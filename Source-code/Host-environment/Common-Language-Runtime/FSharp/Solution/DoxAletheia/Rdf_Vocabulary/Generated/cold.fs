namespace http.purl.org.configurationontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cold =
    let _namespace_iri = Namespace_Iri cold |> NamespaceIRI

    /// <summary>
    ///   <para>cold:CompletelyDefinedConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Completely defined configuration"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#CompletelyDefinedConfiguration">http://purl.org/configurationontology#CompletelyDefinedConfiguration</seealso>
    let CompletelyDefinedConfiguration =
        Prefixed_Name(cold, "CompletelyDefinedConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>cold:Configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A state of the configuration process, assumed to correspond to a valid partially defined product - valid in the sense that it can be completed into an existing fully specified product, one that can be ordered, without changing any of the current selections.
    ///
    /// A configuration is defined by a Lexicon (the set of the descriptive attributes of the configured product, cf. the "lexicon" property), and by the set of choices that have been made so far (typically  selected specifications), cf. the "definingChoice" property.
    ///
    /// Note: A configurator application may conceivably have to handle “invalid configurations”, that is, combinations of specifications that are impossible. This can happen, for instance, if the user is allowed to begin the configuration process by choosing features without any control of their compatibility; or if she is allowed to choose a feature incompatible with her previous selections. In this case, it is the responsibility of the configurator application to restore the consistency of the configuration, necessarily by excluding some of the previous user selections. This Configuration class excludes such invalid combinations.
    ///
    /// Relation with GoodRelations and schema.org vocabularies :
    /// because a configuration mainly describes a Partially Defined Product, it can be seen as a GoodRelations "ProductOrServiceModel" (or a schema.org "ProductModel): "an intangible entity that specifies some characteristics of a group of similar, usually mass-produced products, in the sense of a prototype". The suffix "Model" may seem misleading when used for a Configuration, as it suggests something such as "Ford T", and not "Ford T with sunroof and climat control (itself not a completely defined product -  you still can choose, well, the color: it is a "prototype of similar products").
    ///
    /// On the other hand, a Configuration has a price (more precisely, a "from price" - the minimum of the "suggested retail prices" of all the matching completely defined products). As such, a Configuration may be seen as a commercial offer. It can also be used to represent a customer's wish list, constrained by the definition of the range. It could therefore be considered as a gr:Offering (or a schema:Offer) as well.
    ///
    /// But gr:ProductOrService and gr:Offering are disjoint classes: a given Configuration cannot be both. Depending on the use case, a publisher of configuration data may want to type her Configurations with either of these classes."</para>
    /// labels<para>"Configuration"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#Configuration">http://purl.org/configurationontology#Configuration</seealso>
    let Configuration = Prefixed_Name(cold, "Configuration") |> PrefixedName
    /// <summary>
    ///   <para>cold:ConfigurationLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Models the link between a given Configuration and another one (a change of state in the configuration process): typically, the association of a Specification to be selected, and of a resulting Configuration."</para>
    /// labels<para>"Configuration Link"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#ConfigurationLink">http://purl.org/configurationontology#ConfigurationLink</seealso>
    let ConfigurationLink = Prefixed_Name(cold, "ConfigurationLink") |> PrefixedName

    /// <summary>
    ///   <para>cold:ConfigurationVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A variable in a Lexicon, eg. the fuel type, or the body color. Automotive ranges typically only use discrete variables: the possible values corresponding to one ConfigurationVariable are alternative specifications (for instance "Diesel", "Gasoline", etc.  for the fuel type variable)"</para>
    /// labels<para>"Configuration variable"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#ConfigurationVariable">http://purl.org/configurationontology#ConfigurationVariable</seealso>
    let ConfigurationVariable =
        Prefixed_Name(cold, "ConfigurationVariable") |> PrefixedName

    /// <summary>
    ///   <para>cold:Lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of specifications (and of their corresponding configuration variables) used in the configuration process: all the possible descriptive attributes of the configured product."</para>
    /// labels<para>"Lexicon"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#Lexicon">http://purl.org/configurationontology#Lexicon</seealso>
    let Lexicon = Prefixed_Name(cold, "Lexicon") |> PrefixedName
    /// <summary>
    ///   <para>cold:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specification that identifies a model (like "Ford T"). Corresponding configurations are supposed to share the same lexicon."</para>
    /// labels<para>"Model specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#Model">http://purl.org/configurationontology#Model</seealso>
    let Model = Prefixed_Name(cold, "Model") |> PrefixedName
    /// <summary>
    ///   <para>cold:Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Feature, option, any value of a characteristic of a product that can be chosen during the configuration process. For instance: "Automatic gearbox", "Blue body color", "CO2 emission value &lt; 100 g of CO2""</para>
    /// labels<para>"Specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#Specification">http://purl.org/configurationontology#Specification</seealso>
    let Specification = Prefixed_Name(cold, "Specification") |> PrefixedName
    /// <summary>
    ///   <para>cold:alternative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Models the possibility to change a previous choice (links the configuration to a similar one, with one of the definingChoices removed or changed. This property may not be used when the chosen specification in question happens to be implied by the other choices"</para>
    /// labels<para>"alternative"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#alternative">http://purl.org/configurationontology#alternative</seealso>
    let alternative = Prefixed_Name(cold, "alternative") |> PrefixedName
    /// <summary>
    ///   <para>cold:choiceSeq</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Choices are made one at a time and in a given order, which may matter. Of course it doesn’t impact the characteristics of the product in any way, but it can be used by some applications."</para>
    /// labels<para>"choice sequence"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#choiceSeq">http://purl.org/configurationontology#choiceSeq</seealso>
    let choiceSeq = Prefixed_Name(cold, "choiceSeq") |> PrefixedName
    /// <summary>
    ///   <para>cold:chosenSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SubProperty of co:definingChoice listing the specifications selected by the user:
    /// If two or more of the cold:chosenSpec of a Configuration correspond to the same cold:ConfigurationVariable, by convention they are to be interpreted as ORed (even XORed, by the way, as such specifications are alternative).
    /// So:
    /// ex:AConf coold:chosenSpec ex:SimpleRadio, ex:RadioMP3.
    /// means that the car has either a ex:SimpleRadio, or a ex:RadioMP3, not both. "</para>
    /// labels<para>"chosen specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#chosenSpec">http://purl.org/configurationontology#chosenSpec</seealso>
    let chosenSpec = Prefixed_Name(cold, "chosenSpec") |> PrefixedName
    /// <summary>
    ///   <para>cold:completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Configuration to a completely defined one (that is, a Completely Defined Configuration that matches the configuration in question). The price of the linked configuration may be higher than this configuration price. Configurations completed at the same price are given by the completedAtSamePrice property."</para>
    /// labels<para>"completed"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#completed">http://purl.org/configurationontology#completed</seealso>
    let completed = Prefixed_Name(cold, "completed") |> PrefixedName

    /// <summary>
    ///   <para>cold:completedAtSamePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Configuration to a completely defined one, which has the same price."</para>
    /// labels<para>"completed at the same price"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#completedAtSamePrice">http://purl.org/configurationontology#completedAtSamePrice</seealso>
    let completedAtSamePrice =
        Prefixed_Name(cold, "completedAtSamePrice") |> PrefixedName

    /// <summary>
    ///   <para>cold:confVarId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Code identifying a ConfigurationVariable within the Lexicon it belongs to."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/configurationontology#confVarId">http://purl.org/configurationontology#confVarId</seealso>
    let confVarId = Prefixed_Name(cold, "confVarId") |> PrefixedName
    /// <summary>
    ///   <para>cold:defaultSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specification included by default in a Completely Defined Product matching this configuration"</para>
    /// labels<para>"default"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#defaultSpec">http://purl.org/configurationontology#defaultSpec</seealso>
    let defaultSpec = Prefixed_Name(cold, "defaultSpec") |> PrefixedName
    /// <summary>
    ///   <para>cold:definingChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parent to all properties specifying the choices that define the Configuration: a Configuration is defined by the list of triples it is the subject of, and which have a co:definingChoice as their predicates. "</para>
    /// labels<para>"defining choice"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#definingChoice">http://purl.org/configurationontology#definingChoice</seealso>
    let definingChoice = Prefixed_Name(cold, "definingChoice") |> PrefixedName
    /// <summary>
    ///   <para>cold:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used in a Lexicon to list the values (specifications) of a ConfigurationVariable. Alternatively, we could say that these specifications have rdf:type the ConfigurationVariable in question."</para>
    /// labels<para>"has value"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#hasValue">http://purl.org/configurationontology#hasValue</seealso>
    let hasValue = Prefixed_Name(cold, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>cold:impliedSpec</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Specification that is implied by the conjunction of the definingChoice(s) of this Configuration."</para>
    /// labels<para>"implied specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#impliedSpec">http://purl.org/configurationontology#impliedSpec</seealso>
    let impliedSpec = Prefixed_Name(cold, "impliedSpec") |> PrefixedName
    /// <summary>
    ///   <para>cold:impossible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Models a choice that conflicts with the definition of this configuration: when a specification is not compatible with a configuration, the configuration engine can nevertheless provide a way to select it - of course, at the cost of discarding some of the previous selections; there is a conflict, to be resolved by removing or changing some of the cold:definingChoice(s). "</para>
    /// labels<para>"impossible"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#impossible">http://purl.org/configurationontology#impossible</seealso>
    let impossible = Prefixed_Name(cold, "impossible") |> PrefixedName
    /// <summary>
    ///   <para>cold:lexicon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used to link a Configuration, a ConfigurationVariable or a Specification to a Lexicon."</para>
    /// labels<para>"lexicon"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#lexicon">http://purl.org/configurationontology#lexicon</seealso>
    let lexicon = Prefixed_Name(cold, "lexicon") |> PrefixedName
    /// <summary>
    ///   <para>cold:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Parent property of all the properties linking a Configuration to another one in the configuration process.
    /// The HTML display of a cold:ConfigurationLink corresponds to an hypertext link, whose href is the value of the cold:linkedConf property. As for the text of this link, the rdfs:label of the cold:specToBeAdded value is quite adequate. It can be directly included in the RDF as the rdfs:label of the cold: ConfigurationLink"</para>
    /// labels<para>"configuration link"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#link">http://purl.org/configurationontology#link</seealso>
    let link = Prefixed_Name(cold, "link") |> PrefixedName
    /// <summary>
    ///   <para>cold:linkedConf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"the linked configuration that contains choices of current Configuration plus the specifications that will be added and listed in the configuration link it belongs to."</para>
    /// labels<para>"linked configuration"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#linkedConf">http://purl.org/configurationontology#linkedConf</seealso>
    let linkedConf = Prefixed_Name(cold, "linkedConf") |> PrefixedName
    /// <summary>
    ///   <para>cold:maxPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An upper limit set on the price of the configuration."</para>
    /// labels<para>"max price"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#maxPrice">http://purl.org/configurationontology#maxPrice</seealso>
    let maxPrice = Prefixed_Name(cold, "maxPrice") |> PrefixedName
    /// <summary>
    ///   <para>cold:possible</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Models a choice (or a set of choices) that can be made without changing any of the previous choices done in the configuration: links to a Configuration whose list of definingChoice(s) contains the list of definingChoice(s) of this configuration."</para>
    /// labels<para>"possible"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#possible">http://purl.org/configurationontology#possible</seealso>
    let possible = Prefixed_Name(cold, "possible") |> PrefixedName
    /// <summary>
    ///   <para>cold:proposedConf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a Configuration to another one supposed to be of interest for a customer at this point in the configuration process. The semantics is rather vague, leaving open the possibility to link to a Configuration that matches the defining choices of the subject configuration, or not (to be used by marketing people for bargains, 'upselling', etc.)"</para>
    /// labels<para>"proposal"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#proposedConf">http://purl.org/configurationontology#proposedConf</seealso>
    let proposedConf = Prefixed_Name(cold, "proposedConf") |> PrefixedName
    /// <summary>
    ///   <para>cold:specId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Code identifying a Specification within the Lexicon it belongs to."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/configurationontology#specId">http://purl.org/configurationontology#specId</seealso>
    let specId = Prefixed_Name(cold, "specId") |> PrefixedName
    /// <summary>
    ///   <para>cold:specToBeAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specification to be added to a Configuration in a ConfigurationLink"</para>
    /// labels<para>"added specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#specToBeAdded">http://purl.org/configurationontology#specToBeAdded</seealso>
    let specToBeAdded = Prefixed_Name(cold, "specToBeAdded") |> PrefixedName
    /// <summary>
    ///   <para>cold:specToBeRemoved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specification to be removed from a Configuration in a ConfigurationLink"</para>
    /// labels<para>"removed specification"</para></remarks>
    /// <seealso href="http://purl.org/configurationontology#specToBeRemoved">http://purl.org/configurationontology#specToBeRemoved</seealso>
    let specToBeRemoved = Prefixed_Name(cold, "specToBeRemoved") |> PrefixedName
