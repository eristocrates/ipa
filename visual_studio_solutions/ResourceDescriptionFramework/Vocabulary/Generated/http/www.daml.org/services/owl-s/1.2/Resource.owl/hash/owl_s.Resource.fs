namespace Owl_s.Resource.Namespace
module Resource =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://www.daml.org/services/owl-s/1.2/Resource.owl#" (Some "http://www.daml.org/services/owl-s/1.2/Resource.owl") (Some "owl_s.Resource") None
    let AggregateResource = {_prefixID with _localName = "AggregateResource"}
    let AllocationType = {_prefixID with _localName = "AllocationType"}
    let AtomicResource = {_prefixID with _localName = "AtomicResource"}
    let BatchCapacityResource = {_prefixID with _localName = "BatchCapacityResource"}
    let CapacityType = {_prefixID with _localName = "CapacityType"}
    let ConjunctiveAggregateResource = {_prefixID with _localName = "ConjunctiveAggregateResource"}
    let ConsumableAllocation = {_prefixID with _localName = "ConsumableAllocation"}
    let ContinuousCapacity = {_prefixID with _localName = "ContinuousCapacity"}
    let DiscreteCapacity = {_prefixID with _localName = "DiscreteCapacity"}
    let DisjunctiveAggregateResource = {_prefixID with _localName = "DisjunctiveAggregateResource"}
    let Resource = {_prefixID with _localName = "Resource"}
    let ReusableAllocation = {_prefixID with _localName = "ReusableAllocation"}
    let UnitCapacityResource = {_prefixID with _localName = "UnitCapacityResource"}
    let allocationType = {_prefixID with _localName = "allocationType"}
    let capacityGranularity = {_prefixID with _localName = "capacityGranularity"}
    let capacityType = {_prefixID with _localName = "capacityType"}