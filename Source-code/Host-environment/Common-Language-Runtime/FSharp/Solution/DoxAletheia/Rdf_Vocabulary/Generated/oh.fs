namespace http.semweb.mmlab.be.ns.oh.hash

open DoxAletheia.Rdf_Vocabulary

module oh =
    let _namespace_name = "http://semweb.mmlab.be/ns/oh#"
    /// <summary>
    /// A calendar which can be used for opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#Calendar"></see></summary>
    let Calendar = Namespaced_IRI.parse _namespace_name "Calendar" |> NamespacedName

    /// <summary>
    /// A class to identify opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#OpeningHours"></see></summary>
    let OpeningHours =
        Namespaced_IRI.parse _namespace_name "OpeningHours" |> NamespacedName

    /// <summary>
    /// A class to identify the type of opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#OpeningHoursType"></see></summary>
    let OpeningHoursType =
        Namespaced_IRI.parse _namespace_name "OpeningHoursType" |> NamespacedName

    /// <summary>
    /// A property to tell oh:OpeningHours to keep this calendar into account
    /// <see href="http://semweb.mmlab.be/ns/oh#calendar"></see></summary>
    let calendar = Namespaced_IRI.parse _namespace_name "calendar" |> NamespacedName

    /// <summary>
    /// Tell whether or not this oh:Calendar specifies closing hours.
    /// <see href="http://semweb.mmlab.be/ns/oh#closinghours"></see></summary>
    let closinghours =
        Namespaced_IRI.parse _namespace_name "closinghours" |> NamespacedName

    /// <summary>
    /// Link a certain thing to a description of opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#hasOpeningHours"></see></summary>
    let hasOpeningHours =
        Namespaced_IRI.parse _namespace_name "hasOpeningHours" |> NamespacedName

    /// <summary>
    /// Give a type to an oh:OpeningHours instance
    /// <see href="http://semweb.mmlab.be/ns/oh#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
