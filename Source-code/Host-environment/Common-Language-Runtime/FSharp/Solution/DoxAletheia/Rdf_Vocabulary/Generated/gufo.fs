namespace http.purl.org.nemo.gufo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gufo =
    let _namespace_iri = Namespace_Iri gufo |> NamespaceIRI
    /// <summary>
    ///   <para>gufo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The objective of gUFO is to provide a lightweight implementation of the Unified Foundational Ontology (UFO) [1-5] suitable for Semantic Web OWL 2 DL applications.
    ///
    /// Intended users are those implementing UFO-based lightweight ontologies that reuse gUFO by specializing and instantiating its elements.
    ///
    /// There are three implications of the use of the term lightweight. First of all, we have employed little expressive means in an effort to retain computational properties for the resulting OWL ontology. Second, we have selected a subset of UFO-A [1, 2] and UFO-B [3] to include here. In particular, there is minimalistic support for UFO-B (only that which is necessary to establish the participation of objects in events and to capture historical dependence between events). Third, a lightweight ontology, differently from a reference ontology, is designed with the purpose of providing an implementation artifact to structure a knowledge base (or knowledge graph). This has driven a number of pragmatic implementation choices which are discussed in comments annotated to the various elements of this implementation.
    ///
    /// The 'g' in gUFO stands for gentle. At the same time, "gufo" is the Italian word for "owl".
    ///
    /// For background information on the reference ontology on which this implementation is based, see:
    ///
    /// 1. G. Guizzardi, G. Wagner, J. P. A. Almeida, R. S. S. Guizzardi, “Towards ontological foundations for conceptual modeling: The unified foundational ontology (UFO) story,” Applied Ontology (Online), vol. 10, p. 259–271, 2015. &lt;http://dx.doi.org/10.3233/ao-150157&gt;
    /// 2. G. Guizzardi, Ontological Foundations for Structural Conceptual Models,
    /// PhD Thesis, University of Twente, The Netherlands, 2005. &lt;https://research.utwente.nl/en/publications/ontological-foundations-for-structural-conceptual-models&gt;
    /// 3. G. Guizzardi, G. Wagner, R. A. Falbo, R. S. S. Guizzardi, and J. P. A. Almeida, “Towards Ontological Foundations for the Conceptual Modeling of Events,” in Proc. 32th International Conference, ER 2013, 2013, p. 327–341. &lt;https://doi.org/10.1007/978-3-642-41924-9_27&gt;
    /// 4. G. Guizzardi, C. M. Fonseca, A. B. Benevides, J. P. A. Almeida, D. Porello, T. P. Sales, “Endurant Types in Ontology-Driven Conceptual Modeling: Towards OntoUML 2.0,” in Conceptual Modeling – 37th International Conference, ER 2018, 2018, p. 136–150. &lt;https://doi.org/10.1007/978-3-030-00847-5_12&gt;
    /// 5. C. M. Fonseca, D. Porello, G. Guizzardi, J. P. A. Almeida, and N. Guarino, “Relations in ontology-driven conceptual modeling,” in 38th International Conference on Conceptual Modeling (ER 2019), LNCS, 2019. v. 11788, 2019, p. 1–15. &lt;http://dx.doi.org/10.1007/978-3-030-33223-5_4&gt;
    ///
    /// Cite this work as:
    ///
    /// J. P. A. Almeida, G. Guizzardi, T. P. Sales, R. A. Falbo, "gUFO: A Lightweight Implementation of the Unified Foundational Ontology (UFO)", 2019, http://purl.org/nemo/doc/gufo
    ///
    /// This work is distributed under Creative Commons Attribution License CC BY 4.0 &lt;https://creativecommons.org/licenses/by/4.0/legalcode&gt;.
    ///
    /// For the source repository, see: &lt;https://github.com/nemo-ufes/gufo&gt;"</para>
    /// </remarks>
    /// <seealso href="http://purl.org/nemo/gufo#">http://purl.org/nemo/gufo#</seealso>
    let _prefix_iri = Prefixed_Name(gufo, "") |> PrefixedName
    /// <summary>
    ///   <para>gufo:/1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#/1.0.0">http://purl.org/nemo/gufo#/1.0.0</seealso>
    let ``_/1.0.0`` = Prefixed_Name(gufo, "/1.0.0") |> PrefixedName
    /// <summary>
    ///   <para>gufo:AbstractIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Individual that does not exist in space-time in the same way as a gufo:ConcreteIndividual does. A gufo:AbstractIndividual has no spatiotemporal qualities in its own right. Hence, it does not make sense to ask how much space it now occupies (Gideon, 2018) and when it was created or destroyed.
    ///
    /// Examples include the number ten, the null set, and the proposition that 'Obama was the president of the United States'.
    ///
    /// Rosen, Gideon, "Abstract Objects", The Stanford Encyclopedia of Philosophy (Winter 2018 Edition), Edward N. Zalta (ed.), &lt;https://plato.stanford.edu/archives/win2018/entries/abstract-objects/&gt;"</para>
    /// labels<para>"AbstractIndividual"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#AbstractIndividual">http://purl.org/nemo/gufo#AbstractIndividual</seealso>
    let AbstractIndividual = Prefixed_Name(gufo, "AbstractIndividual") |> PrefixedName

    /// <summary>
    ///   <para>gufo:AbstractIndividualType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are abstract individuals.
    ///
    /// Instances of gufo:AbstractIndividualType are subclasses of gufo:AbstractIndividual.
    ///
    /// Examples include the types "NaturalNumber", "Set", "Proposition"."</para>
    /// labels<para>"AbstractIndividualType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#AbstractIndividualType">http://purl.org/nemo/gufo#AbstractIndividualType</seealso>
    let AbstractIndividualType =
        Prefixed_Name(gufo, "AbstractIndividualType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:AntiRigidType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:NonRigidType that applies contingently to all its instances (see Guizzardi, 2005, chapter 4).
    ///
    /// Examples include the gufo:Phase "Child", the gufo:PhaseMixin "InfantAnimal", the gufo:Role "Student", and the gufo:RoleMixin "Customer"."</para>
    /// labels<para>"AntiRigidType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#AntiRigidType">http://purl.org/nemo/gufo#AntiRigidType</seealso>
    let AntiRigidType = Prefixed_Name(gufo, "AntiRigidType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Aspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Endurant that depends on at least one other concrete individual for its existence. A gufo:Aspect is a characteristic or trait of a concrete individual that is itself conceived as an individual.
    ///
    /// Examples include: intrinsic physical aspects, such as the Moon's mass, Lassie's fur color; mental dispositions, such as Bob's math skills, his belief that the number one is odd; as well as relational aspects, such as John's love for Mary and the marriage between John and Mary.
    ///
    /// The specific sort of existential dependence connecting aspects to their bearers is called inherence.
    ///
    /// Corresponds to "Moment" in Guizzardi (2005).
    ///
    /// Also termed "property instance", "particularized property", "individual accident", or "(variable) trope" in the philosophical literature."</para>
    /// labels<para>"Aspect"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Aspect">http://purl.org/nemo/gufo#Aspect</seealso>
    let Aspect = Prefixed_Name(gufo, "Aspect") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both non-sortal and rigid. It captures essential properties that apply to instances of different kinds.
    ///
    /// For example, "PhysicalObject" may be considered a gufo:Category, encompassing objects such as cars, planets, trees. "Agent" may be a gufo:Category that classifies both people and organizations."</para>
    /// labels<para>"Category"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Category">http://purl.org/nemo/gufo#Category</seealso>
    let Category = Prefixed_Name(gufo, "Category") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complex gufo:Object whose parts (the members of the collection) have a uniform structure (i.e., members are conceived as playing the same role in the collection). Collections may have a fixed or variable membership, which can be asserted using gufo:FixedCollection and gufo:VariableCollection respectively.
    ///
    /// Examples include a deck of cards, a pile of bricks, a forest (conceived as a collection of trees), and a group of people.
    ///
    /// Collections in many cases constitute a functional complex. For example, a pile of bricks may constitute a wall, a group of people may constitute a football team.
    ///
    /// A gufo:Collection may be decomposed into "smaller" collections. For instance, a group of people may be decomposed into a group of English speakers and a group of Italian speakers. Sub collections may or may not share members among them."</para>
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Collection">http://purl.org/nemo/gufo#Collection</seealso>
    let Collection = Prefixed_Name(gufo, "Collection") |> PrefixedName

    /// <summary>
    ///   <para>gufo:ComparativeRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:RelationshipType derived from intrinsic aspects of the related entities.
    ///
    /// For example, "heavierThan", "olderThan".
    ///
    /// For a gufo:ComparativeRelationshipType it is recommended to identify the types of intrinsic aspects from which it is derived (see gufo:isDerivedFrom). For example "heavierThan" is derived from the "Weight" quality type.
    ///
    /// Note that, in the case of relationships that may change in different circumstances or times, the use of a qualified relation pattern enables indicating the period of time in which the relationship holds. See gufo:TemporaryRelationshipSituation.
    ///
    /// Corresponds to "comparative formal relation" in Guizzardi (2005) and "Comparative Relation" in Fonseca et al. (2019)."</para>
    /// labels<para>"ComparativeRelationshipType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#ComparativeRelationshipType">http://purl.org/nemo/gufo#ComparativeRelationshipType</seealso>
    let ComparativeRelationshipType =
        Prefixed_Name(gufo, "ComparativeRelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:ConcreteIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Individual that exists in space-time.
    ///
    /// Concrete individuals comprise not only object-like entities (a car, a mountain, a person, a marriage, a belief), but also events (a business meeting, a soccer match) and situations (the situation in which a person weighs 80 kilograms, the situation in which a bank account is overdrawn)."</para>
    /// labels<para>"ConcreteIndividual"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#ConcreteIndividual">http://purl.org/nemo/gufo#ConcreteIndividual</seealso>
    let ConcreteIndividual = Prefixed_Name(gufo, "ConcreteIndividual") |> PrefixedName

    /// <summary>
    ///   <para>gufo:ConcreteIndividualType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are concrete individuals.
    ///
    /// Instances of gufo:ConcreteIndividualType are subclasses of gufo:ConcreteIndividual.
    ///
    /// Examples include the gufo:Kind "Person", the gufo:Category "Physical Object", the gufo:EventType "Business Meeting"."</para>
    /// labels<para>"ConcreteIndividualType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#ConcreteIndividualType">http://purl.org/nemo/gufo#ConcreteIndividualType</seealso>
    let ConcreteIndividualType =
        Prefixed_Name(gufo, "ConcreteIndividualType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:Endurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:ConcreteIndividual that endures in time and may change qualitatively while keeping its identity.
    ///
    /// Examples include: ordinary objects of everyday experience, such as a person, a house, and a car; reified relationships, such as a marriage, a rental contract, and a person's love for another; and existentially-dependent aspects of objects, such as a car's weight, a person's language skills, and a house's color.
    ///
    /// Also termed "continuant" in the philosophical literature."</para>
    /// labels<para>"Endurant"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Endurant">http://purl.org/nemo/gufo#Endurant</seealso>
    let Endurant = Prefixed_Name(gufo, "Endurant") |> PrefixedName
    /// <summary>
    ///   <para>gufo:EndurantType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are endurants.
    ///
    /// Instances of gufo:EndurantType are subclasses of gufo:Endurant.
    ///
    /// Examples include the object kind "Person", the phase "Child", the relator kind "Marriage".
    ///
    /// See Guizzardi et al. (2018) for details concerning the taxonomy of endurant types included here."</para>
    /// labels<para>"EndurantType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#EndurantType">http://purl.org/nemo/gufo#EndurantType</seealso>
    let EndurantType = Prefixed_Name(gufo, "EndurantType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:ConcreteIndividual that 'occurs' or 'happens' in time. They may be instantaneous or long-running. Events are those "things that happen to or are performed by" (Casati and Varzi, 2015) endurants.
    ///
    /// Examples include actions and processes, such as a business meeting, a communicative act, a soccer match, a goal kick, the clicking of a mouse button; as well as natural occurrences such as an earthquake, the fall of the meteor that caused the extinction of the dinosaurs.
    ///
    /// Also termed "happening", "occurrence", "perdurant" or "occurrent" in the philosophical literature.
    ///
    /// Casati, R. &amp; Varzi, A. (2015). Events. In E.N. Zalta (Ed.), The Stanford Encyclopedia of Philosophy (Winter 2015 ed.). 19 Metaphysics Research Lab, Stanford University. https://plato.stanford.edu/archives/win2015/entries/events/"</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Event">http://purl.org/nemo/gufo#Event</seealso>
    let Event = Prefixed_Name(gufo, "Event") |> PrefixedName
    /// <summary>
    ///   <para>gufo:EventType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are events.
    ///
    /// Instances of gufo:EventType are subclasses of gufo:Event.
    ///
    /// Examples include "Business Meeting", "Birth", "Musical Performance"."</para>
    /// labels<para>"EventType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#EventType">http://purl.org/nemo/gufo#EventType</seealso>
    let EventType = Prefixed_Name(gufo, "EventType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:ExtrinsicAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Aspect that depends on one or more concrete individuals.
    ///
    /// Extrinsic (or "relational") aspects are reified relationships, e.g., John and Mary's marriage, Mary's employment contract at Nasa, or parts of those relationships, e.g., John's obligations towards Mary in the scope of the marriage, Mary's reciprocal claims, Mary's obligations towards John, John's reciprocal claims. Extrinsic aspects can also be reified one-sided relationships, e.g., John's admiration for Obama (which depends on Obama but does not characterize him).
    ///
    /// Corresponds to "Extrinsic Moment" in Fonseca et al (2019). Encompasses "Externally Depedent Mode", "Qua Individual" and "Relator" in Guizzardi (2005)."</para>
    /// labels<para>"ExtrinsicAspect"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#ExtrinsicAspect">http://purl.org/nemo/gufo#ExtrinsicAspect</seealso>
    let ExtrinsicAspect = Prefixed_Name(gufo, "ExtrinsicAspect") |> PrefixedName
    /// <summary>
    ///   <para>gufo:ExtrinsicMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:ExtrinsicAspect that inheres in a concrete individual and depends on others for its existence.
    ///
    /// A gufo:ExtrinsicMode can be understood as a reified one-sided relationship, such as John's admiration for Mary.
    ///
    /// Corresponds to "Extrinsic Moment" in Fonseca et al (2019). Encompasses what "Externally Dependent Mode", "Qua Individual" and "Relator" in Guizzardi (2005)."</para>
    /// labels<para>"ExtrinsicMode"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#ExtrinsicMode">http://purl.org/nemo/gufo#ExtrinsicMode</seealso>
    let ExtrinsicMode = Prefixed_Name(gufo, "ExtrinsicMode") |> PrefixedName
    /// <summary>
    ///   <para>gufo:FixedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Collection for which no change in membership is possible.
    ///
    /// Such a collection obeys an extensional principle of identity, i.e., two fixed collections are the same if, and only if, they have the same members.
    ///
    /// Consider, for example, a group of people understood as a gufo:FixedCollection. In this case, any change in the membership of the group (e.g., the addition of one person) would in fact create a different group of people. In this case, the gufo:FixedCollection may be contrasted with the complexes they constitute. For instance, The Beatles (the band conceived as a gufo:FunctionalComplex) was in a certain circumstance constituted by the collection {John, Paul, George, Pete} and in another one constituted by the collection {John, Paul, George, Ringo}. The replacement of Pete Best by Ringo Star does not alter the identity of the band, but creates a  different group of people."</para>
    /// labels<para>"FixedCollection"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#FixedCollection">http://purl.org/nemo/gufo#FixedCollection</seealso>
    let FixedCollection = Prefixed_Name(gufo, "FixedCollection") |> PrefixedName
    /// <summary>
    ///   <para>gufo:FunctionalComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complex gufo:Object whose parts (components) play different roles in its composition.
    ///
    /// For example, a person could be considered a gufo:FunctionalComplex with the various organs (heart, brain, lungs, etc.) playing different roles. Another example is a scrum team, which is composed by people playing the roles of scrum master, product owner, developer, etc.
    ///
    /// To explicitly capture temporary components, use gufo:TemporaryParthoodSituation."</para>
    /// labels<para>"FunctionalComplex"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#FunctionalComplex">http://purl.org/nemo/gufo#FunctionalComplex</seealso>
    let FunctionalComplex = Prefixed_Name(gufo, "FunctionalComplex") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that (unlike a gufo:Type) cannot be instantiated.
    ///
    /// Individuals may be either concrete (e.g., the Earth, Mick Jagger, Brazil, the 1985 Mexico City Earthquake) or abstract (e.g., the number two, the proposition that 'three is a prime number').
    ///
    /// Also known as "particular" in the philosophical literature."</para>
    /// labels<para>"Individual"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Individual">http://purl.org/nemo/gufo#Individual</seealso>
    let Individual = Prefixed_Name(gufo, "Individual") |> PrefixedName
    /// <summary>
    ///   <para>gufo:IntrinsicAspect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Aspect that depends on a single concrete individual in which it inheres.
    ///
    /// Examples include intrinsic physical aspects, such as the Moon's mass, Lassie's fur color; the fragility of John Lennon's glasses; mental dispositions, such as Bob's math skills, his belief that the number one is odd.
    ///
    /// A gufo:IntrinsicAspect is classified as a gufo:Quality (e.g., an apple's weight, the height of the Statue of Liberty) if it is measurable by a certain value space, or as a gufo:IntrinsicMode (e.g. Bob's belief that the Eiffel Tower is in Paris) otherwise.
    ///
    /// Corresponds to "Instrinsic Moment" in Guizzardi (2005). Different from Guizzardi (2005), here we consider that aspects can inhere in concrete individuals in general, and not only in endurants."</para>
    /// labels<para>"IntrinsicAspect"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#IntrinsicAspect">http://purl.org/nemo/gufo#IntrinsicAspect</seealso>
    let IntrinsicAspect = Prefixed_Name(gufo, "IntrinsicAspect") |> PrefixedName
    /// <summary>
    ///   <para>gufo:IntrinsicMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:IntrinsicAspect that is not measurable.
    ///
    /// For example, Bob's belief that the Eiffel Tower is in Paris, his math skills, his headache.
    ///
    /// Corresponds to "Mode" in Guizzardi (2005)."</para>
    /// labels<para>"IntrinsicMode"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#IntrinsicMode">http://purl.org/nemo/gufo#IntrinsicMode</seealso>
    let IntrinsicMode = Prefixed_Name(gufo, "IntrinsicMode") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Kind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both sortal and rigid. It provides a uniform principle of identity for its instances. Every gufo:Endurant instantiates one and only one gufo:Kind.
    ///
    /// Examples include kinds of ordinary objects of everyday experience, such as: "Person", "House", "Car"; kinds of relators, such as "Marriage", "RentalContract"; kinds of existentially-dependent aspects of objects, such as "Weight", "Belief", "Vulnerability"."</para>
    /// labels<para>"Kind"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Kind">http://purl.org/nemo/gufo#Kind</seealso>
    let Kind = Prefixed_Name(gufo, "Kind") |> PrefixedName

    /// <summary>
    ///   <para>gufo:MaterialRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:RelationshipType derived from extrinsic aspects of the related entities.
    ///
    /// For example, "marriedWith", "employedBy", "enrolledIn", "admires".
    ///
    /// For a gufo:MaterialRelationshipType it is recommended to identify the type of extrinsic aspect from which the material relationship type is derived (see gufo:isDerivedFrom). For example "marriedWith" can be derived from the "Marriage" relator type, "employedBy" can be derived from the "Employment" relator type.
    ///
    /// Encompasses "Material Relation" in Guizzardi (2005) and corresponds to "Material Relation" in Fonseca et al. (2019)."</para>
    /// labels<para>"MaterialRelationshipType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#MaterialRelationshipType">http://purl.org/nemo/gufo#MaterialRelationshipType</seealso>
    let MaterialRelationshipType =
        Prefixed_Name(gufo, "MaterialRelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:Mixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both non-sortal and semi-rigid. As a semi-rigid type, it applies necessarily to some of its instances and contingently to some others. As a non-sortal, it captures properties shared by instances of different kinds.
    ///
    /// For example, the type "FemaleAnimal" may be considered a gufo:Mixin as it applies necessarily to animals of certain species, e.g., lions and sharks, while it applies contingently to animals of other species such as clownfish and mushroom corals (which may change sex given certain conditions)."</para>
    /// labels<para>"Mixin"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Mixin">http://purl.org/nemo/gufo#Mixin</seealso>
    let Mixin = Prefixed_Name(gufo, "Mixin") |> PrefixedName
    /// <summary>
    ///   <para>gufo:NonRigidType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that does not apply necessarily to at least one of its instances (see Guizzardi, 2005, chapter 4).
    ///
    /// Examples include anti-rigid types, such as the role "Student" and the phase "Child", and semi-rigid types, such as the mixin "MusicalArtist" (which necessarily characterizes bands, but contingently characterizes people) and the mixin "FemaleAnimal" (which is necessarily characterizes female dogs, but contigently characterizes clownfish)."</para>
    /// labels<para>"NonRigidType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#NonRigidType">http://purl.org/nemo/gufo#NonRigidType</seealso>
    let NonRigidType = Prefixed_Name(gufo, "NonRigidType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:NonSortal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that applies to individuals of different kinds (see Guizzardi, 2005, chapter 4).
    ///
    /// Non-sortals do not provide a uniform principle of identity for their instances; instead, they just classify things that share common properties but which obey different principles of identity.
    ///
    /// Also termed "dispersive" types in the philosophical literature."</para>
    /// labels<para>"NonSortal"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#NonSortal">http://purl.org/nemo/gufo#NonSortal</seealso>
    let NonSortal = Prefixed_Name(gufo, "NonSortal") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Endurant that does not depend on another endurant for its existence (excluding its essential parts and aspects).
    ///
    /// Examples of objects include ordinary physical entities, such as a dog, a house, a tomato, a car, Alan Turing, but also socially-defined entities such as The Rolling Stones, the European Union, the Brazilian 1988 Constitution.
    ///
    /// Guizzardi (2005) also included the more abstract notion of "Substantial", which generalizes both objects and amounts of matter. That notion was left out from this implementation, together with the notion of amount of matter. Support for the representation of maximally-self-connected amounts of matter is given by gufo:Quantity."</para>
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Object">http://purl.org/nemo/gufo#Object</seealso>
    let Object = Prefixed_Name(gufo, "Object") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Participation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Event that depends on a single object.
    ///
    /// Participations can be used to partition an event into portions, each of which depend exclusively on a single object. Consider a business meeting with multiple participants, including John and Mary. John's participation in the meeting encompasses all events that are part of the meeting and that depend solely on him. Likewise, Mary's participation encompasses all events that are part of the meeting and that depend solely on her. Similarly, in Brutus’ stabbing of Caesar, we may identify the participations of Brutus, of Caesar, and of the dagger."</para>
    /// labels<para>"Participation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Participation">http://purl.org/nemo/gufo#Participation</seealso>
    let Participation = Prefixed_Name(gufo, "Participation") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Phase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both sortal and anti-rigid. It is defined by instrinsic but contingent instantiation conditions. Phases are relationally independent types that capturec instrinsic properties shared by instances of a given kind.
    ///
    /// For example, "Child" may be considered a gufo:Phase as a subclass of the gufo:Kind "Person", instantiated by persons younger than 12. Another example is the type "IllPerson", which may be considered a gufo:Phase that is instantiated whenever an instance of "Disease" (a gufo:IntrinsicMode) inheres in a person."</para>
    /// labels<para>"Phase"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Phase">http://purl.org/nemo/gufo#Phase</seealso>
    let Phase = Prefixed_Name(gufo, "Phase") |> PrefixedName
    /// <summary>
    ///   <para>gufo:PhaseMixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both non-sortal and anti-rigid. It is defined by instrinsic but contingent instantiation conditions. Phase mixins are relationally independent types that capture instrinsic properties shared by instances of different kinds.
    ///
    /// For example, "LivingAnimal" may be considered a gufo:PhaseMixin as a superclass of the phases "LivingPerson" (specializing the gufo:Kind "Person") and "LivingDog" (specializing the gufo:Kind "Dog")."</para>
    /// labels<para>"PhaseMixin"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#PhaseMixin">http://purl.org/nemo/gufo#PhaseMixin</seealso>
    let PhaseMixin = Prefixed_Name(gufo, "PhaseMixin") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Quality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:IntrinsicAspect that is measurable by some value spaces. A quality may be used to compare individuals, on the basis of the value it takes in a certain quality space (for instance, a position within the RGB spectrum).
    ///
    /// Examples include the weight of a person, the name of organization, the color of a car, and the duration of a concert."</para>
    /// labels<para>"Quality"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Quality">http://purl.org/nemo/gufo#Quality</seealso>
    let Quality = Prefixed_Name(gufo, "Quality") |> PrefixedName
    /// <summary>
    ///   <para>gufo:QualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:AbstractIndividual that can be associated with a gufo:Quality reflecting the perception or conception of the quality in a certain value space.
    ///
    /// Instances of gufo:QualityValue include the rational number 2.5 when used to conceive of the acidity of a portion of wine (in a pH scale), the tuple &lt;38.8897,-77.0089&gt; when used to conceive of the location of a building (in a space formed by latitude and longitude), or the triplet &lt;0,0,0&gt; when used to conceive of the color of a physical object (in a trimensional space formed by red, green and blue color components).
    ///
    /// Corresponds to "Quale" in Guizzardi (2005).
    ///
    /// Use this class only for quality values (qualia) that are to be reified in the A-box and associated with a gufo:ConcreteIndividual through the object property gufo:hasReifiedQualityValue. Otherwise, use the gufo:hasQualityValue data property and a literal to determine the quality value."</para>
    /// labels<para>"QualityValue"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#QualityValue">http://purl.org/nemo/gufo#QualityValue</seealso>
    let QualityValue = Prefixed_Name(gufo, "QualityValue") |> PrefixedName

    /// <summary>
    ///   <para>gufo:QualityValueAttributionSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Situation in which a quality value is temporarily attributed to a gufo:Endurant.
    ///
    /// A gufo:QualityValueAttributionSituation should be used only for mutable qualities, i.e. those whose value can vary in time.
    ///
    /// Examples include: the situation in which the value of a bitcoin in Euros is 6.526,12, which lasted from 10/12/2019 to 11/12/2019; the situation in which the weight of Mike Tyson was 100 kg; and the situation in which the color of Einstein' hair was grey.
    ///
    /// This is a reification of the quality value attribution (in a solution that is similar to the qualified relation pattern  http://patterns.dataincubator.org/book/qualified-relation.html )"</para>
    /// labels<para>"QualityValueAttributionSituation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#QualityValueAttributionSituation">http://purl.org/nemo/gufo#QualityValueAttributionSituation</seealso>
    let QualityValueAttributionSituation =
        Prefixed_Name(gufo, "QualityValueAttributionSituation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A complex gufo:Object that is a maximally-connected portion of stuff. A gufo:Quantity has a fixed constitution, and thus, removing or adding a sub-quantity would result in a different quantity.
    ///
    /// Examples include the portion of wine in a wine tank, a lump of clay, the gold that constitutes a wedding ring.
    ///
    /// Also termed "quantity of matter", "objectified portion of matter", "piece" in the philosophical literature."</para>
    /// labels<para>"Quantity"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Quantity">http://purl.org/nemo/gufo#Quantity</seealso>
    let Quantity = Prefixed_Name(gufo, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>gufo:RelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are ordered pairs of related entities. Instances of gufo:RelationshipType are object properties in UFO-based ontologies.
    ///
    /// The object properties "marriedWith" and "enrolledIn" are examples of material relationship types. The object properties "heavierThan", "olderThan" are examples of comparative relationship types.
    ///
    /// The use of gufo:RelationshipType and its subclasses requires OWL 2 punning.
    ///
    /// Corresponds to "Relation" in Guizzardi (2005) and Fonseca et al. (2019)."</para>
    /// labels<para>"RelationshipType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#RelationshipType">http://purl.org/nemo/gufo#RelationshipType</seealso>
    let RelationshipType = Prefixed_Name(gufo, "RelationshipType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Relator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:ExtrinsicAspect that connects (involves, mediates) two or more concrete individuals. Relators are reified relationships composed of reciprocal extrinsic modes.
    ///
    /// Examples of relators include John and Mary's marriage (composed of John's obligations towards Mary in the scope of the marriage, Mary's reciprocal claims, Mary's obligations towards John, John's reciprocal claims), Mary's employment contract at Nasa, a covalent bond between two atoms."</para>
    /// labels<para>"Relator"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Relator">http://purl.org/nemo/gufo#Relator</seealso>
    let Relator = Prefixed_Name(gufo, "Relator") |> PrefixedName
    /// <summary>
    ///   <para>gufo:RigidType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType which applies necessarily to its instances (see Guizzardi, 2005, chapter 4).
    ///
    /// Examples include the types "Agent", "Person", "Animal", "PhysicalObject", "Car", and "Tree"."</para>
    /// labels<para>"RigidType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#RigidType">http://purl.org/nemo/gufo#RigidType</seealso>
    let RigidType = Prefixed_Name(gufo, "RigidType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that both sortal and anti-rigid. It is defined by relational instantiation conditions. Roles are relationally dependent types, capturing relational properties shared by instances of a given kind.
    ///
    /// For example, "Student" may be considered a gufo:Role as a subclass of the gufo:Kind "Person", instantiated by all persons enrolled in a school. ""</para>
    /// labels<para>"Role"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Role">http://purl.org/nemo/gufo#Role</seealso>
    let Role = Prefixed_Name(gufo, "Role") |> PrefixedName
    /// <summary>
    ///   <para>gufo:RoleMixin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both non-sortal and anti-rigid. It is defined by relational instantiation conditions. Role mixins are relationally dependent types, capturing relational properties shared by instances of different kinds.
    ///
    /// For example, "Customer" may be considered a gufo:RoleMixin as a superclass of the roles "CorporateCustomer" (specializing the gufo:Kind "BusinessOrganization") and "PersonalCustomer" (specializing the gufo:Kind "Person")."</para>
    /// labels<para>"RoleMixin"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#RoleMixin">http://purl.org/nemo/gufo#RoleMixin</seealso>
    let RoleMixin = Prefixed_Name(gufo, "RoleMixin") |> PrefixedName
    /// <summary>
    ///   <para>gufo:SemiRigidType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:NonRigidType that applies necessarily to some of its instances and contingently to some others (see Guizzardi, 2005, chapter 4)."</para>
    /// labels<para>"SemiRigidType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#SemiRigidType">http://purl.org/nemo/gufo#SemiRigidType</seealso>
    let SemiRigidType = Prefixed_Name(gufo, "SemiRigidType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:ConcreteIndividual that is a particular configuration of a part of reality which can be understood as a whole and in which entities stand in relations. A situation may be counterfactual or actual. An actual situation (or in other words, a "fact") "obtains" in a certain time instant or during a time interval.
    ///
    /// Note that, in Guizzardi et al. (2013), situations were considered to obtain at a specific point in time. Here, instead, they obtain in a time interval when begin and end points differ.
    ///
    /// The various subclasses of Situation in this implementation are used to capture "mutable" facts which obtain during some time and fail to obtain at other times. This includes the contingent instantiation of non-rigid types (e.g., as someone is a child at one point in time and a teenager later), the attribution of value to mutable qualities (such as a person's weight) and temporary participation in part-whole relations for replaceable parts (such as a car's tires). Other subclasses may be created to capture domain-specific notions such as "HazardousSituation", "PersonHasFever"."</para>
    /// labels<para>"Situation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Situation">http://purl.org/nemo/gufo#Situation</seealso>
    let Situation = Prefixed_Name(gufo, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>gufo:SituationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Type whose instances are situations.
    ///
    /// Instances of gufo:SituationType are subclasses of gufo:Situation.
    ///
    /// Examples include "HazardousSituation", "PersonHasFever",  "PersonIsStudent"."</para>
    /// labels<para>"SituationType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#SituationType">http://purl.org/nemo/gufo#SituationType</seealso>
    let SituationType = Prefixed_Name(gufo, "SituationType") |> PrefixedName
    /// <summary>
    ///   <para>gufo:Sortal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType which carries (or supplies) a principle of identity for its instances  (see Guizzardi, 2005, chapter 4)."</para>
    /// labels<para>"Sortal"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Sortal">http://purl.org/nemo/gufo#Sortal</seealso>
    let Sortal = Prefixed_Name(gufo, "Sortal") |> PrefixedName
    /// <summary>
    ///   <para>gufo:SubKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:EndurantType that is both sortal and rigid. It specializes a gufo:Kind carrying the principle of identity supplied by that kind. Every gufo:SubKind should directly or indirectly specialize a gufo:Kind.
    ///
    /// For example, the gufo:Kind "Lion" may be specialized into the "Lionness" and "Male Lion" subkinds, while the gufo:Kind "Computer" may be specialized into the "Laptop" and "Desktop" subkinds."</para>
    /// labels<para>"SubKind"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#SubKind">http://purl.org/nemo/gufo#SubKind</seealso>
    let SubKind = Prefixed_Name(gufo, "SubKind") |> PrefixedName

    /// <summary>
    ///   <para>gufo:TemporaryConstitutionSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Situation in which a gufo:Endurant temporarly constitutes another gufo:Endurant.
    ///
    /// When constitution of an object may change in time, it may be qualified by the period in time in which the relation applies.
    ///
    /// Examples include: the situation in which the Beatles is constituted by the group composed of {John,Paul,Ringo,George}; and the situation in which the statue of Venus de Milo was constituted by its original quantity of marble (including its arms).
    ///
    /// This is a reification of constitution (in a solution that is similar to the qualified relation pattern  http://patterns.dataincubator.org/book/qualified-relation.html)"</para>
    /// labels<para>"TemporaryConstitutionSituation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#TemporaryConstitutionSituation">http://purl.org/nemo/gufo#TemporaryConstitutionSituation</seealso>
    let TemporaryConstitutionSituation =
        Prefixed_Name(gufo, "TemporaryConstitutionSituation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:TemporaryInstantiationSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Situation in which a gufo:Endurant temporarily instantiates a gufo:NonRigidType.
    ///
    /// A gufo:TemporaryInstantiationSituation can account for the time period in which a particular instantiation holds.
    ///
    /// Examples include: the situation in which Obama instantiates the role of president, which began in 20/01/2009 and lasted until 20/01/2017; the situation in which Coatria instantiates the role of EU Member, which began in 01/07/2013 (and is still on-going); and the situation in which Steve Jobs instantiates the child phase, which began in 24/02/1955 and lasted until 24/02/1965.
    ///
    /// This solution is inspired in the qualified relation pattern (http://patterns.dataincubator.org/book/qualified-relation.html)."</para>
    /// labels<para>"TemporaryInstantiationSituation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#TemporaryInstantiationSituation">http://purl.org/nemo/gufo#TemporaryInstantiationSituation</seealso>
    let TemporaryInstantiationSituation =
        Prefixed_Name(gufo, "TemporaryInstantiationSituation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:TemporaryParthoodSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Situation in which a gufo:Endurant is temporarily a part of another gufo:Endurant.
    ///
    /// A gufo:TemporaryParthoodSituation should only be used for mutable parts. It may be qualified by the period in time in which the relation applies.
    ///
    /// Examples include: the situation in which the United Kingdom is a member of the European Union; the situation in which Messi is a a member of the Barcelona FC squad; the situation in which an engine is part of a car; and the situation in which a transplanted heart is part of a person.
    ///
    /// Note that, since every instance of gufo:Quantity or gufo:FixedCollection only has essential parts, the gufo:TemporaryParthoodSituation should not be used to represent these parthood relations.
    ///
    /// This solution is inspired in the qualified relation pattern (http://patterns.dataincubator.org/book/qualified-relation.html)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TemporaryParthoodSituation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#TemporaryParthoodSituation">http://purl.org/nemo/gufo#TemporaryParthoodSituation</seealso>
    let TemporaryParthoodSituation =
        Prefixed_Name(gufo, "TemporaryParthoodSituation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:TemporaryRelationshipSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Situation in which a gufo:Endurant temporarily stands in a relation with another gufo:Endurant (or other endurants in the case of n-ary relationships).
    ///
    /// Reification of a gufo:TemporaryRelationshipSituation allows qualification of the relationship with the period in time in which it applies.
    ///
    /// Examples include: the situation in which Einstein works at the Swiss Patent Office in Bern; the situation in which Elon Musk studies at the University of Pennsylvania; the situation in which John Lennon is married to Yoko Ono; and the situation in which Facebook has a lower market value than Amazon.
    ///
    /// For material relationships, prefer the use of gufo:Relator.
    ///
    /// This is a reification of the relationship (in a solution that is similar to the qualified relation pattern  http://patterns.dataincubator.org/book/qualified-relation.html)."</para>
    /// labels<para>"TemporaryRelationshipSituation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#TemporaryRelationshipSituation">http://purl.org/nemo/gufo#TemporaryRelationshipSituation</seealso>
    let TemporaryRelationshipSituation =
        Prefixed_Name(gufo, "TemporaryRelationshipSituation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An entity that may be instantiated by (or predicated over) other entities. Types encompass what we often call "sorts", "kinds", "categories", etc.
    ///
    /// Examples include the kind "Person", the event type "Earthquake", and the abstract individual type "NaturalNumber". Relations, such as "marriedTo" and "olderThan", are also considered as types.
    ///
    /// Instances of gufo:Type are classes, and should specialize the taxonomy of individuals of gUFO. For example, "Person" is a gufo:Type (more specifically a gufo:Kind), specializing gufo:Object. The mechanism that allows for this is called punning in OWL 2.
    ///
    /// Encompasses the notion of "Universal" in Guizzardi (2005)."</para>
    /// labels<para>"Type"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#Type">http://purl.org/nemo/gufo#Type</seealso>
    let Type = Prefixed_Name(gufo, "Type") |> PrefixedName
    /// <summary>
    ///   <para>gufo:VariableCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gufo:Collection for which change in membership is possible.
    ///
    /// Such a collection obeys an intensional principle of identity, i.e., change in membership does not necessarily create a different collection.
    ///
    /// For example, KLM's fleet of airplanes could be understood as a gufo:VariableCollection. In this case, when the company acquires (or retires) an airplane, the fleet changes. Note that, in this case, the airplanes are conceptualized as playing the role of "member of a fleet". If various roles for the parts of a fleet were envisioned (such as "cargo airplane", "passenger airplane"), then a fleet would be best understood as a gufo:FunctionalComplex.
    ///
    /// See gufo:TemporaryParthoodSituation for the pattern to represent the relation of a variable collection to its temporary parts."</para>
    /// labels<para>"VariableCollection"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#VariableCollection">http://purl.org/nemo/gufo#VariableCollection</seealso>
    let VariableCollection = Prefixed_Name(gufo, "VariableCollection") |> PrefixedName
    /// <summary>
    ///   <para>gufo:broughtAbout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Situation that is brought about by the gufo:Event.
    ///
    /// Guizzardi et al. (2013) included a notion of "brings-about" that related events to a single ("maximal") situation, embodying all the effects of the event at the time it ends. This implementation of gufo:broughtAbout diverges from "brings-about" in that work because gufo:broughtAbout can be used to relate events to more than one gufo:Situation. Each gufo:Situation identified through gufo:broughtAbout should be understood as an (improper) part of the maximal situation."</para>
    /// labels<para>"broughtAbout"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#broughtAbout">http://purl.org/nemo/gufo#broughtAbout</seealso>
    let broughtAbout = Prefixed_Name(gufo, "broughtAbout") |> PrefixedName
    /// <summary>
    ///   <para>gufo:categorizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Identifies a gufo:Type whose instances may be classified by instances of the categorizing higher-order type.
    ///
    /// For example, "ShipType" gufo:categorizes "Ship". Instances of "ShipType" such as "Supercarrier" and "Cargoship" should be declared subclasses of "Ship". OWL 2 punning should be used to capture the two facets of "Supercarrier" and "Cargoship" in this example: (i) as instances of "ShipType", and (ii) as subclasses of "Ship".
    ///
    /// The categorized type is termed the "base type" in the "powertype pattern" see Carvalho et al (2017), the higher-order type is often called the "powertype".
    ///
    /// gufo:categorizes is the general (unspecific) form of categorization. See  gufo:partitions for a more specific form, in which instances of the categorized type are classified by exactly one instance of the higher-order type.
    ///
    /// The domain is gufo:Type excluding gufo:AbstractIndividualType as well as gufo:ConcreteIndividualTypes because those types are first-order types (their instances are individuals). Only instances of gufo:Type representing higher-order types can categorize a base type.
    ///
    /// For further details and formalization of "categorization", see Carvalho et al (2017) which combines UFO with MLT (a multi-level modeling theory).
    ///
    /// V. A. Carvalho, J. P. A. Almeida, C. M. Fonseca, and G. Guizzardi, “Multi-level ontology-based conceptual modeling,” Data &amp; Knowledge Engineering, vol. 109, p. 3–24, 2017. &lt;http://dx.doi.org/10.1016/j.datak.2017.03.002&gt;"</para>
    /// labels<para>"categorizes"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#categorizes">http://purl.org/nemo/gufo#categorizes</seealso>
    let categorizes = Prefixed_Name(gufo, "categorizes") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsConstitutedEndurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the constituted gufo:Endurant in the gufo:TemporaryConstitutionSituation."</para>
    /// labels<para>"concernsConstitutedEndurant"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsConstitutedEndurant">http://purl.org/nemo/gufo#concernsConstitutedEndurant</seealso>
    let concernsConstitutedEndurant =
        Prefixed_Name(gufo, "concernsConstitutedEndurant") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsNonRigidType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the gufo:NonRigidType that is instantiated by the endurant that stands in a gufo:TemporaryInstantiationSituation."</para>
    /// labels<para>"concernsNonRigidType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsNonRigidType">http://purl.org/nemo/gufo#concernsNonRigidType</seealso>
    let concernsNonRigidType =
        Prefixed_Name(gufo, "concernsNonRigidType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsQualityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the quality type (a gufo:EndurantType subclassing gufo:Quality) whose value is attributed in the gufo:QualityValueAttributionSituation."</para>
    /// labels<para>"concernsQualityType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsQualityType">http://purl.org/nemo/gufo#concernsQualityType</seealso>
    let concernsQualityType = Prefixed_Name(gufo, "concernsQualityType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsQualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines a quality value associated with the gufo:ConcreteIndividual that stands in the gufo:QualityValueAttributionSituation.
    ///
    /// Use gufo:concernsReifiedQualityValue instead when quality values are refied.
    ///
    /// It is recommended that subproperties of gufo:concernsQualityValue are created, possibly identifying the datatype to be used. For example, "concernsTemperatureValue" could be defined as a sub-property of gufo:concernsQualityValue with range xsd:double."</para>
    /// labels<para>"concernsQualityValue"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsQualityValue">http://purl.org/nemo/gufo#concernsQualityValue</seealso>
    let concernsQualityValue =
        Prefixed_Name(gufo, "concernsQualityValue") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsReifiedQualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the gufo:QualityValue (i.e., the reified quality value) associated with the endurant that stands in the gufo:QualityValueAttributionSituation."</para>
    /// labels<para>"concernsReifiedQualityValue"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsReifiedQualityValue">http://purl.org/nemo/gufo#concernsReifiedQualityValue</seealso>
    let concernsReifiedQualityValue =
        Prefixed_Name(gufo, "concernsReifiedQualityValue") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsRelatedEndurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the related gufo:Endurant in the gufo:TemporaryRelationshipSituation."</para>
    /// labels<para>"concernsRelatedEndurant"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsRelatedEndurant">http://purl.org/nemo/gufo#concernsRelatedEndurant</seealso>
    let concernsRelatedEndurant =
        Prefixed_Name(gufo, "concernsRelatedEndurant") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the gufo:RelationshipType instantiated in the gufo:TemporaryRelationshipSituation."</para>
    /// labels<para>"concernsRelationshipType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsRelationshipType">http://purl.org/nemo/gufo#concernsRelationshipType</seealso>
    let concernsRelationshipType =
        Prefixed_Name(gufo, "concernsRelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:concernsTemporaryWhole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the whole (a gufo:Endurant) of which the endurant that stands in the gufo:TemporaryParthoodSituation is part."</para>
    /// labels<para>"concernsTemporaryWhole"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#concernsTemporaryWhole">http://purl.org/nemo/gufo#concernsTemporaryWhole</seealso>
    let concernsTemporaryWhole =
        Prefixed_Name(gufo, "concernsTemporaryWhole") |> PrefixedName

    /// <summary>
    ///   <para>gufo:constitutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:ConcreteIndividual that is constituted (partially) by the constituent individual.
    ///
    /// For example, the gufo:Collection of persons whose members are John, Paul, George, Ringo constituted the beatles, the gufo:Quantity of marble that constitutes the statue of Venus de Milo, and the gufo:Event of Paul raising his arm in a meeting that constitutes his voting (also a gufo:Event).
    ///
    /// In case constitution changes in time, see gufo:standsInQualifiedConstitution."</para>
    /// labels<para>"constitutes"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#constitutes">http://purl.org/nemo/gufo#constitutes</seealso>
    let constitutes = Prefixed_Name(gufo, "constitutes") |> PrefixedName

    /// <summary>
    ///   <para>gufo:contributedToTrigger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Event that the gufo:Situation contributed to trigger.
    ///
    /// Guizzardi et al. (2013) defined a notion of "triggers" to relate the situation satisfying all the sufficient and necessary conditions with the triggered  event. This implementation differs from  "triggers" as defined in that work because gufo:contributedToTrigger can be used to relate more than one gufo:Situation to a gufo:Event. Each gufo:Situation identified through gufo:contributedToTrigger should be understood as an (improper) part of the situation that triggered the event."</para>
    /// labels<para>"contributedToTrigger"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#contributedToTrigger">http://purl.org/nemo/gufo#contributedToTrigger</seealso>
    let contributedToTrigger =
        Prefixed_Name(gufo, "contributedToTrigger") |> PrefixedName

    /// <summary>
    ///   <para>gufo:externallyDependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Identifies a gufo:Endurant on which the gufo:ExtrinsicMode depends.
    ///
    /// For example, John's duty to return the book he borrowed from Mary (a gufo:ExtrinsicMode) depends externally on Mary.
    ///
    /// The identifed gufo:Endurant should  be external to the bearer of the extrinsic mode (see Guizzardi, 2005, p. 239). In other words, the identified endurant should not be a part or an intrisic aspect of the bearer of the extrinsic mode."</para>
    /// labels<para>"externallyDependsOn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#externallyDependsOn">http://purl.org/nemo/gufo#externallyDependsOn</seealso>
    let externallyDependsOn = Prefixed_Name(gufo, "externallyDependsOn") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasAssociatedQualityValueType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a quality value type to which the quality type is associated.
    ///
    /// For example, a "Color" quality type may be associated with a "ColorValueInRGB" quality value type.
    ///
    /// It relates a specialization of gufo:Quality (an instance of gufo:EndurantType) to a specialization of gufo:QualityValue  (an instance of gufo:AbstractIndividualType).
    ///
    /// To be used only when quality values are reified."</para>
    /// labels<para>"hasAssociatedQualityValueType"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasAssociatedQualityValueType">http://purl.org/nemo/gufo#hasAssociatedQualityValueType</seealso>
    let hasAssociatedQualityValueType =
        Prefixed_Name(gufo, "hasAssociatedQualityValueType") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasBeginPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the begin point for a gufo:ConcreteIndividual, in the case in which time instants are reified.
    ///
    /// In the case of endurants, this identifies the time point when the endurant comes into existence. In the case of events, this identifies the time point when the event starts to take place. In the case of situation, this identifies the time point when the situation begins to hold.
    ///
    /// If time instants are not reified, use gufo:hasBeginPointInXSDDate or gufo:hasBeginPointInXSDDateTimeStamp."</para>
    /// labels<para>"hasBeginPoint"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasBeginPoint">http://purl.org/nemo/gufo#hasBeginPoint</seealso>
    let hasBeginPoint = Prefixed_Name(gufo, "hasBeginPoint") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasBeginPointInXSDDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines the begin point for a gufo:ConcreteIndividual, using a xsd:date literal.
    ///
    /// In the case of endurants, gufo:asBeginPointInXSDDate determines the time point when the endurant comes into existence. In the case of events, this data property determines the time point when the event starts to take place. In the case of situation, it determines the time point when the situation begins to hold.
    ///
    /// Use gufo:hasBeginPoint instead when temporal entities are reified."</para>
    /// labels<para>"hasBeginPointInXSDDate"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasBeginPointInXSDDate">http://purl.org/nemo/gufo#hasBeginPointInXSDDate</seealso>
    let hasBeginPointInXSDDate =
        Prefixed_Name(gufo, "hasBeginPointInXSDDate") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasBeginPointInXSDDateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Determines the begin point for a gufo:ConcreteIndividual, using a xsd:dateTimeStamp literal.
    ///
    /// In the case of endurants, gufo:hasBeginPointInXSDDateTimeStamp determines the time point when the endurant comes into existence. In the case of events, this data property determines the time point when the event starts to take place. In the case of situation, it determines the time point when the situation begins to hold.
    ///
    /// Use gufo:hasBeginPoint instead when temporal entities are reified."</para>
    /// labels<para>"hasBeginPointInXSDDateTimeStamp"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasBeginPointInXSDDateTimeStamp">http://purl.org/nemo/gufo#hasBeginPointInXSDDateTimeStamp</seealso>
    let hasBeginPointInXSDDateTimeStamp =
        Prefixed_Name(gufo, "hasBeginPointInXSDDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasEndPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the end point for a gufo:ConcreteIndividual, in the case in which time instants are reified.
    ///
    /// In the case of endurants, this identifies the time point when the endurant ceases to exist. In the case of events, this identifies the time point when the event ends. In the case of situation, this identifies the time point when the situation ceases to hold."</para>
    /// labels<para>"hasEndPoint"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasEndPoint">http://purl.org/nemo/gufo#hasEndPoint</seealso>
    let hasEndPoint = Prefixed_Name(gufo, "hasEndPoint") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasEndPointInXSDDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines the end point for a gufo:ConcreteIndividual using a xsd:date literal.
    ///
    /// In the case of endurants, gufo:hasEndPointInXSDDate determines the time point when the endurant ceases to exist. In the case of events, this data property determines the time point when the event ends. In the case of situation, it determines the time point when the situation ceases to hold.
    ///
    /// Use gufo:hasEndPoint instead when temporal entities are reified."</para>
    /// labels<para>"hasEndPointInXSDDate"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasEndPointInXSDDate">http://purl.org/nemo/gufo#hasEndPointInXSDDate</seealso>
    let hasEndPointInXSDDate =
        Prefixed_Name(gufo, "hasEndPointInXSDDate") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasEndPointInXSDDateTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Determines the end point for a gufo:ConcreteIndividual using a xsd:dateTimeStamp literal.
    ///
    /// In the case of endurants, gufo:hasEndPointInXSDDateTimeStamp determines the time point when the endurant ceases to exist. In the case of events, this data property determines the time point when the event ends. In the case of situation, it determines the time point when the situation ceases to hold.
    ///
    /// Use gufo:hasEndPoint instead when temporal entities are reified."</para>
    /// labels<para>"hasEndPointInXSDDateTimeStamp"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasEndPointInXSDDateTimeStamp">http://purl.org/nemo/gufo#hasEndPointInXSDDateTimeStamp</seealso>
    let hasEndPointInXSDDateTimeStamp =
        Prefixed_Name(gufo, "hasEndPointInXSDDateTimeStamp") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasQualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Determines a quality value associated with the concrete individual.
    ///
    /// Use gufo:hasReifiedQualityValue instead when quality values are reified.
    ///
    /// It is recommended that subproperties of gufo:hasQualityValue are created, possibly identifying the datatype to be used. For example, "hasTemperatureValue" could be defined as a sub-property of gufo:hasQualityValue whose domain is "Temperature" (specializing gufo:Quality) and whose range is xsd:double."</para>
    /// labels<para>"hasQualityValue"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasQualityValue">http://purl.org/nemo/gufo#hasQualityValue</seealso>
    let hasQualityValue = Prefixed_Name(gufo, "hasQualityValue") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasReifiedQualityValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies an instance of gufo:QualityValue to reflect the perception or conception of a quality in a certain value space.
    ///
    /// Use this property only for quality values that are to be reified in the A-box and associated with a gufo:ConcreteIndividual. Otherwise, use the gufo:hasQualityValue data property and a literal to determine the quality value.
    ///
    /// The full representation pattern for quality values involves first identifying a gufo:Quality that inheres in a concrete individual and then associating it with a reified quality value. For example, let us consider the color of Yves Klein's "Blue Monochrome" painting made in 1961 (MoMA's object with number 618.1967). In the full pattern, an instance of gufo:Quality that inheres in the physical object (the color of that painting) is associated with a gufo:QualityValue (say the triplet &lt;0, 47, 167&gt; for that painting) through gufo:hasReifiedQualityValue. The full pattern is recommended when different quality spaces are expected to be used for the same quality. For example, the color of that painting could also be associated with a quadruple &lt;100, 72, 0, 35&gt; representing the same color in a CMYK space.
    ///
    /// When the full pattern is not required, gufo:hasReifiedQualityValue can also be used to directly associate a concrete individual (without identifying the quality) with a quality value."</para>
    /// labels<para>"hasReifiedQualityValue"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasReifiedQualityValue">http://purl.org/nemo/gufo#hasReifiedQualityValue</seealso>
    let hasReifiedQualityValue =
        Prefixed_Name(gufo, "hasReifiedQualityValue") |> PrefixedName

    /// <summary>
    ///   <para>gufo:hasValueComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is used for quality values that are defined in terms of a multidimensional quality structure (such as color conceived in terms of hue, saturation and brightness). Each value component of a quality value (a particular value for hue, a particular value for saturation, a particular value for brightness) is determined with this property.
    ///
    /// It is recommended that subproperties of gufo:hasValueComponent are created to indicate values for particular dimensions, possibly identifying the datatype to be used. For example "hasHueComponent", "hasSaturationComponent" and "hasBrightnessComponent" could be used as data properties specializing gufo:hasValueComponent with the xsd:double datatype."</para>
    /// labels<para>"hasValueComponent"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#hasValueComponent">http://purl.org/nemo/gufo#hasValueComponent</seealso>
    let hasValueComponent = Prefixed_Name(gufo, "hasValueComponent") |> PrefixedName

    /// <summary>
    ///   <para>gufo:historicallyDependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:ConcreteIndividual on which the concrete individual depends historically.
    ///
    /// For example, a person is historically dependent on his/her ancestors.
    ///
    /// When used between events, historical dependence encompasses causation (when the event is caused by the other), but also other cases where there is dependence but not causation (when the event brings about a situation that is either insufficient or more than sufficient to trigger the historically dependent event).
    ///
    /// For example, Real Madrid's goal in the 60th minute of the 2016 FIFA Club World Cup Final is historically dependent on (and in this case caused by) a penalty kick by Cristiano Ronaldo. The penalty kick itself is historically dependent on (but not caused by) a penalty (the occurrence of the penalty is necessary but not sufficient to cause the penalty kick as authorization of the referee is required).
    ///
    /// Historical dependence is transitive. Hence, in the example above, Real Madrid's goal is historically dependent on the penalty."</para>
    /// labels<para>"historicallyDependsOn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#historicallyDependsOn">http://purl.org/nemo/gufo#historicallyDependsOn</seealso>
    let historicallyDependsOn =
        Prefixed_Name(gufo, "historicallyDependsOn") |> PrefixedName

    /// <summary>
    ///   <para>gufo:inheresIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the gufo:ConcreteIndividual in which the gufo:Aspect inheres. Inherence is a sort of existential dependence. The identified concrete individual is the "bearer" of the aspect.
    ///
    /// For example, the color of an object inheres in the object and the average speed of a flight inheres in the flight."</para>
    /// labels<para>"inheresIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#inheresIn">http://purl.org/nemo/gufo#inheresIn</seealso>
    let inheresIn = Prefixed_Name(gufo, "inheresIn") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isAspectProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Identifies a gufo:Aspect of which the aspect is a proper part.
    ///
    /// For example, John's obligations towards Mary in the scope of their marriage is an aspect proper part of their marriage  (and same can be said of Mary's extrinsic aspects in the scope of their marriage.)
    ///
    /// This property can be used to represent the composition of a relator from extrisinc aspects, but also to represent complex extrisinc aspects.
    ///
    /// gufo:isAspectProperPartOf is transitive."</para>
    /// labels<para>"isAspectProperPartOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isAspectProperPartOf">http://purl.org/nemo/gufo#isAspectProperPartOf</seealso>
    let isAspectProperPartOf =
        Prefixed_Name(gufo, "isAspectProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isCollectionMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Collection of which the object is a member.
    ///
    /// This is the relation between John and a group of persons, and between a cow and its herd.
    ///
    /// gufo:isCollectionMemberOf is intransitive (Guizzardi, 2005, p. 185).
    ///
    /// For membership in a gufo:VariableCollection, see gufo:standsInQualifiedParthood."</para>
    /// labels<para>"isCollectionMemberOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isCollectionMemberOf">http://purl.org/nemo/gufo#isCollectionMemberOf</seealso>
    let isCollectionMemberOf =
        Prefixed_Name(gufo, "isCollectionMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:FunctionalComplex of which the object is a component.
    ///
    /// For example, the habitation module is a component of the International Space Station, and so are each of the solar panels; Obama's brain is a component of his body, and so is his heart; the engine is a component of the HMS Queen Elizabeth (R08).
    ///
    /// gufo:isComponentOf is not transitive in the general case. Particular sub-properties may be transitive (Guizzardi, 2005, p. 183).
    ///
    /// When a component may change its relation to be whole, see gufo:standsInQualifiedParthood."</para>
    /// labels<para>"isComponentOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isComponentOf">http://purl.org/nemo/gufo#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(gufo, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>gufo:isDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:EndurantType from which the material or comparative relation can be derived. The identified gufo:EndurantType should be a subclass of gufo:Aspect, more specifically a subclass of gufo:ExtrinsicAspect in the case of a gufo:MaterialRelationshipType, and a subclass of gufo:IntrinsicAspect in the case of a gufo:ComparativeRelationshipType.
    ///
    /// For example, "marriedWith" can be derived from "Marriage", "heavierThan" can be derived from "Weight".
    ///
    /// See Fonseca et al. (2019)."</para>
    /// labels<para>"isDerivedFrom"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isDerivedFrom">http://purl.org/nemo/gufo#isDerivedFrom</seealso>
    let isDerivedFrom = Prefixed_Name(gufo, "isDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>gufo:isEventProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Identifies a gufo:Event of which the event is part.
    ///
    /// For example, Cristiano Ronaldo's penalty kick is an event proper part of the 2016 FIFA Club World Cup Final, having ocurred in the 60th minute of that match. That match is itself an event proper part of the 2016 FIFA Club World Cup.
    ///
    /// The match can be decomposed in different ways. For example, we can identify the participation of each player in the match (instances of gufo:Participation that are proper parts of the match) or decomposed the match using some temporal segmentation (each minute of the match, each of which is a proper part of the match).
    ///
    /// gufo:isEventProperPartOf is transitive."</para>
    /// labels<para>"isEventProperPartOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isEventProperPartOf">http://purl.org/nemo/gufo#isEventProperPartOf</seealso>
    let isEventProperPartOf = Prefixed_Name(gufo, "isEventProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isObjectProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Object of which the object is a part.
    ///
    /// This is a general parthood relation between objects. Use the various sub-properties provided in order to represent specific types of parthood, each of which has specialized semantics (and different formal properties in this implementation, in particular, transitivity (Guizzardi, 2005, section 5.6)."</para>
    /// labels<para>"isObjectProperPartOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isObjectProperPartOf">http://purl.org/nemo/gufo#isObjectProperPartOf</seealso>
    let isObjectProperPartOf =
        Prefixed_Name(gufo, "isObjectProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a whole of which the entity is a proper part.
    ///
    /// gufo:isProperPartOf is the most generic parthood relation in this implementation. Use the various sub-properties provided in order to represent specific types of parthood.
    ///
    /// Proper parthood (and each of its sub-properties) is asymmetric and irreflexive. Nevertheless, these characteristics are not declared in this implementation since that would violate rules of OWL 2 DL that guarantee decidability of reasoning. Instead, we have focused only on declaring transitivity where applicable.
    ///
    /// Note that gufo:isProperPartOf (as the most general notion of parthood) is transitive, although the various sub-properties may not be transitive."</para>
    /// labels<para>"isProperPartOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isProperPartOf">http://purl.org/nemo/gufo#isProperPartOf</seealso>
    let isProperPartOf = Prefixed_Name(gufo, "isProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isSituationProperPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Situation of which the situation is a part.
    ///
    /// Examples include: the situation in which John has influenza is part of the situation in which John has influenza and he is tired; the situation in which John is friends with Mary is part of the situation in which he is friends with Mary and Alice; the situation in which John is married to Alice is part of the situation in which John is married to Alice, while she works at the Free University of Bozen-Bolzano."</para>
    /// labels<para>"isSituationProperPartOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isSituationProperPartOf">http://purl.org/nemo/gufo#isSituationProperPartOf</seealso>
    let isSituationProperPartOf =
        Prefixed_Name(gufo, "isSituationProperPartOf") |> PrefixedName

    /// <summary>
    ///   <para>gufo:isSubCollectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Identifies a gufo:Collection of which the collection is a sub-collection. All members of the sub-collection are members of the identified super-collection.
    ///
    /// gufo:isSubCollectionOf is transitive (Guizzardi, 2005, p. 186).
    ///
    /// For parthood involving one or more varied collections, see gufo:standsInQualifiedParthood."</para>
    /// labels<para>"isSubCollectionOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isSubCollectionOf">http://purl.org/nemo/gufo#isSubCollectionOf</seealso>
    let isSubCollectionOf = Prefixed_Name(gufo, "isSubCollectionOf") |> PrefixedName
    /// <summary>
    ///   <para>gufo:isSubQuantityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Identifies a gufo:Quantity of which the quantity is a part.
    ///
    /// For example, the quantity of water in a wine glass is a sub-quantity of the wine in that glass.
    ///
    /// gufo:isSubQuantityOf is transitive (Guizzardi, 2005, p. 184).
    ///
    /// Sub-quantities are always essential parts of their wholes. Thus, gufo:standsInQualifiedParthood is not applicable for sub-quantities."</para>
    /// labels<para>"isSubQuantityOf"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#isSubQuantityOf">http://purl.org/nemo/gufo#isSubQuantityOf</seealso>
    let isSubQuantityOf = Prefixed_Name(gufo, "isSubQuantityOf") |> PrefixedName
    /// <summary>
    ///   <para>gufo:manifestedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Event in which the gufo:Aspect is manifested.
    ///
    /// For example, the passing of an electrical current in a conductor is an event that encompasses the manifestation of an aspect inhering in a copper wire (the wire's  electrical conductivity)."</para>
    /// labels<para>"manifestedIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#manifestedIn">http://purl.org/nemo/gufo#manifestedIn</seealso>
    let manifestedIn = Prefixed_Name(gufo, "manifestedIn") |> PrefixedName
    /// <summary>
    ///   <para>gufo:mediates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:IrreflexiveProperty</para>
    ///   <para>"Identifies the endurants mediated by a gufo:Relator.
    ///
    /// For example, John and Mary's marriage mediates John and Mary."</para>
    /// labels<para>"mediates"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#mediates">http://purl.org/nemo/gufo#mediates</seealso>
    let mediates = Prefixed_Name(gufo, "mediates") |> PrefixedName
    /// <summary>
    ///   <para>gufo:participatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Event in which the gufo:Object participated.
    ///
    /// Examples include the participation of Freddy Mercury in Queen's Live Aid Concert and the participation of an airplane in a flight."</para>
    /// labels<para>"participatedIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#participatedIn">http://purl.org/nemo/gufo#participatedIn</seealso>
    let participatedIn = Prefixed_Name(gufo, "participatedIn") |> PrefixedName
    /// <summary>
    ///   <para>gufo:partitions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Type whose instances are classified by exactly one instance of the partitioning higher-order type.
    ///
    /// For example, "AnimalSpecies" gufo:partitions "Animal". Instances of "AnimalSpecies" such as "Lion", "Hiena" must be disjoint subclasses of "Animal". OWL 2 punning should be used to capture the two facets of "Lion" and "Hiena" in this example: (i) as instances of "AnimalSpecies", and (ii) as  subclasses of "Animal".
    ///
    /// Note that the partitioned type (in the example "Animal") may or may not be declared to be a disjoint union of the explicitly enumerated subclasses (such as "Lion", "Hiena"). This is because other instances of the higher-order type ("AnimalSpecies") may exist that are not explicitly enumerated in the ontology.
    ///
    /// The partitioned type is termed the "base type" in the "powertype pattern" see Carvalho et al (2017), the higher-order type is often called the "powertype".
    ///
    /// For further details and formalization of "partitioning", see Carvalho et al (2017) which combines UFO with MLT (a multi-level modeling theory).
    ///
    /// V. A. Carvalho, J. P. A. Almeida, C. M. Fonseca, and G. Guizzardi, “Multi-level ontology-based conceptual modeling,” Data &amp; Knowledge Engineering, vol. 109, p. 3–24, 2017. &lt;http://dx.doi.org/10.1016/j.datak.2017.03.002&gt;"</para>
    /// labels<para>"partitions"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#partitions">http://purl.org/nemo/gufo#partitions</seealso>
    let partitions = Prefixed_Name(gufo, "partitions") |> PrefixedName
    /// <summary>
    ///   <para>gufo:standsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:Situation in which the entity stands.
    ///
    /// This implementation includes sub-properties of gufo:standsIn to identify situations concerning the attribution of (mutable) values to qualities, variable relationships, the instantiation of non-contingent types, temporary parthood and temporary constitution."</para>
    /// labels<para>"standsIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsIn">http://purl.org/nemo/gufo#standsIn</seealso>
    let standsIn = Prefixed_Name(gufo, "standsIn") |> PrefixedName

    /// <summary>
    ///   <para>gufo:standsInQualifiedAttribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:QualityValueAttributionSituation in which the endurant stands. The identified gufo:QualityValueAttributionSituation is then used with the gufo:concernsQualityValue data property or the gufo:concernsReifiedQualityValue object property to indicate a quality value attributed to the gufo:Endurant standing in the situation. This forms a pattern to represent that quality values may differ in different situations."</para>
    /// labels<para>"standsInQualifiedAttribution"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsInQualifiedAttribution">http://purl.org/nemo/gufo#standsInQualifiedAttribution</seealso>
    let standsInQualifiedAttribution =
        Prefixed_Name(gufo, "standsInQualifiedAttribution") |> PrefixedName

    /// <summary>
    ///   <para>gufo:standsInQualifiedConstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:TemporaryConstitutionSituation in which an endurant stands temporarily (as a constituent). The identified gufo:TemporaryConstitutionSituation is further related with an endurant (the whole) through the gufo:concernsConstitutedEndurant object property. This forms a pattern to represent temporary constitution, in which the relationships between constituents and constituted endurant vary in different situations.
    ///
    /// Consider, for example, a group of people (understood as a gufo:FixedCollection) constituting a band (understood as a gufo:FunctionalComplex). In this case, any change in the membership of the group (e.g., the replacement of one person) creates a different group of people. Therefore, the band's constitution can change in time, and the pattern using gufo:TemporaryConstitutionSituation is applicable."</para>
    /// labels<para>"standsInQualifiedConstitution"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsInQualifiedConstitution">http://purl.org/nemo/gufo#standsInQualifiedConstitution</seealso>
    let standsInQualifiedConstitution =
        Prefixed_Name(gufo, "standsInQualifiedConstitution") |> PrefixedName

    /// <summary>
    ///   <para>gufo:standsInQualifiedInstantiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:TemporaryInstantiationSituation in which the endurant stands. The identified gufo:TemporaryInstantiationSituation is further related with a gufo:NonRigidType through the gufo:concernsNonRigidType object property. This forms a pattern to represent the contigent instantiation of a non-rigid type by the endurant, in which case instantiation may vary in different situations."</para>
    /// labels<para>"standsInQualifiedInstantiation"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsInQualifiedInstantiation">http://purl.org/nemo/gufo#standsInQualifiedInstantiation</seealso>
    let standsInQualifiedInstantiation =
        Prefixed_Name(gufo, "standsInQualifiedInstantiation") |> PrefixedName

    /// <summary>
    ///   <para>gufo:standsInQualifiedParthood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:TemporaryParthoodSituation in which the endurant stands (as a temporary part). The identified gufo:TemporaryParthoodSituation is further related with an endurant (the whole) through the gufo:concernsTemporaryWhole object property. This forms a pattern to represent temporary parthood, in which the relationships between parts and wholes vary in different situations. In particular, this pattern is useful in case parts may be separated from their wholes, attached to other wholes, replaced."</para>
    /// labels<para>"standsInQualifiedParthood"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsInQualifiedParthood">http://purl.org/nemo/gufo#standsInQualifiedParthood</seealso>
    let standsInQualifiedParthood =
        Prefixed_Name(gufo, "standsInQualifiedParthood") |> PrefixedName

    /// <summary>
    ///   <para>gufo:standsInQualifiedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies a gufo:TemporaryRelationshipSituation in which the endurant stands. The identified gufo:TemporaryRelationshipSituation is then used with the gufo:concernsRelatedEndurant and the gufo:concernsRelationshipType object properties to indicate the related element and the type of relationship that applies. This forms a pattern to represent that relationships that may change in different situations. For example, "heavierThan" may change when the objects involved gain or lose weight.
    ///
    /// For material relations, prefer the use of gufo:Relator."</para>
    /// labels<para>"standsInQualifiedRelationship"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#standsInQualifiedRelationship">http://purl.org/nemo/gufo#standsInQualifiedRelationship</seealso>
    let standsInQualifiedRelationship =
        Prefixed_Name(gufo, "standsInQualifiedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>gufo:wasCreatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the gufo:Event which brought the gufo:Endurant into existence.
    ///
    /// For example, a musical piece is created in an act of composition (or in an event that is part of it), a piece of legislation is created in a complex legislative process.
    ///
    /// Benevides et al. (2019) only discussed creation of objects; gufo:wasCreatedIn is extended to endurants in general. Further, in that work "createdBy" required the event to "bring about" a situation in which the created object is present. We relax this requirement here, such that the object may be created and terminated in the scope of the identified gufo:Event.
    ///
    /// A. B. Benevides, J. R. Bourguet, G. Guizzardi, R. Penãloza, and J. P. A. Almeida, “Representing a reference foundational ontology of events in SROIQ,” Applied ontology, vol. 14, iss. 3, p. 293–334, 2019. &lt;http://dx.doi.org/10.3233/AO-190214&gt;"</para>
    /// labels<para>"wasCreatedIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#wasCreatedIn">http://purl.org/nemo/gufo#wasCreatedIn</seealso>
    let wasCreatedIn = Prefixed_Name(gufo, "wasCreatedIn") |> PrefixedName
    /// <summary>
    ///   <para>gufo:wasTerminatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies the gufo:Event in which the gufo:Endurant was brought to an end.
    ///
    /// For example, the Space Shuttle Challenger (OV-099) (a gufo:FunctionalComplex) was destroyed during the launch of its tenth flight (a gufo:Event).
    ///
    /// Benevides et al. (2019) only discussed termination of objects; gufo:wasCreatedIn is extended to endurants in general. This means that a gufo:Relator (such as a marriage) can be declared terminated. Further, in that work "terminatedBy" required the event to be "triggered" by a situation in which the terminated object is present. We relax this requirement here, such that the object may be created and terminated in the scope of the identified gufo:Event.
    ///
    /// A. B. Benevides, J. R. Bourguet, G. Guizzardi, R. Penãloza, and J. P. A. Almeida, “Representing a reference foundational ontology of events in SROIQ,” Applied ontology, vol. 14, iss. 3, p. 293–334, 2019. &lt;http://dx.doi.org/10.3233/AO-190214&gt;"</para>
    /// labels<para>"wasTerminatedIn"</para></remarks>
    /// <seealso href="http://purl.org/nemo/gufo#wasTerminatedIn">http://purl.org/nemo/gufo#wasTerminatedIn</seealso>
    let wasTerminatedIn = Prefixed_Name(gufo, "wasTerminatedIn") |> PrefixedName
