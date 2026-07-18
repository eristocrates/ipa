namespace http.contextus.net.ontology.ontomedia.ext.common.being.hash

open DoxAletheia.Rdf_Vocabulary

module being =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/ext/common/being#"
    /// <summary>
    /// This class represents an adopted bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Adopted"></see></summary>
    let Adopted = Namespaced_IRI.parse _namespace_name "Adopted" |> NamespacedName
    /// <summary>
    /// This class represents a family bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// This class represents an alliance that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Alliance"></see></summary>
    let Alliance = Namespaced_IRI.parse _namespace_name "Alliance" |> NamespacedName
    /// <summary>
    /// This class represents a bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Bond"></see></summary>
    let Bond = Namespaced_IRI.parse _namespace_name "Bond" |> NamespacedName
    /// <summary>
    /// This class represents an Entity with a personality
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Being"></see></summary>
    let Being = Namespaced_IRI.parse _namespace_name "Being" |> NamespacedName
    /// <summary>
    /// This class represents a blood bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Blood"></see></summary>
    let Blood = Namespaced_IRI.parse _namespace_name "Blood" |> NamespacedName

    /// <summary>
    /// This class represents a bonded group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Bonded-Group"></see></summary>
    let ``Bonded-Group`` =
        Namespaced_IRI.parse _namespace_name "Bonded-Group" |> NamespacedName

    /// <summary>
    /// This class represents a community
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Community"></see></summary>
    let Community = Namespaced_IRI.parse _namespace_name "Community" |> NamespacedName
    /// <summary>
    /// This class represents an fictionalised contruction of an entity with a personality
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Character"></see></summary>
    let Character = Namespaced_IRI.parse _namespace_name "Character" |> NamespacedName
    /// <summary>
    /// This class represents a group of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// This class represents a company
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Company"></see></summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName

    /// <summary>
    /// This class represents an organisation
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Organisation"></see></summary>
    let Organisation =
        Namespaced_IRI.parse _namespace_name "Organisation" |> NamespacedName

    /// <summary>
    /// This class represents a deal that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Deal"></see></summary>
    let Deal = Namespaced_IRI.parse _namespace_name "Deal" |> NamespacedName

    /// <summary>
    /// This class represents a emotional crisis
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Emotional-Crisis"></see></summary>
    let ``Emotional-Crisis`` =
        Namespaced_IRI.parse _namespace_name "Emotional-Crisis" |> NamespacedName

    /// <summary>
    /// This class represents an emnity that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Enmity"></see></summary>
    let Enmity = Namespaced_IRI.parse _namespace_name "Enmity" |> NamespacedName
    /// <summary>
    /// This class represents a foster bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Foster"></see></summary>
    let Foster = Namespaced_IRI.parse _namespace_name "Foster" |> NamespacedName
    /// <summary>
    /// This class represents an friendship that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Friendship"></see></summary>
    let Friendship = Namespaced_IRI.parse _namespace_name "Friendship" |> NamespacedName
    /// <summary>
    /// This class represents a governing group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Government"></see></summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName
    /// <summary>
    /// This class represents a household
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Household"></see></summary>
    let Household = Namespaced_IRI.parse _namespace_name "Household" |> NamespacedName

    /// <summary>
    /// This class represents a mental illness
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Mental-Illness"></see></summary>
    let ``Mental-Illness`` =
        Namespaced_IRI.parse _namespace_name "Mental-Illness" |> NamespacedName

    /// <summary>
    /// This class represents a partnership
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Partnership"></see></summary>
    let Partnership =
        Namespaced_IRI.parse _namespace_name "Partnership" |> NamespacedName

    /// <summary>
    /// This class represents a physical illness
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Illness"></see></summary>
    let ``Physical-Illness`` =
        Namespaced_IRI.parse _namespace_name "Physical-Illness" |> NamespacedName

    /// <summary>
    /// This class represents a physical injury
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Injury"></see></summary>
    let ``Physical-Injury`` =
        Namespaced_IRI.parse _namespace_name "Physical-Injury" |> NamespacedName

    /// <summary>
    /// This class represents a promise that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Pledge"></see></summary>
    let Pledge = Namespaced_IRI.parse _namespace_name "Pledge" |> NamespacedName
    /// <summary>
    /// This class represents a the bond between two entities where one claims ownership of the other
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Possession"></see></summary>
    let Possession = Namespaced_IRI.parse _namespace_name "Possession" |> NamespacedName
    /// <summary>
    /// This class represents a profession
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Profession"></see></summary>
    let Profession = Namespaced_IRI.parse _namespace_name "Profession" |> NamespacedName

    /// <summary>
    /// This class represents something that may develop into a being for cases where the being/item divide isn't clear
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Proto-Being"></see></summary>
    let ``Proto-Being`` =
        Namespaced_IRI.parse _namespace_name "Proto-Being" |> NamespacedName

    /// <summary>
    /// This class represents a step bond that exists between beings or groups of beings
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName

    /// <summary>
    /// This property specifies a title which can be used by any members of the group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-title"></see></summary>
    let ``carries-title`` =
        Namespaced_IRI.parse _namespace_name "carries-title" |> NamespacedName

    /// <summary>
    /// This property specifies a uniform which is worn by any members of the group
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-uniform"></see></summary>
    let ``carries-uniform`` =
        Namespaced_IRI.parse _namespace_name "carries-uniform" |> NamespacedName

    /// <summary>
    /// This property specifies a cure event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#cured"></see></summary>
    let cured = Namespaced_IRI.parse _namespace_name "cured" |> NamespacedName

    /// <summary>
    /// This property specifies the conditions of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#deal-conditions"></see></summary>
    let ``deal-conditions`` =
        Namespaced_IRI.parse _namespace_name "deal-conditions" |> NamespacedName

    /// <summary>
    /// This property specifies the broker of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#dealbroker"></see></summary>
    let dealbroker = Namespaced_IRI.parse _namespace_name "dealbroker" |> NamespacedName
    /// <summary>
    /// This property specifies the broker of the deal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#dealmaker"></see></summary>
    let dealmaker = Namespaced_IRI.parse _namespace_name "dealmaker" |> NamespacedName
    /// <summary>
    /// This property specifies a diagnosis event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#diagnosed"></see></summary>
    let diagnosed = Namespaced_IRI.parse _namespace_name "diagnosed" |> NamespacedName

    /// <summary>
    /// This property specifies an entering remission event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#entered-remission"></see></summary>
    let ``entered-remission`` =
        Namespaced_IRI.parse _namespace_name "entered-remission" |> NamespacedName

    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#governed-by"></see></summary>
    let ``governed-by`` =
        Namespaced_IRI.parse _namespace_name "governed-by" |> NamespacedName

    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#governs"></see></summary>
    let governs = Namespaced_IRI.parse _namespace_name "governs" |> NamespacedName

    /// <summary>
    /// This property specifies the emotional crisis of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-crisis"></see></summary>
    let ``has-crisis`` =
        Namespaced_IRI.parse _namespace_name "has-crisis" |> NamespacedName

    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-emotional-health"></see></summary>
    let ``has-emotional-health`` =
        Namespaced_IRI.parse _namespace_name "has-emotional-health" |> NamespacedName

    /// <summary>
    /// This property specifies that the specified being acting in loco parentis of the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-loco-parentis"></see></summary>
    let ``has-loco-parentis`` =
        Namespaced_IRI.parse _namespace_name "has-loco-parentis" |> NamespacedName

    /// <summary>
    /// This property specifies that the Being is the child of the specified Being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-relation-of"></see></summary>
    let ``is-relation-of`` =
        Namespaced_IRI.parse _namespace_name "is-relation-of" |> NamespacedName

    /// <summary>
    /// This property specifies that the being is acting in loco parentis of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#in-loco-parentis"></see></summary>
    let ``in-loco-parentis`` =
        Namespaced_IRI.parse _namespace_name "in-loco-parentis" |> NamespacedName

    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-mental-disorder"></see></summary>
    let ``has-mental-disorder`` =
        Namespaced_IRI.parse _namespace_name "has-mental-disorder" |> NamespacedName

    /// <summary>
    /// This property specifies the number of parts contained by the collection
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-number-of-parts"></see></summary>
    let ``has-number-of-parts`` =
        Namespaced_IRI.parse _namespace_name "has-number-of-parts" |> NamespacedName

    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-illness"></see></summary>
    let ``has-physical-illness`` =
        Namespaced_IRI.parse _namespace_name "has-physical-illness" |> NamespacedName

    /// <summary>
    /// This property specifies the emotional well-being of a being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-injury"></see></summary>
    let ``has-physical-injury`` =
        Namespaced_IRI.parse _namespace_name "has-physical-injury" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity has a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-bonded-to"></see></summary>
    let ``have-bonded-to`` =
        Namespaced_IRI.parse _namespace_name "have-bonded-to" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity has done the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-done"></see></summary>
    let ``have-done`` =
        Namespaced_IRI.parse _namespace_name "have-done" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity does not have a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-bonded-to"></see></summary>
    let ``have-not-bonded-to`` =
        Namespaced_IRI.parse _namespace_name "have-not-bonded-to" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity has not done the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-done"></see></summary>
    let ``have-not-done`` =
        Namespaced_IRI.parse _namespace_name "have-not-done" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity is the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-a"></see></summary>
    let ``is-a`` = Namespaced_IRI.parse _namespace_name "is-a" |> NamespacedName

    /// <summary>
    /// This property specifies that the being is the child of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-child-of"></see></summary>
    let ``is-child-of`` =
        Namespaced_IRI.parse _namespace_name "is-child-of" |> NamespacedName

    /// <summary>
    /// This property specifies that the being is the parent of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-parent-of"></see></summary>
    let ``is-parent-of`` =
        Namespaced_IRI.parse _namespace_name "is-parent-of" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity is not the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#is-not-a"></see></summary>
    let ``is-not-a`` = Namespaced_IRI.parse _namespace_name "is-not-a" |> NamespacedName
    /// <summary>
    /// This property specifies a class of items of which the group or collection is made
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#of-type"></see></summary>
    let ``of-type`` = Namespaced_IRI.parse _namespace_name "of-type" |> NamespacedName
    /// <summary>
    /// This property specifies ownership by an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#owned-by"></see></summary>
    let ``owned-by`` = Namespaced_IRI.parse _namespace_name "owned-by" |> NamespacedName
    /// <summary>
    /// This property specifies the ownership of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName

    /// <summary>
    /// This property specifies the place the being was born or created
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#place-of-birth"></see></summary>
    let ``place-of-birth`` =
        Namespaced_IRI.parse _namespace_name "place-of-birth" |> NamespacedName

    /// <summary>
    /// This property specifies the place that the being is a citizan of
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#place_of_citizenship"></see></summary>
    let place_of_citizenship =
        Namespaced_IRI.parse _namespace_name "place_of_citizenship" |> NamespacedName

    /// <summary>
    /// This property the entity making the pledge
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-maker"></see></summary>
    let ``pledge-maker`` =
        Namespaced_IRI.parse _namespace_name "pledge-maker" |> NamespacedName

    /// <summary>
    /// This property represents the reciever of the pledge
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-reciever"></see></summary>
    let ``pledge-reciever`` =
        Namespaced_IRI.parse _namespace_name "pledge-reciever" |> NamespacedName

    /// <summary>
    /// This property specifies what entity or event is being portrayed
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#portrays"></see></summary>
    let portrays = Namespaced_IRI.parse _namespace_name "portrays" |> NamespacedName
    /// <summary>
    /// This property specifies a language or alphabet read by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#reads"></see></summary>
    let reads = Namespaced_IRI.parse _namespace_name "reads" |> NamespacedName
    /// <summary>
    /// This property specifies a recovery event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#recovered"></see></summary>
    let recovered = Namespaced_IRI.parse _namespace_name "recovered" |> NamespacedName

    /// <summary>
    /// This property specifies a rehabilitation event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#rehabilitated"></see></summary>
    let rehabilitated =
        Namespaced_IRI.parse _namespace_name "rehabilitated" |> NamespacedName

    /// <summary>
    /// This property specifies a crisis resolution event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#resolved"></see></summary>
    let resolved = Namespaced_IRI.parse _namespace_name "resolved" |> NamespacedName

    /// <summary>
    /// This property specifies that the being is a sibling of the specified being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#sibling-of"></see></summary>
    let ``sibling-of`` =
        Namespaced_IRI.parse _namespace_name "sibling-of" |> NamespacedName

    /// <summary>
    /// This property specifies a language spoken by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks"></see></summary>
    let speaks = Namespaced_IRI.parse _namespace_name "speaks" |> NamespacedName

    /// <summary>
    /// This property specifies a language spoken at a basic level by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-basic"></see></summary>
    let ``speaks-basic`` =
        Namespaced_IRI.parse _namespace_name "speaks-basic" |> NamespacedName

    /// <summary>
    /// This property specifies a language spoken fluently by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-fluently"></see></summary>
    let ``speaks-fluently`` =
        Namespaced_IRI.parse _namespace_name "speaks-fluently" |> NamespacedName

    /// <summary>
    /// This property specifies a language almost spoken by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-pidgin"></see></summary>
    let ``speaks-pidgin`` =
        Namespaced_IRI.parse _namespace_name "speaks-pidgin" |> NamespacedName

    /// <summary>
    /// This property specifies a treatment event
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#treated"></see></summary>
    let treated = Namespaced_IRI.parse _namespace_name "treated" |> NamespacedName
    /// <summary>
    /// This property specifies who/what an entity is typically used by
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#used-by"></see></summary>
    let ``used-by`` = Namespaced_IRI.parse _namespace_name "used-by" |> NamespacedName
    /// <summary>
    /// This property specifies an entity typically used by the refering entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#uses"></see></summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    /// This property specifies what the entity or event is being portrayed by
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#voiced-by"></see></summary>
    let ``voiced-by`` =
        Namespaced_IRI.parse _namespace_name "voiced-by" |> NamespacedName

    /// <summary>
    /// This property specifies what entity or event is being portrayed
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#voices"></see></summary>
    let voices = Namespaced_IRI.parse _namespace_name "voices" |> NamespacedName
    /// <summary>
    /// This property specifies an item worn by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#wears"></see></summary>
    let wears = Namespaced_IRI.parse _namespace_name "wears" |> NamespacedName

    /// <summary>
    /// This property specifies a class of items worn by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#wears-type"></see></summary>
    let ``wears-type`` =
        Namespaced_IRI.parse _namespace_name "wears-type" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity will bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-bond-to"></see></summary>
    let ``will-bond-to`` =
        Namespaced_IRI.parse _namespace_name "will-bond-to" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity will do the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-do"></see></summary>
    let ``will-do`` = Namespaced_IRI.parse _namespace_name "will-do" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity will not have a bond with the named entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-bond-to"></see></summary>
    let ``will-not-bond-to`` =
        Namespaced_IRI.parse _namespace_name "will-not-bond-to" |> NamespacedName

    /// <summary>
    /// This property represents a pledge that the entity will not do the named thing
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-do"></see></summary>
    let ``will-not-do`` =
        Namespaced_IRI.parse _namespace_name "will-not-do" |> NamespacedName

    /// <summary>
    /// This property represents the entity being worked for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#works-for"></see></summary>
    let ``works-for`` =
        Namespaced_IRI.parse _namespace_name "works-for" |> NamespacedName

    /// <summary>
    /// This property specifies a language or alphabet read by the being
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/being#writes"></see></summary>
    let writes = Namespaced_IRI.parse _namespace_name "writes" |> NamespacedName
