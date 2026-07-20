namespace http.purl.org.configurationontology.hash

open DoxAletheia

module cold =
    let _namespace_name = "http://purl.org/configurationontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Models the link between a given Configuration and another one (a change of state in the configuration process): typically, the association of a Specification to be selected, and of a resulting Configuration.
    /// <see href="http://purl.org/configurationontology#ConfigurationLink"></see></summary>
    let ConfigurationLink = _prefix "ConfigurationLink"
    /// <summary>
    /// A state of the configuration process, assumed to correspond to a valid partially defined product - valid in the sense that it can be completed into an existing fully specified product, one that can be ordered, without changing any of the current selections.
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
    /// But gr:ProductOrService and gr:Offering are disjoint classes: a given Configuration cannot be both. Depending on the use case, a publisher of configuration data may want to type her Configurations with either of these classes.
    /// <see href="http://purl.org/configurationontology#Configuration"></see></summary>
    let Configuration = _prefix "Configuration"
    /// <summary>
    /// the linked configuration that contains choices of current Configuration plus the specifications that will be added and listed in the configuration link it belongs to.
    /// <see href="http://purl.org/configurationontology#linkedConf"></see></summary>
    let linkedConf = _prefix "linkedConf"
    /// <summary>
    ///   <see href="http://purl.org/configurationontology#CompletelyDefinedConfiguration"></see>
    /// </summary>
    let CompletelyDefinedConfiguration = _prefix "CompletelyDefinedConfiguration"
    /// <summary>
    /// A variable in a Lexicon, eg. the fuel type, or the body color. Automotive ranges typically only use discrete variables: the possible values corresponding to one ConfigurationVariable are alternative specifications (for instance "Diesel", "Gasoline", etc.  for the fuel type variable)
    /// <see href="http://purl.org/configurationontology#ConfigurationVariable"></see></summary>
    let ConfigurationVariable = _prefix "ConfigurationVariable"
    /// <summary>
    /// The set of specifications (and of their corresponding configuration variables) used in the configuration process: all the possible descriptive attributes of the configured product.
    /// <see href="http://purl.org/configurationontology#Lexicon"></see></summary>
    let Lexicon = _prefix "Lexicon"
    /// <summary>
    /// Used to link a Configuration, a ConfigurationVariable or a Specification to a Lexicon.
    /// <see href="http://purl.org/configurationontology#lexicon"></see></summary>
    let lexicon = _prefix "lexicon"
    /// <summary>
    /// A specification that identifies a model (like "Ford T"). Corresponding configurations are supposed to share the same lexicon.
    /// <see href="http://purl.org/configurationontology#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Feature, option, any value of a characteristic of a product that can be chosen during the configuration process. For instance: "Automatic gearbox", "Blue body color", "CO2 emission value &lt; 100 g of CO2"
    /// <see href="http://purl.org/configurationontology#Specification"></see></summary>
    let Specification = _prefix "Specification"
    /// <summary>
    /// Models the possibility to change a previous choice (links the configuration to a similar one, with one of the definingChoices removed or changed. This property may not be used when the chosen specification in question happens to be implied by the other choices
    /// <see href="http://purl.org/configurationontology#alternative"></see></summary>
    let alternative = _prefix "alternative"
    /// <summary>
    /// Parent property of all the properties linking a Configuration to another one in the configuration process.
    /// The HTML display of a cold:ConfigurationLink corresponds to an hypertext link, whose href is the value of the cold:linkedConf property. As for the text of this link, the rdfs:label of the cold:specToBeAdded value is quite adequate. It can be directly included in the RDF as the rdfs:label of the cold: ConfigurationLink
    /// <see href="http://purl.org/configurationontology#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// Choices are made one at a time and in a given order, which may matter. Of course it doesn’t impact the characteristics of the product in any way, but it can be used by some applications.
    /// <see href="http://purl.org/configurationontology#choiceSeq"></see></summary>
    let choiceSeq = _prefix "choiceSeq"
    /// <summary>
    /// Parent to all properties specifying the choices that define the Configuration: a Configuration is defined by the list of triples it is the subject of, and which have a co:definingChoice as their predicates.
    /// <see href="http://purl.org/configurationontology#definingChoice"></see></summary>
    let definingChoice = _prefix "definingChoice"
    /// <summary>
    /// A SubProperty of co:definingChoice listing the specifications selected by the user:
    /// If two or more of the cold:chosenSpec of a Configuration correspond to the same cold:ConfigurationVariable, by convention they are to be interpreted as ORed (even XORed, by the way, as such specifications are alternative).
    /// So:
    /// ex:AConf coold:chosenSpec ex:SimpleRadio, ex:RadioMP3.
    /// means that the car has either a ex:SimpleRadio, or a ex:RadioMP3, not both.
    /// <see href="http://purl.org/configurationontology#chosenSpec"></see></summary>
    let chosenSpec = _prefix "chosenSpec"
    /// <summary>
    /// Links a Configuration to a completely defined one (that is, a Completely Defined Configuration that matches the configuration in question). The price of the linked configuration may be higher than this configuration price. Configurations completed at the same price are given by the completedAtSamePrice property.
    /// <see href="http://purl.org/configurationontology#completed"></see></summary>
    let completed = _prefix "completed"
    /// <summary>
    /// Links a Configuration to a completely defined one, which has the same price.
    /// <see href="http://purl.org/configurationontology#completedAtSamePrice"></see></summary>
    let completedAtSamePrice = _prefix "completedAtSamePrice"
    /// <summary>
    /// Code identifying a ConfigurationVariable within the Lexicon it belongs to.
    /// <see href="http://purl.org/configurationontology#confVarId"></see></summary>
    let confVarId = _prefix "confVarId"
    /// <summary>
    /// Specification included by default in a Completely Defined Product matching this configuration
    /// <see href="http://purl.org/configurationontology#defaultSpec"></see></summary>
    let defaultSpec = _prefix "defaultSpec"
    /// <summary>
    /// Used in a Lexicon to list the values (specifications) of a ConfigurationVariable. Alternatively, we could say that these specifications have rdf:type the ConfigurationVariable in question.
    /// <see href="http://purl.org/configurationontology#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// A Specification that is implied by the conjunction of the definingChoice(s) of this Configuration.
    /// <see href="http://purl.org/configurationontology#impliedSpec"></see></summary>
    let impliedSpec = _prefix "impliedSpec"
    /// <summary>
    /// Models a choice that conflicts with the definition of this configuration: when a specification is not compatible with a configuration, the configuration engine can nevertheless provide a way to select it - of course, at the cost of discarding some of the previous selections; there is a conflict, to be resolved by removing or changing some of the cold:definingChoice(s).
    /// <see href="http://purl.org/configurationontology#impossible"></see></summary>
    let impossible = _prefix "impossible"
    /// <summary>
    /// An upper limit set on the price of the configuration.
    /// <see href="http://purl.org/configurationontology#maxPrice"></see></summary>
    let maxPrice = _prefix "maxPrice"
    /// <summary>
    /// Models a choice (or a set of choices) that can be made without changing any of the previous choices done in the configuration: links to a Configuration whose list of definingChoice(s) contains the list of definingChoice(s) of this configuration.
    /// <see href="http://purl.org/configurationontology#possible"></see></summary>
    let possible = _prefix "possible"
    /// <summary>
    /// Links a Configuration to another one supposed to be of interest for a customer at this point in the configuration process. The semantics is rather vague, leaving open the possibility to link to a Configuration that matches the defining choices of the subject configuration, or not (to be used by marketing people for bargains, 'upselling', etc.)
    /// <see href="http://purl.org/configurationontology#proposedConf"></see></summary>
    let proposedConf = _prefix "proposedConf"
    /// <summary>
    /// Code identifying a Specification within the Lexicon it belongs to.
    /// <see href="http://purl.org/configurationontology#specId"></see></summary>
    let specId = _prefix "specId"
    /// <summary>
    /// Specification to be added to a Configuration in a ConfigurationLink
    /// <see href="http://purl.org/configurationontology#specToBeAdded"></see></summary>
    let specToBeAdded = _prefix "specToBeAdded"
    /// <summary>
    /// Specification to be removed from a Configuration in a ConfigurationLink
    /// <see href="http://purl.org/configurationontology#specToBeRemoved"></see></summary>
    let specToBeRemoved = _prefix "specToBeRemoved"
