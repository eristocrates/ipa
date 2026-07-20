namespace http.contextus.net.ontology.ontomedia.misc.date.hash

open DoxAletheia

module date =
    let _namespace_name = "http://contextus.net/ontology/ontomedia/misc/date#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents a system of representing time
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Calendar"></see></summary>
    let Calendar = _prefix "Calendar"
    /// <summary>
    /// This class represents a reference point which a calendar measures other dates relative to
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#CalendarReferencePoint"></see></summary>
    let CalendarReferencePoint = _prefix "CalendarReferencePoint"
    /// <summary>
    /// This class represents a value representing time
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// This class represents the parts of a date
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date-Component"></see></summary>
    let ``Date-Component`` = _prefix "Date-Component"
    /// <summary>
    /// This class represents the order in which components describing a date should be displayed
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Date-Ordering"></see></summary>
    let ``Date-Ordering`` = _prefix "Date-Ordering"
    /// <summary>
    /// This class represents the part of a date which is the day designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Day"></see></summary>
    let Day = _prefix "Day"
    /// <summary>
    /// This class represents the part of a date which is the hour designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Hour"></see></summary>
    let Hour = _prefix "Hour"
    /// <summary>
    /// This class represents the part of a date which is the minute designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Minute"></see></summary>
    let Minute = _prefix "Minute"
    /// <summary>
    /// This class represents the part of a date which is the month designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Month"></see></summary>
    let Month = _prefix "Month"
    /// <summary>
    /// This class represents the textual qualifier that may be part of the data i.e. AD, BCE etc
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Qualifier"></see></summary>
    let Qualifier = _prefix "Qualifier"
    /// <summary>
    /// This class represents the part of a date which is the second designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Second"></see></summary>
    let Second = _prefix "Second"
    /// <summary>
    /// This class represents the International Standard form of the date
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// This class represents the part of a date which is the year designaition
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#Year"></see></summary>
    let Year = _prefix "Year"
    /// <summary>
    /// The occurrance of an event from which the reference point was abstracted
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#abstracted-from-occurrence"></see></summary>
    let ``abstracted-from-occurrence`` = _prefix "abstracted-from-occurrence"
    /// <summary>
    /// The relative reference point after which the desired point of time occurs
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#after-reference-point"></see></summary>
    let ``after-reference-point`` = _prefix "after-reference-point"
    /// <summary>
    /// The relative reference point before which the desired point of time occurs
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#before-reference-point"></see></summary>
    let ``before-reference-point`` = _prefix "before-reference-point"
    /// <summary>
    /// This property specifies the name represented by the component
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#has-date-component"></see></summary>
    let ``has-date-component`` = _prefix "has-date-component"
    /// <summary>
    /// This property specifies a point of reference in a Calendar
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#has-reference-point"></see></summary>
    let ``has-reference-point`` = _prefix "has-reference-point"
    /// <summary>
    /// The Year Preceeding the Reference Point Year
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-minus-one"></see></summary>
    let ``reference-point-minus-one`` = _prefix "reference-point-minus-one"
    /// <summary>
    /// The Year Following the Reference Point Year
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#reference-point-plus-one"></see></summary>
    let ``reference-point-plus-one`` = _prefix "reference-point-plus-one"
    /// <summary>
    /// The calandar which the date uses
    /// <see href="http://contextus.net/ontology/ontomedia/misc/date#uses-calendar"></see></summary>
    let ``uses-calendar`` = _prefix "uses-calendar"
