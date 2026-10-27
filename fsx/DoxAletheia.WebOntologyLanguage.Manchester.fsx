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

    static member (.&&)((dataConjunction: DataConjunction), (dataPrimary: DataPrimary)) =
        match dataConjunction with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            match dataPrimaries.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ dataPrimary ])
                |> DataPrimaryAndDataPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataPrimary first -> List.TwoOrMore.Two first dataPrimary |> DataPrimaryAndDataPrimary

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

    static member (.&&)((one: DataPrimary), (dataConjunction: DataConjunction)) =
        match dataConjunction with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            match dataPrimaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(one, first, second :: rest) |> DataPrimaryAndDataPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataPrimary two -> List.TwoOrMore.Two one two |> DataPrimaryAndDataPrimary

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

    member this.Expression =
        match this with
        | ConjunctionOrConjunction conjunctions ->
            Set.TwoOrMore.More
                conjunctions.items[0].Expression
                conjunctions.items[1].Expression
                (conjunctions.items[2..] |> List.map (fun item -> item.Expression) |> Set.ofList)
            |> ObjectUnion
        | Conjunction conjunction -> conjunction.Expression

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

    static member (.&&)((conjunction: Conjunction), (primary: Primary)) =
        match conjunction with
        | PrimaryAndPrimary primaries ->
            match primaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(first, second, rest @ [ primary ]) |> PrimaryAndPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Primary first -> List.TwoOrMore.Two first primary |> PrimaryAndPrimary
        | ClassThatRestriction _ -> invalidArg (nameof primary) "A class-that conjunction can only be extended by another restriction primary."

    static member (.&&)((conjunction: Conjunction), (restrictionPrimary: RestrictionPrimary)) =
        match conjunction with
        | ClassThatRestriction(classIRI, restrictions) -> ClassThatRestriction(classIRI, List.OneOrMore.More(restrictions.items, restrictionPrimary))
        | _ -> conjunction .&& Primary.RestrictionPrimary restrictionPrimary

    member this.Expression =
        match this with
        | ClassThatRestriction(classIRI, restrictionPrimaries) ->
            match restrictionPrimaries.items with
            | [ restrictionPrimary ] ->
                Set.TwoOrMore.Two classIRI.Expression restrictionPrimary.Expression
                |> ObjectIntersection
            | restrictionItems ->
                Set.TwoOrMore.More
                    classIRI.Expression
                    restrictionItems[0].Expression
                    (restrictionItems[1..]
                     |> List.map (fun restrictionPrimary -> restrictionPrimary.Expression)
                     |> Set.ofList)
                |> ObjectIntersection
        | PrimaryAndPrimary primaries ->
            Set.TwoOrMore.More primaries.items[0].Expression primaries.items[1].Expression (primaries.items[2..] |> List.map (fun item -> item.Expression) |> Set.ofList)
            |> ObjectIntersection
        | Primary primary -> primary.Expression

and Primary =
    | RestrictionPrimary of RestrictionPrimary
    | AtomicPrimary of AtomicPrimary

    static member (.&&)((one: Primary), (two: Primary)) =
        List.TwoOrMore.Two one two |> PrimaryAndPrimary

    static member (.&&)((one: Primary), (conjunction: Conjunction)) =
        match conjunction with
        | PrimaryAndPrimary primaries ->
            match primaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(one, first, second :: rest) |> PrimaryAndPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Primary two -> List.TwoOrMore.Two one two |> PrimaryAndPrimary
        | ClassThatRestriction _ -> invalidArg (nameof conjunction) "A class-that conjunction cannot be appended to a primary conjunction without parentheses."

    member this.Expression =
        match this with
        | RestrictionPrimary restrictionPrimary -> restrictionPrimary.Expression
        | AtomicPrimary atomicPrimary -> atomicPrimary.Expression

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

    member this.primary = Primary.RestrictionPrimary this

    static member (!!)(restrictionPrimary: RestrictionPrimary) = {
        restrictionPrimary with
            polarity = !!restrictionPrimary.polarity
    }

    static member (.&&)((one: RestrictionPrimary), (two: RestrictionPrimary)) = one.primary .&& two.primary

    member this.Expression =
        match this.polarity with
        | Positive -> RestrictionClassExpression this.restriction
        | Negative -> ObjectComplement(RestrictionClassExpression this.restriction)

and AtomicPrimary = {
    polarity: Polarity
    atomic: Atomic
} with

    static member ofAtomic(atomic: Atomic) = { polarity = Positive; atomic = atomic }

    member this.primary = Primary.AtomicPrimary this

    static member (!!)(atomicPrimary: AtomicPrimary) = {
        atomicPrimary with
            polarity = !!atomicPrimary.polarity
    }

    member this.Expression =
        match this.polarity with
        | Positive -> this.atomic.Expression
        | Negative -> ObjectComplement this.atomic.Expression

and Atomic =
    | AtomicClass of Class
    | AtomicIndividuals of Set.OneOrMore<Individual>
    | AtomicDescription of Description

    member this.Expression =
        match this with
        | AtomicClass classIRI -> ClassExpression classIRI
        | AtomicIndividuals individuals -> ObjectOne individuals
        | AtomicDescription description -> description.Expression

type PredicatePropertyFact = {
    polarity: Polarity
    predicateProperty: NormativePredicate
    individual: Individual
} with

    static member (!!)(objectPropertyFact: PredicatePropertyFact) = {
        objectPropertyFact with
            polarity = !!objectPropertyFact.polarity
    }
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
    | PredicatePropertyFact of PredicatePropertyFact
    | ObjectPropertyFact of ObjectPropertyFact
    | DataPropertyFact of DataPropertyFact

    static member (!!)(fact: Fact) =
        match fact with
        | PredicatePropertyFact predicatePropertyFact -> PredicatePropertyFact !!predicatePropertyFact
        | ObjectPropertyFact objectPropertyFact -> ObjectPropertyFact !!objectPropertyFact
        | DataPropertyFact dataPropertyFact -> DataPropertyFact !!dataPropertyFact

type PropertyExpression =
    | ObjectPropertyExpression of ObjectPropertyExpression
    | DataPropertyExpression of DataPropertyExpression

[<RequireQualifiedAccess>]
type ObjectPropertyCharacteristic =
    | Functional
    | InverseFunctional
    | Reflexive
    | Irreflexive
    | Symmetric
    | Asymmetric
    | Transitive

[<RequireQualifiedAccess>]
type DataPropertyCharacteristic = | Functional

type DisjointUnionDescriptions = {
    disjointUnionDescriptions: Set.TwoOrMore<Description>
}

type KeyPropertyExpressions = {
    keyPropertyExpressions: List.OneOrMore<PropertyExpression>
}

// The following n-ary types correspond to Manchester's top-level misc productions.
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

type EquivalentDataPropertyExpressions = {
    equivalentDataProperties: Set.TwoOrMore<DataPropertyExpression>
}

type DisjointDataPropertyExpressions = {
    disjointDataProperties: Set.TwoOrMore<DataPropertyExpression>
}

type SameIndividuals = {
    sameIndividuals: Set.TwoOrMore<Individual>
}

type DifferentIndividualValues = {
    differentIndividuals: Set.TwoOrMore<Individual>
}

[<RequireQualifiedAccess>]
type Misc =
    | EquivalentClasses of Annotated<EquivalentDescriptions>
    | DisjointClasses of Annotated<DisjointDescriptions>
    | EquivalentObjectProperties of Annotated<EquivalentObjectProperties>
    | DisjointObjectProperties of Annotated<DisjointObjectProperties>
    | EquivalentDataProperties of Annotated<EquivalentDataPropertyExpressions>
    | DisjointDataProperties of Annotated<DisjointDataPropertyExpressions>
    | SameIndividual of Annotated<SameIndividuals>
    | DifferentIndividuals of Annotated<DifferentIndividualValues>

type DatatypeFrame = {
    Datatype: Datatype
    Annotations: Set<Annotation>
    EquivalentTo: Annotated<DataRange> option
}

type ClassFrame = {
    Class: Class
    Annotations: Set<Annotation>
    SubClassOf: Set<Annotated<Description>>
    EquivalentTo: Set<Annotated<Description>>
    DisjointWith: Set<Annotated<Description>>
    DisjointUnionOf: Set<Annotated<DisjointUnionDescriptions>>
    HasKey: Set<Annotated<KeyPropertyExpressions>>
}

type ObjectPropertyFrame = {
    ObjectProperty: ObjectProperty
    Annotations: Set<Annotation>
    Domain: Set<Annotated<Description>>
    Range: Set<Annotated<Description>>
    Characteristics: Set<Annotated<ObjectPropertyCharacteristic>>
    SubPropertyOf: Set<Annotated<ObjectPropertyExpression>>
    EquivalentTo: Set<Annotated<ObjectPropertyExpression>>
    DisjointWith: Set<Annotated<ObjectPropertyExpression>>
    InverseOf: Set<Annotated<ObjectPropertyExpression>>
    SubPropertyChain: Set<Annotated<PropertyExpressionChain>>
}

type DataPropertyFrame = {
    DataProperty: DataProperty
    Annotations: Set<Annotation>
    Domain: Set<Annotated<Description>>
    Range: Set<Annotated<DataRange>>
    Characteristics: Set<Annotated<DataPropertyCharacteristic>>
    SubPropertyOf: Set<Annotated<DataPropertyExpression>>
    EquivalentTo: Set<Annotated<DataPropertyExpression>>
    DisjointWith: Set<Annotated<DataPropertyExpression>>
}

type AnnotationPropertyFrame = {
    AnnotationProperty: AnnotationProperty
    Annotations: Set<Annotation>
    Domain: Set<Annotated<IRI>>
    Range: Set<Annotated<IRI>>
    SubPropertyOf: Set<Annotated<AnnotationProperty>>
}

type IndividualFrame = {
    Individual: Individual
    Annotations: Set<Annotation>
    Types: Set<Annotated<Description>>
    Facts: Set<Annotated<Fact>>
    SameAs: Set<Annotated<Individual>>
    DifferentFrom: Set<Annotated<Individual>>
}

type Frame =
    | DatatypeFrame of DatatypeFrame
    | ClassFrame of ClassFrame
    | ObjectPropertyFrame of ObjectPropertyFrame
    | DataPropertyFrame of DataPropertyFrame
    | AnnotationPropertyFrame of AnnotationPropertyFrame
    | IndividualFrame of IndividualFrame
    | Misc of Misc

module private ManchesterLowering =

    let mapTwoOrMoreSet (mapping: 'Value -> 'MappedValue) (values: Set.TwoOrMore<'Value>) : Set.TwoOrMore<'MappedValue> =
        let mapped = values.elements |> Set.map mapping
        let mappedArray = mapped |> Set.toArray

        if mappedArray.Length < 2 then
            invalidOp "Lowering collapsed a Manchester two-or-more collection to fewer than two distinct OWL values."

        Set.TwoOrMore.More(mappedArray[0], mappedArray[1], mappedArray[2..] |> Set.ofArray)

    let annotationAssertions (annotationSubject: AnnotationSubject, annotations: Set<Annotation>) : Set<Annotated<Axiom>> =
        annotations
        |> Set.map (fun annotation ->
            Functional.AnnotationAssertion(annotation.annotationAnnotations, annotation.annotationProperty, annotationSubject, annotation.annotationValue)
            |> fun assertion -> assertion.map AnnotationAxiom.AnnotationAssertion
            |> fun annotationAxiom -> annotationAxiom.map Axiom.AnnotationAxiom)

    let declaration (entity: Entity) : Annotated<Axiom> =
        Functional.Declaration entity
        |> fun declaration -> declaration.map Axiom.Declaration

    let classAxiom (annotatedClassAxiom: Annotated<ClassAxiom>) : Annotated<Axiom> =
        annotatedClassAxiom.map Axiom.ClassAxiom

    let objectPropertyAxiom (annotatedObjectPropertyAxiom: Annotated<ObjectPropertyAxiom>) : Annotated<Axiom> =
        annotatedObjectPropertyAxiom.map Axiom.ObjectPropertyAxiom

    let dataPropertyAxiom (annotatedDataPropertyAxiom: Annotated<DataPropertyAxiom>) : Annotated<Axiom> =
        annotatedDataPropertyAxiom.map Axiom.DataPropertyAxiom

    let assertionAxiom (annotatedAssertion: Annotated<Assertion>) : Annotated<Axiom> = annotatedAssertion.map Axiom.Assertion

    let annotationAxiom (annotatedAnnotationAxiom: Annotated<AnnotationAxiom>) : Annotated<Axiom> =
        annotatedAnnotationAxiom.map Axiom.AnnotationAxiom

    let keyProperties (keyPropertyExpressions: KeyPropertyExpressions) : KeyProperties =
        let objectPropertyExpressions, dataPropertyExpressions =
            keyPropertyExpressions.keyPropertyExpressions.items
            |> List.fold
                (fun (objectProperties, dataProperties) propertyExpression ->
                    match propertyExpression with
                    | PropertyExpression.ObjectPropertyExpression objectPropertyExpression -> objectPropertyExpression :: objectProperties, dataProperties
                    | PropertyExpression.DataPropertyExpression dataPropertyExpression -> objectProperties, dataPropertyExpression :: dataProperties)
                ([], [])

        let objectPropertySet = objectPropertyExpressions |> Set.ofList
        let dataPropertySet = dataPropertyExpressions |> Set.ofList

        match Set.isEmpty objectPropertySet, Set.isEmpty dataPropertySet with
        | false, false -> ObjectDataKeyProperties(Set.OneOrMore.ofSet objectPropertySet, Set.OneOrMore.ofSet dataPropertySet)
        | false, true -> ObjectKeyProperties(Set.OneOrMore.ofSet objectPropertySet)
        | true, false -> DataKeyProperties(Set.OneOrMore.ofSet dataPropertySet)
        | true, true -> invalidOp "A Manchester HasKey entry must contain at least one property expression."

    let individualAnnotationSubject (individual: Individual) : AnnotationSubject =
        match individual with
        | Individual namedIndividual -> IriSubject namedIndividual.IRI
        | AnonymousIndividual anonymousIndividual -> BNodeSubject anonymousIndividual.BNode

    let namedIndividualDeclaration (individual: Individual) : Annotated<Axiom> option =
        match individual with
        | Individual namedIndividual -> Functional.NamedIndividual namedIndividual |> declaration |> Some
        | AnonymousIndividual _ -> None

type ObjectPropertyFact with
    static member not(objectPropertyFact: ObjectPropertyFact) = !!objectPropertyFact
    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this.polarity with
        | Positive ->
            let assertion: ObjectPropertyAssertion = {
                sourceIndividual = sourceIndividual
                objectPropertyExpression = Functional.AsObjectPropertyExpression this.objectProperty
                targetIndividual = this.individual
            }
            Assertion.ObjectPropertyAssertion assertion
        | Negative ->
            let assertion: NegativeObjectPropertyAssertion = {
                sourceIndividual = sourceIndividual
                negativeObjectPropertyExpression = Functional.AsObjectPropertyExpression this.objectProperty
                targetIndividual = this.individual
            }
            Assertion.NegativeObjectPropertyAssertion assertion

    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)

type DataPropertyFact with
    static member not(dataPropertyFact: DataPropertyFact) = !!dataPropertyFact
    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this.polarity with
        | Positive ->
            let assertion: DataPropertyAssertion = {
                sourceIndividual = sourceIndividual
                dataPropertyExpression = this.dataProperty
                targetValue = this.literal
            }
            Assertion.DataPropertyAssertion assertion
        | Negative ->
            let assertion: NegativeDataPropertyAssertion = {
                sourceIndividual = sourceIndividual
                negativeDataPropertyExpression = this.dataProperty
                targetValue = this.literal
            }
            Assertion.NegativeDataPropertyAssertion assertion

    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)

type Fact with
    static member not(fact: Fact) = !!fact
    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this with
        | ObjectPropertyFact objectPropertyFact -> objectPropertyFact.Assertion sourceIndividual
        | DataPropertyFact dataPropertyFact -> dataPropertyFact.Assertion sourceIndividual

    member this.Assertion(individuals: Individual list) : Assertion list = individuals |> List.map this.Assertion

type DatatypeFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = IriSubject this.Datatype.Iri
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let definition =
            this.EquivalentTo
            |> Option.map (fun equivalentTo ->
                equivalentTo
                    .map(fun dataRange ->
                        let definition: DatatypeDefinition = {
                            datatype = this.Datatype
                            dataRange = dataRange
                        }
                        definition)
                    .map
                    Axiom.DatatypeDefinition)
            |> Option.toList
            |> Set.ofList

        Set.union annotations definition

type ClassFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let classExpression = this.Class.Expression
        let annotationSubject = IriSubject this.Class.IRI
        let declaration = Functional.Class this.Class |> ManchesterLowering.declaration |> Set.singleton
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let subClassOf =
            this.SubClassOf
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let subClass: SubClass = {
                        subClassExpression = classExpression
                        superClassExpression = description.Expression
                    }
                    ClassAxiom.SubClassAxiom subClass)
                |> ManchesterLowering.classAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let equivalentClasses: EquivalentClasses = {
                        equivalentClasses = Set.TwoOrMore.Two(classExpression, description.Expression)
                    }
                    ClassAxiom.EquivalentClassesAxiom equivalentClasses)
                |> ManchesterLowering.classAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let disjointClasses: DisjointClasses = {
                        disjointClasses = Set.TwoOrMore.Two(classExpression, description.Expression)
                    }
                    ClassAxiom.DisjointClassesAxiom disjointClasses)
                |> ManchesterLowering.classAxiom)

        let disjointUnionOf =
            this.DisjointUnionOf
            |> Set.map (fun entry ->
                entry.map (fun disjointUnionDescriptions ->
                    let disjointUnion: DisjointUnion = {
                        disjointClass = this.Class
                        disjointClassExpressions =
                            disjointUnionDescriptions.disjointUnionDescriptions
                            |> ManchesterLowering.mapTwoOrMoreSet (fun description -> description.Expression)
                    }
                    ClassAxiom.DisjointUnionAxiom disjointUnion)
                |> ManchesterLowering.classAxiom)

        let hasKey =
            this.HasKey
            |> Set.map (fun entry ->
                entry.map (fun keyPropertyExpressions ->
                    let hasKey: HasKey = {
                        classExpression = classExpression
                        keyProperties = ManchesterLowering.keyProperties keyPropertyExpressions
                    }
                    Axiom.HasKey hasKey))

        Set.unionMany [
            declaration
            annotations
            subClassOf
            equivalentTo
            disjointWith
            disjointUnionOf
            hasKey
        ]

type ObjectPropertyFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let objectPropertyExpression = Functional.AsObjectPropertyExpression this.ObjectProperty
        let annotationSubject = IriSubject this.ObjectProperty.IRI
        let declaration =
            Functional.ObjectProperty this.ObjectProperty
            |> ManchesterLowering.declaration
            |> Set.singleton
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let domain: ObjectPropertyDomain = {
                        objectPropertyExpression = objectPropertyExpression
                        objectPropertyDomain = description.Expression
                    }
                    ObjectPropertyAxiom.ObjectPropertyDomain domain)
                |> ManchesterLowering.objectPropertyAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let range: ObjectPropertyRange = {
                        objectPropertyExpression = objectPropertyExpression
                        objectPropertyRange = description.Expression
                    }
                    ObjectPropertyAxiom.ObjectPropertyRange range)
                |> ManchesterLowering.objectPropertyAxiom)

        let characteristics =
            this.Characteristics
            |> Set.map (fun entry ->
                entry.map (fun characteristic ->
                    match characteristic with
                    | ObjectPropertyCharacteristic.Functional ->
                        ObjectPropertyAxiom.FunctionalObjectProperty {
                            functionalObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.InverseFunctional ->
                        ObjectPropertyAxiom.InverseFunctionalObjectProperty {
                            inverseFunctionalObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.Reflexive ->
                        ObjectPropertyAxiom.ReflexiveObjectProperty {
                            reflexiveObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.Irreflexive ->
                        ObjectPropertyAxiom.IrreflexiveObjectProperty {
                            irreflexiveObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.Symmetric ->
                        ObjectPropertyAxiom.SymmetricObjectProperty {
                            symmetricObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.Asymmetric ->
                        ObjectPropertyAxiom.AsymmetricObjectProperty {
                            asymmetricObjectProperty = objectPropertyExpression
                        }
                    | ObjectPropertyCharacteristic.Transitive ->
                        ObjectPropertyAxiom.TransitiveObjectProperty {
                            transitiveObjectProperty = objectPropertyExpression
                        })
                |> ManchesterLowering.objectPropertyAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superObjectPropertyExpression ->
                    let subObjectProperty: SubObjectProperty = {
                        subObjectPropertyExpression = SubObjectPropertyExpression objectPropertyExpression
                        superObjectPropertyExpression = superObjectPropertyExpression
                    }
                    ObjectPropertyAxiom.SubObjectProperty subObjectProperty)
                |> ManchesterLowering.objectPropertyAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun equivalentObjectPropertyExpression ->
                    let equivalent: EquivalentObjectPropertyExpressions = {
                        equivalentObjectProperties = Set.TwoOrMore.Two(objectPropertyExpression, equivalentObjectPropertyExpression)
                    }
                    ObjectPropertyAxiom.EquivalentObjectProperties equivalent)
                |> ManchesterLowering.objectPropertyAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun disjointObjectPropertyExpression ->
                    let disjoint: DisjointObjectPropertyExpressions = {
                        disjointObjectProperties = Set.TwoOrMore.Two(objectPropertyExpression, disjointObjectPropertyExpression)
                    }
                    ObjectPropertyAxiom.DisjointObjectProperties disjoint)
                |> ManchesterLowering.objectPropertyAxiom)

        let inverseOf =
            this.InverseOf
            |> Set.map (fun entry ->
                entry.map (fun inverseObjectPropertyExpression ->
                    let inverse: InverseObjectProperties = {
                        inverseObjectProperties = objectPropertyExpression, inverseObjectPropertyExpression
                    }
                    ObjectPropertyAxiom.InverseObjectProperties inverse)
                |> ManchesterLowering.objectPropertyAxiom)

        let subPropertyChain =
            this.SubPropertyChain
            |> Set.map (fun entry ->
                entry.map (fun propertyExpressionChain ->
                    let subObjectProperty: SubObjectProperty = {
                        subObjectPropertyExpression = PropertyExpressionChain propertyExpressionChain
                        superObjectPropertyExpression = objectPropertyExpression
                    }
                    ObjectPropertyAxiom.SubObjectProperty subObjectProperty)
                |> ManchesterLowering.objectPropertyAxiom)

        Set.unionMany [
            declaration
            annotations
            domain
            range
            characteristics
            subPropertyOf
            equivalentTo
            disjointWith
            inverseOf
            subPropertyChain
        ]

type DataPropertyFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let dataPropertyExpression = this.DataProperty
        let annotationSubject = IriSubject this.DataProperty.IRI
        let declaration =
            Functional.DataProperty this.DataProperty
            |> ManchesterLowering.declaration
            |> Set.singleton
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let domain: DataPropertyDomain = {
                        dataPropertyExpression = dataPropertyExpression
                        dataPropertyDomain = description.Expression
                    }
                    DataPropertyAxiom.DataPropertyDomain domain)
                |> ManchesterLowering.dataPropertyAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun dataRange ->
                    let range: DataPropertyRange = {
                        dataPropertyExpression = dataPropertyExpression
                        dataPropertyRange = dataRange
                    }
                    DataPropertyAxiom.DataPropertyRange range)
                |> ManchesterLowering.dataPropertyAxiom)

        let characteristics =
            this.Characteristics
            |> Set.map (fun entry ->
                entry.map (fun characteristic ->
                    match characteristic with
                    | DataPropertyCharacteristic.Functional ->
                        DataPropertyAxiom.FunctionalDataProperty {
                            functionalDataProperty = dataPropertyExpression
                        })
                |> ManchesterLowering.dataPropertyAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superDataPropertyExpression ->
                    let subDataProperty: SubDataProperty = {
                        subDataPropertyExpression = dataPropertyExpression
                        superDataPropertyExpression = superDataPropertyExpression
                    }
                    DataPropertyAxiom.SubDataProperty subDataProperty)
                |> ManchesterLowering.dataPropertyAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun equivalentDataPropertyExpression ->
                    let equivalent: EquivalentDataProperties = {
                        equivalentDataProperties = Set.TwoOrMore.Two(dataPropertyExpression, equivalentDataPropertyExpression)
                    }
                    DataPropertyAxiom.EquivalentDataProperties equivalent)
                |> ManchesterLowering.dataPropertyAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun disjointDataPropertyExpression ->
                    let disjoint: DisjointDataProperties = {
                        disjointDataProperties = Set.TwoOrMore.Two(dataPropertyExpression, disjointDataPropertyExpression)
                    }
                    DataPropertyAxiom.DisjointDataProperties disjoint)
                |> ManchesterLowering.dataPropertyAxiom)

        Set.unionMany [
            declaration
            annotations
            domain
            range
            characteristics
            subPropertyOf
            equivalentTo
            disjointWith
        ]

type AnnotationPropertyFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = IriSubject this.AnnotationProperty.IRI
        let declaration =
            Functional.AnnotationProperty this.AnnotationProperty
            |> ManchesterLowering.declaration
            |> Set.singleton
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun domainIRI ->
                    let domain: AnnotationPropertyDomain = {
                        annotationProperty = this.AnnotationProperty
                        domainIRI = domainIRI
                    }
                    AnnotationAxiom.AnnotationPropertyDomain domain)
                |> ManchesterLowering.annotationAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun rangeIRI ->
                    let range: AnnotationPropertyRange = {
                        annotationProperty = this.AnnotationProperty
                        rangeIRI = rangeIRI
                    }
                    AnnotationAxiom.AnnotationPropertyRange range)
                |> ManchesterLowering.annotationAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superAnnotationProperty ->
                    let subProperty: SubAnnotationProperty = {
                        subAnnotationProperty = this.AnnotationProperty
                        superAnnotationProperty = superAnnotationProperty
                    }
                    AnnotationAxiom.SubAnnotationProperty subProperty)
                |> ManchesterLowering.annotationAxiom)

        Set.unionMany [ declaration; annotations; domain; range; subPropertyOf ]

type IndividualFrame with
    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = ManchesterLowering.individualAnnotationSubject this.Individual
        let declaration =
            ManchesterLowering.namedIndividualDeclaration this.Individual
            |> Option.toList
            |> Set.ofList
        let annotations = ManchesterLowering.annotationAssertions (annotationSubject, this.Annotations)

        let types =
            this.Types
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let assertion: ClassAssertion = {
                        individual = this.Individual
                        classExpression = description.Expression
                    }
                    Assertion.ClassAssertion assertion)
                |> ManchesterLowering.assertionAxiom)

        let facts =
            this.Facts
            |> Set.map (fun entry ->
                entry.map (fun fact -> fact.Assertion this.Individual)
                |> ManchesterLowering.assertionAxiom)

        let sameAs =
            this.SameAs
            |> Set.map (fun entry ->
                entry.map (fun sameIndividual ->
                    let same: SameIndividual = {
                        SameIndividual = Set.TwoOrMore.Two(this.Individual, sameIndividual)
                    }
                    Assertion.SameIndividual same)
                |> ManchesterLowering.assertionAxiom)

        let differentFrom =
            this.DifferentFrom
            |> Set.map (fun entry ->
                entry.map (fun differentIndividual ->
                    let different: DifferentIndividuals = {
                        DifferentIndividuals = Set.TwoOrMore.Two(this.Individual, differentIndividual)
                    }
                    Assertion.DifferentIndividuals different)
                |> ManchesterLowering.assertionAxiom)

        Set.unionMany [ declaration; annotations; types; facts; sameAs; differentFrom ]

type Misc with
    member this.axioms: Set<Annotated<Axiom>> =
        match this with
        | Misc.EquivalentClasses entry ->
            entry.map (fun equivalentDescriptions ->
                let equivalent: EquivalentClasses = {
                    equivalentClasses =
                        equivalentDescriptions.equivalentDescriptions
                        |> ManchesterLowering.mapTwoOrMoreSet (fun description -> description.Expression)
                }
                ClassAxiom.EquivalentClassesAxiom equivalent)
            |> ManchesterLowering.classAxiom
            |> Set.singleton

        | Misc.DisjointClasses entry ->
            entry.map (fun disjointDescriptions ->
                let disjoint: DisjointClasses = {
                    disjointClasses =
                        disjointDescriptions.disjointDescriptions
                        |> ManchesterLowering.mapTwoOrMoreSet (fun description -> description.Expression)
                }
                ClassAxiom.DisjointClassesAxiom disjoint)
            |> ManchesterLowering.classAxiom
            |> Set.singleton

        | Misc.EquivalentObjectProperties entry ->
            entry.map (fun equivalentObjectProperties ->
                let equivalent: EquivalentObjectPropertyExpressions = {
                    equivalentObjectProperties =
                        equivalentObjectProperties.equivalentObjectProperties
                        |> ManchesterLowering.mapTwoOrMoreSet Functional.AsObjectPropertyExpression
                }
                ObjectPropertyAxiom.EquivalentObjectProperties equivalent)
            |> ManchesterLowering.objectPropertyAxiom
            |> Set.singleton

        | Misc.DisjointObjectProperties entry ->
            entry.map (fun disjointObjectProperties ->
                let disjoint: DisjointObjectPropertyExpressions = {
                    disjointObjectProperties =
                        disjointObjectProperties.disjointObjectProperties
                        |> ManchesterLowering.mapTwoOrMoreSet Functional.AsObjectPropertyExpression
                }
                ObjectPropertyAxiom.DisjointObjectProperties disjoint)
            |> ManchesterLowering.objectPropertyAxiom
            |> Set.singleton

        | Misc.EquivalentDataProperties entry ->
            entry.map (fun equivalentDataProperties ->
                let equivalent: EquivalentDataProperties = {
                    equivalentDataProperties = equivalentDataProperties.equivalentDataProperties
                }
                DataPropertyAxiom.EquivalentDataProperties equivalent)
            |> ManchesterLowering.dataPropertyAxiom
            |> Set.singleton

        | Misc.DisjointDataProperties entry ->
            entry.map (fun disjointDataProperties ->
                let disjoint: DisjointDataProperties = {
                    disjointDataProperties = disjointDataProperties.disjointDataProperties
                }
                DataPropertyAxiom.DisjointDataProperties disjoint)
            |> ManchesterLowering.dataPropertyAxiom
            |> Set.singleton

        | Misc.SameIndividual entry ->
            entry.map (fun sameIndividuals ->
                let same: SameIndividual = {
                    SameIndividual = sameIndividuals.sameIndividuals
                }
                Assertion.SameIndividual same)
            |> ManchesterLowering.assertionAxiom
            |> Set.singleton

        | Misc.DifferentIndividuals entry ->
            entry.map (fun differentIndividuals ->
                let different: DifferentIndividuals = {
                    DifferentIndividuals = differentIndividuals.differentIndividuals
                }
                Assertion.DifferentIndividuals different)
            |> ManchesterLowering.assertionAxiom
            |> Set.singleton

type Frame with
    member this.axioms: Set<Annotated<Axiom>> =
        match this with
        | DatatypeFrame datatypeFrame -> datatypeFrame.axioms
        | ClassFrame classFrame -> classFrame.axioms
        | ObjectPropertyFrame objectPropertyFrame -> objectPropertyFrame.axioms
        | DataPropertyFrame dataPropertyFrame -> dataPropertyFrame.axioms
        | AnnotationPropertyFrame annotationPropertyFrame -> annotationPropertyFrame.axioms
        | IndividualFrame individualFrame -> individualFrame.axioms
        | Misc misc -> misc.axioms

type ManchesterOntology = {
    ontologyIdentifier: (OntologyIRI * VersionIRI option) option
    directlyImportsDocuments: Set<DirectlyImportsDocument>
    Annotations: Set<Annotation>
    Frames: Frame list
} with

    member this.owlOntology: Annotated<Ontology> =
        let axioms = this.Frames |> Seq.collect (fun frame -> frame.axioms) |> Set.ofSeq

        Functional.Ontology(this.ontologyIdentifier, this.directlyImportsDocuments, this.Annotations, axioms)

type ManchesterOntologyDocument = {
    PrefixDeclarations: Set<PrefixDeclaration>
    Ontology: ManchesterOntology
} with

    member this.owlOntologyDocument: OntologyDocument = Functional.OntologyDocument (this.PrefixDeclarations) this.Ontology.owlOntology

type Manchester =
    static member inverse(objectProperty: ObjectProperty) =
        Functional.ObjectInverseOf objectProperty

type DataConjunction with
    static member or_((one: DataConjunction), (two: DataConjunction)) = one .|| two
    static member or_((one: DataDescription), (two: DataConjunction)) = one .|| two
    static member or_((one: DataConjunction), (two: DataDescription)) = one .|| two
    static member and_((one: DataConjunction), (two: DataPrimary)) = one .&& two
    member this._or(other: DataConjunction) = this .|| other
    member this._or(other: DataDescription) = this .|| other
    member this._and(other: DataPrimary) = this .&& other

type DataDescription with
    member this._or(other: DataConjunction) = this .|| other

type RestrictionPrimary with
    static member not(restrictionPrimary: RestrictionPrimary) = !!restrictionPrimary
    member this._not = !!this
    member this._and(other: RestrictionPrimary) = this .&& other
    static member and_((one: RestrictionPrimary), (two: RestrictionPrimary)) = one .&& two

type Conjunction with
    static member or_((one: Conjunction), (two: Conjunction)) = one .|| two
    static member and_((one: Conjunction), (two: Primary)) = one .&& two
    static member and_((one: Conjunction), (two: RestrictionPrimary)) = one .&& two
    member this._or(other: Conjunction) = this .|| other
    member this._and(other: Primary) = this .&& other
    member this._and(other: RestrictionPrimary) = this .&& other

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
    static member that((classIRI: Class), (restrictionPrimaries: List.OneOrMore<RestrictionPrimary>)) =
        ClassThatRestriction(classIRI, restrictionPrimaries)

    static member that((classIRI: Class), (restrictionPrimary: RestrictionPrimary)) =
        Conjunction.that (classIRI, List.OneOrMore.One restrictionPrimary)

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

type ObjectPropertyExpression with
    member this._some(primary: Primary) =
        this
        |> Restriction.ObjectSomeValuesFrom primary.Expression
        |> RestrictionPrimary.ofRestriction

    member this._only(primary: Primary) =
        this
        |> Restriction.ObjectAllValuesFrom primary.Expression
        |> RestrictionPrimary.ofRestriction

    member this._value(individual: Individual) =
        this
        |> Restriction.ObjectHasValue individual
        |> RestrictionPrimary.ofRestriction

    member this._min((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.Expression)
        |> RestrictionPrimary.ofRestriction

    member this._min(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.Expression)
            |> RestrictionPrimary.ofRestriction

    member this._min(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._exactly((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.Expression)
        |> RestrictionPrimary.ofRestriction

    member this._exactly(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.Expression)
            |> RestrictionPrimary.ofRestriction

    member this._exactly(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._max((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.Expression)
        |> RestrictionPrimary.ofRestriction

    member this._max(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.Expression)
            |> RestrictionPrimary.ofRestriction

    member this._max(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member self._Self = Restriction.ObjectHasSelf self |> RestrictionPrimary.ofRestriction

type NormativePredicate with
    member this.Fact(individual: Individual) = {
        polarity = Positive
        predicateProperty = this
        individual = individual
    }

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

    member this._that(restrictionPrimary: RestrictionPrimary) =
        Conjunction.that (this, restrictionPrimary)

    member this._that(restrictionPrimaries: List.OneOrMore<RestrictionPrimary>) =
        Conjunction.that (this, restrictionPrimaries)

type Individual with
    member this.Assertion(fact: Fact) = fact.Assertion this

    member this.Assertion(facts: Fact list) =
        facts |> List.map (fun fact -> fact.Assertion this)

    member this.Assertion(fact: Annotated<Fact>) : Annotated<Assertion> =
        fact.map (fun value -> value.Assertion this)

    member this.Assertion(facts: Annotated<Fact> list) : Annotated<Assertion> list =
        facts |> List.map (fun fact -> this.Assertion fact)

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

module private KnownAnnotationProperty =
    let label = AnnotationPropertyIRI rdfs.label
    let comment = AnnotationPropertyIRI rdfs.comment
    let seeAlso = AnnotationPropertyIRI rdfs.seeAlso
    let isDefinedBy = AnnotationPropertyIRI rdfs.isDefinedBy
    let deprecated = AnnotationPropertyIRI owl.deprecated
    let versionInfo = AnnotationPropertyIRI owl.versionInfo
    let priorVersion = AnnotationPropertyIRI owl.priorVersion
    let backwardCompatibleWith = AnnotationPropertyIRI owl.backwardCompatibleWith
    let incompatibleWith = AnnotationPropertyIRI owl.incompatibleWith

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

    member this.label(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.label, annotationObject)
    member this.label(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.label, annotationObject)
    member this.label(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.label, annotationObject)

    member this.comment(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.comment, annotationObject)
    member this.comment(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.comment, annotationObject)
    member this.comment(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.comment, annotationObject)

    member this.seeAlso(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.seeAlso, annotationObject)
    member this.seeAlso(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.seeAlso, annotationObject)
    member this.seeAlso(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.seeAlso, annotationObject)

    member this.isDefinedBy(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.isDefinedBy, annotationObject)
    member this.isDefinedBy(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.isDefinedBy, annotationObject)
    member this.isDefinedBy(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.isDefinedBy, annotationObject)

    member this.deprecated(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.deprecated, annotationObject)
    member this.deprecated(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.deprecated, annotationObject)
    member this.deprecated(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.deprecated, annotationObject)

    member this.versionInfo(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.versionInfo, annotationObject)
    member this.versionInfo(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.versionInfo, annotationObject)
    member this.versionInfo(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.versionInfo, annotationObject)

    member this.priorVersion(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.priorVersion, annotationObject)
    member this.priorVersion(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.priorVersion, annotationObject)
    member this.priorVersion(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.priorVersion, annotationObject)

    member this.backwardCompatibleWith(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.backwardCompatibleWith, annotationObject)
    member this.backwardCompatibleWith(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.backwardCompatibleWith, annotationObject)
    member this.backwardCompatibleWith(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.backwardCompatibleWith, annotationObject)

    member this.incompatibleWith(annotationObject: Iri) =
        this.Annotation(KnownAnnotationProperty.incompatibleWith, annotationObject)
    member this.incompatibleWith(annotationObject: BNode) =
        this.Annotation(KnownAnnotationProperty.incompatibleWith, annotationObject)
    member this.incompatibleWith(annotationObject: Literal) =
        this.Annotation(KnownAnnotationProperty.incompatibleWith, annotationObject)

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
