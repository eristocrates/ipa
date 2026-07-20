namespace https.w3id.org.def.och.hash

open DoxAletheia

module och =
    let _namespace_name = "https://w3id.org/def/och#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The change operation corresponding to addition of a characteristic to a property
    /// <see href="https://w3id.org/def/och#AddCharacteristic"></see></summary>
    let AddCharacteristic = _prefix "AddCharacteristic"
    /// <summary>
    /// The change operation corresponding to the change of a property characteristic.
    /// <see href="https://w3id.org/def/och#PropertyCharacteristicChange"></see></summary>
    let PropertyCharacteristicChange = _prefix "PropertyCharacteristicChange"
    /// <summary>
    /// The change operation corresponding to the addition of a class
    /// <see href="https://w3id.org/def/och#AddClass"></see></summary>
    let AddClass = _prefix "AddClass"
    /// <summary>
    /// The change operation corresponding to the change of a given class within the ontology
    /// <see href="https://w3id.org/def/och#ClassChange"></see></summary>
    let ClassChange = _prefix "ClassChange"
    /// <summary>
    /// The change operation corresponding to the addition of a data property
    /// <see href="https://w3id.org/def/och#AddDataProperty"></see></summary>
    let AddDataProperty = _prefix "AddDataProperty"
    /// <summary>
    /// The class that represents the addition of a property to an ontology
    /// <see href="https://w3id.org/def/och#AddProperty"></see></summary>
    let AddProperty = _prefix "AddProperty"
    /// <summary>
    /// The change operation corresponding to the change of a data property
    /// <see href="https://w3id.org/def/och#DataPropertyChange"></see></summary>
    let DataPropertyChange = _prefix "DataPropertyChange"
    /// <summary>
    /// The change operation corresponding to the addition of a Disjoint Property relation between two properties
    /// <see href="https://w3id.org/def/och#AddDisjointProperty"></see></summary>
    let AddDisjointProperty = _prefix "AddDisjointProperty"
    /// <summary>
    /// The change operation corresponding to the change of a Disjoint Property
    /// <see href="https://w3id.org/def/och#DisjointPropertyChange"></see></summary>
    let DisjointPropertyChange = _prefix "DisjointPropertyChange"
    /// <summary>
    /// The change operation corresponding to the addition of the domain to a given property
    /// <see href="https://w3id.org/def/och#AddDomain"></see></summary>
    let AddDomain = _prefix "AddDomain"
    /// <summary>
    /// The change operation corresponding to the change of the domain of a given property
    /// <see href="https://w3id.org/def/och#DomainChange"></see></summary>
    let DomainChange = _prefix "DomainChange"
    /// <summary>
    /// The change operation corresponding to the addition of an equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#AddEquivalentClass"></see></summary>
    let AddEquivalentClass = _prefix "AddEquivalentClass"
    /// <summary>
    /// The change operation corresponding to the change of an equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#EquivalentClassChange"></see></summary>
    let EquivalentClassChange = _prefix "EquivalentClassChange"
    /// <summary>
    /// The change operation corresponding to the addition of an equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#AddEquivalentProperty"></see></summary>
    let AddEquivalentProperty = _prefix "AddEquivalentProperty"
    /// <summary>
    /// The change operation corresponding to the change of an equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#EquivalentPropertyChange"></see></summary>
    let EquivalentPropertyChange = _prefix "EquivalentPropertyChange"
    /// <summary>
    /// The change operation corresponding to the addition of an individual to the ontology
    /// <see href="https://w3id.org/def/och#AddIndividual"></see></summary>
    let AddIndividual = _prefix "AddIndividual"
    /// <summary>
    /// The change operation corresponding to the change of a given individual within the ontology
    /// <see href="https://w3id.org/def/och#IndividualChange"></see></summary>
    let IndividualChange = _prefix "IndividualChange"
    /// <summary>
    /// The change operation corresponding to the addition of an inverse property relation between two properties
    /// <see href="https://w3id.org/def/och#AddInverseProperty"></see></summary>
    let AddInverseProperty = _prefix "AddInverseProperty"
    /// <summary>
    /// The change operation corresponding to the change of an inverse prop7 relation between two properties
    /// <see href="https://w3id.org/def/och#InversePropertyChange"></see></summary>
    let InversePropertyChange = _prefix "InversePropertyChange"
    /// <summary>
    /// The change operation corresponding to the addition of an object property
    /// <see href="https://w3id.org/def/och#AddObjectProperty"></see></summary>
    let AddObjectProperty = _prefix "AddObjectProperty"
    /// <summary>
    /// The change operation corresponding to the change of an object property
    /// <see href="https://w3id.org/def/och#ObjectPropertyChange"></see></summary>
    let ObjectPropertyChange = _prefix "ObjectPropertyChange"
    /// <summary>
    /// The class that represents changes to properties
    /// <see href="https://w3id.org/def/och#PropertyChange"></see></summary>
    let PropertyChange = _prefix "PropertyChange"
    /// <summary>
    /// The change operation corresponding to the addition of the range to a given property
    /// <see href="https://w3id.org/def/och#AddRange"></see></summary>
    let AddRange = _prefix "AddRange"
    /// <summary>
    /// The change operation corresponding to the change of the range of a given property
    /// <see href="https://w3id.org/def/och#RangeChange"></see></summary>
    let RangeChange = _prefix "RangeChange"
    /// <summary>
    /// The change operation corresponding to the addition of the range of a given data property
    /// <see href="https://w3id.org/def/och#AddRangeDataProperty"></see></summary>
    let AddRangeDataProperty = _prefix "AddRangeDataProperty"
    /// <summary>
    /// The change operation corresponding to the addition of the range of a given object property
    /// <see href="https://w3id.org/def/och#AddRangeObjectProperty"></see></summary>
    let AddRangeObjectProperty = _prefix "AddRangeObjectProperty"
    /// <summary>
    /// The change operation corresponding to the addition of a relation between two individuals
    /// <see href="https://w3id.org/def/och#AddRelationToIndividual"></see></summary>
    let AddRelationToIndividual = _prefix "AddRelationToIndividual"
    /// <summary>
    /// The change operation corresponding to the change of a relationship between two individuals within the ontology
    /// <see href="https://w3id.org/def/och#IndividualRelationChange"></see></summary>
    let IndividualRelationChange = _prefix "IndividualRelationChange"
    /// <summary>
    /// The change operation corresponding to the addition of a subClass relation between two classes
    /// <see href="https://w3id.org/def/och#AddSubClass"></see></summary>
    let AddSubClass = _prefix "AddSubClass"
    /// <summary>
    /// The class that represents changes to a subclass relationship between two classes.
    /// <see href="https://w3id.org/def/och#SubClassChange"></see></summary>
    let SubClassChange = _prefix "SubClassChange"
    /// <summary>
    /// The change operation corresponding to the addition of a subProperty relation between two properties
    /// <see href="https://w3id.org/def/och#AddSubPropertyOf"></see></summary>
    let AddSubPropertyOf = _prefix "AddSubPropertyOf"
    /// <summary>
    /// The change operation corresponding to the change of the subProperty relation between to properties
    /// <see href="https://w3id.org/def/och#SubPropertyChange"></see></summary>
    let SubPropertyChange = _prefix "SubPropertyChange"
    /// <summary>
    /// The term that describes asymmetric properties.
    /// <see href="https://w3id.org/def/och#AsymmetricProperty"></see></summary>
    let AsymmetricProperty = _prefix "AsymmetricProperty"
    /// <summary>
    /// The term that describes those property characteristics that are exclusive to object properties
    /// <see href="https://w3id.org/def/och#ObjectPropertyCharacteristic"></see></summary>
    let ObjectPropertyCharacteristic = _prefix "ObjectPropertyCharacteristic"
    /// <summary>
    /// The class for representing sets of changes, it can be used for representing complex changes made out of atomic changes.
    /// <see href="https://w3id.org/def/och#ChangeSet"></see></summary>
    let ChangeSet = _prefix "ChangeSet"
    /// <summary>
    /// The set of change operations between ontology versions
    /// <see href="https://w3id.org/def/och#Changelog"></see></summary>
    let Changelog = _prefix "Changelog"
    /// <summary>
    /// The class that represents all changes to OWL Entities: classes, properties, and individuals
    /// <see href="https://w3id.org/def/och#EntityChange"></see></summary>
    let EntityChange = _prefix "EntityChange"
    /// <summary>
    /// The change operation corresponding to the change of the relationship between two classes
    /// <see href="https://w3id.org/def/och#ClassRelationChange"></see></summary>
    let ClassRelationChange = _prefix "ClassRelationChange"
    /// <summary>
    /// The change operation corresponding to the deprecation of an OWL Entity
    /// <see href="https://w3id.org/def/och#DeprecateEntity"></see></summary>
    let DeprecateEntity = _prefix "DeprecateEntity"
    /// <summary>
    /// The class that represents changes to property relations
    /// <see href="https://w3id.org/def/och#PropertyRelationChange"></see></summary>
    let PropertyRelationChange = _prefix "PropertyRelationChange"
    /// <summary>
    /// The class that represents all changes within an ontology being term-level, structural level, or higher level
    /// <see href="https://w3id.org/def/och#OntologicalChange"></see></summary>
    let OntologicalChange = _prefix "OntologicalChange"
    /// <summary>
    /// The term that describes Functional Properties.
    /// <see href="https://w3id.org/def/och#FunctionalProperty"></see></summary>
    let FunctionalProperty = _prefix "FunctionalProperty"
    /// <summary>
    /// The top term that encompases all characteristics
    /// <see href="https://w3id.org/def/och#PropertyCharacteristic"></see></summary>
    let PropertyCharacteristic = _prefix "PropertyCharacteristic"
    /// <summary>
    /// The term that describes the inverse functional properties.
    /// <see href="https://w3id.org/def/och#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"
    /// <summary>
    /// The term that describes irreflexive properties.
    /// <see href="https://w3id.org/def/och#IrreflexiveProperty"></see></summary>
    let IrreflexiveProperty = _prefix "IrreflexiveProperty"
    /// <summary>
    /// The term that describes reflexive properties.
    /// <see href="https://w3id.org/def/och#ReflexiveProperty"></see></summary>
    let ReflexiveProperty = _prefix "ReflexiveProperty"
    /// <summary>
    /// The change operation corresponding to the removal of a property characteristic
    /// <see href="https://w3id.org/def/och#RemoveCharacteristic"></see></summary>
    let RemoveCharacteristic = _prefix "RemoveCharacteristic"
    /// <summary>
    /// The change operation corresponding to the removal of a class
    /// <see href="https://w3id.org/def/och#RemoveClass"></see></summary>
    let RemoveClass = _prefix "RemoveClass"
    /// <summary>
    /// The change operation corresponding to the removal of a data property
    /// <see href="https://w3id.org/def/och#RemoveDataProperty"></see></summary>
    let RemoveDataProperty = _prefix "RemoveDataProperty"
    /// <summary>
    /// The class that represents the removal of a property to an ontology
    /// <see href="https://w3id.org/def/och#RemoveProperty"></see></summary>
    let RemoveProperty = _prefix "RemoveProperty"
    /// <summary>
    /// The change operation corresponding to the removal of a Disjoint Property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveDisjointProperty"></see></summary>
    let RemoveDisjointProperty = _prefix "RemoveDisjointProperty"
    /// <summary>
    /// The change operation corresponding to the removal of the domain of a given property
    /// <see href="https://w3id.org/def/och#RemoveDomain"></see></summary>
    let RemoveDomain = _prefix "RemoveDomain"
    /// <summary>
    /// The change operation corresponding to the removal of the equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#RemoveEquivalentClass"></see></summary>
    let RemoveEquivalentClass = _prefix "RemoveEquivalentClass"
    /// <summary>
    /// The change operation corresponding to the removal of the equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveEquivalentProperty"></see></summary>
    let RemoveEquivalentProperty = _prefix "RemoveEquivalentProperty"
    /// <summary>
    /// The change operation corresponding to the removal of an individual to the ontology
    /// <see href="https://w3id.org/def/och#RemoveIndividual"></see></summary>
    let RemoveIndividual = _prefix "RemoveIndividual"
    /// <summary>
    /// The change operation corresponding to the removal of the inverse property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveInverseProperty"></see></summary>
    let RemoveInverseProperty = _prefix "RemoveInverseProperty"
    /// <summary>
    /// The change operation corresponding to the removal of an object property
    /// <see href="https://w3id.org/def/och#RemoveObjectProperty"></see></summary>
    let RemoveObjectProperty = _prefix "RemoveObjectProperty"
    /// <summary>
    /// The change operation corresponding to the removal of the range of a given property
    /// <see href="https://w3id.org/def/och#RemoveRange"></see></summary>
    let RemoveRange = _prefix "RemoveRange"
    /// <summary>
    /// The change operation corresponding to the removal of the range of a data property
    /// <see href="https://w3id.org/def/och#RemoveRangeDataProperty"></see></summary>
    let RemoveRangeDataProperty = _prefix "RemoveRangeDataProperty"
    /// <summary>
    /// The change operation corresponding to the removal of the range off an object property
    /// <see href="https://w3id.org/def/och#RemoveRangeObjectProperty"></see></summary>
    let RemoveRangeObjectProperty = _prefix "RemoveRangeObjectProperty"
    /// <summary>
    /// The change operation corresponding to the removal of a relation between two individuals
    /// <see href="https://w3id.org/def/och#RemoveRelationFromIndividual"></see></summary>
    let RemoveRelationFromIndividual = _prefix "RemoveRelationFromIndividual"
    /// <summary>
    /// The change operation corresponding to the removal of the subClass relation between two classes
    /// <see href="https://w3id.org/def/och#RemoveSubClass"></see></summary>
    let RemoveSubClass = _prefix "RemoveSubClass"
    /// <summary>
    /// The change operation corresponding to the removal of the subProperty relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveSubPropertyOf"></see></summary>
    let RemoveSubPropertyOf = _prefix "RemoveSubPropertyOf"
    /// <summary>
    /// The change operation corresponding to the renaming of an OWL Entity within an ontology, this is whenever the semantics do not change and only the URI is modified
    /// <see href="https://w3id.org/def/och#RenameEntity"></see></summary>
    let RenameEntity = _prefix "RenameEntity"
    /// <summary>
    /// The change operation corresponding to the revokal of an ontological term
    /// <see href="https://w3id.org/def/och#RevokeDeprecate"></see></summary>
    let RevokeDeprecate = _prefix "RevokeDeprecate"
    /// <summary>
    /// The term that describes symmetric properties.
    /// <see href="https://w3id.org/def/och#SymmetricProperty"></see></summary>
    let SymmetricProperty = _prefix "SymmetricProperty"
    /// <summary>
    /// The term that describes transitive properties.
    /// <see href="https://w3id.org/def/och#TransitiveProperty"></see></summary>
    let TransitiveProperty = _prefix "TransitiveProperty"
    /// <summary>
    /// The characteristic being added to a given property
    /// <see href="https://w3id.org/def/och#addedCharacteristic"></see></summary>
    let addedCharacteristic = _prefix "addedCharacteristic"
    /// <summary>
    /// The property a characteristic is added to
    /// <see href="https://w3id.org/def/och#addedCharacteristicToProperty"></see></summary>
    let addedCharacteristicToProperty = _prefix "addedCharacteristicToProperty"
    /// <summary>
    /// The class being added in an AddClass operation
    /// <see href="https://w3id.org/def/och#addedClass"></see></summary>
    let addedClass = _prefix "addedClass"
    /// <summary>
    /// The entity that is being added in a change operation
    /// <see href="https://w3id.org/def/och#addedEntity"></see></summary>
    let addedEntity = _prefix "addedEntity"
    /// <summary>
    /// The data property that is being added to the ontology
    /// <see href="https://w3id.org/def/och#addedDataProperty"></see></summary>
    let addedDataProperty = _prefix "addedDataProperty"
    /// <summary>
    /// The range being added to a data property
    /// <see href="https://w3id.org/def/och#addedDataRange"></see></summary>
    let addedDataRange = _prefix "addedDataRange"
    /// <summary>
    /// The added domain of an Add Domain change operation
    /// <see href="https://w3id.org/def/och#addedDomain"></see></summary>
    let addedDomain = _prefix "addedDomain"
    /// <summary>
    /// The property a domain is added to.
    /// <see href="https://w3id.org/def/och#addedDomainToProperty"></see></summary>
    let addedDomainToProperty = _prefix "addedDomainToProperty"
    /// <summary>
    /// The individual being added in an AddIndividual operation
    /// <see href="https://w3id.org/def/och#addedIndividual"></see></summary>
    let addedIndividual = _prefix "addedIndividual"
    /// <summary>
    /// The object property being added to the ontology
    /// <see href="https://w3id.org/def/och#addedObjectProperty"></see></summary>
    let addedObjectProperty = _prefix "addedObjectProperty"
    /// <summary>
    /// The range that is being added to the object property
    /// <see href="https://w3id.org/def/och#addedObjectRange"></see></summary>
    let addedObjectRange = _prefix "addedObjectRange"
    /// <summary>
    /// The property being added to the ontology
    /// <see href="https://w3id.org/def/och#addedProperty"></see></summary>
    let addedProperty = _prefix "addedProperty"
    /// <summary>
    /// The property to which the change is being added.
    /// <see href="https://w3id.org/def/och#addedRangeToProperty"></see></summary>
    let addedRangeToProperty = _prefix "addedRangeToProperty"
    /// <summary>
    /// The individual that is the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#addedRelationToIndividual"></see></summary>
    let addedRelationToIndividual = _prefix "addedRelationToIndividual"
    /// <summary>
    /// The OWL Entity that is being deprecated
    /// <see href="https://w3id.org/def/och#deprecatedEntity"></see></summary>
    let deprecatedEntity = _prefix "deprecatedEntity"
    /// <summary>
    /// The fromChangelog property indicates that a given change belongs to a Changelog
    /// <see href="https://w3id.org/def/och#fromChangelog"></see></summary>
    let fromChangelog = _prefix "fromChangelog"
    /// <summary>
    /// The issuedBy property indicates what Agent has issued a change.
    /// <see href="https://w3id.org/def/och#issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// The new version the ontology is updated to.
    /// <see href="https://w3id.org/def/och#newVersion"></see></summary>
    let newVersion = _prefix "newVersion"
    /// <summary>
    /// The former name of the OWL Entity that has been renamed
    /// <see href="https://w3id.org/def/och#outdatedEntityName"></see></summary>
    let outdatedEntityName = _prefix "outdatedEntityName"
    /// <summary>
    /// The former version of the ontology that is being outdated
    /// <see href="https://w3id.org/def/och#prevVersion"></see></summary>
    let prevVersion = _prefix "prevVersion"
    /// <summary>
    /// The property that indicates an unspecified relation between two Ontology Changes
    /// <see href="https://w3id.org/def/och#relatedChange"></see></summary>
    let relatedChange = _prefix "relatedChange"
    /// <summary>
    /// The characteristic that is being removed from a property
    /// <see href="https://w3id.org/def/och#removedCharacteristic"></see></summary>
    let removedCharacteristic = _prefix "removedCharacteristic"
    /// <summary>
    /// The property a characteristicic is removed from
    /// <see href="https://w3id.org/def/och#removedCharacteristicFromProperty"></see></summary>
    let removedCharacteristicFromProperty = _prefix "removedCharacteristicFromProperty"
    /// <summary>
    /// The class that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedClass"></see></summary>
    let removedClass = _prefix "removedClass"
    /// <summary>
    /// The entity that is being removed in a change operation
    /// <see href="https://w3id.org/def/och#removedEntity"></see></summary>
    let removedEntity = _prefix "removedEntity"
    /// <summary>
    /// The data property that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedDataProperty"></see></summary>
    let removedDataProperty = _prefix "removedDataProperty"
    /// <summary>
    /// The range that is being removed from a Datatype Property
    /// <see href="https://w3id.org/def/och#removedDataRange"></see></summary>
    let removedDataRange = _prefix "removedDataRange"
    /// <summary>
    /// The domain that is being removed from a property
    /// <see href="https://w3id.org/def/och#removedDomain"></see></summary>
    let removedDomain = _prefix "removedDomain"
    /// <summary>
    /// The property a domain is removed from
    /// <see href="https://w3id.org/def/och#removedDomainFromProperty"></see></summary>
    let removedDomainFromProperty = _prefix "removedDomainFromProperty"
    /// <summary>
    /// The individual that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedIndividual"></see></summary>
    let removedIndividual = _prefix "removedIndividual"
    /// <summary>
    /// The object property being removed from an ontology
    /// <see href="https://w3id.org/def/och#removedObjectProperty"></see></summary>
    let removedObjectProperty = _prefix "removedObjectProperty"
    /// <summary>
    /// The range being removed from an object property
    /// <see href="https://w3id.org/def/och#removedObjectRange"></see></summary>
    let removedObjectRange = _prefix "removedObjectRange"
    /// <summary>
    /// The property being removed from the ontology
    /// <see href="https://w3id.org/def/och#removedProperty"></see></summary>
    let removedProperty = _prefix "removedProperty"
    /// <summary>
    /// The removed range for a property
    /// <see href="https://w3id.org/def/och#removedRangeFromProperty"></see></summary>
    let removedRangeFromProperty = _prefix "removedRangeFromProperty"
    /// <summary>
    /// The relation being removed from an individual in a change operation
    /// <see href="https://w3id.org/def/och#removedRelationFromIndividual"></see></summary>
    let removedRelationFromIndividual = _prefix "removedRelationFromIndividual"
    /// <summary>
    ///   <see href="https://w3id.org/def/och#RemoveRelationtoIndividual"></see>
    /// </summary>
    let RemoveRelationtoIndividual = _prefix "RemoveRelationtoIndividual"
    /// <summary>
    /// The new name the OWL Entity is being renamed to
    /// <see href="https://w3id.org/def/och#renamedEntityName"></see></summary>
    let renamedEntityName = _prefix "renamedEntityName"
    /// <summary>
    /// The subject of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddDisjointProperty"></see></summary>
    let sourceAddDisjointProperty = _prefix "sourceAddDisjointProperty"
    /// <summary>
    /// The property that is the subject of the property relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceProperty"></see></summary>
    let sourceProperty = _prefix "sourceProperty"
    /// <summary>
    /// The subject of the equivalent class relation being added
    /// <see href="https://w3id.org/def/och#sourceAddEquivalentClass"></see></summary>
    let sourceAddEquivalentClass = _prefix "sourceAddEquivalentClass"
    /// <summary>
    /// The class that is the subject of the class relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceClass"></see></summary>
    let sourceClass = _prefix "sourceClass"
    /// <summary>
    /// The subject of the equivalent property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddEquivalentProperty"></see></summary>
    let sourceAddEquivalentProperty = _prefix "sourceAddEquivalentProperty"
    /// <summary>
    /// The subject of the inverse property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddInverseProperty"></see></summary>
    let sourceAddInverseProperty = _prefix "sourceAddInverseProperty"
    /// <summary>
    /// The individual that is the subject of the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#sourceAddRelationToIndividual"></see></summary>
    let sourceAddRelationToIndividual = _prefix "sourceAddRelationToIndividual"
    /// <summary>
    /// The subject of the subClass relation being added
    /// <see href="https://w3id.org/def/och#sourceAddSubClass"></see></summary>
    let sourceAddSubClass = _prefix "sourceAddSubClass"
    /// <summary>
    /// The subject of the subProperty relation being added
    /// <see href="https://w3id.org/def/och#sourceAddSubProperty"></see></summary>
    let sourceAddSubProperty = _prefix "sourceAddSubProperty"
    /// <summary>
    /// The individual that is the subject of the relation being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceIndividual"></see></summary>
    let sourceIndividual = _prefix "sourceIndividual"
    /// <summary>
    /// The subject of the disjoint property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveDisjointProperty"></see></summary>
    let sourceRemoveDisjointProperty = _prefix "sourceRemoveDisjointProperty"
    /// <summary>
    /// The subject of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveEquivalentClass"></see></summary>
    let sourceRemoveEquivalentClass = _prefix "sourceRemoveEquivalentClass"
    /// <summary>
    /// The subject of the equivalent property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveEquivalentProperty"></see></summary>
    let sourceRemoveEquivalentProperty = _prefix "sourceRemoveEquivalentProperty"
    /// <summary>
    /// The subject of the inverse property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveInverseProperty"></see></summary>
    let sourceRemoveInverseProperty = _prefix "sourceRemoveInverseProperty"
    /// <summary>
    /// The individual that is the subject of the relation being removed in a change operation
    /// <see href="https://w3id.org/def/och#sourceRemoveRelationToIndividual"></see></summary>
    let sourceRemoveRelationToIndividual = _prefix "sourceRemoveRelationToIndividual"
    /// <summary>
    /// The subject of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#sourceRemoveSubClass"></see></summary>
    let sourceRemoveSubClass = _prefix "sourceRemoveSubClass"
    /// <summary>
    /// The subject of the subProperty relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveSubProperty"></see></summary>
    let sourceRemoveSubProperty = _prefix "sourceRemoveSubProperty"
    /// <summary>
    /// The object of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#targetAddDisjointProperty"></see></summary>
    let targetAddDisjointProperty = _prefix "targetAddDisjointProperty"
    /// <summary>
    /// The property that is the object of the property relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetProperty"></see></summary>
    let targetProperty = _prefix "targetProperty"
    /// <summary>
    /// The object of the equivalent class relation being added
    /// <see href="https://w3id.org/def/och#targetAddEquivalentClass"></see></summary>
    let targetAddEquivalentClass = _prefix "targetAddEquivalentClass"
    /// <summary>
    /// The class that is the object of the class relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetClass"></see></summary>
    let targetClass = _prefix "targetClass"
    /// <summary>
    /// The object of the equivalent property relation being added
    /// <see href="https://w3id.org/def/och#targetAddEquivalentProperty"></see></summary>
    let targetAddEquivalentProperty = _prefix "targetAddEquivalentProperty"
    /// <summary>
    /// The object of the inverse property relation being added
    /// <see href="https://w3id.org/def/och#targetAddInverseProperty"></see></summary>
    let targetAddInverseProperty = _prefix "targetAddInverseProperty"
    /// <summary>
    /// The individual that is the object of the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#targetAddRelationToIndividual"></see></summary>
    let targetAddRelationToIndividual = _prefix "targetAddRelationToIndividual"
    /// <summary>
    /// The object of the subClass relation being added
    /// <see href="https://w3id.org/def/och#targetAddSubClass"></see></summary>
    let targetAddSubClass = _prefix "targetAddSubClass"
    /// <summary>
    /// The object of the subProperty relation being added
    /// <see href="https://w3id.org/def/och#targetAddSubProperty"></see></summary>
    let targetAddSubProperty = _prefix "targetAddSubProperty"
    /// <summary>
    /// The object of the disjoint property relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveDisjointProperty"></see></summary>
    let targetRemoveDisjointProperty = _prefix "targetRemoveDisjointProperty"
    /// <summary>
    /// The object of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveEquivalentClass"></see></summary>
    let targetRemoveEquivalentClass = _prefix "targetRemoveEquivalentClass"
    /// <summary>
    /// The object of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveEquivalentProperty"></see></summary>
    let targetRemoveEquivalentProperty = _prefix "targetRemoveEquivalentProperty"
    /// <summary>
    /// The object of the inverse property relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveInverseProperty"></see></summary>
    let targetRemoveInverseProperty = _prefix "targetRemoveInverseProperty"
    /// <summary>
    /// The individual that is the object of the relation being removed in a change operation
    /// <see href="https://w3id.org/def/och#targetRemoveRelationToIndividual"></see></summary>
    let targetRemoveRelationToIndividual = _prefix "targetRemoveRelationToIndividual"
    /// <summary>
    /// The object of the subClass relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveSubClass"></see></summary>
    let targetRemoveSubClass = _prefix "targetRemoveSubClass"
    /// <summary>
    /// The object of the subProperty relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveSubProperty"></see></summary>
    let targetRemoveSubProperty = _prefix "targetRemoveSubProperty"
    /// <summary>
    /// The individual that is the object of the relation being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetResource"></see></summary>
    let targetResource = _prefix "targetResource"
    /// <summary>
    /// The ontological term that is being undeprecated
    /// <see href="https://w3id.org/def/och#undeprecatedElement"></see></summary>
    let undeprecatedElement = _prefix "undeprecatedElement"
