#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module trait =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/ext/common/trait#" "trait"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : This class represents a component part of an abstract item^^xsd:string</para>
    ///   <para>rdfs:label : Abstract Component^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Component">trait:Abstract-Component</a>
    /// </summary>
    let Abstract_Component = _prefixId.prefix "Abstract-Component"
    /// <summary>
    ///   <para>rdfs:comment : This class represents an abstract problem or obstacle^^xsd:string</para>
    ///   <para>rdfs:label : Abstract Obstacle^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Abstract-Obstacle">trait:Abstract-Obstacle</a>
    /// </summary>
    let Abstract_Obstacle = _prefixId.prefix "Abstract-Obstacle"
    /// <summary>
    ///   <para>rdfs:label : Adult^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the adult stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Adult">trait:Adult</a>
    /// </summary>
    let Adult = _prefixId.prefix "Adult"
    /// <summary>
    ///   <para>rdfs:label : Age^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the age of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Age">trait:Age</a>
    /// </summary>
    let Age = _prefixId.prefix "Age"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity which is alive^^xsd:string</para>
    ///   <para>rdfs:label : Living^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Alive">trait:Alive</a>
    /// </summary>
    let Alive = _prefixId.prefix "Alive"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity whose consciousness is not in its normal state^^xsd:string</para>
    ///   <para>rdfs:label : Altered Consciousness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Altered">trait:Altered</a>
    /// </summary>
    let Altered = _prefixId.prefix "Altered"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity which is asleep^^xsd:string</para>
    ///   <para>rdfs:label : Asleep^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Asleep">trait:Asleep</a>
    /// </summary>
    let Asleep = _prefixId.prefix "Asleep"
    /// <summary>
    ///   <para>rdfs:label : Behavioural Sex^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the behavioural or psychological sex of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Behavioural-Sex">trait:Behavioural-Sex</a>
    /// </summary>
    let Behavioural_Sex = _prefixId.prefix "Behavioural-Sex"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the characteristics that describe a Character Entity^^xsd:string</para>
    ///   <para>rdfs:label : Character Trait^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Being-Trait">trait:Being-Trait</a>
    /// </summary>
    let Being_Trait = _prefixId.prefix "Being-Trait"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a physical build type^^xsd:string</para>
    ///   <para>rdfs:label : Build^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Build">trait:Build</a>
    /// </summary>
    let Build = _prefixId.prefix "Build"
    /// <summary>
    ///   <para>rdfs:label : Child^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the child stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Child">trait:Child</a>
    /// </summary>
    let Child = _prefixId.prefix "Child"
    /// <summary>
    ///   <para>rdfs:comment : This class represents colours^^xsd:string</para>
    ///   <para>rdfs:label : Colour^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Colour">trait:Colour</a>
    /// </summary>
    let Colour = _prefixId.prefix "Colour"
    /// <summary>
    ///   <para>rdfs:label : Conscious^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is conscious^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Conscious">trait:Conscious</a>
    /// </summary>
    let Conscious = _prefixId.prefix "Conscious"
    /// <summary>
    ///   <para>rdfs:label : Corporeal^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is corporeal^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Corporeal">trait:Corporeal</a>
    /// </summary>
    let Corporeal = _prefixId.prefix "Corporeal"
    /// <summary>
    ///   <para>rdfs:label : Dead^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is dead^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dead">trait:Dead</a>
    /// </summary>
    let Dead = _prefixId.prefix "Dead"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the physical description of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Description">trait:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    /// <summary>
    ///   <para>rdfs:label : Dimension^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a dimension^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Dimension">trait:Dimension</a>
    /// </summary>
    let Dimension = _prefixId.prefix "Dimension"
    /// <summary>
    ///   <para>rdfs:label : Distinguishing Mark^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a distinguishing mark^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Distinguishing-Mark">trait:Distinguishing-Mark</a>
    /// </summary>
    let Distinguishing_Mark = _prefixId.prefix "Distinguishing-Mark"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity whose consciousness is ecstatic^^xsd:string</para>
    ///   <para>rdfs:label : Ecstatic Consciousness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ecstatic">trait:Ecstatic</a>
    /// </summary>
    let Ecstatic = _prefixId.prefix "Ecstatic"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the employment or other type of job undertaken by an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Employment^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Employment">trait:Employment</a>
    /// </summary>
    let Employment = _prefixId.prefix "Employment"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the ethnicity of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Ethnicity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ethnicity">trait:Ethnicity</a>
    /// </summary>
    let Ethnicity = _prefixId.prefix "Ethnicity"
    /// <summary>
    ///   <para>rdfs:label : Faith^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the religious or spiritual preference or preferences of a Character Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Faith">trait:Faith</a>
    /// </summary>
    let Faith = _prefixId.prefix "Faith"
    /// <summary>
    ///   <para>rdfs:label : Female^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the female gender^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Female">trait:Female</a>
    /// </summary>
    let Female = _prefixId.prefix "Female"
    /// <summary>
    ///   <para>rdfs:label : Gas^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is a gas^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gas">trait:Gas</a>
    /// </summary>
    let Gas = _prefixId.prefix "Gas"
    /// <summary>
    ///   <para>rdfs:label : Gender^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the gender of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gender">trait:Gender</a>
    /// </summary>
    let Gender = _prefixId.prefix "Gender"
    /// <summary>
    ///   <para>rdfs:label : Genetic Sex^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the genetic or chromosomal sex of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Genetic-Sex">trait:Genetic-Sex</a>
    /// </summary>
    let Genetic_Sex = _prefixId.prefix "Genetic-Sex"
    /// <summary>
    ///   <para>rdfs:label : Gonadal Sex^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the gonadal (reproductive system) sex of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Gonadal-Sex">trait:Gonadal-Sex</a>
    /// </summary>
    let Gonadal_Sex = _prefixId.prefix "Gonadal-Sex"
    /// <summary>
    ///   <para>rdfs:label : Inanimate^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which exists but is not, never was or never can be alive^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Inanimate">trait:Inanimate</a>
    /// </summary>
    let Inanimate = _prefixId.prefix "Inanimate"
    /// <summary>
    ///   <para>rdfs:label : Incorporeal^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is incorporeal^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Incorporeal">trait:Incorporeal</a>
    /// </summary>
    let Incorporeal = _prefixId.prefix "Incorporeal"
    /// <summary>
    ///   <para>rdfs:label : Instinctual/Subconscious^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity that is working at a totally instinctual/subconscious level^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Instinctual">trait:Instinctual</a>
    /// </summary>
    let Instinctual = _prefixId.prefix "Instinctual"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the sexual kinks or fetishes of a Character Entity. This is distinct from and in addition to a Character Entities' sexuality.^^xsd:string</para>
    ///   <para>rdfs:label : Kink^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Kink">trait:Kink</a>
    /// </summary>
    let Kink = _prefixId.prefix "Kink"
    /// <summary>
    ///   <para>rdfs:comment : This class represents things known by an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Knowledge^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Knowledge">trait:Knowledge</a>
    /// </summary>
    let Knowledge = _prefixId.prefix "Knowledge"
    /// <summary>
    ///   <para>rdfs:comment : This class represents links between this and other Entities^^xsd:string</para>
    ///   <para>rdfs:label : Link^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Link">trait:Link</a>
    /// </summary>
    let Link = _prefixId.prefix "Link"
    /// <summary>
    ///   <para>rdfs:label : Liquid^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is a liquid^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Liquid">trait:Liquid</a>
    /// </summary>
    let Liquid = _prefixId.prefix "Liquid"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the male gender^^xsd:string</para>
    ///   <para>rdfs:label : Male^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Male">trait:Male</a>
    /// </summary>
    let Male = _prefixId.prefix "Male"
    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a type of material^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Material">trait:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the motivation of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Motivation^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Motivation">trait:Motivation</a>
    /// </summary>
    let Motivation = _prefixId.prefix "Motivation"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the name or equivilent designation of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Name">trait:Name</a>
    /// </summary>
    let Name = _prefixId.prefix "Name"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the neuter gender^^xsd:string</para>
    ///   <para>rdfs:label : Neuter^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Neuter">trait:Neuter</a>
    /// </summary>
    let Neuter = _prefixId.prefix "Neuter"
    /// <summary>
    ///   <para>rdfs:label : Non-Existent^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which does not exist^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Non-Existent">trait:Non-Existent</a>
    /// </summary>
    let Non_Existent = _prefixId.prefix "Non-Existent"
    let NonExistent = _prefixId.prefix "NonExistent"
    /// <summary>
    ///   <para>rdfs:label : Old^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the old stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Old">trait:Old</a>
    /// </summary>
    let Old = _prefixId.prefix "Old"
    /// <summary>
    ///   <para>rdfs:label : Ordering^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents an ordering of Entities^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Ordering">trait:Ordering</a>
    /// </summary>
    let Ordering = _prefixId.prefix "Ordering"
    /// <summary>
    ///   <para>rdfs:label : Other^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents other genders^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Other">trait:Other</a>
    /// </summary>
    let Other = _prefixId.prefix "Other"
    /// <summary>
    ///   <para>rdfs:label : Phenotypic Sex^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the phenotypic (body type/attributes) sex of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Phenotypic-Sex">trait:Phenotypic-Sex</a>
    /// </summary>
    let Phenotypic_Sex = _prefixId.prefix "Phenotypic-Sex"
    /// <summary>
    ///   <para>rdfs:label : Physical Obstacle^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents a physical problem or obstacle^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Physical-Obstacle">trait:Physical-Obstacle</a>
    /// </summary>
    let Physical_Obstacle = _prefixId.prefix "Physical-Obstacle"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the sex of a Entity^^xsd:string</para>
    ///   <para>rdfs:label : Sex^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sex">trait:Sex</a>
    /// </summary>
    let Sex = _prefixId.prefix "Sex"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the sexual preference or preferences of a Character Entity^^xsd:string</para>
    ///   <para>rdfs:label : Sexuality^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Sexuality">trait:Sexuality</a>
    /// </summary>
    let Sexuality = _prefixId.prefix "Sexuality"
    /// <summary>
    ///   <para>rdfs:label : Solid^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is a solid^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Solid">trait:Solid</a>
    /// </summary>
    let Solid = _prefixId.prefix "Solid"
    /// <summary>
    ///   <para>rdfs:label : Species^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the species of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Species">trait:Species</a>
    /// </summary>
    let Species = _prefixId.prefix "Species"
    /// <summary>
    ///   <para>rdfs:label : Stage of Life^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the stage of life of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Stage-Of-Life">trait:Stage-Of-Life</a>
    /// </summary>
    let Stage_Of_Life = _prefixId.prefix "Stage-Of-Life"
    /// <summary>
    ///   <para>rdfs:label : State of Being^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the state of being of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Being">trait:State-Of-Being</a>
    /// </summary>
    let State_Of_Being = _prefixId.prefix "State-Of-Being"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the state of consciousness of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : State of Consciousness^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Consciousness">trait:State-Of-Consciousness</a>
    /// </summary>
    let State_Of_Consciousness = _prefixId.prefix "State-Of-Consciousness"
    /// <summary>
    ///   <para>rdfs:label : State of Form^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the state of form of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#State-Of-Form">trait:State-Of-Form</a>
    /// </summary>
    let State_Of_Form = _prefixId.prefix "State-Of-Form"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a style type^^xsd:string</para>
    ///   <para>rdfs:label : Style^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Style">trait:Style</a>
    /// </summary>
    let Style = _prefixId.prefix "Style"
    /// <summary>
    ///   <para>rdfs:label : Teenage^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the teenage stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Teenager">trait:Teenager</a>
    /// </summary>
    let Teenager = _prefixId.prefix "Teenager"
    /// <summary>
    ///   <para>rdfs:label : To No Gender/Asexual^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents having  a Character Entity with no sexual preference or preferences to other Entities^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-None">trait:To-None</a>
    /// </summary>
    let To_None = _prefixId.prefix "To-None"
    /// <summary>
    ///   <para>rdfs:label : To Other Gender^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the sexual preference or preferences of a Character Entity to other Entities which have a different gender trait. This might not be exclusive.^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Other-Gender">trait:To-Other-Gender</a>
    /// </summary>
    let To_Other_Gender = _prefixId.prefix "To-Other-Gender"
    /// <summary>
    ///   <para>rdfs:label : To Same Gender^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the sexual preference or preferences of a Character Entity to other Entities which share the same gender trait. This might not be exclusive.^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#To-Same-Gender">trait:To-Same-Gender</a>
    /// </summary>
    let To_Same_Gender = _prefixId.prefix "To-Same-Gender"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the characteristics that describe an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Trait^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Trait">trait:Trait</a>
    /// </summary>
    let Trait = _prefixId.prefix "Trait"
    /// <summary>
    ///   <para>rdfs:comment : This class represents a type^^xsd:string</para>
    ///   <para>rdfs:label : Type^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Type">trait:Type</a>
    /// </summary>
    let Type = _prefixId.prefix "Type"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity which is unconscious^^xsd:string</para>
    ///   <para>rdfs:label : Unconscious^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unconscious">trait:Unconscious</a>
    /// </summary>
    let Unconscious = _prefixId.prefix "Unconscious"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity which is undead^^xsd:string</para>
    ///   <para>rdfs:label : Undead^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Undead">trait:Undead</a>
    /// </summary>
    let Undead = _prefixId.prefix "Undead"
    /// <summary>
    ///   <para>rdfs:label : Unknown^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity those state of existance is not unknown but is theoretically provable^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unknown">trait:Unknown</a>
    /// </summary>
    let Unknown = _prefixId.prefix "Unknown"
    /// <summary>
    ///   <para>rdfs:label : Unprovable^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity those state of existance cannot be proved^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unprovable">trait:Unprovable</a>
    /// </summary>
    let Unprovable = _prefixId.prefix "Unprovable"
    /// <summary>
    ///   <para>rdfs:comment : This class describes an Entity which is totally unresponsive to external stimuli i.e. coma^^xsd:string</para>
    ///   <para>rdfs:label : Unresponsive^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Unresponsive">trait:Unresponsive</a>
    /// </summary>
    let Unresponsive = _prefixId.prefix "Unresponsive"
    /// <summary>
    ///   <para>rdfs:comment : This class represents the value of an Entity^^xsd:string</para>
    ///   <para>rdfs:label : Value^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Value">trait:Value</a>
    /// </summary>
    let Value = _prefixId.prefix "Value"
    /// <summary>
    ///   <para>rdfs:label : Virgin^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the pre-sexually active stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Virgin">trait:Virgin</a>
    /// </summary>
    let Virgin = _prefixId.prefix "Virgin"
    /// <summary>
    ///   <para>rdfs:label : Void^^xsd:string</para>
    ///   <para>rdfs:comment : This class describes an Entity which is a void^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Void">trait:Void</a>
    /// </summary>
    let Void = _prefixId.prefix "Void"
    /// <summary>
    ///   <para>rdfs:label : Young^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the young stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young">trait:Young</a>
    /// </summary>
    let Young = _prefixId.prefix "Young"
    /// <summary>
    ///   <para>rdfs:label : Young Adult^^xsd:string</para>
    ///   <para>rdfs:comment : This class represents the young adult stage of life of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#Young-Adult">trait:Young-Adult</a>
    /// </summary>
    let Young_Adult = _prefixId.prefix "Young-Adult"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the religion the entity has faith in.^^xsd:string</para>
    ///   <para>rdfs:label : Believes^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#believes">trait:believes</a>
    /// </summary>
    let believes = _prefixId.prefix "believes"
    let has_age = _prefixId.prefix "has-age"
    let has_birthday = _prefixId.prefix "has-birthday"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a bond which a character has^^xsd:string</para>
    ///   <para>rdfs:label : Has Bond^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-bond">trait:has-bond</a>
    /// </summary>
    let has_bond = _prefixId.prefix "has-bond"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a description of the entity^^xsd:string</para>
    ///   <para>rdfs:label : Has Description^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-description">trait:has-description</a>
    /// </summary>
    let has_description = _prefixId.prefix "has-description"
    let has_dimension = _prefixId.prefix "has-dimension"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a physical feature of the entity^^xsd:string</para>
    ///   <para>rdfs:label : Has Feature^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-feature">trait:has-feature</a>
    /// </summary>
    let has_feature = _prefixId.prefix "has-feature"
    let has_locspec_description = _prefixId.prefix "has-locspec-description"
    let has_marking = _prefixId.prefix "has-marking"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies an event whose occurrence is desired^^xsd:string</para>
    ///   <para>rdfs:label : Has Motivation^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation">trait:has-motivation</a>
    /// </summary>
    let has_motivation = _prefixId.prefix "has-motivation"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies an event whose occurrence is not wanted^^xsd:string</para>
    ///   <para>rdfs:label : Has Motivation^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-motivation-to-avoid">trait:has-motivation-to-avoid</a>
    /// </summary>
    let has_motivation_to_avoid = _prefixId.prefix "has-motivation-to-avoid"
    /// <summary>
    ///   <para>rdfs:label : Given Name^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the full name of the entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-name">trait:has-name</a>
    /// </summary>
    let has_name = _prefixId.prefix "has-name"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a profession which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows^^xsd:string</para>
    ///   <para>rdfs:label : Has Observed Profession^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-profession">trait:has-observed-profession</a>
    /// </summary>
    let has_observed_profession = _prefixId.prefix "has-observed-profession"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a trait which belongs to an Entity and is known outside the Context in which the Entity exists but not by other Entities within the Context i.e the audience knows^^xsd:string</para>
    ///   <para>rdfs:label : Has Observed Trait^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-observed-trait">trait:has-observed-trait</a>
    /// </summary>
    let has_observed_trait = _prefixId.prefix "has-observed-trait"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the order that the linked components go in^^xsd:string</para>
    ///   <para>rdfs:label : Has Order^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-order">trait:has-order</a>
    /// </summary>
    let has_order = _prefixId.prefix "has-order"
    let has_priority = _prefixId.prefix "has-priority"
    /// <summary>
    ///   <para>rdfs:label : Has Profession^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the profession of an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-profession">trait:has-profession</a>
    /// </summary>
    let has_profession = _prefixId.prefix "has-profession"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a profession which is projected by Entity to other Entities^^xsd:string</para>
    ///   <para>rdfs:label : Has Projected Profession^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-profession">trait:has-projected-profession</a>
    /// </summary>
    let has_projected_profession = _prefixId.prefix "has-projected-profession"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a trait which is projected by Entity to other Entities^^xsd:string</para>
    ///   <para>rdfs:label : Has Projected Trait^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-projected-trait">trait:has-projected-trait</a>
    /// </summary>
    let has_projected_trait = _prefixId.prefix "has-projected-trait"
    /// <summary>
    ///   <para>rdfs:label : Has Sex Chromosomes^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the sex chromosomes of an entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-sex-chromosomes">trait:has-sex-chromosomes</a>
    /// </summary>
    let has_sex_chromosomes = _prefixId.prefix "has-sex-chromosomes"
    /// <summary>
    ///   <para>rdfs:label : Has Trait^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies a general trait which belongs to an Entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-trait">trait:has-trait</a>
    /// </summary>
    let has_trait = _prefixId.prefix "has-trait"
    let has_unit = _prefixId.prefix "has-unit"
    /// <summary>
    ///   <para>rdfs:label : Has Value^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies a value of the property or entity^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#has-value">trait:has-value</a>
    /// </summary>
    let has_value = _prefixId.prefix "has-value"
    /// <summary>
    ///   <para>rdfs:label : Identified With^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the gender that a particular sex classification or attribute is identified with^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#identified-with">trait:identified-with</a>
    /// </summary>
    let identified_with = _prefixId.prefix "identified-with"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies something known by the character^^xsd:string</para>
    ///   <para>rdfs:label : Knows^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#knows">trait:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the 'likes' of the Character. Has domain of To-Other-Gender but not To-Same-Gender because same gender implies a match whereas since there are three genders 'other' gender gives you a choice of possibles.^^xsd:string</para>
    ///   <para>rdfs:label : Likes^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#likes">trait:likes</a>
    /// </summary>
    let likes = _prefixId.prefix "likes"
    /// <summary>
    ///   <para>rdfs:label : Mark Gained^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the event at which the distinguishing mark of the entity was gained^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-gained">trait:mark-gained</a>
    /// </summary>
    let mark_gained = _prefixId.prefix "mark-gained"
    /// <summary>
    ///   <para>rdfs:label : Mark Location^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the location of a distinguishing mark^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location">trait:mark-location</a>
    /// </summary>
    let mark_location = _prefixId.prefix "mark-location"
    /// <summary>
    ///   <para>rdfs:label : Mark Location^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the location of a distinguishing mark^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#mark-location-type">trait:mark-location-type</a>
    /// </summary>
    let mark_location_type = _prefixId.prefix "mark-location-type"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the Entity or Entities at which the related trait is not projected at^^xsd:string</para>
    ///   <para>rdfs:label : Not Projected At^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#not-projected-at">trait:not-projected-at</a>
    /// </summary>
    let not_projected_at = _prefixId.prefix "not-projected-at"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the order of magnitude of the value. Useful list: http://chemistry.berkeley.edu/links/weights/powers.html^^xsd:string</para>
    ///   <para>rdfs:label : Order of Magnitude^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#order_of_magnitude">trait:order_of_magnitude</a>
    /// </summary>
    let order_of_magnitude = _prefixId.prefix "order_of_magnitude"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the Entity or Entities at which the related trait is projected at^^xsd:string</para>
    ///   <para>rdfs:label : Projected At^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#projected-at">trait:projected-at</a>
    /// </summary>
    let projected_at = _prefixId.prefix "projected-at"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies a fetish of the Character^^xsd:string</para>
    ///   <para>rdfs:label : Requires^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#requires">trait:requires</a>
    /// </summary>
    let requires = _prefixId.prefix "requires"
    /// <summary>
    ///   <para>rdfs:label : Responsible For^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the entities for which the Entity is responsible for^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for">trait:responsible-for</a>
    /// </summary>
    let responsible_for = _prefixId.prefix "responsible-for"
    /// <summary>
    ///   <para>rdfs:label : Responsible For Type^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the types of entities for which the Entity is responsible for^^xsd:string</para>
    ///   <a href="http://contextus.net/ontology/ontomedia/ext/common/trait#responsible-for-type">trait:responsible-for-type</a>
    /// </summary>
    let responsible_for_type = _prefixId.prefix "responsible-for-type"
