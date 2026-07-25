namespace http.www.w3.org.ns.person.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module person =
    let _namespace_iri = Namespace_Iri person |> NamespaceIRI
    /// <summary>
    ///   <para>person:birthName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>All data associated with an individual is subject to change. Names can change for a variety of reasons, either formally or informally, and new information may come to light that means that a correction or clarification can be made to an existing record. Birth names tend to be persistent however and for this reason they are recorded by some public sector information systems. There is no granularity for birth name - the full name should be recorded in a single field.</para>
    /// labels<para>birth name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#birthName">http://www.w3.org/ns/person#birthName</seealso>
    let birthName = Prefixed_Name(person, "birthName") |> PrefixedName
    /// <summary>
    ///   <para>person:citizenship</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The citizenship relationship links a Person to a Jurisdiction that has conferred citizenship rights on the individual such as the right to vote, to receive certain protection from the community or the issuance of a passport. Multiple citizenships are recorded as multiple instances of the citizenship relationship.</para>
    /// labels<para>citizenship</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#citizenship">http://www.w3.org/ns/person#citizenship</seealso>
    let citizenship = Prefixed_Name(person, "citizenship") |> PrefixedName
    /// <summary>
    ///   <para>person:countryOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The country in which a Person was born.</para>
    /// labels<para>country of birth</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#countryOfBirth">http://www.w3.org/ns/person#countryOfBirth</seealso>
    let countryOfBirth = Prefixed_Name(person, "countryOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>person:patronymicName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Patronymic names are important in some countries. Iceland does not have a concept of family name in the way that many other European countries do, for example. In Bulgaria and Russia, patronymic names are in every day usage, for example, the &amp;quot;Sergeyevich&amp;quot; (Сергеевич) in &amp;quot;Mikhail Sergeyevich Gorbachev&amp;quot; (Михаил Сергеевич Горбачёв).</para>
    /// labels<para>patronymic name</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#patronymicName">http://www.w3.org/ns/person#patronymicName</seealso>
    let patronymicName = Prefixed_Name(person, "patronymicName") |> PrefixedName
    /// <summary>
    ///   <para>person:placeOfBirth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>A person's place of birth.</para>
    /// labels<para>place of birth</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#placeOfBirth">http://www.w3.org/ns/person#placeOfBirth</seealso>
    let placeOfBirth = Prefixed_Name(person, "placeOfBirth") |> PrefixedName
    /// <summary>
    ///   <para>person:countryOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The country in which a Person died.</para>
    /// labels<para>country of death</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#countryOfDeath">http://www.w3.org/ns/person#countryOfDeath</seealso>
    let countryOfDeath = Prefixed_Name(person, "countryOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>person:placeOfDeath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A person's place of death.</para>
    /// labels<para>place of death</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#placeOfDeath">http://www.w3.org/ns/person#placeOfDeath</seealso>
    let placeOfDeath = Prefixed_Name(person, "placeOfDeath") |> PrefixedName
    /// <summary>
    ///   <para>person:residency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Residency typically provides an individual with a subset of the rights of a citizen.</para>
    /// labels<para>residency</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#residency">http://www.w3.org/ns/person#residency</seealso>
    let residency = Prefixed_Name(person, "residency") |> PrefixedName
    /// <summary>
    ///   <para>person:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An individual person who may be dead or alive, but not imaginary. It is that restriction that makes person:Person a sub class of both foaf:Person and schema:Person which both cover imaginary characters as well as real people.</para>
    /// labels<para>Person</para></remarks>
    /// <seealso href="http://www.w3.org/ns/person#Person">http://www.w3.org/ns/person#Person</seealso>
    let Person = Prefixed_Name(person, "Person") |> PrefixedName
    /// <summary>
    ///   <para>person:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/person#">http://www.w3.org/ns/person#</seealso>
    let _prefix_iri = Prefixed_Name(person, "") |> PrefixedName
