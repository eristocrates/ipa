namespace http.purl.obolibrary.org.obo.SYMP_.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module symp =
    let _namespace_iri = Namespace_Iri symp |> NamespaceIRI
    /// <summary>
    ///   <para>cdao:SYMP_0000012</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"blurred vision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000012">http://purl.obolibrary.org/obo/SYMP_0000012</seealso>
    let blurred_vision = Prefixed_Name(symp, "0000012") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000094</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"muscle weakness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000094">http://purl.obolibrary.org/obo/SYMP_0000094</seealso>
    let muscle_weakness = Prefixed_Name(symp, "0000094") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000099</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"pain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000099">http://purl.obolibrary.org/obo/SYMP_0000099</seealso>
    let pain = Prefixed_Name(symp, "0000099") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000320</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"vision symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000320">http://purl.obolibrary.org/obo/SYMP_0000320</seealso>
    let vision_symptom = Prefixed_Name(symp, "0000320") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000352</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"peripheral muscle weakness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000352">http://purl.obolibrary.org/obo/SYMP_0000352</seealso>
    let peripheral_muscle_weakness = Prefixed_Name(symp, "0000352") |> PrefixedName

    /// <summary>
    ///   <para>cdao:SYMP_0000410</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"neurological and physiological symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000410">http://purl.obolibrary.org/obo/SYMP_0000410</seealso>
    let neurological_and_physiological_symptom =
        Prefixed_Name(symp, "0000410") |> PrefixedName

    /// <summary>
    ///   <para>cdao:SYMP_0000462</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000462">http://purl.obolibrary.org/obo/SYMP_0000462</seealso>
    let symptom = Prefixed_Name(symp, "0000462") |> PrefixedName

    /// <summary>
    ///   <para>cdao:SYMP_0000473</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nutrition, metabolism, and development symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000473">http://purl.obolibrary.org/obo/SYMP_0000473</seealso>
    let ``nutrition,_metabolism,_and_development_symptom`` =
        Prefixed_Name(symp, "0000473") |> PrefixedName

    /// <summary>
    ///   <para>cdao:SYMP_0000480</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"nervous system symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000480">http://purl.obolibrary.org/obo/SYMP_0000480</seealso>
    let nervous_system_symptom = Prefixed_Name(symp, "0000480") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000485</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"dysuria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000485">http://purl.obolibrary.org/obo/SYMP_0000485</seealso>
    let dysuria = Prefixed_Name(symp, "0000485") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000486</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urinary system symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000486">http://purl.obolibrary.org/obo/SYMP_0000486</seealso>
    let urinary_system_symptom = Prefixed_Name(symp, "0000486") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000524</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyphagia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000524">http://purl.obolibrary.org/obo/SYMP_0000524</seealso>
    let polyphagia = Prefixed_Name(symp, "0000524") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000560</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polydipsia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000560">http://purl.obolibrary.org/obo/SYMP_0000560</seealso>
    let polydipsia = Prefixed_Name(symp, "0000560") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000563</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"urinary frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000563">http://purl.obolibrary.org/obo/SYMP_0000563</seealso>
    let urinary_frequency = Prefixed_Name(symp, "0000563") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000565</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"polyuria"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000565">http://purl.obolibrary.org/obo/SYMP_0000565</seealso>
    let polyuria = Prefixed_Name(symp, "0000565") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000576</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"chest pain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000576">http://purl.obolibrary.org/obo/SYMP_0000576</seealso>
    let chest_pain = Prefixed_Name(symp, "0000576") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000734</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"stroke"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000734">http://purl.obolibrary.org/obo/SYMP_0000734</seealso>
    let stroke = Prefixed_Name(symp, "0000734") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0000891</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"musculoskeletal system symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0000891">http://purl.obolibrary.org/obo/SYMP_0000891</seealso>
    let musculoskeletal_system_symptom = Prefixed_Name(symp, "0000891") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0019163</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"eye symptom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0019163">http://purl.obolibrary.org/obo/SYMP_0019163</seealso>
    let eye_symptom = Prefixed_Name(symp, "0019163") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0019169</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"arthritis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0019169">http://purl.obolibrary.org/obo/SYMP_0019169</seealso>
    let arthritis = Prefixed_Name(symp, "0019169") |> PrefixedName
    /// <summary>
    ///   <para>cdao:SYMP_0019177</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"fatigue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.obolibrary.org/obo/SYMP_0019177">http://purl.obolibrary.org/obo/SYMP_0019177</seealso>
    let fatigue = Prefixed_Name(symp, "0019177") |> PrefixedName
