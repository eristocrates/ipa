namespace https.w3id.org.emmo.hash

open DoxAletheia.Rdf_Vocabulary

module emmo =
    let _namespace_name = "https://w3id.org/emmo#"

    /// <summary>
    /// An object which is instrumental for reaching a particular purpose through its characteristic functioning process, with particular reference to mechanical or electronic equipment.
    /// <see href="https://w3id.org/emmo#EMMO_494b372c_cfdf_47d3_a4de_5e037c540de8"></see></summary>
    let EMMO_494b372c_cfdf_47d3_a4de_5e037c540de8 =
        Namespaced_IRI.parse _namespace_name "EMMO_494b372c_cfdf_47d3_a4de_5e037c540de8" |> NamespacedName

    /// <summary>
    /// Definitions are usually taken from Wiktionary.
    /// The etymology annotation explains the origin of a word and the historical development of its meaning.
    /// <see href="https://w3id.org/emmo#EMMO_705f27ae_954c_4f13_98aa_18473fc52b25"></see></summary>
    let EMMO_705f27ae_954c_4f13_98aa_18473fc52b25 =
        Namespaced_IRI.parse _namespace_name "EMMO_705f27ae_954c_4f13_98aa_18473fc52b25" |> NamespacedName

    /// <summary>
    /// A comment can be addressed to facilitate interpretation, to suggest possible usage, to clarify the concepts behind each entity with respect to other ontological apporaches.
    /// A text that add some information about the entity.
    /// <see href="https://w3id.org/emmo#EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f"></see></summary>
    let EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f =
        Namespaced_IRI.parse _namespace_name "EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f" |> NamespacedName

    /// <summary>
    /// (according to DIN 8200) Shot peening to generate residual compressive stresses in layers of the blasting material close to the surface in order to improve certain component properties, e.g. fatigue strength, corrosion resistance, wear resistance (from: DIN 8200:1982)
    /// <see href="https://w3id.org/emmo#EMMO_dc0874e8_36e1_44df_947d_0d7c81167a09"></see></summary>
    let EMMO_dc0874e8_36e1_44df_947d_0d7c81167a09 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc0874e8_36e1_44df_947d_0d7c81167a09" |> NamespacedName

    /// <summary>
    /// A 'Sign' that stands for an 'Object' due to causal continguity.
    /// <see href="https://w3id.org/emmo#EMMO_0cd58641_824c_4851_907f_f4c3be76630c"></see></summary>
    let EMMO_0cd58641_824c_4851_907f_f4c3be76630c =
        Namespaced_IRI.parse _namespace_name "EMMO_0cd58641_824c_4851_907f_f4c3be76630c" |> NamespacedName

    /// <summary>
    /// The universe is considered as a causally self-connected object, encompassing all other objects. For this reason is unique.
    /// <see href="https://w3id.org/emmo#EMMO_08cb807c_e626_447b_863f_e2835540e918"></see></summary>
    let EMMO_08cb807c_e626_447b_863f_e2835540e918 =
        Namespaced_IRI.parse _namespace_name "EMMO_08cb807c_e626_447b_863f_e2835540e918" |> NamespacedName

    /// <summary>
    /// The primitive relation that express the concept of an entity being part of another one.
    /// All other mereology relations can be defined in FOL using hasPart as primitive.
    /// <see href="https://w3id.org/emmo#EMMO_17e27c22_37e1_468c_9dd7_95e137f73e7f"></see></summary>
    let EMMO_17e27c22_37e1_468c_9dd7_95e137f73e7f =
        Namespaced_IRI.parse _namespace_name "EMMO_17e27c22_37e1_468c_9dd7_95e137f73e7f" |> NamespacedName

    /// <summary>
    /// x isNotCauseOf y iff not(x isCauseOf y)
    /// <see href="https://w3id.org/emmo#EMMO_01e5766d_dac3_4574_8a78_310de92a5c9d"></see></summary>
    let EMMO_01e5766d_dac3_4574_8a78_310de92a5c9d =
        Namespaced_IRI.parse _namespace_name "EMMO_01e5766d_dac3_4574_8a78_310de92a5c9d" |> NamespacedName

    /// <summary>
    /// A causal relation between the y effected and the x causing entities with intermediaries, where x isCauseOf y and not(y isCauseOf x).
    /// <see href="https://w3id.org/emmo#EMMO_3733bd38_ca2b_4264_a92a_3075a1715598"></see></summary>
    let EMMO_3733bd38_ca2b_4264_a92a_3075a1715598 =
        Namespaced_IRI.parse _namespace_name "EMMO_3733bd38_ca2b_4264_a92a_3075a1715598" |> NamespacedName

    /// <summary>
    /// Discrete data that are decoded as a sequence of 1/0, or true/false, or on/off.
    /// <see href="https://w3id.org/emmo#EMMO_4db96fb7_e9e0_466d_942b_f6f17bfdc145"></see></summary>
    let EMMO_4db96fb7_e9e0_466d_942b_f6f17bfdc145 =
        Namespaced_IRI.parse _namespace_name "EMMO_4db96fb7_e9e0_466d_942b_f6f17bfdc145" |> NamespacedName

    /// <summary>
    /// The class of all the OWL individuals representing world entities according to EMMO conceptualisation.
    /// The EMMO conceptualises the world using the primitive concepts of causality and parthood. Parthood is about the composition of world entities starting from other more fundamental entities. Causality is about the interactions between world entities.
    /// The quantum is the smallest indivisible part of any world entity. Quantum individuals are the fundamental causal constituents of the universe, since it is implied that causality originates from quantum-to-quantum interactions. Quantums are no-dimensional, and their aggregation makes spacetime emerge from their causal structure. Causality between macro entities (i.e. entities made of more than one quantum) is explained as the sum of the causality relations between their quantum constituents. Fundamental interactions (quantum fields) are represented as symmetric causality between macro entities, while classical interactions are mediated by chain of quantums (i.e. elementary particles).
    /// The fundamental distinction between world entities is direct causality self-connectedness: a world entity can be self-connected xor not self-connected depending on the causality network of its fundamental components.
    /// Void regions do not exist in the EMMO, or in other words there is no spacetime without entities, since space and time are measured quantities following a causality relation between entities (spacetime emerges as relational property not as a self-standing entity).
    /// Entities are not placed in space or time: space and time are always relative between entities and are measured. In other words, space and time relations originates from causality interactions.
    /// The disjoint union of the fundamental mereocausal classes of Quantum, CausalPath, CausalSystem and Collection.
    /// EMMO entities dimensionality is related to their mereocausal structures. From the no-dimensional quantum entity, we introduce time dimension with the elementary concept, and the spacetime with the causal system concept.
    /// The EMMO conceptualisation does not allow the existence of space without a temporal dimension, the latter coming from a causal relation between entities.
    /// For this reason, the EMMO entities that are not quantum or elementaries, may be considered to be always spatiotemporal. The EMMO poses no constraints to the number of spatial dimensions for a causal system (except being higher than one).
    /// <see href="https://w3id.org/emmo#EMMO_802d3e92_8770_4f98_a289_ccaaab7fdddf"></see></summary>
    let EMMO_802d3e92_8770_4f98_a289_ccaaab7fdddf =
        Namespaced_IRI.parse _namespace_name "EMMO_802d3e92_8770_4f98_a289_ccaaab7fdddf" |> NamespacedName

    /// <summary>
    /// Machining with a circular cutting movement, usually associated with a multi-toothed tool, and with a feed movement perpendicular or oblique to the axis of rotation of the tool, to produce any workpiece surface.
    /// <see href="https://w3id.org/emmo#EMMO_44f91d47_3faf_48e2_844c_d44bbe3e22f6"></see></summary>
    let EMMO_44f91d47_3faf_48e2_844c_d44bbe3e22f6 =
        Namespaced_IRI.parse _namespace_name "EMMO_44f91d47_3faf_48e2_844c_d44bbe3e22f6" |> NamespacedName

    /// <summary>
    /// Strengthening by rolling is the strengthening of component surfaces by mechanically generating compressive stresses in the component surface and consolidating the material.
    /// <see href="https://w3id.org/emmo#EMMO_607ccc15_38aa_4a69_a70a_effa8015bf42"></see></summary>
    let EMMO_607ccc15_38aa_4a69_a70a_effa8015bf42 =
        Namespaced_IRI.parse _namespace_name "EMMO_607ccc15_38aa_4a69_a70a_effa8015bf42" |> NamespacedName

    /// <summary>
    /// The process of transforming precursor objects (e.g. raw materials) into a product by the use of manual labor, machinery or chemical/biological processes.
    /// Deals with entities that have a defined shape.
    /// <see href="https://w3id.org/emmo#EMMO_a4d66059_5dd3_4b90_b4cb_10960559441b"></see></summary>
    let EMMO_a4d66059_5dd3_4b90_b4cb_10960559441b =
        Namespaced_IRI.parse _namespace_name "EMMO_a4d66059_5dd3_4b90_b4cb_10960559441b" |> NamespacedName

    /// <summary>
    /// A manufacturing with an output that is an object with a specific function, shape, or intended use, not simply a material.
    /// <see href="https://w3id.org/emmo#EMMO_8786cb47_8e1f_4968_9b15_f6d41fc51252"></see></summary>
    let EMMO_8786cb47_8e1f_4968_9b15_f6d41fc51252 =
        Namespaced_IRI.parse _namespace_name "EMMO_8786cb47_8e1f_4968_9b15_f6d41fc51252" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3ec45f3b_677d_4e71_be75_6f8966b4f808"></see>
    /// </summary>
    let EMMO_3ec45f3b_677d_4e71_be75_6f8966b4f808 =
        Namespaced_IRI.parse _namespace_name "EMMO_3ec45f3b_677d_4e71_be75_6f8966b4f808" |> NamespacedName

    /// <summary>
    /// An object that has been designed and manufactured for a particular purpose.
    /// <see href="https://w3id.org/emmo#EMMO_86ca9b93_1183_4b65_81b8_c0fcd3bba5ad"></see></summary>
    let EMMO_86ca9b93_1183_4b65_81b8_c0fcd3bba5ad =
        Namespaced_IRI.parse _namespace_name "EMMO_86ca9b93_1183_4b65_81b8_c0fcd3bba5ad" |> NamespacedName

    /// <summary>
    /// A perspective in which entities are represented according to the variation of their properties.
    /// A data is a causal object whose variations (non-uniformity) can be recognised and eventually interpreted.
    /// A data can be of different physical types (e.g., matter, wave, atomic excited states).
    /// How the variations are recognised and eventually decoded depends on the interpreting rules that characterise that type of data.
    /// Variations are pure physical variations and do not necessarily possess semantic meaning.
    /// <see href="https://w3id.org/emmo#EMMO_1e877c70_3b01_45a8_a8f6_8ce4f6a24660"></see></summary>
    let EMMO_1e877c70_3b01_45a8_a8f6_8ce4f6a24660 =
        Namespaced_IRI.parse _namespace_name "EMMO_1e877c70_3b01_45a8_a8f6_8ce4f6a24660" |> NamespacedName

    /// <summary>
    /// Draw forming by drawing a workpiece through a tool opening that is narrowed in the drawing direction.
    /// <see href="https://w3id.org/emmo#EMMO_01048432_3722_40a9_aa37_ea009da44272"></see></summary>
    let EMMO_01048432_3722_40a9_aa37_ea009da44272 =
        Namespaced_IRI.parse _namespace_name "EMMO_01048432_3722_40a9_aa37_ea009da44272" |> NamespacedName

    /// <summary>
    /// A collection is the concept that complements the item concept, being an entity that possesses at least one part non directly causally connected with the rest.
    /// A collection can be partitioned in maximally connected items called members. The members are self-connected entities and there is no direct causality relation between them.
    /// The combination of collection and item concepts is the EMMO mereocausality alternative to set theory. However, two items can be members only if they are non direct causally connected, giving some constraints to a collection definition. For example, two entities which are directly connected cannot be two distinct members, while their interiors (i.e. the entities obtained by removing the layer of parts that provides the causal contact between them) can be.
    /// The class of not direct causally self-connected world entities.
    /// <see href="https://w3id.org/emmo#EMMO_2d2ecd97_067f_4d0e_950c_d746b7700a31"></see></summary>
    let EMMO_2d2ecd97_067f_4d0e_950c_d746b7700a31 =
        Namespaced_IRI.parse _namespace_name "EMMO_2d2ecd97_067f_4d0e_950c_d746b7700a31" |> NamespacedName

    /// <summary>
    /// Sintering is the process of forming a solid mass of material through heat and pressure without melting to the point of liquefaction. This process involves the atoms in materials diffusing across the particle boundaries and fusing together into one piece.
    /// Sintering occurs naturally in mineral deposits, and is used as a manufacturing process for materials including ceramics, metals and plastics.
    /// Because the sintering temperature doesn’t reach the materials’ melting point, it is often used for materials with high melting points, such as molybdenum and tungsten.
    /// <see href="https://w3id.org/emmo#EMMO_03441eb3_d1fd_4906_b953_b83312d7589e"></see></summary>
    let EMMO_03441eb3_d1fd_4906_b953_b83312d7589e =
        Namespaced_IRI.parse _namespace_name "EMMO_03441eb3_d1fd_4906_b953_b83312d7589e" |> NamespacedName

    /// <summary>
    /// An elucidation should address the real world entities using the concepts introduced by the conceptualisation annotation.
    /// Short enlightening explanation aimed to facilitate the user in drawing the connection (interpretation) between a OWL entity and the real world object(s) for which it stands.
    /// <see href="https://w3id.org/emmo#EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9"></see></summary>
    let EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 =
        Namespaced_IRI.parse _namespace_name "EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9" |> NamespacedName

    /// <summary>
    /// An Internationalized Resource Identifier (IRI) is a compact sequence of characters that identifies an abstract or physical resource. It is similar to URI, but greatly extends the allowed character set from ASCII to the Universal Character Set (Unicode/ISO 10646)..
    /// IRIs are commonly used as identifiers for ontological entities, although the extended unicode character set is rarely used.
    /// <see href="https://w3id.org/emmo#EMMO_5c15f8c4_d2de_47a0_acdd_470b8dda979b"></see></summary>
    let EMMO_5c15f8c4_d2de_47a0_acdd_470b8dda979b =
        Namespaced_IRI.parse _namespace_name "EMMO_5c15f8c4_d2de_47a0_acdd_470b8dda979b" |> NamespacedName

    /// <summary>
    /// A property is atomic in the sense that is aimed to deliver one and one only aspect of the object according to one code, such as the color with one sign (e.g., black) or a quantitiative property (e.g., 1.4 kg).
    /// A coded that makes use of an atomic symbol with respect to the code used to refer to the interaction.
    /// <see href="https://w3id.org/emmo#EMMO_b7bcff25_ffc3_474e_9ab5_01b1664bd4ba"></see></summary>
    let EMMO_b7bcff25_ffc3_474e_9ab5_01b1664bd4ba =
        Namespaced_IRI.parse _namespace_name "EMMO_b7bcff25_ffc3_474e_9ab5_01b1664bd4ba" |> NamespacedName

    /// <summary>
    /// The superclass of entities which are defined by requiring the existence of some parts (at least one) of specifically given types, where the specified types are different with respect to the type of the whole.
    /// A whole is categorized as fundamental (or maximal) or redundant (non-maximal).
    /// A whole is always defined using a criterion expressed through the classical transitive parthood relation.
    /// This class is expected to host the definition of world objects as they appear in its wholeness, dependently on some of their parts and independently on the surroundings.
    /// <see href="https://w3id.org/emmo#EMMO_1efe8b96_e006_4a33_bc9a_421406cbb9f0"></see></summary>
    let EMMO_1efe8b96_e006_4a33_bc9a_421406cbb9f0 =
        Namespaced_IRI.parse _namespace_name "EMMO_1efe8b96_e006_4a33_bc9a_421406cbb9f0" |> NamespacedName

    /// <summary>
    /// A determination of an object without any actual interaction.
    /// <see href="https://w3id.org/emmo#EMMO_1c0b22a2_be82_4fa8_9e2b_a569a625d442"></see></summary>
    let EMMO_1c0b22a2_be82_4fa8_9e2b_a569a625d442 =
        Namespaced_IRI.parse _namespace_name "EMMO_1c0b22a2_be82_4fa8_9e2b_a569a625d442" |> NamespacedName

    /// <summary>
    /// The class of individuals standing for quantum or causally self-connected world entities.
    /// A world entity is direct causally self-connected if any two parts that make up the whole are direct causally connected to each other. In the EMMO, topological connectivity is based on causality.
    /// All physical objects, i.e. entities whose behaviour is explained by physics laws, are represented only by items. In other words, a physical object part is embedded in a direct causal graph that provides always a path between two of its parts.
    /// Members of a collection lack such direct causality connection, i.e. they do not constitute a physical object.
    /// Following graph theory concepts, the quantums of an item are all connected together within a network of causal relations, forming a connected causal graph. A collection is then a set of disconnected graphs.
    /// The disjoint union of Particle and CausalStructure classes.
    /// The concept of self-connectivity is applied using a 4D approach. Given that, the entity made of an electron and a proton that travel, interact, and then depart from each other is an item, since we don't focus only on the beginning or the end stage but to the overall 4D entity, being the interaction the connectivity bridge between the two particles.
    /// <see href="https://w3id.org/emmo#EMMO_eb3a768e_d53e_4be9_a23b_0714833c36de"></see></summary>
    let EMMO_eb3a768e_d53e_4be9_a23b_0714833c36de =
        Namespaced_IRI.parse _namespace_name "EMMO_eb3a768e_d53e_4be9_a23b_0714833c36de" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_46dc0d51_b60f_49cd_8650_9aba7be3726c"></see>
    /// </summary>
    let EMMO_46dc0d51_b60f_49cd_8650_9aba7be3726c =
        Namespaced_IRI.parse _namespace_name "EMMO_46dc0d51_b60f_49cd_8650_9aba7be3726c" |> NamespacedName

    /// <summary>
    /// A conceptualisation is the preliminary step behind each theory, preceding each logical formalisation. The readers approaching an ontology entity should first read the conceptualisation annotation to clearly understand "what we are talking about" and the accompanying terminology, and then read the elucidation.
    /// The conceptualisation annotation is a comment that helps the reader to understand how the world has been conceptualised by the ontology authors.
    /// <see href="https://w3id.org/emmo#EMMO_31252f35_c767_4b97_a877_1235076c3e13"></see></summary>
    let EMMO_31252f35_c767_4b97_a877_1235076c3e13 =
        Namespaced_IRI.parse _namespace_name "EMMO_31252f35_c767_4b97_a877_1235076c3e13" |> NamespacedName

    /// <summary>
    /// The process in which an agent works with some entities according to some existing formalised operative rules.
    /// A procedure can be considered as an intentional process with a plan.
    /// The set of established forms or methods of an organized body for accomplishing a certain task or tasks (Wiktionary).
    /// <see href="https://w3id.org/emmo#EMMO_472a0ca2_58bf_4618_b561_6fe68bd9fd49"></see></summary>
    let EMMO_472a0ca2_58bf_4618_b561_6fe68bd9fd49 =
        Namespaced_IRI.parse _namespace_name "EMMO_472a0ca2_58bf_4618_b561_6fe68bd9fd49" |> NamespacedName

    /// <summary>
    /// Process for removing unwanted residual or waste material from a given product or material
    /// <see href="https://w3id.org/emmo#EMMO_92eaefcb_50be_4237_9ec0_4a019ce24921"></see></summary>
    let EMMO_92eaefcb_50be_4237_9ec0_4a019ce24921 =
        Namespaced_IRI.parse _namespace_name "EMMO_92eaefcb_50be_4237_9ec0_4a019ce24921" |> NamespacedName

    /// <summary>
    /// A language object is a discrete data entity respecting specific language syntactic rules (a well-formed formula).
    /// <see href="https://w3id.org/emmo#EMMO_d8d2144e_5c8d_455d_a643_5caf4d8d9df8"></see></summary>
    let EMMO_d8d2144e_5c8d_455d_a643_5caf4d8d9df8 =
        Namespaced_IRI.parse _namespace_name "EMMO_d8d2144e_5c8d_455d_a643_5caf4d8d9df8" |> NamespacedName

    /// <summary>
    /// esce workpiece
    /// Has shaped bodies as input and output.
    /// The processing of a material aimed to transform its structure by means of any type of treatment, without involving relevant synthesis phenomena.
    /// <see href="https://w3id.org/emmo#EMMO_fc859d37_408d_44b6_b345_a0ea0b65121e"></see></summary>
    let EMMO_fc859d37_408d_44b6_b345_a0ea0b65121e =
        Namespaced_IRI.parse _namespace_name "EMMO_fc859d37_408d_44b6_b345_a0ea0b65121e" |> NamespacedName

    /// <summary>
    /// An heterogenous object made of different graphical object parts.
    /// <see href="https://w3id.org/emmo#EMMO_ccdc1a41_6e96_416b_92ec_efe67917434a"></see></summary>
    let EMMO_ccdc1a41_6e96_416b_92ec_efe67917434a =
        Namespaced_IRI.parse _namespace_name "EMMO_ccdc1a41_6e96_416b_92ec_efe67917434a" |> NamespacedName

    /// <summary>
    /// All or part of the programs, procedures, rules, and associated documentation of an information processing system.
    /// Software is usually used as a generic term for programs. However, in its broadest sense it can refer to all information (i.e., both programs and data) in electronic form and can provide a distinction from hardware, which refers to computers or other electronic systems on which software can exist and be use.
    /// Here we explicitly include in the definition also all the data (e.g. source code, script files) that takes part to the building of the executable, are necessary to the execution of a program or that document it for the users.
    /// <see href="https://w3id.org/emmo#EMMO_8681074a_e225_4e38_b586_e85b0f43ce38"></see></summary>
    let EMMO_8681074a_e225_4e38_b586_e85b0f43ce38 =
        Namespaced_IRI.parse _namespace_name "EMMO_8681074a_e225_4e38_b586_e85b0f43ce38" |> NamespacedName

    /// <summary>
    /// application of scientific knowledge, tools, techniques, crafts or systems in order to solve a problem or to achieve an objective which can result in a product or process
    /// Class that includes the application of scientific knowledge, tools and techniques in order to transform a precursor object (ex. conversion of material) following a practic purpose.
    /// Technology refers to methods, systems, and devices which are the result of scientific knowledge being used for practical purposes.
    /// Conversion of materials and assembly of components for the manufacture of products
    /// Technology is the application of knowledge for achieving practical goals in a reproducible way.
    /// application of scientific knowledge, tools, techniques, crafts, systems or methods of organization in order to solve a problem or achieve an objective
    /// <see href="https://w3id.org/emmo#EMMO_2b9cbfb5_dbd0_4a68_9c6f_acc41b40dd72"></see></summary>
    let EMMO_2b9cbfb5_dbd0_4a68_9c6f_acc41b40dd72 =
        Namespaced_IRI.parse _namespace_name "EMMO_2b9cbfb5_dbd0_4a68_9c6f_acc41b40dd72" |> NamespacedName

    /// <summary>
    /// A material is a crystal if it has essentially a sharp diffraction pattern.
    ///
    /// A solid is a crystal if it has essentially a sharp diffraction pattern. The word essentially means that most of the intensity of the diffraction is concentrated in relatively sharp Bragg peaks, besides the always present diffuse scattering. In all cases, the positions of the diffraction peaks can be expressed by
    ///
    ///
    /// H=∑ni=1hia∗i  (n≥3)
    /// <see href="https://w3id.org/emmo#EMMO_0bb3b434_73aa_428f_b4e8_2a2468648e19"></see></summary>
    let EMMO_0bb3b434_73aa_428f_b4e8_2a2468648e19 =
        Namespaced_IRI.parse _namespace_name "EMMO_0bb3b434_73aa_428f_b4e8_2a2468648e19" |> NamespacedName

    /// <summary>
    /// A relation that connects the interpreter to the semiotic object in a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_f2fc1ce9_cc3b_4eb5_a112_3c85d1b1374a"></see></summary>
    let EMMO_f2fc1ce9_cc3b_4eb5_a112_3c85d1b1374a =
        Namespaced_IRI.parse _namespace_name "EMMO_f2fc1ce9_cc3b_4eb5_a112_3c85d1b1374a" |> NamespacedName

    /// <summary>
    /// Free forming is pressure forming with tools that do not or only partially contain the shape of the workpiece and move against each other.
    /// Non la metterei
    /// Printing forms with tools that do not or only partially contain the shape of the workpiece and move against each other. The workpiece shape is created by free or fixed relative movement between the tool and the workpiece (kinematic shape generation).
    /// <see href="https://w3id.org/emmo#EMMO_7432b843_cfd2_4345_a3d2_eaa539b27e61"></see></summary>
    let EMMO_7432b843_cfd2_4345_a3d2_eaa539b27e61 =
        Namespaced_IRI.parse _namespace_name "EMMO_7432b843_cfd2_4345_a3d2_eaa539b27e61" |> NamespacedName

    /// <summary>
    /// A matter object throughout which all physical properties of a material are essentially uniform.
    /// In the physical sciences, a phase is a region of space (a thermodynamic system), throughout which all physical properties of a material are essentially uniform. Examples of physical properties include density, index of refraction, magnetization and chemical composition. A simple description is that a phase is a region of material that is chemically uniform, physically distinct, and (often) mechanically separable. In a system consisting of ice and water in a glass jar, the ice cubes are one phase, the water is a second phase, and the humid air is a third phase over the ice and water. The glass of the jar is another separate phase.
    ///
    /// The term phase is sometimes used as a synonym for state of matter, but there can be several immiscible phases of the same state of matter. Also, the term phase is sometimes used to refer to a set of equilibrium states demarcated in terms of state variables such as pressure and temperature by a phase boundary on a phase diagram. Because phase boundaries relate to changes in the organization of matter, such as a change from liquid to solid or a more subtle change from one crystal structure to another, this latter usage is similar to the use of "phase" as a synonym for state of matter. However, the state of matter and phase diagram usages are not commensurate with the formal definition given above and the intended meaning must be determined in part from the context in which the term is used.
    /// <see href="https://w3id.org/emmo#EMMO_668fbd5b_6f1b_405c_9c6b_d6067bd0595a"></see></summary>
    let EMMO_668fbd5b_6f1b_405c_9c6b_d6067bd0595a =
        Namespaced_IRI.parse _namespace_name "EMMO_668fbd5b_6f1b_405c_9c6b_d6067bd0595a" |> NamespacedName

    /// <summary>
    /// URL to corresponding Wikipedia entry.
    /// <see href="https://w3id.org/emmo#EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d"></see></summary>
    let EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d =
        Namespaced_IRI.parse _namespace_name "EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d" |> NamespacedName

    /// <summary>
    /// A building or group of buildings where goods are manufactured or assembled.
    /// <see href="https://w3id.org/emmo#EMMO_02122e58_e0b3_4274_bdd4_745f64a61645"></see></summary>
    let EMMO_02122e58_e0b3_4274_bdd4_745f64a61645 =
        Namespaced_IRI.parse _namespace_name "EMMO_02122e58_e0b3_4274_bdd4_745f64a61645" |> NamespacedName

    /// <summary>
    /// An holistic system of people that has its own functions with responsibilities, authorities and relationships to achieve its objectives.
    /// <see href="https://w3id.org/emmo#EMMO_c0f72631_d7c2_434c_9c26_5c44123df682"></see></summary>
    let EMMO_c0f72631_d7c2_434c_9c26_5c44123df682 =
        Namespaced_IRI.parse _namespace_name "EMMO_c0f72631_d7c2_434c_9c26_5c44123df682" |> NamespacedName

    /// <summary>
    /// The subject of condensed matter physics that deals with the macroscopic and microscopic physical properties of matter, especially the solid and liquid phases which arise from electromagnetic forces between atoms. More generally, the subject deals with "condensed" phases of matter: systems of many constituents with strong interactions between them.
    /// <see href="https://w3id.org/emmo#EMMO_220b7201_d277_4dca_bf6a_5a5e2c4062dd"></see></summary>
    let EMMO_220b7201_d277_4dca_bf6a_5a5e2c4062dd =
        Namespaced_IRI.parse _namespace_name "EMMO_220b7201_d277_4dca_bf6a_5a5e2c4062dd" |> NamespacedName

    /// <summary>
    /// Nailing is joining by hammering or pressing nails (wire pins) as auxiliary parts into the solid material. Several parts are joined by pressing them together (from: DIN 8593 part 3/09.85).
    /// <see href="https://w3id.org/emmo#EMMO_4f46c5ab_1c21_4639_90d5_3c4ebf3b156b"></see></summary>
    let EMMO_4f46c5ab_1c21_4639_90d5_3c4ebf3b156b =
        Namespaced_IRI.parse _namespace_name "EMMO_4f46c5ab_1c21_4639_90d5_3c4ebf3b156b" |> NamespacedName

    /// <summary>
    /// heat treatment consisting of heating and soaking at a suitable temperature, followed by cooling under conditions such that, after return to ambient temperature, the metal will be in a structural state closer to that of equilibrium
    /// <see href="https://w3id.org/emmo#EMMO_9900d51c_bdd3_40e8_aa82_ad1aa7092f71"></see></summary>
    let EMMO_9900d51c_bdd3_40e8_aa82_ad1aa7092f71 =
        Namespaced_IRI.parse _namespace_name "EMMO_9900d51c_bdd3_40e8_aa82_ad1aa7092f71" |> NamespacedName

    /// <summary>
    /// An interpreter who establish the connection between an icon an an object recognizing their resemblance (e.g. logical, pictorial)
    /// <see href="https://w3id.org/emmo#EMMO_19608340_178c_4bfd_bd4d_0d3b935c6fec"></see></summary>
    let EMMO_19608340_178c_4bfd_bd4d_0d3b935c6fec =
        Namespaced_IRI.parse _namespace_name "EMMO_19608340_178c_4bfd_bd4d_0d3b935c6fec" |> NamespacedName

    /// <summary>
    /// A collective term for the processes in which, during joining, the parts to be joined and any auxiliary parts are essentially only elastically deformed and unintentional loosening is prevented by frictional connection.
    /// <see href="https://w3id.org/emmo#EMMO_bbf12904_e25e_4f49_87f3_8bd210a6b535"></see></summary>
    let EMMO_bbf12904_e25e_4f49_87f3_8bd210a6b535 =
        Namespaced_IRI.parse _namespace_name "EMMO_bbf12904_e25e_4f49_87f3_8bd210a6b535" |> NamespacedName

    /// <summary>
    /// The causal path class can be defined univocally in FOL.
    /// The class of entities that possess a temporal structure but no spatial structure.
    /// A causal chain is an ordered causal sequence of entities that does not host any bifurcation within itself (a chain). A chain can only be partitioned in time.
    /// <see href="https://w3id.org/emmo#EMMO_0f795e3e_c602_4577_9a43_d5a231aa1360"></see></summary>
    let EMMO_0f795e3e_c602_4577_9a43_d5a231aa1360 =
        Namespaced_IRI.parse _namespace_name "EMMO_0f795e3e_c602_4577_9a43_d5a231aa1360" |> NamespacedName

    /// <summary>
    /// A characterisation of an object with an actual interaction.
    /// <see href="https://w3id.org/emmo#EMMO_3b19eab4_79be_4b02_bdaf_ecf1f0067a68"></see></summary>
    let EMMO_3b19eab4_79be_4b02_bdaf_ecf1f0067a68 =
        Namespaced_IRI.parse _namespace_name "EMMO_3b19eab4_79be_4b02_bdaf_ecf1f0067a68" |> NamespacedName

    /// <summary>
    /// A definition univocally determines a OWL entity using necessary and sufficient conditions referring to other OWL entities.
    /// Precise and univocal description of an ontological entity in the framework of an axiomatic system.
    /// <see href="https://w3id.org/emmo#EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84"></see></summary>
    let EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 =
        Namespaced_IRI.parse _namespace_name "EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84" |> NamespacedName

    /// <summary>
    /// DP(x, y) ≡ PP(x, y) ∧ ∃φ[φ(x) ↔ ¬φ(y)]
    /// The superproperty of all object property relations between an entity and one of its proper parts that belongs to different taxonomical branch.
    /// <see href="https://w3id.org/emmo#EMMO_1328d112_e731_4e56_b9b9_6b6cdd495cd6"></see></summary>
    let EMMO_1328d112_e731_4e56_b9b9_6b6cdd495cd6 =
        Namespaced_IRI.parse _namespace_name "EMMO_1328d112_e731_4e56_b9b9_6b6cdd495cd6" |> NamespacedName

    /// <summary>
    /// Forming of a solid body, whereby the plastic state is essentially brought about by uniaxial or multiaxial compressive stress.
    /// lasciano tensioni residue di compressione
    /// <see href="https://w3id.org/emmo#EMMO_39d5c9c4_7d24_4409_ba3b_60ca3afde902"></see></summary>
    let EMMO_39d5c9c4_7d24_4409_ba3b_60ca3afde902 =
        Namespaced_IRI.parse _namespace_name "EMMO_39d5c9c4_7d24_4409_ba3b_60ca3afde902" |> NamespacedName

    /// <summary>
    /// It has a shape, so we conclude that it is solid
    /// A solid is defined as a portion of matter that is in a condensed state characterised by resistance to deformation and volume changes.
    /// They are not powders or threads
    /// Object that is processed with a machine
    /// powder is not workpiece because it has the shape of the recipient containing them
    /// it seems to be solid, so it has a proper shape
    /// In manufacturing, a workpiece is a single, delimited part of largely solid material that is processed in some form (e.g. stone ).
    /// A WorkPiece is physical artifact, that has a proper shape and occupyes a proper volume intended for subsequent transformation. It is a condensed state, so it is a compact body that is processed or  has to be processed.
    /// The raw material or partially finished piece that is shaped by performing various operations.
    /// it seems to be an intermediate product, that has to reach the final shape.
    /// Seems to have to be processed through mechanical deformation. So it takes part of a manufacturing process. It is a Manufactured Product and it can be a Commercial Product
    /// fili e polveri non sono compresi
    /// a physical artifact, real or virtual, intended for subsequent transformation within some manufacturing operation
    /// In physics, a rigid body (also known as a rigid object[2]) is a solid body in which deformation is zero or so small it can be neglected. The distance between any two given points on a rigid body remains constant in time regardless of external forces or moments exerted on it. A rigid body is usually considered as a continuous distribution of mass.
    /// <see href="https://w3id.org/emmo#EMMO_479db031_b344_4488_9efa_4bc12c6c1765"></see></summary>
    let EMMO_479db031_b344_4488_9efa_4bc12c6c1765 =
        Namespaced_IRI.parse _namespace_name "EMMO_479db031_b344_4488_9efa_4bc12c6c1765" |> NamespacedName

    /// <summary>
    /// A 'Perceptual' which stands for a real world object whose spatial configuration is due to an explicit graphical procedure and shows an identifiable pattern.
    /// This concept includes only things that are purposely created by an agent.
    /// <see href="https://w3id.org/emmo#EMMO_c74da218_9147_4f03_92d1_8894abca55f3"></see></summary>
    let EMMO_c74da218_9147_4f03_92d1_8894abca55f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_c74da218_9147_4f03_92d1_8894abca55f3" |> NamespacedName

    /// <summary>
    /// The class of individuals representing causal clusters.
    /// With the causal cluster term we address an heterogenous group of entities, which possess the common feature of having at least two causally non connected quanta. It comprises collections (non self-connected entities) and causal systems (entities extended in space).
    /// The disjoint union of the CausalSystem and Collection classes.
    /// <see href="https://w3id.org/emmo#EMMO_76bd5e44_bf5a_49f9_a517_eea5e8bcbc2d"></see></summary>
    let EMMO_76bd5e44_bf5a_49f9_a517_eea5e8bcbc2d =
        Namespaced_IRI.parse _namespace_name "EMMO_76bd5e44_bf5a_49f9_a517_eea5e8bcbc2d" |> NamespacedName

    /// <summary>
    /// This class is the most general superclass for the categorization of contrasts that are perceivable through a specific human-related perception mechanism. This perspective is based on human characterization of perceptions.
    /// A 'Perceptual' can stand for another object in an EMMO described semiotic process (acting as sign or as object), just like a word on a paper (the perceptual object) may refer semiotically to another object. However, a perceptual is not necessarily a 'Sign' (e.g. a line sketched on a blackboard is a recognizable 'Perceptual' but it may stand for nothing).
    /// A 'Perceptual' becomes a semiotic object, when it is part of a 'Semiotic' process described by the ontologist within the EMMO, and it's done always specifying for which interpreter this relation occurs.
    /// The class constrast individuals standing for entities that can stimulate a perception (e.g. a retina impression) to a human being and that are categorized accordingly to human perception mechanisms.
    /// <see href="https://w3id.org/emmo#EMMO_649bf97b_4397_4005_90d9_219755d92e34"></see></summary>
    let EMMO_649bf97b_4397_4005_90d9_219755d92e34 =
        Namespaced_IRI.parse _namespace_name "EMMO_649bf97b_4397_4005_90d9_219755d92e34" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3cb27225_df45_4616_aa3b_32dba383524c"></see>
    /// </summary>
    let EMMO_3cb27225_df45_4616_aa3b_32dba383524c =
        Namespaced_IRI.parse _namespace_name "EMMO_3cb27225_df45_4616_aa3b_32dba383524c" |> NamespacedName

    /// <summary>
    /// A mathematical entity based on a fundamental physics theory which defines the relations between physics quantities of an entity.
    /// <see href="https://w3id.org/emmo#EMMO_b29fd350_39aa_4af7_9459_3faa0544cba6"></see></summary>
    let EMMO_b29fd350_39aa_4af7_9459_3faa0544cba6 =
        Namespaced_IRI.parse _namespace_name "EMMO_b29fd350_39aa_4af7_9459_3faa0544cba6" |> NamespacedName

    /// <summary>
    /// A simulation that relies on physics based models, according to the Review of Materials Modelling and CWA 17284:2018.
    /// <see href="https://w3id.org/emmo#EMMO_e97af6ec_4371_4bbc_8936_34b76e33302f"></see></summary>
    let EMMO_e97af6ec_4371_4bbc_8936_34b76e33302f =
        Namespaced_IRI.parse _namespace_name "EMMO_e97af6ec_4371_4bbc_8936_34b76e33302f" |> NamespacedName

    /// <summary>
    /// The term "Uniform Resource Name" (URN) has been used historically to refer to both URIs under the "urn" scheme [RFC2141], which are required to remain globally unique and persistent even when the resource ceases to exist or becomes unavailable, and to any other URI with the properties of a name.
    /// <see href="https://w3id.org/emmo#EMMO_db99b1e5_2f34_467b_a784_d104946d9f00"></see></summary>
    let EMMO_db99b1e5_2f34_467b_a784_d104946d9f00 =
        Namespaced_IRI.parse _namespace_name "EMMO_db99b1e5_2f34_467b_a784_d104946d9f00" |> NamespacedName

    /// <summary>
    /// A 'Physical' which is a tessellation of 'State' temporal direct parts.
    /// An 'Existent' individual stands for a real world object for which the ontologist wants to provide univocal tessellation in time.
    ///
    /// By definition, the tiles are represented by 'State'-s individual.
    ///
    /// Tiles are related to the 'Existent' through temporal direct parthood, enforcing non-transitivity and inverse-functionality.
    /// 'Existent' is the EMMO class to be used for representing real world physical objects under a reductionistic perspective (i.e. objects come from the composition of sub-part objects, both in time and space).
    ///
    /// 'Existent' class collects all individuals that stand for physical objects that can be structured in well defined temporal sub-parts called states, through the temporal direct parthood relation.
    ///
    /// This class provides a first granularity hierarchy in time, and a way to axiomatize tessellation principles for a specific whole with a non-transitivity relation (direct parthood) that helps to retain the granularity levels.
    ///
    /// e.g. a car, a supersaturated gas with nucleating nanoparticles, an atom that becomes ionized and then recombines with an electron.
    /// Being hasTemporalDirectPart a proper parthood relation, there cannot be 'Existent' made of a single 'State'.
    ///
    /// Moreover, due to inverse functionality, a 'State' can be part of only one 'Existent', preventing overlapping between 'Existent'-s.
    /// <see href="https://w3id.org/emmo#EMMO_52211e5e_d767_4812_845e_eb6b402c476a"></see></summary>
    let EMMO_52211e5e_d767_4812_845e_eb6b402c476a =
        Namespaced_IRI.parse _namespace_name "EMMO_52211e5e_d767_4812_845e_eb6b402c476a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2b524942_4e3e_403a_b4ab_2b53750f3d3b"></see>
    /// </summary>
    let EMMO_2b524942_4e3e_403a_b4ab_2b53750f3d3b =
        Namespaced_IRI.parse _namespace_name "EMMO_2b524942_4e3e_403a_b4ab_2b53750f3d3b" |> NamespacedName

    /// <summary>
    /// A discrete data whose elements can be decoded as tokens from one or more alphabets, without necessarily respecting syntactic rules.
    /// A symbolic entity is not necessarily graphical (e.g. it doesn't necessarily have the physical shape of a letter), but its elements can be decoded and put in relation with an alphabet.
    /// In other words, a sequence of bit "1000010" in a RAM (a non-graphical entity) is a valid symbol since it can be decoded through ASCII rules as the letter "B". The same holds for an entity standing for the sound of a voice saying: "Hello", since it can be decomposed in discrete parts, each of them being associated to a letter of an alphabet.
    /// <see href="https://w3id.org/emmo#EMMO_057e7d57_aff0_49de_911a_8861d85cef40"></see></summary>
    let EMMO_057e7d57_aff0_49de_911a_8861d85cef40 =
        Namespaced_IRI.parse _namespace_name "EMMO_057e7d57_aff0_49de_911a_8861d85cef40" |> NamespacedName

    /// <summary>
    /// A perspective characterized by the belief that:
    /// - a whole is more than merely the sum of its parts (wholism)
    /// - the parts of a whole are interconnected in a way that can be explained only by reference to the whole (rolism).
    /// An holistic perspective considers each part of the whole as equally important, without the need to position the parts within a hierarchy (in time or space). The interest is on the whole object and on its parts (how they contribute to the whole, i.e. their roles), without going further into specifying the spatial hierarchy or the temporal position of each part.
    ///
    /// This class allows the picking of parts without necessarily going trough a rigid hierarchy of spatial compositions (e.g. body -&gt; organ -&gt; cell -&gt; molecule) or temporal composition. This is inline with the transitive nature of parthood, as it is usually defined in literature.
    ///
    /// The holistic perspective is not excluding the reductionistic perspective, on the contrary it can be considered its complement.
    /// The union of classes whole and part.
    /// <see href="https://w3id.org/emmo#EMMO_0277f24a_ea7f_4917_81b7_fb0406c8fc62"></see></summary>
    let EMMO_0277f24a_ea7f_4917_81b7_fb0406c8fc62 =
        Namespaced_IRI.parse _namespace_name "EMMO_0277f24a_ea7f_4917_81b7_fb0406c8fc62" |> NamespacedName

    /// <summary>
    /// Forming of vessel parts from a flat mould into a three-dimensional shape by means of a press and tools, whereby material is neither removed nor added
    /// <see href="https://w3id.org/emmo#EMMO_ecf78412_f0ca_4368_9078_559ffe8935d3"></see></summary>
    let EMMO_ecf78412_f0ca_4368_9078_559ffe8935d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_ecf78412_f0ca_4368_9078_559ffe8935d3" |> NamespacedName

    /// <summary>
    /// Cutting workpieces between two cutting edges that move past each other (see Figure 1 [see figure in the standard]).
    /// <see href="https://w3id.org/emmo#EMMO_1d6b63d5_9938_483c_ad62_a09ac34153c9"></see></summary>
    let EMMO_1d6b63d5_9938_483c_ad62_a09ac34153c9 =
        Namespaced_IRI.parse _namespace_name "EMMO_1d6b63d5_9938_483c_ad62_a09ac34153c9" |> NamespacedName

    /// <summary>
    /// The relation between two individuals representing entities that share at least one of their parts.
    /// <see href="https://w3id.org/emmo#EMMO_d893d373_b579_4867_841e_1c2b31a8d2c6"></see></summary>
    let EMMO_d893d373_b579_4867_841e_1c2b31a8d2c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_d893d373_b579_4867_841e_1c2b31a8d2c6" |> NamespacedName

    /// <summary>
    /// If object and sign belongs to the same class, then the sign is fuctional, diagrammatic and resemblance.
    /// For example, when a Boeing 747 is used as a sign for another Boeing 747.
    /// In Peirce semiotics three subtypes of icon are possible:
    /// (a) the image, which depends on a simple quality (e.g. picture)
    /// (b) the diagram, whose internal relations, mainly dyadic or so taken, represent by analogy the relations in something (e.g. math formula, geometric flowchart)
    /// (c) the metaphor, which represents the representative character of a sign by representing a parallelism in something else
    /// [Wikipedia]
    /// A sign that stands for an object by resembling or imitating it, in shape, function or by sharing a similar logical structure.
    /// <see href="https://w3id.org/emmo#EMMO_d7788d1a_020d_4c78_85a1_13563fcec168"></see></summary>
    let EMMO_d7788d1a_020d_4c78_85a1_13563fcec168 =
        Namespaced_IRI.parse _namespace_name "EMMO_d7788d1a_020d_4c78_85a1_13563fcec168" |> NamespacedName

    /// <summary>
    /// The interpretation of the term "matter" is not univocal. Several concepts are labelled with this term, depending on the field of science. The concept mass is sometimes related to the term "matter", even if the former refers to a physical quantity (precisely defined by modern physics) while the latter is a type that qualifies a physical entity.
    /// It is possible to identify more than one concept that can be reasonably labelled with the term "matter". For example, it is possible to label as matter only the entities that are made up of atoms. Or more generally, we can be more fine-grained and call "matter" the entities that are made up of protons, neutrons or electrons, so that we can call matter also a neutron radiation or a cathode ray.
    /// A more fundamental approach, that we embrace for the EMMO, considers matter as entities that are made of fermions (i.e. quarks and leptons) requiring their presence, without excluding particles like the W and Z bosons that possess some mass, but are not fermions.
    /// Antimatter is a subclass of matter.
    /// A matter entity requires the presence of fermions without excluding the presence of real or virtual fundamental bosons parts that are responsible for the interactions between the (real) fundamental fermions.
    /// The class of physical objects that have some fermionic quantum parts.
    /// <see href="https://w3id.org/emmo#EMMO_5b2222df_4da6_442f_8244_96e9e45887d1"></see></summary>
    let EMMO_5b2222df_4da6_442f_8244_96e9e45887d1 =
        Namespaced_IRI.parse _namespace_name "EMMO_5b2222df_4da6_442f_8244_96e9e45887d1" |> NamespacedName

    /// <summary>
    /// A topological space with the property that each point has a neighborhood that is homeomorphic to an open subset of 1-dimensional Euclidean space.
    /// One-dimensional manifolds include lines and circles, but not self-crossing curves. Two-dimensional manifolds are also called surfaces. Examples include the plane, the sphere, and the torus, and also the Klein bottle and real projective plane.
    /// <see href="https://w3id.org/emmo#EMMO_0c576e13_4ee7_4f3d_bfe9_1614243df018"></see></summary>
    let EMMO_0c576e13_4ee7_4f3d_bfe9_1614243df018 =
        Namespaced_IRI.parse _namespace_name "EMMO_0c576e13_4ee7_4f3d_bfe9_1614243df018" |> NamespacedName

    /// <summary>
    /// A path is a string of characters used to uniquely identify a location in a directory structure according to a particular convention.
    /// <see href="https://w3id.org/emmo#EMMO_e94a9156_fb6c_4e16_88ee_829ac9933155"></see></summary>
    let EMMO_e94a9156_fb6c_4e16_88ee_829ac9933155 =
        Namespaced_IRI.parse _namespace_name "EMMO_e94a9156_fb6c_4e16_88ee_829ac9933155" |> NamespacedName

    /// <summary>
    /// Mechanical separation of workpieces without the formation of shapeless material, i.e. also without chips (chipless).
    /// <see href="https://w3id.org/emmo#EMMO_d5f98475_00ce_4987_99fb_262aed395e46"></see></summary>
    let EMMO_d5f98475_00ce_4987_99fb_262aed395e46 =
        Namespaced_IRI.parse _namespace_name "EMMO_d5f98475_00ce_4987_99fb_262aed395e46" |> NamespacedName

    /// <summary>
    /// An entity that is categorized according to its relation with a whole through a parthood relation and that contributes to it according to an holistic criterion, where the type of the whole is not the type of the part.
    /// In this class the concept of role and part are superimposed (the term part is also used to define the role played by an actor).
    /// Here entities are categorized according to their relation with the whole, i.e. how they contribute to make a specific whole, and not what they are as separate entities.
    /// This class is expected to host the definition of world objects as they appear in its relation with the surrounding whole (being a part implies being surrounded by something bigger to which it contributes).
    /// <see href="https://w3id.org/emmo#EMMO_4f226cf3_6d02_4d35_8566_a9e641bc6ff3"></see></summary>
    let EMMO_4f226cf3_6d02_4d35_8566_a9e641bc6ff3 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f226cf3_6d02_4d35_8566_a9e641bc6ff3" |> NamespacedName

    /// <summary>
    /// This term is often used in a non-technical context synonymously with additive manufacturing and, in these cases, typically associated with machines used for non-industrial purposes including personal use.
    /// Fabrication of objects through the deposition of a material using a print head, nozzle or another printer technology.
    /// fabrication of objects through the deposition of a material using a print head, nozzle or another printer technology
    /// Note 1 to entry: This term is often used in a non-technical context synonymously with additive manufacturing (3.1.2) and, in these cases, typically associated with machines used for non-industrial purposes including personal use.
    /// <see href="https://w3id.org/emmo#EMMO_253e1d54_69af_4931_90d0_5ccfd7e690ad"></see></summary>
    let EMMO_253e1d54_69af_4931_90d0_5ccfd7e690ad =
        Namespaced_IRI.parse _namespace_name "EMMO_253e1d54_69af_4931_90d0_5ccfd7e690ad" |> NamespacedName

    /// <summary>
    /// Cutting with circular or straight cutting motion, using a multi-toothed tool of small cutting width, the cutting motion being performed by the tool
    /// Process of cutting a workpiece into smaller parts that are either doughter parts, samples (e.g. for testing) or scrap.
    /// <see href="https://w3id.org/emmo#EMMO_c7d004db_59fa_5ae3_adb1_e75736aa721a"></see></summary>
    let EMMO_c7d004db_59fa_5ae3_adb1_e75736aa721a =
        Namespaced_IRI.parse _namespace_name "EMMO_c7d004db_59fa_5ae3_adb1_e75736aa721a" |> NamespacedName

    /// <summary>
    /// The EMMO adheres to Atomistic General Extensional Mereology (AGEM).
    /// The superclass of all mereological EMMO relations.
    /// <see href="https://w3id.org/emmo#EMMO_3f2e4ac2_8ef3_4a14_b826_60d37f15f8ee"></see></summary>
    let EMMO_3f2e4ac2_8ef3_4a14_b826_60d37f15f8ee =
        Namespaced_IRI.parse _namespace_name "EMMO_3f2e4ac2_8ef3_4a14_b826_60d37f15f8ee" |> NamespacedName

    /// <summary>
    /// The relation between individuals representing non-overlapping entities (i.e. that have no parts in common).
    /// <see href="https://w3id.org/emmo#EMMO_aa987900_caf1_4ce2_82fa_6b1d6fbd2ead"></see></summary>
    let EMMO_aa987900_caf1_4ce2_82fa_6b1d6fbd2ead =
        Namespaced_IRI.parse _namespace_name "EMMO_aa987900_caf1_4ce2_82fa_6b1d6fbd2ead" |> NamespacedName

    /// <summary>
    /// The class of causal objects that stand for world objects according to a specific representational perspective.
    /// This class is the practical implementation of the EMMO pluralistic approach for which the only objective categorization is provided by the Universe individual and all the Quantum individuals.
    /// Between these two extremes, there are several subjective ways to categorize real world objects, each one provide under a 'Perspective' subclass.
    /// <see href="https://w3id.org/emmo#EMMO_49267eba_5548_4163_8f36_518d65b583f9"></see></summary>
    let EMMO_49267eba_5548_4163_8f36_518d65b583f9 =
        Namespaced_IRI.parse _namespace_name "EMMO_49267eba_5548_4163_8f36_518d65b583f9" |> NamespacedName

    /// <summary>
    /// The proper part relation has the following pair-covering sub-relations:
    /// - hasMembers xor hasPiece
    /// - hasPortionPart xor hasGatheredPart
    /// . hasItemPart xor hasScatteredPart
    /// The relation between an entity and one of its parts, when both entities are distinct.
    /// <see href="https://w3id.org/emmo#EMMO_9380ab64_0363_4804_b13f_3a8a94119a76"></see></summary>
    let EMMO_9380ab64_0363_4804_b13f_3a8a94119a76 =
        Namespaced_IRI.parse _namespace_name "EMMO_9380ab64_0363_4804_b13f_3a8a94119a76" |> NamespacedName

    /// <summary>
    /// EncodedData is the class where inventions that don't actually exist whould be placed.
    /// For example, the blueprint of a bridge is an encoded data. When the bridge will be built, than the blueprint will also be a semiotical entity.
    /// Another example is Superman, that exists only as a set of magazines, drawings, novels, movies, but not in the real world.
    /// A causal object whose properties variation are encoded by an agent and that can be decoded by another agent according to a specific rule.
    /// <see href="https://w3id.org/emmo#EMMO_3e7add3d_e6ed_489a_a796_8e31fef9b490"></see></summary>
    let EMMO_3e7add3d_e6ed_489a_a796_8e31fef9b490 =
        Namespaced_IRI.parse _namespace_name "EMMO_3e7add3d_e6ed_489a_a796_8e31fef9b490" |> NamespacedName

    /// <summary>
    /// machining with a circular cutting movement in which the axis of rotation of the tool and the axis of the internal surface to be produced are identical and the feed movement is in the direction of this axis. The axis of rotation of the cutting movement maintains its position relative to the workpiece independently of the feed movement (axis of rotation workpiece-bound).
    /// <see href="https://w3id.org/emmo#EMMO_c1dad83e_974f_432e_ac92_d016f2445279"></see></summary>
    let EMMO_c1dad83e_974f_432e_ac92_d016f2445279 =
        Namespaced_IRI.parse _namespace_name "EMMO_c1dad83e_974f_432e_ac92_d016f2445279" |> NamespacedName

    /// <summary>
    /// A variable is a symbolic object that stands for any other mathematical object, such as  number, a vector, a matrix, a function, the argument of a function, a set, an element of a set.
    /// <see href="https://w3id.org/emmo#EMMO_1eed0732_e3f1_4b2c_a9c4_b4e75eeb5895"></see></summary>
    let EMMO_1eed0732_e3f1_4b2c_a9c4_b4e75eeb5895 =
        Namespaced_IRI.parse _namespace_name "EMMO_1eed0732_e3f1_4b2c_a9c4_b4e75eeb5895" |> NamespacedName

    /// <summary>
    /// A measurement always implies a causal interaction between the object and the observer.
    /// An 'observation' that results in a quantitative comparison of a 'property' of an 'object' with a standard reference based on a well defined mesurement procedure.
    /// A measurement is the process of experimentally obtaining one or more measurement results that can reasonably be attributed to a quantity.
    /// <see href="https://w3id.org/emmo#EMMO_463bcfda_867b_41d9_a967_211d4d437cfb"></see></summary>
    let EMMO_463bcfda_867b_41d9_a967_211d4d437cfb =
        Namespaced_IRI.parse _namespace_name "EMMO_463bcfda_867b_41d9_a967_211d4d437cfb" |> NamespacedName

    /// <summary>
    /// A relation that connects the semiotic object to the sign in a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_60577dea_9019_4537_ac41_80b0fb563d41"></see></summary>
    let EMMO_60577dea_9019_4537_ac41_80b0fb563d41 =
        Namespaced_IRI.parse _namespace_name "EMMO_60577dea_9019_4537_ac41_80b0fb563d41" |> NamespacedName

    /// <summary>
    /// Process consisting of two steps: - first, the steel is heated in a quenching treatment to a temperature above Ac3 and then rapidly cooled in a liquid to produce a process-specific grain structure; - subsequently, the steel is heated to a specific temperature during tempering to set the desired property and cooled in air.
    /// <see href="https://w3id.org/emmo#EMMO_6fa330f7_3289_4228_81df_12ee8a9708ac"></see></summary>
    let EMMO_6fa330f7_3289_4228_81df_12ee8a9708ac =
        Namespaced_IRI.parse _namespace_name "EMMO_6fa330f7_3289_4228_81df_12ee8a9708ac" |> NamespacedName

    /// <summary>
    /// A relation connecting a sign to the interpreter in a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_4832e353_6a2d_4deb_9a5b_96989afaff2d"></see></summary>
    let EMMO_4832e353_6a2d_4deb_9a5b_96989afaff2d =
        Namespaced_IRI.parse _namespace_name "EMMO_4832e353_6a2d_4deb_9a5b_96989afaff2d" |> NamespacedName

    /// <summary>
    /// Equality is here defined following a mereological approach.
    /// The relation between two individuals representing the same entity.
    /// <see href="https://w3id.org/emmo#EMMO_6835537c_d294_4005_a770_ec9621f29ed1"></see></summary>
    let EMMO_6835537c_d294_4005_a770_ec9621f29ed1 =
        Namespaced_IRI.parse _namespace_name "EMMO_6835537c_d294_4005_a770_ec9621f29ed1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8679c7d3_fd5d_49ba_bc1f_1bb820a1f73f"></see>
    /// </summary>
    let EMMO_8679c7d3_fd5d_49ba_bc1f_1bb820a1f73f =
        Namespaced_IRI.parse _namespace_name "EMMO_8679c7d3_fd5d_49ba_bc1f_1bb820a1f73f" |> NamespacedName

    /// <summary>
    /// A physical particle with integer spin that follows Bose–Einstein statistics.
    /// <see href="https://w3id.org/emmo#EMMO_b5a5494c_83bf_44aa_a9a6_49b948e68939"></see></summary>
    let EMMO_b5a5494c_83bf_44aa_a9a6_49b948e68939 =
        Namespaced_IRI.parse _namespace_name "EMMO_b5a5494c_83bf_44aa_a9a6_49b948e68939" |> NamespacedName

    /// <summary>
    /// The superproperty of the all object property relations between a whole and its mereological parts of the same type.
    /// RP(x, y) ≡ PP(x, y) ∧ ∃φ(φ(x) ∧ φ(y))
    /// <see href="https://w3id.org/emmo#EMMO_6786b336_e982_4759_8dee_1905a4106591"></see></summary>
    let EMMO_6786b336_e982_4759_8dee_1905a4106591 =
        Namespaced_IRI.parse _namespace_name "EMMO_6786b336_e982_4759_8dee_1905a4106591" |> NamespacedName

    /// <summary>
    /// Each pair of entities in direct causality relation is either in hasNext or hasTwoWayCauseWith relation. The two are mutually exclusive.
    /// A time contact occurs when x isDirectCause y and not(y isCauseOf x).
    /// A temporal relation between two entities occurs when the two entities are in a one directional causality relation. The idea is that a temporal relation always implies a one-directional causality between two entities, leading to a asymmetric relation.
    /// This means that the causing entity can be in direct and optionally indirect causality relation with the effect entity. On the contrary, the effect entity cannot be in any causal relation (direct or indirect) with the causing entity.
    /// <see href="https://w3id.org/emmo#EMMO_499e24a5_5072_4c83_8625_fe3f96ae4a8d"></see></summary>
    let EMMO_499e24a5_5072_4c83_8625_fe3f96ae4a8d =
        Namespaced_IRI.parse _namespace_name "EMMO_499e24a5_5072_4c83_8625_fe3f96ae4a8d" |> NamespacedName

    /// <summary>
    /// Continuous or stepwise pressure forming with one or more rotating tools (rollers), without or with additional tools, e.g. plugs or mandrels, rods, guide tools
    /// <see href="https://w3id.org/emmo#EMMO_91c2db4b_83e2_4c36_aadf_453acc72e6d2"></see></summary>
    let EMMO_91c2db4b_83e2_4c36_aadf_453acc72e6d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_91c2db4b_83e2_4c36_aadf_453acc72e6d2" |> NamespacedName

    /// <summary>
    /// Screwing (screwing on, screwing in, screwing tight) is joining by pressing on by means of a self-locking thread (from: DIN 8593 Part 3/09.85).
    /// <see href="https://w3id.org/emmo#EMMO_410b5956_a06d_4370_b7df_b1bd2126fb4b"></see></summary>
    let EMMO_410b5956_a06d_4370_b7df_b1bd2126fb4b =
        Namespaced_IRI.parse _namespace_name "EMMO_410b5956_a06d_4370_b7df_b1bd2126fb4b" |> NamespacedName

    /// <summary>
    /// A quantum is the most fundamental item (both mereologically and causally) and is considered causally self-connected by definition.
    /// The quantum concept recalls the fact that there is lower epistemological limit to our knowledge of the universe, related to the uncertainity principle.
    /// Space and time emerge following the network of causal connections between quantum objects. So quantum objects are adimensional objects, that precede space and time dimensions: they are simple beings (in greek οντα).
    /// Using physics concepts, we can think the quantum as an elementary particle (e.g. an electron) in a specific state between two causal interactions.
    /// A quantum stands for an incoming or outcoming real particle in a Feynman diagram.
    /// The class of entities without proper parts.
    /// The class of the mereological and causal fundamental entities.
    /// A quantum is the EMMO mereological atomistic and causal reductionistic entity.  To avoid confusion with the concept of atom coming from physics and to underline the causal reductionistic approach, we will use the expression quantum mereology, instead of atomistic mereology.
    /// <see href="https://w3id.org/emmo#EMMO_3f9ae00e_810c_4518_aec2_7200e424cf68"></see></summary>
    let EMMO_3f9ae00e_810c_4518_aec2_7200e424cf68 =
        Namespaced_IRI.parse _namespace_name "EMMO_3f9ae00e_810c_4518_aec2_7200e424cf68" |> NamespacedName

    /// <summary>
    /// Forming of a solid body, whereby the plastic state is essentially brought about by a bending stress.
    /// <see href="https://w3id.org/emmo#EMMO_aced32dd_1a13_49b0_8d8f_c79313942d19"></see></summary>
    let EMMO_aced32dd_1a13_49b0_8d8f_c79313942d19 =
        Namespaced_IRI.parse _namespace_name "EMMO_aced32dd_1a13_49b0_8d8f_c79313942d19" |> NamespacedName

    /// <summary>
    /// Type of scratching behaviour where the scratching force and the (displacement) deflection of the scratching tip are constant over the scratching distance during the test.
    /// <see href="https://w3id.org/emmo#EMMO_f5655090_2266_41cb_b2e9_3b4569c45731"></see></summary>
    let EMMO_f5655090_2266_41cb_b2e9_3b4569c45731 =
        Namespaced_IRI.parse _namespace_name "EMMO_f5655090_2266_41cb_b2e9_3b4569c45731" |> NamespacedName

    /// <summary>
    /// Forming of a solid body, whereby the plastic state is essentially brought about by shear stress.
    /// <see href="https://w3id.org/emmo#EMMO_22744495_4f32_4a17_b189_259c644268f9"></see></summary>
    let EMMO_22744495_4f32_4a17_b189_259c644268f9 =
        Namespaced_IRI.parse _namespace_name "EMMO_22744495_4f32_4a17_b189_259c644268f9" |> NamespacedName

    /// <summary>
    /// A source code is the companion of an application, being it the entity used to generate the application list of CPU executable instructions.
    /// A programming language entity expressing a formal detailed plan of what a software is intended to do.
    /// <see href="https://w3id.org/emmo#EMMO_348d39f7_6a17_49d1_9860_9b33b69b51de"></see></summary>
    let EMMO_348d39f7_6a17_49d1_9860_9b33b69b51de =
        Namespaced_IRI.parse _namespace_name "EMMO_348d39f7_6a17_49d1_9860_9b33b69b51de" |> NamespacedName

    /// <summary>
    /// A set of instructions that tell a computer what to do.
    /// A program is a sequence of instructions understandable by a computer's central processing unit (CPU) that indicates which operations the computer should perform on a set of data.
    /// <see href="https://w3id.org/emmo#EMMO_65411b3d_c8d3_4111_86a9_a2ce0a64c647"></see></summary>
    let EMMO_65411b3d_c8d3_4111_86a9_a2ce0a64c647 =
        Namespaced_IRI.parse _namespace_name "EMMO_65411b3d_c8d3_4111_86a9_a2ce0a64c647" |> NamespacedName

    /// <summary>
    /// A tessellation (or tiling) is the covering of a surface, often a plane, using one or more geometric shapes, called tiles, with no overlaps and no gaps.
    /// A causal object that is tessellated in direct parts.
    /// <see href="https://w3id.org/emmo#EMMO_ee0466e4_780d_4236_8281_ace7ad3fc5d2"></see></summary>
    let EMMO_ee0466e4_780d_4236_8281_ace7ad3fc5d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_ee0466e4_780d_4236_8281_ace7ad3fc5d2" |> NamespacedName

    /// <summary>
    /// Free forming is pressure forming with tools that do not or only partially contain the shape of the workpiece and move against each other (from: DIN 8583 Part 3/05.70).
    /// <see href="https://w3id.org/emmo#EMMO_6800c3fd_bf5d_4a2a_8e6e_9e909eefc16c"></see></summary>
    let EMMO_6800c3fd_bf5d_4a2a_8e6e_9e909eefc16c =
        Namespaced_IRI.parse _namespace_name "EMMO_6800c3fd_bf5d_4a2a_8e6e_9e909eefc16c" |> NamespacedName

    /// <summary>
    /// This subclass of icon inspired by Peirceian category (c) the metaphor, which represents the representative character of a sign by representing a parallelism in something else.
    /// An icon that imitates one representative character of the object. It share external similarities with the object, but not necessarily the same internal logical structure.
    /// An icon that focusing WHAT the object does.
    /// <see href="https://w3id.org/emmo#EMMO_c7013b53_3071_410b_a5e4_a8d266dcdfb5"></see></summary>
    let EMMO_c7013b53_3071_410b_a5e4_a8d266dcdfb5 =
        Namespaced_IRI.parse _namespace_name "EMMO_c7013b53_3071_410b_a5e4_a8d266dcdfb5" |> NamespacedName

    /// <summary>
    /// Heat treatment process that generally produces martensite in the matrix.
    /// <see href="https://w3id.org/emmo#EMMO_7cd8a4ec_b219_498e_b696_028257163aa4"></see></summary>
    let EMMO_7cd8a4ec_b219_498e_b696_028257163aa4 =
        Namespaced_IRI.parse _namespace_name "EMMO_7cd8a4ec_b219_498e_b696_028257163aa4" |> NamespacedName

    /// <summary>
    /// Method of joining metallic materials with the aid of a molten filler metal (solder), optionally with the use of flow agents
    /// <see href="https://w3id.org/emmo#EMMO_c790c7ff_2d10_4336_94ad_4f4e173109a9"></see></summary>
    let EMMO_c790c7ff_2d10_4336_94ad_4f4e173109a9 =
        Namespaced_IRI.parse _namespace_name "EMMO_c790c7ff_2d10_4336_94ad_4f4e173109a9" |> NamespacedName

    /// <summary>
    /// A manufacturing involving the creation of long-term connection of several workpieces.
    /// The permanent joining or other bringing together of two or more workpieces of a geometric shape or of similar workpieces with shapeless material. In each case, the cohesion is created locally and increased as a whole.
    /// <see href="https://w3id.org/emmo#EMMO_6ab555fd_5803_4f03_82e8_127c01aabfea"></see></summary>
    let EMMO_6ab555fd_5803_4f03_82e8_127c01aabfea =
        Namespaced_IRI.parse _namespace_name "EMMO_6ab555fd_5803_4f03_82e8_127c01aabfea" |> NamespacedName

    /// <summary>
    /// A causal structure expresses itself in time and space thanks to the underlying causality relations between its constituent quantum entities. It must at least provide two temporal parts. The unity criterion beyond the definition of a causal structure (the most general concept of structure) is the existence of an undirected causal path between each of its parts.
    /// The class of individuals representing causally self-connected world entities.
    /// The disjoint union of Causal Path and CausalSystem classes.
    /// The most fundamental unity criterion for the definition of an structure is that:
    /// - is made of at least two quantums (a structure is not a simple entity)
    /// - all quantum parts form a causally connected graph
    /// <see href="https://w3id.org/emmo#EMMO_c5ddfdba_c074_4aa4_ad6b_1ac4942d300d"></see></summary>
    let EMMO_c5ddfdba_c074_4aa4_ad6b_1ac4942d300d =
        Namespaced_IRI.parse _namespace_name "EMMO_c5ddfdba_c074_4aa4_ad6b_1ac4942d300d" |> NamespacedName

    /// <summary>
    /// Thermal ablation is the separation of material particles in solid, liquid or gaseous state by heat processes as well as the removal of these material particles by mechanical or electromagnetic forces (from: DIN
    /// <see href="https://w3id.org/emmo#EMMO_c9f0abb6_d3e8_459e_bacc_c14ed5481998"></see></summary>
    let EMMO_c9f0abb6_d3e8_459e_bacc_c14ed5481998 =
        Namespaced_IRI.parse _namespace_name "EMMO_c9f0abb6_d3e8_459e_bacc_c14ed5481998" |> NamespacedName

    /// <summary>
    /// action to disassemble a product or a component by removing all or some of its constituent parts with the intent to salvage
    /// <see href="https://w3id.org/emmo#EMMO_c7171429_b9e3_4812_95c1_e97309370538"></see></summary>
    let EMMO_c7171429_b9e3_4812_95c1_e97309370538 =
        Namespaced_IRI.parse _namespace_name "EMMO_c7171429_b9e3_4812_95c1_e97309370538" |> NamespacedName

    /// <summary>
    /// A causal particle represents the most elementary entity in physics, being it a simple state of an elementary particle, called quantum in the EMMO, or a chain of causally connected quanta.
    /// The disjoint union of CausalPath and Quantum classes.
    /// The class of individuals representing causal particles.
    /// <see href="https://w3id.org/emmo#EMMO_52b8a39b_e5ff_46d3_b972_65bc43077a07"></see></summary>
    let EMMO_52b8a39b_e5ff_46d3_b972_65bc43077a07 =
        Namespaced_IRI.parse _namespace_name "EMMO_52b8a39b_e5ff_46d3_b972_65bc43077a07" |> NamespacedName

    /// <summary>
    /// An icon that represents the internal logical structure of the object.
    /// An icon that focus on HOW the object works.
    /// <see href="https://w3id.org/emmo#EMMO_4f2d1fcc_e20c_4479_9ad7_7a0480dd3e44"></see></summary>
    let EMMO_4f2d1fcc_e20c_4479_9ad7_7a0480dd3e44 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f2d1fcc_e20c_4479_9ad7_7a0480dd3e44" |> NamespacedName

    /// <summary>
    /// Manufacturing by separating particles of material from a solid body by non-mechanical means. Ablation refers both to the removal of layers of material and to the separation of workpiece parts. The production process of ablation is considered in its stationary instantaneous state, independently of the application of auxiliary processes necessary to initiate the process. Ablation is divided into three subgroups according to the order point of view (OGP) "process in the effective zone on the surface of the workpiece": - thermal ablation; - chemical ablation; - electrochemical ablation.
    /// <see href="https://w3id.org/emmo#EMMO_1a2cbca8_3d3b_4e2c_9a71_e39273937786"></see></summary>
    let EMMO_1a2cbca8_3d3b_4e2c_9a71_e39273937786 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a2cbca8_3d3b_4e2c_9a71_e39273937786" |> NamespacedName

    /// <summary>
    /// We say that an entity causes another if there is a quantum part of the first that is in causal relation with a quantum parts of the second.
    /// An entity cannot cause itself (causal loops are forbidden) or a part of itself. For this reasons causality between entities excludes reflexivity and prevents them to overlap.
    /// The relation between an individuals x and y, that holds if and only if:
    /// a) y having a part that is causing an effect on a part of x
    /// b) y and x are non-overlapping
    /// Each pair of causally connected entities is either in isDirectCauseOf or isIndirectCauseOf relation. The two are mutually exclusive.
    /// <see href="https://w3id.org/emmo#EMMO_d67ee67e_4fac_4676_82c9_aec361dba698"></see></summary>
    let EMMO_d67ee67e_4fac_4676_82c9_aec361dba698 =
        Namespaced_IRI.parse _namespace_name "EMMO_d67ee67e_4fac_4676_82c9_aec361dba698" |> NamespacedName

    /// <summary>
    /// URI = scheme ":" ["//" authority] path ["?" query] ["#" fragment]
    /// A Uniform Resource Identifier (URI) is a compact sequence of characters that identifies an abstract or physical resource.
    /// <see href="https://w3id.org/emmo#EMMO_6470bbfa_04a6_4360_9534_1aa18d68329b"></see></summary>
    let EMMO_6470bbfa_04a6_4360_9534_1aa18d68329b =
        Namespaced_IRI.parse _namespace_name "EMMO_6470bbfa_04a6_4360_9534_1aa18d68329b" |> NamespacedName

    /// <summary>
    /// Forming of a solid body, whereby the plastic state is essentially brought about by a bending stress
    /// <see href="https://w3id.org/emmo#EMMO_68ee441e_c89e_4391_93c3_e68fef59fe14"></see></summary>
    let EMMO_68ee441e_c89e_4391_93c3_e68fef59fe14 =
        Namespaced_IRI.parse _namespace_name "EMMO_68ee441e_c89e_4391_93c3_e68fef59fe14" |> NamespacedName

    /// <summary>
    /// process of joining materials to make parts from 3D model data, usually layer upon layer, as opposed to subtractive manufacturing (3.1.29) and formative manufacturing methodologies,
    /// <see href="https://w3id.org/emmo#EMMO_03eb9b46_8ff0_4fcd_b1a0_73f65ae7434e"></see></summary>
    let EMMO_03eb9b46_8ff0_4fcd_b1a0_73f65ae7434e =
        Namespaced_IRI.parse _namespace_name "EMMO_03eb9b46_8ff0_4fcd_b1a0_73f65ae7434e" |> NamespacedName

    /// <summary>
    /// The union of the CausalCluster and CausalStructure classes.
    /// A fusion is any entity that is made up of two or more quantum entities, regardless of the fact that they are or not self-connected.
    /// The class of individuals representing mereological fusions consisting of two or more quantum entities.
    /// <see href="https://w3id.org/emmo#EMMO_53ed8611_2cd7_4286_9ef0_36572117b963"></see></summary>
    let EMMO_53ed8611_2cd7_4286_9ef0_36572117b963 =
        Namespaced_IRI.parse _namespace_name "EMMO_53ed8611_2cd7_4286_9ef0_36572117b963" |> NamespacedName

    /// <summary>
    /// An icon that focus on WHERE/WHEN the object is, in the sense of spatial or temporal shape.
    /// An icon that mimics the spatial or temporal shape of the object.
    /// The subclass of icon inspired by Peirceian category a) the image, which depends on a simple quality (e.g. picture).
    /// <see href="https://w3id.org/emmo#EMMO_8c537c06_8e1d_4a3b_a251_1c89bb2c4790"></see></summary>
    let EMMO_8c537c06_8e1d_4a3b_a251_1c89bb2c4790 =
        Namespaced_IRI.parse _namespace_name "EMMO_8c537c06_8e1d_4a3b_a251_1c89bb2c4790" |> NamespacedName

    /// <summary>
    /// The relation between a collection and one of its item members.
    /// <see href="https://w3id.org/emmo#EMMO_6b7276a4_4b9d_440a_b577_0277539c0fc4"></see></summary>
    let EMMO_6b7276a4_4b9d_440a_b577_0277539c0fc4 =
        Namespaced_IRI.parse _namespace_name "EMMO_6b7276a4_4b9d_440a_b577_0277539c0fc4" |> NamespacedName

    /// <summary>
    /// The overall lifetime of an holistic that has been the output of an intentional process.
    /// This concepts encompass the overall lifetime of a product.
    /// Is temporaly fundamental, meaning that it can have other products as holistic spatial parts, but its holistic temporal parts are not products. In other words, the individual must encompass the whole lifetime from creation to disposal.
    /// A product can be a tangible object (e.g. a manufactured object), a process (e.g. service). It can be the outcome of a natural or an artificially driven process.
    /// It must have and initial stage of its life that is also an outcome of a intentional process.
    /// <see href="https://w3id.org/emmo#EMMO_82fc8506_1f84_4add_9683_abea077bd1e3"></see></summary>
    let EMMO_82fc8506_1f84_4add_9683_abea077bd1e3 =
        Namespaced_IRI.parse _namespace_name "EMMO_82fc8506_1f84_4add_9683_abea077bd1e3" |> NamespacedName

    /// <summary>
    /// A process occurring with the active participation of an agent that drives the process according to a specific objective (intention).
    /// <see href="https://w3id.org/emmo#EMMO_bafc17b5_9be4_4823_8bbe_ab4e90b6738c"></see></summary>
    let EMMO_bafc17b5_9be4_4823_8bbe_ab4e90b6738c =
        Namespaced_IRI.parse _namespace_name "EMMO_bafc17b5_9be4_4823_8bbe_ab4e90b6738c" |> NamespacedName

    /// <summary>
    /// An elementary particle is a causal chain of quantum entities of the same type. For example, an elementary electron is a sequence of fundamental electrons only.
    /// A chausal chain whose quantum parts are of the same standard model fundamental type.
    /// <see href="https://w3id.org/emmo#EMMO_7b79b2ac_3cf2_4d3b_8cdc_bcabb59d869e"></see></summary>
    let EMMO_7b79b2ac_3cf2_4d3b_8cdc_bcabb59d869e =
        Namespaced_IRI.parse _namespace_name "EMMO_7b79b2ac_3cf2_4d3b_8cdc_bcabb59d869e" |> NamespacedName

    /// <summary>
    /// Treatment carried out after hardening or case hardening consisting of cooling to a temperature below room temperature to complete the transformation of austenite to martensite
    /// <see href="https://w3id.org/emmo#EMMO_61846411_8c6f_410b_ae7b_8999ec18f2b2"></see></summary>
    let EMMO_61846411_8c6f_410b_ae7b_8999ec18f2b2 =
        Namespaced_IRI.parse _namespace_name "EMMO_61846411_8c6f_410b_ae7b_8999ec18f2b2" |> NamespacedName

    /// <summary>
    /// The term "Uniform Resource Locator" (URL) refers to the subset of URIs that, in addition to identifying a resource, provide a means of locating the resource by describing its primary access mechanism (e.g., its network "location").
    /// <see href="https://w3id.org/emmo#EMMO_8a8f664b_dc59_4e00_ae00_81fdf1e1d12e"></see></summary>
    let EMMO_8a8f664b_dc59_4e00_ae00_81fdf1e1d12e =
        Namespaced_IRI.parse _namespace_name "EMMO_8a8f664b_dc59_4e00_ae00_81fdf1e1d12e" |> NamespacedName

    /// <summary>
    /// Joining process by softening the surfaces to be joined, either by heat or with a solvent (swelling welding, solvent welding), and pressing the softened surfaces together.
    /// <see href="https://w3id.org/emmo#EMMO_06c415dc_ba26_407d_b596_283bd4d9a66f"></see></summary>
    let EMMO_06c415dc_ba26_407d_b596_283bd4d9a66f =
        Namespaced_IRI.parse _namespace_name "EMMO_06c415dc_ba26_407d_b596_283bd4d9a66f" |> NamespacedName

    /// <summary>
    /// Widening is tensile forming to increase the circumference of a hollow body. A distinction is made between: Widening, bulging.
    /// <see href="https://w3id.org/emmo#EMMO_214e9a99_58de_40e2_86cf_fa6aa1d180a8"></see></summary>
    let EMMO_214e9a99_58de_40e2_86cf_fa6aa1d180a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_214e9a99_58de_40e2_86cf_fa6aa1d180a8" |> NamespacedName

    /// <summary>
    /// An object that enables or facilitate an agent in the execution of a process that modifies the surrounding environment.
    /// <see href="https://w3id.org/emmo#EMMO_5c68497d_2544_4cd4_897b_1ea783c9f6fe"></see></summary>
    let EMMO_5c68497d_2544_4cd4_897b_1ea783c9f6fe =
        Namespaced_IRI.parse _namespace_name "EMMO_5c68497d_2544_4cd4_897b_1ea783c9f6fe" |> NamespacedName

    /// <summary>
    /// Heat to a temperature appropriate for the particular material, maintain at that temperature and then cool at an appropriate rate to reduce hardness, improve machinability or achieve desired properties.
    /// <see href="https://w3id.org/emmo#EMMO_dacfc7dc_5ddb_4f67_986b_dcd01d649d60"></see></summary>
    let EMMO_dacfc7dc_5ddb_4f67_986b_dcd01d649d60 =
        Namespaced_IRI.parse _namespace_name "EMMO_dacfc7dc_5ddb_4f67_986b_dcd01d649d60" |> NamespacedName

    /// <summary>
    /// A procedure that deals with quantitative symbols (i.e. symbols associated with a quantitative oriented language).
    /// <see href="https://w3id.org/emmo#EMMO_eff42cb3_208e_4768_9a39_f8b6b3c3d7a2"></see></summary>
    let EMMO_eff42cb3_208e_4768_9a39_f8b6b3c3d7a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_eff42cb3_208e_4768_9a39_f8b6b3c3d7a2" |> NamespacedName

    /// <summary>
    /// A supply chain is a system of organizations, people, activities, information, and resources involved in supplying a product or service to a consumer.
    /// <see href="https://w3id.org/emmo#EMMO_0c7ad550_00ae_45ff_a4e2_58d6a61f48eb"></see></summary>
    let EMMO_0c7ad550_00ae_45ff_a4e2_58d6a61f48eb =
        Namespaced_IRI.parse _namespace_name "EMMO_0c7ad550_00ae_45ff_a4e2_58d6a61f48eb" |> NamespacedName

    /// <summary>
    /// The class of individuals representing a causal system.
    /// A causal system provides the most general concept of system, being a union of causal structures interacting together. In its most simple form, a causal system is an interlacement of causal paths (the most simple structure type).
    /// A causal system is always a spatial-like structure, and is represented as a multiple topologically orderable direct acyclic graph, with quanta as nodes and causality relations as edges.
    /// <see href="https://w3id.org/emmo#EMMO_e7aac247_31d6_4b2e_9fd2_e842b1b7ccac"></see></summary>
    let EMMO_e7aac247_31d6_4b2e_9fd2_e842b1b7ccac =
        Namespaced_IRI.parse _namespace_name "EMMO_e7aac247_31d6_4b2e_9fd2_e842b1b7ccac" |> NamespacedName

    /// <summary>
    /// Shot peening is shot peening for shaping or straightening workpieces by introducing residual compressive stresses (from: DIN 8200/10.82).
    /// <see href="https://w3id.org/emmo#EMMO_46f70544_818e_495e_99ef_d342c54ee7dc"></see></summary>
    let EMMO_46f70544_818e_495e_99ef_d342c54ee7dc =
        Namespaced_IRI.parse _namespace_name "EMMO_46f70544_818e_495e_99ef_d342c54ee7dc" |> NamespacedName

    /// <summary>
    /// The term in the International vocabulary of metrology (VIM) (JCGM 200:2008) that corresponds to the annotated term in EMMO.
    /// <see href="https://w3id.org/emmo#EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6"></see></summary>
    let EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6" |> NamespacedName

    /// <summary>
    /// VIM defines a quantity as a "property of a phenomenon, body, or substance, where the property has a magnitude that can be expressed as a number and a reference".
    ///
    /// A quantity in EMMO is a property and therefore only addresses the first part of the VIM definition (that is a property of a phenomenon, body, or substance). The second part (that it can be expressed as a number and a reference) is syntactic and addressed by emmo:QuantityValue.
    /// A quantifiable property of a phenomenon, body, or substance.
    /// <see href="https://w3id.org/emmo#EMMO_0650c031_42b6_4f0a_b62d_d88f071da6bf"></see></summary>
    let EMMO_0650c031_42b6_4f0a_b62d_d88f071da6bf =
        Namespaced_IRI.parse _namespace_name "EMMO_0650c031_42b6_4f0a_b62d_d88f071da6bf" |> NamespacedName

    /// <summary>
    /// Process for joining two (base) materials by means of an adhesive polymer material
    /// <see href="https://w3id.org/emmo#EMMO_ecc10f05_b301_4dcf_8c84_b6f511117234"></see></summary>
    let EMMO_ecc10f05_b301_4dcf_8c84_b6f511117234 =
        Namespaced_IRI.parse _namespace_name "EMMO_ecc10f05_b301_4dcf_8c84_b6f511117234" |> NamespacedName

    /// <summary>
    /// Forming of a solid body, whereby the plastic state is essentially brought about by a combined tensile and compressive stress.
    /// <see href="https://w3id.org/emmo#EMMO_6fba4018_24bd_450c_abc3_354e2c7809c9"></see></summary>
    let EMMO_6fba4018_24bd_450c_abc3_354e2c7809c9 =
        Namespaced_IRI.parse _namespace_name "EMMO_6fba4018_24bd_450c_abc3_354e2c7809c9" |> NamespacedName

    /// <summary>
    /// No loss or adds of parts by the components, nor merging. In assemblying parts are losing some of theirs movement degrees of freedom.
    /// The act of connecting together the parts of something
    /// <see href="https://w3id.org/emmo#EMMO_912ac3a2_a124_4233_92dd_06c9aebea46c"></see></summary>
    let EMMO_912ac3a2_a124_4233_92dd_06c9aebea46c =
        Namespaced_IRI.parse _namespace_name "EMMO_912ac3a2_a124_4233_92dd_06c9aebea46c" |> NamespacedName

    /// <summary>
    /// A language entity used in the metrology discipline.
    /// Metrology is the science of measurement and its application and includes all theoretical and practical aspects of measurement, whatever the measurement uncertainty and field of application (VIM3 2.2)
    /// <see href="https://w3id.org/emmo#EMMO_985bec21_989f_4b9e_a4b3_735d88099c3c"></see></summary>
    let EMMO_985bec21_989f_4b9e_a4b3_735d88099c3c =
        Namespaced_IRI.parse _namespace_name "EMMO_985bec21_989f_4b9e_a4b3_735d88099c3c" |> NamespacedName

    /// <summary>
    /// Axiom not included in the theory because of OWL 2 DL global restrictions for decidability.
    /// <see href="https://w3id.org/emmo#EMMO_c6e77b51_681b_4d04_b20d_a08f2b977470"></see></summary>
    let EMMO_c6e77b51_681b_4d04_b20d_a08f2b977470 =
        Namespaced_IRI.parse _namespace_name "EMMO_c6e77b51_681b_4d04_b20d_a08f2b977470" |> NamespacedName

    /// <summary>
    /// A manufacturing process in which metallic material is anodically dissolved under the influence of an electric current and an electrolyte solution. The current flow can be caused either by connection to an external current source or due to local element formation on the workpiece (etching).
    /// <see href="https://w3id.org/emmo#EMMO_b8ce01a5_1e0c_4c69_8e54_7235fd4fe47e"></see></summary>
    let EMMO_b8ce01a5_1e0c_4c69_8e54_7235fd4fe47e =
        Namespaced_IRI.parse _namespace_name "EMMO_b8ce01a5_1e0c_4c69_8e54_7235fd4fe47e" |> NamespacedName

    /// <summary>
    /// The union of hadron and lepton, or fermion and bosons.
    /// The scope of the physical particle definition goes from the elementary particles to molecules, as fundamental constituents of substances.
    /// A well defined physical entity, elementary or composite, usually treated as a singular unit, that is found at scales spanning from the elementary particles to molecules, as fundamental constituents of larger scale substances (as the etymology of "particle" suggests).
    /// <see href="https://w3id.org/emmo#EMMO_a15cea10_9946_4d2b_95c5_cfc333fd2abb"></see></summary>
    let EMMO_a15cea10_9946_4d2b_95c5_cfc333fd2abb =
        Namespaced_IRI.parse _namespace_name "EMMO_a15cea10_9946_4d2b_95c5_cfc333fd2abb" |> NamespacedName

    /// <summary>
    /// It is natural to define entities made or more than one smaller parts as object according to some unity criteria. One of the most general one applicable to causal interacting systems is to ask that all the quantum parts of the system are part of elementaries whose paths start and end within the entitiy. We call this causal convexity. In other words, causal convexity excludes all quantums that leave the system (no more interacting), or that are not yet part of it (not yet interacting).
    /// So, a photon leaving a body is not part of a convex system, while a real photon that is the carrier of clasical electromagnetic interaction between two molecular parts of the body, is part of the convex body.
    /// A physical phenomenon is defined as a causally non-convex interacting system, complement of causally convex interacting system.
    /// The class of individuals standing for causally convex interacting systems.
    /// <see href="https://w3id.org/emmo#EMMO_38b579de_4331_40e0_803d_09efa298e726"></see></summary>
    let EMMO_38b579de_4331_40e0_803d_09efa298e726 =
        Namespaced_IRI.parse _namespace_name "EMMO_38b579de_4331_40e0_803d_09efa298e726" |> NamespacedName

    /// <summary>
    /// Removal of material by means of rigid or flexible discs or belts containing abrasives.
    /// <see href="https://w3id.org/emmo#EMMO_2138677c_845a_4bc2_8be7_7b0a07b4777d"></see></summary>
    let EMMO_2138677c_845a_4bc2_8be7_7b0a07b4777d =
        Namespaced_IRI.parse _namespace_name "EMMO_2138677c_845a_4bc2_8be7_7b0a07b4777d" |> NamespacedName

    /// <summary>
    /// hardening of a workpiece caused by the precipitation of one or more compounds from a supersaturated solid solution
    /// <see href="https://w3id.org/emmo#EMMO_3c7affee_09ed_42e7_a190_4a10c75ab6dd"></see></summary>
    let EMMO_3c7affee_09ed_42e7_a190_4a10c75ab6dd =
        Namespaced_IRI.parse _namespace_name "EMMO_3c7affee_09ed_42e7_a190_4a10c75ab6dd" |> NamespacedName

    /// <summary>
    /// A person or organisation acting as a contact point for enquiries about the ontology resource
    /// The annotation should include an email address.
    /// <see href="https://w3id.org/emmo#EMMO_1246b120_abbe_4840_b0f8_3e4348b24a17"></see></summary>
    let EMMO_1246b120_abbe_4840_b0f8_3e4348b24a17 =
        Namespaced_IRI.parse _namespace_name "EMMO_1246b120_abbe_4840_b0f8_3e4348b24a17" |> NamespacedName

    /// <summary>
    /// A sub collection realtion where the proper part is fully encompasses some of the members of the collection.
    /// <see href="https://w3id.org/emmo#0528e41d_edd2_49f9_bd2a_aeabdc215515"></see></summary>
    let _0528e41d_edd2_49f9_bd2a_aeabdc215515 =
        Namespaced_IRI.parse _namespace_name "0528e41d_edd2_49f9_bd2a_aeabdc215515" |> NamespacedName

    /// <summary>
    /// The relation between individuals representing a collection and one or more of its members.
    /// A maximal part is a proper part that is not connected with the rest of the whole.
    /// A proper part which is not connected with the rest of the whole.
    /// <see href="https://w3id.org/emmo#33fd15ab_7662_4cc6_8bf6_988422efc631"></see></summary>
    let _33fd15ab_7662_4cc6_8bf6_988422efc631 =
        Namespaced_IRI.parse _namespace_name "33fd15ab_7662_4cc6_8bf6_988422efc631" |> NamespacedName

    /// <summary>
    /// The relation between two individuals representing an entity and a non-maximal proper part, meaning the the latter is connected with the rest of the whole.
    /// A non-maximal part is a proper part that is connected with the rest of the whole.
    /// <see href="https://w3id.org/emmo#76413949_896c_4363_a955_de4722c6e149"></see></summary>
    let _76413949_896c_4363_a955_de4722c6e149 =
        Namespaced_IRI.parse _namespace_name "76413949_896c_4363_a955_de4722c6e149" |> NamespacedName

    /// <summary>
    /// The ampere, symbol A, is the SI unit of electric current. It is defined by taking the fixed numerical value of the elementary charge e to be 1.602176634×10−19 when expressed in the unit C, which is equal to A s, where the second is defined in terms of ∆νCs.
    /// <see href="https://w3id.org/emmo#Ampere"></see></summary>
    let Ampere = Namespaced_IRI.parse _namespace_name "Ampere" |> NamespacedName

    /// <summary>
    /// The owl:dataProperty that provides a serialisation of an EMMO symbol data entity.
    /// <see href="https://w3id.org/emmo#EMMO_23b579e1_8088_45b5_9975_064014026c42"></see></summary>
    let EMMO_23b579e1_8088_45b5_9975_064014026c42 =
        Namespaced_IRI.parse _namespace_name "EMMO_23b579e1_8088_45b5_9975_064014026c42" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrent'.
    /// <see href="https://w3id.org/emmo#EMMO_d5f3e0e5_fc7d_4e64_86ad_555e74aaff84"></see></summary>
    let EMMO_d5f3e0e5_fc7d_4e64_86ad_555e74aaff84 =
        Namespaced_IRI.parse _namespace_name "EMMO_d5f3e0e5_fc7d_4e64_86ad_555e74aaff84" |> NamespacedName

    /// <summary>
    /// The UN/CEFACT Recommendation 20 provides three character alphabetic and alphanumeric codes for representing units of measurement for length, area, volume/capacity, mass (weight), time, and other quantities used in international trade. The codes are intended for use in manual and/or automated systems for the exchange of information between participants in international trade.
    /// <see href="https://w3id.org/emmo#EMMO_0b1cbe60_d380_4787_b92e_be26bdacf2c2"></see></summary>
    let EMMO_0b1cbe60_d380_4787_b92e_be26bdacf2c2 =
        Namespaced_IRI.parse _namespace_name "EMMO_0b1cbe60_d380_4787_b92e_be26bdacf2c2" |> NamespacedName

    /// <summary>
    /// URL to corresponing entity in QUDT.
    /// <see href="https://w3id.org/emmo#EMMO_1f1b164d_ec6a_4faa_8d5e_88bda62316cc"></see></summary>
    let EMMO_1f1b164d_ec6a_4faa_8d5e_88bda62316cc =
        Namespaced_IRI.parse _namespace_name "EMMO_1f1b164d_ec6a_4faa_8d5e_88bda62316cc" |> NamespacedName

    /// <summary>
    /// Unified Code for Units of Measure (UCUM).
    /// The Unified Code for Units of Measure (UCUM) is a code system intended to include all units of measures being contemporarily used in international science, engineering, and business. The purpose is to facilitate unambiguous electronic communication of quantities together with their units.
    /// <see href="https://w3id.org/emmo#EMMO_33ae2d07_5526_4555_a0b4_8f4c031b5652"></see></summary>
    let EMMO_33ae2d07_5526_4555_a0b4_8f4c031b5652 =
        Namespaced_IRI.parse _namespace_name "EMMO_33ae2d07_5526_4555_a0b4_8f4c031b5652" |> NamespacedName

    /// <summary>
    /// URL to corresponding dpbedia entry.
    /// <see href="https://w3id.org/emmo#EMMO_6dd685dd_1895_46e4_b227_be9f7d643c25"></see></summary>
    let EMMO_6dd685dd_1895_46e4_b227_be9f7d643c25 =
        Namespaced_IRI.parse _namespace_name "EMMO_6dd685dd_1895_46e4_b227_be9f7d643c25" |> NamespacedName

    /// <summary>
    /// DOI to corresponding concept in IUPAC
    /// <see href="https://w3id.org/emmo#EMMO_fe015383_afb3_44a6_ae86_043628697aa2"></see></summary>
    let EMMO_fe015383_afb3_44a6_ae86_043628697aa2 =
        Namespaced_IRI.parse _namespace_name "EMMO_fe015383_afb3_44a6_ae86_043628697aa2" |> NamespacedName

    /// <summary>
    /// `Ampere hour` is a practical unit of electric charge equal to the charge flowing in one hour through a conductor passing one ampere. An ampere-hour or amp-hour (symbol Ah, AHr,  A · h, A h) is a unit of electric charge, with sub-units milliampere-hour (mAh) and milliampere second (mAs). One ampere-hour is equal to 3600 coulombs (ampere-seconds), the electric charge transferred by a steady current of one ampere for one hour. The ampere-hour is frequently used in measurements of electrochemical systems such as electroplating and electrical batteries. The commonly seen milliampere-hour (mAh or mA · h) is one-thousandth of an ampere-hour (3.6  coulombs).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmpereHour"></see></summary>
    let AmpereHour = Namespaced_IRI.parse _namespace_name "AmpereHour" |> NamespacedName

    /// <summary>
    /// Number to multiply a SI coherent unit with when converting to a given non-SI coherent unit.
    /// Conversion formula:
    ///
    ///     nonsi_coherent_unit = si_coherent_unit * multiplier + offset
    /// <see href="https://w3id.org/emmo#EMMO_8189b42e_0995_423a_a26c_51168b27c3cf"></see></summary>
    let EMMO_8189b42e_0995_423a_a26c_51168b27c3cf =
        Namespaced_IRI.parse _namespace_name "EMMO_8189b42e_0995_423a_a26c_51168b27c3cf" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCharge'.
    /// <see href="https://w3id.org/emmo#EMMO_ab79e92b_5377_454d_be06_d61b50db295a"></see></summary>
    let EMMO_ab79e92b_5377_454d_be06_d61b50db295a =
        Namespaced_IRI.parse _namespace_name "EMMO_ab79e92b_5377_454d_be06_d61b50db295a" |> NamespacedName

    /// <summary>
    /// Defived units that are accepted to be used with SI.
    /// <see href="https://w3id.org/emmo#EMMO_ac19c801_bead_4730_8b8c_50020eec45ec"></see></summary>
    let EMMO_ac19c801_bead_4730_8b8c_50020eec45ec =
        Namespaced_IRI.parse _namespace_name "EMMO_ac19c801_bead_4730_8b8c_50020eec45ec" |> NamespacedName

    /// <summary>
    /// Number to add to a SI coherent unit when converting to a given non-SI coherent unit.
    /// Conversion formula:
    ///
    ///     nonsi_coherent_unit = si_coherent_unit * multiplier + offset
    /// <see href="https://w3id.org/emmo#EMMO_d088a3cb_d3e3_4eb2_9897_00aef0cb00cd"></see></summary>
    let EMMO_d088a3cb_d3e3_4eb2_9897_00aef0cb00cd =
        Namespaced_IRI.parse _namespace_name "EMMO_d088a3cb_d3e3_4eb2_9897_00aef0cb00cd" |> NamespacedName

    /// <summary>
    /// A unit symbol may be a symbolic construct (e.g. km) or a symbol (e.g. m).
    /// The standard symbol for a unit.
    /// <see href="https://w3id.org/emmo#EMMO_7f1dec83_d85e_4e1b_b7bd_c9442d4f5a64"></see></summary>
    let EMMO_7f1dec83_d85e_4e1b_b7bd_c9442d4f5a64 =
        Namespaced_IRI.parse _namespace_name "EMMO_7f1dec83_d85e_4e1b_b7bd_c9442d4f5a64" |> NamespacedName

    /// <summary>
    /// unit of electric charge relative to mass
    /// <see href="https://w3id.org/emmo#AmpereHourPerKilogram"></see></summary>
    let AmpereHourPerKilogram =
        Namespaced_IRI.parse _namespace_name "AmpereHourPerKilogram" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargePerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_4dbe2b16_3e84_4049_898d_eb89bcc925a2"></see></summary>
    let EMMO_4dbe2b16_3e84_4049_898d_eb89bcc925a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_4dbe2b16_3e84_4049_898d_eb89bcc925a2" |> NamespacedName

    /// <summary>
    /// a unit of electric charge per volume
    /// <see href="https://w3id.org/emmo#AmpereHourPerLitre"></see></summary>
    let AmpereHourPerLitre =
        Namespaced_IRI.parse _namespace_name "AmpereHourPerLitre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargeDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_8f36559a_a494_4b00_abc5_60bbc1475009"></see></summary>
    let EMMO_8f36559a_a494_4b00_abc5_60bbc1475009 =
        Namespaced_IRI.parse _namespace_name "EMMO_8f36559a_a494_4b00_abc5_60bbc1475009" |> NamespacedName

    /// <summary>
    /// SI base unit ampere divided by the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerCentiMetre"></see></summary>
    let AmperePerCentiMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerCentiMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticFieldStrength'.
    /// <see href="https://w3id.org/emmo#EMMO_e6b83139_ba92_4fbd_a8b2_c8dde55844a1"></see></summary>
    let EMMO_e6b83139_ba92_4fbd_a8b2_c8dde55844a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_e6b83139_ba92_4fbd_a8b2_c8dde55844a1" |> NamespacedName

    /// <summary>
    /// A derived unit whos numerical factor in front of the product of base units is NOT equal to one.
    /// <see href="https://w3id.org/emmo#EMMO_60b78cc3_6011_4134_95ab_956f56d4bdc1"></see></summary>
    let EMMO_60b78cc3_6011_4134_95ab_956f56d4bdc1 =
        Namespaced_IRI.parse _namespace_name "EMMO_60b78cc3_6011_4134_95ab_956f56d4bdc1" |> NamespacedName

    /// <summary>
    /// A measure used to express how a current is subject to temperature. Originally used in Wien's Law to describe phenomena related to filaments. One use today is to express how a current generator derates with temperature.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerDegreeCelsius"></see></summary>
    let AmperePerDegreeCelsius =
        Namespaced_IRI.parse _namespace_name "AmperePerDegreeCelsius" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentPerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_ed7dd267_e2ee_4565_8117_e5c1eafa3e66"></see></summary>
    let EMMO_ed7dd267_e2ee_4565_8117_e5c1eafa3e66 =
        Namespaced_IRI.parse _namespace_name "EMMO_ed7dd267_e2ee_4565_8117_e5c1eafa3e66" |> NamespacedName

    /// <summary>
    /// A unit of electric current per mass.
    /// <see href="https://w3id.org/emmo#AmperePerGram"></see></summary>
    let AmperePerGram =
        Namespaced_IRI.parse _namespace_name "AmperePerGram" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentPerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_73be8825_e9a7_41d0_956e_b58060e5d5ac"></see></summary>
    let EMMO_73be8825_e9a7_41d0_956e_b58060e5d5ac =
        Namespaced_IRI.parse _namespace_name "EMMO_73be8825_e9a7_41d0_956e_b58060e5d5ac" |> NamespacedName

    /// <summary>
    /// The inverse measure of joule-per-ampere or weber. The measure for the reciprical of magnetic flux.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerJoule"></see></summary>
    let AmperePerJoule =
        Namespaced_IRI.parse _namespace_name "AmperePerJoule" |> NamespacedName

    /// <summary>
    /// A SI derived unit whos numerical factor in front of the product of SI base units is one.
    /// This class collects all units that are products or powers of SI base or SI special units only.
    /// <see href="https://w3id.org/emmo#EMMO_1273eb34_de48_43a9_925f_104110469dd2"></see></summary>
    let EMMO_1273eb34_de48_43a9_925f_104110469dd2 =
        Namespaced_IRI.parse _namespace_name "EMMO_1273eb34_de48_43a9_925f_104110469dd2" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentPerUnitEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_1aaaceb6_c5eb_4cf3_a494_f82d43fda10a"></see></summary>
    let EMMO_1aaaceb6_c5eb_4cf3_a494_f82d43fda10a =
        Namespaced_IRI.parse _namespace_name "EMMO_1aaaceb6_c5eb_4cf3_a494_f82d43fda10a" |> NamespacedName

    /// <summary>
    ///  is the SI unit of magnetic field strength. One ampere per meter is equal to π/250 oersteds (12.566  371 millioersteds) in CGS units. The ampere per meter is also the SI unit of "magnetization" in the sense of magnetic dipole moment per unit volume; in this context 1 A/m = 0.001 emu per cubic centimeter.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerMetre"></see></summary>
    let AmperePerMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerMetre" |> NamespacedName

    /// <summary>
    /// SI base unit ampere divided by the 0.001-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerMilliMetre"></see></summary>
    let AmperePerMilliMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerMilliMetre" |> NamespacedName

    /// <summary>
    /// `Ampere per Radian` is a derived unit for measuring the amount of current per unit measure of angle, expressed in ampere per radian.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerRadian"></see></summary>
    let AmperePerRadian =
        Namespaced_IRI.parse _namespace_name "AmperePerRadian" |> NamespacedName

    /// <summary>
    /// SI base unit ampere divided by the 0.0001-fold  of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerSquareCentiMetre"></see></summary>
    let AmperePerSquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerSquareCentiMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_120d86b6_d7c4_4490_8ef2_8a5f58403950"></see></summary>
    let EMMO_120d86b6_d7c4_4490_8ef2_8a5f58403950 =
        Namespaced_IRI.parse _namespace_name "EMMO_120d86b6_d7c4_4490_8ef2_8a5f58403950" |> NamespacedName

    /// <summary>
    /// `Ampere Per Square Meter` is a unit in the category of electric current density. This unit is commonly used in the SI unit system.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerSquareMetre"></see></summary>
    let AmperePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerSquareMetre" |> NamespacedName

    /// <summary>
    /// Ampere per square metre and square Kelvin.
    /// <see href="https://w3id.org/emmo#AmperePerSquareMetreSquareKelvin"></see></summary>
    let AmperePerSquareMetreSquareKelvin =
        Namespaced_IRI.parse _namespace_name "AmperePerSquareMetreSquareKelvin" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'RichardsonConstant'.
    /// <see href="https://w3id.org/emmo#EMMO_754c3a5d_8ae8_41ff_b5f2_acbadb53c735"></see></summary>
    let EMMO_754c3a5d_8ae8_41ff_b5f2_acbadb53c735 =
        Namespaced_IRI.parse _namespace_name "EMMO_754c3a5d_8ae8_41ff_b5f2_acbadb53c735" |> NamespacedName

    /// <summary>
    /// SI base unit ampere divided by the 0.000 001-fold of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmperePerSquareMilliMetre"></see></summary>
    let AmperePerSquareMilliMetre =
        Namespaced_IRI.parse _namespace_name "AmperePerSquareMilliMetre" |> NamespacedName

    /// <summary>
    /// product out of the SI base unit ampere and the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmpereSecond"></see></summary>
    let AmpereSecond =
        Namespaced_IRI.parse _namespace_name "AmpereSecond" |> NamespacedName

    /// <summary>
    /// The SI unit of electromagnetic moment.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmpereSquareMetre"></see></summary>
    let AmpereSquareMetre =
        Namespaced_IRI.parse _namespace_name "AmpereSquareMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticDipoleMoment'.
    /// <see href="https://w3id.org/emmo#EMMO_1c2226a9_22f0_40c8_8928_5a01d398f96e"></see></summary>
    let EMMO_1c2226a9_22f0_40c8_8928_5a01d398f96e =
        Namespaced_IRI.parse _namespace_name "EMMO_1c2226a9_22f0_40c8_8928_5a01d398f96e" |> NamespacedName

    /// <summary>
    /// The SI unit of gyromagnetic ratio.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#AmpereSquareMetrePerJouleSecond"></see></summary>
    let AmpereSquareMetrePerJouleSecond =
        Namespaced_IRI.parse _namespace_name "AmpereSquareMetrePerJouleSecond" |> NamespacedName

    /// <summary>
    /// An astronomical unit (abbreviated as AU, au, a.u., or ua) is a unit of length equal to 149,597,870,700 metres (92,955,807.273 mi) or approximately the mean Earth Sun distance. The symbol ua is recommended by the International Bureau of Weights and Measures, and the international standard ISO 80000, while au is recommended by the International Astronomical Union, and is more common in Anglosphere countries. In general, the International System of Units only uses capital letters for the symbols of units which are named after individual scientists, while au or a.u. can also mean atomic unit or even arbitrary unit. However, the use of AU to refer to the astronomical unit is widespread. The astronomical constant whose value is one astronomical unit is referred to as unit distance and is given the symbol A. [Wikipedia]
    ///
    /// -- QUDT
    /// One astronomical unit is defined as exactly 149597870700 m, which is roughly the distance from earth to sun.
    /// <see href="https://w3id.org/emmo#AstronomicalUnit"></see></summary>
    let AstronomicalUnit =
        Namespaced_IRI.parse _namespace_name "AstronomicalUnit" |> NamespacedName

    /// <summary>
    /// A unit symbol that stands for a derived unit.
    /// Special units are semiotic shortcuts to more complex composed symbolic objects.
    /// <see href="https://w3id.org/emmo#EMMO_3ee80521_3c23_4dd1_935d_9d522614a3e2"></see></summary>
    let EMMO_3ee80521_3c23_4dd1_935d_9d522614a3e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_3ee80521_3c23_4dd1_935d_9d522614a3e2" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Length'.
    /// <see href="https://w3id.org/emmo#EMMO_b3600e73_3e05_479d_9714_c041c3acf5cc"></see></summary>
    let EMMO_b3600e73_3e05_479d_9714_c041c3acf5cc =
        Namespaced_IRI.parse _namespace_name "EMMO_b3600e73_3e05_479d_9714_c041c3acf5cc" |> NamespacedName

    /// <summary>
    /// Number of one type of species divided by the number of all species.
    /// <see href="https://w3id.org/emmo#AtomFraction"></see></summary>
    let AtomFraction =
        Namespaced_IRI.parse _namespace_name "AtomFraction" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_f76f5a24_d703_4e8c_b368_f9a7777cb73a"></see></summary>
    let EMMO_f76f5a24_d703_4e8c_b368_f9a7777cb73a =
        Namespaced_IRI.parse _namespace_name "EMMO_f76f5a24_d703_4e8c_b368_f9a7777cb73a" |> NamespacedName

    /// <summary>
    /// The SI derived unit of activity, usually meaning radioactivity. "Radioactivity" is caused when atoms disintegrate, ejecting energetic particles. One becquerel is the radiation caused by one disintegration per second; this is equivalent to about 27.0270 picocuries (pCi). The unit is named for a French physicist, Antoine-Henri Becquerel (1852-1908), the discoverer of radioactivity. Note: both the becquerel and the hertz are basically defined as one event per second, yet they measure different things. The hertz is used to measure the rates of events that happen periodically in a fixed and definite cycle. The becquerel is used to measure the rates of events that happen sporadically and unpredictably, not in a definite cycle.
    ///
    /// -- QUDT
    /// Radioactive decays per second.
    /// SI unit for radioactive activity.
    /// <see href="https://w3id.org/emmo#Becquerel"></see></summary>
    let Becquerel = Namespaced_IRI.parse _namespace_name "Becquerel" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Frequency'.
    /// <see href="https://w3id.org/emmo#EMMO_515b5579_d526_4842_9e6f_ecc34db6f368"></see></summary>
    let EMMO_515b5579_d526_4842_9e6f_ecc34db6f368 =
        Namespaced_IRI.parse _namespace_name "EMMO_515b5579_d526_4842_9e6f_ecc34db6f368" |> NamespacedName

    /// <summary>
    /// The SI derived unit of unit in the category of Radioactivity concentration.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#BecquerelPerCubicMetre"></see></summary>
    let BecquerelPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "BecquerelPerCubicMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'FrequencyPerVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_43e499a1_ca67_4380_ac08_cfc52a93ad04"></see></summary>
    let EMMO_43e499a1_ca67_4380_ac08_cfc52a93ad04 =
        Namespaced_IRI.parse _namespace_name "EMMO_43e499a1_ca67_4380_ac08_cfc52a93ad04" |> NamespacedName

    /// <summary>
    /// "Becquerel per Kilogram" is used to describe radioactivity, which is often expressed in becquerels per unit of volume or weight, to express how much radioactive material is contained in a sample.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#BecquerelPerKilogram"></see></summary>
    let BecquerelPerKilogram =
        Namespaced_IRI.parse _namespace_name "BecquerelPerKilogram" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerTimeMass'.
    /// <see href="https://w3id.org/emmo#EMMO_52b029aa_e525_4907_95d8_759298b04f97"></see></summary>
    let EMMO_52b029aa_e525_4907_95d8_759298b04f97 =
        Namespaced_IRI.parse _namespace_name "EMMO_52b029aa_e525_4907_95d8_759298b04f97" |> NamespacedName

    /// <summary>
    /// One radioactive disintegration per second from a one part in 10**3 of the SI unit of volume (cubic metre).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#BecquerelPerLitre"></see></summary>
    let BecquerelPerLitre =
        Namespaced_IRI.parse _namespace_name "BecquerelPerLitre" |> NamespacedName

    /// <summary>
    /// Becquerel per square metre.
    /// <see href="https://w3id.org/emmo#BecquerelPerSquareMetre"></see></summary>
    let BecquerelPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "BecquerelPerSquareMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerAreaTime'.
    /// <see href="https://w3id.org/emmo#EMMO_9b075686_4ac2_43bb_b2a3_17b3ea24ff17"></see></summary>
    let EMMO_9b075686_4ac2_43bb_b2a3_17b3ea24ff17 =
        Namespaced_IRI.parse _namespace_name "EMMO_9b075686_4ac2_43bb_b2a3_17b3ea24ff17" |> NamespacedName

    /// <summary>
    /// Becquerels second per cubic metre.
    /// <see href="https://w3id.org/emmo#BecquerelSecondPerCubicMetre"></see></summary>
    let BecquerelSecondPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "BecquerelSecondPerCubicMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_95a9bf22_eabc_4a84_863d_9ea398c8a52e"></see></summary>
    let EMMO_95a9bf22_eabc_4a84_863d_9ea398c8a52e =
        Namespaced_IRI.parse _namespace_name "EMMO_95a9bf22_eabc_4a84_863d_9ea398c8a52e" |> NamespacedName

    /// <summary>
    /// The candela, symbol cd, is the SI unit of luminous intensity in a given direction. It is defined by taking the fixed numerical value of the luminous efficacy of monochromatic radiation of frequency 540×1012 Hz, Kcd, to be 683 when expressed in the unit lm W−1, which is equal to cd sr W−1, or cd sr kg−1 m−2 s3, where the kilogram, metre and second are defined in terms of h, c and ∆νCs.
    /// <see href="https://w3id.org/emmo#Candela"></see></summary>
    let Candela = Namespaced_IRI.parse _namespace_name "Candela" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LuminousIntensity'.
    /// <see href="https://w3id.org/emmo#EMMO_14ff4393_0f28_4fb4_abc7_c2cc00bc761d"></see></summary>
    let EMMO_14ff4393_0f28_4fb4_abc7_c2cc00bc761d =
        Namespaced_IRI.parse _namespace_name "EMMO_14ff4393_0f28_4fb4_abc7_c2cc00bc761d" |> NamespacedName

    /// <summary>
    /// Candela per Lumen.
    /// <see href="https://w3id.org/emmo#CandelaPerLumen"></see></summary>
    let CandelaPerLumen =
        Namespaced_IRI.parse _namespace_name "CandelaPerLumen" |> NamespacedName

    /// <summary>
    /// Quantities that are ratios of quantities of the same kind (for example length ratios and amount fractions) have the option of being expressed with units (m/m, mol/mol to aid the understanding of the quantity being expressed and also allow the use of SI prefixes, if this
    /// is desirable (μm/m, nmol/mol).
    /// -- SI Brochure
    /// Unit for fractions of quantities of the same kind, to aid the understanding of the quantity being expressed.
    /// <see href="https://w3id.org/emmo#EMMO_c2f5ee66_579c_44c6_a2e9_fa2eaa9fa4da"></see></summary>
    let EMMO_c2f5ee66_579c_44c6_a2e9_fa2eaa9fa4da =
        Namespaced_IRI.parse _namespace_name "EMMO_c2f5ee66_579c_44c6_a2e9_fa2eaa9fa4da" |> NamespacedName

    /// <summary>
    /// The candela per square metre (cd/m²) is the derived SI unit of luminance. The unit is based on the candela, the SI unit of luminous intensity, and the square metre, the SI unit of area. Nit (nt) is a deprecated non-SI name also used for this unit (1 nit = 1 cd/m²). As a measure of light emitted per unit area, this unit is frequently used to specify the brightness of a display device. Most consumer desktop liquid crystal displays have luminances of 200 to 300 cd/m²; the sRGB spec for monitors targets 80 cd/m2. HDTVs range from 450 to about 1000 cd/m2. Typically, calibrated monitors should have a brightness of 120 cd/m². Nit is believed to come from the Latin word nitere, to shine.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CandelaPerSquareMetre"></see></summary>
    let CandelaPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "CandelaPerSquareMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Luminance'.
    /// <see href="https://w3id.org/emmo#EMMO_4000d06d_8594_4263_ba72_5d9440b66c5e"></see></summary>
    let EMMO_4000d06d_8594_4263_ba72_5d9440b66c5e =
        Namespaced_IRI.parse _namespace_name "EMMO_4000d06d_8594_4263_ba72_5d9440b66c5e" |> NamespacedName

    /// <summary>
    /// SI unit for electric charge.
    /// The SI unit of electric charge. One coulomb is the amount of charge accumulated in one second by a current of one ampere. Electricity is actually a flow of charged particles, such as electrons, protons, or ions. The charge on one of these particles is a whole-number multiple of the charge e on a single electron, and one coulomb represents a charge of approximately 6.241 506 x 1018 e. The coulomb is named for a French physicist, Charles-Augustin de Coulomb (1736-1806), who was the first to measure accurately the forces exerted between electric charges.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Coulomb"></see></summary>
    let Coulomb = Namespaced_IRI.parse _namespace_name "Coulomb" |> NamespacedName

    /// <summary>
    /// It is also known as atomic unit, u.a., au, ua. This unit is commonly used in the SI unit system. Coulomb Meter (C-m) has a dimension of LTI where L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    /// Coulomb Meter (C-m) is a unit in the category of Electric dipole moment. It is also known as atomic unit, u.a., au, ua. This unit is commonly used in the SI unit system. Coulomb Meter (C-m) has a dimension of LTI where L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombMetre"></see></summary>
    let CoulombMetre =
        Namespaced_IRI.parse _namespace_name "CoulombMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthTimeCurrent'.
    /// <see href="https://w3id.org/emmo#EMMO_8515e948_bc2f_423b_8025_e4830f2b21dd"></see></summary>
    let EMMO_8515e948_bc2f_423b_8025_e4830f2b21dd =
        Namespaced_IRI.parse _namespace_name "EMMO_8515e948_bc2f_423b_8025_e4830f2b21dd" |> NamespacedName

    /// <summary>
    /// derived SI unit coulomb divided by the 0.000 001-fold of the power of the SI base unit metre by exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerCubicCentiMetre"></see></summary>
    let CoulombPerCubicCentiMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerCubicCentiMetre" |> NamespacedName

    /// <summary>
    /// Coulomb Per Cubic Meter (C/m³) is a unit in the category of Electric charge density. It is also known as coulomb per cubic metre, coulombs per cubic meter, coulombs per cubic metre, coulomb/cubic meter, coulomb/cubic metre. This unit is commonly used in the SI unit system. Coulomb Per Cubic Meter has a dimension of L⁻³TI where L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerCubicMetre"></see></summary>
    let CoulombPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerCubicMetre" |> NamespacedName

    /// <summary>
    /// derived SI unit coulomb divided by the 0.000 000 001-fold of the power of the SI base unit metre by exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerCubicMilliMetre"></see></summary>
    let CoulombPerCubicMilliMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerCubicMilliMetre" |> NamespacedName

    /// <summary>
    /// `Coulomb Per Kilogram (C/kg)` is the unit in the category of Exposure. It is also known as coulombs per kilogram, coulomb/kilogram. This unit is commonly used in the SI unit system. Coulomb Per Kilogram (C/kg) has a dimension of M⁻¹TI where M is mass, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerKilogram"></see></summary>
    let CoulombPerKilogram =
        Namespaced_IRI.parse _namespace_name "CoulombPerKilogram" |> NamespacedName

    /// <summary>
    /// The SI unit of exposure rate
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerKilogramSecond"></see></summary>
    let CoulombPerKilogramSecond =
        Namespaced_IRI.parse _namespace_name "CoulombPerKilogramSecond" |> NamespacedName

    /// <summary>
    /// "Coulomb per Meter" is a unit for  'Electric Charge Line Density' expressed as C/m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerMetre"></see></summary>
    let CoulombPerMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargePerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_9794a778_47d7_45d5_b4ab_ae6a8db04c78"></see></summary>
    let EMMO_9794a778_47d7_45d5_b4ab_ae6a8db04c78 =
        Namespaced_IRI.parse _namespace_name "EMMO_9794a778_47d7_45d5_b4ab_ae6a8db04c78" |> NamespacedName

    /// <summary>
    ///  (C/mol) is a unit in the category of Molar electric charge. It is also known as coulombs/mol. Coulomb Per Mol has a dimension of TN{-1}I where T is time, N is amount of substance, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerMole"></see></summary>
    let CoulombPerMole =
        Namespaced_IRI.parse _namespace_name "CoulombPerMole" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargePerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_e6110006_88b9_45cd_9f9c_a2a91c0c21f8"></see></summary>
    let EMMO_e6110006_88b9_45cd_9f9c_a2a91c0c21f8 =
        Namespaced_IRI.parse _namespace_name "EMMO_e6110006_88b9_45cd_9f9c_a2a91c0c21f8" |> NamespacedName

    /// <summary>
    /// derived SI unit coulomb divided by the 0.0001-fold of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerSquareCentiMetre"></see></summary>
    let CoulombPerSquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerSquareCentiMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricDisplacementField'.
    /// <see href="https://w3id.org/emmo#EMMO_6d753e0c_a967_4de4_ad22_c2fecb3913be"></see></summary>
    let EMMO_6d753e0c_a967_4de4_ad22_c2fecb3913be =
        Namespaced_IRI.parse _namespace_name "EMMO_6d753e0c_a967_4de4_ad22_c2fecb3913be" |> NamespacedName

    /// <summary>
    /// Coulomb Per Square Meter (C/m²) is a unit in the category of Electric charge surface density. It is also known as coulombs per square meter, coulomb per square metre, coulombs per square metre, coulomb/square meter, coulomb/square metre. This unit is commonly used in the SI unit system. Coulomb Per Square Meter (C/m2) has a dimension of L⁻²TI where L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerSquareMetre"></see></summary>
    let CoulombPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerSquareMetre" |> NamespacedName

    /// <summary>
    /// derived SI unit coulomb divided by the 0.000 001-fold of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombPerSquareMilliMetre"></see></summary>
    let CoulombPerSquareMilliMetre =
        Namespaced_IRI.parse _namespace_name "CoulombPerSquareMilliMetre" |> NamespacedName

    /// <summary>
    /// Coulomb Square Meter (C-m2) is a unit in the category of Electric quadrupole moment. This unit is commonly used in the SI unit system. Coulomb Square Meter (C-m2) has a dimension of L2TI where L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombSquareMetre"></see></summary>
    let CoulombSquareMetre =
        Namespaced_IRI.parse _namespace_name "CoulombSquareMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargeArea'.
    /// <see href="https://w3id.org/emmo#EMMO_92aaff7b_3a7c_4c1a_b149_d422e9682106"></see></summary>
    let EMMO_92aaff7b_3a7c_4c1a_b149_d422e9682106 =
        Namespaced_IRI.parse _namespace_name "EMMO_92aaff7b_3a7c_4c1a_b149_d422e9682106" |> NamespacedName

    /// <summary>
    /// Coulomb Square Meter (C-m2-per-volt) is a unit in the category of Electric polarizability.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CoulombSquareMetrePerVolt"></see></summary>
    let CoulombSquareMetrePerVolt =
        Namespaced_IRI.parse _namespace_name "CoulombSquareMetrePerVolt" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareCurrentQuarticTimePerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_cd9ad446_04f7_44ff_b9ea_ae7389574fa6"></see></summary>
    let EMMO_cd9ad446_04f7_44ff_b9ea_ae7389574fa6 =
        Namespaced_IRI.parse _namespace_name "EMMO_cd9ad446_04f7_44ff_b9ea_ae7389574fa6" |> NamespacedName

    /// <summary>
    /// The CGS unit of volume, equal to 10-6 cubic meter, 1 milliliter, or about 0.061 023 7 cubic inch
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetre"></see></summary>
    let CubicCentiMetre =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Volume'.
    /// <see href="https://w3id.org/emmo#EMMO_9141801c_c539_4c72_b423_8c74ff6b8f05"></see></summary>
    let EMMO_9141801c_c539_4c72_b423_8c74ff6b8f05 =
        Namespaced_IRI.parse _namespace_name "EMMO_9141801c_c539_4c72_b423_8c74ff6b8f05" |> NamespacedName

    /// <summary>
    /// volume ratio consisting of the 0.000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerCubicCentiMetre"></see></summary>
    let CubicCentiMetrePerCubicCentiMetre =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerCubicCentiMetre" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two volumes.
    /// <see href="https://w3id.org/emmo#EMMO_9fd1e79d_41d1_44f8_8142_66dbdf0fc7ad"></see></summary>
    let EMMO_9fd1e79d_41d1_44f8_8142_66dbdf0fc7ad =
        Namespaced_IRI.parse _namespace_name "EMMO_9fd1e79d_41d1_44f8_8142_66dbdf0fc7ad" |> NamespacedName

    /// <summary>
    /// volume ratio consisting of the 0.000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerCubicMetre"></see></summary>
    let CubicCentiMetrePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerCubicMetre" |> NamespacedName

    /// <summary>
    /// 0,000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerDay"></see></summary>
    let CubicCentiMetrePerDay =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerDay" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_a88475b9_c745_4a47_9403_ab0d158b9b1b"></see></summary>
    let EMMO_a88475b9_c745_4a47_9403_ab0d158b9b1b =
        Namespaced_IRI.parse _namespace_name "EMMO_a88475b9_c745_4a47_9403_ab0d158b9b1b" |> NamespacedName

    /// <summary>
    /// 0,000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerHour"></see></summary>
    let CubicCentiMetrePerHour =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerHour" |> NamespacedName

    /// <summary>
    /// 0,000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the SI base unit kelvin
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerKelvin"></see></summary>
    let CubicCentiMetrePerKelvin =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerKelvin" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_85d72920_708d_4eb9_89ce_8a588b0ce66d"></see></summary>
    let EMMO_85d72920_708d_4eb9_89ce_8a588b0ce66d =
        Namespaced_IRI.parse _namespace_name "EMMO_85d72920_708d_4eb9_89ce_8a588b0ce66d" |> NamespacedName

    /// <summary>
    /// 0,000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerMinute"></see></summary>
    let CubicCentiMetrePerMinute =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerMinute" |> NamespacedName

    /// <summary>
    /// 0.000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the SI base unit mol
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerMole"></see></summary>
    let CubicCentiMetrePerMole =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerMole" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_aa7397ff_2815_434e_9b99_e4c6a80e034e"></see></summary>
    let EMMO_aa7397ff_2815_434e_9b99_e4c6a80e034e =
        Namespaced_IRI.parse _namespace_name "EMMO_aa7397ff_2815_434e_9b99_e4c6a80e034e" |> NamespacedName

    /// <summary>
    /// A unit that is the 0.000001-fold of the power of the SI base unit metre with the exponent 3 divided by the SI base unit mol multiplied by the SI base unit second.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerMoleSecond"></see></summary>
    let CubicCentiMetrePerMoleSecond =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerMoleSecond" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerAmountTime'.
    /// <see href="https://w3id.org/emmo#EMMO_bc73913a_3bb6_4205_8d36_79bc72ca9891"></see></summary>
    let EMMO_bc73913a_3bb6_4205_8d36_79bc72ca9891 =
        Namespaced_IRI.parse _namespace_name "EMMO_bc73913a_3bb6_4205_8d36_79bc72ca9891" |> NamespacedName

    /// <summary>
    /// 0,000 001-fold of the power of the SI base unit metre with the exponent 3 divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCentiMetrePerSecond"></see></summary>
    let CubicCentiMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "CubicCentiMetrePerSecond" |> NamespacedName

    /// <summary>
    /// "Cubic Coulomb Meter per Square Joule" is a unit for  'Cubic Electric Dipole Moment Per Square Energy' expressed as C³ m³ J⁻².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicCoulombMetrePerSquareJoule"></see></summary>
    let CubicCoulombMetrePerSquareJoule =
        Namespaced_IRI.parse _namespace_name "CubicCoulombMetrePerSquareJoule" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'CubicElectricChargeLengthPerSquareEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_360adeca_9eee_4bb9_a5ca_728756c1ed4a"></see></summary>
    let EMMO_360adeca_9eee_4bb9_a5ca_728756c1ed4a =
        Namespaced_IRI.parse _namespace_name "EMMO_360adeca_9eee_4bb9_a5ca_728756c1ed4a" |> NamespacedName

    /// <summary>
    /// 1 000-fold of the power of the SI base unit metre by exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDecaMetre"></see></summary>
    let CubicDecaMetre =
        Namespaced_IRI.parse _namespace_name "CubicDecaMetre" |> NamespacedName

    /// <summary>
    /// 0.1-fold of the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetre"></see></summary>
    let CubicDeciMetre =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetre" |> NamespacedName

    /// <summary>
    /// volume ratio consisting of the 0.001-fold of the power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerCubicMetre"></see></summary>
    let CubicDeciMetrePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerCubicMetre" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit for time day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerDay"></see></summary>
    let CubicDeciMetrePerDay =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerDay" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerHour"></see></summary>
    let CubicDeciMetrePerHour =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerHour" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit for time minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerMinute"></see></summary>
    let CubicDeciMetrePerMinute =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerMinute" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the power of the SI base unit metre with the exponent 3 divided by the SI base unit mol
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerMole"></see></summary>
    let CubicDeciMetrePerMole =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerMole" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the power of the SI base unit metre with the exponent 3 divided by the unit for time second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicDeciMetrePerSecond"></see></summary>
    let CubicDeciMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "CubicDeciMetrePerSecond" |> NamespacedName

    /// <summary>
    /// `Cubic Kilometer per Square Second` is a unit for `Standard Gravitational Parameter` expressed as km³/s².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicKiloMetrePerSquareSecond"></see></summary>
    let CubicKiloMetrePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "CubicKiloMetrePerSquareSecond" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_87deb5a8_7a85_49c3_97b2_e62c8484aa1a"></see></summary>
    let EMMO_87deb5a8_7a85_49c3_97b2_e62c8484aa1a =
        Namespaced_IRI.parse _namespace_name "EMMO_87deb5a8_7a85_49c3_97b2_e62c8484aa1a" |> NamespacedName

    /// <summary>
    /// The SI unit of volume, equal to 1.0e6 cm3, 1000 liters, 35.3147 ft3, or 1.30795 yd3. A cubic meter holds about 264.17 U.S. liquid gallons or 219.99 British Imperial gallons.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetre"></see></summary>
    let CubicMetre = Namespaced_IRI.parse _namespace_name "CubicMetre" |> NamespacedName

    /// <summary>
    /// IRI to corresponding concept in the Ontology of units of Measure.
    /// <see href="https://w3id.org/emmo#EMMO_209ba1b3_149f_4ff0_b672_941610eafd72"></see></summary>
    let EMMO_209ba1b3_149f_4ff0_b672_941610eafd72 =
        Namespaced_IRI.parse _namespace_name "EMMO_209ba1b3_149f_4ff0_b672_941610eafd72" |> NamespacedName

    /// <summary>
    /// Cubic metre per Coulomb.
    /// <see href="https://w3id.org/emmo#CubicMetrePerCoulomb"></see></summary>
    let CubicMetrePerCoulomb =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerCoulomb" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ReciprocalElectricChargeDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_578f7da0_10f8_4fc2_9fd0_79b79f47f975"></see></summary>
    let EMMO_578f7da0_10f8_4fc2_9fd0_79b79f47f975 =
        Namespaced_IRI.parse _namespace_name "EMMO_578f7da0_10f8_4fc2_9fd0_79b79f47f975" |> NamespacedName

    /// <summary>
    /// Power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 3.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerCubicMetre"></see></summary>
    let CubicMetrePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerCubicMetre" |> NamespacedName

    /// <summary>
    /// power of the SI base unit metre with the exponent 3 divided by the unit day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerDay"></see></summary>
    let CubicMetrePerDay =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerDay" |> NamespacedName

    /// <summary>
    /// Cubic metre per hectare.
    /// <see href="https://w3id.org/emmo#CubicMetrePerHectare"></see></summary>
    let CubicMetrePerHectare =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerHectare" |> NamespacedName

    /// <summary>
    /// Cubic Meter Per Hour (m3/h) is a unit in the category of Volume flow rate. It is also known as cubic meters per hour, cubic metre per hour, cubic metres per hour, cubic meter/hour, cubic metre/hour, cubic meter/hr, cubic metre/hr, flowrate. Cubic Meter Per Hour (m3/h) has a dimension of L3T-1 where L is length, and T is time. It can be converted to the corresponding standard SI unit m3/s by multiplying its value by a factor of 0.00027777777.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerHour"></see></summary>
    let CubicMetrePerHour =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerHour" |> NamespacedName

    /// <summary>
    /// Cubic metre per Kelvin.
    /// <see href="https://w3id.org/emmo#CubicMetrePerKelvin"></see></summary>
    let CubicMetrePerKelvin =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerKelvin" |> NamespacedName

    /// <summary>
    /// Cubic Meter Per Kilogram (m3/kg) is a unit in the category of Specific volume. It is also known as cubic meters per kilogram, cubic metre per kilogram, cubic metres per kilogram, cubic meter/kilogram, cubic metre/kilogram. This unit is commonly used in the SI unit system. Cubic Meter Per Kilogram (m3/kg) has a dimension of M-1L3 where M is mass, and L is length. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerKilogram"></see></summary>
    let CubicMetrePerKilogram =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerKilogram" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'VolumePerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_8a582db1_c561_42f6_80ff_0fd8f252b129"></see></summary>
    let EMMO_8a582db1_c561_42f6_80ff_0fd8f252b129 =
        Namespaced_IRI.parse _namespace_name "EMMO_8a582db1_c561_42f6_80ff_0fd8f252b129" |> NamespacedName

    /// <summary>
    /// Cubic metre per kilogram and square second.
    /// <see href="https://w3id.org/emmo#CubicMetrePerKilogramSquareSecond"></see></summary>
    let CubicMetrePerKilogramSquareSecond =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerKilogramSquareSecond" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'NewtonianConstantOfGravity'.
    /// <see href="https://w3id.org/emmo#EMMO_3181bb28_623b_4411_ad79_80277c661322"></see></summary>
    let EMMO_3181bb28_623b_4411_ad79_80277c661322 =
        Namespaced_IRI.parse _namespace_name "EMMO_3181bb28_623b_4411_ad79_80277c661322" |> NamespacedName

    /// <summary>
    /// power of the SI base unit metre with the exponent 3 divided by the unit minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerMinute"></see></summary>
    let CubicMetrePerMinute =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerMinute" |> NamespacedName

    /// <summary>
    /// The molar volume, symbol Vm, is the volume occupied by one mole of a substance (chemical element or chemical compound) at a given temperature and pressure. It is equal to the molar mass (M) divided by the mass density. It has the SI unit cubic metres per mole m3/mol, although it is more practical to use the units cubic decimetres per mole dm3/mol for gases and cubic centimetres per mole cm3/mol for liquids and solids.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerMole"></see></summary>
    let CubicMetrePerMole =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerMole" |> NamespacedName

    /// <summary>
    /// A cubic metre per second (m³s⁻¹, m³/s), cumecs or cubic meter per second in American English) is a derived SI unit of flow rate equal to that of a stere or cube with sides of one metre ( u0303 39.37 in) in length exchanged or moving each second. It is popularly used for water flow, especially in rivers and streams, and fractions for HVAC values measuring air flow.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerSecond"></see></summary>
    let CubicMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerSecond" |> NamespacedName

    /// <summary>
    /// power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerSquareMetre"></see></summary>
    let CubicMetrePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerSquareMetre" |> NamespacedName

    /// <summary>
    /// `Cubic Meter per Square Second` is a C.G.S System unit for  `Standard Gravitational Parameter` expressed as m³/s²
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMetrePerSquareSecond"></see></summary>
    let CubicMetrePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "CubicMetrePerSquareSecond" |> NamespacedName

    /// <summary>
    /// Cubic micrometre per cubic metre unit.
    /// <see href="https://w3id.org/emmo#CubicMicroMetrePerCubicMetre"></see></summary>
    let CubicMicroMetrePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CubicMicroMetrePerCubicMetre" |> NamespacedName

    /// <summary>
    /// Cubic micrometre per millilitre.
    /// <see href="https://w3id.org/emmo#CubicMicroMetrePerMilliLitre"></see></summary>
    let CubicMicroMetrePerMilliLitre =
        Namespaced_IRI.parse _namespace_name "CubicMicroMetrePerMilliLitre" |> NamespacedName

    /// <summary>
    /// Measurement units that are not SI units.
    /// <see href="https://w3id.org/emmo#EMMO_15344998_4490_4b40_b242_c3d92e5cdc27"></see></summary>
    let EMMO_15344998_4490_4b40_b242_c3d92e5cdc27 =
        Namespaced_IRI.parse _namespace_name "EMMO_15344998_4490_4b40_b242_c3d92e5cdc27" |> NamespacedName

    /// <summary>
    /// A metric measure of volume or capacity equal to a cube 1 millimeter on each edge
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMilliMetre"></see></summary>
    let CubicMilliMetre =
        Namespaced_IRI.parse _namespace_name "CubicMilliMetre" |> NamespacedName

    /// <summary>
    /// volume ratio consisting of the 0.000000001-fold of the power of the SI base unit metre with the exponent 3 divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#CubicMilliMetrePerCubicMetre"></see></summary>
    let CubicMilliMetrePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "CubicMilliMetrePerCubicMetre" |> NamespacedName

    /// <summary>
    /// One dalton is defined as one twelfth of the mass of an unbound neutral atom of carbon-12 in its nuclear and electronic ground state.
    /// The unified atomic mass unit (symbol: μ) or dalton (symbol: Da) is a unit that is used for indicating mass on an atomic or molecular scale. It is defined as one twelfth of the rest mass of an unbound atom of carbon-12 in its nuclear and electronic ground state, and has a value of 1.660538782(83) × 10⁻²⁷ kg. One Da is approximately equal to the mass of one proton or one neutron. The CIPM have categorised it as a "non-SI unit whose values in SI units must be obtained experimentally".
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Dalton"></see></summary>
    let Dalton = Namespaced_IRI.parse _namespace_name "Dalton" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Mass'.
    /// <see href="https://w3id.org/emmo#EMMO_77e9dc31_5b19_463e_b000_44c6e79f98aa"></see></summary>
    let EMMO_77e9dc31_5b19_463e_b000_44c6e79f98aa =
        Namespaced_IRI.parse _namespace_name "EMMO_77e9dc31_5b19_463e_b000_44c6e79f98aa" |> NamespacedName

    /// <summary>
    /// Mean solar day
    ///
    /// -- QUDT
    /// A measure of time defined as 86 400 seconds.
    /// <see href="https://w3id.org/emmo#Day"></see></summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Time'.
    /// <see href="https://w3id.org/emmo#EMMO_02e894c3_b793_4197_b120_3442e08f58d1"></see></summary>
    let EMMO_02e894c3_b793_4197_b120_3442e08f58d1 =
        Namespaced_IRI.parse _namespace_name "EMMO_02e894c3_b793_4197_b120_3442e08f58d1" |> NamespacedName

    /// <summary>
    /// A degree (in full, a degree of arc, arc degree, or arcdegree), usually denoted by ° (the degree symbol), is a measurement of plane angle, representing 1/360 of a full rotation; one degree is equivalent to  2π /360 rad, 0.017453 rad. It is not an SI unit, as the SI unit for angles is radian, but is an accepted SI unit.
    ///
    /// -- QUDT
    /// Degree is a measurement of plane angle, defined by representing a full rotation as 360 degrees.
    /// <see href="https://w3id.org/emmo#Degree"></see></summary>
    let Degree = Namespaced_IRI.parse _namespace_name "Degree" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two lengths.
    /// <see href="https://w3id.org/emmo#EMMO_cdc962d8_f3ea_4764_a57a_c7caa4859179"></see></summary>
    let EMMO_cdc962d8_f3ea_4764_a57a_c7caa4859179 =
        Namespaced_IRI.parse _namespace_name "EMMO_cdc962d8_f3ea_4764_a57a_c7caa4859179" |> NamespacedName

    /// <summary>
    /// Celsius, also known as centigrade, is a scale and unit of measurement for temperature. It can refer to a specific temperature on the Celsius scale as well as a unit to indicate a temperature interval, a difference between two temperatures or an uncertainty. This definition fixes the magnitude of both the degree Celsius and the kelvin as precisely 1 part in 273.16 (approximately 0.00366) of the difference between absolute zero and the triple point of water. Thus, it sets the magnitude of one degree Celsius and that of one kelvin as exactly the same. Additionally, it establishes the difference between the two scales' null points as being precisely 273.15 °C.
    ///
    /// -- QUDT
    /// Measurement unit for Celsius temperature. This unit can only be used for expressing temperature differences.
    /// <see href="https://w3id.org/emmo#DegreeCelsius"></see></summary>
    let DegreeCelsius =
        Namespaced_IRI.parse _namespace_name "DegreeCelsius" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Temperature'.
    /// <see href="https://w3id.org/emmo#EMMO_a77a0a4b_6bd2_42b2_be27_4b63cebbb59e"></see></summary>
    let EMMO_a77a0a4b_6bd2_42b2_be27_4b63cebbb59e =
        Namespaced_IRI.parse _namespace_name "EMMO_a77a0a4b_6bd2_42b2_be27_4b63cebbb59e" |> NamespacedName

    /// <summary>
    /// `Degree Celsius Centimeter` is a C.G.S System unit for 'Length Temperature' expressed as cm-degC.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusCentiMetre"></see></summary>
    let DegreeCelsiusCentiMetre =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusCentiMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_d02c92e0_99ba_4c09_b01f_0d7a7dd7b24e"></see></summary>
    let EMMO_d02c92e0_99ba_4c09_b01f_0d7a7dd7b24e =
        Namespaced_IRI.parse _namespace_name "EMMO_d02c92e0_99ba_4c09_b01f_0d7a7dd7b24e" |> NamespacedName

    /// <summary>
    /// Derived unit for the product of the temperature in degrees Celsius and the mass density of a medium, integrated over vertical depth or height in metres.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusKilogramPerSquareMetre"></see></summary>
    let DegreeCelsiusKilogramPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusKilogramPerSquareMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperatureMassPerArea'.
    /// <see href="https://w3id.org/emmo#EMMO_6726fbb8_c40a_4b55_a2d5_bf49352d1e73"></see></summary>
    let EMMO_6726fbb8_c40a_4b55_a2d5_bf49352d1e73 =
        Namespaced_IRI.parse _namespace_name "EMMO_6726fbb8_c40a_4b55_a2d5_bf49352d1e73" |> NamespacedName

    /// <summary>
    /// `Degree Celsius per Hour` is a unit for 'Temperature Per Time' expressed as degC / hr.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusPerHour"></see></summary>
    let DegreeCelsiusPerHour =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusPerHour" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_4f245147_f072_4431_b535_6241e8e87eb8"></see></summary>
    let EMMO_4f245147_f072_4431_b535_6241e8e87eb8 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f245147_f072_4431_b535_6241e8e87eb8" |> NamespacedName

    /// <summary>
    /// unit with the name Degree Celsius divided by the SI base unit kelvin
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusPerKelvin"></see></summary>
    let DegreeCelsiusPerKelvin =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusPerKelvin" |> NamespacedName

    /// <summary>
    /// The subclass of measurement units with no physical dimension.
    /// <see href="https://w3id.org/emmo#EMMO_3227b821_26a5_4c7c_9c01_5c24483e0bd0"></see></summary>
    let EMMO_3227b821_26a5_4c7c_9c01_5c24483e0bd0 =
        Namespaced_IRI.parse _namespace_name "EMMO_3227b821_26a5_4c7c_9c01_5c24483e0bd0" |> NamespacedName

    /// <summary>
    /// Degree Celsius per metre unit.
    /// <see href="https://w3id.org/emmo#DegreeCelsiusPerMetre"></see></summary>
    let DegreeCelsiusPerMetre =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusPerMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_720a469f_a19c_4a88_900c_29b3938f5092"></see></summary>
    let EMMO_720a469f_a19c_4a88_900c_29b3938f5092 =
        Namespaced_IRI.parse _namespace_name "EMMO_720a469f_a19c_4a88_900c_29b3938f5092" |> NamespacedName

    /// <summary>
    /// `Degree Celsius per Minute` is a unit for 'Temperature Per Time' expressed as degC / m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusPerMinute"></see></summary>
    let DegreeCelsiusPerMinute =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusPerMinute" |> NamespacedName

    /// <summary>
    /// `Degree Celsius per Second` is a unit for 'Temperature Per Time' expressed as degC / s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreeCelsiusPerSecond"></see></summary>
    let DegreeCelsiusPerSecond =
        Namespaced_IRI.parse _namespace_name "DegreeCelsiusPerSecond" |> NamespacedName

    /// <summary>
    /// "Degree per Hour" is an Imperial unit for  'Angular Velocity' expressed as deg/h.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreePerHour"></see></summary>
    let DegreePerHour =
        Namespaced_IRI.parse _namespace_name "DegreePerHour" |> NamespacedName

    /// <summary>
    /// A change of angle in one SI unit of length.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreePerMetre"></see></summary>
    let DegreePerMetre =
        Namespaced_IRI.parse _namespace_name "DegreePerMetre" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ReciprocalLength'.
    /// <see href="https://w3id.org/emmo#EMMO_608a1b30_df6f_4bbb_9dc3_5c0de92fd9cf"></see></summary>
    let EMMO_608a1b30_df6f_4bbb_9dc3_5c0de92fd9cf =
        Namespaced_IRI.parse _namespace_name "EMMO_608a1b30_df6f_4bbb_9dc3_5c0de92fd9cf" |> NamespacedName

    /// <summary>
    /// A unit of measure for the rate of change of plane angle, dω / dt,  in durations of one minute.The vector ω is directed along the axis of rotation in the direction for which the rotation is clockwise.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreePerMinute"></see></summary>
    let DegreePerMinute =
        Namespaced_IRI.parse _namespace_name "DegreePerMinute" |> NamespacedName

    /// <summary>
    /// "Degree per Second" is an Imperial unit for  'Angular Velocity' expressed as deg/s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreePerSecond"></see></summary>
    let DegreePerSecond =
        Namespaced_IRI.parse _namespace_name "DegreePerSecond" |> NamespacedName

    /// <summary>
    /// `Degree per Square Second` is an Imperial unit for `Angular Acceleration` expressed as deg/s².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#DegreePerSquareSecond"></see></summary>
    let DegreePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "DegreePerSquareSecond" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AngularFrequency'.
    /// <see href="https://w3id.org/emmo#EMMO_78487bf1_c0bc_4db8_99dd_d8b7cc8b3bac"></see></summary>
    let EMMO_78487bf1_c0bc_4db8_99dd_d8b7cc8b3bac =
        Namespaced_IRI.parse _namespace_name "EMMO_78487bf1_c0bc_4db8_99dd_d8b7cc8b3bac" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaPerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_002e4002_58c7_4aea_ac1f_bba5188818ff"></see></summary>
    let EMMO_002e4002_58c7_4aea_ac1f_bba5188818ff =
        Namespaced_IRI.parse _namespace_name "EMMO_002e4002_58c7_4aea_ac1f_bba5188818ff" |> NamespacedName

    /// <summary>
    /// In SI are the physical dimensions of the base quantities time (T), length (L), mass (M), electric current (I), thermodynamic temperature (Θ), amount of substance (N) and luminous intensity (J).
    ///
    /// In general the dimension of any quantity Q is written in the form of a dimensional product,
    ///
    ///     dim Q = T^α L^β M^γ I^δ Θ^ε N^ζ J^η
    ///
    /// where the exponents α, β, γ, δ, ε, ζ and η, which are generally small integers, which can be positive, negative, or zero, are called the dimensional exponents.
    /// -- SI brouchure
    ///
    /// The SI dimensional units are equivalent to dimensional strings that uniquely defines their dimensionality by specifying the values of the coefficients α, β, γ, δ, ε, ζ and η. A dimensional string is a space-separated string of the physical dimension symbols followed by the value of the exponent (including it sign). They should always match the following regular expression:
    ///
    /// ^T([+-][1-9]|0) L([+-][1-9]|0) M([+-][1-9]|0) I([+-][1-9]|0) Θ([+-][1-9]|0) N([+-][1-9]|0) J([+-][1-9]|0)$
    ///
    /// Examples of correspondance between dimensional units and their dimensional units are:
    ///
    /// - AmountOfSubstanceUnit &lt;=&gt; "T0 L0 M0 I0 Θ0 N+1 J0"
    /// - TimeUnit &lt;=&gt; "T+1 L0 M0 I0 Θ0 N0 J0"
    /// - ElectricCurrentDensityUnit &lt;=&gt; "T0 L-2 M0 I+1 Θ0 N0 J0"
    /// Dimensional unit with its physical dimensionality described accortind to the International System of Units (SI).
    /// <see href="https://w3id.org/emmo#EMMO_9895a1b4_f0a5_4167_ac5e_97db40b8bfcc"></see></summary>
    let EMMO_9895a1b4_f0a5_4167_ac5e_97db40b8bfcc =
        Namespaced_IRI.parse _namespace_name "EMMO_9895a1b4_f0a5_4167_ac5e_97db40b8bfcc" |> NamespacedName

    /// <summary>
    /// Relates a SI dimensional unit to a dimension string.
    /// <see href="https://w3id.org/emmo#EMMO_19d925d0_2cf1_40e5_a391_1a99d68409c9"></see></summary>
    let EMMO_19d925d0_2cf1_40e5_a391_1a99d68409c9 =
        Namespaced_IRI.parse _namespace_name "EMMO_19d925d0_2cf1_40e5_a391_1a99d68409c9" |> NamespacedName

    /// <summary>
    /// Atom subclass for carbon.
    /// <see href="https://w3id.org/emmo#EMMO_0056cc2f-f2fe-558e-a65c-9a8fc5cea333"></see></summary>
    let ``EMMO_0056cc2f-f2fe-558e-a65c-9a8fc5cea333`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0056cc2f-f2fe-558e-a65c-9a8fc5cea333" |> NamespacedName

    /// <summary>
    /// This is a convenient shortcut for the conventional declaration process of assigning an atomic number to an atom subclass.
    /// The atomic number of an atomic element.
    /// <see href="https://w3id.org/emmo#EMMO_a585728e-36c8-5df4-9d95-aa128d2a0e7f"></see></summary>
    let ``EMMO_a585728e-36c8-5df4-9d95-aa128d2a0e7f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a585728e-36c8-5df4-9d95-aa128d2a0e7f" |> NamespacedName

    /// <summary>
    /// This is a convenient shortcut for the measurement process process of the atomic mass reported by IUPAC2016.
    /// The mass of an atomic element according to IUPAC 2016.
    /// <see href="https://w3id.org/emmo#EMMO_43de6d01-276c-55ed-a166-ad097ec75575"></see></summary>
    let ``EMMO_43de6d01-276c-55ed-a166-ad097ec75575`` =
        Namespaced_IRI.parse _namespace_name "EMMO_43de6d01-276c-55ed-a166-ad097ec75575" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the carbon atom.
    /// <see href="https://w3id.org/emmo#EMMO_a7180b5f-d46d-5751-b3bc-ae28a6655992"></see></summary>
    let ``EMMO_a7180b5f-d46d-5751-b3bc-ae28a6655992`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a7180b5f-d46d-5751-b3bc-ae28a6655992" |> NamespacedName

    /// <summary>
    /// The chemical symbol of an atomic element.
    /// <see href="https://w3id.org/emmo#EMMO_79c0edfa-06f9-5149-b754-28c589035b8a"></see></summary>
    let ``EMMO_79c0edfa-06f9-5149-b754-28c589035b8a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_79c0edfa-06f9-5149-b754-28c589035b8a" |> NamespacedName

    /// <summary>
    /// A standalone atom has direct part one 'nucleus' and one 'electron_cloud'.
    ///
    /// An O 'atom' within an O₂ 'molecule' is an 'e-bonded_atom'.
    ///
    /// In this material branch, H atom is a particular case, with respect to higher atomic number atoms, since as soon as it shares its electron it has no nucleus entangled electron cloud.
    ///
    /// We cannot say that H₂ molecule has direct part two H atoms, but has direct part two H nucleus.
    /// An 'atom' is a 'nucleus' surrounded by an 'electron_cloud', i.e. a quantum system made of one or more bounded electrons.
    /// <see href="https://w3id.org/emmo#EMMO_eb77076b_a104_42ac_a065_798b2d2809ad"></see></summary>
    let EMMO_eb77076b_a104_42ac_a065_798b2d2809ad =
        Namespaced_IRI.parse _namespace_name "EMMO_eb77076b_a104_42ac_a065_798b2d2809ad" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the uranium atom.
    /// <see href="https://w3id.org/emmo#EMMO_0080b38f-bac4-5dd6-9d28-d821cf723787"></see></summary>
    let ``EMMO_0080b38f-bac4-5dd6-9d28-d821cf723787`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0080b38f-bac4-5dd6-9d28-d821cf723787" |> NamespacedName

    /// <summary>
    /// The IUPAC Gold Book defines the a chemical element both as:
    /// - a species of atoms; all atoms with the same number of protons in the atomic nucleus
    /// -  a pure chemical substance composed of atoms with the same number of protons in the atomic nucleus
    ///
    /// This qualifies a chemical element as a name and not a matter obejct that can stand for an atom or a substance.
    /// The symbol for a specific chemical element, that can stand both for an atom or a substance.
    /// <see href="https://w3id.org/emmo#EMMO_4f40def1_3cd7_4067_9596_541e9a5134cf"></see></summary>
    let EMMO_4f40def1_3cd7_4067_9596_541e9a5134cf =
        Namespaced_IRI.parse _namespace_name "EMMO_4f40def1_3cd7_4067_9596_541e9a5134cf" |> NamespacedName

    /// <summary>
    /// A 'Process', that has participant an 'Interpreter', that is aimed to produce a 'Sign' representing another participant, the 'Object'.
    /// <see href="https://w3id.org/emmo#EMMO_008fd3b2_4013_451f_8827_52bceab11841"></see></summary>
    let EMMO_008fd3b2_4013_451f_8827_52bceab11841 =
        Namespaced_IRI.parse _namespace_name "EMMO_008fd3b2_4013_451f_8827_52bceab11841" |> NamespacedName

    /// <summary>
    /// The interpreter's internal representation of the object in a semiosis process.
    /// <see href="https://w3id.org/emmo#EMMO_054af807_85cd_4a13_8eba_119dfdaaf38b"></see></summary>
    let EMMO_054af807_85cd_4a13_8eba_119dfdaaf38b =
        Namespaced_IRI.parse _namespace_name "EMMO_054af807_85cd_4a13_8eba_119dfdaaf38b" |> NamespacedName

    /// <summary>
    /// A semiotic process that assigns a sign by deduction from causal continguity.
    /// <see href="https://w3id.org/emmo#EMMO_39a4e2a4_d835_426d_b497_182d06e1caff"></see></summary>
    let EMMO_39a4e2a4_d835_426d_b497_182d06e1caff =
        Namespaced_IRI.parse _namespace_name "EMMO_39a4e2a4_d835_426d_b497_182d06e1caff" |> NamespacedName

    /// <summary>
    /// A semiotic process that assigns a sign based on conventions.
    /// <see href="https://w3id.org/emmo#EMMO_47bf3513_4ae6_4858_9c45_76e23230d68d"></see></summary>
    let EMMO_47bf3513_4ae6_4858_9c45_76e23230d68d =
        Namespaced_IRI.parse _namespace_name "EMMO_47bf3513_4ae6_4858_9c45_76e23230d68d" |> NamespacedName

    /// <summary>
    /// A semiotic process that assigns a sign by recognising an object by how it resemble or imitate what the sign stands for, in shape, function or by sharing a similar logical structure.
    /// <see href="https://w3id.org/emmo#EMMO_7cdc375d_d371_4d78_acd5_d51732f52126"></see></summary>
    let EMMO_7cdc375d_d371_4d78_acd5_d51732f52126 =
        Namespaced_IRI.parse _namespace_name "EMMO_7cdc375d_d371_4d78_acd5_d51732f52126" |> NamespacedName

    /// <summary>
    /// An product that is ready for commercialisation.
    /// <see href="https://w3id.org/emmo#EMMO_00b85655_f20c_4e83_b90e_094e8ea7e48f"></see></summary>
    let EMMO_00b85655_f20c_4e83_b90e_094e8ea7e48f =
        Namespaced_IRI.parse _namespace_name "EMMO_00b85655_f20c_4e83_b90e_094e8ea7e48f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_00f2dc2d_2f64_468a_a77c_d70841b0b5f0"></see>
    /// </summary>
    let EMMO_00f2dc2d_2f64_468a_a77c_d70841b0b5f0 =
        Namespaced_IRI.parse _namespace_name "EMMO_00f2dc2d_2f64_468a_a77c_d70841b0b5f0" |> NamespacedName

    /// <summary>
    /// A chain of linked physics based model simulations solved iteratively, where equations are segregated.
    /// <see href="https://w3id.org/emmo#EMMO_01354ac2_cce1_4b7d_8b4a_7322d6cb10bc"></see></summary>
    let EMMO_01354ac2_cce1_4b7d_8b4a_7322d6cb10bc =
        Namespaced_IRI.parse _namespace_name "EMMO_01354ac2_cce1_4b7d_8b4a_7322d6cb10bc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_02c4890b_aef3_4173_9669_94d1f6baf611"></see>
    /// </summary>
    let EMMO_02c4890b_aef3_4173_9669_94d1f6baf611 =
        Namespaced_IRI.parse _namespace_name "EMMO_02c4890b_aef3_4173_9669_94d1f6baf611" |> NamespacedName

    /// <summary>
    /// Atom subclass for osmium.
    /// <see href="https://w3id.org/emmo#EMMO_016c831e-66b7-546e-ad4a-fc22c739b0f5"></see></summary>
    let ``EMMO_016c831e-66b7-546e-ad4a-fc22c739b0f5`` =
        Namespaced_IRI.parse _namespace_name "EMMO_016c831e-66b7-546e-ad4a-fc22c739b0f5" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the osmium atom.
    /// <see href="https://w3id.org/emmo#EMMO_fb1bb238-24bc-5d37-9243-414770fda5be"></see></summary>
    let ``EMMO_fb1bb238-24bc-5d37-9243-414770fda5be`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fb1bb238-24bc-5d37-9243-414770fda5be" |> NamespacedName

    /// <summary>
    /// Real part of the admittance.
    /// <see href="https://w3id.org/emmo#EMMO_01b80fdd_065c_4caf_b36c_4c0724936e24"></see></summary>
    let EMMO_01b80fdd_065c_4caf_b36c_4c0724936e24 =
        Namespaced_IRI.parse _namespace_name "EMMO_01b80fdd_065c_4caf_b36c_4c0724936e24" |> NamespacedName

    /// <summary>
    /// Measure of the ease for electric current to pass through a material.
    /// Inverse of 'ElectricalResistance'.
    /// <see href="https://w3id.org/emmo#EMMO_ffb73b1e_5786_43e4_a964_cb32ac7affb7"></see></summary>
    let EMMO_ffb73b1e_5786_43e4_a964_cb32ac7affb7 =
        Namespaced_IRI.parse _namespace_name "EMMO_ffb73b1e_5786_43e4_a964_cb32ac7affb7" |> NamespacedName

    /// <summary>
    /// URL corresponding to entry in Wikidata.
    /// <see href="https://w3id.org/emmo#EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54"></see></summary>
    let EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 =
        Namespaced_IRI.parse _namespace_name "EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54" |> NamespacedName

    /// <summary>
    /// URL for the entry in the International Electrotechnical Vocabulary (IEV).
    /// <see href="https://w3id.org/emmo#EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f"></see></summary>
    let EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f =
        Namespaced_IRI.parse _namespace_name "EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f" |> NamespacedName

    /// <summary>
    /// Corresponding item number in ISO 80 000.
    /// <see href="https://w3id.org/emmo#EMMO_8de5d5bf_db1c_40ac_b698_095ba3b18578"></see></summary>
    let EMMO_8de5d5bf_db1c_40ac_b698_095ba3b18578 =
        Namespaced_IRI.parse _namespace_name "EMMO_8de5d5bf_db1c_40ac_b698_095ba3b18578" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticReluctivity'.
    /// <see href="https://w3id.org/emmo#EMMO_01cd670e_d37c_424f_b91e_c2c2bbb5ea43"></see></summary>
    let EMMO_01cd670e_d37c_424f_b91e_c2c2bbb5ea43 =
        Namespaced_IRI.parse _namespace_name "EMMO_01cd670e_d37c_424f_b91e_c2c2bbb5ea43" |> NamespacedName

    /// <summary>
    /// Time derivative of the dose equivalent.
    /// <see href="https://w3id.org/emmo#EMMO_01e4191d_03ba_4107_a307_1c09c0e6a7d2"></see></summary>
    let EMMO_01e4191d_03ba_4107_a307_1c09c0e6a7d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_01e4191d_03ba_4107_a307_1c09c0e6a7d2" |> NamespacedName

    /// <summary>
    /// Differential quotient of the absorbed dose with respect to time.
    /// <see href="https://w3id.org/emmo#EMMO_15d36b02_fbb4_4c35_bca9_38e9c573baee"></see></summary>
    let EMMO_15d36b02_fbb4_4c35_bca9_38e9c573baee =
        Namespaced_IRI.parse _namespace_name "EMMO_15d36b02_fbb4_4c35_bca9_38e9c573baee" |> NamespacedName

    /// <summary>
    /// Causality is the fundamental concept describing how entities affect each other, and occurs before time and space relations.
    /// Embracing a strong reductionistic view, causality originates at quantum entities level.
    /// Causality in the EMMO is intended as physical causation and not counter-factual. Meaning that causality is an expression of actual physical interactions, and not of a counterfactual depence such as “I didn't water the flowers, hence, I'm the cause of their death”.
    /// The superclass of all causal EMMO relations.
    /// <see href="https://w3id.org/emmo#EMMO_ad0e72fc_dcaa_490d_8371_b4d814dcda2c"></see></summary>
    let EMMO_ad0e72fc_dcaa_490d_8371_b4d814dcda2c =
        Namespaced_IRI.parse _namespace_name "EMMO_ad0e72fc_dcaa_490d_8371_b4d814dcda2c" |> NamespacedName

    /// <summary>
    /// A system is conceived as an aggregate of things that 'work' (or interact) together. While a system extends in time through distinct temporal parts (like every other 4D object), this elucdation focuses on a timescale in which the obejct shows a persistence in time.
    /// An object that is made of a set of sub objects working together as parts of a mechanism or an interconnecting network (natural or artificial); a complex whole.
    /// <see href="https://w3id.org/emmo#EMMO_65a007dc_2550_46b0_b394_3346c67fbb69"></see></summary>
    let EMMO_65a007dc_2550_46b0_b394_3346c67fbb69 =
        Namespaced_IRI.parse _namespace_name "EMMO_65a007dc_2550_46b0_b394_3346c67fbb69" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0266ec8c_bd13_4c9c_be77_607498793ed3"></see>
    /// </summary>
    let EMMO_0266ec8c_bd13_4c9c_be77_607498793ed3 =
        Namespaced_IRI.parse _namespace_name "EMMO_0266ec8c_bd13_4c9c_be77_607498793ed3" |> NamespacedName

    /// <summary>
    /// This is the superproperty of all data properties used to serialise a fundamental data type in the EMMO Data perspective. An entity can have only one data value expressing its serialisation (e.g. a Real entity cannot have two different real values).
    /// The owl:dataProperty that provides a serialisation of an EMMO data entity.
    /// <see href="https://w3id.org/emmo#EMMO_b6292331_94af_4f00_976b_ea55960c2f1c"></see></summary>
    let EMMO_b6292331_94af_4f00_976b_ea55960c2f1c =
        Namespaced_IRI.parse _namespace_name "EMMO_b6292331_94af_4f00_976b_ea55960c2f1c" |> NamespacedName

    /// <summary>
    /// A qualified role is an entity of a type that requires to be part of a another specific and different type. For example, a participant is always required to be part of a process, or a student always requires to be part of a school.
    /// This definition provides a clear and precise way to define what a role is.
    /// The superclass for all classes whose entities are part of an entity of different type.
    /// <see href="https://w3id.org/emmo#EMMO_56cf1cea_bb26_4093_b587_dd64e230bf9b"></see></summary>
    let EMMO_56cf1cea_bb26_4093_b587_dd64e230bf9b =
        Namespaced_IRI.parse _namespace_name "EMMO_56cf1cea_bb26_4093_b587_dd64e230bf9b" |> NamespacedName

    /// <summary>
    /// A qualified whole is an entity of a type that requires to have parts of a another specific and different type. For example, a process always requires to have a participant, or a car always requires to have a powertrain.
    /// This definition provides a clear and precise way to define what a whole is.
    /// The superclass for all classes whose entities requires to have at least a part of different type.
    /// <see href="https://w3id.org/emmo#EMMO_a374f1d4_55b1_4796_a8c6_88668f205cd2"></see></summary>
    let EMMO_a374f1d4_55b1_4796_a8c6_88668f205cd2 =
        Namespaced_IRI.parse _namespace_name "EMMO_a374f1d4_55b1_4796_a8c6_88668f205cd2" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_02a935c8_c2d4_4a00_bd6f_b89d05aac79e"></see></summary>
    let EMMO_02a935c8_c2d4_4a00_bd6f_b89d05aac79e =
        Namespaced_IRI.parse _namespace_name "EMMO_02a935c8_c2d4_4a00_bd6f_b89d05aac79e" |> NamespacedName

    /// <summary>
    /// Measurement units of quantities of the same quantity dimension may be designated by the same name and symbol even when the quantities are not of the same kind.
    ///
    /// For example, joule per kelvin and J/K are respectively the name and symbol of both a measurement unit of heat capacity and a measurement unit of entropy, which are generally not considered to be quantities of the same kind.
    ///
    /// However, in some cases special measurement unit names are restricted to be used with quantities of specific kind only.
    ///
    /// For example, the measurement unit ‘second to the power minus one’ (1/s) is called hertz (Hz) when used for frequencies and becquerel (Bq) when used for activities of radionuclides.
    ///
    /// As another example, the joule (J) is used as a unit of energy, but never as a unit of moment of force, i.e. the newton metre (N · m).
    /// Measured or simulated 'physical propertiy'-s are always defined by a physical law, connected to a physical entity through a model perspective and measurement is done according to the same model.
    ///
    /// Systems of units suggests that this is the correct approach, since except for the fundamental units (length, time, charge) every other unit is derived by mathematical relations between these fundamental units, implying a physical laws or definitions.
    /// — quantities of the same kind have the same quantity dimension,
    /// — quantities of different quantity dimensions are always of different kinds, and
    /// — quantities having the same quantity dimension are not necessarily of the same kind.
    /// ISO 80000-1
    /// In the same system of quantities, dim ρB = ML−3 is the quantity dimension of mass concentration of component B, and ML−3 is also the quantity dimension of mass density, ρ.
    /// ISO 80000-1
    /// A 'Mathematical' entity that is made of a 'Numeral' and a 'MeasurementUnit' defined by a physical law, connected to a physical entity through a model perspective. Measurement is done according to the same model.
    /// <see href="https://w3id.org/emmo#EMMO_02c0621e_a527_4790_8a0f_2bb51973c819"></see></summary>
    let EMMO_02c0621e_a527_4790_8a0f_2bb51973c819 =
        Namespaced_IRI.parse _namespace_name "EMMO_02c0621e_a527_4790_8a0f_2bb51973c819" |> NamespacedName

    /// <summary>
    /// Relates a quantity to its metrological reference through a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_67fc0a36_8dcb_4ffa_9a43_31074efa3296"></see></summary>
    let EMMO_67fc0a36_8dcb_4ffa_9a43_31074efa3296 =
        Namespaced_IRI.parse _namespace_name "EMMO_67fc0a36_8dcb_4ffa_9a43_31074efa3296" |> NamespacedName

    /// <summary>
    /// A metrological reference for a physical quantity.
    /// "Real scalar quantity, defined and adopted by convention, with which any other quantity of the same kind can be compared to express the ratio of the second quantity to the first one as a number"
    /// ISO 80000-1
    /// <see href="https://w3id.org/emmo#EMMO_b081b346_7279_46ef_9a3d_2c088fcd79f4"></see></summary>
    let EMMO_b081b346_7279_46ef_9a3d_2c088fcd79f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_b081b346_7279_46ef_9a3d_2c088fcd79f4" |> NamespacedName

    /// <summary>
    /// "Quantity, in a system of quantities, defined in terms of the base quantities of that system".
    /// <see href="https://w3id.org/emmo#EMMO_71f6ab56_342c_484b_bbe0_de86b7367cb3"></see></summary>
    let EMMO_71f6ab56_342c_484b_bbe0_de86b7367cb3 =
        Namespaced_IRI.parse _namespace_name "EMMO_71f6ab56_342c_484b_bbe0_de86b7367cb3" |> NamespacedName

    /// <summary>
    /// "Quantity in a conventionally chosen subset of a given system of quantities, where no quantity in the subset can be expressed in terms of the other quantities within that subset"
    /// ISO 80000-1
    /// <see href="https://w3id.org/emmo#EMMO_acaaa124_3dde_48b6_86e6_6ec6f364f408"></see></summary>
    let EMMO_acaaa124_3dde_48b6_86e6_6ec6f364f408 =
        Namespaced_IRI.parse _namespace_name "EMMO_acaaa124_3dde_48b6_86e6_6ec6f364f408" |> NamespacedName

    /// <summary>
    /// A physics based simulation with multiple physics based models.
    /// <see href="https://w3id.org/emmo#EMMO_7d56ec24_499d_487a_af7d_a91aaa787bfe"></see></summary>
    let EMMO_7d56ec24_499d_487a_af7d_a91aaa787bfe =
        Namespaced_IRI.parse _namespace_name "EMMO_7d56ec24_499d_487a_af7d_a91aaa787bfe" |> NamespacedName

    /// <summary>
    /// A simulation in which more than one model are solved together with a coupled method.
    /// <see href="https://w3id.org/emmo#EMMO_fbcc3aad_c58a_4185_bcc9_859db779b226"></see></summary>
    let EMMO_fbcc3aad_c58a_4185_bcc9_859db779b226 =
        Namespaced_IRI.parse _namespace_name "EMMO_fbcc3aad_c58a_4185_bcc9_859db779b226" |> NamespacedName

    /// <summary>
    /// The owl:dataProperty that provides a serialisation of an EMMO string data entity.
    /// <see href="https://w3id.org/emmo#EMMO_02face50_43a1_40ce_a909_dfe54d5e186b"></see></summary>
    let EMMO_02face50_43a1_40ce_a909_dfe54d5e186b =
        Namespaced_IRI.parse _namespace_name "EMMO_02face50_43a1_40ce_a909_dfe54d5e186b" |> NamespacedName

    /// <summary>
    /// Symbolic data that consist of a sequence of characters.
    /// Since a string is a simple type that can contain only characters but not other child elements, is often not suitable for representing human text, that may need additional elements for control of aspects such as bidirectional formatting or ruby annotation.
    /// <see href="https://w3id.org/emmo#EMMO_5f334606_f67d_4f0e_acb9_eeb21cb10c66"></see></summary>
    let EMMO_5f334606_f67d_4f0e_acb9_eeb21cb10c66 =
        Namespaced_IRI.parse _namespace_name "EMMO_5f334606_f67d_4f0e_acb9_eeb21cb10c66" |> NamespacedName

    /// <summary>
    /// Ratio of magnetic dipole moment to total angular momentum.
    /// <see href="https://w3id.org/emmo#EMMO_030ce585_429a_4cfb_95c2_8364e58a1ebb"></see></summary>
    let EMMO_030ce585_429a_4cfb_95c2_8364e58a1ebb =
        Namespaced_IRI.parse _namespace_name "EMMO_030ce585_429a_4cfb_95c2_8364e58a1ebb" |> NamespacedName

    /// <summary>
    /// Derived quantities defined in the International System of Quantities (ISQ).
    /// <see href="https://w3id.org/emmo#EMMO_2946d40b_24a1_47fa_8176_e3f79bb45064"></see></summary>
    let EMMO_2946d40b_24a1_47fa_8176_e3f79bb45064 =
        Namespaced_IRI.parse _namespace_name "EMMO_2946d40b_24a1_47fa_8176_e3f79bb45064" |> NamespacedName

    /// <summary>
    /// A conventional semiotic relation that relates a physical quantity to its unit.
    /// <see href="https://w3id.org/emmo#EMMO_bed1d005_b04e_4a90_94cf_02bc678a8569"></see></summary>
    let EMMO_bed1d005_b04e_4a90_94cf_02bc678a8569 =
        Namespaced_IRI.parse _namespace_name "EMMO_bed1d005_b04e_4a90_94cf_02bc678a8569" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-10.
    /// <see href="https://w3id.org/emmo#EMMO_3b1b64d1_60c9_4689_a300_eb9cd56e368b"></see></summary>
    let EMMO_3b1b64d1_60c9_4689_a300_eb9cd56e368b =
        Namespaced_IRI.parse _namespace_name "EMMO_3b1b64d1_60c9_4689_a300_eb9cd56e368b" |> NamespacedName

    /// <summary>
    /// The velocity depends on the choice of the reference frame. Proper transformation between frames must be used: Galilean for non-relativistic description, Lorentzian for relativistic description.
    ///
    /// -- IEC, note 2
    /// The velocity is related to a point described by its position vector. The point may localize a particle, or be attached to any other object such as a body or a wave.
    ///
    /// -- IEC, note 1
    /// Vector quantity giving the rate of change of a position vector.
    ///
    /// -- ISO 80000-3
    /// <see href="https://w3id.org/emmo#EMMO_0329f1f5_8339_4ce4_8505_a264c6d606ba"></see></summary>
    let EMMO_0329f1f5_8339_4ce4_8505_a264c6d606ba =
        Namespaced_IRI.parse _namespace_name "EMMO_0329f1f5_8339_4ce4_8505_a264c6d606ba" |> NamespacedName

    /// <summary>
    /// A quantity whose magnitude is independent of the size of the system.
    /// Note that not all physical quantities can be categorised as being either intensive or extensive. For example the square root of the mass.
    /// <see href="https://w3id.org/emmo#EMMO_602397bd_e302_42a6_be33_fe67ea81933a"></see></summary>
    let EMMO_602397bd_e302_42a6_be33_fe67ea81933a =
        Namespaced_IRI.parse _namespace_name "EMMO_602397bd_e302_42a6_be33_fe67ea81933a" |> NamespacedName

    /// <summary>
    /// 1-dimensional array who's spatial direct parts are numbers.
    /// <see href="https://w3id.org/emmo#EMMO_06658d8d_dcde_4fc9_aae1_17f71c0bcdec"></see></summary>
    let EMMO_06658d8d_dcde_4fc9_aae1_17f71c0bcdec =
        Namespaced_IRI.parse _namespace_name "EMMO_06658d8d_dcde_4fc9_aae1_17f71c0bcdec" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Speed'.
    /// <see href="https://w3id.org/emmo#EMMO_4f5c7c54_1c63_4d17_b12b_ea0792c2b187"></see></summary>
    let EMMO_4f5c7c54_1c63_4d17_b12b_ea0792c2b187 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f5c7c54_1c63_4d17_b12b_ea0792c2b187" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-3.
    /// <see href="https://w3id.org/emmo#EMMO_a242d3e9_c6d3_411e_a667_71ffbc248a1a"></see></summary>
    let EMMO_a242d3e9_c6d3_411e_a667_71ffbc248a1a =
        Namespaced_IRI.parse _namespace_name "EMMO_a242d3e9_c6d3_411e_a667_71ffbc248a1a" |> NamespacedName

    /// <summary>
    /// Speed in the absolute value of the velocity.
    /// Length per unit time.
    /// <see href="https://w3id.org/emmo#EMMO_81369540_1b0e_471b_9bae_6801af22800e"></see></summary>
    let EMMO_81369540_1b0e_471b_9bae_6801af22800e =
        Namespaced_IRI.parse _namespace_name "EMMO_81369540_1b0e_471b_9bae_6801af22800e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0342678c_13ba_43d7_9cbd_df60967a0a45"></see>
    /// </summary>
    let EMMO_0342678c_13ba_43d7_9cbd_df60967a0a45 =
        Namespaced_IRI.parse _namespace_name "EMMO_0342678c_13ba_43d7_9cbd_df60967a0a45" |> NamespacedName

    /// <summary>
    /// From Powder, from liquid, from gas
    /// da una forma non propria ad una forma propria
    /// <see href="https://w3id.org/emmo#EMMO_45fec702_54cb_4508_b47e_bdc581229e22"></see></summary>
    let EMMO_45fec702_54cb_4508_b47e_bdc581229e22 =
        Namespaced_IRI.parse _namespace_name "EMMO_45fec702_54cb_4508_b47e_bdc581229e22" |> NamespacedName

    /// <summary>
    /// Angle between the scattered ray and the lattice plane.
    /// <see href="https://w3id.org/emmo#EMMO_034bc7dd_a8c2_4ed0_8b51_66ac9b00342f"></see></summary>
    let EMMO_034bc7dd_a8c2_4ed0_8b51_66ac9b00342f =
        Namespaced_IRI.parse _namespace_name "EMMO_034bc7dd_a8c2_4ed0_8b51_66ac9b00342f" |> NamespacedName

    /// <summary>
    /// Ratio of circular arc length to radius.
    /// <see href="https://w3id.org/emmo#EMMO_f3dd74c0_f480_49e8_9764_33b78638c235"></see></summary>
    let EMMO_f3dd74c0_f480_49e8_9764_33b78638c235 =
        Namespaced_IRI.parse _namespace_name "EMMO_f3dd74c0_f480_49e8_9764_33b78638c235" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-12.
    /// <see href="https://w3id.org/emmo#EMMO_c29603f5_95e8_42f5_ab0c_f3bcf3166d53"></see></summary>
    let EMMO_c29603f5_95e8_42f5_ab0c_f3bcf3166d53 =
        Namespaced_IRI.parse _namespace_name "EMMO_c29603f5_95e8_42f5_ab0c_f3bcf3166d53" |> NamespacedName

    /// <summary>
    /// Resonance in a nuclear reaction, determined by the kinetic energy of an incident particle in the reference frame of the target particle.
    /// <see href="https://w3id.org/emmo#EMMO_038cb8cb_c035_40c1_a3e7_7f24d63b2804"></see></summary>
    let EMMO_038cb8cb_c035_40c1_a3e7_7f24d63b2804 =
        Namespaced_IRI.parse _namespace_name "EMMO_038cb8cb_c035_40c1_a3e7_7f24d63b2804" |> NamespacedName

    /// <summary>
    /// A property of objects which can be transferred to other objects or converted into different forms.
    /// Energy is often defined as "ability of a system to perform work", but it might be misleading since is not necessarily available to do work.
    /// <see href="https://w3id.org/emmo#EMMO_31ec09ba_1713_42cb_83c7_b38bf6f9ced2"></see></summary>
    let EMMO_31ec09ba_1713_42cb_83c7_b38bf6f9ced2 =
        Namespaced_IRI.parse _namespace_name "EMMO_31ec09ba_1713_42cb_83c7_b38bf6f9ced2" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1/100.
    /// <see href="https://w3id.org/emmo#EMMO_03d2c71b_0276_45d7_a847_7cd164cb7d45"></see></summary>
    let EMMO_03d2c71b_0276_45d7_a847_7cd164cb7d45 =
        Namespaced_IRI.parse _namespace_name "EMMO_03d2c71b_0276_45d7_a847_7cd164cb7d45" |> NamespacedName

    /// <summary>
    /// The owl:dataProperty that provides a serialisation of an EMMO numerical data entity.
    /// <see href="https://w3id.org/emmo#EMMO_faf79f53_749d_40b2_807c_d34244c192f4"></see></summary>
    let EMMO_faf79f53_749d_40b2_807c_d34244c192f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_faf79f53_749d_40b2_807c_d34244c192f4" |> NamespacedName

    /// <summary>
    /// Fundamental translation vector for the crystal lattice.
    /// <see href="https://w3id.org/emmo#EMMO_03d32783_3780_43c3_8b73_7efe9aeeed54"></see></summary>
    let EMMO_03d32783_3780_43c3_8b73_7efe9aeeed54 =
        Namespaced_IRI.parse _namespace_name "EMMO_03d32783_3780_43c3_8b73_7efe9aeeed54" |> NamespacedName

    /// <summary>
    /// A computer language used to describe simulations.
    /// <see href="https://w3id.org/emmo#EMMO_03d4cd70_0d16_4403_b68c_d41a9117f981"></see></summary>
    let EMMO_03d4cd70_0d16_4403_b68c_d41a9117f981 =
        Namespaced_IRI.parse _namespace_name "EMMO_03d4cd70_0d16_4403_b68c_d41a9117f981" |> NamespacedName

    /// <summary>
    /// An artificial computer language used to express information or knowledge, often for use in computer system design.
    /// <see href="https://w3id.org/emmo#EMMO_18c4634c_b821_49a3_beff_5eb7515ffc40"></see></summary>
    let EMMO_18c4634c_b821_49a3_beff_5eb7515ffc40 =
        Namespaced_IRI.parse _namespace_name "EMMO_18c4634c_b821_49a3_beff_5eb7515ffc40" |> NamespacedName

    /// <summary>
    /// Disintegrations per unit time dN/dt for an atomic nucleus divided by the number of nuclei N existing at the same time t.
    /// <see href="https://w3id.org/emmo#EMMO_0449de81_0995_4575_8f2b_2c70cffafa71"></see></summary>
    let EMMO_0449de81_0995_4575_8f2b_2c70cffafa71 =
        Namespaced_IRI.parse _namespace_name "EMMO_0449de81_0995_4575_8f2b_2c70cffafa71" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LuminousEfficacy'.
    /// <see href="https://w3id.org/emmo#EMMO_044f83a6_ade4_4441_9c73_5490dd93344f"></see></summary>
    let EMMO_044f83a6_ade4_4441_9c73_5490dd93344f =
        Namespaced_IRI.parse _namespace_name "EMMO_044f83a6_ade4_4441_9c73_5490dd93344f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_048a14e3_65fb_457d_8695_948965c89492"></see>
    /// </summary>
    let EMMO_048a14e3_65fb_457d_8695_948965c89492 =
        Namespaced_IRI.parse _namespace_name "EMMO_048a14e3_65fb_457d_8695_948965c89492" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f8a2fe9f_458b_4771_9aba_a50e76afc52d"></see>
    /// </summary>
    let EMMO_f8a2fe9f_458b_4771_9aba_a50e76afc52d =
        Namespaced_IRI.parse _namespace_name "EMMO_f8a2fe9f_458b_4771_9aba_a50e76afc52d" |> NamespacedName

    /// <summary>
    /// The amount of a constituent divided by the total amount of all constituents in a mixture.
    /// <see href="https://w3id.org/emmo#EMMO_04b3300c_98bd_42dc_a3b5_e6c29d69f1ac"></see></summary>
    let EMMO_04b3300c_98bd_42dc_a3b5_e6c29d69f1ac =
        Namespaced_IRI.parse _namespace_name "EMMO_04b3300c_98bd_42dc_a3b5_e6c29d69f1ac" |> NamespacedName

    /// <summary>
    /// Quantities defined as ratios `Q=A/B` having equal dimensions in numerator and denominator are dimensionless quantities but still have a physical dimension defined as dim(A)/dim(B).
    ///
    /// Johansson, Ingvar (2010). "Metrological thinking needs the notions of parametric quantities, units and dimensions". Metrologia. 47 (3): 219–230. doi:10.1088/0026-1394/47/3/012. ISSN 0026-1394.
    /// The class of quantities that are the ratio of two quantities with the same physical dimensionality.
    /// <see href="https://w3id.org/emmo#EMMO_faab3f84_e475_4a46_af9c_7d249f0b9aef"></see></summary>
    let EMMO_faab3f84_e475_4a46_af9c_7d249f0b9aef =
        Namespaced_IRI.parse _namespace_name "EMMO_faab3f84_e475_4a46_af9c_7d249f0b9aef" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a293f923_954c_4af5_9f97_9600ebd362cb"></see>
    /// </summary>
    let EMMO_a293f923_954c_4af5_9f97_9600ebd362cb =
        Namespaced_IRI.parse _namespace_name "EMMO_a293f923_954c_4af5_9f97_9600ebd362cb" |> NamespacedName

    /// <summary>
    /// A property of an electrical conductor by which a change in current through it induces an electromotive force in both the conductor itself and in any nearby conductors by mutual inductance.
    /// <see href="https://w3id.org/emmo#EMMO_04cc9451_5306_45d0_8554_22cee4d6e785"></see></summary>
    let EMMO_04cc9451_5306_45d0_8554_22cee4d6e785 =
        Namespaced_IRI.parse _namespace_name "EMMO_04cc9451_5306_45d0_8554_22cee4d6e785" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Inductance'.
    /// <see href="https://w3id.org/emmo#EMMO_585e0ff0_9429_4d3c_b578_58abb1ba21d1"></see></summary>
    let EMMO_585e0ff0_9429_4d3c_b578_58abb1ba21d1 =
        Namespaced_IRI.parse _namespace_name "EMMO_585e0ff0_9429_4d3c_b578_58abb1ba21d1" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-6.
    /// <see href="https://w3id.org/emmo#EMMO_af794e9d_dc7d_4756_83e1_2cd0e2ec864e"></see></summary>
    let EMMO_af794e9d_dc7d_4756_83e1_2cd0e2ec864e =
        Namespaced_IRI.parse _namespace_name "EMMO_af794e9d_dc7d_4756_83e1_2cd0e2ec864e" |> NamespacedName

    /// <summary>
    /// Force of gravity acting on a body.
    /// <see href="https://w3id.org/emmo#EMMO_04cf0295_3e8f_4693_a87f_3130d125cf05"></see></summary>
    let EMMO_04cf0295_3e8f_4693_a87f_3130d125cf05 =
        Namespaced_IRI.parse _namespace_name "EMMO_04cf0295_3e8f_4693_a87f_3130d125cf05" |> NamespacedName

    /// <summary>
    /// Any interaction that, when unopposed, will change the motion of an object
    /// <see href="https://w3id.org/emmo#EMMO_1f087811_06cb_42d5_90fb_25d0e7e068ef"></see></summary>
    let EMMO_1f087811_06cb_42d5_90fb_25d0e7e068ef =
        Namespaced_IRI.parse _namespace_name "EMMO_1f087811_06cb_42d5_90fb_25d0e7e068ef" |> NamespacedName

    /// <summary>
    /// Gas is a compressible fluid, a state of matter that has no fixed shape and no fixed volume.
    /// <see href="https://w3id.org/emmo#EMMO_04f2a2d5_e799_4692_a654_420e76f5acc1"></see></summary>
    let EMMO_04f2a2d5_e799_4692_a654_420e76f5acc1 =
        Namespaced_IRI.parse _namespace_name "EMMO_04f2a2d5_e799_4692_a654_420e76f5acc1" |> NamespacedName

    /// <summary>
    /// A continuum that has no fixed shape and yields easily to external pressure.
    /// <see href="https://w3id.org/emmo#EMMO_87ac88ff_8379_4f5a_8c7b_424a8fff1ee8"></see></summary>
    let EMMO_87ac88ff_8379_4f5a_8c7b_424a8fff1ee8 =
        Namespaced_IRI.parse _namespace_name "EMMO_87ac88ff_8379_4f5a_8c7b_424a8fff1ee8" |> NamespacedName

    /// <summary>
    /// The entity (or agent, or observer, or cognitive entity) who connects 'Sign', 'Interpretant' and 'Object'.
    /// The interpreter is not the ontologist, being the ontologist acting outside the ontology at the meta-ontology level.
    ///
    /// On the contrary, the interpreter is an agent recognized by the ontologist. The semiotic branch of the EMMO is the tool used by the ontologist to represent an interpreter's semiotic activity.
    /// <see href="https://w3id.org/emmo#EMMO_0527413c_b286_4e9c_b2d0_03fb2a038dee"></see></summary>
    let EMMO_0527413c_b286_4e9c_b2d0_03fb2a038dee =
        Namespaced_IRI.parse _namespace_name "EMMO_0527413c_b286_4e9c_b2d0_03fb2a038dee" |> NamespacedName

    /// <summary>
    /// An interpreter who establish the connection between an conventional sign and an object according to a specific convention.
    /// <see href="https://w3id.org/emmo#EMMO_2d72e38c_d587_437f_98f6_f2718fb130eb"></see></summary>
    let EMMO_2d72e38c_d587_437f_98f6_f2718fb130eb =
        Namespaced_IRI.parse _namespace_name "EMMO_2d72e38c_d587_437f_98f6_f2718fb130eb" |> NamespacedName

    /// <summary>
    /// An interpreter who establish the connection between an index sign and an object according to a causal contiguity.
    /// <see href="https://w3id.org/emmo#EMMO_36a4c1ca_5085_49ca_9e13_4c70d00c50a5"></see></summary>
    let EMMO_36a4c1ca_5085_49ca_9e13_4c70d00c50a5 =
        Namespaced_IRI.parse _namespace_name "EMMO_36a4c1ca_5085_49ca_9e13_4c70d00c50a5" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountSquareTimePerMassVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_052e9796_1144_43ae_a798_c5755cd6cd81"></see></summary>
    let EMMO_052e9796_1144_43ae_a798_c5755cd6cd81 =
        Namespaced_IRI.parse _namespace_name "EMMO_052e9796_1144_43ae_a798_c5755cd6cd81" |> NamespacedName

    /// <summary>
    /// An 'Physical' that is used as sign ("semeion" in greek) that stands for another 'Physical' through an semiotic process.
    /// A 'Sign' can have temporal-direct-parts which are 'Sign' themselves.
    ///
    /// A 'Sign' usually havs 'sign' spatial direct parts only up to a certain elementary semiotic level, in which the part is only a 'Physical' and no more a 'Sign' (i.e. it stands for nothing). This elementary semiotic level is peculiar to each particular system of signs (e.g. text, painting).
    ///
    /// Just like an 'Elementary' in the 'Physical' branch, each 'Sign' branch should have an a-tomistic mereological part.
    /// According to Peirce, 'Sign' includes three subcategories:
    /// - symbols: that stand for an object through convention
    /// - indeces: that stand for an object due to causal continguity
    /// - icons: that stand for an object due to similitudes e.g. in shape or composition
    /// <see href="https://w3id.org/emmo#EMMO_b21a56ed_f969_4612_a6ec_cb7766f7f31d"></see></summary>
    let EMMO_b21a56ed_f969_4612_a6ec_cb7766f7f31d =
        Namespaced_IRI.parse _namespace_name "EMMO_b21a56ed_f969_4612_a6ec_cb7766f7f31d" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting an index sign to the interpreter (deducer) in a deduction process.
    /// <see href="https://w3id.org/emmo#EMMO_057d0573_6ac0_4c27_9e3f_3c29205fd104"></see></summary>
    let EMMO_057d0573_6ac0_4c27_9e3f_3c29205fd104 =
        Namespaced_IRI.parse _namespace_name "EMMO_057d0573_6ac0_4c27_9e3f_3c29205fd104" |> NamespacedName

    /// <summary>
    /// A discrete schema may be based on a continuum material basis that is filtered according to its variations. For example, a continuous voltage based signal can be considered 1 or 0 according to some threshold.
    /// Discrete does not mean that the material basis is discrete, but that the data are encoded according to such step-based rules.
    /// Data whose variations are decoded according to a discrete schema.
    /// <see href="https://w3id.org/emmo#EMMO_be8592a7_68d1_4a06_ad23_82f2b56ef926"></see></summary>
    let EMMO_be8592a7_68d1_4a06_ad23_82f2b56ef926 =
        Namespaced_IRI.parse _namespace_name "EMMO_be8592a7_68d1_4a06_ad23_82f2b56ef926" |> NamespacedName

    /// <summary>
    /// A symbolic entity made of other symbolic entities according to a specific spatial configuration.
    /// This class collects individuals that represents arrangements of strings, or other symbolic compositions, without any particular predifined arrangement schema.
    /// <see href="https://w3id.org/emmo#EMMO_89a0c87c_0804_4013_937a_6fe234d9499c"></see></summary>
    let EMMO_89a0c87c_0804_4013_937a_6fe234d9499c =
        Namespaced_IRI.parse _namespace_name "EMMO_89a0c87c_0804_4013_937a_6fe234d9499c" |> NamespacedName

    /// <summary>
    /// Subclasses of 'Symbol' are alphabets, in formal languages terminology. A 'Symbol' is atomic for that alphabet, i.e. it has no parts that are symbols for the same alphabet.
    /// e.g. a math symbol is not made of other math symbols
    /// A Symbol may be a String in another language.
    /// e.g. "Bq" is the symbol for Becquerel units when dealing with metrology, or a string of "B" and "q" symbols when dealing with characters.
    /// The class of individuals that stand for an elementary mark of a specific symbolic code (alphabet).
    /// <see href="https://w3id.org/emmo#EMMO_a1083d0a_c1fb_471f_8e20_a98f881ad527"></see></summary>
    let EMMO_a1083d0a_c1fb_471f_8e20_a98f881ad527 =
        Namespaced_IRI.parse _namespace_name "EMMO_a1083d0a_c1fb_471f_8e20_a98f881ad527" |> NamespacedName

    /// <summary>
    /// Quantity representing the spatial distribution of mass in a continuous material.
    /// <see href="https://w3id.org/emmo#EMMO_06448f64_8db6_4304_8b2c_e785dba82044"></see></summary>
    let EMMO_06448f64_8db6_4304_8b2c_e785dba82044 =
        Namespaced_IRI.parse _namespace_name "EMMO_06448f64_8db6_4304_8b2c_e785dba82044" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Density'.
    /// <see href="https://w3id.org/emmo#EMMO_1c957677_a460_4702_85a6_baef659d14b1"></see></summary>
    let EMMO_1c957677_a460_4702_85a6_baef659d14b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_1c957677_a460_4702_85a6_baef659d14b1" |> NamespacedName

    /// <summary>
    /// A semiotic relation that connects a semiotic object to a property in a declaration process.
    /// <see href="https://w3id.org/emmo#EMMO_e1097637_70d2_4895_973f_2396f04fa204"></see></summary>
    let EMMO_e1097637_70d2_4895_973f_2396f04fa204 =
        Namespaced_IRI.parse _namespace_name "EMMO_e1097637_70d2_4895_973f_2396f04fa204" |> NamespacedName

    /// <summary>
    /// A symbolic is recognized as reference unit also if it is not part of a quantity (e.g. as in the sentence "the Bq is the reference unit of Becquerel").
    /// For this reason we can't declare the axiom:
    /// MetrologicalReference SubClassOf: inverse(hasMetrologicalReference) some Quantity
    /// because there exist reference units without being part of a quantity.
    /// This is peculiar to EMMO, where quantities as syntatic entities (explicit quantities) are distinct with quantities as semantic entities (properties).
    /// A reference can be a measurement unit, a measurement procedure, a reference material, or a combination of such (VIM3 1.1 NOTE 2).
    /// <see href="https://w3id.org/emmo#EMMO_18ce5200_00f5_45bb_8c6f_6fb128cd41ae"></see></summary>
    let EMMO_18ce5200_00f5_45bb_8c6f_6fb128cd41ae =
        Namespaced_IRI.parse _namespace_name "EMMO_18ce5200_00f5_45bb_8c6f_6fb128cd41ae" |> NamespacedName

    /// <summary>
    /// A quantity whos value that cannot be univocally determined and depends on an agent (e.g. a human individual, a community).
    /// <see href="https://w3id.org/emmo#EMMO_a9a6ddf8_7e16_420a_9f3d_df7d5cfe3536"></see></summary>
    let EMMO_a9a6ddf8_7e16_420a_9f3d_df7d5cfe3536 =
        Namespaced_IRI.parse _namespace_name "EMMO_a9a6ddf8_7e16_420a_9f3d_df7d5cfe3536" |> NamespacedName

    /// <summary>
    /// The word objective does not mean that each observation will provide the same results. It means that the observation followed a well defined procedure.
    ///
    /// This class refers to what is commonly known as physical property, i.e. a measurable property of physical system, whether is quantifiable or not.
    /// A quantity that is obtained from a well-defined procedure.
    /// Subclasses of 'ObjectiveProperty' classify objects according to the type semiosis that is used to connect the property to the object (e.g. by measurement, by convention, by modelling).
    /// <see href="https://w3id.org/emmo#EMMO_dd4a7f3e_ef56_466c_ac1a_d2716b5f87ec"></see></summary>
    let EMMO_dd4a7f3e_ef56_466c_ac1a_d2716b5f87ec =
        Namespaced_IRI.parse _namespace_name "EMMO_dd4a7f3e_ef56_466c_ac1a_d2716b5f87ec" |> NamespacedName

    /// <summary>
    /// "Ordinal quantities, such as Rockwell C hardness, are usually not considered to be part of a system of quantities because they are related to other quantities through empirical relations only."
    /// International vocabulary of metrology (VIM)
    /// "Quantity, defined by a conventional measurement procedure, for which a total ordering relation can be established, according to magnitude, with other quantities of the same kind, but for which no algebraic operations among those quantities exist"
    /// International vocabulary of metrology (VIM)
    /// <see href="https://w3id.org/emmo#EMMO_c46f091c_0420_4c1a_af30_0a2c8ebcf7d7"></see></summary>
    let EMMO_c46f091c_0420_4c1a_af30_0a2c8ebcf7d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_c46f091c_0420_4c1a_af30_0a2c8ebcf7d7" |> NamespacedName

    /// <summary>
    /// Dimensionless quantity in electromagnetism.
    /// <see href="https://w3id.org/emmo#EMMO_0658e7df_ffd9_4779_82fc_62efe0a7f3b1"></see></summary>
    let EMMO_0658e7df_ffd9_4779_82fc_62efe0a7f3b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_0658e7df_ffd9_4779_82fc_62efe0a7f3b1" |> NamespacedName

    /// <summary>
    /// Arrays are ordered objects, since they are a subclasses of Arrangement.
    /// Arrays are ordered mathematical objects who's elementary spatial parts are numbers. Their dimensionality is constructed with spatial direct parthood, where 1-dimensional arrays have spatial direct parts Number and n-dimensional array have spatial direct parts (n-1)-dimensional arrays.
    /// Array subclasses with a specific shape can be constructed with cardinality restrictions.
    ///
    /// See Shape4x3Matrix as an example.
    /// <see href="https://w3id.org/emmo#EMMO_28fbea28_2204_4613_87ff_6d877b855fcd"></see></summary>
    let EMMO_28fbea28_2204_4613_87ff_6d877b855fcd =
        Namespaced_IRI.parse _namespace_name "EMMO_28fbea28_2204_4613_87ff_6d877b855fcd" |> NamespacedName

    /// <summary>
    /// In math usually number and numeral are distinct concepts, the numeral being the symbol or a composition of symbols (e.g. 3.14, 010010, three) and the number is the idea behind it.
    /// More than one numeral stands for the same number.
    /// In the EMMO abstract entities do not exists, and numbers are simply defined by other numerals, so that a number is the class of all the numerals that are equivalent (e.g. 3 and 0011 are numerals that stands for the same number).
    /// Or alternatively, an integer numeral may also stands for a set of a specific cardinality (e.g. 3 stands for a set of three apples). Rational and real numbers are simply a syntactic arrangment of integers (digits, in decimal system).
    /// The fact that you can't give a name to a number without using a numeral or, in case of positive integers, without referring to a real world objects set with specific cardinality, suggests that the abstract concept of number is not a concept that can be practically used.
    /// For these reasons, the EMMO will consider numerals and numbers as the same concept.
    /// A number is actually a string (e.g. 1.4, 1e-8) of numerical digits and other symbols. However, in order not to increase complexity of the taxonomy and relations, here we take a number as an "atomic" object, without decomposit it in digits (i.e. we do not include digits in the EMMO as alphabet for numbers).
    /// A number individual provides the link between the ontology and the actual data, through the data property hasNumericalValue.
    /// A numerical data value.
    /// <see href="https://w3id.org/emmo#EMMO_21f56795_ee72_4858_b571_11cfaa59c1a8"></see></summary>
    let EMMO_21f56795_ee72_4858_b571_11cfaa59c1a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_21f56795_ee72_4858_b571_11cfaa59c1a8" |> NamespacedName

    /// <summary>
    /// A relation between the whole and one of its tiles, where the tile is only spatially connected with the other tiles forming the tessellation.
    /// <see href="https://w3id.org/emmo#EMMO_b2282816_b7a3_44c6_b2cb_3feff1ceb7fe"></see></summary>
    let EMMO_b2282816_b7a3_44c6_b2cb_3feff1ceb7fe =
        Namespaced_IRI.parse _namespace_name "EMMO_b2282816_b7a3_44c6_b2cb_3feff1ceb7fe" |> NamespacedName

    /// <summary>
    /// for solutions, product for all substances B of concentration c_B of substance B in power of its stoichiometric number v_B: K_p = \sum_B{c_B^{v_B}}.
    /// The physical dimension can change based on the stoichiometric numbers of the substances involved.
    /// <see href="https://w3id.org/emmo#EMMO_066937f0_ea5c_4b06_8739_53f66d5ef89e"></see></summary>
    let EMMO_066937f0_ea5c_4b06_8739_53f66d5ef89e =
        Namespaced_IRI.parse _namespace_name "EMMO_066937f0_ea5c_4b06_8739_53f66d5ef89e" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-9.
    /// <see href="https://w3id.org/emmo#EMMO_a06e3d38_1aa8_4f45_89a8_722dbacfda24"></see></summary>
    let EMMO_a06e3d38_1aa8_4f45_89a8_722dbacfda24 =
        Namespaced_IRI.parse _namespace_name "EMMO_a06e3d38_1aa8_4f45_89a8_722dbacfda24" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "pico" (1e-12).
    /// <see href="https://w3id.org/emmo#EMMO_068c4e58_2470_4b1c_8454_010dd4906100"></see></summary>
    let EMMO_068c4e58_2470_4b1c_8454_010dd4906100 =
        Namespaced_IRI.parse _namespace_name "EMMO_068c4e58_2470_4b1c_8454_010dd4906100" |> NamespacedName

    /// <summary>
    /// Relates a SI prefixed unit to the multiplication factor corresponding to the prefix.
    /// <see href="https://w3id.org/emmo#EMMO_95908a5b_2e5e_4a52_9c5d_db25efe76e0f"></see></summary>
    let EMMO_95908a5b_2e5e_4a52_9c5d_db25efe76e0f =
        Namespaced_IRI.parse _namespace_name "EMMO_95908a5b_2e5e_4a52_9c5d_db25efe76e0f" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-12.
    /// <see href="https://w3id.org/emmo#EMMO_2b243e59_3a2a_412e_9a58_81d1e5c92fbe"></see></summary>
    let EMMO_2b243e59_3a2a_412e_9a58_81d1e5c92fbe =
        Namespaced_IRI.parse _namespace_name "EMMO_2b243e59_3a2a_412e_9a58_81d1e5c92fbe" |> NamespacedName

    /// <summary>
    /// Relates a prefixed unit to its metric prefix part.
    /// <see href="https://w3id.org/emmo#EMMO_4be0acad_af05_426f_aa6d_fe7531072564"></see></summary>
    let EMMO_4be0acad_af05_426f_aa6d_fe7531072564 =
        Namespaced_IRI.parse _namespace_name "EMMO_4be0acad_af05_426f_aa6d_fe7531072564" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_071b87fd_8ac8_4287_bfc6_9fcd8ce6674c"></see></summary>
    let EMMO_071b87fd_8ac8_4287_bfc6_9fcd8ce6674c =
        Namespaced_IRI.parse _namespace_name "EMMO_071b87fd_8ac8_4287_bfc6_9fcd8ce6674c" |> NamespacedName

    /// <summary>
    /// Atom subclass for gadolinium.
    /// <see href="https://w3id.org/emmo#EMMO_0724601e-642c-5770-bc86-7078e7441664"></see></summary>
    let ``EMMO_0724601e-642c-5770-bc86-7078e7441664`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0724601e-642c-5770-bc86-7078e7441664" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the gadolinium atom.
    /// <see href="https://w3id.org/emmo#EMMO_2563e18a-93d2-5d81-86d3-736295e9e519"></see></summary>
    let ``EMMO_2563e18a-93d2-5d81-86d3-736295e9e519`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2563e18a-93d2-5d81-86d3-736295e9e519" |> NamespacedName

    /// <summary>
    /// Vector quantity equal to the time derivative of the electric flux density.
    /// <see href="https://w3id.org/emmo#EMMO_072bc73e_9167_49f5_a62c_612a52c74f50"></see></summary>
    let EMMO_072bc73e_9167_49f5_a62c_612a52c74f50 =
        Namespaced_IRI.parse _namespace_name "EMMO_072bc73e_9167_49f5_a62c_612a52c74f50" |> NamespacedName

    /// <summary>
    /// Electric current divided by the cross-sectional area it is passing through.
    /// <see href="https://w3id.org/emmo#EMMO_7c8007b0_58a7_4486_bf1c_4772852caca0"></see></summary>
    let EMMO_7c8007b0_58a7_4486_bf1c_4772852caca0 =
        Namespaced_IRI.parse _namespace_name "EMMO_7c8007b0_58a7_4486_bf1c_4772852caca0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the lithium atom.
    /// <see href="https://w3id.org/emmo#EMMO_0755dd67-bdf1-5164-a706-55fcf9ced526"></see></summary>
    let ``EMMO_0755dd67-bdf1-5164-a706-55fcf9ced526`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0755dd67-bdf1-5164-a706-55fcf9ced526" |> NamespacedName

    /// <summary>
    /// Atom subclass for cadmium.
    /// <see href="https://w3id.org/emmo#EMMO_0761710a-3de3-5cff-a0cc-dfb8eba5a99d"></see></summary>
    let ``EMMO_0761710a-3de3-5cff-a0cc-dfb8eba5a99d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0761710a-3de3-5cff-a0cc-dfb8eba5a99d" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the cadmium atom.
    /// <see href="https://w3id.org/emmo#EMMO_b12e3fea-4467-5a08-9b14-67c51def1431"></see></summary>
    let ``EMMO_b12e3fea-4467-5a08-9b14-67c51def1431`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b12e3fea-4467-5a08-9b14-67c51def1431" |> NamespacedName

    /// <summary>
    /// Number of protons in an atomic nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_07de47e0_6bb6_45b9_b55a_4f238efbb105"></see></summary>
    let EMMO_07de47e0_6bb6_45b9_b55a_4f238efbb105 =
        Namespaced_IRI.parse _namespace_name "EMMO_07de47e0_6bb6_45b9_b55a_4f238efbb105" |> NamespacedName

    /// <summary>
    /// A data representing an arbritrary sized integer number.
    /// <see href="https://w3id.org/emmo#EMMO_f8bd64d5_5d3e_4ad4_a46e_c30714fecb7f"></see></summary>
    let EMMO_f8bd64d5_5d3e_4ad4_a46e_c30714fecb7f =
        Namespaced_IRI.parse _namespace_name "EMMO_f8bd64d5_5d3e_4ad4_a46e_c30714fecb7f" |> NamespacedName

    /// <summary>
    /// A pure number, typically the number of something.
    /// According to the SI brochure counting does not automatically qualify a quantity as an amount of substance.
    ///
    /// This quantity is used only to describe the outcome of a counting process, without regard of the type of entities.
    ///
    /// There are also some quantities that cannot be described in terms of the seven base quantities of the SI, but have the nature of a count. Examples are a number of molecules, a number of cellular or biomolecular entities (for example copies of a particular nucleic acid sequence), or degeneracy in quantum mechanics. Counting quantities are also quantities with the associated unit one.
    /// <see href="https://w3id.org/emmo#EMMO_ba882f34_0d71_4e4f_9d92_0c076c633a2c"></see></summary>
    let EMMO_ba882f34_0d71_4e4f_9d92_0c076c633a2c =
        Namespaced_IRI.parse _namespace_name "EMMO_ba882f34_0d71_4e4f_9d92_0c076c633a2c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticReluctance'.
    /// <see href="https://w3id.org/emmo#EMMO_07f571cd_252b_4421_8f98_94b6690d2ab9"></see></summary>
    let EMMO_07f571cd_252b_4421_8f98_94b6690d2ab9 =
        Namespaced_IRI.parse _namespace_name "EMMO_07f571cd_252b_4421_8f98_94b6690d2ab9" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the bohrium atom.
    /// <see href="https://w3id.org/emmo#EMMO_0805a892-352b-53e3-9577-60aa0835bc17"></see></summary>
    let ``EMMO_0805a892-352b-53e3-9577-60aa0835bc17`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0805a892-352b-53e3-9577-60aa0835bc17" |> NamespacedName

    /// <summary>
    /// Dimensionless parameter to quantify fluid resistance.
    /// <see href="https://w3id.org/emmo#EMMO_08415c4f_58bf_4696_8581_f5f90fec24b7"></see></summary>
    let EMMO_08415c4f_58bf_4696_8581_f5f90fec24b7 =
        Namespaced_IRI.parse _namespace_name "EMMO_08415c4f_58bf_4696_8581_f5f90fec24b7" |> NamespacedName

    /// <summary>
    /// A quantity to which no physical dimension is assigned and with a corresponding unit of measurement in the SI of the unit one.
    /// <see href="https://w3id.org/emmo#EMMO_a66427d1_9932_4363_9ec5_7d91f2bfda1e"></see></summary>
    let EMMO_a66427d1_9932_4363_9ec5_7d91f2bfda1e =
        Namespaced_IRI.parse _namespace_name "EMMO_a66427d1_9932_4363_9ec5_7d91f2bfda1e" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-4.
    /// <see href="https://w3id.org/emmo#EMMO_be76ad52_2e29_4202_be6f_0a15eb9c1817"></see></summary>
    let EMMO_be76ad52_2e29_4202_be6f_0a15eb9c1817 =
        Namespaced_IRI.parse _namespace_name "EMMO_be76ad52_2e29_4202_be6f_0a15eb9c1817" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_084b4f77_6df7_4c6a_b705_2528aba5cdda"></see>
    /// </summary>
    let EMMO_084b4f77_6df7_4c6a_b705_2528aba5cdda =
        Namespaced_IRI.parse _namespace_name "EMMO_084b4f77_6df7_4c6a_b705_2528aba5cdda" |> NamespacedName

    /// <summary>
    /// The equation that describes the velocity of a uniform accelerated body v = v0 + a*t is a functional icon. In general every analitical solution of a mathematical model can be considered an icon. A functional icon expresses its similarity with the object when is part of a process the makes it imitate the behavior of the object. In the case of v = v0 + a*t, plotting the velocity over time or listing their values at certain instants is when the icon expresses it functionality.
    /// A functional icon that imitates the behaviour of the object through mathematical evaluations of some mathematical construct.
    /// <see href="https://w3id.org/emmo#EMMO_5dd63d84_57f5_4b79_b760_fe940c06680d"></see></summary>
    let EMMO_5dd63d84_57f5_4b79_b760_fe940c06680d =
        Namespaced_IRI.parse _namespace_name "EMMO_5dd63d84_57f5_4b79_b760_fe940c06680d" |> NamespacedName

    /// <summary>
    /// Atom subclass for curium.
    /// <see href="https://w3id.org/emmo#EMMO_08522112-0872-599f-9d81-81889333254e"></see></summary>
    let ``EMMO_08522112-0872-599f-9d81-81889333254e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_08522112-0872-599f-9d81-81889333254e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the curium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c97277f7-f011-51bb-aeb8-5e8b1f3f711c"></see></summary>
    let ``EMMO_c97277f7-f011-51bb-aeb8-5e8b1f3f711c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c97277f7-f011-51bb-aeb8-5e8b1f3f711c" |> NamespacedName

    /// <summary>
    /// Expectation value of the energy imparted.
    /// <see href="https://w3id.org/emmo#EMMO_08865f1c_4d7e_4fa7_afba_05e5f7d06cb9"></see></summary>
    let EMMO_08865f1c_4d7e_4fa7_afba_05e5f7d06cb9 =
        Namespaced_IRI.parse _namespace_name "EMMO_08865f1c_4d7e_4fa7_afba_05e5f7d06cb9" |> NamespacedName

    /// <summary>
    /// The mass of one type of species divided by the total mass.
    /// <see href="https://w3id.org/emmo#EMMO_089f13b1_ceb3_4d2a_8795_b4a2d92916da"></see></summary>
    let EMMO_089f13b1_ceb3_4d2a_8795_b4a2d92916da =
        Namespaced_IRI.parse _namespace_name "EMMO_089f13b1_ceb3_4d2a_8795_b4a2d92916da" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two masses.
    /// <see href="https://w3id.org/emmo#EMMO_18448443_dcf1_49b8_a321_cf46e2c393e1"></see></summary>
    let EMMO_18448443_dcf1_49b8_a321_cf46e2c393e1 =
        Namespaced_IRI.parse _namespace_name "EMMO_18448443_dcf1_49b8_a321_cf46e2c393e1" |> NamespacedName

    /// <summary>
    /// A measurement unit for a derived quantity.
    /// -- VIM
    /// Derived units are defined as products of powers of the base units corresponding to the relations defining the derived quantities in terms of the base quantities.
    /// <see href="https://w3id.org/emmo#EMMO_08b308d4_31cd_4779_a784_aa92fc730f39"></see></summary>
    let EMMO_08b308d4_31cd_4779_a784_aa92fc730f39 =
        Namespaced_IRI.parse _namespace_name "EMMO_08b308d4_31cd_4779_a784_aa92fc730f39" |> NamespacedName

    /// <summary>
    /// Minimum length of a straight line segment between a point and a reference line or reference surface.
    /// <see href="https://w3id.org/emmo#EMMO_08bcf1d6_e719_46c8_bb21_24bc9bf34dba"></see></summary>
    let EMMO_08bcf1d6_e719_46c8_bb21_24bc9bf34dba =
        Namespaced_IRI.parse _namespace_name "EMMO_08bcf1d6_e719_46c8_bb21_24bc9bf34dba" |> NamespacedName

    /// <summary>
    /// Extend of a spatial dimension.
    /// Length is a non-negative additive quantity attributed to a one-dimensional object in space.
    /// <see href="https://w3id.org/emmo#EMMO_cd2cd0de_e0cc_4ef1_b27e_2e88db027bac"></see></summary>
    let EMMO_cd2cd0de_e0cc_4ef1_b27e_2e88db027bac =
        Namespaced_IRI.parse _namespace_name "EMMO_cd2cd0de_e0cc_4ef1_b27e_2e88db027bac" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_08d993e0_cc1c_45da_b0c5_3d658091ccfd"></see>
    /// </summary>
    let EMMO_08d993e0_cc1c_45da_b0c5_3d658091ccfd =
        Namespaced_IRI.parse _namespace_name "EMMO_08d993e0_cc1c_45da_b0c5_3d658091ccfd" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_09007bc0_b5f2_4fb9_af01_caf948cf2044"></see>
    /// </summary>
    let EMMO_09007bc0_b5f2_4fb9_af01_caf948cf2044 =
        Namespaced_IRI.parse _namespace_name "EMMO_09007bc0_b5f2_4fb9_af01_caf948cf2044" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1461e904_a2bf_4558_ad74_2706f5706b34"></see>
    /// </summary>
    let EMMO_1461e904_a2bf_4558_ad74_2706f5706b34 =
        Namespaced_IRI.parse _namespace_name "EMMO_1461e904_a2bf_4558_ad74_2706f5706b34" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_095b3c46_2b60_43cb_bade_9ee9ac969720"></see>
    /// </summary>
    let EMMO_095b3c46_2b60_43cb_bade_9ee9ac969720 =
        Namespaced_IRI.parse _namespace_name "EMMO_095b3c46_2b60_43cb_bade_9ee9ac969720" |> NamespacedName

    /// <summary>
    /// Measure for how the magnetization of material is affected by the application of an external magnetic field .
    /// <see href="https://w3id.org/emmo#EMMO_09663630_1b84_4202_91e6_e641104f579e"></see></summary>
    let EMMO_09663630_1b84_4202_91e6_e641104f579e =
        Namespaced_IRI.parse _namespace_name "EMMO_09663630_1b84_4202_91e6_e641104f579e" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Permeability'.
    /// <see href="https://w3id.org/emmo#EMMO_fa9c8c56_314f_4a5a_a71d_bae66446b185"></see></summary>
    let EMMO_fa9c8c56_314f_4a5a_a71d_bae66446b185 =
        Namespaced_IRI.parse _namespace_name "EMMO_fa9c8c56_314f_4a5a_a71d_bae66446b185" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_0972cb08_48bd_4524_ac03_8a2e7f30f02f"></see></summary>
    let EMMO_0972cb08_48bd_4524_ac03_8a2e7f30f02f =
        Namespaced_IRI.parse _namespace_name "EMMO_0972cb08_48bd_4524_ac03_8a2e7f30f02f" |> NamespacedName

    /// <summary>
    /// Atom subclass for lutetium.
    /// <see href="https://w3id.org/emmo#EMMO_098f6f77-746a-5fcc-a6d1-4988929bf404"></see></summary>
    let ``EMMO_098f6f77-746a-5fcc-a6d1-4988929bf404`` =
        Namespaced_IRI.parse _namespace_name "EMMO_098f6f77-746a-5fcc-a6d1-4988929bf404" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the lutetium atom.
    /// <see href="https://w3id.org/emmo#EMMO_66c364c4-16b7-5d5f-abd5-b6977c46f525"></see></summary>
    let ``EMMO_66c364c4-16b7-5d5f-abd5-b6977c46f525`` =
        Namespaced_IRI.parse _namespace_name "EMMO_66c364c4-16b7-5d5f-abd5-b6977c46f525" |> NamespacedName

    /// <summary>
    /// Rate of transfer of energy per unit time.
    /// <see href="https://w3id.org/emmo#EMMO_09b9021b_f97b_43eb_b83d_0a764b472bc2"></see></summary>
    let EMMO_09b9021b_f97b_43eb_b83d_0a764b472bc2 =
        Namespaced_IRI.parse _namespace_name "EMMO_09b9021b_f97b_43eb_b83d_0a764b472bc2" |> NamespacedName

    /// <summary>
    /// A quantity whose magnitude is additive for subsystems.
    /// Note that not all physical quantities can be categorised as being either intensive or extensive. For example the square root of the mass.
    /// <see href="https://w3id.org/emmo#EMMO_194100e1_e11a_4b7c_bb5a_171655679fc8"></see></summary>
    let EMMO_194100e1_e11a_4b7c_bb5a_171655679fc8 =
        Namespaced_IRI.parse _namespace_name "EMMO_194100e1_e11a_4b7c_bb5a_171655679fc8" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Power'.
    /// <see href="https://w3id.org/emmo#EMMO_c8d084ad_f88e_4596_8e4d_982c6655ce6f"></see></summary>
    let EMMO_c8d084ad_f88e_4596_8e4d_982c6655ce6f =
        Namespaced_IRI.parse _namespace_name "EMMO_c8d084ad_f88e_4596_8e4d_982c6655ce6f" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_09cee580_aed5_4541_ab94_ec5bb1c64a7c"></see></summary>
    let EMMO_09cee580_aed5_4541_ab94_ec5bb1c64a7c =
        Namespaced_IRI.parse _namespace_name "EMMO_09cee580_aed5_4541_ab94_ec5bb1c64a7c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the tin atom.
    /// <see href="https://w3id.org/emmo#EMMO_09e84f72-511a-5d22-adf1-accacaf7146a"></see></summary>
    let ``EMMO_09e84f72-511a-5d22-adf1-accacaf7146a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_09e84f72-511a-5d22-adf1-accacaf7146a" |> NamespacedName

    /// <summary>
    /// A causally bonded system is a system in which there are at least thwo causal paths that are interacting.
    /// <see href="https://w3id.org/emmo#EMMO_09f0ac34_c349_46b5_acf0_0edeae52cca1"></see></summary>
    let EMMO_09f0ac34_c349_46b5_acf0_0edeae52cca1 =
        Namespaced_IRI.parse _namespace_name "EMMO_09f0ac34_c349_46b5_acf0_0edeae52cca1" |> NamespacedName

    /// <summary>
    /// The class of individuals standing for causally non-convex interacting systems.
    /// <see href="https://w3id.org/emmo#EMMO_5cc4e111_3eb1_44a3_9369_5af3846cf605"></see></summary>
    let EMMO_5cc4e111_3eb1_44a3_9369_5af3846cf605 =
        Namespaced_IRI.parse _namespace_name "EMMO_5cc4e111_3eb1_44a3_9369_5af3846cf605" |> NamespacedName

    /// <summary>
    /// Probability is a dimensionless quantity that can attain values between 0 and 1; zero denotes the impossible event and 1 denotes a certain event.
    /// The propability for a certain outcome, is the ratio between the number of events leading to the given outcome and the total number of events.
    /// <see href="https://w3id.org/emmo#EMMO_0a88be81_343d_4388_92c1_09228ff95ada"></see></summary>
    let EMMO_0a88be81_343d_4388_92c1_09228ff95ada =
        Namespaced_IRI.parse _namespace_name "EMMO_0a88be81_343d_4388_92c1_09228ff95ada" |> NamespacedName

    /// <summary>
    /// Quotient of radiation amplitude scattered by the atom and radiation amplitude scattered by a single electron.
    /// <see href="https://w3id.org/emmo#EMMO_0a982eeb_e5ef_4828_93bc_53ece1b3f171"></see></summary>
    let EMMO_0a982eeb_e5ef_4828_93bc_53ece1b3f171 =
        Namespaced_IRI.parse _namespace_name "EMMO_0a982eeb_e5ef_4828_93bc_53ece1b3f171" |> NamespacedName

    /// <summary>
    /// Relates an object to a quantity describing a quantifiable property of the object obtained via a well-defined procedure.
    /// <see href="https://w3id.org/emmo#EMMO_0aa934ee_1ad4_4345_8a7f_bc73ec67c7e5"></see></summary>
    let EMMO_0aa934ee_1ad4_4345_8a7f_bc73ec67c7e5 =
        Namespaced_IRI.parse _namespace_name "EMMO_0aa934ee_1ad4_4345_8a7f_bc73ec67c7e5" |> NamespacedName

    /// <summary>
    /// A topological space with the property that each point has a neighborhood that is homeomorphic to an open subset of 0-dimensional Euclidean space.
    /// <see href="https://w3id.org/emmo#EMMO_0ab0485c_9e5b_4257_a679_90a2dfba5c7c"></see></summary>
    let EMMO_0ab0485c_9e5b_4257_a679_90a2dfba5c7c =
        Namespaced_IRI.parse _namespace_name "EMMO_0ab0485c_9e5b_4257_a679_90a2dfba5c7c" |> NamespacedName

    /// <summary>
    /// A 'graphical' aimed to represent a geometrical concept.
    /// <see href="https://w3id.org/emmo#EMMO_b5957cef_a287_442d_a3ce_fd39f20ba1cd"></see></summary>
    let EMMO_b5957cef_a287_442d_a3ce_fd39f20ba1cd =
        Namespaced_IRI.parse _namespace_name "EMMO_b5957cef_a287_442d_a3ce_fd39f20ba1cd" |> NamespacedName

    /// <summary>
    /// Force resisting the motion when a body (such as a ball, tire, or wheel) rolls on a surface.
    /// <see href="https://w3id.org/emmo#EMMO_0ab4306c_ba36_4a6e_941e_474ed04e8ccf"></see></summary>
    let EMMO_0ab4306c_ba36_4a6e_941e_474ed04e8ccf =
        Namespaced_IRI.parse _namespace_name "EMMO_0ab4306c_ba36_4a6e_941e_474ed04e8ccf" |> NamespacedName

    /// <summary>
    /// Quotient of tangential and normal component of the force applied to a body which is rolling at constant speed over a surface.
    /// <see href="https://w3id.org/emmo#EMMO_ea47add2_8e93_4659_a5f0_e6879032dee0"></see></summary>
    let EMMO_ea47add2_8e93_4659_a5f0_e6879032dee0 =
        Namespaced_IRI.parse _namespace_name "EMMO_ea47add2_8e93_4659_a5f0_e6879032dee0" |> NamespacedName

    /// <summary>
    /// Physical quantity for describing the temporal distance between events.
    /// <see href="https://w3id.org/emmo#EMMO_0adabf6f_7404_44cb_9f65_32d83d8101a3"></see></summary>
    let EMMO_0adabf6f_7404_44cb_9f65_32d83d8101a3 =
        Namespaced_IRI.parse _namespace_name "EMMO_0adabf6f_7404_44cb_9f65_32d83d8101a3" |> NamespacedName

    /// <summary>
    /// The indefinite continued progress of existence and events that occur in apparently irreversible succession from the past through the present to the future.
    /// Time can be seen as the duration of an event or, more operationally, as "what clocks read".
    /// One-dimensional subspace of space-time, which is locally orthogonal to space.
    /// <see href="https://w3id.org/emmo#EMMO_d4f7d378_5e3b_468a_baa1_a7e98358cda7"></see></summary>
    let EMMO_d4f7d378_5e3b_468a_baa1_a7e98358cda7 =
        Namespaced_IRI.parse _namespace_name "EMMO_d4f7d378_5e3b_468a_baa1_a7e98358cda7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0afc19b0_2d43_4b3d_8da0_9ffb63bc1492"></see>
    /// </summary>
    let EMMO_0afc19b0_2d43_4b3d_8da0_9ffb63bc1492 =
        Namespaced_IRI.parse _namespace_name "EMMO_0afc19b0_2d43_4b3d_8da0_9ffb63bc1492" |> NamespacedName

    /// <summary>
    /// In an infinite medium, the probability that a neutron slowing down will traverse all or some specified portion of the range of resonance energies without being absorbed.
    /// <see href="https://w3id.org/emmo#EMMO_0b0dc439_fe4b_4e59_a5f6_655b0bf48559"></see></summary>
    let EMMO_0b0dc439_fe4b_4e59_a5f6_655b0bf48559 =
        Namespaced_IRI.parse _namespace_name "EMMO_0b0dc439_fe4b_4e59_a5f6_655b0bf48559" |> NamespacedName

    /// <summary>
    /// The relation between a process and the entity that represents how things have turned out.
    /// <see href="https://w3id.org/emmo#EMMO_0b1502e2_d12f_4ff3_83b1_eeedf9382954"></see></summary>
    let EMMO_0b1502e2_d12f_4ff3_83b1_eeedf9382954 =
        Namespaced_IRI.parse _namespace_name "EMMO_0b1502e2_d12f_4ff3_83b1_eeedf9382954" |> NamespacedName

    /// <summary>
    /// The superclass for causal structure classes whose individuals have some temporal item parts that are not of the same type of the whole.
    /// A process can be defined only according to an entity type. The minimum process is an entity made of two entities of different types that are temporally related.
    /// <see href="https://w3id.org/emmo#EMMO_43e9a05d_98af_41b4_92f6_00f79a09bfce"></see></summary>
    let EMMO_43e9a05d_98af_41b4_92f6_00f79a09bfce =
        Namespaced_IRI.parse _namespace_name "EMMO_43e9a05d_98af_41b4_92f6_00f79a09bfce" |> NamespacedName

    /// <summary>
    /// The relation between the whole and a proper part of the whole that scale down to the point which it lose the characteristics of the whole and become something else.
    /// <see href="https://w3id.org/emmo#EMMO_8e52c42b_e879_4473_9fa1_4b23428b392b"></see></summary>
    let EMMO_8e52c42b_e879_4473_9fa1_4b23428b392b =
        Namespaced_IRI.parse _namespace_name "EMMO_8e52c42b_e879_4473_9fa1_4b23428b392b" |> NamespacedName

    /// <summary>
    /// A material in which distributed particles of one phase are dispersed in a different continuous phase.
    /// <see href="https://w3id.org/emmo#EMMO_0b15f4ae_092e_4487_9100_3c44176c545c"></see></summary>
    let EMMO_0b15f4ae_092e_4487_9100_3c44176c545c =
        Namespaced_IRI.parse _namespace_name "EMMO_0b15f4ae_092e_4487_9100_3c44176c545c" |> NamespacedName

    /// <summary>
    /// A solution is a homogeneous mixture composed of two or more substances.
    /// Solutions are characterized by the occurrence of Rayleigh scattering on light,
    /// <see href="https://w3id.org/emmo#EMMO_2031516a_2be7_48e8_9af7_7e1270e308fe"></see></summary>
    let EMMO_2031516a_2be7_48e8_9af7_7e1270e308fe =
        Namespaced_IRI.parse _namespace_name "EMMO_2031516a_2be7_48e8_9af7_7e1270e308fe" |> NamespacedName

    /// <summary>
    /// An heterogeneous mixture that contains coarsly dispersed particles (no Tyndall effect), that generally tend to separate in time to the dispersion medium phase.
    /// Suspensions show no significant effect on light.
    /// <see href="https://w3id.org/emmo#EMMO_4a464c8d_8895_44a8_a628_aed13509f1bd"></see></summary>
    let EMMO_4a464c8d_8895_44a8_a628_aed13509f1bd =
        Namespaced_IRI.parse _namespace_name "EMMO_4a464c8d_8895_44a8_a628_aed13509f1bd" |> NamespacedName

    /// <summary>
    /// A mixture in which one substance of microscopically dispersed insoluble or soluble particles (from 1 nm to 1 μm) is suspended throughout another substance and that does not settle, or would take a very long time to settle appreciably.
    /// Colloids are characterized by the occurring of the Tyndall effect on light.
    /// <see href="https://w3id.org/emmo#EMMO_6c487fb3_03d1_4e56_91ed_c2e16dcbef60"></see></summary>
    let EMMO_6c487fb3_03d1_4e56_91ed_c2e16dcbef60 =
        Namespaced_IRI.parse _namespace_name "EMMO_6c487fb3_03d1_4e56_91ed_c2e16dcbef60" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_58e7c821_4af0_4394_89f7_a9649735f4d2"></see>
    /// </summary>
    let EMMO_58e7c821_4af0_4394_89f7_a9649735f4d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_58e7c821_4af0_4394_89f7_a9649735f4d2" |> NamespacedName

    /// <summary>
    /// Coefficient of heat transfer when heat exchange takes place between a body at thermodynamic temperature Ts and its surroundings that are at a reference temperature Tr.
    /// <see href="https://w3id.org/emmo#EMMO_0b3295fa_f4bf_4f83_a603_9d98c03da5bb"></see></summary>
    let EMMO_0b3295fa_f4bf_4f83_a603_9d98c03da5bb =
        Namespaced_IRI.parse _namespace_name "EMMO_0b3295fa_f4bf_4f83_a603_9d98c03da5bb" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-5.
    /// <see href="https://w3id.org/emmo#EMMO_dae32a4a_d8da_4047_81b0_36a9713fdce1"></see></summary>
    let EMMO_dae32a4a_d8da_4047_81b0_36a9713fdce1 =
        Namespaced_IRI.parse _namespace_name "EMMO_dae32a4a_d8da_4047_81b0_36a9713fdce1" |> NamespacedName

    /// <summary>
    /// At a point on the surface separating two media with different thermodynamic temperatures, magnitude of the density of heat flow rate φ divided by the absolute value of temperature difference ΔT.
    /// <see href="https://w3id.org/emmo#EMMO_43b349fc_c7ed_480d_b0ca_9db84b700813"></see></summary>
    let EMMO_43b349fc_c7ed_480d_b0ca_9db84b700813 =
        Namespaced_IRI.parse _namespace_name "EMMO_43b349fc_c7ed_480d_b0ca_9db84b700813" |> NamespacedName

    /// <summary>
    /// A relation which makes a non-equal comparison between two numbers or other mathematical expressions.
    /// <see href="https://w3id.org/emmo#EMMO_0b6ebe5a_0026_4bef_a1c1_5be00df9f98e"></see></summary>
    let EMMO_0b6ebe5a_0026_4bef_a1c1_5be00df9f98e =
        Namespaced_IRI.parse _namespace_name "EMMO_0b6ebe5a_0026_4bef_a1c1_5be00df9f98e" |> NamespacedName

    /// <summary>
    /// A mathematical string that express a relation between the elements in one set X to elements in another set Y.
    /// The set X is called domain and the set Y range or codomain.
    /// <see href="https://w3id.org/emmo#EMMO_88470739_03d3_4c47_a03e_b30a1288d50c"></see></summary>
    let EMMO_88470739_03d3_4c47_a03e_b30a1288d50c =
        Namespaced_IRI.parse _namespace_name "EMMO_88470739_03d3_4c47_a03e_b30a1288d50c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the arsenic atom.
    /// <see href="https://w3id.org/emmo#EMMO_0ba17fb4-6149-5332-b65f-0639ace42edf"></see></summary>
    let ``EMMO_0ba17fb4-6149-5332-b65f-0639ace42edf`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0ba17fb4-6149-5332-b65f-0639ace42edf" |> NamespacedName

    /// <summary>
    /// Suggestion of Rickard Armiento
    /// <see href="https://w3id.org/emmo#EMMO_f1025834_0cd2_42a1_bfeb_13bec41c8655"></see></summary>
    let EMMO_f1025834_0cd2_42a1_bfeb_13bec41c8655 =
        Namespaced_IRI.parse _namespace_name "EMMO_f1025834_0cd2_42a1_bfeb_13bec41c8655" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the zinc atom.
    /// <see href="https://w3id.org/emmo#EMMO_0bd0c81a-2972-5b2d-8ff5-bb72a82b9c0d"></see></summary>
    let ``EMMO_0bd0c81a-2972-5b2d-8ff5-bb72a82b9c0d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0bd0c81a-2972-5b2d-8ff5-bb72a82b9c0d" |> NamespacedName

    /// <summary>
    /// A system whose is mainly characterised by the way in which elements are interconnected.
    /// <see href="https://w3id.org/emmo#EMMO_f93fe78b_9646_4a15_b88b_1c93686a764d"></see></summary>
    let EMMO_f93fe78b_9646_4a15_b88b_1c93686a764d =
        Namespaced_IRI.parse _namespace_name "EMMO_f93fe78b_9646_4a15_b88b_1c93686a764d" |> NamespacedName

    /// <summary>
    /// Quotient of linear attenuation coefficient µ and the amount c of the medium.
    /// <see href="https://w3id.org/emmo#EMMO_0ca67b4c_bdd3_40a6_b8c6_ba77e39c13a3"></see></summary>
    let EMMO_0ca67b4c_bdd3_40a6_b8c6_ba77e39c13a3 =
        Namespaced_IRI.parse _namespace_name "EMMO_0ca67b4c_bdd3_40a6_b8c6_ba77e39c13a3" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_973656ed_870e_40ba_8bc0_c879687a335a"></see></summary>
    let EMMO_973656ed_870e_40ba_8bc0_c879687a335a =
        Namespaced_IRI.parse _namespace_name "EMMO_973656ed_870e_40ba_8bc0_c879687a335a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePressurePerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_0cd4c619_b123_4ae4_b778_3c9adaad65e7"></see></summary>
    let EMMO_0cd4c619_b123_4ae4_b778_3c9adaad65e7 =
        Namespaced_IRI.parse _namespace_name "EMMO_0cd4c619_b123_4ae4_b778_3c9adaad65e7" |> NamespacedName

    /// <summary>
    /// Data that are decoded retaining its continuous variations characteristic.
    /// The fact that there may be a finite granularity in the variations of the material basis (e.g. the smallest peak in a vynil that can be recognized by the piezo-electric transducer) does not prevent a data to be analog. It means only that the focus on such data encoding is on a scale that makes such variations negligible, making them practically a continuum.
    /// <see href="https://w3id.org/emmo#EMMO_0d1c0018_42e2_4506_bc3d_f53c117c1ad3"></see></summary>
    let EMMO_0d1c0018_42e2_4506_bc3d_f53c117c1ad3 =
        Namespaced_IRI.parse _namespace_name "EMMO_0d1c0018_42e2_4506_bc3d_f53c117c1ad3" |> NamespacedName

    /// <summary>
    /// For a closed path, scalar quantity equal to the electric current through any surface bounded by the path.
    /// <see href="https://w3id.org/emmo#EMMO_0d2c0390_51fb_42aa_93b1_af903b3ad510"></see></summary>
    let EMMO_0d2c0390_51fb_42aa_93b1_af903b3ad510 =
        Namespaced_IRI.parse _namespace_name "EMMO_0d2c0390_51fb_42aa_93b1_af903b3ad510" |> NamespacedName

    /// <summary>
    /// A flow of electric charge.
    /// <see href="https://w3id.org/emmo#EMMO_c995ae70_3b84_4ebb_bcfc_69e6a281bb88"></see></summary>
    let EMMO_c995ae70_3b84_4ebb_bcfc_69e6a281bb88 =
        Namespaced_IRI.parse _namespace_name "EMMO_c995ae70_3b84_4ebb_bcfc_69e6a281bb88" |> NamespacedName

    /// <summary>
    /// Atom subclass for gold.
    /// <see href="https://w3id.org/emmo#EMMO_0d37beeb-9dea-558e-82c5-4df3fb6d08d0"></see></summary>
    let ``EMMO_0d37beeb-9dea-558e-82c5-4df3fb6d08d0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0d37beeb-9dea-558e-82c5-4df3fb6d08d0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the gold atom.
    /// <see href="https://w3id.org/emmo#EMMO_811c67a9-bcdf-5a9e-bbce-28ae2af12915"></see></summary>
    let ``EMMO_811c67a9-bcdf-5a9e-bbce-28ae2af12915`` =
        Namespaced_IRI.parse _namespace_name "EMMO_811c67a9-bcdf-5a9e-bbce-28ae2af12915" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperatureLengthPerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_0d4bdfcd_f4f0_4b8f_b470_e3f654e37d33"></see></summary>
    let EMMO_0d4bdfcd_f4f0_4b8f_b470_e3f654e37d33 =
        Namespaced_IRI.parse _namespace_name "EMMO_0d4bdfcd_f4f0_4b8f_b470_e3f654e37d33" |> NamespacedName

    /// <summary>
    /// Atom subclass for molybdenum.
    /// <see href="https://w3id.org/emmo#EMMO_0d8247fb-82b0-5ad6-996b-19469e1d7960"></see></summary>
    let ``EMMO_0d8247fb-82b0-5ad6-996b-19469e1d7960`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0d8247fb-82b0-5ad6-996b-19469e1d7960" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the molybdenum atom.
    /// <see href="https://w3id.org/emmo#EMMO_e4c89307-e63b-57c8-8892-60924c65aa3b"></see></summary>
    let ``EMMO_e4c89307-e63b-57c8-8892-60924c65aa3b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e4c89307-e63b-57c8-8892-60924c65aa3b" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting a declaring interpreter to the "declared" semiotic object in a declaration process.
    /// <see href="https://w3id.org/emmo#EMMO_0d829933_29e3_4e61_b3d3_88e6b9d0d0ce"></see></summary>
    let EMMO_0d829933_29e3_4e61_b3d3_88e6b9d0d0ce =
        Namespaced_IRI.parse _namespace_name "EMMO_0d829933_29e3_4e61_b3d3_88e6b9d0d0ce" |> NamespacedName

    /// <summary>
    /// Retarding force on a body moving in a fluid.
    /// <see href="https://w3id.org/emmo#EMMO_0dbdd7c5_86a5_4867_a396_2277e20fc4bc"></see></summary>
    let EMMO_0dbdd7c5_86a5_4867_a396_2277e20fc4bc =
        Namespaced_IRI.parse _namespace_name "EMMO_0dbdd7c5_86a5_4867_a396_2277e20fc4bc" |> NamespacedName

    /// <summary>
    /// Measure of the relative volume change of a fluid or solid as a response to a pressure change.
    /// <see href="https://w3id.org/emmo#EMMO_0de3878e_7928_4ab6_bc6d_cf590b2d0e5b"></see></summary>
    let EMMO_0de3878e_7928_4ab6_bc6d_cf590b2d0e5b =
        Namespaced_IRI.parse _namespace_name "EMMO_0de3878e_7928_4ab6_bc6d_cf590b2d0e5b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerPressure'.
    /// <see href="https://w3id.org/emmo#EMMO_2a068ad0_582c_4f50_90d2_89d9e28977c1"></see></summary>
    let EMMO_2a068ad0_582c_4f50_90d2_89d9e28977c1 =
        Namespaced_IRI.parse _namespace_name "EMMO_2a068ad0_582c_4f50_90d2_89d9e28977c1" |> NamespacedName

    /// <summary>
    /// Phase heterogenous mixture may share the same state of matter.
    ///
    /// For example, immiscibile liquid phases (e.g. oil and water) constitute a mixture whose phases are clearly separated but share the same state of matter.
    /// A mixture in which more than one phases of matter cohexists.
    /// <see href="https://w3id.org/emmo#EMMO_0e030040_98a7_49b2_a871_dced1f3a6131"></see></summary>
    let EMMO_0e030040_98a7_49b2_a871_dced1f3a6131 =
        Namespaced_IRI.parse _namespace_name "EMMO_0e030040_98a7_49b2_a871_dced1f3a6131" |> NamespacedName

    /// <summary>
    /// A Miixture is a material made up of two or more different substances which are physically (not chemically) combined.
    /// <see href="https://w3id.org/emmo#EMMO_ec2c8ac8_98c5_4c74_b85b_ff8e8ca6655c"></see></summary>
    let EMMO_ec2c8ac8_98c5_4c74_b85b_ff8e8ca6655c =
        Namespaced_IRI.parse _namespace_name "EMMO_ec2c8ac8_98c5_4c74_b85b_ff8e8ca6655c" |> NamespacedName

    /// <summary>
    /// A data that represents instants of time, optionally marked with a particular time zone offset.
    /// <see href="https://w3id.org/emmo#EMMO_0e03a375_8af8_46db_88ae_a45fe2d2940f"></see></summary>
    let EMMO_0e03a375_8af8_46db_88ae_a45fe2d2940f =
        Namespaced_IRI.parse _namespace_name "EMMO_0e03a375_8af8_46db_88ae_a45fe2d2940f" |> NamespacedName

    /// <summary>
    /// Atom subclass for bismuth.
    /// <see href="https://w3id.org/emmo#EMMO_0e08326e-376b-5d54-ad2c-2a7cf274af61"></see></summary>
    let ``EMMO_0e08326e-376b-5d54-ad2c-2a7cf274af61`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0e08326e-376b-5d54-ad2c-2a7cf274af61" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the bismuth atom.
    /// <see href="https://w3id.org/emmo#EMMO_ed5acb06-0af0-5a3a-9b31-a1b32267f753"></see></summary>
    let ``EMMO_ed5acb06-0af0-5a3a-9b31-a1b32267f753`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ed5acb06-0af0-5a3a-9b31-a1b32267f753" |> NamespacedName

    /// <summary>
    /// Partial differential quotient of the cross section of a process with respect to the solid angle around a given direction and the energy of a particle scattered in that direction.
    /// <see href="https://w3id.org/emmo#EMMO_0e0ee94d_70be_4b7e_afcc_320e62a94974"></see></summary>
    let EMMO_0e0ee94d_70be_4b7e_afcc_320e62a94974 =
        Namespaced_IRI.parse _namespace_name "EMMO_0e0ee94d_70be_4b7e_afcc_320e62a94974" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareTimePerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_f508dec1_e2d8_43d5_ae65_c386c7b330f9"></see></summary>
    let EMMO_f508dec1_e2d8_43d5_ae65_c386c7b330f9 =
        Namespaced_IRI.parse _namespace_name "EMMO_f508dec1_e2d8_43d5_ae65_c386c7b330f9" |> NamespacedName

    /// <summary>
    /// An holistic temporal part of a whole.
    /// <see href="https://w3id.org/emmo#EMMO_0e1f2009_bf12_49d1_99f3_1422e5287d82"></see></summary>
    let EMMO_0e1f2009_bf12_49d1_99f3_1422e5287d82 =
        Namespaced_IRI.parse _namespace_name "EMMO_0e1f2009_bf12_49d1_99f3_1422e5287d82" |> NamespacedName

    /// <summary>
    /// A single phase mixture.
    /// <see href="https://w3id.org/emmo#EMMO_0e6378df_1ce8_4321_b00c_ee9beea60a67"></see></summary>
    let EMMO_0e6378df_1ce8_4321_b00c_ee9beea60a67 =
        Namespaced_IRI.parse _namespace_name "EMMO_0e6378df_1ce8_4321_b00c_ee9beea60a67" |> NamespacedName

    /// <summary>
    /// Coercive field strength in a substance when either the magnetic flux density or the magnetic polarization and magnetization is brought from its value at magnetic saturation to zero by monotonic reduction of the applied magnetic field strength.
    /// <see href="https://w3id.org/emmo#EMMO_0e78a4d4_b4e0_48e7_97d8_e7d41a85a54d"></see></summary>
    let EMMO_0e78a4d4_b4e0_48e7_97d8_e7d41a85a54d =
        Namespaced_IRI.parse _namespace_name "EMMO_0e78a4d4_b4e0_48e7_97d8_e7d41a85a54d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0e86a108_9d4d_4582_8126_f0c527d81901"></see>
    /// </summary>
    let EMMO_0e86a108_9d4d_4582_8126_f0c527d81901 =
        Namespaced_IRI.parse _namespace_name "EMMO_0e86a108_9d4d_4582_8126_f0c527d81901" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0ee9e6a2_9240_4b1d_ac9a_f72416c7dc70"></see>
    /// </summary>
    let EMMO_0ee9e6a2_9240_4b1d_ac9a_f72416c7dc70 =
        Namespaced_IRI.parse _namespace_name "EMMO_0ee9e6a2_9240_4b1d_ac9a_f72416c7dc70" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_0eabfde6_c6c5_4b1f_bf10_e4e0e06e9b2e"></see>
    /// </summary>
    let EMMO_0eabfde6_c6c5_4b1f_bf10_e4e0e06e9b2e =
        Namespaced_IRI.parse _namespace_name "EMMO_0eabfde6_c6c5_4b1f_bf10_e4e0e06e9b2e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_172e2c96_180b_40f8_a3e7_b624471f40c2"></see>
    /// </summary>
    let EMMO_172e2c96_180b_40f8_a3e7_b624471f40c2 =
        Namespaced_IRI.parse _namespace_name "EMMO_172e2c96_180b_40f8_a3e7_b624471f40c2" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the ruthenium atom.
    /// <see href="https://w3id.org/emmo#EMMO_0edbde89-9714-53c7-b2a9-0ef6c0f73091"></see></summary>
    let ``EMMO_0edbde89-9714-53c7-b2a9-0ef6c0f73091`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0edbde89-9714-53c7-b2a9-0ef6c0f73091" |> NamespacedName

    /// <summary>
    /// Measure for how the polarization of a material is affected by the application of an external electric field.
    /// <see href="https://w3id.org/emmo#EMMO_0ee5779e_d798_4ee5_9bfe_c392d5bea112"></see></summary>
    let EMMO_0ee5779e_d798_4ee5_9bfe_c392d5bea112 =
        Namespaced_IRI.parse _namespace_name "EMMO_0ee5779e_d798_4ee5_9bfe_c392d5bea112" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Permittivity'.
    /// <see href="https://w3id.org/emmo#EMMO_5f89cb0c_3171_47ee_b2ab_027a07c34c4b"></see></summary>
    let EMMO_5f89cb0c_3171_47ee_b2ab_027a07c34c4b =
        Namespaced_IRI.parse _namespace_name "EMMO_5f89cb0c_3171_47ee_b2ab_027a07c34c4b" |> NamespacedName

    /// <summary>
    /// The partial overlapping is required since the creating process is distinct with the process in which the output is used or consumed.
    /// The outcome of a process.
    /// <see href="https://w3id.org/emmo#EMMO_c4bace1d_4db0_4cd3_87e9_18122bae2840"></see></summary>
    let EMMO_c4bace1d_4db0_4cd3_87e9_18122bae2840 =
        Namespaced_IRI.parse _namespace_name "EMMO_c4bace1d_4db0_4cd3_87e9_18122bae2840" |> NamespacedName

    /// <summary>
    /// Atom subclass for titanium.
    /// <see href="https://w3id.org/emmo#EMMO_0eee5986-12a1-5f73-b5e0-6eb2b640c924"></see></summary>
    let ``EMMO_0eee5986-12a1-5f73-b5e0-6eb2b640c924`` =
        Namespaced_IRI.parse _namespace_name "EMMO_0eee5986-12a1-5f73-b5e0-6eb2b640c924" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the titanium atom.
    /// <see href="https://w3id.org/emmo#EMMO_1cba8181-2ea5-5772-8bd7-e668ffcde394"></see></summary>
    let ``EMMO_1cba8181-2ea5-5772-8bd7-e668ffcde394`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1cba8181-2ea5-5772-8bd7-e668ffcde394" |> NamespacedName

    /// <summary>
    /// A one-manyfold with two unconnected end points.
    /// <see href="https://w3id.org/emmo#EMMO_0ef4ff4a_5458_4f2a_b51f_4689d472a3f2"></see></summary>
    let EMMO_0ef4ff4a_5458_4f2a_b51f_4689d472a3f2 =
        Namespaced_IRI.parse _namespace_name "EMMO_0ef4ff4a_5458_4f2a_b51f_4689d472a3f2" |> NamespacedName

    /// <summary>
    /// A causal multipath system is a system made of causal paths that are not interacting between each others, or possibly merge and fork.
    /// A physically unbounded system is a combination of elementary particles chains tha may include also decays and/or annihilations, without any space-like interaction between elementary particles.
    /// <see href="https://w3id.org/emmo#EMMO_0f19d84e_05b4_47c9_a5de_bb2a913d211b"></see></summary>
    let EMMO_0f19d84e_05b4_47c9_a5de_bb2a913d211b =
        Namespaced_IRI.parse _namespace_name "EMMO_0f19d84e_05b4_47c9_a5de_bb2a913d211b" |> NamespacedName

    /// <summary>
    /// Quotient of the total linear stopping power S and the mass density ρ of the material.
    /// <see href="https://w3id.org/emmo#EMMO_0f1b1f8b_0323_4840_899c_fd6860763155"></see></summary>
    let EMMO_0f1b1f8b_0323_4840_899c_fd6860763155 =
        Namespaced_IRI.parse _namespace_name "EMMO_0f1b1f8b_0323_4840_899c_fd6860763155" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassStoppingPower'.
    /// <see href="https://w3id.org/emmo#EMMO_c0f32e02_44d7_4c99_986e_c368d7219e4c"></see></summary>
    let EMMO_c0f32e02_44d7_4c99_986e_c368d7219e4c =
        Namespaced_IRI.parse _namespace_name "EMMO_c0f32e02_44d7_4c99_986e_c368d7219e4c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ThermalConductivity'.
    /// <see href="https://w3id.org/emmo#EMMO_0f3ec0ad_3fcf_42b2_8f34_6dca89e35a4f"></see></summary>
    let EMMO_0f3ec0ad_3fcf_42b2_8f34_6dca89e35a4f =
        Namespaced_IRI.parse _namespace_name "EMMO_0f3ec0ad_3fcf_42b2_8f34_6dca89e35a4f" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassAmountOfSubstance'.
    /// <see href="https://w3id.org/emmo#EMMO_0f43918c_3578_4196_a5fa_d3fa6c0d5869"></see></summary>
    let EMMO_0f43918c_3578_4196_a5fa_d3fa6c0d5869 =
        Namespaced_IRI.parse _namespace_name "EMMO_0f43918c_3578_4196_a5fa_d3fa6c0d5869" |> NamespacedName

    /// <summary>
    /// A measurement result generally contains “relevant information” about the set of measured quantity properties, such that some may be more representative of the measured quantity than others. This may be expressed in the form of a probability density function (pdf).
    /// Result of a measurement.
    ///
    /// A set of quantites being attributed to a measurand (measured quantitative property) together with any other available relevant information, like measurement uncertainty.
    ///
    /// -- VIM
    /// <see href="https://w3id.org/emmo#EMMO_0f6f0120_c079_4d95_bb11_4ddee05e530e"></see></summary>
    let EMMO_0f6f0120_c079_4d95_bb11_4ddee05e530e =
        Namespaced_IRI.parse _namespace_name "EMMO_0f6f0120_c079_4d95_bb11_4ddee05e530e" |> NamespacedName

    /// <summary>
    /// A coded conventional that is determined by each interpeter following a well defined determination procedure through a specific perception channel.
    /// The word objective does not mean that each observation will provide the same results. It means that the observation followed a well defined procedure.
    ///
    /// This class refers to what is commonly known as physical property, i.e. a measurable property of physical system, whether is quantifiable or not.
    /// <see href="https://w3id.org/emmo#EMMO_2a888cdf_ec4a_4ec5_af1c_0343372fc978"></see></summary>
    let EMMO_2a888cdf_ec4a_4ec5_af1c_0343372fc978 =
        Namespaced_IRI.parse _namespace_name "EMMO_2a888cdf_ec4a_4ec5_af1c_0343372fc978" |> NamespacedName

    /// <summary>
    /// Relates the result of a semiotic process to ont of its optained quantities.
    /// <see href="https://w3id.org/emmo#EMMO_5d73661e_e710_4844_ab9b_a85b7e68576a"></see></summary>
    let EMMO_5d73661e_e710_4844_ab9b_a85b7e68576a =
        Namespaced_IRI.parse _namespace_name "EMMO_5d73661e_e710_4844_ab9b_a85b7e68576a" |> NamespacedName

    /// <summary>
    /// A relation that identify a proper item part of the whole, whose parts always cover the full spatial extension of the whole within a time interval.
    /// A temporal part of an item cannot both cause and be caused by any other proper part of the item.
    /// A temporal part is not constraint to be causally self-connected, i.e. it can be either an item or a collection. We therefore introduce two subproperties in order to distinguish between both cases.
    /// <see href="https://w3id.org/emmo#EMMO_7afbed84_7593_4a23_bd88_9d9c6b04e8f6"></see></summary>
    let EMMO_7afbed84_7593_4a23_bd88_9d9c6b04e8f6 =
        Namespaced_IRI.parse _namespace_name "EMMO_7afbed84_7593_4a23_bd88_9d9c6b04e8f6" |> NamespacedName

    /// <summary>
    /// A chausal path whose quantum parts belongs to at least two different standard model fundamental types.
    /// An multi-particle path is a causal path of quantum entities of different type, following the causal connection between an initial quantum up to the final one, regardless on the fact that causality is passing through elementary particles of different types.
    /// For example, a path starting from an elementary  photon, then through the electron with which it scatter, and then trough a positron with which the electron collides.
    /// <see href="https://w3id.org/emmo#EMMO_5e00b1db_48fc_445b_82e8_ab0e2255bf52"></see></summary>
    let EMMO_5e00b1db_48fc_445b_82e8_ab0e2255bf52 =
        Namespaced_IRI.parse _namespace_name "EMMO_5e00b1db_48fc_445b_82e8_ab0e2255bf52" |> NamespacedName

    /// <summary>
    /// Quantity characterizing the relative variation of volume V with pressure p at constant entropy.
    /// The coherent SI unit of isentropic compressibility is pascal to the power minus one, 1/Pa.
    /// <see href="https://w3id.org/emmo#EMMO_1044e509_e204_433a_8130_8d4579ada59f"></see></summary>
    let EMMO_1044e509_e204_433a_8130_8d4579ada59f =
        Namespaced_IRI.parse _namespace_name "EMMO_1044e509_e204_433a_8130_8d4579ada59f" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareMassPerSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_109e8c69_4148_4cb0_9ceb_fbd526befca0"></see></summary>
    let EMMO_109e8c69_4148_4cb0_9ceb_fbd526befca0 =
        Namespaced_IRI.parse _namespace_name "EMMO_109e8c69_4148_4cb0_9ceb_fbd526befca0" |> NamespacedName

    /// <summary>
    /// A 'Semiosis' that involves an 'Observer' that perceives another 'Physical' (the 'Object') through a specific perception mechanism and produces a 'Property' (the 'Sign') that stands for the result of that particular perception according to a well defined conventional procedure.
    /// <see href="https://w3id.org/emmo#EMMO_10a5fd39_06aa_4648_9e70_f962a9cb2069"></see></summary>
    let EMMO_10a5fd39_06aa_4648_9e70_f962a9cb2069 =
        Namespaced_IRI.parse _namespace_name "EMMO_10a5fd39_06aa_4648_9e70_f962a9cb2069" |> NamespacedName

    /// <summary>
    /// An 'interpreter' that perceives another 'entity' (the 'object') through a specific perception mechanism and produces a 'property' (the 'sign') that stands for the result of that particular perception.
    /// <see href="https://w3id.org/emmo#EMMO_1b52ee70_121e_4d8d_8419_3f97cd0bd89c"></see></summary>
    let EMMO_1b52ee70_121e_4d8d_8419_3f97cd0bd89c =
        Namespaced_IRI.parse _namespace_name "EMMO_1b52ee70_121e_4d8d_8419_3f97cd0bd89c" |> NamespacedName

    /// <summary>
    /// A data that represents instants of time, marked with a particular time zone offset.
    /// <see href="https://w3id.org/emmo#EMMO_10bbe9e9_46b6_4b5d_8b51_ed759fc21f21"></see></summary>
    let EMMO_10bbe9e9_46b6_4b5d_8b51_ed759fc21f21 =
        Namespaced_IRI.parse _namespace_name "EMMO_10bbe9e9_46b6_4b5d_8b51_ed759fc21f21" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaPerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_10f703b5_8b2a_4c5a_a734_f0cfb29622ad"></see></summary>
    let EMMO_10f703b5_8b2a_4c5a_a734_f0cfb29622ad =
        Namespaced_IRI.parse _namespace_name "EMMO_10f703b5_8b2a_4c5a_a734_f0cfb29622ad" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the vanadium atom.
    /// <see href="https://w3id.org/emmo#EMMO_113acda0-3c17-59d9-87ef-7e5e5c0ba128"></see></summary>
    let ``EMMO_113acda0-3c17-59d9-87ef-7e5e5c0ba128`` =
        Namespaced_IRI.parse _namespace_name "EMMO_113acda0-3c17-59d9-87ef-7e5e5c0ba128" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerArea'.
    /// <see href="https://w3id.org/emmo#EMMO_11708648_fc62_46c6_bae5_3a10693e416e"></see></summary>
    let EMMO_11708648_fc62_46c6_bae5_3a10693e416e =
        Namespaced_IRI.parse _namespace_name "EMMO_11708648_fc62_46c6_bae5_3a10693e416e" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e9.
    /// <see href="https://w3id.org/emmo#EMMO_117d3e39_de3e_46f5_9744_b4a28d9fc83e"></see></summary>
    let EMMO_117d3e39_de3e_46f5_9744_b4a28d9fc83e =
        Namespaced_IRI.parse _namespace_name "EMMO_117d3e39_de3e_46f5_9744_b4a28d9fc83e" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "deci" (0.1).
    /// <see href="https://w3id.org/emmo#EMMO_1181c938_c8f0_4ad6_bc7a_2bfdc0903d29"></see></summary>
    let EMMO_1181c938_c8f0_4ad6_bc7a_2bfdc0903d29 =
        Namespaced_IRI.parse _namespace_name "EMMO_1181c938_c8f0_4ad6_bc7a_2bfdc0903d29" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1/10.
    /// <see href="https://w3id.org/emmo#EMMO_890856a3_3eb4_471e_a54a_65031bee30f4"></see></summary>
    let EMMO_890856a3_3eb4_471e_a54a_65031bee30f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_890856a3_3eb4_471e_a54a_65031bee30f4" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the mercury atom.
    /// <see href="https://w3id.org/emmo#EMMO_12120d44-785e-5e5e-a9fd-73fe7c24ead4"></see></summary>
    let ``EMMO_12120d44-785e-5e5e-a9fd-73fe7c24ead4`` =
        Namespaced_IRI.parse _namespace_name "EMMO_12120d44-785e-5e5e-a9fd-73fe7c24ead4" |> NamespacedName

    /// <summary>
    /// Atom subclass for platinum.
    /// <see href="https://w3id.org/emmo#EMMO_123629bd-efd6-5ba6-979e-2a4698b54e70"></see></summary>
    let ``EMMO_123629bd-efd6-5ba6-979e-2a4698b54e70`` =
        Namespaced_IRI.parse _namespace_name "EMMO_123629bd-efd6-5ba6-979e-2a4698b54e70" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the platinum atom.
    /// <see href="https://w3id.org/emmo#EMMO_e580b699-7725-58d5-b057-7b3c816e84a1"></see></summary>
    let ``EMMO_e580b699-7725-58d5-b057-7b3c816e84a1`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e580b699-7725-58d5-b057-7b3c816e84a1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_123b0aee_eac2_461f_8078_3a7c8dfbe7ce"></see>
    /// </summary>
    let EMMO_123b0aee_eac2_461f_8078_3a7c8dfbe7ce =
        Namespaced_IRI.parse _namespace_name "EMMO_123b0aee_eac2_461f_8078_3a7c8dfbe7ce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_5e5656ef_971e_49e6_a32f_048b6e86c3e0"></see>
    /// </summary>
    let EMMO_5e5656ef_971e_49e6_a32f_048b6e86c3e0 =
        Namespaced_IRI.parse _namespace_name "EMMO_5e5656ef_971e_49e6_a32f_048b6e86c3e0" |> NamespacedName

    /// <summary>
    /// Atom subclass for cerium.
    /// <see href="https://w3id.org/emmo#EMMO_125b6f65-caf4-5ff2-89f2-90a6183ee34e"></see></summary>
    let ``EMMO_125b6f65-caf4-5ff2-89f2-90a6183ee34e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_125b6f65-caf4-5ff2-89f2-90a6183ee34e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the cerium atom.
    /// <see href="https://w3id.org/emmo#EMMO_44eb5d63-b868-54c5-bd52-7528db10674d"></see></summary>
    let ``EMMO_44eb5d63-b868-54c5-bd52-7528db10674d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_44eb5d63-b868-54c5-bd52-7528db10674d" |> NamespacedName

    /// <summary>
    /// For a solute X in a solution; quantity proportional to the absolute activity.
    /// <see href="https://w3id.org/emmo#EMMO_125e8614_0dad_4c04_9ac9_03317e63beec"></see></summary>
    let EMMO_125e8614_0dad_4c04_9ac9_03317e63beec =
        Namespaced_IRI.parse _namespace_name "EMMO_125e8614_0dad_4c04_9ac9_03317e63beec" |> NamespacedName

    /// <summary>
    /// Square root of the product of electron and hole density in a semiconductor.
    /// <see href="https://w3id.org/emmo#EMMO_126e57a9_0f9c_4315_a031_bc273a0f302b"></see></summary>
    let EMMO_126e57a9_0f9c_4315_a031_bc273a0f302b =
        Namespaced_IRI.parse _namespace_name "EMMO_126e57a9_0f9c_4315_a031_bc273a0f302b" |> NamespacedName

    /// <summary>
    /// Physical quantity for measuring per volume.
    /// <see href="https://w3id.org/emmo#EMMO_ca369738_78de_470b_8631_be83f75e45a3"></see></summary>
    let EMMO_ca369738_78de_470b_8631_be83f75e45a3 =
        Namespaced_IRI.parse _namespace_name "EMMO_ca369738_78de_470b_8631_be83f75e45a3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_127594de_4802_4ad6_b09d_d05b340394dd"></see>
    /// </summary>
    let EMMO_127594de_4802_4ad6_b09d_d05b340394dd =
        Namespaced_IRI.parse _namespace_name "EMMO_127594de_4802_4ad6_b09d_d05b340394dd" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3aa37f92_8dc5_4ee4_8438_e41e6ae20c62"></see>
    /// </summary>
    let EMMO_3aa37f92_8dc5_4ee4_8438_e41e6ae20c62 =
        Namespaced_IRI.parse _namespace_name "EMMO_3aa37f92_8dc5_4ee4_8438_e41e6ae20c62" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PressurePerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_1275ac79_7280_4d99_ab61_3d98e00c053e"></see></summary>
    let EMMO_1275ac79_7280_4d99_ab61_3d98e00c053e =
        Namespaced_IRI.parse _namespace_name "EMMO_1275ac79_7280_4d99_ab61_3d98e00c053e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_12a9a254_9791_4a00_b045_f397bc3ab2bc"></see>
    /// </summary>
    let EMMO_12a9a254_9791_4a00_b045_f397bc3ab2bc =
        Namespaced_IRI.parse _namespace_name "EMMO_12a9a254_9791_4a00_b045_f397bc3ab2bc" |> NamespacedName

    /// <summary>
    /// A meson with spin zero and odd parity.
    /// <see href="https://w3id.org/emmo#EMMO_12aae025_a226_4762_9d51_81200a8ce54c"></see></summary>
    let EMMO_12aae025_a226_4762_9d51_81200a8ce54c =
        Namespaced_IRI.parse _namespace_name "EMMO_12aae025_a226_4762_9d51_81200a8ce54c" |> NamespacedName

    /// <summary>
    /// ratio of the product of ion molality b and a correction factor γ to the molality b° of the same ion in a standard solution under standardized conditions: a = bγ / b°.
    /// The correction factor is called activity coefficient and it is determined experimentally. See ActivityCoefficient
    /// Normally a standard solution is a solution of the ion at a molality of 1 mol/kg (exactly). Standardized conditions are normally 1013,25 hPa and 25 °C.
    /// <see href="https://w3id.org/emmo#EMMO_12b2ec1e_fb89_468a_a51d_97c2a6db297c"></see></summary>
    let EMMO_12b2ec1e_fb89_468a_a51d_97c2a6db297c =
        Namespaced_IRI.parse _namespace_name "EMMO_12b2ec1e_fb89_468a_a51d_97c2a6db297c" |> NamespacedName

    /// <summary>
    /// Heat is energy in transfer to or from a thermodynamic system, by mechanisms other than thermodynamic work or transfer of matter.
    /// <see href="https://w3id.org/emmo#EMMO_12d4ba9b_2f89_4ea3_b206_cd376f96c875"></see></summary>
    let EMMO_12d4ba9b_2f89_4ea3_b206_cd376f96c875 =
        Namespaced_IRI.parse _namespace_name "EMMO_12d4ba9b_2f89_4ea3_b206_cd376f96c875" |> NamespacedName

    /// <summary>
    /// Permittivity divided by electric constant.
    /// <see href="https://w3id.org/emmo#EMMO_12f0b2eb_a7b2_4f87_8176_12748f415832"></see></summary>
    let EMMO_12f0b2eb_a7b2_4f87_8176_12748f415832 =
        Namespaced_IRI.parse _namespace_name "EMMO_12f0b2eb_a7b2_4f87_8176_12748f415832" |> NamespacedName

    /// <summary>
    /// An object which is an holistic spatial part of a process.
    /// <see href="https://w3id.org/emmo#EMMO_13191289_6c2b_4741_93e1_82d53bd0e703"></see></summary>
    let EMMO_13191289_6c2b_4741_93e1_82d53bd0e703 =
        Namespaced_IRI.parse _namespace_name "EMMO_13191289_6c2b_4741_93e1_82d53bd0e703" |> NamespacedName

    /// <summary>
    /// The superclass for causal structure classes whose individuals have all temporal item parts of the same type of the whole.
    /// Indefinitely temporally slicing of an entity leads to temporal parts whose temporal extension is so small that the connectivity relations that define the entity as an item will no longer hold. More generally. a temporal part is no more of type ϕ when the temporal interval is lower than the interval that characterizes the causality interactions between the object parts.
    /// In other terms, if the time span of a temporal part is lower than the inverse of the frequency of interactions between the constituents, then the constituents in such temporal part are not connected. The object is no more an object, neither an item, but simply a collection of fundamental quantum parts.
    /// For this reason, the definition of object is done by considering only item temporal parts, meaning that slicing in time has the lower limit of a self-connected (i.e. item) entity.
    /// An item can be classified as an object according to a type ϕ (a ϕ-object) if it's a ϕ all its temporal item parts are also of type ϕ. This conceptualisation tries to catch the persistency of type in the temporal parts of an entity.
    /// <see href="https://w3id.org/emmo#EMMO_90ae56e4_d197_49b6_be1a_0049e4756606"></see></summary>
    let EMMO_90ae56e4_d197_49b6_be1a_0049e4756606 =
        Namespaced_IRI.parse _namespace_name "EMMO_90ae56e4_d197_49b6_be1a_0049e4756606" |> NamespacedName

    /// <summary>
    /// An holistic spatial part of a whole.
    /// <see href="https://w3id.org/emmo#EMMO_fcae603e_aa6e_4940_9fa1_9f0909cabf3b"></see></summary>
    let EMMO_fcae603e_aa6e_4940_9fa1_9f0909cabf3b =
        Namespaced_IRI.parse _namespace_name "EMMO_fcae603e_aa6e_4940_9fa1_9f0909cabf3b" |> NamespacedName

    /// <summary>
    /// Fundamental translation vectors for the reciprocal lattice.
    /// <see href="https://w3id.org/emmo#EMMO_134b78a0_63f8_4f7f_8098_925d1d934e48"></see></summary>
    let EMMO_134b78a0_63f8_4f7f_8098_925d1d934e48 =
        Namespaced_IRI.parse _namespace_name "EMMO_134b78a0_63f8_4f7f_8098_925d1d934e48" |> NamespacedName

    /// <summary>
    /// A process occurring by natural (non-intentional) laws.
    /// <see href="https://w3id.org/emmo#EMMO_135ab8ea_e028_439e_be64_3e0f9734ea2b"></see></summary>
    let EMMO_135ab8ea_e028_439e_be64_3e0f9734ea2b =
        Namespaced_IRI.parse _namespace_name "EMMO_135ab8ea_e028_439e_be64_3e0f9734ea2b" |> NamespacedName

    /// <summary>
    /// Quotient of the magnetic dipole moment of an atom, and the product of the nuclear spin quantum number and the nuclear magneton.
    /// <see href="https://w3id.org/emmo#EMMO_137c6f65_f393_43ca_9c6d_ac765de56a5a"></see></summary>
    let EMMO_137c6f65_f393_43ca_9c6d_ac765de56a5a =
        Namespaced_IRI.parse _namespace_name "EMMO_137c6f65_f393_43ca_9c6d_ac765de56a5a" |> NamespacedName

    /// <summary>
    /// Relation between observed magnetic moment of a particle and the related unit of magnetic moment.
    /// <see href="https://w3id.org/emmo#EMMO_cd981768_f96b_4b65_85e6_19216c0e1dd4"></see></summary>
    let EMMO_cd981768_f96b_4b65_85e6_19216c0e1dd4 =
        Namespaced_IRI.parse _namespace_name "EMMO_cd981768_f96b_4b65_85e6_19216c0e1dd4" |> NamespacedName

    /// <summary>
    /// A computer language that is domain-independent and can be used for expressing data from any kind of discipline.
    /// <see href="https://w3id.org/emmo#EMMO_13fea749_0b3b_4756_9c81_22cce620fc25"></see></summary>
    let EMMO_13fea749_0b3b_4756_9c81_22cce620fc25 =
        Namespaced_IRI.parse _namespace_name "EMMO_13fea749_0b3b_4756_9c81_22cce620fc25" |> NamespacedName

    /// <summary>
    /// A formal language used to communicate with a computer.
    /// The categorisation of computer languages is based on
    ///
    /// Guide to the Software Engineering Body of Knowledge (SWEBOK(R)): Version 3.0, January 2014. Editors Pierre Bourque, Richard E. Fairley. Publisher: IEEE Computer Society PressWashingtonDCUnited States. ISBN:978-0-7695-5166-1.
    /// https://www.computer.org/education/bodies-of-knowledge/software-engineering
    /// <see href="https://w3id.org/emmo#EMMO_19fe0747_6954_40cb_9f8f_b87498bc8e78"></see></summary>
    let EMMO_19fe0747_6954_40cb_9f8f_b87498bc8e78 =
        Namespaced_IRI.parse _namespace_name "EMMO_19fe0747_6954_40cb_9f8f_b87498bc8e78" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountConductivity'.
    /// <see href="https://w3id.org/emmo#EMMO_14235b93_650f_4452_8395_a23b8f645c9a"></see></summary>
    let EMMO_14235b93_650f_4452_8395_a23b8f645c9a =
        Namespaced_IRI.parse _namespace_name "EMMO_14235b93_650f_4452_8395_a23b8f645c9a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1440d010_e4c5_4597_8858_1d58cb1fb28f"></see>
    /// </summary>
    let EMMO_1440d010_e4c5_4597_8858_1d58cb1fb28f =
        Namespaced_IRI.parse _namespace_name "EMMO_1440d010_e4c5_4597_8858_1d58cb1fb28f" |> NamespacedName

    /// <summary>
    /// An object which is an holistic temporal part of a process.
    /// <see href="https://w3id.org/emmo#EMMO_d9589ed2_5304_48b3_9795_11bf44e64e9b"></see></summary>
    let EMMO_d9589ed2_5304_48b3_9795_11bf44e64e9b =
        Namespaced_IRI.parse _namespace_name "EMMO_d9589ed2_5304_48b3_9795_11bf44e64e9b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_9ee42d6b_7242_4a8d_967e_79f8f1c7fe29"></see>
    /// </summary>
    let EMMO_9ee42d6b_7242_4a8d_967e_79f8f1c7fe29 =
        Namespaced_IRI.parse _namespace_name "EMMO_9ee42d6b_7242_4a8d_967e_79f8f1c7fe29" |> NamespacedName

    /// <summary>
    /// A language object that follows syntactic rules of a programming language.
    /// A programming language object can also be a fragment (e.g. a C function) not suitable for exectution.
    /// <see href="https://w3id.org/emmo#EMMO_9ffffb55_3496_4307_82b8_a0d78fe1fcd8"></see></summary>
    let EMMO_9ffffb55_3496_4307_82b8_a0d78fe1fcd8 =
        Namespaced_IRI.parse _namespace_name "EMMO_9ffffb55_3496_4307_82b8_a0d78fe1fcd8" |> NamespacedName

    /// <summary>
    /// Quotient of the mean rate of production of particles in a volume, and that volume.
    /// <see href="https://w3id.org/emmo#EMMO_146e85cb_37a7_4204_84f1_30113cfddd0c"></see></summary>
    let EMMO_146e85cb_37a7_4204_84f1_30113cfddd0c =
        Namespaced_IRI.parse _namespace_name "EMMO_146e85cb_37a7_4204_84f1_30113cfddd0c" |> NamespacedName

    /// <summary>
    /// Atom subclass for erbium.
    /// <see href="https://w3id.org/emmo#EMMO_14729316-fa36-5eda-a5e6-86e28a5d80ba"></see></summary>
    let ``EMMO_14729316-fa36-5eda-a5e6-86e28a5d80ba`` =
        Namespaced_IRI.parse _namespace_name "EMMO_14729316-fa36-5eda-a5e6-86e28a5d80ba" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the erbium atom.
    /// <see href="https://w3id.org/emmo#EMMO_357b32b5-7d1b-5649-b9bd-2b1b9359fcd0"></see></summary>
    let ``EMMO_357b32b5-7d1b-5649-b9bd-2b1b9359fcd0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_357b32b5-7d1b-5649-b9bd-2b1b9359fcd0" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1494c1a9_00e1_40c2_a9cc_9bbf302a1cac"></see>
    /// </summary>
    let EMMO_1494c1a9_00e1_40c2_a9cc_9bbf302a1cac =
        Namespaced_IRI.parse _namespace_name "EMMO_1494c1a9_00e1_40c2_a9cc_9bbf302a1cac" |> NamespacedName

    /// <summary>
    /// The relation between two entities that overlaps and neither of both is part of the other.
    /// <see href="https://w3id.org/emmo#EMMO_b3c8ba10_6bee_45e7_9416_e9019aa9f023"></see></summary>
    let EMMO_b3c8ba10_6bee_45e7_9416_e9019aa9f023 =
        Namespaced_IRI.parse _namespace_name "EMMO_b3c8ba10_6bee_45e7_9416_e9019aa9f023" |> NamespacedName

    /// <summary>
    /// The input of a process.
    /// <see href="https://w3id.org/emmo#EMMO_36e69413_8c59_4799_946c_10b05d266e22"></see></summary>
    let EMMO_36e69413_8c59_4799_946c_10b05d266e22 =
        Namespaced_IRI.parse _namespace_name "EMMO_36e69413_8c59_4799_946c_10b05d266e22" |> NamespacedName

    /// <summary>
    /// Atom subclass for neptunium.
    /// <see href="https://w3id.org/emmo#EMMO_15595dc5-20a7-5b9f-a896-aad79f97bb8b"></see></summary>
    let ``EMMO_15595dc5-20a7-5b9f-a896-aad79f97bb8b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_15595dc5-20a7-5b9f-a896-aad79f97bb8b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the neptunium atom.
    /// <see href="https://w3id.org/emmo#EMMO_e941986d-658b-5a08-ae3d-4cc170344b06"></see></summary>
    let ``EMMO_e941986d-658b-5a08-ae3d-4cc170344b06`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e941986d-658b-5a08-ae3d-4cc170344b06" |> NamespacedName

    /// <summary>
    /// A link to a graphical representation aimed to facilitate understanding of the concept, or of an annotation.
    /// <see href="https://w3id.org/emmo#EMMO_157fdf31_6387_42be_8e72_10530519214a"></see></summary>
    let EMMO_157fdf31_6387_42be_8e72_10530519214a =
        Namespaced_IRI.parse _namespace_name "EMMO_157fdf31_6387_42be_8e72_10530519214a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the plutonium atom.
    /// <see href="https://w3id.org/emmo#EMMO_15841f91-ad7d-5b81-89d1-c12b13e42f32"></see></summary>
    let ``EMMO_15841f91-ad7d-5b81-89d1-c12b13e42f32`` =
        Namespaced_IRI.parse _namespace_name "EMMO_15841f91-ad7d-5b81-89d1-c12b13e42f32" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AbsorbedDoseRate'.
    /// <see href="https://w3id.org/emmo#EMMO_835f4e4e_680d_404c_8c73_92a6a570f6eb"></see></summary>
    let EMMO_835f4e4e_680d_404c_8c73_92a6a570f6eb =
        Namespaced_IRI.parse _namespace_name "EMMO_835f4e4e_680d_404c_8c73_92a6a570f6eb" |> NamespacedName

    /// <summary>
    /// Unit for dimensionless quantities that have the nature of count.
    /// <see href="https://w3id.org/emmo#EMMO_15d62b55_38ea_4aec_b7c4_25db1a2e5a01"></see></summary>
    let EMMO_15d62b55_38ea_4aec_b7c4_25db1a2e5a01 =
        Namespaced_IRI.parse _namespace_name "EMMO_15d62b55_38ea_4aec_b7c4_25db1a2e5a01" |> NamespacedName

    /// <summary>
    /// A class devoted to categorize causal objects by specifying their granularity levels.
    /// A granularity level is specified by a tiling decomposition of the whole y. A tiling is identified as a set of items {x1, x2, ... xn} called tiles that:
    ///     - are proper parts of y
    ///     - covers the entire whole (y = x1 +x2 + ... + xn)
    ///     - do not overlap
    ///     - are part of one, and one only, whole (inverse functional)
    /// <see href="https://w3id.org/emmo#EMMO_15db234d_ecaf_4715_9838_4b4ec424fb13"></see></summary>
    let EMMO_15db234d_ecaf_4715_9838_4b4ec424fb13 =
        Namespaced_IRI.parse _namespace_name "EMMO_15db234d_ecaf_4715_9838_4b4ec424fb13" |> NamespacedName

    /// <summary>
    /// A causal object that is direct part of a tessellation.
    /// <see href="https://w3id.org/emmo#EMMO_9953c19f_ee33_4af8_be5e_dbf6d1e33581"></see></summary>
    let EMMO_9953c19f_ee33_4af8_be5e_dbf6d1e33581 =
        Namespaced_IRI.parse _namespace_name "EMMO_9953c19f_ee33_4af8_be5e_dbf6d1e33581" |> NamespacedName

    /// <summary>
    /// The physical property of matter that causes it to experience a force when placed in an electromagnetic field.
    /// <see href="https://w3id.org/emmo#EMMO_1604f495_328a_4f28_9962_f4cc210739dd"></see></summary>
    let EMMO_1604f495_328a_4f28_9962_f4cc210739dd =
        Namespaced_IRI.parse _namespace_name "EMMO_1604f495_328a_4f28_9962_f4cc210739dd" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_161bef57_cc59_4246_8249_19dbdae96e7b"></see>
    /// </summary>
    let EMMO_161bef57_cc59_4246_8249_19dbdae96e7b =
        Namespaced_IRI.parse _namespace_name "EMMO_161bef57_cc59_4246_8249_19dbdae96e7b" |> NamespacedName

    /// <summary>
    /// A programming language that is executed through runtime interpretation.
    /// <see href="https://w3id.org/emmo#EMMO_f84b1b92_1dc8_4146_99f0_b03cd53e455b"></see></summary>
    let EMMO_f84b1b92_1dc8_4146_99f0_b03cd53e455b =
        Namespaced_IRI.parse _namespace_name "EMMO_f84b1b92_1dc8_4146_99f0_b03cd53e455b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_16a3bd5c_75f0_42b3_b000_cb0d018f840e"></see>
    /// </summary>
    let EMMO_16a3bd5c_75f0_42b3_b000_cb0d018f840e =
        Namespaced_IRI.parse _namespace_name "EMMO_16a3bd5c_75f0_42b3_b000_cb0d018f840e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_26586828_3b8c_4d8b_9c6c_0bc2502f26ae"></see>
    /// </summary>
    let EMMO_26586828_3b8c_4d8b_9c6c_0bc2502f26ae =
        Namespaced_IRI.parse _namespace_name "EMMO_26586828_3b8c_4d8b_9c6c_0bc2502f26ae" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_91a0635a_a89a_46de_8928_04a777d145c7"></see>
    /// </summary>
    let EMMO_91a0635a_a89a_46de_8928_04a777d145c7 =
        Namespaced_IRI.parse _namespace_name "EMMO_91a0635a_a89a_46de_8928_04a777d145c7" |> NamespacedName

    /// <summary>
    /// An object can be represented by a quantity for the fact that it has been recognized to belong to a specific class.
    ///
    /// The quantity is selected without an observation aimed to measure its actual value, but by convention.
    /// Assigns a quantity to an object by convention.
    /// <see href="https://w3id.org/emmo#EMMO_16b510a6_0584_4134_bdb6_3bc185c17860"></see></summary>
    let EMMO_16b510a6_0584_4134_bdb6_3bc185c17860 =
        Namespaced_IRI.parse _namespace_name "EMMO_16b510a6_0584_4134_bdb6_3bc185c17860" |> NamespacedName

    /// <summary>
    /// A property that is associated to an object by convention, or assumption.
    /// A quantitative property attributed by agreement to a quantity for a given purpose.
    /// <see href="https://w3id.org/emmo#EMMO_d8aa8e1f_b650_416d_88a0_5118de945456"></see></summary>
    let EMMO_d8aa8e1f_b650_416d_88a0_5118de945456 =
        Namespaced_IRI.parse _namespace_name "EMMO_d8aa8e1f_b650_416d_88a0_5118de945456" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_16c41198_3881_4a34_bae5_993f88823993"></see>
    /// </summary>
    let EMMO_16c41198_3881_4a34_bae5_993f88823993 =
        Namespaced_IRI.parse _namespace_name "EMMO_16c41198_3881_4a34_bae5_993f88823993" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f8b20fd2_08b9_4368_b786_156e11d1cec8"></see>
    /// </summary>
    let EMMO_f8b20fd2_08b9_4368_b786_156e11d1cec8 =
        Namespaced_IRI.parse _namespace_name "EMMO_f8b20fd2_08b9_4368_b786_156e11d1cec8" |> NamespacedName

    /// <summary>
    /// A system arranged to setup a specific manufacturing process.
    /// <see href="https://w3id.org/emmo#EMMO_16cc6deb_d9f8_4ede_900a_a17cc86e57c4"></see></summary>
    let EMMO_16cc6deb_d9f8_4ede_900a_a17cc86e57c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_16cc6deb_d9f8_4ede_900a_a17cc86e57c4" |> NamespacedName

    /// <summary>
    /// A system which is mainly characterised by the spatial configuration of its elements.
    /// <see href="https://w3id.org/emmo#EMMO_b9522e56_1fac_4766_97e6_428605fabd3e"></see></summary>
    let EMMO_b9522e56_1fac_4766_97e6_428605fabd3e =
        Namespaced_IRI.parse _namespace_name "EMMO_b9522e56_1fac_4766_97e6_428605fabd3e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_16d1606c_e562_43cd_a92c_0894abc2027b"></see>
    /// </summary>
    let EMMO_16d1606c_e562_43cd_a92c_0894abc2027b =
        Namespaced_IRI.parse _namespace_name "EMMO_16d1606c_e562_43cd_a92c_0894abc2027b" |> NamespacedName

    /// <summary>
    /// Archetype join attaches two workpiece with geometrically defined shape together, using supplementary workpiece made of amorphous material (e.g. powder).
    /// <see href="https://w3id.org/emmo#EMMO_22496460_c849_4bd7_8be0_9a1202506f18"></see></summary>
    let EMMO_22496460_c849_4bd7_8be0_9a1202506f18 =
        Namespaced_IRI.parse _namespace_name "EMMO_22496460_c849_4bd7_8be0_9a1202506f18" |> NamespacedName

    /// <summary>
    /// Number of turns.
    /// <see href="https://w3id.org/emmo#EMMO_16d72037_3243_4018_ac6c_0015f661d3c3"></see></summary>
    let EMMO_16d72037_3243_4018_ac6c_0015f661d3c3 =
        Namespaced_IRI.parse _namespace_name "EMMO_16d72037_3243_4018_ac6c_0015f661d3c3" |> NamespacedName

    /// <summary>
    /// Mass of a constituent divided by the volume of the mixture.
    /// <see href="https://w3id.org/emmo#EMMO_16f2fe60_2db7_43ca_8fee_5b3e416bfe87"></see></summary>
    let EMMO_16f2fe60_2db7_43ca_8fee_5b3e416bfe87 =
        Namespaced_IRI.parse _namespace_name "EMMO_16f2fe60_2db7_43ca_8fee_5b3e416bfe87" |> NamespacedName

    /// <summary>
    /// the abundance of a constituent divided by the total volume of a mixture.
    /// <see href="https://w3id.org/emmo#EMMO_a356870d_409a_4de6_a910_0d8498e593ff"></see></summary>
    let EMMO_a356870d_409a_4de6_a910_0d8498e593ff =
        Namespaced_IRI.parse _namespace_name "EMMO_a356870d_409a_4de6_a910_0d8498e593ff" |> NamespacedName

    /// <summary>
    /// Following nominalistic approach a species is simply a name that can point to an element name, a chemical formula or a chemical compound.
    ///
    /// So everything addressed by these classes of names can be calleded a chemical species.
    /// Specific form of an element defined as to isotopic composition, electronic or oxidation state, and/or complex or molecular structure.
    ///
    /// Chemical species is the macroscopic equivalent of molecular entity and refers to sets or ensembles of molecular entities.
    /// N2
    /// Methane
    /// CH4
    /// Fe
    /// Sodium Chloride
    /// <see href="https://w3id.org/emmo#EMMO_cbcf8fe6_6da6_49e0_ab4d_00f737ea9689"></see></summary>
    let EMMO_cbcf8fe6_6da6_49e0_ab4d_00f737ea9689 =
        Namespaced_IRI.parse _namespace_name "EMMO_cbcf8fe6_6da6_49e0_ab4d_00f737ea9689" |> NamespacedName

    /// <summary>
    /// Diffusion coefficient through the pore space of a porous media.
    /// <see href="https://w3id.org/emmo#EMMO_1744d51d_0dac_4f48_8b50_fde6c7c2ab39"></see></summary>
    let EMMO_1744d51d_0dac_4f48_8b50_fde6c7c2ab39 =
        Namespaced_IRI.parse _namespace_name "EMMO_1744d51d_0dac_4f48_8b50_fde6c7c2ab39" |> NamespacedName

    /// <summary>
    /// Proportionality constant in some physical laws.
    /// <see href="https://w3id.org/emmo#EMMO_931a725b_926d_4f60_8955_61fe17fce98b"></see></summary>
    let EMMO_931a725b_926d_4f60_8955_61fe17fce98b =
        Namespaced_IRI.parse _namespace_name "EMMO_931a725b_926d_4f60_8955_61fe17fce98b" |> NamespacedName

    /// <summary>
    /// The DBpedia definition (http://dbpedia.org/page/Avogadro_constant) is outdated as May 20, 2019. It is now an exact quantity.
    /// The number of constituent particles, usually atoms or molecules, that are contained in the amount of substance given by one mole.
    ///
    /// It defines the base unit mole in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_176cae33_b83e_4cd2_a6bc_281f42f0ccc8"></see></summary>
    let EMMO_176cae33_b83e_4cd2_a6bc_281f42f0ccc8 =
        Namespaced_IRI.parse _namespace_name "EMMO_176cae33_b83e_4cd2_a6bc_281f42f0ccc8" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_af24ae20_8ef2_435a_86a1_2ea44488b318"></see></summary>
    let EMMO_af24ae20_8ef2_435a_86a1_2ea44488b318 =
        Namespaced_IRI.parse _namespace_name "EMMO_af24ae20_8ef2_435a_86a1_2ea44488b318" |> NamespacedName

    /// <summary>
    /// Physical constant that by definition (after the latest revision of the SI system that was enforsed May 2019) has a known exact numerical value when expressed in SI units.
    /// <see href="https://w3id.org/emmo#EMMO_f2ca6dd0_0e5f_4392_a92d_cafdae6cfc95"></see></summary>
    let EMMO_f2ca6dd0_0e5f_4392_a92d_cafdae6cfc95 =
        Namespaced_IRI.parse _namespace_name "EMMO_f2ca6dd0_0e5f_4392_a92d_cafdae6cfc95" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the manganese atom.
    /// <see href="https://w3id.org/emmo#EMMO_179a652d-68c8-5412-9621-98b4b00984dd"></see></summary>
    let ``EMMO_179a652d-68c8-5412-9621-98b4b00984dd`` =
        Namespaced_IRI.parse _namespace_name "EMMO_179a652d-68c8-5412-9621-98b4b00984dd" |> NamespacedName

    /// <summary>
    /// The difference in electric potential between two points.
    /// Correspond to the work needed per unit of charge to move a test charge between two points in a static electric field.
    /// <see href="https://w3id.org/emmo#EMMO_17b031fb_4695_49b6_bb69_189ec63df3ee"></see></summary>
    let EMMO_17b031fb_4695_49b6_bb69_189ec63df3ee =
        Namespaced_IRI.parse _namespace_name "EMMO_17b031fb_4695_49b6_bb69_189ec63df3ee" |> NamespacedName

    /// <summary>
    /// Energy required to move a unit charge through an electric field from a reference point.
    /// The electric potential is not unique, since any constant scalar field quantity can be added to it without changing its gradient.
    /// <see href="https://w3id.org/emmo#EMMO_4f2d3939_91b1_4001_b8ab_7d19074bf845"></see></summary>
    let EMMO_4f2d3939_91b1_4001_b8ab_7d19074bf845 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f2d3939_91b1_4001_b8ab_7d19074bf845" |> NamespacedName

    /// <summary>
    /// The inverse relation of hasPart.
    /// <see href="https://w3id.org/emmo#EMMO_a8bd7094_6b40_47af_b1f4_a69d81a3afbd"></see></summary>
    let EMMO_a8bd7094_6b40_47af_b1f4_a69d81a3afbd =
        Namespaced_IRI.parse _namespace_name "EMMO_a8bd7094_6b40_47af_b1f4_a69d81a3afbd" |> NamespacedName

    /// <summary>
    /// The inverse relation for overcrosses.
    /// <see href="https://w3id.org/emmo#EMMO_e4f66254_7312_4de5_a86a_6e0808baaaab"></see></summary>
    let EMMO_e4f66254_7312_4de5_a86a_6e0808baaaab =
        Namespaced_IRI.parse _namespace_name "EMMO_e4f66254_7312_4de5_a86a_6e0808baaaab" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerArea'.
    /// <see href="https://w3id.org/emmo#EMMO_183f6fac_8543_44e0_bd59_434aa7054f4c"></see></summary>
    let EMMO_183f6fac_8543_44e0_bd59_434aa7054f4c =
        Namespaced_IRI.parse _namespace_name "EMMO_183f6fac_8543_44e0_bd59_434aa7054f4c" |> NamespacedName

    /// <summary>
    /// Atom subclass for astatine.
    /// <see href="https://w3id.org/emmo#EMMO_186607c3-fe59-5731-983f-4374a1f8544b"></see></summary>
    let ``EMMO_186607c3-fe59-5731-983f-4374a1f8544b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_186607c3-fe59-5731-983f-4374a1f8544b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the astatine atom.
    /// <see href="https://w3id.org/emmo#EMMO_c7651944-e33f-56bc-8d83-f6de9760d661"></see></summary>
    let ``EMMO_c7651944-e33f-56bc-8d83-f6de9760d661`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c7651944-e33f-56bc-8d83-f6de9760d661" |> NamespacedName

    /// <summary>
    /// Atom subclass for praseodymium.
    /// <see href="https://w3id.org/emmo#EMMO_18748aef-0e6b-5369-99b5-1e5ab1a0f99b"></see></summary>
    let ``EMMO_18748aef-0e6b-5369-99b5-1e5ab1a0f99b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_18748aef-0e6b-5369-99b5-1e5ab1a0f99b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the praseodymium atom.
    /// <see href="https://w3id.org/emmo#EMMO_3565b4e7-51bd-57e5-afde-60be404857cf"></see></summary>
    let ``EMMO_3565b4e7-51bd-57e5-afde-60be404857cf`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3565b4e7-51bd-57e5-afde-60be404857cf" |> NamespacedName

    /// <summary>
    /// A reference unit provided by a reference material.
    /// International vocabulary of metrology (VIM)
    /// <see href="https://w3id.org/emmo#EMMO_acd1a504_ca32_4f30_86ad_0b62cea5bc02"></see></summary>
    let EMMO_acd1a504_ca32_4f30_86ad_0b62cea5bc02 =
        Namespaced_IRI.parse _namespace_name "EMMO_acd1a504_ca32_4f30_86ad_0b62cea5bc02" |> NamespacedName

    /// <summary>
    /// Procedure units and measurement units are disjoint.
    /// A reference unit provided by a measurement procedure.
    /// <see href="https://w3id.org/emmo#EMMO_c9c8f824_9127_4f93_bc21_69fe78a7f6f2"></see></summary>
    let EMMO_c9c8f824_9127_4f93_bc21_69fe78a7f6f2 =
        Namespaced_IRI.parse _namespace_name "EMMO_c9c8f824_9127_4f93_bc21_69fe78a7f6f2" |> NamespacedName

    /// <summary>
    /// A data representing a real number.
    /// <see href="https://w3id.org/emmo#EMMO_18d180e4_5e3e_42f7_820c_e08951223486"></see></summary>
    let EMMO_18d180e4_5e3e_42f7_820c_e08951223486 =
        Namespaced_IRI.parse _namespace_name "EMMO_18d180e4_5e3e_42f7_820c_e08951223486" |> NamespacedName

    /// <summary>
    /// A symbolic data representing a numerical value.
    /// <see href="https://w3id.org/emmo#EMMO_8b305b63_6fa3_44dd_9679_17eb8403a07a"></see></summary>
    let EMMO_8b305b63_6fa3_44dd_9679_17eb8403a07a =
        Namespaced_IRI.parse _namespace_name "EMMO_8b305b63_6fa3_44dd_9679_17eb8403a07a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the dysprosium atom.
    /// <see href="https://w3id.org/emmo#EMMO_1936bc9e-5e81-5267-bd48-cbec9a6cfb17"></see></summary>
    let ``EMMO_1936bc9e-5e81-5267-bd48-cbec9a6cfb17`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1936bc9e-5e81-5267-bd48-cbec9a6cfb17" |> NamespacedName

    /// <summary>
    /// The superclass for all physical quantities classes that are categorized according to some domain of interests (e.g. metallurgy, chemistry), property (intensive/extensive) or application.
    /// <see href="https://w3id.org/emmo#EMMO_79751276_b2d0_4e2f_bbd4_99d412f43d55"></see></summary>
    let EMMO_79751276_b2d0_4e2f_bbd4_99d412f43d55 =
        Namespaced_IRI.parse _namespace_name "EMMO_79751276_b2d0_4e2f_bbd4_99d412f43d55" |> NamespacedName

    /// <summary>
    /// Quantum number of an atom describing the inclination of the nuclear spin with respect to a quantization axis given by the magnetic field produced by the orbital electrons.
    /// <see href="https://w3id.org/emmo#EMMO_1942247a_50b4_4109_bff4_bb213de45e08"></see></summary>
    let EMMO_1942247a_50b4_4109_bff4_bb213de45e08 =
        Namespaced_IRI.parse _namespace_name "EMMO_1942247a_50b4_4109_bff4_bb213de45e08" |> NamespacedName

    /// <summary>
    /// Number describing a particular state of a quantum system.
    /// <see href="https://w3id.org/emmo#EMMO_252cce84_cc8a_49dc_8405_0d5e06425d69"></see></summary>
    let EMMO_252cce84_cc8a_49dc_8405_0d5e06425d69 =
        Namespaced_IRI.parse _namespace_name "EMMO_252cce84_cc8a_49dc_8405_0d5e06425d69" |> NamespacedName

    /// <summary>
    /// Encoded data made of more than one datum.
    /// <see href="https://w3id.org/emmo#EMMO_194e367c_9783_4bf5_96d0_9ad597d48d9a"></see></summary>
    let EMMO_194e367c_9783_4bf5_96d0_9ad597d48d9a =
        Namespaced_IRI.parse _namespace_name "EMMO_194e367c_9783_4bf5_96d0_9ad597d48d9a" |> NamespacedName

    /// <summary>
    /// A self-consistent encoded data entity.
    /// <see href="https://w3id.org/emmo#EMMO_50d6236a_7667_4883_8ae1_9bb5d190423a"></see></summary>
    let EMMO_50d6236a_7667_4883_8ae1_9bb5d190423a =
        Namespaced_IRI.parse _namespace_name "EMMO_50d6236a_7667_4883_8ae1_9bb5d190423a" |> NamespacedName

    /// <summary>
    /// Relates a dataset to its datum.
    /// <see href="https://w3id.org/emmo#EMMO_6b78c119_f86c_4b5e_ba6c_b42d25a64122"></see></summary>
    let EMMO_6b78c119_f86c_4b5e_ba6c_b42d25a64122 =
        Namespaced_IRI.parse _namespace_name "EMMO_6b78c119_f86c_4b5e_ba6c_b42d25a64122" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LorenzNumber'.
    /// <see href="https://w3id.org/emmo#EMMO_197095a5_6d0c_4747_bcd7_f239203217dc"></see></summary>
    let EMMO_197095a5_6d0c_4747_bcd7_f239203217dc =
        Namespaced_IRI.parse _namespace_name "EMMO_197095a5_6d0c_4747_bcd7_f239203217dc" |> NamespacedName

    /// <summary>
    /// Measure of the tendency of a solution to take in pure solvent by osmosis.
    /// <see href="https://w3id.org/emmo#EMMO_19c5c2b2_463b_4e41_bd50_4f7239aa62d9"></see></summary>
    let EMMO_19c5c2b2_463b_4e41_bd50_4f7239aa62d9 =
        Namespaced_IRI.parse _namespace_name "EMMO_19c5c2b2_463b_4e41_bd50_4f7239aa62d9" |> NamespacedName

    /// <summary>
    /// The force applied perpendicular to the surface of an object per unit area over which that force is distributed.
    /// <see href="https://w3id.org/emmo#EMMO_50a44256_9dc5_434b_bad4_74a4d9a29989"></see></summary>
    let EMMO_50a44256_9dc5_434b_bad4_74a4d9a29989 =
        Namespaced_IRI.parse _namespace_name "EMMO_50a44256_9dc5_434b_bad4_74a4d9a29989" |> NamespacedName

    /// <summary>
    /// A well-formed formula in computer science may be or not be interpreted by a computer. For example pseudo-code is only intended for human consumption.
    /// A well-formed formula that follows the syntactic rules of computer science.
    /// <see href="https://w3id.org/emmo#EMMO_b45fbdc6_2519_4885_aa49_c56b394c3910"></see></summary>
    let EMMO_b45fbdc6_2519_4885_aa49_c56b394c3910 =
        Namespaced_IRI.parse _namespace_name "EMMO_b45fbdc6_2519_4885_aa49_c56b394c3910" |> NamespacedName

    /// <summary>
    /// An electric dipole, vector quantity of magnitude equal to the product of the positive charge and the distance between the charges and directed from the negative charge to the positive charge.
    /// <see href="https://w3id.org/emmo#EMMO_1a179ce4_3724_47f8_bee5_6292e3ac9942"></see></summary>
    let EMMO_1a179ce4_3724_47f8_bee5_6292e3ac9942 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a179ce4_3724_47f8_bee5_6292e3ac9942" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricDipoleMoment'.
    /// <see href="https://w3id.org/emmo#EMMO_cab2be5c_4e71_4c15_8412_adb2a7f0831a"></see></summary>
    let EMMO_cab2be5c_4e71_4c15_8412_adb2a7f0831a =
        Namespaced_IRI.parse _namespace_name "EMMO_cab2be5c_4e71_4c15_8412_adb2a7f0831a" |> NamespacedName

    /// <summary>
    /// A manufacturing process in which the shape of a workpiece is changed by breaking the material cohesion at the processing point and thus the material cohesion is reduced overall.
    /// <see href="https://w3id.org/emmo#EMMO_90589553_5625_4074_8f0d_0532fd7eb42b"></see></summary>
    let EMMO_90589553_5625_4074_8f0d_0532fd7eb42b =
        Namespaced_IRI.parse _namespace_name "EMMO_90589553_5625_4074_8f0d_0532fd7eb42b" |> NamespacedName

    /// <summary>
    /// Base quantities defined in the International System of Quantities (ISQ).
    /// <see href="https://w3id.org/emmo#EMMO_1a4c1a97_88a7_4d8e_b2f9_2ca58e92dde4"></see></summary>
    let EMMO_1a4c1a97_88a7_4d8e_b2f9_2ca58e92dde4 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a4c1a97_88a7_4d8e_b2f9_2ca58e92dde4" |> NamespacedName

    /// <summary>
    /// Quantities declared under the ISO 80000.
    /// <see href="https://w3id.org/emmo#EMMO_f35cff4d_dc09_44cf_a729_22fb79e3bfb2"></see></summary>
    let EMMO_f35cff4d_dc09_44cf_a729_22fb79e3bfb2 =
        Namespaced_IRI.parse _namespace_name "EMMO_f35cff4d_dc09_44cf_a729_22fb79e3bfb2" |> NamespacedName

    /// <summary>
    /// A measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle. It is based on the luminosity function, which is a standardized model of the sensitivity of the human eye.
    /// <see href="https://w3id.org/emmo#EMMO_50bf79a6_a48b_424d_9d2c_813bd631231a"></see></summary>
    let EMMO_50bf79a6_a48b_424d_9d2c_813bd631231a =
        Namespaced_IRI.parse _namespace_name "EMMO_50bf79a6_a48b_424d_9d2c_813bd631231a" |> NamespacedName

    /// <summary>
    /// The number of elementary entities present.
    /// "In the name “amount of substance”, the word “substance” will typically be replaced by words to specify the substance concerned in any particular application, for example “amount of hydrogen chloride, HCl”, or “amount of benzene, C6H6 ”. It is important to give a precise definition of the entity involved (as emphasized in the definition of the mole); this should preferably be done by specifying the molecular chemical formula of the material involved. Although the word “amount” has a more general dictionary definition, the abbreviation of the full name “amount of substance” to “amount” may be used for brevity."
    ///
    /// -- SI Brochure
    /// <see href="https://w3id.org/emmo#EMMO_8159c26a_494b_4fa0_9959_10888f152298"></see></summary>
    let EMMO_8159c26a_494b_4fa0_9959_10888f152298 =
        Namespaced_IRI.parse _namespace_name "EMMO_8159c26a_494b_4fa0_9959_10888f152298" |> NamespacedName

    /// <summary>
    /// Thermodynamic temperature is the absolute measure of temperature. It is defined by the third law of thermodynamics in which the theoretically lowest temperature is the null or zero point.
    /// <see href="https://w3id.org/emmo#EMMO_affe07e4_e9bc_4852_86c6_69e26182a17f"></see></summary>
    let EMMO_affe07e4_e9bc_4852_86c6_69e26182a17f =
        Namespaced_IRI.parse _namespace_name "EMMO_affe07e4_e9bc_4852_86c6_69e26182a17f" |> NamespacedName

    /// <summary>
    /// Property of a physical body that express its resistance to acceleration (a change in its state of motion) when a force is applied.
    /// <see href="https://w3id.org/emmo#EMMO_ed4af7ae_63a2_497e_bb88_2309619ea405"></see></summary>
    let EMMO_ed4af7ae_63a2_497e_bb88_2309619ea405 =
        Namespaced_IRI.parse _namespace_name "EMMO_ed4af7ae_63a2_497e_bb88_2309619ea405" |> NamespacedName

    /// <summary>
    /// distance between successive lattice planes
    /// <see href="https://w3id.org/emmo#EMMO_1a4ed964_9ee4_44a9_b386_4b0f95cf6666"></see></summary>
    let EMMO_1a4ed964_9ee4_44a9_b386_4b0f95cf6666 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a4ed964_9ee4_44a9_b386_4b0f95cf6666" |> NamespacedName

    /// <summary>
    /// Distance is the norm of Displacement.
    /// Shortest path length between two points in a metric space.
    /// <see href="https://w3id.org/emmo#EMMO_6ee9304e_54b7_4594_8354_0790138dffb8"></see></summary>
    let EMMO_6ee9304e_54b7_4594_8354_0790138dffb8 =
        Namespaced_IRI.parse _namespace_name "EMMO_6ee9304e_54b7_4594_8354_0790138dffb8" |> NamespacedName

    /// <summary>
    /// Characteristic quantum number s of a particle, related to its spin.
    /// <see href="https://w3id.org/emmo#EMMO_1a5dd75a_6ed6_4148_a99c_001a27f5b417"></see></summary>
    let EMMO_1a5dd75a_6ed6_4148_a99c_001a27f5b417 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a5dd75a_6ed6_4148_a99c_001a27f5b417" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1a9e6e27_1e1d_492a_824e_6fb848574846"></see>
    /// </summary>
    let EMMO_1a9e6e27_1e1d_492a_824e_6fb848574846 =
        Namespaced_IRI.parse _namespace_name "EMMO_1a9e6e27_1e1d_492a_824e_6fb848574846" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1abe0ea7_2378_402f_b950_89b0795d2f45"></see>
    /// </summary>
    let EMMO_1abe0ea7_2378_402f_b950_89b0795d2f45 =
        Namespaced_IRI.parse _namespace_name "EMMO_1abe0ea7_2378_402f_b950_89b0795d2f45" |> NamespacedName

    /// <summary>
    /// Number of slowed-down particles per time and volume.
    /// <see href="https://w3id.org/emmo#EMMO_1ac837ae_23e4_4cae_b866_dcf18c5c8a3d"></see></summary>
    let EMMO_1ac837ae_23e4_4cae_b866_dcf18c5c8a3d =
        Namespaced_IRI.parse _namespace_name "EMMO_1ac837ae_23e4_4cae_b866_dcf18c5c8a3d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1acb552d_281a_40a4_9d55_5e31b85d4dc1"></see>
    /// </summary>
    let EMMO_1acb552d_281a_40a4_9d55_5e31b85d4dc1 =
        Namespaced_IRI.parse _namespace_name "EMMO_1acb552d_281a_40a4_9d55_5e31b85d4dc1" |> NamespacedName

    /// <summary>
    /// Atom subclass for hassium.
    /// <see href="https://w3id.org/emmo#EMMO_1acc07d0-709d-53f4-9807-cbc0d144865c"></see></summary>
    let ``EMMO_1acc07d0-709d-53f4-9807-cbc0d144865c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1acc07d0-709d-53f4-9807-cbc0d144865c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the hassium atom.
    /// <see href="https://w3id.org/emmo#EMMO_ef4ce791-8ba4-55cd-a6fa-778133a19d19"></see></summary>
    let ``EMMO_ef4ce791-8ba4-55cd-a6fa-778133a19d19`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ef4ce791-8ba4-55cd-a6fa-778133a19d19" |> NamespacedName

    /// <summary>
    /// An expression that has parts only integer constants, variables, and the algebraic operations (addition, subtraction, multiplication, division and exponentiation by an exponent that is a rational number)
    /// <see href="https://w3id.org/emmo#EMMO_1aed91a3_d00c_48af_8f43_a0c958b2512a"></see></summary>
    let EMMO_1aed91a3_d00c_48af_8f43_a0c958b2512a =
        Namespaced_IRI.parse _namespace_name "EMMO_1aed91a3_d00c_48af_8f43_a0c958b2512a" |> NamespacedName

    /// <summary>
    /// A well-formed finite combination of mathematical symbols according to some specific rules.
    /// <see href="https://w3id.org/emmo#EMMO_f9bc8b52_85e9_4b53_b969_dd7724d5b8e4"></see></summary>
    let EMMO_f9bc8b52_85e9_4b53_b969_dd7724d5b8e4 =
        Namespaced_IRI.parse _namespace_name "EMMO_f9bc8b52_85e9_4b53_b969_dd7724d5b8e4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_1b01c9c6_6367_498c_a04d_1a37499b3eff"></see>
    /// </summary>
    let EMMO_1b01c9c6_6367_498c_a04d_1a37499b3eff =
        Namespaced_IRI.parse _namespace_name "EMMO_1b01c9c6_6367_498c_a04d_1a37499b3eff" |> NamespacedName

    /// <summary>
    /// Atom subclass for barium.
    /// <see href="https://w3id.org/emmo#EMMO_1b1aa658-a7d5-5bc6-9d78-37a901fd66dd"></see></summary>
    let ``EMMO_1b1aa658-a7d5-5bc6-9d78-37a901fd66dd`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1b1aa658-a7d5-5bc6-9d78-37a901fd66dd" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the barium atom.
    /// <see href="https://w3id.org/emmo#EMMO_d60619c8-1abe-52c0-9491-eb3086245e22"></see></summary>
    let ``EMMO_d60619c8-1abe-52c0-9491-eb3086245e22`` =
        Namespaced_IRI.parse _namespace_name "EMMO_d60619c8-1abe-52c0-9491-eb3086245e22" |> NamespacedName

    /// <summary>
    /// A meson with total spin 1 and odd parit.
    /// <see href="https://w3id.org/emmo#EMMO_1b32a555_978b_4e56_933f_e158e165023e"></see></summary>
    let EMMO_1b32a555_978b_4e56_933f_e158e165023e =
        Namespaced_IRI.parse _namespace_name "EMMO_1b32a555_978b_4e56_933f_e158e165023e" |> NamespacedName

    /// <summary>
    /// A characteriser that declares a property for an object without actually interact with it with the specific interaction required by the property definition (i.e. infer a property from other properties).
    /// <see href="https://w3id.org/emmo#EMMO_4a1c73f1_b6f5_4d10_a3a6_5de90bac7cd0"></see></summary>
    let EMMO_4a1c73f1_b6f5_4d10_a3a6_5de90bac7cd0 =
        Namespaced_IRI.parse _namespace_name "EMMO_4a1c73f1_b6f5_4d10_a3a6_5de90bac7cd0" |> NamespacedName

    /// <summary>
    /// A characteriser that declares a property for an object through the specific interaction required by the property definition.
    /// <see href="https://w3id.org/emmo#EMMO_ea67caa5_2609_4e91_98ae_81103f2d5c25"></see></summary>
    let EMMO_ea67caa5_2609_4e91_98ae_81103f2d5c25 =
        Namespaced_IRI.parse _namespace_name "EMMO_ea67caa5_2609_4e91_98ae_81103f2d5c25" |> NamespacedName

    /// <summary>
    /// A coded that has been observed by an interpreter.
    /// <see href="https://w3id.org/emmo#EMMO_1b6a95fb_3df7_44c9_ad3d_419c9c5fe7cb"></see></summary>
    let EMMO_1b6a95fb_3df7_44c9_ad3d_419c9c5fe7cb =
        Namespaced_IRI.parse _namespace_name "EMMO_1b6a95fb_3df7_44c9_ad3d_419c9c5fe7cb" |> NamespacedName

    /// <summary>
    /// A structured collection of data held in a computer system that has a well-defined interface.
    /// <see href="https://w3id.org/emmo#EMMO_1beed5ca_2bab_425d_bbe6_db6fab6ffe64"></see></summary>
    let EMMO_1beed5ca_2bab_425d_bbe6_db6fab6ffe64 =
        Namespaced_IRI.parse _namespace_name "EMMO_1beed5ca_2bab_425d_bbe6_db6fab6ffe64" |> NamespacedName

    /// <summary>
    /// Matter composed of both matter and antimatter fundamental particles.
    /// <see href="https://w3id.org/emmo#EMMO_1c16bb7f_5400_4498_8ef2_54392908da4e"></see></summary>
    let EMMO_1c16bb7f_5400_4498_8ef2_54392908da4e =
        Namespaced_IRI.parse _namespace_name "EMMO_1c16bb7f_5400_4498_8ef2_54392908da4e" |> NamespacedName

    /// <summary>
    /// Quantity characterizing the variation with thermodynamic temperature T of the volume V of a body, under given conditions.
    /// alpha_V = (1/V) * (dV/dT)
    /// <see href="https://w3id.org/emmo#EMMO_1c1ec02e_4def_4979_aff9_572c06a95391"></see></summary>
    let EMMO_1c1ec02e_4def_4979_aff9_572c06a95391 =
        Namespaced_IRI.parse _namespace_name "EMMO_1c1ec02e_4def_4979_aff9_572c06a95391" |> NamespacedName

    /// <summary>
    /// Material property which describes how the size of an object changes with a change in temperature.
    /// <see href="https://w3id.org/emmo#EMMO_80f3d95d_b1fd_46c0_b98a_b6b611b47105"></see></summary>
    let EMMO_80f3d95d_b1fd_46c0_b98a_b6b611b47105 =
        Namespaced_IRI.parse _namespace_name "EMMO_80f3d95d_b1fd_46c0_b98a_b6b611b47105" |> NamespacedName

    /// <summary>
    /// Relative change of length per change of temperature.
    /// <see href="https://w3id.org/emmo#EMMO_399426d1_c4cc_414c_806f_47096c72d634"></see></summary>
    let EMMO_399426d1_c4cc_414c_806f_47096c72d634 =
        Namespaced_IRI.parse _namespace_name "EMMO_399426d1_c4cc_414c_806f_47096c72d634" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerElectricCharge'.
    /// <see href="https://w3id.org/emmo#EMMO_1c3de02f_ddbd_4704_9538_3d4f38cc373e"></see></summary>
    let EMMO_1c3de02f_ddbd_4704_9538_3d4f38cc373e =
        Namespaced_IRI.parse _namespace_name "EMMO_1c3de02f_ddbd_4704_9538_3d4f38cc373e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the flerovium atom.
    /// <see href="https://w3id.org/emmo#EMMO_1c5c8217-481b-5ae9-b44f-9ec353f6ea93"></see></summary>
    let ``EMMO_1c5c8217-481b-5ae9-b44f-9ec353f6ea93`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1c5c8217-481b-5ae9-b44f-9ec353f6ea93" |> NamespacedName

    /// <summary>
    /// A computation that provides a data output following the elaboration of some input data, using a data processing application.
    /// <see href="https://w3id.org/emmo#EMMO_1c7f2dfe_0db4_4bf6_a0f6_853054a34ead"></see></summary>
    let EMMO_1c7f2dfe_0db4_4bf6_a0f6_853054a34ead =
        Namespaced_IRI.parse _namespace_name "EMMO_1c7f2dfe_0db4_4bf6_a0f6_853054a34ead" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_cbf42aa6_9e11_4be8_932a_ae3c792ab17d"></see>
    /// </summary>
    let EMMO_cbf42aa6_9e11_4be8_932a_ae3c792ab17d =
        Namespaced_IRI.parse _namespace_name "EMMO_cbf42aa6_9e11_4be8_932a_ae3c792ab17d" |> NamespacedName

    /// <summary>
    /// Participation is a parthood relation: you must be part of the process to contribute to it. A participant whose 4D extension is totally contained within the process.
    ///
    /// Participation is not under direct parthood since a process is not strictly related to reductionism, but it's a way to categorize temporal regions by the interpreters.
    /// The relation between a process and an object participating to it, i.e. that is relevant to the process itself.
    /// <see href="https://w3id.org/emmo#EMMO_ae2d1a96_bfa1_409a_a7d2_03d69e8a125a"></see></summary>
    let EMMO_ae2d1a96_bfa1_409a_a7d2_03d69e8a125a =
        Namespaced_IRI.parse _namespace_name "EMMO_ae2d1a96_bfa1_409a_a7d2_03d69e8a125a" |> NamespacedName

    /// <summary>
    /// 2-dimensional array who's spatial direct parts are vectors.
    /// <see href="https://w3id.org/emmo#EMMO_1cba0b27_15d0_4326_933f_379d0b3565b6"></see></summary>
    let EMMO_1cba0b27_15d0_4326_933f_379d0b3565b6 =
        Namespaced_IRI.parse _namespace_name "EMMO_1cba0b27_15d0_4326_933f_379d0b3565b6" |> NamespacedName

    /// <summary>
    /// A tessellation in wich a tile has next two or more non spatially connected tiles.
    /// <see href="https://w3id.org/emmo#EMMO_1ce18268_dc63_42af_9113_6589331b5562"></see></summary>
    let EMMO_1ce18268_dc63_42af_9113_6589331b5562 =
        Namespaced_IRI.parse _namespace_name "EMMO_1ce18268_dc63_42af_9113_6589331b5562" |> NamespacedName

    /// <summary>
    /// A well formed tessellation with tiles that are all temporal.
    /// <see href="https://w3id.org/emmo#EMMO_f7f41d20_eabb_4bcb_9a16_0436851fcd5c"></see></summary>
    let EMMO_f7f41d20_eabb_4bcb_9a16_0436851fcd5c =
        Namespaced_IRI.parse _namespace_name "EMMO_f7f41d20_eabb_4bcb_9a16_0436851fcd5c" |> NamespacedName

    /// <summary>
    /// Vector potential of the magnetic flux density.
    /// <see href="https://w3id.org/emmo#EMMO_1d77524b_ff3f_4e9a_90a4_be3d0bd88855"></see></summary>
    let EMMO_1d77524b_ff3f_4e9a_90a4_be3d0bd88855 =
        Namespaced_IRI.parse _namespace_name "EMMO_1d77524b_ff3f_4e9a_90a4_be3d0bd88855" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticPotential'.
    /// <see href="https://w3id.org/emmo#EMMO_8cf32f24_ada1_4350_af2c_50eb0e5f6415"></see></summary>
    let EMMO_8cf32f24_ada1_4350_af2c_50eb0e5f6415 =
        Namespaced_IRI.parse _namespace_name "EMMO_8cf32f24_ada1_4350_af2c_50eb0e5f6415" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "deca" (10).
    /// <see href="https://w3id.org/emmo#EMMO_1d8b370b_c672_4d0c_964e_eaafcbf2f51f"></see></summary>
    let EMMO_1d8b370b_c672_4d0c_964e_eaafcbf2f51f =
        Namespaced_IRI.parse _namespace_name "EMMO_1d8b370b_c672_4d0c_964e_eaafcbf2f51f" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 10.
    /// <see href="https://w3id.org/emmo#EMMO_e07a252a_6913_49d6_9038_37a258b2d95e"></see></summary>
    let EMMO_e07a252a_6913_49d6_9038_37a258b2d95e =
        Namespaced_IRI.parse _namespace_name "EMMO_e07a252a_6913_49d6_9038_37a258b2d95e" |> NamespacedName

    /// <summary>
    /// A 'Graphical' that stands for a real world object that shows a recognizable pictorial pattern without being necessarily associated to a symbolic language.
    /// <see href="https://w3id.org/emmo#EMMO_1da53c06_9577_4008_8652_272fa3b62be7"></see></summary>
    let EMMO_1da53c06_9577_4008_8652_272fa3b62be7 =
        Namespaced_IRI.parse _namespace_name "EMMO_1da53c06_9577_4008_8652_272fa3b62be7" |> NamespacedName

    /// <summary>
    /// Symbolic data that can be represented as a sequence of zeros and ones.
    /// <see href="https://w3id.org/emmo#EMMO_1daaf7b2_e7bf_4b3a_b7f6_8aa3f3c3d080"></see></summary>
    let EMMO_1daaf7b2_e7bf_4b3a_b7f6_8aa3f3c3d080 =
        Namespaced_IRI.parse _namespace_name "EMMO_1daaf7b2_e7bf_4b3a_b7f6_8aa3f3c3d080" |> NamespacedName

    /// <summary>
    /// The class for entities which stands for data expressed using a symbolic encoding.
    /// A symbolic data is a a data that is rooted on some symbolic based encoding, such as floating point numbers, strings, integer. They are not to be intended as mathematical entities (even if they may be interpreted as such) but as syntactic structures (datastructures or datatypes) based on concatenated tokens (or symbols, letters) that can deliver data.
    /// <see href="https://w3id.org/emmo#EMMO_70bbb94e_2ca7_4d73_ba01_6397f134d172"></see></summary>
    let EMMO_70bbb94e_2ca7_4d73_ba01_6397f134d172 =
        Namespaced_IRI.parse _namespace_name "EMMO_70bbb94e_2ca7_4d73_ba01_6397f134d172" |> NamespacedName

    /// <summary>
    /// inverse of the mass density ρ, thus v = 1/ρ.
    /// <see href="https://w3id.org/emmo#EMMO_1db22203_95cb_46e2_ad94_14367a93d1dc"></see></summary>
    let EMMO_1db22203_95cb_46e2_ad94_14367a93d1dc =
        Namespaced_IRI.parse _namespace_name "EMMO_1db22203_95cb_46e2_ad94_14367a93d1dc" |> NamespacedName

    /// <summary>
    /// In geometrical optics, vergence describes the curvature of optical wavefronts.
    /// <see href="https://w3id.org/emmo#EMMO_1e7603a7_1365_49b8_b5e5_3711c8e6b904"></see></summary>
    let EMMO_1e7603a7_1365_49b8_b5e5_3711c8e6b904 =
        Namespaced_IRI.parse _namespace_name "EMMO_1e7603a7_1365_49b8_b5e5_3711c8e6b904" |> NamespacedName

    /// <summary>
    /// A non encoded contrast (e.g. a temperature variation) can be represented by data that describes (e.g. the string "today it's warmer than yesterday") or quantifies (e.g. Monday 28 °C, Tuesday 30 °C) it through a semiotic process.
    /// Contrast that occurs naturally without an encoding agent producing it.
    /// <see href="https://w3id.org/emmo#EMMO_5a10e288_c6a5_409a_a16a_98a2fb8be4f3"></see></summary>
    let EMMO_5a10e288_c6a5_409a_a16a_98a2fb8be4f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_5a10e288_c6a5_409a_a16a_98a2fb8be4f3" |> NamespacedName

    /// <summary>
    /// For metals, the resistivity extrapolated to zero thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_1eb6b28e_f260_4f04_ada1_19c6dcb668d9"></see></summary>
    let EMMO_1eb6b28e_f260_4f04_ada1_19c6dcb668d9 =
        Namespaced_IRI.parse _namespace_name "EMMO_1eb6b28e_f260_4f04_ada1_19c6dcb668d9" |> NamespacedName

    /// <summary>
    /// Electric field strength divided by the current density.
    /// <see href="https://w3id.org/emmo#EMMO_e150fa8d_06dc_4bb8_bf95_04e2aea529c1"></see></summary>
    let EMMO_e150fa8d_06dc_4bb8_bf95_04e2aea529c1 =
        Namespaced_IRI.parse _namespace_name "EMMO_e150fa8d_06dc_4bb8_bf95_04e2aea529c1" |> NamespacedName

    /// <summary>
    /// A mathematical object in this branch is not representing a concept but an actual graphical object built using mathematcal symbols arranged in some way, according to math conventions.
    /// The class of general mathematical symbolic objects respecting mathematical syntactic rules.
    /// <see href="https://w3id.org/emmo#EMMO_54ee6b5e_5261_44a8_86eb_5717e7fdb9d0"></see></summary>
    let EMMO_54ee6b5e_5261_44a8_86eb_5717e7fdb9d0 =
        Namespaced_IRI.parse _namespace_name "EMMO_54ee6b5e_5261_44a8_86eb_5717e7fdb9d0" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Force'.
    /// <see href="https://w3id.org/emmo#EMMO_53e825d9_1a09_483c_baa7_37501ebfbe1c"></see></summary>
    let EMMO_53e825d9_1a09_483c_baa7_37501ebfbe1c =
        Namespaced_IRI.parse _namespace_name "EMMO_53e825d9_1a09_483c_baa7_37501ebfbe1c" |> NamespacedName

    /// <summary>
    /// A non-elementary particle (bonded) of a fundamental bosonic type (integer spin).
    /// <see href="https://w3id.org/emmo#EMMO_1f19b65b_35bf_4662_a318_7f1c147cb3b6"></see></summary>
    let EMMO_1f19b65b_35bf_4662_a318_7f1c147cb3b6 =
        Namespaced_IRI.parse _namespace_name "EMMO_1f19b65b_35bf_4662_a318_7f1c147cb3b6" |> NamespacedName

    /// <summary>
    /// A composite particle is a bonded particle for which it is possible to clearly define its bosonic or fermionic behaviour. The term particle is then reserved for entities whose fermionic or bosonic nature is clearly defined.
    /// <see href="https://w3id.org/emmo#EMMO_8b1367d6_0133_4b56_acc1_fa8b058169e3"></see></summary>
    let EMMO_8b1367d6_0133_4b56_acc1_fa8b058169e3 =
        Namespaced_IRI.parse _namespace_name "EMMO_8b1367d6_0133_4b56_acc1_fa8b058169e3" |> NamespacedName

    /// <summary>
    /// A collapse is a fundamental interaction between m colliding particles that results in a single outgoing particle (inverse decay)  that is expressed as a complete bipartite directed graph K(m,1) with m&gt;1.
    /// <see href="https://w3id.org/emmo#EMMO_1f2bfb9f_ecc6_46a0_9e41_2d6fcbf59e4b"></see></summary>
    let EMMO_1f2bfb9f_ecc6_46a0_9e41_2d6fcbf59e4b =
        Namespaced_IRI.parse _namespace_name "EMMO_1f2bfb9f_ecc6_46a0_9e41_2d6fcbf59e4b" |> NamespacedName

    /// <summary>
    /// A colloid formed by trapping pockets of gas in a liquid or solid.
    /// <see href="https://w3id.org/emmo#EMMO_1f5e3e7e_72c9_40d4_91dd_ae432d7b7018"></see></summary>
    let EMMO_1f5e3e7e_72c9_40d4_91dd_ae432d7b7018 =
        Namespaced_IRI.parse _namespace_name "EMMO_1f5e3e7e_72c9_40d4_91dd_ae432d7b7018" |> NamespacedName

    /// <summary>
    /// Hexadecimal encoding of binary data, using the alphabeth [0-9a-f].
    /// <see href="https://w3id.org/emmo#EMMO_1f96db65_51df_4e8d_afd2_9c6b8bd40058"></see></summary>
    let EMMO_1f96db65_51df_4e8d_afd2_9c6b8bd40058 =
        Namespaced_IRI.parse _namespace_name "EMMO_1f96db65_51df_4e8d_afd2_9c6b8bd40058" |> NamespacedName

    /// <summary>
    /// Number of particles per time and area crossing a surface.
    /// <see href="https://w3id.org/emmo#EMMO_1fa63b54_64d7_40fa_9c8c_003bd61664d1"></see></summary>
    let EMMO_1fa63b54_64d7_40fa_9c8c_003bd61664d1 =
        Namespaced_IRI.parse _namespace_name "EMMO_1fa63b54_64d7_40fa_9c8c_003bd61664d1" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the nickel atom.
    /// <see href="https://w3id.org/emmo#EMMO_1fade54b-20ed-5e58-af59-214ea3b15ba9"></see></summary>
    let ``EMMO_1fade54b-20ed-5e58-af59-214ea3b15ba9`` =
        Namespaced_IRI.parse _namespace_name "EMMO_1fade54b-20ed-5e58-af59-214ea3b15ba9" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricChargePerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_200c735e_3dd7_44b2_bb34_4bb454a8e53b"></see></summary>
    let EMMO_200c735e_3dd7_44b2_bb34_4bb454a8e53b =
        Namespaced_IRI.parse _namespace_name "EMMO_200c735e_3dd7_44b2_bb34_4bb454a8e53b" |> NamespacedName

    /// <summary>
    /// Measurement unit obtained by multiplying a given measurement unit by an integer SI prefix greater than one.
    /// <see href="https://w3id.org/emmo#EMMO_2024fca1_b015_45ee_9490_e9e7d36bf704"></see></summary>
    let EMMO_2024fca1_b015_45ee_9490_e9e7d36bf704 =
        Namespaced_IRI.parse _namespace_name "EMMO_2024fca1_b015_45ee_9490_e9e7d36bf704" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "hecto" (100).
    /// <see href="https://w3id.org/emmo#EMMO_21aaefc1_3f86_4208_b7db_a755f31f0f8c"></see></summary>
    let EMMO_21aaefc1_3f86_4208_b7db_a755f31f0f8c =
        Namespaced_IRI.parse _namespace_name "EMMO_21aaefc1_3f86_4208_b7db_a755f31f0f8c" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "tera" (1e12).
    /// <see href="https://w3id.org/emmo#EMMO_3a204900_2b33_47d1_b444_815cc4c8cffa"></see></summary>
    let EMMO_3a204900_2b33_47d1_b444_815cc4c8cffa =
        Namespaced_IRI.parse _namespace_name "EMMO_3a204900_2b33_47d1_b444_815cc4c8cffa" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "peta" (1e15).
    /// <see href="https://w3id.org/emmo#EMMO_43a6b269_da31_4bb6_a537_c97df4fff32a"></see></summary>
    let EMMO_43a6b269_da31_4bb6_a537_c97df4fff32a =
        Namespaced_IRI.parse _namespace_name "EMMO_43a6b269_da31_4bb6_a537_c97df4fff32a" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "exa" (1e18).
    /// <see href="https://w3id.org/emmo#EMMO_5cf9f86c_86f5_40c4_846d_60371f670e0a"></see></summary>
    let EMMO_5cf9f86c_86f5_40c4_846d_60371f670e0a =
        Namespaced_IRI.parse _namespace_name "EMMO_5cf9f86c_86f5_40c4_846d_60371f670e0a" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "mega" (1e6).
    /// <see href="https://w3id.org/emmo#EMMO_5eaecadc_4f0d_4a3a_afc7_1fc0b83cc928"></see></summary>
    let EMMO_5eaecadc_4f0d_4a3a_afc7_1fc0b83cc928 =
        Namespaced_IRI.parse _namespace_name "EMMO_5eaecadc_4f0d_4a3a_afc7_1fc0b83cc928" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "kilo" (1000).
    /// <see href="https://w3id.org/emmo#EMMO_74931b1b_c133_4e59_9a75_1bf0e1626201"></see></summary>
    let EMMO_74931b1b_c133_4e59_9a75_1bf0e1626201 =
        Namespaced_IRI.parse _namespace_name "EMMO_74931b1b_c133_4e59_9a75_1bf0e1626201" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "giga" (1e9).
    /// <see href="https://w3id.org/emmo#EMMO_a8eb4bbb_1bd3_4ad4_b114_2789bcbd2134"></see></summary>
    let EMMO_a8eb4bbb_1bd3_4ad4_b114_2789bcbd2134 =
        Namespaced_IRI.parse _namespace_name "EMMO_a8eb4bbb_1bd3_4ad4_b114_2789bcbd2134" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "zetta" (1e21).
    /// <see href="https://w3id.org/emmo#EMMO_daa9ee97_4c5f_42e5_918c_44d7523e8958"></see></summary>
    let EMMO_daa9ee97_4c5f_42e5_918c_44d7523e8958 =
        Namespaced_IRI.parse _namespace_name "EMMO_daa9ee97_4c5f_42e5_918c_44d7523e8958" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "yotta" (1e24).
    /// <see href="https://w3id.org/emmo#EMMO_e79c62ff_10ad_4ec0_baba_c19ddd4eaa11"></see></summary>
    let EMMO_e79c62ff_10ad_4ec0_baba_c19ddd4eaa11 =
        Namespaced_IRI.parse _namespace_name "EMMO_e79c62ff_10ad_4ec0_baba_c19ddd4eaa11" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the protactinium atom.
    /// <see href="https://w3id.org/emmo#EMMO_209b3242-1274-5d1d-a965-f8cb3fcc1073"></see></summary>
    let ``EMMO_209b3242-1274-5d1d-a965-f8cb3fcc1073`` =
        Namespaced_IRI.parse _namespace_name "EMMO_209b3242-1274-5d1d-a965-f8cb3fcc1073" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the mendelevium atom.
    /// <see href="https://w3id.org/emmo#EMMO_20bb4724-2370-5205-ab8e-51a4c3609d3b"></see></summary>
    let ``EMMO_20bb4724-2370-5205-ab8e-51a4c3609d3b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_20bb4724-2370-5205-ab8e-51a4c3609d3b" |> NamespacedName

    /// <summary>
    /// 3-dimensional array who's spatial direct parts are matrices.
    /// <see href="https://w3id.org/emmo#EMMO_20ff3b34_c864_4936_8955_9345fc0a3b3c"></see></summary>
    let EMMO_20ff3b34_c864_4936_8955_9345fc0a3b3c =
        Namespaced_IRI.parse _namespace_name "EMMO_20ff3b34_c864_4936_8955_9345fc0a3b3c" |> NamespacedName

    /// <summary>
    /// A process which is an holistic temporal part of an object.
    /// <see href="https://w3id.org/emmo#EMMO_210e7e99_c1cf_44cc_87c7_310a10ff068b"></see></summary>
    let EMMO_210e7e99_c1cf_44cc_87c7_310a10ff068b =
        Namespaced_IRI.parse _namespace_name "EMMO_210e7e99_c1cf_44cc_87c7_310a10ff068b" |> NamespacedName

    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity that can undergo a chemical reaction.
    /// Molecular entity is used as a general term for singular entities, irrespective of their nature, while chemical species stands for sets or ensembles of molecular entities.
    /// Note that the name of a compound may refer to the respective molecular entity or to the chemical species,
    /// Molecular entity is used as a general term for singular entities, irrespective of their nature, while chemical species stands for sets or ensembles of molecular entities.
    ///
    /// Note that the name of a compound may refer to the respective molecular entity or to the chemical species,
    /// <see href="https://w3id.org/emmo#EMMO_21205421_5783_4d3e_81e5_10c5d894a88a"></see></summary>
    let EMMO_21205421_5783_4d3e_81e5_10c5d894a88a =
        Namespaced_IRI.parse _namespace_name "EMMO_21205421_5783_4d3e_81e5_10c5d894a88a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_24788d59_32f5_4339_a42a_43a102ec14a8"></see>
    /// </summary>
    let EMMO_24788d59_32f5_4339_a42a_43a102ec14a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_24788d59_32f5_4339_a42a_43a102ec14a8" |> NamespacedName

    /// <summary>
    /// A symbol that stands for a single unit.
    /// <see href="https://w3id.org/emmo#EMMO_216f448e_cdbc_4aeb_a529_7a5fe7fc38bb"></see></summary>
    let EMMO_216f448e_cdbc_4aeb_a529_7a5fe7fc38bb =
        Namespaced_IRI.parse _namespace_name "EMMO_216f448e_cdbc_4aeb_a529_7a5fe7fc38bb" |> NamespacedName

    /// <summary>
    /// A set of units that correspond to the base quantities in a system of units.
    /// <see href="https://w3id.org/emmo#EMMO_db716151_6b73_45ff_910c_d182fdcbb4f5"></see></summary>
    let EMMO_db716151_6b73_45ff_910c_d182fdcbb4f5 =
        Namespaced_IRI.parse _namespace_name "EMMO_db716151_6b73_45ff_910c_d182fdcbb4f5" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ThermalConductance'.
    /// <see href="https://w3id.org/emmo#EMMO_21a91e48_b6d3_4558_b08f_246433d43860"></see></summary>
    let EMMO_21a91e48_b6d3_4558_b08f_246433d43860 =
        Namespaced_IRI.parse _namespace_name "EMMO_21a91e48_b6d3_4558_b08f_246433d43860" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 100.
    /// <see href="https://w3id.org/emmo#EMMO_4bc07644_8301_4aed_b21c_823f99b08d1a"></see></summary>
    let EMMO_4bc07644_8301_4aed_b21c_823f99b08d1a =
        Namespaced_IRI.parse _namespace_name "EMMO_4bc07644_8301_4aed_b21c_823f99b08d1a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SexticLength'.
    /// <see href="https://w3id.org/emmo#EMMO_21bc99ae_f2ba_4eb3_90c1_d81968c429e2"></see></summary>
    let EMMO_21bc99ae_f2ba_4eb3_90c1_d81968c429e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_21bc99ae_f2ba_4eb3_90c1_d81968c429e2" |> NamespacedName

    /// <summary>
    /// Quotient of the linear attenuation coefficient µ and the number density, n, of atoms in the substance.
    /// <see href="https://w3id.org/emmo#EMMO_21e69447_1d0c_4880_ab8c_6bfbcd83aab4"></see></summary>
    let EMMO_21e69447_1d0c_4880_ab8c_6bfbcd83aab4 =
        Namespaced_IRI.parse _namespace_name "EMMO_21e69447_1d0c_4880_ab8c_6bfbcd83aab4" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Area'.
    /// <see href="https://w3id.org/emmo#EMMO_33433bb1_c68f_45ee_a466_f01e2c57b214"></see></summary>
    let EMMO_33433bb1_c68f_45ee_a466_f01e2c57b214 =
        Namespaced_IRI.parse _namespace_name "EMMO_33433bb1_c68f_45ee_a466_f01e2c57b214" |> NamespacedName

    /// <summary>
    /// A 'Mathematical' that has no unknown value, i.e. all its 'Variable"-s parts refers to a 'Number' (for scalars that have a built-in datatype) or to another 'Numerical' (for complex numerical data structures that should rely on external implementations).
    /// <see href="https://w3id.org/emmo#EMMO_4ce76d7f_03f8_45b6_9003_90052a79bfaa"></see></summary>
    let EMMO_4ce76d7f_03f8_45b6_9003_90052a79bfaa =
        Namespaced_IRI.parse _namespace_name "EMMO_4ce76d7f_03f8_45b6_9003_90052a79bfaa" |> NamespacedName

    /// <summary>
    /// Base-64 encoding of binary data.
    /// <see href="https://w3id.org/emmo#EMMO_220218b0_bbe2_489e_a68a_232e3610718e"></see></summary>
    let EMMO_220218b0_bbe2_489e_a68a_232e3610718e =
        Namespaced_IRI.parse _namespace_name "EMMO_220218b0_bbe2_489e_a68a_232e3610718e" |> NamespacedName

    /// <summary>
    /// A liquid is a nearly incompressible fluid that conforms to the shape of its container but retains a (nearly) constant volume independent of pressure.
    /// <see href="https://w3id.org/emmo#EMMO_7509da43_56b1_4d7f_887a_65d1663df4ba"></see></summary>
    let EMMO_7509da43_56b1_4d7f_887a_65d1663df4ba =
        Namespaced_IRI.parse _namespace_name "EMMO_7509da43_56b1_4d7f_887a_65d1663df4ba" |> NamespacedName

    /// <summary>
    /// A continuum characterized by structural rigidity and resistance to changes of shape or volume, that retains its shape and density when not confined.
    /// <see href="https://w3id.org/emmo#EMMO_a2b006f2_bbfd_4dba_bcaa_3fca20cd6be1"></see></summary>
    let EMMO_a2b006f2_bbfd_4dba_bcaa_3fca20cd6be1 =
        Namespaced_IRI.parse _namespace_name "EMMO_a2b006f2_bbfd_4dba_bcaa_3fca20cd6be1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_223d9523_4169_4ecd_b8af_acad1215e1ff"></see>
    /// </summary>
    let EMMO_223d9523_4169_4ecd_b8af_acad1215e1ff =
        Namespaced_IRI.parse _namespace_name "EMMO_223d9523_4169_4ecd_b8af_acad1215e1ff" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3c424d37_cf62_41b1_ac9d_a316f8d113d6"></see>
    /// </summary>
    let EMMO_3c424d37_cf62_41b1_ac9d_a316f8d113d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_3c424d37_cf62_41b1_ac9d_a316f8d113d6" |> NamespacedName

    /// <summary>
    /// An experiment is a process that is intended to replicate a physical phenomenon in a controlled environment.
    /// <see href="https://w3id.org/emmo#EMMO_22522299_4091_4d1f_82a2_3890492df6db"></see></summary>
    let EMMO_22522299_4091_4d1f_82a2_3890492df6db =
        Namespaced_IRI.parse _namespace_name "EMMO_22522299_4091_4d1f_82a2_3890492df6db" |> NamespacedName

    /// <summary>
    /// A 'process' that is recognized by physical sciences and is categorized accordingly.
    /// While every 'process' in the EMMO involves physical objects, this class is devoted to represent real world objects that express a phenomenon relevant for the ontologist
    /// <see href="https://w3id.org/emmo#EMMO_314d0bd5_67ed_437e_a609_36d46147cea7"></see></summary>
    let EMMO_314d0bd5_67ed_437e_a609_36d46147cea7 =
        Namespaced_IRI.parse _namespace_name "EMMO_314d0bd5_67ed_437e_a609_36d46147cea7" |> NamespacedName

    /// <summary>
    /// The relation between a process P and an object whole O that overcrosses it. The intersection between P and O is a participant of P.
    /// <see href="https://w3id.org/emmo#EMMO_35c29eb6_f57e_48d8_85af_854f9e926e77"></see></summary>
    let EMMO_35c29eb6_f57e_48d8_85af_854f9e926e77 =
        Namespaced_IRI.parse _namespace_name "EMMO_35c29eb6_f57e_48d8_85af_854f9e926e77" |> NamespacedName

    /// <summary>
    /// A manufacturing in which workpieces are produced from solid raw parts through permanent deformation, provided that neither material is added nor removed.
    /// The mass of the raw part is equal to the mass of the finished part.
    /// <see href="https://w3id.org/emmo#EMMO_2b4783a6_36ad_48c8_8f5d_fe7c05ad298b"></see></summary>
    let EMMO_2b4783a6_36ad_48c8_8f5d_fe7c05ad298b =
        Namespaced_IRI.parse _namespace_name "EMMO_2b4783a6_36ad_48c8_8f5d_fe7c05ad298b" |> NamespacedName

    /// <summary>
    /// The generic EMMO semiotical relation.
    /// <see href="https://w3id.org/emmo#EMMO_2337e25c_3c60_43fc_a8f9_b11a3f974291"></see></summary>
    let EMMO_2337e25c_3c60_43fc_a8f9_b11a3f974291 =
        Namespaced_IRI.parse _namespace_name "EMMO_2337e25c_3c60_43fc_a8f9_b11a3f974291" |> NamespacedName

    /// <summary>
    /// The class for all relations used by the EMMO.
    /// <see href="https://w3id.org/emmo#EMMO_ec2472ae_cf4a_46a5_8555_1556f5a6c3c5"></see></summary>
    let EMMO_ec2472ae_cf4a_46a5_8555_1556f5a6c3c5 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec2472ae_cf4a_46a5_8555_1556f5a6c3c5" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is a positive integer larger than 1.
    /// <see href="https://w3id.org/emmo#EMMO_2374896c_4ef8_4b3d_8c0c_0d29ba66bcfb"></see></summary>
    let EMMO_2374896c_4ef8_4b3d_8c0c_0d29ba66bcfb =
        Namespaced_IRI.parse _namespace_name "EMMO_2374896c_4ef8_4b3d_8c0c_0d29ba66bcfb" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e12.
    /// <see href="https://w3id.org/emmo#EMMO_33fe9747_d66f_4f88_b2c1_951279dbca59"></see></summary>
    let EMMO_33fe9747_d66f_4f88_b2c1_951279dbca59 =
        Namespaced_IRI.parse _namespace_name "EMMO_33fe9747_d66f_4f88_b2c1_951279dbca59" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e18.
    /// <see href="https://w3id.org/emmo#EMMO_3f2d29d9_6d27_43bd_a1bc_85475eae98be"></see></summary>
    let EMMO_3f2d29d9_6d27_43bd_a1bc_85475eae98be =
        Namespaced_IRI.parse _namespace_name "EMMO_3f2d29d9_6d27_43bd_a1bc_85475eae98be" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1000.
    /// <see href="https://w3id.org/emmo#EMMO_68a031ba_abf5_4859_b84c_32977f029908"></see></summary>
    let EMMO_68a031ba_abf5_4859_b84c_32977f029908 =
        Namespaced_IRI.parse _namespace_name "EMMO_68a031ba_abf5_4859_b84c_32977f029908" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e6.
    /// <see href="https://w3id.org/emmo#EMMO_85ee9154_5a3e_482e_aa37_c617ff1947ff"></see></summary>
    let EMMO_85ee9154_5a3e_482e_aa37_c617ff1947ff =
        Namespaced_IRI.parse _namespace_name "EMMO_85ee9154_5a3e_482e_aa37_c617ff1947ff" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e27.
    /// <see href="https://w3id.org/emmo#EMMO_aef1144d_41bd_4189_be5c_d849204b3708"></see></summary>
    let EMMO_aef1144d_41bd_4189_be5c_d849204b3708 =
        Namespaced_IRI.parse _namespace_name "EMMO_aef1144d_41bd_4189_be5c_d849204b3708" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e24.
    /// <see href="https://w3id.org/emmo#EMMO_cb3f4298_5895_4272_be63_42dd246cc10c"></see></summary>
    let EMMO_cb3f4298_5895_4272_be63_42dd246cc10c =
        Namespaced_IRI.parse _namespace_name "EMMO_cb3f4298_5895_4272_be63_42dd246cc10c" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e15.
    /// <see href="https://w3id.org/emmo#EMMO_d7c74480_a568_4470_acff_f18b499cc850"></see></summary>
    let EMMO_d7c74480_a568_4470_acff_f18b499cc850 =
        Namespaced_IRI.parse _namespace_name "EMMO_d7c74480_a568_4470_acff_f18b499cc850" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e30.
    /// <see href="https://w3id.org/emmo#EMMO_dabcbe7d_db82_4445_889b_ae4d76964ea0"></see></summary>
    let EMMO_dabcbe7d_db82_4445_889b_ae4d76964ea0 =
        Namespaced_IRI.parse _namespace_name "EMMO_dabcbe7d_db82_4445_889b_ae4d76964ea0" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e21.
    /// <see href="https://w3id.org/emmo#EMMO_fbf7da6f_04bb_4c8e_abbf_e4048d6a5e73"></see></summary>
    let EMMO_fbf7da6f_04bb_4c8e_abbf_e4048d6a5e73 =
        Namespaced_IRI.parse _namespace_name "EMMO_fbf7da6f_04bb_4c8e_abbf_e4048d6a5e73" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "femto" (1e-15).
    /// <see href="https://w3id.org/emmo#EMMO_23bfe79a_cade_48f1_9a8c_fd96e6bac8ba"></see></summary>
    let EMMO_23bfe79a_cade_48f1_9a8c_fd96e6bac8ba =
        Namespaced_IRI.parse _namespace_name "EMMO_23bfe79a_cade_48f1_9a8c_fd96e6bac8ba" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-15.
    /// <see href="https://w3id.org/emmo#EMMO_7fd8ec39_1c4b_4ff3_9bc8_0bf3c27e2db0"></see></summary>
    let EMMO_7fd8ec39_1c4b_4ff3_9bc8_0bf3c27e2db0 =
        Namespaced_IRI.parse _namespace_name "EMMO_7fd8ec39_1c4b_4ff3_9bc8_0bf3c27e2db0" |> NamespacedName

    /// <summary>
    /// Metric prefix defined in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_23eabdb5_6de6_4615_b6b1_a07b3ad32fd9"></see></summary>
    let EMMO_23eabdb5_6de6_4615_b6b1_a07b3ad32fd9 =
        Namespaced_IRI.parse _namespace_name "EMMO_23eabdb5_6de6_4615_b6b1_a07b3ad32fd9" |> NamespacedName

    /// <summary>
    /// Dimensionless multiplicative unit prefix.
    /// <see href="https://w3id.org/emmo#EMMO_442bd91e_a724_4e9f_89c1_18423016fb75"></see></summary>
    let EMMO_442bd91e_a724_4e9f_89c1_18423016fb75 =
        Namespaced_IRI.parse _namespace_name "EMMO_442bd91e_a724_4e9f_89c1_18423016fb75" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1/N where N is a positive integer larger than 1.
    /// <see href="https://w3id.org/emmo#EMMO_48fc9480_78c3_4c81_a126_019df20d58d9"></see></summary>
    let EMMO_48fc9480_78c3_4c81_a126_019df20d58d9 =
        Namespaced_IRI.parse _namespace_name "EMMO_48fc9480_78c3_4c81_a126_019df20d58d9" |> NamespacedName

    /// <summary>
    /// Differential quotient of N with respect to a, where N is the number of particles incident on a sphere of cross-sectional area a.
    /// <see href="https://w3id.org/emmo#EMMO_246af1cb_2f80_4ff7_9add_c1dd4cfdcc93"></see></summary>
    let EMMO_246af1cb_2f80_4ff7_9add_c1dd4cfdcc93 =
        Namespaced_IRI.parse _namespace_name "EMMO_246af1cb_2f80_4ff7_9add_c1dd4cfdcc93" |> NamespacedName

    /// <summary>
    /// A participant that is the driver of the process.
    /// An agent is not necessarily human.
    /// An agent plays an active role within the process.
    /// An agent is a participant of a process that would not occur without it.
    /// <see href="https://w3id.org/emmo#EMMO_2480b72b_db8d_460f_9a5f_c2912f979046"></see></summary>
    let EMMO_2480b72b_db8d_460f_9a5f_c2912f979046 =
        Namespaced_IRI.parse _namespace_name "EMMO_2480b72b_db8d_460f_9a5f_c2912f979046" |> NamespacedName

    /// <summary>
    /// A real matrix with shape 4x3.
    /// <see href="https://w3id.org/emmo#EMMO_24b30ba4_90f4_423d_93d2_fd0fde349087"></see></summary>
    let EMMO_24b30ba4_90f4_423d_93d2_fd0fde349087 =
        Namespaced_IRI.parse _namespace_name "EMMO_24b30ba4_90f4_423d_93d2_fd0fde349087" |> NamespacedName

    /// <summary>
    /// Internal energy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_24c44d2c_9ec3_438d_8cff_348cb9d7cb5c"></see></summary>
    let EMMO_24c44d2c_9ec3_438d_8cff_348cb9d7cb5c =
        Namespaced_IRI.parse _namespace_name "EMMO_24c44d2c_9ec3_438d_8cff_348cb9d7cb5c" |> NamespacedName

    /// <summary>
    /// Energy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_f675294e_6f30_4b1d_a68e_a74e59f3b2fc"></see></summary>
    let EMMO_f675294e_6f30_4b1d_a68e_a74e59f3b2fc =
        Namespaced_IRI.parse _namespace_name "EMMO_f675294e_6f30_4b1d_a68e_a74e59f3b2fc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_24c71baf_6db6_48b9_86c8_8c70cf36db0c"></see>
    /// </summary>
    let EMMO_24c71baf_6db6_48b9_86c8_8c70cf36db0c =
        Namespaced_IRI.parse _namespace_name "EMMO_24c71baf_6db6_48b9_86c8_8c70cf36db0c" |> NamespacedName

    /// <summary>
    /// A semiotic relation that connects a recognised semiotic object to an icon in a cognition process.
    /// <see href="https://w3id.org/emmo#EMMO_39c3815d_8cae_4c8f_b2ff_eeba24bec455"></see></summary>
    let EMMO_39c3815d_8cae_4c8f_b2ff_eeba24bec455 =
        Namespaced_IRI.parse _namespace_name "EMMO_39c3815d_8cae_4c8f_b2ff_eeba24bec455" |> NamespacedName

    /// <summary>
    /// Subatomic particle which contains an odd number of valence quarks, at least 3.
    /// <see href="https://w3id.org/emmo#EMMO_24dda193_ada8_433b_bb74_6ca4a0b89a20"></see></summary>
    let EMMO_24dda193_ada8_433b_bb74_6ca4a0b89a20 =
        Namespaced_IRI.parse _namespace_name "EMMO_24dda193_ada8_433b_bb74_6ca4a0b89a20" |> NamespacedName

    /// <summary>
    /// An elementary fermionic particle that is the fundamental constituent of matter.
    /// <see href="https://w3id.org/emmo#EMMO_99a8eece_40bf_4f26_832c_f290ca664767"></see></summary>
    let EMMO_99a8eece_40bf_4f26_832c_f290ca664767 =
        Namespaced_IRI.parse _namespace_name "EMMO_99a8eece_40bf_4f26_832c_f290ca664767" |> NamespacedName

    /// <summary>
    /// A non-elementary particle (bonded) of a fundamental fermionic type (half-integer spin).
    /// <see href="https://w3id.org/emmo#EMMO_29108c7c_9087_4992_ab1c_02561665df21"></see></summary>
    let EMMO_29108c7c_9087_4992_ab1c_02561665df21 =
        Namespaced_IRI.parse _namespace_name "EMMO_29108c7c_9087_4992_ab1c_02561665df21" |> NamespacedName

    /// <summary>
    /// Atom subclass for neon.
    /// <see href="https://w3id.org/emmo#EMMO_24e7961c-26c8-5ae1-a29c-c32717c40684"></see></summary>
    let ``EMMO_24e7961c-26c8-5ae1-a29c-c32717c40684`` =
        Namespaced_IRI.parse _namespace_name "EMMO_24e7961c-26c8-5ae1-a29c-c32717c40684" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the neon atom.
    /// <see href="https://w3id.org/emmo#EMMO_2e96348b-f8d1-5877-a5c5-b6863c5ebcf2"></see></summary>
    let ``EMMO_2e96348b-f8d1-5877-a5c5-b6863c5ebcf2`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2e96348b-f8d1-5877-a5c5-b6863c5ebcf2" |> NamespacedName

    /// <summary>
    /// A coded conventional that cannot be univocally determined and depends on an agent (e.g. a human individual, a community) acting as black-box.
    /// The word subjective applies to property intrisically subjective or non-well defined. In general, when an black-box-like procedure is used for the definition of the property.
    ///
    /// This happens due to e.g. the complexity of the object, the lack of a underlying model for the representation of the object, the non-well specified meaning of the property symbols.
    ///
    /// A 'SubjectiveProperty' cannot be used to univocally compare 'Object'-s.
    ///
    /// e.g. you cannot evaluate the beauty of a person on objective basis.
    /// <see href="https://w3id.org/emmo#EMMO_251cfb4f_5c75_4778_91ed_6c8395212fd8"></see></summary>
    let EMMO_251cfb4f_5c75_4778_91ed_6c8395212fd8 =
        Namespaced_IRI.parse _namespace_name "EMMO_251cfb4f_5c75_4778_91ed_6c8395212fd8" |> NamespacedName

    /// <summary>
    /// Atom subclass for nitrogen.
    /// <see href="https://w3id.org/emmo#EMMO_252f143a-2c00-5d9a-a551-c07daa22c5c0"></see></summary>
    let ``EMMO_252f143a-2c00-5d9a-a551-c07daa22c5c0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_252f143a-2c00-5d9a-a551-c07daa22c5c0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the nitrogen atom.
    /// <see href="https://w3id.org/emmo#EMMO_26b7c6ca-6c6c-52e0-ba01-dcc883e64d46"></see></summary>
    let ``EMMO_26b7c6ca-6c6c-52e0-ba01-dcc883e64d46`` =
        Namespaced_IRI.parse _namespace_name "EMMO_26b7c6ca-6c6c-52e0-ba01-dcc883e64d46" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "zepto" (1e-21).
    /// <see href="https://w3id.org/emmo#EMMO_254472c6_3dbd_4f02_bc43_571389cd281f"></see></summary>
    let EMMO_254472c6_3dbd_4f02_bc43_571389cd281f =
        Namespaced_IRI.parse _namespace_name "EMMO_254472c6_3dbd_4f02_bc43_571389cd281f" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-21.
    /// <see href="https://w3id.org/emmo#EMMO_4db5c662_b065_49e4_96eb_826699fa8048"></see></summary>
    let EMMO_4db5c662_b065_49e4_96eb_826699fa8048 =
        Namespaced_IRI.parse _namespace_name "EMMO_4db5c662_b065_49e4_96eb_826699fa8048" |> NamespacedName

    /// <summary>
    /// For substance X in a liquid or a solid mixture; quotient of absolute activity of substance X and the product of absolute activity of the pure substance X at the same temperature and pressure and amount-of-substance fraction of substance X.
    /// Activity factors can also be obtained applying Raoult's law or Henry's law.
    /// <see href="https://w3id.org/emmo#EMMO_254ff869_7d28_42dd_aedc_adb4cc8ad0cb"></see></summary>
    let EMMO_254ff869_7d28_42dd_aedc_adb4cc8ad0cb =
        Namespaced_IRI.parse _namespace_name "EMMO_254ff869_7d28_42dd_aedc_adb4cc8ad0cb" |> NamespacedName

    /// <summary>
    /// A coefficient in thermodynamics used to account for deviation of a mixture of chemical substances from ideal behaviour.
    /// <see href="https://w3id.org/emmo#EMMO_3434b127_1820_43a7_9e13_b96f25e66ee8"></see></summary>
    let EMMO_3434b127_1820_43a7_9e13_b96f25e66ee8 =
        Namespaced_IRI.parse _namespace_name "EMMO_3434b127_1820_43a7_9e13_b96f25e66ee8" |> NamespacedName

    /// <summary>
    /// An object which is an holistic temporal part of another object.
    /// Here we consider a temporal interval that is lower than the characteristic time of the physical process that provides the causality connection between the object parts.
    /// <see href="https://w3id.org/emmo#EMMO_2553c342_fc28_47d8_8e19_7a98fa08f150"></see></summary>
    let EMMO_2553c342_fc28_47d8_8e19_7a98fa08f150 =
        Namespaced_IRI.parse _namespace_name "EMMO_2553c342_fc28_47d8_8e19_7a98fa08f150" |> NamespacedName

    /// <summary>
    /// For charged particles of a given type and energy E0 the differential quotient of E with respect to x, where E is the mean energy lost by the charged particles in traversing a distance x in the given material.
    /// <see href="https://w3id.org/emmo#EMMO_2558579d_fd7e_4c15_8ad4_2050ca0acc5e"></see></summary>
    let EMMO_2558579d_fd7e_4c15_8ad4_2050ca0acc5e =
        Namespaced_IRI.parse _namespace_name "EMMO_2558579d_fd7e_4c15_8ad4_2050ca0acc5e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2565210a_bbcc_4c00_a122_6a608faa355b"></see>
    /// </summary>
    let EMMO_2565210a_bbcc_4c00_a122_6a608faa355b =
        Namespaced_IRI.parse _namespace_name "EMMO_2565210a_bbcc_4c00_a122_6a608faa355b" |> NamespacedName

    /// <summary>
    /// A network of objects that implements a production process through a series of interconnected elements.
    /// <see href="https://w3id.org/emmo#EMMO_256bb4be_78c6_4f2f_8589_f5e4c8339bbd"></see></summary>
    let EMMO_256bb4be_78c6_4f2f_8589_f5e4c8339bbd =
        Namespaced_IRI.parse _namespace_name "EMMO_256bb4be_78c6_4f2f_8589_f5e4c8339bbd" |> NamespacedName

    /// <summary>
    /// Natural logarithm of the quotient of a reference energy and the kinetic energy of a neutron.
    /// <see href="https://w3id.org/emmo#EMMO_25e8c0c4_943a_4851_9cb7_3c4b45f69bb5"></see></summary>
    let EMMO_25e8c0c4_943a_4851_9cb7_3c4b45f69bb5 =
        Namespaced_IRI.parse _namespace_name "EMMO_25e8c0c4_943a_4851_9cb7_3c4b45f69bb5" |> NamespacedName

    /// <summary>
    /// A 2-manifold with two unconnected boundaries.
    /// <see href="https://w3id.org/emmo#EMMO_25f5ca8e_8f7f_44d8_a392_bd3fe8894458"></see></summary>
    let EMMO_25f5ca8e_8f7f_44d8_a392_bd3fe8894458 =
        Namespaced_IRI.parse _namespace_name "EMMO_25f5ca8e_8f7f_44d8_a392_bd3fe8894458" |> NamespacedName

    /// <summary>
    /// A topological space with the property that each point has a neighborhood that is homeomorphic to an open subset of 2-dimensional Euclidean space.
    /// <see href="https://w3id.org/emmo#EMMO_9268958f_7f54_48ab_a693_febe2645892b"></see></summary>
    let EMMO_9268958f_7f54_48ab_a693_febe2645892b =
        Namespaced_IRI.parse _namespace_name "EMMO_9268958f_7f54_48ab_a693_febe2645892b" |> NamespacedName

    /// <summary>
    /// Sum of the kinetic energy of the α-particle produced in the disintegration process and the recoil energy of the product atom in a reference frame in which the emitting nucleus is at rest before its disintegration.
    /// <see href="https://w3id.org/emmo#EMMO_260dfba7_f7ab_4e5d_99e5_137600778220"></see></summary>
    let EMMO_260dfba7_f7ab_4e5d_99e5_137600778220 =
        Namespaced_IRI.parse _namespace_name "EMMO_260dfba7_f7ab_4e5d_99e5_137600778220" |> NamespacedName

    /// <summary>
    /// Internal energy minus the product of thermodynamic temperature and entropy.
    /// <see href="https://w3id.org/emmo#EMMO_262d4582_15b9_4685_b693_24f8e9ead98d"></see></summary>
    let EMMO_262d4582_15b9_4685_b693_24f8e9ead98d =
        Namespaced_IRI.parse _namespace_name "EMMO_262d4582_15b9_4685_b693_24f8e9ead98d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_263d9161_5a7c_4900_a49b_55f012b3fe07"></see>
    /// </summary>
    let EMMO_263d9161_5a7c_4900_a49b_55f012b3fe07 =
        Namespaced_IRI.parse _namespace_name "EMMO_263d9161_5a7c_4900_a49b_55f012b3fe07" |> NamespacedName

    /// <summary>
    /// A chemical numenclature should not be confused with the chemical formula.
    /// A language object following a specific nomenclature rules for defining univocal names of chemical compounds.
    /// <see href="https://w3id.org/emmo#EMMO_643d99dd_fae6_4121_a76f_47f486a4480b"></see></summary>
    let EMMO_643d99dd_fae6_4121_a76f_47f486a4480b =
        Namespaced_IRI.parse _namespace_name "EMMO_643d99dd_fae6_4121_a76f_47f486a4480b" |> NamespacedName

    /// <summary>
    /// A step that is a temporal tile of a workflow.
    /// <see href="https://w3id.org/emmo#EMMO_2666a7e3_2ad4_49a0_899e_329607231f4b"></see></summary>
    let EMMO_2666a7e3_2ad4_49a0_899e_329607231f4b =
        Namespaced_IRI.parse _namespace_name "EMMO_2666a7e3_2ad4_49a0_899e_329607231f4b" |> NamespacedName

    /// <summary>
    /// A direct part that is obtained by partitioning a whole purely in temporal parts.
    /// <see href="https://w3id.org/emmo#EMMO_504ad89e_dd4a_4fa6_aeb6_15c8ce0cde9b"></see></summary>
    let EMMO_504ad89e_dd4a_4fa6_aeb6_15c8ce0cde9b =
        Namespaced_IRI.parse _namespace_name "EMMO_504ad89e_dd4a_4fa6_aeb6_15c8ce0cde9b" |> NamespacedName

    /// <summary>
    /// A task that is a well formed tile of a workflow, according to a reductionistic description.
    /// A step is part of a specific granularity level for the workflow description, as composition of tasks.
    /// <see href="https://w3id.org/emmo#EMMO_9f6ec830_c59f_46aa_8a22_945ba20b6ea3"></see></summary>
    let EMMO_9f6ec830_c59f_46aa_8a22_945ba20b6ea3 =
        Namespaced_IRI.parse _namespace_name "EMMO_9f6ec830_c59f_46aa_8a22_945ba20b6ea3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_268a8a97_3a6f_4022_93da_962a66827cdc"></see>
    /// </summary>
    let EMMO_268a8a97_3a6f_4022_93da_962a66827cdc =
        Namespaced_IRI.parse _namespace_name "EMMO_268a8a97_3a6f_4022_93da_962a66827cdc" |> NamespacedName

    /// <summary>
    /// Charge number that an atom within a molecule would have if all the ligands were removed along with the electron pairs that were shared.
    /// <see href="https://w3id.org/emmo#EMMO_26922e28_b266_46c1_b93e_4940633ba5e4"></see></summary>
    let EMMO_26922e28_b266_46c1_b93e_4940633ba5e4 =
        Namespaced_IRI.parse _namespace_name "EMMO_26922e28_b266_46c1_b93e_4940633ba5e4" |> NamespacedName

    /// <summary>
    /// The charge number of a particle may be presented as a superscript to the symbol of that particle, e.g. H+, He++, Al3+, Cl−, S=, N3−.
    /// The charge number of an electrically charged particle can be positive or negative. The charge number of an electrically neutral particle is zero.
    /// For a particle, electric charge q divided by elementary charge e.
    /// <see href="https://w3id.org/emmo#EMMO_dc467621_3b49_4f31_9b09_82290f29da52"></see></summary>
    let EMMO_dc467621_3b49_4f31_9b09_82290f29da52 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc467621_3b49_4f31_9b09_82290f29da52" |> NamespacedName

    /// <summary>
    /// Geometrical characteristic of a shape of a body.
    /// <see href="https://w3id.org/emmo#EMMO_26b13395_0031_4da2_b4d0_55eca1792107"></see></summary>
    let EMMO_26b13395_0031_4da2_b4d0_55eca1792107 =
        Namespaced_IRI.parse _namespace_name "EMMO_26b13395_0031_4da2_b4d0_55eca1792107" |> NamespacedName

    /// <summary>
    /// time constant for scattering, trapping or annihilation of charge carriers, phonons or other quasiparticles
    /// <see href="https://w3id.org/emmo#EMMO_26c6f1b3_c33f_4804_a3e8_3c5c931582b3"></see></summary>
    let EMMO_26c6f1b3_c33f_4804_a3e8_3c5c931582b3 =
        Namespaced_IRI.parse _namespace_name "EMMO_26c6f1b3_c33f_4804_a3e8_3c5c931582b3" |> NamespacedName

    /// <summary>
    /// parameter characterizing the response to a step input of a first‑order, linear time‑invariant system
    /// <see href="https://w3id.org/emmo#EMMO_88967c93_894b_4e42_bc3c_c8517b255489"></see></summary>
    let EMMO_88967c93_894b_4e42_bc3c_c8517b255489 =
        Namespaced_IRI.parse _namespace_name "EMMO_88967c93_894b_4e42_bc3c_c8517b255489" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_26f34447_32ec_48ce_9baa_4afec09120f4"></see>
    /// </summary>
    let EMMO_26f34447_32ec_48ce_9baa_4afec09120f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_26f34447_32ec_48ce_9baa_4afec09120f4" |> NamespacedName

    /// <summary>
    /// The mass of an atom in the ground state.
    /// The atomic mass is often expressed as an average of the commonly found isotopes.
    /// Since the nucleus account for nearly all of the total mass of atoms  (with the electrons and nuclear binding energy making minor contributions), the atomic mass measured in Da has nearly the same value as the mass number.
    /// <see href="https://w3id.org/emmo#EMMO_27367073_ed8a_481a_9b07_f836dfe31f7f"></see></summary>
    let EMMO_27367073_ed8a_481a_9b07_f836dfe31f7f =
        Namespaced_IRI.parse _namespace_name "EMMO_27367073_ed8a_481a_9b07_f836dfe31f7f" |> NamespacedName

    /// <summary>
    /// Quotient of thermal conductivity and the product of mass density and specific heat capacity.
    /// <see href="https://w3id.org/emmo#EMMO_276f1224_fdc1_42ac_bd27_03d6dcec191a"></see></summary>
    let EMMO_276f1224_fdc1_42ac_bd27_03d6dcec191a =
        Namespaced_IRI.parse _namespace_name "EMMO_276f1224_fdc1_42ac_bd27_03d6dcec191a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreicSpeed'.
    /// <see href="https://w3id.org/emmo#EMMO_b33cc5b5_a9dc_4082_b497_14d1654c5591"></see></summary>
    let EMMO_b33cc5b5_a9dc_4082_b497_14d1654c5591 =
        Namespaced_IRI.parse _namespace_name "EMMO_b33cc5b5_a9dc_4082_b497_14d1654c5591" |> NamespacedName

    /// <summary>
    /// An 'equation' that stands for a 'physical_law' by mathematically defining the relations between physics_quantities.
    /// <see href="https://w3id.org/emmo#EMMO_27c5d8c6_8af7_4d63_beb1_ec37cd8b3fa3"></see></summary>
    let EMMO_27c5d8c6_8af7_4d63_beb1_ec37cd8b3fa3 =
        Namespaced_IRI.parse _namespace_name "EMMO_27c5d8c6_8af7_4d63_beb1_ec37cd8b3fa3" |> NamespacedName

    /// <summary>
    /// The class of 'mathematical'-s that stand for a statement of equality between two mathematical expressions.
    /// An equation with variables can always be represented as:
    ///
    /// f(v0, v1, ..., vn) = g(v0, v1, ..., vn)
    ///
    /// where f is the left hand and g the right hand  side expressions and v0, v1, ..., vn are the variables.
    /// <see href="https://w3id.org/emmo#EMMO_e56ee3eb_7609_4ae1_8bed_51974f0960a6"></see></summary>
    let EMMO_e56ee3eb_7609_4ae1_8bed_51974f0960a6 =
        Namespaced_IRI.parse _namespace_name "EMMO_e56ee3eb_7609_4ae1_8bed_51974f0960a6" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaPerQuarticTime'.
    /// <see href="https://w3id.org/emmo#EMMO_27c8e4db_eb18_402c_951e_6a38751cf1d0"></see></summary>
    let EMMO_27c8e4db_eb18_402c_951e_6a38751cf1d0 =
        Namespaced_IRI.parse _namespace_name "EMMO_27c8e4db_eb18_402c_951e_6a38751cf1d0" |> NamespacedName

    /// <summary>
    /// The InChiKey is a hash of the full InChi identifier using the SHA-256 algorithm, designed to allow for easy web searches of chemical compounds.
    /// A hash of the full International Chemical Identifier (InChi) for a chemical substance.
    /// <see href="https://w3id.org/emmo#EMMO_2856bbc2_96e1_485b_b5f8_2fdfcb0c9b92"></see></summary>
    let EMMO_2856bbc2_96e1_485b_b5f8_2fdfcb0c9b92 =
        Namespaced_IRI.parse _namespace_name "EMMO_2856bbc2_96e1_485b_b5f8_2fdfcb0c9b92" |> NamespacedName

    /// <summary>
    /// A physical particle with half odd integer spin (1/2, 3/2, etc...) that follows Fermi-Dirac statistics.
    /// <see href="https://w3id.org/emmo#EMMO_53dced52_34f6_4cf0_8a99_ddf451861543"></see></summary>
    let EMMO_53dced52_34f6_4cf0_8a99_ddf451861543 =
        Namespaced_IRI.parse _namespace_name "EMMO_53dced52_34f6_4cf0_8a99_ddf451861543" |> NamespacedName

    /// <summary>
    /// Atom subclass for francium.
    /// <see href="https://w3id.org/emmo#EMMO_291a1550-d4cb-5934-b0db-0ea3c6a23932"></see></summary>
    let ``EMMO_291a1550-d4cb-5934-b0db-0ea3c6a23932`` =
        Namespaced_IRI.parse _namespace_name "EMMO_291a1550-d4cb-5934-b0db-0ea3c6a23932" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the francium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c3a05192-7d78-5190-bc3e-3ea44cfc9d19"></see></summary>
    let ``EMMO_c3a05192-7d78-5190-bc3e-3ea44cfc9d19`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c3a05192-7d78-5190-bc3e-3ea44cfc9d19" |> NamespacedName

    /// <summary>
    /// A construction language used to make queries in databases and information systems.
    /// <see href="https://w3id.org/emmo#EMMO_29791c75_2899_47a8_bfad_fc239aa4dd2d"></see></summary>
    let EMMO_29791c75_2899_47a8_bfad_fc239aa4dd2d =
        Namespaced_IRI.parse _namespace_name "EMMO_29791c75_2899_47a8_bfad_fc239aa4dd2d" |> NamespacedName

    /// <summary>
    /// A computer language by which a human can specify an executable problem solution to a computer.
    /// <see href="https://w3id.org/emmo#EMMO_3ab914c1_5d8d_4a6e_804b_84aa89623c48"></see></summary>
    let EMMO_3ab914c1_5d8d_4a6e_804b_84aa89623c48 =
        Namespaced_IRI.parse _namespace_name "EMMO_3ab914c1_5d8d_4a6e_804b_84aa89623c48" |> NamespacedName

    /// <summary>
    /// A semiotic relation that connects a deduced semiotic object to an indexin a deduction process.
    /// <see href="https://w3id.org/emmo#EMMO_297999d6_c9e4_4262_9536_bd524d1c6e21"></see></summary>
    let EMMO_297999d6_c9e4_4262_9536_bd524d1c6e21 =
        Namespaced_IRI.parse _namespace_name "EMMO_297999d6_c9e4_4262_9536_bd524d1c6e21" |> NamespacedName

    /// <summary>
    /// Atom subclass for protactinium.
    /// <see href="https://w3id.org/emmo#EMMO_29987c5a-a7fb-5207-9610-b94316977a3d"></see></summary>
    let ``EMMO_29987c5a-a7fb-5207-9610-b94316977a3d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_29987c5a-a7fb-5207-9610-b94316977a3d" |> NamespacedName

    /// <summary>
    /// An equation that define a new variable in terms of other mathematical entities.
    /// <see href="https://w3id.org/emmo#EMMO_29afdf54_90ae_4c98_8845_fa9ea3f143a8"></see></summary>
    let EMMO_29afdf54_90ae_4c98_8845_fa9ea3f143a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_29afdf54_90ae_4c98_8845_fa9ea3f143a8" |> NamespacedName

    /// <summary>
    /// The ratio of the binding energy of a nucleus to the atomic mass number.
    /// <see href="https://w3id.org/emmo#EMMO_29edd972_2e77_4658_8106_01c86b3b10a2"></see></summary>
    let EMMO_29edd972_2e77_4658_8106_01c86b3b10a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_29edd972_2e77_4658_8106_01c86b3b10a2" |> NamespacedName

    /// <summary>
    /// Angular measure between the positive real axis and the radius of the polar representation of the complex number in the complex plane.
    /// <see href="https://w3id.org/emmo#EMMO_2a0e5777_348c_475b_adf0_1b1e71a29bc9"></see></summary>
    let EMMO_2a0e5777_348c_475b_adf0_1b1e71a29bc9 =
        Namespaced_IRI.parse _namespace_name "EMMO_2a0e5777_348c_475b_adf0_1b1e71a29bc9" |> NamespacedName

    /// <summary>
    /// Atom subclass for chromium.
    /// <see href="https://w3id.org/emmo#EMMO_2a61986e-772c-5f68-bdc9-80adbc618e41"></see></summary>
    let ``EMMO_2a61986e-772c-5f68-bdc9-80adbc618e41`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2a61986e-772c-5f68-bdc9-80adbc618e41" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the chromium atom.
    /// <see href="https://w3id.org/emmo#EMMO_517752af-5883-5cf5-8363-6b19f76aca3e"></see></summary>
    let ``EMMO_517752af-5883-5cf5-8363-6b19f76aca3e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_517752af-5883-5cf5-8363-6b19f76aca3e" |> NamespacedName

    /// <summary>
    /// The derivative of the electric charge of a system with respect to the area.
    /// <see href="https://w3id.org/emmo#EMMO_2a67f539_d503_4e98_934e_50d4a9ae6cfd"></see></summary>
    let EMMO_2a67f539_d503_4e98_934e_50d4a9ae6cfd =
        Namespaced_IRI.parse _namespace_name "EMMO_2a67f539_d503_4e98_934e_50d4a9ae6cfd" |> NamespacedName

    /// <summary>
    /// Vector quantity obtained at a given point by adding the electric polarization P to the product of the electric field strength E and the electric constant ε0.
    /// <see href="https://w3id.org/emmo#EMMO_4ef8c0e4_1b0b_4699_a135_8c89ca289802"></see></summary>
    let EMMO_4ef8c0e4_1b0b_4699_a135_8c89ca289802 =
        Namespaced_IRI.parse _namespace_name "EMMO_4ef8c0e4_1b0b_4699_a135_8c89ca289802" |> NamespacedName

    /// <summary>
    /// Partition function of a molecule.
    /// <see href="https://w3id.org/emmo#EMMO_2a971203_58d5_4039_98ce_be7eafb2b14f"></see></summary>
    let EMMO_2a971203_58d5_4039_98ce_be7eafb2b14f =
        Namespaced_IRI.parse _namespace_name "EMMO_2a971203_58d5_4039_98ce_be7eafb2b14f" |> NamespacedName

    /// <summary>
    /// The exponential of the ratio of the chemical potential to R*T where R is the gas constant and T the thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_2ae37adf_07f2_4920_8ec6_084c69761e34"></see></summary>
    let EMMO_2ae37adf_07f2_4920_8ec6_084c69761e34 =
        Namespaced_IRI.parse _namespace_name "EMMO_2ae37adf_07f2_4920_8ec6_084c69761e34" |> NamespacedName

    /// <summary>
    /// Quotient of electron and hole mobility.
    /// <see href="https://w3id.org/emmo#EMMO_2b0a1578_ae70_4cd1_940d_54d9c220d8f7"></see></summary>
    let EMMO_2b0a1578_ae70_4cd1_940d_54d9c220d8f7 =
        Namespaced_IRI.parse _namespace_name "EMMO_2b0a1578_ae70_4cd1_940d_54d9c220d8f7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2b1303e8_d4c3_453b_9918_76f1d009543f"></see>
    /// </summary>
    let EMMO_2b1303e8_d4c3_453b_9918_76f1d009543f =
        Namespaced_IRI.parse _namespace_name "EMMO_2b1303e8_d4c3_453b_9918_76f1d009543f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_707f0cd1_941c_4b57_9f20_d0ba30cd6ff3"></see>
    /// </summary>
    let EMMO_707f0cd1_941c_4b57_9f20_d0ba30cd6ff3 =
        Namespaced_IRI.parse _namespace_name "EMMO_707f0cd1_941c_4b57_9f20_d0ba30cd6ff3" |> NamespacedName

    /// <summary>
    /// A well formed tessellation with at least a junction tile.
    /// <see href="https://w3id.org/emmo#EMMO_2b1fb71c_0eb0_445c_9be7_fb5d30ae79fd"></see></summary>
    let EMMO_2b1fb71c_0eb0_445c_9be7_fb5d30ae79fd =
        Namespaced_IRI.parse _namespace_name "EMMO_2b1fb71c_0eb0_445c_9be7_fb5d30ae79fd" |> NamespacedName

    /// <summary>
    /// A direct part that is obtained by partitioning a whole hybridly in spatial, temporal and spatiotemporal parts.
    /// <see href="https://w3id.org/emmo#EMMO_d4c95fa1_5bda_4063_a22d_62c81fcea284"></see></summary>
    let EMMO_d4c95fa1_5bda_4063_a22d_62c81fcea284 =
        Namespaced_IRI.parse _namespace_name "EMMO_d4c95fa1_5bda_4063_a22d_62c81fcea284" |> NamespacedName

    /// <summary>
    /// The relation grouping all direct parthood relations used in the reductionistic perspective.
    /// Direct parthood is the non transitive version of parthood enabling the establishment of hierarchy of granularities, starting with an entity and providing several tesselation levels according to specific criteria.
    /// The criteria are implemented in specialised versions of the direct parthood relation (e.g., metrological direct part, XML format direct part).
    /// The direct parts (tiles) and the tessellated entity (tessellation) are causally self connected (i.e., items), coherently with the concept behind the definition of the reductionistic perspective.
    /// This relation is not antitransitive, to enable partitioning of a causal structure with more than one tiling scheme (e.g. time and space partitioning).
    /// <see href="https://w3id.org/emmo#EMMO_74a75cf1_3418_4244_b43c_b5db94635d42"></see></summary>
    let EMMO_74a75cf1_3418_4244_b43c_b5db94635d42 =
        Namespaced_IRI.parse _namespace_name "EMMO_74a75cf1_3418_4244_b43c_b5db94635d42" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_fc86c700_ccea_441c_b628_ad236f030fe6"></see>
    /// </summary>
    let EMMO_fc86c700_ccea_441c_b628_ad236f030fe6 =
        Namespaced_IRI.parse _namespace_name "EMMO_fc86c700_ccea_441c_b628_ad236f030fe6" |> NamespacedName

    /// <summary>
    /// For a sinusoidal wave at a given point, velocity in the direction of propagation of the wavefront corresponding to a specified phase.
    /// <see href="https://w3id.org/emmo#EMMO_2b69b940_a4ab_40dc_b565_8daab23e4df2"></see></summary>
    let EMMO_2b69b940_a4ab_40dc_b565_8daab23e4df2 =
        Namespaced_IRI.parse _namespace_name "EMMO_2b69b940_a4ab_40dc_b565_8daab23e4df2" |> NamespacedName

    /// <summary>
    /// Atom subclass for calcium.
    /// <see href="https://w3id.org/emmo#EMMO_2b6dcba2-8e5f-50fb-8242-26fa609379a8"></see></summary>
    let ``EMMO_2b6dcba2-8e5f-50fb-8242-26fa609379a8`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2b6dcba2-8e5f-50fb-8242-26fa609379a8" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the calcium atom.
    /// <see href="https://w3id.org/emmo#EMMO_38626021-30ac-5bd1-8776-0541a8341bf2"></see></summary>
    let ``EMMO_38626021-30ac-5bd1-8776-0541a8341bf2`` =
        Namespaced_IRI.parse _namespace_name "EMMO_38626021-30ac-5bd1-8776-0541a8341bf2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2bb50428_568d_46e8_b8bf_59a4c5656461"></see>
    /// </summary>
    let EMMO_2bb50428_568d_46e8_b8bf_59a4c5656461 =
        Namespaced_IRI.parse _namespace_name "EMMO_2bb50428_568d_46e8_b8bf_59a4c5656461" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2bf617c6_e57b_430b_9f37_fcf2cfda719e"></see>
    /// </summary>
    let EMMO_2bf617c6_e57b_430b_9f37_fcf2cfda719e =
        Namespaced_IRI.parse _namespace_name "EMMO_2bf617c6_e57b_430b_9f37_fcf2cfda719e" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerLengthTime'.
    /// <see href="https://w3id.org/emmo#EMMO_2c224eb4_cb86_44a4_a067_8969ead598d7"></see></summary>
    let EMMO_2c224eb4_cb86_44a4_a067_8969ead598d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_2c224eb4_cb86_44a4_a067_8969ead598d7" |> NamespacedName

    /// <summary>
    /// Quotient of the magnetic dipole moment of an atom, and the product of the total angular momentum quantum number and the Bohr magneton.
    /// <see href="https://w3id.org/emmo#EMMO_2c33f59a_fbeb_445e_aea9_8b05738b5f8b"></see></summary>
    let EMMO_2c33f59a_fbeb_445e_aea9_8b05738b5f8b =
        Namespaced_IRI.parse _namespace_name "EMMO_2c33f59a_fbeb_445e_aea9_8b05738b5f8b" |> NamespacedName

    /// <summary>
    /// Atom subclass for manganese.
    /// <see href="https://w3id.org/emmo#EMMO_2c701f72-a859-5e33-9552-b6bdbcbd28d9"></see></summary>
    let ``EMMO_2c701f72-a859-5e33-9552-b6bdbcbd28d9`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2c701f72-a859-5e33-9552-b6bdbcbd28d9" |> NamespacedName

    /// <summary>
    /// Atom subclass for helium.
    /// <see href="https://w3id.org/emmo#EMMO_2c85ff7a-835c-5559-b369-193683d631c8"></see></summary>
    let ``EMMO_2c85ff7a-835c-5559-b369-193683d631c8`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2c85ff7a-835c-5559-b369-193683d631c8" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the helium atom.
    /// <see href="https://w3id.org/emmo#EMMO_fad04773-08a7-5bd3-8990-06d7e9d2c21e"></see></summary>
    let ``EMMO_fad04773-08a7-5bd3-8990-06d7e9d2c21e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fad04773-08a7-5bd3-8990-06d7e9d2c21e" |> NamespacedName

    /// <summary>
    /// Average power over a period.
    /// <see href="https://w3id.org/emmo#EMMO_2c9f993c_5b30_40a5_a471_808f7eb719db"></see></summary>
    let EMMO_2c9f993c_5b30_40a5_a471_808f7eb719db =
        Namespaced_IRI.parse _namespace_name "EMMO_2c9f993c_5b30_40a5_a471_808f7eb719db" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2ce04004_62cf_4394_b6a2_b45fce1aebfe"></see>
    /// </summary>
    let EMMO_2ce04004_62cf_4394_b6a2_b45fce1aebfe =
        Namespaced_IRI.parse _namespace_name "EMMO_2ce04004_62cf_4394_b6a2_b45fce1aebfe" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerMassPressure'.
    /// <see href="https://w3id.org/emmo#EMMO_2d66cf6d_9396_40c8_bb82_324ab19067ce"></see></summary>
    let EMMO_2d66cf6d_9396_40c8_bb82_324ab19067ce =
        Namespaced_IRI.parse _namespace_name "EMMO_2d66cf6d_9396_40c8_bb82_324ab19067ce" |> NamespacedName

    /// <summary>
    /// An interpreter who assigns a name to an object without any motivations related to the object characters.
    /// <see href="https://w3id.org/emmo#EMMO_421167c0_1ea5_405f_970f_a41e9cb308f9"></see></summary>
    let EMMO_421167c0_1ea5_405f_970f_a41e9cb308f9 =
        Namespaced_IRI.parse _namespace_name "EMMO_421167c0_1ea5_405f_970f_a41e9cb308f9" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Acceleration'.
    /// <see href="https://w3id.org/emmo#EMMO_2da7408f_d389_4245_887d_a1743b81a9b6"></see></summary>
    let EMMO_2da7408f_d389_4245_887d_a1743b81a9b6 =
        Namespaced_IRI.parse _namespace_name "EMMO_2da7408f_d389_4245_887d_a1743b81a9b6" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the chlorine atom.
    /// <see href="https://w3id.org/emmo#EMMO_2dc17698-8cd9-562e-8eca-7818d507c813"></see></summary>
    let ``EMMO_2dc17698-8cd9-562e-8eca-7818d507c813`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2dc17698-8cd9-562e-8eca-7818d507c813" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of solid in a solid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_2dd512a1_5187_47cc_b0b8_141214e22b59"></see></summary>
    let EMMO_2dd512a1_5187_47cc_b0b8_141214e22b59 =
        Namespaced_IRI.parse _namespace_name "EMMO_2dd512a1_5187_47cc_b0b8_141214e22b59" |> NamespacedName

    /// <summary>
    /// OpenSMILE representation of a molecular structure.
    /// OpenSMILES is an open specification of the SMILE language for specifying molecular structures, which has become a defacto standard for exchange of molecular structures.
    /// <see href="https://w3id.org/emmo#EMMO_2e0b0f1b_ba90_4827_af5a_92b826cb90de"></see></summary>
    let EMMO_2e0b0f1b_ba90_4827_af5a_92b826cb90de =
        Namespaced_IRI.parse _namespace_name "EMMO_2e0b0f1b_ba90_4827_af5a_92b826cb90de" |> NamespacedName

    /// <summary>
    /// Ratio of the number of dissociated molecules of a specified type to the total number of dissolved molecules of this type.
    /// <see href="https://w3id.org/emmo#EMMO_2e19759a_b728_4a42_8a0c_5e6c57ea4811"></see></summary>
    let EMMO_2e19759a_b728_4a42_8a0c_5e6c57ea4811 =
        Namespaced_IRI.parse _namespace_name "EMMO_2e19759a_b728_4a42_8a0c_5e6c57ea4811" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountConcentration'.
    /// <see href="https://w3id.org/emmo#EMMO_e9348e5b_af4f_4898_bbfe_c4583cf44b80"></see></summary>
    let EMMO_e9348e5b_af4f_4898_bbfe_c4583cf44b80 =
        Namespaced_IRI.parse _namespace_name "EMMO_e9348e5b_af4f_4898_bbfe_c4583cf44b80" |> NamespacedName

    /// <summary>
    /// Atom subclass for einsteinium.
    /// <see href="https://w3id.org/emmo#EMMO_2e36028f-f5a0-5a5a-af66-c357fb64765e"></see></summary>
    let ``EMMO_2e36028f-f5a0-5a5a-af66-c357fb64765e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2e36028f-f5a0-5a5a-af66-c357fb64765e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the einsteinium atom.
    /// <see href="https://w3id.org/emmo#EMMO_6b241a1f-2a5f-5ea8-b0aa-7b162d7d73e4"></see></summary>
    let ``EMMO_6b241a1f-2a5f-5ea8-b0aa-7b162d7d73e4`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6b241a1f-2a5f-5ea8-b0aa-7b162d7d73e4" |> NamespacedName

    /// <summary>
    /// https://w3id.org/emmo#EMMO_22c91e99_61f8_4433_8853_432d44a2a46a
    /// <see href="https://w3id.org/emmo#EMMO_2e46d966_9f14_4673_821e_7c7cf2957926"></see></summary>
    let EMMO_2e46d966_9f14_4673_821e_7c7cf2957926 =
        Namespaced_IRI.parse _namespace_name "EMMO_2e46d966_9f14_4673_821e_7c7cf2957926" |> NamespacedName

    /// <summary>
    /// A direct part that is obtained by partitioning a whole purely in spatial parts.
    /// <see href="https://w3id.org/emmo#EMMO_4cf484af_082a_40f5_9f11_930bf4634482"></see></summary>
    let EMMO_4cf484af_082a_40f5_9f11_930bf4634482 =
        Namespaced_IRI.parse _namespace_name "EMMO_4cf484af_082a_40f5_9f11_930bf4634482" |> NamespacedName

    /// <summary>
    /// A tile that has next and is next of other tiles within the same tessellation.
    /// <see href="https://w3id.org/emmo#EMMO_caa63d00_80b1_4408_ac1b_cd0d23b0ec50"></see></summary>
    let EMMO_caa63d00_80b1_4408_ac1b_cd0d23b0ec50 =
        Namespaced_IRI.parse _namespace_name "EMMO_caa63d00_80b1_4408_ac1b_cd0d23b0ec50" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_edf72228_e040_4edc_8b46_78b2a47c72d7"></see>
    /// </summary>
    let EMMO_edf72228_e040_4edc_8b46_78b2a47c72d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_edf72228_e040_4edc_8b46_78b2a47c72d7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_fa595892_070d_455e_9459_06c97179c080"></see>
    /// </summary>
    let EMMO_fa595892_070d_455e_9459_06c97179c080 =
        Namespaced_IRI.parse _namespace_name "EMMO_fa595892_070d_455e_9459_06c97179c080" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_22c91e99_61f8_4433_8853_432d44a2a46a"></see>
    /// </summary>
    let EMMO_22c91e99_61f8_4433_8853_432d44a2a46a =
        Namespaced_IRI.parse _namespace_name "EMMO_22c91e99_61f8_4433_8853_432d44a2a46a" |> NamespacedName

    /// <summary>
    /// Number of neutrons in an atomic nucleus.
    /// Atomic number (proton number) plus neutron number equals mass number.
    /// <see href="https://w3id.org/emmo#EMMO_2e6c62da_2836_42c1_b2f9_dd801eef5992"></see></summary>
    let EMMO_2e6c62da_2836_42c1_b2f9_dd801eef5992 =
        Namespaced_IRI.parse _namespace_name "EMMO_2e6c62da_2836_42c1_b2f9_dd801eef5992" |> NamespacedName

    /// <summary>
    /// Atom subclass for neodymium.
    /// <see href="https://w3id.org/emmo#EMMO_2e6eba5e-8c55-534c-b955-f09296e190e0"></see></summary>
    let ``EMMO_2e6eba5e-8c55-534c-b955-f09296e190e0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_2e6eba5e-8c55-534c-b955-f09296e190e0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the neodymium atom.
    /// <see href="https://w3id.org/emmo#EMMO_afee3bf0-d0e0-53dc-bfb1-b624b5724d47"></see></summary>
    let ``EMMO_afee3bf0-d0e0-53dc-bfb1-b624b5724d47`` =
        Namespaced_IRI.parse _namespace_name "EMMO_afee3bf0-d0e0-53dc-bfb1-b624b5724d47" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricPotential'.
    /// <see href="https://w3id.org/emmo#EMMO_2e7e5796_4a80_4d73_bb84_f31138446c0c"></see></summary>
    let EMMO_2e7e5796_4a80_4d73_bb84_f31138446c0c =
        Namespaced_IRI.parse _namespace_name "EMMO_2e7e5796_4a80_4d73_bb84_f31138446c0c" |> NamespacedName

    /// <summary>
    /// The relation between a process whole and a temporal part of the same type.
    /// <see href="https://w3id.org/emmo#EMMO_2eb10b5b_900b_44d7_af85_4de9a3729474"></see></summary>
    let EMMO_2eb10b5b_900b_44d7_af85_4de9a3729474 =
        Namespaced_IRI.parse _namespace_name "EMMO_2eb10b5b_900b_44d7_af85_4de9a3729474" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_bbca6dfa_7463_4e8d_8280_35862ff50ce0"></see>
    /// </summary>
    let EMMO_bbca6dfa_7463_4e8d_8280_35862ff50ce0 =
        Namespaced_IRI.parse _namespace_name "EMMO_bbca6dfa_7463_4e8d_8280_35862ff50ce0" |> NamespacedName

    /// <summary>
    /// For a solvent in a solution, quotient of the absolute activity and that of the pure substance at the same temperature and pressure.
    /// <see href="https://w3id.org/emmo#EMMO_2ed364b1_affe_4711_a83f_74bfd57b94ad"></see></summary>
    let EMMO_2ed364b1_affe_4711_a83f_74bfd57b94ad =
        Namespaced_IRI.parse _namespace_name "EMMO_2ed364b1_affe_4711_a83f_74bfd57b94ad" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthTimePerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_2f31340f_59ca_4a57_8513_269837af3796"></see></summary>
    let EMMO_2f31340f_59ca_4a57_8513_269837af3796 =
        Namespaced_IRI.parse _namespace_name "EMMO_2f31340f_59ca_4a57_8513_269837af3796" |> NamespacedName

    /// <summary>
    /// Fraction of atoms in an Ising ferromagnet having magnetic moments in one direction, minus the fraction having magnetic moments in the opposite direction.
    /// <see href="https://w3id.org/emmo#EMMO_2fb9b3ca_a3ba_4176_b9dc_ce5449286195"></see></summary>
    let EMMO_2fb9b3ca_a3ba_4176_b9dc_ce5449286195 =
        Namespaced_IRI.parse _namespace_name "EMMO_2fb9b3ca_a3ba_4176_b9dc_ce5449286195" |> NamespacedName

    /// <summary>
    /// A standalone atom can be bonded with other atoms by intermolecular forces (i.e. dipole–dipole, London dispersion force, hydrogen bonding), since this bonds does not involve electron sharing.
    /// An atom that does not share electrons with other atoms.
    /// <see href="https://w3id.org/emmo#EMMO_2fd3f574_5e93_47fe_afca_ed80b0a21ab4"></see></summary>
    let EMMO_2fd3f574_5e93_47fe_afca_ed80b0a21ab4 =
        Namespaced_IRI.parse _namespace_name "EMMO_2fd3f574_5e93_47fe_afca_ed80b0a21ab4" |> NamespacedName

    /// <summary>
    /// A standalone atom that has no net charge.
    /// <see href="https://w3id.org/emmo#EMMO_4588526f_8553_4f4d_aa73_a483e88d599b"></see></summary>
    let EMMO_4588526f_8553_4f4d_aa73_a483e88d599b =
        Namespaced_IRI.parse _namespace_name "EMMO_4588526f_8553_4f4d_aa73_a483e88d599b" |> NamespacedName

    /// <summary>
    /// A standalone atom with an unbalanced number of electrons with respect to its atomic number.
    /// The ion_atom is the basic part of a pure ionic bonded compound i.e. without eclectron sharing,
    /// <see href="https://w3id.org/emmo#EMMO_db03061b_db31_4132_a47a_6a634846578b"></see></summary>
    let EMMO_db03061b_db31_4132_a47a_6a634846578b =
        Namespaced_IRI.parse _namespace_name "EMMO_db03061b_db31_4132_a47a_6a634846578b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_2fe8b850_9f2d_4c13_8be9_6ae2487de393"></see>
    /// </summary>
    let EMMO_2fe8b850_9f2d_4c13_8be9_6ae2487de393 =
        Namespaced_IRI.parse _namespace_name "EMMO_2fe8b850_9f2d_4c13_8be9_6ae2487de393" |> NamespacedName

    /// <summary>
    /// A real vector with 3 elements.
    /// <see href="https://w3id.org/emmo#EMMO_2ff07b07_c447_490f_903a_f6a72a12d7bf"></see></summary>
    let EMMO_2ff07b07_c447_490f_903a_f6a72a12d7bf =
        Namespaced_IRI.parse _namespace_name "EMMO_2ff07b07_c447_490f_903a_f6a72a12d7bf" |> NamespacedName

    /// <summary>
    /// The datatype for bidimensional arrays.
    /// <see href="https://w3id.org/emmo#EMMO_2ff657b6_1c9f_4335_bba2_ea4428422977"></see></summary>
    let EMMO_2ff657b6_1c9f_4335_bba2_ea4428422977 =
        Namespaced_IRI.parse _namespace_name "EMMO_2ff657b6_1c9f_4335_bba2_ea4428422977" |> NamespacedName

    /// <summary>
    /// The datatype for monodimensional arrays.
    /// <see href="https://w3id.org/emmo#EMMO_d95ff9c8_e43f_4701_a761_f2ed601eb61d"></see></summary>
    let EMMO_d95ff9c8_e43f_4701_a761_f2ed601eb61d =
        Namespaced_IRI.parse _namespace_name "EMMO_d95ff9c8_e43f_4701_a761_f2ed601eb61d" |> NamespacedName

    /// <summary>
    /// In the EMMO we use the following JSON based syntax to represent arrays:
    /// - mono-dimensional array [v1,v2,...,vn] (vector)
    /// - bi-dimensional array [[v1,v2,...,vn],[w1,w2,...,2n]] (matrix)
    /// This notation can be extended to multidimensional arrays.
    /// An array is a datatype representing an ordered collection of elements (or values) that can be accessed by indexes. Arrays have an analog mathematical counterpart in vectors and matrixes, but are separate concepts. Arrays may be multidimensionals.
    /// <see href="https://w3id.org/emmo#EMMO_9e49caad_b29e_4cf1_9be4_80419fd1e45c"></see></summary>
    let EMMO_9e49caad_b29e_4cf1_9be4_80419fd1e45c =
        Namespaced_IRI.parse _namespace_name "EMMO_9e49caad_b29e_4cf1_9be4_80419fd1e45c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerQuarticTime'.
    /// <see href="https://w3id.org/emmo#EMMO_30261696_a8a4_44ce_9bf5_b18201a83c76"></see></summary>
    let EMMO_30261696_a8a4_44ce_9bf5_b18201a83c76 =
        Namespaced_IRI.parse _namespace_name "EMMO_30261696_a8a4_44ce_9bf5_b18201a83c76" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3086e6a8_edd9_4592_b33c_66d818835951"></see>
    /// </summary>
    let EMMO_3086e6a8_edd9_4592_b33c_66d818835951 =
        Namespaced_IRI.parse _namespace_name "EMMO_3086e6a8_edd9_4592_b33c_66d818835951" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_78284835_f4ed_4a7c_914f_a7fdb460ed8e"></see>
    /// </summary>
    let EMMO_78284835_f4ed_4a7c_914f_a7fdb460ed8e =
        Namespaced_IRI.parse _namespace_name "EMMO_78284835_f4ed_4a7c_914f_a7fdb460ed8e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_30e3edb5_0977_4b9b_9aed_5a4d16c1c07c"></see>
    /// </summary>
    let EMMO_30e3edb5_0977_4b9b_9aed_5a4d16c1c07c =
        Namespaced_IRI.parse _namespace_name "EMMO_30e3edb5_0977_4b9b_9aed_5a4d16c1c07c" |> NamespacedName

    /// <summary>
    /// A manufacturing in which an adherent layer of amorphous material is applied to a workpiece.
    /// <see href="https://w3id.org/emmo#EMMO_92028373_3a43_4b80_9a69_caca22df3918"></see></summary>
    let EMMO_92028373_3a43_4b80_9a69_caca22df3918 =
        Namespaced_IRI.parse _namespace_name "EMMO_92028373_3a43_4b80_9a69_caca22df3918" |> NamespacedName

    /// <summary>
    /// A colloid in which small particles (1 nm to 100 nm) are suspended in a continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_31557fae_b039_491c_bcbb_0ccb8711d5a6"></see></summary>
    let EMMO_31557fae_b039_491c_bcbb_0ccb8711d5a6 =
        Namespaced_IRI.parse _namespace_name "EMMO_31557fae_b039_491c_bcbb_0ccb8711d5a6" |> NamespacedName

    /// <summary>
    /// Number of ions per volume.
    /// <see href="https://w3id.org/emmo#EMMO_31b393c5_4cfe_4ad4_a9a4_0eafcb7fbd1a"></see></summary>
    let EMMO_31b393c5_4cfe_4ad4_a9a4_0eafcb7fbd1a =
        Namespaced_IRI.parse _namespace_name "EMMO_31b393c5_4cfe_4ad4_a9a4_0eafcb7fbd1a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Energy'.
    /// <see href="https://w3id.org/emmo#EMMO_f6070071_d054_4b17_9d2d_f446f7147d0f"></see></summary>
    let EMMO_f6070071_d054_4b17_9d2d_f446f7147d0f =
        Namespaced_IRI.parse _namespace_name "EMMO_f6070071_d054_4b17_9d2d_f446f7147d0f" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the livermorium atom.
    /// <see href="https://w3id.org/emmo#EMMO_31fda9f8-24e1-5c53-8616-a63cee7613de"></see></summary>
    let ``EMMO_31fda9f8-24e1-5c53-8616-a63cee7613de`` =
        Namespaced_IRI.parse _namespace_name "EMMO_31fda9f8-24e1-5c53-8616-a63cee7613de" |> NamespacedName

    /// <summary>
    /// A unit symbol that belongs to the SI system. Is either a SI base unit or a SI special unit.
    /// <see href="https://w3id.org/emmo#EMMO_32129fb5_df25_48fd_a29c_18a2f22a2dd5"></see></summary>
    let EMMO_32129fb5_df25_48fd_a29c_18a2f22a2dd5 =
        Namespaced_IRI.parse _namespace_name "EMMO_32129fb5_df25_48fd_a29c_18a2f22a2dd5" |> NamespacedName

    /// <summary>
    /// The base units in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_3a185e6c_9e19_4776_b583_19c978156aa0"></see></summary>
    let EMMO_3a185e6c_9e19_4776_b583_19c978156aa0 =
        Namespaced_IRI.parse _namespace_name "EMMO_3a185e6c_9e19_4776_b583_19c978156aa0" |> NamespacedName

    /// <summary>
    /// These units are SI coherent by definition.
    /// The 22 derived units that are given a special name in the SI system that stands for units derived by SI base units.
    /// <see href="https://w3id.org/emmo#EMMO_e9ffc696_5228_4ff9_8a60_0f5e05e9931b"></see></summary>
    let EMMO_e9ffc696_5228_4ff9_8a60_0f5e05e9931b =
        Namespaced_IRI.parse _namespace_name "EMMO_e9ffc696_5228_4ff9_8a60_0f5e05e9931b" |> NamespacedName

    /// <summary>
    /// Atom subclass for meitnerium.
    /// <see href="https://w3id.org/emmo#EMMO_3213514e-b1ba-506c-ae22-d4e3a688ddf3"></see></summary>
    let ``EMMO_3213514e-b1ba-506c-ae22-d4e3a688ddf3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3213514e-b1ba-506c-ae22-d4e3a688ddf3" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the meitnerium atom.
    /// <see href="https://w3id.org/emmo#EMMO_b2e41936-a44f-578d-960b-91f8f0135b2b"></see></summary>
    let ``EMMO_b2e41936-a44f-578d-960b-91f8f0135b2b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b2e41936-a44f-578d-960b-91f8f0135b2b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricConductance'.
    /// <see href="https://w3id.org/emmo#EMMO_321af35f_f0cc_4a5c_b4fe_8c2c0303fb0c"></see></summary>
    let EMMO_321af35f_f0cc_4a5c_b4fe_8c2c0303fb0c =
        Namespaced_IRI.parse _namespace_name "EMMO_321af35f_f0cc_4a5c_b4fe_8c2c0303fb0c" |> NamespacedName

    /// <summary>
    /// A generic step in a workflow, that is not the begin or the end.
    /// <see href="https://w3id.org/emmo#EMMO_322ce14e_9ede_4841_ad70_302b4d6c5f28"></see></summary>
    let EMMO_322ce14e_9ede_4841_ad70_302b4d6c5f28 =
        Namespaced_IRI.parse _namespace_name "EMMO_322ce14e_9ede_4841_ad70_302b4d6c5f28" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_326e7731_76c5_402d_a041_c9b48a736963"></see>
    /// </summary>
    let EMMO_326e7731_76c5_402d_a041_c9b48a736963 =
        Namespaced_IRI.parse _namespace_name "EMMO_326e7731_76c5_402d_a041_c9b48a736963" |> NamespacedName

    /// <summary>
    /// A meson with spin zero and even parity.
    /// <see href="https://w3id.org/emmo#EMMO_3275b6e9_05f1_4912_954f_7d64ac12b2d2"></see></summary>
    let EMMO_3275b6e9_05f1_4912_954f_7d64ac12b2d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_3275b6e9_05f1_4912_954f_7d64ac12b2d2" |> NamespacedName

    /// <summary>
    /// Distance from the centre of a circle to the circumference.
    /// <see href="https://w3id.org/emmo#EMMO_32dcd601_47c7_4028_b7fa_5e972ae57f12"></see></summary>
    let EMMO_32dcd601_47c7_4028_b7fa_5e972ae57f12 =
        Namespaced_IRI.parse _namespace_name "EMMO_32dcd601_47c7_4028_b7fa_5e972ae57f12" |> NamespacedName

    /// <summary>
    /// Distance, where one point is located on an axis or within a closed non self-intersecting curve or surface.
    /// <see href="https://w3id.org/emmo#EMMO_d772fa7a_0a31_44bb_a825_ae7829d794c6"></see></summary>
    let EMMO_d772fa7a_0a31_44bb_a825_ae7829d794c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_d772fa7a_0a31_44bb_a825_ae7829d794c6" |> NamespacedName

    /// <summary>
    /// Bounded matter.
    /// <see href="https://w3id.org/emmo#EMMO_32f55395_8b94_40de_a103_bffa5c121d98"></see></summary>
    let EMMO_32f55395_8b94_40de_a103_bffa5c121d98 =
        Namespaced_IRI.parse _namespace_name "EMMO_32f55395_8b94_40de_a103_bffa5c121d98" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassLengthPerCubicTime'.
    /// <see href="https://w3id.org/emmo#EMMO_3371fb68_5f07_467c_ada6_5aa3da3808d0"></see></summary>
    let EMMO_3371fb68_5f07_467c_ada6_5aa3da3808d0 =
        Namespaced_IRI.parse _namespace_name "EMMO_3371fb68_5f07_467c_ada6_5aa3da3808d0" |> NamespacedName

    /// <summary>
    /// An atom_based state defined by an exact number of e-bonded atomic species and an electron cloud made of the shared electrons.
    /// An entity is called essential if removing one direct part will lead to a change in entity class.
    /// An entity is called redundand if removing one direct part will not lead to a change in entity class.
    /// <see href="https://w3id.org/emmo#EMMO_3397f270_dfc1_4500_8f6f_4d0d85ac5f71"></see></summary>
    let EMMO_3397f270_dfc1_4500_8f6f_4d0d85ac5f71 =
        Namespaced_IRI.parse _namespace_name "EMMO_3397f270_dfc1_4500_8f6f_4d0d85ac5f71" |> NamespacedName

    /// <summary>
    /// The small, dense region at the centre of an atom consisting of protons and neutrons.
    /// <see href="https://w3id.org/emmo#EMMO_f835f4d4_c665_403d_ab25_dca5cc74be52"></see></summary>
    let EMMO_f835f4d4_c665_403d_ab25_dca5cc74be52 =
        Namespaced_IRI.parse _namespace_name "EMMO_f835f4d4_c665_403d_ab25_dca5cc74be52" |> NamespacedName

    /// <summary>
    /// A proper part of a whole, whose parts always cover the full temporal extension of the whole within a spatial interval.
    /// In EMMO FOL this is a defined property. In OWL temporal relations are primitive.
    /// <see href="https://w3id.org/emmo#EMMO_dc57d998_23db_4d8e_b2cd_f346b195b846"></see></summary>
    let EMMO_dc57d998_23db_4d8e_b2cd_f346b195b846 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc57d998_23db_4d8e_b2cd_f346b195b846" |> NamespacedName

    /// <summary>
    /// An elementary charged fermionic particle that belongs to the first generation of the lepton particle family.
    /// <see href="https://w3id.org/emmo#EMMO_730f2e31_ca78_410f_a5e1_4043217a41ab"></see></summary>
    let EMMO_730f2e31_ca78_410f_a5e1_4043217a41ab =
        Namespaced_IRI.parse _namespace_name "EMMO_730f2e31_ca78_410f_a5e1_4043217a41ab" |> NamespacedName

    /// <summary>
    /// A molecule composed of more than one element type.
    /// <see href="https://w3id.org/emmo#EMMO_50967f46_51f9_462a_b1e4_e63365b4a184"></see></summary>
    let EMMO_50967f46_51f9_462a_b1e4_e63365b4a184 =
        Namespaced_IRI.parse _namespace_name "EMMO_50967f46_51f9_462a_b1e4_e63365b4a184" |> NamespacedName

    /// <summary>
    /// A molecule composed of only one element type.
    /// <see href="https://w3id.org/emmo#EMMO_e024544d_e374_45b7_9340_1982040bc6b7"></see></summary>
    let EMMO_e024544d_e374_45b7_9340_1982040bc6b7 =
        Namespaced_IRI.parse _namespace_name "EMMO_e024544d_e374_45b7_9340_1982040bc6b7" |> NamespacedName

    /// <summary>
    /// The relation between two individuals representing a collection and a non-maximal proper part, meaning the the latter is connected with the rest of the whole.
    /// <see href="https://w3id.org/emmo#EMMO_339d8e1a_f52a_42cd_8df5_57b5328b939e"></see></summary>
    let EMMO_339d8e1a_f52a_42cd_8df5_57b5328b939e =
        Namespaced_IRI.parse _namespace_name "EMMO_339d8e1a_f52a_42cd_8df5_57b5328b939e" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ThermalResistivity'.
    /// <see href="https://w3id.org/emmo#EMMO_33b6c84d_e139_418c_8f8c_f1d45f94df46"></see></summary>
    let EMMO_33b6c84d_e139_418c_8f8c_f1d45f94df46 =
        Namespaced_IRI.parse _namespace_name "EMMO_33b6c84d_e139_418c_8f8c_f1d45f94df46" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of liquid in a solid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_33e0ac8b_a318_4285_b1de_e95347784632"></see></summary>
    let EMMO_33e0ac8b_a318_4285_b1de_e95347784632 =
        Namespaced_IRI.parse _namespace_name "EMMO_33e0ac8b_a318_4285_b1de_e95347784632" |> NamespacedName

    /// <summary>
    /// For a substance in a mixture, the absolute activity of the pure substance at the same temperature but at standard pressure.
    /// <see href="https://w3id.org/emmo#EMMO_340ec9c3_7b0a_4169_a739_6f9242517ff4"></see></summary>
    let EMMO_340ec9c3_7b0a_4169_a739_6f9242517ff4 =
        Namespaced_IRI.parse _namespace_name "EMMO_340ec9c3_7b0a_4169_a739_6f9242517ff4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3446e167_c576_49d6_846c_215bb8878a55"></see>
    /// </summary>
    let EMMO_3446e167_c576_49d6_846c_215bb8878a55 =
        Namespaced_IRI.parse _namespace_name "EMMO_3446e167_c576_49d6_846c_215bb8878a55" |> NamespacedName

    /// <summary>
    /// A semiotic relation that connects a declared semiotic object to a conventional sign in a declaration process.
    /// <see href="https://w3id.org/emmo#EMMO_eb3518bf_f799_4f9e_8c3e_ce59af11453b"></see></summary>
    let EMMO_eb3518bf_f799_4f9e_8c3e_ce59af11453b =
        Namespaced_IRI.parse _namespace_name "EMMO_eb3518bf_f799_4f9e_8c3e_ce59af11453b" |> NamespacedName

    /// <summary>
    /// Sum of the maximum beta-particle kinetic energy and the recoil energy of the atom produced in a reference frame in which the emitting nucleus is at rest before its disintegration.
    /// <see href="https://w3id.org/emmo#EMMO_34bdb169_90da_4d38_a351_647071804e5d"></see></summary>
    let EMMO_34bdb169_90da_4d38_a351_647071804e5d =
        Namespaced_IRI.parse _namespace_name "EMMO_34bdb169_90da_4d38_a351_647071804e5d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3528547f_cefe_4f24_bc46_936b39f711eb"></see>
    /// </summary>
    let EMMO_3528547f_cefe_4f24_bc46_936b39f711eb =
        Namespaced_IRI.parse _namespace_name "EMMO_3528547f_cefe_4f24_bc46_936b39f711eb" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassArea'.
    /// <see href="https://w3id.org/emmo#EMMO_3532cc67_472a_4227_96f4_04b93146cec3"></see></summary>
    let EMMO_3532cc67_472a_4227_96f4_04b93146cec3 =
        Namespaced_IRI.parse _namespace_name "EMMO_3532cc67_472a_4227_96f4_04b93146cec3" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricResistivity'.
    /// <see href="https://w3id.org/emmo#EMMO_359312ca_1d9d_4765_b20b_28d9f45d77e7"></see></summary>
    let EMMO_359312ca_1d9d_4765_b20b_28d9f45d77e7 =
        Namespaced_IRI.parse _namespace_name "EMMO_359312ca_1d9d_4765_b20b_28d9f45d77e7" |> NamespacedName

    /// <summary>
    /// A 'Sign' that stands for an 'Object' through convention, norm or habit, without any resemblance to it.
    /// In Peirce semiotics this kind of sign category is called symbol. However, since symbol is also used in formal languages, the name is changed in conventional.
    /// <see href="https://w3id.org/emmo#EMMO_35d2e130_6e01_41ed_94f7_00b333d46cf9"></see></summary>
    let EMMO_35d2e130_6e01_41ed_94f7_00b333d46cf9 =
        Namespaced_IRI.parse _namespace_name "EMMO_35d2e130_6e01_41ed_94f7_00b333d46cf9" |> NamespacedName

    /// <summary>
    /// A conventional that provides no possibility to infer the characteristics of the object to which it refers.
    /// <see href="https://w3id.org/emmo#EMMO_6e78433a_dbb9_409a_a7c0_4037f79d4ed8"></see></summary>
    let EMMO_6e78433a_dbb9_409a_a7c0_4037f79d4ed8 =
        Namespaced_IRI.parse _namespace_name "EMMO_6e78433a_dbb9_409a_a7c0_4037f79d4ed8" |> NamespacedName

    /// <summary>
    /// Let's define the class Colour as the subclass of the coded signs that involve photon emission and electromagnetic radiation sensible observers.
    /// An individual C of this class Colour can be defined be declaring the process individual (e.g. daylight illumination) and the observer (e.g. my eyes)
    /// Stating that an entity E hasCoded C, we mean that it can be observed by such setup of process + observer (i.e. observed by my eyes under daylight).
    /// This definition can be specialised for human eye perception, so that the observer can be a generic human, or to camera perception so that the observer can be a device.
    /// This can be used in material characterization, to define exactly the type of measurement done, including the instrument type.
    /// A conventional that stands for an object according to a code of interpretation to which the interpreter refers.
    /// A conventional referring to an object according to a specific code that reflects the results of a specific interaction mechanism and is shared between other interpreters.
    /// A coded is always a partial representation of an object since it reflects the object capability to be part of a specific determination.
    /// A coded is a sort of name or label that we put upon objects that interact with an determiner in the same specific way.
    ///
    /// For example, "hot" objects are objects that interact with an observer through a perception mechanism aimed to perceive an heat source. The code is made of terms such as "hot", "warm", "cold", that commonly refer to the perception of heat.
    /// <see href="https://w3id.org/emmo#EMMO_7286b164_df4c_4c14_a4b5_d41ad9c121f3"></see></summary>
    let EMMO_7286b164_df4c_4c14_a4b5_d41ad9c121f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_7286b164_df4c_4c14_a4b5_d41ad9c121f3" |> NamespacedName

    /// <summary>
    /// A coded that is not atomic with respect to a code of description.
    /// A description is a collection of properties that depicts an object. It is not atomic since it is made of several properties collected together.
    /// <see href="https://w3id.org/emmo#EMMO_35d4c439_fcb6_4399_a855_a89a207b41e9"></see></summary>
    let EMMO_35d4c439_fcb6_4399_a855_a89a207b41e9 =
        Namespaced_IRI.parse _namespace_name "EMMO_35d4c439_fcb6_4399_a855_a89a207b41e9" |> NamespacedName

    /// <summary>
    /// Measure of a conical geometric figure, called solid angle, formed by all rays, originating from a common point, called the vertex of the solid angle, and passing through the points of a closed, non-self-intersecting curve in space considered as the border of a surface.
    /// <see href="https://w3id.org/emmo#EMMO_35e1dd93_2cb6_4cea_b201_31036e113f61"></see></summary>
    let EMMO_35e1dd93_2cb6_4cea_b201_31036e113f61 =
        Namespaced_IRI.parse _namespace_name "EMMO_35e1dd93_2cb6_4cea_b201_31036e113f61" |> NamespacedName

    /// <summary>
    /// In an infinite medium, the quotient of the number of thermal neutrons absorbed in a fissionable nuclide or in a nuclear fuel, as specified, and the total number of thermal neutrons absorbed.
    /// <see href="https://w3id.org/emmo#EMMO_3657c87f_ee9a_41fd_9dd0_97fb524dba1a"></see></summary>
    let EMMO_3657c87f_ee9a_41fd_9dd0_97fb524dba1a =
        Namespaced_IRI.parse _namespace_name "EMMO_3657c87f_ee9a_41fd_9dd0_97fb524dba1a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the fluorine atom.
    /// <see href="https://w3id.org/emmo#EMMO_36a32a8c-8307-5b09-adcb-bbaeb9e36b49"></see></summary>
    let ``EMMO_36a32a8c-8307-5b09-adcb-bbaeb9e36b49`` =
        Namespaced_IRI.parse _namespace_name "EMMO_36a32a8c-8307-5b09-adcb-bbaeb9e36b49" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_36a9bf69_483b_42fd_8a0c_7ac9206320bc"></see>
    /// </summary>
    let EMMO_36a9bf69_483b_42fd_8a0c_7ac9206320bc =
        Namespaced_IRI.parse _namespace_name "EMMO_36a9bf69_483b_42fd_8a0c_7ac9206320bc" |> NamespacedName

    /// <summary>
    /// Atom subclass for silver.
    /// <see href="https://w3id.org/emmo#EMMO_36ab7281-0187-568f-b0b4-61e33dc08cfc"></see></summary>
    let ``EMMO_36ab7281-0187-568f-b0b4-61e33dc08cfc`` =
        Namespaced_IRI.parse _namespace_name "EMMO_36ab7281-0187-568f-b0b4-61e33dc08cfc" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the silver atom.
    /// <see href="https://w3id.org/emmo#EMMO_e82869a8-32a8-5d57-81a8-e2d618976f23"></see></summary>
    let ``EMMO_e82869a8-32a8-5d57-81a8-e2d618976f23`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e82869a8-32a8-5d57-81a8-e2d618976f23" |> NamespacedName

    /// <summary>
    /// A causal object which is tessellated with only spatial direct parts.
    /// The definition of an arrangement implies that its spatial direct parts are not gained or lost during its temporal extension (they exist from the left to the right side of the time interval), so that the cardinality of spatial direct parts in an arrangement is constant.
    /// This does not mean that there cannot be a change in the internal structure of the arrangement direct parts. It means only that this change must not affect the existence of the direct part itself.
    /// The use of spatial direct parthood in state definition means that an arrangement cannot overlap in space another arrangement that is direct part of the same whole.
    /// <see href="https://w3id.org/emmo#EMMO_36c79456_e29c_400d_8bd3_0eedddb82652"></see></summary>
    let EMMO_36c79456_e29c_400d_8bd3_0eedddb82652 =
        Namespaced_IRI.parse _namespace_name "EMMO_36c79456_e29c_400d_8bd3_0eedddb82652" |> NamespacedName

    /// <summary>
    /// A well formed tessellation with tiles that all spatial.
    /// <see href="https://w3id.org/emmo#EMMO_8944581c_64da_46a9_be29_7074f7cc8098"></see></summary>
    let EMMO_8944581c_64da_46a9_be29_7074f7cc8098 =
        Namespaced_IRI.parse _namespace_name "EMMO_8944581c_64da_46a9_be29_7074f7cc8098" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PowerPerAreaVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_36e03182_1be9_497c_bb71_e26fbb9160d2"></see></summary>
    let EMMO_36e03182_1be9_497c_bb71_e26fbb9160d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_36e03182_1be9_497c_bb71_e26fbb9160d2" |> NamespacedName

    /// <summary>
    /// An indirect cause is a relation between two entities that is mediated by a intermediate entity. In other words, there are no quantum parts of the causing entity that are direct cause of quantum parts of the caused entity.
    /// A causal relation between the effected and the causing entities with intermediaries.
    /// <see href="https://w3id.org/emmo#EMMO_b85e4738_500c_4e1b_bbe8_9e84190485d6"></see></summary>
    let EMMO_b85e4738_500c_4e1b_bbe8_9e84190485d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_b85e4738_500c_4e1b_bbe8_9e84190485d6" |> NamespacedName

    /// <summary>
    /// A relation between entities that are only one-directionally causally connected.
    /// A relation jointly covered by hasNext and hasSuccessor relations, which are mutually exclusive.
    /// <see href="https://w3id.org/emmo#EMMO_ebc9e62c_5dc4_44db_9060_7923740bdf78"></see></summary>
    let EMMO_ebc9e62c_5dc4_44db_9060_7923740bdf78 =
        Namespaced_IRI.parse _namespace_name "EMMO_ebc9e62c_5dc4_44db_9060_7923740bdf78" |> NamespacedName

    /// <summary>
    /// The relation between two causally reachable entities through a path of contacts relations (i.e. representing physical interactions).
    /// <see href="https://w3id.org/emmo#EMMO_d01b3ee2_91a5_4ce2_95cd_f0d2c333c6d3"></see></summary>
    let EMMO_d01b3ee2_91a5_4ce2_95cd_f0d2c333c6d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_d01b3ee2_91a5_4ce2_95cd_f0d2c333c6d3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_375aaa5a_998f_4626_83e0_c7d7e52a6565"></see>
    /// </summary>
    let EMMO_375aaa5a_998f_4626_83e0_c7d7e52a6565 =
        Namespaced_IRI.parse _namespace_name "EMMO_375aaa5a_998f_4626_83e0_c7d7e52a6565" |> NamespacedName

    /// <summary>
    /// Product of the mean linear range R and the mass density ρ of the material.
    /// <see href="https://w3id.org/emmo#EMMO_376d013c_b703_40dc_bd8d_23145dfed2e3"></see></summary>
    let EMMO_376d013c_b703_40dc_bd8d_23145dfed2e3 =
        Namespaced_IRI.parse _namespace_name "EMMO_376d013c_b703_40dc_bd8d_23145dfed2e3" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_90798691_3b86_4d8c_910f_be2b39c98b39"></see></summary>
    let EMMO_90798691_3b86_4d8c_910f_be2b39c98b39 =
        Namespaced_IRI.parse _namespace_name "EMMO_90798691_3b86_4d8c_910f_be2b39c98b39" |> NamespacedName

    /// <summary>
    /// Magnitude of the angular velocity ω divided by the angle 2π, thus n = |ω|/2π.
    /// <see href="https://w3id.org/emmo#EMMO_3789d3c5_77f4_456e_b7ed_40e670f47e52"></see></summary>
    let EMMO_3789d3c5_77f4_456e_b7ed_40e670f47e52 =
        Namespaced_IRI.parse _namespace_name "EMMO_3789d3c5_77f4_456e_b7ed_40e670f47e52" |> NamespacedName

    /// <summary>
    /// Number of periods per time interval.
    /// <see href="https://w3id.org/emmo#EMMO_852b4ab8_fc29_4749_a8c7_b92d4fca7d5a"></see></summary>
    let EMMO_852b4ab8_fc29_4749_a8c7_b92d4fca7d5a =
        Namespaced_IRI.parse _namespace_name "EMMO_852b4ab8_fc29_4749_a8c7_b92d4fca7d5a" |> NamespacedName

    /// <summary>
    /// Atomic quantum number related to the orbital angular momentum l of a one-electron state.
    /// <see href="https://w3id.org/emmo#EMMO_37f1613c_c905_4cce_bcf4_ef0964c19e5d"></see></summary>
    let EMMO_37f1613c_c905_4cce_bcf4_ef0964c19e5d =
        Namespaced_IRI.parse _namespace_name "EMMO_37f1613c_c905_4cce_bcf4_ef0964c19e5d" |> NamespacedName

    /// <summary>
    /// Atom subclass for actinium.
    /// <see href="https://w3id.org/emmo#EMMO_380f1ba6-b4f3-51e2-a63f-ceeeca2ed2f4"></see></summary>
    let ``EMMO_380f1ba6-b4f3-51e2-a63f-ceeeca2ed2f4`` =
        Namespaced_IRI.parse _namespace_name "EMMO_380f1ba6-b4f3-51e2-a63f-ceeeca2ed2f4" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the actinium atom.
    /// <see href="https://w3id.org/emmo#EMMO_3bf0809d-2f7c-5282-b7fd-2e5486f6dbd3"></see></summary>
    let ``EMMO_3bf0809d-2f7c-5282-b7fd-2e5486f6dbd3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3bf0809d-2f7c-5282-b7fd-2e5486f6dbd3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_381b6a6e_6e8e_461a_8591_d7a60e823d4d"></see>
    /// </summary>
    let EMMO_381b6a6e_6e8e_461a_8591_d7a60e823d4d =
        Namespaced_IRI.parse _namespace_name "EMMO_381b6a6e_6e8e_461a_8591_d7a60e823d4d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_6523cad7_ea54_471c_adb7_e783f824ec09"></see>
    /// </summary>
    let EMMO_6523cad7_ea54_471c_adb7_e783f824ec09 =
        Namespaced_IRI.parse _namespace_name "EMMO_6523cad7_ea54_471c_adb7_e783f824ec09" |> NamespacedName

    /// <summary>
    /// Atomic quantum number related to the number n−1 of radial nodes of one-electron wave functions.
    /// <see href="https://w3id.org/emmo#EMMO_385de036_637c_48fa_b6d5_5dca6f79d350"></see></summary>
    let EMMO_385de036_637c_48fa_b6d5_5dca6f79d350 =
        Namespaced_IRI.parse _namespace_name "EMMO_385de036_637c_48fa_b6d5_5dca6f79d350" |> NamespacedName

    /// <summary>
    /// A geometrical property of an area which reflects how its points are distributed with regard to an arbitrary axis.
    /// <see href="https://w3id.org/emmo#EMMO_38a53b33_0eda_45fd_b955_69d2f0d3f9de"></see></summary>
    let EMMO_38a53b33_0eda_45fd_b955_69d2f0d3f9de =
        Namespaced_IRI.parse _namespace_name "EMMO_38a53b33_0eda_45fd_b955_69d2f0d3f9de" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'QuarticLength'.
    /// <see href="https://w3id.org/emmo#EMMO_8627410d_01f8_4ed1_8f2b_aba69d791ad3"></see></summary>
    let EMMO_8627410d_01f8_4ed1_8f2b_aba69d791ad3 =
        Namespaced_IRI.parse _namespace_name "EMMO_8627410d_01f8_4ed1_8f2b_aba69d791ad3" |> NamespacedName

    /// <summary>
    /// A geometrical property of an area which reflects how its points are distributed with regard to an arbitrary axis.
    /// <see href="https://w3id.org/emmo#EMMO_700cd058_a54d_4104_97ab_887ad865409e"></see></summary>
    let EMMO_700cd058_a54d_4104_97ab_887ad865409e =
        Namespaced_IRI.parse _namespace_name "EMMO_700cd058_a54d_4104_97ab_887ad865409e" |> NamespacedName

    /// <summary>
    /// The class of physical objects possessing a structure that is larger than a single composite particle, for which its bosonic or fermionic nature is undetermined.
    /// A composite physical object is made of bonded objects (i.e. characterised by their quantum states using a Schrodinger equation approach) that are connected together by elementary particles travelling between them. These elemenentary particles are real particles, describing the existance of a classical field (e.g. Coulomb potential between charged particles).
    /// <see href="https://w3id.org/emmo#EMMO_57d977ab_0036_4779_b59a_e47620afdb9c"></see></summary>
    let EMMO_57d977ab_0036_4779_b59a_e47620afdb9c =
        Namespaced_IRI.parse _namespace_name "EMMO_57d977ab_0036_4779_b59a_e47620afdb9c" |> NamespacedName

    /// <summary>
    /// "... in the 'classical' picture ordinary matter is made of atoms, in which electrons are held in orbit around a nucleus of protons and neutrons by the electrical attraction of opposite charges. We can now give this model a more sophisticated formulation by attributing the binding force to the exchange of photons between the electrons and the protons in the nucleus. However, for the purposes of atomic physics this is overkill, for in this context quantization of the electromagnetic field produces only minute effects (notably the Lamb shift and the anomalous magnetic moment of the electron). To excellent approximation we can pretend that the forces are given by Coulomb's law (together with various magnetic dipole couplings). The point is that in a bound state enormous numbers of photons are continually streaming back and forth, so that the "lumpiness" of the field is effectively smoothed out, and classical electrodynamics is a suitable approximation to the truth. But in most elementary particle processes, such as the photoelectric effect or Compton scattering, individual photons are involved, and quantization can no longer be ignored."
    /// D. Griffiths, "Introduction to elementary Particles", Wiley-VCH, 2004, pp.16-17
    /// A bonded object is a sequence of fundamental interactions that can be described approximatively by Schrodinger formulation. A bonded object is typically characterised by having quantum states (e.g.  electron states in an atom, energy levels of a molecule). Furthermore, a bonded object is made of elementary particles that travels from the beginning to the end of the entity (i.e. a bonded object doesn't change its components).
    /// <see href="https://w3id.org/emmo#EMMO_801395f8_948e_4637_ac3b_5fcd587d72ca"></see></summary>
    let EMMO_801395f8_948e_4637_ac3b_5fcd587d72ca =
        Namespaced_IRI.parse _namespace_name "EMMO_801395f8_948e_4637_ac3b_5fcd587d72ca" |> NamespacedName

    /// <summary>
    /// A meson with total spin 1 and even parit.
    /// <see href="https://w3id.org/emmo#EMMO_38d00e5f_d759_4dcc_8551_ab95865cf799"></see></summary>
    let EMMO_38d00e5f_d759_4dcc_8551_ab95865cf799 =
        Namespaced_IRI.parse _namespace_name "EMMO_38d00e5f_d759_4dcc_8551_ab95865cf799" |> NamespacedName

    /// <summary>
    /// The analytical composition of a saturated solution, expressed in terms of the proportion of a designated solute in a designated solvent, is the solubility of that solute.
    /// The solubility may be expressed as a concentration, molality, mole fraction, mole ratio, etc.
    /// <see href="https://w3id.org/emmo#EMMO_38d65ffa_353f_4820_8781_ff986b63e517"></see></summary>
    let EMMO_38d65ffa_353f_4820_8781_ff986b63e517 =
        Namespaced_IRI.parse _namespace_name "EMMO_38d65ffa_353f_4820_8781_ff986b63e517" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_39348191_08fd_4bb6_9b1e_012d5b2f1ff6"></see>
    /// </summary>
    let EMMO_39348191_08fd_4bb6_9b1e_012d5b2f1ff6 =
        Namespaced_IRI.parse _namespace_name "EMMO_39348191_08fd_4bb6_9b1e_012d5b2f1ff6" |> NamespacedName

    /// <summary>
    /// The class of individuals standing for an amount of ordinary matter substance (or mixture of substances) in different states of matter or phases.
    /// A instance of a material (e.g. nitrogen) can represent any state of matter. The fact that the individual also belongs to other classes (e.g. Gas) would reveal the actual form in which the material is found.
    /// <see href="https://w3id.org/emmo#EMMO_4207e895_8b83_4318_996a_72cfb32acd94"></see></summary>
    let EMMO_4207e895_8b83_4318_996a_72cfb32acd94 =
        Namespaced_IRI.parse _namespace_name "EMMO_4207e895_8b83_4318_996a_72cfb32acd94" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4c1f58cd_6e2c_48fb_8098_1cbb762abb05"></see>
    /// </summary>
    let EMMO_4c1f58cd_6e2c_48fb_8098_1cbb762abb05 =
        Namespaced_IRI.parse _namespace_name "EMMO_4c1f58cd_6e2c_48fb_8098_1cbb762abb05" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c5e9e390_8836_4440_b4fd_c906fdd4f438"></see>
    /// </summary>
    let EMMO_c5e9e390_8836_4440_b4fd_c906fdd4f438 =
        Namespaced_IRI.parse _namespace_name "EMMO_c5e9e390_8836_4440_b4fd_c906fdd4f438" |> NamespacedName

    /// <summary>
    /// A material that contains two or more constituent materials.
    /// <see href="https://w3id.org/emmo#EMMO_f678173d_f036_4df1_a86b_2894560be617"></see></summary>
    let EMMO_f678173d_f036_4df1_a86b_2894560be617 =
        Namespaced_IRI.parse _namespace_name "EMMO_f678173d_f036_4df1_a86b_2894560be617" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_fb27e6d6_159e_48a6_9c29_76dc31d8a860"></see>
    /// </summary>
    let EMMO_fb27e6d6_159e_48a6_9c29_76dc31d8a860 =
        Namespaced_IRI.parse _namespace_name "EMMO_fb27e6d6_159e_48a6_9c29_76dc31d8a860" |> NamespacedName

    /// <summary>
    /// A zero-manifold of only one point.
    /// <see href="https://w3id.org/emmo#EMMO_39362460_2a97_4367_8f93_0418c2ac9a08"></see></summary>
    let EMMO_39362460_2a97_4367_8f93_0418c2ac9a08 =
        Namespaced_IRI.parse _namespace_name "EMMO_39362460_2a97_4367_8f93_0418c2ac9a08" |> NamespacedName

    /// <summary>
    /// Quotient of thermal conductivity, and the product of electric conductivity and thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_394390c8_7b29_4c0a_9104_2d2bc8780138"></see></summary>
    let EMMO_394390c8_7b29_4c0a_9104_2d2bc8780138 =
        Namespaced_IRI.parse _namespace_name "EMMO_394390c8_7b29_4c0a_9104_2d2bc8780138" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3967de47_343f_4bab_aada_b4bec73d11da"></see>
    /// </summary>
    let EMMO_3967de47_343f_4bab_aada_b4bec73d11da =
        Namespaced_IRI.parse _namespace_name "EMMO_3967de47_343f_4bab_aada_b4bec73d11da" |> NamespacedName

    /// <summary>
    /// A soft, solid or solid-like colloid consisting of two or more components, one of which is a liquid, present in substantial quantity.
    /// <see href="https://w3id.org/emmo#EMMO_3995e22d_5720_4dcf_ba3b_d0ce03f514c6"></see></summary>
    let EMMO_3995e22d_5720_4dcf_ba3b_d0ce03f514c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_3995e22d_5720_4dcf_ba3b_d0ce03f514c6" |> NamespacedName

    /// <summary>
    /// A construction language used to write configuration files.
    /// <see href="https://w3id.org/emmo#EMMO_3997e1f5_f478_4572_a030_4b8e7e5cc63a"></see></summary>
    let EMMO_3997e1f5_f478_4572_a030_4b8e7e5cc63a =
        Namespaced_IRI.parse _namespace_name "EMMO_3997e1f5_f478_4572_a030_4b8e7e5cc63a" |> NamespacedName

    /// <summary>
    /// The kelvin, symbol K, is the SI unit of thermodynamic temperature. It is defined by taking the fixed numerical value of the Boltzmann constant k to be 1.380649×10−23 when expressed in the unit J K−1, which is equal to kg m2 s−2 K−1, where the kilogram, metre and second are defined in terms of h, c and ∆νCs.
    /// <see href="https://w3id.org/emmo#Kelvin"></see></summary>
    let Kelvin = Namespaced_IRI.parse _namespace_name "Kelvin" |> NamespacedName
    /// <summary>
    /// The kilogram, symbol kg, is the SI unit of mass. It is defined by taking the fixed numerical value of the Planck constant h to be 6.62607015×10−34 when expressed in the unit J s, which is equal to kg m2 s−1, where the metre and the second are defined in terms of c and ∆νCs.
    /// <see href="https://w3id.org/emmo#Kilogram"></see></summary>
    let Kilogram = Namespaced_IRI.parse _namespace_name "Kilogram" |> NamespacedName
    /// <summary>
    /// The metre, symbol m, is the SI unit of length. It is defined by taking the fixed numerical value of the speed of light in vacuum c to be 299792458 when expressed in the unit m s−1, where the second is defined in terms of ∆νCs.
    /// <see href="https://w3id.org/emmo#Metre"></see></summary>
    let Metre = Namespaced_IRI.parse _namespace_name "Metre" |> NamespacedName
    /// <summary>
    /// The mole, symbol mol, is the SI unit of amount of substance. One mole contains exactly 6.022 140 76 × 1023 elementary entities. This number is the fixed numerical value of the Avogadro constant, NA, when expressed in the unit mol−1 and is called the Avogadro number. The amount of substance, symbol n, of a system is a measure of the number of specified elementary entities. An elementary entity may be an atom, a molecule, an ion, an electron, any other particle or specified group of particles.
    /// <see href="https://w3id.org/emmo#Mole"></see></summary>
    let Mole = Namespaced_IRI.parse _namespace_name "Mole" |> NamespacedName
    /// <summary>
    /// The second, symbol s, is the SI unit of time. It is defined by taking the fixed numerical value of the caesium frequency ∆νCs, the unperturbed ground-state hyperfine transition frequency of the caesium 133 atom, to be 9192631770 when expressed in the unit Hz, which is equal to s−1.
    /// <see href="https://w3id.org/emmo#Second"></see></summary>
    let Second = Namespaced_IRI.parse _namespace_name "Second" |> NamespacedName

    /// <summary>
    /// A data representing 32-bit non-negative integer number, 0...4294967295.
    /// <see href="https://w3id.org/emmo#EMMO_3a53b946_4dfd_4a38_bb5b_aa78d7b0db9c"></see></summary>
    let EMMO_3a53b946_4dfd_4a38_bb5b_aa78d7b0db9c =
        Namespaced_IRI.parse _namespace_name "EMMO_3a53b946_4dfd_4a38_bb5b_aa78d7b0db9c" |> NamespacedName

    /// <summary>
    /// Describes elements' or compounds' readiness to form bonds.
    /// <see href="https://w3id.org/emmo#EMMO_3a5b4cf3_08d7_4107_be20_cdd0ef7fc73c"></see></summary>
    let EMMO_3a5b4cf3_08d7_4107_be20_cdd0ef7fc73c =
        Namespaced_IRI.parse _namespace_name "EMMO_3a5b4cf3_08d7_4107_be20_cdd0ef7fc73c" |> NamespacedName

    /// <summary>
    /// Ratio of void volume and total volume of a porous material.
    /// <see href="https://w3id.org/emmo#EMMO_3a6578ac_aee0_43b9_9bc6_1eb208c8c9a9"></see></summary>
    let EMMO_3a6578ac_aee0_43b9_9bc6_1eb208c8c9a9 =
        Namespaced_IRI.parse _namespace_name "EMMO_3a6578ac_aee0_43b9_9bc6_1eb208c8c9a9" |> NamespacedName

    /// <summary>
    /// The magnetic flux density for disappearance of superconductivity in a type I superconductor.
    /// <see href="https://w3id.org/emmo#EMMO_3a713a3d_dee2_4acd_bc30_5d2b23f605cd"></see></summary>
    let EMMO_3a713a3d_dee2_4acd_bc30_5d2b23f605cd =
        Namespaced_IRI.parse _namespace_name "EMMO_3a713a3d_dee2_4acd_bc30_5d2b23f605cd" |> NamespacedName

    /// <summary>
    /// Strength of the magnetic field.
    /// Often denoted B.
    /// <see href="https://w3id.org/emmo#EMMO_961d1aba_f75e_4411_aaa4_457f7516ed6b"></see></summary>
    let EMMO_961d1aba_f75e_4411_aaa4_457f7516ed6b =
        Namespaced_IRI.parse _namespace_name "EMMO_961d1aba_f75e_4411_aaa4_457f7516ed6b" |> NamespacedName

    /// <summary>
    /// For type II superconductors, the threshold magnetic flux density for disappearance of bulk superconductivity.
    /// <see href="https://w3id.org/emmo#EMMO_6bfe6ad2_96ba_4478_81e5_d8881c550757"></see></summary>
    let EMMO_6bfe6ad2_96ba_4478_81e5_d8881c550757 =
        Namespaced_IRI.parse _namespace_name "EMMO_6bfe6ad2_96ba_4478_81e5_d8881c550757" |> NamespacedName

    /// <summary>
    /// For type II superconductors, the threshold magnetic flux density for magnetic flux entering the superconductor.
    /// <see href="https://w3id.org/emmo#EMMO_fd4a6307_f9f7_4b54_b044_caa04e620232"></see></summary>
    let EMMO_fd4a6307_f9f7_4b54_b044_caa04e620232 =
        Namespaced_IRI.parse _namespace_name "EMMO_fd4a6307_f9f7_4b54_b044_caa04e620232" |> NamespacedName

    /// <summary>
    /// A program aimed to provide a specific high level function to the user, usually hiding lower level procedures.
    /// <see href="https://w3id.org/emmo#EMMO_3b031fa9_8623_4ea5_8b57_bcafb70c5c8b"></see></summary>
    let EMMO_3b031fa9_8623_4ea5_8b57_bcafb70c5c8b =
        Namespaced_IRI.parse _namespace_name "EMMO_3b031fa9_8623_4ea5_8b57_bcafb70c5c8b" |> NamespacedName

    /// <summary>
    /// Quotient of mass excess and the unified atomic mass constant.
    /// <see href="https://w3id.org/emmo#EMMO_3b246b97_b2d1_4e6b_8d3f_669ebd4ddbd6"></see></summary>
    let EMMO_3b246b97_b2d1_4e6b_8d3f_669ebd4ddbd6 =
        Namespaced_IRI.parse _namespace_name "EMMO_3b246b97_b2d1_4e6b_8d3f_669ebd4ddbd6" |> NamespacedName

    /// <summary>
    /// Written as pOH
    /// number quantifying the acidic or the alkaline character of a solution, equal to the negative of the decimal logarithm of ion activity aOH- of the hydroxide anion OH-
    /// pH = −10 log(a_OH-)
    /// <see href="https://w3id.org/emmo#EMMO_3b586409_b05e_4129_ab40_93768eef503f"></see></summary>
    let EMMO_3b586409_b05e_4129_ab40_93768eef503f =
        Namespaced_IRI.parse _namespace_name "EMMO_3b586409_b05e_4129_ab40_93768eef503f" |> NamespacedName

    /// <summary>
    /// Written as pH
    /// At about 25 °C aqueous solutions with:
    /// pH &lt; 7 are acidic;
    /// pH = 7 are neutral;
    /// pH &gt; 7 are alkaline.
    /// At temperatures far from 25 °C the pH of a neutral solution differs significantly from 7.
    /// Number quantifying the acidic or the alkaline character of a solution, equal to the negative of the decimal logarithm of ion activity aH+ of the hydrogen cation H+
    /// pH = −10 log(a_H+).
    /// <see href="https://w3id.org/emmo#EMMO_80fe82d4_f4c1_43a1_98dc_ee5fc7927e19"></see></summary>
    let EMMO_80fe82d4_f4c1_43a1_98dc_ee5fc7927e19 =
        Namespaced_IRI.parse _namespace_name "EMMO_80fe82d4_f4c1_43a1_98dc_ee5fc7927e19" |> NamespacedName

    /// <summary>
    /// Measure of magnetism, taking account of the strength and the extent of a magnetic field.
    /// <see href="https://w3id.org/emmo#EMMO_3b931698_937e_49be_ab1b_36fa52d91181"></see></summary>
    let EMMO_3b931698_937e_49be_ab1b_36fa52d91181 =
        Namespaced_IRI.parse _namespace_name "EMMO_3b931698_937e_49be_ab1b_36fa52d91181" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticFlux'.
    /// <see href="https://w3id.org/emmo#EMMO_4c49ab58_a6f6_409e_b849_f873ae1dcbee"></see></summary>
    let EMMO_4c49ab58_a6f6_409e_b849_f873ae1dcbee =
        Namespaced_IRI.parse _namespace_name "EMMO_4c49ab58_a6f6_409e_b849_f873ae1dcbee" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3b95deb3_9f2f_4ab0_8574_fb74f01b4bea"></see>
    /// </summary>
    let EMMO_3b95deb3_9f2f_4ab0_8574_fb74f01b4bea =
        Namespaced_IRI.parse _namespace_name "EMMO_3b95deb3_9f2f_4ab0_8574_fb74f01b4bea" |> NamespacedName

    /// <summary>
    /// Atom subclass for lithium.
    /// <see href="https://w3id.org/emmo#EMMO_3bb84fc5-5cb4-5250-ba87-169ae90ec6d7"></see></summary>
    let ``EMMO_3bb84fc5-5cb4-5250-ba87-169ae90ec6d7`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3bb84fc5-5cb4-5250-ba87-169ae90ec6d7" |> NamespacedName

    /// <summary>
    /// Atom subclass for rhodium.
    /// <see href="https://w3id.org/emmo#EMMO_3bc0aedf-c43e-5d30-8688-44d19900a68b"></see></summary>
    let ``EMMO_3bc0aedf-c43e-5d30-8688-44d19900a68b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3bc0aedf-c43e-5d30-8688-44d19900a68b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the rhodium atom.
    /// <see href="https://w3id.org/emmo#EMMO_ddcc9683-bee2-5ea0-8b18-54c85b551ad6"></see></summary>
    let ``EMMO_ddcc9683-bee2-5ea0-8b18-54c85b551ad6`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ddcc9683-bee2-5ea0-8b18-54c85b551ad6" |> NamespacedName

    /// <summary>
    /// The class of units with physical dimensionality per length to the power of four.
    /// <see href="https://w3id.org/emmo#EMMO_3c38a8b4_ed07_4185_8d9b_b57b9130c537"></see></summary>
    let EMMO_3c38a8b4_ed07_4185_8d9b_b57b9130c537 =
        Namespaced_IRI.parse _namespace_name "EMMO_3c38a8b4_ed07_4185_8d9b_b57b9130c537" |> NamespacedName

    /// <summary>
    /// A mapping that acts on elements of one space and produces elements of another space.
    /// <see href="https://w3id.org/emmo#EMMO_f6d0c26a_98b6_4cf8_8632_aa259131faaa"></see></summary>
    let EMMO_f6d0c26a_98b6_4cf8_8632_aa259131faaa =
        Namespaced_IRI.parse _namespace_name "EMMO_f6d0c26a_98b6_4cf8_8632_aa259131faaa" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3c51ea74_43a4_42d5_953b_fcb43f359c73"></see>
    /// </summary>
    let EMMO_3c51ea74_43a4_42d5_953b_fcb43f359c73 =
        Namespaced_IRI.parse _namespace_name "EMMO_3c51ea74_43a4_42d5_953b_fcb43f359c73" |> NamespacedName

    /// <summary>
    /// A scripting language developed specifically for an application, so that it's usage and interpretation is limited in this context.
    /// <see href="https://w3id.org/emmo#EMMO_3c5b33a1_4f28_41f9_b725_1994df79bf55"></see></summary>
    let EMMO_3c5b33a1_4f28_41f9_b725_1994df79bf55 =
        Namespaced_IRI.parse _namespace_name "EMMO_3c5b33a1_4f28_41f9_b725_1994df79bf55" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_3c7f239f_e833_4a2b_98a1_c88831770c1b"></see>
    /// </summary>
    let EMMO_3c7f239f_e833_4a2b_98a1_c88831770c1b =
        Namespaced_IRI.parse _namespace_name "EMMO_3c7f239f_e833_4a2b_98a1_c88831770c1b" |> NamespacedName

    /// <summary>
    /// A constituent of a system.
    /// <see href="https://w3id.org/emmo#EMMO_f76884f7_964e_488e_9bb7_1b2453e9e817"></see></summary>
    let EMMO_f76884f7_964e_488e_9bb7_1b2453e9e817 =
        Namespaced_IRI.parse _namespace_name "EMMO_f76884f7_964e_488e_9bb7_1b2453e9e817" |> NamespacedName

    /// <summary>
    /// The relation between an object and one of its holistic part that contributes to the object under some spatial-based criteria.
    /// <see href="https://w3id.org/emmo#EMMO_dba27ca1_33c9_4443_a912_1519ce4c39ec"></see></summary>
    let EMMO_dba27ca1_33c9_4443_a912_1519ce4c39ec =
        Namespaced_IRI.parse _namespace_name "EMMO_dba27ca1_33c9_4443_a912_1519ce4c39ec" |> NamespacedName

    /// <summary>
    /// A data representing 8-bit integer number.
    /// <see href="https://w3id.org/emmo#EMMO_3c87fd89_b0f0_477a_86b6_d949c2b982ee"></see></summary>
    let EMMO_3c87fd89_b0f0_477a_86b6_d949c2b982ee =
        Namespaced_IRI.parse _namespace_name "EMMO_3c87fd89_b0f0_477a_86b6_d949c2b982ee" |> NamespacedName

    /// <summary>
    /// For particle X, mass of that particle at rest in an inertial frame.
    /// <see href="https://w3id.org/emmo#EMMO_3c947caf_4070_4c79_a3a3_e53274ac9944"></see></summary>
    let EMMO_3c947caf_4070_4c79_a3a3_e53274ac9944 =
        Namespaced_IRI.parse _namespace_name "EMMO_3c947caf_4070_4c79_a3a3_e53274ac9944" |> NamespacedName

    /// <summary>
    /// energy difference between an electron at rest at infinity and an electron at the lowest level of the conduction band in an insulator or semiconductor
    /// <see href="https://w3id.org/emmo#EMMO_3cae45cc_3b57_469c_a695_713735886f31"></see></summary>
    let EMMO_3cae45cc_3b57_469c_a695_713735886f31 =
        Namespaced_IRI.parse _namespace_name "EMMO_3cae45cc_3b57_469c_a695_713735886f31" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EntropyPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_3cb55500_dc5b_4586_bbf3_1d4158afac35"></see></summary>
    let EMMO_3cb55500_dc5b_4586_bbf3_1d4158afac35 =
        Namespaced_IRI.parse _namespace_name "EMMO_3cb55500_dc5b_4586_bbf3_1d4158afac35" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_3d254432_6f8f_4a6d_9eb3_4ab54388171b"></see></summary>
    let EMMO_3d254432_6f8f_4a6d_9eb3_4ab54388171b =
        Namespaced_IRI.parse _namespace_name "EMMO_3d254432_6f8f_4a6d_9eb3_4ab54388171b" |> NamespacedName

    /// <summary>
    /// Mass density ρ of a substance divided by the mass density ρ0 of a reference substance, under conditions that should be specified for both substances.
    /// <see href="https://w3id.org/emmo#EMMO_3d54c1e7_69d6_4736_92ff_595f31109f2a"></see></summary>
    let EMMO_3d54c1e7_69d6_4736_92ff_595f31109f2a =
        Namespaced_IRI.parse _namespace_name "EMMO_3d54c1e7_69d6_4736_92ff_595f31109f2a" |> NamespacedName

    /// <summary>
    /// Measure of probability that a specific process will take place in a collision of two particles.
    /// <see href="https://w3id.org/emmo#EMMO_3d77504a_a1fe_485f_aabb_6750598fe1ea"></see></summary>
    let EMMO_3d77504a_a1fe_485f_aabb_6750598fe1ea =
        Namespaced_IRI.parse _namespace_name "EMMO_3d77504a_a1fe_485f_aabb_6750598fe1ea" |> NamespacedName

    /// <summary>
    /// A dose quantity used in the International Commission on Radiological Protection (ICRP) system of radiological protection.
    /// <see href="https://w3id.org/emmo#EMMO_3df10765_f6ff_4c9e_be3d_10b1809d78bd"></see></summary>
    let EMMO_3df10765_f6ff_4c9e_be3d_10b1809d78bd =
        Namespaced_IRI.parse _namespace_name "EMMO_3df10765_f6ff_4c9e_be3d_10b1809d78bd" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AbsorbedDose'.
    /// <see href="https://w3id.org/emmo#EMMO_847f1d9f_205e_46c1_8cb6_a9e479421f88"></see></summary>
    let EMMO_847f1d9f_205e_46c1_8cb6_a9e479421f88 =
        Namespaced_IRI.parse _namespace_name "EMMO_847f1d9f_205e_46c1_8cb6_a9e479421f88" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperatureTime'.
    /// <see href="https://w3id.org/emmo#EMMO_3df1408c_df34_4037_8584_c25f854bb346"></see></summary>
    let EMMO_3df1408c_df34_4037_8584_c25f854bb346 =
        Namespaced_IRI.parse _namespace_name "EMMO_3df1408c_df34_4037_8584_c25f854bb346" |> NamespacedName

    /// <summary>
    /// 1/12 of the mass of an atom of the nuclide 12C in the ground state at rest.
    /// <see href="https://w3id.org/emmo#EMMO_3e1a8604_8d5a_470d_bb4a_865c65728986"></see></summary>
    let EMMO_3e1a8604_8d5a_470d_bb4a_865c65728986 =
        Namespaced_IRI.parse _namespace_name "EMMO_3e1a8604_8d5a_470d_bb4a_865c65728986" |> NamespacedName

    /// <summary>
    /// Physical constants are categorised into "exact" and measured constants.
    ///
    /// With "exact" constants, we refer to physical constants that have an exact numerical value after the revision of the SI system that was enforsed May 2019.
    /// <see href="https://w3id.org/emmo#EMMO_b953f2b1_c8d1_4dd9_b630_d3ef6580c2bb"></see></summary>
    let EMMO_b953f2b1_c8d1_4dd9_b630_d3ef6580c2bb =
        Namespaced_IRI.parse _namespace_name "EMMO_b953f2b1_c8d1_4dd9_b630_d3ef6580c2bb" |> NamespacedName

    /// <summary>
    /// Data that can be decoded under a quantitative schema and also associated with a graphical number symbols.
    /// <see href="https://w3id.org/emmo#EMMO_888a5dea_3b7d_4dc0_93f2_d4e345a1f903"></see></summary>
    let EMMO_888a5dea_3b7d_4dc0_93f2_d4e345a1f903 =
        Namespaced_IRI.parse _namespace_name "EMMO_888a5dea_3b7d_4dc0_93f2_d4e345a1f903" |> NamespacedName

    /// <summary>
    /// Data that are non-quantitatively interpreted (e.g., qualitative data, types).
    /// <see href="https://w3id.org/emmo#EMMO_ac1a05c5_0c17_4387_bac0_683f2a86f3ed"></see></summary>
    let EMMO_ac1a05c5_0c17_4387_bac0_683f2a86f3ed =
        Namespaced_IRI.parse _namespace_name "EMMO_ac1a05c5_0c17_4387_bac0_683f2a86f3ed" |> NamespacedName

    /// <summary>
    /// Data that are expressed through quantum mechanical principles, and that can have several values ​​/ be in several states in the same place at the same time (quantum superposition), each of them with a certain probability.
    /// <see href="https://w3id.org/emmo#EMMO_6fa1feac_c388_44cc_a721_283499d5addc"></see></summary>
    let EMMO_6fa1feac_c388_44cc_a721_283499d5addc =
        Namespaced_IRI.parse _namespace_name "EMMO_6fa1feac_c388_44cc_a721_283499d5addc" |> NamespacedName

    /// <summary>
    /// Data that are expressed through classical physics mechanisms, having one value and one state, and being in the same place at the same time.
    /// <see href="https://w3id.org/emmo#EMMO_ed257e78_8b59_44c3_9d61_06c261184f55"></see></summary>
    let EMMO_ed257e78_8b59_44c3_9d61_06c261184f55 =
        Namespaced_IRI.parse _namespace_name "EMMO_ed257e78_8b59_44c3_9d61_06c261184f55" |> NamespacedName

    /// <summary>
    /// Atom subclass for radium.
    /// <see href="https://w3id.org/emmo#EMMO_3ea9993c-80b9-5133-b552-dce78cd17ade"></see></summary>
    let ``EMMO_3ea9993c-80b9-5133-b552-dce78cd17ade`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3ea9993c-80b9-5133-b552-dce78cd17ade" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the radium atom.
    /// <see href="https://w3id.org/emmo#EMMO_9a24be51-7059-5306-af89-400c78a49e9c"></see></summary>
    let ``EMMO_9a24be51-7059-5306-af89-400c78a49e9c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_9a24be51-7059-5306-af89-400c78a49e9c" |> NamespacedName

    /// <summary>
    /// A unit that belongs to one or more unit systems.
    /// <see href="https://w3id.org/emmo#EMMO_3eb993a1_61ae_4a20_b168_dda853f51c14"></see></summary>
    let EMMO_3eb993a1_61ae_4a20_b168_dda853f51c14 =
        Namespaced_IRI.parse _namespace_name "EMMO_3eb993a1_61ae_4a20_b168_dda853f51c14" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Entropy'.
    /// <see href="https://w3id.org/emmo#EMMO_3ecff38b_b3cf_4a78_b49f_8580abf8715b"></see></summary>
    let EMMO_3ecff38b_b3cf_4a78_b49f_8580abf8715b =
        Namespaced_IRI.parse _namespace_name "EMMO_3ecff38b_b3cf_4a78_b49f_8580abf8715b" |> NamespacedName

    /// <summary>
    /// A vector quantity equal to the product of the current, the loop area, and the unit vector normal to the loop plane, the direction of which corresponds to the loop orientation
    /// <see href="https://w3id.org/emmo#EMMO_3ef37f82_cd1a_4d49_ace1_83b17487c8e2"></see></summary>
    let EMMO_3ef37f82_cd1a_4d49_ace1_83b17487c8e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_3ef37f82_cd1a_4d49_ace1_83b17487c8e2" |> NamespacedName

    /// <summary>
    /// For a given unit system, measured constants are physical constants that are not used to define the unit system. Hence, these constants have to be measured and will therefore be associated with an uncertainty.
    /// <see href="https://w3id.org/emmo#EMMO_3f15d200_c97b_42c8_8ac0_d81d150361e2"></see></summary>
    let EMMO_3f15d200_c97b_42c8_8ac0_d81d150361e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_3f15d200_c97b_42c8_8ac0_d81d150361e2" |> NamespacedName

    /// <summary>
    /// Atom subclass for roentgenium.
    /// <see href="https://w3id.org/emmo#EMMO_3f29d3e0-e9d9-5f1f-bd77-97af10125f7e"></see></summary>
    let ``EMMO_3f29d3e0-e9d9-5f1f-bd77-97af10125f7e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3f29d3e0-e9d9-5f1f-bd77-97af10125f7e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the roentgenium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c1102bae-7e7d-5142-95fe-ec25c8cb4903"></see></summary>
    let ``EMMO_c1102bae-7e7d-5142-95fe-ec25c8cb4903`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c1102bae-7e7d-5142-95fe-ec25c8cb4903" |> NamespacedName

    /// <summary>
    /// Radius of the electron orbital in the hydrogen atom in its ground state in the Bohr model of the atom.
    /// <see href="https://w3id.org/emmo#EMMO_3f2a669c_101b_428e_9cfc_0157986c36d5"></see></summary>
    let EMMO_3f2a669c_101b_428e_9cfc_0157986c36d5 =
        Namespaced_IRI.parse _namespace_name "EMMO_3f2a669c_101b_428e_9cfc_0157986c36d5" |> NamespacedName

    /// <summary>
    /// The mass that it seems to have when responding to forces, or the mass that it seems to have when interacting with other identical particles in a thermal distribution.
    /// <see href="https://w3id.org/emmo#EMMO_3f7feefd_ac94_4208_8dfd_92bb50be30f3"></see></summary>
    let EMMO_3f7feefd_ac94_4208_8dfd_92bb50be30f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_3f7feefd_ac94_4208_8dfd_92bb50be30f3" |> NamespacedName

    /// <summary>
    /// Number of particles of a given species per volume.
    /// <see href="https://w3id.org/emmo#EMMO_3f97cf06_fde4_4c2d_b867_d7983228a1ff"></see></summary>
    let EMMO_3f97cf06_fde4_4c2d_b867_d7983228a1ff =
        Namespaced_IRI.parse _namespace_name "EMMO_3f97cf06_fde4_4c2d_b867_d7983228a1ff" |> NamespacedName

    /// <summary>
    /// Number of molecules of a substance in a mixture per volume.
    /// <see href="https://w3id.org/emmo#EMMO_46406907_9afd_424e_934a_a523f9f9cc36"></see></summary>
    let EMMO_46406907_9afd_424e_934a_a523f9f9cc36 =
        Namespaced_IRI.parse _namespace_name "EMMO_46406907_9afd_424e_934a_a523f9f9cc36" |> NamespacedName

    /// <summary>
    /// Count per volume.
    /// <see href="https://w3id.org/emmo#EMMO_90a39fcb_5087_451e_a92e_ce0adc6d80f1"></see></summary>
    let EMMO_90a39fcb_5087_451e_a92e_ce0adc6d80f1 =
        Namespaced_IRI.parse _namespace_name "EMMO_90a39fcb_5087_451e_a92e_ce0adc6d80f1" |> NamespacedName

    /// <summary>
    /// Mean number of particles per volume.
    /// <see href="https://w3id.org/emmo#EMMO_e7ec6ee1_9de2_4791_a826_15b7682b6bee"></see></summary>
    let EMMO_e7ec6ee1_9de2_4791_a826_15b7682b6bee =
        Namespaced_IRI.parse _namespace_name "EMMO_e7ec6ee1_9de2_4791_a826_15b7682b6bee" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the scandium atom.
    /// <see href="https://w3id.org/emmo#EMMO_3fb231cb-7818-5b59-b8da-b5bd2c09c0fc"></see></summary>
    let ``EMMO_3fb231cb-7818-5b59-b8da-b5bd2c09c0fc`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3fb231cb-7818-5b59-b8da-b5bd2c09c0fc" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the seaborgium atom.
    /// <see href="https://w3id.org/emmo#EMMO_3fb44e47-7de9-5d86-9320-5949d8792951"></see></summary>
    let ``EMMO_3fb44e47-7de9-5d86-9320-5949d8792951`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3fb44e47-7de9-5d86-9320-5949d8792951" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthMass'.
    /// <see href="https://w3id.org/emmo#EMMO_3fe66e46_9343_4a36_b101_a732ad5f4f76"></see></summary>
    let EMMO_3fe66e46_9343_4a36_b101_a732ad5f4f76 =
        Namespaced_IRI.parse _namespace_name "EMMO_3fe66e46_9343_4a36_b101_a732ad5f4f76" |> NamespacedName

    /// <summary>
    /// Atom subclass for cobalt.
    /// <see href="https://w3id.org/emmo#EMMO_3fe9d899-f1f1-5657-b176-ac6afff2e93d"></see></summary>
    let ``EMMO_3fe9d899-f1f1-5657-b176-ac6afff2e93d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_3fe9d899-f1f1-5657-b176-ac6afff2e93d" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the cobalt atom.
    /// <see href="https://w3id.org/emmo#EMMO_4aa59242-76e7-5cce-a126-c7e9c657e7ad"></see></summary>
    let ``EMMO_4aa59242-76e7-5cce-a126-c7e9c657e7ad`` =
        Namespaced_IRI.parse _namespace_name "EMMO_4aa59242-76e7-5cce-a126-c7e9c657e7ad" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_4007522b_7ab7_4855_acd2_e99e2a0690b6"></see></summary>
    let EMMO_4007522b_7ab7_4855_acd2_e99e2a0690b6 =
        Namespaced_IRI.parse _namespace_name "EMMO_4007522b_7ab7_4855_acd2_e99e2a0690b6" |> NamespacedName

    /// <summary>
    /// vector quantity between any two points in space
    /// <see href="https://w3id.org/emmo#EMMO_4024a7f8_2991_4d80_bcc9_63705aa0c750"></see></summary>
    let EMMO_4024a7f8_2991_4d80_bcc9_63705aa0c750 =
        Namespaced_IRI.parse _namespace_name "EMMO_4024a7f8_2991_4d80_bcc9_63705aa0c750" |> NamespacedName

    /// <summary>
    /// The part is connected with the rest item or members with hasNext (or its inverse) and hasContact relations only.
    /// <see href="https://w3id.org/emmo#EMMO_408a46b2_3930_46da_b936_e9ce72ffdde9"></see></summary>
    let EMMO_408a46b2_3930_46da_b936_e9ce72ffdde9 =
        Namespaced_IRI.parse _namespace_name "EMMO_408a46b2_3930_46da_b936_e9ce72ffdde9" |> NamespacedName

    /// <summary>
    /// The part is not connected with the rest item or members with hasNext relation (or its inverse).
    /// <see href="https://w3id.org/emmo#EMMO_9a50a0ae_841a_46fe_8b23_3df319b60611"></see></summary>
    let EMMO_9a50a0ae_841a_46fe_8b23_3df319b60611 =
        Namespaced_IRI.parse _namespace_name "EMMO_9a50a0ae_841a_46fe_8b23_3df319b60611" |> NamespacedName

    /// <summary>
    /// Measurement of energy in a thermodynamic system.
    /// <see href="https://w3id.org/emmo#EMMO_4091d5ec_a4df_42b9_a073_9a090839279f"></see></summary>
    let EMMO_4091d5ec_a4df_42b9_a073_9a090839279f =
        Namespaced_IRI.parse _namespace_name "EMMO_4091d5ec_a4df_42b9_a073_9a090839279f" |> NamespacedName

    /// <summary>
    /// Quotient of Larmor angular frequency and 2π.
    /// <see href="https://w3id.org/emmo#EMMO_40923aa2_c600_44e4_8af8_80260ba25ab2"></see></summary>
    let EMMO_40923aa2_c600_44e4_8af8_80260ba25ab2 =
        Namespaced_IRI.parse _namespace_name "EMMO_40923aa2_c600_44e4_8af8_80260ba25ab2" |> NamespacedName

    /// <summary>
    /// For the dissociation of a salt AmBn → mA + nB, the solubility product is KSP = am(A) ⋅ an(B), where a is ionic activity and m and n are the stoichiometric numbers.
    /// Product of the ion activities of the ions resulting from the dissociation of a solute in a saturated solution, raised to powers equal to their stoichiometric numbers.
    /// <see href="https://w3id.org/emmo#EMMO_40989212_4866_41c0_8a20_84fd39540f29"></see></summary>
    let EMMO_40989212_4866_41c0_8a20_84fd39540f29 =
        Namespaced_IRI.parse _namespace_name "EMMO_40989212_4866_41c0_8a20_84fd39540f29" |> NamespacedName

    /// <summary>
    /// Number of electrons in conduction band per volume.
    /// <see href="https://w3id.org/emmo#EMMO_40a1d85c_bcfe_48aa_89a2_79e8a8c82af1"></see></summary>
    let EMMO_40a1d85c_bcfe_48aa_89a2_79e8a8c82af1 =
        Namespaced_IRI.parse _namespace_name "EMMO_40a1d85c_bcfe_48aa_89a2_79e8a8c82af1" |> NamespacedName

    /// <summary>
    /// An emulsion is a mixture of two or more liquids that are normally immiscible (a liquid-liquid heterogeneous mixture).
    /// <see href="https://w3id.org/emmo#EMMO_40e18c93_a1b5_49ff_b06a_d9d932d1fb65"></see></summary>
    let EMMO_40e18c93_a1b5_49ff_b06a_d9d932d1fb65 =
        Namespaced_IRI.parse _namespace_name "EMMO_40e18c93_a1b5_49ff_b06a_d9d932d1fb65" |> NamespacedName

    /// <summary>
    /// Atom subclass for arsenic.
    /// <see href="https://w3id.org/emmo#EMMO_41dba862-503f-57c2-86c7-bb40030481f0"></see></summary>
    let ``EMMO_41dba862-503f-57c2-86c7-bb40030481f0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_41dba862-503f-57c2-86c7-bb40030481f0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the bromine atom.
    /// <see href="https://w3id.org/emmo#EMMO_41ee55be-d0e9-5f39-86a6-36b81a7bc301"></see></summary>
    let ``EMMO_41ee55be-d0e9-5f39-86a6-36b81a7bc301`` =
        Namespaced_IRI.parse _namespace_name "EMMO_41ee55be-d0e9-5f39-86a6-36b81a7bc301" |> NamespacedName

    /// <summary>
    /// Discrete quantity; number of entities of a given kind in a system.
    /// <see href="https://w3id.org/emmo#EMMO_41efdf5d_0c9c_4ea0_bb65_f8236e663be5"></see></summary>
    let EMMO_41efdf5d_0c9c_4ea0_bb65_f8236e663be5 =
        Namespaced_IRI.parse _namespace_name "EMMO_41efdf5d_0c9c_4ea0_bb65_f8236e663be5" |> NamespacedName

    /// <summary>
    /// Atom subclass for lawrencium.
    /// <see href="https://w3id.org/emmo#EMMO_41f2ed3b-aba4-5b99-a5a1-547109a7cb4c"></see></summary>
    let ``EMMO_41f2ed3b-aba4-5b99-a5a1-547109a7cb4c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_41f2ed3b-aba4-5b99-a5a1-547109a7cb4c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the lawrencium atom.
    /// <see href="https://w3id.org/emmo#EMMO_f21db3a4-d5de-52dd-9460-5cdd138fb83f"></see></summary>
    let ``EMMO_f21db3a4-d5de-52dd-9460-5cdd138fb83f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f21db3a4-d5de-52dd-9460-5cdd138fb83f" |> NamespacedName

    /// <summary>
    /// Matter composed of only matter particles, excluding anti-matter particles.
    /// <see href="https://w3id.org/emmo#EMMO_6e9cb807_fc68_4bcf_b3ba_5fccc887c644"></see></summary>
    let EMMO_6e9cb807_fc68_4bcf_b3ba_5fccc887c644 =
        Namespaced_IRI.parse _namespace_name "EMMO_6e9cb807_fc68_4bcf_b3ba_5fccc887c644" |> NamespacedName

    /// <summary>
    /// A composite physical object made of fermions (i.e. having mass and occupying space).
    /// <see href="https://w3id.org/emmo#EMMO_bc37743c_37c4_4ec7_9d58_d1aae5567352"></see></summary>
    let EMMO_bc37743c_37c4_4ec7_9d58_d1aae5567352 =
        Namespaced_IRI.parse _namespace_name "EMMO_bc37743c_37c4_4ec7_9d58_d1aae5567352" |> NamespacedName

    /// <summary>
    /// An expression that provides information about the element types that constiture a molecule or a molecular substance and their number.
    /// <see href="https://w3id.org/emmo#EMMO_4208f937_8bad_47cf_af46_4ada75e63adb"></see></summary>
    let EMMO_4208f937_8bad_47cf_af46_4ada75e63adb =
        Namespaced_IRI.parse _namespace_name "EMMO_4208f937_8bad_47cf_af46_4ada75e63adb" |> NamespacedName

    /// <summary>
    /// A chemical formula may also include other symbols such as parentheses, plus and minus signs, brackets
    /// A symbolic construct that provides informations about the chemical proportions of the elements that constitute a chemical compound or a specific molecule.
    /// <see href="https://w3id.org/emmo#EMMO_9236d0aa_cb39_43a1_bbdd_6a2a714951c8"></see></summary>
    let EMMO_9236d0aa_cb39_43a1_bbdd_6a2a714951c8 =
        Namespaced_IRI.parse _namespace_name "EMMO_9236d0aa_cb39_43a1_bbdd_6a2a714951c8" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of gas in a liquid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_42185fe7_122c_4e0c_a3cd_659d3e21c389"></see></summary>
    let EMMO_42185fe7_122c_4e0c_a3cd_659d3e21c389 =
        Namespaced_IRI.parse _namespace_name "EMMO_42185fe7_122c_4e0c_a3cd_659d3e21c389" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "atto" (1e-18).
    /// <see href="https://w3id.org/emmo#EMMO_42955b2d_b465_4666_86cc_ea3c2d685753"></see></summary>
    let EMMO_42955b2d_b465_4666_86cc_ea3c2d685753 =
        Namespaced_IRI.parse _namespace_name "EMMO_42955b2d_b465_4666_86cc_ea3c2d685753" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-18.
    /// <see href="https://w3id.org/emmo#EMMO_e9722f13_947c_444e_82ef_1ce045f6637c"></see></summary>
    let EMMO_e9722f13_947c_444e_82ef_1ce045f6637c =
        Namespaced_IRI.parse _namespace_name "EMMO_e9722f13_947c_444e_82ef_1ce045f6637c" |> NamespacedName

    /// <summary>
    /// A task is a generic part of a workflow, without taking care of the task granularities.
    /// It means that you can declare that e.g. tightening a bolt is a task of building an airplane, without caring of the coarser tasks to which this tightening belongs.
    /// A procedure that is an hoilistic part of a workflow.
    /// <see href="https://w3id.org/emmo#EMMO_4299e344_a321_4ef2_a744_bacfcce80afc"></see></summary>
    let EMMO_4299e344_a321_4ef2_a744_bacfcce80afc =
        Namespaced_IRI.parse _namespace_name "EMMO_4299e344_a321_4ef2_a744_bacfcce80afc" |> NamespacedName

    /// <summary>
    /// A procedure that has at least two procedures (tasks) as proper parts.
    /// <see href="https://w3id.org/emmo#EMMO_64963ed6_39c9_4258_85e0_6466c4b5420c"></see></summary>
    let EMMO_64963ed6_39c9_4258_85e0_6466c4b5420c =
        Namespaced_IRI.parse _namespace_name "EMMO_64963ed6_39c9_4258_85e0_6466c4b5420c" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_70da982d_1810_4b01_9630_a28e216ecd9a"></see>
    /// </summary>
    let EMMO_70da982d_1810_4b01_9630_a28e216ecd9a =
        Namespaced_IRI.parse _namespace_name "EMMO_70da982d_1810_4b01_9630_a28e216ecd9a" |> NamespacedName

    /// <summary>
    /// A data representing an integer number &gt;= 0.
    /// <see href="https://w3id.org/emmo#EMMO_42eee73b_e4d2_4a0f_b468_3d2ce0475af6"></see></summary>
    let EMMO_42eee73b_e4d2_4a0f_b468_3d2ce0475af6 =
        Namespaced_IRI.parse _namespace_name "EMMO_42eee73b_e4d2_4a0f_b468_3d2ce0475af6" |> NamespacedName

    /// <summary>
    /// Shortest distance between two surfaces limiting a layer, when this distance can be considered to be constant over a region of a finite size.
    /// <see href="https://w3id.org/emmo#EMMO_43003c86_9d15_433b_9789_ee2940920656"></see></summary>
    let EMMO_43003c86_9d15_433b_9789_ee2940920656 =
        Namespaced_IRI.parse _namespace_name "EMMO_43003c86_9d15_433b_9789_ee2940920656" |> NamespacedName

    /// <summary>
    /// Vector quantity from the origin of a coordinate system to a point in space.
    /// <see href="https://w3id.org/emmo#EMMO_4312cae4_03ba_457e_b35d_0671a7db350c"></see></summary>
    let EMMO_4312cae4_03ba_457e_b35d_0671a7db350c =
        Namespaced_IRI.parse _namespace_name "EMMO_4312cae4_03ba_457e_b35d_0671a7db350c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'NewtonSquareMetrePerAmpere'.
    /// <see href="https://w3id.org/emmo#EMMO_431ce3bc_3d54_481d_a10d_7c4a4418732a"></see></summary>
    let EMMO_431ce3bc_3d54_481d_a10d_7c4a4418732a =
        Namespaced_IRI.parse _namespace_name "EMMO_431ce3bc_3d54_481d_a10d_7c4a4418732a" |> NamespacedName

    /// <summary>
    /// Symbol representing a spacing.
    /// <see href="https://w3id.org/emmo#EMMO_432192c4_111f_4e80_b7cd_c6ce1c1129ea"></see></summary>
    let EMMO_432192c4_111f_4e80_b7cd_c6ce1c1129ea =
        Namespaced_IRI.parse _namespace_name "EMMO_432192c4_111f_4e80_b7cd_c6ce1c1129ea" |> NamespacedName

    /// <summary>
    /// A type of sol in the form of one solid dispersed in liquid.
    /// <see href="https://w3id.org/emmo#EMMO_4354ac74_7425_43ab_92e4_6dc19d1afee9"></see></summary>
    let EMMO_4354ac74_7425_43ab_92e4_6dc19d1afee9 =
        Namespaced_IRI.parse _namespace_name "EMMO_4354ac74_7425_43ab_92e4_6dc19d1afee9" |> NamespacedName

    /// <summary>
    /// A chemical substance composed of atoms with the same number of protons in the atomic nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_436b11bd_1756_4821_9f14_c9ed6b67552e"></see></summary>
    let EMMO_436b11bd_1756_4821_9f14_c9ed6b67552e =
        Namespaced_IRI.parse _namespace_name "EMMO_436b11bd_1756_4821_9f14_c9ed6b67552e" |> NamespacedName

    /// <summary>
    /// A substance is always composed of more than one molecular entity. It lays in the continuum or mesoscopic domain.
    /// Matter of constant composition best characterized by the entities (molecules, formula units, atoms) it is composed of.
    /// <see href="https://w3id.org/emmo#EMMO_df96cbb6_b5ee_4222_8eab_b3675df24bea"></see></summary>
    let EMMO_df96cbb6_b5ee_4222_8eab_b3675df24bea =
        Namespaced_IRI.parse _namespace_name "EMMO_df96cbb6_b5ee_4222_8eab_b3675df24bea" |> NamespacedName

    /// <summary>
    /// Product of mass and velocity.
    /// <see href="https://w3id.org/emmo#EMMO_43776fc9_d712_4571_85f0_72183678039a"></see></summary>
    let EMMO_43776fc9_d712_4571_85f0_72183678039a =
        Namespaced_IRI.parse _namespace_name "EMMO_43776fc9_d712_4571_85f0_72183678039a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Momentum'.
    /// <see href="https://w3id.org/emmo#EMMO_ec987ba8_a548_4fc9_9df6_a834daebd140"></see></summary>
    let EMMO_ec987ba8_a548_4fc9_9df6_a834daebd140 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec987ba8_a548_4fc9_9df6_a834daebd140" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the dubnium atom.
    /// <see href="https://w3id.org/emmo#EMMO_43815c80-05dc-5917-8d52-b200badbf1d3"></see></summary>
    let ``EMMO_43815c80-05dc-5917-8d52-b200badbf1d3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_43815c80-05dc-5917-8d52-b200badbf1d3" |> NamespacedName

    /// <summary>
    /// A fundamental physical process is made of one or more standard particles as input, and one or more standard particles as output, where each input is direct cause of each output.
    /// Each fundamental physical phenomena refers to a Feynman diagram, hence is made at least of three standard model particles.
    /// This requirement implies that a physical phenomena is either a decay, annihilation, interaction, collapse or creation phenomena (fundamental) or a composition of them (non-fundamental).
    /// A causal system that is the representation of a Feynman diagram, where quantum represents the real particles entering and exiting the system.
    /// A fundamental system is expressed as a complete bipartite directed graph K(m,n) of quantums, m being the number of originating quantums, and n being the receiving quantums.
    /// <see href="https://w3id.org/emmo#EMMO_43a4e80d_6ae9_45ed_8cfb_fd0a5339bf87"></see></summary>
    let EMMO_43a4e80d_6ae9_45ed_8cfb_fd0a5339bf87 =
        Namespaced_IRI.parse _namespace_name "EMMO_43a4e80d_6ae9_45ed_8cfb_fd0a5339bf87" |> NamespacedName

    /// <summary>
    /// A causal interaction is a fundamental causal system that is expressed as a complete bupartite directed graph K(m,n), when m,n&gt;1
    /// <see href="https://w3id.org/emmo#EMMO_50afa1a9_2c4e_40fd_aa93_0e33511f1f27"></see></summary>
    let EMMO_50afa1a9_2c4e_40fd_aa93_0e33511f1f27 =
        Namespaced_IRI.parse _namespace_name "EMMO_50afa1a9_2c4e_40fd_aa93_0e33511f1f27" |> NamespacedName

    /// <summary>
    /// A collapse is a fundamental process occurring to one particle that is expressed as a complete bipartite directed graph K(1,n) with n&gt;1, being n the number of outgoing particles.
    /// <see href="https://w3id.org/emmo#EMMO_a9891fff_fa7a_4806_b7bd_786de7358e8d"></see></summary>
    let EMMO_a9891fff_fa7a_4806_b7bd_786de7358e8d =
        Namespaced_IRI.parse _namespace_name "EMMO_a9891fff_fa7a_4806_b7bd_786de7358e8d" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ThermalTransmittance'.
    /// <see href="https://w3id.org/emmo#EMMO_4b2c223f_89fb_4407_b1b6_24774b7fe770"></see></summary>
    let EMMO_4b2c223f_89fb_4407_b1b6_24774b7fe770 =
        Namespaced_IRI.parse _namespace_name "EMMO_4b2c223f_89fb_4407_b1b6_24774b7fe770" |> NamespacedName

    /// <summary>
    /// A variable that stand for a numerical constant, even if it is unknown.
    /// <see href="https://w3id.org/emmo#EMMO_8c64fcfa_23aa_45f8_9e58_bdfd065fab8f"></see></summary>
    let EMMO_8c64fcfa_23aa_45f8_9e58_bdfd065fab8f =
        Namespaced_IRI.parse _namespace_name "EMMO_8c64fcfa_23aa_45f8_9e58_bdfd065fab8f" |> NamespacedName

    /// <summary>
    /// A data representing 16-bit integer number.
    /// <see href="https://w3id.org/emmo#EMMO_443198a5_934c_44fa_b89e_28eca13b25b2"></see></summary>
    let EMMO_443198a5_934c_44fa_b89e_28eca13b25b2 =
        Namespaced_IRI.parse _namespace_name "EMMO_443198a5_934c_44fa_b89e_28eca13b25b2" |> NamespacedName

    /// <summary>
    /// Differential quotient of N with respect to time, where N is the number of particles being emitted from an infinitesimally small volume element in the time interval of duration dt, and dt.
    /// <see href="https://w3id.org/emmo#EMMO_444de087_cecb_4b21_a24c_529aa31e0f4a"></see></summary>
    let EMMO_444de087_cecb_4b21_a24c_529aa31e0f4a =
        Namespaced_IRI.parse _namespace_name "EMMO_444de087_cecb_4b21_a24c_529aa31e0f4a" |> NamespacedName

    /// <summary>
    /// A quantity defined as the inverse of time.
    /// <see href="https://w3id.org/emmo#EMMO_5f04b896_a4fd_4206_b201_0449b6c29289"></see></summary>
    let EMMO_5f04b896_a4fd_4206_b201_0449b6c29289 =
        Namespaced_IRI.parse _namespace_name "EMMO_5f04b896_a4fd_4206_b201_0449b6c29289" |> NamespacedName

    /// <summary>
    /// A physics-based model based on a physics equation describing the behaviour of continuum volume.
    /// <see href="https://w3id.org/emmo#EMMO_4456a5d2_16a6_4ee1_9a8e_5c75956b28ea"></see></summary>
    let EMMO_4456a5d2_16a6_4ee1_9a8e_5c75956b28ea =
        Namespaced_IRI.parse _namespace_name "EMMO_4456a5d2_16a6_4ee1_9a8e_5c75956b28ea" |> NamespacedName

    /// <summary>
    /// Fhe force of friction on an object that is not moving.
    /// <see href="https://w3id.org/emmo#EMMO_445d186f_1896_4752_8940_384f98440cfe"></see></summary>
    let EMMO_445d186f_1896_4752_8940_384f98440cfe =
        Namespaced_IRI.parse _namespace_name "EMMO_445d186f_1896_4752_8940_384f98440cfe" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_449beacd_4fda_4d46_a723_d2118f4e2623"></see>
    /// </summary>
    let EMMO_449beacd_4fda_4d46_a723_d2118f4e2623 =
        Namespaced_IRI.parse _namespace_name "EMMO_449beacd_4fda_4d46_a723_d2118f4e2623" |> NamespacedName

    /// <summary>
    /// Average value of the increment of the lethargy per collision.
    /// <see href="https://w3id.org/emmo#EMMO_44afb828_82bf_4091_a7a0_7c80ec47281d"></see></summary>
    let EMMO_44afb828_82bf_4091_a7a0_7c80ec47281d =
        Namespaced_IRI.parse _namespace_name "EMMO_44afb828_82bf_4091_a7a0_7c80ec47281d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_44d5f29a_6a9b_4f5d_9405_20ca553cd4d3"></see>
    /// </summary>
    let EMMO_44d5f29a_6a9b_4f5d_9405_20ca553cd4d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_44d5f29a_6a9b_4f5d_9405_20ca553cd4d3" |> NamespacedName

    /// <summary>
    /// Vector r characterizing a point P in a point space with a given origin point O.
    /// Position vectors are so-called bounded vectors, i.e. their magnitude and direction depend on the particular coordinate system used.
    ///
    /// -- ISO 80000-3
    /// In the usual geometrical three-dimensional space, position vectors are quantities of the dimension length.
    ///
    /// -- IEC
    /// <see href="https://w3id.org/emmo#EMMO_44da6d75_54a4_4aa8_bd3a_156f6e9abb8e"></see></summary>
    let EMMO_44da6d75_54a4_4aa8_bd3a_156f6e9abb8e =
        Namespaced_IRI.parse _namespace_name "EMMO_44da6d75_54a4_4aa8_bd3a_156f6e9abb8e" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthTimeTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_44ddbe46_0112_4185_b595_132866e902da"></see></summary>
    let EMMO_44ddbe46_0112_4185_b595_132866e902da =
        Namespaced_IRI.parse _namespace_name "EMMO_44ddbe46_0112_4185_b595_132866e902da" |> NamespacedName

    /// <summary>
    /// A manufacturing in which material is removed from the workpiece in the form of chips.
    /// <see href="https://w3id.org/emmo#EMMO_bfce8136_8f58_4ea5_ab3a_1734170c5d92"></see></summary>
    let EMMO_bfce8136_8f58_4ea5_ab3a_1734170c5d92 =
        Namespaced_IRI.parse _namespace_name "EMMO_bfce8136_8f58_4ea5_ab3a_1734170c5d92" |> NamespacedName

    /// <summary>
    /// The rest mass of an electron.
    /// <see href="https://w3id.org/emmo#EMMO_44fc8c60_7a9c_49af_a046_e1878c88862c"></see></summary>
    let EMMO_44fc8c60_7a9c_49af_a046_e1878c88862c =
        Namespaced_IRI.parse _namespace_name "EMMO_44fc8c60_7a9c_49af_a046_e1878c88862c" |> NamespacedName

    /// <summary>
    /// A manufacturing in which it is formed a solid body with its shape from shapeless original material parts, whose cohesion is created during the process.
    /// <see href="https://w3id.org/emmo#EMMO_dd4b7d81_28a9_4801_8831_4cbab217e362"></see></summary>
    let EMMO_dd4b7d81_28a9_4801_8831_4cbab217e362 =
        Namespaced_IRI.parse _namespace_name "EMMO_dd4b7d81_28a9_4801_8831_4cbab217e362" |> NamespacedName

    /// <summary>
    /// A set of one or more 'MeasuringInstruments' and often other devices, including any reagent and supply, assembled and adapted to give information used to generate 'MeasuredQuantityProperty' within specified intervals for quantities of specified kinds.
    ///
    /// -- VIM
    /// <see href="https://w3id.org/emmo#EMMO_7dea2572_ab42_45bd_9fd7_92448cec762a"></see></summary>
    let EMMO_7dea2572_ab42_45bd_9fd7_92448cec762a =
        Namespaced_IRI.parse _namespace_name "EMMO_7dea2572_ab42_45bd_9fd7_92448cec762a" |> NamespacedName

    /// <summary>
    /// Chosen value of amount concentration, usually equal to 1 mol dm−3.
    /// <see href="https://w3id.org/emmo#EMMO_46b8d239_5d79_4d3e_bf8e_228d52fc3428"></see></summary>
    let EMMO_46b8d239_5d79_4d3e_bf8e_228d52fc3428 =
        Namespaced_IRI.parse _namespace_name "EMMO_46b8d239_5d79_4d3e_bf8e_228d52fc3428" |> NamespacedName

    /// <summary>
    /// The amount of a constituent divided by the volume of the mixture.
    /// <see href="https://w3id.org/emmo#EMMO_d5be1faf_0c56_4f5a_9b78_581e6dee949f"></see></summary>
    let EMMO_d5be1faf_0c56_4f5a_9b78_581e6dee949f =
        Namespaced_IRI.parse _namespace_name "EMMO_d5be1faf_0c56_4f5a_9b78_581e6dee949f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_46d5643b_9706_4b67_8bea_ed77d6026539"></see>
    /// </summary>
    let EMMO_46d5643b_9706_4b67_8bea_ed77d6026539 =
        Namespaced_IRI.parse _namespace_name "EMMO_46d5643b_9706_4b67_8bea_ed77d6026539" |> NamespacedName

    /// <summary>
    /// A topological space with the property that each point has a neighborhood that is homeomorphic to an open subset of 3-dimensional Euclidean space.
    /// <see href="https://w3id.org/emmo#EMMO_46f0f8df_4dc6_418f_8036_10427a3a288e"></see></summary>
    let EMMO_46f0f8df_4dc6_418f_8036_10427a3a288e =
        Namespaced_IRI.parse _namespace_name "EMMO_46f0f8df_4dc6_418f_8036_10427a3a288e" |> NamespacedName

    /// <summary>
    /// A chemical entity comprises the two different ways to represents matter: as single recognizable particle entity (molecular entity) and as a composition of particle entities (substance).
    ///
    /// This distinction is not well assessed in actual chemical nomenclature, in which an element name refers to both the pure elemental substance or the atom.
    ///
    /// In the EMMO we force the adoption of a more strict categorization based on mereotopology.
    ///
    /// The class Material hosts the subclasses for which a substance can be identified without necessarily considering its nature of molecule/atom or substance (e.g. hydrocarbon is the class of both hydrocarbon molecules or gases).
    /// <see href="https://w3id.org/emmo#EMMO_47338839_6cca_4a8e_b565_3c4d5517e2c0"></see></summary>
    let EMMO_47338839_6cca_4a8e_b565_3c4d5517e2c0 =
        Namespaced_IRI.parse _namespace_name "EMMO_47338839_6cca_4a8e_b565_3c4d5517e2c0" |> NamespacedName

    /// <summary>
    /// Efficiency of an ideal heat engine operating according to the Carnot process.
    /// <see href="https://w3id.org/emmo#EMMO_476cb776_8219_418d_92e8_2fe04b1fe5cf"></see></summary>
    let EMMO_476cb776_8219_418d_92e8_2fe04b1fe5cf =
        Namespaced_IRI.parse _namespace_name "EMMO_476cb776_8219_418d_92e8_2fe04b1fe5cf" |> NamespacedName

    /// <summary>
    /// Distance in a superconductor over which the effect of a perturbation is appreciable at zero thermodynamic temperature
    /// <see href="https://w3id.org/emmo#EMMO_477042ef_3173_49b2_a264_0e3270733f8c"></see></summary>
    let EMMO_477042ef_3173_49b2_a264_0e3270733f8c =
        Namespaced_IRI.parse _namespace_name "EMMO_477042ef_3173_49b2_a264_0e3270733f8c" |> NamespacedName

    /// <summary>
    /// A material that is obtained through a manufacturing process.
    /// <see href="https://w3id.org/emmo#EMMO_ec7464a9_d99d_45f8_965b_4e9230ea8356"></see></summary>
    let EMMO_ec7464a9_d99d_45f8_965b_4e9230ea8356 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec7464a9_d99d_45f8_965b_4e9230ea8356" |> NamespacedName

    /// <summary>
    /// A declaration that provides a sign for an object that is independent from any assignment rule.
    /// <see href="https://w3id.org/emmo#EMMO_e999f9e0_7d63_4564_9028_07246580a267"></see></summary>
    let EMMO_e999f9e0_7d63_4564_9028_07246580a267 =
        Namespaced_IRI.parse _namespace_name "EMMO_e999f9e0_7d63_4564_9028_07246580a267" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_47eea65c_e6ce_4c95_9406_fdb1519abc87"></see>
    /// </summary>
    let EMMO_47eea65c_e6ce_4c95_9406_fdb1519abc87 =
        Namespaced_IRI.parse _namespace_name "EMMO_47eea65c_e6ce_4c95_9406_fdb1519abc87" |> NamespacedName

    /// <summary>
    /// Ngative quotient of Gibbs energy and temperature.
    /// <see href="https://w3id.org/emmo#EMMO_47f2da35_3b01_4290_964a_589c593e85c6"></see></summary>
    let EMMO_47f2da35_3b01_4290_964a_589c593e85c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_47f2da35_3b01_4290_964a_589c593e85c6" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of liquid in a liquid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_47fe2379_be21_48d1_9ede_402f0faf494b"></see></summary>
    let EMMO_47fe2379_be21_48d1_9ede_402f0faf494b =
        Namespaced_IRI.parse _namespace_name "EMMO_47fe2379_be21_48d1_9ede_402f0faf494b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaPerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_4817e479_e401_437e_a49b_54540b93d2a1"></see></summary>
    let EMMO_4817e479_e401_437e_a49b_54540b93d2a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_4817e479_e401_437e_a49b_54540b93d2a1" |> NamespacedName

    /// <summary>
    /// Arithmetic average of (electric field strength multiplied by electric flux density) and (magnetic field strength multiplied by magnetic flux density).
    /// <see href="https://w3id.org/emmo#EMMO_48540672_f1ee_4848_982f_0cd5ec396a84"></see></summary>
    let EMMO_48540672_f1ee_4848_982f_0cd5ec396a84 =
        Namespaced_IRI.parse _namespace_name "EMMO_48540672_f1ee_4848_982f_0cd5ec396a84" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Pressure'.
    /// <see href="https://w3id.org/emmo#EMMO_53bd0c90_41c3_46e2_8779_cd2a80f7e18b"></see></summary>
    let EMMO_53bd0c90_41c3_46e2_8779_cd2a80f7e18b =
        Namespaced_IRI.parse _namespace_name "EMMO_53bd0c90_41c3_46e2_8779_cd2a80f7e18b" |> NamespacedName

    /// <summary>
    /// Factor by which the intensity of a diffraction line is reduced because of the lattice vibrations.
    /// <see href="https://w3id.org/emmo#EMMO_485720e7_b24a_4149_86eb_9985b2bea4da"></see></summary>
    let EMMO_485720e7_b24a_4149_86eb_9985b2bea4da =
        Namespaced_IRI.parse _namespace_name "EMMO_485720e7_b24a_4149_86eb_9985b2bea4da" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the europium atom.
    /// <see href="https://w3id.org/emmo#EMMO_4894a40d-6bf5-54a2-8b21-e9b278e0e973"></see></summary>
    let ``EMMO_4894a40d-6bf5-54a2-8b21-e9b278e0e973`` =
        Namespaced_IRI.parse _namespace_name "EMMO_4894a40d-6bf5-54a2-8b21-e9b278e0e973" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaTimeTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_48a3c106_9d39_455e_a849_81ceff95bdea"></see></summary>
    let EMMO_48a3c106_9d39_455e_a849_81ceff95bdea =
        Namespaced_IRI.parse _namespace_name "EMMO_48a3c106_9d39_455e_a849_81ceff95bdea" |> NamespacedName

    /// <summary>
    /// Atom subclass for oxygen.
    /// <see href="https://w3id.org/emmo#EMMO_48be0f49-9e7f-51c1-96ce-88e7794a13b0"></see></summary>
    let ``EMMO_48be0f49-9e7f-51c1-96ce-88e7794a13b0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_48be0f49-9e7f-51c1-96ce-88e7794a13b0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the oxygen atom.
    /// <see href="https://w3id.org/emmo#EMMO_96fb9a6c-80d6-57fa-a4f2-0d2a59232418"></see></summary>
    let ``EMMO_96fb9a6c-80d6-57fa-a4f2-0d2a59232418`` =
        Namespaced_IRI.parse _namespace_name "EMMO_96fb9a6c-80d6-57fa-a4f2-0d2a59232418" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricFlux'.
    /// <see href="https://w3id.org/emmo#EMMO_48f00c52_8d3d_4e80_8d88_59fabaa01d87"></see></summary>
    let EMMO_48f00c52_8d3d_4e80_8d88_59fabaa01d87 =
        Namespaced_IRI.parse _namespace_name "EMMO_48f00c52_8d3d_4e80_8d88_59fabaa01d87" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1/1000.
    /// <see href="https://w3id.org/emmo#EMMO_49adf406_5c8f_498a_8c90_e4974e9e6d11"></see></summary>
    let EMMO_49adf406_5c8f_498a_8c90_e4974e9e6d11 =
        Namespaced_IRI.parse _namespace_name "EMMO_49adf406_5c8f_498a_8c90_e4974e9e6d11" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-30.
    /// <see href="https://w3id.org/emmo#EMMO_556e27cd_fef1_41c9_824a_dd78980062b5"></see></summary>
    let EMMO_556e27cd_fef1_41c9_824a_dd78980062b5 =
        Namespaced_IRI.parse _namespace_name "EMMO_556e27cd_fef1_41c9_824a_dd78980062b5" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-6.
    /// <see href="https://w3id.org/emmo#EMMO_6da1b965_768c_4cf0_8873_44f2035133ba"></see></summary>
    let EMMO_6da1b965_768c_4cf0_8873_44f2035133ba =
        Namespaced_IRI.parse _namespace_name "EMMO_6da1b965_768c_4cf0_8873_44f2035133ba" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-24.
    /// <see href="https://w3id.org/emmo#EMMO_7abfbbc4_ce7b_4611_b731_1b5b8bd2bbc0"></see></summary>
    let EMMO_7abfbbc4_ce7b_4611_b731_1b5b8bd2bbc0 =
        Namespaced_IRI.parse _namespace_name "EMMO_7abfbbc4_ce7b_4611_b731_1b5b8bd2bbc0" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-9.
    /// <see href="https://w3id.org/emmo#EMMO_afb29c1a_eba4_4ba7_b6a1_62e9023c94ec"></see></summary>
    let EMMO_afb29c1a_eba4_4ba7_b6a1_62e9023c94ec =
        Namespaced_IRI.parse _namespace_name "EMMO_afb29c1a_eba4_4ba7_b6a1_62e9023c94ec" |> NamespacedName

    /// <summary>
    /// SI prefix who's value is 1e-27.
    /// <see href="https://w3id.org/emmo#EMMO_fbc2549b_9108_467a_a573_de48eb45cc4a"></see></summary>
    let EMMO_fbc2549b_9108_467a_a573_de48eb45cc4a =
        Namespaced_IRI.parse _namespace_name "EMMO_fbc2549b_9108_467a_a573_de48eb45cc4a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the tennessine atom.
    /// <see href="https://w3id.org/emmo#EMMO_490c2981-b1cb-5f8c-be82-17a1ef1c27b4"></see></summary>
    let ``EMMO_490c2981-b1cb-5f8c-be82-17a1ef1c27b4`` =
        Namespaced_IRI.parse _namespace_name "EMMO_490c2981-b1cb-5f8c-be82-17a1ef1c27b4" |> NamespacedName

    /// <summary>
    /// A process which is an holistic spatial part of a process.
    /// In the EMMO the relation of participation to a process falls under mereotopology.
    ///
    /// Since topological connection means causality, then the only way for a real world object to participate to a process is to be a part of it.
    /// <see href="https://w3id.org/emmo#EMMO_49804605_c0fe_4538_abda_f70ba1dc8a5d"></see></summary>
    let EMMO_49804605_c0fe_4538_abda_f70ba1dc8a5d =
        Namespaced_IRI.parse _namespace_name "EMMO_49804605_c0fe_4538_abda_f70ba1dc8a5d" |> NamespacedName

    /// <summary>
    /// A suspension of liquid droplets dispersed in a gas through an atomization process.
    /// <see href="https://w3id.org/emmo#EMMO_498aad49_f8d4_40a4_a9eb_efd563a0115f"></see></summary>
    let EMMO_498aad49_f8d4_40a4_a9eb_efd563a0115f =
        Namespaced_IRI.parse _namespace_name "EMMO_498aad49_f8d4_40a4_a9eb_efd563a0115f" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of liquid in a gas continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_e0edfb9e_9a96_4fae_b942_831ffe27b84a"></see></summary>
    let EMMO_e0edfb9e_9a96_4fae_b942_831ffe27b84a =
        Namespaced_IRI.parse _namespace_name "EMMO_e0edfb9e_9a96_4fae_b942_831ffe27b84a" |> NamespacedName

    /// <summary>
    /// Direct cause is irreflexive.
    /// A causal relation between the causing and the effected entities occurring without intermediaries.
    /// Direct causality is a concept that capture the idea of contact between two entities, given the fact that there are no causal intermediaries between them. It requires that at least a quantum of the causing entity is direct cause of a quantum of the caused entity.
    /// It does not exclude the possibility of indirect causal routes between proper parts of the two entities.
    /// <see href="https://w3id.org/emmo#EMMO_555d0261_da5e_4301_b7f9_46f604a32e91"></see></summary>
    let EMMO_555d0261_da5e_4301_b7f9_46f604a32e91 =
        Namespaced_IRI.parse _namespace_name "EMMO_555d0261_da5e_4301_b7f9_46f604a32e91" |> NamespacedName

    /// <summary>
    /// An interaction that is the sum of direct causality relations between two entities that are interpretable as fundamental physical interactions.
    /// Spatial contact is symmetric and irreflexive.
    /// A spatial contact between two entities occurs when the two entities are in an interaction relation whose causal structure is a representation of the fundamental interactions between elementary particles (Feynman diagrams).
    /// It means that if two entities are in contact, then there is at least a couple of elementary particles, one part of the first and one part of the second, interacting according to one of the fundamental interactions through virtual particles. This kind of connection is space-like (i.e. interconnecting force carrier particle is offshelf).
    /// Contacts between two entities exclude the possibility of other causal relations that are not included in a fundamental space-like interaction.
    /// <see href="https://w3id.org/emmo#EMMO_8785be5a_2493_4b12_8f39_31907ab11748"></see></summary>
    let EMMO_8785be5a_2493_4b12_8f39_31907ab11748 =
        Namespaced_IRI.parse _namespace_name "EMMO_8785be5a_2493_4b12_8f39_31907ab11748" |> NamespacedName

    /// <summary>
    /// Atom subclass for nobelium.
    /// <see href="https://w3id.org/emmo#EMMO_49eb0790-50c2-5691-a8bf-dfa6f4a9f6c7"></see></summary>
    let ``EMMO_49eb0790-50c2-5691-a8bf-dfa6f4a9f6c7`` =
        Namespaced_IRI.parse _namespace_name "EMMO_49eb0790-50c2-5691-a8bf-dfa6f4a9f6c7" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the nobelium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c1bb775c-0888-5b88-9cce-c49bae1d298b"></see></summary>
    let ``EMMO_c1bb775c-0888-5b88-9cce-c49bae1d298b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c1bb775c-0888-5b88-9cce-c49bae1d298b" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of gas in a solid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_c457b6b9_5e73_4853_ae08_d776c12b8058"></see></summary>
    let EMMO_c457b6b9_5e73_4853_ae08_d776c12b8058 =
        Namespaced_IRI.parse _namespace_name "EMMO_c457b6b9_5e73_4853_ae08_d776c12b8058" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of solid in a gas continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_d4f37e32_16ae_4cc6_b4cd_fd896b2449c4"></see></summary>
    let EMMO_d4f37e32_16ae_4cc6_b4cd_fd896b2449c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_d4f37e32_16ae_4cc6_b4cd_fd896b2449c4" |> NamespacedName

    /// <summary>
    /// A coarse dispersion of solids in a liquid continuum phase.
    /// <see href="https://w3id.org/emmo#EMMO_e9e02156_651f_41c8_9efb_d5da0d4ce5e2"></see></summary>
    let EMMO_e9e02156_651f_41c8_9efb_d5da0d4ce5e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_e9e02156_651f_41c8_9efb_d5da0d4ce5e2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4ab7fb52_cec3_4c00_90c0_5648f01e3296"></see>
    /// </summary>
    let EMMO_4ab7fb52_cec3_4c00_90c0_5648f01e3296 =
        Namespaced_IRI.parse _namespace_name "EMMO_4ab7fb52_cec3_4c00_90c0_5648f01e3296" |> NamespacedName

    /// <summary>
    /// 'acoustical' refers to the perception mechanism of the observer that can occur through a microphone, a ear.
    /// A 'Perceptual' which stands for a real world object whose spatiotemporal pattern makes it identifiable by an observer as a sound.
    /// <see href="https://w3id.org/emmo#EMMO_4b3afb22_27cf_4ce3_88bc_492bfccb546b"></see></summary>
    let EMMO_4b3afb22_27cf_4ce3_88bc_492bfccb546b =
        Namespaced_IRI.parse _namespace_name "EMMO_4b3afb22_27cf_4ce3_88bc_492bfccb546b" |> NamespacedName

    /// <summary>
    /// A liquid solution made of two or more component substances.
    /// <see href="https://w3id.org/emmo#EMMO_4b3e2374_52a1_4420_8e3f_3ae6b9bf7dff"></see></summary>
    let EMMO_4b3e2374_52a1_4420_8e3f_3ae6b9bf7dff =
        Namespaced_IRI.parse _namespace_name "EMMO_4b3e2374_52a1_4420_8e3f_3ae6b9bf7dff" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4b77c8ac_6d0e_456a_af41_ce43601b28b7"></see>
    /// </summary>
    let EMMO_4b77c8ac_6d0e_456a_af41_ce43601b28b7 =
        Namespaced_IRI.parse _namespace_name "EMMO_4b77c8ac_6d0e_456a_af41_ce43601b28b7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ae3c9eb3_289d_4133_99d6_77068367a58d"></see>
    /// </summary>
    let EMMO_ae3c9eb3_289d_4133_99d6_77068367a58d =
        Namespaced_IRI.parse _namespace_name "EMMO_ae3c9eb3_289d_4133_99d6_77068367a58d" |> NamespacedName

    /// <summary>
    /// A function defined using functional notation.
    /// A mathematical relation that relates each element in the domain (X) to exactly one element in the range (Y).
    /// <see href="https://w3id.org/emmo#EMMO_4bc29b0f_8fcc_4026_a291_f9774a66d9b8"></see></summary>
    let EMMO_4bc29b0f_8fcc_4026_a291_f9774a66d9b8 =
        Namespaced_IRI.parse _namespace_name "EMMO_4bc29b0f_8fcc_4026_a291_f9774a66d9b8" |> NamespacedName

    /// <summary>
    /// A measurement unit that is made of a metric prefix and a unit symbol.
    /// <see href="https://w3id.org/emmo#EMMO_c6d4a5e0_7e95_44df_a6db_84ee0a8bbc8e"></see></summary>
    let EMMO_c6d4a5e0_7e95_44df_a6db_84ee0a8bbc8e =
        Namespaced_IRI.parse _namespace_name "EMMO_c6d4a5e0_7e95_44df_a6db_84ee0a8bbc8e" |> NamespacedName

    /// <summary>
    /// The energy possessed by a body by virtue of its position or orientation in a potential field.
    /// <see href="https://w3id.org/emmo#EMMO_4c151909_6f26_4ef9_b43d_7c9e9514883a"></see></summary>
    let EMMO_4c151909_6f26_4ef9_b43d_7c9e9514883a =
        Namespaced_IRI.parse _namespace_name "EMMO_4c151909_6f26_4ef9_b43d_7c9e9514883a" |> NamespacedName

    /// <summary>
    /// A fluid in which a gas is ionized to a level where its electrical conductivity allows long-range electric and magnetic fields to dominate its behaviour.
    /// <see href="https://w3id.org/emmo#EMMO_4c21fb86_fdcf_444e_b498_86fe656295af"></see></summary>
    let EMMO_4c21fb86_fdcf_444e_b498_86fe656295af =
        Namespaced_IRI.parse _namespace_name "EMMO_4c21fb86_fdcf_444e_b498_86fe656295af" |> NamespacedName

    /// <summary>
    /// Quotient of the thermal diffusion ratio and the product of the local amount-of-substance fractions.
    /// <see href="https://w3id.org/emmo#EMMO_4c3ccf65_0950_4328_b04b_91d1eaa14681"></see></summary>
    let EMMO_4c3ccf65_0950_4328_b04b_91d1eaa14681 =
        Namespaced_IRI.parse _namespace_name "EMMO_4c3ccf65_0950_4328_b04b_91d1eaa14681" |> NamespacedName

    /// <summary>
    /// In a steady-state of a binary mixture in which thermal diffusion occurs; proportionality factor between gradient of the amount-of-subsstance fraction of the heavier substance B, and negative gradient of the local thermodynamic temperature divided by that temperature.
    /// <see href="https://w3id.org/emmo#EMMO_e84be61e_6f6f_43e2_b91d_86898a5dc7c4"></see></summary>
    let EMMO_e84be61e_6f6f_43e2_b91d_86898a5dc7c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_e84be61e_6f6f_43e2_b91d_86898a5dc7c4" |> NamespacedName

    /// <summary>
    /// Sum of the product of the proton number and the hydrogen atomic mass, and the neutron rest mass, minus the rest mass of the atom.
    /// <see href="https://w3id.org/emmo#EMMO_4cdec724_8ed2_4e8e_b145_260a828bb1ed"></see></summary>
    let EMMO_4cdec724_8ed2_4e8e_b145_260a828bb1ed =
        Namespaced_IRI.parse _namespace_name "EMMO_4cdec724_8ed2_4e8e_b145_260a828bb1ed" |> NamespacedName

    /// <summary>
    /// A group of machineries used to process a group of similar parts.
    /// Is not simply a collection of machineries, since the connection between them is due to the parallel flow of processed parts that comes from a unique source and ends into a common repository.
    /// <see href="https://w3id.org/emmo#EMMO_4d2ca841_6cb1_4710_a756_5b989746bca2"></see></summary>
    let EMMO_4d2ca841_6cb1_4710_a756_5b989746bca2 =
        Namespaced_IRI.parse _namespace_name "EMMO_4d2ca841_6cb1_4710_a756_5b989746bca2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4d5053a7_273e_495b_8098_5aa5c0f3f925"></see>
    /// </summary>
    let EMMO_4d5053a7_273e_495b_8098_5aa5c0f3f925 =
        Namespaced_IRI.parse _namespace_name "EMMO_4d5053a7_273e_495b_8098_5aa5c0f3f925" |> NamespacedName

    /// <summary>
    /// Sum of the slowing-down area from fission energy to thermal energy and the diffusion area for thermal neutrons.
    /// <see href="https://w3id.org/emmo#EMMO_4d548993_7a73_4cb1_a125_d417014b571e"></see></summary>
    let EMMO_4d548993_7a73_4cb1_a125_d417014b571e =
        Namespaced_IRI.parse _namespace_name "EMMO_4d548993_7a73_4cb1_a125_d417014b571e" |> NamespacedName

    /// <summary>
    /// Extent of a surface.
    /// <see href="https://w3id.org/emmo#EMMO_96f39f77_44dc_491b_8fa7_30d887fe0890"></see></summary>
    let EMMO_96f39f77_44dc_491b_8fa7_30d887fe0890 =
        Namespaced_IRI.parse _namespace_name "EMMO_96f39f77_44dc_491b_8fa7_30d887fe0890" |> NamespacedName

    /// <summary>
    /// A liquid aerosol composed of water droplets in air or another gas.
    /// <see href="https://w3id.org/emmo#EMMO_4d604a13_d1f6_42fd_818f_d3138d5e308c"></see></summary>
    let EMMO_4d604a13_d1f6_42fd_818f_d3138d5e308c =
        Namespaced_IRI.parse _namespace_name "EMMO_4d604a13_d1f6_42fd_818f_d3138d5e308c" |> NamespacedName

    /// <summary>
    /// An aerosol composed of liquid droplets in air or another gas.
    /// <see href="https://w3id.org/emmo#EMMO_94010cbc_c2a6_4cb9_b29a_83aa99d2ff70"></see></summary>
    let EMMO_94010cbc_c2a6_4cb9_b29a_83aa99d2ff70 =
        Namespaced_IRI.parse _namespace_name "EMMO_94010cbc_c2a6_4cb9_b29a_83aa99d2ff70" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4e099d7e_f624_4761_aff6_2ee6c63b8d2d"></see>
    /// </summary>
    let EMMO_4e099d7e_f624_4761_aff6_2ee6c63b8d2d =
        Namespaced_IRI.parse _namespace_name "EMMO_4e099d7e_f624_4761_aff6_2ee6c63b8d2d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4e659c69_ca2d_4569_8a96_f99857a1fa32"></see>
    /// </summary>
    let EMMO_4e659c69_ca2d_4569_8a96_f99857a1fa32 =
        Namespaced_IRI.parse _namespace_name "EMMO_4e659c69_ca2d_4569_8a96_f99857a1fa32" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4e6c4c25_e937_40d5_9cd1_0f3b740cc0a8"></see>
    /// </summary>
    let EMMO_4e6c4c25_e937_40d5_9cd1_0f3b740cc0a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_4e6c4c25_e937_40d5_9cd1_0f3b740cc0a8" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the antimony atom.
    /// <see href="https://w3id.org/emmo#EMMO_4ee57a22-0634-5889-a283-0b4f8e5023f6"></see></summary>
    let ``EMMO_4ee57a22-0634-5889-a283-0b4f8e5023f6`` =
        Namespaced_IRI.parse _namespace_name "EMMO_4ee57a22-0634-5889-a283-0b4f8e5023f6" |> NamespacedName

    /// <summary>
    /// A language object that follows the syntactic rules used in the chemical field.
    /// <see href="https://w3id.org/emmo#EMMO_abf7efbe_6b04_41b8_8326_4dd0f6be753e"></see></summary>
    let EMMO_abf7efbe_6b04_41b8_8326_4dd0f6be753e =
        Namespaced_IRI.parse _namespace_name "EMMO_abf7efbe_6b04_41b8_8326_4dd0f6be753e" |> NamespacedName

    /// <summary>
    /// One minus the square of the coupling factor
    /// <see href="https://w3id.org/emmo#EMMO_4f75924f_782d_4a9d_995f_43ae968fe5e2"></see></summary>
    let EMMO_4f75924f_782d_4a9d_995f_43ae968fe5e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_4f75924f_782d_4a9d_995f_43ae968fe5e2" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the silicon atom.
    /// <see href="https://w3id.org/emmo#EMMO_4f9670f5-14ca-53da-a1ea-9b0550a61035"></see></summary>
    let ``EMMO_4f9670f5-14ca-53da-a1ea-9b0550a61035`` =
        Namespaced_IRI.parse _namespace_name "EMMO_4f9670f5-14ca-53da-a1ea-9b0550a61035" |> NamespacedName

    /// <summary>
    /// Inverse of the impendance.
    /// <see href="https://w3id.org/emmo#EMMO_4fb35ebc_0f3f_4cda_b181_a5334bc2b114"></see></summary>
    let EMMO_4fb35ebc_0f3f_4cda_b181_a5334bc2b114 =
        Namespaced_IRI.parse _namespace_name "EMMO_4fb35ebc_0f3f_4cda_b181_a5334bc2b114" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyTimePerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_4fdf946a_9c40_4d71_80ab_e4221ff6a534"></see></summary>
    let EMMO_4fdf946a_9c40_4d71_80ab_e4221ff6a534 =
        Namespaced_IRI.parse _namespace_name "EMMO_4fdf946a_9c40_4d71_80ab_e4221ff6a534" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AngularMomentum'.
    /// <see href="https://w3id.org/emmo#EMMO_501f9b3a_c469_48f7_9281_2e6a8d805d7a"></see></summary>
    let EMMO_501f9b3a_c469_48f7_9281_2e6a8d805d7a =
        Namespaced_IRI.parse _namespace_name "EMMO_501f9b3a_c469_48f7_9281_2e6a8d805d7a" |> NamespacedName

    /// <summary>
    /// Defines the Candela base unit in the SI system.
    /// The luminous efficacy of monochromatic radiation of frequency 540 × 10 12 Hz, K cd , is a technical constant that gives an exact numerical relationship between the purely physical characteristics of the radiant power stimulating the human eye (W) and its photobiological response defined by the luminous flux due to the spectral responsivity of a standard observer (lm) at a frequency of 540 × 10 12 hertz.
    /// <see href="https://w3id.org/emmo#EMMO_506f7823_52bc_40cb_be07_b3b1e10cce13"></see></summary>
    let EMMO_506f7823_52bc_40cb_be07_b3b1e10cce13 =
        Namespaced_IRI.parse _namespace_name "EMMO_506f7823_52bc_40cb_be07_b3b1e10cce13" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticDipoleMoment'.
    /// <see href="https://w3id.org/emmo#EMMO_5073dc80_aec2_4a3b_8057_fababfcbfe11"></see></summary>
    let EMMO_5073dc80_aec2_4a3b_8057_fababfcbfe11 =
        Namespaced_IRI.parse _namespace_name "EMMO_5073dc80_aec2_4a3b_8057_fababfcbfe11" |> NamespacedName

    /// <summary>
    /// Either a proton or a neutron.
    /// <see href="https://w3id.org/emmo#EMMO_50781fd9_a9e4_46ad_b7be_4500371d188d"></see></summary>
    let EMMO_50781fd9_a9e4_46ad_b7be_4500371d188d =
        Namespaced_IRI.parse _namespace_name "EMMO_50781fd9_a9e4_46ad_b7be_4500371d188d" |> NamespacedName

    /// <summary>
    /// A positive charged subatomic particle found in the atomic nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_8f87e700_99a8_4427_8ffb_e493de05c217"></see></summary>
    let EMMO_8f87e700_99a8_4427_8ffb_e493de05c217 =
        Namespaced_IRI.parse _namespace_name "EMMO_8f87e700_99a8_4427_8ffb_e493de05c217" |> NamespacedName

    /// <summary>
    /// An uncharged subatomic particle found in the atomic nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_df808271_df91_4f27_ba59_fa423c51896c"></see></summary>
    let EMMO_df808271_df91_4f27_ba59_fa423c51896c =
        Namespaced_IRI.parse _namespace_name "EMMO_df808271_df91_4f27_ba59_fa423c51896c" |> NamespacedName

    /// <summary>
    /// A symbol that stands for a concept in the language of the meterological domain of ISO 80000.
    /// <see href="https://w3id.org/emmo#EMMO_50a3552e_859a_4ff7_946d_76d537cabce6"></see></summary>
    let EMMO_50a3552e_859a_4ff7_946d_76d537cabce6 =
        Namespaced_IRI.parse _namespace_name "EMMO_50a3552e_859a_4ff7_946d_76d537cabce6" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-8.
    /// <see href="https://w3id.org/emmo#EMMO_50b91f00_d1b3_4638_ab1e_8f982a37621a"></see></summary>
    let EMMO_50b91f00_d1b3_4638_ab1e_8f982a37621a =
        Namespaced_IRI.parse _namespace_name "EMMO_50b91f00_d1b3_4638_ab1e_8f982a37621a" |> NamespacedName

    /// <summary>
    /// Quantities categorised according to ISO 80000-7.
    /// <see href="https://w3id.org/emmo#EMMO_ec1aa2cd_74eb_4506_81d1_901a3124aaba"></see></summary>
    let EMMO_ec1aa2cd_74eb_4506_81d1_901a3124aaba =
        Namespaced_IRI.parse _namespace_name "EMMO_ec1aa2cd_74eb_4506_81d1_901a3124aaba" |> NamespacedName

    /// <summary>
    /// Measure of how resistant to compressibility a substance is.
    /// <see href="https://w3id.org/emmo#EMMO_50dbbf9a_ed96_486f_99f6_d8ba78a0047c"></see></summary>
    let EMMO_50dbbf9a_ed96_486f_99f6_d8ba78a0047c =
        Namespaced_IRI.parse _namespace_name "EMMO_50dbbf9a_ed96_486f_99f6_d8ba78a0047c" |> NamespacedName

    /// <summary>
    /// A physical made of more than one symbol sequentially arranged.
    /// A string is made of concatenated symbols whose arrangement is one-dimensional. Each symbol can have only one previous and one next neighborhood (bidirectional list).
    /// <see href="https://w3id.org/emmo#EMMO_50ea1ec5_f157_41b0_b46b_a9032f17ca10"></see></summary>
    let EMMO_50ea1ec5_f157_41b0_b46b_a9032f17ca10 =
        Namespaced_IRI.parse _namespace_name "EMMO_50ea1ec5_f157_41b0_b46b_a9032f17ca10" |> NamespacedName

    /// <summary>
    /// E_0 = m_0 * c_0^2
    ///
    /// where m_0 is the rest mass of that particle and c_0 is the speed of light in a vacuum.
    /// Product of the rest mass and the square of the speed of light in vacuum.
    /// <see href="https://w3id.org/emmo#EMMO_5117c5fe_f661_46f8_83c3_b48947f1532a"></see></summary>
    let EMMO_5117c5fe_f661_46f8_83c3_b48947f1532a =
        Namespaced_IRI.parse _namespace_name "EMMO_5117c5fe_f661_46f8_83c3_b48947f1532a" |> NamespacedName

    /// <summary>
    /// A command must be interpretable by the computer system.
    /// An instruction to a computer system to perform a given task.
    /// <see href="https://w3id.org/emmo#EMMO_51645022_3a21_4fa9_a9ce_a795eebbeca7"></see></summary>
    let EMMO_51645022_3a21_4fa9_a9ce_a795eebbeca7 =
        Namespaced_IRI.parse _namespace_name "EMMO_51645022_3a21_4fa9_a9ce_a795eebbeca7" |> NamespacedName

    /// <summary>
    /// Position vector of a particle.
    /// <see href="https://w3id.org/emmo#EMMO_5186b2e6_f34f_46ee_b08e_ec517a1f43d2"></see></summary>
    let EMMO_5186b2e6_f34f_46ee_b08e_ec517a1f43d2 =
        Namespaced_IRI.parse _namespace_name "EMMO_5186b2e6_f34f_46ee_b08e_ec517a1f43d2" |> NamespacedName

    /// <summary>
    /// Under periodic conditions, ratio of the absolute value of the active power P to the apparent power S.
    /// <see href="https://w3id.org/emmo#EMMO_51acadf5_b874_46c1_9707_24e25e2b89ff"></see></summary>
    let EMMO_51acadf5_b874_46c1_9707_24e25e2b89ff =
        Namespaced_IRI.parse _namespace_name "EMMO_51acadf5_b874_46c1_9707_24e25e2b89ff" |> NamespacedName

    /// <summary>
    /// Proportionality constant between the particle current density J and the gradient of the particle fluence rate.
    /// <see href="https://w3id.org/emmo#EMMO_51c4190e_dc9a_4292_968c_b36f7fb68912"></see></summary>
    let EMMO_51c4190e_dc9a_4292_968c_b36f7fb68912 =
        Namespaced_IRI.parse _namespace_name "EMMO_51c4190e_dc9a_4292_968c_b36f7fb68912" |> NamespacedName

    /// <summary>
    /// Helmholtz energy per unit mass.
    /// <see href="https://w3id.org/emmo#EMMO_51e72318_0e25_42e8_b066_42aa69dc6e5e"></see></summary>
    let EMMO_51e72318_0e25_42e8_b066_42aa69dc6e5e =
        Namespaced_IRI.parse _namespace_name "EMMO_51e72318_0e25_42e8_b066_42aa69dc6e5e" |> NamespacedName

    /// <summary>
    /// Energy per unit mass
    /// <see href="https://w3id.org/emmo#EMMO_e218c625_6a39_47a9_8d08_a2ef41c152a9"></see></summary>
    let EMMO_e218c625_6a39_47a9_8d08_a2ef41c152a9 =
        Namespaced_IRI.parse _namespace_name "EMMO_e218c625_6a39_47a9_8d08_a2ef41c152a9" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting a recognising interpreter to the "cognised" semiotic object in a cognition process.
    /// <see href="https://w3id.org/emmo#EMMO_51e72e5c_ab21_4d0e_ad9f_b168eca89cf4"></see></summary>
    let EMMO_51e72e5c_ab21_4d0e_ad9f_b168eca89cf4 =
        Namespaced_IRI.parse _namespace_name "EMMO_51e72e5c_ab21_4d0e_ad9f_b168eca89cf4" |> NamespacedName

    /// <summary>
    /// Any physical or virtual component of limited availability within a computer system.
    /// <see href="https://w3id.org/emmo#EMMO_51f1ba0d_e92b_4be2_9a9d_4640b16ac7ed"></see></summary>
    let EMMO_51f1ba0d_e92b_4be2_9a9d_4640b16ac7ed =
        Namespaced_IRI.parse _namespace_name "EMMO_51f1ba0d_e92b_4be2_9a9d_4640b16ac7ed" |> NamespacedName

    /// <summary>
    /// Electronic device capable of processing data, typically in binary form, according to instructions given to it in a variable program.
    /// <see href="https://w3id.org/emmo#EMMO_e7848014_ad79_422d_be02_74df892f7c11"></see></summary>
    let EMMO_e7848014_ad79_422d_be02_74df892f7c11 =
        Namespaced_IRI.parse _namespace_name "EMMO_e7848014_ad79_422d_be02_74df892f7c11" |> NamespacedName

    /// <summary>
    /// A part of an item is always non-maximal, meaning that is causally connected with the rest.
    /// A proper part relation with domain restricted to items.
    /// <see href="https://w3id.org/emmo#EMMO_55354438_7000_4284_b1b9_59d60c2261b9"></see></summary>
    let EMMO_55354438_7000_4284_b1b9_59d60c2261b9 =
        Namespaced_IRI.parse _namespace_name "EMMO_55354438_7000_4284_b1b9_59d60c2261b9" |> NamespacedName

    /// <summary>
    /// A data representing 64-bit integer number.
    /// <see href="https://w3id.org/emmo#EMMO_51f93d8c_57fa_4314_a68d_8d69c2609c97"></see></summary>
    let EMMO_51f93d8c_57fa_4314_a68d_8d69c2609c97 =
        Namespaced_IRI.parse _namespace_name "EMMO_51f93d8c_57fa_4314_a68d_8d69c2609c97" |> NamespacedName

    /// <summary>
    /// A relation that establishes for the whole a univocal tessellation in temporal parts forming the tessellation.
    /// <see href="https://w3id.org/emmo#EMMO_65a2c5b8_e4d8_4a51_b2f8_e55effc0547d"></see></summary>
    let EMMO_65a2c5b8_e4d8_4a51_b2f8_e55effc0547d =
        Namespaced_IRI.parse _namespace_name "EMMO_65a2c5b8_e4d8_4a51_b2f8_e55effc0547d" |> NamespacedName

    /// <summary>
    /// A tessellation of temporal slices.
    /// <see href="https://w3id.org/emmo#EMMO_92829beb_6ed4_4c88_bbd5_3bc7403e2895"></see></summary>
    let EMMO_92829beb_6ed4_4c88_bbd5_3bc7403e2895 =
        Namespaced_IRI.parse _namespace_name "EMMO_92829beb_6ed4_4c88_bbd5_3bc7403e2895" |> NamespacedName

    /// <summary>
    /// Thickness of the attenuating layer that reduces the quantity of interest of a unidirectional beam of infinitesimal width to half of its initial value.
    /// <see href="https://w3id.org/emmo#EMMO_5273677c_1cf3_4ae1_b73e_98df6fe9cfa9"></see></summary>
    let EMMO_5273677c_1cf3_4ae1_b73e_98df6fe9cfa9 =
        Namespaced_IRI.parse _namespace_name "EMMO_5273677c_1cf3_4ae1_b73e_98df6fe9cfa9" |> NamespacedName

    /// <summary>
    /// Atom subclass for iodine.
    /// <see href="https://w3id.org/emmo#EMMO_52a611ba-81df-5557-9dfe-c55e4d0f5860"></see></summary>
    let ``EMMO_52a611ba-81df-5557-9dfe-c55e4d0f5860`` =
        Namespaced_IRI.parse _namespace_name "EMMO_52a611ba-81df-5557-9dfe-c55e4d0f5860" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the iodine atom.
    /// <see href="https://w3id.org/emmo#EMMO_c10700ef-832b-5b39-a0a0-5e3f5f17b8e8"></see></summary>
    let ``EMMO_c10700ef-832b-5b39-a0a0-5e3f5f17b8e8`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c10700ef-832b-5b39-a0a0-5e3f5f17b8e8" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MechanicalMobility'.
    /// <see href="https://w3id.org/emmo#EMMO_52ba3876_b51e_4670_a6f2_ce726abc2d3d"></see></summary>
    let EMMO_52ba3876_b51e_4670_a6f2_ce726abc2d3d =
        Namespaced_IRI.parse _namespace_name "EMMO_52ba3876_b51e_4670_a6f2_ce726abc2d3d" |> NamespacedName

    /// <summary>
    /// A system of independent elements that are assembled together to perform a function.
    /// <see href="https://w3id.org/emmo#EMMO_52bbaaee_1145_4be3_8a5c_b366851ea1b9"></see></summary>
    let EMMO_52bbaaee_1145_4be3_8a5c_b366851ea1b9 =
        Namespaced_IRI.parse _namespace_name "EMMO_52bbaaee_1145_4be3_8a5c_b366851ea1b9" |> NamespacedName

    /// <summary>
    /// Reciprocal of the decay constant λ.
    /// <see href="https://w3id.org/emmo#EMMO_52f7d4e5_b4aa_4e11_9205_71e42eea13b3"></see></summary>
    let EMMO_52f7d4e5_b4aa_4e11_9205_71e42eea13b3 =
        Namespaced_IRI.parse _namespace_name "EMMO_52f7d4e5_b4aa_4e11_9205_71e42eea13b3" |> NamespacedName

    /// <summary>
    /// A symbolic data representing a 64-bit floating point numbers incl. ±Inf, ±0, NaN.
    /// <see href="https://w3id.org/emmo#EMMO_52fa9c76_fc42_4eca_a5c1_6095a1c9caab"></see></summary>
    let EMMO_52fa9c76_fc42_4eca_a5c1_6095a1c9caab =
        Namespaced_IRI.parse _namespace_name "EMMO_52fa9c76_fc42_4eca_a5c1_6095a1c9caab" |> NamespacedName

    /// <summary>
    /// A symbolic data representing a numerical floating point value.
    /// <see href="https://w3id.org/emmo#EMMO_88a34881_b8d0_474b_9a08_40dbd414d834"></see></summary>
    let EMMO_88a34881_b8d0_474b_9a08_40dbd414d834 =
        Namespaced_IRI.parse _namespace_name "EMMO_88a34881_b8d0_474b_9a08_40dbd414d834" |> NamespacedName

    /// <summary>
    /// Hypothetical pressure of gas if it alone occupied the volume of the mixture at the same temperature.
    /// <see href="https://w3id.org/emmo#EMMO_535021bf_d490_416a_9855_b918cf96c115"></see></summary>
    let EMMO_535021bf_d490_416a_9855_b918cf96c115 =
        Namespaced_IRI.parse _namespace_name "EMMO_535021bf_d490_416a_9855_b918cf96c115" |> NamespacedName

    /// <summary>
    /// The equals symbol.
    /// <see href="https://w3id.org/emmo#EMMO_535d75a4_1972_40bc_88c6_ca566386934f"></see></summary>
    let EMMO_535d75a4_1972_40bc_88c6_ca566386934f =
        Namespaced_IRI.parse _namespace_name "EMMO_535d75a4_1972_40bc_88c6_ca566386934f" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting an icon to a interpreter (cogniser) in a cognision process.
    /// <see href="https://w3id.org/emmo#EMMO_5369d256_5866_4729_adc2_1498ee9a4959"></see></summary>
    let EMMO_5369d256_5866_4729_adc2_1498ee9a4959 =
        Namespaced_IRI.parse _namespace_name "EMMO_5369d256_5866_4729_adc2_1498ee9a4959" |> NamespacedName

    /// <summary>
    /// A physics-based model based on a physics equation describing the behaviour of mesoscopic entities, i.e. a set of bounded atoms like a molecule, bead or nanoparticle.
    /// <see href="https://w3id.org/emmo#EMMO_53935db0_af45_4426_b9e9_244a0d77db00"></see></summary>
    let EMMO_53935db0_af45_4426_b9e9_244a0d77db00 =
        Namespaced_IRI.parse _namespace_name "EMMO_53935db0_af45_4426_b9e9_244a0d77db00" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PowerDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_539d8d92_d3a5_4f46_858f_081fed5b4190"></see></summary>
    let EMMO_539d8d92_d3a5_4f46_858f_081fed5b4190 =
        Namespaced_IRI.parse _namespace_name "EMMO_539d8d92_d3a5_4f46_858f_081fed5b4190" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentPerEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_53b10105_52c7_4746_ab73_a5a30bd198e2"></see></summary>
    let EMMO_53b10105_52c7_4746_ab73_a5a30bd198e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_53b10105_52c7_4746_ab73_a5a30bd198e2" |> NamespacedName

    /// <summary>
    /// An elementary particle of a fundamental fermionic type.
    /// <see href="https://w3id.org/emmo#EMMO_820619ca_b23e_4c7a_8543_18a17722abc0"></see></summary>
    let EMMO_820619ca_b23e_4c7a_8543_18a17722abc0 =
        Namespaced_IRI.parse _namespace_name "EMMO_820619ca_b23e_4c7a_8543_18a17722abc0" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_53dd6f2a_f9de_4f83_b925_1bf39a4ab9a6"></see>
    /// </summary>
    let EMMO_53dd6f2a_f9de_4f83_b925_1bf39a4ab9a6 =
        Namespaced_IRI.parse _namespace_name "EMMO_53dd6f2a_f9de_4f83_b925_1bf39a4ab9a6" |> NamespacedName

    /// <summary>
    /// This relation is about two wholes that overlap, and whose intersection is an holistic part of both.
    /// A relation between two holistic wholes that properly overlap, sharing one of their holistic parts.
    /// <see href="https://w3id.org/emmo#EMMO_53e5b1e1_6026_4ddc_8a4a_3aaaa5fdbdb7"></see></summary>
    let EMMO_53e5b1e1_6026_4ddc_8a4a_3aaaa5fdbdb7 =
        Namespaced_IRI.parse _namespace_name "EMMO_53e5b1e1_6026_4ddc_8a4a_3aaaa5fdbdb7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_bcaddc91_a881_4c40_a102_562cbaf61c6c"></see>
    /// </summary>
    let EMMO_bcaddc91_a881_4c40_a102_562cbaf61c6c =
        Namespaced_IRI.parse _namespace_name "EMMO_bcaddc91_a881_4c40_a102_562cbaf61c6c" |> NamespacedName

    /// <summary>
    /// Atom subclass for darmastadtium.
    /// <see href="https://w3id.org/emmo#EMMO_5455d87d-1c98-50e1-9904-c94f6a697097"></see></summary>
    let ``EMMO_5455d87d-1c98-50e1-9904-c94f6a697097`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5455d87d-1c98-50e1-9904-c94f6a697097" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the darmastadtium atom.
    /// <see href="https://w3id.org/emmo#EMMO_71d48627-4696-54c2-a990-4fdd9f353aef"></see></summary>
    let ``EMMO_71d48627-4696-54c2-a990-4fdd9f353aef`` =
        Namespaced_IRI.parse _namespace_name "EMMO_71d48627-4696-54c2-a990-4fdd9f353aef" |> NamespacedName

    /// <summary>
    /// The relation between entities that express a mutual causation.
    /// A relation jointly covered by Contact and InteractWith relations, which are mutually exclusive.
    /// <see href="https://w3id.org/emmo#EMMO_54d0d0f4_d9fa_4179_a9b5_4110c49dafff"></see></summary>
    let EMMO_54d0d0f4_d9fa_4179_a9b5_4110c49dafff =
        Namespaced_IRI.parse _namespace_name "EMMO_54d0d0f4_d9fa_4179_a9b5_4110c49dafff" |> NamespacedName

    /// <summary>
    /// A data repesenting a boolean number.
    /// <see href="https://w3id.org/emmo#EMMO_54dc83cb_06e1_4739_9e45_bc09cead7f48"></see></summary>
    let EMMO_54dc83cb_06e1_4739_9e45_bc09cead7f48 =
        Namespaced_IRI.parse _namespace_name "EMMO_54dc83cb_06e1_4739_9e45_bc09cead7f48" |> NamespacedName

    /// <summary>
    /// Relative change of length with respect the original length.
    /// <see href="https://w3id.org/emmo#EMMO_5574a8ed_5094_4d63_8d95_1c19cfd38409"></see></summary>
    let EMMO_5574a8ed_5094_4d63_8d95_1c19cfd38409 =
        Namespaced_IRI.parse _namespace_name "EMMO_5574a8ed_5094_4d63_8d95_1c19cfd38409" |> NamespacedName

    /// <summary>
    /// The inverse relation for hasProperPart.
    /// <see href="https://w3id.org/emmo#EMMO_559ab98c_1c7d_4794_996c_8c1d8d56381c"></see></summary>
    let EMMO_559ab98c_1c7d_4794_996c_8c1d8d56381c =
        Namespaced_IRI.parse _namespace_name "EMMO_559ab98c_1c7d_4794_996c_8c1d8d56381c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthPerCubeTime'.
    /// <see href="https://w3id.org/emmo#EMMO_55ffe612_cf43_4b9b_a4e1_6aeb0c59c10c"></see></summary>
    let EMMO_55ffe612_cf43_4b9b_a4e1_6aeb0c59c10c =
        Namespaced_IRI.parse _namespace_name "EMMO_55ffe612_cf43_4b9b_a4e1_6aeb0c59c10c" |> NamespacedName

    /// <summary>
    /// Width of the forbidden energy band in a superconductor.
    /// <see href="https://w3id.org/emmo#EMMO_560d031f_cc8a_4f0d_a52b_039149fdc171"></see></summary>
    let EMMO_560d031f_cc8a_4f0d_a52b_039149fdc171 =
        Namespaced_IRI.parse _namespace_name "EMMO_560d031f_cc8a_4f0d_a52b_039149fdc171" |> NamespacedName

    /// <summary>
    /// Smallest energy difference between the lowest level of conduction band and the highest level of valence band at zero thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_69164f9e_c75d_4fbc_a0f8_af7a81bbd128"></see></summary>
    let EMMO_69164f9e_c75d_4fbc_a0f8_af7a81bbd128 =
        Namespaced_IRI.parse _namespace_name "EMMO_69164f9e_c75d_4fbc_a0f8_af7a81bbd128" |> NamespacedName

    /// <summary>
    /// A colloid composed of fine solid particles or liquid droplets in air or another gas.
    /// <see href="https://w3id.org/emmo#EMMO_560d833a_6184_410c_859a_05d982712fd7"></see></summary>
    let EMMO_560d833a_6184_410c_859a_05d982712fd7 =
        Namespaced_IRI.parse _namespace_name "EMMO_560d833a_6184_410c_859a_05d982712fd7" |> NamespacedName

    /// <summary>
    /// Electric field strength multiplied by magnetic field strength.
    /// <see href="https://w3id.org/emmo#EMMO_566321d8_1600_4ab0_a5da_7f99dce2b1db"></see></summary>
    let EMMO_566321d8_1600_4ab0_a5da_7f99dce2b1db =
        Namespaced_IRI.parse _namespace_name "EMMO_566321d8_1600_4ab0_a5da_7f99dce2b1db" |> NamespacedName

    /// <summary>
    /// Proportionality constant between the particle current density J and the gradient of the particle number density n.
    /// <see href="https://w3id.org/emmo#EMMO_56710a21_601b_43bb_88c5_0bd9eca06da2"></see></summary>
    let EMMO_56710a21_601b_43bb_88c5_0bd9eca06da2 =
        Namespaced_IRI.parse _namespace_name "EMMO_56710a21_601b_43bb_88c5_0bd9eca06da2" |> NamespacedName

    /// <summary>
    /// Length of the repetition interval of a wave.
    /// <see href="https://w3id.org/emmo#EMMO_573c7572_e7c7_4909_93a4_2bfe102e389d"></see></summary>
    let EMMO_573c7572_e7c7_4909_93a4_2bfe102e389d =
        Namespaced_IRI.parse _namespace_name "EMMO_573c7572_e7c7_4909_93a4_2bfe102e389d" |> NamespacedName

    /// <summary>
    /// Atom subclass for xenon.
    /// <see href="https://w3id.org/emmo#EMMO_57742ca9-95d8-50f8-9b33-0ded30da4532"></see></summary>
    let ``EMMO_57742ca9-95d8-50f8-9b33-0ded30da4532`` =
        Namespaced_IRI.parse _namespace_name "EMMO_57742ca9-95d8-50f8-9b33-0ded30da4532" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the xenon atom.
    /// <see href="https://w3id.org/emmo#EMMO_fba570fc-6881-51d6-8e9d-a8c23e422b62"></see></summary>
    let ``EMMO_fba570fc-6881-51d6-8e9d-a8c23e422b62`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fba570fc-6881-51d6-8e9d-a8c23e422b62" |> NamespacedName

    /// <summary>
    /// Atom subclass for copper.
    /// <see href="https://w3id.org/emmo#EMMO_57a7ab6b-30a4-54e5-821d-0b8efb5e08b2"></see></summary>
    let ``EMMO_57a7ab6b-30a4-54e5-821d-0b8efb5e08b2`` =
        Namespaced_IRI.parse _namespace_name "EMMO_57a7ab6b-30a4-54e5-821d-0b8efb5e08b2" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the copper atom.
    /// <see href="https://w3id.org/emmo#EMMO_bd93ef72-3d4f-5f17-b613-01f440296995"></see></summary>
    let ``EMMO_bd93ef72-3d4f-5f17-b613-01f440296995`` =
        Namespaced_IRI.parse _namespace_name "EMMO_bd93ef72-3d4f-5f17-b613-01f440296995" |> NamespacedName

    /// <summary>
    /// A guess is a theory, estimated and subjective, since its premises are subjective.
    /// <see href="https://w3id.org/emmo#EMMO_57b9fd6c_84d6_43f2_8c4f_de6a1ab50aea"></see></summary>
    let EMMO_57b9fd6c_84d6_43f2_8c4f_de6a1ab50aea =
        Namespaced_IRI.parse _namespace_name "EMMO_57b9fd6c_84d6_43f2_8c4f_de6a1ab50aea" |> NamespacedName

    /// <summary>
    /// A 'conventional' that stand for a 'physical'.
    /// The 'theory' is e.g. a proposition, a book or a paper whose sub-symbols suggest in the mind of the interpreter an interpretant structure that can represent a 'physical'.
    ///
    /// It is not an 'icon' (like a math equation), because it has no common resemblance or logical structure with the 'physical'.
    ///
    /// In Peirce semiotics: legisign-symbol-argument
    /// <see href="https://w3id.org/emmo#EMMO_8d2d9374_ef3a_47e6_8595_6bc208e07519"></see></summary>
    let EMMO_8d2d9374_ef3a_47e6_8595_6bc208e07519 =
        Namespaced_IRI.parse _namespace_name "EMMO_8d2d9374_ef3a_47e6_8595_6bc208e07519" |> NamespacedName

    /// <summary>
    /// A coded that is assigned from an estimation.
    /// <see href="https://w3id.org/emmo#EMMO_9b87d718_9dcc_4f7d_ad20_12c2aa4c76be"></see></summary>
    let EMMO_9b87d718_9dcc_4f7d_ad20_12c2aa4c76be =
        Namespaced_IRI.parse _namespace_name "EMMO_9b87d718_9dcc_4f7d_ad20_12c2aa4c76be" |> NamespacedName

    /// <summary>
    /// A workflow whose tasks are tiles of a sequence.
    /// <see href="https://w3id.org/emmo#EMMO_57ba1bf0_4314_432c_a9bb_6a6720c8dab5"></see></summary>
    let EMMO_57ba1bf0_4314_432c_a9bb_6a6720c8dab5 =
        Namespaced_IRI.parse _namespace_name "EMMO_57ba1bf0_4314_432c_a9bb_6a6720c8dab5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_57c75ca1_bf8a_42bc_85d9_58cfe38c7df2"></see>
    /// </summary>
    let EMMO_57c75ca1_bf8a_42bc_85d9_58cfe38c7df2 =
        Namespaced_IRI.parse _namespace_name "EMMO_57c75ca1_bf8a_42bc_85d9_58cfe38c7df2" |> NamespacedName

    /// <summary>
    /// Scalar quantity equal to the flux of the electric flux density D through a given directed surface S.
    /// <see href="https://w3id.org/emmo#EMMO_581e05bc_a4fe_494a_a85c_f2c4b4374e18"></see></summary>
    let EMMO_581e05bc_a4fe_494a_a85c_f2c4b4374e18 =
        Namespaced_IRI.parse _namespace_name "EMMO_581e05bc_a4fe_494a_a85c_f2c4b4374e18" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the thallium atom.
    /// <see href="https://w3id.org/emmo#EMMO_5833085e-0afc-516a-a584-f56f1f191a13"></see></summary>
    let ``EMMO_5833085e-0afc-516a-a584-f56f1f191a13`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5833085e-0afc-516a-a584-f56f1f191a13" |> NamespacedName

    /// <summary>
    /// A workflow whose tasks are spatial tiles.
    /// <see href="https://w3id.org/emmo#EMMO_5848e476_2768_4988_98f9_9053c532307b"></see></summary>
    let EMMO_5848e476_2768_4988_98f9_9053c532307b =
        Namespaced_IRI.parse _namespace_name "EMMO_5848e476_2768_4988_98f9_9053c532307b" |> NamespacedName

    /// <summary>
    /// The DBpedia definition (http://dbpedia.org/page/Elementary_charge) is outdated as May 20, 2019. It is now an exact quantity.
    /// The magnitude of the electric charge carried by a single electron. It defines the base unit Ampere in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_58a650f0_a638_4743_8439_535a325e5c4c"></see></summary>
    let EMMO_58a650f0_a638_4743_8439_535a325e5c4c =
        Namespaced_IRI.parse _namespace_name "EMMO_58a650f0_a638_4743_8439_535a325e5c4c" |> NamespacedName

    /// <summary>
    /// Scalar measure of the rotational inertia with respect to a fixed axis of rotation.
    /// <see href="https://w3id.org/emmo#EMMO_58a85e5b_6526_484d_b080_e1059ce9994c"></see></summary>
    let EMMO_58a85e5b_6526_484d_b080_e1059ce9994c =
        Namespaced_IRI.parse _namespace_name "EMMO_58a85e5b_6526_484d_b080_e1059ce9994c" |> NamespacedName

    /// <summary>
    /// System program refers to operating systems and utility programs that manage computer resources at a low level enabling a computer to function.
    /// <see href="https://w3id.org/emmo#EMMO_58b17cac_3125_4486_9b9c_8c45ac254040"></see></summary>
    let EMMO_58b17cac_3125_4486_9b9c_8c45ac254040 =
        Namespaced_IRI.parse _namespace_name "EMMO_58b17cac_3125_4486_9b9c_8c45ac254040" |> NamespacedName

    /// <summary>
    /// Rest mass of a nuclide X in the ground state.
    /// <see href="https://w3id.org/emmo#EMMO_58c08428_03e2_446d_85e1_f94cc6682e2b"></see></summary>
    let EMMO_58c08428_03e2_446d_85e1_f94cc6682e2b =
        Namespaced_IRI.parse _namespace_name "EMMO_58c08428_03e2_446d_85e1_f94cc6682e2b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareElectricPotentialPerSquareTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_58c5b65c_c896_4740_80d9_ff9a7643c7e8"></see></summary>
    let EMMO_58c5b65c_c896_4740_80d9_ff9a7643c7e8 =
        Namespaced_IRI.parse _namespace_name "EMMO_58c5b65c_c896_4740_80d9_ff9a7643c7e8" |> NamespacedName

    /// <summary>
    /// A data representing an integer number &gt; 0.
    /// <see href="https://w3id.org/emmo#EMMO_58f76a09_205c_44f2_b237_88de54e8e001"></see></summary>
    let EMMO_58f76a09_205c_44f2_b237_88de54e8e001 =
        Namespaced_IRI.parse _namespace_name "EMMO_58f76a09_205c_44f2_b237_88de54e8e001" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ReciprocalMass'.
    /// <see href="https://w3id.org/emmo#EMMO_59197cce_b8b6_4216_a08d_26fb83c032af"></see></summary>
    let EMMO_59197cce_b8b6_4216_a08d_26fb83c032af =
        Namespaced_IRI.parse _namespace_name "EMMO_59197cce_b8b6_4216_a08d_26fb83c032af" |> NamespacedName

    /// <summary>
    /// Deals with entities that have a undefined shape. Undefined means that the actual shape of the entity that is produced is not relevant for the definition of the process.
    /// In fact, everything has a shape, but in process engineering this is not relevant.
    ///
    /// e.g. the fact that steel comes in sheets is not relevant for the definition of steel material generated in a steel-making process.
    /// <see href="https://w3id.org/emmo#EMMO_592b1d98_4736_4cac_9b62_849b8dbe11c7"></see></summary>
    let EMMO_592b1d98_4736_4cac_9b62_849b8dbe11c7 =
        Namespaced_IRI.parse _namespace_name "EMMO_592b1d98_4736_4cac_9b62_849b8dbe11c7" |> NamespacedName

    /// <summary>
    /// Scalar quantity or tensor quantity equal to the absolute permeability divided by the magnetic constant.
    /// <see href="https://w3id.org/emmo#EMMO_593ecc7c_250d_4e4d_8957_0170f3cc2154"></see></summary>
    let EMMO_593ecc7c_250d_4e4d_8957_0170f3cc2154 =
        Namespaced_IRI.parse _namespace_name "EMMO_593ecc7c_250d_4e4d_8957_0170f3cc2154" |> NamespacedName

    /// <summary>
    /// Product of damping coefficient and period duration.
    /// <see href="https://w3id.org/emmo#EMMO_59809abc_d206_4015_9836_9d3a32460586"></see></summary>
    let EMMO_59809abc_d206_4015_9836_9d3a32460586 =
        Namespaced_IRI.parse _namespace_name "EMMO_59809abc_d206_4015_9836_9d3a32460586" |> NamespacedName

    /// <summary>
    /// Atom subclass for thorium.
    /// <see href="https://w3id.org/emmo#EMMO_59d342fd-1ace-5b68-9d0d-ed4ff9f55d63"></see></summary>
    let ``EMMO_59d342fd-1ace-5b68-9d0d-ed4ff9f55d63`` =
        Namespaced_IRI.parse _namespace_name "EMMO_59d342fd-1ace-5b68-9d0d-ed4ff9f55d63" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the thorium atom.
    /// <see href="https://w3id.org/emmo#EMMO_e9fbc98d-3ac1-5a2d-a354-6e3ba1412157"></see></summary>
    let ``EMMO_e9fbc98d-3ac1-5a2d-a354-6e3ba1412157`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e9fbc98d-3ac1-5a2d-a354-6e3ba1412157" |> NamespacedName

    /// <summary>
    /// A derived unit that belongs to the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_59e710f4_d9ea_4167_9a3f_f90628a307df"></see></summary>
    let EMMO_59e710f4_d9ea_4167_9a3f_f90628a307df =
        Namespaced_IRI.parse _namespace_name "EMMO_59e710f4_d9ea_4167_9a3f_f90628a307df" |> NamespacedName

    /// <summary>
    /// In nuclear physics, the multiplication factor for an infinite medium.
    /// <see href="https://w3id.org/emmo#EMMO_5a0f35b8_d18e_4570_a94e_ee84b13bb7bc"></see></summary>
    let EMMO_5a0f35b8_d18e_4570_a94e_ee84b13bb7bc =
        Namespaced_IRI.parse _namespace_name "EMMO_5a0f35b8_d18e_4570_a94e_ee84b13bb7bc" |> NamespacedName

    /// <summary>
    /// Smoke is a solid aerosol made of particles emitted when a material undergoes combustion or pyrolysis.
    /// <see href="https://w3id.org/emmo#EMMO_5a2af26d_99de_4e5e_b1cd_514be71420c3"></see></summary>
    let EMMO_5a2af26d_99de_4e5e_b1cd_514be71420c3 =
        Namespaced_IRI.parse _namespace_name "EMMO_5a2af26d_99de_4e5e_b1cd_514be71420c3" |> NamespacedName

    /// <summary>
    /// An aerosol composed of fine solid particles in air or another gas.
    /// <see href="https://w3id.org/emmo#EMMO_96c8d72f_b436_44e2_9f7f_085c24094292"></see></summary>
    let EMMO_96c8d72f_b436_44e2_9f7f_085c24094292 =
        Namespaced_IRI.parse _namespace_name "EMMO_96c8d72f_b436_44e2_9f7f_085c24094292" |> NamespacedName

    /// <summary>
    /// Atom subclass for hydrogen.
    /// <see href="https://w3id.org/emmo#EMMO_5a4790e5-b11b-5a0c-80e4-81515c27a560"></see></summary>
    let ``EMMO_5a4790e5-b11b-5a0c-80e4-81515c27a560`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5a4790e5-b11b-5a0c-80e4-81515c27a560" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the hydrogen atom.
    /// <see href="https://w3id.org/emmo#EMMO_93582808-e5fc-5bb5-bc7a-0e674e1a7f0e"></see></summary>
    let ``EMMO_93582808-e5fc-5bb5-bc7a-0e674e1a7f0e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_93582808-e5fc-5bb5-bc7a-0e674e1a7f0e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_5a5cf124_1ece_4b8e_ae63_edc2b5ee573a"></see>
    /// </summary>
    let EMMO_5a5cf124_1ece_4b8e_ae63_edc2b5ee573a =
        Namespaced_IRI.parse _namespace_name "EMMO_5a5cf124_1ece_4b8e_ae63_edc2b5ee573a" |> NamespacedName

    /// <summary>
    /// Quotient of the activity A of a sample and the mass m of that sample.
    /// <see href="https://w3id.org/emmo#EMMO_5adcbbb9_4325_4c23_ac50_62c77569e9c4"></see></summary>
    let EMMO_5adcbbb9_4325_4c23_ac50_62c77569e9c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_5adcbbb9_4325_4c23_ac50_62c77569e9c4" |> NamespacedName

    /// <summary>
    /// A type of sol in the form of one solid dispersed in another continuous solid.
    /// <see href="https://w3id.org/emmo#EMMO_5add9885_dc98_4fa5_8482_fdf9ba5e3889"></see></summary>
    let EMMO_5add9885_dc98_4fa5_8482_fdf9ba5e3889 =
        Namespaced_IRI.parse _namespace_name "EMMO_5add9885_dc98_4fa5_8482_fdf9ba5e3889" |> NamespacedName

    /// <summary>
    /// Atom subclass for iridium.
    /// <see href="https://w3id.org/emmo#EMMO_5ae62317-1681-5ca9-9fa7-8801757ee5c8"></see></summary>
    let ``EMMO_5ae62317-1681-5ca9-9fa7-8801757ee5c8`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5ae62317-1681-5ca9-9fa7-8801757ee5c8" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the iridium atom.
    /// <see href="https://w3id.org/emmo#EMMO_b8aab013-b729-51f1-bc14-5302e7f97cbe"></see></summary>
    let ``EMMO_b8aab013-b729-51f1-bc14-5302e7f97cbe`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b8aab013-b729-51f1-bc14-5302e7f97cbe" |> NamespacedName

    /// <summary>
    /// The derivative of the electric charge of a system with respect to the length.
    /// <see href="https://w3id.org/emmo#EMMO_5afa28f0_8c9f_4fcd_8f67_805bd2f9c068"></see></summary>
    let EMMO_5afa28f0_8c9f_4fcd_8f67_805bd2f9c068 =
        Namespaced_IRI.parse _namespace_name "EMMO_5afa28f0_8c9f_4fcd_8f67_805bd2f9c068" |> NamespacedName

    /// <summary>
    /// Antimatter is matter that is composed only of the antiparticles of those that constitute ordinary matter.
    /// This branch is not expanded due to the limited use of such entities.
    /// <see href="https://w3id.org/emmo#EMMO_f13672a3_59cc_40ed_8def_65009a8f74e6"></see></summary>
    let EMMO_f13672a3_59cc_40ed_8def_65009a8f74e6 =
        Namespaced_IRI.parse _namespace_name "EMMO_f13672a3_59cc_40ed_8def_65009a8f74e6" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_5be83f9c_a4ba_4b9a_be1a_5bfc6e891231"></see>
    /// </summary>
    let EMMO_5be83f9c_a4ba_4b9a_be1a_5bfc6e891231 =
        Namespaced_IRI.parse _namespace_name "EMMO_5be83f9c_a4ba_4b9a_be1a_5bfc6e891231" |> NamespacedName

    /// <summary>
    /// A gaseous solution made of more than one component type.
    /// <see href="https://w3id.org/emmo#EMMO_5be9c137_325a_43d8_b7cd_ea93e7721c2d"></see></summary>
    let EMMO_5be9c137_325a_43d8_b7cd_ea93e7721c2d =
        Namespaced_IRI.parse _namespace_name "EMMO_5be9c137_325a_43d8_b7cd_ea93e7721c2d" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LuminousEfficacy'.
    /// <see href="https://w3id.org/emmo#EMMO_5c003f53_20a2_4bd7_8445_58187e582578"></see></summary>
    let EMMO_5c003f53_20a2_4bd7_8445_58187e582578 =
        Namespaced_IRI.parse _namespace_name "EMMO_5c003f53_20a2_4bd7_8445_58187e582578" |> NamespacedName

    /// <summary>
    /// A formal computer-interpretable identifier of a system resource.
    /// <see href="https://w3id.org/emmo#EMMO_c404e6d9_261d_4d2e_ab0d_ba4e05062647"></see></summary>
    let EMMO_c404e6d9_261d_4d2e_ab0d_ba4e05062647 =
        Namespaced_IRI.parse _namespace_name "EMMO_c404e6d9_261d_4d2e_ab0d_ba4e05062647" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the berkelium atom.
    /// <see href="https://w3id.org/emmo#EMMO_5c736993-31b7-5839-aa36-38b6cd8b41a2"></see></summary>
    let ``EMMO_5c736993-31b7-5839-aa36-38b6cd8b41a2`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5c736993-31b7-5839-aa36-38b6cd8b41a2" |> NamespacedName

    /// <summary>
    /// Voltage between the two terminals of a voltage source when there is no electric current through the source.
    /// <see href="https://w3id.org/emmo#EMMO_5c78b424_087b_4e31_8c91_6422f1be1e86"></see></summary>
    let EMMO_5c78b424_087b_4e31_8c91_6422f1be1e86 =
        Namespaced_IRI.parse _namespace_name "EMMO_5c78b424_087b_4e31_8c91_6422f1be1e86" |> NamespacedName

    /// <summary>
    /// A liquid solution in which the solvent is water.
    /// <see href="https://w3id.org/emmo#EMMO_5cb107ba_7daa_46dd_8f9f_da22a6eac676"></see></summary>
    let EMMO_5cb107ba_7daa_46dd_8f9f_da22a6eac676 =
        Namespaced_IRI.parse _namespace_name "EMMO_5cb107ba_7daa_46dd_8f9f_da22a6eac676" |> NamespacedName

    /// <summary>
    /// Electric charge per volume.
    /// <see href="https://w3id.org/emmo#EMMO_5cbb7bfb_7ab8_4151_8ed1_13a5b7d5caa4"></see></summary>
    let EMMO_5cbb7bfb_7ab8_4151_8ed1_13a5b7d5caa4 =
        Namespaced_IRI.parse _namespace_name "EMMO_5cbb7bfb_7ab8_4151_8ed1_13a5b7d5caa4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_5ceab41b_2aea_4041_9e9c_a243f7562cee"></see>
    /// </summary>
    let EMMO_5ceab41b_2aea_4041_9e9c_a243f7562cee =
        Namespaced_IRI.parse _namespace_name "EMMO_5ceab41b_2aea_4041_9e9c_a243f7562cee" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerMassTime'.
    /// <see href="https://w3id.org/emmo#EMMO_5d2d48c4_4fb6_4f33_bfc0_273129429c30"></see></summary>
    let EMMO_5d2d48c4_4fb6_4f33_bfc0_273129429c30 =
        Namespaced_IRI.parse _namespace_name "EMMO_5d2d48c4_4fb6_4f33_bfc0_273129429c30" |> NamespacedName

    /// <summary>
    /// Average number of fission neutrons, both prompt and delayed, emitted per fission event.
    /// <see href="https://w3id.org/emmo#EMMO_5d34ae8e_182c_49f3_815e_ea675faaaf30"></see></summary>
    let EMMO_5d34ae8e_182c_49f3_815e_ea675faaaf30 =
        Namespaced_IRI.parse _namespace_name "EMMO_5d34ae8e_182c_49f3_815e_ea675faaaf30" |> NamespacedName

    /// <summary>
    /// Differential quotient of the cross section for a process and the energy of the scattered particle.
    /// <see href="https://w3id.org/emmo#EMMO_5d61057e_d7f1_43e4_98fa_ae04e0cb470a"></see></summary>
    let EMMO_5d61057e_d7f1_43e4_98fa_ae04e0cb470a =
        Namespaced_IRI.parse _namespace_name "EMMO_5d61057e_d7f1_43e4_98fa_ae04e0cb470a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ForcePerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_d46e131b_f51a_4ae7_9301_824d718c56fa"></see></summary>
    let EMMO_d46e131b_f51a_4ae7_9301_824d718c56fa =
        Namespaced_IRI.parse _namespace_name "EMMO_d46e131b_f51a_4ae7_9301_824d718c56fa" |> NamespacedName

    /// <summary>
    /// Nanomaterials are Materials possessing, at minimum, one external dimension measuring 1-100nm
    /// <see href="https://w3id.org/emmo#EMMO_5d659e25_a508_43ed_903c_3707c7c7cd4b"></see></summary>
    let EMMO_5d659e25_a508_43ed_903c_3707c7c7cd4b =
        Namespaced_IRI.parse _namespace_name "EMMO_5d659e25_a508_43ed_903c_3707c7c7cd4b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e4e80813_f379_4091_b017_ee059811f806"></see>
    /// </summary>
    let EMMO_e4e80813_f379_4091_b017_ee059811f806 =
        Namespaced_IRI.parse _namespace_name "EMMO_e4e80813_f379_4091_b017_ee059811f806" |> NamespacedName

    /// <summary>
    /// Sum of energies deposited by ionizing radiation in a given volume.
    /// <see href="https://w3id.org/emmo#EMMO_5d7f00a7_0374_4517_b5a8_62b154f33cc6"></see></summary>
    let EMMO_5d7f00a7_0374_4517_b5a8_62b154f33cc6 =
        Namespaced_IRI.parse _namespace_name "EMMO_5d7f00a7_0374_4517_b5a8_62b154f33cc6" |> NamespacedName

    /// <summary>
    /// Apparent admittance is often denoted by Y .
    /// quotient of the rms value of the electric current in a two-terminal element or a two-terminal circuit by the rms value of the voltage between its terminals.
    /// <see href="https://w3id.org/emmo#EMMO_5e26440d_af47_4c30_a1c3_511e4072c617"></see></summary>
    let EMMO_5e26440d_af47_4c30_a1c3_511e4072c617 =
        Namespaced_IRI.parse _namespace_name "EMMO_5e26440d_af47_4c30_a1c3_511e4072c617" |> NamespacedName

    /// <summary>
    /// A solid solution made of two or more component substances.
    /// <see href="https://w3id.org/emmo#EMMO_5e77f00d_5c0a_44e7_baf1_2c2a4cb5b3ae"></see></summary>
    let EMMO_5e77f00d_5c0a_44e7_baf1_2c2a4cb5b3ae =
        Namespaced_IRI.parse _namespace_name "EMMO_5e77f00d_5c0a_44e7_baf1_2c2a4cb5b3ae" |> NamespacedName

    /// <summary>
    /// Represents the number 1, used as an explicit unit to say something has no units.
    /// "The unit one is the neutral element of any system of units – necessary and present automatically."
    ///
    /// -- SI Brochure
    /// <see href="https://w3id.org/emmo#EMMO_5ebd5e01_0ed3_49a2_a30d_cd05cbe72978"></see></summary>
    let EMMO_5ebd5e01_0ed3_49a2_a30d_cd05cbe72978 =
        Namespaced_IRI.parse _namespace_name "EMMO_5ebd5e01_0ed3_49a2_a30d_cd05cbe72978" |> NamespacedName

    /// <summary>
    /// Atom subclass for fermium.
    /// <see href="https://w3id.org/emmo#EMMO_5ee30708-feb6-54c0-977e-3d069e496a76"></see></summary>
    let ``EMMO_5ee30708-feb6-54c0-977e-3d069e496a76`` =
        Namespaced_IRI.parse _namespace_name "EMMO_5ee30708-feb6-54c0-977e-3d069e496a76" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the fermium atom.
    /// <see href="https://w3id.org/emmo#EMMO_9c5b1294-ac9e-554f-a135-a3d72a763d9c"></see></summary>
    let ``EMMO_9c5b1294-ac9e-554f-a135-a3d72a763d9c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_9c5b1294-ac9e-554f-a135-a3d72a763d9c" |> NamespacedName

    /// <summary>
    /// Factor by which the phase velocity of light is reduced in a medium.
    /// <see href="https://w3id.org/emmo#EMMO_5eedba4d_105b_44d8_b1bc_e33606276ea2"></see></summary>
    let EMMO_5eedba4d_105b_44d8_b1bc_e33606276ea2 =
        Namespaced_IRI.parse _namespace_name "EMMO_5eedba4d_105b_44d8_b1bc_e33606276ea2" |> NamespacedName

    /// <summary>
    /// A three-manifold with Euclidean metric.
    /// <see href="https://w3id.org/emmo#EMMO_5f278af9_8593_4e27_a717_ccc9e07a0ddf"></see></summary>
    let EMMO_5f278af9_8593_4e27_a717_ccc9e07a0ddf =
        Namespaced_IRI.parse _namespace_name "EMMO_5f278af9_8593_4e27_a717_ccc9e07a0ddf" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_5f375229_de0c_46bf_b11f_da9d3b742253"></see></summary>
    let EMMO_5f375229_de0c_46bf_b11f_da9d3b742253 =
        Namespaced_IRI.parse _namespace_name "EMMO_5f375229_de0c_46bf_b11f_da9d3b742253" |> NamespacedName

    /// <summary>
    /// number of nucleons in an atomic nucleus
    /// <see href="https://w3id.org/emmo#EMMO_5fb97c35_1896_4221_bdc1_0028bb80f5d5"></see></summary>
    let EMMO_5fb97c35_1896_4221_bdc1_0028bb80f5d5 =
        Namespaced_IRI.parse _namespace_name "EMMO_5fb97c35_1896_4221_bdc1_0028bb80f5d5" |> NamespacedName

    /// <summary>
    /// Ratio of specific heat capacity at constant pressure cp to specific heat capacity at constant volume cV, thus γ = cp/cV.
    /// <see href="https://w3id.org/emmo#EMMO_5fde0fa1_bbb3_42a9_ac2d_d144771aeb4b"></see></summary>
    let EMMO_5fde0fa1_bbb3_42a9_ac2d_d144771aeb4b =
        Namespaced_IRI.parse _namespace_name "EMMO_5fde0fa1_bbb3_42a9_ac2d_d144771aeb4b" |> NamespacedName

    /// <summary>
    /// Here is assumed that the concept of 'object' is always relative to a 'semiotic' process. An 'object' does not exists per se, but it's always part of an interpretation.
    ///
    /// The EMMO relies on strong reductionism, i.e. everything real is a formless collection of elementary particles: we give a meaning to real world entities only by giving them boundaries and defining them using 'sign'-s.
    ///
    /// In this way the 'sign'-ed entity becomes an 'object', and the 'object' is the basic entity needed in order to apply a logical formalism to the real world entities (i.e. we can speak of it through its sign, and use logics on it through its sign).
    /// The object, in Peirce semiotics, as participant to a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_6f5af708_f825_4feb_a0d1_a8d813d3022b"></see></summary>
    let EMMO_6f5af708_f825_4feb_a0d1_a8d813d3022b =
        Namespaced_IRI.parse _namespace_name "EMMO_6f5af708_f825_4feb_a0d1_a8d813d3022b" |> NamespacedName

    /// <summary>
    /// The inverse relation of hasSign.
    /// <see href="https://w3id.org/emmo#EMMO_61f264fa_1f23_47f0_aa1c_c947d0be56fc"></see></summary>
    let EMMO_61f264fa_1f23_47f0_aa1c_c947d0be56fc =
        Namespaced_IRI.parse _namespace_name "EMMO_61f264fa_1f23_47f0_aa1c_c947d0be56fc" |> NamespacedName

    /// <summary>
    /// Vector k in the expression ω t−k⋅r+ϑ0 of the phase of a sinusoidal wave.
    /// <see href="https://w3id.org/emmo#EMMO_6074aa9d_7c3b_4011_b45a_4e7cde6f5f39"></see></summary>
    let EMMO_6074aa9d_7c3b_4011_b45a_4e7cde6f5f39 =
        Namespaced_IRI.parse _namespace_name "EMMO_6074aa9d_7c3b_4011_b45a_4e7cde6f5f39" |> NamespacedName

    /// <summary>
    /// The inverse of length.
    /// <see href="https://w3id.org/emmo#EMMO_ecec2983_7c26_4f8d_a981_51ca29668baf"></see></summary>
    let EMMO_ecec2983_7c26_4f8d_a981_51ca29668baf =
        Namespaced_IRI.parse _namespace_name "EMMO_ecec2983_7c26_4f8d_a981_51ca29668baf" |> NamespacedName

    /// <summary>
    /// In condensed matter physics, position vector of an atom or ion in equilibrium.
    /// <see href="https://w3id.org/emmo#EMMO_6110af0a_bc82_4c9e_aa4b_b45d08d9c9e0"></see></summary>
    let EMMO_6110af0a_bc82_4c9e_aa4b_b45d08d9c9e0 =
        Namespaced_IRI.parse _namespace_name "EMMO_6110af0a_bc82_4c9e_aa4b_b45d08d9c9e0" |> NamespacedName

    /// <summary>
    /// Sum of electric current and displacement current
    /// <see href="https://w3id.org/emmo#EMMO_614c1bd9_93df_4248_861c_44b86d854739"></see></summary>
    let EMMO_614c1bd9_93df_4248_861c_44b86d854739 =
        Namespaced_IRI.parse _namespace_name "EMMO_614c1bd9_93df_4248_861c_44b86d854739" |> NamespacedName

    /// <summary>
    /// The DBpedia definition (http://dbpedia.org/page/Vacuum_permittivity) is outdated since May 20, 2019. It is now a measured constant.
    /// The value of the absolute dielectric permittivity of classical vacuum.
    /// <see href="https://w3id.org/emmo#EMMO_61a32ae9_8200_473a_bd55_59a9899996f4"></see></summary>
    let EMMO_61a32ae9_8200_473a_bd55_59a9899996f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_61a32ae9_8200_473a_bd55_59a9899996f4" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerLengthTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_61eec472_f9af_4861_bedd_d741f022a7e5"></see></summary>
    let EMMO_61eec472_f9af_4861_bedd_d741f022a7e5 =
        Namespaced_IRI.parse _namespace_name "EMMO_61eec472_f9af_4861_bedd_d741f022a7e5" |> NamespacedName

    /// <summary>
    /// The integral over a time interval of the instantaneous power.
    /// <see href="https://w3id.org/emmo#EMMO_621607ae_90ef_4f48_845e_3b53091a9340"></see></summary>
    let EMMO_621607ae_90ef_4f48_845e_3b53091a9340 =
        Namespaced_IRI.parse _namespace_name "EMMO_621607ae_90ef_4f48_845e_3b53091a9340" |> NamespacedName

    /// <summary>
    /// Ratio of the partial pressure p of water vapour in moist air to its partial pressure psat at saturation, at the same temperature φ = p/psat.
    /// The relative humidity is often expressed in per cent.
    /// <see href="https://w3id.org/emmo#EMMO_62273272_4cec_4168_bc7b_448f57feaba6"></see></summary>
    let EMMO_62273272_4cec_4168_bc7b_448f57feaba6 =
        Namespaced_IRI.parse _namespace_name "EMMO_62273272_4cec_4168_bc7b_448f57feaba6" |> NamespacedName

    /// <summary>
    /// Ratio of the mass concentration of water vapour v to its mass concentration at saturation vsat, at the same temperature, thus ψ = v/vsat.
    /// For normal cases, the relative humidity may be assumed to be equal to relative mass concentration of vapour.
    /// <see href="https://w3id.org/emmo#EMMO_c106f318_38b1_4261_94cc_f4ac6ccc47af"></see></summary>
    let EMMO_c106f318_38b1_4261_94cc_f4ac6ccc47af =
        Namespaced_IRI.parse _namespace_name "EMMO_c106f318_38b1_4261_94cc_f4ac6ccc47af" |> NamespacedName

    /// <summary>
    /// Product of force and displacement.
    /// <see href="https://w3id.org/emmo#EMMO_624d72ee_e676_4470_9434_c22b4190d3d5"></see></summary>
    let EMMO_624d72ee_e676_4470_9434_c22b4190d3d5 =
        Namespaced_IRI.parse _namespace_name "EMMO_624d72ee_e676_4470_9434_c22b4190d3d5" |> NamespacedName

    /// <summary>
    /// Mechanical property of linear elastic solid materials.
    /// <see href="https://w3id.org/emmo#EMMO_62824128_35bd_45c4_9516_23f3f24c8332"></see></summary>
    let EMMO_62824128_35bd_45c4_9516_23f3f24c8332 =
        Namespaced_IRI.parse _namespace_name "EMMO_62824128_35bd_45c4_9516_23f3f24c8332" |> NamespacedName

    /// <summary>
    /// Atom subclass for boron.
    /// <see href="https://w3id.org/emmo#EMMO_62cb8f50-5ce5-5f99-9cc8-514eff05d05e"></see></summary>
    let ``EMMO_62cb8f50-5ce5-5f99-9cc8-514eff05d05e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_62cb8f50-5ce5-5f99-9cc8-514eff05d05e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the boron atom.
    /// <see href="https://w3id.org/emmo#EMMO_a30e9658-1a08-50cc-b200-25dbc8add30a"></see></summary>
    let ``EMMO_a30e9658-1a08-50cc-b200-25dbc8add30a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a30e9658-1a08-50cc-b200-25dbc8add30a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the tantalum atom.
    /// <see href="https://w3id.org/emmo#EMMO_6378a9e9-29e5-5cae-b75b-46ca365e49b9"></see></summary>
    let ``EMMO_6378a9e9-29e5-5cae-b75b-46ca365e49b9`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6378a9e9-29e5-5cae-b75b-46ca365e49b9" |> NamespacedName

    /// <summary>
    /// At a given point within a domain of quasi-infinitesimal volume V, vector quantity equal to the electric dipole moment p of the substance contained within the domain divided by the volume V.
    /// <see href="https://w3id.org/emmo#EMMO_64420439_5282_4996_b6e1_2044358ac899"></see></summary>
    let EMMO_64420439_5282_4996_b6e1_2044358ac899 =
        Namespaced_IRI.parse _namespace_name "EMMO_64420439_5282_4996_b6e1_2044358ac899" |> NamespacedName

    /// <summary>
    /// A data representing an integer number &lt; 0.
    /// <see href="https://w3id.org/emmo#EMMO_648c17b7_a012_4060_a096_c76bd407804b"></see></summary>
    let EMMO_648c17b7_a012_4060_a096_c76bd407804b =
        Namespaced_IRI.parse _namespace_name "EMMO_648c17b7_a012_4060_a096_c76bd407804b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the strontium atom.
    /// <see href="https://w3id.org/emmo#EMMO_649415e4-1e31-5809-aceb-59efbba7d5f5"></see></summary>
    let ``EMMO_649415e4-1e31-5809-aceb-59efbba7d5f5`` =
        Namespaced_IRI.parse _namespace_name "EMMO_649415e4-1e31-5809-aceb-59efbba7d5f5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8f207971_aaab_48dc_a10d_55a6b4331410"></see>
    /// </summary>
    let EMMO_8f207971_aaab_48dc_a10d_55a6b4331410 =
        Namespaced_IRI.parse _namespace_name "EMMO_8f207971_aaab_48dc_a10d_55a6b4331410" |> NamespacedName

    /// <summary>
    /// A 'Perceptual' which stands for a real world object whose spatiotemporal pattern makes it identifiable by an observer through an optical perception employing the visible part of the electromagnetic spectrum.
    /// <see href="https://w3id.org/emmo#EMMO_c5ae6d8e_6b39_431f_8de4_ae4e357abc04"></see></summary>
    let EMMO_c5ae6d8e_6b39_431f_8de4_ae4e357abc04 =
        Namespaced_IRI.parse _namespace_name "EMMO_c5ae6d8e_6b39_431f_8de4_ae4e357abc04" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_dd14d055_2db0_4b81_bc97_ef6c2f72b8a0"></see>
    /// </summary>
    let EMMO_dd14d055_2db0_4b81_bc97_ef6c2f72b8a0 =
        Namespaced_IRI.parse _namespace_name "EMMO_dd14d055_2db0_4b81_bc97_ef6c2f72b8a0" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e1021593_06da_4237_8a02_29d8f6fef76d"></see>
    /// </summary>
    let EMMO_e1021593_06da_4237_8a02_29d8f6fef76d =
        Namespaced_IRI.parse _namespace_name "EMMO_e1021593_06da_4237_8a02_29d8f6fef76d" |> NamespacedName

    /// <summary>
    /// A language object respecting the syntactic rules of C++.
    /// <see href="https://w3id.org/emmo#EMMO_64aba1e5_24b7_4140_8eb4_676c35698e79"></see></summary>
    let EMMO_64aba1e5_24b7_4140_8eb4_676c35698e79 =
        Namespaced_IRI.parse _namespace_name "EMMO_64aba1e5_24b7_4140_8eb4_676c35698e79" |> NamespacedName

    /// <summary>
    /// Information is encoded data with a meaning (semiotic sign).
    /// <see href="https://w3id.org/emmo#EMMO_64c72d00_7582_44ea_a0b5_3a14e50acc36"></see></summary>
    let EMMO_64c72d00_7582_44ea_a0b5_3a14e50acc36 =
        Namespaced_IRI.parse _namespace_name "EMMO_64c72d00_7582_44ea_a0b5_3a14e50acc36" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_658b8bca_203a_49a6_920b_96b5baf5e199"></see>
    /// </summary>
    let EMMO_658b8bca_203a_49a6_920b_96b5baf5e199 =
        Namespaced_IRI.parse _namespace_name "EMMO_658b8bca_203a_49a6_920b_96b5baf5e199" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the terbium atom.
    /// <see href="https://w3id.org/emmo#EMMO_6599389d-7a26-5d51-a65c-5dd9c3ed532f"></see></summary>
    let ``EMMO_6599389d-7a26-5d51-a65c-5dd9c3ed532f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6599389d-7a26-5d51-a65c-5dd9c3ed532f" |> NamespacedName

    /// <summary>
    /// A tile that is connected with other tiles with bi-directional causal relations that fall under hasNext (or its inverse) or hasContact.
    /// This owl:ObjectProperty is, like its super property, a mere collector of direct parthoods that manifest a spatiotemporal meaningful shape.
    /// <see href="https://w3id.org/emmo#EMMO_7efab93d_c8fe_49c7_ba8e_d21d13b38c85"></see></summary>
    let EMMO_7efab93d_c8fe_49c7_ba8e_d21d13b38c85 =
        Namespaced_IRI.parse _namespace_name "EMMO_7efab93d_c8fe_49c7_ba8e_d21d13b38c85" |> NamespacedName

    /// <summary>
    /// Coefficient in the law of recombination,
    /// <see href="https://w3id.org/emmo#EMMO_65b794a4_cf52_4d0a_88c4_2c479537b30a"></see></summary>
    let EMMO_65b794a4_cf52_4d0a_88c4_2c479537b30a =
        Namespaced_IRI.parse _namespace_name "EMMO_65b794a4_cf52_4d0a_88c4_2c479537b30a" |> NamespacedName

    /// <summary>
    /// Atom subclass for samarium.
    /// <see href="https://w3id.org/emmo#EMMO_65d84215-de2a-56c9-80e3-a49d08dfc1de"></see></summary>
    let ``EMMO_65d84215-de2a-56c9-80e3-a49d08dfc1de`` =
        Namespaced_IRI.parse _namespace_name "EMMO_65d84215-de2a-56c9-80e3-a49d08dfc1de" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the samarium atom.
    /// <see href="https://w3id.org/emmo#EMMO_96252ae5-c061-5ba0-80a4-774e5d949e06"></see></summary>
    let ``EMMO_96252ae5-c061-5ba0-80a4-774e5d949e06`` =
        Namespaced_IRI.parse _namespace_name "EMMO_96252ae5-c061-5ba0-80a4-774e5d949e06" |> NamespacedName

    /// <summary>
    /// Cut-off angular frequency in the Debye model of the vibrational spectrum of a solid.
    /// <see href="https://w3id.org/emmo#EMMO_65ec122c_b67f_4009_8b16_2df7dfae118a"></see></summary>
    let EMMO_65ec122c_b67f_4009_8b16_2df7dfae118a =
        Namespaced_IRI.parse _namespace_name "EMMO_65ec122c_b67f_4009_8b16_2df7dfae118a" |> NamespacedName

    /// <summary>
    /// Rate of change of the phase angle.
    /// <see href="https://w3id.org/emmo#EMMO_f4a30d7e_8e8b_41e6_9695_d33a68f54f4b"></see></summary>
    let EMMO_f4a30d7e_8e8b_41e6_9695_d33a68f54f4b =
        Namespaced_IRI.parse _namespace_name "EMMO_f4a30d7e_8e8b_41e6_9695_d33a68f54f4b" |> NamespacedName

    /// <summary>
    /// Mass increment per time.
    /// <see href="https://w3id.org/emmo#EMMO_65efeec4_148f_4843_9954_fe52efff3441"></see></summary>
    let EMMO_65efeec4_148f_4843_9954_fe52efff3441 =
        Namespaced_IRI.parse _namespace_name "EMMO_65efeec4_148f_4843_9954_fe52efff3441" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_8826aefb_0bf6_4378_8732_fc80aa95654c"></see></summary>
    let EMMO_8826aefb_0bf6_4378_8732_fc80aa95654c =
        Namespaced_IRI.parse _namespace_name "EMMO_8826aefb_0bf6_4378_8732_fc80aa95654c" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_660a4964_0333_4663_bc66_e93ef59b0679"></see>
    /// </summary>
    let EMMO_660a4964_0333_4663_bc66_e93ef59b0679 =
        Namespaced_IRI.parse _namespace_name "EMMO_660a4964_0333_4663_bc66_e93ef59b0679" |> NamespacedName

    /// <summary>
    /// Since measurement uncertainty is a subclass of objective property, this relation can also describe the uncertainty of an measurement uncertainty.
    /// Assigns a quantifiable uncertainty to an objective property through a well-defined procecure.
    /// <see href="https://w3id.org/emmo#EMMO_662c64e7_fc72_49b3_a161_f50fd42deafa"></see></summary>
    let EMMO_662c64e7_fc72_49b3_a161_f50fd42deafa =
        Namespaced_IRI.parse _namespace_name "EMMO_662c64e7_fc72_49b3_a161_f50fd42deafa" |> NamespacedName

    /// <summary>
    /// Metrological uncertainty in EMMO is a slight generalisation of the VIM term 'measurement uncertainty', which is defined as "a non-negative parameter characterising the dispersion of the quantity being measured".
    /// In general, for a given set of information, it is understood that the measurement uncertainty is associated with a stated quantity value. A modification of this value results in a modification of the associated uncertainty.
    /// The uncertainty of a quantity obtained through a well-defined procedure, characterising of the dispersion of the quantity.
    /// Metrological uncertainty includes components arising from systematic effects, such as components associated with corrections and the assigned quantity values of measurement standards, as well as the definitional uncertainty. Sometimes estimated systematic effects are not corrected for but, instead, associated measurement uncertainty components are incorporated.
    /// <see href="https://w3id.org/emmo#EMMO_847724b7_acef_490e_9f0d_67da967f2812"></see></summary>
    let EMMO_847724b7_acef_490e_9f0d_67da967f2812 =
        Namespaced_IRI.parse _namespace_name "EMMO_847724b7_acef_490e_9f0d_67da967f2812" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_662e94ea_babe_4709_af8f_b669931076bc"></see>
    /// </summary>
    let EMMO_662e94ea_babe_4709_af8f_b669931076bc =
        Namespaced_IRI.parse _namespace_name "EMMO_662e94ea_babe_4709_af8f_b669931076bc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d7432d8c_3182_4d61_a08f_dc686efaabe9"></see>
    /// </summary>
    let EMMO_d7432d8c_3182_4d61_a08f_dc686efaabe9 =
        Namespaced_IRI.parse _namespace_name "EMMO_d7432d8c_3182_4d61_a08f_dc686efaabe9" |> NamespacedName

    /// <summary>
    /// A relation between the whole and one of its tiles, where the tile is both spatially and temporally connected with the other tiles forming the tessellation.
    /// <see href="https://w3id.org/emmo#EMMO_663859e5_add3_4c9e_96fb_c99399de278d"></see></summary>
    let EMMO_663859e5_add3_4c9e_96fb_c99399de278d =
        Namespaced_IRI.parse _namespace_name "EMMO_663859e5_add3_4c9e_96fb_c99399de278d" |> NamespacedName

    /// <summary>
    /// A state that is a collection of sufficiently large number of other parts such that:
    /// - it is the bearer of qualities that can exists only by the fact that it is a sum of parts
    /// - the smallest partition dV of the state volume in which we are interested in, contains enough parts to be statistically consistent: n [#/m3] x dV [m3] &gt;&gt; 1
    /// A continuum is made of a sufficient number of parts that it continues to exists as continuum individual even after the loss of one of them i.e. a continuum is a redundant.
    /// <see href="https://w3id.org/emmo#EMMO_8b0923ab_b500_477b_9ce9_8b3a3e4dc4f2"></see></summary>
    let EMMO_8b0923ab_b500_477b_9ce9_8b3a3e4dc4f2 =
        Namespaced_IRI.parse _namespace_name "EMMO_8b0923ab_b500_477b_9ce9_8b3a3e4dc4f2" |> NamespacedName

    /// <summary>
    /// An objective comparative measure of hot or cold.
    ///
    /// Temperature is a relative quantity that can be used to express temperature differences. Unlike ThermodynamicTemperature, it cannot express absolute temperatures.
    /// <see href="https://w3id.org/emmo#EMMO_66bc9029_f473_45ff_bab9_c3509ff37a22"></see></summary>
    let EMMO_66bc9029_f473_45ff_bab9_c3509ff37a22 =
        Namespaced_IRI.parse _namespace_name "EMMO_66bc9029_f473_45ff_bab9_c3509ff37a22" |> NamespacedName

    /// <summary>
    /// Measure of the extent and direction an object rotates about a reference point.
    /// <see href="https://w3id.org/emmo#EMMO_66d01570_36dd_42fd_844d_29b81b029cd5"></see></summary>
    let EMMO_66d01570_36dd_42fd_844d_29b81b029cd5 =
        Namespaced_IRI.parse _namespace_name "EMMO_66d01570_36dd_42fd_844d_29b81b029cd5" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the sulfur atom.
    /// <see href="https://w3id.org/emmo#EMMO_66d895f4-42fa-58a2-89af-ef065f52c1eb"></see></summary>
    let ``EMMO_66d895f4-42fa-58a2-89af-ef065f52c1eb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_66d895f4-42fa-58a2-89af-ef065f52c1eb" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperatureAreaPerMassTime'.
    /// <see href="https://w3id.org/emmo#EMMO_66e91d9a_05c1_4906_9731_3f4d8c4f3fd8"></see></summary>
    let EMMO_66e91d9a_05c1_4906_9731_3f4d8c4f3fd8 =
        Namespaced_IRI.parse _namespace_name "EMMO_66e91d9a_05c1_4906_9731_3f4d8c4f3fd8" |> NamespacedName

    /// <summary>
    /// Constant of a chemical reaction. It is the value of its reaction quotient at chemical equilibrium, a state approached by a dynamic chemical system after sufficient time has elapsed at which its composition has no measurable tendency towards further change.
    /// <see href="https://w3id.org/emmo#EMMO_672e2475_8376_4987_82cf_097f0024e74b"></see></summary>
    let EMMO_672e2475_8376_4987_82cf_097f0024e74b =
        Namespaced_IRI.parse _namespace_name "EMMO_672e2475_8376_4987_82cf_097f0024e74b" |> NamespacedName

    /// <summary>
    /// Magnetic tension divided by magnetic flux.
    /// <see href="https://w3id.org/emmo#EMMO_673433f6_47c6_4c28_ae91_12945488ed10"></see></summary>
    let EMMO_673433f6_47c6_4c28_ae91_12945488ed10 =
        Namespaced_IRI.parse _namespace_name "EMMO_673433f6_47c6_4c28_ae91_12945488ed10" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the indium atom.
    /// <see href="https://w3id.org/emmo#EMMO_67589be3-8acd-5230-bc54-89280412a3fb"></see></summary>
    let ``EMMO_67589be3-8acd-5230-bc54-89280412a3fb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_67589be3-8acd-5230-bc54-89280412a3fb" |> NamespacedName

    /// <summary>
    /// Atom subclass for bohrium.
    /// <see href="https://w3id.org/emmo#EMMO_67761ddc-260b-5945-bfc3-311813ab71c9"></see></summary>
    let ``EMMO_67761ddc-260b-5945-bfc3-311813ab71c9`` =
        Namespaced_IRI.parse _namespace_name "EMMO_67761ddc-260b-5945-bfc3-311813ab71c9" |> NamespacedName

    /// <summary>
    /// Non-SI units mentioned in the SI.
    /// This is a list of units that are not defined as part of the International System of Units (SI), but are otherwise mentioned in the SI brouchure, because either the General Conference on Weights and Measures (CGPM) accepts their use as being multiples or submultiples of SI-units, they have important contemporary application worldwide, or are otherwise commonly encountered worldwide.
    /// <see href="https://w3id.org/emmo#EMMO_6795a4b8_ffd0_4588_a581_a9413fe49cac"></see></summary>
    let EMMO_6795a4b8_ffd0_4588_a581_a9413fe49cac =
        Namespaced_IRI.parse _namespace_name "EMMO_6795a4b8_ffd0_4588_a581_a9413fe49cac" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_6796ec88_e49f_4628_b28d_6559f9dd630a"></see>
    /// </summary>
    let EMMO_6796ec88_e49f_4628_b28d_6559f9dd630a =
        Namespaced_IRI.parse _namespace_name "EMMO_6796ec88_e49f_4628_b28d_6559f9dd630a" |> NamespacedName

    /// <summary>
    /// A computational application that uses an empiric equation to predict the behaviour of a system without relying on the knowledge of the actual physical phenomena occurring in the object.
    /// <see href="https://w3id.org/emmo#EMMO_67c70dcd_2adf_4e6c_b3f8_f33dd1512487"></see></summary>
    let EMMO_67c70dcd_2adf_4e6c_b3f8_f33dd1512487 =
        Namespaced_IRI.parse _namespace_name "EMMO_67c70dcd_2adf_4e6c_b3f8_f33dd1512487" |> NamespacedName

    /// <summary>
    /// An application aimed to functionally reproduce an object.
    /// <see href="https://w3id.org/emmo#EMMO_8b66ada5_510c_44bd_a8d8_3c64d301a5e9"></see></summary>
    let EMMO_8b66ada5_510c_44bd_a8d8_3c64d301a5e9 =
        Namespaced_IRI.parse _namespace_name "EMMO_8b66ada5_510c_44bd_a8d8_3c64d301a5e9" |> NamespacedName

    /// <summary>
    /// Atom subclass for seaborgium.
    /// <see href="https://w3id.org/emmo#EMMO_67eaac8f-7f83-5bca-b1d0-10451d3a88a1"></see></summary>
    let ``EMMO_67eaac8f-7f83-5bca-b1d0-10451d3a88a1`` =
        Namespaced_IRI.parse _namespace_name "EMMO_67eaac8f-7f83-5bca-b1d0-10451d3a88a1" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricPotentialPerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_6837b106_7220_4ec6_b7c9_d549d6163672"></see></summary>
    let EMMO_6837b106_7220_4ec6_b7c9_d549d6163672 =
        Namespaced_IRI.parse _namespace_name "EMMO_6837b106_7220_4ec6_b7c9_d549d6163672" |> NamespacedName

    /// <summary>
    /// A material that takes active part in a chemical reaction.
    /// <see href="https://w3id.org/emmo#EMMO_68390bfb_e307_479d_8f78_d66d8773cb1d"></see></summary>
    let EMMO_68390bfb_e307_479d_8f78_d66d8773cb1d =
        Namespaced_IRI.parse _namespace_name "EMMO_68390bfb_e307_479d_8f78_d66d8773cb1d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a96e2152_40e7_409c_a53a_fdb9f141eb6a"></see>
    /// </summary>
    let EMMO_a96e2152_40e7_409c_a53a_fdb9f141eb6a =
        Namespaced_IRI.parse _namespace_name "EMMO_a96e2152_40e7_409c_a53a_fdb9f141eb6a" |> NamespacedName

    /// <summary>
    /// Magnitude of the magnetic moment of an electron in a state with orbital angular momentum quantum number l=1 due to its orbital motion.
    /// <see href="https://w3id.org/emmo#EMMO_6884600e_5d9b_44b1_9fc5_7d4dc1639e2f"></see></summary>
    let EMMO_6884600e_5d9b_44b1_9fc5_7d4dc1639e2f =
        Namespaced_IRI.parse _namespace_name "EMMO_6884600e_5d9b_44b1_9fc5_7d4dc1639e2f" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the tungsten atom.
    /// <see href="https://w3id.org/emmo#EMMO_68a887df-63af-55c0-8239-b0b8edaa94ea"></see></summary>
    let ``EMMO_68a887df-63af-55c0-8239-b0b8edaa94ea`` =
        Namespaced_IRI.parse _namespace_name "EMMO_68a887df-63af-55c0-8239-b0b8edaa94ea" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_68d094e2_1777_48b5_8e43_32965f824970"></see>
    /// </summary>
    let EMMO_68d094e2_1777_48b5_8e43_32965f824970 =
        Namespaced_IRI.parse _namespace_name "EMMO_68d094e2_1777_48b5_8e43_32965f824970" |> NamespacedName

    /// <summary>
    /// Atom subclass for germanium.
    /// <see href="https://w3id.org/emmo#EMMO_694e27a2-f3ee-5a3e-8851-d6f78d79d84e"></see></summary>
    let ``EMMO_694e27a2-f3ee-5a3e-8851-d6f78d79d84e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_694e27a2-f3ee-5a3e-8851-d6f78d79d84e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the germanium atom.
    /// <see href="https://w3id.org/emmo#EMMO_6b670dce-5692-5505-9688-8f735b325214"></see></summary>
    let ``EMMO_6b670dce-5692-5505-9688-8f735b325214`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6b670dce-5692-5505-9688-8f735b325214" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the argon atom.
    /// <see href="https://w3id.org/emmo#EMMO_69e0ff08-9843-5ca2-b2bb-58467b07c4bb"></see></summary>
    let ``EMMO_69e0ff08-9843-5ca2-b2bb-58467b07c4bb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_69e0ff08-9843-5ca2-b2bb-58467b07c4bb" |> NamespacedName

    /// <summary>
    /// A symbolic data representing a rational number, that is a number that can be expressed exact by `p/q` where `p` and `q` are integer numbers.
    /// <see href="https://w3id.org/emmo#EMMO_69ebb235_9c5e_443d_9a3b_7042b1005f1f"></see></summary>
    let EMMO_69ebb235_9c5e_443d_9a3b_7042b1005f1f =
        Namespaced_IRI.parse _namespace_name "EMMO_69ebb235_9c5e_443d_9a3b_7042b1005f1f" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'InverseSquareMass'.
    /// <see href="https://w3id.org/emmo#EMMO_6aa04359_50d6_43d7_b3a7_296bd391bf7d"></see></summary>
    let EMMO_6aa04359_50d6_43d7_b3a7_296bd391bf7d =
        Namespaced_IRI.parse _namespace_name "EMMO_6aa04359_50d6_43d7_b3a7_296bd391bf7d" |> NamespacedName

    /// <summary>
    /// Angular wavenumber of electrons in states on the Fermi sphere.
    /// <see href="https://w3id.org/emmo#EMMO_6aad14ae_5ca1_4d19_aa6c_56448ff534b6"></see></summary>
    let EMMO_6aad14ae_5ca1_4d19_aa6c_56448ff534b6 =
        Namespaced_IRI.parse _namespace_name "EMMO_6aad14ae_5ca1_4d19_aa6c_56448ff534b6" |> NamespacedName

    /// <summary>
    /// Magnitude of the wave vector.
    /// <see href="https://w3id.org/emmo#EMMO_ba236f43_7f94_4386_9673_9122952e928b"></see></summary>
    let EMMO_ba236f43_7f94_4386_9673_9122952e928b =
        Namespaced_IRI.parse _namespace_name "EMMO_ba236f43_7f94_4386_9673_9122952e928b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_eb85216f_b872_4ee5_9f62_655aa2ae0470"></see>
    /// </summary>
    let EMMO_eb85216f_b872_4ee5_9f62_655aa2ae0470 =
        Namespaced_IRI.parse _namespace_name "EMMO_eb85216f_b872_4ee5_9f62_655aa2ae0470" |> NamespacedName

    /// <summary>
    /// An expression that provide information about the element type of a compound and their relative ratio.
    /// <see href="https://w3id.org/emmo#EMMO_6afdb7e8_2a0b_444d_bde3_8d67d98180c0"></see></summary>
    let EMMO_6afdb7e8_2a0b_444d_bde3_8d67d98180c0 =
        Namespaced_IRI.parse _namespace_name "EMMO_6afdb7e8_2a0b_444d_bde3_8d67d98180c0" |> NamespacedName

    /// <summary>
    /// Critical thermodynamic temperature of a ferromagnet.
    /// <see href="https://w3id.org/emmo#EMMO_6b5af5a8_a2d8_4353_a1d6_54c9f778343d"></see></summary>
    let EMMO_6b5af5a8_a2d8_4353_a1d6_54c9f778343d =
        Namespaced_IRI.parse _namespace_name "EMMO_6b5af5a8_a2d8_4353_a1d6_54c9f778343d" |> NamespacedName

    /// <summary>
    /// Temperature below which quantum effects dominate.
    /// <see href="https://w3id.org/emmo#EMMO_83424a56_e28f_4aea_8125_bef7b9347ee6"></see></summary>
    let EMMO_83424a56_e28f_4aea_8125_bef7b9347ee6 =
        Namespaced_IRI.parse _namespace_name "EMMO_83424a56_e28f_4aea_8125_bef7b9347ee6" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'JosephsonConstant'.
    /// <see href="https://w3id.org/emmo#EMMO_6b8bf0c9_4ec7_452c_bee5_26e5149a4f05"></see></summary>
    let EMMO_6b8bf0c9_4ec7_452c_bee5_26e5149a4f05 =
        Namespaced_IRI.parse _namespace_name "EMMO_6b8bf0c9_4ec7_452c_bee5_26e5149a4f05" |> NamespacedName

    /// <summary>
    /// Energy to be added to or removed from a system under constant temperature and pressure to undergo a complete phase transition.
    /// <see href="https://w3id.org/emmo#EMMO_6bae1f5a_1644_4da3_b3e4_0a01171034ad"></see></summary>
    let EMMO_6bae1f5a_1644_4da3_b3e4_0a01171034ad =
        Namespaced_IRI.parse _namespace_name "EMMO_6bae1f5a_1644_4da3_b3e4_0a01171034ad" |> NamespacedName

    /// <summary>
    /// Heat released or absorbed energy during a constant-temperature process.
    /// <see href="https://w3id.org/emmo#EMMO_fb1e757e_087e_4541_847f_392990643f64"></see></summary>
    let EMMO_fb1e757e_087e_4541_847f_392990643f64 =
        Namespaced_IRI.parse _namespace_name "EMMO_fb1e757e_087e_4541_847f_392990643f64" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerTemperatureTime'.
    /// <see href="https://w3id.org/emmo#EMMO_6bcf334d_efeb_49f8_9dd0_dbcbb31514d3"></see></summary>
    let EMMO_6bcf334d_efeb_49f8_9dd0_dbcbb31514d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_6bcf334d_efeb_49f8_9dd0_dbcbb31514d3" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the phosphorus atom.
    /// <see href="https://w3id.org/emmo#EMMO_6bd7b6f4-db3b-58da-b9a0-58f44bb3ed37"></see></summary>
    let ``EMMO_6bd7b6f4-db3b-58da-b9a0-58f44bb3ed37`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6bd7b6f4-db3b-58da-b9a0-58f44bb3ed37" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_6c213064_e525_45d4_99cf_afebed8bbddd"></see>
    /// </summary>
    let EMMO_6c213064_e525_45d4_99cf_afebed8bbddd =
        Namespaced_IRI.parse _namespace_name "EMMO_6c213064_e525_45d4_99cf_afebed8bbddd" |> NamespacedName

    /// <summary>
    /// The 'semiosis' process of interpreting a 'physical' and provide a complec sign, 'theory' that stands for it and explain it to another interpreter.
    /// <see href="https://w3id.org/emmo#EMMO_6c739b1a_a774_4416_bb31_1961486fa9ed"></see></summary>
    let EMMO_6c739b1a_a774_4416_bb31_1961486fa9ed =
        Namespaced_IRI.parse _namespace_name "EMMO_6c739b1a_a774_4416_bb31_1961486fa9ed" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'QuarticLengthPerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_6cfc5b82_b47b_47bc_bb45_c23c273d2e06"></see></summary>
    let EMMO_6cfc5b82_b47b_47bc_bb45_c23c273d2e06 =
        Namespaced_IRI.parse _namespace_name "EMMO_6cfc5b82_b47b_47bc_bb45_c23c273d2e06" |> NamespacedName

    /// <summary>
    /// Number of donor levels per volume.
    /// <see href="https://w3id.org/emmo#EMMO_6d53d04c_07d3_4522_9181_92649ef78f86"></see></summary>
    let EMMO_6d53d04c_07d3_4522_9181_92649ef78f86 =
        Namespaced_IRI.parse _namespace_name "EMMO_6d53d04c_07d3_4522_9181_92649ef78f86" |> NamespacedName

    /// <summary>
    /// At a point in a fluid, the product of mass density and velocity.
    /// <see href="https://w3id.org/emmo#EMMO_6d61ee3c_c5b6_4452_bc11_e9c33af992a7"></see></summary>
    let EMMO_6d61ee3c_c5b6_4452_bc11_e9c33af992a7 =
        Namespaced_IRI.parse _namespace_name "EMMO_6d61ee3c_c5b6_4452_bc11_e9c33af992a7" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassFlux'.
    /// <see href="https://w3id.org/emmo#EMMO_e35d4936_b2e3_4cd6_a437_f1c864b3d450"></see></summary>
    let EMMO_e35d4936_b2e3_4cd6_a437_f1c864b3d450 =
        Namespaced_IRI.parse _namespace_name "EMMO_e35d4936_b2e3_4cd6_a437_f1c864b3d450" |> NamespacedName

    /// <summary>
    /// In an infinite homogenous medium, one-sixth of the mean square of the distance between the neutron source and the point where a neutron reaches a given energy.
    /// <see href="https://w3id.org/emmo#EMMO_6d7158f3_7d96_498f_9cf3_31f4798f31c6"></see></summary>
    let EMMO_6d7158f3_7d96_498f_9cf3_31f4798f31c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_6d7158f3_7d96_498f_9cf3_31f4798f31c6" |> NamespacedName

    /// <summary>
    /// Differential quotient of fluence Φ with respect to time.
    /// <see href="https://w3id.org/emmo#EMMO_6de11e9b_8dcb_444b_ba79_1a55130ed0c8"></see></summary>
    let EMMO_6de11e9b_8dcb_444b_ba79_1a55130ed0c8 =
        Namespaced_IRI.parse _namespace_name "EMMO_6de11e9b_8dcb_444b_ba79_1a55130ed0c8" |> NamespacedName

    /// <summary>
    /// A function solution of a physics equation that provides a methods for the prediction of some quantitiative properties of an object.
    /// This must be a mathematical function v(t), x(t).
    /// A dataset as solution is a conventional sign.
    /// <see href="https://w3id.org/emmo#EMMO_6e0664f2_4d4d_4407_bf60_e1b3c07198d7"></see></summary>
    let EMMO_6e0664f2_4d4d_4407_bf60_e1b3c07198d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_6e0664f2_4d4d_4407_bf60_e1b3c07198d7" |> NamespacedName

    /// <summary>
    /// Atom subclass for plutonium.
    /// <see href="https://w3id.org/emmo#EMMO_6e467e25-2883-5f7b-a60f-2f4b651bba3f"></see></summary>
    let ``EMMO_6e467e25-2883-5f7b-a60f-2f4b651bba3f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_6e467e25-2883-5f7b-a60f-2f4b651bba3f" |> NamespacedName

    /// <summary>
    /// Atomic quantum number related to the z component lz, jz or sz, of the orbital, total, or spin angular momentum.
    /// <see href="https://w3id.org/emmo#EMMO_6e5608ec_7768_4764_b052_2254bb5283bb"></see></summary>
    let EMMO_6e5608ec_7768_4764_b052_2254bb5283bb =
        Namespaced_IRI.parse _namespace_name "EMMO_6e5608ec_7768_4764_b052_2254bb5283bb" |> NamespacedName

    /// <summary>
    /// A physics-based model based on a physics equation describing the behaviour of electrons.
    /// <see href="https://w3id.org/emmo#EMMO_6eca09be_17e9_445e_abc9_000aa61b7a11"></see></summary>
    let EMMO_6eca09be_17e9_445e_abc9_000aa61b7a11 =
        Namespaced_IRI.parse _namespace_name "EMMO_6eca09be_17e9_445e_abc9_000aa61b7a11" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two areas.
    /// <see href="https://w3id.org/emmo#EMMO_6f4d704a_a7c6_4c07_b8a7_ea0bab04128f"></see></summary>
    let EMMO_6f4d704a_a7c6_4c07_b8a7_ea0bab04128f =
        Namespaced_IRI.parse _namespace_name "EMMO_6f4d704a_a7c6_4c07_b8a7_ea0bab04128f" |> NamespacedName

    /// <summary>
    /// Parameter in the expression for the thermionic emission current density J for a metal in terms of the thermodynamic temperature T and work function.
    /// <see href="https://w3id.org/emmo#EMMO_6f55a062_4a3b_4bb7_b2d3_54a4a93ce5cc"></see></summary>
    let EMMO_6f55a062_4a3b_4bb7_b2d3_54a4a93ce5cc =
        Namespaced_IRI.parse _namespace_name "EMMO_6f55a062_4a3b_4bb7_b2d3_54a4a93ce5cc" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TimePerVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_6f76f9bf_feb3_4e27_9bcb_45b5f3526050"></see></summary>
    let EMMO_6f76f9bf_feb3_4e27_9bcb_45b5f3526050 =
        Namespaced_IRI.parse _namespace_name "EMMO_6f76f9bf_feb3_4e27_9bcb_45b5f3526050" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_704630b8_fee3_49b9_baca_40e2dd276370"></see>
    /// </summary>
    let EMMO_704630b8_fee3_49b9_baca_40e2dd276370 =
        Namespaced_IRI.parse _namespace_name "EMMO_704630b8_fee3_49b9_baca_40e2dd276370" |> NamespacedName

    /// <summary>
    /// Atom subclass for tennessine.
    /// <see href="https://w3id.org/emmo#EMMO_706cac26-78f1-5ca4-a63c-2600828db412"></see></summary>
    let ``EMMO_706cac26-78f1-5ca4-a63c-2600828db412`` =
        Namespaced_IRI.parse _namespace_name "EMMO_706cac26-78f1-5ca4-a63c-2600828db412" |> NamespacedName

    /// <summary>
    /// A unit that can be expressed as a product of powers of SI base units with no pre-factor of offset.
    /// Derived units are defined as products of powers of the base units. When the numerical factor of this product is one, the derived units are called coherent derived units. The base and coherent derived units of the SI form a coherent set, designated the set of coherent SI units.
    /// <see href="https://w3id.org/emmo#EMMO_707c6032_e272_4a20_98b5_d35c4f67be68"></see></summary>
    let EMMO_707c6032_e272_4a20_98b5_d35c4f67be68 =
        Namespaced_IRI.parse _namespace_name "EMMO_707c6032_e272_4a20_98b5_d35c4f67be68" |> NamespacedName

    /// <summary>
    /// A symbolic data that is not array data.
    /// Scalar data are primitive symbolic data that are not built up of other types of symbolic data.
    /// <see href="https://w3id.org/emmo#EMMO_dd8301d8_affa_4b1d_8db8_7b9d0a1f2ee7"></see></summary>
    let EMMO_dd8301d8_affa_4b1d_8db8_7b9d0a1f2ee7 =
        Namespaced_IRI.parse _namespace_name "EMMO_dd8301d8_affa_4b1d_8db8_7b9d0a1f2ee7" |> NamespacedName

    /// <summary>
    /// The inverse relation of hasDescription.
    /// <see href="https://w3id.org/emmo#EMMO_7159549c_16a3_4dd3_b37d_e992ad0b0879"></see></summary>
    let EMMO_7159549c_16a3_4dd3_b37d_e992ad0b0879 =
        Namespaced_IRI.parse _namespace_name "EMMO_7159549c_16a3_4dd3_b37d_e992ad0b0879" |> NamespacedName

    /// <summary>
    /// A semiotic relation that connects a declared semiotic object to a description in a declaration process.
    /// <see href="https://w3id.org/emmo#EMMO_c58c799e_cc6c_4310_a3f1_78da70705b2a"></see></summary>
    let EMMO_c58c799e_cc6c_4310_a3f1_78da70705b2a =
        Namespaced_IRI.parse _namespace_name "EMMO_c58c799e_cc6c_4310_a3f1_78da70705b2a" |> NamespacedName

    /// <summary>
    /// The inverse relation of hasConvention.
    /// <see href="https://w3id.org/emmo#EMMO_e58bd4f4_a343_4831_be59_bf753075edb0"></see></summary>
    let EMMO_e58bd4f4_a343_4831_be59_bf753075edb0 =
        Namespaced_IRI.parse _namespace_name "EMMO_e58bd4f4_a343_4831_be59_bf753075edb0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the lead atom.
    /// <see href="https://w3id.org/emmo#EMMO_717d8808-5085-5f35-86b4-6bc75bafac0b"></see></summary>
    let ``EMMO_717d8808-5085-5f35-86b4-6bc75bafac0b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_717d8808-5085-5f35-86b4-6bc75bafac0b" |> NamespacedName

    /// <summary>
    /// Quantity in condensed matter physics.
    /// <see href="https://w3id.org/emmo#EMMO_71a0d05d_4c29_4eae_aff1_fb34b8d36f96"></see></summary>
    let EMMO_71a0d05d_4c29_4eae_aff1_fb34b8d36f96 =
        Namespaced_IRI.parse _namespace_name "EMMO_71a0d05d_4c29_4eae_aff1_fb34b8d36f96" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyDensityOfStates'.
    /// <see href="https://w3id.org/emmo#EMMO_971c8cb1_156f_4a70_a72c_2d851d4d2b20"></see></summary>
    let EMMO_971c8cb1_156f_4a70_a72c_2d851d4d2b20 =
        Namespaced_IRI.parse _namespace_name "EMMO_971c8cb1_156f_4a70_a72c_2d851d4d2b20" |> NamespacedName

    /// <summary>
    /// quotient of the number of vibrational modes in an infinitesimal interval of angular frequency, and the product of the width of that interval and volume
    /// <see href="https://w3id.org/emmo#EMMO_88bbdd04_908f_45f0_9ded_d73b430de3b1"></see></summary>
    let EMMO_88bbdd04_908f_45f0_9ded_d73b430de3b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_88bbdd04_908f_45f0_9ded_d73b430de3b1" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the iron atom.
    /// <see href="https://w3id.org/emmo#EMMO_71b5082d-9908-5011-8ad0-b2ab70ffd08c"></see></summary>
    let ``EMMO_71b5082d-9908-5011-8ad0-b2ab70ffd08c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_71b5082d-9908-5011-8ad0-b2ab70ffd08c" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_71b7346e_5a4a_4b2b_8ac5_d41ecc9c7bfd"></see>
    /// </summary>
    let EMMO_71b7346e_5a4a_4b2b_8ac5_d41ecc9c7bfd =
        Namespaced_IRI.parse _namespace_name "EMMO_71b7346e_5a4a_4b2b_8ac5_d41ecc9c7bfd" |> NamespacedName

    /// <summary>
    /// Atom subclass for gallium.
    /// <see href="https://w3id.org/emmo#EMMO_71c716bf-75bb-529f-b7c8-9d36a7c58b3a"></see></summary>
    let ``EMMO_71c716bf-75bb-529f-b7c8-9d36a7c58b3a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_71c716bf-75bb-529f-b7c8-9d36a7c58b3a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the gallium atom.
    /// <see href="https://w3id.org/emmo#EMMO_b546b51b-c19d-5368-8810-c9e4e9b1c1f3"></see></summary>
    let ``EMMO_b546b51b-c19d-5368-8810-c9e4e9b1c1f3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b546b51b-c19d-5368-8810-c9e4e9b1c1f3" |> NamespacedName

    /// <summary>
    /// A material process requires the output to be classified as an individual of a material subclass.
    /// A manufacturing process aimed to modify the precursor objects through a physical process (involving other materials, energy, manipulation) to change its material properties.
    /// <see href="https://w3id.org/emmo#EMMO_71d1c8f0_c6e3_44b5_a4b6_1b74ff35698a"></see></summary>
    let EMMO_71d1c8f0_c6e3_44b5_a4b6_1b74ff35698a =
        Namespaced_IRI.parse _namespace_name "EMMO_71d1c8f0_c6e3_44b5_a4b6_1b74ff35698a" |> NamespacedName

    /// <summary>
    /// Quotient of the activity A of a sample and the total area S of the surface of that sample.
    /// <see href="https://w3id.org/emmo#EMMO_7214db6c_32e3_436f_85a4_24785f0e3714"></see></summary>
    let EMMO_7214db6c_32e3_436f_85a4_24785f0e3714 =
        Namespaced_IRI.parse _namespace_name "EMMO_7214db6c_32e3_436f_85a4_24785f0e3714" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Diffusivity'.
    /// <see href="https://w3id.org/emmo#EMMO_721be099_4826_4b51_a78f_542b5728bd74"></see></summary>
    let EMMO_721be099_4826_4b51_a78f_542b5728bd74 =
        Namespaced_IRI.parse _namespace_name "EMMO_721be099_4826_4b51_a78f_542b5728bd74" |> NamespacedName

    /// <summary>
    /// Magnetic flux the integration area of which is such that magnetic field lines cross it in the same orientation more than once.
    /// <see href="https://w3id.org/emmo#EMMO_72301c89_4337_48f5_a390_7649c5fad98b"></see></summary>
    let EMMO_72301c89_4337_48f5_a390_7649c5fad98b =
        Namespaced_IRI.parse _namespace_name "EMMO_72301c89_4337_48f5_a390_7649c5fad98b" |> NamespacedName

    /// <summary>
    /// Atom subclass for krypton.
    /// <see href="https://w3id.org/emmo#EMMO_72379870-0d00-5e48-912b-62cbd5b3f548"></see></summary>
    let ``EMMO_72379870-0d00-5e48-912b-62cbd5b3f548`` =
        Namespaced_IRI.parse _namespace_name "EMMO_72379870-0d00-5e48-912b-62cbd5b3f548" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the krypton atom.
    /// <see href="https://w3id.org/emmo#EMMO_7c79a41c-c0aa-564b-b0b1-6fd4ee6f3256"></see></summary>
    let ``EMMO_7c79a41c-c0aa-564b-b0b1-6fd4ee6f3256`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7c79a41c-c0aa-564b-b0b1-6fd4ee6f3256" |> NamespacedName

    /// <summary>
    /// For all types of ions in a solution, half the sum of the products of their molality b_i and the square of their charge number z_i.
    /// Charge number is a quantity of dimension one defined in ChargeNumber.
    /// <see href="https://w3id.org/emmo#EMMO_7243633d_96ff_426d_ae44_8a2504e682da"></see></summary>
    let EMMO_7243633d_96ff_426d_ae44_8a2504e682da =
        Namespaced_IRI.parse _namespace_name "EMMO_7243633d_96ff_426d_ae44_8a2504e682da" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_95971713_d589_4002_a5a7_affc5c74cfdb"></see></summary>
    let EMMO_95971713_d589_4002_a5a7_affc5c74cfdb =
        Namespaced_IRI.parse _namespace_name "EMMO_95971713_d589_4002_a5a7_affc5c74cfdb" |> NamespacedName

    /// <summary>
    /// Vector whose scalar products with all fundamental lattice vectors are integral multiples of 2pi.
    /// <see href="https://w3id.org/emmo#EMMO_7254c8be_965d_4b3c_b3be_12c5578bee7c"></see></summary>
    let EMMO_7254c8be_965d_4b3c_b3be_12c5578bee7c =
        Namespaced_IRI.parse _namespace_name "EMMO_7254c8be_965d_4b3c_b3be_12c5578bee7c" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_7329967c_3972_4c99_b478_84f66436620d"></see>
    /// </summary>
    let EMMO_7329967c_3972_4c99_b478_84f66436620d =
        Namespaced_IRI.parse _namespace_name "EMMO_7329967c_3972_4c99_b478_84f66436620d" |> NamespacedName

    /// <summary>
    /// Atom subclass for yttrium.
    /// <see href="https://w3id.org/emmo#EMMO_733b8473-aa8f-59d5-81c3-c97ca40ea9d0"></see></summary>
    let ``EMMO_733b8473-aa8f-59d5-81c3-c97ca40ea9d0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_733b8473-aa8f-59d5-81c3-c97ca40ea9d0" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the yttrium atom.
    /// <see href="https://w3id.org/emmo#EMMO_74fd9704-69a8-5112-b65a-72ba05bba315"></see></summary>
    let ``EMMO_74fd9704-69a8-5112-b65a-72ba05bba315`` =
        Namespaced_IRI.parse _namespace_name "EMMO_74fd9704-69a8-5112-b65a-72ba05bba315" |> NamespacedName

    /// <summary>
    /// Atom subclass for promethium.
    /// <see href="https://w3id.org/emmo#EMMO_73e73382-f3c0-5d09-bcee-f6e380269388"></see></summary>
    let ``EMMO_73e73382-f3c0-5d09-bcee-f6e380269388`` =
        Namespaced_IRI.parse _namespace_name "EMMO_73e73382-f3c0-5d09-bcee-f6e380269388" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the promethium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c45d9e2f-54f3-5464-82f3-c0f11a36389a"></see></summary>
    let ``EMMO_c45d9e2f-54f3-5464-82f3-c0f11a36389a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c45d9e2f-54f3-5464-82f3-c0f11a36389a" |> NamespacedName

    /// <summary>
    /// Differential quotient of the cross section for scattering a particle in a given direction and the solid angle around that direction.
    /// <see href="https://w3id.org/emmo#EMMO_748ff828_763b_4290_adb9_e05376d4136a"></see></summary>
    let EMMO_748ff828_763b_4290_adb9_e05376d4136a =
        Namespaced_IRI.parse _namespace_name "EMMO_748ff828_763b_4290_adb9_e05376d4136a" |> NamespacedName

    /// <summary>
    /// Atom subclass for lead.
    /// <see href="https://w3id.org/emmo#EMMO_749a9347-0b50-530a-995a-054f2a90bc0d"></see></summary>
    let ``EMMO_749a9347-0b50-530a-995a-054f2a90bc0d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_749a9347-0b50-530a-995a-054f2a90bc0d" |> NamespacedName

    /// <summary>
    /// Vector quantity equal to the product of the magnetization M and the magnetic constant μ0.
    /// <see href="https://w3id.org/emmo#EMMO_74a096dd_cc83_4c7e_b704_0541620ff18d"></see></summary>
    let EMMO_74a096dd_cc83_4c7e_b704_0541620ff18d =
        Namespaced_IRI.parse _namespace_name "EMMO_74a096dd_cc83_4c7e_b704_0541620ff18d" |> NamespacedName

    /// <summary>
    /// Symbol representing a letter in a digit.
    /// <see href="https://w3id.org/emmo#EMMO_74b05aed_66bf_43c8_aa2c_752a9ca8be03"></see></summary>
    let EMMO_74b05aed_66bf_43c8_aa2c_752a9ca8be03 =
        Namespaced_IRI.parse _namespace_name "EMMO_74b05aed_66bf_43c8_aa2c_752a9ca8be03" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_74cfc811_6e04_4fe4_aea5_6a5cc09f6571"></see>
    /// </summary>
    let EMMO_74cfc811_6e04_4fe4_aea5_6a5cc09f6571 =
        Namespaced_IRI.parse _namespace_name "EMMO_74cfc811_6e04_4fe4_aea5_6a5cc09f6571" |> NamespacedName

    /// <summary>
    /// A 2-manifold with one unconnected boundary and two "faces".
    /// <see href="https://w3id.org/emmo#EMMO_750d42f1_c291_42ce_91b2_a079d79639fb"></see></summary>
    let EMMO_750d42f1_c291_42ce_91b2_a079d79639fb =
        Namespaced_IRI.parse _namespace_name "EMMO_750d42f1_c291_42ce_91b2_a079d79639fb" |> NamespacedName

    /// <summary>
    /// A symbolic construct used within the discipline of metrology.
    /// <see href="https://w3id.org/emmo#EMMO_754fa9fa_1285_4e2f_b1fc_018c9321a0a8"></see></summary>
    let EMMO_754fa9fa_1285_4e2f_b1fc_018c9321a0a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_754fa9fa_1285_4e2f_b1fc_018c9321a0a8" |> NamespacedName

    /// <summary>
    /// Atom subclass for argon.
    /// <see href="https://w3id.org/emmo#EMMO_755d962f-c703-514f-8d90-ca4f55e331d4"></see></summary>
    let ``EMMO_755d962f-c703-514f-8d90-ca4f55e331d4`` =
        Namespaced_IRI.parse _namespace_name "EMMO_755d962f-c703-514f-8d90-ca4f55e331d4" |> NamespacedName

    /// <summary>
    /// Application of additive manufacturing intended for reducing the time needed for producing prototypes.
    /// <see href="https://w3id.org/emmo#EMMO_755eaac8_735e_438c_8c19_a8b5e6a81728"></see></summary>
    let EMMO_755eaac8_735e_438c_8c19_a8b5e6a81728 =
        Namespaced_IRI.parse _namespace_name "EMMO_755eaac8_735e_438c_8c19_a8b5e6a81728" |> NamespacedName

    /// <summary>
    /// Atom subclass for nihonium.
    /// <see href="https://w3id.org/emmo#EMMO_75771a96-5e17-568c-bc28-caba06c0047a"></see></summary>
    let ``EMMO_75771a96-5e17-568c-bc28-caba06c0047a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_75771a96-5e17-568c-bc28-caba06c0047a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the nihonium atom.
    /// <see href="https://w3id.org/emmo#EMMO_8fbc9110-c822-5b8e-a5fc-ee5430d9f34a"></see></summary>
    let ``EMMO_8fbc9110-c822-5b8e-a5fc-ee5430d9f34a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8fbc9110-c822-5b8e-a5fc-ee5430d9f34a" |> NamespacedName

    /// <summary>
    /// A Material occurring in nature, without the need of human intervention.
    /// <see href="https://w3id.org/emmo#EMMO_75fe4fd1_0f7e_429b_b91d_59d248561bae"></see></summary>
    let EMMO_75fe4fd1_0f7e_429b_b91d_59d248561bae =
        Namespaced_IRI.parse _namespace_name "EMMO_75fe4fd1_0f7e_429b_b91d_59d248561bae" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricResistance'.
    /// <see href="https://w3id.org/emmo#EMMO_7610efb8_c7c6_4684_abc1_774783c62472"></see></summary>
    let EMMO_7610efb8_c7c6_4684_abc1_774783c62472 =
        Namespaced_IRI.parse _namespace_name "EMMO_7610efb8_c7c6_4684_abc1_774783c62472" |> NamespacedName

    /// <summary>
    /// Cut-off angular wavenumber in the Debye model of the vibrational spectrum of a solid.
    /// <see href="https://w3id.org/emmo#EMMO_76acb5d8_5ab8_484b_8354_7f7612f39c17"></see></summary>
    let EMMO_76acb5d8_5ab8_484b_8354_7f7612f39c17 =
        Namespaced_IRI.parse _namespace_name "EMMO_76acb5d8_5ab8_484b_8354_7f7612f39c17" |> NamespacedName

    /// <summary>
    /// In condensed matter physics, quotient of momentum and the reduced Planck constant.
    /// <see href="https://w3id.org/emmo#EMMO_e4791212_5a13_4aa6_aac2_08704550dcc3"></see></summary>
    let EMMO_e4791212_5a13_4aa6_aac2_08704550dcc3 =
        Namespaced_IRI.parse _namespace_name "EMMO_e4791212_5a13_4aa6_aac2_08704550dcc3" |> NamespacedName

    /// <summary>
    /// The quantum of action. It defines the kg base unit in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_76cc4efc_231e_42b4_be83_2547681caed6"></see></summary>
    let EMMO_76cc4efc_231e_42b4_be83_2547681caed6 =
        Namespaced_IRI.parse _namespace_name "EMMO_76cc4efc_231e_42b4_be83_2547681caed6" |> NamespacedName

    /// <summary>
    /// Vector quantity giving the rate of change of angular velocity.
    /// <see href="https://w3id.org/emmo#EMMO_77c53503_48b5_4811_a1a5_6bb4425e0bbf"></see></summary>
    let EMMO_77c53503_48b5_4811_a1a5_6bb4425e0bbf =
        Namespaced_IRI.parse _namespace_name "EMMO_77c53503_48b5_4811_a1a5_6bb4425e0bbf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_77e2e601_5ecb_450b_b563_92f096997832"></see>
    /// </summary>
    let EMMO_77e2e601_5ecb_450b_b563_92f096997832 =
        Namespaced_IRI.parse _namespace_name "EMMO_77e2e601_5ecb_450b_b563_92f096997832" |> NamespacedName

    /// <summary>
    /// Atom subclass for polonium.
    /// <see href="https://w3id.org/emmo#EMMO_784119c1-c336-5b0c-80fc-4cc8bddc99ca"></see></summary>
    let ``EMMO_784119c1-c336-5b0c-80fc-4cc8bddc99ca`` =
        Namespaced_IRI.parse _namespace_name "EMMO_784119c1-c336-5b0c-80fc-4cc8bddc99ca" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the polonium atom.
    /// <see href="https://w3id.org/emmo#EMMO_af362dae-2da6-595e-8581-21a8363a5a54"></see></summary>
    let ``EMMO_af362dae-2da6-595e-8581-21a8363a5a54`` =
        Namespaced_IRI.parse _namespace_name "EMMO_af362dae-2da6-595e-8581-21a8363a5a54" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_7855043d_a466_4585_97a9_b9fe4ce0c12d"></see></summary>
    let EMMO_7855043d_a466_4585_97a9_b9fe4ce0c12d =
        Namespaced_IRI.parse _namespace_name "EMMO_7855043d_a466_4585_97a9_b9fe4ce0c12d" |> NamespacedName

    /// <summary>
    /// Atom subclass for rutherfordium.
    /// <see href="https://w3id.org/emmo#EMMO_78c3f353-1296-5dca-9759-7c59a7f53927"></see></summary>
    let ``EMMO_78c3f353-1296-5dca-9759-7c59a7f53927`` =
        Namespaced_IRI.parse _namespace_name "EMMO_78c3f353-1296-5dca-9759-7c59a7f53927" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the rutherfordium atom.
    /// <see href="https://w3id.org/emmo#EMMO_ce8cedc4-4835-5298-b723-6223d2a17e5a"></see></summary>
    let ``EMMO_ce8cedc4-4835-5298-b723-6223d2a17e5a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ce8cedc4-4835-5298-b723-6223d2a17e5a" |> NamespacedName

    /// <summary>
    /// Relates a prefixed unit to its non-prefixed part.
    /// <see href="https://w3id.org/emmo#EMMO_78c79b48_4b76_4cbe_812f_b32dbb04fd44"></see></summary>
    let EMMO_78c79b48_4b76_4cbe_812f_b32dbb04fd44 =
        Namespaced_IRI.parse _namespace_name "EMMO_78c79b48_4b76_4cbe_812f_b32dbb04fd44" |> NamespacedName

    /// <summary>
    /// Atom subclass for phosphorus.
    /// <see href="https://w3id.org/emmo#EMMO_7905373a-cf03-57fe-a627-bfdb1db9369c"></see></summary>
    let ``EMMO_7905373a-cf03-57fe-a627-bfdb1db9369c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7905373a-cf03-57fe-a627-bfdb1db9369c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'LengthPerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_793f3567_b351_42ef_a1d4_5111d53999c4"></see></summary>
    let EMMO_793f3567_b351_42ef_a1d4_5111d53999c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_793f3567_b351_42ef_a1d4_5111d53999c4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_79575941_45dc_4f15_bb59_dc04dff2c92d"></see>
    /// </summary>
    let EMMO_79575941_45dc_4f15_bb59_dc04dff2c92d =
        Namespaced_IRI.parse _namespace_name "EMMO_79575941_45dc_4f15_bb59_dc04dff2c92d" |> NamespacedName

    /// <summary>
    /// Atom subclass for silicon.
    /// <see href="https://w3id.org/emmo#EMMO_798b0c96-82ca-5ce8-8d5f-f9f72668cf5d"></see></summary>
    let ``EMMO_798b0c96-82ca-5ce8-8d5f-f9f72668cf5d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_798b0c96-82ca-5ce8-8d5f-f9f72668cf5d" |> NamespacedName

    /// <summary>
    /// Measure of the opposition that a circuit presents to a current when a voltage is applied.
    /// <see href="https://w3id.org/emmo#EMMO_79a02de5_b884_4eab_bc18_f67997d597a2"></see></summary>
    let EMMO_79a02de5_b884_4eab_bc18_f67997d597a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_79a02de5_b884_4eab_bc18_f67997d597a2" |> NamespacedName

    /// <summary>
    /// Measure of the difficulty to pass an electric current through a material.
    /// Inverse of 'ElectricalConductance'.
    /// <see href="https://w3id.org/emmo#EMMO_e88f75d6_9a17_4cfc_bdf7_43d7cea5a9a1"></see></summary>
    let EMMO_e88f75d6_9a17_4cfc_bdf7_43d7cea5a9a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_e88f75d6_9a17_4cfc_bdf7_43d7cea5a9a1" |> NamespacedName

    /// <summary>
    /// A mixed tiling in wich a tile has next spatially connected tiles.
    /// <see href="https://w3id.org/emmo#EMMO_79aad3fb_2e01_4626_8369_4e914893aa6d"></see></summary>
    let EMMO_79aad3fb_2e01_4626_8369_4e914893aa6d =
        Namespaced_IRI.parse _namespace_name "EMMO_79aad3fb_2e01_4626_8369_4e914893aa6d" |> NamespacedName

    /// <summary>
    /// Atom subclass for flerovium.
    /// <see href="https://w3id.org/emmo#EMMO_7aa6b5b1-34c8-5d37-9db0-cc6a232f3946"></see></summary>
    let ``EMMO_7aa6b5b1-34c8-5d37-9db0-cc6a232f3946`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7aa6b5b1-34c8-5d37-9db0-cc6a232f3946" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the zirconium atom.
    /// <see href="https://w3id.org/emmo#EMMO_7ab01303-b09e-5a90-8a5b-f5087d6559d3"></see></summary>
    let ``EMMO_7ab01303-b09e-5a90-8a5b-f5087d6559d3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7ab01303-b09e-5a90-8a5b-f5087d6559d3" |> NamespacedName

    /// <summary>
    /// RMS value voltage multiplied by rms value of electric current.
    /// <see href="https://w3id.org/emmo#EMMO_7b09c6b8_d120_4518_9b66_3b1139e0aa66"></see></summary>
    let EMMO_7b09c6b8_d120_4518_9b66_3b1139e0aa66 =
        Namespaced_IRI.parse _namespace_name "EMMO_7b09c6b8_d120_4518_9b66_3b1139e0aa66" |> NamespacedName

    /// <summary>
    /// Particles composed of two or more quarks.
    /// <see href="https://w3id.org/emmo#EMMO_7b42954f_0b91_4b3a_a65e_2470202cf548"></see></summary>
    let EMMO_7b42954f_0b91_4b3a_a65e_2470202cf548 =
        Namespaced_IRI.parse _namespace_name "EMMO_7b42954f_0b91_4b3a_a65e_2470202cf548" |> NamespacedName

    /// <summary>
    /// Most mesons are composed of one quark and one antiquark.
    /// Hadronic subatomic particles composed of an equal number of quarks and antiquarks bound together by strong interactions.
    /// <see href="https://w3id.org/emmo#EMMO_be0a7278_b4e6_4bca_88ba_de3f67a478e2"></see></summary>
    let EMMO_be0a7278_b4e6_4bca_88ba_de3f67a478e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_be0a7278_b4e6_4bca_88ba_de3f67a478e2" |> NamespacedName

    /// <summary>
    /// An elementary particle of a fundamental bosonic type.
    /// <see href="https://w3id.org/emmo#EMMO_cafd0f10_ce85_48b9_9a36_2b0af141ce21"></see></summary>
    let EMMO_cafd0f10_ce85_48b9_9a36_2b0af141ce21 =
        Namespaced_IRI.parse _namespace_name "EMMO_cafd0f10_ce85_48b9_9a36_2b0af141ce21" |> NamespacedName

    /// <summary>
    /// Atom subclass for tungsten.
    /// <see href="https://w3id.org/emmo#EMMO_7b7d258b-3ea7-5716-af58-afc68679de23"></see></summary>
    let ``EMMO_7b7d258b-3ea7-5716-af58-afc68679de23`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7b7d258b-3ea7-5716-af58-afc68679de23" |> NamespacedName

    /// <summary>
    /// Mass of a constituent divided by the total mass of all constituents in the mixture.
    /// <see href="https://w3id.org/emmo#EMMO_7c055d65_2929_40e1_af4f_4bf10995ad50"></see></summary>
    let EMMO_7c055d65_2929_40e1_af4f_4bf10995ad50 =
        Namespaced_IRI.parse _namespace_name "EMMO_7c055d65_2929_40e1_af4f_4bf10995ad50" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EntropyPerMass'.
    /// <see href="https://w3id.org/emmo#EMMO_7cef5aae_baae_42d1_959a_ee70a7cf7a73"></see></summary>
    let EMMO_7cef5aae_baae_42d1_959a_ee70a7cf7a73 =
        Namespaced_IRI.parse _namespace_name "EMMO_7cef5aae_baae_42d1_959a_ee70a7cf7a73" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'FrequencyPerAreaTime'.
    /// <see href="https://w3id.org/emmo#EMMO_7cfbe969_6ced_47a2_86c6_de33673c45d0"></see></summary>
    let EMMO_7cfbe969_6ced_47a2_86c6_de33673c45d0 =
        Namespaced_IRI.parse _namespace_name "EMMO_7cfbe969_6ced_47a2_86c6_de33673c45d0" |> NamespacedName

    /// <summary>
    /// Difference between the mass of an atom, and the product of its mass number and the unified mass constant.
    /// <see href="https://w3id.org/emmo#EMMO_7dd84949_0afa_4313_9b89_7bb0dd2e7771"></see></summary>
    let EMMO_7dd84949_0afa_4313_9b89_7bb0dd2e7771 =
        Namespaced_IRI.parse _namespace_name "EMMO_7dd84949_0afa_4313_9b89_7bb0dd2e7771" |> NamespacedName

    /// <summary>
    /// A measuring instrument that can be used alone is a measuring system.
    /// Device used for making measurements, alone or in conjunction with one or more supplementary devices.
    ///
    /// -- VIM
    /// <see href="https://w3id.org/emmo#EMMO_f2d5d3ad_2e00_417f_8849_686f3988d929"></see></summary>
    let EMMO_f2d5d3ad_2e00_417f_8849_686f3988d929 =
        Namespaced_IRI.parse _namespace_name "EMMO_f2d5d3ad_2e00_417f_8849_686f3988d929" |> NamespacedName

    /// <summary>
    /// An observer that makes use of a measurement tool and provides a quantitative property.
    /// <see href="https://w3id.org/emmo#EMMO_9be5fcc4_0d8b_481d_b984_6338d4b55588"></see></summary>
    let EMMO_9be5fcc4_0d8b_481d_b984_6338d4b55588 =
        Namespaced_IRI.parse _namespace_name "EMMO_9be5fcc4_0d8b_481d_b984_6338d4b55588" |> NamespacedName

    /// <summary>
    /// Surface density of electric charge multiplied by velocity
    /// <see href="https://w3id.org/emmo#EMMO_7e53a8b4_6e02_4e56_80d4_8683f92b9c77"></see></summary>
    let EMMO_7e53a8b4_6e02_4e56_80d4_8683f92b9c77 =
        Namespaced_IRI.parse _namespace_name "EMMO_7e53a8b4_6e02_4e56_80d4_8683f92b9c77" |> NamespacedName

    /// <summary>
    /// Atom subclass for aluminium.
    /// <see href="https://w3id.org/emmo#EMMO_7e8f9419-0bda-5aa3-ba88-00b2be6ca69e"></see></summary>
    let ``EMMO_7e8f9419-0bda-5aa3-ba88-00b2be6ca69e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_7e8f9419-0bda-5aa3-ba88-00b2be6ca69e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the aluminium atom.
    /// <see href="https://w3id.org/emmo#EMMO_fc7ab7d2-d960-5ae8-b13b-a53dbc547cca"></see></summary>
    let ``EMMO_fc7ab7d2-d960-5ae8-b13b-a53dbc547cca`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fc7ab7d2-d960-5ae8-b13b-a53dbc547cca" |> NamespacedName

    /// <summary>
    /// A tessellation in which all tiles are connected through spatiotemporal relations hasNext or contacts.
    /// <see href="https://w3id.org/emmo#EMMO_e12dcfa4_c9f1_4546_9a12_8457c052e6ba"></see></summary>
    let EMMO_e12dcfa4_c9f1_4546_9a12_8457c052e6ba =
        Namespaced_IRI.parse _namespace_name "EMMO_e12dcfa4_c9f1_4546_9a12_8457c052e6ba" |> NamespacedName

    /// <summary>
    /// A language construct that provides information about the consitutents of a substance and their fractions or amounts.
    /// <see href="https://w3id.org/emmo#EMMO_7efd64d1_05a1_49cd_a7f0_783ca050d4f3"></see></summary>
    let EMMO_7efd64d1_05a1_49cd_a7f0_783ca050d4f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_7efd64d1_05a1_49cd_a7f0_783ca050d4f3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_90963312_d9a9_4474_8d10_835aef5b168e"></see>
    /// </summary>
    let EMMO_90963312_d9a9_4474_8d10_835aef5b168e =
        Namespaced_IRI.parse _namespace_name "EMMO_90963312_d9a9_4474_8d10_835aef5b168e" |> NamespacedName

    /// <summary>
    /// Under sinusoidal conditions, phase difference between the voltage applied to a linear two-terminal element or two-terminal circuit and the electric current in the element or circuit.
    /// <see href="https://w3id.org/emmo#EMMO_7f8ef5cf_7d80_46fa_951c_369014e3a8af"></see></summary>
    let EMMO_7f8ef5cf_7d80_46fa_951c_369014e3a8af =
        Namespaced_IRI.parse _namespace_name "EMMO_7f8ef5cf_7d80_46fa_951c_369014e3a8af" |> NamespacedName

    /// <summary>
    /// Quotient of mechanical output and input power.
    /// <see href="https://w3id.org/emmo#EMMO_7f9b4abe_0bf1_48dc_9bd0_ea34e926ec85"></see></summary>
    let EMMO_7f9b4abe_0bf1_48dc_9bd0_ea34e926ec85 =
        Namespaced_IRI.parse _namespace_name "EMMO_7f9b4abe_0bf1_48dc_9bd0_ea34e926ec85" |> NamespacedName

    /// <summary>
    /// A relation that connects a semiotic object to the interpretant in a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_7fb7fe7e_bdf9_4eeb_adad_e384dd5285c6"></see></summary>
    let EMMO_7fb7fe7e_bdf9_4eeb_adad_e384dd5285c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_7fb7fe7e_bdf9_4eeb_adad_e384dd5285c6" |> NamespacedName

    /// <summary>
    /// Examples of condition might be constant volume or constant pressure for a gas.
    /// Quantity C = dQ/dT, when the thermodynamic temperature of a system is increased by dT as a result of the addition of a amount of heat dQ, under given condition.
    /// <see href="https://w3id.org/emmo#EMMO_802c167d_b792_4cb8_a315_35797345c0e3"></see></summary>
    let EMMO_802c167d_b792_4cb8_a315_35797345c0e3 =
        Namespaced_IRI.parse _namespace_name "EMMO_802c167d_b792_4cb8_a315_35797345c0e3" |> NamespacedName

    /// <summary>
    /// For an ideal gas, isentropic exponent is equal to ratio of the specific heat capacities.
    /// <see href="https://w3id.org/emmo#EMMO_8040a6f6_4736_4dd2_8d1c_f2c13cb77a71"></see></summary>
    let EMMO_8040a6f6_4736_4dd2_8d1c_f2c13cb77a71 =
        Namespaced_IRI.parse _namespace_name "EMMO_8040a6f6_4736_4dd2_8d1c_f2c13cb77a71" |> NamespacedName

    /// <summary>
    /// Atom subclass for selenium.
    /// <see href="https://w3id.org/emmo#EMMO_808f7cd9-27b4-527b-974f-4213f10e1772"></see></summary>
    let ``EMMO_808f7cd9-27b4-527b-974f-4213f10e1772`` =
        Namespaced_IRI.parse _namespace_name "EMMO_808f7cd9-27b4-527b-974f-4213f10e1772" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the selenium atom.
    /// <see href="https://w3id.org/emmo#EMMO_cfac37de-991d-5a7d-9adc-8946324ffef6"></see></summary>
    let ``EMMO_cfac37de-991d-5a7d-9adc-8946324ffef6`` =
        Namespaced_IRI.parse _namespace_name "EMMO_cfac37de-991d-5a7d-9adc-8946324ffef6" |> NamespacedName

    /// <summary>
    /// Sum of canonical partition function Z (NA,NB,…) for the given number of particles A, B, ... multiplied by absolute activities of particles A, B, ...
    /// <see href="https://w3id.org/emmo#EMMO_80b19ae3_7248_4205_8c79_4e94f5f0444c"></see></summary>
    let EMMO_80b19ae3_7248_4205_8c79_4e94f5f0444c =
        Namespaced_IRI.parse _namespace_name "EMMO_80b19ae3_7248_4205_8c79_4e94f5f0444c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Amount'.
    /// <see href="https://w3id.org/emmo#EMMO_e501069c_34d3_4dc7_ac87_c90c7342192b"></see></summary>
    let EMMO_e501069c_34d3_4dc7_ac87_c90c7342192b =
        Namespaced_IRI.parse _namespace_name "EMMO_e501069c_34d3_4dc7_ac87_c90c7342192b" |> NamespacedName

    /// <summary>
    /// Reciprocal of the coefficient of heat transfer.
    /// <see href="https://w3id.org/emmo#EMMO_8168c707_1b2a_4c6f_8d2e_a4e8081fd276"></see></summary>
    let EMMO_8168c707_1b2a_4c6f_8d2e_a4e8081fd276 =
        Namespaced_IRI.parse _namespace_name "EMMO_8168c707_1b2a_4c6f_8d2e_a4e8081fd276" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerThermalTransmittance'.
    /// <see href="https://w3id.org/emmo#EMMO_869e6e4f_a9b5_4db8_a978_8ad050239933"></see></summary>
    let EMMO_869e6e4f_a9b5_4db8_a978_8ad050239933 =
        Namespaced_IRI.parse _namespace_name "EMMO_869e6e4f_a9b5_4db8_a978_8ad050239933" |> NamespacedName

    /// <summary>
    /// For an atom or nucleus, this energy is quantized and can be written as:
    ///
    ///     W = g μ M B
    ///
    /// where g is the appropriate g factor, μ is mostly the Bohr magneton or nuclear magneton, M is magnetic quantum number, and B is magnitude of the magnetic flux density.
    ///
    /// -- ISO 80000
    /// Vector quantity μ causing a change to its energy ΔW in an external magnetic field of field flux density B:
    ///
    ///     ΔW = −μ · B
    /// <see href="https://w3id.org/emmo#EMMO_81e767f1_59b1_4d7a_bf69_17f322241831"></see></summary>
    let EMMO_81e767f1_59b1_4d7a_bf69_17f322241831 =
        Namespaced_IRI.parse _namespace_name "EMMO_81e767f1_59b1_4d7a_bf69_17f322241831" |> NamespacedName

    /// <summary>
    /// quotient of number of acceptor levels and volume.
    /// <see href="https://w3id.org/emmo#EMMO_8219a082_9443_4374_8038_6459d5cf4ce9"></see></summary>
    let EMMO_8219a082_9443_4374_8038_6459d5cf4ce9 =
        Namespaced_IRI.parse _namespace_name "EMMO_8219a082_9443_4374_8038_6459d5cf4ce9" |> NamespacedName

    /// <summary>
    /// A non-SI coherent can be expressed in terms of its corresponding SI coherent unit, as
    ///
    ///     nonsi_coherent_unit = si_coherent_unit * multiplier + offset
    ///
    /// where `multiplier` and `offset` are specified via the 'hasConversionMultiplier' and 'hasConversionOffset' data properties, respectively.
    /// A unit whos numerical factor in front of the product of base units is NOT equal to one.
    /// <see href="https://w3id.org/emmo#EMMO_8246541a_f1f6_4d03_8bd7_fc6b76d17375"></see></summary>
    let EMMO_8246541a_f1f6_4d03_8bd7_fc6b76d17375 =
        Namespaced_IRI.parse _namespace_name "EMMO_8246541a_f1f6_4d03_8bd7_fc6b76d17375" |> NamespacedName

    /// <summary>
    /// A SI base or special unit with a metric prefix.
    /// The presence of the prefix makes this units non-coherent with SI system.
    /// <see href="https://w3id.org/emmo#EMMO_d41ce84b_4317_41fb_a5d1_6cd281fca106"></see></summary>
    let EMMO_d41ce84b_4317_41fb_a5d1_6cd281fca106 =
        Namespaced_IRI.parse _namespace_name "EMMO_d41ce84b_4317_41fb_a5d1_6cd281fca106" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_826bd296_d8e2_4c43_8f54_d684bf00090a"></see>
    /// </summary>
    let EMMO_826bd296_d8e2_4c43_8f54_d684bf00090a =
        Namespaced_IRI.parse _namespace_name "EMMO_826bd296_d8e2_4c43_8f54_d684bf00090a" |> NamespacedName

    /// <summary>
    /// Atom subclass for thulium.
    /// <see href="https://w3id.org/emmo#EMMO_82f9a8f3-2bb4-5d14-9a41-30a858ecce61"></see></summary>
    let ``EMMO_82f9a8f3-2bb4-5d14-9a41-30a858ecce61`` =
        Namespaced_IRI.parse _namespace_name "EMMO_82f9a8f3-2bb4-5d14-9a41-30a858ecce61" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the thulium atom.
    /// <see href="https://w3id.org/emmo#EMMO_849f62cf-3e92-5122-94ba-bcce51a04c5f"></see></summary>
    let ``EMMO_849f62cf-3e92-5122-94ba-bcce51a04c5f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_849f62cf-3e92-5122-94ba-bcce51a04c5f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_aaad78a9_abaf_4f97_9c1a_d763a94c4ba3"></see>
    /// </summary>
    let EMMO_aaad78a9_abaf_4f97_9c1a_d763a94c4ba3 =
        Namespaced_IRI.parse _namespace_name "EMMO_aaad78a9_abaf_4f97_9c1a_d763a94c4ba3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_964568dd_64d2_454b_a12f_ac389f1c5e7f"></see>
    /// </summary>
    let EMMO_964568dd_64d2_454b_a12f_ac389f1c5e7f =
        Namespaced_IRI.parse _namespace_name "EMMO_964568dd_64d2_454b_a12f_ac389f1c5e7f" |> NamespacedName

    /// <summary>
    /// A real bond between atoms is always something hybrid between covalent, metallic and ionic.
    ///
    /// In general, metallic and ionic bonds have atoms sharing electrons.
    /// An bonded atom that shares at least one electron to the atom-based entity of which is part of.
    /// The bond types that are covered by this definition are the strong electonic bonds: covalent, metallic and ionic.
    /// This class can be used to represent molecules as simplified quantum systems, in which outer molecule shared electrons are un-entangled with the inner shells of the atoms composing the molecule.
    /// <see href="https://w3id.org/emmo#EMMO_8303a247_f9d9_4616_bdcd_f5cbd7b298e3"></see></summary>
    let EMMO_8303a247_f9d9_4616_bdcd_f5cbd7b298e3 =
        Namespaced_IRI.parse _namespace_name "EMMO_8303a247_f9d9_4616_bdcd_f5cbd7b298e3" |> NamespacedName

    /// <summary>
    /// A state quantity equal to the difference between the total energy of a system and the sum of the macroscopic kinetic and potential energies of the system.
    /// <see href="https://w3id.org/emmo#EMMO_830b59f7_d047_438c_90cd_62845749efcb"></see></summary>
    let EMMO_830b59f7_d047_438c_90cd_62845749efcb =
        Namespaced_IRI.parse _namespace_name "EMMO_830b59f7_d047_438c_90cd_62845749efcb" |> NamespacedName

    /// <summary>
    /// For a two-terminal element or a two-terminal circuit under periodic conditions, quantity equal to the square root of the difference of the squares of the apparent power S and the active power P.
    /// <see href="https://w3id.org/emmo#EMMO_83318add_d05e_40fc_93ea_c6cd605df437"></see></summary>
    let EMMO_83318add_d05e_40fc_93ea_c6cd605df437 =
        Namespaced_IRI.parse _namespace_name "EMMO_83318add_d05e_40fc_93ea_c6cd605df437" |> NamespacedName

    /// <summary>
    /// SI derived unit pascal divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalPerMetre"></see></summary>
    let PascalPerMetre =
        Namespaced_IRI.parse _namespace_name "PascalPerMetre" |> NamespacedName

    /// <summary>
    /// Real part of the impedance.
    /// <see href="https://w3id.org/emmo#EMMO_83a43803_0b0f_45a4_86a3_bc6b32e6a540"></see></summary>
    let EMMO_83a43803_0b0f_45a4_86a3_bc6b32e6a540 =
        Namespaced_IRI.parse _namespace_name "EMMO_83a43803_0b0f_45a4_86a3_bc6b32e6a540" |> NamespacedName

    /// <summary>
    /// A workflow that is the concurrent evolution of two or more tasks, not communicacting between themselves.
    /// <see href="https://w3id.org/emmo#EMMO_83a460aa_5826_4fbb_93e8_d73d0df25757"></see></summary>
    let EMMO_83a460aa_5826_4fbb_93e8_d73d0df25757 =
        Namespaced_IRI.parse _namespace_name "EMMO_83a460aa_5826_4fbb_93e8_d73d0df25757" |> NamespacedName

    /// <summary>
    /// A 2-manifold with one unconnected boundary and one "face".
    /// <see href="https://w3id.org/emmo#EMMO_8406f483_eafc_4700_b6c0_5d2908ea2adf"></see></summary>
    let EMMO_8406f483_eafc_4700_b6c0_5d2908ea2adf =
        Namespaced_IRI.parse _namespace_name "EMMO_8406f483_eafc_4700_b6c0_5d2908ea2adf" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_8455fa05_a877_48d7_b8a3_8e3bfad119bf"></see></summary>
    let EMMO_8455fa05_a877_48d7_b8a3_8e3bfad119bf =
        Namespaced_IRI.parse _namespace_name "EMMO_8455fa05_a877_48d7_b8a3_8e3bfad119bf" |> NamespacedName

    /// <summary>
    /// A physics-based model based on a physics equation describing the behaviour of atoms.
    /// <see href="https://w3id.org/emmo#EMMO_84cadc45_6758_46f2_ba2a_5ead65c70213"></see></summary>
    let EMMO_84cadc45_6758_46f2_ba2a_5ead65c70213 =
        Namespaced_IRI.parse _namespace_name "EMMO_84cadc45_6758_46f2_ba2a_5ead65c70213" |> NamespacedName

    /// <summary>
    /// An icon that not only resembles the object, but also can express some of the object's functions.
    /// <see href="https://w3id.org/emmo#EMMO_8533871a_01e4_4935_8c7b_cedf8fcc3fa3"></see></summary>
    let EMMO_8533871a_01e4_4935_8c7b_cedf8fcc3fa3 =
        Namespaced_IRI.parse _namespace_name "EMMO_8533871a_01e4_4935_8c7b_cedf8fcc3fa3" |> NamespacedName

    /// <summary>
    /// Enthalpy per unit mass.
    /// <see href="https://w3id.org/emmo#EMMO_85605643_f9ed_42ae_85ff_4a7443288dfd"></see></summary>
    let EMMO_85605643_f9ed_42ae_85ff_4a7443288dfd =
        Namespaced_IRI.parse _namespace_name "EMMO_85605643_f9ed_42ae_85ff_4a7443288dfd" |> NamespacedName

    /// <summary>
    /// Atom subclass for caesium.
    /// <see href="https://w3id.org/emmo#EMMO_85ab88f1-3bb6-5fb7-8996-d1be786da995"></see></summary>
    let ``EMMO_85ab88f1-3bb6-5fb7-8996-d1be786da995`` =
        Namespaced_IRI.parse _namespace_name "EMMO_85ab88f1-3bb6-5fb7-8996-d1be786da995" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the caesium atom.
    /// <see href="https://w3id.org/emmo#EMMO_f7e8a63d-d40c-57f7-8017-7ad6b1d89b4e"></see></summary>
    let ``EMMO_f7e8a63d-d40c-57f7-8017-7ad6b1d89b4e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f7e8a63d-d40c-57f7-8017-7ad6b1d89b4e" |> NamespacedName

    /// <summary>
    /// The simplest 2-manifold with genus 1.
    /// <see href="https://w3id.org/emmo#EMMO_86060335_31c2_4820_b433_27c64aea0366"></see></summary>
    let EMMO_86060335_31c2_4820_b433_27c64aea0366 =
        Namespaced_IRI.parse _namespace_name "EMMO_86060335_31c2_4820_b433_27c64aea0366" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'CapacitancePerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_860ef96c_e93e_4549_b3a3_099a625a26a5"></see></summary>
    let EMMO_860ef96c_e93e_4549_b3a3_099a625a26a5 =
        Namespaced_IRI.parse _namespace_name "EMMO_860ef96c_e93e_4549_b3a3_099a625a26a5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_865a1a70_02e8_40b2_948d_078e636c8701"></see>
    /// </summary>
    let EMMO_865a1a70_02e8_40b2_948d_078e636c8701 =
        Namespaced_IRI.parse _namespace_name "EMMO_865a1a70_02e8_40b2_948d_078e636c8701" |> NamespacedName

    /// <summary>
    /// A measurement unit symbol that do not have a metric prefix as a direct spatial part.
    /// <see href="https://w3id.org/emmo#EMMO_868ae137_4d25_493e_b270_21ea3d94849e"></see></summary>
    let EMMO_868ae137_4d25_493e_b270_21ea3d94849e =
        Namespaced_IRI.parse _namespace_name "EMMO_868ae137_4d25_493e_b270_21ea3d94849e" |> NamespacedName

    /// <summary>
    /// A device that is designed to participate to a manufacturing process.
    /// <see href="https://w3id.org/emmo#EMMO_86a305d1_7644_48be_b84c_1f976679b904"></see></summary>
    let EMMO_86a305d1_7644_48be_b84c_1f976679b904 =
        Namespaced_IRI.parse _namespace_name "EMMO_86a305d1_7644_48be_b84c_1f976679b904" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricConductivity'.
    /// <see href="https://w3id.org/emmo#EMMO_86ffe1bb_d457_4948_9e39_35f363b9a9fe"></see></summary>
    let EMMO_86ffe1bb_d457_4948_9e39_35f363b9a9fe =
        Namespaced_IRI.parse _namespace_name "EMMO_86ffe1bb_d457_4948_9e39_35f363b9a9fe" |> NamespacedName

    /// <summary>
    /// A quantity that is the result of a well-defined measurement procedure.
    /// The specification of a measurand requires knowledge of the kind of quantity, description of the state of the phenomenon, body, or substance carrying the quantity, including any relevant component, and the chemical entities involved.
    ///
    /// -- VIM
    /// <see href="https://w3id.org/emmo#EMMO_873b0ab3_88e6_4054_b901_5531e01f14a4"></see></summary>
    let EMMO_873b0ab3_88e6_4054_b901_5531e01f14a4 =
        Namespaced_IRI.parse _namespace_name "EMMO_873b0ab3_88e6_4054_b901_5531e01f14a4" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ReciprocalSquareEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_87b5dd20_e4fe_422d_9e70_1eee54ec9496"></see></summary>
    let EMMO_87b5dd20_e4fe_422d_9e70_1eee54ec9496 =
        Namespaced_IRI.parse _namespace_name "EMMO_87b5dd20_e4fe_422d_9e70_1eee54ec9496" |> NamespacedName

    /// <summary>
    /// Atom subclass for sulfur.
    /// <see href="https://w3id.org/emmo#EMMO_87c8f425-c96c-5503-88a0-f10465669ea3"></see></summary>
    let ``EMMO_87c8f425-c96c-5503-88a0-f10465669ea3`` =
        Namespaced_IRI.parse _namespace_name "EMMO_87c8f425-c96c-5503-88a0-f10465669ea3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8820f251_ad36_43f4_a693_c0e86a89cc1f"></see>
    /// </summary>
    let EMMO_8820f251_ad36_43f4_a693_c0e86a89cc1f =
        Namespaced_IRI.parse _namespace_name "EMMO_8820f251_ad36_43f4_a693_c0e86a89cc1f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_88470630_2a27_4f9e_866a_47ff7789e34b"></see>
    /// </summary>
    let EMMO_88470630_2a27_4f9e_866a_47ff7789e34b =
        Namespaced_IRI.parse _namespace_name "EMMO_88470630_2a27_4f9e_866a_47ff7789e34b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8864793d_0f36_4fa3_b54a_90d0234f976a"></see>
    /// </summary>
    let EMMO_8864793d_0f36_4fa3_b54a_90d0234f976a =
        Namespaced_IRI.parse _namespace_name "EMMO_8864793d_0f36_4fa3_b54a_90d0234f976a" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquarePressureTime'.
    /// <see href="https://w3id.org/emmo#EMMO_886eb0fb_4d36_4b7d_99e4_e5915a06aff1"></see></summary>
    let EMMO_886eb0fb_4d36_4b7d_99e4_e5915a06aff1 =
        Namespaced_IRI.parse _namespace_name "EMMO_886eb0fb_4d36_4b7d_99e4_e5915a06aff1" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyArea'.
    /// <see href="https://w3id.org/emmo#EMMO_88f36585_bd30_4160_b975_61362f3468a9"></see></summary>
    let EMMO_88f36585_bd30_4160_b975_61362f3468a9 =
        Namespaced_IRI.parse _namespace_name "EMMO_88f36585_bd30_4160_b975_61362f3468a9" |> NamespacedName

    /// <summary>
    /// Energy per unit change in amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_88fc5d1b_d3ab_4626_b24c_915ebe7400ca"></see></summary>
    let EMMO_88fc5d1b_d3ab_4626_b24c_915ebe7400ca =
        Namespaced_IRI.parse _namespace_name "EMMO_88fc5d1b_d3ab_4626_b24c_915ebe7400ca" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_89083bab_f69c_4d06_bf6d_62973b56cdc7"></see>
    /// </summary>
    let EMMO_89083bab_f69c_4d06_bf6d_62973b56cdc7 =
        Namespaced_IRI.parse _namespace_name "EMMO_89083bab_f69c_4d06_bf6d_62973b56cdc7" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricConductivityPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_89113866_31a4_4d19_bc83_7f7c1661ab73"></see></summary>
    let EMMO_89113866_31a4_4d19_bc83_7f7c1661ab73 =
        Namespaced_IRI.parse _namespace_name "EMMO_89113866_31a4_4d19_bc83_7f7c1661ab73" |> NamespacedName

    /// <summary>
    /// Physical constant used to define a unit system. Hence, when expressed in that unit system they have an exact value with no associated uncertainty.
    /// <see href="https://w3id.org/emmo#EMMO_89762966_8076_4f7c_b745_f718d653e8e2"></see></summary>
    let EMMO_89762966_8076_4f7c_b745_f718d653e8e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_89762966_8076_4f7c_b745_f718d653e8e2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_89d04b65_5b11_4916_b606_0cf3f007fcd9"></see>
    /// </summary>
    let EMMO_89d04b65_5b11_4916_b606_0cf3f007fcd9 =
        Namespaced_IRI.parse _namespace_name "EMMO_89d04b65_5b11_4916_b606_0cf3f007fcd9" |> NamespacedName

    /// <summary>
    /// Dimensionless scalar value which describes the ratio of the force of friction between two bodies and the force pressing them together; depends on the materials used, ranges from near zero to greater than one.
    /// <see href="https://w3id.org/emmo#EMMO_a18a3e9b_7e3d_44bf_9640_c8634e770ba8"></see></summary>
    let EMMO_a18a3e9b_7e3d_44bf_9640_c8634e770ba8 =
        Namespaced_IRI.parse _namespace_name "EMMO_a18a3e9b_7e3d_44bf_9640_c8634e770ba8" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the palladium atom.
    /// <see href="https://w3id.org/emmo#EMMO_89f46282-58a4-5140-8c5b-7aaddcccdcf0"></see></summary>
    let ``EMMO_89f46282-58a4-5140-8c5b-7aaddcccdcf0`` =
        Namespaced_IRI.parse _namespace_name "EMMO_89f46282-58a4-5140-8c5b-7aaddcccdcf0" |> NamespacedName

    /// <summary>
    /// The final step of a workflow.
    /// There may be more than one end task, if they run in parallel leading to more than one output.
    /// <see href="https://w3id.org/emmo#EMMO_8a2a1cbc_dfc3_4e6c_b337_00ee56fd438a"></see></summary>
    let EMMO_8a2a1cbc_dfc3_4e6c_b337_00ee56fd438a =
        Namespaced_IRI.parse _namespace_name "EMMO_8a2a1cbc_dfc3_4e6c_b337_00ee56fd438a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8a41ed1b_64f9_4be7_9b60_01fcece45075"></see>
    /// </summary>
    let EMMO_8a41ed1b_64f9_4be7_9b60_01fcece45075 =
        Namespaced_IRI.parse _namespace_name "EMMO_8a41ed1b_64f9_4be7_9b60_01fcece45075" |> NamespacedName

    /// <summary>
    /// Atom subclass for europium.
    /// <see href="https://w3id.org/emmo#EMMO_8aa13073-865b-5035-b128-43a4758a0302"></see></summary>
    let ``EMMO_8aa13073-865b-5035-b128-43a4758a0302`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8aa13073-865b-5035-b128-43a4758a0302" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8b2fd84c_8f51_4731_9bd7_830545e78b23"></see>
    /// </summary>
    let EMMO_8b2fd84c_8f51_4731_9bd7_830545e78b23 =
        Namespaced_IRI.parse _namespace_name "EMMO_8b2fd84c_8f51_4731_9bd7_830545e78b23" |> NamespacedName

    /// <summary>
    /// Volume per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_8b4af754_110a_4854_ac65_349ebafc1bed"></see></summary>
    let EMMO_8b4af754_110a_4854_ac65_349ebafc1bed =
        Namespaced_IRI.parse _namespace_name "EMMO_8b4af754_110a_4854_ac65_349ebafc1bed" |> NamespacedName

    /// <summary>
    /// Quantum number in an atom describing the magnitude of total angular momentum J.
    /// <see href="https://w3id.org/emmo#EMMO_8b960a48_8017_4cc0_8e38_27d9237b7e0d"></see></summary>
    let EMMO_8b960a48_8017_4cc0_8e38_27d9237b7e0d =
        Namespaced_IRI.parse _namespace_name "EMMO_8b960a48_8017_4cc0_8e38_27d9237b7e0d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8bb6b688_812a_4cb9_b76c_d5a058928719"></see>
    /// </summary>
    let EMMO_8bb6b688_812a_4cb9_b76c_d5a058928719 =
        Namespaced_IRI.parse _namespace_name "EMMO_8bb6b688_812a_4cb9_b76c_d5a058928719" |> NamespacedName

    /// <summary>
    /// Semiotic subclasse are defined using Peirce's semiotic theory.
    ///
    /// "Namely, a sign is something, A, which brings something, B, its interpretant sign determined or created by it, into the same sort of correspondence with something, C, its object, as that in which itself stands to C." (Peirce 1902, NEM 4, 20–21).
    ///
    /// The triadic elements:
    /// - 'sign': the sign A (e.g. a name)
    /// - 'interpretant': the sign B as the effects of the sign A on the interpreter (e.g. the mental concept of what a name means)
    /// - 'object': the object C (e.g. the entity to which the sign A and B refer to)
    ///
    /// This class includes also the 'interpeter' i.e. the entity that connects the 'sign' to the 'object'
    /// The class of individuals that stands for semiotic objects, i.e. objects that take part on a semiotic process.
    /// <see href="https://w3id.org/emmo#EMMO_b803f122_4acb_4064_9d71_c1e5fd091fc9"></see></summary>
    let EMMO_b803f122_4acb_4064_9d71_c1e5fd091fc9 =
        Namespaced_IRI.parse _namespace_name "EMMO_b803f122_4acb_4064_9d71_c1e5fd091fc9" |> NamespacedName

    /// <summary>
    /// Differential quotient of q with respect to l, where q is the average total charge of all positive ions produced by an ionizing charged particle over a path l, divided by the elementary charge.
    /// <see href="https://w3id.org/emmo#EMMO_8c151a67_f04a_4435_b7d1_1738e6d952ee"></see></summary>
    let EMMO_8c151a67_f04a_4435_b7d1_1738e6d952ee =
        Namespaced_IRI.parse _namespace_name "EMMO_8c151a67_f04a_4435_b7d1_1738e6d952ee" |> NamespacedName

    /// <summary>
    /// A variable standing for a numerical defined mathematical object like e.g. a number, a vector of numbers, a matrix of numbers.
    /// <see href="https://w3id.org/emmo#EMMO_9e029526_79a2_47a8_a151_dd0545db471b"></see></summary>
    let EMMO_9e029526_79a2_47a8_a151_dd0545db471b =
        Namespaced_IRI.parse _namespace_name "EMMO_9e029526_79a2_47a8_a151_dd0545db471b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the technetium atom.
    /// <see href="https://w3id.org/emmo#EMMO_8caaf41b-df30-5355-be5a-74283c49f50a"></see></summary>
    let ``EMMO_8caaf41b-df30-5355-be5a-74283c49f50a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8caaf41b-df30-5355-be5a-74283c49f50a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the rhenium atom.
    /// <see href="https://w3id.org/emmo#EMMO_8d2f22ab-ba39-5e40-98dc-56f075cf22f1"></see></summary>
    let ``EMMO_8d2f22ab-ba39-5e40-98dc-56f075cf22f1`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8d2f22ab-ba39-5e40-98dc-56f075cf22f1" |> NamespacedName

    /// <summary>
    /// Decays per unit time.
    /// <see href="https://w3id.org/emmo#EMMO_8d3da9ac_2265_4382_bee5_db72046722f8"></see></summary>
    let EMMO_8d3da9ac_2265_4382_bee5_db72046722f8 =
        Namespaced_IRI.parse _namespace_name "EMMO_8d3da9ac_2265_4382_bee5_db72046722f8" |> NamespacedName

    /// <summary>
    /// A computational application that uses a physical model to predict the behaviour of a system, providing a identifiable analogy with the original object.
    /// <see href="https://w3id.org/emmo#EMMO_8d4962d7_9608_44f7_a2f1_82a4bb173f4a"></see></summary>
    let EMMO_8d4962d7_9608_44f7_a2f1_82a4bb173f4a =
        Namespaced_IRI.parse _namespace_name "EMMO_8d4962d7_9608_44f7_a2f1_82a4bb173f4a" |> NamespacedName

    /// <summary>
    /// The rest mass of a proton.
    /// <see href="https://w3id.org/emmo#EMMO_8d689295_7d84_421b_bc01_d5cceb2c2086"></see></summary>
    let EMMO_8d689295_7d84_421b_bc01_d5cceb2c2086 =
        Namespaced_IRI.parse _namespace_name "EMMO_8d689295_7d84_421b_bc01_d5cceb2c2086" |> NamespacedName

    /// <summary>
    /// Atom subclass for ytterbium.
    /// <see href="https://w3id.org/emmo#EMMO_8d722efa-b49d-51b1-8bf3-bf50ba4b438c"></see></summary>
    let ``EMMO_8d722efa-b49d-51b1-8bf3-bf50ba4b438c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8d722efa-b49d-51b1-8bf3-bf50ba4b438c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the ytterbium atom.
    /// <see href="https://w3id.org/emmo#EMMO_fdcc0ac2-f82f-5650-838c-ec1ad138a632"></see></summary>
    let ``EMMO_fdcc0ac2-f82f-5650-838c-ec1ad138a632`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fdcc0ac2-f82f-5650-838c-ec1ad138a632" |> NamespacedName

    /// <summary>
    /// Atom subclass for rhenium.
    /// <see href="https://w3id.org/emmo#EMMO_8d93f51b-c7c7-5486-b64a-ee206f6b6672"></see></summary>
    let ``EMMO_8d93f51b-c7c7-5486-b64a-ee206f6b6672`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8d93f51b-c7c7-5486-b64a-ee206f6b6672" |> NamespacedName

    /// <summary>
    /// average distance that phonons travel between two successive interactions
    /// <see href="https://w3id.org/emmo#EMMO_8dacb56f_5931_443b_8de6_f31aec44036c"></see></summary>
    let EMMO_8dacb56f_5931_443b_8de6_f31aec44036c =
        Namespaced_IRI.parse _namespace_name "EMMO_8dacb56f_5931_443b_8de6_f31aec44036c" |> NamespacedName

    /// <summary>
    /// The mean free path may thus be specified either for all interactions, i.e. total mean free path, or for particular types of interaction such as scattering, capture, or ionization.
    /// in a given medium, average distance that particles of a specified type travel between successive interactions of a specified type.
    /// <see href="https://w3id.org/emmo#EMMO_adc5aa0d_9add_4c8a_aa81_b5798a654ca9"></see></summary>
    let EMMO_adc5aa0d_9add_4c8a_aa81_b5798a654ca9 =
        Namespaced_IRI.parse _namespace_name "EMMO_adc5aa0d_9add_4c8a_aa81_b5798a654ca9" |> NamespacedName

    /// <summary>
    /// In an anisotropic medium, thermal conductivity is a tensor quantity.
    /// At a point fixed in a medium with a temperature field, scalar quantity λ characterizing the ability of the medium to transmit heat through a surface element containing that point: φ = −λ grad T, where φ is the density of heat flow rate and T is thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_8dd40ec6_2c5a_43f3_bf64_cadcd447a1c1"></see></summary>
    let EMMO_8dd40ec6_2c5a_43f3_bf64_cadcd447a1c1 =
        Namespaced_IRI.parse _namespace_name "EMMO_8dd40ec6_2c5a_43f3_bf64_cadcd447a1c1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8de14a59_660b_454f_aff8_76a07ce185f4"></see>
    /// </summary>
    let EMMO_8de14a59_660b_454f_aff8_76a07ce185f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_8de14a59_660b_454f_aff8_76a07ce185f4" |> NamespacedName

    /// <summary>
    /// Average distance that electrons travel between two successive interactions.
    /// <see href="https://w3id.org/emmo#EMMO_8e08b6d4_da0f_4722_a69a_301f2246546c"></see></summary>
    let EMMO_8e08b6d4_da0f_4722_a69a_301f2246546c =
        Namespaced_IRI.parse _namespace_name "EMMO_8e08b6d4_da0f_4722_a69a_301f2246546c" |> NamespacedName

    /// <summary>
    /// Energy imparted to matter by ionizing radiation in a suitable small element of volume divided by the mass of that element of volume.
    /// <see href="https://w3id.org/emmo#EMMO_8e5dd473_808b_4a8a_b7cd_63068c12ff57"></see></summary>
    let EMMO_8e5dd473_808b_4a8a_b7cd_63068c12ff57 =
        Namespaced_IRI.parse _namespace_name "EMMO_8e5dd473_808b_4a8a_b7cd_63068c12ff57" |> NamespacedName

    /// <summary>
    /// In nuclear physics, energy imparted per mass.
    /// <see href="https://w3id.org/emmo#EMMO_a5de0529_7c25_494c_951d_c0a561fd61fd"></see></summary>
    let EMMO_a5de0529_7c25_494c_951d_c0a561fd61fd =
        Namespaced_IRI.parse _namespace_name "EMMO_a5de0529_7c25_494c_951d_c0a561fd61fd" |> NamespacedName

    /// <summary>
    /// Quantum number related to the total angular momentum, J, of a nucleus in any specified state, normally called nuclear spin.
    /// <see href="https://w3id.org/emmo#EMMO_8e655535_d6eb_46cd_9738_f86fa6c93217"></see></summary>
    let EMMO_8e655535_d6eb_46cd_9738_f86fa6c93217 =
        Namespaced_IRI.parse _namespace_name "EMMO_8e655535_d6eb_46cd_9738_f86fa6c93217" |> NamespacedName

    /// <summary>
    /// Atom subclass for strontium.
    /// <see href="https://w3id.org/emmo#EMMO_8ec7fdf6-5652-547d-942f-b8b09ad84660"></see></summary>
    let ``EMMO_8ec7fdf6-5652-547d-942f-b8b09ad84660`` =
        Namespaced_IRI.parse _namespace_name "EMMO_8ec7fdf6-5652-547d-942f-b8b09ad84660" |> NamespacedName

    /// <summary>
    /// Relates a quantity to its numerical value through spatial direct parthood.
    /// <see href="https://w3id.org/emmo#EMMO_8ef3cd6d_ae58_4a8d_9fc0_ad8f49015cd0"></see></summary>
    let EMMO_8ef3cd6d_ae58_4a8d_9fc0_ad8f49015cd0 =
        Namespaced_IRI.parse _namespace_name "EMMO_8ef3cd6d_ae58_4a8d_9fc0_ad8f49015cd0" |> NamespacedName

    /// <summary>
    /// A symbolic that has parts a numerical object and a reference expressing the value of a quantity (expressed as the product of the numerical and the unit).
    /// A quantity value is not necessarily a property, since it is possible to write "10 kg", without assigning this quantity to a specific object.
    /// Following the International Vocabulary of Metrology (VIM), EMMO distinguishes between a quantity (a property) and the quantity value (a numerical and a reference).
    ///
    /// So, for the EMMO the symbol "kg" is not a physical quantity but simply a 'Symbolic' object categorized as a 'MeasurementUnit'.
    ///
    /// While the string "1 kg" is a 'QuantityValue'.
    /// <see href="https://w3id.org/emmo#EMMO_f658c301_ce93_46cf_9639_4eace2c5d1d5"></see></summary>
    let EMMO_f658c301_ce93_46cf_9639_4eace2c5d1d5 =
        Namespaced_IRI.parse _namespace_name "EMMO_f658c301_ce93_46cf_9639_4eace2c5d1d5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8ef46550_7bf2_4ef9_8334_ca3d63fb69b1"></see>
    /// </summary>
    let EMMO_8ef46550_7bf2_4ef9_8334_ca3d63fb69b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_8ef46550_7bf2_4ef9_8334_ca3d63fb69b1" |> NamespacedName

    /// <summary>
    /// Quantity wd = 1 − wH2O, where wH2O is mass fraction of water.
    /// <see href="https://w3id.org/emmo#EMMO_8f171308_f902_42c5_ac1d_d5259022e9c1"></see></summary>
    let EMMO_8f171308_f902_42c5_ac1d_d5259022e9c1 =
        Namespaced_IRI.parse _namespace_name "EMMO_8f171308_f902_42c5_ac1d_d5259022e9c1" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerVolumeTime'.
    /// <see href="https://w3id.org/emmo#EMMO_8f3a9f9f_6f56_49dc_b39e_1aee57ffdc58"></see></summary>
    let EMMO_8f3a9f9f_6f56_49dc_b39e_1aee57ffdc58 =
        Namespaced_IRI.parse _namespace_name "EMMO_8f3a9f9f_6f56_49dc_b39e_1aee57ffdc58" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_8f4d2c80_002f_44b4_a4f1_0d9ead0779ba"></see>
    /// </summary>
    let EMMO_8f4d2c80_002f_44b4_a4f1_0d9ead0779ba =
        Namespaced_IRI.parse _namespace_name "EMMO_8f4d2c80_002f_44b4_a4f1_0d9ead0779ba" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyLengthPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_8fb052e8_fcca_43ce_85db_55266baf2d7c"></see></summary>
    let EMMO_8fb052e8_fcca_43ce_85db_55266baf2d7c =
        Namespaced_IRI.parse _namespace_name "EMMO_8fb052e8_fcca_43ce_85db_55266baf2d7c" |> NamespacedName

    /// <summary>
    /// Heat capacity at constant volume.
    /// <see href="https://w3id.org/emmo#EMMO_8fc576e1_3984_402b_a548_be921b4e1bf4"></see></summary>
    let EMMO_8fc576e1_3984_402b_a548_be921b4e1bf4 =
        Namespaced_IRI.parse _namespace_name "EMMO_8fc576e1_3984_402b_a548_be921b4e1bf4" |> NamespacedName

    /// <summary>
    /// Ratio of transverse strain to axial strain.
    /// <see href="https://w3id.org/emmo#EMMO_8fdabd25_01e0_4296_b82a_09d1c34e52d4"></see></summary>
    let EMMO_8fdabd25_01e0_4296_b82a_09d1c34e52d4 =
        Namespaced_IRI.parse _namespace_name "EMMO_8fdabd25_01e0_4296_b82a_09d1c34e52d4" |> NamespacedName

    /// <summary>
    /// The measure of the resistance of a fluid to flow when an external force is applied.
    /// <see href="https://w3id.org/emmo#EMMO_908da3d5_775e_425e_af96_33914618eb66"></see></summary>
    let EMMO_908da3d5_775e_425e_af96_33914618eb66 =
        Namespaced_IRI.parse _namespace_name "EMMO_908da3d5_775e_425e_af96_33914618eb66" |> NamespacedName

    /// <summary>
    /// "Property of a phenomenon, body, or substance, where the property has no magnitude."
    ///
    /// "A nominal property has a value, which can be expressed in words, by alphanumerical codes, or by other means."
    ///
    /// International vocabulary of metrology (VIM)
    /// An 'ObjectiveProperty' that cannot be quantified.
    /// <see href="https://w3id.org/emmo#EMMO_909415d1_7c43_4d5e_bbeb_7e1910159f66"></see></summary>
    let EMMO_909415d1_7c43_4d5e_bbeb_7e1910159f66 =
        Namespaced_IRI.parse _namespace_name "EMMO_909415d1_7c43_4d5e_bbeb_7e1910159f66" |> NamespacedName

    /// <summary>
    /// Number of all quantum states consistent with given energy, volume, and external fields.
    /// <see href="https://w3id.org/emmo#EMMO_90a1a4d4_7f02_4b0e_9bfd_053bafbed5f2"></see></summary>
    let EMMO_90a1a4d4_7f02_4b0e_9bfd_053bafbed5f2 =
        Namespaced_IRI.parse _namespace_name "EMMO_90a1a4d4_7f02_4b0e_9bfd_053bafbed5f2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_90bfd475_ba4a_4065_b0c1_1f08230be252"></see>
    /// </summary>
    let EMMO_90bfd475_ba4a_4065_b0c1_1f08230be252 =
        Namespaced_IRI.parse _namespace_name "EMMO_90bfd475_ba4a_4065_b0c1_1f08230be252" |> NamespacedName

    /// <summary>
    /// duration of one cycle of a periodic event
    /// <see href="https://w3id.org/emmo#EMMO_90e59882_4592_4036_a75d_5fbefb22dc80"></see></summary>
    let EMMO_90e59882_4592_4036_a75d_5fbefb22dc80 =
        Namespaced_IRI.parse _namespace_name "EMMO_90e59882_4592_4036_a75d_5fbefb22dc80" |> NamespacedName

    /// <summary>
    /// A solvable set of one Physics Equation and one or more Materials Relations.
    /// <see href="https://w3id.org/emmo#EMMO_90f18cf0_1225_4c64_b5f8_f65cd7f992c5"></see></summary>
    let EMMO_90f18cf0_1225_4c64_b5f8_f65cd7f992c5 =
        Namespaced_IRI.parse _namespace_name "EMMO_90f18cf0_1225_4c64_b5f8_f65cd7f992c5" |> NamespacedName

    /// <summary>
    /// A material_relation can e.g. return a predefined number, return a database query, be an equation that depends on other physics_quantities.
    /// An 'equation' that stands for a physical assumption specific to a material, and provides an expression for a 'physics_quantity' (the dependent variable) as function of other variables, physics_quantity or data (independent variables).
    /// <see href="https://w3id.org/emmo#EMMO_e5438930_04e7_4d42_ade5_3700d4a52ab7"></see></summary>
    let EMMO_e5438930_04e7_4d42_ade5_3700d4a52ab7 =
        Namespaced_IRI.parse _namespace_name "EMMO_e5438930_04e7_4d42_ade5_3700d4a52ab7" |> NamespacedName

    /// <summary>
    /// Mean duration required for the decay of one half of the atoms or nuclei.
    /// <see href="https://w3id.org/emmo#EMMO_90f255f7_4890_440d_a8de_841a8437676c"></see></summary>
    let EMMO_90f255f7_4890_440d_a8de_841a8437676c =
        Namespaced_IRI.parse _namespace_name "EMMO_90f255f7_4890_440d_a8de_841a8437676c" |> NamespacedName

    /// <summary>
    /// Relative change of pressure with temperature at constant volume.
    /// <see href="https://w3id.org/emmo#EMMO_90fa8b63_e59d_4c71_b245_6bb759a22e26"></see></summary>
    let EMMO_90fa8b63_e59d_4c71_b245_6bb759a22e26 =
        Namespaced_IRI.parse _namespace_name "EMMO_90fa8b63_e59d_4c71_b245_6bb759a22e26" |> NamespacedName

    /// <summary>
    /// Change of pressure per change of temperature at constant volume.
    /// <see href="https://w3id.org/emmo#EMMO_a4e36749_1f44_4e6c_80e8_d5b27d986d8b"></see></summary>
    let EMMO_a4e36749_1f44_4e6c_80e8_d5b27d986d8b =
        Namespaced_IRI.parse _namespace_name "EMMO_a4e36749_1f44_4e6c_80e8_d5b27d986d8b" |> NamespacedName

    /// <summary>
    /// Probability that a neutron will not escape from the reactor during the slowing-down process or while it diffuses as a thermal neutron.
    /// <see href="https://w3id.org/emmo#EMMO_9140f0d2_fa24_4050_85d9_17d7d2e9e1df"></see></summary>
    let EMMO_9140f0d2_fa24_4050_85d9_17d7d2e9e1df =
        Namespaced_IRI.parse _namespace_name "EMMO_9140f0d2_fa24_4050_85d9_17d7d2e9e1df" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_91447ec0_fb55_49f2_85a5_3172dff6482c"></see>
    /// </summary>
    let EMMO_91447ec0_fb55_49f2_85a5_3172dff6482c =
        Namespaced_IRI.parse _namespace_name "EMMO_91447ec0_fb55_49f2_85a5_3172dff6482c" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the magnesium atom.
    /// <see href="https://w3id.org/emmo#EMMO_91579f8a-e3b1-5ac9-9533-402c8cb1ffdd"></see></summary>
    let ``EMMO_91579f8a-e3b1-5ac9-9533-402c8cb1ffdd`` =
        Namespaced_IRI.parse _namespace_name "EMMO_91579f8a-e3b1-5ac9-9533-402c8cb1ffdd" |> NamespacedName

    /// <summary>
    /// Amount of heat through a surface during a time interval divided by the duration of this interval.
    /// <see href="https://w3id.org/emmo#EMMO_91a99750_7914_42be_9fe5_b82c59183450"></see></summary>
    let EMMO_91a99750_7914_42be_9fe5_b82c59183450 =
        Namespaced_IRI.parse _namespace_name "EMMO_91a99750_7914_42be_9fe5_b82c59183450" |> NamespacedName

    /// <summary>
    /// Vector quantity with magnitude equal to the heat flow rate dΦ through a surface element divided by the area dA of the element, and direction eφ in the direction of propagation of heat.
    /// At a fixed point in a medium, the direction of propagation of heat is opposite to the temperature gradient. At a point on the surface separating two media with different temperatures, the direction of propagation of heat is normal to the surface, from higher to lower temperatures.
    /// <see href="https://w3id.org/emmo#EMMO_ee7ddcb8_ad8e_4ff7_a09f_889d8edf8f8b"></see></summary>
    let EMMO_ee7ddcb8_ad8e_4ff7_a09f_889d8edf8f8b =
        Namespaced_IRI.parse _namespace_name "EMMO_ee7ddcb8_ad8e_4ff7_a09f_889d8edf8f8b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the copernicium atom.
    /// <see href="https://w3id.org/emmo#EMMO_920b8adc-575b-55e9-9cd5-cf5eab1696f1"></see></summary>
    let ``EMMO_920b8adc-575b-55e9-9cd5-cf5eab1696f1`` =
        Namespaced_IRI.parse _namespace_name "EMMO_920b8adc-575b-55e9-9cd5-cf5eab1696f1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_92227f7f_22e9_4b19_a011_920eac3c7b75"></see>
    /// </summary>
    let EMMO_92227f7f_22e9_4b19_a011_920eac3c7b75 =
        Namespaced_IRI.parse _namespace_name "EMMO_92227f7f_22e9_4b19_a011_920eac3c7b75" |> NamespacedName

    /// <summary>
    /// The opposition of a circuit element to a change in current or voltage, due to that element's inductance or capacitance.
    /// The imaginary part of the impedance.
    /// <see href="https://w3id.org/emmo#EMMO_92b2fb85_2143_4bc7_bbca_df3e6944bfc1"></see></summary>
    let EMMO_92b2fb85_2143_4bc7_bbca_df3e6944bfc1 =
        Namespaced_IRI.parse _namespace_name "EMMO_92b2fb85_2143_4bc7_bbca_df3e6944bfc1" |> NamespacedName

    /// <summary>
    /// The abstract notion of angle.
    /// <see href="https://w3id.org/emmo#EMMO_930ce8d9_6cde_4ef9_9cb2_a98a63852b96"></see></summary>
    let EMMO_930ce8d9_6cde_4ef9_9cb2_a98a63852b96 =
        Namespaced_IRI.parse _namespace_name "EMMO_930ce8d9_6cde_4ef9_9cb2_a98a63852b96" |> NamespacedName

    /// <summary>
    /// Non-SI prefixed units that have been accepted by SI to be used together with the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_93170bc8_d3b2_45bd_8cad_20aad08462ef"></see></summary>
    let EMMO_93170bc8_d3b2_45bd_8cad_20aad08462ef =
        Namespaced_IRI.parse _namespace_name "EMMO_93170bc8_d3b2_45bd_8cad_20aad08462ef" |> NamespacedName

    /// <summary>
    /// A estimation of a property using a functional icon.
    /// <see href="https://w3id.org/emmo#EMMO_9335cf09_431f_4613_9dab_ce4ceaca965b"></see></summary>
    let EMMO_9335cf09_431f_4613_9dab_ce4ceaca965b =
        Namespaced_IRI.parse _namespace_name "EMMO_9335cf09_431f_4613_9dab_ce4ceaca965b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentDensityPerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_93681c53_4316_415d_8243_a42a0e171de6"></see></summary>
    let EMMO_93681c53_4316_415d_8243_a42a0e171de6 =
        Namespaced_IRI.parse _namespace_name "EMMO_93681c53_4316_415d_8243_a42a0e171de6" |> NamespacedName

    /// <summary>
    /// A scientific theory is a description, objective and observed, produced with scientific methodology.
    /// <see href="https://w3id.org/emmo#EMMO_937757d3_ed79_4ae3_9513_3b135e58a6a1"></see></summary>
    let EMMO_937757d3_ed79_4ae3_9513_3b135e58a6a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_937757d3_ed79_4ae3_9513_3b135e58a6a1" |> NamespacedName

    /// <summary>
    /// In nuclear physics, quotient of the reduced Planck constant and the mean duration of life of an unstable particle or an excited state.
    /// <see href="https://w3id.org/emmo#EMMO_937db6d0_38c3_4469_aeec_1e033f5ea6c4"></see></summary>
    let EMMO_937db6d0_38c3_4469_aeec_1e033f5ea6c4 =
        Namespaced_IRI.parse _namespace_name "EMMO_937db6d0_38c3_4469_aeec_1e033f5ea6c4" |> NamespacedName

    /// <summary>
    /// The relation between an entity that overlaps another without being its part.
    /// <see href="https://w3id.org/emmo#EMMO_9cb984ca_48ad_4864_b09e_50d3fff19420"></see></summary>
    let EMMO_9cb984ca_48ad_4864_b09e_50d3fff19420 =
        Namespaced_IRI.parse _namespace_name "EMMO_9cb984ca_48ad_4864_b09e_50d3fff19420" |> NamespacedName

    /// <summary>
    /// Ratio of the mass of water vapour to the mass of dry air in a given volume of air.
    /// The mixing ratio at saturation is denoted xsat.
    /// <see href="https://w3id.org/emmo#EMMO_94857660_8739_4270_99a7_c388933fa17d"></see></summary>
    let EMMO_94857660_8739_4270_99a7_c388933fa17d =
        Namespaced_IRI.parse _namespace_name "EMMO_94857660_8739_4270_99a7_c388933fa17d" |> NamespacedName

    /// <summary>
    /// Atom subclass for ruthenium.
    /// <see href="https://w3id.org/emmo#EMMO_948b47f0-3c24-50c7-a698-a805f760e667"></see></summary>
    let ``EMMO_948b47f0-3c24-50c7-a698-a805f760e667`` =
        Namespaced_IRI.parse _namespace_name "EMMO_948b47f0-3c24-50c7-a698-a805f760e667" |> NamespacedName

    /// <summary>
    /// Quotient of Thomson heat power developed, and the electric current and temperature difference.
    /// <see href="https://w3id.org/emmo#EMMO_950256cd_c286_4793_b9f7_a3f922d0c354"></see></summary>
    let EMMO_950256cd_c286_4793_b9f7_a3f922d0c354 =
        Namespaced_IRI.parse _namespace_name "EMMO_950256cd_c286_4793_b9f7_a3f922d0c354" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricPotentialPerTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_96ffda63_71e7_451b_85ee_2cc8e341ff11"></see></summary>
    let EMMO_96ffda63_71e7_451b_85ee_2cc8e341ff11 =
        Namespaced_IRI.parse _namespace_name "EMMO_96ffda63_71e7_451b_85ee_2cc8e341ff11" |> NamespacedName

    /// <summary>
    /// Change of thermodynamic temperature with respect to pressure in a Joule-Thomson process at constant enthalpy.
    /// <see href="https://w3id.org/emmo#EMMO_a43cb01a_beb0_46e1_ae6d_22236222e6a1"></see></summary>
    let EMMO_a43cb01a_beb0_46e1_ae6d_22236222e6a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_a43cb01a_beb0_46e1_ae6d_22236222e6a1" |> NamespacedName

    /// <summary>
    /// Frequency by which the nucleus angular momentum vector precesses about the axis of an external magnetic field.
    /// <see href="https://w3id.org/emmo#EMMO_953d7ce1_2a40_4391_831f_e4be15162efb"></see></summary>
    let EMMO_953d7ce1_2a40_4391_831f_e4be15162efb =
        Namespaced_IRI.parse _namespace_name "EMMO_953d7ce1_2a40_4391_831f_e4be15162efb" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaTime'.
    /// <see href="https://w3id.org/emmo#EMMO_959c9715_14fb_4ce8_a93b_79678b2959b9"></see></summary>
    let EMMO_959c9715_14fb_4ce8_a93b_79678b2959b9 =
        Namespaced_IRI.parse _namespace_name "EMMO_959c9715_14fb_4ce8_a93b_79678b2959b9" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_95d4eb9b_d3d0_4705_a01c_4f87fb5f8d43"></see>
    /// </summary>
    let EMMO_95d4eb9b_d3d0_4705_a01c_4f87fb5f8d43 =
        Namespaced_IRI.parse _namespace_name "EMMO_95d4eb9b_d3d0_4705_a01c_4f87fb5f8d43" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MagneticFluxDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_ec903946_ddc9_464a_903c_7373e0d1eeb5"></see></summary>
    let EMMO_ec903946_ddc9_464a_903c_7373e0d1eeb5 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec903946_ddc9_464a_903c_7373e0d1eeb5" |> NamespacedName

    /// <summary>
    /// Atom subclass for indium.
    /// <see href="https://w3id.org/emmo#EMMO_96522455-d7d7-5b1e-b10a-ad87e41a5adc"></see></summary>
    let ``EMMO_96522455-d7d7-5b1e-b10a-ad87e41a5adc`` =
        Namespaced_IRI.parse _namespace_name "EMMO_96522455-d7d7-5b1e-b10a-ad87e41a5adc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_96c38f8d_fabd_41dc_abda_d15419eb897d"></see>
    /// </summary>
    let EMMO_96c38f8d_fabd_41dc_abda_d15419eb897d =
        Namespaced_IRI.parse _namespace_name "EMMO_96c38f8d_fabd_41dc_abda_d15419eb897d" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerCubicTimeQuarticTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_971b3dff_28b4_4538_b082_3ec9fa5af294"></see></summary>
    let EMMO_971b3dff_28b4_4538_b082_3ec9fa5af294 =
        Namespaced_IRI.parse _namespace_name "EMMO_971b3dff_28b4_4538_b082_3ec9fa5af294" |> NamespacedName

    /// <summary>
    /// A logarithmic unit is a unit that can be used to express a quantity (physical or mathematical) on a logarithmic scale, that is, as being proportional to the value of a logarithm function applied to the ratio of the quantity and a reference quantity of the same type.
    /// Note that logarithmic units like decibel or neper are not univocally defines, since their definition depends on whether they are used to measure a "power" or a "root-power" quantity.
    ///
    /// It is advisory to create a uniquely defined subclass these units for concrete usage.
    /// <see href="https://w3id.org/emmo#EMMO_972e01b0_b017_4903_8c05_b7edda958723"></see></summary>
    let EMMO_972e01b0_b017_4903_8c05_b7edda958723 =
        Namespaced_IRI.parse _namespace_name "EMMO_972e01b0_b017_4903_8c05_b7edda958723" |> NamespacedName

    /// <summary>
    /// A photometric measure of the luminous intensity per unit area of light travelling in a given direction.
    /// Measured in cd/m². Not to confuse with Illuminance, which is measured in lux (cd sr/m²).
    /// <see href="https://w3id.org/emmo#EMMO_97589322_710c_4af4_9431_1e5027f2be42"></see></summary>
    let EMMO_97589322_710c_4af4_9431_1e5027f2be42 =
        Namespaced_IRI.parse _namespace_name "EMMO_97589322_710c_4af4_9431_1e5027f2be42" |> NamespacedName

    /// <summary>
    /// For a quantum level, the statistical weight of that level.
    /// <see href="https://w3id.org/emmo#EMMO_9864a26d_ee34_43ac_bc01_118734886185"></see></summary>
    let EMMO_9864a26d_ee34_43ac_bc01_118734886185 =
        Namespaced_IRI.parse _namespace_name "EMMO_9864a26d_ee34_43ac_bc01_118734886185" |> NamespacedName

    /// <summary>
    /// Quantity characterizing the deviation of a solvent from ideal behavior.
    /// <see href="https://w3id.org/emmo#EMMO_987594e7_c152_4f76_88cf_a80874a864fd"></see></summary>
    let EMMO_987594e7_c152_4f76_88cf_a80874a864fd =
        Namespaced_IRI.parse _namespace_name "EMMO_987594e7_c152_4f76_88cf_a80874a864fd" |> NamespacedName

    /// <summary>
    /// A subclass of measurement unit focusing on the physical dimensionality that is carried by the unit.
    /// The current version of EMMO does not provide explicit classes for physical dimensions. Rather it embraces the fact that the physical dimensionality of a physical quantity is carried by its measurement unit.
    ///
    /// The role of dimensional unit and its subclasses is to express the physical dimensionality that is carried by the unit.
    ///
    /// Since the dimensionality of a physical quantity can be written as the product of powers of the physical dimensions of the base quantities in the selected system of quantities, the physical dimensionality of a measurement unit is uniquely determined by the exponents. For a dimensional unit, at least one of these exponents must be non-zero (making it disjoint from dimensionless units).
    /// <see href="https://w3id.org/emmo#EMMO_cbdea88b_fef1_4c7c_b69f_ae1f0f241c4a"></see></summary>
    let EMMO_cbdea88b_fef1_4c7c_b69f_ae1f0f241c4a =
        Namespaced_IRI.parse _namespace_name "EMMO_cbdea88b_fef1_4c7c_b69f_ae1f0f241c4a" |> NamespacedName

    /// <summary>
    /// An 'equation' that has parts two 'polynomial'-s
    /// <see href="https://w3id.org/emmo#EMMO_98d65021_4574_4890_b2fb_46430841077f"></see></summary>
    let EMMO_98d65021_4574_4890_b2fb_46430841077f =
        Namespaced_IRI.parse _namespace_name "EMMO_98d65021_4574_4890_b2fb_46430841077f" |> NamespacedName

    /// <summary>
    /// The speed of light in vacuum. Defines the base unit metre in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_99296e55_53f7_4333_9e06_760ad175a1b9"></see></summary>
    let EMMO_99296e55_53f7_4333_9e06_760ad175a1b9 =
        Namespaced_IRI.parse _namespace_name "EMMO_99296e55_53f7_4333_9e06_760ad175a1b9" |> NamespacedName

    /// <summary>
    /// In computing, a computer file is a resource for recording data on a computer storage device, primarily identified by its file path.
    /// <see href="https://w3id.org/emmo#EMMO_998dd3a0_c85f_4c8d_9fb8_816a93cc3bb8"></see></summary>
    let EMMO_998dd3a0_c85f_4c8d_9fb8_816a93cc3bb8 =
        Namespaced_IRI.parse _namespace_name "EMMO_998dd3a0_c85f_4c8d_9fb8_816a93cc3bb8" |> NamespacedName

    /// <summary>
    /// Relates a resource to its identifier.
    /// <see href="https://w3id.org/emmo#EMMO_a592c856_4103_43cf_8635_1982a1e5d5de"></see></summary>
    let EMMO_a592c856_4103_43cf_8635_1982a1e5d5de =
        Namespaced_IRI.parse _namespace_name "EMMO_a592c856_4103_43cf_8635_1982a1e5d5de" |> NamespacedName

    /// <summary>
    /// The derivative of the electric charge of a system with respect to the electric potential.
    /// <see href="https://w3id.org/emmo#EMMO_99dba333_0dbd_4f75_8841_8c0f97fd58e2"></see></summary>
    let EMMO_99dba333_0dbd_4f75_8841_8c0f97fd58e2 =
        Namespaced_IRI.parse _namespace_name "EMMO_99dba333_0dbd_4f75_8841_8c0f97fd58e2" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'Capacitance'.
    /// <see href="https://w3id.org/emmo#EMMO_b14d9be5_f81e_469b_abca_379c2e83feab"></see></summary>
    let EMMO_b14d9be5_f81e_469b_abca_379c2e83feab =
        Namespaced_IRI.parse _namespace_name "EMMO_b14d9be5_f81e_469b_abca_379c2e83feab" |> NamespacedName

    /// <summary>
    /// Atom subclass for tin.
    /// <see href="https://w3id.org/emmo#EMMO_9aa9e086-ae07-51f6-bf84-788ffdefcb6f"></see></summary>
    let ``EMMO_9aa9e086-ae07-51f6-bf84-788ffdefcb6f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_9aa9e086-ae07-51f6-bf84-788ffdefcb6f" |> NamespacedName

    /// <summary>
    /// A workflow whose output can be used as input for another workflow of the same type, iteratively, within the framework of a larger workflow.
    /// <see href="https://w3id.org/emmo#EMMO_9ac10a20_63d0_4bbd_a5d3_f00a0ad4682c"></see></summary>
    let EMMO_9ac10a20_63d0_4bbd_a5d3_f00a0ad4682c =
        Namespaced_IRI.parse _namespace_name "EMMO_9ac10a20_63d0_4bbd_a5d3_f00a0ad4682c" |> NamespacedName

    /// <summary>
    /// A semiotic relation that relates a datum to its dimension.
    /// <see href="https://w3id.org/emmo#EMMO_9ae258e3_f79b_4ff3_a777_9c188b3c019c"></see></summary>
    let EMMO_9ae258e3_f79b_4ff3_a777_9c188b3c019c =
        Namespaced_IRI.parse _namespace_name "EMMO_9ae258e3_f79b_4ff3_a777_9c188b3c019c" |> NamespacedName

    /// <summary>
    /// A coded sign that stands for a dimension.
    /// <see href="https://w3id.org/emmo#EMMO_b4c97fa0_d82c_406a_bda7_597d6e190654"></see></summary>
    let EMMO_b4c97fa0_d82c_406a_bda7_597d6e190654 =
        Namespaced_IRI.parse _namespace_name "EMMO_b4c97fa0_d82c_406a_bda7_597d6e190654" |> NamespacedName

    /// <summary>
    /// Quotient of average drift speed imparted to a charged particle in a medium by an electric field, and the electric field strength.
    /// <see href="https://w3id.org/emmo#EMMO_9b8f36cd_4312_4bc3_a99c_420c00f41550"></see></summary>
    let EMMO_9b8f36cd_4312_4bc3_a99c_420c00f41550 =
        Namespaced_IRI.parse _namespace_name "EMMO_9b8f36cd_4312_4bc3_a99c_420c00f41550" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricMobility'.
    /// <see href="https://w3id.org/emmo#EMMO_ca54593a_6828_491b_8fda_22b0ad85e446"></see></summary>
    let EMMO_ca54593a_6828_491b_8fda_22b0ad85e446 =
        Namespaced_IRI.parse _namespace_name "EMMO_ca54593a_6828_491b_8fda_22b0ad85e446" |> NamespacedName

    /// <summary>
    /// Angular frequency divided by angular wavenumber.
    /// <see href="https://w3id.org/emmo#EMMO_9b9e0029_8b16_4382_bd47_571a7ae7d6f6"></see></summary>
    let EMMO_9b9e0029_8b16_4382_bd47_571a7ae7d6f6 =
        Namespaced_IRI.parse _namespace_name "EMMO_9b9e0029_8b16_4382_bd47_571a7ae7d6f6" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerAmount'.
    /// <see href="https://w3id.org/emmo#EMMO_9ba91622_e39f_43e3_b95f_290937928d7e"></see></summary>
    let EMMO_9ba91622_e39f_43e3_b95f_290937928d7e =
        Namespaced_IRI.parse _namespace_name "EMMO_9ba91622_e39f_43e3_b95f_290937928d7e" |> NamespacedName

    /// <summary>
    /// Logarithmic measure of the number of available states of a system.
    /// May also be referred to as a measure of order of  a system.
    /// <see href="https://w3id.org/emmo#EMMO_9bbab0be_f9cc_4f46_9f46_0fd271911b79"></see></summary>
    let EMMO_9bbab0be_f9cc_4f46_9f46_0fd271911b79 =
        Namespaced_IRI.parse _namespace_name "EMMO_9bbab0be_f9cc_4f46_9f46_0fd271911b79" |> NamespacedName

    /// <summary>
    /// Quantity characterising the relative variation of volume with pressure at constant thermodynamic temperature.
    /// <see href="https://w3id.org/emmo#EMMO_9bc6da11_528a_44e8_bd9e_c4154eae7e55"></see></summary>
    let EMMO_9bc6da11_528a_44e8_bd9e_c4154eae7e55 =
        Namespaced_IRI.parse _namespace_name "EMMO_9bc6da11_528a_44e8_bd9e_c4154eae7e55" |> NamespacedName

    /// <summary>
    /// A foam of trapped gas in a solid.
    /// <see href="https://w3id.org/emmo#EMMO_9bed5d66_805a_4b3a_9153_beaf67143848"></see></summary>
    let EMMO_9bed5d66_805a_4b3a_9153_beaf67143848 =
        Namespaced_IRI.parse _namespace_name "EMMO_9bed5d66_805a_4b3a_9153_beaf67143848" |> NamespacedName

    /// <summary>
    /// A law that provides a connection between a property of the object and other properties, capturing a fundamental physical phenomena.
    /// <see href="https://w3id.org/emmo#EMMO_9c32fd69_f480_4130_83b3_fb25d9face14"></see></summary>
    let EMMO_9c32fd69_f480_4130_83b3_fb25d9face14 =
        Namespaced_IRI.parse _namespace_name "EMMO_9c32fd69_f480_4130_83b3_fb25d9face14" |> NamespacedName

    /// <summary>
    /// A scientific theory that focuses on a specific phenomena, for which a single statement (not necessariliy in mathematical form) can be expressed.
    /// <see href="https://w3id.org/emmo#EMMO_db9a009e_f097_43f5_9520_6cbc07e7610b"></see></summary>
    let EMMO_db9a009e_f097_43f5_9520_6cbc07e7610b =
        Namespaced_IRI.parse _namespace_name "EMMO_db9a009e_f097_43f5_9520_6cbc07e7610b" |> NamespacedName

    /// <summary>
    /// The superclass for all physical quantities classes that are categorized according to a standard (e.g. ISQ).
    /// <see href="https://w3id.org/emmo#EMMO_9c407ac0_fd4c_4178_8763_95fad9fe29ec"></see></summary>
    let EMMO_9c407ac0_fd4c_4178_8763_95fad9fe29ec =
        Namespaced_IRI.parse _namespace_name "EMMO_9c407ac0_fd4c_4178_8763_95fad9fe29ec" |> NamespacedName

    /// <summary>
    /// Atom subclass for technetium.
    /// <see href="https://w3id.org/emmo#EMMO_9c803415-5978-5525-9de9-fcf0a2098b4c"></see></summary>
    let ``EMMO_9c803415-5978-5525-9de9-fcf0a2098b4c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_9c803415-5978-5525-9de9-fcf0a2098b4c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerQuarticLengthTime'.
    /// <see href="https://w3id.org/emmo#EMMO_9cffc70d_4b60_4187_a7cd_706f5740ae87"></see></summary>
    let EMMO_9cffc70d_4b60_4187_a7cd_706f5740ae87 =
        Namespaced_IRI.parse _namespace_name "EMMO_9cffc70d_4b60_4187_a7cd_706f5740ae87" |> NamespacedName

    /// <summary>
    /// Number of holes in valence band per volume.
    /// <see href="https://w3id.org/emmo#EMMO_9d018f03_bbda_4ca5_bc4c_646e72651e53"></see></summary>
    let EMMO_9d018f03_bbda_4ca5_bc4c_646e72651e53 =
        Namespaced_IRI.parse _namespace_name "EMMO_9d018f03_bbda_4ca5_bc4c_646e72651e53" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two pressures.
    /// <see href="https://w3id.org/emmo#EMMO_9d09022c_e7ae_4379_a765_4803a8a502a1"></see></summary>
    let EMMO_9d09022c_e7ae_4379_a765_4803a8a502a1 =
        Namespaced_IRI.parse _namespace_name "EMMO_9d09022c_e7ae_4379_a765_4803a8a502a1" |> NamespacedName

    /// <summary>
    /// Measurement unit obtained by dividing a given measurement unit by an integer SI prefix greater than one.
    /// <see href="https://w3id.org/emmo#EMMO_9d28f9ad_d9d3_4edb_bc00_5d9bd242244d"></see></summary>
    let EMMO_9d28f9ad_d9d3_4edb_bc00_5d9bd242244d =
        Namespaced_IRI.parse _namespace_name "EMMO_9d28f9ad_d9d3_4edb_bc00_5d9bd242244d" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "micro" (1e-6).
    /// <see href="https://w3id.org/emmo#EMMO_9ff3bf8e_2168_406e_8251_1d158fc948ae"></see></summary>
    let EMMO_9ff3bf8e_2168_406e_8251_1d158fc948ae =
        Namespaced_IRI.parse _namespace_name "EMMO_9ff3bf8e_2168_406e_8251_1d158fc948ae" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "milli" (1e-3).
    /// <see href="https://w3id.org/emmo#EMMO_a3a701ed_6f7d_4a10_9aee_dfa1961fc7b7"></see></summary>
    let EMMO_a3a701ed_6f7d_4a10_9aee_dfa1961fc7b7 =
        Namespaced_IRI.parse _namespace_name "EMMO_a3a701ed_6f7d_4a10_9aee_dfa1961fc7b7" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "centi" (0.01).
    /// <see href="https://w3id.org/emmo#EMMO_b55cd09a_e54d_4eb1_81dd_03c29d1b878e"></see></summary>
    let EMMO_b55cd09a_e54d_4eb1_81dd_03c29d1b878e =
        Namespaced_IRI.parse _namespace_name "EMMO_b55cd09a_e54d_4eb1_81dd_03c29d1b878e" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "nano" (1e-9).
    /// <see href="https://w3id.org/emmo#EMMO_e1981c25_7c55_4020_aa7a_d2e14ced86d4"></see></summary>
    let EMMO_e1981c25_7c55_4020_aa7a_d2e14ced86d4 =
        Namespaced_IRI.parse _namespace_name "EMMO_e1981c25_7c55_4020_aa7a_d2e14ced86d4" |> NamespacedName

    /// <summary>
    /// Superclass for all units prefixed with "yocto" (1e-24).
    /// <see href="https://w3id.org/emmo#EMMO_f5769206_9257_4b08_bf7b_dad7868c6afc"></see></summary>
    let EMMO_f5769206_9257_4b08_bf7b_dad7868c6afc =
        Namespaced_IRI.parse _namespace_name "EMMO_f5769206_9257_4b08_bf7b_dad7868c6afc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_9d74a963_8c62_4c20_a413_93b786bfbecc"></see>
    /// </summary>
    let EMMO_9d74a963_8c62_4c20_a413_93b786bfbecc =
        Namespaced_IRI.parse _namespace_name "EMMO_9d74a963_8c62_4c20_a413_93b786bfbecc" |> NamespacedName

    /// <summary>
    /// In non-relativistic physics, the centre of mass doesn’t depend on the chosen reference frame.
    /// The unique point where the weighted relative position of the distributed mass of an Item sums to zero. Equivalently, it is the point where if a force is applied to the Item, causes the Item to move in direction of force without rotation.
    /// <see href="https://w3id.org/emmo#EMMO_9d8f708a_f291_4d72_80ec_362c6e6bbca6"></see></summary>
    let EMMO_9d8f708a_f291_4d72_80ec_362c6e6bbca6 =
        Namespaced_IRI.parse _namespace_name "EMMO_9d8f708a_f291_4d72_80ec_362c6e6bbca6" |> NamespacedName

    /// <summary>
    /// Gauge pressure can be measured using a diaphragm sensor, where one side of the diaphragm is exposed to the pressure media that is to be measured, while the other side is exposed to the ambient atmospheric pressure.
    /// The pressure measured relative to the ambient atmospheric pressure.
    /// <see href="https://w3id.org/emmo#EMMO_9e0891a6_4d87_4891_b557_69ab2bae1dae"></see></summary>
    let EMMO_9e0891a6_4d87_4891_b557_69ab2bae1dae =
        Namespaced_IRI.parse _namespace_name "EMMO_9e0891a6_4d87_4891_b557_69ab2bae1dae" |> NamespacedName

    /// <summary>
    /// Measure of the tendency of a substance to leave a phase.
    /// <see href="https://w3id.org/emmo#EMMO_9e2ab15a_f1c7_435b_91ff_bc774e6ba4e7"></see></summary>
    let EMMO_9e2ab15a_f1c7_435b_91ff_bc774e6ba4e7 =
        Namespaced_IRI.parse _namespace_name "EMMO_9e2ab15a_f1c7_435b_91ff_bc774e6ba4e7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_9e452535_a369_404d_9afb_d41fd79d12b8"></see>
    /// </summary>
    let EMMO_9e452535_a369_404d_9afb_d41fd79d12b8 =
        Namespaced_IRI.parse _namespace_name "EMMO_9e452535_a369_404d_9afb_d41fd79d12b8" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a46f2e3f_6d06_4968_a02f_55274d131130"></see>
    /// </summary>
    let EMMO_a46f2e3f_6d06_4968_a02f_55274d131130 =
        Namespaced_IRI.parse _namespace_name "EMMO_a46f2e3f_6d06_4968_a02f_55274d131130" |> NamespacedName

    /// <summary>
    /// Relates an array to the scalar data of its basic elements.
    /// <see href="https://w3id.org/emmo#EMMO_e5a34647_a955_40bc_8d81_9b784f0ac527"></see></summary>
    let EMMO_e5a34647_a955_40bc_8d81_9b784f0ac527 =
        Namespaced_IRI.parse _namespace_name "EMMO_e5a34647_a955_40bc_8d81_9b784f0ac527" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_9e5f464a_658c_4b34_b80d_a5f8d5ec811a"></see>
    /// </summary>
    let EMMO_9e5f464a_658c_4b34_b80d_a5f8d5ec811a =
        Namespaced_IRI.parse _namespace_name "EMMO_9e5f464a_658c_4b34_b80d_a5f8d5ec811a" |> NamespacedName

    /// <summary>
    /// Conductivity per molar concentration of electrolyte.
    /// <see href="https://w3id.org/emmo#EMMO_9e955e04_2977_457e_a91a_bc6a541c9a9e"></see></summary>
    let EMMO_9e955e04_2977_457e_a91a_bc6a541c9a9e =
        Namespaced_IRI.parse _namespace_name "EMMO_9e955e04_2977_457e_a91a_bc6a541c9a9e" |> NamespacedName

    /// <summary>
    /// A data representing a date.
    /// <see href="https://w3id.org/emmo#EMMO_9e985b2c_d36d_4ab5_ab01_3290b6747757"></see></summary>
    let EMMO_9e985b2c_d36d_4ab5_ab01_3290b6747757 =
        Namespaced_IRI.parse _namespace_name "EMMO_9e985b2c_d36d_4ab5_ab01_3290b6747757" |> NamespacedName

    /// <summary>
    /// In a metal, highest occupied energy level at zero thermodynamic temperature, where energy level means the energy of an electron in the interior of a substance.
    /// <see href="https://w3id.org/emmo#EMMO_9eb2d590_2115_4edd_aa8e_345d60921765"></see></summary>
    let EMMO_9eb2d590_2115_4edd_aa8e_345d60921765 =
        Namespaced_IRI.parse _namespace_name "EMMO_9eb2d590_2115_4edd_aa8e_345d60921765" |> NamespacedName

    /// <summary>
    /// Energy of the electron in a hydrogen atom in its ground state
    /// <see href="https://w3id.org/emmo#EMMO_9ecb2aa2_10a9_4499_a3ff_9ad76e9f4e0d"></see></summary>
    let EMMO_9ecb2aa2_10a9_4499_a3ff_9ad76e9f4e0d =
        Namespaced_IRI.parse _namespace_name "EMMO_9ecb2aa2_10a9_4499_a3ff_9ad76e9f4e0d" |> NamespacedName

    /// <summary>
    /// Mathematical description in crystallography.
    /// <see href="https://w3id.org/emmo#EMMO_9ed4ea5a_42c4_48aa_bd59_c16c7d34e741"></see></summary>
    let EMMO_9ed4ea5a_42c4_48aa_bd59_c16c7d34e741 =
        Namespaced_IRI.parse _namespace_name "EMMO_9ed4ea5a_42c4_48aa_bd59_c16c7d34e741" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerLengthTime'.
    /// <see href="https://w3id.org/emmo#EMMO_9f0338b9_326f_44c2_893c_2d815b763130"></see></summary>
    let EMMO_9f0338b9_326f_44c2_893c_2d815b763130 =
        Namespaced_IRI.parse _namespace_name "EMMO_9f0338b9_326f_44c2_893c_2d815b763130" |> NamespacedName

    /// <summary>
    /// Quotient of relative mass excess and the nucleon number.
    /// <see href="https://w3id.org/emmo#EMMO_9f33b66d_f2d6_47d0_b163_deeb3d45685a"></see></summary>
    let EMMO_9f33b66d_f2d6_47d0_b163_deeb3d45685a =
        Namespaced_IRI.parse _namespace_name "EMMO_9f33b66d_f2d6_47d0_b163_deeb3d45685a" |> NamespacedName

    /// <summary>
    /// An initial step of a workflow.
    /// There may be more than one begin task, if they run in parallel.
    /// <see href="https://w3id.org/emmo#EMMO_b941e455_2cb1_4c11_93e3_17caa06086b4"></see></summary>
    let EMMO_b941e455_2cb1_4c11_93e3_17caa06086b4 =
        Namespaced_IRI.parse _namespace_name "EMMO_b941e455_2cb1_4c11_93e3_17caa06086b4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_9fa966c7_5231_409e_841f_b4c5fd33732a"></see>
    /// </summary>
    let EMMO_9fa966c7_5231_409e_841f_b4c5fd33732a =
        Namespaced_IRI.parse _namespace_name "EMMO_9fa966c7_5231_409e_841f_b4c5fd33732a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a086af15_a7c3_404c_b4ce_c8e4466f1b4b"></see>
    /// </summary>
    let EMMO_a086af15_a7c3_404c_b4ce_c8e4466f1b4b =
        Namespaced_IRI.parse _namespace_name "EMMO_a086af15_a7c3_404c_b4ce_c8e4466f1b4b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a09a5342_cad4_40fa_a619_a5af0867cb8f"></see>
    /// </summary>
    let EMMO_a09a5342_cad4_40fa_a619_a5af0867cb8f =
        Namespaced_IRI.parse _namespace_name "EMMO_a09a5342_cad4_40fa_a619_a5af0867cb8f" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting a decucing interpreter to the "deduced" semiotic object in a deduction process.
    /// <see href="https://w3id.org/emmo#EMMO_a0a2ded8_54e8_408d_a6b0_7fd1b4d7d16d"></see></summary>
    let EMMO_a0a2ded8_54e8_408d_a6b0_7fd1b4d7d16d =
        Namespaced_IRI.parse _namespace_name "EMMO_a0a2ded8_54e8_408d_a6b0_7fd1b4d7d16d" |> NamespacedName

    /// <summary>
    /// Least energy required for the emission of a conduction electron.
    /// Work function is the energy difference between an electron at rest at infinity and an electron at the Fermi level in the interior of a substance.
    /// <see href="https://w3id.org/emmo#EMMO_a0c4322d_4de2_4770_991c_5fad4e6ec25b"></see></summary>
    let EMMO_a0c4322d_4de2_4770_991c_5fad4e6ec25b =
        Namespaced_IRI.parse _namespace_name "EMMO_a0c4322d_4de2_4770_991c_5fad4e6ec25b" |> NamespacedName

    /// <summary>
    /// Length of a rectifiable curve between two of its points.
    /// <see href="https://w3id.org/emmo#EMMO_a0ce1017_0467_473b_8af8_0ddf4621b0be"></see></summary>
    let EMMO_a0ce1017_0467_473b_8af8_0ddf4621b0be =
        Namespaced_IRI.parse _namespace_name "EMMO_a0ce1017_0467_473b_8af8_0ddf4621b0be" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a139c6d5_1a0b_4605_a6c0_9f383539f9b1"></see>
    /// </summary>
    let EMMO_a139c6d5_1a0b_4605_a6c0_9f383539f9b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_a139c6d5_1a0b_4605_a6c0_9f383539f9b1" |> NamespacedName

    /// <summary>
    /// Mass of the contained water vapour per volume.
    /// <see href="https://w3id.org/emmo#EMMO_a13cff6e_41fd_48d5_82b6_3a9015f19001"></see></summary>
    let EMMO_a13cff6e_41fd_48d5_82b6_3a9015f19001 =
        Namespaced_IRI.parse _namespace_name "EMMO_a13cff6e_41fd_48d5_82b6_3a9015f19001" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a14dd591_8b7a_4847_8c91_3a2f421a45b4"></see>
    /// </summary>
    let EMMO_a14dd591_8b7a_4847_8c91_3a2f421a45b4 =
        Namespaced_IRI.parse _namespace_name "EMMO_a14dd591_8b7a_4847_8c91_3a2f421a45b4" |> NamespacedName

    /// <summary>
    /// translation vector that maps the crystal lattice on itself
    /// <see href="https://w3id.org/emmo#EMMO_a1bd0bfc_5464_43ce_a1a2_947b58dc0f89"></see></summary>
    let EMMO_a1bd0bfc_5464_43ce_a1a2_947b58dc0f89 =
        Namespaced_IRI.parse _namespace_name "EMMO_a1bd0bfc_5464_43ce_a1a2_947b58dc0f89" |> NamespacedName

    /// <summary>
    /// In condensed matter physics, the square root of the product of diffusion coefficient and lifetime.
    /// <see href="https://w3id.org/emmo#EMMO_a2641370_e4b8_4582_b4e0_fb389c8d8efb"></see></summary>
    let EMMO_a2641370_e4b8_4582_b4e0_fb389c8d8efb =
        Namespaced_IRI.parse _namespace_name "EMMO_a2641370_e4b8_4582_b4e0_fb389c8d8efb" |> NamespacedName

    /// <summary>
    /// Displacement of one surface with respect to another divided by the distance between them.
    /// <see href="https://w3id.org/emmo#EMMO_a2682209_f9e2_4024_98dd_ed1f6c5699be"></see></summary>
    let EMMO_a2682209_f9e2_4024_98dd_ed1f6c5699be =
        Namespaced_IRI.parse _namespace_name "EMMO_a2682209_f9e2_4024_98dd_ed1f6c5699be" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the lanthanum atom.
    /// <see href="https://w3id.org/emmo#EMMO_a3569860-5d20-5e69-baf6-cbe8ae7cfc15"></see></summary>
    let ``EMMO_a3569860-5d20-5e69-baf6-cbe8ae7cfc15`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a3569860-5d20-5e69-baf6-cbe8ae7cfc15" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a365b3c1_7bde_41d7_a15b_2820762e85f4"></see>
    /// </summary>
    let EMMO_a365b3c1_7bde_41d7_a15b_2820762e85f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_a365b3c1_7bde_41d7_a15b_2820762e85f4" |> NamespacedName

    /// <summary>
    /// Thermodynamic temperature at which vapour in air reaches saturation.
    /// The corresponding Celsius temperature is denoted td and is also called dew point.
    /// <see href="https://w3id.org/emmo#EMMO_a383e332_a271_463f_9e44_559604547220"></see></summary>
    let EMMO_a383e332_a271_463f_9e44_559604547220 =
        Namespaced_IRI.parse _namespace_name "EMMO_a383e332_a271_463f_9e44_559604547220" |> NamespacedName

    /// <summary>
    /// The Rydberg constant represents the limiting value of the highest wavenumber (the inverse wavelength) of any photon that can be emitted from the hydrogen atom, or, alternatively, the wavenumber of the lowest-energy photon capable of ionizing the hydrogen atom from its ground state.
    /// <see href="https://w3id.org/emmo#EMMO_a3c78d6f_ae49_47c8_a634_9b6d86b79382"></see></summary>
    let EMMO_a3c78d6f_ae49_47c8_a634_9b6d86b79382 =
        Namespaced_IRI.parse _namespace_name "EMMO_a3c78d6f_ae49_47c8_a634_9b6d86b79382" |> NamespacedName

    /// <summary>
    /// The number of waves per unit length along the direction of propagation.
    /// <see href="https://w3id.org/emmo#EMMO_d859588d_44dc_4614_bc75_5fcd0058acc8"></see></summary>
    let EMMO_d859588d_44dc_4614_bc75_5fcd0058acc8 =
        Namespaced_IRI.parse _namespace_name "EMMO_d859588d_44dc_4614_bc75_5fcd0058acc8" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePerPressure'.
    /// <see href="https://w3id.org/emmo#EMMO_a4edc0c9_6d1d_4358_8030_b61db6c84176"></see></summary>
    let EMMO_a4edc0c9_6d1d_4358_8030_b61db6c84176 =
        Namespaced_IRI.parse _namespace_name "EMMO_a4edc0c9_6d1d_4358_8030_b61db6c84176" |> NamespacedName

    /// <summary>
    /// Quotient of mass concentration of water vapour and mass concentration at its saturation
    ///
    /// ψ = r/rsat
    ///
    /// where r is mass ratio of water vapour to dry gas and rsat is the mass ratio of water vapour to dry gas at saturation of the same temperature.
    /// <see href="https://w3id.org/emmo#EMMO_a45dc074_c5ed_4aad_a4e7_141a02fe1d73"></see></summary>
    let EMMO_a45dc074_c5ed_4aad_a4e7_141a02fe1d73 =
        Namespaced_IRI.parse _namespace_name "EMMO_a45dc074_c5ed_4aad_a4e7_141a02fe1d73" |> NamespacedName

    /// <summary>
    /// A graphical representation of a molecular structure showing the relative position in space of the atomic constituents and their bonds.
    /// <see href="https://w3id.org/emmo#EMMO_a466b60b_d973_4b8f_897f_d0b837a59df3"></see></summary>
    let EMMO_a466b60b_d973_4b8f_897f_d0b837a59df3 =
        Namespaced_IRI.parse _namespace_name "EMMO_a466b60b_d973_4b8f_897f_d0b837a59df3" |> NamespacedName

    /// <summary>
    /// A representation of objects belonging to the chemistry field.
    /// <see href="https://w3id.org/emmo#EMMO_ecc4efe9_77a2_47e3_8190_f9a883d54ac6"></see></summary>
    let EMMO_ecc4efe9_77a2_47e3_8190_f9a883d54ac6 =
        Namespaced_IRI.parse _namespace_name "EMMO_ecc4efe9_77a2_47e3_8190_f9a883d54ac6" |> NamespacedName

    /// <summary>
    /// Atom subclass for iron.
    /// <see href="https://w3id.org/emmo#EMMO_a4839f08-1080-53bf-9cb3-101e20c2656b"></see></summary>
    let ``EMMO_a4839f08-1080-53bf-9cb3-101e20c2656b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a4839f08-1080-53bf-9cb3-101e20c2656b" |> NamespacedName

    /// <summary>
    /// A computational application that uses existing data to predict the behaviour of a system without providing a identifiable analogy with the original object.
    /// <see href="https://w3id.org/emmo#EMMO_a4b14b83_9392_4a5f_a2e8_b2b58793f59b"></see></summary>
    let EMMO_a4b14b83_9392_4a5f_a2e8_b2b58793f59b =
        Namespaced_IRI.parse _namespace_name "EMMO_a4b14b83_9392_4a5f_a2e8_b2b58793f59b" |> NamespacedName

    /// <summary>
    /// A strict fundamental object overcrossing a manufacturing process, the intersection being the agent that participates and drives the manufacturing process.
    /// <see href="https://w3id.org/emmo#EMMO_c0afb341_7d31_4883_a307_ae4606df2a1b"></see></summary>
    let EMMO_c0afb341_7d31_4883_a307_ae4606df2a1b =
        Namespaced_IRI.parse _namespace_name "EMMO_c0afb341_7d31_4883_a307_ae4606df2a1b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricPotentialPerArea'.
    /// <see href="https://w3id.org/emmo#EMMO_a5111335_6d14_49d9_ba7a_10c10b2189e7"></see></summary>
    let EMMO_a5111335_6d14_49d9_ba7a_10c10b2189e7 =
        Namespaced_IRI.parse _namespace_name "EMMO_a5111335_6d14_49d9_ba7a_10c10b2189e7" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a6138ba7_e365_4f2d_b6b4_fe5a5918d403"></see>
    /// </summary>
    let EMMO_a6138ba7_e365_4f2d_b6b4_fe5a5918d403 =
        Namespaced_IRI.parse _namespace_name "EMMO_a6138ba7_e365_4f2d_b6b4_fe5a5918d403" |> NamespacedName

    /// <summary>
    /// A process which is an holistic temporal part of a process.
    /// <see href="https://w3id.org/emmo#EMMO_a633c6f8_4269_4870_9b28_f5ca1783fd54"></see></summary>
    let EMMO_a633c6f8_4269_4870_9b28_f5ca1783fd54 =
        Namespaced_IRI.parse _namespace_name "EMMO_a633c6f8_4269_4870_9b28_f5ca1783fd54" |> NamespacedName

    /// <summary>
    /// Scalar potential of an irrotational magnetic field strength.
    /// <see href="https://w3id.org/emmo#EMMO_a68368e4_b822_4395_9213_ae7429a677d6"></see></summary>
    let EMMO_a68368e4_b822_4395_9213_ae7429a677d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_a68368e4_b822_4395_9213_ae7429a677d6" |> NamespacedName

    /// <summary>
    /// Symbol representing a punctuation character.
    /// <see href="https://w3id.org/emmo#EMMO_a817035a_3e3c_4709_8ede_3205df3031a3"></see></summary>
    let EMMO_a817035a_3e3c_4709_8ede_3205df3031a3 =
        Namespaced_IRI.parse _namespace_name "EMMO_a817035a_3e3c_4709_8ede_3205df3031a3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_a85d0b8a_588e_423f_b799_97b0890e9183"></see>
    /// </summary>
    let EMMO_a85d0b8a_588e_423f_b799_97b0890e9183 =
        Namespaced_IRI.parse _namespace_name "EMMO_a85d0b8a_588e_423f_b799_97b0890e9183" |> NamespacedName

    /// <summary>
    /// Volume of a constituent of a mixture divided by the sum of volumes of all constituents prior to mixing.
    /// <see href="https://w3id.org/emmo#EMMO_a8eb87b5_4d10_4137_a75c_e04ee59ca095"></see></summary>
    let EMMO_a8eb87b5_4d10_4137_a75c_e04ee59ca095 =
        Namespaced_IRI.parse _namespace_name "EMMO_a8eb87b5_4d10_4137_a75c_e04ee59ca095" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the potassium atom.
    /// <see href="https://w3id.org/emmo#EMMO_a939c29d-2304-5e48-8b15-fc592a9d1813"></see></summary>
    let ``EMMO_a939c29d-2304-5e48-8b15-fc592a9d1813`` =
        Namespaced_IRI.parse _namespace_name "EMMO_a939c29d-2304-5e48-8b15-fc592a9d1813" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerAreaTime'.
    /// <see href="https://w3id.org/emmo#EMMO_a94aec97_71ff_4574_b111_a52d77d2c230"></see></summary>
    let EMMO_a94aec97_71ff_4574_b111_a52d77d2c230 =
        Namespaced_IRI.parse _namespace_name "EMMO_a94aec97_71ff_4574_b111_a52d77d2c230" |> NamespacedName

    /// <summary>
    /// Radius of the circular movement of an electrically charged particle in a magnetic field.
    /// <see href="https://w3id.org/emmo#EMMO_aa078194_12df_4b10_b264_6595d2472570"></see></summary>
    let EMMO_aa078194_12df_4b10_b264_6595d2472570 =
        Namespaced_IRI.parse _namespace_name "EMMO_aa078194_12df_4b10_b264_6595d2472570" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_aa446897_0683_4e9b_9b0e_b6081d2d70d8"></see>
    /// </summary>
    let EMMO_aa446897_0683_4e9b_9b0e_b6081d2d70d8 =
        Namespaced_IRI.parse _namespace_name "EMMO_aa446897_0683_4e9b_9b0e_b6081d2d70d8" |> NamespacedName

    /// <summary>
    /// A data representing 32-bit integer number.
    /// <see href="https://w3id.org/emmo#EMMO_aa972cc9_5d9e_47a2_abc5_00243d6b3917"></see></summary>
    let EMMO_aa972cc9_5d9e_47a2_abc5_00243d6b3917 =
        Namespaced_IRI.parse _namespace_name "EMMO_aa972cc9_5d9e_47a2_abc5_00243d6b3917" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_aab6a0cc_2fbd_43ac_ac5a_b7b7b75331dc"></see>
    /// </summary>
    let EMMO_aab6a0cc_2fbd_43ac_ac5a_b7b7b75331dc =
        Namespaced_IRI.parse _namespace_name "EMMO_aab6a0cc_2fbd_43ac_ac5a_b7b7b75331dc" |> NamespacedName

    /// <summary>
    /// The effectiveness of a force to produce rotation about an axis, measured by the product of the force and the perpendicular distance from the line of action of the force to the axis.
    /// Even though torque has the same physical dimension as energy, it is not of the same kind and can not be measured with energy units like joule or electron volt.
    /// <see href="https://w3id.org/emmo#EMMO_aaf9dd7f_0474_40d0_9606_02def8515249"></see></summary>
    let EMMO_aaf9dd7f_0474_40d0_9606_02def8515249 =
        Namespaced_IRI.parse _namespace_name "EMMO_aaf9dd7f_0474_40d0_9606_02def8515249" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TimePerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_ab2ee5cd_4de3_46b6_bec5_29e293b33422"></see></summary>
    let EMMO_ab2ee5cd_4de3_46b6_bec5_29e293b33422 =
        Namespaced_IRI.parse _namespace_name "EMMO_ab2ee5cd_4de3_46b6_bec5_29e293b33422" |> NamespacedName

    /// <summary>
    /// Inverse of the time constant of an exponentially varying quantity.
    /// <see href="https://w3id.org/emmo#EMMO_ab3e812f_4d0f_4290_83fb_b2f5963f3772"></see></summary>
    let EMMO_ab3e812f_4d0f_4290_83fb_b2f5963f3772 =
        Namespaced_IRI.parse _namespace_name "EMMO_ab3e812f_4d0f_4290_83fb_b2f5963f3772" |> NamespacedName

    /// <summary>
    /// Quotient of a quantity by a duration.
    /// <see href="https://w3id.org/emmo#EMMO_de2c6b70_bc1e_48ff_84b7_8fa16e0287fa"></see></summary>
    let EMMO_de2c6b70_bc1e_48ff_84b7_8fa16e0287fa =
        Namespaced_IRI.parse _namespace_name "EMMO_de2c6b70_bc1e_48ff_84b7_8fa16e0287fa" |> NamespacedName

    /// <summary>
    /// The energy of an object due to its motion.
    /// <see href="https://w3id.org/emmo#EMMO_ac540a9d_0131_43f6_a33b_17e5cfc432ed"></see></summary>
    let EMMO_ac540a9d_0131_43f6_a33b_17e5cfc432ed =
        Namespaced_IRI.parse _namespace_name "EMMO_ac540a9d_0131_43f6_a33b_17e5cfc432ed" |> NamespacedName

    /// <summary>
    /// Heat capacity at constant pressure.
    /// <see href="https://w3id.org/emmo#EMMO_ac82358d_94a7_4ceb_93e7_41bab5bcefdf"></see></summary>
    let EMMO_ac82358d_94a7_4ceb_93e7_41bab5bcefdf =
        Namespaced_IRI.parse _namespace_name "EMMO_ac82358d_94a7_4ceb_93e7_41bab5bcefdf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ac852bf0_3251_4d6b_9e57_acbfcb5e7e08"></see>
    /// </summary>
    let EMMO_ac852bf0_3251_4d6b_9e57_acbfcb5e7e08 =
        Namespaced_IRI.parse _namespace_name "EMMO_ac852bf0_3251_4d6b_9e57_acbfcb5e7e08" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_b35e92d7_7fa0_4661_aa5a_5cea7c8e6925"></see>
    /// </summary>
    let EMMO_b35e92d7_7fa0_4661_aa5a_5cea7c8e6925 =
        Namespaced_IRI.parse _namespace_name "EMMO_b35e92d7_7fa0_4661_aa5a_5cea7c8e6925" |> NamespacedName

    /// <summary>
    /// A symbolic data representing a 32-bit floating point numbers incl. ±Inf, ±0, NaN.
    /// <see href="https://w3id.org/emmo#EMMO_ac9e518d_b403_4d8b_97e2_06f9d40bac01"></see></summary>
    let EMMO_ac9e518d_b403_4d8b_97e2_06f9d40bac01 =
        Namespaced_IRI.parse _namespace_name "EMMO_ac9e518d_b403_4d8b_97e2_06f9d40bac01" |> NamespacedName

    /// <summary>
    /// Change of the relative positions of parts of a body, excluding a displacement of the body as a whole.
    /// <see href="https://w3id.org/emmo#EMMO_acf636d4_9ac2_4ce3_960a_d54338e6cae3"></see></summary>
    let EMMO_acf636d4_9ac2_4ce3_960a_d54338e6cae3 =
        Namespaced_IRI.parse _namespace_name "EMMO_acf636d4_9ac2_4ce3_960a_d54338e6cae3" |> NamespacedName

    /// <summary>
    /// Atom subclass for niobium.
    /// <see href="https://w3id.org/emmo#EMMO_ad2056af-0fa7-56cf-a881-80e3a7dfd266"></see></summary>
    let ``EMMO_ad2056af-0fa7-56cf-a881-80e3a7dfd266`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ad2056af-0fa7-56cf-a881-80e3a7dfd266" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the niobium atom.
    /// <see href="https://w3id.org/emmo#EMMO_f0f7abe2-766d-5dcd-ba67-ada816684677"></see></summary>
    let ``EMMO_f0f7abe2-766d-5dcd-ba67-ada816684677`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f0f7abe2-766d-5dcd-ba67-ada816684677" |> NamespacedName

    /// <summary>
    /// Equivalent to the Boltzmann constant, but expressed in units of energy per temperature increment per mole (rather than energy per temperature increment per particle).
    /// <see href="https://w3id.org/emmo#EMMO_ad6c76cf_b400_423e_820f_cf0c4e77f455"></see></summary>
    let EMMO_ad6c76cf_b400_423e_820f_cf0c4e77f455 =
        Namespaced_IRI.parse _namespace_name "EMMO_ad6c76cf_b400_423e_820f_cf0c4e77f455" |> NamespacedName

    /// <summary>
    /// Quotient of the Boltzmann constant and the mass m.
    /// <see href="https://w3id.org/emmo#EMMO_f1be7d92_c57d_4698_a0ba_968130a3f9e1"></see></summary>
    let EMMO_f1be7d92_c57d_4698_a0ba_968130a3f9e1 =
        Namespaced_IRI.parse _namespace_name "EMMO_f1be7d92_c57d_4698_a0ba_968130a3f9e1" |> NamespacedName

    /// <summary>
    /// A computer language that expresses the presentation of structured documents.
    /// <see href="https://w3id.org/emmo#EMMO_ad8b1096_4df1_44f5_a3b9_fc2ec9e7f5b1"></see></summary>
    let EMMO_ad8b1096_4df1_44f5_a3b9_fc2ec9e7f5b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_ad8b1096_4df1_44f5_a3b9_fc2ec9e7f5b1" |> NamespacedName

    /// <summary>
    /// Distance a magnetic field penetrates the plane surface of a semi-finite superconductor.
    /// <see href="https://w3id.org/emmo#EMMO_ad91ad62_ef79_42ad_8e15_34cbd95d69cb"></see></summary>
    let EMMO_ad91ad62_ef79_42ad_8e15_34cbd95d69cb =
        Namespaced_IRI.parse _namespace_name "EMMO_ad91ad62_ef79_42ad_8e15_34cbd95d69cb" |> NamespacedName

    /// <summary>
    /// Gibbs energy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_ad9d6895_2800_48ad_8007_e293c52a8178"></see></summary>
    let EMMO_ad9d6895_2800_48ad_8007_e293c52a8178 =
        Namespaced_IRI.parse _namespace_name "EMMO_ad9d6895_2800_48ad_8007_e293c52a8178" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_add2e29d_6d87_4b78_9706_588e25557093"></see>
    /// </summary>
    let EMMO_add2e29d_6d87_4b78_9706_588e25557093 =
        Namespaced_IRI.parse _namespace_name "EMMO_add2e29d_6d87_4b78_9706_588e25557093" |> NamespacedName

    /// <summary>
    /// A variable that stand for a well known numerical constant (a known number).
    /// <see href="https://w3id.org/emmo#EMMO_ae15fb4f_8e4d_41de_a0f9_3997f89ba6a2"></see></summary>
    let EMMO_ae15fb4f_8e4d_41de_a0f9_3997f89ba6a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_ae15fb4f_8e4d_41de_a0f9_3997f89ba6a2" |> NamespacedName

    /// <summary>
    /// Helmholtz energy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_aea43ae4_f824_4c42_892e_709bf9dc1c40"></see></summary>
    let EMMO_aea43ae4_f824_4c42_892e_709bf9dc1c40 =
        Namespaced_IRI.parse _namespace_name "EMMO_aea43ae4_f824_4c42_892e_709bf9dc1c40" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ReciprocalAmountPerVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_aef218f9_6ded_4db9_9263_e78eed55e5d6"></see></summary>
    let EMMO_aef218f9_6ded_4db9_9263_e78eed55e5d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_aef218f9_6ded_4db9_9263_e78eed55e5d6" |> NamespacedName

    /// <summary>
    /// A grammar for annotating a document in a way that is syntactically distinguishable from the text.
    /// <see href="https://w3id.org/emmo#EMMO_af7b627d_6528_4fdb_97df_ba4579c4bb5d"></see></summary>
    let EMMO_af7b627d_6528_4fdb_97df_ba4579c4bb5d =
        Namespaced_IRI.parse _namespace_name "EMMO_af7b627d_6528_4fdb_97df_ba4579c4bb5d" |> NamespacedName

    /// <summary>
    /// Mass per unit area.
    /// <see href="https://w3id.org/emmo#EMMO_afea89af_ef16_4bdb_99d5_f3b2f4c85a6c"></see></summary>
    let EMMO_afea89af_ef16_4bdb_99d5_f3b2f4c85a6c =
        Namespaced_IRI.parse _namespace_name "EMMO_afea89af_ef16_4bdb_99d5_f3b2f4c85a6c" |> NamespacedName

    /// <summary>
    /// The mass concentration of water at saturation is denoted wsat.
    /// Quotient of the mass of water in a three-dimensional domain, irrespective of the form of aggregation, by the volume of the domain.
    /// <see href="https://w3id.org/emmo#EMMO_b02aaadc_592d_4d65_bf11_eee06bd9f80d"></see></summary>
    let EMMO_b02aaadc_592d_4d65_bf11_eee06bd9f80d =
        Namespaced_IRI.parse _namespace_name "EMMO_b02aaadc_592d_4d65_bf11_eee06bd9f80d" |> NamespacedName

    /// <summary>
    /// Duration required for the neutron fluence rate in a reactor to change by the factor e when the fluence rate is rising or falling exponentially.
    /// <see href="https://w3id.org/emmo#EMMO_b03dfad7_eab8_4949_9d10_dd4fd12faaef"></see></summary>
    let EMMO_b03dfad7_eab8_4949_9d10_dd4fd12faaef =
        Namespaced_IRI.parse _namespace_name "EMMO_b03dfad7_eab8_4949_9d10_dd4fd12faaef" |> NamespacedName

    /// <summary>
    /// Atom subclass for lanthanum.
    /// <see href="https://w3id.org/emmo#EMMO_b0597d20-6438-53e5-a627-b9dacebc69da"></see></summary>
    let ``EMMO_b0597d20-6438-53e5-a627-b9dacebc69da`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b0597d20-6438-53e5-a627-b9dacebc69da" |> NamespacedName

    /// <summary>
    /// The set of units provided by the SI referring to the ISQ.
    /// The names, symbols and prefixes of SI units are defined by the General Conference on Weights and Measures (CGPM).
    ///
    /// https://en.wikipedia.org/wiki/General_Conference_on_Weights_and_Measures
    /// The complete set of SI units includes both the coherent set and the multiples and sub-multiples formed by using the SI prefixes.
    /// <see href="https://w3id.org/emmo#EMMO_feb03a8a_bbb6_4918_a891_46713ef557f4"></see></summary>
    let EMMO_feb03a8a_bbb6_4918_a891_46713ef557f4 =
        Namespaced_IRI.parse _namespace_name "EMMO_feb03a8a_bbb6_4918_a891_46713ef557f4" |> NamespacedName

    /// <summary>
    /// Number of different microstates in a subsystem.
    /// <see href="https://w3id.org/emmo#EMMO_b0ef0941_5c92_4b71_bc26_95e95e5e0004"></see></summary>
    let EMMO_b0ef0941_5c92_4b71_bc26_95e95e5e0004 =
        Namespaced_IRI.parse _namespace_name "EMMO_b0ef0941_5c92_4b71_bc26_95e95e5e0004" |> NamespacedName

    /// <summary>
    /// A mixed tiling in wich a tile is the next of spatially connected tiles.
    /// <see href="https://w3id.org/emmo#EMMO_b1862e72_219f_4fc0_b58c_b26339f6dc88"></see></summary>
    let EMMO_b1862e72_219f_4fc0_b58c_b26339f6dc88 =
        Namespaced_IRI.parse _namespace_name "EMMO_b1862e72_219f_4fc0_b58c_b26339f6dc88" |> NamespacedName

    /// <summary>
    /// Relates a dataset to its datum.
    /// <see href="https://w3id.org/emmo#EMMO_b19aacfc_5f73_4c33_9456_469c1e89a53e"></see></summary>
    let EMMO_b19aacfc_5f73_4c33_9456_469c1e89a53e =
        Namespaced_IRI.parse _namespace_name "EMMO_b19aacfc_5f73_4c33_9456_469c1e89a53e" |> NamespacedName

    /// <summary>
    /// The relation between a object whole and its spatial part of the same type.
    /// <see href="https://w3id.org/emmo#EMMO_b1daa610_64c6_4935_94b8_a19db586a2f6"></see></summary>
    let EMMO_b1daa610_64c6_4935_94b8_a19db586a2f6 =
        Namespaced_IRI.parse _namespace_name "EMMO_b1daa610_64c6_4935_94b8_a19db586a2f6" |> NamespacedName

    /// <summary>
    /// Atom subclass for uranium.
    /// <see href="https://w3id.org/emmo#EMMO_b233f8c0-37d8-51ae-9264-560e6649e246"></see></summary>
    let ``EMMO_b233f8c0-37d8-51ae-9264-560e6649e246`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b233f8c0-37d8-51ae-9264-560e6649e246" |> NamespacedName

    /// <summary>
    /// At a given point within a domain of quasi-infinitesimal volume V, vector quantity equal to the magnetic area moment m of the substance contained within the domain divided by the volume V.
    /// <see href="https://w3id.org/emmo#EMMO_b23e7251_a488_4732_8268_027ad76d7e37"></see></summary>
    let EMMO_b23e7251_a488_4732_8268_027ad76d7e37 =
        Namespaced_IRI.parse _namespace_name "EMMO_b23e7251_a488_4732_8268_027ad76d7e37" |> NamespacedName

    /// <summary>
    /// A causal system posessing bonding that can not be representated by a simple Feynman diagram.
    /// <see href="https://w3id.org/emmo#EMMO_b295158f_fda4_4124_ab58_d9ea4ccfca5a"></see></summary>
    let EMMO_b295158f_fda4_4124_ab58_d9ea4ccfca5a =
        Namespaced_IRI.parse _namespace_name "EMMO_b295158f_fda4_4124_ab58_d9ea4ccfca5a" |> NamespacedName

    /// <summary>
    /// A mathematical model can be defined as a description of a system using mathematical concepts and language to facilitate proper explanation of a system or to study the effects of different components and to make predictions on patterns of behaviour.
    ///
    /// Abramowitz and Stegun, 1968
    /// An analogical icon expressed in mathematical language.
    /// <see href="https://w3id.org/emmo#EMMO_f7ed665b_c2e1_42bc_889b_6b42ed3a36f0"></see></summary>
    let EMMO_f7ed665b_c2e1_42bc_889b_6b42ed3a36f0 =
        Namespaced_IRI.parse _namespace_name "EMMO_f7ed665b_c2e1_42bc_889b_6b42ed3a36f0" |> NamespacedName

    /// <summary>
    /// Self-connected one-manyfold.
    /// <see href="https://w3id.org/emmo#EMMO_b2a234a8_579a_422c_9305_b8f7e72c76cd"></see></summary>
    let EMMO_b2a234a8_579a_422c_9305_b8f7e72c76cd =
        Namespaced_IRI.parse _namespace_name "EMMO_b2a234a8_579a_422c_9305_b8f7e72c76cd" |> NamespacedName

    /// <summary>
    /// The relation between electric field strength and current density in an isotropic conductor.
    /// <see href="https://w3id.org/emmo#EMMO_b30d4f1c_61e3_4647_bae1_c0928acb2095"></see></summary>
    let EMMO_b30d4f1c_61e3_4647_bae1_c0928acb2095 =
        Namespaced_IRI.parse _namespace_name "EMMO_b30d4f1c_61e3_4647_bae1_c0928acb2095" |> NamespacedName

    /// <summary>
    /// Specific heat capacity at saturated vaport pressure.
    /// <see href="https://w3id.org/emmo#EMMO_b33909cc_61a1_4ab3_a1f8_d9283a6b1a0d"></see></summary>
    let EMMO_b33909cc_61a1_4ab3_a1f8_d9283a6b1a0d =
        Namespaced_IRI.parse _namespace_name "EMMO_b33909cc_61a1_4ab3_a1f8_d9283a6b1a0d" |> NamespacedName

    /// <summary>
    /// Heat capacity divided by mass.
    /// <see href="https://w3id.org/emmo#EMMO_b4f4ed28_d24c_4a00_9583_62ab839abeca"></see></summary>
    let EMMO_b4f4ed28_d24c_4a00_9583_62ab839abeca =
        Namespaced_IRI.parse _namespace_name "EMMO_b4f4ed28_d24c_4a00_9583_62ab839abeca" |> NamespacedName

    /// <summary>
    /// Quantity equal to the volume dV of substance crossing a given surface during a time interval with infinitesimal duration dt, divided by this duration, thus qV = dV / dt-
    /// <see href="https://w3id.org/emmo#EMMO_b385b94e_ffff_47a2_8971_856f92dd786e"></see></summary>
    let EMMO_b385b94e_ffff_47a2_8971_856f92dd786e =
        Namespaced_IRI.parse _namespace_name "EMMO_b385b94e_ffff_47a2_8971_856f92dd786e" |> NamespacedName

    /// <summary>
    /// Time constant for recombination or trapping of minority charge carriers in semiconductors
    /// <see href="https://w3id.org/emmo#EMMO_b3bf01d2_5d67_45d3_91e6_70abddae08a9"></see></summary>
    let EMMO_b3bf01d2_5d67_45d3_91e6_70abddae08a9 =
        Namespaced_IRI.parse _namespace_name "EMMO_b3bf01d2_5d67_45d3_91e6_70abddae08a9" |> NamespacedName

    /// <summary>
    /// Mean energy, excluding rest energy, of the particles that are emitted, transferred, or received.
    /// <see href="https://w3id.org/emmo#EMMO_b3c004d7_d377_459d_8857_dee6b5f51f3a"></see></summary>
    let EMMO_b3c004d7_d377_459d_8857_dee6b5f51f3a =
        Namespaced_IRI.parse _namespace_name "EMMO_b3c004d7_d377_459d_8857_dee6b5f51f3a" |> NamespacedName

    /// <summary>
    /// Atom subclass for bromine.
    /// <see href="https://w3id.org/emmo#EMMO_b3dfa085-5206-5868-b060-13efa01caf8e"></see></summary>
    let ``EMMO_b3dfa085-5206-5868-b060-13efa01caf8e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b3dfa085-5206-5868-b060-13efa01caf8e" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the beryllium atom.
    /// <see href="https://w3id.org/emmo#EMMO_b42b9f49-aa2a-5dc7-afa5-9c5c013b621d"></see></summary>
    let ``EMMO_b42b9f49-aa2a-5dc7-afa5-9c5c013b621d`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b42b9f49-aa2a-5dc7-afa5-9c5c013b621d" |> NamespacedName

    /// <summary>
    /// Will be removed with 1.0.0 release due to duplicated scope of emmo:example with respect to skos:example
    /// <see href="https://w3id.org/emmo#EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a"></see></summary>
    let EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a =
        Namespaced_IRI.parse _namespace_name "EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a" |> NamespacedName

    /// <summary>
    /// Atom subclass for californium.
    /// <see href="https://w3id.org/emmo#EMMO_b443dea3-7407-59c3-9e86-6784e715f48b"></see></summary>
    let ``EMMO_b443dea3-7407-59c3-9e86-6784e715f48b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b443dea3-7407-59c3-9e86-6784e715f48b" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the californium atom.
    /// <see href="https://w3id.org/emmo#EMMO_ff1d6ece-712d-54b8-9c05-c26854e0c35a"></see></summary>
    let ``EMMO_ff1d6ece-712d-54b8-9c05-c26854e0c35a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ff1d6ece-712d-54b8-9c05-c26854e0c35a" |> NamespacedName

    /// <summary>
    /// Angular frequency of the electron angular momentum vector precession about the axis of an external magnetic field.
    /// <see href="https://w3id.org/emmo#EMMO_b452fe23_0c61_436d_8357_57a521448801"></see></summary>
    let EMMO_b452fe23_0c61_436d_8357_57a521448801 =
        Namespaced_IRI.parse _namespace_name "EMMO_b452fe23_0c61_436d_8357_57a521448801" |> NamespacedName

    /// <summary>
    /// Strength of a magnetic field. Commonly denoted H.
    /// <see href="https://w3id.org/emmo#EMMO_b4895f75_41c8_4fd9_b6d6_4d5f7c99c423"></see></summary>
    let EMMO_b4895f75_41c8_4fd9_b6d6_4d5f7c99c423 =
        Namespaced_IRI.parse _namespace_name "EMMO_b4895f75_41c8_4fd9_b6d6_4d5f7c99c423" |> NamespacedName

    /// <summary>
    /// The total luminous flux incident on a surface, per unit area.
    /// <see href="https://w3id.org/emmo#EMMO_b51fbd00_a857_4132_9711_0ef70e7bdd20"></see></summary>
    let EMMO_b51fbd00_a857_4132_9711_0ef70e7bdd20 =
        Namespaced_IRI.parse _namespace_name "EMMO_b51fbd00_a857_4132_9711_0ef70e7bdd20" |> NamespacedName

    /// <summary>
    /// Quotient of dynamic viscosity and mass density of a fluid.
    /// <see href="https://w3id.org/emmo#EMMO_b5523f03_5f2f_4e11_92c0_3734c6de3749"></see></summary>
    let EMMO_b5523f03_5f2f_4e11_92c0_3734c6de3749 =
        Namespaced_IRI.parse _namespace_name "EMMO_b5523f03_5f2f_4e11_92c0_3734c6de3749" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_b5c58790_fb2d_42eb_b184_2a3f6ca60acb"></see>
    /// </summary>
    let EMMO_b5c58790_fb2d_42eb_b184_2a3f6ca60acb =
        Namespaced_IRI.parse _namespace_name "EMMO_b5c58790_fb2d_42eb_b184_2a3f6ca60acb" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_b5efbfa6_8610_4e3e_ad36_93e426bd873e"></see>
    /// </summary>
    let EMMO_b5efbfa6_8610_4e3e_ad36_93e426bd873e =
        Namespaced_IRI.parse _namespace_name "EMMO_b5efbfa6_8610_4e3e_ad36_93e426bd873e" |> NamespacedName

    /// <summary>
    /// For ionizing uncharged particles of a given type and energy, the differential quotient of Rtr with respect to l. Where Rtr is the mean energy that is transferred to kinetic energy of charged particles by interactions of the uncharged particles of incident radiant energy R in traversing a distance  l in the material of density rho, divided by rho and R
    /// <see href="https://w3id.org/emmo#EMMO_b642d14c_0ba3_43c0_aa90_d0df922486c0"></see></summary>
    let EMMO_b642d14c_0ba3_43c0_aa90_d0df922486c0 =
        Namespaced_IRI.parse _namespace_name "EMMO_b642d14c_0ba3_43c0_aa90_d0df922486c0" |> NamespacedName

    /// <summary>
    /// Atom subclass for moscovium.
    /// <see href="https://w3id.org/emmo#EMMO_b655f801-c5b9-5187-99e8-c9eba8645c05"></see></summary>
    let ``EMMO_b655f801-c5b9-5187-99e8-c9eba8645c05`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b655f801-c5b9-5187-99e8-c9eba8645c05" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the moscovium atom.
    /// <see href="https://w3id.org/emmo#EMMO_ced3fb28-51f7-5208-9aab-d1f8bef21ee5"></see></summary>
    let ``EMMO_ced3fb28-51f7-5208-9aab-d1f8bef21ee5`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ced3fb28-51f7-5208-9aab-d1f8bef21ee5" |> NamespacedName

    /// <summary>
    /// Atom subclass for dubnium.
    /// <see href="https://w3id.org/emmo#EMMO_b65acde7-56c5-5cca-b589-b6744beb4223"></see></summary>
    let ``EMMO_b65acde7-56c5-5cca-b589-b6744beb4223`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b65acde7-56c5-5cca-b589-b6744beb4223" |> NamespacedName

    /// <summary>
    /// Complex representation of an oscillating voltage.
    /// <see href="https://w3id.org/emmo#EMMO_b67a9ef5_880a_487c_84e8_3b36faba9159"></see></summary>
    let EMMO_b67a9ef5_880a_487c_84e8_3b36faba9159 =
        Namespaced_IRI.parse _namespace_name "EMMO_b67a9ef5_880a_487c_84e8_3b36faba9159" |> NamespacedName

    /// <summary>
    /// Scalar quantity equal to the flux of the displacement current density JD through a given directed surface S.
    /// <see href="https://w3id.org/emmo#EMMO_b6a008a8_39b1_451c_93d2_dae1e17ec8db"></see></summary>
    let EMMO_b6a008a8_39b1_451c_93d2_dae1e17ec8db =
        Namespaced_IRI.parse _namespace_name "EMMO_b6a008a8_39b1_451c_93d2_dae1e17ec8db" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_b7229683_d2c5_4225_8e5f_7693744fd5a2"></see>
    /// </summary>
    let EMMO_b7229683_d2c5_4225_8e5f_7693744fd5a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_b7229683_d2c5_4225_8e5f_7693744fd5a2" |> NamespacedName

    /// <summary>
    /// Measure of voltage induced by change of temperature.
    /// <see href="https://w3id.org/emmo#EMMO_b725aad8_55e2_430a_b2d2_f84b8333484e"></see></summary>
    let EMMO_b725aad8_55e2_430a_b2d2_f84b8333484e =
        Namespaced_IRI.parse _namespace_name "EMMO_b725aad8_55e2_430a_b2d2_f84b8333484e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_b7493aee_366c_442d_8f59_49ac7aa664d7"></see>
    /// </summary>
    let EMMO_b7493aee_366c_442d_8f59_49ac7aa664d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_b7493aee_366c_442d_8f59_49ac7aa664d7" |> NamespacedName

    /// <summary>
    /// Atom subclass for beryllium.
    /// <see href="https://w3id.org/emmo#EMMO_b8294a50-b121-5b9c-bacd-5d4206c3aaaf"></see></summary>
    let ``EMMO_b8294a50-b121-5b9c-bacd-5d4206c3aaaf`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b8294a50-b121-5b9c-bacd-5d4206c3aaaf" |> NamespacedName

    /// <summary>
    /// Quotient of the total mean charge of all positive ions produced by an ionizing charged particle along its entire path and along the paths of any secondary charged particles, and the elementary charge.
    /// <see href="https://w3id.org/emmo#EMMO_b82d6a44_ea23_4b68_9b24_70f77deac955"></see></summary>
    let EMMO_b82d6a44_ea23_4b68_9b24_70f77deac955 =
        Namespaced_IRI.parse _namespace_name "EMMO_b82d6a44_ea23_4b68_9b24_70f77deac955" |> NamespacedName

    /// <summary>
    /// Assigns a quantity to an object via a well-defined modelling procedure.
    /// <see href="https://w3id.org/emmo#EMMO_b8f79e53_2ad4_441d_87ff_284a5c419e46"></see></summary>
    let EMMO_b8f79e53_2ad4_441d_87ff_284a5c419e46 =
        Namespaced_IRI.parse _namespace_name "EMMO_b8f79e53_2ad4_441d_87ff_284a5c419e46" |> NamespacedName

    /// <summary>
    /// A quantity obtained from a well-defined modelling procedure.
    /// <see href="https://w3id.org/emmo#EMMO_d0200cf1_e4f4_45ae_873f_b9359daea3cd"></see></summary>
    let EMMO_d0200cf1_e4f4_45ae_873f_b9359daea3cd =
        Namespaced_IRI.parse _namespace_name "EMMO_d0200cf1_e4f4_45ae_873f_b9359daea3cd" |> NamespacedName

    /// <summary>
    /// Atom subclass for chlorine.
    /// <see href="https://w3id.org/emmo#EMMO_b92900ac-69b2-5a63-a9d5-4984ae20905a"></see></summary>
    let ``EMMO_b92900ac-69b2-5a63-a9d5-4984ae20905a`` =
        Namespaced_IRI.parse _namespace_name "EMMO_b92900ac-69b2-5a63-a9d5-4984ae20905a" |> NamespacedName

    /// <summary>
    /// Critical thermodynamic temperature of a superconductor.
    /// <see href="https://w3id.org/emmo#EMMO_b94b3748_71c5_4de9_95e7_42586c3ed607"></see></summary>
    let EMMO_b94b3748_71c5_4de9_95e7_42586c3ed607 =
        Namespaced_IRI.parse _namespace_name "EMMO_b94b3748_71c5_4de9_95e7_42586c3ed607" |> NamespacedName

    /// <summary>
    /// In physics, a state of matter is one of the distinct forms in which matter can exist. Four states of matter are observable in everyday life: solid, liquid, gas, and plasma.
    /// A superclass made as the disjoint union of all the form under which matter can exist.
    /// <see href="https://w3id.org/emmo#EMMO_b9695e87_8261_412e_83cd_a86459426a28"></see></summary>
    let EMMO_b9695e87_8261_412e_83cd_a86459426a28 =
        Namespaced_IRI.parse _namespace_name "EMMO_b9695e87_8261_412e_83cd_a86459426a28" |> NamespacedName

    /// <summary>
    /// Inverse of the magnetic flux quantum.
    /// The DBpedia definition (http://dbpedia.org/page/Magnetic_flux_quantum) is outdated as May 20, 2019. It is now an exact quantity.
    /// <see href="https://w3id.org/emmo#EMMO_ba380bc6_2bfd_4f11_94c7_b3cbaafd1631"></see></summary>
    let EMMO_ba380bc6_2bfd_4f11_94c7_b3cbaafd1631 =
        Namespaced_IRI.parse _namespace_name "EMMO_ba380bc6_2bfd_4f11_94c7_b3cbaafd1631" |> NamespacedName

    /// <summary>
    /// An agent that is driven by the intention to reach a defined objective in driving a process.
    /// Intentionality is not limited to human agents, but in general to all agents that have the capacity to decide to act in driving a process according to a motivation.
    /// <see href="https://w3id.org/emmo#EMMO_c130614a_2985_476d_a7ed_8a137847703c"></see></summary>
    let EMMO_c130614a_2985_476d_a7ed_8a137847703c =
        Namespaced_IRI.parse _namespace_name "EMMO_c130614a_2985_476d_a7ed_8a137847703c" |> NamespacedName

    /// <summary>
    /// The relation within a process and an agengt participant.
    /// <see href="https://w3id.org/emmo#EMMO_cd24eb82_a11c_4a31_96ea_32f870c5580a"></see></summary>
    let EMMO_cd24eb82_a11c_4a31_96ea_32f870c5580a =
        Namespaced_IRI.parse _namespace_name "EMMO_cd24eb82_a11c_4a31_96ea_32f870c5580a" |> NamespacedName

    /// <summary>
    /// The mass concentration of water at saturation is denoted usat.
    /// Ratio of the mass of water to the mass of dry matter in a given volume of matter.
    /// <see href="https://w3id.org/emmo#EMMO_bba5d6f7_53e5_417a_855e_a95322fb641e"></see></summary>
    let EMMO_bba5d6f7_53e5_417a_855e_a95322fb641e =
        Namespaced_IRI.parse _namespace_name "EMMO_bba5d6f7_53e5_417a_855e_a95322fb641e" |> NamespacedName

    /// <summary>
    /// Atom subclass for mercury.
    /// <see href="https://w3id.org/emmo#EMMO_bc1bb0e8-ec90-5276-a15c-3e805144a083"></see></summary>
    let ``EMMO_bc1bb0e8-ec90-5276-a15c-3e805144a083`` =
        Namespaced_IRI.parse _namespace_name "EMMO_bc1bb0e8-ec90-5276-a15c-3e805144a083" |> NamespacedName

    /// <summary>
    /// Atom subclass for thallium.
    /// <see href="https://w3id.org/emmo#EMMO_bcf70555-8df3-5a39-b26a-a5e802d17a37"></see></summary>
    let ``EMMO_bcf70555-8df3-5a39-b26a-a5e802d17a37`` =
        Namespaced_IRI.parse _namespace_name "EMMO_bcf70555-8df3-5a39-b26a-a5e802d17a37" |> NamespacedName

    /// <summary>
    /// Axial vector quantity describing the rotation around an axis, with magnitude ω=|dφ/dt|, where dφ is the plane angle change during the infinitesimal time interval with duration dt, and with direction along the axis for which the rotation is clockwise.
    /// <see href="https://w3id.org/emmo#EMMO_bd325ef5_4127_420c_83d3_207b3e2184fd"></see></summary>
    let EMMO_bd325ef5_4127_420c_83d3_207b3e2184fd =
        Namespaced_IRI.parse _namespace_name "EMMO_bd325ef5_4127_420c_83d3_207b3e2184fd" |> NamespacedName

    /// <summary>
    /// Increase in the rate of reaction of a specified chemical reaction that an enzyme produces in a specific assay system.
    /// <see href="https://w3id.org/emmo#EMMO_bd67d149_24c2_4bc9_833a_c2bc26f98fd3"></see></summary>
    let EMMO_bd67d149_24c2_4bc9_833a_c2bc26f98fd3 =
        Namespaced_IRI.parse _namespace_name "EMMO_bd67d149_24c2_4bc9_833a_c2bc26f98fd3" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'CatalyticActivity'.
    /// <see href="https://w3id.org/emmo#EMMO_ce7d4720_aa20_4a8c_93e8_df41a35b6723"></see></summary>
    let EMMO_ce7d4720_aa20_4a8c_93e8_df41a35b6723 =
        Namespaced_IRI.parse _namespace_name "EMMO_ce7d4720_aa20_4a8c_93e8_df41a35b6723" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_bd8db028_aec2_4a44_ad93_1a9f8270f72c"></see>
    /// </summary>
    let EMMO_bd8db028_aec2_4a44_ad93_1a9f8270f72c =
        Namespaced_IRI.parse _namespace_name "EMMO_bd8db028_aec2_4a44_ad93_1a9f8270f72c" |> NamespacedName

    /// <summary>
    /// Quotient of the product of the electric charge of a particle and the magnitude of the magnetic flux density of the magnetic field, and the particle mass.
    /// <see href="https://w3id.org/emmo#EMMO_bdb1ece0_0631_452e_9348_8387595428e8"></see></summary>
    let EMMO_bdb1ece0_0631_452e_9348_8387595428e8 =
        Namespaced_IRI.parse _namespace_name "EMMO_bdb1ece0_0631_452e_9348_8387595428e8" |> NamespacedName

    /// <summary>
    /// Quotient of change of volume and original volume.
    /// <see href="https://w3id.org/emmo#EMMO_bdb76b61_4bf6_44d6_9424_6cc073f964bc"></see></summary>
    let EMMO_bdb76b61_4bf6_44d6_9424_6cc073f964bc =
        Namespaced_IRI.parse _namespace_name "EMMO_bdb76b61_4bf6_44d6_9424_6cc073f964bc" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_bdee99f6_389b_4816_8a1c_a7903a2df00a"></see></summary>
    let EMMO_bdee99f6_389b_4816_8a1c_a7903a2df00a =
        Namespaced_IRI.parse _namespace_name "EMMO_bdee99f6_389b_4816_8a1c_a7903a2df00a" |> NamespacedName

    /// <summary>
    /// A meson with spin two.
    /// <see href="https://w3id.org/emmo#EMMO_f895cb83_2280_42e9_9f4c_047273e70d3c"></see></summary>
    let EMMO_f895cb83_2280_42e9_9f4c_047273e70d3c =
        Namespaced_IRI.parse _namespace_name "EMMO_f895cb83_2280_42e9_9f4c_047273e70d3c" |> NamespacedName

    /// <summary>
    /// The value of the chemical potential under specified standard conditions (in the standard state).
    /// <see href="https://w3id.org/emmo#EMMO_be31e6c6_881f_41c4_8354_c05aac4d7c46"></see></summary>
    let EMMO_be31e6c6_881f_41c4_8354_c05aac4d7c46 =
        Namespaced_IRI.parse _namespace_name "EMMO_be31e6c6_881f_41c4_8354_c05aac4d7c46" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_be8680e5_28ec_4168_9206_d1cd33fbd458"></see>
    /// </summary>
    let EMMO_be8680e5_28ec_4168_9206_d1cd33fbd458 =
        Namespaced_IRI.parse _namespace_name "EMMO_be8680e5_28ec_4168_9206_d1cd33fbd458" |> NamespacedName

    /// <summary>
    /// Symbol representing a letter in an alphabet.
    /// <see href="https://w3id.org/emmo#EMMO_bed2fe4c_dc7e_43a8_8200_6aac44030bff"></see></summary>
    let EMMO_bed2fe4c_dc7e_43a8_8200_6aac44030bff =
        Namespaced_IRI.parse _namespace_name "EMMO_bed2fe4c_dc7e_43a8_8200_6aac44030bff" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PowerArea'.
    /// <see href="https://w3id.org/emmo#EMMO_bf106e62_ce1c_4ccc_9f45_c10326078a5a"></see></summary>
    let EMMO_bf106e62_ce1c_4ccc_9f45_c10326078a5a =
        Namespaced_IRI.parse _namespace_name "EMMO_bf106e62_ce1c_4ccc_9f45_c10326078a5a" |> NamespacedName

    /// <summary>
    /// For solvent A, standard absolute activity of the pure substance A at the same temperature and at a standard pressure.
    /// <see href="https://w3id.org/emmo#EMMO_bf66642d_f13d_42d2_ad6d_eafd41686155"></see></summary>
    let EMMO_bf66642d_f13d_42d2_ad6d_eafd41686155 =
        Namespaced_IRI.parse _namespace_name "EMMO_bf66642d_f13d_42d2_ad6d_eafd41686155" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_bf836c2b_7800_474d_b674_f5d629fa0bb1"></see>
    /// </summary>
    let EMMO_bf836c2b_7800_474d_b674_f5d629fa0bb1 =
        Namespaced_IRI.parse _namespace_name "EMMO_bf836c2b_7800_474d_b674_f5d629fa0bb1" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the sodium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c00cc96e-a51e-5dc9-9e6c-1cc4dfaf1c67"></see></summary>
    let ``EMMO_c00cc96e-a51e-5dc9-9e6c-1cc4dfaf1c67`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c00cc96e-a51e-5dc9-9e6c-1cc4dfaf1c67" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'QuarticElectricDipoleMomentPerCubicEnergy'.
    /// <see href="https://w3id.org/emmo#EMMO_c0487653_66e8_454e_bb11_e50167e412e4"></see></summary>
    let EMMO_c0487653_66e8_454e_bb11_e50167e412e4 =
        Namespaced_IRI.parse _namespace_name "EMMO_c0487653_66e8_454e_bb11_e50167e412e4" |> NamespacedName

    /// <summary>
    /// Atom subclass for zirconium.
    /// <see href="https://w3id.org/emmo#EMMO_c052baf7-358f-55de-8ca3-9688563c3cfb"></see></summary>
    let ``EMMO_c052baf7-358f-55de-8ca3-9688563c3cfb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c052baf7-358f-55de-8ca3-9688563c3cfb" |> NamespacedName

    /// <summary>
    /// Square root of the migration area, M^2.
    /// <see href="https://w3id.org/emmo#EMMO_c05759c8_de71_4223_abba_630ae405b2b8"></see></summary>
    let EMMO_c05759c8_de71_4223_abba_630ae405b2b8 =
        Namespaced_IRI.parse _namespace_name "EMMO_c05759c8_de71_4223_abba_630ae405b2b8" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_4b32fc1e_5293_4247_9e8d_1175df9f1c0b"></see>
    /// </summary>
    let EMMO_4b32fc1e_5293_4247_9e8d_1175df9f1c0b =
        Namespaced_IRI.parse _namespace_name "EMMO_4b32fc1e_5293_4247_9e8d_1175df9f1c0b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c0ec56d1_0deb_4452_a6a1_70570308b6bb"></see>
    /// </summary>
    let EMMO_c0ec56d1_0deb_4452_a6a1_70570308b6bb =
        Namespaced_IRI.parse _namespace_name "EMMO_c0ec56d1_0deb_4452_a6a1_70570308b6bb" |> NamespacedName

    /// <summary>
    /// The relation between the whole and a temporal tile that has only ingoing temporal connections.
    /// <see href="https://w3id.org/emmo#EMMO_c0f48dc6_4a32_4d9a_a956_d68415954a8e"></see></summary>
    let EMMO_c0f48dc6_4a32_4d9a_a956_d68415954a8e =
        Namespaced_IRI.parse _namespace_name "EMMO_c0f48dc6_4a32_4d9a_a956_d68415954a8e" |> NamespacedName

    /// <summary>
    /// Time derivative of exposure.
    /// <see href="https://w3id.org/emmo#EMMO_c12eb68b_8526_4c35_8346_c27194946353"></see></summary>
    let EMMO_c12eb68b_8526_4c35_8346_c27194946353 =
        Namespaced_IRI.parse _namespace_name "EMMO_c12eb68b_8526_4c35_8346_c27194946353" |> NamespacedName

    /// <summary>
    /// Sum of electric current density and displacement current density.
    /// <see href="https://w3id.org/emmo#EMMO_c18fff21_87c8_4877_a7e6_9ca1052d074e"></see></summary>
    let EMMO_c18fff21_87c8_4877_a7e6_9ca1052d074e =
        Namespaced_IRI.parse _namespace_name "EMMO_c18fff21_87c8_4877_a7e6_9ca1052d074e" |> NamespacedName

    /// <summary>
    /// A boson with spin of 1 that carries electromagnetism.
    /// <see href="https://w3id.org/emmo#EMMO_c1a6e72c_de7a_48db_8f45_32c0be019291"></see></summary>
    let EMMO_c1a6e72c_de7a_48db_8f45_32c0be019291 =
        Namespaced_IRI.parse _namespace_name "EMMO_c1a6e72c_de7a_48db_8f45_32c0be019291" |> NamespacedName

    /// <summary>
    /// Atom subclass for tellurium.
    /// <see href="https://w3id.org/emmo#EMMO_c1b40f92-d27d-5aa0-9811-b6c58391f951"></see></summary>
    let ``EMMO_c1b40f92-d27d-5aa0-9811-b6c58391f951`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c1b40f92-d27d-5aa0-9811-b6c58391f951" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the tellurium atom.
    /// <see href="https://w3id.org/emmo#EMMO_cf55f4d1-3865-5de4-88b4-3045f0db3a20"></see></summary>
    let ``EMMO_cf55f4d1-3865-5de4-88b4-3045f0db3a20`` =
        Namespaced_IRI.parse _namespace_name "EMMO_cf55f4d1-3865-5de4-88b4-3045f0db3a20" |> NamespacedName

    /// <summary>
    /// The diameter of a circle or a sphere is twice its radius.
    /// maximal distance of two points of an object, in a given direction or along a straight line passing through the centre.
    /// <see href="https://w3id.org/emmo#EMMO_c1c8ac3c_8a1c_4777_8e0b_14c1f9f9b0c6"></see></summary>
    let EMMO_c1c8ac3c_8a1c_4777_8e0b_14c1f9f9b0c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_c1c8ac3c_8a1c_4777_8e0b_14c1f9f9b0c6" |> NamespacedName

    /// <summary>
    /// Number dN of spontaneous nuclear transitions or nuclear disintegrations for a radionuclide of amount N produced during a short time interval dt, divided by this time interval.
    /// <see href="https://w3id.org/emmo#EMMO_c20dd550_7241_4ca4_b5b1_0d300ab03b6c"></see></summary>
    let EMMO_c20dd550_7241_4ca4_b5b1_0d300ab03b6c =
        Namespaced_IRI.parse _namespace_name "EMMO_c20dd550_7241_4ca4_b5b1_0d300ab03b6c" |> NamespacedName

    /// <summary>
    /// Arctan of the loss factor
    /// <see href="https://w3id.org/emmo#EMMO_c2a2b2ac_1fbe_46d9_8853_6497cea6ff43"></see></summary>
    let EMMO_c2a2b2ac_1fbe_46d9_8853_6497cea6ff43 =
        Namespaced_IRI.parse _namespace_name "EMMO_c2a2b2ac_1fbe_46d9_8853_6497cea6ff43" |> NamespacedName

    /// <summary>
    /// Measure for the energy lost by charged particles per traversed distance, including only interactions up to a given energy.
    /// <see href="https://w3id.org/emmo#EMMO_c2d725c3_9c16_4871_9a86_7afa12fc0a01"></see></summary>
    let EMMO_c2d725c3_9c16_4871_9a86_7afa12fc0a01 =
        Namespaced_IRI.parse _namespace_name "EMMO_c2d725c3_9c16_4871_9a86_7afa12fc0a01" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c2d9d370_f9eb_40be_b01e_7ceba8f7457f"></see>
    /// </summary>
    let EMMO_c2d9d370_f9eb_40be_b01e_7ceba8f7457f =
        Namespaced_IRI.parse _namespace_name "EMMO_c2d9d370_f9eb_40be_b01e_7ceba8f7457f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c30aaeb1_66cc_4c69_8890_d7812c1d608c"></see>
    /// </summary>
    let EMMO_c30aaeb1_66cc_4c69_8890_d7812c1d608c =
        Namespaced_IRI.parse _namespace_name "EMMO_c30aaeb1_66cc_4c69_8890_d7812c1d608c" |> NamespacedName

    /// <summary>
    /// Atom subclass for antimony.
    /// <see href="https://w3id.org/emmo#EMMO_c32f8642-f1a1-5fae-8b4e-990b40f6eff8"></see></summary>
    let ``EMMO_c32f8642-f1a1-5fae-8b4e-990b40f6eff8`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c32f8642-f1a1-5fae-8b4e-990b40f6eff8" |> NamespacedName

    /// <summary>
    /// Quotient of the number of internal conversion electrons and the number of gamma quanta emitted by the radioactive atom in a given transition, where a conversion electron represents an orbital electron emitted through the radioactive decay.
    /// <see href="https://w3id.org/emmo#EMMO_c365fcb8_095d_416b_b4df_a18f2f557016"></see></summary>
    let EMMO_c365fcb8_095d_416b_b4df_a18f2f557016 =
        Namespaced_IRI.parse _namespace_name "EMMO_c365fcb8_095d_416b_b4df_a18f2f557016" |> NamespacedName

    /// <summary>
    /// Inverse of the quality factor.
    /// <see href="https://w3id.org/emmo#EMMO_c3796906_8063_47d4_92af_890ae08f25fa"></see></summary>
    let EMMO_c3796906_8063_47d4_92af_890ae08f25fa =
        Namespaced_IRI.parse _namespace_name "EMMO_c3796906_8063_47d4_92af_890ae08f25fa" |> NamespacedName

    /// <summary>
    /// Negative quotient of Helmholtz energy and temperature.
    /// <see href="https://w3id.org/emmo#EMMO_c39d6a20_b987_49db_addb_a498635b89ff"></see></summary>
    let EMMO_c39d6a20_b987_49db_addb_a498635b89ff =
        Namespaced_IRI.parse _namespace_name "EMMO_c39d6a20_b987_49db_addb_a498635b89ff" |> NamespacedName

    /// <summary>
    /// Parameter for diffusion and fluid flow in porous media.
    /// <see href="https://w3id.org/emmo#EMMO_c413d96f_c57b_4c70_9ac1_312db6c009a8"></see></summary>
    let EMMO_c413d96f_c57b_4c70_9ac1_312db6c009a8 =
        Namespaced_IRI.parse _namespace_name "EMMO_c413d96f_c57b_4c70_9ac1_312db6c009a8" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c4fba898_896b_4d58_a24c_b5c0851fa2a2"></see>
    /// </summary>
    let EMMO_c4fba898_896b_4d58_a24c_b5c0851fa2a2 =
        Namespaced_IRI.parse _namespace_name "EMMO_c4fba898_896b_4d58_a24c_b5c0851fa2a2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c4ffca76_fb0c_43c7_bc16_8c2430888c83"></see>
    /// </summary>
    let EMMO_c4ffca76_fb0c_43c7_bc16_8c2430888c83 =
        Namespaced_IRI.parse _namespace_name "EMMO_c4ffca76_fb0c_43c7_bc16_8c2430888c83" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c5970406_0b66_4931_8a23_3e81162ba65b"></see>
    /// </summary>
    let EMMO_c5970406_0b66_4931_8a23_3e81162ba65b =
        Namespaced_IRI.parse _namespace_name "EMMO_c5970406_0b66_4931_8a23_3e81162ba65b" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AmountPerVolumeTime'.
    /// <see href="https://w3id.org/emmo#EMMO_c5ac5c53_14de_47ce_b424_2576d042d241"></see></summary>
    let EMMO_c5ac5c53_14de_47ce_b424_2576d042d241 =
        Namespaced_IRI.parse _namespace_name "EMMO_c5ac5c53_14de_47ce_b424_2576d042d241" |> NamespacedName

    /// <summary>
    /// In condensed matter physics, position vector of an atom or ion relative to its equilibrium position.
    /// <see href="https://w3id.org/emmo#EMMO_c5fcfb08_12a9_4030_925b_14e3a0eabd07"></see></summary>
    let EMMO_c5fcfb08_12a9_4030_925b_14e3a0eabd07 =
        Namespaced_IRI.parse _namespace_name "EMMO_c5fcfb08_12a9_4030_925b_14e3a0eabd07" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c62b76d5_c1cc_432a_8c9e_7684ab054669"></see>
    /// </summary>
    let EMMO_c62b76d5_c1cc_432a_8c9e_7684ab054669 =
        Namespaced_IRI.parse _namespace_name "EMMO_c62b76d5_c1cc_432a_8c9e_7684ab054669" |> NamespacedName

    /// <summary>
    /// Relates a prefixed unit to its unit symbol part.
    /// <see href="https://w3id.org/emmo#EMMO_d4e0a0ab_2f67_4f87_a0db_b544e6dceed4"></see></summary>
    let EMMO_d4e0a0ab_2f67_4f87_a0db_b544e6dceed4 =
        Namespaced_IRI.parse _namespace_name "EMMO_d4e0a0ab_2f67_4f87_a0db_b544e6dceed4" |> NamespacedName

    /// <summary>
    /// z component of the diagonalized tensor of nuclear quadrupole moment, in the quantum state with the nuclear spin in the field direction (z).
    /// <see href="https://w3id.org/emmo#EMMO_c6da5256_df91_48f5_8653_35165fb454a0"></see></summary>
    let EMMO_c6da5256_df91_48f5_8653_35165fb454a0 =
        Namespaced_IRI.parse _namespace_name "EMMO_c6da5256_df91_48f5_8653_35165fb454a0" |> NamespacedName

    /// <summary>
    /// Ratio of the absolute value of the mutual permeance related to two circuit elements  to the geometric average of their self-permeances.
    /// <see href="https://w3id.org/emmo#EMMO_c6f8d962_2239_4a9e_a9ac_63c01b84de09"></see></summary>
    let EMMO_c6f8d962_2239_4a9e_a9ac_63c01b84de09 =
        Namespaced_IRI.parse _namespace_name "EMMO_c6f8d962_2239_4a9e_a9ac_63c01b84de09" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePerSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_c7188d13_52e6_43f7_9b6d_aba4c161fa8f"></see></summary>
    let EMMO_c7188d13_52e6_43f7_9b6d_aba4c161fa8f =
        Namespaced_IRI.parse _namespace_name "EMMO_c7188d13_52e6_43f7_9b6d_aba4c161fa8f" |> NamespacedName

    /// <summary>
    /// Voltage phasor multiplied by complex conjugate of the current phasor.
    /// <see href="https://w3id.org/emmo#EMMO_c7bc281c_0f58_431c_a66f_04be575fae7e"></see></summary>
    let EMMO_c7bc281c_0f58_431c_a66f_04be575fae7e =
        Namespaced_IRI.parse _namespace_name "EMMO_c7bc281c_0f58_431c_a66f_04be575fae7e" |> NamespacedName

    /// <summary>
    /// A tessellation in wich a tile is next for two or more non spatially connected tiles.
    /// <see href="https://w3id.org/emmo#EMMO_c7ee175d_4c25_45cb_b74e_71435b11b77d"></see></summary>
    let EMMO_c7ee175d_4c25_45cb_b74e_71435b11b77d =
        Namespaced_IRI.parse _namespace_name "EMMO_c7ee175d_4c25_45cb_b74e_71435b11b77d" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c7f4684e_ee74_4119_87e0_ecd255e10d2f"></see>
    /// </summary>
    let EMMO_c7f4684e_ee74_4119_87e0_ecd255e10d2f =
        Namespaced_IRI.parse _namespace_name "EMMO_c7f4684e_ee74_4119_87e0_ecd255e10d2f" |> NamespacedName

    /// <summary>
    /// Atom subclass for rubidium.
    /// <see href="https://w3id.org/emmo#EMMO_c828cd65-e2de-5ae2-b581-4e5d2498e493"></see></summary>
    let ``EMMO_c828cd65-e2de-5ae2-b581-4e5d2498e493`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c828cd65-e2de-5ae2-b581-4e5d2498e493" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the rubidium atom.
    /// <see href="https://w3id.org/emmo#EMMO_f9544c7c-d259-5839-b36a-61595809c538"></see></summary>
    let ``EMMO_f9544c7c-d259-5839-b36a-61595809c538`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f9544c7c-d259-5839-b36a-61595809c538" |> NamespacedName

    /// <summary>
    /// An interpreted computer language for job control in computing.
    /// <see href="https://w3id.org/emmo#EMMO_c8fe15d0_caf7_46f7_883c_0e98081987f1"></see></summary>
    let EMMO_c8fe15d0_caf7_46f7_883c_0e98081987f1 =
        Namespaced_IRI.parse _namespace_name "EMMO_c8fe15d0_caf7_46f7_883c_0e98081987f1" |> NamespacedName

    /// <summary>
    /// Vector quantity expressing the internal angular momentum of a particle or a particle system.
    /// <see href="https://w3id.org/emmo#EMMO_c91a40af_033a_48b3_baa5_6cc43aaf62aa"></see></summary>
    let EMMO_c91a40af_033a_48b3_baa5_6cc43aaf62aa =
        Namespaced_IRI.parse _namespace_name "EMMO_c91a40af_033a_48b3_baa5_6cc43aaf62aa" |> NamespacedName

    /// <summary>
    /// Ratio of shear stress to the shear strain.
    /// <see href="https://w3id.org/emmo#EMMO_c9354e77_e6c9_4a76_8571_2446bc934c94"></see></summary>
    let EMMO_c9354e77_e6c9_4a76_8571_2446bc934c94 =
        Namespaced_IRI.parse _namespace_name "EMMO_c9354e77_e6c9_4a76_8571_2446bc934c94" |> NamespacedName

    /// <summary>
    /// In nuclear physics, product of the number density of atoms of a given type and the cross section.
    /// <see href="https://w3id.org/emmo#EMMO_c949f76f_4a65_4203_9734_0f9dd778e56b"></see></summary>
    let EMMO_c949f76f_4a65_4203_9734_0f9dd778e56b =
        Namespaced_IRI.parse _namespace_name "EMMO_c949f76f_4a65_4203_9734_0f9dd778e56b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_c9a2307d_51d0_426b_ae2f_85f5a44934e0"></see>
    /// </summary>
    let EMMO_c9a2307d_51d0_426b_ae2f_85f5a44934e0 =
        Namespaced_IRI.parse _namespace_name "EMMO_c9a2307d_51d0_426b_ae2f_85f5a44934e0" |> NamespacedName

    /// <summary>
    /// In nuclear physics, incident radiant energy per cross-sectional area.
    /// <see href="https://w3id.org/emmo#EMMO_c9aa84db_e12f_4ab7_8807_0c09d5dba2cb"></see></summary>
    let EMMO_c9aa84db_e12f_4ab7_8807_0c09d5dba2cb =
        Namespaced_IRI.parse _namespace_name "EMMO_c9aa84db_e12f_4ab7_8807_0c09d5dba2cb" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the hafnium atom.
    /// <see href="https://w3id.org/emmo#EMMO_c9ac19ce-af4f-5abd-975d-c86dca0b4d58"></see></summary>
    let ``EMMO_c9ac19ce-af4f-5abd-975d-c86dca0b4d58`` =
        Namespaced_IRI.parse _namespace_name "EMMO_c9ac19ce-af4f-5abd-975d-c86dca0b4d58" |> NamespacedName

    /// <summary>
    /// Atom subclass for nickel.
    /// <see href="https://w3id.org/emmo#EMMO_caacc634-4328-5d9d-a8e8-1c25a2557e94"></see></summary>
    let ``EMMO_caacc634-4328-5d9d-a8e8-1c25a2557e94`` =
        Namespaced_IRI.parse _namespace_name "EMMO_caacc634-4328-5d9d-a8e8-1c25a2557e94" |> NamespacedName

    /// <summary>
    /// Atom subclass for palladium.
    /// <see href="https://w3id.org/emmo#EMMO_cabcb18d-88ff-5ff7-aceb-ab573526620e"></see></summary>
    let ``EMMO_cabcb18d-88ff-5ff7-aceb-ab573526620e`` =
        Namespaced_IRI.parse _namespace_name "EMMO_cabcb18d-88ff-5ff7-aceb-ab573526620e" |> NamespacedName

    /// <summary>
    /// Quantity of dimension 1 equal to u/(1 + u), where u is mass ratio of water to dry matter.
    /// <see href="https://w3id.org/emmo#EMMO_cac16ce6_2cef_405d_ac63_0f918db4875e"></see></summary>
    let EMMO_cac16ce6_2cef_405d_ac63_0f918db4875e =
        Namespaced_IRI.parse _namespace_name "EMMO_cac16ce6_2cef_405d_ac63_0f918db4875e" |> NamespacedName

    /// <summary>
    /// In an infinite medium, the ratio of the mean number of neutrons produced by fission due to neutrons of all energies to the mean number of neutrons produced by fissions due to thermal neutrons only.
    /// <see href="https://w3id.org/emmo#EMMO_cb62c651_f41a_4e12_a374_a3da3db1d2ff"></see></summary>
    let EMMO_cb62c651_f41a_4e12_a374_a3da3db1d2ff =
        Namespaced_IRI.parse _namespace_name "EMMO_cb62c651_f41a_4e12_a374_a3da3db1d2ff" |> NamespacedName

    /// <summary>
    /// Product of the number density na of the atoms and the cross section σ_tot for a given type of atoms.
    /// <see href="https://w3id.org/emmo#EMMO_cb71d1cb_0d62_4de7_a628_bc8e14acfe05"></see></summary>
    let EMMO_cb71d1cb_0d62_4de7_a628_bc8e14acfe05 =
        Namespaced_IRI.parse _namespace_name "EMMO_cb71d1cb_0d62_4de7_a628_bc8e14acfe05" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ForceArea'.
    /// <see href="https://w3id.org/emmo#EMMO_cb77e107_43ed_4a97_bf39_03b3587404d3"></see></summary>
    let EMMO_cb77e107_43ed_4a97_bf39_03b3587404d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_cb77e107_43ed_4a97_bf39_03b3587404d3" |> NamespacedName

    /// <summary>
    /// For substance B, an integer number or a simple fraction, being negative for a reactant and positive for a product, occurring in the expression for a chemical reaction.
    /// <see href="https://w3id.org/emmo#EMMO_cbba91a7_d639_461f_ae23_d021751029e4"></see></summary>
    let EMMO_cbba91a7_d639_461f_ae23_d021751029e4 =
        Namespaced_IRI.parse _namespace_name "EMMO_cbba91a7_d639_461f_ae23_d021751029e4" |> NamespacedName

    /// <summary>
    /// The negative of ElementaryCharge.
    /// The charge of an electron.
    /// <see href="https://w3id.org/emmo#EMMO_cc01751d_dd05_429b_9d0c_1b7a74d1f277"></see></summary>
    let EMMO_cc01751d_dd05_429b_9d0c_1b7a74d1f277 =
        Namespaced_IRI.parse _namespace_name "EMMO_cc01751d_dd05_429b_9d0c_1b7a74d1f277" |> NamespacedName

    /// <summary>
    /// A semiotic relation connecting a conventional sign to the interpreter (declarer) in a declaration process.
    /// <see href="https://w3id.org/emmo#EMMO_cc823237_398d_4c9a_b8fa_aa157ee3e3a5"></see></summary>
    let EMMO_cc823237_398d_4c9a_b8fa_aa157ee3e3a5 =
        Namespaced_IRI.parse _namespace_name "EMMO_cc823237_398d_4c9a_b8fa_aa157ee3e3a5" |> NamespacedName

    /// <summary>
    /// Quotient of the total number of fission or fission-dependent neutrons produced in the duration of a time interval and the total number of neutrons lost by absorption and leakage in that duration.
    /// <see href="https://w3id.org/emmo#EMMO_ccb1ccaa_c8bd_47a4_b572_ca809325ac68"></see></summary>
    let EMMO_ccb1ccaa_c8bd_47a4_b572_ca809325ac68 =
        Namespaced_IRI.parse _namespace_name "EMMO_ccb1ccaa_c8bd_47a4_b572_ca809325ac68" |> NamespacedName

    /// <summary>
    /// Entropy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_cdc5a859_de8d_401a_b2fd_6bed90aad310"></see></summary>
    let EMMO_cdc5a859_de8d_401a_b2fd_6bed90aad310 =
        Namespaced_IRI.parse _namespace_name "EMMO_cdc5a859_de8d_401a_b2fd_6bed90aad310" |> NamespacedName

    /// <summary>
    /// Conductivity is equeal to the resiprocal of resistivity.
    /// Measure of a material's ability to conduct an electric current.
    /// <see href="https://w3id.org/emmo#EMMO_cde4368c_1d4d_4c94_8548_604749523c6d"></see></summary>
    let EMMO_cde4368c_1d4d_4c94_8548_604749523c6d =
        Namespaced_IRI.parse _namespace_name "EMMO_cde4368c_1d4d_4c94_8548_604749523c6d" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'AreaTemperature'.
    /// <see href="https://w3id.org/emmo#EMMO_ceaa4c6b_f5b7_46f4_bfcd_16eb4afab945"></see></summary>
    let EMMO_ceaa4c6b_f5b7_46f4_bfcd_16eb4afab945 =
        Namespaced_IRI.parse _namespace_name "EMMO_ceaa4c6b_f5b7_46f4_bfcd_16eb4afab945" |> NamespacedName

    /// <summary>
    /// An object which is an holistic spatial part of a object.
    /// <see href="https://w3id.org/emmo#EMMO_ceaaf9f7_fd11_424b_8fda_9afa186af186"></see></summary>
    let EMMO_ceaaf9f7_fd11_424b_8fda_9afa186af186 =
        Namespaced_IRI.parse _namespace_name "EMMO_ceaaf9f7_fd11_424b_8fda_9afa186af186" |> NamespacedName

    /// <summary>
    /// A data representing an integer number &lt;= 0.
    /// <see href="https://w3id.org/emmo#EMMO_cf0f8f57_8a9e_410c_8fe4_a436673fa3d3"></see></summary>
    let EMMO_cf0f8f57_8a9e_410c_8fe4_a436673fa3d3 =
        Namespaced_IRI.parse _namespace_name "EMMO_cf0f8f57_8a9e_410c_8fe4_a436673fa3d3" |> NamespacedName

    /// <summary>
    /// Factor taking into account health effects in the determination of the dose equivalent.
    /// <see href="https://w3id.org/emmo#EMMO_cff5ef70_96eb_4ea3_9bea_fe1fbe6177be"></see></summary>
    let EMMO_cff5ef70_96eb_4ea3_9bea_fe1fbe6177be =
        Namespaced_IRI.parse _namespace_name "EMMO_cff5ef70_96eb_4ea3_9bea_fe1fbe6177be" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ThermalResistance'.
    /// <see href="https://w3id.org/emmo#EMMO_cff9f930_f3f7_43c6_9228_28bf3e1ec706"></see></summary>
    let EMMO_cff9f930_f3f7_43c6_9228_28bf3e1ec706 =
        Namespaced_IRI.parse _namespace_name "EMMO_cff9f930_f3f7_43c6_9228_28bf3e1ec706" |> NamespacedName

    /// <summary>
    /// Atom subclass for oganesson.
    /// <see href="https://w3id.org/emmo#EMMO_cffec057-9258-52ae-bb4c-ca761b6bc407"></see></summary>
    let ``EMMO_cffec057-9258-52ae-bb4c-ca761b6bc407`` =
        Namespaced_IRI.parse _namespace_name "EMMO_cffec057-9258-52ae-bb4c-ca761b6bc407" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the oganesson atom.
    /// <see href="https://w3id.org/emmo#EMMO_e5d7bd48-4098-59b6-b872-8bba421157eb"></see></summary>
    let ``EMMO_e5d7bd48-4098-59b6-b872-8bba421157eb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e5d7bd48-4098-59b6-b872-8bba421157eb" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d02f6f3e_9e32_4188_a116_29dc304ceb49"></see>
    /// </summary>
    let EMMO_d02f6f3e_9e32_4188_a116_29dc304ceb49 =
        Namespaced_IRI.parse _namespace_name "EMMO_d02f6f3e_9e32_4188_a116_29dc304ceb49" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the radon atom.
    /// <see href="https://w3id.org/emmo#EMMO_d0af02f3-8a47-554e-a725-42b752451a1b"></see></summary>
    let ``EMMO_d0af02f3-8a47-554e-a725-42b752451a1b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_d0af02f3-8a47-554e-a725-42b752451a1b" |> NamespacedName

    /// <summary>
    /// A standalone simulation, where a single physics equation is solved.
    /// <see href="https://w3id.org/emmo#EMMO_d0bcf2ca_cd55_4f34_8fc2_2decc4c6087a"></see></summary>
    let EMMO_d0bcf2ca_cd55_4f34_8fc2_2decc4c6087a =
        Namespaced_IRI.parse _namespace_name "EMMO_d0bcf2ca_cd55_4f34_8fc2_2decc4c6087a" |> NamespacedName

    /// <summary>
    /// Measure of the internal forces that neighboring particles of a continuous material exert on each other.
    /// Force per unit oriented surface area .
    /// <see href="https://w3id.org/emmo#EMMO_d1917609_db5e_4b8a_9b76_ef1d6f860a81"></see></summary>
    let EMMO_d1917609_db5e_4b8a_9b76_ef1d6f860a81 =
        Namespaced_IRI.parse _namespace_name "EMMO_d1917609_db5e_4b8a_9b76_ef1d6f860a81" |> NamespacedName

    /// <summary>
    /// A variable whose value is assumed to be known independently from the equation, but whose value is not explicitated in the equation.
    /// <see href="https://w3id.org/emmo#EMMO_d1d436e7_72fc_49cd_863b_7bfb4ba5276a"></see></summary>
    let EMMO_d1d436e7_72fc_49cd_863b_7bfb4ba5276a =
        Namespaced_IRI.parse _namespace_name "EMMO_d1d436e7_72fc_49cd_863b_7bfb4ba5276a" |> NamespacedName

    /// <summary>
    /// Quotient of mass defect and the unified atomic mass constant.
    /// <see href="https://w3id.org/emmo#EMMO_d26859bb_bb6e_47bb_b46e_c2253414808e"></see></summary>
    let EMMO_d26859bb_bb6e_47bb_b46e_c2253414808e =
        Namespaced_IRI.parse _namespace_name "EMMO_d26859bb_bb6e_47bb_b46e_c2253414808e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d271f202_4c1a_4d74_b86a_387c82034eb7"></see>
    /// </summary>
    let EMMO_d271f202_4c1a_4d74_b86a_387c82034eb7 =
        Namespaced_IRI.parse _namespace_name "EMMO_d271f202_4c1a_4d74_b86a_387c82034eb7" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'InversePermittivity'.
    /// <see href="https://w3id.org/emmo#EMMO_d2a20142_b3a4_4d3b_a7e1_e17597e7f177"></see></summary>
    let EMMO_d2a20142_b3a4_4d3b_a7e1_e17597e7f177 =
        Namespaced_IRI.parse _namespace_name "EMMO_d2a20142_b3a4_4d3b_a7e1_e17597e7f177" |> NamespacedName

    /// <summary>
    /// Chemical Abstact Service registry number for a chemical substance from the American Chemical Society
    /// <see href="https://w3id.org/emmo#EMMO_d2a47cd8_662f_438f_855a_b4378eb992ff"></see></summary>
    let EMMO_d2a47cd8_662f_438f_855a_b4378eb992ff =
        Namespaced_IRI.parse _namespace_name "EMMO_d2a47cd8_662f_438f_855a_b4378eb992ff" |> NamespacedName

    /// <summary>
    /// Atom subclass for berkelium.
    /// <see href="https://w3id.org/emmo#EMMO_d2a4df79-23a0-5536-9f12-37d3b49c323f"></see></summary>
    let ``EMMO_d2a4df79-23a0-5536-9f12-37d3b49c323f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_d2a4df79-23a0-5536-9f12-37d3b49c323f" |> NamespacedName

    /// <summary>
    /// Absolute value of the electric charge of ions produced in dry air by X- or gamma radiation per mass of air.
    /// <see href="https://w3id.org/emmo#EMMO_d2b37868_7b74_469b_ae26_0a7153c23222"></see></summary>
    let EMMO_d2b37868_7b74_469b_ae26_0a7153c23222 =
        Namespaced_IRI.parse _namespace_name "EMMO_d2b37868_7b74_469b_ae26_0a7153c23222" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d320f878_2be4_4927_aea6_d36a2ae2dd89"></see>
    /// </summary>
    let EMMO_d320f878_2be4_4927_aea6_d36a2ae2dd89 =
        Namespaced_IRI.parse _namespace_name "EMMO_d320f878_2be4_4927_aea6_d36a2ae2dd89" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d357e0dd_3497_4590_af6f_7954db7fecf7"></see>
    /// </summary>
    let EMMO_d357e0dd_3497_4590_af6f_7954db7fecf7 =
        Namespaced_IRI.parse _namespace_name "EMMO_d357e0dd_3497_4590_af6f_7954db7fecf7" |> NamespacedName

    /// <summary>
    /// Maximum kinetic energy of the emitted beta particle produced in the nuclear disintegration process.
    /// <see href="https://w3id.org/emmo#EMMO_d364e5e0_9652_4295_8f85_bd1297497377"></see></summary>
    let EMMO_d364e5e0_9652_4295_8f85_bd1297497377 =
        Namespaced_IRI.parse _namespace_name "EMMO_d364e5e0_9652_4295_8f85_bd1297497377" |> NamespacedName

    /// <summary>
    /// Property of a solute in a solution.
    /// <see href="https://w3id.org/emmo#EMMO_d368744e_bb2e_4d40_a7ef_762505b6027e"></see></summary>
    let EMMO_d368744e_bb2e_4d40_a7ef_762505b6027e =
        Namespaced_IRI.parse _namespace_name "EMMO_d368744e_bb2e_4d40_a7ef_762505b6027e" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d3eecd54_e9bf_4c6f_bef8_6086cb9aa7b5"></see>
    /// </summary>
    let EMMO_d3eecd54_e9bf_4c6f_bef8_6086cb9aa7b5 =
        Namespaced_IRI.parse _namespace_name "EMMO_d3eecd54_e9bf_4c6f_bef8_6086cb9aa7b5" |> NamespacedName

    /// <summary>
    /// Average number of fission neutrons, both prompt and delayed, emitted per neutron absorbed in a fissionable nuclide or in a nuclear fuel, as specified.
    /// <see href="https://w3id.org/emmo#EMMO_d3fce82a_4acb_40f9_bbcf_9b123dbe84af"></see></summary>
    let EMMO_d3fce82a_4acb_40f9_bbcf_9b123dbe84af =
        Namespaced_IRI.parse _namespace_name "EMMO_d3fce82a_4acb_40f9_bbcf_9b123dbe84af" |> NamespacedName

    /// <summary>
    /// A data representing an arbritrary precision decimal number.
    /// <see href="https://w3id.org/emmo#EMMO_d43546df_7fd7_44d5_9d7c_0f2bf56cefe3"></see></summary>
    let EMMO_d43546df_7fd7_44d5_9d7c_0f2bf56cefe3 =
        Namespaced_IRI.parse _namespace_name "EMMO_d43546df_7fd7_44d5_9d7c_0f2bf56cefe3" |> NamespacedName

    /// <summary>
    /// The relation between a process and one of its process parts.
    /// <see href="https://w3id.org/emmo#EMMO_d43af210_f854_4432_a891_ce3022e3b558"></see></summary>
    let EMMO_d43af210_f854_4432_a891_ce3022e3b558 =
        Namespaced_IRI.parse _namespace_name "EMMO_d43af210_f854_4432_a891_ce3022e3b558" |> NamespacedName

    /// <summary>
    /// Time derivative of kerma.
    /// <see href="https://w3id.org/emmo#EMMO_d481815b_11bd_4cf6_a290_941062ee76ef"></see></summary>
    let EMMO_d481815b_11bd_4cf6_a290_941062ee76ef =
        Namespaced_IRI.parse _namespace_name "EMMO_d481815b_11bd_4cf6_a290_941062ee76ef" |> NamespacedName

    /// <summary>
    /// Inverse of the radius of curvature.
    /// <see href="https://w3id.org/emmo#EMMO_d4deccf7_8cbf_4766_bf3d_57db491fa637"></see></summary>
    let EMMO_d4deccf7_8cbf_4766_bf3d_57db491fa637 =
        Namespaced_IRI.parse _namespace_name "EMMO_d4deccf7_8cbf_4766_bf3d_57db491fa637" |> NamespacedName

    /// <summary>
    /// Quotient of the Planck constant and the product of the mass of the particle and the speed of light in vacuum.
    /// <see href="https://w3id.org/emmo#EMMO_d5888438_b092_4057_b8df_966cf6034fb2"></see></summary>
    let EMMO_d5888438_b092_4057_b8df_966cf6034fb2 =
        Namespaced_IRI.parse _namespace_name "EMMO_d5888438_b092_4057_b8df_966cf6034fb2" |> NamespacedName

    /// <summary>
    /// A estimation of a property by a criteria based on the pre-existing knowledge of the estimator.
    /// <see href="https://w3id.org/emmo#EMMO_d5adc819_d4b2_4661_b429_1705b75d5053"></see></summary>
    let EMMO_d5adc819_d4b2_4661_b429_1705b75d5053 =
        Namespaced_IRI.parse _namespace_name "EMMO_d5adc819_d4b2_4661_b429_1705b75d5053" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricCurrentPerAmountVolume'.
    /// <see href="https://w3id.org/emmo#EMMO_d5b6a25a_408a_408d_aebc_e017260d885d"></see></summary>
    let EMMO_d5b6a25a_408a_408d_aebc_e017260d885d =
        Namespaced_IRI.parse _namespace_name "EMMO_d5b6a25a_408a_408d_aebc_e017260d885d" |> NamespacedName

    /// <summary>
    /// A manufacturing process in which interchangeable parts are added to a product in a sequential manner to create an end product.
    /// Is not collection, since the connection between the elements of an assembly line occurs through the flow of objects that are processed.
    /// <see href="https://w3id.org/emmo#EMMO_d64920b5_acd0_4e29_893e_ae03b3d7cdaf"></see></summary>
    let EMMO_d64920b5_acd0_4e29_893e_ae03b3d7cdaf =
        Namespaced_IRI.parse _namespace_name "EMMO_d64920b5_acd0_4e29_893e_ae03b3d7cdaf" |> NamespacedName

    /// <summary>
    /// Mean total rectified path length travelled by a particle in the course of slowing down to rest in a given material averaged over a group of particles having the same initial energy.
    /// <see href="https://w3id.org/emmo#EMMO_d64a491b_d160_4adf_bba1_1a3f0624f0ea"></see></summary>
    let EMMO_d64a491b_d160_4adf_bba1_1a3f0624f0ea =
        Namespaced_IRI.parse _namespace_name "EMMO_d64a491b_d160_4adf_bba1_1a3f0624f0ea" |> NamespacedName

    /// <summary>
    /// A foam of trapped gas in a liquid.
    /// <see href="https://w3id.org/emmo#EMMO_d69d2e95_b22f_499a_a552_17fde0d778fc"></see></summary>
    let EMMO_d69d2e95_b22f_499a_a552_17fde0d778fc =
        Namespaced_IRI.parse _namespace_name "EMMO_d69d2e95_b22f_499a_a552_17fde0d778fc" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_d700aed9_2eb9_4e26_ba30_81cc36157fb1"></see>
    /// </summary>
    let EMMO_d700aed9_2eb9_4e26_ba30_81cc36157fb1 =
        Namespaced_IRI.parse _namespace_name "EMMO_d700aed9_2eb9_4e26_ba30_81cc36157fb1" |> NamespacedName

    /// <summary>
    /// Mass per length.
    /// <see href="https://w3id.org/emmo#EMMO_d722016a_4907_497b_b0d3_cfd10adfef26"></see></summary>
    let EMMO_d722016a_4907_497b_b0d3_cfd10adfef26 =
        Namespaced_IRI.parse _namespace_name "EMMO_d722016a_4907_497b_b0d3_cfd10adfef26" |> NamespacedName

    /// <summary>
    /// The International Chemical Identifier (InChI) textual identifier proposed by IUPAC to provide a standard encoding for databases of molecular information.
    /// <see href="https://w3id.org/emmo#EMMO_d74ed682_894f_46c5_87cb_167f60926965"></see></summary>
    let EMMO_d74ed682_894f_46c5_87cb_167f60926965 =
        Namespaced_IRI.parse _namespace_name "EMMO_d74ed682_894f_46c5_87cb_167f60926965" |> NamespacedName

    /// <summary>
    /// A standard 2-manifold with no unconnected boundaries.
    /// <see href="https://w3id.org/emmo#EMMO_d7bf784a_db94_4dd9_861c_54f262846fbf"></see></summary>
    let EMMO_d7bf784a_db94_4dd9_861c_54f262846fbf =
        Namespaced_IRI.parse _namespace_name "EMMO_d7bf784a_db94_4dd9_861c_54f262846fbf" |> NamespacedName

    /// <summary>
    /// Atom subclass for potassium.
    /// <see href="https://w3id.org/emmo#EMMO_d7c9e90e-ba46-55b2-9671-43408f6a1d74"></see></summary>
    let ``EMMO_d7c9e90e-ba46-55b2-9671-43408f6a1d74`` =
        Namespaced_IRI.parse _namespace_name "EMMO_d7c9e90e-ba46-55b2-9671-43408f6a1d74" |> NamespacedName

    /// <summary>
    /// A fundamental physical constant characterizing the strength of the electromagnetic interaction between elementary charged particles.
    /// <see href="https://w3id.org/emmo#EMMO_d7d2ca25_03e1_4099_9220_c1a58df13ad0"></see></summary>
    let EMMO_d7d2ca25_03e1_4099_9220_c1a58df13ad0 =
        Namespaced_IRI.parse _namespace_name "EMMO_d7d2ca25_03e1_4099_9220_c1a58df13ad0" |> NamespacedName

    /// <summary>
    /// Thermodynamic temperature difference divided by heat flow rate.
    /// The name “thermal resistance” and the symbol R are used in building technology to designate thermal insulance.
    /// <see href="https://w3id.org/emmo#EMMO_d7efc862_981f_4909_925b_700cd93070fc"></see></summary>
    let EMMO_d7efc862_981f_4909_925b_700cd93070fc =
        Namespaced_IRI.parse _namespace_name "EMMO_d7efc862_981f_4909_925b_700cd93070fc" |> NamespacedName

    /// <summary>
    /// Imaginary part of the complex power.
    /// <see href="https://w3id.org/emmo#EMMO_d8030875_6d89_4645_9728_bbc3b8690609"></see></summary>
    let EMMO_d8030875_6d89_4645_9728_bbc3b8690609 =
        Namespaced_IRI.parse _namespace_name "EMMO_d8030875_6d89_4645_9728_bbc3b8690609" |> NamespacedName

    /// <summary>
    /// Relates a SI prefixed unit to the prefix symbol.
    /// <see href="https://w3id.org/emmo#EMMO_d85162ec_6d62_4cdb_a5b9_f092285e5b7f"></see></summary>
    let EMMO_d85162ec_6d62_4cdb_a5b9_f092285e5b7f =
        Namespaced_IRI.parse _namespace_name "EMMO_d85162ec_6d62_4cdb_a5b9_f092285e5b7f" |> NamespacedName

    /// <summary>
    /// Sum over quantum states of energy in a system in equilibrium.
    /// In physics, a partition function describes the statistical properties of a system in thermodynamic equilibrium. Partition functions are functions of the thermodynamic state variables, such as the temperature and volume. Most of the aggregate thermodynamic variables of the system, such as the total energy, free energy, entropy, and pressure, can be expressed in terms of the partition function or its derivatives. The partition function is dimensionless.
    /// <see href="https://w3id.org/emmo#EMMO_d8612fa0_c0fb_485d_b45a_1845e7a46796"></see></summary>
    let EMMO_d8612fa0_c0fb_485d_b45a_1845e7a46796 =
        Namespaced_IRI.parse _namespace_name "EMMO_d8612fa0_c0fb_485d_b45a_1845e7a46796" |> NamespacedName

    /// <summary>
    /// Faction of electrical current carried by given ionic species.
    /// <see href="https://w3id.org/emmo#EMMO_d97b27cb_61a4_4568_a38b_4edd4f224acc"></see></summary>
    let EMMO_d97b27cb_61a4_4568_a38b_4edd4f224acc =
        Namespaced_IRI.parse _namespace_name "EMMO_d97b27cb_61a4_4568_a38b_4edd4f224acc" |> NamespacedName

    /// <summary>
    /// Vector characterising a dislocation in a crystal lattice.
    /// <see href="https://w3id.org/emmo#EMMO_da4ea7e3_6e60_410b_a209_6ea735a6b10c"></see></summary>
    let EMMO_da4ea7e3_6e60_410b_a209_6ea735a6b10c =
        Namespaced_IRI.parse _namespace_name "EMMO_da4ea7e3_6e60_410b_a209_6ea735a6b10c" |> NamespacedName

    /// <summary>
    /// Physical constant in Newton's law of gravitation and in Einstein's general theory of relativity.
    /// <see href="https://w3id.org/emmo#EMMO_da831168_975a_41f8_baae_279c298569da"></see></summary>
    let EMMO_da831168_975a_41f8_baae_279c298569da =
        Namespaced_IRI.parse _namespace_name "EMMO_da831168_975a_41f8_baae_279c298569da" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_dabe353b_8bfc_4da7_8ac7_8f52786d16f8"></see>
    /// </summary>
    let EMMO_dabe353b_8bfc_4da7_8ac7_8f52786d16f8 =
        Namespaced_IRI.parse _namespace_name "EMMO_dabe353b_8bfc_4da7_8ac7_8f52786d16f8" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareTemperaturePerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_dafdcae3_f8ec_4993_8269_2c9299a75158"></see></summary>
    let EMMO_dafdcae3_f8ec_4993_8269_2c9299a75158 =
        Namespaced_IRI.parse _namespace_name "EMMO_dafdcae3_f8ec_4993_8269_2c9299a75158" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_dbe39465_6cf4_4592_b0c5_b7446789a37b"></see>
    /// </summary>
    let EMMO_dbe39465_6cf4_4592_b0c5_b7446789a37b =
        Namespaced_IRI.parse _namespace_name "EMMO_dbe39465_6cf4_4592_b0c5_b7446789a37b" |> NamespacedName

    /// <summary>
    /// Atom subclass for tantalum.
    /// <see href="https://w3id.org/emmo#EMMO_dbe54798-a21f-519f-9d52-e6ab2c2e28cb"></see></summary>
    let ``EMMO_dbe54798-a21f-519f-9d52-e6ab2c2e28cb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_dbe54798-a21f-519f-9d52-e6ab2c2e28cb" |> NamespacedName

    /// <summary>
    /// Describes the effect that changing the volume of a crystal lattice has on its vibrational properties, and, as a consequence, the effect that changing temperature has on the size or dynamics of the lattice.
    /// <see href="https://w3id.org/emmo#EMMO_dc1370b5_3902_4652_8736_0804d88dd128"></see></summary>
    let EMMO_dc1370b5_3902_4652_8736_0804d88dd128 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc1370b5_3902_4652_8736_0804d88dd128" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_dc3a6b2d_e31d_491a_ab40_c433f8dd8d48"></see>
    /// </summary>
    let EMMO_dc3a6b2d_e31d_491a_ab40_c433f8dd8d48 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc3a6b2d_e31d_491a_ab40_c433f8dd8d48" |> NamespacedName

    /// <summary>
    /// Number of nucleons in an atomic nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_dc6c8de0_cfc4_4c66_a7dc_8f720e732d54"></see></summary>
    let EMMO_dc6c8de0_cfc4_4c66_a7dc_8f720e732d54 =
        Namespaced_IRI.parse _namespace_name "EMMO_dc6c8de0_cfc4_4c66_a7dc_8f720e732d54" |> NamespacedName

    /// <summary>
    /// A data representing 16-bit non-negative integer number, 0...65535.
    /// <see href="https://w3id.org/emmo#EMMO_dc6e40f6_5b6c_473b_a715_d36622ada5ad"></see></summary>
    let EMMO_dc6e40f6_5b6c_473b_a715_d36622ada5ad =
        Namespaced_IRI.parse _namespace_name "EMMO_dc6e40f6_5b6c_473b_a715_d36622ada5ad" |> NamespacedName

    /// <summary>
    /// Conventional radius of sphere in which the nuclear matter is included,
    /// <see href="https://w3id.org/emmo#EMMO_dd48bd88_9855_4da9_9297_41ae8a3c41fc"></see></summary>
    let EMMO_dd48bd88_9855_4da9_9297_41ae8a3c41fc =
        Namespaced_IRI.parse _namespace_name "EMMO_dd48bd88_9855_4da9_9297_41ae8a3c41fc" |> NamespacedName

    /// <summary>
    /// Quotient of the initial kinetic energy Ek of an ionizing charged particle and the total ionization Ni produced by that particle.
    /// <see href="https://w3id.org/emmo#EMMO_dd92c2ae_3ca4_49bc_9147_d82b96f7505e"></see></summary>
    let EMMO_dd92c2ae_3ca4_49bc_9147_d82b96f7505e =
        Namespaced_IRI.parse _namespace_name "EMMO_dd92c2ae_3ca4_49bc_9147_d82b96f7505e" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'MassPerSquareLengthSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_ddcc1e64_69cc_4a0c_9ee8_08aca78b3c85"></see></summary>
    let EMMO_ddcc1e64_69cc_4a0c_9ee8_08aca78b3c85 =
        Namespaced_IRI.parse _namespace_name "EMMO_ddcc1e64_69cc_4a0c_9ee8_08aca78b3c85" |> NamespacedName

    /// <summary>
    /// A workflow whose steps (iterative steps) are the repetition of the same workflow type.
    /// <see href="https://w3id.org/emmo#EMMO_ddecfff6_d3a1_4972_b9e9_3d0ca11a3a0b"></see></summary>
    let EMMO_ddecfff6_d3a1_4972_b9e9_3d0ca11a3a0b =
        Namespaced_IRI.parse _namespace_name "EMMO_ddecfff6_d3a1_4972_b9e9_3d0ca11a3a0b" |> NamespacedName

    /// <summary>
    /// The DBpedia and UIPAC Gold Book definitions (http://dbpedia.org/page/Vacuum_permeability,  https://doi.org/10.1351/goldbook.P04504) are outdated since May 20, 2019. It is now a measured constant.
    /// The value of magnetic permeability in a classical vacuum.
    /// <see href="https://w3id.org/emmo#EMMO_de021e4f_918f_47ef_a67b_11120f56b9d7"></see></summary>
    let EMMO_de021e4f_918f_47ef_a67b_11120f56b9d7 =
        Namespaced_IRI.parse _namespace_name "EMMO_de021e4f_918f_47ef_a67b_11120f56b9d7" |> NamespacedName

    /// <summary>
    /// Vector quantity in a quantum system composed of the vectorial sum of angular momentum L and spin s.
    /// <see href="https://w3id.org/emmo#EMMO_de649cb1_7ec0_4a2e_ad55_d84e4ccd88b0"></see></summary>
    let EMMO_de649cb1_7ec0_4a2e_ad55_d84e4ccd88b0 =
        Namespaced_IRI.parse _namespace_name "EMMO_de649cb1_7ec0_4a2e_ad55_d84e4ccd88b0" |> NamespacedName

    /// <summary>
    /// Atom subclass for sodium.
    /// <see href="https://w3id.org/emmo#EMMO_dea931ca-1ec7-58f8-88e5-fb5615d8b214"></see></summary>
    let ``EMMO_dea931ca-1ec7-58f8-88e5-fb5615d8b214`` =
        Namespaced_IRI.parse _namespace_name "EMMO_dea931ca-1ec7-58f8-88e5-fb5615d8b214" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'EnergyPerSquareMagneticFluxDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_df1d3a25_eba2_4530_9803_d82d349f4051"></see></summary>
    let EMMO_df1d3a25_eba2_4530_9803_d82d349f4051 =
        Namespaced_IRI.parse _namespace_name "EMMO_df1d3a25_eba2_4530_9803_d82d349f4051" |> NamespacedName

    /// <summary>
    /// Quotient of the mass of water vapour in moist gas by the total gas volume.
    /// The mass concentration of water at saturation is denoted vsat.
    /// <see href="https://w3id.org/emmo#EMMO_df8b283c_c02a_4158_b65e_60de7bb0b550"></see></summary>
    let EMMO_df8b283c_c02a_4158_b65e_60de7bb0b550 =
        Namespaced_IRI.parse _namespace_name "EMMO_df8b283c_c02a_4158_b65e_60de7bb0b550" |> NamespacedName

    /// <summary>
    /// Quotient of Peltier heat power developed at a junction, and the electric current flowing from substance a to substance b.
    /// <see href="https://w3id.org/emmo#EMMO_dfcff795_0fe9_4eb7_8f8f_879bb50939c9"></see></summary>
    let EMMO_dfcff795_0fe9_4eb7_8f8f_879bb50939c9 =
        Namespaced_IRI.parse _namespace_name "EMMO_dfcff795_0fe9_4eb7_8f8f_879bb50939c9" |> NamespacedName

    /// <summary>
    /// Quotient of the traversed circular path length of a point in space during a rotation and its distance from the axis or centre of rotation.
    /// <see href="https://w3id.org/emmo#EMMO_dfd22e00_993b_40cc_a4ad_1134c1e3007a"></see></summary>
    let EMMO_dfd22e00_993b_40cc_a4ad_1134c1e3007a =
        Namespaced_IRI.parse _namespace_name "EMMO_dfd22e00_993b_40cc_a4ad_1134c1e3007a" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the holmium atom.
    /// <see href="https://w3id.org/emmo#EMMO_e0136ad7-1435-5292-9ed6-9848b481d503"></see></summary>
    let ``EMMO_e0136ad7-1435-5292-9ed6-9848b481d503`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e0136ad7-1435-5292-9ed6-9848b481d503" |> NamespacedName

    /// <summary>
    /// The persistence perspective classifies entities according to the persistence of temporal parts of specifc type, introducing the distiction between objects (when a type is conserved through all its time parts) or processes (where a type is not conserved through all its time parts).
    /// This perspective provides classes aimed to represent concepts similar to the ones of endurant and perdurant (a.k.a. continuant and occurrent). However, in the EMMO case, an entity is defined as an object or a process according to a specific type, and not per-se. For this reason an entity in the EMMO can be classified both object or a process depending on the reference type, due to the underlying 4D framework (e.g. an individual may belong both to the class of runners and the class of running process), and the distinction is purely representational.
    /// This categorisation has been introduced due to the large use of object/process commonsensical concepts, and the fact that our language distinguish between nouns and verbs to address things, forcing the separation between things that happens and things that persist.
    /// The union of the object or process classes.
    /// <see href="https://w3id.org/emmo#EMMO_e04884d9_eda6_487e_93d5_7722d7eda96b"></see></summary>
    let EMMO_e04884d9_eda6_487e_93d5_7722d7eda96b =
        Namespaced_IRI.parse _namespace_name "EMMO_e04884d9_eda6_487e_93d5_7722d7eda96b" |> NamespacedName

    /// <summary>
    /// Reciprocal of the wavelength.
    /// <see href="https://w3id.org/emmo#EMMO_e0aaed83_9224_4bd8_a960_a813c4569412"></see></summary>
    let EMMO_e0aaed83_9224_4bd8_a960_a813c4569412 =
        Namespaced_IRI.parse _namespace_name "EMMO_e0aaed83_9224_4bd8_a960_a813c4569412" |> NamespacedName

    /// <summary>
    /// Inverse of the reluctance.
    /// <see href="https://w3id.org/emmo#EMMO_e0feea8c_318e_4dcf_92f0_751e228ed99d"></see></summary>
    let EMMO_e0feea8c_318e_4dcf_92f0_751e228ed99d =
        Namespaced_IRI.parse _namespace_name "EMMO_e0feea8c_318e_4dcf_92f0_751e228ed99d" |> NamespacedName

    /// <summary>
    /// A unicode character encoded with UTF-8.
    /// <see href="https://w3id.org/emmo#EMMO_e13b2173_1dec_4b97_9ac1_1dc4b418612a"></see></summary>
    let EMMO_e13b2173_1dec_4b97_9ac1_1dc4b418612a =
        Namespaced_IRI.parse _namespace_name "EMMO_e13b2173_1dec_4b97_9ac1_1dc4b418612a" |> NamespacedName

    /// <summary>
    /// Gibbs energy per unit mass.
    /// <see href="https://w3id.org/emmo#EMMO_e16033b0_cb72_4d02_84fa_4df7f54a9c4e"></see></summary>
    let EMMO_e16033b0_cb72_4d02_84fa_4df7f54a9c4e =
        Namespaced_IRI.parse _namespace_name "EMMO_e16033b0_cb72_4d02_84fa_4df7f54a9c4e" |> NamespacedName

    /// <summary>
    /// Atom subclass for dysprosium.
    /// <see href="https://w3id.org/emmo#EMMO_e1e686a5-71c3-5a98-8646-6d4e0f665f35"></see></summary>
    let ``EMMO_e1e686a5-71c3-5a98-8646-6d4e0f665f35`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e1e686a5-71c3-5a98-8646-6d4e0f665f35" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e1f38566_ba25_4c09_9282_eea2b86cb90b"></see>
    /// </summary>
    let EMMO_e1f38566_ba25_4c09_9282_eea2b86cb90b =
        Namespaced_IRI.parse _namespace_name "EMMO_e1f38566_ba25_4c09_9282_eea2b86cb90b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e258099f_5361_463c_ba1d_51d7d730630f"></see>
    /// </summary>
    let EMMO_e258099f_5361_463c_ba1d_51d7d730630f =
        Namespaced_IRI.parse _namespace_name "EMMO_e258099f_5361_463c_ba1d_51d7d730630f" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e2b08775_a0f6_4bf7_b228_53dc2299f114"></see>
    /// </summary>
    let EMMO_e2b08775_a0f6_4bf7_b228_53dc2299f114 =
        Namespaced_IRI.parse _namespace_name "EMMO_e2b08775_a0f6_4bf7_b228_53dc2299f114" |> NamespacedName

    /// <summary>
    /// A chemical substance composed of many identical molecules (or molecular entities) composed of atoms from more than one element held together by chemical bonds.
    /// <see href="https://w3id.org/emmo#EMMO_e2b11f6a_4191_427e_9844_2e0ac88dfc8b"></see></summary>
    let EMMO_e2b11f6a_4191_427e_9844_2e0ac88dfc8b =
        Namespaced_IRI.parse _namespace_name "EMMO_e2b11f6a_4191_427e_9844_2e0ac88dfc8b" |> NamespacedName

    /// <summary>
    /// Perceived power of light.
    /// <see href="https://w3id.org/emmo#EMMO_e2ee1c98_497a_4f66_b4ed_5711496a848e"></see></summary>
    let EMMO_e2ee1c98_497a_4f66_b4ed_5711496a848e =
        Namespaced_IRI.parse _namespace_name "EMMO_e2ee1c98_497a_4f66_b4ed_5711496a848e" |> NamespacedName

    /// <summary>
    /// Difference between equilibrium and initial amount of a substance, divided by its stoichiometric number.
    /// <see href="https://w3id.org/emmo#EMMO_e35d2cb2_e915_4667_bbe1_1149b19777cb"></see></summary>
    let EMMO_e35d2cb2_e915_4667_bbe1_1149b19777cb =
        Namespaced_IRI.parse _namespace_name "EMMO_e35d2cb2_e915_4667_bbe1_1149b19777cb" |> NamespacedName

    /// <summary>
    /// Type of thermodynamic potential; useful for calculating reversible work in certain systems.
    /// <see href="https://w3id.org/emmo#EMMO_e3727dab_74f9_438b_90f0_d03ea76c31fc"></see></summary>
    let EMMO_e3727dab_74f9_438b_90f0_d03ea76c31fc =
        Namespaced_IRI.parse _namespace_name "EMMO_e3727dab_74f9_438b_90f0_d03ea76c31fc" |> NamespacedName

    /// <summary>
    /// Derivative of velocity with respect to time.
    /// <see href="https://w3id.org/emmo#EMMO_e37ac288_aa60_415a_8cb7_c375724ac8e1"></see></summary>
    let EMMO_e37ac288_aa60_415a_8cb7_c375724ac8e1 =
        Namespaced_IRI.parse _namespace_name "EMMO_e37ac288_aa60_415a_8cb7_c375724ac8e1" |> NamespacedName

    /// <summary>
    /// Atom subclass for hafnium.
    /// <see href="https://w3id.org/emmo#EMMO_e37eaa49-d5e8-54e7-a7dc-9ad6073e86b7"></see></summary>
    let ``EMMO_e37eaa49-d5e8-54e7-a7dc-9ad6073e86b7`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e37eaa49-d5e8-54e7-a7dc-9ad6073e86b7" |> NamespacedName

    /// <summary>
    /// Performance measure of a device that uses thermal energy, expressed as the ratio of work done over thermal energy used.
    /// <see href="https://w3id.org/emmo#EMMO_e37ec2b9_aed3_4549_ad25_5f78d31cac06"></see></summary>
    let EMMO_e37ec2b9_aed3_4549_ad25_5f78d31cac06 =
        Namespaced_IRI.parse _namespace_name "EMMO_e37ec2b9_aed3_4549_ad25_5f78d31cac06" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e3850f08_8e79_454b_9d83_c517cab42857"></see>
    /// </summary>
    let EMMO_e3850f08_8e79_454b_9d83_c517cab42857 =
        Namespaced_IRI.parse _namespace_name "EMMO_e3850f08_8e79_454b_9d83_c517cab42857" |> NamespacedName

    /// <summary>
    /// A process which is an holistic spatial part of an object.
    /// A constitutive process is a process that is holistically relevant for the definition of the whole.
    /// <see href="https://w3id.org/emmo#EMMO_f68858dd_64f4_4877_b7fb_70d04fbe5bab"></see></summary>
    let EMMO_f68858dd_64f4_4877_b7fb_70d04fbe5bab =
        Namespaced_IRI.parse _namespace_name "EMMO_f68858dd_64f4_4877_b7fb_70d04fbe5bab" |> NamespacedName

    /// <summary>
    /// Atom subclass for terbium.
    /// <see href="https://w3id.org/emmo#EMMO_e3cd5791-6fbb-587a-a535-0e937800beaa"></see></summary>
    let ``EMMO_e3cd5791-6fbb-587a-a535-0e937800beaa`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e3cd5791-6fbb-587a-a535-0e937800beaa" |> NamespacedName

    /// <summary>
    /// A suspension of fine particles in the atmosphere.
    /// <see href="https://w3id.org/emmo#EMMO_e4281979_2b07_4a43_a772_4903fb3696fe"></see></summary>
    let EMMO_e4281979_2b07_4a43_a772_4903fb3696fe =
        Namespaced_IRI.parse _namespace_name "EMMO_e4281979_2b07_4a43_a772_4903fb3696fe" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'IlluminanceTime'.
    /// <see href="https://w3id.org/emmo#EMMO_e467cc3f_676c_432e_b70e_19237d1bcc78"></see></summary>
    let EMMO_e467cc3f_676c_432e_b70e_19237d1bcc78 =
        Namespaced_IRI.parse _namespace_name "EMMO_e467cc3f_676c_432e_b70e_19237d1bcc78" |> NamespacedName

    /// <summary>
    /// The radiant energy emitted, reflected, transmitted or received, per unit time.
    /// <see href="https://w3id.org/emmo#EMMO_e46f3f24_c2ec_4552_8dd4_cfc5c0a89c09"></see></summary>
    let EMMO_e46f3f24_c2ec_4552_8dd4_cfc5c0a89c09 =
        Namespaced_IRI.parse _namespace_name "EMMO_e46f3f24_c2ec_4552_8dd4_cfc5c0a89c09" |> NamespacedName

    /// <summary>
    /// Length in a given direction regarded as horizontal.
    /// The terms breadth and width are often used by convention, as distinguished from length and from height or thickness.
    /// <see href="https://w3id.org/emmo#EMMO_e4de48b1_dabb_4490_ac2b_040f926c64f0"></see></summary>
    let EMMO_e4de48b1_dabb_4490_ac2b_040f926c64f0 =
        Namespaced_IRI.parse _namespace_name "EMMO_e4de48b1_dabb_4490_ac2b_040f926c64f0" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SectionAreaIntegral'.
    /// <see href="https://w3id.org/emmo#EMMO_e55d4f6d_2506_4f63_8e01_1963efe7071e"></see></summary>
    let EMMO_e55d4f6d_2506_4f63_8e01_1963efe7071e =
        Namespaced_IRI.parse _namespace_name "EMMO_e55d4f6d_2506_4f63_8e01_1963efe7071e" |> NamespacedName

    /// <summary>
    /// Scalar or tensor quantity the product of which by the magnetic constant μ0 and by the magnetic field strength H is equal to the magnetic polarization J.
    /// <see href="https://w3id.org/emmo#EMMO_e59eb557_3a0f_4532_9984_deed22f94952"></see></summary>
    let EMMO_e59eb557_3a0f_4532_9984_deed22f94952 =
        Namespaced_IRI.parse _namespace_name "EMMO_e59eb557_3a0f_4532_9984_deed22f94952" |> NamespacedName

    /// <summary>
    /// constituent of the interaction energy between the spins of adjacent electrons in matter arising from the overlap of electron state functions
    /// <see href="https://w3id.org/emmo#EMMO_e5e17147_64a9_47c9_b3d1_2d4ab23eed54"></see></summary>
    let EMMO_e5e17147_64a9_47c9_b3d1_2d4ab23eed54 =
        Namespaced_IRI.parse _namespace_name "EMMO_e5e17147_64a9_47c9_b3d1_2d4ab23eed54" |> NamespacedName

    /// <summary>
    /// Proportionality constant between the magnetic dipole moment and the angular momentum of the electron.
    /// <see href="https://w3id.org/emmo#EMMO_e689c57f_2a8e_4bea_8750_a4fa015a1989"></see></summary>
    let EMMO_e689c57f_2a8e_4bea_8750_a4fa015a1989 =
        Namespaced_IRI.parse _namespace_name "EMMO_e689c57f_2a8e_4bea_8750_a4fa015a1989" |> NamespacedName

    /// <summary>
    /// Radius of a sphere such that the relativistic electron energy is distributed uniformly.
    /// <see href="https://w3id.org/emmo#EMMO_e6a173ac_40e9_4616_8883_710b358f5c85"></see></summary>
    let EMMO_e6a173ac_40e9_4616_8883_710b358f5c85 =
        Namespaced_IRI.parse _namespace_name "EMMO_e6a173ac_40e9_4616_8883_710b358f5c85" |> NamespacedName

    /// <summary>
    /// Electric conductivity of an electrolyte.
    /// <see href="https://w3id.org/emmo#EMMO_e6e7277a_1d40_4be5_a3a9_afd3da53d937"></see></summary>
    let EMMO_e6e7277a_1d40_4be5_a3a9_afd3da53d937 =
        Namespaced_IRI.parse _namespace_name "EMMO_e6e7277a_1d40_4be5_a3a9_afd3da53d937" |> NamespacedName

    /// <summary>
    /// fraction of nearest-neighbour atom pairs in an Ising ferromagnet having magnetic moments in one direction, minus the fraction having magnetic moments in the opposite direction
    /// <see href="https://w3id.org/emmo#EMMO_e6efd70d_87b4_4e18_a471_9b29c7a1fe16"></see></summary>
    let EMMO_e6efd70d_87b4_4e18_a471_9b29c7a1fe16 =
        Namespaced_IRI.parse _namespace_name "EMMO_e6efd70d_87b4_4e18_a471_9b29c7a1fe16" |> NamespacedName

    /// <summary>
    /// Scalar line integral of the magnetic field strength along a closed path.
    /// <see href="https://w3id.org/emmo#EMMO_e75fdaed_cb4e_41ba_8aa3_4cfa5087358f"></see></summary>
    let EMMO_e75fdaed_cb4e_41ba_8aa3_4cfa5087358f =
        Namespaced_IRI.parse _namespace_name "EMMO_e75fdaed_cb4e_41ba_8aa3_4cfa5087358f" |> NamespacedName

    /// <summary>
    /// Unit for quantities of dimension one that are the fraction of two speeds.
    /// <see href="https://w3id.org/emmo#EMMO_e7bc8939_7ff8_4917_beb5_c42730b390f3"></see></summary>
    let EMMO_e7bc8939_7ff8_4917_beb5_c42730b390f3 =
        Namespaced_IRI.parse _namespace_name "EMMO_e7bc8939_7ff8_4917_beb5_c42730b390f3" |> NamespacedName

    /// <summary>
    /// Ratio of area on a sphere to its radius squared.
    /// <see href="https://w3id.org/emmo#EMMO_e7c9f7fd_e534_4441_88fe_1fec6cb20f26"></see></summary>
    let EMMO_e7c9f7fd_e534_4441_88fe_1fec6cb20f26 =
        Namespaced_IRI.parse _namespace_name "EMMO_e7c9f7fd_e534_4441_88fe_1fec6cb20f26" |> NamespacedName

    /// <summary>
    /// A hypothesis is a theory, estimated and objective, since its estimated premises are objective.
    /// <see href="https://w3id.org/emmo#EMMO_e7cbc129_0d05_41a2_851a_10b198cd7ca2"></see></summary>
    let EMMO_e7cbc129_0d05_41a2_851a_10b198cd7ca2 =
        Namespaced_IRI.parse _namespace_name "EMMO_e7cbc129_0d05_41a2_851a_10b198cd7ca2" |> NamespacedName

    /// <summary>
    /// Atom subclass for mendelevium.
    /// <see href="https://w3id.org/emmo#EMMO_e85b68e1-ca2b-51b5-8b61-dea134d88bef"></see></summary>
    let ``EMMO_e85b68e1-ca2b-51b5-8b61-dea134d88bef`` =
        Namespaced_IRI.parse _namespace_name "EMMO_e85b68e1-ca2b-51b5-8b61-dea134d88bef" |> NamespacedName

    /// <summary>
    /// Internal energy per unit mass.
    /// <see href="https://w3id.org/emmo#EMMO_e86c84bd_af21_402d_a1ad_42a90599f9eb"></see></summary>
    let EMMO_e86c84bd_af21_402d_a1ad_42a90599f9eb =
        Namespaced_IRI.parse _namespace_name "EMMO_e86c84bd_af21_402d_a1ad_42a90599f9eb" |> NamespacedName

    /// <summary>
    /// Non-SI unit that has been accepted by SI to be used together with the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_e8b5f7de_4fd9_41d7_b988_87b512fe0180"></see></summary>
    let EMMO_e8b5f7de_4fd9_41d7_b988_87b512fe0180 =
        Namespaced_IRI.parse _namespace_name "EMMO_e8b5f7de_4fd9_41d7_b988_87b512fe0180" |> NamespacedName

    /// <summary>
    /// A manufacturing in which the product is a solid body with a well defined geometrical shape made from shapeless original material parts, whose cohesion is created during the process.
    /// <see href="https://w3id.org/emmo#EMMO_e9244742_c185_4c50_b455_c57654852582"></see></summary>
    let EMMO_e9244742_c185_4c50_b455_c57654852582 =
        Namespaced_IRI.parse _namespace_name "EMMO_e9244742_c185_4c50_b455_c57654852582" |> NamespacedName

    /// <summary>
    /// One-sixth of the mean square distance between the point where a neutron enters a specified class and the point where it leaves this class.
    /// <see href="https://w3id.org/emmo#EMMO_e93927b4_f403_4df8_8801_1162558a9b3e"></see></summary>
    let EMMO_e93927b4_f403_4df8_8801_1162558a9b3e =
        Namespaced_IRI.parse _namespace_name "EMMO_e93927b4_f403_4df8_8801_1162558a9b3e" |> NamespacedName

    /// <summary>
    /// Kinetic energy released per mass.
    /// <see href="https://w3id.org/emmo#EMMO_e963f280_1599_4ee8_bb74_439a4bc6412d"></see></summary>
    let EMMO_e963f280_1599_4ee8_bb74_439a4bc6412d =
        Namespaced_IRI.parse _namespace_name "EMMO_e963f280_1599_4ee8_bb74_439a4bc6412d" |> NamespacedName

    /// <summary>
    /// Mass per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_e980389d_6dfe_4156_9b40_32050c9644a5"></see></summary>
    let EMMO_e980389d_6dfe_4156_9b40_32050c9644a5 =
        Namespaced_IRI.parse _namespace_name "EMMO_e980389d_6dfe_4156_9b40_32050c9644a5" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e9907887_f266_4d81_9b2d_ba5137c914dd"></see>
    /// </summary>
    let EMMO_e9907887_f266_4d81_9b2d_ba5137c914dd =
        Namespaced_IRI.parse _namespace_name "EMMO_e9907887_f266_4d81_9b2d_ba5137c914dd" |> NamespacedName

    /// <summary>
    /// In a nuclear reaction, sum of the kinetic energies and photon energies of the reaction products minus the sum of the kinetic and photon energies of the reactants.
    /// <see href="https://w3id.org/emmo#EMMO_e998cee4_ac07_47a0_a12c_43eda1d9e750"></see></summary>
    let EMMO_e998cee4_ac07_47a0_a12c_43eda1d9e750 =
        Namespaced_IRI.parse _namespace_name "EMMO_e998cee4_ac07_47a0_a12c_43eda1d9e750" |> NamespacedName

    /// <summary>
    /// A data representing 8-bit non-negative integer number, 0...255.
    /// <see href="https://w3id.org/emmo#EMMO_e99aec47_9ae6_4a1d_bddd_b87bb456c52a"></see></summary>
    let EMMO_e99aec47_9ae6_4a1d_bddd_b87bb456c52a =
        Namespaced_IRI.parse _namespace_name "EMMO_e99aec47_9ae6_4a1d_bddd_b87bb456c52a" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_e9d65041_d87d_4b04_9fe9_1eed8f9c0370"></see>
    /// </summary>
    let EMMO_e9d65041_d87d_4b04_9fe9_1eed8f9c0370 =
        Namespaced_IRI.parse _namespace_name "EMMO_e9d65041_d87d_4b04_9fe9_1eed8f9c0370" |> NamespacedName

    /// <summary>
    /// Measurement unit for electric capacitance.
    /// The SI unit of electric capacitance. Very early in the study of electricity scientists discovered that a pair of conductors separated by an insulator can store a much larger charge than an isolated conductor can store. The better the insulator, the larger the charge that the conductors can hold. This property of a circuit is called capacitance, and it is measured in farads. One farad is defined as the ability to store one coulomb of charge per volt of potential difference between the two conductors. This is a natural definition, but the unit it defines is very large. In practical circuits, capacitance is often measured in microfarads, nanofarads, or sometimes even in picofarads (10⁻¹² farad, or trillionths of a farad). The unit is named for the British physicist Michael Faraday (1791-1867), who was known for his work in electricity and electrochemistry.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Farad"></see></summary>
    let Farad = Namespaced_IRI.parse _namespace_name "Farad" |> NamespacedName
    /// <summary>
    /// The SI unit of radiation dose. Radiation carries energy, and when it is absorbed by matter the matter receives this energy. The dose is the amount of energy deposited per unit of mass. One gray is defined to be the dose of one joule of energy absorbed per kilogram of matter, or 100 rad. The unit is named for the British physician L. Harold Gray (1905-1965), an authority on the use of radiation in the treatment of cancer.
    ///
    /// -- QUDT
    /// SI unit for absorbed dose.
    /// <see href="https://w3id.org/emmo#Gray"></see></summary>
    let Gray = Namespaced_IRI.parse _namespace_name "Gray" |> NamespacedName
    /// <summary>
    /// H = Wb/A = V·s/A = Ω·s
    /// SI unit for electrical inductance.
    /// <see href="https://w3id.org/emmo#Henry"></see></summary>
    let Henry = Namespaced_IRI.parse _namespace_name "Henry" |> NamespacedName
    /// <summary>
    /// SI unit for frequence.
    /// The hertz (symbol Hz) is the SI unit of frequency defined as the number of cycles per second of a periodic phenomenon. One of its most common uses is the description of the sine wave, particularly those used in radio and audio applications, such as the frequency of musical tones. The word "hertz" is named for Heinrich Rudolf Hertz, who was the first to conclusively prove the existence of electromagnetic waves.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Hertz"></see></summary>
    let Hertz = Namespaced_IRI.parse _namespace_name "Hertz" |> NamespacedName
    /// <summary>
    /// SI unit for energy.
    /// The SI unit of work or energy, defined to be the work done by a force of one newton acting to move an object through a distance of one meter in the direction in which the force is applied. Equivalently, since kinetic energy is one half the mass times the square of the velocity, one joule is the kinetic energy of a mass of two kilograms moving at a velocity of 1 m/s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Joule"></see></summary>
    let Joule = Namespaced_IRI.parse _namespace_name "Joule" |> NamespacedName
    /// <summary>
    /// A unit of catalytic activity used especially in the chemistry of enzymes. A catalyst is a substance that starts or speeds a chemical reaction. Enzymes are proteins that act as catalysts within the bodies of living plants and animals. A catalyst has an activity of one katal if it enables a reaction to proceed at the rate of one mole per second.
    ///
    /// -- QUDT
    /// SI unit for catalytic activity.
    /// <see href="https://w3id.org/emmo#Katal"></see></summary>
    let Katal = Namespaced_IRI.parse _namespace_name "Katal" |> NamespacedName
    /// <summary>
    /// SI unit for luminous flux.
    /// The SI unit for measuring the flux of light being produced by a light source or received by a surface. The intensity of a light source is measured in candelas. One lumen represents the total flux of light emitted, equal to the intensity in candelas multiplied by the solid angle in steradians into which the light is emitted. A full sphere has a solid angle of 4·π steradians. A light source that uniformly radiates one candela in all directions has a total luminous flux of 1 cd·4π sr = 4π cd·sr ≈ 12.57 lumens. "Lumen" is a Latin word for light.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Lumen"></see></summary>
    let Lumen = Namespaced_IRI.parse _namespace_name "Lumen" |> NamespacedName
    /// <summary>
    /// The SI unit for measuring the illumination (illuminance) of a surface. One lux is defined as an illumination of one lumen per square meter or 0.0001 phot. In considering the various light units, it's useful to think about light originating at a point and shining upon a surface. The intensity of the light source is measured in candelas; the total light flux in transit is measured in lumens (1 lumen = 1 candelau·steradian); and the amount of light received per unit of surface area is measured in lux (1 lux = 1 lumen/square meter). One lux is equal to approximately 0.09290 foot candle.
    ///
    /// -- QUDT
    /// SI unit for illuminance.
    /// <see href="https://w3id.org/emmo#Lux"></see></summary>
    let Lux = Namespaced_IRI.parse _namespace_name "Lux" |> NamespacedName
    /// <summary>
    /// SI unit for force.
    /// The "Newton" is the SI unit of force. A force of one newton will accelerate a mass of one kilogram at the rate of one meter per second per second. The newton is named for Isaac Newton (1642-1727), the British mathematician, physicist, and natural philosopher. He was the first person to understand clearly the relationship between force (F), mass (m), and acceleration (a) expressed by the formula F = m·a.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Newton"></see></summary>
    let Newton = Namespaced_IRI.parse _namespace_name "Newton" |> NamespacedName
    /// <summary>
    /// The SI derived unit of electrical resistance, named after German physicist Georg Simon Ohm.
    /// Ω = V/A = H/s
    /// <see href="https://w3id.org/emmo#Ohm"></see></summary>
    let Ohm = Namespaced_IRI.parse _namespace_name "Ohm" |> NamespacedName
    /// <summary>
    /// The SI unit of pressure. The pascal is the standard pressure unit in the MKS metric system, equal to one newton per square meter or one "kilogram per meter per second per second." The unit is named for Blaise Pascal (1623-1662), French philosopher and mathematician, who was the first person to use a barometer to measure differences in altitude.
    ///
    /// -- QUDT
    /// SI unit for pressure.
    /// <see href="https://w3id.org/emmo#Pascal"></see></summary>
    let Pascal = Namespaced_IRI.parse _namespace_name "Pascal" |> NamespacedName
    /// <summary>
    /// Measure of plane angle.
    /// Dimensionless measurement unit for plane angle.
    /// <see href="https://w3id.org/emmo#Radian"></see></summary>
    let Radian = Namespaced_IRI.parse _namespace_name "Radian" |> NamespacedName
    /// <summary>
    /// SI unit for electrical conductance.
    /// Siemens  is the SI unit of electric conductance, susceptance, and admittance. The most important property of a conductor is the amount of current it will carry when a voltage is applied. Current flow is opposed by resistance in all circuits, and by also by reactance and impedance in alternating current circuits. Conductance, susceptance, and admittance are the inverses of resistance, reactance, and impedance, respectively. To measure these properties, the siemens is the reciprocal of the ohm. In other words, the conductance, susceptance, or admittance, in siemens, is simply 1 divided by the resistance, reactance or impedance, respectively, in ohms. The unit is named for the German electrical engineer Werner von Siemens (1816-1892).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Siemens"></see></summary>
    let Siemens = Namespaced_IRI.parse _namespace_name "Siemens" |> NamespacedName
    /// <summary>
    /// SI unit for equivalent doseof ionizing radiation. Sievert is derived from absorbed dose, but takes into account the biological effectiveness of the radiation, which is dependent on the radiation type and energy.
    /// Although the sievert has the same dimensions as the gray (i.e. joules per kilogram), it measures a different quantity. To avoid any risk of confusion between the absorbed dose and the equivalent dose, the corresponding special units, namely the gray instead of the joule per kilogram for absorbed dose and the sievert instead of the joule per kilogram for the dose equivalent, should be used.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Sievert"></see></summary>
    let Sievert = Namespaced_IRI.parse _namespace_name "Sievert" |> NamespacedName
    /// <summary>
    /// Dimensionless measurement unit for solid angle.
    /// <see href="https://w3id.org/emmo#Steradian"></see></summary>
    let Steradian = Namespaced_IRI.parse _namespace_name "Steradian" |> NamespacedName
    /// <summary>
    /// SI unit for magnetic flux density or induction.
    /// The SI unit of flux density (or field intensity) for magnetic fields (also called the magnetic induction). The intensity of a magnetic field can be measured by placing a current-carrying conductor in the field. The magnetic field exerts a force on the conductor, a force which depends on the amount of the current and on the length of the conductor. One tesla is defined as the field intensity generating one newton of force per ampere of current per meter of conductor. Equivalently, one tesla represents a magnetic flux density of one weber per square meter of area. A field of one tesla is quite strong: the strongest fields available in laboratories are about 20 teslas, and the Earth's magnetic flux density, at its surface, is about 50 microteslas. The tesla, defined in 1958, honors the Serbian-American electrical engineer Nikola Tesla (1856-1943), whose work in electromagnetic induction led to the first practical generators and motors using alternating current.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Tesla"></see></summary>
    let Tesla = Namespaced_IRI.parse _namespace_name "Tesla" |> NamespacedName
    /// <summary>
    /// SI unit for electric potential difference.
    /// The volt is the unit of electric potential difference—electric potential difference is also known as voltage. The size of 1 volt is officially defined as the potential difference between two points of a wire carrying a current of 1 ampere when the power dissipated in the wire is 1 watt.
    /// <see href="https://w3id.org/emmo#Volt"></see></summary>
    let Volt = Namespaced_IRI.parse _namespace_name "Volt" |> NamespacedName
    /// <summary>
    /// The SI unit of power. Power is the rate at which work is done, or (equivalently) the rate at which energy is expended. One watt is equal to a power rate of one joule of work per second of time. This unit is used both in mechanics and in electricity, so it links the mechanical and electrical units to one another. In mechanical terms, one watt equals about 0.001 341 02 horsepower (hp) or 0.737 562 foot-pound per second (lbf/s). In electrical terms, one watt is the power produced by a current of one ampere flowing through an electric potential of one volt. The name of the unit honors James Watt (1736-1819), the British engineer whose improvements to the steam engine are often credited with igniting the Industrial Revolution.
    ///
    /// -- QUDT
    /// SI unit for power.
    /// <see href="https://w3id.org/emmo#Watt"></see></summary>
    let Watt = Namespaced_IRI.parse _namespace_name "Watt" |> NamespacedName
    /// <summary>
    /// The SI unit of magnetic flux. "Flux" is the rate (per unit of time) at which something crosses a surface perpendicular to the flow. The weber is a large unit, equal to 10⁸ maxwells, and practical fluxes are usually fractions of one weber. The weber is the magnetic flux which, linking a circuit of one turn, would produce in it an electromotive force of 1 volt if it were reduced to zero at a uniform rate in 1 second. In SI base units, the dimensions of the weber are (kg·m²)/(s²·A). The weber is commonly expressed in terms of other derived units as the Tesla-square meter (T·m²), volt-seconds (V·s), or joules per ampere (J/A).
    /// SI unit for magnetic flux.
    /// <see href="https://w3id.org/emmo#Weber"></see></summary>
    let Weber = Namespaced_IRI.parse _namespace_name "Weber" |> NamespacedName

    /// <summary>
    /// A construction language designed to transform some input text in a certain formal language into a modified output text that meets some specific goal.
    /// <see href="https://w3id.org/emmo#EMMO_ea00dafc_ac92_4e67_aa65_ce5a29e77fcf"></see></summary>
    let EMMO_ea00dafc_ac92_4e67_aa65_ce5a29e77fcf =
        Namespaced_IRI.parse _namespace_name "EMMO_ea00dafc_ac92_4e67_aa65_ce5a29e77fcf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ea7724fe_ba5d_4201_865e_761cb6fe9f99"></see>
    /// </summary>
    let EMMO_ea7724fe_ba5d_4201_865e_761cb6fe9f99 =
        Namespaced_IRI.parse _namespace_name "EMMO_ea7724fe_ba5d_4201_865e_761cb6fe9f99" |> NamespacedName

    /// <summary>
    /// Given an electric current in a thin conducting loop and the linked flux caused by that electric current in another loop, the mutual inductance of the two loops is the linked flux divided by the electric current.
    /// <see href="https://w3id.org/emmo#EMMO_ea7ef02a_589c_4971_908d_dee6688eebda"></see></summary>
    let EMMO_ea7ef02a_589c_4971_908d_dee6688eebda =
        Namespaced_IRI.parse _namespace_name "EMMO_ea7ef02a_589c_4971_908d_dee6688eebda" |> NamespacedName

    /// <summary>
    /// quotient of the amount of substance nB of solute B by the mass m of the solvent: bB = nB / m.
    /// <see href="https://w3id.org/emmo#EMMO_ead7c629_824a_410f_afec_579f08894c78"></see></summary>
    let EMMO_ead7c629_824a_410f_afec_579f08894c78 =
        Namespaced_IRI.parse _namespace_name "EMMO_ead7c629_824a_410f_afec_579f08894c78" |> NamespacedName

    /// <summary>
    /// Resistance quantum.
    /// The von Klitzing constant is defined as Planck constant divided by the square of the elementary charge.
    /// <see href="https://w3id.org/emmo#EMMO_eb561764_276e_413d_a8cb_3a3154fd9bf8"></see></summary>
    let EMMO_eb561764_276e_413d_a8cb_3a3154fd9bf8 =
        Namespaced_IRI.parse _namespace_name "EMMO_eb561764_276e_413d_a8cb_3a3154fd9bf8" |> NamespacedName

    /// <summary>
    /// A graphical object aimed to represent schematically the conceptual, tempral or spatial structure of another object, that may or may not exist.
    /// <see href="https://w3id.org/emmo#EMMO_eb7de1a1_c30e_4f0d_94c6_fe70414d7e61"></see></summary>
    let EMMO_eb7de1a1_c30e_4f0d_94c6_fe70414d7e61 =
        Namespaced_IRI.parse _namespace_name "EMMO_eb7de1a1_c30e_4f0d_94c6_fe70414d7e61" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ebc8c324_8e7a_4b09_bcb5_306e0c461d24"></see>
    /// </summary>
    let EMMO_ebc8c324_8e7a_4b09_bcb5_306e0c461d24 =
        Namespaced_IRI.parse _namespace_name "EMMO_ebc8c324_8e7a_4b09_bcb5_306e0c461d24" |> NamespacedName

    /// <summary>
    /// In nuclear physics, fraction of interacting particles per distance traversed in a given material.
    /// <see href="https://w3id.org/emmo#EMMO_ebd133e3_b823_478d_984f_1e399c6c99aa"></see></summary>
    let EMMO_ebd133e3_b823_478d_984f_1e399c6c99aa =
        Namespaced_IRI.parse _namespace_name "EMMO_ebd133e3_b823_478d_984f_1e399c6c99aa" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'ElectricFieldStrength'.
    /// <see href="https://w3id.org/emmo#EMMO_ebf9a5c6_ca80_45d4_a991_24a1bf4b6720"></see></summary>
    let EMMO_ebf9a5c6_ca80_45d4_a991_24a1bf4b6720 =
        Namespaced_IRI.parse _namespace_name "EMMO_ebf9a5c6_ca80_45d4_a991_24a1bf4b6720" |> NamespacedName

    /// <summary>
    /// A chain of linked physics based model simulations, where equations are solved sequentially.
    /// <see href="https://w3id.org/emmo#EMMO_ec502e30_b9ec_4216_90c6_f67d2df75627"></see></summary>
    let EMMO_ec502e30_b9ec_4216_90c6_f67d2df75627 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec502e30_b9ec_4216_90c6_f67d2df75627" |> NamespacedName

    /// <summary>
    /// at a given point on a two-dimensional domain of quasi-infinitesimal area dA, scalar quantity equal to the mass dm within the domain divided by the area dA, thus ρA = dm/dA.
    /// <see href="https://w3id.org/emmo#EMMO_ec767367_a773_4935_80ea_dd6a5eaefb54"></see></summary>
    let EMMO_ec767367_a773_4935_80ea_dd6a5eaefb54 =
        Namespaced_IRI.parse _namespace_name "EMMO_ec767367_a773_4935_80ea_dd6a5eaefb54" |> NamespacedName

    /// <summary>
    /// Decrease in magnitude of any kind of flux through a medium.
    /// <see href="https://w3id.org/emmo#EMMO_ecf938f1_bc37_4897_841d_092cd37f74de"></see></summary>
    let EMMO_ecf938f1_bc37_4897_841d_092cd37f74de =
        Namespaced_IRI.parse _namespace_name "EMMO_ecf938f1_bc37_4897_841d_092cd37f74de" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ee518694_9a11_41e5_ada2_8c68c62c2993"></see>
    /// </summary>
    let EMMO_ee518694_9a11_41e5_ada2_8c68c62c2993 =
        Namespaced_IRI.parse _namespace_name "EMMO_ee518694_9a11_41e5_ada2_8c68c62c2993" |> NamespacedName

    /// <summary>
    /// Power transferred per unit area.
    /// <see href="https://w3id.org/emmo#emmo_fd2aa864_eef7_4c3d_8243_9ea832d9df3e"></see></summary>
    let emmo_fd2aa864_eef7_4c3d_8243_9ea832d9df3e =
        Namespaced_IRI.parse _namespace_name "emmo_fd2aa864_eef7_4c3d_8243_9ea832d9df3e" |> NamespacedName

    /// <summary>
    /// Enthalpy per amount of substance.
    /// <see href="https://w3id.org/emmo#EMMO_ee837ed0_2355_4802_b3cd_a8fab297d244"></see></summary>
    let EMMO_ee837ed0_2355_4802_b3cd_a8fab297d244 =
        Namespaced_IRI.parse _namespace_name "EMMO_ee837ed0_2355_4802_b3cd_a8fab297d244" |> NamespacedName

    /// <summary>
    /// Sum of all cross sections corresponding to the various reactions or processes between an incident particle of specified type and energy and a target entity.
    /// <see href="https://w3id.org/emmo#EMMO_ee98501a_5036_48b5_902b_4c68c6eeec1e"></see></summary>
    let EMMO_ee98501a_5036_48b5_902b_4c68c6eeec1e =
        Namespaced_IRI.parse _namespace_name "EMMO_ee98501a_5036_48b5_902b_4c68c6eeec1e" |> NamespacedName

    /// <summary>
    /// Electric polarization divided by electric constant and electric field strength.
    /// <see href="https://w3id.org/emmo#EMMO_eead19f5_c0cd_4946_a501_c870bb50f3b1"></see></summary>
    let EMMO_eead19f5_c0cd_4946_a501_c870bb50f3b1 =
        Namespaced_IRI.parse _namespace_name "EMMO_eead19f5_c0cd_4946_a501_c870bb50f3b1" |> NamespacedName

    /// <summary>
    /// Relates a quantity to its reference unit through spatial direct parthood.
    /// <see href="https://w3id.org/emmo#EMMO_eeb06032_dd4f_476e_9da6_aa24302b7588"></see></summary>
    let EMMO_eeb06032_dd4f_476e_9da6_aa24302b7588 =
        Namespaced_IRI.parse _namespace_name "EMMO_eeb06032_dd4f_476e_9da6_aa24302b7588" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_eeb8118c_b290_4f57_b0f8_bd65bb6d77ad"></see>
    /// </summary>
    let EMMO_eeb8118c_b290_4f57_b0f8_bd65bb6d77ad =
        Namespaced_IRI.parse _namespace_name "EMMO_eeb8118c_b290_4f57_b0f8_bd65bb6d77ad" |> NamespacedName

    /// <summary>
    /// Number of turns in a winding.
    /// <see href="https://w3id.org/emmo#EMMO_eefaa0ef_e7d4_4633_bf79_655bb55f4a49"></see></summary>
    let EMMO_eefaa0ef_e7d4_4633_bf79_655bb55f4a49 =
        Namespaced_IRI.parse _namespace_name "EMMO_eefaa0ef_e7d4_4633_bf79_655bb55f4a49" |> NamespacedName

    /// <summary>
    /// Quotient of the rms value of the voltage between the terminals of a two-terminal element or a two-terminal circuit by the rms value of the electric current in the element or circuit.
    /// <see href="https://w3id.org/emmo#EMMO_efe73b0e_006b_417a_98a7_6db26b3ce2ac"></see></summary>
    let EMMO_efe73b0e_006b_417a_98a7_6db26b3ce2ac =
        Namespaced_IRI.parse _namespace_name "EMMO_efe73b0e_006b_417a_98a7_6db26b3ce2ac" |> NamespacedName

    /// <summary>
    /// Atom subclass for vanadium.
    /// <see href="https://w3id.org/emmo#EMMO_f02b58a5-8f1e-5d72-a261-8fe5ad2fbb4b"></see></summary>
    let ``EMMO_f02b58a5-8f1e-5d72-a261-8fe5ad2fbb4b`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f02b58a5-8f1e-5d72-a261-8fe5ad2fbb4b" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f0644f69_7337_4385_9d4a_4401b7bf3302"></see>
    /// </summary>
    let EMMO_f0644f69_7337_4385_9d4a_4401b7bf3302 =
        Namespaced_IRI.parse _namespace_name "EMMO_f0644f69_7337_4385_9d4a_4401b7bf3302" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f09e1d0a_07ce_4121_8c89_5bd67b7e8116"></see>
    /// </summary>
    let EMMO_f09e1d0a_07ce_4121_8c89_5bd67b7e8116 =
        Namespaced_IRI.parse _namespace_name "EMMO_f09e1d0a_07ce_4121_8c89_5bd67b7e8116" |> NamespacedName

    /// <summary>
    /// Critical thermodynamic temperature of an antiferromagnet.
    /// <see href="https://w3id.org/emmo#EMMO_f0b8bace_151e_4f54_8129_c180fd83ae44"></see></summary>
    let EMMO_f0b8bace_151e_4f54_8129_c180fd83ae44 =
        Namespaced_IRI.parse _namespace_name "EMMO_f0b8bace_151e_4f54_8129_c180fd83ae44" |> NamespacedName

    /// <summary>
    /// Difference between energy of an electron at rest at infinity and a certain energy level which is the energy of an electron in the interior of a substance.
    /// <see href="https://w3id.org/emmo#EMMO_f0b903be_d86f_4d28_9f42_b4d4753e2cf4"></see></summary>
    let EMMO_f0b903be_d86f_4d28_9f42_b4d4753e2cf4 =
        Namespaced_IRI.parse _namespace_name "EMMO_f0b903be_d86f_4d28_9f42_b4d4753e2cf4" |> NamespacedName

    /// <summary>
    /// The symbol that stands for the americium atom.
    /// <see href="https://w3id.org/emmo#EMMO_f107c0e5-0b9f-566c-9cba-a3443c904f78"></see></summary>
    let ``EMMO_f107c0e5-0b9f-566c-9cba-a3443c904f78`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f107c0e5-0b9f-566c-9cba-a3443c904f78" |> NamespacedName

    /// <summary>
    /// Quotient of entropy and mass.
    /// <see href="https://w3id.org/emmo#EMMO_f14ae884_9345_4de4_a322_362329517e3e"></see></summary>
    let EMMO_f14ae884_9345_4de4_a322_362329517e3e =
        Namespaced_IRI.parse _namespace_name "EMMO_f14ae884_9345_4de4_a322_362329517e3e" |> NamespacedName

    /// <summary>
    /// Number of direct parts of a Reductionistic.
    /// Using direct parthood EMMO creates a well-defined broadcasting between granularity levels. This also make it possible to count the direct parts of each granularity level.
    /// <see href="https://w3id.org/emmo#EMMO_f17133c2_bb33_4ffd_89fa_eef2b403d5e6"></see></summary>
    let EMMO_f17133c2_bb33_4ffd_89fa_eef2b403d5e6 =
        Namespaced_IRI.parse _namespace_name "EMMO_f17133c2_bb33_4ffd_89fa_eef2b403d5e6" |> NamespacedName

    /// <summary>
    /// A law that provides a connection between a material property and other properties of the object.
    /// <see href="https://w3id.org/emmo#EMMO_f19ff3b4_6bfe_4c41_a2b2_9affd39c140b"></see></summary>
    let EMMO_f19ff3b4_6bfe_4c41_a2b2_9affd39c140b =
        Namespaced_IRI.parse _namespace_name "EMMO_f19ff3b4_6bfe_4c41_a2b2_9affd39c140b" |> NamespacedName

    /// <summary>
    /// Extent of an object in space.
    /// <see href="https://w3id.org/emmo#EMMO_f1a51559_aa3d_43a0_9327_918039f0dfed"></see></summary>
    let EMMO_f1a51559_aa3d_43a0_9327_918039f0dfed =
        Namespaced_IRI.parse _namespace_name "EMMO_f1a51559_aa3d_43a0_9327_918039f0dfed" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f1d0f28b_7575_4e82_8d22_cb5b46b84cfd"></see>
    /// </summary>
    let EMMO_f1d0f28b_7575_4e82_8d22_cb5b46b84cfd =
        Namespaced_IRI.parse _namespace_name "EMMO_f1d0f28b_7575_4e82_8d22_cb5b46b84cfd" |> NamespacedName

    /// <summary>
    /// A data representing 64-bit non-negative integer number, 0...18446744073709551615.
    /// <see href="https://w3id.org/emmo#EMMO_f1ee5c02_5cc0_45ba_a09a_2e6319f75fc8"></see></summary>
    let EMMO_f1ee5c02_5cc0_45ba_a09a_2e6319f75fc8 =
        Namespaced_IRI.parse _namespace_name "EMMO_f1ee5c02_5cc0_45ba_a09a_2e6319f75fc8" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_f22abf74_4538_4f50_ab85_09908cdda707"></see>
    /// </summary>
    let EMMO_f22abf74_4538_4f50_ab85_09908cdda707 =
        Namespaced_IRI.parse _namespace_name "EMMO_f22abf74_4538_4f50_ab85_09908cdda707" |> NamespacedName

    /// <summary>
    /// A estimator that uses its predefined knowledge to declare a property of an object.
    /// <see href="https://w3id.org/emmo#EMMO_f273529f_9f2c_4877_a94b_5b47590353fc"></see></summary>
    let EMMO_f273529f_9f2c_4877_a94b_5b47590353fc =
        Namespaced_IRI.parse _namespace_name "EMMO_f273529f_9f2c_4877_a94b_5b47590353fc" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_f2c1a072_4ccb_46c4_a0f8_ac801d328d0f"></see></summary>
    let EMMO_f2c1a072_4ccb_46c4_a0f8_ac801d328d0f =
        Namespaced_IRI.parse _namespace_name "EMMO_f2c1a072_4ccb_46c4_a0f8_ac801d328d0f" |> NamespacedName

    /// <summary>
    /// Atom subclass for livermorium.
    /// <see href="https://w3id.org/emmo#EMMO_f2d4c89a-c354-5e4c-9cdb-f2de932e294f"></see></summary>
    let ``EMMO_f2d4c89a-c354-5e4c-9cdb-f2de932e294f`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f2d4c89a-c354-5e4c-9cdb-f2de932e294f" |> NamespacedName

    /// <summary>
    /// A command language designed to be run by a command-line interpreter, like a Unix shell.
    /// <see href="https://w3id.org/emmo#EMMO_f42a0e95_c130_4a69_9660_6bfdbb897d4a"></see></summary>
    let EMMO_f42a0e95_c130_4a69_9660_6bfdbb897d4a =
        Namespaced_IRI.parse _namespace_name "EMMO_f42a0e95_c130_4a69_9660_6bfdbb897d4a" |> NamespacedName

    /// <summary>
    /// Ratio of the number of dissociation events to the maximum number of theoretically possible dissociation events.
    /// Dissociation may occur stepwise.
    /// <see href="https://w3id.org/emmo#EMMO_f4cce1ec_c7dd_4061_8c46_7a24fdcd07ca"></see></summary>
    let EMMO_f4cce1ec_c7dd_4061_8c46_7a24fdcd07ca =
        Namespaced_IRI.parse _namespace_name "EMMO_f4cce1ec_c7dd_4061_8c46_7a24fdcd07ca" |> NamespacedName

    /// <summary>
    /// Atom subclass for zinc.
    /// <see href="https://w3id.org/emmo#EMMO_f4fee945-1d4a-5158-b0ca-eaef9ad40502"></see></summary>
    let ``EMMO_f4fee945-1d4a-5158-b0ca-eaef9ad40502`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f4fee945-1d4a-5158-b0ca-eaef9ad40502" |> NamespacedName

    /// <summary>
    /// Vector field quantity E which exerts on any charged particle at rest a force F equal to the product of E and the electric charge Q of the particle.
    /// <see href="https://w3id.org/emmo#EMMO_f53bafb6_b17d_4eb9_ad58_9d209f70dbfd"></see></summary>
    let EMMO_f53bafb6_b17d_4eb9_ad58_9d209f70dbfd =
        Namespaced_IRI.parse _namespace_name "EMMO_f53bafb6_b17d_4eb9_ad58_9d209f70dbfd" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'TemperaturePerMagneticFluxDensity'.
    /// <see href="https://w3id.org/emmo#EMMO_f6fac54d_6b6d_4255_b217_4363a83f1834"></see></summary>
    let EMMO_f6fac54d_6b6d_4255_b217_4363a83f1834 =
        Namespaced_IRI.parse _namespace_name "EMMO_f6fac54d_6b6d_4255_b217_4363a83f1834" |> NamespacedName

    /// <summary>
    /// In nuclear physics, time derivative of the energy fluence.
    /// <see href="https://w3id.org/emmo#EMMO_f8736fbd_b1e3_4fdc_bf5f_f69f54aef3bb"></see></summary>
    let EMMO_f8736fbd_b1e3_4fdc_bf5f_f69f54aef3bb =
        Namespaced_IRI.parse _namespace_name "EMMO_f8736fbd_b1e3_4fdc_bf5f_f69f54aef3bb" |> NamespacedName

    /// <summary>
    /// This form of matter may exist in a stable form within the core of some neutron stars.
    /// A baryon containing one or more strange quarks, but no charm, bottom, or top quark.
    /// <see href="https://w3id.org/emmo#EMMO_f87e79eb_f549_4a06_9c27_a3d1412444c6"></see></summary>
    let EMMO_f87e79eb_f549_4a06_9c27_a3d1412444c6 =
        Namespaced_IRI.parse _namespace_name "EMMO_f87e79eb_f549_4a06_9c27_a3d1412444c6" |> NamespacedName

    /// <summary>
    /// Atom subclass for americium.
    /// <see href="https://w3id.org/emmo#EMMO_f90da1f3-eb4c-54c4-b5d9-cf00fef180a1"></see></summary>
    let ``EMMO_f90da1f3-eb4c-54c4-b5d9-cf00fef180a1`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f90da1f3-eb4c-54c4-b5d9-cf00fef180a1" |> NamespacedName

    /// <summary>
    /// Atom subclass for copernicium.
    /// <see href="https://w3id.org/emmo#EMMO_f9125b67-8798-5595-9db3-ffc1840c9947"></see></summary>
    let ``EMMO_f9125b67-8798-5595-9db3-ffc1840c9947`` =
        Namespaced_IRI.parse _namespace_name "EMMO_f9125b67-8798-5595-9db3-ffc1840c9947" |> NamespacedName

    /// <summary>
    /// A estimator that uses modelling to declare a property of an object (i.e. infer a property from other properties).
    /// <see href="https://w3id.org/emmo#EMMO_f94e509a_be29_4365_a4cd_70165e47e232"></see></summary>
    let EMMO_f94e509a_be29_4365_a4cd_70165e47e232 =
        Namespaced_IRI.parse _namespace_name "EMMO_f94e509a_be29_4365_a4cd_70165e47e232" |> NamespacedName

    /// <summary>
    /// Activity per unit volume of the sample.
    /// <see href="https://w3id.org/emmo#EMMO_f94fceab_966b_4ead_b615_f6b6b07dfd55"></see></summary>
    let EMMO_f94fceab_966b_4ead_b615_f6b6b07dfd55 =
        Namespaced_IRI.parse _namespace_name "EMMO_f94fceab_966b_4ead_b615_f6b6b07dfd55" |> NamespacedName

    /// <summary>
    /// The frequency standard in the SI system in which the photon absorption by transitions between the two hyperfine ground states of caesium-133 atoms are used to control the output frequency.
    ///
    /// It defines the base unit second in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_f96feb3f_4438_4e43_aa44_7458c4d87fc2"></see></summary>
    let EMMO_f96feb3f_4438_4e43_aa44_7458c4d87fc2 =
        Namespaced_IRI.parse _namespace_name "EMMO_f96feb3f_4438_4e43_aa44_7458c4d87fc2" |> NamespacedName

    /// <summary>
    /// Measure of the change of amplitude and phase angle of a plane wave propagating in a given direction.
    /// <see href="https://w3id.org/emmo#EMMO_f9cc7a8e_bad7_40ea_be23_71dc6d0363df"></see></summary>
    let EMMO_f9cc7a8e_bad7_40ea_be23_71dc6d0363df =
        Namespaced_IRI.parse _namespace_name "EMMO_f9cc7a8e_bad7_40ea_be23_71dc6d0363df" |> NamespacedName

    /// <summary>
    /// The relation between the whole and a temporal tile that has only outgoing temporal connections.
    /// <see href="https://w3id.org/emmo#EMMO_fe63194f_7c04_4dbd_a244_524b38b6699b"></see></summary>
    let EMMO_fe63194f_7c04_4dbd_a244_524b38b6699b =
        Namespaced_IRI.parse _namespace_name "EMMO_fe63194f_7c04_4dbd_a244_524b38b6699b" |> NamespacedName

    /// <summary>
    /// Speed with which the envelope of a wave propagates in space.
    /// <see href="https://w3id.org/emmo#EMMO_fa957390_cdfb_4dda_b160_94ae25bd2254"></see></summary>
    let EMMO_fa957390_cdfb_4dda_b160_94ae25bd2254 =
        Namespaced_IRI.parse _namespace_name "EMMO_fa957390_cdfb_4dda_b160_94ae25bd2254" |> NamespacedName

    /// <summary>
    /// Deals with undefined shapes both input and output.
    /// The creation of a material entity starting from fundamental substances, involving chemical phenomena (e.g. reaction, bonding).
    /// <see href="https://w3id.org/emmo#EMMO_fa9cfc5d_9c3c_4856_a708_28be3858917e"></see></summary>
    let EMMO_fa9cfc5d_9c3c_4856_a708_28be3858917e =
        Namespaced_IRI.parse _namespace_name "EMMO_fa9cfc5d_9c3c_4856_a708_28be3858917e" |> NamespacedName

    /// <summary>
    /// A language used to describe what a computer system should do.
    /// <see href="https://w3id.org/emmo#EMMO_fb294e8d_603c_4fe5_bd71_8f4d152b2fb5"></see></summary>
    let EMMO_fb294e8d_603c_4fe5_bd71_8f4d152b2fb5 =
        Namespaced_IRI.parse _namespace_name "EMMO_fb294e8d_603c_4fe5_bd71_8f4d152b2fb5" |> NamespacedName

    /// <summary>
    /// Absolute value of the magnetic moment of a nucleus.
    /// <see href="https://w3id.org/emmo#EMMO_fbd27874_80aa_4aac_997b_91ab766342ac"></see></summary>
    let EMMO_fbd27874_80aa_4aac_997b_91ab766342ac =
        Namespaced_IRI.parse _namespace_name "EMMO_fbd27874_80aa_4aac_997b_91ab766342ac" |> NamespacedName

    /// <summary>
    /// Square root of the slowing down area.
    /// <see href="https://w3id.org/emmo#EMMO_fbef8d6b_9340_4ea0_bb38_26f66a5dee60"></see></summary>
    let EMMO_fbef8d6b_9340_4ea0_bb38_26f66a5dee60 =
        Namespaced_IRI.parse _namespace_name "EMMO_fbef8d6b_9340_4ea0_bb38_26f66a5dee60" |> NamespacedName

    /// <summary>
    /// Atom subclass for scandium.
    /// <see href="https://w3id.org/emmo#EMMO_fbfd4b93-12ee-5a15-8377-d4c54635b5de"></see></summary>
    let ``EMMO_fbfd4b93-12ee-5a15-8377-d4c54635b5de`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fbfd4b93-12ee-5a15-8377-d4c54635b5de" |> NamespacedName

    /// <summary>
    /// Physical quantity of dimension energy × time.
    /// <see href="https://w3id.org/emmo#EMMO_fc1987b2_afff_4dc6_a102_bdd9f024b03b"></see></summary>
    let EMMO_fc1987b2_afff_4dc6_a102_bdd9f024b03b =
        Namespaced_IRI.parse _namespace_name "EMMO_fc1987b2_afff_4dc6_a102_bdd9f024b03b" |> NamespacedName

    /// <summary>
    /// Imaginary part of the admittance.
    /// <see href="https://w3id.org/emmo#EMMO_fc457a08_9b93_4a00_bdcb_a806f30bcf90"></see></summary>
    let EMMO_fc457a08_9b93_4a00_bdcb_a806f30bcf90 =
        Namespaced_IRI.parse _namespace_name "EMMO_fc457a08_9b93_4a00_bdcb_a806f30bcf90" |> NamespacedName

    /// <summary>
    /// Scalar quantity equal to the line integral of the magnetic field strength H along a specified path linking two points a and b.
    /// <see href="https://w3id.org/emmo#EMMO_fcdf3dd6_c5d7_40d2_b062_b5580e37a9bd"></see></summary>
    let EMMO_fcdf3dd6_c5d7_40d2_b062_b5580e37a9bd =
        Namespaced_IRI.parse _namespace_name "EMMO_fcdf3dd6_c5d7_40d2_b062_b5580e37a9bd" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PressurePerTime'.
    /// <see href="https://w3id.org/emmo#EMMO_fced2382_9c23_47a1_8246_a5dcd45ad99c"></see></summary>
    let EMMO_fced2382_9c23_47a1_8246_a5dcd45ad99c =
        Namespaced_IRI.parse _namespace_name "EMMO_fced2382_9c23_47a1_8246_a5dcd45ad99c" |> NamespacedName

    /// <summary>
    /// Quotient of the linear attenuation coefficient µ and the mass density ρ of the medium.
    /// <see href="https://w3id.org/emmo#EMMO_fcfc9256_1159_44d2_b4c2_bac1b85698da"></see></summary>
    let EMMO_fcfc9256_1159_44d2_b4c2_bac1b85698da =
        Namespaced_IRI.parse _namespace_name "EMMO_fcfc9256_1159_44d2_b4c2_bac1b85698da" |> NamespacedName

    /// <summary>
    /// Atom subclass for holmium.
    /// <see href="https://w3id.org/emmo#EMMO_fd03c660-7b3b-5451-9d78-bc48836e1cc6"></see></summary>
    let ``EMMO_fd03c660-7b3b-5451-9d78-bc48836e1cc6`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fd03c660-7b3b-5451-9d78-bc48836e1cc6" |> NamespacedName

    /// <summary>
    /// Assigns a quantity to an object via a well-defined measurement procedure.
    /// <see href="https://w3id.org/emmo#EMMO_fd689787_31b0_41cf_bf03_0d69af76469d"></see></summary>
    let EMMO_fd689787_31b0_41cf_bf03_0d69af76469d =
        Namespaced_IRI.parse _namespace_name "EMMO_fd689787_31b0_41cf_bf03_0d69af76469d" |> NamespacedName

    /// <summary>
    /// Atom subclass for radon.
    /// <see href="https://w3id.org/emmo#EMMO_fd99c17e-6385-5b97-a20c-eddffdd56837"></see></summary>
    let ``EMMO_fd99c17e-6385-5b97-a20c-eddffdd56837`` =
        Namespaced_IRI.parse _namespace_name "EMMO_fd99c17e-6385-5b97-a20c-eddffdd56837" |> NamespacedName

    /// <summary>
    /// in the free electron model, the Fermi energy divided by the Boltzmann constant
    /// <see href="https://w3id.org/emmo#EMMO_fdd744f7_72e5_4060_86a7_93ff361237d6"></see></summary>
    let EMMO_fdd744f7_72e5_4060_86a7_93ff361237d6 =
        Namespaced_IRI.parse _namespace_name "EMMO_fdd744f7_72e5_4060_86a7_93ff361237d6" |> NamespacedName

    /// <summary>
    /// Force opposing the motion of a body sliding on a surface.
    /// <see href="https://w3id.org/emmo#EMMO_fe3eb868_8745_4fea_8370_4313d0531c18"></see></summary>
    let EMMO_fe3eb868_8745_4fea_8370_4313d0531c18 =
        Namespaced_IRI.parse _namespace_name "EMMO_fe3eb868_8745_4fea_8370_4313d0531c18" |> NamespacedName

    /// <summary>
    /// Reciprocal of the thermal resistance.
    /// <see href="https://w3id.org/emmo#EMMO_fe573dc7_9aac_49f2_9390_02cf697bfe53"></see></summary>
    let EMMO_fe573dc7_9aac_49f2_9390_02cf697bfe53 =
        Namespaced_IRI.parse _namespace_name "EMMO_fe573dc7_9aac_49f2_9390_02cf697bfe53" |> NamespacedName

    /// <summary>
    /// The dependent variable for which an equation has been written.
    /// <see href="https://w3id.org/emmo#EMMO_fe7e56ce_118b_4243_9aad_20eb9f4f31f6"></see></summary>
    let EMMO_fe7e56ce_118b_4243_9aad_20eb9f4f31f6 =
        Namespaced_IRI.parse _namespace_name "EMMO_fe7e56ce_118b_4243_9aad_20eb9f4f31f6" |> NamespacedName

    /// <summary>
    /// Radius of the osculating circle of a planar curve at a particular point of the curve.
    /// <see href="https://w3id.org/emmo#EMMO_fea5076a_20d0_4277_a4f1_d0eebd3b0d0e"></see></summary>
    let EMMO_fea5076a_20d0_4277_a4f1_d0eebd3b0d0e =
        Namespaced_IRI.parse _namespace_name "EMMO_fea5076a_20d0_4277_a4f1_d0eebd3b0d0e" |> NamespacedName

    /// <summary>
    /// Voltage between substances a and b caused by the thermoelectric effect.
    /// <see href="https://w3id.org/emmo#EMMO_fec651dc_8962_48c3_8b30_1115b2dd7c16"></see></summary>
    let EMMO_fec651dc_8962_48c3_8b30_1115b2dd7c16 =
        Namespaced_IRI.parse _namespace_name "EMMO_fec651dc_8962_48c3_8b30_1115b2dd7c16" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'PerLength'.
    /// <see href="https://w3id.org/emmo#EMMO_fee2a014_3322_48f9_91ab_d947a6e54556"></see></summary>
    let EMMO_fee2a014_3322_48f9_91ab_d947a6e54556 =
        Namespaced_IRI.parse _namespace_name "EMMO_fee2a014_3322_48f9_91ab_d947a6e54556" |> NamespacedName

    /// <summary>
    /// The imaginary part of the propagation coefficient.
    /// Change of phase angle with the length along the path travelled by a plane wave.
    /// <see href="https://w3id.org/emmo#EMMO_ff1212da_108e_4aaf_a2b0_b691fe53685e"></see></summary>
    let EMMO_ff1212da_108e_4aaf_a2b0_b691fe53685e =
        Namespaced_IRI.parse _namespace_name "EMMO_ff1212da_108e_4aaf_a2b0_b691fe53685e" |> NamespacedName

    /// <summary>
    /// A dimensionless thermodynamic parameter named after German physicist Eduard Grüneisen.
    /// <see href="https://w3id.org/emmo#EMMO_ff4dfc0f_6d79_41e1_9e32_68801bdea085"></see></summary>
    let EMMO_ff4dfc0f_6d79_41e1_9e32_68801bdea085 =
        Namespaced_IRI.parse _namespace_name "EMMO_ff4dfc0f_6d79_41e1_9e32_68801bdea085" |> NamespacedName

    /// <summary>
    /// Atom subclass for fluorine.
    /// <see href="https://w3id.org/emmo#EMMO_ff4e0ff1-a3ea-5c59-82dc-75f0abad66eb"></see></summary>
    let ``EMMO_ff4e0ff1-a3ea-5c59-82dc-75f0abad66eb`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ff4e0ff1-a3ea-5c59-82dc-75f0abad66eb" |> NamespacedName

    /// <summary>
    /// Atom subclass for magnesium.
    /// <see href="https://w3id.org/emmo#EMMO_ff5e8306-8e33-5305-84aa-d99055d34e0c"></see></summary>
    let ``EMMO_ff5e8306-8e33-5305-84aa-d99055d34e0c`` =
        Namespaced_IRI.parse _namespace_name "EMMO_ff5e8306-8e33-5305-84aa-d99055d34e0c" |> NamespacedName

    /// <summary>
    /// The class of units with dimensionality 'SquarePressurePerSquareTime'.
    /// <see href="https://w3id.org/emmo#EMMO_ffbacbc4_c3be_4cc5_9539_94344e72f7a6"></see></summary>
    let EMMO_ffbacbc4_c3be_4cc5_9539_94344e72f7a6 =
        Namespaced_IRI.parse _namespace_name "EMMO_ffbacbc4_c3be_4cc5_9539_94344e72f7a6" |> NamespacedName

    /// <summary>
    /// The DBpedia definition (http://dbpedia.org/page/Boltzmann_constant) is outdated as May 20, 2019. It is now an exact quantity.
    /// A physical constant relating energy at the individual particle level with temperature. It is the gas constant R divided by the Avogadro constant.
    ///
    /// It defines the Kelvin unit in the SI system.
    /// <see href="https://w3id.org/emmo#EMMO_ffc7735f_c177_46a4_98e9_a54440d29209"></see></summary>
    let EMMO_ffc7735f_c177_46a4_98e9_a54440d29209 =
        Namespaced_IRI.parse _namespace_name "EMMO_ffc7735f_c177_46a4_98e9_a54440d29209" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo#EMMO_ffe760a2_9d1f_4aef_8bee_1f450f9cb00d"></see>
    /// </summary>
    let EMMO_ffe760a2_9d1f_4aef_8bee_1f450f9cb00d =
        Namespaced_IRI.parse _namespace_name "EMMO_ffe760a2_9d1f_4aef_8bee_1f450f9cb00d" |> NamespacedName

    /// <summary>
    /// An electron volt (eV) is the energy that an electron gains when it travels through a potential of one volt. You can imagine that the electron starts at the negative plate of a parallel plate capacitor and accelerates to the positive plate, which is at one volt higher potential. Numerically 1 eV approximates 1.6x10⁻¹⁹ joules, where 1 joule is 6.2x10¹⁸ eV. For example, it would take 6.2x10²⁰ eV/sec to light a 100 watt light bulb.
    ///
    /// -- QUDT
    /// The amount of energy gained (or lost) by the charge of a single electron moving across an electric potential difference of one volt.
    /// <see href="https://w3id.org/emmo#ElectronVolt"></see></summary>
    let ElectronVolt =
        Namespaced_IRI.parse _namespace_name "ElectronVolt" |> NamespacedName

    /// <summary>
    /// `Electron Volt per Kelvin` is a unit for 'Heat Capacity' expressed as eV/K.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ElectronVoltPerKelvin"></see></summary>
    let ElectronVoltPerKelvin =
        Namespaced_IRI.parse _namespace_name "ElectronVoltPerKelvin" |> NamespacedName

    /// <summary>
    /// "Electron Volt per Tesla" is a unit for  'Magnetic Dipole Moment' expressed as eV T⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ElectronVoltPerTesla"></see></summary>
    let ElectronVoltPerTesla =
        Namespaced_IRI.parse _namespace_name "ElectronVoltPerTesla" |> NamespacedName

    /// <summary>
    /// "Electron Volt Second" is a unit for  'Angular Momentum' expressed as eV s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ElectronVoltSecond"></see></summary>
    let ElectronVoltSecond =
        Namespaced_IRI.parse _namespace_name "ElectronVoltSecond" |> NamespacedName

    /// <summary>
    /// unit electronvolt divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ElectronvoltPerMetre"></see></summary>
    let ElectronvoltPerMetre =
        Namespaced_IRI.parse _namespace_name "ElectronvoltPerMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit farad divided by the 1 000-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#FaradPerKiloMetre"></see></summary>
    let FaradPerKiloMetre =
        Namespaced_IRI.parse _namespace_name "FaradPerKiloMetre" |> NamespacedName

    /// <summary>
    /// Farad Per Meter (F/m) is a unit in the category of Electric permittivity. It is also known as farad/meter. This unit is commonly used in the SI unit system. Farad Per Meter has a dimension of M-1L-3T4I2 where M is mass, L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#FaradPerMetre"></see></summary>
    let FaradPerMetre =
        Namespaced_IRI.parse _namespace_name "FaradPerMetre" |> NamespacedName

    /// <summary>
    /// Fraction is a unit for 'Dimensionless Ratio' expressed as the value of the ratio itself.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Fraction"></see></summary>
    let Fraction = Namespaced_IRI.parse _namespace_name "Fraction" |> NamespacedName

    /// <summary>
    /// `Gram Degree Celsius` is a C.G.S System unit for 'Mass Temperature' expressed as g · degC.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramDegreeCelsius"></see></summary>
    let GramDegreeCelsius =
        Namespaced_IRI.parse _namespace_name "GramDegreeCelsius" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the unit day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerDay"></see></summary>
    let GramPerDay = Namespaced_IRI.parse _namespace_name "GramPerDay" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerHour"></see></summary>
    let GramPerHour =
        Namespaced_IRI.parse _namespace_name "GramPerHour" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerLitre"></see></summary>
    let GramPerLitre =
        Namespaced_IRI.parse _namespace_name "GramPerLitre" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the 0.001-fold of the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerMilliLitre"></see></summary>
    let GramPerMilliLitre =
        Namespaced_IRI.parse _namespace_name "GramPerMilliLitre" |> NamespacedName

    /// <summary>
    /// 0,001-fold of the SI base unit kilogram divided by the unit minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerMinute"></see></summary>
    let GramPerMinute =
        Namespaced_IRI.parse _namespace_name "GramPerMinute" |> NamespacedName

    /// <summary>
    /// A metric unit of volume over time indicating the amount generated across one square meter over a day.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GramPerSquareMetrePerDay"></see></summary>
    let GramPerSquareMetrePerDay =
        Namespaced_IRI.parse _namespace_name "GramPerSquareMetrePerDay" |> NamespacedName

    /// <summary>
    /// "Gray per Second" is a unit for  'Absorbed Dose Rate' expressed as Gy/s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#GrayPerSecond"></see></summary>
    let GrayPerSecond =
        Namespaced_IRI.parse _namespace_name "GrayPerSecond" |> NamespacedName

    /// <summary>
    /// The customary metric unit of land area, equal to 100 ares. One hectare is a square hectometer, that is, the area of a square 100 meters on each side: exactly 10 000 square meters or approximately 107 639.1 square feet, 11 959.9 square yards, or 2.471 054 acres.
    ///
    /// -- QUDT
    /// A non-SI metric unit of area defined as the square with 100-metre sides.
    /// <see href="https://w3id.org/emmo#Hectare"></see></summary>
    let Hectare = Namespaced_IRI.parse _namespace_name "Hectare" |> NamespacedName

    /// <summary>
    /// SI derived unit henry divided by the 1 000-fold of the SI derived unit ohm
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HenryPerKiloOhm"></see></summary>
    let HenryPerKiloOhm =
        Namespaced_IRI.parse _namespace_name "HenryPerKiloOhm" |> NamespacedName

    /// <summary>
    /// The henry per meter (symbolized H/m) is the unit of magnetic permeability in the International System of Units ( SI ). Reduced to base units in SI, 1 H/m is the equivalent of one kilogram meter per square second per square ampere.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HenryPerMetre"></see></summary>
    let HenryPerMetre =
        Namespaced_IRI.parse _namespace_name "HenryPerMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit henry divided by the SI derived unit ohm
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HenryPerOhm"></see></summary>
    let HenryPerOhm =
        Namespaced_IRI.parse _namespace_name "HenryPerOhm" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit hertz and the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HertzMetre"></see></summary>
    let HertzMetre = Namespaced_IRI.parse _namespace_name "HertzMetre" |> NamespacedName

    /// <summary>
    /// `Hertz per Kelvin` is a unit for 'Inverse Time Temperature' expressed as Hz K⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HertzPerKelvin"></see></summary>
    let HertzPerKelvin =
        Namespaced_IRI.parse _namespace_name "HertzPerKelvin" |> NamespacedName

    /// <summary>
    /// "Hertz per Tesla" is a unit for  'Electric Charge Per Mass' expressed as Hz T⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HertzPerTesla"></see></summary>
    let HertzPerTesla =
        Namespaced_IRI.parse _namespace_name "HertzPerTesla" |> NamespacedName

    /// <summary>
    /// In the Hertz per Volt standard the frequency of the note is directly related to the voltage. A pitch of a note goes up one octave when its frequency doubles, meaning that the voltage will have to double for every octave rise. Depending on the footage (octave) selected, nominally one volt gives 1000Hz, two volts 2000Hz and so on. In terms of notes, bottom C would be 0.25 volts, the next C up would be 0.5 volts, then 1V, 2V, 4V, 8V for the following octaves. This system was used mainly by Yamaha and Korg.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#HertzPerVolt"></see></summary>
    let HertzPerVolt =
        Namespaced_IRI.parse _namespace_name "HertzPerVolt" |> NamespacedName

    /// <summary>
    /// Measure of time defined as 3600 seconds.
    /// The hour (common symbol: h or hr) is a unit of measurement of time. In modern usage, an hour comprises 60 minutes, or 3,600 seconds. It is approximately 1/24 of a mean solar day. An hour in the Universal Coordinated Time (UTC) time standard can include a negative or positive leap second, and may therefore have a duration of 3,599 or 3,601 seconds for adjustment purposes. Although it is not a standard defined by the International System of Units, the hour is a unit accepted for use with SI, represented by the symbol h.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    /// `Joule Meter per Mole` is a unit for 'Length Molar Energy' expressed as J · m · mol⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JouleMetrePerMole"></see></summary>
    let JouleMetrePerMole =
        Namespaced_IRI.parse _namespace_name "JouleMetrePerMole" |> NamespacedName

    /// <summary>
    /// `Joule Per Cubic Meter` (J/m³) is a unit in the category of Energy density. It is also known as joules per cubic meter, joule per cubic metre, joules per cubic metre, joule/cubic meter, joule/cubic metre. This unit is commonly used in the SI unit system.  It has a dimension of ML⁻¹T⁻² where M is mass, L is length, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerCubicMetre"></see></summary>
    let JoulePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerCubicMetre" |> NamespacedName

    /// <summary>
    /// `Joule per Cubic Meter Kelvin` is a unit for 'Volumetric Heat Capacity' expressed as J/(m³ K).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerCubicMetreKelvin"></see></summary>
    let JoulePerCubicMetreKelvin =
        Namespaced_IRI.parse _namespace_name "JoulePerCubicMetreKelvin" |> NamespacedName

    /// <summary>
    /// SI derived unit joule divided by the 3600 times the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerHour"></see></summary>
    let JoulePerHour =
        Namespaced_IRI.parse _namespace_name "JoulePerHour" |> NamespacedName

    /// <summary>
    /// Joule Per Kelvin (J/K) is a unit in the category of Entropy. It is also known as joules per kelvin, joule/kelvin. This unit is commonly used in the SI unit system. Joule Per Kelvin (J/K) has a dimension of ML²T⁻²Q⁻¹ where M is mass, L is length, T is time, and Q is temperature. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerKelvin"></see></summary>
    let JoulePerKelvin =
        Namespaced_IRI.parse _namespace_name "JoulePerKelvin" |> NamespacedName

    /// <summary>
    /// Joule Per Kilogram} (J/kg) is a unit in the category of Thermal heat capacity. It is also known as `joule/kilogram`, `joules per kilogram`. This unit is commonly used in the SI unit system. The unit has a dimension of L2T⁻² where L is length, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerKilogram"></see></summary>
    let JoulePerKilogram =
        Namespaced_IRI.parse _namespace_name "JoulePerKilogram" |> NamespacedName

    /// <summary>
    /// Specific heat capacity - The heat required to raise unit mass of a substance by unit temperature interval under specified conditions, such as constant pressure: usually measured in joules per kelvin per kilogram. Symbol c_p (for constant pressure) Also called specific heat.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerKilogramKelvin"></see></summary>
    let JoulePerKilogramKelvin =
        Namespaced_IRI.parse _namespace_name "JoulePerKilogramKelvin" |> NamespacedName

    /// <summary>
    /// Joule per kilogram and Kelvin and cubic metre.
    /// <see href="https://w3id.org/emmo#JoulePerKilogramKelvinCubicMetre"></see></summary>
    let JoulePerKilogramKelvinCubicMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerKilogramKelvinCubicMetre" |> NamespacedName

    /// <summary>
    /// Joule per kilogram and Kelvin and Pascal.
    /// <see href="https://w3id.org/emmo#JoulePerKilogramKelvinPerPascal"></see></summary>
    let JoulePerKilogramKelvinPerPascal =
        Namespaced_IRI.parse _namespace_name "JoulePerKilogramKelvinPerPascal" |> NamespacedName

    /// <summary>
    /// Joule per metre.
    /// <see href="https://w3id.org/emmo#JoulePerMetre"></see></summary>
    let JoulePerMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerMetre" |> NamespacedName

    /// <summary>
    /// The joule per mole (symbol: J· mol⁻¹) is an SI derived unit of energy per amount of material. Energy is measured in joules, and the amount of material is measured in moles. Physical quantities measured in J· mol⁻¹) usually describe quantities of energy transferred during phase transformations or chemical reactions. Division by the number of moles facilitates comparison between processes involving different quantities of material and between similar processes involving different types of materials. The meaning of such a quantity is always context-dependent and, particularly for chemical reactions, is dependent on the (possibly arbitrary) definition of a 'mole' for a particular process.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerMole"></see></summary>
    let JoulePerMole =
        Namespaced_IRI.parse _namespace_name "JoulePerMole" |> NamespacedName

    /// <summary>
    /// Energy needed to heat one mole of substance by 1 Kelvin, under standard conditions (not standard temperature and pressure STP). The standard molar entropy is usually given the symbol S, and has units of joules per mole kelvin (  J· mol⁻¹ K⁻¹). Unlike standard enthalpies of formation, the value of S is an absolute. That is, an element in its standard state has a nonzero value of S at room temperature.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerMoleKelvin"></see></summary>
    let JoulePerMoleKelvin =
        Namespaced_IRI.parse _namespace_name "JoulePerMoleKelvin" |> NamespacedName

    /// <summary>
    /// `Joule Per Quartic Meter` (J/m⁴) is a unit for the spectral concentration of radiant energy density (in terms of wavelength), or the spectral radiant energy density (in terms of wave length). This unit is commonly used in the SI unit system.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerQuarticMetre"></see></summary>
    let JoulePerQuarticMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerQuarticMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit joule divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerSecond"></see></summary>
    let JoulePerSecond =
        Namespaced_IRI.parse _namespace_name "JoulePerSecond" |> NamespacedName

    /// <summary>
    /// derived SI unit joule divided by the 0.0001-fold of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerSquareCentiMetre"></see></summary>
    let JoulePerSquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerSquareCentiMetre" |> NamespacedName

    /// <summary>
    /// Radiant energy per 10⁻⁴ SI unit area over a period of one day.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerSquareCentiMetrePerDay"></see></summary>
    let JoulePerSquareCentiMetrePerDay =
        Namespaced_IRI.parse _namespace_name "JoulePerSquareCentiMetrePerDay" |> NamespacedName

    /// <summary>
    /// Joule Per Square Meter (J/m²) is a unit in the category of Energy density. It is also known as joules per square meter, joule per square metre, joule/square meter, joule/square metre. This unit is commonly used in the SI unit system.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerSquareMetre"></see></summary>
    let JoulePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "JoulePerSquareMetre" |> NamespacedName

    /// <summary>
    /// A measure of the diamagnetic energy, for a Bohr-radius spread around a magnetic axis, per square Tesla.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerSquareTesla"></see></summary>
    let JoulePerSquareTesla =
        Namespaced_IRI.parse _namespace_name "JoulePerSquareTesla" |> NamespacedName

    /// <summary>
    /// The magnetic moment of a magnet is a quantity that determines the force that the magnet can exert on electric currents and the torque that a magnetic field will exert on it. A loop of electric current, a bar magnet, an electron, a molecule, and a planet all have magnetic moments. The unit for magnetic moment is not a base unit in the International System of Units (SI) and it can be represented in more than one way. For example, in the current loop definition, the area is measured in square meters and I is measured in amperes, so the magnetic moment is measured in ampere-square meters (A m2). In the equation for torque on a moment, the torque is measured in joules and the magnetic field in tesla, so the moment is measured in Joules per Tesla (J u00b7T-1). These two representations are equivalent: 1 A u00b7m2 = 1 J u00b7T-1.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JoulePerTesla"></see></summary>
    let JoulePerTesla =
        Namespaced_IRI.parse _namespace_name "JoulePerTesla" |> NamespacedName

    /// <summary>
    /// The joule-second is a unit equal to a joule multiplied by a second, used to measure action or angular momentum. The joule-second is the unit used for Planck's constant.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JouleSecond"></see></summary>
    let JouleSecond =
        Namespaced_IRI.parse _namespace_name "JouleSecond" |> NamespacedName

    /// <summary>
    /// `Joule Second per Mole` is a unit for 'Molar Angular Momentum' expressed as J s mol⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#JouleSecondPerMole"></see></summary>
    let JouleSecondPerMole =
        Namespaced_IRI.parse _namespace_name "JouleSecondPerMole" |> NamespacedName

    /// <summary>
    /// Joule square metre.
    /// <see href="https://w3id.org/emmo#JouleSquareMetre"></see></summary>
    let JouleSquareMetre =
        Namespaced_IRI.parse _namespace_name "JouleSquareMetre" |> NamespacedName

    /// <summary>
    /// Joule square metre per kilogram.
    /// <see href="https://w3id.org/emmo#JouleSquareMetrePerKilogram"></see></summary>
    let JouleSquareMetrePerKilogram =
        Namespaced_IRI.parse _namespace_name "JouleSquareMetrePerKilogram" |> NamespacedName

    /// <summary>
    /// Kelvin day unit.
    /// <see href="https://w3id.org/emmo#KelvinDay"></see></summary>
    let KelvinDay = Namespaced_IRI.parse _namespace_name "KelvinDay" |> NamespacedName

    /// <summary>
    /// Kelvin metre.
    /// <see href="https://w3id.org/emmo#KelvinMetre"></see></summary>
    let KelvinMetre =
        Namespaced_IRI.parse _namespace_name "KelvinMetre" |> NamespacedName

    /// <summary>
    /// Kelvin metre per second.
    /// <see href="https://w3id.org/emmo#KelvinMetrePerSecond"></see></summary>
    let KelvinMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "KelvinMetrePerSecond" |> NamespacedName

    /// <summary>
    /// product of the SI base unit kelvin and the SI base unit metre divided by the derived SI unit watt
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinMetrePerWatt"></see></summary>
    let KelvinMetrePerWatt =
        Namespaced_IRI.parse _namespace_name "KelvinMetrePerWatt" |> NamespacedName

    /// <summary>
    /// Kelvin Pascal per second.
    /// <see href="https://w3id.org/emmo#KelvinPascalPerSecond"></see></summary>
    let KelvinPascalPerSecond =
        Namespaced_IRI.parse _namespace_name "KelvinPascalPerSecond" |> NamespacedName

    /// <summary>
    /// `Kelvin per Hour` is a unit for 'Temperature Per Time' expressed as K / h.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerHour"></see></summary>
    let KelvinPerHour =
        Namespaced_IRI.parse _namespace_name "KelvinPerHour" |> NamespacedName

    /// <summary>
    /// SI base unit kelvin divided by the SI base unit kelvin
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerKelvin"></see></summary>
    let KelvinPerKelvin =
        Namespaced_IRI.parse _namespace_name "KelvinPerKelvin" |> NamespacedName

    /// <summary>
    /// A change of temperature on the Kelvin temperature scale in one SI unit of length.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerMetre"></see></summary>
    let KelvinPerMetre =
        Namespaced_IRI.parse _namespace_name "KelvinPerMetre" |> NamespacedName

    /// <summary>
    /// `Kelvin per Minute` is a unit for 'Temperature Per Time' expressed as K / m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerMinute"></see></summary>
    let KelvinPerMinute =
        Namespaced_IRI.parse _namespace_name "KelvinPerMinute" |> NamespacedName

    /// <summary>
    /// `Kelvin per Second` is a unit for 'Temperature Per Time' expressed as K / s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerSecond"></see></summary>
    let KelvinPerSecond =
        Namespaced_IRI.parse _namespace_name "KelvinPerSecond" |> NamespacedName

    /// <summary>
    /// `Kelvin per Square Second` is a unit for 'Temperature Per Time Squared' expressed as K / s².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerSquareSecond"></see></summary>
    let KelvinPerSquareSecond =
        Namespaced_IRI.parse _namespace_name "KelvinPerSquareSecond" |> NamespacedName

    /// <summary>
    /// `Kelvin per Tesla` is a unit for 'Temperature Per Magnetic Flux Density' expressed as K T⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerTesla"></see></summary>
    let KelvinPerTesla =
        Namespaced_IRI.parse _namespace_name "KelvinPerTesla" |> NamespacedName

    /// <summary>
    /// Thermal resistance is a heat property and a measure of a temperature difference by which an object or material resists a heat flow (heat per time unit or thermal resistance). Thermal resistance is the reciprocal thermal conductance. Absolute thermal resistance is the temperature difference across a structure when a unit of heat energy flows through it in unit time. It is the reciprocal of thermal conductance. The SI units of thermal resistance are kelvins per watt or the equivalent degrees Celsius per watt (the two are the same since as intervals).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#KelvinPerWatt"></see></summary>
    let KelvinPerWatt =
        Namespaced_IRI.parse _namespace_name "KelvinPerWatt" |> NamespacedName

    /// <summary>
    /// Kelvin second.
    /// <see href="https://w3id.org/emmo#KelvinSecond"></see></summary>
    let KelvinSecond =
        Namespaced_IRI.parse _namespace_name "KelvinSecond" |> NamespacedName

    /// <summary>
    /// Kelvin square metres per kilogram and second.
    /// <see href="https://w3id.org/emmo#KelvinSquareMetrePerKilogramPerSecond"></see></summary>
    let KelvinSquareMetrePerKilogramPerSecond =
        Namespaced_IRI.parse _namespace_name "KelvinSquareMetrePerKilogramPerSecond" |> NamespacedName

    /// <summary>
    /// Other used symbols for litre are "l" and "ℓ".
    /// The litre (American spelling: `liter`; SI symbol l or L) is a non-SI metric system unit of volume equal to 1 `cubic decimetre` (dm³), 1,000 cubic centimetres (cm³) or 1/1000 `cubic metre`. If the lower case "L" is used as the symbol, it is sometimes rendered as a cursive "l" to help distinguish it from the capital "I", although this usage has no official approval by any international bureau.
    ///
    /// -- QUDT
    /// A non-SI unit of volume defined as 1 cubic decimetre (dm3),
    /// <see href="https://w3id.org/emmo#Litre"></see></summary>
    let Litre = Namespaced_IRI.parse _namespace_name "Litre" |> NamespacedName

    /// <summary>
    /// unit litre divided by the unit day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerDay"></see></summary>
    let LitrePerDay =
        Namespaced_IRI.parse _namespace_name "LitrePerDay" |> NamespacedName

    /// <summary>
    /// Unit litre divided by the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerHour"></see></summary>
    let LitrePerHour =
        Namespaced_IRI.parse _namespace_name "LitrePerHour" |> NamespacedName

    /// <summary>
    /// unit litre divided by the SI base unit kelvin
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerKelvin"></see></summary>
    let LitrePerKelvin =
        Namespaced_IRI.parse _namespace_name "LitrePerKelvin" |> NamespacedName

    /// <summary>
    /// unit of the volume litre divided by the SI base unit kilogram
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerKilogram"></see></summary>
    let LitrePerKilogram =
        Namespaced_IRI.parse _namespace_name "LitrePerKilogram" |> NamespacedName

    /// <summary>
    /// volume ratio consisting of the unit litre divided by the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerLitre"></see></summary>
    let LitrePerLitre =
        Namespaced_IRI.parse _namespace_name "LitrePerLitre" |> NamespacedName

    /// <summary>
    /// The inverse of a molar concentration - the untits of per molarity.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerMicroMole"></see></summary>
    let LitrePerMicroMole =
        Namespaced_IRI.parse _namespace_name "LitrePerMicroMole" |> NamespacedName

    /// <summary>
    /// unit litre divided by the unit minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerMinute"></see></summary>
    let LitrePerMinute =
        Namespaced_IRI.parse _namespace_name "LitrePerMinute" |> NamespacedName

    /// <summary>
    /// unit litre divided by the SI base unit mol
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerMole"></see></summary>
    let LitrePerMole =
        Namespaced_IRI.parse _namespace_name "LitrePerMole" |> NamespacedName

    /// <summary>
    /// unit litre divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerSecond"></see></summary>
    let LitrePerSecond =
        Namespaced_IRI.parse _namespace_name "LitrePerSecond" |> NamespacedName

    /// <summary>
    /// Ventilation rate in Litres per second divided by the floor area
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LitrePerSecondPerSquareMetre"></see></summary>
    let LitrePerSecondPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "LitrePerSecondPerSquareMetre" |> NamespacedName

    /// <summary>
    /// A measurement of luminous efficacy, which is the light output in lumens using one watt of electricity.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LumenPerWatt"></see></summary>
    let LumenPerWatt =
        Namespaced_IRI.parse _namespace_name "LumenPerWatt" |> NamespacedName

    /// <summary>
    /// In photometry, the lumen second is the SI derived unit of luminous energy. It is based on the lumen, the SI unit of luminous flux, and the second, the SI base unit of time.  The lumen second is sometimes called the talbot (symbol T).  An older name for the lumen second was the lumberg.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LumenSecond"></see></summary>
    let LumenSecond =
        Namespaced_IRI.parse _namespace_name "LumenSecond" |> NamespacedName

    /// <summary>
    /// The SI unit for measuring the illumination (illuminance) of a surface. One lux is defined as an illumination of one lumen per square meter or 0.0001 phot. In considering the various light units, it's useful to think about light originating at a point and shining upon a surface. The intensity of the light source is measured in candelas; the total light flux in transit is measured in lumens (1 lumen = 1 candelau00b7steradian); and the amount of light received per unit of surface area is measured in lux (1 lux = 1 lumen/square meter). One lux is equal to approximately 0.09290 foot candle.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#LuxHour"></see></summary>
    let LuxHour = Namespaced_IRI.parse _namespace_name "LuxHour" |> NamespacedName

    /// <summary>
    /// 1 000 000-fold of the SI base unit ampere divided by the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MegaAmperePerSquareMetre"></see></summary>
    let MegaAmperePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "MegaAmperePerSquareMetre" |> NamespacedName

    /// <summary>
    /// 1,000,000-fold of the derived unit volt
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MegaVolt"></see></summary>
    let MegaVolt = Namespaced_IRI.parse _namespace_name "MegaVolt" |> NamespacedName

    /// <summary>
    /// `Meter Kelvin` is a unit for 'Length Temperature' expressed as m K.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MetreKelvin"></see></summary>
    let MetreKelvin =
        Namespaced_IRI.parse _namespace_name "MetreKelvin" |> NamespacedName

    /// <summary>
    /// Kilogram metre.
    /// <see href="https://w3id.org/emmo#MetreKilogram"></see></summary>
    let MetreKilogram =
        Namespaced_IRI.parse _namespace_name "MetreKilogram" |> NamespacedName

    /// <summary>
    /// Metre per Farad.
    /// <see href="https://w3id.org/emmo#MetrePerFarad"></see></summary>
    let MetrePerFarad =
        Namespaced_IRI.parse _namespace_name "MetrePerFarad" |> NamespacedName

    /// <summary>
    /// Metre per hour is a metric unit of both speed (scalar) and velocity (Vector (geometry)). Its symbol is m/h or mu00b7h-1 (not to be confused with the imperial unit symbol mph. By definition, an object travelling at a speed of 1 m/h for an hour would move 1 metre.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MetrePerHour"></see></summary>
    let MetrePerHour =
        Namespaced_IRI.parse _namespace_name "MetrePerHour" |> NamespacedName

    /// <summary>
    /// Metre per Kelvin.
    /// <see href="https://w3id.org/emmo#MetrePerKelvin"></see></summary>
    let MetrePerKelvin =
        Namespaced_IRI.parse _namespace_name "MetrePerKelvin" |> NamespacedName

    /// <summary>
    /// Meter Per Minute (m/min) is a unit in the category of Velocity. It is also known as meter/minute, meters per minute, metre per minute, metres per minute. Meter Per Minute (m/min) has a dimension of LT-1 where L is length, and T is time. It can be converted to the corresponding standard SI unit m/s by multiplying its value by a factor of 0.016666666666
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MetrePerMinute"></see></summary>
    let MetrePerMinute =
        Namespaced_IRI.parse _namespace_name "MetrePerMinute" |> NamespacedName

    /// <summary>
    /// Metre per second is an SI derived unit of both speed (scalar) and velocity (vector quantity which specifies both magnitude and a specific direction), defined by distance in metres divided by time in seconds.
    /// The official SI symbolic abbreviation is mu00b7s-1, or equivalently either m/s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MetrePerSecond"></see></summary>
    let MetrePerSecond =
        Namespaced_IRI.parse _namespace_name "MetrePerSecond" |> NamespacedName

    /// <summary>
    /// The `meter per Square second` is the unit of acceleration in the International System of Units (SI). As a derived unit it is composed from the SI base units of length, the metre, and the standard unit of time, the second. Its symbol is written in several forms as m/s², or m s⁻². As acceleration, the unit is interpreted physically as change in velocity or speed per time interval, that is, `metre per second per second`.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MetrePerSquareSecond"></see></summary>
    let MetrePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "MetrePerSquareSecond" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit becquerel
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroBecquerel"></see></summary>
    let MicroBecquerel =
        Namespaced_IRI.parse _namespace_name "MicroBecquerel" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit coulomb divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroCoulombPerCubicMetre"></see></summary>
    let MicroCoulombPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "MicroCoulombPerCubicMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit coulomb divided by the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroCoulombPerSquareMetre"></see></summary>
    let MicroCoulombPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "MicroCoulombPerSquareMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit farad divided by the 1,000-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroFaradPerKiloMetre"></see></summary>
    let MicroFaradPerKiloMetre =
        Namespaced_IRI.parse _namespace_name "MicroFaradPerKiloMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit farad divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroFaradPerMetre"></see></summary>
    let MicroFaradPerMetre =
        Namespaced_IRI.parse _namespace_name "MicroFaradPerMetre" |> NamespacedName

    /// <summary>
    /// 0.000000001-fold of the SI base unit kilogram
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroGram"></see></summary>
    let MicroGram = Namespaced_IRI.parse _namespace_name "MicroGram" |> NamespacedName

    /// <summary>
    /// 0.000000001-fold of the SI base unit kilogram divided by the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroGramPerLitre"></see></summary>
    let MicroGramPerLitre =
        Namespaced_IRI.parse _namespace_name "MicroGramPerLitre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit henry divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroHenryPerMetre"></see></summary>
    let MicroHenryPerMetre =
        Namespaced_IRI.parse _namespace_name "MicroHenryPerMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroLitre"></see></summary>
    let MicroLitre = Namespaced_IRI.parse _namespace_name "MicroLitre" |> NamespacedName

    /// <summary>
    /// volume ratio as 0.000001-fold of the unit litre divided by the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroLitrePerLitre"></see></summary>
    let MicroLitrePerLitre =
        Namespaced_IRI.parse _namespace_name "MicroLitrePerLitre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI base unit metre divided by the SI base unit kelvin
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroMetrePerKelvin"></see></summary>
    let MicroMetrePerKelvin =
        Namespaced_IRI.parse _namespace_name "MicroMetrePerKelvin" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI base unit mol
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroMole"></see></summary>
    let MicroMole = Namespaced_IRI.parse _namespace_name "MicroMole" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit newton
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroNewton"></see></summary>
    let MicroNewton =
        Namespaced_IRI.parse _namespace_name "MicroNewton" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the product out of the derived SI newton and the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroNewtonMetre"></see></summary>
    let MicroNewtonMetre =
        Namespaced_IRI.parse _namespace_name "MicroNewtonMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit ohm
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroOhm"></see></summary>
    let MicroOhm = Namespaced_IRI.parse _namespace_name "MicroOhm" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit pascal
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroPascal"></see></summary>
    let MicroPascal =
        Namespaced_IRI.parse _namespace_name "MicroPascal" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit siemens
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroSiemens"></see></summary>
    let MicroSiemens =
        Namespaced_IRI.parse _namespace_name "MicroSiemens" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit Siemens divided by the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroSiemensPerCentiMetre"></see></summary>
    let MicroSiemensPerCentiMetre =
        Namespaced_IRI.parse _namespace_name "MicroSiemensPerCentiMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit Siemens divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroSiemensPerMetre"></see></summary>
    let MicroSiemensPerMetre =
        Namespaced_IRI.parse _namespace_name "MicroSiemensPerMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the SI derived unit watt
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MicroWatt"></see></summary>
    let MicroWatt = Namespaced_IRI.parse _namespace_name "MicroWatt" |> NamespacedName
    /// <summary>
    /// Non-SI time unit defined as 60 seconds.
    /// A minute is a unit of measurement of time. The minute is a unit of time equal to 1/60 (the first sexagesimal fraction of an hour or 60 seconds. In the UTC time scale, a minute on rare occasions has 59 or 61 seconds; see leap second. The minute is not an SI unit; however, it is accepted for use with SI units. The SI symbol for minute or minutes is min (for time measurement) or the prime symbol after a number, e.g. 5' (for angle measurement, even if it is informally used for time).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Minute"></see></summary>
    let Minute = Namespaced_IRI.parse _namespace_name "Minute" |> NamespacedName

    /// <summary>
    /// Mole Per Kilogram (mol/kg) is a unit of Molality
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolPerKilogram"></see></summary>
    let MolPerKilogram =
        Namespaced_IRI.parse _namespace_name "MolPerKilogram" |> NamespacedName

    /// <summary>
    /// `Mole Degree Celsius` is a C.G.S System unit for 'Temperature Amount Of Substance' expressed as mol-degC.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MoleDegreeCelsius"></see></summary>
    let MoleDegreeCelsius =
        Namespaced_IRI.parse _namespace_name "MoleDegreeCelsius" |> NamespacedName

    /// <summary>
    /// Mole Kelvin is a unit for `Temperature Amount Of Substance` expressed as mol-K.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MoleKelvin"></see></summary>
    let MoleKelvin = Namespaced_IRI.parse _namespace_name "MoleKelvin" |> NamespacedName

    /// <summary>
    /// SI base unit mol divided by the 0.001-fold of the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerCubicDeciMetre"></see></summary>
    let MolePerCubicDeciMetre =
        Namespaced_IRI.parse _namespace_name "MolePerCubicDeciMetre" |> NamespacedName

    /// <summary>
    /// The SI derived unit for amount-of-substance concentration is the mole/cubic meter.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerCubicMetre"></see></summary>
    let MolePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "MolePerCubicMetre" |> NamespacedName

    /// <summary>
    /// SI unit of quantity of matter per SI unit volume per SI unit of time.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerCubicMetrePerSecond"></see></summary>
    let MolePerCubicMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "MolePerCubicMetrePerSecond" |> NamespacedName

    /// <summary>
    /// SI unit of the quantity of matter per SI unit of mass per unit of time expressed in hour.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerGramPerHour"></see></summary>
    let MolePerGramPerHour =
        Namespaced_IRI.parse _namespace_name "MolePerGramPerHour" |> NamespacedName

    /// <summary>
    /// SI base unit mole divided by the unit for time hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerHour"></see></summary>
    let MolePerHour =
        Namespaced_IRI.parse _namespace_name "MolePerHour" |> NamespacedName

    /// <summary>
    /// Mole Per Kilogram Pascal (mol/kg-pa) is a unit of Molar Mass variation due to Pressure.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerKilogramPascal"></see></summary>
    let MolePerKilogramPascal =
        Namespaced_IRI.parse _namespace_name "MolePerKilogramPascal" |> NamespacedName

    /// <summary>
    /// SI base unit mol divided by the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerLitre"></see></summary>
    let MolePerLitre =
        Namespaced_IRI.parse _namespace_name "MolePerLitre" |> NamespacedName

    /// <summary>
    /// SI base unit mole divided by the unit for time minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerMinute"></see></summary>
    let MolePerMinute =
        Namespaced_IRI.parse _namespace_name "MolePerMinute" |> NamespacedName

    /// <summary>
    /// SI base unit mol divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerSecond"></see></summary>
    let MolePerSecond =
        Namespaced_IRI.parse _namespace_name "MolePerSecond" |> NamespacedName

    /// <summary>
    /// SI unit of quantity of matter per SI unit area.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerSquareMetre"></see></summary>
    let MolePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetre" |> NamespacedName

    /// <summary>
    /// quantity of matter per unit area per unit of time.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerSquareMetrePerDay"></see></summary>
    let MolePerSquareMetrePerDay =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetrePerDay" |> NamespacedName

    /// <summary>
    /// SI unit of quantity of matter per SI unit area per SI unit of time.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#MolePerSquareMetrePerSecond"></see></summary>
    let MolePerSquareMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetrePerSecond" |> NamespacedName

    /// <summary>
    /// Moles per square metre and second and metre.
    /// <see href="https://w3id.org/emmo#MolePerSquareMetrePerSecondPerMetre"></see></summary>
    let MolePerSquareMetrePerSecondPerMetre =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetrePerSecondPerMetre" |> NamespacedName

    /// <summary>
    /// Moles per square metre per second per metre per steradian.
    /// <see href="https://w3id.org/emmo#MolePerSquareMetrePerSecondPerMetrePerSteradian"></see></summary>
    let MolePerSquareMetrePerSecondPerMetrePerSteradian =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetrePerSecondPerMetrePerSteradian" |> NamespacedName

    /// <summary>
    /// Moles per square metre per second per steradian.
    /// <see href="https://w3id.org/emmo#MolePerSquareMetrePerSecondPerSteradian"></see></summary>
    let MolePerSquareMetrePerSecondPerSteradian =
        Namespaced_IRI.parse _namespace_name "MolePerSquareMetrePerSecondPerSteradian" |> NamespacedName

    /// <summary>
    /// Unit of measurement for quantities of type level or level difference, which are defined as the natural logarithm of the ratio of power- or field-type quantities.
    ///
    /// The value of a ratio in nepers is given by `ln(x1/x2)` where `x1` and `x2` are the values of interest (amplitudes), and ln is the natural logarithm. When the values are quadratic in the amplitude (e.g. power), they are first linearised by taking the square root before the logarithm is taken, or equivalently the result is halved.
    ///
    /// Wikipedia
    /// The neper is a logarithmic unit for ratios of measurements of physical field and power quantities, such as gain and loss of electronic signals. It has the unit symbol Np. The unit's name is derived from the name of John Napier, the inventor of logarithms. As is the case for the decibel and bel, the neper is not a unit in the International System of Units (SI), but it is accepted for use alongside the SI. Like the decibel, the neper is a unit in a logarithmic scale. While the bel uses the decadic (base-10) logarithm to compute ratios, the neper uses the natural logarithm, based on Euler's number
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Neper"></see></summary>
    let Neper = Namespaced_IRI.parse _namespace_name "Neper" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit newton and the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonCentiMetre"></see></summary>
    let NewtonCentiMetre =
        Namespaced_IRI.parse _namespace_name "NewtonCentiMetre" |> NamespacedName

    /// <summary>
    /// "Torque" is the tendency of a force to cause a rotation, is the product of the force and the distance from the center of rotation to the point where the force is applied. Torque has the same units as work or energy, but it is a different physical concept. To stress the difference, scientists measure torque in newton meters rather than in joules, the SI unit of work. One newton meter is approximately 0.737562 pound foot.
    ///
    /// -- QUDT
    /// Note that the physical dimension is the same as for Joule.
    /// <see href="https://w3id.org/emmo#NewtonMetre"></see></summary>
    let NewtonMetre =
        Namespaced_IRI.parse _namespace_name "NewtonMetre" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit newton and the SI base unit metre divided by the SI base unit ampere
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetrePerAmpere"></see></summary>
    let NewtonMetrePerAmpere =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerAmpere" |> NamespacedName

    /// <summary>
    /// product of the derived SI unit newton and the SI base unit metre divided by the SI base unit kilogram
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetrePerKilogram"></see></summary>
    let NewtonMetrePerKilogram =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerKilogram" |> NamespacedName

    /// <summary>
    /// This is the SI unit for the rolling resistance, which is equivalent to drag force in newton
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetrePerMetre"></see></summary>
    let NewtonMetrePerMetre =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerMetre" |> NamespacedName

    /// <summary>
    /// Newton metre per metre and radian.
    /// <see href="https://w3id.org/emmo#NewtonMetrePerMetrePerRadian"></see></summary>
    let NewtonMetrePerMetrePerRadian =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerMetrePerRadian" |> NamespacedName

    /// <summary>
    /// Newton Meter per Radian is the SI unit for Torsion Constant
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetrePerRadian"></see></summary>
    let NewtonMetrePerRadian =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerRadian" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit newton and the SI base unit metre divided by the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetrePerSquareMetre"></see></summary>
    let NewtonMetrePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "NewtonMetrePerSquareMetre" |> NamespacedName

    /// <summary>
    /// The SI derived unit of angular momentum.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetreSecond"></see></summary>
    let NewtonMetreSecond =
        Namespaced_IRI.parse _namespace_name "NewtonMetreSecond" |> NamespacedName

    /// <summary>
    /// Newton metre seconds measured per metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetreSecondPerMetre"></see></summary>
    let NewtonMetreSecondPerMetre =
        Namespaced_IRI.parse _namespace_name "NewtonMetreSecondPerMetre" |> NamespacedName

    /// <summary>
    /// Newton metre seconds measured per radian
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonMetreSecondPerRadian"></see></summary>
    let NewtonMetreSecondPerRadian =
        Namespaced_IRI.parse _namespace_name "NewtonMetreSecondPerRadian" |> NamespacedName

    /// <summary>
    /// SI derived unit newton divided by the SI base unit ampere
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerAmpere"></see></summary>
    let NewtonPerAmpere =
        Namespaced_IRI.parse _namespace_name "NewtonPerAmpere" |> NamespacedName

    /// <summary>
    /// SI derived unit newton divided by the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerCentiMetre"></see></summary>
    let NewtonPerCentiMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerCentiMetre" |> NamespacedName

    /// <summary>
    /// Newton Per Coulomb ( N/C) is a unit in the category of Electric field strength. It is also known as newtons/coulomb. Newton Per Coulomb ( N/C) has a dimension of MLT-3I-1 where M is mass, L is length, T is time, and I is electric current. It essentially the same as the corresponding standard SI unit V/m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerCoulomb"></see></summary>
    let NewtonPerCoulomb =
        Namespaced_IRI.parse _namespace_name "NewtonPerCoulomb" |> NamespacedName

    /// <summary>
    /// Newton per cubic metre.
    /// <see href="https://w3id.org/emmo#NewtonPerCubicMetre"></see></summary>
    let NewtonPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Gravitational field strength at a point is the gravitational force per unit mass at that point. It is a vector and its S.I. unit is N kg-1.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerKilogram"></see></summary>
    let NewtonPerKilogram =
        Namespaced_IRI.parse _namespace_name "NewtonPerKilogram" |> NamespacedName

    /// <summary>
    /// Newton Per Meter (N/m) is a unit in the category of Surface tension. It is also known as newtons per meter, newton per metre, newtons per metre, newton/meter, newton/metre. This unit is commonly used in the SI unit system. Newton Per Meter (N/m) has a dimension of MT-2 where M is mass, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerMetre"></see></summary>
    let NewtonPerMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit newton divided by the 0.001-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerMilliMetre"></see></summary>
    let NewtonPerMilliMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerMilliMetre" |> NamespacedName

    /// <summary>
    /// A one-newton force applied for one angle/torsional torque
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerRadian"></see></summary>
    let NewtonPerRadian =
        Namespaced_IRI.parse _namespace_name "NewtonPerRadian" |> NamespacedName

    /// <summary>
    /// derived SI unit newton divided by the 0.0001-fold of the power of the SI base unit metre by exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerSquareCentiMetre"></see></summary>
    let NewtonPerSquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerSquareCentiMetre" |> NamespacedName

    /// <summary>
    /// The SI unit of pressure. The pascal is the standard pressure unit in the MKS metric system, equal to one newton per square meter or one "kilogram per meter per second per second." The unit is named for Blaise Pascal (1623-1662), French philosopher and mathematician, who was the first person to use a barometer to measure differences in altitude.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerSquareMetre"></see></summary>
    let NewtonPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerSquareMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit newton divided by the 0.000001-fold of the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonPerSquareMilliMetre"></see></summary>
    let NewtonPerSquareMilliMetre =
        Namespaced_IRI.parse _namespace_name "NewtonPerSquareMilliMetre" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit newton and the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonSecond"></see></summary>
    let NewtonSecond =
        Namespaced_IRI.parse _namespace_name "NewtonSecond" |> NamespacedName

    /// <summary>
    /// The SI unit of specific acoustic impedance. When sound waves pass through any physical substance the pressure of the waves causes the particles of the substance to move. The sound specific impedance is the ratio between the sound pressure and the particle velocity it produces. The specific impedance is 1 N · s · m⁻³  if unit pressure produces unit velocity.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonSecondPerCubicMetre"></see></summary>
    let NewtonSecondPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "NewtonSecondPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Newton second measured per metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonSecondPerMetre"></see></summary>
    let NewtonSecondPerMetre =
        Namespaced_IRI.parse _namespace_name "NewtonSecondPerMetre" |> NamespacedName

    /// <summary>
    /// Newton seconds measured per radian
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonSecondPerRadian"></see></summary>
    let NewtonSecondPerRadian =
        Namespaced_IRI.parse _namespace_name "NewtonSecondPerRadian" |> NamespacedName

    /// <summary>
    /// Newton square metre.
    /// <see href="https://w3id.org/emmo#NewtonSquareMetre"></see></summary>
    let NewtonSquareMetre =
        Namespaced_IRI.parse _namespace_name "NewtonSquareMetre" |> NamespacedName

    /// <summary>
    /// Newton metre squared per Ampere.
    /// <see href="https://w3id.org/emmo#NewtonSquareMetrePerAmpere"></see></summary>
    let NewtonSquareMetrePerAmpere =
        Namespaced_IRI.parse _namespace_name "NewtonSquareMetrePerAmpere" |> NamespacedName

    /// <summary>
    /// unit of gravitational constant as product of the derived SI unit newton, the power of the SI base unit metre with the exponent 2 divided by the power of the SI base unit kilogram with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#NewtonSquareMetrePerSquareKilogram"></see></summary>
    let NewtonSquareMetrePerSquareKilogram =
        Namespaced_IRI.parse _namespace_name "NewtonSquareMetrePerSquareKilogram" |> NamespacedName

    /// <summary>
    /// Ohm metre.
    /// <see href="https://w3id.org/emmo#OhmMetre"></see></summary>
    let OhmMetre = Namespaced_IRI.parse _namespace_name "OhmMetre" |> NamespacedName

    /// <summary>
    /// Ohm square metre per metre.
    /// <see href="https://w3id.org/emmo#OhmSquareMetrePerMetre"></see></summary>
    let OhmSquareMetrePerMetre =
        Namespaced_IRI.parse _namespace_name "OhmSquareMetrePerMetre" |> NamespacedName

    /// <summary>
    /// product out of the SI derived unit pascal and the power of the SI base unit metre with the exponent 3 divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalCubicMetrePerSecond"></see></summary>
    let PascalCubicMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "PascalCubicMetrePerSecond" |> NamespacedName

    /// <summary>
    /// product out of the SI derived unit pascal and the unit litre divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalLitrePerSecond"></see></summary>
    let PascalLitrePerSecond =
        Namespaced_IRI.parse _namespace_name "PascalLitrePerSecond" |> NamespacedName

    /// <summary>
    /// Pascal metre.
    /// <see href="https://w3id.org/emmo#PascalMetre"></see></summary>
    let PascalMetre =
        Namespaced_IRI.parse _namespace_name "PascalMetre" |> NamespacedName

    /// <summary>
    /// Pascal metre per second.
    /// <see href="https://w3id.org/emmo#PascalMetrePerSecond"></see></summary>
    let PascalMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "PascalMetrePerSecond" |> NamespacedName

    /// <summary>
    /// Pascal metre per square second.
    /// <see href="https://w3id.org/emmo#PascalMetrePerSquareSecond"></see></summary>
    let PascalMetrePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "PascalMetrePerSquareSecond" |> NamespacedName

    /// <summary>
    /// A rate of change of pressure measured as the number of Pascals in a period of one hour.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalPerHour"></see></summary>
    let PascalPerHour =
        Namespaced_IRI.parse _namespace_name "PascalPerHour" |> NamespacedName

    /// <summary>
    /// Pascal per Kelvin.
    /// <see href="https://w3id.org/emmo#PascalPerKelvin"></see></summary>
    let PascalPerKelvin =
        Namespaced_IRI.parse _namespace_name "PascalPerKelvin" |> NamespacedName

    /// <summary>
    /// A rate of change of pressure measured as the number of Pascals in a period of one minute.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalPerMinute"></see></summary>
    let PascalPerMinute =
        Namespaced_IRI.parse _namespace_name "PascalPerMinute" |> NamespacedName

    /// <summary>
    /// A rate of change of pressure measured as the number of Pascals in a period of one second.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalPerSecond"></see></summary>
    let PascalPerSecond =
        Namespaced_IRI.parse _namespace_name "PascalPerSecond" |> NamespacedName

    /// <summary>
    /// The SI unit of dynamic viscosity, equal to 10 poises or 1000 centipoises.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalSecond"></see></summary>
    let PascalSecond =
        Namespaced_IRI.parse _namespace_name "PascalSecond" |> NamespacedName

    /// <summary>
    /// `Pascal Second Per Cubic Meter` (Pa-s/m³) is a unit in the category of Acoustic impedance. It is also known as `pascal-second/cubic meter`. It has a dimension of ML⁻⁴T⁻¹ where M is mass, L is length, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalSecondPerCubicMetre"></see></summary>
    let PascalSecondPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "PascalSecondPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Pascal Second Per Meter (Pa-s/m) is a unit in the category of Specific acoustic impedance. It is also known as pascal-second/meter. Pascal Second Per Meter has a dimension of ML²T⁻¹ where M is mass, L is length, and T is time. It essentially the same as the corresponding standard SI unit kg/m2· s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PascalSecondPerMetre"></see></summary>
    let PascalSecondPerMetre =
        Namespaced_IRI.parse _namespace_name "PascalSecondPerMetre" |> NamespacedName

    /// <summary>
    /// reciprocal of the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerCentiMetre"></see></summary>
    let PerCentiMetre =
        Namespaced_IRI.parse _namespace_name "PerCentiMetre" |> NamespacedName

    /// <summary>
    /// reciprocal of the 0.000001-fold of the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerCubicCentiMetre"></see></summary>
    let PerCubicCentiMetre =
        Namespaced_IRI.parse _namespace_name "PerCubicCentiMetre" |> NamespacedName

    /// <summary>
    /// "Per Cubic Meter" is a denominator unit with dimensions /m³.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerCubicMetre"></see></summary>
    let PerCubicMetre =
        Namespaced_IRI.parse _namespace_name "PerCubicMetre" |> NamespacedName

    /// <summary>
    /// Per cubic metre and second.
    /// <see href="https://w3id.org/emmo#PerCubicMetreSecond"></see></summary>
    let PerCubicMetreSecond =
        Namespaced_IRI.parse _namespace_name "PerCubicMetreSecond" |> NamespacedName

    /// <summary>
    /// reciprocal value of the 0.000000001-fold of the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerCubicMilliMetre"></see></summary>
    let PerCubicMilliMetre =
        Namespaced_IRI.parse _namespace_name "PerCubicMilliMetre" |> NamespacedName

    /// <summary>
    /// Reciprocal Henry.
    /// <see href="https://w3id.org/emmo#PerHenry"></see></summary>
    let PerHenry = Namespaced_IRI.parse _namespace_name "PerHenry" |> NamespacedName

    /// <summary>
    /// Per Joule cubic metre.
    /// <see href="https://w3id.org/emmo#PerJouleCubicMetre"></see></summary>
    let PerJouleCubicMetre =
        Namespaced_IRI.parse _namespace_name "PerJouleCubicMetre" |> NamespacedName

    /// <summary>
    /// Per Kelvin Unit is a denominator unit with dimensions /K.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerKelvin"></see></summary>
    let PerKelvin = Namespaced_IRI.parse _namespace_name "PerKelvin" |> NamespacedName

    /// <summary>
    /// Per Kilometer Unit is a denominator unit with dimensions /km.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerKiloMetre"></see></summary>
    let PerKiloMetre =
        Namespaced_IRI.parse _namespace_name "PerKiloMetre" |> NamespacedName

    /// <summary>
    /// Per Meter Unit is a denominator unit with dimensions /m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerMetre"></see></summary>
    let PerMetre = Namespaced_IRI.parse _namespace_name "PerMetre" |> NamespacedName

    /// <summary>
    /// Per Meter Kelvin Unit is a denominator unit with dimensions /m.k.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerMetreKelvin"></see></summary>
    let PerMetreKelvin =
        Namespaced_IRI.parse _namespace_name "PerMetreKelvin" |> NamespacedName

    /// <summary>
    /// Per metre and nanometre.
    /// <see href="https://w3id.org/emmo#PerMetreNanoMetre"></see></summary>
    let PerMetreNanoMetre =
        Namespaced_IRI.parse _namespace_name "PerMetreNanoMetre" |> NamespacedName

    /// <summary>
    /// Per metre and nanometre and steradian.
    /// <see href="https://w3id.org/emmo#PerMetreNanoMetreSteradian"></see></summary>
    let PerMetreNanoMetreSteradian =
        Namespaced_IRI.parse _namespace_name "PerMetreNanoMetreSteradian" |> NamespacedName

    /// <summary>
    /// Per metre and second.
    /// <see href="https://w3id.org/emmo#PerMetreSecond"></see></summary>
    let PerMetreSecond =
        Namespaced_IRI.parse _namespace_name "PerMetreSecond" |> NamespacedName

    /// <summary>
    /// Per metre and steradian.
    /// <see href="https://w3id.org/emmo#PerMetreSteradian"></see></summary>
    let PerMetreSteradian =
        Namespaced_IRI.parse _namespace_name "PerMetreSteradian" |> NamespacedName

    /// <summary>
    /// Per Micrometer Unit is a denominator unit with dimensions /microm.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerMicroMetre"></see></summary>
    let PerMicroMetre =
        Namespaced_IRI.parse _namespace_name "PerMicroMetre" |> NamespacedName

    /// <summary>
    /// Per Millimeter Unit is a denominator unit with dimensions /mm.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerMilliMetre"></see></summary>
    let PerMilliMetre =
        Namespaced_IRI.parse _namespace_name "PerMilliMetre" |> NamespacedName

    /// <summary>
    /// Per millisecond.
    /// <see href="https://w3id.org/emmo#PerMilliSecond"></see></summary>
    let PerMilliSecond =
        Namespaced_IRI.parse _namespace_name "PerMilliSecond" |> NamespacedName

    /// <summary>
    /// Per Mole Unit is a denominator unit with dimensions mol⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerMole"></see></summary>
    let PerMole = Namespaced_IRI.parse _namespace_name "PerMole" |> NamespacedName

    /// <summary>
    /// Per Nanometer Unit is a denominator unit with dimensions /nm.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerNanoMetre"></see></summary>
    let PerNanoMetre =
        Namespaced_IRI.parse _namespace_name "PerNanoMetre" |> NamespacedName

    /// <summary>
    /// Per Pascal.
    /// <see href="https://w3id.org/emmo#PerPascal"></see></summary>
    let PerPascal = Namespaced_IRI.parse _namespace_name "PerPascal" |> NamespacedName

    /// <summary>
    /// Per Pascal and Second.
    /// <see href="https://w3id.org/emmo#PerPascalSecond"></see></summary>
    let PerPascalSecond =
        Namespaced_IRI.parse _namespace_name "PerPascalSecond" |> NamespacedName

    /// <summary>
    /// Per Picoometer Unit is a denominator unit with dimensions /pm.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerPicoMetre"></see></summary>
    let PerPicoMetre =
        Namespaced_IRI.parse _namespace_name "PerPicoMetre" |> NamespacedName

    /// <summary>
    /// A reciprical unit of time for `reciprocal second` or `inverse second`. The `Per Second` is a unit of rate.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSecond"></see></summary>
    let PerSecond = Namespaced_IRI.parse _namespace_name "PerSecond" |> NamespacedName

    /// <summary>
    /// `Per Second Square Meter` is a measure of flux with dimensions /sec-m².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSecondSquareMetre"></see></summary>
    let PerSecondSquareMetre =
        Namespaced_IRI.parse _namespace_name "PerSecondSquareMetre" |> NamespacedName

    /// <summary>
    /// Per Second Square Meter Steradian is a denominator unit with dimensions /sec-m²-sr.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSecondSquareMetreSteradian"></see></summary>
    let PerSecondSquareMetreSteradian =
        Namespaced_IRI.parse _namespace_name "PerSecondSquareMetreSteradian" |> NamespacedName

    /// <summary>
    /// Per Second Steradian Unit is a denominator unit with dimensions /sec-sr.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSecondSteradian"></see></summary>
    let PerSecondSteradian =
        Namespaced_IRI.parse _namespace_name "PerSecondSteradian" |> NamespacedName

    /// <summary>
    /// Per Square Joule is a denominator unit with dimensions /eV².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSquareJoule"></see></summary>
    let PerSquareJoule =
        Namespaced_IRI.parse _namespace_name "PerSquareJoule" |> NamespacedName

    /// <summary>
    /// Per Square Kilogram is a denominator unit with dimensions /kg².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSquareKilogram"></see></summary>
    let PerSquareKilogram =
        Namespaced_IRI.parse _namespace_name "PerSquareKilogram" |> NamespacedName

    /// <summary>
    /// "Per Square Meter" is a denominator unit with dimensions /m².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerSquareMetre"></see></summary>
    let PerSquareMetre =
        Namespaced_IRI.parse _namespace_name "PerSquareMetre" |> NamespacedName

    /// <summary>
    /// Per square metre and second.
    /// <see href="https://w3id.org/emmo#PerSquareMetreSecond"></see></summary>
    let PerSquareMetreSecond =
        Namespaced_IRI.parse _namespace_name "PerSquareMetreSecond" |> NamespacedName

    /// <summary>
    /// Per square second.
    /// <see href="https://w3id.org/emmo#PerSquareSecond"></see></summary>
    let PerSquareSecond =
        Namespaced_IRI.parse _namespace_name "PerSquareSecond" |> NamespacedName

    /// <summary>
    /// Per steradian.
    /// <see href="https://w3id.org/emmo#PerSteradian"></see></summary>
    let PerSteradian =
        Namespaced_IRI.parse _namespace_name "PerSteradian" |> NamespacedName

    /// <summary>
    /// Per Tesla Meter Unit is a denominator unit with dimensions /m .· T.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerTeslaMetre"></see></summary>
    let PerTeslaMetre =
        Namespaced_IRI.parse _namespace_name "PerTeslaMetre" |> NamespacedName

    /// <summary>
    /// Per Tesla Second Unit is a denominator unit with dimensions /s . T.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#PerTeslaSecond"></see></summary>
    let PerTeslaSecond =
        Namespaced_IRI.parse _namespace_name "PerTeslaSecond" |> NamespacedName

    /// <summary>
    /// Per Weber unit.
    /// <see href="https://w3id.org/emmo#PerWeber"></see></summary>
    let PerWeber = Namespaced_IRI.parse _namespace_name "PerWeber" |> NamespacedName

    /// <summary>
    /// "Quartic Coulomb Meter per Cubic Energy" is a unit for  'Quartic Electric Dipole Moment Per Cubic Energy' expressed as C⁴ m⁴ J⁻³.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#QuarticCoulombMetrePerCubicEnergy"></see></summary>
    let QuarticCoulombMetrePerCubicEnergy =
        Namespaced_IRI.parse _namespace_name "QuarticCoulombMetrePerCubicEnergy" |> NamespacedName

    /// <summary>
    /// A unit associated with area moments of inertia.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#QuarticMetre"></see></summary>
    let QuarticMetre =
        Namespaced_IRI.parse _namespace_name "QuarticMetre" |> NamespacedName

    /// <summary>
    /// Metre to the power four per second.
    /// <see href="https://w3id.org/emmo#QuarticMetrePerSecond"></see></summary>
    let QuarticMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "QuarticMetrePerSecond" |> NamespacedName

    /// <summary>
    /// 0.001-fold of the power of the SI base unit metre with the exponent 4
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#QuarticMilliMetre"></see></summary>
    let QuarticMilliMetre =
        Namespaced_IRI.parse _namespace_name "QuarticMilliMetre" |> NamespacedName

    /// <summary>
    /// Metre to the power of five.
    /// <see href="https://w3id.org/emmo#QuinticMetre"></see></summary>
    let QuinticMetre =
        Namespaced_IRI.parse _namespace_name "QuinticMetre" |> NamespacedName

    /// <summary>
    /// "Radian per Hour" is a unit for  'Angular Velocity' expressed as rad/h.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#RadianPerHour"></see></summary>
    let RadianPerHour =
        Namespaced_IRI.parse _namespace_name "RadianPerHour" |> NamespacedName

    /// <summary>
    /// Radian per metre.
    /// <see href="https://w3id.org/emmo#RadianPerMetre"></see></summary>
    let RadianPerMetre =
        Namespaced_IRI.parse _namespace_name "RadianPerMetre" |> NamespacedName

    /// <summary>
    /// Radian Per Minute (rad/min) is a unit in the category of Angular velocity. It is also known as radians per minute, radian/minute. Radian Per Minute (rad/min) has a dimension of aT-1 where T is time. It can be converted to the corresponding standard SI unit rad/s by multiplying its value by a factor of 0.0166666666667.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#RadianPerMinute"></see></summary>
    let RadianPerMinute =
        Namespaced_IRI.parse _namespace_name "RadianPerMinute" |> NamespacedName

    /// <summary>
    /// "Radian per Second" is the SI unit of rotational speed (angular velocity), and, also the unit of angular frequency. The radian per second is defined as the change in the orientation of an object, in radians, every second.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#RadianPerSecond"></see></summary>
    let RadianPerSecond =
        Namespaced_IRI.parse _namespace_name "RadianPerSecond" |> NamespacedName

    /// <summary>
    /// Angular acceleration is the rate of change of angular velocity. In SI units, it is measured in radians per Square second (rad/s²), and is usually denoted by the Greek letter α.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#RadianPerSquareSecond"></see></summary>
    let RadianPerSquareSecond =
        Namespaced_IRI.parse _namespace_name "RadianPerSquareSecond" |> NamespacedName

    /// <summary>
    /// Radian square metre per kilogram.
    /// <see href="https://w3id.org/emmo#RadianSquareMetrePerKilogram"></see></summary>
    let RadianSquareMetrePerKilogram =
        Namespaced_IRI.parse _namespace_name "RadianSquareMetrePerKilogram" |> NamespacedName

    /// <summary>
    /// Radian square metre per mole.
    /// <see href="https://w3id.org/emmo#RadianSquareMetrePerMole"></see></summary>
    let RadianSquareMetrePerMole =
        Namespaced_IRI.parse _namespace_name "RadianSquareMetrePerMole" |> NamespacedName

    /// <summary>
    /// reciprocal of the unit day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalDay"></see></summary>
    let ReciprocalDay =
        Namespaced_IRI.parse _namespace_name "ReciprocalDay" |> NamespacedName

    /// <summary>
    /// A reciprocal unit of time for `reciprocal hour` or "inverse hour".
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalHour"></see></summary>
    let ReciprocalHour =
        Namespaced_IRI.parse _namespace_name "ReciprocalHour" |> NamespacedName

    /// <summary>
    /// reciprocal of the 1,000-fold of the product of the SI derived unit volt and the SI base unit ampere and the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalKiloVoltAmpereHour"></see></summary>
    let ReciprocalKiloVoltAmpereHour =
        Namespaced_IRI.parse _namespace_name "ReciprocalKiloVoltAmpereHour" |> NamespacedName

    /// <summary>
    /// reciprocal value of the unit litre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalLitre"></see></summary>
    let ReciprocalLitre =
        Namespaced_IRI.parse _namespace_name "ReciprocalLitre" |> NamespacedName

    /// <summary>
    /// Units used to describe the sensitivity of detection of a spectrophotometer.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalMicroMolePerLitre"></see></summary>
    let ReciprocalMicroMolePerLitre =
        Namespaced_IRI.parse _namespace_name "ReciprocalMicroMolePerLitre" |> NamespacedName

    /// <summary>
    /// A reciprocal unit of time for `reciprocal minute` or `inverse minute`.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalMinute"></see></summary>
    let ReciprocalMinute =
        Namespaced_IRI.parse _namespace_name "ReciprocalMinute" |> NamespacedName

    /// <summary>
    /// Per Square Electron Volt is a denominator unit with dimensions /eV².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalSquareElectronVolt"></see></summary>
    let ReciprocalSquareElectronVolt =
        Namespaced_IRI.parse _namespace_name "ReciprocalSquareElectronVolt" |> NamespacedName

    /// <summary>
    /// Per Square Giga Electron Volt Unit is a denominator unit with dimensions /GeV².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#ReciprocalSquareGigaElectronVolt"></see></summary>
    let ReciprocalSquareGigaElectronVolt =
        Namespaced_IRI.parse _namespace_name "ReciprocalSquareGigaElectronVolt" |> NamespacedName

    /// <summary>
    /// "Revolution per Minute" is a unit for  'Angular Velocity' expressed as rev/min.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#RevolutionPerMinute"></see></summary>
    let RevolutionPerMinute =
        Namespaced_IRI.parse _namespace_name "RevolutionPerMinute" |> NamespacedName

    /// <summary>
    /// Second per metre.
    /// <see href="https://w3id.org/emmo#SecondPerMetre"></see></summary>
    let SecondPerMetre =
        Namespaced_IRI.parse _namespace_name "SecondPerMetre" |> NamespacedName

    /// <summary>
    /// Second per radian and cubic metre unit.
    /// <see href="https://w3id.org/emmo#SecondPerRadianCubicMetre"></see></summary>
    let SecondPerRadianCubicMetre =
        Namespaced_IRI.parse _namespace_name "SecondPerRadianCubicMetre" |> NamespacedName

    /// <summary>
    /// Metre to the power of six.
    /// <see href="https://w3id.org/emmo#SexticMetre"></see></summary>
    let SexticMetre =
        Namespaced_IRI.parse _namespace_name "SexticMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit Siemens divided by the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SiemensPerCentiMetre"></see></summary>
    let SiemensPerCentiMetre =
        Namespaced_IRI.parse _namespace_name "SiemensPerCentiMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit siemens divided by the SI base unit metre.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SiemensPerMetre"></see></summary>
    let SiemensPerMetre =
        Namespaced_IRI.parse _namespace_name "SiemensPerMetre" |> NamespacedName

    /// <summary>
    /// Siemens square metre per mole.
    /// <see href="https://w3id.org/emmo#SiemensSquareMetrePerMole"></see></summary>
    let SiemensSquareMetrePerMole =
        Namespaced_IRI.parse _namespace_name "SiemensSquareMetrePerMole" |> NamespacedName

    /// <summary>
    /// A unit of area equal to that of a square, of sides 1cm
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareCentiMetre"></see></summary>
    let SquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "SquareCentiMetre" |> NamespacedName

    /// <summary>
    /// "Square centimeter minute" is a unit for  'Area Time' expressed as cm² . m.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareCentiMetreMinute"></see></summary>
    let SquareCentiMetreMinute =
        Namespaced_IRI.parse _namespace_name "SquareCentiMetreMinute" |> NamespacedName

    /// <summary>
    /// Square centimetre per cubic centimetre.
    /// <see href="https://w3id.org/emmo#SquareCentiMetrePerCubicCentiMetre"></see></summary>
    let SquareCentiMetrePerCubicCentiMetre =
        Namespaced_IRI.parse _namespace_name "SquareCentiMetrePerCubicCentiMetre" |> NamespacedName

    /// <summary>
    /// Square centimetre per second.
    /// <see href="https://w3id.org/emmo#SquareCentiMetrePerSecond"></see></summary>
    let SquareCentiMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "SquareCentiMetrePerSecond" |> NamespacedName

    /// <summary>
    /// "Square Centimeter Second" is a C.G.S System unit for  'Area Time' expressed as cm² . s.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareCentiMetreSecond"></see></summary>
    let SquareCentiMetreSecond =
        Namespaced_IRI.parse _namespace_name "SquareCentiMetreSecond" |> NamespacedName

    /// <summary>
    /// "Square Coulomb Square Meter per Joule" is a unit for  'Polarizability' expressed as C² m² J⁻¹.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareCoulombSquareMetrePerJoule"></see></summary>
    let SquareCoulombSquareMetrePerJoule =
        Namespaced_IRI.parse _namespace_name "SquareCoulombSquareMetrePerJoule" |> NamespacedName

    /// <summary>
    /// 0.1-fold of the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareDeciMetre"></see></summary>
    let SquareDeciMetre =
        Namespaced_IRI.parse _namespace_name "SquareDeciMetre" |> NamespacedName

    /// <summary>
    /// A square degree is a non-SI unit measure of solid angle. It is denoted in various ways, including deg, sq. deg. and °². Just as degrees are used to measure parts of a circle, square degrees are used to measure parts of a sphere. Analogous to one degree being equal to π /180 radians, a square degree is equal to (π /180) or about 1/3283 steradian. The number of square degrees in a whole sphere is or approximately 41 253 deg. This is the total area of the 88 constellations in the list of constellations by area. For example, observed from the surface of the Earth, the Moon has a diameter of approximately 0.5°, so it covers a solid angle of approximately 0.196 deg, which is 4.8 × 10 of the total sky sphere.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareDegree"></see></summary>
    let SquareDegree =
        Namespaced_IRI.parse _namespace_name "SquareDegree" |> NamespacedName

    /// <summary>
    /// Square degree Celsius per second.
    /// <see href="https://w3id.org/emmo#SquareDegreeCelsiusPerSecond"></see></summary>
    let SquareDegreeCelsiusPerSecond =
        Namespaced_IRI.parse _namespace_name "SquareDegreeCelsiusPerSecond" |> NamespacedName

    /// <summary>
    /// Square Kelvin.
    /// <see href="https://w3id.org/emmo#SquareKelvin"></see></summary>
    let SquareKelvin =
        Namespaced_IRI.parse _namespace_name "SquareKelvin" |> NamespacedName

    /// <summary>
    /// Square kilogram per square second.
    /// <see href="https://w3id.org/emmo#SquareKilogramPerSquareSecond"></see></summary>
    let SquareKilogramPerSquareSecond =
        Namespaced_IRI.parse _namespace_name "SquareKilogramPerSquareSecond" |> NamespacedName

    /// <summary>
    /// The S I unit of area is the square metre.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetre"></see></summary>
    let SquareMetre =
        Namespaced_IRI.parse _namespace_name "SquareMetre" |> NamespacedName

    /// <summary>
    /// Square metre and cubic Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetreCubicHertz"></see></summary>
    let SquareMetreCubicHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetreCubicHertz" |> NamespacedName

    /// <summary>
    /// Square metre Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetreHertz"></see></summary>
    let SquareMetreHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetreHertz" |> NamespacedName

    /// <summary>
    /// `Square Meter Kelvin` is a unit for 'Area Temperature' expressed as m²-K.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetreKelvin"></see></summary>
    let SquareMetreKelvin =
        Namespaced_IRI.parse _namespace_name "SquareMetreKelvin" |> NamespacedName

    /// <summary>
    /// `Square Meter Kelvin per Watt` is a unit for 'Thermal Insulance' expressed as (K²)m/W.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetreKelvinPerWatt"></see></summary>
    let SquareMetreKelvinPerWatt =
        Namespaced_IRI.parse _namespace_name "SquareMetreKelvinPerWatt" |> NamespacedName

    /// <summary>
    /// A unit in the category of specific area.
    /// <see href="https://w3id.org/emmo#SquareMetrePerGram"></see></summary>
    let SquareMetrePerGram =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerGram" |> NamespacedName

    /// <summary>
    /// Square metres per hectare.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerHectare"></see></summary>
    let SquareMetrePerHectare =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerHectare" |> NamespacedName

    /// <summary>
    /// Square metre per Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetrePerHertz"></see></summary>
    let SquareMetrePerHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerHertz" |> NamespacedName

    /// <summary>
    /// Square metre per Hertz and angular degree unit.
    /// <see href="https://w3id.org/emmo#SquareMetrePerHertzPerDegree"></see></summary>
    let SquareMetrePerHertzPerDegree =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerHertzPerDegree" |> NamespacedName

    /// <summary>
    /// Square metre per Joule.
    /// <see href="https://w3id.org/emmo#SquareMetrePerJoule"></see></summary>
    let SquareMetrePerJoule =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerJoule" |> NamespacedName

    /// <summary>
    /// Square metre per Kelvin.
    /// <see href="https://w3id.org/emmo#SquareMetrePerKelvin"></see></summary>
    let SquareMetrePerKelvin =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerKelvin" |> NamespacedName

    /// <summary>
    /// Square Meter Per Kilogram (m2/kg) is a unit in the category of Specific Area. It is also known as square meters per kilogram, square metre per kilogram, square metres per kilogram, square meter/kilogram, square metre/kilogram. This unit is commonly used in the SI unit system. Square Meter Per Kilogram (m2/kg) has a dimension of M-1L2 where M is mass, and L is length. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerKilogram"></see></summary>
    let SquareMetrePerKilogram =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerKilogram" |> NamespacedName

    /// <summary>
    /// Square Meter Per Mole (m2/mol) is a unit in the category of Specific Area. It is also known as square meters per mole, square metre per per, square metres per per, square meter/per, square metre/per. This unit is commonly used in the SI unit system. Square Meter Per Mole (m2/mol) has a dimension of M-1L2 where M is mass, and L is length. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerMole"></see></summary>
    let SquareMetrePerMole =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerMole" |> NamespacedName

    /// <summary>
    /// power of the SI base unit metre with the exponent 2 divided by the derived SI unit newton
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerNewton"></see></summary>
    let SquareMetrePerNewton =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerNewton" |> NamespacedName

    /// <summary>
    /// Square Metres per second is the SI derived unit of angular momentum, defined by distance or displacement in metres multiplied by distance again in metres and divided by time in seconds. The unit is written in symbols as m2/s or m2u00b7s-1 or m2s-1. It may be better understood when phrased as "metres per second times metres", i.e. the momentum of an object with respect to a position.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerSecond"></see></summary>
    let SquareMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSecond" |> NamespacedName

    /// <summary>
    /// Square metres per square Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetrePerSquareHertz"></see></summary>
    let SquareMetrePerSquareHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSquareHertz" |> NamespacedName

    /// <summary>
    /// A square metre unit of area per square metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetrePerSquareMetre"></see></summary>
    let SquareMetrePerSquareMetre =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSquareMetre" |> NamespacedName

    /// <summary>
    /// Square metre per square second.
    /// <see href="https://w3id.org/emmo#SquareMetrePerSquareSecond"></see></summary>
    let SquareMetrePerSquareSecond =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSquareSecond" |> NamespacedName

    /// <summary>
    /// Square metre per steradian.
    /// <see href="https://w3id.org/emmo#SquareMetrePerSteradian"></see></summary>
    let SquareMetrePerSteradian =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSteradian" |> NamespacedName

    /// <summary>
    /// Square metre per steradian and Joule.
    /// <see href="https://w3id.org/emmo#SquareMetrePerSteradianJoule"></see></summary>
    let SquareMetrePerSteradianJoule =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerSteradianJoule" |> NamespacedName

    /// <summary>
    /// Square metre per volt second.
    /// <see href="https://w3id.org/emmo#SquareMetrePerVoltSecond"></see></summary>
    let SquareMetrePerVoltSecond =
        Namespaced_IRI.parse _namespace_name "SquareMetrePerVoltSecond" |> NamespacedName

    /// <summary>
    /// Square metre and quartic Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetreQuarticHertz"></see></summary>
    let SquareMetreQuarticHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetreQuarticHertz" |> NamespacedName

    /// <summary>
    /// Square metre seconds per radian.
    /// <see href="https://w3id.org/emmo#SquareMetreSecondPerRadian"></see></summary>
    let SquareMetreSecondPerRadian =
        Namespaced_IRI.parse _namespace_name "SquareMetreSecondPerRadian" |> NamespacedName

    /// <summary>
    /// Square metre and square Hertz.
    /// <see href="https://w3id.org/emmo#SquareMetreSquareHertz"></see></summary>
    let SquareMetreSquareHertz =
        Namespaced_IRI.parse _namespace_name "SquareMetreSquareHertz" |> NamespacedName

    /// <summary>
    /// "Square Meter Steradian" is a unit for  'Area Angle' expressed as m²-sr.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMetreSteradian"></see></summary>
    let SquareMetreSteradian =
        Namespaced_IRI.parse _namespace_name "SquareMetreSteradian" |> NamespacedName

    /// <summary>
    /// 0.000000000001-fold of the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMicroMetre"></see></summary>
    let SquareMicroMetre =
        Namespaced_IRI.parse _namespace_name "SquareMicroMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the power of the SI base unit metre with the exponent 2
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMilliMetre"></see></summary>
    let SquareMilliMetre =
        Namespaced_IRI.parse _namespace_name "SquareMilliMetre" |> NamespacedName

    /// <summary>
    /// 0.000001-fold of the power of the SI base unit metre with the exponent 2 divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareMilliMetrePerSecond"></see></summary>
    let SquareMilliMetrePerSecond =
        Namespaced_IRI.parse _namespace_name "SquareMilliMetrePerSecond" |> NamespacedName

    /// <summary>
    /// A unit of area equal to that of a square, of sides 1nm
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareNanoMetre"></see></summary>
    let SquareNanoMetre =
        Namespaced_IRI.parse _namespace_name "SquareNanoMetre" |> NamespacedName

    /// <summary>
    /// Square Pascal per square second.
    /// <see href="https://w3id.org/emmo#SquarePascalPerSquareSecond"></see></summary>
    let SquarePascalPerSquareSecond =
        Namespaced_IRI.parse _namespace_name "SquarePascalPerSquareSecond" |> NamespacedName

    /// <summary>
    /// Square Pascal Second (Pa²· s) is a unit in the category of sound exposure.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquarePascalSecond"></see></summary>
    let SquarePascalSecond =
        Namespaced_IRI.parse _namespace_name "SquarePascalSecond" |> NamespacedName

    /// <summary>
    /// "Square Second" is a unit for  'Square Time' expressed as s².
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#SquareSecond"></see></summary>
    let SquareSecond =
        Namespaced_IRI.parse _namespace_name "SquareSecond" |> NamespacedName

    /// <summary>
    /// Square volt per square Kelvin.
    /// <see href="https://w3id.org/emmo#SquareVoltPerSquareKelvin"></see></summary>
    let SquareVoltPerSquareKelvin =
        Namespaced_IRI.parse _namespace_name "SquareVoltPerSquareKelvin" |> NamespacedName

    /// <summary>
    /// 1,000-fold of the SI base unit kilogram
    ///
    /// -- QUDT
    /// A non-SI unit defined as 1000 kg.
    /// <see href="https://w3id.org/emmo#Tonne"></see></summary>
    let Tonne = Namespaced_IRI.parse _namespace_name "Tonne" |> NamespacedName

    /// <summary>
    /// unit tonne divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerCubicMetre"></see></summary>
    let TonnePerCubicMetre =
        Namespaced_IRI.parse _namespace_name "TonnePerCubicMetre" |> NamespacedName

    /// <summary>
    /// metric unit ton divided by the unit for time day
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerDay"></see></summary>
    let TonnePerDay =
        Namespaced_IRI.parse _namespace_name "TonnePerDay" |> NamespacedName

    /// <summary>
    /// A measure of density equivalent to 1000kg per hectare or one Megagram per hectare, typically used to express a volume of biomass or crop yield.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerHectare"></see></summary>
    let TonnePerHectare =
        Namespaced_IRI.parse _namespace_name "TonnePerHectare" |> NamespacedName

    /// <summary>
    /// unit tonne divided by the unit for time hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerHour"></see></summary>
    let TonnePerHour =
        Namespaced_IRI.parse _namespace_name "TonnePerHour" |> NamespacedName

    /// <summary>
    /// unit ton divided by the unit for time minute
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerMinute"></see></summary>
    let TonnePerMinute =
        Namespaced_IRI.parse _namespace_name "TonnePerMinute" |> NamespacedName

    /// <summary>
    /// unit tonne divided by the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#TonnePerSecond"></see></summary>
    let TonnePerSecond =
        Namespaced_IRI.parse _namespace_name "TonnePerSecond" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit volt and the SI base unit ampere
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltAmpere"></see></summary>
    let VoltAmpere = Namespaced_IRI.parse _namespace_name "VoltAmpere" |> NamespacedName

    /// <summary>
    /// product of the unit for apparent by ampere and the unit hour
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltAmpereHour"></see></summary>
    let VoltAmpereHour =
        Namespaced_IRI.parse _namespace_name "VoltAmpereHour" |> NamespacedName

    /// <summary>
    /// derived SI unit volt divided by the 0.01-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerCentiMetre"></see></summary>
    let VoltPerCentiMetre =
        Namespaced_IRI.parse _namespace_name "VoltPerCentiMetre" |> NamespacedName

    /// <summary>
    /// Volt per Kelvin.
    /// <see href="https://w3id.org/emmo#VoltPerKelvin"></see></summary>
    let VoltPerKelvin =
        Namespaced_IRI.parse _namespace_name "VoltPerKelvin" |> NamespacedName

    /// <summary>
    /// Volt Per Meter (V/m) is a unit in the category of Electric field strength. It is also known as volts per meter, volt/meter, volt/metre, volt per metre, volts per metre. This unit is commonly used in the SI unit system. Volt Per Meter (V/m) has a dimension of MLT⁻³I⁻¹ where M is mass, L is length, T is time, and I is electric current. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerMetre"></see></summary>
    let VoltPerMetre =
        Namespaced_IRI.parse _namespace_name "VoltPerMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit volt divided by the 0.000001-fold of the SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerMicroSecond"></see></summary>
    let VoltPerMicroSecond =
        Namespaced_IRI.parse _namespace_name "VoltPerMicroSecond" |> NamespacedName

    /// <summary>
    /// SI derived unit volt divided by the 0.001-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerMilliMetre"></see></summary>
    let VoltPerMilliMetre =
        Namespaced_IRI.parse _namespace_name "VoltPerMilliMetre" |> NamespacedName

    /// <summary>
    /// 'Volt per Second' is a unit of magnetic flux equaling one weber. This is the flux passing through a conducting loop and reduced to zero at a uniform rate in one second inducing an electric potential of one volt in the loop.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerSecond"></see></summary>
    let VoltPerSecond =
        Namespaced_IRI.parse _namespace_name "VoltPerSecond" |> NamespacedName

    /// <summary>
    /// The divergence at a particular point in a vector field is (roughly) how much the vector field 'spreads out' from that point. Operationally, we take the partial derivative of each of the field with respect to each of its space variables and add all the derivatives together to get the divergence. Electric field (V/m) differentiated with respect to distance (m) yields V/(m²).
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltPerSquareMetre"></see></summary>
    let VoltPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "VoltPerSquareMetre" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit volt and the SI base unit second divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#VoltSecondPerMetre"></see></summary>
    let VoltSecondPerMetre =
        Namespaced_IRI.parse _namespace_name "VoltSecondPerMetre" |> NamespacedName

    /// <summary>
    /// A unit of specific energy commonly used to measure the density of energy in batteries and capacitors.
    /// <see href="https://w3id.org/emmo#WattHourPerKilogram"></see></summary>
    let WattHourPerKilogram =
        Namespaced_IRI.parse _namespace_name "WattHourPerKilogram" |> NamespacedName

    /// <summary>
    /// A unit of energy density commonly used to measure the density of energy in batteries and capacitors.
    /// <see href="https://w3id.org/emmo#WattHourPerLitre"></see></summary>
    let WattHourPerLitre =
        Namespaced_IRI.parse _namespace_name "WattHourPerLitre" |> NamespacedName

    /// <summary>
    /// The power per unit area of radiation of a given wavenumber illuminating a target at a given incident angle.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattMetrePerSquareMetreSteradian"></see></summary>
    let WattMetrePerSquareMetreSteradian =
        Namespaced_IRI.parse _namespace_name "WattMetrePerSquareMetreSteradian" |> NamespacedName

    /// <summary>
    /// SI derived unit watt divided by the power of the SI base unit metre with the exponent 3
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerCubicMetre"></see></summary>
    let WattPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "WattPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Watt Per Kelvin (W/K) is a unit in the category of Thermal conductivity.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerKelvin"></see></summary>
    let WattPerKelvin =
        Namespaced_IRI.parse _namespace_name "WattPerKelvin" |> NamespacedName

    /// <summary>
    /// SI derived unit watt divided by the SI base unit kilogram
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerKilogram"></see></summary>
    let WattPerKilogram =
        Namespaced_IRI.parse _namespace_name "WattPerKilogram" |> NamespacedName

    /// <summary>
    /// A unit for power per volume quantities.
    /// <see href="https://w3id.org/emmo#WattPerLitre"></see></summary>
    let WattPerLitre =
        Namespaced_IRI.parse _namespace_name "WattPerLitre" |> NamespacedName

    /// <summary>
    /// Watts per metre.
    /// <see href="https://w3id.org/emmo#WattPerMetre"></see></summary>
    let WattPerMetre =
        Namespaced_IRI.parse _namespace_name "WattPerMetre" |> NamespacedName

    /// <summary>
    /// Watt per metre and Kelvin unit.
    /// <see href="https://w3id.org/emmo#WattPerMetreKelvin"></see></summary>
    let WattPerMetreKelvin =
        Namespaced_IRI.parse _namespace_name "WattPerMetreKelvin" |> NamespacedName

    /// <summary>
    /// Watt Per Square Centimeter is a unit of heat flux or thermal flux, the rate of heat energy transfer through a given surface.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareCentiMetre"></see></summary>
    let WattPerSquareCentiMetre =
        Namespaced_IRI.parse _namespace_name "WattPerSquareCentiMetre" |> NamespacedName

    /// <summary>
    /// "Watt per Square Meter} is a unit of irradiance defined as the power received per area. This is a unit in the category of Energy flux. It is also known as watts per square meter, watt per square metre, watts per square metre, watt/square meter, watt/square metre. This unit is commonly used in the SI unit system. Watt Per Square Meter (W/m²) has a dimension of MT^{-3" where M is mass, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareMetre"></see></summary>
    let WattPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetre" |> NamespacedName

    /// <summary>
    /// `Watt Per Square Meter Per Kelvin `(W m⁻² K⁻¹) is a unit in the category of Thermal heat transfer coefficient. It is also known as watt/square meter-kelvin. This unit is commonly used in the SI unit system. Watt Per Square Meter Per Kelvin (W m⁻² K⁻¹) has a dimension of MT⁻¹Q⁻¹ where M is mass, T is time, and Q is temperature. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareMetreKelvin"></see></summary>
    let WattPerSquareMetreKelvin =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetreKelvin" |> NamespacedName

    /// <summary>
    /// Watt Per Square Meter Per Pascal (W/m²-pa) is a unit of Evaporative Heat Transfer.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareMetrePascal"></see></summary>
    let WattPerSquareMetrePascal =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetrePascal" |> NamespacedName

    /// <summary>
    /// Watts per square metre per metre.
    /// <see href="https://w3id.org/emmo#WattPerSquareMetrePerMetre"></see></summary>
    let WattPerSquareMetrePerMetre =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetrePerMetre" |> NamespacedName

    /// <summary>
    /// Watts per square metre and metre and steradian.
    /// <see href="https://w3id.org/emmo#WattPerSquareMetrePerMetrePerSteradian"></see></summary>
    let WattPerSquareMetrePerMetrePerSteradian =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetrePerMetrePerSteradian" |> NamespacedName

    /// <summary>
    /// Watt per square metre and nanometre.
    /// <see href="https://w3id.org/emmo#WattPerSquareMetrePerNanoMetre"></see></summary>
    let WattPerSquareMetrePerNanoMetre =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetrePerNanoMetre" |> NamespacedName

    /// <summary>
    /// Watt per square metre and nanometre and steradian unit.
    /// <see href="https://w3id.org/emmo#WattPerSquareMetrePerNanoMetrePerSteradian"></see></summary>
    let WattPerSquareMetrePerNanoMetrePerSteradian =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetrePerNanoMetrePerSteradian" |> NamespacedName

    /// <summary>
    /// Watt Per Square Meter Per Quartic Kelvin (W/m2·K4) is a unit in the category of light.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareMetreQuarticKelvin"></see></summary>
    let WattPerSquareMetreQuarticKelvin =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetreQuarticKelvin" |> NamespacedName

    /// <summary>
    /// `Watt per steradian per square metre` is the SI unit of radiance (W·sr⁻¹·m⁻²), while that of spectral radiance in frequency is the watt per steradian per square metre per hertz (W·sr⁻¹·m⁻²·Hz⁻¹) and that of spectral radiance in wavelength is the watt per steradian per square metre, per metre (W·sr⁻¹·m⁻³), commonly the watt per steradian per square metre per nanometre (W·sr⁻¹·m⁻²·nm⁻¹). It has a dimension of ML⁻⁴T⁻³ where M is mass, L is length, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSquareMetreSteradian"></see></summary>
    let WattPerSquareMetreSteradian =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetreSteradian" |> NamespacedName

    /// <summary>
    /// `Watt Per Steradian (W/sr)` is the unit in the category of Radiant intensity. It is also known as watts per steradian. This unit is commonly used in the SI unit system. Watt Per Steradian (W/sr) has a dimension of M· L⁻²· T⁻³ where M is mass, L is length, and T is time. This unit is the standard SI unit in this category.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattPerSteradian"></see></summary>
    let WattPerSteradian =
        Namespaced_IRI.parse _namespace_name "WattPerSteradian" |> NamespacedName

    /// <summary>
    /// product of the SI derived unit watt and SI base unit second
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WattSecond"></see></summary>
    let WattSecond = Namespaced_IRI.parse _namespace_name "WattSecond" |> NamespacedName

    /// <summary>
    /// Watt second per square metre.
    /// <see href="https://w3id.org/emmo#WattSecondPerSquareMetre"></see></summary>
    let WattSecondPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "WattSecondPerSquareMetre" |> NamespacedName

    /// <summary>
    /// The watt hour is a unit of energy, equal to 3,600 joule.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#Watthour"></see></summary>
    let Watthour = Namespaced_IRI.parse _namespace_name "Watthour" |> NamespacedName

    /// <summary>
    /// The watt hour per cubic meter is a unit of energy density, equal to 3,600 joule per cubic meter.
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WatthourPerCubicMetre"></see></summary>
    let WatthourPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "WatthourPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Weber metre.
    /// <see href="https://w3id.org/emmo#WeberMetre"></see></summary>
    let WeberMetre = Namespaced_IRI.parse _namespace_name "WeberMetre" |> NamespacedName

    /// <summary>
    /// SI derived unit weber divided by the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WeberPerMetre"></see></summary>
    let WeberPerMetre =
        Namespaced_IRI.parse _namespace_name "WeberPerMetre" |> NamespacedName

    /// <summary>
    /// derived SI unit weber divided by the 0.001-fold of the SI base unit metre
    ///
    /// -- QUDT
    /// <see href="https://w3id.org/emmo#WeberPerMilliMetre"></see></summary>
    let WeberPerMilliMetre =
        Namespaced_IRI.parse _namespace_name "WeberPerMilliMetre" |> NamespacedName
