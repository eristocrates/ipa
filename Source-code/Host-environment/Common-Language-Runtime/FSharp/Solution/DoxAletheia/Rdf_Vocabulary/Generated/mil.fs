namespace http.rdf.muninn_project.org.ontologies.military.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mil =
    let _namespace_iri = Namespace_Iri mil |> NamespaceIRI

    /// <summary>
    ///   <para>mil:AirForceServiceBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:ArmsType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Force aérienne (Service Militare)</para><para>Air Force (Service Branch)</para><para>Luftstreitkräfte (Service)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceServiceBranch">http://rdf.muninn-project.org/ontologies/military#AirForceServiceBranch</seealso>
    let AirForceServiceBranch =
        Prefixed_Name(mil, "AirForceServiceBranch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_vice-marshal_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air vice-marshal (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Air vice-marshal (Australië (land))</para><para>Air vice-marshal (Australien)</para><para>Air vice-marshal (Australien)</para><para>Air vice-marshal (Australia)</para><para>Air vice-marshal (Australia)</para><para>Air vice-marshal (Australia)</para><para>Air vice-marshal (Austrália)</para><para>Air vice-marshal (Australie)</para><para>Air vice-marshal (Australia)</para><para>Air vice-marshal (Australia)</para><para>Air vice-marshal (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Australia</seealso>
    let Rank_Air_vice_marshal_Australia =
        Prefixed_Name(mil, "Rank_Air_vice-marshal_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_Marshal_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ»Ð°Ð²Ð½ÑÐ¹ Ð¼Ð°ÑÑÐ°Ð» ÑÐ¾Ð´Ð° Ð²Ð¾Ð¹ÑÐº (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Chief Marshal (Ryssland)</para><para>Chief Marshal (Russland)</para><para>Chief Marshal (Russland)</para><para>Chief Marshal (Rusland)</para><para>Chief Marshal (Russie)</para><para>Chief Marshal (Russia)</para><para>Chief Marshal (Russia)</para><para>Chief Marshal (Rússia)</para><para>Chief Marshal (Venäjä)</para><para>Chief Marshal (Rusia)</para><para>Chief Marshal (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Russia</seealso>
    let Rank_Chief_Marshal_Russia =
        Prefixed_Name(mil, "Rank_Chief_Marshal_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_Marshal_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ»Ð°Ð²Ð½ÑÐ¹ Ð¼Ð°ÑÑÐ°Ð» ÑÐ¾Ð´Ð° Ð²Ð¾Ð¹ÑÐº (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Chief Marshal (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Chief Marshal (Union des républiques socialistes soviétiques)</para><para>Chief Marshal (Unione Sovietica)</para><para>Chief Marshal (União Soviética)</para><para>Chief Marshal (Unión Soviética)</para><para>Chief Marshal (Neuvostoliitto)</para><para>Chief Marshal (Sovjetunionen)</para><para>Chief Marshal (Sovjetunionen)</para><para>Chief Marshal (Soviet Union)</para><para>Chief Marshal (Sovjet-Unie)</para><para>Chief Marshal (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Soviet_Union</seealso>
    let Rank_Chief_Marshal_Soviet_Union =
        Prefixed_Name(mil, "Rank_Chief_Marshal_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chief petty officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer</seealso>
    let Rank_Chief_petty_officer =
        Prefixed_Name(mil, "Rank_Chief_petty_officer") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer,_1st_class_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para> Chief petty officer, 1st Class (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class_Canada</seealso>
    let ``Rank_Chief_petty_officer,_1st_class_Canada`` =
        Prefixed_Name(mil, "Rank_Chief_petty_officer,_1st_class_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer,_1st_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class</seealso>
    let ``Rank_Chief_petty_officer,_1st_class`` =
        Prefixed_Name(mil, "Rank_Chief_petty_officer,_1st_class") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer,_2nd_class_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para> Chief petty officer, 2nd Class (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class_Canada</seealso>
    let ``Rank_Chief_petty_officer,_2nd_class_Canada`` =
        Prefixed_Name(mil, "Rank_Chief_petty_officer,_2nd_class_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer,_2nd_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class</seealso>
    let ``Rank_Chief_petty_officer,_2nd_class`` =
        Prefixed_Name(mil, "Rank_Chief_petty_officer,_2nd_class") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chief petty officer (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Chief petty officer (Australië (land))</para><para>Chief petty officer (Australien)</para><para>Chief petty officer (Australien)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australia)</para><para>Chief petty officer (Australie)</para><para>Chief petty officer (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Australia</seealso>
    let Rank_Chief_petty_officer_Australia =
        Prefixed_Name(mil, "Rank_Chief_petty_officer_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chief petty officer (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Canada</seealso>
    let Rank_Chief_petty_officer_Canada =
        Prefixed_Name(mil, "Rank_Chief_petty_officer_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_petty_officer_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Chief petty officer (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Chief petty officer (Commonwealth delle nazioni)</para><para>Chief petty officer (Mancomunidad de Naciones)</para><para>Chief petty officer (Commonwealth of Nations)</para><para>Chief petty officer (Commonwealth of Nations)</para><para>Chief petty officer (Commonwealth of Nations)</para><para>Chief petty officer (Samveldet av nasjoner)</para><para>Chief petty officer (Gemenebest van Naties)</para><para>Chief petty officer (Wspólnota Narodów)</para><para>Chief petty officer (Kansainyhteisö)</para><para>Chief petty officer (Commonwealth)</para><para>Chief petty officer (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Commonwealth_of_Nations</seealso>
    let Rank_Chief_petty_officer_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Chief_petty_officer_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chiliarque</para><para>Chiliarcha</para><para>Chiliarch</para><para>Quiliarca</para><para>Chiliarch</para><para>Chiliarca</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch</seealso>
    let Rank_Chiliarch = Prefixed_Name(mil, "Rank_Chiliarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chiliarch (ÐÑÐµÑÐ¸Ñ)</para><para>Chiliarch (Griechenland)</para><para>Chiliarch (Griekenland)</para><para>Chiliarch (Grekland)</para><para>Chiliarcha (Grecja)</para><para>Chiliarch (Kreikka)</para><para>Chiliarca (Grecia)</para><para>Quiliarca (Grecia)</para><para>Chiliarch (Greece)</para><para>Chiliarch (Hellas)</para><para>Chiliarch (Grécia)</para><para>Chiliarque (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Greece</seealso>
    let Rank_Chiliarch_Greece =
        Prefixed_Name(mil, "Rank_Chiliarch_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_Admiral_Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Divisional Admiral (ÐÑÐ°Ð»Ð¸Ñ)</para><para>Ammiraglio di divisione (Italia)</para><para>Divisional Admiral (Italien)</para><para>Divisional Admiral (Italien)</para><para>Divisional Admiral (WÅochy)</para><para>Divisional Admiral (Itália)</para><para>Divisional Admiral (Italia)</para><para>Divisional Admiral (Italia)</para><para>Divisional Admiral (Italia)</para><para>Amiral de division (Italie)</para><para>Divisional Admiral (Italy)</para><para>Divisieadmiraal (Italië)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Italy">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Italy</seealso>
    let Rank_Divisional_Admiral_Italy =
        Prefixed_Name(mil, "Rank_Divisional_Admiral_Italy") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_General</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Generale di divisione</para><para>Général de division</para><para>Divisional General</para><para>General de divisão</para><para>Divisioonakenraali</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General</seealso>
    let Rank_Divisional_General =
        Prefixed_Name(mil, "Rank_Divisional_General") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_General_France</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Generale di divisione (France)</para><para>Général de division (France)</para><para>General de divisão (France)</para><para>Divisioonakenraali (France)</para><para>Divisional General (France)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_France">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_France</seealso>
    let Rank_Divisional_General_France =
        Prefixed_Name(mil, "Rank_Divisional_General_France") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_General_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Generale di divisione (Poland)</para><para>Général de division (Poland)</para><para>Divisioonakenraali (Poland)</para><para>General de divisão (Poland)</para><para>Divisional General (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_Poland</seealso>
    let Rank_Divisional_General_Poland =
        Prefixed_Name(mil, "Rank_Divisional_General_Poland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hetman_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÑÐ¼Ð°Ð½ (Poland)</para><para>Hetmani (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para><para>Hetman (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Poland</seealso>
    let Rank_Hetman_Poland = Prefixed_Name(mil, "Rank_Hetman_Poland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lochagos_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Lochagos (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Lochagos_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Lochagos_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lord_High_Admiral_of_the_Wash</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lord High Admiral of the Wash</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash">http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash</seealso>
    let Rank_Lord_High_Admiral_of_the_Wash =
        Prefixed_Name(mil, "Rank_Lord_High_Admiral_of_the_Wash") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lord_High_Admiral_of_the_Wash_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lord High Admiral of the Wash (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_England">http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_England</seealso>
    let Rank_Lord_High_Admiral_of_the_Wash_England =
        Prefixed_Name(mil, "Rank_Lord_High_Admiral_of_the_Wash_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lord_High_Admiral_of_the_Wash_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lord High Admiral of the Wash (Pays de Galles)</para><para>Lord High Admiral of the Wash (País de Gales)</para><para>Lord High Admiral of the Wash (Ð£ÑÐ»ÑÑ)</para><para>Lord High Admiral of the Wash (Galles)</para><para>Lord High Admiral of the Wash (Wales)</para><para>Lord High Admiral of the Wash (Gales)</para><para>Lord High Admiral of the Wash (Wales)</para><para>Lord High Admiral of the Wash (Walia)</para><para>Lord High Admiral of the Wash (Wales)</para><para>Lord High Admiral of the Wash (Wales)</para><para>Lord High Admiral of the Wash (Wales)</para><para>Lord High Admiral of the Wash (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Wales</seealso>
    let Rank_Lord_High_Admiral_of_the_Wash_Wales =
        Prefixed_Name(mil, "Rank_Lord_High_Admiral_of_the_Wash_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Major_general</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Major general</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general">http://rdf.muninn-project.org/ontologies/military#Rank_Major_general</seealso>
    let Rank_Major_general = Prefixed_Name(mil, "Rank_Major_general") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Major_general_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Major general (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Major general (Australië (land))</para><para>Major general (Australien)</para><para>Major general (Australien)</para><para>Major general (Australia)</para><para>Major general (Australia)</para><para>Major general (Australia)</para><para>Major general (Australia)</para><para>Major general (Austrália)</para><para>Major general (Australie)</para><para>Major general (Australia)</para><para>Major general (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Australia</seealso>
    let Rank_Major_general_Australia =
        Prefixed_Name(mil, "Rank_Major_general_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Major_general_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Major general (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Canada</seealso>
    let Rank_Major_general_Canada =
        Prefixed_Name(mil, "Rank_Major_general_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sotnik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡Ð¾ÑÐ½Ð¸Ðº (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Sotnik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Sotnik (Union des républiques socialistes soviétiques)</para><para>Sotnik (Unione Sovietica)</para><para>Sotnik (Unión Soviética)</para><para>Sótnik (União Soviética)</para><para>Sotnik (Neuvostoliitto)</para><para>Sotnik (Sovjetunionen)</para><para>Sotnik (Sovjetunionen)</para><para>Sotnik (Soviet Union)</para><para>Sotnik (Sowjetunion)</para><para>Sotnik (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Soviet_Union</seealso>
    let Rank_Sotnik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Sotnik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sotnik_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡Ð¾ÑÐ½Ð¸Ðº (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Sotnik (Oekraïne)</para><para>Sotnik (Ucrania)</para><para>Sotnik (Ukraine)</para><para>Sotnik (Ukraina)</para><para>Sotnik (Ukraine)</para><para>Sótnik (Ucrânia)</para><para>Sotnik (Ukraina)</para><para>Sotnik (Ucraina)</para><para>Sotnik (Ukraina)</para><para>Sotnik (Ukraine)</para><para>Sotnik (Ukraina)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Ukraine</seealso>
    let Rank_Sotnik_Ukraine = Prefixed_Name(mil, "Rank_Sotnik_Ukraine") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Trooper_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trooper (rank, Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Canada</seealso>
    let Rank_Trooper_Canada = Prefixed_Name(mil, "Rank_Trooper_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trooper_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trooper (rank) (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Trooper (rank) (Commonwealth delle nazioni)</para><para>Trooper (rank) (Mancomunidad de Naciones)</para><para>Trooper (rank) (Commonwealth of Nations)</para><para>Trooper (rank) (Commonwealth of Nations)</para><para>Trooper (rank) (Commonwealth of Nations)</para><para>Trooper (rank) (Samveldet av nasjoner)</para><para>Trooper (rank) (Gemenebest van Naties)</para><para>Trooper (rank) (Wspólnota Narodów)</para><para>Trooper (rank) (Kansainyhteisö)</para><para>Trooper (rank) (Commonwealth)</para><para>Trooper (rank) (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Commonwealth_of_Nations</seealso>
    let Rank_Trooper_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Trooper_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trumpet_Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trumpet Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major">http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major</seealso>
    let Rank_Trumpet_Major = Prefixed_Name(mil, "Rank_Trumpet_Major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trumpet_Major_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Trumpet Major (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Trumpet Major (Commonwealth delle nazioni)</para><para>Trumpet Major (Mancomunidad de Naciones)</para><para>Trumpet Major (Commonwealth of Nations)</para><para>Trumpet Major (Commonwealth of Nations)</para><para>Trumpet Major (Commonwealth of Nations)</para><para>Trumpet Major (Gemenebest van Naties)</para><para>Trumpet Major (Samveldet av nasjoner)</para><para>Trumpet Major (Wspólnota Narodów)</para><para>Trumpet Major (Kansainyhteisö)</para><para>Trumpet Major (Commonwealth)</para><para>Trumpet Major (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Commonwealth_of_Nations</seealso>
    let Rank_Trumpet_Major_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Trumpet_Major_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trumpet_Major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Trumpet Major (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_England</seealso>
    let Rank_Trumpet_Major_England =
        Prefixed_Name(mil, "Rank_Trumpet_Major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trumpet_Major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Trumpet Major (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Trumpet Major (Schottland)</para><para>Trumpet Major (Skottland)</para><para>Trumpet Major (Skotlanti)</para><para>Trumpet Major (Skottland)</para><para>Trumpet Major (Schotland)</para><para>Trumpet Major (Scotland)</para><para>Trumpet Major (Szkocja)</para><para>Trumpet Major (Escócia)</para><para>Trumpet Major (Escocia)</para><para>Trumpet Major (Scozia)</para><para>Trumpet Major (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Scotland</seealso>
    let Rank_Trumpet_Major_Scotland =
        Prefixed_Name(mil, "Rank_Trumpet_Major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trumpet_Major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trumpet Major (Pays de Galles)</para><para>Trumpet Major (País de Gales)</para><para>Trumpet Major (Ð£ÑÐ»ÑÑ)</para><para>Trumpet Major (Galles)</para><para>Trumpet Major (Gales)</para><para>Trumpet Major (Walia)</para><para>Trumpet Major (Wales)</para><para>Trumpet Major (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Wales</seealso>
    let Rank_Trumpet_Major_Wales =
        Prefixed_Name(mil, "Rank_Trumpet_Major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tysyatsky</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢ÑÑÑÑÐºÐ¸Ð¹</para><para>Tysjatski</para><para>Tysjackij</para><para>Tysyatsky</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky">http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky</seealso>
    let Rank_Tysyatsky = Prefixed_Name(mil, "Rank_Tysyatsky") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tysyatsky_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢ÑÑÑÑÐºÐ¸Ð¹ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Tysyatsky (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Tysyatsky (Union des républiques socialistes soviétiques)</para><para>Tysjackij (Unione Sovietica)</para><para>Tysyatsky (Unión Soviética)</para><para>Tysyatsky (União Soviética)</para><para>Tysyatsky (Neuvostoliitto)</para><para>Tysyatsky (Sovjetunionen)</para><para>Tysyatsky (Sovjetunionen)</para><para>Tysyatsky (Soviet Union)</para><para>Tysjatski (Sovjet-Unie)</para><para>Tysyatsky (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Soviet_Union</seealso>
    let Rank_Tysyatsky_Soviet_Union =
        Prefixed_Name(mil, "Rank_Tysyatsky_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Under Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer</seealso>
    let Rank_Under_Officer = Prefixed_Name(mil, "Rank_Under_Officer") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Under Officer (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Under Officer (Australië (land))</para><para>Under Officer (Australien)</para><para>Under Officer (Australien)</para><para>Under Officer (Australia)</para><para>Under Officer (Australia)</para><para>Under Officer (Austrália)</para><para>Under Officer (Australia)</para><para>Under Officer (Australia)</para><para>Under Officer (Australia)</para><para>Under Officer (Australia)</para><para>Under Officer (Australie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Australia</seealso>
    let Rank_Under_Officer_Australia =
        Prefixed_Name(mil, "Rank_Under_Officer_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Under Officer (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_England">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_England</seealso>
    let Rank_Under_Officer_England =
        Prefixed_Name(mil, "Rank_Under_Officer_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Under Officer (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Under Officer (Schottland)</para><para>Under Officer (Skotlanti)</para><para>Under Officer (Skottland)</para><para>Under Officer (Skottland)</para><para>Under Officer (Schotland)</para><para>Under Officer (Scotland)</para><para>Under Officer (Escocia)</para><para>Under Officer (Szkocja)</para><para>Under Officer (Escócia)</para><para>Under Officer (Scozia)</para><para>Under Officer (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Scotland</seealso>
    let Rank_Under_Officer_Scotland =
        Prefixed_Name(mil, "Rank_Under_Officer_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Under Officer (Pays de Galles)</para><para>Under Officer (País de Gales)</para><para>Under Officer (Ð£ÑÐ»ÑÑ)</para><para>Under Officer (Galles)</para><para>Under Officer (Walia)</para><para>Under Officer (Wales)</para><para>Under Officer (Wales)</para><para>Under Officer (Wales)</para><para>Under Officer (Wales)</para><para>Under Officer (Wales)</para><para>Under Officer (Wales)</para><para>Under Officer (Gales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Wales</seealso>
    let Rank_Under_Officer_Wales =
        Prefixed_Name(mil, "Rank_Under_Officer_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankAirMechanic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air Mechanic (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanic">http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanic</seealso>
    let _1AIFRankAirMechanic = Prefixed_Name(mil, "1AIFRankAirMechanic") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankAirMechanicClassI</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air Mechanic Class I (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassI">http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassI</seealso>
    let _1AIFRankAirMechanicClassI =
        Prefixed_Name(mil, "1AIFRankAirMechanicClassI") |> PrefixedName

    /// <summary>
    ///   <para>mil:DivisionNavalEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Division (Marine)</para><para>Division (Navy)</para><para>Division</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalEstablishment">http://rdf.muninn-project.org/ontologies/military#DivisionNavalEstablishment</seealso>
    let DivisionNavalEstablishment =
        Prefixed_Name(mil, "DivisionNavalEstablishment") |> PrefixedName

    /// <summary>
    ///   <para>mil:NavalSquadron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Eskadra (marynarka wojenna)</para><para>Geschwader (Marine)</para><para>Laivue (laivasto)</para><para>Squadron (naval)</para><para>Ð­ÑÐºÐ°Ð´ÑÐ°</para><para>Esquadra naval</para><para>Háº£i ÄoÃ n</para><para>Eskader</para><para>Eskader</para><para>Escadre</para><para>Eskadra</para><para>Eskadre</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalSquadron">http://rdf.muninn-project.org/ontologies/military#NavalSquadron</seealso>
    let NavalSquadron = Prefixed_Name(mil, "NavalSquadron") |> PrefixedName
    /// <summary>
    ///   <para>mil:DivisionNavalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Division de Navire (Marine)</para><para>Ship's Division (Navy)</para><para>Division</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalUnit">http://rdf.muninn-project.org/ontologies/military#DivisionNavalUnit</seealso>
    let DivisionNavalUnit = Prefixed_Name(mil, "DivisionNavalUnit") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankNursingSisterArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Non-Combatant</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Nursing Sister (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankNursingSisterArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankNursingSisterArmyCanada</seealso>
    let RankNursingSisterArmyCanada =
        Prefixed_Name(mil, "RankNursingSisterArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankPrivateArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Private (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankPrivateArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankPrivateArmyCanada</seealso>
    let RankPrivateArmyCanada =
        Prefixed_Name(mil, "RankPrivateArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankQuartermasterSergeantMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///
    /// labels<para>Quartermaster Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantMajorArmyCanada</seealso>
    let RankQuartermasterSergeantMajorArmyCanada =
        Prefixed_Name(mil, "RankQuartermasterSergeantMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankRiflemanArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///
    /// labels<para>Rifleman (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankRiflemanArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankRiflemanArmyCanada</seealso>
    let RankRiflemanArmyCanada =
        Prefixed_Name(mil, "RankRiflemanArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comdiv_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð´Ð¸Ð² (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Komdiw (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Comdiv (Union des républiques socialistes soviétiques)</para><para>Divisioonankomentaja (Neuvostoliitto)</para><para>Comdiv (Unione Sovietica)</para><para>Comdiv (União Soviética)</para><para>Komdiv (Unión Soviética)</para><para>Komdiv (Sovjetunionen)</para><para>Comdiv (Sovjetunionen)</para><para>Comdiv (Soviet Union)</para><para>Comdiv (Sovjet-Unie)</para><para>Komdiv (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Soviet_Union</seealso>
    let Rank_Comdiv_Soviet_Union =
        Prefixed_Name(mil, "Rank_Comdiv_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lieutenant_commander_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lieutenant commander</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_commander_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_commander_EnglishTradition</seealso>
    let Rank_Lieutenant_commander_EnglishTradition =
        Prefixed_Name(mil, "Rank_Lieutenant_commander_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Squadron_leader_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Squadron leader</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Squadron_leader_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Squadron_leader_EnglishTradition</seealso>
    let Rank_Squadron_leader_EnglishTradition =
        Prefixed_Name(mil, "Rank_Squadron_leader_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wing_commander_(rank)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_(rank)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_(rank)_EnglishTradition</seealso>
    let ``Rank_Wing_commander_(rank)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Wing_commander_(rank)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commandeur_France</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Commandeur (marine, France)</para><para>Commandeur (France)</para><para>Commandeur (France)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_France">http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_France</seealso>
    let Rank_Commandeur_France =
        Prefixed_Name(mil, "Rank_Commandeur_France") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commandeur_Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Commandeur (ÐÐ¸Ð´ÐµÑÐ»Ð°Ð½Ð´Ñ)</para><para>Commandeur (marine) (Nederland)</para><para>Commandeur (Nederländerna)</para><para>Commandeur (Países Baixos)</para><para>Commandeur (Países Bajos)</para><para>Commandeur (Paesi Bassi)</para><para>Commandeur (Niederlande)</para><para>Commandeur (Netherlands)</para><para>Commandeur (Alankomaat)</para><para>Commandeur (Nederland)</para><para>Commandeur (Pays-Bas)</para><para>Commandeur (Holandia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_Netherlands">http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_Netherlands</seealso>
    let Rank_Commandeur_Netherlands =
        Prefixed_Name(mil, "Rank_Commandeur_Netherlands") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_sergeant_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Flight sergeant (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Flight sergeant (Australië (land))</para><para>Flight sergeant (Australien)</para><para>Flight sergeant (Australien)</para><para>Flight sergeant (Austrália)</para><para>Flight sergeant (Australia)</para><para>Flight sergeant (Australia)</para><para>Flight sergeant (Australie)</para><para>Flight sergeant (Australia)</para><para>Flight sergeant (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Australia</seealso>
    let Rank_Flight_sergeant_Australia =
        Prefixed_Name(mil, "Rank_Flight_sergeant_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolagasi_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>KolaÄasÄ± (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>KolaÄasÄ± (Osmanien valtakunta)</para><para>KolaÄasÄ± (Imperium osmaÅskie)</para><para>KolaÄasÄ± (Osmanisches Reich)</para><para>KolaÄasÄ± (Det osmanske rike)</para><para>KolaÄasÄ± (ImpÃ©rio Otomano)</para><para>KolaÄasÄ± (Imperio otomano)</para><para>KolaÄasÄ± (Impero ottomano)</para><para>KolaÄasÄ± (Ottomaanse Rijk)</para><para>KolaÄasÄ± (Empire ottoman)</para><para>KolaÄasÄ± (Osmanska riket)</para><para>KolaÄasÄ± (Ottoman Empire)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Ottoman_Empire</seealso>
    let Rank_Kolagasi_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Kolagasi_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Oberst (ÐÐ°Ð½Ð¸Ñ)</para><para>Oberst (Denemarken)</para><para>Oberst (Dinamarca)</para><para>Oberst (Dinamarca)</para><para>Oberst (Danimarca)</para><para>Oberst (Dänemark)</para><para>Oberst (Danemark)</para><para>Oberst (Denmark)</para><para>Oberst (Danmark)</para><para>Oberst (Danmark)</para><para>Oberst (Tanska)</para><para>Oberst (Dania)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Denmark">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Denmark</seealso>
    let Rank_Oberst_Denmark = Prefixed_Name(mil, "Rank_Oberst_Denmark") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Starshina</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÐ°ÑÑÐ¸Ð½Ð°</para><para>Starshiná</para><para>Starshina</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina">http://rdf.muninn-project.org/ontologies/military#Rank_Starshina</seealso>
    let Rank_Starshina = Prefixed_Name(mil, "Rank_Starshina") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Starshina_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÐ°ÑÑÐ¸Ð½Ð° (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Starshina (Russland)</para><para>Starshina (Russland)</para><para>Starshina (Ryssland)</para><para>Starshina (Rusland)</para><para>Starshina (Rússia)</para><para>Starshina (Russia)</para><para>Starshina (Venäjä)</para><para>Starshina (Russie)</para><para>Starshina (Russia)</para><para>Starshiná (Rusia)</para><para>Starshina (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Russia</seealso>
    let Rank_Starshina_Russia =
        Prefixed_Name(mil, "Rank_Starshina_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice_admiral</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice admiral</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral">http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral</seealso>
    let Rank_Vice_admiral = Prefixed_Name(mil, "Rank_Vice_admiral") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice_admiral_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vice admiral (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Vice admiral (Australië (land))</para><para>Vice admiral (Australien)</para><para>Vice admiral (Australien)</para><para>Vice admiral (Australia)</para><para>Vice admiral (Australia)</para><para>Vice admiral (Australia)</para><para>Vice admiral (Australia)</para><para>Vice admiral (Australie)</para><para>Vice admiral (Austrália)</para><para>Vice admiral (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia</seealso>
    let Rank_Vice_admiral_Australia =
        Prefixed_Name(mil, "Rank_Vice_admiral_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>English Tradition</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#EnglishTradition">http://rdf.muninn-project.org/ontologies/military#EnglishTradition</seealso>
    let EnglishTradition = Prefixed_Name(mil, "EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigadier_general_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Brigadier general (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Brigadier general (Australië (land))</para><para>Brigadier general (Australien)</para><para>Brigadier general (Australien)</para><para>Brigadier general (Australia)</para><para>Brigadier general (Australie)</para><para>Brigadier general (Austrália)</para><para>Brigadier general (Australia)</para><para>Brigadier general (Australia)</para><para>Brigadier general (Australia)</para><para>Brigadier general (Australia)</para><para>Brigadier general (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Australia</seealso>
    let Rank_Brigadier_general_Australia =
        Prefixed_Name(mil, "Rank_Brigadier_general_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Mirliva_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Mirliva (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>Mirliva (Repubblica delle Sette Isole Unite)</para><para>Mirliva (Republiek van de Zeven Eilanden)</para><para>Mirliva (República de las Islas Jónicas)</para><para>Mirliva (République des Sept-Îles)</para><para>Mirliva (Republika Siedmiu Wysp)</para><para>Mirliva (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Septinsular_Republic</seealso>
    let Rank_Mirliva_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Mirliva_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Under_Officer_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Under Officer (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Under Officer (Commonwealth delle nazioni)</para><para>Under Officer (Mancomunidad de Naciones)</para><para>Under Officer (Commonwealth of Nations)</para><para>Under Officer (Commonwealth of Nations)</para><para>Under Officer (Commonwealth of Nations)</para><para>Under Officer (Samveldet av nasjoner)</para><para>Under Officer (Gemenebest van Naties)</para><para>Under Officer (Wspólnota Narodów)</para><para>Under Officer (Kansainyhteisö)</para><para>Under Officer (Commonwealth)</para><para>Under Officer (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Commonwealth_of_Nations</seealso>
    let Rank_Under_Officer_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Under_Officer_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:ProtoAirForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Proto Air Force</para><para>Proto_air_force</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ProtoAirForce">http://rdf.muninn-project.org/ontologies/military#ProtoAirForce</seealso>
    let ProtoAirForce = Prefixed_Name(mil, "ProtoAirForce") |> PrefixedName
    /// <summary>
    ///   <para>mil:regiment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#regiment">http://rdf.muninn-project.org/ontologies/military#regiment</seealso>
    let regiment = Prefixed_Name(mil, "regiment") |> PrefixedName
    /// <summary>
    ///   <para>mil:Detachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Détachement (Militare)</para><para>Detachment (military)</para><para>Detachement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Detachment">http://rdf.muninn-project.org/ontologies/military#Detachment</seealso>
    let Detachment = Prefixed_Name(mil, "Detachment") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Une Organisation Militare</para><para>A Military Organization</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryOrganization">http://rdf.muninn-project.org/ontologies/military#MilitaryOrganization</seealso>
    let MilitaryOrganization =
        Prefixed_Name(mil, "MilitaryOrganization") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLanceCorporalArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para> Lance Corporal (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLanceCorporalArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankLanceCorporalArmyCanada</seealso>
    let RankLanceCorporalArmyCanada =
        Prefixed_Name(mil, "RankLanceCorporalArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLieutenantColonelArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Lieutenant-Colonel (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada</seealso>
    let RankLieutenantColonelArmyCanada =
        Prefixed_Name(mil, "RankLieutenantColonelArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankMajorArmyCanada</seealso>
    let RankMajorArmyCanada = Prefixed_Name(mil, "RankMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankMasterGunnerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///
    /// labels<para>Master Gunner (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankMasterGunnerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankMasterGunnerArmyCanada</seealso>
    let RankMasterGunnerArmyCanada =
        Prefixed_Name(mil, "RankMasterGunnerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankOrderlyRoomSergeantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Orderly Room Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankOrderlyRoomSergeantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankOrderlyRoomSergeantArmyCanada</seealso>
    let RankOrderlyRoomSergeantArmyCanada =
        Prefixed_Name(mil, "RankOrderlyRoomSergeantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankPioneerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Pioneer (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankPioneerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankPioneerArmyCanada</seealso>
    let RankPioneerArmyCanada =
        Prefixed_Name(mil, "RankPioneerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankQuartermasterSergeantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Quartermaster Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantArmyCanada</seealso>
    let RankQuartermasterSergeantArmyCanada =
        Prefixed_Name(mil, "RankQuartermasterSergeantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankRegimentalSergeantMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Regimental Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankRegimentalSergeantMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankRegimentalSergeantMajorArmyCanada</seealso>
    let RankRegimentalSergeantMajorArmyCanada =
        Prefixed_Name(mil, "RankRegimentalSergeantMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSaddlerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///
    /// labels<para>Saddler (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSaddlerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSaddlerArmyCanada</seealso>
    let RankSaddlerArmyCanada =
        Prefixed_Name(mil, "RankSaddlerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSapperArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Sapper (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSapperArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSapperArmyCanada</seealso>
    let RankSapperArmyCanada =
        Prefixed_Name(mil, "RankSapperArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSecondCorporalArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Second Corporal (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSecondCorporalArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSecondCorporalArmyCanada</seealso>
    let RankSecondCorporalArmyCanada =
        Prefixed_Name(mil, "RankSecondCorporalArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSecondLieutenantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Second Lieutenant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSecondLieutenantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSecondLieutenantArmyCanada</seealso>
    let RankSecondLieutenantArmyCanada =
        Prefixed_Name(mil, "RankSecondLieutenantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flying_officer_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Flying officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flying_officer_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Flying_officer_EnglishTradition</seealso>
    let Rank_Flying_officer_EnglishTradition =
        Prefixed_Name(mil, "Rank_Flying_officer_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Flight sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant</seealso>
    let Rank_Flight_sergeant =
        Prefixed_Name(mil, "Rank_Flight_sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Navarch_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð²Ð°ÑÑ (ÐÑÐµÑÐ¸Ñ)</para><para>Nauarch (Griechenland)</para><para>Navarch (Griekenland)</para><para>Navarch (Grekland)</para><para>Navarch (Kreikka)</para><para>Navarch (Grecia)</para><para>Nauarch (Grecja)</para><para>Navarch (Hellas)</para><para>Navarch (Grécia)</para><para>Navarco (Grecia)</para><para>Navarch (Greece)</para><para>Navarque (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Greece</seealso>
    let Rank_Navarch_Greece = Prefixed_Name(mil, "Rank_Navarch_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Praporshchik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Praporshchik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Praporshchik (Union des républiques socialistes soviétiques)</para><para>Praporshchik (Unione Sovietica)</para><para>Praporshchik (União Soviética)</para><para>Praporshchik (Unión Soviética)</para><para>Praporshchik (Neuvostoliitto)</para><para>Praporshchik (Sovjetunionen)</para><para>Praporshchik (Sovjetunionen)</para><para>Praporshchik (Soviet Union)</para><para>Praporshchik (Sowjetunion)</para><para>Praporshchik (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Soviet_Union</seealso>
    let Rank_Praporshchik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Praporshchik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Corporal_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Corporal (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Staff Corporal (Schottland)</para><para>Staff Corporal (Skotlanti)</para><para>Staff Corporal (Skottland)</para><para>Staff Corporal (Schotland)</para><para>Staff Corporal (Skottland)</para><para>Staff Corporal (Scotland)</para><para>Staff Corporal (Escocia)</para><para>Staff Corporal (Szkocja)</para><para>Staff Corporal (Escócia)</para><para>Staff Corporal (Scozia)</para><para>Staff Corporal (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Scotland</seealso>
    let Rank_Staff_Corporal_Scotland =
        Prefixed_Name(mil, "Rank_Staff_Corporal_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vaapeli_Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>VÃ¤Ã¤peli (Ð¨Ð²ÐµÑÐ¸Ñ)</para><para>Vääpeli (Schweden)</para><para>Vääpeli (Sverige)</para><para>Vääpeli (Sverige)</para><para>Vääpeli (Szwecja)</para><para>Vääpeli (Ruotsi)</para><para>Vääpeli (Suecia)</para><para>Vääpeli (Sweden)</para><para>Vääpeli (Svezia)</para><para>Vääpeli (Zweden)</para><para>Vääpeli (Suécia)</para><para>Vääpeli (Suède)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Sweden">http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Sweden</seealso>
    let Rank_Vaapeli_Sweden = Prefixed_Name(mil, "Rank_Vaapeli_Sweden") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankCorporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Corporal (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCorporal">http://rdf.muninn-project.org/ontologies/military#1AIFRankCorporal</seealso>
    let _1AIFRankCorporal = Prefixed_Name(mil, "1AIFRankCorporal") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Driver (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankDriver">http://rdf.muninn-project.org/ontologies/military#RankDriver</seealso>
    let RankDriver = Prefixed_Name(mil, "RankDriver") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankEngineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Engineer (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankEngineer">http://rdf.muninn-project.org/ontologies/military#1AIFRankEngineer</seealso>
    let _1AIFRankEngineer = Prefixed_Name(mil, "1AIFRankEngineer") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankLanceCorporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///
    /// labels<para>Lance Corporal (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceCorporal">http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceCorporal</seealso>
    let _1AIFRankLanceCorporal =
        Prefixed_Name(mil, "1AIFRankLanceCorporal") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankLeadingStoker</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Leading Stoker (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLeadingStoker">http://rdf.muninn-project.org/ontologies/military#1AIFRankLeadingStoker</seealso>
    let _1AIFRankLeadingStoker =
        Prefixed_Name(mil, "1AIFRankLeadingStoker") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLeadingStoker</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Leading Stoker</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLeadingStoker">http://rdf.muninn-project.org/ontologies/military#RankLeadingStoker</seealso>
    let RankLeadingStoker = Prefixed_Name(mil, "RankLeadingStoker") |> PrefixedName
    /// <summary>
    ///   <para>mil:Warship</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Navire Militare</para><para>Warship</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Warship">http://rdf.muninn-project.org/ontologies/military#Warship</seealso>
    let Warship = Prefixed_Name(mil, "Warship") |> PrefixedName
    /// <summary>
    ///   <para>mil:FrontLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frente (término militar)</para><para>VÃ¡leÄnÃ¡ fronta</para><para>Frente de batalha</para><para>Front (military)</para><para>Fronte (guerra)</para><para>Front militaire</para><para>Front (militar)</para><para>Front (oorlog)</para><para>Kriegsfront</para><para>Frontlinje</para><para>Kampfront</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FrontLine">http://rdf.muninn-project.org/ontologies/military#FrontLine</seealso>
    let FrontLine = Prefixed_Name(mil, "FrontLine") |> PrefixedName
    /// <summary>
    ///   <para>mil:Garrison</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Garnison (Militaire)</para><para>Garrison (military)</para><para>Garnison (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Garrison">http://rdf.muninn-project.org/ontologies/military#Garrison</seealso>
    let Garrison = Prefixed_Name(mil, "Garrison") |> PrefixedName
    /// <summary>
    ///   <para>mil:GrandeBatterie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Grande Batterie</para><para>Grand-Batterie</para><para>Grand Battery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#GrandeBatterie">http://rdf.muninn-project.org/ontologies/military#GrandeBatterie</seealso>
    let GrandeBatterie = Prefixed_Name(mil, "GrandeBatterie") |> PrefixedName
    /// <summary>
    ///   <para>mil:HouseholdCavalry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Household Cavalry</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#HouseholdCavalry">http://rdf.muninn-project.org/ontologies/military#HouseholdCavalry</seealso>
    let HouseholdCavalry = Prefixed_Name(mil, "HouseholdCavalry") |> PrefixedName
    /// <summary>
    ///   <para>mil:LiaisonOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verbindungsoffizier</para><para>Officier de Liason</para><para>Liaison Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#LiaisonOfficer">http://rdf.muninn-project.org/ontologies/military#LiaisonOfficer</seealso>
    let LiaisonOfficer = Prefixed_Name(mil, "LiaisonOfficer") |> PrefixedName
    /// <summary>
    ///   <para>mil:LightInfantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Infantry</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#LightInfantry">http://rdf.muninn-project.org/ontologies/military#LightInfantry</seealso>
    let LightInfantry = Prefixed_Name(mil, "LightInfantry") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Admiral_of_the_Fleet_Russia_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Admiral of the Fleet (Russia) (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Admiral of the Fleet (Russia) (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Admiral of the Fleet (Russia) (Union des républiques socialistes soviétiques)</para><para>Ammiraglio della flotta (Russia) (Unione Sovietica)</para><para>Admiral of the Fleet (Russia) (Unión Soviética)</para><para>Admiral of the Fleet (Russia) (União Soviética)</para><para>Admiral of the Fleet (Russia) (Neuvostoliitto)</para><para>Admiral of the Fleet (Russia) (Sovjetunionen)</para><para>Admiral of the Fleet (Russia) (Sovjetunionen)</para><para>Admiral of the Fleet (Russia) (Soviet Union)</para><para>Admiral of the Fleet (Russia) (Sovjet-Unie)</para><para>Admiral of the Fleet (Russia) (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Soviet_Union</seealso>
    let Rank_Admiral_of_the_Fleet_Russia_Soviet_Union =
        Prefixed_Name(mil, "Rank_Admiral_of_the_Fleet_Russia_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Lieutenant_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½-Ð»ÐµÐ¹ÑÐµÐ½Ð°Ð½Ñ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Capitaine-lieutenant (Russie)</para><para>Captain Lieutenant (Rusland)</para><para>Captain Lieutenant (Rússia)</para><para>Kapteeniluutnantti (Venäjä)</para><para>Captain Lieutenant (Russia)</para><para>Captain Lieutenant (Russia)</para><para>Kapteinløytnant (Russland)</para><para>Kapitänleutnant (Russland)</para><para>Captain Lieutenant (Rusia)</para><para>Captain Lieutenant (Rosja)</para><para>Kaptenlöjtnant (Ryssland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Russia</seealso>
    let Rank_Captain_Lieutenant_Russia =
        Prefixed_Name(mil, "Rank_Captain_Lieutenant_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Lieutenant_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½-Ð»ÐµÐ¹ÑÐµÐ½Ð°Ð½Ñ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Capitaine-lieutenant (Union des républiques socialistes soviétiques)</para><para>Captain Lieutenant (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Captain Lieutenant (Unione Sovietica)</para><para>Captain Lieutenant (União Soviética)</para><para>Captain Lieutenant (Unión Soviética)</para><para>Kapteeniluutnantti (Neuvostoliitto)</para><para>Captain Lieutenant (Soviet Union)</para><para>Captain Lieutenant (Sovjet-Unie)</para><para>Kapteinløytnant (Sovjetunionen)</para><para>Kaptenlöjtnant (Sovjetunionen)</para><para>Kapitänleutnant (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Soviet_Union</seealso>
    let Rank_Captain_Lieutenant_Soviet_Union =
        Prefixed_Name(mil, "Rank_Captain_Lieutenant_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Capitão (militar) (República da Irlanda)</para><para>Captain (OF-2) (Republic of Ireland)</para><para>Kapteeni (sotilasarvo) (Irlanti)</para><para>Kapitein (rang) (Ierland (land))</para><para>Hauptmann (Offizier) (Irland)</para><para>Kapitan (ranga) (Irlandia)</para><para>Capitaine (Irlande (pays))</para><para>Kaptein (grad) (Irland)</para><para>Capitano (Irlanda)</para><para>Capitán (Irlanda)</para><para>Kapten (Irland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Republic_of_Ireland</seealso>
    let Rank_Captain_Republic_of_Ireland =
        Prefixed_Name(mil, "Rank_Captain_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Hauptmann (Offizier) (Russland)</para><para>Kapteeni (sotilasarvo) (Venäjä)</para><para>Capitão (militar) (Rússia)</para><para>Kaptein (grad) (Russland)</para><para>Kapitein (rang) (Rusland)</para><para>Kapitan (ranga) (Rosja)</para><para>Captain (OF-2) (Russia)</para><para>Capitaine (Russie)</para><para>Capitano (Russia)</para><para>Kapten (Ryssland)</para><para>Capitán (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Russia</seealso>
    let Rank_Captain_Russia = Prefixed_Name(mil, "Rank_Captain_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Kapteeni (sotilasarvo) (Singapore)</para><para>Hauptmann (Offizier) (Singapur)</para><para>Capitão (militar) (Singapura)</para><para>Kapitein (rang) (Singapore)</para><para>Kapitan (ranga) (Singapur)</para><para>Captain (OF-2) (Singapore)</para><para>Kaptein (grad) (Singapore)</para><para>Capitaine (Singapour)</para><para>Capitano (Singapore)</para><para>Capitán (Singapur)</para><para>Kapten (Singapore)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Singapore</seealso>
    let Rank_Captain_Singapore =
        Prefixed_Name(mil, "Rank_Captain_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Kapitan (ranga) (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Capitaine (Union des républiques socialistes soviétiques)</para><para>Kapteeni (sotilasarvo) (Neuvostoliitto)</para><para>Capitão (militar) (União Soviética)</para><para>Hauptmann (Offizier) (Sowjetunion)</para><para>Kaptein (grad) (Sovjetunionen)</para><para>Kapitein (rang) (Sovjet-Unie)</para><para>Captain (OF-2) (Soviet Union)</para><para>Capitano (Unione Sovietica)</para><para>Capitán (Unión Soviética)</para><para>Kapten (Sovjetunionen)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Soviet_Union</seealso>
    let Rank_Captain_Soviet_Union =
        Prefixed_Name(mil, "Rank_Captain_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (Ð¨Ð²ÐµÑÐ¸Ñ)</para><para>Kapteeni (sotilasarvo) (Ruotsi)</para><para>Hauptmann (Offizier) (Schweden)</para><para>Capitão (militar) (Suécia)</para><para>Kapitan (ranga) (Szwecja)</para><para>Kaptein (grad) (Sverige)</para><para>Kapitein (rang) (Zweden)</para><para>Captain (OF-2) (Sweden)</para><para>Capitaine (Suède)</para><para>Capitano (Svezia)</para><para>Capitán (Suecia)</para><para>Kapten (Sverige)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Sweden">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Sweden</seealso>
    let Rank_Captain_Sweden = Prefixed_Name(mil, "Rank_Captain_Sweden") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Conductor_army</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Conductor (Army)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army">http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army</seealso>
    let Rank_Conductor_army = Prefixed_Name(mil, "Rank_Conductor_army") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Conductor_army_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Conductor (Army) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Conductor (Army) (Australië (land))</para><para>Conductor (Army) (Australien)</para><para>Conductor (Army) (Australien)</para><para>Conductor (Army) (Australie)</para><para>Conductor (Army) (Australia)</para><para>Conductor (Army) (Australia)</para><para>Conductor (Army) (Australia)</para><para>Conductor (Army) (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Australia</seealso>
    let Rank_Conductor_army_Australia =
        Prefixed_Name(mil, "Rank_Conductor_army_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Conductor_army_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Conductor (Army) (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_England">http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_England</seealso>
    let Rank_Conductor_army_England =
        Prefixed_Name(mil, "Rank_Conductor_army_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Conductor_army_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Conductor (Army) (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Conductor (Army) (Schottland)</para><para>Conductor (Army) (Skottland)</para><para>Conductor (Army) (Skotlanti)</para><para>Conductor (Army) (Skottland)</para><para>Conductor (Army) (Schotland)</para><para>Conductor (Army) (Scotland)</para><para>Conductor (Army) (Szkocja)</para><para>Conductor (Army) (Escocia)</para><para>Conductor (Army) (Escócia)</para><para>Conductor (Army) (Écosse)</para><para>Conductor (Army) (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Scotland</seealso>
    let Rank_Conductor_army_Scotland =
        Prefixed_Name(mil, "Rank_Conductor_army_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Conductor_army_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Conductor (Army) (Pays de Galles)</para><para>Conductor (Army) (País de Gales)</para><para>Conductor (Army) (Ð£ÑÐ»ÑÑ)</para><para>Conductor (Army) (Galles)</para><para>Conductor (Army) (Wales)</para><para>Conductor (Army) (Wales)</para><para>Conductor (Army) (Wales)</para><para>Conductor (Army) (Wales)</para><para>Conductor (Army) (Walia)</para><para>Conductor (Army) (Gales)</para><para>Conductor (Army) (Wales)</para><para>Conductor (Army) (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Wales</seealso>
    let Rank_Conductor_army_Wales =
        Prefixed_Name(mil, "Rank_Conductor_army_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Leading_seaman_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Leading seaman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_seaman_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Leading_seaman_EnglishTradition</seealso>
    let Rank_Leading_seaman_EnglishTradition =
        Prefixed_Name(mil, "Rank_Leading_seaman_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Daejang</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Daejang</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang">http://rdf.muninn-project.org/ontologies/military#Rank_Daejang</seealso>
    let Rank_Daejang = Prefixed_Name(mil, "Rank_Daejang") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Daejang_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Daejang (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Daejang (Korean demokraattinen kansantasavalta)</para><para>Daejang (Korea PÃ³Ånocna)</para><para>Daejang (Corea del Norte)</para><para>Daejang (Coreia do Norte)</para><para>Daejang (Corea del Nord)</para><para>Daejang (Corée du Nord)</para><para>Daejang (North Korea)</para><para>Daejang (Noord-Korea)</para><para>Daejang (Nord-Korea)</para><para>Daejang (Nordkorea)</para><para>Daejang (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_North_Korea</seealso>
    let Rank_Daejang_North_Korea =
        Prefixed_Name(mil, "Rank_Daejang_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Daejang_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Daejang (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Daejang (Korea PoÅudniowa)</para><para>Daejang (Korean tasavalta)</para><para>Daejang (Coreia do Sul)</para><para>Daejang (Corea del Sur)</para><para>Daejang (Corea del Sud)</para><para>Daejang (Corée du Sud)</para><para>Daejang (South Korea)</para><para>Daejang (Zuid-Korea)</para><para>Daejang (Sør-Korea)</para><para>Daejang (Sydkorea)</para><para>Daejang (Südkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_South_Korea</seealso>
    let Rank_Daejang_South_Korea =
        Prefixed_Name(mil, "Rank_Daejang_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Daffadar</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Daffadar</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar">http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar</seealso>
    let Rank_Daffadar = Prefixed_Name(mil, "Rank_Daffadar") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General_Admiral_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð´Ð¼Ð¸ÑÐ°Ð» (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>General Admiral (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>General Admiral (Union des républiques socialistes soviétiques)</para><para>Almirante General (Unión Soviética)</para><para>General Admiral (Unione Sovietica)</para><para>General Admiral (União Soviética)</para><para>Kenraaliamiraali (Neuvostoliitto)</para><para>Admiraal-generaal (Sovjet-Unie)</para><para>General Admiral (Sovjetunionen)</para><para>General Admiral (Sovjetunionen)</para><para>General Admiral (Soviet Union)</para><para>Generaladmiral (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Soviet_Union</seealso>
    let Rank_General_Admiral_Soviet_Union =
        Prefixed_Name(mil, "Rank_General_Admiral_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hasa</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Hasa (Korean military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa">http://rdf.muninn-project.org/ontologies/military#Rank_Hasa</seealso>
    let Rank_Hasa = Prefixed_Name(mil, "Rank_Hasa") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hasa_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Hasa (Korean military) (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Hasa (Korean military) (Korean demokraattinen kansantasavalta)</para><para>Hasa (Korean military) (Korea PÃ³Ånocna)</para><para>Hasa (Korean military) (Coreia do Norte)</para><para>Hasa (Korean military) (Corea del Norte)</para><para>Hasa (Korean military) (Corea del Nord)</para><para>Hasa (Korean military) (Corée du Nord)</para><para>Hasa (Korean military) (Noord-Korea)</para><para>Hasa (Korean military) (North Korea)</para><para>Hasa (Korean military) (Nord-Korea)</para><para>Hasa (Korean military) (Nordkorea)</para><para>Hasa (Korean military) (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_North_Korea</seealso>
    let Rank_Hasa_North_Korea =
        Prefixed_Name(mil, "Rank_Hasa_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Sergeant (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Lance Sergeant (Commonwealth delle nazioni)</para><para>Lance Sergeant (Mancomunidad de Naciones)</para><para>Lance Sergeant (Commonwealth of Nations)</para><para>Lance Sergeant (Commonwealth of Nations)</para><para>Lance Sergeant (Commonwealth of Nations)</para><para>Lance Sergeant (Gemenebest van Naties)</para><para>Lance Sergeant (Samveldet av nasjoner)</para><para>Lance Sergeant (Wspólnota Narodów)</para><para>Lance Sergeant (Kansainyhteisö)</para><para>Lance Sergeant (Commonwealth)</para><para>Lance Sergeant (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Commonwealth_of_Nations</seealso>
    let Rank_Lance_sergeant_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Lance_sergeant_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Sergeant (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_England">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_England</seealso>
    let Rank_Lance_sergeant_England =
        Prefixed_Name(mil, "Rank_Lance_sergeant_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Sergeant (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Lance Sergeant (Schottland)</para><para>Lance Sergeant (Skotlanti)</para><para>Lance Sergeant (Skottland)</para><para>Lance Sergeant (Skottland)</para><para>Lance Sergeant (Schotland)</para><para>Lance Sergeant (Scotland)</para><para>Lance Sergeant (Escocia)</para><para>Lance Sergeant (Escócia)</para><para>Lance Sergeant (Szkocja)</para><para>Lance Sergeant (Écosse)</para><para>Lance Sergeant (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Scotland</seealso>
    let Rank_Lance_sergeant_Scotland =
        Prefixed_Name(mil, "Rank_Lance_sergeant_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Leading_aircraftman</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Leading aircraftman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman">http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman</seealso>
    let Rank_Leading_aircraftman =
        Prefixed_Name(mil, "Rank_Leading_aircraftman") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Leading_aircraftman_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Leading aircraftman (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Leading aircraftman (Australië (land))</para><para>Leading aircraftman (Australien)</para><para>Leading aircraftman (Australia)</para><para>Leading aircraftman (Australia)</para><para>Leading aircraftman (Austrália)</para><para>Leading aircraftman (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Australia</seealso>
    let Rank_Leading_aircraftman_Australia =
        Prefixed_Name(mil, "Rank_Leading_aircraftman_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Leading_aircraftman_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Leading aircraftman (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Canada</seealso>
    let Rank_Leading_aircraftman_Canada =
        Prefixed_Name(mil, "Rank_Leading_aircraftman_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Leading_aircraftman_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Leading aircraftman (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Leading aircraftman (Commonwealth delle nazioni)</para><para>Leading aircraftman (Mancomunidad de Naciones)</para><para>Leading aircraftman (Commonwealth of Nations)</para><para>Leading aircraftman (Commonwealth of Nations)</para><para>Leading aircraftman (Commonwealth of Nations)</para><para>Leading aircraftman (Samveldet av nasjoner)</para><para>Leading aircraftman (Gemenebest van Naties)</para><para>Leading aircraftman (Wspólnota Narodów)</para><para>Leading aircraftman (Kansainyhteisö)</para><para>Leading aircraftman (Commonwealth)</para><para>Leading aircraftman (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Commonwealth_of_Nations</seealso>
    let Rank_Leading_aircraftman_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Leading_aircraftman_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pipe_Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Pipe Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major">http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major</seealso>
    let Rank_Pipe_Major = Prefixed_Name(mil, "Rank_Pipe_Major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pipe_Major_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Pipe Major (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Pipe Major (Commonwealth delle nazioni)</para><para>Pipe Major (Mancomunidad de Naciones)</para><para>Pipe Major (Commonwealth of Nations)</para><para>Pipe Major (Commonwealth of Nations)</para><para>Pipe Major (Commonwealth of Nations)</para><para>Pipe Major (Gemenebest van Naties)</para><para>Pipe Major (Samveldet av nasjoner)</para><para>Pipe Major (Wspólnota Narodów)</para><para>Pipe Major (Kansainyhteisö)</para><para>Pipe Major (Commonwealth)</para><para>Pipe Major (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Commonwealth_of_Nations</seealso>
    let Rank_Pipe_Major_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Pipe_Major_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pipe_Major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Pipe Major (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_England</seealso>
    let Rank_Pipe_Major_England =
        Prefixed_Name(mil, "Rank_Pipe_Major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pipe_Major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Pipe Major (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Pipe Major (Schottland)</para><para>Pipe Major (Skottland)</para><para>Pipe Major (Skotlanti)</para><para>Pipe Major (Schotland)</para><para>Pipe Major (Skottland)</para><para>Pipe Major (Scotland)</para><para>Pipe Major (Szkocja)</para><para>Pipe Major (Escocia)</para><para>Pipe Major (Escócia)</para><para>Pipe Major (Scozia)</para><para>Pipe Major (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Scotland</seealso>
    let Rank_Pipe_Major_Scotland =
        Prefixed_Name(mil, "Rank_Pipe_Major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpolkovnik</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>PodpuÅkownik</para><para>Podpolkovnik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik">http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik</seealso>
    let Rank_Podpolkovnik = Prefixed_Name(mil, "Rank_Podpolkovnik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpolkovnik_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>PodpuÅkownik (Poland)</para><para>Podpolkovnik (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Poland</seealso>
    let Rank_Podpolkovnik_Poland =
        Prefixed_Name(mil, "Rank_Podpolkovnik_Poland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpolkovnik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Podpolkovnik (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Podpolkovnik (Russland)</para><para>Podpolkovnik (Russland)</para><para>Podpolkovnik (Ryssland)</para><para>Podpolkovnik (Rusland)</para><para>PodpuÅkownik (Rosja)</para><para>Podpolkovnik (Russia)</para><para>Podpolkovnik (Rússia)</para><para>Podpolkovnik (Russia)</para><para>Podpolkovnik (Russie)</para><para>Podpolkovnik (Venäjä)</para><para>Podpolkovnik (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Russia</seealso>
    let Rank_Podpolkovnik_Russia =
        Prefixed_Name(mil, "Rank_Podpolkovnik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Major_Instructor_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sergeant Major Instructor (Pays de Galles)</para><para>Sergeant Major Instructor (País de Gales)</para><para>Sergeant Major Instructor (Ð£ÑÐ»ÑÑ)</para><para>Sergeant Major Instructor (Galles)</para><para>Sergeant Major Instructor (Wales)</para><para>Sergeant Major Instructor (Wales)</para><para>Sergeant Major Instructor (Wales)</para><para>Sergeant Major Instructor (Gales)</para><para>Sergeant Major Instructor (Walia)</para><para>Sergeant Major Instructor (Wales)</para><para>Sergeant Major Instructor (Wales)</para><para>Sergeant Major Instructor (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Wales</seealso>
    let Rank_Sergeant_Major_Instructor_Wales =
        Prefixed_Name(mil, "Rank_Sergeant_Major_Instructor_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sergeant Pilot</para><para>Fältflygare</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot</seealso>
    let Rank_Sergeant_Pilot = Prefixed_Name(mil, "Rank_Sergeant_Pilot") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sergeant Pilot (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Sergeant Pilot (Australië (land))</para><para>Sergeant Pilot (Australien)</para><para>Sergeant Pilot (Australia)</para><para>Sergeant Pilot (Australia)</para><para>Sergeant Pilot (Australia)</para><para>Sergeant Pilot (Austrália)</para><para>Sergeant Pilot (Australia)</para><para>Sergeant Pilot (Australie)</para><para>Sergeant Pilot (Australia)</para><para>Sergeant Pilot (Australia)</para><para>Fältflygare (Australien)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Australia</seealso>
    let Rank_Sergeant_Pilot_Australia =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Taxiarch (Det akhaiske forbund)</para><para>Taxiarch (Achaiska förbundet)</para><para>Taxiarch (ZwiÄzek Achajski)</para><para>Taxiarch (Achaiischer Bund)</para><para>Taxiarch (Achaeïsche Bond)</para><para>Taxiarch (Akhaian liitto)</para><para>Taxiarch (Achaean League)</para><para>Taxiarch (Ligue achéenne)</para><para>Taxiarch (Liga Aqueia)</para><para>Taxiarch (Liga Aquea)</para><para>Taxiarch (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Achaean_League</seealso>
    let Rank_Taxiarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Taxiarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch_Byzantine_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ (ÐÐ¸Ð·Ð°Ð½ÑÐ¸Ð¹ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Taxiarch (Cesarstwo BizantyÅskie)</para><para>Taxiarch (Byzantinisches Reich)</para><para>Taxiarch (Bysantin valtakunta)</para><para>Taxiarch (Império Bizantino)</para><para>Taxiarch (Imperio bizantino)</para><para>Taxiarch (Bysantinska riket)</para><para>Taxiarch (Impero bizantino)</para><para>Taxiarch (Byzantijnse Rijk)</para><para>Taxiarch (Byzantine Empire)</para><para>Taxiarch (Empire byzantin)</para><para>Taxiarch (Østromerriket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Byzantine_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Byzantine_Empire</seealso>
    let Rank_Taxiarch_Byzantine_Empire =
        Prefixed_Name(mil, "Rank_Taxiarch_Byzantine_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ (ÐÑÐµÑÐ¸Ñ)</para><para>Taxiarch (Griechenland)</para><para>Taxiarch (Griekenland)</para><para>Taxiarch (Grekland)</para><para>Taxiarch (Kreikka)</para><para>Taxiarch (Grécia)</para><para>Taxiarch (Grecja)</para><para>Taxiarch (Grecia)</para><para>Taxiarch (Grecia)</para><para>Taxiarch (Hellas)</para><para>Taxiarch (Greece)</para><para>Taxiarch (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Greece</seealso>
    let Rank_Taxiarch_Greece =
        Prefixed_Name(mil, "Rank_Taxiarch_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Spy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Espion</para><para>Spion</para><para>Spy</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Spy">http://rdf.muninn-project.org/ontologies/military#Spy</seealso>
    let Spy = Prefixed_Name(mil, "Spy") |> PrefixedName
    /// <summary>
    ///   <para>mil:SupplyTrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Train D'alimentation (Military)</para><para>liefern dem Zug (Militär)</para><para>Supply Train (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#SupplyTrain">http://rdf.muninn-project.org/ontologies/military#SupplyTrain</seealso>
    let SupplyTrain = Prefixed_Name(mil, "SupplyTrain") |> PrefixedName
    /// <summary>
    ///   <para>mil:Trade</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Occupation Professionelle (Civil)</para><para>Trade (Civil)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Trade">http://rdf.muninn-project.org/ontologies/military#Trade</seealso>
    let Trade = Prefixed_Name(mil, "Trade") |> PrefixedName
    /// <summary>
    ///   <para>mil:TrenchObstacle</para>
    /// </summary>
    /// <remarks>
    ///   <para>geovocab:spatial#Feature</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Trench Obstacle</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#TrenchObstacle">http://rdf.muninn-project.org/ontologies/military#TrenchObstacle</seealso>
    let TrenchObstacle = Prefixed_Name(mil, "TrenchObstacle") |> PrefixedName
    /// <summary>
    ///   <para>mil:VolunteerSoldier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Soldat (freiwilliger)</para><para>Soldier (Volunteer)</para><para>Soldat (Volontaire)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#VolunteerSoldier">http://rdf.muninn-project.org/ontologies/military#VolunteerSoldier</seealso>
    let VolunteerSoldier = Prefixed_Name(mil, "VolunteerSoldier") |> PrefixedName
    /// <summary>
    ///   <para>mil:War</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#War">http://rdf.muninn-project.org/ontologies/military#War</seealso>
    let War = Prefixed_Name(mil, "War") |> PrefixedName
    /// <summary>
    ///   <para>mil:Weapon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Weapon (Military)</para><para>Waffe (Militär)</para><para>Arme (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Weapon">http://rdf.muninn-project.org/ontologies/military#Weapon</seealso>
    let Weapon = Prefixed_Name(mil, "Weapon") |> PrefixedName
    /// <summary>
    ///   <para>mil:allegiance</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Allegiance</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#allegiance">http://rdf.muninn-project.org/ontologies/military#allegiance</seealso>
    let allegiance = Prefixed_Name(mil, "allegiance") |> PrefixedName
    /// <summary>
    ///   <para>mil:commanderInChiefOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Commander In Chief of</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#commanderInChiefOf">http://rdf.muninn-project.org/ontologies/military#commanderInChiefOf</seealso>
    let commanderInChiefOf = Prefixed_Name(mil, "commanderInChiefOf") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankBombardier</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Bombardier (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankBombardier">http://rdf.muninn-project.org/ontologies/military#1AIFRankBombardier</seealso>
    let _1AIFRankBombardier = Prefixed_Name(mil, "1AIFRankBombardier") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankChaplain</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Chaplain (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankChaplain">http://rdf.muninn-project.org/ontologies/military#1AIFRankChaplain</seealso>
    let _1AIFRankChaplain = Prefixed_Name(mil, "1AIFRankChaplain") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankCompanyQuartermasterSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanyQuartermasterSergeant">http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanyQuartermasterSergeant</seealso>
    let _1AIFRankCompanyQuartermasterSergeant =
        Prefixed_Name(mil, "1AIFRankCompanyQuartermasterSergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCompanySergeantMajor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///
    /// labels<para>Company Sergeant Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajor">http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajor</seealso>
    let RankCompanySergeantMajor =
        Prefixed_Name(mil, "RankCompanySergeantMajor") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Driver (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankDriver">http://rdf.muninn-project.org/ontologies/military#1AIFRankDriver</seealso>
    let _1AIFRankDriver = Prefixed_Name(mil, "1AIFRankDriver") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankEngineer</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Engineer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankEngineer">http://rdf.muninn-project.org/ontologies/military#RankEngineer</seealso>
    let RankEngineer = Prefixed_Name(mil, "RankEngineer") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankGunner</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///
    /// labels<para>Gunner (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankGunner">http://rdf.muninn-project.org/ontologies/military#1AIFRankGunner</seealso>
    let _1AIFRankGunner = Prefixed_Name(mil, "1AIFRankGunner") |> PrefixedName
    /// <summary>
    ///   <para>mil:Artillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///
    /// labels<para>Artillery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Artillery">http://rdf.muninn-project.org/ontologies/military#Artillery</seealso>
    let Artillery = Prefixed_Name(mil, "Artillery") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankLanceSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Sergeant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceSergeant">http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceSergeant</seealso>
    let _1AIFRankLanceSergeant =
        Prefixed_Name(mil, "1AIFRankLanceSergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sergeant</para><para>Sergeant</para><para>Sergent</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_EnglishTradition</seealso>
    let Rank_Sergeant_EnglishTradition =
        Prefixed_Name(mil, "Rank_Sergeant_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankLieutenantColonel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Lieutenant Colonel (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenantColonel">http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenantColonel</seealso>
    let _1AIFRankLieutenantColonel =
        Prefixed_Name(mil, "1AIFRankLieutenantColonel") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLieutenantColonelArmy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmy">http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmy</seealso>
    let RankLieutenantColonelArmy =
        Prefixed_Name(mil, "RankLieutenantColonelArmy") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Major_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Major</para><para>Major</para><para>Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Major_EnglishTradition</seealso>
    let Rank_Major_EnglishTradition =
        Prefixed_Name(mil, "Rank_Major_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankNurse</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Nurse (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankNurse">http://rdf.muninn-project.org/ontologies/military#1AIFRankNurse</seealso>
    let _1AIFRankNurse = Prefixed_Name(mil, "1AIFRankNurse") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankTrooperArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Trooper (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankTrooperArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankTrooperArmyCanada</seealso>
    let RankTrooperArmyCanada =
        Prefixed_Name(mil, "RankTrooperArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Admiral_of_the_Fleet_Russia_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Admiral of the Fleet (Russia) (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Ammiraglio della flotta (Russia) (Russia)</para><para>Admiral of the Fleet (Russia) (Ryssland)</para><para>Admiral of the Fleet (Russia) (Russland)</para><para>Admiral of the Fleet (Russia) (Russland)</para><para>Admiral of the Fleet (Russia) (Rusland)</para><para>Admiral of the Fleet (Russia) (Venäjä)</para><para>Admiral of the Fleet (Russia) (Rússia)</para><para>Admiral of the Fleet (Russia) (Russie)</para><para>Admiral of the Fleet (Russia) (Russia)</para><para>Admiral of the Fleet (Russia) (Rusia)</para><para>Admiral of the Fleet (Russia) (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Russia</seealso>
    let Rank_Admiral_of_the_Fleet_Russia_Russia =
        Prefixed_Name(mil, "Rank_Admiral_of_the_Fleet_Russia_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commandant_(rank)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandant_(rank)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Commandant_(rank)_EnglishTradition</seealso>
    let ``Rank_Commandant_(rank)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Commandant_(rank)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Lieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½-Ð»ÐµÐ¹ÑÐµÐ½Ð°Ð½Ñ</para><para>Capitaine-lieutenant</para><para>Kapteeniluutnantti</para><para>Captain Lieutenant</para><para>Kapteinløytnant</para><para>Kapitänleutnant</para><para>Kaptenlöjtnant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant</seealso>
    let Rank_Captain_Lieutenant =
        Prefixed_Name(mil, "Rank_Captain_Lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Company Quartermaster Sergeant (Schottland)</para><para>Company Quartermaster Sergeant (Schotland)</para><para>Company Quartermaster Sergeant (Skotlanti)</para><para>Company Quartermaster Sergeant (Skottland)</para><para>Company Quartermaster Sergeant (Skottland)</para><para>Company Quartermaster Sergeant (Scotland)</para><para>Company Quartermaster Sergeant (Escócia)</para><para>Company Quartermaster Sergeant (Szkocja)</para><para>Company Quartermaster Sergeant (Escocia)</para><para>Company Quartermaster Sergeant (Scozia)</para><para>Company Quartermaster Sergeant (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Scotland</seealso>
    let Rank_Company_Quartermaster_Sergeant_Scotland =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (Pays de Galles)</para><para>Company Quartermaster Sergeant (País de Gales)</para><para>Company Quartermaster Sergeant (Ð£ÑÐ»ÑÑ)</para><para>Company Quartermaster Sergeant (Galles)</para><para>Company Quartermaster Sergeant (Wales)</para><para>Company Quartermaster Sergeant (Wales)</para><para>Company Quartermaster Sergeant (Gales)</para><para>Company Quartermaster Sergeant (Wales)</para><para>Company Quartermaster Sergeant (Wales)</para><para>Company Quartermaster Sergeant (Walia)</para><para>Company Quartermaster Sergeant (Wales)</para><para>Company Quartermaster Sergeant (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Wales</seealso>
    let Rank_Company_Quartermaster_Sergeant_Wales =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Company sergeant major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major</seealso>
    let Rank_Company_sergeant_major =
        Prefixed_Name(mil, "Rank_Company_sergeant_major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Company sergeant major (Australië (land))</para><para>Company sergeant major (Australien)</para><para>Company sergeant major (Australien)</para><para>Company sergeant major (Australie)</para><para>Company sergeant major (Australia)</para><para>Company sergeant major (Austrália)</para><para>Company sergeant major (Australia)</para><para>Company sergeant major (Australia)</para><para>Company sergeant major (Australia)</para><para>Company sergeant major (Australia)</para><para>Company sergeant major (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Australia</seealso>
    let Rank_Company_sergeant_major_Australia =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Company sergeant major (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Canada</seealso>
    let Rank_Company_sergeant_major_Canada =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Company sergeant major (Commonwealth delle nazioni)</para><para>Company sergeant major (Mancomunidad de Naciones)</para><para>Company sergeant major (Commonwealth of Nations)</para><para>Company sergeant major (Commonwealth of Nations)</para><para>Company sergeant major (Commonwealth of Nations)</para><para>Company sergeant major (Gemenebest van Naties)</para><para>Company sergeant major (Samveldet av nasjoner)</para><para>Company sergeant major (Wspólnota Narodów)</para><para>Company sergeant major (Kansainyhteisö)</para><para>Company sergeant major (Commonwealth)</para><para>Company sergeant major (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Commonwealth_of_Nations</seealso>
    let Rank_Company_sergeant_major_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Gefreiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÑÐµÐ¹ÑÐ¾Ñ</para><para>Gefreiter</para><para>Gefreiter</para><para>Gefreiter</para><para>Gefrajter</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter">http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter</seealso>
    let Rank_Gefreiter = Prefixed_Name(mil, "Rank_Gefreiter") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Gefreiter_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÑÐµÐ¹ÑÐ¾Ñ (Germany)</para><para>Gefreiter (Germany)</para><para>Gefreiter (Germany)</para><para>Gefreiter (Germany)</para><para>Gefrajter (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Germany</seealso>
    let Rank_Gefreiter_Germany =
        Prefixed_Name(mil, "Rank_Gefreiter_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Gefreiter_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÑÐµÐ¹ÑÐ¾Ñ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Gefreiter (Russland)</para><para>Gefreiter (Ryssland)</para><para>Gefreiter (Russland)</para><para>Gefreiter (Rusland)</para><para>Gefreiter (Russia)</para><para>Gefreiter (Venäjä)</para><para>Gefreiter (Russie)</para><para>Gefreiter (Russia)</para><para>Gefreiter (Rússia)</para><para>Gefreiter (Rusia)</para><para>Gefrajter (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Russia</seealso>
    let Rank_Gefreiter_Russia =
        Prefixed_Name(mil, "Rank_Gefreiter_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Gefreiter_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÑÐµÐ¹ÑÐ¾Ñ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Gefrajter (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Gefreiter (Union des républiques socialistes soviétiques)</para><para>Gefreiter (Unione Sovietica)</para><para>Gefreiter (Unión Soviética)</para><para>Gefreiter (União Soviética)</para><para>Gefreiter (Neuvostoliitto)</para><para>Gefreiter (Sovjetunionen)</para><para>Gefreiter (Sovjetunionen)</para><para>Gefreiter (Soviet Union)</para><para>Gefreiter (Sowjetunion)</para><para>Gefreiter (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Soviet_Union</seealso>
    let Rank_Gefreiter_Soviet_Union =
        Prefixed_Name(mil, "Rank_Gefreiter_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General-in-Chief</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð½ÑÐµÑ</para><para>General-in-Chief</para><para>General en chef</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief">http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief</seealso>
    let Rank_General_in_Chief =
        Prefixed_Name(mil, "Rank_General-in-Chief") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General-in-Chief_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð½ÑÐµÑ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>General-in-Chief (Russland)</para><para>General-in-Chief (Russland)</para><para>General-in-Chief (Rusland)</para><para>General en chef (Ryssland)</para><para>General-in-Chief (Russie)</para><para>General-in-Chief (Rússia)</para><para>General-in-Chief (Venäjä)</para><para>General-in-Chief (Russia)</para><para>General-in-Chief (Russia)</para><para>General-in-Chief (Rosja)</para><para>General-in-Chief (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Russia</seealso>
    let Rank_General_in_Chief_Russia =
        Prefixed_Name(mil, "Rank_General-in-Chief_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General-in-Chief_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð½ÑÐµÑ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>General-in-Chief (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>General-in-Chief (Union des républiques socialistes soviétiques)</para><para>General-in-Chief (Unione Sovietica)</para><para>General-in-Chief (Unión Soviética)</para><para>General-in-Chief (União Soviética)</para><para>General-in-Chief (Neuvostoliitto)</para><para>General-in-Chief (Sovjetunionen)</para><para>General-in-Chief (Soviet Union)</para><para>General en chef (Sovjetunionen)</para><para>General-in-Chief (Sowjetunion)</para><para>General-in-Chief (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Soviet_Union</seealso>
    let Rank_General_in_Chief_Soviet_Union =
        Prefixed_Name(mil, "Rank_General-in-Chief_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General_Admiral</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð´Ð¼Ð¸ÑÐ°Ð»</para><para>Almirante General</para><para>Admiraal-generaal</para><para>Kenraaliamiraali</para><para>General Admiral</para><para>Generaladmiral</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral">http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral</seealso>
    let Rank_General_Admiral =
        Prefixed_Name(mil, "Rank_General_Admiral") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General_Admiral_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð´Ð¼Ð¸ÑÐ°Ð» (Germany)</para><para>Admiraal-generaal (Germany)</para><para>Almirante General (Germany)</para><para>Kenraaliamiraali (Germany)</para><para>General Admiral (Germany)</para><para>Generaladmiral (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Germany</seealso>
    let Rank_General_Admiral_Germany =
        Prefixed_Name(mil, "Rank_General_Admiral_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_major_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_major_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_major_EnglishTradition</seealso>
    let Rank_Sergeant_major_EnglishTradition =
        Prefixed_Name(mil, "Rank_Sergeant_major_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ordinary_seaman_rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ordinary Seaman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating">http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating</seealso>
    let Rank_Ordinary_seaman_rating =
        Prefixed_Name(mil, "Rank_Ordinary_seaman_rating") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ordinary_seaman_rating_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ordinary Seaman (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Ordinary Seaman (Australië (land))</para><para>Ordinary Seaman (Australien)</para><para>Ordinary Seaman (Australien)</para><para>Ordinary Seaman (Austrália)</para><para>Ordinary Seaman (Australia)</para><para>Ordinary Seaman (Australie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Australia</seealso>
    let Rank_Ordinary_seaman_rating_Australia =
        Prefixed_Name(mil, "Rank_Ordinary_seaman_rating_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ordinary_seaman_rating_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ordinary Seaman (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Canada</seealso>
    let Rank_Ordinary_seaman_rating_Canada =
        Prefixed_Name(mil, "Rank_Ordinary_seaman_rating_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ordinary_seaman_rating_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ordinary Seaman (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Ordinary Seaman (Commonwealth delle nazioni)</para><para>Ordinary Seaman (Mancomunidad de Naciones)</para><para>Ordinary Seaman (Commonwealth of Nations)</para><para>Ordinary Seaman (Commonwealth of Nations)</para><para>Ordinary Seaman (Commonwealth of Nations)</para><para>Ordinary Seaman (Samveldet av nasjoner)</para><para>Ordinary Seaman (Gemenebest van Naties)</para><para>Ordinary Seaman (Wspólnota Narodów)</para><para>Ordinary Seaman (Kansainyhteisö)</para><para>Ordinary Seaman (Commonwealth)</para><para>Ordinary Seaman (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Commonwealth_of_Nations</seealso>
    let Rank_Ordinary_seaman_rating_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Ordinary_seaman_rating_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sangsa_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sangsa (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Sangsa (Korea PoÅudniowa)</para><para>Sangsa (Korean tasavalta)</para><para>Sangsa (Coreia do Sul)</para><para>Sangsa (Corea del Sur)</para><para>Sangsa (Corea del Sud)</para><para>Sangsa (Corée du Sud)</para><para>Sangsa (South Korea)</para><para>Sangsa (Zuid-Korea)</para><para>Sangsa (Sør-Korea)</para><para>Sangsa (Südkorea)</para><para>Sangsa (Sydkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_South_Korea</seealso>
    let Rank_Sangsa_South_Korea =
        Prefixed_Name(mil, "Rank_Sangsa_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Schout-bij-nacht</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¨Ð°ÑÑÐ±ÐµÐ½Ð°ÑÑ</para><para>Schout-bij-nacht</para><para>Schout-bij-nacht</para><para>Schout-bij-nacht</para><para>Schoutbynacht</para><para>Schoutbynacht</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht">http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht</seealso>
    let Rank_Schout_bij_nacht =
        Prefixed_Name(mil, "Rank_Schout-bij-nacht") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_autokrator_Byzantine_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Strategos autokrator (ÐÐ¸Ð·Ð°Ð½ÑÐ¸Ð¹ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Strategos autokrator (Cesarstwo BizantyÅskie)</para><para>Strategos autokrator (Byzantinisches Reich)</para><para>Strategos autokrator (Bysantin valtakunta)</para><para>Strategos autokrator (Bysantinska riket)</para><para>Strategos autokrator (Imperio bizantino)</para><para>Strategos autokrator (Império Bizantino)</para><para>Strategos autokrator (Impero bizantino)</para><para>Strategos autokrator (Byzantijnse Rijk)</para><para>Strategos autokrator (Byzantine Empire)</para><para>Strategos autokrator (Empire byzantin)</para><para>Strategos autokrator (Østromerriket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator_Byzantine_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator_Byzantine_Empire</seealso>
    let Rank_Strategos_autokrator_Byzantine_Empire =
        Prefixed_Name(mil, "Rank_Strategos_autokrator_Byzantine_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_autokrator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator</seealso>
    let Rank_Strategos_autokrator =
        Prefixed_Name(mil, "Rank_Strategos_autokrator") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Suba%C5%9Fi</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>SubaÅi</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Suba%C5%9Fi">http://rdf.muninn-project.org/ontologies/military#Rank_Suba%C5%9Fi</seealso>
    let ``Rank_Suba%C5%9Fi`` = Prefixed_Name(mil, "Rank_Suba%C5%9Fi") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Subaltern</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÐ±Ð°Ð»ÑÐµÑÐ½-Ð¾ÑÐ¸ÑÐµÑ</para><para>Subalternoffiser</para><para>Subalternofficer</para><para>Subaltern</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern">http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern</seealso>
    let Rank_Subaltern = Prefixed_Name(mil, "Rank_Subaltern") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subaltern_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÐ±Ð°Ð»ÑÐµÑÐ½-Ð¾ÑÐ¸ÑÐµÑ (England)</para><para>Subalternofficer (England)</para><para>Subalternoffiser (England)</para><para>Subaltern (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_England">http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_England</seealso>
    let Rank_Subaltern_England =
        Prefixed_Name(mil, "Rank_Subaltern_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankRegimentalQuartermasterSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalQuartermasterSergeant">http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalQuartermasterSergeant</seealso>
    let _1AIFRankRegimentalQuartermasterSergeant =
        Prefixed_Name(mil, "1AIFRankRegimentalQuartermasterSergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankRegimentalSergeantMajor</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental Sergeant Major (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalSergeantMajor">http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalSergeantMajor</seealso>
    let _1AIFRankRegimentalSergeantMajor =
        Prefixed_Name(mil, "1AIFRankRegimentalSergeantMajor") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankSapper</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sapper (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSapper">http://rdf.muninn-project.org/ontologies/military#1AIFRankSapper</seealso>
    let _1AIFRankSapper = Prefixed_Name(mil, "1AIFRankSapper") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankSapper</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sapper</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSapper">http://rdf.muninn-project.org/ontologies/military#RankSapper</seealso>
    let RankSapper = Prefixed_Name(mil, "RankSapper") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryTrench</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///   <para>geovocab:spatial#Feature</para>
    ///
    /// labels<para>Tranchée Militaire</para><para>Military Trench</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrench">http://rdf.muninn-project.org/ontologies/military#MilitaryTrench</seealso>
    let MilitaryTrench = Prefixed_Name(mil, "MilitaryTrench") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-10</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Officer Rank OF-10</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-10">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-10</seealso>
    let NatoRankOF_10 = Prefixed_Name(mil, "NatoRankOF-10") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Officer Rank OF-2</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-2">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-2</seealso>
    let NatoRankOF_2 = Prefixed_Name(mil, "NatoRankOF-2") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Agha_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ³Ð° (ÑÐ¸ÑÑÐ» Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸ÐºÐ¾Ð²) (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>Agha (Ottoman Empire) (Republiek van de Zeven Eilanden)</para><para>Agha (Ottoman Empire) (República de las Islas Jónicas)</para><para>Agha (Ottoman Empire) (Septinsular Republic)</para><para>Agha (Repubblica delle Sette Isole Unite)</para><para>Aga (wojsko) (Republika Siedmiu Wysp)</para><para>Agha (Titel) (Septinsular Republic)</para><para>Agha (République des Sept-Îles)</para><para>Agha (Septinsular Republic)</para><para>Agha (Septinsular Republic)</para><para>Agha (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Septinsular_Republic</seealso>
    let Rank_Agha_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Agha_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_England</seealso>
    let Rank_Company_sergeant_major_England =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Company sergeant major (Schottland)</para><para>Company sergeant major (Skottland)</para><para>Company sergeant major (Skottland)</para><para>Company sergeant major (Skotlanti)</para><para>Company sergeant major (Schotland)</para><para>Company sergeant major (Scotland)</para><para>Company sergeant major (Szkocja)</para><para>Company sergeant major (Escócia)</para><para>Company sergeant major (Escocia)</para><para>Company sergeant major (Scozia)</para><para>Company sergeant major (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Scotland</seealso>
    let Rank_Company_sergeant_major_Scotland =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapour)</para><para>Company sergeant major (Singapura)</para><para>Company sergeant major (Singapore)</para><para>Company sergeant major (Singapur)</para><para>Company sergeant major (Singapur)</para><para>Company sergeant major (Singapur)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Singapore</seealso>
    let Rank_Company_sergeant_major_Singapore =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_sergeant_major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company sergeant major (Pays de Galles)</para><para>Company sergeant major (País de Gales)</para><para>Company sergeant major (Ð£ÑÐ»ÑÑ)</para><para>Company sergeant major (Galles)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Wales)</para><para>Company sergeant major (Gales)</para><para>Company sergeant major (Walia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Wales</seealso>
    let Rank_Company_sergeant_major_Wales =
        Prefixed_Name(mil, "Rank_Company_sergeant_major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance-corporal_of_horse_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance Corporal of Horse (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Lance Corporal of Horse (Schottland)</para><para>Lance Corporal of Horse (Schotland)</para><para>Lance Corporal of Horse (Skottland)</para><para>Lance Corporal of Horse (Skottland)</para><para>Lance Corporal of Horse (Skotlanti)</para><para>Lance Corporal of Horse (Scotland)</para><para>Lance Corporal of Horse (Escócia)</para><para>Lance Corporal of Horse (Szkocja)</para><para>Lance Corporal of Horse (Escocia)</para><para>Lance Corporal of Horse (Écosse)</para><para>Lance Corporal of Horse (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Scotland</seealso>
    let Rank_Lance_corporal_of_horse_Scotland =
        Prefixed_Name(mil, "Rank_Lance-corporal_of_horse_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberst (Ð¨Ð²ÐµÐ¹ÑÐ°ÑÐ¸Ñ)</para><para>Oberst (Zwitserland)</para><para>Oberst (Switzerland)</para><para>Oberst (Szwajcaria)</para><para>Oberst (Svizzera)</para><para>Oberst (Schweiz)</para><para>Oberst (Schweiz)</para><para>Oberst (Sveitsi)</para><para>Oberst (Sveits)</para><para>Oberst (Suisse)</para><para>Oberst (Suíça)</para><para>Oberst (Suiza)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Switzerland">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Switzerland</seealso>
    let Rank_Oberst_Switzerland =
        Prefixed_Name(mil, "Rank_Oberst_Switzerland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_sergeant_major_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental sergeant major (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Regimental sergeant major (Commonwealth delle nazioni)</para><para>Regimental sergeant major (Mancomunidad de Naciones)</para><para>Regimental sergeant major (Commonwealth of Nations)</para><para>Regimental sergeant major (Commonwealth of Nations)</para><para>Regimental sergeant major (Commonwealth of Nations)</para><para>Regimental sergeant major (Samveldet av nasjoner)</para><para>Regimental sergeant major (Gemenebest van Naties)</para><para>Regimental sergeant major (Wspólnota Narodów)</para><para>Regimental sergeant major (Kansainyhteisö)</para><para>Regimental sergeant major (Commonwealth)</para><para>Regimental sergeant major (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Commonwealth_of_Nations</seealso>
    let Rank_Regimental_sergeant_major_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Regimental_sergeant_major_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_sergeant_major_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental sergeant major (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapura)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapour)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapore)</para><para>Regimental sergeant major (Singapur)</para><para>Regimental sergeant major (Singapur)</para><para>Regimental sergeant major (Singapur)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Singapore</seealso>
    let Rank_Regimental_sergeant_major_Singapore =
        Prefixed_Name(mil, "Rank_Regimental_sergeant_major_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wojski</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¹ÑÐºÐ¸Ð¹</para><para>Wojski</para><para>Wojski</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski">http://rdf.muninn-project.org/ontologies/military#Rank_Wojski</seealso>
    let Rank_Wojski = Prefixed_Name(mil, "Rank_Wojski") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wojski_Lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð¹ÑÐºÐ¸Ð¹ (ÐÐ¸ÑÐ²Ð°)</para><para>Wojski (Lithuania)</para><para>Wojski (Lituania)</para><para>Wojski (Litouwen)</para><para>Wojski (Lituânia)</para><para>Wojski (Lituania)</para><para>Wojski (Lituanie)</para><para>Wojski (Litauen)</para><para>Wojski (Litauen)</para><para>Wojski (Litauen)</para><para>Wojski (Liettua)</para><para>Wojski (Litwa)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Lithuania">http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Lithuania</seealso>
    let Rank_Wojski_Lithuania =
        Prefixed_Name(mil, "Rank_Wojski_Lithuania") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wojski_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¹ÑÐºÐ¸Ð¹ (Poland)</para><para>Wojski (Poland)</para><para>Wojski (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Poland</seealso>
    let Rank_Wojski_Poland = Prefixed_Name(mil, "Rank_Wojski_Poland") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Wonsu</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð½ÑÑ</para><para>Wonsu</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu">http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu</seealso>
    let Rank_Wonsu = Prefixed_Name(mil, "Rank_Wonsu") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wonsu_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð½ÑÑ (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Wonsu (Korean demokraattinen kansantasavalta)</para><para>Wonsu (Korea PÃ³Ånocna)</para><para>Wonsu (Corea del Norte)</para><para>Wonsu (Coreia do Norte)</para><para>Wonsu (Corea del Nord)</para><para>Wonsu (Corée du Nord)</para><para>Wonsu (Noord-Korea)</para><para>Wonsu (North Korea)</para><para>Wonsu (Nord-Korea)</para><para>Wonsu (Nordkorea)</para><para>Wonsu (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_North_Korea</seealso>
    let Rank_Wonsu_North_Korea =
        Prefixed_Name(mil, "Rank_Wonsu_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_EnglishTradition</seealso>
    let Rank_Captain_EnglishTradition =
        Prefixed_Name(mil, "Rank_Captain_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Offizier</para><para>Officier</para><para>Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Officer">http://rdf.muninn-project.org/ontologies/military#Officer</seealso>
    let Officer = Prefixed_Name(mil, "Officer") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankScoutArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///
    /// labels<para>Scout (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankScoutArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankScoutArmyCanada</seealso>
    let RankScoutArmyCanada = Prefixed_Name(mil, "RankScoutArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSergeantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSergeantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSergeantArmyCanada</seealso>
    let RankSergeantArmyCanada =
        Prefixed_Name(mil, "RankSergeantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSignallerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///
    /// labels<para>Signaller (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSignallerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSignallerArmyCanada</seealso>
    let RankSignallerArmyCanada =
        Prefixed_Name(mil, "RankSignallerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSquadronSergeantMajorArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///
    /// labels<para>Squadron Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSquadronSergeantMajorArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankSquadronSergeantMajorArmyCanada+</seealso>
    let ``RankSquadronSergeantMajorArmyCanada+`` =
        Prefixed_Name(mil, "RankSquadronSergeantMajorArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commander_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Capitaine de frégate</para><para>Fregattenkapitän</para><para>Commander</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commander_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Commander_EnglishTradition</seealso>
    let Rank_Commander_EnglishTradition =
        Prefixed_Name(mil, "Rank_Commander_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Kapitein (rang) (Australië (land))</para><para>Kapteeni (sotilasarvo) (Australia)</para><para>Hauptmann (Offizier) (Australien)</para><para>Capitão (militar) (Austrália)</para><para>Kapitan (ranga) (Australia)</para><para>Captain (OF-2) (Australia)</para><para>Kaptein (grad) (Australia)</para><para>Capitaine (Australie)</para><para>Capitano (Australia)</para><para>Capitán (Australia)</para><para>Kapten (Australien)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Australia</seealso>
    let Rank_Captain_Australia =
        Prefixed_Name(mil, "Rank_Captain_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_lieutenant_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Flight lieutenant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_lieutenant_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_lieutenant_EnglishTradition</seealso>
    let Rank_Flight_lieutenant_EnglishTradition =
        Prefixed_Name(mil, "Rank_Flight_lieutenant_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lieutenant_(navy)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_(navy)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_(navy)_EnglishTradition</seealso>
    let ``Rank_Lieutenant_(navy)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Lieutenant_(navy)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Lieutenant_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½-Ð»ÐµÐ¹ÑÐµÐ½Ð°Ð½Ñ (Germany)</para><para>Capitaine-lieutenant (Germany)</para><para>Captain Lieutenant (Germany)</para><para>Kapteeniluutnantti (Germany)</para><para>Kapteinløytnant (Germany)</para><para>Kapitänleutnant (Germany)</para><para>Kaptenlöjtnant (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Germany</seealso>
    let Rank_Captain_Lieutenant_Germany =
        Prefixed_Name(mil, "Rank_Captain_Lieutenant_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_sergeant_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Flight sergeant (República da Irlanda)</para><para>Flight sergeant (Republic of Ireland)</para><para>Flight sergeant (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Flight sergeant (Ierland (land))</para><para>Flight sergeant (Irlande (pays))</para><para>Flight sergeant (Irlandia)</para><para>Flight sergeant (Irlanda)</para><para>Flight sergeant (Irlanda)</para><para>Flight sergeant (Irlanti)</para><para>Flight sergeant (Irland)</para><para>Flight sergeant (Irland)</para><para>Flight sergeant (Irland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Republic_of_Ireland</seealso>
    let Rank_Flight_sergeant_Republic_of_Ireland =
        Prefixed_Name(mil, "Rank_Flight_sergeant_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Garrison_Sergeant_Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Garrison Sergeant Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major">http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major</seealso>
    let Rank_Garrison_Sergeant_Major =
        Prefixed_Name(mil, "Rank_Garrison_Sergeant_Major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Garrison_Sergeant_Major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Garrison Sergeant Major (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Garrison Sergeant Major (Schottland)</para><para>Garrison Sergeant Major (Skottland)</para><para>Garrison Sergeant Major (Skottland)</para><para>Garrison Sergeant Major (Skotlanti)</para><para>Garrison Sergeant Major (Schotland)</para><para>Garrison Sergeant Major (Scotland)</para><para>Garrison Sergeant Major (Szkocja)</para><para>Garrison Sergeant Major (Escócia)</para><para>Garrison Sergeant Major (Escocia)</para><para>Garrison Sergeant Major (Écosse)</para><para>Garrison Sergeant Major (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Scotland</seealso>
    let Rank_Garrison_Sergeant_Major_Scotland =
        Prefixed_Name(mil, "Rank_Garrison_Sergeant_Major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Garrison_Sergeant_Major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Garrison Sergeant Major (Pays de Galles)</para><para>Garrison Sergeant Major (País de Gales)</para><para>Garrison Sergeant Major (Ð£ÑÐ»ÑÑ)</para><para>Garrison Sergeant Major (Galles)</para><para>Garrison Sergeant Major (Walia)</para><para>Garrison Sergeant Major (Wales)</para><para>Garrison Sergeant Major (Gales)</para><para>Garrison Sergeant Major (Wales)</para><para>Garrison Sergeant Major (Wales)</para><para>Garrison Sergeant Major (Wales)</para><para>Garrison Sergeant Major (Wales)</para><para>Garrison Sergeant Major (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Wales</seealso>
    let Rank_Garrison_Sergeant_Major_Wales =
        Prefixed_Name(mil, "Rank_Garrison_Sergeant_Major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Kingdom_of_Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Oberst (ÐÐ¾ÑÐ¾Ð»ÐµÐ²ÑÑÐ²Ð¾ ÐÐ°Ð½Ð¸Ñ)</para><para>Oberst (Regno Unito di Danimarca)</para><para>Oberst (Tanskan kuningaskunta)</para><para>Oberst (Reino de Dinamarca)</para><para>Oberst (Kungariket Danmark)</para><para>Oberst (Kingdom of Denmark)</para><para>Oberst (Reino da Dinamarca)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Kingdom_of_Denmark">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Kingdom_of_Denmark</seealso>
    let Rank_Oberst_Kingdom_of_Denmark =
        Prefixed_Name(mil, "Rank_Oberst_Kingdom_of_Denmark") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Oberst (ÐÐ¾ÑÐ²ÐµÐ³Ð¸Ñ)</para><para>Oberst (Noorwegen)</para><para>Oberst (Norvegia)</para><para>Oberst (Norwegen)</para><para>Oberst (Norwegia)</para><para>Oberst (Noruega)</para><para>Oberst (Norvège)</para><para>Oberst (Noruega)</para><para>Oberst (Norway)</para><para>Oberst (Norja)</para><para>Oberst (Norge)</para><para>Oberst (Norge)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Norway">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Norway</seealso>
    let Rank_Oberst_Norway = Prefixed_Name(mil, "Rank_Oberst_Norway") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Regimental Quartermaster Sergeant (Schottland)</para><para>Regimental Quartermaster Sergeant (Schotland)</para><para>Regimental Quartermaster Sergeant (Skotlanti)</para><para>Regimental Quartermaster Sergeant (Skottland)</para><para>Regimental Quartermaster Sergeant (Skottland)</para><para>Regimental Quartermaster Sergeant (Scotland)</para><para>Regimental Quartermaster Sergeant (Szkocja)</para><para>Regimental Quartermaster Sergeant (Escocia)</para><para>Regimental Quartermaster Sergeant (Escócia)</para><para>Regimental Quartermaster Sergeant (Scozia)</para><para>Regimental Quartermaster Sergeant (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Scotland</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Scotland =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÑÐ°ÑÐµÐ³ (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Strateg (Grecja) (ZwiÄzek Achajski)</para><para>Strategos (Det akhaiske forbund)</para><para>Strategos (Achaiska förbundet)</para><para>Strategos (Achaiischer Bund)</para><para>Strategos (Achaeïsche Bond)</para><para>Strategos (Akhaian liitto)</para><para>Strategos (Achaean League)</para><para>Stratège (Ligue achéenne)</para><para>Estratego (Liga Aqueia)</para><para>Strategos (Lega achea)</para><para>Strategos (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Achaean_League</seealso>
    let Rank_Strategos_Achaean_League =
        Prefixed_Name(mil, "Rank_Strategos_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_Byzantine_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÑÐ°ÑÐµÐ³ (ÐÐ¸Ð·Ð°Ð½ÑÐ¸Ð¹ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Strateg (Grecja) (Cesarstwo BizantyÅskie)</para><para>Strategos (Byzantinisches Reich)</para><para>Strategos (Bysantin valtakunta)</para><para>Estratego (Império Bizantino)</para><para>Strategos (Bysantinska riket)</para><para>Strategos (Imperio bizantino)</para><para>Strategos (Byzantijnse Rijk)</para><para>Strategos (Byzantine Empire)</para><para>Strategos (Impero bizantino)</para><para>Stratège (Empire byzantin)</para><para>Strategos (Østromerriket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Byzantine_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Byzantine_Empire</seealso>
    let Rank_Strategos_Byzantine_Empire =
        Prefixed_Name(mil, "Rank_Strategos_Byzantine_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÑÐ°ÑÐµÐ³ (ÐÑÐµÑÐ¸Ñ)</para><para>Strateg (Grecja) (Grecja)</para><para>Strategos (Griechenland)</para><para>Strategos (Griekenland)</para><para>Strategos (Grekland)</para><para>Strategos (Kreikka)</para><para>Strategos (Grecia)</para><para>Estratego (Grécia)</para><para>Strategos (Grecia)</para><para>Strategos (Greece)</para><para>Strategos (Hellas)</para><para>Stratège (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Greece</seealso>
    let Rank_Strategos_Greece =
        Prefixed_Name(mil, "Rank_Strategos_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÑÐ°ÑÐµÐ³ (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Strateg (Grecja) (StaroÅ¼ytna Macedonia)</para><para>Strategos (Macedonia (ancient kingdom))</para><para>Strategos (Macedonia (ancient kingdom))</para><para>Strategos (Makedonian valtakunta)</para><para>Stratège (Royaume de Macédoine)</para><para>Strategos (Oldtidens Makedonia)</para><para>Strategos (Macedonië (oudheid))</para><para>Strategos (Reino de Macedonia)</para><para>Strategos (Regno di Macedonia)</para><para>Estratego (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Macedonia</seealso>
    let Rank_Strategos_Macedonia =
        Prefixed_Name(mil, "Rank_Strategos_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Strateg (Grecja) (Timocracy of Sapinetia)</para><para>Ð¡ÑÑÐ°ÑÐµÐ³ (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Estratego (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Strategos (Timocracy of Sapinetia)</para><para>Stratège (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Strategos_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Strategos_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wonsu_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð½ÑÑ (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Wonsu (Korea PoÅudniowa)</para><para>Wonsu (Korean tasavalta)</para><para>Wonsu (Coreia do Sul)</para><para>Wonsu (Corea del Sud)</para><para>Wonsu (Corea del Sur)</para><para>Wonsu (Corée du Sud)</para><para>Wonsu (South Korea)</para><para>Wonsu (Zuid-Korea)</para><para>Wonsu (Sør-Korea)</para><para>Wonsu (Sydkorea)</para><para>Wonsu (Südkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_South_Korea</seealso>
    let Rank_Wonsu_South_Korea =
        Prefixed_Name(mil, "Rank_Wonsu_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Yesaul</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°ÑÐ»</para><para>Jessaul</para><para>Yesaul</para><para>EsauÅ</para><para>Jesaul</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul">http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul</seealso>
    let Rank_Yesaul = Prefixed_Name(mil, "Rank_Yesaul") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Yesaul_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°ÑÐ» (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Jessaul (Russland)</para><para>Jesaul (Ryssland)</para><para>Yesaul (Russland)</para><para>Yesaul (Rusland)</para><para>Yesaul (Russia)</para><para>Yesaul (Russie)</para><para>Yesaul (Rússia)</para><para>Yesaul (Russia)</para><para>Yesaul (Venäjä)</para><para>EsauÅ (Rosja)</para><para>Yesaul (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Russia</seealso>
    let Rank_Yesaul_Russia = Prefixed_Name(mil, "Rank_Yesaul_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankStaffSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Staff Sergeant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankStaffSergeant">http://rdf.muninn-project.org/ontologies/military#1AIFRankStaffSergeant</seealso>
    let _1AIFRankStaffSergeant =
        Prefixed_Name(mil, "1AIFRankStaffSergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Staff sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant</seealso>
    let Rank_Staff_sergeant = Prefixed_Name(mil, "Rank_Staff_sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankWarrantOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant Officer (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficer">http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficer</seealso>
    let _1AIFRankWarrantOfficer =
        Prefixed_Name(mil, "1AIFRankWarrantOfficer") |> PrefixedName

    /// <summary>
    ///   <para>mil:NatoRankOF-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Officer Rank OF-9</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-9">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-9</seealso>
    let NatoRankOF_9 = Prefixed_Name(mil, "NatoRankOF-9") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-1</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-1">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-1</seealso>
    let NatoRankOR_1 = Prefixed_Name(mil, "NatoRankOR-1") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-3</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-3">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-3</seealso>
    let NatoRankOR_3 = Prefixed_Name(mil, "NatoRankOR-3") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-4</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-4">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-4</seealso>
    let NatoRankOR_4 = Prefixed_Name(mil, "NatoRankOR-4") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-5</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-5</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-5">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-5</seealso>
    let NatoRankOR_5 = Prefixed_Name(mil, "NatoRankOR-5") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-9</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-9</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-9">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-9</seealso>
    let NatoRankOR_9 = Prefixed_Name(mil, "NatoRankOR-9") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankWO-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Warrant Officer Rank WO-1</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-1">http://rdf.muninn-project.org/ontologies/military#NatoRankWO-1</seealso>
    let NatoRankWO_1 = Prefixed_Name(mil, "NatoRankWO-1") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankWO-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Warrant Officer Rank WO-2</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-2">http://rdf.muninn-project.org/ontologies/military#NatoRankWO-2</seealso>
    let NatoRankWO_2 = Prefixed_Name(mil, "NatoRankWO-2") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_commodore_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air commodore</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_commodore_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Air_commodore_EnglishTradition</seealso>
    let Rank_Air_commodore_EnglishTradition =
        Prefixed_Name(mil, "Rank_Air_commodore_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigadier_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Brigadier</para><para>Brigadier</para><para>Brigadier</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_EnglishTradition</seealso>
    let Rank_Brigadier_EnglishTradition =
        Prefixed_Name(mil, "Rank_Brigadier_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Group_captain_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Group captain</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Group_captain_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Group_captain_EnglishTradition</seealso>
    let Rank_Group_captain_EnglishTradition =
        Prefixed_Name(mil, "Rank_Group_captain_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_vice-marshal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air vice-marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal">http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal</seealso>
    let Rank_Air_vice_marshal =
        Prefixed_Name(mil, "Rank_Air_vice-marshal") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_vice-marshal_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air vice-marshal (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Canada</seealso>
    let Rank_Air_vice_marshal_Canada =
        Prefixed_Name(mil, "Rank_Air_vice-marshal_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_vice-marshal_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air vice-marshal (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Air vice-marshal (Commonwealth delle nazioni)</para><para>Air vice-marshal (Mancomunidad de Naciones)</para><para>Air vice-marshal (Commonwealth of Nations)</para><para>Air vice-marshal (Commonwealth of Nations)</para><para>Air vice-marshal (Commonwealth of Nations)</para><para>Air vice-marshal (Samveldet av nasjoner)</para><para>Air vice-marshal (Gemenebest van Naties)</para><para>Air vice-marshal (Wspólnota Narodów)</para><para>Air vice-marshal (Kansainyhteisö)</para><para>Air vice-marshal (Commonwealth)</para><para>Air vice-marshal (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Commonwealth_of_Nations</seealso>
    let Rank_Air_vice_marshal_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Air_vice-marshal_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General_Admiral_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð»-Ð°Ð´Ð¼Ð¸ÑÐ°Ð» (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Admiraal-generaal (Rusland)</para><para>General Admiral (Russland)</para><para>General Admiral (Ryssland)</para><para>Generaladmiral (Russland)</para><para>Kenraaliamiraali (Venäjä)</para><para>Almirante General (Rusia)</para><para>General Admiral (Rússia)</para><para>General Admiral (Russia)</para><para>General Admiral (Russie)</para><para>General Admiral (Russia)</para><para>General Admiral (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Russia</seealso>
    let Rank_General_Admiral_Russia =
        Prefixed_Name(mil, "Rank_General_Admiral_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant</seealso>
    let Rank_Lance_sergeant = Prefixed_Name(mil, "Rank_Lance_sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance Sergeant (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Lance Sergeant (Australië (land))</para><para>Lance Sergeant (Australien)</para><para>Lance Sergeant (Australien)</para><para>Lance Sergeant (Australie)</para><para>Lance Sergeant (Austrália)</para><para>Lance Sergeant (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Australia</seealso>
    let Rank_Lance_sergeant_Australia =
        Prefixed_Name(mil, "Rank_Lance_sergeant_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Phrourarch_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Phrourarch (Griechenland)</para><para>Phrourarch (ÐÑÐµÑÐ¸Ñ)</para><para>Phrourarch (Griekenland)</para><para>Phrourarch (Grekland)</para><para>Phrourarch (Kreikka)</para><para>Phrourarch (Greece)</para><para>Phrourarch (Grecia)</para><para>Phrourarch (Grécia)</para><para>Phrourarch (Grecia)</para><para>Phrourarch (Grecja)</para><para>Phrourarch (Hellas)</para><para>Phrourarch (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Greece</seealso>
    let Rank_Phrourarch_Greece =
        Prefixed_Name(mil, "Rank_Phrourarch_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Phrourarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Phrourarch (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Phrourarch (Macedonia (ancient kingdom))</para><para>Phrourarch (StaroÅ¼ytna Macedonia)</para><para>Phrourarch (Makedonian valtakunta)</para><para>Phrourarch (Royaume de Macédoine)</para><para>Phrourarch (Macedonië (oudheid))</para><para>Phrourarch (Oldtidens Makedonia)</para><para>Phrourarch (Reino de Macedonia)</para><para>Phrourarch (Regno di Macedonia)</para><para>Phrourarch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Macedonia</seealso>
    let Rank_Phrourarch_Macedonia =
        Prefixed_Name(mil, "Rank_Phrourarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Phrourarch_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Phrourarch (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Phrourarch_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Phrourarch_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Second_Corporal_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Second Corporal (Pays de Galles)</para><para>Second Corporal (País de Gales)</para><para>Second Corporal (Ð£ÑÐ»ÑÑ)</para><para>Second Corporal (Galles)</para><para>Second Corporal (Wales)</para><para>Second Corporal (Gales)</para><para>Second Corporal (Wales)</para><para>Second Corporal (Wales)</para><para>Second Corporal (Wales)</para><para>Second Corporal (Wales)</para><para>Second Corporal (Walia)</para><para>Second Corporal (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Wales</seealso>
    let Rank_Second_Corporal_Wales =
        Prefixed_Name(mil, "Rank_Second_Corporal_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Major_Instructor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Major Instructor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor</seealso>
    let Rank_Sergeant_Major_Instructor =
        Prefixed_Name(mil, "Rank_Sergeant_Major_Instructor") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Major_Instructor_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Major Instructor (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_England">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_England</seealso>
    let Rank_Sergeant_Major_Instructor_England =
        Prefixed_Name(mil, "Rank_Sergeant_Major_Instructor_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Major_Instructor_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sergeant Major Instructor (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Sergeant Major Instructor (Schottland)</para><para>Sergeant Major Instructor (Schotland)</para><para>Sergeant Major Instructor (Skottland)</para><para>Sergeant Major Instructor (Skottland)</para><para>Sergeant Major Instructor (Skotlanti)</para><para>Sergeant Major Instructor (Scotland)</para><para>Sergeant Major Instructor (Szkocja)</para><para>Sergeant Major Instructor (Escócia)</para><para>Sergeant Major Instructor (Escocia)</para><para>Sergeant Major Instructor (Écosse)</para><para>Sergeant Major Instructor (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Scotland</seealso>
    let Rank_Sergeant_Major_Instructor_Scotland =
        Prefixed_Name(mil, "Rank_Sergeant_Major_Instructor_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Tagmatarchis (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ</para><para>Taxiarch</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch</seealso>
    let Rank_Taxiarch = Prefixed_Name(mil, "Rank_Taxiarch") |> PrefixedName
    /// <summary>
    ///   <para>mil:RegimentalColours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Drapeau du Regiment</para><para>Regimental Colours</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RegimentalColours">http://rdf.muninn-project.org/ontologies/military#RegimentalColours</seealso>
    let RegimentalColours = Prefixed_Name(mil, "RegimentalColours") |> PrefixedName
    /// <summary>
    ///   <para>mil:Reservist</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reservist (Soldier)</para><para>Reservist (Soldat)</para><para>Soldat Réserviste</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Reservist">http://rdf.muninn-project.org/ontologies/military#Reservist</seealso>
    let Reservist = Prefixed_Name(mil, "Reservist") |> PrefixedName
    /// <summary>
    ///   <para>mil:Ship</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Navire</para><para>Ship</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Ship">http://rdf.muninn-project.org/ontologies/military#Ship</seealso>
    let Ship = Prefixed_Name(mil, "Ship") |> PrefixedName
    /// <summary>
    ///   <para>mil:ShoreEstablishment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Etablishment de Terre (Marine)</para><para>Ufer Gründung (Kriegsmarine)</para><para>Shore Establishment (Navy)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ShoreEstablishment">http://rdf.muninn-project.org/ontologies/military#ShoreEstablishment</seealso>
    let ShoreEstablishment = Prefixed_Name(mil, "ShoreEstablishment") |> PrefixedName
    /// <summary>
    ///   <para>mil:warship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#warship">http://rdf.muninn-project.org/ontologies/military#warship</seealso>
    let warship = Prefixed_Name(mil, "warship") |> PrefixedName
    /// <summary>
    ///   <para>mil:ship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ship">http://rdf.muninn-project.org/ontologies/military#ship</seealso>
    let ship = Prefixed_Name(mil, "ship") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankMajor</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Major (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankMajor">http://rdf.muninn-project.org/ontologies/military#1AIFRankMajor</seealso>
    let _1AIFRankMajor = Prefixed_Name(mil, "1AIFRankMajor") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankPettyOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Petty Officer (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPettyOfficer">http://rdf.muninn-project.org/ontologies/military#1AIFRankPettyOfficer</seealso>
    let _1AIFRankPettyOfficer =
        Prefixed_Name(mil, "1AIFRankPettyOfficer") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Petty_officer_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Maître (grade)</para><para>Petty officer</para><para>Petty Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Petty_officer_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Petty_officer_EnglishTradition</seealso>
    let Rank_Petty_officer_EnglishTradition =
        Prefixed_Name(mil, "Rank_Petty_officer_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankPrivate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>Private (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPrivate">http://rdf.muninn-project.org/ontologies/military#1AIFRankPrivate</seealso>
    let _1AIFRankPrivate = Prefixed_Name(mil, "1AIFRankPrivate") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryOperation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryOperation">http://rdf.muninn-project.org/ontologies/military#MilitaryOperation</seealso>
    let MilitaryOperation = Prefixed_Name(mil, "MilitaryOperation") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryRaid</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryRaid">http://rdf.muninn-project.org/ontologies/military#MilitaryRaid</seealso>
    let MilitaryRaid = Prefixed_Name(mil, "MilitaryRaid") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Marshal_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Maréchal (armée)</para><para>Marschall</para><para>Marshal</para><para>Marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_EnglishTradition</seealso>
    let Rank_Marshal_EnglishTradition =
        Prefixed_Name(mil, "Rank_Marshal_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Agha</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ³Ð° (ÑÐ¸ÑÑÐ» Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸ÐºÐ¾Ð²)</para><para>Agha (Ottoman Empire)</para><para>Aga (wojsko)</para><para>Agha (Titel)</para><para>Agha</para><para>Agha</para><para>Agha</para><para>Agha</para><para>Agha</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha">http://rdf.muninn-project.org/ontologies/military#Rank_Agha</seealso>
    let Rank_Agha = Prefixed_Name(mil, "Rank_Agha") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Garrison_Sergeant_Major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Garrison Sergeant Major (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_England</seealso>
    let Rank_Garrison_Sergeant_Major_England =
        Prefixed_Name(mil, "Rank_Garrison_Sergeant_Major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberst (Germany)</para><para>Oberst (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Germany</seealso>
    let Rank_Oberst_Germany = Prefixed_Name(mil, "Rank_Oberst_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Starshina_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÐ°ÑÑÐ¸Ð½Ð° (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Starshina (Oekraïne)</para><para>Starshina (Ukraina)</para><para>Starshina (Ukraine)</para><para>Starshina (Ukraine)</para><para>Starshiná (Ucrania)</para><para>Starshina (Ukraina)</para><para>Starshina (Ucrânia)</para><para>Starshina (Ukraine)</para><para>Starshina (Ukraina)</para><para>Starshina (Ukraina)</para><para>Starshina (Ucraina)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Ukraine</seealso>
    let Rank_Starshina_Ukraine =
        Prefixed_Name(mil, "Rank_Starshina_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stratarches</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Stratarches</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches">http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches</seealso>
    let Rank_Stratarches = Prefixed_Name(mil, "Rank_Stratarches") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stratarches_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Stratarches (ÐÑÐµÑÐ¸Ñ)</para><para>Stratarches (Griechenland)</para><para>Stratarches (Griekenland)</para><para>Stratarches (Grekland)</para><para>Stratarches (Kreikka)</para><para>Stratarches (Hellas)</para><para>Stratarches (Grecia)</para><para>Stratarches (Greece)</para><para>Stratarches (Grecja)</para><para>Stratarches (Grécia)</para><para>Stratarches (Grecia)</para><para>Stratarches (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Greece</seealso>
    let Rank_Stratarches_Greece =
        Prefixed_Name(mil, "Rank_Stratarches_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stratarches_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Stratarches (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Stratarches_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Stratarches_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Strategos</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Strateg (Grecja)</para><para>Ð¡ÑÑÐ°ÑÐµÐ³</para><para>Estratego</para><para>Strategos</para><para>Strategos</para><para>Strategos</para><para>Strategos</para><para>Strategos</para><para>Strategos</para><para>Strategos</para><para>Stratège</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos">http://rdf.muninn-project.org/ontologies/military#Rank_Strategos</seealso>
    let Rank_Strategos = Prefixed_Name(mil, "Rank_Strategos") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant Officer (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Canada</seealso>
    let Rank_Warrant_officer_United_Kingdom_Canada =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Warrant Officer (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Warrant Officer (Commonwealth delle nazioni)</para><para>Warrant Officer (Mancomunidad de Naciones)</para><para>Warrant Officer (Commonwealth of Nations)</para><para>Warrant Officer (Commonwealth of Nations)</para><para>Warrant Officer (Commonwealth of Nations)</para><para>Warrant Officer (Samveldet av nasjoner)</para><para>Warrant Officer (Gemenebest van Naties)</para><para>Warrant Officer (Wspólnota Narodów)</para><para>Warrant Officer (Kansainyhteisö)</para><para>Warrant Officer (Commonwealth)</para><para>Warrant Officer (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations</seealso>
    let Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankGunner</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Gunner</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankGunner">http://rdf.muninn-project.org/ontologies/military#RankGunner</seealso>
    let RankGunner = Prefixed_Name(mil, "RankGunner") |> PrefixedName
    /// <summary>
    ///   <para>mil:Frigate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Frigate</para><para>Fregate</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Frigate">http://rdf.muninn-project.org/ontologies/military#Frigate</seealso>
    let Frigate = Prefixed_Name(mil, "Frigate") |> PrefixedName
    /// <summary>
    ///   <para>mil:WarTheater</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Théâtre militaire</para><para>Theater (warfare)</para><para>Kriegsschauplatz</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#WarTheater">http://rdf.muninn-project.org/ontologies/military#WarTheater</seealso>
    let WarTheater = Prefixed_Name(mil, "WarTheater") |> PrefixedName
    /// <summary>
    ///   <para>mil:GeneralOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>allgemeinen Offizier</para><para>Officiers Généraux</para><para>General Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#GeneralOfficer">http://rdf.muninn-project.org/ontologies/military#GeneralOfficer</seealso>
    let GeneralOfficer = Prefixed_Name(mil, "GeneralOfficer") |> PrefixedName
    /// <summary>
    ///   <para>mil:HorseArtillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Berittene Artillerie</para><para>Artillerie à cheval</para><para>Horse Artillery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#HorseArtillery">http://rdf.muninn-project.org/ontologies/military#HorseArtillery</seealso>
    let HorseArtillery = Prefixed_Name(mil, "HorseArtillery") |> PrefixedName
    /// <summary>
    ///   <para>mil:Invasion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Invasion">http://rdf.muninn-project.org/ontologies/military#Invasion</seealso>
    let Invasion = Prefixed_Name(mil, "Invasion") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryAirborneFlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Aviation Flight (Military Unit)</para><para>Schwarm (Luftfahrt)</para><para>Escadrille</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryAirborneFlight">http://rdf.muninn-project.org/ontologies/military#MilitaryAirborneFlight</seealso>
    let MilitaryAirborneFlight =
        Prefixed_Name(mil, "MilitaryAirborneFlight") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryGroundFlight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ground Flight (Military Unit)</para><para>Schwarm Boden(Luftfahrt)</para><para>Escadrille de terra</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryGroundFlight">http://rdf.muninn-project.org/ontologies/military#MilitaryGroundFlight</seealso>
    let MilitaryGroundFlight =
        Prefixed_Name(mil, "MilitaryGroundFlight") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryUniform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Military Uniform</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryUniform">http://rdf.muninn-project.org/ontologies/military#MilitaryUniform</seealso>
    let MilitaryUniform = Prefixed_Name(mil, "MilitaryUniform") |> PrefixedName
    /// <summary>
    ///   <para>mil:MountainArtillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Artillerie de Montagnecampagne</para><para>Mountain Artillery</para><para>Gebirgsgeschütz</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MountainArtillery">http://rdf.muninn-project.org/ontologies/military#MountainArtillery</seealso>
    let MountainArtillery = Prefixed_Name(mil, "MountainArtillery") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-1</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Officer Rank OF-1</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-1">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-1</seealso>
    let NatoRankOF_1 = Prefixed_Name(mil, "NatoRankOF-1") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRanks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Grades de l'OTAN</para><para>NATO Rangcode</para><para>Ranks of NATO</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRanks">http://rdf.muninn-project.org/ontologies/military#NatoRanks</seealso>
    let NatoRanks = Prefixed_Name(mil, "NatoRanks") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Officer Rank OF-3</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-3">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-3</seealso>
    let NatoRankOF_3 = Prefixed_Name(mil, "NatoRankOF-3") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Officer Rank OF-4</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-4">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-4</seealso>
    let NatoRankOF_4 = Prefixed_Name(mil, "NatoRankOF-4") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Officer Rank OF-6</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-6">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-6</seealso>
    let NatoRankOF_6 = Prefixed_Name(mil, "NatoRankOF-6") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-7</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Officer Rank OF-7</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-7">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-7</seealso>
    let NatoRankOF_7 = Prefixed_Name(mil, "NatoRankOF-7") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Officer Rank OF-8</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-8">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-8</seealso>
    let NatoRankOF_8 = Prefixed_Name(mil, "NatoRankOF-8") |> PrefixedName

    /// <summary>
    ///   <para>mil:NonCommissionedOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Soldatenlaufbahnverordnung</para><para>Sous-Officier Subalternes</para><para>Non Commissioned Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NonCommissionedOfficer">http://rdf.muninn-project.org/ontologies/military#NonCommissionedOfficer</seealso>
    let NonCommissionedOfficer =
        Prefixed_Name(mil, "NonCommissionedOfficer") |> PrefixedName

    /// <summary>
    ///   <para>mil:NatoRankOR-2</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-2</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-2">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-2</seealso>
    let NatoRankOR_2 = Prefixed_Name(mil, "NatoRankOR-2") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-6</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-6">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-6</seealso>
    let NatoRankOR_6 = Prefixed_Name(mil, "NatoRankOR-6") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-7</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-7</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-7">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-7</seealso>
    let NatoRankOR_7 = Prefixed_Name(mil, "NatoRankOR-7") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOR-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Other/Enlisted Rank OR-8</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-8">http://rdf.muninn-project.org/ontologies/military#NatoRankOR-8</seealso>
    let NatoRankOR_8 = Prefixed_Name(mil, "NatoRankOR-8") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankWO-3</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Warrant Officer Rank WO-3</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-3">http://rdf.muninn-project.org/ontologies/military#NatoRankWO-3</seealso>
    let NatoRankWO_3 = Prefixed_Name(mil, "NatoRankWO-3") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankWO-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>NATO Warrant Officer Rank WO-4</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-4">http://rdf.muninn-project.org/ontologies/military#NatoRankWO-4</seealso>
    let NatoRankWO_4 = Prefixed_Name(mil, "NatoRankWO-4") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankWO-5</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Warrant Officer Rank WO-5</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-5">http://rdf.muninn-project.org/ontologies/military#NatoRankWO-5</seealso>
    let NatoRankWO_5 = Prefixed_Name(mil, "NatoRankWO-5") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavalArtillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Artillerie Navale</para><para>Schiffsartillerie</para><para>Navel Artillery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalArtillery">http://rdf.muninn-project.org/ontologies/military#NavalArtillery</seealso>
    let NavalArtillery = Prefixed_Name(mil, "NavalArtillery") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavyBigFleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Marine (Groupe de batiment naval)</para><para>Navy (Named or Numbered)</para><para>Marine (Boot-Gruppe)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavyBigFleet">http://rdf.muninn-project.org/ontologies/military#NavyBigFleet</seealso>
    let NavyBigFleet = Prefixed_Name(mil, "NavyBigFleet") |> PrefixedName
    /// <summary>
    ///   <para>mil:SeamanMilitary</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Matelot (Militare)</para><para>Seaman (Military)</para><para>Matrose (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#SeamanMilitary">http://rdf.muninn-project.org/ontologies/military#SeamanMilitary</seealso>
    let SeamanMilitary = Prefixed_Name(mil, "SeamanMilitary") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavalRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Unteroffiziere (Deutsche Marine)</para><para>Maître (Marine de Guerre)</para><para>Naval Rating</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalRating">http://rdf.muninn-project.org/ontologies/military#NavalRating</seealso>
    let NavalRating = Prefixed_Name(mil, "NavalRating") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavyAirStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Station (Naval Aircraft)</para><para></para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavyAirStation">http://rdf.muninn-project.org/ontologies/military#NavyAirStation</seealso>
    let NavyAirStation = Prefixed_Name(mil, "NavyAirStation") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavyMerchant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavyMerchant">http://rdf.muninn-project.org/ontologies/military#NavyMerchant</seealso>
    let NavyMerchant = Prefixed_Name(mil, "NavyMerchant") |> PrefixedName
    /// <summary>
    ///   <para>mil:member</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#member">http://rdf.muninn-project.org/ontologies/military#member</seealso>
    let member_ = Prefixed_Name(mil, "member") |> PrefixedName

    /// <summary>
    ///   <para>mil:WaterBasedOrganization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#WaterBasedOrganization">http://rdf.muninn-project.org/ontologies/military#WaterBasedOrganization</seealso>
    let WaterBasedOrganization =
        Prefixed_Name(mil, "WaterBasedOrganization") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Appointee</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee">http://rdf.muninn-project.org/ontologies/military#Rank_Appointee</seealso>
    let Rank_Appointee = Prefixed_Name(mil, "Rank_Appointee") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Appointee_Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Appointee (Ð¨Ð²ÐµÐ¹ÑÐ°ÑÐ¸Ñ)</para><para>Appointee (Switzerland)</para><para>Appointee (Zwitserland)</para><para>Appointee (Szwajcaria)</para><para>Appuntato (Svizzera)</para><para>Appointee (Schweiz)</para><para>Appointee (Schweiz)</para><para>Appointee (Sveitsi)</para><para>Appointee (Sveits)</para><para>Appointee (Suíça)</para><para>Appointé (Suisse)</para><para>Appointee (Suiza)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Switzerland">http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Switzerland</seealso>
    let Rank_Appointee_Switzerland =
        Prefixed_Name(mil, "Rank_Appointee_Switzerland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Chiliarch (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Chiliarch (Macedonia (ancient kingdom))</para><para>Chiliarch (Macedonia (ancient kingdom))</para><para>Chiliarcha (StaroÅ¼ytna Macedonia)</para><para>Chiliarch (Makedonian valtakunta)</para><para>Chiliarque (Royaume de Macédoine)</para><para>Chiliarch (Macedonië (oudheid))</para><para>Chiliarch (Oldtidens Makedonia)</para><para>Chiliarca (Regno di Macedonia)</para><para>Quiliarca (Reino de Macedonia)</para><para>Chiliarch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Macedonia</seealso>
    let Rank_Chiliarch_Macedonia =
        Prefixed_Name(mil, "Rank_Chiliarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chiliarcha (Timocracy of Sapinetia)</para><para>Chiliarque (Timocracy of Sapinetia)</para><para>Quiliarca (Timocracy of Sapinetia)</para><para>Chiliarch (Timocracy of Sapinetia)</para><para>Chiliarch (Timocracy of Sapinetia)</para><para>Chiliarca (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Chiliarch_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Chiliarch_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chorbaji</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð§Ð¾ÑÐ±Ð°Ð´Ð¶Ð¸</para><para>ÃorbacÄ±</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji">http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji</seealso>
    let Rank_Chorbaji = Prefixed_Name(mil, "Rank_Chorbaji") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chorbaji_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð§Ð¾ÑÐ±Ð°Ð´Ð¶Ð¸ (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>ÃorbacÄ± (Cossack Hetmanate)</para><para>ÃorbacÄ± (Hetmanat cosaque)</para><para>ÃorbacÄ± (Hetmanato cosaco)</para><para>ÃorbacÄ± (HetmaÅszczyzna)</para><para>ÃorbacÄ± (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Cossack_Hetmanate</seealso>
    let Rank_Chorbaji_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Chorbaji_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hetman_Belarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÑÐ¼Ð°Ð½ (ÐÐµÐ»Ð¾ÑÑÑÑÐ¸Ñ)</para><para>Hetman (Hviterussland)</para><para>Hetmani (Valko-Venäjä)</para><para>Hetman (Bielorrússia)</para><para>Hetman (Weißrussland)</para><para>Hetman (Vitryssland)</para><para>Hetman (Bielorrusia)</para><para>Hetman (Wit-Rusland)</para><para>Hetman (Biélorussie)</para><para>Hetman (Bielorussia)</para><para>Hetman (BiaÅoruÅ)</para><para>Hetman (Belarus)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Belarus">http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Belarus</seealso>
    let Rank_Hetman_Belarus = Prefixed_Name(mil, "Rank_Hetman_Belarus") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hetman_Lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÑÐ¼Ð°Ð½ (ÐÐ¸ÑÐ²Ð°)</para><para>Hetman (Lithuania)</para><para>Hetman (Lituania)</para><para>Hetman (Litouwen)</para><para>Hetmani (Liettua)</para><para>Hetman (Lituania)</para><para>Hetman (Lituânia)</para><para>Hetman (Lituanie)</para><para>Hetman (Litauen)</para><para>Hetman (Litauen)</para><para>Hetman (Litauen)</para><para>Hetman (Litwa)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Lithuania">http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Lithuania</seealso>
    let Rank_Hetman_Lithuania =
        Prefixed_Name(mil, "Rank_Hetman_Lithuania") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lochagos_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lochagos (ÐÑÐµÑÐ¸Ñ)</para><para>Lochagos (Griechenland)</para><para>Lochagos (Griekenland)</para><para>Lochagos (Grekland)</para><para>Lochagos (Kreikka)</para><para>Lochagos (Hellas)</para><para>Lochagos (Grecia)</para><para>Lochagos (Grecja)</para><para>Lochagos (Grécia)</para><para>Lochagos (Grecia)</para><para>Lochagos (Greece)</para><para>Lochagos (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Greece</seealso>
    let Rank_Lochagos_Greece =
        Prefixed_Name(mil, "Rank_Lochagos_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lochagos_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lochagos (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Lochagos (Macedonia (ancient kingdom))</para><para>Lochagos (StaroÅ¼ytna Macedonia)</para><para>Lochagos (Makedonian valtakunta)</para><para>Lochagos (Royaume de Macédoine)</para><para>Lochagos (Macedonië (oudheid))</para><para>Lochagos (Oldtidens Makedonia)</para><para>Lochagos (Regno di Macedonia)</para><para>Lochagos (Reino de Macedonia)</para><para>Lochagos (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Macedonia</seealso>
    let Rank_Lochagos_Macedonia =
        Prefixed_Name(mil, "Rank_Lochagos_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Pilot (Canada)</para><para>Fältflygare (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Canada</seealso>
    let Rank_Sergeant_Pilot_Canada =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Pilot (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Sergeant Pilot (Commonwealth delle nazioni)</para><para>Sergeant Pilot (Mancomunidad de Naciones)</para><para>Sergeant Pilot (Commonwealth of Nations)</para><para>Sergeant Pilot (Commonwealth of Nations)</para><para>Sergeant Pilot (Commonwealth of Nations)</para><para>Sergeant Pilot (Gemenebest van Naties)</para><para>Sergeant Pilot (Samveldet av nasjoner)</para><para>Sergeant Pilot (Wspólnota Narodów)</para><para>Sergeant Pilot (Kansainyhteisö)</para><para>Sergeant Pilot (Commonwealth)</para><para>Fältflygare (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Commonwealth_of_Nations</seealso>
    let Rank_Sergeant_Pilot_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Pilot (England)</para><para>Fältflygare (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_England">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_England</seealso>
    let Rank_Sergeant_Pilot_England =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Pilot (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Sergeant Pilot (Schottland)</para><para>Sergeant Pilot (Schotland)</para><para>Sergeant Pilot (Skotlanti)</para><para>Sergeant Pilot (Skottland)</para><para>Sergeant Pilot (Scotland)</para><para>Sergeant Pilot (Escocia)</para><para>Sergeant Pilot (Szkocja)</para><para>Sergeant Pilot (Escócia)</para><para>Fältflygare (Skottland)</para><para>Sergeant Pilot (Scozia)</para><para>Sergeant Pilot (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Scotland</seealso>
    let Rank_Sergeant_Pilot_Scotland =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant_Pilot_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Pilot (Pays de Galles)</para><para>Sergeant Pilot (País de Gales)</para><para>Sergeant Pilot (Ð£ÑÐ»ÑÑ)</para><para>Sergeant Pilot (Galles)</para><para>Sergeant Pilot (Gales)</para><para>Sergeant Pilot (Wales)</para><para>Sergeant Pilot (Wales)</para><para>Sergeant Pilot (Wales)</para><para>Sergeant Pilot (Wales)</para><para>Sergeant Pilot (Walia)</para><para>Sergeant Pilot (Wales)</para><para>Fältflygare (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Wales</seealso>
    let Rank_Sergeant_Pilot_Wales =
        Prefixed_Name(mil, "Rank_Sergeant_Pilot_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Skeuophoros</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Skeuophoros</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros">http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros</seealso>
    let Rank_Skeuophoros = Prefixed_Name(mil, "Rank_Skeuophoros") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Skeuophoros_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Skeuophoros (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Skeuophoros (Det akhaiske forbund)</para><para>Skeuophoros (Achaiska förbundet)</para><para>Skeuophoros (ZwiÄzek Achajski)</para><para>Skeuophoros (Achaiischer Bund)</para><para>Skeuophoros (Achaeïsche Bond)</para><para>Skeuophoros (Akhaian liitto)</para><para>Skeuophoros (Achaean League)</para><para>Skeuophoros (Ligue achéenne)</para><para>Skeuophoros (Liga Aqueia)</para><para>Skeuophoros (Lega achea)</para><para>Skeuophoros (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Achaean_League</seealso>
    let Rank_Skeuophoros_Achaean_League =
        Prefixed_Name(mil, "Rank_Skeuophoros_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Somatophylakes</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sômatophylaques</para><para>Somatofilachie</para><para>Somatophylakes</para><para>Somatophylakes</para><para>Somatophylakes</para><para>Somatofylakes</para><para>Somatophylax</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes">http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes</seealso>
    let Rank_Somatophylakes = Prefixed_Name(mil, "Rank_Somatophylakes") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Somatophylakes_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Somatophylakes (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Somatophylakes (Det akhaiske forbund)</para><para>Somatophylakes (Achaiska förbundet)</para><para>Somatophylakes (ZwiÄzek Achajski)</para><para>Somatophylakes (Achaiischer Bund)</para><para>Sômatophylaques (Ligue achéenne)</para><para>Somatophylakes (Achaean League)</para><para>Somatofylakes (Akhaian liitto)</para><para>Somatophylax (Achaeïsche Bond)</para><para>Somatophylakes (Liga Aqueia)</para><para>Somatophylakes (Liga Aquea)</para><para>Somatofilachie (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Achaean_League</seealso>
    let Rank_Somatophylakes_Achaean_League =
        Prefixed_Name(mil, "Rank_Somatophylakes_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sotnik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡Ð¾ÑÐ½Ð¸Ðº</para><para>Sótnik</para><para>Sotnik</para><para>Sotnik</para><para>Sotnik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik">http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik</seealso>
    let Rank_Sotnik = Prefixed_Name(mil, "Rank_Sotnik") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Sotnik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡Ð¾ÑÐ½Ð¸Ðº (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Sotnik (Russland)</para><para>Sotnik (Ryssland)</para><para>Sotnik (Russland)</para><para>Sotnik (Rusland)</para><para>Sotnik (Venäjä)</para><para>Sotnik (Russia)</para><para>Sotnik (Russie)</para><para>Sótnik (Rússia)</para><para>Sotnik (Russia)</para><para>Sotnik (Rusia)</para><para>Sotnik (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Russia</seealso>
    let Rank_Sotnik_Russia = Prefixed_Name(mil, "Rank_Sotnik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trierarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢ÑÐ¸ÐµÑÐ°ÑÑÐ¸Ñ (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Trierarchie (Macedonia (ancient kingdom))</para><para>Trierarch (Macedonia (ancient kingdom))</para><para>Triérarchie (Royaume de Macédoine)</para><para>Trierarch (Makedonian valtakunta)</para><para>Trierarch (StaroÅ¼ytna Macedonia)</para><para>Trierarchia (Regno di Macedonia)</para><para>Trierarch (Macedonië (oudheid))</para><para>Trierark (Oldtidens Makedonia)</para><para>Trierarca (Reino de Macedonia)</para><para>Trierarch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Macedonia</seealso>
    let Rank_Trierarch_Macedonia =
        Prefixed_Name(mil, "Rank_Trierarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trooper_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trooper (rank) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Trooper (rank) (Australië (land))</para><para>Trooper (rank) (Australien)</para><para>Trooper (rank) (Australien)</para><para>Trooper (rank) (Australia)</para><para>Trooper (rank) (Australia)</para><para>Trooper (rank) (Australie)</para><para>Trooper (rank) (Australia)</para><para>Trooper (rank) (Austrália)</para><para>Trooper (rank) (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Australia</seealso>
    let Rank_Trooper_Australia =
        Prefixed_Name(mil, "Rank_Trooper_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:placeOfEnlistment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Place Of Enlistment</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#placeOfEnlistment">http://rdf.muninn-project.org/ontologies/military#placeOfEnlistment</seealso>
    let placeOfEnlistment = Prefixed_Name(mil, "placeOfEnlistment") |> PrefixedName

    /// <summary>
    ///   <para>mil:spacethefinalfrontier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:BattleSpace</para>
    ///
    /// labels<para>Space</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#spacethefinalfrontier">http://rdf.muninn-project.org/ontologies/military#spacethefinalfrontier</seealso>
    let spacethefinalfrontier =
        Prefixed_Name(mil, "spacethefinalfrontier") |> PrefixedName

    /// <summary>
    ///   <para>mil:toUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>To Unit</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#toUnit">http://rdf.muninn-project.org/ontologies/military#toUnit</seealso>
    let toUnit = Prefixed_Name(mil, "toUnit") |> PrefixedName
    /// <summary>
    ///   <para>mil:Nato_Ranks</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Nato_Ranks">http://rdf.muninn-project.org/ontologies/military#Nato_Ranks</seealso>
    let Nato_Ranks = Prefixed_Name(mil, "Nato_Ranks") |> PrefixedName
    /// <summary>
    ///   <para>mil:NatoRankOF-5</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>NATO Officer Rank OF-5</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-5">http://rdf.muninn-project.org/ontologies/military#NatoRankOF-5</seealso>
    let NatoRankOF_5 = Prefixed_Name(mil, "NatoRankOF-5") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_lieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Captain lieutenant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant</seealso>
    let Rank_Captain_lieutenant =
        Prefixed_Name(mil, "Rank_Captain_lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_lieutenant_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Captain lieutenant (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Germany</seealso>
    let Rank_Captain_lieutenant_Germany =
        Prefixed_Name(mil, "Rank_Captain_lieutenant_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_lieutenant_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Captain lieutenant (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Captain lieutenant (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Captain lieutenant (Union des républiques socialistes soviétiques)</para><para>Captain lieutenant (Unione Sovietica)</para><para>Captain lieutenant (Unión Soviética)</para><para>Captain lieutenant (União Soviética)</para><para>Captain lieutenant (Neuvostoliitto)</para><para>Captain lieutenant (Sovjetunionen)</para><para>Captain lieutenant (Sovjetunionen)</para><para>Captain lieutenant (Soviet Union)</para><para>Captain lieutenant (Sowjetunion)</para><para>Captain lieutenant (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Soviet_Union</seealso>
    let Rank_Captain_lieutenant_Soviet_Union =
        Prefixed_Name(mil, "Rank_Captain_lieutenant_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chief_Marshal</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ»Ð°Ð²Ð½ÑÐ¹ Ð¼Ð°ÑÑÐ°Ð» ÑÐ¾Ð´Ð° Ð²Ð¾Ð¹ÑÐº</para><para>Chief Marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal">http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal</seealso>
    let Rank_Chief_Marshal = Prefixed_Name(mil, "Rank_Chief_Marshal") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Oberstleutnant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant">http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant</seealso>
    let Rank_Oberstleutnant = Prefixed_Name(mil, "Rank_Oberstleutnant") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Sangsa</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sangsa</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa">http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa</seealso>
    let Rank_Sangsa = Prefixed_Name(mil, "Rank_Sangsa") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sangsa_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sangsa (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Sangsa (Korean demokraattinen kansantasavalta)</para><para>Sangsa (Korea PÃ³Ånocna)</para><para>Sangsa (Corea del Norte)</para><para>Sangsa (Coreia do Norte)</para><para>Sangsa (Corea del Nord)</para><para>Sangsa (Corée du Nord)</para><para>Sangsa (Noord-Korea)</para><para>Sangsa (North Korea)</para><para>Sangsa (Nord-Korea)</para><para>Sangsa (Nordkorea)</para><para>Sangsa (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_North_Korea</seealso>
    let Rank_Sangsa_North_Korea =
        Prefixed_Name(mil, "Rank_Sangsa_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Private_EnglishTradition</seealso>
    let Rank_Private_EnglishTradition =
        Prefixed_Name(mil, "Rank_Private_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant</seealso>
    let Rank_Regimental_Quartermaster_Sergeant =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_sergeant_major</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental sergeant major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major</seealso>
    let Rank_Regimental_sergeant_major =
        Prefixed_Name(mil, "Rank_Regimental_sergeant_major") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeant">http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeant</seealso>
    let _1AIFRankSergeant = Prefixed_Name(mil, "1AIFRankSergeant") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankSergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSergeant">http://rdf.muninn-project.org/ontologies/military#RankSergeant</seealso>
    let RankSergeant = Prefixed_Name(mil, "RankSergeant") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankSignaller</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Signaller</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSignaller">http://rdf.muninn-project.org/ontologies/military#RankSignaller</seealso>
    let RankSignaller = Prefixed_Name(mil, "RankSignaller") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankTrooper</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///
    /// labels<para>Trooper (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankTrooper">http://rdf.muninn-project.org/ontologies/military#1AIFRankTrooper</seealso>
    let _1AIFRankTrooper = Prefixed_Name(mil, "1AIFRankTrooper") |> PrefixedName
    /// <summary>
    ///   <para>mil:Cavalry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:ArmsType</para>
    ///
    /// labels<para>Kavallerie</para><para>Cavalerie</para><para>Equitata</para><para>Cavalry</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Cavalry">http://rdf.muninn-project.org/ontologies/military#Cavalry</seealso>
    let Cavalry = Prefixed_Name(mil, "Cavalry") |> PrefixedName
    /// <summary>
    ///   <para>mil:WarrantOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Officiers Mariniers</para><para>Warrant Officer</para><para>?</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#WarrantOfficer">http://rdf.muninn-project.org/ontologies/military#WarrantOfficer</seealso>
    let WarrantOfficer = Prefixed_Name(mil, "WarrantOfficer") |> PrefixedName
    /// <summary>
    ///   <para>mil:ActingRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Handelnden Rang (Militärischen)</para><para>Grade Intérimaire (Militare)</para><para>Acting Rank (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ActingRank">http://rdf.muninn-project.org/ontologies/military#ActingRank</seealso>
    let ActingRank = Prefixed_Name(mil, "ActingRank") |> PrefixedName
    /// <summary>
    ///   <para>mil:NamedAirForceUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Luftflotten der United States Air Force</para><para>KhÃ´ng lá»±c mang sá»</para><para>Força Aérea Numerada</para><para>Numbered Air Force</para><para>Numbered Air Force</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NamedAirForceUnit">http://rdf.muninn-project.org/ontologies/military#NamedAirForceUnit</seealso>
    let NamedAirForceUnit = Prefixed_Name(mil, "NamedAirForceUnit") |> PrefixedName
    /// <summary>
    ///   <para>mil:TacticalAirForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Luftstreitkräfte (taktisch)</para><para>Force Aérienne Tactique </para><para>Tactical Air Force</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#TacticalAirForce">http://rdf.muninn-project.org/ontologies/military#TacticalAirForce</seealso>
    let TacticalAirForce = Prefixed_Name(mil, "TacticalAirForce") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Detail (Air Force)</para><para></para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceDetail">http://rdf.muninn-project.org/ontologies/military#AirForceDetail</seealso>
    let AirForceDetail = Prefixed_Name(mil, "AirForceDetail") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Group (military aviation unit)</para><para>Groupe (Force Aérienne)</para><para>Gruppe (Luftfahrt)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceGroup">http://rdf.muninn-project.org/ontologies/military#AirForceGroup</seealso>
    let AirForceGroup = Prefixed_Name(mil, "AirForceGroup") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Type Armes (Military)</para><para>Arms Type(Military)</para><para>?</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmsType">http://rdf.muninn-project.org/ontologies/military#ArmsType</seealso>
    let ArmsType = Prefixed_Name(mil, "ArmsType") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryFlightUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Flight (military unit)</para><para>Flight (luchtmacht)</para><para>Escadrille</para><para>Phi Äá»i</para><para>Schwarm</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryFlightUnit">http://rdf.muninn-project.org/ontologies/military#MilitaryFlightUnit</seealso>
    let MilitaryFlightUnit = Prefixed_Name(mil, "MilitaryFlightUnit") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceWing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ²Ð¸Ð°ÑÐ¸Ð¾Ð½Ð½Ð¾Ðµ ÐºÑÑÐ»Ð¾</para><para>SkrzydÅo (oddziaÅ lotnictwa)</para><para>Wing (military aviation unit)</para><para>Stormo (unità militare)</para><para>Ving (militær enhet)</para><para>Wing (luchtmacht)</para><para>Ala (militar)</para><para>KhÃ´ng ÄoÃ n</para><para>Flygflottilj</para><para>Geschwader</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceWing">http://rdf.muninn-project.org/ontologies/military#AirForceWing</seealso>
    let AirForceWing = Prefixed_Name(mil, "AirForceWing") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Seaman_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Matelot</para><para>Seemann</para><para>Seaman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Seaman_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Seaman_EnglishTradition</seealso>
    let Rank_Seaman_EnglishTradition =
        Prefixed_Name(mil, "Rank_Seaman_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Anthypolochagos_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Anthypolochagos (ÐÑÐµÑÐ¸Ñ)</para><para>Anthypolochagos (Griechenland)</para><para>Anthypolochagos (Griekenland)</para><para>Anthypolochagos (Grekland)</para><para>Anthypolochagos (Kreikka)</para><para>Anthypolochagos (Grecja)</para><para>Anthypolochagos (Grecia)</para><para>Anthypolochagos (Hellas)</para><para>Anthypolochagos (Greece)</para><para>Anthypolochagos (Grecia)</para><para>Anthypolochagos (Grécia)</para><para>Anthypolochagos (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Greece</seealso>
    let Rank_Anthypolochagos_Greece =
        Prefixed_Name(mil, "Rank_Anthypolochagos_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///
    /// labels<para>Anthypolochagos (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Antisyntagmatarchis_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Antisyntagmatarchis (ÐÑÐµÑÐ¸Ñ)</para><para>Antisyntagmatarchis (Griechenland)</para><para>Antisyntagmatarchis (Griekenland)</para><para>Antisyntagmatarchis (Grekland)</para><para>Antisyntagmatarchis (Kreikka)</para><para>Antisyntagmatarchis (Grecia)</para><para>Antisyntagmatarchis (Greece)</para><para>Antisyntagmatarchis (Grécia)</para><para>Antisyntagmatarchis (Hellas)</para><para>Antisyntagmatarchis (Grecja)</para><para>Antisyntagmatarchis (Grecia)</para><para>Antisyntagmatarchis (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Greece</seealso>
    let Rank_Antisyntagmatarchis_Greece =
        Prefixed_Name(mil, "Rank_Antisyntagmatarchis_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Antisyntagmatarchis (Timocracy_of_Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Appointee_Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Appointee (ÐÑÐ°Ð»Ð¸Ñ)</para><para>Appointee (WÅochy)</para><para>Appointee (Italien)</para><para>Appointee (Italien)</para><para>Appointee (Italia)</para><para>Appointee (Italia)</para><para>Appointee (Italia)</para><para>Appointee (Italië)</para><para>Appuntato (Italia)</para><para>Appointee (Itália)</para><para>Appointé (Italie)</para><para>Appointee (Italy)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Italy">http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Italy</seealso>
    let Rank_Appointee_Italy =
        Prefixed_Name(mil, "Rank_Appointee_Italy") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Daffadar_British_India</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Daffadar</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar_British_India">http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar_British_India</seealso>
    let Rank_Daffadar_British_India =
        Prefixed_Name(mil, "Rank_Daffadar_British_India") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant</seealso>
    let Rank_Sergeant = Prefixed_Name(mil, "Rank_Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_Admiral</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ammiraglio di divisione</para><para>Divisional Admiral</para><para>Amiral de division</para><para>Divisieadmiraal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral</seealso>
    let Rank_Divisional_Admiral =
        Prefixed_Name(mil, "Rank_Divisional_Admiral") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_sergeant_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance Sergeant (Pays de Galles)</para><para>Lance Sergeant (País de Gales)</para><para>Lance Sergeant (Ð£ÑÐ»ÑÑ)</para><para>Lance Sergeant (Galles)</para><para>Lance Sergeant (Wales)</para><para>Lance Sergeant (Gales)</para><para>Lance Sergeant (Wales)</para><para>Lance Sergeant (Walia)</para><para>Lance Sergeant (Wales)</para><para>Lance Sergeant (Wales)</para><para>Lance Sergeant (Wales)</para><para>Lance Sergeant (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Wales</seealso>
    let Rank_Lance_sergeant_Wales =
        Prefixed_Name(mil, "Rank_Lance_sergeant_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Second_Corporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Second Corporal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal">http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal</seealso>
    let Rank_Second_Corporal =
        Prefixed_Name(mil, "Rank_Second_Corporal") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Second_Corporal_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Second Corporal (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_England">http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_England</seealso>
    let Rank_Second_Corporal_England =
        Prefixed_Name(mil, "Rank_Second_Corporal_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Second_Corporal_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Second Corporal (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Second Corporal (Schottland)</para><para>Second Corporal (Skotlanti)</para><para>Second Corporal (Skottland)</para><para>Second Corporal (Skottland)</para><para>Second Corporal (Schotland)</para><para>Second Corporal (Scotland)</para><para>Second Corporal (Escocia)</para><para>Second Corporal (Szkocja)</para><para>Second Corporal (Escócia)</para><para>Second Corporal (Écosse)</para><para>Second Corporal (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Scotland</seealso>
    let Rank_Second_Corporal_Scotland =
        Prefixed_Name(mil, "Rank_Second_Corporal_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Yesaul_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°ÑÐ» (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>EsauÅ (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Yesaul (Union des républiques socialistes soviétiques)</para><para>Yesaul (Unione Sovietica)</para><para>Yesaul (União Soviética)</para><para>Yesaul (Unión Soviética)</para><para>Yesaul (Neuvostoliitto)</para><para>Jesaul (Sovjetunionen)</para><para>Yesaul (Sovjetunionen)</para><para>Yesaul (Soviet Union)</para><para>Jessaul (Sowjetunion)</para><para>Yesaul (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Soviet_Union</seealso>
    let Rank_Yesaul_Soviet_Union =
        Prefixed_Name(mil, "Rank_Yesaul_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Yesaul_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÐ°ÑÐ» (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Yesaul (Oekraïne)</para><para>Jessaul (Ukraine)</para><para>Jesaul (Ukraina)</para><para>Yesaul (Ukraine)</para><para>Yesaul (Ukraina)</para><para>Yesaul (Ukraina)</para><para>Yesaul (Ukraine)</para><para>Yesaul (Ucrânia)</para><para>Yesaul (Ucrania)</para><para>Yesaul (Ucraina)</para><para>EsauÅ (Ukraina)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Ukraine</seealso>
    let Rank_Yesaul_Ukraine = Prefixed_Name(mil, "Rank_Yesaul_Ukraine") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Ypolochagos</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ypolochagos</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos">http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos</seealso>
    let Rank_Ypolochagos = Prefixed_Name(mil, "Rank_Ypolochagos") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ypolochagos_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ypolochagos (Griechenland)</para><para>Ypolochagos (ÐÑÐµÑÐ¸Ñ)</para><para>Ypolochagos (Griekenland)</para><para>Ypolochagos (Grekland)</para><para>Ypolochagos (Kreikka)</para><para>Ypolochagos (Grecia)</para><para>Ypolochagos (Greece)</para><para>Ypolochagos (Grecia)</para><para>Ypolochagos (Hellas)</para><para>Ypolochagos (Grécia)</para><para>Ypolochagos (Grecja)</para><para>Ypolochagos (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Greece</seealso>
    let Rank_Ypolochagos_Greece =
        Prefixed_Name(mil, "Rank_Ypolochagos_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ypolochagos_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ypolochagos (Timocracy_of_Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Ypolochagos_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Ypolochagos_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Regiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Regiment</para><para>Regiment</para><para>Régiment</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Regiment">http://rdf.muninn-project.org/ontologies/military#Regiment</seealso>
    let Regiment = Prefixed_Name(mil, "Regiment") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankWarrantOfficerClass2</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant Officer Class 2 (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficerClass2">http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficerClass2</seealso>
    let _1AIFRankWarrantOfficerClass2 =
        Prefixed_Name(mil, "1AIFRankWarrantOfficerClass2") |> PrefixedName

    /// <summary>
    ///   <para>mil:AirDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air Division</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirDivision">http://rdf.muninn-project.org/ontologies/military#AirDivision</seealso>
    let AirDivision = Prefixed_Name(mil, "AirDivision") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Command (Air Force)</para><para></para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceCommand">http://rdf.muninn-project.org/ontologies/military#AirForceCommand</seealso>
    let AirForceCommand = Prefixed_Name(mil, "AirForceCommand") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavalFleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Laivasto (sotilasyksikkö)</para><para>Flotte (Marine)</para><para>Flåte (marine)</para><para>Háº¡m Äá»i</para><para>Naval fleet</para><para>Ð¤Ð»Ð¾Ñ</para><para>LoÄstvo</para><para>Flotta</para><para>Flotte</para><para>Flotta</para><para>Frota</para><para>Flota</para><para>Flota</para><para>Flota</para><para>Vloot</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalFleet">http://rdf.muninn-project.org/ontologies/military#NavalFleet</seealso>
    let NavalFleet = Prefixed_Name(mil, "NavalFleet") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_lieutenant_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Captain lieutenant (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Captain lieutenant (Russland)</para><para>Captain lieutenant (Russland)</para><para>Captain lieutenant (Ryssland)</para><para>Captain lieutenant (Rusland)</para><para>Captain lieutenant (Venäjä)</para><para>Captain lieutenant (Russie)</para><para>Captain lieutenant (Russia)</para><para>Captain lieutenant (Rússia)</para><para>Captain lieutenant (Russia)</para><para>Captain lieutenant (Rusia)</para><para>Captain lieutenant (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Russia</seealso>
    let Rank_Captain_lieutenant_Russia =
        Prefixed_Name(mil, "Rank_Captain_lieutenant_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberstleutnant_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberstleutnant (Germany)</para><para>Oberstleutnant (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant_Germany</seealso>
    let Rank_Oberstleutnant_Germany =
        Prefixed_Name(mil, "Rank_Oberstleutnant_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankSergeantMajor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sergeant Major (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeantMajor">http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeantMajor</seealso>
    let _1AIFRankSergeantMajor =
        Prefixed_Name(mil, "1AIFRankSergeantMajor") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankSignaller</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///
    /// labels<para>Signaller (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSignaller">http://rdf.muninn-project.org/ontologies/military#1AIFRankSignaller</seealso>
    let _1AIFRankSignaller = Prefixed_Name(mil, "1AIFRankSignaller") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Trooper</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Trooper (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper">http://rdf.muninn-project.org/ontologies/military#Rank_Trooper</seealso>
    let Rank_Trooper = Prefixed_Name(mil, "Rank_Trooper") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stratarches_Byzantine_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Stratarches (ÐÐ¸Ð·Ð°Ð½ÑÐ¸Ð¹ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Stratarches (Cesarstwo BizantyÅskie)</para><para>Stratarches (Byzantinisches Reich)</para><para>Stratarches (Bysantin valtakunta)</para><para>Stratarches (Imperio bizantino)</para><para>Stratarches (Império Bizantino)</para><para>Stratarches (Bysantinska riket)</para><para>Stratarches (Byzantine Empire)</para><para>Stratarches (Byzantijnse Rijk)</para><para>Stratarches (Impero bizantino)</para><para>Stratarches (Empire byzantin)</para><para>Stratarches (Østromerriket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Byzantine_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Byzantine_Empire</seealso>
    let Rank_Stratarches_Byzantine_Empire =
        Prefixed_Name(mil, "Rank_Stratarches_Byzantine_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom</seealso>
    let Rank_Warrant_officer_United_Kingdom =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Warrant Officer (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Warrant Officer (Australië (land))</para><para>Warrant Officer (Australien)</para><para>Warrant Officer (Australien)</para><para>Warrant Officer (Australie)</para><para>Warrant Officer (Australia)</para><para>Warrant Officer (Australia)</para><para>Warrant Officer (Australia)</para><para>Warrant Officer (Australia)</para><para>Warrant Officer (Australia)</para><para>Warrant Officer (Austrália)</para><para>Warrant Officer (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Australia</seealso>
    let Rank_Warrant_officer_United_Kingdom_Australia =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:PostToUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#PostToUnit">http://rdf.muninn-project.org/ontologies/military#PostToUnit</seealso>
    let PostToUnit = Prefixed_Name(mil, "PostToUnit") |> PrefixedName

    /// <summary>
    ///   <para>mil:UnprivilegedCombatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Combatant non-privilégié</para><para>unprivilegierten Kämpfer</para><para>Unprivileged Combatant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#UnprivilegedCombatant">http://rdf.muninn-project.org/ontologies/military#UnprivilegedCombatant</seealso>
    let UnprivilegedCombatant =
        Prefixed_Name(mil, "UnprivilegedCombatant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Army_General_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð» Ð°ÑÐ¼Ð¸Ð¸ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Army General (Russia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia</seealso>
    let Rank_Army_General_Russia =
        Prefixed_Name(mil, "Rank_Army_General_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Army_General_Russia_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð» Ð°ÑÐ¼Ð¸Ð¸ (Ð Ð¾ÑÑÐ¸Ñ) (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Army General (Russia) (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Army General (Russia) (Union des républiques socialistes soviétiques)</para><para>Army General (Russia) (Unione Sovietica)</para><para>Army General (Russia) (União Soviética)</para><para>Army General (Russia) (Unión Soviética)</para><para>Army General (Russia) (Neuvostoliitto)</para><para>Army General (Russia) (Sovjetunionen)</para><para>Army General (Russia) (Sovjetunionen)</para><para>Army General (Russia) (Soviet Union)</para><para>Army General (Russia) (Sovjet-Unie)</para><para>Army General (Russia) (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Soviet_Union</seealso>
    let Rank_Army_General_Russia_Soviet_Union =
        Prefixed_Name(mil, "Rank_Army_General_Russia_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Aspirant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Aspirant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant">http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant</seealso>
    let Rank_Aspirant = Prefixed_Name(mil, "Rank_Aspirant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Aspirant_France</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Aspirant (France)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_France">http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_France</seealso>
    let Rank_Aspirant_France =
        Prefixed_Name(mil, "Rank_Aspirant_France") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Aspirant_Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Aspirant (Ð ÑÐ¼ÑÐ½Ð¸Ñ)</para><para>Aspirant (Roemenië)</para><para>Aspirant (Roumanie)</para><para>Aspirant (Rumänien)</para><para>Aspirant (Rumänien)</para><para>Aspirant (Romania)</para><para>Aspirant (Romania)</para><para>Aspirant (Romania)</para><para>Aspirant (Rumania)</para><para>Aspirant (Rumunia)</para><para>Aspirant (Roménia)</para><para>Aspirant (Romania)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania">http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania</seealso>
    let Rank_Aspirant_Romania =
        Prefixed_Name(mil, "Rank_Aspirant_Romania") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chowqzy</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¥Ð¾ÑÑÐ½Ð¶Ð¸Ð¹</para><para>ChorÄÅ¼y</para><para>ChorÄÅ¼y</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy">http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy</seealso>
    let Rank_Chowqzy = Prefixed_Name(mil, "Rank_Chowqzy") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_Major_General_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum Major General (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Drum Major General (Commonwealth delle nazioni)</para><para>Drum Major General (Mancomunidad de Naciones)</para><para>Drum Major General (Commonwealth of Nations)</para><para>Drum Major General (Commonwealth of Nations)</para><para>Drum Major General (Commonwealth of Nations)</para><para>Drum Major General (Gemenebest van Naties)</para><para>Drum Major General (Samveldet av nasjoner)</para><para>Drum Major General (Wspólnota Narodów)</para><para>Drum Major General (Kansainyhteisö)</para><para>Drum Major General (Commonwealth)</para><para>Drum Major General (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Commonwealth_of_Nations</seealso>
    let Rank_Drum_Major_General_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Drum_Major_General_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_Major_General_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Drum Major General (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Drum Major General (Schottland)</para><para>Drum Major General (Schotland)</para><para>Drum Major General (Skotlanti)</para><para>Drum Major General (Skottland)</para><para>Drum Major General (Skottland)</para><para>Drum Major General (Scotland)</para><para>Drum Major General (Szkocja)</para><para>Drum Major General (Escócia)</para><para>Drum Major General (Escocia)</para><para>Drum Major General (Écosse)</para><para>Drum Major General (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Scotland</seealso>
    let Rank_Drum_Major_General_Scotland =
        Prefixed_Name(mil, "Rank_Drum_Major_General_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_Major_General_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum Major General (Pays de Galles)</para><para>Drum Major General (País de Gales)</para><para>Drum Major General (Ð£ÑÐ»ÑÑ)</para><para>Drum Major General (Galles)</para><para>Drum Major General (Wales)</para><para>Drum Major General (Walia)</para><para>Drum Major General (Gales)</para><para>Drum Major General (Wales)</para><para>Drum Major General (Wales)</para><para>Drum Major General (Wales)</para><para>Drum Major General (Wales)</para><para>Drum Major General (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Wales</seealso>
    let Rank_Drum_Major_General_Wales =
        Prefixed_Name(mil, "Rank_Drum_Major_General_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hipparchus_Cavalry_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¸Ð¿Ð¿Ð°ÑÑ (Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸Ðº) (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Hipparchus (cavalry officer) (Macedonia (ancient kingdom))</para><para>Hiparco (oficial de caballería) (Reino de Macedonia)</para><para>Hipparchus (cavalry officer) (StaroÅ¼ytna Macedonia)</para><para>Hipparchus (cavalry officer) (Makedonian valtakunta)</para><para>Hipparchus (cavalry officer) (Royaume de Macédoine)</para><para>Hipparchus (cavalry officer) (Oldtidens Makedonia)</para><para>Hipparchus (cavalry officer) (Regno di Macedonia)</para><para>Hipparchus (cavalry officer) (Macedónia Antiga)</para><para>Hipparchos (Macedonië (oudheid))</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Macedonia</seealso>
    let Rank_Hipparchus_Cavalry_Macedonia =
        Prefixed_Name(mil, "Rank_Hipparchus_Cavalry_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungsa</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Jungsa</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa">http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa</seealso>
    let Rank_Jungsa = Prefixed_Name(mil, "Rank_Jungsa") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungsa_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Jungsa (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Jungsa (Korean demokraattinen kansantasavalta)</para><para>Jungsa (Korea PÃ³Ånocna)</para><para>Jungsa (Corea del Norte)</para><para>Jungsa (Coreia do Norte)</para><para>Jungsa (Corea del Nord)</para><para>Jungsa (Corée du Nord)</para><para>Jungsa (Noord-Korea)</para><para>Jungsa (North Korea)</para><para>Jungsa (Nord-Korea)</para><para>Jungsa (Nordkorea)</para><para>Jungsa (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_North_Korea</seealso>
    let Rank_Jungsa_North_Korea =
        Prefixed_Name(mil, "Rank_Jungsa_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungsa_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Jungsa (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Jungsa (Korea PoÅudniowa)</para><para>Jungsa (Korean tasavalta)</para><para>Jungsa (Coreia do Sul)</para><para>Jungsa (Corea del Sud)</para><para>Jungsa (Corea del Sur)</para><para>Jungsa (Corée du Sud)</para><para>Jungsa (South Korea)</para><para>Jungsa (Zuid-Korea)</para><para>Jungsa (Sør-Korea)</para><para>Jungsa (Südkorea)</para><para>Jungsa (Sydkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_South_Korea</seealso>
    let Rank_Jungsa_South_Korea =
        Prefixed_Name(mil, "Rank_Jungsa_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungwi</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Jungwi</para><para>Jungwi</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi">http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi</seealso>
    let Rank_Jungwi = Prefixed_Name(mil, "Rank_Jungwi") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungwi_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Jungwi (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Jungwi (Korean demokraattinen kansantasavalta)</para><para>Jungwi (Korea PÃ³Ånocna)</para><para>Jungwi (Corea del Norte)</para><para>Jungwi (Coreia do Norte)</para><para>Jungwi (Corea del Nord)</para><para>Jungwi (Corée du Nord)</para><para>Jungwi (North Korea)</para><para>Jungwi (Noord-Korea)</para><para>Jungwi (Nord-Korea)</para><para>Jungwi (Nordkorea)</para><para>Jungwi (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_North_Korea</seealso>
    let Rank_Jungwi_North_Korea =
        Prefixed_Name(mil, "Rank_Jungwi_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Jungwi_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Jungwi (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Jungwi (Korea PoÅudniowa)</para><para>Jungwi (Korean tasavalta)</para><para>Jungwi (Corea del Sur)</para><para>Jungwi (Coreia do Sul)</para><para>Jungwi (Corea del Sud)</para><para>Jungwi (Corée du Sud)</para><para>Jungwi (South Korea)</para><para>Jungwi (Zuid-Korea)</para><para>Jungwi (Sør-Korea)</para><para>Jungwi (Sydkorea)</para><para>Jungwi (Südkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_South_Korea</seealso>
    let Rank_Jungwi_South_Korea =
        Prefixed_Name(mil, "Rank_Jungwi_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junior_sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Junior Sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant</seealso>
    let Rank_Junior_sergeant =
        Prefixed_Name(mil, "Rank_Junior_sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junior_sergeant_Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Junior Sergeant (Ð­ÑÑÐ¾Ð½Ð¸Ñ)</para><para>Junior Sergeant (Estónia)</para><para>Junior Sergeant (Estonia)</para><para>Junior Sergeant (Estonia)</para><para>Junior Sergeant (Estonia)</para><para>Junior Sergeant (Estland)</para><para>Junior Sergeant (Estland)</para><para>Junior Sergeant (Estonie)</para><para>Junior Sergeant (Estonia)</para><para>Junior Sergeant (Estland)</para><para>Junior Sergeant (Estland)</para><para>Junior Sergeant (Viro)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Estonia">http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Estonia</seealso>
    let Rank_Junior_sergeant_Estonia =
        Prefixed_Name(mil, "Rank_Junior_sergeant_Estonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Officer_cadet_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Officer cadet</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Officer_cadet_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Officer_cadet_EnglishTradition</seealso>
    let Rank_Officer_cadet_EnglishTradition =
        Prefixed_Name(mil, "Rank_Officer_cadet_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_EnglishTradition</seealso>
    let Rank_Warrant_officer_EnglishTradition =
        Prefixed_Name(mil, "Rank_Warrant_officer_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Mirliva</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Mirliva</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva">http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva</seealso>
    let Rank_Mirliva = Prefixed_Name(mil, "Rank_Mirliva") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Mirliva_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Mirliva (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>Mirliva (Cossack Hetmanate)</para><para>Mirliva (Hetmanat cosaque)</para><para>Mirliva (Hetmanato cosaco)</para><para>Mirliva (HetmaÅszczyzna)</para><para>Mirliva (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Cossack_Hetmanate</seealso>
    let Rank_Mirliva_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Mirliva_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Mirliva_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Mirliva (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Mirliva (Imperium osmaÅskie)</para><para>Mirliva (Osmanien valtakunta)</para><para>Mirliva (Osmanisches Reich)</para><para>Mirliva (Det osmanske rike)</para><para>Mirliva (Ottomaanse Rijk)</para><para>Mirliva (Imperio otomano)</para><para>Mirliva (Impero ottomano)</para><para>Mirliva (Império Otomano)</para><para>Mirliva (Empire ottoman)</para><para>Mirliva (Ottoman Empire)</para><para>Mirliva (Osmanska riket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Ottoman_Empire</seealso>
    let Rank_Mirliva_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Mirliva_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Musir</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>MÃ¼Åir</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir">http://rdf.muninn-project.org/ontologies/military#Rank_Musir</seealso>
    let Rank_Musir = Prefixed_Name(mil, "Rank_Musir") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Musir_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>MÃ¼Åir (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>MÃ¼Åir (Cossack Hetmanate)</para><para>MÃ¼Åir (Hetmanato cosaco)</para><para>MÃ¼Åir (Hetmanat cosaque)</para><para>MÃ¼Åir (HetmaÅszczyzna)</para><para>MÃ¼Åir (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Cossack_Hetmanate</seealso>
    let Rank_Musir_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Musir_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Musir_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>MÃ¼Åir (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>MÃ¼Åir (Osmanien valtakunta)</para><para>MÃ¼Åir (Imperium osmaÅskie)</para><para>MÃ¼Åir (Det osmanske rike)</para><para>MÃ¼Åir (Osmanisches Reich)</para><para>MÃ¼Åir (ImpÃ©rio Otomano)</para><para>MÃ¼Åir (Imperio otomano)</para><para>MÃ¼Åir (Ottomaanse Rijk)</para><para>MÃ¼Åir (Impero ottomano)</para><para>MÃ¼Åir (Osmanska riket)</para><para>MÃ¼Åir (Empire ottoman)</para><para>MÃ¼Åir (Ottoman Empire)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Ottoman_Empire</seealso>
    let Rank_Musir_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Musir_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitan_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¨ÑÐ°Ð±Ñ-ÐºÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Sztabskapitan (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Stabskapitän (Union des républiques socialistes soviétiques)</para><para>Stabskapitän (Unione Sovietica)</para><para>Stabskapitän (União Soviética)</para><para>Stabskapitän (Unión Soviética)</para><para>Stabskapitän (Sovjetunionen)</para><para>Alikapteeni (Neuvostoliitto)</para><para>Stabskapitän (Sovjetunionen)</para><para>Stabskapitän (Soviet Union)</para><para>Stabskapitän (Sowjetunion)</para><para>Stabskapitän (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Soviet_Union</seealso>
    let Rank_Stabskapitan_Soviet_Union =
        Prefixed_Name(mil, "Rank_Stabskapitan_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitanleutnant_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Stabskapitänleutnant (Germany)</para><para>Stabskapitänleutnant (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant_Germany</seealso>
    let Rank_Stabskapitanleutnant_Germany =
        Prefixed_Name(mil, "Rank_Stabskapitanleutnant_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitanleutnant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant</seealso>
    let Rank_Stabskapitanleutnant =
        Prefixed_Name(mil, "Rank_Stabskapitanleutnant") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Corporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Corporal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal</seealso>
    let Rank_Staff_Corporal = Prefixed_Name(mil, "Rank_Staff_Corporal") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Corporal_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Corporal (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_England">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_England</seealso>
    let Rank_Staff_Corporal_England =
        Prefixed_Name(mil, "Rank_Staff_Corporal_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Corporal_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Corporal (Pays de Galles)</para><para>Staff Corporal (País de Gales)</para><para>Staff Corporal (Ð£ÑÐ»ÑÑ)</para><para>Staff Corporal (Galles)</para><para>Staff Corporal (Gales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Wales)</para><para>Staff Corporal (Walia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Wales</seealso>
    let Rank_Staff_Corporal_Wales =
        Prefixed_Name(mil, "Rank_Staff_Corporal_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Sergeant_Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Staff Sergeant Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major</seealso>
    let Rank_Staff_Sergeant_Major =
        Prefixed_Name(mil, "Rank_Staff_Sergeant_Major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Sergeant_Major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Sergeant Major (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_England</seealso>
    let Rank_Staff_Sergeant_Major_England =
        Prefixed_Name(mil, "Rank_Staff_Sergeant_Major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Sergeant_Major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Sergeant Major (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Staff Sergeant Major (Schottland)</para><para>Staff Sergeant Major (Schotland)</para><para>Staff Sergeant Major (Skottland)</para><para>Staff Sergeant Major (Skottland)</para><para>Staff Sergeant Major (Skotlanti)</para><para>Staff Sergeant Major (Scotland)</para><para>Staff Sergeant Major (Escócia)</para><para>Staff Sergeant Major (Escocia)</para><para>Staff Sergeant Major (Szkocja)</para><para>Staff Sergeant Major (Écosse)</para><para>Staff Sergeant Major (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Scotland</seealso>
    let Rank_Staff_Sergeant_Major_Scotland =
        Prefixed_Name(mil, "Rank_Staff_Sergeant_Major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Veebel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Veebel</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel">http://rdf.muninn-project.org/ontologies/military#Rank_Veebel</seealso>
    let Rank_Veebel = Prefixed_Name(mil, "Rank_Veebel") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Veebel_Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Veebel (Ð­ÑÑÐ¾Ð½Ð¸Ñ)</para><para>Veebel (Estonia)</para><para>Veebel (Estonie)</para><para>Veebel (Estonia)</para><para>Veebel (Estonia)</para><para>Veebel (Estonia)</para><para>Veebel (Estland)</para><para>Veebel (Estland)</para><para>Veebel (Estland)</para><para>Veebel (Estland)</para><para>Veebel (Estónia)</para><para>Veebel (Viro)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Estonia">http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Estonia</seealso>
    let Rank_Veebel_Estonia = Prefixed_Name(mil, "Rank_Veebel_Estonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Veebel_Republic_of_Estonia_1920-1940</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Veebel (Republic of Estonia, 1920-1940)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Republic_of_Estonia_1920-1940">http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Republic_of_Estonia_1920-1940</seealso>
    let Rank_Veebel_Republic_of_Estonia_1920_1940 =
        Prefixed_Name(mil, "Rank_Veebel_Republic_of_Estonia_1920-1940") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRank2ndCorporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///
    /// labels<para>2nd Corporal (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndCorporal">http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndCorporal</seealso>
    let _1AIFRank2ndCorporal = Prefixed_Name(mil, "1AIFRank2ndCorporal") |> PrefixedName
    /// <summary>
    ///   <para>mil:rankOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Rank used by</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#rankOf">http://rdf.muninn-project.org/ontologies/military#rankOf</seealso>
    let rankOf = Prefixed_Name(mil, "rankOf") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigadier_general</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Brigadier general</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general">http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general</seealso>
    let Rank_Brigadier_general =
        Prefixed_Name(mil, "Rank_Brigadier_general") |> PrefixedName

    /// <summary>
    ///   <para>mil:Campaign</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Campaign">http://rdf.muninn-project.org/ontologies/military#Campaign</seealso>
    let Campaign = Prefixed_Name(mil, "Campaign") |> PrefixedName
    /// <summary>
    ///   <para>mil:CarrierBattleGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ²Ð¸Ð°Ð½Ð¾ÑÐ½Ð°Ñ ÑÐ´Ð°ÑÐ½Ð°Ñ Ð³ÑÑÐ¿Ð¿Ð°</para><para>Gruppo da battaglia di una portaerei</para><para>Flugzeugträgerkampfgruppe</para><para>Carrier battle group</para><para>Carrier Strike Group</para><para>Groupe aéronaval</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CarrierBattleGroup">http://rdf.muninn-project.org/ontologies/military#CarrierBattleGroup</seealso>
    let CarrierBattleGroup = Prefixed_Name(mil, "CarrierBattleGroup") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Battery_sergeant_major</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Battery Sergeant Major</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Battery_sergeant_major">http://rdf.muninn-project.org/ontologies/military#Rank_Battery_sergeant_major</seealso>
    let Rank_Battery_sergeant_major =
        Prefixed_Name(mil, "Rank_Battery_sergeant_major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Birinci_Ferik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Birinci Ferik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik">http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik</seealso>
    let Rank_Birinci_Ferik = Prefixed_Name(mil, "Rank_Birinci_Ferik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Birinci_Ferik_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Birinci Ferik (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>Birinci Ferik (Cossack Hetmanate)</para><para>Birinci Ferik (Hetmanato cosaco)</para><para>Birinci Ferik (Hetmanat cosaque)</para><para>Birinci Ferik (HetmaÅszczyzna)</para><para>Birinci Ferik (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Cossack_Hetmanate</seealso>
    let Rank_Birinci_Ferik_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Birinci_Ferik_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Birinci_Ferik_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Birinci Ferik (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Birinci Ferik (Imperium osmaÅskie)</para><para>Birinci Ferik (Osmanien valtakunta)</para><para>Birinci Ferik (Osmanisches Reich)</para><para>Birinci Ferik (Det osmanske rike)</para><para>Birinci Ferik (Ottomaanse Rijk)</para><para>Birinci Ferik (Império Otomano)</para><para>Birinci Ferik (Imperio otomano)</para><para>Birinci Ferik (Impero ottomano)</para><para>Birinci Ferik (Empire ottoman)</para><para>Birinci Ferik (Osmanska riket)</para><para>Birinci Ferik (Ottoman Empire)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Ottoman_Empire</seealso>
    let Rank_Birinci_Ferik_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Birinci_Ferik_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Birinci_Ferik_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Birinci Ferik (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>Birinci Ferik (Repubblica delle Sette Isole Unite)</para><para>Birinci Ferik (Republiek van de Zeven Eilanden)</para><para>Birinci Ferik (República de las Islas Jónicas)</para><para>Birinci Ferik (République des Sept-Îles)</para><para>Birinci Ferik (Republika Siedmiu Wysp)</para><para>Birinci Ferik (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Septinsular_Republic</seealso>
    let Rank_Birinci_Ferik_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Birinci_Ferik_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bombardier_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±Ð°ÑÐ´Ð¸Ñ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Bombardier (rank) (Australië (land))</para><para>Bombardier (stopieÅ) (Australia)</para><para>Bombardier (rank) (Australien)</para><para>Bombardier (rank) (Australien)</para><para>Bombardier (rank) (Australia)</para><para>Bombardier (rank) (Australie)</para><para>Bombardier (rank) (Australia)</para><para>Bombardier (rank) (Australia)</para><para>Bombardier (rank) (Australia)</para><para>Bombardier (rank) (Australia)</para><para>Bombardier (rank) (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Australia</seealso>
    let Rank_Bombardier_Australia =
        Prefixed_Name(mil, "Rank_Bombardier_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bombardier_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_%28rank%29">http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_%28rank%29</seealso>
    let ``Rank_Bombardier_%28rank%29`` =
        Prefixed_Name(mil, "Rank_Bombardier_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bombardier_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±Ð°ÑÐ´Ð¸Ñ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ, Canada)</para><para>Bombardier (stopieÅ, Canada)</para><para>Bombardier (rank, Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Canada</seealso>
    let Rank_Bombardier_Canada =
        Prefixed_Name(mil, "Rank_Bombardier_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bombardier_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±Ð°ÑÐ´Ð¸Ñ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ) (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Bombardier (rank) (Commonwealth delle nazioni)</para><para>Bombardier (rank) (Mancomunidad de Naciones)</para><para>Bombardier (rank) (Commonwealth of Nations)</para><para>Bombardier (rank) (Commonwealth of Nations)</para><para>Bombardier (stopieÅ) (WspÃ³lnota NarodÃ³w)</para><para>Bombardier (rank) (Commonwealth of Nations)</para><para>Bombardier (rank) (Gemenebest van Naties)</para><para>Bombardier (rank) (Samveldet av nasjoner)</para><para>Bombardier (rank) (Kansainyhteisö)</para><para>Bombardier (rank) (Commonwealth)</para><para>Bombardier (rank) (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Commonwealth_of_Nations</seealso>
    let Rank_Bombardier_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Bombardier_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bootsmann</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÐ¼Ð°Ð½</para><para>Bootsmann</para><para>Bootsmann</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann">http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann</seealso>
    let Rank_Bootsmann = Prefixed_Name(mil, "Rank_Bootsmann") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bootsmann_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÐ¼Ð°Ð½ (Germany)</para><para>Bootsmann (Germany)</para><para>Bootsmann (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Germany</seealso>
    let Rank_Bootsmann_Germany =
        Prefixed_Name(mil, "Rank_Bootsmann_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bootsmann_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÐ¼Ð°Ð½ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Bootsmann (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Bootsmann (Union des républiques socialistes soviétiques)</para><para>Bootsmann (Unione Sovietica)</para><para>Bootsmann (Unión Soviética)</para><para>Bootsmann (União Soviética)</para><para>Bootsmann (Neuvostoliitto)</para><para>Bootsmann (Sovjetunionen)</para><para>Bootsmann (Sovjetunionen)</para><para>Bootsmann (Soviet Union)</para><para>Bootsmann (Sowjetunion)</para><para>Bootsmann (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Soviet_Union</seealso>
    let Rank_Bootsmann_Soviet_Union =
        Prefixed_Name(mil, "Rank_Bootsmann_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigade_General</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Brigade General</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General">http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General</seealso>
    let Rank_Brigade_General =
        Prefixed_Name(mil, "Rank_Brigade_General") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigade_General_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Brigade General (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Brigade General (Australië (land))</para><para>Brigade General (Australien)</para><para>Brigade General (Australien)</para><para>Brigade General (Austrália)</para><para>Brigade General (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Australia</seealso>
    let Rank_Brigade_General_Australia =
        Prefixed_Name(mil, "Rank_Brigade_General_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigade_General_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Brigade General (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Canada</seealso>
    let Rank_Brigade_General_Canada =
        Prefixed_Name(mil, "Rank_Brigade_General_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ferik_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ferik (rank) (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Ferik (rank) (Osmanien valtakunta)</para><para>Ferik (rank) (Imperium osmaÅskie)</para><para>Ferik (rank) (Det osmanske rike)</para><para>Ferik (rank) (Osmanisches Reich)</para><para>Ferik (rank) (Império Otomano)</para><para>Ferik (rank) (Ottomaanse Rijk)</para><para>Ferik (rank) (Impero ottomano)</para><para>Ferik (rank) (Imperio otomano)</para><para>Ferik (rank) (Ottoman Empire)</para><para>Ferik (rank) (Osmanska riket)</para><para>Ferik (rank) (Empire ottoman)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Ottoman_Empire</seealso>
    let Rank_Ferik_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Ferik_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ferik_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ferik (rank) (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>Ferik (rank) (Repubblica delle Sette Isole Unite)</para><para>Ferik (rank) (Republiek van de Zeven Eilanden)</para><para>Ferik (rank) (República de las Islas Jónicas)</para><para>Ferik (rank) (République des Sept-Îles)</para><para>Ferik (rank) (Republika Siedmiu Wysp)</para><para>Ferik (rank) (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Septinsular_Republic</seealso>
    let Rank_Ferik_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Ferik_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Fleet_Board</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Fleet Board</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board">http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board</seealso>
    let Rank_Fleet_Board = Prefixed_Name(mil, "Rank_Fleet_Board") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Fleet_Board_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Fleet Board (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_England">http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_England</seealso>
    let Rank_Fleet_Board_England =
        Prefixed_Name(mil, "Rank_Fleet_Board_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Fleet_Board_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Fleet Board (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Fleet Board (Schottland)</para><para>Fleet Board (Skottland)</para><para>Fleet Board (Skotlanti)</para><para>Fleet Board (Schotland)</para><para>Fleet Board (Skottland)</para><para>Fleet Board (Scotland)</para><para>Fleet Board (Escocia)</para><para>Fleet Board (Szkocja)</para><para>Fleet Board (Escócia)</para><para>Fleet Board (Écosse)</para><para>Fleet Board (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Scotland</seealso>
    let Rank_Fleet_Board_Scotland =
        Prefixed_Name(mil, "Rank_Fleet_Board_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Poruchik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÑÑÐ¸Ðº</para><para>Porutschik</para><para>Poroetsjik</para><para>PoruÄik</para><para>Poruchik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik">http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik</seealso>
    let Rank_Poruchik = Prefixed_Name(mil, "Rank_Poruchik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Poruchik_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾ÑÑÑÐ¸Ðº (Poland)</para><para>Poroetsjik (Poland)</para><para>Porutschik (Poland)</para><para>PoruÄik (Poland)</para><para>Poruchik (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Poland</seealso>
    let Rank_Poruchik_Poland =
        Prefixed_Name(mil, "Rank_Poruchik_Poland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Poruchik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾ÑÑÑÐ¸Ðº (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Porutschik (Russland)</para><para>Poroetsjik (Rusland)</para><para>Poruchik (Ryssland)</para><para>Poruchik (Russland)</para><para>Poruchik (Rússia)</para><para>Poruchik (Russia)</para><para>Poruchik (Russie)</para><para>PoruÄik (Russia)</para><para>Poruchik (Venäjä)</para><para>Poruchik (Rosja)</para><para>Poruchik (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Russia</seealso>
    let Rank_Poruchik_Russia =
        Prefixed_Name(mil, "Rank_Poruchik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Poruchik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÑÑÐ¸Ðº (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Poruchik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Poruchik (Union des républiques socialistes soviétiques)</para><para>PoruÄik (Unione Sovietica)</para><para>Poruchik (Unión Soviética)</para><para>Poruchik (União Soviética)</para><para>Poruchik (Neuvostoliitto)</para><para>Poruchik (Sovjetunionen)</para><para>Porutschik (Sowjetunion)</para><para>Poroetsjik (Sovjet-Unie)</para><para>Poruchik (Sovjetunionen)</para><para>Poruchik (Soviet Union)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Soviet_Union</seealso>
    let Rank_Poruchik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Poruchik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Praporshchik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº</para><para>Praporshchik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik">http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik</seealso>
    let Rank_Praporshchik = Prefixed_Name(mil, "Rank_Praporshchik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Praporshchik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Praporshchik (Ryssland)</para><para>Praporshchik (Russland)</para><para>Praporshchik (Russland)</para><para>Praporshchik (Rusland)</para><para>Praporshchik (Russia)</para><para>Praporshchik (Russie)</para><para>Praporshchik (Rússia)</para><para>Praporshchik (Venäjä)</para><para>Praporshchik (Russia)</para><para>Praporshchik (Rosja)</para><para>Praporshchik (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Russia</seealso>
    let Rank_Praporshchik_Russia =
        Prefixed_Name(mil, "Rank_Praporshchik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Private (Dienstgrad)</para><para>Soldat (Dienstgrad)</para><para>Deuxième classe</para><para>Soldat (grade)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹</para><para>Private (rank)</para><para>Soldado raso</para><para>Menig (grad)</para><para>Szeregowy</para><para>Menig 1kl</para><para>Sotamies</para><para>Menig</para><para>Menig</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private">http://rdf.muninn-project.org/ontologies/military#Rank_Private</seealso>
    let Rank_Private = Prefixed_Name(mil, "Rank_Private") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Private (Dienstgrad)Soldat (Dienstgrad) (Australien)</para><para>Deuxième classeSoldat (grade) (Australie)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Private (rank) (Australië (land))</para><para>Menig (grad)Menig (Australia)</para><para>Menig 1klMenig (Australien)</para><para>Private (rank) (Australia)</para><para>Private (rank) (Australia)</para><para>Private (rank) (Austrália)</para><para>Soldado raso (Australia)</para><para>Szeregowy (Australia)</para><para>Sotamies (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Private_Australia</seealso>
    let Rank_Private_Australia =
        Prefixed_Name(mil, "Rank_Private_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_Sergeant_Major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff Sergeant Major (Pays de Galles)</para><para>Staff Sergeant Major (País de Gales)</para><para>Staff Sergeant Major (Ð£ÑÐ»ÑÑ)</para><para>Staff Sergeant Major (Galles)</para><para>Staff Sergeant Major (Walia)</para><para>Staff Sergeant Major (Wales)</para><para>Staff Sergeant Major (Wales)</para><para>Staff Sergeant Major (Wales)</para><para>Staff Sergeant Major (Wales)</para><para>Staff Sergeant Major (Gales)</para><para>Staff Sergeant Major (Wales)</para><para>Staff Sergeant Major (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Wales</seealso>
    let Rank_Staff_Sergeant_Major_Wales =
        Prefixed_Name(mil, "Rank_Staff_Sergeant_Major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_sergeant_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff sergeant (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Staff sergeant (Australië (land))</para><para>Staff sergeant (Australien)</para><para>Staff sergeant (Australien)</para><para>Staff sergeant (Australia)</para><para>Staff sergeant (Australia)</para><para>Staff sergeant (Australia)</para><para>Staff sergeant (Australia)</para><para>Staff sergeant (Australie)</para><para>Staff sergeant (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Australia</seealso>
    let Rank_Staff_sergeant_Australia =
        Prefixed_Name(mil, "Rank_Staff_sergeant_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_Coast</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vice-Admiral of the Coast</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast</seealso>
    let Rank_Vice_Admiral_of_the_Coast =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_Coast") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_Coast_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the Coast (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_England">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_England</seealso>
    let Rank_Vice_Admiral_of_the_Coast_England =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_Coast_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_Coast_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the Coast (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Vice-Admiral of the Coast (Schottland)</para><para>Vice-Admiral of the Coast (Skottland)</para><para>Vice-Admiral of the Coast (Skottland)</para><para>Vice-Admiral of the Coast (Skotlanti)</para><para>Vice-Admiral of the Coast (Schotland)</para><para>Vice-Admiral of the Coast (Scotland)</para><para>Vice-Admiral of the Coast (Escócia)</para><para>Vice-Admiral of the Coast (Escocia)</para><para>Vice-Admiral of the Coast (Szkocja)</para><para>Vice-Admiral of the Coast (Écosse)</para><para>Vice-Admiral of the Coast (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Scotland</seealso>
    let Rank_Vice_Admiral_of_the_Coast_Scotland =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_Coast_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_Coast_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the Coast (Pays de Galles)</para><para>Vice-Admiral of the Coast (País de Gales)</para><para>Vice-Admiral of the Coast (Ð£ÑÐ»ÑÑ)</para><para>Vice-Admiral of the Coast (Galles)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Walia)</para><para>Vice-Admiral of the Coast (Wales)</para><para>Vice-Admiral of the Coast (Gales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Wales</seealso>
    let Rank_Vice_Admiral_of_the_Coast_Wales =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_Coast_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:FightsPrimarilyInAir</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:BattleSpace</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air (Battleground)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyInAir">http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyInAir</seealso>
    let FightsPrimarilyInAir =
        Prefixed_Name(mil, "FightsPrimarilyInAir") |> PrefixedName

    /// <summary>
    ///   <para>mil:Squadron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Squadron (unit)</para><para>Schwadron</para><para>Escadron</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Squadron">http://rdf.muninn-project.org/ontologies/military#Squadron</seealso>
    let Squadron = Prefixed_Name(mil, "Squadron") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Station (Force Aérienne)</para><para>Station (Luftfahrt)</para><para>Station (Air Force)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceStation">http://rdf.muninn-project.org/ontologies/military#AirForceStation</seealso>
    let AirForceStation = Prefixed_Name(mil, "AirForceStation") |> PrefixedName
    /// <summary>
    ///   <para>mil:AirForceStationRAF</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Royal Air Force station</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceStationRAF">http://rdf.muninn-project.org/ontologies/military#AirForceStationRAF</seealso>
    let AirForceStationRAF = Prefixed_Name(mil, "AirForceStationRAF") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Havildar</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>à¤¹à¤µà¤¿à¤²à¤¦à¤¾à¤°</para><para>Havildar</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar">http://rdf.muninn-project.org/ontologies/military#Rank_Havildar</seealso>
    let Rank_Havildar = Prefixed_Name(mil, "Rank_Havildar") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hasa_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Hasa (Korean military) (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Hasa (Korean military) (Korea PoÅudniowa)</para><para>Hasa (Korean military) (Korean tasavalta)</para><para>Hasa (Korean military) (Coreia do Sul)</para><para>Hasa (Korean military) (Corea del Sud)</para><para>Hasa (Korean military) (Corea del Sur)</para><para>Hasa (Korean military) (Corée du Sud)</para><para>Hasa (Korean military) (South Korea)</para><para>Hasa (Korean military) (Zuid-Korea)</para><para>Hasa (Korean military) (Sør-Korea)</para><para>Hasa (Korean military) (Sydkorea)</para><para>Hasa (Korean military) (Südkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_South_Korea</seealso>
    let Rank_Hasa_South_Korea =
        Prefixed_Name(mil, "Rank_Hasa_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Havildar_British_India</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>à¤¹à¤µà¤¿à¤²à¤¦à¤¾à¤°</para><para>Havildar</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar_British_India">http://rdf.muninn-project.org/ontologies/military#Rank_Havildar_British_India</seealso>
    let Rank_Havildar_British_India =
        Prefixed_Name(mil, "Rank_Havildar_British_India") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hetman</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÑÐ¼Ð°Ð½</para><para>Hetmani</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para><para>Hetman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman">http://rdf.muninn-project.org/ontologies/military#Rank_Hetman</seealso>
    let Rank_Hetman = Prefixed_Name(mil, "Rank_Hetman") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tagmatarchis_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Tagmatarchis (Griechenland)</para><para>Tagmatarchis (ÐÑÐµÑÐ¸Ñ)</para><para>Tagmatarchis (Griekenland)</para><para>Tagmatarchis (Grekland)</para><para>Tagmatarchis (Kreikka)</para><para>Tagmatarchis (Hellas)</para><para>Tagmatarchis (Greece)</para><para>Tagmatarchis (Grecia)</para><para>Tagmatarchis (Grécia)</para><para>Tagmatarchis (Grecja)</para><para>Tagmatarchis (Grecia)</para><para>Tagmatarchis (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Greece</seealso>
    let Rank_Tagmatarchis_Greece =
        Prefixed_Name(mil, "Rank_Tagmatarchis_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:AirForceSquadron</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ð­ÑÐºÐ°Ð´ÑÐ¸Ð»ÑÑ</para><para>Laivue (ilmavoimat)</para><para>Squadron (aviation)</para><para>Staffel (Militär)</para><para>Esquadrilha</para><para>Escuadrilla</para><para>Esquadrilla</para><para>Phi ÄoÃ n</para><para>Squadron</para><para>Skvadron</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AirForceSquadron">http://rdf.muninn-project.org/ontologies/military#AirForceSquadron</seealso>
    let AirForceSquadron = Prefixed_Name(mil, "AirForceSquadron") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryServiceBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Branche du service militaire</para><para>Service Branch (Military)</para><para>Teilstreitkraft</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryServiceBranch">http://rdf.muninn-project.org/ontologies/military#MilitaryServiceBranch</seealso>
    let MilitaryServiceBranch =
        Prefixed_Name(mil, "MilitaryServiceBranch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Aircraftman_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Aircraftman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Aircraftman_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Aircraftman_EnglishTradition</seealso>
    let Rank_Aircraftman_EnglishTradition =
        Prefixed_Name(mil, "Rank_Aircraftman_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Anthypolochagos</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Anthypolochagos</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos">http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos</seealso>
    let Rank_Anthypolochagos =
        Prefixed_Name(mil, "Rank_Anthypolochagos") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Antisyntagmatarchis</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Antisyntagmatarchis</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis">http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis</seealso>
    let Rank_Antisyntagmatarchis =
        Prefixed_Name(mil, "Rank_Antisyntagmatarchis") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Chiliarch (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Chiliarch (Det akhaiske forbund)</para><para>Chiliarcha (ZwiÄzek Achajski)</para><para>Chiliarch (Achaiska förbundet)</para><para>Chiliarch (Achaiischer Bund)</para><para>Chiliarque (Ligue achéenne)</para><para>Chiliarch (Achaeïsche Bond)</para><para>Chiliarch (Akhaian liitto)</para><para>Chiliarch (Achaean League)</para><para>Chiliarch (Liga Aqueia)</para><para>Chiliarca (Lega achea)</para><para>Quiliarca (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Achaean_League</seealso>
    let Rank_Chiliarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Chiliarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chiliarch_Byzantine_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Chiliarch (ÐÐ¸Ð·Ð°Ð½ÑÐ¸Ð¹ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Chiliarcha (Cesarstwo BizantyÅskie)</para><para>Chiliarch (Byzantinisches Reich)</para><para>Chiliarch (Bysantin valtakunta)</para><para>Chiliarch (Império Bizantino)</para><para>Chiliarch (Bysantinska riket)</para><para>Quiliarca (Imperio bizantino)</para><para>Chiliarca (Impero bizantino)</para><para>Chiliarch (Byzantine Empire)</para><para>Chiliarch (Byzantijnse Rijk)</para><para>Chiliarque (Empire byzantin)</para><para>Chiliarch (Østromerriket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Byzantine_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Byzantine_Empire</seealso>
    let Rank_Chiliarch_Byzantine_Empire =
        Prefixed_Name(mil, "Rank_Chiliarch_Byzantine_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Divisional_Admiral_Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Divisional Admiral (ÐÐµÐ»ÑÐ³Ð¸Ñ)</para><para>Ammiraglio di divisione (Belgio)</para><para>Amiral de division (Belgique)</para><para>Divisional Admiral (Belgium)</para><para>Divisional Admiral (Belgien)</para><para>Divisional Admiral (Bélgica)</para><para>Divisional Admiral (Bélgica)</para><para>Divisional Admiral (Belgien)</para><para>Divisional Admiral (Belgia)</para><para>Divisional Admiral (Belgia)</para><para>Divisional Admiral (Belgia)</para><para>Divisieadmiraal (België)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Belgium">http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Belgium</seealso>
    let Rank_Divisional_Admiral_Belgium =
        Prefixed_Name(mil, "Rank_Divisional_Admiral_Belgium") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lochagos</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lochagos</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos">http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos</seealso>
    let Rank_Lochagos = Prefixed_Name(mil, "Rank_Lochagos") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lochagos_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lochagos (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Lochagos (Det akhaiske forbund)</para><para>Lochagos (Achaiska förbundet)</para><para>Lochagos (ZwiÄzek Achajski)</para><para>Lochagos (Achaiischer Bund)</para><para>Lochagos (Achaeïsche Bond)</para><para>Lochagos (Achaean League)</para><para>Lochagos (Akhaian liitto)</para><para>Lochagos (Ligue achéenne)</para><para>Lochagos (Liga Aqueia)</para><para>Lochagos (Lega achea)</para><para>Lochagos (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Achaean_League</seealso>
    let Rank_Lochagos_Achaean_League =
        Prefixed_Name(mil, "Rank_Lochagos_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpolkovnik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Podpolkovnik (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>PodpuÅkownik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Podpolkovnik (Union des républiques socialistes soviétiques)</para><para>Podpolkovnik (Unione Sovietica)</para><para>Podpolkovnik (Unión Soviética)</para><para>Podpolkovnik (União Soviética)</para><para>Podpolkovnik (Neuvostoliitto)</para><para>Podpolkovnik (Sovjetunionen)</para><para>Podpolkovnik (Sovjetunionen)</para><para>Podpolkovnik (Soviet Union)</para><para>Podpolkovnik (Sovjet-Unie)</para><para>Podpolkovnik (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Soviet_Union</seealso>
    let Rank_Podpolkovnik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Podpolkovnik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpolkovnik_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Podpolkovnik (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>PodpuÅkownik (Ukraina)</para><para>Podpolkovnik (Oekraïne)</para><para>Podpolkovnik (Ukraina)</para><para>Podpolkovnik (Ucraina)</para><para>Podpolkovnik (Ukraina)</para><para>Podpolkovnik (Ukraina)</para><para>Podpolkovnik (Ukraine)</para><para>Podpolkovnik (Ucrania)</para><para>Podpolkovnik (Ukraine)</para><para>Podpolkovnik (Ukraine)</para><para>Podpolkovnik (Ucrânia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Ukraine</seealso>
    let Rank_Podpolkovnik_Ukraine =
        Prefixed_Name(mil, "Rank_Podpolkovnik_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpraporshchik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð´Ð¿ÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº</para><para>Podpraporshchik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik">http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik</seealso>
    let Rank_Podpraporshchik =
        Prefixed_Name(mil, "Rank_Podpraporshchik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpraporshchik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð´Ð¿ÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Podpraporshchik (Russland)</para><para>Podpraporshchik (Russland)</para><para>Podpraporshchik (Ryssland)</para><para>Podpraporshchik (Rusland)</para><para>Podpraporshchik (Venäjä)</para><para>Podpraporshchik (Russia)</para><para>Podpraporshchik (Russie)</para><para>Podpraporshchik (Rússia)</para><para>Podpraporshchik (Russia)</para><para>Podpraporshchik (Rosja)</para><para>Podpraporshchik (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Russia</seealso>
    let Rank_Podpraporshchik_Russia =
        Prefixed_Name(mil, "Rank_Podpraporshchik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Podpraporshchik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð´Ð¿ÑÐ°Ð¿Ð¾ÑÑÐ¸Ðº (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Podpraporshchik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Podpraporshchik (Union des républiques socialistes soviétiques)</para><para>Podpraporshchik (Unione Sovietica)</para><para>Podpraporshchik (União Soviética)</para><para>Podpraporshchik (Unión Soviética)</para><para>Podpraporshchik (Neuvostoliitto)</para><para>Podpraporshchik (Sovjetunionen)</para><para>Podpraporshchik (Sovjetunionen)</para><para>Podpraporshchik (Soviet Union)</para><para>Podpraporshchik (Sowjetunion)</para><para>Podpraporshchik (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Soviet_Union</seealso>
    let Rank_Podpraporshchik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Podpraporshchik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polemarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð»ÐµÐ¼Ð°ÑÑ</para><para>Polemarchos</para><para>Polémarque</para><para>Polemarkos</para><para>Polemarca</para><para>Polemarco</para><para>Polemarch</para><para>Polemark</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch">http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch</seealso>
    let Rank_Polemarch = Prefixed_Name(mil, "Rank_Polemarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polemarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð»ÐµÐ¼Ð°ÑÑ (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Polemarkos (Det akhaiske forbund)</para><para>Polemarch (ZwiÄzek Achajski)</para><para>Polemark (Achaiska förbundet)</para><para>Polemarchos (Achaeïsche Bond)</para><para>Polemarch (Achaiischer Bund)</para><para>Polémarque (Ligue achéenne)</para><para>Polemarch (Akhaian liitto)</para><para>Polemarch (Achaean League)</para><para>Polemarco (Liga Aqueia)</para><para>Polemarch (Lega achea)</para><para>Polemarca (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Achaean_League</seealso>
    let Rank_Polemarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Polemarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polemarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð»ÐµÐ¼Ð°ÑÑ (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Polemarch (Macedonia (ancient kingdom))</para><para>Polemark (Macedonia (ancient kingdom))</para><para>Polémarque (Royaume de Macédoine)</para><para>Polemarch (StaroÅ¼ytna Macedonia)</para><para>Polemarchos (Macedonië (oudheid))</para><para>Polemarch (Makedonian valtakunta)</para><para>Polemarkos (Oldtidens Makedonia)</para><para>Polemarca (Reino de Macedonia)</para><para>Polemarch (Regno di Macedonia)</para><para>Polemarco (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Macedonia</seealso>
    let Rank_Polemarch_Macedonia =
        Prefixed_Name(mil, "Rank_Polemarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sowi</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sowi</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi">http://rdf.muninn-project.org/ontologies/military#Rank_Sowi</seealso>
    let Rank_Sowi = Prefixed_Name(mil, "Rank_Sowi") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sowi_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Sowi (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Sowi (Korean demokraattinen kansantasavalta)</para><para>Sowi (Korea PÃ³Ånocna)</para><para>Sowi (Coreia do Norte)</para><para>Sowi (Corea del Norte)</para><para>Sowi (Corea del Nord)</para><para>Sowi (Corée du Nord)</para><para>Sowi (North Korea)</para><para>Sowi (Noord-Korea)</para><para>Sowi (Nord-Korea)</para><para>Sowi (Nordkorea)</para><para>Sowi (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_North_Korea</seealso>
    let Rank_Sowi_North_Korea =
        Prefixed_Name(mil, "Rank_Sowi_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sowi_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sowi (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Sowi (Korea PoÅudniowa)</para><para>Sowi (Korean tasavalta)</para><para>Sowi (Coreia do Sul)</para><para>Sowi (Corea del Sur)</para><para>Sowi (Corea del Sud)</para><para>Sowi (Corée du Sud)</para><para>Sowi (South Korea)</para><para>Sowi (Zuid-Korea)</para><para>Sowi (Sør-Korea)</para><para>Sowi (Sydkorea)</para><para>Sowi (Südkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_South_Korea</seealso>
    let Rank_Sowi_South_Korea =
        Prefixed_Name(mil, "Rank_Sowi_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staabikapten</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Staabikapten</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten">http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten</seealso>
    let Rank_Staabikapten = Prefixed_Name(mil, "Rank_Staabikapten") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staabikapten_Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staabikapten (Ð­ÑÑÐ¾Ð½Ð¸Ñ)</para><para>Staabikapten (Estonia)</para><para>Staabikapten (Estland)</para><para>Staabikapten (Estónia)</para><para>Staabikapten (Estland)</para><para>Staabikapten (Estonia)</para><para>Staabikapten (Estland)</para><para>Staabikapten (Estonia)</para><para>Staabikapten (Estonia)</para><para>Staabikapten (Estonie)</para><para>Staabikapten (Estland)</para><para>Staabikapten (Viro)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Estonia">http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Estonia</seealso>
    let Rank_Staabikapten_Estonia =
        Prefixed_Name(mil, "Rank_Staabikapten_Estonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tysyatsky_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢ÑÑÑÑÐºÐ¸Ð¹ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Tysyatsky (Ryssland)</para><para>Tysyatsky (Russland)</para><para>Tysyatsky (Russland)</para><para>Tysjatski (Rusland)</para><para>Tysyatsky (Russia)</para><para>Tysyatsky (Venäjä)</para><para>Tysjackij (Russia)</para><para>Tysyatsky (Russie)</para><para>Tysyatsky (Rússia)</para><para>Tysyatsky (Rosja)</para><para>Tysyatsky (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Russia</seealso>
    let Rank_Tysyatsky_Russia =
        Prefixed_Name(mil, "Rank_Tysyatsky_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Appointment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Appointment (Civil)</para><para>Appointment (Civil)</para><para>Appointment (Civil)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Appointment">http://rdf.muninn-project.org/ontologies/military#Appointment</seealso>
    let Appointment = Prefixed_Name(mil, "Appointment") |> PrefixedName
    /// <summary>
    ///   <para>mil:Armor</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///
    /// labels<para>Armor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Armor">http://rdf.muninn-project.org/ontologies/military#Armor</seealso>
    let Armor = Prefixed_Name(mil, "Armor") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmyCompany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company (Military Unit)</para><para>Compagnie (militaire)</para><para>Kompanie (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmyCompany">http://rdf.muninn-project.org/ontologies/military#ArmyCompany</seealso>
    let ArmyCompany = Prefixed_Name(mil, "ArmyCompany") |> PrefixedName
    /// <summary>
    ///   <para>mil:nominalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Nominal Unit Size</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#nominalSize">http://rdf.muninn-project.org/ontologies/military#nominalSize</seealso>
    let nominalSize = Prefixed_Name(mil, "nominalSize") |> PrefixedName
    /// <summary>
    ///   <para>mil:Platoon</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Peloton (militaire)</para><para>Platoon</para><para>Platoon</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Platoon">http://rdf.muninn-project.org/ontologies/military#Platoon</seealso>
    let Platoon = Prefixed_Name(mil, "Platoon") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmyServiceBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Army (Service Branch)</para><para>Armee (Service)</para><para>Armée (Service)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmyServiceBranch">http://rdf.muninn-project.org/ontologies/military#ArmyServiceBranch</seealso>
    let ArmyServiceBranch = Prefixed_Name(mil, "ArmyServiceBranch") |> PrefixedName
    /// <summary>
    ///   <para>mil:Battalion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Battalion (Military)</para><para>Bataillon</para><para>Bataillon</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Battalion">http://rdf.muninn-project.org/ontologies/military#Battalion</seealso>
    let Battalion = Prefixed_Name(mil, "Battalion") |> PrefixedName
    /// <summary>
    ///   <para>mil:PrivilegedCombatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>privilegierten Kämpfer</para><para>Combatant privilégié</para><para>Privileged Combatant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#PrivilegedCombatant">http://rdf.muninn-project.org/ontologies/military#PrivilegedCombatant</seealso>
    let PrivilegedCombatant = Prefixed_Name(mil, "PrivilegedCombatant") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankAbleSeaman_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Canada">http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Canada</seealso>
    let RankAbleSeaman_Canada =
        Prefixed_Name(mil, "RankAbleSeaman_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chorbaji_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð§Ð¾ÑÐ±Ð°Ð´Ð¶Ð¸ (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>ÃorbacÄ± (Imperium osmaÅskie)</para><para>ÃorbacÄ± (Osmanien valtakunta)</para><para>ÃorbacÄ± (Osmanisches Reich)</para><para>ÃorbacÄ± (Det osmanske rike)</para><para>ÃorbacÄ± (ImpÃ©rio Otomano)</para><para>ÃorbacÄ± (Ottomaanse Rijk)</para><para>ÃorbacÄ± (Imperio otomano)</para><para>ÃorbacÄ± (Impero ottomano)</para><para>ÃorbacÄ± (Osmanska riket)</para><para>ÃorbacÄ± (Ottoman Empire)</para><para>ÃorbacÄ± (Empire ottoman)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Ottoman_Empire</seealso>
    let Rank_Chorbaji_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Chorbaji_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_Major_General</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Drum Major General</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General</seealso>
    let Rank_Drum_Major_General =
        Prefixed_Name(mil, "Rank_Drum_Major_General") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hetman_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐµÑÐ¼Ð°Ð½ (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Hetman (Oekraïne)</para><para>Hetmani (Ukraina)</para><para>Hetman (Ukraine)</para><para>Hetman (Ucraina)</para><para>Hetman (Ukraina)</para><para>Hetman (Ukraine)</para><para>Hetman (Ukraina)</para><para>Hetman (Ucrânia)</para><para>Hetman (Ukraine)</para><para>Hetman (Ukraina)</para><para>Hetman (Ucrania)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Ukraine</seealso>
    let Rank_Hetman_Ukraine = Prefixed_Name(mil, "Rank_Hetman_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hipparchus_Cavalry</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¸Ð¿Ð¿Ð°ÑÑ (Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸Ðº)</para><para>Hiparco (oficial de caballería)</para><para>Hipparchus (cavalry officer)</para><para>Hipparchos</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry">http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry</seealso>
    let Rank_Hipparchus_Cavalry =
        Prefixed_Name(mil, "Rank_Hipparchus_Cavalry") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Hipparchus_Cavalry_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¸Ð¿Ð¿Ð°ÑÑ (Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸Ðº) (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Hipparchus (cavalry officer) (Det akhaiske forbund)</para><para>Hipparchus (cavalry officer) (Achaiska förbundet)</para><para>Hipparchus (cavalry officer) (ZwiÄzek Achajski)</para><para>Hipparchus (cavalry officer) (Achaiischer Bund)</para><para>Hipparchus (cavalry officer) (Ligue achéenne)</para><para>Hipparchus (cavalry officer) (Akhaian liitto)</para><para>Hipparchus (cavalry officer) (Achaean League)</para><para>Hiparco (oficial de caballería) (Liga Aquea)</para><para>Hipparchus (cavalry officer) (Liga Aqueia)</para><para>Hipparchus (cavalry officer) (Lega achea)</para><para>Hipparchos (Achaeïsche Bond)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Achaean_League</seealso>
    let Rank_Hipparchus_Cavalry_Achaean_League =
        Prefixed_Name(mil, "Rank_Hipparchus_Cavalry_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:hasCommanderInChief</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Commander In Chief</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#hasCommanderInChief">http://rdf.muninn-project.org/ontologies/military#hasCommanderInChief</seealso>
    let hasCommanderInChief = Prefixed_Name(mil, "hasCommanderInChief") |> PrefixedName
    /// <summary>
    ///   <para>mil:deathDay</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Day of Death</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#deathDay">http://rdf.muninn-project.org/ontologies/military#deathDay</seealso>
    let deathDay = Prefixed_Name(mil, "deathDay") |> PrefixedName
    /// <summary>
    ///   <para>mil:epauletDepiction</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Epaulets</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#epauletDepiction">http://rdf.muninn-project.org/ontologies/military#epauletDepiction</seealso>
    let epauletDepiction = Prefixed_Name(mil, "epauletDepiction") |> PrefixedName
    /// <summary>
    ///   <para>mil:CommanderInChiefOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CommanderInChiefOf">http://rdf.muninn-project.org/ontologies/military#CommanderInChiefOf</seealso>
    let CommanderInChiefOf = Prefixed_Name(mil, "CommanderInChiefOf") |> PrefixedName
    /// <summary>
    ///   <para>mil:hasPrincipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>has Principal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#hasPrincipal">http://rdf.muninn-project.org/ontologies/military#hasPrincipal</seealso>
    let hasPrincipal = Prefixed_Name(mil, "hasPrincipal") |> PrefixedName
    /// <summary>
    ///   <para>mil:hasUniform</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Uniform</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#hasUniform">http://rdf.muninn-project.org/ontologies/military#hasUniform</seealso>
    let hasUniform = Prefixed_Name(mil, "hasUniform") |> PrefixedName
    /// <summary>
    ///   <para>mil:heldRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Held Rank</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#heldRank">http://rdf.muninn-project.org/ontologies/military#heldRank</seealso>
    let heldRank = Prefixed_Name(mil, "heldRank") |> PrefixedName
    /// <summary>
    ///   <para>mil:idANZACNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Australian Archives Anzac Person Identifier</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#idANZACNumber">http://rdf.muninn-project.org/ontologies/military#idANZACNumber</seealso>
    let idANZACNumber = Prefixed_Name(mil, "idANZACNumber") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmyFront</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ðµ ÑÑÐ¾Ð½ÑÑ Ð²Ð¾ Ð²ÑÐµÐ¼Ñ ÐÐµÐ»Ð¸ÐºÐ¾Ð¹ ÐÑÐµÑÐµÑÑÐ²ÐµÐ½Ð½Ð¾Ð¹ Ð²Ð¾Ð¹Ð½Ñ</para><para>PhÆ°Æ¡ng diá»n quÃ¢n (LiÃªn XÃ´)</para><para>Front (military formation)</para><para>Front (unité soviétique)</para><para>Rintama (puna-armeija)</para><para>Front (Großverband)</para><para>Front (Röda armén)</para><para>Front (seregtest)</para><para>Fronty radzieckie</para><para>Front (forband)</para><para>Front</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmyFront">http://rdf.muninn-project.org/ontologies/military#ArmyFront</seealso>
    let ArmyFront = Prefixed_Name(mil, "ArmyFront") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmyGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Groupe d'Armée</para><para>Heeresgruppe</para><para>Army Group</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmyGroup">http://rdf.muninn-project.org/ontologies/military#ArmyGroup</seealso>
    let ArmyGroup = Prefixed_Name(mil, "ArmyGroup") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Grade (Civil)</para><para>Rank (Civil)</para><para>Rang (Civil)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank">http://rdf.muninn-project.org/ontologies/military#Rank</seealso>
    let Rank = Prefixed_Name(mil, "Rank") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Army_General_Russia_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐµÐ½ÐµÑÐ°Ð» Ð°ÑÐ¼Ð¸Ð¸ (Ð Ð¾ÑÑÐ¸Ñ) (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Army General (Russia) (Russland)</para><para>Army General (Russia) (Russland)</para><para>Army General (Russia) (Ryssland)</para><para>Army General (Russia) (Rusland)</para><para>Army General (Russia) (Russie)</para><para>Army General (Russia) (Russia)</para><para>Army General (Russia) (Russia)</para><para>Army General (Russia) (Rússia)</para><para>Army General (Russia) (Venäjä)</para><para>Army General (Russia) (Rosja)</para><para>Army General (Russia) (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Russia</seealso>
    let Rank_Army_General_Russia_Russia =
        Prefixed_Name(mil, "Rank_Army_General_Russia_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pipe_Major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Pipe Major (Pays de Galles)</para><para>Pipe Major (País de Gales)</para><para>Pipe Major (Ð£ÑÐ»ÑÑ)</para><para>Pipe Major (Galles)</para><para>Pipe Major (Wales)</para><para>Pipe Major (Wales)</para><para>Pipe Major (Wales)</para><para>Pipe Major (Gales)</para><para>Pipe Major (Wales)</para><para>Pipe Major (Wales)</para><para>Pipe Major (Walia)</para><para>Pipe Major (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Wales</seealso>
    let Rank_Pipe_Major_Wales =
        Prefixed_Name(mil, "Rank_Pipe_Major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tagmatarchis_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Tagmatarchis (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Tagmatarchis (Macedonia (ancient kingdom))</para><para>Tagmatarchis (StaroÅ¼ytna Macedonia)</para><para>Tagmatarchis (Makedonian valtakunta)</para><para>Tagmatarchis (Royaume de Macédoine)</para><para>Tagmatarchis (Oldtidens Makedonia)</para><para>Tagmatarchis (Macedonië (oudheid))</para><para>Tagmatarchis (Regno di Macedonia)</para><para>Tagmatarchis (Reino de Macedonia)</para><para>Tagmatarchis (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Macedonia</seealso>
    let Rank_Tagmatarchis_Macedonia =
        Prefixed_Name(mil, "Rank_Tagmatarchis_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:ArmySection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Section (Military Unit)</para><para>Abschnitt (Militär)</para><para>Section (Militaire)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmySection">http://rdf.muninn-project.org/ontologies/military#ArmySection</seealso>
    let ArmySection = Prefixed_Name(mil, "ArmySection") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArmySquad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Squad (Military Unit)</para><para>Équipe (Militaire)</para><para>Gruppe (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmySquad">http://rdf.muninn-project.org/ontologies/military#ArmySquad</seealso>
    let ArmySquad = Prefixed_Name(mil, "ArmySquad") |> PrefixedName
    /// <summary>
    ///   <para>mil:ArtilleryBattery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Batterie (armement)</para><para>Batterie (Militär)</para><para>Artillery Battery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBattery">http://rdf.muninn-project.org/ontologies/military#ArtilleryBattery</seealso>
    let ArtilleryBattery = Prefixed_Name(mil, "ArtilleryBattery") |> PrefixedName

    /// <summary>
    ///   <para>mil:ArtilleryBatteryDivision</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Division de Batterie (armement)</para><para>Batterie Division (Militär)</para><para>Divisional Artillery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBatteryDivision">http://rdf.muninn-project.org/ontologies/military#ArtilleryBatteryDivision</seealso>
    let ArtilleryBatteryDivision =
        Prefixed_Name(mil, "ArtilleryBatteryDivision") |> PrefixedName

    /// <summary>
    ///   <para>mil:AssaultGroupInfantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Assault Group (Infantry)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#AssaultGroupInfantry">http://rdf.muninn-project.org/ontologies/military#AssaultGroupInfantry</seealso>
    let AssaultGroupInfantry =
        Prefixed_Name(mil, "AssaultGroupInfantry") |> PrefixedName

    /// <summary>
    ///   <para>mil:Battle</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Battle">http://rdf.muninn-project.org/ontologies/military#Battle</seealso>
    let Battle = Prefixed_Name(mil, "Battle") |> PrefixedName
    /// <summary>
    ///   <para>mil:BattleStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>étendard de bataille</para><para>Battle Standard</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#BattleStandard">http://rdf.muninn-project.org/ontologies/military#BattleStandard</seealso>
    let BattleStandard = Prefixed_Name(mil, "BattleStandard") |> PrefixedName
    /// <summary>
    ///   <para>mil:Division</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Division (Militaire)</para><para>Division (Military)</para><para>Division (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Division">http://rdf.muninn-project.org/ontologies/military#Division</seealso>
    let Division = Prefixed_Name(mil, "Division") |> PrefixedName
    /// <summary>
    ///   <para>mil:BrigadeAirCorps</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Brigade (Air Corps)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#BrigadeAirCorps">http://rdf.muninn-project.org/ontologies/military#BrigadeAirCorps</seealso>
    let BrigadeAirCorps = Prefixed_Name(mil, "BrigadeAirCorps") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankClerkArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Clerk (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankClerkArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankClerkArmyCanada+</seealso>
    let ``RankClerkArmyCanada+`` =
        Prefixed_Name(mil, "RankClerkArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankColonelArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Colonel (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankColonelArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankColonelArmyCanada</seealso>
    let RankColonelArmyCanada =
        Prefixed_Name(mil, "RankColonelArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCombatMilitaryRank_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Combat (military rank) (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Combat (military rank) (Russland)</para><para>Combat (military rank) (Ryssland)</para><para>Combat (military rank) (Russland)</para><para>Combat (military rank) (Rusland)</para><para>Combat (military rank) (Venäjä)</para><para>Combat (military rank) (Russia)</para><para>Combat (military rank) (Russie)</para><para>Combat (military rank) (Rússia)</para><para>Combat (military rank) (Russia)</para><para>Combat (military rank) (Rosja)</para><para>Combat (military rank) (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Russia">http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Russia</seealso>
    let RankCombatMilitaryRank_Russia =
        Prefixed_Name(mil, "RankCombatMilitaryRank_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCommandant_France</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Commandant (rank) (France)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_France">http://rdf.muninn-project.org/ontologies/military#RankCommandant_France</seealso>
    let RankCommandant_France =
        Prefixed_Name(mil, "RankCommandant_France") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCommandant_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Commandant (rank) (República da Irlanda)</para><para>Commandant (rank) (Republic of Ireland)</para><para>Commandant (rank) (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Commandant (rank) (Ierland (land))</para><para>Commandant (rank) (Irlande (pays))</para><para>Commandant (rank) (Irlandia)</para><para>Commandant (rank) (Irlanti)</para><para>Commandant (rank) (Irlanda)</para><para>Commandant (rank) (Irlanda)</para><para>Commandant (rank) (Irland)</para><para>Commandant (rank) (Irland)</para><para>Commandant (rank) (Irland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#RankCommandant_Republic_of_Ireland</seealso>
    let RankCommandant_Republic_of_Ireland =
        Prefixed_Name(mil, "RankCommandant_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comandarm_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Komandarm av 1. klasseKomandarm av 2. klasse (Russland)</para><para>Sowjetische GeneralsrängeKomandarm (Russland)</para><para>Comandarm (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Comandarm (Ryssland)</para><para>Comandarm (Rusland)</para><para>Comandarm (Russie)</para><para>Comandarm (Rússia)</para><para>Comandarm (Venäjä)</para><para>Comandarm (Russia)</para><para>Comandarm (Russia)</para><para>Comandarm (Rusia)</para><para>Komandarm (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Russia</seealso>
    let Rank_Comandarm_Russia =
        Prefixed_Name(mil, "Rank_Comandarm_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Marshal_of_the_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°ÑÑÐ°Ð» Ð¡Ð¾Ð²ÐµÑÑÐºÐ¾Ð³Ð¾ Ð¡Ð¾ÑÐ·Ð°</para><para>Maresciallo dell'Unione Sovietica</para><para>Maréchal de l'Union soviétique</para><para>Mariscal de la Unión Soviética</para><para>Maarschalk van de Sovjet-Unie</para><para>Marechal da União Soviética</para><para>Marshal of the Soviet Union</para><para>Marskalk av Sovjetunionen</para><para>Marskalk av Sovjetunionen</para><para>Marschall der Sowjetunion</para><para>Neuvostoliiton marsalkka</para><para>MarszaÅkowie ZSRR</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union</seealso>
    let Rank_Marshal_of_the_Soviet_Union =
        Prefixed_Name(mil, "Rank_Marshal_of_the_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Master_warrant_officer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Master Warrant Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer">http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer</seealso>
    let Rank_Master_warrant_officer =
        Prefixed_Name(mil, "Rank_Master_warrant_officer") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polkovnik_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Polkovnik (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Polkovnik (Russland)</para><para>Polkovnik (Ryssland)</para><para>Polkovnik (Russland)</para><para>Polkovnik (Rusland)</para><para>Polkovnik (Rússia)</para><para>Polkovnik (Venäjä)</para><para>Polkovnik (Russie)</para><para>Polkovnik (Russia)</para><para>Polkovnik (Russia)</para><para>Polkovnik (Rosja)</para><para>Polkovnik (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Russia</seealso>
    let Rank_Polkovnik_Russia =
        Prefixed_Name(mil, "Rank_Polkovnik_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polkovnik_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Polkovnik (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Polkovnik (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Polkovnik (Union des républiques socialistes soviétiques)</para><para>Polkovnik (Unione Sovietica)</para><para>Polkovnik (Unión Soviética)</para><para>Polkovnik (União Soviética)</para><para>Polkovnik (Neuvostoliitto)</para><para>Polkovnik (Sovjetunionen)</para><para>Polkovnik (Sovjetunionen)</para><para>Polkovnik (Soviet Union)</para><para>Polkovnik (Sovjet-Unie)</para><para>Polkovnik (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Soviet_Union</seealso>
    let Rank_Polkovnik_Soviet_Union =
        Prefixed_Name(mil, "Rank_Polkovnik_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polkovnik_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Polkovnik (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Polkovnik (Oekraïne)</para><para>Polkovnik (Ucrania)</para><para>Polkovnik (Ukraine)</para><para>Polkovnik (Ukraina)</para><para>Polkovnik (Ukraina)</para><para>Polkovnik (Ukraina)</para><para>Polkovnik (Ucrânia)</para><para>Polkovnik (Ukraina)</para><para>Polkovnik (Ucraina)</para><para>Polkovnik (Ukraine)</para><para>Polkovnik (Ukraine)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Ukraine</seealso>
    let Rank_Polkovnik_Ukraine =
        Prefixed_Name(mil, "Rank_Polkovnik_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staabikapten_Republic_of_Estonia_1920-1940</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staabikapten (Republic of Estonia, 1920-1940)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Republic_of_Estonia_1920-1940">http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Republic_of_Estonia_1920-1940</seealso>
    let Rank_Staabikapten_Republic_of_Estonia_1920_1940 =
        Prefixed_Name(mil, "Rank_Staabikapten_Republic_of_Estonia_1920-1940") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitan</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¨ÑÐ°Ð±Ñ-ÐºÐ°Ð¿Ð¸ÑÐ°Ð½</para><para>Sztabskapitan</para><para>Stabskapitän</para><para>Stabskapitän</para><para>Alikapteeni</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan</seealso>
    let Rank_Stabskapitan = Prefixed_Name(mil, "Rank_Stabskapitan") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitan_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¨ÑÐ°Ð±Ñ-ÐºÐ°Ð¿Ð¸ÑÐ°Ð½ (Germany)</para><para>Sztabskapitan (Germany)</para><para>Stabskapitän (Germany)</para><para>Stabskapitän (Germany)</para><para>Alikapteeni (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Germany</seealso>
    let Rank_Stabskapitan_Germany =
        Prefixed_Name(mil, "Rank_Stabskapitan_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Stabskapitan_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¨ÑÐ°Ð±Ñ-ÐºÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Stabskapitän (Ryssland)</para><para>Stabskapitän (Russland)</para><para>Stabskapitän (Russland)</para><para>Stabskapitän (Rusland)</para><para>Sztabskapitan (Rosja)</para><para>Stabskapitän (Russia)</para><para>Stabskapitän (Russia)</para><para>Stabskapitän (Russie)</para><para>Stabskapitän (Rússia)</para><para>Stabskapitän (Rusia)</para><para>Alikapteeni (Venäjä)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Russia</seealso>
    let Rank_Stabskapitan_Russia =
        Prefixed_Name(mil, "Rank_Stabskapitan_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vaapeli</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vääpeli</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli">http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli</seealso>
    let Rank_Vaapeli = Prefixed_Name(mil, "Rank_Vaapeli") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vaapeli_Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>VÃ¤Ã¤peli (Ð¤Ð¸Ð½Ð»ÑÐ½Ð´Ð¸Ñ)</para><para>Vääpeli (Finlandia)</para><para>Vääpeli (Finlândia)</para><para>Vääpeli (Finlandia)</para><para>Vääpeli (Finlandia)</para><para>Vääpeli (Finnland)</para><para>Vääpeli (Finlande)</para><para>Vääpeli (Finland)</para><para>Vääpeli (Finland)</para><para>Vääpeli (Finland)</para><para>Vääpeli (Finland)</para><para>Vääpeli (Suomi)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Finland">http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Finland</seealso>
    let Rank_Vaapeli_Finland =
        Prefixed_Name(mil, "Rank_Vaapeli_Finland") |> PrefixedName

    /// <summary>
    ///   <para>mil:GroundBasedOrganization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#GroundBasedOrganization">http://rdf.muninn-project.org/ontologies/military#GroundBasedOrganization</seealso>
    let GroundBasedOrganization =
        Prefixed_Name(mil, "GroundBasedOrganization") |> PrefixedName

    /// <summary>
    ///   <para>mil:FightsPrimarilyOnAndInLand</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:BattleSpace</para>
    ///
    /// labels<para>Land (Battleground)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInLand">http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInLand</seealso>
    let FightsPrimarilyOnAndInLand =
        Prefixed_Name(mil, "FightsPrimarilyOnAndInLand") |> PrefixedName

    /// <summary>
    ///   <para>mil:ArmyTroop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Troupe (Militare)</para><para>Troop (Military)</para><para>Truppe (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArmyTroop">http://rdf.muninn-project.org/ontologies/military#ArmyTroop</seealso>
    let ArmyTroop = Prefixed_Name(mil, "ArmyTroop") |> PrefixedName

    /// <summary>
    ///   <para>mil:ArtilleryEmplacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>geovocab:spatial#Feature</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Artillery Emplacement</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ArtilleryEmplacement">http://rdf.muninn-project.org/ontologies/military#ArtilleryEmplacement</seealso>
    let ArtilleryEmplacement =
        Prefixed_Name(mil, "ArtilleryEmplacement") |> PrefixedName

    /// <summary>
    ///   <para>mil:Brigade</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Brigade (Military)</para><para>Brigade (Militare)</para><para>Brigade</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Brigade">http://rdf.muninn-project.org/ontologies/military#Brigade</seealso>
    let Brigade = Prefixed_Name(mil, "Brigade") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryEvent">http://rdf.muninn-project.org/ontologies/military#MilitaryEvent</seealso>
    let MilitaryEvent = Prefixed_Name(mil, "MilitaryEvent") |> PrefixedName
    /// <summary>
    ///   <para>mil:BattleSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Espace de Battaille</para><para>Battle Space</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#BattleSpace">http://rdf.muninn-project.org/ontologies/military#BattleSpace</seealso>
    let BattleSpace = Prefixed_Name(mil, "BattleSpace") |> PrefixedName
    /// <summary>
    ///   <para>mil:BrevetRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Brevet Rang (Militärischen)</para><para>Grade Brevet (Militare)</para><para>Brevet Rank (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#BrevetRank">http://rdf.muninn-project.org/ontologies/military#BrevetRank</seealso>
    let BrevetRank = Prefixed_Name(mil, "BrevetRank") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Aspirant_Romania_Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Aspirant (Romania) (Ð ÑÐ¼ÑÐ½Ð¸Ñ)</para><para>Aspirant (Romania) (Rumänien)</para><para>Aspirant (Romania) (Roemenië)</para><para>Aspirant (Romania) (Rumänien)</para><para>Aspirant (Romania) (Roumanie)</para><para>Aspirant (Romania) (Rumunia)</para><para>Aspirant (Romania) (Romania)</para><para>Aspirant (Romania) (Roménia)</para><para>Aspirant (Romania) (Romania)</para><para>Aspirant (Romania) (Romania)</para><para>Aspirant (Romania) (Romania)</para><para>Aspirant (Romania) (Rumania)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania_Romania">http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania_Romania</seealso>
    let Rank_Aspirant_Romania_Romania =
        Prefixed_Name(mil, "Rank_Aspirant_Romania_Romania") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ataman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ataman / Otaman</para><para>ÐÑÐ°Ð¼Ð°Ð½</para><para>Atamaani</para><para>Atamano</para><para>Atamán</para><para>Ataman</para><para>Ataman</para><para>Ataman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman">http://rdf.muninn-project.org/ontologies/military#Rank_Ataman</seealso>
    let Rank_Ataman = Prefixed_Name(mil, "Rank_Ataman") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Ataman_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÑÐ°Ð¼Ð°Ð½ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Ataman / Otaman (Russie)</para><para>Ataman (Russland)</para><para>Ataman (Russland)</para><para>Atamaani (Venäjä)</para><para>Ataman (Ryssland)</para><para>Ataman (Rusland)</para><para>Atamano (Russia)</para><para>Ataman (Rússia)</para><para>Ataman (Russia)</para><para>Atamán (Rusia)</para><para>Ataman (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Russia</seealso>
    let Rank_Ataman_Russia = Prefixed_Name(mil, "Rank_Ataman_Russia") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Drum_major</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum major (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major</seealso>
    let Rank_Drum_major = Prefixed_Name(mil, "Rank_Drum_major") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_major_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum major (rank, England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_England">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_England</seealso>
    let Rank_Drum_major_England =
        Prefixed_Name(mil, "Rank_Drum_major_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_major_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Drum major (rank) (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Drum major (rank) (Schottland)</para><para>Drum major (rank) (Skottland)</para><para>Drum major (rank) (Skottland)</para><para>Drum major (rank) (Skotlanti)</para><para>Drum major (rank) (Schotland)</para><para>Drum major (rank) (Scotland)</para><para>Drum major (rank) (Escocia)</para><para>Drum major (rank) (Szkocja)</para><para>Drum major (rank) (Escócia)</para><para>Drum major (rank) (Écosse)</para><para>Drum major (rank) (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Scotland</seealso>
    let Rank_Drum_major_Scotland =
        Prefixed_Name(mil, "Rank_Drum_major_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_major_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum major (rank) (Pays de Galles)</para><para>Drum major (rank) (País de Gales)</para><para>Drum major (rank) (Ð£ÑÐ»ÑÑ)</para><para>Drum major (rank) (Galles)</para><para>Drum major (rank) (Gales)</para><para>Drum major (rank) (Wales)</para><para>Drum major (rank) (Wales)</para><para>Drum major (rank) (Wales)</para><para>Drum major (rank) (Walia)</para><para>Drum major (rank) (Wales)</para><para>Drum major (rank) (Wales)</para><para>Drum major (rank) (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Wales</seealso>
    let Rank_Drum_major_Wales =
        Prefixed_Name(mil, "Rank_Drum_major_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ensign_(rank)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ensign_(rank)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Ensign_(rank)_EnglishTradition</seealso>
    let ``Rank_Ensign_(rank)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Ensign_(rank)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Second_lieutenant_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Second lieutenant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_lieutenant_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Second_lieutenant_EnglishTradition</seealso>
    let Rank_Second_lieutenant_EnglishTradition =
        Prefixed_Name(mil, "Rank_Second_lieutenant_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Pilot_officer_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Pilot officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Pilot_officer_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Pilot_officer_EnglishTradition</seealso>
    let Rank_Pilot_officer_EnglishTradition =
        Prefixed_Name(mil, "Rank_Pilot_officer_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Sub-lieutenant_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sub-lieutenant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Sub-lieutenant_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Sub-lieutenant_EnglishTradition</seealso>
    let Rank_Sub_lieutenant_EnglishTradition =
        Prefixed_Name(mil, "Rank_Sub-lieutenant_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Midshipman_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Midshipman</para><para>Midshipman</para><para>Seekadett</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Midshipman_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Midshipman_EnglishTradition</seealso>
    let Rank_Midshipman_EnglishTradition =
        Prefixed_Name(mil, "Rank_Midshipman_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Epihipparch</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Epihipparch</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch">http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch</seealso>
    let Rank_Epihipparch = Prefixed_Name(mil, "Rank_Epihipparch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Epihipparch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Epihipparch (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Epihipparch (Det akhaiske forbund)</para><para>Epihipparch (Achaiska förbundet)</para><para>Epihipparch (ZwiÄzek Achajski)</para><para>Epihipparch (Achaiischer Bund)</para><para>Epihipparch (Achaeïsche Bond)</para><para>Epihipparch (Ligue achéenne)</para><para>Epihipparch (Achaean League)</para><para>Epihipparch (Akhaian liitto)</para><para>Epihipparch (Liga Aqueia)</para><para>Epihipparch (Lega achea)</para><para>Epihipparch (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Achaean_League</seealso>
    let Rank_Epihipparch_Achaean_League =
        Prefixed_Name(mil, "Rank_Epihipparch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ferik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ferik (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik">http://rdf.muninn-project.org/ontologies/military#Rank_Ferik</seealso>
    let Rank_Ferik = Prefixed_Name(mil, "Rank_Ferik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ferik_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ferik (rank) (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>Ferik (rank) (Cossack Hetmanate)</para><para>Ferik (rank) (Hetmanato cosaco)</para><para>Ferik (rank) (Hetmanat cosaque)</para><para>Ferik (rank) (HetmaÅszczyzna)</para><para>Ferik (rank) (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Cossack_Hetmanate</seealso>
    let Rank_Ferik_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Ferik_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junior_sergeant_Republic_of_Estonia_1920-1940</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Republic_of_Estonia_1920-1940">http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Republic_of_Estonia_1920-1940</seealso>
    let Rank_Junior_sergeant_Republic_of_Estonia_1920_1940 =
        Prefixed_Name(mil, "Rank_Junior_sergeant_Republic_of_Estonia_1920-1940") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junjang</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Junjang</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang">http://rdf.muninn-project.org/ontologies/military#Rank_Junjang</seealso>
    let Rank_Junjang = Prefixed_Name(mil, "Rank_Junjang") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junjang_North_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Junjang (ÐÐ¾ÑÐµÐ¹ÑÐºÐ°Ñ ÐÐ°ÑÐ¾Ð´Ð½Ð¾-ÐÐµÐ¼Ð¾ÐºÑÐ°ÑÐ¸ÑÐµÑÐºÐ°Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ°)</para><para>Junjang (Korean demokraattinen kansantasavalta)</para><para>Junjang (Korea PÃ³Ånocna)</para><para>Junjang (Corea del Norte)</para><para>Junjang (Coreia do Norte)</para><para>Junjang (Corea del Nord)</para><para>Junjang (Corée du Nord)</para><para>Junjang (North Korea)</para><para>Junjang (Noord-Korea)</para><para>Junjang (Nord-Korea)</para><para>Junjang (Nordkorea)</para><para>Junjang (Nordkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_North_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_North_Korea</seealso>
    let Rank_Junjang_North_Korea =
        Prefixed_Name(mil, "Rank_Junjang_North_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Junjang_South_Korea</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Junjang (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° ÐÐ¾ÑÐµÑ)</para><para>Junjang (Korea PoÅudniowa)</para><para>Junjang (Korean tasavalta)</para><para>Junjang (Corea del Sur)</para><para>Junjang (Corea del Sud)</para><para>Junjang (Coreia do Sul)</para><para>Junjang (Corée du Sud)</para><para>Junjang (South Korea)</para><para>Junjang (Zuid-Korea)</para><para>Junjang (Sør-Korea)</para><para>Junjang (Südkorea)</para><para>Junjang (Sydkorea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_South_Korea">http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_South_Korea</seealso>
    let Rank_Junjang_South_Korea =
        Prefixed_Name(mil, "Rank_Junjang_South_Korea") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kapudan_Pasha</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿ÑÐ´Ð°Ð½-Ð¿Ð°ÑÐ°</para><para>Kapudan Pascha</para><para>Capitan pacha</para><para>Kapudan Pasha</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha">http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha</seealso>
    let Rank_Kapudan_Pasha = Prefixed_Name(mil, "Rank_Kapudan_Pasha") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kapudan_Pasha_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿ÑÐ´Ð°Ð½-Ð¿Ð°ÑÐ° (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>Kapudan Pasha (Cossack Hetmanate)</para><para>Capitan pacha (Hetmanat cosaque)</para><para>Kapudan Pasha (Hetmanato cosaco)</para><para>Kapudan Pasha (HetmaÅszczyzna)</para><para>Kapudan Pascha (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Cossack_Hetmanate</seealso>
    let Rank_Kapudan_Pasha_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Kapudan_Pasha_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kapudan_Pasha_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿ÑÐ´Ð°Ð½-Ð¿Ð°ÑÐ° (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Kapudan Pasha (Imperium osmaÅskie)</para><para>Kapudan Pasha (Osmanien valtakunta)</para><para>Kapudan Pascha (Osmanisches Reich)</para><para>Kapudan Pasha (Det osmanske rike)</para><para>Kapudan Pasha (Imperio otomano)</para><para>Kapudan Pasha (Impero ottomano)</para><para>Kapudan Pasha (Império Otomano)</para><para>Kapudan Pasha (Ottomaanse Rijk)</para><para>Kapudan Pasha (Ottoman Empire)</para><para>Capitan pacha (Empire ottoman)</para><para>Kapudan Pasha (Osmanska riket)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Ottoman_Empire</seealso>
    let Rank_Kapudan_Pasha_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Kapudan_Pasha_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kapudan_Pasha_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿ÑÐ´Ð°Ð½-Ð¿Ð°ÑÐ° (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>Kapudan Pasha (Repubblica delle Sette Isole Unite)</para><para>Kapudan Pasha (Republiek van de Zeven Eilanden)</para><para>Kapudan Pasha (República de las Islas Jónicas)</para><para>Capitan pacha (République des Sept-Îles)</para><para>Kapudan Pasha (Republika Siedmiu Wysp)</para><para>Kapudan Pascha (Septinsular Republic)</para><para>Kapudan Pasha (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Septinsular_Republic</seealso>
    let Rank_Kapudan_Pasha_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Kapudan_Pasha_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Musir_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>MÃ¼Åir (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>MÃ¼Åir (Repubblica delle Sette Isole Unite)</para><para>MÃ¼Åir (RepÃºblica de las Islas JÃ³nicas)</para><para>MÃ¼Åir (Republiek van de Zeven Eilanden)</para><para>MÃ¼Åir (RÃ©publique des Sept-Ãles)</para><para>MÃ¼Åir (Republika Siedmiu Wysp)</para><para>MÃ¼Åir (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Septinsular_Republic</seealso>
    let Rank_Musir_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Musir_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Navarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð²Ð°ÑÑ</para><para>Navarque</para><para>Navarch</para><para>Nauarch</para><para>Navarco</para><para>Nauarch</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch">http://rdf.muninn-project.org/ontologies/military#Rank_Navarch</seealso>
    let Rank_Navarch = Prefixed_Name(mil, "Rank_Navarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Navarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð²Ð°ÑÑ (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Navarch (Det akhaiske forbund)</para><para>Navarch (Achaiska förbundet)</para><para>Nauarch (ZwiÄzek Achajski)</para><para>Nauarch (Achaiischer Bund)</para><para>Navarque (Ligue achéenne)</para><para>Navarch (Achaeïsche Bond)</para><para>Navarch (Achaean League)</para><para>Navarch (Akhaian liitto)</para><para>Navarch (Liga Aqueia)</para><para>Navarco (Liga Aquea)</para><para>Navarch (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Achaean_League</seealso>
    let Rank_Navarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Navarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Navarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð²Ð°ÑÑ (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Nauarch (Macedonia (ancient kingdom))</para><para>Navarch (Macedonia (ancient kingdom))</para><para>Navarch (Makedonian valtakunta)</para><para>Navarque (Royaume de Macédoine)</para><para>Nauarch (StaroÅ¼ytna Macedonia)</para><para>Navarch (Macedonië (oudheid))</para><para>Navarch (Oldtidens Makedonia)</para><para>Navarco (Reino de Macedonia)</para><para>Navarch (Regno di Macedonia)</para><para>Navarch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Macedonia</seealso>
    let Rank_Navarch_Macedonia =
        Prefixed_Name(mil, "Rank_Navarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Navarch_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð²Ð°ÑÑ (Timocracy of Sapinetia)</para><para>Navarque (Timocracy of Sapinetia)</para><para>Navarco (Timocracy of Sapinetia)</para><para>Navarch (Timocracy of Sapinetia)</para><para>Nauarch (Timocracy of Sapinetia)</para><para>Nauarch (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Navarch_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Navarch_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Obergefreiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Obergefreiter</para><para>Obergefreiter</para><para>Ylikorpraali</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter">http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter</seealso>
    let Rank_Obergefreiter = Prefixed_Name(mil, "Rank_Obergefreiter") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Private_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Deuxième classeSoldat (grade, Canada)</para><para>Soldat (Dienstgrad, Canada)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (Canada)</para><para>Menig 1klMenig (Canada)</para><para>Private (rank, Canada)</para><para>Soldado raso (Canada)</para><para>Menig (grad, Canada)</para><para>Szeregowy (Canada)</para><para>Sotamies (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Private_Canada</seealso>
    let Rank_Private_Canada = Prefixed_Name(mil, "Rank_Private_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Private (Dienstgrad)Soldat (Dienstgrad, England)</para><para>Deuxième classeSoldat (grade) (England)</para><para>Menig 1klMenig (England)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (England)</para><para>Private (rank, England)</para><para>Soldado raso (England)</para><para>Menig (grad, England)</para><para>Szeregowy (England)</para><para>Sotamies (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_England">http://rdf.muninn-project.org/ontologies/military#Rank_Private_England</seealso>
    let Rank_Private_England =
        Prefixed_Name(mil, "Rank_Private_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_sergeant_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff sergeant (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Canada</seealso>
    let Rank_Staff_sergeant_Canada =
        Prefixed_Name(mil, "Rank_Staff_sergeant_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_sergeant_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff sergeant (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Staff sergeant (Commonwealth delle nazioni)</para><para>Staff sergeant (Mancomunidad de Naciones)</para><para>Staff sergeant (Commonwealth of Nations)</para><para>Staff sergeant (Commonwealth of Nations)</para><para>Staff sergeant (Commonwealth of Nations)</para><para>Staff sergeant (Samveldet av nasjoner)</para><para>Staff sergeant (Gemenebest van Naties)</para><para>Staff sergeant (Wspólnota Narodów)</para><para>Staff sergeant (Kansainyhteisö)</para><para>Staff sergeant (Commonwealth)</para><para>Staff sergeant (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Commonwealth_of_Nations</seealso>
    let Rank_Staff_sergeant_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Staff_sergeant_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Staff_sergeant_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Staff sergeant (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapour)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapura)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapore)</para><para>Staff sergeant (Singapur)</para><para>Staff sergeant (Singapur)</para><para>Staff sergeant (Singapur)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Singapore</seealso>
    let Rank_Staff_sergeant_Singapore =
        Prefixed_Name(mil, "Rank_Staff_sergeant_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_West</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the West</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West</seealso>
    let Rank_Vice_Admiral_of_the_West =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_West") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_West_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the West (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_England">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_England</seealso>
    let Rank_Vice_Admiral_of_the_West_England =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_West_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_West_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vice-Admiral of the West (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Vice-Admiral of the West (Schottland)</para><para>Vice-Admiral of the West (Skottland)</para><para>Vice-Admiral of the West (Skottland)</para><para>Vice-Admiral of the West (Schotland)</para><para>Vice-Admiral of the West (Skotlanti)</para><para>Vice-Admiral of the West (Scotland)</para><para>Vice-Admiral of the West (Escócia)</para><para>Vice-Admiral of the West (Escocia)</para><para>Vice-Admiral of the West (Szkocja)</para><para>Vice-Admiral of the West (Écosse)</para><para>Vice-Admiral of the West (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Scotland</seealso>
    let Rank_Vice_Admiral_of_the_West_Scotland =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_West_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice-Admiral_of_the_West_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Vice-Admiral of the West (Pays de Galles)</para><para>Vice-Admiral of the West (País de Gales)</para><para>Vice-Admiral of the West (Ð£ÑÐ»ÑÑ)</para><para>Vice-Admiral of the West (Galles)</para><para>Vice-Admiral of the West (Gales)</para><para>Vice-Admiral of the West (Wales)</para><para>Vice-Admiral of the West (Wales)</para><para>Vice-Admiral of the West (Wales)</para><para>Vice-Admiral of the West (Wales)</para><para>Vice-Admiral of the West (Wales)</para><para>Vice-Admiral of the West (Walia)</para><para>Vice-Admiral of the West (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Wales</seealso>
    let Rank_Vice_Admiral_of_the_West_Wales =
        Prefixed_Name(mil, "Rank_Vice-Admiral_of_the_West_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice_admiral_Australia_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vice Admiral (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Vice Admiral (Australië (land))</para><para>Vice Admiral (Australien)</para><para>Vice Admiral (Australien)</para><para>Vice Admiral (Australia)</para><para>Vice Admiral (Austrália)</para><para>Vice Admiral (Australie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia_Australia</seealso>
    let Rank_Vice_admiral_Australia_Australia =
        Prefixed_Name(mil, "Rank_Vice_admiral_Australia_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Vice_admiral_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Vice admiral (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Canada</seealso>
    let Rank_Vice_admiral_Canada =
        Prefixed_Name(mil, "Rank_Vice_admiral_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wachtmeister</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°ÑÐ¼Ð¸ÑÑÑ</para><para>Wachtmeister</para><para>Wachtmeister</para><para>Wachmistrz</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister">http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister</seealso>
    let Rank_Wachtmeister = Prefixed_Name(mil, "Rank_Wachtmeister") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wachtmeister_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°ÑÐ¼Ð¸ÑÑÑ (Germany)</para><para>Wachtmeister (Germany)</para><para>Wachtmeister (Germany)</para><para>Wachmistrz (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Germany</seealso>
    let Rank_Wachtmeister_Germany =
        Prefixed_Name(mil, "Rank_Wachtmeister_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wachtmeister_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°ÑÐ¼Ð¸ÑÑÑ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Wachtmeister (Ryssland)</para><para>Wachtmeister (Russland)</para><para>Wachtmeister (Russland)</para><para>Wachtmeister (Rusland)</para><para>Wachtmeister (Russie)</para><para>Wachtmeister (Russia)</para><para>Wachtmeister (Russia)</para><para>Wachtmeister (Venäjä)</para><para>Wachtmeister (Rússia)</para><para>Wachtmeister (Rusia)</para><para>Wachmistrz (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Russia</seealso>
    let Rank_Wachtmeister_Russia =
        Prefixed_Name(mil, "Rank_Wachtmeister_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:FieldArmy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Armee (Großverband)</para><para>Armée (Unité)</para><para>Field Army</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FieldArmy">http://rdf.muninn-project.org/ontologies/military#FieldArmy</seealso>
    let FieldArmy = Prefixed_Name(mil, "FieldArmy") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankAbleSeaman_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Able Seaman (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Able Seaman (Commonwealth delle nazioni)</para><para>Able Seaman (Mancomunidad de Naciones)</para><para>Able Seaman (Commonwealth of Nations)</para><para>Able Seaman (Commonwealth of Nations)</para><para>Able Seaman (Commonwealth of Nations)</para><para>Able Seaman (Samveldet av nasjoner)</para><para>Able Seaman (Gemenebest van Naties)</para><para>Able Seaman (Wspólnota Narodów)</para><para>Able Seaman (Kansainyhteisö)</para><para>Able Seaman (Commonwealth)</para><para>Able Seaman (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Commonwealth_of_Nations</seealso>
    let RankAbleSeaman_Commonwealth_of_Nations =
        Prefixed_Name(mil, "RankAbleSeaman_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankBandsmanArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Bandsman (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankBandsmanArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankBandsmanArmyCanada+</seealso>
    let ``RankBandsmanArmyCanada+`` =
        Prefixed_Name(mil, "RankBandsmanArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankBoyArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Boy (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankBoyArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankBoyArmyCanada</seealso>
    let RankBoyArmyCanada = Prefixed_Name(mil, "RankBoyArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chorbaji_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð§Ð¾ÑÐ±Ð°Ð´Ð¶Ð¸ (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>ÃorbacÄ± (Repubblica delle Sette Isole Unite)</para><para>ÃorbacÄ± (RepÃºblica de las Islas JÃ³nicas)</para><para>ÃorbacÄ± (Republiek van de Zeven Eilanden)</para><para>ÃorbacÄ± (RÃ©publique des Sept-Ãles)</para><para>ÃorbacÄ± (Republika Siedmiu Wysp)</para><para>ÃorbacÄ± (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Septinsular_Republic</seealso>
    let Rank_Chorbaji_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Chorbaji_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chowqzy_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¥Ð¾ÑÑÐ½Ð¶Ð¸Ð¹ (Poland)</para><para>ChorÄÅ¼y (Poland)</para><para>ChorÄÅ¼y (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Poland</seealso>
    let Rank_Chowqzy_Poland = Prefixed_Name(mil, "Rank_Chowqzy_Poland") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Chowqzy_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¥Ð¾ÑÑÐ½Ð¶Ð¸Ð¹ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>ChorÄÅ¼y (Russland)</para><para>ChorÄÅ¼y (Russland)</para><para>ChorÄÅ¼y (Ryssland)</para><para>ChorÄÅ¼y (VenÃ¤jÃ¤)</para><para>ChorÄÅ¼y (RÃºssia)</para><para>ChorÄÅ¼y (Rusland)</para><para>ChorÄÅ¼y (Russia)</para><para>ChorÄÅ¼y (Russia)</para><para>ChorÄÅ¼y (Russie)</para><para>ChorÄÅ¼y (Rosja)</para><para>ChorÄÅ¼y (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Russia</seealso>
    let Rank_Chowqzy_Russia = Prefixed_Name(mil, "Rank_Chowqzy_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chowqzy_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¥Ð¾ÑÑÐ½Ð¶Ð¸Ð¹ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>ChorÄÅ¼y (Union des rÃ©publiques socialistes soviÃ©tiques)</para><para>ChorÄÅ¼y (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>ChorÄÅ¼y (UniÃ³n SoviÃ©tica)</para><para>ChorÄÅ¼y (UniÃ£o SoviÃ©tica)</para><para>ChorÄÅ¼y (Unione Sovietica)</para><para>ChorÄÅ¼y (Neuvostoliitto)</para><para>ChorÄÅ¼y (Sovjetunionen)</para><para>ChorÄÅ¼y (Sovjetunionen)</para><para>ChorÄÅ¼y (Soviet Union)</para><para>ChorÄÅ¼y (Sowjetunion)</para><para>ChorÄÅ¼y (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Soviet_Union</seealso>
    let Rank_Chowqzy_Soviet_Union =
        Prefixed_Name(mil, "Rank_Chowqzy_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_major_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Drum major (rank) (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Drum major (rank) (Commonwealth delle nazioni)</para><para>Drum major (rank) (Mancomunidad de Naciones)</para><para>Drum major (rank) (Commonwealth of Nations)</para><para>Drum major (rank) (Commonwealth of Nations)</para><para>Drum major (rank) (Commonwealth of Nations)</para><para>Drum major (rank) (Gemenebest van Naties)</para><para>Drum major (rank) (Samveldet av nasjoner)</para><para>Drum major (rank) (Wspólnota Narodów)</para><para>Drum major (rank) (Kansainyhteisö)</para><para>Drum major (rank) (Commonwealth)</para><para>Drum major (rank) (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Commonwealth_of_Nations</seealso>
    let Rank_Drum_major_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Drum_major_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Skeuophoros_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Skeuophoros (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Skeuophoros (Macedonia (ancient kingdom))</para><para>Skeuophoros (Makedonian valtakunta)</para><para>Skeuophoros (StaroÅ¼ytna Macedonia)</para><para>Skeuophoros (Royaume de Macédoine)</para><para>Skeuophoros (Macedonië (oudheid))</para><para>Skeuophoros (Oldtidens Makedonia)</para><para>Skeuophoros (Reino de Macedonia)</para><para>Skeuophoros (Regno di Macedonia)</para><para>Skeuophoros (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Macedonia</seealso>
    let Rank_Skeuophoros_Macedonia =
        Prefixed_Name(mil, "Rank_Skeuophoros_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tetrarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢ÐµÑÑÐ°ÑÑ (Ð·Ð½Ð°ÑÐµÐ½Ð¸Ñ) (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Tetrarch (Det akhaiske forbund)</para><para>Tetrark (Achaiska förbundet)</para><para>Tetrarch (ZwiÄzek Achajski)</para><para>Tetrarch (Achaiischer Bund)</para><para>Tetrarch (Achaeïsche Bond)</para><para>Tetrarkki (Akhaian liitto)</para><para>Tetrarch (Achaean League)</para><para>Tetrarch (Ligue achéenne)</para><para>Tetrarca (Liga Aqueia)</para><para>Tetrarch (Liga Aquea)</para><para>Tetrarch (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Achaean_League</seealso>
    let Rank_Tetrarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Tetrarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trierarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢ÑÐ¸ÐµÑÐ°ÑÑÐ¸Ñ</para><para>Trierarchie</para><para>Triérarchie</para><para>Trierarchia</para><para>Trierarch</para><para>Trierarca</para><para>Trierark</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch">http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch</seealso>
    let Rank_Trierarch = Prefixed_Name(mil, "Rank_Trierarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Trierarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢ÑÐ¸ÐµÑÐ°ÑÑÐ¸Ñ (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Trierark (Det akhaiske forbund)</para><para>Trierarch (Achaiska förbundet)</para><para>Trierarchie (Achaiischer Bund)</para><para>Trierarch (ZwiÄzek Achajski)</para><para>Triérarchie (Ligue achéenne)</para><para>Trierarch (Achaeïsche Bond)</para><para>Trierarch (Akhaian liitto)</para><para>Trierarch (Achaean League)</para><para>Trierarchia (Lega achea)</para><para>Trierarch (Liga Aqueia)</para><para>Trierarca (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Achaean_League</seealso>
    let Rank_Trierarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Trierarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:inUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>In Use</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#inUse">http://rdf.muninn-project.org/ontologies/military#inUse</seealso>
    let inUse = Prefixed_Name(mil, "inUse") |> PrefixedName
    /// <summary>
    ///   <para>mil:information</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:BattleSpace</para>
    ///
    /// labels<para>Information</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#information">http://rdf.muninn-project.org/ontologies/military#information</seealso>
    let information = Prefixed_Name(mil, "information") |> PrefixedName

    /// <summary>
    ///   <para>mil:militaryServiceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Military Service Number</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#militaryServiceNumber">http://rdf.muninn-project.org/ontologies/military#militaryServiceNumber</seealso>
    let militaryServiceNumber =
        Prefixed_Name(mil, "militaryServiceNumber") |> PrefixedName

    /// <summary>
    ///   <para>mil:nextOfKin</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Next Of Kin</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#nextOfKin">http://rdf.muninn-project.org/ontologies/military#nextOfKin</seealso>
    let nextOfKin = Prefixed_Name(mil, "nextOfKin") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankBatterySergeantMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///
    /// labels<para>Battery Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankBatterySergeantMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankBatterySergeantMajorArmyCanada</seealso>
    let RankBatterySergeantMajorArmyCanada =
        Prefixed_Name(mil, "RankBatterySergeantMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankBrigadierGeneralArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Brigadier (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankBrigadierGeneralArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankBrigadierGeneralArmyCanada</seealso>
    let RankBrigadierGeneralArmyCanada =
        Prefixed_Name(mil, "RankBrigadierGeneralArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCaptainNaval</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ 1-Ð³Ð¾ ÑÐ°Ð½Ð³Ð°</para><para>Capitão de mar e guerra</para><para>Capitaine de vaisseau</para><para>Capitano di vascello</para><para>Capitán de navío</para><para>Kapitein-ter-zee</para><para>Captain (naval)</para><para>Kapitän zur See</para><para>Kommodori</para><para>Kommandør</para><para>Kommendör</para><para>Komandor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval">http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval</seealso>
    let RankCaptainNaval = Prefixed_Name(mil, "RankCaptainNaval") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Drum_Major_General_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Drum Major General (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_England">http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_England</seealso>
    let Rank_Drum_Major_General_England =
        Prefixed_Name(mil, "Rank_Drum_Major_General_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lord_High_Admiral_of_the_Wash_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lord High Admiral of the Wash (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Lord High Admiral of the Wash (Schottland)</para><para>Lord High Admiral of the Wash (Schotland)</para><para>Lord High Admiral of the Wash (Skotlanti)</para><para>Lord High Admiral of the Wash (Skottland)</para><para>Lord High Admiral of the Wash (Skottland)</para><para>Lord High Admiral of the Wash (Scotland)</para><para>Lord High Admiral of the Wash (Escocia)</para><para>Lord High Admiral of the Wash (Szkocja)</para><para>Lord High Admiral of the Wash (Escócia)</para><para>Lord High Admiral of the Wash (Écosse)</para><para>Lord High Admiral of the Wash (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Scotland</seealso>
    let Rank_Lord_High_Admiral_of_the_Wash_Scotland =
        Prefixed_Name(mil, "Rank_Lord_High_Admiral_of_the_Wash_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Taxiarch (Macedonia (ancient kingdom))</para><para>Taxiarch (Makedonian valtakunta)</para><para>Taxiarch (StaroÅ¼ytna Macedonia)</para><para>Taxiarch (Royaume de Macédoine)</para><para>Taxiarch (Oldtidens Makedonia)</para><para>Taxiarch (Macedonië (oudheid))</para><para>Taxiarch (Regno di Macedonia)</para><para>Taxiarch (Reino de Macedonia)</para><para>Taxiarch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Macedonia</seealso>
    let Rank_Taxiarch_Macedonia =
        Prefixed_Name(mil, "Rank_Taxiarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Taxiarch_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢Ð°ÐºÑÐ¸Ð°ÑÑ (Timocracy of Sapinetia)</para><para>Taxiarch (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Taxiarch_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Taxiarch_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tetrarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¢ÐµÑÑÐ°ÑÑ (Ð·Ð½Ð°ÑÐµÐ½Ð¸Ñ)</para><para>Tetrarkki</para><para>Tetrarch</para><para>Tetrarch</para><para>Tetrarca</para><para>Tetrarch</para><para>Tetrark</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch">http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch</seealso>
    let Rank_Tetrarch = Prefixed_Name(mil, "Rank_Tetrarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tetrarch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¢ÐµÑÑÐ°ÑÑ (Ð·Ð½Ð°ÑÐµÐ½Ð¸Ñ) (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Tetrarch (Macedonia (ancient kingdom))</para><para>Tetrarch (Macedonia (ancient kingdom))</para><para>Tetrark (Macedonia (ancient kingdom))</para><para>Tetrarkki (Makedonian valtakunta)</para><para>Tetrarch (StaroÅ¼ytna Macedonia)</para><para>Tetrarch (Royaume de Macédoine)</para><para>Tetrarch (Macedonië (oudheid))</para><para>Tetrarch (Oldtidens Makedonia)</para><para>Tetrarch (Reino de Macedonia)</para><para>Tetrarch (Regno di Macedonia)</para><para>Tetrarca (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Macedonia</seealso>
    let Rank_Tetrarch_Macedonia =
        Prefixed_Name(mil, "Rank_Tetrarch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Soldier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Soldier</para><para>Soldat</para><para>Soldat</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Soldier">http://rdf.muninn-project.org/ontologies/military#Soldier</seealso>
    let Soldier = Prefixed_Name(mil, "Soldier") |> PrefixedName
    /// <summary>
    ///   <para>mil:MilitaryRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rang (Militärischen)</para><para>Grade (Militare)</para><para>Rank (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryRank">http://rdf.muninn-project.org/ontologies/military#MilitaryRank</seealso>
    let MilitaryRank = Prefixed_Name(mil, "MilitaryRank") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankAbleSeaman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///
    /// labels<para>Able Seaman (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAbleSeaman">http://rdf.muninn-project.org/ontologies/military#1AIFRankAbleSeaman</seealso>
    let _1AIFRankAbleSeaman = Prefixed_Name(mil, "1AIFRankAbleSeaman") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavyServiceBranch</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///   <para>owl:Class</para>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavyServiceBranch">http://rdf.muninn-project.org/ontologies/military#NavyServiceBranch</seealso>
    let NavyServiceBranch = Prefixed_Name(mil, "NavyServiceBranch") |> PrefixedName
    /// <summary>
    ///   <para>mil:Corps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Corps</para><para>Korps</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Corps">http://rdf.muninn-project.org/ontologies/military#Corps</seealso>
    let Corps = Prefixed_Name(mil, "Corps") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCompanySergeantMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///
    /// labels<para>Company Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajorArmyCanada</seealso>
    let RankCompanySergeantMajorArmyCanada =
        Prefixed_Name(mil, "RankCompanySergeantMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCorporalArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Corporal (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCorporalArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankCorporalArmyCanada+</seealso>
    let ``RankCorporalArmyCanada+`` =
        Prefixed_Name(mil, "RankCorporalArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankDriver_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Driver (rank) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Driver (rank) (Australië (land))</para><para>Driver (rank) (Australien)</para><para>Driver (rank) (Australien)</para><para>Driver (rank) (Australia)</para><para>Driver (rank) (Australia)</para><para>Driver (rank) (Austrália)</para><para>Driver (rank) (Australie)</para><para>Driver (rank) (Australia)</para><para>Driver (rank) (Australia)</para><para>Driver (rank) (Australia)</para><para>Driver (rank) (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Australia">http://rdf.muninn-project.org/ontologies/military#RankDriver_Australia</seealso>
    let RankDriver_Australia =
        Prefixed_Name(mil, "RankDriver_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Combrig</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Prikaatinkomentaja</para><para>ÐÐ¾Ð¼Ð±ÑÐ¸Ð³</para><para>Kombrig</para><para>Kombrig</para><para>Kombrig</para><para>Kombrig</para><para>Combrig</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig">http://rdf.muninn-project.org/ontologies/military#Rank_Combrig</seealso>
    let Rank_Combrig = Prefixed_Name(mil, "Rank_Combrig") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Epihipparch_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Epihipparch (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Epihipparch (Macedonia (ancient kingdom))</para><para>Epihipparch (Makedonian valtakunta)</para><para>Epihipparch (StaroÅ¼ytna Macedonia)</para><para>Epihipparch (Royaume de Macédoine)</para><para>Epihipparch (Macedonië (oudheid))</para><para>Epihipparch (Oldtidens Makedonia)</para><para>Epihipparch (Reino de Macedonia)</para><para>Epihipparch (Regno di Macedonia)</para><para>Epihipparch (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Macedonia</seealso>
    let Rank_Epihipparch_Macedonia =
        Prefixed_Name(mil, "Rank_Epihipparch_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Master_warrant_officer_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Master Warrant Officer (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Canada</seealso>
    let Rank_Master_warrant_officer_Canada =
        Prefixed_Name(mil, "Rank_Master_warrant_officer_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Master_warrant_officer_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Master Warrant Officer (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Master Warrant Officer (Singapura)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapour)</para><para>Master Warrant Officer (Singapore)</para><para>Master Warrant Officer (Singapur)</para><para>Master Warrant Officer (Singapur)</para><para>Master Warrant Officer (Singapur)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Singapore</seealso>
    let Rank_Master_warrant_officer_Singapore =
        Prefixed_Name(mil, "Rank_Master_warrant_officer_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankBombardierArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Bombardier (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankBombardierArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankBombardierArmyCanada</seealso>
    let RankBombardierArmyCanada =
        Prefixed_Name(mil, "RankBombardierArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCadetArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Cadet (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCadetArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankCadetArmyCanada</seealso>
    let RankCadetArmyCanada = Prefixed_Name(mil, "RankCadetArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCaptainArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Captain (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCaptainArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankCaptainArmyCanada</seealso>
    let RankCaptainArmyCanada =
        Prefixed_Name(mil, "RankCaptainArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCaptainNaval_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ 1-Ð³Ð¾ ÑÐ°Ð½Ð³Ð° (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Capitão de mar e guerra (Austrália)</para><para>Kapitein-ter-zee (Australië (land))</para><para>Capitaine de vaisseau (Australie)</para><para>Capitano di vascello (Australia)</para><para>Kapitän zur See (Australien)</para><para>Capitán de navío (Australia)</para><para>Captain (naval) (Australia)</para><para>Kommendör (Australien)</para><para>Kommandør (Australia)</para><para>Kommodori (Australia)</para><para>Komandor (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Australia">http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Australia</seealso>
    let RankCaptainNaval_Australia =
        Prefixed_Name(mil, "RankCaptainNaval_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCaptainNaval_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ 1-Ð³Ð¾ ÑÐ°Ð½Ð³Ð° (Canada)</para><para>Capitão de mar e guerra (Canada)</para><para>Capitaine de vaisseau (Canada)</para><para>Capitano di vascello (Canada)</para><para>Capitán de navío (Canada)</para><para>Kapitein-ter-zee (Canada)</para><para>Kapitän zur See (Canada)</para><para>Captain (naval, Canada)</para><para>Kommodori (Canada)</para><para>Kommandør (Canada)</para><para>Kommendör (Canada)</para><para>Komandor (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Canada">http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Canada</seealso>
    let RankCaptainNaval_Canada =
        Prefixed_Name(mil, "RankCaptainNaval_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ataman_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°Ð¼Ð°Ð½ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Ataman / Otaman (Union des républiques socialistes soviétiques)</para><para>Ataman (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Atamano (Unione Sovietica)</para><para>Atamaani (Neuvostoliitto)</para><para>Atamán (Unión Soviética)</para><para>Ataman (União Soviética)</para><para>Ataman (Sovjetunionen)</para><para>Ataman (Sovjetunionen)</para><para>Ataman (Soviet Union)</para><para>Ataman (Sowjetunion)</para><para>Ataman (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Soviet_Union</seealso>
    let Rank_Ataman_Soviet_Union =
        Prefixed_Name(mil, "Rank_Ataman_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Ataman_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÑÐ°Ð¼Ð°Ð½ (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>Ataman / Otaman (Ukraine)</para><para>Atamaani (Ukraina)</para><para>Atamano (Ucraina)</para><para>Ataman (Oekraïne)</para><para>Ataman (Ukraina)</para><para>Ataman (Ucrânia)</para><para>Ataman (Ukraina)</para><para>Ataman (Ukraina)</para><para>Atamán (Ucrania)</para><para>Ataman (Ukraine)</para><para>Ataman (Ukraine)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Ukraine</seealso>
    let Rank_Ataman_Ukraine = Prefixed_Name(mil, "Rank_Ataman_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Chowqzy_Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¥Ð¾ÑÑÐ½Ð¶Ð¸Ð¹ (Ð£ÐºÑÐ°Ð¸Ð½Ð°)</para><para>ChorÄÅ¼y (OekraÃ¯ne)</para><para>ChorÄÅ¼y (UcrÃ¢nia)</para><para>ChorÄÅ¼y (Ukraine)</para><para>ChorÄÅ¼y (Ucraina)</para><para>ChorÄÅ¼y (Ukraine)</para><para>ChorÄÅ¼y (Ukraina)</para><para>ChorÄÅ¼y (Ukraina)</para><para>ChorÄÅ¼y (Ukraina)</para><para>ChorÄÅ¼y (Ukraine)</para><para>ChorÄÅ¼y (Ucrania)</para><para>ChorÄÅ¼y (Ukraina)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Ukraine">http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Ukraine</seealso>
    let Rank_Chowqzy_Ukraine =
        Prefixed_Name(mil, "Rank_Chowqzy_Ukraine") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lieutenant_colonel_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lieutenant colonel</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_colonel_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_colonel_EnglishTradition</seealso>
    let Rank_Lieutenant_colonel_EnglishTradition =
        Prefixed_Name(mil, "Rank_Lieutenant_colonel_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comandarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Sowjetische Generalsränge</para><para>Komandarm av 2. klasse</para><para>Komandarm av 1. klasse</para><para>Comandarm</para><para>Komandarm</para><para>Komandarm</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm">http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm</seealso>
    let Rank_Comandarm = Prefixed_Name(mil, "Rank_Comandarm") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comandarm_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Comandarm (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Komandarm av 1. klasseKomandarm av 2. klasse (Sovjetunionen)</para><para>Komandarm (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Comandarm (Union des républiques socialistes soviétiques)</para><para>Sowjetische GeneralsrängeKomandarm (Sowjetunion)</para><para>Comandarm (Unione Sovietica)</para><para>Comandarm (União Soviética)</para><para>Comandarm (Unión Soviética)</para><para>Comandarm (Neuvostoliitto)</para><para>Comandarm (Sovjetunionen)</para><para>Comandarm (Soviet Union)</para><para>Comandarm (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Soviet_Union</seealso>
    let Rank_Comandarm_Soviet_Union =
        Prefixed_Name(mil, "Rank_Comandarm_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Combrig_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±ÑÐ¸Ð³ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Prikaatinkomentaja (Venäjä)</para><para>Combrig (Russland)</para><para>Kombrig (Russland)</para><para>Combrig (Ryssland)</para><para>Combrig (Rusland)</para><para>Combrig (Russia)</para><para>Kombrig (Russia)</para><para>Combrig (Russie)</para><para>Combrig (Rússia)</para><para>Kombrig (Rosja)</para><para>Kombrig (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Russia</seealso>
    let Rank_Combrig_Russia = Prefixed_Name(mil, "Rank_Combrig_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Combrig_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±ÑÐ¸Ð³ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Kombrig (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Combrig (Union des républiques socialistes soviétiques)</para><para>Prikaatinkomentaja (Neuvostoliitto)</para><para>Kombrig (Unione Sovietica)</para><para>Kombrig (Unión Soviética)</para><para>Combrig (União Soviética)</para><para>Combrig (Sovjetunionen)</para><para>Combrig (Sovjetunionen)</para><para>Combrig (Soviet Union)</para><para>Combrig (Sovjet-Unie)</para><para>Kombrig (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Soviet_Union</seealso>
    let Rank_Combrig_Soviet_Union =
        Prefixed_Name(mil, "Rank_Combrig_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comcor_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Armeijakunnankomentaja (Venäjä)</para><para>ÐÐ¾Ð¼ÐºÐ¾Ñ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Komkor (Russland)</para><para>Komkor (Russland)</para><para>Comcor (Ryssland)</para><para>Comcor (Rusland)</para><para>Comcor (Rússia)</para><para>Comcor (Russia)</para><para>Comcor (Russie)</para><para>Comcor (Russia)</para><para>Komkor (Rosja)</para><para>Komkor (Rusia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Russia</seealso>
    let Rank_Comcor_Russia = Prefixed_Name(mil, "Rank_Comcor_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comcor_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ¾Ð¼ÐºÐ¾Ñ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Komkor (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Comcor (Union des républiques socialistes soviétiques)</para><para>Armeijakunnankomentaja (Neuvostoliitto)</para><para>Comcor (Unione Sovietica)</para><para>Komkor (Unión Soviética)</para><para>Comcor (União Soviética)</para><para>Komkor (Sovjetunionen)</para><para>Comcor (Sovjetunionen)</para><para>Comcor (Soviet Union)</para><para>Komkor (Sowjetunion)</para><para>Comcor (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Soviet_Union</seealso>
    let Rank_Comcor_Soviet_Union =
        Prefixed_Name(mil, "Rank_Comcor_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comdiv</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Divisioonankomentaja</para><para>ÐÐ¾Ð¼Ð´Ð¸Ð²</para><para>Komdiv</para><para>Komdiv</para><para>Komdiw</para><para>Comdiv</para><para>Komdiv</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv">http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv</seealso>
    let Rank_Comdiv = Prefixed_Name(mil, "Rank_Comdiv") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Comdiv_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Divisioonankomentaja (Venäjä)</para><para>ÐÐ¾Ð¼Ð´Ð¸Ð² (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Comdiv (Ryssland)</para><para>Komdiv (Russland)</para><para>Komdiv (Russland)</para><para>Comdiv (Rusland)</para><para>Comdiv (Russia)</para><para>Comdiv (Rússia)</para><para>Comdiv (Russie)</para><para>Comdiv (Russia)</para><para>Komdiv (Rusia)</para><para>Komdiw (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Russia</seealso>
    let Rank_Comdiv_Russia = Prefixed_Name(mil, "Rank_Comdiv_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Fleet_Board_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Fleet Board (Pays de Galles)</para><para>Fleet Board (País de Gales)</para><para>Fleet Board (Ð£ÑÐ»ÑÑ)</para><para>Fleet Board (Galles)</para><para>Fleet Board (Wales)</para><para>Fleet Board (Wales)</para><para>Fleet Board (Gales)</para><para>Fleet Board (Wales)</para><para>Fleet Board (Wales)</para><para>Fleet Board (Walia)</para><para>Fleet Board (Wales)</para><para>Fleet Board (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Wales</seealso>
    let Rank_Fleet_Board_Wales =
        Prefixed_Name(mil, "Rank_Fleet_Board_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kindral</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Kindral</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral">http://rdf.muninn-project.org/ontologies/military#Rank_Kindral</seealso>
    let Rank_Kindral = Prefixed_Name(mil, "Rank_Kindral") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kindral_Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Kindral (Ð­ÑÑÐ¾Ð½Ð¸Ñ)</para><para>Kindral (Estland)</para><para>Kindral (Estland)</para><para>Kindral (Estónia)</para><para>Kindral (Estonia)</para><para>Kindral (Estland)</para><para>Kindral (Estonie)</para><para>Kindral (Estonia)</para><para>Kindral (Estonia)</para><para>Kindral (Estland)</para><para>Kindral (Estonia)</para><para>Kindral (Viro)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Estonia">http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Estonia</seealso>
    let Rank_Kindral_Estonia =
        Prefixed_Name(mil, "Rank_Kindral_Estonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kindral_Republic_of_Estonia_1920-1940</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Kindral (Republic of Estonia, 1920-1940)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Republic_of_Estonia_1920-1940">http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Republic_of_Estonia_1920-1940</seealso>
    let Rank_Kindral_Republic_of_Estonia_1920_1940 =
        Prefixed_Name(mil, "Rank_Kindral_Republic_of_Estonia_1920-1940") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolagasi</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>KolaÄasÄ±</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi">http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi</seealso>
    let Rank_Kolagasi = Prefixed_Name(mil, "Rank_Kolagasi") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolagasi_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>KolaÄasÄ± (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>KolaÄasÄ± (Cossack Hetmanate)</para><para>KolaÄasÄ± (Hetmanat cosaque)</para><para>KolaÄasÄ± (Hetmanato cosaco)</para><para>KolaÄasÄ± (HetmaÅszczyzna)</para><para>KolaÄasÄ± (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Cossack_Hetmanate</seealso>
    let Rank_Kolagasi_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Kolagasi_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Obergefreiter_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Obergefreiter (Germany)</para><para>Obergefreiter (Germany)</para><para>Ylikorpraali (Germany)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Germany">http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Germany</seealso>
    let Rank_Obergefreiter_Germany =
        Prefixed_Name(mil, "Rank_Obergefreiter_Germany") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Obergefreiter_Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Obergefreiter (Ð¨Ð²ÐµÐ¹ÑÐ°ÑÐ¸Ñ)</para><para>Obergefreiter (Switzerland)</para><para>Obergefreiter (Zwitserland)</para><para>Obergefreiter (Szwajcaria)</para><para>Obergefreiter (Svizzera)</para><para>Obergefreiter (Schweiz)</para><para>Obergefreiter (Schweiz)</para><para>Ylikorpraali (Sveitsi)</para><para>Obergefreiter (Suisse)</para><para>Obergefreiter (Sveits)</para><para>Obergefreiter (Suiza)</para><para>Obergefreiter (Suíça)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Switzerland">http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Switzerland</seealso>
    let Rank_Obergefreiter_Switzerland =
        Prefixed_Name(mil, "Rank_Obergefreiter_Switzerland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberst</para><para>Oberst</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst</seealso>
    let Rank_Oberst = Prefixed_Name(mil, "Rank_Oberst") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Oberst_Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberst (ÐÐ²ÑÑÑÐ¸Ñ)</para><para>Oberst (Oostenrijk)</para><para>Oberst (Österreich)</para><para>Oberst (Österrike)</para><para>Oberst (Østerrike)</para><para>Oberst (Itävalta)</para><para>Oberst (Autriche)</para><para>Oberst (Austria)</para><para>Oberst (Áustria)</para><para>Oberst (Austria)</para><para>Oberst (Austria)</para><para>Oberst (Austria)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Austria">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Austria</seealso>
    let Rank_Oberst_Austria = Prefixed_Name(mil, "Rank_Oberst_Austria") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Private (Dienstgrad)Soldat (Dienstgrad) (Irland)</para><para>Deuxième classeSoldat (grade) (Irlande (pays))</para><para>Private (rank) (República da Irlanda)</para><para>Private (rank) (Republic of Ireland)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Private (rank) (Ierland (land))</para><para>Menig (grad)Menig (Irland)</para><para>Private (rank) (Irlanda)</para><para>Menig 1klMenig (Irland)</para><para>Soldado raso (Irlanda)</para><para>Szeregowy (Irlandia)</para><para>Sotamies (Irlanti)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#Rank_Private_Republic_of_Ireland</seealso>
    let Rank_Private_Republic_of_Ireland =
        Prefixed_Name(mil, "Rank_Private_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Private (Dienstgrad)Soldat (Dienstgrad) (Schottland)</para><para>Deuxième classeSoldat (grade) (Écosse)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Menig (grad)Menig (Skottland)</para><para>Private (rank) (Schotland)</para><para>Menig 1klMenig (Skottland)</para><para>Private (rank) (Scotland)</para><para>Private (rank) (Escócia)</para><para>Private (rank) (Scozia)</para><para>Soldado raso (Escocia)</para><para>Sotamies (Skotlanti)</para><para>Szeregowy (Szkocja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Private_Scotland</seealso>
    let Rank_Private_Scotland =
        Prefixed_Name(mil, "Rank_Private_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Private_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Private (Dienstgrad)Soldat (Dienstgrad) (Wales)</para><para>Deuxième classeSoldat (grade) (Pays de Galles)</para><para>Private (rank) (País de Gales)</para><para>Ð ÑÐ´Ð¾Ð²Ð¾Ð¹ (Ð£ÑÐ»ÑÑ)</para><para>Menig (grad)Menig (Wales)</para><para>Private (rank) (Galles)</para><para>Private (rank) (Wales)</para><para>Menig 1klMenig (Wales)</para><para>Private (rank) (Wales)</para><para>Soldado raso (Gales)</para><para>Szeregowy (Walia)</para><para>Sotamies (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Private_Wales</seealso>
    let Rank_Private_Wales = Prefixed_Name(mil, "Rank_Private_Wales") |> PrefixedName
    /// <summary>
    ///   <para>mil:Rank_Rear_admiral</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Rear admiral</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral">http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral</seealso>
    let Rank_Rear_admiral = Prefixed_Name(mil, "Rank_Rear_admiral") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Rear_admiral_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Rear admiral (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Rear admiral (Australië (land))</para><para>Rear admiral (Australien)</para><para>Rear admiral (Australien)</para><para>Rear admiral (Australia)</para><para>Rear admiral (Australia)</para><para>Rear admiral (Australia)</para><para>Rear admiral (Australie)</para><para>Rear admiral (Australia)</para><para>Rear admiral (Austrália)</para><para>Rear admiral (Australia)</para><para>Rear admiral (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Australia</seealso>
    let Rank_Rear_admiral_Australia =
        Prefixed_Name(mil, "Rank_Rear_admiral_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Rear_admiral_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Rear admiral (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Canada</seealso>
    let Rank_Rear_admiral_Canada =
        Prefixed_Name(mil, "Rank_Rear_admiral_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Regimental Quartermaster Sergeant (Australië (land))</para><para>Regimental Quartermaster Sergeant (Australien)</para><para>Regimental Quartermaster Sergeant (Australien)</para><para>Regimental Quartermaster Sergeant (Australia)</para><para>Regimental Quartermaster Sergeant (Australia)</para><para>Regimental Quartermaster Sergeant (Austrália)</para><para>Regimental Quartermaster Sergeant (Australia)</para><para>Regimental Quartermaster Sergeant (Australia)</para><para>Regimental Quartermaster Sergeant (Australia)</para><para>Regimental Quartermaster Sergeant (Australie)</para><para>Regimental Quartermaster Sergeant (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Australia</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Australia =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Canada</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Canada =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Regimental Quartermaster Sergeant (Commonwealth delle nazioni)</para><para>Regimental Quartermaster Sergeant (Mancomunidad de Naciones)</para><para>Regimental Quartermaster Sergeant (Commonwealth of Nations)</para><para>Regimental Quartermaster Sergeant (Commonwealth of Nations)</para><para>Regimental Quartermaster Sergeant (Commonwealth of Nations)</para><para>Regimental Quartermaster Sergeant (Gemenebest van Naties)</para><para>Regimental Quartermaster Sergeant (Samveldet av nasjoner)</para><para>Regimental Quartermaster Sergeant (Wspólnota Narodów)</para><para>Regimental Quartermaster Sergeant (Kansainyhteisö)</para><para>Regimental Quartermaster Sergeant (Commonwealth)</para><para>Regimental Quartermaster Sergeant (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_England">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_England</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_England =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (República da Irlanda)</para><para>Regimental Quartermaster Sergeant (Republic of Ireland)</para><para>Regimental Quartermaster Sergeant (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Regimental Quartermaster Sergeant (Irlande (pays))</para><para>Regimental Quartermaster Sergeant (Ierland (land))</para><para>Regimental Quartermaster Sergeant (Irlandia)</para><para>Regimental Quartermaster Sergeant (Irlanda)</para><para>Regimental Quartermaster Sergeant (Irlanti)</para><para>Regimental Quartermaster Sergeant (Irlanda)</para><para>Regimental Quartermaster Sergeant (Irland)</para><para>Regimental Quartermaster Sergeant (Irland)</para><para>Regimental Quartermaster Sergeant (Irland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_Quartermaster_Sergeant_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Regimental Quartermaster Sergeant (Pays de Galles)</para><para>Regimental Quartermaster Sergeant (País de Gales)</para><para>Regimental Quartermaster Sergeant (Ð£ÑÐ»ÑÑ)</para><para>Regimental Quartermaster Sergeant (Galles)</para><para>Regimental Quartermaster Sergeant (Gales)</para><para>Regimental Quartermaster Sergeant (Walia)</para><para>Regimental Quartermaster Sergeant (Wales)</para><para>Regimental Quartermaster Sergeant (Wales)</para><para>Regimental Quartermaster Sergeant (Wales)</para><para>Regimental Quartermaster Sergeant (Wales)</para><para>Regimental Quartermaster Sergeant (Wales)</para><para>Regimental Quartermaster Sergeant (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Wales</seealso>
    let Rank_Regimental_Quartermaster_Sergeant_Wales =
        Prefixed_Name(mil, "Rank_Regimental_Quartermaster_Sergeant_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Regimental_sergeant_major_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Regimental sergeant major (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Regimental sergeant major (Australië (land))</para><para>Regimental sergeant major (Australien)</para><para>Regimental sergeant major (Australien)</para><para>Regimental sergeant major (Australia)</para><para>Regimental sergeant major (Australia)</para><para>Regimental sergeant major (Australia)</para><para>Regimental sergeant major (Australia)</para><para>Regimental sergeant major (Australie)</para><para>Regimental sergeant major (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Australia</seealso>
    let Rank_Regimental_sergeant_major_Australia =
        Prefixed_Name(mil, "Rank_Regimental_sergeant_major_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Warrant Officer (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_England">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_England</seealso>
    let Rank_Warrant_officer_United_Kingdom_England =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Warrant Officer (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Warrant Officer (Schottland)</para><para>Warrant Officer (Skottland)</para><para>Warrant Officer (Skottland)</para><para>Warrant Officer (Schotland)</para><para>Warrant Officer (Skotlanti)</para><para>Warrant Officer (Scotland)</para><para>Warrant Officer (Escócia)</para><para>Warrant Officer (Escocia)</para><para>Warrant Officer (Szkocja)</para><para>Warrant Officer (Écosse)</para><para>Warrant Officer (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Scotland</seealso>
    let Rank_Warrant_officer_United_Kingdom_Scotland =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Warrant_officer_United_Kingdom_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Warrant Officer (Pays de Galles)</para><para>Warrant Officer (País de Gales)</para><para>Warrant Officer (Ð£ÑÐ»ÑÑ)</para><para>Warrant Officer (Galles)</para><para>Warrant Officer (Walia)</para><para>Warrant Officer (Wales)</para><para>Warrant Officer (Wales)</para><para>Warrant Officer (Wales)</para><para>Warrant Officer (Wales)</para><para>Warrant Officer (Gales)</para><para>Warrant Officer (Wales)</para><para>Warrant Officer (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Wales</seealso>
    let Rank_Warrant_officer_United_Kingdom_Wales =
        Prefixed_Name(mil, "Rank_Warrant_officer_United_Kingdom_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wing_commander</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Wing commander (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander">http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander</seealso>
    let Rank_Wing_commander = Prefixed_Name(mil, "Rank_Wing_commander") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wing_commander_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Wing commander (rank) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Wing commander (rank) (Australië (land))</para><para>Wing commander (rank) (Australien)</para><para>Wing commander (rank) (Australien)</para><para>Wing commander (rank) (Australia)</para><para>Wing commander (rank) (Australia)</para><para>Wing commander (rank) (Australia)</para><para>Wing commander (rank) (Australia)</para><para>Wing commander (rank) (Australie)</para><para>Wing commander (rank) (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Australia</seealso>
    let Rank_Wing_commander_Australia =
        Prefixed_Name(mil, "Rank_Wing_commander_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wing_commander_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Wing commander (rank, Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Canada</seealso>
    let Rank_Wing_commander_Canada =
        Prefixed_Name(mil, "Rank_Wing_commander_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wing_commander_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Wing commander (rank) (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Wing commander (rank) (Commonwealth delle nazioni)</para><para>Wing commander (rank) (Mancomunidad de Naciones)</para><para>Wing commander (rank) (Commonwealth of Nations)</para><para>Wing commander (rank) (Commonwealth of Nations)</para><para>Wing commander (rank) (Commonwealth of Nations)</para><para>Wing commander (rank) (Gemenebest van Naties)</para><para>Wing commander (rank) (Samveldet av nasjoner)</para><para>Wing commander (rank) (Wspólnota Narodów)</para><para>Wing commander (rank) (Kansainyhteisö)</para><para>Wing commander (rank) (Commonwealth)</para><para>Wing commander (rank) (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Commonwealth_of_Nations</seealso>
    let Rank_Wing_commander_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Wing_commander_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Infantry</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:ArmsType</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Infantry</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Infantry">http://rdf.muninn-project.org/ontologies/military#Infantry</seealso>
    let Infantry = Prefixed_Name(mil, "Infantry") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Corporal_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Korporal</para><para>Corporal</para><para>Caporal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Corporal_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Corporal_EnglishTradition</seealso>
    let Rank_Corporal_EnglishTradition =
        Prefixed_Name(mil, "Rank_Corporal_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lieutenant_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lieutenant (grade militaire)</para><para>Lieutenant</para><para>Lieutenant</para><para>Leutnant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_EnglishTradition</seealso>
    let Rank_Lieutenant_EnglishTradition =
        Prefixed_Name(mil, "Rank_Lieutenant_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankLieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lieutenant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenant">http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenant</seealso>
    let _1AIFRankLieutenant = Prefixed_Name(mil, "1AIFRankLieutenant") |> PrefixedName
    /// <summary>
    ///   <para>mil:CavalryTroop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Troupe de Cavalerie</para><para>Kavallerie Truppe</para><para>Cavalry Troop</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CavalryTroop">http://rdf.muninn-project.org/ontologies/military#CavalryTroop</seealso>
    let CavalryTroop = Prefixed_Name(mil, "CavalryTroop") |> PrefixedName
    /// <summary>
    ///   <para>mil:Non-Combatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Non-Combatant</para><para>Non-Combatant</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Non-Combatant">http://rdf.muninn-project.org/ontologies/military#Non-Combatant</seealso>
    let Non_Combatant = Prefixed_Name(mil, "Non-Combatant") |> PrefixedName
    /// <summary>
    ///   <para>mil:Combatant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Combatant</para><para>Combatant</para><para></para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Combatant">http://rdf.muninn-project.org/ontologies/military#Combatant</seealso>
    let Combatant = Prefixed_Name(mil, "Combatant") |> PrefixedName
    /// <summary>
    ///   <para>mil:Corps_list</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:List</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Corps_list">http://rdf.muninn-project.org/ontologies/military#Corps_list</seealso>
    let Corps_list = Prefixed_Name(mil, "Corps_list") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bootsmann_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾ÑÐ¼Ð°Ð½ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Bootsmann (Russland)</para><para>Bootsmann (Russland)</para><para>Bootsmann (Ryssland)</para><para>Bootsmann (Rusland)</para><para>Bootsmann (Rússia)</para><para>Bootsmann (Venäjä)</para><para>Bootsmann (Russie)</para><para>Bootsmann (Russia)</para><para>Bootsmann (Russia)</para><para>Bootsmann (Rusia)</para><para>Bootsmann (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Russia</seealso>
    let Rank_Bootsmann_Russia =
        Prefixed_Name(mil, "Rank_Bootsmann_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Comcor</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Armeijakunnankomentaja</para><para>ÐÐ¾Ð¼ÐºÐ¾Ñ</para><para>Komkor</para><para>Komkor</para><para>Komkor</para><para>Komkor</para><para>Comcor</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor">http://rdf.muninn-project.org/ontologies/military#Rank_Comcor</seealso>
    let Rank_Comcor = Prefixed_Name(mil, "Rank_Comcor") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Marshal_of_the_Soviet_Union_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°ÑÑÐ°Ð» Ð¡Ð¾Ð²ÐµÑÑÐºÐ¾Ð³Ð¾ Ð¡Ð¾ÑÐ·Ð° (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Maréchal de l'Union soviétique (Union des républiques socialistes soviétiques)</para><para>MarszaÅkowie ZSRR (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Maresciallo dell'Unione Sovietica (Unione Sovietica)</para><para>Mariscal de la Unión Soviética (Unión Soviética)</para><para>Marechal da União Soviética (União Soviética)</para><para>Maarschalk van de Sovjet-Unie (Sovjet-Unie)</para><para>Marshal of the Soviet Union (Soviet Union)</para><para>Neuvostoliiton marsalkka (Neuvostoliitto)</para><para>Marskalk av Sovjetunionen (Sovjetunionen)</para><para>Marskalk av Sovjetunionen (Sovjetunionen)</para><para>Marschall der Sowjetunion (Sowjetunion)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union_Soviet_Union</seealso>
    let Rank_Marshal_of_the_Soviet_Union_Soviet_Union =
        Prefixed_Name(mil, "Rank_Marshal_of_the_Soviet_Union_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polkovnik</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Polkovnik</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik">http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik</seealso>
    let Rank_Polkovnik = Prefixed_Name(mil, "Rank_Polkovnik") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Polkovnik_Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Polkovnik (Poland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Poland">http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Poland</seealso>
    let Rank_Polkovnik_Poland =
        Prefixed_Name(mil, "Rank_Polkovnik_Poland") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryAppointment</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Appointment (Militärischen)</para><para>Appointment (Militare)</para><para>Appointment (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryAppointment">http://rdf.muninn-project.org/ontologies/military#MilitaryAppointment</seealso>
    let MilitaryAppointment = Prefixed_Name(mil, "MilitaryAppointment") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankChaplainArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Non-Combatant</para>
    ///
    /// labels<para>Chaplain (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankChaplainArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankChaplainArmyCanada</seealso>
    let RankChaplainArmyCanada =
        Prefixed_Name(mil, "RankChaplainArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCombatMilitaryRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Combat (military rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank">http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank</seealso>
    let RankCombatMilitaryRank =
        Prefixed_Name(mil, "RankCombatMilitaryRank") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Somatophylakes_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Somatophylakes (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Somatophylakes (Macedonia (ancient kingdom))</para><para>Somatophylakes (Macedonia (ancient kingdom))</para><para>Sômatophylaques (Royaume de Macédoine)</para><para>Somatophylakes (StaroÅ¼ytna Macedonia)</para><para>Somatofylakes (Makedonian valtakunta)</para><para>Somatophylakes (Oldtidens Makedonia)</para><para>Somatophylakes (Reino de Macedonia)</para><para>Somatofilachie (Regno di Macedonia)</para><para>Somatophylax (Macedonië (oudheid))</para><para>Somatophylakes (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Macedonia</seealso>
    let Rank_Somatophylakes_Macedonia =
        Prefixed_Name(mil, "Rank_Somatophylakes_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Flotilla</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Flotylla okrÄtÃ³w</para><para>Ð¤Ð»Ð¾ÑÐ¸Ð»Ð¸Ñ</para><para>Flottielje</para><para>Flottille</para><para>Flottille</para><para>Flotilha</para><para>Flotilla</para><para>Flotilla</para><para>Flottilj</para><para>Flotilla</para><para>Flotila</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Flotilla">http://rdf.muninn-project.org/ontologies/military#Flotilla</seealso>
    let Flotilla = Prefixed_Name(mil, "Flotilla") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavalTaskForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Force opérationnelle (Marine)</para><para>Task Force (Marine)</para><para>Task Force (Naval)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalTaskForce">http://rdf.muninn-project.org/ontologies/military#NavalTaskForce</seealso>
    let NavalTaskForce = Prefixed_Name(mil, "NavalTaskForce") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCombatMilitaryRank_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Combat (military rank) (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Combat (military rank) (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Combat (military rank) (Union des républiques socialistes soviétiques)</para><para>Combat (military rank) (Unione Sovietica)</para><para>Combat (military rank) (União Soviética)</para><para>Combat (military rank) (Unión Soviética)</para><para>Combat (military rank) (Neuvostoliitto)</para><para>Combat (military rank) (Sovjetunionen)</para><para>Combat (military rank) (Sovjetunionen)</para><para>Combat (military rank) (Soviet Union)</para><para>Combat (military rank) (Sowjetunion)</para><para>Combat (military rank) (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Soviet_Union</seealso>
    let RankCombatMilitaryRank_Soviet_Union =
        Prefixed_Name(mil, "RankCombatMilitaryRank_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCommandant</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Commandant (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCommandant">http://rdf.muninn-project.org/ontologies/military#RankCommandant</seealso>
    let RankCommandant = Prefixed_Name(mil, "RankCommandant") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankCompanyQuarterMasterSergeantArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Company Quarter Master Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankCompanyQuarterMasterSergeantArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankCompanyQuarterMasterSergeantArmyCanada+</seealso>
    let ``RankCompanyQuarterMasterSergeantArmyCanada+`` =
        Prefixed_Name(mil, "RankCompanyQuarterMasterSergeantArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankConductorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Conductor (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankConductorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankConductorArmyCanada</seealso>
    let RankConductorArmyCanada =
        Prefixed_Name(mil, "RankConductorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankDriverArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Driver (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankDriverArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankDriverArmyCanada</seealso>
    let RankDriverArmyCanada =
        Prefixed_Name(mil, "RankDriverArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankDriver_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Driver (rank, Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Canada">http://rdf.muninn-project.org/ontologies/military#RankDriver_Canada</seealso>
    let RankDriver_Canada = Prefixed_Name(mil, "RankDriver_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankGeneralArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>General (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankGeneralArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankGeneralArmyCanada</seealso>
    let RankGeneralArmyCanada =
        Prefixed_Name(mil, "RankGeneralArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankGunnerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Trade&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Gunner (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankGunnerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankGunnerArmyCanada</seealso>
    let RankGunnerArmyCanada =
        Prefixed_Name(mil, "RankGunnerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLanceSergeantArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Lance Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLanceSergeantArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankLanceSergeantArmyCanada+</seealso>
    let ``RankLanceSergeantArmyCanada+`` =
        Prefixed_Name(mil, "RankLanceSergeantArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankStoker</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>LStoker</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankStoker">http://rdf.muninn-project.org/ontologies/military#RankStoker</seealso>
    let RankStoker = Prefixed_Name(mil, "RankStoker") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLieutenantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Lieutenant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankLieutenantArmyCanada</seealso>
    let RankLieutenantArmyCanada =
        Prefixed_Name(mil, "RankLieutenantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLieutenantColonelArmyCanada+</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Lieutenant Colonel (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada+">http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada+</seealso>
    let ``RankLieutenantColonelArmyCanada+`` =
        Prefixed_Name(mil, "RankLieutenantColonelArmyCanada+") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankLieutenantGeneralArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para> Lieutenant-General (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantGeneralArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankLieutenantGeneralArmyCanada</seealso>
    let RankLieutenantGeneralArmyCanada =
        Prefixed_Name(mil, "RankLieutenantGeneralArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Colonel_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Colonel</para><para>Colonel</para><para>Oberst</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Colonel_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Colonel_EnglishTradition</seealso>
    let Rank_Colonel_EnglishTradition =
        Prefixed_Name(mil, "Rank_Colonel_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Brigadier_general_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Brigadier general (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Canada</seealso>
    let Rank_Brigadier_general_Canada =
        Prefixed_Name(mil, "Rank_Brigadier_general_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Buffer_Navy</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Buffer (navy)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy">http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy</seealso>
    let Rank_Buffer_Navy = Prefixed_Name(mil, "Rank_Buffer_Navy") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Buffer_Navy_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Buffer (navy) (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Buffer (navy) (Australië (land))</para><para>Buffer (navy) (Australien)</para><para>Buffer (navy) (Australien)</para><para>Buffer (navy) (Australia)</para><para>Buffer (navy) (Australia)</para><para>Buffer (navy) (Australia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Australia</seealso>
    let Rank_Buffer_Navy_Australia =
        Prefixed_Name(mil, "Rank_Buffer_Navy_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Buffer_Navy_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Buffer (navy) (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Buffer (navy) (Commonwealth delle nazioni)</para><para>Buffer (navy) (Mancomunidad de Naciones)</para><para>Buffer (navy) (Commonwealth of Nations)</para><para>Buffer (navy) (Commonwealth of Nations)</para><para>Buffer (navy) (Commonwealth of Nations)</para><para>Buffer (navy) (Samveldet av nasjoner)</para><para>Buffer (navy) (Gemenebest van Naties)</para><para>Buffer (navy) (Wspólnota Narodów)</para><para>Buffer (navy) (Kansainyhteisö)</para><para>Buffer (navy) (Commonwealth)</para><para>Buffer (navy) (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Commonwealth_of_Nations</seealso>
    let Rank_Buffer_Navy_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Buffer_Navy_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ)</para><para>Kapteeni (sotilasarvo)</para><para>Hauptmann (Offizier)</para><para>Capitão (militar)</para><para>Kapitein (rang)</para><para>Kapitan (ranga)</para><para>Captain (OF-2)</para><para>Kaptein (grad)</para><para>Capitaine</para><para>Capitano</para><para>Capitán</para><para>Kapten</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain">http://rdf.muninn-project.org/ontologies/military#Rank_Captain</seealso>
    let Rank_Captain = Prefixed_Name(mil, "Rank_Captain") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_(naval)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_(naval)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_(naval)_EnglishTradition</seealso>
    let ``Rank_Captain_(naval)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Captain_(naval)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Captain_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ°Ð¿Ð¸ÑÐ°Ð½ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ, Canada)</para><para>Kapteeni (sotilasarvo, Canada)</para><para>Hauptmann (Offizier, Canada)</para><para>Capitão (militar, Canada)</para><para>Kapitein (rang, Canada)</para><para>Kapitan (ranga, Canada)</para><para>Kaptein (grad, Canada)</para><para>Captain (OF-2, Canada)</para><para>Capitaine (Canada)</para><para>Capitano (Canada)</para><para>Capitán (Canada)</para><para>Kapten (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Canada</seealso>
    let Rank_Captain_Canada = Prefixed_Name(mil, "Rank_Captain_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_sergeant_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Flight sergeant (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Canada</seealso>
    let Rank_Flight_sergeant_Canada =
        Prefixed_Name(mil, "Rank_Flight_sergeant_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Flight_sergeant_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Flight sergeant (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Flight sergeant (Commonwealth delle nazioni)</para><para>Flight sergeant (Mancomunidad de Naciones)</para><para>Flight sergeant (Commonwealth of Nations)</para><para>Flight sergeant (Commonwealth of Nations)</para><para>Flight sergeant (Commonwealth of Nations)</para><para>Flight sergeant (Gemenebest van Naties)</para><para>Flight sergeant (Samveldet av nasjoner)</para><para>Flight sergeant (Wspólnota Narodów)</para><para>Flight sergeant (Kansainyhteisö)</para><para>Flight sergeant (Commonwealth)</para><para>Flight sergeant (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Commonwealth_of_Nations</seealso>
    let Rank_Flight_sergeant_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Flight_sergeant_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolagasi_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>KolaÄasÄ± (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>KolaÄasÄ± (Repubblica delle Sette Isole Unite)</para><para>KolaÄasÄ± (RepÃºblica de las Islas JÃ³nicas)</para><para>KolaÄasÄ± (Republiek van de Zeven Eilanden)</para><para>KolaÄasÄ± (RÃ©publique des Sept-Ãles)</para><para>KolaÄasÄ± (Republika Siedmiu Wysp)</para><para>KolaÄasÄ± (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Septinsular_Republic</seealso>
    let Rank_Kolagasi_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Kolagasi_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Oberst (Ð¤Ð¸Ð½Ð»ÑÐ½Ð´Ð¸Ñ)</para><para>Oberst (Finlandia)</para><para>Oberst (Finlândia)</para><para>Oberst (Finlandia)</para><para>Oberst (Finlandia)</para><para>Oberst (Finnland)</para><para>Oberst (Finlande)</para><para>Oberst (Finland)</para><para>Oberst (Finland)</para><para>Oberst (Finland)</para><para>Oberst (Finland)</para><para>Oberst (Suomi)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Finland">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Finland</seealso>
    let Rank_Oberst_Finland = Prefixed_Name(mil, "Rank_Oberst_Finland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Starshina_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÐ°ÑÑÐ¸Ð½Ð° (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Starshina (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Starshina (Union des républiques socialistes soviétiques)</para><para>Starshina (Unione Sovietica)</para><para>Starshiná (Unión Soviética)</para><para>Starshina (União Soviética)</para><para>Starshina (Neuvostoliitto)</para><para>Starshina (Sovjetunionen)</para><para>Starshina (Sovjetunionen)</para><para>Starshina (Soviet Union)</para><para>Starshina (Sowjetunion)</para><para>Starshina (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Soviet_Union</seealso>
    let Rank_Starshina_Soviet_Union =
        Prefixed_Name(mil, "Rank_Starshina_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Wachtmeister_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ°ÑÐ¼Ð¸ÑÑÑ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Wachtmeister (Union des républiques socialistes soviétiques)</para><para>Wachmistrz (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Wachtmeister (Unione Sovietica)</para><para>Wachtmeister (União Soviética)</para><para>Wachtmeister (Unión Soviética)</para><para>Wachtmeister (Neuvostoliitto)</para><para>Wachtmeister (Sovjetunionen)</para><para>Wachtmeister (Sovjetunionen)</para><para>Wachtmeister (Soviet Union)</para><para>Wachtmeister (Sowjetunion)</para><para>Wachtmeister (Sovjet-Unie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Soviet_Union</seealso>
    let Rank_Wachtmeister_Soviet_Union =
        Prefixed_Name(mil, "Rank_Wachtmeister_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRank2ndLieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>mil:Soldier</para>
    ///
    /// labels<para>2nd Lieutenant (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndLieutenant">http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndLieutenant</seealso>
    let _1AIFRank2ndLieutenant =
        Prefixed_Name(mil, "1AIFRank2ndLieutenant") |> PrefixedName

    /// <summary>
    ///   <para>mil:MilitaryTrade</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Occupation Professionelle (Militare)</para><para>Trade (Military)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrade">http://rdf.muninn-project.org/ontologies/military#MilitaryTrade</seealso>
    let MilitaryTrade = Prefixed_Name(mil, "MilitaryTrade") |> PrefixedName
    /// <summary>
    ///   <para>mil:CavalrySquadron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Escadron de Cavalerie</para><para>Kavallerie Schwadron</para><para>Cavalry Squadron</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CavalrySquadron">http://rdf.muninn-project.org/ontologies/military#CavalrySquadron</seealso>
    let CavalrySquadron = Prefixed_Name(mil, "CavalrySquadron") |> PrefixedName
    /// <summary>
    ///   <para>mil:Civilian</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Zivilist</para><para>Civilian</para><para>Civil</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Civilian">http://rdf.muninn-project.org/ontologies/military#Civilian</seealso>
    let Civilian = Prefixed_Name(mil, "Civilian") |> PrefixedName
    /// <summary>
    ///   <para>mil:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Role</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Role">http://rdf.muninn-project.org/ontologies/military#Role</seealso>
    let Role = Prefixed_Name(mil, "Role") |> PrefixedName
    /// <summary>
    ///   <para>mil:CorpsUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Corps (Unité d'armée)</para><para>Corps (Unit)</para><para>Korps (Unit)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CorpsUnit">http://rdf.muninn-project.org/ontologies/military#CorpsUnit</seealso>
    let CorpsUnit = Prefixed_Name(mil, "CorpsUnit") |> PrefixedName
    /// <summary>
    ///   <para>mil:CorpsFormation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Korps (Großverband)</para><para>Corps (Formation)</para><para>Corps d'armée</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#CorpsFormation">http://rdf.muninn-project.org/ontologies/military#CorpsFormation</seealso>
    let CorpsFormation = Prefixed_Name(mil, "CorpsFormation") |> PrefixedName
    /// <summary>
    ///   <para>mil:DemiBrigade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Half-Brigade</para><para>Demi-brigade</para><para>Halbbrigade</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#DemiBrigade">http://rdf.muninn-project.org/ontologies/military#DemiBrigade</seealso>
    let DemiBrigade = Prefixed_Name(mil, "DemiBrigade") |> PrefixedName
    /// <summary>
    ///   <para>mil:Depot</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Depot (Military)</para><para>Dépot (Military)</para><para>Depot (Militär)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Depot">http://rdf.muninn-project.org/ontologies/military#Depot</seealso>
    let Depot = Prefixed_Name(mil, "Depot") |> PrefixedName
    /// <summary>
    ///   <para>mil:Navy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Navy">http://rdf.muninn-project.org/ontologies/military#Navy</seealso>
    let Navy = Prefixed_Name(mil, "Navy") |> PrefixedName
    /// <summary>
    ///   <para>mil:DraftedSoldier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Soldat (eingezogen)</para><para>Soldier (Drafted)</para><para>Soldat (Rédigé)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#DraftedSoldier">http://rdf.muninn-project.org/ontologies/military#DraftedSoldier</seealso>
    let DraftedSoldier = Prefixed_Name(mil, "DraftedSoldier") |> PrefixedName
    /// <summary>
    ///   <para>mil:RegularForceSoldier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>regulärer Soldat</para><para>Regular Soldier</para><para>Soldat Régulier</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RegularForceSoldier">http://rdf.muninn-project.org/ontologies/military#RegularForceSoldier</seealso>
    let RegularForceSoldier = Prefixed_Name(mil, "RegularForceSoldier") |> PrefixedName
    /// <summary>
    ///   <para>mil:Enlisted</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>angeworbenen Soldaten</para><para>Hommes de Troupes</para><para>Enlisted Soldier</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Enlisted">http://rdf.muninn-project.org/ontologies/military#Enlisted</seealso>
    let Enlisted = Prefixed_Name(mil, "Enlisted") |> PrefixedName
    /// <summary>
    ///   <para>mil:ExchangeOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Officier d'échange</para><para>Austausch-Offizier</para><para>Exchange Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#ExchangeOfficer">http://rdf.muninn-project.org/ontologies/military#ExchangeOfficer</seealso>
    let ExchangeOfficer = Prefixed_Name(mil, "ExchangeOfficer") |> PrefixedName
    /// <summary>
    ///   <para>mil:FieldArtillery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Artillerie de campagne</para><para>Berittene Kampagne</para><para>Field Artillery</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FieldArtillery">http://rdf.muninn-project.org/ontologies/military#FieldArtillery</seealso>
    let FieldArtillery = Prefixed_Name(mil, "FieldArtillery") |> PrefixedName

    /// <summary>
    ///   <para>mil:FightsPrimarilyOnAndInWater</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:BattleSpace</para>
    ///
    /// labels<para>Water (Battleground)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInWater">http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInWater</seealso>
    let FightsPrimarilyOnAndInWater =
        Prefixed_Name(mil, "FightsPrimarilyOnAndInWater") |> PrefixedName

    /// <summary>
    ///   <para>mil:FlagOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Flaggoffizier</para><para>Flag Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#FlagOfficer">http://rdf.muninn-project.org/ontologies/military#FlagOfficer</seealso>
    let FlagOfficer = Prefixed_Name(mil, "FlagOfficer") |> PrefixedName
    /// <summary>
    ///   <para>mil:NavalOfficer</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Offiziere (Deutsche Marine)</para><para>Officier (Marine)</para><para>Naval Officer</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#NavalOfficer">http://rdf.muninn-project.org/ontologies/military#NavalOfficer</seealso>
    let NavalOfficer = Prefixed_Name(mil, "NavalOfficer") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankStaffSergeantArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///
    /// labels<para>Staff Sergeant (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankStaffSergeantArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankStaffSergeantArmyCanada</seealso>
    let RankStaffSergeantArmyCanada =
        Prefixed_Name(mil, "RankStaffSergeantArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankWarrantOfficerArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Warrant Officer (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankWarrantOfficerArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankWarrantOfficerArmyCanada</seealso>
    let RankWarrantOfficerArmyCanada =
        Prefixed_Name(mil, "RankWarrantOfficerArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Admiral_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Admiral</para><para>Admiral</para><para>Amiral</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_EnglishTradition</seealso>
    let Rank_Admiral_EnglishTradition =
        Prefixed_Name(mil, "Rank_Admiral_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_marshal_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_marshal_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Air_marshal_EnglishTradition</seealso>
    let Rank_Air_marshal_EnglishTradition =
        Prefixed_Name(mil, "Rank_Air_marshal_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_General_officer_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>General officer</para><para>Général</para><para>General</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_General_officer_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_General_officer_EnglishTradition</seealso>
    let Rank_General_officer_EnglishTradition =
        Prefixed_Name(mil, "Rank_General_officer_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Admiral_of_the_fleet_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Admiral of the fleet</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_fleet_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_fleet_EnglishTradition</seealso>
    let Rank_Admiral_of_the_fleet_EnglishTradition =
        Prefixed_Name(mil, "Rank_Admiral_of_the_fleet_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commodore_(rank)_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    /// </remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commodore_(rank)_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Commodore_(rank)_EnglishTradition</seealso>
    let ``Rank_Commodore_(rank)_EnglishTradition`` =
        Prefixed_Name(mil, "Rank_Commodore_(rank)_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Admiral_of_the_Fleet_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ammiraglio della flotta (Russia)</para><para>Admiral of the Fleet (Russia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia</seealso>
    let Rank_Admiral_of_the_Fleet_Russia =
        Prefixed_Name(mil, "Rank_Admiral_of_the_Fleet_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Marshal_of_the_air_force_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Marshal of the air force</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_air_force_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_air_force_EnglishTradition</seealso>
    let Rank_Marshal_of_the_air_force_EnglishTradition =
        Prefixed_Name(mil, "Rank_Marshal_of_the_air_force_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Field_marshal_EnglishTradition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Field marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Field_marshal_EnglishTradition">http://rdf.muninn-project.org/ontologies/military#Rank_Field_marshal_EnglishTradition</seealso>
    let Rank_Field_marshal_EnglishTradition =
        Prefixed_Name(mil, "Rank_Field_marshal_EnglishTradition") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Agha_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>ÐÐ³Ð° (ÑÐ¸ÑÑÐ» Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸ÐºÐ¾Ð²) (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>Agha (Ottoman Empire) (Cossack Hetmanate)</para><para>Agha (Ottoman Empire) (Hetmanato cosaco)</para><para>Aga (wojsko) (HetmaÅszczyzna)</para><para>Agha (Cossack Hetmanate)</para><para>Agha (Cossack Hetmanate)</para><para>Agha (Cossack Hetmanate)</para><para>Agha (Cossack Hetmanate)</para><para>Agha (Hetmanat cosaque)</para><para>Agha (Titel) (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Cossack_Hetmanate</seealso>
    let Rank_Agha_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Agha_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Agha_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ³Ð° (ÑÐ¸ÑÑÐ» Ð²Ð¾ÐµÐ½Ð°ÑÐ°Ð»ÑÐ½Ð¸ÐºÐ¾Ð²) (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>Agha (Ottoman Empire) (Imperio otomano)</para><para>Agha (Ottoman Empire) (Ottomaanse Rijk)</para><para>Agha (Ottoman Empire) (Império Otomano)</para><para>Agha (Ottoman Empire) (Ottoman Empire)</para><para>Aga (wojsko) (Imperium osmaÅskie)</para><para>Agha (Titel) (Osmanisches Reich)</para><para>Agha (Osmanien valtakunta)</para><para>Agha (Det osmanske rike)</para><para>Agha (Impero ottomano)</para><para>Agha (Osmanska riket)</para><para>Agha (Empire ottoman)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Ottoman_Empire</seealso>
    let Rank_Agha_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Agha_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_chief_marshal</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air chief marshal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal">http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal</seealso>
    let Rank_Air_chief_marshal =
        Prefixed_Name(mil, "Rank_Air_chief_marshal") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_chief_marshal_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air chief marshal (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Air chief marshal (Australia)</para><para>Air chief marshal (Austrália)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia</seealso>
    let Rank_Air_chief_marshal_Australia =
        Prefixed_Name(mil, "Rank_Air_chief_marshal_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_chief_marshal_Australia_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air Chief Marshal (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Air Chief Marshal (Australië (land))</para><para>Air Chief Marshal (Australien)</para><para>Air Chief Marshal (Australien)</para><para>Air Chief Marshal (Australia)</para><para>Air Chief Marshal (Australia)</para><para>Air Chief Marshal (Australie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia_Australia</seealso>
    let Rank_Air_chief_marshal_Australia_Australia =
        Prefixed_Name(mil, "Rank_Air_chief_marshal_Australia_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_chief_marshal_Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air chief marshal (Canada)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Canada">http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Canada</seealso>
    let Rank_Air_chief_marshal_Canada =
        Prefixed_Name(mil, "Rank_Air_chief_marshal_Canada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Air_chief_marshal_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Air chief marshal (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Air chief marshal (Commonwealth delle nazioni)</para><para>Air chief marshal (Mancomunidad de Naciones)</para><para>Air chief marshal (Commonwealth of Nations)</para><para>Air chief marshal (Commonwealth of Nations)</para><para>Air chief marshal (Commonwealth of Nations)</para><para>Air chief marshal (Samveldet av nasjoner)</para><para>Air chief marshal (Gemenebest van Naties)</para><para>Air chief marshal (Wspólnota Narodów)</para><para>Air chief marshal (Kansainyhteisö)</para><para>Air chief marshal (Commonwealth)</para><para>Air chief marshal (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Commonwealth_of_Nations</seealso>
    let Rank_Air_chief_marshal_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Air_chief_marshal_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance-corporal_of_horse_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Corporal of Horse (Pays de Galles)</para><para>Lance Corporal of Horse (País de Gales)</para><para>Lance Corporal of Horse (Ð£ÑÐ»ÑÑ)</para><para>Lance Corporal of Horse (Galles)</para><para>Lance Corporal of Horse (Wales)</para><para>Lance Corporal of Horse (Walia)</para><para>Lance Corporal of Horse (Wales)</para><para>Lance Corporal of Horse (Wales)</para><para>Lance Corporal of Horse (Wales)</para><para>Lance Corporal of Horse (Wales)</para><para>Lance Corporal of Horse (Gales)</para><para>Lance Corporal of Horse (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Wales</seealso>
    let Rank_Lance_corporal_of_horse_Wales =
        Prefixed_Name(mil, "Rank_Lance-corporal_of_horse_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance corporal</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal</seealso>
    let Rank_Lance_corporal = Prefixed_Name(mil, "Rank_Lance_corporal") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance corporal (ÐÐ²ÑÑÑÐ°Ð»Ð¸Ñ)</para><para>Lance corporal (Australië (land))</para><para>Lance corporal (Australien)</para><para>Lance corporal (Australien)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Australia)</para><para>Lance corporal (Austrália)</para><para>Lance corporal (Australie)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Australia">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Australia</seealso>
    let Rank_Lance_corporal_Australia =
        Prefixed_Name(mil, "Rank_Lance_corporal_Australia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance corporal (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Lance corporal (Commonwealth delle nazioni)</para><para>Lance corporal (Mancomunidad de Naciones)</para><para>Lance corporal (Commonwealth of Nations)</para><para>Lance corporal (Commonwealth of Nations)</para><para>Lance corporal (Commonwealth of Nations)</para><para>Lance corporal (Gemenebest van Naties)</para><para>Lance corporal (Samveldet av nasjoner)</para><para>Lance corporal (Wspólnota Narodów)</para><para>Lance corporal (Kansainyhteisö)</para><para>Lance corporal (Commonwealth)</para><para>Lance corporal (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Commonwealth_of_Nations</seealso>
    let Rank_Lance_corporal_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Lance_corporal_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance corporal (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_England">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_England</seealso>
    let Rank_Lance_corporal_England =
        Prefixed_Name(mil, "Rank_Lance_corporal_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance corporal (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Lance corporal (Schottland)</para><para>Lance corporal (Skottland)</para><para>Lance corporal (Skotlanti)</para><para>Lance corporal (Schotland)</para><para>Lance corporal (Skottland)</para><para>Lance corporal (Scotland)</para><para>Lance corporal (Szkocja)</para><para>Lance corporal (Escocia)</para><para>Lance corporal (Escócia)</para><para>Lance corporal (Scozia)</para><para>Lance corporal (Écosse)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Scotland</seealso>
    let Rank_Lance_corporal_Scotland =
        Prefixed_Name(mil, "Rank_Lance_corporal_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance corporal (Ð¡Ð¸Ð½Ð³Ð°Ð¿ÑÑ)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapour)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapura)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapore)</para><para>Lance corporal (Singapur)</para><para>Lance corporal (Singapur)</para><para>Lance corporal (Singapur)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Singapore">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Singapore</seealso>
    let Rank_Lance_corporal_Singapore =
        Prefixed_Name(mil, "Rank_Lance_corporal_Singapore") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance_corporal_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance corporal (Pays de Galles)</para><para>Lance corporal (País de Gales)</para><para>Lance corporal (Ð£ÑÐ»ÑÑ)</para><para>Lance corporal (Galles)</para><para>Lance corporal (Wales)</para><para>Lance corporal (Wales)</para><para>Lance corporal (Walia)</para><para>Lance corporal (Wales)</para><para>Lance corporal (Wales)</para><para>Lance corporal (Gales)</para><para>Lance corporal (Wales)</para><para>Lance corporal (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Wales</seealso>
    let Rank_Lance_corporal_Wales =
        Prefixed_Name(mil, "Rank_Lance_corporal_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Phrourarch</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Phrourarch</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch">http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch</seealso>
    let Rank_Phrourarch = Prefixed_Name(mil, "Rank_Phrourarch") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Phrourarch_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Phrourarch (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Phrourarch (Det akhaiske forbund)</para><para>Phrourarch (Achaiska förbundet)</para><para>Phrourarch (ZwiÄzek Achajski)</para><para>Phrourarch (Achaiischer Bund)</para><para>Phrourarch (Achaeïsche Bond)</para><para>Phrourarch (Achaean League)</para><para>Phrourarch (Akhaian liitto)</para><para>Phrourarch (Ligue achéenne)</para><para>Phrourarch (Liga Aqueia)</para><para>Phrourarch (Liga Aquea)</para><para>Phrourarch (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Achaean_League</seealso>
    let Rank_Phrourarch_Achaean_League =
        Prefixed_Name(mil, "Rank_Phrourarch_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Schout-bij-nacht_Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¨Ð°ÑÑÐ±ÐµÐ½Ð°ÑÑ (ÐÐ¸Ð´ÐµÑÐ»Ð°Ð½Ð´Ñ)</para><para>Schout-bij-nacht (Países Baixos)</para><para>Schout-bij-nacht (Países Bajos)</para><para>Schout-bij-nacht (Netherlands)</para><para>Schout-bij-nacht (Paesi Bassi)</para><para>Schout-bij-nacht (Niederlande)</para><para>Schoutbynacht (Nederländerna)</para><para>Schout-bij-nacht (Alankomaat)</para><para>Schout-bij-nacht (Nederland)</para><para>Schout-bij-nacht (Holandia)</para><para>Schout-bij-nacht (Pays-Bas)</para><para>Schoutbynacht (Nederland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Netherlands">http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Netherlands</seealso>
    let Rank_Schout_bij_nacht_Netherlands =
        Prefixed_Name(mil, "Rank_Schout-bij-nacht_Netherlands") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Schout-bij-nacht_Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¨Ð°ÑÑÐ±ÐµÐ½Ð°ÑÑ (Ð Ð¾ÑÑÐ¸Ñ)</para><para>Schout-bij-nacht (Russland)</para><para>Schout-bij-nacht (Rusland)</para><para>Schout-bij-nacht (Venäjä)</para><para>Schout-bij-nacht (Russia)</para><para>Schout-bij-nacht (Russia)</para><para>Schout-bij-nacht (Russie)</para><para>Schout-bij-nacht (Rússia)</para><para>Schoutbynacht (Russland)</para><para>Schoutbynacht (Ryssland)</para><para>Schout-bij-nacht (Rusia)</para><para>Schout-bij-nacht (Rosja)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Russia">http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Russia</seealso>
    let Rank_Schout_bij_nacht_Russia =
        Prefixed_Name(mil, "Rank_Schout-bij-nacht_Russia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Schout-bij-nacht_Soviet_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¨Ð°ÑÑÐ±ÐµÐ½Ð°ÑÑ (Ð¡Ð¾ÑÐ· Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ñ Ð¡Ð¾ÑÐ¸Ð°Ð»Ð¸ÑÑÐ¸ÑÐµÑÐºÐ¸Ñ Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸Ðº)</para><para>Schout-bij-nacht (ZwiÄzek Socjalistycznych Republik Radzieckich)</para><para>Schout-bij-nacht (Union des républiques socialistes soviétiques)</para><para>Schout-bij-nacht (Unione Sovietica)</para><para>Schout-bij-nacht (União Soviética)</para><para>Schout-bij-nacht (Unión Soviética)</para><para>Schout-bij-nacht (Neuvostoliitto)</para><para>Schout-bij-nacht (Soviet Union)</para><para>Schout-bij-nacht (Sovjet-Unie)</para><para>Schout-bij-nacht (Sowjetunion)</para><para>Schoutbynacht (Sovjetunionen)</para><para>Schoutbynacht (Sovjetunionen)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Soviet_Union">http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Soviet_Union</seealso>
    let Rank_Schout_bij_nacht_Soviet_Union =
        Prefixed_Name(mil, "Rank_Schout-bij-nacht_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subaltern_Scotland</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Ð¡ÑÐ±Ð°Ð»ÑÐµÑÐ½-Ð¾ÑÐ¸ÑÐµÑ (Ð¨Ð¾ÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Subalternoffiser (Skottland)</para><para>Subalternofficer (Skottland)</para><para>Subaltern (Schottland)</para><para>Subaltern (Schotland)</para><para>Subaltern (Skotlanti)</para><para>Subaltern (Scotland)</para><para>Subaltern (Szkocja)</para><para>Subaltern (Escócia)</para><para>Subaltern (Escocia)</para><para>Subaltern (Écosse)</para><para>Subaltern (Scozia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Scotland">http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Scotland</seealso>
    let Rank_Subaltern_Scotland =
        Prefixed_Name(mil, "Rank_Subaltern_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subaltern_Wales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Ð¡ÑÐ±Ð°Ð»ÑÐµÑÐ½-Ð¾ÑÐ¸ÑÐµÑ (Ð£ÑÐ»ÑÑ)</para><para>Subaltern (Pays de Galles)</para><para>Subaltern (País de Gales)</para><para>Subalternofficer (Wales)</para><para>Subalternoffiser (Wales)</para><para>Subaltern (Galles)</para><para>Subaltern (Wales)</para><para>Subaltern (Wales)</para><para>Subaltern (Gales)</para><para>Subaltern (Walia)</para><para>Subaltern (Wales)</para><para>Subaltern (Wales)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Wales">http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Wales</seealso>
    let Rank_Subaltern_Wales =
        Prefixed_Name(mil, "Rank_Subaltern_Wales") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subasi_Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>SubaÅi (ÐÐµÑÐ¼Ð°Ð½ÑÐ¸Ð½Ð°)</para><para>SubaÅi (Cossack Hetmanate)</para><para>SubaÅi (Hetmanato cosaco)</para><para>SubaÅi (Hetmanat cosaque)</para><para>SubaÅi (HetmaÅszczyzna)</para><para>SubaÅi (Hetmanat)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Cossack_Hetmanate">http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Cossack_Hetmanate</seealso>
    let Rank_Subasi_Cossack_Hetmanate =
        Prefixed_Name(mil, "Rank_Subasi_Cossack_Hetmanate") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subasi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi">http://rdf.muninn-project.org/ontologies/military#Rank_Subasi</seealso>
    let Rank_Subasi = Prefixed_Name(mil, "Rank_Subasi") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subasi_Ottoman_Empire</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>SubaÅi (ÐÑÐ¼Ð°Ð½ÑÐºÐ°Ñ Ð¸Ð¼Ð¿ÐµÑÐ¸Ñ)</para><para>SubaÅi (Osmanien valtakunta)</para><para>SubaÅi (Imperium osmaÅskie)</para><para>SubaÅi (Det osmanske rike)</para><para>SubaÅi (Osmanisches Reich)</para><para>SubaÅi (ImpÃ©rio Otomano)</para><para>SubaÅi (Ottomaanse Rijk)</para><para>SubaÅi (Impero ottomano)</para><para>SubaÅi (Imperio otomano)</para><para>SubaÅi (Osmanska riket)</para><para>SubaÅi (Ottoman Empire)</para><para>SubaÅi (Empire ottoman)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Ottoman_Empire">http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Ottoman_Empire</seealso>
    let Rank_Subasi_Ottoman_Empire =
        Prefixed_Name(mil, "Rank_Subasi_Ottoman_Empire") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Subasi_Septinsular_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>SubaÅi (Ð ÐµÑÐ¿ÑÐ±Ð»Ð¸ÐºÐ° Ð¡ÐµÐ¼Ð¸ ÐÑÑÑÐ¾Ð²Ð¾Ð²)</para><para>SubaÅi (Repubblica delle Sette Isole Unite)</para><para>SubaÅi (RepÃºblica de las Islas JÃ³nicas)</para><para>SubaÅi (Republiek van de Zeven Eilanden)</para><para>SubaÅi (RÃ©publique des Sept-Ãles)</para><para>SubaÅi (Republika Siedmiu Wysp)</para><para>SubaÅi (Septinsular Republic)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Septinsular_Republic">http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Septinsular_Republic</seealso>
    let Rank_Subasi_Septinsular_Republic =
        Prefixed_Name(mil, "Rank_Subasi_Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Syntagmatarchis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Syntagmatarchis</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis">http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis</seealso>
    let Rank_Syntagmatarchis =
        Prefixed_Name(mil, "Rank_Syntagmatarchis") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Syntagmatarchis_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Syntagmatarchis (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Syntagmatarchis (Det akhaiske forbund)</para><para>Syntagmatarchis (Achaiska förbundet)</para><para>Syntagmatarchis (ZwiÄzek Achajski)</para><para>Syntagmatarchis (Achaiischer Bund)</para><para>Syntagmatarchis (Achaeïsche Bond)</para><para>Syntagmatarchis (Akhaian liitto)</para><para>Syntagmatarchis (Achaean League)</para><para>Syntagmatarchis (Ligue achéenne)</para><para>Syntagmatarchis (Liga Aqueia)</para><para>Syntagmatarchis (Liga Aquea)</para><para>Syntagmatarchis (Lega achea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Achaean_League</seealso>
    let Rank_Syntagmatarchis_Achaean_League =
        Prefixed_Name(mil, "Rank_Syntagmatarchis_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Syntagmatarchis_Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Syntagmatarchis (Griechenland)</para><para>Syntagmatarchis (ÐÑÐµÑÐ¸Ñ)</para><para>Syntagmatarchis (Griekenland)</para><para>Syntagmatarchis (Grekland)</para><para>Syntagmatarchis (Kreikka)</para><para>Syntagmatarchis (Greece)</para><para>Syntagmatarchis (Grecia)</para><para>Syntagmatarchis (Grecia)</para><para>Syntagmatarchis (Grécia)</para><para>Syntagmatarchis (Grecja)</para><para>Syntagmatarchis (Hellas)</para><para>Syntagmatarchis (Grèce)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Greece">http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Greece</seealso>
    let Rank_Syntagmatarchis_Greece =
        Prefixed_Name(mil, "Rank_Syntagmatarchis_Greece") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Syntagmatarchis_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Syntagmatarchis (ÐÑÐµÐ²Ð½ÑÑ ÐÐ°ÐºÐµÐ´Ð¾Ð½Ð¸Ñ)</para><para>Syntagmatarchis (Macedonia (ancient kingdom))</para><para>Syntagmatarchis (Makedonian valtakunta)</para><para>Syntagmatarchis (StaroÅ¼ytna Macedonia)</para><para>Syntagmatarchis (Royaume de Macédoine)</para><para>Syntagmatarchis (Macedonië (oudheid))</para><para>Syntagmatarchis (Oldtidens Makedonia)</para><para>Syntagmatarchis (Reino de Macedonia)</para><para>Syntagmatarchis (Regno di Macedonia)</para><para>Syntagmatarchis (Macedónia Antiga)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Macedonia">http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Macedonia</seealso>
    let Rank_Syntagmatarchis_Macedonia =
        Prefixed_Name(mil, "Rank_Syntagmatarchis_Macedonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Syntagmatarchis (Timocracy of Sapinetia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia">http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia</seealso>
    let Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia =
        Prefixed_Name(mil, "Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tagmatarchis</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Tagmatarchis</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis">http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis</seealso>
    let Rank_Tagmatarchis = Prefixed_Name(mil, "Rank_Tagmatarchis") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Tagmatarchis_Achaean_League</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Tagmatarchis (ÐÑÐµÐ¹ÑÐºÐ¸Ð¹ ÑÐ¾ÑÐ·)</para><para>Tagmatarchis (Det akhaiske forbund)</para><para>Tagmatarchis (Achaiska förbundet)</para><para>Tagmatarchis (ZwiÄzek Achajski)</para><para>Tagmatarchis (Achaiischer Bund)</para><para>Tagmatarchis (Achaeïsche Bond)</para><para>Tagmatarchis (Ligue achéenne)</para><para>Tagmatarchis (Achaean League)</para><para>Tagmatarchis (Akhaian liitto)</para><para>Tagmatarchis (Liga Aqueia)</para><para>Tagmatarchis (Lega achea)</para><para>Tagmatarchis (Liga Aquea)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Achaean_League">http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Achaean_League</seealso>
    let Rank_Tagmatarchis_Achaean_League =
        Prefixed_Name(mil, "Rank_Tagmatarchis_Achaean_League") |> PrefixedName

    /// <summary>
    ///   <para>mil:datasetdefinition</para>
    /// </summary>
    /// <remarks>
    ///   <para>void:Dataset</para>
    ///   <para>This object is void dataset container for covinience.</para>
    /// labels<para>The Muninn Military Ontology</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#datasetdefinition">http://rdf.muninn-project.org/ontologies/military#datasetdefinition</seealso>
    let datasetdefinition = Prefixed_Name(mil, "datasetdefinition") |> PrefixedName
    /// <summary>
    ///   <para>mil:RankAbleSeaman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Able Seaman</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman">http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman</seealso>
    let RankAbleSeaman = Prefixed_Name(mil, "RankAbleSeaman") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankAirMechanicClassII</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:Soldier</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Air Mechanic Class II (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassII">http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassII</seealso>
    let _1AIFRankAirMechanicClassII =
        Prefixed_Name(mil, "1AIFRankAirMechanicClassII") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Bombardier</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>ÐÐ¾Ð¼Ð±Ð°ÑÐ´Ð¸Ñ (Ð²Ð¾Ð¸Ð½ÑÐºÐ¾Ðµ Ð·Ð²Ð°Ð½Ð¸Ðµ)</para><para>Bombardier (stopieÅ)</para><para>Bombardier (rank)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier">http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier</seealso>
    let Rank_Bombardier = Prefixed_Name(mil, "Rank_Bombardier") |> PrefixedName
    /// <summary>
    ///   <para>mil:1AIFRankCaptain</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Captain (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCaptain">http://rdf.muninn-project.org/ontologies/military#1AIFRankCaptain</seealso>
    let _1AIFRankCaptain = Prefixed_Name(mil, "1AIFRankCaptain") |> PrefixedName
    /// <summary>
    ///   <para>mil:Chaplain</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#MilitaryTrade&gt;</para>
    ///
    /// labels<para>Chaplain (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Chaplain">http://rdf.muninn-project.org/ontologies/military#Chaplain</seealso>
    let Chaplain = Prefixed_Name(mil, "Chaplain") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Company Quartermaster Sergeant</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant</seealso>
    let Rank_Company_Quartermaster_Sergeant =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>mil:1AIFRankCompanySergeantMajor</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryAppointment</para>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryTrade</para>
    ///   <para>mil:Soldier</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Company Sergeant Major (1st AIF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanySergeantMajor">http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanySergeantMajor</seealso>
    let _1AIFRankCompanySergeantMajor =
        Prefixed_Name(mil, "1AIFRankCompanySergeantMajor") |> PrefixedName

    /// <summary>
    ///   <para>mil:Fireteam</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fireteam (Military Unit)</para><para>Trupp (Militär)</para><para>Fireteam?</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Fireteam">http://rdf.muninn-project.org/ontologies/military#Fireteam</seealso>
    let Fireteam = Prefixed_Name(mil, "Fireteam") |> PrefixedName

    /// <summary>
    ///   <para>mil:RankSergeantMajorArmyCanada</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://rdf.muninn-project.org/ontologies/organization#Appointment&gt;</para>
    ///   <para>mil:Rank</para>
    ///
    /// labels<para>Sergeant Major (CEF)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#RankSergeantMajorArmyCanada">http://rdf.muninn-project.org/ontologies/military#RankSergeantMajorArmyCanada</seealso>
    let RankSergeantMajorArmyCanada =
        Prefixed_Name(mil, "RankSergeantMajorArmyCanada") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Commandeur</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Commandeur (marine)</para><para>Commandeur</para><para>Commandeur</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur">http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur</seealso>
    let Rank_Commandeur = Prefixed_Name(mil, "Rank_Commandeur") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (Ð¡Ð¾Ð´ÑÑÐ¶ÐµÑÑÐ²Ð¾ Ð½Ð°ÑÐ¸Ð¹)</para><para>Company Quartermaster Sergeant (Commonwealth delle nazioni)</para><para>Company Quartermaster Sergeant (Mancomunidad de Naciones)</para><para>Company Quartermaster Sergeant (Commonwealth of Nations)</para><para>Company Quartermaster Sergeant (Commonwealth of Nations)</para><para>Company Quartermaster Sergeant (Commonwealth of Nations)</para><para>Company Quartermaster Sergeant (Gemenebest van Naties)</para><para>Company Quartermaster Sergeant (Samveldet av nasjoner)</para><para>Company Quartermaster Sergeant (Wspólnota Narodów)</para><para>Company Quartermaster Sergeant (Kansainyhteisö)</para><para>Company Quartermaster Sergeant (Commonwealth)</para><para>Company Quartermaster Sergeant (Samväldet)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations</seealso>
    let Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_England">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_England</seealso>
    let Rank_Company_Quartermaster_Sergeant_England =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Company Quartermaster Sergeant (República da Irlanda)</para><para>Company Quartermaster Sergeant (Republic of Ireland)</para><para>Company Quartermaster Sergeant (ÐÑÐ»Ð°Ð½Ð´Ð¸Ñ)</para><para>Company Quartermaster Sergeant (Ierland (land))</para><para>Company Quartermaster Sergeant (Irlande (pays))</para><para>Company Quartermaster Sergeant (Irlandia)</para><para>Company Quartermaster Sergeant (Irlanda)</para><para>Company Quartermaster Sergeant (Irlanti)</para><para>Company Quartermaster Sergeant (Irlanda)</para><para>Company Quartermaster Sergeant (Irland)</para><para>Company Quartermaster Sergeant (Irland)</para><para>Company Quartermaster Sergeant (Irland)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland">http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland</seealso>
    let Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland =
        Prefixed_Name(mil, "Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolonel</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Kolonel</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel">http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel</seealso>
    let Rank_Kolonel = Prefixed_Name(mil, "Rank_Kolonel") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolonel_Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Kolonel (ÐÐµÐ»ÑÐ³Ð¸Ñ)</para><para>Kolonel (Belgique)</para><para>Kolonel (Belgien)</para><para>Kolonel (Bélgica)</para><para>Kolonel (Bélgica)</para><para>Kolonel (Belgium)</para><para>Kolonel (Belgien)</para><para>Kolonel (België)</para><para>Kolonel (Belgia)</para><para>Kolonel (Belgia)</para><para>Kolonel (Belgio)</para><para>Kolonel (Belgia)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Belgium">http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Belgium</seealso>
    let Rank_Kolonel_Belgium =
        Prefixed_Name(mil, "Rank_Kolonel_Belgium") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolonel_Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Kolonel (Ð­ÑÑÐ¾Ð½Ð¸Ñ)</para><para>Kolonel (Estonia)</para><para>Kolonel (Estonia)</para><para>Kolonel (Estland)</para><para>Kolonel (Estland)</para><para>Kolonel (Estónia)</para><para>Kolonel (Estonie)</para><para>Kolonel (Estland)</para><para>Kolonel (Estonia)</para><para>Kolonel (Estland)</para><para>Kolonel (Estonia)</para><para>Kolonel (Viro)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Estonia">http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Estonia</seealso>
    let Rank_Kolonel_Estonia =
        Prefixed_Name(mil, "Rank_Kolonel_Estonia") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolonel_Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Kolonel (ÐÐ¸Ð´ÐµÑÐ»Ð°Ð½Ð´Ñ)</para><para>Kolonel (Nederländerna)</para><para>Kolonel (Países Baixos)</para><para>Kolonel (Países Bajos)</para><para>Kolonel (Niederlande)</para><para>Kolonel (Paesi Bassi)</para><para>Kolonel (Netherlands)</para><para>Kolonel (Alankomaat)</para><para>Kolonel (Nederland)</para><para>Kolonel (Nederland)</para><para>Kolonel (Holandia)</para><para>Kolonel (Pays-Bas)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Netherlands">http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Netherlands</seealso>
    let Rank_Kolonel_Netherlands =
        Prefixed_Name(mil, "Rank_Kolonel_Netherlands") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Kolonel_Republic_of_Estonia_1920-1940</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Kolonel (Republic of Estonia, 1920-1940)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Republic_of_Estonia_1920-1940">http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Republic_of_Estonia_1920-1940</seealso>
    let Rank_Kolonel_Republic_of_Estonia_1920_1940 =
        Prefixed_Name(mil, "Rank_Kolonel_Republic_of_Estonia_1920-1940") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance-corporal_of_horse</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Lance Corporal of Horse</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse">http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse</seealso>
    let Rank_Lance_corporal_of_horse =
        Prefixed_Name(mil, "Rank_Lance-corporal_of_horse") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Lance-corporal_of_horse_England</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>mil:MilitaryRank</para>
    ///
    /// labels<para>Lance Corporal of Horse (England)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_England">http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_England</seealso>
    let Rank_Lance_corporal_of_horse_England =
        Prefixed_Name(mil, "Rank_Lance-corporal_of_horse_England") |> PrefixedName

    /// <summary>
    ///   <para>mil:Rank_Oberst_Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>mil:MilitaryRank</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>Oberst (Ð¨Ð²ÐµÑÐ¸Ñ)</para><para>Oberst (Schweden)</para><para>Oberst (Sverige)</para><para>Oberst (Szwecja)</para><para>Oberst (Sverige)</para><para>Oberst (Svezia)</para><para>Oberst (Suecia)</para><para>Oberst (Suécia)</para><para>Oberst (Zweden)</para><para>Oberst (Sweden)</para><para>Oberst (Ruotsi)</para><para>Oberst (Suède)</para></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Sweden">http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Sweden</seealso>
    let Rank_Oberst_Sweden = Prefixed_Name(mil, "Rank_Oberst_Sweden") |> PrefixedName
