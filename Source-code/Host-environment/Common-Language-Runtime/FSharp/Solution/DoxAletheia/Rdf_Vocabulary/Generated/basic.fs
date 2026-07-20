namespace http.def.seegrid.csiro.au.isotc211.iso19103._2005.basic.hash

open DoxAletheia

module basic =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Measure of amount of substance
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// Measure of temporal extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// measure of arc length or rotation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Angle"></see></summary>
    let Angle = _prefix "Angle"
    /// <summary>
    /// Temporal position expressed as a time and date
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#DateTime"></see></summary>
    let DateTime = _prefix "DateTime"
    /// <summary>
    /// Truth value. Most valuable in the predicate calculus, where items are either True or False, unless they are ill formed.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Boolean"></see></summary>
    let Boolean = _prefix "Boolean"
    /// <summary>
    /// Temporal position expressed with precision of days
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// The value of this property is a number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Measure of 1-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Length"></see></summary>
    let Length = _prefix "Length"
    /// <summary>
    /// The common binary Real finite implementation using base 2. Since such reals can approximate any measure where absolute accuracy is not possible, this form of numeric is most often used for measures. In cases were absolute accuracy is needed, such as currencies, then a decimal representation may be preferred (assuming the currency is decimal, such as the US dollar, British pound, etc.). Where there are no subunits possible, Integer numbers may be preferred.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/2 (halves).
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Real"></see></summary>
    let Real = _prefix "Real"
    /// <summary>
    /// Measure of rate of change of position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Velocity"></see></summary>
    let Velocity = _prefix "Velocity"
    /// <summary>
    /// Name in some local context
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#LocalName"></see></summary>
    let LocalName = _prefix "LocalName"
    /// <summary>
    /// Number of components in the vector
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#dimension"></see></summary>
    let dimension = _prefix "dimension"
    /// <summary>
    /// Scaled number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Measure"></see></summary>
    let Measure = _prefix "Measure"
    /// <summary>
    /// sequence of characters
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#CharacterString"></see></summary>
    let CharacterString = _prefix "CharacterString"
    /// <summary>
    /// A vector is a sequence of a fixed length of Numbers. Normally, the numbers represent some measures, and thus vectors are often used where records of Numbers would be more appropriate. In geometry for example, direct positions are given by undistinguished coordinate vectors, which can be interpreted through the use of coordinate reference systems.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Vector"></see></summary>
    let Vector = _prefix "Vector"
    /// <summary>
    /// Measure of 3-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Volume"></see></summary>
    let Volume = _prefix "Volume"
    /// <summary>
    /// An exact integer value, with no fractional part.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Integer"></see></summary>
    let Integer = _prefix "Integer"
    /// <summary>
    /// Measure of rate of change of velocity
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Acceleration"></see></summary>
    let Acceleration = _prefix "Acceleration"
    /// <summary>
    /// The value of this property designates the units of measure or scale for the quantity
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#uom"></see></summary>
    let uom = _prefix "uom"
    /// <summary>
    /// Measure of force due to a mass in a specific gravitational field
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Weight"></see></summary>
    let Weight = _prefix "Weight"
    /// <summary>
    /// The usually finite representation of a decimal number. It differs from the common binary Real implementation in that it can represent 1/10 (one-tenth) without error, while binary real representation can only represent powers of 1/2 (one-half) exactly. Since many currencies are decimal, these representations are preferred in dealing with such moneys. This is also true for mile markers, which are often given in decimals.
    ///
    /// Can be thought of as an integer part followed by a fractional part given in multiples of powers of 1/10 (tenths).
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Decimal"></see></summary>
    let Decimal = _prefix "Decimal"
    /// <summary>
    /// Factor by which a representation should be magnified to match the geomstric size of the thing it represents.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Scale"></see></summary>
    let Scale = _prefix "Scale"
    /// <summary>
    /// Scale for a number describing size or extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#UnitOfMeasure"></see></summary>
    let UnitOfMeasure = _prefix "UnitOfMeasure"
    /// <summary>
    /// Measure of exchange value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Currency"></see></summary>
    let Currency = _prefix "Currency"
    /// <summary>
    /// Measure of rate of change of angular position
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#AngularVelocity"></see></summary>
    let AngularVelocity = _prefix "AngularVelocity"
    /// <summary>
    /// The value of this property is a scaled number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#measure"></see></summary>
    let measure = _prefix "measure"
    /// <summary>
    /// The set of numbers
    /// Note: integer is a specialization of decimal
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Number"></see></summary>
    let Number = _prefix "Number"
    /// <summary>
    /// Measure of spatial separation along some 1-D manifold
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Distance"></see></summary>
    let Distance = _prefix "Distance"
    /// <summary>
    /// Measure of 2-D extent
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// Numerical values of the vector components
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#ordinates"></see></summary>
    let ordinates = _prefix "ordinates"
