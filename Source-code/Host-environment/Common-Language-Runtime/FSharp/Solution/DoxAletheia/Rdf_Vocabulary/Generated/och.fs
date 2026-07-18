namespace https.w3id.org.def.och.hash

open DoxAletheia.Rdf_Vocabulary

module och =
    let _namespace_name = "https://w3id.org/def/och#"

    /// <summary>
    /// The change operation corresponding to addition of a characteristic to a property
    /// <see href="https://w3id.org/def/och#AddCharacteristic"></see></summary>
    let AddCharacteristic =
        Namespaced_IRI.parse _namespace_name "AddCharacteristic" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a property characteristic.
    /// <see href="https://w3id.org/def/och#PropertyCharacteristicChange"></see></summary>
    let PropertyCharacteristicChange =
        Namespaced_IRI.parse _namespace_name "PropertyCharacteristicChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a class
    /// <see href="https://w3id.org/def/och#AddClass"></see></summary>
    let AddClass = Namespaced_IRI.parse _namespace_name "AddClass" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a given class within the ontology
    /// <see href="https://w3id.org/def/och#ClassChange"></see></summary>
    let ClassChange =
        Namespaced_IRI.parse _namespace_name "ClassChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a data property
    /// <see href="https://w3id.org/def/och#AddDataProperty"></see></summary>
    let AddDataProperty =
        Namespaced_IRI.parse _namespace_name "AddDataProperty" |> NamespacedName

    /// <summary>
    /// The class that represents the addition of a property to an ontology
    /// <see href="https://w3id.org/def/och#AddProperty"></see></summary>
    let AddProperty =
        Namespaced_IRI.parse _namespace_name "AddProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a data property
    /// <see href="https://w3id.org/def/och#DataPropertyChange"></see></summary>
    let DataPropertyChange =
        Namespaced_IRI.parse _namespace_name "DataPropertyChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a Disjoint Property relation between two properties
    /// <see href="https://w3id.org/def/och#AddDisjointProperty"></see></summary>
    let AddDisjointProperty =
        Namespaced_IRI.parse _namespace_name "AddDisjointProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a Disjoint Property
    /// <see href="https://w3id.org/def/och#DisjointPropertyChange"></see></summary>
    let DisjointPropertyChange =
        Namespaced_IRI.parse _namespace_name "DisjointPropertyChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of the domain to a given property
    /// <see href="https://w3id.org/def/och#AddDomain"></see></summary>
    let AddDomain = Namespaced_IRI.parse _namespace_name "AddDomain" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of the domain of a given property
    /// <see href="https://w3id.org/def/och#DomainChange"></see></summary>
    let DomainChange =
        Namespaced_IRI.parse _namespace_name "DomainChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of an equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#AddEquivalentClass"></see></summary>
    let AddEquivalentClass =
        Namespaced_IRI.parse _namespace_name "AddEquivalentClass" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of an equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#EquivalentClassChange"></see></summary>
    let EquivalentClassChange =
        Namespaced_IRI.parse _namespace_name "EquivalentClassChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of an equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#AddEquivalentProperty"></see></summary>
    let AddEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "AddEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of an equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#EquivalentPropertyChange"></see></summary>
    let EquivalentPropertyChange =
        Namespaced_IRI.parse _namespace_name "EquivalentPropertyChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of an individual to the ontology
    /// <see href="https://w3id.org/def/och#AddIndividual"></see></summary>
    let AddIndividual =
        Namespaced_IRI.parse _namespace_name "AddIndividual" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a given individual within the ontology
    /// <see href="https://w3id.org/def/och#IndividualChange"></see></summary>
    let IndividualChange =
        Namespaced_IRI.parse _namespace_name "IndividualChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of an inverse property relation between two properties
    /// <see href="https://w3id.org/def/och#AddInverseProperty"></see></summary>
    let AddInverseProperty =
        Namespaced_IRI.parse _namespace_name "AddInverseProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of an inverse prop7 relation between two properties
    /// <see href="https://w3id.org/def/och#InversePropertyChange"></see></summary>
    let InversePropertyChange =
        Namespaced_IRI.parse _namespace_name "InversePropertyChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of an object property
    /// <see href="https://w3id.org/def/och#AddObjectProperty"></see></summary>
    let AddObjectProperty =
        Namespaced_IRI.parse _namespace_name "AddObjectProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of an object property
    /// <see href="https://w3id.org/def/och#ObjectPropertyChange"></see></summary>
    let ObjectPropertyChange =
        Namespaced_IRI.parse _namespace_name "ObjectPropertyChange" |> NamespacedName

    /// <summary>
    /// The class that represents changes to properties
    /// <see href="https://w3id.org/def/och#PropertyChange"></see></summary>
    let PropertyChange =
        Namespaced_IRI.parse _namespace_name "PropertyChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of the range to a given property
    /// <see href="https://w3id.org/def/och#AddRange"></see></summary>
    let AddRange = Namespaced_IRI.parse _namespace_name "AddRange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of the range of a given property
    /// <see href="https://w3id.org/def/och#RangeChange"></see></summary>
    let RangeChange =
        Namespaced_IRI.parse _namespace_name "RangeChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of the range of a given data property
    /// <see href="https://w3id.org/def/och#AddRangeDataProperty"></see></summary>
    let AddRangeDataProperty =
        Namespaced_IRI.parse _namespace_name "AddRangeDataProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of the range of a given object property
    /// <see href="https://w3id.org/def/och#AddRangeObjectProperty"></see></summary>
    let AddRangeObjectProperty =
        Namespaced_IRI.parse _namespace_name "AddRangeObjectProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a relation between two individuals
    /// <see href="https://w3id.org/def/och#AddRelationToIndividual"></see></summary>
    let AddRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "AddRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of a relationship between two individuals within the ontology
    /// <see href="https://w3id.org/def/och#IndividualRelationChange"></see></summary>
    let IndividualRelationChange =
        Namespaced_IRI.parse _namespace_name "IndividualRelationChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a subClass relation between two classes
    /// <see href="https://w3id.org/def/och#AddSubClass"></see></summary>
    let AddSubClass =
        Namespaced_IRI.parse _namespace_name "AddSubClass" |> NamespacedName

    /// <summary>
    /// The class that represents changes to a subclass relationship between two classes.
    /// <see href="https://w3id.org/def/och#SubClassChange"></see></summary>
    let SubClassChange =
        Namespaced_IRI.parse _namespace_name "SubClassChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the addition of a subProperty relation between two properties
    /// <see href="https://w3id.org/def/och#AddSubPropertyOf"></see></summary>
    let AddSubPropertyOf =
        Namespaced_IRI.parse _namespace_name "AddSubPropertyOf" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of the subProperty relation between to properties
    /// <see href="https://w3id.org/def/och#SubPropertyChange"></see></summary>
    let SubPropertyChange =
        Namespaced_IRI.parse _namespace_name "SubPropertyChange" |> NamespacedName

    /// <summary>
    /// The term that describes asymmetric properties.
    /// <see href="https://w3id.org/def/och#AsymmetricProperty"></see></summary>
    let AsymmetricProperty =
        Namespaced_IRI.parse _namespace_name "AsymmetricProperty" |> NamespacedName

    /// <summary>
    /// The term that describes those property characteristics that are exclusive to object properties
    /// <see href="https://w3id.org/def/och#ObjectPropertyCharacteristic"></see></summary>
    let ObjectPropertyCharacteristic =
        Namespaced_IRI.parse _namespace_name "ObjectPropertyCharacteristic" |> NamespacedName

    /// <summary>
    /// The class for representing sets of changes, it can be used for representing complex changes made out of atomic changes.
    /// <see href="https://w3id.org/def/och#ChangeSet"></see></summary>
    let ChangeSet = Namespaced_IRI.parse _namespace_name "ChangeSet" |> NamespacedName
    /// <summary>
    /// The set of change operations between ontology versions
    /// <see href="https://w3id.org/def/och#Changelog"></see></summary>
    let Changelog = Namespaced_IRI.parse _namespace_name "Changelog" |> NamespacedName

    /// <summary>
    /// The class that represents all changes to OWL Entities: classes, properties, and individuals
    /// <see href="https://w3id.org/def/och#EntityChange"></see></summary>
    let EntityChange =
        Namespaced_IRI.parse _namespace_name "EntityChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the change of the relationship between two classes
    /// <see href="https://w3id.org/def/och#ClassRelationChange"></see></summary>
    let ClassRelationChange =
        Namespaced_IRI.parse _namespace_name "ClassRelationChange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the deprecation of an OWL Entity
    /// <see href="https://w3id.org/def/och#DeprecateEntity"></see></summary>
    let DeprecateEntity =
        Namespaced_IRI.parse _namespace_name "DeprecateEntity" |> NamespacedName

    /// <summary>
    /// The class that represents changes to property relations
    /// <see href="https://w3id.org/def/och#PropertyRelationChange"></see></summary>
    let PropertyRelationChange =
        Namespaced_IRI.parse _namespace_name "PropertyRelationChange" |> NamespacedName

    /// <summary>
    /// The class that represents all changes within an ontology being term-level, structural level, or higher level
    /// <see href="https://w3id.org/def/och#OntologicalChange"></see></summary>
    let OntologicalChange =
        Namespaced_IRI.parse _namespace_name "OntologicalChange" |> NamespacedName

    /// <summary>
    /// The term that describes Functional Properties.
    /// <see href="https://w3id.org/def/och#FunctionalProperty"></see></summary>
    let FunctionalProperty =
        Namespaced_IRI.parse _namespace_name "FunctionalProperty" |> NamespacedName

    /// <summary>
    /// The top term that encompases all characteristics
    /// <see href="https://w3id.org/def/och#PropertyCharacteristic"></see></summary>
    let PropertyCharacteristic =
        Namespaced_IRI.parse _namespace_name "PropertyCharacteristic" |> NamespacedName

    /// <summary>
    /// The term that describes the inverse functional properties.
    /// <see href="https://w3id.org/def/och#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty =
        Namespaced_IRI.parse _namespace_name "InverseFunctionalProperty" |> NamespacedName

    /// <summary>
    /// The term that describes irreflexive properties.
    /// <see href="https://w3id.org/def/och#IrreflexiveProperty"></see></summary>
    let IrreflexiveProperty =
        Namespaced_IRI.parse _namespace_name "IrreflexiveProperty" |> NamespacedName

    /// <summary>
    /// The term that describes reflexive properties.
    /// <see href="https://w3id.org/def/och#ReflexiveProperty"></see></summary>
    let ReflexiveProperty =
        Namespaced_IRI.parse _namespace_name "ReflexiveProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of a property characteristic
    /// <see href="https://w3id.org/def/och#RemoveCharacteristic"></see></summary>
    let RemoveCharacteristic =
        Namespaced_IRI.parse _namespace_name "RemoveCharacteristic" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of a class
    /// <see href="https://w3id.org/def/och#RemoveClass"></see></summary>
    let RemoveClass =
        Namespaced_IRI.parse _namespace_name "RemoveClass" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of a data property
    /// <see href="https://w3id.org/def/och#RemoveDataProperty"></see></summary>
    let RemoveDataProperty =
        Namespaced_IRI.parse _namespace_name "RemoveDataProperty" |> NamespacedName

    /// <summary>
    /// The class that represents the removal of a property to an ontology
    /// <see href="https://w3id.org/def/och#RemoveProperty"></see></summary>
    let RemoveProperty =
        Namespaced_IRI.parse _namespace_name "RemoveProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of a Disjoint Property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveDisjointProperty"></see></summary>
    let RemoveDisjointProperty =
        Namespaced_IRI.parse _namespace_name "RemoveDisjointProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the domain of a given property
    /// <see href="https://w3id.org/def/och#RemoveDomain"></see></summary>
    let RemoveDomain =
        Namespaced_IRI.parse _namespace_name "RemoveDomain" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the equivalent class relation between two classes
    /// <see href="https://w3id.org/def/och#RemoveEquivalentClass"></see></summary>
    let RemoveEquivalentClass =
        Namespaced_IRI.parse _namespace_name "RemoveEquivalentClass" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the equivalent property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveEquivalentProperty"></see></summary>
    let RemoveEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "RemoveEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of an individual to the ontology
    /// <see href="https://w3id.org/def/och#RemoveIndividual"></see></summary>
    let RemoveIndividual =
        Namespaced_IRI.parse _namespace_name "RemoveIndividual" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the inverse property relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveInverseProperty"></see></summary>
    let RemoveInverseProperty =
        Namespaced_IRI.parse _namespace_name "RemoveInverseProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of an object property
    /// <see href="https://w3id.org/def/och#RemoveObjectProperty"></see></summary>
    let RemoveObjectProperty =
        Namespaced_IRI.parse _namespace_name "RemoveObjectProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the range of a given property
    /// <see href="https://w3id.org/def/och#RemoveRange"></see></summary>
    let RemoveRange =
        Namespaced_IRI.parse _namespace_name "RemoveRange" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the range of a data property
    /// <see href="https://w3id.org/def/och#RemoveRangeDataProperty"></see></summary>
    let RemoveRangeDataProperty =
        Namespaced_IRI.parse _namespace_name "RemoveRangeDataProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the range off an object property
    /// <see href="https://w3id.org/def/och#RemoveRangeObjectProperty"></see></summary>
    let RemoveRangeObjectProperty =
        Namespaced_IRI.parse _namespace_name "RemoveRangeObjectProperty" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of a relation between two individuals
    /// <see href="https://w3id.org/def/och#RemoveRelationFromIndividual"></see></summary>
    let RemoveRelationFromIndividual =
        Namespaced_IRI.parse _namespace_name "RemoveRelationFromIndividual" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the subClass relation between two classes
    /// <see href="https://w3id.org/def/och#RemoveSubClass"></see></summary>
    let RemoveSubClass =
        Namespaced_IRI.parse _namespace_name "RemoveSubClass" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the removal of the subProperty relation between two properties
    /// <see href="https://w3id.org/def/och#RemoveSubPropertyOf"></see></summary>
    let RemoveSubPropertyOf =
        Namespaced_IRI.parse _namespace_name "RemoveSubPropertyOf" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the renaming of an OWL Entity within an ontology, this is whenever the semantics do not change and only the URI is modified
    /// <see href="https://w3id.org/def/och#RenameEntity"></see></summary>
    let RenameEntity =
        Namespaced_IRI.parse _namespace_name "RenameEntity" |> NamespacedName

    /// <summary>
    /// The change operation corresponding to the revokal of an ontological term
    /// <see href="https://w3id.org/def/och#RevokeDeprecate"></see></summary>
    let RevokeDeprecate =
        Namespaced_IRI.parse _namespace_name "RevokeDeprecate" |> NamespacedName

    /// <summary>
    /// The term that describes symmetric properties.
    /// <see href="https://w3id.org/def/och#SymmetricProperty"></see></summary>
    let SymmetricProperty =
        Namespaced_IRI.parse _namespace_name "SymmetricProperty" |> NamespacedName

    /// <summary>
    /// The term that describes transitive properties.
    /// <see href="https://w3id.org/def/och#TransitiveProperty"></see></summary>
    let TransitiveProperty =
        Namespaced_IRI.parse _namespace_name "TransitiveProperty" |> NamespacedName

    /// <summary>
    /// The characteristic being added to a given property
    /// <see href="https://w3id.org/def/och#addedCharacteristic"></see></summary>
    let addedCharacteristic =
        Namespaced_IRI.parse _namespace_name "addedCharacteristic" |> NamespacedName

    /// <summary>
    /// The property a characteristic is added to
    /// <see href="https://w3id.org/def/och#addedCharacteristicToProperty"></see></summary>
    let addedCharacteristicToProperty =
        Namespaced_IRI.parse _namespace_name "addedCharacteristicToProperty" |> NamespacedName

    /// <summary>
    /// The class being added in an AddClass operation
    /// <see href="https://w3id.org/def/och#addedClass"></see></summary>
    let addedClass = Namespaced_IRI.parse _namespace_name "addedClass" |> NamespacedName

    /// <summary>
    /// The entity that is being added in a change operation
    /// <see href="https://w3id.org/def/och#addedEntity"></see></summary>
    let addedEntity =
        Namespaced_IRI.parse _namespace_name "addedEntity" |> NamespacedName

    /// <summary>
    /// The data property that is being added to the ontology
    /// <see href="https://w3id.org/def/och#addedDataProperty"></see></summary>
    let addedDataProperty =
        Namespaced_IRI.parse _namespace_name "addedDataProperty" |> NamespacedName

    /// <summary>
    /// The range being added to a data property
    /// <see href="https://w3id.org/def/och#addedDataRange"></see></summary>
    let addedDataRange =
        Namespaced_IRI.parse _namespace_name "addedDataRange" |> NamespacedName

    /// <summary>
    /// The added domain of an Add Domain change operation
    /// <see href="https://w3id.org/def/och#addedDomain"></see></summary>
    let addedDomain =
        Namespaced_IRI.parse _namespace_name "addedDomain" |> NamespacedName

    /// <summary>
    /// The property a domain is added to.
    /// <see href="https://w3id.org/def/och#addedDomainToProperty"></see></summary>
    let addedDomainToProperty =
        Namespaced_IRI.parse _namespace_name "addedDomainToProperty" |> NamespacedName

    /// <summary>
    /// The individual being added in an AddIndividual operation
    /// <see href="https://w3id.org/def/och#addedIndividual"></see></summary>
    let addedIndividual =
        Namespaced_IRI.parse _namespace_name "addedIndividual" |> NamespacedName

    /// <summary>
    /// The object property being added to the ontology
    /// <see href="https://w3id.org/def/och#addedObjectProperty"></see></summary>
    let addedObjectProperty =
        Namespaced_IRI.parse _namespace_name "addedObjectProperty" |> NamespacedName

    /// <summary>
    /// The range that is being added to the object property
    /// <see href="https://w3id.org/def/och#addedObjectRange"></see></summary>
    let addedObjectRange =
        Namespaced_IRI.parse _namespace_name "addedObjectRange" |> NamespacedName

    /// <summary>
    /// The property being added to the ontology
    /// <see href="https://w3id.org/def/och#addedProperty"></see></summary>
    let addedProperty =
        Namespaced_IRI.parse _namespace_name "addedProperty" |> NamespacedName

    /// <summary>
    /// The property to which the change is being added.
    /// <see href="https://w3id.org/def/och#addedRangeToProperty"></see></summary>
    let addedRangeToProperty =
        Namespaced_IRI.parse _namespace_name "addedRangeToProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#addedRelationToIndividual"></see></summary>
    let addedRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "addedRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The OWL Entity that is being deprecated
    /// <see href="https://w3id.org/def/och#deprecatedEntity"></see></summary>
    let deprecatedEntity =
        Namespaced_IRI.parse _namespace_name "deprecatedEntity" |> NamespacedName

    /// <summary>
    /// The fromChangelog property indicates that a given change belongs to a Changelog
    /// <see href="https://w3id.org/def/och#fromChangelog"></see></summary>
    let fromChangelog =
        Namespaced_IRI.parse _namespace_name "fromChangelog" |> NamespacedName

    /// <summary>
    /// The issuedBy property indicates what Agent has issued a change.
    /// <see href="https://w3id.org/def/och#issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName
    /// <summary>
    /// The new version the ontology is updated to.
    /// <see href="https://w3id.org/def/och#newVersion"></see></summary>
    let newVersion = Namespaced_IRI.parse _namespace_name "newVersion" |> NamespacedName

    /// <summary>
    /// The former name of the OWL Entity that has been renamed
    /// <see href="https://w3id.org/def/och#outdatedEntityName"></see></summary>
    let outdatedEntityName =
        Namespaced_IRI.parse _namespace_name "outdatedEntityName" |> NamespacedName

    /// <summary>
    /// The former version of the ontology that is being outdated
    /// <see href="https://w3id.org/def/och#prevVersion"></see></summary>
    let prevVersion =
        Namespaced_IRI.parse _namespace_name "prevVersion" |> NamespacedName

    /// <summary>
    /// The property that indicates an unspecified relation between two Ontology Changes
    /// <see href="https://w3id.org/def/och#relatedChange"></see></summary>
    let relatedChange =
        Namespaced_IRI.parse _namespace_name "relatedChange" |> NamespacedName

    /// <summary>
    /// The characteristic that is being removed from a property
    /// <see href="https://w3id.org/def/och#removedCharacteristic"></see></summary>
    let removedCharacteristic =
        Namespaced_IRI.parse _namespace_name "removedCharacteristic" |> NamespacedName

    /// <summary>
    /// The property a characteristicic is removed from
    /// <see href="https://w3id.org/def/och#removedCharacteristicFromProperty"></see></summary>
    let removedCharacteristicFromProperty =
        Namespaced_IRI.parse _namespace_name "removedCharacteristicFromProperty" |> NamespacedName

    /// <summary>
    /// The class that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedClass"></see></summary>
    let removedClass =
        Namespaced_IRI.parse _namespace_name "removedClass" |> NamespacedName

    /// <summary>
    /// The entity that is being removed in a change operation
    /// <see href="https://w3id.org/def/och#removedEntity"></see></summary>
    let removedEntity =
        Namespaced_IRI.parse _namespace_name "removedEntity" |> NamespacedName

    /// <summary>
    /// The data property that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedDataProperty"></see></summary>
    let removedDataProperty =
        Namespaced_IRI.parse _namespace_name "removedDataProperty" |> NamespacedName

    /// <summary>
    /// The range that is being removed from a Datatype Property
    /// <see href="https://w3id.org/def/och#removedDataRange"></see></summary>
    let removedDataRange =
        Namespaced_IRI.parse _namespace_name "removedDataRange" |> NamespacedName

    /// <summary>
    /// The domain that is being removed from a property
    /// <see href="https://w3id.org/def/och#removedDomain"></see></summary>
    let removedDomain =
        Namespaced_IRI.parse _namespace_name "removedDomain" |> NamespacedName

    /// <summary>
    /// The property a domain is removed from
    /// <see href="https://w3id.org/def/och#removedDomainFromProperty"></see></summary>
    let removedDomainFromProperty =
        Namespaced_IRI.parse _namespace_name "removedDomainFromProperty" |> NamespacedName

    /// <summary>
    /// The individual that is being removed in an ontology
    /// <see href="https://w3id.org/def/och#removedIndividual"></see></summary>
    let removedIndividual =
        Namespaced_IRI.parse _namespace_name "removedIndividual" |> NamespacedName

    /// <summary>
    /// The object property being removed from an ontology
    /// <see href="https://w3id.org/def/och#removedObjectProperty"></see></summary>
    let removedObjectProperty =
        Namespaced_IRI.parse _namespace_name "removedObjectProperty" |> NamespacedName

    /// <summary>
    /// The range being removed from an object property
    /// <see href="https://w3id.org/def/och#removedObjectRange"></see></summary>
    let removedObjectRange =
        Namespaced_IRI.parse _namespace_name "removedObjectRange" |> NamespacedName

    /// <summary>
    /// The property being removed from the ontology
    /// <see href="https://w3id.org/def/och#removedProperty"></see></summary>
    let removedProperty =
        Namespaced_IRI.parse _namespace_name "removedProperty" |> NamespacedName

    /// <summary>
    /// The removed range for a property
    /// <see href="https://w3id.org/def/och#removedRangeFromProperty"></see></summary>
    let removedRangeFromProperty =
        Namespaced_IRI.parse _namespace_name "removedRangeFromProperty" |> NamespacedName

    /// <summary>
    /// The relation being removed from an individual in a change operation
    /// <see href="https://w3id.org/def/och#removedRelationFromIndividual"></see></summary>
    let removedRelationFromIndividual =
        Namespaced_IRI.parse _namespace_name "removedRelationFromIndividual" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/def/och#RemoveRelationtoIndividual"></see>
    /// </summary>
    let RemoveRelationtoIndividual =
        Namespaced_IRI.parse _namespace_name "RemoveRelationtoIndividual" |> NamespacedName

    /// <summary>
    /// The new name the OWL Entity is being renamed to
    /// <see href="https://w3id.org/def/och#renamedEntityName"></see></summary>
    let renamedEntityName =
        Namespaced_IRI.parse _namespace_name "renamedEntityName" |> NamespacedName

    /// <summary>
    /// The subject of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddDisjointProperty"></see></summary>
    let sourceAddDisjointProperty =
        Namespaced_IRI.parse _namespace_name "sourceAddDisjointProperty" |> NamespacedName

    /// <summary>
    /// The property that is the subject of the property relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceProperty"></see></summary>
    let sourceProperty =
        Namespaced_IRI.parse _namespace_name "sourceProperty" |> NamespacedName

    /// <summary>
    /// The subject of the equivalent class relation being added
    /// <see href="https://w3id.org/def/och#sourceAddEquivalentClass"></see></summary>
    let sourceAddEquivalentClass =
        Namespaced_IRI.parse _namespace_name "sourceAddEquivalentClass" |> NamespacedName

    /// <summary>
    /// The class that is the subject of the class relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceClass"></see></summary>
    let sourceClass =
        Namespaced_IRI.parse _namespace_name "sourceClass" |> NamespacedName

    /// <summary>
    /// The subject of the equivalent property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddEquivalentProperty"></see></summary>
    let sourceAddEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "sourceAddEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The subject of the inverse property relation being added
    /// <see href="https://w3id.org/def/och#sourceAddInverseProperty"></see></summary>
    let sourceAddInverseProperty =
        Namespaced_IRI.parse _namespace_name "sourceAddInverseProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the subject of the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#sourceAddRelationToIndividual"></see></summary>
    let sourceAddRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "sourceAddRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The subject of the subClass relation being added
    /// <see href="https://w3id.org/def/och#sourceAddSubClass"></see></summary>
    let sourceAddSubClass =
        Namespaced_IRI.parse _namespace_name "sourceAddSubClass" |> NamespacedName

    /// <summary>
    /// The subject of the subProperty relation being added
    /// <see href="https://w3id.org/def/och#sourceAddSubProperty"></see></summary>
    let sourceAddSubProperty =
        Namespaced_IRI.parse _namespace_name "sourceAddSubProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the subject of the relation being changed in a change operation
    /// <see href="https://w3id.org/def/och#sourceIndividual"></see></summary>
    let sourceIndividual =
        Namespaced_IRI.parse _namespace_name "sourceIndividual" |> NamespacedName

    /// <summary>
    /// The subject of the disjoint property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveDisjointProperty"></see></summary>
    let sourceRemoveDisjointProperty =
        Namespaced_IRI.parse _namespace_name "sourceRemoveDisjointProperty" |> NamespacedName

    /// <summary>
    /// The subject of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveEquivalentClass"></see></summary>
    let sourceRemoveEquivalentClass =
        Namespaced_IRI.parse _namespace_name "sourceRemoveEquivalentClass" |> NamespacedName

    /// <summary>
    /// The subject of the equivalent property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveEquivalentProperty"></see></summary>
    let sourceRemoveEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "sourceRemoveEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The subject of the inverse property relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveInverseProperty"></see></summary>
    let sourceRemoveInverseProperty =
        Namespaced_IRI.parse _namespace_name "sourceRemoveInverseProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the subject of the relation being removed in a change operation
    /// <see href="https://w3id.org/def/och#sourceRemoveRelationToIndividual"></see></summary>
    let sourceRemoveRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "sourceRemoveRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The subject of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#sourceRemoveSubClass"></see></summary>
    let sourceRemoveSubClass =
        Namespaced_IRI.parse _namespace_name "sourceRemoveSubClass" |> NamespacedName

    /// <summary>
    /// The subject of the subProperty relation being removed
    /// <see href="https://w3id.org/def/och#sourceRemoveSubProperty"></see></summary>
    let sourceRemoveSubProperty =
        Namespaced_IRI.parse _namespace_name "sourceRemoveSubProperty" |> NamespacedName

    /// <summary>
    /// The object of the disjoint property relation being added
    /// <see href="https://w3id.org/def/och#targetAddDisjointProperty"></see></summary>
    let targetAddDisjointProperty =
        Namespaced_IRI.parse _namespace_name "targetAddDisjointProperty" |> NamespacedName

    /// <summary>
    /// The property that is the object of the property relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetProperty"></see></summary>
    let targetProperty =
        Namespaced_IRI.parse _namespace_name "targetProperty" |> NamespacedName

    /// <summary>
    /// The object of the equivalent class relation being added
    /// <see href="https://w3id.org/def/och#targetAddEquivalentClass"></see></summary>
    let targetAddEquivalentClass =
        Namespaced_IRI.parse _namespace_name "targetAddEquivalentClass" |> NamespacedName

    /// <summary>
    /// The class that is the object of the class relations being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetClass"></see></summary>
    let targetClass =
        Namespaced_IRI.parse _namespace_name "targetClass" |> NamespacedName

    /// <summary>
    /// The object of the equivalent property relation being added
    /// <see href="https://w3id.org/def/och#targetAddEquivalentProperty"></see></summary>
    let targetAddEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "targetAddEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The object of the inverse property relation being added
    /// <see href="https://w3id.org/def/och#targetAddInverseProperty"></see></summary>
    let targetAddInverseProperty =
        Namespaced_IRI.parse _namespace_name "targetAddInverseProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the object of the relation being added in a change operation
    /// <see href="https://w3id.org/def/och#targetAddRelationToIndividual"></see></summary>
    let targetAddRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "targetAddRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The object of the subClass relation being added
    /// <see href="https://w3id.org/def/och#targetAddSubClass"></see></summary>
    let targetAddSubClass =
        Namespaced_IRI.parse _namespace_name "targetAddSubClass" |> NamespacedName

    /// <summary>
    /// The object of the subProperty relation being added
    /// <see href="https://w3id.org/def/och#targetAddSubProperty"></see></summary>
    let targetAddSubProperty =
        Namespaced_IRI.parse _namespace_name "targetAddSubProperty" |> NamespacedName

    /// <summary>
    /// The object of the disjoint property relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveDisjointProperty"></see></summary>
    let targetRemoveDisjointProperty =
        Namespaced_IRI.parse _namespace_name "targetRemoveDisjointProperty" |> NamespacedName

    /// <summary>
    /// The object of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveEquivalentClass"></see></summary>
    let targetRemoveEquivalentClass =
        Namespaced_IRI.parse _namespace_name "targetRemoveEquivalentClass" |> NamespacedName

    /// <summary>
    /// The object of the equivalent class relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveEquivalentProperty"></see></summary>
    let targetRemoveEquivalentProperty =
        Namespaced_IRI.parse _namespace_name "targetRemoveEquivalentProperty" |> NamespacedName

    /// <summary>
    /// The object of the inverse property relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveInverseProperty"></see></summary>
    let targetRemoveInverseProperty =
        Namespaced_IRI.parse _namespace_name "targetRemoveInverseProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the object of the relation being removed in a change operation
    /// <see href="https://w3id.org/def/och#targetRemoveRelationToIndividual"></see></summary>
    let targetRemoveRelationToIndividual =
        Namespaced_IRI.parse _namespace_name "targetRemoveRelationToIndividual" |> NamespacedName

    /// <summary>
    /// The object of the subClass relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveSubClass"></see></summary>
    let targetRemoveSubClass =
        Namespaced_IRI.parse _namespace_name "targetRemoveSubClass" |> NamespacedName

    /// <summary>
    /// The object of the subProperty relation being removed
    /// <see href="https://w3id.org/def/och#targetRemoveSubProperty"></see></summary>
    let targetRemoveSubProperty =
        Namespaced_IRI.parse _namespace_name "targetRemoveSubProperty" |> NamespacedName

    /// <summary>
    /// The individual that is the object of the relation being changed in a change operation
    /// <see href="https://w3id.org/def/och#targetResource"></see></summary>
    let targetResource =
        Namespaced_IRI.parse _namespace_name "targetResource" |> NamespacedName

    /// <summary>
    /// The ontological term that is being undeprecated
    /// <see href="https://w3id.org/def/och#undeprecatedElement"></see></summary>
    let undeprecatedElement =
        Namespaced_IRI.parse _namespace_name "undeprecatedElement" |> NamespacedName
