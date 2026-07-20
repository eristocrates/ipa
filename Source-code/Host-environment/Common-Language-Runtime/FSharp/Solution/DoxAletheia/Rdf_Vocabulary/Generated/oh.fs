namespace http.semweb.mmlab.be.ns.oh.hash

open DoxAletheia

module oh =
    let _namespace_name = "http://semweb.mmlab.be/ns/oh#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A calendar which can be used for opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#Calendar"></see></summary>
    let Calendar = _prefix "Calendar"
    /// <summary>
    /// A class to identify opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#OpeningHours"></see></summary>
    let OpeningHours = _prefix "OpeningHours"
    /// <summary>
    /// A class to identify the type of opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#OpeningHoursType"></see></summary>
    let OpeningHoursType = _prefix "OpeningHoursType"
    /// <summary>
    /// A property to tell oh:OpeningHours to keep this calendar into account
    /// <see href="http://semweb.mmlab.be/ns/oh#calendar"></see></summary>
    let calendar = _prefix "calendar"
    /// <summary>
    /// Tell whether or not this oh:Calendar specifies closing hours.
    /// <see href="http://semweb.mmlab.be/ns/oh#closinghours"></see></summary>
    let closinghours = _prefix "closinghours"
    /// <summary>
    /// Link a certain thing to a description of opening hours
    /// <see href="http://semweb.mmlab.be/ns/oh#hasOpeningHours"></see></summary>
    let hasOpeningHours = _prefix "hasOpeningHours"
    /// <summary>
    /// Give a type to an oh:OpeningHours instance
    /// <see href="http://semweb.mmlab.be/ns/oh#type"></see></summary>
    let type_ = _prefix "type"
