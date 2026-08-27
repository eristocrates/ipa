namespace http.dbpedia.org.resource.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module resource =
    let _namespace_iri = Namespace_Iri resource |> NamespaceIRI

    /// <summary>
    ///   <para>planet:resource/%C3%87orbac%C4%B1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/%C3%87orbac%C4%B1">http://dbpedia.org/resource/%C3%87orbac%C4%B1</seealso>
    let ``_%C3%87orbac%C4%B1`` =
        Prefixed_Name(resource, "%C3%87orbac%C4%B1") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/.dwg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/.dwg">http://dbpedia.org/resource/.dwg</seealso>
    let ``_.dwg`` = Prefixed_Name(resource, ".dwg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/:Carpentry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/:Carpentry">http://dbpedia.org/resource/:Carpentry</seealso>
    let ``_:Carpentry`` = Prefixed_Name(resource, ":Carpentry") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/ACRISS_Car_Classification_Code</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/ACRISS_Car_Classification_Code">http://dbpedia.org/resource/ACRISS_Car_Classification_Code</seealso>
    let ACRISS_Car_Classification_Code =
        Prefixed_Name(resource, "ACRISS_Car_Classification_Code") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Able_seaman_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Able_seaman_%28rank%29">http://dbpedia.org/resource/Able_seaman_%28rank%29</seealso>
    let ``Able_seaman_%28rank%29`` =
        Prefixed_Name(resource, "Able_seaman_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Abolition_of_monarchy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Abolition_of_monarchy">http://dbpedia.org/resource/Abolition_of_monarchy</seealso>
    let Abolition_of_monarchy =
        Prefixed_Name(resource, "Abolition_of_monarchy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Abolitionism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Abolitionism">http://dbpedia.org/resource/Abolitionism</seealso>
    let Abolitionism = Prefixed_Name(resource, "Abolitionism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Abortion-rights_movements</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Abortion-rights_movements">http://dbpedia.org/resource/Abortion-rights_movements</seealso>
    let Abortion_rights_movements =
        Prefixed_Name(resource, "Abortion-rights_movements") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Abrahamic_religions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Abrahamic_religions">http://dbpedia.org/resource/Abrahamic_religions</seealso>
    let Abrahamic_religions =
        Prefixed_Name(resource, "Abrahamic_religions") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Accessibility">http://dbpedia.org/resource/Accessibility</seealso>
    let Accessibility = Prefixed_Name(resource, "Accessibility") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Achaean_League</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Achaean_League">http://dbpedia.org/resource/Achaean_League</seealso>
    let Achaean_League = Prefixed_Name(resource, "Achaean_League") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Acrophobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Acrophobia">http://dbpedia.org/resource/Acrophobia</seealso>
    let Acrophobia = Prefixed_Name(resource, "Acrophobia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Admiral</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Admiral">http://dbpedia.org/resource/Admiral</seealso>
    let Admiral = Prefixed_Name(resource, "Admiral") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Admiral_of_the_Fleet_%28Russia%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Admiral_of_the_Fleet_%28Russia%29">http://dbpedia.org/resource/Admiral_of_the_Fleet_%28Russia%29</seealso>
    let ``Admiral_of_the_Fleet_%28Russia%29`` =
        Prefixed_Name(resource, "Admiral_of_the_Fleet_%28Russia%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Admiral_of_the_fleet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Admiral_of_the_fleet">http://dbpedia.org/resource/Admiral_of_the_fleet</seealso>
    let Admiral_of_the_fleet =
        Prefixed_Name(resource, "Admiral_of_the_fleet") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Adriatic_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Adriatic_Sea">http://dbpedia.org/resource/Adriatic_Sea</seealso>
    let Adriatic_Sea = Prefixed_Name(resource, "Adriatic_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Adventism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Adventism">http://dbpedia.org/resource/Adventism</seealso>
    let Adventism = Prefixed_Name(resource, "Adventism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Aegean_Sea_Plate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Aegean_Sea_Plate">http://dbpedia.org/resource/Aegean_Sea_Plate</seealso>
    let Aegean_Sea_Plate = Prefixed_Name(resource, "Aegean_Sea_Plate") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Afghanistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Afghanistan">http://dbpedia.org/resource/Afghanistan</seealso>
    let Afghanistan = Prefixed_Name(resource, "Afghanistan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Africa">http://dbpedia.org/resource/Africa</seealso>
    let Africa = Prefixed_Name(resource, "Africa") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/African-American_Civil_Rights_Movement_(1954%E2%80%931968)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/African-American_Civil_Rights_Movement_(1954%E2%80%931968)">http://dbpedia.org/resource/African-American_Civil_Rights_Movement_(1954%E2%80%931968)</seealso>
    let ``African_American_Civil_Rights_Movement_(1954%E2%80%931968)`` =
        Prefixed_Name(resource, "African-American_Civil_Rights_Movement_(1954%E2%80%931968)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/African_Americans</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/African_Americans">http://dbpedia.org/resource/African_Americans</seealso>
    let African_Americans = Prefixed_Name(resource, "African_Americans") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/African_Red_Slip</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/African_Red_Slip">http://dbpedia.org/resource/African_Red_Slip</seealso>
    let African_Red_Slip = Prefixed_Name(resource, "African_Red_Slip") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/African_diaspora</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/African_diaspora">http://dbpedia.org/resource/African_diaspora</seealso>
    let African_diaspora = Prefixed_Name(resource, "African_diaspora") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Afro-Caribbean</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Afro-Caribbean">http://dbpedia.org/resource/Afro-Caribbean</seealso>
    let Afro_Caribbean = Prefixed_Name(resource, "Afro-Caribbean") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Agave</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Agave">http://dbpedia.org/resource/Agave</seealso>
    let Agave = Prefixed_Name(resource, "Agave") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Agha_%28Ottoman_Empire%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Agha_%28Ottoman_Empire%29">http://dbpedia.org/resource/Agha_%28Ottoman_Empire%29</seealso>
    let ``Agha_%28Ottoman_Empire%29`` =
        Prefixed_Name(resource, "Agha_%28Ottoman_Empire%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Agnosticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Agnosticism">http://dbpedia.org/resource/Agnosticism</seealso>
    let Agnosticism = Prefixed_Name(resource, "Agnosticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ailurophobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ailurophobia">http://dbpedia.org/resource/Ailurophobia</seealso>
    let Ailurophobia = Prefixed_Name(resource, "Ailurophobia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Air</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    ///   <para>"Air"</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Air">http://dbpedia.org/resource/Air</seealso>
    let Air = Prefixed_Name(resource, "Air") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Air_chief_marshal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Air_chief_marshal">http://dbpedia.org/resource/Air_chief_marshal</seealso>
    let Air_chief_marshal = Prefixed_Name(resource, "Air_chief_marshal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Air_commodore</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Air_commodore">http://dbpedia.org/resource/Air_commodore</seealso>
    let Air_commodore = Prefixed_Name(resource, "Air_commodore") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Air_marshal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Air_marshal">http://dbpedia.org/resource/Air_marshal</seealso>
    let Air_marshal = Prefixed_Name(resource, "Air_marshal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Air_vice-marshal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Air_vice-marshal">http://dbpedia.org/resource/Air_vice-marshal</seealso>
    let Air_vice_marshal = Prefixed_Name(resource, "Air_vice-marshal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Airbus</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Airbus SE is a European multinational aerospace corporation. Airbus designs, manufactures and sells civil and military aerospace products worldwide and manufactures aircraft in Europe and various countries outside Europe. The company has three divisions: Commercial Aircraft (Airbus S.A.S.), Defence and Space, and Helicopters, the third being the largest in its industry in terms of revenues and turbine helicopter deliveries."</para>
    /// labels<para>"Airbus"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Airbus">http://dbpedia.org/resource/Airbus</seealso>
    let Airbus = Prefixed_Name(resource, "Airbus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Aircraftman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Aircraftman">http://dbpedia.org/resource/Aircraftman</seealso>
    let Aircraftman = Prefixed_Name(resource, "Aircraftman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Albania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Albania">http://dbpedia.org/resource/Albania</seealso>
    let Albania = Prefixed_Name(resource, "Albania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Algeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Algeria">http://dbpedia.org/resource/Algeria</seealso>
    let Algeria = Prefixed_Name(resource, "Algeria") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Alkaline_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:AlkalineFuelCell</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Alkaline_fuel_cell">http://dbpedia.org/resource/Alkaline_fuel_cell</seealso>
    let Alkaline_fuel_cell =
        Prefixed_Name(resource, "Alkaline_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Allergy">http://dbpedia.org/resource/Allergy</seealso>
    let Allergy = Prefixed_Name(resource, "Allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Alpha_particle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Alpha_particle">http://dbpedia.org/resource/Alpha_particle</seealso>
    let Alpha_particle = Prefixed_Name(resource, "Alpha_particle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Alstom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"Alstom SA is a French multinational rolling stock manufacturer operating worldwide in rail transport markets, active in the fields of passenger transportation, signalling, and locomotives, with products including the AGV, TGV, Eurostar, Avelia and New Pendolino high-speed trains, in addition to suburban, regional and metro trains, and Citadis trams. In 2004, Alstom was again in financial difficulties, having incurred massive unexpected costs (€4 billion) arising from a design flaw inherited from the acquisition of ABB Group's turbine business, in addition to losses in other business sectors."</para>
    /// labels<para>"Alstom"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Alstom">http://dbpedia.org/resource/Alstom</seealso>
    let Alstom = Prefixed_Name(resource, "Alstom") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Alstom_Coradia_Lint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:PassengerTrain</para>
    ///   <para>"The Alstom Coradia LINT is an articulated railcar manufactured by Alstom since 1999, offered in diesel and hydrogen fuel models.The acronym LINT is short for the German "leichter innovativer Nahverkehrstriebwagen" (light innovative local transport rail vehicle). It was designed by Linke-Hofmann-Busch (LHB; acquired 1996 by Alstom) and has been distributed as part of Alstom's Coradia family."</para>
    /// labels<para>"Alstom Coradia Lint"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Alstom_Coradia_Lint">http://dbpedia.org/resource/Alstom_Coradia_Lint</seealso>
    let Alstom_Coradia_Lint =
        Prefixed_Name(resource, "Alstom_Coradia_Lint") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Alstom_Coradia_iLint</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PassengerTrain</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Coradia iLintTM"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Alstom_Coradia_iLint">http://dbpedia.org/resource/Alstom_Coradia_iLint</seealso>
    let Alstom_Coradia_iLint =
        Prefixed_Name(resource, "Alstom_Coradia_iLint") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ambazonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ambazonia">http://dbpedia.org/resource/Ambazonia</seealso>
    let Ambazonia = Prefixed_Name(resource, "Ambazonia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anarchism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anarchism">http://dbpedia.org/resource/Anarchism</seealso>
    let Anarchism = Prefixed_Name(resource, "Anarchism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Andorra</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Andorra">http://dbpedia.org/resource/Andorra</seealso>
    let Andorra = Prefixed_Name(resource, "Andorra") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anglicanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anglicanism">http://dbpedia.org/resource/Anglicanism</seealso>
    let Anglicanism = Prefixed_Name(resource, "Anglicanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anglo-Irish_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anglo-Irish_people">http://dbpedia.org/resource/Anglo-Irish_people</seealso>
    let Anglo_Irish_people =
        Prefixed_Name(resource, "Anglo-Irish_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anglo-Normans</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anglo-Normans">http://dbpedia.org/resource/Anglo-Normans</seealso>
    let Anglo_Normans = Prefixed_Name(resource, "Anglo-Normans") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Angola</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Angola">http://dbpedia.org/resource/Angola</seealso>
    let Angola = Prefixed_Name(resource, "Angola") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anheuser%E2%80%93Busch_InBev</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anheuser%E2%80%93Busch_InBev">http://dbpedia.org/resource/Anheuser%E2%80%93Busch_InBev</seealso>
    let ``Anheuser%E2%80%93Busch_InBev`` =
        Prefixed_Name(resource, "Anheuser%E2%80%93Busch_InBev") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Animal_welfare</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Animal_welfare">http://dbpedia.org/resource/Animal_welfare</seealso>
    let Animal_welfare = Prefixed_Name(resource, "Animal_welfare") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Antechamber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antechamber">http://dbpedia.org/resource/Antechamber</seealso>
    let Antechamber = Prefixed_Name(resource, "Antechamber") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anthypolochagos</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anthypolochagos">http://dbpedia.org/resource/Anthypolochagos</seealso>
    let Anthypolochagos = Prefixed_Name(resource, "Anthypolochagos") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-Americanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Americanism">http://dbpedia.org/resource/Anti-Americanism</seealso>
    let Anti_Americanism = Prefixed_Name(resource, "Anti-Americanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-Apartheid_Movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Apartheid_Movement">http://dbpedia.org/resource/Anti-Apartheid_Movement</seealso>
    let Anti_Apartheid_Movement =
        Prefixed_Name(resource, "Anti-Apartheid_Movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-British_sentiment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-British_sentiment">http://dbpedia.org/resource/Anti-British_sentiment</seealso>
    let Anti_British_sentiment =
        Prefixed_Name(resource, "Anti-British_sentiment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-Catholicism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Catholicism">http://dbpedia.org/resource/Anti-Catholicism</seealso>
    let Anti_Catholicism = Prefixed_Name(resource, "Anti-Catholicism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-Federalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Federalism">http://dbpedia.org/resource/Anti-Federalism</seealso>
    let Anti_Federalism = Prefixed_Name(resource, "Anti-Federalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-Masonry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Masonry">http://dbpedia.org/resource/Anti-Masonry</seealso>
    let Anti_Masonry = Prefixed_Name(resource, "Anti-Masonry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-Zionism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-Zionism">http://dbpedia.org/resource/Anti-Zionism</seealso>
    let Anti_Zionism = Prefixed_Name(resource, "Anti-Zionism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-capitalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-capitalism">http://dbpedia.org/resource/Anti-capitalism</seealso>
    let Anti_capitalism = Prefixed_Name(resource, "Anti-capitalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-clericalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-clericalism">http://dbpedia.org/resource/Anti-clericalism</seealso>
    let Anti_clericalism = Prefixed_Name(resource, "Anti-clericalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-communism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-communism">http://dbpedia.org/resource/Anti-communism</seealso>
    let Anti_communism = Prefixed_Name(resource, "Anti-communism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-fascism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-fascism">http://dbpedia.org/resource/Anti-fascism</seealso>
    let Anti_fascism = Prefixed_Name(resource, "Anti-fascism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-globalization_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-globalization_movement">http://dbpedia.org/resource/Anti-globalization_movement</seealso>
    let Anti_globalization_movement =
        Prefixed_Name(resource, "Anti-globalization_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-imperialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-imperialism">http://dbpedia.org/resource/Anti-imperialism</seealso>
    let Anti_imperialism = Prefixed_Name(resource, "Anti-imperialism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-nuclear_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-nuclear_movement">http://dbpedia.org/resource/Anti-nuclear_movement</seealso>
    let Anti_nuclear_movement =
        Prefixed_Name(resource, "Anti-nuclear_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Anti-racism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-racism">http://dbpedia.org/resource/Anti-racism</seealso>
    let Anti_racism = Prefixed_Name(resource, "Anti-racism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-suffragism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-suffragism">http://dbpedia.org/resource/Anti-suffragism</seealso>
    let Anti_suffragism = Prefixed_Name(resource, "Anti-suffragism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-urbanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-urbanism">http://dbpedia.org/resource/Anti-urbanism</seealso>
    let Anti_urbanism = Prefixed_Name(resource, "Anti-urbanism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Anti-war_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Anti-war_movement">http://dbpedia.org/resource/Anti-war_movement</seealso>
    let Anti_war_movement = Prefixed_Name(resource, "Anti-war_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Antidisestablishmentarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antidisestablishmentarianism">http://dbpedia.org/resource/Antidisestablishmentarianism</seealso>
    let Antidisestablishmentarianism =
        Prefixed_Name(resource, "Antidisestablishmentarianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Antifeminism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antifeminism">http://dbpedia.org/resource/Antifeminism</seealso>
    let Antifeminism = Prefixed_Name(resource, "Antifeminism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Antigua_and_Barbuda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Antigua_and_Barbuda">http://dbpedia.org/resource/Antigua_and_Barbuda</seealso>
    let Antigua_and_Barbuda =
        Prefixed_Name(resource, "Antigua_and_Barbuda") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Antilles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antilles">http://dbpedia.org/resource/Antilles</seealso>
    let Antilles = Prefixed_Name(resource, "Antilles") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Antisemitism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antisemitism">http://dbpedia.org/resource/Antisemitism</seealso>
    let Antisemitism = Prefixed_Name(resource, "Antisemitism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Antisyntagmatarchis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Antisyntagmatarchis">http://dbpedia.org/resource/Antisyntagmatarchis</seealso>
    let Antisyntagmatarchis =
        Prefixed_Name(resource, "Antisyntagmatarchis") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Appeasement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Appeasement">http://dbpedia.org/resource/Appeasement</seealso>
    let Appeasement = Prefixed_Name(resource, "Appeasement") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Arabs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Arabs">http://dbpedia.org/resource/Arabs</seealso>
    let Arabs = Prefixed_Name(resource, "Arabs") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Argentina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Argentina">http://dbpedia.org/resource/Argentina</seealso>
    let Argentina = Prefixed_Name(resource, "Argentina") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Armenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Armenia">http://dbpedia.org/resource/Armenia</seealso>
    let Armenia = Prefixed_Name(resource, "Armenia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Army_General_%28Russia%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Army_General_%28Russia%29">http://dbpedia.org/resource/Army_General_%28Russia%29</seealso>
    let ``Army_General_%28Russia%29`` =
        Prefixed_Name(resource, "Army_General_%28Russia%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Artillery_battery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Artillery_battery">http://dbpedia.org/resource/Artillery_battery</seealso>
    let Artillery_battery = Prefixed_Name(resource, "Artillery_battery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Asceticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Asceticism">http://dbpedia.org/resource/Asceticism</seealso>
    let Asceticism = Prefixed_Name(resource, "Asceticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ashkenazi_Jews</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ashkenazi_Jews">http://dbpedia.org/resource/Ashkenazi_Jews</seealso>
    let Ashkenazi_Jews = Prefixed_Name(resource, "Ashkenazi_Jews") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Asia">http://dbpedia.org/resource/Asia</seealso>
    let Asia = Prefixed_Name(resource, "Asia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Asia-Pacific</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:GeographicMarket</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Asia-Pacific">http://dbpedia.org/resource/Asia-Pacific</seealso>
    let Asia_Pacific = Prefixed_Name(resource, "Asia-Pacific") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Asian_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Asian_people">http://dbpedia.org/resource/Asian_people</seealso>
    let Asian_people = Prefixed_Name(resource, "Asian_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Aspirant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Aspirant">http://dbpedia.org/resource/Aspirant</seealso>
    let Aspirant = Prefixed_Name(resource, "Aspirant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ataman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ataman">http://dbpedia.org/resource/Ataman</seealso>
    let Ataman = Prefixed_Name(resource, "Ataman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Atheism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Atheism">http://dbpedia.org/resource/Atheism</seealso>
    let Atheism = Prefixed_Name(resource, "Atheism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Atmosphere_of_Earth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Atmosphere_of_Earth">http://dbpedia.org/resource/Atmosphere_of_Earth</seealso>
    let Atmosphere_of_Earth =
        Prefixed_Name(resource, "Atmosphere_of_Earth") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Atomic_mass_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Atomic_mass_constant">http://dbpedia.org/resource/Atomic_mass_constant</seealso>
    let Atomic_mass_constant =
        Prefixed_Name(resource, "Atomic_mass_constant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Atomic_mass_unit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Atomic_mass_unit">http://dbpedia.org/resource/Atomic_mass_unit</seealso>
    let Atomic_mass_unit = Prefixed_Name(resource, "Atomic_mass_unit") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Atomic_units</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Atomic_units">http://dbpedia.org/resource/Atomic_units</seealso>
    let Atomic_units = Prefixed_Name(resource, "Atomic_units") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Augmented_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Augmented_chord">http://dbpedia.org/resource/Augmented_chord</seealso>
    let Augmented_chord = Prefixed_Name(resource, "Augmented_chord") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Australia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Australia">http://dbpedia.org/resource/Australia</seealso>
    let Australia = Prefixed_Name(resource, "Australia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Austria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Austria">http://dbpedia.org/resource/Austria</seealso>
    let Austria = Prefixed_Name(resource, "Austria") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Auto_mechanic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Auto_mechanic">http://dbpedia.org/resource/Auto_mechanic</seealso>
    let Auto_mechanic = Prefixed_Name(resource, "Auto_mechanic") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Automobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Automobile">http://dbpedia.org/resource/Automobile</seealso>
    let Automobile = Prefixed_Name(resource, "Automobile") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Average</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Average">http://dbpedia.org/resource/Average</seealso>
    let Average = Prefixed_Name(resource, "Average") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Azerbaijan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Azerbaijan">http://dbpedia.org/resource/Azerbaijan</seealso>
    let Azerbaijan = Prefixed_Name(resource, "Azerbaijan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Azores</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Azores">http://dbpedia.org/resource/Azores</seealso>
    let Azores = Prefixed_Name(resource, "Azores") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bachelor_of_Arts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bachelor_of_Arts">http://dbpedia.org/resource/Bachelor_of_Arts</seealso>
    let Bachelor_of_Arts = Prefixed_Name(resource, "Bachelor_of_Arts") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bachelor_of_Science</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bachelor_of_Science">http://dbpedia.org/resource/Bachelor_of_Science</seealso>
    let Bachelor_of_Science =
        Prefixed_Name(resource, "Bachelor_of_Science") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bahrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bahrain">http://dbpedia.org/resource/Bahrain</seealso>
    let Bahrain = Prefixed_Name(resource, "Bahrain") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Baking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Baking">http://dbpedia.org/resource/Baking</seealso>
    let Baking = Prefixed_Name(resource, "Baking") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Balearic_Sea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Balearic_Sea">http://dbpedia.org/resource/Balearic_Sea</seealso>
    let Balearic_Sea = Prefixed_Name(resource, "Balearic_Sea") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ballard_Power_Systems</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Ballard Power Systems Inc. is a developer and manufacturer of proton exchange membrane (PEM) fuel cell products for markets such as heavy-duty motive (consisting of bus and tram applications), portable power, material handling as well as engineering services. Ballard has designed and shipped over 400 MW of fuel cell products to date."</para>
    /// labels<para>"Ballard Power Systems"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ballard_Power_Systems">http://dbpedia.org/resource/Ballard_Power_Systems</seealso>
    let Ballard_Power_Systems =
        Prefixed_Name(resource, "Ballard_Power_Systems") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bangladesh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bangladesh">http://dbpedia.org/resource/Bangladesh</seealso>
    let Bangladesh = Prefixed_Name(resource, "Bangladesh") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Baptists</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Baptists">http://dbpedia.org/resource/Baptists</seealso>
    let Baptists = Prefixed_Name(resource, "Baptists") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Barbados</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Barbados">http://dbpedia.org/resource/Barbados</seealso>
    let Barbados = Prefixed_Name(resource, "Barbados") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Barley</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Barley">http://dbpedia.org/resource/Barley</seealso>
    let Barley = Prefixed_Name(resource, "Barley") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Battalion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Battalion">http://dbpedia.org/resource/Battalion</seealso>
    let Battalion = Prefixed_Name(resource, "Battalion") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Battery_electric_vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:RoadApplication</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Battery_electric_vehicle">http://dbpedia.org/resource/Battery_electric_vehicle</seealso>
    let Battery_electric_vehicle =
        Prefixed_Name(resource, "Battery_electric_vehicle") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Battle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Battle">http://dbpedia.org/resource/Battle</seealso>
    let Battle = Prefixed_Name(resource, "Battle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Battlespace</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Battlespace">http://dbpedia.org/resource/Battlespace</seealso>
    let Battlespace = Prefixed_Name(resource, "Battlespace") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bay_of_Biscay</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bay_of_Biscay">http://dbpedia.org/resource/Bay_of_Biscay</seealso>
    let Bay_of_Biscay = Prefixed_Name(resource, "Bay_of_Biscay") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Behmenism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Behmenism">http://dbpedia.org/resource/Behmenism</seealso>
    let Behmenism = Prefixed_Name(resource, "Behmenism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Belarus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Belarus">http://dbpedia.org/resource/Belarus</seealso>
    let Belarus = Prefixed_Name(resource, "Belarus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Belgium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Belgium">http://dbpedia.org/resource/Belgium</seealso>
    let Belgium = Prefixed_Name(resource, "Belgium") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Belize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Belize">http://dbpedia.org/resource/Belize</seealso>
    let Belize = Prefixed_Name(resource, "Belize") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bengal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bengal">http://dbpedia.org/resource/Bengal</seealso>
    let Bengal = Prefixed_Name(resource, "Bengal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bengalis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bengalis">http://dbpedia.org/resource/Bengalis</seealso>
    let Bengalis = Prefixed_Name(resource, "Bengalis") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Benin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Benin">http://dbpedia.org/resource/Benin</seealso>
    let Benin = Prefixed_Name(resource, "Benin") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bhutan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bhutan">http://dbpedia.org/resource/Bhutan</seealso>
    let Bhutan = Prefixed_Name(resource, "Bhutan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bicycle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bicycle">http://dbpedia.org/resource/Bicycle</seealso>
    let Bicycle = Prefixed_Name(resource, "Bicycle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Birinci_Ferik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Birinci_Ferik">http://dbpedia.org/resource/Birinci_Ferik</seealso>
    let Birinci_Ferik = Prefixed_Name(resource, "Birinci_Ferik") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Birth_control_movement_in_the_United_States</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Birth_control_movement_in_the_United_States">http://dbpedia.org/resource/Birth_control_movement_in_the_United_States</seealso>
    let Birth_control_movement_in_the_United_States =
        Prefixed_Name(resource, "Birth_control_movement_in_the_United_States") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Black_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Black_Sea">http://dbpedia.org/resource/Black_Sea</seealso>
    let Black_Sea = Prefixed_Name(resource, "Black_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Black_body</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Black_body">http://dbpedia.org/resource/Black_body</seealso>
    let Black_body = Prefixed_Name(resource, "Black_body") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Black_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Black_nationalism">http://dbpedia.org/resource/Black_nationalism</seealso>
    let Black_nationalism = Prefixed_Name(resource, "Black_nationalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Black_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Black_people">http://dbpedia.org/resource/Black_people</seealso>
    let Black_people = Prefixed_Name(resource, "Black_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Blindness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Blindness">http://dbpedia.org/resource/Blindness</seealso>
    let Blindness = Prefixed_Name(resource, "Blindness") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Boarding_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Boarding_school">http://dbpedia.org/resource/Boarding_school</seealso>
    let Boarding_school = Prefixed_Name(resource, "Boarding_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Boat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Boat">http://dbpedia.org/resource/Boat</seealso>
    let Boat = Prefixed_Name(resource, "Boat") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Boeing_Phantom_Eye</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Aircraft</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Boeing Phantom Eye was a high altitude, long endurance (HALE) liquid hydrogen-powered unmanned aerial vehicle developed by Boeing Phantom Works. The aircraft was Boeing's proposal to meet the demand from the US military for unmanned drones designed to provide advanced intelligence and reconnaissance work, driven by the combat conditions in Afghanistan in particular. In August 2016, the Phantom Eye demonstrator was disassembled for display at the Air Force Flight Test Museum."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Boeing_Phantom_Eye">http://dbpedia.org/resource/Boeing_Phantom_Eye</seealso>
    let Boeing_Phantom_Eye =
        Prefixed_Name(resource, "Boeing_Phantom_Eye") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bohemianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bohemianism">http://dbpedia.org/resource/Bohemianism</seealso>
    let Bohemianism = Prefixed_Name(resource, "Bohemianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bohr_magneton</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bohr_magneton">http://dbpedia.org/resource/Bohr_magneton</seealso>
    let Bohr_magneton = Prefixed_Name(resource, "Bohr_magneton") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bolivia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bolivia">http://dbpedia.org/resource/Bolivia</seealso>
    let Bolivia = Prefixed_Name(resource, "Bolivia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bolsheviks</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bolsheviks">http://dbpedia.org/resource/Bolsheviks</seealso>
    let Bolsheviks = Prefixed_Name(resource, "Bolsheviks") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Boltzmann_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Boltzmann_constant">http://dbpedia.org/resource/Boltzmann_constant</seealso>
    let Boltzmann_constant =
        Prefixed_Name(resource, "Boltzmann_constant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bombardier_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bombardier_%28rank%29">http://dbpedia.org/resource/Bombardier_%28rank%29</seealso>
    let ``Bombardier_%28rank%29`` =
        Prefixed_Name(resource, "Bombardier_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bonapartism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bonapartism">http://dbpedia.org/resource/Bonapartism</seealso>
    let Bonapartism = Prefixed_Name(resource, "Bonapartism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bootsmann</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bootsmann">http://dbpedia.org/resource/Bootsmann</seealso>
    let Bootsmann = Prefixed_Name(resource, "Bootsmann") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Bosnia_and_Herzegovina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bosnia_and_Herzegovina">http://dbpedia.org/resource/Bosnia_and_Herzegovina</seealso>
    let Bosnia_and_Herzegovina =
        Prefixed_Name(resource, "Bosnia_and_Herzegovina") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Botswana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Botswana">http://dbpedia.org/resource/Botswana</seealso>
    let Botswana = Prefixed_Name(resource, "Botswana") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bourbon_whiskey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bourbon_whiskey">http://dbpedia.org/resource/Bourbon_whiskey</seealso>
    let Bourbon_whiskey = Prefixed_Name(resource, "Bourbon_whiskey") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Brazil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Brazil">http://dbpedia.org/resource/Brazil</seealso>
    let Brazil = Prefixed_Name(resource, "Brazil") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Brigade</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Brigade">http://dbpedia.org/resource/Brigade</seealso>
    let Brigade = Prefixed_Name(resource, "Brigade") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Brigade_General</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Brigade_General">http://dbpedia.org/resource/Brigade_General</seealso>
    let Brigade_General = Prefixed_Name(resource, "Brigade_General") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Brigadier</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Brigadier">http://dbpedia.org/resource/Brigadier</seealso>
    let Brigadier = Prefixed_Name(resource, "Brigadier") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Brigadier_general</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Brigadier_general">http://dbpedia.org/resource/Brigadier_general</seealso>
    let Brigadier_general = Prefixed_Name(resource, "Brigadier_general") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/British_Indian_Army</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/British_Indian_Army">http://dbpedia.org/resource/British_Indian_Army</seealso>
    let British_Indian_Army =
        Prefixed_Name(resource, "British_Indian_Army") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/British_Rail_Class_799</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:PassengerTrain</para>
    ///   <para>"The British Rail Class 799 are tri-mode multiple units prototype adapted from Class 319 electric multiple units (319001/382). The existing 25 kV AC and 750 V DC equipment has been retained with a hydrogen fuel cell added, currently taking up one of the carriages."</para>
    /// labels<para>"British Rail Class 799"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/British_Rail_Class_799">http://dbpedia.org/resource/British_Rail_Class_799</seealso>
    let British_Rail_Class_799 =
        Prefixed_Name(resource, "British_Rail_Class_799") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/British_Raj</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/British_Raj">http://dbpedia.org/resource/British_Raj</seealso>
    let British_Raj = Prefixed_Name(resource, "British_Raj") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/British_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/British_nationalism">http://dbpedia.org/resource/British_nationalism</seealso>
    let British_nationalism =
        Prefixed_Name(resource, "British_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Brunei</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Brunei">http://dbpedia.org/resource/Brunei</seealso>
    let Brunei = Prefixed_Name(resource, "Brunei") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Buddhism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Buddhism">http://dbpedia.org/resource/Buddhism</seealso>
    let Buddhism = Prefixed_Name(resource, "Buddhism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Buffer_%28navy%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Buffer_%28navy%29">http://dbpedia.org/resource/Buffer_%28navy%29</seealso>
    let ``Buffer_%28navy%29`` =
        Prefixed_Name(resource, "Buffer_%28navy%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Building</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Building">http://dbpedia.org/resource/Building</seealso>
    let Building = Prefixed_Name(resource, "Building") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bulgaria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Bulgaria">http://dbpedia.org/resource/Bulgaria</seealso>
    let Bulgaria = Prefixed_Name(resource, "Bulgaria") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Burkina_Faso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Burkina_Faso">http://dbpedia.org/resource/Burkina_Faso</seealso>
    let Burkina_Faso = Prefixed_Name(resource, "Burkina_Faso") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Burundi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Burundi">http://dbpedia.org/resource/Burundi</seealso>
    let Burundi = Prefixed_Name(resource, "Burundi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bus">http://dbpedia.org/resource/Bus</seealso>
    let Bus = Prefixed_Name(resource, "Bus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Bushido</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Bushido">http://dbpedia.org/resource/Bushido</seealso>
    let Bushido = Prefixed_Name(resource, "Bushido") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Byzantine_Empire</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Byzantine_Empire">http://dbpedia.org/resource/Byzantine_Empire</seealso>
    let Byzantine_Empire = Prefixed_Name(resource, "Byzantine_Empire") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/CHAdeMO</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/CHAdeMO">http://dbpedia.org/resource/CHAdeMO</seealso>
    let CHAdeMO = Prefixed_Name(resource, "CHAdeMO") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/COLLADA</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/COLLADA">http://dbpedia.org/resource/COLLADA</seealso>
    let COLLADA = Prefixed_Name(resource, "COLLADA") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Call</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Call"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Call">http://dbpedia.org/resource/Call</seealso>
    let Call = Prefixed_Name(resource, "Call") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Calvinism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Calvinism">http://dbpedia.org/resource/Calvinism</seealso>
    let Calvinism = Prefixed_Name(resource, "Calvinism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cambodia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cambodia">http://dbpedia.org/resource/Cambodia</seealso>
    let Cambodia = Prefixed_Name(resource, "Cambodia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cameroon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cameroon">http://dbpedia.org/resource/Cameroon</seealso>
    let Cameroon = Prefixed_Name(resource, "Cameroon") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Camisard</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Camisard">http://dbpedia.org/resource/Camisard</seealso>
    let Camisard = Prefixed_Name(resource, "Camisard") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Campaigns_against_corporal_punishment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Campaigns_against_corporal_punishment">http://dbpedia.org/resource/Campaigns_against_corporal_punishment</seealso>
    let Campaigns_against_corporal_punishment =
        Prefixed_Name(resource, "Campaigns_against_corporal_punishment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Canada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Canada">http://dbpedia.org/resource/Canada</seealso>
    let Canada = Prefixed_Name(resource, "Canada") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Canadian_Aviation_Corps</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Canadian_Aviation_Corps">http://dbpedia.org/resource/Canadian_Aviation_Corps</seealso>
    let Canadian_Aviation_Corps =
        Prefixed_Name(resource, "Canadian_Aviation_Corps") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Canary_islands</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Canary_islands">http://dbpedia.org/resource/Canary_islands</seealso>
    let Canary_islands = Prefixed_Name(resource, "Canary_islands") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Canoe</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Canoe">http://dbpedia.org/resource/Canoe</seealso>
    let Canoe = Prefixed_Name(resource, "Canoe") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cape_Verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cape_Verde">http://dbpedia.org/resource/Cape_Verde</seealso>
    let Cape_Verde = Prefixed_Name(resource, "Cape_Verde") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Capital_punishment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Capital_punishment">http://dbpedia.org/resource/Capital_punishment</seealso>
    let Capital_punishment =
        Prefixed_Name(resource, "Capital_punishment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Capitalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Capitalism">http://dbpedia.org/resource/Capitalism</seealso>
    let Capitalism = Prefixed_Name(resource, "Capitalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Captain_%28OF-2%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_%28OF-2%29">http://dbpedia.org/resource/Captain_%28OF-2%29</seealso>
    let ``Captain_%28OF_2%29`` =
        Prefixed_Name(resource, "Captain_%28OF-2%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Captain_%28naval%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_%28naval%29">http://dbpedia.org/resource/Captain_%28naval%29</seealso>
    let ``Captain_%28naval%29`` =
        Prefixed_Name(resource, "Captain_%28naval%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Captain_(OF-2)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_(OF-2)">http://dbpedia.org/resource/Captain_(OF-2)</seealso>
    let ``Captain_(OF_2)`` = Prefixed_Name(resource, "Captain_(OF-2)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Captain_(naval)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_(naval)">http://dbpedia.org/resource/Captain_(naval)</seealso>
    let ``Captain_(naval)`` = Prefixed_Name(resource, "Captain_(naval)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Captain_Lieutenant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_Lieutenant">http://dbpedia.org/resource/Captain_Lieutenant</seealso>
    let Captain_Lieutenant =
        Prefixed_Name(resource, "Captain_Lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Captain_lieutenant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Captain_lieutenant">http://dbpedia.org/resource/Captain_lieutenant</seealso>
    let Captain_lieutenant =
        Prefixed_Name(resource, "Captain_lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Carbonated_water</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Carbonated_water">http://dbpedia.org/resource/Carbonated_water</seealso>
    let Carbonated_water = Prefixed_Name(resource, "Carbonated_water") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Caring_for_people_with_dementia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Caring_for_people_with_dementia">http://dbpedia.org/resource/Caring_for_people_with_dementia</seealso>
    let Caring_for_people_with_dementia =
        Prefixed_Name(resource, "Caring_for_people_with_dementia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Carrier_battle_group</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Carrier_battle_group">http://dbpedia.org/resource/Carrier_battle_group</seealso>
    let Carrier_battle_group =
        Prefixed_Name(resource, "Carrier_battle_group") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Cartesianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Cartesianism">http://dbpedia.org/resource/Cartesianism</seealso>
    let Cartesianism = Prefixed_Name(resource, "Cartesianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Caste_politics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Caste_politics">http://dbpedia.org/resource/Caste_politics</seealso>
    let Caste_politics = Prefixed_Name(resource, "Caste_politics") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Caste_system_in_India</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Caste_system_in_India">http://dbpedia.org/resource/Caste_system_in_India</seealso>
    let Caste_system_in_India =
        Prefixed_Name(resource, "Caste_system_in_India") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Cat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cat">http://dbpedia.org/resource/Cat</seealso>
    let Cat = Prefixed_Name(resource, "Cat") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Catering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Catering">http://dbpedia.org/resource/Catering</seealso>
    let Catering = Prefixed_Name(resource, "Catering") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Catholic_Church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Catholic_Church">http://dbpedia.org/resource/Catholic_Church</seealso>
    let Catholic_Church = Prefixed_Name(resource, "Catholic_Church") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Catholic_emancipation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Catholic_emancipation">http://dbpedia.org/resource/Catholic_emancipation</seealso>
    let Catholic_emancipation =
        Prefixed_Name(resource, "Catholic_emancipation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Cavalry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Cavalry">http://dbpedia.org/resource/Cavalry</seealso>
    let Cavalry = Prefixed_Name(resource, "Cavalry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Celts_(modern)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Celts_(modern)">http://dbpedia.org/resource/Celts_(modern)</seealso>
    let ``Celts_(modern)`` = Prefixed_Name(resource, "Celts_(modern)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Central_African_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Central_African_Republic">http://dbpedia.org/resource/Central_African_Republic</seealso>
    let Central_African_Republic =
        Prefixed_Name(resource, "Central_African_Republic") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Central_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:GeographicMarket</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Central_America">http://dbpedia.org/resource/Central_America</seealso>
    let Central_America = Prefixed_Name(resource, "Central_America") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Central_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Central_Asia">http://dbpedia.org/resource/Central_Asia</seealso>
    let Central_Asia = Prefixed_Name(resource, "Central_Asia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Chad">http://dbpedia.org/resource/Chad</seealso>
    let Chad = Prefixed_Name(resource, "Chad") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chairman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chairman">http://dbpedia.org/resource/Chairman</seealso>
    let Chairman = Prefixed_Name(resource, "Chairman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chartism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chartism">http://dbpedia.org/resource/Chartism</seealso>
    let Chartism = Prefixed_Name(resource, "Chartism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chief_Marshal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chief_Marshal">http://dbpedia.org/resource/Chief_Marshal</seealso>
    let Chief_Marshal = Prefixed_Name(resource, "Chief_Marshal") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Chief_petty_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chief_petty_officer">http://dbpedia.org/resource/Chief_petty_officer</seealso>
    let Chief_petty_officer =
        Prefixed_Name(resource, "Chief_petty_officer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Child_care</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Child_care">http://dbpedia.org/resource/Child_care</seealso>
    let Child_care = Prefixed_Name(resource, "Child_care") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Chile">http://dbpedia.org/resource/Chile</seealso>
    let Chile = Prefixed_Name(resource, "Chile") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chiliarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chiliarch">http://dbpedia.org/resource/Chiliarch</seealso>
    let Chiliarch = Prefixed_Name(resource, "Chiliarch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/China</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"China (Chinese: 中国; pinyin: Zhōngguó), officially the People's Republic of China (PRC; Chinese: 中华人民共和国; pinyin: Zhōnghuá Rénmín Gònghéguó), is a country in East Asia. It is the world's most populous country, with a population of more than 1.4 billion. China spans five geographical time zones and borders 14 different countries, the second most of any country in the world after Russia. Covering an area of approximately 9.6 million square kilometers (3,700,000 sq mi), it is the world's third or fourth largest country. The country consists of 23 provinces, five autonomous regions, four municipalities, and two Special Administrative Regions (Hong Kong and Macau). The national capital is Beijing."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/China">http://dbpedia.org/resource/China</seealso>
    let China = Prefixed_Name(resource, "China") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chinese_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chinese_people">http://dbpedia.org/resource/Chinese_people</seealso>
    let Chinese_people = Prefixed_Name(resource, "Chinese_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chlorophyll</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chl"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chlorophyll">http://dbpedia.org/resource/Chlorophyll</seealso>
    let Chlorophyll = Prefixed_Name(resource, "Chlorophyll") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Chor%C4%85%C5%BCy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chor%C4%85%C5%BCy">http://dbpedia.org/resource/Chor%C4%85%C5%BCy</seealso>
    let ``Chor%C4%85%C5%BCy`` =
        Prefixed_Name(resource, "Chor%C4%85%C5%BCy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Christian_Science</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Christian_Science">http://dbpedia.org/resource/Christian_Science</seealso>
    let Christian_Science = Prefixed_Name(resource, "Christian_Science") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Christian_pacifism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Christian_pacifism">http://dbpedia.org/resource/Christian_pacifism</seealso>
    let Christian_pacifism =
        Prefixed_Name(resource, "Christian_pacifism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Christian_socialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Christian_socialism">http://dbpedia.org/resource/Christian_socialism</seealso>
    let Christian_socialism =
        Prefixed_Name(resource, "Christian_socialism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Christianity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Christianity">http://dbpedia.org/resource/Christianity</seealso>
    let Christianity = Prefixed_Name(resource, "Christianity") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Chum-Churum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Chum-Churum">http://dbpedia.org/resource/Chum-Churum</seealso>
    let Chum_Churum = Prefixed_Name(resource, "Chum-Churum") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Church_of_Ireland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Church_of_Ireland">http://dbpedia.org/resource/Church_of_Ireland</seealso>
    let Church_of_Ireland = Prefixed_Name(resource, "Church_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Circulation_%28fluid_dynamics%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Circulation_%28fluid_dynamics%29">http://dbpedia.org/resource/Circulation_%28fluid_dynamics%29</seealso>
    let ``Circulation_%28fluid_dynamics%29`` =
        Prefixed_Name(resource, "Circulation_%28fluid_dynamics%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Civil_and_political_rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Civil_and_political_rights">http://dbpedia.org/resource/Civil_and_political_rights</seealso>
    let Civil_and_political_rights =
        Prefixed_Name(resource, "Civil_and_political_rights") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Civil_libertarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Civil_libertarianism">http://dbpedia.org/resource/Civil_libertarianism</seealso>
    let Civil_libertarianism =
        Prefixed_Name(resource, "Civil_libertarianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Clear_(color)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Clear_(color)">http://dbpedia.org/resource/Clear_(color)</seealso>
    let ``Clear_(color)`` = Prefixed_Name(resource, "Clear_(color)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cognitive_deficit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cognitive_deficit">http://dbpedia.org/resource/Cognitive_deficit</seealso>
    let Cognitive_deficit = Prefixed_Name(resource, "Cognitive_deficit") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Colombia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Colombia">http://dbpedia.org/resource/Colombia</seealso>
    let Colombia = Prefixed_Name(resource, "Colombia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Colonel</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Colonel">http://dbpedia.org/resource/Colonel</seealso>
    let Colonel = Prefixed_Name(resource, "Colonel") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Comandarm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Comandarm">http://dbpedia.org/resource/Comandarm</seealso>
    let Comandarm = Prefixed_Name(resource, "Comandarm") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Combat_%28military_rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Combat_%28military_rank%29">http://dbpedia.org/resource/Combat_%28military_rank%29</seealso>
    let ``Combat_%28military_rank%29`` =
        Prefixed_Name(resource, "Combat_%28military_rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Combrig</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Combrig">http://dbpedia.org/resource/Combrig</seealso>
    let Combrig = Prefixed_Name(resource, "Combrig") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Comcor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Comcor">http://dbpedia.org/resource/Comcor</seealso>
    let Comcor = Prefixed_Name(resource, "Comcor") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Comdiv</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Comdiv">http://dbpedia.org/resource/Comdiv</seealso>
    let Comdiv = Prefixed_Name(resource, "Comdiv") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Commandant_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Commandant_%28rank%29">http://dbpedia.org/resource/Commandant_%28rank%29</seealso>
    let ``Commandant_%28rank%29`` =
        Prefixed_Name(resource, "Commandant_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Commandant_(rank)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Commandant_(rank)">http://dbpedia.org/resource/Commandant_(rank)</seealso>
    let ``Commandant_(rank)`` =
        Prefixed_Name(resource, "Commandant_(rank)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Commander</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Commander">http://dbpedia.org/resource/Commander</seealso>
    let Commander = Prefixed_Name(resource, "Commander") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Commandeur</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Commandeur">http://dbpedia.org/resource/Commandeur</seealso>
    let Commandeur = Prefixed_Name(resource, "Commandeur") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Commodore_(rank)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Commodore_(rank)">http://dbpedia.org/resource/Commodore_(rank)</seealso>
    let ``Commodore_(rank)`` =
        Prefixed_Name(resource, "Commodore_(rank)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Commonwealth_of_Nations</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Commonwealth_of_Nations">http://dbpedia.org/resource/Commonwealth_of_Nations</seealso>
    let Commonwealth_of_Nations =
        Prefixed_Name(resource, "Commonwealth_of_Nations") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Communalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Communalism">http://dbpedia.org/resource/Communalism</seealso>
    let Communalism = Prefixed_Name(resource, "Communalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Communism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Communism">http://dbpedia.org/resource/Communism</seealso>
    let Communism = Prefixed_Name(resource, "Communism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Comoros</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Comoros">http://dbpedia.org/resource/Comoros</seealso>
    let Comoros = Prefixed_Name(resource, "Comoros") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Company_(military_unit)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Company_(military_unit)">http://dbpedia.org/resource/Company_(military_unit)</seealso>
    let ``Company_(military_unit)`` =
        Prefixed_Name(resource, "Company_(military_unit)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Company_Quartermaster_Sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Company_Quartermaster_Sergeant">http://dbpedia.org/resource/Company_Quartermaster_Sergeant</seealso>
    let Company_Quartermaster_Sergeant =
        Prefixed_Name(resource, "Company_Quartermaster_Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Company_sergeant_major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Company_sergeant_major">http://dbpedia.org/resource/Company_sergeant_major</seealso>
    let Company_sergeant_major =
        Prefixed_Name(resource, "Company_sergeant_major") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Comprehensive_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Comprehensive_school">http://dbpedia.org/resource/Comprehensive_school</seealso>
    let Comprehensive_school =
        Prefixed_Name(resource, "Comprehensive_school") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Compton_wavelength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Compton_wavelength">http://dbpedia.org/resource/Compton_wavelength</seealso>
    let Compton_wavelength =
        Prefixed_Name(resource, "Compton_wavelength") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Computer_repair_technician</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Computer_repair_technician">http://dbpedia.org/resource/Computer_repair_technician</seealso>
    let Computer_repair_technician =
        Prefixed_Name(resource, "Computer_repair_technician") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Computer_skills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Computer_skills">http://dbpedia.org/resource/Computer_skills</seealso>
    let Computer_skills = Prefixed_Name(resource, "Computer_skills") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Conductance_quantum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Conductance_quantum">http://dbpedia.org/resource/Conductance_quantum</seealso>
    let Conductance_quantum =
        Prefixed_Name(resource, "Conductance_quantum") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Conductor_%28Army%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Conductor_%28Army%29">http://dbpedia.org/resource/Conductor_%28Army%29</seealso>
    let ``Conductor_%28Army%29`` =
        Prefixed_Name(resource, "Conductor_%28Army%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Congregational_church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Congregational_church">http://dbpedia.org/resource/Congregational_church</seealso>
    let Congregational_church =
        Prefixed_Name(resource, "Congregational_church") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Conscientious_objector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Conscientious_objector">http://dbpedia.org/resource/Conscientious_objector</seealso>
    let Conscientious_objector =
        Prefixed_Name(resource, "Conscientious_objector") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Conservatism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Conservatism">http://dbpedia.org/resource/Conservatism</seealso>
    let Conservatism = Prefixed_Name(resource, "Conservatism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Constitutionalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Constitutionalism">http://dbpedia.org/resource/Constitutionalism</seealso>
    let Constitutionalism = Prefixed_Name(resource, "Constitutionalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Contagious_Diseases_Acts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Contagious_Diseases_Acts">http://dbpedia.org/resource/Contagious_Diseases_Acts</seealso>
    let Contagious_Diseases_Acts =
        Prefixed_Name(resource, "Contagious_Diseases_Acts") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Cook_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cook_Islands">http://dbpedia.org/resource/Cook_Islands</seealso>
    let Cook_Islands = Prefixed_Name(resource, "Cook_Islands") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cooking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cooking">http://dbpedia.org/resource/Cooking</seealso>
    let Cooking = Prefixed_Name(resource, "Cooking") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Coral_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Coral_Sea">http://dbpedia.org/resource/Coral_Sea</seealso>
    let Coral_Sea = Prefixed_Name(resource, "Coral_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cornish_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Cornish_people">http://dbpedia.org/resource/Cornish_people</seealso>
    let Cornish_people = Prefixed_Name(resource, "Cornish_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Corporal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Corporal">http://dbpedia.org/resource/Corporal</seealso>
    let Corporal = Prefixed_Name(resource, "Corporal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Corporation_sole</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Corporation_sole">http://dbpedia.org/resource/Corporation_sole</seealso>
    let Corporation_sole = Prefixed_Name(resource, "Corporation_sole") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Corps</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Corps">http://dbpedia.org/resource/Corps</seealso>
    let Corps = Prefixed_Name(resource, "Corps") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cossack_Hetmanate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Cossack_Hetmanate">http://dbpedia.org/resource/Cossack_Hetmanate</seealso>
    let Cossack_Hetmanate = Prefixed_Name(resource, "Cossack_Hetmanate") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Costa_Rica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Costa_Rica">http://dbpedia.org/resource/Costa_Rica</seealso>
    let Costa_Rica = Prefixed_Name(resource, "Costa_Rica") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Counting</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Counting">http://dbpedia.org/resource/Counting</seealso>
    let Counting = Prefixed_Name(resource, "Counting") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Coupling_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Coupling_constant">http://dbpedia.org/resource/Coupling_constant</seealso>
    let Coupling_constant = Prefixed_Name(resource, "Coupling_constant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Covenanter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Covenanter">http://dbpedia.org/resource/Covenanter</seealso>
    let Covenanter = Prefixed_Name(resource, "Covenanter") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Craft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Craft">http://dbpedia.org/resource/Craft</seealso>
    let Craft = Prefixed_Name(resource, "Craft") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Creole_peoples</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Creole_peoples">http://dbpedia.org/resource/Creole_peoples</seealso>
    let Creole_peoples = Prefixed_Name(resource, "Creole_peoples") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cretan_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Cretan_Sea">http://dbpedia.org/resource/Cretan_Sea</seealso>
    let Cretan_Sea = Prefixed_Name(resource, "Cretan_Sea") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Criticisms_of_socialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Criticisms_of_socialism">http://dbpedia.org/resource/Criticisms_of_socialism</seealso>
    let Criticisms_of_socialism =
        Prefixed_Name(resource, "Criticisms_of_socialism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Croatia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Croatia">http://dbpedia.org/resource/Croatia</seealso>
    let Croatia = Prefixed_Name(resource, "Croatia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cuba</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cuba">http://dbpedia.org/resource/Cuba</seealso>
    let Cuba = Prefixed_Name(resource, "Cuba") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cynophobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cynophobia">http://dbpedia.org/resource/Cynophobia</seealso>
    let Cynophobia = Prefixed_Name(resource, "Cynophobia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Cyprus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Cyprus">http://dbpedia.org/resource/Cyprus</seealso>
    let Cyprus = Prefixed_Name(resource, "Cyprus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Czech_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Czech_Republic">http://dbpedia.org/resource/Czech_Republic</seealso>
    let Czech_Republic = Prefixed_Name(resource, "Czech_Republic") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/DBM</para>
    /// </summary>
    /// <remarks>
    ///   <para>saref:UnitOfMeasure</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"decibel-milliwatts"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/DBM">http://dbpedia.org/resource/DBM</seealso>
    let DBM = Prefixed_Name(resource, "DBM") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/DE-9IM</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/DE-9IM">http://dbpedia.org/resource/DE-9IM</seealso>
    let DE_9IM = Prefixed_Name(resource, "DE-9IM") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Daejang</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Daejang">http://dbpedia.org/resource/Daejang</seealso>
    let Daejang = Prefixed_Name(resource, "Daejang") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Daffadar</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Daffadar">http://dbpedia.org/resource/Daffadar</seealso>
    let Daffadar = Prefixed_Name(resource, "Daffadar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Daimler_AG</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Daimler AG (previously named Daimler-Benz and DaimlerChrysler; commonly known and referred to as Mercedes-Benz or simply Daimler) is a German multinational automotive corporation headquartered in Stuttgart, Baden-Württemberg, Germany. It is one of the world's leading car and truck manufacturers. Daimler-Benz was formed with the merger of Benz &amp; Cie. and Daimler Motoren Gesellschaft in 1926."</para>
    /// labels<para>"Daimler AG"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Daimler_AG">http://dbpedia.org/resource/Daimler_AG</seealso>
    let Daimler_AG = Prefixed_Name(resource, "Daimler_AG") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dalit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dalit">http://dbpedia.org/resource/Dalit</seealso>
    let Dalit = Prefixed_Name(resource, "Dalit") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dame_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dame_school">http://dbpedia.org/resource/Dame_school</seealso>
    let Dame_school = Prefixed_Name(resource, "Dame_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Dance">http://dbpedia.org/resource/Dance</seealso>
    let Dance = Prefixed_Name(resource, "Dance") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Darwinism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Darwinism">http://dbpedia.org/resource/Darwinism</seealso>
    let Darwinism = Prefixed_Name(resource, "Darwinism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Day_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Day_school">http://dbpedia.org/resource/Day_school</seealso>
    let Day_school = Prefixed_Name(resource, "Day_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Deafness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Deafness">http://dbpedia.org/resource/Deafness</seealso>
    let Deafness = Prefixed_Name(resource, "Deafness") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Deism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Deism">http://dbpedia.org/resource/Deism</seealso>
    let Deism = Prefixed_Name(resource, "Deism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Demi-brigade</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Demi-brigade">http://dbpedia.org/resource/Demi-brigade</seealso>
    let Demi_brigade = Prefixed_Name(resource, "Demi-brigade") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Democratic_Republic_of_the_Congo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Democratic_Republic_of_the_Congo">http://dbpedia.org/resource/Democratic_Republic_of_the_Congo</seealso>
    let Democratic_Republic_of_the_Congo =
        Prefixed_Name(resource, "Democratic_Republic_of_the_Congo") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Denmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Denmark">http://dbpedia.org/resource/Denmark</seealso>
    let Denmark = Prefixed_Name(resource, "Denmark") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Departments_of_the_United_Kingdom_Government</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Departments_of_the_United_Kingdom_Government">http://dbpedia.org/resource/Departments_of_the_United_Kingdom_Government</seealso>
    let Departments_of_the_United_Kingdom_Government =
        Prefixed_Name(resource, "Departments_of_the_United_Kingdom_Government") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Depression_(mood)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Depression_(mood)">http://dbpedia.org/resource/Depression_(mood)</seealso>
    let ``Depression_(mood)`` =
        Prefixed_Name(resource, "Depression_(mood)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Detachment_(military)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Detachment_(military)">http://dbpedia.org/resource/Detachment_(military)</seealso>
    let ``Detachment_(military)`` =
        Prefixed_Name(resource, "Detachment_(military)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Determinism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Determinism">http://dbpedia.org/resource/Determinism</seealso>
    let Determinism = Prefixed_Name(resource, "Determinism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Diabetes_mellitus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Diabetes_mellitus">http://dbpedia.org/resource/Diabetes_mellitus</seealso>
    let Diabetes_mellitus = Prefixed_Name(resource, "Diabetes_mellitus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Diageo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Diageo">http://dbpedia.org/resource/Diageo</seealso>
    let Diageo = Prefixed_Name(resource, "Diageo") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Diffuse_sky_radiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Radiation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Diffuse irradiation is the one that reaches the earth's surface from the sky except for the sun due to the scattering and reflection by the compositions of the atmosphere."</para>
    /// labels<para>"diffuse_irradiance"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Diffuse_sky_radiation">http://dbpedia.org/resource/Diffuse_sky_radiation</seealso>
    let Diffuse_sky_radiation =
        Prefixed_Name(resource, "Diffuse_sky_radiation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Diminished_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Diminished_chord">http://dbpedia.org/resource/Diminished_chord</seealso>
    let Diminished_chord = Prefixed_Name(resource, "Diminished_chord") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Direct_carbon_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:SubstituteFuelCell</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Direct_carbon_fuel_cell">http://dbpedia.org/resource/Direct_carbon_fuel_cell</seealso>
    let Direct_carbon_fuel_cell =
        Prefixed_Name(resource, "Direct_carbon_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Direct_insolation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Radiation_Property</para>
    ///   <para>"Direct radiation is the solar radiation which travels on a straight line from the sun down to the earth׳s surface"</para>
    /// labels<para>"direct_irradiance_at_the_surface"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Direct_insolation">http://dbpedia.org/resource/Direct_insolation</seealso>
    let Direct_insolation = Prefixed_Name(resource, "Direct_insolation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Direct_methanol_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:MethanolFuelCell</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Direct_methanol_fuel_cell">http://dbpedia.org/resource/Direct_methanol_fuel_cell</seealso>
    let Direct_methanol_fuel_cell =
        Prefixed_Name(resource, "Direct_methanol_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Disestablishmentarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Disestablishmentarianism">http://dbpedia.org/resource/Disestablishmentarianism</seealso>
    let Disestablishmentarianism =
        Prefixed_Name(resource, "Disestablishmentarianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Dishwashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Dishwashing">http://dbpedia.org/resource/Dishwashing</seealso>
    let Dishwashing = Prefixed_Name(resource, "Dishwashing") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Division_(military)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Division_(military)">http://dbpedia.org/resource/Division_(military)</seealso>
    let ``Division_(military)`` =
        Prefixed_Name(resource, "Division_(military)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Divisional_Admiral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Divisional_Admiral">http://dbpedia.org/resource/Divisional_Admiral</seealso>
    let Divisional_Admiral =
        Prefixed_Name(resource, "Divisional_Admiral") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Divisional_General</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Divisional_General">http://dbpedia.org/resource/Divisional_General</seealso>
    let Divisional_General =
        Prefixed_Name(resource, "Divisional_General") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Djibouti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Djibouti">http://dbpedia.org/resource/Djibouti</seealso>
    let Djibouti = Prefixed_Name(resource, "Djibouti") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Doctor_of_Philosophy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Doctor_of_Philosophy">http://dbpedia.org/resource/Doctor_of_Philosophy</seealso>
    let Doctor_of_Philosophy =
        Prefixed_Name(resource, "Doctor_of_Philosophy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Document</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Document">http://dbpedia.org/resource/Document</seealso>
    let Document = Prefixed_Name(resource, "Document") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Dog">http://dbpedia.org/resource/Dog</seealso>
    let Dog = Prefixed_Name(resource, "Dog") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dominica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Dominica">http://dbpedia.org/resource/Dominica</seealso>
    let Dominica = Prefixed_Name(resource, "Dominica") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dominican_Order</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dominican_Order">http://dbpedia.org/resource/Dominican_Order</seealso>
    let Dominican_Order = Prefixed_Name(resource, "Dominican_Order") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Dominican_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Dominican_Republic">http://dbpedia.org/resource/Dominican_Republic</seealso>
    let Dominican_Republic =
        Prefixed_Name(resource, "Dominican_Republic") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Door</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Door">http://dbpedia.org/resource/Door</seealso>
    let Door = Prefixed_Name(resource, "Door") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Doorbell</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Doorbell">http://dbpedia.org/resource/Doorbell</seealso>
    let Doorbell = Prefixed_Name(resource, "Doorbell") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dreyfus_affair</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dreyfus_affair">http://dbpedia.org/resource/Dreyfus_affair</seealso>
    let Dreyfus_affair = Prefixed_Name(resource, "Dreyfus_affair") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Driver_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Driver_%28rank%29">http://dbpedia.org/resource/Driver_%28rank%29</seealso>
    let ``Driver_%28rank%29`` =
        Prefixed_Name(resource, "Driver_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Drought</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:resource/Soil_Property</para>
    ///
    /// labels<para>"Drought"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Drought">http://dbpedia.org/resource/Drought</seealso>
    let Drought = Prefixed_Name(resource, "Drought") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Drug_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Drug_allergy">http://dbpedia.org/resource/Drug_allergy</seealso>
    let Drug_allergy = Prefixed_Name(resource, "Drug_allergy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Drum_Major_General</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Drum_Major_General">http://dbpedia.org/resource/Drum_Major_General</seealso>
    let Drum_Major_General =
        Prefixed_Name(resource, "Drum_Major_General") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Drum_major_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Drum_major_%28rank%29">http://dbpedia.org/resource/Drum_major_%28rank%29</seealso>
    let ``Drum_major_%28rank%29`` =
        Prefixed_Name(resource, "Drum_major_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Dublin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dublin">http://dbpedia.org/resource/Dublin</seealso>
    let Dublin = Prefixed_Name(resource, "Dublin") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Dutch_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Dutch_people">http://dbpedia.org/resource/Dutch_people</seealso>
    let Dutch_people = Prefixed_Name(resource, "Dutch_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/East_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/East_Germany">http://dbpedia.org/resource/East_Germany</seealso>
    let East_Germany = Prefixed_Name(resource, "East_Germany") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/East_Timor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/East_Timor">http://dbpedia.org/resource/East_Timor</seealso>
    let East_Timor = Prefixed_Name(resource, "East_Timor") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Eastern_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Eastern Europe"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Eastern_Europe">http://dbpedia.org/resource/Eastern_Europe</seealso>
    let Eastern_Europe = Prefixed_Name(resource, "Eastern_Europe") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Eastern_religions</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Eastern_religions">http://dbpedia.org/resource/Eastern_religions</seealso>
    let Eastern_religions = Prefixed_Name(resource, "Eastern_religions") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ecuador</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ecuador">http://dbpedia.org/resource/Ecuador</seealso>
    let Ecuador = Prefixed_Name(resource, "Ecuador") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ecumenism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ecumenism">http://dbpedia.org/resource/Ecumenism</seealso>
    let Ecumenism = Prefixed_Name(resource, "Ecumenism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Education_in_the_United_Kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Education_in_the_United_Kingdom">http://dbpedia.org/resource/Education_in_the_United_Kingdom</seealso>
    let Education_in_the_United_Kingdom =
        Prefixed_Name(resource, "Education_in_the_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Education_reform</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Education_reform">http://dbpedia.org/resource/Education_reform</seealso>
    let Education_reform = Prefixed_Name(resource, "Education_reform") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Egalitarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Egalitarianism">http://dbpedia.org/resource/Egalitarianism</seealso>
    let Egalitarianism = Prefixed_Name(resource, "Egalitarianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Egg_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Egg_allergy">http://dbpedia.org/resource/Egg_allergy</seealso>
    let Egg_allergy = Prefixed_Name(resource, "Egg_allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Egypt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Egypt">http://dbpedia.org/resource/Egypt</seealso>
    let Egypt = Prefixed_Name(resource, "Egypt") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Egyptian_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Egyptian_nationalism">http://dbpedia.org/resource/Egyptian_nationalism</seealso>
    let Egyptian_nationalism =
        Prefixed_Name(resource, "Egyptian_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/El_Salvador</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/El_Salvador">http://dbpedia.org/resource/El_Salvador</seealso>
    let El_Salvador = Prefixed_Name(resource, "El_Salvador") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Elder_rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Elder_rights">http://dbpedia.org/resource/Elder_rights</seealso>
    let Elder_rights = Prefixed_Name(resource, "Elder_rights") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Elderly_care</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Elderly_care">http://dbpedia.org/resource/Elderly_care</seealso>
    let Elderly_care = Prefixed_Name(resource, "Elderly_care") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Electoral_reform</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Electoral_reform">http://dbpedia.org/resource/Electoral_reform</seealso>
    let Electoral_reform = Prefixed_Name(resource, "Electoral_reform") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Electric_bicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Bike</para>
    ///   <para>"An electric bicycle (e-bike, eBike, etc.) is a motorized bicycle with an integrated electric motor used to assist propulsion. Many kinds of e-bikes are available worldwide, but they generally fall into two broad categories: bikes that assist the rider's pedal-power (i.e. pedelecs) and bikes that add a throttle, integrating moped-style functionality. Both retain the ability to be pedaled by the rider and are therefore not electric motorcycles."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Electric_bicycle">http://dbpedia.org/resource/Electric_bicycle</seealso>
    let Electric_bicycle = Prefixed_Name(resource, "Electric_bicycle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Electricity">http://dbpedia.org/resource/Electricity</seealso>
    let Electricity = Prefixed_Name(resource, "Electricity") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Electron</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Electron">http://dbpedia.org/resource/Electron</seealso>
    let Electron = Prefixed_Name(resource, "Electron") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Electron_magnetic_dipole_moment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Electron_magnetic_dipole_moment">http://dbpedia.org/resource/Electron_magnetic_dipole_moment</seealso>
    let Electron_magnetic_dipole_moment =
        Prefixed_Name(resource, "Electron_magnetic_dipole_moment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Electron_volt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Electron_volt">http://dbpedia.org/resource/Electron_volt</seealso>
    let Electron_volt = Prefixed_Name(resource, "Electron_volt") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Elementary_charge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Elementary_charge">http://dbpedia.org/resource/Elementary_charge</seealso>
    let Elementary_charge = Prefixed_Name(resource, "Elementary_charge") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Elevator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Elevator">http://dbpedia.org/resource/Elevator</seealso>
    let Elevator = Prefixed_Name(resource, "Elevator") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/England</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/England">http://dbpedia.org/resource/England</seealso>
    let England = Prefixed_Name(resource, "England") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/English_Dissenters</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/English_Dissenters">http://dbpedia.org/resource/English_Dissenters</seealso>
    let English_Dissenters =
        Prefixed_Name(resource, "English_Dissenters") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/English_Dissenters#Rational_Dissenters</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/English_Dissenters#Rational_Dissenters">http://dbpedia.org/resource/English_Dissenters#Rational_Dissenters</seealso>
    let ``English_Dissenters#Rational_Dissenters`` =
        Prefixed_Name(resource, "English_Dissenters#Rational_Dissenters") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/English_Reformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/English_Reformation">http://dbpedia.org/resource/English_Reformation</seealso>
    let English_Reformation =
        Prefixed_Name(resource, "English_Reformation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/English_national_identity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/English_national_identity">http://dbpedia.org/resource/English_national_identity</seealso>
    let English_national_identity =
        Prefixed_Name(resource, "English_national_identity") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/English_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/English_people">http://dbpedia.org/resource/English_people</seealso>
    let English_people = Prefixed_Name(resource, "English_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Enhanced_vegetation_index</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The enhanced vegetation index (EVI) is an 'optimized' vegetation index designed to enhance the vegetation signal with improved sensitivity in high biomass regions and improved vegetation monitoring through a de-coupling of the canopy background signal and a reduction in atmosphere influences. EVI is computed following this equation: where: * NIR/red/blue are atmospherically-corrected and partially atmosphere corrected (Rayleigh and ozone absorption) surface reflectances * L is the canopy background adjustment that addresses non-linear, differential NIR and red radiant transfer through a canopy, and * C1, C2 are the coefficients of the aerosol resistance term, which uses the blue band to correct for aerosol influences in the red band. The coefficients adopted in the MODIS-EVI algorithm are: L=1, C1 = 6, C2 = 7.5, and G (gain factor) = 2.5. Whereas the Normalized Difference Vegetation Index (NDVI) is chlorophyll sensitive, the EVI is more responsive to canopy structural variations, including leaf area index (LAI), canopy type, plant physiognomy, and canopy architecture. The two vegetation indices complement each other in global vegetation studies and improve upon the detection of vegetation changes and extraction of canopy biophysical parameters.. Another difference between Normalized Difference Vegetation Index (NDVI) and EVI is that in the presence of snow, NDVI decreases, while EVI increases (Huete, 2002). Starting 2000, and after the launch of the two MODIS sensors on Terra (satellite) and Aqua (satellite) by NASA, EVI was adopted as a standard product by NASA and became extremely popular with users due to its ability to eliminate background and atmosphere noises, as well as its non saturation, a typical NDVI problem. EVI is currently distributed for free by the USGS LP DAAC. (en)"</para>
    /// labels<para>"EVI"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Enhanced_vegetation_index">http://dbpedia.org/resource/Enhanced_vegetation_index</seealso>
    let Enhanced_vegetation_index =
        Prefixed_Name(resource, "Enhanced_vegetation_index") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ensign_(rank)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ensign_(rank)">http://dbpedia.org/resource/Ensign_(rank)</seealso>
    let ``Ensign_(rank)`` = Prefixed_Name(resource, "Ensign_(rank)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Entrance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Entrance">http://dbpedia.org/resource/Entrance</seealso>
    let Entrance = Prefixed_Name(resource, "Entrance") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Environmentalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Environmentalism">http://dbpedia.org/resource/Environmentalism</seealso>
    let Environmentalism = Prefixed_Name(resource, "Environmentalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Epihipparch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Epihipparch">http://dbpedia.org/resource/Epihipparch</seealso>
    let Epihipparch = Prefixed_Name(resource, "Epihipparch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Equatorial_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Equatorial_Guinea">http://dbpedia.org/resource/Equatorial_Guinea</seealso>
    let Equatorial_Guinea = Prefixed_Name(resource, "Equatorial_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Eritrea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Eritrea">http://dbpedia.org/resource/Eritrea</seealso>
    let Eritrea = Prefixed_Name(resource, "Eritrea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Estonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Estonia">http://dbpedia.org/resource/Estonia</seealso>
    let Estonia = Prefixed_Name(resource, "Estonia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Eswatini</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Eswatini">http://dbpedia.org/resource/Eswatini</seealso>
    let Eswatini = Prefixed_Name(resource, "Eswatini") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ethiopia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ethiopia">http://dbpedia.org/resource/Ethiopia</seealso>
    let Ethiopia = Prefixed_Name(resource, "Ethiopia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ethnic_groups_in_Europe</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ethnic_groups_in_Europe">http://dbpedia.org/resource/Ethnic_groups_in_Europe</seealso>
    let Ethnic_groups_in_Europe =
        Prefixed_Name(resource, "Ethnic_groups_in_Europe") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Eugenics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Eugenics">http://dbpedia.org/resource/Eugenics</seealso>
    let Eugenics = Prefixed_Name(resource, "Eugenics") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Eurasian_(mixed_ancestry)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Eurasian_(mixed_ancestry)">http://dbpedia.org/resource/Eurasian_(mixed_ancestry)</seealso>
    let ``Eurasian_(mixed_ancestry)`` =
        Prefixed_Name(resource, "Eurasian_(mixed_ancestry)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Europe is a continent, also recognised as part of Eurasia, located entirely in the Northern Hemisphere and mostly in the Eastern Hemisphere. Comprising the westernmost peninsulas of the continental landmass of Eurasia, it shares the continental landmass of Afro-Eurasia with both Asia and Africa. It is bordered by the Arctic Ocean to the north, the Atlantic Ocean to the west, the Mediterranean Sea to the south and Asia to the east. Europe is commonly considered to be separated from Asia by the watershed of the Ural Mountains, the Ural River, the Caspian Sea, the Greater Caucasus, the Black Sea and the waterways of the Turkish Straits."</para>
    /// labels<para>"Europe"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Europe">http://dbpedia.org/resource/Europe</seealso>
    let Europe = Prefixed_Name(resource, "Europe") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/European_Credit_Transfer_and_Accumulation_System</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/European_Credit_Transfer_and_Accumulation_System">http://dbpedia.org/resource/European_Credit_Transfer_and_Accumulation_System</seealso>
    let European_Credit_Transfer_and_Accumulation_System =
        Prefixed_Name(resource, "European_Credit_Transfer_and_Accumulation_System") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/European_Union</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The European Union (EU) is a political and economic union of 27 member states that are located primarily in Europe. The union has a total area of 4,233,255.3 km2 (1,634,469.0 sq mi) and an estimated total population of about 447 million. An internal single market has been established through a standardised system of laws that apply in all member states in those matters, and only those matters, where the states have agreed to act as one. EU policies aim to ensure the free movement of people, goods, services and capital within the internal market; enact legislation in justice and home affairs; and maintain common policies on trade, agriculture, fisheries and regional development. Passport controls have been abolished for travel within the Schengen Area."</para>
    /// labels<para>"European Union"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/European_Union">http://dbpedia.org/resource/European_Union</seealso>
    let European_Union = Prefixed_Name(resource, "European_Union") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/European_microstates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/European_microstates">http://dbpedia.org/resource/European_microstates</seealso>
    let European_microstates =
        Prefixed_Name(resource, "European_microstates") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Euroscepticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Euroscepticism">http://dbpedia.org/resource/Euroscepticism</seealso>
    let Euroscepticism = Prefixed_Name(resource, "Euroscepticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Evangelicalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Evangelicalism">http://dbpedia.org/resource/Evangelicalism</seealso>
    let Evangelicalism = Prefixed_Name(resource, "Evangelicalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Event</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Event, other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Event">http://dbpedia.org/resource/Event</seealso>
    let Event = Prefixed_Name(resource, "Event") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Event_planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Event_planning">http://dbpedia.org/resource/Event_planning</seealso>
    let Event_planning = Prefixed_Name(resource, "Event_planning") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/EvoBus</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"EvoBus GmbH is a German bus and coach manufacturer headquartered in Stuttgart, Germany and a wholly owned subsidiary of . Its products go to market under the brands Setra or Mercedes-Benz."</para>
    /// labels<para>"EvoBus"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/EvoBus">http://dbpedia.org/resource/EvoBus</seealso>
    let EvoBus = Prefixed_Name(resource, "EvoBus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Exchange_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Exchange_officer">http://dbpedia.org/resource/Exchange_officer</seealso>
    let Exchange_officer = Prefixed_Name(resource, "Exchange_officer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Executive_agency</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Executive_agency">http://dbpedia.org/resource/Executive_agency</seealso>
    let Executive_agency = Prefixed_Name(resource, "Executive_agency") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Existentialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Existentialism">http://dbpedia.org/resource/Existentialism</seealso>
    let Existentialism = Prefixed_Name(resource, "Existentialism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Eye_color</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Eye_color">http://dbpedia.org/resource/Eye_color</seealso>
    let Eye_color = Prefixed_Name(resource, "Eye_color") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/FCDO</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PublicAdministrationAndDefenseOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/FCDO">http://dbpedia.org/resource/FCDO</seealso>
    let FCDO = Prefixed_Name(resource, "FCDO") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Faculty_of_Mathematics_and_Physics,_Charles_University</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Faculty_of_Mathematics_and_Physics,_Charles_University">http://dbpedia.org/resource/Faculty_of_Mathematics_and_Physics,_Charles_University</seealso>
    let ``Faculty_of_Mathematics_and_Physics,_Charles_University`` =
        Prefixed_Name(resource, "Faculty_of_Mathematics_and_Physics,_Charles_University") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Faith_healing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Faith_healing">http://dbpedia.org/resource/Faith_healing</seealso>
    let Faith_healing = Prefixed_Name(resource, "Faith_healing") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fascism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fascism">http://dbpedia.org/resource/Fascism</seealso>
    let Fascism = Prefixed_Name(resource, "Fascism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fatalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fatalism">http://dbpedia.org/resource/Fatalism</seealso>
    let Fatalism = Prefixed_Name(resource, "Fatalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fear_of_the_dark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Fear_of_the_dark">http://dbpedia.org/resource/Fear_of_the_dark</seealso>
    let Fear_of_the_dark = Prefixed_Name(resource, "Fear_of_the_dark") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Federal_Bureau_of_Investigation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Federal_Bureau_of_Investigation">http://dbpedia.org/resource/Federal_Bureau_of_Investigation</seealso>
    let Federal_Bureau_of_Investigation =
        Prefixed_Name(resource, "Federal_Bureau_of_Investigation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Federal_Ministry_of_Transport_and_Digital_Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PublicAdministrationAndDefenseOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Federal Ministry of Transport and Digital Infrastructure (German: Bundesministerium für Verkehr und digitale Infrastruktur), abbreviated BMVI, is a cabinet-level ministry of the Federal Republic of Germany. Its main office is located in Berlin, while the majority of its civil servants and employees work in Bonn, the secondary seat."</para>
    /// labels<para>"Federal Ministry of Transport and Digital Infrastructure"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Federal_Ministry_of_Transport_and_Digital_Infrastructure">http://dbpedia.org/resource/Federal_Ministry_of_Transport_and_Digital_Infrastructure</seealso>
    let Federal_Ministry_of_Transport_and_Digital_Infrastructure =
        Prefixed_Name(resource, "Federal_Ministry_of_Transport_and_Digital_Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Federal_Railway_Authority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:PublicAdministrationAndDefenseOrganization</para>
    ///   <para>"The German Federal Railway Authority (German: Eisenbahn-Bundesamt, EBA) has been the independent federal authority for the regulation of the railways in Germany since 1 January 1994. It is under the supervision and direction of the Federal Ministry for Digital and Transport and is headed by a president."</para>
    /// labels<para>"Federal Railway Authority"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Federal_Railway_Authority">http://dbpedia.org/resource/Federal_Railway_Authority</seealso>
    let Federal_Railway_Authority =
        Prefixed_Name(resource, "Federal_Railway_Authority") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Federated_States_of_Micronesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Federated_States_of_Micronesia">http://dbpedia.org/resource/Federated_States_of_Micronesia</seealso>
    let Federated_States_of_Micronesia =
        Prefixed_Name(resource, "Federated_States_of_Micronesia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Female_education</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Female_education">http://dbpedia.org/resource/Female_education</seealso>
    let Female_education = Prefixed_Name(resource, "Female_education") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Feminism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Feminism">http://dbpedia.org/resource/Feminism</seealso>
    let Feminism = Prefixed_Name(resource, "Feminism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ferik_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ferik_%28rank%29">http://dbpedia.org/resource/Ferik_%28rank%29</seealso>
    let ``Ferik_%28rank%29`` =
        Prefixed_Name(resource, "Ferik_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Fiat_Panda_Hydrogen</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Car</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Panda Hydrogen is a prototype fuel cell-type hydrogen vehicle based on the Fiat Panda introduced in 2006. The fuel, gaseous Hydrogen, is stored in underfloor hydrogen tanks at 350 bar. A "Andromeda II" fuel cell stack generates energy to power an electric motor directly, i.e. without a battery. Panda Hydrogen produces 40 kW (54 hp) power and it can achieve top speed of 130 km/h (81 mph). Operating range is over 200 km (120 mi) in urban driving."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Fiat_Panda_Hydrogen">http://dbpedia.org/resource/Fiat_Panda_Hydrogen</seealso>
    let Fiat_Panda_Hydrogen =
        Prefixed_Name(resource, "Fiat_Panda_Hydrogen") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Field_army</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Field_army">http://dbpedia.org/resource/Field_army</seealso>
    let Field_army = Prefixed_Name(resource, "Field_army") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Field_artillery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Field_artillery">http://dbpedia.org/resource/Field_artillery</seealso>
    let Field_artillery = Prefixed_Name(resource, "Field_artillery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Field_marshal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Field_marshal">http://dbpedia.org/resource/Field_marshal</seealso>
    let Field_marshal = Prefixed_Name(resource, "Field_marshal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fifth_Monarchists</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fifth_Monarchists">http://dbpedia.org/resource/Fifth_Monarchists</seealso>
    let Fifth_Monarchists = Prefixed_Name(resource, "Fifth_Monarchists") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fiji</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Fiji">http://dbpedia.org/resource/Fiji</seealso>
    let Fiji = Prefixed_Name(resource, "Fiji") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Financial_adviser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Financial_adviser">http://dbpedia.org/resource/Financial_adviser</seealso>
    let Financial_adviser = Prefixed_Name(resource, "Financial_adviser") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Fine-structure_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fine-structure_constant">http://dbpedia.org/resource/Fine-structure_constant</seealso>
    let Fine_structure_constant =
        Prefixed_Name(resource, "Fine-structure_constant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Finland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Finland">http://dbpedia.org/resource/Finland</seealso>
    let Finland = Prefixed_Name(resource, "Finland") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/First_Boer_War</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/First_Boer_War">http://dbpedia.org/resource/First_Boer_War</seealso>
    let First_Boer_War = Prefixed_Name(resource, "First_Boer_War") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Fleet_Board</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fleet_Board">http://dbpedia.org/resource/Fleet_Board</seealso>
    let Fleet_Board = Prefixed_Name(resource, "Fleet_Board") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Flemish_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flemish_people">http://dbpedia.org/resource/Flemish_people</seealso>
    let Flemish_people = Prefixed_Name(resource, "Flemish_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Flight_(military_unit)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flight_(military_unit)">http://dbpedia.org/resource/Flight_(military_unit)</seealso>
    let ``Flight_(military_unit)`` =
        Prefixed_Name(resource, "Flight_(military_unit)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Flight_lieutenant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flight_lieutenant">http://dbpedia.org/resource/Flight_lieutenant</seealso>
    let Flight_lieutenant = Prefixed_Name(resource, "Flight_lieutenant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Flight_sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flight_sergeant">http://dbpedia.org/resource/Flight_sergeant</seealso>
    let Flight_sergeant = Prefixed_Name(resource, "Flight_sergeant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Flotilla</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flotilla">http://dbpedia.org/resource/Flotilla</seealso>
    let Flotilla = Prefixed_Name(resource, "Flotilla") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Flying_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Flying_officer">http://dbpedia.org/resource/Flying_officer</seealso>
    let Flying_officer = Prefixed_Name(resource, "Flying_officer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Food_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Food_allergy">http://dbpedia.org/resource/Food_allergy</seealso>
    let Food_allergy = Prefixed_Name(resource, "Food_allergy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ford_F-250_Super_Chief</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PickupTruck</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ford F-250 Super Chief"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ford_F-250_Super_Chief">http://dbpedia.org/resource/Ford_F-250_Super_Chief</seealso>
    let Ford_F_250_Super_Chief =
        Prefixed_Name(resource, "Ford_F-250_Super_Chief") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ford_Motor_Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"Ford Motor Company (commonly known as Ford) is an American multinational automobile manufacturer headquartered in Dearborn, Michigan, United States. It was founded by Henry Ford and incorporated on June 16, 1903. The company sells automobiles and commercial vehicles under the Ford brand, and luxury cars under its Lincoln luxury brand. Ford also owns Brazilian SUV manufacturer Troller, an 8% stake in Aston Martin of the United Kingdom and a 32% stake in China's Jiangling Motors. It also has joint-ventures in China (Changan Ford), Taiwan (Ford Lio Ho), Thailand (AutoAlliance Thailand), Turkey (Ford Otosan), and Russia (Ford Sollers). The company is listed on the New York Stock Exchange and is controlled by the Ford family; they have minority ownership but the majority of the voting power."</para>
    /// labels<para>"Ford Motor Company"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ford_Motor_Company">http://dbpedia.org/resource/Ford_Motor_Company</seealso>
    let Ford_Motor_Company =
        Prefixed_Name(resource, "Ford_Motor_Company") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Foreign,_Commonwealth_and_Development_Office</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PublicAdministrationAndDefenseOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Foreign, Commonwealth &amp; Development Office (FCDO) is a department of the Government of the United Kingdom. It was created on 2 September 2020 through the merger of the Foreign &amp; Commonwealth Office (FCO) and the Department for International Development (DFID). The FCO, itself created in 1968 by the merger of the Foreign Office (FO) and the Commonwealth Office, was responsible for protecting and promoting British interests worldwide. The expenditure, administration and policy of the FCDO are scrutinised by the Foreign Affairs Select Committee."</para>
    /// labels<para>"Foreign, Commonwealth and Development Office"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Foreign,_Commonwealth_and_Development_Office">http://dbpedia.org/resource/Foreign,_Commonwealth_and_Development_Office</seealso>
    let ``Foreign,_Commonwealth_and_Development_Office`` =
        Prefixed_Name(resource, "Foreign,_Commonwealth_and_Development_Office") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Forklift</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A forklift (also called lift truck, jitney, fork truck, fork hoist, and forklift truck) is a powered industrial truck used to lift and move materials over short distances."</para>
    /// labels<para>"Forklift"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Forklift">http://dbpedia.org/resource/Forklift</seealso>
    let Forklift = Prefixed_Name(resource, "Forklift") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/France</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/France">http://dbpedia.org/resource/France</seealso>
    let France = Prefixed_Name(resource, "France") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Free_Trader</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Free_Trader">http://dbpedia.org/resource/Free_Trader</seealso>
    let Free_Trader = Prefixed_Name(resource, "Free_Trader") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Freedom_of_speech</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Freedom_of_speech">http://dbpedia.org/resource/Freedom_of_speech</seealso>
    let Freedom_of_speech = Prefixed_Name(resource, "Freedom_of_speech") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Freemasonry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Freemasonry">http://dbpedia.org/resource/Freemasonry</seealso>
    let Freemasonry = Prefixed_Name(resource, "Freemasonry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Freethought</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Freethought">http://dbpedia.org/resource/Freethought</seealso>
    let Freethought = Prefixed_Name(resource, "Freethought") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/French_Riviera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/French_Riviera">http://dbpedia.org/resource/French_Riviera</seealso>
    let French_Riviera = Prefixed_Name(resource, "French_Riviera") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/French_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/French_nationalism">http://dbpedia.org/resource/French_nationalism</seealso>
    let French_nationalism =
        Prefixed_Name(resource, "French_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Front_(military)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Front_(military)">http://dbpedia.org/resource/Front_(military)</seealso>
    let ``Front_(military)`` =
        Prefixed_Name(resource, "Front_(military)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Front_(military_formation)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Front_(military_formation)">http://dbpedia.org/resource/Front_(military_formation)</seealso>
    let ``Front_(military_formation)`` =
        Prefixed_Name(resource, "Front_(military_formation)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Fuel-cell_stack</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:FuelCellStack</para>
    ///
    /// labels<para>"Fuel-cell stack"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fuel-cell_stack">http://dbpedia.org/resource/Fuel-cell_stack</seealso>
    let Fuel_cell_stack = Prefixed_Name(resource, "Fuel-cell_stack") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/FuelCell_Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"FuelCell Energy, Inc. is a publicly traded fuel cell company, headquartered in Danbury, Connecticut. It designs, manufactures, operates and services Direct Fuel Cell power plants (a type of molten carbonate fuel cell). The company's fuel cell technology is an alternative to traditional combustion-based power generation, and is complementary to intermittent sources of energy, such as solar and wind turbines. As one of the biggest publicly traded fuel cell manufacturers in the U.S., the company provides clean energy in over 50 locations all over the world. It operates the world's largest fuel cell park, Gyeonggi Green Energy Fuel cell park, which is located in South Korea. The park consists of 21 power plants providing 59 Megawatt of electricity plus district heating to a number of customers"</para>
    /// labels<para>"FuelCell Energy"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/FuelCell_Energy">http://dbpedia.org/resource/FuelCell_Energy</seealso>
    let FuelCell_Energy = Prefixed_Name(resource, "FuelCell_Energy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Fuel_Cell_Bus_Club</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>org:Organization</para>
    ///   <para>"The Fuel Cell Bus Club comprised the participants of the projects (2001-2006), (2001-2005) and (2001-2005) which were pioneering demonstration projects for fuel cell bus fleets in Europe and Australia. The projects have been successfully completed. There were three buses in each of the 11 cities in the trial. The buses were a Mercedes-Benz Citaro and used hydrogen fuel cells from Ballard Power Systems. At the time they claimed to be the largest fleet of fuel cell buses in the world. The buses were estimated to cost US$ 1.2 million each and have a range of 300 kilometres (186.4 mi) and carry around 70 passengers."</para>
    /// labels<para>"Fuel Cell Bus Club"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fuel_Cell_Bus_Club">http://dbpedia.org/resource/Fuel_Cell_Bus_Club</seealso>
    let Fuel_Cell_Bus_Club =
        Prefixed_Name(resource, "Fuel_Cell_Bus_Club") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Fuel_cell_bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Bus</para>
    ///   <para>"A fuel cell bus is a bus that uses a hydrogen fuel cell as its power source for electrically driven wheels, sometimes augmented in a hybrid fashion with batteries or a supercapacitor."</para>
    /// labels<para>"Fuel cell bus"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Fuel_cell_bus">http://dbpedia.org/resource/Fuel_cell_bus</seealso>
    let Fuel_cell_bus = Prefixed_Name(resource, "Fuel_cell_bus") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/G-factor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/G-factor">http://dbpedia.org/resource/G-factor</seealso>
    let G_factor = Prefixed_Name(resource, "G-factor") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gabon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Gabon">http://dbpedia.org/resource/Gabon</seealso>
    let Gabon = Prefixed_Name(resource, "Gabon") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gaels</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gaels">http://dbpedia.org/resource/Gaels</seealso>
    let Gaels = Prefixed_Name(resource, "Gaels") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Galway_Bay</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Galway_Bay">http://dbpedia.org/resource/Galway_Bay</seealso>
    let Galway_Bay = Prefixed_Name(resource, "Galway_Bay") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Garrison</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Garrison">http://dbpedia.org/resource/Garrison</seealso>
    let Garrison = Prefixed_Name(resource, "Garrison") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Garrison_Sergeant_Major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Garrison_Sergeant_Major">http://dbpedia.org/resource/Garrison_Sergeant_Major</seealso>
    let Garrison_Sergeant_Major =
        Prefixed_Name(resource, "Garrison_Sergeant_Major") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Gefreiter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gefreiter">http://dbpedia.org/resource/Gefreiter</seealso>
    let Gefreiter = Prefixed_Name(resource, "Gefreiter") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/General-in-Chief</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/General-in-Chief">http://dbpedia.org/resource/General-in-Chief</seealso>
    let General_in_Chief = Prefixed_Name(resource, "General-in-Chief") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/General_Admiral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/General_Admiral">http://dbpedia.org/resource/General_Admiral</seealso>
    let General_Admiral = Prefixed_Name(resource, "General_Admiral") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/General_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/General_officer">http://dbpedia.org/resource/General_officer</seealso>
    let General_officer = Prefixed_Name(resource, "General_officer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gentry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gentry">http://dbpedia.org/resource/Gentry</seealso>
    let Gentry = Prefixed_Name(resource, "Gentry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/GeoJSON</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/GeoJSON">http://dbpedia.org/resource/GeoJSON</seealso>
    let GeoJSON = Prefixed_Name(resource, "GeoJSON") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/GeoNames</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/GeoNames">http://dbpedia.org/resource/GeoNames</seealso>
    let GeoNames = Prefixed_Name(resource, "GeoNames") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Georges_Ernest_Boulanger</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Georges_Ernest_Boulanger">http://dbpedia.org/resource/Georges_Ernest_Boulanger</seealso>
    let Georges_Ernest_Boulanger =
        Prefixed_Name(resource, "Georges_Ernest_Boulanger") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Georgia_(country)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Georgia_(country)">http://dbpedia.org/resource/Georgia_(country)</seealso>
    let ``Georgia_(country)`` =
        Prefixed_Name(resource, "Georgia_(country)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/German_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/German_nationalism">http://dbpedia.org/resource/German_nationalism</seealso>
    let German_nationalism =
        Prefixed_Name(resource, "German_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Germany">http://dbpedia.org/resource/Germany</seealso>
    let Germany = Prefixed_Name(resource, "Germany") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ghana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ghana">http://dbpedia.org/resource/Ghana</seealso>
    let Ghana = Prefixed_Name(resource, "Ghana") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Girondins</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Girondins">http://dbpedia.org/resource/Girondins</seealso>
    let Girondins = Prefixed_Name(resource, "Girondins") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Glenfiddich_distillery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Glenfiddich_distillery">http://dbpedia.org/resource/Glenfiddich_distillery</seealso>
    let Glenfiddich_distillery =
        Prefixed_Name(resource, "Glenfiddich_distillery") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Gnosticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gnosticism">http://dbpedia.org/resource/Gnosticism</seealso>
    let Gnosticism = Prefixed_Name(resource, "Gnosticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gold_(color)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gold_(color)">http://dbpedia.org/resource/Gold_(color)</seealso>
    let ``Gold_(color)`` = Prefixed_Name(resource, "Gold_(color)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grab_bar</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Grab_bar">http://dbpedia.org/resource/Grab_bar</seealso>
    let Grab_bar = Prefixed_Name(resource, "Grab_bar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grading</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Grading">http://dbpedia.org/resource/Grading</seealso>
    let Grading = Prefixed_Name(resource, "Grading") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grammar_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Grammar_school">http://dbpedia.org/resource/Grammar_school</seealso>
    let Grammar_school = Prefixed_Name(resource, "Grammar_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grand_Battery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Grand_Battery">http://dbpedia.org/resource/Grand_Battery</seealso>
    let Grand_Battery = Prefixed_Name(resource, "Grand_Battery") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Great_Officer_of_State</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Great_Officer_of_State">http://dbpedia.org/resource/Great_Officer_of_State</seealso>
    let Great_Officer_of_State =
        Prefixed_Name(resource, "Great_Officer_of_State") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Greece</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Greece">http://dbpedia.org/resource/Greece</seealso>
    let Greece = Prefixed_Name(resource, "Greece") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Greek_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Greek_nationalism">http://dbpedia.org/resource/Greek_nationalism</seealso>
    let Greek_nationalism = Prefixed_Name(resource, "Greek_nationalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grenada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Grenada">http://dbpedia.org/resource/Grenada</seealso>
    let Grenada = Prefixed_Name(resource, "Grenada") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Grocery_store</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Grocery_store">http://dbpedia.org/resource/Grocery_store</seealso>
    let Grocery_store = Prefixed_Name(resource, "Grocery_store") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Group_(military_aviation_unit)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Group_(military_aviation_unit)">http://dbpedia.org/resource/Group_(military_aviation_unit)</seealso>
    let ``Group_(military_aviation_unit)`` =
        Prefixed_Name(resource, "Group_(military_aviation_unit)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Group_captain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Group_captain">http://dbpedia.org/resource/Group_captain</seealso>
    let Group_captain = Prefixed_Name(resource, "Group_captain") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Guatemala</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Guatemala">http://dbpedia.org/resource/Guatemala</seealso>
    let Guatemala = Prefixed_Name(resource, "Guatemala") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Guelphs_and_Ghibellines</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Guelphs_and_Ghibellines">http://dbpedia.org/resource/Guelphs_and_Ghibellines</seealso>
    let Guelphs_and_Ghibellines =
        Prefixed_Name(resource, "Guelphs_and_Ghibellines") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Guinea">http://dbpedia.org/resource/Guinea</seealso>
    let Guinea = Prefixed_Name(resource, "Guinea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Guinea-Bissau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Guinea-Bissau">http://dbpedia.org/resource/Guinea-Bissau</seealso>
    let Guinea_Bissau = Prefixed_Name(resource, "Guinea-Bissau") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Guinness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Guinness">http://dbpedia.org/resource/Guinness</seealso>
    let Guinness = Prefixed_Name(resource, "Guinness") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gulf_of_Cadiz</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gulf_of_Cadiz">http://dbpedia.org/resource/Gulf_of_Cadiz</seealso>
    let Gulf_of_Cadiz = Prefixed_Name(resource, "Gulf_of_Cadiz") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Gulf_of_Lion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Gulf_of_Lion">http://dbpedia.org/resource/Gulf_of_Lion</seealso>
    let Gulf_of_Lion = Prefixed_Name(resource, "Gulf_of_Lion") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Guyana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Guyana">http://dbpedia.org/resource/Guyana</seealso>
    let Guyana = Prefixed_Name(resource, "Guyana") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Gyromagnetic_ratio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Gyromagnetic_ratio">http://dbpedia.org/resource/Gyromagnetic_ratio</seealso>
    let Gyromagnetic_ratio =
        Prefixed_Name(resource, "Gyromagnetic_ratio") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hairdresser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hairdresser">http://dbpedia.org/resource/Hairdresser</seealso>
    let Hairdresser = Prefixed_Name(resource, "Hairdresser") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Haiti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Haiti">http://dbpedia.org/resource/Haiti</seealso>
    let Haiti = Prefixed_Name(resource, "Haiti") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hanover</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hanover">http://dbpedia.org/resource/Hanover</seealso>
    let Hanover = Prefixed_Name(resource, "Hanover") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hartree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hartree">http://dbpedia.org/resource/Hartree</seealso>
    let Hartree = Prefixed_Name(resource, "Hartree") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hasa_%28Korean_military%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hasa_%28Korean_military%29">http://dbpedia.org/resource/Hasa_%28Korean_military%29</seealso>
    let ``Hasa_%28Korean_military%29`` =
        Prefixed_Name(resource, "Hasa_%28Korean_military%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Havildar</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Havildar">http://dbpedia.org/resource/Havildar</seealso>
    let Havildar = Prefixed_Name(resource, "Havildar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Heart_disease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Heart_disease">http://dbpedia.org/resource/Heart_disease</seealso>
    let Heart_disease = Prefixed_Name(resource, "Heart_disease") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Heat_transfer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Heat_transfer">http://dbpedia.org/resource/Heat_transfer</seealso>
    let Heat_transfer = Prefixed_Name(resource, "Heat_transfer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hermeticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hermeticism">http://dbpedia.org/resource/Hermeticism</seealso>
    let Hermeticism = Prefixed_Name(resource, "Hermeticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hetman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hetman">http://dbpedia.org/resource/Hetman</seealso>
    let Hetman = Prefixed_Name(resource, "Hetman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/High_Tory</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/High_Tory">http://dbpedia.org/resource/High_Tory</seealso>
    let High_Tory = Prefixed_Name(resource, "High_Tory") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/High_church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/High_church">http://dbpedia.org/resource/High_church</seealso>
    let High_church = Prefixed_Name(resource, "High_church") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Higher_education</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Higher_education">http://dbpedia.org/resource/Higher_education</seealso>
    let Higher_education = Prefixed_Name(resource, "Higher_education") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hinduism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hinduism">http://dbpedia.org/resource/Hinduism</seealso>
    let Hinduism = Prefixed_Name(resource, "Hinduism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hipparchus_%28cavalry_officer%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hipparchus_%28cavalry_officer%29">http://dbpedia.org/resource/Hipparchus_%28cavalry_officer%29</seealso>
    let ``Hipparchus_%28cavalry_officer%29`` =
        Prefixed_Name(resource, "Hipparchus_%28cavalry_officer%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/History_of_the_cooperative_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/History_of_the_cooperative_movement">http://dbpedia.org/resource/History_of_the_cooperative_movement</seealso>
    let History_of_the_cooperative_movement =
        Prefixed_Name(resource, "History_of_the_cooperative_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Home_rule</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Home_rule">http://dbpedia.org/resource/Home_rule</seealso>
    let Home_rule = Prefixed_Name(resource, "Home_rule") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Honduras</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Honduras">http://dbpedia.org/resource/Honduras</seealso>
    let Honduras = Prefixed_Name(resource, "Honduras") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Honorary_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Honorary_degree">http://dbpedia.org/resource/Honorary_degree</seealso>
    let Honorary_degree = Prefixed_Name(resource, "Honorary_degree") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Horizon_Fuel_Cell_Technolgies</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Horizon Fuel Cell Technologies is a company founded in 2003 in Singapore, serving a diverse range of industries with various fuel cell electric energy solutions and products. Horizon Fuel Cell Technologies products and solutions are enabled by in-house manufacturing of micro-size to multi-kilowatt scale proton exchange membrane fuel cells, combined with a choice of proprietary on-demand hydrogen storage and production methods including hydrolysis, electrolysis and reformer-based solutions."</para>
    /// labels<para>"Horizon Fuel Cell Technologies"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Horizon_Fuel_Cell_Technolgies">http://dbpedia.org/resource/Horizon_Fuel_Cell_Technolgies</seealso>
    let Horizon_Fuel_Cell_Technolgies =
        Prefixed_Name(resource, "Horizon_Fuel_Cell_Technolgies") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Horse_artillery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Horse_artillery">http://dbpedia.org/resource/Horse_artillery</seealso>
    let Horse_artillery = Prefixed_Name(resource, "Horse_artillery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/House_of_Hanover</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/House_of_Hanover">http://dbpedia.org/resource/House_of_Hanover</seealso>
    let House_of_Hanover = Prefixed_Name(resource, "House_of_Hanover") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/House_of_York</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/House_of_York">http://dbpedia.org/resource/House_of_York</seealso>
    let House_of_York = Prefixed_Name(resource, "House_of_York") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Household_Cavalry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Household_Cavalry">http://dbpedia.org/resource/Household_Cavalry</seealso>
    let Household_Cavalry = Prefixed_Name(resource, "Household_Cavalry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Howard_Burnham</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Howard_Burnham">http://dbpedia.org/resource/Howard_Burnham</seealso>
    let Howard_Burnham = Prefixed_Name(resource, "Howard_Burnham") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Huguenot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Huguenot">http://dbpedia.org/resource/Huguenot</seealso>
    let Huguenot = Prefixed_Name(resource, "Huguenot") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Human_hair_color</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Human_hair_color">http://dbpedia.org/resource/Human_hair_color</seealso>
    let Human_hair_color = Prefixed_Name(resource, "Human_hair_color") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Human_rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Human_rights">http://dbpedia.org/resource/Human_rights</seealso>
    let Human_rights = Prefixed_Name(resource, "Human_rights") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Humanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Humanism">http://dbpedia.org/resource/Humanism</seealso>
    let Humanism = Prefixed_Name(resource, "Humanism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>planet:resource/Meteorology_Property</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Humidity">http://dbpedia.org/resource/Humidity</seealso>
    let Humidity = Prefixed_Name(resource, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hungary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hungary">http://dbpedia.org/resource/Hungary</seealso>
    let Hungary = Prefixed_Name(resource, "Hungary") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hybrid_electric_vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:RoadApplication</para>
    ///   <para>"A hybrid electric vehicle (HEV) is a type of hybrid vehicle that combines a conventional internal combustion engine (ICE) system with an electric propulsion system (hybrid vehicle drivetrain). The presence of the electric powertrain is intended to achieve either better fuel economy than a conventional vehicle or better performance. There is a variety of HEV types and the degree to which each function as an electric vehicle (EV) also varies. The most common form of HEV is the hybrid electric car, although hybrid electric trucks (pickups and tractors), buses, boats and aircraft also exist."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hybrid_electric_vehicle">http://dbpedia.org/resource/Hybrid_electric_vehicle</seealso>
    let Hybrid_electric_vehicle =
        Prefixed_Name(resource, "Hybrid_electric_vehicle") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hybrid_train</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Train</para>
    ///   <para>"A hybrid train is a locomotive, railcar or train that uses an onboard rechargeable energy storage system (RESS), placed between the power source (often a diesel engine prime mover) and the traction transmission system connected to the wheels. Since most diesel locomotives are diesel-electric, they have all the components of a series hybrid transmission except the storage battery, making this a relatively simple prospect."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hybrid_train">http://dbpedia.org/resource/Hybrid_train</seealso>
    let Hybrid_train = Prefixed_Name(resource, "Hybrid_train") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hydrogen-powered_aircraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Aircraft</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A hydrogen-powered aircraft is an aeroplane that uses hydrogen fuel as a power source. Hydrogen can either be burned in a jet engine or another kind of internal combustion engine, or can be used to power a fuel cell to generate electricity to power a propeller. Unlike most aircraft, which store fuel in the wings, hydrogen-powered aircraft are usually designed with the hydrogen fuel tanks inside the fuselage."</para>
    /// labels<para>"Hydrogen-powered aircraft"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hydrogen-powered_aircraft">http://dbpedia.org/resource/Hydrogen-powered_aircraft</seealso>
    let Hydrogen_powered_aircraft =
        Prefixed_Name(resource, "Hydrogen-powered_aircraft") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hydrogen_Fuel_Cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenReconversion</para>
    ///
    /// labels<para>"Hydrogen Fuel Cell"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hydrogen_Fuel_Cell">http://dbpedia.org/resource/Hydrogen_Fuel_Cell</seealso>
    let Hydrogen_Fuel_Cell =
        Prefixed_Name(resource, "Hydrogen_Fuel_Cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hydrogen_Tank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenStorage</para>
    ///   <para>"A hydrogen tank (other names- cartridge or canister) is used for hydrogen storage. The first type IV hydrogen tanks for compressed hydrogen at 700 bars (70 MPa; 10,000 psi) were demonstrated in 2001, the first fuel cell vehicles on the road with type IV tanks are the Toyota FCHV, Mercedes-Benz F-Cell and the GM HydroGen4."</para>
    /// labels<para>"Hydrogen Tank"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hydrogen_Tank">http://dbpedia.org/resource/Hydrogen_Tank</seealso>
    let Hydrogen_Tank = Prefixed_Name(resource, "Hydrogen_Tank") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hydrogen_engine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenReconversion</para>
    ///
    /// labels<para>"Hydrogen engine"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hydrogen_engine">http://dbpedia.org/resource/Hydrogen_engine</seealso>
    let Hydrogen_engine = Prefixed_Name(resource, "Hydrogen_engine") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hydrogen_technologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:HydrogenProduct</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Hydrogen technologies are technologies that relate to the production and use of hydrogen. Hydrogen technologies are applicable for many uses. Some hydrogen technologies are carbon neutral and could have a role in preventing climate change and a possible future hydrogen economy. Hydrogen is a chemical widely used in various applications including ammonia production, oil refining and energy. The most common methods for producing hydrogen on an industrial scale are: Steam reforming, , coal gasification, water electrolysis. Hydrogen is not a primary energy source, because it is not naturally occurring as a fuel. It is, however, widely regarded as an ideal energy storage medium, due to the ease with which electricity can convert water into hydrogen and oxygen through electrolysis and can be con"</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hydrogen_technologies">http://dbpedia.org/resource/Hydrogen_technologies</seealso>
    let Hydrogen_technologies =
        Prefixed_Name(resource, "Hydrogen_technologies") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hypertension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hypertension">http://dbpedia.org/resource/Hypertension</seealso>
    let Hypertension = Prefixed_Name(resource, "Hypertension") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hypotension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hypotension">http://dbpedia.org/resource/Hypotension</seealso>
    let Hypotension = Prefixed_Name(resource, "Hypotension") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hyundai_Motor_Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Hyundai Motor Company, often abbreviated to Hyundai Motors (Korean: 현대자동차; Hanja: 現代自動車; RR: Hyeondae Jadongcha ) and commonly known as Hyundai (Korean: 현대; Hanja: 現代; RR: Hyeondae, IPA: [ˈhjəːndɛ]; lit. 'modernity'), is a South Korean multinational automotive manufacturer headquartered in Seoul, South Korea. Hyundai Motor Company was founded in 1967. Currently, the company owns 33.88 percent of Kia Corporation, and also fully owns two marques including its luxury cars subsidiary, Genesis Motor, and an electric vehicle sub-brand, Ioniq. Those three brands altogether comprise the Hyundai Motor Group."</para>
    /// labels<para>"Hyundai Motor Company"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hyundai_Motor_Company">http://dbpedia.org/resource/Hyundai_Motor_Company</seealso>
    let Hyundai_Motor_Company =
        Prefixed_Name(resource, "Hyundai_Motor_Company") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Hyundai_Nexo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Car</para>
    ///   <para>"The Hyundai Nexo (Korean: 현대 넥쏘, romanized: Hyeondae Negso) is a hydrogen fuel cell powered crossover SUV that was revealed at the 2018 Consumer Electronics Show on January 8, 2018. Replacing the Hyundai Tucson FCEV, the Nexo is the flagship for Hyundai's "eco car" portfolio."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hyundai_Nexo">http://dbpedia.org/resource/Hyundai_Nexo</seealso>
    let Hyundai_Nexo = Prefixed_Name(resource, "Hyundai_Nexo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hyundai_ix35_FCEV</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Car</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Hyundai ix35 FCEV or Tucson FCEV is a hydrogen fuel cell electric vehicle developed by Hyundai. The model is a left-hand drive only conversion to the SUV platform it is based on and was the first of its type to be mass-produced and sold commercially in the world. Different versions are known, the previous version was based on the Hyundai Tucson FCEV, and the upcoming model is based on the current ix35 FCEV. The first generation was introduced in 2001, with the Hyundai Santa Fe FCEV, and had a range of 100 miles (160 km), with a top speed of 78 mph (126 km/h)."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Hyundai_ix35_FCEV">http://dbpedia.org/resource/Hyundai_ix35_FCEV</seealso>
    let Hyundai_ix35_FCEV = Prefixed_Name(resource, "Hyundai_ix35_FCEV") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Hyzon_Motors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"Hyzon Motors is a supplier of zero-emissions hydrogen fuel cell powered commercial vehicles, including heavy duty trucks, buses and coaches. Hyzon was established as a new business of Horizon Fuel Cell Technologies."</para>
    /// labels<para>"Hyzon Motors"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Hyzon_Motors">http://dbpedia.org/resource/Hyzon_Motors</seealso>
    let Hyzon_Motors = Prefixed_Name(resource, "Hyzon_Motors") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/IC_codes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/IC_codes">http://dbpedia.org/resource/IC_codes</seealso>
    let IC_codes = Prefixed_Name(resource, "IC_codes") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/IGES</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/IGES">http://dbpedia.org/resource/IGES</seealso>
    let IGES = Prefixed_Name(resource, "IGES") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/INSEE</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/INSEE">http://dbpedia.org/resource/INSEE</seealso>
    let INSEE = Prefixed_Name(resource, "INSEE") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_5218</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_5218">http://dbpedia.org/resource/ISO_5218</seealso>
    let ISO_5218 = Prefixed_Name(resource, "ISO_5218") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:aa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:aa">http://dbpedia.org/resource/ISO_639:aa</seealso>
    let ``ISO_639:aa`` = Prefixed_Name(resource, "ISO_639:aa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ab">http://dbpedia.org/resource/ISO_639:ab</seealso>
    let ``ISO_639:ab`` = Prefixed_Name(resource, "ISO_639:ab") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ae">http://dbpedia.org/resource/ISO_639:ae</seealso>
    let ``ISO_639:ae`` = Prefixed_Name(resource, "ISO_639:ae") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:af</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:af">http://dbpedia.org/resource/ISO_639:af</seealso>
    let ``ISO_639:af`` = Prefixed_Name(resource, "ISO_639:af") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ak">http://dbpedia.org/resource/ISO_639:ak</seealso>
    let ``ISO_639:ak`` = Prefixed_Name(resource, "ISO_639:ak") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:am</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:am">http://dbpedia.org/resource/ISO_639:am</seealso>
    let ``ISO_639:am`` = Prefixed_Name(resource, "ISO_639:am") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:an</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:an">http://dbpedia.org/resource/ISO_639:an</seealso>
    let ``ISO_639:an`` = Prefixed_Name(resource, "ISO_639:an") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ar">http://dbpedia.org/resource/ISO_639:ar</seealso>
    let ``ISO_639:ar`` = Prefixed_Name(resource, "ISO_639:ar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:as</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:as">http://dbpedia.org/resource/ISO_639:as</seealso>
    let ``ISO_639:as`` = Prefixed_Name(resource, "ISO_639:as") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:av</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:av">http://dbpedia.org/resource/ISO_639:av</seealso>
    let ``ISO_639:av`` = Prefixed_Name(resource, "ISO_639:av") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ay">http://dbpedia.org/resource/ISO_639:ay</seealso>
    let ``ISO_639:ay`` = Prefixed_Name(resource, "ISO_639:ay") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:az</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:az">http://dbpedia.org/resource/ISO_639:az</seealso>
    let ``ISO_639:az`` = Prefixed_Name(resource, "ISO_639:az") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ba</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ba">http://dbpedia.org/resource/ISO_639:ba</seealso>
    let ``ISO_639:ba`` = Prefixed_Name(resource, "ISO_639:ba") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:be</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:be">http://dbpedia.org/resource/ISO_639:be</seealso>
    let ``ISO_639:be`` = Prefixed_Name(resource, "ISO_639:be") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bg">http://dbpedia.org/resource/ISO_639:bg</seealso>
    let ``ISO_639:bg`` = Prefixed_Name(resource, "ISO_639:bg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bh">http://dbpedia.org/resource/ISO_639:bh</seealso>
    let ``ISO_639:bh`` = Prefixed_Name(resource, "ISO_639:bh") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bi">http://dbpedia.org/resource/ISO_639:bi</seealso>
    let ``ISO_639:bi`` = Prefixed_Name(resource, "ISO_639:bi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bm">http://dbpedia.org/resource/ISO_639:bm</seealso>
    let ``ISO_639:bm`` = Prefixed_Name(resource, "ISO_639:bm") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bn">http://dbpedia.org/resource/ISO_639:bn</seealso>
    let ``ISO_639:bn`` = Prefixed_Name(resource, "ISO_639:bn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bo">http://dbpedia.org/resource/ISO_639:bo</seealso>
    let ``ISO_639:bo`` = Prefixed_Name(resource, "ISO_639:bo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:br</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:br">http://dbpedia.org/resource/ISO_639:br</seealso>
    let ``ISO_639:br`` = Prefixed_Name(resource, "ISO_639:br") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:bs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:bs">http://dbpedia.org/resource/ISO_639:bs</seealso>
    let ``ISO_639:bs`` = Prefixed_Name(resource, "ISO_639:bs") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ca</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ca">http://dbpedia.org/resource/ISO_639:ca</seealso>
    let ``ISO_639:ca`` = Prefixed_Name(resource, "ISO_639:ca") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ce">http://dbpedia.org/resource/ISO_639:ce</seealso>
    let ``ISO_639:ce`` = Prefixed_Name(resource, "ISO_639:ce") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ch">http://dbpedia.org/resource/ISO_639:ch</seealso>
    let ``ISO_639:ch`` = Prefixed_Name(resource, "ISO_639:ch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:co</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:co">http://dbpedia.org/resource/ISO_639:co</seealso>
    let ``ISO_639:co`` = Prefixed_Name(resource, "ISO_639:co") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:cr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:cr">http://dbpedia.org/resource/ISO_639:cr</seealso>
    let ``ISO_639:cr`` = Prefixed_Name(resource, "ISO_639:cr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:cs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:cs">http://dbpedia.org/resource/ISO_639:cs</seealso>
    let ``ISO_639:cs`` = Prefixed_Name(resource, "ISO_639:cs") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:cu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:cu">http://dbpedia.org/resource/ISO_639:cu</seealso>
    let ``ISO_639:cu`` = Prefixed_Name(resource, "ISO_639:cu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:cv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:cv">http://dbpedia.org/resource/ISO_639:cv</seealso>
    let ``ISO_639:cv`` = Prefixed_Name(resource, "ISO_639:cv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:cy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:cy">http://dbpedia.org/resource/ISO_639:cy</seealso>
    let ``ISO_639:cy`` = Prefixed_Name(resource, "ISO_639:cy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:da</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:da">http://dbpedia.org/resource/ISO_639:da</seealso>
    let ``ISO_639:da`` = Prefixed_Name(resource, "ISO_639:da") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:de</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:de">http://dbpedia.org/resource/ISO_639:de</seealso>
    let ``ISO_639:de`` = Prefixed_Name(resource, "ISO_639:de") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:dv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:dv">http://dbpedia.org/resource/ISO_639:dv</seealso>
    let ``ISO_639:dv`` = Prefixed_Name(resource, "ISO_639:dv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:dz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:dz">http://dbpedia.org/resource/ISO_639:dz</seealso>
    let ``ISO_639:dz`` = Prefixed_Name(resource, "ISO_639:dz") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ee">http://dbpedia.org/resource/ISO_639:ee</seealso>
    let ``ISO_639:ee`` = Prefixed_Name(resource, "ISO_639:ee") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:el</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:el">http://dbpedia.org/resource/ISO_639:el</seealso>
    let ``ISO_639:el`` = Prefixed_Name(resource, "ISO_639:el") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:en</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:en">http://dbpedia.org/resource/ISO_639:en</seealso>
    let ``ISO_639:en`` = Prefixed_Name(resource, "ISO_639:en") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:eo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:eo">http://dbpedia.org/resource/ISO_639:eo</seealso>
    let ``ISO_639:eo`` = Prefixed_Name(resource, "ISO_639:eo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:es</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:es">http://dbpedia.org/resource/ISO_639:es</seealso>
    let ``ISO_639:es`` = Prefixed_Name(resource, "ISO_639:es") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:et</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:et">http://dbpedia.org/resource/ISO_639:et</seealso>
    let ``ISO_639:et`` = Prefixed_Name(resource, "ISO_639:et") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:eu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:eu">http://dbpedia.org/resource/ISO_639:eu</seealso>
    let ``ISO_639:eu`` = Prefixed_Name(resource, "ISO_639:eu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fa">http://dbpedia.org/resource/ISO_639:fa</seealso>
    let ``ISO_639:fa`` = Prefixed_Name(resource, "ISO_639:fa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ff">http://dbpedia.org/resource/ISO_639:ff</seealso>
    let ``ISO_639:ff`` = Prefixed_Name(resource, "ISO_639:ff") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fi">http://dbpedia.org/resource/ISO_639:fi</seealso>
    let ``ISO_639:fi`` = Prefixed_Name(resource, "ISO_639:fi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fj">http://dbpedia.org/resource/ISO_639:fj</seealso>
    let ``ISO_639:fj`` = Prefixed_Name(resource, "ISO_639:fj") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fo">http://dbpedia.org/resource/ISO_639:fo</seealso>
    let ``ISO_639:fo`` = Prefixed_Name(resource, "ISO_639:fo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fr">http://dbpedia.org/resource/ISO_639:fr</seealso>
    let ``ISO_639:fr`` = Prefixed_Name(resource, "ISO_639:fr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:fy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:fy">http://dbpedia.org/resource/ISO_639:fy</seealso>
    let ``ISO_639:fy`` = Prefixed_Name(resource, "ISO_639:fy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ga">http://dbpedia.org/resource/ISO_639:ga</seealso>
    let ``ISO_639:ga`` = Prefixed_Name(resource, "ISO_639:ga") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:gd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:gd">http://dbpedia.org/resource/ISO_639:gd</seealso>
    let ``ISO_639:gd`` = Prefixed_Name(resource, "ISO_639:gd") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:gl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:gl">http://dbpedia.org/resource/ISO_639:gl</seealso>
    let ``ISO_639:gl`` = Prefixed_Name(resource, "ISO_639:gl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:gn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:gn">http://dbpedia.org/resource/ISO_639:gn</seealso>
    let ``ISO_639:gn`` = Prefixed_Name(resource, "ISO_639:gn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:gu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:gu">http://dbpedia.org/resource/ISO_639:gu</seealso>
    let ``ISO_639:gu`` = Prefixed_Name(resource, "ISO_639:gu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:gv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:gv">http://dbpedia.org/resource/ISO_639:gv</seealso>
    let ``ISO_639:gv`` = Prefixed_Name(resource, "ISO_639:gv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ha">http://dbpedia.org/resource/ISO_639:ha</seealso>
    let ``ISO_639:ha`` = Prefixed_Name(resource, "ISO_639:ha") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:he</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:he">http://dbpedia.org/resource/ISO_639:he</seealso>
    let ``ISO_639:he`` = Prefixed_Name(resource, "ISO_639:he") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:hi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:hi">http://dbpedia.org/resource/ISO_639:hi</seealso>
    let ``ISO_639:hi`` = Prefixed_Name(resource, "ISO_639:hi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ho</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ho">http://dbpedia.org/resource/ISO_639:ho</seealso>
    let ``ISO_639:ho`` = Prefixed_Name(resource, "ISO_639:ho") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:hr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:hr">http://dbpedia.org/resource/ISO_639:hr</seealso>
    let ``ISO_639:hr`` = Prefixed_Name(resource, "ISO_639:hr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ht</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ht">http://dbpedia.org/resource/ISO_639:ht</seealso>
    let ``ISO_639:ht`` = Prefixed_Name(resource, "ISO_639:ht") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:hu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:hu">http://dbpedia.org/resource/ISO_639:hu</seealso>
    let ``ISO_639:hu`` = Prefixed_Name(resource, "ISO_639:hu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:hy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:hy">http://dbpedia.org/resource/ISO_639:hy</seealso>
    let ``ISO_639:hy`` = Prefixed_Name(resource, "ISO_639:hy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:hz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:hz">http://dbpedia.org/resource/ISO_639:hz</seealso>
    let ``ISO_639:hz`` = Prefixed_Name(resource, "ISO_639:hz") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ia">http://dbpedia.org/resource/ISO_639:ia</seealso>
    let ``ISO_639:ia`` = Prefixed_Name(resource, "ISO_639:ia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:id">http://dbpedia.org/resource/ISO_639:id</seealso>
    let ``ISO_639:id`` = Prefixed_Name(resource, "ISO_639:id") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ie">http://dbpedia.org/resource/ISO_639:ie</seealso>
    let ``ISO_639:ie`` = Prefixed_Name(resource, "ISO_639:ie") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ig</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ig">http://dbpedia.org/resource/ISO_639:ig</seealso>
    let ``ISO_639:ig`` = Prefixed_Name(resource, "ISO_639:ig") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ii</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ii">http://dbpedia.org/resource/ISO_639:ii</seealso>
    let ``ISO_639:ii`` = Prefixed_Name(resource, "ISO_639:ii") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ik</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ik">http://dbpedia.org/resource/ISO_639:ik</seealso>
    let ``ISO_639:ik`` = Prefixed_Name(resource, "ISO_639:ik") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:io</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:io">http://dbpedia.org/resource/ISO_639:io</seealso>
    let ``ISO_639:io`` = Prefixed_Name(resource, "ISO_639:io") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:is</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:is">http://dbpedia.org/resource/ISO_639:is</seealso>
    let ``ISO_639:is`` = Prefixed_Name(resource, "ISO_639:is") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:it</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:it">http://dbpedia.org/resource/ISO_639:it</seealso>
    let ``ISO_639:it`` = Prefixed_Name(resource, "ISO_639:it") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:iu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:iu">http://dbpedia.org/resource/ISO_639:iu</seealso>
    let ``ISO_639:iu`` = Prefixed_Name(resource, "ISO_639:iu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ja</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ja">http://dbpedia.org/resource/ISO_639:ja</seealso>
    let ``ISO_639:ja`` = Prefixed_Name(resource, "ISO_639:ja") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:jv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:jv">http://dbpedia.org/resource/ISO_639:jv</seealso>
    let ``ISO_639:jv`` = Prefixed_Name(resource, "ISO_639:jv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ka">http://dbpedia.org/resource/ISO_639:ka</seealso>
    let ``ISO_639:ka`` = Prefixed_Name(resource, "ISO_639:ka") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kg">http://dbpedia.org/resource/ISO_639:kg</seealso>
    let ``ISO_639:kg`` = Prefixed_Name(resource, "ISO_639:kg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ki</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ki">http://dbpedia.org/resource/ISO_639:ki</seealso>
    let ``ISO_639:ki`` = Prefixed_Name(resource, "ISO_639:ki") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kj">http://dbpedia.org/resource/ISO_639:kj</seealso>
    let ``ISO_639:kj`` = Prefixed_Name(resource, "ISO_639:kj") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kk">http://dbpedia.org/resource/ISO_639:kk</seealso>
    let ``ISO_639:kk`` = Prefixed_Name(resource, "ISO_639:kk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kl">http://dbpedia.org/resource/ISO_639:kl</seealso>
    let ``ISO_639:kl`` = Prefixed_Name(resource, "ISO_639:kl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:km</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:km">http://dbpedia.org/resource/ISO_639:km</seealso>
    let ``ISO_639:km`` = Prefixed_Name(resource, "ISO_639:km") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kn">http://dbpedia.org/resource/ISO_639:kn</seealso>
    let ``ISO_639:kn`` = Prefixed_Name(resource, "ISO_639:kn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ko</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ko">http://dbpedia.org/resource/ISO_639:ko</seealso>
    let ``ISO_639:ko`` = Prefixed_Name(resource, "ISO_639:ko") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kr">http://dbpedia.org/resource/ISO_639:kr</seealso>
    let ``ISO_639:kr`` = Prefixed_Name(resource, "ISO_639:kr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ks">http://dbpedia.org/resource/ISO_639:ks</seealso>
    let ``ISO_639:ks`` = Prefixed_Name(resource, "ISO_639:ks") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ku</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ku">http://dbpedia.org/resource/ISO_639:ku</seealso>
    let ``ISO_639:ku`` = Prefixed_Name(resource, "ISO_639:ku") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kv">http://dbpedia.org/resource/ISO_639:kv</seealso>
    let ``ISO_639:kv`` = Prefixed_Name(resource, "ISO_639:kv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:kw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:kw">http://dbpedia.org/resource/ISO_639:kw</seealso>
    let ``ISO_639:kw`` = Prefixed_Name(resource, "ISO_639:kw") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ky</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ky">http://dbpedia.org/resource/ISO_639:ky</seealso>
    let ``ISO_639:ky`` = Prefixed_Name(resource, "ISO_639:ky") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:la</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:la">http://dbpedia.org/resource/ISO_639:la</seealso>
    let ``ISO_639:la`` = Prefixed_Name(resource, "ISO_639:la") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lb">http://dbpedia.org/resource/ISO_639:lb</seealso>
    let ``ISO_639:lb`` = Prefixed_Name(resource, "ISO_639:lb") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lg">http://dbpedia.org/resource/ISO_639:lg</seealso>
    let ``ISO_639:lg`` = Prefixed_Name(resource, "ISO_639:lg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:li</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:li">http://dbpedia.org/resource/ISO_639:li</seealso>
    let ``ISO_639:li`` = Prefixed_Name(resource, "ISO_639:li") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ln</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ln">http://dbpedia.org/resource/ISO_639:ln</seealso>
    let ``ISO_639:ln`` = Prefixed_Name(resource, "ISO_639:ln") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lo">http://dbpedia.org/resource/ISO_639:lo</seealso>
    let ``ISO_639:lo`` = Prefixed_Name(resource, "ISO_639:lo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lt">http://dbpedia.org/resource/ISO_639:lt</seealso>
    let ``ISO_639:lt`` = Prefixed_Name(resource, "ISO_639:lt") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lu">http://dbpedia.org/resource/ISO_639:lu</seealso>
    let ``ISO_639:lu`` = Prefixed_Name(resource, "ISO_639:lu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:lv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:lv">http://dbpedia.org/resource/ISO_639:lv</seealso>
    let ``ISO_639:lv`` = Prefixed_Name(resource, "ISO_639:lv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mg">http://dbpedia.org/resource/ISO_639:mg</seealso>
    let ``ISO_639:mg`` = Prefixed_Name(resource, "ISO_639:mg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mh">http://dbpedia.org/resource/ISO_639:mh</seealso>
    let ``ISO_639:mh`` = Prefixed_Name(resource, "ISO_639:mh") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mi">http://dbpedia.org/resource/ISO_639:mi</seealso>
    let ``ISO_639:mi`` = Prefixed_Name(resource, "ISO_639:mi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mk">http://dbpedia.org/resource/ISO_639:mk</seealso>
    let ``ISO_639:mk`` = Prefixed_Name(resource, "ISO_639:mk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ml">http://dbpedia.org/resource/ISO_639:ml</seealso>
    let ``ISO_639:ml`` = Prefixed_Name(resource, "ISO_639:ml") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mn">http://dbpedia.org/resource/ISO_639:mn</seealso>
    let ``ISO_639:mn`` = Prefixed_Name(resource, "ISO_639:mn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mr">http://dbpedia.org/resource/ISO_639:mr</seealso>
    let ``ISO_639:mr`` = Prefixed_Name(resource, "ISO_639:mr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ms">http://dbpedia.org/resource/ISO_639:ms</seealso>
    let ``ISO_639:ms`` = Prefixed_Name(resource, "ISO_639:ms") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:mt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:mt">http://dbpedia.org/resource/ISO_639:mt</seealso>
    let ``ISO_639:mt`` = Prefixed_Name(resource, "ISO_639:mt") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:my</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:my">http://dbpedia.org/resource/ISO_639:my</seealso>
    let ``ISO_639:my`` = Prefixed_Name(resource, "ISO_639:my") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:na</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:na">http://dbpedia.org/resource/ISO_639:na</seealso>
    let ``ISO_639:na`` = Prefixed_Name(resource, "ISO_639:na") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nb">http://dbpedia.org/resource/ISO_639:nb</seealso>
    let ``ISO_639:nb`` = Prefixed_Name(resource, "ISO_639:nb") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nd">http://dbpedia.org/resource/ISO_639:nd</seealso>
    let ``ISO_639:nd`` = Prefixed_Name(resource, "ISO_639:nd") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ne">http://dbpedia.org/resource/ISO_639:ne</seealso>
    let ``ISO_639:ne`` = Prefixed_Name(resource, "ISO_639:ne") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ng</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ng">http://dbpedia.org/resource/ISO_639:ng</seealso>
    let ``ISO_639:ng`` = Prefixed_Name(resource, "ISO_639:ng") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nl">http://dbpedia.org/resource/ISO_639:nl</seealso>
    let ``ISO_639:nl`` = Prefixed_Name(resource, "ISO_639:nl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nn">http://dbpedia.org/resource/ISO_639:nn</seealso>
    let ``ISO_639:nn`` = Prefixed_Name(resource, "ISO_639:nn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:no</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:no">http://dbpedia.org/resource/ISO_639:no</seealso>
    let ``ISO_639:no`` = Prefixed_Name(resource, "ISO_639:no") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nr">http://dbpedia.org/resource/ISO_639:nr</seealso>
    let ``ISO_639:nr`` = Prefixed_Name(resource, "ISO_639:nr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:nv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:nv">http://dbpedia.org/resource/ISO_639:nv</seealso>
    let ``ISO_639:nv`` = Prefixed_Name(resource, "ISO_639:nv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ny</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ny">http://dbpedia.org/resource/ISO_639:ny</seealso>
    let ``ISO_639:ny`` = Prefixed_Name(resource, "ISO_639:ny") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:oc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:oc">http://dbpedia.org/resource/ISO_639:oc</seealso>
    let ``ISO_639:oc`` = Prefixed_Name(resource, "ISO_639:oc") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:oj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:oj">http://dbpedia.org/resource/ISO_639:oj</seealso>
    let ``ISO_639:oj`` = Prefixed_Name(resource, "ISO_639:oj") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:om</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:om">http://dbpedia.org/resource/ISO_639:om</seealso>
    let ``ISO_639:om`` = Prefixed_Name(resource, "ISO_639:om") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:or</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:or">http://dbpedia.org/resource/ISO_639:or</seealso>
    let ``ISO_639:or`` = Prefixed_Name(resource, "ISO_639:or") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:os</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:os">http://dbpedia.org/resource/ISO_639:os</seealso>
    let ``ISO_639:os`` = Prefixed_Name(resource, "ISO_639:os") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:pa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:pa">http://dbpedia.org/resource/ISO_639:pa</seealso>
    let ``ISO_639:pa`` = Prefixed_Name(resource, "ISO_639:pa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:pi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:pi">http://dbpedia.org/resource/ISO_639:pi</seealso>
    let ``ISO_639:pi`` = Prefixed_Name(resource, "ISO_639:pi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:pl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:pl">http://dbpedia.org/resource/ISO_639:pl</seealso>
    let ``ISO_639:pl`` = Prefixed_Name(resource, "ISO_639:pl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ps">http://dbpedia.org/resource/ISO_639:ps</seealso>
    let ``ISO_639:ps`` = Prefixed_Name(resource, "ISO_639:ps") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:pt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:pt">http://dbpedia.org/resource/ISO_639:pt</seealso>
    let ``ISO_639:pt`` = Prefixed_Name(resource, "ISO_639:pt") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:qu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:qu">http://dbpedia.org/resource/ISO_639:qu</seealso>
    let ``ISO_639:qu`` = Prefixed_Name(resource, "ISO_639:qu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:rm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:rm">http://dbpedia.org/resource/ISO_639:rm</seealso>
    let ``ISO_639:rm`` = Prefixed_Name(resource, "ISO_639:rm") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:rn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:rn">http://dbpedia.org/resource/ISO_639:rn</seealso>
    let ``ISO_639:rn`` = Prefixed_Name(resource, "ISO_639:rn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ro">http://dbpedia.org/resource/ISO_639:ro</seealso>
    let ``ISO_639:ro`` = Prefixed_Name(resource, "ISO_639:ro") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ru</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ru">http://dbpedia.org/resource/ISO_639:ru</seealso>
    let ``ISO_639:ru`` = Prefixed_Name(resource, "ISO_639:ru") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:rw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:rw">http://dbpedia.org/resource/ISO_639:rw</seealso>
    let ``ISO_639:rw`` = Prefixed_Name(resource, "ISO_639:rw") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sa">http://dbpedia.org/resource/ISO_639:sa</seealso>
    let ``ISO_639:sa`` = Prefixed_Name(resource, "ISO_639:sa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sc">http://dbpedia.org/resource/ISO_639:sc</seealso>
    let ``ISO_639:sc`` = Prefixed_Name(resource, "ISO_639:sc") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sd">http://dbpedia.org/resource/ISO_639:sd</seealso>
    let ``ISO_639:sd`` = Prefixed_Name(resource, "ISO_639:sd") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:se</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:se">http://dbpedia.org/resource/ISO_639:se</seealso>
    let ``ISO_639:se`` = Prefixed_Name(resource, "ISO_639:se") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sg">http://dbpedia.org/resource/ISO_639:sg</seealso>
    let ``ISO_639:sg`` = Prefixed_Name(resource, "ISO_639:sg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:si</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:si">http://dbpedia.org/resource/ISO_639:si</seealso>
    let ``ISO_639:si`` = Prefixed_Name(resource, "ISO_639:si") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sk">http://dbpedia.org/resource/ISO_639:sk</seealso>
    let ``ISO_639:sk`` = Prefixed_Name(resource, "ISO_639:sk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sl">http://dbpedia.org/resource/ISO_639:sl</seealso>
    let ``ISO_639:sl`` = Prefixed_Name(resource, "ISO_639:sl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sm">http://dbpedia.org/resource/ISO_639:sm</seealso>
    let ``ISO_639:sm`` = Prefixed_Name(resource, "ISO_639:sm") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sn">http://dbpedia.org/resource/ISO_639:sn</seealso>
    let ``ISO_639:sn`` = Prefixed_Name(resource, "ISO_639:sn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:so</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:so">http://dbpedia.org/resource/ISO_639:so</seealso>
    let ``ISO_639:so`` = Prefixed_Name(resource, "ISO_639:so") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sq">http://dbpedia.org/resource/ISO_639:sq</seealso>
    let ``ISO_639:sq`` = Prefixed_Name(resource, "ISO_639:sq") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sr">http://dbpedia.org/resource/ISO_639:sr</seealso>
    let ``ISO_639:sr`` = Prefixed_Name(resource, "ISO_639:sr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ss">http://dbpedia.org/resource/ISO_639:ss</seealso>
    let ``ISO_639:ss`` = Prefixed_Name(resource, "ISO_639:ss") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:st</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:st">http://dbpedia.org/resource/ISO_639:st</seealso>
    let ``ISO_639:st`` = Prefixed_Name(resource, "ISO_639:st") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:su</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:su">http://dbpedia.org/resource/ISO_639:su</seealso>
    let ``ISO_639:su`` = Prefixed_Name(resource, "ISO_639:su") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sv</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sv">http://dbpedia.org/resource/ISO_639:sv</seealso>
    let ``ISO_639:sv`` = Prefixed_Name(resource, "ISO_639:sv") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:sw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:sw">http://dbpedia.org/resource/ISO_639:sw</seealso>
    let ``ISO_639:sw`` = Prefixed_Name(resource, "ISO_639:sw") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ta">http://dbpedia.org/resource/ISO_639:ta</seealso>
    let ``ISO_639:ta`` = Prefixed_Name(resource, "ISO_639:ta") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:te</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:te">http://dbpedia.org/resource/ISO_639:te</seealso>
    let ``ISO_639:te`` = Prefixed_Name(resource, "ISO_639:te") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tg">http://dbpedia.org/resource/ISO_639:tg</seealso>
    let ``ISO_639:tg`` = Prefixed_Name(resource, "ISO_639:tg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:th</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:th">http://dbpedia.org/resource/ISO_639:th</seealso>
    let ``ISO_639:th`` = Prefixed_Name(resource, "ISO_639:th") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ti</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ti">http://dbpedia.org/resource/ISO_639:ti</seealso>
    let ``ISO_639:ti`` = Prefixed_Name(resource, "ISO_639:ti") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tk">http://dbpedia.org/resource/ISO_639:tk</seealso>
    let ``ISO_639:tk`` = Prefixed_Name(resource, "ISO_639:tk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tl">http://dbpedia.org/resource/ISO_639:tl</seealso>
    let ``ISO_639:tl`` = Prefixed_Name(resource, "ISO_639:tl") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tn">http://dbpedia.org/resource/ISO_639:tn</seealso>
    let ``ISO_639:tn`` = Prefixed_Name(resource, "ISO_639:tn") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:to">http://dbpedia.org/resource/ISO_639:to</seealso>
    let ``ISO_639:to`` = Prefixed_Name(resource, "ISO_639:to") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tr">http://dbpedia.org/resource/ISO_639:tr</seealso>
    let ``ISO_639:tr`` = Prefixed_Name(resource, "ISO_639:tr") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ts">http://dbpedia.org/resource/ISO_639:ts</seealso>
    let ``ISO_639:ts`` = Prefixed_Name(resource, "ISO_639:ts") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tt">http://dbpedia.org/resource/ISO_639:tt</seealso>
    let ``ISO_639:tt`` = Prefixed_Name(resource, "ISO_639:tt") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:tw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:tw">http://dbpedia.org/resource/ISO_639:tw</seealso>
    let ``ISO_639:tw`` = Prefixed_Name(resource, "ISO_639:tw") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ty">http://dbpedia.org/resource/ISO_639:ty</seealso>
    let ``ISO_639:ty`` = Prefixed_Name(resource, "ISO_639:ty") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ug">http://dbpedia.org/resource/ISO_639:ug</seealso>
    let ``ISO_639:ug`` = Prefixed_Name(resource, "ISO_639:ug") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:uk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:uk">http://dbpedia.org/resource/ISO_639:uk</seealso>
    let ``ISO_639:uk`` = Prefixed_Name(resource, "ISO_639:uk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ur</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ur">http://dbpedia.org/resource/ISO_639:ur</seealso>
    let ``ISO_639:ur`` = Prefixed_Name(resource, "ISO_639:ur") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:uz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:uz">http://dbpedia.org/resource/ISO_639:uz</seealso>
    let ``ISO_639:uz`` = Prefixed_Name(resource, "ISO_639:uz") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:ve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:ve">http://dbpedia.org/resource/ISO_639:ve</seealso>
    let ``ISO_639:ve`` = Prefixed_Name(resource, "ISO_639:ve") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:vi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:vi">http://dbpedia.org/resource/ISO_639:vi</seealso>
    let ``ISO_639:vi`` = Prefixed_Name(resource, "ISO_639:vi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:vo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:vo">http://dbpedia.org/resource/ISO_639:vo</seealso>
    let ``ISO_639:vo`` = Prefixed_Name(resource, "ISO_639:vo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:wa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:wa">http://dbpedia.org/resource/ISO_639:wa</seealso>
    let ``ISO_639:wa`` = Prefixed_Name(resource, "ISO_639:wa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:wo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:wo">http://dbpedia.org/resource/ISO_639:wo</seealso>
    let ``ISO_639:wo`` = Prefixed_Name(resource, "ISO_639:wo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:xh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:xh">http://dbpedia.org/resource/ISO_639:xh</seealso>
    let ``ISO_639:xh`` = Prefixed_Name(resource, "ISO_639:xh") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:yi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:yi">http://dbpedia.org/resource/ISO_639:yi</seealso>
    let ``ISO_639:yi`` = Prefixed_Name(resource, "ISO_639:yi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:yo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:yo">http://dbpedia.org/resource/ISO_639:yo</seealso>
    let ``ISO_639:yo`` = Prefixed_Name(resource, "ISO_639:yo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:za</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:za">http://dbpedia.org/resource/ISO_639:za</seealso>
    let ``ISO_639:za`` = Prefixed_Name(resource, "ISO_639:za") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:zh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:zh">http://dbpedia.org/resource/ISO_639:zh</seealso>
    let ``ISO_639:zh`` = Prefixed_Name(resource, "ISO_639:zh") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/ISO_639:zu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/ISO_639:zu">http://dbpedia.org/resource/ISO_639:zu</seealso>
    let ``ISO_639:zu`` = Prefixed_Name(resource, "ISO_639:zu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Iceland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Iceland">http://dbpedia.org/resource/Iceland</seealso>
    let Iceland = Prefixed_Name(resource, "Iceland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Icelandic_New_Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>org:Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Icelandic New Energy Ltd (Íslensk NýOrka ehf) is a company that promotes the use of hydrogen fuel in Iceland founded in 1999 following a decision in 1998 by the Icelandic Parliament to convert vehicle and fishing fleets to hydrogen produced from renewable energy by 2050. Together with SEV, and the authorities in the Faroe Islands and Greenland, Icelandic New Energy has established the to investigate hydrogen technology."</para>
    /// labels<para>"Icelandic New Energy"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Icelandic_New_Energy">http://dbpedia.org/resource/Icelandic_New_Energy</seealso>
    let Icelandic_New_Energy =
        Prefixed_Name(resource, "Icelandic_New_Energy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Igbo_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Igbo_people">http://dbpedia.org/resource/Igbo_people</seealso>
    let Igbo_people = Prefixed_Name(resource, "Igbo_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Imperialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Imperialism">http://dbpedia.org/resource/Imperialism</seealso>
    let Imperialism = Prefixed_Name(resource, "Imperialism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Inch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Inch">http://dbpedia.org/resource/Inch</seealso>
    let Inch = Prefixed_Name(resource, "Inch") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Indentured_servitude</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Indentured_servitude">http://dbpedia.org/resource/Indentured_servitude</seealso>
    let Indentured_servitude =
        Prefixed_Name(resource, "Indentured_servitude") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Independent_Methodist_Connexion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Independent_Methodist_Connexion">http://dbpedia.org/resource/Independent_Methodist_Connexion</seealso>
    let Independent_Methodist_Connexion =
        Prefixed_Name(resource, "Independent_Methodist_Connexion") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/India</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/India">http://dbpedia.org/resource/India</seealso>
    let India = Prefixed_Name(resource, "India") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Indian_independence_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Indian_independence_movement">http://dbpedia.org/resource/Indian_independence_movement</seealso>
    let Indian_independence_movement =
        Prefixed_Name(resource, "Indian_independence_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Indian_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Indian_people">http://dbpedia.org/resource/Indian_people</seealso>
    let Indian_people = Prefixed_Name(resource, "Indian_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Indigenous_peoples_of_the_Americas</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Indigenous_peoples_of_the_Americas">http://dbpedia.org/resource/Indigenous_peoples_of_the_Americas</seealso>
    let Indigenous_peoples_of_the_Americas =
        Prefixed_Name(resource, "Indigenous_peoples_of_the_Americas") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Indigenous_rights</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Indigenous_rights">http://dbpedia.org/resource/Indigenous_rights</seealso>
    let Indigenous_rights = Prefixed_Name(resource, "Indigenous_rights") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Individualism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Individualism">http://dbpedia.org/resource/Individualism</seealso>
    let Individualism = Prefixed_Name(resource, "Individualism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Indonesia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Indonesia">http://dbpedia.org/resource/Indonesia</seealso>
    let Indonesia = Prefixed_Name(resource, "Indonesia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Industry_Foundation_Classes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Industry_Foundation_Classes">http://dbpedia.org/resource/Industry_Foundation_Classes</seealso>
    let Industry_Foundation_Classes =
        Prefixed_Name(resource, "Industry_Foundation_Classes") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Internationalism_%28politics%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Internationalism_%28politics%29">http://dbpedia.org/resource/Internationalism_%28politics%29</seealso>
    let ``Internationalism_%28politics%29`` =
        Prefixed_Name(resource, "Internationalism_%28politics%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Internationalism_(politics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Internationalism_(politics">http://dbpedia.org/resource/Internationalism_(politics</seealso>
    let ``Internationalism_(politics`` =
        Prefixed_Name(resource, "Internationalism_(politics") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Internationalism_(politics)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Internationalism_(politics)">http://dbpedia.org/resource/Internationalism_(politics)</seealso>
    let ``Internationalism_(politics)`` =
        Prefixed_Name(resource, "Internationalism_(politics)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Internet">http://dbpedia.org/resource/Internet</seealso>
    let Internet = Prefixed_Name(resource, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Invasion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Invasion">http://dbpedia.org/resource/Invasion</seealso>
    let Invasion = Prefixed_Name(resource, "Invasion") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Inventory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Inventory">http://dbpedia.org/resource/Inventory</seealso>
    let Inventory = Prefixed_Name(resource, "Inventory") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ionian_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ionian_Sea">http://dbpedia.org/resource/Ionian_Sea</seealso>
    let Ionian_Sea = Prefixed_Name(resource, "Ionian_Sea") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ionic_liquid_piston_compressor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:HydrogenStorage</para>
    ///   <para>"An ionic liquid piston compressor, ionic compressor or ionic liquid piston pump is a hydrogen compressor based on an ionic liquid piston instead of a metal piston as in a piston-metal diaphragm compressor."</para>
    /// labels<para>"Ionic liquid piston compressor"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ionic_liquid_piston_compressor">http://dbpedia.org/resource/Ionic_liquid_piston_compressor</seealso>
    let Ionic_liquid_piston_compressor =
        Prefixed_Name(resource, "Ionic_liquid_piston_compressor") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Iran</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Iran">http://dbpedia.org/resource/Iran</seealso>
    let Iran = Prefixed_Name(resource, "Iran") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Iraq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Iraq">http://dbpedia.org/resource/Iraq</seealso>
    let Iraq = Prefixed_Name(resource, "Iraq") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ireland">http://dbpedia.org/resource/Ireland</seealso>
    let Ireland = Prefixed_Name(resource, "Ireland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Irish_Home_Rule_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Irish_Home_Rule_movement">http://dbpedia.org/resource/Irish_Home_Rule_movement</seealso>
    let Irish_Home_Rule_movement =
        Prefixed_Name(resource, "Irish_Home_Rule_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Irish_National_Land_League</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Irish_National_Land_League">http://dbpedia.org/resource/Irish_National_Land_League</seealso>
    let Irish_National_Land_League =
        Prefixed_Name(resource, "Irish_National_Land_League") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Irish_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Irish_nationalism">http://dbpedia.org/resource/Irish_nationalism</seealso>
    let Irish_nationalism = Prefixed_Name(resource, "Irish_nationalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Irish_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Irish_people">http://dbpedia.org/resource/Irish_people</seealso>
    let Irish_people = Prefixed_Name(resource, "Irish_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Irish_republicanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Irish_republicanism">http://dbpedia.org/resource/Irish_republicanism</seealso>
    let Irish_republicanism =
        Prefixed_Name(resource, "Irish_republicanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Iroise_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Iroise_Sea">http://dbpedia.org/resource/Iroise_Sea</seealso>
    let Iroise_Sea = Prefixed_Name(resource, "Iroise_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Iroquois</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Iroquois">http://dbpedia.org/resource/Iroquois</seealso>
    let Iroquois = Prefixed_Name(resource, "Iroquois") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Islam</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Islam">http://dbpedia.org/resource/Islam</seealso>
    let Islam = Prefixed_Name(resource, "Islam") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Isolationism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Isolationism">http://dbpedia.org/resource/Isolationism</seealso>
    let Isolationism = Prefixed_Name(resource, "Isolationism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Israel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Israel">http://dbpedia.org/resource/Israel</seealso>
    let Israel = Prefixed_Name(resource, "Israel") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Israelis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Israelis">http://dbpedia.org/resource/Israelis</seealso>
    let Israelis = Prefixed_Name(resource, "Israelis") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Italian_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Italian_nationalism">http://dbpedia.org/resource/Italian_nationalism</seealso>
    let Italian_nationalism =
        Prefixed_Name(resource, "Italian_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Italian_unification</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Italian_unification">http://dbpedia.org/resource/Italian_unification</seealso>
    let Italian_unification =
        Prefixed_Name(resource, "Italian_unification") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Italy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Italy">http://dbpedia.org/resource/Italy</seealso>
    let Italy = Prefixed_Name(resource, "Italy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ivory_Coast</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ivory_Coast">http://dbpedia.org/resource/Ivory_Coast</seealso>
    let Ivory_Coast = Prefixed_Name(resource, "Ivory_Coast") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jacobin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jacobin">http://dbpedia.org/resource/Jacobin</seealso>
    let Jacobin = Prefixed_Name(resource, "Jacobin") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Jacobin_(politics)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jacobin_(politics)">http://dbpedia.org/resource/Jacobin_(politics)</seealso>
    let ``Jacobin_(politics)`` =
        Prefixed_Name(resource, "Jacobin_(politics)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Jacobitism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jacobitism">http://dbpedia.org/resource/Jacobitism</seealso>
    let Jacobitism = Prefixed_Name(resource, "Jacobitism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jamaica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Jamaica">http://dbpedia.org/resource/Jamaica</seealso>
    let Jamaica = Prefixed_Name(resource, "Jamaica") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jamaicans</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jamaicans">http://dbpedia.org/resource/Jamaicans</seealso>
    let Jamaicans = Prefixed_Name(resource, "Jamaicans") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jansenism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jansenism">http://dbpedia.org/resource/Jansenism</seealso>
    let Jansenism = Prefixed_Name(resource, "Jansenism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Japan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Japan">http://dbpedia.org/resource/Japan</seealso>
    let Japan = Prefixed_Name(resource, "Japan") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Jewish_emancipation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jewish_emancipation">http://dbpedia.org/resource/Jewish_emancipation</seealso>
    let Jewish_emancipation =
        Prefixed_Name(resource, "Jewish_emancipation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Jewish_identity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jewish_identity">http://dbpedia.org/resource/Jewish_identity</seealso>
    let Jewish_identity = Prefixed_Name(resource, "Jewish_identity") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jews</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jews">http://dbpedia.org/resource/Jews</seealso>
    let Jews = Prefixed_Name(resource, "Jews") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jinro</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jinro">http://dbpedia.org/resource/Jinro</seealso>
    let Jinro = Prefixed_Name(resource, "Jinro") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/John_Wilkes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/John_Wilkes">http://dbpedia.org/resource/John_Wilkes</seealso>
    let John_Wilkes = Prefixed_Name(resource, "John_Wilkes") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jordan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Jordan">http://dbpedia.org/resource/Jordan</seealso>
    let Jordan = Prefixed_Name(resource, "Jordan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Judaism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Judaism">http://dbpedia.org/resource/Judaism</seealso>
    let Judaism = Prefixed_Name(resource, "Judaism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jungsa</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jungsa">http://dbpedia.org/resource/Jungsa</seealso>
    let Jungsa = Prefixed_Name(resource, "Jungsa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Jungwi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Jungwi">http://dbpedia.org/resource/Jungwi</seealso>
    let Jungwi = Prefixed_Name(resource, "Jungwi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Junior_sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Junior_sergeant">http://dbpedia.org/resource/Junior_sergeant</seealso>
    let Junior_sergeant = Prefixed_Name(resource, "Junior_sergeant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Junjang</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Junjang">http://dbpedia.org/resource/Junjang</seealso>
    let Junjang = Prefixed_Name(resource, "Junjang") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kapudan_Pasha</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kapudan_Pasha">http://dbpedia.org/resource/Kapudan_Pasha</seealso>
    let Kapudan_Pasha = Prefixed_Name(resource, "Kapudan_Pasha") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Katholieke_Universiteit_Leuven</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Katholieke_Universiteit_Leuven">http://dbpedia.org/resource/Katholieke_Universiteit_Leuven</seealso>
    let Katholieke_Universiteit_Leuven =
        Prefixed_Name(resource, "Katholieke_Universiteit_Leuven") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kayak</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kayak">http://dbpedia.org/resource/Kayak</seealso>
    let Kayak = Prefixed_Name(resource, "Kayak") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kazakhstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kazakhstan">http://dbpedia.org/resource/Kazakhstan</seealso>
    let Kazakhstan = Prefixed_Name(resource, "Kazakhstan") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Keihin_Corporation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"The Keihin Corporation (株式会社ケーヒン, Kabushiki-gaisha Keihin) was founded December 19, 1956, and maintains its head office in Shinjuku Ward, Tokyo, Japan. It produces carburetors and fuel injection, and is a major supplier to Honda."</para>
    /// labels<para>"Keihin Corporation"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Keihin_Corporation">http://dbpedia.org/resource/Keihin_Corporation</seealso>
    let Keihin_Corporation =
        Prefixed_Name(resource, "Keihin_Corporation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kenya</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kenya">http://dbpedia.org/resource/Kenya</seealso>
    let Kenya = Prefixed_Name(resource, "Kenya") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kilkenny</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kilkenny">http://dbpedia.org/resource/Kilkenny</seealso>
    let Kilkenny = Prefixed_Name(resource, "Kilkenny") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kilkenny_(beer)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kilkenny_(beer)">http://dbpedia.org/resource/Kilkenny_(beer)</seealso>
    let ``Kilkenny_(beer)`` = Prefixed_Name(resource, "Kilkenny_(beer)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kindral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kindral">http://dbpedia.org/resource/Kindral</seealso>
    let Kindral = Prefixed_Name(resource, "Kindral") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kingdom_of_Denmark</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kingdom_of_Denmark">http://dbpedia.org/resource/Kingdom_of_Denmark</seealso>
    let Kingdom_of_Denmark =
        Prefixed_Name(resource, "Kingdom_of_Denmark") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kinsey_scale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kinsey_scale">http://dbpedia.org/resource/Kinsey_scale</seealso>
    let Kinsey_scale = Prefixed_Name(resource, "Kinsey_scale") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kiribati</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kiribati">http://dbpedia.org/resource/Kiribati</seealso>
    let Kiribati = Prefixed_Name(resource, "Kiribati") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Knitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Knitting">http://dbpedia.org/resource/Knitting</seealso>
    let Knitting = Prefixed_Name(resource, "Knitting") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kola%C4%9Fas%C4%B1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kola%C4%9Fas%C4%B1">http://dbpedia.org/resource/Kola%C4%9Fas%C4%B1</seealso>
    let ``Kola%C4%9Fas%C4%B1`` =
        Prefixed_Name(resource, "Kola%C4%9Fas%C4%B1") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Kolonel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Kolonel">http://dbpedia.org/resource/Kolonel</seealso>
    let Kolonel = Prefixed_Name(resource, "Kolonel") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kosovo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kosovo">http://dbpedia.org/resource/Kosovo</seealso>
    let Kosovo = Prefixed_Name(resource, "Kosovo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kuwait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kuwait">http://dbpedia.org/resource/Kuwait</seealso>
    let Kuwait = Prefixed_Name(resource, "Kuwait") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Kyrgyzstan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Kyrgyzstan">http://dbpedia.org/resource/Kyrgyzstan</seealso>
    let Kyrgyzstan = Prefixed_Name(resource, "Kyrgyzstan") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/LGBT_social_movements</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/LGBT_social_movements">http://dbpedia.org/resource/LGBT_social_movements</seealso>
    let LGBT_social_movements =
        Prefixed_Name(resource, "LGBT_social_movements") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Labour_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Labour_movement">http://dbpedia.org/resource/Labour_movement</seealso>
    let Labour_movement = Prefixed_Name(resource, "Labour_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lady_Literate_in_Arts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lady_Literate_in_Arts">http://dbpedia.org/resource/Lady_Literate_in_Arts</seealso>
    let Lady_Literate_in_Arts =
        Prefixed_Name(resource, "Lady_Literate_in_Arts") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lance-corporal_of_horse</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lance-corporal_of_horse">http://dbpedia.org/resource/Lance-corporal_of_horse</seealso>
    let Lance_corporal_of_horse =
        Prefixed_Name(resource, "Lance-corporal_of_horse") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lance_corporal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lance_corporal">http://dbpedia.org/resource/Lance_corporal</seealso>
    let Lance_corporal = Prefixed_Name(resource, "Lance_corporal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lance_sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lance_sergeant">http://dbpedia.org/resource/Lance_sergeant</seealso>
    let Lance_sergeant = Prefixed_Name(resource, "Lance_sergeant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Land_reform</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Land_reform">http://dbpedia.org/resource/Land_reform</seealso>
    let Land_reform = Prefixed_Name(resource, "Land_reform") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Land_surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Land_surface">http://dbpedia.org/resource/Land_surface</seealso>
    let Land_surface = Prefixed_Name(resource, "Land_surface") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Language</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Language">http://dbpedia.org/resource/Language</seealso>
    let Language = Prefixed_Name(resource, "Language") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Laos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Laos">http://dbpedia.org/resource/Laos</seealso>
    let Laos = Prefixed_Name(resource, "Laos") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Latin_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Latin_America">http://dbpedia.org/resource/Latin_America</seealso>
    let Latin_America = Prefixed_Name(resource, "Latin_America") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Latitudinarian</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Latitudinarian">http://dbpedia.org/resource/Latitudinarian</seealso>
    let Latitudinarian = Prefixed_Name(resource, "Latitudinarian") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Latvia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Latvia">http://dbpedia.org/resource/Latvia</seealso>
    let Latvia = Prefixed_Name(resource, "Latvia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Law_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Law_degree">http://dbpedia.org/resource/Law_degree</seealso>
    let Law_degree = Prefixed_Name(resource, "Law_degree") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lawyer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Lawyer">http://dbpedia.org/resource/Lawyer</seealso>
    let Lawyer = Prefixed_Name(resource, "Lawyer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Leading_aircraftman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Leading_aircraftman">http://dbpedia.org/resource/Leading_aircraftman</seealso>
    let Leading_aircraftman =
        Prefixed_Name(resource, "Leading_aircraftman") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Leading_seaman</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Leading_seaman">http://dbpedia.org/resource/Leading_seaman</seealso>
    let Leading_seaman = Prefixed_Name(resource, "Leading_seaman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lebanon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Lebanon">http://dbpedia.org/resource/Lebanon</seealso>
    let Lebanon = Prefixed_Name(resource, "Lebanon") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Left-wing_politics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Left-wing_politics">http://dbpedia.org/resource/Left-wing_politics</seealso>
    let Left_wing_politics =
        Prefixed_Name(resource, "Left-wing_politics") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lesbian_feminism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lesbian_feminism">http://dbpedia.org/resource/Lesbian_feminism</seealso>
    let Lesbian_feminism = Prefixed_Name(resource, "Lesbian_feminism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lesotho</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Lesotho">http://dbpedia.org/resource/Lesotho</seealso>
    let Lesotho = Prefixed_Name(resource, "Lesotho") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Liaison_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Liaison_officer">http://dbpedia.org/resource/Liaison_officer</seealso>
    let Liaison_officer = Prefixed_Name(resource, "Liaison_officer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Liberal_Unionist_Party</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Liberal_Unionist_Party">http://dbpedia.org/resource/Liberal_Unionist_Party</seealso>
    let Liberal_Unionist_Party =
        Prefixed_Name(resource, "Liberal_Unionist_Party") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Liberalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Liberalism">http://dbpedia.org/resource/Liberalism</seealso>
    let Liberalism = Prefixed_Name(resource, "Liberalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Liberia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Liberia">http://dbpedia.org/resource/Liberia</seealso>
    let Liberia = Prefixed_Name(resource, "Liberia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Libertarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Libertarianism">http://dbpedia.org/resource/Libertarianism</seealso>
    let Libertarianism = Prefixed_Name(resource, "Libertarianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Libya</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Libya">http://dbpedia.org/resource/Libya</seealso>
    let Libya = Prefixed_Name(resource, "Libya") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Liechtenstein</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Liechtenstein">http://dbpedia.org/resource/Liechtenstein</seealso>
    let Liechtenstein = Prefixed_Name(resource, "Liechtenstein") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lieutenant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Lieutenant">http://dbpedia.org/resource/Lieutenant</seealso>
    let Lieutenant = Prefixed_Name(resource, "Lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lieutenant_(navy)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lieutenant_(navy)">http://dbpedia.org/resource/Lieutenant_(navy)</seealso>
    let ``Lieutenant_(navy)`` =
        Prefixed_Name(resource, "Lieutenant_(navy)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lieutenant_colonel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lieutenant_colonel">http://dbpedia.org/resource/Lieutenant_colonel</seealso>
    let Lieutenant_colonel =
        Prefixed_Name(resource, "Lieutenant_colonel") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lieutenant_commander</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lieutenant_commander">http://dbpedia.org/resource/Lieutenant_commander</seealso>
    let Lieutenant_commander =
        Prefixed_Name(resource, "Lieutenant_commander") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ligurian_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ligurian_Sea">http://dbpedia.org/resource/Ligurian_Sea</seealso>
    let Ligurian_Sea = Prefixed_Name(resource, "Ligurian_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Linde_plc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"Linde plc is a global multinational chemical company founded in Germany and, since 2018, domiciled in Ireland and headquartered in the United Kingdom. Linde is the world's largest industrial gas company by market share and revenue. It serves customers in the healthcare, petroleum refining, manufacturing, food, beverage carbonation, fiber-optics, steel making, aerospace, chemicals, electronics and water treatment industries. The company's primary business is the manufacturing and distribution of atmospheric gases, including oxygen, nitrogen, argon, rare gases, and process gases, including carbon dioxide, helium, hydrogen, ammonia, electronic gases, specialty gases, and acetylene."</para>
    /// labels<para>"Linde plc"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Linde_plc">http://dbpedia.org/resource/Linde_plc</seealso>
    let Linde_plc = Prefixed_Name(resource, "Linde_plc") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/List_of_ethnic_groups_of_Africa</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/List_of_ethnic_groups_of_Africa">http://dbpedia.org/resource/List_of_ethnic_groups_of_Africa</seealso>
    let List_of_ethnic_groups_of_Africa =
        Prefixed_Name(resource, "List_of_ethnic_groups_of_Africa") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/List_of_fuel_cell_manufacturers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///   <para>"A fuel cell is an electrochemical energy conversion device. Fuel cells differ from batteries in that they are designed for continuous replenishment of the reactants consumed. This is a partial list of companies currently producing commercially available fuel cell systems for use in residential, commercial, or industrial settings. Fuel cell systems from these manufacturers are currently being used to generate AC or DC electricity, heat, water, or any combination of the three."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/List_of_fuel_cell_manufacturers">http://dbpedia.org/resource/List_of_fuel_cell_manufacturers</seealso>
    let List_of_fuel_cell_manufacturers =
        Prefixed_Name(resource, "List_of_fuel_cell_manufacturers") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/List_of_fuel_cell_vehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:RoadApplication</para>
    ///   <para>"A fuel cell vehicle is a vehicle that uses a fuel cell to power an electric drive system. There are also hybrid vehicles meaning that they are fitted with a fuel cell and a battery or a fuel cell and an ultracapacitor. For HICEV see List of hydrogen internal combustion engine vehicles. For a discussion of the advantages and disadvantages of fuel cell vehicles, see fuel cell vehicle."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/List_of_fuel_cell_vehicles">http://dbpedia.org/resource/List_of_fuel_cell_vehicles</seealso>
    let List_of_fuel_cell_vehicles =
        Prefixed_Name(resource, "List_of_fuel_cell_vehicles") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lithuania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Lithuania">http://dbpedia.org/resource/Lithuania</seealso>
    let Lithuania = Prefixed_Name(resource, "Lithuania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Lochagos</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lochagos">http://dbpedia.org/resource/Lochagos</seealso>
    let Lochagos = Prefixed_Name(resource, "Lochagos") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Log-distance_path_loss_model</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Log-distance_path_loss_model">http://dbpedia.org/resource/Log-distance_path_loss_model</seealso>
    let Log_distance_path_loss_model =
        Prefixed_Name(resource, "Log-distance_path_loss_model") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lollardy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lollardy">http://dbpedia.org/resource/Lollardy</seealso>
    let Lollardy = Prefixed_Name(resource, "Lollardy") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Lord_High_Admiral_of_the_Wash</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Lord_High_Admiral_of_the_Wash">http://dbpedia.org/resource/Lord_High_Admiral_of_the_Wash</seealso>
    let Lord_High_Admiral_of_the_Wash =
        Prefixed_Name(resource, "Lord_High_Admiral_of_the_Wash") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Loschmidt_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Loschmidt_constant">http://dbpedia.org/resource/Loschmidt_constant</seealso>
    let Loschmidt_constant =
        Prefixed_Name(resource, "Loschmidt_constant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Luxembourg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Luxembourg">http://dbpedia.org/resource/Luxembourg</seealso>
    let Luxembourg = Prefixed_Name(resource, "Luxembourg") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/M%C3%BC%C5%9Fir</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/M%C3%BC%C5%9Fir">http://dbpedia.org/resource/M%C3%BC%C5%9Fir</seealso>
    let ``M%C3%BC%C5%9Fir`` = Prefixed_Name(resource, "M%C3%BC%C5%9Fir") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Macedonia_%28ancient_kingdom%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Macedonia_%28ancient_kingdom%29">http://dbpedia.org/resource/Macedonia_%28ancient_kingdom%29</seealso>
    let ``Macedonia_%28ancient_kingdom%29`` =
        Prefixed_Name(resource, "Macedonia_%28ancient_kingdom%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mach_number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mach_number">http://dbpedia.org/resource/Mach_number</seealso>
    let Mach_number = Prefixed_Name(resource, "Mach_number") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Madagascar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Madagascar">http://dbpedia.org/resource/Madagascar</seealso>
    let Madagascar = Prefixed_Name(resource, "Madagascar") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Magnetic_flux_quantum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Magnetic_flux_quantum">http://dbpedia.org/resource/Magnetic_flux_quantum</seealso>
    let Magnetic_flux_quantum =
        Prefixed_Name(resource, "Magnetic_flux_quantum") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Magnetic_moment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Magnetic_moment">http://dbpedia.org/resource/Magnetic_moment</seealso>
    let Magnetic_moment = Prefixed_Name(resource, "Magnetic_moment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mainland_Southeast_Asia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:GeographicMarket</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mainland_Southeast_Asia">http://dbpedia.org/resource/Mainland_Southeast_Asia</seealso>
    let Mainland_Southeast_Asia =
        Prefixed_Name(resource, "Mainland_Southeast_Asia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Maintenance,_repair,_and_operations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Maintenance,_repair,_and_operations">http://dbpedia.org/resource/Maintenance,_repair,_and_operations</seealso>
    let ``Maintenance,_repair,_and_operations`` =
        Prefixed_Name(resource, "Maintenance,_repair,_and_operations") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Major</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Major">http://dbpedia.org/resource/Major</seealso>
    let Major = Prefixed_Name(resource, "Major") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Major_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Major_chord">http://dbpedia.org/resource/Major_chord</seealso>
    let Major_chord = Prefixed_Name(resource, "Major_chord") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Major_general</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Major_general">http://dbpedia.org/resource/Major_general</seealso>
    let Major_general = Prefixed_Name(resource, "Major_general") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Major_seventh_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Major_seventh_chord">http://dbpedia.org/resource/Major_seventh_chord</seealso>
    let Major_seventh_chord =
        Prefixed_Name(resource, "Major_seventh_chord") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Malawi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Malawi">http://dbpedia.org/resource/Malawi</seealso>
    let Malawi = Prefixed_Name(resource, "Malawi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Malaysia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Malaysia">http://dbpedia.org/resource/Malaysia</seealso>
    let Malaysia = Prefixed_Name(resource, "Malaysia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Maldives</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Maldives">http://dbpedia.org/resource/Maldives</seealso>
    let Maldives = Prefixed_Name(resource, "Maldives") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mali</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mali">http://dbpedia.org/resource/Mali</seealso>
    let Mali = Prefixed_Name(resource, "Mali") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Malta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Malta">http://dbpedia.org/resource/Malta</seealso>
    let Malta = Prefixed_Name(resource, "Malta") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Malthusianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Malthusianism">http://dbpedia.org/resource/Malthusianism</seealso>
    let Malthusianism = Prefixed_Name(resource, "Malthusianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Maoism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Maoism">http://dbpedia.org/resource/Maoism</seealso>
    let Maoism = Prefixed_Name(resource, "Maoism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Marmara_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Marmara_Sea">http://dbpedia.org/resource/Marmara_Sea</seealso>
    let Marmara_Sea = Prefixed_Name(resource, "Marmara_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Marshal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Marshal">http://dbpedia.org/resource/Marshal</seealso>
    let Marshal = Prefixed_Name(resource, "Marshal") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Marshal_of_the_Soviet_Union</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Marshal_of_the_Soviet_Union">http://dbpedia.org/resource/Marshal_of_the_Soviet_Union</seealso>
    let Marshal_of_the_Soviet_Union =
        Prefixed_Name(resource, "Marshal_of_the_Soviet_Union") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Marshal_of_the_air_force</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Marshal_of_the_air_force">http://dbpedia.org/resource/Marshal_of_the_air_force</seealso>
    let Marshal_of_the_air_force =
        Prefixed_Name(resource, "Marshal_of_the_air_force") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Marshall_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Marshall_Islands">http://dbpedia.org/resource/Marshall_Islands</seealso>
    let Marshall_Islands = Prefixed_Name(resource, "Marshall_Islands") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Martin-Schultz_scale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Martin-Schultz_scale">http://dbpedia.org/resource/Martin-Schultz_scale</seealso>
    let Martin_Schultz_scale =
        Prefixed_Name(resource, "Martin-Schultz_scale") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Marxism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Marxism">http://dbpedia.org/resource/Marxism</seealso>
    let Marxism = Prefixed_Name(resource, "Marxism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mass%E2%80%93energy_equivalence</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mass%E2%80%93energy_equivalence">http://dbpedia.org/resource/Mass%E2%80%93energy_equivalence</seealso>
    let ``Mass%E2%80%93energy_equivalence`` =
        Prefixed_Name(resource, "Mass%E2%80%93energy_equivalence") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mass-to-charge_ratio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mass-to-charge_ratio">http://dbpedia.org/resource/Mass-to-charge_ratio</seealso>
    let Mass_to_charge_ratio =
        Prefixed_Name(resource, "Mass-to-charge_ratio") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Master%27s_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Master%27s_degree">http://dbpedia.org/resource/Master%27s_degree</seealso>
    let ``Master%27s_degree`` =
        Prefixed_Name(resource, "Master%27s_degree") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Master_warrant_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Master_warrant_officer">http://dbpedia.org/resource/Master_warrant_officer</seealso>
    let Master_warrant_officer =
        Prefixed_Name(resource, "Master_warrant_officer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mauritania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mauritania">http://dbpedia.org/resource/Mauritania</seealso>
    let Mauritania = Prefixed_Name(resource, "Mauritania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mauritius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mauritius">http://dbpedia.org/resource/Mauritius</seealso>
    let Mauritius = Prefixed_Name(resource, "Mauritius") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Max</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Max">http://dbpedia.org/resource/Max</seealso>
    let Max = Prefixed_Name(resource, "Max") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mayotte</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mayotte">http://dbpedia.org/resource/Mayotte</seealso>
    let Mayotte = Prefixed_Name(resource, "Mayotte") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Medical_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Medical_degree">http://dbpedia.org/resource/Medical_degree</seealso>
    let Medical_degree = Prefixed_Name(resource, "Medical_degree") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mental_disorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mental_disorder">http://dbpedia.org/resource/Mental_disorder</seealso>
    let Mental_disorder = Prefixed_Name(resource, "Mental_disorder") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mercedes-Benz_Cito</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Bus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Mercedes-Benz Cito (coded as O520) was a low-floor midibus built by EvoBus for Continental Europe between 1999 and 2003. Unusual for buses at that time, it had a diesel-electric transmission and was planned to have a hybrid engine or a fuel cell at a later stage. The Diesel engine was positioned above the rear axle.It is planned to build a fuel cell type By The next few years."</para>
    /// labels<para>"Mercedes-Benz Cito"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mercedes-Benz_Cito">http://dbpedia.org/resource/Mercedes-Benz_Cito</seealso>
    let Mercedes_Benz_Cito =
        Prefixed_Name(resource, "Mercedes-Benz_Cito") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Merchant_navy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Merchant_navy">http://dbpedia.org/resource/Merchant_navy</seealso>
    let Merchant_navy = Prefixed_Name(resource, "Merchant_navy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Meteorology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Meteorology">http://dbpedia.org/resource/Meteorology</seealso>
    let Meteorology = Prefixed_Name(resource, "Meteorology") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Meteorology_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Meteorological properties"</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Meteorology_Property">http://dbpedia.org/resource/Meteorology_Property</seealso>
    let Meteorology_Property =
        Prefixed_Name(resource, "Meteorology_Property") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Methodist_Episcopal_Church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Methodist_Episcopal_Church">http://dbpedia.org/resource/Methodist_Episcopal_Church</seealso>
    let Methodist_Episcopal_Church =
        Prefixed_Name(resource, "Methodist_Episcopal_Church") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Metre</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Metre">http://dbpedia.org/resource/Metre</seealso>
    let Metre = Prefixed_Name(resource, "Metre") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mexico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mexico">http://dbpedia.org/resource/Mexico</seealso>
    let Mexico = Prefixed_Name(resource, "Mexico") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Microbial_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:SubstituteProduct</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Microbial_fuel_cell">http://dbpedia.org/resource/Microbial_fuel_cell</seealso>
    let Microbial_fuel_cell =
        Prefixed_Name(resource, "Microbial_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Middle_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Middle_class">http://dbpedia.org/resource/Middle_class</seealso>
    let Middle_class = Prefixed_Name(resource, "Middle_class") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Midshipman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Midshipman">http://dbpedia.org/resource/Midshipman</seealso>
    let Midshipman = Prefixed_Name(resource, "Midshipman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Militarism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Militarism">http://dbpedia.org/resource/Militarism</seealso>
    let Militarism = Prefixed_Name(resource, "Militarism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/MilitaryUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/MilitaryUnit">http://dbpedia.org/resource/MilitaryUnit</seealso>
    let MilitaryUnit = Prefixed_Name(resource, "MilitaryUnit") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Military_branch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Military_branch">http://dbpedia.org/resource/Military_branch</seealso>
    let Military_branch = Prefixed_Name(resource, "Military_branch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Military_campaign</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Military_campaign">http://dbpedia.org/resource/Military_campaign</seealso>
    let Military_campaign = Prefixed_Name(resource, "Military_campaign") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Military_operation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Military_operation">http://dbpedia.org/resource/Military_operation</seealso>
    let Military_operation =
        Prefixed_Name(resource, "Military_operation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Milk_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Milk_allergy">http://dbpedia.org/resource/Milk_allergy</seealso>
    let Milk_allergy = Prefixed_Name(resource, "Milk_allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Millenarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Millenarianism">http://dbpedia.org/resource/Millenarianism</seealso>
    let Millenarianism = Prefixed_Name(resource, "Millenarianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Min</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Min">http://dbpedia.org/resource/Min</seealso>
    let Min = Prefixed_Name(resource, "Min") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Minor_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Minor_chord">http://dbpedia.org/resource/Minor_chord</seealso>
    let Minor_chord = Prefixed_Name(resource, "Minor_chord") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Minor_major_seventh_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Minor_major_seventh_chord">http://dbpedia.org/resource/Minor_major_seventh_chord</seealso>
    let Minor_major_seventh_chord =
        Prefixed_Name(resource, "Minor_major_seventh_chord") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Minor_seventh_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Minor_seventh_chord">http://dbpedia.org/resource/Minor_seventh_chord</seealso>
    let Minor_seventh_chord =
        Prefixed_Name(resource, "Minor_seventh_chord") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mirliva</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mirliva">http://dbpedia.org/resource/Mirliva</seealso>
    let Mirliva = Prefixed_Name(resource, "Mirliva") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Mixed-sex_education</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mixed-sex_education">http://dbpedia.org/resource/Mixed-sex_education</seealso>
    let Mixed_sex_education =
        Prefixed_Name(resource, "Mixed-sex_education") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Module</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Module">http://dbpedia.org/resource/Module</seealso>
    let Module = Prefixed_Name(resource, "Module") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mohawk</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mohawk">http://dbpedia.org/resource/Mohawk</seealso>
    let Mohawk = Prefixed_Name(resource, "Mohawk") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mohawk_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mohawk_people">http://dbpedia.org/resource/Mohawk_people</seealso>
    let Mohawk_people = Prefixed_Name(resource, "Mohawk_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Moldova</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Moldova">http://dbpedia.org/resource/Moldova</seealso>
    let Moldova = Prefixed_Name(resource, "Moldova") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Monaco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Monaco">http://dbpedia.org/resource/Monaco</seealso>
    let Monaco = Prefixed_Name(resource, "Monaco") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Monarchism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Monarchism">http://dbpedia.org/resource/Monarchism</seealso>
    let Monarchism = Prefixed_Name(resource, "Monarchism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mondeca</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mondeca">http://dbpedia.org/resource/Mondeca</seealso>
    let Mondeca = Prefixed_Name(resource, "Mondeca") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mongolia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mongolia">http://dbpedia.org/resource/Mongolia</seealso>
    let Mongolia = Prefixed_Name(resource, "Mongolia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Monism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Monism">http://dbpedia.org/resource/Monism</seealso>
    let Monism = Prefixed_Name(resource, "Monism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Montenegro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Montenegro">http://dbpedia.org/resource/Montenegro</seealso>
    let Montenegro = Prefixed_Name(resource, "Montenegro") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Moravian_Church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Moravian_Church">http://dbpedia.org/resource/Moravian_Church</seealso>
    let Moravian_Church = Prefixed_Name(resource, "Moravian_Church") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Morocco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Morocco">http://dbpedia.org/resource/Morocco</seealso>
    let Morocco = Prefixed_Name(resource, "Morocco") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Motor_vehicle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Motor_vehicle">http://dbpedia.org/resource/Motor_vehicle</seealso>
    let Motor_vehicle = Prefixed_Name(resource, "Motor_vehicle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Motorboat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Motorboat">http://dbpedia.org/resource/Motorboat</seealso>
    let Motorboat = Prefixed_Name(resource, "Motorboat") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Motorcycle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Motorcycle">http://dbpedia.org/resource/Motorcycle</seealso>
    let Motorcycle = Prefixed_Name(resource, "Motorcycle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Motorized_bicycle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Motorized_bicycle">http://dbpedia.org/resource/Motorized_bicycle</seealso>
    let Motorized_bicycle = Prefixed_Name(resource, "Motorized_bicycle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mozambique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Mozambique">http://dbpedia.org/resource/Mozambique</seealso>
    let Mozambique = Prefixed_Name(resource, "Mozambique") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Multiculturalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Multiculturalism">http://dbpedia.org/resource/Multiculturalism</seealso>
    let Multiculturalism = Prefixed_Name(resource, "Multiculturalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Multiracial</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Multiracial">http://dbpedia.org/resource/Multiracial</seealso>
    let Multiracial = Prefixed_Name(resource, "Multiracial") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Multiracialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Multiracialism">http://dbpedia.org/resource/Multiracialism</seealso>
    let Multiracialism = Prefixed_Name(resource, "Multiracialism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Musical_performance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Musical_performance">http://dbpedia.org/resource/Musical_performance</seealso>
    let Musical_performance =
        Prefixed_Name(resource, "Musical_performance") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Myanmar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Myanmar">http://dbpedia.org/resource/Myanmar</seealso>
    let Myanmar = Prefixed_Name(resource, "Myanmar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Mysticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Mysticism">http://dbpedia.org/resource/Mysticism</seealso>
    let Mysticism = Prefixed_Name(resource, "Mysticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Namibia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Namibia">http://dbpedia.org/resource/Namibia</seealso>
    let Namibia = Prefixed_Name(resource, "Namibia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/National_Archives_of_Australia</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/National_Archives_of_Australia">http://dbpedia.org/resource/National_Archives_of_Australia</seealso>
    let National_Archives_of_Australia =
        Prefixed_Name(resource, "National_Archives_of_Australia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/National_Institute_for_Research_in_Computer_Science_and_Control</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/National_Institute_for_Research_in_Computer_Science_and_Control">http://dbpedia.org/resource/National_Institute_for_Research_in_Computer_Science_and_Control</seealso>
    let National_Institute_for_Research_in_Computer_Science_and_Control =
        Prefixed_Name(resource, "National_Institute_for_Research_in_Computer_Science_and_Control") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nationalism">http://dbpedia.org/resource/Nationalism</seealso>
    let Nationalism = Prefixed_Name(resource, "Nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Natural_gas_vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:RoadApplication</para>
    ///   <para>"A natural gas vehicle (NGV) is an alternative fuel vehicle that uses compressed natural gas (CNG) or liquefied natural gas (LNG). Natural gas vehicles should not be confused with autogas vehicles powered by liquefied petroleum gas (LPG), mainly propane, a fuel with a fundamentally different composition. Worldwide, there were almost 28 million NGVs by 2019. In 2016, the market was led by China (5.4 million), Iran (4 million), India (3 million), Pakistan (3 million), Argentina (2.2 million), Brazil (1.8 million), and Italy (1.1 million)."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Natural_gas_vehicle">http://dbpedia.org/resource/Natural_gas_vehicle</seealso>
    let Natural_gas_vehicle =
        Prefixed_Name(resource, "Natural_gas_vehicle") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Natural_religion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Natural_religion">http://dbpedia.org/resource/Natural_religion</seealso>
    let Natural_religion = Prefixed_Name(resource, "Natural_religion") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Natural_units</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Natural_units">http://dbpedia.org/resource/Natural_units</seealso>
    let Natural_units = Prefixed_Name(resource, "Natural_units") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nauru</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Nauru">http://dbpedia.org/resource/Nauru</seealso>
    let Nauru = Prefixed_Name(resource, "Nauru") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Naval_fleet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Naval_fleet">http://dbpedia.org/resource/Naval_fleet</seealso>
    let Naval_fleet = Prefixed_Name(resource, "Naval_fleet") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Navarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Navarch">http://dbpedia.org/resource/Navarch</seealso>
    let Navarch = Prefixed_Name(resource, "Navarch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Navy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Navy">http://dbpedia.org/resource/Navy</seealso>
    let Navy = Prefixed_Name(resource, "Navy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nazism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nazism">http://dbpedia.org/resource/Nazism</seealso>
    let Nazism = Prefixed_Name(resource, "Nazism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Neo-Scholasticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Neo-Scholasticism">http://dbpedia.org/resource/Neo-Scholasticism</seealso>
    let Neo_Scholasticism = Prefixed_Name(resource, "Neo-Scholasticism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Neoconservatism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Neoconservatism">http://dbpedia.org/resource/Neoconservatism</seealso>
    let Neoconservatism = Prefixed_Name(resource, "Neoconservatism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nepal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Nepal">http://dbpedia.org/resource/Nepal</seealso>
    let Nepal = Prefixed_Name(resource, "Nepal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Netherlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Netherlands">http://dbpedia.org/resource/Netherlands</seealso>
    let Netherlands = Prefixed_Name(resource, "Netherlands") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Neutron</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Neutron">http://dbpedia.org/resource/Neutron</seealso>
    let Neutron = Prefixed_Name(resource, "Neutron") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Neutron_magnetic_moment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Neutron_magnetic_moment">http://dbpedia.org/resource/Neutron_magnetic_moment</seealso>
    let Neutron_magnetic_moment =
        Prefixed_Name(resource, "Neutron_magnetic_moment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/New_Deal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Deal">http://dbpedia.org/resource/New_Deal</seealso>
    let New_Deal = Prefixed_Name(resource, "New_Deal") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/New_Hebrides_Trench</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Hebrides_Trench">http://dbpedia.org/resource/New_Hebrides_Trench</seealso>
    let New_Hebrides_Trench =
        Prefixed_Name(resource, "New_Hebrides_Trench") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/New_Sunshine_Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>schema1:ResearchProject</para>
    ///   <para>"The New Sunshine Project (NSS) is a Japanese project to develop the technologies for new energy and global environment, integrating the Sunshine, the Moonlight (Energy-saving technology R &amp; D) and the Global Environment Technology Projects since 1993. It is the successor of the 1974 MITI Sunshine Project, and focuses on the development of photovoltaic, geothermal and hydrogen technology."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Sunshine_Project">http://dbpedia.org/resource/New_Sunshine_Project</seealso>
    let New_Sunshine_Project =
        Prefixed_Name(resource, "New_Sunshine_Project") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/New_Thought</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Thought">http://dbpedia.org/resource/New_Thought</seealso>
    let New_Thought = Prefixed_Name(resource, "New_Thought") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/New_Unionism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Unionism">http://dbpedia.org/resource/New_Unionism</seealso>
    let New_Unionism = Prefixed_Name(resource, "New_Unionism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/New_Zealand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/New_Zealand">http://dbpedia.org/resource/New_Zealand</seealso>
    let New_Zealand = Prefixed_Name(resource, "New_Zealand") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nicaragua</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Nicaragua">http://dbpedia.org/resource/Nicaragua</seealso>
    let Nicaragua = Prefixed_Name(resource, "Nicaragua") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Niger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Niger">http://dbpedia.org/resource/Niger</seealso>
    let Niger = Prefixed_Name(resource, "Niger") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nigeria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Nigeria">http://dbpedia.org/resource/Nigeria</seealso>
    let Nigeria = Prefixed_Name(resource, "Nigeria") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nihilism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nihilism">http://dbpedia.org/resource/Nihilism</seealso>
    let Nihilism = Prefixed_Name(resource, "Nihilism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Niue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Niue">http://dbpedia.org/resource/Niue</seealso>
    let Niue = Prefixed_Name(resource, "Niue") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Non-departmental_public_body</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Non-departmental_public_body">http://dbpedia.org/resource/Non-departmental_public_body</seealso>
    let Non_departmental_public_body =
        Prefixed_Name(resource, "Non-departmental_public_body") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Non-ministerial_government_department</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Non-ministerial_government_department">http://dbpedia.org/resource/Non-ministerial_government_department</seealso>
    let Non_ministerial_government_department =
        Prefixed_Name(resource, "Non-ministerial_government_department") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Nonconformist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nonconformist">http://dbpedia.org/resource/Nonconformist</seealso>
    let Nonconformist = Prefixed_Name(resource, "Nonconformist") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nonjuring_schism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nonjuring_schism">http://dbpedia.org/resource/Nonjuring_schism</seealso>
    let Nonjuring_schism = Prefixed_Name(resource, "Nonjuring_schism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Normans</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Normans">http://dbpedia.org/resource/Normans</seealso>
    let Normans = Prefixed_Name(resource, "Normans") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/North_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/North_America">http://dbpedia.org/resource/North_America</seealso>
    let North_America = Prefixed_Name(resource, "North_America") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/North_Korea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/North_Korea">http://dbpedia.org/resource/North_Korea</seealso>
    let North_Korea = Prefixed_Name(resource, "North_Korea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/North_Macedonia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/North_Macedonia">http://dbpedia.org/resource/North_Macedonia</seealso>
    let North_Macedonia = Prefixed_Name(resource, "North_Macedonia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Norway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Norway">http://dbpedia.org/resource/Norway</seealso>
    let Norway = Prefixed_Name(resource, "Norway") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Norwegian_Sea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Norwegian_Sea">http://dbpedia.org/resource/Norwegian_Sea</seealso>
    let Norwegian_Sea = Prefixed_Name(resource, "Norwegian_Sea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nuclear_magneton</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nuclear_magneton">http://dbpedia.org/resource/Nuclear_magneton</seealso>
    let Nuclear_magneton = Prefixed_Name(resource, "Nuclear_magneton") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Nucleon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Nucleon">http://dbpedia.org/resource/Nucleon</seealso>
    let Nucleon = Prefixed_Name(resource, "Nucleon") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Numbered_Air_Force</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Numbered_Air_Force">http://dbpedia.org/resource/Numbered_Air_Force</seealso>
    let Numbered_Air_Force =
        Prefixed_Name(resource, "Numbered_Air_Force") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Nursing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Nursing">http://dbpedia.org/resource/Nursing</seealso>
    let Nursing = Prefixed_Name(resource, "Nursing") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Oak</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Oak">http://dbpedia.org/resource/Oak</seealso>
    let Oak = Prefixed_Name(resource, "Oak") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Obeah</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Obeah">http://dbpedia.org/resource/Obeah</seealso>
    let Obeah = Prefixed_Name(resource, "Obeah") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Obergefreiter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Obergefreiter">http://dbpedia.org/resource/Obergefreiter</seealso>
    let Obergefreiter = Prefixed_Name(resource, "Obergefreiter") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Oberst</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Oberst">http://dbpedia.org/resource/Oberst</seealso>
    let Oberst = Prefixed_Name(resource, "Oberst") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Oceania</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Oceania (UK: /ˌoʊsiˈɑːniə, ˌoʊʃi-, -ˈeɪn-/, US: /ˌoʊʃiˈæniə/, /-ˈɑːn-/) is a geographic region that includes Australasia, Melanesia, Micronesia and Polynesia. Spanning the Eastern and Western Hemispheres, Oceania has a land area of 8,525,989 square kilometres (3,291,903 sq mi) and a population of over 41 million. When compared with the continents, the region of Oceania is the smallest in land area and the second smallest in population after Antarctica."</para>
    /// labels<para>"Oceania"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Oceania">http://dbpedia.org/resource/Oceania</seealso>
    let Oceania = Prefixed_Name(resource, "Oceania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Officer_cadet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Officer_cadet">http://dbpedia.org/resource/Officer_cadet</seealso>
    let Officer_cadet = Prefixed_Name(resource, "Officer_cadet") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Official_Timocracy_of_Sapinetia</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Official_Timocracy_of_Sapinetia">http://dbpedia.org/resource/Official_Timocracy_of_Sapinetia</seealso>
    let Official_Timocracy_of_Sapinetia =
        Prefixed_Name(resource, "Official_Timocracy_of_Sapinetia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Oman</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Oman">http://dbpedia.org/resource/Oman</seealso>
    let Oman = Prefixed_Name(resource, "Oman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Online_shopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Online_shopping">http://dbpedia.org/resource/Online_shopping</seealso>
    let Online_shopping = Prefixed_Name(resource, "Online_shopping") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Open_Knowledge_Foundation</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Open_Knowledge_Foundation">http://dbpedia.org/resource/Open_Knowledge_Foundation</seealso>
    let Open_Knowledge_Foundation =
        Prefixed_Name(resource, "Open_Knowledge_Foundation") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Opposition_%28politics%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Opposition_%28politics%29">http://dbpedia.org/resource/Opposition_%28politics%29</seealso>
    let ``Opposition_%28politics%29`` =
        Prefixed_Name(resource, "Opposition_%28politics%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Opposition_to_the_English_Poor_Laws</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Opposition_to_the_English_Poor_Laws">http://dbpedia.org/resource/Opposition_to_the_English_Poor_Laws</seealso>
    let Opposition_to_the_English_Poor_Laws =
        Prefixed_Name(resource, "Opposition_to_the_English_Poor_Laws") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Opposition_to_the_Second_Boer_War</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Opposition_to_the_Second_Boer_War">http://dbpedia.org/resource/Opposition_to_the_Second_Boer_War</seealso>
    let Opposition_to_the_Second_Boer_War =
        Prefixed_Name(resource, "Opposition_to_the_Second_Boer_War") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Order_of_Saint_Benedict</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Order_of_Saint_Benedict">http://dbpedia.org/resource/Order_of_Saint_Benedict</seealso>
    let Order_of_Saint_Benedict =
        Prefixed_Name(resource, "Order_of_Saint_Benedict") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ordinary_seaman_%28rating%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ordinary_seaman_%28rating%29">http://dbpedia.org/resource/Ordinary_seaman_%28rating%29</seealso>
    let ``Ordinary_seaman_%28rating%29`` =
        Prefixed_Name(resource, "Ordinary_seaman_%28rating%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Orthophoto</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>"geometrically corrected aerial photograph"</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Orthophoto">http://dbpedia.org/resource/Orthophoto</seealso>
    let Orthophoto = Prefixed_Name(resource, "Orthophoto") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ottoman_Empire</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ottoman_Empire">http://dbpedia.org/resource/Ottoman_Empire</seealso>
    let Ottoman_Empire = Prefixed_Name(resource, "Ottoman_Empire") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Oxford_Movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Oxford_Movement">http://dbpedia.org/resource/Oxford_Movement</seealso>
    let Oxford_Movement = Prefixed_Name(resource, "Oxford_Movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/PLY_(file_format)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/PLY_(file_format)">http://dbpedia.org/resource/PLY_(file_format)</seealso>
    let ``PLY_(file_format)`` =
        Prefixed_Name(resource, "PLY_(file_format)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Pacifism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pacifism">http://dbpedia.org/resource/Pacifism</seealso>
    let Pacifism = Prefixed_Name(resource, "Pacifism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Paganism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Paganism">http://dbpedia.org/resource/Paganism</seealso>
    let Paganism = Prefixed_Name(resource, "Paganism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pakistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Pakistan">http://dbpedia.org/resource/Pakistan</seealso>
    let Pakistan = Prefixed_Name(resource, "Pakistan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Palau</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Palau">http://dbpedia.org/resource/Palau</seealso>
    let Palau = Prefixed_Name(resource, "Palau") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pallet_jack</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:MaterialHandlingVehicle</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A pallet jack, also known as a pallet truck, pallet pump, pump truck, scooter, dog, or jigger is a tool used to lift and move pallets. Pallet jacks are the most basic form of a forklift and are intended to move pallets within a warehouse."</para>
    /// labels<para>"Pallet jack"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pallet_jack">http://dbpedia.org/resource/Pallet_jack</seealso>
    let Pallet_jack = Prefixed_Name(resource, "Pallet_jack") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Panama</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Panama">http://dbpedia.org/resource/Panama</seealso>
    let Panama = Prefixed_Name(resource, "Panama") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pantheism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pantheism">http://dbpedia.org/resource/Pantheism</seealso>
    let Pantheism = Prefixed_Name(resource, "Pantheism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Papua_New_Guinea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Papua_New_Guinea">http://dbpedia.org/resource/Papua_New_Guinea</seealso>
    let Papua_New_Guinea = Prefixed_Name(resource, "Papua_New_Guinea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Paraguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Paraguay">http://dbpedia.org/resource/Paraguay</seealso>
    let Paraguay = Prefixed_Name(resource, "Paraguay") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Parliamentary_system</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Parliamentary_system">http://dbpedia.org/resource/Parliamentary_system</seealso>
    let Parliamentary_system =
        Prefixed_Name(resource, "Parliamentary_system") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Parsi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Parsi">http://dbpedia.org/resource/Parsi</seealso>
    let Parsi = Prefixed_Name(resource, "Parsi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Partnership</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Partnership">http://dbpedia.org/resource/Partnership</seealso>
    let Partnership = Prefixed_Name(resource, "Partnership") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Paternalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Paternalism">http://dbpedia.org/resource/Paternalism</seealso>
    let Paternalism = Prefixed_Name(resource, "Paternalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Patriotism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Patriotism">http://dbpedia.org/resource/Patriotism</seealso>
    let Patriotism = Prefixed_Name(resource, "Patriotism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pentecostalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pentecostalism">http://dbpedia.org/resource/Pentecostalism</seealso>
    let Pentecostalism = Prefixed_Name(resource, "Pentecostalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Personal_Care_Assistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Personal_Care_Assistant">http://dbpedia.org/resource/Personal_Care_Assistant</seealso>
    let Personal_Care_Assistant =
        Prefixed_Name(resource, "Personal_Care_Assistant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Peru</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Peru">http://dbpedia.org/resource/Peru</seealso>
    let Peru = Prefixed_Name(resource, "Peru") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Pet">http://dbpedia.org/resource/Pet</seealso>
    let Pet = Prefixed_Name(resource, "Pet") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Petty_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Petty_officer">http://dbpedia.org/resource/Petty_officer</seealso>
    let Petty_officer = Prefixed_Name(resource, "Petty_officer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Philippines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Philippines">http://dbpedia.org/resource/Philippines</seealso>
    let Philippines = Prefixed_Name(resource, "Philippines") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Philosophical_Radicals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Philosophical_Radicals">http://dbpedia.org/resource/Philosophical_Radicals</seealso>
    let Philosophical_Radicals =
        Prefixed_Name(resource, "Philosophical_Radicals") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Phrourarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Phrourarch">http://dbpedia.org/resource/Phrourarch</seealso>
    let Phrourarch = Prefixed_Name(resource, "Phrourarch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pilot_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pilot_officer">http://dbpedia.org/resource/Pilot_officer</seealso>
    let Pilot_officer = Prefixed_Name(resource, "Pilot_officer") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pipe_Major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pipe_Major">http://dbpedia.org/resource/Pipe_Major</seealso>
    let Pipe_Major = Prefixed_Name(resource, "Pipe_Major") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Place</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Place"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Place">http://dbpedia.org/resource/Place</seealso>
    let Place = Prefixed_Name(resource, "Place") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Planck_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Planck_constant">http://dbpedia.org/resource/Planck_constant</seealso>
    let Planck_constant = Prefixed_Name(resource, "Planck_constant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Planck_mass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Planck_mass">http://dbpedia.org/resource/Planck_mass</seealso>
    let Planck_mass = Prefixed_Name(resource, "Planck_mass") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Plant_disease</para>
    /// </summary>
    /// <remarks>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Spectral indicator of plant disease or pathogen-induced stress."</para>
    /// labels<para>"DiseaseStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Plant_disease">http://dbpedia.org/resource/Plant_disease</seealso>
    let Plant_disease = Prefixed_Name(resource, "Plant_disease") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Platoon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Platoon">http://dbpedia.org/resource/Platoon</seealso>
    let Platoon = Prefixed_Name(resource, "Platoon") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Plug_Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///
    /// labels<para>"Plug Power Inc."</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Plug_Power">http://dbpedia.org/resource/Plug_Power</seealso>
    let Plug_Power = Prefixed_Name(resource, "Plug_Power") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Plumbing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Plumbing">http://dbpedia.org/resource/Plumbing</seealso>
    let Plumbing = Prefixed_Name(resource, "Plumbing") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Plymouth_Brethren</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Plymouth_Brethren">http://dbpedia.org/resource/Plymouth_Brethren</seealso>
    let Plymouth_Brethren = Prefixed_Name(resource, "Plymouth_Brethren") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Podpolkovnik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Podpolkovnik">http://dbpedia.org/resource/Podpolkovnik</seealso>
    let Podpolkovnik = Prefixed_Name(resource, "Podpolkovnik") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Podpraporshchik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Podpraporshchik">http://dbpedia.org/resource/Podpraporshchik</seealso>
    let Podpraporshchik = Prefixed_Name(resource, "Podpraporshchik") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Poland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Poland">http://dbpedia.org/resource/Poland</seealso>
    let Poland = Prefixed_Name(resource, "Poland") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Polemarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Polemarch">http://dbpedia.org/resource/Polemarch</seealso>
    let Polemarch = Prefixed_Name(resource, "Polemarch") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Polish_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Polish_nationalism">http://dbpedia.org/resource/Polish_nationalism</seealso>
    let Polish_nationalism =
        Prefixed_Name(resource, "Polish_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Political_integration_of_India</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Political_integration_of_India">http://dbpedia.org/resource/Political_integration_of_India</seealso>
    let Political_integration_of_India =
        Prefixed_Name(resource, "Political_integration_of_India") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Political_radicalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Political_radicalism">http://dbpedia.org/resource/Political_radicalism</seealso>
    let Political_radicalism =
        Prefixed_Name(resource, "Political_radicalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Polkovnik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Polkovnik">http://dbpedia.org/resource/Polkovnik</seealso>
    let Polkovnik = Prefixed_Name(resource, "Polkovnik") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Polytechnic_University_of_Turin</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Polytechnic_University_of_Turin">http://dbpedia.org/resource/Polytechnic_University_of_Turin</seealso>
    let Polytechnic_University_of_Turin =
        Prefixed_Name(resource, "Polytechnic_University_of_Turin") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Porcupine_Abyssal_Plain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Porcupine_Abyssal_Plain">http://dbpedia.org/resource/Porcupine_Abyssal_Plain</seealso>
    let Porcupine_Abyssal_Plain =
        Prefixed_Name(resource, "Porcupine_Abyssal_Plain") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Portugal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Portugal">http://dbpedia.org/resource/Portugal</seealso>
    let Portugal = Prefixed_Name(resource, "Portugal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Poruchik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Poruchik">http://dbpedia.org/resource/Poruchik</seealso>
    let Poruchik = Prefixed_Name(resource, "Poruchik") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Poverty_reduction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Poverty_reduction">http://dbpedia.org/resource/Poverty_reduction</seealso>
    let Poverty_reduction = Prefixed_Name(resource, "Poverty_reduction") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Praporshchik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Praporshchik">http://dbpedia.org/resource/Praporshchik</seealso>
    let Praporshchik = Prefixed_Name(resource, "Praporshchik") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Precipitation_(meteorology)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Precipitation_(meteorology)">http://dbpedia.org/resource/Precipitation_(meteorology)</seealso>
    let ``Precipitation_(meteorology)`` =
        Prefixed_Name(resource, "Precipitation_(meteorology)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Preparatory_school_(United_Kingdom)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Preparatory_school_(United_Kingdom)">http://dbpedia.org/resource/Preparatory_school_(United_Kingdom)</seealso>
    let ``Preparatory_school_(United_Kingdom)`` =
        Prefixed_Name(resource, "Preparatory_school_(United_Kingdom)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Presbyterianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Presbyterianism">http://dbpedia.org/resource/Presbyterianism</seealso>
    let Presbyterianism = Prefixed_Name(resource, "Presbyterianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Primary_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Primary_school">http://dbpedia.org/resource/Primary_school</seealso>
    let Primary_school = Prefixed_Name(resource, "Primary_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Prison_reform</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Prison_reform">http://dbpedia.org/resource/Prison_reform</seealso>
    let Prison_reform = Prefixed_Name(resource, "Prison_reform") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Private_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Private_%28rank%29">http://dbpedia.org/resource/Private_%28rank%29</seealso>
    let ``Private_%28rank%29`` =
        Prefixed_Name(resource, "Private_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Private_(rank)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Private_(rank)">http://dbpedia.org/resource/Private_(rank)</seealso>
    let ``Private_(rank)`` = Prefixed_Name(resource, "Private_(rank)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Private_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Private_school">http://dbpedia.org/resource/Private_school</seealso>
    let Private_school = Prefixed_Name(resource, "Private_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Pro-Europeanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Pro-Europeanism">http://dbpedia.org/resource/Pro-Europeanism</seealso>
    let Pro_Europeanism = Prefixed_Name(resource, "Pro-Europeanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Professional_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Professional_degree">http://dbpedia.org/resource/Professional_degree</seealso>
    let Professional_degree =
        Prefixed_Name(resource, "Professional_degree") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Property_law</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Property_law">http://dbpedia.org/resource/Property_law</seealso>
    let Property_law = Prefixed_Name(resource, "Property_law") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Proslavery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Proslavery">http://dbpedia.org/resource/Proslavery</seealso>
    let Proslavery = Prefixed_Name(resource, "Proslavery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Protestantism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Protestantism">http://dbpedia.org/resource/Protestantism</seealso>
    let Protestantism = Prefixed_Name(resource, "Protestantism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Proto-Zionism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Proto-Zionism">http://dbpedia.org/resource/Proto-Zionism</seealso>
    let Proto_Zionism = Prefixed_Name(resource, "Proto-Zionism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Proton</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Proton">http://dbpedia.org/resource/Proton</seealso>
    let Proton = Prefixed_Name(resource, "Proton") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Proton-exchange_membrane_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PolymerElectrolyteMembraneFuelCell</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Proton-exchange membrane fuel cells (PEMFC), also known as polymer electrolyte membrane (PEM) fuel cells, are a type of fuel cell being developed mainly for transport applications, as well as for stationary fuel-cell applications and portable fuel-cell applications. Their distinguishing features include lower temperature/pressure ranges (50 to 100 °C) and a special proton-conducting polymer electrolyte membrane. PEMFCs generate electricity and operate on the opposite principle to PEM electrolysis, which consumes electricity. They are a leading candidate to replace the aging alkaline fuel-cell technology, which was used in the Space Shuttle."</para>
    /// labels<para>"Proton-exchange membrane fuel cell"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Proton-exchange_membrane_fuel_cell">http://dbpedia.org/resource/Proton-exchange_membrane_fuel_cell</seealso>
    let Proton_exchange_membrane_fuel_cell =
        Prefixed_Name(resource, "Proton-exchange_membrane_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Pruning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Pruning">http://dbpedia.org/resource/Pruning</seealso>
    let Pruning = Prefixed_Name(resource, "Pruning") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Psychotic_episode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Psychotic_episode">http://dbpedia.org/resource/Psychotic_episode</seealso>
    let Psychotic_episode = Prefixed_Name(resource, "Psychotic_episode") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Public_toilet</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Public_toilet">http://dbpedia.org/resource/Public_toilet</seealso>
    let Public_toilet = Prefixed_Name(resource, "Public_toilet") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Public_transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Public_transport">http://dbpedia.org/resource/Public_transport</seealso>
    let Public_transport = Prefixed_Name(resource, "Public_transport") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Punjabis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Punjabis">http://dbpedia.org/resource/Punjabis</seealso>
    let Punjabis = Prefixed_Name(resource, "Punjabis") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Puritans</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Puritans">http://dbpedia.org/resource/Puritans</seealso>
    let Puritans = Prefixed_Name(resource, "Puritans") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Qatar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Qatar">http://dbpedia.org/resource/Qatar</seealso>
    let Qatar = Prefixed_Name(resource, "Qatar") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Qingdao</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Qingdao">http://dbpedia.org/resource/Qingdao</seealso>
    let Qingdao = Prefixed_Name(resource, "Qingdao") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Quadracycle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Quadracycle">http://dbpedia.org/resource/Quadracycle</seealso>
    let Quadracycle = Prefixed_Name(resource, "Quadracycle") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Quakers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Quakers">http://dbpedia.org/resource/Quakers</seealso>
    let Quakers = Prefixed_Name(resource, "Quakers") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Quantum_Hall_effect</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Quantum_Hall_effect">http://dbpedia.org/resource/Quantum_Hall_effect</seealso>
    let Quantum_Hall_effect =
        Prefixed_Name(resource, "Quantum_Hall_effect") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Racial_equality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Racial_equality">http://dbpedia.org/resource/Racial_equality</seealso>
    let Racial_equality = Prefixed_Name(resource, "Racial_equality") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Racism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Racism">http://dbpedia.org/resource/Racism</seealso>
    let Racism = Prefixed_Name(resource, "Racism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Racism_in_the_United_Kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Racism_in_the_United_Kingdom">http://dbpedia.org/resource/Racism_in_the_United_Kingdom</seealso>
    let Racism_in_the_United_Kingdom =
        Prefixed_Name(resource, "Racism_in_the_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Radiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Radiation">http://dbpedia.org/resource/Radiation</seealso>
    let Radiation = Prefixed_Name(resource, "Radiation") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Rationalism">http://dbpedia.org/resource/Rationalism</seealso>
    let Rationalism = Prefixed_Name(resource, "Rationalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rear_admiral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Rear_admiral">http://dbpedia.org/resource/Rear_admiral</seealso>
    let Rear_admiral = Prefixed_Name(resource, "Rear_admiral") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Reform_Bills</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Reform_Bills">http://dbpedia.org/resource/Reform_Bills</seealso>
    let Reform_Bills = Prefixed_Name(resource, "Reform_Bills") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Reform_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Reform_movement">http://dbpedia.org/resource/Reform_movement</seealso>
    let Reform_movement = Prefixed_Name(resource, "Reform_movement") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Regiment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Regiment">http://dbpedia.org/resource/Regiment</seealso>
    let Regiment = Prefixed_Name(resource, "Regiment") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Regimental_Quartermaster_Sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Regimental_Quartermaster_Sergeant">http://dbpedia.org/resource/Regimental_Quartermaster_Sergeant</seealso>
    let Regimental_Quartermaster_Sergeant =
        Prefixed_Name(resource, "Regimental_Quartermaster_Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Regimental_sergeant_major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Regimental_sergeant_major">http://dbpedia.org/resource/Regimental_sergeant_major</seealso>
    let Regimental_sergeant_major =
        Prefixed_Name(resource, "Regimental_sergeant_major") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Reincarnation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Reincarnation">http://dbpedia.org/resource/Reincarnation</seealso>
    let Reincarnation = Prefixed_Name(resource, "Reincarnation") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Renault</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Renault">http://dbpedia.org/resource/Renault</seealso>
    let Renault = Prefixed_Name(resource, "Renault") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Republic_of_Estonia_%281920-1940%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Republic_of_Estonia_%281920-1940%29">http://dbpedia.org/resource/Republic_of_Estonia_%281920-1940%29</seealso>
    let ``Republic_of_Estonia_%281920_1940%29`` =
        Prefixed_Name(resource, "Republic_of_Estonia_%281920-1940%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Republic_of_Ireland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Republic_of_Ireland">http://dbpedia.org/resource/Republic_of_Ireland</seealso>
    let Republic_of_Ireland =
        Prefixed_Name(resource, "Republic_of_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Republic_of_the_Congo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Republic_of_the_Congo">http://dbpedia.org/resource/Republic_of_the_Congo</seealso>
    let Republic_of_the_Congo =
        Prefixed_Name(resource, "Republic_of_the_Congo") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Republicanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Republicanism">http://dbpedia.org/resource/Republicanism</seealso>
    let Republicanism = Prefixed_Name(resource, "Republicanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Republicanism_in_Spain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Republicanism_in_Spain">http://dbpedia.org/resource/Republicanism_in_Spain</seealso>
    let Republicanism_in_Spain =
        Prefixed_Name(resource, "Republicanism_in_Spain") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Revolutionary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Revolutionary">http://dbpedia.org/resource/Revolutionary</seealso>
    let Revolutionary = Prefixed_Name(resource, "Revolutionary") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Reynolds_number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Reynolds_number">http://dbpedia.org/resource/Reynolds_number</seealso>
    let Reynolds_number = Prefixed_Name(resource, "Reynolds_number") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rheumatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Rheumatism">http://dbpedia.org/resource/Rheumatism</seealso>
    let Rheumatism = Prefixed_Name(resource, "Rheumatism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rickshaw</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Rickshaw">http://dbpedia.org/resource/Rickshaw</seealso>
    let Rickshaw = Prefixed_Name(resource, "Rickshaw") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Role</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Role">http://dbpedia.org/resource/Role</seealso>
    let Role = Prefixed_Name(resource, "Role") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Romani_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Romani_people">http://dbpedia.org/resource/Romani_people</seealso>
    let Romani_people = Prefixed_Name(resource, "Romani_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Romania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Romania">http://dbpedia.org/resource/Romania</seealso>
    let Romania = Prefixed_Name(resource, "Romania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Room</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Room">http://dbpedia.org/resource/Room</seealso>
    let Room = Prefixed_Name(resource, "Room") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rosicrucianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Rosicrucianism">http://dbpedia.org/resource/Rosicrucianism</seealso>
    let Rosicrucianism = Prefixed_Name(resource, "Rosicrucianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Royal_Air_Force_station</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Royal_Air_Force_station">http://dbpedia.org/resource/Royal_Air_Force_station</seealso>
    let Royal_Air_Force_station =
        Prefixed_Name(resource, "Royal_Air_Force_station") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Royal_Canadian_Mounted_Police</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Royal_Canadian_Mounted_Police">http://dbpedia.org/resource/Royal_Canadian_Mounted_Police</seealso>
    let Royal_Canadian_Mounted_Police =
        Prefixed_Name(resource, "Royal_Canadian_Mounted_Police") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Ruby_(color)__Ruby_Red__1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ruby_(color)__Ruby_Red__1">http://dbpedia.org/resource/Ruby_(color)__Ruby_Red__1</seealso>
    let ``Ruby_(color)__Ruby_Red__1`` =
        Prefixed_Name(resource, "Ruby_(color)__Ruby_Red__1") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Russia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Russia">http://dbpedia.org/resource/Russia</seealso>
    let Russia = Prefixed_Name(resource, "Russia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rwanda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Rwanda">http://dbpedia.org/resource/Rwanda</seealso>
    let Rwanda = Prefixed_Name(resource, "Rwanda") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Rydberg_constant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Rydberg_constant">http://dbpedia.org/resource/Rydberg_constant</seealso>
    let Rydberg_constant = Prefixed_Name(resource, "Rydberg_constant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/SABMiller</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/SABMiller">http://dbpedia.org/resource/SABMiller</seealso>
    let SABMiller = Prefixed_Name(resource, "SABMiller") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sabbatarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sabbatarianism">http://dbpedia.org/resource/Sabbatarianism</seealso>
    let Sabbatarianism = Prefixed_Name(resource, "Sabbatarianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sahrawi_Arab_Democratic_Republic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sahrawi_Arab_Democratic_Republic">http://dbpedia.org/resource/Sahrawi_Arab_Democratic_Republic</seealso>
    let Sahrawi_Arab_Democratic_Republic =
        Prefixed_Name(resource, "Sahrawi_Arab_Democratic_Republic") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sailboat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sailboat">http://dbpedia.org/resource/Sailboat</seealso>
    let Sailboat = Prefixed_Name(resource, "Sailboat") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Saint_Kitts_and_Nevis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Saint_Kitts_and_Nevis">http://dbpedia.org/resource/Saint_Kitts_and_Nevis</seealso>
    let Saint_Kitts_and_Nevis =
        Prefixed_Name(resource, "Saint_Kitts_and_Nevis") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Saint_Lucia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Saint_Lucia">http://dbpedia.org/resource/Saint_Lucia</seealso>
    let Saint_Lucia = Prefixed_Name(resource, "Saint_Lucia") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Saint_Vincent_and_the_Grenadines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Saint_Vincent_and_the_Grenadines">http://dbpedia.org/resource/Saint_Vincent_and_the_Grenadines</seealso>
    let Saint_Vincent_and_the_Grenadines =
        Prefixed_Name(resource, "Saint_Vincent_and_the_Grenadines") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sales</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sales">http://dbpedia.org/resource/Sales</seealso>
    let Sales = Prefixed_Name(resource, "Sales") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Samoa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Samoa">http://dbpedia.org/resource/Samoa</seealso>
    let Samoa = Prefixed_Name(resource, "Samoa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/San_Marino</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/San_Marino">http://dbpedia.org/resource/San_Marino</seealso>
    let San_Marino = Prefixed_Name(resource, "San_Marino") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sangsa</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sangsa">http://dbpedia.org/resource/Sangsa</seealso>
    let Sangsa = Prefixed_Name(resource, "Sangsa") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sanitation#History</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sanitation#History">http://dbpedia.org/resource/Sanitation#History</seealso>
    let ``Sanitation#History`` =
        Prefixed_Name(resource, "Sanitation#History") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Saudi_Arabia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Saudi_Arabia">http://dbpedia.org/resource/Saudi_Arabia</seealso>
    let Saudi_Arabia = Prefixed_Name(resource, "Saudi_Arabia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Saxons</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Saxons">http://dbpedia.org/resource/Saxons</seealso>
    let Saxons = Prefixed_Name(resource, "Saxons") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Scalable_Vector_Graphics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Scalable_Vector_Graphics">http://dbpedia.org/resource/Scalable_Vector_Graphics</seealso>
    let Scalable_Vector_Graphics =
        Prefixed_Name(resource, "Scalable_Vector_Graphics") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/School</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/School">http://dbpedia.org/resource/School</seealso>
    let School = Prefixed_Name(resource, "School") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Schout-bij-nacht</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Schout-bij-nacht">http://dbpedia.org/resource/Schout-bij-nacht</seealso>
    let Schout_bij_nacht = Prefixed_Name(resource, "Schout-bij-nacht") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Scotland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Scotland">http://dbpedia.org/resource/Scotland</seealso>
    let Scotland = Prefixed_Name(resource, "Scotland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Scottish_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Scottish_nationalism">http://dbpedia.org/resource/Scottish_nationalism</seealso>
    let Scottish_nationalism =
        Prefixed_Name(resource, "Scottish_nationalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Scottish_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Scottish_people">http://dbpedia.org/resource/Scottish_people</seealso>
    let Scottish_people = Prefixed_Name(resource, "Scottish_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Seafood_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Seafood_allergy">http://dbpedia.org/resource/Seafood_allergy</seealso>
    let Seafood_allergy = Prefixed_Name(resource, "Seafood_allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Seaman</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Seaman">http://dbpedia.org/resource/Seaman</seealso>
    let Seaman = Prefixed_Name(resource, "Seaman") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Second_Boer_War</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Second_Boer_War">http://dbpedia.org/resource/Second_Boer_War</seealso>
    let Second_Boer_War = Prefixed_Name(resource, "Second_Boer_War") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Second_Corporal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Second_Corporal">http://dbpedia.org/resource/Second_Corporal</seealso>
    let Second_Corporal = Prefixed_Name(resource, "Second_Corporal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Second_lieutenant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Second_lieutenant">http://dbpedia.org/resource/Second_lieutenant</seealso>
    let Second_lieutenant = Prefixed_Name(resource, "Second_lieutenant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Secondary_education_in_France</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Secondary_education_in_France">http://dbpedia.org/resource/Secondary_education_in_France</seealso>
    let Secondary_education_in_France =
        Prefixed_Name(resource, "Secondary_education_in_France") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Secondary_modern_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Secondary_modern_school">http://dbpedia.org/resource/Secondary_modern_school</seealso>
    let Secondary_modern_school =
        Prefixed_Name(resource, "Secondary_modern_school") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Secondary_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Secondary_school">http://dbpedia.org/resource/Secondary_school</seealso>
    let Secondary_school = Prefixed_Name(resource, "Secondary_school") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Section_(military_unit)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Section_(military_unit)">http://dbpedia.org/resource/Section_(military_unit)</seealso>
    let ``Section_(military_unit)`` =
        Prefixed_Name(resource, "Section_(military_unit)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Secularism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Secularism">http://dbpedia.org/resource/Secularism</seealso>
    let Secularism = Prefixed_Name(resource, "Secularism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Seekers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Seekers">http://dbpedia.org/resource/Seekers</seealso>
    let Seekers = Prefixed_Name(resource, "Seekers") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Self_Defined_Ethnicity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Self_Defined_Ethnicity">http://dbpedia.org/resource/Self_Defined_Ethnicity</seealso>
    let Self_Defined_Ethnicity =
        Prefixed_Name(resource, "Self_Defined_Ethnicity") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Senegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Senegal">http://dbpedia.org/resource/Senegal</seealso>
    let Senegal = Prefixed_Name(resource, "Senegal") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sensitive_skin_type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sensitive_skin_type">http://dbpedia.org/resource/Sensitive_skin_type</seealso>
    let Sensitive_skin_type =
        Prefixed_Name(resource, "Sensitive_skin_type") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Separatism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Separatism">http://dbpedia.org/resource/Separatism</seealso>
    let Separatism = Prefixed_Name(resource, "Separatism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sephardi_Jews</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sephardi_Jews">http://dbpedia.org/resource/Sephardi_Jews</seealso>
    let Sephardi_Jews = Prefixed_Name(resource, "Sephardi_Jews") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Septinsular_Republic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Septinsular_Republic">http://dbpedia.org/resource/Septinsular_Republic</seealso>
    let Septinsular_Republic =
        Prefixed_Name(resource, "Septinsular_Republic") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Serbia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Serbia">http://dbpedia.org/resource/Serbia</seealso>
    let Serbia = Prefixed_Name(resource, "Serbia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sergeant</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sergeant">http://dbpedia.org/resource/Sergeant</seealso>
    let Sergeant = Prefixed_Name(resource, "Sergeant") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sergeant_Major_Instructor</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sergeant_Major_Instructor">http://dbpedia.org/resource/Sergeant_Major_Instructor</seealso>
    let Sergeant_Major_Instructor =
        Prefixed_Name(resource, "Sergeant_Major_Instructor") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sergeant_Pilot</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sergeant_Pilot">http://dbpedia.org/resource/Sergeant_Pilot</seealso>
    let Sergeant_Pilot = Prefixed_Name(resource, "Sergeant_Pilot") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sergeant_major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sergeant_major">http://dbpedia.org/resource/Sergeant_major</seealso>
    let Sergeant_major = Prefixed_Name(resource, "Sergeant_major") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Seventh_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Seventh_chord">http://dbpedia.org/resource/Seventh_chord</seealso>
    let Seventh_chord = Prefixed_Name(resource, "Seventh_chord") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sewing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sewing">http://dbpedia.org/resource/Sewing</seealso>
    let Sewing = Prefixed_Name(resource, "Sewing") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Seychelles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Seychelles">http://dbpedia.org/resource/Seychelles</seealso>
    let Seychelles = Prefixed_Name(resource, "Seychelles") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Shapefile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Shapefile">http://dbpedia.org/resource/Shapefile</seealso>
    let Shapefile = Prefixed_Name(resource, "Shapefile") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sherry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sherry">http://dbpedia.org/resource/Sherry</seealso>
    let Sherry = Prefixed_Name(resource, "Sherry") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Shinto</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Shinto">http://dbpedia.org/resource/Shinto</seealso>
    let Shinto = Prefixed_Name(resource, "Shinto") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ship">http://dbpedia.org/resource/Ship</seealso>
    let Ship = Prefixed_Name(resource, "Ship") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sierra_Leone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sierra_Leone">http://dbpedia.org/resource/Sierra_Leone</seealso>
    let Sierra_Leone = Prefixed_Name(resource, "Sierra_Leone") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Singapore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Singapore">http://dbpedia.org/resource/Singapore</seealso>
    let Singapore = Prefixed_Name(resource, "Singapore") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Single-sex_education</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Single-sex_education">http://dbpedia.org/resource/Single-sex_education</seealso>
    let Single_sex_education =
        Prefixed_Name(resource, "Single-sex_education") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Sixth_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sixth_chord">http://dbpedia.org/resource/Sixth_chord</seealso>
    let Sixth_chord = Prefixed_Name(resource, "Sixth_chord") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Skeuophoros</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Skeuophoros">http://dbpedia.org/resource/Skeuophoros</seealso>
    let Skeuophoros = Prefixed_Name(resource, "Skeuophoros") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Slavery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Slavery">http://dbpedia.org/resource/Slavery</seealso>
    let Slavery = Prefixed_Name(resource, "Slavery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Slavs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Slavs">http://dbpedia.org/resource/Slavs</seealso>
    let Slavs = Prefixed_Name(resource, "Slavs") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Slovakia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Slovakia">http://dbpedia.org/resource/Slovakia</seealso>
    let Slovakia = Prefixed_Name(resource, "Slovakia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Slovenia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Slovenia">http://dbpedia.org/resource/Slovenia</seealso>
    let Slovenia = Prefixed_Name(resource, "Slovenia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Smithwick%27s</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Smithwick%27s">http://dbpedia.org/resource/Smithwick%27s</seealso>
    let ``Smithwick%27s`` = Prefixed_Name(resource, "Smithwick%27s") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Social_Gospel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Social_Gospel">http://dbpedia.org/resource/Social_Gospel</seealso>
    let Social_Gospel = Prefixed_Name(resource, "Social_Gospel") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Social_purity_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Social_purity_movement">http://dbpedia.org/resource/Social_purity_movement</seealso>
    let Social_purity_movement =
        Prefixed_Name(resource, "Social_purity_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Socialism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Socialism">http://dbpedia.org/resource/Socialism</seealso>
    let Socialism = Prefixed_Name(resource, "Socialism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Socinianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Socinianism">http://dbpedia.org/resource/Socinianism</seealso>
    let Socinianism = Prefixed_Name(resource, "Socinianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Soil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Soil">http://dbpedia.org/resource/Soil</seealso>
    let Soil = Prefixed_Name(resource, "Soil") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Soil-adjusted_vegetation_index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>vas:Vegetation_Property</para>
    ///   <para>"Empirically derived NDVI products have been shown to be unstable, varying with soil colour, soil moisture, and saturation effects from high density vegetation. In an attempt to improve NDVI, Huete developed a vegetation index that accounted for the differential red and near-infrared extinction through the vegetation canopy. The index is a transformation technique that minimizes soil brightness influences from spectral vegetation indices involving red and near-infrared (NIR) wavelengths. The index is given as: where L is a canopy background adjustment factor. An L value of 0.5 in reflectance space was found to minimize soil brightness variations and eliminate the need for additional calibration for different soils.The transformation was found to nearly eliminate soil-induced variations in vegetation indices. (en)"</para>
    /// labels<para>"SAVI"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Soil-adjusted_vegetation_index">http://dbpedia.org/resource/Soil-adjusted_vegetation_index</seealso>
    let Soil_adjusted_vegetation_index =
        Prefixed_Name(resource, "Soil-adjusted_vegetation_index") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Soil_Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class that represents all Soil properties"</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Soil_Property">http://dbpedia.org/resource/Soil_Property</seealso>
    let Soil_Property = Prefixed_Name(resource, "Soil_Property") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Soil_moisture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>planet:resource/Soil_Property</para>
    ///   <para>"Soil moisture is the water content of the soil. It can be expressed in terms of volume or weight. Soil moisture measurement can be based on in situ probes (e.g., capacitance probes, neutron probes) or remote sensing methods. Water that enters a field is removed from a field by runoff, drainage, evaporation or transpiration."</para>
    /// labels<para>"SM"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Soil_moisture">http://dbpedia.org/resource/Soil_moisture</seealso>
    let Soil_moisture = Prefixed_Name(resource, "Soil_moisture") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Soldier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Soldier">http://dbpedia.org/resource/Soldier</seealso>
    let Soldier = Prefixed_Name(resource, "Soldier") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Solid_oxide_fuel_cell</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:SolidOxideFuelCell</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Solid oxide fuel cell"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Solid_oxide_fuel_cell">http://dbpedia.org/resource/Solid_oxide_fuel_cell</seealso>
    let Solid_oxide_fuel_cell =
        Prefixed_Name(resource, "Solid_oxide_fuel_cell") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Solomon_Islands</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Solomon_Islands">http://dbpedia.org/resource/Solomon_Islands</seealso>
    let Solomon_Islands = Prefixed_Name(resource, "Solomon_Islands") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Somalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Somalia">http://dbpedia.org/resource/Somalia</seealso>
    let Somalia = Prefixed_Name(resource, "Somalia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Somaliland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Somaliland">http://dbpedia.org/resource/Somaliland</seealso>
    let Somaliland = Prefixed_Name(resource, "Somaliland") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Somatophylakes</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Somatophylakes">http://dbpedia.org/resource/Somatophylakes</seealso>
    let Somatophylakes = Prefixed_Name(resource, "Somatophylakes") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sotnik</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sotnik">http://dbpedia.org/resource/Sotnik</seealso>
    let Sotnik = Prefixed_Name(resource, "Sotnik") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/South_Africa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/South_Africa">http://dbpedia.org/resource/South_Africa</seealso>
    let South_Africa = Prefixed_Name(resource, "South_Africa") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/South_America</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/South_America">http://dbpedia.org/resource/South_America</seealso>
    let South_America = Prefixed_Name(resource, "South_America") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/South_Korea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/South_Korea">http://dbpedia.org/resource/South_Korea</seealso>
    let South_Korea = Prefixed_Name(resource, "South_Korea") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/South_Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/South_Sudan">http://dbpedia.org/resource/South_Sudan</seealso>
    let South_Sudan = Prefixed_Name(resource, "South_Sudan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Soviet_Union</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Soviet_Union">http://dbpedia.org/resource/Soviet_Union</seealso>
    let Soviet_Union = Prefixed_Name(resource, "Soviet_Union") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sowi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sowi">http://dbpedia.org/resource/Sowi</seealso>
    let Sowi = Prefixed_Name(resource, "Sowi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Spain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Spain">http://dbpedia.org/resource/Spain</seealso>
    let Spain = Prefixed_Name(resource, "Spain") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Specific_phobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Specific_phobia">http://dbpedia.org/resource/Specific_phobia</seealso>
    let Specific_phobia = Prefixed_Name(resource, "Specific_phobia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Spiritualism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Spiritualism">http://dbpedia.org/resource/Spiritualism</seealso>
    let Spiritualism = Prefixed_Name(resource, "Spiritualism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sport">http://dbpedia.org/resource/Sport</seealso>
    let Sport = Prefixed_Name(resource, "Sport") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Squadron_(army)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Squadron_(army)">http://dbpedia.org/resource/Squadron_(army)</seealso>
    let ``Squadron_(army)`` = Prefixed_Name(resource, "Squadron_(army)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Squadron_(aviation)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Squadron_(aviation)">http://dbpedia.org/resource/Squadron_(aviation)</seealso>
    let ``Squadron_(aviation)`` =
        Prefixed_Name(resource, "Squadron_(aviation)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Squadron_(naval)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Squadron_(naval)">http://dbpedia.org/resource/Squadron_(naval)</seealso>
    let ``Squadron_(naval)`` =
        Prefixed_Name(resource, "Squadron_(naval)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Squadron_leader</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Squadron_leader">http://dbpedia.org/resource/Squadron_leader</seealso>
    let Squadron_leader = Prefixed_Name(resource, "Squadron_leader") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sri_Lanka</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sri_Lanka">http://dbpedia.org/resource/Sri_Lanka</seealso>
    let Sri_Lanka = Prefixed_Name(resource, "Sri_Lanka") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Staabikapten</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Staabikapten">http://dbpedia.org/resource/Staabikapten</seealso>
    let Staabikapten = Prefixed_Name(resource, "Staabikapten") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Stabskapit%C3%A4n</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Stabskapit%C3%A4n">http://dbpedia.org/resource/Stabskapit%C3%A4n</seealso>
    let ``Stabskapit%C3%A4n`` =
        Prefixed_Name(resource, "Stabskapit%C3%A4n") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Staff_Corporal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Staff_Corporal">http://dbpedia.org/resource/Staff_Corporal</seealso>
    let Staff_Corporal = Prefixed_Name(resource, "Staff_Corporal") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Staff_Sergeant_Major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Staff_Sergeant_Major">http://dbpedia.org/resource/Staff_Sergeant_Major</seealso>
    let Staff_Sergeant_Major =
        Prefixed_Name(resource, "Staff_Sergeant_Major") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Staff_sergeant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Staff_sergeant">http://dbpedia.org/resource/Staff_sergeant</seealso>
    let Staff_sergeant = Prefixed_Name(resource, "Staff_sergeant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Stairway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Stairway">http://dbpedia.org/resource/Stairway</seealso>
    let Stairway = Prefixed_Name(resource, "Stairway") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Stalinism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Stalinism">http://dbpedia.org/resource/Stalinism</seealso>
    let Stalinism = Prefixed_Name(resource, "Stalinism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Starshina</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Starshina">http://dbpedia.org/resource/Starshina</seealso>
    let Starshina = Prefixed_Name(resource, "Starshina") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/State_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/State_school">http://dbpedia.org/resource/State_school</seealso>
    let State_school = Prefixed_Name(resource, "State_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Statelessness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Statelessness">http://dbpedia.org/resource/Statelessness</seealso>
    let Statelessness = Prefixed_Name(resource, "Statelessness") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Stationary_fuel-cell_applications</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:PowerGeneration</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Definition from dbpedia: Stationary fuel-cell applications (or stationary fuel-cell power systems) are applications for fuel cells that are either connected to the electric grid (distributed generation) to provide supplemental power and as emergency power system for critical areas, or installed as a grid-independent generator for on-site service."</para>
    /// labels<para>"Stationary fuel-cell applications"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Stationary_fuel-cell_applications">http://dbpedia.org/resource/Stationary_fuel-cell_applications</seealso>
    let Stationary_fuel_cell_applications =
        Prefixed_Name(resource, "Stationary_fuel-cell_applications") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Steps</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Steps">http://dbpedia.org/resource/Steps</seealso>
    let Steps = Prefixed_Name(resource, "Steps") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Stratarches</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Stratarches">http://dbpedia.org/resource/Stratarches</seealso>
    let Stratarches = Prefixed_Name(resource, "Stratarches") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Strategos</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Strategos">http://dbpedia.org/resource/Strategos</seealso>
    let Strategos = Prefixed_Name(resource, "Strategos") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Strathspey,_Scotland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Strathspey,_Scotland">http://dbpedia.org/resource/Strathspey,_Scotland</seealso>
    let ``Strathspey,_Scotland`` =
        Prefixed_Name(resource, "Strathspey,_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Stroke</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Stroke">http://dbpedia.org/resource/Stroke</seealso>
    let Stroke = Prefixed_Name(resource, "Stroke") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sub-lieutenant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sub-lieutenant">http://dbpedia.org/resource/Sub-lieutenant</seealso>
    let Sub_lieutenant = Prefixed_Name(resource, "Sub-lieutenant") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Suba%C5%9Fi</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Suba%C5%9Fi">http://dbpedia.org/resource/Suba%C5%9Fi</seealso>
    let ``Suba%C5%9Fi`` = Prefixed_Name(resource, "Suba%C5%9Fi") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Subaltern</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Subaltern">http://dbpedia.org/resource/Subaltern</seealso>
    let Subaltern = Prefixed_Name(resource, "Subaltern") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sudan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sudan">http://dbpedia.org/resource/Sudan</seealso>
    let Sudan = Prefixed_Name(resource, "Sudan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Suffrage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Suffrage">http://dbpedia.org/resource/Suffrage</seealso>
    let Suffrage = Prefixed_Name(resource, "Suffrage") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sufism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Sufism">http://dbpedia.org/resource/Sufism</seealso>
    let Sufism = Prefixed_Name(resource, "Sufism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Summation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Summation">http://dbpedia.org/resource/Summation</seealso>
    let Summation = Prefixed_Name(resource, "Summation") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Suriname</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Suriname">http://dbpedia.org/resource/Suriname</seealso>
    let Suriname = Prefixed_Name(resource, "Suriname") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Suspended_chord</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Suspended_chord">http://dbpedia.org/resource/Suspended_chord</seealso>
    let Suspended_chord = Prefixed_Name(resource, "Suspended_chord") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Sweden</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Sweden">http://dbpedia.org/resource/Sweden</seealso>
    let Sweden = Prefixed_Name(resource, "Sweden") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Switzerland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Switzerland">http://dbpedia.org/resource/Switzerland</seealso>
    let Switzerland = Prefixed_Name(resource, "Switzerland") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Syntagmatarchis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Syntagmatarchis">http://dbpedia.org/resource/Syntagmatarchis</seealso>
    let Syntagmatarchis = Prefixed_Name(resource, "Syntagmatarchis") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Syria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Syria">http://dbpedia.org/resource/Syria</seealso>
    let Syria = Prefixed_Name(resource, "Syria") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/TEACHER</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/TEACHER">http://dbpedia.org/resource/TEACHER</seealso>
    let TEACHER = Prefixed_Name(resource, "TEACHER") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tagmatarchis</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tagmatarchis">http://dbpedia.org/resource/Tagmatarchis</seealso>
    let Tagmatarchis = Prefixed_Name(resource, "Tagmatarchis") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tailor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tailor">http://dbpedia.org/resource/Tailor</seealso>
    let Tailor = Prefixed_Name(resource, "Tailor") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tajikistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tajikistan">http://dbpedia.org/resource/Tajikistan</seealso>
    let Tajikistan = Prefixed_Name(resource, "Tajikistan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tank_Truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Truck</para>
    ///   <para>"A tank truck, gas truck, fuel truck, or tanker truck (United States usage) or tanker (United Kingdom usage), is a motor vehicle designed to carry liquids or gases on roads. The largest such vehicles are similar to railroad tank cars which are also designed to carry liquid loads. Many variants exist due to the wide variety of liquids that can be transported. Tank trucks tend to be large; they may be insulated or non-insulated; pressurized or non-pressurized; and designed for single or multiple loads (often by means of internal divisions in their tank). Some are semi-trailer trucks. They are difficult to drive and highly susceptible to rollover due to their high center of gravity, and potentially the free surface effect of liquids sloshing in a partially filled tank."</para>
    /// labels<para>"Tank Truck"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tank_Truck">http://dbpedia.org/resource/Tank_Truck</seealso>
    let Tank_Truck = Prefixed_Name(resource, "Tank_Truck") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tanzania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tanzania">http://dbpedia.org/resource/Tanzania</seealso>
    let Tanzania = Prefixed_Name(resource, "Tanzania") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tap_(valve)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tap_(valve)">http://dbpedia.org/resource/Tap_(valve)</seealso>
    let ``Tap_(valve)`` = Prefixed_Name(resource, "Tap_(valve)") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Task_force</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Task_force">http://dbpedia.org/resource/Task_force</seealso>
    let Task_force = Prefixed_Name(resource, "Task_force") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tatars</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tatars">http://dbpedia.org/resource/Tatars</seealso>
    let Tatars = Prefixed_Name(resource, "Tatars") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tax_resistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tax_resistance">http://dbpedia.org/resource/Tax_resistance</seealso>
    let Tax_resistance = Prefixed_Name(resource, "Tax_resistance") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Taxiarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Taxiarch">http://dbpedia.org/resource/Taxiarch</seealso>
    let Taxiarch = Prefixed_Name(resource, "Taxiarch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Telephone_call</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Telephone_call">http://dbpedia.org/resource/Telephone_call</seealso>
    let Telephone_call = Prefixed_Name(resource, "Telephone_call") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Temperance_movement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Temperance_movement">http://dbpedia.org/resource/Temperance_movement</seealso>
    let Temperance_movement =
        Prefixed_Name(resource, "Temperance_movement") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Tetrarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tetrarch">http://dbpedia.org/resource/Tetrarch</seealso>
    let Tetrarch = Prefixed_Name(resource, "Tetrarch") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Thailand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Thailand">http://dbpedia.org/resource/Thailand</seealso>
    let Thailand = Prefixed_Name(resource, "Thailand") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/The_Bahamas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/The_Bahamas">http://dbpedia.org/resource/The_Bahamas</seealso>
    let The_Bahamas = Prefixed_Name(resource, "The_Bahamas") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/The_Gambia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/The_Gambia">http://dbpedia.org/resource/The_Gambia</seealso>
    let The_Gambia = Prefixed_Name(resource, "The_Gambia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/The_New_Church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/The_New_Church">http://dbpedia.org/resource/The_New_Church</seealso>
    let The_New_Church = Prefixed_Name(resource, "The_New_Church") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Theater_(warfare)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Theater_(warfare)">http://dbpedia.org/resource/Theater_(warfare)</seealso>
    let ``Theater_(warfare)`` =
        Prefixed_Name(resource, "Theater_(warfare)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Theism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Theism">http://dbpedia.org/resource/Theism</seealso>
    let Theism = Prefixed_Name(resource, "Theism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Thracians</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Thracians">http://dbpedia.org/resource/Thracians</seealso>
    let Thracians = Prefixed_Name(resource, "Thracians") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Tiger_Cub_Economies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tiger_Cub_Economies">http://dbpedia.org/resource/Tiger_Cub_Economies</seealso>
    let Tiger_Cub_Economies =
        Prefixed_Name(resource, "Tiger_Cub_Economies") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Time</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Time">http://dbpedia.org/resource/Time</seealso>
    let Time = Prefixed_Name(resource, "Time") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Togo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Togo">http://dbpedia.org/resource/Togo</seealso>
    let Togo = Prefixed_Name(resource, "Togo") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tonga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tonga">http://dbpedia.org/resource/Tonga</seealso>
    let Tonga = Prefixed_Name(resource, "Tonga") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tool">http://dbpedia.org/resource/Tool</seealso>
    let Tool = Prefixed_Name(resource, "Tool") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Tories_(British_political_party)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tories_(British_political_party)">http://dbpedia.org/resource/Tories_(British_political_party)</seealso>
    let ``Tories_(British_political_party)`` =
        Prefixed_Name(resource, "Tories_(British_political_party)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Tour_guide</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tour_guide">http://dbpedia.org/resource/Tour_guide</seealso>
    let Tour_guide = Prefixed_Name(resource, "Tour_guide") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Toyota_FCHV-4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:Car</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Toyota_FCHV-4">http://dbpedia.org/resource/Toyota_FCHV-4</seealso>
    let Toyota_FCHV_4 = Prefixed_Name(resource, "Toyota_FCHV-4") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Toyota_Fuel_Cell_Hybrid_Vehicle-Advanced</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Car</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Toyota Fuel Cell Hybrid Vehicle-Advanced (FCHV-adv) is a fuel cell vehicle based on the first generation Toyota FCHV. The proposed FCHV-adv uses four hydrogen fuel tanks, which store high-pressure compressed hydrogen at up to 70 MPa (10,153 psi/700 bar) and feed it into a fuel stack to produce electricity via a chemical reaction between hydrogen and oxygen. This electricity then powers an electric motor, capable of 90 kW (122 ps/121 hp) and 260 Nm (26.5 kgf/192 lb·ft) of torque, and charges a nickel–metal hydride battery. Cruising range is approximately 760 km (472 mi) to 830 km (516 mi), and top speed is stated to be 155 km/h (96 mph)."</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Toyota_Fuel_Cell_Hybrid_Vehicle-Advanced">http://dbpedia.org/resource/Toyota_Fuel_Cell_Hybrid_Vehicle-Advanced</seealso>
    let Toyota_Fuel_Cell_Hybrid_Vehicle_Advanced =
        Prefixed_Name(resource, "Toyota_Fuel_Cell_Hybrid_Vehicle-Advanced") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Tractor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tractor">http://dbpedia.org/resource/Tractor</seealso>
    let Tractor = Prefixed_Name(resource, "Tractor") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Trade_union</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Trade_union">http://dbpedia.org/resource/Trade_union</seealso>
    let Trade_union = Prefixed_Name(resource, "Trade_union") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Trailer_(vehicle)</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Trailer_(vehicle)">http://dbpedia.org/resource/Trailer_(vehicle)</seealso>
    let ``Trailer_(vehicle)`` =
        Prefixed_Name(resource, "Trailer_(vehicle)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Transport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Transport">http://dbpedia.org/resource/Transport</seealso>
    let Transport = Prefixed_Name(resource, "Transport") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Travel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Travel">http://dbpedia.org/resource/Travel</seealso>
    let Travel = Prefixed_Name(resource, "Travel") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tree_nut_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tree_nut_allergy">http://dbpedia.org/resource/Tree_nut_allergy</seealso>
    let Tree_nut_allergy = Prefixed_Name(resource, "Tree_nut_allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Trench</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Trench">http://dbpedia.org/resource/Trench</seealso>
    let Trench = Prefixed_Name(resource, "Trench") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Trierarch</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Trierarch">http://dbpedia.org/resource/Trierarch</seealso>
    let Trierarch = Prefixed_Name(resource, "Trierarch") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Trinidad_and_Tobago</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Trinidad_and_Tobago">http://dbpedia.org/resource/Trinidad_and_Tobago</seealso>
    let Trinidad_and_Tobago =
        Prefixed_Name(resource, "Trinidad_and_Tobago") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Trooper_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Trooper_%28rank%29">http://dbpedia.org/resource/Trooper_%28rank%29</seealso>
    let ``Trooper_%28rank%29`` =
        Prefixed_Name(resource, "Trooper_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Truck">http://dbpedia.org/resource/Truck</seealso>
    let Truck = Prefixed_Name(resource, "Truck") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Trumpet_Major</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Trumpet_Major">http://dbpedia.org/resource/Trumpet_Major</seealso>
    let Trumpet_Major = Prefixed_Name(resource, "Trumpet_Major") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tsingtao_Brewery</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tsingtao_Brewery">http://dbpedia.org/resource/Tsingtao_Brewery</seealso>
    let Tsingtao_Brewery = Prefixed_Name(resource, "Tsingtao_Brewery") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tunisia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tunisia">http://dbpedia.org/resource/Tunisia</seealso>
    let Tunisia = Prefixed_Name(resource, "Tunisia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Turkey</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Turkey">http://dbpedia.org/resource/Turkey</seealso>
    let Turkey = Prefixed_Name(resource, "Turkey") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Turkmenistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Turkmenistan">http://dbpedia.org/resource/Turkmenistan</seealso>
    let Turkmenistan = Prefixed_Name(resource, "Turkmenistan") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tuvalu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Tuvalu">http://dbpedia.org/resource/Tuvalu</seealso>
    let Tuvalu = Prefixed_Name(resource, "Tuvalu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Tysyatsky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Tysyatsky">http://dbpedia.org/resource/Tysyatsky</seealso>
    let Tysyatsky = Prefixed_Name(resource, "Tysyatsky") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Uganda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Uganda">http://dbpedia.org/resource/Uganda</seealso>
    let Uganda = Prefixed_Name(resource, "Uganda") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ukraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Ukraine">http://dbpedia.org/resource/Ukraine</seealso>
    let Ukraine = Prefixed_Name(resource, "Ukraine") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Under_Officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Under_Officer">http://dbpedia.org/resource/Under_Officer</seealso>
    let Under_Officer = Prefixed_Name(resource, "Under_Officer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Undergraduate_degree</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Undergraduate_degree">http://dbpedia.org/resource/Undergraduate_degree</seealso>
    let Undergraduate_degree =
        Prefixed_Name(resource, "Undergraduate_degree") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Unionism_in_Ireland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Unionism_in_Ireland">http://dbpedia.org/resource/Unionism_in_Ireland</seealso>
    let Unionism_in_Ireland =
        Prefixed_Name(resource, "Unionism_in_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Unitarian_church</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Unitarian_church">http://dbpedia.org/resource/Unitarian_church</seealso>
    let Unitarian_church = Prefixed_Name(resource, "Unitarian_church") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Unitarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Unitarianism">http://dbpedia.org/resource/Unitarianism</seealso>
    let Unitarianism = Prefixed_Name(resource, "Unitarianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/United_Arab_Emirates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/United_Arab_Emirates">http://dbpedia.org/resource/United_Arab_Emirates</seealso>
    let United_Arab_Emirates =
        Prefixed_Name(resource, "United_Arab_Emirates") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/United_Kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/United_Kingdom">http://dbpedia.org/resource/United_Kingdom</seealso>
    let United_Kingdom = Prefixed_Name(resource, "United_Kingdom") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/United_States</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/United_States">http://dbpedia.org/resource/United_States</seealso>
    let United_States = Prefixed_Name(resource, "United_States") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Universalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Universalism">http://dbpedia.org/resource/Universalism</seealso>
    let Universalism = Prefixed_Name(resource, "Universalism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/University_of_Bonn</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Organization</para>
    ///   <para>dcterms:Agent</para>
    ///
    /// labels<para>"University of Bonn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/University_of_Bonn">http://dbpedia.org/resource/University_of_Bonn</seealso>
    let University_of_Bonn =
        Prefixed_Name(resource, "University_of_Bonn") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Upper_middle_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Upper_middle_class">http://dbpedia.org/resource/Upper_middle_class</seealso>
    let Upper_middle_class =
        Prefixed_Name(resource, "Upper_middle_class") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Urban_renewal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Urban_renewal">http://dbpedia.org/resource/Urban_renewal</seealso>
    let Urban_renewal = Prefixed_Name(resource, "Urban_renewal") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Uruguay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Uruguay">http://dbpedia.org/resource/Uruguay</seealso>
    let Uruguay = Prefixed_Name(resource, "Uruguay") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Utilitarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Utilitarianism">http://dbpedia.org/resource/Utilitarianism</seealso>
    let Utilitarianism = Prefixed_Name(resource, "Utilitarianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Uzbekistan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Uzbekistan">http://dbpedia.org/resource/Uzbekistan</seealso>
    let Uzbekistan = Prefixed_Name(resource, "Uzbekistan") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/V%C3%A4%C3%A4peli</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/V%C3%A4%C3%A4peli">http://dbpedia.org/resource/V%C3%A4%C3%A4peli</seealso>
    let ``V%C3%A4%C3%A4peli`` =
        Prefixed_Name(resource, "V%C3%A4%C3%A4peli") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vaccine_controversies</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vaccine_controversies">http://dbpedia.org/resource/Vaccine_controversies</seealso>
    let Vaccine_controversies =
        Prefixed_Name(resource, "Vaccine_controversies") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vacuum_truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:RegionalTruck</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A vacuum truck or vacuum tanker is a tank truck that has a pump and a tank. The pump is designed to pneumatically suck liquids, sludges, slurries, or the like from a location (often underground) into the tank of the truck. The objective is to enable transport of the liquid material via road to another location. Vacuum trucks transport the collected material to a treatment or disposal site, for example a sewage treatment plant. Vacuum trucks can be equipped with a high pressure pump if they are used to clean out sewers from sand."</para>
    /// labels<para>"Vacuum truck"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vacuum_truck">http://dbpedia.org/resource/Vacuum_truck</seealso>
    let Vacuum_truck = Prefixed_Name(resource, "Vacuum_truck") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Van</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Van">http://dbpedia.org/resource/Van</seealso>
    let Van = Prefixed_Name(resource, "Van") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Van_Hool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>holy:ManufacturingOrganization</para>
    ///
    /// labels<para>"Van Hool"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Van_Hool">http://dbpedia.org/resource/Van_Hool</seealso>
    let Van_Hool = Prefixed_Name(resource, "Van_Hool") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vanuatu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Vanuatu">http://dbpedia.org/resource/Vanuatu</seealso>
    let Vanuatu = Prefixed_Name(resource, "Vanuatu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vatican_City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Vatican_City">http://dbpedia.org/resource/Vatican_City</seealso>
    let Vatican_City = Prefixed_Name(resource, "Vatican_City") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Veebel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Veebel">http://dbpedia.org/resource/Veebel</seealso>
    let Veebel = Prefixed_Name(resource, "Veebel") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vegetarianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vegetarianism">http://dbpedia.org/resource/Vegetarianism</seealso>
    let Vegetarianism = Prefixed_Name(resource, "Vegetarianism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vegetation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Vegetation">http://dbpedia.org/resource/Vegetation</seealso>
    let Vegetation = Prefixed_Name(resource, "Vegetation") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vehicle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vehicle">http://dbpedia.org/resource/Vehicle</seealso>
    let Vehicle = Prefixed_Name(resource, "Vehicle") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vehicle_Identification_Number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vehicle_Identification_Number">http://dbpedia.org/resource/Vehicle_Identification_Number</seealso>
    let Vehicle_Identification_Number =
        Prefixed_Name(resource, "Vehicle_Identification_Number") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Velk%C3%A9_Popovice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Velk%C3%A9_Popovice">http://dbpedia.org/resource/Velk%C3%A9_Popovice</seealso>
    let ``Velk%C3%A9_Popovice`` =
        Prefixed_Name(resource, "Velk%C3%A9_Popovice") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Venezuela</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Venezuela">http://dbpedia.org/resource/Venezuela</seealso>
    let Venezuela = Prefixed_Name(resource, "Venezuela") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vice-Admiral_of_the_Coast</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vice-Admiral_of_the_Coast">http://dbpedia.org/resource/Vice-Admiral_of_the_Coast</seealso>
    let Vice_Admiral_of_the_Coast =
        Prefixed_Name(resource, "Vice-Admiral_of_the_Coast") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vice-Admiral_of_the_West</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vice-Admiral_of_the_West">http://dbpedia.org/resource/Vice-Admiral_of_the_West</seealso>
    let Vice_Admiral_of_the_West =
        Prefixed_Name(resource, "Vice-Admiral_of_the_West") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vice_admiral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vice_admiral">http://dbpedia.org/resource/Vice_admiral</seealso>
    let Vice_admiral = Prefixed_Name(resource, "Vice_admiral") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Victorian_dress_reform</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Victorian_dress_reform">http://dbpedia.org/resource/Victorian_dress_reform</seealso>
    let Victorian_dress_reform =
        Prefixed_Name(resource, "Victorian_dress_reform") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vietnam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Vietnam">http://dbpedia.org/resource/Vietnam</seealso>
    let Vietnam = Prefixed_Name(resource, "Vietnam") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vilanova_i_la_Geltr%C3%BA</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vilanova_i_la_Geltr%C3%BA">http://dbpedia.org/resource/Vilanova_i_la_Geltr%C3%BA</seealso>
    let ``Vilanova_i_la_Geltr%C3%BA`` =
        Prefixed_Name(resource, "Vilanova_i_la_Geltr%C3%BA") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Vitalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vitalism">http://dbpedia.org/resource/Vitalism</seealso>
    let Vitalism = Prefixed_Name(resource, "Vitalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vivisection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vivisection">http://dbpedia.org/resource/Vivisection</seealso>
    let Vivisection = Prefixed_Name(resource, "Vivisection") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Vocational_school</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Vocational_school">http://dbpedia.org/resource/Vocational_school</seealso>
    let Vocational_school = Prefixed_Name(resource, "Vocational_school") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Von_Luschan_scale</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Von_Luschan_scale">http://dbpedia.org/resource/Von_Luschan_scale</seealso>
    let Von_Luschan_scale = Prefixed_Name(resource, "Von_Luschan_scale") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wachtmeister</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wachtmeister">http://dbpedia.org/resource/Wachtmeister</seealso>
    let Wachtmeister = Prefixed_Name(resource, "Wachtmeister") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wales</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wales">http://dbpedia.org/resource/Wales</seealso>
    let Wales = Prefixed_Name(resource, "Wales") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Warrant_officer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Warrant_officer">http://dbpedia.org/resource/Warrant_officer</seealso>
    let Warrant_officer = Prefixed_Name(resource, "Warrant_officer") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Warrant_officer_%28United_Kingdom%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Warrant_officer_%28United_Kingdom%29">http://dbpedia.org/resource/Warrant_officer_%28United_Kingdom%29</seealso>
    let ``Warrant_officer_%28United_Kingdom%29`` =
        Prefixed_Name(resource, "Warrant_officer_%28United_Kingdom%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/WashBasin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/WashBasin">http://dbpedia.org/resource/WashBasin</seealso>
    let WashBasin = Prefixed_Name(resource, "WashBasin") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Washing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Washing">http://dbpedia.org/resource/Washing</seealso>
    let Washing = Prefixed_Name(resource, "Washing") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Water_supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Water_supply">http://dbpedia.org/resource/Water_supply</seealso>
    let Water_supply = Prefixed_Name(resource, "Water_supply") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Watercraft</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Watercraft">http://dbpedia.org/resource/Watercraft</seealso>
    let Watercraft = Prefixed_Name(resource, "Watercraft") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Weapon</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Weapon">http://dbpedia.org/resource/Weapon</seealso>
    let Weapon = Prefixed_Name(resource, "Weapon") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Welsh_nationalism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Welsh_nationalism">http://dbpedia.org/resource/Welsh_nationalism</seealso>
    let Welsh_nationalism = Prefixed_Name(resource, "Welsh_nationalism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Welsh_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Welsh_people">http://dbpedia.org/resource/Welsh_people</seealso>
    let Welsh_people = Prefixed_Name(resource, "Welsh_people") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wends</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wends">http://dbpedia.org/resource/Wends</seealso>
    let Wends = Prefixed_Name(resource, "Wends") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wesleyanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wesleyanism">http://dbpedia.org/resource/Wesleyanism</seealso>
    let Wesleyanism = Prefixed_Name(resource, "Wesleyanism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/West_Germany</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/West_Germany">http://dbpedia.org/resource/West_Germany</seealso>
    let West_Germany = Prefixed_Name(resource, "West_Germany") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/West_Indian</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/West_Indian">http://dbpedia.org/resource/West_Indian</seealso>
    let West_Indian = Prefixed_Name(resource, "West_Indian") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Western_Europe</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Western Europe"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/Western_Europe">http://dbpedia.org/resource/Western_Europe</seealso>
    let Western_Europe = Prefixed_Name(resource, "Western_Europe") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Western_Sahara</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Western_Sahara">http://dbpedia.org/resource/Western_Sahara</seealso>
    let Western_Sahara = Prefixed_Name(resource, "Western_Sahara") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Western_world</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Western_world">http://dbpedia.org/resource/Western_world</seealso>
    let Western_world = Prefixed_Name(resource, "Western_world") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wheat_allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Wheat_allergy">http://dbpedia.org/resource/Wheat_allergy</seealso>
    let Wheat_allergy = Prefixed_Name(resource, "Wheat_allergy") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wheelchair_lift</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wheelchair_lift">http://dbpedia.org/resource/Wheelchair_lift</seealso>
    let Wheelchair_lift = Prefixed_Name(resource, "Wheelchair_lift") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Wheelchair_ramp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wheelchair_ramp">http://dbpedia.org/resource/Wheelchair_ramp</seealso>
    let Wheelchair_ramp = Prefixed_Name(resource, "Wheelchair_ramp") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Whiggism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Whiggism">http://dbpedia.org/resource/Whiggism</seealso>
    let Whiggism = Prefixed_Name(resource, "Whiggism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Whisky</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Whisky">http://dbpedia.org/resource/Whisky</seealso>
    let Whisky = Prefixed_Name(resource, "Whisky") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/White_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/White_people">http://dbpedia.org/resource/White_people</seealso>
    let White_people = Prefixed_Name(resource, "White_people") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wien%27s_displacement_law</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wien%27s_displacement_law">http://dbpedia.org/resource/Wien%27s_displacement_law</seealso>
    let ``Wien%27s_displacement_law`` =
        Prefixed_Name(resource, "Wien%27s_displacement_law") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/William_Grant_%26_Sons</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/William_Grant_%26_Sons">http://dbpedia.org/resource/William_Grant_%26_Sons</seealso>
    let ``William_Grant_%26_Sons`` =
        Prefixed_Name(resource, "William_Grant_%26_Sons") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/William_Wilde</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/William_Wilde">http://dbpedia.org/resource/William_Wilde</seealso>
    let William_Wilde = Prefixed_Name(resource, "William_Wilde") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wing_(military_aviation_unit)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wing_(military_aviation_unit)">http://dbpedia.org/resource/Wing_(military_aviation_unit)</seealso>
    let ``Wing_(military_aviation_unit)`` =
        Prefixed_Name(resource, "Wing_(military_aviation_unit)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wing_commander_%28rank%29</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wing_commander_%28rank%29">http://dbpedia.org/resource/Wing_commander_%28rank%29</seealso>
    let ``Wing_commander_%28rank%29`` =
        Prefixed_Name(resource, "Wing_commander_%28rank%29") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wing_commander_(rank)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wing_commander_(rank)">http://dbpedia.org/resource/Wing_commander_(rank)</seealso>
    let ``Wing_commander_(rank)`` =
        Prefixed_Name(resource, "Wing_commander_(rank)") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wojski</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wojski">http://dbpedia.org/resource/Wojski</seealso>
    let Wojski = Prefixed_Name(resource, "Wojski") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Womanism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Womanism">http://dbpedia.org/resource/Womanism</seealso>
    let Womanism = Prefixed_Name(resource, "Womanism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Women's_Enfranchisement_Act,_1930</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Women's_Enfranchisement_Act,_1930">http://dbpedia.org/resource/Women's_Enfranchisement_Act,_1930</seealso>
    let ``Women's_Enfranchisement_Act,_1930`` =
        Prefixed_Name(resource, "Women's_Enfranchisement_Act,_1930") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Women_in_the_workforce</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Women_in_the_workforce">http://dbpedia.org/resource/Women_in_the_workforce</seealso>
    let Women_in_the_workforce =
        Prefixed_Name(resource, "Women_in_the_workforce") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/Wonsu</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Wonsu">http://dbpedia.org/resource/Wonsu</seealso>
    let Wonsu = Prefixed_Name(resource, "Wonsu") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Woodworking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Woodworking">http://dbpedia.org/resource/Woodworking</seealso>
    let Woodworking = Prefixed_Name(resource, "Woodworking") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Working_class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Working_class">http://dbpedia.org/resource/Working_class</seealso>
    let Working_class = Prefixed_Name(resource, "Working_class") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/World</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:GeographicMarket</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/World">http://dbpedia.org/resource/World</seealso>
    let World = Prefixed_Name(resource, "World") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/X3D</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/X3D">http://dbpedia.org/resource/X3D</seealso>
    let X3D = Prefixed_Name(resource, "X3D") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/X_unit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/X_unit">http://dbpedia.org/resource/X_unit</seealso>
    let X_unit = Prefixed_Name(resource, "X_unit") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Yemen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Yemen">http://dbpedia.org/resource/Yemen</seealso>
    let Yemen = Prefixed_Name(resource, "Yemen") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Yesaul</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Yesaul">http://dbpedia.org/resource/Yesaul</seealso>
    let Yesaul = Prefixed_Name(resource, "Yesaul") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Ypolochagos</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Ypolochagos">http://dbpedia.org/resource/Ypolochagos</seealso>
    let Ypolochagos = Prefixed_Name(resource, "Ypolochagos") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zambia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Zambia">http://dbpedia.org/resource/Zambia</seealso>
    let Zambia = Prefixed_Name(resource, "Zambia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zen</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Zen">http://dbpedia.org/resource/Zen</seealso>
    let Zen = Prefixed_Name(resource, "Zen") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zimbabwe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Zimbabwe">http://dbpedia.org/resource/Zimbabwe</seealso>
    let Zimbabwe = Prefixed_Name(resource, "Zimbabwe") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zionism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Zionism">http://dbpedia.org/resource/Zionism</seealso>
    let Zionism = Prefixed_Name(resource, "Zionism") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zoophobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://dbpedia.org/resource/Zoophobia">http://dbpedia.org/resource/Zoophobia</seealso>
    let Zoophobia = Prefixed_Name(resource, "Zoophobia") |> PrefixedName
    /// <summary>
    ///   <para>planet:resource/Zoroastrianism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/resource/Zoroastrianism">http://dbpedia.org/resource/Zoroastrianism</seealso>
    let Zoroastrianism = Prefixed_Name(resource, "Zoroastrianism") |> PrefixedName

    /// <summary>
    ///   <para>planet:resource/combined_heat_and_power_station</para>
    /// </summary>
    /// <remarks>
    ///   <para>holy:Heating</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Combined heat and power station"</para></remarks>
    /// <seealso href="http://dbpedia.org/resource/combined_heat_and_power_station">http://dbpedia.org/resource/combined_heat_and_power_station</seealso>
    let combined_heat_and_power_station =
        Prefixed_Name(resource, "combined_heat_and_power_station") |> PrefixedName
