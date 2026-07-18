namespace http.rdvocab.info.uri.schema.FRBRentitiesRDA.slash

open DoxAletheia.Rdf_Vocabulary

module rdafrbr =
    let _namespace_name = "http://rdvocab.info/uri/schema/FRBRentitiesRDA/"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/CorporateBody"></see>
    /// </summary>
    let CorporateBody =
        Namespaced_IRI.parse _namespace_name "CorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Family"></see>
    /// </summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Subject"></see>
    /// </summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Expression"></see>
    /// </summary>
    let Expression = Namespaced_IRI.parse _namespace_name "Expression" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Item"></see>
    /// </summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Manifestation"></see>
    /// </summary>
    let Manifestation =
        Namespaced_IRI.parse _namespace_name "Manifestation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Name"></see>
    /// </summary>
    let Name = Namespaced_IRI.parse _namespace_name "Name" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Place"></see>
    /// </summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Work"></see>
    /// </summary>
    let Work = Namespaced_IRI.parse _namespace_name "Work" |> NamespacedName
