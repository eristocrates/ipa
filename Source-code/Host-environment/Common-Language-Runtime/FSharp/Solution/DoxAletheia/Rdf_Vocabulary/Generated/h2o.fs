namespace http.def.seegrid.csiro.au.isotc211.iso19150._2._2012.basic.hash

open DoxAletheia

module h2o =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tvalue"></see>
    /// </summary>
    let tvalue = _prefix "tvalue"
    /// <summary>
    /// Class for UML tagged values
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#TaggedValue"></see></summary>
    let TaggedValue = _prefix "TaggedValue"
    /// <summary>
    /// This property indicates whether the class was flagged 'abstract' in the UML model. Abstract classes cannot be instantiated directly. Concrete subclasses may be instantiated.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isAbstract"></see></summary>
    let isAbstract = _prefix "isAbstract"
    /// <summary>
    /// A datatype for skos:notation annotations, used to indicate the original UML class name
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ISOClassName"></see></summary>
    let ISOClassName = _prefix "ISOClassName"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#constraint"></see>
    /// </summary>
    let constraint_ = _prefix "constraint"
    /// <summary>
    /// OWL property that links to a tagged value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tag"></see></summary>
    let tag = _prefix "tag"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ttag"></see>
    /// </summary>
    let ttag = _prefix "ttag"
    /// <summary>
    /// This property indicates if the class corresponds to a UML stereotype
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isStereotype"></see></summary>
    let isStereotype = _prefix "isStereotype"
    /// <summary>
    /// property that can be attached to any statement to support a link to the evidence for the value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#valueAssignment"></see></summary>
    let valueAssignment = _prefix "valueAssignment"
