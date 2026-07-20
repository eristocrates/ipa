namespace http.contextus.net.ontology.ontomedia.ext.common.being.hash

open DoxAletheia

module being =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/ext/common/being#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents an adopted bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Adopted"></see></summary>
    let Adopted = _prefix "Adopted"
    /// <summary>
    /// This class represents a family bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// This class represents an alliance that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Alliance"></see></summary>
    let Alliance = _prefix "Alliance"
    /// <summary>
    /// This class represents a bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Bond"></see></summary>
    let Bond = _prefix "Bond"
    /// <summary>
    /// This class represents an Entity with a personality
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Being"></see></summary>
    let Being = _prefix "Being"
    /// <summary>
    /// This class represents a blood bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Blood"></see></summary>
    let Blood = _prefix "Blood"
    /// <summary>
    /// This class represents a bonded group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Bonded-Group"></see></summary>
    let ``Bonded-Group`` = _prefix "Bonded-Group"
    /// <summary>
    /// This class represents a community
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Community"></see></summary>
    let Community = _prefix "Community"
    /// <summary>
    /// This class represents an fictionalised contruction of an entity with a personality
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Character"></see></summary>
    let Character = _prefix "Character"
    /// <summary>
    /// This class represents a group of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// This class represents a company
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Company"></see></summary>
    let Company = _prefix "Company"
    /// <summary>
    /// This class represents an organisation
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Organisation"></see></summary>
    let Organisation = _prefix "Organisation"
    /// <summary>
    /// This class represents a deal that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Deal"></see></summary>
    let Deal = _prefix "Deal"
    /// <summary>
    /// This class represents a emotional crisis
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Emotional-Crisis"></see></summary>
    let ``Emotional-Crisis`` = _prefix "Emotional-Crisis"
    /// <summary>
    /// This class represents an emnity that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Enmity"></see></summary>
    let Enmity = _prefix "Enmity"
    /// <summary>
    /// This class represents a foster bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Foster"></see></summary>
    let Foster = _prefix "Foster"
    /// <summary>
    /// This class represents an friendship that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Friendship"></see></summary>
    let Friendship = _prefix "Friendship"
    /// <summary>
    /// This class represents a governing group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Government"></see></summary>
    let Government = _prefix "Government"
    /// <summary>
    /// This class represents a household
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Household"></see></summary>
    let Household = _prefix "Household"
    /// <summary>
    /// This class represents a mental illness
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Mental-Illness"></see></summary>
    let ``Mental-Illness`` = _prefix "Mental-Illness"
    /// <summary>
    /// This class represents a partnership
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Partnership"></see></summary>
    let Partnership = _prefix "Partnership"
    /// <summary>
    /// This class represents a physical illness
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Illness"></see></summary>
    let ``Physical-Illness`` = _prefix "Physical-Illness"
    /// <summary>
    /// This class represents a physical injury
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Injury"></see></summary>
    let ``Physical-Injury`` = _prefix "Physical-Injury"
    /// <summary>
    /// This class represents a promise that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Pledge"></see></summary>
    let Pledge = _prefix "Pledge"
    /// <summary>
    /// This class represents a the bond between two entities where one claims ownership of the other
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Possession"></see></summary>
    let Possession = _prefix "Possession"
    /// <summary>
    /// This class represents a profession
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Profession"></see></summary>
    let Profession = _prefix "Profession"
    /// <summary>
    /// This class represents something that may develop into a being for cases where the being/item divide isn't clear
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Proto-Being"></see></summary>
    let ``Proto-Being`` = _prefix "Proto-Being"
    /// <summary>
    /// This class represents a step bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    /// This property specifies a title which can be used by any members of the group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-title"></see></summary>
    let ``carries-title`` = _prefix "carries-title"
    /// <summary>
    /// This property specifies a uniform which is worn by any members of the group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-uniform"></see></summary>
    let ``carries-uniform`` = _prefix "carries-uniform"
    /// <summary>
    /// This property specifies a cure event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#cured"></see></summary>
    let cured = _prefix "cured"
    /// <summary>
    /// This property specifies the conditions of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#deal-conditions"></see></summary>
    let ``deal-conditions`` = _prefix "deal-conditions"
    /// <summary>
    /// This property specifies the broker of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#dealbroker"></see></summary>
    let dealbroker = _prefix "dealbroker"
    /// <summary>
    /// This property specifies the broker of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#dealmaker"></see></summary>
    let dealmaker = _prefix "dealmaker"
    /// <summary>
    /// This property specifies a diagnosis event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#diagnosed"></see></summary>
    let diagnosed = _prefix "diagnosed"
    /// <summary>
    /// This property specifies an entering remission event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#entered-remission"></see></summary>
    let ``entered-remission`` = _prefix "entered-remission"
    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#governed-by"></see></summary>
    let ``governed-by`` = _prefix "governed-by"
    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#governs"></see></summary>
    let governs = _prefix "governs"
    /// <summary>
    /// This property specifies the emotional crisis of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-crisis"></see></summary>
    let ``has-crisis`` = _prefix "has-crisis"
    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-emotional-health"></see></summary>
    let ``has-emotional-health`` = _prefix "has-emotional-health"
    /// <summary>
    /// This property specifies that the specified being acting in loco parentis of the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-loco-parentis"></see></summary>
    let ``has-loco-parentis`` = _prefix "has-loco-parentis"
    /// <summary>
    /// This property specifies that the Being is the child of the specified Being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-relation-of"></see></summary>
    let ``is-relation-of`` = _prefix "is-relation-of"
    /// <summary>
    /// This property specifies that the being is acting in loco parentis of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#in-loco-parentis"></see></summary>
    let ``in-loco-parentis`` = _prefix "in-loco-parentis"
    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-mental-disorder"></see></summary>
    let ``has-mental-disorder`` = _prefix "has-mental-disorder"
    /// <summary>
    /// This property specifies the number of parts contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-number-of-parts"></see></summary>
    let ``has-number-of-parts`` = _prefix "has-number-of-parts"
    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-illness"></see></summary>
    let ``has-physical-illness`` = _prefix "has-physical-illness"
    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-injury"></see></summary>
    let ``has-physical-injury`` = _prefix "has-physical-injury"
    /// <summary>
    /// This property represents a pledge that the entity has a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-bonded-to"></see></summary>
    let ``have-bonded-to`` = _prefix "have-bonded-to"
    /// <summary>
    /// This property represents a pledge that the entity has done the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-done"></see></summary>
    let ``have-done`` = _prefix "have-done"
    /// <summary>
    /// This property represents a pledge that the entity does not have a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-bonded-to"></see></summary>
    let ``have-not-bonded-to`` = _prefix "have-not-bonded-to"
    /// <summary>
    /// This property represents a pledge that the entity has not done the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-done"></see></summary>
    let ``have-not-done`` = _prefix "have-not-done"
    /// <summary>
    /// This property represents a pledge that the entity is the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-a"></see></summary>
    let ``is-a`` = _prefix "is-a"
    /// <summary>
    /// This property specifies that the being is the child of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-child-of"></see></summary>
    let ``is-child-of`` = _prefix "is-child-of"
    /// <summary>
    /// This property specifies that the being is the parent of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-parent-of"></see></summary>
    let ``is-parent-of`` = _prefix "is-parent-of"
    /// <summary>
    /// This property represents a pledge that the entity is not the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-not-a"></see></summary>
    let ``is-not-a`` = _prefix "is-not-a"
    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#of-type"></see></summary>
    let ``of-type`` = _prefix "of-type"
    /// <summary>
    /// This property specifies ownership by an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#owned-by"></see></summary>
    let ``owned-by`` = _prefix "owned-by"
    /// <summary>
    /// This property specifies the ownership of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// This property specifies the place the being was born or created
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#place-of-birth"></see></summary>
    let ``place-of-birth`` = _prefix "place-of-birth"
    /// <summary>
    /// This property specifies the place that the being is a citizan of
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#place_of_citizenship"></see></summary>
    let place_of_citizenship = _prefix "place_of_citizenship"
    /// <summary>
    /// This property the entity making the pledge
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-maker"></see></summary>
    let ``pledge-maker`` = _prefix "pledge-maker"
    /// <summary>
    /// This property represents the reciever of the pledge
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-reciever"></see></summary>
    let ``pledge-reciever`` = _prefix "pledge-reciever"
    /// <summary>
    /// This property specifies what entity or event is being portrayed
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#portrays"></see></summary>
    let portrays = _prefix "portrays"
    /// <summary>
    /// This property specifies a language or alphabet read by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#reads"></see></summary>
    let reads = _prefix "reads"
    /// <summary>
    /// This property specifies a recovery event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#recovered"></see></summary>
    let recovered = _prefix "recovered"
    /// <summary>
    /// This property specifies a rehabilitation event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#rehabilitated"></see></summary>
    let rehabilitated = _prefix "rehabilitated"
    /// <summary>
    /// This property specifies a crisis resolution event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#resolved"></see></summary>
    let resolved = _prefix "resolved"
    /// <summary>
    /// This property specifies that the being is a sibling of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#sibling-of"></see></summary>
    let ``sibling-of`` = _prefix "sibling-of"
    /// <summary>
    /// This property specifies a language spoken by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks"></see></summary>
    let speaks = _prefix "speaks"
    /// <summary>
    /// This property specifies a language spoken at a basic level by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-basic"></see></summary>
    let ``speaks-basic`` = _prefix "speaks-basic"
    /// <summary>
    /// This property specifies a language spoken fluently by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-fluently"></see></summary>
    let ``speaks-fluently`` = _prefix "speaks-fluently"
    /// <summary>
    /// This property specifies a language almost spoken by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-pidgin"></see></summary>
    let ``speaks-pidgin`` = _prefix "speaks-pidgin"
    /// <summary>
    /// This property specifies a treatment event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#treated"></see></summary>
    let treated = _prefix "treated"
    /// <summary>
    /// This property specifies who/what an entity is typically used by
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#used-by"></see></summary>
    let ``used-by`` = _prefix "used-by"
    /// <summary>
    /// This property specifies an entity typically used by the refering entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#uses"></see></summary>
    let uses = _prefix "uses"
    /// <summary>
    /// This property specifies what the entity or event is being portrayed by
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#voiced-by"></see></summary>
    let ``voiced-by`` = _prefix "voiced-by"
    /// <summary>
    /// This property specifies what entity or event is being portrayed
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#voices"></see></summary>
    let voices = _prefix "voices"
    /// <summary>
    /// This property specifies an item worn by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#wears"></see></summary>
    let wears = _prefix "wears"
    /// <summary>
    /// This property specifies a class of items worn by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#wears-type"></see></summary>
    let ``wears-type`` = _prefix "wears-type"
    /// <summary>
    /// This property represents a pledge that the entity will bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-bond-to"></see></summary>
    let ``will-bond-to`` = _prefix "will-bond-to"
    /// <summary>
    /// This property represents a pledge that the entity will do the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-do"></see></summary>
    let ``will-do`` = _prefix "will-do"
    /// <summary>
    /// This property represents a pledge that the entity will not have a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-bond-to"></see></summary>
    let ``will-not-bond-to`` = _prefix "will-not-bond-to"
    /// <summary>
    /// This property represents a pledge that the entity will not do the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-do"></see></summary>
    let ``will-not-do`` = _prefix "will-not-do"
    /// <summary>
    /// This property represents the entity being worked for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#works-for"></see></summary>
    let ``works-for`` = _prefix "works-for"
    /// <summary>
    /// This property specifies a language or alphabet read by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#writes"></see></summary>
    let writes = _prefix "writes"
