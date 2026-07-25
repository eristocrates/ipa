namespace http.def.seegrid.csiro.au.isotc211.iso19150._2._2012.basic.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module h2o =
    let _namespace_iri = Namespace_Iri h2o |> NamespaceIRI
    /// <summary>
    ///   <para>h2o:tvalue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>UML tagged value value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tvalue">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tvalue</seealso>
    let tvalue = Prefixed_Name(h2o, "tvalue") |> PrefixedName
    /// <summary>
    ///   <para>h2o:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#</seealso>
    let _prefix_iri = Prefixed_Name(h2o, "") |> PrefixedName
    /// <summary>
    ///   <para>h2o:TaggedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class for UML tagged values</para>
    /// labels<para>UML tagged value structure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#TaggedValue">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#TaggedValue</seealso>
    let TaggedValue = Prefixed_Name(h2o, "TaggedValue") |> PrefixedName
    /// <summary>
    ///   <para>h2o:constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>UML constraint</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#constraint">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#constraint</seealso>
    let constraint_ = Prefixed_Name(h2o, "constraint") |> PrefixedName
    /// <summary>
    ///   <para>h2o:isStereotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This property indicates if the class corresponds to a UML stereotype </para>
    /// labels<para>ISO stereotype flag</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isStereotype">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isStereotype</seealso>
    let isStereotype = Prefixed_Name(h2o, "isStereotype") |> PrefixedName
    /// <summary>
    ///   <para>h2o:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>OWL property that links to a tagged value</para>
    /// labels<para>UML tagged value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tag">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#tag</seealso>
    let tag = Prefixed_Name(h2o, "tag") |> PrefixedName
    /// <summary>
    ///   <para>h2o:ttag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>UML tagged value tag</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ttag">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ttag</seealso>
    let ttag = Prefixed_Name(h2o, "ttag") |> PrefixedName
    /// <summary>
    ///   <para>h2o:valueAssignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>property that can be attached to any statement to support a link to the evidence for the value</para>
    /// labels<para>value assignment method</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#valueAssignment">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#valueAssignment</seealso>
    let valueAssignment = Prefixed_Name(h2o, "valueAssignment") |> PrefixedName
    /// <summary>
    ///   <para>h2o:isAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>This property indicates whether the class was flagged 'abstract' in the UML model. Abstract classes cannot be instantiated directly. Concrete subclasses may be instantiated.</para>
    /// labels<para>UML abstract class</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isAbstract">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#isAbstract</seealso>
    let isAbstract = Prefixed_Name(h2o, "isAbstract") |> PrefixedName
    /// <summary>
    ///   <para>h2o:ISOClassName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>A datatype for skos:notation annotations, used to indicate the original UML class name</para>
    /// labels<para>ISO Class name</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ISOClassName">http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#ISOClassName</seealso>
    let ISOClassName = Prefixed_Name(h2o, "ISOClassName") |> PrefixedName
