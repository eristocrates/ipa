namespace https.en.wikipedia.org.wiki.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wikipedia =
    let _namespace_iri = Namespace_Iri wikipedia |> NamespaceIRI

    /// <summary>
    ///   <para>wikipedia:%C3%85land_Islands/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/%C3%85land_Islands/">https://en.wikipedia.org/wiki/%C3%85land_Islands/</seealso>
    let ``_%C3%85land_Islands/`` =
        Prefixed_Name(wikipedia, "%C3%85land_Islands/") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:AC_power_plugs_and_sockets#10_A_plugs_and_sockets_(Type_J)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#10_A_plugs_and_sockets_(Type_J)">https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#10_A_plugs_and_sockets_(Type_J)</seealso>
    let ``AC_power_plugs_and_sockets#10_A_plugs_and_sockets_(Type_J)`` =
        Prefixed_Name(wikipedia, "AC_power_plugs_and_sockets#10_A_plugs_and_sockets_(Type_J)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:AC_power_plugs_and_sockets#CEE_7/16_plugs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#CEE_7/16_plugs">https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#CEE_7/16_plugs</seealso>
    let ``AC_power_plugs_and_sockets#CEE_7/16_plugs`` =
        Prefixed_Name(wikipedia, "AC_power_plugs_and_sockets#CEE_7/16_plugs") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:AC_power_plugs_and_sockets#CEE_7/5_socket_and_CEE_7/6_plug_(French;_Type_E)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#CEE_7/5_socket_and_CEE_7/6_plug_(French;_Type_E)">https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets#CEE_7/5_socket_and_CEE_7/6_plug_(French;_Type_E)</seealso>
    let ``AC_power_plugs_and_sockets#CEE_7/5_socket_and_CEE_7/6_plug_(French;_Type_E)`` =
        Prefixed_Name(wikipedia, "AC_power_plugs_and_sockets#CEE_7/5_socket_and_CEE_7/6_plug_(French;_Type_E)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:AC_power_plugs_and_sockets:_British_and_related_types#International_usage_of_Type_G</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets:_British_and_related_types#International_usage_of_Type_G">https://en.wikipedia.org/wiki/AC_power_plugs_and_sockets:_British_and_related_types#International_usage_of_Type_G</seealso>
    let ``AC_power_plugs_and_sockets:_British_and_related_types#International_usage_of_Type_G`` =
        Prefixed_Name(wikipedia, "AC_power_plugs_and_sockets:_British_and_related_types#International_usage_of_Type_G") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:AS/NZS_3112</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/AS/NZS_3112">https://en.wikipedia.org/wiki/AS/NZS_3112</seealso>
    let ``AS/NZS_3112`` = Prefixed_Name(wikipedia, "AS/NZS_3112") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Address_(geography)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Address_(geography)">https://en.wikipedia.org/wiki/Address_(geography)</seealso>
    let ``Address_(geography)`` =
        Prefixed_Name(wikipedia, "Address_(geography)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Administrative_division</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Administrative_division">https://en.wikipedia.org/wiki/Administrative_division</seealso>
    let Administrative_division =
        Prefixed_Name(wikipedia, "Administrative_division") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Aunt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Aunt">https://en.wikipedia.org/wiki/Aunt</seealso>
    let Aunt = Prefixed_Name(wikipedia, "Aunt") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Autodidacticism</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Autodidacticism">https://en.wikipedia.org/wiki/Autodidacticism</seealso>
    let Autodidacticism = Prefixed_Name(wikipedia, "Autodidacticism") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:British_people</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/British_people">https://en.wikipedia.org/wiki/British_people</seealso>
    let British_people = Prefixed_Name(wikipedia, "British_people") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Brother</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Brother">https://en.wikipedia.org/wiki/Brother</seealso>
    let Brother = Prefixed_Name(wikipedia, "Brother") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Budweiser_(Anheuser-Busch)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Budweiser_(Anheuser-Busch)">https://en.wikipedia.org/wiki/Budweiser_(Anheuser-Busch)</seealso>
    let ``Budweiser_(Anheuser_Busch)`` =
        Prefixed_Name(wikipedia, "Budweiser_(Anheuser-Busch)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Bursary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Bursary">https://en.wikipedia.org/wiki/Bursary</seealso>
    let Bursary = Prefixed_Name(wikipedia, "Bursary") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:CHAdeMO</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/CHAdeMO">https://en.wikipedia.org/wiki/CHAdeMO</seealso>
    let CHAdeMO = Prefixed_Name(wikipedia, "CHAdeMO") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Capital_districts_and_territories</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Capital_districts_and_territories">https://en.wikipedia.org/wiki/Capital_districts_and_territories</seealso>
    let Capital_districts_and_territories =
        Prefixed_Name(wikipedia, "Capital_districts_and_territories") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Carnivora</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Carnivora">https://en.wikipedia.org/wiki/Carnivora</seealso>
    let Carnivora = Prefixed_Name(wikipedia, "Carnivora") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:City</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/City">https://en.wikipedia.org/wiki/City</seealso>
    let City = Prefixed_Name(wikipedia, "City") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Combined_Charging_System</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Combined_Charging_System">https://en.wikipedia.org/wiki/Combined_Charging_System</seealso>
    let Combined_Charging_System =
        Prefixed_Name(wikipedia, "Combined_Charging_System") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Combined_statistical_area</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Combined_statistical_area">https://en.wikipedia.org/wiki/Combined_statistical_area</seealso>
    let Combined_statistical_area =
        Prefixed_Name(wikipedia, "Combined_statistical_area") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Consolidated_city-county</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Consolidated_city-county">https://en.wikipedia.org/wiki/Consolidated_city-county</seealso>
    let Consolidated_city_county =
        Prefixed_Name(wikipedia, "Consolidated_city-county") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Country</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Country">https://en.wikipedia.org/wiki/Country</seealso>
    let Country = Prefixed_Name(wikipedia, "Country") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:County</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/County">https://en.wikipedia.org/wiki/County</seealso>
    let County = Prefixed_Name(wikipedia, "County") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Courts_of_Denmark/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Courts_of_Denmark/">https://en.wikipedia.org/wiki/Courts_of_Denmark/</seealso>
    let ``Courts_of_Denmark/`` =
        Prefixed_Name(wikipedia, "Courts_of_Denmark/") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Courts_of_England_and_Wales</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Courts_of_England_and_Wales">https://en.wikipedia.org/wiki/Courts_of_England_and_Wales</seealso>
    let Courts_of_England_and_Wales =
        Prefixed_Name(wikipedia, "Courts_of_England_and_Wales") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Courts_of_Northern_Ireland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Courts_of_Northern_Ireland">https://en.wikipedia.org/wiki/Courts_of_Northern_Ireland</seealso>
    let Courts_of_Northern_Ireland =
        Prefixed_Name(wikipedia, "Courts_of_Northern_Ireland") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Courts_of_Scotland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Courts_of_Scotland">https://en.wikipedia.org/wiki/Courts_of_Scotland</seealso>
    let Courts_of_Scotland =
        Prefixed_Name(wikipedia, "Courts_of_Scotland") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Courts_of_the_United_Kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Courts_of_the_United_Kingdom">https://en.wikipedia.org/wiki/Courts_of_the_United_Kingdom</seealso>
    let Courts_of_the_United_Kingdom =
        Prefixed_Name(wikipedia, "Courts_of_the_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Data_dictionary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Data_dictionary">https://en.wikipedia.org/wiki/Data_dictionary</seealso>
    let Data_dictionary = Prefixed_Name(wikipedia, "Data_dictionary") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Data_element</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Data_element">https://en.wikipedia.org/wiki/Data_element</seealso>
    let Data_element = Prefixed_Name(wikipedia, "Data_element") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Data_element_definition</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Data_element_definition">https://en.wikipedia.org/wiki/Data_element_definition</seealso>
    let Data_element_definition =
        Prefixed_Name(wikipedia, "Data_element_definition") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Data_element_name</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Data_element_name">https://en.wikipedia.org/wiki/Data_element_name</seealso>
    let Data_element_name =
        Prefixed_Name(wikipedia, "Data_element_name") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Daughter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Daughter">https://en.wikipedia.org/wiki/Daughter</seealso>
    let Daughter = Prefixed_Name(wikipedia, "Daughter") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:District</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/District">https://en.wikipedia.org/wiki/District</seealso>
    let District = Prefixed_Name(wikipedia, "District") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Dunkel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Dunkel">https://en.wikipedia.org/wiki/Dunkel</seealso>
    let Dunkel = Prefixed_Name(wikipedia, "Dunkel") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:European_Commission</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/European_Commission">https://en.wikipedia.org/wiki/European_Commission</seealso>
    let European_Commission =
        Prefixed_Name(wikipedia, "European_Commission") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Exhibition_(scholarship)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Exhibition_(scholarship)">https://en.wikipedia.org/wiki/Exhibition_(scholarship)</seealso>
    let ``Exhibition_(scholarship)`` =
        Prefixed_Name(wikipedia, "Exhibition_(scholarship)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Exonym_and_endonym</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Exonym_and_endonym">https://en.wikipedia.org/wiki/Exonym_and_endonym</seealso>
    let Exonym_and_endonym =
        Prefixed_Name(wikipedia, "Exonym_and_endonym") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Extract,_transform,_load</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Extract,_transform,_load">https://en.wikipedia.org/wiki/Extract,_transform,_load</seealso>
    let ``Extract,_transform,_load`` =
        Prefixed_Name(wikipedia, "Extract,_transform,_load") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Fair_value</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Fair_value">https://en.wikipedia.org/wiki/Fair_value</seealso>
    let Fair_value = Prefixed_Name(wikipedia, "Fair_value") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Family#Roles</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Family#Roles">https://en.wikipedia.org/wiki/Family#Roles</seealso>
    let ``Family#Roles`` = Prefixed_Name(wikipedia, "Family#Roles") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Father</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Father">https://en.wikipedia.org/wiki/Father</seealso>
    let Father = Prefixed_Name(wikipedia, "Father") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Federated_state</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Federated_state">https://en.wikipedia.org/wiki/Federated_state</seealso>
    let Federated_state = Prefixed_Name(wikipedia, "Federated_state") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Filename_extension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Filename_extension">https://en.wikipedia.org/wiki/Filename_extension</seealso>
    let Filename_extension =
        Prefixed_Name(wikipedia, "Filename_extension") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Fuel_Cell_Bus_Club#CUTE</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Fuel_Cell_Bus_Club#CUTE">https://en.wikipedia.org/wiki/Fuel_Cell_Bus_Club#CUTE</seealso>
    let ``Fuel_Cell_Bus_Club#CUTE`` =
        Prefixed_Name(wikipedia, "Fuel_Cell_Bus_Club#CUTE") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Geographical_feature</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Geographical_feature">https://en.wikipedia.org/wiki/Geographical_feature</seealso>
    let Geographical_feature =
        Prefixed_Name(wikipedia, "Geographical_feature") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Geometry</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Geometry">https://en.wikipedia.org/wiki/Geometry</seealso>
    let Geometry = Prefixed_Name(wikipedia, "Geometry") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Government_of_the_United_Kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Government_of_the_United_Kingdom">https://en.wikipedia.org/wiki/Government_of_the_United_Kingdom</seealso>
    let Government_of_the_United_Kingdom =
        Prefixed_Name(wikipedia, "Government_of_the_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Grandparent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Grandparent">https://en.wikipedia.org/wiki/Grandparent</seealso>
    let Grandparent = Prefixed_Name(wikipedia, "Grandparent") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Guernsey#Politics</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Guernsey#Politics">https://en.wikipedia.org/wiki/Guernsey#Politics</seealso>
    let ``Guernsey#Politics`` =
        Prefixed_Name(wikipedia, "Guernsey#Politics") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Hamlet_(place)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Hamlet_(place)">https://en.wikipedia.org/wiki/Hamlet_(place)</seealso>
    let ``Hamlet_(place)`` = Prefixed_Name(wikipedia, "Hamlet_(place)") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Hoare_logic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Hoare_logic">https://en.wikipedia.org/wiki/Hoare_logic</seealso>
    let Hoare_logic = Prefixed_Name(wikipedia, "Hoare_logic") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Homeschooling</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Homeschooling">https://en.wikipedia.org/wiki/Homeschooling</seealso>
    let Homeschooling = Prefixed_Name(wikipedia, "Homeschooling") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Hostname</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Hostname">https://en.wikipedia.org/wiki/Hostname</seealso>
    let Hostname = Prefixed_Name(wikipedia, "Hostname") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:House_numbering</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/House_numbering">https://en.wikipedia.org/wiki/House_numbering</seealso>
    let House_numbering = Prefixed_Name(wikipedia, "House_numbering") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:IEC_60309</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/IEC_60309">https://en.wikipedia.org/wiki/IEC_60309</seealso>
    let IEC_60309 = Prefixed_Name(wikipedia, "IEC_60309") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:IEC_62196#Type_1_(SAE_J1772-2009),_Yazaki</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/IEC_62196#Type_1_(SAE_J1772-2009),_Yazaki">https://en.wikipedia.org/wiki/IEC_62196#Type_1_(SAE_J1772-2009),_Yazaki</seealso>
    let ``IEC_62196#Type_1_(SAE_J1772_2009),_Yazaki`` =
        Prefixed_Name(wikipedia, "IEC_62196#Type_1_(SAE_J1772-2009),_Yazaki") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:IEC_62196#Type_3_(EV_Plug_Alliance_connector),_Scame</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/IEC_62196#Type_3_(EV_Plug_Alliance_connector),_Scame">https://en.wikipedia.org/wiki/IEC_62196#Type_3_(EV_Plug_Alliance_connector),_Scame</seealso>
    let ``IEC_62196#Type_3_(EV_Plug_Alliance_connector),_Scame`` =
        Prefixed_Name(wikipedia, "IEC_62196#Type_3_(EV_Plug_Alliance_connector),_Scame") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:ISO/IEC_11179</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO/IEC_11179">https://en.wikipedia.org/wiki/ISO/IEC_11179</seealso>
    let ``ISO/IEC_11179`` = Prefixed_Name(wikipedia, "ISO/IEC_11179") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:ISO/IEC_7812</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO/IEC_7812">https://en.wikipedia.org/wiki/ISO/IEC_7812</seealso>
    let ``ISO/IEC_7812`` = Prefixed_Name(wikipedia, "ISO/IEC_7812") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:ISO_3166-1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO_3166-1">https://en.wikipedia.org/wiki/ISO_3166-1</seealso>
    let ISO_3166_1 = Prefixed_Name(wikipedia, "ISO_3166-1") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Identifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Identifier">https://en.wikipedia.org/wiki/Identifier</seealso>
    let Identifier = Prefixed_Name(wikipedia, "Identifier") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Indian_Depository_Receipt</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Indian_Depository_Receipt">https://en.wikipedia.org/wiki/Indian_Depository_Receipt</seealso>
    let Indian_Depository_Receipt =
        Prefixed_Name(wikipedia, "Indian_Depository_Receipt") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Jerry_Hobbs</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Jerry_Hobbs">https://en.wikipedia.org/wiki/Jerry_Hobbs</seealso>
    let Jerry_Hobbs = Prefixed_Name(wikipedia, "Jerry_Hobbs") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judicial_system_of_Finland</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judicial_system_of_Finland">https://en.wikipedia.org/wiki/Judicial_system_of_Finland</seealso>
    let Judicial_system_of_Finland =
        Prefixed_Name(wikipedia, "Judicial_system_of_Finland") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judiciaries_of_the_United_Kingdom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judiciaries_of_the_United_Kingdom">https://en.wikipedia.org/wiki/Judiciaries_of_the_United_Kingdom</seealso>
    let Judiciaries_of_the_United_Kingdom =
        Prefixed_Name(wikipedia, "Judiciaries_of_the_United_Kingdom") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judiciary_of_Germany/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judiciary_of_Germany/">https://en.wikipedia.org/wiki/Judiciary_of_Germany/</seealso>
    let ``Judiciary_of_Germany/`` =
        Prefixed_Name(wikipedia, "Judiciary_of_Germany/") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judiciary_of_Portugal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judiciary_of_Portugal">https://en.wikipedia.org/wiki/Judiciary_of_Portugal</seealso>
    let Judiciary_of_Portugal =
        Prefixed_Name(wikipedia, "Judiciary_of_Portugal") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judiciary_of_the_Isle_of_Man</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judiciary_of_the_Isle_of_Man">https://en.wikipedia.org/wiki/Judiciary_of_the_Isle_of_Man</seealso>
    let Judiciary_of_the_Isle_of_Man =
        Prefixed_Name(wikipedia, "Judiciary_of_the_Isle_of_Man") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Judiciary_of_the_Netherlands</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Judiciary_of_the_Netherlands">https://en.wikipedia.org/wiki/Judiciary_of_the_Netherlands</seealso>
    let Judiciary_of_the_Netherlands =
        Prefixed_Name(wikipedia, "Judiciary_of_the_Netherlands") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Law_of_Jersey#Judiciary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Law_of_Jersey#Judiciary">https://en.wikipedia.org/wiki/Law_of_Jersey#Judiciary</seealso>
    let ``Law_of_Jersey#Judiciary`` =
        Prefixed_Name(wikipedia, "Law_of_Jersey#Judiciary") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:List_of_Metropolitan_Statistical_Areas</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/List_of_Metropolitan_Statistical_Areas">https://en.wikipedia.org/wiki/List_of_Metropolitan_Statistical_Areas</seealso>
    let List_of_Metropolitan_Statistical_Areas =
        Prefixed_Name(wikipedia, "List_of_Metropolitan_Statistical_Areas") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:List_of_micropolitan_statistical_areas</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/List_of_micropolitan_statistical_areas">https://en.wikipedia.org/wiki/List_of_micropolitan_statistical_areas</seealso>
    let List_of_micropolitan_statistical_areas =
        Prefixed_Name(wikipedia, "List_of_micropolitan_statistical_areas") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Mixin</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Mixin">https://en.wikipedia.org/wiki/Mixin</seealso>
    let Mixin = Prefixed_Name(wikipedia, "Mixin") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Mother</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Mother">https://en.wikipedia.org/wiki/Mother</seealso>
    let Mother = Prefixed_Name(wikipedia, "Mother") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Municipality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Municipality">https://en.wikipedia.org/wiki/Municipality</seealso>
    let Municipality = Prefixed_Name(wikipedia, "Municipality") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:NEMA_connector#NEMA_14</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/NEMA_connector#NEMA_14">https://en.wikipedia.org/wiki/NEMA_connector#NEMA_14</seealso>
    let ``NEMA_connector#NEMA_14`` =
        Prefixed_Name(wikipedia, "NEMA_connector#NEMA_14") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:NEMA_connector#NEMA_5</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/NEMA_connector#NEMA_5">https://en.wikipedia.org/wiki/NEMA_connector#NEMA_5</seealso>
    let ``NEMA_connector#NEMA_5`` =
        Prefixed_Name(wikipedia, "NEMA_connector#NEMA_5") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:NEMA_connector#NEMA_6</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/NEMA_connector#NEMA_6">https://en.wikipedia.org/wiki/NEMA_connector#NEMA_6</seealso>
    let ``NEMA_connector#NEMA_6`` =
        Prefixed_Name(wikipedia, "NEMA_connector#NEMA_6") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:National_Assembly_for_Wales</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/National_Assembly_for_Wales">https://en.wikipedia.org/wiki/National_Assembly_for_Wales</seealso>
    let National_Assembly_for_Wales =
        Prefixed_Name(wikipedia, "National_Assembly_for_Wales") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Neighbourhood</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Neighbourhood">https://en.wikipedia.org/wiki/Neighbourhood</seealso>
    let Neighbourhood = Prefixed_Name(wikipedia, "Neighbourhood") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Nephew_and_niece</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Nephew_and_niece">https://en.wikipedia.org/wiki/Nephew_and_niece</seealso>
    let Nephew_and_niece = Prefixed_Name(wikipedia, "Nephew_and_niece") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Northern_Ireland_Assembly</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Northern_Ireland_Assembly">https://en.wikipedia.org/wiki/Northern_Ireland_Assembly</seealso>
    let Northern_Ireland_Assembly =
        Prefixed_Name(wikipedia, "Northern_Ireland_Assembly") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Organization</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Organization">https://en.wikipedia.org/wiki/Organization</seealso>
    let Organization = Prefixed_Name(wikipedia, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Parent</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Parent">https://en.wikipedia.org/wiki/Parent</seealso>
    let Parent = Prefixed_Name(wikipedia, "Parent") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Parish_(administrative_division)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Parish_(administrative_division)">https://en.wikipedia.org/wiki/Parish_(administrative_division)</seealso>
    let ``Parish_(administrative_division)`` =
        Prefixed_Name(wikipedia, "Parish_(administrative_division)") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Political_division</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Political_division">https://en.wikipedia.org/wiki/Political_division</seealso>
    let Political_division =
        Prefixed_Name(wikipedia, "Political_division") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Politics_of_Afghanistan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Politics_of_Afghanistan">https://en.wikipedia.org/wiki/Politics_of_Afghanistan</seealso>
    let Politics_of_Afghanistan =
        Prefixed_Name(wikipedia, "Politics_of_Afghanistan") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Postal_code</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Postal_code">https://en.wikipedia.org/wiki/Postal_code</seealso>
    let Postal_code = Prefixed_Name(wikipedia, "Postal_code") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Province</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Province">https://en.wikipedia.org/wiki/Province</seealso>
    let Province = Prefixed_Name(wikipedia, "Province") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Public_service</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Public_service">https://en.wikipedia.org/wiki/Public_service</seealso>
    let Public_service = Prefixed_Name(wikipedia, "Public_service") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Puerto_Rico</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Puerto_Rico">https://en.wikipedia.org/wiki/Puerto_Rico</seealso>
    let Puerto_Rico = Prefixed_Name(wikipedia, "Puerto_Rico") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:SAE_J1772</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/SAE_J1772">https://en.wikipedia.org/wiki/SAE_J1772</seealso>
    let SAE_J1772 = Prefixed_Name(wikipedia, "SAE_J1772") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Scholarship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Scholarship">https://en.wikipedia.org/wiki/Scholarship</seealso>
    let Scholarship = Prefixed_Name(wikipedia, "Scholarship") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:School</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/School">https://en.wikipedia.org/wiki/School</seealso>
    let School = Prefixed_Name(wikipedia, "School") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Scottish_Government</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Scottish_Government">https://en.wikipedia.org/wiki/Scottish_Government</seealso>
    let Scottish_Government =
        Prefixed_Name(wikipedia, "Scottish_Government") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Sibling</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Sibling">https://en.wikipedia.org/wiki/Sibling</seealso>
    let Sibling = Prefixed_Name(wikipedia, "Sibling") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Sister</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Sister">https://en.wikipedia.org/wiki/Sister</seealso>
    let Sister = Prefixed_Name(wikipedia, "Sister") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Stepchild</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Stepchild">https://en.wikipedia.org/wiki/Stepchild</seealso>
    let Stepchild = Prefixed_Name(wikipedia, "Stepchild") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Stepfather</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Stepfather">https://en.wikipedia.org/wiki/Stepfather</seealso>
    let Stepfather = Prefixed_Name(wikipedia, "Stepfather") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Stepmother</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Stepmother">https://en.wikipedia.org/wiki/Stepmother</seealso>
    let Stepmother = Prefixed_Name(wikipedia, "Stepmother") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Stepsibling</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Stepsibling">https://en.wikipedia.org/wiki/Stepsibling</seealso>
    let Stepsibling = Prefixed_Name(wikipedia, "Stepsibling") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Street</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Street">https://en.wikipedia.org/wiki/Street</seealso>
    let Street = Prefixed_Name(wikipedia, "Street") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Studentship</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Studentship">https://en.wikipedia.org/wiki/Studentship</seealso>
    let Studentship = Prefixed_Name(wikipedia, "Studentship") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Supreme_Court_of_Albania</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Supreme_Court_of_Albania">https://en.wikipedia.org/wiki/Supreme_Court_of_Albania</seealso>
    let Supreme_Court_of_Albania =
        Prefixed_Name(wikipedia, "Supreme_Court_of_Albania") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Tesla_Supercharger</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Tesla_Supercharger">https://en.wikipedia.org/wiki/Tesla_Supercharger</seealso>
    let Tesla_Supercharger =
        Prefixed_Name(wikipedia, "Tesla_Supercharger") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Thoroughfare</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Thoroughfare">https://en.wikipedia.org/wiki/Thoroughfare</seealso>
    let Thoroughfare = Prefixed_Name(wikipedia, "Thoroughfare") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Town</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Town">https://en.wikipedia.org/wiki/Town</seealso>
    let Town = Prefixed_Name(wikipedia, "Town") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Township</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Township">https://en.wikipedia.org/wiki/Township</seealso>
    let Township = Prefixed_Name(wikipedia, "Township") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Type_2_connector</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Type_2_connector">https://en.wikipedia.org/wiki/Type_2_connector</seealso>
    let Type_2_connector = Prefixed_Name(wikipedia, "Type_2_connector") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Uncle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Uncle">https://en.wikipedia.org/wiki/Uncle</seealso>
    let Uncle = Prefixed_Name(wikipedia, "Uncle") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:United_States_Virgin_Islands</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/United_States_Virgin_Islands">https://en.wikipedia.org/wiki/United_States_Virgin_Islands</seealso>
    let United_States_Virgin_Islands =
        Prefixed_Name(wikipedia, "United_States_Virgin_Islands") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Village</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Village">https://en.wikipedia.org/wiki/Village</seealso>
    let Village = Prefixed_Name(wikipedia, "Village") |> PrefixedName
    /// <summary>
    ///   <para>wikipedia:Viverridae</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Viverridae">https://en.wikipedia.org/wiki/Viverridae</seealso>
    let Viverridae = Prefixed_Name(wikipedia, "Viverridae") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Washington,_D.C.</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Washington,_D.C.">https://en.wikipedia.org/wiki/Washington,_D.C.</seealso>
    let ``Washington,_D.C.`` =
        Prefixed_Name(wikipedia, "Washington,_D.C.") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:Wife</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/Wife">https://en.wikipedia.org/wiki/Wife</seealso>
    let Wife = Prefixed_Name(wikipedia, "Wife") |> PrefixedName

    /// <summary>
    ///   <para>wikipedia:XLR_connector#Four-pin_(XLR4)</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://en.wikipedia.org/wiki/XLR_connector#Four-pin_(XLR4)">https://en.wikipedia.org/wiki/XLR_connector#Four-pin_(XLR4)</seealso>
    let ``XLR_connector#Four_pin_(XLR4)`` =
        Prefixed_Name(wikipedia, "XLR_connector#Four-pin_(XLR4)") |> PrefixedName
