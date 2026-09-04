#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cold =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/configurationontology#" "cold"

    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : Completely defined configuration</para>
    ///   <a href="http://purl.org/configurationontology#CompletelyDefinedConfiguration">cold:CompletelyDefinedConfiguration</a>
    /// </summary>
    let CompletelyDefinedConfiguration =
        _prefixId.prefix "CompletelyDefinedConfiguration"

    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A state of the configuration process, assumed to correspond to a valid partially defined product - valid in the sense that it can be completed into an existing fully specified product, one that can be ordered, without changing any of the current selections.
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
    /// But gr:ProductOrService and gr:Offering are disjoint classes: a given Configuration cannot be both. Depending on the use case, a publisher of configuration data may want to type her Configurations with either of these classes.</para>
    ///   <para>rdfs:label : Configurationrdfs:label : Configuration</para>
    ///   <a href="http://purl.org/configurationontology#Configuration">cold:Configuration</a>
    /// </summary>
    let Configuration = _prefixId.prefix "Configuration"
    /// <summary>
    ///   <para>rdfs:comment : Models the link between a given Configuration and another one (a change of state in the configuration process): typically, the association of a Specification to be selected, and of a resulting Configuration.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Configuration Link</para>
    ///   <a href="http://purl.org/configurationontology#ConfigurationLink">cold:ConfigurationLink</a>
    /// </summary>
    let ConfigurationLink = _prefixId.prefix "ConfigurationLink"
    /// <summary>
    ///   <para>rdfs:comment : A variable in a Lexicon, eg. the fuel type, or the body color. Automotive ranges typically only use discrete variables: the possible values corresponding to one ConfigurationVariable are alternative specifications (for instance "Diesel", "Gasoline", etc.  for the fuel type variable)</para>
    ///   <para>rdfs:label : Configuration variable</para>
    ///   <a href="http://purl.org/configurationontology#ConfigurationVariable">cold:ConfigurationVariable</a>
    /// </summary>
    let ConfigurationVariable = _prefixId.prefix "ConfigurationVariable"
    /// <summary>
    ///   <para>rdfs:comment : The set of specifications (and of their corresponding configuration variables) used in the configuration process: all the possible descriptive attributes of the configured product.</para>
    ///   <para>rdfs:label : Lexicon</para>
    ///   <a href="http://purl.org/configurationontology#Lexicon">cold:Lexicon</a>
    /// </summary>
    let Lexicon = _prefixId.prefix "Lexicon"
    /// <summary>
    ///   <para>rdfs:comment : A specification that identifies a model (like "Ford T"). Corresponding configurations are supposed to share the same lexicon.</para>
    ///   <para>rdfs:label : Model specification</para>
    ///   <a href="http://purl.org/configurationontology#Model">cold:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Feature, option, any value of a characteristic of a product that can be chosen during the configuration process. For instance: "Automatic gearbox", "Blue body color", "CO2 emission value &lt; 100 g of CO2"</para>
    ///   <para>rdfs:label : Specification</para>
    ///   <a href="http://purl.org/configurationontology#Specification">cold:Specification</a>
    /// </summary>
    let Specification = _prefixId.prefix "Specification"
    /// <summary>
    ///   <para>rdfs:comment : Models the possibility to change a previous choice (links the configuration to a similar one, with one of the definingChoices removed or changed. This property may not be used when the chosen specification in question happens to be implied by the other choices</para>
    ///   <para>rdfs:label : alternative</para>
    ///   <a href="http://purl.org/configurationontology#alternative">cold:alternative</a>
    /// </summary>
    let alternative = _prefixId.prefix "alternative"
    /// <summary>
    ///   <para>rdfs:comment : Choices are made one at a time and in a given order, which may matter. Of course it doesn’t impact the characteristics of the product in any way, but it can be used by some applications.</para>
    ///   <para>rdfs:label : choice sequence</para>
    ///   <a href="http://purl.org/configurationontology#choiceSeq">cold:choiceSeq</a>
    /// </summary>
    let choiceSeq = _prefixId.prefix "choiceSeq"
    /// <summary>
    ///   <para>rdfs:comment : A SubProperty of co:definingChoice listing the specifications selected by the user:
    /// If two or more of the cold:chosenSpec of a Configuration correspond to the same cold:ConfigurationVariable, by convention they are to be interpreted as ORed (even XORed, by the way, as such specifications are alternative).
    /// So:
    /// ex:AConf coold:chosenSpec ex:SimpleRadio, ex:RadioMP3.
    /// means that the car has either a ex:SimpleRadio, or a ex:RadioMP3, not both. </para>
    ///   <para>rdfs:label : chosen specification</para>
    ///   <a href="http://purl.org/configurationontology#chosenSpec">cold:chosenSpec</a>
    /// </summary>
    let chosenSpec = _prefixId.prefix "chosenSpec"
    /// <summary>
    ///   <para>rdfs:comment : Links a Configuration to a completely defined one (that is, a Completely Defined Configuration that matches the configuration in question). The price of the linked configuration may be higher than this configuration price. Configurations completed at the same price are given by the completedAtSamePrice property.</para>
    ///   <para>rdfs:label : completed</para>
    ///   <a href="http://purl.org/configurationontology#completed">cold:completed</a>
    /// </summary>
    let completed = _prefixId.prefix "completed"
    /// <summary>
    ///   <para>rdfs:comment : Links a Configuration to a completely defined one, which has the same price.</para>
    ///   <para>rdfs:label : completed at the same price</para>
    ///   <a href="http://purl.org/configurationontology#completedAtSamePrice">cold:completedAtSamePrice</a>
    /// </summary>
    let completedAtSamePrice = _prefixId.prefix "completedAtSamePrice"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Code identifying a ConfigurationVariable within the Lexicon it belongs to.</para>
    ///   <a href="http://purl.org/configurationontology#confVarId">cold:confVarId</a>
    /// </summary>
    let confVarId = _prefixId.prefix "confVarId"
    /// <summary>
    ///   <para>rdfs:comment : Specification included by default in a Completely Defined Product matching this configuration</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:label : default</para>
    ///   <a href="http://purl.org/configurationontology#defaultSpec">cold:defaultSpec</a>
    /// </summary>
    let defaultSpec = _prefixId.prefix "defaultSpec"
    /// <summary>
    ///   <para>rdfs:comment : Parent to all properties specifying the choices that define the Configuration: a Configuration is defined by the list of triples it is the subject of, and which have a co:definingChoice as their predicates. </para>
    ///   <para>rdfs:label : defining choice</para>
    ///   <a href="http://purl.org/configurationontology#definingChoice">cold:definingChoice</a>
    /// </summary>
    let definingChoice = _prefixId.prefix "definingChoice"
    /// <summary>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : Used in a Lexicon to list the values (specifications) of a ConfigurationVariable. Alternatively, we could say that these specifications have rdf:type the ConfigurationVariable in question.</para>
    ///   <para>rdfs:label : has value</para>
    ///   <a href="http://purl.org/configurationontology#hasValue">cold:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:comment : A Specification that is implied by the conjunction of the definingChoice(s) of this Configuration.</para>
    ///   <para>rdfs:label : implied specification</para>
    ///   <a href="http://purl.org/configurationontology#impliedSpec">cold:impliedSpec</a>
    /// </summary>
    let impliedSpec = _prefixId.prefix "impliedSpec"
    /// <summary>
    ///   <para>rdfs:comment : Models a choice that conflicts with the definition of this configuration: when a specification is not compatible with a configuration, the configuration engine can nevertheless provide a way to select it - of course, at the cost of discarding some of the previous selections; there is a conflict, to be resolved by removing or changing some of the cold:definingChoice(s). </para>
    ///   <para>rdfs:label : impossible</para>
    ///   <a href="http://purl.org/configurationontology#impossible">cold:impossible</a>
    /// </summary>
    let impossible = _prefixId.prefix "impossible"
    /// <summary>
    ///   <para>rdfs:comment : Used to link a Configuration, a ConfigurationVariable or a Specification to a Lexicon.</para>
    ///   <para>rdfs:label : lexicon</para>
    ///   <a href="http://purl.org/configurationontology#lexicon">cold:lexicon</a>
    /// </summary>
    let lexicon = _prefixId.prefix "lexicon"
    /// <summary>
    ///   <para>rdfs:comment : Parent property of all the properties linking a Configuration to another one in the configuration process.
    /// The HTML display of a cold:ConfigurationLink corresponds to an hypertext link, whose href is the value of the cold:linkedConf property. As for the text of this link, the rdfs:label of the cold:specToBeAdded value is quite adequate. It can be directly included in the RDF as the rdfs:label of the cold: ConfigurationLink</para>
    ///   <para>rdfs:label : configuration link</para>
    ///   <a href="http://purl.org/configurationontology#link">cold:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:comment : the linked configuration that contains choices of current Configuration plus the specifications that will be added and listed in the configuration link it belongs to.</para>
    ///   <para>rdfs:label : linked configuration</para>
    ///   <a href="http://purl.org/configurationontology#linkedConf">cold:linkedConf</a>
    /// </summary>
    let linkedConf = _prefixId.prefix "linkedConf"
    /// <summary>
    ///   <para>rdfs:comment : An upper limit set on the price of the configuration.</para>
    ///   <para>rdfs:label : max price</para>
    ///   <a href="http://purl.org/configurationontology#maxPrice">cold:maxPrice</a>
    /// </summary>
    let maxPrice = _prefixId.prefix "maxPrice"
    /// <summary>
    ///   <para>rdfs:comment : Models a choice (or a set of choices) that can be made without changing any of the previous choices done in the configuration: links to a Configuration whose list of definingChoice(s) contains the list of definingChoice(s) of this configuration.</para>
    ///   <para>rdfs:label : possible</para>
    ///   <a href="http://purl.org/configurationontology#possible">cold:possible</a>
    /// </summary>
    let possible = _prefixId.prefix "possible"
    /// <summary>
    ///   <para>rdfs:comment : Links a Configuration to another one supposed to be of interest for a customer at this point in the configuration process. The semantics is rather vague, leaving open the possibility to link to a Configuration that matches the defining choices of the subject configuration, or not (to be used by marketing people for bargains, 'upselling', etc.)</para>
    ///   <para>rdfs:label : proposal</para>
    ///   <a href="http://purl.org/configurationontology#proposedConf">cold:proposedConf</a>
    /// </summary>
    let proposedConf = _prefixId.prefix "proposedConf"
    /// <summary>
    ///   <para>vs:term_status : unstable</para>
    ///   <para>rdfs:comment : Code identifying a Specification within the Lexicon it belongs to.</para>
    ///   <a href="http://purl.org/configurationontology#specId">cold:specId</a>
    /// </summary>
    let specId = _prefixId.prefix "specId"
    /// <summary>
    ///   <para>rdfs:comment : Specification to be added to a Configuration in a ConfigurationLink</para>
    ///   <para>rdfs:label : added specification</para>
    ///   <a href="http://purl.org/configurationontology#specToBeAdded">cold:specToBeAdded</a>
    /// </summary>
    let specToBeAdded = _prefixId.prefix "specToBeAdded"
    /// <summary>
    ///   <para>rdfs:comment : Specification to be removed from a Configuration in a ConfigurationLink</para>
    ///   <para>rdfs:label : removed specification</para>
    ///   <a href="http://purl.org/configurationontology#specToBeRemoved">cold:specToBeRemoved</a>
    /// </summary>
    let specToBeRemoved = _prefixId.prefix "specToBeRemoved"
