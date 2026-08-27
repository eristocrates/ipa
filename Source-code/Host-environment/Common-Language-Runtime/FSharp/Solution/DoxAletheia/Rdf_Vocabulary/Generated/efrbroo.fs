namespace http.erlangen_crm.org.efrbroo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module efrbroo =
    let _namespace_iri = Namespace_Iri efrbroo |> NamespaceIRI
    /// <summary>
    ///   <para>efrbroo:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/">http://erlangen-crm.org/efrbroo/</seealso>
    let _prefix_iri = Prefixed_Name(efrbroo, "") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:CLP2_should_have_type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/CLP2_should_have_type">http://erlangen-crm.org/efrbroo/CLP2_should_have_type</seealso>
    let CLP2_should_have_type =
        Prefixed_Name(efrbroo, "CLP2_should_have_type") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:CLP2i_should_be_type_of</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/CLP2i_should_be_type_of">http://erlangen-crm.org/efrbroo/CLP2i_should_be_type_of</seealso>
    let CLP2i_should_be_type_of =
        Prefixed_Name(efrbroo, "CLP2i_should_be_type_of") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:CLP43_should_have_dimension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/CLP43_should_have_dimension">http://erlangen-crm.org/efrbroo/CLP43_should_have_dimension</seealso>
    let CLP43_should_have_dimension =
        Prefixed_Name(efrbroo, "CLP43_should_have_dimension") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:CLP43i_should_be_dimension_of</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/CLP43i_should_be_dimension_of">http://erlangen-crm.org/efrbroo/CLP43i_should_be_dimension_of</seealso>
    let CLP43i_should_be_dimension_of =
        Prefixed_Name(efrbroo, "CLP43i_should_be_dimension_of") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F10_Person</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F10_Person">http://erlangen-crm.org/efrbroo/F10_Person</seealso>
    let F10_Person = Prefixed_Name(efrbroo, "F10_Person") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F14_Individual_Work</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F14_Individual_Work">http://erlangen-crm.org/efrbroo/F14_Individual_Work</seealso>
    let F14_Individual_Work =
        Prefixed_Name(efrbroo, "F14_Individual_Work") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F15_Complex_Work</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F15_Complex_Work">http://erlangen-crm.org/efrbroo/F15_Complex_Work</seealso>
    let F15_Complex_Work = Prefixed_Name(efrbroo, "F15_Complex_Work") |> PrefixedName
    /// <summary>
    ///   <para>efrbroo:F1_Work</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F1_Work">http://erlangen-crm.org/efrbroo/F1_Work</seealso>
    let F1_Work = Prefixed_Name(efrbroo, "F1_Work") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F22_Self-Contained_Expression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F22_Self-Contained_Expression">http://erlangen-crm.org/efrbroo/F22_Self-Contained_Expression</seealso>
    let F22_Self_Contained_Expression =
        Prefixed_Name(efrbroo, "F22_Self-Contained_Expression") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F23_Expression_Fragment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F23_Expression_Fragment">http://erlangen-crm.org/efrbroo/F23_Expression_Fragment</seealso>
    let F23_Expression_Fragment =
        Prefixed_Name(efrbroo, "F23_Expression_Fragment") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F24_Publication_Expression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F24_Publication_Expression">http://erlangen-crm.org/efrbroo/F24_Publication_Expression</seealso>
    let F24_Publication_Expression =
        Prefixed_Name(efrbroo, "F24_Publication_Expression") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F25_Performance_Plan</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F25_Performance_Plan">http://erlangen-crm.org/efrbroo/F25_Performance_Plan</seealso>
    let F25_Performance_Plan =
        Prefixed_Name(efrbroo, "F25_Performance_Plan") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F28_Expression_Creation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F28_Expression_Creation">http://erlangen-crm.org/efrbroo/F28_Expression_Creation</seealso>
    let F28_Expression_Creation =
        Prefixed_Name(efrbroo, "F28_Expression_Creation") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F2_Expression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F2_Expression">http://erlangen-crm.org/efrbroo/F2_Expression</seealso>
    let F2_Expression = Prefixed_Name(efrbroo, "F2_Expression") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F30_Publication_Event</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F30_Publication_Event">http://erlangen-crm.org/efrbroo/F30_Publication_Event</seealso>
    let F30_Publication_Event =
        Prefixed_Name(efrbroo, "F30_Publication_Event") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F31_Performance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F31_Performance">http://erlangen-crm.org/efrbroo/F31_Performance</seealso>
    let F31_Performance = Prefixed_Name(efrbroo, "F31_Performance") |> PrefixedName
    /// <summary>
    ///   <para>efrbroo:F38_Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F38_Character">http://erlangen-crm.org/efrbroo/F38_Character</seealso>
    let F38_Character = Prefixed_Name(efrbroo, "F38_Character") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F3_Manifestation_Product_Type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F3_Manifestation_Product_Type">http://erlangen-crm.org/efrbroo/F3_Manifestation_Product_Type</seealso>
    let F3_Manifestation_Product_Type =
        Prefixed_Name(efrbroo, "F3_Manifestation_Product_Type") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F4_Manifestation_Singleton</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F4_Manifestation_Singleton">http://erlangen-crm.org/efrbroo/F4_Manifestation_Singleton</seealso>
    let F4_Manifestation_Singleton =
        Prefixed_Name(efrbroo, "F4_Manifestation_Singleton") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:F50_Controlled_Access_Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/F50_Controlled_Access_Point">http://erlangen-crm.org/efrbroo/F50_Controlled_Access_Point</seealso>
    let F50_Controlled_Access_Point =
        Prefixed_Name(efrbroo, "F50_Controlled_Access_Point") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R17_created</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R17_created">http://erlangen-crm.org/efrbroo/R17_created</seealso>
    let R17_created = Prefixed_Name(efrbroo, "R17_created") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R17i_was_created_by</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R17i_was_created_by">http://erlangen-crm.org/efrbroo/R17i_was_created_by</seealso>
    let R17i_was_created_by =
        Prefixed_Name(efrbroo, "R17i_was_created_by") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R18_created</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R18_created">http://erlangen-crm.org/efrbroo/R18_created</seealso>
    let R18_created = Prefixed_Name(efrbroo, "R18_created") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R18i_was_created_by</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R18i_was_created_by">http://erlangen-crm.org/efrbroo/R18i_was_created_by</seealso>
    let R18i_was_created_by =
        Prefixed_Name(efrbroo, "R18i_was_created_by") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R3_is_realised_in</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R3_is_realised_in">http://erlangen-crm.org/efrbroo/R3_is_realised_in</seealso>
    let R3_is_realised_in = Prefixed_Name(efrbroo, "R3_is_realised_in") |> PrefixedName
    /// <summary>
    ///   <para>efrbroo:R3i_realises</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R3i_realises">http://erlangen-crm.org/efrbroo/R3i_realises</seealso>
    let R3i_realises = Prefixed_Name(efrbroo, "R3i_realises") |> PrefixedName
    /// <summary>
    ///   <para>efrbroo:R5_has_component</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R5_has_component">http://erlangen-crm.org/efrbroo/R5_has_component</seealso>
    let R5_has_component = Prefixed_Name(efrbroo, "R5_has_component") |> PrefixedName

    /// <summary>
    ///   <para>efrbroo:R5i_is_component_of</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://erlangen-crm.org/efrbroo/R5i_is_component_of">http://erlangen-crm.org/efrbroo/R5i_is_component_of</seealso>
    let R5i_is_component_of =
        Prefixed_Name(efrbroo, "R5i_is_component_of") |> PrefixedName
