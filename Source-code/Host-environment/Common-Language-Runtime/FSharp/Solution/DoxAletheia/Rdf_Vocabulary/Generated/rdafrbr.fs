namespace http.rdvocab.info.uri.schema.FRBRentitiesRDA.slash

open DoxAletheia

module rdafrbr =
    let _namespace_name = "http://rdvocab.info/uri/schema/FRBRentitiesRDA/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/CorporateBody"></see>
    /// </summary>
    let CorporateBody = _prefix "CorporateBody"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Family"></see>
    /// </summary>
    let Family = _prefix "Family"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Subject"></see>
    /// </summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Expression"></see>
    /// </summary>
    let Expression = _prefix "Expression"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Item"></see>
    /// </summary>
    let Item = _prefix "Item"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Manifestation"></see>
    /// </summary>
    let Manifestation = _prefix "Manifestation"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Name"></see>
    /// </summary>
    let Name = _prefix "Name"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Place"></see>
    /// </summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://rdvocab.info/uri/schema/FRBRentitiesRDA/Work"></see>
    /// </summary>
    let Work = _prefix "Work"
