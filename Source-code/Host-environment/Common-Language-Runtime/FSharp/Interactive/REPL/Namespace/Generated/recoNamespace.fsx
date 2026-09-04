#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module reco =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/reco#" "reco"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Demand</para>
    ///   <para>rdfs:comment : Groups of preferences representing users' requests at a given context or situation.</para>
    ///   <a href="http://purl.org/reco#Demand">reco:Demand</a>
    /// </summary>
    let Demand = _prefixId.prefix "Demand"
    /// <summary>
    ///   <para>rdfs:label : Filter</para>
    ///   <para>rdfs:comment : A datatype constraint based on boolean operators.</para>
    ///   <a href="http://purl.org/reco#Filter">reco:Filter</a>
    /// </summary>
    let Filter = _prefixId.prefix "Filter"
    /// <summary>
    ///   <para>rdfs:label : Operator</para>
    ///   <para>rdfs:comment : Boolean operations on data values: string comparisons, numerical intervales and (in)equality. Operators are reused from the X-path specification to ensure interoperability.</para>
    ///   <a href="http://purl.org/reco#Operator">reco:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>rdfs:label : Pattern</para>
    ///   <para>rdfs:comment : Patterns are reifications of constraints, which are conditions about the desired or preferred attributes of the resources. A constraint ranges over a set of individuals. RECO considers several kind of constraint expressions: (1) conjunction of constraints: "music from the sixties"; (2) disjunction of constraints: "music or films"; (3) composition of constraints: "cars with powerful engines"; (4) datatype constraints based on boolean operators: "released before 1980".</para>
    ///   <a href="http://purl.org/reco#Pattern">reco:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    /// <summary>
    ///   <para>rdfs:label : Preference</para>
    ///   <para>rdfs:comment : A preference is a qualitative description of the desired attributes that resources must ideally satisfy in order to be of interest for a user. A preference is described by a set of constraints.</para>
    ///   <a href="http://purl.org/reco#Preference">reco:Preference</a>
    /// </summary>
    let Preference = _prefixId.prefix "Preference"
    /// <summary>
    ///   <para>rdfs:label : Rating</para>
    ///   <para>rdfs:comment : A rating is a quantitative measurement of the "appealingness" of a particular item to a user.</para>
    ///   <a href="http://purl.org/reco#Rating">reco:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:label : About</para>
    ///   <para>rdfs:comment : A property that relates a preference with its main pattern.</para>
    ///   <a href="http://purl.org/reco#about">reco:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>rdfs:label : Assigned by</para>
    ///   <para>rdfs:comment : This property relates a rating with the person having carried out it.</para>
    ///   <a href="http://purl.org/reco#assignedBy">reco:assignedBy</a>
    /// </summary>
    let assignedBy = _prefixId.prefix "assignedBy"
    /// <summary>
    ///   <para>rdfs:label : Excluded Preference</para>
    ///   <para>rdfs:comment : This property relates a demand with a particular preference P. The items that fulfill the constraints of P are excluded from the set of results calculated for this demand.</para>
    ///   <a href="http://purl.org/reco#excludedPreference">reco:excludedPreference</a>
    /// </summary>
    let excludedPreference = _prefixId.prefix "excludedPreference"
    /// <summary>
    ///   <para>rdfs:label : Filter</para>
    ///   <para>rdfs:comment : A property that relates a pattern with a constraint of the value of a datatype property. For instance, "less than 180 cms height" or "released before 1980".</para>
    ///   <a href="http://purl.org/reco#filter">reco:filter</a>
    /// </summary>
    let filter = _prefixId.prefix "filter"
    /// <summary>
    ///   <para>rdfs:label : Holds</para>
    ///   <para>rdfs:comment : This property relates a person with a preference.</para>
    ///   <a href="http://purl.org/reco#holds">reco:holds</a>
    /// </summary>
    let holds = _prefixId.prefix "holds"
    /// <summary>
    ///   <para>rdfs:label : Operator</para>
    ///   <para>rdfs:comment : A property that relates a filter to the operator restraining the value of a datatype property.</para>
    ///   <a href="http://purl.org/reco#operator">reco:operator</a>
    /// </summary>
    let operator = _prefixId.prefix "operator"
    /// <summary>
    ///   <para>rdfs:label : Optional Preference</para>
    ///   <para>rdfs:comment : This property relates a demand to a preference P. The items that fulfill the constraints of P increase or decline their utility value according to the utility of P.</para>
    ///   <a href="http://purl.org/reco#optionalPreference">reco:optionalPreference</a>
    /// </summary>
    let optionalPreference = _prefixId.prefix "optionalPreference"
    /// <summary>
    ///   <para>rdfs:label : Preference</para>
    ///   <para>rdfs:comment : This property relates a demand with the set of preferences that defines its matchmaking conditions. </para>
    ///   <a href="http://purl.org/reco#preference">reco:preference</a>
    /// </summary>
    let preference = _prefixId.prefix "preference"
    /// <summary>
    ///   <para>rdfs:label : Rates</para>
    ///   <para>rdfs:comment : This property relates a rating with the resource assessed. Notice that this property has an open range (rdfs:Resource), therefore ratings can be applied to anything, including preferences themselves.</para>
    ///   <a href="http://purl.org/reco#rates">reco:rates</a>
    /// </summary>
    let rates = _prefixId.prefix "rates"
    let ``reco.owl`` = _prefixId.prefix "reco.owl"
    /// <summary>
    ///   <para>rdfs:label : Required Preference</para>
    ///   <para>rdfs:comment : This property relates a demand with a preference P. The items fulfilling the constraints of P must be included in the final set of results for this demand.</para>
    ///   <a href="http://purl.org/reco#requiredPreference">reco:requiredPreference</a>
    /// </summary>
    let requiredPreference = _prefixId.prefix "requiredPreference"
    /// <summary>
    ///   <para>rdfs:label : Union composition</para>
    ///   <para>rdfs:comment : A property which reifies a disjunction of constraints.</para>
    ///   <a href="http://purl.org/reco#union">reco:union</a>
    /// </summary>
    let union = _prefixId.prefix "union"
    /// <summary>
    ///   <para>rdfs:label : Utility</para>
    ///   <para>rdfs:comment : This property captures the utility value of a rating. The utility in RECO is measured in the real interval [-1,1]. In practice, other discrete scales can be also used to measure users' opinions on resources, such as the Likert scale. </para>
    ///   <a href="http://purl.org/reco#utility">reco:utility</a>
    /// </summary>
    let utility = _prefixId.prefix "utility"
