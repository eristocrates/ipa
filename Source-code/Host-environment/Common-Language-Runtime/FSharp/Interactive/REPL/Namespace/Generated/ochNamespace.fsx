#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module och =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/def/och#" "och"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to addition of a characteristic to a property^^xsd:string</para>
    ///   <para>rdfs:label : Add Characteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddCharacteristic">och:AddCharacteristic</a>
    /// </summary>
    let AddCharacteristic = _prefixId.prefix "AddCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a class^^xsd:string</para>
    ///   <para>rdfs:label : Add Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddClass">och:AddClass</a>
    /// </summary>
    let AddClass = _prefixId.prefix "AddClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a data property^^xsd:string</para>
    ///   <para>rdfs:label : Add Data Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddDataProperty">och:AddDataProperty</a>
    /// </summary>
    let AddDataProperty = _prefixId.prefix "AddDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a Disjoint Property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Add Disjoint Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddDisjointProperty">och:AddDisjointProperty</a>
    /// </summary>
    let AddDisjointProperty = _prefixId.prefix "AddDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of the domain to a given property^^xsd:string</para>
    ///   <para>rdfs:label : Add Domain^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddDomain">och:AddDomain</a>
    /// </summary>
    let AddDomain = _prefixId.prefix "AddDomain"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of an equivalent class relation between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Add Equivalent Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddEquivalentClass">och:AddEquivalentClass</a>
    /// </summary>
    let AddEquivalentClass = _prefixId.prefix "AddEquivalentClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of an equivalent property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Add Equivalent Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddEquivalentProperty">och:AddEquivalentProperty</a>
    /// </summary>
    let AddEquivalentProperty = _prefixId.prefix "AddEquivalentProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of an individual to the ontology^^xsd:string</para>
    ///   <para>rdfs:label : Add Individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddIndividual">och:AddIndividual</a>
    /// </summary>
    let AddIndividual = _prefixId.prefix "AddIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of an inverse property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Add Inverse Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddInverseProperty">och:AddInverseProperty</a>
    /// </summary>
    let AddInverseProperty = _prefixId.prefix "AddInverseProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of an object property^^xsd:string</para>
    ///   <para>rdfs:label : Add Object Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddObjectProperty">och:AddObjectProperty</a>
    /// </summary>
    let AddObjectProperty = _prefixId.prefix "AddObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents the addition of a property to an ontology^^xsd:string</para>
    ///   <para>rdfs:label : Add Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddProperty">och:AddProperty</a>
    /// </summary>
    let AddProperty = _prefixId.prefix "AddProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of the range to a given property^^xsd:string</para>
    ///   <para>rdfs:label : Add Range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddRange">och:AddRange</a>
    /// </summary>
    let AddRange = _prefixId.prefix "AddRange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of the range of a given data property^^xsd:string</para>
    ///   <para>rdfs:label : Add Range Data Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddRangeDataProperty">och:AddRangeDataProperty</a>
    /// </summary>
    let AddRangeDataProperty = _prefixId.prefix "AddRangeDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of the range of a given object property^^xsd:string</para>
    ///   <para>rdfs:label : Add Range Object Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddRangeObjectProperty">och:AddRangeObjectProperty</a>
    /// </summary>
    let AddRangeObjectProperty = _prefixId.prefix "AddRangeObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a relation between two individuals^^xsd:string</para>
    ///   <para>rdfs:label : Add Relation to Individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddRelationToIndividual">och:AddRelationToIndividual</a>
    /// </summary>
    let AddRelationToIndividual = _prefixId.prefix "AddRelationToIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a subClass relation between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Add Sub Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddSubClass">och:AddSubClass</a>
    /// </summary>
    let AddSubClass = _prefixId.prefix "AddSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the addition of a subProperty relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Add Sub Property Of^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#AddSubPropertyOf">och:AddSubPropertyOf</a>
    /// </summary>
    let AddSubPropertyOf = _prefixId.prefix "AddSubPropertyOf"
    let AsymmetricProperty = _prefixId.prefix "AsymmetricProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class for representing sets of changes, it can be used for representing complex changes made out of atomic changes.^^xsd:string</para>
    ///   <para>rdfs:label : Change Set^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#ChangeSet">och:ChangeSet</a>
    /// </summary>
    let ChangeSet = _prefixId.prefix "ChangeSet"
    /// <summary>
    ///   <para>rdfs:comment : The set of change operations between ontology versions^^xsd:string</para>
    ///   <para>rdfs:label : Changelog^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#Changelog">och:Changelog</a>
    /// </summary>
    let Changelog = _prefixId.prefix "Changelog"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a given class within the ontology^^xsd:string</para>
    ///   <para>rdfs:label : Class Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#ClassChange">och:ClassChange</a>
    /// </summary>
    let ClassChange = _prefixId.prefix "ClassChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of the relationship between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Class Relation Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#ClassRelationChange">och:ClassRelationChange</a>
    /// </summary>
    let ClassRelationChange = _prefixId.prefix "ClassRelationChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a data property^^xsd:string</para>
    ///   <para>rdfs:label : Data Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#DataPropertyChange">och:DataPropertyChange</a>
    /// </summary>
    let DataPropertyChange = _prefixId.prefix "DataPropertyChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the deprecation of an OWL Entity^^xsd:string</para>
    ///   <para>rdfs:label : Deprecate Entity^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#DeprecateEntity">och:DeprecateEntity</a>
    /// </summary>
    let DeprecateEntity = _prefixId.prefix "DeprecateEntity"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a Disjoint Property^^xsd:string</para>
    ///   <para>rdfs:label : Disjoint Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#DisjointPropertyChange">och:DisjointPropertyChange</a>
    /// </summary>
    let DisjointPropertyChange = _prefixId.prefix "DisjointPropertyChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of the domain of a given property^^xsd:string</para>
    ///   <para>rdfs:label : Domain Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#DomainChange">och:DomainChange</a>
    /// </summary>
    let DomainChange = _prefixId.prefix "DomainChange"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents all changes to OWL Entities: classes, properties, and individuals^^xsd:string</para>
    ///   <para>rdfs:label : Entity Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#EntityChange">och:EntityChange</a>
    /// </summary>
    let EntityChange = _prefixId.prefix "EntityChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of an equivalent class relation between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Equivalent Class Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#EquivalentClassChange">och:EquivalentClassChange</a>
    /// </summary>
    let EquivalentClassChange = _prefixId.prefix "EquivalentClassChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of an equivalent property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Equivalent Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#EquivalentPropertyChange">och:EquivalentPropertyChange</a>
    /// </summary>
    let EquivalentPropertyChange = _prefixId.prefix "EquivalentPropertyChange"
    let FunctionalProperty = _prefixId.prefix "FunctionalProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a given individual within the ontology^^xsd:string</para>
    ///   <para>rdfs:label : Individual Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#IndividualChange">och:IndividualChange</a>
    /// </summary>
    let IndividualChange = _prefixId.prefix "IndividualChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a relationship between two individuals within the ontology^^xsd:string</para>
    ///   <para>rdfs:label : Individual Relation Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#IndividualRelationChange">och:IndividualRelationChange</a>
    /// </summary>
    let IndividualRelationChange = _prefixId.prefix "IndividualRelationChange"
    let InverseFunctionalProperty = _prefixId.prefix "InverseFunctionalProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of an inverse prop7 relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Inverse Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#InversePropertyChange">och:InversePropertyChange</a>
    /// </summary>
    let InversePropertyChange = _prefixId.prefix "InversePropertyChange"
    let IrreflexiveProperty = _prefixId.prefix "IrreflexiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of an object property^^xsd:string</para>
    ///   <para>rdfs:label : Object Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#ObjectPropertyChange">och:ObjectPropertyChange</a>
    /// </summary>
    let ObjectPropertyChange = _prefixId.prefix "ObjectPropertyChange"
    /// <summary>
    ///   <para>rdfs:comment : The term that describes those property characteristics that are exclusive to object properties</para>
    ///   <para>rdfs:label : Object Property Characteristic</para>
    ///   <a href="https://w3id.org/def/och#ObjectPropertyCharacteristic">och:ObjectPropertyCharacteristic</a>
    /// </summary>
    let ObjectPropertyCharacteristic = _prefixId.prefix "ObjectPropertyCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents all changes within an ontology being term-level, structural level, or higher level^^xsd:string</para>
    ///   <para>rdfs:label : Ontological Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#OntologicalChange">och:OntologicalChange</a>
    /// </summary>
    let OntologicalChange = _prefixId.prefix "OntologicalChange"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents changes to properties^^xsd:string</para>
    ///   <para>rdfs:label : Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#PropertyChange">och:PropertyChange</a>
    /// </summary>
    let PropertyChange = _prefixId.prefix "PropertyChange"
    /// <summary>
    ///   <para>rdfs:comment : The top term that encompases all characteristics</para>
    ///   <para>rdfs:label : Property Characteristic</para>
    ///   <a href="https://w3id.org/def/och#PropertyCharacteristic">och:PropertyCharacteristic</a>
    /// </summary>
    let PropertyCharacteristic = _prefixId.prefix "PropertyCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of a property characteristic.^^xsd:string</para>
    ///   <para>rdfs:label : Property Characteristic Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#PropertyCharacteristicChange">och:PropertyCharacteristicChange</a>
    /// </summary>
    let PropertyCharacteristicChange = _prefixId.prefix "PropertyCharacteristicChange"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents changes to property relations^^xsd:string</para>
    ///   <para>rdfs:label : Property Relation Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#PropertyRelationChange">och:PropertyRelationChange</a>
    /// </summary>
    let PropertyRelationChange = _prefixId.prefix "PropertyRelationChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of the range of a given property^^xsd:string</para>
    ///   <para>rdfs:label : Range Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RangeChange">och:RangeChange</a>
    /// </summary>
    let RangeChange = _prefixId.prefix "RangeChange"
    let ReflexiveProperty = _prefixId.prefix "ReflexiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of a property characteristic^^xsd:string</para>
    ///   <para>rdfs:label : Remove Characteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveCharacteristic">och:RemoveCharacteristic</a>
    /// </summary>
    let RemoveCharacteristic = _prefixId.prefix "RemoveCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of a class^^xsd:string</para>
    ///   <para>rdfs:label : Remove Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveClass">och:RemoveClass</a>
    /// </summary>
    let RemoveClass = _prefixId.prefix "RemoveClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of a data property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Data Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveDataProperty">och:RemoveDataProperty</a>
    /// </summary>
    let RemoveDataProperty = _prefixId.prefix "RemoveDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of a Disjoint Property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Remove Disjoint Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveDisjointProperty">och:RemoveDisjointProperty</a>
    /// </summary>
    let RemoveDisjointProperty = _prefixId.prefix "RemoveDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the domain of a given property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Domain^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveDomain">och:RemoveDomain</a>
    /// </summary>
    let RemoveDomain = _prefixId.prefix "RemoveDomain"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the equivalent class relation between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Remove Equivalent Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveEquivalentClass">och:RemoveEquivalentClass</a>
    /// </summary>
    let RemoveEquivalentClass = _prefixId.prefix "RemoveEquivalentClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the equivalent property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Remove Equivalent Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveEquivalentProperty">och:RemoveEquivalentProperty</a>
    /// </summary>
    let RemoveEquivalentProperty = _prefixId.prefix "RemoveEquivalentProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of an individual to the ontology^^xsd:string</para>
    ///   <para>rdfs:label : Remove Individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveIndividual">och:RemoveIndividual</a>
    /// </summary>
    let RemoveIndividual = _prefixId.prefix "RemoveIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the inverse property relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Remove Inverse Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveInverseProperty">och:RemoveInverseProperty</a>
    /// </summary>
    let RemoveInverseProperty = _prefixId.prefix "RemoveInverseProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of an object property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Object Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveObjectProperty">och:RemoveObjectProperty</a>
    /// </summary>
    let RemoveObjectProperty = _prefixId.prefix "RemoveObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents the removal of a property to an ontology^^xsd:string</para>
    ///   <para>rdfs:label : Remove Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveProperty">och:RemoveProperty</a>
    /// </summary>
    let RemoveProperty = _prefixId.prefix "RemoveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the range of a given property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveRange">och:RemoveRange</a>
    /// </summary>
    let RemoveRange = _prefixId.prefix "RemoveRange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the range of a data property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Range Data Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveRangeDataProperty">och:RemoveRangeDataProperty</a>
    /// </summary>
    let RemoveRangeDataProperty = _prefixId.prefix "RemoveRangeDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the range off an object property^^xsd:string</para>
    ///   <para>rdfs:label : Remove Range Object Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveRangeObjectProperty">och:RemoveRangeObjectProperty</a>
    /// </summary>
    let RemoveRangeObjectProperty = _prefixId.prefix "RemoveRangeObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of a relation between two individuals^^xsd:string</para>
    ///   <para>rdfs:label : Remove Relation from Individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveRelationFromIndividual">och:RemoveRelationFromIndividual</a>
    /// </summary>
    let RemoveRelationFromIndividual = _prefixId.prefix "RemoveRelationFromIndividual"
    let RemoveRelationtoIndividual = _prefixId.prefix "RemoveRelationtoIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the subClass relation between two classes^^xsd:string</para>
    ///   <para>rdfs:label : Remove Sub Class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveSubClass">och:RemoveSubClass</a>
    /// </summary>
    let RemoveSubClass = _prefixId.prefix "RemoveSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the removal of the subProperty relation between two properties^^xsd:string</para>
    ///   <para>rdfs:label : Remove Sub Property Of^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RemoveSubPropertyOf">och:RemoveSubPropertyOf</a>
    /// </summary>
    let RemoveSubPropertyOf = _prefixId.prefix "RemoveSubPropertyOf"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the renaming of an OWL Entity within an ontology, this is whenever the semantics do not change and only the URI is modified^^xsd:string</para>
    ///   <para>rdfs:label : Rename Entity^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RenameEntity">och:RenameEntity</a>
    /// </summary>
    let RenameEntity = _prefixId.prefix "RenameEntity"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the revokal of an ontological term^^xsd:string</para>
    ///   <para>rdfs:label : Revoke Deprecate^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#RevokeDeprecate">och:RevokeDeprecate</a>
    /// </summary>
    let RevokeDeprecate = _prefixId.prefix "RevokeDeprecate"
    /// <summary>
    ///   <para>rdfs:comment : The class that represents changes to a subclass relationship between two classes.^^xsd:string</para>
    ///   <para>rdfs:label : Sub Class Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#SubClassChange">och:SubClassChange</a>
    /// </summary>
    let SubClassChange = _prefixId.prefix "SubClassChange"
    /// <summary>
    ///   <para>rdfs:comment : The change operation corresponding to the change of the subProperty relation between to properties^^xsd:string</para>
    ///   <para>rdfs:label : Sub Property Change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#SubPropertyChange">och:SubPropertyChange</a>
    /// </summary>
    let SubPropertyChange = _prefixId.prefix "SubPropertyChange"
    let SymmetricProperty = _prefixId.prefix "SymmetricProperty"
    let TransitiveProperty = _prefixId.prefix "TransitiveProperty"
    /// <summary>
    ///   <para>rdfs:comment : The characteristic being added to a given property^^xsd:string</para>
    ///   <para>rdfs:label : added characteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedCharacteristic">och:addedCharacteristic</a>
    /// </summary>
    let addedCharacteristic = _prefixId.prefix "addedCharacteristic"
    /// <summary>
    ///   <para>rdfs:comment : The property a characteristic is added to^^xsd:string</para>
    ///   <para>rdfs:label : add Characteristic to property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedCharacteristicToProperty">och:addedCharacteristicToProperty</a>
    /// </summary>
    let addedCharacteristicToProperty = _prefixId.prefix "addedCharacteristicToProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class being added in an AddClass operation^^xsd:string</para>
    ///   <para>rdfs:label : added class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedClass">och:addedClass</a>
    /// </summary>
    let addedClass = _prefixId.prefix "addedClass"
    /// <summary>
    ///   <para>rdfs:comment : The data property that is being added to the ontology^^xsd:string</para>
    ///   <para>rdfs:label : added data property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedDataProperty">och:addedDataProperty</a>
    /// </summary>
    let addedDataProperty = _prefixId.prefix "addedDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The range being added to a data property^^xsd:string</para>
    ///   <para>rdfs:label : added data range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedDataRange">och:addedDataRange</a>
    /// </summary>
    let addedDataRange = _prefixId.prefix "addedDataRange"
    /// <summary>
    ///   <para>rdfs:comment : The added domain of an Add Domain change operation^^xsd:string</para>
    ///   <para>rdfs:label : added domain^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedDomain">och:addedDomain</a>
    /// </summary>
    let addedDomain = _prefixId.prefix "addedDomain"
    /// <summary>
    ///   <para>rdfs:comment : The property a domain is added to.^^xsd:string</para>
    ///   <para>rdfs:label : added Domain for Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedDomainToProperty">och:addedDomainToProperty</a>
    /// </summary>
    let addedDomainToProperty = _prefixId.prefix "addedDomainToProperty"
    /// <summary>
    ///   <para>rdfs:comment : The entity that is being added in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : added entity^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedEntity">och:addedEntity</a>
    /// </summary>
    let addedEntity = _prefixId.prefix "addedEntity"
    /// <summary>
    ///   <para>rdfs:comment : The individual being added in an AddIndividual operation^^xsd:string</para>
    ///   <para>rdfs:label : added individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedIndividual">och:addedIndividual</a>
    /// </summary>
    let addedIndividual = _prefixId.prefix "addedIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The object property being added to the ontology^^xsd:string</para>
    ///   <para>rdfs:label : added object property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedObjectProperty">och:addedObjectProperty</a>
    /// </summary>
    let addedObjectProperty = _prefixId.prefix "addedObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The range that is being added to the object property^^xsd:string</para>
    ///   <para>rdfs:label : added object range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedObjectRange">och:addedObjectRange</a>
    /// </summary>
    let addedObjectRange = _prefixId.prefix "addedObjectRange"
    /// <summary>
    ///   <para>rdfs:comment : The property being added to the ontology^^xsd:string</para>
    ///   <para>rdfs:label : added Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedProperty">och:addedProperty</a>
    /// </summary>
    let addedProperty = _prefixId.prefix "addedProperty"
    /// <summary>
    ///   <para>rdfs:comment : The property to which the change is being added.^^xsd:string</para>
    ///   <para>rdfs:label : add range for property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedRangeToProperty">och:addedRangeToProperty</a>
    /// </summary>
    let addedRangeToProperty = _prefixId.prefix "addedRangeToProperty"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is the relation being added in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : property add relation to individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#addedRelationToIndividual">och:addedRelationToIndividual</a>
    /// </summary>
    let addedRelationToIndividual = _prefixId.prefix "addedRelationToIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The OWL Entity that is being deprecated^^xsd:string</para>
    ///   <para>rdfs:label : deprecated entity^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#deprecatedEntity">och:deprecatedEntity</a>
    /// </summary>
    let deprecatedEntity = _prefixId.prefix "deprecatedEntity"
    /// <summary>
    ///   <para>rdfs:comment : The fromChangelog property indicates that a given change belongs to a Changelog^^xsd:string</para>
    ///   <para>rdfs:label : from changelog^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#fromChangelog">och:fromChangelog</a>
    /// </summary>
    let fromChangelog = _prefixId.prefix "fromChangelog"
    /// <summary>
    ///   <para>rdfs:comment : The issuedBy property indicates what Agent has issued a change.^^xsd:string</para>
    ///   <para>rdfs:label : issued by^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#issuedBy">och:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:comment : The new version the ontology is updated to.^^xsd:string</para>
    ///   <para>rdfs:label : new version^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#newVersion">och:newVersion</a>
    /// </summary>
    let newVersion = _prefixId.prefix "newVersion"
    /// <summary>
    ///   <para>rdfs:comment : The former name of the OWL Entity that has been renamed^^xsd:string</para>
    ///   <para>rdfs:label : outdated entity name^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#outdatedEntityName">och:outdatedEntityName</a>
    /// </summary>
    let outdatedEntityName = _prefixId.prefix "outdatedEntityName"
    /// <summary>
    ///   <para>rdfs:comment : The former version of the ontology that is being outdated^^xsd:string</para>
    ///   <para>rdfs:label : previous version^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#prevVersion">och:prevVersion</a>
    /// </summary>
    let prevVersion = _prefixId.prefix "prevVersion"
    /// <summary>
    ///   <para>rdfs:comment : The property that indicates an unspecified relation between two Ontology Changes^^xsd:string</para>
    ///   <para>rdfs:label : related change^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#relatedChange">och:relatedChange</a>
    /// </summary>
    let relatedChange = _prefixId.prefix "relatedChange"
    /// <summary>
    ///   <para>rdfs:comment : The characteristic that is being removed from a property^^xsd:string</para>
    ///   <para>rdfs:label : removed characteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedCharacteristic">och:removedCharacteristic</a>
    /// </summary>
    let removedCharacteristic = _prefixId.prefix "removedCharacteristic"

    /// <summary>
    ///   <para>rdfs:comment : The property a characteristicic is removed from^^xsd:string</para>
    ///   <para>rdfs:label : property RemoveCharacteristic^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedCharacteristicFromProperty">och:removedCharacteristicFromProperty</a>
    /// </summary>
    let removedCharacteristicFromProperty =
        _prefixId.prefix "removedCharacteristicFromProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class that is being removed in an ontology^^xsd:string</para>
    ///   <para>rdfs:label : removed class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedClass">och:removedClass</a>
    /// </summary>
    let removedClass = _prefixId.prefix "removedClass"
    /// <summary>
    ///   <para>rdfs:comment : The data property that is being removed in an ontology^^xsd:string</para>
    ///   <para>rdfs:label : removed data property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedDataProperty">och:removedDataProperty</a>
    /// </summary>
    let removedDataProperty = _prefixId.prefix "removedDataProperty"
    /// <summary>
    ///   <para>rdfs:comment : The range that is being removed from a Datatype Property^^xsd:string</para>
    ///   <para>rdfs:label : removed data range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedDataRange">och:removedDataRange</a>
    /// </summary>
    let removedDataRange = _prefixId.prefix "removedDataRange"
    /// <summary>
    ///   <para>rdfs:comment : The domain that is being removed from a property^^xsd:string</para>
    ///   <para>rdfs:label : removed domain^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedDomain">och:removedDomain</a>
    /// </summary>
    let removedDomain = _prefixId.prefix "removedDomain"
    /// <summary>
    ///   <para>rdfs:comment : The property a domain is removed from^^xsd:string</para>
    ///   <para>rdfs:label : removed Domain for Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedDomainFromProperty">och:removedDomainFromProperty</a>
    /// </summary>
    let removedDomainFromProperty = _prefixId.prefix "removedDomainFromProperty"
    /// <summary>
    ///   <para>rdfs:comment : The entity that is being removed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : removed entity^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedEntity">och:removedEntity</a>
    /// </summary>
    let removedEntity = _prefixId.prefix "removedEntity"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is being removed in an ontology^^xsd:string</para>
    ///   <para>rdfs:label : removed individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedIndividual">och:removedIndividual</a>
    /// </summary>
    let removedIndividual = _prefixId.prefix "removedIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The object property being removed from an ontology^^xsd:string</para>
    ///   <para>rdfs:label : removed object property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedObjectProperty">och:removedObjectProperty</a>
    /// </summary>
    let removedObjectProperty = _prefixId.prefix "removedObjectProperty"
    /// <summary>
    ///   <para>rdfs:comment : The range being removed from an object property^^xsd:string</para>
    ///   <para>rdfs:label : removed object range^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedObjectRange">och:removedObjectRange</a>
    /// </summary>
    let removedObjectRange = _prefixId.prefix "removedObjectRange"
    /// <summary>
    ///   <para>rdfs:comment : The property being removed from the ontology^^xsd:string</para>
    ///   <para>rdfs:label : removed Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedProperty">och:removedProperty</a>
    /// </summary>
    let removedProperty = _prefixId.prefix "removedProperty"
    /// <summary>
    ///   <para>rdfs:comment : The removed range for a property^^xsd:string</para>
    ///   <para>rdfs:label : removed range for property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedRangeFromProperty">och:removedRangeFromProperty</a>
    /// </summary>
    let removedRangeFromProperty = _prefixId.prefix "removedRangeFromProperty"
    /// <summary>
    ///   <para>rdfs:comment : The relation being removed from an individual in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : removed relation from individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#removedRelationFromIndividual">och:removedRelationFromIndividual</a>
    /// </summary>
    let removedRelationFromIndividual = _prefixId.prefix "removedRelationFromIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The new name the OWL Entity is being renamed to^^xsd:string</para>
    ///   <para>rdfs:label : renamed entity name^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#renamedEntityName">och:renamedEntityName</a>
    /// </summary>
    let renamedEntityName = _prefixId.prefix "renamedEntityName"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the disjoint property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddDisjointProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddDisjointProperty">och:sourceAddDisjointProperty</a>
    /// </summary>
    let sourceAddDisjointProperty = _prefixId.prefix "sourceAddDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the equivalent class relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddEquivalentClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddEquivalentClass">och:sourceAddEquivalentClass</a>
    /// </summary>
    let sourceAddEquivalentClass = _prefixId.prefix "sourceAddEquivalentClass"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the equivalent property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddEquivalentProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddEquivalentProperty">och:sourceAddEquivalentProperty</a>
    /// </summary>
    let sourceAddEquivalentProperty = _prefixId.prefix "sourceAddEquivalentProperty"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the inverse property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddInverseProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddInverseProperty">och:sourceAddInverseProperty</a>
    /// </summary>
    let sourceAddInverseProperty = _prefixId.prefix "sourceAddInverseProperty"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is the subject of the relation being added in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : source add relation to individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddRelationToIndividual">och:sourceAddRelationToIndividual</a>
    /// </summary>
    let sourceAddRelationToIndividual = _prefixId.prefix "sourceAddRelationToIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the subClass relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddSubClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddSubClass">och:sourceAddSubClass</a>
    /// </summary>
    let sourceAddSubClass = _prefixId.prefix "sourceAddSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the subProperty relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source AddSubProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceAddSubProperty">och:sourceAddSubProperty</a>
    /// </summary>
    let sourceAddSubProperty = _prefixId.prefix "sourceAddSubProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class that is the subject of the class relations being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : source class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceClass">och:sourceClass</a>
    /// </summary>
    let sourceClass = _prefixId.prefix "sourceClass"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is the subject of the relation being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : source individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceIndividual">och:sourceIndividual</a>
    /// </summary>
    let sourceIndividual = _prefixId.prefix "sourceIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The property that is the subject of the property relations being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : source property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceProperty">och:sourceProperty</a>
    /// </summary>
    let sourceProperty = _prefixId.prefix "sourceProperty"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the disjoint property relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveDisjointProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveDisjointProperty">och:sourceRemoveDisjointProperty</a>
    /// </summary>
    let sourceRemoveDisjointProperty = _prefixId.prefix "sourceRemoveDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the equivalent class relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveEquivalentClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveEquivalentClass">och:sourceRemoveEquivalentClass</a>
    /// </summary>
    let sourceRemoveEquivalentClass = _prefixId.prefix "sourceRemoveEquivalentClass"

    /// <summary>
    ///   <para>rdfs:comment : The subject of the equivalent property relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveEquivalentProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveEquivalentProperty">och:sourceRemoveEquivalentProperty</a>
    /// </summary>
    let sourceRemoveEquivalentProperty =
        _prefixId.prefix "sourceRemoveEquivalentProperty"

    /// <summary>
    ///   <para>rdfs:comment : The subject of the inverse property relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveInverseProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveInverseProperty">och:sourceRemoveInverseProperty</a>
    /// </summary>
    let sourceRemoveInverseProperty = _prefixId.prefix "sourceRemoveInverseProperty"

    /// <summary>
    ///   <para>rdfs:comment : The individual that is the subject of the relation being removed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : source remove relation to individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveRelationToIndividual">och:sourceRemoveRelationToIndividual</a>
    /// </summary>
    let sourceRemoveRelationToIndividual =
        _prefixId.prefix "sourceRemoveRelationToIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The subject of the disjoint property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveSubClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveSubClass">och:sourceRemoveSubClass</a>
    /// </summary>
    let sourceRemoveSubClass = _prefixId.prefix "sourceRemoveSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The subject of the subProperty relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : source RemoveSubProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#sourceRemoveSubProperty">och:sourceRemoveSubProperty</a>
    /// </summary>
    let sourceRemoveSubProperty = _prefixId.prefix "sourceRemoveSubProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object of the disjoint property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddDisjointProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddDisjointProperty">och:targetAddDisjointProperty</a>
    /// </summary>
    let targetAddDisjointProperty = _prefixId.prefix "targetAddDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object of the equivalent class relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddEquivalentClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddEquivalentClass">och:targetAddEquivalentClass</a>
    /// </summary>
    let targetAddEquivalentClass = _prefixId.prefix "targetAddEquivalentClass"
    /// <summary>
    ///   <para>rdfs:comment : The object of the equivalent property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddEquivalentProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddEquivalentProperty">och:targetAddEquivalentProperty</a>
    /// </summary>
    let targetAddEquivalentProperty = _prefixId.prefix "targetAddEquivalentProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object of the inverse property relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddInverseProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddInverseProperty">och:targetAddInverseProperty</a>
    /// </summary>
    let targetAddInverseProperty = _prefixId.prefix "targetAddInverseProperty"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is the object of the relation being added in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : target add relation to individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddRelationToIndividual">och:targetAddRelationToIndividual</a>
    /// </summary>
    let targetAddRelationToIndividual = _prefixId.prefix "targetAddRelationToIndividual"
    /// <summary>
    ///   <para>rdfs:comment : The object of the subClass relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddSubClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddSubClass">och:targetAddSubClass</a>
    /// </summary>
    let targetAddSubClass = _prefixId.prefix "targetAddSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The object of the subProperty relation being added^^xsd:string</para>
    ///   <para>rdfs:label : target AddSubProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetAddSubProperty">och:targetAddSubProperty</a>
    /// </summary>
    let targetAddSubProperty = _prefixId.prefix "targetAddSubProperty"
    /// <summary>
    ///   <para>rdfs:comment : The class that is the object of the class relations being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : target class^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetClass">och:targetClass</a>
    /// </summary>
    let targetClass = _prefixId.prefix "targetClass"
    /// <summary>
    ///   <para>rdfs:comment : The property that is the object of the property relations being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : target Property^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetProperty">och:targetProperty</a>
    /// </summary>
    let targetProperty = _prefixId.prefix "targetProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object of the disjoint property relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemoveDisjointProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveDisjointProperty">och:targetRemoveDisjointProperty</a>
    /// </summary>
    let targetRemoveDisjointProperty = _prefixId.prefix "targetRemoveDisjointProperty"
    /// <summary>
    ///   <para>rdfs:comment : The object of the equivalent class relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemoveEquivalentClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveEquivalentClass">och:targetRemoveEquivalentClass</a>
    /// </summary>
    let targetRemoveEquivalentClass = _prefixId.prefix "targetRemoveEquivalentClass"

    /// <summary>
    ///   <para>rdfs:comment : The object of the equivalent class relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemoveEquivalentProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveEquivalentProperty">och:targetRemoveEquivalentProperty</a>
    /// </summary>
    let targetRemoveEquivalentProperty =
        _prefixId.prefix "targetRemoveEquivalentProperty"

    /// <summary>
    ///   <para>rdfs:comment : The object of the inverse property relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemoveInverseProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveInverseProperty">och:targetRemoveInverseProperty</a>
    /// </summary>
    let targetRemoveInverseProperty = _prefixId.prefix "targetRemoveInverseProperty"

    /// <summary>
    ///   <para>rdfs:comment : The individual that is the object of the relation being removed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : target remove relation to individuals^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveRelationToIndividual">och:targetRemoveRelationToIndividual</a>
    /// </summary>
    let targetRemoveRelationToIndividual =
        _prefixId.prefix "targetRemoveRelationToIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The object of the subClass relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemovesubClass^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveSubClass">och:targetRemoveSubClass</a>
    /// </summary>
    let targetRemoveSubClass = _prefixId.prefix "targetRemoveSubClass"
    /// <summary>
    ///   <para>rdfs:comment : The object of the subProperty relation being removed^^xsd:string</para>
    ///   <para>rdfs:label : target RemoveSubProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetRemoveSubProperty">och:targetRemoveSubProperty</a>
    /// </summary>
    let targetRemoveSubProperty = _prefixId.prefix "targetRemoveSubProperty"
    /// <summary>
    ///   <para>rdfs:comment : The individual that is the object of the relation being changed in a change operation^^xsd:string</para>
    ///   <para>rdfs:label : target individual^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#targetResource">och:targetResource</a>
    /// </summary>
    let targetResource = _prefixId.prefix "targetResource"
    /// <summary>
    ///   <para>rdfs:comment : The ontological term that is being undeprecated^^xsd:string</para>
    ///   <para>rdfs:label : undeprecated element^^xsd:string</para>
    ///   <a href="https://w3id.org/def/och#undeprecatedElement">och:undeprecatedElement</a>
    /// </summary>
    let undeprecatedElement = _prefixId.prefix "undeprecatedElement"
