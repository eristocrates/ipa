namespace http.contextus.net.ontology.ontomedia.ext.common._trait.hash

open DoxAletheia

module trait_ =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/ext/common/trait#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents a component part of an abstract item
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Component"></see></summary>
    let ``Abstract-Component`` = _prefix "Abstract-Component"
    /// <summary>
    /// This class represents the value of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Value"></see></summary>
    let Value = _prefix "Value"
    /// <summary>
    /// This class represents an abstract problem or obstacle
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Obstacle"></see></summary>
    let ``Abstract-Obstacle`` = _prefix "Abstract-Obstacle"
    /// <summary>
    /// This class represents the characteristics that describe an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Trait"></see></summary>
    let Trait = _prefix "Trait"
    /// <summary>
    /// This class represents the characteristics that describe a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Being-Trait"></see></summary>
    let ``Being-Trait`` = _prefix "Being-Trait"
    /// <summary>
    /// This class represents the adult stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Adult"></see></summary>
    let Adult = _prefix "Adult"
    /// <summary>
    /// This class represents the stage of life of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Stage-Of-Life"></see></summary>
    let ``Stage-Of-Life`` = _prefix "Stage-Of-Life"
    /// <summary>
    /// This class represents the age of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Age"></see></summary>
    let Age = _prefix "Age"
    /// <summary>
    /// This class describes an Entity which is alive
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Alive"></see></summary>
    let Alive = _prefix "Alive"
    /// <summary>
    /// This class represents the state of being of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Being"></see></summary>
    let ``State-Of-Being`` = _prefix "State-Of-Being"
    /// <summary>
    /// This class describes an Entity which is dead
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dead"></see></summary>
    let Dead = _prefix "Dead"
    /// <summary>
    /// This class describes an Entity which is undead
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Undead"></see></summary>
    let Undead = _prefix "Undead"
    /// <summary>
    /// This class describes an Entity those state of existance cannot be proved
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unprovable"></see></summary>
    let Unprovable = _prefix "Unprovable"
    /// <summary>
    /// This class describes an Entity which exists but is not, never was or never can be alive
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Inanimate"></see></summary>
    let Inanimate = _prefix "Inanimate"
    /// <summary>
    /// This class describes an Entity those state of existance is not unknown but is theoretically provable
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unknown"></see></summary>
    let Unknown = _prefix "Unknown"
    /// <summary>
    /// This class describes an Entity whose consciousness is not in its normal state
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Altered"></see></summary>
    let Altered = _prefix "Altered"
    /// <summary>
    /// This class represents the state of consciousness of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Consciousness"></see></summary>
    let ``State-Of-Consciousness`` = _prefix "State-Of-Consciousness"
    /// <summary>
    /// This class describes an Entity which is asleep
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Asleep"></see></summary>
    let Asleep = _prefix "Asleep"
    /// <summary>
    /// This class describes an Entity which is conscious
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Conscious"></see></summary>
    let Conscious = _prefix "Conscious"
    /// <summary>
    /// This class describes an Entity which is totally unresponsive to external stimuli i.e. coma
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unresponsive"></see></summary>
    let Unresponsive = _prefix "Unresponsive"
    /// <summary>
    /// This class describes an Entity that is working at a totally instinctual/subconscious level
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Instinctual"></see></summary>
    let Instinctual = _prefix "Instinctual"
    /// <summary>
    /// This class represents the behavioural or psychological sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Behavioural-Sex"></see></summary>
    let ``Behavioural-Sex`` = _prefix "Behavioural-Sex"
    /// <summary>
    /// This class represents the sex of a Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sex"></see></summary>
    let Sex = _prefix "Sex"
    /// <summary>
    /// This class represents a physical build type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Build"></see></summary>
    let Build = _prefix "Build"
    /// <summary>
    /// This class represents the physical description of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Description"></see></summary>
    let Description = _prefix "Description"
    /// <summary>
    /// This class represents the child stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Child"></see></summary>
    let Child = _prefix "Child"
    /// <summary>
    /// This class represents the young stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young"></see></summary>
    let Young = _prefix "Young"
    /// <summary>
    /// This class represents colours
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Colour"></see></summary>
    let Colour = _prefix "Colour"
    /// <summary>
    /// This class describes an Entity which is corporeal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Corporeal"></see></summary>
    let Corporeal = _prefix "Corporeal"
    /// <summary>
    /// This class represents the state of form of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Form"></see></summary>
    let ``State-Of-Form`` = _prefix "State-Of-Form"
    /// <summary>
    /// This class describes an Entity which is incorporeal
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Incorporeal"></see></summary>
    let Incorporeal = _prefix "Incorporeal"
    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#NonExistent"></see>
    /// </summary>
    let NonExistent = _prefix "NonExistent"
    /// <summary>
    /// This class represents a dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dimension"></see></summary>
    let Dimension = _prefix "Dimension"
    /// <summary>
    /// This class represents a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Distinguishing-Mark"></see></summary>
    let ``Distinguishing-Mark`` = _prefix "Distinguishing-Mark"
    /// <summary>
    /// This class describes an Entity whose consciousness is ecstatic
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ecstatic"></see></summary>
    let Ecstatic = _prefix "Ecstatic"
    /// <summary>
    /// This class represents the employment or other type of job undertaken by an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Employment"></see></summary>
    let Employment = _prefix "Employment"
    /// <summary>
    /// This class represents the ethnicity of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ethnicity"></see></summary>
    let Ethnicity = _prefix "Ethnicity"
    /// <summary>
    /// This class represents the religious or spiritual preference or preferences of a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Faith"></see></summary>
    let Faith = _prefix "Faith"
    /// <summary>
    /// This class represents the female gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Female"></see></summary>
    let Female = _prefix "Female"
    /// <summary>
    /// This class represents the gender of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gender"></see></summary>
    let Gender = _prefix "Gender"
    /// <summary>
    /// This class describes an Entity which is a gas
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gas"></see></summary>
    let Gas = _prefix "Gas"
    /// <summary>
    /// This class represents the genetic or chromosomal sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Genetic-Sex"></see></summary>
    let ``Genetic-Sex`` = _prefix "Genetic-Sex"
    /// <summary>
    /// This class represents the gonadal (reproductive system) sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gonadal-Sex"></see></summary>
    let ``Gonadal-Sex`` = _prefix "Gonadal-Sex"
    /// <summary>
    /// This class represents the sexual kinks or fetishes of a Character Entity. This is distinct from and in addition to a Character Entities' sexuality.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Kink"></see></summary>
    let Kink = _prefix "Kink"
    /// <summary>
    /// This class represents things known by an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Knowledge"></see></summary>
    let Knowledge = _prefix "Knowledge"
    /// <summary>
    /// This class represents links between this and other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// This class describes an Entity which is a liquid
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Liquid"></see></summary>
    let Liquid = _prefix "Liquid"
    /// <summary>
    /// This class represents the male gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Male"></see></summary>
    let Male = _prefix "Male"
    /// <summary>
    /// This class represents a type of material
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// This class represents the motivation of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Motivation"></see></summary>
    let Motivation = _prefix "Motivation"
    /// <summary>
    /// This class represents the name or equivilent designation of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Name"></see></summary>
    let Name = _prefix "Name"
    /// <summary>
    /// This class represents the neuter gender
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Neuter"></see></summary>
    let Neuter = _prefix "Neuter"
    /// <summary>
    /// This class describes an Entity which does not exist
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Non-Existent"></see></summary>
    let ``Non-Existent`` = _prefix "Non-Existent"
    /// <summary>
    /// This class represents the old stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Old"></see></summary>
    let Old = _prefix "Old"
    /// <summary>
    /// This class represents an ordering of Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ordering"></see></summary>
    let Ordering = _prefix "Ordering"
    /// <summary>
    /// This class represents other genders
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Other"></see></summary>
    let Other = _prefix "Other"
    /// <summary>
    /// This class represents the phenotypic (body type/attributes) sex of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Phenotypic-Sex"></see></summary>
    let ``Phenotypic-Sex`` = _prefix "Phenotypic-Sex"
    /// <summary>
    /// This class represents a physical problem or obstacle
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Physical-Obstacle"></see></summary>
    let ``Physical-Obstacle`` = _prefix "Physical-Obstacle"
    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sexuality"></see></summary>
    let Sexuality = _prefix "Sexuality"
    /// <summary>
    /// This class describes an Entity which is a solid
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Solid"></see></summary>
    let Solid = _prefix "Solid"
    /// <summary>
    /// This class represents the species of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Species"></see></summary>
    let Species = _prefix "Species"
    /// <summary>
    /// This class represents a style type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Style"></see></summary>
    let Style = _prefix "Style"
    /// <summary>
    /// This class represents the teenage stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Teenager"></see></summary>
    let Teenager = _prefix "Teenager"
    /// <summary>
    /// This class represents having  a Character Entity with no sexual preference or preferences to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-None"></see></summary>
    let ``To-None`` = _prefix "To-None"
    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity to other Entities which have a different gender trait. This might not be exclusive.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Other-Gender"></see></summary>
    let ``To-Other-Gender`` = _prefix "To-Other-Gender"
    /// <summary>
    /// This class represents the sexual preference or preferences of a Character Entity to other Entities which share the same gender trait. This might not be exclusive.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Same-Gender"></see></summary>
    let ``To-Same-Gender`` = _prefix "To-Same-Gender"
    /// <summary>
    /// This class represents a type
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// This class describes an Entity which is unconscious
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unconscious"></see></summary>
    let Unconscious = _prefix "Unconscious"
    /// <summary>
    /// This class represents the pre-sexually active stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Virgin"></see></summary>
    let Virgin = _prefix "Virgin"
    /// <summary>
    /// This class describes an Entity which is a void
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Void"></see></summary>
    let Void = _prefix "Void"
    /// <summary>
    /// This class represents the young adult stage of life of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young-Adult"></see></summary>
    let ``Young-Adult`` = _prefix "Young-Adult"
    /// <summary>
    /// This property specifies the religion the entity has faith in.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#believes"></see></summary>
    let believes = _prefix "believes"
    /// <summary>
    /// This property specifies the age of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-age"></see></summary>
    let ``has-age`` = _prefix "has-age"
    /// <summary>
    /// This property specifies the date of birth or creation of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-birthday"></see></summary>
    let ``has-birthday`` = _prefix "has-birthday"
    /// <summary>
    /// This property specifies a bond which a character has
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-bond"></see></summary>
    let ``has-bond`` = _prefix "has-bond"
    /// <summary>
    /// This property specifies a description of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-description"></see></summary>
    let ``has-description`` = _prefix "has-description"
    /// <summary>
    /// This property specifies the dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-dimension"></see></summary>
    let ``has-dimension`` = _prefix "has-dimension"
    /// <summary>
    /// This property specifies a physical feature of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-feature"></see></summary>
    let ``has-feature`` = _prefix "has-feature"
    /// <summary>
    /// This property specifies the units for the dimension
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-locspec-description"></see></summary>
    let ``has-locspec-description`` = _prefix "has-locspec-description"
    /// <summary>
    /// This property specifies an event whose occurrence is desired
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation"></see></summary>
    let ``has-motivation`` = _prefix "has-motivation"
    /// <summary>
    /// This property specifies an event whose occurrence is not wanted
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation-to-avoid"></see></summary>
    let ``has-motivation-to-avoid`` = _prefix "has-motivation-to-avoid"
    /// <summary>
    /// This property specifies the full name of the entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-name"></see></summary>
    let ``has-name`` = _prefix "has-name"
    /// <summary>
    /// This property specifies a profession which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-profession"></see></summary>
    let ``has-observed-profession`` = _prefix "has-observed-profession"
    /// <summary>
    /// This property specifies a trait which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-trait"></see></summary>
    let ``has-observed-trait`` = _prefix "has-observed-trait"
    /// <summary>
    /// This property specifies the order that the linked components go in
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-order"></see></summary>
    let ``has-order`` = _prefix "has-order"
    /// <summary>
    /// Priority of motivation
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-priority"></see></summary>
    let ``has-priority`` = _prefix "has-priority"
    /// <summary>
    /// This property specifies the profession of an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-profession"></see></summary>
    let ``has-profession`` = _prefix "has-profession"
    /// <summary>
    /// This property specifies a profession which is projected by Entity to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-profession"></see></summary>
    let ``has-projected-profession`` = _prefix "has-projected-profession"
    /// <summary>
    /// This property specifies a trait which is projected by Entity to other Entities
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-trait"></see></summary>
    let ``has-projected-trait`` = _prefix "has-projected-trait"
    /// <summary>
    /// This property specifies the sex chromosomes of an entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-sex-chromosomes"></see></summary>
    let ``has-sex-chromosomes`` = _prefix "has-sex-chromosomes"
    /// <summary>
    /// This property specifies a general trait which belongs to an Entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-trait"></see></summary>
    let ``has-trait`` = _prefix "has-trait"
    /// <summary>
    /// This property specifies the units for the dimension or value
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-unit"></see></summary>
    let ``has-unit`` = _prefix "has-unit"
    /// <summary>
    /// This property specifies a value of the property or entity
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-value"></see></summary>
    let ``has-value`` = _prefix "has-value"
    /// <summary>
    /// This property specifies the gender that a particular sex classification or attribute is identified with
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#identified-with"></see></summary>
    let ``identified-with`` = _prefix "identified-with"
    /// <summary>
    /// This property specifies something known by the character
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// This property specifies the 'likes' of the Character. Has domain of To-Other-Gender but not To-Same-Gender because same gender implies a match whereas since there are three genders 'other' gender gives you a choice of possibles.
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#likes"></see></summary>
    let likes = _prefix "likes"
    /// <summary>
    /// This property specifies the event at which the distinguishing mark of the entity was gained
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-gained"></see></summary>
    let ``mark-gained`` = _prefix "mark-gained"
    /// <summary>
    /// This property specifies the location of a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location"></see></summary>
    let ``mark-location`` = _prefix "mark-location"
    /// <summary>
    ///   <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-marking"></see>
    /// </summary>
    let ``has-marking`` = _prefix "has-marking"
    /// <summary>
    /// This property specifies the location of a distinguishing mark
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location-type"></see></summary>
    let ``mark-location-type`` = _prefix "mark-location-type"
    /// <summary>
    /// This property specifies the Entity or Entities at which the related trait is not projected at
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#not-projected-at"></see></summary>
    let ``not-projected-at`` = _prefix "not-projected-at"
    /// <summary>
    /// This property specifies the order of magnitude of the value. Useful list: http://chemistry.berkeley.edu/links/weights/powers.html
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#order_of_magnitude"></see></summary>
    let order_of_magnitude = _prefix "order_of_magnitude"
    /// <summary>
    /// This property specifies the Entity or Entities at which the related trait is projected at
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#projected-at"></see></summary>
    let ``projected-at`` = _prefix "projected-at"
    /// <summary>
    /// This property specifies a fetish of the Character
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#requires"></see></summary>
    let requires = _prefix "requires"
    /// <summary>
    /// This property specifies the entities for which the Entity is responsible for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for"></see></summary>
    let ``responsible-for`` = _prefix "responsible-for"
    /// <summary>
    /// This property specifies the types of entities for which the Entity is responsible for
    /// <see href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for-type"></see></summary>
    let ``responsible-for-type`` = _prefix "responsible-for-type"
