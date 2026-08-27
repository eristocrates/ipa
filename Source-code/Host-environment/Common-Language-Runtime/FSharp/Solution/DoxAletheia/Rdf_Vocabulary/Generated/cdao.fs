namespace http.purl.obolibrary.org.obo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cdao =
    let _namespace_iri = Namespace_Iri cdao |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"OBO Foundry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/">http://purl.obolibrary.org/obo/</seealso>
    let OBO_Foundry = Prefixed_Name(cdao, "") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"is template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000001">http://purl.obolibrary.org/obo/ARG_0000001</seealso>
    let is_template'ARG_0000001 = Prefixed_Name(cdao, "ARG_0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000008</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000008">http://purl.obolibrary.org/obo/ARG_0000008</seealso>
    let ARG_0000008'ARG_0000008 = Prefixed_Name(cdao, "ARG_0000008") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"user-defined tag"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000015">http://purl.obolibrary.org/obo/ARG_0000015</seealso>
    let user_defined_tag'ARG_0000015 = Prefixed_Name(cdao, "ARG_0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000033">http://purl.obolibrary.org/obo/ARG_0000033</seealso>
    let ARG_0000033'ARG_0000033 = Prefixed_Name(cdao, "ARG_0000033") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000172</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"patient ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000172">http://purl.obolibrary.org/obo/ARG_0000172</seealso>
    let patient_ID'ARG_0000172 = Prefixed_Name(cdao, "ARG_0000172") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_0000197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"health care provider ID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_0000197">http://purl.obolibrary.org/obo/ARG_0000197</seealso>
    let health_care_provider_ID'ARG_0000197 = Prefixed_Name(cdao, "ARG_0000197") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Topic Weight Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000008">http://purl.obolibrary.org/obo/ARG_2000008</seealso>
    let Topic_Weight_Measurement'ARG_2000008 = Prefixed_Name(cdao, "ARG_2000008") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expertise Measurement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000009">http://purl.obolibrary.org/obo/ARG_2000009</seealso>
    let Expertise_Measurement'ARG_2000009 = Prefixed_Name(cdao, "ARG_2000009") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Topic Weight Measurement Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000010">http://purl.obolibrary.org/obo/ARG_2000010</seealso>
    let Topic_Weight_Measurement_Process =
        Prefixed_Name(cdao, "ARG_2000010") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Expertise Measurement Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000011">http://purl.obolibrary.org/obo/ARG_2000011</seealso>
    let Expertise_Measurement_Process =
        Prefixed_Name(cdao, "ARG_2000011") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"Measurement Label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000012">http://purl.obolibrary.org/obo/ARG_2000012</seealso>
    let Measurement_Label'ARG_2000012 = Prefixed_Name(cdao, "ARG_2000012") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000021</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Experience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000021">http://purl.obolibrary.org/obo/ARG_2000021</seealso>
    let Experience'ARG_2000021 = Prefixed_Name(cdao, "ARG_2000021") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000022</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specialty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000022">http://purl.obolibrary.org/obo/ARG_2000022</seealso>
    let specialty'ARG_2000022 = Prefixed_Name(cdao, "ARG_2000022") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contact info"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000028">http://purl.obolibrary.org/obo/ARG_2000028</seealso>
    let has_contact_info'ARG_2000028 = Prefixed_Name(cdao, "ARG_2000028") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contact info for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000029">http://purl.obolibrary.org/obo/ARG_2000029</seealso>
    let contact_info_for'ARG_2000029 = Prefixed_Name(cdao, "ARG_2000029") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000065</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Allergy and Immunology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000065">http://purl.obolibrary.org/obo/ARG_2000065</seealso>
    let American_Board_of_Allergy_and_Immunology =
        Prefixed_Name(cdao, "ARG_2000065") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000066</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Anesthesiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000066">http://purl.obolibrary.org/obo/ARG_2000066</seealso>
    let American_Board_of_Anesthesiology =
        Prefixed_Name(cdao, "ARG_2000066") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000067</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Colon and Rectal Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000067">http://purl.obolibrary.org/obo/ARG_2000067</seealso>
    let American_Board_of_Colon_and_Rectal_Surgery =
        Prefixed_Name(cdao, "ARG_2000067") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000068</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Dermatology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000068">http://purl.obolibrary.org/obo/ARG_2000068</seealso>
    let American_Board_of_Dermatology =
        Prefixed_Name(cdao, "ARG_2000068") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000069</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Emergency Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000069">http://purl.obolibrary.org/obo/ARG_2000069</seealso>
    let American_Board_of_Emergency_Medicine =
        Prefixed_Name(cdao, "ARG_2000069") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000070</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Family Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000070">http://purl.obolibrary.org/obo/ARG_2000070</seealso>
    let American_Board_of_Family_Medicine =
        Prefixed_Name(cdao, "ARG_2000070") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000071</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Internal Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000071">http://purl.obolibrary.org/obo/ARG_2000071</seealso>
    let American_Board_of_Internal_Medicine =
        Prefixed_Name(cdao, "ARG_2000071") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000072</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Medical Genetics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000072">http://purl.obolibrary.org/obo/ARG_2000072</seealso>
    let American_Board_of_Medical_Genetics =
        Prefixed_Name(cdao, "ARG_2000072") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000073</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Neurological Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000073">http://purl.obolibrary.org/obo/ARG_2000073</seealso>
    let American_Board_of_Neurological_Surgery =
        Prefixed_Name(cdao, "ARG_2000073") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000074</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Nuclear Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000074">http://purl.obolibrary.org/obo/ARG_2000074</seealso>
    let American_Board_of_Nuclear_Medicine =
        Prefixed_Name(cdao, "ARG_2000074") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000075</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Obstetrics and Gynecology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000075">http://purl.obolibrary.org/obo/ARG_2000075</seealso>
    let American_Board_of_Obstetrics_and_Gynecology =
        Prefixed_Name(cdao, "ARG_2000075") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000076</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Ophthalmology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000076">http://purl.obolibrary.org/obo/ARG_2000076</seealso>
    let American_Board_of_Ophthalmology =
        Prefixed_Name(cdao, "ARG_2000076") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000077</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Orthopaedic Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000077">http://purl.obolibrary.org/obo/ARG_2000077</seealso>
    let American_Board_of_Orthopaedic_Surgery =
        Prefixed_Name(cdao, "ARG_2000077") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000078</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Otolaryngology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000078">http://purl.obolibrary.org/obo/ARG_2000078</seealso>
    let American_Board_of_Otolaryngology =
        Prefixed_Name(cdao, "ARG_2000078") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000079</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Pathology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000079">http://purl.obolibrary.org/obo/ARG_2000079</seealso>
    let American_Board_of_Pathology'ARG_2000079 = Prefixed_Name(cdao, "ARG_2000079") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000080</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Pediatrics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000080">http://purl.obolibrary.org/obo/ARG_2000080</seealso>
    let American_Board_of_Pediatrics =
        Prefixed_Name(cdao, "ARG_2000080") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000081</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Physical Medicine and Rehabilitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000081">http://purl.obolibrary.org/obo/ARG_2000081</seealso>
    let American_Board_of_Physical_Medicine_and_Rehabilitation =
        Prefixed_Name(cdao, "ARG_2000081") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000083</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Plastic Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000083">http://purl.obolibrary.org/obo/ARG_2000083</seealso>
    let American_Board_of_Plastic_Surgery =
        Prefixed_Name(cdao, "ARG_2000083") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000084</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Preventive Medicine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000084">http://purl.obolibrary.org/obo/ARG_2000084</seealso>
    let American_Board_of_Preventive_Medicine =
        Prefixed_Name(cdao, "ARG_2000084") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000085</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Psychiatry and Neurology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000085">http://purl.obolibrary.org/obo/ARG_2000085</seealso>
    let American_Board_of_Psychiatry_and_Neurology =
        Prefixed_Name(cdao, "ARG_2000085") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000086</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Radiology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000086">http://purl.obolibrary.org/obo/ARG_2000086</seealso>
    let American_Board_of_Radiology'ARG_2000086 = Prefixed_Name(cdao, "ARG_2000086") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000087</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000087">http://purl.obolibrary.org/obo/ARG_2000087</seealso>
    let American_Board_of_Surgery'ARG_2000087 = Prefixed_Name(cdao, "ARG_2000087") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000088</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Thoracic Surgery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000088">http://purl.obolibrary.org/obo/ARG_2000088</seealso>
    let American_Board_of_Thoracic_Surgery =
        Prefixed_Name(cdao, "ARG_2000088") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ARG_2000089</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"American Board of Urology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000089">http://purl.obolibrary.org/obo/ARG_2000089</seealso>
    let American_Board_of_Urology'ARG_2000089 = Prefixed_Name(cdao, "ARG_2000089") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000376</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contact Qualifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000376">http://purl.obolibrary.org/obo/ARG_2000376</seealso>
    let Contact_Qualifier'ARG_2000376 = Prefixed_Name(cdao, "ARG_2000376") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FOAF Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000377">http://purl.obolibrary.org/obo/ARG_2000377</seealso>
    let FOAF_Profile'ARG_2000377 = Prefixed_Name(cdao, "ARG_2000377") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000379</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000379">http://purl.obolibrary.org/obo/ARG_2000379</seealso>
    let Contact'ARG_2000379 = Prefixed_Name(cdao, "ARG_2000379") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"context for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000390">http://purl.obolibrary.org/obo/ARG_2000390</seealso>
    let context_for'ARG_2000390 = Prefixed_Name(cdao, "ARG_2000390") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000391</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000391">http://purl.obolibrary.org/obo/ARG_2000391</seealso>
    let has_context'ARG_2000391 = Prefixed_Name(cdao, "ARG_2000391") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000399</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has contact agent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000399">http://purl.obolibrary.org/obo/ARG_2000399</seealso>
    let has_contact_agent'ARG_2000399 = Prefixed_Name(cdao, "ARG_2000399") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ARG_2000400</para>
    /// </summary>
    /// <remarks>
    ///   <para>cdao:UO_0000280</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"count per year"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ARG_2000400">http://purl.obolibrary.org/obo/ARG_2000400</seealso>
    let count_per_year'ARG_2000400 = Prefixed_Name(cdao, "ARG_2000400") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000001">http://purl.obolibrary.org/obo/BFO_0000001</seealso>
    let Entity'BFO_0000001 = Prefixed_Name(cdao, "BFO_0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"continuant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000002">http://purl.obolibrary.org/obo/BFO_0000002</seealso>
    let Continuant'BFO_0000002 = Prefixed_Name(cdao, "BFO_0000002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Occurrent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"occurrent"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000003">http://purl.obolibrary.org/obo/BFO_0000003</seealso>
    let Occurrent'BFO_0000003 = Prefixed_Name(cdao, "BFO_0000003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Independent Continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"independent continuant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000004">http://purl.obolibrary.org/obo/BFO_0000004</seealso>
    let Independent_Continuant'BFO_0000004 = Prefixed_Name(cdao, "BFO_0000004") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"obsolete dependent continuant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000005">http://purl.obolibrary.org/obo/BFO_0000005</seealso>
    let obsolete_dependent_continuant =
        Prefixed_Name(cdao, "BFO_0000005") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatial region"</para><para>"Spatial Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000006">http://purl.obolibrary.org/obo/BFO_0000006</seealso>
    let spatial_region'BFO_0000006 = Prefixed_Name(cdao, "BFO_0000006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000008</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temporal region"</para><para>"Temporal Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000008">http://purl.obolibrary.org/obo/BFO_0000008</seealso>
    let temporal_region'BFO_0000008 = Prefixed_Name(cdao, "BFO_0000008") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two-dimensional spatial region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000009">http://purl.obolibrary.org/obo/BFO_0000009</seealso>
    let two_dimensional_spatial_region =
        Prefixed_Name(cdao, "BFO_0000009") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"spatiotemporal region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000011">http://purl.obolibrary.org/obo/BFO_0000011</seealso>
    let spatiotemporal_region'BFO_0000011 = Prefixed_Name(cdao, "BFO_0000011") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"process"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000015">http://purl.obolibrary.org/obo/BFO_0000015</seealso>
    let Process'BFO_0000015 = Prefixed_Name(cdao, "BFO_0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"disposition"</para><para>"Disposition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000016">http://purl.obolibrary.org/obo/BFO_0000016</seealso>
    let disposition'BFO_0000016 = Prefixed_Name(cdao, "BFO_0000016") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000017</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"realizable entity"</para><para>"Realizable Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000017">http://purl.obolibrary.org/obo/BFO_0000017</seealso>
    let realizable_entity'BFO_0000017 = Prefixed_Name(cdao, "BFO_0000017") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zero-dimensional spatial region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000018">http://purl.obolibrary.org/obo/BFO_0000018</seealso>
    let zero_dimensional_spatial_region =
        Prefixed_Name(cdao, "BFO_0000018") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"quality"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000019">http://purl.obolibrary.org/obo/BFO_0000019</seealso>
    let Quality'BFO_0000019 = Prefixed_Name(cdao, "BFO_0000019") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Specifically Dependent Continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"specifically dependent continuant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000020">http://purl.obolibrary.org/obo/BFO_0000020</seealso>
    let Specifically_Dependent_Continuant =
        Prefixed_Name(cdao, "BFO_0000020") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000023</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"role"</para><para>"Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000023">http://purl.obolibrary.org/obo/BFO_0000023</seealso>
    let role'BFO_0000023 = Prefixed_Name(cdao, "BFO_0000023") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000024</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fiat object"</para><para>"fiat object part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000024">http://purl.obolibrary.org/obo/BFO_0000024</seealso>
    let fiat_object'BFO_0000024 = Prefixed_Name(cdao, "BFO_0000024") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000026</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"one-dimensional spatial region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000026">http://purl.obolibrary.org/obo/BFO_0000026</seealso>
    let one_dimensional_spatial_region =
        Prefixed_Name(cdao, "BFO_0000026") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000027</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object aggregate"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000027">http://purl.obolibrary.org/obo/BFO_0000027</seealso>
    let object_aggregate'BFO_0000027 = Prefixed_Name(cdao, "BFO_0000027") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000028</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"three-dimensional spatial region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000028">http://purl.obolibrary.org/obo/BFO_0000028</seealso>
    let three_dimensional_spatial_region =
        Prefixed_Name(cdao, "BFO_0000028") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Site"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"site"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000029">http://purl.obolibrary.org/obo/BFO_0000029</seealso>
    let Site'BFO_0000029 = Prefixed_Name(cdao, "BFO_0000029") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000030</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000030">http://purl.obolibrary.org/obo/BFO_0000030</seealso>
    let object'BFO_0000030 = Prefixed_Name(cdao, "BFO_0000030") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Generically Dependent Continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"generically dependent continuant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000031">http://purl.obolibrary.org/obo/BFO_0000031</seealso>
    let Generically_Dependent_Continuant =
        Prefixed_Name(cdao, "BFO_0000031") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"function"</para><para>"Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000034">http://purl.obolibrary.org/obo/BFO_0000034</seealso>
    let function_'BFO_0000034 = Prefixed_Name(cdao, "BFO_0000034") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000035</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process boundary"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000035">http://purl.obolibrary.org/obo/BFO_0000035</seealso>
    let process_boundary'BFO_0000035 = Prefixed_Name(cdao, "BFO_0000035") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"One-Dimensional Temporal Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"one-dimensional temporal region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000038">http://purl.obolibrary.org/obo/BFO_0000038</seealso>
    let One_Dimensional_Temporal_Region =
        Prefixed_Name(cdao, "BFO_0000038") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000040</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"material entity"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000040">http://purl.obolibrary.org/obo/BFO_0000040</seealso>
    let Material_Entity'BFO_0000040 = Prefixed_Name(cdao, "BFO_0000040") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"part of"</para><para>"part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000050">http://purl.obolibrary.org/obo/BFO_0000050</seealso>
    let part_of'BFO_0000050 = Prefixed_Name(cdao, "BFO_0000050") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has part"</para><para>"has part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000051">http://purl.obolibrary.org/obo/BFO_0000051</seealso>
    let has_part'BFO_0000051 = Prefixed_Name(cdao, "BFO_0000051") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Paraphrase of elucidation: a relation between a realizable entity and a process, where there is some material entity that is bearer of the realizable entity and participates in the process, and the realizable entity comes to be realized in the course of the process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realized in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"realized in"</para><para>"has realization"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000054">http://purl.obolibrary.org/obo/BFO_0000054</seealso>
    let realized_in'BFO_0000054 = Prefixed_Name(cdao, "BFO_0000054") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000055</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Paraphrase of elucidation: a relation between a process and a realizable entity, where there is some material entity that is bearer of the realizable entity and participates in the process, and the realizable entity comes to be realized in the course of the process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"realizes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000055">http://purl.obolibrary.org/obo/BFO_0000055</seealso>
    let realizes'BFO_0000055 = Prefixed_Name(cdao, "BFO_0000055") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"participates in"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000056">http://purl.obolibrary.org/obo/BFO_0000056</seealso>
    let participates_in'BFO_0000056 = Prefixed_Name(cdao, "BFO_0000056") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has participant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000057">http://purl.obolibrary.org/obo/BFO_0000057</seealso>
    let has_participant'BFO_0000057 = Prefixed_Name(cdao, "BFO_0000057") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is concretized by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000058">http://purl.obolibrary.org/obo/BFO_0000058</seealso>
    let is_concretized_by'BFO_0000058 = Prefixed_Name(cdao, "BFO_0000058") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"concretizes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000059">http://purl.obolibrary.org/obo/BFO_0000059</seealso>
    let concretizes'BFO_0000059 = Prefixed_Name(cdao, "BFO_0000059") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000062</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"preceded by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000062">http://purl.obolibrary.org/obo/BFO_0000062</seealso>
    let preceded_by'BFO_0000062 = Prefixed_Name(cdao, "BFO_0000062") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000063</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"precedes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000063">http://purl.obolibrary.org/obo/BFO_0000063</seealso>
    let precedes'BFO_0000063 = Prefixed_Name(cdao, "BFO_0000063") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Paraphrase of definition: a relation between a process and an independent continuant, in which the process takes place entirely within the independent continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occurs in"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000066">http://purl.obolibrary.org/obo/BFO_0000066</seealso>
    let occurs_in'BFO_0000066 = Prefixed_Name(cdao, "BFO_0000066") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000067</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Paraphrase of definition: a relation between an independent continuant and a process, in which the process takes place entirely within the independent continuant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"contains process"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000067">http://purl.obolibrary.org/obo/BFO_0000067</seealso>
    let contains_process'BFO_0000067 = Prefixed_Name(cdao, "BFO_0000067") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"generically depends on"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000084">http://purl.obolibrary.org/obo/BFO_0000084</seealso>
    let generically_depends_on'BFO_0000084 = Prefixed_Name(cdao, "BFO_0000084") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000101</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"is carrier of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000101">http://purl.obolibrary.org/obo/BFO_0000101</seealso>
    let is_carrier_of'BFO_0000101 = Prefixed_Name(cdao, "BFO_0000101") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000108</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"exists at"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000108">http://purl.obolibrary.org/obo/BFO_0000108</seealso>
    let exists_at'BFO_0000108 = Prefixed_Name(cdao, "BFO_0000108") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000115</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has member part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000115">http://purl.obolibrary.org/obo/BFO_0000115</seealso>
    let has_member_part'BFO_0000115 = Prefixed_Name(cdao, "BFO_0000115") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"has occurrent part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000117">http://purl.obolibrary.org/obo/BFO_0000117</seealso>
    let has_occurrent_part'BFO_0000117 = Prefixed_Name(cdao, "BFO_0000117") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has temporal part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000121">http://purl.obolibrary.org/obo/BFO_0000121</seealso>
    let has_temporal_part'BFO_0000121 = Prefixed_Name(cdao, "BFO_0000121") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000124</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"location of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000124">http://purl.obolibrary.org/obo/BFO_0000124</seealso>
    let location_of'BFO_0000124 = Prefixed_Name(cdao, "BFO_0000124") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000127</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"material basis of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000127">http://purl.obolibrary.org/obo/BFO_0000127</seealso>
    let material_basis_of'BFO_0000127 = Prefixed_Name(cdao, "BFO_0000127") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000129</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"member part of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000129">http://purl.obolibrary.org/obo/BFO_0000129</seealso>
    let member_part_of'BFO_0000129 = Prefixed_Name(cdao, "BFO_0000129") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000132</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"occurrent part of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000132">http://purl.obolibrary.org/obo/BFO_0000132</seealso>
    let occurrent_part_of'BFO_0000132 = Prefixed_Name(cdao, "BFO_0000132") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000134</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000134">http://purl.obolibrary.org/obo/BFO_0000134</seealso>
    let BFO_0000134'BFO_0000134 = Prefixed_Name(cdao, "BFO_0000134") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000139</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"temporal part of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000139">http://purl.obolibrary.org/obo/BFO_0000139</seealso>
    let temporal_part_of'BFO_0000139 = Prefixed_Name(cdao, "BFO_0000139") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"continuant fiat boundary"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000140">http://purl.obolibrary.org/obo/BFO_0000140</seealso>
    let continuant_fiat_boundary'BFO_0000140 = Prefixed_Name(cdao, "BFO_0000140") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immaterial entity"</para><para>"Immaterial Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000141">http://purl.obolibrary.org/obo/BFO_0000141</seealso>
    let immaterial_entity'BFO_0000141 = Prefixed_Name(cdao, "BFO_0000141") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fiat line"</para><para>"one-dimensional continuant fiat boundary"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000142">http://purl.obolibrary.org/obo/BFO_0000142</seealso>
    let fiat_line'BFO_0000142 = Prefixed_Name(cdao, "BFO_0000142") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000144</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"process profile"</para><para>"Process Profile"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000144">http://purl.obolibrary.org/obo/BFO_0000144</seealso>
    let process_profile'BFO_0000144 = Prefixed_Name(cdao, "BFO_0000144") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000145</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"relational quality"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000145">http://purl.obolibrary.org/obo/BFO_0000145</seealso>
    let relational_quality'BFO_0000145 = Prefixed_Name(cdao, "BFO_0000145") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"two-dimensional continuant fiat boundary"</para><para>"fiat surface"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000146">http://purl.obolibrary.org/obo/BFO_0000146</seealso>
    let two_dimensional_continuant_fiat_boundary =
        Prefixed_Name(cdao, "BFO_0000146") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000147</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"zero-dimensional continuant fiat boundary"</para><para>"fiat point"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000147">http://purl.obolibrary.org/obo/BFO_0000147</seealso>
    let zero_dimensional_continuant_fiat_boundary =
        Prefixed_Name(cdao, "BFO_0000147") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Zero-Dimensional Temporal Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"zero-dimensional temporal region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000148">http://purl.obolibrary.org/obo/BFO_0000148</seealso>
    let Zero_Dimensional_Temporal_Region =
        Prefixed_Name(cdao, "BFO_0000148") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000153</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"temporally projects onto"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000153">http://purl.obolibrary.org/obo/BFO_0000153</seealso>
    let temporally_projects_onto'BFO_0000153 = Prefixed_Name(cdao, "BFO_0000153") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"located in"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000171">http://purl.obolibrary.org/obo/BFO_0000171</seealso>
    let located_in'BFO_0000171 = Prefixed_Name(cdao, "BFO_0000171") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000176</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"continuant part of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000176">http://purl.obolibrary.org/obo/BFO_0000176</seealso>
    let continuant_part_of'BFO_0000176 = Prefixed_Name(cdao, "BFO_0000176") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000178</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has continuant part"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000178">http://purl.obolibrary.org/obo/BFO_0000178</seealso>
    let has_continuant_part'BFO_0000178 = Prefixed_Name(cdao, "BFO_0000178") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000179</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"BFO OWL specification label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000179">http://purl.obolibrary.org/obo/BFO_0000179</seealso>
    let BFO_OWL_specification_label'BFO_0000179 = Prefixed_Name(cdao, "BFO_0000179") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000180</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"BFO CLIF specification label"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000180">http://purl.obolibrary.org/obo/BFO_0000180</seealso>
    let BFO_CLIF_specification_label =
        Prefixed_Name(cdao, "BFO_0000180") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"history"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000182">http://purl.obolibrary.org/obo/BFO_0000182</seealso>
    let history'BFO_0000182 = Prefixed_Name(cdao, "BFO_0000182") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000183</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environs"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000183">http://purl.obolibrary.org/obo/BFO_0000183</seealso>
    let environs'BFO_0000183 = Prefixed_Name(cdao, "BFO_0000183") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000184</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"history of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000184">http://purl.obolibrary.org/obo/BFO_0000184</seealso>
    let history_of'BFO_0000184 = Prefixed_Name(cdao, "BFO_0000184") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000185</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has history"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000185">http://purl.obolibrary.org/obo/BFO_0000185</seealso>
    let has_history'BFO_0000185 = Prefixed_Name(cdao, "BFO_0000185") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000194</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifically depended on by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000194">http://purl.obolibrary.org/obo/BFO_0000194</seealso>
    let specifically_depended_on_by'BFO_0000194 = Prefixed_Name(cdao, "BFO_0000194") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000195</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"specifically depends on"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000195">http://purl.obolibrary.org/obo/BFO_0000195</seealso>
    let specifically_depends_on'BFO_0000195 = Prefixed_Name(cdao, "BFO_0000195") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bearer of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000196">http://purl.obolibrary.org/obo/BFO_0000196</seealso>
    let bearer_of'BFO_0000196 = Prefixed_Name(cdao, "BFO_0000196") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000197</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inheres in"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000197">http://purl.obolibrary.org/obo/BFO_0000197</seealso>
    let inheres_in'BFO_0000197 = Prefixed_Name(cdao, "BFO_0000197") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000199</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"occupies temporal region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000199">http://purl.obolibrary.org/obo/BFO_0000199</seealso>
    let occupies_temporal_region'BFO_0000199 = Prefixed_Name(cdao, "BFO_0000199") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000200</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"occupies spatiotemporal region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000200">http://purl.obolibrary.org/obo/BFO_0000200</seealso>
    let occupies_spatiotemporal_region =
        Prefixed_Name(cdao, "BFO_0000200") |> PrefixedName

    /// <summary>
    ///   <para>cdao:BFO_0000202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temporal interval"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000202">http://purl.obolibrary.org/obo/BFO_0000202</seealso>
    let temporal_interval'BFO_0000202 = Prefixed_Name(cdao, "BFO_0000202") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temporal instant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000203">http://purl.obolibrary.org/obo/BFO_0000203</seealso>
    let temporal_instant'BFO_0000203 = Prefixed_Name(cdao, "BFO_0000203") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000210</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"occupies spatial region"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000210">http://purl.obolibrary.org/obo/BFO_0000210</seealso>
    let occupies_spatial_region'BFO_0000210 = Prefixed_Name(cdao, "BFO_0000210") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000216</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"spatially projects onto"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000216">http://purl.obolibrary.org/obo/BFO_0000216</seealso>
    let spatially_projects_onto'BFO_0000216 = Prefixed_Name(cdao, "BFO_0000216") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000218</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has material basis"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000218">http://purl.obolibrary.org/obo/BFO_0000218</seealso>
    let has_material_basis'BFO_0000218 = Prefixed_Name(cdao, "BFO_0000218") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000221</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"first instant of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000221">http://purl.obolibrary.org/obo/BFO_0000221</seealso>
    let first_instant_of'BFO_0000221 = Prefixed_Name(cdao, "BFO_0000221") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has first instant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000222">http://purl.obolibrary.org/obo/BFO_0000222</seealso>
    let has_first_instant'BFO_0000222 = Prefixed_Name(cdao, "BFO_0000222") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"last instant of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000223">http://purl.obolibrary.org/obo/BFO_0000223</seealso>
    let last_instant_of'BFO_0000223 = Prefixed_Name(cdao, "BFO_0000223") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BFO_0000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has last instant"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BFO_0000224">http://purl.obolibrary.org/obo/BFO_0000224</seealso>
    let has_last_instant'BFO_0000224 = Prefixed_Name(cdao, "BFO_0000224") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BILA_0000027</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BILA_0000027">http://purl.obolibrary.org/obo/BILA_0000027</seealso>
    let BILA_0000027'BILA_0000027 = Prefixed_Name(cdao, "BILA_0000027") |> PrefixedName
    /// <summary>
    ///   <para>cdao:BILA_0000028</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/BILA_0000028">http://purl.obolibrary.org/obo/BILA_0000028</seealso>
    let BILA_0000028'BILA_0000028 = Prefixed_Name(cdao, "BILA_0000028") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell line cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0000001">http://purl.obolibrary.org/obo/CLO_0000001</seealso>
    let cell_line_cell'CLO_0000001 = Prefixed_Name(cdao, "CLO_0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mortal cell line cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0000018">http://purl.obolibrary.org/obo/CLO_0000018</seealso>
    let mortal_cell_line_cell'CLO_0000018 = Prefixed_Name(cdao, "CLO_0000018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0000019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immortal cell line cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0000019">http://purl.obolibrary.org/obo/CLO_0000019</seealso>
    let immortal_cell_line_cell'CLO_0000019 = Prefixed_Name(cdao, "CLO_0000019") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell line"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0000031">http://purl.obolibrary.org/obo/CLO_0000031</seealso>
    let cell_line'CLO_0000031 = Prefixed_Name(cdao, "CLO_0000031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0009828</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"immortal cell line"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0009828">http://purl.obolibrary.org/obo/CLO_0009828</seealso>
    let immortal_cell_line'CLO_0009828 = Prefixed_Name(cdao, "CLO_0009828") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CLO_0009829</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mortal cell line"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CLO_0009829">http://purl.obolibrary.org/obo/CLO_0009829</seealso>
    let mortal_cell_line'CLO_0009829 = Prefixed_Name(cdao, "CLO_0009829") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"cell"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000000">http://purl.obolibrary.org/obo/CL_0000000</seealso>
    let cell'CL_0000000 = Prefixed_Name(cdao, "CL_0000000") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"primary cultured cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000001">http://purl.obolibrary.org/obo/CL_0000001</seealso>
    let primary_cultured_cell'CL_0000001 = Prefixed_Name(cdao, "CL_0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000002">http://purl.obolibrary.org/obo/CL_0000002</seealso>
    let CL_0000002'CL_0000002 = Prefixed_Name(cdao, "CL_0000002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"native cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000003">http://purl.obolibrary.org/obo/CL_0000003</seealso>
    let native_cell'CL_0000003 = Prefixed_Name(cdao, "CL_0000003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000010</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cultured cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000010">http://purl.obolibrary.org/obo/CL_0000010</seealso>
    let cultured_cell'CL_0000010 = Prefixed_Name(cdao, "CL_0000010") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fibroblast"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000057">http://purl.obolibrary.org/obo/CL_0000057</seealso>
    let fibroblast'CL_0000057 = Prefixed_Name(cdao, "CL_0000057") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000066</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"epithelial cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000066">http://purl.obolibrary.org/obo/CL_0000066</seealso>
    let epithelial_cell'CL_0000066 = Prefixed_Name(cdao, "CL_0000066") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000084</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000084">http://purl.obolibrary.org/obo/CL_0000084</seealso>
    let T_cell'CL_0000084 = Prefixed_Name(cdao, "CL_0000084") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000097</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mast cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000097">http://purl.obolibrary.org/obo/CL_0000097</seealso>
    let mast_cell'CL_0000097 = Prefixed_Name(cdao, "CL_0000097") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hepatocyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000182">http://purl.obolibrary.org/obo/CL_0000182</seealso>
    let hepatocyte'CL_0000182 = Prefixed_Name(cdao, "CL_0000182") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000232</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"erythrocyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000232">http://purl.obolibrary.org/obo/CL_0000232</seealso>
    let erythrocyte'CL_0000232 = Prefixed_Name(cdao, "CL_0000232") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000235</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"macrophage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000235">http://purl.obolibrary.org/obo/CL_0000235</seealso>
    let macrophage'CL_0000235 = Prefixed_Name(cdao, "CL_0000235") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000236</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"B cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000236">http://purl.obolibrary.org/obo/CL_0000236</seealso>
    let B_cell'CL_0000236 = Prefixed_Name(cdao, "CL_0000236") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000451</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dendritic cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000451">http://purl.obolibrary.org/obo/CL_0000451</seealso>
    let dendritic_cell'CL_0000451 = Prefixed_Name(cdao, "CL_0000451") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000542</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lymphocyte"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000542">http://purl.obolibrary.org/obo/CL_0000542</seealso>
    let lymphocyte'CL_0000542 = Prefixed_Name(cdao, "CL_0000542") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000578</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"experimentally modified cell in vitro"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000578">http://purl.obolibrary.org/obo/CL_0000578</seealso>
    let experimentally_modified_cell_in_vitro =
        Prefixed_Name(cdao, "CL_0000578") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000624</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CD4-positive, alpha-beta T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000624">http://purl.obolibrary.org/obo/CL_0000624</seealso>
    let ``CD4_positive,_alpha_beta_T_cell`` =
        Prefixed_Name(cdao, "CL_0000624") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000625</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CD8-positive, alpha-beta T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000625">http://purl.obolibrary.org/obo/CL_0000625</seealso>
    let ``CD8_positive,_alpha_beta_T_cell`` =
        Prefixed_Name(cdao, "CL_0000625") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000767</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"basophil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000767">http://purl.obolibrary.org/obo/CL_0000767</seealso>
    let basophil'CL_0000767 = Prefixed_Name(cdao, "CL_0000767") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"plasma cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000786">http://purl.obolibrary.org/obo/CL_0000786</seealso>
    let plasma_cell'CL_0000786 = Prefixed_Name(cdao, "CL_0000786") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alpha-beta T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000789">http://purl.obolibrary.org/obo/CL_0000789</seealso>
    let alpha_beta_T_cell'CL_0000789 = Prefixed_Name(cdao, "CL_0000789") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000794</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CD8-positive, alpha-beta cytotoxic T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000794">http://purl.obolibrary.org/obo/CL_0000794</seealso>
    let ``CD8_positive,_alpha_beta_cytotoxic_T_cell`` =
        Prefixed_Name(cdao, "CL_0000794") |> PrefixedName

    /// <summary>
    ///   <para>cdao:CL_0000814</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mature NK T cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000814">http://purl.obolibrary.org/obo/CL_0000814</seealso>
    let mature_NK_T_cell'CL_0000814 = Prefixed_Name(cdao, "CL_0000814") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0000842</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mononuclear cell"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0000842">http://purl.obolibrary.org/obo/CL_0000842</seealso>
    let mononuclear_cell'CL_0000842 = Prefixed_Name(cdao, "CL_0000842") |> PrefixedName
    /// <summary>
    ///   <para>cdao:CL_0007014</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/CL_0007014">http://purl.obolibrary.org/obo/CL_0007014</seealso>
    let CL_0007014'CL_0007014 = Prefixed_Name(cdao, "CL_0007014") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00000446</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00000446">http://purl.obolibrary.org/obo/ENVO_00000446</seealso>
    let ENVO_00000446'ENVO_00000446 = Prefixed_Name(cdao, "ENVO_00000446") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00001998</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"soil"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00001998">http://purl.obolibrary.org/obo/ENVO_00001998</seealso>
    let soil'ENVO_00001998 = Prefixed_Name(cdao, "ENVO_00001998") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00002011</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00002011">http://purl.obolibrary.org/obo/ENVO_00002011</seealso>
    let ENVO_00002011'ENVO_00002011 = Prefixed_Name(cdao, "ENVO_00002011") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00002019</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00002019">http://purl.obolibrary.org/obo/ENVO_00002019</seealso>
    let ENVO_00002019'ENVO_00002019 = Prefixed_Name(cdao, "ENVO_00002019") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00002149</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00002149">http://purl.obolibrary.org/obo/ENVO_00002149</seealso>
    let ENVO_00002149'ENVO_00002149 = Prefixed_Name(cdao, "ENVO_00002149") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00002257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"podzol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00002257">http://purl.obolibrary.org/obo/ENVO_00002257</seealso>
    let podzol'ENVO_00002257 = Prefixed_Name(cdao, "ENVO_00002257") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_00010483</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environmental material"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_00010483">http://purl.obolibrary.org/obo/ENVO_00010483</seealso>
    let environmental_material'ENVO_00010483 = Prefixed_Name(cdao, "ENVO_00010483") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ENVO_01000320</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ENVO_01000320">http://purl.obolibrary.org/obo/ENVO_01000320</seealso>
    let ENVO_01000320'ENVO_01000320 = Prefixed_Name(cdao, "ENVO_01000320") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"See OBI listserv discussion for considerations in defining instrument. http://sourceforge.net/tracker/index.php?func=detail&amp;aid=2894801&amp;group_id=177891&amp;atid=886178"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Instrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000004">http://purl.obolibrary.org/obo/ERO_0000004</seealso>
    let Instrument'ERO_0000004 = Prefixed_Name(cdao, "ERO_0000004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000005</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF. NIF ID: nlx_res_20090105"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000005">http://purl.obolibrary.org/obo/ERO_0000005</seealso>
    let Service'ERO_0000005 = Prefixed_Name(cdao, "ERO_0000005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000006</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Placeholder for class to be imported from the Reagent Ontology (ReO)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reagent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000006">http://purl.obolibrary.org/obo/ERO_0000006</seealso>
    let Reagent'ERO_0000006 = Prefixed_Name(cdao, "ERO_0000006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000007</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Protocol is added to eagle-i temporarily until a relationship between the informatio entity "protocol" and these planned processes is created. This class refers to the axtual process not the document"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Technique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000007">http://purl.obolibrary.org/obo/ERO_0000007</seealso>
    let Technique'ERO_0000007 = Prefixed_Name(cdao, "ERO_0000007") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Service Provider Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000012">http://purl.obolibrary.org/obo/ERO_0000012</seealso>
    let Service_Provider_Role'ERO_0000012 = Prefixed_Name(cdao, "ERO_0000012") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000014</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Maybe SameAs "Investigation" but is the subject of funding"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Research Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000014">http://purl.obolibrary.org/obo/ERO_0000014</seealso>
    let Research_Project'ERO_0000014 = Prefixed_Name(cdao, "ERO_0000014") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This should be imported from OCRE- but they currently have no generic human study type. Def is modified."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Human Study"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000015">http://purl.obolibrary.org/obo/ERO_0000015</seealso>
    let Human_Study'ERO_0000015 = Prefixed_Name(cdao, "ERO_0000015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000016</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Clinical Trial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000016">http://purl.obolibrary.org/obo/ERO_0000016</seealso>
    let Clinical_Trial'ERO_0000016 = Prefixed_Name(cdao, "ERO_0000016") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Should have relationship to Organism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Biological Specimen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000020">http://purl.obolibrary.org/obo/ERO_0000020</seealso>
    let Biological_Specimen'ERO_0000020 = Prefixed_Name(cdao, "ERO_0000020") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000029</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"change the domain tye to access service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"provides access to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000029">http://purl.obolibrary.org/obo/ERO_0000029</seealso>
    let provides_access_to'ERO_0000029 = Prefixed_Name(cdao, "ERO_0000029") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000031</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Here there are things to be fixed (for instance a service can use a technique...)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000031">http://purl.obolibrary.org/obo/ERO_0000031</seealso>
    let uses'ERO_0000031 = Prefixed_Name(cdao, "ERO_0000031") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has expertise in technique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000033">http://purl.obolibrary.org/obo/ERO_0000033</seealso>
    let has_expertise_in_technique'ERO_0000033 = Prefixed_Name(cdao, "ERO_0000033") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000034</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"manufacturer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000034">http://purl.obolibrary.org/obo/ERO_0000034</seealso>
    let manufacturer'ERO_0000034 = Prefixed_Name(cdao, "ERO_0000034") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0000037</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contact or provider for service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000037">http://purl.obolibrary.org/obo/ERO_0000037</seealso>
    let contact_or_provider_for_service =
        Prefixed_Name(cdao, "ERO_0000037") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0000038</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"specifies the use of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000038">http://purl.obolibrary.org/obo/ERO_0000038</seealso>
    let specifies_the_use_of'ERO_0000038 = Prefixed_Name(cdao, "ERO_0000038") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000044</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"inventory number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000044">http://purl.obolibrary.org/obo/ERO_0000044</seealso>
    let inventory_number'ERO_0000044 = Prefixed_Name(cdao, "ERO_0000044") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000045</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000045">http://purl.obolibrary.org/obo/ERO_0000045</seealso>
    let has_restriction'ERO_0000045 = Prefixed_Name(cdao, "ERO_0000045") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000046</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has geographic restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000046">http://purl.obolibrary.org/obo/ERO_0000046</seealso>
    let has_geographic_restriction'ERO_0000046 = Prefixed_Name(cdao, "ERO_0000046") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000050</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"model number"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000050">http://purl.obolibrary.org/obo/ERO_0000050</seealso>
    let model_number'ERO_0000050 = Prefixed_Name(cdao, "ERO_0000050") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000054</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"lab data format"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000054">http://purl.obolibrary.org/obo/ERO_0000054</seealso>
    let lab_data_format'ERO_0000054 = Prefixed_Name(cdao, "ERO_0000054") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000070</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"used by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000070">http://purl.obolibrary.org/obo/ERO_0000070</seealso>
    let used_by'ERO_0000070 = Prefixed_Name(cdao, "ERO_0000070") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000071</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"IAO is a planned specification, in SWO is an Information artifact. In eagle-i, we have a need to collect material instances and is it thus currently classified as a material entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000071">http://purl.obolibrary.org/obo/ERO_0000071</seealso>
    let Software'ERO_0000071 = Prefixed_Name(cdao, "ERO_0000071") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000072">http://purl.obolibrary.org/obo/ERO_0000072</seealso>
    let version'ERO_0000072 = Prefixed_Name(cdao, "ERO_0000072") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Funding Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000224">http://purl.obolibrary.org/obo/ERO_0000224</seealso>
    let Funding_Role'ERO_0000224 = Prefixed_Name(cdao, "ERO_0000224") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000225</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Educator Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000225">http://purl.obolibrary.org/obo/ERO_0000225</seealso>
    let Educator_Role'ERO_0000225 = Prefixed_Name(cdao, "ERO_0000225") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000390</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"service provided by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000390">http://purl.obolibrary.org/obo/ERO_0000390</seealso>
    let service_provided_by'ERO_0000390 = Prefixed_Name(cdao, "ERO_0000390") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000391</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Access Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000391">http://purl.obolibrary.org/obo/ERO_0000391</seealso>
    let Access_Service'ERO_0000391 = Prefixed_Name(cdao, "ERO_0000391") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000392</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"coordinate with NIF. NIF ID:nlx_res_20090419"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Storage Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000392">http://purl.obolibrary.org/obo/ERO_0000392</seealso>
    let Storage_Service'ERO_0000392 = Prefixed_Name(cdao, "ERO_0000392") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF. NIF ID: nlx_res_20090444"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Training Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000393">http://purl.obolibrary.org/obo/ERO_0000393</seealso>
    let Training_Service'ERO_0000393 = Prefixed_Name(cdao, "ERO_0000393") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000394</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF: NIF ID: nlx_res_20090416"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material Processing Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000394">http://purl.obolibrary.org/obo/ERO_0000394</seealso>
    let Material_Processing_Service'ERO_0000394 = Prefixed_Name(cdao, "ERO_0000394") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000395</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF: NIF ID: nlx_res_20090420"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material Analysis Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000395">http://purl.obolibrary.org/obo/ERO_0000395</seealso>
    let Material_Analysis_Service'ERO_0000395 = Prefixed_Name(cdao, "ERO_0000395") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000396</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Coordinate with NIF. NIF ID: nlx_res_20090418"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Material Production Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000396">http://purl.obolibrary.org/obo/ERO_0000396</seealso>
    let Material_Production_Service'ERO_0000396 = Prefixed_Name(cdao, "ERO_0000396") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000397</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performs technique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000397">http://purl.obolibrary.org/obo/ERO_0000397</seealso>
    let performs_technique'ERO_0000397 = Prefixed_Name(cdao, "ERO_0000397") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000398</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is performed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000398">http://purl.obolibrary.org/obo/ERO_0000398</seealso>
    let is_performed_by'ERO_0000398 = Prefixed_Name(cdao, "ERO_0000398") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000424</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has study population"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000424">http://purl.obolibrary.org/obo/ERO_0000424</seealso>
    let has_study_population'ERO_0000424 = Prefixed_Name(cdao, "ERO_0000424") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000460</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000460">http://purl.obolibrary.org/obo/ERO_0000460</seealso>
    let has_documentation'ERO_0000460 = Prefixed_Name(cdao, "ERO_0000460") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000481</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"placeholder: need to be modeled for the proper kind of service (production services)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"realizes protocol"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000481">http://purl.obolibrary.org/obo/ERO_0000481</seealso>
    let realizes_protocol'ERO_0000481 = Prefixed_Name(cdao, "ERO_0000481") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000482</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Placeholder needs to be redesign"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"uses software"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000482">http://purl.obolibrary.org/obo/ERO_0000482</seealso>
    let uses_software'ERO_0000482 = Prefixed_Name(cdao, "ERO_0000482") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000543</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"related technique"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000543">http://purl.obolibrary.org/obo/ERO_0000543</seealso>
    let related_technique'ERO_0000543 = Prefixed_Name(cdao, "ERO_0000543") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Technology Transfer Office"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000565">http://purl.obolibrary.org/obo/ERO_0000565</seealso>
    let Technology_Transfer_Office'ERO_0000565 = Prefixed_Name(cdao, "ERO_0000565") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000572</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"used to study"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000572">http://purl.obolibrary.org/obo/ERO_0000572</seealso>
    let used_to_study'ERO_0000572 = Prefixed_Name(cdao, "ERO_0000572") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000595</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Research Opportunity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000595">http://purl.obolibrary.org/obo/ERO_0000595</seealso>
    let Research_Opportunity'ERO_0000595 = Prefixed_Name(cdao, "ERO_0000595") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000774</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has eligibility requirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000774">http://purl.obolibrary.org/obo/ERO_0000774</seealso>
    let has_eligibility_requirement'ERO_0000774 = Prefixed_Name(cdao, "ERO_0000774") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000775</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has residency requirement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000775">http://purl.obolibrary.org/obo/ERO_0000775</seealso>
    let has_residency_requirement'ERO_0000775 = Prefixed_Name(cdao, "ERO_0000775") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000776</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"US Resident Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000776">http://purl.obolibrary.org/obo/ERO_0000776</seealso>
    let US_Resident_Role'ERO_0000776 = Prefixed_Name(cdao, "ERO_0000776") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000777</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"US Citizen Role"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000777">http://purl.obolibrary.org/obo/ERO_0000777</seealso>
    let US_Citizen_Role'ERO_0000777 = Prefixed_Name(cdao, "ERO_0000777") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000778</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non-US Citizen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000778">http://purl.obolibrary.org/obo/ERO_0000778</seealso>
    let Non_US_Citizen'ERO_0000778 = Prefixed_Name(cdao, "ERO_0000778") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000779</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Permanent Resident Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000779">http://purl.obolibrary.org/obo/ERO_0000779</seealso>
    let Permanent_Resident_Role'ERO_0000779 = Prefixed_Name(cdao, "ERO_0000779") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000780</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Non-Permanent Resident Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000780">http://purl.obolibrary.org/obo/ERO_0000780</seealso>
    let Non_Permanent_Resident_Role'ERO_0000780 = Prefixed_Name(cdao, "ERO_0000780") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000783</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Student Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000783">http://purl.obolibrary.org/obo/ERO_0000783</seealso>
    let Student_Role'ERO_0000783 = Prefixed_Name(cdao, "ERO_0000783") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000784</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Undergraduate Student Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000784">http://purl.obolibrary.org/obo/ERO_0000784</seealso>
    let Undergraduate_Student_Role'ERO_0000784 = Prefixed_Name(cdao, "ERO_0000784") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000785</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Graduate Student Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000785">http://purl.obolibrary.org/obo/ERO_0000785</seealso>
    let Graduate_Student_Role'ERO_0000785 = Prefixed_Name(cdao, "ERO_0000785") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000786</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"High School Student Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000786">http://purl.obolibrary.org/obo/ERO_0000786</seealso>
    let High_School_Student_Role'ERO_0000786 = Prefixed_Name(cdao, "ERO_0000786") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000787</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Employee Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000787">http://purl.obolibrary.org/obo/ERO_0000787</seealso>
    let Employee_Role'ERO_0000787 = Prefixed_Name(cdao, "ERO_0000787") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000788</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Faculty Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000788">http://purl.obolibrary.org/obo/ERO_0000788</seealso>
    let Faculty_Role'ERO_0000788 = Prefixed_Name(cdao, "ERO_0000788") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000789</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Staff Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000789">http://purl.obolibrary.org/obo/ERO_0000789</seealso>
    let Staff_Role'ERO_0000789 = Prefixed_Name(cdao, "ERO_0000789") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000790</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post-Baccalaureate Trainee"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000790">http://purl.obolibrary.org/obo/ERO_0000790</seealso>
    let Post_Baccalaureate_Trainee'ERO_0000790 = Prefixed_Name(cdao, "ERO_0000790") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0000914</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Post-Graduate Student Trainee Role"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000914">http://purl.obolibrary.org/obo/ERO_0000914</seealso>
    let Post_Graduate_Student_Trainee_Role =
        Prefixed_Name(cdao, "ERO_0000914") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0000918</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"related research project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000918">http://purl.obolibrary.org/obo/ERO_0000918</seealso>
    let related_research_project'ERO_0000918 = Prefixed_Name(cdao, "ERO_0000918") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0000919</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"related biological specimen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0000919">http://purl.obolibrary.org/obo/ERO_0000919</seealso>
    let related_biological_specimen'ERO_0000919 = Prefixed_Name(cdao, "ERO_0000919") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001245</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Licensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001245">http://purl.obolibrary.org/obo/ERO_0001245</seealso>
    let Licensing'ERO_0001245 = Prefixed_Name(cdao, "ERO_0001245") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001254</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Transport Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001254">http://purl.obolibrary.org/obo/ERO_0001254</seealso>
    let Transport_Service'ERO_0001254 = Prefixed_Name(cdao, "ERO_0001254") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001255</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Support Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001255">http://purl.obolibrary.org/obo/ERO_0001255</seealso>
    let Support_Service'ERO_0001255 = Prefixed_Name(cdao, "ERO_0001255") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Storage Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001256">http://purl.obolibrary.org/obo/ERO_0001256</seealso>
    let Material_Storage_Service'ERO_0001256 = Prefixed_Name(cdao, "ERO_0001256") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001257</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Storage Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001257">http://purl.obolibrary.org/obo/ERO_0001257</seealso>
    let Data_Storage_Service'ERO_0001257 = Prefixed_Name(cdao, "ERO_0001257") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001258</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Maintenance Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001258">http://purl.obolibrary.org/obo/ERO_0001258</seealso>
    let Maintenance_Service'ERO_0001258 = Prefixed_Name(cdao, "ERO_0001258") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0001259</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Maintenance Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001259">http://purl.obolibrary.org/obo/ERO_0001259</seealso>
    let Material_Maintenance_Service =
        Prefixed_Name(cdao, "ERO_0001259") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0001260</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Maintenance Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001260">http://purl.obolibrary.org/obo/ERO_0001260</seealso>
    let Data_Maintenance_Service'ERO_0001260 = Prefixed_Name(cdao, "ERO_0001260") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001261</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Analysis Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001261">http://purl.obolibrary.org/obo/ERO_0001261</seealso>
    let Analysis_Service'ERO_0001261 = Prefixed_Name(cdao, "ERO_0001261") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001262</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Data Analysis Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001262">http://purl.obolibrary.org/obo/ERO_0001262</seealso>
    let Data_Analysis_Service'ERO_0001262 = Prefixed_Name(cdao, "ERO_0001262") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0001263</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Material Modification Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001263">http://purl.obolibrary.org/obo/ERO_0001263</seealso>
    let Material_Modification_Service =
        Prefixed_Name(cdao, "ERO_0001263") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ERO_0001518</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has phase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001518">http://purl.obolibrary.org/obo/ERO_0001518</seealso>
    let has_phase'ERO_0001518 = Prefixed_Name(cdao, "ERO_0001518") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001520</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performs human study"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001520">http://purl.obolibrary.org/obo/ERO_0001520</seealso>
    let performs_human_study'ERO_0001520 = Prefixed_Name(cdao, "ERO_0001520") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001521</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"performed by organization"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001521">http://purl.obolibrary.org/obo/ERO_0001521</seealso>
    let performed_by_organization'ERO_0001521 = Prefixed_Name(cdao, "ERO_0001521") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ERO_0001716</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Just a place horder. It will probably be replaced by NIF term: http://ontology.neuinfo.org/NIF/DigitalEntities/NIF-Resource.owl#nlx_res_20090405"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Database"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ERO_0001716">http://purl.obolibrary.org/obo/ERO_0001716</seealso>
    let Database'ERO_0001716 = Prefixed_Name(cdao, "ERO_0001716") |> PrefixedName

    /// <summary>
    ///   <para>cdao:HP_0000009</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Functional abnormality of the bladder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0000009">http://purl.obolibrary.org/obo/HP_0000009</seealso>
    let Functional_abnormality_of_the_bladder =
        Prefixed_Name(cdao, "HP_0000009") |> PrefixedName

    /// <summary>
    ///   <para>cdao:HP_0000855</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Insulin resistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0000855">http://purl.obolibrary.org/obo/HP_0000855</seealso>
    let Insulin_resistance'HP_0000855 = Prefixed_Name(cdao, "HP_0000855") |> PrefixedName
    /// <summary>
    ///   <para>cdao:HP_0012088</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Abnormal urinary odor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0012088">http://purl.obolibrary.org/obo/HP_0012088</seealso>
    let Abnormal_urinary_odor'HP_0012088 = Prefixed_Name(cdao, "HP_0012088") |> PrefixedName
    /// <summary>
    ///   <para>cdao:HP_0025142</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Constitutional symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0025142">http://purl.obolibrary.org/obo/HP_0025142</seealso>
    let Constitutional_symptom'HP_0025142 = Prefixed_Name(cdao, "HP_0025142") |> PrefixedName

    /// <summary>
    ///   <para>cdao:HP_0033072</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Abnormal macroscopic urine appearance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0033072">http://purl.obolibrary.org/obo/HP_0033072</seealso>
    let Abnormal_macroscopic_urine_appearance =
        Prefixed_Name(cdao, "HP_0033072") |> PrefixedName

    /// <summary>
    ///   <para>cdao:HP_0100515</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pollakisuria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0100515">http://purl.obolibrary.org/obo/HP_0100515</seealso>
    let Pollakisuria'HP_0100515 = Prefixed_Name(cdao, "HP_0100515") |> PrefixedName
    /// <summary>
    ///   <para>cdao:HP_0100749</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Chest pain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/HP_0100749">http://purl.obolibrary.org/obo/HP_0100749</seealso>
    let Chest_pain'HP_0100749 = Prefixed_Name(cdao, "HP_0100749") |> PrefixedName
    /// <summary>
    ///   <para>cdao:IDO_0000586</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"infection"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IDO_0000586">http://purl.obolibrary.org/obo/IDO_0000586</seealso>
    let infection'IDO_0000586 = Prefixed_Name(cdao, "IDO_0000586") |> PrefixedName

    /// <summary>
    ///   <para>cdao:IDO_0000666</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"human pathogenicity disposition"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/IDO_0000666">http://purl.obolibrary.org/obo/IDO_0000666</seealso>
    let human_pathogenicity_disposition =
        Prefixed_Name(cdao, "IDO_0000666") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0000011</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"age"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000011">http://purl.obolibrary.org/obo/PATO_0000011</seealso>
    let age'PATO_0000011 = Prefixed_Name(cdao, "PATO_0000011") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fluorescence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000018">http://purl.obolibrary.org/obo/PATO_0000018</seealso>
    let fluorescence'PATO_0000018 = Prefixed_Name(cdao, "PATO_0000018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"composition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000025">http://purl.obolibrary.org/obo/PATO_0000025</seealso>
    let composition'PATO_0000025 = Prefixed_Name(cdao, "PATO_0000025") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000033</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"concentration of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000033">http://purl.obolibrary.org/obo/PATO_0000033</seealso>
    let concentration_of'PATO_0000033 = Prefixed_Name(cdao, "PATO_0000033") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000047</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biological sex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000047">http://purl.obolibrary.org/obo/PATO_0000047</seealso>
    let biological_sex'PATO_0000047 = Prefixed_Name(cdao, "PATO_0000047") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000051</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"morphology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000051">http://purl.obolibrary.org/obo/PATO_0000051</seealso>
    let morphology'PATO_0000051 = Prefixed_Name(cdao, "PATO_0000051") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000117</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000117">http://purl.obolibrary.org/obo/PATO_0000117</seealso>
    let size'PATO_0000117 = Prefixed_Name(cdao, "PATO_0000117") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"length"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000122">http://purl.obolibrary.org/obo/PATO_0000122</seealso>
    let length'PATO_0000122 = Prefixed_Name(cdao, "PATO_0000122") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000125</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000125">http://purl.obolibrary.org/obo/PATO_0000125</seealso>
    let mass'PATO_0000125 = Prefixed_Name(cdao, "PATO_0000125") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000140</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000140">http://purl.obolibrary.org/obo/PATO_0000140</seealso>
    let position'PATO_0000140 = Prefixed_Name(cdao, "PATO_0000140") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000141</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"structure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000141">http://purl.obolibrary.org/obo/PATO_0000141</seealso>
    let structure'PATO_0000141 = Prefixed_Name(cdao, "PATO_0000141") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000146</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"temperature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000146">http://purl.obolibrary.org/obo/PATO_0000146</seealso>
    let temperature'PATO_0000146 = Prefixed_Name(cdao, "PATO_0000146") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000165</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000165">http://purl.obolibrary.org/obo/PATO_0000165</seealso>
    let time'PATO_0000165 = Prefixed_Name(cdao, "PATO_0000165") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"viability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000169">http://purl.obolibrary.org/obo/PATO_0000169</seealso>
    let viability'PATO_0000169 = Prefixed_Name(cdao, "PATO_0000169") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000186</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"behavioral quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000186">http://purl.obolibrary.org/obo/PATO_0000186</seealso>
    let behavioral_quality'PATO_0000186 = Prefixed_Name(cdao, "PATO_0000186") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000383</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"female"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000383">http://purl.obolibrary.org/obo/PATO_0000383</seealso>
    let female'PATO_0000383 = Prefixed_Name(cdao, "PATO_0000383") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"male"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000384">http://purl.obolibrary.org/obo/PATO_0000384</seealso>
    let male'PATO_0000384 = Prefixed_Name(cdao, "PATO_0000384") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0000918</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"volume"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0000918">http://purl.obolibrary.org/obo/PATO_0000918</seealso>
    let volume'PATO_0000918 = Prefixed_Name(cdao, "PATO_0000918") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001018">http://purl.obolibrary.org/obo/PATO_0001018</seealso>
    let physical_quality'PATO_0001018 = Prefixed_Name(cdao, "PATO_0001018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001020</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"damage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001020">http://purl.obolibrary.org/obo/PATO_0001020</seealso>
    let damage'PATO_0001020 = Prefixed_Name(cdao, "PATO_0001020") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pressure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001025">http://purl.obolibrary.org/obo/PATO_0001025</seealso>
    let pressure'PATO_0001025 = Prefixed_Name(cdao, "PATO_0001025") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001161</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diluted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001161">http://purl.obolibrary.org/obo/PATO_0001161</seealso>
    let diluted'PATO_0001161 = Prefixed_Name(cdao, "PATO_0001161") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001167</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"damaged"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001167">http://purl.obolibrary.org/obo/PATO_0001167</seealso>
    let damaged'PATO_0001167 = Prefixed_Name(cdao, "PATO_0001167") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001193</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"lateral to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001193">http://purl.obolibrary.org/obo/PATO_0001193</seealso>
    let lateral_to'PATO_0001193 = Prefixed_Name(cdao, "PATO_0001193") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001196</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ventral to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001196">http://purl.obolibrary.org/obo/PATO_0001196</seealso>
    let ventral_to'PATO_0001196 = Prefixed_Name(cdao, "PATO_0001196") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dorsal to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001233">http://purl.obolibrary.org/obo/PATO_0001233</seealso>
    let dorsal_to'PATO_0001233 = Prefixed_Name(cdao, "PATO_0001233") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001241</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"physical object quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001241">http://purl.obolibrary.org/obo/PATO_0001241</seealso>
    let physical_object_quality'PATO_0001241 = Prefixed_Name(cdao, "PATO_0001241") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001291</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"electromagnetic (EM) radiation quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001291">http://purl.obolibrary.org/obo/PATO_0001291</seealso>
    let ``electromagnetic_(EM)_radiation_quality`` =
        Prefixed_Name(cdao, "PATO_0001291") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001296</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"luminous flux"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001296">http://purl.obolibrary.org/obo/PATO_0001296</seealso>
    let luminous_flux'PATO_0001296 = Prefixed_Name(cdao, "PATO_0001296") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001300</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"optical quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001300">http://purl.obolibrary.org/obo/PATO_0001300</seealso>
    let optical_quality'PATO_0001300 = Prefixed_Name(cdao, "PATO_0001300") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001335</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bacterial mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001335">http://purl.obolibrary.org/obo/PATO_0001335</seealso>
    let bacterial_mating_type'PATO_0001335 = Prefixed_Name(cdao, "PATO_0001335") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001337</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"yeast mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001337">http://purl.obolibrary.org/obo/PATO_0001337</seealso>
    let yeast_mating_type'PATO_0001337 = Prefixed_Name(cdao, "PATO_0001337") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001338</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mixed sex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001338">http://purl.obolibrary.org/obo/PATO_0001338</seealso>
    let mixed_sex'PATO_0001338 = Prefixed_Name(cdao, "PATO_0001338") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001339</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"biomaterial purity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001339">http://purl.obolibrary.org/obo/PATO_0001339</seealso>
    let biomaterial_purity'PATO_0001339 = Prefixed_Name(cdao, "PATO_0001339") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001340</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"hermaphrodite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001340">http://purl.obolibrary.org/obo/PATO_0001340</seealso>
    let hermaphrodite'PATO_0001340 = Prefixed_Name(cdao, "PATO_0001340") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001341</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"a mating type (yeast)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001341">http://purl.obolibrary.org/obo/PATO_0001341</seealso>
    let ``a_mating_type_(yeast)`` = Prefixed_Name(cdao, "PATO_0001341") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001342</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Saccharomyces cerevisiae mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001342">http://purl.obolibrary.org/obo/PATO_0001342</seealso>
    let Saccharomyces_cerevisiae_mating_type =
        Prefixed_Name(cdao, "PATO_0001342") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001343</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Schizosaccharomyces pombe mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001343">http://purl.obolibrary.org/obo/PATO_0001343</seealso>
    let Schizosaccharomyces_pombe_mating_type =
        Prefixed_Name(cdao, "PATO_0001343") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001344</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alpha mating type (yeast)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001344">http://purl.obolibrary.org/obo/PATO_0001344</seealso>
    let ``alpha_mating_type_(yeast)`` =
        Prefixed_Name(cdao, "PATO_0001344") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001345</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"h minus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001345">http://purl.obolibrary.org/obo/PATO_0001345</seealso>
    let h_minus'PATO_0001345 = Prefixed_Name(cdao, "PATO_0001345") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001346</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"h plus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001346">http://purl.obolibrary.org/obo/PATO_0001346</seealso>
    let h_plus'PATO_0001346 = Prefixed_Name(cdao, "PATO_0001346") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001347</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001347">http://purl.obolibrary.org/obo/PATO_0001347</seealso>
    let F_mating_type'PATO_0001347 = Prefixed_Name(cdao, "PATO_0001347") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001348</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"F minus mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001348">http://purl.obolibrary.org/obo/PATO_0001348</seealso>
    let F_minus_mating_type'PATO_0001348 = Prefixed_Name(cdao, "PATO_0001348") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001374</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ploidy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001374">http://purl.obolibrary.org/obo/PATO_0001374</seealso>
    let ploidy'PATO_0001374 = Prefixed_Name(cdao, "PATO_0001374") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001375</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"haploid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001375">http://purl.obolibrary.org/obo/PATO_0001375</seealso>
    let haploid'PATO_0001375 = Prefixed_Name(cdao, "PATO_0001375") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001377</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyploid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001377">http://purl.obolibrary.org/obo/PATO_0001377</seealso>
    let polyploid'PATO_0001377 = Prefixed_Name(cdao, "PATO_0001377") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001385</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aneuploid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001385">http://purl.obolibrary.org/obo/PATO_0001385</seealso>
    let aneuploid'PATO_0001385 = Prefixed_Name(cdao, "PATO_0001385") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001393</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"euploid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001393">http://purl.obolibrary.org/obo/PATO_0001393</seealso>
    let euploid'PATO_0001393 = Prefixed_Name(cdao, "PATO_0001393") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001394</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"diploid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001394">http://purl.obolibrary.org/obo/PATO_0001394</seealso>
    let diploid'PATO_0001394 = Prefixed_Name(cdao, "PATO_0001394") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001396</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"cellular quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001396">http://purl.obolibrary.org/obo/PATO_0001396</seealso>
    let cellular_quality'PATO_0001396 = Prefixed_Name(cdao, "PATO_0001396") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001421</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"alive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001421">http://purl.obolibrary.org/obo/PATO_0001421</seealso>
    let alive'PATO_0001421 = Prefixed_Name(cdao, "PATO_0001421") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001422</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dead"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001422">http://purl.obolibrary.org/obo/PATO_0001422</seealso>
    let dead'PATO_0001422 = Prefixed_Name(cdao, "PATO_0001422") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001546</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality of a solid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001546">http://purl.obolibrary.org/obo/PATO_0001546</seealso>
    let quality_of_a_solid'PATO_0001546 = Prefixed_Name(cdao, "PATO_0001546") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001547</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality of a gas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001547">http://purl.obolibrary.org/obo/PATO_0001547</seealso>
    let quality_of_a_gas'PATO_0001547 = Prefixed_Name(cdao, "PATO_0001547") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001548</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality of a liquid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001548">http://purl.obolibrary.org/obo/PATO_0001548</seealso>
    let quality_of_a_liquid'PATO_0001548 = Prefixed_Name(cdao, "PATO_0001548") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001574</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"flow rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001574">http://purl.obolibrary.org/obo/PATO_0001574</seealso>
    let flow_rate'PATO_0001574 = Prefixed_Name(cdao, "PATO_0001574") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001632</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"anterior to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001632">http://purl.obolibrary.org/obo/PATO_0001632</seealso>
    let anterior_to'PATO_0001632 = Prefixed_Name(cdao, "PATO_0001632") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001710</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"3-D extent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001710">http://purl.obolibrary.org/obo/PATO_0001710</seealso>
    let _3_D_extent'PATO_0001710 = Prefixed_Name(cdao, "PATO_0001710") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001739</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radiation quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001739">http://purl.obolibrary.org/obo/PATO_0001739</seealso>
    let radiation_quality'PATO_0001739 = Prefixed_Name(cdao, "PATO_0001739") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001740</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"activity (of a radionuclide)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001740">http://purl.obolibrary.org/obo/PATO_0001740</seealso>
    let ``activity_(of_a_radionuclide)`` =
        Prefixed_Name(cdao, "PATO_0001740") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PATO_0001741</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"radioactive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001741">http://purl.obolibrary.org/obo/PATO_0001741</seealso>
    let radioactive'PATO_0001741 = Prefixed_Name(cdao, "PATO_0001741") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001792</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left side of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001792">http://purl.obolibrary.org/obo/PATO_0001792</seealso>
    let left_side_of'PATO_0001792 = Prefixed_Name(cdao, "PATO_0001792") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001793</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right side of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001793">http://purl.obolibrary.org/obo/PATO_0001793</seealso>
    let right_side_of'PATO_0001793 = Prefixed_Name(cdao, "PATO_0001793") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001894</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"phenotypic sex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001894">http://purl.obolibrary.org/obo/PATO_0001894</seealso>
    let phenotypic_sex'PATO_0001894 = Prefixed_Name(cdao, "PATO_0001894") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001895</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"mating type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001895">http://purl.obolibrary.org/obo/PATO_0001895</seealso>
    let mating_type'PATO_0001895 = Prefixed_Name(cdao, "PATO_0001895") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001906</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"movement quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001906">http://purl.obolibrary.org/obo/PATO_0001906</seealso>
    let movement_quality'PATO_0001906 = Prefixed_Name(cdao, "PATO_0001906") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001985</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"frozen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001985">http://purl.obolibrary.org/obo/PATO_0001985</seealso>
    let frozen'PATO_0001985 = Prefixed_Name(cdao, "PATO_0001985") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0001995</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"organismal quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0001995">http://purl.obolibrary.org/obo/PATO_0001995</seealso>
    let organismal_quality'PATO_0001995 = Prefixed_Name(cdao, "PATO_0001995") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002003</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"population quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002003">http://purl.obolibrary.org/obo/PATO_0002003</seealso>
    let population_quality'PATO_0002003 = Prefixed_Name(cdao, "PATO_0002003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002182</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002182">http://purl.obolibrary.org/obo/PATO_0002182</seealso>
    let molecular_quality'PATO_0002182 = Prefixed_Name(cdao, "PATO_0002182") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002198</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quality of a substance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002198">http://purl.obolibrary.org/obo/PATO_0002198</seealso>
    let quality_of_a_substance'PATO_0002198 = Prefixed_Name(cdao, "PATO_0002198") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002201</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"handedness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002201">http://purl.obolibrary.org/obo/PATO_0002201</seealso>
    let handedness'PATO_0002201 = Prefixed_Name(cdao, "PATO_0002201") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002202</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"left handedness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002202">http://purl.obolibrary.org/obo/PATO_0002202</seealso>
    let left_handedness'PATO_0002202 = Prefixed_Name(cdao, "PATO_0002202") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002203</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"right handedness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002203">http://purl.obolibrary.org/obo/PATO_0002203</seealso>
    let right_handedness'PATO_0002203 = Prefixed_Name(cdao, "PATO_0002203") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002204</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ambidextrous handedness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002204">http://purl.obolibrary.org/obo/PATO_0002204</seealso>
    let ambidextrous_handedness'PATO_0002204 = Prefixed_Name(cdao, "PATO_0002204") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PATO_0002243</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fluid flow rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PATO_0002243">http://purl.obolibrary.org/obo/PATO_0002243</seealso>
    let fluid_flow_rate'PATO_0002243 = Prefixed_Name(cdao, "PATO_0002243") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"protein"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000000001">http://purl.obolibrary.org/obo/PR_000000001</seealso>
    let protein'PR_000000001 = Prefixed_Name(cdao, "PR_000000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000001004</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CD4 molecule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000001004">http://purl.obolibrary.org/obo/PR_000001004</seealso>
    let CD4_molecule'PR_000001004 = Prefixed_Name(cdao, "PR_000001004") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000001018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CD3 subunit with immunoglobulin domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000001018">http://purl.obolibrary.org/obo/PR_000001018</seealso>
    let CD3_subunit_with_immunoglobulin_domain =
        Prefixed_Name(cdao, "PR_000001018") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000003252</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"antithrombin-III"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000003252">http://purl.obolibrary.org/obo/PR_000003252</seealso>
    let antithrombin_III'PR_000003252 = Prefixed_Name(cdao, "PR_000003252") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000003745</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"double-stranded RNA-specific adenosine deaminase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000003745">http://purl.obolibrary.org/obo/PR_000003745</seealso>
    let double_stranded_RNA_specific_adenosine_deaminase =
        Prefixed_Name(cdao, "PR_000003745") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000006592</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"deoxyribonuclease-1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000006592">http://purl.obolibrary.org/obo/PR_000006592</seealso>
    let deoxyribonuclease_1'PR_000006592 = Prefixed_Name(cdao, "PR_000006592") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000007928</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"glial cell line-derived neurotrophic factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000007928">http://purl.obolibrary.org/obo/PR_000007928</seealso>
    let glial_cell_line_derived_neurotrophic_factor =
        Prefixed_Name(cdao, "PR_000007928") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000014060</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonuclease T2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000014060">http://purl.obolibrary.org/obo/PR_000014060</seealso>
    let ribonuclease_T2'PR_000014060 = Prefixed_Name(cdao, "PR_000014060") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000023089</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DNA ligase"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000023089">http://purl.obolibrary.org/obo/PR_000023089</seealso>
    let DNA_ligase'PR_000023089 = Prefixed_Name(cdao, "PR_000023089") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000025402</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"T cell receptor co-receptor CD8"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025402">http://purl.obolibrary.org/obo/PR_000025402</seealso>
    let T_cell_receptor_co_receptor_CD8 =
        Prefixed_Name(cdao, "PR_000025402") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000025467</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"guanyl-specific ribonuclease T1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025467">http://purl.obolibrary.org/obo/PR_000025467</seealso>
    let guanyl_specific_ribonuclease_T1 =
        Prefixed_Name(cdao, "PR_000025467") |> PrefixedName

    /// <summary>
    ///   <para>cdao:PR_000025471</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nuclease S1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025471">http://purl.obolibrary.org/obo/PR_000025471</seealso>
    let nuclease_S1'PR_000025471 = Prefixed_Name(cdao, "PR_000025471") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000025475</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonuclease U2"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025475">http://purl.obolibrary.org/obo/PR_000025475</seealso>
    let ribonuclease_U2'PR_000025475 = Prefixed_Name(cdao, "PR_000025475") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000025477</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonuclease V1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025477">http://purl.obolibrary.org/obo/PR_000025477</seealso>
    let ribonuclease_V1'PR_000025477 = Prefixed_Name(cdao, "PR_000025477") |> PrefixedName
    /// <summary>
    ///   <para>cdao:PR_000025478</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ribonuclease CL3"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/PR_000025478">http://purl.obolibrary.org/obo/PR_000025478</seealso>
    let ribonuclease_CL3'PR_000025478 = Prefixed_Name(cdao, "PR_000025478") |> PrefixedName
    /// <summary>
    ///   <para>cdao:REO_0000171</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular label role"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/REO_0000171">http://purl.obolibrary.org/obo/REO_0000171</seealso>
    let molecular_label_role'REO_0000171 = Prefixed_Name(cdao, "REO_0000171") |> PrefixedName
    /// <summary>
    ///   <para>cdao:REO_0000280</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"molecular label"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/REO_0000280">http://purl.obolibrary.org/obo/REO_0000280</seealso>
    let molecular_label'REO_0000280 = Prefixed_Name(cdao, "REO_0000280") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000052</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inheres in"</para><para>"inheres in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000052">http://purl.obolibrary.org/obo/RO_0000052</seealso>
    let inheres_in'RO_0000052 = Prefixed_Name(cdao, "RO_0000052") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000053</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bearer of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"bearer of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000053">http://purl.obolibrary.org/obo/RO_0000053</seealso>
    let bearer_of'RO_0000053 = Prefixed_Name(cdao, "RO_0000053") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000056</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"participates in"</para><para>"participates in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000056">http://purl.obolibrary.org/obo/RO_0000056</seealso>
    let participates_in'RO_0000056 = Prefixed_Name(cdao, "RO_0000056") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000057</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has participant"</para><para>"has participant"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000057">http://purl.obolibrary.org/obo/RO_0000057</seealso>
    let has_participant'RO_0000057 = Prefixed_Name(cdao, "RO_0000057") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000058</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is concretized as"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000058">http://purl.obolibrary.org/obo/RO_0000058</seealso>
    let is_concretized_as'RO_0000058 = Prefixed_Name(cdao, "RO_0000058") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000059</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"concretizes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000059">http://purl.obolibrary.org/obo/RO_0000059</seealso>
    let concretizes'RO_0000059 = Prefixed_Name(cdao, "RO_0000059") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000079</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"function of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000079">http://purl.obolibrary.org/obo/RO_0000079</seealso>
    let function_of'RO_0000079 = Prefixed_Name(cdao, "RO_0000079") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000080</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"quality of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000080">http://purl.obolibrary.org/obo/RO_0000080</seealso>
    let quality_of'RO_0000080 = Prefixed_Name(cdao, "RO_0000080") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000081</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"role of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000081">http://purl.obolibrary.org/obo/RO_0000081</seealso>
    let role_of'RO_0000081 = Prefixed_Name(cdao, "RO_0000081") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000085</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has function"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000085">http://purl.obolibrary.org/obo/RO_0000085</seealso>
    let has_function'RO_0000085 = Prefixed_Name(cdao, "RO_0000085") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000086</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has quality"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000086">http://purl.obolibrary.org/obo/RO_0000086</seealso>
    let has_quality'RO_0000086 = Prefixed_Name(cdao, "RO_0000086") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has role"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000087">http://purl.obolibrary.org/obo/RO_0000087</seealso>
    let has_role'RO_0000087 = Prefixed_Name(cdao, "RO_0000087") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000091</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has disposition"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000091">http://purl.obolibrary.org/obo/RO_0000091</seealso>
    let has_disposition'RO_0000091 = Prefixed_Name(cdao, "RO_0000091") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0000092</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"disposition of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0000092">http://purl.obolibrary.org/obo/RO_0000092</seealso>
    let disposition_of'RO_0000092 = Prefixed_Name(cdao, "RO_0000092") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derives from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"derives from"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001000">http://purl.obolibrary.org/obo/RO_0001000</seealso>
    let derives_from'RO_0001000 = Prefixed_Name(cdao, "RO_0001000") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"derives into"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001001">http://purl.obolibrary.org/obo/RO_0001001</seealso>
    let derives_into'RO_0001001 = Prefixed_Name(cdao, "RO_0001001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001015</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"location of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"location of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001015">http://purl.obolibrary.org/obo/RO_0001015</seealso>
    let location_of'RO_0001015 = Prefixed_Name(cdao, "RO_0001015") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001018</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contained in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001018">http://purl.obolibrary.org/obo/RO_0001018</seealso>
    let contained_in'RO_0001018 = Prefixed_Name(cdao, "RO_0001018") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001019</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001019">http://purl.obolibrary.org/obo/RO_0001019</seealso>
    let contains'RO_0001019 = Prefixed_Name(cdao, "RO_0001019") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001025</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"located in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"located in"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001025">http://purl.obolibrary.org/obo/RO_0001025</seealso>
    let located_in'RO_0001025 = Prefixed_Name(cdao, "RO_0001025") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001900</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>"temporal interpretation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001900">http://purl.obolibrary.org/obo/RO_0001900</seealso>
    let temporal_interpretation'RO_0001900 = Prefixed_Name(cdao, "RO_0001900") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0001901</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"axiom holds for all times"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001901">http://purl.obolibrary.org/obo/RO_0001901</seealso>
    let axiom_holds_for_all_times'RO_0001901 = Prefixed_Name(cdao, "RO_0001901") |> PrefixedName

    /// <summary>
    ///   <para>cdao:RO_0001902</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"relation has no temporal argument"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0001902">http://purl.obolibrary.org/obo/RO_0001902</seealso>
    let relation_has_no_temporal_argument =
        Prefixed_Name(cdao, "RO_0001902") |> PrefixedName

    /// <summary>
    ///   <para>cdao:RO_0002000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"2D boundary of"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002000">http://purl.obolibrary.org/obo/RO_0002000</seealso>
    let _2D_boundary_of'RO_0002000 = Prefixed_Name(cdao, "RO_0002000") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002002</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has 2D boundary"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002002">http://purl.obolibrary.org/obo/RO_0002002</seealso>
    let has_2D_boundary'RO_0002002 = Prefixed_Name(cdao, "RO_0002002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002087</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"X immediately_preceded_by Y iff: end(X) simultaneous_with start(Y)"</para>
    /// labels<para>"immediately preceded by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002087">http://purl.obolibrary.org/obo/RO_0002087</seealso>
    let immediately_preceded_by'RO_0002087 = Prefixed_Name(cdao, "RO_0002087") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002090</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"X immediately_precedes_Y iff: end(X) simultaneous_with start(Y)"</para>
    /// labels<para>"immediately precedes"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002090">http://purl.obolibrary.org/obo/RO_0002090</seealso>
    let immediately_precedes'RO_0002090 = Prefixed_Name(cdao, "RO_0002090") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002219</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"surrounded by"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002219">http://purl.obolibrary.org/obo/RO_0002219</seealso>
    let surrounded_by'RO_0002219 = Prefixed_Name(cdao, "RO_0002219") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002220</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"adjacent to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002220">http://purl.obolibrary.org/obo/RO_0002220</seealso>
    let adjacent_to'RO_0002220 = Prefixed_Name(cdao, "RO_0002220") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002222</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation that holds between two occurrents. This is a grouping relation that collects together all the Allen relations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"temporal relation"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002222">http://purl.obolibrary.org/obo/RO_0002222</seealso>
    let temporal_relation'RO_0002222 = Prefixed_Name(cdao, "RO_0002222") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002223</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"starts"</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002223">http://purl.obolibrary.org/obo/RO_0002223</seealso>
    let starts'RO_0002223 = Prefixed_Name(cdao, "RO_0002223") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002224</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002224">http://purl.obolibrary.org/obo/RO_0002224</seealso>
    let RO_0002224'RO_0002224 = Prefixed_Name(cdao, "RO_0002224") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002230</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002230">http://purl.obolibrary.org/obo/RO_0002230</seealso>
    let RO_0002230'RO_0002230 = Prefixed_Name(cdao, "RO_0002230") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002233</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002233">http://purl.obolibrary.org/obo/RO_0002233</seealso>
    let has_input'RO_0002233 = Prefixed_Name(cdao, "RO_0002233") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002234</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002234">http://purl.obolibrary.org/obo/RO_0002234</seealso>
    let has_output'RO_0002234 = Prefixed_Name(cdao, "RO_0002234") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002303</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002303">http://purl.obolibrary.org/obo/RO_0002303</seealso>
    let RO_0002303'RO_0002303 = Prefixed_Name(cdao, "RO_0002303") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002350</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"member of"</para><para>"member of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002350">http://purl.obolibrary.org/obo/RO_0002350</seealso>
    let member_of'RO_0002350 = Prefixed_Name(cdao, "RO_0002350") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002351</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///
    /// labels<para>"has member"</para><para>"has member"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002351">http://purl.obolibrary.org/obo/RO_0002351</seealso>
    let has_member'RO_0002351 = Prefixed_Name(cdao, "RO_0002351") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002352">http://purl.obolibrary.org/obo/RO_0002352</seealso>
    let RO_0002352'RO_0002352 = Prefixed_Name(cdao, "RO_0002352") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0002353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"output of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0002353">http://purl.obolibrary.org/obo/RO_0002353</seealso>
    let output_of'RO_0002353 = Prefixed_Name(cdao, "RO_0002353") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0003000</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"produces"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0003000">http://purl.obolibrary.org/obo/RO_0003000</seealso>
    let produces'RO_0003000 = Prefixed_Name(cdao, "RO_0003000") |> PrefixedName
    /// <summary>
    ///   <para>cdao:RO_0003001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"produced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/RO_0003001">http://purl.obolibrary.org/obo/RO_0003001</seealso>
    let produced_by'RO_0003001 = Prefixed_Name(cdao, "RO_0003001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000001</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000001">http://purl.obolibrary.org/obo/SO_0000001</seealso>
    let region'SO_0000001 = Prefixed_Name(cdao, "SO_0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000104</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polypeptide"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000104">http://purl.obolibrary.org/obo/SO_0000104</seealso>
    let polypeptide'SO_0000104 = Prefixed_Name(cdao, "SO_0000104") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000148</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"supercontig"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000148">http://purl.obolibrary.org/obo/SO_0000148</seealso>
    let supercontig'SO_0000148 = Prefixed_Name(cdao, "SO_0000148") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000149</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"contig"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000149">http://purl.obolibrary.org/obo/SO_0000149</seealso>
    let contig'SO_0000149 = Prefixed_Name(cdao, "SO_0000149") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000276</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"miRNA"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000276">http://purl.obolibrary.org/obo/SO_0000276</seealso>
    let miRNA'SO_0000276 = Prefixed_Name(cdao, "SO_0000276") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000353</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sequence_assembly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000353">http://purl.obolibrary.org/obo/SO_0000353</seealso>
    let sequence_assembly'SO_0000353 = Prefixed_Name(cdao, "SO_0000353") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0000988</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"circular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0000988">http://purl.obolibrary.org/obo/SO_0000988</seealso>
    let circular'SO_0000988 = Prefixed_Name(cdao, "SO_0000988") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0001248</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assembly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0001248">http://purl.obolibrary.org/obo/SO_0001248</seealso>
    let assembly'SO_0001248 = Prefixed_Name(cdao, "SO_0001248") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SO_0001410</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"experimental_feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SO_0001410">http://purl.obolibrary.org/obo/SO_0001410</seealso>
    let experimental_feature'SO_0001410 = Prefixed_Name(cdao, "SO_0001410") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo.owl">http://purl.obolibrary.org/obo/bfo.owl</seealso>
    let ``bfo.owl`` = Prefixed_Name(cdao, "bfo.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:bfo/2019-08-26/bfo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/2019-08-26/bfo.owl">http://purl.obolibrary.org/obo/bfo/2019-08-26/bfo.owl</seealso>
    let ``bfo/2019_08_26/bfo.owl`` =
        Prefixed_Name(cdao, "bfo/2019-08-26/bfo.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:bfo/axiom/0000001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000001">http://purl.obolibrary.org/obo/bfo/axiom/0000001</seealso>
    let ``bfo/axiom/0000001`` = Prefixed_Name(cdao, "bfo/axiom/0000001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000002">http://purl.obolibrary.org/obo/bfo/axiom/0000002</seealso>
    let ``bfo/axiom/0000002`` = Prefixed_Name(cdao, "bfo/axiom/0000002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000003">http://purl.obolibrary.org/obo/bfo/axiom/0000003</seealso>
    let ``bfo/axiom/0000003`` = Prefixed_Name(cdao, "bfo/axiom/0000003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000004">http://purl.obolibrary.org/obo/bfo/axiom/0000004</seealso>
    let ``bfo/axiom/0000004`` = Prefixed_Name(cdao, "bfo/axiom/0000004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000005</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000005">http://purl.obolibrary.org/obo/bfo/axiom/0000005</seealso>
    let ``bfo/axiom/0000005`` = Prefixed_Name(cdao, "bfo/axiom/0000005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000006</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000006">http://purl.obolibrary.org/obo/bfo/axiom/0000006</seealso>
    let ``bfo/axiom/0000006`` = Prefixed_Name(cdao, "bfo/axiom/0000006") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000007</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000007">http://purl.obolibrary.org/obo/bfo/axiom/0000007</seealso>
    let ``bfo/axiom/0000007`` = Prefixed_Name(cdao, "bfo/axiom/0000007") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000008</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000008">http://purl.obolibrary.org/obo/bfo/axiom/0000008</seealso>
    let ``bfo/axiom/0000008`` = Prefixed_Name(cdao, "bfo/axiom/0000008") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000011</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000011">http://purl.obolibrary.org/obo/bfo/axiom/0000011</seealso>
    let ``bfo/axiom/0000011`` = Prefixed_Name(cdao, "bfo/axiom/0000011") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000012</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000012">http://purl.obolibrary.org/obo/bfo/axiom/0000012</seealso>
    let ``bfo/axiom/0000012`` = Prefixed_Name(cdao, "bfo/axiom/0000012") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000300</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000300">http://purl.obolibrary.org/obo/bfo/axiom/0000300</seealso>
    let ``bfo/axiom/0000300`` = Prefixed_Name(cdao, "bfo/axiom/0000300") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/0000301</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/0000301">http://purl.obolibrary.org/obo/bfo/axiom/0000301</seealso>
    let ``bfo/axiom/0000301`` = Prefixed_Name(cdao, "bfo/axiom/0000301") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/001-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/001-001">http://purl.obolibrary.org/obo/bfo/axiom/001-001</seealso>
    let ``bfo/axiom/001_001`` = Prefixed_Name(cdao, "bfo/axiom/001-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/008-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/008-002">http://purl.obolibrary.org/obo/bfo/axiom/008-002</seealso>
    let ``bfo/axiom/008_002`` = Prefixed_Name(cdao, "bfo/axiom/008-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/009-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/009-002">http://purl.obolibrary.org/obo/bfo/axiom/009-002</seealso>
    let ``bfo/axiom/009_002`` = Prefixed_Name(cdao, "bfo/axiom/009-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/011-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/011-002">http://purl.obolibrary.org/obo/bfo/axiom/011-002</seealso>
    let ``bfo/axiom/011_002`` = Prefixed_Name(cdao, "bfo/axiom/011-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/017-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/017-002">http://purl.obolibrary.org/obo/bfo/axiom/017-002</seealso>
    let ``bfo/axiom/017_002`` = Prefixed_Name(cdao, "bfo/axiom/017-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/018-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/018-002">http://purl.obolibrary.org/obo/bfo/axiom/018-002</seealso>
    let ``bfo/axiom/018_002`` = Prefixed_Name(cdao, "bfo/axiom/018-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/019-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/019-002">http://purl.obolibrary.org/obo/bfo/axiom/019-002</seealso>
    let ``bfo/axiom/019_002`` = Prefixed_Name(cdao, "bfo/axiom/019-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/020-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/020-002">http://purl.obolibrary.org/obo/bfo/axiom/020-002</seealso>
    let ``bfo/axiom/020_002`` = Prefixed_Name(cdao, "bfo/axiom/020-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/021-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/021-002">http://purl.obolibrary.org/obo/bfo/axiom/021-002</seealso>
    let ``bfo/axiom/021_002`` = Prefixed_Name(cdao, "bfo/axiom/021-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/024-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/024-001">http://purl.obolibrary.org/obo/bfo/axiom/024-001</seealso>
    let ``bfo/axiom/024_001`` = Prefixed_Name(cdao, "bfo/axiom/024-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/025-004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/025-004">http://purl.obolibrary.org/obo/bfo/axiom/025-004</seealso>
    let ``bfo/axiom/025_004`` = Prefixed_Name(cdao, "bfo/axiom/025-004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/027-004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/027-004">http://purl.obolibrary.org/obo/bfo/axiom/027-004</seealso>
    let ``bfo/axiom/027_004`` = Prefixed_Name(cdao, "bfo/axiom/027-004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/029-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/029-001">http://purl.obolibrary.org/obo/bfo/axiom/029-001</seealso>
    let ``bfo/axiom/029_001`` = Prefixed_Name(cdao, "bfo/axiom/029-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/031-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/031-001">http://purl.obolibrary.org/obo/bfo/axiom/031-001</seealso>
    let ``bfo/axiom/031_001`` = Prefixed_Name(cdao, "bfo/axiom/031-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/032-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/032-001">http://purl.obolibrary.org/obo/bfo/axiom/032-001</seealso>
    let ``bfo/axiom/032_001`` = Prefixed_Name(cdao, "bfo/axiom/032-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/033-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/033-001">http://purl.obolibrary.org/obo/bfo/axiom/033-001</seealso>
    let ``bfo/axiom/033_001`` = Prefixed_Name(cdao, "bfo/axiom/033-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/034-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/034-002">http://purl.obolibrary.org/obo/bfo/axiom/034-002</seealso>
    let ``bfo/axiom/034_002`` = Prefixed_Name(cdao, "bfo/axiom/034-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/035-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/035-001">http://purl.obolibrary.org/obo/bfo/axiom/035-001</seealso>
    let ``bfo/axiom/035_001`` = Prefixed_Name(cdao, "bfo/axiom/035-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/036-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/036-001">http://purl.obolibrary.org/obo/bfo/axiom/036-001</seealso>
    let ``bfo/axiom/036_001`` = Prefixed_Name(cdao, "bfo/axiom/036-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/037-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/037-001">http://purl.obolibrary.org/obo/bfo/axiom/037-001</seealso>
    let ``bfo/axiom/037_001`` = Prefixed_Name(cdao, "bfo/axiom/037-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/038-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/038-001">http://purl.obolibrary.org/obo/bfo/axiom/038-001</seealso>
    let ``bfo/axiom/038_001`` = Prefixed_Name(cdao, "bfo/axiom/038-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/039-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/039-001">http://purl.obolibrary.org/obo/bfo/axiom/039-001</seealso>
    let ``bfo/axiom/039_001`` = Prefixed_Name(cdao, "bfo/axiom/039-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/040-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/040-001">http://purl.obolibrary.org/obo/bfo/axiom/040-001</seealso>
    let ``bfo/axiom/040_001`` = Prefixed_Name(cdao, "bfo/axiom/040-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/050-003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/050-003">http://purl.obolibrary.org/obo/bfo/axiom/050-003</seealso>
    let ``bfo/axiom/050_003`` = Prefixed_Name(cdao, "bfo/axiom/050-003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/055-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/055-001">http://purl.obolibrary.org/obo/bfo/axiom/055-001</seealso>
    let ``bfo/axiom/055_001`` = Prefixed_Name(cdao, "bfo/axiom/055-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/057-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/057-001">http://purl.obolibrary.org/obo/bfo/axiom/057-001</seealso>
    let ``bfo/axiom/057_001`` = Prefixed_Name(cdao, "bfo/axiom/057-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/058-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/058-002">http://purl.obolibrary.org/obo/bfo/axiom/058-002</seealso>
    let ``bfo/axiom/058_002`` = Prefixed_Name(cdao, "bfo/axiom/058-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/060-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/060-002">http://purl.obolibrary.org/obo/bfo/axiom/060-002</seealso>
    let ``bfo/axiom/060_002`` = Prefixed_Name(cdao, "bfo/axiom/060-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/061-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/061-001">http://purl.obolibrary.org/obo/bfo/axiom/061-001</seealso>
    let ``bfo/axiom/061_001`` = Prefixed_Name(cdao, "bfo/axiom/061-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/062-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/062-002">http://purl.obolibrary.org/obo/bfo/axiom/062-002</seealso>
    let ``bfo/axiom/062_002`` = Prefixed_Name(cdao, "bfo/axiom/062-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/063-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/063-002">http://purl.obolibrary.org/obo/bfo/axiom/063-002</seealso>
    let ``bfo/axiom/063_002`` = Prefixed_Name(cdao, "bfo/axiom/063-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/064-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/064-001">http://purl.obolibrary.org/obo/bfo/axiom/064-001</seealso>
    let ``bfo/axiom/064_001`` = Prefixed_Name(cdao, "bfo/axiom/064-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/074-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/074-001">http://purl.obolibrary.org/obo/bfo/axiom/074-001</seealso>
    let ``bfo/axiom/074_001`` = Prefixed_Name(cdao, "bfo/axiom/074-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/077-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/077-002">http://purl.obolibrary.org/obo/bfo/axiom/077-002</seealso>
    let ``bfo/axiom/077_002`` = Prefixed_Name(cdao, "bfo/axiom/077-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/079-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/079-001">http://purl.obolibrary.org/obo/bfo/axiom/079-001</seealso>
    let ``bfo/axiom/079_001`` = Prefixed_Name(cdao, "bfo/axiom/079-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/080-003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/080-003">http://purl.obolibrary.org/obo/bfo/axiom/080-003</seealso>
    let ``bfo/axiom/080_003`` = Prefixed_Name(cdao, "bfo/axiom/080-003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/081-003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/081-003">http://purl.obolibrary.org/obo/bfo/axiom/081-003</seealso>
    let ``bfo/axiom/081_003`` = Prefixed_Name(cdao, "bfo/axiom/081-003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/083-003</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/083-003">http://purl.obolibrary.org/obo/bfo/axiom/083-003</seealso>
    let ``bfo/axiom/083_003`` = Prefixed_Name(cdao, "bfo/axiom/083-003") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/084-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/084-001">http://purl.obolibrary.org/obo/bfo/axiom/084-001</seealso>
    let ``bfo/axiom/084_001`` = Prefixed_Name(cdao, "bfo/axiom/084-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/085-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/085-002">http://purl.obolibrary.org/obo/bfo/axiom/085-002</seealso>
    let ``bfo/axiom/085_002`` = Prefixed_Name(cdao, "bfo/axiom/085-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/093-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/093-002">http://purl.obolibrary.org/obo/bfo/axiom/093-002</seealso>
    let ``bfo/axiom/093_002`` = Prefixed_Name(cdao, "bfo/axiom/093-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/094-005</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/094-005">http://purl.obolibrary.org/obo/bfo/axiom/094-005</seealso>
    let ``bfo/axiom/094_005`` = Prefixed_Name(cdao, "bfo/axiom/094-005") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/095-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/095-001">http://purl.obolibrary.org/obo/bfo/axiom/095-001</seealso>
    let ``bfo/axiom/095_001`` = Prefixed_Name(cdao, "bfo/axiom/095-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/096-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/096-001">http://purl.obolibrary.org/obo/bfo/axiom/096-001</seealso>
    let ``bfo/axiom/096_001`` = Prefixed_Name(cdao, "bfo/axiom/096-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/098-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/098-001">http://purl.obolibrary.org/obo/bfo/axiom/098-001</seealso>
    let ``bfo/axiom/098_001`` = Prefixed_Name(cdao, "bfo/axiom/098-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/099-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/099-001">http://purl.obolibrary.org/obo/bfo/axiom/099-001</seealso>
    let ``bfo/axiom/099_001`` = Prefixed_Name(cdao, "bfo/axiom/099-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/100-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/100-001">http://purl.obolibrary.org/obo/bfo/axiom/100-001</seealso>
    let ``bfo/axiom/100_001`` = Prefixed_Name(cdao, "bfo/axiom/100-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/101-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/101-001">http://purl.obolibrary.org/obo/bfo/axiom/101-001</seealso>
    let ``bfo/axiom/101_001`` = Prefixed_Name(cdao, "bfo/axiom/101-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/102-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/102-001">http://purl.obolibrary.org/obo/bfo/axiom/102-001</seealso>
    let ``bfo/axiom/102_001`` = Prefixed_Name(cdao, "bfo/axiom/102-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/103-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/103-001">http://purl.obolibrary.org/obo/bfo/axiom/103-001</seealso>
    let ``bfo/axiom/103_001`` = Prefixed_Name(cdao, "bfo/axiom/103-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/105-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/105-001">http://purl.obolibrary.org/obo/bfo/axiom/105-001</seealso>
    let ``bfo/axiom/105_001`` = Prefixed_Name(cdao, "bfo/axiom/105-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/107-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/107-002">http://purl.obolibrary.org/obo/bfo/axiom/107-002</seealso>
    let ``bfo/axiom/107_002`` = Prefixed_Name(cdao, "bfo/axiom/107-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/108-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/108-001">http://purl.obolibrary.org/obo/bfo/axiom/108-001</seealso>
    let ``bfo/axiom/108_001`` = Prefixed_Name(cdao, "bfo/axiom/108-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/119-002</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/119-002">http://purl.obolibrary.org/obo/bfo/axiom/119-002</seealso>
    let ``bfo/axiom/119_002`` = Prefixed_Name(cdao, "bfo/axiom/119-002") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/126-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/126-001">http://purl.obolibrary.org/obo/bfo/axiom/126-001</seealso>
    let ``bfo/axiom/126_001`` = Prefixed_Name(cdao, "bfo/axiom/126-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/131-004</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/131-004">http://purl.obolibrary.org/obo/bfo/axiom/131-004</seealso>
    let ``bfo/axiom/131_004`` = Prefixed_Name(cdao, "bfo/axiom/131-004") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/134-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/134-001">http://purl.obolibrary.org/obo/bfo/axiom/134-001</seealso>
    let ``bfo/axiom/134_001`` = Prefixed_Name(cdao, "bfo/axiom/134-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:bfo/axiom/138-001</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/bfo/axiom/138-001">http://purl.obolibrary.org/obo/bfo/axiom/138-001</seealso>
    let ``bfo/axiom/138_001`` = Prefixed_Name(cdao, "bfo/axiom/138-001") |> PrefixedName
    /// <summary>
    ///   <para>cdao:chebi.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/chebi.owl">http://purl.obolibrary.org/obo/chebi.owl</seealso>
    let ``chebi.owl`` = Prefixed_Name(cdao, "chebi.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:chebi/formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/chebi/formula">http://purl.obolibrary.org/obo/chebi/formula</seealso>
    let ``chebi/formula`` = Prefixed_Name(cdao, "chebi/formula") |> PrefixedName
    /// <summary>
    ///   <para>cdao:cl.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/cl.owl">http://purl.obolibrary.org/obo/cl.owl</seealso>
    let ``cl.owl`` = Prefixed_Name(cdao, "cl.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:clo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/clo.owl">http://purl.obolibrary.org/obo/clo.owl</seealso>
    let ``clo.owl`` = Prefixed_Name(cdao, "clo.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:envo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/envo.owl">http://purl.obolibrary.org/obo/envo.owl</seealso>
    let ``envo.owl`` = Prefixed_Name(cdao, "envo.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:gaz.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/gaz.owl">http://purl.obolibrary.org/obo/gaz.owl</seealso>
    let ``gaz.owl`` = Prefixed_Name(cdao, "gaz.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:go.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/go.owl">http://purl.obolibrary.org/obo/go.owl</seealso>
    let ``go.owl`` = Prefixed_Name(cdao, "go.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:hp.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/hp.owl">http://purl.obolibrary.org/obo/hp.owl</seealso>
    let ``hp.owl`` = Prefixed_Name(cdao, "hp.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:iao.owl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/iao.owl">http://purl.obolibrary.org/obo/iao.owl</seealso>
    let ``iao.owl`` = Prefixed_Name(cdao, "iao.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:iao/d-acts.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/iao/d-acts.owl">http://purl.obolibrary.org/obo/iao/d-acts.owl</seealso>
    let ``iao/d_acts.owl`` = Prefixed_Name(cdao, "iao/d-acts.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:iao/pno.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/iao/pno.owl">http://purl.obolibrary.org/obo/iao/pno.owl</seealso>
    let ``iao/pno.owl`` = Prefixed_Name(cdao, "iao/pno.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ido.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ido.owl">http://purl.obolibrary.org/obo/ido.owl</seealso>
    let ``ido.owl`` = Prefixed_Name(cdao, "ido.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ncbitaxon#has_rank</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ncbitaxon#has_rank">http://purl.obolibrary.org/obo/ncbitaxon#has_rank</seealso>
    let ``ncbitaxon#has_rank`` =
        Prefixed_Name(cdao, "ncbitaxon#has_rank") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ncbitaxon.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ncbitaxon.owl">http://purl.obolibrary.org/obo/ncbitaxon.owl</seealso>
    let ``ncbitaxon.owl`` = Prefixed_Name(cdao, "ncbitaxon.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:obi.owl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Please cite the OBI consortium http://purl.obolibrary.org/obo/obi where traditional citation is called for. However it is adequate that individual terms be attributed simply by use of the identifying PURL for the term, in projects that refer to them."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/obi.owl">http://purl.obolibrary.org/obo/obi.owl</seealso>
    let ``obi.owl`` = Prefixed_Name(cdao, "obi.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:obi/2019-08-06/obi.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/obi/2019-08-06/obi.owl">http://purl.obolibrary.org/obo/obi/2019-08-06/obi.owl</seealso>
    let ``obi/2019_08_06/obi.owl`` =
        Prefixed_Name(cdao, "obi/2019-08-06/obi.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:obi_webservice.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/obi_webservice.owl">http://purl.obolibrary.org/obo/obi_webservice.owl</seealso>
    let ``obi_webservice.owl`` =
        Prefixed_Name(cdao, "obi_webservice.owl") |> PrefixedName

    /// <summary>
    ///   <para>cdao:ogms.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ogms.owl">http://purl.obolibrary.org/obo/ogms.owl</seealso>
    let ``ogms.owl`` = Prefixed_Name(cdao, "ogms.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:omiabis.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/omiabis.owl">http://purl.obolibrary.org/obo/omiabis.owl</seealso>
    let ``omiabis.owl`` = Prefixed_Name(cdao, "omiabis.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:pato.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/pato.owl">http://purl.obolibrary.org/obo/pato.owl</seealso>
    let ``pato.owl`` = Prefixed_Name(cdao, "pato.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:pr.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/pr.owl">http://purl.obolibrary.org/obo/pr.owl</seealso>
    let ``pr.owl`` = Prefixed_Name(cdao, "pr.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:reo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/reo.owl">http://purl.obolibrary.org/obo/reo.owl</seealso>
    let ``reo.owl`` = Prefixed_Name(cdao, "reo.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:ro.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/ro.owl">http://purl.obolibrary.org/obo/ro.owl</seealso>
    let ``ro.owl`` = Prefixed_Name(cdao, "ro.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:so.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/so.owl">http://purl.obolibrary.org/obo/so.owl</seealso>
    let ``so.owl`` = Prefixed_Name(cdao, "so.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:uberon.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/uberon.owl">http://purl.obolibrary.org/obo/uberon.owl</seealso>
    let ``uberon.owl`` = Prefixed_Name(cdao, "uberon.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:uo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/uo.owl">http://purl.obolibrary.org/obo/uo.owl</seealso>
    let ``uo.owl`` = Prefixed_Name(cdao, "uo.owl") |> PrefixedName
    /// <summary>
    ///   <para>cdao:uo.owl/unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"reused from Units of measurement Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/uo.owl/unit">http://purl.obolibrary.org/obo/uo.owl/unit</seealso>
    let ``uo.owl/unit`` = Prefixed_Name(cdao, "uo.owl/unit") |> PrefixedName
    /// <summary>
    ///   <para>cdao:vo.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/vo.owl">http://purl.obolibrary.org/obo/vo.owl</seealso>
    let ``vo.owl`` = Prefixed_Name(cdao, "vo.owl") |> PrefixedName
