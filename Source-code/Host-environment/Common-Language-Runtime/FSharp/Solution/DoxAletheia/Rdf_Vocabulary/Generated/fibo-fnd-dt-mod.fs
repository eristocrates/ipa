namespace https.spec.edmcouncil.org.fibo.ontology.FND.DatesAndTimes.MetadataFNDDatesAndTimes.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_dt_mod =
    let _namespace_iri = Namespace_Iri fibo_fnd_dt_mod |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-dt-mod:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Metadata for the EDMC-FIBO Foundations (FND) Dates and Times Module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_dt_mod, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-dt-mod:DatesAndTimesModule</para>
    /// </summary>
    /// <remarks>
    ///   <para>fibo-fnd-utl-av:Module</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"dates and times module"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/DatesAndTimesModule">https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/DatesAndTimesModule</seealso>
    let DatesAndTimesModule =
        Prefixed_Name(fibo_fnd_dt_mod, "DatesAndTimesModule") |> PrefixedName
