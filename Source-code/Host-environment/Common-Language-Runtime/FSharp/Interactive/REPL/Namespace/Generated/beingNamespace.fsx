#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module being =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/ext/common/being#" "being"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Adopted Family Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an adopted bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Adopted">being:Adopted</a>
    /// </summary>
    let Adopted = _prefixId.prefix "Adopted"
    /// <summary>
    ///   <para>rdfs:label : Alliance^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an alliance that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Alliance">being:Alliance</a>
    /// </summary>
    let Alliance = _prefixId.prefix "Alliance"
    /// <summary>
    ///   <para>rdfs:label : Being^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an Entity with a personality^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Being">being:Being</a>
    /// </summary>
    let Being = _prefixId.prefix "Being"
    /// <summary>
    ///   <para>rdfs:label : Blood Family Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a blood bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Blood">being:Blood</a>
    /// </summary>
    let Blood = _prefixId.prefix "Blood"
    /// <summary>
    ///   <para>rdfs:label : Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Bond">being:Bond</a>
    /// </summary>
    let Bond = _prefixId.prefix "Bond"
    /// <summary>
    ///   <para>rdfs:label : Bonded Group^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a bonded group^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Bonded-Group">being:Bonded-Group</a>
    /// </summary>
    let Bonded_Group = _prefixId.prefix "Bonded-Group"
    /// <summary>
    ///   <para>rdfs:label : Character^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an fictionalised contruction of an entity with a personality^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Character">being:Character</a>
    /// </summary>
    let Character = _prefixId.prefix "Character"
    /// <summary>
    ///   <para>rdfs:label : Community^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a community^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Community">being:Community</a>
    /// </summary>
    let Community = _prefixId.prefix "Community"
    /// <summary>
    ///   <para>rdfs:label : Company^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a company^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Company">being:Company</a>
    /// </summary>
    let Company = _prefixId.prefix "Company"
    /// <summary>
    ///   <para>rdfs:label : Deal^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a deal that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Deal">being:Deal</a>
    /// </summary>
    let Deal = _prefixId.prefix "Deal"
    /// <summary>
    ///   <para>rdfs:label : Emotional Crisis^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a emotional crisis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Emotional-Crisis">being:Emotional-Crisis</a>
    /// </summary>
    let Emotional_Crisis = _prefixId.prefix "Emotional-Crisis"
    /// <summary>
    ///   <para>rdfs:label : Enmity^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an emnity that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Enmity">being:Enmity</a>
    /// </summary>
    let Enmity = _prefixId.prefix "Enmity"
    /// <summary>
    ///   <para>rdfs:label : Family Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a family bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Family">being:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:label : Foster Family Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a foster bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Foster">being:Foster</a>
    /// </summary>
    let Foster = _prefixId.prefix "Foster"
    /// <summary>
    ///   <para>rdfs:label : Friendship^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an friendship that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Friendship">being:Friendship</a>
    /// </summary>
    let Friendship = _prefixId.prefix "Friendship"
    /// <summary>
    ///   <para>rdfs:label : Government^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a governing group^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Government">being:Government</a>
    /// </summary>
    let Government = _prefixId.prefix "Government"
    /// <summary>
    ///   <para>rdfs:label : Group^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a group of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Group">being:Group</a>
    /// </summary>
    let Group = _prefixId.prefix "Group"
    /// <summary>
    ///   <para>rdfs:label : Household^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a household^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Household">being:Household</a>
    /// </summary>
    let Household = _prefixId.prefix "Household"
    /// <summary>
    ///   <para>rdfs:label : Mental Illness^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a mental illness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Mental-Illness">being:Mental-Illness</a>
    /// </summary>
    let Mental_Illness = _prefixId.prefix "Mental-Illness"
    /// <summary>
    ///   <para>rdfs:label : Organisation^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an organisation^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Organisation">being:Organisation</a>
    /// </summary>
    let Organisation = _prefixId.prefix "Organisation"
    /// <summary>
    ///   <para>rdfs:label : Partnership^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a partnership^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Partnership">being:Partnership</a>
    /// </summary>
    let Partnership = _prefixId.prefix "Partnership"
    /// <summary>
    ///   <para>rdfs:label : Physical Illness^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a physical illness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Illness">being:Physical-Illness</a>
    /// </summary>
    let Physical_Illness = _prefixId.prefix "Physical-Illness"
    /// <summary>
    ///   <para>rdfs:label : Physical Injury^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a physical injury^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Injury">being:Physical-Injury</a>
    /// </summary>
    let Physical_Injury = _prefixId.prefix "Physical-Injury"
    /// <summary>
    ///   <para>rdfs:label : Pledge^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a promise that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Pledge">being:Pledge</a>
    /// </summary>
    let Pledge = _prefixId.prefix "Pledge"
    /// <summary>
    ///   <para>rdfs:label : Possession^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a the bond between two entities where one claims ownership of the other^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Possession">being:Possession</a>
    /// </summary>
    let Possession = _prefixId.prefix "Possession"
    /// <summary>
    ///   <para>rdfs:label : Profession^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a profession^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Profession">being:Profession</a>
    /// </summary>
    let Profession = _prefixId.prefix "Profession"
    /// <summary>
    ///   <para>rdfs:label : Proto-Being^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents something that may develop into a being for cases where the being/item divide isn't clear^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Proto-Being">being:Proto-Being</a>
    /// </summary>
    let Proto_Being = _prefixId.prefix "Proto-Being"
    /// <summary>
    ///   <para>rdfs:label : Step Family Bond^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a step bond that exists between beings or groups of beings^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#Step">being:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a title which can be used by any members of the group^^xsd:string</para>
    ///   <para>rdfs:label : Carries Title^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-title">being:carries-title</a>
    /// </summary>
    let carries_title = _prefixId.prefix "carries-title"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a uniform which is worn by any members of the group^^xsd:string</para>
    ///   <para>rdfs:label : Carries Uniform^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-uniform">being:carries-uniform</a>
    /// </summary>
    let carries_uniform = _prefixId.prefix "carries-uniform"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a cure event^^xsd:string</para>
    ///   <para>rdfs:label : Cured^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#cured">being:cured</a>
    /// </summary>
    let cured = _prefixId.prefix "cured"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the conditions of the deal^^xsd:string</para>
    ///   <para>rdfs:label : Deal Conditions^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#deal-conditions">being:deal-conditions</a>
    /// </summary>
    let deal_conditions = _prefixId.prefix "deal-conditions"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the broker of the deal^^xsd:string</para>
    ///   <para>rdfs:label : Deal Broker^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#dealbroker">being:dealbroker</a>
    /// </summary>
    let dealbroker = _prefixId.prefix "dealbroker"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the broker of the deal^^xsd:string</para>
    ///   <para>rdfs:label : Deal Broker^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#dealmaker">being:dealmaker</a>
    /// </summary>
    let dealmaker = _prefixId.prefix "dealmaker"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a diagnosis event^^xsd:string</para>
    ///   <para>rdfs:label : Diagnosed^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#diagnosed">being:diagnosed</a>
    /// </summary>
    let diagnosed = _prefixId.prefix "diagnosed"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies an entering remission event^^xsd:string</para>
    ///   <para>rdfs:label : Entered Remission^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#entered-remission">being:entered-remission</a>
    /// </summary>
    let entered_remission = _prefixId.prefix "entered-remission"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a class of items of which the group or collection is made^^xsd:string</para>
    ///   <para>rdfs:label : Governed By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#governed-by">being:governed-by</a>
    /// </summary>
    let governed_by = _prefixId.prefix "governed-by"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a class of items of which the group or collection is made^^xsd:string</para>
    ///   <para>rdfs:label : Governs^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#governs">being:governs</a>
    /// </summary>
    let governs = _prefixId.prefix "governs"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the emotional crisis of a being^^xsd:string</para>
    ///   <para>rdfs:label : Has Crisis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-crisis">being:has-crisis</a>
    /// </summary>
    let has_crisis = _prefixId.prefix "has-crisis"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the emotional well-being of a being^^xsd:string</para>
    ///   <para>rdfs:label : Emotional Health^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-emotional-health">being:has-emotional-health</a>
    /// </summary>
    let has_emotional_health = _prefixId.prefix "has-emotional-health"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the specified being acting in loco parentis of the being^^xsd:string</para>
    ///   <para>rdfs:label : Has Loco Parentis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-loco-parentis">being:has-loco-parentis</a>
    /// </summary>
    let has_loco_parentis = _prefixId.prefix "has-loco-parentis"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the emotional well-being of a being^^xsd:string</para>
    ///   <para>rdfs:label : Mental Health^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-mental-disorder">being:has-mental-disorder</a>
    /// </summary>
    let has_mental_disorder = _prefixId.prefix "has-mental-disorder"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the number of parts contained by the collection^^xsd:string</para>
    ///   <para>rdfs:label : Has Number Of Parts^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-number-of-parts">being:has-number-of-parts</a>
    /// </summary>
    let has_number_of_parts = _prefixId.prefix "has-number-of-parts"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the emotional well-being of a being^^xsd:string</para>
    ///   <para>rdfs:label : Physical Illness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-illness">being:has-physical-illness</a>
    /// </summary>
    let has_physical_illness = _prefixId.prefix "has-physical-illness"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the emotional well-being of a being^^xsd:string</para>
    ///   <para>rdfs:label : Physical Injury^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-injury">being:has-physical-injury</a>
    /// </summary>
    let has_physical_injury = _prefixId.prefix "has-physical-injury"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity has a bond with the named entity^^xsd:string</para>
    ///   <para>rdfs:label : Have Bonded To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#have-bonded-to">being:have-bonded-to</a>
    /// </summary>
    let have_bonded_to = _prefixId.prefix "have-bonded-to"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity has done the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Have Done^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#have-done">being:have-done</a>
    /// </summary>
    let have_done = _prefixId.prefix "have-done"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity does not have a bond with the named entity^^xsd:string</para>
    ///   <para>rdfs:label : Have Not Bonded To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-bonded-to">being:have-not-bonded-to</a>
    /// </summary>
    let have_not_bonded_to = _prefixId.prefix "have-not-bonded-to"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity has not done the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Have Not Done^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-done">being:have-not-done</a>
    /// </summary>
    let have_not_done = _prefixId.prefix "have-not-done"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the being is acting in loco parentis of the specified being^^xsd:string</para>
    ///   <para>rdfs:label : In Loco Parentis^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#in-loco-parentis">being:in-loco-parentis</a>
    /// </summary>
    let in_loco_parentis = _prefixId.prefix "in-loco-parentis"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity is the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Is A^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#is-a">being:is-a</a>
    /// </summary>
    let is_a = _prefixId.prefix "is-a"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the being is the child of the specified being^^xsd:string</para>
    ///   <para>rdfs:label : Is Child Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#is-child-of">being:is-child-of</a>
    /// </summary>
    let is_child_of = _prefixId.prefix "is-child-of"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity is not the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Is Not A^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#is-not-a">being:is-not-a</a>
    /// </summary>
    let is_not_a = _prefixId.prefix "is-not-a"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the being is the parent of the specified being^^xsd:string</para>
    ///   <para>rdfs:label : Is Parent Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#is-parent-of">being:is-parent-of</a>
    /// </summary>
    let is_parent_of = _prefixId.prefix "is-parent-of"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the Being is the child of the specified Being^^xsd:string</para>
    ///   <para>rdfs:label : Is Relation Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#is-relation-of">being:is-relation-of</a>
    /// </summary>
    let is_relation_of = _prefixId.prefix "is-relation-of"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a class of items of which the group or collection is made^^xsd:string</para>
    ///   <para>rdfs:label : Of Type^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#of-type">being:of-type</a>
    /// </summary>
    let of_type = _prefixId.prefix "of-type"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies ownership by an entity^^xsd:string</para>
    ///   <para>rdfs:label : Owns^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#owned-by">being:owned-by</a>
    /// </summary>
    let owned_by = _prefixId.prefix "owned-by"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the ownership of an entity^^xsd:string</para>
    ///   <para>rdfs:label : Owns^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#owns">being:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    let place_of_birth = _prefixId.prefix "place-of-birth"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the place that the being is a citizan of^^xsd:string</para>
    ///   <para>rdfs:label : Place of Citizenship^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#place_of_citizenship">being:place_of_citizenship</a>
    /// </summary>
    let place_of_citizenship = _prefixId.prefix "place_of_citizenship"
    /// <summary>
    ///   <para>rdfs:comment : This property the entity making the pledge^^xsd:string</para>
    ///   <para>rdfs:label : Pledge Maker^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-maker">being:pledge-maker</a>
    /// </summary>
    let pledge_maker = _prefixId.prefix "pledge-maker"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the reciever of the pledge^^xsd:string</para>
    ///   <para>rdfs:label : Pledged Reciever^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-reciever">being:pledge-reciever</a>
    /// </summary>
    let pledge_reciever = _prefixId.prefix "pledge-reciever"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies what entity or event is being portrayed^^xsd:string</para>
    ///   <para>rdfs:label : Portrays^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#portrays">being:portrays</a>
    /// </summary>
    let portrays = _prefixId.prefix "portrays"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language or alphabet read by the being^^xsd:string</para>
    ///   <para>rdfs:label : Reads^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#reads">being:reads</a>
    /// </summary>
    let reads = _prefixId.prefix "reads"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a recovery event^^xsd:string</para>
    ///   <para>rdfs:label : Recovered^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#recovered">being:recovered</a>
    /// </summary>
    let recovered = _prefixId.prefix "recovered"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a rehabilitation event^^xsd:string</para>
    ///   <para>rdfs:label : Rehabilitated^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#rehabilitated">being:rehabilitated</a>
    /// </summary>
    let rehabilitated = _prefixId.prefix "rehabilitated"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a crisis resolution event^^xsd:string</para>
    ///   <para>rdfs:label : Resolved^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#resolved">being:resolved</a>
    /// </summary>
    let resolved = _prefixId.prefix "resolved"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies that the being is a sibling of the specified being^^xsd:string</para>
    ///   <para>rdfs:label : Sibling Of^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#sibling-of">being:sibling-of</a>
    /// </summary>
    let sibling_of = _prefixId.prefix "sibling-of"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language spoken by the being^^xsd:string</para>
    ///   <para>rdfs:label : Speaks^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks">being:speaks</a>
    /// </summary>
    let speaks = _prefixId.prefix "speaks"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language spoken at a basic level by the being^^xsd:string</para>
    ///   <para>rdfs:label : Speaks Basic^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-basic">being:speaks-basic</a>
    /// </summary>
    let speaks_basic = _prefixId.prefix "speaks-basic"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language spoken fluently by the being^^xsd:string</para>
    ///   <para>rdfs:label : Speaks Fluently^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-fluently">being:speaks-fluently</a>
    /// </summary>
    let speaks_fluently = _prefixId.prefix "speaks-fluently"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language almost spoken by the being^^xsd:string</para>
    ///   <para>rdfs:label : Speaks Pidgin^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-pidgin">being:speaks-pidgin</a>
    /// </summary>
    let speaks_pidgin = _prefixId.prefix "speaks-pidgin"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a treatment event^^xsd:string</para>
    ///   <para>rdfs:label : Treated^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#treated">being:treated</a>
    /// </summary>
    let treated = _prefixId.prefix "treated"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies who/what an entity is typically used by^^xsd:string</para>
    ///   <para>rdfs:label : Used By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#used-by">being:used-by</a>
    /// </summary>
    let used_by = _prefixId.prefix "used-by"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies an entity typically used by the refering entity^^xsd:string</para>
    ///   <para>rdfs:label : Uses^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#uses">being:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies what the entity or event is being portrayed by^^xsd:string</para>
    ///   <para>rdfs:label : Voiced By^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#voiced-by">being:voiced-by</a>
    /// </summary>
    let voiced_by = _prefixId.prefix "voiced-by"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies what entity or event is being portrayed^^xsd:string</para>
    ///   <para>rdfs:label : Voices^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#voices">being:voices</a>
    /// </summary>
    let voices = _prefixId.prefix "voices"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies an item worn by the being^^xsd:string</para>
    ///   <para>rdfs:label : Wears^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#wears">being:wears</a>
    /// </summary>
    let wears = _prefixId.prefix "wears"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a class of items worn by the being^^xsd:string</para>
    ///   <para>rdfs:label : Wears Type^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#wears-type">being:wears-type</a>
    /// </summary>
    let wears_type = _prefixId.prefix "wears-type"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity will bond with the named entity^^xsd:string</para>
    ///   <para>rdfs:label : Will Bond To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#will-bond-to">being:will-bond-to</a>
    /// </summary>
    let will_bond_to = _prefixId.prefix "will-bond-to"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity will do the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Will Do^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#will-do">being:will-do</a>
    /// </summary>
    let will_do = _prefixId.prefix "will-do"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity will not have a bond with the named entity^^xsd:string</para>
    ///   <para>rdfs:label : Will Not Bond To^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-bond-to">being:will-not-bond-to</a>
    /// </summary>
    let will_not_bond_to = _prefixId.prefix "will-not-bond-to"
    /// <summary>
    ///   <para>rdfs:comment : This property represents a pledge that the entity will not do the named thing^^xsd:string</para>
    ///   <para>rdfs:label : Will Not Do^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-do">being:will-not-do</a>
    /// </summary>
    let will_not_do = _prefixId.prefix "will-not-do"
    /// <summary>
    ///   <para>rdfs:comment : This property represents the entity being worked for^^xsd:string</para>
    ///   <para>rdfs:label : Works For^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#works-for">being:works-for</a>
    /// </summary>
    let works_for = _prefixId.prefix "works-for"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a language or alphabet read by the being^^xsd:string</para>
    ///   <para>rdfs:label : Writes^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/being#writes">being:writes</a>
    /// </summary>
    let writes = _prefixId.prefix "writes"
