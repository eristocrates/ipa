namespace http.contextus.net.ontology.ontomedia.ext.common.being.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module being =
    let _namespace_iri = Namespace_Iri being |> NamespaceIRI
    /// <summary>
    ///   <para>being:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OntoMedia Being Representation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#">http://contextus.net/ontology/ontomedia/ext/common/being#</seealso>
    let _prefix_iri = Prefixed_Name(being, "") |> PrefixedName
    /// <summary>
    ///   <para>being:Bond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a bond that exists between beings or groups of beings</para>
    /// labels<para>Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Bond">http://contextus.net/ontology/ontomedia/ext/common/being#Bond</seealso>
    let Bond = Prefixed_Name(being, "Bond") |> PrefixedName
    /// <summary>
    ///   <para>being:Blood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a blood bond that exists between beings or groups of beings</para>
    /// labels<para>Blood Family Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Blood">http://contextus.net/ontology/ontomedia/ext/common/being#Blood</seealso>
    let Blood = Prefixed_Name(being, "Blood") |> PrefixedName
    /// <summary>
    ///   <para>being:Bonded-Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a bonded group</para>
    /// labels<para>Bonded Group</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Bonded-Group">http://contextus.net/ontology/ontomedia/ext/common/being#Bonded-Group</seealso>
    let Bonded_Group = Prefixed_Name(being, "Bonded-Group") |> PrefixedName
    /// <summary>
    ///   <para>being:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a group of beings</para>
    /// labels<para>Group</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Group">http://contextus.net/ontology/ontomedia/ext/common/being#Group</seealso>
    let Group = Prefixed_Name(being, "Group") |> PrefixedName
    /// <summary>
    ///   <para>being:Enmity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an emnity that exists between beings or groups of beings</para>
    /// labels<para>Enmity</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Enmity">http://contextus.net/ontology/ontomedia/ext/common/being#Enmity</seealso>
    let Enmity = Prefixed_Name(being, "Enmity") |> PrefixedName
    /// <summary>
    ///   <para>being:Friendship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an friendship that exists between beings or groups of beings</para>
    /// labels<para>Friendship</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Friendship">http://contextus.net/ontology/ontomedia/ext/common/being#Friendship</seealso>
    let Friendship = Prefixed_Name(being, "Friendship") |> PrefixedName
    /// <summary>
    ///   <para>being:Mental-Illness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a mental illness</para>
    /// labels<para>Mental Illness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Mental-Illness">http://contextus.net/ontology/ontomedia/ext/common/being#Mental-Illness</seealso>
    let Mental_Illness = Prefixed_Name(being, "Mental-Illness") |> PrefixedName
    /// <summary>
    ///   <para>being:Pledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a promise that exists between beings or groups of beings</para>
    /// labels<para>Pledge</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Pledge">http://contextus.net/ontology/ontomedia/ext/common/being#Pledge</seealso>
    let Pledge = Prefixed_Name(being, "Pledge") |> PrefixedName
    /// <summary>
    ///   <para>being:Proto-Being</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents something that may develop into a being for cases where the being/item divide isn't clear</para>
    /// labels<para>Proto-Being</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Proto-Being">http://contextus.net/ontology/ontomedia/ext/common/being#Proto-Being</seealso>
    let Proto_Being = Prefixed_Name(being, "Proto-Being") |> PrefixedName
    /// <summary>
    ///   <para>being:carries-uniform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a uniform which is worn by any members of the group</para>
    /// labels<para>Carries Uniform</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-uniform">http://contextus.net/ontology/ontomedia/ext/common/being#carries-uniform</seealso>
    let carries_uniform = Prefixed_Name(being, "carries-uniform") |> PrefixedName
    /// <summary>
    ///   <para>being:deal-conditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the conditions of the deal</para>
    /// labels<para>Deal Conditions</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#deal-conditions">http://contextus.net/ontology/ontomedia/ext/common/being#deal-conditions</seealso>
    let deal_conditions = Prefixed_Name(being, "deal-conditions") |> PrefixedName
    /// <summary>
    ///   <para>being:is-relation-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the Being is the child of the specified Being</para>
    /// labels<para>Is Relation Of</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#is-relation-of">http://contextus.net/ontology/ontomedia/ext/common/being#is-relation-of</seealso>
    let is_relation_of = Prefixed_Name(being, "is-relation-of") |> PrefixedName
    /// <summary>
    ///   <para>being:in-loco-parentis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the being is acting in loco parentis of the specified being</para>
    /// labels<para>In Loco Parentis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#in-loco-parentis">http://contextus.net/ontology/ontomedia/ext/common/being#in-loco-parentis</seealso>
    let in_loco_parentis = Prefixed_Name(being, "in-loco-parentis") |> PrefixedName

    /// <summary>
    ///   <para>being:has-mental-disorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the emotional well-being of a being</para>
    /// labels<para>Mental Health</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-mental-disorder">http://contextus.net/ontology/ontomedia/ext/common/being#has-mental-disorder</seealso>
    let has_mental_disorder =
        Prefixed_Name(being, "has-mental-disorder") |> PrefixedName

    /// <summary>
    ///   <para>being:has-number-of-parts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the number of parts contained by the collection</para>
    /// labels<para>Has Number Of Parts</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-number-of-parts">http://contextus.net/ontology/ontomedia/ext/common/being#has-number-of-parts</seealso>
    let has_number_of_parts =
        Prefixed_Name(being, "has-number-of-parts") |> PrefixedName

    /// <summary>
    ///   <para>being:has-physical-injury</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the emotional well-being of a being</para>
    /// labels<para>Physical Injury</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-injury">http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-injury</seealso>
    let has_physical_injury =
        Prefixed_Name(being, "has-physical-injury") |> PrefixedName

    /// <summary>
    ///   <para>being:have-bonded-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity has a bond with the named entity</para>
    /// labels<para>Have Bonded To</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#have-bonded-to">http://contextus.net/ontology/ontomedia/ext/common/being#have-bonded-to</seealso>
    let have_bonded_to = Prefixed_Name(being, "have-bonded-to") |> PrefixedName
    /// <summary>
    ///   <para>being:have-not-bonded-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity does not have a bond with the named entity</para>
    /// labels<para>Have Not Bonded To</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-bonded-to">http://contextus.net/ontology/ontomedia/ext/common/being#have-not-bonded-to</seealso>
    let have_not_bonded_to = Prefixed_Name(being, "have-not-bonded-to") |> PrefixedName
    /// <summary>
    ///   <para>being:is-a</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity is the named thing</para>
    /// labels<para>Is A</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#is-a">http://contextus.net/ontology/ontomedia/ext/common/being#is-a</seealso>
    let is_a = Prefixed_Name(being, "is-a") |> PrefixedName
    /// <summary>
    ///   <para>being:is-child-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the being is the child of the specified being</para>
    /// labels<para>Is Child Of</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#is-child-of">http://contextus.net/ontology/ontomedia/ext/common/being#is-child-of</seealso>
    let is_child_of = Prefixed_Name(being, "is-child-of") |> PrefixedName
    /// <summary>
    ///   <para>being:is-not-a</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity is not the named thing</para>
    /// labels<para>Is Not A</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#is-not-a">http://contextus.net/ontology/ontomedia/ext/common/being#is-not-a</seealso>
    let is_not_a = Prefixed_Name(being, "is-not-a") |> PrefixedName
    /// <summary>
    ///   <para>being:of-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a class of items of which the group or collection is made</para>
    /// labels<para>Of Type</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#of-type">http://contextus.net/ontology/ontomedia/ext/common/being#of-type</seealso>
    let of_type = Prefixed_Name(being, "of-type") |> PrefixedName
    /// <summary>
    ///   <para>being:owned-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies ownership by an entity</para>
    /// labels<para>Owns</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#owned-by">http://contextus.net/ontology/ontomedia/ext/common/being#owned-by</seealso>
    let owned_by = Prefixed_Name(being, "owned-by") |> PrefixedName
    /// <summary>
    ///   <para>being:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the ownership of an entity</para>
    /// labels<para>Owns</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#owns">http://contextus.net/ontology/ontomedia/ext/common/being#owns</seealso>
    let owns = Prefixed_Name(being, "owns") |> PrefixedName
    /// <summary>
    ///   <para>being:place-of-birth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the place the being was born or created</para>
    /// labels<para>Place of Birth</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#place-of-birth">http://contextus.net/ontology/ontomedia/ext/common/being#place-of-birth</seealso>
    let place_of_birth = Prefixed_Name(being, "place-of-birth") |> PrefixedName

    /// <summary>
    ///   <para>being:place_of_citizenship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the place that the being is a citizan of</para>
    /// labels<para>Place of Citizenship</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#place_of_citizenship">http://contextus.net/ontology/ontomedia/ext/common/being#place_of_citizenship</seealso>
    let place_of_citizenship =
        Prefixed_Name(being, "place_of_citizenship") |> PrefixedName

    /// <summary>
    ///   <para>being:pledge-maker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property the entity making the pledge</para>
    /// labels<para>Pledge Maker</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-maker">http://contextus.net/ontology/ontomedia/ext/common/being#pledge-maker</seealso>
    let pledge_maker = Prefixed_Name(being, "pledge-maker") |> PrefixedName
    /// <summary>
    ///   <para>being:pledge-reciever</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents the reciever of the pledge</para>
    /// labels<para>Pledged Reciever</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#pledge-reciever">http://contextus.net/ontology/ontomedia/ext/common/being#pledge-reciever</seealso>
    let pledge_reciever = Prefixed_Name(being, "pledge-reciever") |> PrefixedName
    /// <summary>
    ///   <para>being:portrays</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies what entity or event is being portrayed</para>
    /// labels<para>Portrays</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#portrays">http://contextus.net/ontology/ontomedia/ext/common/being#portrays</seealso>
    let portrays = Prefixed_Name(being, "portrays") |> PrefixedName
    /// <summary>
    ///   <para>being:voiced-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies what the entity or event is being portrayed by</para>
    /// labels<para>Voiced By</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#voiced-by">http://contextus.net/ontology/ontomedia/ext/common/being#voiced-by</seealso>
    let voiced_by = Prefixed_Name(being, "voiced-by") |> PrefixedName
    /// <summary>
    ///   <para>being:Adopted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an adopted bond that exists between beings or groups of beings</para>
    /// labels<para>Adopted Family Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Adopted">http://contextus.net/ontology/ontomedia/ext/common/being#Adopted</seealso>
    let Adopted = Prefixed_Name(being, "Adopted") |> PrefixedName
    /// <summary>
    ///   <para>being:Being</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an Entity with a personality</para>
    /// labels<para>Being</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Being">http://contextus.net/ontology/ontomedia/ext/common/being#Being</seealso>
    let Being = Prefixed_Name(being, "Being") |> PrefixedName
    /// <summary>
    ///   <para>being:Community</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a community</para>
    /// labels<para>Community</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Community">http://contextus.net/ontology/ontomedia/ext/common/being#Community</seealso>
    let Community = Prefixed_Name(being, "Community") |> PrefixedName
    /// <summary>
    ///   <para>being:Company</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a company</para>
    /// labels<para>Company</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Company">http://contextus.net/ontology/ontomedia/ext/common/being#Company</seealso>
    let Company = Prefixed_Name(being, "Company") |> PrefixedName
    /// <summary>
    ///   <para>being:Foster</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a foster bond that exists between beings or groups of beings</para>
    /// labels<para>Foster Family Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Foster">http://contextus.net/ontology/ontomedia/ext/common/being#Foster</seealso>
    let Foster = Prefixed_Name(being, "Foster") |> PrefixedName
    /// <summary>
    ///   <para>being:Household</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a household</para>
    /// labels<para>Household</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Household">http://contextus.net/ontology/ontomedia/ext/common/being#Household</seealso>
    let Household = Prefixed_Name(being, "Household") |> PrefixedName
    /// <summary>
    ///   <para>being:Partnership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a partnership</para>
    /// labels<para>Partnership</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Partnership">http://contextus.net/ontology/ontomedia/ext/common/being#Partnership</seealso>
    let Partnership = Prefixed_Name(being, "Partnership") |> PrefixedName
    /// <summary>
    ///   <para>being:Physical-Illness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a physical illness</para>
    /// labels<para>Physical Illness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Illness">http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Illness</seealso>
    let Physical_Illness = Prefixed_Name(being, "Physical-Illness") |> PrefixedName
    /// <summary>
    ///   <para>being:Physical-Injury</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a physical injury</para>
    /// labels<para>Physical Injury</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Injury">http://contextus.net/ontology/ontomedia/ext/common/being#Physical-Injury</seealso>
    let Physical_Injury = Prefixed_Name(being, "Physical-Injury") |> PrefixedName
    /// <summary>
    ///   <para>being:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a step bond that exists between beings or groups of beings</para>
    /// labels<para>Step Family Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Step">http://contextus.net/ontology/ontomedia/ext/common/being#Step</seealso>
    let Step = Prefixed_Name(being, "Step") |> PrefixedName
    /// <summary>
    ///   <para>being:cured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a cure event</para>
    /// labels<para>Cured</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#cured">http://contextus.net/ontology/ontomedia/ext/common/being#cured</seealso>
    let cured = Prefixed_Name(being, "cured") |> PrefixedName
    /// <summary>
    ///   <para>being:dealbroker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the broker of the deal</para>
    /// labels<para>Deal Broker</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#dealbroker">http://contextus.net/ontology/ontomedia/ext/common/being#dealbroker</seealso>
    let dealbroker = Prefixed_Name(being, "dealbroker") |> PrefixedName
    /// <summary>
    ///   <para>being:diagnosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a diagnosis event</para>
    /// labels<para>Diagnosed</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#diagnosed">http://contextus.net/ontology/ontomedia/ext/common/being#diagnosed</seealso>
    let diagnosed = Prefixed_Name(being, "diagnosed") |> PrefixedName
    /// <summary>
    ///   <para>being:reads</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language or alphabet read by the being</para>
    /// labels<para>Reads</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#reads">http://contextus.net/ontology/ontomedia/ext/common/being#reads</seealso>
    let reads = Prefixed_Name(being, "reads") |> PrefixedName
    /// <summary>
    ///   <para>being:recovered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a recovery event</para>
    /// labels<para>Recovered</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#recovered">http://contextus.net/ontology/ontomedia/ext/common/being#recovered</seealso>
    let recovered = Prefixed_Name(being, "recovered") |> PrefixedName
    /// <summary>
    ///   <para>being:Organisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an organisation</para>
    /// labels<para>Organisation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Organisation">http://contextus.net/ontology/ontomedia/ext/common/being#Organisation</seealso>
    let Organisation = Prefixed_Name(being, "Organisation") |> PrefixedName
    /// <summary>
    ///   <para>being:Profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a profession</para>
    /// labels<para>Profession</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Profession">http://contextus.net/ontology/ontomedia/ext/common/being#Profession</seealso>
    let Profession = Prefixed_Name(being, "Profession") |> PrefixedName
    /// <summary>
    ///   <para>being:carries-title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a title which can be used by any members of the group</para>
    /// labels<para>Carries Title</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#carries-title">http://contextus.net/ontology/ontomedia/ext/common/being#carries-title</seealso>
    let carries_title = Prefixed_Name(being, "carries-title") |> PrefixedName
    /// <summary>
    ///   <para>being:Possession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a the bond between two entities where one claims ownership of the other</para>
    /// labels<para>Possession</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Possession">http://contextus.net/ontology/ontomedia/ext/common/being#Possession</seealso>
    let Possession = Prefixed_Name(being, "Possession") |> PrefixedName
    /// <summary>
    ///   <para>being:wears-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a class of items worn by the being</para>
    /// labels<para>Wears Type</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#wears-type">http://contextus.net/ontology/ontomedia/ext/common/being#wears-type</seealso>
    let wears_type = Prefixed_Name(being, "wears-type") |> PrefixedName
    /// <summary>
    ///   <para>being:dealmaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the broker of the deal</para>
    /// labels<para>Deal Broker</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#dealmaker">http://contextus.net/ontology/ontomedia/ext/common/being#dealmaker</seealso>
    let dealmaker = Prefixed_Name(being, "dealmaker") |> PrefixedName
    /// <summary>
    ///   <para>being:entered-remission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an entering remission event</para>
    /// labels<para>Entered Remission</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#entered-remission">http://contextus.net/ontology/ontomedia/ext/common/being#entered-remission</seealso>
    let entered_remission = Prefixed_Name(being, "entered-remission") |> PrefixedName
    /// <summary>
    ///   <para>being:governed-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a class of items of which the group or collection is made</para>
    /// labels<para>Governed By</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#governed-by">http://contextus.net/ontology/ontomedia/ext/common/being#governed-by</seealso>
    let governed_by = Prefixed_Name(being, "governed-by") |> PrefixedName
    /// <summary>
    ///   <para>being:governs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a class of items of which the group or collection is made</para>
    /// labels<para>Governs</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#governs">http://contextus.net/ontology/ontomedia/ext/common/being#governs</seealso>
    let governs = Prefixed_Name(being, "governs") |> PrefixedName
    /// <summary>
    ///   <para>being:has-crisis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the emotional crisis of a being</para>
    /// labels<para>Has Crisis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-crisis">http://contextus.net/ontology/ontomedia/ext/common/being#has-crisis</seealso>
    let has_crisis = Prefixed_Name(being, "has-crisis") |> PrefixedName

    /// <summary>
    ///   <para>being:has-emotional-health</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the emotional well-being of a being</para>
    /// labels<para>Emotional Health</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-emotional-health">http://contextus.net/ontology/ontomedia/ext/common/being#has-emotional-health</seealso>
    let has_emotional_health =
        Prefixed_Name(being, "has-emotional-health") |> PrefixedName

    /// <summary>
    ///   <para>being:has-loco-parentis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the specified being acting in loco parentis of the being</para>
    /// labels<para>Has Loco Parentis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-loco-parentis">http://contextus.net/ontology/ontomedia/ext/common/being#has-loco-parentis</seealso>
    let has_loco_parentis = Prefixed_Name(being, "has-loco-parentis") |> PrefixedName

    /// <summary>
    ///   <para>being:has-physical-illness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the emotional well-being of a being</para>
    /// labels<para>Physical Illness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-illness">http://contextus.net/ontology/ontomedia/ext/common/being#has-physical-illness</seealso>
    let has_physical_illness =
        Prefixed_Name(being, "has-physical-illness") |> PrefixedName

    /// <summary>
    ///   <para>being:have-done</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity has done the named thing</para>
    /// labels<para>Have Done</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#have-done">http://contextus.net/ontology/ontomedia/ext/common/being#have-done</seealso>
    let have_done = Prefixed_Name(being, "have-done") |> PrefixedName
    /// <summary>
    ///   <para>being:have-not-done</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity has not done the named thing</para>
    /// labels<para>Have Not Done</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#have-not-done">http://contextus.net/ontology/ontomedia/ext/common/being#have-not-done</seealso>
    let have_not_done = Prefixed_Name(being, "have-not-done") |> PrefixedName
    /// <summary>
    ///   <para>being:is-parent-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the being is the parent of the specified being</para>
    /// labels<para>Is Parent Of</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#is-parent-of">http://contextus.net/ontology/ontomedia/ext/common/being#is-parent-of</seealso>
    let is_parent_of = Prefixed_Name(being, "is-parent-of") |> PrefixedName
    /// <summary>
    ///   <para>being:resolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a crisis resolution event</para>
    /// labels<para>Resolved</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#resolved">http://contextus.net/ontology/ontomedia/ext/common/being#resolved</seealso>
    let resolved = Prefixed_Name(being, "resolved") |> PrefixedName
    /// <summary>
    ///   <para>being:speaks-fluently</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language spoken fluently by the being</para>
    /// labels<para>Speaks Fluently</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-fluently">http://contextus.net/ontology/ontomedia/ext/common/being#speaks-fluently</seealso>
    let speaks_fluently = Prefixed_Name(being, "speaks-fluently") |> PrefixedName
    /// <summary>
    ///   <para>being:voices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies what entity or event is being portrayed</para>
    /// labels<para>Voices</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#voices">http://contextus.net/ontology/ontomedia/ext/common/being#voices</seealso>
    let voices = Prefixed_Name(being, "voices") |> PrefixedName
    /// <summary>
    ///   <para>being:wears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an item worn by the being</para>
    /// labels<para>Wears</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#wears">http://contextus.net/ontology/ontomedia/ext/common/being#wears</seealso>
    let wears = Prefixed_Name(being, "wears") |> PrefixedName
    /// <summary>
    ///   <para>being:will-bond-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity will bond with the named entity</para>
    /// labels<para>Will Bond To</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#will-bond-to">http://contextus.net/ontology/ontomedia/ext/common/being#will-bond-to</seealso>
    let will_bond_to = Prefixed_Name(being, "will-bond-to") |> PrefixedName
    /// <summary>
    ///   <para>being:will-do</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity will do the named thing</para>
    /// labels<para>Will Do</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#will-do">http://contextus.net/ontology/ontomedia/ext/common/being#will-do</seealso>
    let will_do = Prefixed_Name(being, "will-do") |> PrefixedName
    /// <summary>
    ///   <para>being:will-not-bond-to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity will not have a bond with the named entity</para>
    /// labels<para>Will Not Bond To</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-bond-to">http://contextus.net/ontology/ontomedia/ext/common/being#will-not-bond-to</seealso>
    let will_not_bond_to = Prefixed_Name(being, "will-not-bond-to") |> PrefixedName
    /// <summary>
    ///   <para>being:rehabilitated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a rehabilitation event</para>
    /// labels<para>Rehabilitated</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#rehabilitated">http://contextus.net/ontology/ontomedia/ext/common/being#rehabilitated</seealso>
    let rehabilitated = Prefixed_Name(being, "rehabilitated") |> PrefixedName
    /// <summary>
    ///   <para>being:sibling-of</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies that the being is a sibling of the specified being</para>
    /// labels<para>Sibling Of</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#sibling-of">http://contextus.net/ontology/ontomedia/ext/common/being#sibling-of</seealso>
    let sibling_of = Prefixed_Name(being, "sibling-of") |> PrefixedName
    /// <summary>
    ///   <para>being:speaks-basic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language spoken at a basic level by the being</para>
    /// labels<para>Speaks Basic</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-basic">http://contextus.net/ontology/ontomedia/ext/common/being#speaks-basic</seealso>
    let speaks_basic = Prefixed_Name(being, "speaks-basic") |> PrefixedName
    /// <summary>
    ///   <para>being:speaks-pidgin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language almost spoken by the being</para>
    /// labels<para>Speaks Pidgin</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks-pidgin">http://contextus.net/ontology/ontomedia/ext/common/being#speaks-pidgin</seealso>
    let speaks_pidgin = Prefixed_Name(being, "speaks-pidgin") |> PrefixedName
    /// <summary>
    ///   <para>being:used-by</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies who/what an entity is typically used by</para>
    /// labels<para>Used By</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#used-by">http://contextus.net/ontology/ontomedia/ext/common/being#used-by</seealso>
    let used_by = Prefixed_Name(being, "used-by") |> PrefixedName
    /// <summary>
    ///   <para>being:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an entity typically used by the refering entity</para>
    /// labels<para>Uses</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#uses">http://contextus.net/ontology/ontomedia/ext/common/being#uses</seealso>
    let uses = Prefixed_Name(being, "uses") |> PrefixedName
    /// <summary>
    ///   <para>being:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a family bond that exists between beings or groups of beings</para>
    /// labels<para>Family Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Family">http://contextus.net/ontology/ontomedia/ext/common/being#Family</seealso>
    let Family = Prefixed_Name(being, "Family") |> PrefixedName
    /// <summary>
    ///   <para>being:Alliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an alliance that exists between beings or groups of beings</para>
    /// labels<para>Alliance</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Alliance">http://contextus.net/ontology/ontomedia/ext/common/being#Alliance</seealso>
    let Alliance = Prefixed_Name(being, "Alliance") |> PrefixedName
    /// <summary>
    ///   <para>being:Character</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an fictionalised contruction of an entity with a personality</para>
    /// labels<para>Character</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Character">http://contextus.net/ontology/ontomedia/ext/common/being#Character</seealso>
    let Character = Prefixed_Name(being, "Character") |> PrefixedName
    /// <summary>
    ///   <para>being:Deal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a deal that exists between beings or groups of beings</para>
    /// labels<para>Deal</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Deal">http://contextus.net/ontology/ontomedia/ext/common/being#Deal</seealso>
    let Deal = Prefixed_Name(being, "Deal") |> PrefixedName
    /// <summary>
    ///   <para>being:Emotional-Crisis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a emotional crisis</para>
    /// labels<para>Emotional Crisis</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Emotional-Crisis">http://contextus.net/ontology/ontomedia/ext/common/being#Emotional-Crisis</seealso>
    let Emotional_Crisis = Prefixed_Name(being, "Emotional-Crisis") |> PrefixedName
    /// <summary>
    ///   <para>being:Government</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a governing group</para>
    /// labels<para>Government</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#Government">http://contextus.net/ontology/ontomedia/ext/common/being#Government</seealso>
    let Government = Prefixed_Name(being, "Government") |> PrefixedName
    /// <summary>
    ///   <para>being:speaks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language spoken by the being</para>
    /// labels<para>Speaks</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#speaks">http://contextus.net/ontology/ontomedia/ext/common/being#speaks</seealso>
    let speaks = Prefixed_Name(being, "speaks") |> PrefixedName
    /// <summary>
    ///   <para>being:treated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a treatment event</para>
    /// labels<para>Treated</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#treated">http://contextus.net/ontology/ontomedia/ext/common/being#treated</seealso>
    let treated = Prefixed_Name(being, "treated") |> PrefixedName
    /// <summary>
    ///   <para>being:will-not-do</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents a pledge that the entity will not do the named thing</para>
    /// labels<para>Will Not Do</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#will-not-do">http://contextus.net/ontology/ontomedia/ext/common/being#will-not-do</seealso>
    let will_not_do = Prefixed_Name(being, "will-not-do") |> PrefixedName
    /// <summary>
    ///   <para>being:works-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property represents the entity being worked for</para>
    /// labels<para>Works For</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#works-for">http://contextus.net/ontology/ontomedia/ext/common/being#works-for</seealso>
    let works_for = Prefixed_Name(being, "works-for") |> PrefixedName
    /// <summary>
    ///   <para>being:writes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a language or alphabet read by the being</para>
    /// labels<para>Writes</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/being#writes">http://contextus.net/ontology/ontomedia/ext/common/being#writes</seealso>
    let writes = Prefixed_Name(being, "writes") |> PrefixedName
