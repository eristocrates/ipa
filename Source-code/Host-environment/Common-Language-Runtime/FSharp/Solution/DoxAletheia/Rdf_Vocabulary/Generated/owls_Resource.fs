namespace http.www.daml.org.services.owl_s._1._2.Resource.owl.hash

open DoxAletheia

module owls_Resource =
    let _namespace_name = "http://www.daml.org/services/owl-s/1.2/Resource.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AggregateResource"></see>
    /// </summary>
    let AggregateResource = _prefix "AggregateResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#Resource"></see>
    /// </summary>
    let Resource = _prefix "Resource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AllocationType"></see>
    /// </summary>
    let AllocationType = _prefix "AllocationType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#AtomicResource"></see>
    /// </summary>
    let AtomicResource = _prefix "AtomicResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#BatchCapacityResource"></see>
    /// </summary>
    let BatchCapacityResource = _prefix "BatchCapacityResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#CapacityType"></see>
    /// </summary>
    let CapacityType = _prefix "CapacityType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConjunctiveAggregateResource"></see>
    /// </summary>
    let ConjunctiveAggregateResource = _prefix "ConjunctiveAggregateResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ConsumableAllocation"></see>
    /// </summary>
    let ConsumableAllocation = _prefix "ConsumableAllocation"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ContinuousCapacity"></see>
    /// </summary>
    let ContinuousCapacity = _prefix "ContinuousCapacity"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DiscreteCapacity"></see>
    /// </summary>
    let DiscreteCapacity = _prefix "DiscreteCapacity"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#DisjunctiveAggregateResource"></see>
    /// </summary>
    let DisjunctiveAggregateResource = _prefix "DisjunctiveAggregateResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#ReusableAllocation"></see>
    /// </summary>
    let ReusableAllocation = _prefix "ReusableAllocation"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#UnitCapacityResource"></see>
    /// </summary>
    let UnitCapacityResource = _prefix "UnitCapacityResource"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#allocationType"></see>
    /// </summary>
    let allocationType = _prefix "allocationType"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityGranularity"></see>
    /// </summary>
    let capacityGranularity = _prefix "capacityGranularity"
    /// <summary>
    ///   <see href="http://www.daml.org/services/owl-s/1.2/Resource.owl#capacityType"></see>
    /// </summary>
    let capacityType = _prefix "capacityType"
