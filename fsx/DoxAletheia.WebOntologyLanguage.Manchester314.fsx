#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "DoxAletheia.ResourceDescriptionFramework.dll"
#r "DoxAletheia.WebOntologyLanguage.dll"
#r "DoxAletheia.WebOntologyLanguage.Functional.dll"
open DoxAletheia.ResourceDescriptionFramework
open DoxAletheia.WebOntologyLanguage
open DoxAletheia.WebOntologyLanguage.Functional

#load @".paket/load/main.group.fsx"
open System
open IriTools

type Polarity =
    | Positive
    | Negative

    static member (!!)(polarity: Polarity) =
        match polarity with
        | Positive -> Negative
        | Negative -> Positive

type DataDescription =
    | DataConjunctionOrDataConjunction of List.TwoOrMore<DataConjunction>
    | DataConjunction of DataConjunction

    member this.dataRange =
        match this with
        | DataConjunctionOrDataConjunction dataConjunctions ->
            Set.TwoOrMore.More
                dataConjunctions.items[0].dataRange
                dataConjunctions.items[1].dataRange
                (dataConjunctions.items[2..]
                 |> List.map (fun item -> item.dataRange)
                 |> Set.ofList)
            |> DataUnion
        | DataConjunction dataConjunction -> dataConjunction.dataRange
and DataConjunction =
    | DataPrimaryAndDataPrimary of List.TwoOrMore<DataPrimary>
    | DataPrimary of DataPrimary

    static member (.||)((one: DataConjunction), (two: DataConjunction)) =
        List.TwoOrMore.Two one two |> DataConjunctionOrDataConjunction
    static member (.||)((dataDescription: DataDescription), (dataConjunction: DataConjunction)) =
        match dataDescription with
        | DataConjunctionOrDataConjunction twoOrMoreDataConjunctions ->
            match twoOrMoreDataConjunctions.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ dataConjunction ])
                |> DataConjunctionOrDataConjunction

            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataConjunction oneDataConjunction ->
            List.TwoOrMore.Two oneDataConjunction dataConjunction
            |> DataConjunctionOrDataConjunction
    static member (.||)((dataConjunction: DataConjunction), (dataDescription: DataDescription)) = dataDescription .|| dataConjunction
    member this.dataRange =
        match this with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            Set.TwoOrMore.More
                dataPrimaries.items[0].dataRange
                dataPrimaries.items[1].dataRange
                (dataPrimaries.items[2..] |> List.map (fun item -> item.dataRange) |> Set.ofList)
            |> DataIntersection
        | DataPrimary dataPrimary -> dataPrimary.dataRange
and DataPrimary = {
    polarity: Polarity
    dataAtomic: DataAtomic
} with

    static member (!!)(primary: DataPrimary) = {
        primary with
            polarity = !!primary.polarity
    }
    static member (.&&)((one: DataPrimary), (two: DataPrimary)) =
        List.TwoOrMore.Two one two |> DataPrimaryAndDataPrimary
    static member and_((one: DataPrimary), (two: DataPrimary)) = one .&& two
    member this._and(dataPrimary: DataPrimary) = this .&& dataPrimary
    member this.dataRange =
        match this.polarity with
        | Positive -> this.dataAtomic.dataRange
        | Negative -> DataComplement this.dataAtomic.dataRange
and DataAtomic =
    | AtomicDatatype of Datatype
    | AtomicLiterals of Set.OneOrMore<Literal>
    | AtomicDatatypeRestriction of DatatypeRestriction
    | AtomicDataDescription of DataDescription

    member this.dataRange =
        match this with
        | AtomicDatatype datatype -> DatatypeRange datatype
        | AtomicLiterals literals -> DataOne literals
        | AtomicDatatypeRestriction datatypeRestriction -> DatatypeRestriction datatypeRestriction
        | AtomicDataDescription dataDescription -> dataDescription.dataRange

type Description =
    | ConjunctionOrConjunction of List.TwoOrMore<Conjunction>
    | Conjunction of Conjunction

    member this.classExpression =
        match this with
        | ConjunctionOrConjunction conjunctions ->
            Set.TwoOrMore.More
                conjunctions.items[0].classExpression
                conjunctions.items[1].classExpression
                (conjunctions.items[2..]
                 |> List.map (fun item -> item.classExpression)
                 |> Set.ofList)
            |> ObjectUnion
        | Conjunction conjunction -> conjunction.classExpression
and Conjunction =
    | ClassThatRestriction of Class * List.OneOrMore<RestrictionPrimary>
    | PrimaryAndPrimary of List.TwoOrMore<Primary>
    | Primary of Primary

    static member (.||)((one: Conjunction), (two: Conjunction)) =
        List.TwoOrMore.Two one two |> ConjunctionOrConjunction
    static member (.||)((description: Description), (conjunction: Conjunction)) =
        match description with
        | ConjunctionOrConjunction twoOrMoreConjunctions ->
            match twoOrMoreConjunctions.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ conjunction ])
                |> ConjunctionOrConjunction

            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Conjunction oneConjunction -> List.TwoOrMore.Two oneConjunction conjunction |> ConjunctionOrConjunction
    static member (.||)((conjunction: Conjunction), (description: Description)) = description .|| conjunction
    member this.classExpression =
        match this with
        | ClassThatRestriction(classIRI, restrictionPrimaries) ->
            match restrictionPrimaries.items with
            | [ restrictionPrimary ] ->
                Set.TwoOrMore.Two classIRI.classExpression restrictionPrimary.classExpression
                |> ObjectIntersection
            | restrictionItems ->
                Set.TwoOrMore.More
                    classIRI.classExpression
                    restrictionItems[0].classExpression
                    (restrictionItems[1..]
                     |> List.map (fun restrictionPrimary -> restrictionPrimary.classExpression)
                     |> Set.ofList)
                |> ObjectIntersection
        | PrimaryAndPrimary primaries ->
            Set.TwoOrMore.More
                primaries.items[0].classExpression
                primaries.items[1].classExpression
                (primaries.items[2..]
                 |> List.map (fun item -> item.classExpression)
                 |> Set.ofList)
            |> ObjectIntersection
        | Primary primary -> primary.classExpression
and Primary =
    | RestrictionPrimary of RestrictionPrimary
    | AtomicPrimary of AtomicPrimary

    static member (.&&)((one: Primary), (two: Primary)) =
        List.TwoOrMore.Two one two |> PrimaryAndPrimary
    member this.classExpression =
        match this with
        | RestrictionPrimary restrictionPrimary -> restrictionPrimary.classExpression
        | AtomicPrimary atomicPrimary -> atomicPrimary.classExpression
and RestrictionPrimary = {
    polarity: Polarity
    restriction: Restriction
} with

    static member ofRestriction(restriction: Restriction) = {
        polarity = Positive
        restriction = restriction
    }
    static member op_Implicit(restriction: Restriction) =
        RestrictionPrimary.ofRestriction restriction

    static member (!!)(restrictionPrimary: RestrictionPrimary) = {
        restrictionPrimary with
            polarity = !!restrictionPrimary.polarity
    }
    static member (.&&)((one: RestrictionPrimary), (two: RestrictionPrimary)) = List.TwoOrMore.Two one two
    member this.classExpression =
        match this.polarity with
        | Positive -> RestrictionClassExpression this.restriction
        | Negative -> ObjectComplement(RestrictionClassExpression this.restriction)
and AtomicPrimary = {
    polarity: Polarity
    atomic: Atomic
} with

    static member (!!)(atomicPrimary: AtomicPrimary) = {
        atomicPrimary with
            polarity = !!atomicPrimary.polarity
    }
    member this.classExpression =
        match this.polarity with
        | Positive -> this.atomic.classExpression
        | Negative -> ObjectComplement this.atomic.classExpression

and Atomic =
    | AtomicClass of Class
    | AtomicIndividuals of Set.OneOrMore<Individual>
    | AtomicDescription of Description

    member this.classExpression =
        match this with
        | AtomicClass classIRI -> ClassExpression classIRI
        | AtomicIndividuals individuals -> ObjectOne individuals
        | AtomicDescription description -> description.classExpression
type ObjectPropertyFact = {
    polarity: Polarity
    objectProperty: ObjectProperty
    individual: Individual
} with

    static member (!!)(objectPropertyFact: ObjectPropertyFact) = {
        objectPropertyFact with
            polarity = !!objectPropertyFact.polarity
    }
type DataPropertyFact = {
    polarity: Polarity
    dataProperty: DataProperty
    literal: Literal
} with

    static member (!!)(dataPropertyFact: DataPropertyFact) = {
        dataPropertyFact with
            polarity = !!dataPropertyFact.polarity
    }
type Fact =
    | ObjectPropertyFact of ObjectPropertyFact
    | DataPropertyFact of DataPropertyFact

    static member (!!)(fact: Fact) =
        match fact with
        | ObjectPropertyFact objectPropertyFact -> ObjectPropertyFact !!objectPropertyFact
        | DataPropertyFact dataPropertyFact -> DataPropertyFact !!dataPropertyFact

type PropertyExpression =
    | ObjectPropertyExpression of ObjectPropertyExpression
    | DataPropertyExpression of DataPropertyExpression
type FunctionalProperty = FunctionalObjectProperty of ObjectProperty
type InverseFunctionalObjectProperty = InverseFunctionalObjectProperty of ObjectProperty
type ReflexiveObjectProperty = ReflexiveObjectProperty of ObjectProperty
type IrreflexiveObjectProperty = IrreflexiveObjectProperty of ObjectProperty
type SymmetricObjectProperty = SymmetricObjectProperty of ObjectProperty
type AsymmetricObjectProperty = AsymmetricObjectProperty of ObjectProperty
type TransitiveObjectProperty = TransitiveObjectProperty of ObjectProperty
type CharacteristicObjectProperty =
    | FunctionalProperty of FunctionalProperty
    | InverseFunctionalProperty of InverseFunctionalObjectProperty
    | ReflexiveProperty of ReflexiveObjectProperty
    | IrreflexiveProperty of IrreflexiveObjectProperty
    | SymmetricProperty of SymmetricObjectProperty
    | AsymmetricProperty of AsymmetricObjectProperty
    | TransitiveProperty of TransitiveObjectProperty

type FunctionalDataProperty = FunctionalDataProperty of DataProperty
type EquivalentDescriptions = {
    equivalentDescriptions: Set.TwoOrMore<Description>
}
type DisjointDescriptions = {
    disjointDescriptions: Set.TwoOrMore<Description>
}
type EquivalentObjectProperties = {
    equivalentObjectProperties: Set.TwoOrMore<ObjectProperty>
}
type DisjointObjectProperties = {
    disjointObjectProperties: Set.TwoOrMore<ObjectProperty>
}
type EquivalentDataRange = { equivalentudataRange: DataRange }
type DatatypeFrame = {
    Datatype: Datatype
    Annotations: Set<Annotation>
    EquivalentTo: EquivalentDataRange option
}
type ClassFrame = {
    Class: Class
    Annotations: Set<Annotation>
    SubClassOf: Set<SubClass>
    EquivalentTo: Set<EquivalentDescriptions>
    DisjointWith: Set<DisjointDescriptions>
    DisjointUnionOf: Set<DisjointUnion>
    HasKey: Set<HasKey>
}
type ObjectPropertyFrame = {
    ObjectProperty: ObjectProperty
    Annotations: Set<Annotation>
    Domain: Set<ObjectPropertyDomain>
    Range: Set<ObjectPropertyRange>
    Characteristics: Set<CharacteristicObjectProperty>
    SubPropertyOf: Set<SubObjectProperty>
    EquivalentTo: Set<EquivalentObjectProperties>
    DisjointWith: Set<DisjointObjectProperties>
    InverseOf: Set<InverseObjectProperties>
    SubPropertyChain: Set<PropertyExpressionChain>
}
type DataPropertyFrame = {
    DataProperty: DataProperty
    Annotations: Set<Annotation>
    Domain: Set<DataPropertyDomain>
    Range: Set<DataPropertyRange>
    Characteristics: Annotated<FunctionalDataProperty> option
    SubPropertyOf: Set<SubDataProperty>
    EquivalentTo: Set<EquivalentDataProperties>
    DisjointWith: Set<DisjointDataProperties>
}
type AnnotationPropertyFrame = {
    AnnotationProperty: AnnotationProperty
    Annotations: Set<Annotation>
    Domain: Set<AnnotationPropertyDomain>
    Range: Set<AnnotationPropertyRange>
    SubPropertyOf: Set<SubAnnotationProperty>
}
type IndividualFrame = {
    Individual: Individual
    Annotations: Set<Annotation>
    Types: Set<ClassExpression>
    Facts: Set<Fact>
    SameAs: Set<SameIndividual>
    DifferentFrom: Set<DifferentIndividuals>
}
type Frame =
    | DatatypeFrame of DatatypeFrame
    | ClassFrame of ClassFrame
    | ObjectPropertyFrame of ObjectPropertyFrame
    | DataPropertyFrame of DataPropertyFrame
    | AnnotationPropertyFrame of AnnotationPropertyFrame
    | IndividualFrame of IndividualFrame

type Manchester =
    static member inverse(objectProperty: ObjectProperty) =
        Functional.ObjectInverseOf objectProperty
type DataConjunction with
    static member or_((one: DataConjunction), (two: DataConjunction)) = one .|| two
    static member or_((one: DataDescription), (two: DataConjunction)) = one .|| two
    static member or_((one: DataConjunction), (two: DataDescription)) = one .|| two
    member this._or(other: DataConjunction) = this .|| other
    member this._or(other: DataDescription) = this .|| other
type DataDescription with
    member this._or(other: DataConjunction) = this .|| other
type RestrictionPrimary with
    static member not(restrictionPrimary: RestrictionPrimary) = !!restrictionPrimary
    member this._not = !!this
    member this._and(other: RestrictionPrimary) = this .&& other
    static member and_((one: RestrictionPrimary), (two: RestrictionPrimary)) = one .&& two
type Conjunction with
    static member or_((one: Conjunction), (two: Conjunction)) = one .|| two
    member this._or(other: Conjunction) = this .|| other
type Polarity with
    static member not(polarity: Polarity) = !!polarity
    member this._not = !!this
type DataPrimary with
    static member not(dataPrimary: DataPrimary) = !!dataPrimary
    member this._not = !!this
type AtomicPrimary with
    static member not(atomicPrimary: AtomicPrimary) = !!atomicPrimary
    member this._not = !!this

type Conjunction with

    static member that((classIRI: Class), (restrictionPrimary: RestrictionPrimary)) =
        ClassThatRestriction(classIRI, List.OneOrMore.One restrictionPrimary)
    static member that((classIRI: Class), (polarity: Polarity), (restriction: Restriction)) =
        Conjunction.that (
            classIRI,
            {
                polarity = polarity
                restriction = restriction
            }
        )
    static member that((classIRI: Class), (restriction: Restriction)) =
        Conjunction.that (classIRI, Positive, restriction)
    static member that(restriction: Restriction) =
        fun (classIRI: Class) -> Conjunction.that (classIRI, restriction)
    static member that(polarity: Polarity) =
        fun (restriction: Restriction) -> fun (classIRI: Class) -> Conjunction.that (classIRI, polarity, restriction)
    static member that_not((classIRI: Class), (restriction: Restriction)) =
        Conjunction.that (classIRI, Negative, restriction)
    static member that_not(restriction: Restriction) =
        fun (classIRI: Class) -> Conjunction.that_not (classIRI, restriction)
type Primary with
    static member and_((one: Primary), (two: Primary)) = one .&& two
    member this._and(primary: Primary) = this .&& primary

(*
    static member not(dataAtomic: DataAtomic) = !!dataAtomic
    static member not(restriction: Restriction) = !!restriction
    static member not(atomic: Atomic) = !!atomic
    static member and_(one: Restriction) = fun (two: Restriction) -> one .&& two
    static member and_(one: Primary) = fun (two: Primary) -> one .&& two
    static member and_(one: DataPrimary) = fun (two: DataPrimary) -> one .&& two
*)
type ObjectPropertyFact with
    static member not(objectPropertyFact: ObjectPropertyFact) = !!objectPropertyFact
    member this._not = !!this
    member this.Assertion(sourceIndividual: Individual) =
        match this.polarity with
        | Positive ->
            Functional.ObjectPropertyAssertion(ObjectPropertyExpression this.objectProperty, sourceIndividual, this.individual)
            |> ObjectPropertyAssertion
        | Negative ->
            Functional.NegativeObjectPropertyAssertion(ObjectPropertyExpression this.objectProperty, sourceIndividual, this.individual)
            |> NegativeObjectPropertyAssertion
    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)
type DataPropertyFact with
    static member not(dataPropertyFact: DataPropertyFact) = !!dataPropertyFact
    member this._not = !!this
    member this.Assertion(sourceIndividual: Individual) =
        match this.polarity with
        | Positive ->
            Functional.DataPropertyAssertion(this.dataProperty, sourceIndividual, this.literal)
            |> DataPropertyAssertion
        | Negative ->
            Functional.NegativeDataPropertyAssertion(this.dataProperty, sourceIndividual, this.literal)
            |> NegativeDataPropertyAssertion
    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)
type Fact with
    static member not(Fact: Fact) = !!Fact
    member this._not = !!this
    member this.Assertion(sourceIndividual: Individual) =
        match this with
        | ObjectPropertyFact objectPropertyFact -> objectPropertyFact.Assertion sourceIndividual
        | DataPropertyFact dataPropertyFact -> dataPropertyFact.Assertion sourceIndividual
    member this.Assertion(individuals: Individual list) : Assertion list =
        match this with
        | ObjectPropertyFact objectPropertyFact -> objectPropertyFact.Assertion individuals
        | DataPropertyFact dataPropertyFact -> dataPropertyFact.Assertion individuals
type ObjectPropertyExpression with
    member this._some(primary: Primary) =
        this
        |> Restriction.ObjectSomeValuesFrom primary.classExpression
        |> RestrictionPrimary.ofRestriction
    member this._only(primary: Primary) =
        this
        |> Restriction.ObjectAllValuesFrom primary.classExpression
        |> RestrictionPrimary.ofRestriction
    member this._value(individual: Individual) =
        this
        |> Restriction.ObjectHasValue individual
        |> RestrictionPrimary.ofRestriction
    member this._min((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.classExpression)
        |> RestrictionPrimary.ofRestriction
    member this._min(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.classExpression)
            |> RestrictionPrimary.ofRestriction
    member this._min(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._exactly((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.classExpression)
        |> RestrictionPrimary.ofRestriction

    member this._exactly(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.classExpression)
            |> RestrictionPrimary.ofRestriction

    member this._exactly(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._max((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.classExpression)
        |> RestrictionPrimary.ofRestriction
    member this._max(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.classExpression)
            |> RestrictionPrimary.ofRestriction

    member this._max(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member self._Self = Restriction.ObjectHasSelf self |> RestrictionPrimary.ofRestriction
type ObjectProperty with
    member this.Fact(individual: Individual) = {
        polarity = Positive
        objectProperty = this
        individual = individual
    }
    member this._not(individual: Individual) = !!(this.Fact individual)
type DataProperty with
    member this._some(dataPrimary: DataPrimary) =
        this
        |> Restriction.DataSomeValuesFrom dataPrimary.dataRange
        |> RestrictionPrimary.ofRestriction

    member this._only(dataPrimary: DataPrimary) =
        this
        |> Restriction.DataAllValuesFrom dataPrimary.dataRange
        |> RestrictionPrimary.ofRestriction
    member this._value(literal: Literal) =
        this |> Restriction.DataHasValue literal |> RestrictionPrimary.ofRestriction
    member this._min((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataMinCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction
    member this._min(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataMinCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction
    member this._min(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataMinCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._exactly((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataExactCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction

    member this._exactly(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataExactCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction
    member this._exactly(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataExactCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._max((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataMaxCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction

    member this._max(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataMaxCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction
    member this._max(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataMaxCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this.Fact(literal: Literal) = {
        polarity = Positive
        dataProperty = this
        literal = literal
    }
    member this._not(literal: Literal) = !!(this.Fact literal)
type PropertyExpressionChain with
    static member o((propertyExpressionChain: PropertyExpressionChain), (objectPropertyExpression: ObjectPropertyExpression)) =
        // List.TwoOrMore.More objectPropertyExpression propertyExpressionChain.objectPropertyChain.items[0] propertyExpressionChain.objectPropertyChain.items[1..]
        match propertyExpressionChain.objectPropertyChain.items with
        | first :: second :: rest ->
            List.TwoOrMore.More(first, second, rest @ [ objectPropertyExpression ])
            |> Functional.ObjectPropertyChain

        | _ -> invalidOp "Impossible List.TwoOrMore state."
    static member o(objectPropertyExpression: ObjectPropertyExpression) =
        fun (propertyExpressionChain: PropertyExpressionChain) -> PropertyExpressionChain.o (propertyExpressionChain, objectPropertyExpression)
    member this._o(objectPropertyExpression: ObjectPropertyExpression) =
        this |> PropertyExpressionChain.o objectPropertyExpression

type ObjectPropertyExpression with
    member this._o(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.ObjectPropertyChain this objectPropertyExpression
type ObjectProperty with
    member this._inverse = Functional.ObjectInverseOf this
type Class with
    member this._that(restriction: Restriction) = Conjunction.that (this, restriction)

type AnnotationProperty with
    member this.Annotation(value: Iri) =
        Functional.Annotation(this, IriObject value)

    member this.Annotation(value: BNode) =
        Functional.Annotation(this, BNodeObject value)

    member this.Annotation(value: Literal) =
        Functional.Annotation(this, LiteralObject value)

    member this.Assertion(subject: Iri, value: Iri) =
        Functional.AnnotationAssertion(this, IriSubject subject, IriObject value)

    member this.Assertion(subject: Iri, value: BNode) =
        Functional.AnnotationAssertion(this, IriSubject subject, BNodeObject value)

    member this.Assertion(subject: Iri, value: Literal) =
        Functional.AnnotationAssertion(this, IriSubject subject, LiteralObject value)

    member this.Assertion(subject: BNode, value: Iri) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, IriObject value)

    member this.Assertion(subject: BNode, value: BNode) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, BNodeObject value)

    member this.Assertion(subject: BNode, value: Literal) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, LiteralObject value)
type Individual with
    member this.Assertion(fact: Fact) = fact.Assertion this
    member this.Assertion(facts: Fact list) =
        facts |> List.map (fun fact -> fact.Assertion this)

type Iri with
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Iri)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, IriObject annotationObject)
    member this.Annotation(annotationObject: Iri) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, IriSubject this, IriObject annotationObject)
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: BNode)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, BNodeObject annotationObject)
    member this.Annotation(annotationObject: BNode) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, IriSubject this, BNodeObject annotationObject)
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Literal)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, LiteralObject annotationObject)
    member this.Annotation(annotationObject: Literal) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, IriSubject this, LiteralObject annotationObject)
    member this.label annotation = this.Annotation annotation
    member this.comment annotation = this.Annotation annotation
    member this.seeAlso annotation = this.Annotation annotation
    member this.isDefinedBy annotation = this.Annotation annotation
    member this.deprecated annotation = this.Annotation annotation
    member this.versionInfo annotation = this.Annotation annotation
    member this.priorVersion annotation = this.Annotation annotation
    member this.backwardCompatibleWith annotation = this.Annotation annotation
    member this.incompatibleWith annotation = this.Annotation annotation
type BNode with
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Iri)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, IriObject annotationObject)
    member this.Annotation(annotationObject: Iri) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, IriObject annotationObject)
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: BNode)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, BNodeObject annotationObject)
    member this.Annotation(annotationObject: BNode) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, BNodeObject annotationObject)
    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Literal)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, LiteralObject annotationObject)
    member this.Annotation(annotationObject: Literal) =
        fun (annotationProperty: AnnotationProperty) -> Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, LiteralObject annotationObject)
type DatatypeIri with
    member this.length(length: NonNegativeInteger) =
        this
        |> Functional.DatatypeRestriction(xsd.length |> Functional.FacetValue($"{length}" ^^ xsd.nonNegativeInteger))
    member this.minLength(minLength: NonNegativeInteger) =
        this
        |> Functional.DatatypeRestriction(xsd.minLength |> Functional.FacetValue($"{minLength}" ^^ xsd.nonNegativeInteger))
    member this.maxLength(maxLength: NonNegativeInteger) =
        this
        |> Functional.DatatypeRestriction(xsd.maxLength |> Functional.FacetValue($"{maxLength}" ^^ xsd.nonNegativeInteger))
    member this.pattern(pattern: string) =
        this
        |> Functional.DatatypeRestriction(xsd.pattern |> Functional.FacetValue($"{pattern}" ^^ xsd.string))
    member this.langRange(langRange: string) =
        this
        |> Functional.DatatypeRestriction(rdf.langRange |> Functional.FacetValue($"{langRange}" ^^ xsd.string))

    member this.withRestrictions(facetValues: Set.OneOrMore<FacetValue>) =
        Functional.DatatypeRestriction(this, facetValues)
