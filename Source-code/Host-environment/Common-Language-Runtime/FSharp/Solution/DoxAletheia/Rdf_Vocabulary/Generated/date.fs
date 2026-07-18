namespace http.contextus.net.ontology.ontomedia.misc.date.hash

open DoxAletheia.Rdf_Vocabulary

module date =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/misc/date#"
    /// <summary>
    /// This class represents a system of representing time
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Calendar"></see></summary>
    let Calendar = Namespaced_IRI.parse _namespace_name "Calendar" |> NamespacedName

    /// <summary>
    /// This class represents a reference point which a calendar measures other dates relative to
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#CalendarReferencePoint"></see></summary>
    let CalendarReferencePoint =
        Namespaced_IRI.parse _namespace_name "CalendarReferencePoint" |> NamespacedName

    /// <summary>
    /// This class represents a value representing time
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName

    /// <summary>
    /// This class represents the parts of a date
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date-Component"></see></summary>
    let ``Date-Component`` =
        Namespaced_IRI.parse _namespace_name "Date-Component" |> NamespacedName

    /// <summary>
    /// This class represents the order in which components describing a date should be displayed
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date-Ordering"></see></summary>
    let ``Date-Ordering`` =
        Namespaced_IRI.parse _namespace_name "Date-Ordering" |> NamespacedName

    /// <summary>
    /// This class represents the part of a date which is the day designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Day"></see></summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName
    /// <summary>
    /// This class represents the part of a date which is the hour designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName
    /// <summary>
    /// This class represents the part of a date which is the minute designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Minute"></see></summary>
    let Minute = Namespaced_IRI.parse _namespace_name "Minute" |> NamespacedName
    /// <summary>
    /// This class represents the part of a date which is the month designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Month"></see></summary>
    let Month = Namespaced_IRI.parse _namespace_name "Month" |> NamespacedName
    /// <summary>
    /// This class represents the textual qualifier that may be part of the data i.e. AD, BCE etc
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Qualifier"></see></summary>
    let Qualifier = Namespaced_IRI.parse _namespace_name "Qualifier" |> NamespacedName
    /// <summary>
    /// This class represents the part of a date which is the second designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Second"></see></summary>
    let Second = Namespaced_IRI.parse _namespace_name "Second" |> NamespacedName
    /// <summary>
    /// This class represents the International Standard form of the date
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName
    /// <summary>
    /// This class represents the part of a date which is the year designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Year"></see></summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName

    /// <summary>
    /// The occurrance of an event from which the reference point was abstracted
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#abstracted-from-occurrence"></see></summary>
    let ``abstracted-from-occurrence`` =
        Namespaced_IRI.parse _namespace_name "abstracted-from-occurrence" |> NamespacedName

    /// <summary>
    /// The relative reference point after which the desired point of time occurs
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#after-reference-point"></see></summary>
    let ``after-reference-point`` =
        Namespaced_IRI.parse _namespace_name "after-reference-point" |> NamespacedName

    /// <summary>
    /// The relative reference point before which the desired point of time occurs
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#before-reference-point"></see></summary>
    let ``before-reference-point`` =
        Namespaced_IRI.parse _namespace_name "before-reference-point" |> NamespacedName

    /// <summary>
    /// This property specifies the name represented by the component
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#has-date-component"></see></summary>
    let ``has-date-component`` =
        Namespaced_IRI.parse _namespace_name "has-date-component" |> NamespacedName

    /// <summary>
    /// This property specifies a point of reference in a Calendar
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#has-reference-point"></see></summary>
    let ``has-reference-point`` =
        Namespaced_IRI.parse _namespace_name "has-reference-point" |> NamespacedName

    /// <summary>
    /// The Year Preceeding the Reference Point Year
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-minus-one"></see></summary>
    let ``reference-point-minus-one`` =
        Namespaced_IRI.parse _namespace_name "reference-point-minus-one" |> NamespacedName

    /// <summary>
    /// The Year Following the Reference Point Year
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-plus-one"></see></summary>
    let ``reference-point-plus-one`` =
        Namespaced_IRI.parse _namespace_name "reference-point-plus-one" |> NamespacedName

    /// <summary>
    /// The calandar which the date uses
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#uses-calendar"></see></summary>
    let ``uses-calendar`` =
        Namespaced_IRI.parse _namespace_name "uses-calendar" |> NamespacedName
