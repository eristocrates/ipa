#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vf =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/valueflows/ont/vf#" "vf"

    /// <summary>
    ///   <para>rdfs:label : Accountable Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource primary accountable agent.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#AccountableEffect">vf:AccountableEffect</a>
    /// </summary>
    let AccountableEffect = _prefixId.prefix "AccountableEffect"
    /// <summary>
    ///   <para>rdfs:label : Accounting Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource accounting quantity.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#AccountingEffect">vf:AccountingEffect</a>
    /// </summary>
    let AccountingEffect = _prefixId.prefix "AccountingEffect"
    /// <summary>
    ///   <para>rdfs:label : Action</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An action verb defining the kind of flow and its behavior.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Action">vf:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:action</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ActionDomain">vf:ActionDomain</a>
    /// </summary>
    let ActionDomain = _prefixId.prefix "ActionDomain"
    /// <summary>
    ///   <para>rdfs:label : Agent</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An identifiable entity that can commit to and/or perform economic and/or ecological activity under its own power or authority.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Agent">vf:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : Agreement</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A set of reciprocal commitments among economic agents, and/or a set of reciprocal economic events.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Agreement">vf:Agreement</a>
    /// </summary>
    let Agreement = _prefixId.prefix "Agreement"
    /// <summary>
    ///   <para>rdfs:label : Agreement Bundle</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A grouping of agreements to bundle detailed line item reciprocity.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#AgreementBundle">vf:AgreementBundle</a>
    /// </summary>
    let AgreementBundle = _prefixId.prefix "AgreementBundle"
    /// <summary>
    ///   <para>rdfs:label : Batch Lot Record</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A document which contains all the needed detail related to the production process of a particular batch or lot, a resource processed in the same process(es) so that it is expected to be homogeneous.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#BatchLotRecord">vf:BatchLotRecord</a>
    /// </summary>
    let BatchLotRecord = _prefixId.prefix "BatchLotRecord"
    /// <summary>
    ///   <para>rdfs:label : Claim</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A claim for a future economic event(s) in reciprocity for an economic event that already occurred.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Claim">vf:Claim</a>
    /// </summary>
    let Claim = _prefixId.prefix "Claim"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:classifiedAs</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ClassifiedAsDomain">vf:ClassifiedAsDomain</a>
    /// </summary>
    let ClassifiedAsDomain = _prefixId.prefix "ClassifiedAsDomain"
    /// <summary>
    ///   <para>rdfs:label : Commitment</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A planned economic flow that has been scheduled or promised by one agent to another agent.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Commitment">vf:Commitment</a>
    /// </summary>
    let Commitment = _prefixId.prefix "Commitment"
    /// <summary>
    ///   <para>rdfs:label : Contained Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource contained in resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ContainedEffect">vf:ContainedEffect</a>
    /// </summary>
    let ContainedEffect = _prefixId.prefix "ContainedEffect"
    /// <summary>
    ///   <para>rdfs:label : Create Resource</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action can create an economic resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#CreateResource">vf:CreateResource</a>
    /// </summary>
    let CreateResource = _prefixId.prefix "CreateResource"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:created</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#CreatedDomain">vf:CreatedDomain</a>
    /// </summary>
    let CreatedDomain = _prefixId.prefix "CreatedDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:due</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#DueDomain">vf:DueDomain</a>
    /// </summary>
    let DueDomain = _prefixId.prefix "DueDomain"
    /// <summary>
    ///   <para>rdfs:label : Ecological Agent</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A non-human being; or a functional group of non-human beings; or an ecosystem of living beings that includes non-humans; but it has agency and receives and/or provides economic/ecological resources.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#EcologicalAgent">vf:EcologicalAgent</a>
    /// </summary>
    let EcologicalAgent = _prefixId.prefix "EcologicalAgent"
    /// <summary>
    ///   <para>rdfs:label : Economic Event</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An observed economic flow, which could reflect creation or a change in the quantity, location, accountability and/or responsibility, of an economic resource, whether material or not.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#EconomicEvent">vf:EconomicEvent</a>
    /// </summary>
    let EconomicEvent = _prefixId.prefix "EconomicEvent"
    /// <summary>
    ///   <para>rdfs:label : Economic Resource</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Economic or environmental things (material or digital), media of exchange, which agents agree should be accounted for and which can be inventoried.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#EconomicResource">vf:EconomicResource</a>
    /// </summary>
    let EconomicResource = _prefixId.prefix "EconomicResource"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:effortQuantity</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#EffortQuantityDomain">vf:EffortQuantityDomain</a>
    /// </summary>
    let EffortQuantityDomain = _prefixId.prefix "EffortQuantityDomain"
    /// <summary>
    ///   <para>rdfs:label : Event Quantity</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action involves the event resource quantity, event quantity, or both.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#EventQuantity">vf:EventQuantity</a>
    /// </summary>
    let EventQuantity = _prefixId.prefix "EventQuantity"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:finished</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#FinishedDomain">vf:FinishedDomain</a>
    /// </summary>
    let FinishedDomain = _prefixId.prefix "FinishedDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:hasBeginning</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#HasBeginningDomain">vf:HasBeginningDomain</a>
    /// </summary>
    let HasBeginningDomain = _prefixId.prefix "HasBeginningDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:hasEnd</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#HasEndDomain">vf:HasEndDomain</a>
    /// </summary>
    let HasEndDomain = _prefixId.prefix "HasEndDomain"
    /// <summary>
    ///   <para>rdfs:label : Range for vf:hasInput</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#HasInputRange">vf:HasInputRange</a>
    /// </summary>
    let HasInputRange = _prefixId.prefix "HasInputRange"
    /// <summary>
    ///   <para>rdfs:label : Range for vf:hasOutput</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#HasOutputRange">vf:HasOutputRange</a>
    /// </summary>
    let HasOutputRange = _prefixId.prefix "HasOutputRange"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:hasPointInTime</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#HasPointInTimeDomain">vf:HasPointInTimeDomain</a>
    /// </summary>
    let HasPointInTimeDomain = _prefixId.prefix "HasPointInTimeDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:image</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ImageDomain">vf:ImageDomain</a>
    /// </summary>
    let ImageDomain = _prefixId.prefix "ImageDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:imageList</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ImageListDomain">vf:ImageListDomain</a>
    /// </summary>
    let ImageListDomain = _prefixId.prefix "ImageListDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:inputOf</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#InputOfDomain">vf:InputOfDomain</a>
    /// </summary>
    let InputOfDomain = _prefixId.prefix "InputOfDomain"
    /// <summary>
    ///   <para>rdfs:label : Input/Output</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action is an input or output of a process, or not applicable to a process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#InputOutput">vf:InputOutput</a>
    /// </summary>
    let InputOutput = _prefixId.prefix "InputOutput"
    /// <summary>
    ///   <para>rdfs:label : Intent</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A desired or proposed or planned or estimated economic flow, usually with only one agent associated, which could become a commitment and/or economic event.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Intent">vf:Intent</a>
    /// </summary>
    let Intent = _prefixId.prefix "Intent"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:label</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#LabelDomain">vf:LabelDomain</a>
    /// </summary>
    let LabelDomain = _prefixId.prefix "LabelDomain"
    /// <summary>
    ///   <para>rdfs:label : Location Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource current location.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#LocationEffect">vf:LocationEffect</a>
    /// </summary>
    let LocationEffect = _prefixId.prefix "LocationEffect"
    /// <summary>
    ///   <para>rdfs:label : Measure</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A quantity expressed as a numeric value with a unit of measure.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Measure">vf:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:name</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#NameDomain">vf:NameDomain</a>
    /// </summary>
    let NameDomain = _prefixId.prefix "NameDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:note</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#NoteDomain">vf:NoteDomain</a>
    /// </summary>
    let NoteDomain = _prefixId.prefix "NoteDomain"
    /// <summary>
    ///   <para>rdfs:label : Onhand Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource onhand quantity.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#OnhandEffect">vf:OnhandEffect</a>
    /// </summary>
    let OnhandEffect = _prefixId.prefix "OnhandEffect"
    /// <summary>
    ///   <para>rdfs:label : Organization</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A functional structure, formal or informal, which can include people and/or other organizations, and has its own agency.  Something called a group is an Organization in Valueflows if it has agency as the group.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Organization">vf:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:outputOf</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#OutputOfDomain">vf:OutputOfDomain</a>
    /// </summary>
    let OutputOfDomain = _prefixId.prefix "OutputOfDomain"
    let PairsWith = _prefixId.prefix "PairsWith"
    /// <summary>
    ///   <para>rdfs:label : Person</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A human being. All persons are considered agents.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Person">vf:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : Plan</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A logical collection of processes, with optional connected agreements, that constitute a body of scheduled work with defined deliverable(s).</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Plan">vf:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:label : Range for vf:planIncludes</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#PlanIncludesRange">vf:PlanIncludesRange</a>
    /// </summary>
    let PlanIncludesRange = _prefixId.prefix "PlanIncludesRange"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:plannedWithin</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#PlannedWithinDomain">vf:PlannedWithinDomain</a>
    /// </summary>
    let PlannedWithinDomain = _prefixId.prefix "PlannedWithinDomain"
    /// <summary>
    ///   <para>rdfs:label : Process</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An activity that changes inputs into outputs, by transforming or transporting economic resource(s).</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Process">vf:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>rdfs:label : Process Specification</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the kind of process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ProcessSpecification">vf:ProcessSpecification</a>
    /// </summary>
    let ProcessSpecification = _prefixId.prefix "ProcessSpecification"
    /// <summary>
    ///   <para>rdfs:label : Proposal</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Published requests or offers, sometimes with what is expected in return.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Proposal">vf:Proposal</a>
    /// </summary>
    let Proposal = _prefixId.prefix "Proposal"
    /// <summary>
    ///   <para>rdfs:label : Proposal List</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A grouping of proposals, for publishing as a list.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ProposalList">vf:ProposalList</a>
    /// </summary>
    let ProposalList = _prefixId.prefix "ProposalList"
    /// <summary>
    ///   <para>rdfs:label : Proposal Purpose</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The type of proposal: offer or request (other types may be added).</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ProposalPurpose">vf:ProposalPurpose</a>
    /// </summary>
    let ProposalPurpose = _prefixId.prefix "ProposalPurpose"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:proposedTo</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ProposedToDomain">vf:ProposedToDomain</a>
    /// </summary>
    let ProposedToDomain = _prefixId.prefix "ProposedToDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:provider</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ProviderDomain">vf:ProviderDomain</a>
    /// </summary>
    let ProviderDomain = _prefixId.prefix "ProviderDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:receiver</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ReceiverDomain">vf:ReceiverDomain</a>
    /// </summary>
    let ReceiverDomain = _prefixId.prefix "ReceiverDomain"
    /// <summary>
    ///   <para>rdfs:label : Recipe</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Optional instance of a recipe which directly specifies the recipe processes included.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Recipe">vf:Recipe</a>
    /// </summary>
    let Recipe = _prefixId.prefix "Recipe"
    /// <summary>
    ///   <para>rdfs:label : Recipe Exchange</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies an exchange type agreement as part of a recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#RecipeExchange">vf:RecipeExchange</a>
    /// </summary>
    let RecipeExchange = _prefixId.prefix "RecipeExchange"
    /// <summary>
    ///   <para>rdfs:label : Recipe Flow</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The specification of a resource inflow to, or outflow from, a recipe process; and/or a clause, or reciprocal clause, of a recipe exchange.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#RecipeFlow">vf:RecipeFlow</a>
    /// </summary>
    let RecipeFlow = _prefixId.prefix "RecipeFlow"
    /// <summary>
    ///   <para>rdfs:label : Recipe Process</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a process in a recipe for use in planning from recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#RecipeProcess">vf:RecipeProcess</a>
    /// </summary>
    let RecipeProcess = _prefixId.prefix "RecipeProcess"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:resourceClassifiedAs</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ResourceClassifiedAsDomain">vf:ResourceClassifiedAsDomain</a>
    /// </summary>
    let ResourceClassifiedAsDomain = _prefixId.prefix "ResourceClassifiedAsDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:resourceConformsTo</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ResourceConformsToDomain">vf:ResourceConformsToDomain</a>
    /// </summary>
    let ResourceConformsToDomain = _prefixId.prefix "ResourceConformsToDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:resourceInventoriedAs</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ResourceInventoriedAsDomain">vf:ResourceInventoriedAsDomain</a>
    /// </summary>
    let ResourceInventoriedAsDomain = _prefixId.prefix "ResourceInventoriedAsDomain"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:resourceQuantity</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ResourceQuantityDomain">vf:ResourceQuantityDomain</a>
    /// </summary>
    let ResourceQuantityDomain = _prefixId.prefix "ResourceQuantityDomain"
    /// <summary>
    ///   <para>rdfs:label : Resource Specification</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the kind of economic or environmental resource, even if the resource is not instantiated as an EconomicResource. Could define a material or digital thing, service, medium of exchange or currency, skill or type of work.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ResourceSpecification">vf:ResourceSpecification</a>
    /// </summary>
    let ResourceSpecification = _prefixId.prefix "ResourceSpecification"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:satisfies</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#SatisfiesDomain">vf:SatisfiesDomain</a>
    /// </summary>
    let SatisfiesDomain = _prefixId.prefix "SatisfiesDomain"
    /// <summary>
    ///   <para>rdfs:label : Spatial Thing</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Data that locates something relative to the Earth, usually a somewhat fixed location.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#SpatialThing">vf:SpatialThing</a>
    /// </summary>
    let SpatialThing = _prefixId.prefix "SpatialThing"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:stage</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#StageDomain">vf:StageDomain</a>
    /// </summary>
    let StageDomain = _prefixId.prefix "StageDomain"
    /// <summary>
    ///   <para>rdfs:label : Stage Effect</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource stage.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#StageEffect">vf:StageEffect</a>
    /// </summary>
    let StageEffect = _prefixId.prefix "StageEffect"
    /// <summary>
    ///   <para>rdfs:label : Domain for vf:state</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#StateDomain">vf:StateDomain</a>
    /// </summary>
    let StateDomain = _prefixId.prefix "StateDomain"
    /// <summary>
    ///   <para>rdfs:label : State Effect</para>
    ///   <para>vs:term_status : unstable^^xsd:string</para>
    ///   <para>rdfs:comment : The action has this effect on an inventoried resource state.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#StateEffect">vf:StateEffect</a>
    /// </summary>
    let StateEffect = _prefixId.prefix "StateEffect"
    /// <summary>
    ///   <para>rdfs:label : Unit</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A standard unit of measure, defined and adopted by convention or by law.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#Unit">vf:Unit</a>
    /// </summary>
    let Unit = _prefixId.prefix "Unit"
    let accept = _prefixId.prefix "accept"
    /// <summary>
    ///   <para>rdfs:comment : The primaryAccountable should be updated to the event receiver, or not.</para>
    ///   <para>rdfs:label : accountable effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#accountableEffect">vf:accountableEffect</a>
    /// </summary>
    let accountableEffect = _prefixId.prefix "accountableEffect"
    /// <summary>
    ///   <para>rdfs:comment : The increment and/or decrement effect the action will have on the accounting quantity of an inventoried resource.</para>
    ///   <para>rdfs:label : accounting effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#accountingEffect">vf:accountingEffect</a>
    /// </summary>
    let accountingEffect = _prefixId.prefix "accountingEffect"
    /// <summary>
    ///   <para>rdfs:label : accounting quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The current amount and unit of the economic resource for which the agent has primary rights and responsibilities, sometimes thought of as ownership. This can be either stored or derived from economic events affecting the resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#accountingQuantity">vf:accountingQuantity</a>
    /// </summary>
    let accountingQuantity = _prefixId.prefix "accountingQuantity"
    /// <summary>
    ///   <para>rdfs:label : action</para>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the kind of flow, such as consume, produce, work, transfer, etc.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#action">vf:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>rdfs:label : altitude</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 altitude of a spatial thing (decimal meters above the local reference ellipsoid)^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#alt">vf:alt</a>
    /// </summary>
    let alt = _prefixId.prefix "alt"
    /// <summary>
    ///   <para>rdfs:label : available quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The amount and unit of the offered resource currently available.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#availableQuantity">vf:availableQuantity</a>
    /// </summary>
    let availableQuantity = _prefixId.prefix "availableQuantity"
    /// <summary>
    ///   <para>rdfs:label : based on</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The definition or standard specification for a process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#basedOn">vf:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>rdfs:label : batch or lot code</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The code or identifier for this batch or lot, used to physically label individuals in the batch or lot.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#batchLotCode">vf:batchLotCode</a>
    /// </summary>
    let batchLotCode = _prefixId.prefix "batchLotCode"
    let both = _prefixId.prefix "both"
    /// <summary>
    ///   <para>rdfs:label : bundled in</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : This agreement is bundled with other agreements, for example in an order.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#bundledIn">vf:bundledIn</a>
    /// </summary>
    let bundledIn = _prefixId.prefix "bundledIn"
    /// <summary>
    ///   <para>rdfs:label : bundles</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : All the agreements included in this agreement bundle.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#bundles">vf:bundles</a>
    /// </summary>
    let bundles = _prefixId.prefix "bundles"
    let cite = _prefixId.prefix "cite"
    /// <summary>
    ///   <para>rdfs:label : classified as</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : References one or more uri's for a concept in a common taxonomy or other classification scheme for purposes of categorization or grouping; or it can be one or more string classifications such as tags.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#classifiedAs">vf:classifiedAs</a>
    /// </summary>
    let classifiedAs = _prefixId.prefix "classifiedAs"
    /// <summary>
    ///   <para>rdfs:label : clause of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This commitment is a primary part of the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#clauseOf">vf:clauseOf</a>
    /// </summary>
    let clauseOf = _prefixId.prefix "clauseOf"
    let combine = _prefixId.prefix "combine"
    /// <summary>
    ///   <para>rdfs:label : conforms to</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The primary resource specification or definition of an economic resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#conformsTo">vf:conformsTo</a>
    /// </summary>
    let conformsTo = _prefixId.prefix "conformsTo"
    let consume = _prefixId.prefix "consume"
    /// <summary>
    ///   <para>rdfs:comment : The contained in resource should be updated or removed.</para>
    ///   <para>rdfs:label : contained effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#containedEffect">vf:containedEffect</a>
    /// </summary>
    let containedEffect = _prefixId.prefix "containedEffect"
    /// <summary>
    ///   <para>rdfs:label : contained in</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Used when an economic resource contains units also defined as separate economic resources, for example a tool kit or a package of resources for shipping.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#containedIn">vf:containedIn</a>
    /// </summary>
    let containedIn = _prefixId.prefix "containedIn"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : An economic resource contains at least one other economic resource, for example a tool kit or package of resources for shipping.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#contains">vf:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    let copy = _prefixId.prefix "copy"
    /// <summary>
    ///   <para>rdfs:label : corrects</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Used when an event was entered incorrectly and needs to be backed out or corrected. (The initial event cannot be changed.)</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#corrects">vf:corrects</a>
    /// </summary>
    let corrects = _prefixId.prefix "corrects"
    /// <summary>
    ///   <para>rdfs:comment : The action can create an economic resource.</para>
    ///   <para>rdfs:label : can create resource</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#createResource">vf:createResource</a>
    /// </summary>
    let createResource = _prefixId.prefix "createResource"
    /// <summary>
    ///   <para>rdfs:label : created</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The date, and time if desired, the information was agreed to or recorded.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#created">vf:created</a>
    /// </summary>
    let created = _prefixId.prefix "created"
    /// <summary>
    ///   <para>rdfs:label : current currency location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The current virtual place a currency economic resource is located, for example the address for a bank account, crypto wallet, etc., in a domain standard format.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#currentCurrencyLocation">vf:currentCurrencyLocation</a>
    /// </summary>
    let currentCurrencyLocation = _prefixId.prefix "currentCurrencyLocation"
    /// <summary>
    ///   <para>rdfs:label : current location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The current physical location of an economic resource.  Could be at any level of granularity, from a town to an address to a warehouse location.  Usually mappable.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#currentLocation">vf:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>rdfs:label : current virtual location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The current virtual place a digital economic resource is located. Usually used for documents, code, or other electronic resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#currentVirtualLocation">vf:currentVirtualLocation</a>
    /// </summary>
    let currentVirtualLocation = _prefixId.prefix "currentVirtualLocation"
    let decrement = _prefixId.prefix "decrement"
    let decrementIncrement = _prefixId.prefix "decrementIncrement"
    /// <summary>
    ///   <para>rdfs:label : default unit of effort</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The default unit used for use or work or sometimes cite actions.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#defaultUnitOfEffort">vf:defaultUnitOfEffort</a>
    /// </summary>
    let defaultUnitOfEffort = _prefixId.prefix "defaultUnitOfEffort"
    /// <summary>
    ///   <para>rdfs:label : default unit of resource</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The default unit used for the resource itself.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#defaultUnitOfResource">vf:defaultUnitOfResource</a>
    /// </summary>
    let defaultUnitOfResource = _prefixId.prefix "defaultUnitOfResource"
    let deliverService = _prefixId.prefix "deliverService"
    let dropoff = _prefixId.prefix "dropoff"
    /// <summary>
    ///   <para>rdfs:label : due</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The date, and time if desired, something is expected to be complete.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#due">vf:due</a>
    /// </summary>
    let due = _prefixId.prefix "due"
    let effort = _prefixId.prefix "effort"
    /// <summary>
    ///   <para>rdfs:label : effort quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The amount and unit of the work or use or citation effort-based action. This is often expressed with a time unit, but also could be cycle counts or other measures of effort or usefulness.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#effortQuantity">vf:effortQuantity</a>
    /// </summary>
    let effortQuantity = _prefixId.prefix "effortQuantity"
    /// <summary>
    ///   <para>rdfs:label : eligible location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Location or area where the proposal is valid.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#eligibleLocation">vf:eligibleLocation</a>
    /// </summary>
    let eligibleLocation = _prefixId.prefix "eligibleLocation"
    /// <summary>
    ///   <para>rdfs:comment : The event quantity applicable is resource quantity, effort quantity, or both.</para>
    ///   <para>rdfs:label : event quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#eventQuantity">vf:eventQuantity</a>
    /// </summary>
    let eventQuantity = _prefixId.prefix "eventQuantity"
    /// <summary>
    ///   <para>rdfs:label : expiration date</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The date after which a resource of this batch or lot should no longer be used or consumed.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#expirationDate">vf:expirationDate</a>
    /// </summary>
    let expirationDate = _prefixId.prefix "expirationDate"
    /// <summary>
    ///   <para>rdfs:label : finished</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The flow or process is complete or not.  This is irrespective of if the original goal has been met, and indicates simply that no more will be done.  Default false.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#finished">vf:finished</a>
    /// </summary>
    let finished = _prefixId.prefix "finished"
    /// <summary>
    ///   <para>rdfs:label : fulfills</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The commitment(s) fulfilled completely or partially by an economic event.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#fulfills">vf:fulfills</a>
    /// </summary>
    let fulfills = _prefixId.prefix "fulfills"
    /// <summary>
    ///   <para>rdfs:label : has beginning</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The planned or actual beginning date, and time if desired, of a flow or process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasBeginning">vf:hasBeginning</a>
    /// </summary>
    let hasBeginning = _prefixId.prefix "hasBeginning"
    /// <summary>
    ///   <para>rdfs:label : has detailed geometry</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : A spatial geometry of any complexity and tooling supported by geosparql.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasDetailedGeometry">vf:hasDetailedGeometry</a>
    /// </summary>
    let hasDetailedGeometry = _prefixId.prefix "hasDetailedGeometry"
    /// <summary>
    ///   <para>rdfs:label : has duration</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The temporal extent of the process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasDuration">vf:hasDuration</a>
    /// </summary>
    let hasDuration = _prefixId.prefix "hasDuration"
    /// <summary>
    ///   <para>rdfs:label : has end</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The planned or actual ending date, and time if desired, of a flow or process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasEnd">vf:hasEnd</a>
    /// </summary>
    let hasEnd = _prefixId.prefix "hasEnd"
    /// <summary>
    ///   <para>rdfs:label : has independent demand</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The commitments and/or intents which this plan was created to deliver on.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasIndependentDemand">vf:hasIndependentDemand</a>
    /// </summary>
    let hasIndependentDemand = _prefixId.prefix "hasIndependentDemand"
    /// <summary>
    ///   <para>rdfs:label : has input</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the input flows of a process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasInput">vf:hasInput</a>
    /// </summary>
    let hasInput = _prefixId.prefix "hasInput"
    /// <summary>
    ///   <para>rdfs:label : has numerical value</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric amount.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasNumericalValue">vf:hasNumericalValue</a>
    /// </summary>
    let hasNumericalValue = _prefixId.prefix "hasNumericalValue"
    /// <summary>
    ///   <para>rdfs:label : has output</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the output flows of a process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasOutput">vf:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : has point in time</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The planned or actual date, and time if desired, of a flow; can be used instead of hasBeginning and hasEnd, if so, hasBeginning and hasEnd should be able to return this value.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasPointInTime">vf:hasPointInTime</a>
    /// </summary>
    let hasPointInTime = _prefixId.prefix "hasPointInTime"
    /// <summary>
    ///   <para>rdfs:label : has recipe input</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the inputs of a recipe process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasRecipeInput">vf:hasRecipeInput</a>
    /// </summary>
    let hasRecipeInput = _prefixId.prefix "hasRecipeInput"
    /// <summary>
    ///   <para>rdfs:label : has recipe output</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the outputs of a recipe process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasRecipeOutput">vf:hasRecipeOutput</a>
    /// </summary>
    let hasRecipeOutput = _prefixId.prefix "hasRecipeOutput"
    /// <summary>
    ///   <para>rdfs:label : has unit</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A standard unit of measure.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#hasUnit">vf:hasUnit</a>
    /// </summary>
    let hasUnit = _prefixId.prefix "hasUnit"
    /// <summary>
    ///   <para>rdfs:label : image</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The uri to an image relevant to the entity, such as a logo, avatar, photo, diagram, etc.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#image">vf:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : image list</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A comma separated list of uri addresses to images relevant to the resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#imageList">vf:imageList</a>
    /// </summary>
    let imageList = _prefixId.prefix "imageList"
    /// <summary>
    ///   <para>rdfs:label : in scope of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Scope here means executed in the context of an agent.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#inScopeOf">vf:inScopeOf</a>
    /// </summary>
    let inScopeOf = _prefixId.prefix "inScopeOf"
    let increment = _prefixId.prefix "increment"
    let incrementTo = _prefixId.prefix "incrementTo"
    /// <summary>
    ///   <para>rdfs:label : independent demand of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This plan is the way this commitment or intent will be realized.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#independentDemandOf">vf:independentDemandOf</a>
    /// </summary>
    let independentDemandOf = _prefixId.prefix "independentDemandOf"
    let input = _prefixId.prefix "input"
    /// <summary>
    ///   <para>rdfs:label : input of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an input flow to its process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#inputOf">vf:inputOf</a>
    /// </summary>
    let inputOf = _prefixId.prefix "inputOf"
    /// <summary>
    ///   <para>rdfs:comment : Denotes if a process input or output, or not applicable to a process.</para>
    ///   <para>rdfs:label : input/output</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#inputOutput">vf:inputOutput</a>
    /// </summary>
    let inputOutput = _prefixId.prefix "inputOutput"
    let knowledge = _prefixId.prefix "knowledge"
    /// <summary>
    ///   <para>rdfs:label : label</para>
    ///   <para>owl:cardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The label defined for human readable display.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#label">vf:label</a>
    /// </summary>
    let label = _prefixId.prefix "label"
    /// <summary>
    ///   <para>rdfs:label : latitude</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 latitude of a spatial thing (decimal degrees).^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#lat">vf:lat</a>
    /// </summary>
    let lat = _prefixId.prefix "lat"
    let layer = _prefixId.prefix "layer"
    /// <summary>
    ///   <para>rdfs:label : listed in</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : This proposal is part of these lists of proposals.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#listedIn">vf:listedIn</a>
    /// </summary>
    let listedIn = _prefixId.prefix "listedIn"
    /// <summary>
    ///   <para>rdfs:label : lists</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : All the proposals included in this proposal list.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#lists">vf:lists</a>
    /// </summary>
    let lists = _prefixId.prefix "lists"
    /// <summary>
    ///   <para>rdfs:comment : This action can update the current location of an inventoried resource.</para>
    ///   <para>rdfs:label : location effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#locationEffect">vf:locationEffect</a>
    /// </summary>
    let locationEffect = _prefixId.prefix "locationEffect"
    /// <summary>
    ///   <para>rdfs:label : longitude</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The WGS84 longitude of a spatial thing (decimal degrees).^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#long">vf:long</a>
    /// </summary>
    let long = _prefixId.prefix "long"
    let lower = _prefixId.prefix "lower"
    /// <summary>
    ///   <para>rdfs:label : mappable address</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A textual address that can be mapped using mapping software.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#mappableAddress">vf:mappableAddress</a>
    /// </summary>
    let mappableAddress = _prefixId.prefix "mappableAddress"
    /// <summary>
    ///   <para>rdfs:label : medium of exchange</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : True if the resource is a currency, money, token, credit, etc. used as a medium of exchange.  Default false.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#mediumOfExchange">vf:mediumOfExchange</a>
    /// </summary>
    let mediumOfExchange = _prefixId.prefix "mediumOfExchange"
    /// <summary>
    ///   <para>rdfs:label : minimum quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The minimum required order amount and unit of the offered resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#minimumQuantity">vf:minimumQuantity</a>
    /// </summary>
    let minimumQuantity = _prefixId.prefix "minimumQuantity"
    let modify = _prefixId.prefix "modify"
    let move = _prefixId.prefix "move"
    /// <summary>
    ///   <para>rdfs:label : name</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : An informal or formal textual identifier for an object. Does not imply uniqueness.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#name">vf:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    let new_ = _prefixId.prefix "new"
    let notApplicable = _prefixId.prefix "notApplicable"
    /// <summary>
    ///   <para>rdfs:label : note</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Any useful textual information related to the item.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#note">vf:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:label : of batch or lot</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The batch lot record of this resource, if it is a batch or lot resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#ofBatchLot">vf:ofBatchLot</a>
    /// </summary>
    let ofBatchLot = _prefixId.prefix "ofBatchLot"
    let offer = _prefixId.prefix "offer"
    /// <summary>
    ///   <para>rdfs:label : om unit identifier</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The unique identifier of the om unit of measure, for standardization across networks.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#omUnitIdentifier">vf:omUnitIdentifier</a>
    /// </summary>
    let omUnitIdentifier = _prefixId.prefix "omUnitIdentifier"
    /// <summary>
    ///   <para>rdfs:comment : The increment and/or decrement effect the action will have on the onhand quantity of an inventoried resource.</para>
    ///   <para>rdfs:label : onhand effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#onhandEffect">vf:onhandEffect</a>
    /// </summary>
    let onhandEffect = _prefixId.prefix "onhandEffect"
    /// <summary>
    ///   <para>rdfs:label : onhand quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The current amount and unit of the economic resource which is under direct control of the agent.  It may be more or less than the accounting quantity. This can be either stored or derived from economic events affecting the resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#onhandQuantity">vf:onhandQuantity</a>
    /// </summary>
    let onhandQuantity = _prefixId.prefix "onhandQuantity"
    let optional = _prefixId.prefix "optional"
    let optionalTo = _prefixId.prefix "optionalTo"
    let output = _prefixId.prefix "output"
    let outputInput = _prefixId.prefix "outputInput"
    /// <summary>
    ///   <para>rdfs:label : output of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an output flow to its process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#outputOf">vf:outputOf</a>
    /// </summary>
    let outputOf = _prefixId.prefix "outputOf"
    /// <summary>
    ///   <para>rdfs:comment : The action that usually affects the same resource as a complement in the same flow.</para>
    ///   <para>rdfs:label : pairs with</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#pairsWith">vf:pairsWith</a>
    /// </summary>
    let pairsWith = _prefixId.prefix "pairsWith"
    let pickup = _prefixId.prefix "pickup"
    /// <summary>
    ///   <para>rdfs:label : plan includes</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The processes and non-process commitments/intents that constitute the plan.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#planIncludes">vf:planIncludes</a>
    /// </summary>
    let planIncludes = _prefixId.prefix "planIncludes"
    /// <summary>
    ///   <para>rdfs:label : planned within</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The process with its inputs and outputs, or the non-process commitment or intent, is part of the plan.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#plannedWithin">vf:plannedWithin</a>
    /// </summary>
    let plannedWithin = _prefixId.prefix "plannedWithin"
    /// <summary>
    ///   <para>rdfs:label : primary accountable</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The agent currently with primary rights and responsibilites for the economic resource. It is the agent that is associated with the accountingQuantity of the economic resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#primaryAccountable">vf:primaryAccountable</a>
    /// </summary>
    let primaryAccountable = _prefixId.prefix "primaryAccountable"
    /// <summary>
    ///   <para>rdfs:label : primary location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The main place an agent is located, often an address where activities occur and mail can be sent. This is usually a mappable geographic location.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#primaryLocation">vf:primaryLocation</a>
    /// </summary>
    let primaryLocation = _prefixId.prefix "primaryLocation"
    /// <summary>
    ///   <para>rdfs:label : primary output</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The main type of resource the recipe is intended to produce or deliver.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#primaryOutput">vf:primaryOutput</a>
    /// </summary>
    let primaryOutput = _prefixId.prefix "primaryOutput"
    /// <summary>
    ///   <para>rdfs:label : process classified as</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : References one or more uri's for a concept in a common taxonomy or other classification scheme for purposes of categorization or grouping; or can be one or more string classifications such as tags.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#processClassifiedAs">vf:processClassifiedAs</a>
    /// </summary>
    let processClassifiedAs = _prefixId.prefix "processClassifiedAs"
    /// <summary>
    ///   <para>rdfs:label : process conforms to</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The standard specification or definition of a type of process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#processConformsTo">vf:processConformsTo</a>
    /// </summary>
    let processConformsTo = _prefixId.prefix "processConformsTo"
    let produce = _prefixId.prefix "produce"
    /// <summary>
    ///   <para>rdfs:label : proposed to</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The agent(s) to which the proposal or proposal list is published.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#proposedTo">vf:proposedTo</a>
    /// </summary>
    let proposedTo = _prefixId.prefix "proposedTo"
    /// <summary>
    ///   <para>rdfs:label : provider</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The economic agent by whom the intended, committed, or actual economic event is initiated.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#provider">vf:provider</a>
    /// </summary>
    let provider = _prefixId.prefix "provider"
    /// <summary>
    ///   <para>rdfs:label : publishes</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The primary intent(s) of this published proposal. Would be used in intent matching.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#publishes">vf:publishes</a>
    /// </summary>
    let publishes = _prefixId.prefix "publishes"
    /// <summary>
    ///   <para>rdfs:label : purpose</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The type of proposal, whether offer or request (others may be added as need arises).</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#purpose">vf:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    let raise = _prefixId.prefix "raise"
    /// <summary>
    ///   <para>rdfs:label : realization of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This non-reciprocal economic event occurs as part of this agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#realizationOf">vf:realizationOf</a>
    /// </summary>
    let realizationOf = _prefixId.prefix "realizationOf"
    /// <summary>
    ///   <para>rdfs:label : realizes</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the non-reciprocal economic events (with or without commitments) that realize the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#realizes">vf:realizes</a>
    /// </summary>
    let realizes = _prefixId.prefix "realizes"
    /// <summary>
    ///   <para>rdfs:label : realizes reciprocal</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the reciprocal economic events (with or without commitments) that realize the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#realizesReciprocal">vf:realizesReciprocal</a>
    /// </summary>
    let realizesReciprocal = _prefixId.prefix "realizesReciprocal"
    /// <summary>
    ///   <para>rdfs:label : receiver</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The economic agent whom the intended, committed, or actual economic event is for.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#receiver">vf:receiver</a>
    /// </summary>
    let receiver = _prefixId.prefix "receiver"
    /// <summary>
    ///   <para>rdfs:label : recipe clause of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a flow to its exchange agreement in a recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeClauseOf">vf:recipeClauseOf</a>
    /// </summary>
    let recipeClauseOf = _prefixId.prefix "recipeClauseOf"
    /// <summary>
    ///   <para>rdfs:label : recipe includes</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The collection of processes needed for this recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeIncludes">vf:recipeIncludes</a>
    /// </summary>
    let recipeIncludes = _prefixId.prefix "recipeIncludes"
    /// <summary>
    ///   <para>rdfs:label : recipe input of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an input flow to its process in a recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeInputOf">vf:recipeInputOf</a>
    /// </summary>
    let recipeInputOf = _prefixId.prefix "recipeInputOf"
    /// <summary>
    ///   <para>rdfs:label : recipe output of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates an output flow to its process in a recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeOutputOf">vf:recipeOutputOf</a>
    /// </summary>
    let recipeOutputOf = _prefixId.prefix "recipeOutputOf"
    /// <summary>
    ///   <para>rdfs:label : recipe reciprocal clause of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a reciprocal flow to its exchange agreement in a recipe.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeReciprocalClauseOf">vf:recipeReciprocalClauseOf</a>
    /// </summary>
    let recipeReciprocalClauseOf = _prefixId.prefix "recipeReciprocalClauseOf"
    /// <summary>
    ///   <para>rdfs:label : recipe stipulates</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the primary clauses of a recipe exchange.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeStipulates">vf:recipeStipulates</a>
    /// </summary>
    let recipeStipulates = _prefixId.prefix "recipeStipulates"
    /// <summary>
    ///   <para>rdfs:label : recipe stipulates reciprocal</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the reciprocal clauses of a recipe exchange.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#recipeStipulatesReciprocal">vf:recipeStipulatesReciprocal</a>
    /// </summary>
    let recipeStipulatesReciprocal = _prefixId.prefix "recipeStipulatesReciprocal"
    /// <summary>
    ///   <para>rdfs:label : reciprocal</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The reciprocal intent(s) of this published proposal. Not meant to be used for intent matching.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#reciprocal">vf:reciprocal</a>
    /// </summary>
    let reciprocal = _prefixId.prefix "reciprocal"
    /// <summary>
    ///   <para>rdfs:label : reciprocal clause of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This commitment is a reciprocal part of the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#reciprocalClauseOf">vf:reciprocalClauseOf</a>
    /// </summary>
    let reciprocalClauseOf = _prefixId.prefix "reciprocalClauseOf"
    /// <summary>
    ///   <para>rdfs:label : reciprocal realization of</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This reciprocal economic event occurs as part of this agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#reciprocalRealizationOf">vf:reciprocalRealizationOf</a>
    /// </summary>
    let reciprocalRealizationOf = _prefixId.prefix "reciprocalRealizationOf"
    let remove = _prefixId.prefix "remove"
    let request = _prefixId.prefix "request"
    let resource = _prefixId.prefix "resource"
    /// <summary>
    ///   <para>rdfs:label : resource classified as</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : References one or more uri's for a concept in a common taxonomy or other classification scheme for purposes of categorization or grouping; or can be one or more string classifications such as tags.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#resourceClassifiedAs">vf:resourceClassifiedAs</a>
    /// </summary>
    let resourceClassifiedAs = _prefixId.prefix "resourceClassifiedAs"
    /// <summary>
    ///   <para>rdfs:label : resource conforms to</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The lowest level resource specification or definition of an existing or potential economic resource, whether one will ever be instantiated or not.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#resourceConformsTo">vf:resourceConformsTo</a>
    /// </summary>
    let resourceConformsTo = _prefixId.prefix "resourceConformsTo"
    /// <summary>
    ///   <para>rdfs:label : resource inventoried as</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Economic resource involved in the flow.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#resourceInventoriedAs">vf:resourceInventoriedAs</a>
    /// </summary>
    let resourceInventoriedAs = _prefixId.prefix "resourceInventoriedAs"
    /// <summary>
    ///   <para>rdfs:label : resource quantity</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The amount and unit of the economic resource counted or inventoried.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#resourceQuantity">vf:resourceQuantity</a>
    /// </summary>
    let resourceQuantity = _prefixId.prefix "resourceQuantity"
    /// <summary>
    ///   <para>rdfs:label : satisfies</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The intent(s) satisfied fully or partially by an economic event or commitment.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#satisfies">vf:satisfies</a>
    /// </summary>
    let satisfies = _prefixId.prefix "satisfies"
    let separate = _prefixId.prefix "separate"
    /// <summary>
    ///   <para>rdfs:label : settles</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The claim(s) settled fully or partially by the economic event.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#settles">vf:settles</a>
    /// </summary>
    let settles = _prefixId.prefix "settles"
    /// <summary>
    ///   <para>rdfs:label : stage</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The required stage of the desired input economic resource. References the ProcessSpecification of the last process the economic resource went through.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#stage">vf:stage</a>
    /// </summary>
    let stage = _prefixId.prefix "stage"
    /// <summary>
    ///   <para>rdfs:comment : The stage of the inventoried resource should be updated, or not.</para>
    ///   <para>rdfs:label : stage effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#stageEffect">vf:stageEffect</a>
    /// </summary>
    let stageEffect = _prefixId.prefix "stageEffect"
    /// <summary>
    ///   <para>rdfs:label : state</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : The required state of the desired input economic resource, after coming out of a test or review process.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#state">vf:state</a>
    /// </summary>
    let state = _prefixId.prefix "state"
    /// <summary>
    ///   <para>rdfs:comment : The state of the from or to inventoried resource should be updated, or not.</para>
    ///   <para>rdfs:label : state effect</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#stateEffect">vf:stateEffect</a>
    /// </summary>
    let stateEffect = _prefixId.prefix "stateEffect"
    /// <summary>
    ///   <para>rdfs:label : stipulates</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the primary commitments that constitute the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#stipulates">vf:stipulates</a>
    /// </summary>
    let stipulates = _prefixId.prefix "stipulates"
    /// <summary>
    ///   <para>rdfs:label : stipulates reciprocal</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : All the reciprocal commitments that constitute the agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#stipulatesReciprocal">vf:stipulatesReciprocal</a>
    /// </summary>
    let stipulatesReciprocal = _prefixId.prefix "stipulatesReciprocal"
    /// <summary>
    ///   <para>rdfs:label : substitutable</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Defines if any resource of that type can be freely substituted for any other resource of that type when used, consumed, traded, etc.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#substitutable">vf:substitutable</a>
    /// </summary>
    let substitutable = _prefixId.prefix "substitutable"
    /// <summary>
    ///   <para>rdfs:label : symbol</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The symbol defined for human readable display.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#symbol">vf:symbol</a>
    /// </summary>
    let symbol = _prefixId.prefix "symbol"
    /// <summary>
    ///   <para>rdfs:label : to location</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The new location of the receiver resource.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#toLocation">vf:toLocation</a>
    /// </summary>
    let toLocation = _prefixId.prefix "toLocation"
    /// <summary>
    ///   <para>rdfs:label : to resource inventoried as</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Additional economic resource on the economic event when needed by the receiver. Used when a transfer or move, or sometimes other actions, requires explicitly identifying an economic resource by the receiver, which is identified differently by the sender.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#toResourceInventoriedAs">vf:toResourceInventoriedAs</a>
    /// </summary>
    let toResourceInventoriedAs = _prefixId.prefix "toResourceInventoriedAs"
    /// <summary>
    ///   <para>rdfs:label : tracking identifier</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Any identifier used to track a singular resource, such as a serial number or VIN.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#trackingIdentifier">vf:trackingIdentifier</a>
    /// </summary>
    let trackingIdentifier = _prefixId.prefix "trackingIdentifier"
    let transfer = _prefixId.prefix "transfer"
    let transferAllRights = _prefixId.prefix "transferAllRights"
    let transferCustody = _prefixId.prefix "transferCustody"
    /// <summary>
    ///   <para>rdfs:label : triggered by</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : References an economic event that implied the claim, often based on a prior agreement.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#triggeredBy">vf:triggeredBy</a>
    /// </summary>
    let triggeredBy = _prefixId.prefix "triggeredBy"
    /// <summary>
    ///   <para>rdfs:label : unit based</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : This group of intents contains unit based quantities, which can be multipied to create commitments; commonly seen in a price list or e-commerce. Default false.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#unitBased">vf:unitBased</a>
    /// </summary>
    let unitBased = _prefixId.prefix "unitBased"
    /// <summary>
    ///   <para>rdfs:label : unit of effort</para>
    ///   <para>owl:maxCardinality : 1^^xsd:integer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The unit used for use or work or sometimes cite actions.</para>
    ///   <a href="https://w3id.org/valueflows/ont/vf#unitOfEffort">vf:unitOfEffort</a>
    /// </summary>
    let unitOfEffort = _prefixId.prefix "unitOfEffort"
    let update = _prefixId.prefix "update"
    let updateTo = _prefixId.prefix "updateTo"
    let use_ = _prefixId.prefix "use"
    let work = _prefixId.prefix "work"
