namespace http.ns.inria.fr.semed.eduprogression.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eduprog =
    let _namespace_iri = Namespace_Iri eduprog |> NamespaceIRI
    /// <summary>
    ///   <para>eduprog:v1#Course</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In the French educational system, skills that students are expected to develop, are defined by cycle and each cycle is organized into course.</para>
    /// labels<para>Course </para><para>Cours</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#Course">http://ns.inria.fr/semed/eduprogression/v1#Course</seealso>
    let ``v1#Course`` = Prefixed_Name(eduprog, "v1#Course") |> PrefixedName
    /// <summary>
    ///   <para>eduprog:v1#Knowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is represented by class Knowledge and each of its instances is a skos:Concept that is part of a skos:ConceptScheme that contains all the knowledge pieces of a given progression. An instance of EKS is related to an instance of Knowledge through property hasKnowledge.</para>
    /// labels<para>Connaissance</para><para>Knowledge </para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#Knowledge">http://ns.inria.fr/semed/eduprogression/v1#Knowledge</seealso>
    let ``v1#Knowledge`` = Prefixed_Name(eduprog, "v1#Knowledge") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#LearningDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A learning domain is represented by an instance of the LearningDomain class, and it is also an instance of skos:Concept that is part of (only) one skos:ConceptScheme containing the only learning domains of a progression. Also, as they are SKOS concepts, learning domains are hierarchically structured by using the skos:broader and/or skos:narrower properties. A learning domain can be associated to a Progression or to an EKS.</para>
    /// labels<para>Domaine d'enseignement</para><para>Learning domain</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#LearningDomain">http://ns.inria.fr/semed/eduprogression/v1#LearningDomain</seealso>
    let ``v1#LearningDomain`` =
        Prefixed_Name(eduprog, "v1#LearningDomain") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#Progression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A progression is represented by an instance of class Progression. It can be further described by using the Dublin Core or RDFS vocabularies. A progression can be associated to an existing learning domain (through the hasLearningDomain property) and to one or several EKSs (through the hasEKS property).</para>
    /// labels<para>Progression</para><para>Progression</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#Progression">http://ns.inria.fr/semed/eduprogression/v1#Progression</seealso>
    let ``v1#Progression`` = Prefixed_Name(eduprog, "v1#Progression") |> PrefixedName
    /// <summary>
    ///   <para>eduprog:v1#hasCourse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of EKS to an instance of Course.</para>
    /// labels<para>Has course</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasCourse">http://ns.inria.fr/semed/eduprogression/v1#hasCourse</seealso>
    let ``v1#hasCourse`` = Prefixed_Name(eduprog, "v1#hasCourse") |> PrefixedName
    /// <summary>
    ///   <para>eduprog:v1#hasKnowledge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of EKS to an instance of Knowledge.</para>
    /// labels<para>Has knowledge</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasKnowledge">http://ns.inria.fr/semed/eduprogression/v1#hasKnowledge</seealso>
    let ``v1#hasKnowledge`` = Prefixed_Name(eduprog, "v1#hasKnowledge") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#hasRelatedResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates an instance of a class with a resource on DBpedia</para>
    /// labels<para>Has realted resource on DBpedia</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasRelatedResource">http://ns.inria.fr/semed/eduprogression/v1#hasRelatedResource</seealso>
    let ``v1#hasRelatedResource`` =
        Prefixed_Name(eduprog, "v1#hasRelatedResource") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#hasVocabularyItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of EKS to an instance of the class VocabularyItem.</para>
    /// labels<para>Has a vocabulary item</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasVocabularyItem">http://ns.inria.fr/semed/eduprogression/v1#hasVocabularyItem</seealso>
    let ``v1#hasVocabularyItem`` =
        Prefixed_Name(eduprog, "v1#hasVocabularyItem") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The EduProgression ontology formalizes the educational progressions of the French educational system, making possible to represent the existing progressions in a standard formal model, searchable and understandable by machines (OWL).</para>
    /// </remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1">http://ns.inria.fr/semed/eduprogression/v1</seealso>
    let v1 = Prefixed_Name(eduprog, "v1") |> PrefixedName
    /// <summary>
    ///   <para>eduprog:v1#EKS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An element of knowledge and skills is an instance of this class and it is associated to a set of knowledge pieces (class Knowledge) and skills (class Skill) for a specific French school cycle (class Course) containing reference points (class PointOfReference) and also a vocabulary of associated terms (class Vocabulary).</para>
    /// labels<para>Element de connaissances et de competences</para><para>Element of knowledge and skills </para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#EKS">http://ns.inria.fr/semed/eduprogression/v1#EKS</seealso>
    let ``v1#EKS`` = Prefixed_Name(eduprog, "v1#EKS") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#PointOfReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An instance of class PointOfReference represents an educational reference element on a specific element of knowledge and skills (an instance of EKS). An instance of EKS is related to an instance of class PointOfReference through the property hasPointOfReference.</para>
    /// labels<para>Point of reference</para><para>Repère</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#PointOfReference">http://ns.inria.fr/semed/eduprogression/v1#PointOfReference</seealso>
    let ``v1#PointOfReference`` =
        Prefixed_Name(eduprog, "v1#PointOfReference") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is represented by class Skill and described as well by using the Dublin Core and RDFS vocabularies. An instance of EKS is related to an instance of Skill through property hasSkill.</para>
    /// labels<para>Competence</para><para>Skill</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#Skill">http://ns.inria.fr/semed/eduprogression/v1#Skill</seealso>
    let ``v1#Skill`` = Prefixed_Name(eduprog, "v1#Skill") |> PrefixedName
    /// <summary>
    ///   <para>eduprog:v1#hasEKS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Allows a progression to be associated to one or several EKSs.</para>
    /// labels<para>Has an associated EKS </para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasEKS">http://ns.inria.fr/semed/eduprogression/v1#hasEKS</seealso>
    let ``v1#hasEKS`` = Prefixed_Name(eduprog, "v1#hasEKS") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#hasLearningDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a learning domain to a Progression or to an EKS.</para>
    /// labels<para>Has a learning sub domain</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasLearningDomain">http://ns.inria.fr/semed/eduprogression/v1#hasLearningDomain</seealso>
    let ``v1#hasLearningDomain`` =
        Prefixed_Name(eduprog, "v1#hasLearningDomain") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#hasPointOfReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of EKS to an instance of class PointOfReference.</para>
    /// labels<para>Has point of reference</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasPointOfReference">http://ns.inria.fr/semed/eduprogression/v1#hasPointOfReference</seealso>
    let ``v1#hasPointOfReference`` =
        Prefixed_Name(eduprog, "v1#hasPointOfReference") |> PrefixedName

    /// <summary>
    ///   <para>eduprog:v1#hasSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an instance of EKS to an instance of Skill.</para>
    /// labels<para>Has skill</para></remarks>
    /// <seealso href="http://ns.inria.fr/semed/eduprogression/v1#hasSkill">http://ns.inria.fr/semed/eduprogression/v1#hasSkill</seealso>
    let ``v1#hasSkill`` = Prefixed_Name(eduprog, "v1#hasSkill") |> PrefixedName
