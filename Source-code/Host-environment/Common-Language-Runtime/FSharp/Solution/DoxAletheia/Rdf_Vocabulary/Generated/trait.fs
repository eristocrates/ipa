namespace http.contextus.net.ontology.ontomedia.ext.common._trait.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module trait_ =
    let _namespace_iri = Namespace_Iri trait_ |> NamespaceIRI
    /// <summary>
    ///   <para>trait:Trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the characteristics that describe an Entity</para>
    /// labels<para>Trait</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Trait">http://contextus.net/ontology/ontomedia/ext/common/trait#Trait</seealso>
    let Trait = Prefixed_Name(trait_, "Trait") |> PrefixedName
    /// <summary>
    ///   <para>trait:Being-Trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the characteristics that describe a Character Entity</para>
    /// labels<para>Character Trait</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Being-Trait">http://contextus.net/ontology/ontomedia/ext/common/trait#Being-Trait</seealso>
    let Being_Trait = Prefixed_Name(trait_, "Being-Trait") |> PrefixedName
    /// <summary>
    ///   <para>trait:State-Of-Being</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the state of being of an Entity</para>
    /// labels<para>State of Being</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Being">http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Being</seealso>
    let State_Of_Being = Prefixed_Name(trait_, "State-Of-Being") |> PrefixedName
    /// <summary>
    ///   <para>trait:Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity those state of existance is not unknown but is theoretically provable</para>
    /// labels<para>Unknown</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unknown">http://contextus.net/ontology/ontomedia/ext/common/trait#Unknown</seealso>
    let Unknown = Prefixed_Name(trait_, "Unknown") |> PrefixedName
    /// <summary>
    ///   <para>trait:Altered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity whose consciousness is not in its normal state</para>
    /// labels<para>Altered Consciousness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Altered">http://contextus.net/ontology/ontomedia/ext/common/trait#Altered</seealso>
    let Altered = Prefixed_Name(trait_, "Altered") |> PrefixedName
    /// <summary>
    ///   <para>trait:Knowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents things known by an Entity</para>
    /// labels<para>Knowledge</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Knowledge">http://contextus.net/ontology/ontomedia/ext/common/trait#Knowledge</seealso>
    let Knowledge = Prefixed_Name(trait_, "Knowledge") |> PrefixedName
    /// <summary>
    ///   <para>trait:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents links between this and other Entities</para>
    /// labels<para>Link</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Link">http://contextus.net/ontology/ontomedia/ext/common/trait#Link</seealso>
    let Link = Prefixed_Name(trait_, "Link") |> PrefixedName
    /// <summary>
    ///   <para>trait:Male</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the male gender</para>
    /// labels<para>Male</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Male">http://contextus.net/ontology/ontomedia/ext/common/trait#Male</seealso>
    let Male = Prefixed_Name(trait_, "Male") |> PrefixedName
    /// <summary>
    ///   <para>trait:Neuter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the neuter gender</para>
    /// labels<para>Neuter</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Neuter">http://contextus.net/ontology/ontomedia/ext/common/trait#Neuter</seealso>
    let Neuter = Prefixed_Name(trait_, "Neuter") |> PrefixedName
    /// <summary>
    ///   <para>trait:Ordering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an ordering of Entities</para>
    /// labels<para>Ordering</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ordering">http://contextus.net/ontology/ontomedia/ext/common/trait#Ordering</seealso>
    let Ordering = Prefixed_Name(trait_, "Ordering") |> PrefixedName
    /// <summary>
    ///   <para>trait:Sexuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sexual preference or preferences of a Character Entity</para>
    /// labels<para>Sexuality</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sexuality">http://contextus.net/ontology/ontomedia/ext/common/trait#Sexuality</seealso>
    let Sexuality = Prefixed_Name(trait_, "Sexuality") |> PrefixedName
    /// <summary>
    ///   <para>trait:Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is a solid</para>
    /// labels<para>Solid</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Solid">http://contextus.net/ontology/ontomedia/ext/common/trait#Solid</seealso>
    let Solid = Prefixed_Name(trait_, "Solid") |> PrefixedName
    /// <summary>
    ///   <para>trait:Style</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a style type</para>
    /// labels<para>Style</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Style">http://contextus.net/ontology/ontomedia/ext/common/trait#Style</seealso>
    let Style = Prefixed_Name(trait_, "Style") |> PrefixedName
    /// <summary>
    ///   <para>trait:Teenager</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the teenage stage of life of an entity</para>
    /// labels<para>Teenage</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Teenager">http://contextus.net/ontology/ontomedia/ext/common/trait#Teenager</seealso>
    let Teenager = Prefixed_Name(trait_, "Teenager") |> PrefixedName
    /// <summary>
    ///   <para>trait:To-None</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents having  a Character Entity with no sexual preference or preferences to other Entities</para>
    /// labels<para>To No Gender/Asexual</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-None">http://contextus.net/ontology/ontomedia/ext/common/trait#To-None</seealso>
    let To_None = Prefixed_Name(trait_, "To-None") |> PrefixedName
    /// <summary>
    ///   <para>trait:To-Other-Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sexual preference or preferences of a Character Entity to other Entities which have a different gender trait. This might not be exclusive.</para>
    /// labels<para>To Other Gender</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Other-Gender">http://contextus.net/ontology/ontomedia/ext/common/trait#To-Other-Gender</seealso>
    let To_Other_Gender = Prefixed_Name(trait_, "To-Other-Gender") |> PrefixedName
    /// <summary>
    ///   <para>trait:To-Same-Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sexual preference or preferences of a Character Entity to other Entities which share the same gender trait. This might not be exclusive.</para>
    /// labels<para>To Same Gender</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Same-Gender">http://contextus.net/ontology/ontomedia/ext/common/trait#To-Same-Gender</seealso>
    let To_Same_Gender = Prefixed_Name(trait_, "To-Same-Gender") |> PrefixedName
    /// <summary>
    ///   <para>trait:Unconscious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is unconscious</para>
    /// labels<para>Unconscious</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unconscious">http://contextus.net/ontology/ontomedia/ext/common/trait#Unconscious</seealso>
    let Unconscious = Prefixed_Name(trait_, "Unconscious") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-projected-profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a profession which is projected by Entity to other Entities</para>
    /// labels<para>Has Projected Profession</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-profession">http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-profession</seealso>
    let has_projected_profession =
        Prefixed_Name(trait_, "has-projected-profession") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-projected-trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a trait which is projected by Entity to other Entities</para>
    /// labels<para>Has Projected Trait</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-trait">http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-trait</seealso>
    let has_projected_trait =
        Prefixed_Name(trait_, "has-projected-trait") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the units for the dimension or value</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-unit">http://contextus.net/ontology/ontomedia/ext/common/trait#has-unit</seealso>
    let has_unit = Prefixed_Name(trait_, "has-unit") |> PrefixedName
    /// <summary>
    ///   <para>trait:identified-with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the gender that a particular sex classification or attribute is identified with</para>
    /// labels<para>Identified With</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#identified-with">http://contextus.net/ontology/ontomedia/ext/common/trait#identified-with</seealso>
    let identified_with = Prefixed_Name(trait_, "identified-with") |> PrefixedName
    /// <summary>
    ///   <para>trait:knows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies something known by the character</para>
    /// labels<para>Knows</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#knows">http://contextus.net/ontology/ontomedia/ext/common/trait#knows</seealso>
    let knows = Prefixed_Name(trait_, "knows") |> PrefixedName
    /// <summary>
    ///   <para>trait:likes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the 'likes' of the Character. Has domain of To-Other-Gender but not To-Same-Gender because same gender implies a match whereas since there are three genders 'other' gender gives you a choice of possibles.</para>
    /// labels<para>Likes</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#likes">http://contextus.net/ontology/ontomedia/ext/common/trait#likes</seealso>
    let likes = Prefixed_Name(trait_, "likes") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-marking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-marking">http://contextus.net/ontology/ontomedia/ext/common/trait#has-marking</seealso>
    let has_marking = Prefixed_Name(trait_, "has-marking") |> PrefixedName
    /// <summary>
    ///   <para>trait:mark-location-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the location of a distinguishing mark</para>
    /// labels<para>Mark Location</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location-type">http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location-type</seealso>
    let mark_location_type = Prefixed_Name(trait_, "mark-location-type") |> PrefixedName
    /// <summary>
    ///   <para>trait:not-projected-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the Entity or Entities at which the related trait is not projected at</para>
    /// labels<para>Not Projected At</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#not-projected-at">http://contextus.net/ontology/ontomedia/ext/common/trait#not-projected-at</seealso>
    let not_projected_at = Prefixed_Name(trait_, "not-projected-at") |> PrefixedName
    /// <summary>
    ///   <para>trait:projected-at</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the Entity or Entities at which the related trait is projected at</para>
    /// labels<para>Projected At</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#projected-at">http://contextus.net/ontology/ontomedia/ext/common/trait#projected-at</seealso>
    let projected_at = Prefixed_Name(trait_, "projected-at") |> PrefixedName
    /// <summary>
    ///   <para>trait:requires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a fetish of the Character</para>
    /// labels<para>Requires</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#requires">http://contextus.net/ontology/ontomedia/ext/common/trait#requires</seealso>
    let requires = Prefixed_Name(trait_, "requires") |> PrefixedName
    /// <summary>
    ///   <para>trait:responsible-for</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the entities for which the Entity is responsible for</para>
    /// labels<para>Responsible For</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for">http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for</seealso>
    let responsible_for = Prefixed_Name(trait_, "responsible-for") |> PrefixedName
    /// <summary>
    ///   <para>trait:Abstract-Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a component part of an abstract item</para>
    /// labels<para>Abstract Component</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Component">http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Component</seealso>
    let Abstract_Component = Prefixed_Name(trait_, "Abstract-Component") |> PrefixedName
    /// <summary>
    ///   <para>trait:Stage-Of-Life</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the stage of life of an Entity</para>
    /// labels<para>Stage of Life</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Stage-Of-Life">http://contextus.net/ontology/ontomedia/ext/common/trait#Stage-Of-Life</seealso>
    let Stage_Of_Life = Prefixed_Name(trait_, "Stage-Of-Life") |> PrefixedName
    /// <summary>
    ///   <para>trait:Alive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is alive</para>
    /// labels<para>Living</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Alive">http://contextus.net/ontology/ontomedia/ext/common/trait#Alive</seealso>
    let Alive = Prefixed_Name(trait_, "Alive") |> PrefixedName

    /// <summary>
    ///   <para>trait:State-Of-Consciousness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the state of consciousness of an Entity</para>
    /// labels<para>State of Consciousness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Consciousness">http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Consciousness</seealso>
    let State_Of_Consciousness =
        Prefixed_Name(trait_, "State-Of-Consciousness") |> PrefixedName

    /// <summary>
    ///   <para>trait:Asleep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is asleep</para>
    /// labels<para>Asleep</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Asleep">http://contextus.net/ontology/ontomedia/ext/common/trait#Asleep</seealso>
    let Asleep = Prefixed_Name(trait_, "Asleep") |> PrefixedName
    /// <summary>
    ///   <para>trait:Instinctual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity that is working at a totally instinctual/subconscious level</para>
    /// labels<para>Instinctual/Subconscious</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Instinctual">http://contextus.net/ontology/ontomedia/ext/common/trait#Instinctual</seealso>
    let Instinctual = Prefixed_Name(trait_, "Instinctual") |> PrefixedName
    /// <summary>
    ///   <para>trait:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sex of a Entity</para>
    /// labels<para>Sex</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sex">http://contextus.net/ontology/ontomedia/ext/common/trait#Sex</seealso>
    let Sex = Prefixed_Name(trait_, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>trait:Young</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the young stage of life of an entity</para>
    /// labels<para>Young</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young">http://contextus.net/ontology/ontomedia/ext/common/trait#Young</seealso>
    let Young = Prefixed_Name(trait_, "Young") |> PrefixedName
    /// <summary>
    ///   <para>trait:Colour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents colours</para>
    /// labels<para>Colour</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Colour">http://contextus.net/ontology/ontomedia/ext/common/trait#Colour</seealso>
    let Colour = Prefixed_Name(trait_, "Colour") |> PrefixedName
    /// <summary>
    ///   <para>trait:Corporeal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is corporeal</para>
    /// labels<para>Corporeal</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Corporeal">http://contextus.net/ontology/ontomedia/ext/common/trait#Corporeal</seealso>
    let Corporeal = Prefixed_Name(trait_, "Corporeal") |> PrefixedName
    /// <summary>
    ///   <para>trait:Dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a dimension</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dimension">http://contextus.net/ontology/ontomedia/ext/common/trait#Dimension</seealso>
    let Dimension = Prefixed_Name(trait_, "Dimension") |> PrefixedName
    /// <summary>
    ///   <para>trait:Employment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the employment or other type of job undertaken by an Entity</para>
    /// labels<para>Employment</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Employment">http://contextus.net/ontology/ontomedia/ext/common/trait#Employment</seealso>
    let Employment = Prefixed_Name(trait_, "Employment") |> PrefixedName
    /// <summary>
    ///   <para>trait:Female</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the female gender</para>
    /// labels<para>Female</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Female">http://contextus.net/ontology/ontomedia/ext/common/trait#Female</seealso>
    let Female = Prefixed_Name(trait_, "Female") |> PrefixedName
    /// <summary>
    ///   <para>trait:Genetic-Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the genetic or chromosomal sex of an entity</para>
    /// labels<para>Genetic Sex</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Genetic-Sex">http://contextus.net/ontology/ontomedia/ext/common/trait#Genetic-Sex</seealso>
    let Genetic_Sex = Prefixed_Name(trait_, "Genetic-Sex") |> PrefixedName
    /// <summary>
    ///   <para>trait:Gonadal-Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the gonadal (reproductive system) sex of an entity</para>
    /// labels<para>Gonadal Sex</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gonadal-Sex">http://contextus.net/ontology/ontomedia/ext/common/trait#Gonadal-Sex</seealso>
    let Gonadal_Sex = Prefixed_Name(trait_, "Gonadal-Sex") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a value of the property or entity</para>
    /// labels<para>Has Value</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-value">http://contextus.net/ontology/ontomedia/ext/common/trait#has-value</seealso>
    let has_value = Prefixed_Name(trait_, "has-value") |> PrefixedName
    /// <summary>
    ///   <para>trait:mark-gained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the event at which the distinguishing mark of the entity was gained</para>
    /// labels<para>Mark Gained</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-gained">http://contextus.net/ontology/ontomedia/ext/common/trait#mark-gained</seealso>
    let mark_gained = Prefixed_Name(trait_, "mark-gained") |> PrefixedName
    /// <summary>
    ///   <para>trait:mark-location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the location of a distinguishing mark</para>
    /// labels<para>Mark Location</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location">http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location</seealso>
    let mark_location = Prefixed_Name(trait_, "mark-location") |> PrefixedName
    /// <summary>
    ///   <para>trait:Adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the adult stage of life of an entity</para>
    /// labels<para>Adult</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Adult">http://contextus.net/ontology/ontomedia/ext/common/trait#Adult</seealso>
    let Adult = Prefixed_Name(trait_, "Adult") |> PrefixedName
    /// <summary>
    ///   <para>trait:Undead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is undead</para>
    /// labels<para>Undead</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Undead">http://contextus.net/ontology/ontomedia/ext/common/trait#Undead</seealso>
    let Undead = Prefixed_Name(trait_, "Undead") |> PrefixedName
    /// <summary>
    ///   <para>trait:Conscious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is conscious</para>
    /// labels<para>Conscious</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Conscious">http://contextus.net/ontology/ontomedia/ext/common/trait#Conscious</seealso>
    let Conscious = Prefixed_Name(trait_, "Conscious") |> PrefixedName
    /// <summary>
    ///   <para>trait:Behavioural-Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the behavioural or psychological sex of an entity</para>
    /// labels<para>Behavioural Sex</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Behavioural-Sex">http://contextus.net/ontology/ontomedia/ext/common/trait#Behavioural-Sex</seealso>
    let Behavioural_Sex = Prefixed_Name(trait_, "Behavioural-Sex") |> PrefixedName
    /// <summary>
    ///   <para>trait:Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the physical description of an Entity</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Description">http://contextus.net/ontology/ontomedia/ext/common/trait#Description</seealso>
    let Description = Prefixed_Name(trait_, "Description") |> PrefixedName
    /// <summary>
    ///   <para>trait:Child</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the child stage of life of an entity</para>
    /// labels<para>Child</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Child">http://contextus.net/ontology/ontomedia/ext/common/trait#Child</seealso>
    let Child = Prefixed_Name(trait_, "Child") |> PrefixedName
    /// <summary>
    ///   <para>trait:NonExistent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#NonExistent">http://contextus.net/ontology/ontomedia/ext/common/trait#NonExistent</seealso>
    let NonExistent = Prefixed_Name(trait_, "NonExistent") |> PrefixedName

    /// <summary>
    ///   <para>trait:Distinguishing-Mark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a distinguishing mark</para>
    /// labels<para>Distinguishing Mark</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Distinguishing-Mark">http://contextus.net/ontology/ontomedia/ext/common/trait#Distinguishing-Mark</seealso>
    let Distinguishing_Mark =
        Prefixed_Name(trait_, "Distinguishing-Mark") |> PrefixedName

    /// <summary>
    ///   <para>trait:Ecstatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity whose consciousness is ecstatic</para>
    /// labels<para>Ecstatic Consciousness</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ecstatic">http://contextus.net/ontology/ontomedia/ext/common/trait#Ecstatic</seealso>
    let Ecstatic = Prefixed_Name(trait_, "Ecstatic") |> PrefixedName
    /// <summary>
    ///   <para>trait:Faith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the religious or spiritual preference or preferences of a Character Entity</para>
    /// labels<para>Faith</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Faith">http://contextus.net/ontology/ontomedia/ext/common/trait#Faith</seealso>
    let Faith = Prefixed_Name(trait_, "Faith") |> PrefixedName
    /// <summary>
    ///   <para>trait:Gender</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the gender of an Entity</para>
    /// labels<para>Gender</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gender">http://contextus.net/ontology/ontomedia/ext/common/trait#Gender</seealso>
    let Gender = Prefixed_Name(trait_, "Gender") |> PrefixedName
    /// <summary>
    ///   <para>trait:Gas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is a gas</para>
    /// labels<para>Gas</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gas">http://contextus.net/ontology/ontomedia/ext/common/trait#Gas</seealso>
    let Gas = Prefixed_Name(trait_, "Gas") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-sex-chromosomes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the sex chromosomes of an entity</para>
    /// labels<para>Has Sex Chromosomes</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-sex-chromosomes">http://contextus.net/ontology/ontomedia/ext/common/trait#has-sex-chromosomes</seealso>
    let has_sex_chromosomes =
        Prefixed_Name(trait_, "has-sex-chromosomes") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a general trait which belongs to an Entity</para>
    /// labels<para>Has Trait</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-trait">http://contextus.net/ontology/ontomedia/ext/common/trait#has-trait</seealso>
    let has_trait = Prefixed_Name(trait_, "has-trait") |> PrefixedName
    /// <summary>
    ///   <para>trait:Dead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is dead</para>
    /// labels<para>Dead</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dead">http://contextus.net/ontology/ontomedia/ext/common/trait#Dead</seealso>
    let Dead = Prefixed_Name(trait_, "Dead") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the profession of an Entity</para>
    /// labels<para>Has Profession</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-profession">http://contextus.net/ontology/ontomedia/ext/common/trait#has-profession</seealso>
    let has_profession = Prefixed_Name(trait_, "has-profession") |> PrefixedName
    /// <summary>
    ///   <para>trait:Incorporeal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is incorporeal</para>
    /// labels<para>Incorporeal</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Incorporeal">http://contextus.net/ontology/ontomedia/ext/common/trait#Incorporeal</seealso>
    let Incorporeal = Prefixed_Name(trait_, "Incorporeal") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the full name of the entity</para>
    /// labels<para>Given Name</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-name">http://contextus.net/ontology/ontomedia/ext/common/trait#has-name</seealso>
    let has_name = Prefixed_Name(trait_, "has-name") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-order</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the order that the linked components go in</para>
    /// labels<para>Has Order</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-order">http://contextus.net/ontology/ontomedia/ext/common/trait#has-order</seealso>
    let has_order = Prefixed_Name(trait_, "has-order") |> PrefixedName
    /// <summary>
    ///   <para>trait:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a type</para>
    /// labels<para>Type</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Type">http://contextus.net/ontology/ontomedia/ext/common/trait#Type</seealso>
    let Type = Prefixed_Name(trait_, "Type") |> PrefixedName
    /// <summary>
    ///   <para>trait:Virgin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the pre-sexually active stage of life of an entity</para>
    /// labels<para>Virgin</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Virgin">http://contextus.net/ontology/ontomedia/ext/common/trait#Virgin</seealso>
    let Virgin = Prefixed_Name(trait_, "Virgin") |> PrefixedName
    /// <summary>
    ///   <para>trait:Young-Adult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the young adult stage of life of an entity</para>
    /// labels<para>Young Adult</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young-Adult">http://contextus.net/ontology/ontomedia/ext/common/trait#Young-Adult</seealso>
    let Young_Adult = Prefixed_Name(trait_, "Young-Adult") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-bond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a bond which a character has</para>
    /// labels<para>Has Bond</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-bond">http://contextus.net/ontology/ontomedia/ext/common/trait#has-bond</seealso>
    let has_bond = Prefixed_Name(trait_, "has-bond") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-dimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the dimension</para>
    /// labels<para>Dimension</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-dimension">http://contextus.net/ontology/ontomedia/ext/common/trait#has-dimension</seealso>
    let has_dimension = Prefixed_Name(trait_, "has-dimension") |> PrefixedName
    /// <summary>
    ///   <para>trait:order_of_magnitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the order of magnitude of the value. Useful list: http://chemistry.berkeley.edu/links/weights/powers.html</para>
    /// labels<para>Order of Magnitude</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#order_of_magnitude">http://contextus.net/ontology/ontomedia/ext/common/trait#order_of_magnitude</seealso>
    let order_of_magnitude = Prefixed_Name(trait_, "order_of_magnitude") |> PrefixedName

    /// <summary>
    ///   <para>trait:responsible-for-type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the types of entities for which the Entity is responsible for</para>
    /// labels<para>Responsible For Type</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for-type">http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for-type</seealso>
    let responsible_for_type =
        Prefixed_Name(trait_, "responsible-for-type") |> PrefixedName

    /// <summary>
    ///   <para>trait:Ethnicity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the ethnicity of an Entity</para>
    /// labels<para>Ethnicity</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ethnicity">http://contextus.net/ontology/ontomedia/ext/common/trait#Ethnicity</seealso>
    let Ethnicity = Prefixed_Name(trait_, "Ethnicity") |> PrefixedName
    /// <summary>
    ///   <para>trait:Kink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the sexual kinks or fetishes of a Character Entity. This is distinct from and in addition to a Character Entities' sexuality.</para>
    /// labels<para>Kink</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Kink">http://contextus.net/ontology/ontomedia/ext/common/trait#Kink</seealso>
    let Kink = Prefixed_Name(trait_, "Kink") |> PrefixedName
    /// <summary>
    ///   <para>trait:Liquid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is a liquid</para>
    /// labels<para>Liquid</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Liquid">http://contextus.net/ontology/ontomedia/ext/common/trait#Liquid</seealso>
    let Liquid = Prefixed_Name(trait_, "Liquid") |> PrefixedName
    /// <summary>
    ///   <para>trait:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a type of material</para>
    /// labels<para>Material</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Material">http://contextus.net/ontology/ontomedia/ext/common/trait#Material</seealso>
    let Material = Prefixed_Name(trait_, "Material") |> PrefixedName
    /// <summary>
    ///   <para>trait:Motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the motivation of an Entity</para>
    /// labels<para>Motivation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Motivation">http://contextus.net/ontology/ontomedia/ext/common/trait#Motivation</seealso>
    let Motivation = Prefixed_Name(trait_, "Motivation") |> PrefixedName
    /// <summary>
    ///   <para>trait:Non-Existent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which does not exist</para>
    /// labels<para>Non-Existent</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Non-Existent">http://contextus.net/ontology/ontomedia/ext/common/trait#Non-Existent</seealso>
    let Non_Existent = Prefixed_Name(trait_, "Non-Existent") |> PrefixedName
    /// <summary>
    ///   <para>trait:Old</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the old stage of life of an entity</para>
    /// labels<para>Old</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Old">http://contextus.net/ontology/ontomedia/ext/common/trait#Old</seealso>
    let Old = Prefixed_Name(trait_, "Old") |> PrefixedName
    /// <summary>
    ///   <para>trait:Phenotypic-Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the phenotypic (body type/attributes) sex of an entity</para>
    /// labels<para>Phenotypic Sex</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Phenotypic-Sex">http://contextus.net/ontology/ontomedia/ext/common/trait#Phenotypic-Sex</seealso>
    let Phenotypic_Sex = Prefixed_Name(trait_, "Phenotypic-Sex") |> PrefixedName
    /// <summary>
    ///   <para>trait:Physical-Obstacle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a physical problem or obstacle</para>
    /// labels<para>Physical Obstacle</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Physical-Obstacle">http://contextus.net/ontology/ontomedia/ext/common/trait#Physical-Obstacle</seealso>
    let Physical_Obstacle = Prefixed_Name(trait_, "Physical-Obstacle") |> PrefixedName
    /// <summary>
    ///   <para>trait:Species</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the species of an Entity</para>
    /// labels<para>Species</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Species">http://contextus.net/ontology/ontomedia/ext/common/trait#Species</seealso>
    let Species = Prefixed_Name(trait_, "Species") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a description of the entity</para>
    /// labels<para>Has Description</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-description">http://contextus.net/ontology/ontomedia/ext/common/trait#has-description</seealso>
    let has_description = Prefixed_Name(trait_, "has-description") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a physical feature of the entity</para>
    /// labels<para>Has Feature</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-feature">http://contextus.net/ontology/ontomedia/ext/common/trait#has-feature</seealso>
    let has_feature = Prefixed_Name(trait_, "has-feature") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-locspec-description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the units for the dimension</para>
    /// labels<para>Unit</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-locspec-description">http://contextus.net/ontology/ontomedia/ext/common/trait#has-locspec-description</seealso>
    let has_locspec_description =
        Prefixed_Name(trait_, "has-locspec-description") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an event whose occurrence is desired</para>
    /// labels<para>Has Motivation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation">http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation</seealso>
    let has_motivation = Prefixed_Name(trait_, "has-motivation") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-motivation-to-avoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an event whose occurrence is not wanted</para>
    /// labels<para>Has Motivation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation-to-avoid">http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation-to-avoid</seealso>
    let has_motivation_to_avoid =
        Prefixed_Name(trait_, "has-motivation-to-avoid") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-observed-profession</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a profession which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows</para>
    /// labels<para>Has Observed Profession</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-profession">http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-profession</seealso>
    let has_observed_profession =
        Prefixed_Name(trait_, "has-observed-profession") |> PrefixedName

    /// <summary>
    ///   <para>trait:has-observed-trait</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a trait which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows</para>
    /// labels<para>Has Observed Trait</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-trait">http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-trait</seealso>
    let has_observed_trait = Prefixed_Name(trait_, "has-observed-trait") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Priority of motivation</para>
    /// </remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-priority">http://contextus.net/ontology/ontomedia/ext/common/trait#has-priority</seealso>
    let has_priority = Prefixed_Name(trait_, "has-priority") |> PrefixedName
    /// <summary>
    ///   <para>trait:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>OntoMedia Trait Representation</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#">http://contextus.net/ontology/ontomedia/ext/common/trait#</seealso>
    let _prefix_iri = Prefixed_Name(trait_, "") |> PrefixedName
    /// <summary>
    ///   <para>trait:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the value of an Entity</para>
    /// labels<para>Value</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Value">http://contextus.net/ontology/ontomedia/ext/common/trait#Value</seealso>
    let Value = Prefixed_Name(trait_, "Value") |> PrefixedName
    /// <summary>
    ///   <para>trait:Abstract-Obstacle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents an abstract problem or obstacle</para>
    /// labels<para>Abstract Obstacle</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Obstacle">http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Obstacle</seealso>
    let Abstract_Obstacle = Prefixed_Name(trait_, "Abstract-Obstacle") |> PrefixedName
    /// <summary>
    ///   <para>trait:Age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the age of an Entity</para>
    /// labels<para>Age</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Age">http://contextus.net/ontology/ontomedia/ext/common/trait#Age</seealso>
    let Age = Prefixed_Name(trait_, "Age") |> PrefixedName
    /// <summary>
    ///   <para>trait:Unprovable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity those state of existance cannot be proved</para>
    /// labels<para>Unprovable</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unprovable">http://contextus.net/ontology/ontomedia/ext/common/trait#Unprovable</seealso>
    let Unprovable = Prefixed_Name(trait_, "Unprovable") |> PrefixedName
    /// <summary>
    ///   <para>trait:Inanimate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which exists but is not, never was or never can be alive</para>
    /// labels<para>Inanimate</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Inanimate">http://contextus.net/ontology/ontomedia/ext/common/trait#Inanimate</seealso>
    let Inanimate = Prefixed_Name(trait_, "Inanimate") |> PrefixedName
    /// <summary>
    ///   <para>trait:Unresponsive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is totally unresponsive to external stimuli i.e. coma</para>
    /// labels<para>Unresponsive</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unresponsive">http://contextus.net/ontology/ontomedia/ext/common/trait#Unresponsive</seealso>
    let Unresponsive = Prefixed_Name(trait_, "Unresponsive") |> PrefixedName
    /// <summary>
    ///   <para>trait:Build</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents a physical build type</para>
    /// labels<para>Build</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Build">http://contextus.net/ontology/ontomedia/ext/common/trait#Build</seealso>
    let Build = Prefixed_Name(trait_, "Build") |> PrefixedName
    /// <summary>
    ///   <para>trait:State-Of-Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the state of form of an Entity</para>
    /// labels<para>State of Form</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Form">http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Form</seealso>
    let State_Of_Form = Prefixed_Name(trait_, "State-Of-Form") |> PrefixedName
    /// <summary>
    ///   <para>trait:Name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the name or equivilent designation of an Entity</para>
    /// labels<para>Name</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Name">http://contextus.net/ontology/ontomedia/ext/common/trait#Name</seealso>
    let Name = Prefixed_Name(trait_, "Name") |> PrefixedName
    /// <summary>
    ///   <para>trait:Other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents other genders</para>
    /// labels<para>Other</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Other">http://contextus.net/ontology/ontomedia/ext/common/trait#Other</seealso>
    let Other = Prefixed_Name(trait_, "Other") |> PrefixedName
    /// <summary>
    ///   <para>trait:Void</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class describes an Entity which is a void</para>
    /// labels<para>Void</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#Void">http://contextus.net/ontology/ontomedia/ext/common/trait#Void</seealso>
    let Void = Prefixed_Name(trait_, "Void") |> PrefixedName
    /// <summary>
    ///   <para>trait:believes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies the religion the entity has faith in.</para>
    /// labels<para>Believes</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#believes">http://contextus.net/ontology/ontomedia/ext/common/trait#believes</seealso>
    let believes = Prefixed_Name(trait_, "believes") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-age</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the age of the entity</para>
    /// labels<para>Age</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-age">http://contextus.net/ontology/ontomedia/ext/common/trait#has-age</seealso>
    let has_age = Prefixed_Name(trait_, "has-age") |> PrefixedName
    /// <summary>
    ///   <para>trait:has-birthday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This property specifies the date of birth or creation of the entity</para>
    /// labels<para>Birthday</para></remarks>
    /// <seealso href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-birthday">http://contextus.net/ontology/ontomedia/ext/common/trait#has-birthday</seealso>
    let has_birthday = Prefixed_Name(trait_, "has-birthday") |> PrefixedName
