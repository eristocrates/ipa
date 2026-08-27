namespace https.w3id.org.earthsemantics.OSO.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oso =
    let _namespace_iri = Namespace_Iri oso |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#NewHebridesSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Vanuatu Trench Site"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#NewHebridesSite">https://w3id.org/earthsemantics/OSO#NewHebridesSite</seealso>
    let NewHebridesSite = Prefixed_Name(oso, "NewHebridesSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#New_Caledonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"New Caledonia"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#New_Caledonia">https://w3id.org/earthsemantics/OSO#New_Caledonia</seealso>
    let New_Caledonia = Prefixed_Name(oso, "New_Caledonia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nice</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Nice"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nice">https://w3id.org/earthsemantics/OSO#Nice</seealso>
    let Nice = Prefixed_Name(oso, "Nice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nice_East_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Nice East station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nice_East_station">https://w3id.org/earthsemantics/OSO#Nice_East_station</seealso>
    let Nice_East_station = Prefixed_Name(oso, "Nice_East_station") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nice_West_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Nice West station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nice_West_station">https://w3id.org/earthsemantics/OSO#Nice_West_station</seealso>
    let Nice_West_station = Prefixed_Name(oso, "Nice_West_station") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#NorEMSO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NorEMSO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#NorEMSO">https://w3id.org/earthsemantics/OSO#NorEMSO</seealso>
    let NorEMSO = Prefixed_Name(oso, "NorEMSO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nordic_Seas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>"L’infrastructure régionale Nordic Seas comprend 5 sections de planeurs océaniques, 4 sites de mouillages et un observatoire multi-réseaux. Elle combine des dispositifs de suivi existants, étendus, avec de nouvelles installations, afin d’améliorer la compréhension du rôle des Nordic Seas dans le système climatique global. Les recherches pluridisciplinaires portent notamment sur :
    ///
    ///                              Transport de l’eau, circulation et propriétés des masses d’eau des Nordic Seas
    ///                              Biogéochimie sous-surface • Émissions de méthane depuis le fond marin
    ///                              Variabilité des fronts entre eaux polaires et atlantiques
    ///                              Caractérisation géophysique, océanographique et écologique d’une source hydrothermale
    ///
    ///                              L’activité est présentée sur la carte : transects de planeurs (lignes rouges), mouillages (cercles blancs : Svinøy, Station M, South Cape, Fram Strait) et observatoire multi-réseaux (EMSO-Mohn).
    ///
    ///                              Disciplines EMSO : océanographie physique, biogéochimie, écologie marine (en cours de développement)"</para>
    ///   <para>"Οι περιφερειακές εγκαταστάσεις Nordic Seas περιλαμβάνουν 5 διαδρομές ωκεάνιων ανεμοπτερίων, 4 σταθμούς αγκυροβολημένων οργάνων και ένα πολυστοιχειακό παρατηρητήριο. Η εγκατάσταση αποτελεί συνδυασμό υφιστάμενων στοιχείων παρακολούθησης, τα οποία επεκτείνονται, και νέων υποδομών, με κύριο στόχο τη βελτίωση της κατανόησης του ρόλου των Nordic Seas στο παγκόσμιο κλιματικό σύστημα. Ειδικότερα, η διεπιστημονική έρευνα που διεξάγεται στην περιφερειακή εγκατάσταση Nordic Seas εστιάζει στα εξής:
    ///
    ///                              Μεταφορά υδάτων, κυκλοφορία και ιδιότητες των υδάτινων μαζών των Nordic Seas
    ///                              Υποθαλάσσια βιογεωχημεία • Εκπομπές μεθανίου από τον θαλάσσιο πυθμένα
    ///                              Μεταβλητότητα των μετώπων μεταξύ πολικών και ατλαντικών υδάτων
    ///                              Γεωφυσικός, ωκεανογραφικός και οικολογικός χαρακτηρισμός υδροθερμικού αναβλύσματος
    ///
    ///                              Η δραστηριότητα της περιφερειακής εγκατάστασης Nordic Seas παρουσιάζεται στον χάρτη, όπου οι διαδρομές των ανεμοπτερίων απεικονίζονται με κόκκινες γραμμές και αριθμούς, οι σταθμοί αγκυροβολημένων οργάνων με λευκούς κύκλους (Svinøy, Station M, South Cape, Fram Strait), και το πολυστοιχειακό παρατηρητήριο με λευκό κύκλο (EMSO-Mohn).
    ///
    ///                              Επιστημονικοί τομείς EMSO: φυσική ωκεανογραφία, βιογεωχημεία, θαλάσσια οικολογία (υπό σχεδιασμό)"</para>
    ///   <para>"Infrastructura regională Nordic Seas include 5 secțiuni de glidere oceanice, 4 stații de ancorare și un observator multi-array. Aceasta combină componente de monitorizare existente, extinse, cu noi instalații, având ca obiectiv îmbunătățirea înțelegerii rolului Nordic Seas în sistemul climatic global. Cercetarea se concentrează pe:
    ///
    ///                              Transportul apei, circulația și proprietățile maselor de apă
    ///                              Biogeochimia sub-suprafață • Emisia de metan de pe fundul mării
    ///                              Variabilitatea fronturilor între ape polare și atlantice
    ///                              Caracterizarea geofizică, oceanografică și ecologică a unei surse hidrotermale
    ///
    ///                              Activitatea este ilustrată pe hartă: glidere (linii roșii), ancoraje (cercuri albe) și observatorul (EMSO-Mohn).
    ///
    ///                              Domenii EMSO: oceanografie fizică, biogeochimie, ecologie marină (planificată)"</para>
    ///   <para>"A infraestrutura regional Nordic Seas inclui 5 secções de gliders oceânicos, 4 estações de amarração e um observatório multi-array. Combina componentes de monitorização existentes, ampliados, com novas instalações, com o objetivo de melhorar a compreensão do papel dos Nordic Seas no sistema climático global. A investigação centra-se em:
    ///
    ///                              Transporte de água, circulação e propriedades das massas de água
    ///                              Biogeoquímica subsuperficial • Libertação de metano do fundo marinho
    ///                              Variabilidade das frentes entre águas polares e atlânticas
    ///                              Caracterização geofísica, oceanográfica e ecológica de fontes hidrotermais
    ///
    ///                              A atividade é apresentada no mapa com transectos (linhas vermelhas), amarrações (círculos brancos) e observatório (EMSO-Mohn).
    ///
    ///                              Disciplinas EMSO: oceanografia física, biogeoquímica, ecologia marinha (planeada)"</para>
    ///   <para>"L’infrastruttura regionale Nordic Seas comprende 5 sezioni di glider oceanici, 4 siti di ormeggio e un osservatorio multi-array. Combina componenti di monitoraggio esistenti, ampliati, con nuove installazioni, con l’obiettivo di migliorare la comprensione del ruolo dei Nordic Seas nel sistema climatico globale. In particolare, la ricerca multidisciplinare si concentra su:
    ///
    ///                              Trasporto dell’acqua, circolazione e proprietà delle masse d’acqua dei Nordic Seas
    ///                              Biogeochimica sub-superficiale • Rilascio di metano dal fondale
    ///                              Variabilità dei fronti tra acque polari e atlantiche
    ///                              Caratterizzazione geofisica, oceanografica ed ecologica di una sorgente idrotermale
    ///
    ///                              L’attività è illustrata nella mappa: transect dei glider (linee rosse), ormeggi (cerchi bianchi) e osservatorio multi-array (EMSO-Mohn).
    ///
    ///                              Discipline EMSO: oceanografia fisica, biogeochimica, ecologia marina (in pianificazione)"</para>
    ///   <para>"The Nordic Seas regional facility comprises 5 ocean glider sections, 4 mooring sites, and one multi-array observatory. The facility combines existing monitoring components, which are expanded, with new installations, with the main aim of improving understanding of the role of the Nordic Seas in the global climate system. In particular, the multidisciplinary research conducted at the Nordic Seas regional facility focuses on:
    ///
    ///                              Water transport, circulation and water mass properties of the Nordic Seas
    ///                              Sub-surface biogeochemistry • Methane release from the seafloor
    ///                              Front variability between Polar and Atlantic waters
    ///                              Geophysical, oceanographic and ecological characterization of a hydrothermal vent
    ///
    ///                              The activity of the Nordic Seas regional facility is illustrated on the map, where ocean glider transects are shown as red lines and numbers, mooring sites as white circles (Svinøy, Station M, South Cape, Fram Strait), and the multi-array observatory as a white circle (EMSO-Mohn).
    ///
    ///                              EMSO scientific disciplines: physical oceanography, biogeochemistry, marine ecology (planned)"</para>
    ///   <para>"Den regionale infrastrukturen Nordic Seas omfatter 5 seksjoner med havglidere, 4 fortøyningsstasjoner og ett multi-array observatorium. Den kombinerer eksisterende overvåkingskomponenter, som utvides, med nye installasjoner, med mål om å forbedre forståelsen av Nordic Seas sin rolle i det globale klimasystemet. Forskningen fokuserer på:
    ///
    ///                              Vanntransport, sirkulasjon og egenskaper til vannmassene i Nordic Seas
    ///                              Biogeokjemi under overflaten • Metanutslipp fra havbunnen
    ///                              Variabilitet i fronter mellom polare og atlantiske vannmasser
    ///                              Geofysisk, oseanografisk og økologisk karakterisering av hydrotermale kilder
    ///
    ///                              Aktiviteten vises på kartet med gliderbaner (røde linjer), fortøyninger (hvite sirkler) og observatorium (EMSO-Mohn).
    ///
    ///                              EMSO-fagområder: fysisk oseanografi, biogeokjemi, marin økologi (planlagt)"</para>
    ///   <para>"La infraestructura regional Nordic Seas comprende 5 secciones de planeadores oceánicos, 4 estaciones de fondeo y un observatorio multi-array. Combina componentes de monitorización existentes, ampliados, con nuevas instalaciones, con el objetivo principal de mejorar la comprensión del papel de los Nordic Seas en el sistema climático global. En particular, la investigación multidisciplinar se centra en:
    ///
    ///                              Transporte de agua, circulación y propiedades de las masas de agua de los Nordic Seas
    ///                              Biogeoquímica subsuperficial • Emisiones de metano desde el fondo marino
    ///                              Variabilidad de los frentes entre aguas polares y atlánticas
    ///                              Caracterización geofísica, oceanográfica y ecológica de una fuente hidrotermal
    ///
    ///                              La actividad se muestra en el mapa, donde los transectos de planeadores se indican con líneas rojas y números, los fondeos con círculos blancos (Svinøy, Station M, South Cape, Fram Strait) y el observatorio multi-array con un círculo blanco (EMSO-Mohn).
    ///
    ///                              Disciplinas científicas EMSO: oceanografía física, biogeoquímica, ecología marina (planificada)"</para>
    /// labels<para>"Nordic Seas"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nordic_Seas">https://w3id.org/earthsemantics/OSO#Nordic_Seas</seealso>
    let Nordic_Seas = Prefixed_Name(oso, "Nordic_Seas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nordic_Seas_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nordic_Seas_EMSO_membership">https://w3id.org/earthsemantics/OSO#Nordic_Seas_EMSO_membership</seealso>
    let Nordic_Seas_EMSO_membership =
        Prefixed_Name(oso, "Nordic_Seas_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Norvegia"</para><para>"Norvège"</para><para>"Νορβηγία"</para><para>"Norge"</para><para>"Noruega"</para><para>"Norway"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Norway">https://w3id.org/earthsemantics/OSO#Norway</seealso>
    let Norway = Prefixed_Name(oso, "Norway") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OBSEA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"WMO ID 6103565"</para>
    /// labels<para>"OBSEA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OBSEA">https://w3id.org/earthsemantics/OSO#OBSEA</seealso>
    let OBSEA = Prefixed_Name(oso, "OBSEA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OBSEA_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"OBSEA buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OBSEA_buoy">https://w3id.org/earthsemantics/OSO#OBSEA_buoy</seealso>
    let OBSEA_buoy = Prefixed_Name(oso, "OBSEA_buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OBSEA_seabed_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"OBSEA seabed station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OBSEA_seabed_station">https://w3id.org/earthsemantics/OSO#OBSEA_seabed_station</seealso>
    let OBSEA_seabed_station =
        Prefixed_Name(oso, "OBSEA_seabed_station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ODASItalia1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ODAS Italia 1"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ODASItalia1">https://w3id.org/earthsemantics/OSO#ODASItalia1</seealso>
    let ODASItalia1 = Prefixed_Name(oso, "ODASItalia1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OGS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"OGS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OGS">https://w3id.org/earthsemantics/OSO#OGS</seealso>
    let OGS = Prefixed_Name(oso, "OGS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ObsoleteClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Root class grouping deprecated OSO classes."</para>
    ///   <para>"Classe raiz que agrupa as classes OSO obsoletas."</para>
    ///   <para>"Rotklasse som grupperer foreldede OSO-klasser."</para>
    ///   <para>"Clase raíz que agrupa las clases OSO obsoletas."</para>
    ///   <para>"Classe racine regroupant les classes OSO obsolètes."</para>
    ///   <para>"Ριζική κλάση που ομαδοποιεί τις παρωχημένες κλάσεις του OSO."</para>
    ///   <para>"Clasă rădăcină care grupează clasele OSO învechite."</para>
    ///   <para>"Classe radice che raggruppa le classi OSO obsolete."</para>
    /// labels<para>"Obsolete class"</para><para>"Clase obsoleta"</para><para>"Clasă învechită"</para><para>"Classe obsolète"</para><para>"Classe obsoleta"</para><para>"Παρωχημένη κλάση"</para><para>"Foreldet klasse"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ObsoleteClass">https://w3id.org/earthsemantics/OSO#ObsoleteClass</seealso>
    let ObsoleteClass = Prefixed_Name(oso, "ObsoleteClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ocean_Network_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ocean Networks Canada"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ocean_Network_Canada">https://w3id.org/earthsemantics/OSO#Ocean_Network_Canada</seealso>
    let Ocean_Network_Canada =
        Prefixed_Name(oso, "Ocean_Network_Canada") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An oceanographic campaign linked to a Regional Facility"</para>
    ///   <para>"Μια ωκεανογραφική εκστρατεία που συνδέεται με μια περιφερειακή υποδομή"</para>
    ///   <para>"Una campagna oceanografica collegata a una struttura regionale"</para>
    ///   <para>"En havforskningskampanje knyttet til en regional infrastruktur"</para>
    ///   <para>"O campanie oceanografică asociată unei infrastructuri regionale"</para>
    ///   <para>"Uma campanha oceanográfica associada a uma infraestrutura regional"</para>
    ///   <para>"Una campaña oceanográfica vinculada a una instalación regional"</para>
    ///   <para>"Une campagne océanographique liée à un noeud régional"</para>
    /// labels<para>"Campagne océanographique"</para><para>"Kampanje"</para><para>"Campanha oceanográfica"</para><para>"Campaña oceanográfica"</para><para>"Ωκεανογραφική εκστρατεία"</para><para>"Campanie oceanografică"</para><para>"Cruise"</para><para>"Campagna oceanografica"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OceanographicCampaign">https://w3id.org/earthsemantics/OSO#OceanographicCampaign</seealso>
    let OceanographicCampaign =
        Prefixed_Name(oso, "OceanographicCampaign") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Office_fran%C3%A7ais_de_la_biodiversit%C3%A9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"Oficiul Francez pentru Biodiversitate"</para><para>"Oficina Francesa de la Biodiversidad"</para><para>"Office français de la biodiversité"</para><para>"French Office for Biodiversity"</para><para>"Escritório Francês para a Biodiversidade"</para><para>"Franske biodiversitetskontoret"</para><para>"Ufficio francese per la biodiversità"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Office_fran%C3%A7ais_de_la_biodiversit%C3%A9">https://w3id.org/earthsemantics/OSO#Office_fran%C3%A7ais_de_la_biodiversit%C3%A9</seealso>
    let ``Office_fran%C3%A7ais_de_la_biodiversit%C3%A9`` =
        Prefixed_Name(oso, "Office_fran%C3%A7ais_de_la_biodiversit%C3%A9") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#OntologyEngineeringWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>nsprov:Activity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Samarbeidende ontologiutvikling innen EMSO Data Management Service Group (DMSG)"</para><para>"Ingénierie collaborative de l’ontologie au sein de l'EMSO Data Management Service Group (DMSG)"</para><para>"Συνεργατική μηχανική οντολογιών στο EMSO Data Management Service Group (DMSG)"</para><para>"Engenharia colaborativa de ontologias no EMSO Data Management Service Group (DMSG)"</para><para>"Inginerie colaborativă a ontologiilor în cadrul EMSO Data Management Service Group (DMSG)"</para><para>"Collaborative ontology engineering within the EMSO Data Management Service Group (DMSG)"</para><para>"Ingegneria collaborativa dell'ontologia all'interno dell'EMSO Data Management Service Group (DMSG)"</para><para>"Ingeniería colaborativa de ontologías dentro del EMSO Data Management Service Group (DMSG)"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#OntologyEngineeringWorkflow">https://w3id.org/earthsemantics/OSO#OntologyEngineeringWorkflow</seealso>
    let OntologyEngineeringWorkflow =
        Prefixed_Name(oso, "OntologyEngineeringWorkflow") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PAP_Central_Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PAP Central Site"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PAP_Central_Site">https://w3id.org/earthsemantics/OSO#PAP_Central_Site</seealso>
    let PAP_Central_Site = Prefixed_Name(oso, "PAP_Central_Site") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PAP_H4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"H4"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PAP_H4">https://w3id.org/earthsemantics/OSO#PAP_H4</seealso>
    let PAP_H4 = Prefixed_Name(oso, "PAP_H4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PAP_P4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"P4"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PAP_P4">https://w3id.org/earthsemantics/OSO#PAP_P4</seealso>
    let PAP_P4 = Prefixed_Name(oso, "PAP_P4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PI_Molene_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PI_Molene_AutonomousDevices">https://w3id.org/earthsemantics/OSO#PI_Molene_AutonomousDevices</seealso>
    let PI_Molene_AutonomousDevices =
        Prefixed_Name(oso, "PI_Molene_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PI_PoulmicPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PI_PoulmicPlatform">https://w3id.org/earthsemantics/OSO#PI_PoulmicPlatform</seealso>
    let PI_PoulmicPlatform = Prefixed_Name(oso, "PI_PoulmicPlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PI_SubmarinePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PI_SubmarinePlatform">https://w3id.org/earthsemantics/OSO#PI_SubmarinePlatform</seealso>
    let PI_SubmarinePlatform =
        Prefixed_Name(oso, "PI_SubmarinePlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PLOCAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"O Ministério da Economia e Competitividade (MINECO) está representado no EMSO pelo PLOCAN."</para>
    ///   <para>"Il Ministero dell’Economia e della Competitività (MINECO) è rappresentato in EMSO da PLOCAN."</para>
    ///   <para>"Departementet for økonomi og konkurranseevne (MINECO) er representert i EMSO av PLOCAN."</para>
    ///   <para>"The Ministry of Economy and Competitiveness (MINECO) is represented within EMSO by PLOCAN."</para>
    ///   <para>"El Ministerio de Economía y Competitividad (MINECO) está representado en EMSO por PLOCAN."</para>
    ///   <para>"Το Υπουργείο Οικονομίας και Ανταγωνιστικότητας (MINECO) εκπροσωπείται στο EMSO από το PLOCAN."</para>
    ///   <para>"Le ministère de l’Économie et de la Compétitivité (MINECO) est représenté au sein d’EMSO par PLOCAN."</para>
    ///   <para>"Ministerul Economiei și Competitivității (MINECO) este reprezentat în EMSO de PLOCAN."</para>
    /// labels<para>"PLOCAN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PLOCAN">https://w3id.org/earthsemantics/OSO#PLOCAN</seealso>
    let PLOCAN = Prefixed_Name(oso, "PLOCAN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PYLOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PYLOS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PYLOS">https://w3id.org/earthsemantics/OSO#PYLOS</seealso>
    let PYLOS = Prefixed_Name(oso, "PYLOS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PYLOS_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PYLOS Buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PYLOS_Mooring">https://w3id.org/earthsemantics/OSO#PYLOS_Mooring</seealso>
    let PYLOS_Mooring = Prefixed_Name(oso, "PYLOS_Mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#PYLOS_Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"PYLOS Platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#PYLOS_Platform">https://w3id.org/earthsemantics/OSO#PYLOS_Platform</seealso>
    let PYLOS_Platform = Prefixed_Name(oso, "PYLOS_Platform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Pacific_Peering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"Pacific Peering"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Pacific_Peering">https://w3id.org/earthsemantics/OSO#Pacific_Peering</seealso>
    let Pacific_Peering = Prefixed_Name(oso, "Pacific_Peering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Patrice_BRETEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Patrice BRETEL"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Patrice_BRETEL">https://w3id.org/earthsemantics/OSO#Patrice_BRETEL</seealso>
    let Patrice_BRETEL = Prefixed_Name(oso, "Patrice_BRETEL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Paulo_RELVAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Paulo RELVAS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Paulo_RELVAS">https://w3id.org/earthsemantics/OSO#Paulo_RELVAS</seealso>
    let Paulo_RELVAS = Prefixed_Name(oso, "Paulo_RELVAS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Pierre_HENRY</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pierre HENRY"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Pierre_HENRY">https://w3id.org/earthsemantics/OSO#Pierre_HENRY</seealso>
    let Pierre_HENRY = Prefixed_Name(oso, "Pierre_HENRY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Planned</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Σχεδιαζόμενο"</para><para>"Planlagt"</para><para>"Planificat"</para><para>"Planeado"</para><para>"Planifié"</para><para>"Planificado"</para><para>"Pianificato"</para><para>"Planned"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Planned">https://w3id.org/earthsemantics/OSO#Planned</seealso>
    let Planned = Prefixed_Name(oso, "Planned") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"O platformă de observație, fixă sau mobilă, instalată într-un site sau subsite, care suportă unul sau mai multe instrumente sau sisteme de achiziție."</para>
    ///   <para>"En observasjonsplattform, fast eller mobil, installert på et sted eller underområde, som støtter ett eller flere instrumenter eller innhentingssystemer."</para>
    ///   <para>"An observation platform, fixed or mobile, installed on a site or subsite, supporting one or more instruments or acquisition systems."</para>
    ///   <para>"Μια πλατφόρμα παρατήρησης, σταθερή ή κινητή, εγκατεστημένη σε έναν τόπο ή υποτοποθεσία, υποστηρίζοντας ένα ή περισσότερα όργανα ή συστήματα συλλογής δεδομένων."</para>
    ///   <para>"Una piattaforma di osservazione, fissa o mobile, installata su un sito o sotto-sito, che supporta uno o più strumenti o sistemi di acquisizione."</para>
    ///   <para>"Una plataforma de observación, fija o móvil, instalada en un sitio o sub-sitio, que soporta uno o más instrumentos o sistemas de adquisición."</para>
    ///   <para>"Une plateforme d'observation fixe ou mobile, installée sur un site ou un sous-site, supportant un ou plusieurs instruments ou systèmes d'acquisition."</para>
    ///   <para>"Uma plataforma de observação, fixa ou móvel, instalada num local ou sublocal, suportando um ou mais instrumentos ou sistemas de aquisição."</para>
    /// labels<para>"Platformă de observație"</para><para>"Plataforma de observación"</para><para>"Plateforme d'observation"</para><para>"Observation Platform"</para><para>"Plataforma de observação"</para><para>"Πλατφόρμα παρατήρησης"</para><para>"Piattaforma di osservazione"</para><para>"Observasjonsplattform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Platform">https://w3id.org/earthsemantics/OSO#Platform</seealso>
    let Platform = Prefixed_Name(oso, "Platform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Platform_contains_Subplatforms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Platform_contains_Subplatforms">https://w3id.org/earthsemantics/OSO#Platform_contains_Subplatforms</seealso>
    let Platform_contains_Subplatforms =
        Prefixed_Name(oso, "Platform_contains_Subplatforms") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Porcupine_Abyssal_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Porcupine Abyssal Plain"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain">https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain</seealso>
    let Porcupine_Abyssal_Plain =
        Prefixed_Name(oso, "Porcupine_Abyssal_Plain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Porcupine_Abyssal_Plain_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain_EMSO_membership">https://w3id.org/earthsemantics/OSO#Porcupine_Abyssal_Plain_EMSO_membership</seealso>
    let Porcupine_Abyssal_Plain_EMSO_membership =
        Prefixed_Name(oso, "Porcupine_Abyssal_Plain_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Portugal"</para><para>"Πορτογαλία"</para><para>"Portogallo"</para><para>"Portugalia"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Portugal">https://w3id.org/earthsemantics/OSO#Portugal</seealso>
    let Portugal = Prefixed_Name(oso, "Portugal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Poulmic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Poulmic"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Poulmic">https://w3id.org/earthsemantics/OSO#Poulmic</seealso>
    let Poulmic = Prefixed_Name(oso, "Poulmic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Poulmic_Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Poulmic Platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Poulmic_Platform">https://w3id.org/earthsemantics/OSO#Poulmic_Platform</seealso>
    let Poulmic_Platform = Prefixed_Name(oso, "Poulmic_Platform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Project_is_led_by_an_Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the organization responsible for leading or coordinating a research project."</para>
    ///   <para>"Indique l'organisation responsable de la direction ou de la coordination d’un projet de recherche."</para>
    /// labels<para>"Project is led by an organisation"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Project_is_led_by_an_Organization">https://w3id.org/earthsemantics/OSO#Project_is_led_by_an_Organization</seealso>
    let Project_is_led_by_an_Organization =
        Prefixed_Name(oso, "Project_is_led_by_an_Organization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"R1"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R1">https://w3id.org/earthsemantics/OSO#R1</seealso>
    let R1 = Prefixed_Name(oso, "R1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R1_SmartCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"R1 SmartCable"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R1_SmartCable">https://w3id.org/earthsemantics/OSO#R1_SmartCable</seealso>
    let R1_SmartCable = Prefixed_Name(oso, "R1_SmartCable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"R2"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R2">https://w3id.org/earthsemantics/OSO#R2</seealso>
    let R2 = Prefixed_Name(oso, "R2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R2_SmartCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"R2 SmartCable"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R2_SmartCable">https://w3id.org/earthsemantics/OSO#R2_SmartCable</seealso>
    let R2_SmartCable = Prefixed_Name(oso, "R2_SmartCable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"R3"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R3">https://w3id.org/earthsemantics/OSO#R3</seealso>
    let R3 = Prefixed_Name(oso, "R3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#R3_SmartCable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"R3 SmartCable"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#R3_SmartCable">https://w3id.org/earthsemantics/OSO#R3_SmartCable</seealso>
    let R3_SmartCable = Prefixed_Name(oso, "R3_SmartCable") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#REVOSIMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///
    /// labels<para>"REVOSIMA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#REVOSIMA">https://w3id.org/earthsemantics/OSO#REVOSIMA</seealso>
    let REVOSIMA = Prefixed_Name(oso, "REVOSIMA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Infrastructură regională care conține site-uri, asociată cu infrastructuri de cercetare, campanii oceanografice, organizații și un lider de echipă regional."</para>
    ///   <para>"A regional facility containing sites, associated with research infrastructures, oceanographic campaigns, organizations, and a Regional Team Leader."</para>
    ///   <para>"Περιφερειακή υποδομή που περιλαμβάνει τοποθεσίες, συνδέεται με ερευνητικές υποδομές, ωκεανογραφικές εκστρατείες, οργανισμούς και έναν υπεύθυνο ομάδας."</para>
    ///   <para>"Infraestructura regional que contiene sitios, asociada a infraestructuras de investigación, campañas oceanográficas, organizaciones y un líder de equipo regional."</para>
    ///   <para>"Regional fasilitet som inneholder lokaliteter, tilknyttet forskningsinfrastrukturer, havkampanjer, organisasjoner og en regionalt ansvarlig."</para>
    ///   <para>"Infrastruttura regionale contenente siti, associata a infrastrutture di ricerca, campagne oceanografiche, organizzazioni e un coordinatore regionale."</para>
    ///   <para>"Une noeud régional comprenant plusieurs sites, liée à des infrastructures de recherche, des campagnes océanographiques, des organisations et un coordinateur régional."</para>
    ///   <para>"Infraestrutura regional que contém locais, associada a infraestruturas de investigação, campanhas oceanográficas, organizações e um líder regional."</para>
    /// labels<para>"Infrastruttura regionale"</para><para>"Infraestrutura regional"</para><para>"Regional Facility"</para><para>"Nœud régional"</para><para>"Infrastructură regională"</para><para>"Infraestructura regional"</para><para>"Περιφερειακή υποδομή"</para><para>"Regional fasilitet"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalFacility">https://w3id.org/earthsemantics/OSO#RegionalFacility</seealso>
    let RegionalFacility = Prefixed_Name(oso, "RegionalFacility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility_is_linked_to_a_project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Regional Facility is linked to a project"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalFacility_is_linked_to_a_project">https://w3id.org/earthsemantics/OSO#RegionalFacility_is_linked_to_a_project</seealso>
    let RegionalFacility_is_linked_to_a_project =
        Prefixed_Name(oso, "RegionalFacility_is_linked_to_a_project") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacilityisRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is related to zero or more Research Infrastructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Regional Facility is related to a Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisRelatedTo">https://w3id.org/earthsemantics/OSO#RegionalFacilityisRelatedTo</seealso>
    let RegionalFacilityisRelatedTo =
        Prefixed_Name(oso, "RegionalFacilityisRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacilityisledby</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Research Infrastructure is led by"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalFacilityisledby">https://w3id.org/earthsemantics/OSO#RegionalFacilityisledby</seealso>
    let RegionalFacilityisledby =
        Prefixed_Name(oso, "RegionalFacilityisledby") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacilityispartofRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Regional Facility is part of a Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalFacilityispartofRI">https://w3id.org/earthsemantics/OSO#RegionalFacilityispartofRI</seealso>
    let RegionalFacilityispartofRI =
        Prefixed_Name(oso, "RegionalFacilityispartofRI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#RegionalTeamLeaderIroise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#RegionalTeamLeaderIroise">https://w3id.org/earthsemantics/OSO#RegionalTeamLeaderIroise</seealso>
    let RegionalTeamLeaderIroise =
        Prefixed_Name(oso, "RegionalTeamLeaderIroise") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research infrastructure may bring together one or more Regional Facilities"</para>
    /// labels<para>"Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ResearchInfrastructure">https://w3id.org/earthsemantics/OSO#ResearchInfrastructure</seealso>
    let ResearchInfrastructure =
        Prefixed_Name(oso, "ResearchInfrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ResearchProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una actividad científica estructurada destinada a producir nuevo conocimiento, datos o comprensión dentro de un alcance y una duración definidos."</para>
    ///   <para>"O activitate științifică structurată destinată să producă noi cunoștințe, date sau înțelegere într-un cadru și o durată definite."</para>
    ///   <para>"En strukturert vitenskapelig aktivitet som har som mål å produsere ny kunnskap, data eller forståelse innenfor et definert omfang og tidsrom."</para>
    ///   <para>"Un'attività scientifica strutturata progettata per produrre nuova conoscenza, dati o comprensione entro un ambito e una durata definiti."</para>
    ///   <para>"Uma atividade científica estruturada concebida para produzir novo conhecimento, dados ou compreensão dentro de um âmbito e duração definidos."</para>
    ///   <para>"A structured scientific activity designed to produce new knowledge, data, or understanding within a defined scope and duration."</para>
    ///   <para>"Επιστημονική δραστηριότητα με σαφή δομή που αποσκοπεί στην παραγωγή νέας γνώσης, δεδομένων ή κατανόησης, εντός καθορισμένου πλαισίου και διάρκειας."</para>
    ///   <para>"Une activité scientifique structurée visant à produire de nouvelles connaissances, données ou compréhensions dans un périmètre et une durée définis."</para>
    /// labels<para>"Proyecto de investigación"</para><para>"Forskningsprosjekt"</para><para>"Proiect de cercetare"</para><para>"Projet de recherche"</para><para>"Ερευνητικό έργο"</para><para>"Projeto de investigação"</para><para>"Progetto di ricerca"</para><para>"Research project"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ResearchProject">https://w3id.org/earthsemantics/OSO#ResearchProject</seealso>
    let ResearchProject = Prefixed_Name(oso, "ResearchProject") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Research_Council_of_Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Kingdom of Norway is represented in EMSO by the Research Council of Norway."</para>
    ///   <para>"Le Royaume de Norvège est représenté au sein d’EMSO par le Conseil de la recherche de Norvège."</para>
    ///   <para>"El Reino de Noruega está representado en EMSO por el Consejo de Investigación de Noruega."</para>
    ///   <para>"Regatul Norvegiei este reprezentat în EMSO de Consiliul de Cercetare al Norvegiei."</para>
    ///   <para>"Το Βασίλειο της Νορβηγίας εκπροσωπείται στο EMSO από το Ερευνητικό Συμβούλιο της Νορβηγίας."</para>
    ///   <para>"Kongeriket Norge er representert i EMSO av Norges forskningsråd."</para>
    ///   <para>"Il Regno di Norvegia è rappresentato in EMSO dal Consiglio della ricerca della Norvegia."</para>
    ///   <para>"O Reino da Noruega é representado no EMSO pelo Conselho de Investigação da Noruega."</para>
    /// labels<para>"Research Council of Norway"</para><para>"Norges forskningsråd"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Research_Council_of_Norway">https://w3id.org/earthsemantics/OSO#Research_Council_of_Norway</seealso>
    let Research_Council_of_Norway =
        Prefixed_Name(oso, "Research_Council_of_Norway") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Roberto_BOZZANO</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Roberto BOZZANO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Roberto_BOZZANO">https://w3id.org/earthsemantics/OSO#Roberto_BOZZANO</seealso>
    let Roberto_BOZZANO = Prefixed_Name(oso, "Roberto_BOZZANO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ρουμανία"</para><para>"Roumanie"</para><para>"Romania"</para><para>"Roménia"</para><para>"România"</para><para>"Rumanía"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Romania">https://w3id.org/earthsemantics/OSO#Romania</seealso>
    let Romania = Prefixed_Name(oso, "Romania") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#S%C3%A9bastien_GARZIGLIA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Sébastien GARZIGLIA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#S%C3%A9bastien_GARZIGLIA">https://w3id.org/earthsemantics/OSO#S%C3%A9bastien_GARZIGLIA</seealso>
    let ``S%C3%A9bastien_GARZIGLIA`` =
        Prefixed_Name(oso, "S%C3%A9bastien_GARZIGLIA") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#S%C3%A9verine_MARTINI</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Séverine MARTINI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#S%C3%A9verine_MARTINI">https://w3id.org/earthsemantics/OSO#S%C3%A9verine_MARTINI</seealso>
    let ``S%C3%A9verine_MARTINI`` =
        Prefixed_Name(oso, "S%C3%A9verine_MARTINI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SN-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SN-4"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SN-4">https://w3id.org/earthsemantics/OSO#SN-4</seealso>
    let SN_4 = Prefixed_Name(oso, "SN-4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SN1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SN1"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SN1">https://w3id.org/earthsemantics/OSO#SN1</seealso>
    let SN1 = Prefixed_Name(oso, "SN1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SN1_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SN1 Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SN1_Seabed_Station">https://w3id.org/earthsemantics/OSO#SN1_Seabed_Station</seealso>
    let SN1_Seabed_Station = Prefixed_Name(oso, "SN1_Seabed_Station") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Sapin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Sapin"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Sapin">https://w3id.org/earthsemantics/OSO#Sapin</seealso>
    let Sapin = Prefixed_Name(oso, "Sapin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ScInObs</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ScInObs (Science, Innovation et Observatoires sous-marins)"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ScInObs">https://w3id.org/earthsemantics/OSO#ScInObs</seealso>
    let ScInObs = Prefixed_Name(oso, "ScInObs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SeaMoNEast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"SeaMoN East"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SeaMoNEast">https://w3id.org/earthsemantics/OSO#SeaMoNEast</seealso>
    let SeaMoNEast = Prefixed_Name(oso, "SeaMoNEast") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SeaMoNWest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"SeaMoN West"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SeaMoNWest">https://w3id.org/earthsemantics/OSO#SeaMoNWest</seealso>
    let SeaMoNWest = Prefixed_Name(oso, "SeaMoNWest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uma série de campanhas oceanográficas associadas a uma infraestrutura regional."</para>
    ///   <para>"A series of oceanographic campaigns linked to a Regional Facility."</para>
    ///   <para>"O serie de campanii oceanografice asociate unei infrastructuri regionale."</para>
    ///   <para>"Una serie de campañas oceanográficas vinculadas a una instalación regional."</para>
    ///   <para>"En serie med havforskningskampanjer knyttet til en regional infrastruktur."</para>
    ///   <para>"Una serie di campagne oceanografiche collegate a una struttura regionale."</para>
    ///   <para>"Μια σειρά από ωκεανογραφικές εκστρατείες που συνδέονται με μια περιφερειακή υποδομή"</para>
    ///   <para>"Une série de campagnes océanographiques liées à un noeud régional."</para>
    /// labels<para>"Serie de campañas oceanográficas"</para><para>"Series of Oceanographic Campaigns"</para><para>"Serie de campanii oceanografice"</para><para>"Serie med havforskningskampanjer"</para><para>"Série de campagnes océanographiques"</para><para>"Série de campanhas oceanográficas"</para><para>"Σειρά ωκεανογραφικών εκστρατειών"</para><para>"Serie di campagne oceanografiche"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SeriesOfOceanographicCampaigns">https://w3id.org/earthsemantics/OSO#SeriesOfOceanographicCampaigns</seealso>
    let SeriesOfOceanographicCampaigns =
        Prefixed_Name(oso, "SeriesOfOceanographicCampaigns") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Sintra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Sintra"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Sintra">https://w3id.org/earthsemantics/OSO#Sintra</seealso>
    let Sintra = Prefixed_Name(oso, "Sintra") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un sito osservatorio localizzato, collegato a una struttura regionale, che può ospitare una o più piattaforme di misura."</para>
    ///   <para>"Un site observator localizat, asociat cu o facilitate regională, care poate găzdui una sau mai multe platforme de măsurare."</para>
    ///   <para>"A localized observatory site, attached to a regional facility, potentially hosting one or more measurement platforms."</para>
    ///   <para>"Et lokalisert observasjonssted tilknyttet en regional fasilitet, som potensielt huser en eller flere måleplattformer."</para>
    ///   <para>"Un site observatoire localisé, rattaché à un nœud régional, pouvant accueillir une ou plusieurs plateformes de mesure."</para>
    ///   <para>"Um local de observação localizado, associado a uma infraestrutura regional, podendo acolher uma ou mais plataformas de medição."</para>
    ///   <para>"Ένας τοπικός τόπος παρατήρησης, συνδεδεμένος με μια περιφερειακή υποδομή, που μπορεί να φιλοξενήσει μία ή περισσότερες πλατφόρμες μέτρησης."</para>
    ///   <para>"Un sitio de observación localizado, vinculado a una infraestructura regional, que puede albergar una o más plataformas de medición."</para>
    /// labels<para>"Observasjonssted"</para><para>"Site d'observation"</para><para>"Sitio de observación"</para><para>"Sito di osservazione"</para><para>"Local de observação"</para><para>"Τόπος παρατήρησης"</para><para>"Observatory Site"</para><para>"Loc de observare"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Site">https://w3id.org/earthsemantics/OSO#Site</seealso>
    let Site = Prefixed_Name(oso, "Site") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SiteLedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Site is led by"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SiteLedBy">https://w3id.org/earthsemantics/OSO#SiteLedBy</seealso>
    let SiteLedBy = Prefixed_Name(oso, "SiteLedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SiteResponsibleMol%C3%A8ne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SiteResponsibleMol%C3%A8ne">https://w3id.org/earthsemantics/OSO#SiteResponsibleMol%C3%A8ne</seealso>
    let ``SiteResponsibleMol%C3%A8ne`` =
        Prefixed_Name(oso, "SiteResponsibleMol%C3%A8ne") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SiteResponsiblePoulmic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SiteResponsiblePoulmic">https://w3id.org/earthsemantics/OSO#SiteResponsiblePoulmic</seealso>
    let SiteResponsiblePoulmic =
        Prefixed_Name(oso, "SiteResponsiblePoulmic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Site_has_Latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Site-ul are latitudine"</para><para>"Nettsted har breddegrad"</para><para>"Τοποθεσία έχει γεωγραφικό πλάτος"</para><para>"Le site a une latitude"</para><para>"El sitio tiene latitud"</para><para>"O local tem latitude"</para><para>"Site has Latitude"</para><para>"Il sito ha latitudine"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Site_has_Latitude">https://w3id.org/earthsemantics/OSO#Site_has_Latitude</seealso>
    let Site_has_Latitude = Prefixed_Name(oso, "Site_has_Latitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Site_has_Longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"Site has Longitude"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Site_has_Longitude">https://w3id.org/earthsemantics/OSO#Site_has_Longitude</seealso>
    let Site_has_Longitude = Prefixed_Name(oso, "Site_has_Longitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Site_has_a_Subsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A site can be associated to one or more subsites"</para>
    /// labels<para>"Site has a subsite"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Site_has_a_Subsite">https://w3id.org/earthsemantics/OSO#Site_has_a_Subsite</seealso>
    let Site_has_a_Subsite = Prefixed_Name(oso, "Site_has_a_Subsite") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Site_is_part_of_a_RI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Site is part of an Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Site_is_part_of_a_RI">https://w3id.org/earthsemantics/OSO#Site_is_part_of_a_RI</seealso>
    let Site_is_part_of_a_RI =
        Prefixed_Name(oso, "Site_is_part_of_a_RI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Smartbay</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Smartbay"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Smartbay">https://w3id.org/earthsemantics/OSO#Smartbay</seealso>
    let Smartbay = Prefixed_Name(oso, "Smartbay") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Smartbay_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Smartbay Buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Smartbay_buoy">https://w3id.org/earthsemantics/OSO#Smartbay_buoy</seealso>
    let Smartbay_buoy = Prefixed_Name(oso, "Smartbay_buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Smartbay_observatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Smartbay Observatory"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Smartbay_observatory">https://w3id.org/earthsemantics/OSO#Smartbay_observatory</seealso>
    let Smartbay_observatory =
        Prefixed_Name(oso, "Smartbay_observatory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SorbonneUniversit%C3%A9</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sorbonne Université"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SorbonneUniversit%C3%A9">https://w3id.org/earthsemantics/OSO#SorbonneUniversit%C3%A9</seealso>
    let ``SorbonneUniversit%C3%A9`` =
        Prefixed_Name(oso, "SorbonneUniversit%C3%A9") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SouthCrystal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Crystal"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SouthCrystal">https://w3id.org/earthsemantics/OSO#SouthCrystal</seealso>
    let SouthCrystal = Prefixed_Name(oso, "SouthCrystal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Adriatic_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mar Adriático meridional"</para><para>"South Adriatic Sea"</para><para>"Mer Adriatique méridionale"</para><para>"Mare Adriatico meridionale"</para><para>"Νότια Αδριατική Θάλασσα"</para><para>"Marea Adriatică de Sud"</para><para>"Sørlige Adriaterhavet"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea">https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea</seealso>
    let South_Adriatic_Sea = Prefixed_Name(oso, "South_Adriatic_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Adriatic_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#South_Adriatic_Sea_EMSO_membership</seealso>
    let South_Adriatic_Sea_EMSO_membership =
        Prefixed_Name(oso, "South_Adriatic_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Cape</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Cape"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Cape">https://w3id.org/earthsemantics/OSO#South_Cape</seealso>
    let South_Cape = Prefixed_Name(oso, "South_Cape") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Cape_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Cape Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Cape_Seabed_Station">https://w3id.org/earthsemantics/OSO#South_Cape_Seabed_Station</seealso>
    let South_Cape_Seabed_Station =
        Prefixed_Name(oso, "South_Cape_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Cape_Subsurface_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"South Cape Subsurface Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Cape_Subsurface_Mooring">https://w3id.org/earthsemantics/OSO#South_Cape_Subsurface_Mooring</seealso>
    let South_Cape_Subsurface_Mooring =
        Prefixed_Name(oso, "South_Cape_Subsurface_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Rockall_Trough</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Νότιο Rockall Trough"</para><para>"Depresiunea sudică Rockall"</para><para>"Fossa sul de Rockall"</para><para>"Fosse sud de Rockall"</para><para>"Sørlige Rockall-renna"</para><para>"Cuenca sur de Rockall"</para><para>"Bacino meridionale di Rockall"</para><para>"South Rockall Trough"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough">https://w3id.org/earthsemantics/OSO#South_Rockall_Trough</seealso>
    let South_Rockall_Trough =
        Prefixed_Name(oso, "South_Rockall_Trough") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#South_Rockall_Trough_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"South Rockall Trough Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#South_Rockall_Trough_Mooring">https://w3id.org/earthsemantics/OSO#South_Rockall_Trough_Mooring</seealso>
    let South_Rockall_Trough_Mooring =
        Prefixed_Name(oso, "South_Rockall_Trough_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Spania"</para><para>"Espanha"</para><para>"España"</para><para>"Spain"</para><para>"Ισπανία"</para><para>"Spagna"</para><para>"Espagne"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Spain">https://w3id.org/earthsemantics/OSO#Spain</seealso>
    let Spain = Prefixed_Name(oso, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Station_M</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Station M"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Station_M">https://w3id.org/earthsemantics/OSO#Station_M</seealso>
    let Station_M = Prefixed_Name(oso, "Station_M") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Station_M_Subsurface_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Station M Subsurface Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Station_M_Subsurface_Mooring">https://w3id.org/earthsemantics/OSO#Station_M_Subsurface_Mooring</seealso>
    let Station_M_Subsurface_Mooring =
        Prefixed_Name(oso, "Station_M_Subsurface_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Stefano_MISEROCCHI</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Stefano MISEROCCHI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Stefano_MISEROCCHI">https://w3id.org/earthsemantics/OSO#Stefano_MISEROCCHI</seealso>
    let Stefano_MISEROCCHI = Prefixed_Name(oso, "Stefano_MISEROCCHI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Steffen_JORGENSEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Steffen LETH JORGENSEN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Steffen_JORGENSEN">https://w3id.org/earthsemantics/OSO#Steffen_JORGENSEN</seealso>
    let Steffen_JORGENSEN = Prefixed_Name(oso, "Steffen_JORGENSEN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Stylaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Stylaster"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Stylaster">https://w3id.org/earthsemantics/OSO#Stylaster</seealso>
    let Stylaster = Prefixed_Name(oso, "Stylaster") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SubPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observation subplatform, a component or specific segment of a platform, dedicated to a particular type of measurement or instrumental configuration."</para>
    ///   <para>"O subplatformă de observație, componentă sau segment specific al unei platforme, dedicată unui tip particular de măsurare sau configurație instrumentală."</para>
    ///   <para>"Uma subplataforma de observação, componente ou segmento específico de uma plataforma, dedicada a um tipo particular de medição ou configuração instrumental."</para>
    ///   <para>"Μια υποπλατφόρμα παρατήρησης, συστατικό ή συγκεκριμένο τμήμα μιας πλατφόρμας, αφιερωμένη σε έναν συγκεκριμένο τύπο μέτρησης ή οργανολογικής διάταξης."</para>
    ///   <para>"En underplattform for observasjon, en komponent eller spesifikt segment av en plattform, dedikert til en bestemt måletype eller instrumentkonfigurasjon."</para>
    ///   <para>"Una subplataforma de observación, componente o segmento específico de una plataforma, dedicada a un tipo particular de medición o configuración instrumental."</para>
    ///   <para>"Una sotto-piattaforma di osservazione, componente o segmento specifico di una piattaforma, dedicata a un tipo particolare di misurazione o configurazione strumentale."</para>
    ///   <para>"Une sous-plateforme d'observation, élément constitutif ou segment spécifique d'une plateforme, dédiée à un type particulier de mesure ou de configuration instrumentale."</para>
    /// labels<para>"Subplataforma de observação"</para><para>"Subplatformă de observație"</para><para>"Υποπλατφόρμα παρατήρησης"</para><para>"Subplataforma de observación"</para><para>"Observation Subplatform"</para><para>"Underplattform for observasjon"</para><para>"Sous-plateforme d'observation"</para><para>"Sotto-piattaforma di osservazione"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SubPlatform">https://w3id.org/earthsemantics/OSO#SubPlatform</seealso>
    let SubPlatform = Prefixed_Name(oso, "SubPlatform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#SubmarinePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Molène Submarine Platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#SubmarinePlatform">https://w3id.org/earthsemantics/OSO#SubmarinePlatform</seealso>
    let SubmarinePlatform = Prefixed_Name(oso, "SubmarinePlatform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un sous-site d'observation, composante plus fine d’un site, qui permet une granularité spatiale accrue pour la mesure ou l'instrumentation."</para>
    ///   <para>"Un sub-sitio de observación, componente más detallado de un sitio, que permite una mayor granularidad espacial para mediciones o instrumentación."</para>
    ///   <para>"Un sotto-sito di osservazione, componente più fine di un sito, che consente una maggiore granularità spaziale per le misurazioni o la strumentazione."</para>
    ///   <para>"A subsite of observation, a finer component of a site, enabling increased spatial granularity for measurement or instrumentation."</para>
    ///   <para>"Um sublocal de observação, componente mais detalhado de um site, permitindo maior granularidade espacial para medições ou instrumentação."</para>
    ///   <para>"Μια υποτοποθεσία παρατήρησης, λεπτότερο συστατικό ενός τόπου, που επιτρέπει αυξημένη χωρική ανάλυση για μέτρηση ή οργανολογία."</para>
    ///   <para>"Un sub-site de observație, componentă mai detaliată a unui site, care permite o granularitate spațială crescută pentru măsurători sau instrumentare."</para>
    ///   <para>"Et delområde for observasjon, en finere komponent av et sted, som muliggjør økt romlig granularitet for måling eller instrumentering."</para>
    /// labels<para>"Sotto-sito di osservazione"</para><para>"Sub-site de observație"</para><para>"Sublocal de observação"</para><para>"Υποτοποθεσία παρατήρησης"</para><para>"Observation Subsite"</para><para>"Delområde for observasjon"</para><para>"Sub-sitio de observación"</para><para>"Sous-site d'observation"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Subsite">https://w3id.org/earthsemantics/OSO#Subsite</seealso>
    let Subsite = Prefixed_Name(oso, "Subsite") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Subsite_contains_a_Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"a subsite contains one or more platforms"</para>
    /// labels<para>"Subsite contains a platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Subsite_contains_a_Platform">https://w3id.org/earthsemantics/OSO#Subsite_contains_a_Platform</seealso>
    let Subsite_contains_a_Platform =
        Prefixed_Name(oso, "Subsite_contains_a_Platform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Subsite_is_part_of_a_RI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Subsite is part of an Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Subsite_is_part_of_a_RI">https://w3id.org/earthsemantics/OSO#Subsite_is_part_of_a_RI</seealso>
    let Subsite_is_part_of_a_RI =
        Prefixed_Name(oso, "Subsite_is_part_of_a_RI") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Surface"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Surface">https://w3id.org/earthsemantics/OSO#Surface</seealso>
    let Surface = Prefixed_Name(oso, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Susan_HARTMAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Susan HARTMAN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Susan_HARTMAN">https://w3id.org/earthsemantics/OSO#Susan_HARTMAN</seealso>
    let Susan_HARTMAN = Prefixed_Name(oso, "Susan_HARTMAN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Svinoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Svinoy"</para><para>"Svinøy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Svinoy">https://w3id.org/earthsemantics/OSO#Svinoy</seealso>
    let Svinoy = Prefixed_Name(oso, "Svinoy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Svinoy_North</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#SubPlatform</para>
    ///
    /// labels<para>"Svinoy North"</para><para>"Svinøy North"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Svinoy_North">https://w3id.org/earthsemantics/OSO#Svinoy_North</seealso>
    let Svinoy_North = Prefixed_Name(oso, "Svinoy_North") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Svinoy_North_Subsurface_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Svinoy North Subsurface Mooring"</para><para>"Svinøy North Subsurface Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Svinoy_North_Subsurface_Mooring">https://w3id.org/earthsemantics/OSO#Svinoy_North_Subsurface_Mooring</seealso>
    let Svinoy_North_Subsurface_Mooring =
        Prefixed_Name(oso, "Svinoy_North_Subsurface_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Svinoy_South</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SubPlatform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Svinoy South"</para><para>"Svinøy South"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Svinoy_South">https://w3id.org/earthsemantics/OSO#Svinoy_South</seealso>
    let Svinoy_South = Prefixed_Name(oso, "Svinoy_South") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Svinoy_South_Subsurface_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Svinoy South Subsurface Mooring"</para><para>"Svinøy South Subsurface Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Svinoy_South_Subsurface_Mooring">https://w3id.org/earthsemantics/OSO#Svinoy_South_Subsurface_Mooring</seealso>
    let Svinoy_South_Subsurface_Mooring =
        Prefixed_Name(oso, "Svinoy_South_Subsurface_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sweden"</para><para>"Suedia"</para><para>"Suécia"</para><para>"Σουηδία"</para><para>"Suecia"</para><para>"Sverige"</para><para>"Svezia"</para><para>"Suède"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Sweden">https://w3id.org/earthsemantics/OSO#Sweden</seealso>
    let Sweden = Prefixed_Name(oso, "Sweden") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Deployment</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_1">https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_1</seealso>
    let TUPEM_SubSurface_Mooring_deployment_1 =
        Prefixed_Name(oso, "TUPEM_SubSurface_Mooring_deployment_1") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Deployment</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_2">https://w3id.org/earthsemantics/OSO#TUPEM_SubSurface_Mooring_deployment_2</seealso>
    let TUPEM_SubSurface_Mooring_deployment_2 =
        Prefixed_Name(oso, "TUPEM_SubSurface_Mooring_deployment_2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#TamTam</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tam Tam"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#TamTam">https://w3id.org/earthsemantics/OSO#TamTam</seealso>
    let TamTam = Prefixed_Name(oso, "TamTam") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Thibault_BARREYRE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Thibault BARREYRE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Thibault_BARREYRE">https://w3id.org/earthsemantics/OSO#Thibault_BARREYRE</seealso>
    let Thibault_BARREYRE = Prefixed_Name(oso, "Thibault_BARREYRE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#TourEiffel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Tour Eiffel"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#TourEiffel">https://w3id.org/earthsemantics/OSO#TourEiffel</seealso>
    let TourEiffel = Prefixed_Name(oso, "TourEiffel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#TourEiffel_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#TourEiffel_AutonomousDevices">https://w3id.org/earthsemantics/OSO#TourEiffel_AutonomousDevices</seealso>
    let TourEiffel_AutonomousDevices =
        Prefixed_Name(oso, "TourEiffel_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Turkey"</para><para>"Turchia"</para><para>"Tyrkia"</para><para>"Τουρκία"</para><para>"Turcia"</para><para>"Turquía"</para><para>"Turquia"</para><para>"Turquie"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Turkey">https://w3id.org/earthsemantics/OSO#Turkey</seealso>
    let Turkey = Prefixed_Name(oso, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ULPGC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"ULPGC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ULPGC">https://w3id.org/earthsemantics/OSO#ULPGC</seealso>
    let ULPGC = Prefixed_Name(oso, "ULPGC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#UPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"UPC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#UPC">https://w3id.org/earthsemantics/OSO#UPC</seealso>
    let UPC = Prefixed_Name(oso, "UPC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#UiB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"UiB"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#UiB">https://w3id.org/earthsemantics/OSO#UiB</seealso>
    let UiB = Prefixed_Name(oso, "UiB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Ukraine"</para><para>"Ukraina"</para><para>"Ucraina"</para><para>"Ουκρανία"</para><para>"Ucrânia"</para><para>"Ucrania"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ukraine">https://w3id.org/earthsemantics/OSO#Ukraine</seealso>
    let Ukraine = Prefixed_Name(oso, "Ukraine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"United Kingdom"</para><para>"Reino Unido"</para><para>"Regatul Unit"</para><para>"Regno Unito"</para><para>"Royaume-Uni"</para><para>"Storbritannia"</para><para>"Ηνωμένο Βασίλειο"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#United_Kingdom">https://w3id.org/earthsemantics/OSO#United_Kingdom</seealso>
    let United_Kingdom = Prefixed_Name(oso, "United_Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Vanessa_CARDIN</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Vanessa CARDIN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Vanessa_CARDIN">https://w3id.org/earthsemantics/OSO#Vanessa_CARDIN</seealso>
    let Vanessa_CARDIN = Prefixed_Name(oso, "Vanessa_CARDIN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Vanuatu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Vanuatu"</para><para>"Βανουάτου"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Vanuatu">https://w3id.org/earthsemantics/OSO#Vanuatu</seealso>
    let Vanuatu = Prefixed_Name(oso, "Vanuatu") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Vanuatu_Trench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Fosa Vanuatu"</para><para>"Fosse du Vanuatu"</para><para>"Fosa de Vanuatu"</para><para>"Fossa de Vanuatu"</para><para>"Vanuatu-gropen"</para><para>"Vanuatu Trench"</para><para>"Fossa di Vanuatu"</para><para>"Τάφρος Βανουάτου"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Vanuatu_Trench">https://w3id.org/earthsemantics/OSO#Vanuatu_Trench</seealso>
    let Vanuatu_Trench = Prefixed_Name(oso, "Vanuatu_Trench") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Vlad_R%C4%83dulescu</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Vlad Rădulescu"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Vlad_R%C4%83dulescu">https://w3id.org/earthsemantics/OSO#Vlad_R%C4%83dulescu</seealso>
    let ``Vlad_R%C4%83dulescu`` =
        Prefixed_Name(oso, "Vlad_R%C4%83dulescu") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#W1M3A</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"W1M3A"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#W1M3A">https://w3id.org/earthsemantics/OSO#W1M3A</seealso>
    let W1M3A = Prefixed_Name(oso, "W1M3A") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#W1M3A_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"W1M3A Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#W1M3A_Mooring">https://w3id.org/earthsemantics/OSO#W1M3A_Mooring</seealso>
    let W1M3A_Mooring = Prefixed_Name(oso, "W1M3A_Mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#WestLake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"West Lake"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#WestLake">https://w3id.org/earthsemantics/OSO#WestLake</seealso>
    let WestLake = Prefixed_Name(oso, "WestLake") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Western_Ionian_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mar Jônico ocidental"</para><para>"Mar Ionio occidentale"</para><para>"Marea Ionică de Vest"</para><para>"Mar Jónico occidental"</para><para>"Western Ionian Sea"</para><para>"Δυτική Ιόνια Θάλασσα"</para><para>"Mer Ionienne occidentale"</para><para>"Vestlige joniske hav"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea">https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea</seealso>
    let Western_Ionian_Sea = Prefixed_Name(oso, "Western_Ionian_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Western_Ionian_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Western_Ionian_Sea_EMSO_membership</seealso>
    let Western_Ionian_Sea_EMSO_membership =
        Prefixed_Name(oso, "Western_Ionian_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Western_Mediterranean_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"El nodo regional 'Western Mediterranean Sea' corresponde al mar de Liguria, según lo definido por la Organización Hidrográfica Internacional."</para>
    ///   <para>"Den regionale noden 'Western Mediterranean Sea' tilsvarer Liguriahavet, slik det er definert av Den internasjonale hydrografiske organisasjonen."</para>
    ///   <para>"Nodul regional 'Western Mediterranean Sea' corespunde Mării Ligurice, așa cum este definită de Organizația Hidrografică Internațională."</para>
    ///   <para>"Il nodo regionale 'Western Mediterranean Sea' corrisponde al Mar Ligure, come definito dall’Organizzazione Idrografica Internazionale."</para>
    ///   <para>"O nó regional 'Western Mediterranean Sea' corresponde ao Mar da Ligúria, conforme definido pela Organização Hidrográfica Internacional."</para>
    ///   <para>"Ο περιφερειακός κόμβος 'Western Mediterranean Sea' αντιστοιχεί στη Λιγουρική Θάλασσα, όπως ορίζεται από τον Διεθνή Υδρογραφικό Οργανισμό."</para>
    ///   <para>"Le nœud régional 'Western Mediterranean Sea' correspond à la mer Ligure, telle que définie par l’Organisation hydrographique internationale."</para>
    ///   <para>"The Regional Facility 'Western Mediterranean Sea' corresponds to the Ligurian Sea, as defined by the International Hydrographic Organization."</para>
    /// labels<para>"Western Mediterranean Sea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea">https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea</seealso>
    let Western_Mediterranean_Sea =
        Prefixed_Name(oso, "Western_Mediterranean_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Western_Mediterranean_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Western_Mediterranean_Sea_EMSO_membership</seealso>
    let Western_Mediterranean_Sea_EMSO_membership =
        Prefixed_Name(oso, "Western_Mediterranean_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#WhiteCastle</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"White Castle"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#WhiteCastle">https://w3id.org/earthsemantics/OSO#WhiteCastle</seealso>
    let WhiteCastle = Prefixed_Name(oso, "WhiteCastle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Y3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Y3"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Y3">https://w3id.org/earthsemantics/OSO#Y3</seealso>
    let Y3 = Prefixed_Name(oso, "Y3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Zuzia_STROYNOWSKI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Zuzia STROYNOWSKI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Zuzia_STROYNOWSKI">https://w3id.org/earthsemantics/OSO#Zuzia_STROYNOWSKI</seealso>
    let Zuzia_STROYNOWSKI = Prefixed_Name(oso, "Zuzia_STROYNOWSKI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#associatedWithRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is associated with one or more Research Infrastructures."</para>
    /// labels<para>"Regional Facility is associated with a Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#associatedWithRI">https://w3id.org/earthsemantics/OSO#associatedWithRI</seealso>
    let associatedWithRI = Prefixed_Name(oso, "associatedWithRI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#containsPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A site contains one or more platforms."</para>
    /// labels<para>"Site contains a Platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#containsPlatform">https://w3id.org/earthsemantics/OSO#containsPlatform</seealso>
    let containsPlatform = Prefixed_Name(oso, "containsPlatform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#containsSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility contains one or more Sites."</para>
    /// labels<para>"Regional Facility contains a Site"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#containsSite">https://w3id.org/earthsemantics/OSO#containsSite</seealso>
    let containsSite = Prefixed_Name(oso, "containsSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#dateEndDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date marking the end of deployment of an instrument, platform, or infrastructure."</para>
    ///   <para>"Date marquant la fin du déploiement d’un instrument, d’une plateforme ou d’une infrastructure."</para>
    /// labels<para>"Fecha de finalización del despliegue"</para><para>"Data de sfârșit a desfășurării"</para><para>"Ημερομηνία λήξης της εγκατάστασης"</para><para>"Data di fine del dispiegamento"</para><para>"Sluttdato for utplassering"</para><para>"Date de fin du déploiement"</para><para>"Data de fim da implantação"</para><para>"Deployment end date"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#dateEndDeployment">https://w3id.org/earthsemantics/OSO#dateEndDeployment</seealso>
    let dateEndDeployment = Prefixed_Name(oso, "dateEndDeployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#dateFirstDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date of the first deployment of an instrument, platform, or infrastructure."</para>
    ///   <para>"Date du premier déploiement d’un instrument, d’une plateforme ou d’une infrastructure."</para>
    /// labels<para>"Ημερομηνία πρώτης εγκατάστασης"</para><para>"First deployment date"</para><para>"Data da primeira implantação"</para><para>"Date du premier déploiement"</para><para>"Fecha del primer despliegue"</para><para>"Data primei desfășurări"</para><para>"Dato for første utplassering"</para><para>"Data del primo dispiegamento"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#dateFirstDeployment">https://w3id.org/earthsemantics/OSO#dateFirstDeployment</seealso>
    let dateFirstDeployment = Prefixed_Name(oso, "dateFirstDeployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#geosciences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Discipline</para>
    ///
    /// labels<para>"Geosciences"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#geosciences">https://w3id.org/earthsemantics/OSO#geosciences</seealso>
    let geosciences = Prefixed_Name(oso, "geosciences") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasBoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a regional facility to its spatial extent, aligned with EX_Extent/EX_GeographicBoundingBox in ISO 19115-3."</para>
    /// labels<para>"Regional Facility has a bouding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasBoundingBox">https://w3id.org/earthsemantics/OSO#hasBoundingBox</seealso>
    let hasBoundingBox = Prefixed_Name(oso, "hasBoundingBox") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"tiene país"</para><para>"ha paese"</para><para>"a pour pays"</para><para>"are țară"</para><para>"tem país"</para><para>"har land"</para><para>"has country"</para><para>"έχει χώρα"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasCountry">https://w3id.org/earthsemantics/OSO#hasCountry</seealso>
    let hasCountry = Prefixed_Name(oso, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasDOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Associe une entité à un identifiant DOI pour une identification pérenne."</para>
    ///   <para>"Associates an entity with a Digital Object Identifier (DOI) for persistent identification."</para>
    /// labels<para>"DOI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasDOI">https://w3id.org/earthsemantics/OSO#hasDOI</seealso>
    let hasDOI = Prefixed_Name(oso, "hasDOI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasDeployment">https://w3id.org/earthsemantics/OSO#hasDeployment</seealso>
    let hasDeployment = Prefixed_Name(oso, "hasDeployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasEDMO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Questa proprietà collega un'Organizzazione al suo identificatore EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"Cette propriété relie une organisation à son identifiant EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"Αυτή η ιδιότητα συνδέει έναν Οργανισμό με το αναγνωριστικό EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"Esta propriedade liga uma Organização ao seu identificador EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"This property links an Organisation to its EDMO (European Directory of Marine Organisations) identifier."</para>
    ///   <para>"Această proprietate leagă o organizație de identificatorul său EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"Esta propiedad vincula una Organización con su identificador EDMO (European Directory of Marine Organisations)."</para>
    ///   <para>"Denne egenskapen kobler en organisasjon til dens EDMO-identifikator (European Directory of Marine Organisations)."</para>
    /// labels<para>"has an EDMO"</para><para>"a un EDMO"</para><para>"are un EDMO"</para><para>"έχει EDMO"</para><para>"ha un EDMO"</para><para>"tiene un EDMO"</para><para>"har en EDMO"</para><para>"tem um EDMO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasEDMO">https://w3id.org/earthsemantics/OSO#hasEDMO</seealso>
    let hasEDMO = Prefixed_Name(oso, "hasEDMO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasERICMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a regional facility to its membership within an ERIC infrastructure."</para>
    ///   <para>"Relie une infrastructure régionale à son appartenance à un ERIC."</para>
    /// labels<para>"are apartenență la un ERIC"</para><para>"har medlemskap i et ERIC"</para><para>"ha un'appartenenza a un ERIC"</para><para>"a une appartenance à un ERIC"</para><para>"has ERIC membership"</para><para>"tem participação em um ERIC"</para><para>"έχει συμμετοχή σε ERIC"</para><para>"tiene membresía en un ERIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasERICMembership">https://w3id.org/earthsemantics/OSO#hasERICMembership</seealso>
    let hasERICMembership = Prefixed_Name(oso, "hasERICMembership") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasEastLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corresponds to eastBoundLongitude in ISO 19115-3"</para>
    /// labels<para>"East Longitude"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasEastLongitude">https://w3id.org/earthsemantics/OSO#hasEastLongitude</seealso>
    let hasEastLongitude = Prefixed_Name(oso, "hasEastLongitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has geometry"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasGeometry">https://w3id.org/earthsemantics/OSO#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(oso, "hasGeometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associe une entité à une localisation géographique ou une géométrie."</para>
    ///   <para>"Associates an entity with a geographical location description or geometry."</para>
    /// labels<para>"has location"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasLocation">https://w3id.org/earthsemantics/OSO#hasLocation</seealso>
    let hasLocation = Prefixed_Name(oso, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasLogo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ha un logo"</para><para>"har logo"</para><para>"tiene logotipo"</para><para>"έχει λογότυπο"</para><para>"are siglă"</para><para>"has logo"</para><para>"tem logótipo"</para><para>"a un logo"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasLogo">https://w3id.org/earthsemantics/OSO#hasLogo</seealso>
    let hasLogo = Prefixed_Name(oso, "hasLogo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasNorthLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corresponds to northBoundLatitude in ISO 19115-3"</para>
    /// labels<para>"North Latitude"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasNorthLatitude">https://w3id.org/earthsemantics/OSO#hasNorthLatitude</seealso>
    let hasNorthLatitude = Prefixed_Name(oso, "hasNorthLatitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasORCID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ORCID"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasORCID">https://w3id.org/earthsemantics/OSO#hasORCID</seealso>
    let hasORCID = Prefixed_Name(oso, "hasORCID") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasPlatformCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une instance de plateforme à un concept contrôlé du vocabulaire NERC L06 SeaVoX Platform Categories."</para>
    ///   <para>"Links a platform instance to a controlled concept from the NERC L06 SeaVoX Platform Categories vocabulary."</para>
    /// labels<para>"a pour catégorie de plateforme"</para><para>"has platform category"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasPlatformCategory">https://w3id.org/earthsemantics/OSO#hasPlatformCategory</seealso>
    let hasPlatformCategory = Prefixed_Name(oso, "hasPlatformCategory") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasPrincipalInvestigator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Platform may have zero or more Principal Investigators."</para>
    /// labels<para>"Platform has a Principal Investigator"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasPrincipalInvestigator">https://w3id.org/earthsemantics/OSO#hasPrincipalInvestigator</seealso>
    let hasPrincipalInvestigator =
        Prefixed_Name(oso, "hasPrincipalInvestigator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasROR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Această proprietate leagă o organizație de identificatorul său ROR (Research Organization Registry)."</para>
    ///   <para>"Denne egenskapen kobler en organisasjon til dens ROR-identifikator (Research Organization Registry)."</para>
    ///   <para>"Esta propriedade liga uma Organização ao seu identificador ROR (Research Organization Registry)."</para>
    ///   <para>"Questa proprietà collega un'Organizzazione al suo identificatore ROR (Research Organization Registry)."</para>
    ///   <para>"This property links an Organisation to its ROR (Research Organization Registry) identifier."</para>
    ///   <para>"Cette propriété relie une organisation à son identifiant ROR (Research Organization Registry)."</para>
    ///   <para>"Αυτή η ιδιότητα συνδέει έναν Οργανισμό με το αναγνωριστικό ROR (Research Organization Registry)."</para>
    ///   <para>"Esta propiedad vincula una Organización con su identificador ROR (Research Organization Registry)."</para>
    /// labels<para>"ha un ROR"</para><para>"tiene un ROR"</para><para>"are un ROR"</para><para>"har en ROR"</para><para>"a un ROR"</para><para>"έχει ROR"</para><para>"tem um ROR"</para><para>"has a ROR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasROR">https://w3id.org/earthsemantics/OSO#hasROR</seealso>
    let hasROR = Prefixed_Name(oso, "hasROR") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasRegionalTeamLeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is managed by one Regional Team Leader."</para>
    /// labels<para>"Regional Faciliy has a Regional Team Leader"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasRegionalTeamLeader">https://w3id.org/earthsemantics/OSO#hasRegionalTeamLeader</seealso>
    let hasRegionalTeamLeader =
        Prefixed_Name(oso, "hasRegionalTeamLeader") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Associe une infrastructure ou un système à un ou plusieurs sites d’observation."</para>
    ///   <para>"Associates an infrastructure or system with one or more observation sites."</para>
    /// labels<para>"has site"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasSite">https://w3id.org/earthsemantics/OSO#hasSite</seealso>
    let hasSite = Prefixed_Name(oso, "hasSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasSiteResponsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Site is managed by one Site Responsible."</para>
    /// labels<para>"Site has a Site Responsible"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasSiteResponsible">https://w3id.org/earthsemantics/OSO#hasSiteResponsible</seealso>
    let hasSiteResponsible = Prefixed_Name(oso, "hasSiteResponsible") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasSouthLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corresponds to southBoundLatitude in ISO 19115-3"</para>
    /// labels<para>"South Latitude"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasSouthLatitude">https://w3id.org/earthsemantics/OSO#hasSouthLatitude</seealso>
    let hasSouthLatitude = Prefixed_Name(oso, "hasSouthLatitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasSpatialExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relie une entité à son emprise géographique, comme une boîte englobante ou une zone de couverture."</para>
    ///   <para>"Relates an entity to its geographical extent, such as a bounding box or spatial coverage."</para>
    /// labels<para>"has spatial extent"</para><para>"έχει χωρική emprise"</para><para>"ha estensione spaziale"</para><para>"har romlig utstrekning"</para><para>"are extindere spațială"</para><para>"tiene extensión espacial"</para><para>"tem extensão espacial"</para><para>"a une emprise spatiale"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasSpatialExtent">https://w3id.org/earthsemantics/OSO#hasSpatialExtent</seealso>
    let hasSpatialExtent = Prefixed_Name(oso, "hasSpatialExtent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasStatus">https://w3id.org/earthsemantics/OSO#hasStatus</seealso>
    let hasStatus = Prefixed_Name(oso, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasSubsite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a site to a subdivision or component subsite."</para>
    ///   <para>"Relie un site à une sous-division ou un sous-site composant."</para>
    /// labels<para>"έχει υπο-τοποθεσία"</para><para>"are subsite"</para><para>"har delområde"</para><para>"tiene subsitio"</para><para>"has subsite"</para><para>"a un sous-site"</para><para>"tem subsite"</para><para>"ha sotto-sito"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasSubsite">https://w3id.org/earthsemantics/OSO#hasSubsite</seealso>
    let hasSubsite = Prefixed_Name(oso, "hasSubsite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#hasWestLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Corresponds to westBoundLongitude in ISO 19115-3"</para>
    /// labels<para>"West Longitude"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#hasWestLongitude">https://w3id.org/earthsemantics/OSO#hasWestLongitude</seealso>
    let hasWestLongitude = Prefixed_Name(oso, "hasWestLongitude") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#isERICMembershipOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"é participação em um ERIC de"</para><para>"er medlemskap i et ERIC for"</para><para>"είναι συμμετοχή σε ERIC του"</para><para>"est une appartenance à un ERIC de"</para><para>"este apartenență la un ERIC a"</para><para>"is ERIC membership of"</para><para>"è appartenenza a un ERIC di"</para><para>"es membresía en un ERIC de"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#isERICMembershipOf">https://w3id.org/earthsemantics/OSO#isERICMembershipOf</seealso>
    let isERICMembershipOf = Prefixed_Name(oso, "isERICMembershipOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#isInvolvedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#isInvolvedIn">https://w3id.org/earthsemantics/OSO#isInvolvedIn</seealso>
    let isInvolvedIn = Prefixed_Name(oso, "isInvolvedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#isManagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a research infrastructure (ERIC or national) to the organisation that manages or coordinates it."</para>
    /// labels<para>"is managed by"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#isManagedBy">https://w3id.org/earthsemantics/OSO#isManagedBy</seealso>
    let isManagedBy = Prefixed_Name(oso, "isManagedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#isMemberof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"Organisation is member of an ERIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#isMemberof">https://w3id.org/earthsemantics/OSO#isMemberof</seealso>
    let isMemberof = Prefixed_Name(oso, "isMemberof") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#isTestSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Υποδεικνύει εάν ένας τόπος ή υποτόπος θεωρείται δοκιμαστικός τόπος (true/false)."</para>
    ///   <para>"Indicates whether a site or subsite is considered a test site (true/false)."</para>
    ///   <para>"Indica se un sito o sottosito è considerato un sito di test (true/false)."</para>
    ///   <para>"Angir om et sted eller delsted regnes som et teststed (true/false)."</para>
    ///   <para>"Indica se um sítio ou subsítio é considerado um sítio de teste (true/false)."</para>
    ///   <para>"Indică dacă un sit sau un subsit este considerat sit de testare (true/false)."</para>
    ///   <para>"Indique si un site ou sous-site est considéré comme un site de test (true/false)."</para>
    ///   <para>"Indica si un sitio o subsitio se considera un sitio de prueba (true/false)."</para>
    /// labels<para>"is test site"</para><para>"este sit de testare"</para><para>"est un site de test"</para><para>"è un sito di test"</para><para>"er teststed"</para><para>"είναι δοκιμαστικός τόπος"</para><para>"es sitio de prueba"</para><para>"é sítio de teste"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#isTestSite">https://w3id.org/earthsemantics/OSO#isTestSite</seealso>
    let isTestSite = Prefixed_Name(oso, "isTestSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ledByOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is managed by one or more Organisations."</para>
    /// labels<para>"Regional Facility is managed by an Organisation"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ledByOrganization">https://w3id.org/earthsemantics/OSO#ledByOrganization</seealso>
    let ledByOrganization = Prefixed_Name(oso, "ledByOrganization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#linkedToCampaigns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is linked to zero or more Oceanographic Campaigns."</para>
    /// labels<para>"Regional Facility is linked to Cruise"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#linkedToCampaigns">https://w3id.org/earthsemantics/OSO#linkedToCampaigns</seealso>
    let linkedToCampaigns = Prefixed_Name(oso, "linkedToCampaigns") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#linkedToSeries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Regional Facility is linked to zero or more of series of Oceanographic Campaigns."</para>
    /// labels<para>"Regional Facility is linked to a Series of Cruises"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#linkedToSeries">https://w3id.org/earthsemantics/OSO#linkedToSeries</seealso>
    let linkedToSeries = Prefixed_Name(oso, "linkedToSeries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#maxWaterDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value expressed in meter (m)"</para>
    /// labels<para>"has max depth"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#maxWaterDepth">https://w3id.org/earthsemantics/OSO#maxWaterDepth</seealso>
    let maxWaterDepth = Prefixed_Name(oso, "maxWaterDepth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#membershipInERIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"appartenenza a un ERIC"</para><para>"συμμετοχή σε ERIC"</para><para>"medlemskap i et ERIC"</para><para>"membership in ERIC"</para><para>"apartenență la un ERIC"</para><para>"participação em um ERIC"</para><para>"membresía en un ERIC"</para><para>"appartenance à un ERIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#membershipInERIC">https://w3id.org/earthsemantics/OSO#membershipInERIC</seealso>
    let membershipInERIC = Prefixed_Name(oso, "membershipInERIC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#minWaterDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value expressed in meter (m)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has min depth"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#minWaterDepth">https://w3id.org/earthsemantics/OSO#minWaterDepth</seealso>
    let minWaterDepth = Prefixed_Name(oso, "minWaterDepth") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#mooring_line_A</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"mooring line A"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#mooring_line_A">https://w3id.org/earthsemantics/OSO#mooring_line_A</seealso>
    let mooring_line_A = Prefixed_Name(oso, "mooring_line_A") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#mooring_line_B</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"mooring line B"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#mooring_line_B">https://w3id.org/earthsemantics/OSO#mooring_line_B</seealso>
    let mooring_line_B = Prefixed_Name(oso, "mooring_line_B") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#mooring_line_C</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"mooring line C"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#mooring_line_C">https://w3id.org/earthsemantics/OSO#mooring_line_C</seealso>
    let mooring_line_C = Prefixed_Name(oso, "mooring_line_C") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#node1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"node1"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#node1">https://w3id.org/earthsemantics/OSO#node1</seealso>
    let node1 = Prefixed_Name(oso, "node1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#node2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"node2"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#node2">https://w3id.org/earthsemantics/OSO#node2</seealso>
    let node2 = Prefixed_Name(oso, "node2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#node3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"node3"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#node3">https://w3id.org/earthsemantics/OSO#node3</seealso>
    let node3 = Prefixed_Name(oso, "node3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#node4</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"node4"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#node4">https://w3id.org/earthsemantics/OSO#node4</seealso>
    let node4 = Prefixed_Name(oso, "node4") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#physical_oceanography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Discipline</para>
    ///
    /// labels<para>"Physical oceanography"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#physical_oceanography">https://w3id.org/earthsemantics/OSO#physical_oceanography</seealso>
    let physical_oceanography =
        Prefixed_Name(oso, "physical_oceanography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#pilot_line</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"pilot line"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#pilot_line">https://w3id.org/earthsemantics/OSO#pilot_line</seealso>
    let pilot_line = Prefixed_Name(oso, "pilot_line") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#profil_CTD</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"profil CTD"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#profil_CTD">https://w3id.org/earthsemantics/OSO#profil_CTD</seealso>
    let profil_CTD = Prefixed_Name(oso, "profil_CTD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#">https://w3id.org/earthsemantics/OSO#</seealso>
    let _prefix_iri = Prefixed_Name(oso, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#AIMSIR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///
    /// labels<para>"AIMSIR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#AIMSIR">https://w3id.org/earthsemantics/OSO#AIMSIR</seealso>
    let AIMSIR = Prefixed_Name(oso, "AIMSIR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ALBATROSS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"ALBATROSS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ALBATROSS">https://w3id.org/earthsemantics/OSO#ALBATROSS</seealso>
    let ALBATROSS = Prefixed_Name(oso, "ALBATROSS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ANTARES</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ANTARES"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ANTARES">https://w3id.org/earthsemantics/OSO#ANTARES</seealso>
    let ANTARES = Prefixed_Name(oso, "ANTARES") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ARDITI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"ARDITI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ARDITI">https://w3id.org/earthsemantics/OSO#ARDITI</seealso>
    let ARDITI = Prefixed_Name(oso, "ARDITI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Alan_BERRY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Alan BERRY"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Alan_BERRY">https://w3id.org/earthsemantics/OSO#Alan_BERRY</seealso>
    let Alan_BERRY = Prefixed_Name(oso, "Alan_BERRY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Antigonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Antigonia"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Antigonia">https://w3id.org/earthsemantics/OSO#Antigonia</seealso>
    let Antigonia = Prefixed_Name(oso, "Antigonia") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#AtlanticWhaleDealbbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3cgeo:BoundingBox</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#AtlanticWhaleDealbbox">https://w3id.org/earthsemantics/OSO#AtlanticWhaleDealbbox</seealso>
    let AtlanticWhaleDealbbox =
        Prefixed_Name(oso, "AtlanticWhaleDealbbox") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Atlantic_Whale_Deal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///
    /// labels<para>"Atlantic Whale Deal"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Atlantic_Whale_Deal">https://w3id.org/earthsemantics/OSO#Atlantic_Whale_Deal</seealso>
    let Atlantic_Whale_Deal = Prefixed_Name(oso, "Atlantic_Whale_Deal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Azores</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Azores"</para><para>"Açores"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Azores">https://w3id.org/earthsemantics/OSO#Azores</seealso>
    let Azores = Prefixed_Name(oso, "Azores") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Azores_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Azores_EMSO_membership">https://w3id.org/earthsemantics/OSO#Azores_EMSO_membership</seealso>
    let Azores_EMSO_membership =
        Prefixed_Name(oso, "Azores_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Azoresbbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3cgeo:BoundingBox</para>
    ///
    /// labels<para>"Azores Regional Facility bounding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Azoresbbox">https://w3id.org/earthsemantics/OSO#Azoresbbox</seealso>
    let Azoresbbox = Prefixed_Name(oso, "Azoresbbox") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#B%C3%A9n%C3%A9dicte_FERR%C3%89</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Bénédicte FERRÉ"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#B%C3%A9n%C3%A9dicte_FERR%C3%89">https://w3id.org/earthsemantics/OSO#B%C3%A9n%C3%A9dicte_FERR%C3%89</seealso>
    let ``B%C3%A9n%C3%A9dicte_FERR%C3%89`` =
        Prefixed_Name(oso, "B%C3%A9n%C3%A9dicte_FERR%C3%89") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BB"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BB">https://w3id.org/earthsemantics/OSO#BB</seealso>
    let BB = Prefixed_Name(oso, "BB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BB_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BB mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BB_Mooring">https://w3id.org/earthsemantics/OSO#BB_Mooring</seealso>
    let BB_Mooring = Prefixed_Name(oso, "BB_Mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BILLION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"BILLION"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BILLION">https://w3id.org/earthsemantics/OSO#BILLION</seealso>
    let BILLION = Prefixed_Name(oso, "BILLION") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BJS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BJS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BJS">https://w3id.org/earthsemantics/OSO#BJS</seealso>
    let BJS = Prefixed_Name(oso, "BJS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BJS_BathyBot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"BJS BathyBot"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BJS_BathyBot">https://w3id.org/earthsemantics/OSO#BJS_BathyBot</seealso>
    let BJS_BathyBot = Prefixed_Name(oso, "BJS_BathyBot") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BJS_BathyDock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"BJS BathyDock"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BJS_BathyDock">https://w3id.org/earthsemantics/OSO#BJS_BathyDock</seealso>
    let BJS_BathyDock = Prefixed_Name(oso, "BJS_BathyDock") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BJS_SeabedStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"BJS Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BJS_SeabedStation">https://w3id.org/earthsemantics/OSO#BJS_SeabedStation</seealso>
    let BJS_SeabedStation = Prefixed_Name(oso, "BJS_SeabedStation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#BRGM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"BRGM"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#BRGM">https://w3id.org/earthsemantics/OSO#BRGM</seealso>
    let BRGM = Prefixed_Name(oso, "BRGM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Balearic_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mar Balear"</para><para>"Βαλεαρίδα Θάλασσα"</para><para>"Balearic Sea"</para><para>"Balearhavet"</para><para>"Marea Balearelor"</para><para>"Mer des Baléares"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Balearic_Sea">https://w3id.org/earthsemantics/OSO#Balearic_Sea</seealso>
    let Balearic_Sea = Prefixed_Name(oso, "Balearic_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Balearic_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Balearic_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Balearic_Sea_EMSO_membership</seealso>
    let Balearic_Sea_EMSO_membership =
        Prefixed_Name(oso, "Balearic_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Bay_of_Biscay_Slope</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bay of Biscay canyons"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Bay_of_Biscay_Slope">https://w3id.org/earthsemantics/OSO#Bay_of_Biscay_Slope</seealso>
    let Bay_of_Biscay_Slope = Prefixed_Name(oso, "Bay_of_Biscay_Slope") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Benthic_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"benthic station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Benthic_station">https://w3id.org/earthsemantics/OSO#Benthic_station</seealso>
    let Benthic_station = Prefixed_Name(oso, "Benthic_station") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Billion_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Esta plataforma não faz parte nem da rede EMSO-France nem da rede EMSO-ERIC"</para>
    ///   <para>"Această platformă nu face parte nici din rețeaua EMSO-France, nici din rețeaua EMSO-ERIC"</para>
    ///   <para>"Η πλατφόρμα αυτή δεν ανήκει ούτε στο δίκτυο EMSO-France ούτε στο δίκτυο EMSO-ERIC"</para>
    ///   <para>"Questa piattaforma non fa parte né della rete EMSO-France né della rete EMSO-ERIC"</para>
    ///   <para>"This mooring is not part of either the EMSO-France network or the EMSO-ERIC network"</para>
    ///   <para>"Ce mouillage ne fait ni partie du réseau EMSO-France, ni du réseau EMSO-ERIC"</para>
    ///   <para>"Denne plattformen er ikke en del av verken EMSO-France-nettverket eller EMSO-ERIC-nettverket"</para>
    ///   <para>"Este amarre no forma parte ni de la red EMSO-France ni de la red EMSO-ERIC"</para>
    /// labels<para>"Billion Mooring"</para><para>"mouillage Billion"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Billion_mooring">https://w3id.org/earthsemantics/OSO#Billion_mooring</seealso>
    let Billion_mooring = Prefixed_Name(oso, "Billion_mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Black_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>"The Black Sea is one of the largest regional seas of the Eurasian continent and unique in many of its geographical, geological, biological, hydrographical and socio-political characteristics. With anoxic conditions in the deep, problems with invasive species and high sediment loads delivered to the system, this area has unique problems requiring long-term stations. The Black Sea is located in a geological complex area, where three major tectonic plates (Eurasian, Anatolian, Arabian) interact. Geo hazards, such as earthquarkes, submarine landslide, displacement along active faults, are present and are possible triggers of tsunami, together with extreme meteorological events."</para>
    /// labels<para>"Black Sea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Black_Sea">https://w3id.org/earthsemantics/OSO#Black_Sea</seealso>
    let Black_Sea = Prefixed_Name(oso, "Black_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Black_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Black_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Black_Sea_EMSO_membership</seealso>
    let Black_Sea_EMSO_membership =
        Prefixed_Name(oso, "Black_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Black_Sea_RF_bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3cgeo:BoundingBox</para>
    ///
    /// labels<para>"Black Sea Regional Facility bounding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Black_Sea_RF_bbox">https://w3id.org/earthsemantics/OSO#Black_Sea_RF_bbox</seealso>
    let Black_Sea_RF_bbox = Prefixed_Name(oso, "Black_Sea_RF_bbox") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Boris_MARCAILLOU</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Boris MARCAILLOU"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Boris_MARCAILLOU">https://w3id.org/earthsemantics/OSO#Boris_MARCAILLOU</seealso>
    let Boris_MARCAILLOU = Prefixed_Name(oso, "Boris_MARCAILLOU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CHEREEF-OBS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///
    /// labels<para>"CHEREEF-OBS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CHEREEF-OBS">https://w3id.org/earthsemantics/OSO#CHEREEF-OBS</seealso>
    let CHEREEF_OBS = Prefixed_Name(oso, "CHEREEF-OBS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CLASS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CLASS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CLASS">https://w3id.org/earthsemantics/OSO#CLASS</seealso>
    let CLASS = Prefixed_Name(oso, "CLASS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CNR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"CNR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CNR">https://w3id.org/earthsemantics/OSO#CNR</seealso>
    let CNR = Prefixed_Name(oso, "CNR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CNRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"CNRS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CNRS">https://w3id.org/earthsemantics/OSO#CNRS</seealso>
    let CNRS = Prefixed_Name(oso, "CNRS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CONDOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CONDOR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CONDOR">https://w3id.org/earthsemantics/OSO#CONDOR</seealso>
    let CONDOR = Prefixed_Name(oso, "CONDOR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CSIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"CSIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CSIC">https://w3id.org/earthsemantics/OSO#CSIC</seealso>
    let CSIC = Prefixed_Name(oso, "CSIC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#CTD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"CTD"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#CTD">https://w3id.org/earthsemantics/OSO#CTD</seealso>
    let CTD = Prefixed_Name(oso, "CTD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Calipso</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Calipso"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Calipso">https://w3id.org/earthsemantics/OSO#Calipso</seealso>
    let Calipso = Prefixed_Name(oso, "Calipso") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Calipso_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Calipso Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Calipso_Seabed_Station">https://w3id.org/earthsemantics/OSO#Calipso_Seabed_Station</seealso>
    let Calipso_Seabed_Station =
        Prefixed_Name(oso, "Calipso_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Canada"</para><para>"Canadá"</para><para>"Καναδάς"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Canada">https://w3id.org/earthsemantics/OSO#Canada</seealso>
    let Canada = Prefixed_Name(oso, "Canada") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Canarias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>"Canarias Regional Facility is linked to the Atlantic Whale Deal project (issue concerning collision with marine mammals)"</para>
    /// labels<para>"Canarias"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Canarias">https://w3id.org/earthsemantics/OSO#Canarias</seealso>
    let Canarias = Prefixed_Name(oso, "Canarias") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Canarias_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Canarias_EMSO_membership">https://w3id.org/earthsemantics/OSO#Canarias_EMSO_membership</seealso>
    let Canarias_EMSO_membership =
        Prefixed_Name(oso, "Canarias_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Capelinhos</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Capelinhos"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Capelinhos">https://w3id.org/earthsemantics/OSO#Capelinhos</seealso>
    let Capelinhos = Prefixed_Name(oso, "Capelinhos") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Capelinhos_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Capelinhos_AutonomousDevices">https://w3id.org/earthsemantics/OSO#Capelinhos_AutonomousDevices</seealso>
    let Capelinhos_AutonomousDevices =
        Prefixed_Name(oso, "Capelinhos_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Carlos_SOUSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Carlos SOUSA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Carlos_SOUSA">https://w3id.org/earthsemantics/OSO#Carlos_SOUSA</seealso>
    let Carlos_SOUSA = Prefixed_Name(oso, "Carlos_SOUSA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Celtic_Seas</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Celtic Seas"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Celtic_Seas">https://w3id.org/earthsemantics/OSO#Celtic_Seas</seealso>
    let Celtic_Seas = Prefixed_Name(oso, "Celtic_Seas") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Celtic_Seas_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Celtic_Seas_EMSO_membership">https://w3id.org/earthsemantics/OSO#Celtic_Seas_EMSO_membership</seealso>
    let Celtic_Seas_EMSO_membership =
        Prefixed_Name(oso, "Celtic_Seas_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Central_Fram_Strait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Central Fram Strait"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait">https://w3id.org/earthsemantics/OSO#Central_Fram_Strait</seealso>
    let Central_Fram_Strait = Prefixed_Name(oso, "Central_Fram_Strait") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Central_Fram_Strait_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Central Farm Strait Subsurface mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Central_Fram_Strait_mooring">https://w3id.org/earthsemantics/OSO#Central_Fram_Strait_mooring</seealso>
    let Central_Fram_Strait_mooring =
        Prefixed_Name(oso, "Central_Fram_Strait_mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Cimendef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Cimendef"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Cimendef">https://w3id.org/earthsemantics/OSO#Cimendef</seealso>
    let Cimendef = Prefixed_Name(oso, "Cimendef") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Condor_seamount</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Condor Seamount"</para><para>"Όρος Condor"</para><para>"Monte submarino Condor"</para><para>"Mont sous-marin Condor"</para><para>"Munte submarin Condor"</para><para>"Condor undervannsfjell"</para><para>"Monte sottomarino Condor"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Condor_seamount">https://w3id.org/earthsemantics/OSO#Condor_seamount</seealso>
    let Condor_seamount = Prefixed_Name(oso, "Condor_seamount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Cretan_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Cretan Sea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Cretan_Sea">https://w3id.org/earthsemantics/OSO#Cretan_Sea</seealso>
    let Cretan_Sea = Prefixed_Name(oso, "Cretan_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Cretan_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Cretan_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Cretan_Sea_EMSO_membership</seealso>
    let Cretan_Sea_EMSO_membership =
        Prefixed_Name(oso, "Cretan_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Crystal</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Crystal"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Crystal">https://w3id.org/earthsemantics/OSO#Crystal</seealso>
    let Crystal = Prefixed_Name(oso, "Crystal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Cypres</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cyprès"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Cypres">https://w3id.org/earthsemantics/OSO#Cypres</seealso>
    let Cypres = Prefixed_Name(oso, "Cypres") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#DAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DAS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#DAS">https://w3id.org/earthsemantics/OSO#DAS</seealso>
    let DAS = Prefixed_Name(oso, "DAS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#DYFAMED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>"DYFAMED : DYnamique des Flux Atmosphériques en MEDiterranée"</para>
    ///   <para>"DYFAMED: Dynamics of Atmospheric Fluxes in the Mediterranean"</para>
    /// labels<para>"DYFAMED"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#DYFAMED">https://w3id.org/earthsemantics/OSO#DYFAMED</seealso>
    let DYFAMED = Prefixed_Name(oso, "DYFAMED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Davide_EMBRIACO</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Davide EMBRIACO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Davide_EMBRIACO">https://w3id.org/earthsemantics/OSO#Davide_EMBRIACO</seealso>
    let Davide_EMBRIACO = Prefixed_Name(oso, "Davide_EMBRIACO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Deployment">https://w3id.org/earthsemantics/OSO#Deployment</seealso>
    let Deployment = Prefixed_Name(oso, "Deployment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dione</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Dione"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dione">https://w3id.org/earthsemantics/OSO#Dione</seealso>
    let Dione = Prefixed_Name(oso, "Dione") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dione_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Dione Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dione_Seabed_Station">https://w3id.org/earthsemantics/OSO#Dione_Seabed_Station</seealso>
    let Dione_Seabed_Station =
        Prefixed_Name(oso, "Dione_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Discipline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"List of EMSO scientific disciplines associated to a Regional Facility"</para>
    /// labels<para>"Discipline"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Discipline">https://w3id.org/earthsemantics/OSO#Discipline</seealso>
    let Discipline = Prefixed_Name(oso, "Discipline") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#DistanceFromLand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"value expressed in nautical miles (NM)"</para>
    /// labels<para>"Distance from land"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#DistanceFromLand">https://w3id.org/earthsemantics/OSO#DistanceFromLand</seealso>
    let DistanceFromLand = Prefixed_Name(oso, "DistanceFromLand") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dominique_LEFEVRE</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Dominique LEFEVRE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dominique_LEFEVRE">https://w3id.org/earthsemantics/OSO#Dominique_LEFEVRE</seealso>
    let Dominique_LEFEVRE = Prefixed_Name(oso, "Dominique_LEFEVRE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dyfamed_Mugobs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"DYFAMED Mugobs"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dyfamed_Mugobs">https://w3id.org/earthsemantics/OSO#Dyfamed_Mugobs</seealso>
    let Dyfamed_Mugobs = Prefixed_Name(oso, "Dyfamed_Mugobs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dyfamed_ODAS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DYFAMED Buoy ODAS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dyfamed_ODAS">https://w3id.org/earthsemantics/OSO#Dyfamed_ODAS</seealso>
    let Dyfamed_ODAS = Prefixed_Name(oso, "Dyfamed_ODAS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Dyfamed_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DYFAMED mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Dyfamed_mooring">https://w3id.org/earthsemantics/OSO#Dyfamed_mooring</seealso>
    let Dyfamed_mooring = Prefixed_Name(oso, "Dyfamed_mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#E1M3A</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"E1M3A"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#E1M3A">https://w3id.org/earthsemantics/OSO#E1M3A</seealso>
    let E1M3A = Prefixed_Name(oso, "E1M3A") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#E1M3A_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"E1M3A mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#E1M3A_mooring">https://w3id.org/earthsemantics/OSO#E1M3A_mooring</seealso>
    let E1M3A_mooring = Prefixed_Name(oso, "E1M3A_mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#E2M3A</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"E2M3A"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#E2M3A">https://w3id.org/earthsemantics/OSO#E2M3A</seealso>
    let E2M3A = Prefixed_Name(oso, "E2M3A") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#E2M3A_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"E2M3A buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#E2M3A_buoy">https://w3id.org/earthsemantics/OSO#E2M3A_buoy</seealso>
    let E2M3A_buoy = Prefixed_Name(oso, "E2M3A_buoy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#E2M3A_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"E2M3A mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#E2M3A_mooring">https://w3id.org/earthsemantics/OSO#E2M3A_mooring</seealso>
    let E2M3A_mooring = Prefixed_Name(oso, "E2M3A_mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EDOKKO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EDOKKO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EDOKKO">https://w3id.org/earthsemantics/OSO#EDOKKO</seealso>
    let EDOKKO = Prefixed_Name(oso, "EDOKKO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMBRC-France</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EMBRC-France"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMBRC-France">https://w3id.org/earthsemantics/OSO#EMBRC-France</seealso>
    let EMBRC_France = Prefixed_Name(oso, "EMBRC-France") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERIC</para>
    ///
    /// labels<para>"EMSO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO">https://w3id.org/earthsemantics/OSO#EMSO</seealso>
    let EMSO = Prefixed_Name(oso, "EMSO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO-France</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EMSO-France"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO-France">https://w3id.org/earthsemantics/OSO#EMSO-France</seealso>
    let EMSO_France = Prefixed_Name(oso, "EMSO-France") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO-PT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EMSO Portugal"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO-PT">https://w3id.org/earthsemantics/OSO#EMSO-PT</seealso>
    let EMSO_PT = Prefixed_Name(oso, "EMSO-PT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO_DMSG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"EMSO Data Management Service Group"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO_DMSG">https://w3id.org/earthsemantics/OSO#EMSO_DMSG</seealso>
    let EMSO_DMSG = Prefixed_Name(oso, "EMSO_DMSG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO_EVOLVE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO_EVOLVE">https://w3id.org/earthsemantics/OSO#EMSO_EVOLVE</seealso>
    let EMSO_EVOLVE = Prefixed_Name(oso, "EMSO_EVOLVE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO_Italia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ResearchInfrastructure</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO_Italia">https://w3id.org/earthsemantics/OSO#EMSO_Italia</seealso>
    let EMSO_Italia = Prefixed_Name(oso, "EMSO_Italia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO_LIGURE_OUEST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///
    /// labels<para>"EMSO LIGURE OUEST"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO_LIGURE_OUEST">https://w3id.org/earthsemantics/OSO#EMSO_LIGURE_OUEST</seealso>
    let EMSO_LIGURE_OUEST = Prefixed_Name(oso, "EMSO_LIGURE_OUEST") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EMSO_SA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///
    /// labels<para>"EMSO SA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EMSO_SA">https://w3id.org/earthsemantics/OSO#EMSO_SA</seealso>
    let EMSO_SA = Prefixed_Name(oso, "EMSO_SA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ERIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A European Research Infrastructure Consortium established under the ERIC legal framework to support long-term scientific collaboration and shared research services."</para>
    /// labels<para>"ERIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ERIC">https://w3id.org/earthsemantics/OSO#ERIC</seealso>
    let ERIC = Prefixed_Name(oso, "ERIC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class representing the membership relationship between an organisation or national entity and a European Research Infrastructure Consortium (ERIC)."</para>
    /// labels<para>"Συμμετοχή σε ERIC"</para><para>"Apartenență la un ERIC"</para><para>"Appartenenza a un ERIC"</para><para>"Membresía en un ERIC"</para><para>"ERIC membership"</para><para>"Participação em um ERIC"</para><para>"Medlemskap i et ERIC"</para><para>"Appartenance à un ERIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ERICMembership">https://w3id.org/earthsemantics/OSO#ERICMembership</seealso>
    let ERICMembership = Prefixed_Name(oso, "ERICMembership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ERIC_has_a_Director_General</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ERIC has a Director General"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ERIC_has_a_Director_General">https://w3id.org/earthsemantics/OSO#ERIC_has_a_Director_General</seealso>
    let ERIC_has_a_Director_General =
        Prefixed_Name(oso, "ERIC_has_a_Director_General") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ERICfederate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"ERIC federated a Research Infrastructure"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ERICfederate">https://w3id.org/earthsemantics/OSO#ERICfederate</seealso>
    let ERICfederate = Prefixed_Name(oso, "ERICfederate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ESTOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ESTOC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ESTOC">https://w3id.org/earthsemantics/OSO#ESTOC</seealso>
    let ESTOC = Prefixed_Name(oso, "ESTOC") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ESTOC_Autonomous_Devices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"ESTOC Autonomous Devices"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ESTOC_Autonomous_Devices">https://w3id.org/earthsemantics/OSO#ESTOC_Autonomous_Devices</seealso>
    let ESTOC_Autonomous_Devices =
        Prefixed_Name(oso, "ESTOC_Autonomous_Devices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ESTOC_Moored_Surface_Buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ESTOC Moored Surface Buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ESTOC_Moored_Surface_Buoy">https://w3id.org/earthsemantics/OSO#ESTOC_Moored_Surface_Buoy</seealso>
    let ESTOC_Moored_Surface_Buoy =
        Prefixed_Name(oso, "ESTOC_Moored_Surface_Buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ESTOC_Subsurface_gliders</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ESTOC Subsurface gliders"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_gliders">https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_gliders</seealso>
    let ESTOC_Subsurface_gliders =
        Prefixed_Name(oso, "ESTOC_Subsurface_gliders") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#ESTOC_Subsurface_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"ESTOC Subsurface mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_mooring">https://w3id.org/earthsemantics/OSO#ESTOC_Subsurface_mooring</seealso>
    let ESTOC_Subsurface_mooring =
        Prefixed_Name(oso, "ESTOC_Subsurface_mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EUXINUS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///
    /// labels<para>"EUXINUS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EUXINUS">https://w3id.org/earthsemantics/OSO#EUXINUS</seealso>
    let EUXINUS = Prefixed_Name(oso, "EUXINUS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EastVulcano</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"East vulcano"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EastVulcano">https://w3id.org/earthsemantics/OSO#EastVulcano</seealso>
    let EastVulcano = Prefixed_Name(oso, "EastVulcano") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#East_of_Gran_Canaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"A est di Gran Canaria"</para><para>"Este de Gran Canaria"</para><para>"À l’est de Gran Canaria"</para><para>"Øst for Gran Canaria"</para><para>"Ανατολικά της Μεγάλης Κανάριας"</para><para>"A leste de Gran Canaria"</para><para>"East of Gran Canaria"</para><para>"Est de Gran Canaria"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria">https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria</seealso>
    let East_of_Gran_Canaria =
        Prefixed_Name(oso, "East_of_Gran_Canaria") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#East_of_Gran_Canaria_Autonomous_Devices</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"East of Gran Canaria Autonomous Devices"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Autonomous_Devices">https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Autonomous_Devices</seealso>
    let East_of_Gran_Canaria_Autonomous_Devices =
        Prefixed_Name(oso, "East_of_Gran_Canaria_Autonomous_Devices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#East_of_Gran_Canaria_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"East of Gran Canaria Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Seabed_Station">https://w3id.org/earthsemantics/OSO#East_of_Gran_Canaria_Seabed_Station</seealso>
    let East_of_Gran_Canaria_Seabed_Station =
        Prefixed_Name(oso, "East_of_Gran_Canaria_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Eric_DELORY</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Eric DELORY"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Eric_DELORY">https://w3id.org/earthsemantics/OSO#Eric_DELORY</seealso>
    let Eric_DELORY = Prefixed_Name(oso, "Eric_DELORY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#European_Commission</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"European Commission"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#European_Commission">https://w3id.org/earthsemantics/OSO#European_Commission</seealso>
    let European_Commission = Prefixed_Name(oso, "European_Commission") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#European_Marine_Biological_Resource_Centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERIC</para>
    ///
    /// labels<para>"EMBRC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#European_Marine_Biological_Resource_Centre">https://w3id.org/earthsemantics/OSO#European_Marine_Biological_Resource_Centre</seealso>
    let European_Marine_Biological_Resource_Centre =
        Prefixed_Name(oso, "European_Marine_Biological_Resource_Centre") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#European_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#European_Union">https://w3id.org/earthsemantics/OSO#European_Union</seealso>
    let European_Union = Prefixed_Name(oso, "European_Union") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo01</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Relie une entité à sa représentation géométrique."</para>
    ///   <para>"Links an entity to its geometric representation."</para>
    /// labels<para>"EuxRo01"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo01">https://w3id.org/earthsemantics/OSO#EuxRo01</seealso>
    let EuxRo01 = Prefixed_Name(oso, "EuxRo01") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo01_geom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>ns349:geosparql#Geometry</para>
    ///
    /// labels<para>"EuxRo01 geometry"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo01_geom">https://w3id.org/earthsemantics/OSO#EuxRo01_geom</seealso>
    let EuxRo01_geom = Prefixed_Name(oso, "EuxRo01_geom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo01_surface_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"EuxRo01 surface buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo01_surface_buoy">https://w3id.org/earthsemantics/OSO#EuxRo01_surface_buoy</seealso>
    let EuxRo01_surface_buoy =
        Prefixed_Name(oso, "EuxRo01_surface_buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo02</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"EuxRo02"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo02">https://w3id.org/earthsemantics/OSO#EuxRo02</seealso>
    let EuxRo02 = Prefixed_Name(oso, "EuxRo02") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo02_seabed_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EuxRo02 seabed station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo02_seabed_station">https://w3id.org/earthsemantics/OSO#EuxRo02_seabed_station</seealso>
    let EuxRo02_seabed_station =
        Prefixed_Name(oso, "EuxRo02_seabed_station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo02_surface_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EuxRo02 surface buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo02_surface_buoy">https://w3id.org/earthsemantics/OSO#EuxRo02_surface_buoy</seealso>
    let EuxRo02_surface_buoy =
        Prefixed_Name(oso, "EuxRo02_surface_buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo03</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EuxRo03"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo03">https://w3id.org/earthsemantics/OSO#EuxRo03</seealso>
    let EuxRo03 = Prefixed_Name(oso, "EuxRo03") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo03_seabed_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"EuxRo03 seabed station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo03_seabed_station">https://w3id.org/earthsemantics/OSO#EuxRo03_seabed_station</seealso>
    let EuxRo03_seabed_station =
        Prefixed_Name(oso, "EuxRo03_seabed_station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#EuxRo03_surface_buoy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"EuxRo03 surface buoy"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#EuxRo03_surface_buoy">https://w3id.org/earthsemantics/OSO#EuxRo03_surface_buoy</seealso>
    let EuxRo03_surface_buoy =
        Prefixed_Name(oso, "EuxRo03_surface_buoy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#FCT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///   <para>"A Fundação para a Ciência e a Tecnologia (FCT) representa Portugal no EMSO."</para>
    ///   <para>"La Fundação para a Ciência e a Tecnologia (FCT) representa a Portugal en EMSO."</para>
    ///   <para>"La Fundação para a Ciência e a Tecnologia (FCT) rappresenta il Portogallo in EMSO."</para>
    ///   <para>"Το Ίδρυμα για την Επιστήμη και την Τεχνολογία (FCT) εκπροσωπεί την Πορτογαλία στο EMSO."</para>
    ///   <para>"The Fundação para a Ciência e a Tecnologia (FCT) represents Portugal in EMSO."</para>
    ///   <para>"Fundația pentru Știință și Tehnologie (FCT) reprezintă Portugalia în EMSO."</para>
    ///   <para>"La Fundação para a Ciência e a Tecnologia (FCT) représente le Portugal dans EMSO."</para>
    ///   <para>"Fundação para a Ciência e a Tecnologia (FCT) representerer Portugal i EMSO."</para>
    /// labels<para>"FCT"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#FCT">https://w3id.org/earthsemantics/OSO#FCT</seealso>
    let FCT = Prefixed_Name(oso, "FCT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#FF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"FF"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#FF">https://w3id.org/earthsemantics/OSO#FF</seealso>
    let FF = Prefixed_Name(oso, "FF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#FF_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"FF mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#FF_Mooring">https://w3id.org/earthsemantics/OSO#FF_Mooring</seealso>
    let FF_Mooring = Prefixed_Name(oso, "FF_Mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#France</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"France"</para><para>"Francia"</para><para>"França"</para><para>"Franța"</para><para>"Frankrike"</para><para>"Γαλλία"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#France">https://w3id.org/earthsemantics/OSO#France</seealso>
    let France = Prefixed_Name(oso, "France") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#French_riviera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Riviera francese"</para><para>"Riviera francesa"</para><para>"Riviera Francesa"</para><para>"Γαλλική Ριβιέρα"</para><para>"Côte d’Azur"</para><para>"French Riviera"</para><para>"Riviera Franceză"</para><para>"Franske riviera"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#French_riviera">https://w3id.org/earthsemantics/OSO#French_riviera</seealso>
    let French_riviera = Prefixed_Name(oso, "French_riviera") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A research project supported by dedicated financial funding from one or more organizations or funding bodies."</para>
    ///   <para>"Un projet de recherche soutenu par un financement dédié provenant d'une ou plusieurs organisations ou agences de financement."</para>
    ///   <para>"Un proiect de cercetare susținut prin finanțare dedicată din partea uneia sau mai multor organizații sau organisme de finanțare."</para>
    ///   <para>"Um projeto de investigação apoiado por financiamento específico proveniente de uma ou mais organizações ou entidades financiadoras."</para>
    ///   <para>"Ένα ερευνητικό έργο που υποστηρίζεται από ειδική χρηματοδότηση από έναν ή περισσότερους οργανισμούς ή φορείς χρηματοδότησης."</para>
    ///   <para>"Un progetto di ricerca sostenuto da finanziamenti dedicati provenienti da una o più organizzazioni o enti finanziatori."</para>
    ///   <para>"Un proyecto de investigación respaldado por financiación específica de una o más organizaciones o entidades financiadoras."</para>
    ///   <para>"Et forskningsprosjekt støttet av dedikert finansiering fra en eller flere organisasjoner eller finansieringskilder."</para>
    /// labels<para>"Proiect finanțat"</para><para>"Projet financé"</para><para>"Progetto finanziato"</para><para>"Proyecto financiado"</para><para>"Χρηματοδοτούμενο έργο"</para><para>"Funded project"</para><para>"Finansiert prosjekt"</para><para>"Projeto financiado"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#FundedProject">https://w3id.org/earthsemantics/OSO#FundedProject</seealso>
    let FundedProject = Prefixed_Name(oso, "FundedProject") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Galatea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Galatea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Galatea">https://w3id.org/earthsemantics/OSO#Galatea</seealso>
    let Galatea = Prefixed_Name(oso, "Galatea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Galatea_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Galatea Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Galatea_Mooring">https://w3id.org/earthsemantics/OSO#Galatea_Mooring</seealso>
    let Galatea_Mooring = Prefixed_Name(oso, "Galatea_Mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#GeoEcoMar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///   <para>"Departementet for nasjonal utdanning (ANCS) utpekte GeoEcoMar til å representere Romania i EMSO."</para>
    ///   <para>"Il Ministero dell’Istruzione Nazionale (ANCS) ha incaricato GeoEcoMar di rappresentare la Romania in EMSO."</para>
    ///   <para>"The Ministry of National Education (ANCS) appointed GeoEcoMar to represent Romania in EMSO."</para>
    ///   <para>"Ministerul Educației Naționale (ANCS) a desemnat GeoEcoMar să reprezinte România în EMSO."</para>
    ///   <para>"El Ministerio de Educación Nacional (ANCS) designó a GeoEcoMar para representar a Rumanía en EMSO."</para>
    ///   <para>"Le ministère de l’Éducation nationale (ANCS) a désigné GeoEcoMar pour représenter la Roumanie au sein d’EMSO."</para>
    ///   <para>"O Ministério da Educação Nacional (ANCS) designou o GeoEcoMar para representar a Roménia no EMSO."</para>
    ///   <para>"Το Υπουργείο Εθνικής Παιδείας (ANCS) όρισε το GeoEcoMar ως εκπρόσωπο της Ρουμανίας στο EMSO."</para>
    /// labels<para>"GeoEcoMar"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#GeoEcoMar">https://w3id.org/earthsemantics/OSO#GeoEcoMar</seealso>
    let GeoEcoMar = Prefixed_Name(oso, "GeoEcoMar") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Geometry">https://w3id.org/earthsemantics/OSO#Geometry</seealso>
    let Geometry = Prefixed_Name(oso, "Geometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#George_PETIHAKIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"George PETIHAKIS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#George_PETIHAKIS">https://w3id.org/earthsemantics/OSO#George_PETIHAKIS</seealso>
    let George_PETIHAKIS = Prefixed_Name(oso, "George_PETIHAKIS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Grecia"</para><para>"Grécia"</para><para>"Ελλάδα"</para><para>"Hellas"</para><para>"Grèce"</para><para>"Greece"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Greece">https://w3id.org/earthsemantics/OSO#Greece</seealso>
    let Greece = Prefixed_Name(oso, "Greece") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#HCMR</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HCMR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#HCMR">https://w3id.org/earthsemantics/OSO#HCMR</seealso>
    let HCMR = Prefixed_Name(oso, "HCMR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#HYDROMOMAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"HYDROMOMAR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#HYDROMOMAR">https://w3id.org/earthsemantics/OSO#HYDROMOMAR</seealso>
    let HYDROMOMAR = Prefixed_Name(oso, "HYDROMOMAR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Hellenic_Arc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Hellenic Arc"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc">https://w3id.org/earthsemantics/OSO#Hellenic_Arc</seealso>
    let Hellenic_Arc = Prefixed_Name(oso, "Hellenic_Arc") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Hellenic_Arc_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Hellenic_Arc_EMSO_membership">https://w3id.org/earthsemantics/OSO#Hellenic_Arc_EMSO_membership</seealso>
    let Hellenic_Arc_EMSO_membership =
        Prefixed_Name(oso, "Hellenic_Arc_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IL07</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IL07"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IL07">https://w3id.org/earthsemantics/OSO#IL07</seealso>
    let IL07 = Prefixed_Name(oso, "IL07") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#INFN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"INFN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#INFN">https://w3id.org/earthsemantics/OSO#INFN</seealso>
    let INFN = Prefixed_Name(oso, "INFN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#INGV</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Ministry of Education, University and Research (MIUR) appointed INGV to represent the Italian scientific community in marine science across different Italian research institutions."</para>
    ///   <para>"Το Υπουργείο Παιδείας, Πανεπιστημίων και Έρευνας (MIUR) όρισε το INGV να εκπροσωπεί την ιταλική επιστημονική κοινότητα των θαλάσσιων επιστημών, κατανεμημένη σε διάφορα ιταλικά ερευνητικά ιδρύματα."</para>
    ///   <para>"El Ministerio de Educación, Universidad e Investigación (MIUR) designó al INGV para representar a la comunidad científica italiana de ciencias marinas distribuida en distintas instituciones de investigación italianas."</para>
    ///   <para>"Ministerul Educației, Universității și Cercetării (MIUR) a desemnat INGV să reprezinte comunitatea științifică italiană din domeniul științelor marine, distribuită în diferite instituții de cercetare italiene."</para>
    ///   <para>"Il Ministero dell’Istruzione, dell’Università e della Ricerca (MIUR) ha incaricato l’INGV di rappresentare la comunità scientifica italiana delle scienze marine distribuita tra diverse istituzioni di ricerca italiane."</para>
    ///   <para>"Departementet for utdanning, universitet og forskning (MIUR) utpekte INGV til å representere det italienske vitenskapelige miljøet innen marin forskning, fordelt på ulike italienske forskningsinstitusjoner."</para>
    ///   <para>"Le ministère de l’Éducation, de l’Université et de la Recherche (MIUR) a désigné l’INGV pour représenter la communauté scientifique italienne des sciences marines répartie entre différentes institutions de recherche italiennes."</para>
    ///   <para>"O Ministério da Educação, Universidade e Investigação (MIUR) designou o INGV para representar a comunidade científica italiana das ciências marinhas distribuída por diferentes instituições de investigação italianas."</para>
    /// labels<para>"INGV"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#INGV">https://w3id.org/earthsemantics/OSO#INGV</seealso>
    let INGV = Prefixed_Name(oso, "INGV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IPGP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"IPGP"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IPGP">https://w3id.org/earthsemantics/OSO#IPGP</seealso>
    let IPGP = Prefixed_Name(oso, "IPGP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IPMA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"IPMA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IPMA">https://w3id.org/earthsemantics/OSO#IPMA</seealso>
    let IPMA = Prefixed_Name(oso, "IPMA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IRD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"IRD"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IRD">https://w3id.org/earthsemantics/OSO#IRD</seealso>
    let IRD = Prefixed_Name(oso, "IRD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMa-CSV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>"IbMa-CSV: Iberian Margin Cap St. Vincent"</para>
    /// labels<para>"IbMa-CSV"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMa-CSV">https://w3id.org/earthsemantics/OSO#IbMa-CSV</seealso>
    let IbMa_CSV = Prefixed_Name(oso, "IbMa-CSV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMa-N</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"IbMa-N"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMa-N">https://w3id.org/earthsemantics/OSO#IbMa-N</seealso>
    let IbMa_N = Prefixed_Name(oso, "IbMa-N") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMaCSV_SaoVicenteCanyon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"IbMa-CSV Sao Vicente Canyon"</para><para>"IbMa-CSV São Vicente canyon"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMaCSV_SaoVicenteCanyon">https://w3id.org/earthsemantics/OSO#IbMaCSV_SaoVicenteCanyon</seealso>
    let IbMaCSV_SaoVicenteCanyon =
        Prefixed_Name(oso, "IbMaCSV_SaoVicenteCanyon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMaCSV_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"IbMa-CSV Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMaCSV_Seabed_Station">https://w3id.org/earthsemantics/OSO#IbMaCSV_Seabed_Station</seealso>
    let IbMaCSV_Seabed_Station =
        Prefixed_Name(oso, "IbMaCSV_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"IbMa-CSV TUPEM Fixed SubSurface Vertical Profiler"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler">https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler</seealso>
    let IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler =
        Prefixed_Name(oso, "IbMaCSV_TUPEM_Fixed_SubSurface_Vertical_Profiler") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMaCSV_TUPEM_SubSurface_Mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"IbMa-CS TUPEM SubSurface Mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_SubSurface_Mooring">https://w3id.org/earthsemantics/OSO#IbMaCSV_TUPEM_SubSurface_Mooring</seealso>
    let IbMaCSV_TUPEM_SubSurface_Mooring =
        Prefixed_Name(oso, "IbMaCSV_TUPEM_SubSurface_Mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#IbMaN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"IbMa-N"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#IbMaN">https://w3id.org/earthsemantics/OSO#IbMaN</seealso>
    let IbMaN = Prefixed_Name(oso, "IbMaN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Iberian_Margin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Iberian Margin"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Iberian_Margin">https://w3id.org/earthsemantics/OSO#Iberian_Margin</seealso>
    let Iberian_Margin = Prefixed_Name(oso, "Iberian_Margin") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Iberian_Margin_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Iberian_Margin_EMSO_membership">https://w3id.org/earthsemantics/OSO#Iberian_Margin_EMSO_membership</seealso>
    let Iberian_Margin_EMSO_membership =
        Prefixed_Name(oso, "Iberian_Margin_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ifremer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>foaf:Organization</para>
    ///
    /// labels<para>"Ifremer"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ifremer">https://w3id.org/earthsemantics/OSO#Ifremer</seealso>
    let Ifremer = Prefixed_Name(oso, "Ifremer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ilker_FER</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ilker FER"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ilker_FER">https://w3id.org/earthsemantics/OSO#Ilker_FER</seealso>
    let Ilker_FER = Prefixed_Name(oso, "Ilker_FER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ingrid_PUILLAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Ingrid PUILLAT"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ingrid_PUILLAT">https://w3id.org/earthsemantics/OSO#Ingrid_PUILLAT</seealso>
    let Ingrid_PUILLAT = Prefixed_Name(oso, "Ingrid_PUILLAT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ingunn_SKJELVAN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Ingunn SKJELVAN"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ingunn_SKJELVAN">https://w3id.org/earthsemantics/OSO#Ingunn_SKJELVAN</seealso>
    let Ingunn_SKJELVAN = Prefixed_Name(oso, "Ingunn_SKJELVAN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ireland"</para><para>"Irland"</para><para>"Irlanda"</para><para>"Ιρλανδία"</para><para>"Irlande"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ireland">https://w3id.org/earthsemantics/OSO#Ireland</seealso>
    let Ireland = Prefixed_Name(oso, "Ireland") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Iroise</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Iroise"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Iroise">https://w3id.org/earthsemantics/OSO#Iroise</seealso>
    let Iroise = Prefixed_Name(oso, "Iroise") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Iroise_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Iroise_EMSO_membership">https://w3id.org/earthsemantics/OSO#Iroise_EMSO_membership</seealso>
    let Iroise_EMSO_membership =
        Prefixed_Name(oso, "Iroise_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Iroise_RF_bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3cgeo:BoundingBox</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Iroise Regional Facility bounding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Iroise_RF_bbox">https://w3id.org/earthsemantics/OSO#Iroise_RF_bbox</seealso>
    let Iroise_RF_bbox = Prefixed_Name(oso, "Iroise_RF_bbox") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Isabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Isabel"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Isabel">https://w3id.org/earthsemantics/OSO#Isabel</seealso>
    let Isabel = Prefixed_Name(oso, "Isabel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:ontology/Country</para>
    ///
    /// labels<para>"Italia"</para><para>"Italie"</para><para>"Italy"</para><para>"Itália"</para><para>"Ιταλία"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Italy">https://w3id.org/earthsemantics/OSO#Italy</seealso>
    let Italy = Prefixed_Name(oso, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#JAMSTEC</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"JAMSTEC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#JAMSTEC">https://w3id.org/earthsemantics/OSO#JAMSTEC</seealso>
    let JAMSTEC = Prefixed_Name(oso, "JAMSTEC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Japan</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:ontology/Country</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Giappone"</para><para>"Japan"</para><para>"Japonia"</para><para>"Japón"</para><para>"Japon"</para><para>"Japão"</para><para>"Ιαπωνία"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Japan">https://w3id.org/earthsemantics/OSO#Japan</seealso>
    let Japan = Prefixed_Name(oso, "Japan") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Joaquin_DEL_RIO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Joaquin DEL RIO FERNANDEZ"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Joaquin_DEL_RIO">https://w3id.org/earthsemantics/OSO#Joaquin_DEL_RIO</seealso>
    let Joaquin_DEL_RIO = Prefixed_Name(oso, "Joaquin_DEL_RIO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#KANADEEP_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KANADEEP 2"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#KANADEEP_2">https://w3id.org/earthsemantics/OSO#KANADEEP_2</seealso>
    let KANADEEP_2 = Prefixed_Name(oso, "KANADEEP_2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#KASEAOPE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KASEAOPE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#KASEAOPE">https://w3id.org/earthsemantics/OSO#KASEAOPE</seealso>
    let KASEAOPE = Prefixed_Name(oso, "KASEAOPE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#KASEASPACE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"KASEASPACE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#KASEASPACE">https://w3id.org/earthsemantics/OSO#KASEASPACE</seealso>
    let KASEASPACE = Prefixed_Name(oso, "KASEASPACE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Karin_SIGLOCH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Karin SIGLOCH"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Karin_SIGLOCH">https://w3id.org/earthsemantics/OSO#Karin_SIGLOCH</seealso>
    let Karin_SIGLOCH = Prefixed_Name(oso, "Karin_SIGLOCH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Karine_OLU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Karine OLU"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Karine_OLU">https://w3id.org/earthsemantics/OSO#Karine_OLU</seealso>
    let Karine_OLU = Prefixed_Name(oso, "Karine_OLU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#LION</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LION"</para>
    /// labels<para>"LION"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#LION">https://w3id.org/earthsemantics/OSO#LION</seealso>
    let LION = Prefixed_Name(oso, "LION") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#LO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"LO : Ligure Ouest"</para>
    ///   <para>"LO: Western Ligurian site"</para>
    /// labels<para>"LO"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#LO">https://w3id.org/earthsemantics/OSO#LO</seealso>
    let LO = Prefixed_Name(oso, "LO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#LUCKYDIVMIC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///
    /// labels<para>"LUCKYDIVMIC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#LUCKYDIVMIC">https://w3id.org/earthsemantics/OSO#LUCKYDIVMIC</seealso>
    let LUCKYDIVMIC = Prefixed_Name(oso, "LUCKYDIVMIC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lampaul_Canyon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Lampaul Canyon"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lampaul_Canyon">https://w3id.org/earthsemantics/OSO#Lampaul_Canyon</seealso>
    let Lampaul_Canyon = Prefixed_Name(oso, "Lampaul_Canyon") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Laura_DE_STEUR</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Laura DE STEUR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Laura_DE_STEUR">https://w3id.org/earthsemantics/OSO#Laura_DE_STEUR</seealso>
    let Laura_DE_STEUR = Prefixed_Name(oso, "Laura_DE_STEUR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Laurent_COPPOLA</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Laurent COPPOLA"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Laurent_COPPOLA">https://w3id.org/earthsemantics/OSO#Laurent_COPPOLA</seealso>
    let Laurent_COPPOLA = Prefixed_Name(oso, "Laurent_COPPOLA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Laurent_GAUTIER</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Laurent GAUTIER"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Laurent_GAUTIER">https://w3id.org/earthsemantics/OSO#Laurent_GAUTIER</seealso>
    let Laurent_GAUTIER = Prefixed_Name(oso, "Laurent_GAUTIER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#LavaLake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Lava Lake"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#LavaLake">https://w3id.org/earthsemantics/OSO#LavaLake</seealso>
    let LavaLake = Prefixed_Name(oso, "LavaLake") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Leonidas_PERIVOLIOTIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Leonidas PERIVOLIOTIS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Leonidas_PERIVOLIOTIS">https://w3id.org/earthsemantics/OSO#Leonidas_PERIVOLIOTIS</seealso>
    let Leonidas_PERIVOLIOTIS =
        Prefixed_Name(oso, "Leonidas_PERIVOLIOTIS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ligurian_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///   <para>"Infrastruttura regionale che copre un’ampia area marina del Mediterraneo nord-occidentale, includendo il Mar Ligure, la Costa Azzurra, il Golfo del Leone e lo spazio marino intermedio."</para>
    ///   <para>"Περιφερειακή υποδομή που καλύπτει μια ευρεία θαλάσσια περιοχή στη βορειοδυτική Μεσόγειο, συμπεριλαμβανομένης της Λιγουρικής Θάλασσας, της Γαλλικής Ριβιέρας, του Κόλπου του Λέοντα και του ενδιάμεσου θαλάσσιου χώρου."</para>
    ///   <para>"Installation régionale couvrant une vaste zone marine du nord-ouest de la Méditerranée, incluant la mer Ligure, la Côte d’Azur, le golfe du Lion ainsi que l’espace marin intermédiaire."</para>
    ///   <para>"Regional infrastruktur som dekker et bredt marint område i det nordvestlige Middelhavet, inkludert Liguriahavet, den franske rivieraen, Løvegolfen og det mellomliggende havområdet."</para>
    ///   <para>"Infraestructura regional que cubre una amplia zona marina del noroeste del Mediterráneo, incluyendo el mar de Liguria, la Riviera francesa, el golfo de León y el espacio marino intermedio."</para>
    ///   <para>"Infrastructură regională care acoperă o zonă marină extinsă din nord-vestul Mării Mediterane, incluzând Marea Ligurică, Riviera Franceză, Golful Lyon și spațiul marin intermediar."</para>
    ///   <para>"Regional Facility covering a broad north-western Mediterranean marine area, including the Ligurian Sea, the French Riviera, the Gulf of Lion, and the intermediate marine space."</para>
    ///   <para>"Infraestrutura regional que cobre uma vasta área marinha do noroeste do Mediterrâneo, incluindo o Mar da Ligúria, a Riviera Francesa, o Golfo do Leão e o espaço marinho intermédio."</para>
    /// labels<para>"Mer Ligure"</para><para>"Liguriahavet"</para><para>"Mar de Liguria"</para><para>"Marea Ligurică"</para><para>"Λιγουρική Θάλασσα"</para><para>"Mar Ligure"</para><para>"Mar da Ligúria"</para><para>"Ligurian Sea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea">https://w3id.org/earthsemantics/OSO#Ligurian_Sea</seealso>
    let Ligurian_Sea = Prefixed_Name(oso, "Ligurian_Sea") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ligurian_Sea_EMSO_membership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#ERICMembership</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_EMSO_membership">https://w3id.org/earthsemantics/OSO#Ligurian_Sea_EMSO_membership</seealso>
    let Ligurian_Sea_EMSO_membership =
        Prefixed_Name(oso, "Ligurian_Sea_EMSO_membership") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Ligurian_Sea_RF_bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3cgeo:BoundingBox</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ligurian Sea Regional Facility bounding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Ligurian_Sea_RF_bbox">https://w3id.org/earthsemantics/OSO#Ligurian_Sea_RF_bbox</seealso>
    let Ligurian_Sea_RF_bbox =
        Prefixed_Name(oso, "Ligurian_Sea_RF_bbox") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lion_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>"Această platformă aparține exclusiv rețelei EMSO-France și nu face parte din rețeaua EMSO-ERIC"</para>
    ///   <para>"Questa piattaforma appartiene esclusivamente alla rete EMSO-France e non fa parte della rete EMSO-ERIC"</para>
    ///   <para>"Η πλατφόρμα αυτή ανήκει αποκλειστικά στο δίκτυο EMSO-France και δεν αποτελεί μέρος του δικτύου EMSO-ERIC"</para>
    ///   <para>"Ce mouillage appartient exclusivement au réseau EMSO-France et ne fait pas partie du réseau EMSO-ERIC"</para>
    ///   <para>"Esta plataforma pertence exclusivamente à rede EMSO-France e não faz parte da rede EMSO-ERIC"</para>
    ///   <para>"Denne plattformen tilhører utelukkende EMSO-France-nettverket og er ikke en del av EMSO-ERIC-nettverket"</para>
    ///   <para>"Este amarre pertenece exclusivamente a la red EMSO-France y no forma parte de la red EMSO-ERIC"</para>
    ///   <para>"This mooring belongs exclusively to the EMSO-France network and is not part of the EMSO-ERIC network"</para>
    /// labels<para>"Lion mooring"</para><para>"mouillage Lion"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lion_mooring">https://w3id.org/earthsemantics/OSO#Lion_mooring</seealso>
    let Lion_mooring = Prefixed_Name(oso, "Lion_mooring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Louis_GELLI</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Person</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Louis GELI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Louis_GELLI">https://w3id.org/earthsemantics/OSO#Louis_GELLI</seealso>
    let Louis_GELLI = Prefixed_Name(oso, "Louis_GELLI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lucky_Strike</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lucky Strike"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lucky_Strike">https://w3id.org/earthsemantics/OSO#Lucky_Strike</seealso>
    let Lucky_Strike = Prefixed_Name(oso, "Lucky_Strike") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lucky_Strike_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Lucky Strike AutonomousDevices"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_AutonomousDevices">https://w3id.org/earthsemantics/OSO#Lucky_Strike_AutonomousDevices</seealso>
    let Lucky_Strike_AutonomousDevices =
        Prefixed_Name(oso, "Lucky_Strike_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lucky_Strike_EGIM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#SubPlatform</para>
    ///
    /// labels<para>"Lucky Strike EGIM"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_EGIM">https://w3id.org/earthsemantics/OSO#Lucky_Strike_EGIM</seealso>
    let Lucky_Strike_EGIM = Prefixed_Name(oso, "Lucky_Strike_EGIM") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lucky_Strike_Hydrographicmooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Lucky Strike Hydrographic mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Hydrographicmooring">https://w3id.org/earthsemantics/OSO#Lucky_Strike_Hydrographicmooring</seealso>
    let Lucky_Strike_Hydrographicmooring =
        Prefixed_Name(oso, "Lucky_Strike_Hydrographicmooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Lucky_Strike_Surface_BOREL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Surface BOREL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Lucky_Strike_Surface_BOREL">https://w3id.org/earthsemantics/OSO#Lucky_Strike_Surface_BOREL</seealso>
    let Lucky_Strike_Surface_BOREL =
        Prefixed_Name(oso, "Lucky_Strike_Surface_BOREL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MARLEY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MARLEY">https://w3id.org/earthsemantics/OSO#MARLEY</seealso>
    let MARLEY = Prefixed_Name(oso, "MARLEY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MARMESONET</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MARMESONET"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MARMESONET">https://w3id.org/earthsemantics/OSO#MARMESONET</seealso>
    let MARMESONET = Prefixed_Name(oso, "MARMESONET") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MARMOR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MARMOR"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MARMOR">https://w3id.org/earthsemantics/OSO#MARMOR</seealso>
    let MARMOR = Prefixed_Name(oso, "MARMOR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MARNAUT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#OceanographicCampaign</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MARNAUT"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MARNAUT">https://w3id.org/earthsemantics/OSO#MARNAUT</seealso>
    let MARNAUT = Prefixed_Name(oso, "MARNAUT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MARSITECRUISE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MARSITECRUISE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MARSITECRUISE">https://w3id.org/earthsemantics/OSO#MARSITECRUISE</seealso>
    let MARSITECRUISE = Prefixed_Name(oso, "MARSITECRUISE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MAYOBS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MAYOBS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MAYOBS">https://w3id.org/earthsemantics/OSO#MAYOBS</seealso>
    let MAYOBS = Prefixed_Name(oso, "MAYOBS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MII</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"MII"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MII">https://w3id.org/earthsemantics/OSO#MII</seealso>
    let MII = Prefixed_Name(oso, "MII") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MOMARSAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"MOMAR is the acronym for MOnitoring the Mid Atlantic Ridge"</para>
    /// labels<para>"MOMARSAT"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MOMARSAT">https://w3id.org/earthsemantics/OSO#MOMARSAT</seealso>
    let MOMARSAT = Prefixed_Name(oso, "MOMARSAT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MOOSE-GE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MOOSE-GE"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MOOSE-GE">https://w3id.org/earthsemantics/OSO#MOOSE-GE</seealso>
    let MOOSE_GE = Prefixed_Name(oso, "MOOSE-GE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MUG-OBS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#SeriesOfOceanographicCampaigns</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"MUG-OBS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MUG-OBS">https://w3id.org/earthsemantics/OSO#MUG-OBS</seealso>
    let MUG_OBS = Prefixed_Name(oso, "MUG-OBS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#FundedProject</para>
    ///
    /// labels<para>"LIFE Marha"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marha">https://w3id.org/earthsemantics/OSO#Marha</seealso>
    let Marha = Prefixed_Name(oso, "Marha") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marine_institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"El Marine Institute es el organismo nacional responsable de la investigación marina, el desarrollo tecnológico y la innovación."</para>
    ///   <para>"O Marine Institute é a agência nacional responsável pela investigação marinha, desenvolvimento tecnológico e inovação."</para>
    ///   <para>"Marine Institute er det nasjonale organet ansvarlig for marin forskning, teknologisk utvikling og innovasjon."</para>
    ///   <para>"The Marine Institute is the national agency responsible for Marine Research, Technology Development and Innovation (RTDI)."</para>
    ///   <para>"Il Marine Institute è l’agenzia nazionale responsabile della ricerca marina, dello sviluppo tecnologico e dell’innovazione."</para>
    ///   <para>"Le Marine Institute est l’organisme national chargé de la recherche marine, du développement technologique et de l’innovation."</para>
    ///   <para>"Marine Institute este agenția națională responsabilă pentru cercetarea marină, dezvoltarea tehnologică și inovarea."</para>
    ///   <para>"Το Marine Institute είναι ο εθνικός οργανισμός υπεύθυνος για την έρευνα, την τεχνολογική ανάπτυξη και την καινοτομία στη θαλάσσια επιστήμη."</para>
    /// labels<para>"Marine Institute"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marine_institute">https://w3id.org/earthsemantics/OSO#Marine_institute</seealso>
    let Marine_institute = Prefixed_Name(oso, "Marine_institute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marjolaine_MATABOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Marjolaine MATABOS"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marjolaine_MATABOS">https://w3id.org/earthsemantics/OSO#Marjolaine_MATABOS</seealso>
    let Marjolaine_MATABOS = Prefixed_Name(oso, "Marjolaine_MATABOS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marmara</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Marmara"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marmara">https://w3id.org/earthsemantics/OSO#Marmara</seealso>
    let Marmara = Prefixed_Name(oso, "Marmara") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marmara_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Marmara Autonomous Devices"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marmara_AutonomousDevices">https://w3id.org/earthsemantics/OSO#Marmara_AutonomousDevices</seealso>
    let Marmara_AutonomousDevices =
        Prefixed_Name(oso, "Marmara_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marmara_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Marmara Sea"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marmara_Sea">https://w3id.org/earthsemantics/OSO#Marmara_Sea</seealso>
    let Marmara_Sea = Prefixed_Name(oso, "Marmara_Sea") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Marmara_Sea_RF_bbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3cgeo:BoundingBox</para>
    ///
    /// labels<para>"Marmara Sea Regional Facility bounding box"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Marmara_Sea_RF_bbox">https://w3id.org/earthsemantics/OSO#Marmara_Sea_RF_bbox</seealso>
    let Marmara_Sea_RF_bbox = Prefixed_Name(oso, "Marmara_Sea_RF_bbox") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Martin_PATRIAT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Martin PATRIAT"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Martin_PATRIAT">https://w3id.org/earthsemantics/OSO#Martin_PATRIAT</seealso>
    let Martin_PATRIAT = Prefixed_Name(oso, "Martin_PATRIAT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Mayotte</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#RegionalFacility</para>
    ///
    /// labels<para>"Mayotte"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Mayotte">https://w3id.org/earthsemantics/OSO#Mayotte</seealso>
    let Mayotte = Prefixed_Name(oso, "Mayotte") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MayotteCCNode1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Mayotte CC Node 1"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MayotteCCNode1">https://w3id.org/earthsemantics/OSO#MayotteCCNode1</seealso>
    let MayotteCCNode1 = Prefixed_Name(oso, "MayotteCCNode1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MayotteCCNode2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Mayotte CC Node 2"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MayotteCCNode2">https://w3id.org/earthsemantics/OSO#MayotteCCNode2</seealso>
    let MayotteCCNode2 = Prefixed_Name(oso, "MayotteCCNode2") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MayotteCCNode3</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mayotte CC Node 3"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MayotteCCNode3">https://w3id.org/earthsemantics/OSO#MayotteCCNode3</seealso>
    let MayotteCCNode3 = Prefixed_Name(oso, "MayotteCCNode3") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MayotteCCNode4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Mayotte CC Node 4"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MayotteCCNode4">https://w3id.org/earthsemantics/OSO#MayotteCCNode4</seealso>
    let MayotteCCNode4 = Prefixed_Name(oso, "MayotteCCNode4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MayotteSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Mayotte site"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MayotteSite">https://w3id.org/earthsemantics/OSO#MayotteSite</seealso>
    let MayotteSite = Prefixed_Name(oso, "MayotteSite") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Mohn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///
    /// labels<para>"Mohn"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Mohn">https://w3id.org/earthsemantics/OSO#Mohn</seealso>
    let Mohn = Prefixed_Name(oso, "Mohn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Mohn_Seabed_Station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Mohn Seabed Station"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Mohn_Seabed_Station">https://w3id.org/earthsemantics/OSO#Mohn_Seabed_Station</seealso>
    let Mohn_Seabed_Station = Prefixed_Name(oso, "Mohn_Seabed_Station") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Mohn_Subsurface_mooring</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mohn Subsurface mooring"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Mohn_Subsurface_mooring">https://w3id.org/earthsemantics/OSO#Mohn_Subsurface_mooring</seealso>
    let Mohn_Subsurface_mooring =
        Prefixed_Name(oso, "Mohn_Subsurface_mooring") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Mol%C3%A8ne</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Mol%C3%A8ne">https://w3id.org/earthsemantics/OSO#Mol%C3%A8ne</seealso>
    let ``Mol%C3%A8ne`` = Prefixed_Name(oso, "Mol%C3%A8ne") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Molene</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Molène"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Molene">https://w3id.org/earthsemantics/OSO#Molene</seealso>
    let Molene = Prefixed_Name(oso, "Molene") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Molene_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///
    /// labels<para>"Molène AutonomousDevices"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Molene_AutonomousDevices">https://w3id.org/earthsemantics/OSO#Molene_AutonomousDevices</seealso>
    let Molene_AutonomousDevices =
        Prefixed_Name(oso, "Molene_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Molene_SubmarinePlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Platform</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Molène Submarine Platform"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Molene_SubmarinePlatform">https://w3id.org/earthsemantics/OSO#Molene_SubmarinePlatform</seealso>
    let Molene_SubmarinePlatform =
        Prefixed_Name(oso, "Molene_SubmarinePlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MontSegur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:earthsemantics/OSO#Subsite</para>
    ///
    /// labels<para>"Mont Segur"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MontSegur">https://w3id.org/earthsemantics/OSO#MontSegur</seealso>
    let MontSegur = Prefixed_Name(oso, "MontSegur") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#MontSegur_AutonomousDevices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#MontSegur_AutonomousDevices">https://w3id.org/earthsemantics/OSO#MontSegur_AutonomousDevices</seealso>
    let MontSegur_AutonomousDevices =
        Prefixed_Name(oso, "MontSegur_AutonomousDevices") |> PrefixedName

    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Munida</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:earthsemantics/OSO#Site</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Munida"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Munida">https://w3id.org/earthsemantics/OSO#Munida</seealso>
    let Munida = Prefixed_Name(oso, "Munida") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#NOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NOC"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#NOC">https://w3id.org/earthsemantics/OSO#NOC</seealso>
    let NOC = Prefixed_Name(oso, "NOC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:earthsemantics/OSO#Nadine_LANTERI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:Person</para>
    ///
    /// labels<para>"Nadine LANTERI"</para></remarks>
    /// <seealso href="https://w3id.org/earthsemantics/OSO#Nadine_LANTERI">https://w3id.org/earthsemantics/OSO#Nadine_LANTERI</seealso>
    let Nadine_LANTERI = Prefixed_Name(oso, "Nadine_LANTERI") |> PrefixedName
