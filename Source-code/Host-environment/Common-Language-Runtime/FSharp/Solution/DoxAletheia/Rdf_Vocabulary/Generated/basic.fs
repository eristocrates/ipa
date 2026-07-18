namespace http.def.seegrid.csiro.au.isotc211.iso19103._2005.basic.hash

open DoxAletheia.Rdf_Vocabulary

module basic =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#"
    /// <summary>
    /// Measure of amount of substance
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Mass"></see></summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName
    /// <summary>
    /// Measure of temporal extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// measure of arc length or rotation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Angle"></see></summary>
    let Angle = Namespaced_IRI.parse _namespace_name "Angle" |> NamespacedName
    /// <summary>
    /// Temporal position expressed as a time and date
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#DateTime"></see></summary>
    let DateTime = Namespaced_IRI.parse _namespace_name "DateTime" |> NamespacedName
    /// <summary>
    /// Truth value. Most valuable in the predicate calculus, where items are either True or False, unless they are ill formed.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Boolean"></see></summary>
    let Boolean = Namespaced_IRI.parse _namespace_name "Boolean" |> NamespacedName
    /// <summary>
    /// Temporal position expressed with precision of days
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    /// The value of this property is a number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Measure of 1-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Length"></see></summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName
    /// <summary>
    /// The common binary Real finite implementation using base 2. Since such reals can approximate any measure where absolute accuracy is not possible, this form of numeric is most often used for measures. In cases were absolute accuracy is needed, such as currencies, then a decimal representation may be preferred (assuming the currency is decimal, such as the US dollar, British pound, etc.). Where there are no subunits possible, Integer numbers may be preferred.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/2 (halves).
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Real"></see></summary>
    let Real = Namespaced_IRI.parse _namespace_name "Real" |> NamespacedName
    /// <summary>
    /// Measure of rate of change of position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Velocity"></see></summary>
    let Velocity = Namespaced_IRI.parse _namespace_name "Velocity" |> NamespacedName
    /// <summary>
    /// Name in some local context
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#LocalName"></see></summary>
    let LocalName = Namespaced_IRI.parse _namespace_name "LocalName" |> NamespacedName
    /// <summary>
    /// Number of components in the vector
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#dimension"></see></summary>
    let dimension = Namespaced_IRI.parse _namespace_name "dimension" |> NamespacedName
    /// <summary>
    /// Scaled number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Measure"></see></summary>
    let Measure = Namespaced_IRI.parse _namespace_name "Measure" |> NamespacedName

    /// <summary>
    /// sequence of characters
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#CharacterString"></see></summary>
    let CharacterString =
        Namespaced_IRI.parse _namespace_name "CharacterString" |> NamespacedName

    /// <summary>
    /// A vector is a sequence of a fixed length of Numbers. Normally, the numbers represent some measures, and thus vectors are often used where records of Numbers would be more appropriate. In geometry for example, direct positions are given by undistinguished coordinate vectors, which can be interpreted through the use of coordinate reference systems.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Vector"></see></summary>
    let Vector = Namespaced_IRI.parse _namespace_name "Vector" |> NamespacedName
    /// <summary>
    /// Measure of 3-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Volume"></see></summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName
    /// <summary>
    /// An exact integer value, with no fractional part.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Integer"></see></summary>
    let Integer = Namespaced_IRI.parse _namespace_name "Integer" |> NamespacedName

    /// <summary>
    /// Measure of rate of change of velocity
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Acceleration"></see></summary>
    let Acceleration =
        Namespaced_IRI.parse _namespace_name "Acceleration" |> NamespacedName

    /// <summary>
    /// The value of this property designates the units of measure or scale for the quantity
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#uom"></see></summary>
    let uom = Namespaced_IRI.parse _namespace_name "uom" |> NamespacedName
    /// <summary>
    /// Measure of force due to a mass in a specific gravitational field
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Weight"></see></summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName
    /// <summary>
    /// The usually finite representation of a decimal number. It differs from the common binary Real implementation in that it can represent 1/10 (one-tenth) without error, while binary real representation can only represent powers of 1/2 (one-half) exactly. Since many currencies are decimal, these representations are preferred in dealing with such moneys. This is also true for mile markers, which are often given in decimals.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/10 (tenths).
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Decimal"></see></summary>
    let Decimal = Namespaced_IRI.parse _namespace_name "Decimal" |> NamespacedName
    /// <summary>
    /// Factor by which a representation should be magnified to match the geomstric size of the thing it represents.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    /// Scale for a number describing size or extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#UnitOfMeasure"></see></summary>
    let UnitOfMeasure =
        Namespaced_IRI.parse _namespace_name "UnitOfMeasure" |> NamespacedName

    /// <summary>
    /// Measure of exchange value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Currency"></see></summary>
    let Currency = Namespaced_IRI.parse _namespace_name "Currency" |> NamespacedName

    /// <summary>
    /// Measure of rate of change of angular position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#AngularVelocity"></see></summary>
    let AngularVelocity =
        Namespaced_IRI.parse _namespace_name "AngularVelocity" |> NamespacedName

    /// <summary>
    /// The value of this property is a scaled number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#measure"></see></summary>
    let measure = Namespaced_IRI.parse _namespace_name "measure" |> NamespacedName
    /// <summary>
    /// The set of numbers
    /// Note: integer is a specialization of decimal
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Number"></see></summary>
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName
    /// <summary>
    /// Measure of spatial separation along some 1-D manifold
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Distance"></see></summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName
    /// <summary>
    /// Measure of 2-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Area"></see></summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName
    /// <summary>
    /// Numerical values of the vector components
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#ordinates"></see></summary>
    let ordinates = Namespaced_IRI.parse _namespace_name "ordinates" |> NamespacedName
