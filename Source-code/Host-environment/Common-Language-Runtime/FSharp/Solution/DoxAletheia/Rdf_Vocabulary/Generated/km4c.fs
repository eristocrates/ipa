namespace http.www.disit.org.km4city.schema.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module km4c =
    let _namespace_iri = Namespace_Iri km4c |> NamespaceIRI
    /// <summary>
    ///   <para>km4c:Auditorium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Auditorium</para><para>Auditorium</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Auditorium">http://www.disit.org/km4city/schema#Auditorium</seealso>
    let Auditorium = Prefixed_Name(km4c, "Auditorium") |> PrefixedName

    /// <summary>
    ///   <para>km4c:EducationAndResearch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi quali scuole per ogni eta' e scuole di formazione</para>
    /// labels<para>EducationAndResearch</para><para>Istruzione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#EducationAndResearch">http://www.disit.org/km4city/schema#EducationAndResearch</seealso>
    let EducationAndResearch =
        Prefixed_Name(km4c, "EducationAndResearch") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Bakery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bakery</para><para>Forno</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bakery">http://www.disit.org/km4city/schema#Bakery</seealso>
    let Bakery = Prefixed_Name(km4c, "Bakery") |> PrefixedName
    /// <summary>
    ///   <para>km4c:WineAndFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ristoranti, enoteche e tutte le altre attivita' enogastronomiche</para>
    /// labels<para>Enogastronomia</para><para>Wine And Food</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#WineAndFood">http://www.disit.org/km4city/schema#WineAndFood</seealso>
    let WineAndFood = Prefixed_Name(km4c, "WineAndFood") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Banca</para><para>Bank</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bank">http://www.disit.org/km4city/schema#Bank</seealso>
    let Bank = Prefixed_Name(km4c, "Bank") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Equipment_for_events_and_shows_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio attrezzature per manifestazioni e spettacoli</para><para>Equipment for events and shows rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Equipment_for_events_and_shows_rental">http://www.disit.org/km4city/schema#Equipment_for_events_and_shows_rental</seealso>
    let Equipment_for_events_and_shows_rental =
        Prefixed_Name(km4c, "Equipment_for_events_and_shows_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Building_construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Building Construction</para><para>Costruzione Edifici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Building_construction">http://www.disit.org/km4city/schema#Building_construction</seealso>
    let Building_construction =
        Prefixed_Name(km4c, "Building_construction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Emergency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Contiene tutte le classi relative ai servizi di emergenza</para>
    /// labels<para>Emergenze</para><para>Emergency</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Emergency">http://www.disit.org/km4city/schema#Emergency</seealso>
    let Emergency = Prefixed_Name(km4c, "Emergency") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cargo_handling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Movimentazione Merci</para><para>Cargo Handling</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cargo_handling">http://www.disit.org/km4city/schema#Cargo_handling</seealso>
    let Cargo_handling = Prefixed_Name(km4c, "Cargo_handling") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RailwayJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>2 giunzioni delimitano un elemento ferroviario e rappresentano stazioni ferroviarie o scali merce</para>
    /// labels<para>Giunzione Ferroviaria</para><para>Railway Junction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RailwayJunction">http://www.disit.org/km4city/schema#RailwayJunction</seealso>
    let RailwayJunction = Prefixed_Name(km4c, "RailwayJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Green_areas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Green areas</para><para>Aree verdi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Green_areas">http://www.disit.org/km4city/schema#Green_areas</seealso>
    let Green_areas = Prefixed_Name(km4c, "Green_areas") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Grill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rosticceria</para><para>Grill</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Grill">http://www.disit.org/km4city/schema#Grill</seealso>
    let Grill = Prefixed_Name(km4c, "Grill") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Gym_fitness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Palestra fitness</para><para>Gym fitness</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Gym_fitness">http://www.disit.org/km4city/schema#Gym_fitness</seealso>
    let Gym_fitness = Prefixed_Name(km4c, "Gym_fitness") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Hairdressing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Barbieri e parrucchiere</para><para>Hairdressing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hairdressing">http://www.disit.org/km4city/schema#Hairdressing</seealso>
    let Hairdressing = Prefixed_Name(km4c, "Hairdressing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Hardware_electrical_plumbing_and_heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hardware Electrical Plumbing and Heating</para><para>Ferramenta Elettricita' Termoidraulica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hardware_electrical_plumbing_and_heating">http://www.disit.org/km4city/schema#Hardware_electrical_plumbing_and_heating</seealso>
    let Hardware_electrical_plumbing_and_heating =
        Prefixed_Name(km4c, "Hardware_electrical_plumbing_and_heating") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Hardware_paints_and_glass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hardware Paints and Glass</para><para>Ferramenta Vernici Vetro</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hardware_paints_and_glass">http://www.disit.org/km4city/schema#Hardware_paints_and_glass</seealso>
    let Hardware_paints_and_glass =
        Prefixed_Name(km4c, "Hardware_paints_and_glass") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Performing_arts_schools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Conservatori e accademie</para><para>Performing arts schools</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Performing_arts_schools">http://www.disit.org/km4city/schema#Performing_arts_schools</seealso>
    let Performing_arts_schools =
        Prefixed_Name(km4c, "Performing_arts_schools") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Personal_service_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Personal service activities</para><para>Servizi alla persona</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Personal_service_activities">http://www.disit.org/km4city/schema#Personal_service_activities</seealso>
    let Personal_service_activities =
        Prefixed_Name(km4c, "Personal_service_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Petroleum_and_natural_gas_extraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Petroleum and natural gas extraction</para><para>Estrazione petrolio e gas natuale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Petroleum_and_natural_gas_extraction">http://www.disit.org/km4city/schema#Petroleum_and_natural_gas_extraction</seealso>
    let Petroleum_and_natural_gas_extraction =
        Prefixed_Name(km4c, "Petroleum_and_natural_gas_extraction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pharmaceuticals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Prodotti Farmaceutici</para><para>Pharmaceuticals</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pharmaceuticals">http://www.disit.org/km4city/schema#Pharmaceuticals</seealso>
    let Pharmaceuticals = Prefixed_Name(km4c, "Pharmaceuticals") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Pharmacy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pharmacy</para><para>Farmacia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pharmacy">http://www.disit.org/km4city/schema#Pharmacy</seealso>
    let Pharmacy = Prefixed_Name(km4c, "Pharmacy") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Photovoltaic_system</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>geolocalizzazione degli impianti fotovoltaici funzionanti</para>
    /// labels<para>Impianti fotovoltaici</para><para>Photovoltaic system</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Photovoltaic_system">http://www.disit.org/km4city/schema#Photovoltaic_system</seealso>
    let Photovoltaic_system = Prefixed_Name(km4c, "Photovoltaic_system") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Physical_therapy_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri di riabilitazione</para><para>Physical therapy centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Physical_therapy_centre">http://www.disit.org/km4city/schema#Physical_therapy_centre</seealso>
    let Physical_therapy_centre =
        Prefixed_Name(km4c, "Physical_therapy_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Police_headquarters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Police headquarters</para><para>Questura</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Police_headquarters">http://www.disit.org/km4city/schema#Police_headquarters</seealso>
    let Police_headquarters = Prefixed_Name(km4c, "Police_headquarters") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Pool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Piscina</para><para>Pool</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pool">http://www.disit.org/km4city/schema#Pool</seealso>
    let Pool = Prefixed_Name(km4c, "Pool") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Post_secondary_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Istruzione e formazione tecnica superiore (IFTS)</para><para>Post-secondary education</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Post_secondary_education">http://www.disit.org/km4city/schema#Post_secondary_education</seealso>
    let Post_secondary_education =
        Prefixed_Name(km4c, "Post_secondary_education") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Primary_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Primary education</para><para>Scuole elementari</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Primary_education">http://www.disit.org/km4city/schema#Primary_education</seealso>
    let Primary_education = Prefixed_Name(km4c, "Primary_education") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Printing_and_recorded_media</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Stampa e Supporti Registrati</para><para>Printing and Recorded Media</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Printing_and_recorded_media">http://www.disit.org/km4city/schema#Printing_and_recorded_media</seealso>
    let Printing_and_recorded_media =
        Prefixed_Name(km4c, "Printing_and_recorded_media") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_clinic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Clinica privata</para><para>Private clinic</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_clinic">http://www.disit.org/km4city/schema#Private_clinic</seealso>
    let Private_clinic = Prefixed_Name(km4c, "Private_clinic") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Private_high_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Private high school</para><para>Licei privati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_high_school">http://www.disit.org/km4city/schema#Private_high_school</seealso>
    let Private_high_school = Prefixed_Name(km4c, "Private_high_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_polytechnic_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Private polytechnic school</para><para>Istituti tecnici privati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_polytechnic_school">http://www.disit.org/km4city/schema#Private_polytechnic_school</seealso>
    let Private_polytechnic_school =
        Prefixed_Name(km4c, "Private_polytechnic_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_preschool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Private preschool</para><para>Nidi privati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_preschool">http://www.disit.org/km4city/schema#Private_preschool</seealso>
    let Private_preschool = Prefixed_Name(km4c, "Private_preschool") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_professional_institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Istituti professionali privati</para><para>Private professional institute</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_professional_institute">http://www.disit.org/km4city/schema#Private_professional_institute</seealso>
    let Private_professional_institute =
        Prefixed_Name(km4c, "Private_professional_institute") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Train_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Stazione ferroviaria</para><para>Train station</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Train_station">http://www.disit.org/km4city/schema#Train_station</seealso>
    let Train_station = Prefixed_Name(km4c, "Train_station") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Training_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Formazione e aggiornamento professionale</para><para>Training school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Training_school">http://www.disit.org/km4city/schema#Training_school</seealso>
    let Training_school = Prefixed_Name(km4c, "Training_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Training_school_for_teachers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Training school for teachers</para><para>Istituti magistrali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Training_school_for_teachers">http://www.disit.org/km4city/schema#Training_school_for_teachers</seealso>
    let Training_school_for_teachers =
        Prefixed_Name(km4c, "Training_school_for_teachers") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Translation_and_interpreting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Translation and interpreting</para><para>Traduttori e interpreti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Translation_and_interpreting">http://www.disit.org/km4city/schema#Translation_and_interpreting</seealso>
    let Translation_and_interpreting =
        Prefixed_Name(km4c, "Translation_and_interpreting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:TransverseService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>servizi molto spesso collegati ad altri servizi, che presentano una loro geolocalizzazione</para>
    /// labels<para>Servizio Trasversale</para><para>Transverse Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TransverseService">http://www.disit.org/km4city/schema#TransverseService</seealso>
    let TransverseService = Prefixed_Name(km4c, "TransverseService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Travel_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli da Viaggio</para><para>Travel goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Travel_goods">http://www.disit.org/km4city/schema#Travel_goods</seealso>
    let Travel_goods = Prefixed_Name(km4c, "Travel_goods") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Travel_information</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assistenza Turistica</para><para>Travel information</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Travel_information">http://www.disit.org/km4city/schema#Travel_information</seealso>
    let Travel_information = Prefixed_Name(km4c, "Travel_information") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Trinkets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bigiotteria</para><para>Trinkets</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Trinkets">http://www.disit.org/km4city/schema#Trinkets</seealso>
    let Trinkets = Prefixed_Name(km4c, "Trinkets") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Underwear_knitwear_and_shirts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Underwear, Knitwear and Shirts</para><para>Biancheria Maglieria Camicie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Underwear_knitwear_and_shirts">http://www.disit.org/km4city/schema#Underwear_knitwear_and_shirts</seealso>
    let Underwear_knitwear_and_shirts =
        Prefixed_Name(km4c, "Underwear_knitwear_and_shirts") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Upholsterer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Upholsterer</para><para>Tappezzerie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Upholsterer">http://www.disit.org/km4city/schema#Upholsterer</seealso>
    let Upholsterer = Prefixed_Name(km4c, "Upholsterer") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Useful_numbers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Useful numbers</para><para>Numeri utili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Useful_numbers">http://www.disit.org/km4city/schema#Useful_numbers</seealso>
    let Useful_numbers = Prefixed_Name(km4c, "Useful_numbers") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Vacating_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sgombero di cantine, solai e garage</para><para>Vacating service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Vacating_service">http://www.disit.org/km4city/schema#Vacating_service</seealso>
    let Vacating_service = Prefixed_Name(km4c, "Vacating_service") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Vacation_resort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Residence di villeggiatura</para><para>Vacation resort</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Vacation_resort">http://www.disit.org/km4city/schema#Vacation_resort</seealso>
    let Vacation_resort = Prefixed_Name(km4c, "Vacation_resort") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Vehicle_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio veicoli</para><para>Vehicle rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Vehicle_rental">http://www.disit.org/km4city/schema#Vehicle_rental</seealso>
    let Vehicle_rental = Prefixed_Name(km4c, "Vehicle_rental") |> PrefixedName
    /// <summary>
    ///   <para>km4c:speedLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#speedLimit">http://www.disit.org/km4city/schema#speedLimit</seealso>
    let speedLimit = Prefixed_Name(km4c, "speedLimit") |> PrefixedName
    /// <summary>
    ///   <para>km4c:speedPercentile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#speedPercentile">http://www.disit.org/km4city/schema#speedPercentile</seealso>
    let speedPercentile = Prefixed_Name(km4c, "speedPercentile") |> PrefixedName
    /// <summary>
    ///   <para>km4c:state</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#state">http://www.disit.org/km4city/schema#state</seealso>
    let state = Prefixed_Name(km4c, "state") |> PrefixedName
    /// <summary>
    ///   <para>km4c:stopNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#stopNumber">http://www.disit.org/km4city/schema#stopNumber</seealso>
    let stopNumber = Prefixed_Name(km4c, "stopNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:sunHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#sunHeight">http://www.disit.org/km4city/schema#sunHeight</seealso>
    let sunHeight = Prefixed_Name(km4c, "sunHeight") |> PrefixedName
    /// <summary>
    ///   <para>km4c:sunrise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#sunrise">http://www.disit.org/km4city/schema#sunrise</seealso>
    let sunrise = Prefixed_Name(km4c, "sunrise") |> PrefixedName
    /// <summary>
    ///   <para>km4c:sunset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#sunset">http://www.disit.org/km4city/schema#sunset</seealso>
    let sunset = Prefixed_Name(km4c, "sunset") |> PrefixedName
    /// <summary>
    ///   <para>km4c:supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#supply">http://www.disit.org/km4city/schema#supply</seealso>
    let supply = Prefixed_Name(km4c, "supply") |> PrefixedName
    /// <summary>
    ///   <para>km4c:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#text">http://www.disit.org/km4city/schema#text</seealso>
    let text = Prefixed_Name(km4c, "text") |> PrefixedName
    /// <summary>
    ///   <para>km4c:thresholdPerc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#thresholdPerc">http://www.disit.org/km4city/schema#thresholdPerc</seealso>
    let thresholdPerc = Prefixed_Name(km4c, "thresholdPerc") |> PrefixedName
    /// <summary>
    ///   <para>km4c:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#time">http://www.disit.org/km4city/schema#time</seealso>
    let time = Prefixed_Name(km4c, "time") |> PrefixedName
    /// <summary>
    ///   <para>km4c:timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ANCHE SE VERRA' INSERITO IL COLLEGAMENTO CON INSTANT, QUESTO ATTRIBUTO NON VA CANCELLATO</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#timestamp">http://www.disit.org/km4city/schema#timestamp</seealso>
    let timestamp = Prefixed_Name(km4c, "timestamp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:HealthCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ospedali, studi medici, laboratori analisi e altre strutture che forniscono servizi sanitari</para>
    /// labels<para>Assistenza Sanitaria</para><para>Health Care</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#HealthCare">http://www.disit.org/km4city/schema#HealthCare</seealso>
    let HealthCare = Prefixed_Name(km4c, "HealthCare") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Psychologists</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Psychologists</para><para>Psicologi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Psychologists">http://www.disit.org/km4city/schema#Psychologists</seealso>
    let Psychologists = Prefixed_Name(km4c, "Psychologists") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Travel_bureau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ufficio visite guidate</para><para>Travel bureau</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Travel_bureau">http://www.disit.org/km4city/schema#Travel_bureau</seealso>
    let Travel_bureau = Prefixed_Name(km4c, "Travel_bureau") |> PrefixedName
    /// <summary>
    ///   <para>km4c:occupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#occupancy">http://www.disit.org/km4city/schema#occupancy</seealso>
    let occupancy = Prefixed_Name(km4c, "occupancy") |> PrefixedName
    /// <summary>
    ///   <para>km4c:occupied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>numero di posti occupati</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#occupied">http://www.disit.org/km4city/schema#occupied</seealso>
    let occupied = Prefixed_Name(km4c, "occupied") |> PrefixedName
    /// <summary>
    ///   <para>km4c:operatingStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#operatingStatus">http://www.disit.org/km4city/schema#operatingStatus</seealso>
    let operatingStatus = Prefixed_Name(km4c, "operatingStatus") |> PrefixedName
    /// <summary>
    ///   <para>km4c:parkOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>percentuale di posti occupati</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#parkOccupancy">http://www.disit.org/km4city/schema#parkOccupancy</seealso>
    let parkOccupancy = Prefixed_Name(km4c, "parkOccupancy") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Accommodation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Alberghi e strutture simili</para>
    /// labels<para>Accommodation</para><para>Alloggio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Accommodation">http://www.disit.org/km4city/schema#Accommodation</seealso>
    let Accommodation = Prefixed_Name(km4c, "Accommodation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:UtilitiesAndSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fornitura di utenze e servizi</para>
    /// labels<para>Forniture di servizi</para><para>Utilities and supply</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#UtilitiesAndSupply">http://www.disit.org/km4city/schema#UtilitiesAndSupply</seealso>
    let UtilitiesAndSupply = Prefixed_Name(km4c, "UtilitiesAndSupply") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Addiction_recovery_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Comunita e centri di recupero per dipendenze</para><para>Addiction recovery centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Addiction_recovery_centre">http://www.disit.org/km4city/schema#Addiction_recovery_centre</seealso>
    let Addiction_recovery_centre =
        Prefixed_Name(km4c, "Addiction_recovery_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:RoadElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono gli elementi che compongono le strade</para>
    /// labels<para>Elemento Stradale</para><para>Road element</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RoadElement">http://www.disit.org/km4city/schema#RoadElement</seealso>
    let RoadElement = Prefixed_Name(km4c, "RoadElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Adult_clothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Abbigliamento Uomo Donna</para><para>Adult Clothing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Adult_clothing">http://www.disit.org/km4city/schema#Adult_clothing</seealso>
    let Adult_clothing = Prefixed_Name(km4c, "Adult_clothing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Clothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Abbigliamento</para><para>Clothing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Clothing">http://www.disit.org/km4city/schema#Clothing</seealso>
    let Clothing = Prefixed_Name(km4c, "Clothing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Hunting_trapping_and_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hunting Trapping and Services</para><para>Caccia Cattura e Servizi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hunting_trapping_and_services">http://www.disit.org/km4city/schema#Hunting_trapping_and_services</seealso>
    let Hunting_trapping_and_services =
        Prefixed_Name(km4c, "Hunting_trapping_and_services") |> PrefixedName

    /// <summary>
    ///   <para>km4c:ICT_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi ICT</para><para>ICT service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#ICT_service">http://www.disit.org/km4city/schema#ICT_service</seealso>
    let ICT_service = Prefixed_Name(km4c, "ICT_service") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Income_revenue_authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Income revenue authority</para><para>Agenzia delle entrate</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Income_revenue_authority">http://www.disit.org/km4city/schema#Income_revenue_authority</seealso>
    let Income_revenue_authority =
        Prefixed_Name(km4c, "Income_revenue_authority") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Insurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assicurazione</para><para>Insurance</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Insurance">http://www.disit.org/km4city/schema#Insurance</seealso>
    let Insurance = Prefixed_Name(km4c, "Insurance") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Insurance_and_financial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assicurazione e finanziario</para><para>Insurance and financial</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Insurance_and_financial">http://www.disit.org/km4city/schema#Insurance_and_financial</seealso>
    let Insurance_and_financial =
        Prefixed_Name(km4c, "Insurance_and_financial") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Internet_point_and_public_telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Internet Point and Public Telephone</para><para>Internet Point</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Internet_point_and_public_telephone">http://www.disit.org/km4city/schema#Internet_point_and_public_telephone</seealso>
    let Internet_point_and_public_telephone =
        Prefixed_Name(km4c, "Internet_point_and_public_telephone") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway line is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasElement">http://www.disit.org/km4city/schema#hasElement</seealso>
    let hasElement = Prefixed_Name(km4c, "hasElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isComposedByElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway Section is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isComposedByElement">http://www.disit.org/km4city/schema#isComposedByElement</seealso>
    let isComposedByElement = Prefixed_Name(km4c, "isComposedByElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Recreation_room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Recreation room</para><para>Sala gioco</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Recreation_room">http://www.disit.org/km4city/schema#Recreation_room</seealso>
    let Recreation_room = Prefixed_Name(km4c, "Recreation_room") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Recreational_and_sports_goods_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio  attrezzature sportive e ricreative</para><para>Recreational and Sports Goods rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Recreational_and_sports_goods_rental">http://www.disit.org/km4city/schema#Recreational_and_sports_goods_rental</seealso>
    let Recreational_and_sports_goods_rental =
        Prefixed_Name(km4c, "Recreational_and_sports_goods_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Recruitment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ricerca e Selezione personale</para><para>Recruitment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Recruitment">http://www.disit.org/km4city/schema#Recruitment</seealso>
    let Recruitment = Prefixed_Name(km4c, "Recruitment") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le varie regioni</para>
    /// labels<para>Amministrazione Regionale</para><para>Regional Administration</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Region">http://www.disit.org/km4city/schema#Region</seealso>
    let Region = Prefixed_Name(km4c, "Region") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RegularService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>servizi che possono avere altre caratteristiche, rappresentate come servizi trasversali</para>
    /// labels<para>Servizio Regolare</para><para>Regular Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RegularService">http://www.disit.org/km4city/schema#RegularService</seealso>
    let RegularService = Prefixed_Name(km4c, "RegularService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazioni</para><para>Repair</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair">http://www.disit.org/km4city/schema#Repair</seealso>
    let Repair = Prefixed_Name(km4c, "Repair") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_musical_instruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione strumenti musicali</para><para>Repair musical instruments</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_musical_instruments">http://www.disit.org/km4city/schema#Repair_musical_instruments</seealso>
    let Repair_musical_instruments =
        Prefixed_Name(km4c, "Repair_musical_instruments") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_communication_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione telefoni, cellulari, fax</para><para>Repair of communication equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_communication_equipment">http://www.disit.org/km4city/schema#Repair_of_communication_equipment</seealso>
    let Repair_of_communication_equipment =
        Prefixed_Name(km4c, "Repair_of_communication_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_footwear_and_leather_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione calzature e articolo da viaggio</para><para>Repair of footwear and leather goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_footwear_and_leather_goods">http://www.disit.org/km4city/schema#Repair_of_footwear_and_leather_goods</seealso>
    let Repair_of_footwear_and_leather_goods =
        Prefixed_Name(km4c, "Repair_of_footwear_and_leather_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_garden_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione articoli giardinaggio</para><para>Repair of garden equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_garden_equipment">http://www.disit.org/km4city/schema#Repair_of_garden_equipment</seealso>
    let Repair_of_garden_equipment =
        Prefixed_Name(km4c, "Repair_of_garden_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_home_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione articoli per la casa</para><para>Repair of home equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_home_equipment">http://www.disit.org/km4city/schema#Repair_of_home_equipment</seealso>
    let Repair_of_home_equipment =
        Prefixed_Name(km4c, "Repair_of_home_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Research_and_development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Research and development</para><para>Ricerca e Sviluppo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Research_and_development">http://www.disit.org/km4city/schema#Research_and_development</seealso>
    let Research_and_development =
        Prefixed_Name(km4c, "Research_and_development") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Residential_care_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Residential care activities</para><para>Assistenza residenziale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Residential_care_activities">http://www.disit.org/km4city/schema#Residential_care_activities</seealso>
    let Residential_care_activities =
        Prefixed_Name(km4c, "Residential_care_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#year">http://www.disit.org/km4city/schema#year</seealso>
    let year = Prefixed_Name(km4c, "year") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Other_accommodation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Other Accommodation</para><para>Altre sistemazioni</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_accommodation">http://www.disit.org/km4city/schema#Other_accommodation</seealso>
    let Other_accommodation = Prefixed_Name(km4c, "Other_accommodation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Other_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Vari</para><para>Other Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_goods">http://www.disit.org/km4city/schema#Other_goods</seealso>
    let Other_goods = Prefixed_Name(km4c, "Other_goods") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>attivita' commerciali, servizi al cittadino, uffici...che possono essere localizzati in un punto</para>
    /// labels<para>Servizio</para><para>Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Service">http://www.disit.org/km4city/schema#Service</seealso>
    let Service = Prefixed_Name(km4c, "Service") |> PrefixedName
    /// <summary>
    ///   <para>km4c:FinancialService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>banche, istituti monetari e altri servizi finanziari</para>
    /// labels<para>Servizio Finanziario</para><para>Financial Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#FinancialService">http://www.disit.org/km4city/schema#FinancialService</seealso>
    let FinancialService = Prefixed_Name(km4c, "FinancialService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:ShoppingAndService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>negozi, centri commerciali, spacci, ogni forma di attivita' di vendita al pubblico</para>
    /// labels<para>Shopping and service</para><para>Shopping e servizi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#ShoppingAndService">http://www.disit.org/km4city/schema#ShoppingAndService</seealso>
    let ShoppingAndService = Prefixed_Name(km4c, "ShoppingAndService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Airfields</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Aviosuperfici</para><para>Airfields</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Airfields">http://www.disit.org/km4city/schema#Airfields</seealso>
    let Airfields = Prefixed_Name(km4c, "Airfields") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Airport_lost_property_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ufficio oggetti smarriti aeroporto</para><para>Airport lost property office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Airport_lost_property_office">http://www.disit.org/km4city/schema#Airport_lost_property_office</seealso>
    let Airport_lost_property_office =
        Prefixed_Name(km4c, "Airport_lost_property_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Amusement_and_theme_parks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Parchi divertimento e tematici</para><para>Amusement and theme parks</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Amusement_and_theme_parks">http://www.disit.org/km4city/schema#Amusement_and_theme_parks</seealso>
    let Amusement_and_theme_parks =
        Prefixed_Name(km4c, "Amusement_and_theme_parks") |> PrefixedName

    /// <summary>
    ///   <para>km4c:IndustryAndManufacturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi legati all'industria e al lavoro</para>
    /// labels<para>Industry and manufacturing</para><para>Industria e produzione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#IndustryAndManufacturing">http://www.disit.org/km4city/schema#IndustryAndManufacturing</seealso>
    let IndustryAndManufacturing =
        Prefixed_Name(km4c, "IndustryAndManufacturing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Crop_animal_production_hunting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Animali, Vegetali e Caccia</para><para>Crop Animal Production Hunting</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Crop_animal_production_hunting">http://www.disit.org/km4city/schema#Crop_animal_production_hunting</seealso>
    let Crop_animal_production_hunting =
        Prefixed_Name(km4c, "Crop_animal_production_hunting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Crop_production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Vegetali</para><para>Crop Production</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Crop_production">http://www.disit.org/km4city/schema#Crop_production</seealso>
    let Crop_production = Prefixed_Name(km4c, "Crop_production") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cultural_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centro culturale</para><para>Cultural centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cultural_centre">http://www.disit.org/km4city/schema#Cultural_centre</seealso>
    let Cultural_centre = Prefixed_Name(km4c, "Cultural_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cultural_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Formazione culturale</para><para>Cultural education</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cultural_education">http://www.disit.org/km4city/schema#Cultural_education</seealso>
    let Cultural_education = Prefixed_Name(km4c, "Cultural_education") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Religiuos_guest_house</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Religiuos guest house</para><para>Casa per ferie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Religiuos_guest_house">http://www.disit.org/km4city/schema#Religiuos_guest_house</seealso>
    let Religiuos_guest_house =
        Prefixed_Name(km4c, "Religiuos_guest_house") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_consumer_electronics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Repair of consumer electronics</para><para>Riparazione Tv, video e audio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_consumer_electronics">http://www.disit.org/km4city/schema#Repair_of_consumer_electronics</seealso>
    let Repair_of_consumer_electronics =
        Prefixed_Name(km4c, "Repair_of_consumer_electronics") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_household_appliances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Repair of household appliances</para><para>Riparazione elettrodomestici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_household_appliances">http://www.disit.org/km4city/schema#Repair_of_household_appliances</seealso>
    let Repair_of_household_appliances =
        Prefixed_Name(km4c, "Repair_of_household_appliances") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Reporting_agencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzie di informazioni commerciali</para><para>Reporting agencies</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Reporting_agencies">http://www.disit.org/km4city/schema#Reporting_agencies</seealso>
    let Reporting_agencies = Prefixed_Name(km4c, "Reporting_agencies") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Reproduction_recorded_media</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riproduzione Supporti Registrati</para><para>Reproduction Recorded Media</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Reproduction_recorded_media">http://www.disit.org/km4city/schema#Reproduction_recorded_media</seealso>
    let Reproduction_recorded_media =
        Prefixed_Name(km4c, "Reproduction_recorded_media") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Rest_home</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Casa di riposo</para><para>Rest home</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Rest_home">http://www.disit.org/km4city/schema#Rest_home</seealso>
    let Rest_home = Prefixed_Name(km4c, "Rest_home") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Restaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Restaurant</para><para>Ristorante</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Restaurant">http://www.disit.org/km4city/schema#Restaurant</seealso>
    let Restaurant = Prefixed_Name(km4c, "Restaurant") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Retail_sale_non_specialized_stores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Dettaglio Esercizi Non Specializzati</para><para>Retail Sale Non-Specialized Stores</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Retail_sale_non_specialized_stores">http://www.disit.org/km4city/schema#Retail_sale_non_specialized_stores</seealso>
    let Retail_sale_non_specialized_stores =
        Prefixed_Name(km4c, "Retail_sale_non_specialized_stores") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Retail_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Dettaglio</para><para>Retail Trade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Retail_trade">http://www.disit.org/km4city/schema#Retail_trade</seealso>
    let Retail_trade = Prefixed_Name(km4c, "Retail_trade") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Road</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le strade</para>
    /// labels<para>Strada</para><para>Road</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Road">http://www.disit.org/km4city/schema#Road</seealso>
    let Road = Prefixed_Name(km4c, "Road") |> PrefixedName
    /// <summary>
    ///   <para>km4c:startingJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a road linnk is delimited by two junctions</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#startingJunction">http://www.disit.org/km4city/schema#startingJunction</seealso>
    let startingJunction = Prefixed_Name(km4c, "startingJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:endingJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a road linnk is delimited by two junctions</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#endingJunction">http://www.disit.org/km4city/schema#endingJunction</seealso>
    let endingJunction = Prefixed_Name(km4c, "endingJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Rope_cord_and_twine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Corde, funi e sacchi</para><para>Rope cord and twine</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Rope_cord_and_twine">http://www.disit.org/km4city/schema#Rope_cord_and_twine</seealso>
    let Rope_cord_and_twine = Prefixed_Name(km4c, "Rope_cord_and_twine") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasFirstStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>defines which is the departure stop of a route</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasFirstStop">http://www.disit.org/km4city/schema#hasFirstStop</seealso>
    let hasFirstStop = Prefixed_Name(km4c, "hasFirstStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RouteSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tratto di strada compreso tra due successive fermate dell'autobus di una certa linea</para>
    /// labels<para>Sezione di percorso</para><para>Route Section</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RouteSection">http://www.disit.org/km4city/schema#RouteSection</seealso>
    let RouteSection = Prefixed_Name(km4c, "RouteSection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasFirstSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>defines which is the departure section of a route</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasFirstSection">http://www.disit.org/km4city/schema#hasFirstSection</seealso>
    let hasFirstSection = Prefixed_Name(km4c, "hasFirstSection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RouteJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL</para>
    /// labels<para>giunzione dei percorsi</para><para>Route Junction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RouteJunction">http://www.disit.org/km4city/schema#RouteJunction</seealso>
    let RouteJunction = Prefixed_Name(km4c, "RouteJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:beginsAtJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each routeLink, has a beginning and an end junction</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#beginsAtJunction">http://www.disit.org/km4city/schema#beginsAtJunction</seealso>
    let beginsAtJunction = Prefixed_Name(km4c, "beginsAtJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:startsAtStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a route section is delimited by two consecutive bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#startsAtStop">http://www.disit.org/km4city/schema#startsAtStop</seealso>
    let startsAtStop = Prefixed_Name(km4c, "startsAtStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:endsAtStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a route section is delimited by two consecutive bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#endsAtStop">http://www.disit.org/km4city/schema#endsAtStop</seealso>
    let endsAtStop = Prefixed_Name(km4c, "endsAtStop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sale_of_motor_vehicles_and_motorcycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sale of Motor Vehicles and Motorcycles</para><para>Vendita Autoveicoli Motocicli</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles_and_motorcycles">http://www.disit.org/km4city/schema#Sale_of_motor_vehicles_and_motorcycles</seealso>
    let Sale_of_motor_vehicles_and_motorcycles =
        Prefixed_Name(km4c, "Sale_of_motor_vehicles_and_motorcycles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sale_of_motorcycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sale of Motorcycles</para><para>Vendita Motocicli</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sale_of_motorcycles">http://www.disit.org/km4city/schema#Sale_of_motorcycles</seealso>
    let Sale_of_motorcycles = Prefixed_Name(km4c, "Sale_of_motorcycles") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Second_hand_books</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Second-Hand Books</para><para>Libri Usati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Second_hand_books">http://www.disit.org/km4city/schema#Second_hand_books</seealso>
    let Second_hand_books = Prefixed_Name(km4c, "Second_hand_books") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Second_hand_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Second-Hand Goods</para><para>Articoli Usati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Second_hand_goods">http://www.disit.org/km4city/schema#Second_hand_goods</seealso>
    let Second_hand_goods = Prefixed_Name(km4c, "Second_hand_goods") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Senior_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Senior centre</para><para>Ricoveri</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Senior_centre">http://www.disit.org/km4city/schema#Senior_centre</seealso>
    let Senior_centre = Prefixed_Name(km4c, "Senior_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:SensorSite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensore stradale che rilascia info sul traffico</para>
    ///   <para>Singolo sensore per osservare velocita', traffico, concentrazione o densita'</para>
    /// labels<para>Sensori del traffico</para><para>Traffic sensor</para><para>Sensor</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#SensorSite">http://www.disit.org/km4city/schema#SensorSite</seealso>
    let SensorSite = Prefixed_Name(km4c, "SensorSite") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasStreetNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each road has street numbers</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasStreetNumber">http://www.disit.org/km4city/schema#hasStreetNumber</seealso>
    let hasStreetNumber = Prefixed_Name(km4c, "hasStreetNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#capacity">http://www.disit.org/km4city/schema#capacity</seealso>
    let capacity = Prefixed_Name(km4c, "capacity") |> PrefixedName
    /// <summary>
    ///   <para>km4c:carParkStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#carParkStatus">http://www.disit.org/km4city/schema#carParkStatus</seealso>
    let carParkStatus = Prefixed_Name(km4c, "carParkStatus") |> PrefixedName
    /// <summary>
    ///   <para>km4c:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#category">http://www.disit.org/km4city/schema#category</seealso>
    let category = Prefixed_Name(km4c, "category") |> PrefixedName
    /// <summary>
    ///   <para>km4c:classCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#classCode">http://www.disit.org/km4city/schema#classCode</seealso>
    let classCode = Prefixed_Name(km4c, "classCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:coincideWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>there is no exact match between Road and AdministrativeRoad</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#coincideWith">http://www.disit.org/km4city/schema#coincideWith</seealso>
    let coincideWith = Prefixed_Name(km4c, "coincideWith") |> PrefixedName
    /// <summary>
    ///   <para>km4c:combinedTraffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#combinedTraffic">http://www.disit.org/km4city/schema#combinedTraffic</seealso>
    let combinedTraffic = Prefixed_Name(km4c, "combinedTraffic") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Passenger_air_transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Passenger Air Transport</para><para>Trasporto Aereo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Passenger_air_transport">http://www.disit.org/km4city/schema#Passenger_air_transport</seealso>
    let Passenger_air_transport =
        Prefixed_Name(km4c, "Passenger_air_transport") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pedestrian_zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>pedestrian zone</para><para>area pedonale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pedestrian_zone">http://www.disit.org/km4city/schema#Pedestrian_zone</seealso>
    let Pedestrian_zone = Prefixed_Name(km4c, "Pedestrian_zone") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Personal_and_household_goods_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio di beni personali e per la casa</para><para>Personal and household goods rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Personal_and_household_goods_rental">http://www.disit.org/km4city/schema#Personal_and_household_goods_rental</seealso>
    let Personal_and_household_goods_rental =
        Prefixed_Name(km4c, "Personal_and_household_goods_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pet_care_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pet care services</para><para>Toilette animali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pet_care_services">http://www.disit.org/km4city/schema#Pet_care_services</seealso>
    let Pet_care_services = Prefixed_Name(km4c, "Pet_care_services") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tourist_guides</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Guide Turistiche</para><para>Tourist guides</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tourist_guides">http://www.disit.org/km4city/schema#Tourist_guides</seealso>
    let Tourist_guides = Prefixed_Name(km4c, "Tourist_guides") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tourist_trail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Itinerario turistico</para><para>tourist trail</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tourist_trail">http://www.disit.org/km4city/schema#Tourist_trail</seealso>
    let Tourist_trail = Prefixed_Name(km4c, "Tourist_trail") |> PrefixedName
    /// <summary>
    ///   <para>km4c:concentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#concentration">http://www.disit.org/km4city/schema#concentration</seealso>
    let concentration = Prefixed_Name(km4c, "concentration") |> PrefixedName
    /// <summary>
    ///   <para>km4c:vehicleFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#vehicleFlow">http://www.disit.org/km4city/schema#vehicleFlow</seealso>
    let vehicleFlow = Prefixed_Name(km4c, "vehicleFlow") |> PrefixedName
    /// <summary>
    ///   <para>km4c:averageSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#averageSpeed">http://www.disit.org/km4city/schema#averageSpeed</seealso>
    let averageSpeed = Prefixed_Name(km4c, "averageSpeed") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Traffic_corps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Polizia stradale</para><para>Traffic corps</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Traffic_corps">http://www.disit.org/km4city/schema#Traffic_corps</seealso>
    let Traffic_corps = Prefixed_Name(km4c, "Traffic_corps") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Accommodation_or_office_containers_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Accommodation or office containers rental</para><para>Noleggio Container per alloggi o uffico</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Accommodation_or_office_containers_rental">http://www.disit.org/km4city/schema#Accommodation_or_office_containers_rental</seealso>
    let Accommodation_or_office_containers_rental =
        Prefixed_Name(km4c, "Accommodation_or_office_containers_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Catering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Catering</para><para>Catering</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Catering">http://www.disit.org/km4city/schema#Catering</seealso>
    let Catering = Prefixed_Name(km4c, "Catering") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Pizzeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pizzeria</para><para>Pizzeria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pizzeria">http://www.disit.org/km4city/schema#Pizzeria</seealso>
    let Pizzeria = Prefixed_Name(km4c, "Pizzeria") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Postal_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ufficio postale</para><para>Postal office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Postal_office">http://www.disit.org/km4city/schema#Postal_office</seealso>
    let Postal_office = Prefixed_Name(km4c, "Postal_office") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Prefecture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Prefettura</para><para>Prefecture</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Prefecture">http://www.disit.org/km4city/schema#Prefecture</seealso>
    let Prefecture = Prefixed_Name(km4c, "Prefecture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Printing_and_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Printing and Services</para><para>Stampa e Servizi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Printing_and_services">http://www.disit.org/km4city/schema#Printing_and_services</seealso>
    let Printing_and_services =
        Prefixed_Name(km4c, "Printing_and_services") |> PrefixedName

    /// <summary>
    ///   <para>km4c:TrafficFlow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>sottoclasse delle osservazioni relative alla flusso auto</para>
    /// labels<para>Traffic Flow Observation</para><para>Osservazione sul flusso</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TrafficFlow">http://www.disit.org/km4city/schema#TrafficFlow</seealso>
    let TrafficFlow = Prefixed_Name(km4c, "TrafficFlow") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isPartOfProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a province is formed by more municipalities</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isPartOfProvince">http://www.disit.org/km4city/schema#isPartOfProvince</seealso>
    let isPartOfProvince = Prefixed_Name(km4c, "isPartOfProvince") |> PrefixedName
    /// <summary>
    ///   <para>km4c:juncType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#juncType">http://www.disit.org/km4city/schema#juncType</seealso>
    let juncType = Prefixed_Name(km4c, "juncType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Accountants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ragionieri Commercialisti e periti commerciali</para><para>Accountants</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Accountants">http://www.disit.org/km4city/schema#Accountants</seealso>
    let Accountants = Prefixed_Name(km4c, "Accountants") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Human_health_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Human health activities</para><para>Assistenza Sanitaria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Human_health_activities">http://www.disit.org/km4city/schema#Human_health_activities</seealso>
    let Human_health_activities =
        Prefixed_Name(km4c, "Human_health_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Public_junior_high_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Public junior high school</para><para>Scuole medie pubbliche</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_junior_high_school">http://www.disit.org/km4city/schema#Public_junior_high_school</seealso>
    let Public_junior_high_school =
        Prefixed_Name(km4c, "Public_junior_high_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Urban_bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Autobus urbani</para><para>Urban bus</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Urban_bus">http://www.disit.org/km4city/schema#Urban_bus</seealso>
    let Urban_bus = Prefixed_Name(km4c, "Urban_bus") |> PrefixedName
    /// <summary>
    ///   <para>km4c:overtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#overtime">http://www.disit.org/km4city/schema#overtime</seealso>
    let overtime = Prefixed_Name(km4c, "overtime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:ownerAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the authority that owns the administrative road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#ownerAuthority">http://www.disit.org/km4city/schema#ownerAuthority</seealso>
    let ownerAuthority = Prefixed_Name(km4c, "ownerAuthority") |> PrefixedName
    /// <summary>
    ///   <para>km4c:AdministrativeRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le estese amministrative definite nel grafo stradale</para>
    /// labels<para>Estesa Amministrativa</para><para>Administrative Road</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#AdministrativeRoad">http://www.disit.org/km4city/schema#AdministrativeRoad</seealso>
    let AdministrativeRoad = Prefixed_Name(km4c, "AdministrativeRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Advertising</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi legati al mondo della pubblicita'</para>
    /// labels<para>Pubblicita'</para><para>Advertising</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Advertising">http://www.disit.org/km4city/schema#Advertising</seealso>
    let Advertising = Prefixed_Name(km4c, "Advertising") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Advertising_and_promotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pubblicita' e Concessionarie</para><para>Advertising and promotion</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Advertising_and_promotion">http://www.disit.org/km4city/schema#Advertising_and_promotion</seealso>
    let Advertising_and_promotion =
        Prefixed_Name(km4c, "Advertising_and_promotion") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Agritourism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agriturismo</para><para>Agritourism</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Agritourism">http://www.disit.org/km4city/schema#Agritourism</seealso>
    let Agritourism = Prefixed_Name(km4c, "Agritourism") |> PrefixedName

    /// <summary>
    ///   <para>km4c:TransferServiceAndRenting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Parcheggi auto, stazioni ferroviarie o degli autobus, tutto cio' che deve essere localizzato su una mappa e fa riferimento al trasporto</para>
    /// labels<para>Servizio di trasferimento e noleggio</para><para>Transfer service and renting</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TransferServiceAndRenting">http://www.disit.org/km4city/schema#TransferServiceAndRenting</seealso>
    let TransferServiceAndRenting =
        Prefixed_Name(km4c, "TransferServiceAndRenting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Investigation_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi investigativi privati</para><para>Investigation activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Investigation_activities">http://www.disit.org/km4city/schema#Investigation_activities</seealso>
    let Investigation_activities =
        Prefixed_Name(km4c, "Investigation_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Jeweller</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione orologi e gioielli</para><para>Jeweller</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Jeweller">http://www.disit.org/km4city/schema#Jeweller</seealso>
    let Jeweller = Prefixed_Name(km4c, "Jeweller") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Journalist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Giornalisti indipendenti</para><para>Journalist</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Journalist">http://www.disit.org/km4city/schema#Journalist</seealso>
    let Journalist = Prefixed_Name(km4c, "Journalist") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Knitted_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Knitted Manufacture</para><para>Produzione a Maglia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Knitted_manufacture">http://www.disit.org/km4city/schema#Knitted_manufacture</seealso>
    let Knitted_manufacture = Prefixed_Name(km4c, "Knitted_manufacture") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Land_transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Trasporti Terrestri</para><para>Land Transport</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Land_transport">http://www.disit.org/km4city/schema#Land_transport</seealso>
    let Land_transport = Prefixed_Name(km4c, "Land_transport") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Landscape_care</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cura del paesaggio</para><para>Landscape care</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Landscape_care">http://www.disit.org/km4city/schema#Landscape_care</seealso>
    let Landscape_care = Prefixed_Name(km4c, "Landscape_care") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Laundries_and_dry_cleaners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>laundries and dry cleaners</para><para>Lavenderie e tintorie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Laundries_and_dry_cleaners">http://www.disit.org/km4city/schema#Laundries_and_dry_cleaners</seealso>
    let Laundries_and_dry_cleaners =
        Prefixed_Name(km4c, "Laundries_and_dry_cleaners") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Legal_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Studi Legali</para><para>Legal office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Legal_office">http://www.disit.org/km4city/schema#Legal_office</seealso>
    let Legal_office = Prefixed_Name(km4c, "Legal_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Lifting_and_handling_equipment_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio attrezzature sollevamento e movimentazione</para><para>Lifting and handling equipment rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Lifting_and_handling_equipment_rental">http://www.disit.org/km4city/schema#Lifting_and_handling_equipment_rental</seealso>
    let Lifting_and_handling_equipment_rental =
        Prefixed_Name(km4c, "Lifting_and_handling_equipment_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Lighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Illuminazione</para><para>Lighting</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Lighting">http://www.disit.org/km4city/schema#Lighting</seealso>
    let Lighting = Prefixed_Name(km4c, "Lighting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Local_health_authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Local health authority</para><para>Asl</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Local_health_authority">http://www.disit.org/km4city/schema#Local_health_authority</seealso>
    let Local_health_authority =
        Prefixed_Name(km4c, "Local_health_authority") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Lot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Insieme di linee TPL, individuabili a livello regionale come lotto</para>
    /// labels<para>Lotto TPL</para><para>TPL Lot</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Lot">http://www.disit.org/km4city/schema#Lot</seealso>
    let Lot = Prefixed_Name(km4c, "Lot") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Machinery_repair_and_installation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione Manutenzione Macchinari Utensili</para><para>Machinery Repair and Installation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Machinery_repair_and_installation">http://www.disit.org/km4city/schema#Machinery_repair_and_installation</seealso>
    let Machinery_repair_and_installation =
        Prefixed_Name(km4c, "Machinery_repair_and_installation") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Repair_of_sporting_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione articoli sportivi e da campeggio</para><para>Repair of sporting goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Repair_of_sporting_goods">http://www.disit.org/km4city/schema#Repair_of_sporting_goods</seealso>
    let Repair_of_sporting_goods =
        Prefixed_Name(km4c, "Repair_of_sporting_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Delibera approvata da una qualche Pa</para>
    /// labels<para>Resolution</para><para>Delibera</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Resolution">http://www.disit.org/km4city/schema#Resolution</seealso>
    let Resolution = Prefixed_Name(km4c, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Restorers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Restauratori</para><para>Restorers</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Restorers">http://www.disit.org/km4city/schema#Restorers</seealso>
    let Restorers = Prefixed_Name(km4c, "Restorers") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Retail_motor_vehicles_parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Dettaglio Ricambi Autoveicoli</para><para>Retail Motor Vehicles Parts</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Retail_motor_vehicles_parts">http://www.disit.org/km4city/schema#Retail_motor_vehicles_parts</seealso>
    let Retail_motor_vehicles_parts =
        Prefixed_Name(km4c, "Retail_motor_vehicles_parts") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Ride</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea</para>
    /// labels<para>Corsa</para><para>Ride</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Ride">http://www.disit.org/km4city/schema#Ride</seealso>
    let Ride = Prefixed_Name(km4c, "Ride") |> PrefixedName
    /// <summary>
    ///   <para>km4c:scheduledOnLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a ride can be scheduled on a single line</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#scheduledOnLine">http://www.disit.org/km4city/schema#scheduledOnLine</seealso>
    let scheduledOnLine = Prefixed_Name(km4c, "scheduledOnLine") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Riding_stables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riding stables</para><para>Maneggi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Riding_stables">http://www.disit.org/km4city/schema#Riding_stables</seealso>
    let Riding_stables = Prefixed_Name(km4c, "Riding_stables") |> PrefixedName
    /// <summary>
    ///   <para>km4c:startsAtNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a road element is delimited by 2 nodes</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#startsAtNode">http://www.disit.org/km4city/schema#startsAtNode</seealso>
    let startsAtNode = Prefixed_Name(km4c, "startsAtNode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:endsAtNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a road element is delimited by 2 nodes</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#endsAtNode">http://www.disit.org/km4city/schema#endsAtNode</seealso>
    let endsAtNode = Prefixed_Name(km4c, "endsAtNode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RoadLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tratto di strada lineare delimitato da due giunzioni che compone il road element</para>
    /// labels<para>tratto di strada lineare</para><para>RoadLink</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RoadLink">http://www.disit.org/km4city/schema#RoadLink</seealso>
    let RoadLink = Prefixed_Name(km4c, "RoadLink") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>defines all the other section of a route</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasSection">http://www.disit.org/km4city/schema#hasSection</seealso>
    let hasSection = Prefixed_Name(km4c, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RouteLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tratto di strada delimitato da due TPL junction che determina il percorso di una linea TPL</para>
    /// labels<para>strada di collegamento</para><para>RouteLink</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RouteLink">http://www.disit.org/km4city/schema#RouteLink</seealso>
    let RouteLink = Prefixed_Name(km4c, "RouteLink") |> PrefixedName
    /// <summary>
    ///   <para>km4c:finishesAtJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each routeLink, has a beginning and an end junction</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#finishesAtJunction">http://www.disit.org/km4city/schema#finishesAtJunction</seealso>
    let finishesAtJunction = Prefixed_Name(km4c, "finishesAtJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sailing_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuola di vela</para><para>Sailing school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sailing_school">http://www.disit.org/km4city/schema#Sailing_school</seealso>
    let Sailing_school = Prefixed_Name(km4c, "Sailing_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sale_motor_vehicles_parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ricambi Autoveicoli</para><para>Sale Motor Vehicles Parts</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sale_motor_vehicles_parts">http://www.disit.org/km4city/schema#Sale_motor_vehicles_parts</seealso>
    let Sale_motor_vehicles_parts =
        Prefixed_Name(km4c, "Sale_motor_vehicles_parts") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sale_of_motor_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sale of Motor Vehicles</para><para>Vendita Autoveicoli</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sale_of_motor_vehicles">http://www.disit.org/km4city/schema#Sale_of_motor_vehicles</seealso>
    let Sale_of_motor_vehicles =
        Prefixed_Name(km4c, "Sale_of_motor_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sale_via_mail_order_houses_or_via_internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sale Via Mail Order Houses or Via Internet</para><para>Vendita per Corrispondenza o via Internet</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sale_via_mail_order_houses_or_via_internet">http://www.disit.org/km4city/schema#Sale_via_mail_order_houses_or_via_internet</seealso>
    let Sale_via_mail_order_houses_or_via_internet =
        Prefixed_Name(km4c, "Sale_via_mail_order_houses_or_via_internet") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sandwich_shop_pub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sandwich shop pub</para><para>Paninoteche pubs</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sandwich_shop_pub">http://www.disit.org/km4city/schema#Sandwich_shop_pub</seealso>
    let Sandwich_shop_pub = Prefixed_Name(km4c, "Sandwich_shop_pub") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sanitary_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Igienico-Sanitari</para><para>Sanitary Equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sanitary_equipment">http://www.disit.org/km4city/schema#Sanitary_equipment</seealso>
    let Sanitary_equipment = Prefixed_Name(km4c, "Sanitary_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Secretarial_support_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Secretarial support services</para><para>Supporto di segreteria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Secretarial_support_services">http://www.disit.org/km4city/schema#Secretarial_support_services</seealso>
    let Secretarial_support_services =
        Prefixed_Name(km4c, "Secretarial_support_services") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Security_systems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Allarmi e sistemi di sicurezza</para><para>Security systems</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Security_systems">http://www.disit.org/km4city/schema#Security_systems</seealso>
    let Security_systems = Prefixed_Name(km4c, "Security_systems") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Security_systems_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Security systems service</para><para>Sistemi di sicurezza</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Security_systems_service">http://www.disit.org/km4city/schema#Security_systems_service</seealso>
    let Security_systems_service =
        Prefixed_Name(km4c, "Security_systems_service") |> PrefixedName

    /// <summary>
    ///   <para>km4c:SensorSiteTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Insieme di sensori che rappresentano un unica installazione, un unico sito</para>
    /// labels<para>Tabella di sensori</para><para>Sensor Site Table</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#SensorSiteTable">http://www.disit.org/km4city/schema#SensorSiteTable</seealso>
    let SensorSiteTable = Prefixed_Name(km4c, "SensorSiteTable") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sewerage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rete Fognaria</para><para>Sewerage</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sewerage">http://www.disit.org/km4city/schema#Sewerage</seealso>
    let Sewerage = Prefixed_Name(km4c, "Sewerage") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sexy_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sexy Shop</para><para>Sexy Shop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sexy_shop">http://www.disit.org/km4city/schema#Sexy_shop</seealso>
    let Sexy_shop = Prefixed_Name(km4c, "Sexy_shop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Shopping_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri Commerciali</para><para>Shopping centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Shopping_centre">http://www.disit.org/km4city/schema#Shopping_centre</seealso>
    let Shopping_centre = Prefixed_Name(km4c, "Shopping_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Single_brand_store</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Single brand store</para><para>Negozi monomarca</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Single_brand_store">http://www.disit.org/km4city/schema#Single_brand_store</seealso>
    let Single_brand_store = Prefixed_Name(km4c, "Single_brand_store") |> PrefixedName
    /// <summary>
    ///   <para>km4c:SituationRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Registrazione della situazione di occupazione di un determinato parcheggio in un certo istante</para>
    /// labels<para>Situation Record of a Car Park</para><para>Situazione di un parcheggio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#SituationRecord">http://www.disit.org/km4city/schema#SituationRecord</seealso>
    let SituationRecord = Prefixed_Name(km4c, "SituationRecord") |> PrefixedName
    /// <summary>
    ///   <para>km4c:relatedToSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>every XX minutes a sensor sends a report</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#relatedToSensor">http://www.disit.org/km4city/schema#relatedToSensor</seealso>
    let relatedToSensor = Prefixed_Name(km4c, "relatedToSensor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Ski_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuola di sci</para><para>Ski school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Ski_school">http://www.disit.org/km4city/schema#Ski_school</seealso>
    let Ski_school = Prefixed_Name(km4c, "Ski_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Small_household_appliances</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Small Household Appliances</para><para>Piccoli Elettrodomestici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Small_household_appliances">http://www.disit.org/km4city/schema#Small_household_appliances</seealso>
    let Small_household_appliances =
        Prefixed_Name(km4c, "Small_household_appliances") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Small_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Small shop</para><para>Bottega</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Small_shop">http://www.disit.org/km4city/schema#Small_shop</seealso>
    let Small_shop = Prefixed_Name(km4c, "Small_shop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Social_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centro sociale</para><para>Social centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Social_centre">http://www.disit.org/km4city/schema#Social_centre</seealso>
    let Social_centre = Prefixed_Name(km4c, "Social_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Social_security_service_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Social security service office</para><para>Ufficio inps</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Social_security_service_office">http://www.disit.org/km4city/schema#Social_security_service_office</seealso>
    let Social_security_service_office =
        Prefixed_Name(km4c, "Social_security_service_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Social_work</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assistenza sociale</para><para>Social work</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Social_work">http://www.disit.org/km4city/schema#Social_work</seealso>
    let Social_work = Prefixed_Name(km4c, "Social_work") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sound_recording_and_music_publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Registrazione sonora e editoria musicale</para><para>Sound Recording and Music Publishing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sound_recording_and_music_publishing">http://www.disit.org/km4city/schema#Sound_recording_and_music_publishing</seealso>
    let Sound_recording_and_music_publishing =
        Prefixed_Name(km4c, "Sound_recording_and_music_publishing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Souvenirs_Craftwork_and_religious_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Souvenirs Craftwork and Religious Articles</para><para>Souvenir Artigianato e Articoli Religiosi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Souvenirs_Craftwork_and_religious_articles">http://www.disit.org/km4city/schema#Souvenirs_Craftwork_and_religious_articles</seealso>
    let Souvenirs_Craftwork_and_religious_articles =
        Prefixed_Name(km4c, "Souvenirs_Craftwork_and_religious_articles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Specialized_construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Lavori Costruzione Specializzati</para><para>Specialized Construction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Specialized_construction">http://www.disit.org/km4city/schema#Specialized_construction</seealso>
    let Specialized_construction =
        Prefixed_Name(km4c, "Specialized_construction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Specialized_design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Grafici e disegnatori</para><para>Specialized Design</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Specialized_design">http://www.disit.org/km4city/schema#Specialized_design</seealso>
    let Specialized_design = Prefixed_Name(km4c, "Specialized_design") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sport_event_promoters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Organizzazione eventi sportivi</para><para>Sport event promoters</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sport_event_promoters">http://www.disit.org/km4city/schema#Sport_event_promoters</seealso>
    let Sport_event_promoters =
        Prefixed_Name(km4c, "Sport_event_promoters") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sports_and_recreation_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sports and recreation education</para><para>Corsi sportivi e ricreativi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sports_and_recreation_education">http://www.disit.org/km4city/schema#Sports_and_recreation_education</seealso>
    let Sports_and_recreation_education =
        Prefixed_Name(km4c, "Sports_and_recreation_education") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sports_clubs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Societa' sportive</para><para>Sports clubs</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sports_clubs">http://www.disit.org/km4city/schema#Sports_clubs</seealso>
    let Sports_clubs = Prefixed_Name(km4c, "Sports_clubs") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sports_facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Impianti sportivi</para><para>Sports facility</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sports_facility">http://www.disit.org/km4city/schema#Sports_facility</seealso>
    let Sports_facility = Prefixed_Name(km4c, "Sports_facility") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Squares</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Squares</para><para>Piazze</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Squares">http://www.disit.org/km4city/schema#Squares</seealso>
    let Squares = Prefixed_Name(km4c, "Squares") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Stalls_and_markets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Stalls and Markets</para><para>Vendita Ambulante</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stalls_and_markets">http://www.disit.org/km4city/schema#Stalls_and_markets</seealso>
    let Stalls_and_markets = Prefixed_Name(km4c, "Stalls_and_markets") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Stalls_and_markets_of_food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ambulante Alimentari</para><para>Stalls and Markets of Food</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_food">http://www.disit.org/km4city/schema#Stalls_and_markets_of_food</seealso>
    let Stalls_and_markets_of_food =
        Prefixed_Name(km4c, "Stalls_and_markets_of_food") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Stalls_and_markets_other_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ambulante Altri Prodotti</para><para>Stalls and Markets Other Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stalls_and_markets_other_goods">http://www.disit.org/km4city/schema#Stalls_and_markets_other_goods</seealso>
    let Stalls_and_markets_other_goods =
        Prefixed_Name(km4c, "Stalls_and_markets_other_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Stamps_and_coins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Filatelia e Numismatica</para><para>Stamps and Coins</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stamps_and_coins">http://www.disit.org/km4city/schema#Stamps_and_coins</seealso>
    let Stamps_and_coins = Prefixed_Name(km4c, "Stamps_and_coins") |> PrefixedName
    /// <summary>
    ///   <para>km4c:StatisticalData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Valore che fa riferimento ad un dato statistico legato ad una strada o ad una Pa</para>
    /// labels<para>Dato statistico</para><para>StatisticalData</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#StatisticalData">http://www.disit.org/km4city/schema#StatisticalData</seealso>
    let StatisticalData = Prefixed_Name(km4c, "StatisticalData") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Stone_processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Lavorazione Pietra</para><para>Stone Processing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stone_processing">http://www.disit.org/km4city/schema#Stone_processing</seealso>
    let Stone_processing = Prefixed_Name(km4c, "Stone_processing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasInternalAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>it corresponds to the door of the building</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasInternalAccess">http://www.disit.org/km4city/schema#hasInternalAccess</seealso>
    let hasInternalAccess = Prefixed_Name(km4c, "hasInternalAccess") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasLastStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>defines which is the last stop of a route</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasLastStop">http://www.disit.org/km4city/schema#hasLastStop</seealso>
    let hasLastStop = Prefixed_Name(km4c, "hasLastStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasLastStopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the arrival time at last bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasLastStopTime">http://www.disit.org/km4city/schema#hasLastStopTime</seealso>
    let hasLastStopTime = Prefixed_Name(km4c, "hasLastStopTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantAVM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the arrival time at last bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantAVM">http://www.disit.org/km4city/schema#instantAVM</seealso>
    let instantAVM = Prefixed_Name(km4c, "instantAVM") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasManeuver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an entry rule can be connected to a specific maneuver</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasManeuver">http://www.disit.org/km4city/schema#hasManeuver</seealso>
    let hasManeuver = Prefixed_Name(km4c, "hasManeuver") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a province is formed by more municipalities</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasMunicipality">http://www.disit.org/km4city/schema#hasMunicipality</seealso>
    let hasMunicipality = Prefixed_Name(km4c, "hasMunicipality") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each road sensor produce a report every XX minuts</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasObservation">http://www.disit.org/km4city/schema#hasObservation</seealso>
    let hasObservation = Prefixed_Name(km4c, "hasObservation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isPartOfRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>in a region there are more than one province</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isPartOfRegion">http://www.disit.org/km4city/schema#isPartOfRegion</seealso>
    let isPartOfRegion = Prefixed_Name(km4c, "isPartOfRegion") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>every 10 minutes a sensor sends a report</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRecord">http://www.disit.org/km4city/schema#hasRecord</seealso>
    let hasRecord = Prefixed_Name(km4c, "hasRecord") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRegularService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>regular services can be connected to transverse services</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRegularService">http://www.disit.org/km4city/schema#hasRegularService</seealso>
    let hasRegularService = Prefixed_Name(km4c, "hasRegularService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each route refers to a line</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRoute">http://www.disit.org/km4city/schema#hasRoute</seealso>
    let hasRoute = Prefixed_Name(km4c, "hasRoute") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRouteLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRouteLink">http://www.disit.org/km4city/schema#hasRouteLink</seealso>
    let hasRouteLink = Prefixed_Name(km4c, "hasRouteLink") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>some road elements subject to rules of access</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRule">http://www.disit.org/km4city/schema#hasRule</seealso>
    let hasRule = Prefixed_Name(km4c, "hasRule") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasSegment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each road element can be see as a collection of consecutive road link</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasSegment">http://www.disit.org/km4city/schema#hasSegment</seealso>
    let hasSegment = Prefixed_Name(km4c, "hasSegment") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasStatistic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect a statistic to the referred municipality</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasStatistic">http://www.disit.org/km4city/schema#hasStatistic</seealso>
    let hasStatistic = Prefixed_Name(km4c, "hasStatistic") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Agents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenti e procuratori</para><para>Agents</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Agents">http://www.disit.org/km4city/schema#Agents</seealso>
    let Agents = Prefixed_Name(km4c, "Agents") |> PrefixedName
    /// <summary>
    ///   <para>km4c:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>sente proprietario del sistema AVM</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#owner">http://www.disit.org/km4city/schema#owner</seealso>
    let owner = Prefixed_Name(km4c, "owner") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Clothing_accessories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Accessori Abbigliamento</para><para>Clothing Accessories</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Clothing_accessories">http://www.disit.org/km4city/schema#Clothing_accessories</seealso>
    let Clothing_accessories =
        Prefixed_Name(km4c, "Clothing_accessories") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Clothing_factory_outlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Spacci outlet abbigliamento</para><para>Clothing factory outlet</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Clothing_factory_outlet">http://www.disit.org/km4city/schema#Clothing_factory_outlet</seealso>
    let Clothing_factory_outlet =
        Prefixed_Name(km4c, "Clothing_factory_outlet") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Coke_and_petroleum_derivatives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Coke and Petroleum Derivatives</para><para>Coke e Petroliferi Derivati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Coke_and_petroleum_derivatives">http://www.disit.org/km4city/schema#Coke_and_petroleum_derivatives</seealso>
    let Coke_and_petroleum_derivatives =
        Prefixed_Name(km4c, "Coke_and_petroleum_derivatives") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Community_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Community centre</para><para>Centri diurni</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Community_centre">http://www.disit.org/km4city/schema#Community_centre</seealso>
    let Community_centre = Prefixed_Name(km4c, "Community_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Computer_systems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Computer Systems</para><para>Informatica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Computer_systems">http://www.disit.org/km4city/schema#Computer_systems</seealso>
    let Computer_systems = Prefixed_Name(km4c, "Computer_systems") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Wedding_favors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wedding Favors</para><para>Bomboniere</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wedding_favors">http://www.disit.org/km4city/schema#Wedding_favors</seealso>
    let Wedding_favors = Prefixed_Name(km4c, "Wedding_favors") |> PrefixedName
    /// <summary>
    ///   <para>km4c:trackType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#trackType">http://www.disit.org/km4city/schema#trackType</seealso>
    let trackType = Prefixed_Name(km4c, "trackType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:trafficDir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#trafficDir">http://www.disit.org/km4city/schema#trafficDir</seealso>
    let trafficDir = Prefixed_Name(km4c, "trafficDir") |> PrefixedName

    /// <summary>
    ///   <para>km4c:AgricultureAndLivestock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Attivita' e servizi relativi ad agricoltura ed allevamento</para>
    /// labels<para>Agricoltura ed allevamento</para><para>Agriculture and livestock</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#AgricultureAndLivestock">http://www.disit.org/km4city/schema#AgricultureAndLivestock</seealso>
    let AgricultureAndLivestock =
        Prefixed_Name(km4c, "AgricultureAndLivestock") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Airplanes_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Airplanes rental</para><para>Noleggio aerei</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Airplanes_rental">http://www.disit.org/km4city/schema#Airplanes_rental</seealso>
    let Airplanes_rental = Prefixed_Name(km4c, "Airplanes_rental") |> PrefixedName
    /// <summary>
    ///   <para>km4c:GovernmentOffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Uffici aperti al pubblico</para>
    /// labels<para>Government Office</para><para>Uffici Pubblici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#GovernmentOffice">http://www.disit.org/km4city/schema#GovernmentOffice</seealso>
    let GovernmentOffice = Prefixed_Name(km4c, "GovernmentOffice") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Entertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi per l'intrattenimento del cittadino</para>
    /// labels<para>Intrattenimento</para><para>Entertainment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Entertainment">http://www.disit.org/km4city/schema#Entertainment</seealso>
    let Entertainment = Prefixed_Name(km4c, "Entertainment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Animal_feeds_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Animal Feeds Manufacture</para><para>Produzione Mangimi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Animal_feeds_manufacture">http://www.disit.org/km4city/schema#Animal_feeds_manufacture</seealso>
    let Animal_feeds_manufacture =
        Prefixed_Name(km4c, "Animal_feeds_manufacture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Antiques</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Antichita'</para><para>Antiques</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Antiques">http://www.disit.org/km4city/schema#Antiques</seealso>
    let Antiques = Prefixed_Name(km4c, "Antiques") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Dating_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzie matrimoniali</para><para>Dating service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Dating_service">http://www.disit.org/km4city/schema#Dating_service</seealso>
    let Dating_service = Prefixed_Name(km4c, "Dating_service") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Maintenance_repair_of_motor_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manutenzione Riparazione Autoveicoli</para><para>Maintenance Repair of Motor Vehicles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motor_vehicles">http://www.disit.org/km4city/schema#Maintenance_repair_of_motor_vehicles</seealso>
    let Maintenance_repair_of_motor_vehicles =
        Prefixed_Name(km4c, "Maintenance_repair_of_motor_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasSecondElem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the second element concerned the maneuver</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasSecondElem">http://www.disit.org/km4city/schema#hasSecondElem</seealso>
    let hasSecondElem = Prefixed_Name(km4c, "hasSecondElem") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Wifi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Punto di accesso alla WiFi</para><para>Free WiFi point</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wifi">http://www.disit.org/km4city/schema#Wifi</seealso>
    let Wifi = Prefixed_Name(km4c, "Wifi") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Hypermarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hypermarket</para><para>Ipermercati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hypermarket">http://www.disit.org/km4city/schema#Hypermarket</seealso>
    let Hypermarket = Prefixed_Name(km4c, "Hypermarket") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Ice_cream_parlour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ice cream parlour</para><para>Gelateria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Ice_cream_parlour">http://www.disit.org/km4city/schema#Ice_cream_parlour</seealso>
    let Ice_cream_parlour = Prefixed_Name(km4c, "Ice_cream_parlour") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Industrial_laundries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Lavanderie industriali</para><para>industrial laundries</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Industrial_laundries">http://www.disit.org/km4city/schema#Industrial_laundries</seealso>
    let Industrial_laundries =
        Prefixed_Name(km4c, "Industrial_laundries") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Installation_of_industrial_machinery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Installation of Industrial Machinery</para><para>Installazione Macchinari Industriali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Installation_of_industrial_machinery">http://www.disit.org/km4city/schema#Installation_of_industrial_machinery</seealso>
    let Installation_of_industrial_machinery =
        Prefixed_Name(km4c, "Installation_of_industrial_machinery") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Internet_service_provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi di accesso ad internet</para><para>Internet Service Provider</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Internet_service_provider">http://www.disit.org/km4city/schema#Internet_service_provider</seealso>
    let Internet_service_provider =
        Prefixed_Name(km4c, "Internet_service_provider") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Italian_finance_police</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Italian finance police</para><para>Guardia di finanza</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Italian_finance_police">http://www.disit.org/km4city/schema#Italian_finance_police</seealso>
    let Italian_finance_police =
        Prefixed_Name(km4c, "Italian_finance_police") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Jewellery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Gioielleria</para><para>Jewellery</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Jewellery">http://www.disit.org/km4city/schema#Jewellery</seealso>
    let Jewellery = Prefixed_Name(km4c, "Jewellery") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Junction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Punto di interconnessione tra segmenti di strada per disegnare un RoadElement</para>
    /// labels<para>giunzione stradale</para><para>Junction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Junction">http://www.disit.org/km4city/schema#Junction</seealso>
    let Junction = Prefixed_Name(km4c, "Junction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Labour_consultant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Consulenti del lavoro</para><para>Labour consultant</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Labour_consultant">http://www.disit.org/km4city/schema#Labour_consultant</seealso>
    let Labour_consultant = Prefixed_Name(km4c, "Labour_consultant") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Land_transport_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio altri mezzi trasporto terrestri</para><para>Land-transport rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Land_transport_rental">http://www.disit.org/km4city/schema#Land_transport_rental</seealso>
    let Land_transport_rental =
        Prefixed_Name(km4c, "Land_transport_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Language_courses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Language courses</para><para>Corsi di lingue</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Language_courses">http://www.disit.org/km4city/schema#Language_courses</seealso>
    let Language_courses = Prefixed_Name(km4c, "Language_courses") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Leasing_of_intellectual_property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Concessione dei diritti di sfruttamento di proprieta' intellettuale</para><para>Leasing of intellectual property</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Leasing_of_intellectual_property">http://www.disit.org/km4city/schema#Leasing_of_intellectual_property</seealso>
    let Leasing_of_intellectual_property =
        Prefixed_Name(km4c, "Leasing_of_intellectual_property") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Leather_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione in Pelle</para><para>Leather Manufacture</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Leather_manufacture">http://www.disit.org/km4city/schema#Leather_manufacture</seealso>
    let Leather_manufacture = Prefixed_Name(km4c, "Leather_manufacture") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Library</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Biblioteca</para><para>Library</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Library">http://www.disit.org/km4city/schema#Library</seealso>
    let Library = Prefixed_Name(km4c, "Library") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Literary_cafe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>caffe letterario</para><para>literary cafe</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Literary_cafe">http://www.disit.org/km4city/schema#Literary_cafe</seealso>
    let Literary_cafe = Prefixed_Name(km4c, "Literary_cafe") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Local_police</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Polizia municipale</para><para>Local police</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Local_police">http://www.disit.org/km4city/schema#Local_police</seealso>
    let Local_police = Prefixed_Name(km4c, "Local_police") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Logistics_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Attivita' di Logistica</para><para>Logistics Activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Logistics_activities">http://www.disit.org/km4city/schema#Logistics_activities</seealso>
    let Logistics_activities =
        Prefixed_Name(km4c, "Logistics_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Machinery_and_equipment_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio macchinari e attrezzature </para><para>Machinery and Eequipment Rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Machinery_and_equipment_rental">http://www.disit.org/km4city/schema#Machinery_and_equipment_rental</seealso>
    let Machinery_and_equipment_rental =
        Prefixed_Name(km4c, "Machinery_and_equipment_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Maintenance_repair_of_motorcycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manutenzione Riparazione Motocicli</para><para>Maintenance Repair of Motorcycles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Maintenance_repair_of_motorcycles">http://www.disit.org/km4city/schema#Maintenance_repair_of_motorcycles</seealso>
    let Maintenance_repair_of_motorcycles =
        Prefixed_Name(km4c, "Maintenance_repair_of_motorcycles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Management_consultancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Consulenza Imprenditoriale e Gestionale</para><para>Management consultancy</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Management_consultancy">http://www.disit.org/km4city/schema#Management_consultancy</seealso>
    let Management_consultancy =
        Prefixed_Name(km4c, "Management_consultancy") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Maneuver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le possibili manovre che possono essere effettuate su un elemento stradale</para>
    /// labels<para>Maneuver</para><para>Manovra</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Maneuver">http://www.disit.org/km4city/schema#Maneuver</seealso>
    let Maneuver = Prefixed_Name(km4c, "Maneuver") |> PrefixedName
    /// <summary>
    ///   <para>km4c:concerningNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a maneuver takes place in correspondence of a node</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#concerningNode">http://www.disit.org/km4city/schema#concerningNode</seealso>
    let concerningNode = Prefixed_Name(km4c, "concerningNode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasThirdElem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the third element concerned the maneuver</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasThirdElem">http://www.disit.org/km4city/schema#hasThirdElem</seealso>
    let hasThirdElem = Prefixed_Name(km4c, "hasThirdElem") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasFirstElem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the first element concerned the maneuver</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasFirstElem">http://www.disit.org/km4city/schema#hasFirstElem</seealso>
    let hasFirstElem = Prefixed_Name(km4c, "hasFirstElem") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manicure_and_pedicure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manicure and pedicure</para><para>Manicure e pedicure</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manicure_and_pedicure">http://www.disit.org/km4city/schema#Manicure_and_pedicure</seealso>
    let Manicure_and_pedicure =
        Prefixed_Name(km4c, "Manicure_and_pedicure") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_basic_metals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Basic Metals</para><para>Attivita' Metallurgiche</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_basic_metals">http://www.disit.org/km4city/schema#Manufacture_of_basic_metals</seealso>
    let Manufacture_of_basic_metals =
        Prefixed_Name(km4c, "Manufacture_of_basic_metals") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_chemicals_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Chemicals Products</para><para>Produzione Prodotti Chimici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_chemicals_products">http://www.disit.org/km4city/schema#Manufacture_of_chemicals_products</seealso>
    let Manufacture_of_chemicals_products =
        Prefixed_Name(km4c, "Manufacture_of_chemicals_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_clay_and_ceramic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Ceramica e Terracotta</para><para>Manufacture of Clay and Ceramic</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_clay_and_ceramic">http://www.disit.org/km4city/schema#Manufacture_of_clay_and_ceramic</seealso>
    let Manufacture_of_clay_and_ceramic =
        Prefixed_Name(km4c, "Manufacture_of_clay_and_ceramic") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_electronic_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Electronic Products</para><para>Produzione Prodotti Elettronici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_electronic_products">http://www.disit.org/km4city/schema#Manufacture_of_electronic_products</seealso>
    let Manufacture_of_electronic_products =
        Prefixed_Name(km4c, "Manufacture_of_electronic_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Furniture</para><para>Produzione Mobili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_furniture">http://www.disit.org/km4city/schema#Manufacture_of_furniture</seealso>
    let Manufacture_of_furniture =
        Prefixed_Name(km4c, "Manufacture_of_furniture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_glass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione e Lavorazione Vetro</para><para>Manufacture of Glass</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_glass">http://www.disit.org/km4city/schema#Manufacture_of_glass</seealso>
    let Manufacture_of_glass =
        Prefixed_Name(km4c, "Manufacture_of_glass") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_machinery_and_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Machinery and Equipment</para><para>Produzione Macchinari e Utensili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_machinery_and_equipment">http://www.disit.org/km4city/schema#Manufacture_of_machinery_and_equipment</seealso>
    let Manufacture_of_machinery_and_equipment =
        Prefixed_Name(km4c, "Manufacture_of_machinery_and_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_motor_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Motor Vehicles</para><para>Produzione Autoveicoli</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_motor_vehicles">http://www.disit.org/km4city/schema#Manufacture_of_motor_vehicles</seealso>
    let Manufacture_of_motor_vehicles =
        Prefixed_Name(km4c, "Manufacture_of_motor_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_non_metallic_mineral_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Non-Metallic Mineral Products</para><para>Produzione Prodotti Minerali non Metalliferi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_non_metallic_mineral_products">http://www.disit.org/km4city/schema#Manufacture_of_non_metallic_mineral_products</seealso>
    let Manufacture_of_non_metallic_mineral_products =
        Prefixed_Name(km4c, "Manufacture_of_non_metallic_mineral_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_paper</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Industria della Carta</para><para>Manufacture of Paper</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_paper">http://www.disit.org/km4city/schema#Manufacture_of_paper</seealso>
    let Manufacture_of_paper =
        Prefixed_Name(km4c, "Manufacture_of_paper") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_paper_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Paper Products</para><para>Produzione Prodotti di Carta</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_paper_products">http://www.disit.org/km4city/schema#Manufacture_of_paper_products</seealso>
    let Manufacture_of_paper_products =
        Prefixed_Name(km4c, "Manufacture_of_paper_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_plastics_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Plastics Products</para><para>Produzione Prodotti di Plastica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_plastics_products">http://www.disit.org/km4city/schema#Manufacture_of_plastics_products</seealso>
    let Manufacture_of_plastics_products =
        Prefixed_Name(km4c, "Manufacture_of_plastics_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_refined_petroleum_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Refined Petroleum Products</para><para>Produzione Prodotti Petroliferi Raffinati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_refined_petroleum_products">http://www.disit.org/km4city/schema#Manufacture_of_refined_petroleum_products</seealso>
    let Manufacture_of_refined_petroleum_products =
        Prefixed_Name(km4c, "Manufacture_of_refined_petroleum_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_refractory_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Refractory Products</para><para>Produzione Prodotti Refrattari</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_refractory_products">http://www.disit.org/km4city/schema#Manufacture_of_refractory_products</seealso>
    let Manufacture_of_refractory_products =
        Prefixed_Name(km4c, "Manufacture_of_refractory_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_rubber_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Rubber Products</para><para>Produzione Prodotti di Gomma</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_products">http://www.disit.org/km4city/schema#Manufacture_of_rubber_products</seealso>
    let Manufacture_of_rubber_products =
        Prefixed_Name(km4c, "Manufacture_of_rubber_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_sports_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Articoli Sportivi</para><para>Manufacture of Sports Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_sports_goods">http://www.disit.org/km4city/schema#Manufacture_of_sports_goods</seealso>
    let Manufacture_of_sports_goods =
        Prefixed_Name(km4c, "Manufacture_of_sports_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_textiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of textiles</para><para>Industrie Tessile</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_textiles">http://www.disit.org/km4city/schema#Manufacture_of_textiles</seealso>
    let Manufacture_of_textiles =
        Prefixed_Name(km4c, "Manufacture_of_textiles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_toys_and_game</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Toys and Game</para><para>Produzione Gioattoli Giochi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_toys_and_game">http://www.disit.org/km4city/schema#Manufacture_of_toys_and_game</seealso>
    let Manufacture_of_toys_and_game =
        Prefixed_Name(km4c, "Manufacture_of_toys_and_game") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_transport_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Transport Equipment</para><para>Produzione Mezzi di Trasporto</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_transport_equipment">http://www.disit.org/km4city/schema#Manufacture_of_transport_equipment</seealso>
    let Manufacture_of_transport_equipment =
        Prefixed_Name(km4c, "Manufacture_of_transport_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_travel_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Articoli da Viaggio</para><para>Manufacture of Travel Articles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_travel_articles">http://www.disit.org/km4city/schema#Manufacture_of_travel_articles</seealso>
    let Manufacture_of_travel_articles =
        Prefixed_Name(km4c, "Manufacture_of_travel_articles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_wearing_apparel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Wearing Apparel</para><para>Confezione Abbigliamento</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_wearing_apparel">http://www.disit.org/km4city/schema#Manufacture_of_wearing_apparel</seealso>
    let Manufacture_of_wearing_apparel =
        Prefixed_Name(km4c, "Manufacture_of_wearing_apparel") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Market_polling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ricerche di mercato</para><para>Market polling</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Market_polling">http://www.disit.org/km4city/schema#Market_polling</seealso>
    let Market_polling = Prefixed_Name(km4c, "Market_polling") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Materials_recovery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Recupero Materiali</para><para>Materials Recovery</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Materials_recovery">http://www.disit.org/km4city/schema#Materials_recovery</seealso>
    let Materials_recovery = Prefixed_Name(km4c, "Materials_recovery") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Meat_and_poultry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Meat and Poultry</para><para>Carne e Pollame</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Meat_and_poultry">http://www.disit.org/km4city/schema#Meat_and_poultry</seealso>
    let Meat_and_poultry = Prefixed_Name(km4c, "Meat_and_poultry") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Mechanic_workshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mechanic Workshop</para><para>Officina</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Mechanic_workshop">http://www.disit.org/km4city/schema#Mechanic_workshop</seealso>
    let Mechanic_workshop = Prefixed_Name(km4c, "Mechanic_workshop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Medical_analysis_laboratories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Medical analysis laboratories</para><para>Laboratori analisi mediche</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Medical_analysis_laboratories">http://www.disit.org/km4city/schema#Medical_analysis_laboratories</seealso>
    let Medical_analysis_laboratories =
        Prefixed_Name(km4c, "Medical_analysis_laboratories") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Mental_health_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri di salute mentale</para><para>Mental health centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Mental_health_centre">http://www.disit.org/km4city/schema#Mental_health_centre</seealso>
    let Mental_health_centre =
        Prefixed_Name(km4c, "Mental_health_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Milestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono i cippi chilometrici che si trovano lungo le principali strade</para>
    /// labels<para>Cippo chilometrico</para><para>milestone mileage</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Milestone">http://www.disit.org/km4city/schema#Milestone</seealso>
    let Milestone = Prefixed_Name(km4c, "Milestone") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Minimarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Minimarket</para><para>Minimarket</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Minimarket">http://www.disit.org/km4city/schema#Minimarket</seealso>
    let Minimarket = Prefixed_Name(km4c, "Minimarket") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Mining_support_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi Industria Mineraria</para><para>Mining Support Services</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Mining_support_services">http://www.disit.org/km4city/schema#Mining_support_services</seealso>
    let Mining_support_services =
        Prefixed_Name(km4c, "Mining_support_services") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Monument_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Monument location</para><para>Luogo monumento</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Monument_location">http://www.disit.org/km4city/schema#Monument_location</seealso>
    let Monument_location = Prefixed_Name(km4c, "Monument_location") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Motion_picture_and_television_programme_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Motion picture and television programme activities</para><para>Cinama e TV  Produzione e Distribuzione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Motion_picture_and_television_programme_activities">http://www.disit.org/km4city/schema#Motion_picture_and_television_programme_activities</seealso>
    let Motion_picture_and_television_programme_activities =
        Prefixed_Name(km4c, "Motion_picture_and_television_programme_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Motor_Vehicles_wholesale_and_retail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Autoveicoli Ingrosso Dettaglio</para><para>Motor Vehicles Wholesale and Retail</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Motor_Vehicles_wholesale_and_retail">http://www.disit.org/km4city/schema#Motor_Vehicles_wholesale_and_retail</seealso>
    let Motor_Vehicles_wholesale_and_retail =
        Prefixed_Name(km4c, "Motor_Vehicles_wholesale_and_retail") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Motorcycles_parts_wholesale_and_retail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ingrosso Dettaglio Ricambi Motocicli</para><para>Motorcycles Parts Wholesale and Retail</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Motorcycles_parts_wholesale_and_retail">http://www.disit.org/km4city/schema#Motorcycles_parts_wholesale_and_retail</seealso>
    let Motorcycles_parts_wholesale_and_retail =
        Prefixed_Name(km4c, "Motorcycles_parts_wholesale_and_retail") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Municipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono i vari comuni</para>
    /// labels<para>Municipality Administration</para><para>Amministrazione Comunale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Municipality">http://www.disit.org/km4city/schema#Municipality</seealso>
    let Municipality = Prefixed_Name(km4c, "Municipality") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Pa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Comuni, regioni e provincie</para>
    /// labels<para>Pubblica Amministrazione</para><para>Public Administration</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pa">http://www.disit.org/km4city/schema#Pa</seealso>
    let Pa = Prefixed_Name(km4c, "Pa") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Museum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Museum</para><para>Museo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Museum">http://www.disit.org/km4city/schema#Museum</seealso>
    let Museum = Prefixed_Name(km4c, "Museum") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Music_and_video_recordings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Registrazioni musicali e video</para><para>Music and Video Recordings</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Music_and_video_recordings">http://www.disit.org/km4city/schema#Music_and_video_recordings</seealso>
    let Music_and_video_recordings =
        Prefixed_Name(km4c, "Music_and_video_recordings") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Musical_instruments_and_scores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Musical Instruments and Scores</para><para>Strumenti Musicali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Musical_instruments_and_scores">http://www.disit.org/km4city/schema#Musical_instruments_and_scores</seealso>
    let Musical_instruments_and_scores =
        Prefixed_Name(km4c, "Musical_instruments_and_scores") |> PrefixedName

    /// <summary>
    ///   <para>km4c:belongToRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each road has street numbers</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#belongToRoad">http://www.disit.org/km4city/schema#belongToRoad</seealso>
    let belongToRoad = Prefixed_Name(km4c, "belongToRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Street_sweeping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pulizia aree pubbliche e strade</para><para>Street sweeping</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Street_sweeping">http://www.disit.org/km4city/schema#Street_sweeping</seealso>
    let Street_sweeping = Prefixed_Name(km4c, "Street_sweeping") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Summer_camp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Colonie per ragazzi</para><para>Summer camp</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Summer_camp">http://www.disit.org/km4city/schema#Summer_camp</seealso>
    let Summer_camp = Prefixed_Name(km4c, "Summer_camp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Summer_residence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>casa per vacanze</para><para>Summer residence</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Summer_residence">http://www.disit.org/km4city/schema#Summer_residence</seealso>
    let Summer_residence = Prefixed_Name(km4c, "Summer_residence") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Support_animal_production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Supporto Produzione Animali</para><para>Support Animal Production</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Support_animal_production">http://www.disit.org/km4city/schema#Support_animal_production</seealso>
    let Support_animal_production =
        Prefixed_Name(km4c, "Support_animal_production") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Surveyor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Geometri</para><para>Surveyor</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Surveyor">http://www.disit.org/km4city/schema#Surveyor</seealso>
    let Surveyor = Prefixed_Name(km4c, "Surveyor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Sushi_bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sushi bar</para><para>Sushi bar</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sushi_bar">http://www.disit.org/km4city/schema#Sushi_bar</seealso>
    let Sushi_bar = Prefixed_Name(km4c, "Sushi_bar") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Take_away</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Take Away</para><para>Take Away</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Take_away">http://www.disit.org/km4city/schema#Take_away</seealso>
    let Take_away = Prefixed_Name(km4c, "Take_away") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tannery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Conceria</para><para>Tannery</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tannery">http://www.disit.org/km4city/schema#Tannery</seealso>
    let Tannery = Prefixed_Name(km4c, "Tannery") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Taxi_park</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Aree sosta taxi</para><para>Taxi park</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Taxi_park">http://www.disit.org/km4city/schema#Taxi_park</seealso>
    let Taxi_park = Prefixed_Name(km4c, "Taxi_park") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Technical_consultants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Technical consultants</para><para>Studi Tecnici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Technical_consultants">http://www.disit.org/km4city/schema#Technical_consultants</seealso>
    let Technical_consultants =
        Prefixed_Name(km4c, "Technical_consultants") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Technical_testing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Technical testing</para><para>Collaudi tecnici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Technical_testing">http://www.disit.org/km4city/schema#Technical_testing</seealso>
    let Technical_testing = Prefixed_Name(km4c, "Technical_testing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Telecommunications</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Telefonia e Telecomunicazioni</para><para>Telecommunications</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Telecommunications">http://www.disit.org/km4city/schema#Telecommunications</seealso>
    let Telecommunications = Prefixed_Name(km4c, "Telecommunications") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Television_broadcasting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Television broadcasting</para><para>Emittenti Televisive</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Television_broadcasting">http://www.disit.org/km4city/schema#Television_broadcasting</seealso>
    let Television_broadcasting =
        Prefixed_Name(km4c, "Television_broadcasting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Amusement_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Attivita' ricreative</para><para>Amusement activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Amusement_activities">http://www.disit.org/km4city/schema#Amusement_activities</seealso>
    let Amusement_activities =
        Prefixed_Name(km4c, "Amusement_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Animal_production</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Animali</para><para>Animal Production</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Animal_production">http://www.disit.org/km4city/schema#Animal_production</seealso>
    let Animal_production = Prefixed_Name(km4c, "Animal_production") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Archaeological_site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Archaeological site</para><para>Sito archeologico</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Archaeological_site">http://www.disit.org/km4city/schema#Archaeological_site</seealso>
    let Archaeological_site = Prefixed_Name(km4c, "Archaeological_site") |> PrefixedName

    /// <summary>
    ///   <para>km4c:CivilAndEdilEngineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi legati all'ingegneria civile ed edile</para>
    /// labels<para>Civil and edil engineering</para><para>Ingegneria civile ed edile</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#CivilAndEdilEngineering">http://www.disit.org/km4city/schema#CivilAndEdilEngineering</seealso>
    let CivilAndEdilEngineering =
        Prefixed_Name(km4c, "CivilAndEdilEngineering") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_electrical_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Apparecchiature Elettriche</para><para>Manufacture of Electrical Equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_electrical_equipment">http://www.disit.org/km4city/schema#Manufacture_of_electrical_equipment</seealso>
    let Manufacture_of_electrical_equipment =
        Prefixed_Name(km4c, "Manufacture_of_electrical_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:adRoadName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#adRoadName">http://www.disit.org/km4city/schema#adRoadName</seealso>
    let adRoadName = Prefixed_Name(km4c, "adRoadName") |> PrefixedName
    /// <summary>
    ///   <para>km4c:adminClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#adminClass">http://www.disit.org/km4city/schema#adminClass</seealso>
    let adminClass = Prefixed_Name(km4c, "adminClass") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Consulate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Consolato</para><para>Consulate</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Consulate">http://www.disit.org/km4city/schema#Consulate</seealso>
    let Consulate = Prefixed_Name(km4c, "Consulate") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Corps_of_forest_rangers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Corpo forestale dello stato</para><para>Corps of forest rangers</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Corps_of_forest_rangers">http://www.disit.org/km4city/schema#Corps_of_forest_rangers</seealso>
    let Corps_of_forest_rangers =
        Prefixed_Name(km4c, "Corps_of_forest_rangers") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Red_cross</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Croce rossa</para><para>Red cross</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Red_cross">http://www.disit.org/km4city/schema#Red_cross</seealso>
    let Red_cross = Prefixed_Name(km4c, "Red_cross") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_commission_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Intermediari Commercio Ingrosso</para><para>Wholesale Commission Trade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_commission_trade">http://www.disit.org/km4city/schema#Wholesale_commission_trade</seealso>
    let Wholesale_commission_trade =
        Prefixed_Name(km4c, "Wholesale_commission_trade") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Aquarium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Acquario</para><para>Aquarium</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Aquarium">http://www.disit.org/km4city/schema#Aquarium</seealso>
    let Aquarium = Prefixed_Name(km4c, "Aquarium") |> PrefixedName
    /// <summary>
    ///   <para>km4c:CulturalActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>biblioteche, archivi, musei ed altre attivita' culturali</para>
    /// labels<para>Attivita' Culturale</para><para>Cultural Activity</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#CulturalActivity">http://www.disit.org/km4city/schema#CulturalActivity</seealso>
    let CulturalActivity = Prefixed_Name(km4c, "CulturalActivity") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi rappresentati da un'area di forma poligonale</para>
    /// labels<para>Servizio di forma poligonale</para><para>Polygonal Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Area">http://www.disit.org/km4city/schema#Area</seealso>
    let Area = Prefixed_Name(km4c, "Area") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Artisan_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Negozio artigiano</para><para>Artisanshop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Artisan_shop">http://www.disit.org/km4city/schema#Artisan_shop</seealso>
    let Artisan_shop = Prefixed_Name(km4c, "Artisan_shop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_jewellery_bijouterie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Jewellery Bijouterie</para><para>Produzione Gioielleria Bigiotteria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_jewellery_bijouterie">http://www.disit.org/km4city/schema#Manufacture_of_jewellery_bijouterie</seealso>
    let Manufacture_of_jewellery_bijouterie =
        Prefixed_Name(km4c, "Manufacture_of_jewellery_bijouterie") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_pharmaceutical_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Pharmaceutical Products</para><para>Produzione Prodotti Farmaceutici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_pharmaceutical_products">http://www.disit.org/km4city/schema#Manufacture_of_pharmaceutical_products</seealso>
    let Manufacture_of_pharmaceutical_products =
        Prefixed_Name(km4c, "Manufacture_of_pharmaceutical_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:composeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway Direction is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#composeDirection">http://www.disit.org/km4city/schema#composeDirection</seealso>
    let composeDirection = Prefixed_Name(km4c, "composeDirection") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Architectural_consulting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Architectural consulting</para><para>Studi di Architettura</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Architectural_consulting">http://www.disit.org/km4city/schema#Architectural_consulting</seealso>
    let Architectural_consulting =
        Prefixed_Name(km4c, "Architectural_consulting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Node</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono i nodi che congiungono gli elementi stradali</para>
    /// labels<para>Nodo</para><para>Node</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Node">http://www.disit.org/km4city/schema#Node</seealso>
    let Node = Prefixed_Name(km4c, "Node") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Art_galleries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Gallerie Arte</para><para>Art Galleries</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Art_galleries">http://www.disit.org/km4city/schema#Art_galleries</seealso>
    let Art_galleries = Prefixed_Name(km4c, "Art_galleries") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Associations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Associazioni</para><para>Associations</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Associations">http://www.disit.org/km4city/schema#Associations</seealso>
    let Associations = Prefixed_Name(km4c, "Associations") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Auctioning_houses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Auctioning Houses</para><para>Case d'Asta</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Auctioning_houses">http://www.disit.org/km4city/schema#Auctioning_houses</seealso>
    let Auctioning_houses = Prefixed_Name(km4c, "Auctioning_houses") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Auditing_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Revisione e cerificazione bilanci</para><para>Auditing activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Auditing_activities">http://www.disit.org/km4city/schema#Auditing_activities</seealso>
    let Auditing_activities = Prefixed_Name(km4c, "Auditing_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_structural_metal_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Structural Metal Products</para><para>Produzione Prodotti in Metallo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_structural_metal_products">http://www.disit.org/km4city/schema#Manufacture_of_structural_metal_products</seealso>
    let Manufacture_of_structural_metal_products =
        Prefixed_Name(km4c, "Manufacture_of_structural_metal_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_wood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Wood</para><para>Industria del Legno</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_wood">http://www.disit.org/km4city/schema#Manufacture_of_wood</seealso>
    let Manufacture_of_wood = Prefixed_Name(km4c, "Manufacture_of_wood") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_wood_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Prodotti in Legno</para><para>Manufacture of Wood Products</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_wood_products">http://www.disit.org/km4city/schema#Manufacture_of_wood_products</seealso>
    let Manufacture_of_wood_products =
        Prefixed_Name(km4c, "Manufacture_of_wood_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Software_publishing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Software publishing</para><para>Editoria Software</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Software_publishing">http://www.disit.org/km4city/schema#Software_publishing</seealso>
    let Software_publishing = Prefixed_Name(km4c, "Software_publishing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:eventCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#eventCategory">http://www.disit.org/km4city/schema#eventCategory</seealso>
    let eventCategory = Prefixed_Name(km4c, "eventCategory") |> PrefixedName
    /// <summary>
    ///   <para>km4c:eventTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#eventTime">http://www.disit.org/km4city/schema#eventTime</seealso>
    let eventTime = Prefixed_Name(km4c, "eventTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:exponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#exponent">http://www.disit.org/km4city/schema#exponent</seealso>
    let exponent = Prefixed_Name(km4c, "exponent") |> PrefixedName
    /// <summary>
    ///   <para>km4c:extendName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#extendName">http://www.disit.org/km4city/schema#extendName</seealso>
    let extendName = Prefixed_Name(km4c, "extendName") |> PrefixedName
    /// <summary>
    ///   <para>km4c:extendNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#extendNumber">http://www.disit.org/km4city/schema#extendNumber</seealso>
    let extendNumber = Prefixed_Name(km4c, "extendNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Atm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Atm</para><para>Atm</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Atm">http://www.disit.org/km4city/schema#Atm</seealso>
    let Atm = Prefixed_Name(km4c, "Atm") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Audio_and_video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Audio and Video</para><para>Audio e Video</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Audio_and_video">http://www.disit.org/km4city/schema#Audio_and_video</seealso>
    let Audio_and_video = Prefixed_Name(km4c, "Audio_and_video") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_musical_instruments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Musical Instruments</para><para>Produzione Strumenti Musicali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_musical_instruments">http://www.disit.org/km4city/schema#Manufacture_of_musical_instruments</seealso>
    let Manufacture_of_musical_instruments =
        Prefixed_Name(km4c, "Manufacture_of_musical_instruments") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sawmilling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sawmilling</para><para>Segherie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sawmilling">http://www.disit.org/km4city/schema#Sawmilling</seealso>
    let Sawmilling = Prefixed_Name(km4c, "Sawmilling") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Secondary_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole medie, licei e istituti tecnici</para><para>Secondary education</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Secondary_education">http://www.disit.org/km4city/schema#Secondary_education</seealso>
    let Secondary_education = Prefixed_Name(km4c, "Secondary_education") |> PrefixedName
    /// <summary>
    ///   <para>km4c:alterCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#alterCode">http://www.disit.org/km4city/schema#alterCode</seealso>
    let alterCode = Prefixed_Name(km4c, "alterCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:approvedByPa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect a resolution to the municipality that have approved it</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#approvedByPa">http://www.disit.org/km4city/schema#approvedByPa</seealso>
    let approvedByPa = Prefixed_Name(km4c, "approvedByPa") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Diving_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuola di sub</para><para>Diving school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Diving_school">http://www.disit.org/km4city/schema#Diving_school</seealso>
    let Diving_school = Prefixed_Name(km4c, "Diving_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Manufacture_of_rubber_and_plastics_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Manufacture of Rubber and Plastics Products</para><para>Produzione Prodotti di Gomma e Plastica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Manufacture_of_rubber_and_plastics_products">http://www.disit.org/km4city/schema#Manufacture_of_rubber_and_plastics_products</seealso>
    let Manufacture_of_rubber_and_plastics_products =
        Prefixed_Name(km4c, "Manufacture_of_rubber_and_plastics_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Skiing_facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Impianti sciistici</para><para>Skiing facility</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Skiing_facility">http://www.disit.org/km4city/schema#Skiing_facility</seealso>
    let Skiing_facility = Prefixed_Name(km4c, "Skiing_facility") |> PrefixedName
    /// <summary>
    ///   <para>km4c:correspondsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>there is no exact match between Road and AdministrativeRoad</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#correspondsTo">http://www.disit.org/km4city/schema#correspondsTo</seealso>
    let correspondsTo = Prefixed_Name(km4c, "correspondsTo") |> PrefixedName
    /// <summary>
    ///   <para>km4c:direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>direzione percorso</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#direction">http://www.disit.org/km4city/schema#direction</seealso>
    let direction = Prefixed_Name(km4c, "direction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Automobile_driving_and_flying_schools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Autoscuole, scuole di pilotaggio e nautiche</para><para>Automobile driving and flying schools</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Automobile_driving_and_flying_schools">http://www.disit.org/km4city/schema#Automobile_driving_and_flying_schools</seealso>
    let Automobile_driving_and_flying_schools =
        Prefixed_Name(km4c, "Automobile_driving_and_flying_schools") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Beach_resort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Stabilimento balneare</para><para>Beach resort</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Beach_resort">http://www.disit.org/km4city/schema#Beach_resort</seealso>
    let Beach_resort = Prefixed_Name(km4c, "Beach_resort") |> PrefixedName
    /// <summary>
    ///   <para>km4c:TourismService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>attivita' dei servizi delle agenzie di viaggio, tour operator e servizi prenotazione</para>
    /// labels<para>Servizi per il turismo</para><para>Tourism Services</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TourismService">http://www.disit.org/km4city/schema#TourismService</seealso>
    let TourismService = Prefixed_Name(km4c, "TourismService") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Beauty_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Istituti di bellezza</para><para>Beauty centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Beauty_centre">http://www.disit.org/km4city/schema#Beauty_centre</seealso>
    let Beauty_centre = Prefixed_Name(km4c, "Beauty_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Betting_shops</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Betting shops</para><para>Ricevitorie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Betting_shops">http://www.disit.org/km4city/schema#Betting_shops</seealso>
    let Betting_shops = Prefixed_Name(km4c, "Betting_shops") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Footwear_factory_outlet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Spacci outlet calzature</para><para>Footwear factory outlet</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Footwear_factory_outlet">http://www.disit.org/km4city/schema#Footwear_factory_outlet</seealso>
    let Footwear_factory_outlet =
        Prefixed_Name(km4c, "Footwear_factory_outlet") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Footwear_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Footwear Manufacture</para><para>Produzione Calzature</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Footwear_manufacture">http://www.disit.org/km4city/schema#Footwear_manufacture</seealso>
    let Footwear_manufacture =
        Prefixed_Name(km4c, "Footwear_manufacture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Freight_transport_and_furniture_removal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Freight Transport and Furniture Removal</para><para>Trasporto Merci e Traslochi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Freight_transport_and_furniture_removal">http://www.disit.org/km4city/schema#Freight_transport_and_furniture_removal</seealso>
    let Freight_transport_and_furniture_removal =
        Prefixed_Name(km4c, "Freight_transport_and_furniture_removal") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Fresh_place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Luoghi in cui e' possibile sedere all'aria condizionata durante l'estate</para>
    /// labels<para>Luoghi freschi</para><para>Fresh place</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fresh_place">http://www.disit.org/km4city/schema#Fresh_place</seealso>
    let Fresh_place = Prefixed_Name(km4c, "Fresh_place") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Optics_and_photography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Optics and Photography</para><para>Ottica e Fotografia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Optics_and_photography">http://www.disit.org/km4city/schema#Optics_and_photography</seealso>
    let Optics_and_photography =
        Prefixed_Name(km4c, "Optics_and_photography") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Organization_of_conventions_and_trade_shows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Organization of conventions and trade shows</para><para>Organizzazione di convegni e fiere</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Organization_of_conventions_and_trade_shows">http://www.disit.org/km4city/schema#Organization_of_conventions_and_trade_shows</seealso>
    let Organization_of_conventions_and_trade_shows =
        Prefixed_Name(km4c, "Organization_of_conventions_and_trade_shows") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_broadcasting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Other broadcasting</para><para>Altre emittenti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_broadcasting">http://www.disit.org/km4city/schema#Other_broadcasting</seealso>
    let Other_broadcasting = Prefixed_Name(km4c, "Other_broadcasting") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Supermarket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Supermercato</para><para>Supermarket</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Supermarket">http://www.disit.org/km4city/schema#Supermarket</seealso>
    let Supermarket = Prefixed_Name(km4c, "Supermarket") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Support_activities_for_transportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Support Activities for Transportation</para><para>Attivita' di Supporto ai trasporti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Support_activities_for_transportation">http://www.disit.org/km4city/schema#Support_activities_for_transportation</seealso>
    let Support_activities_for_transportation =
        Prefixed_Name(km4c, "Support_activities_for_transportation") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Tattoo_and_piercing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Tatuaggio e piercing</para><para>Tattoo and piercing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tattoo_and_piercing">http://www.disit.org/km4city/schema#Tattoo_and_piercing</seealso>
    let Tattoo_and_piercing = Prefixed_Name(km4c, "Tattoo_and_piercing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tax_advice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri assistenza fiscale (CAF)</para><para>Tax advice</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tax_advice">http://www.disit.org/km4city/schema#Tax_advice</seealso>
    let Tax_advice = Prefixed_Name(km4c, "Tax_advice") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Taxi_company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Taxi Company</para><para>Taxi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Taxi_company">http://www.disit.org/km4city/schema#Taxi_company</seealso>
    let Taxi_company = Prefixed_Name(km4c, "Taxi_company") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasTransferService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each train station tothe correspondant service</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasTransferService">http://www.disit.org/km4city/schema#hasTransferService</seealso>
    let hasTransferService = Prefixed_Name(km4c, "hasTransferService") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasTransverseService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>regular services can be connected to transverse services</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasTransverseService">http://www.disit.org/km4city/schema#hasTransverseService</seealso>
    let hasTransverseService =
        Prefixed_Name(km4c, "hasTransverseService") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasWeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each weather forecasts is connected to a municipality</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasWeatherReport">http://www.disit.org/km4city/schema#hasWeatherReport</seealso>
    let hasWeatherReport = Prefixed_Name(km4c, "hasWeatherReport") |> PrefixedName
    /// <summary>
    ///   <para>km4c:heightHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#heightHour">http://www.disit.org/km4city/schema#heightHour</seealso>
    let heightHour = Prefixed_Name(km4c, "heightHour") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hour">http://www.disit.org/km4city/schema#hour</seealso>
    let hour = Prefixed_Name(km4c, "hour") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Entry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono i possibili ingressi ai numeri civici</para>
    /// labels<para>Accesso</para><para>Entry</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Entry">http://www.disit.org/km4city/schema#Entry</seealso>
    let Entry = Prefixed_Name(km4c, "Entry") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Medical_and_orthopaedic_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Medicali e Ortopedici</para><para>Medical and Orthopaedic Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Medical_and_orthopaedic_goods">http://www.disit.org/km4city/schema#Medical_and_orthopaedic_goods</seealso>
    let Medical_and_orthopaedic_goods =
        Prefixed_Name(km4c, "Medical_and_orthopaedic_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Sporting_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sporting Equipment</para><para>Articoli Sportivi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Sporting_equipment">http://www.disit.org/km4city/schema#Sporting_equipment</seealso>
    let Sporting_equipment = Prefixed_Name(km4c, "Sporting_equipment") |> PrefixedName
    /// <summary>
    ///   <para>km4c:exitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#exitRate">http://www.disit.org/km4city/schema#exitRate</seealso>
    let exitRate = Prefixed_Name(km4c, "exitRate") |> PrefixedName
    /// <summary>
    ///   <para>km4c:expectedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>orario in cui e' previsto l'arrivo del bus a quella fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#expectedTime">http://www.disit.org/km4city/schema#expectedTime</seealso>
    let expectedTime = Prefixed_Name(km4c, "expectedTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bar</para><para>Bar</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bar">http://www.disit.org/km4city/schema#Bar</seealso>
    let Bar = Prefixed_Name(km4c, "Bar") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Farm_house</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Residenza turistica alberghiera</para><para>Farm house</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Farm_house">http://www.disit.org/km4city/schema#Farm_house</seealso>
    let Farm_house = Prefixed_Name(km4c, "Farm_house") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasBObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each beacon to observations that it produces</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasBObservation">http://www.disit.org/km4city/schema#hasBObservation</seealso>
    let hasBObservation = Prefixed_Name(km4c, "hasBObservation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasCarParkSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each car park to its installed sensor</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasCarParkSensor">http://www.disit.org/km4city/schema#hasCarParkSensor</seealso>
    let hasCarParkSensor = Prefixed_Name(km4c, "hasCarParkSensor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasExpectedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the expected time at the next bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasExpectedTime">http://www.disit.org/km4city/schema#hasExpectedTime</seealso>
    let hasExpectedTime = Prefixed_Name(km4c, "hasExpectedTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#day">http://www.disit.org/km4city/schema#day</seealso>
    let day = Prefixed_Name(km4c, "day") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Beacon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Singolo beacon installato</para>
    ///   <para>Servizio associato ai Beacon che permettono di ricevere offerte</para>
    /// labels<para>Beacon</para><para>Beacon</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Beacon">http://www.disit.org/km4city/schema#Beacon</seealso>
    let Beacon = Prefixed_Name(km4c, "Beacon") |> PrefixedName
    /// <summary>
    ///   <para>km4c:BeaconObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>lettura proveniente da un singolo beacon</para>
    /// labels<para>Lettura di un beacon</para><para>Beacon observation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#BeaconObservation">http://www.disit.org/km4city/schema#BeaconObservation</seealso>
    let BeaconObservation = Prefixed_Name(km4c, "BeaconObservation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bed_and_breakfast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Bed and breakfast</para><para>Bed and breakfast</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bed_and_breakfast">http://www.disit.org/km4city/schema#Bed_and_breakfast</seealso>
    let Bed_and_breakfast = Prefixed_Name(km4c, "Bed_and_breakfast") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bike_rack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rastrelliera per biciclette</para><para>Bike rack</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bike_rack">http://www.disit.org/km4city/schema#Bike_rack</seealso>
    let Bike_rack = Prefixed_Name(km4c, "Bike_rack") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Boarding_house</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Boarding house</para><para>Affittacamere</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Boarding_house">http://www.disit.org/km4city/schema#Boarding_house</seealso>
    let Boarding_house = Prefixed_Name(km4c, "Boarding_house") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Fuel_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Distributore di carburante</para><para>Fuel station</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fuel_station">http://www.disit.org/km4city/schema#Fuel_station</seealso>
    let Fuel_station = Prefixed_Name(km4c, "Fuel_station") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Funeral_and_cemetery_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Funerari e Cimiteriali</para><para>Funeral and Cemetery Articles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Funeral_and_cemetery_articles">http://www.disit.org/km4city/schema#Funeral_and_cemetery_articles</seealso>
    let Funeral_and_cemetery_articles =
        Prefixed_Name(km4c, "Funeral_and_cemetery_articles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Gambling_and_betting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Gambling and betting</para><para>Lotterie e scommesse</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Gambling_and_betting">http://www.disit.org/km4city/schema#Gambling_and_betting</seealso>
    let Gambling_and_betting =
        Prefixed_Name(km4c, "Gambling_and_betting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Game_room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ludoteca e biliardi</para><para>Game room</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Game_room">http://www.disit.org/km4city/schema#Game_room</seealso>
    let Game_room = Prefixed_Name(km4c, "Game_room") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Gardens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Giardini</para><para>Gardens</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Gardens">http://www.disit.org/km4city/schema#Gardens</seealso>
    let Gardens = Prefixed_Name(km4c, "Gardens") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Gifts_and_smoking_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli da Regalo e per Fumatori</para><para>Gifts and Smoking Articles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Gifts_and_smoking_articles">http://www.disit.org/km4city/schema#Gifts_and_smoking_articles</seealso>
    let Gifts_and_smoking_articles =
        Prefixed_Name(km4c, "Gifts_and_smoking_articles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:GoodsYard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scalo Merci, sono posizionati in corrispondenza di giunzioni ferroviarie con relazione 1:1</para>
    /// labels<para>Scalo Merci</para><para>Goods Yard</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#GoodsYard">http://www.disit.org/km4city/schema#GoodsYard</seealso>
    let GoodsYard = Prefixed_Name(km4c, "GoodsYard") |> PrefixedName

    /// <summary>
    ///   <para>km4c:correspondToJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>train station and good yard are located precisely on a junction</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#correspondToJunction">http://www.disit.org/km4city/schema#correspondToJunction</seealso>
    let correspondToJunction =
        Prefixed_Name(km4c, "correspondToJunction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Group_practice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Poliambulatorio</para><para>Group practice</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Group_practice">http://www.disit.org/km4city/schema#Group_practice</seealso>
    let Group_practice = Prefixed_Name(km4c, "Group_practice") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Haberdashery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Merceria, filati</para><para>Haberdashery</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Haberdashery">http://www.disit.org/km4city/schema#Haberdashery</seealso>
    let Haberdashery = Prefixed_Name(km4c, "Haberdashery") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Haircare_centres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri tricologici</para><para>Haircare centres</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Haircare_centres">http://www.disit.org/km4city/schema#Haircare_centres</seealso>
    let Haircare_centres = Prefixed_Name(km4c, "Haircare_centres") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Hairdressing_and_beauty_treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Parrucchieri e trattamenti di bellezza</para><para>Hairdressing and beauty treatment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hairdressing_and_beauty_treatment">http://www.disit.org/km4city/schema#Hairdressing_and_beauty_treatment</seealso>
    let Hairdressing_and_beauty_treatment =
        Prefixed_Name(km4c, "Hairdressing_and_beauty_treatment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Health_district</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Distretto sanitario</para><para>Health district</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Health_district">http://www.disit.org/km4city/schema#Health_district</seealso>
    let Health_district = Prefixed_Name(km4c, "Health_district") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Health_reservations_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centro unico di prenotazione</para><para>Health reservations centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Health_reservations_centre">http://www.disit.org/km4city/schema#Health_reservations_centre</seealso>
    let Health_reservations_centre =
        Prefixed_Name(km4c, "Health_reservations_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Healthcare_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri assistenza</para><para>Healthcare centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Healthcare_centre">http://www.disit.org/km4city/schema#Healthcare_centre</seealso>
    let Healthcare_centre = Prefixed_Name(km4c, "Healthcare_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Higher_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Higher education</para><para>Universita'</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Higher_education">http://www.disit.org/km4city/schema#Higher_education</seealso>
    let Higher_education = Prefixed_Name(km4c, "Higher_education") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Highway_stop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Highway stop</para><para>Autogrill</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Highway_stop">http://www.disit.org/km4city/schema#Highway_stop</seealso>
    let Highway_stop = Prefixed_Name(km4c, "Highway_stop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Hippodrome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Hippodrome</para><para>Ippodromo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hippodrome">http://www.disit.org/km4city/schema#Hippodrome</seealso>
    let Hippodrome = Prefixed_Name(km4c, "Hippodrome") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Hostel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ostello</para><para>Hostel</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hostel">http://www.disit.org/km4city/schema#Hostel</seealso>
    let Hostel = Prefixed_Name(km4c, "Hostel") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Hotel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Albergo hotel</para><para>Hotel</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Hotel">http://www.disit.org/km4city/schema#Hotel</seealso>
    let Hotel = Prefixed_Name(km4c, "Hotel") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_infant_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole materne private</para><para>Private infant school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_infant_school">http://www.disit.org/km4city/schema#Private_infant_school</seealso>
    let Private_infant_school =
        Prefixed_Name(km4c, "Private_infant_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_junior_high_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Private junior high school</para><para>Scuole medie private</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_junior_high_school">http://www.disit.org/km4city/schema#Private_junior_high_school</seealso>
    let Private_junior_high_school =
        Prefixed_Name(km4c, "Private_junior_high_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_junior_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole elementari private</para><para>Private junior school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_junior_school">http://www.disit.org/km4city/schema#Private_junior_school</seealso>
    let Private_junior_school =
        Prefixed_Name(km4c, "Private_junior_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Private_security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vigilanza privata</para><para>Private security</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Private_security">http://www.disit.org/km4city/schema#Private_security</seealso>
    let Private_security = Prefixed_Name(km4c, "Private_security") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Province</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le varie provincie</para>
    /// labels<para>Amministrazione Provinciale</para><para>Provincial Administration</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Province">http://www.disit.org/km4city/schema#Province</seealso>
    let Province = Prefixed_Name(km4c, "Province") |> PrefixedName
    /// <summary>
    ///   <para>km4c:PublicTransportLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Linea di una certa azienda TPL</para>
    ///   <para>Servizio associato alla visualizzazione delle linee ATAF con le relative fermate</para>
    /// labels<para>Public Transport Line</para><para>Linea bus</para><para>Linea TPL</para><para>Bus Line</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#PublicTransportLine">http://www.disit.org/km4city/schema#PublicTransportLine</seealso>
    let PublicTransportLine = Prefixed_Name(km4c, "PublicTransportLine") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Public_high_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Public high school</para><para>Licei pubblici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_high_school">http://www.disit.org/km4city/schema#Public_high_school</seealso>
    let Public_high_school = Prefixed_Name(km4c, "Public_high_school") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Public_hospital</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ospedale pubblico</para><para>Public hospital</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_hospital">http://www.disit.org/km4city/schema#Public_hospital</seealso>
    let Public_hospital = Prefixed_Name(km4c, "Public_hospital") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Public_infant_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole materne pubbliche</para><para>Public infant school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_infant_school">http://www.disit.org/km4city/schema#Public_infant_school</seealso>
    let Public_infant_school =
        Prefixed_Name(km4c, "Public_infant_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Public_junior_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole elementari pubbliche</para><para>Public junior school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_junior_school">http://www.disit.org/km4city/schema#Public_junior_school</seealso>
    let Public_junior_school =
        Prefixed_Name(km4c, "Public_junior_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Public_polytechnic_school</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Istituti tecnici pubblici</para><para>Public polytechnic school</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_polytechnic_school">http://www.disit.org/km4city/schema#Public_polytechnic_school</seealso>
    let Public_polytechnic_school =
        Prefixed_Name(km4c, "Public_polytechnic_school") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Public_professional_institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Istituti professionali pubblici</para><para>Public professional institute</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_professional_institute">http://www.disit.org/km4city/schema#Public_professional_institute</seealso>
    let Public_professional_institute =
        Prefixed_Name(km4c, "Public_professional_institute") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Quality_control_and_certification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Certificazione e controllo qualita'</para><para>Quality Control and Certification</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Quality_control_and_certification">http://www.disit.org/km4city/schema#Quality_control_and_certification</seealso>
    let Quality_control_and_certification =
        Prefixed_Name(km4c, "Quality_control_and_certification") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Quarrying_of_stone_sand_and_clay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Estrazione di pietra, sabbia e argilla</para><para>Quarrying of stone sand and clay</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Quarrying_of_stone_sand_and_clay">http://www.disit.org/km4city/schema#Quarrying_of_stone_sand_and_clay</seealso>
    let Quarrying_of_stone_sand_and_clay =
        Prefixed_Name(km4c, "Quarrying_of_stone_sand_and_clay") |> PrefixedName

    /// <summary>
    ///   <para>km4c:RTZgate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Varco ZTL</para><para>RTZ gate</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RTZgate">http://www.disit.org/km4city/schema#RTZgate</seealso>
    let RTZgate = Prefixed_Name(km4c, "RTZgate") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Radio_broadcasting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Radio broadcasting</para><para>Emittenti Radio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Radio_broadcasting">http://www.disit.org/km4city/schema#Radio_broadcasting</seealso>
    let Radio_broadcasting = Prefixed_Name(km4c, "Radio_broadcasting") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Rafting_kayak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rafting canoa e kayak</para><para>Rafting kayak</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Rafting_kayak">http://www.disit.org/km4city/schema#Rafting_kayak</seealso>
    let Rafting_kayak = Prefixed_Name(km4c, "Rafting_kayak") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RailwayDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le direttive ferroviarie</para>
    /// labels<para>Direttiva Ferroviaria</para><para>Railway Direction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RailwayDirection">http://www.disit.org/km4city/schema#RailwayDirection</seealso>
    let RailwayDirection = Prefixed_Name(km4c, "RailwayDirection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Vehicle_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rivendita autoveicoli</para><para>Vehicle trade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Vehicle_trade">http://www.disit.org/km4city/schema#Vehicle_trade</seealso>
    let Vehicle_trade = Prefixed_Name(km4c, "Vehicle_trade") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Vending_machines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Distributori Automatici</para><para>Vending Machines</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Vending_machines">http://www.disit.org/km4city/schema#Vending_machines</seealso>
    let Vending_machines = Prefixed_Name(km4c, "Vending_machines") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Veterinary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Veterinari</para><para>Veterinary</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Veterinary">http://www.disit.org/km4city/schema#Veterinary</seealso>
    let Veterinary = Prefixed_Name(km4c, "Veterinary") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Video_tapes_disks_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Video tapes disks rental</para><para>Noleggio Audiovisi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Video_tapes_disks_rental">http://www.disit.org/km4city/schema#Video_tapes_disks_rental</seealso>
    let Video_tapes_disks_rental =
        Prefixed_Name(km4c, "Video_tapes_disks_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wallpaper_and_floor_coverings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Carta da Parati Rivestimento Pavimenti</para><para>Wallpaper and Floor Coverings</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wallpaper_and_floor_coverings">http://www.disit.org/km4city/schema#Wallpaper_and_floor_coverings</seealso>
    let Wallpaper_and_floor_coverings =
        Prefixed_Name(km4c, "Wallpaper_and_floor_coverings") |> PrefixedName

    /// <summary>
    ///   <para>km4c:WeatherReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Bollettino metereologico con informazioni relative a temperatura, unidita', neve, etc</para>
    /// labels<para>Bollettino metereologico</para><para>Weather Report</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#WeatherReport">http://www.disit.org/km4city/schema#WeatherReport</seealso>
    let WeatherReport = Prefixed_Name(km4c, "WeatherReport") |> PrefixedName

    /// <summary>
    ///   <para>km4c:refersToMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>specifies the municipality for the weather forecast</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#refersToMunicipality">http://www.disit.org/km4city/schema#refersToMunicipality</seealso>
    let refersToMunicipality =
        Prefixed_Name(km4c, "refersToMunicipality") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Weather_sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensore meteo che rilascia info sulle previsioni meteo</para>
    /// labels<para>Weather sensor</para><para>Sensori meteo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Weather_sensor">http://www.disit.org/km4city/schema#Weather_sensor</seealso>
    let Weather_sensor = Prefixed_Name(km4c, "Weather_sensor") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Web_and_internet_provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Web and Internet Provider</para><para>Web e Internet Provider</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Web_and_internet_provider">http://www.disit.org/km4city/schema#Web_and_internet_provider</seealso>
    let Web_and_internet_provider =
        Prefixed_Name(km4c, "Web_and_internet_provider") |> PrefixedName

    /// <summary>
    ///   <para>km4c:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#type">http://www.disit.org/km4city/schema#type</seealso>
    let type_ = Prefixed_Name(km4c, "type") |> PrefixedName
    /// <summary>
    ///   <para>km4c:typeLabel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#typeLabel">http://www.disit.org/km4city/schema#typeLabel</seealso>
    let typeLabel = Prefixed_Name(km4c, "typeLabel") |> PrefixedName
    /// <summary>
    ///   <para>km4c:typeOfResale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#typeOfResale">http://www.disit.org/km4city/schema#typeOfResale</seealso>
    let typeOfResale = Prefixed_Name(km4c, "typeOfResale") |> PrefixedName
    /// <summary>
    ///   <para>km4c:underpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#underpass">http://www.disit.org/km4city/schema#underpass</seealso>
    let underpass = Prefixed_Name(km4c, "underpass") |> PrefixedName
    /// <summary>
    ///   <para>km4c:updateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the generation time of a new weather report</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#updateTime">http://www.disit.org/km4city/schema#updateTime</seealso>
    let updateTime = Prefixed_Name(km4c, "updateTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:uuid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#uuid">http://www.disit.org/km4city/schema#uuid</seealso>
    let uuid = Prefixed_Name(km4c, "uuid") |> PrefixedName
    /// <summary>
    ///   <para>km4c:uv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#uv">http://www.disit.org/km4city/schema#uv</seealso>
    let uv = Prefixed_Name(km4c, "uv") |> PrefixedName
    /// <summary>
    ///   <para>km4c:validityStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#validityStatus">http://www.disit.org/km4city/schema#validityStatus</seealso>
    let validityStatus = Prefixed_Name(km4c, "validityStatus") |> PrefixedName
    /// <summary>
    ///   <para>km4c:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#value">http://www.disit.org/km4city/schema#value</seealso>
    let value = Prefixed_Name(km4c, "value") |> PrefixedName
    /// <summary>
    ///   <para>km4c:vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>numero di riconoscimento mezzo per azineda TPL</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#vehicle">http://www.disit.org/km4city/schema#vehicle</seealso>
    let vehicle = Prefixed_Name(km4c, "vehicle") |> PrefixedName
    /// <summary>
    ///   <para>km4c:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#width">http://www.disit.org/km4city/schema#width</seealso>
    let width = Prefixed_Name(km4c, "width") |> PrefixedName
    /// <summary>
    ///   <para>km4c:wind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#wind">http://www.disit.org/km4city/schema#wind</seealso>
    let wind = Prefixed_Name(km4c, "wind") |> PrefixedName
    /// <summary>
    ///   <para>km4c:yardType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#yardType">http://www.disit.org/km4city/schema#yardType</seealso>
    let yardType = Prefixed_Name(km4c, "yardType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Mountain_shelter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rifugi di Montagna</para><para>Mountain shelter</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Mountain_shelter">http://www.disit.org/km4city/schema#Mountain_shelter</seealso>
    let Mountain_shelter = Prefixed_Name(km4c, "Mountain_shelter") |> PrefixedName
    /// <summary>
    ///   <para>km4c:observeCarPark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each sensor to the referred car park service</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#observeCarPark">http://www.disit.org/km4city/schema#observeCarPark</seealso>
    let observeCarPark = Prefixed_Name(km4c, "observeCarPark") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the expected time at the next bus stops</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantForecast">http://www.disit.org/km4city/schema#instantForecast</seealso>
    let instantForecast = Prefixed_Name(km4c, "instantForecast") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasExternalAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>it corresponds to the outer gate of the building</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasExternalAccess">http://www.disit.org/km4city/schema#hasExternalAccess</seealso>
    let hasExternalAccess = Prefixed_Name(km4c, "hasExternalAccess") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Mining_of_metal_ores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Estrazione minerali metalliferi</para><para>Mining of metal ores</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Mining_of_metal_ores">http://www.disit.org/km4city/schema#Mining_of_metal_ores</seealso>
    let Mining_of_metal_ores =
        Prefixed_Name(km4c, "Mining_of_metal_ores") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Motorcycles_wholesale_and_retail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Motocicli Ingrosso Dettaglio</para><para>Motorcycles Wholesale and Retail</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Motorcycles_wholesale_and_retail">http://www.disit.org/km4city/schema#Motorcycles_wholesale_and_retail</seealso>
    let Motorcycles_wholesale_and_retail =
        Prefixed_Name(km4c, "Motorcycles_wholesale_and_retail") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Stalls_and_markets_of_clothing_and_footwear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ambulante Abbigliamento e Calzature</para><para>Stalls and Markets of Clothing and Footwear</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Stalls_and_markets_of_clothing_and_footwear">http://www.disit.org/km4city/schema#Stalls_and_markets_of_clothing_and_footwear</seealso>
    let Stalls_and_markets_of_clothing_and_footwear =
        Prefixed_Name(km4c, "Stalls_and_markets_of_clothing_and_footwear") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>some services and all railway elements have a specific geometry like polygons or linestrings</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasGeometry">http://www.disit.org/km4city/schema#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(km4c, "hasGeometry") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Beverage_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Beverage Manufacture</para><para>Produzione Bevande</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Beverage_manufacture">http://www.disit.org/km4city/schema#Beverage_manufacture</seealso>
    let Beverage_manufacture =
        Prefixed_Name(km4c, "Beverage_manufacture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Bookshop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Libreria, cartolibreria</para><para>Book Shop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bookshop">http://www.disit.org/km4city/schema#Bookshop</seealso>
    let Bookshop = Prefixed_Name(km4c, "Bookshop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Botanical_and_zoological_gardens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Botanical and zoological gardens</para><para>Giardini botanici e zoologici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Botanical_and_zoological_gardens">http://www.disit.org/km4city/schema#Botanical_and_zoological_gardens</seealso>
    let Botanical_and_zoological_gardens =
        Prefixed_Name(km4c, "Botanical_and_zoological_gardens") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Building_and_industrial_cleaning_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Building and industrial cleaning activities</para><para>Pulizia edifici e impianti industriali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Building_and_industrial_cleaning_activities">http://www.disit.org/km4city/schema#Building_and_industrial_cleaning_activities</seealso>
    let Building_and_industrial_cleaning_activities =
        Prefixed_Name(km4c, "Building_and_industrial_cleaning_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Building_materials_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Building Materials Manufacture</para><para>Produzione Materiali Edili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Building_materials_manufacture">http://www.disit.org/km4city/schema#Building_materials_manufacture</seealso>
    let Building_materials_manufacture =
        Prefixed_Name(km4c, "Building_materials_manufacture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:BusStopForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>previsione di arrivo ad una certa fermata</para>
    /// labels<para>Previsione arrivo in fermata</para><para>BusStop Forecast</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#BusStopForecast">http://www.disit.org/km4city/schema#BusStopForecast</seealso>
    let BusStopForecast = Prefixed_Name(km4c, "BusStopForecast") |> PrefixedName
    /// <summary>
    ///   <para>km4c:atBusStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each forecast refers to a specific bus stop</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#atBusStop">http://www.disit.org/km4city/schema#atBusStop</seealso>
    let atBusStop = Prefixed_Name(km4c, "atBusStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bus_tickets_retail</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rivendita biglietti autobus</para><para>Bus tickets retail</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bus_tickets_retail">http://www.disit.org/km4city/schema#Bus_tickets_retail</seealso>
    let Bus_tickets_retail = Prefixed_Name(km4c, "Bus_tickets_retail") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Business_support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Sostegno alle imprese</para><para>Business support</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Business_support">http://www.disit.org/km4city/schema#Business_support</seealso>
    let Business_support = Prefixed_Name(km4c, "Business_support") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Call_center</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Call center</para><para>Call Center</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Call_center">http://www.disit.org/km4city/schema#Call_center</seealso>
    let Call_center = Prefixed_Name(km4c, "Call_center") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Camper_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Camper service</para><para>Camper service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Camper_service">http://www.disit.org/km4city/schema#Camper_service</seealso>
    let Camper_service = Prefixed_Name(km4c, "Camper_service") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Camping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Campeggio</para><para>Camping</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Camping">http://www.disit.org/km4city/schema#Camping</seealso>
    let Camping = Prefixed_Name(km4c, "Camping") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Canteens_and_food_service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mense e servizi di ristorazione</para><para>Canteens and Food Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Canteens_and_food_service">http://www.disit.org/km4city/schema#Canteens_and_food_service</seealso>
    let Canteens_and_food_service =
        Prefixed_Name(km4c, "Canteens_and_food_service") |> PrefixedName

    /// <summary>
    ///   <para>km4c:CarParkSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensore che raccoglie i dati all'interno di un parcheggio</para>
    /// labels<para>Sensore presente in parcheggio</para><para>Car Park Sensor</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#CarParkSensor">http://www.disit.org/km4city/schema#CarParkSensor</seealso>
    let CarParkSensor = Prefixed_Name(km4c, "CarParkSensor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Car_park</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Parcheggio auto</para><para>Car park</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Car_park">http://www.disit.org/km4city/schema#Car_park</seealso>
    let Car_park = Prefixed_Name(km4c, "Car_park") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Car_rental_with_driver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Noleggio Auto con Conducente</para><para>Car Rental With Driver</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Car_rental_with_driver">http://www.disit.org/km4city/schema#Car_rental_with_driver</seealso>
    let Car_rental_with_driver =
        Prefixed_Name(km4c, "Car_rental_with_driver") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Car_washing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Lavaggio Auto</para><para>Car Washing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Car_washing">http://www.disit.org/km4city/schema#Car_washing</seealso>
    let Car_washing = Prefixed_Name(km4c, "Car_washing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Carabinieri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Carabinieri</para><para>Carabinieri</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Carabinieri">http://www.disit.org/km4city/schema#Carabinieri</seealso>
    let Carabinieri = Prefixed_Name(km4c, "Carabinieri") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Carpentry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Falegnamerie</para><para>Carpentry</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Carpentry">http://www.disit.org/km4city/schema#Carpentry</seealso>
    let Carpentry = Prefixed_Name(km4c, "Carpentry") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Carpets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Carpets</para><para>Tappeti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Carpets">http://www.disit.org/km4city/schema#Carpets</seealso>
    let Carpets = Prefixed_Name(km4c, "Carpets") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Carpets_and_curtains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Carpets and Curtains</para><para>Tappeti e Tende</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Carpets_and_curtains">http://www.disit.org/km4city/schema#Carpets_and_curtains</seealso>
    let Carpets_and_curtains =
        Prefixed_Name(km4c, "Carpets_and_curtains") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Helipads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Elisuperfici</para><para>Helipads</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Helipads">http://www.disit.org/km4city/schema#Helipads</seealso>
    let Helipads = Prefixed_Name(km4c, "Helipads") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Herbalists_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Herbalist's Shop</para><para>Erboristerie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Herbalists_shop">http://www.disit.org/km4city/schema#Herbalists_shop</seealso>
    let Herbalists_shop = Prefixed_Name(km4c, "Herbalists_shop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Historic_residence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Historic residence</para><para>Residenze epoca</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Historic_residence">http://www.disit.org/km4city/schema#Historic_residence</seealso>
    let Historic_residence = Prefixed_Name(km4c, "Historic_residence") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Historical_buildings</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Historical buildings</para><para>Palazzi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Historical_buildings">http://www.disit.org/km4city/schema#Historical_buildings</seealso>
    let Historical_buildings =
        Prefixed_Name(km4c, "Historical_buildings") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Holiday_village</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Villaggio vacanze</para><para>Holiday village</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Holiday_village">http://www.disit.org/km4city/schema#Holiday_village</seealso>
    let Holiday_village = Prefixed_Name(km4c, "Holiday_village") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Household_appliances_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita e riparazione elettrodomestici</para><para>Household appliances shop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_appliances_shop">http://www.disit.org/km4city/schema#Household_appliances_shop</seealso>
    let Household_appliances_shop =
        Prefixed_Name(km4c, "Household_appliances_shop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Household_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli per la Casa</para><para>Household Articles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_articles">http://www.disit.org/km4city/schema#Household_articles</seealso>
    let Household_articles = Prefixed_Name(km4c, "Household_articles") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Household_fuel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Combustibile Uso Domestico</para><para>Household Fuel</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_fuel">http://www.disit.org/km4city/schema#Household_fuel</seealso>
    let Household_fuel = Prefixed_Name(km4c, "Household_fuel") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Household_furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Household Furniture</para><para>Mobili per la Casa</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_furniture">http://www.disit.org/km4city/schema#Household_furniture</seealso>
    let Household_furniture = Prefixed_Name(km4c, "Household_furniture") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Household_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Prodotti Uso Domestico</para><para>Household Products</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_products">http://www.disit.org/km4city/schema#Household_products</seealso>
    let Household_products = Prefixed_Name(km4c, "Household_products") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Household_utensils</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Prodotti per la Casa</para><para>Household Utensils</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Household_utensils">http://www.disit.org/km4city/schema#Household_utensils</seealso>
    let Household_utensils = Prefixed_Name(km4c, "Household_utensils") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Public_university</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Universita pubbliche</para><para>Public university</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Public_university">http://www.disit.org/km4city/schema#Public_university</seealso>
    let Public_university = Prefixed_Name(km4c, "Public_university") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Publishing_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Publishing activities</para><para>Editoria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Publishing_activities">http://www.disit.org/km4city/schema#Publishing_activities</seealso>
    let Publishing_activities =
        Prefixed_Name(km4c, "Publishing_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:RailwayElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono gli elementi che compongono le tratte, le sezioni o le linee ferroviarie</para>
    /// labels<para>Elemento Ferroviario</para><para>Railway Element</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RailwayElement">http://www.disit.org/km4city/schema#RailwayElement</seealso>
    let RailwayElement = Prefixed_Name(km4c, "RailwayElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:consistOfElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway Direction is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#consistOfElement">http://www.disit.org/km4city/schema#consistOfElement</seealso>
    let consistOfElement = Prefixed_Name(km4c, "consistOfElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:endAtJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway element is delimited by two junctions</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#endAtJunction">http://www.disit.org/km4city/schema#endAtJunction</seealso>
    let endAtJunction = Prefixed_Name(km4c, "endAtJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:startAtJunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway element is delimited by two junctions</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#startAtJunction">http://www.disit.org/km4city/schema#startAtJunction</seealso>
    let startAtJunction = Prefixed_Name(km4c, "startAtJunction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RailwaySection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le sezioni ferroviarie</para>
    /// labels<para>Sezione Ferroviaria</para><para>Railway Section</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RailwaySection">http://www.disit.org/km4city/schema#RailwaySection</seealso>
    let RailwaySection = Prefixed_Name(km4c, "RailwaySection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:RailwayLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le linee ferroviarie</para>
    /// labels<para>Linea Ferroviaria</para><para>Railway Line</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#RailwayLine">http://www.disit.org/km4city/schema#RailwayLine</seealso>
    let RailwayLine = Prefixed_Name(km4c, "RailwayLine") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Warehousing_and_storage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Warehousing and Storage</para><para>Magazzini e Custodia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Warehousing_and_storage">http://www.disit.org/km4city/schema#Warehousing_and_storage</seealso>
    let Warehousing_and_storage =
        Prefixed_Name(km4c, "Warehousing_and_storage") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Waste_collection_and_treatment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Waste Collection and Treatment</para><para>Raccolta Trattamento Rifiuti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Waste_collection_and_treatment">http://www.disit.org/km4city/schema#Waste_collection_and_treatment</seealso>
    let Waste_collection_and_treatment =
        Prefixed_Name(km4c, "Waste_collection_and_treatment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Water_collection_treatment_and_supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Water Collection Treatment and Supply</para><para>Raccolta Fornitura Trattamento Acqua</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Water_collection_treatment_and_supply">http://www.disit.org/km4city/schema#Water_collection_treatment_and_supply</seealso>
    let Water_collection_treatment_and_supply =
        Prefixed_Name(km4c, "Water_collection_treatment_and_supply") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Water_transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Trasporto Marittimo e Fluviali</para><para>Water Transport</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Water_transport">http://www.disit.org/km4city/schema#Water_transport</seealso>
    let Water_transport = Prefixed_Name(km4c, "Water_transport") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Weapons_and_ammunition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Weapons and Ammunition</para><para>Armi e Munizioni</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Weapons_and_ammunition">http://www.disit.org/km4city/schema#Weapons_and_ammunition</seealso>
    let Weapons_and_ammunition =
        Prefixed_Name(km4c, "Weapons_and_ammunition") |> PrefixedName

    /// <summary>
    ///   <para>km4c:WeatherPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Previsione metereologica relativa ad una specifica parte del giorno</para>
    /// labels<para>Previsione metereologica</para><para>Weather prediction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#WeatherPrediction">http://www.disit.org/km4city/schema#WeatherPrediction</seealso>
    let WeatherPrediction = Prefixed_Name(km4c, "WeatherPrediction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Welfare_worker_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assistenti sociali uffici</para><para>Welfare worker office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Welfare_worker_office">http://www.disit.org/km4city/schema#Welfare_worker_office</seealso>
    let Welfare_worker_office =
        Prefixed_Name(km4c, "Welfare_worker_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wellness_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri benessere</para><para>Wellness centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wellness_centre">http://www.disit.org/km4city/schema#Wellness_centre</seealso>
    let Wellness_centre = Prefixed_Name(km4c, "Wellness_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_ICT_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ingrosso Apparecchiature ICT</para><para>Wholesale ICT Equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_ICT_equipment">http://www.disit.org/km4city/schema#Wholesale_ICT_equipment</seealso>
    let Wholesale_ICT_equipment =
        Prefixed_Name(km4c, "Wholesale_ICT_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_agricultural_raw_materials_live_animals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wholesale Agricultural Raw Materials Live Animals</para><para>Ingrosso Materie Prime Agricole e Animali</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_agricultural_raw_materials_live_animals">http://www.disit.org/km4city/schema#Wholesale_agricultural_raw_materials_live_animals</seealso>
    let Wholesale_agricultural_raw_materials_live_animals =
        Prefixed_Name(km4c, "Wholesale_agricultural_raw_materials_live_animals") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_food_beverages_tobacco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ingrosso Alimenti Bevande Tabacco</para><para>Wholesale Food Beverages Tobacco</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_food_beverages_tobacco">http://www.disit.org/km4city/schema#Wholesale_food_beverages_tobacco</seealso>
    let Wholesale_food_beverages_tobacco =
        Prefixed_Name(km4c, "Wholesale_food_beverages_tobacco") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_household_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wholesale Household Goods</para><para>Ingrosso Beni Cosumo</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_household_goods">http://www.disit.org/km4city/schema#Wholesale_household_goods</seealso>
    let Wholesale_household_goods =
        Prefixed_Name(km4c, "Wholesale_household_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_machinery_equipmentent_supplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ingrosso Apparecchiature Macchinari Forniture</para><para>Wholesale Machinery Equipmentent Supplies</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_machinery_equipmentent_supplies">http://www.disit.org/km4city/schema#Wholesale_machinery_equipmentent_supplies</seealso>
    let Wholesale_machinery_equipmentent_supplies =
        Prefixed_Name(km4c, "Wholesale_machinery_equipmentent_supplies") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_motor_vehicles_parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Ingrosso Ricambi Autoveicoli</para><para>Wholesale Motor Vehicles Parts</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_motor_vehicles_parts">http://www.disit.org/km4city/schema#Wholesale_motor_vehicles_parts</seealso>
    let Wholesale_motor_vehicles_parts =
        Prefixed_Name(km4c, "Wholesale_motor_vehicles_parts") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Commercio Ingrosso</para><para>Wholesale Trade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale_trade">http://www.disit.org/km4city/schema#Wholesale_trade</seealso>
    let Wholesale_trade = Prefixed_Name(km4c, "Wholesale_trade") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wine_shop_and_wine_bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Wine shop and wine bar</para><para>Enoteche e wine bar</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wine_shop_and_wine_bar">http://www.disit.org/km4city/schema#Wine_shop_and_wine_bar</seealso>
    let Wine_shop_and_wine_bar =
        Prefixed_Name(km4c, "Wine_shop_and_wine_bar") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Youth_assistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Assistenza minori</para><para>Youth assistance</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Youth_assistance">http://www.disit.org/km4city/schema#Youth_assistance</seealso>
    let Youth_assistance = Prefixed_Name(km4c, "Youth_assistance") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Youth_information_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Youth information centre</para><para>Informa Giovani</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Youth_information_centre">http://www.disit.org/km4city/schema#Youth_information_centre</seealso>
    let Youth_information_centre =
        Prefixed_Name(km4c, "Youth_information_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:abbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#abbreviation">http://www.disit.org/km4city/schema#abbreviation</seealso>
    let abbreviation = Prefixed_Name(km4c, "abbreviation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:accessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#accessType">http://www.disit.org/km4city/schema#accessType</seealso>
    let accessType = Prefixed_Name(km4c, "accessType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect a resolution to the municipality that have approved it</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasResolution">http://www.disit.org/km4city/schema#hasResolution</seealso>
    let hasResolution = Prefixed_Name(km4c, "hasResolution") |> PrefixedName
    /// <summary>
    ///   <para>km4c:areaCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#areaCode">http://www.disit.org/km4city/schema#areaCode</seealso>
    let areaCode = Prefixed_Name(km4c, "areaCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:areaName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#areaName">http://www.disit.org/km4city/schema#areaName</seealso>
    let areaName = Prefixed_Name(km4c, "areaName") |> PrefixedName
    /// <summary>
    ///   <para>km4c:arrangedOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each beacon to the road in which it is installed</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#arrangedOnRoad">http://www.disit.org/km4city/schema#arrangedOnRoad</seealso>
    let arrangedOnRoad = Prefixed_Name(km4c, "arrangedOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each forecast refers to a specific bus stop</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasForecast">http://www.disit.org/km4city/schema#hasForecast</seealso>
    let hasForecast = Prefixed_Name(km4c, "hasForecast") |> PrefixedName
    /// <summary>
    ///   <para>km4c:atecoCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#atecoCode">http://www.disit.org/km4city/schema#atecoCode</seealso>
    let atecoCode = Prefixed_Name(km4c, "atecoCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:automaticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#automaticity">http://www.disit.org/km4city/schema#automaticity</seealso>
    let automaticity = Prefixed_Name(km4c, "automaticity") |> PrefixedName
    /// <summary>
    ///   <para>km4c:averageDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#averageDistance">http://www.disit.org/km4city/schema#averageDistance</seealso>
    let averageDistance = Prefixed_Name(km4c, "averageDistance") |> PrefixedName
    /// <summary>
    ///   <para>km4c:axialMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#axialMass">http://www.disit.org/km4city/schema#axialMass</seealso>
    let axialMass = Prefixed_Name(km4c, "axialMass") |> PrefixedName
    /// <summary>
    ///   <para>km4c:composeSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway Section is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#composeSection">http://www.disit.org/km4city/schema#composeSection</seealso>
    let composeSection = Prefixed_Name(km4c, "composeSection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:composition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#composition">http://www.disit.org/km4city/schema#composition</seealso>
    let composition = Prefixed_Name(km4c, "composition") |> PrefixedName
    /// <summary>
    ///   <para>km4c:concernLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an AVMrecord concert to a unique line</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#concernLine">http://www.disit.org/km4city/schema#concernLine</seealso>
    let concernLine = Prefixed_Name(km4c, "concernLine") |> PrefixedName
    /// <summary>
    ///   <para>km4c:containsElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A road is formed by more elements road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#containsElement">http://www.disit.org/km4city/schema#containsElement</seealso>
    let containsElement = Prefixed_Name(km4c, "containsElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isPartOfRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>More road elements compose a road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isPartOfRoad">http://www.disit.org/km4city/schema#isPartOfRoad</seealso>
    let isPartOfRoad = Prefixed_Name(km4c, "isPartOfRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#distance">http://www.disit.org/km4city/schema#distance</seealso>
    let distance = Prefixed_Name(km4c, "distance") |> PrefixedName
    /// <summary>
    ///   <para>km4c:districtCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#districtCode">http://www.disit.org/km4city/schema#districtCode</seealso>
    let districtCode = Prefixed_Name(km4c, "districtCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:elemLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#elemLocation">http://www.disit.org/km4city/schema#elemLocation</seealso>
    let elemLocation = Prefixed_Name(km4c, "elemLocation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:elementClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#elementClass">http://www.disit.org/km4city/schema#elementClass</seealso>
    let elementClass = Prefixed_Name(km4c, "elementClass") |> PrefixedName
    /// <summary>
    ///   <para>km4c:elementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#elementType">http://www.disit.org/km4city/schema#elementType</seealso>
    let elementType = Prefixed_Name(km4c, "elementType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:entryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#entryType">http://www.disit.org/km4city/schema#entryType</seealso>
    let entryType = Prefixed_Name(km4c, "entryType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:fillRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#fillRate">http://www.disit.org/km4city/schema#fillRate</seealso>
    let fillRate = Prefixed_Name(km4c, "fillRate") |> PrefixedName
    /// <summary>
    ///   <para>km4c:firenzeCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#firenzeCard">http://www.disit.org/km4city/schema#firenzeCard</seealso>
    let firenzeCard = Prefixed_Name(km4c, "firenzeCard") |> PrefixedName
    /// <summary>
    ///   <para>km4c:formingAdminRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>more road elements form an administrative road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#formingAdminRoad">http://www.disit.org/km4city/schema#formingAdminRoad</seealso>
    let formingAdminRoad = Prefixed_Name(km4c, "formingAdminRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasRoadElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>more road elements form an administrative road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasRoadElement">http://www.disit.org/km4city/schema#hasRoadElement</seealso>
    let hasRoadElement = Prefixed_Name(km4c, "hasRoadElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:formsTable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>more road sensors form a sensor Table</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#formsTable">http://www.disit.org/km4city/schema#formsTable</seealso>
    let formsTable = Prefixed_Name(km4c, "formsTable") |> PrefixedName
    /// <summary>
    ///   <para>km4c:free</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#free">http://www.disit.org/km4city/schema#free</seealso>
    let free = Prefixed_Name(km4c, "free") |> PrefixedName
    /// <summary>
    ///   <para>km4c:freeEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#freeEvent">http://www.disit.org/km4city/schema#freeEvent</seealso>
    let freeEvent = Prefixed_Name(km4c, "freeEvent") |> PrefixedName
    /// <summary>
    ///   <para>km4c:gauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#gauge">http://www.disit.org/km4city/schema#gauge</seealso>
    let gauge = Prefixed_Name(km4c, "gauge") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasAVMRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the AVM refer to a specific ride code</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasAVMRecord">http://www.disit.org/km4city/schema#hasAVMRecord</seealso>
    let hasAVMRecord = Prefixed_Name(km4c, "hasAVMRecord") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>point corresponding to the house number of service</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasAccess">http://www.disit.org/km4city/schema#hasAccess</seealso>
    let hasAccess = Prefixed_Name(km4c, "hasAccess") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Bike_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Punto noleggio bici</para><para>Bike rental</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Bike_rental">http://www.disit.org/km4city/schema#Bike_rental</seealso>
    let Bike_rental = Prefixed_Name(km4c, "Bike_rental") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Boat_equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli per natanti</para><para>Boat equipment</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Boat_equipment">http://www.disit.org/km4city/schema#Boat_equipment</seealso>
    let Boat_equipment = Prefixed_Name(km4c, "Boat_equipment") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Boats_and_ships_rental</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Boats and ships rental</para><para>Noleggio barche</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Boats_and_ships_rental">http://www.disit.org/km4city/schema#Boats_and_ships_rental</seealso>
    let Boats_and_ships_rental =
        Prefixed_Name(km4c, "Boats_and_ships_rental") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Boxoffice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Boxoffice</para><para>Boxoffice</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Boxoffice">http://www.disit.org/km4city/schema#Boxoffice</seealso>
    let Boxoffice = Prefixed_Name(km4c, "Boxoffice") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi legati all'ambiente</para>
    /// labels<para>Environment</para><para>Ambiente</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Environment">http://www.disit.org/km4city/schema#Environment</seealso>
    let Environment = Prefixed_Name(km4c, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Building_material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Building Material</para><para>Materiali Edili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Building_material">http://www.disit.org/km4city/schema#Building_material</seealso>
    let Building_material = Prefixed_Name(km4c, "Building_material") |> PrefixedName
    /// <summary>
    ///   <para>km4c:BusStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Punto di interconnessione tra segmenti di strada per determinare il percorso di una linea di TPL</para>
    ///   <para>Servizio associato alla visualizzazione delle linee ATAF con le relative fermate</para>
    /// labels<para>Fermata bus</para><para>Bus Stop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#BusStop">http://www.disit.org/km4city/schema#BusStop</seealso>
    let BusStop = Prefixed_Name(km4c, "BusStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Geologists</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Geologists</para><para>Geologi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Geologists">http://www.disit.org/km4city/schema#Geologists</seealso>
    let Geologists = Prefixed_Name(km4c, "Geologists") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Golf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Golf</para><para>Golf</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Golf">http://www.disit.org/km4city/schema#Golf</seealso>
    let Golf = Prefixed_Name(km4c, "Golf") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Parties_and_ceremonies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Organizzazione feste e cerimonie</para><para>Parties and ceremonies</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Parties_and_ceremonies">http://www.disit.org/km4city/schema#Parties_and_ceremonies</seealso>
    let Parties_and_ceremonies =
        Prefixed_Name(km4c, "Parties_and_ceremonies") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pastry_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pastry shop</para><para>Pasticceria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pastry_shop">http://www.disit.org/km4city/schema#Pastry_shop</seealso>
    let Pastry_shop = Prefixed_Name(km4c, "Pastry_shop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Path</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi rappresentati da una spezzata</para>
    /// labels<para>Servizio con forma lineare</para><para>String Service</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Path">http://www.disit.org/km4city/schema#Path</seealso>
    let Path = Prefixed_Name(km4c, "Path") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Perfumery_and_cosmetic_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Perfumery and Cosmetic Articles</para><para>Profumeria Cosmetica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Perfumery_and_cosmetic_articles">http://www.disit.org/km4city/schema#Perfumery_and_cosmetic_articles</seealso>
    let Perfumery_and_cosmetic_articles =
        Prefixed_Name(km4c, "Perfumery_and_cosmetic_articles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pet_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Negozio di Animali</para><para>Pet Shop</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pet_shop">http://www.disit.org/km4city/schema#Pet_shop</seealso>
    let Pet_shop = Prefixed_Name(km4c, "Pet_shop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Photographic_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fotografia e studi fotografici</para><para>Photographic activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Photographic_activities">http://www.disit.org/km4city/schema#Photographic_activities</seealso>
    let Photographic_activities =
        Prefixed_Name(km4c, "Photographic_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Poison_control_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Poison control centre</para><para>Centro antiveleni</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Poison_control_centre">http://www.disit.org/km4city/schema#Poison_control_centre</seealso>
    let Poison_control_centre =
        Prefixed_Name(km4c, "Poison_control_centre") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Postal_and_courier_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Postal and Courier Activities</para><para>Poste e Corrieri</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Postal_and_courier_activities">http://www.disit.org/km4city/schema#Postal_and_courier_activities</seealso>
    let Postal_and_courier_activities =
        Prefixed_Name(km4c, "Postal_and_courier_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Pre_primary_education</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pre-primary education</para><para>Scuole dell'infanzia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Pre_primary_education">http://www.disit.org/km4city/schema#Pre_primary_education</seealso>
    let Pre_primary_education =
        Prefixed_Name(km4c, "Pre_primary_education") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Tourist_information_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ufficio Informazioni Turistiche</para><para>Tourist information office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tourist_information_office">http://www.disit.org/km4city/schema#Tourist_information_office</seealso>
    let Tourist_information_office =
        Prefixed_Name(km4c, "Tourist_information_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Towing_and_roadside_assistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Towing and Roadside Assistance</para><para>Traino e Soccorso Stradale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Towing_and_roadside_assistance">http://www.disit.org/km4city/schema#Towing_and_roadside_assistance</seealso>
    let Towing_and_roadside_assistance =
        Prefixed_Name(km4c, "Towing_and_roadside_assistance") |> PrefixedName

    /// <summary>
    ///   <para>km4c:TrafficConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>sottoclasse delle osservazioni relative alla concentrazione di auto</para>
    /// labels<para>Osservazione sulla concentrazione di auto</para><para>Traffic Concentration Observation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TrafficConcentration">http://www.disit.org/km4city/schema#TrafficConcentration</seealso>
    let TrafficConcentration =
        Prefixed_Name(km4c, "TrafficConcentration") |> PrefixedName

    /// <summary>
    ///   <para>km4c:TrafficHeadway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>sottoclasse delle osservazioni sul tempo medio di transito tra auto</para>
    /// labels<para>Osservazione sulla densita' di auto</para><para>Traffic Headway Observation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TrafficHeadway">http://www.disit.org/km4city/schema#TrafficHeadway</seealso>
    let TrafficHeadway = Prefixed_Name(km4c, "TrafficHeadway") |> PrefixedName
    /// <summary>
    ///   <para>km4c:averageTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Tempo medio tra 2 transiti</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#averageTime">http://www.disit.org/km4city/schema#averageTime</seealso>
    let averageTime = Prefixed_Name(km4c, "averageTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:TrafficSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>sottoclasse delle osservazioni relative alla velocita' media</para>
    /// labels<para>Osservazione sulla velocita'</para><para>TrafficSpeed Observation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TrafficSpeed">http://www.disit.org/km4city/schema#TrafficSpeed</seealso>
    let TrafficSpeed = Prefixed_Name(km4c, "TrafficSpeed") |> PrefixedName
    /// <summary>
    ///   <para>km4c:TrainStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Stazione ferroviaria, sono posizionate in corrispondenza di giunzioni ferroviarie con relazione 1:1</para>
    /// labels<para>Stazione Ferroviaria</para><para>Train Station</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#TrainStation">http://www.disit.org/km4city/schema#TrainStation</seealso>
    let TrainStation = Prefixed_Name(km4c, "TrainStation") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Train_lost_property_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ufficio oggetti smarriti stazione treno</para><para>Train lost property office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Train_lost_property_office">http://www.disit.org/km4city/schema#Train_lost_property_office</seealso>
    let Train_lost_property_office =
        Prefixed_Name(km4c, "Train_lost_property_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Tram_stops</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fermate del tram</para><para>Tram stops</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tram_stops">http://www.disit.org/km4city/schema#Tram_stops</seealso>
    let Tram_stops = Prefixed_Name(km4c, "Tram_stops") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tramline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Linea del Tram</para><para>Tram line</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tramline">http://www.disit.org/km4city/schema#Tramline</seealso>
    let Tramline = Prefixed_Name(km4c, "Tramline") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Trattoria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Trattoria</para><para>Trattoria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Trattoria">http://www.disit.org/km4city/schema#Trattoria</seealso>
    let Trattoria = Prefixed_Name(km4c, "Trattoria") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Travel_agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzia di viaggio</para><para>Travel agency</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Travel_agency">http://www.disit.org/km4city/schema#Travel_agency</seealso>
    let Travel_agency = Prefixed_Name(km4c, "Travel_agency") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lastStop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the AVMrecord specify which is the last bus stop made</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lastStop">http://www.disit.org/km4city/schema#lastStop</seealso>
    let lastStop = Prefixed_Name(km4c, "lastStop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lastStopTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>orario in cui il bus ha raggiunto l'ultima fermata DA ELIMINARE QUANDO INSTANT FUNZIONERA' ALLA PERFEZIONE</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lastStopTime">http://www.disit.org/km4city/schema#lastStopTime</seealso>
    let lastStopTime = Prefixed_Name(km4c, "lastStopTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lastTriples</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lastTriples">http://www.disit.org/km4city/schema#lastTriples</seealso>
    let lastTriples = Prefixed_Name(km4c, "lastTriples") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lastUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lastUpdate">http://www.disit.org/km4city/schema#lastUpdate</seealso>
    let lastUpdate = Prefixed_Name(km4c, "lastUpdate") |> PrefixedName
    /// <summary>
    ///   <para>km4c:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#length">http://www.disit.org/km4city/schema#length</seealso>
    let length = Prefixed_Name(km4c, "length") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Forestry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Silvicoltura</para><para>Forestry</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Forestry">http://www.disit.org/km4city/schema#Forestry</seealso>
    let Forestry = Prefixed_Name(km4c, "Forestry") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Frozen_food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Surgelati</para><para>Frozen Food</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Frozen_food">http://www.disit.org/km4city/schema#Frozen_food</seealso>
    let Frozen_food = Prefixed_Name(km4c, "Frozen_food") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Fruit_and_vegetables</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fruit and Vegetables</para><para>Frutta e Verdura</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fruit_and_vegetables">http://www.disit.org/km4city/schema#Fruit_and_vegetables</seealso>
    let Fruit_and_vegetables =
        Prefixed_Name(km4c, "Fruit_and_vegetables") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Funeral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pompe funebri</para><para>Funeral</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Funeral">http://www.disit.org/km4city/schema#Funeral</seealso>
    let Funeral = Prefixed_Name(km4c, "Funeral") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Fur_and_leather_clothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pellicce Abbigliamento Pelle</para><para>Fur and Leather Clothing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fur_and_leather_clothing">http://www.disit.org/km4city/schema#Fur_and_leather_clothing</seealso>
    let Fur_and_leather_clothing =
        Prefixed_Name(km4c, "Fur_and_leather_clothing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Game_reserve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Parco naturale</para><para>Game reserve</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Game_reserve">http://www.disit.org/km4city/schema#Game_reserve</seealso>
    let Game_reserve = Prefixed_Name(km4c, "Game_reserve") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Games_and_toys</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Giochi e Giocattoli</para><para>Games and toys</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Games_and_toys">http://www.disit.org/km4city/schema#Games_and_toys</seealso>
    let Games_and_toys = Prefixed_Name(km4c, "Games_and_toys") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Garden_and_agriculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Giardinaggio e Agricultura</para><para>Garden and Agriculture</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Garden_and_agriculture">http://www.disit.org/km4city/schema#Garden_and_agriculture</seealso>
    let Garden_and_agriculture =
        Prefixed_Name(km4c, "Garden_and_agriculture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:hasPrediction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a report is made up of more predictions</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasPrediction">http://www.disit.org/km4city/schema#hasPrediction</seealso>
    let hasPrediction = Prefixed_Name(km4c, "hasPrediction") |> PrefixedName
    /// <summary>
    ///   <para>km4c:hasProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>in a region there are more than one province</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#hasProvince">http://www.disit.org/km4city/schema#hasProvince</seealso>
    let hasProvince = Prefixed_Name(km4c, "hasProvince") |> PrefixedName
    /// <summary>
    ///   <para>km4c:AVMRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Corsa programmata da una certa azienda TPL su un certo percorso di una certa linea</para>
    /// labels<para>Registrazione AVM</para><para>AVM Record</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#AVMRecord">http://www.disit.org/km4city/schema#AVMRecord</seealso>
    let AVMRecord = Prefixed_Name(km4c, "AVMRecord") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Route</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Percorso che percorre un mezzo di trasporto pubblico</para>
    /// labels<para>Percorso</para><para>Route</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Route">http://www.disit.org/km4city/schema#Route</seealso>
    let Route = Prefixed_Name(km4c, "Route") |> PrefixedName
    /// <summary>
    ///   <para>km4c:onRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rides and AVMrecords refer to a specific route</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#onRoute">http://www.disit.org/km4city/schema#onRoute</seealso>
    let onRoute = Prefixed_Name(km4c, "onRoute") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cartographers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cartographers</para><para>Cartografi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cartographers">http://www.disit.org/km4city/schema#Cartographers</seealso>
    let Cartographers = Prefixed_Name(km4c, "Cartographers") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Charging_stations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Colonnina di ricarica</para><para>Charging stations</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Charging_stations">http://www.disit.org/km4city/schema#Charging_stations</seealso>
    let Charging_stations = Prefixed_Name(km4c, "Charging_stations") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Charter_airlines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Compagnie di Charter</para><para>Charter Airlines</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Charter_airlines">http://www.disit.org/km4city/schema#Charter_airlines</seealso>
    let Charter_airlines = Prefixed_Name(km4c, "Charter_airlines") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Churches</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Churches</para><para>Chiese</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Churches">http://www.disit.org/km4city/schema#Churches</seealso>
    let Churches = Prefixed_Name(km4c, "Churches") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cinema</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cinema</para><para>Cinema</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cinema">http://www.disit.org/km4city/schema#Cinema</seealso>
    let Cinema = Prefixed_Name(km4c, "Cinema") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Civil_airport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Aeroporto civile</para><para>Civil airport</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Civil_airport">http://www.disit.org/km4city/schema#Civil_airport</seealso>
    let Civil_airport = Prefixed_Name(km4c, "Civil_airport") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Civil_engineering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Civil Engineering</para><para>Ingegneria Civile</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Civil_engineering">http://www.disit.org/km4city/schema#Civil_engineering</seealso>
    let Civil_engineering = Prefixed_Name(km4c, "Civil_engineering") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Civil_protection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Protezione civile</para><para>Civil protection</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Civil_protection">http://www.disit.org/km4city/schema#Civil_protection</seealso>
    let Civil_protection = Prefixed_Name(km4c, "Civil_protection") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Civil_registry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Civil registry</para><para>Anagrafe</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Civil_registry">http://www.disit.org/km4city/schema#Civil_registry</seealso>
    let Civil_registry = Prefixed_Name(km4c, "Civil_registry") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cleaning_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cleaning activities</para><para>Pulizia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cleaning_activities">http://www.disit.org/km4city/schema#Cleaning_activities</seealso>
    let Cleaning_activities = Prefixed_Name(km4c, "Cleaning_activities") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Cleaning_materials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Cleaning Materials</para><para>Prodotti Pulizia</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cleaning_materials">http://www.disit.org/km4city/schema#Cleaning_materials</seealso>
    let Cleaning_materials = Prefixed_Name(km4c, "Cleaning_materials") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Climbing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Alpinismo</para><para>Climbing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Climbing">http://www.disit.org/km4city/schema#Climbing</seealso>
    let Climbing = Prefixed_Name(km4c, "Climbing") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Clothing_and_linen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Abbigliamento e Biancheria</para><para>Clothing and Linen</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Clothing_and_linen">http://www.disit.org/km4city/schema#Clothing_and_linen</seealso>
    let Clothing_and_linen = Prefixed_Name(km4c, "Clothing_and_linen") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Clothing_children_and_infants</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Clothing Children and Infants</para><para>Abbigliamento Bambino</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Clothing_children_and_infants">http://www.disit.org/km4city/schema#Clothing_children_and_infants</seealso>
    let Clothing_children_and_infants =
        Prefixed_Name(km4c, "Clothing_children_and_infants") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Coast_guard_harbormaster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Guardia costiera capitaneria di porto</para><para>Coast guard harbormaster</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Coast_guard_harbormaster">http://www.disit.org/km4city/schema#Coast_guard_harbormaster</seealso>
    let Coast_guard_harbormaster =
        Prefixed_Name(km4c, "Coast_guard_harbormaster") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Coffee_rosters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Coffee Rosters</para><para>Torrefazioni</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Coffee_rosters">http://www.disit.org/km4city/schema#Coffee_rosters</seealso>
    let Coffee_rosters = Prefixed_Name(km4c, "Coffee_rosters") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Combined_facilities_support_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi integrati di gestione agli edifici</para><para>Combined facilities support activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Combined_facilities_support_activities">http://www.disit.org/km4city/schema#Combined_facilities_support_activities</seealso>
    let Combined_facilities_support_activities =
        Prefixed_Name(km4c, "Combined_facilities_support_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Commissariat_of_public_safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Commissariato di pubblica sicurezza</para><para>Commissariat of public safety</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Commissariat_of_public_safety">http://www.disit.org/km4city/schema#Commissariat_of_public_safety</seealso>
    let Commissariat_of_public_safety =
        Prefixed_Name(km4c, "Commissariat_of_public_safety") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Computer_data_processing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Computer data processing</para><para>Elaborazione dati</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Computer_data_processing">http://www.disit.org/km4city/schema#Computer_data_processing</seealso>
    let Computer_data_processing =
        Prefixed_Name(km4c, "Computer_data_processing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Computer_programming_and_consultancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Programmazione e consulenza computer</para><para>Computer programming and consultancy</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Computer_programming_and_consultancy">http://www.disit.org/km4city/schema#Computer_programming_and_consultancy</seealso>
    let Computer_programming_and_consultancy =
        Prefixed_Name(km4c, "Computer_programming_and_consultancy") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Computer_technician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riparazione computer e periferiche</para><para>Computer technician</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Computer_technician">http://www.disit.org/km4city/schema#Computer_technician</seealso>
    let Computer_technician = Prefixed_Name(km4c, "Computer_technician") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Conservatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Conservatorio</para><para>Conservatory</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Conservatory">http://www.disit.org/km4city/schema#Conservatory</seealso>
    let Conservatory = Prefixed_Name(km4c, "Conservatory") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Consulting_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Servizi di Consulenza</para><para>Consulting services</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Consulting_services">http://www.disit.org/km4city/schema#Consulting_services</seealso>
    let Consulting_services = Prefixed_Name(km4c, "Consulting_services") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Controlled_parking_zone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Zona a sosta controllata</para><para>Controlled parking zone</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Controlled_parking_zone">http://www.disit.org/km4city/schema#Controlled_parking_zone</seealso>
    let Controlled_parking_zone =
        Prefixed_Name(km4c, "Controlled_parking_zone") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Courier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Corriere espresso</para><para>Courier</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Courier">http://www.disit.org/km4city/schema#Courier</seealso>
    let Courier = Prefixed_Name(km4c, "Courier") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Credit_collection_agencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Credit collection agencies</para><para>Agenzie recupero crediti</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Credit_collection_agencies">http://www.disit.org/km4city/schema#Credit_collection_agencies</seealso>
    let Credit_collection_agencies =
        Prefixed_Name(km4c, "Credit_collection_agencies") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Cultural_and_recreation_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Culturali e Ricreativi</para><para>Cultural and Recreation Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cultural_and_recreation_goods">http://www.disit.org/km4city/schema#Cultural_and_recreation_goods</seealso>
    let Cultural_and_recreation_goods =
        Prefixed_Name(km4c, "Cultural_and_recreation_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Cultural_sites</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Attivita' culturali</para><para>Cultural sites</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cultural_sites">http://www.disit.org/km4city/schema#Cultural_sites</seealso>
    let Cultural_sites = Prefixed_Name(km4c, "Cultural_sites") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Curtains_and_net_curtains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Curtains and Net Curtains</para><para>Tende e Tendine</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Curtains_and_net_curtains">http://www.disit.org/km4city/schema#Curtains_and_net_curtains</seealso>
    let Curtains_and_net_curtains =
        Prefixed_Name(km4c, "Curtains_and_net_curtains") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Cycle_paths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ciclopercorsi</para><para>Cycle paths</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Cycle_paths">http://www.disit.org/km4city/schema#Cycle_paths</seealso>
    let Cycle_paths = Prefixed_Name(km4c, "Cycle_paths") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Dairy_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Latte e Latticini</para><para>Dairy products</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Dairy_products">http://www.disit.org/km4city/schema#Dairy_products</seealso>
    let Dairy_products = Prefixed_Name(km4c, "Dairy_products") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Dance_schools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Scuole di danza</para><para>Dance schools</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Dance_schools">http://www.disit.org/km4city/schema#Dance_schools</seealso>
    let Dance_schools = Prefixed_Name(km4c, "Dance_schools") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Day_care_centre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centri accoglienza e case alloggio</para><para>Day care centre</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Day_care_centre">http://www.disit.org/km4city/schema#Day_care_centre</seealso>
    let Day_care_centre = Prefixed_Name(km4c, "Day_care_centre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Dentist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Dentista</para><para>Dentist</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Dentist">http://www.disit.org/km4city/schema#Dentist</seealso>
    let Dentist = Prefixed_Name(km4c, "Dentist") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Department_of_motor_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Department of motor vehicles</para><para>Motorizzazione civile</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Department_of_motor_vehicles">http://www.disit.org/km4city/schema#Department_of_motor_vehicles</seealso>
    let Department_of_motor_vehicles =
        Prefixed_Name(km4c, "Department_of_motor_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Diet_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Prodotti Dietetici</para><para>Diet Products</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Diet_products">http://www.disit.org/km4city/schema#Diet_products</seealso>
    let Diet_products = Prefixed_Name(km4c, "Diet_products") |> PrefixedName
    /// <summary>
    ///   <para>km4c:DigitalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi classificati dal comune di Firenze come Digital Location</para>
    /// labels<para>Digital Location</para><para>Digital Location</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#DigitalLocation">http://www.disit.org/km4city/schema#DigitalLocation</seealso>
    let DigitalLocation = Prefixed_Name(km4c, "DigitalLocation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Dining_hall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Dining hall</para><para>Mense</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Dining_hall">http://www.disit.org/km4city/schema#Dining_hall</seealso>
    let Dining_hall = Prefixed_Name(km4c, "Dining_hall") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Discotheque</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Discotheque</para><para>Discoteca</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Discotheque">http://www.disit.org/km4city/schema#Discotheque</seealso>
    let Discotheque = Prefixed_Name(km4c, "Discotheque") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Discount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Discount</para><para>Discount</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Discount">http://www.disit.org/km4city/schema#Discount</seealso>
    let Discount = Prefixed_Name(km4c, "Discount") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Disinfecting_and_exterminating_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Disinfecting and exterminating activities</para><para>Pulizia e disinfestazione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Disinfecting_and_exterminating_activities">http://www.disit.org/km4city/schema#Disinfecting_and_exterminating_activities</seealso>
    let Disinfecting_and_exterminating_activities =
        Prefixed_Name(km4c, "Disinfecting_and_exterminating_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:District</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zona che rappresenta l'estensione di un quartiere</para>
    /// labels<para>Quartiere</para><para>District</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#District">http://www.disit.org/km4city/schema#District</seealso>
    let District = Prefixed_Name(km4c, "District") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Doctor_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ambulatorio medico</para><para>Doctor office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Doctor_office">http://www.disit.org/km4city/schema#Doctor_office</seealso>
    let Doctor_office = Prefixed_Name(km4c, "Doctor_office") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Door_to_door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vendita Porta a Porta</para><para>Door to Door</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Door_to_door">http://www.disit.org/km4city/schema#Door_to_door</seealso>
    let Door_to_door = Prefixed_Name(km4c, "Door_to_door") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Drinking_fountain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Drinking fountain</para><para>Fontanelle</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Drinking_fountain">http://www.disit.org/km4city/schema#Drinking_fountain</seealso>
    let Drinking_fountain = Prefixed_Name(km4c, "Drinking_fountain") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Educational_support_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Educational support activities</para><para>Altri servizi all'istruzione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Educational_support_activities">http://www.disit.org/km4city/schema#Educational_support_activities</seealso>
    let Educational_support_activities =
        Prefixed_Name(km4c, "Educational_support_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Emergency_medical_care</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Emergency medical care</para><para>Guardia medica</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Emergency_medical_care">http://www.disit.org/km4city/schema#Emergency_medical_care</seealso>
    let Emergency_medical_care =
        Prefixed_Name(km4c, "Emergency_medical_care") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Emergency_services</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Emergency services</para><para>Soccorso stradale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Emergency_services">http://www.disit.org/km4city/schema#Emergency_services</seealso>
    let Emergency_services = Prefixed_Name(km4c, "Emergency_services") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Employment_exchange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Centro per l'impiego</para><para>Employment exchange</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Employment_exchange">http://www.disit.org/km4city/schema#Employment_exchange</seealso>
    let Employment_exchange = Prefixed_Name(km4c, "Employment_exchange") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Energy_supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fornitura Produzione Energia</para><para>Energy Supply</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Energy_supply">http://www.disit.org/km4city/schema#Energy_supply</seealso>
    let Energy_supply = Prefixed_Name(km4c, "Energy_supply") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Engineering_consulting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Engineering consulting</para><para>Studi di Ingegneria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Engineering_consulting">http://www.disit.org/km4city/schema#Engineering_consulting</seealso>
    let Engineering_consulting =
        Prefixed_Name(km4c, "Engineering_consulting") |> PrefixedName

    /// <summary>
    ///   <para>km4c:StreetNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono i numeri civici conosciuti</para>
    /// labels<para>Street Number</para><para>Numero Civico</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#StreetNumber">http://www.disit.org/km4city/schema#StreetNumber</seealso>
    let StreetNumber = Prefixed_Name(km4c, "StreetNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:EntryRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classe le cui istanze sono le regole di accesso ai differenti elementi stradali</para>
    /// labels<para>Regola di Acesso</para><para>Entry Rule</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#EntryRule">http://www.disit.org/km4city/schema#EntryRule</seealso>
    let EntryRule = Prefixed_Name(km4c, "EntryRule") |> PrefixedName
    /// <summary>
    ///   <para>km4c:accessToElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>an entry rule refers to a specific Road element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#accessToElement">http://www.disit.org/km4city/schema#accessToElement</seealso>
    let accessToElement = Prefixed_Name(km4c, "accessToElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Estate_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzia immobiliare</para><para>Estate activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Estate_activities">http://www.disit.org/km4city/schema#Estate_activities</seealso>
    let Estate_activities = Prefixed_Name(km4c, "Estate_activities") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Eventi programmati dal comune di firenze e dintormi</para>
    /// labels<para>Evento</para><para>Event</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Event">http://www.disit.org/km4city/schema#Event</seealso>
    let Event = Prefixed_Name(km4c, "Event") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Extraction_of_natural_gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Extraction of natural gas</para><para>Estrazione Gas Naturale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Extraction_of_natural_gas">http://www.disit.org/km4city/schema#Extraction_of_natural_gas</seealso>
    let Extraction_of_natural_gas =
        Prefixed_Name(km4c, "Extraction_of_natural_gas") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Extraction_of_salt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Estrazione di sale</para><para>Extraction of salt</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Extraction_of_salt">http://www.disit.org/km4city/schema#Extraction_of_salt</seealso>
    let Extraction_of_salt = Prefixed_Name(km4c, "Extraction_of_salt") |> PrefixedName
    /// <summary>
    ///   <para>km4c:MiningAndQuarrying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Servizi legati alle attivita' di estrazione e cave</para>
    /// labels<para>Mining and quarrying</para><para>Attivita' estrattive</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#MiningAndQuarrying">http://www.disit.org/km4city/schema#MiningAndQuarrying</seealso>
    let MiningAndQuarrying = Prefixed_Name(km4c, "MiningAndQuarrying") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Family_counselling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Family counselling</para><para>Consultori</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Family_counselling">http://www.disit.org/km4city/schema#Family_counselling</seealso>
    let Family_counselling = Prefixed_Name(km4c, "Family_counselling") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Financial_institute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Financial institute</para><para>Istituto monetario</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Financial_institute">http://www.disit.org/km4city/schema#Financial_institute</seealso>
    let Financial_institute = Prefixed_Name(km4c, "Financial_institute") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Fine_arts_articles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Articoli Belle Arti</para><para>Fine Arts Articles</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fine_arts_articles">http://www.disit.org/km4city/schema#Fine_arts_articles</seealso>
    let Fine_arts_articles = Prefixed_Name(km4c, "Fine_arts_articles") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Fire_brigade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Vigili del fuoco</para><para>Fire brigade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fire_brigade">http://www.disit.org/km4city/schema#Fire_brigade</seealso>
    let Fire_brigade = Prefixed_Name(km4c, "Fire_brigade") |> PrefixedName
    /// <summary>
    ///   <para>km4c:First_aid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Pronto soccorso</para><para>First aid</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#First_aid">http://www.disit.org/km4city/schema#First_aid</seealso>
    let First_aid = Prefixed_Name(km4c, "First_aid") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Fish_and_seafood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fish and Seafood</para><para>Pescherie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fish_and_seafood">http://www.disit.org/km4city/schema#Fish_and_seafood</seealso>
    let Fish_and_seafood = Prefixed_Name(km4c, "Fish_and_seafood") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Fishing_and_aquaculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Fishing and Aquaculture</para><para>Pesca e Acquicoltura</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fishing_and_aquaculture">http://www.disit.org/km4city/schema#Fishing_and_aquaculture</seealso>
    let Fishing_and_aquaculture =
        Prefixed_Name(km4c, "Fishing_and_aquaculture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Fishing_reserve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Riserve di pesca</para><para>Fishing reserve</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Fishing_reserve">http://www.disit.org/km4city/schema#Fishing_reserve</seealso>
    let Fishing_reserve = Prefixed_Name(km4c, "Fishing_reserve") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Flight_companies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Compagnie di Volo</para><para>Flight Companies</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Flight_companies">http://www.disit.org/km4city/schema#Flight_companies</seealso>
    let Flight_companies = Prefixed_Name(km4c, "Flight_companies") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Flower_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Flower shop</para><para>Fioraio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Flower_shop">http://www.disit.org/km4city/schema#Flower_shop</seealso>
    let Flower_shop = Prefixed_Name(km4c, "Flower_shop") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Food_and_ice_cream_truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Ristorazione e Gelaterie Ambulanti</para><para>Food and Ice Cream Truck</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Food_and_ice_cream_truck">http://www.disit.org/km4city/schema#Food_and_ice_cream_truck</seealso>
    let Food_and_ice_cream_truck =
        Prefixed_Name(km4c, "Food_and_ice_cream_truck") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Food_and_tobacconist</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Alimentari e Tabaccherie</para><para>Food and Tobacconist</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Food_and_tobacconist">http://www.disit.org/km4city/schema#Food_and_tobacconist</seealso>
    let Food_and_tobacconist =
        Prefixed_Name(km4c, "Food_and_tobacconist") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Food_manufacture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Produzione Alimentare</para><para>Food Manufacture</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Food_manufacture">http://www.disit.org/km4city/schema#Food_manufacture</seealso>
    let Food_manufacture = Prefixed_Name(km4c, "Food_manufacture") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Food_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rivendite di alimenti</para><para>Food trade</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Food_trade">http://www.disit.org/km4city/schema#Food_trade</seealso>
    let Food_trade = Prefixed_Name(km4c, "Food_trade") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Footwear_and_accessories</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Footwear and Accessories</para><para>Calzature</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Footwear_and_accessories">http://www.disit.org/km4city/schema#Footwear_and_accessories</seealso>
    let Footwear_and_accessories =
        Prefixed_Name(km4c, "Footwear_and_accessories") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Footwear_and_leather_goods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Calzature e Articoli in Pelle</para><para>Footwear and Leather Goods</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Footwear_and_leather_goods">http://www.disit.org/km4city/schema#Footwear_and_leather_goods</seealso>
    let Footwear_and_leather_goods =
        Prefixed_Name(km4c, "Footwear_and_leather_goods") |> PrefixedName

    /// <summary>
    ///   <para>km4c:News_agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzie di stampa</para><para>News agency</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#News_agency">http://www.disit.org/km4city/schema#News_agency</seealso>
    let News_agency = Prefixed_Name(km4c, "News_agency") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Newspapers_and_stationery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Newspapers and Stationery</para><para>Edicole e cartolerie</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Newspapers_and_stationery">http://www.disit.org/km4city/schema#Newspapers_and_stationery</seealso>
    let Newspapers_and_stationery =
        Prefixed_Name(km4c, "Newspapers_and_stationery") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Non_food_large_retailers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Grande distribuzione non alimentare</para><para>non food large retailers</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Non_food_large_retailers">http://www.disit.org/km4city/schema#Non_food_large_retailers</seealso>
    let Non_food_large_retailers =
        Prefixed_Name(km4c, "Non_food_large_retailers") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Non_food_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Altri Prodotti non Alimentari</para><para>Non-Food Products</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Non_food_products">http://www.disit.org/km4city/schema#Non_food_products</seealso>
    let Non_food_products = Prefixed_Name(km4c, "Non_food_products") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Non_specialized_wholesale_trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Non-specialized Wholesale Trade</para><para>Ingrosso Non Specializzato</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Non_specialized_wholesale_trade">http://www.disit.org/km4city/schema#Non_specialized_wholesale_trade</seealso>
    let Non_specialized_wholesale_trade =
        Prefixed_Name(km4c, "Non_specialized_wholesale_trade") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Wholesale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vendita all'ingrosso di qualsiasi cosa</para>
    /// labels<para>Vendita all'ingrosso</para><para>Wholesale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Wholesale">http://www.disit.org/km4city/schema#Wholesale</seealso>
    let Wholesale = Prefixed_Name(km4c, "Wholesale") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Singolo sensore per osservare velocita', traffico, concentrazione o densita'</para>
    /// labels<para>Osservazione</para><para>Observation</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Observation">http://www.disit.org/km4city/schema#Observation</seealso>
    let Observation = Prefixed_Name(km4c, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Office_Furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Mobili per Ufficio</para><para>Office Furniture</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Office_Furniture">http://www.disit.org/km4city/schema#Office_Furniture</seealso>
    let Office_Furniture = Prefixed_Name(km4c, "Office_Furniture") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Office_administrative_and_support_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Office administrative and support activities</para><para>Supporto per le funzioni d'ufficio</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Office_administrative_and_support_activities">http://www.disit.org/km4city/schema#Office_administrative_and_support_activities</seealso>
    let Office_administrative_and_support_activities =
        Prefixed_Name(km4c, "Office_administrative_and_support_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Operation_of_casinos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Operation of casinos</para><para>Slot Machines</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Operation_of_casinos">http://www.disit.org/km4city/schema#Operation_of_casinos</seealso>
    let Operation_of_casinos =
        Prefixed_Name(km4c, "Operation_of_casinos") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_manufacturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Altre Industrie Manifatturiere</para><para>Other Manufacturing</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_manufacturing">http://www.disit.org/km4city/schema#Other_manufacturing</seealso>
    let Other_manufacturing = Prefixed_Name(km4c, "Other_manufacturing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_mining_and_quarrying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Estrazione di altri minerali</para><para>Other mining and quarrying</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_mining_and_quarrying">http://www.disit.org/km4city/schema#Other_mining_and_quarrying</seealso>
    let Other_mining_and_quarrying =
        Prefixed_Name(km4c, "Other_mining_and_quarrying") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Altri Uffici</para><para>Other Office</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_office">http://www.disit.org/km4city/schema#Other_office</seealso>
    let Other_office = Prefixed_Name(km4c, "Other_office") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Other_retail_sale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Other Retail Sale</para><para>Altri Esercizi</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_retail_sale">http://www.disit.org/km4city/schema#Other_retail_sale</seealso>
    let Other_retail_sale = Prefixed_Name(km4c, "Other_retail_sale") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_specialized_construction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Altri Lavori Costruzione Specializzati</para><para>Other Specialized Construction</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_specialized_construction">http://www.disit.org/km4city/schema#Other_specialized_construction</seealso>
    let Other_specialized_construction =
        Prefixed_Name(km4c, "Other_specialized_construction") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_specialized_wholesale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Other Specialized Wholesale</para><para>Ingrosso Specializzato</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_specialized_wholesale">http://www.disit.org/km4city/schema#Other_specialized_wholesale</seealso>
    let Other_specialized_wholesale =
        Prefixed_Name(km4c, "Other_specialized_wholesale") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Other_telecommunications_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Other Telecommunications Activities</para><para>Servizi di telecomunicazione</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Other_telecommunications_activities">http://www.disit.org/km4city/schema#Other_telecommunications_activities</seealso>
    let Other_telecommunications_activities =
        Prefixed_Name(km4c, "Other_telecommunications_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Packaging_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Imballaggio e confezionamento</para><para>Packaging activities</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Packaging_activities">http://www.disit.org/km4city/schema#Packaging_activities</seealso>
    let Packaging_activities =
        Prefixed_Name(km4c, "Packaging_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Paramedical_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Paramedical activities</para><para>Attivita' paramediche</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Paramedical_activities">http://www.disit.org/km4city/schema#Paramedical_activities</seealso>
    let Paramedical_activities =
        Prefixed_Name(km4c, "Paramedical_activities") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Temp_agency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Agenzie Interinali</para><para>Temp agency</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Temp_agency">http://www.disit.org/km4city/schema#Temp_agency</seealso>
    let Temp_agency = Prefixed_Name(km4c, "Temp_agency") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Textile_manufacturing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Textile Manufacturing</para><para>Produzione Tessile</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Textile_manufacturing">http://www.disit.org/km4city/schema#Textile_manufacturing</seealso>
    let Textile_manufacturing =
        Prefixed_Name(km4c, "Textile_manufacturing") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Textiles_products</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Textiles Products</para><para>Prodotti Tessili</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Textiles_products">http://www.disit.org/km4city/schema#Textiles_products</seealso>
    let Textiles_products = Prefixed_Name(km4c, "Textiles_products") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Theatre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Theatre</para><para>Teatro</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Theatre">http://www.disit.org/km4city/schema#Theatre</seealso>
    let Theatre = Prefixed_Name(km4c, "Theatre") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Ticket_sale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Rivendita biglietti</para><para>Ticket sale</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Ticket_sale">http://www.disit.org/km4city/schema#Ticket_sale</seealso>
    let Ticket_sale = Prefixed_Name(km4c, "Ticket_sale") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tobacco_industry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Industria del Tabacco</para><para>Tobacco Industry</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tobacco_industry">http://www.disit.org/km4city/schema#Tobacco_industry</seealso>
    let Tobacco_industry = Prefixed_Name(km4c, "Tobacco_industry") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tobacco_shop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Tobacco shop</para><para>Tabaccheria</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tobacco_shop">http://www.disit.org/km4city/schema#Tobacco_shop</seealso>
    let Tobacco_shop = Prefixed_Name(km4c, "Tobacco_shop") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Toilet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Toilet</para><para>Bagno</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Toilet">http://www.disit.org/km4city/schema#Toilet</seealso>
    let Toilet = Prefixed_Name(km4c, "Toilet") |> PrefixedName
    /// <summary>
    ///   <para>km4c:Tour_operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Tour operator</para><para>Tour operator</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tour_operator">http://www.disit.org/km4city/schema#Tour_operator</seealso>
    let Tour_operator = Prefixed_Name(km4c, "Tour_operator") |> PrefixedName

    /// <summary>
    ///   <para>km4c:Tourist_complaints_office</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para></para>
    /// labels<para>Tourist complaints office</para><para>Uffici Reclami Turistici</para></remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#Tourist_complaints_office">http://www.disit.org/km4city/schema#Tourist_complaints_office</seealso>
    let Tourist_complaints_office =
        Prefixed_Name(km4c, "Tourist_complaints_office") |> PrefixedName

    /// <summary>
    ///   <para>km4c:houseNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#houseNumber">http://www.disit.org/km4city/schema#houseNumber</seealso>
    let houseNumber = Prefixed_Name(km4c, "houseNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#humidity">http://www.disit.org/km4city/schema#humidity</seealso>
    let humidity = Prefixed_Name(km4c, "humidity") |> PrefixedName
    /// <summary>
    ///   <para>km4c:inMunicipalityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>municipality to which the road belongs</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#inMunicipalityOf">http://www.disit.org/km4city/schema#inMunicipalityOf</seealso>
    let inMunicipalityOf = Prefixed_Name(km4c, "inMunicipalityOf") |> PrefixedName
    /// <summary>
    ///   <para>km4c:includeForecast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each AVMrecord includes more forecasts</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#includeForecast">http://www.disit.org/km4city/schema#includeForecast</seealso>
    let includeForecast = Prefixed_Name(km4c, "includeForecast") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantBObserv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ime and date of each Beacon observation</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantBObserv">http://www.disit.org/km4city/schema#instantBObserv</seealso>
    let instantBObserv = Prefixed_Name(km4c, "instantBObserv") |> PrefixedName
    /// <summary>
    ///   <para>km4c:measuredDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Time and date of each Beacon observation</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#measuredDate">http://www.disit.org/km4city/schema#measuredDate</seealso>
    let measuredDate = Prefixed_Name(km4c, "measuredDate") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantObserv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the time of one observation</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantObserv">http://www.disit.org/km4city/schema#instantObserv</seealso>
    let instantObserv = Prefixed_Name(km4c, "instantObserv") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the generation time of one situation record</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantParking">http://www.disit.org/km4city/schema#instantParking</seealso>
    let instantParking = Prefixed_Name(km4c, "instantParking") |> PrefixedName
    /// <summary>
    ///   <para>km4c:instantWReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the generation time of a new weather report</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#instantWReport">http://www.disit.org/km4city/schema#instantWReport</seealso>
    let instantWReport = Prefixed_Name(km4c, "instantWReport") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isInElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each milestone need to refers to a road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isInElement">http://www.disit.org/km4city/schema#isInElement</seealso>
    let isInElement = Prefixed_Name(km4c, "isInElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isInMunicipality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A bus stop can be connected to the municipality to which belong</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isInMunicipality">http://www.disit.org/km4city/schema#isInMunicipality</seealso>
    let isInMunicipality = Prefixed_Name(km4c, "isInMunicipality") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isInRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> service and train station can be connected to the referred Road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isInRoad">http://www.disit.org/km4city/schema#isInRoad</seealso>
    let isInRoad = Prefixed_Name(km4c, "isInRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isPartOfLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>a railway line is composed by more railway element</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isPartOfLine">http://www.disit.org/km4city/schema#isPartOfLine</seealso>
    let isPartOfLine = Prefixed_Name(km4c, "isPartOfLine") |> PrefixedName
    /// <summary>
    ///   <para>km4c:isPartOfLot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>bus stops and bus lines are part of a lot</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#isPartOfLot">http://www.disit.org/km4city/schema#isPartOfLot</seealso>
    let isPartOfLot = Prefixed_Name(km4c, "isPartOfLot") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lineNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lineNumber">http://www.disit.org/km4city/schema#lineNumber</seealso>
    let lineNumber = Prefixed_Name(km4c, "lineNumber") |> PrefixedName
    /// <summary>
    ///   <para>km4c:lunarPhase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#lunarPhase">http://www.disit.org/km4city/schema#lunarPhase</seealso>
    let lunarPhase = Prefixed_Name(km4c, "lunarPhase") |> PrefixedName
    /// <summary>
    ///   <para>km4c:major</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#major">http://www.disit.org/km4city/schema#major</seealso>
    let major = Prefixed_Name(km4c, "major") |> PrefixedName
    /// <summary>
    ///   <para>km4c:managingAuth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#managingAuth">http://www.disit.org/km4city/schema#managingAuth</seealso>
    let managingAuth = Prefixed_Name(km4c, "managingAuth") |> PrefixedName
    /// <summary>
    ///   <para>km4c:managingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the authority that deals with the road elements management</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#managingAuthority">http://www.disit.org/km4city/schema#managingAuthority</seealso>
    let managingAuthority = Prefixed_Name(km4c, "managingAuthority") |> PrefixedName
    /// <summary>
    ///   <para>km4c:managingBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>ente gestore del sistema AVM o dei road sensor</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#managingBy">http://www.disit.org/km4city/schema#managingBy</seealso>
    let managingBy = Prefixed_Name(km4c, "managingBy") |> PrefixedName
    /// <summary>
    ///   <para>km4c:maneuverType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#maneuverType">http://www.disit.org/km4city/schema#maneuverType</seealso>
    let maneuverType = Prefixed_Name(km4c, "maneuverType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:maxTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#maxTemp">http://www.disit.org/km4city/schema#maxTemp</seealso>
    let maxTemp = Prefixed_Name(km4c, "maxTemp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:measuredByBeacon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each observation to the beacon that has product it</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#measuredByBeacon">http://www.disit.org/km4city/schema#measuredByBeacon</seealso>
    let measuredByBeacon = Prefixed_Name(km4c, "measuredByBeacon") |> PrefixedName
    /// <summary>
    ///   <para>km4c:measuredBySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each observation refers to only one road sensor</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#measuredBySensor">http://www.disit.org/km4city/schema#measuredBySensor</seealso>
    let measuredBySensor = Prefixed_Name(km4c, "measuredBySensor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:measuredTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the time of one observation</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#measuredTime">http://www.disit.org/km4city/schema#measuredTime</seealso>
    let measuredTime = Prefixed_Name(km4c, "measuredTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:minTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#minTemp">http://www.disit.org/km4city/schema#minTemp</seealso>
    let minTemp = Prefixed_Name(km4c, "minTemp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:minor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#minor">http://www.disit.org/km4city/schema#minor</seealso>
    let minor = Prefixed_Name(km4c, "minor") |> PrefixedName
    /// <summary>
    ///   <para>km4c:moonrise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#moonrise">http://www.disit.org/km4city/schema#moonrise</seealso>
    let moonrise = Prefixed_Name(km4c, "moonrise") |> PrefixedName
    /// <summary>
    ///   <para>km4c:moonset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#moonset">http://www.disit.org/km4city/schema#moonset</seealso>
    let moonset = Prefixed_Name(km4c, "moonset") |> PrefixedName
    /// <summary>
    ///   <para>km4c:multimediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#multimediaResource">http://www.disit.org/km4city/schema#multimediaResource</seealso>
    let multimediaResource = Prefixed_Name(km4c, "multimediaResource") |> PrefixedName
    /// <summary>
    ///   <para>km4c:nodeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#nodeType">http://www.disit.org/km4city/schema#nodeType</seealso>
    let nodeType = Prefixed_Name(km4c, "nodeType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:numTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>numero di binari presenti. se in costruzione o dismesso inserire uno zero</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#numTrack">http://www.disit.org/km4city/schema#numTrack</seealso>
    let numTrack = Prefixed_Name(km4c, "numTrack") |> PrefixedName
    /// <summary>
    ///   <para>km4c:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#number">http://www.disit.org/km4city/schema#number</seealso>
    let number = Prefixed_Name(km4c, "number") |> PrefixedName
    /// <summary>
    ///   <para>km4c:observationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the generation time of one situation record</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#observationTime">http://www.disit.org/km4city/schema#observationTime</seealso>
    let observationTime = Prefixed_Name(km4c, "observationTime") |> PrefixedName
    /// <summary>
    ///   <para>km4c:perTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#perTemp">http://www.disit.org/km4city/schema#perTemp</seealso>
    let perTemp = Prefixed_Name(km4c, "perTemp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:period</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#period">http://www.disit.org/km4city/schema#period</seealso>
    let period = Prefixed_Name(km4c, "period") |> PrefixedName
    /// <summary>
    ///   <para>km4c:placeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#placeName">http://www.disit.org/km4city/schema#placeName</seealso>
    let placeName = Prefixed_Name(km4c, "placeName") |> PrefixedName
    /// <summary>
    ///   <para>km4c:placedInElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>each entry need to refers to a road</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#placedInElement">http://www.disit.org/km4city/schema#placedInElement</seealso>
    let placedInElement = Prefixed_Name(km4c, "placedInElement") |> PrefixedName
    /// <summary>
    ///   <para>km4c:placedOnRoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>to connect each road sensor to the road in which is installed</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#placedOnRoad">http://www.disit.org/km4city/schema#placedOnRoad</seealso>
    let placedOnRoad = Prefixed_Name(km4c, "placedOnRoad") |> PrefixedName
    /// <summary>
    ///   <para>km4c:porteCochere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#porteCochere">http://www.disit.org/km4city/schema#porteCochere</seealso>
    let porteCochere = Prefixed_Name(km4c, "porteCochere") |> PrefixedName
    /// <summary>
    ///   <para>km4c:power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#power">http://www.disit.org/km4city/schema#power</seealso>
    let power = Prefixed_Name(km4c, "power") |> PrefixedName
    /// <summary>
    ///   <para>km4c:primaryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#primaryType">http://www.disit.org/km4city/schema#primaryType</seealso>
    let primaryType = Prefixed_Name(km4c, "primaryType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:processType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#processType">http://www.disit.org/km4city/schema#processType</seealso>
    let processType = Prefixed_Name(km4c, "processType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:public</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#public">http://www.disit.org/km4city/schema#public</seealso>
    let public_ = Prefixed_Name(km4c, "public") |> PrefixedName
    /// <summary>
    ///   <para>km4c:railDepartment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#railDepartment">http://www.disit.org/km4city/schema#railDepartment</seealso>
    let railDepartment = Prefixed_Name(km4c, "railDepartment") |> PrefixedName
    /// <summary>
    ///   <para>km4c:railwaySiding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#railwaySiding">http://www.disit.org/km4city/schema#railwaySiding</seealso>
    let railwaySiding = Prefixed_Name(km4c, "railwaySiding") |> PrefixedName
    /// <summary>
    ///   <para>km4c:recTemp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#recTemp">http://www.disit.org/km4city/schema#recTemp</seealso>
    let recTemp = Prefixed_Name(km4c, "recTemp") |> PrefixedName
    /// <summary>
    ///   <para>km4c:refersToRide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>the AVM refer to a specific ride code</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#refersToRide">http://www.disit.org/km4city/schema#refersToRide</seealso>
    let refersToRide = Prefixed_Name(km4c, "refersToRide") |> PrefixedName
    /// <summary>
    ///   <para>km4c:restrictionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#restrictionType">http://www.disit.org/km4city/schema#restrictionType</seealso>
    let restrictionType = Prefixed_Name(km4c, "restrictionType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:restrictionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#restrictionValue">http://www.disit.org/km4city/schema#restrictionValue</seealso>
    let restrictionValue = Prefixed_Name(km4c, "restrictionValue") |> PrefixedName
    /// <summary>
    ///   <para>km4c:rideState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>stato della corsa: anticipo, ritardo, in orario</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#rideState">http://www.disit.org/km4city/schema#rideState</seealso>
    let rideState = Prefixed_Name(km4c, "rideState") |> PrefixedName
    /// <summary>
    ///   <para>km4c:roadName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#roadName">http://www.disit.org/km4city/schema#roadName</seealso>
    let roadName = Prefixed_Name(km4c, "roadName") |> PrefixedName
    /// <summary>
    ///   <para>km4c:roadType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#roadType">http://www.disit.org/km4city/schema#roadType</seealso>
    let roadType = Prefixed_Name(km4c, "roadType") |> PrefixedName
    /// <summary>
    ///   <para>km4c:routeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#routeCode">http://www.disit.org/km4city/schema#routeCode</seealso>
    let routeCode = Prefixed_Name(km4c, "routeCode") |> PrefixedName
    /// <summary>
    ///   <para>km4c:routeLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#routeLength">http://www.disit.org/km4city/schema#routeLength</seealso>
    let routeLength = Prefixed_Name(km4c, "routeLength") |> PrefixedName
    /// <summary>
    ///   <para>km4c:routePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#routePosition">http://www.disit.org/km4city/schema#routePosition</seealso>
    let routePosition = Prefixed_Name(km4c, "routePosition") |> PrefixedName
    /// <summary>
    ///   <para>km4c:snow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://www.disit.org/km4city/schema#snow">http://www.disit.org/km4city/schema#snow</seealso>
    let snow = Prefixed_Name(km4c, "snow") |> PrefixedName
