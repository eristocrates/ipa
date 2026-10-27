#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "DoxAletheia.ResourceDescriptionFramework.dll"
open DoxAletheia.ResourceDescriptionFramework
#load @".paket/load/main.group.fsx"
open System
open IriTools

module owl =
    let _namespace = RdfVocabulary.owl
    let AllDifferent = _namespace.curie "AllDifferent"
    let AllDisjointClasses = _namespace.curie "AllDisjointClasses"
    let AllDisjointProperties = _namespace.curie "AllDisjointProperties"
    let allValuesFrom = _namespace.curie "allValuesFrom"
    let annotatedProperty = _namespace.curie "annotatedProperty"
    let annotatedSource = _namespace.curie "annotatedSource"
    let annotatedTarget = _namespace.curie "annotatedTarget"
    let Annotation = _namespace.curie "Annotation"
    let AnnotationProperty = _namespace.curie "AnnotationProperty"
    let assertionProperty = _namespace.curie "assertionProperty"
    let AsymmetricProperty = _namespace.curie "AsymmetricProperty"
    let Axiom = _namespace.curie "Axiom"
    let backwardCompatibleWith = _namespace.curie "backwardCompatibleWith"
    let bottomDataProperty = _namespace.curie "bottomDataProperty"
    let bottomObjectProperty = _namespace.curie "bottomObjectProperty"
    let cardinality = _namespace.curie "cardinality"
    let Class = _namespace.curie "Class"
    let complementOf = _namespace.curie "complementOf"
    let DataRange = _namespace.curie "DataRange"
    let datatypeComplementOf = _namespace.curie "datatypeComplementOf"
    let DatatypeProperty = _namespace.curie "DatatypeProperty"
    let deprecated = _namespace.curie "deprecated"
    let DeprecatedClass = _namespace.curie "DeprecatedClass"
    let DeprecatedProperty = _namespace.curie "DeprecatedProperty"
    let differentFrom = _namespace.curie "differentFrom"
    let disjointUnionOf = _namespace.curie "disjointUnionOf"
    let disjointWith = _namespace.curie "disjointWith"
    let distinctMembers = _namespace.curie "distinctMembers"
    let equivalentClass = _namespace.curie "equivalentClass"
    let equivalentProperty = _namespace.curie "equivalentProperty"
    let FunctionalProperty = _namespace.curie "FunctionalProperty"
    let hasKey = _namespace.curie "hasKey"
    let hasSelf = _namespace.curie "hasSelf"
    let hasValue = _namespace.curie "hasValue"
    let imports = _namespace.curie "imports"
    let incompatibleWith = _namespace.curie "incompatibleWith"
    let intersectionOf = _namespace.curie "intersectionOf"
    let InverseFunctionalProperty = _namespace.curie "InverseFunctionalProperty"
    let inverseOf = _namespace.curie "inverseOf"
    let IrreflexiveProperty = _namespace.curie "IrreflexiveProperty"
    let maxCardinality = _namespace.curie "maxCardinality"
    let maxQualifiedCardinality = _namespace.curie "maxQualifiedCardinality"
    let members = _namespace.curie "members"
    let minCardinality = _namespace.curie "minCardinality"
    let minQualifiedCardinality = _namespace.curie "minQualifiedCardinality"
    let NamedIndividual = _namespace.curie "NamedIndividual"
    let NegativePropertyAssertion = _namespace.curie "NegativePropertyAssertion"
    let Nothing = _namespace.curie "Nothing"
    let ObjectProperty = _namespace.curie "ObjectProperty"
    let onClass = _namespace.curie "onClass"
    let onDataRange = _namespace.curie "onDataRange"
    let onDatatype = _namespace.curie "onDatatype"
    let oneOf = _namespace.curie "oneOf"
    let onProperties = _namespace.curie "onProperties"
    let onProperty = _namespace.curie "onProperty"
    let Ontology = _namespace.curie "Ontology"
    let OntologyProperty = _namespace.curie "OntologyProperty"
    let priorVersion = _namespace.curie "priorVersion"
    let propertyChainAxiom = _namespace.curie "propertyChainAxiom"
    let propertyDisjointWith = _namespace.curie "propertyDisjointWith"
    let qualifiedCardinality = _namespace.curie "qualifiedCardinality"
    let ReflexiveProperty = _namespace.curie "ReflexiveProperty"
    let Restriction = _namespace.curie "Restriction"
    let sameAs = _namespace.curie "sameAs"
    let someValuesFrom = _namespace.curie "someValuesFrom"
    let sourceIndividual = _namespace.curie "sourceIndividual"
    let SymmetricProperty = _namespace.curie "SymmetricProperty"
    let targetIndividual = _namespace.curie "targetIndividual"
    let targetValue = _namespace.curie "targetValue"
    let Thing = _namespace.curie "Thing"
    let topDataProperty = _namespace.curie "topDataProperty"
    let topObjectProperty = _namespace.curie "topObjectProperty"
    let TransitiveProperty = _namespace.curie "TransitiveProperty"
    let unionOf = _namespace.curie "unionOf"
    let versionInfo = _namespace.curie "versionInfo"
    let versionIRI = _namespace.curie "versionIRI"
    let withRestrictions = _namespace.curie "withRestrictions"
module Set =
    type OneOrMore<'SetElement when 'SetElement: comparison> =
        private
        | OneOrMoreElements of Set<'SetElement>

        static member One(one: 'SetElement) =
            one |> Set.singleton |> OneOrMoreElements

        static member More(one: 'SetElement, more: Set<'SetElement>) =
            more |> Set.add one |> OneOrMoreElements

        static member More(one: 'SetElement) =
            fun (more: Set<'SetElement>) -> OneOrMore.More(one, more)
        static member More(elements: Set<'SetElement>) =
            if Set.isEmpty elements then
                invalidArg (nameof elements) "OneOrMore requires at least one element."

            OneOrMoreElements elements
        member this.elements =
            let (OneOrMoreElements elements) = this
            elements
    and TwoOrMore<'SetElement when 'SetElement: comparison> =
        private
        | TwoOrMoreElements of Set<'SetElement>

        static member private Create(elements: Set<'SetElement>) =
            if Set.count elements < 2 then
                invalidArg (nameof elements) "TwoOrMoreElements requires at least two distinct elements."

            TwoOrMoreElements elements

        static member Two(one: 'SetElement, two: 'SetElement) = Set [ one; two ] |> TwoOrMore.Create

        static member Two(one: 'SetElement) =
            fun (two: 'SetElement) -> TwoOrMore.Two(one, two)

        static member More(one: 'SetElement, two: 'SetElement, more: Set<'SetElement>) =
            more |> Set.add two |> Set.add one |> TwoOrMore.Create

        static member More(one: 'SetElement) =
            fun (two: 'SetElement) -> fun (more: Set<'SetElement>) -> TwoOrMore.More(one, two, more)

        member this.elements =
            let (TwoOrMoreElements elements) = this
            elements
module List =
    type OneOrMore<'ListItem> =
        private
        | OneOrMoreItems of 'ListItem list

        static member One(one: 'ListItem) = OneOrMoreItems [ one ]

        static member More(head: 'ListItem, tail: 'ListItem list) = head :: tail |> OneOrMoreItems
        static member More(tail: 'ListItem list, tip: 'ListItem) = tail @ [ tip ] |> OneOrMoreItems

        static member More(head: 'ListItem) =
            fun (tail: 'ListItem list) -> OneOrMore.More(head, tail)
        static member More(tail: 'ListItem list) =
            fun (tip: 'ListItem) -> OneOrMore.More(tail, tip)

        member this.items =
            let (OneOrMoreItems items) = this
            items
    and TwoOrMore<'ListItem> =
        private
        | TwoOrMoreItems of 'ListItem list

        static member Two(one: 'ListItem, two: 'ListItem) = [ one; two ] |> TwoOrMoreItems

        static member Two(one: 'ListItem) =
            fun (two: 'ListItem) -> TwoOrMore.Two(one, two)

        static member More(one: 'ListItem, two: 'ListItem, more: 'ListItem list) = one :: two :: more |> TwoOrMoreItems

        static member More(one: 'ListItem) =
            fun (two: 'ListItem) -> fun (more: 'ListItem list) -> TwoOrMore.More(one, two, more)
        static member More(more: 'ListItem list) =
            fun (one: 'ListItem) -> fun (two: 'ListItem) -> more @ [ one; two ] |> TwoOrMoreItems

        member this.items =
            let (TwoOrMoreItems items) = this
            items

type NonNegativeInteger = uint32
type FullIRI = IriReference
type PrefixName = string
type AbbreviatedIRI = PrefixedName
type IRI = Iri
type AnnotationSubject = NormativeSubject
type AnnotationValue = BasicNormativeObject
type Datatype = DatatypeIri

type OntologyIRI =
    | OntologyIRI of IRI

    static member op_Implicit(iri: IRI) = OntologyIRI iri
    member this.IRI: IRI =
        match this with
        | OntologyIRI iri -> iri
    static member op_Implicit(ontologyIRI: OntologyIRI) = ontologyIRI.IRI
    member this.identity: string = this.IRI.identity
type VersionIRI =
    | VersionIRI of IRI

    static member op_Implicit(iri: IRI) = VersionIRI iri
    member this.IRI: IRI =
        match this with
        | VersionIRI iri -> iri
    static member op_Implicit(versionIRI: VersionIRI) = versionIRI.IRI
    member this.identity: string = this.IRI.identity
type AnnotationProperty =
    | AnnotationPropertyIRI of IRI

    static member op_Implicit(iri: IRI) = AnnotationPropertyIRI iri
    member this.IRI: IRI =
        match this with
        | AnnotationPropertyIRI iri -> iri
    static member op_Implicit(annotationProperty: AnnotationProperty) = annotationProperty.IRI
    member this.identity: string = this.IRI.identity

type Class =
    | ClassIRI of IRI

    static member op_Implicit(iri: IRI) = ClassIRI iri
    member this.IRI: IRI =
        match this with
        | ClassIRI iri -> iri
    static member op_Implicit(class_: Class) = class_.IRI
    member this.identity: string = this.IRI.identity
type DirectlyImportsDocument = Import of IRI
type Annotation = {
    annotationAnnotations: Set<Annotation>
    annotationProperty: AnnotationProperty
    annotationValue: AnnotationValue
}
type PrefixDeclaration = Prefix of PrefixName * FullIRI

type ObjectProperty =
    | ObjectPropertyIRI of IRI

    static member op_Implicit(iri: IRI) = ObjectPropertyIRI iri
    member this.IRI: IRI =
        match this with
        | ObjectPropertyIRI iri -> iri
    static member op_Implicit(objectProperty: ObjectProperty) = objectProperty.IRI
    member this.identity: string = this.IRI.identity
type DataProperty =
    | DataPropertyIRI of IRI

    static member op_Implicit(iri: IRI) = DataPropertyIRI iri
    member this.IRI: IRI =
        match this with
        | DataPropertyIRI iri -> iri
    static member op_Implicit(dataProperty: DataProperty) = dataProperty.IRI
    member this.identity: string = this.IRI.identity
type NamedIndividual =
    | NamedIndividualIRI of IRI

    static member op_Implicit(iri: IRI) = NamedIndividualIRI iri
    member this.IRI: IRI =
        match this with
        | NamedIndividualIRI iri -> iri
    static member op_Implicit(namedIndividual: NamedIndividual) = namedIndividual.IRI
    member this.identity: string = this.IRI.identity
type AnonymousIndividual =
    | AnonymousIndividualBNode of BNode

    static member op_Implicit(bnode: BNode) = AnonymousIndividualBNode bnode
    member this.BNode: BNode =
        match this with
        | AnonymousIndividualBNode bnode -> bnode
    static member op_Implicit(namedIndividual: AnonymousIndividual) = namedIndividual.BNode
    member this.identity: string = this.BNode.identity

type DataPropertyExpression = DataProperty
type Individual =
    | Individual of NamedIndividual
    | AnonymousIndividual of AnonymousIndividual

type ObjectPropertyExpression =
    | ObjectPropertyExpression of ObjectProperty
    | ObjectInverse of ObjectProperty

type Entity =
    | Class of Class
    | Datatype of Datatype
    | ObjectProperty of ObjectProperty
    | DataProperty of DataProperty
    | AnnotationProperty of AnnotationProperty
    | NamedIndividual of NamedIndividual

type Cardinal =
    | MinimumCardinal of NonNegativeInteger
    | ExactCardinal of NonNegativeInteger
    | MaximumCardinal of NonNegativeInteger

type DatatypeRestriction = {
    datatype: Datatype
    facetValues: Set.OneOrMore<FacetValue>
}
type DataRange =
    | DatatypeRange of Datatype
    | DataIntersection of Set.TwoOrMore<DataRange>
    | DataUnion of Set.TwoOrMore<DataRange>
    | DataComplement of DataRange
    | DataOne of Set.OneOrMore<Literal>
    | DatatypeRestriction of DatatypeRestriction
type ClassExpression =
    | ClassExpression of Class
    | ObjectIntersection of Set.TwoOrMore<ClassExpression>
    | ObjectUnion of Set.TwoOrMore<ClassExpression>
    | ObjectComplement of ClassExpression
    | ObjectOne of Set.OneOrMore<Individual>
    | RestrictionClassExpression of Restriction
and Restriction =
    | ExistentialClassRestriction of ClassExpressionRestriction
    | UniversalClassRestriction of ClassExpressionRestriction
    | IndividualValueRestriction of IndividualRestriction
    | SelfRestriction of ObjectPropertyExpression
    | ExistentialDataRangeRestriction of DataRangeRestriction
    | UniversalDataRangeRestriction of DataRangeRestriction
    | LiteralValueRestriction of LiteralRestriction
    | CardinalityRestriction of CardinalityRestriction
and Cardinality =
    | ObjectCardinality of ObjectPropertyExpression
    | ObjectQualifiedCardinality of ObjectPropertyExpression * ClassExpression
    | DataCardinality of DataPropertyExpression
    | DataQualifiedCardinality of DataPropertyExpression * DataRange
and ClassExpressionRestriction = {
    onObjectProperty: ObjectPropertyExpression
    toClassExpression: ClassExpression
}
and IndividualRestriction = {
    onObjectPropertyExpression: ObjectPropertyExpression
    toIndividual: Individual
}
and DataRangeRestriction = {
    onDataPropertyExpressions: List.OneOrMore<DataPropertyExpression>
    toDataRange: DataRange
}
and LiteralRestriction = {
    onDataPropertyExpressions: DataPropertyExpression
    toLiteral: Literal
}
and CardinalityRestriction = {
    cardinality: Cardinality
    cardinal: Cardinal
}
type Class with
    member this.classExpression = ClassExpression this

type SubClass = {
    axiomAnnotations: Set<Annotation>
    subClassExpression: ClassExpression
    superClassExpression: ClassExpression
}

type EquivalentClasses = {
    axiomAnnotations: Set<Annotation>
    equivalentClasses: Set.TwoOrMore<ClassExpression>
}

type DisjointClasses = {
    axiomAnnotations: Set<Annotation>
    disjointClasses: Set.TwoOrMore<ClassExpression>
}

type DisjointUnion = {
    axiomAnnotations: Set<Annotation>
    disjointClass: Class
    disjointExpressions: Set.TwoOrMore<ClassExpression>
}

type PropertyExpressionChain = {
    objectPropertyChain: List.TwoOrMore<ObjectPropertyExpression>
}

type SubObjectPropertyExpression =
    | SubObjectPropertyExpression of ObjectPropertyExpression
    | PropertyExpressionChain of PropertyExpressionChain
type SubObjectProperty = {
    axiomAnnotations: Set<Annotation>
    subObjectPropertyExpression: SubObjectPropertyExpression
    superObjectPropertyExpression: ObjectPropertyExpression
}
type EquivalentObjectPropertyExpressions = {
    axiomAnnotations: Set<Annotation>
    equivalentObjectProperties: Set.TwoOrMore<ObjectPropertyExpression>
}
type DisjointObjectPropertyExpressions = {
    axiomAnnotations: Set<Annotation>
    disjointObjectProperties: Set.TwoOrMore<ObjectPropertyExpression>
}
type ObjectPropertyDomain = {
    axiomAnnotations: Set<Annotation>
    objectPropertyExpression: ObjectPropertyExpression
    objectPropertyDomain: ClassExpression
}
type ObjectPropertyRange = {
    axiomAnnotations: Set<Annotation>
    objectPropertyExpression: ObjectPropertyExpression
    objectPropertyRange: ClassExpression
}
type InverseObjectProperties = {
    axiomAnnotations: Set<Annotation>
    inverseObjectProperties: ObjectPropertyExpression * ObjectPropertyExpression
}
type FunctionalObjectProperty = {
    axiomAnnotations: Set<Annotation>
    functionalObjectProperty: ObjectPropertyExpression
}
type InverseFunctionalObjectProperty = {
    axiomAnnotations: Set<Annotation>
    inverseFunctionalObjectProperty: ObjectPropertyExpression
}
type ReflexiveObjectProperty = {
    axiomAnnotations: Set<Annotation>
    reflexiveObjectProperty: ObjectPropertyExpression
}
type IrreflexiveObjectProperty = {
    axiomAnnotations: Set<Annotation>
    irreflexiveObjectProperty: ObjectPropertyExpression
}
type SymmetricObjectProperty = {
    axiomAnnotations: Set<Annotation>
    symmetricObjectProperty: ObjectPropertyExpression
}
type AsymmetricObjectProperty = {
    axiomAnnotations: Set<Annotation>
    asymmetricObjectProperty: ObjectPropertyExpression
}
type TransitiveObjectProperty = {
    axiomAnnotations: Set<Annotation>
    transitiveObjectProperty: ObjectPropertyExpression
}
type ObjectPropertyAxiom =
    | SubObjectProperty of SubObjectProperty
    | EquivalentObjectProperties of EquivalentObjectPropertyExpressions
    | DisjointObjectProperties of DisjointObjectPropertyExpressions
    | InverseObjectProperties of InverseObjectProperties
    | ObjectPropertyDomain of ObjectPropertyDomain
    | ObjectPropertyRange of ObjectPropertyRange
    | FunctionalObjectProperty of FunctionalObjectProperty
    | InverseFunctionalObjectProperty of InverseFunctionalObjectProperty
    | ReflexiveObjectProperty of ReflexiveObjectProperty
    | IrreflexiveObjectProperty of IrreflexiveObjectProperty
    | SymmetricObjectProperty of SymmetricObjectProperty
    | AsymmetricObjectProperty of AsymmetricObjectProperty
    | TransitiveObjectProperty of TransitiveObjectProperty
type ClassAxiom =
    | SubClassAxiom of SubClass
    | EquivalentClassesAxiom of EquivalentClasses
    | DisjointClassesAxiom of DisjointClasses
    | DisjointUnionAxiom of DisjointUnion
type SubDataProperty = {
    axiomAnnotations: Set<Annotation>
    subDataPropertyExpression: DataPropertyExpression
    superDataPropertyExpression: DataPropertyExpression
}
type EquivalentDataProperties = {
    axiomAnnotations: Set<Annotation>
    equivalentDataProperties: Set.TwoOrMore<DataPropertyExpression>
}
type DisjointDataProperties = {
    axiomAnnotations: Set<Annotation>
    disjointDataProperties: Set.TwoOrMore<DataPropertyExpression>
}
type DataPropertyDomain = {
    axiomAnnotations: Set<Annotation>
    dataPropertyExpression: DataPropertyExpression
    dataPropertyDomain: ClassExpression
}
type DataPropertyRange = {
    axiomAnnotations: Set<Annotation>
    dataPropertyExpression: DataPropertyExpression
    dataPropertyRange: DataRange
}
type FunctionalDataProperty = {
    axiomAnnotations: Set<Annotation>
    functionalDataProperty: DataPropertyExpression
}
type DataPropertyAxiom =
    | SubDataProperty of SubDataProperty
    | EquivalentDataProperties of EquivalentDataProperties
    | DisjointDataProperties of DisjointDataProperties
    | DataPropertyDomain of DataPropertyDomain
    | DataPropertyRange of DataPropertyRange
    | FunctionalDataProperty of FunctionalDataProperty
type KeyProperties =
    | ObjectDataKeyProperties of Set.OneOrMore<ObjectPropertyExpression> * Set.OneOrMore<DataPropertyExpression>
    | ObjectKeyProperties of Set.OneOrMore<ObjectPropertyExpression>
    | DataKeyProperties of Set.OneOrMore<DataPropertyExpression>
type SameIndividual = {
    axiomAnnotations: Set<Annotation>
    SameIndividual: Set.TwoOrMore<Individual>
}
type DifferentIndividuals = {
    axiomAnnotations: Set<Annotation>
    DifferentIndividuals: Set.TwoOrMore<Individual>
}
type ClassAssertion = {
    axiomAnnotations: Set<Annotation>
    individual: Individual
    classExpression: ClassExpression
}
type ObjectPropertyAssertion = {
    axiomAnnotations: Set<Annotation>
    sourceIndividual: Individual
    objectPropertyExpression: ObjectPropertyExpression
    targetIndividual: Individual
}
type NegativeObjectPropertyAssertion = {
    axiomAnnotations: Set<Annotation>
    sourceIndividual: Individual
    negativeObjectPropertyExpression: ObjectPropertyExpression
    targetIndividual: Individual
}
type DataPropertyAssertion = {
    axiomAnnotations: Set<Annotation>
    sourceIndividual: Individual
    dataPropertyExpression: DataPropertyExpression
    targetValue: Literal
}
type NegativeDataPropertyAssertion = {
    axiomAnnotations: Set<Annotation>
    sourceIndividual: Individual
    negativeDataPropertyExpression: DataPropertyExpression
    targetValue: Literal
}
type Assertion =
    | SameIndividual of SameIndividual
    | DifferentIndividuals of DifferentIndividuals
    | ClassAssertion of ClassAssertion
    | ObjectPropertyAssertion of ObjectPropertyAssertion
    | NegativeObjectPropertyAssertion of NegativeObjectPropertyAssertion
    | DataPropertyAssertion of DataPropertyAssertion
    | NegativeDataPropertyAssertion of NegativeDataPropertyAssertion
type AnnotationAssertion = {
    axiomAnnotations: Set<Annotation>
    annotationSubject: AnnotationSubject
    annotationProperty: AnnotationProperty
    annotationValue: AnnotationValue
}
type SubAnnotationProperty = {
    axiomAnnotations: Set<Annotation>
    subAnnotationProperty: AnnotationProperty
    superAnnotationProperty: AnnotationProperty
}
type AnnotationPropertyDomain = {
    axiomAnnotations: Set<Annotation>
    annotationProperty: AnnotationProperty
    domainIRI: IRI
}
type AnnotationPropertyRange = {
    axiomAnnotations: Set<Annotation>
    annotationProperty: AnnotationProperty
    rangeIRI: IRI
}
type AnnotationAxiom =
    | AnnotationAssertion of AnnotationAssertion
    | SubAnnotationProperty of SubAnnotationProperty
    | AnnotationPropertyDomain of AnnotationPropertyDomain
    | AnnotationPropertyRange of AnnotationPropertyRange
type Declaration = {
    axiomAnnotations: Set<Annotation>
    entity: Entity
}
type DatatypeDefinition = {
    axiomAnnotations: Set<Annotation>
    datatype: Datatype
    dataRange: DataRange
}
type HasKey = {
    axiomAnnotations: Set<Annotation>
    classExpression: ClassExpression
    keyProperties: KeyProperties
}
type Axiom =
    | Declaration of Declaration
    | ClassAxiom of ClassAxiom
    | ObjectPropertyAxiom of ObjectPropertyAxiom
    | DataPropertyAxiom of DataPropertyAxiom
    | DatatypeDefinition of DatatypeDefinition
    | HasKey of HasKey
    | Assertion of Assertion
    | AnnotationAxiom of AnnotationAxiom
type Ontology = {
    ontologyIdentifier: (OntologyIRI * VersionIRI option) option
    directlyImportsDocuments: Set<DirectlyImportsDocument>
    ontologyAnnotations: Set<Annotation>
    axioms: Set<Axiom>
}
type OntologyDocument =
    | OntologyDocument of Set<PrefixDeclaration> * Ontology
    | Ontology of Ontology
type Ontology with
    static member Import(importIRI: DirectlyImportsDocument) =
        fun (ontology: Ontology) -> {
            ontology with
                directlyImportsDocuments = Set.add importIRI ontology.directlyImportsDocuments
        }
    static member Import(directlyImportsDocuments: DirectlyImportsDocument list) =
        fun (ontology: Ontology) -> {
            ontology with
                directlyImportsDocuments =
                    ontology.directlyImportsDocuments
                    |> Set.union (Set.ofList directlyImportsDocuments)
        }
    static member Import(fromOntology: Ontology) =
        fun (toOntology: Ontology) ->
            match fromOntology.ontologyIdentifier with
            | Some(OntologyIRI ontologyIRI, Some(VersionIRI versionIRI)) -> {
                toOntology with
                    directlyImportsDocuments = toOntology.directlyImportsDocuments |> Set.add (Import versionIRI)
              }
            | Some(OntologyIRI ontologyIRI, _) -> {
                toOntology with
                    directlyImportsDocuments = toOntology.directlyImportsDocuments |> Set.add (Import ontologyIRI)
              }
            | _ -> toOntology
type Restriction with

    static member ObjectSomeValuesFrom((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        {
            onObjectProperty = objectPropertyExpression
            toClassExpression = classExpression
        }
        |> ExistentialClassRestriction
    static member ObjectSomeValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectSomeValuesFrom(objectPropertyExpression, classExpression)

    static member ObjectAllValuesFrom((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        {
            onObjectProperty = objectPropertyExpression
            toClassExpression = classExpression
        }
        |> UniversalClassRestriction
    static member ObjectAllValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectAllValuesFrom(objectPropertyExpression, classExpression)

    static member ObjectHasValue((objectPropertyExpression: ObjectPropertyExpression), (individual: Individual)) =
        {
            onObjectPropertyExpression = objectPropertyExpression
            toIndividual = individual
        }
        |> IndividualValueRestriction
    static member ObjectHasValue(individual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectHasValue(objectPropertyExpression, individual)

    static member ObjectHasSelf(objectPropertyExpression: ObjectPropertyExpression) =
        objectPropertyExpression |> SelfRestriction

    // Tupled overloads preserve Restriction Syntax. Curried qualified forms begin
    // with the qualifier, then cardinality, then property expression.
    static member ObjectMinCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        {
            cardinality = ObjectCardinality objectPropertyExpression
            cardinal = MinimumCardinal cardinal
        }
        |> CardinalityRestriction

    static member ObjectMinCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        {
            cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
            cardinal = MinimumCardinal cardinal
        }
        |> CardinalityRestriction
    static member ObjectMinCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression)
    static member ObjectMinCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectMaxCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        {
            cardinality = ObjectCardinality objectPropertyExpression
            cardinal = MaximumCardinal cardinal
        }
        |> CardinalityRestriction
    static member ObjectMaxCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        {
            cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
            cardinal = MaximumCardinal cardinal
        }
        |> CardinalityRestriction
    static member ObjectMaxCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression)
    static member ObjectMaxCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectExactCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        {
            cardinality = ObjectCardinality objectPropertyExpression
            cardinal = ExactCardinal cardinal
        }
        |> CardinalityRestriction
    static member ObjectExactCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        {
            cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
            cardinal = ExactCardinal cardinal
        }
        |> CardinalityRestriction

    static member ObjectExactCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression)
    static member ObjectExactCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)

    static member DataSomeValuesFrom((dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>), (dataRange: DataRange)) =
        {
            onDataPropertyExpressions = dataPropertyExpressions
            toDataRange = dataRange
        }
        |> ExistentialDataRangeRestriction

    static member DataSomeValuesFrom
        ((firstDataPropertyExpression: DataPropertyExpression), (moreDataPropertyExpressions: DataPropertyExpression list), (dataRange: DataRange))
        =
        Restriction.DataSomeValuesFrom(List.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions), dataRange)
    static member DataSomeValuesFrom((dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Restriction.DataSomeValuesFrom(List.OneOrMore.One dataPropertyExpression, dataRange)
    static member DataSomeValuesFrom(dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>) =
        fun (dataRange: DataRange) -> Restriction.DataSomeValuesFrom(dataPropertyExpressions, dataRange)
    static member DataSomeValuesFrom(dataRange: DataRange) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataSomeValuesFrom(dataPropertyExpression, dataRange)

    static member DataAllValuesFrom((dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>), (dataRange: DataRange)) =
        {
            onDataPropertyExpressions = dataPropertyExpressions
            toDataRange = dataRange
        }
        |> UniversalDataRangeRestriction

    static member DataAllValuesFrom
        ((firstDataPropertyExpression: DataPropertyExpression), (moreDataPropertyExpressions: DataPropertyExpression list), (dataRange: DataRange))
        =
        Restriction.DataAllValuesFrom(List.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions), dataRange)
    static member DataAllValuesFrom((dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Restriction.DataAllValuesFrom(List.OneOrMore.One dataPropertyExpression, dataRange)
    static member DataAllValuesFrom(dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>) =
        fun (dataRange: DataRange) -> Restriction.DataAllValuesFrom(dataPropertyExpressions, dataRange)
    static member DataAllValuesFrom(dataRange: DataRange) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataAllValuesFrom(dataPropertyExpression, dataRange)

    static member DataHasValue((dataPropertyExpression: DataPropertyExpression), (literal: Literal)) =
        {
            onDataPropertyExpressions = dataPropertyExpression
            toLiteral = literal
        }
        |> LiteralValueRestriction

    static member DataHasValue(literal: Literal) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataHasValue(dataPropertyExpression, literal)

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        {
            cardinality = DataCardinality dataPropertyExpression
            cardinal = MinimumCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        {
            cardinality = (dataPropertyExpression, dataRange) |> DataQualifiedCardinality
            cardinal = MinimumCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataMinCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataMinCardinality(cardinal, dataPropertyExpression)
    static member DataMinCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataMinCardinality(cardinal, dataPropertyExpression, dataRange)

    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        {
            cardinality = DataCardinality dataPropertyExpression
            cardinal = MaximumCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        {
            cardinality = (dataPropertyExpression, dataRange) |> DataQualifiedCardinality
            cardinal = MaximumCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataMaxCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataMaxCardinality(cardinal, dataPropertyExpression)
    static member DataMaxCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataMaxCardinality(cardinal, dataPropertyExpression, dataRange)

    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        {
            cardinality = DataCardinality dataPropertyExpression
            cardinal = ExactCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        {
            cardinality = (dataPropertyExpression, dataRange) |> DataQualifiedCardinality
            cardinal = ExactCardinal cardinal
        }
        |> CardinalityRestriction

    static member DataExactCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataExactCardinality(cardinal, dataPropertyExpression)
    static member DataExactCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Restriction.DataExactCardinality(cardinal, dataPropertyExpression, dataRange)
