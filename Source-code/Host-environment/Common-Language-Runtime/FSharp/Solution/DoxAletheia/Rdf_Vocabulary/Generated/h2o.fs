namespace http.def.seegrid.csiro.au.isotc211.iso19150._2._2012.basic.hash

open DoxAletheia.Rdf_Vocabulary

module h2o =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tvalue"></see>
    /// </summary>
    let tvalue = Namespaced_IRI.parse _namespace_name "tvalue" |> NamespacedName

    /// <summary>
    /// Class for UML tagged values
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#TaggedValue"></see></summary>
    let TaggedValue =
        Namespaced_IRI.parse _namespace_name "TaggedValue" |> NamespacedName

    /// <summary>
    /// This property indicates whether the class was flagged 'abstract' in the UML model. Abstract classes cannot be instantiated directly. Concrete subclasses may be instantiated.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isAbstract"></see></summary>
    let isAbstract = Namespaced_IRI.parse _namespace_name "isAbstract" |> NamespacedName

    /// <summary>
    /// A datatype for skos:notation annotations, used to indicate the original UML class name
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ISOClassName"></see></summary>
    let ISOClassName =
        Namespaced_IRI.parse _namespace_name "ISOClassName" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#constraint"></see>
    /// </summary>
    let constraint_ =
        Namespaced_IRI.parse _namespace_name "constraint" |> NamespacedName

    /// <summary>
    /// OWL property that links to a tagged value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ttag"></see>
    /// </summary>
    let ttag = Namespaced_IRI.parse _namespace_name "ttag" |> NamespacedName

    /// <summary>
    /// This property indicates if the class corresponds to a UML stereotype
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isStereotype"></see></summary>
    let isStereotype =
        Namespaced_IRI.parse _namespace_name "isStereotype" |> NamespacedName

    /// <summary>
    /// property that can be attached to any statement to support a link to the evidence for the value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#valueAssignment"></see></summary>
    let valueAssignment =
        Namespaced_IRI.parse _namespace_name "valueAssignment" |> NamespacedName
