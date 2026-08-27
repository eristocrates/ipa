namespace https.w3id.org.def.och.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3och =
    let _namespace_iri = Namespace_Iri w3och |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:def/och#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/def/och#">https://w3id.org/def/och#</seealso>
    let _prefix_iri = Prefixed_Name(w3och, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to addition of a characteristic to a property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddCharacteristic">https://w3id.org/def/och#AddCharacteristic</seealso>
    let AddCharacteristic = Prefixed_Name(w3och, "AddCharacteristic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddClass">https://w3id.org/def/och#AddClass</seealso>
    let AddClass = Prefixed_Name(w3och, "AddClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Data Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddDataProperty">https://w3id.org/def/och#AddDataProperty</seealso>
    let AddDataProperty = Prefixed_Name(w3och, "AddDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a Disjoint Property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Disjoint Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddDisjointProperty">https://w3id.org/def/och#AddDisjointProperty</seealso>
    let AddDisjointProperty =
        Prefixed_Name(w3och, "AddDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of the domain to a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddDomain">https://w3id.org/def/och#AddDomain</seealso>
    let AddDomain = Prefixed_Name(w3och, "AddDomain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of an equivalent class relation between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Equivalent Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddEquivalentClass">https://w3id.org/def/och#AddEquivalentClass</seealso>
    let AddEquivalentClass = Prefixed_Name(w3och, "AddEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of an equivalent property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Equivalent Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddEquivalentProperty">https://w3id.org/def/och#AddEquivalentProperty</seealso>
    let AddEquivalentProperty =
        Prefixed_Name(w3och, "AddEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of an individual to the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddIndividual">https://w3id.org/def/och#AddIndividual</seealso>
    let AddIndividual = Prefixed_Name(w3och, "AddIndividual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of an inverse property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Inverse Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddInverseProperty">https://w3id.org/def/och#AddInverseProperty</seealso>
    let AddInverseProperty = Prefixed_Name(w3och, "AddInverseProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of an object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Object Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddObjectProperty">https://w3id.org/def/och#AddObjectProperty</seealso>
    let AddObjectProperty = Prefixed_Name(w3och, "AddObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents the addition of a property to an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddProperty">https://w3id.org/def/och#AddProperty</seealso>
    let AddProperty = Prefixed_Name(w3och, "AddProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of the range to a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddRange">https://w3id.org/def/och#AddRange</seealso>
    let AddRange = Prefixed_Name(w3och, "AddRange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddRangeDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of the range of a given data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Range Data Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddRangeDataProperty">https://w3id.org/def/och#AddRangeDataProperty</seealso>
    let AddRangeDataProperty =
        Prefixed_Name(w3och, "AddRangeDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddRangeObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of the range of a given object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Range Object Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddRangeObjectProperty">https://w3id.org/def/och#AddRangeObjectProperty</seealso>
    let AddRangeObjectProperty =
        Prefixed_Name(w3och, "AddRangeObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a relation between two individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Relation to Individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddRelationToIndividual">https://w3id.org/def/och#AddRelationToIndividual</seealso>
    let AddRelationToIndividual =
        Prefixed_Name(w3och, "AddRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#AddSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a subClass relation between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Sub Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddSubClass">https://w3id.org/def/och#AddSubClass</seealso>
    let AddSubClass = Prefixed_Name(w3och, "AddSubClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AddSubPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the addition of a subProperty relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Add Sub Property Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AddSubPropertyOf">https://w3id.org/def/och#AddSubPropertyOf</seealso>
    let AddSubPropertyOf = Prefixed_Name(w3och, "AddSubPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#AsymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes asymmetric properties."</para>
    /// labels<para>"Asymmetric Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#AsymmetricProperty">https://w3id.org/def/och#AsymmetricProperty</seealso>
    let AsymmetricProperty = Prefixed_Name(w3och, "AsymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#ChangeSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class for representing sets of changes, it can be used for representing complex changes made out of atomic changes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Change Set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ChangeSet">https://w3id.org/def/och#ChangeSet</seealso>
    let ChangeSet = Prefixed_Name(w3och, "ChangeSet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#Changelog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of change operations between ontology versions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Changelog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#Changelog">https://w3id.org/def/och#Changelog</seealso>
    let Changelog = Prefixed_Name(w3och, "Changelog") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#ClassChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a given class within the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ClassChange">https://w3id.org/def/och#ClassChange</seealso>
    let ClassChange = Prefixed_Name(w3och, "ClassChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#ClassRelationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of the relationship between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class Relation Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ClassRelationChange">https://w3id.org/def/och#ClassRelationChange</seealso>
    let ClassRelationChange =
        Prefixed_Name(w3och, "ClassRelationChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#DataPropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#DataPropertyChange">https://w3id.org/def/och#DataPropertyChange</seealso>
    let DataPropertyChange = Prefixed_Name(w3och, "DataPropertyChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#DeprecateEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the deprecation of an OWL Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deprecate Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#DeprecateEntity">https://w3id.org/def/och#DeprecateEntity</seealso>
    let DeprecateEntity = Prefixed_Name(w3och, "DeprecateEntity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#DisjointPropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a Disjoint Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Disjoint Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#DisjointPropertyChange">https://w3id.org/def/och#DisjointPropertyChange</seealso>
    let DisjointPropertyChange =
        Prefixed_Name(w3och, "DisjointPropertyChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#DomainChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of the domain of a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Domain Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#DomainChange">https://w3id.org/def/och#DomainChange</seealso>
    let DomainChange = Prefixed_Name(w3och, "DomainChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#EntityChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents all changes to OWL Entities: classes, properties, and individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Entity Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#EntityChange">https://w3id.org/def/och#EntityChange</seealso>
    let EntityChange = Prefixed_Name(w3och, "EntityChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#EquivalentClassChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of an equivalent class relation between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equivalent Class Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#EquivalentClassChange">https://w3id.org/def/och#EquivalentClassChange</seealso>
    let EquivalentClassChange =
        Prefixed_Name(w3och, "EquivalentClassChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#EquivalentPropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of an equivalent property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equivalent Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#EquivalentPropertyChange">https://w3id.org/def/och#EquivalentPropertyChange</seealso>
    let EquivalentPropertyChange =
        Prefixed_Name(w3och, "EquivalentPropertyChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#FunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#PropertyCharacteristic</para>
    ///   <para>"The term that describes Functional Properties."</para>
    /// labels<para>"Functional Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#FunctionalProperty">https://w3id.org/def/och#FunctionalProperty</seealso>
    let FunctionalProperty = Prefixed_Name(w3och, "FunctionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#IndividualChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a given individual within the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Individual Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#IndividualChange">https://w3id.org/def/och#IndividualChange</seealso>
    let IndividualChange = Prefixed_Name(w3och, "IndividualChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#IndividualRelationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a relationship between two individuals within the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Individual Relation Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#IndividualRelationChange">https://w3id.org/def/och#IndividualRelationChange</seealso>
    let IndividualRelationChange =
        Prefixed_Name(w3och, "IndividualRelationChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes the inverse functional properties."</para>
    /// labels<para>"Inverse Functional Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#InverseFunctionalProperty">https://w3id.org/def/och#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(w3och, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#InversePropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of an inverse prop7 relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inverse Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#InversePropertyChange">https://w3id.org/def/och#InversePropertyChange</seealso>
    let InversePropertyChange =
        Prefixed_Name(w3och, "InversePropertyChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#IrreflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes irreflexive properties."</para>
    /// labels<para>"Irreflexive Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#IrreflexiveProperty">https://w3id.org/def/och#IrreflexiveProperty</seealso>
    let IrreflexiveProperty =
        Prefixed_Name(w3och, "IrreflexiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#ObjectPropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of an object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Object Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ObjectPropertyChange">https://w3id.org/def/och#ObjectPropertyChange</seealso>
    let ObjectPropertyChange =
        Prefixed_Name(w3och, "ObjectPropertyChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The term that describes those property characteristics that are exclusive to object properties"</para>
    /// labels<para>"Object Property Characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ObjectPropertyCharacteristic">https://w3id.org/def/och#ObjectPropertyCharacteristic</seealso>
    let ObjectPropertyCharacteristic =
        Prefixed_Name(w3och, "ObjectPropertyCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#OntologicalChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents all changes within an ontology being term-level, structural level, or higher level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ontological Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#OntologicalChange">https://w3id.org/def/och#OntologicalChange</seealso>
    let OntologicalChange = Prefixed_Name(w3och, "OntologicalChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#PropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents changes to properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#PropertyChange">https://w3id.org/def/och#PropertyChange</seealso>
    let PropertyChange = Prefixed_Name(w3och, "PropertyChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#PropertyCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The top term that encompases all characteristics"</para>
    /// labels<para>"Property Characteristic"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#PropertyCharacteristic">https://w3id.org/def/och#PropertyCharacteristic</seealso>
    let PropertyCharacteristic =
        Prefixed_Name(w3och, "PropertyCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#PropertyCharacteristicChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of a property characteristic."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Characteristic Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#PropertyCharacteristicChange">https://w3id.org/def/och#PropertyCharacteristicChange</seealso>
    let PropertyCharacteristicChange =
        Prefixed_Name(w3och, "PropertyCharacteristicChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#PropertyRelationChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents changes to property relations"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property Relation Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#PropertyRelationChange">https://w3id.org/def/och#PropertyRelationChange</seealso>
    let PropertyRelationChange =
        Prefixed_Name(w3och, "PropertyRelationChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RangeChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of the range of a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Range Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RangeChange">https://w3id.org/def/och#RangeChange</seealso>
    let RangeChange = Prefixed_Name(w3och, "RangeChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#ReflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes reflexive properties."</para>
    /// labels<para>"Reflexive Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#ReflexiveProperty">https://w3id.org/def/och#ReflexiveProperty</seealso>
    let ReflexiveProperty = Prefixed_Name(w3och, "ReflexiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of a property characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveCharacteristic">https://w3id.org/def/och#RemoveCharacteristic</seealso>
    let RemoveCharacteristic =
        Prefixed_Name(w3och, "RemoveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of a class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveClass">https://w3id.org/def/och#RemoveClass</seealso>
    let RemoveClass = Prefixed_Name(w3och, "RemoveClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#RemoveDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of a data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Data Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveDataProperty">https://w3id.org/def/och#RemoveDataProperty</seealso>
    let RemoveDataProperty = Prefixed_Name(w3och, "RemoveDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of a Disjoint Property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Disjoint Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveDisjointProperty">https://w3id.org/def/och#RemoveDisjointProperty</seealso>
    let RemoveDisjointProperty =
        Prefixed_Name(w3och, "RemoveDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the domain of a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveDomain">https://w3id.org/def/och#RemoveDomain</seealso>
    let RemoveDomain = Prefixed_Name(w3och, "RemoveDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the equivalent class relation between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Equivalent Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveEquivalentClass">https://w3id.org/def/och#RemoveEquivalentClass</seealso>
    let RemoveEquivalentClass =
        Prefixed_Name(w3och, "RemoveEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the equivalent property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Equivalent Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveEquivalentProperty">https://w3id.org/def/och#RemoveEquivalentProperty</seealso>
    let RemoveEquivalentProperty =
        Prefixed_Name(w3och, "RemoveEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of an individual to the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveIndividual">https://w3id.org/def/och#RemoveIndividual</seealso>
    let RemoveIndividual = Prefixed_Name(w3och, "RemoveIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the inverse property relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Inverse Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveInverseProperty">https://w3id.org/def/och#RemoveInverseProperty</seealso>
    let RemoveInverseProperty =
        Prefixed_Name(w3och, "RemoveInverseProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of an object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Object Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveObjectProperty">https://w3id.org/def/och#RemoveObjectProperty</seealso>
    let RemoveObjectProperty =
        Prefixed_Name(w3och, "RemoveObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents the removal of a property to an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveProperty">https://w3id.org/def/och#RemoveProperty</seealso>
    let RemoveProperty = Prefixed_Name(w3och, "RemoveProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#RemoveRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the range of a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveRange">https://w3id.org/def/och#RemoveRange</seealso>
    let RemoveRange = Prefixed_Name(w3och, "RemoveRange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveRangeDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the range of a data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Range Data Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveRangeDataProperty">https://w3id.org/def/och#RemoveRangeDataProperty</seealso>
    let RemoveRangeDataProperty =
        Prefixed_Name(w3och, "RemoveRangeDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveRangeObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the range off an object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Range Object Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveRangeObjectProperty">https://w3id.org/def/och#RemoveRangeObjectProperty</seealso>
    let RemoveRangeObjectProperty =
        Prefixed_Name(w3och, "RemoveRangeObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveRelationFromIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of a relation between two individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Relation from Individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveRelationFromIndividual">https://w3id.org/def/och#RemoveRelationFromIndividual</seealso>
    let RemoveRelationFromIndividual =
        Prefixed_Name(w3och, "RemoveRelationFromIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveRelationtoIndividual</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveRelationtoIndividual">https://w3id.org/def/och#RemoveRelationtoIndividual</seealso>
    let RemoveRelationtoIndividual =
        Prefixed_Name(w3och, "RemoveRelationtoIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the subClass relation between two classes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Sub Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveSubClass">https://w3id.org/def/och#RemoveSubClass</seealso>
    let RemoveSubClass = Prefixed_Name(w3och, "RemoveSubClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RemoveSubPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the removal of the subProperty relation between two properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Remove Sub Property Of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RemoveSubPropertyOf">https://w3id.org/def/och#RemoveSubPropertyOf</seealso>
    let RemoveSubPropertyOf =
        Prefixed_Name(w3och, "RemoveSubPropertyOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#RenameEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the renaming of an OWL Entity within an ontology, this is whenever the semantics do not change and only the URI is modified"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rename Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RenameEntity">https://w3id.org/def/och#RenameEntity</seealso>
    let RenameEntity = Prefixed_Name(w3och, "RenameEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#RevokeDeprecate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the revokal of an ontological term"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Revoke Deprecate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#RevokeDeprecate">https://w3id.org/def/och#RevokeDeprecate</seealso>
    let RevokeDeprecate = Prefixed_Name(w3och, "RevokeDeprecate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#SubClassChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class that represents changes to a subclass relationship between two classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub Class Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#SubClassChange">https://w3id.org/def/och#SubClassChange</seealso>
    let SubClassChange = Prefixed_Name(w3och, "SubClassChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#SubPropertyChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change operation corresponding to the change of the subProperty relation between to properties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sub Property Change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#SubPropertyChange">https://w3id.org/def/och#SubPropertyChange</seealso>
    let SubPropertyChange = Prefixed_Name(w3och, "SubPropertyChange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes symmetric properties."</para>
    /// labels<para>"Symmetric Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#SymmetricProperty">https://w3id.org/def/och#SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(w3och, "SymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:def/och#ObjectPropertyCharacteristic</para>
    ///   <para>"The term that describes transitive properties."</para>
    /// labels<para>"Transitive Property"</para></remarks>
    /// <seealso href="https://w3id.org/def/och#TransitiveProperty">https://w3id.org/def/och#TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(w3och, "TransitiveProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The characteristic being added to a given property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedCharacteristic">https://w3id.org/def/och#addedCharacteristic</seealso>
    let addedCharacteristic =
        Prefixed_Name(w3och, "addedCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedCharacteristicToProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property a characteristic is added to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"add Characteristic to property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedCharacteristicToProperty">https://w3id.org/def/och#addedCharacteristicToProperty</seealso>
    let addedCharacteristicToProperty =
        Prefixed_Name(w3och, "addedCharacteristicToProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The class being added in an AddClass operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedClass">https://w3id.org/def/och#addedClass</seealso>
    let addedClass = Prefixed_Name(w3och, "addedClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#addedDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The data property that is being added to the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedDataProperty">https://w3id.org/def/och#addedDataProperty</seealso>
    let addedDataProperty = Prefixed_Name(w3och, "addedDataProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#addedDataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The range being added to a data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added data range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedDataRange">https://w3id.org/def/och#addedDataRange</seealso>
    let addedDataRange = Prefixed_Name(w3och, "addedDataRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#addedDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The added domain of an Add Domain change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedDomain">https://w3id.org/def/och#addedDomain</seealso>
    let addedDomain = Prefixed_Name(w3och, "addedDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedDomainToProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property a domain is added to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added Domain for Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedDomainToProperty">https://w3id.org/def/och#addedDomainToProperty</seealso>
    let addedDomainToProperty =
        Prefixed_Name(w3och, "addedDomainToProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The entity that is being added in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedEntity">https://w3id.org/def/och#addedEntity</seealso>
    let addedEntity = Prefixed_Name(w3och, "addedEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#addedIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual being added in an AddIndividual operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedIndividual">https://w3id.org/def/och#addedIndividual</seealso>
    let addedIndividual = Prefixed_Name(w3och, "addedIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property being added to the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedObjectProperty">https://w3id.org/def/och#addedObjectProperty</seealso>
    let addedObjectProperty =
        Prefixed_Name(w3och, "addedObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedObjectRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The range that is being added to the object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added object range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedObjectRange">https://w3id.org/def/och#addedObjectRange</seealso>
    let addedObjectRange = Prefixed_Name(w3och, "addedObjectRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#addedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property being added to the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"added Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedProperty">https://w3id.org/def/och#addedProperty</seealso>
    let addedProperty = Prefixed_Name(w3och, "addedProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedRangeToProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property to which the change is being added."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"add range for property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedRangeToProperty">https://w3id.org/def/och#addedRangeToProperty</seealso>
    let addedRangeToProperty =
        Prefixed_Name(w3och, "addedRangeToProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#addedRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the relation being added in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property add relation to individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#addedRelationToIndividual">https://w3id.org/def/och#addedRelationToIndividual</seealso>
    let addedRelationToIndividual =
        Prefixed_Name(w3och, "addedRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#deprecatedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The OWL Entity that is being deprecated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deprecated entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#deprecatedEntity">https://w3id.org/def/och#deprecatedEntity</seealso>
    let deprecatedEntity = Prefixed_Name(w3och, "deprecatedEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#fromChangelog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The fromChangelog property indicates that a given change belongs to a Changelog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"from changelog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#fromChangelog">https://w3id.org/def/och#fromChangelog</seealso>
    let fromChangelog = Prefixed_Name(w3och, "fromChangelog") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The issuedBy property indicates what Agent has issued a change."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"issued by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#issuedBy">https://w3id.org/def/och#issuedBy</seealso>
    let issuedBy = Prefixed_Name(w3och, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#newVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The new version the ontology is updated to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"new version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#newVersion">https://w3id.org/def/och#newVersion</seealso>
    let newVersion = Prefixed_Name(w3och, "newVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#outdatedEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The former name of the OWL Entity that has been renamed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"outdated entity name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#outdatedEntityName">https://w3id.org/def/och#outdatedEntityName</seealso>
    let outdatedEntityName = Prefixed_Name(w3och, "outdatedEntityName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#prevVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The former version of the ontology that is being outdated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"previous version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#prevVersion">https://w3id.org/def/och#prevVersion</seealso>
    let prevVersion = Prefixed_Name(w3och, "prevVersion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#relatedChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property that indicates an unspecified relation between two Ontology Changes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"related change"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#relatedChange">https://w3id.org/def/och#relatedChange</seealso>
    let relatedChange = Prefixed_Name(w3och, "relatedChange") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The characteristic that is being removed from a property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedCharacteristic">https://w3id.org/def/och#removedCharacteristic</seealso>
    let removedCharacteristic =
        Prefixed_Name(w3och, "removedCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedCharacteristicFromProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property a characteristicic is removed from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"property RemoveCharacteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedCharacteristicFromProperty">https://w3id.org/def/och#removedCharacteristicFromProperty</seealso>
    let removedCharacteristicFromProperty =
        Prefixed_Name(w3och, "removedCharacteristicFromProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The class that is being removed in an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedClass">https://w3id.org/def/och#removedClass</seealso>
    let removedClass = Prefixed_Name(w3och, "removedClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The data property that is being removed in an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed data property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedDataProperty">https://w3id.org/def/och#removedDataProperty</seealso>
    let removedDataProperty =
        Prefixed_Name(w3och, "removedDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedDataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The range that is being removed from a Datatype Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed data range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedDataRange">https://w3id.org/def/och#removedDataRange</seealso>
    let removedDataRange = Prefixed_Name(w3och, "removedDataRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#removedDomain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The domain that is being removed from a property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedDomain">https://w3id.org/def/och#removedDomain</seealso>
    let removedDomain = Prefixed_Name(w3och, "removedDomain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedDomainFromProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property a domain is removed from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed Domain for Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedDomainFromProperty">https://w3id.org/def/och#removedDomainFromProperty</seealso>
    let removedDomainFromProperty =
        Prefixed_Name(w3och, "removedDomainFromProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The entity that is being removed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedEntity">https://w3id.org/def/och#removedEntity</seealso>
    let removedEntity = Prefixed_Name(w3och, "removedEntity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#removedIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is being removed in an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedIndividual">https://w3id.org/def/och#removedIndividual</seealso>
    let removedIndividual = Prefixed_Name(w3och, "removedIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property being removed from an ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedObjectProperty">https://w3id.org/def/och#removedObjectProperty</seealso>
    let removedObjectProperty =
        Prefixed_Name(w3och, "removedObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedObjectRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The range being removed from an object property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed object range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedObjectRange">https://w3id.org/def/och#removedObjectRange</seealso>
    let removedObjectRange = Prefixed_Name(w3och, "removedObjectRange") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#removedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property being removed from the ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedProperty">https://w3id.org/def/och#removedProperty</seealso>
    let removedProperty = Prefixed_Name(w3och, "removedProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedRangeFromProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The removed range for a property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed range for property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedRangeFromProperty">https://w3id.org/def/och#removedRangeFromProperty</seealso>
    let removedRangeFromProperty =
        Prefixed_Name(w3och, "removedRangeFromProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#removedRelationFromIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation being removed from an individual in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"removed relation from individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#removedRelationFromIndividual">https://w3id.org/def/och#removedRelationFromIndividual</seealso>
    let removedRelationFromIndividual =
        Prefixed_Name(w3och, "removedRelationFromIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#renamedEntityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The new name the OWL Entity is being renamed to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"renamed entity name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#renamedEntityName">https://w3id.org/def/och#renamedEntityName</seealso>
    let renamedEntityName = Prefixed_Name(w3och, "renamedEntityName") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the disjoint property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddDisjointProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddDisjointProperty">https://w3id.org/def/och#sourceAddDisjointProperty</seealso>
    let sourceAddDisjointProperty =
        Prefixed_Name(w3och, "sourceAddDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the equivalent class relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddEquivalentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddEquivalentClass">https://w3id.org/def/och#sourceAddEquivalentClass</seealso>
    let sourceAddEquivalentClass =
        Prefixed_Name(w3och, "sourceAddEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the equivalent property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddEquivalentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddEquivalentProperty">https://w3id.org/def/och#sourceAddEquivalentProperty</seealso>
    let sourceAddEquivalentProperty =
        Prefixed_Name(w3och, "sourceAddEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the inverse property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddInverseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddInverseProperty">https://w3id.org/def/och#sourceAddInverseProperty</seealso>
    let sourceAddInverseProperty =
        Prefixed_Name(w3och, "sourceAddInverseProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the subject of the relation being added in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source add relation to individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddRelationToIndividual">https://w3id.org/def/och#sourceAddRelationToIndividual</seealso>
    let sourceAddRelationToIndividual =
        Prefixed_Name(w3och, "sourceAddRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the subClass relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddSubClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddSubClass">https://w3id.org/def/och#sourceAddSubClass</seealso>
    let sourceAddSubClass = Prefixed_Name(w3och, "sourceAddSubClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceAddSubProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the subProperty relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source AddSubProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceAddSubProperty">https://w3id.org/def/och#sourceAddSubProperty</seealso>
    let sourceAddSubProperty =
        Prefixed_Name(w3och, "sourceAddSubProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The class that is the subject of the class relations being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceClass">https://w3id.org/def/och#sourceClass</seealso>
    let sourceClass = Prefixed_Name(w3och, "sourceClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#sourceIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the subject of the relation being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceIndividual">https://w3id.org/def/och#sourceIndividual</seealso>
    let sourceIndividual = Prefixed_Name(w3och, "sourceIndividual") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#sourceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property that is the subject of the property relations being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceProperty">https://w3id.org/def/och#sourceProperty</seealso>
    let sourceProperty = Prefixed_Name(w3och, "sourceProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the disjoint property relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveDisjointProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveDisjointProperty">https://w3id.org/def/och#sourceRemoveDisjointProperty</seealso>
    let sourceRemoveDisjointProperty =
        Prefixed_Name(w3och, "sourceRemoveDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the equivalent class relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveEquivalentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveEquivalentClass">https://w3id.org/def/och#sourceRemoveEquivalentClass</seealso>
    let sourceRemoveEquivalentClass =
        Prefixed_Name(w3och, "sourceRemoveEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the equivalent property relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveEquivalentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveEquivalentProperty">https://w3id.org/def/och#sourceRemoveEquivalentProperty</seealso>
    let sourceRemoveEquivalentProperty =
        Prefixed_Name(w3och, "sourceRemoveEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the inverse property relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveInverseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveInverseProperty">https://w3id.org/def/och#sourceRemoveInverseProperty</seealso>
    let sourceRemoveInverseProperty =
        Prefixed_Name(w3och, "sourceRemoveInverseProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the subject of the relation being removed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source remove relation to individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveRelationToIndividual">https://w3id.org/def/och#sourceRemoveRelationToIndividual</seealso>
    let sourceRemoveRelationToIndividual =
        Prefixed_Name(w3och, "sourceRemoveRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the disjoint property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveSubClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveSubClass">https://w3id.org/def/och#sourceRemoveSubClass</seealso>
    let sourceRemoveSubClass =
        Prefixed_Name(w3och, "sourceRemoveSubClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#sourceRemoveSubProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The subject of the subProperty relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"source RemoveSubProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#sourceRemoveSubProperty">https://w3id.org/def/och#sourceRemoveSubProperty</seealso>
    let sourceRemoveSubProperty =
        Prefixed_Name(w3och, "sourceRemoveSubProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the disjoint property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddDisjointProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddDisjointProperty">https://w3id.org/def/och#targetAddDisjointProperty</seealso>
    let targetAddDisjointProperty =
        Prefixed_Name(w3och, "targetAddDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the equivalent class relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddEquivalentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddEquivalentClass">https://w3id.org/def/och#targetAddEquivalentClass</seealso>
    let targetAddEquivalentClass =
        Prefixed_Name(w3och, "targetAddEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the equivalent property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddEquivalentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddEquivalentProperty">https://w3id.org/def/och#targetAddEquivalentProperty</seealso>
    let targetAddEquivalentProperty =
        Prefixed_Name(w3och, "targetAddEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the inverse property relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddInverseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddInverseProperty">https://w3id.org/def/och#targetAddInverseProperty</seealso>
    let targetAddInverseProperty =
        Prefixed_Name(w3och, "targetAddInverseProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the object of the relation being added in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target add relation to individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddRelationToIndividual">https://w3id.org/def/och#targetAddRelationToIndividual</seealso>
    let targetAddRelationToIndividual =
        Prefixed_Name(w3och, "targetAddRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the subClass relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddSubClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddSubClass">https://w3id.org/def/och#targetAddSubClass</seealso>
    let targetAddSubClass = Prefixed_Name(w3och, "targetAddSubClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetAddSubProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the subProperty relation being added"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target AddSubProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetAddSubProperty">https://w3id.org/def/och#targetAddSubProperty</seealso>
    let targetAddSubProperty =
        Prefixed_Name(w3och, "targetAddSubProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The class that is the object of the class relations being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetClass">https://w3id.org/def/och#targetClass</seealso>
    let targetClass = Prefixed_Name(w3och, "targetClass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:def/och#targetProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property that is the object of the property relations being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetProperty">https://w3id.org/def/och#targetProperty</seealso>
    let targetProperty = Prefixed_Name(w3och, "targetProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveDisjointProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the disjoint property relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemoveDisjointProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveDisjointProperty">https://w3id.org/def/och#targetRemoveDisjointProperty</seealso>
    let targetRemoveDisjointProperty =
        Prefixed_Name(w3och, "targetRemoveDisjointProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveEquivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the equivalent class relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemoveEquivalentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveEquivalentClass">https://w3id.org/def/och#targetRemoveEquivalentClass</seealso>
    let targetRemoveEquivalentClass =
        Prefixed_Name(w3och, "targetRemoveEquivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveEquivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the equivalent class relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemoveEquivalentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveEquivalentProperty">https://w3id.org/def/och#targetRemoveEquivalentProperty</seealso>
    let targetRemoveEquivalentProperty =
        Prefixed_Name(w3och, "targetRemoveEquivalentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveInverseProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the inverse property relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemoveInverseProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveInverseProperty">https://w3id.org/def/och#targetRemoveInverseProperty</seealso>
    let targetRemoveInverseProperty =
        Prefixed_Name(w3och, "targetRemoveInverseProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveRelationToIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the object of the relation being removed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target remove relation to individuals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveRelationToIndividual">https://w3id.org/def/och#targetRemoveRelationToIndividual</seealso>
    let targetRemoveRelationToIndividual =
        Prefixed_Name(w3och, "targetRemoveRelationToIndividual") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveSubClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the subClass relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemovesubClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveSubClass">https://w3id.org/def/och#targetRemoveSubClass</seealso>
    let targetRemoveSubClass =
        Prefixed_Name(w3och, "targetRemoveSubClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetRemoveSubProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object of the subProperty relation being removed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target RemoveSubProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetRemoveSubProperty">https://w3id.org/def/och#targetRemoveSubProperty</seealso>
    let targetRemoveSubProperty =
        Prefixed_Name(w3och, "targetRemoveSubProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#targetResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The individual that is the object of the relation being changed in a change operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"target individual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#targetResource">https://w3id.org/def/och#targetResource</seealso>
    let targetResource = Prefixed_Name(w3och, "targetResource") |> PrefixedName

    /// <summary>
    ///   <para>w3id:def/och#undeprecatedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The ontological term that is being undeprecated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"undeprecated element"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/def/och#undeprecatedElement">https://w3id.org/def/och#undeprecatedElement</seealso>
    let undeprecatedElement =
        Prefixed_Name(w3och, "undeprecatedElement") |> PrefixedName
