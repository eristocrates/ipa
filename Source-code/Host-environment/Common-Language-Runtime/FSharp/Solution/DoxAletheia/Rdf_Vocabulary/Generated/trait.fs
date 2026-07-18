namespace http.contextus.net.ontology.ontomedia.ext.common._trait.hash

open DoxAletheia.Rdf_Vocabulary

module trait_ =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/ext/common/trait#"

    /// <summary>
    /// This class represents a component part of an abstract item
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Component"></see></summary>
    let ``Abstract-Component`` =
        Namespaced_IRI.parse _namespace_name "Abstract-Component" |> NamespacedName

    /// <summary>
    /// This class represents the value of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Value"></see></summary>
    let Value = Namespaced_IRI.parse _namespace_name "Value" |> NamespacedName

    /// <summary>
    /// This class represents an abstract problem or obstacle
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Obstacle"></see></summary>
    let ``Abstract-Obstacle`` =
        Namespaced_IRI.parse _namespace_name "Abstract-Obstacle" |> NamespacedName

    /// <summary>
    /// This class represents the characteristics that describe an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Trait"></see></summary>
    let Trait = Namespaced_IRI.parse _namespace_name "Trait" |> NamespacedName

    /// <summary>
    /// This class represents the characteristics that describe a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Being-Trait"></see></summary>
    let ``Being-Trait`` =
        Namespaced_IRI.parse _namespace_name "Being-Trait" |> NamespacedName

    /// <summary>
    /// This class represents the adult stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Adult"></see></summary>
    let Adult = Namespaced_IRI.parse _namespace_name "Adult" |> NamespacedName

    /// <summary>
    /// This class represents the stage of life of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Stage-Of-Life"></see></summary>
    let ``Stage-Of-Life`` =
        Namespaced_IRI.parse _namespace_name "Stage-Of-Life" |> NamespacedName

    /// <summary>
    /// This class represents the age of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Age"></see></summary>
    let Age = Namespaced_IRI.parse _namespace_name "Age" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is alive
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Alive"></see></summary>
    let Alive = Namespaced_IRI.parse _namespace_name "Alive" |> NamespacedName

    /// <summary>
    /// This class represents the state of being of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Being"></see></summary>
    let ``State-Of-Being`` =
        Namespaced_IRI.parse _namespace_name "State-Of-Being" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which is dead
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dead"></see></summary>
    let Dead = Namespaced_IRI.parse _namespace_name "Dead" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is undead
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Undead"></see></summary>
    let Undead = Namespaced_IRI.parse _namespace_name "Undead" |> NamespacedName
    /// <summary>
    /// This class describes an Entity those state of existance cannot be proved
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unprovable"></see></summary>
    let Unprovable = Namespaced_IRI.parse _namespace_name "Unprovable" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which exists but is not, never was or never can be alive
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Inanimate"></see></summary>
    let Inanimate = Namespaced_IRI.parse _namespace_name "Inanimate" |> NamespacedName
    /// <summary>
    /// This class describes an Entity those state of existance is not unknown but is theoretically provable
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unknown"></see></summary>
    let Unknown = Namespaced_IRI.parse _namespace_name "Unknown" |> NamespacedName
    /// <summary>
    /// This class describes an Entity whose consciousness is not in its normal state
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Altered"></see></summary>
    let Altered = Namespaced_IRI.parse _namespace_name "Altered" |> NamespacedName

    /// <summary>
    /// This class represents the state of consciousness of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Consciousness"></see></summary>
    let ``State-Of-Consciousness`` =
        Namespaced_IRI.parse _namespace_name "State-Of-Consciousness" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which is asleep
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Asleep"></see></summary>
    let Asleep = Namespaced_IRI.parse _namespace_name "Asleep" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is conscious
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Conscious"></see></summary>
    let Conscious = Namespaced_IRI.parse _namespace_name "Conscious" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which is totally unresponsive to external stimuli i.e. coma
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unresponsive"></see></summary>
    let Unresponsive =
        Namespaced_IRI.parse _namespace_name "Unresponsive" |> NamespacedName

    /// <summary>
    /// This class describes an Entity that is working at a totally instinctual/subconscious level
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Instinctual"></see></summary>
    let Instinctual =
        Namespaced_IRI.parse _namespace_name "Instinctual" |> NamespacedName

    /// <summary>
    /// This class represents the behavioural or psychological sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Behavioural-Sex"></see></summary>
    let ``Behavioural-Sex`` =
        Namespaced_IRI.parse _namespace_name "Behavioural-Sex" |> NamespacedName

    /// <summary>
    /// This class represents the sex of a Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sex"></see></summary>
    let Sex = Namespaced_IRI.parse _namespace_name "Sex" |> NamespacedName
    /// <summary>
    /// This class represents a physical build type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Build"></see></summary>
    let Build = Namespaced_IRI.parse _namespace_name "Build" |> NamespacedName

    /// <summary>
    /// This class represents the physical description of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Description"></see></summary>
    let Description =
        Namespaced_IRI.parse _namespace_name "Description" |> NamespacedName

    /// <summary>
    /// This class represents the child stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Child"></see></summary>
    let Child = Namespaced_IRI.parse _namespace_name "Child" |> NamespacedName
    /// <summary>
    /// This class represents the young stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young"></see></summary>
    let Young = Namespaced_IRI.parse _namespace_name "Young" |> NamespacedName
    /// <summary>
    /// This class represents colours
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Colour"></see></summary>
    let Colour = Namespaced_IRI.parse _namespace_name "Colour" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is corporeal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Corporeal"></see></summary>
    let Corporeal = Namespaced_IRI.parse _namespace_name "Corporeal" |> NamespacedName

    /// <summary>
    /// This class represents the state of form of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Form"></see></summary>
    let ``State-Of-Form`` =
        Namespaced_IRI.parse _namespace_name "State-Of-Form" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which is incorporeal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Incorporeal"></see></summary>
    let Incorporeal =
        Namespaced_IRI.parse _namespace_name "Incorporeal" |> NamespacedName

    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#NonExistent"></see>
    /// </summary>
    let NonExistent =
        Namespaced_IRI.parse _namespace_name "NonExistent" |> NamespacedName

    /// <summary>
    /// This class represents a dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dimension"></see></summary>
    let Dimension = Namespaced_IRI.parse _namespace_name "Dimension" |> NamespacedName

    /// <summary>
    /// This class represents a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Distinguishing-Mark"></see></summary>
    let ``Distinguishing-Mark`` =
        Namespaced_IRI.parse _namespace_name "Distinguishing-Mark" |> NamespacedName

    /// <summary>
    /// This class describes an Entity whose consciousness is ecstatic
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ecstatic"></see></summary>
    let Ecstatic = Namespaced_IRI.parse _namespace_name "Ecstatic" |> NamespacedName
    /// <summary>
    /// This class represents the employment or other type of job undertaken by an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Employment"></see></summary>
    let Employment = Namespaced_IRI.parse _namespace_name "Employment" |> NamespacedName
    /// <summary>
    /// This class represents the ethnicity of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ethnicity"></see></summary>
    let Ethnicity = Namespaced_IRI.parse _namespace_name "Ethnicity" |> NamespacedName
    /// <summary>
    /// This class represents the religious or spiritual preference or preferences of a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Faith"></see></summary>
    let Faith = Namespaced_IRI.parse _namespace_name "Faith" |> NamespacedName
    /// <summary>
    /// This class represents the female gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Female"></see></summary>
    let Female = Namespaced_IRI.parse _namespace_name "Female" |> NamespacedName
    /// <summary>
    /// This class represents the gender of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gender"></see></summary>
    let Gender = Namespaced_IRI.parse _namespace_name "Gender" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is a gas
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gas"></see></summary>
    let Gas = Namespaced_IRI.parse _namespace_name "Gas" |> NamespacedName

    /// <summary>
    /// This class represents the genetic or chromosomal sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Genetic-Sex"></see></summary>
    let ``Genetic-Sex`` =
        Namespaced_IRI.parse _namespace_name "Genetic-Sex" |> NamespacedName

    /// <summary>
    /// This class represents the gonadal (reproductive system) sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gonadal-Sex"></see></summary>
    let ``Gonadal-Sex`` =
        Namespaced_IRI.parse _namespace_name "Gonadal-Sex" |> NamespacedName

    /// <summary>
    /// This class represents the sexual kinks or fetishes of a Character Entity. This is distinct from and in addition to a Character Entities' sexuality.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Kink"></see></summary>
    let Kink = Namespaced_IRI.parse _namespace_name "Kink" |> NamespacedName
    /// <summary>
    /// This class represents things known by an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Knowledge"></see></summary>
    let Knowledge = Namespaced_IRI.parse _namespace_name "Knowledge" |> NamespacedName
    /// <summary>
    /// This class represents links between this and other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Link"></see></summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is a liquid
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Liquid"></see></summary>
    let Liquid = Namespaced_IRI.parse _namespace_name "Liquid" |> NamespacedName
    /// <summary>
    /// This class represents the male gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Male"></see></summary>
    let Male = Namespaced_IRI.parse _namespace_name "Male" |> NamespacedName
    /// <summary>
    /// This class represents a type of material
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName
    /// <summary>
    /// This class represents the motivation of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Motivation"></see></summary>
    let Motivation = Namespaced_IRI.parse _namespace_name "Motivation" |> NamespacedName
    /// <summary>
    /// This class represents the name or equivilent designation of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Name"></see></summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName
    /// <summary>
    /// This class represents the neuter gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Neuter"></see></summary>
    let Neuter = Namespaced_IRI.parse _namespace_name "Neuter" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which does not exist
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Non-Existent"></see></summary>
    let ``Non-Existent`` =
        Namespaced_IRI.parse _namespace_name "Non-Existent" |> NamespacedName

    /// <summary>
    /// This class represents the old stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Old"></see></summary>
    let Old = Namespaced_IRI.parse _namespace_name "Old" |> NamespacedName
    /// <summary>
    /// This class represents an ordering of Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ordering"></see></summary>
    let Ordering = Namespaced_IRI.parse _namespace_name "Ordering" |> NamespacedName
    /// <summary>
    /// This class represents other genders
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Other"></see></summary>
    let Other = Namespaced_IRI.parse _namespace_name "Other" |> NamespacedName

    /// <summary>
    /// This class represents the phenotypic (body type/attributes) sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Phenotypic-Sex"></see></summary>
    let ``Phenotypic-Sex`` =
        Namespaced_IRI.parse _namespace_name "Phenotypic-Sex" |> NamespacedName

    /// <summary>
    /// This class represents a physical problem or obstacle
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Physical-Obstacle"></see></summary>
    let ``Physical-Obstacle`` =
        Namespaced_IRI.parse _namespace_name "Physical-Obstacle" |> NamespacedName

    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sexuality"></see></summary>
    let Sexuality = Namespaced_IRI.parse _namespace_name "Sexuality" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is a solid
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Solid"></see></summary>
    let Solid = Namespaced_IRI.parse _namespace_name "Solid" |> NamespacedName
    /// <summary>
    /// This class represents the species of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Species"></see></summary>
    let Species = Namespaced_IRI.parse _namespace_name "Species" |> NamespacedName
    /// <summary>
    /// This class represents a style type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Style"></see></summary>
    let Style = Namespaced_IRI.parse _namespace_name "Style" |> NamespacedName
    /// <summary>
    /// This class represents the teenage stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Teenager"></see></summary>
    let Teenager = Namespaced_IRI.parse _namespace_name "Teenager" |> NamespacedName
    /// <summary>
    /// This class represents having  a Character Entity with no sexual preference or preferences to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-None"></see></summary>
    let ``To-None`` = Namespaced_IRI.parse _namespace_name "To-None" |> NamespacedName

    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity to other Entities which have a different gender trait. This might not be exclusive.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Other-Gender"></see></summary>
    let ``To-Other-Gender`` =
        Namespaced_IRI.parse _namespace_name "To-Other-Gender" |> NamespacedName

    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity to other Entities which share the same gender trait. This might not be exclusive.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Same-Gender"></see></summary>
    let ``To-Same-Gender`` =
        Namespaced_IRI.parse _namespace_name "To-Same-Gender" |> NamespacedName

    /// <summary>
    /// This class represents a type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    /// This class describes an Entity which is unconscious
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unconscious"></see></summary>
    let Unconscious =
        Namespaced_IRI.parse _namespace_name "Unconscious" |> NamespacedName

    /// <summary>
    /// This class represents the pre-sexually active stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Virgin"></see></summary>
    let Virgin = Namespaced_IRI.parse _namespace_name "Virgin" |> NamespacedName
    /// <summary>
    /// This class describes an Entity which is a void
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Void"></see></summary>
    let Void = Namespaced_IRI.parse _namespace_name "Void" |> NamespacedName

    /// <summary>
    /// This class represents the young adult stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young-Adult"></see></summary>
    let ``Young-Adult`` =
        Namespaced_IRI.parse _namespace_name "Young-Adult" |> NamespacedName

    /// <summary>
    /// This property specifies the religion the entity has faith in.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#believes"></see></summary>
    let believes = Namespaced_IRI.parse _namespace_name "believes" |> NamespacedName
    /// <summary>
    /// This property specifies the age of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-age"></see></summary>
    let ``has-age`` = Namespaced_IRI.parse _namespace_name "has-age" |> NamespacedName

    /// <summary>
    /// This property specifies the date of birth or creation of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-birthday"></see></summary>
    let ``has-birthday`` =
        Namespaced_IRI.parse _namespace_name "has-birthday" |> NamespacedName

    /// <summary>
    /// This property specifies a bond which a character has
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-bond"></see></summary>
    let ``has-bond`` = Namespaced_IRI.parse _namespace_name "has-bond" |> NamespacedName

    /// <summary>
    /// This property specifies a description of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-description"></see></summary>
    let ``has-description`` =
        Namespaced_IRI.parse _namespace_name "has-description" |> NamespacedName

    /// <summary>
    /// This property specifies the dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-dimension"></see></summary>
    let ``has-dimension`` =
        Namespaced_IRI.parse _namespace_name "has-dimension" |> NamespacedName

    /// <summary>
    /// This property specifies a physical feature of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-feature"></see></summary>
    let ``has-feature`` =
        Namespaced_IRI.parse _namespace_name "has-feature" |> NamespacedName

    /// <summary>
    /// This property specifies the units for the dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-locspec-description"></see></summary>
    let ``has-locspec-description`` =
        Namespaced_IRI.parse _namespace_name "has-locspec-description" |> NamespacedName

    /// <summary>
    /// This property specifies an event whose occurrence is desired
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation"></see></summary>
    let ``has-motivation`` =
        Namespaced_IRI.parse _namespace_name "has-motivation" |> NamespacedName

    /// <summary>
    /// This property specifies an event whose occurrence is not wanted
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation-to-avoid"></see></summary>
    let ``has-motivation-to-avoid`` =
        Namespaced_IRI.parse _namespace_name "has-motivation-to-avoid" |> NamespacedName

    /// <summary>
    /// This property specifies the full name of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-name"></see></summary>
    let ``has-name`` = Namespaced_IRI.parse _namespace_name "has-name" |> NamespacedName

    /// <summary>
    /// This property specifies a profession which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-profession"></see></summary>
    let ``has-observed-profession`` =
        Namespaced_IRI.parse _namespace_name "has-observed-profession" |> NamespacedName

    /// <summary>
    /// This property specifies a trait which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-trait"></see></summary>
    let ``has-observed-trait`` =
        Namespaced_IRI.parse _namespace_name "has-observed-trait" |> NamespacedName

    /// <summary>
    /// This property specifies the order that the linked components go in
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-order"></see></summary>
    let ``has-order`` =
        Namespaced_IRI.parse _namespace_name "has-order" |> NamespacedName

    /// <summary>
    /// Priority of motivation
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-priority"></see></summary>
    let ``has-priority`` =
        Namespaced_IRI.parse _namespace_name "has-priority" |> NamespacedName

    /// <summary>
    /// This property specifies the profession of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-profession"></see></summary>
    let ``has-profession`` =
        Namespaced_IRI.parse _namespace_name "has-profession" |> NamespacedName

    /// <summary>
    /// This property specifies a profession which is projected by Entity to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-profession"></see></summary>
    let ``has-projected-profession`` =
        Namespaced_IRI.parse _namespace_name "has-projected-profession" |> NamespacedName

    /// <summary>
    /// This property specifies a trait which is projected by Entity to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-trait"></see></summary>
    let ``has-projected-trait`` =
        Namespaced_IRI.parse _namespace_name "has-projected-trait" |> NamespacedName

    /// <summary>
    /// This property specifies the sex chromosomes of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-sex-chromosomes"></see></summary>
    let ``has-sex-chromosomes`` =
        Namespaced_IRI.parse _namespace_name "has-sex-chromosomes" |> NamespacedName

    /// <summary>
    /// This property specifies a general trait which belongs to an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-trait"></see></summary>
    let ``has-trait`` =
        Namespaced_IRI.parse _namespace_name "has-trait" |> NamespacedName

    /// <summary>
    /// This property specifies the units for the dimension or value
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-unit"></see></summary>
    let ``has-unit`` = Namespaced_IRI.parse _namespace_name "has-unit" |> NamespacedName

    /// <summary>
    /// This property specifies a value of the property or entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-value"></see></summary>
    let ``has-value`` =
        Namespaced_IRI.parse _namespace_name "has-value" |> NamespacedName

    /// <summary>
    /// This property specifies the gender that a particular sex classification or attribute is identified with
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#identified-with"></see></summary>
    let ``identified-with`` =
        Namespaced_IRI.parse _namespace_name "identified-with" |> NamespacedName

    /// <summary>
    /// This property specifies something known by the character
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#knows"></see></summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName
    /// <summary>
    /// This property specifies the 'likes' of the Character. Has domain of To-Other-Gender but not To-Same-Gender because same gender implies a match whereas since there are three genders 'other' gender gives you a choice of possibles.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#likes"></see></summary>
    let likes = Namespaced_IRI.parse _namespace_name "likes" |> NamespacedName

    /// <summary>
    /// This property specifies the event at which the distinguishing mark of the entity was gained
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-gained"></see></summary>
    let ``mark-gained`` =
        Namespaced_IRI.parse _namespace_name "mark-gained" |> NamespacedName

    /// <summary>
    /// This property specifies the location of a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location"></see></summary>
    let ``mark-location`` =
        Namespaced_IRI.parse _namespace_name "mark-location" |> NamespacedName

    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-marking"></see>
    /// </summary>
    let ``has-marking`` =
        Namespaced_IRI.parse _namespace_name "has-marking" |> NamespacedName

    /// <summary>
    /// This property specifies the location of a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location-type"></see></summary>
    let ``mark-location-type`` =
        Namespaced_IRI.parse _namespace_name "mark-location-type" |> NamespacedName

    /// <summary>
    /// This property specifies the Entity or Entities at which the related trait is not projected at
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#not-projected-at"></see></summary>
    let ``not-projected-at`` =
        Namespaced_IRI.parse _namespace_name "not-projected-at" |> NamespacedName

    /// <summary>
    /// This property specifies the order of magnitude of the value. Useful list: http://chemistry.berkeley.edu/links/weights/powers.html
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#order_of_magnitude"></see></summary>
    let order_of_magnitude =
        Namespaced_IRI.parse _namespace_name "order_of_magnitude" |> NamespacedName

    /// <summary>
    /// This property specifies the Entity or Entities at which the related trait is projected at
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#projected-at"></see></summary>
    let ``projected-at`` =
        Namespaced_IRI.parse _namespace_name "projected-at" |> NamespacedName

    /// <summary>
    /// This property specifies a fetish of the Character
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#requires"></see></summary>
    let requires = Namespaced_IRI.parse _namespace_name "requires" |> NamespacedName

    /// <summary>
    /// This property specifies the entities for which the Entity is responsible for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for"></see></summary>
    let ``responsible-for`` =
        Namespaced_IRI.parse _namespace_name "responsible-for" |> NamespacedName

    /// <summary>
    /// This property specifies the types of entities for which the Entity is responsible for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for-type"></see></summary>
    let ``responsible-for-type`` =
        Namespaced_IRI.parse _namespace_name "responsible-for-type" |> NamespacedName
