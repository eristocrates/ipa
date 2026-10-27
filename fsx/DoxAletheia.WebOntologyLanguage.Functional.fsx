#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "DoxAletheia.ResourceDescriptionFramework.dll"
open DoxAletheia.ResourceDescriptionFramework
#r "DoxAletheia.WebOntologyLanguage.dll"
open DoxAletheia.WebOntologyLanguage
#load @".paket/load/main.group.fsx"
open System
open IriTools

// Tupled overloads preserve OWL Functional-Style Syntax operand order.
// Curried assertion overloads use subject -> predicate -> object order where applicable.
// Other curried overloads favor partial application; qualified cardinalities begin with the qualifier.
// Annotation-bearing productions return Annotated<'T>; the wrapped value remains the bare OWL structural type.
type Functional =

    static member Prefix((prefixName: string), (fullIRI: FullIRI)) = Prefix(prefixName, fullIRI)
    static member Prefix(prefixName: string) =
        fun (fullIRI: FullIRI) -> Functional.Prefix(prefixName, fullIRI)

    static member OntologyDocument(prefixDeclarations: Set<PrefixDeclaration>) =
        fun (ontology: Annotated<Ontology>) -> OntologyDocument(prefixDeclarations, ontology)
    static member OntologyDocument(ontology: Annotated<Ontology>) = OntologyDocument(Set.empty, ontology)

    static member Ontology
        (
            (ontologyIdentifier: (OntologyIRI * VersionIRI option) option),
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) : Annotated<Ontology> =
        let ontology: Ontology = {
            ontologyIdentifier = ontologyIdentifier
            directlyImportsDocuments = directlyImportsDocuments
            axioms = axioms
        }
        Annotated.Annotate(ontologyAnnotations, ontology)
    static member Ontology
        (
            (ontologyIRI: OntologyIRI),
            (versionIRI: VersionIRI),
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) =
        Functional.Ontology(Some(ontologyIRI, Some versionIRI), directlyImportsDocuments, ontologyAnnotations, axioms)
    static member Ontology((ontologyIRI: OntologyIRI), (versionIRI: VersionIRI)) =
        fun (directlyImportsDocuments: Set<DirectlyImportsDocument>) ->
            fun (ontologyAnnotations: Set<Annotation>) ->
                fun (axioms: Set<Annotated<Axiom>>) -> Functional.Ontology(ontologyIRI, versionIRI, directlyImportsDocuments, ontologyAnnotations, axioms)
    static member Ontology
        ((ontologyIRI: OntologyIRI), (directlyImportsDocuments: Set<DirectlyImportsDocument>), (ontologyAnnotations: Set<Annotation>), (axioms: Set<Annotated<Axiom>>))
        =
        Functional.Ontology(Some(ontologyIRI, None), directlyImportsDocuments, ontologyAnnotations, axioms)
    static member Ontology(ontologyIRI: OntologyIRI) =
        fun (directlyImportsDocuments: Set<DirectlyImportsDocument>) ->
            fun (ontologyAnnotations: Set<Annotation>) ->
                fun (axioms: Set<Annotated<Axiom>>) -> Functional.Ontology(ontologyIRI, directlyImportsDocuments, ontologyAnnotations, axioms)
    static member Ontology((directlyImportsDocuments: Set<DirectlyImportsDocument>), (ontologyAnnotations: Set<Annotation>), (axioms: Set<Annotated<Axiom>>)) =
        Functional.Ontology(None, directlyImportsDocuments, ontologyAnnotations, axioms)
    static member Ontology(directlyImportsDocuments: Set<DirectlyImportsDocument>) =
        fun (ontologyAnnotations: Set<Annotation>) -> fun (axioms: Set<Annotated<Axiom>>) -> Functional.Ontology(directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Declaration((axiomAnnotations: Set<Annotation>), (entity: Entity)) : Annotated<Declaration> =
        let declaration: Declaration = { entity = entity }
        Annotated.Annotate(axiomAnnotations, declaration)
    static member Declaration(axiomAnnotations: Set<Annotation>) =
        fun (entity: Entity) -> Functional.Declaration(axiomAnnotations, entity)
    static member Declaration(entity: Entity) =
        Functional.Declaration(Set.empty, entity)

    static member Class(iri: IRI) = iri |> ClassIRI |> Entity.Class
    static member Class(class_: Class) = Entity.Class class_
    static member Datatype(datatype: Datatype) = Entity.Datatype datatype
    static member ObjectProperty(iri: IRI) =
        iri |> ObjectPropertyIRI |> Entity.ObjectProperty
    static member ObjectProperty(objectProperty: ObjectProperty) = Entity.ObjectProperty objectProperty
    static member DataProperty(iri: IRI) =
        iri |> DataPropertyIRI |> Entity.DataProperty
    static member DataProperty(dataProperty: DataProperty) = Entity.DataProperty dataProperty
    static member AnnotationProperty(iri: IRI) =
        iri |> AnnotationPropertyIRI |> Entity.AnnotationProperty
    static member AnnotationProperty(annotationProperty: AnnotationProperty) =
        Entity.AnnotationProperty annotationProperty
    static member NamedIndividual(iri: IRI) =
        iri |> NamedIndividualIRI |> Entity.NamedIndividual
    static member NamedIndividual(namedIndividual: NamedIndividual) = Entity.NamedIndividual namedIndividual

    static member AsClassExpression(class_: Class) = ClassExpression class_
    static member AsObjectPropertyExpression(objectProperty: ObjectProperty) = ObjectPropertyExpression objectProperty
    static member AsIndividual(namedIndividual: NamedIndividual) = Individual namedIndividual
    static member AsIndividual(anonymousIndividual: AnonymousIndividual) = AnonymousIndividual anonymousIndividual
    static member AsDataRange(datatype: Datatype) = DatatypeRange datatype

    static member Annotation((annotationAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (annotationValue: AnnotationValue)) = {
        annotationAnnotations = annotationAnnotations
        annotationProperty = annotationProperty
        annotationValue = annotationValue
    }
    static member Annotation(annotationAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (annotationValue: AnnotationValue) -> Functional.Annotation(annotationAnnotations, annotationProperty, annotationValue)
    static member Annotation((annotationProperty: AnnotationProperty), (annotationValue: AnnotationValue)) =
        Functional.Annotation(Set.empty, annotationProperty, annotationValue)
    static member Annotation(annotationProperty: AnnotationProperty) =
        fun (annotationValue: AnnotationValue) -> Functional.Annotation(annotationProperty, annotationValue)

    static member AnnotationAssertion
        ((axiomAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (annotationSubject: AnnotationSubject), (annotationValue: AnnotationValue))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                annotationSubject = annotationSubject
                annotationProperty = annotationProperty
                annotationValue = annotationValue
            }
        )
    static member AnnotationAssertion(axiomAnnotations: Set<Annotation>) =
        fun (annotationSubject: AnnotationSubject) ->
            fun (annotationProperty: AnnotationProperty) ->
                fun (annotationValue: AnnotationValue) -> Functional.AnnotationAssertion(axiomAnnotations, annotationProperty, annotationSubject, annotationValue)
    static member AnnotationAssertion((annotationProperty: AnnotationProperty), (annotationSubject: AnnotationSubject), (annotationValue: AnnotationValue)) =
        Functional.AnnotationAssertion(Set.empty, annotationProperty, annotationSubject, annotationValue)
    static member AnnotationAssertion(annotationSubject: AnnotationSubject) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (annotationValue: AnnotationValue) -> Functional.AnnotationAssertion(annotationProperty, annotationSubject, annotationValue)

    static member SubAnnotationPropertyOf((axiomAnnotations: Set<Annotation>), (subAnnotationProperty: AnnotationProperty), (superAnnotationProperty: AnnotationProperty)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                subAnnotationProperty = subAnnotationProperty
                superAnnotationProperty = superAnnotationProperty
            }
        )
    static member SubAnnotationPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subAnnotationProperty: AnnotationProperty) ->
            fun (superAnnotationProperty: AnnotationProperty) -> Functional.SubAnnotationPropertyOf(axiomAnnotations, subAnnotationProperty, superAnnotationProperty)
    static member SubAnnotationPropertyOf((subAnnotationProperty: AnnotationProperty), (superAnnotationProperty: AnnotationProperty)) =
        Functional.SubAnnotationPropertyOf(Set.empty, subAnnotationProperty, superAnnotationProperty)
    static member SubAnnotationPropertyOf(subAnnotationProperty: AnnotationProperty) =
        fun (superAnnotationProperty: AnnotationProperty) -> Functional.SubAnnotationPropertyOf(subAnnotationProperty, superAnnotationProperty)

    static member AnnotationPropertyDomain((axiomAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (domainIRI: IRI)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                annotationProperty = annotationProperty
                domainIRI = domainIRI
            }
        )
    static member AnnotationPropertyDomain(axiomAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) -> fun (domainIRI: IRI) -> Functional.AnnotationPropertyDomain(axiomAnnotations, annotationProperty, domainIRI)
    static member AnnotationPropertyDomain((annotationProperty: AnnotationProperty), (domainIRI: IRI)) =
        Functional.AnnotationPropertyDomain(Set.empty, annotationProperty, domainIRI)
    static member AnnotationPropertyDomain(annotationProperty: AnnotationProperty) =
        fun (domainIRI: IRI) -> Functional.AnnotationPropertyDomain(annotationProperty, domainIRI)

    static member AnnotationPropertyRange((axiomAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (rangeIRI: IRI)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                annotationProperty = annotationProperty
                rangeIRI = rangeIRI
            }
        )
    static member AnnotationPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) -> fun (rangeIRI: IRI) -> Functional.AnnotationPropertyRange(axiomAnnotations, annotationProperty, rangeIRI)
    static member AnnotationPropertyRange((annotationProperty: AnnotationProperty), (rangeIRI: IRI)) =
        Functional.AnnotationPropertyRange(Set.empty, annotationProperty, rangeIRI)
    static member AnnotationPropertyRange(annotationProperty: AnnotationProperty) =
        fun (rangeIRI: IRI) -> Functional.AnnotationPropertyRange(annotationProperty, rangeIRI)

    static member ObjectInverseOf(objectProperty: ObjectProperty) = ObjectInverse objectProperty

    static member DataIntersectionOf((firstDataRange: DataRange), (secondDataRange: DataRange), (moreDataRanges: Set<DataRange>)) =
        Set.TwoOrMore.More(firstDataRange, secondDataRange, moreDataRanges)
        |> DataIntersection
    static member DataIntersectionOf((firstDataRange: DataRange), (secondDataRange: DataRange)) =
        Set.TwoOrMore.Two(firstDataRange, secondDataRange) |> DataIntersection
    static member DataIntersectionOf(dataRanges: Set.TwoOrMore<DataRange>) = dataRanges |> DataIntersection
    static member DataIntersectionOf(firstDataRange: DataRange) =
        fun (secondDataRange: DataRange) -> Functional.DataIntersectionOf(firstDataRange, secondDataRange)

    static member DataUnionOf((firstDataRange: DataRange), (secondDataRange: DataRange), (moreDataRanges: Set<DataRange>)) =
        Set.TwoOrMore.More(firstDataRange, secondDataRange, moreDataRanges) |> DataUnion
    static member DataUnionOf((firstDataRange: DataRange), (secondDataRange: DataRange)) =
        Set.TwoOrMore.Two(firstDataRange, secondDataRange) |> DataUnion
    static member DataUnionOf(dataRanges: Set.TwoOrMore<DataRange>) = dataRanges |> DataUnion
    static member DataUnionOf(firstDataRange: DataRange) =
        fun (secondDataRange: DataRange) -> Functional.DataUnionOf(firstDataRange, secondDataRange)

    static member DataComplementOf(dataRange: DataRange) = dataRange |> DataComplement

    static member DataOneOf((firstLiteral: Literal), (moreLiterals: Set<Literal>)) =
        Set.OneOrMore.More(firstLiteral, moreLiterals) |> DataOne
    static member DataOneOf(literals: Set.OneOrMore<Literal>) = literals |> DataOne
    static member DataOneOf(firstLiteral: Literal) =
        firstLiteral |> Set.OneOrMore.One |> DataOne

    static member FacetValue((constrainingFacet: FacetIri), (restrictionValue: Literal)) = {
        constrainingFacet = constrainingFacet
        restrictionValue = restrictionValue
    }
    static member FacetValue((constrainingFacet: FacetIri), (staticTypedLiteral: StaticTypedLiteral<_>)) =
        Functional.FacetValue(constrainingFacet, StaticTypedLiteral.toLiteral staticTypedLiteral)
    static member FacetValue(staticTypedLiteral: StaticTypedLiteral<_>) =
        fun (constrainingFacet: FacetIri) -> Functional.FacetValue(constrainingFacet, staticTypedLiteral)

    static member DatatypeRestriction((datatype: Datatype), (facetValues: Set.OneOrMore<FacetValue>)) = {
        datatype = datatype
        facetValues = facetValues
    }
    static member DatatypeRestriction((datatype: Datatype), (facetValue: FacetValue)) =
        Functional.DatatypeRestriction(datatype, Set.OneOrMore.One facetValue)
    static member DatatypeRestriction((datatype: Datatype), (firstConstraint: FacetValue), (moreConstraints: Set<FacetValue>)) =
        Functional.DatatypeRestriction(datatype, Set.OneOrMore.More(firstConstraint, moreConstraints))
    static member DatatypeRestriction((datatype: Datatype), (constrainingFacet: FacetIri), (restrictionValue: Literal), (moreConstraints: Set<FacetValue>)) =
        Functional.DatatypeRestriction(datatype, Functional.FacetValue(constrainingFacet, restrictionValue), moreConstraints)
    static member DatatypeRestriction((datatype: Datatype), (constrainingFacet: FacetIri), (restrictionValue: Literal)) =
        Functional.DatatypeRestriction(datatype, Functional.FacetValue(constrainingFacet, restrictionValue))
    static member DatatypeRestriction(datatype: Datatype) =
        fun (constrainingFacet: FacetIri) -> fun (restrictionValue: Literal) -> Functional.DatatypeRestriction(datatype, constrainingFacet, restrictionValue)
    static member DatatypeRestriction(facetValue: FacetValue) =
        fun (datatype: Datatype) -> Functional.DatatypeRestriction(datatype, facetValue)

    static member ObjectIntersectionOf((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        |> ObjectIntersection
    static member ObjectIntersectionOf((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Set.TwoOrMore.Two(firstClassExpression, secondClassExpression)
        |> ObjectIntersection
    static member ObjectIntersectionOf(classExpressions: Set.TwoOrMore<ClassExpression>) = classExpressions |> ObjectIntersection
    static member ObjectIntersectionOf(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) -> Functional.ObjectIntersectionOf(firstClassExpression, secondClassExpression)

    static member ObjectUnionOf((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        |> ObjectUnion
    static member ObjectUnionOf((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Set.TwoOrMore.Two(firstClassExpression, secondClassExpression) |> ObjectUnion
    static member ObjectUnionOf(classExpressions: Set.TwoOrMore<ClassExpression>) = ObjectUnion classExpressions
    static member ObjectUnionOf(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) -> Functional.ObjectUnionOf(firstClassExpression, secondClassExpression)

    static member ObjectComplementOf(classExpression: ClassExpression) = ObjectComplement classExpression

    static member ObjectOneOf((firstIndividual: Individual), (moreIndividuals: Set<Individual>)) =
        Set.OneOrMore.More(firstIndividual, moreIndividuals) |> ObjectOne
    static member ObjectOneOf(individuals: Set.OneOrMore<Individual>) = ObjectOne individuals
    static member ObjectOneOf(firstIndividual: Individual) =
        firstIndividual |> Set.OneOrMore.One |> ObjectOne

    static member ObjectSomeValuesFrom((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        objectPropertyExpression
        |> Restriction.ObjectSomeValuesFrom classExpression
        |> RestrictionClassExpression
    static member ObjectSomeValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectSomeValuesFrom classExpression
            |> RestrictionClassExpression

    static member ObjectAllValuesFrom((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        objectPropertyExpression
        |> Restriction.ObjectAllValuesFrom classExpression
        |> RestrictionClassExpression
    static member ObjectAllValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectAllValuesFrom classExpression
            |> RestrictionClassExpression

    static member ObjectHasValue((objectPropertyExpression: ObjectPropertyExpression), (individual: Individual)) =
        objectPropertyExpression
        |> Restriction.ObjectHasValue individual
        |> RestrictionClassExpression
    static member ObjectHasValue(individual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectHasValue individual
            |> RestrictionClassExpression

    static member ObjectHasSelf(objectPropertyExpression: ObjectPropertyExpression) =
        Restriction.ObjectHasSelf objectPropertyExpression |> RestrictionClassExpression

    // Tupled overloads preserve Functional Syntax. Curried qualified forms begin
    // with the qualifier, then cardinality, then property expression.
    static member ObjectMinCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression

    static member ObjectMinCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression
    static member ObjectMinCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectMinCardinality(cardinal, objectPropertyExpression)
    static member ObjectMinCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectMaxCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression
    static member ObjectMaxCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression

    static member ObjectMaxCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectMaxCardinality(cardinal, objectPropertyExpression)
    static member ObjectMaxCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectExactCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression)) =
        Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression

    static member ObjectExactCardinality((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression

    static member ObjectExactCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectExactCardinality(cardinal, objectPropertyExpression)
    static member ObjectExactCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)

    static member DataSomeValuesFrom((dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>), (dataRange: DataRange)) =
        Restriction.DataSomeValuesFrom(dataPropertyExpressions, dataRange)
        |> RestrictionClassExpression

    static member DataSomeValuesFrom
        ((firstDataPropertyExpression: DataPropertyExpression), (moreDataPropertyExpressions: DataPropertyExpression list), (dataRange: DataRange))
        =
        Functional.DataSomeValuesFrom(List.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions), dataRange)
    static member DataSomeValuesFrom((dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Functional.DataSomeValuesFrom(List.OneOrMore.One dataPropertyExpression, dataRange)
    static member DataSomeValuesFrom(dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>) =
        fun (dataRange: DataRange) -> Functional.DataSomeValuesFrom(dataPropertyExpressions, dataRange)
    static member DataSomeValuesFrom(dataRange: DataRange) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataSomeValuesFrom(dataPropertyExpression, dataRange)

    static member DataAllValuesFrom((dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>), (dataRange: DataRange)) =
        Restriction.DataAllValuesFrom(dataPropertyExpressions, dataRange)
        |> RestrictionClassExpression

    static member DataAllValuesFrom
        ((firstDataPropertyExpression: DataPropertyExpression), (moreDataPropertyExpressions: DataPropertyExpression list), (dataRange: DataRange))
        =
        Functional.DataAllValuesFrom(List.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions), dataRange)
    static member DataAllValuesFrom((dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Functional.DataAllValuesFrom(List.OneOrMore.One dataPropertyExpression, dataRange)
    static member DataAllValuesFrom(dataPropertyExpressions: List.OneOrMore<DataPropertyExpression>) =
        fun (dataRange: DataRange) -> Functional.DataAllValuesFrom(dataPropertyExpressions, dataRange)
    static member DataAllValuesFrom(dataRange: DataRange) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataAllValuesFrom(dataPropertyExpression, dataRange)

    static member DataHasValue((dataPropertyExpression: DataPropertyExpression), (literal: Literal)) =
        Restriction.DataHasValue(dataPropertyExpression, literal)
        |> RestrictionClassExpression

    static member DataHasValue(literal: Literal) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataHasValue(dataPropertyExpression, literal)

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        Restriction.DataMinCardinality(cardinal, dataPropertyExpression)
        |> RestrictionClassExpression

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Restriction.DataMinCardinality(cardinal, dataPropertyExpression, dataRange)
        |> RestrictionClassExpression

    static member DataMinCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataMinCardinality(cardinal, dataPropertyExpression)
    static member DataMinCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataMinCardinality(cardinal, dataPropertyExpression, dataRange)

    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        Restriction.DataMaxCardinality(cardinal, dataPropertyExpression)
        |> RestrictionClassExpression
    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Restriction.DataMaxCardinality(cardinal, dataPropertyExpression, dataRange)
        |> RestrictionClassExpression

    static member DataMaxCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataMaxCardinality(cardinal, dataPropertyExpression)
    static member DataMaxCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataMaxCardinality(cardinal, dataPropertyExpression, dataRange)

    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression)) =
        Restriction.DataExactCardinality(cardinal, dataPropertyExpression)
        |> RestrictionClassExpression
    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Restriction.DataExactCardinality(cardinal, dataPropertyExpression, dataRange)
        |> RestrictionClassExpression

    static member DataExactCardinality(cardinal: NonNegativeInteger) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataExactCardinality(cardinal, dataPropertyExpression)
    static member DataExactCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataPropertyExpression: DataPropertyExpression) -> Functional.DataExactCardinality(cardinal, dataPropertyExpression, dataRange)

    static member SubClassOf((axiomAnnotations: Set<Annotation>), (subClassExpression: ClassExpression), (superClassExpression: ClassExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                subClassExpression = subClassExpression
                superClassExpression = superClassExpression
            }
        )
    static member SubClassOf(axiomAnnotations: Set<Annotation>) =
        fun (subClassExpression: ClassExpression) ->
            fun (superClassExpression: ClassExpression) -> Functional.SubClassOf(axiomAnnotations, subClassExpression, superClassExpression)
    static member SubClassOf((subClassExpression: ClassExpression), (superClassExpression: ClassExpression)) =
        Functional.SubClassOf(Set.empty, subClassExpression, superClassExpression)
    static member SubClassOf(subClassExpression: ClassExpression) =
        fun (superClassExpression: ClassExpression) -> Functional.SubClassOf(subClassExpression, superClassExpression)

    static member EquivalentClasses((axiomAnnotations: Set<Annotation>), (classExpressions: Set.TwoOrMore<ClassExpression>)) =
        Annotated.Annotate(axiomAnnotations, { equivalentClasses = classExpressions })
    static member EquivalentClasses
        ((axiomAnnotations: Set<Annotation>), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Functional.EquivalentClasses(axiomAnnotations, Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions))
    static member EquivalentClasses((axiomAnnotations: Set<Annotation>), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.EquivalentClasses(axiomAnnotations, Set.TwoOrMore.Two(firstClassExpression, secondClassExpression))
    static member EquivalentClasses(axiomAnnotations: Set<Annotation>) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) -> Functional.EquivalentClasses(axiomAnnotations, firstClassExpression, secondClassExpression)
    static member EquivalentClasses(classExpressions: Set.TwoOrMore<ClassExpression>) =
        Functional.EquivalentClasses(Set.empty, classExpressions)
    static member EquivalentClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Functional.EquivalentClasses(Set.empty, firstClassExpression, secondClassExpression, moreClassExpressions)
    static member EquivalentClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.EquivalentClasses(Set.empty, firstClassExpression, secondClassExpression)
    static member EquivalentClasses(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) -> Functional.EquivalentClasses(firstClassExpression, secondClassExpression)

    static member DisjointClasses((axiomAnnotations: Set<Annotation>), (classExpressions: Set.TwoOrMore<ClassExpression>)) =
        Annotated.Annotate(axiomAnnotations, { disjointClasses = classExpressions })
    static member DisjointClasses
        ((axiomAnnotations: Set<Annotation>), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Functional.DisjointClasses(axiomAnnotations, Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions))
    static member DisjointClasses((axiomAnnotations: Set<Annotation>), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.DisjointClasses(axiomAnnotations, Set.TwoOrMore.Two(firstClassExpression, secondClassExpression))
    static member DisjointClasses(axiomAnnotations: Set<Annotation>) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) -> Functional.DisjointClasses(axiomAnnotations, firstClassExpression, secondClassExpression)
    static member DisjointClasses(classExpressions: Set.TwoOrMore<ClassExpression>) =
        Functional.DisjointClasses(Set.empty, classExpressions)
    static member DisjointClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>)) =
        Functional.DisjointClasses(Set.empty, firstClassExpression, secondClassExpression, moreClassExpressions)
    static member DisjointClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.DisjointClasses(Set.empty, firstClassExpression, secondClassExpression)
    static member DisjointClasses(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) -> Functional.DisjointClasses(firstClassExpression, secondClassExpression)

    static member DisjointUnion((axiomAnnotations: Set<Annotation>), (disjointClass: Class), (disjointExpressions: Set.TwoOrMore<ClassExpression>)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                disjointClass = disjointClass
                disjointClassExpressions = disjointExpressions
            }
        )
    static member DisjointUnion
        (
            (axiomAnnotations: Set<Annotation>),
            (disjointClass: Class),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.DisjointUnion(axiomAnnotations, disjointClass, Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions))
    static member DisjointUnion
        ((axiomAnnotations: Set<Annotation>), (disjointClass: Class), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression))
        =
        Functional.DisjointUnion(axiomAnnotations, disjointClass, Set.TwoOrMore.Two(firstClassExpression, secondClassExpression))
    static member DisjointUnion(axiomAnnotations: Set<Annotation>) =
        fun (disjointClass: Class) ->
            fun (firstClassExpression: ClassExpression) ->
                fun (secondClassExpression: ClassExpression) -> Functional.DisjointUnion(axiomAnnotations, disjointClass, firstClassExpression, secondClassExpression)
    static member DisjointUnion((disjointClass: Class), (disjointExpressions: Set.TwoOrMore<ClassExpression>)) =
        Functional.DisjointUnion(Set.empty, disjointClass, disjointExpressions)
    static member DisjointUnion
        ((disjointClass: Class), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression), (moreClassExpressions: Set<ClassExpression>))
        =
        Functional.DisjointUnion(Set.empty, disjointClass, firstClassExpression, secondClassExpression, moreClassExpressions)
    static member DisjointUnion((disjointClass: Class), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.DisjointUnion(Set.empty, disjointClass, firstClassExpression, secondClassExpression)
    static member DisjointUnion(disjointClass: Class) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) -> Functional.DisjointUnion(disjointClass, firstClassExpression, secondClassExpression)

    static member ObjectPropertyChain
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: ObjectPropertyExpression list)
        ) =
        {
            objectPropertyChain = List.TwoOrMore.More(firstObjectPropertyExpression, secondObjectPropertyExpression, moreobjectPropertyExpressions)
        }

    static member ObjectPropertyChain((firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression)) = {
        objectPropertyChain = List.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression)
    }

    static member ObjectPropertyChain(chain: List.TwoOrMore<ObjectPropertyExpression>) = { objectPropertyChain = chain }
    static member ObjectPropertyChain(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) -> Functional.ObjectPropertyChain(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member SubObjectPropertyExpression(objectPropertyExpression: ObjectPropertyExpression) =
        SubObjectPropertyExpression objectPropertyExpression

    static member SubObjectPropertyOf
        ((axiomAnnotations: Set<Annotation>), (subObjectPropertyExpression: SubObjectPropertyExpression), (superObjectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                subObjectPropertyExpression = subObjectPropertyExpression
                superObjectPropertyExpression = superObjectPropertyExpression
            }
        )
    static member SubObjectPropertyOf
        ((axiomAnnotations: Set<Annotation>), (subObjectPropertyExpression: ObjectPropertyExpression), (superObjectPropertyExpression: ObjectPropertyExpression))
        =
        Functional.SubObjectPropertyOf(axiomAnnotations, Functional.SubObjectPropertyExpression(subObjectPropertyExpression), superObjectPropertyExpression)
    static member SubObjectPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subObjectPropertyExpression: SubObjectPropertyExpression) ->
            fun (superObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.SubObjectPropertyOf(axiomAnnotations, subObjectPropertyExpression, superObjectPropertyExpression)
    static member SubObjectPropertyOf((subObjectPropertyExpression: SubObjectPropertyExpression), (superObjectPropertyExpression: ObjectPropertyExpression)) =
        Functional.SubObjectPropertyOf(Set.empty, subObjectPropertyExpression, superObjectPropertyExpression)
    static member SubObjectPropertyOf((subObjectPropertyExpression: ObjectPropertyExpression), (superObjectPropertyExpression: ObjectPropertyExpression)) =
        Functional.SubObjectPropertyOf(Set.empty, subObjectPropertyExpression, superObjectPropertyExpression)
    static member SubObjectPropertyOf(subObjectPropertyExpression: SubObjectPropertyExpression) =
        fun (superObjectPropertyExpression: ObjectPropertyExpression) -> Functional.SubObjectPropertyOf(subObjectPropertyExpression, superObjectPropertyExpression)
    static member SubObjectPropertyOf(subObjectPropertyExpression: ObjectPropertyExpression) =
        fun (superObjectPropertyExpression: ObjectPropertyExpression) -> Functional.SubObjectPropertyOf(subObjectPropertyExpression, superObjectPropertyExpression)

    static member EquivalentObjectProperties((axiomAnnotations: Set<Annotation>), (objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                equivalentObjectProperties = objectPropertyExpressions
            }
        )
    static member EquivalentObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.EquivalentObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(firstObjectPropertyExpression, secondObjectPropertyExpression, moreobjectPropertyExpressions)
        )
    static member EquivalentObjectProperties
        ((axiomAnnotations: Set<Annotation>), (firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression))
        =
        Functional.EquivalentObjectProperties(axiomAnnotations, Set.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression))
    static member EquivalentObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.EquivalentObjectProperties(axiomAnnotations, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member EquivalentObjectProperties(objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>) =
        Functional.EquivalentObjectProperties(Set.empty, objectPropertyExpressions)
    static member EquivalentObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.EquivalentObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression, moreobjectPropertyExpressions)
    static member EquivalentObjectProperties((firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression)) =
        Functional.EquivalentObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member EquivalentObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.EquivalentObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member DisjointObjectProperties((axiomAnnotations: Set<Annotation>), (objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                disjointObjectProperties = objectPropertyExpressions
            }
        )
    static member DisjointObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.DisjointObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(firstObjectPropertyExpression, secondObjectPropertyExpression, moreobjectPropertyExpressions)
        )
    static member DisjointObjectProperties
        ((axiomAnnotations: Set<Annotation>), (firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression))
        =
        Functional.DisjointObjectProperties(axiomAnnotations, Set.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression))
    static member DisjointObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.DisjointObjectProperties(axiomAnnotations, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member DisjointObjectProperties(objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>) =
        Functional.DisjointObjectProperties(Set.empty, objectPropertyExpressions)
    static member DisjointObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.DisjointObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression, moreobjectPropertyExpressions)
    static member DisjointObjectProperties((firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression)) =
        Functional.DisjointObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member DisjointObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) -> Functional.DisjointObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member InverseObjectProperties
        ((axiomAnnotations: Set<Annotation>), (firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                inverseObjectProperties = firstObjectPropertyExpression, secondObjectPropertyExpression
            }
        )
    static member InverseObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.InverseObjectProperties(axiomAnnotations, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member InverseObjectProperties((firstObjectPropertyExpression: ObjectPropertyExpression), (secondObjectPropertyExpression: ObjectPropertyExpression)) =
        Functional.InverseObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)
    static member InverseObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) -> Functional.InverseObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member ObjectPropertyDomain((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                objectPropertyExpression = objectPropertyExpression
                objectPropertyDomain = classExpression
            }
        )
    static member ObjectPropertyDomain(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (classExpression: ClassExpression) -> Functional.ObjectPropertyDomain(axiomAnnotations, objectPropertyExpression, classExpression)
    static member ObjectPropertyDomain((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Functional.ObjectPropertyDomain(Set.empty, objectPropertyExpression, classExpression)
    static member ObjectPropertyDomain(objectPropertyExpression: ObjectPropertyExpression) =
        fun (classExpression: ClassExpression) -> Functional.ObjectPropertyDomain(objectPropertyExpression, classExpression)

    static member ObjectPropertyRange((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                objectPropertyExpression = objectPropertyExpression
                objectPropertyRange = classExpression
            }
        )
    static member ObjectPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (classExpression: ClassExpression) -> Functional.ObjectPropertyRange(axiomAnnotations, objectPropertyExpression, classExpression)
    static member ObjectPropertyRange((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression)) =
        Functional.ObjectPropertyRange(Set.empty, objectPropertyExpression, classExpression)
    static member ObjectPropertyRange(objectPropertyExpression: ObjectPropertyExpression) =
        fun (classExpression: ClassExpression) -> Functional.ObjectPropertyRange(objectPropertyExpression, classExpression)

    static member FunctionalObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                functionalObjectProperty = objectPropertyExpression
            }
        )
    static member FunctionalObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.FunctionalObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member FunctionalObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.FunctionalObjectProperty(Set.empty, objectPropertyExpression)

    static member InverseFunctionalObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                inverseFunctionalObjectProperty = objectPropertyExpression
            }
        )
    static member InverseFunctionalObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.InverseFunctionalObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member InverseFunctionalObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.InverseFunctionalObjectProperty(Set.empty, objectPropertyExpression)

    static member ReflexiveObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                reflexiveObjectProperty = objectPropertyExpression
            }
        )
    static member ReflexiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.ReflexiveObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member ReflexiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.ReflexiveObjectProperty(Set.empty, objectPropertyExpression)

    static member IrreflexiveObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                irreflexiveObjectProperty = objectPropertyExpression
            }
        )
    static member IrreflexiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.IrreflexiveObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member IrreflexiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.IrreflexiveObjectProperty(Set.empty, objectPropertyExpression)

    static member SymmetricObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                symmetricObjectProperty = objectPropertyExpression
            }
        )
    static member SymmetricObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.SymmetricObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member SymmetricObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.SymmetricObjectProperty(Set.empty, objectPropertyExpression)

    static member AsymmetricObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                asymmetricObjectProperty = objectPropertyExpression
            }
        )
    static member AsymmetricObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.AsymmetricObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member AsymmetricObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.AsymmetricObjectProperty(Set.empty, objectPropertyExpression)

    static member TransitiveObjectProperty((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                transitiveObjectProperty = objectPropertyExpression
            }
        )
    static member TransitiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) -> Functional.TransitiveObjectProperty(axiomAnnotations, objectPropertyExpression)
    static member TransitiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.TransitiveObjectProperty(Set.empty, objectPropertyExpression)

    static member SubDataPropertyOf
        ((axiomAnnotations: Set<Annotation>), (subDataPropertyExpression: DataPropertyExpression), (superDataPropertyExpression: DataPropertyExpression))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                subDataPropertyExpression = subDataPropertyExpression
                superDataPropertyExpression = superDataPropertyExpression
            }
        )
    static member SubDataPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subDataPropertyExpression: DataPropertyExpression) ->
            fun (superDataPropertyExpression: DataPropertyExpression) ->
                Functional.SubDataPropertyOf(axiomAnnotations, subDataPropertyExpression, superDataPropertyExpression)
    static member SubDataPropertyOf((subDataPropertyExpression: DataPropertyExpression), (superDataPropertyExpression: DataPropertyExpression)) =
        Functional.SubDataPropertyOf(Set.empty, subDataPropertyExpression, superDataPropertyExpression)
    static member SubDataPropertyOf(subDataPropertyExpression: DataPropertyExpression) =
        fun (superDataPropertyExpression: DataPropertyExpression) -> Functional.SubDataPropertyOf(subDataPropertyExpression, superDataPropertyExpression)

    static member EquivalentDataProperties((axiomAnnotations: Set<Annotation>), (dataPropertyExpressions: Set.TwoOrMore<DataPropertyExpression>)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                equivalentDataProperties = dataPropertyExpressions
            }
        )
    static member EquivalentDataProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstDataPropertyExpression: DataPropertyExpression),
            (secondDataPropertyExpression: DataPropertyExpression),
            (moreDataPropertyExpressions: Set<DataPropertyExpression>)
        ) =
        Functional.EquivalentDataProperties(axiomAnnotations, Set.TwoOrMore.More(firstDataPropertyExpression, secondDataPropertyExpression, moreDataPropertyExpressions))
    static member EquivalentDataProperties
        ((axiomAnnotations: Set<Annotation>), (firstDataPropertyExpression: DataPropertyExpression), (secondDataPropertyExpression: DataPropertyExpression))
        =
        Functional.EquivalentDataProperties(axiomAnnotations, Set.TwoOrMore.Two(firstDataPropertyExpression, secondDataPropertyExpression))
    static member EquivalentDataProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstDataPropertyExpression: DataPropertyExpression) ->
            fun (secondDataPropertyExpression: DataPropertyExpression) ->
                Functional.EquivalentDataProperties(axiomAnnotations, firstDataPropertyExpression, secondDataPropertyExpression)
    static member EquivalentDataProperties(dataPropertyExpressions: Set.TwoOrMore<DataPropertyExpression>) =
        Functional.EquivalentDataProperties(Set.empty, dataPropertyExpressions)
    static member EquivalentDataProperties
        (
            (firstDataPropertyExpression: DataPropertyExpression),
            (secondDataPropertyExpression: DataPropertyExpression),
            (moreDataPropertyExpressions: Set<DataPropertyExpression>)
        ) =
        Functional.EquivalentDataProperties(Set.empty, firstDataPropertyExpression, secondDataPropertyExpression, moreDataPropertyExpressions)
    static member EquivalentDataProperties((firstDataPropertyExpression: DataPropertyExpression), (secondDataPropertyExpression: DataPropertyExpression)) =
        Functional.EquivalentDataProperties(Set.empty, firstDataPropertyExpression, secondDataPropertyExpression)
    static member EquivalentDataProperties(firstDataPropertyExpression: DataPropertyExpression) =
        fun (secondDataPropertyExpression: DataPropertyExpression) -> Functional.EquivalentDataProperties(firstDataPropertyExpression, secondDataPropertyExpression)

    static member DisjointDataProperties((axiomAnnotations: Set<Annotation>), (dataPropertyExpressions: Set.TwoOrMore<DataPropertyExpression>)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                disjointDataProperties = dataPropertyExpressions
            }
        )
    static member DisjointDataProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstDataPropertyExpression: DataPropertyExpression),
            (secondDataPropertyExpression: DataPropertyExpression),
            (moreDataPropertyExpressions: Set<DataPropertyExpression>)
        ) =
        Functional.DisjointDataProperties(axiomAnnotations, Set.TwoOrMore.More(firstDataPropertyExpression, secondDataPropertyExpression, moreDataPropertyExpressions))
    static member DisjointDataProperties
        ((axiomAnnotations: Set<Annotation>), (firstDataPropertyExpression: DataPropertyExpression), (secondDataPropertyExpression: DataPropertyExpression))
        =
        Functional.DisjointDataProperties(axiomAnnotations, Set.TwoOrMore.Two(firstDataPropertyExpression, secondDataPropertyExpression))
    static member DisjointDataProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstDataPropertyExpression: DataPropertyExpression) ->
            fun (secondDataPropertyExpression: DataPropertyExpression) ->
                Functional.DisjointDataProperties(axiomAnnotations, firstDataPropertyExpression, secondDataPropertyExpression)
    static member DisjointDataProperties(dataPropertyExpressions: Set.TwoOrMore<DataPropertyExpression>) =
        Functional.DisjointDataProperties(Set.empty, dataPropertyExpressions)
    static member DisjointDataProperties
        (
            (firstDataPropertyExpression: DataPropertyExpression),
            (secondDataPropertyExpression: DataPropertyExpression),
            (moreDataPropertyExpressions: Set<DataPropertyExpression>)
        ) =
        Functional.DisjointDataProperties(Set.empty, firstDataPropertyExpression, secondDataPropertyExpression, moreDataPropertyExpressions)
    static member DisjointDataProperties((firstDataPropertyExpression: DataPropertyExpression), (secondDataPropertyExpression: DataPropertyExpression)) =
        Functional.DisjointDataProperties(Set.empty, firstDataPropertyExpression, secondDataPropertyExpression)
    static member DisjointDataProperties(firstDataPropertyExpression: DataPropertyExpression) =
        fun (secondDataPropertyExpression: DataPropertyExpression) -> Functional.DisjointDataProperties(firstDataPropertyExpression, secondDataPropertyExpression)

    static member DataPropertyDomain((axiomAnnotations: Set<Annotation>), (dataPropertyExpression: DataPropertyExpression), (classExpression: ClassExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                dataPropertyExpression = dataPropertyExpression
                dataPropertyDomain = classExpression
            }
        )
    static member DataPropertyDomain(axiomAnnotations: Set<Annotation>) =
        fun (dataPropertyExpression: DataPropertyExpression) ->
            fun (classExpression: ClassExpression) -> Functional.DataPropertyDomain(axiomAnnotations, dataPropertyExpression, classExpression)
    static member DataPropertyDomain((dataPropertyExpression: DataPropertyExpression), (classExpression: ClassExpression)) =
        Functional.DataPropertyDomain(Set.empty, dataPropertyExpression, classExpression)
    static member DataPropertyDomain(dataPropertyExpression: DataPropertyExpression) =
        fun (classExpression: ClassExpression) -> Functional.DataPropertyDomain(dataPropertyExpression, classExpression)

    static member DataPropertyRange((axiomAnnotations: Set<Annotation>), (dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                dataPropertyExpression = dataPropertyExpression
                dataPropertyRange = dataRange
            }
        )
    static member DataPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (dataPropertyExpression: DataPropertyExpression) ->
            fun (dataRange: DataRange) -> Functional.DataPropertyRange(axiomAnnotations, dataPropertyExpression, dataRange)
    static member DataPropertyRange((dataPropertyExpression: DataPropertyExpression), (dataRange: DataRange)) =
        Functional.DataPropertyRange(Set.empty, dataPropertyExpression, dataRange)
    static member DataPropertyRange(dataPropertyExpression: DataPropertyExpression) =
        fun (dataRange: DataRange) -> Functional.DataPropertyRange(dataPropertyExpression, dataRange)

    static member FunctionalDataProperty((axiomAnnotations: Set<Annotation>), (dataPropertyExpression: DataPropertyExpression)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                functionalDataProperty = dataPropertyExpression
            }
        )
    static member FunctionalDataProperty(axiomAnnotations: Set<Annotation>) =
        fun (dataPropertyExpression: DataPropertyExpression) -> Functional.FunctionalDataProperty(axiomAnnotations, dataPropertyExpression)
    static member FunctionalDataProperty(dataPropertyExpression: DataPropertyExpression) =
        Functional.FunctionalDataProperty(Set.empty, dataPropertyExpression)

    static member DatatypeDefinition((axiomAnnotations: Set<Annotation>), (datatype: Datatype), (dataRange: DataRange)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                datatype = datatype
                dataRange = dataRange
            }
        )
    static member DatatypeDefinition(axiomAnnotations: Set<Annotation>) =
        fun (datatype: Datatype) -> fun (dataRange: DataRange) -> Functional.DatatypeDefinition(axiomAnnotations, datatype, dataRange)
    static member DatatypeDefinition((datatype: Datatype), (dataRange: DataRange)) =
        Functional.DatatypeDefinition(Set.empty, datatype, dataRange)
    static member DatatypeDefinition(datatype: Datatype) =
        fun (dataRange: DataRange) -> Functional.DatatypeDefinition(datatype, dataRange)

    static member ObjectKeyProperties(objectProperties: Set.OneOrMore<ObjectPropertyExpression>) = objectProperties |> ObjectKeyProperties
    static member ObjectKeyProperties((firstObjectPropertyExpression: ObjectPropertyExpression), (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)) =
        Set.OneOrMore.More(firstObjectPropertyExpression, moreobjectPropertyExpressions)
        |> ObjectKeyProperties
    static member ObjectKeyProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        firstObjectPropertyExpression |> Set.OneOrMore.One |> ObjectKeyProperties

    static member DataKeyProperties(dataProperties: Set.OneOrMore<DataPropertyExpression>) = dataProperties |> DataKeyProperties
    static member DataKeyProperties((firstDataPropertyExpression: DataPropertyExpression), (moreDataPropertyExpressions: Set<DataPropertyExpression>)) =
        Set.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions)
        |> DataKeyProperties
    static member DataKeyProperties(firstDataPropertyExpression: DataPropertyExpression) =
        firstDataPropertyExpression |> Set.OneOrMore.One |> DataKeyProperties

    static member ObjectDataKeyProperties((objectProperties: Set.OneOrMore<ObjectPropertyExpression>), (dataProperties: Set.OneOrMore<DataPropertyExpression>)) =
        (objectProperties, dataProperties) |> ObjectDataKeyProperties
    static member ObjectDataKeyProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>),
            (firstDataPropertyExpression: DataPropertyExpression),
            (moreDataPropertyExpressions: Set<DataPropertyExpression>)
        ) =
        (Set.OneOrMore.More(firstObjectPropertyExpression, moreobjectPropertyExpressions), Set.OneOrMore.More(firstDataPropertyExpression, moreDataPropertyExpressions))
        |> ObjectDataKeyProperties
    static member ObjectDataKeyProperties((firstObjectPropertyExpression: ObjectPropertyExpression), (firstDataPropertyExpression: DataPropertyExpression)) =
        (Set.OneOrMore.One firstObjectPropertyExpression, Set.OneOrMore.One firstDataPropertyExpression)
        |> ObjectDataKeyProperties

    static member HasKey((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (keyProperties: KeyProperties)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                classExpression = classExpression
                keyProperties = keyProperties
            }
        )
    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectProperties: Set.OneOrMore<ObjectPropertyExpression>),
            (dataProperties: Set.OneOrMore<DataPropertyExpression>)
        ) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectDataKeyProperties(objectProperties, dataProperties))
    static member HasKey((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (objectProperties: Set.OneOrMore<ObjectPropertyExpression>)) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectKeyProperties(objectProperties))
    static member HasKey((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (dataProperties: Set.OneOrMore<DataPropertyExpression>)) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.DataKeyProperties(dataProperties))
    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectPropertyExpression: ObjectPropertyExpression),
            (dataPropertyExpression: DataPropertyExpression)
        ) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectDataKeyProperties(objectPropertyExpression, dataPropertyExpression))
    static member HasKey((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (objectPropertyExpression: ObjectPropertyExpression)) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectKeyProperties(objectPropertyExpression))
    static member HasKey((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (dataPropertyExpression: DataPropertyExpression)) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.DataKeyProperties(dataPropertyExpression))
    static member HasKey(axiomAnnotations: Set<Annotation>) =
        fun (classExpression: ClassExpression) -> fun (keyProperties: KeyProperties) -> Functional.HasKey(axiomAnnotations, classExpression, keyProperties)
    static member HasKey((classExpression: ClassExpression), (keyProperties: KeyProperties)) =
        Functional.HasKey(Set.empty, classExpression, keyProperties)
    static member HasKey
        ((classExpression: ClassExpression), (objectProperties: Set.OneOrMore<ObjectPropertyExpression>), (dataProperties: Set.OneOrMore<DataPropertyExpression>))
        =
        Functional.HasKey(Set.empty, classExpression, objectProperties, dataProperties)
    static member HasKey((classExpression: ClassExpression), (objectProperties: Set.OneOrMore<ObjectPropertyExpression>)) =
        Functional.HasKey(Set.empty, classExpression, objectProperties)
    static member HasKey((classExpression: ClassExpression), (dataProperties: Set.OneOrMore<DataPropertyExpression>)) =
        Functional.HasKey(Set.empty, classExpression, dataProperties)
    static member HasKey((classExpression: ClassExpression), (objectPropertyExpression: ObjectPropertyExpression), (dataPropertyExpression: DataPropertyExpression)) =
        Functional.HasKey(Set.empty, classExpression, objectPropertyExpression, dataPropertyExpression)
    static member HasKey((classExpression: ClassExpression), (objectPropertyExpression: ObjectPropertyExpression)) =
        Functional.HasKey(Set.empty, classExpression, objectPropertyExpression)
    static member HasKey((classExpression: ClassExpression), (dataPropertyExpression: DataPropertyExpression)) =
        Functional.HasKey(Set.empty, classExpression, dataPropertyExpression)
    static member HasKey(classExpression: ClassExpression) =
        fun (keyProperties: KeyProperties) -> Functional.HasKey(classExpression, keyProperties)

    static member SameIndividual((axiomAnnotations: Set<Annotation>), (individuals: Set.TwoOrMore<Individual>)) =
        Annotated.Annotate(axiomAnnotations, { SameIndividual = individuals })
    static member SameIndividual((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>)) =
        Functional.SameIndividual(axiomAnnotations, Set.TwoOrMore.More(firstIndividual, secondIndividual, moreIndividuals))
    static member SameIndividual((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.SameIndividual(axiomAnnotations, Set.TwoOrMore.Two(firstIndividual, secondIndividual))
    static member SameIndividual(axiomAnnotations: Set<Annotation>) =
        fun (firstIndividual: Individual) -> fun (secondIndividual: Individual) -> Functional.SameIndividual(axiomAnnotations, firstIndividual, secondIndividual)
    static member SameIndividual(individuals: Set.TwoOrMore<Individual>) =
        Functional.SameIndividual(Set.empty, individuals)
    static member SameIndividual((firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>)) =
        Functional.SameIndividual(Set.empty, firstIndividual, secondIndividual, moreIndividuals)
    static member SameIndividual((firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.SameIndividual(Set.empty, firstIndividual, secondIndividual)
    static member SameIndividual(firstIndividual: Individual) =
        fun (secondIndividual: Individual) -> Functional.SameIndividual(firstIndividual, secondIndividual)

    static member DifferentIndividuals((axiomAnnotations: Set<Annotation>), (individuals: Set.TwoOrMore<Individual>)) =
        Annotated.Annotate(axiomAnnotations, { DifferentIndividuals = individuals })
    static member DifferentIndividuals
        ((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>))
        =
        Functional.DifferentIndividuals(axiomAnnotations, Set.TwoOrMore.More(firstIndividual, secondIndividual, moreIndividuals))
    static member DifferentIndividuals((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.DifferentIndividuals(axiomAnnotations, Set.TwoOrMore.Two(firstIndividual, secondIndividual))
    static member DifferentIndividuals(axiomAnnotations: Set<Annotation>) =
        fun (firstIndividual: Individual) -> fun (secondIndividual: Individual) -> Functional.DifferentIndividuals(axiomAnnotations, firstIndividual, secondIndividual)
    static member DifferentIndividuals(individuals: Set.TwoOrMore<Individual>) =
        Functional.DifferentIndividuals(Set.empty, individuals)
    static member DifferentIndividuals((firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>)) =
        Functional.DifferentIndividuals(Set.empty, firstIndividual, secondIndividual, moreIndividuals)
    static member DifferentIndividuals((firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.DifferentIndividuals(Set.empty, firstIndividual, secondIndividual)
    static member DifferentIndividuals(firstIndividual: Individual) =
        fun (secondIndividual: Individual) -> Functional.DifferentIndividuals(firstIndividual, secondIndividual)

    // Assertion tupled overloads retain Functional-Syntax order; curried overloads use triple order.
    static member ClassAssertion((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (individual: Individual)) =
        Annotated.Annotate(
            axiomAnnotations,
            {
                individual = individual
                classExpression = classExpression
            }
        )
    static member ClassAssertion(axiomAnnotations: Set<Annotation>) =
        fun (individual: Individual) -> fun (classExpression: ClassExpression) -> Functional.ClassAssertion(axiomAnnotations, classExpression, individual)
    static member ClassAssertion((classExpression: ClassExpression), (individual: Individual)) =
        Functional.ClassAssertion(Set.empty, classExpression, individual)
    static member ClassAssertion(individual: Individual) =
        fun (classExpression: ClassExpression) -> Functional.ClassAssertion(classExpression, individual)
    static member ClassAssertion(individuals: Individual list) =
        fun (classExpression: ClassExpression) ->
            individuals
            |> List.map (fun individual -> Functional.ClassAssertion(classExpression, individual))

    static member ObjectPropertyAssertion
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression), (sourceIndividual: Individual), (targetIndividual: Individual))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                sourceIndividual = sourceIndividual
                objectPropertyExpression = objectPropertyExpression
                targetIndividual = targetIndividual
            }
        )
    static member ObjectPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                fun (targetIndividual: Individual) -> Functional.ObjectPropertyAssertion(axiomAnnotations, objectPropertyExpression, sourceIndividual, targetIndividual)
    static member ObjectPropertyAssertion((objectPropertyExpression: ObjectPropertyExpression), (sourceIndividual: Individual), (targetIndividual: Individual)) =
        Functional.ObjectPropertyAssertion(Set.empty, objectPropertyExpression, sourceIndividual, targetIndividual)
    static member ObjectPropertyAssertion(sourceIndividual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (targetIndividual: Individual) -> Functional.ObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)

    static member NegativeObjectPropertyAssertion
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression), (sourceIndividual: Individual), (targetIndividual: Individual))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                sourceIndividual = sourceIndividual
                negativeObjectPropertyExpression = objectPropertyExpression
                targetIndividual = targetIndividual
            }
        )
    static member NegativeObjectPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                fun (targetIndividual: Individual) ->
                    Functional.NegativeObjectPropertyAssertion(axiomAnnotations, objectPropertyExpression, sourceIndividual, targetIndividual)
    static member NegativeObjectPropertyAssertion((objectPropertyExpression: ObjectPropertyExpression), (sourceIndividual: Individual), (targetIndividual: Individual)) =
        Functional.NegativeObjectPropertyAssertion(Set.empty, objectPropertyExpression, sourceIndividual, targetIndividual)
    static member NegativeObjectPropertyAssertion(sourceIndividual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (targetIndividual: Individual) -> Functional.NegativeObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)

    static member DataPropertyAssertion
        ((axiomAnnotations: Set<Annotation>), (dataPropertyExpression: DataPropertyExpression), (sourceIndividual: Individual), (targetValue: Literal))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                sourceIndividual = sourceIndividual
                dataPropertyExpression = dataPropertyExpression
                targetValue = targetValue
            }
        )
    static member DataPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (dataPropertyExpression: DataPropertyExpression) ->
                fun (targetValue: Literal) -> Functional.DataPropertyAssertion(axiomAnnotations, dataPropertyExpression, sourceIndividual, targetValue)
    static member DataPropertyAssertion((dataPropertyExpression: DataPropertyExpression), (sourceIndividual: Individual), (targetValue: Literal)) =
        Functional.DataPropertyAssertion(Set.empty, dataPropertyExpression, sourceIndividual, targetValue)
    static member DataPropertyAssertion(sourceIndividual: Individual) =
        fun (dataPropertyExpression: DataPropertyExpression) ->
            fun (targetValue: Literal) -> Functional.DataPropertyAssertion(dataPropertyExpression, sourceIndividual, targetValue)

    static member NegativeDataPropertyAssertion
        ((axiomAnnotations: Set<Annotation>), (dataPropertyExpression: DataPropertyExpression), (sourceIndividual: Individual), (targetValue: Literal))
        =
        Annotated.Annotate(
            axiomAnnotations,
            {
                sourceIndividual = sourceIndividual
                negativeDataPropertyExpression = dataPropertyExpression
                targetValue = targetValue
            }
        )
    static member NegativeDataPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (dataPropertyExpression: DataPropertyExpression) ->
                fun (targetValue: Literal) -> Functional.NegativeDataPropertyAssertion(axiomAnnotations, dataPropertyExpression, sourceIndividual, targetValue)
    static member NegativeDataPropertyAssertion((dataPropertyExpression: DataPropertyExpression), (sourceIndividual: Individual), (targetValue: Literal)) =
        Functional.NegativeDataPropertyAssertion(Set.empty, dataPropertyExpression, sourceIndividual, targetValue)
    static member NegativeDataPropertyAssertion(sourceIndividual: Individual) =
        fun (dataPropertyExpression: DataPropertyExpression) ->
            fun (targetValue: Literal) -> Functional.NegativeDataPropertyAssertion(dataPropertyExpression, sourceIndividual, targetValue)
