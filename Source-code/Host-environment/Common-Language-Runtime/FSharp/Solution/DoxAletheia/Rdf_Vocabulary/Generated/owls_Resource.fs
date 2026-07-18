namespace http.www.daml.org.services.owl_s._1._2.Resource.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owls_Resource =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Resource.owl#"

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AggregateResource"></see>
    /// </summary>
    let AggregateResource =
        Namespaced_IRI.parse _namespace_name "AggregateResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#Resource"></see>
    /// </summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AllocationType"></see>
    /// </summary>
    let AllocationType =
        Namespaced_IRI.parse _namespace_name "AllocationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AtomicResource"></see>
    /// </summary>
    let AtomicResource =
        Namespaced_IRI.parse _namespace_name "AtomicResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#BatchCapacityResource"></see>
    /// </summary>
    let BatchCapacityResource =
        Namespaced_IRI.parse _namespace_name "BatchCapacityResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#CapacityType"></see>
    /// </summary>
    let CapacityType =
        Namespaced_IRI.parse _namespace_name "CapacityType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConjunctiveAggregateResource"></see>
    /// </summary>
    let ConjunctiveAggregateResource =
        Namespaced_IRI.parse _namespace_name "ConjunctiveAggregateResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConsumableAllocation"></see>
    /// </summary>
    let ConsumableAllocation =
        Namespaced_IRI.parse _namespace_name "ConsumableAllocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ContinuousCapacity"></see>
    /// </summary>
    let ContinuousCapacity =
        Namespaced_IRI.parse _namespace_name "ContinuousCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DiscreteCapacity"></see>
    /// </summary>
    let DiscreteCapacity =
        Namespaced_IRI.parse _namespace_name "DiscreteCapacity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DisjunctiveAggregateResource"></see>
    /// </summary>
    let DisjunctiveAggregateResource =
        Namespaced_IRI.parse _namespace_name "DisjunctiveAggregateResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ReusableAllocation"></see>
    /// </summary>
    let ReusableAllocation =
        Namespaced_IRI.parse _namespace_name "ReusableAllocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#UnitCapacityResource"></see>
    /// </summary>
    let UnitCapacityResource =
        Namespaced_IRI.parse _namespace_name "UnitCapacityResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#allocationType"></see>
    /// </summary>
    let allocationType =
        Namespaced_IRI.parse _namespace_name "allocationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityGranularity"></see>
    /// </summary>
    let capacityGranularity =
        Namespaced_IRI.parse _namespace_name "capacityGranularity" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityType"></see>
    /// </summary>
    let capacityType =
        Namespaced_IRI.parse _namespace_name "capacityType" |> NamespacedName
