namespace http.purl.org.reco.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module reco =
    let _namespace_iri = Namespace_Iri reco |> NamespaceIRI
    /// <summary>
    ///   <para>reco:reco.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/reco#reco.owl">http://purl.org/reco#reco.owl</seealso>
    let ``reco.owl`` = Prefixed_Name(reco, "reco.owl") |> PrefixedName
    /// <summary>
    ///   <para>reco:Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Boolean operations on data values: string comparisons, numerical intervales and (in)equality. Operators are reused from the X-path specification to ensure interoperability.</para>
    /// labels<para>Operator</para></remarks>
    /// <seealso href="http://purl.org/reco#Operator">http://purl.org/reco#Operator</seealso>
    let Operator = Prefixed_Name(reco, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>reco:Preference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A preference is a qualitative description of the desired attributes that resources must ideally satisfy in order to be of interest for a user. A preference is described by a set of constraints.</para>
    /// labels<para>Preference</para></remarks>
    /// <seealso href="http://purl.org/reco#Preference">http://purl.org/reco#Preference</seealso>
    let Preference = Prefixed_Name(reco, "Preference") |> PrefixedName
    /// <summary>
    ///   <para>reco:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A rating is a quantitative measurement of the "appealingness" of a particular item to a user.</para>
    /// labels<para>Rating</para></remarks>
    /// <seealso href="http://purl.org/reco#Rating">http://purl.org/reco#Rating</seealso>
    let Rating = Prefixed_Name(reco, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>reco:Demand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Groups of preferences representing users' requests at a given context or situation.</para>
    /// labels<para>Demand</para></remarks>
    /// <seealso href="http://purl.org/reco#Demand">http://purl.org/reco#Demand</seealso>
    let Demand = Prefixed_Name(reco, "Demand") |> PrefixedName
    /// <summary>
    ///   <para>reco:filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that relates a pattern with a constraint of the value of a datatype property. For instance, "less than 180 cms height" or "released before 1980".</para>
    /// labels<para>Filter</para></remarks>
    /// <seealso href="http://purl.org/reco#filter">http://purl.org/reco#filter</seealso>
    let filter = Prefixed_Name(reco, "filter") |> PrefixedName
    /// <summary>
    ///   <para>reco:preference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a demand with the set of preferences that defines its matchmaking conditions. </para>
    /// labels<para>Preference</para></remarks>
    /// <seealso href="http://purl.org/reco#preference">http://purl.org/reco#preference</seealso>
    let preference = Prefixed_Name(reco, "preference") |> PrefixedName
    /// <summary>
    ///   <para>reco:rates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a rating with the resource assessed. Notice that this property has an open range (rdfs:Resource), therefore ratings can be applied to anything, including preferences themselves.</para>
    /// labels<para>Rates</para></remarks>
    /// <seealso href="http://purl.org/reco#rates">http://purl.org/reco#rates</seealso>
    let rates = Prefixed_Name(reco, "rates") |> PrefixedName
    /// <summary>
    ///   <para>reco:utility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This property captures the utility value of a rating. The utility in RECO is measured in the real interval [-1,1]. In practice, other discrete scales can be also used to measure users' opinions on resources, such as the Likert scale. </para>
    /// labels<para>Utility</para></remarks>
    /// <seealso href="http://purl.org/reco#utility">http://purl.org/reco#utility</seealso>
    let utility = Prefixed_Name(reco, "utility") |> PrefixedName
    /// <summary>
    ///   <para>reco:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that relates a preference with its main pattern.</para>
    /// labels<para>About</para></remarks>
    /// <seealso href="http://purl.org/reco#about">http://purl.org/reco#about</seealso>
    let about = Prefixed_Name(reco, "about") |> PrefixedName
    /// <summary>
    ///   <para>reco:assignedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a rating with the person having carried out it.</para>
    /// labels<para>Assigned by</para></remarks>
    /// <seealso href="http://purl.org/reco#assignedBy">http://purl.org/reco#assignedBy</seealso>
    let assignedBy = Prefixed_Name(reco, "assignedBy") |> PrefixedName
    /// <summary>
    ///   <para>reco:excludedPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a demand with a particular preference P. The items that fulfill the constraints of P are excluded from the set of results calculated for this demand.</para>
    /// labels<para>Excluded Preference</para></remarks>
    /// <seealso href="http://purl.org/reco#excludedPreference">http://purl.org/reco#excludedPreference</seealso>
    let excludedPreference = Prefixed_Name(reco, "excludedPreference") |> PrefixedName
    /// <summary>
    ///   <para>reco:holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a person with a preference.</para>
    /// labels<para>Holds</para></remarks>
    /// <seealso href="http://purl.org/reco#holds">http://purl.org/reco#holds</seealso>
    let holds = Prefixed_Name(reco, "holds") |> PrefixedName
    /// <summary>
    ///   <para>reco:optionalPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a demand to a preference P. The items that fulfill the constraints of P increase or decline their utility value according to the utility of P.</para>
    /// labels<para>Optional Preference</para></remarks>
    /// <seealso href="http://purl.org/reco#optionalPreference">http://purl.org/reco#optionalPreference</seealso>
    let optionalPreference = Prefixed_Name(reco, "optionalPreference") |> PrefixedName
    /// <summary>
    ///   <para>reco:union</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property which reifies a disjunction of constraints.</para>
    /// labels<para>Union composition</para></remarks>
    /// <seealso href="http://purl.org/reco#union">http://purl.org/reco#union</seealso>
    let union = Prefixed_Name(reco, "union") |> PrefixedName
    /// <summary>
    ///   <para>reco:operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A property that relates a filter to the operator restraining the value of a datatype property.</para>
    /// labels<para>Operator</para></remarks>
    /// <seealso href="http://purl.org/reco#operator">http://purl.org/reco#operator</seealso>
    let operator = Prefixed_Name(reco, "operator") |> PrefixedName
    /// <summary>
    ///   <para>reco:requiredPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property relates a demand with a preference P. The items fulfilling the constraints of P must be included in the final set of results for this demand.</para>
    /// labels<para>Required Preference</para></remarks>
    /// <seealso href="http://purl.org/reco#requiredPreference">http://purl.org/reco#requiredPreference</seealso>
    let requiredPreference = Prefixed_Name(reco, "requiredPreference") |> PrefixedName
    /// <summary>
    ///   <para>reco:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://purl.org/reco#">http://purl.org/reco#</seealso>
    let _prefix_iri = Prefixed_Name(reco, "") |> PrefixedName
    /// <summary>
    ///   <para>reco:Filter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A datatype constraint based on boolean operators.</para>
    /// labels<para>Filter</para></remarks>
    /// <seealso href="http://purl.org/reco#Filter">http://purl.org/reco#Filter</seealso>
    let Filter = Prefixed_Name(reco, "Filter") |> PrefixedName
    /// <summary>
    ///   <para>reco:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Patterns are reifications of constraints, which are conditions about the desired or preferred attributes of the resources. A constraint ranges over a set of individuals. RECO considers several kind of constraint expressions: (1) conjunction of constraints: "music from the sixties"; (2) disjunction of constraints: "music or films"; (3) composition of constraints: "cars with powerful engines"; (4) datatype constraints based on boolean operators: "released before 1980".</para>
    /// labels<para>Pattern</para></remarks>
    /// <seealso href="http://purl.org/reco#Pattern">http://purl.org/reco#Pattern</seealso>
    let Pattern = Prefixed_Name(reco, "Pattern") |> PrefixedName
