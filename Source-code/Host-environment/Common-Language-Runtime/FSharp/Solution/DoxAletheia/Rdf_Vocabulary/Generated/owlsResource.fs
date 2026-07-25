namespace http.www.daml.org.services.owl_s._1._2.Resource.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owlsResource =
    let _namespace_iri = Namespace_Iri owlsResource |> NamespaceIRI

    /// <summary>
    ///   <para>owlsResource:AggregateResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Aggregate Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AggregateResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#AggregateResource</seealso>
    let AggregateResource =
        Prefixed_Name(owlsResource, "AggregateResource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:AtomicResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Atomic Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AtomicResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#AtomicResource</seealso>
    let AtomicResource = Prefixed_Name(owlsResource, "AtomicResource") |> PrefixedName
    /// <summary>
    ///   <para>owlsResource:CapacityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Capacity Type</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#CapacityType">http://www.daml.org/services/owl-s/1.2/Resource.owl#CapacityType</seealso>
    let CapacityType = Prefixed_Name(owlsResource, "CapacityType") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:DiscreteCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlsResource:CapacityType</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DiscreteCapacity">http://www.daml.org/services/owl-s/1.2/Resource.owl#DiscreteCapacity</seealso>
    let DiscreteCapacity =
        Prefixed_Name(owlsResource, "DiscreteCapacity") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:DisjunctiveAggregateResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Disjunctive Aggregate Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DisjunctiveAggregateResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#DisjunctiveAggregateResource</seealso>
    let DisjunctiveAggregateResource =
        Prefixed_Name(owlsResource, "DisjunctiveAggregateResource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:AllocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Allocation Type</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AllocationType">http://www.daml.org/services/owl-s/1.2/Resource.owl#AllocationType</seealso>
    let AllocationType = Prefixed_Name(owlsResource, "AllocationType") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:ContinuousCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlsResource:CapacityType</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ContinuousCapacity">http://www.daml.org/services/owl-s/1.2/Resource.owl#ContinuousCapacity</seealso>
    let ContinuousCapacity =
        Prefixed_Name(owlsResource, "ContinuousCapacity") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:allocationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>allocation type</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#allocationType">http://www.daml.org/services/owl-s/1.2/Resource.owl#allocationType</seealso>
    let allocationType = Prefixed_Name(owlsResource, "allocationType") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:ConsumableAllocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlsResource:AllocationType</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConsumableAllocation">http://www.daml.org/services/owl-s/1.2/Resource.owl#ConsumableAllocation</seealso>
    let ConsumableAllocation =
        Prefixed_Name(owlsResource, "ConsumableAllocation") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:capacityGranularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>capacity granularity</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityGranularity">http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityGranularity</seealso>
    let capacityGranularity =
        Prefixed_Name(owlsResource, "capacityGranularity") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Resource Ontology for OWL-S</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#">http://www.daml.org/services/owl-s/1.2/Resource.owl#</seealso>
    let _prefix_iri = Prefixed_Name(owlsResource, "") |> PrefixedName
    /// <summary>
    ///   <para>owlsResource:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#Resource">http://www.daml.org/services/owl-s/1.2/Resource.owl#Resource</seealso>
    let Resource = Prefixed_Name(owlsResource, "Resource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:BatchCapacityResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Batch-capacity Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#BatchCapacityResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#BatchCapacityResource</seealso>
    let BatchCapacityResource =
        Prefixed_Name(owlsResource, "BatchCapacityResource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:ConjunctiveAggregateResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Conjunctive Aggregate Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConjunctiveAggregateResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#ConjunctiveAggregateResource</seealso>
    let ConjunctiveAggregateResource =
        Prefixed_Name(owlsResource, "ConjunctiveAggregateResource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:ReusableAllocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owlsResource:AllocationType</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ReusableAllocation">http://www.daml.org/services/owl-s/1.2/Resource.owl#ReusableAllocation</seealso>
    let ReusableAllocation =
        Prefixed_Name(owlsResource, "ReusableAllocation") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:UnitCapacityResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Unit-capacity Resource</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#UnitCapacityResource">http://www.daml.org/services/owl-s/1.2/Resource.owl#UnitCapacityResource</seealso>
    let UnitCapacityResource =
        Prefixed_Name(owlsResource, "UnitCapacityResource") |> PrefixedName

    /// <summary>
    ///   <para>owlsResource:capacityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>capacity type</para></remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityType">http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityType</seealso>
    let capacityType = Prefixed_Name(owlsResource, "capacityType") |> PrefixedName
