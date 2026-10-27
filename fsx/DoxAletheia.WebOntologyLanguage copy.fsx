// TODO use dynamic operator for namespacenames for adhoc local names
// TODO add op_Implicits to literal values

#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "DoxAletheia.Core.dll"
#r "DoxAletheia.ResourceDescriptionFramework.dll"
open DoxAletheia.Core
open DoxAletheia.ResourceDescriptionFramework
#load @".paket/load/main.group.fsx"

open System
open System.Collections
open System.IO
open System.Globalization
open System.Security.Cryptography
open System.Text
open System.Text.Json
open System.Text.RegularExpressions
open System.Xml
open System.Xml.Linq

open Dubzer.WhatwgUrl
open IriTools
open VDS.RDF
open VDS.RDF.Ontology
open VDS.RDF.Parsing
open RDFSharp.Model
open NLanguageTag
open OWLSharp
open OWLSharp.Extensions
open OWLSharp.Ontology
open OWLSharp.Profiler
open OWLSharp.Reasoner
open OWLSharp.Validator

open FSharp.Data
open FSharpPlus
open Newtonsoft.Json.Linq
open Meziantou.Framework

type OntologyResource with

    member this.tryUriNode =
        match this.Resource with
        | :? UriNode as uriNode -> Some uriNode
        | _ -> None
    member this.UriNode = this.Resource :?> UriNode

type OntologyGraph with
    member this.UriNodeClasses = this.AllClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeProperties = this.AllProperties |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeRdfClasses = this.RdfClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeRdfProperties = this.RdfProperties |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlObjectProperties =
        this.OwlObjectProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlDataProperties =
        this.OwlDatatypeProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlAnnotationProperties =
        this.OwlAnnotationProperties
        |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.UriNodeOwlClasses = this.OwlClasses |> Seq.filter (fun resource -> resource.tryUriNode.IsSome)
    member this.namespaceClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceRdfClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeRdfClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceRdfProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeRdfProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlClasses(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlClasses
        |> Seq.filter (fun ontologyClass -> rdfNamespace.UrlPattern.IsMatch ontologyClass.UriNode.Uri.OriginalString)

    member this.namespaceOwlObjectProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlObjectProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlDatatypeProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlDataProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)

    member this.namespaceOwlAnnotationProperties(rdfNamespace: RDFNamespace) =
        this.UriNodeOwlAnnotationProperties
        |> Seq.filter (fun ontologyProperty -> rdfNamespace.UrlPattern.IsMatch ontologyProperty.UriNode.Uri.OriginalString)
type OWLOntologyView with
    static member tryOntologyGraph(ontologyGraph: OntologyGraph) =
        match ontologyGraph.tryFullNormativeGraph with
        | Some fullyNormativeGraph ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> new OWLOntologyView(OWLOntology.FromRDFGraphAsync(rdfGraph).Result))
        | None -> None
type OntologyClass with
    static member ofOWLClass((owlClass: OWLClass), (owlOntology: OWLOntology)) =
        new OntologyClass(
            Iri.ofOWLClass owlClass,
            owlOntology.ToRDFGraphAsync().Result
            |> FullNormativeGraph.ofRDFGraph
            |> _.asThreadSafeGraph
        )
type OWLClassView with
    static member tryOntologyClass((ontologyClass: OntologyClass), (ontologyGraph: OntologyGraph)) =
        match ontologyGraph.tryFullNormativeGraph, Iri.tryOntologyResource ontologyClass with
        | Some fullyNormativeGraph, Some iri ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> new OWLClassView(iri, OWLOntology.FromRDFGraphAsync(rdfGraph).Result))
        | _, _ -> None

type OWLOntology with
    member this.ToAssertedTurtle(turtlePath: string) =
        this.ToRDFGraphAsync(false).Result.ToTurtle turtlePath
    member this.ToInferredTurtle(turtlePath: string) =
        this.ToRDFGraphAsync(true).Result.ToTurtle turtlePath
    member this.Assert(axiom: OWLDeclaration) = this.DeclarationAxioms.Add axiom

    member this.Assert(axiom: OWLClassAxiom) = this.ClassAxioms.Add axiom

    member this.Assert(axiom: OWLObjectPropertyAxiom) = this.ObjectPropertyAxioms.Add axiom

    member this.Assert(axiom: OWLDataPropertyAxiom) = this.DataPropertyAxioms.Add axiom

    member this.Assert(axiom: OWLDatatypeDefinition) = this.DatatypeDefinitionAxioms.Add axiom

    member this.Assert(axiom: OWLHasKey) = this.KeyAxioms.Add axiom

    member this.Assert(axiom: OWLAssertionAxiom) = this.AssertionAxioms.Add axiom

    member this.Assert(axiom: OWLAnnotationAxiom) = this.AnnotationAxioms.Add axiom
    static member tryOntologyGraph(ontologyGraph: OntologyGraph) =
        match ontologyGraph.tryFullNormativeGraph with
        | Some fullyNormativeGraph ->
            fullyNormativeGraph.tryRDFGraph
            |> Option.map (fun rdfGraph -> OWLOntology.FromRDFGraphAsync(rdfGraph) |> fun task -> task.Result)
        | None -> None

type OntologyGraph with

    member this.tryOWLClassViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->
            this.namespaceOwlClasses rdfNamespace
            |> Seq.choose (fun ontologyClass ->
                match Iri.tryOntologyResource ontologyClass with
                | Some iri -> new OWLClassView(iri, owlOntology) |> Some
                | _ -> None)

            |> Seq.toArray
            |> Some
        | None -> None

    member this.tryOWLDataPropertyViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->
            this.namespaceOwlDatatypeProperties rdfNamespace
            |> Seq.choose (fun ontologyProperty ->
                match Iri.tryOntologyResource ontologyProperty with
                | Some iri -> new OWLDataPropertyView(OWLDataProperty iri, owlOntology) |> Some
                | _ -> None)
            |> Seq.toArray
            |> Some
        | None -> None
    member this.namespaceOWLObjectPropertyViews(rdfNamespace: RDFNamespace) =
        match OWLOntology.tryOntologyGraph this with
        | Some owlOntology ->

            this.namespaceOwlObjectProperties rdfNamespace
            |> Seq.choose (fun ontologyProperty ->
                match Iri.tryOntologyResource ontologyProperty with
                | Some iri -> new OWLObjectPropertyView(OWLObjectProperty iri, owlOntology) |> Some
                | _ -> None)
            |> Seq.toArray
            |> Some
        | None -> None

type OWLOntologyView with
    member this.AnnotationAssertionCount = this.AnnotationAssertionCountAsync().Result
    member this.AnnotationPropertyCount = this.AnnotationPropertyCountAsync().Result
    member this.AnnotationPropertyDomainCount = this.AnnotationPropertyDomainCountAsync().Result
    member this.AnnotationPropertyRangeCount = this.AnnotationPropertyRangeCountAsync().Result
    member this.AnnotationsCount = this.AnnotationsCountAsync().Result
    member this.AsymmetricObjectPropertyCount = this.AsymmetricObjectPropertyCountAsync().Result
    member this.ClassAssertionCount = this.ClassAssertionCountAsync().Result
    member this.ClassCount = this.ClassCountAsync().Result
    member this.DataPropertyAssertionCount = this.DataPropertyAssertionCountAsync().Result
    member this.DataPropertyCount = this.DataPropertyCountAsync().Result
    member this.DataPropertyDomainCount = this.DataPropertyDomainCountAsync().Result
    member this.DataPropertyRangeCount = this.DataPropertyRangeCountAsync().Result
    member this.DatatypeCount = this.DatatypeCountAsync().Result
    member this.DatatypeDefinitionCount = this.DatatypeDefinitionCountAsync().Result
    member this.DeclarationCount = this.DeclarationCountAsync().Result
    member this.DifferentIndividualsCount = this.DifferentIndividualsCountAsync().Result
    member this.DisjointClassesCount = this.DisjointClassesCountAsync().Result
    member this.DisjointDataPropertiesCount = this.DisjointDataPropertiesCountAsync().Result
    member this.DisjointObjectPropertiesCount = this.DisjointObjectPropertiesCountAsync().Result
    member this.DisjointUnionCount = this.DisjointUnionCountAsync().Result
    member this.EquivalentClassesCount = this.EquivalentClassesCountAsync().Result
    member this.EquivalentDataPropertiesCount = this.EquivalentDataPropertiesCountAsync().Result
    member this.EquivalentObjectPropertiesCount = this.EquivalentObjectPropertiesCountAsync().Result
    member this.FunctionalDataPropertyCount = this.FunctionalDataPropertyCountAsync().Result
    member this.FunctionalObjectPropertyCount = this.FunctionalObjectPropertyCountAsync().Result
    member this.ImportsCount = this.ImportsCountAsync().Result
    member this.InverseFunctionalObjectPropertyCount = this.InverseFunctionalObjectPropertyCountAsync().Result
    member this.InverseObjectPropertiesCount = this.InverseObjectPropertiesCountAsync().Result
    member this.IrreflexiveObjectPropertyCount = this.IrreflexiveObjectPropertyCountAsync().Result
    member this.KeyCount = this.KeyCountAsync().Result
    member this.NamedIndividualCount = this.NamedIndividualCountAsync().Result
    member this.NegativeDataPropertyAssertionCount = this.NegativeDataPropertyAssertionCountAsync().Result
    member this.NegativeObjectPropertyAssertionCount = this.NegativeObjectPropertyAssertionCountAsync().Result
    member this.ObjectPropertyAssertionCount = this.ObjectPropertyAssertionCountAsync().Result
    member this.ObjectPropertyCount = this.ObjectPropertyCountAsync().Result
    member this.ObjectPropertyDomainCount = this.ObjectPropertyDomainCountAsync().Result
    member this.ObjectPropertyRangeCount = this.ObjectPropertyRangeCountAsync().Result
    member this.PrefixesCount = this.PrefixesCountAsync().Result
    member this.ReflexiveObjectPropertyCount = this.ReflexiveObjectPropertyCountAsync().Result
    member this.SameIndividualCount = this.SameIndividualCountAsync().Result
    member this.SubAnnotationPropertyOfCount = this.SubAnnotationPropertyOfCountAsync().Result
    member this.SubClassOfCount = this.SubClassOfCountAsync().Result
    member this.SubDataPropertyOfCount = this.SubDataPropertyOfCountAsync().Result
    member this.SubObjectPropertyOfCount = this.SubObjectPropertyOfCountAsync().Result
    member this.SymmetricObjectPropertyCount = this.SymmetricObjectPropertyCountAsync().Result
    member this.TransitiveObjectPropertyCount = this.TransitiveObjectPropertyCountAsync().Result

type OWLClassView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DisjointClasses = this.DisjointClassesAsync().Result |> Seq.toArray
    member this.EquivalentClasses = this.EquivalentClassesAsync().Result |> Seq.toArray
    member this.Individuals = this.IndividualsAsync().Result |> Seq.toArray
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.Keys = this.KeysAsync().Result |> Seq.toArray
    member this.NegativeIndividuals = this.NegativeIndividualsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.SubClasses = this.SubClassesAsync().Result |> Seq.toArray
    member this.SuperClasses = this.SuperClassesAsync().Result |> Seq.toArray
type OWLDataPropertyView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DataAssertions = this.DataAssertionsAsync().Result |> Seq.toArray
    member this.DisjointDataProperties = this.DisjointDataPropertiesAsync().Result |> Seq.toArray
    member this.Domains = this.DomainsAsync().Result |> Seq.toArray
    member this.EquivalentDataProperties = this.EquivalentDataPropertiesAsync().Result |> Seq.toArray
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.IsFunctional = this.IsFunctionalAsync().Result
    member this.NegativeDataAssertions = this.NegativeDataAssertionsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.Ranges = this.RangesAsync().Result |> Seq.toArray
    member this.SubDataProperties = this.SubDataPropertiesAsync().Result |> Seq.toArray
    member this.SuperDataProperties = this.SuperDataPropertiesAsync().Result |> Seq.toArray
//
type OWLObjectPropertyView with
    member this.DataAnnotations = this.DataAnnotationsAsync().Result |> Seq.toArray
    member this.DisjointObjectProperties = this.DisjointObjectPropertiesAsync().Result |> Seq.toArray
    member this.Domains = this.DomainsAsync().Result |> Seq.toArray
    member this.EquivalentObjectProperties = this.EquivalentObjectPropertiesAsync().Result |> Seq.toArray
    member this.InverseObjectProperties = this.InverseObjectPropertiesAsync().Result |> Seq.toArray
    member this.IsAsymmetric = this.IsAsymmetricAsync().Result
    member this.IsDeprecated = this.IsDeprecatedAsync().Result
    member this.IsFunctional = this.IsFunctionalAsync().Result
    member this.IsInverseFunctional = this.IsInverseFunctionalAsync().Result
    member this.IsIrreflexive = this.IsIrreflexiveAsync().Result
    member this.IsReflexive = this.IsReflexiveAsync().Result
    member this.IsSymmetric = this.IsSymmetricAsync().Result
    member this.IsTransitive = this.IsTransitiveAsync().Result
    member this.NegativeObjectAssertions = this.NegativeObjectAssertionsAsync().Result |> Seq.toArray
    member this.ObjectAnnotations = this.ObjectAnnotationsAsync().Result |> Seq.toArray
    member this.ObjectAssertions = this.ObjectAssertionsAsync().Result |> Seq.toArray
    member this.Ranges = this.RangesAsync().Result |> Seq.toArray
    member this.SubObjectProperties = this.SubObjectPropertiesAsync().Result |> Seq.toArray
    member this.SuperObjectProperties = this.SuperObjectPropertiesAsync().Result |> Seq.toArray
type OWLIndividualExpression with
    member this.a<'ClassExpression when 'ClassExpression :> OWLClassExpression>(classExpression: 'ClassExpression) =
        match this with
        | :? OWLNamedIndividual as namedIndividual -> OWLClassAssertion(classExpression, namedIndividual)
        | :? OWLAnonymousIndividual as anonymousIndividual -> OWLClassAssertion(classExpression, anonymousIndividual)

type OWLClass with
    member this.Class = this :> OWLClassExpression

module Owl2 =
    type Annotated<'Entity> = {
        Annotations: OWLAnnotation list
        Value: 'Entity
    } with

        static member ofEntity(entity: 'Entity) = { Annotations = []; Value = entity }
    type FunctionalSyntax =

        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: Iri), (annotationObject: Iri)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationObject)
        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: Iri), (annotationObject: BNode)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationObject)
        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: Iri), (annotationValue: LiteralValue)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationValue)
        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: BNode), (annotationObject: Iri)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationObject)
        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: BNode), (annotationObject: BNode)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationObject)
        static member AnnotationAssertion((annotationProperty: OWLAnnotationProperty), (annotationSubject: BNode), (annotationValue: LiteralValue)) =
            new OWLAnnotationAssertion(annotationProperty, annotationSubject, annotationValue)
        static member AnnotationProperty(iri: Iri) = new OWLAnnotationProperty(iri)
        static member ObjectProperty(iri: Iri) = new OWLObjectProperty(iri)
        static member AsymmetricObjectProperty(iri: Iri) =
            new OWLAsymmetricObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member AsymmetricObjectProperty(inverse: OWLObjectInverseOf) =
            new OWLAsymmetricObjectProperty(inverse)
        static member Class(iri: Iri) = new OWLClass(iri)
        static member Class(bnode: BNode) = new OWLClass(bnode)
        static member NamedIndividual(iri: Iri) = new OWLNamedIndividual(iri)
        static member AnonymousIndividual(bnode: BNode) =
            new OWLAnonymousIndividual(bnode.identity)
        static member Individual(iri: Iri) =
            new OWLNamedIndividual(iri) :> OWLIndividualExpression
        static member Individual(bnode: BNode) =
            new OWLAnonymousIndividual(bnode.identity) :> OWLIndividualExpression
        static member Annotation((annotationProperty: OWLAnnotationProperty), (iri: Iri)) =
            new OWLAnnotation(annotationProperty, iri)
        static member Annotation((annotationProperty: OWLAnnotationProperty), (bnode: BNode)) =
            new OWLAnnotation(annotationProperty, FunctionalSyntax.AnonymousIndividual bnode)
        static member Annotation((annotationProperty: OWLAnnotationProperty), (literal: LiteralValue)) =
            new OWLAnnotation(annotationProperty, literal)
        static member Annotation(iri: Iri) =
            fun (annotationProperty: OWLAnnotationProperty) -> new OWLAnnotation(annotationProperty, iri)
        static member Annotation(bnode: BNode) =
            fun (annotationProperty: OWLAnnotationProperty) -> new OWLAnnotation(annotationProperty, FunctionalSyntax.AnonymousIndividual bnode)
        static member Annotation(literal: LiteralValue) =
            fun (annotationProperty: OWLAnnotationProperty) -> new OWLAnnotation(annotationProperty, literal)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>
            ((classExpression: 'ClassExpression), (individual: OWLIndividualExpression))
            =
            individual.a classExpression
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>
            ((classExpression: 'ClassExpression), (individuals: OWLIndividualExpression list))
            =
            individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>
            ((classExpression: 'ClassExpression), (individuals: OWLNamedIndividual list))
            =
            individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>
            ((classExpression: 'ClassExpression), (individuals: OWLAnonymousIndividual list))
            =
            individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>((classExpression: 'ClassExpression), (iri: Iri)) =
            new OWLClassAssertion(classExpression, FunctionalSyntax.NamedIndividual iri)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>((classExpression: 'ClassExpression), (bnode: BNode)) =
            new OWLClassAssertion(classExpression, FunctionalSyntax.AnonymousIndividual bnode)
        static member ClassAssertion(individual: OWLIndividualExpression) =
            fun (classExpression: OWLClassExpression) -> individual.a classExpression
        static member ClassAssertion(individuals: OWLIndividualExpression list) =
            fun (classExpression: OWLClassExpression) -> individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion(individuals: OWLNamedIndividual list) =
            fun (classExpression: OWLClassExpression) -> individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion(individuals: OWLAnonymousIndividual list) =
            fun (classExpression: OWLClassExpression) -> individuals |> List.map (fun individual -> individual.a classExpression)
        static member ClassAssertion<'ClassExpression when 'ClassExpression :> OWLClassExpression>(iri: Iri) =
            fun (classExpression: 'ClassExpression) -> new OWLClassAssertion(classExpression, FunctionalSyntax.NamedIndividual iri)
        static member ClassAssertion(bnode: BNode) =
            fun (classExpression: OWLClassExpression) -> new OWLClassAssertion(classExpression, FunctionalSyntax.AnonymousIndividual bnode)
        static member DataAllValuesFrom((dataProperty: OWLDataProperty), (dataRangeExpression: OWLDataRangeExpression)) =
            new OWLDataAllValuesFrom(dataProperty, dataRangeExpression)
        static member DataAllValuesFrom(dataProperty: OWLDataProperty) =
            fun (dataRangeExpression: OWLDataRangeExpression) -> new OWLDataAllValuesFrom(dataProperty, dataRangeExpression)
        static member DataComplementOf(dataRange: OWLDataRangeExpression) = new OWLDataComplementOf(dataRange)
        static member DataComplementOf(iri: Iri) =
            new OWLDataComplementOf(DatatypeIri iri)
        static member DataHasValue((dataProperty: OWLDataProperty), (literal: LiteralValue)) =
            new OWLDataHasValue(dataProperty, literal)
        static member DataHasValue((dataProperty: OWLDataProperty), (literal: OWLLiteral)) =
            new OWLDataHasValue(dataProperty, literal)
        static member DataHasValue(literal: OWLLiteral) =
            fun (dataProperty: OWLDataProperty) -> new OWLDataHasValue(dataProperty, literal)
        static member DataHasValue(literal: LiteralValue) =
            fun (dataProperty: OWLDataProperty) -> new OWLDataHasValue(dataProperty, literal)
        static member DataIntersectionOf(dataRanges: OWLDataRangeExpression list) =
            new OWLDataIntersectionOf(Generic.List dataRanges)
        static member DataMaxCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty) =
            new OWLDataMaxCardinality(dataProperty, cardinality)

        static member DataMaxCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty, dataRangeExpression: OWLDataRangeExpression) =
            new OWLDataMaxCardinality(dataProperty, cardinality, dataRangeExpression)
        static member DataMinCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty) =
            new OWLDataMinCardinality(dataProperty, cardinality)

        static member DataMinCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty, dataRangeExpression: OWLDataRangeExpression) =
            new OWLDataMinCardinality(dataProperty, cardinality, dataRangeExpression)

        static member DataExactCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty) =
            new OWLDataExactCardinality(dataProperty, cardinality)

        static member DataExactCardinality(cardinality: NonNegativeInteger, dataProperty: OWLDataProperty, dataRangeExpression: OWLDataRangeExpression) =
            new OWLDataExactCardinality(dataProperty, cardinality, dataRangeExpression)

        static member DataOneOf(literals: OWLLiteral list) = new OWLDataOneOf(Generic.List literals)
        static member DataProperty(iri: Iri) = new OWLDataProperty(iri)
        static member DataPropertyAssertion((dataProperty: OWLDataProperty), (individual: OWLIndividualExpression), (literal: OWLLiteral)) =
            match individual with
            | :? OWLNamedIndividual as namedIndividual -> OWLDataPropertyAssertion(dataProperty, namedIndividual, literal)
            | :? OWLAnonymousIndividual as anonymousIndividual -> OWLDataPropertyAssertion(dataProperty, anonymousIndividual, literal)

        static member DataPropertyAssertion(individual: OWLIndividualExpression) =
            fun (dataProperty: OWLDataProperty) ->
                fun (literal: OWLLiteral) ->
                    match individual with
                    | :? OWLNamedIndividual as namedIndividual -> OWLDataPropertyAssertion(dataProperty, namedIndividual, literal)
                    | :? OWLAnonymousIndividual as anonymousIndividual -> OWLDataPropertyAssertion(dataProperty, anonymousIndividual, literal)

        static member NegativeDataPropertyAssertion((dataProperty: OWLDataProperty), (individual: OWLIndividualExpression), (literal: OWLLiteral)) =
            match individual with
            | :? OWLNamedIndividual as namedIndividual -> OWLNegativeDataPropertyAssertion(dataProperty, namedIndividual, literal)
            | :? OWLAnonymousIndividual as anonymousIndividual -> OWLNegativeDataPropertyAssertion(dataProperty, anonymousIndividual, literal)

        static member NegativeDataPropertyAssertion(individual: OWLIndividualExpression) =
            fun (dataProperty: OWLDataProperty) ->
                fun (literal: OWLLiteral) ->
                    match individual with
                    | :? OWLNamedIndividual as namedIndividual -> OWLNegativeDataPropertyAssertion(dataProperty, namedIndividual, literal)
                    | :? OWLAnonymousIndividual as anonymousIndividual -> OWLNegativeDataPropertyAssertion(dataProperty, anonymousIndividual, literal)
        static member DataPropertyDomain((dataProperty: OWLDataProperty), (classExpression: OWLClassExpression)) =
            new OWLDataPropertyDomain(dataProperty, classExpression)
        static member DataPropertyDomain(dataProperty: OWLDataProperty) =
            fun (classExpression: OWLClassExpression) -> new OWLDataPropertyDomain(dataProperty, classExpression)
        static member DataPropertyRange((dataProperty: OWLDataProperty), (owlDataRangeExpression: OWLDataRangeExpression)) =
            new OWLDataPropertyRange(dataProperty, owlDataRangeExpression)
        static member DataPropertyRange(dataProperty: OWLDataProperty) =
            fun (owlDataRangeExpression: OWLDataRangeExpression) -> new OWLDataPropertyRange(dataProperty, owlDataRangeExpression)
        static member DataSomeValuesFrom((dataProperty: OWLDataProperty), (dataRangeExpression: OWLDataRangeExpression)) =
            new OWLDataSomeValuesFrom(dataProperty, dataRangeExpression)
        static member DataSomeValuesFrom(dataProperty: OWLDataProperty) =
            fun (dataRangeExpression: OWLDataRangeExpression) -> new OWLDataSomeValuesFrom(dataProperty, dataRangeExpression)
        static member Datatype(iri: Iri) = new OWLDatatype(iri)
        static member Datatype(datatypeIri: DatatypeIri) = new OWLDatatype(datatypeIri)
        static member DatatypeDefinition((datatype: DatatypeIri), (dataRangeExpression: OWLDataRangeExpression)) =
            new OWLDatatypeDefinition(datatype, dataRangeExpression)
        static member DatatypeDefinition(dataRangeExpression: OWLDataRangeExpression) =
            fun (datatype: DatatypeIri) -> new OWLDatatypeDefinition(datatype, dataRangeExpression)
        static member DatatypeRestriction(datatype: DatatypeIri) =
            fun (facetRestrictions: OWLFacetRestriction list) -> new OWLDatatypeRestriction(datatype, Generic.List facetRestrictions)
        static member DataUnionOf(dataRanges: OWLDataRangeExpression list) =
            new OWLDataUnionOf(Generic.List dataRanges)
        static member Declaration(owlClass: OWLClass) = new OWLDeclaration(owlClass)
        static member Declaration((axiomAnnotations: OWLAnnotation list), (owlClass: OWLClass)) = [ new OWLDeclaration(owlClass) ]
        static member Declaration(owlDatatype: OWLDatatype) = new OWLDeclaration(owlDatatype)
        static member Declaration(owlObjectProperty: OWLObjectProperty) = new OWLDeclaration(owlObjectProperty)
        static member Declaration(owlDataProperty: OWLDataProperty) = new OWLDeclaration(owlDataProperty)
        static member Declaration(owlAnnotationProperty: OWLAnnotationProperty) =
            new OWLDeclaration(owlAnnotationProperty)
        static member Declaration(owlNamedIndividual: OWLNamedIndividual) = new OWLDeclaration(owlNamedIndividual)
        // static member DifferentIndividuals<'IndividualExpression when 'IndividualExpression :> OWLIndividualExpression> (individualExpressions:'IndividualExpression list)  = individualExpressions |> List.map (fun individualExpression -> individualExpression :> OWLIndividualExpression) |> Generic.List |> OWLDifferentIndividuals
        static member DisjointClasses(classExpressions: OWLClassExpression list) =
            classExpressions |> Generic.List |> OWLDisjointClasses
        static member DisjointDataProperties(classExpressions: OWLDataProperty list) =
            classExpressions |> Generic.List |> OWLDisjointDataProperties

        static member DisjointObjectProperties(classExpressions: OWLObjectPropertyExpression list) =
            classExpressions |> Generic.List |> OWLDisjointObjectProperties
        static member DisjointUnion((owlClass: OWLClass), (disjointClassExpressions: OWLClassExpression list)) =
            new OWLDisjointUnion(owlClass, Generic.List disjointClassExpressions)
        static member DisjointUnion(owlClass: OWLClass) =
            fun (disjointClassExpressions: OWLClassExpression list) -> new OWLDisjointUnion(owlClass, Generic.List disjointClassExpressions)
        // static member EquivalentClasses<'ClassExpression when 'ClassExpression :> OWLClassExpression> (classExpressions:'ClassExpression list)  = classExpressions |> List.map (fun classExpression -> classExpression :> OWLClassExpression) |> Generic.List |> OWLEquivalentClasses
        static member EquivalentDataProperties(classExpressions: OWLDataProperty list) =
            classExpressions |> Generic.List |> OWLEquivalentDataProperties
        static member EquivalentObjectProperties(classExpressions: OWLObjectPropertyExpression list) =
            classExpressions |> Generic.List |> OWLEquivalentObjectProperties

        static member FacetRestriction(iri: Iri) =
            fun (typedLiteral: TypedLiteral) -> new OWLFacetRestriction(typedLiteral, iri)
        static member FunctionalDataProperty(dataProperty: OWLDataProperty) =
            new OWLFunctionalDataProperty(dataProperty)
        static member FunctionalDataProperty(iri: Iri) =
            new OWLFunctionalDataProperty((FunctionalSyntax.DataProperty iri))
        static member FunctionalObjectProperty(objectProperty: OWLObjectProperty) =
            new OWLFunctionalObjectProperty(objectProperty)
        // TODO Next add objectProperty overload to the following
        (*
AsymmetricObjectProperty
InverseFunctionalObjectProperty
IrreflexiveObjectProperty
ReflexiveObjectProperty
SymmetricObjectProperty
TransitiveObjectProperty
*)

        static member FunctionalObjectProperty(iri: Iri) =
            iri |> FunctionalSyntax.ObjectProperty |> OWLFunctionalObjectProperty

        static member FunctionalObjectProperty(inverse: OWLObjectInverseOf) =
            new OWLFunctionalObjectProperty(inverse)
        static member HasKey((classExpression: OWLClassExpression), (objectProperties: OWLObjectPropertyExpression list)) =
            new OWLHasKey(classExpression, Generic.List objectProperties)
        static member HasKey((classExpression: OWLClassExpression), (dataProperties: OWLDataProperty list)) =
            new OWLHasKey(classExpression, Generic.List dataProperties)
        static member HasKey(objectProperties: OWLObjectPropertyExpression list) =
            fun (classExpression: OWLClassExpression) -> new OWLHasKey(classExpression, Generic.List objectProperties)
        static member HasKey(dataProperties: OWLDataProperty list) =
            fun (classExpression: OWLClassExpression) -> new OWLHasKey(classExpression, Generic.List dataProperties)

        static member Prefix((prefixName: string), (iri: Iri)) =
            RDFNamespaceRegister.ensurePrefix (prefixName, iri)
        static member Prefix(iri: Iri) =
            fun (prefixName: string) -> RDFNamespaceRegister.ensurePrefix (prefixName, iri)
        static member Import(iri: Iri) = new OWLImport(iri)
        static member Ontology(iri: Iri) = new OWLOntology(iri)
        static member InverseFunctionalObjectProperty(iri: Iri) =
            new OWLInverseFunctionalObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member InverseFunctionalObjectProperty(inverse: OWLObjectInverseOf) =
            new OWLInverseFunctionalObjectProperty(inverse)

        static member InverseObjectProperties((subObjectProperty: OWLObjectPropertyExpression), (superObjectProperty: OWLObjectPropertyExpression)) =
            new OWLInverseObjectProperties(subObjectProperty, superObjectProperty)
        static member InverseObjectProperties(superObjectProperty: OWLObjectPropertyExpression) =
            fun (subObjectProperty: OWLObjectPropertyExpression) -> new OWLInverseObjectProperties(subObjectProperty, superObjectProperty)

        static member IrreflexiveObjectProperty(iri: Iri) =
            new OWLIrreflexiveObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member IrreflexiveObjectProperty(inverse: OWLObjectInverseOf) =
            new OWLIrreflexiveObjectProperty(inverse)
        static member Literal(value: bool) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: byte array) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: byte) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: DateOnly) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: DateTime) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: DateTimeOffset) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: decimal) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: double) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: int16) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: int32) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: int64) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: sbyte) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: single) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: TimeOnly) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: TimeSpan) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: uint16) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: uint32) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: uint64) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: Uri) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: DomUrl) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: XmlQualifiedName) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member Literal(value: Guid) =
            new OWLLiteral(TypedLiteral.op_Implicit value)
        static member ObjectAllValuesFrom<'ClassExpression when 'ClassExpression :> OWLClassExpression>((iri: Iri), (classExpression: 'ClassExpression)) =
            OWLObjectAllValuesFrom(FunctionalSyntax.ObjectProperty iri, classExpression)
        static member ObjectAllValuesFrom<'ClassExpression, 'ObjectPropertyExpression
            when 'ClassExpression :> OWLClassExpression and 'ObjectPropertyExpression :> OWLObjectPropertyExpression>
            ((objectPropertyExpression: 'ObjectPropertyExpression), (classExpression: 'ClassExpression))
            =
            OWLObjectAllValuesFrom(objectPropertyExpression, classExpression)
        static member ObjectAllValuesFrom<'ClassExpression when 'ClassExpression :> OWLClassExpression>(iri: Iri) =
            fun (classExpression: 'ClassExpression) -> OWLObjectAllValuesFrom(FunctionalSyntax.ObjectProperty iri, classExpression)
        static member ObjectAllValuesFrom<'ClassExpression, 'ObjectPropertyExpression
            when 'ClassExpression :> OWLClassExpression and 'ObjectPropertyExpression :> OWLObjectPropertyExpression>
            (objectPropertyExpression: 'ObjectPropertyExpression)
            =
            fun (classExpression: 'ClassExpression) -> OWLObjectAllValuesFrom(objectPropertyExpression, classExpression)
        static member ObjectComplementOf<'ClassExpression when 'ClassExpression :> OWLClassExpression>(classExpression: 'ClassExpression) =
            new OWLObjectComplementOf(classExpression)
        // static member ObjectExactCardinality<'ClassExpression, 'ObjectPropertyExpression  when 'ClassExpression :> OWLClassExpression and 'ObjectPropertyExpression :> OWLObjectPropertyExpression> ((nonNegativeInteger:NonNegativeInteger), (objectPropertyExpression:'ObjectPropertyExpression), (classExpressions:'ClassExpression list) )
        static member ObjectHasSelf<'ObjectPropertyExpression when 'ObjectPropertyExpression :> OWLObjectPropertyExpression>
            (objectPropertyExpression: 'ObjectPropertyExpression)
            =
            new OWLObjectHasSelf(objectPropertyExpression)
        static member ObjectHasSelf<'ObjectPropertyExpression when 'ObjectPropertyExpression :> OWLObjectPropertyExpression>(iri: Iri) =
            new OWLObjectHasSelf(FunctionalSyntax.ObjectProperty iri)
        static member ObjectHasValue<'ObjectPropertyExpression, 'IndividualExpression
            when 'ObjectPropertyExpression :> OWLObjectPropertyExpression and 'IndividualExpression :> OWLIndividualExpression>
            ((objectPropertyExpression: 'ObjectPropertyExpression), (individualExpression: 'IndividualExpression))
            =
            new OWLObjectHasValue(objectPropertyExpression, individualExpression)
        static member ObjectHasValue<'ObjectPropertyExpression, 'IndividualExpression
            when 'ObjectPropertyExpression :> OWLObjectPropertyExpression and 'IndividualExpression :> OWLIndividualExpression>
            (objectPropertyExpression: 'ObjectPropertyExpression)
            =
            fun (individualExpression: 'IndividualExpression) -> new OWLObjectHasValue(objectPropertyExpression, individualExpression)
        static member ObjectInverseOf(iri: Iri) =
            new OWLObjectInverseOf(FunctionalSyntax.ObjectProperty iri)
        static member ObjectInverseOf(objectProperty: OWLObjectProperty) = new OWLObjectInverseOf(objectProperty)
        static member ObjectMaxCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression) =
            new OWLObjectMaxCardinality(objectPropertyExpression, cardinality)

        static member ObjectMaxCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression, classExpression: OWLClassExpression) =
            new OWLObjectMaxCardinality(objectPropertyExpression, cardinality, classExpression)
        static member ObjectMinCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression) =
            new OWLObjectMinCardinality(objectPropertyExpression, cardinality)

        static member ObjectMinCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression, classExpression: OWLClassExpression) =
            new OWLObjectMinCardinality(objectPropertyExpression, cardinality, classExpression)

        static member ObjectExactCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression) =
            new OWLObjectExactCardinality(objectPropertyExpression, cardinality)

        static member ObjectExactCardinality(cardinality: NonNegativeInteger, objectPropertyExpression: OWLObjectPropertyExpression, classExpression: OWLClassExpression) =
            new OWLObjectExactCardinality(objectPropertyExpression, cardinality, classExpression)
        static member EquivalentClasses(classExpressions: OWLClassExpression list) =
            classExpressions |> Generic.List |> OWLEquivalentClasses

        static member DifferentIndividuals(individuals: OWLIndividualExpression list) =
            individuals |> Generic.List |> OWLDifferentIndividuals

        static member ObjectOneOf(individuals: OWLIndividualExpression list) =
            individuals |> Generic.List |> OWLObjectOneOf

        static member ObjectPropertyAssertion<'ObjectPropertyExpression, 'SourceIndividual, 'TargetIndividual
            when 'ObjectPropertyExpression :> OWLObjectPropertyExpression and 'SourceIndividual :> OWLIndividualExpression and 'TargetIndividual :> OWLIndividualExpression>
            (objectPropertyExpression: 'ObjectPropertyExpression, sourceIndividual: 'SourceIndividual, targetIndividual: 'TargetIndividual)
            =
            new OWLObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)
        static member NegativeObjectPropertyAssertion<'NegativeObjectPropertyExpression, 'SourceIndividual, 'TargetIndividual
            when 'NegativeObjectPropertyExpression :> OWLObjectPropertyExpression
            and 'SourceIndividual :> OWLIndividualExpression
            and 'TargetIndividual :> OWLIndividualExpression>
            (objectPropertyExpression: 'NegativeObjectPropertyExpression, sourceIndividual: 'SourceIndividual, targetIndividual: 'TargetIndividual)
            =
            new OWLNegativeObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)
        static member ObjectPropertyAssertion(sourceIndividual: OWLIndividualExpression) =
            fun (objectPropertyExpression: OWLObjectPropertyExpression) ->
                fun (targetIndividual: OWLIndividualExpression) -> new OWLObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)

        static member NegativeObjectPropertyAssertion(sourceIndividual: OWLIndividualExpression) =
            fun (objectPropertyExpression: OWLObjectPropertyExpression) ->
                fun (targetIndividual: OWLIndividualExpression) -> new OWLNegativeObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)
        static member ObjectPropertyChain(classExpressions: OWLObjectPropertyExpression list) =
            classExpressions |> Generic.List |> OWLObjectPropertyChain
        static member ObjectPropertyDomain((objectPropertyExpression: OWLObjectPropertyExpression), (classExpression: OWLClassExpression)) =
            new OWLObjectPropertyDomain(objectPropertyExpression, classExpression)
        static member ObjectPropertyDomain(objectPropertyExpression: OWLObjectPropertyExpression) =
            fun (classExpression: OWLClassExpression) -> new OWLObjectPropertyDomain(objectPropertyExpression, classExpression)
        static member ObjectPropertyRange((objectPropertyExpression: OWLObjectPropertyExpression), (classExpression: OWLClassExpression)) =
            new OWLObjectPropertyRange(objectPropertyExpression, classExpression)
        static member ObjectPropertyRange(objectPropertyExpression: OWLObjectPropertyExpression) =
            fun (classExpression: OWLClassExpression) -> new OWLObjectPropertyRange(objectPropertyExpression, classExpression)

        static member ObjectSomeValuesFrom<'ClassExpression when 'ClassExpression :> OWLClassExpression>((iri: Iri), (classExpression: 'ClassExpression)) =
            OWLObjectSomeValuesFrom(FunctionalSyntax.ObjectProperty iri, classExpression)
        static member ObjectSomeValuesFrom<'ClassExpression, 'ObjectPropertyExpression
            when 'ClassExpression :> OWLClassExpression and 'ObjectPropertyExpression :> OWLObjectPropertyExpression>
            ((objectPropertyExpression: 'ObjectPropertyExpression), (classExpression: 'ClassExpression))
            =
            OWLObjectSomeValuesFrom(objectPropertyExpression, classExpression)
        static member ObjectSomeValuesFrom<'ClassExpression when 'ClassExpression :> OWLClassExpression>(iri: Iri) =
            fun (classExpression: 'ClassExpression) -> OWLObjectSomeValuesFrom(FunctionalSyntax.ObjectProperty iri, classExpression)
        static member ObjectSomeValuesFrom<'ClassExpression, 'ObjectPropertyExpression
            when 'ClassExpression :> OWLClassExpression and 'ObjectPropertyExpression :> OWLObjectPropertyExpression>
            (objectPropertyExpression: 'ObjectPropertyExpression)
            =
            fun (classExpression: 'ClassExpression) -> OWLObjectSomeValuesFrom(objectPropertyExpression, classExpression)
        static member ObjectIntersectionOf(classExpressions: OWLClassExpression list) =
            classExpressions |> Generic.List |> OWLObjectIntersectionOf

        static member ObjectUnionOf(classExpressions: OWLClassExpression list) =
            classExpressions |> Generic.List |> OWLObjectUnionOf
        static member ReflexiveObjectProperty(iri: Iri) =
            new OWLReflexiveObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member ReflexiveObjectProperty(inverse: OWLObjectInverseOf) = new OWLReflexiveObjectProperty(inverse)
        static member SameIndividual(individuals: OWLIndividualExpression list) =
            individuals |> Generic.List |> OWLSameIndividual
        static member SubAnnotationPropertyOf((subAnnotationProperty: OWLAnnotationProperty), (superAnnotationProperty: OWLAnnotationProperty)) =
            new OWLSubAnnotationPropertyOf(subAnnotationProperty, superAnnotationProperty)
        static member SubAnnotationPropertyOf(superAnnotationProperty: OWLAnnotationProperty) =
            fun (subAnnotationProperty: OWLAnnotationProperty) -> new OWLSubAnnotationPropertyOf(subAnnotationProperty, superAnnotationProperty)

        static member AnnotationPropertyDomain((dataProperty: OWLAnnotationProperty), (iri: Iri)) =
            new OWLAnnotationPropertyDomain(dataProperty, iri)
        static member AnnotationPropertyDomain(iri: Iri) =
            fun (dataProperty: OWLAnnotationProperty) -> new OWLAnnotationPropertyDomain(dataProperty, iri)
        static member AnnotationPropertyRange((dataProperty: OWLAnnotationProperty), (iri: Iri)) =
            new OWLAnnotationPropertyRange(dataProperty, iri)
        static member AnnotationPropertyRange(iri: Iri) =
            fun (dataProperty: OWLAnnotationProperty) -> new OWLAnnotationPropertyRange(dataProperty, iri)
        static member SubClassOf((subClass: OWLClassExpression), (superClass: OWLClassExpression)) = new OWLSubClassOf(subClass, superClass)
        static member SubClassOf(superClass: OWLClassExpression) =
            fun (subClass: OWLClassExpression) -> new OWLSubClassOf(subClass, superClass)
        static member SubDataPropertyOf((subDataProperty: OWLDataProperty), (superDataProperty: OWLDataProperty)) =
            new OWLSubDataPropertyOf(subDataProperty, superDataProperty)
        static member SubDataPropertyOf(superDataProperty: OWLDataProperty) =
            fun (subDataProperty: OWLDataProperty) -> new OWLSubDataPropertyOf(subDataProperty, superDataProperty)
        static member SubObjectPropertyOf((subObjectProperty: OWLObjectPropertyExpression), (superObjectProperty: OWLObjectPropertyExpression)) =
            new OWLSubObjectPropertyOf(subObjectProperty, superObjectProperty)
        static member SubObjectPropertyOf(superObjectProperty: OWLObjectPropertyExpression) =
            fun (subObjectProperty: OWLObjectPropertyExpression) -> new OWLSubObjectPropertyOf(subObjectProperty, superObjectProperty)
        static member SymmetricObjectProperty(iri: Iri) =
            new OWLSymmetricObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member SymmetricObjectProperty(inverse: OWLObjectInverseOf) = new OWLSymmetricObjectProperty(inverse)
        static member TransitiveObjectProperty(iri: Iri) =
            new OWLTransitiveObjectProperty((FunctionalSyntax.ObjectProperty iri))
        static member TransitiveObjectProperty(inverse: OWLObjectInverseOf) =
            new OWLTransitiveObjectProperty(inverse)

    module OWLAnnotationProperty =
        module rdfs =
            let _namespace = RDFNamespace.rdfs

            let label = _namespace.curie "label" |> FunctionalSyntax.AnnotationProperty
            let comment = _namespace.curie "comment" |> FunctionalSyntax.AnnotationProperty
            let seeAlso = _namespace.curie "seeAlso" |> FunctionalSyntax.AnnotationProperty
            let isDefinedBy = _namespace.curie "isDefinedBy" |> FunctionalSyntax.AnnotationProperty
        module owl =
            let _namespace = RDFNamespace.owl
            let deprecated = _namespace.curie "deprecated" |> FunctionalSyntax.AnnotationProperty
            let versionInfo = _namespace.curie "versionInfo" |> FunctionalSyntax.AnnotationProperty
            let priorVersion = _namespace.curie "priorVersion" |> FunctionalSyntax.AnnotationProperty
            let backwardCompatibleWith = _namespace.curie "backwardCompatibleWith" |> FunctionalSyntax.AnnotationProperty
            let incompatibleWith = _namespace.curie "incompatibleWith" |> FunctionalSyntax.AnnotationProperty
        let builtInSet =
            set [
                rdfs.label.IRI
                rdfs.comment.IRI
                rdfs.seeAlso.IRI
                rdfs.isDefinedBy.IRI
                owl.deprecated.IRI
                owl.versionInfo.IRI
                owl.priorVersion.IRI
                owl.backwardCompatibleWith.IRI
                owl.incompatibleWith.IRI
            ]
    module RdfBasedSyntax =
        module owl =

            let _namespace = RDFNamespace.owl
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
            let onProperty = _namespace.curie "onProperty"
            let onProperties = _namespace.curie "onProperties"
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
    module ManchesterSyntax =

        type OneOrMore<'Entity> = 'Entity * 'Entity list

        type TwoOrMore<'Entity> = 'Entity * 'Entity * 'Entity list
        type Restriction =
            | ObjectSomeValuesFromRestriction of OWLObjectSomeValuesFrom
            | ObjectAllValuesFromRestriction of OWLObjectAllValuesFrom
            | ObjectHasValueRestriction of OWLObjectHasValue
            | ObjectMinCardinalityRestriction of OWLObjectMinCardinality
            | ObjectExactCardinalityRestriction of OWLObjectExactCardinality
            | ObjectMaxCardinalityRestriction of OWLObjectMaxCardinality
            | ObjectHasSelfRestriction of OWLObjectHasSelf
            | DataSomeValuesFromRestriction of OWLDataSomeValuesFrom
            | DataAllValuesFromRestriction of OWLDataAllValuesFrom
            | DataHasValueRestriction of OWLDataHasValue
            | DataMinCardinalityRestriction of OWLDataMinCardinality
            | DataExactCardinalityRestriction of OWLDataExactCardinality
            | DataMaxCardinalityRestriction of OWLDataMaxCardinality

            member this.classExpression =
                match this with
                | ObjectSomeValuesFromRestriction owlObjectSomeValuesFrom -> owlObjectSomeValuesFrom :> OWLClassExpression
                | ObjectAllValuesFromRestriction owlObjectAllValuesFrom -> owlObjectAllValuesFrom :> OWLClassExpression
                | ObjectHasValueRestriction owlObjectHasValue -> owlObjectHasValue :> OWLClassExpression
                | ObjectMinCardinalityRestriction owlObjectMinCardinality -> owlObjectMinCardinality :> OWLClassExpression
                | ObjectExactCardinalityRestriction owlObjectExactCardinality -> owlObjectExactCardinality :> OWLClassExpression
                | ObjectMaxCardinalityRestriction owlObjectMaxCardinality -> owlObjectMaxCardinality :> OWLClassExpression
                | ObjectHasSelfRestriction owlObjectHasSelf -> owlObjectHasSelf :> OWLClassExpression
                | DataSomeValuesFromRestriction owlDataSomeValuesFrom -> owlDataSomeValuesFrom :> OWLClassExpression
                | DataAllValuesFromRestriction owlDataAllValuesFrom -> owlDataAllValuesFrom :> OWLClassExpression
                | DataHasValueRestriction owlDataHasValue -> owlDataHasValue :> OWLClassExpression
                | DataMinCardinalityRestriction owlDataMinCardinality -> owlDataMinCardinality :> OWLClassExpression
                | DataExactCardinalityRestriction owlDataExactCardinality -> owlDataExactCardinality :> OWLClassExpression
                | DataMaxCardinalityRestriction owlDataMaxCardinality -> owlDataMaxCardinality :> OWLClassExpression
        type Fact =
            | ObjectPropertyFact of OWLObjectProperty * OWLIndividualExpression
            | NegativeObjectPropertyFact of OWLObjectProperty * OWLIndividualExpression
            | DataPropertyFact of OWLDataProperty * LiteralValue
            | NegativeDataPropertyFact of OWLDataProperty * LiteralValue

            member this.Assertion(domain: OWLIndividualExpression) : OWLAssertionAxiom =
                match this with
                | ObjectPropertyFact(objectProperty, range) -> FunctionalSyntax.ObjectPropertyAssertion(objectProperty, domain, range) :> OWLAssertionAxiom

                | NegativeObjectPropertyFact(objectProperty, range) -> FunctionalSyntax.NegativeObjectPropertyAssertion(objectProperty, domain, range) :> OWLAssertionAxiom

                | DataPropertyFact(dataProperty, literal) -> FunctionalSyntax.DataPropertyAssertion(dataProperty, domain, literal.asOWLLiteral) :> OWLAssertionAxiom

                | NegativeDataPropertyFact(dataProperty, literal) ->
                    FunctionalSyntax.NegativeDataPropertyAssertion(dataProperty, domain, literal.asOWLLiteral) :> OWLAssertionAxiom
            member this.Assertion(domains: OWLIndividualExpression list) : OWLAssertionAxiom list =
                domains |> List.map (fun domain -> this.Assertion domain)
        type OWLObjectProperty with
            member this.Fact(individual: OWLIndividualExpression) = ObjectPropertyFact(this, individual)
            member this.not(individual: OWLIndividualExpression) =
                NegativeObjectPropertyFact(this, individual)
        type OWLDataProperty with
            member this.Fact(literalValue: LiteralValue) = DataPropertyFact(this, literalValue)
            member this.not(literalValue: LiteralValue) =
                NegativeDataPropertyFact(this, literalValue)

        type OWLAnnotationProperty with
            member this.Iri = Iri.op_Implicit this.IRI
            member this.Annotation(value: Iri) =
                FunctionalSyntax.Annotation(this, value)

            member this.Annotation(value: BNode) =
                FunctionalSyntax.Annotation(this, value)

            member this.Annotation(value: LiteralValue) =
                FunctionalSyntax.Annotation(this, value)

            member this.Assertion(subject: Iri, value: Iri) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)

            member this.Assertion(subject: Iri, value: BNode) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)

            member this.Assertion(subject: Iri, value: LiteralValue) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)

            member this.Assertion(subject: BNode, value: Iri) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)

            member this.Assertion(subject: BNode, value: BNode) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)

            member this.Assertion(subject: BNode, value: LiteralValue) =
                FunctionalSyntax.AnnotationAssertion(this, subject, value)
        type OWLIndividualExpression with
            member this.Assertion(fact: Fact) = fact.Assertion this
            member this.Assertion(facts: Fact list) =
                facts |> List.map (fun fact -> fact.Assertion this)

        type Manchester =
            static member oneOf(individuals: OWLIndividualExpression list) =
                FunctionalSyntax.ObjectOneOf individuals
            static member oneOf(literals: OWLLiteral list) = FunctionalSyntax.DataOneOf literals
            static member not(classExpression: OWLClassExpression) =
                FunctionalSyntax.ObjectComplementOf classExpression
            static member not(dataRangeExpression: OWLDataRangeExpression) =
                FunctionalSyntax.DataComplementOf dataRangeExpression
            static member not(individuals: OWLIndividualExpression list) =
                FunctionalSyntax.ObjectComplementOf(FunctionalSyntax.ObjectOneOf individuals)
            static member not(literals: OWLLiteral list) =
                FunctionalSyntax.DataComplementOf(FunctionalSyntax.DataOneOf literals)
            static member not(fact: Fact) =
                match fact with
                | ObjectPropertyFact(objectProperty, individual) -> NegativeObjectPropertyFact(objectProperty, individual)
                | NegativeObjectPropertyFact(objectProperty, individual) -> ObjectPropertyFact(objectProperty, individual)
                | DataPropertyFact(dataProperty, literal) -> NegativeDataPropertyFact(dataProperty, literal)
                | NegativeDataPropertyFact(dataProperty, literal) -> DataPropertyFact(dataProperty, literal)
            static member not((objectProperty: OWLObjectProperty), (individual: OWLIndividualExpression)) =
                NegativeObjectPropertyFact(objectProperty, individual)
            static member not((dataProperty: OWLDataProperty), (literal: LiteralValue)) =
                NegativeDataPropertyFact(dataProperty, literal)

        type OWLObjectPropertyExpression with
            member this.some(classExpression: OWLClassExpression) =
                FunctionalSyntax.ObjectSomeValuesFrom this classExpression
                |> ObjectSomeValuesFromRestriction
            member this.only(classExpression: OWLClassExpression) =
                FunctionalSyntax.ObjectAllValuesFrom this classExpression
                |> ObjectAllValuesFromRestriction
            member this.value(individual: OWLIndividualExpression) =
                FunctionalSyntax.ObjectHasValue this individual |> ObjectHasValueRestriction
            member this.min(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.ObjectMinCardinality(nonNegativeInteger, this)
                |> ObjectMinCardinalityRestriction
            member this.min((nonNegativeInteger: NonNegativeInteger), (classExpression: OWLClassExpression)) =
                FunctionalSyntax.ObjectMinCardinality(nonNegativeInteger, this, classExpression)
                |> ObjectMinCardinalityRestriction
            member this.min(classExpression: OWLClassExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.ObjectMinCardinality(nonNegativeInteger, this, classExpression)
                    |> ObjectMinCardinalityRestriction
            member this.exactly(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.ObjectExactCardinality(nonNegativeInteger, this)
                |> ObjectExactCardinalityRestriction
            member this.exactly((nonNegativeInteger: NonNegativeInteger), (classExpression: OWLClassExpression)) =
                FunctionalSyntax.ObjectExactCardinality(nonNegativeInteger, this, classExpression)
                |> ObjectExactCardinalityRestriction
            member this.exactly(classExpression: OWLClassExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.ObjectExactCardinality(nonNegativeInteger, this, classExpression)
                    |> ObjectExactCardinalityRestriction
            member this.max(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.ObjectMaxCardinality(nonNegativeInteger, this)
                |> ObjectMaxCardinalityRestriction
            member this.max((nonNegativeInteger: NonNegativeInteger), (classExpression: OWLClassExpression)) =
                FunctionalSyntax.ObjectMaxCardinality(nonNegativeInteger, this, classExpression)
                |> ObjectMaxCardinalityRestriction
            member this.max(classExpression: OWLClassExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.ObjectMaxCardinality(nonNegativeInteger, this, classExpression)
                    |> ObjectMaxCardinalityRestriction
            member self.Self = FunctionalSyntax.ObjectHasSelf self |> ObjectHasSelfRestriction
            member this.o(objectPropertyExpression: OWLObjectPropertyExpression) =
                FunctionalSyntax.ObjectPropertyChain [ this; objectPropertyExpression ]
        type OWLObjectPropertyChain with
            member this.objectPropertyExpressions = this.ObjectPropertyExpressions |> Seq.toList
            member this.o(objectPropertyExpression: OWLObjectPropertyExpression) =
                List.append this.objectPropertyExpressions [ objectPropertyExpression ]
                |> FunctionalSyntax.ObjectPropertyChain
        type OWLObjectProperty with
            member this.inverse = FunctionalSyntax.ObjectInverseOf this

        type OWLDataProperty with
            member this.some(dataRange: OWLDataRangeExpression) =
                FunctionalSyntax.DataSomeValuesFrom this dataRange
                |> DataSomeValuesFromRestriction
            member this.only(dataRange: OWLDataRangeExpression) =
                FunctionalSyntax.DataAllValuesFrom this dataRange
                |> DataAllValuesFromRestriction
            member this.value(literal: OWLLiteral) =
                this |> FunctionalSyntax.DataHasValue literal |> DataHasValueRestriction
            member this.min(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.DataMinCardinality(nonNegativeInteger, this)
                |> DataMinCardinalityRestriction
            member this.min((nonNegativeInteger: NonNegativeInteger), (dataRange: OWLDataRangeExpression)) =
                FunctionalSyntax.DataMinCardinality(nonNegativeInteger, this, dataRange)
                |> DataMinCardinalityRestriction
            member this.min(dataRange: OWLDataRangeExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.DataMinCardinality(nonNegativeInteger, this, dataRange)
                    |> DataMinCardinalityRestriction
            member this.exactly(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.DataExactCardinality(nonNegativeInteger, this)
                |> DataExactCardinalityRestriction
            member this.exactly((nonNegativeInteger: NonNegativeInteger), (dataRange: OWLDataRangeExpression)) =
                FunctionalSyntax.DataExactCardinality(nonNegativeInteger, this, dataRange)
                |> DataExactCardinalityRestriction
            member this.exactly(dataRange: OWLDataRangeExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.DataExactCardinality(nonNegativeInteger, this, dataRange)
                    |> DataExactCardinalityRestriction
            member this.max(nonNegativeInteger: NonNegativeInteger) =
                FunctionalSyntax.DataMaxCardinality(nonNegativeInteger, this)
                |> DataMaxCardinalityRestriction
            member this.max((nonNegativeInteger: NonNegativeInteger), (dataRange: OWLDataRangeExpression)) =
                FunctionalSyntax.DataMaxCardinality(nonNegativeInteger, this, dataRange)
                |> DataMaxCardinalityRestriction
            member this.max(dataRange: OWLDataRangeExpression) =
                fun (nonNegativeInteger: NonNegativeInteger) ->
                    FunctionalSyntax.DataMaxCardinality(nonNegativeInteger, this, dataRange)
                    |> DataMaxCardinalityRestriction

        type OWLClass with
            member this.that(restrictions: Restriction list) =
                restrictions
                |> List.map (fun restriction -> restriction.classExpression)
                |> List.append [ this ]
                |> FunctionalSyntax.ObjectIntersectionOf
        type OWLClassExpression with
            member this.and_(classExpression: OWLClassExpression) =
                FunctionalSyntax.ObjectIntersectionOf [ this; classExpression ]
            member this.or_(classExpression: OWLClassExpression) =
                FunctionalSyntax.ObjectUnionOf [ this; classExpression ]
        type Iri with
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: Iri)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: Iri) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: BNode)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: BNode) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: LiteralValue)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: LiteralValue) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
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
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: Iri)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: Iri) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: BNode)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: BNode) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation((annotationProperty: OWLAnnotationProperty), (annotationObject: LiteralValue)) =
                FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
            member this.Annotation(annotationObject: LiteralValue) =
                fun (annotationProperty: OWLAnnotationProperty) -> FunctionalSyntax.AnnotationAssertion(annotationProperty, this, annotationObject)
        type DatatypeIri with
            member this.length(length: NonNegativeInteger) =
                TypedLiteral.nonNegativeInteger length
                |> FunctionalSyntax.FacetRestriction xsd.length
            member this.minLength(minLength: NonNegativeInteger) =
                TypedLiteral.nonNegativeInteger minLength
                |> FunctionalSyntax.FacetRestriction xsd.minLength
            member this.maxLength(maxLength: NonNegativeInteger) =
                TypedLiteral.nonNegativeInteger maxLength
                |> FunctionalSyntax.FacetRestriction xsd.maxLength

            member this.pattern(regexPattern: string) =
                {
                    lexicalForm = regexPattern
                    datatype = RDFNamespace.xsd.curie "string" |> DatatypeIri
                }
                |> FunctionalSyntax.FacetRestriction xsd.pattern
            member this.langRange(regexPattern: string) =
                {
                    lexicalForm = regexPattern
                    datatype = RDFNamespace.xsd.curie "string" |> DatatypeIri
                }
                |> FunctionalSyntax.FacetRestriction(RDFNamespace.rdf.curie "langRange")

            member this.withRestrictions(restrictions: OWLFacetRestriction list) =
                FunctionalSyntax.DatatypeRestriction this restrictions
        type OWLDataRangeExpression with
            member this.and_(dataRangeExpression: OWLDataRangeExpression) =
                FunctionalSyntax.DataIntersectionOf [ this; dataRangeExpression ]
            member this.or_(dataRangeExpression: OWLDataRangeExpression) =
                FunctionalSyntax.DataUnionOf [ this; dataRangeExpression ]
        type PropertyExpression =
            | ObjectPropertyExpression of OWLObjectPropertyExpression
            | DataPropertyExpression of OWLDataPropertyExpression

        type ObjectPropertyCharacteristic =
            | Functional
            | InverseFunctional
            | Reflexive
            | Irreflexive
            | Symmetric
            | Asymmetric
            | Transitive
        type Frame =
            | DatatypeFrame of DatatypeFrame
            | ClassFrame of ClassFrame
            | ObjectPropertyFrame of ObjectPropertyFrame
            | DataPropertyFrame of DataPropertyFrame
            | AnnotationPropertyFrame of AnnotationPropertyFrame
            | IndividualFrame of IndividualFrame
            | MiscFrame of MiscFrame
        and DatatypeFrame = {
            Datatype: OWLDatatype
            Annotations: Annotated<OWLAnnotation> list
            EquivalentTo: Annotated<OWLDataRangeExpression> option
        }
        and ClassFrame = {
            Class: OWLClass
            Annotations: Annotated<OWLAnnotation> list
            SubClassOf: Annotated<OWLClassExpression> list
            EquivalentTo: Annotated<OWLClassExpression> list
            DisjointWith: Annotated<OWLClassExpression> list
            DisjointUnionOf: Annotated<TwoOrMore<OWLClassExpression>> list
            HasKey: Annotated<OneOrMore<PropertyExpression>> list
        }
        and ObjectPropertyFrame = {
            ObjectProperty: OWLObjectProperty
            Annotations: Annotated<OWLAnnotation> list
            Domain: Annotated<OWLClassExpression> list
            Range: Annotated<OWLClassExpression> list
            Characteristics: Annotated<ObjectPropertyCharacteristic> list
            SubPropertyOf: Annotated<OWLObjectPropertyExpression> list
            EquivalentTo: Annotated<OWLObjectPropertyExpression> list
            DisjointWith: Annotated<OWLObjectPropertyExpression> list
            InverseOf: Annotated<OWLObjectPropertyExpression> list
            SubPropertyChain: Annotated<OWLObjectPropertyChain> list
        }
        and DataPropertyFrame = {
            DataProperty: OWLDataProperty
            Annotations: Annotated<OWLAnnotation> list
            Domain: Annotated<OWLClassExpression> list
            Range: Annotated<OWLDataRangeExpression> list
            Characteristics: OWLAnnotation list option
            SubPropertyOf: Annotated<OWLDataPropertyExpression> list
            EquivalentTo: Annotated<OWLDataPropertyExpression> list
            DisjointWith: Annotated<OWLDataPropertyExpression> list
        }
        and AnnotationPropertyFrame = {
            AnnotationProperty: OWLAnnotationProperty
            Annotations: Annotated<OWLAnnotation> list
            Domain: Annotated<Iri> list
            Range: Annotated<Iri> list
            SubPropertyOf: Annotated<OWLAnnotationProperty> list
        }
        and IndividualFrame = {
            Individual: OWLIndividualExpression
            Annotations: Annotated<OWLAnnotation> list
            Types: Annotated<OWLClassExpression> list
            Facts: Annotated<Fact> list
            SameAs: Annotated<OWLIndividualExpression> list
            DifferentFrom: Annotated<OWLIndividualExpression> list
        }
        and MiscFrame =
            | EquivalentClassesFrame of Annotated<TwoOrMore<OWLClassExpression>>
            | DisjointClassesFrame of Annotated<TwoOrMore<OWLClassExpression>>
            | EquivalentObjectPropertiesFrame of Annotated<TwoOrMore<OWLObjectProperty>>
            | DisjointObjectPropertiesFrame of Annotated<TwoOrMore<OWLObjectProperty>>
            | EquivalentDataPropertiesFrame of Annotated<TwoOrMore<OWLDataProperty>>
            | DisjointDataPropertiesFrame of Annotated<TwoOrMore<OWLDataProperty>>
            | SameIndividualFrame of Annotated<TwoOrMore<OWLIndividualExpression>>
            | DifferentIndividualsFrame of Annotated<TwoOrMore<OWLIndividualExpression>>
