namespace http.rdvocab.info.ElementsGr3.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rdag3 =
    let _namespace_iri = Namespace_Iri rdag3 |> NamespaceIRI
    /// <summary>
    ///   <para>rdag3:cataloguersNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Cataloguer's note"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/cataloguersNote">http://rdvocab.info/ElementsGr3/cataloguersNote</seealso>
    let cataloguersNote = Prefixed_Name(rdag3, "cataloguersNote") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:identifierForTheConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Identifier for the concept"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/identifierForTheConcept">http://rdvocab.info/ElementsGr3/identifierForTheConcept</seealso>
    let identifierForTheConcept =
        Prefixed_Name(rdag3, "identifierForTheConcept") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:identifierForTheEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Identifier for the event"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/identifierForTheEvent">http://rdvocab.info/ElementsGr3/identifierForTheEvent</seealso>
    let identifierForTheEvent =
        Prefixed_Name(rdag3, "identifierForTheEvent") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:identifierForTheObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Identifier for the object"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/identifierForTheObject">http://rdvocab.info/ElementsGr3/identifierForTheObject</seealso>
    let identifierForTheObject =
        Prefixed_Name(rdag3, "identifierForTheObject") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:identifierForThePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Identifier for the place"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/identifierForThePlace">http://rdvocab.info/ElementsGr3/identifierForThePlace</seealso>
    let identifierForThePlace =
        Prefixed_Name(rdag3, "identifierForThePlace") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:nameOfTheEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Name of the event"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/nameOfTheEvent">http://rdvocab.info/ElementsGr3/nameOfTheEvent</seealso>
    let nameOfTheEvent = Prefixed_Name(rdag3, "nameOfTheEvent") |> PrefixedName
    /// <summary>
    ///   <para>rdag3:nameOfTheObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Name of the object"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/nameOfTheObject">http://rdvocab.info/ElementsGr3/nameOfTheObject</seealso>
    let nameOfTheObject = Prefixed_Name(rdag3, "nameOfTheObject") |> PrefixedName
    /// <summary>
    ///   <para>rdag3:nameOfThePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Name of the place"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/nameOfThePlace">http://rdvocab.info/ElementsGr3/nameOfThePlace</seealso>
    let nameOfThePlace = Prefixed_Name(rdag3, "nameOfThePlace") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:preferredNameForTheEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Preferred name for the event"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/preferredNameForTheEvent">http://rdvocab.info/ElementsGr3/preferredNameForTheEvent</seealso>
    let preferredNameForTheEvent =
        Prefixed_Name(rdag3, "preferredNameForTheEvent") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:preferredNameForTheObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Preferred name for the object"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/preferredNameForTheObject">http://rdvocab.info/ElementsGr3/preferredNameForTheObject</seealso>
    let preferredNameForTheObject =
        Prefixed_Name(rdag3, "preferredNameForTheObject") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:preferredNameForThePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Preferred name for the place"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/preferredNameForThePlace">http://rdvocab.info/ElementsGr3/preferredNameForThePlace</seealso>
    let preferredNameForThePlace =
        Prefixed_Name(rdag3, "preferredNameForThePlace") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:preferredTermForTheConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Preferred term for the concept"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/preferredTermForTheConcept">http://rdvocab.info/ElementsGr3/preferredTermForTheConcept</seealso>
    let preferredTermForTheConcept =
        Prefixed_Name(rdag3, "preferredTermForTheConcept") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:sourceConsulted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Source consulted"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/sourceConsulted">http://rdvocab.info/ElementsGr3/sourceConsulted</seealso>
    let sourceConsulted = Prefixed_Name(rdag3, "sourceConsulted") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:statusOfIdentification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Status of identification"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/statusOfIdentification">http://rdvocab.info/ElementsGr3/statusOfIdentification</seealso>
    let statusOfIdentification =
        Prefixed_Name(rdag3, "statusOfIdentification") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:termForTheConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Term for the concept"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/termForTheConcept">http://rdvocab.info/ElementsGr3/termForTheConcept</seealso>
    let termForTheConcept = Prefixed_Name(rdag3, "termForTheConcept") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:variantNameForTheEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Variant name for the event"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/variantNameForTheEvent">http://rdvocab.info/ElementsGr3/variantNameForTheEvent</seealso>
    let variantNameForTheEvent =
        Prefixed_Name(rdag3, "variantNameForTheEvent") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:variantNameForTheObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Variant name for the object"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/variantNameForTheObject">http://rdvocab.info/ElementsGr3/variantNameForTheObject</seealso>
    let variantNameForTheObject =
        Prefixed_Name(rdag3, "variantNameForTheObject") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:variantNameForThePlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Variant name for the place"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/variantNameForThePlace">http://rdvocab.info/ElementsGr3/variantNameForThePlace</seealso>
    let variantNameForThePlace =
        Prefixed_Name(rdag3, "variantNameForThePlace") |> PrefixedName

    /// <summary>
    ///   <para>rdag3:variantTermForTheConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>"Variant term for the concept"</para></remarks>
    /// <seealso href="http://rdvocab.info/ElementsGr3/variantTermForTheConcept">http://rdvocab.info/ElementsGr3/variantTermForTheConcept</seealso>
    let variantTermForTheConcept =
        Prefixed_Name(rdag3, "variantTermForTheConcept") |> PrefixedName
