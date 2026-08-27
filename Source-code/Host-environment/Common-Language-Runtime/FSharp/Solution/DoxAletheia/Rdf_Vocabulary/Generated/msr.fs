namespace http.www.telegraphis.net.ontology.measurement.measurement.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module msr =
    let _namespace_iri = Namespace_Iri msr |> NamespaceIRI
    /// <summary>
    ///   <para>msr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#">http://www.telegraphis.net/ontology/measurement/measurement#</seealso>
    let _prefix_iri = Prefixed_Name(msr, "") |> PrefixedName
    /// <summary>
    ///   <para>msr:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>msr:Quantity</para>
    ///
    /// labels<para>"Area"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#Area">http://www.telegraphis.net/ontology/measurement/measurement#Area</seealso>
    let Area = Prefixed_Name(msr, "Area") |> PrefixedName
    /// <summary>
    ///   <para>msr:AreaMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>msr:AreaUnit</para>
    ///
    /// labels<para>"Area Measurement"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#AreaMeasurement">http://www.telegraphis.net/ontology/measurement/measurement#AreaMeasurement</seealso>
    let AreaMeasurement = Prefixed_Name(msr, "AreaMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>msr:AreaUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>msr:UnitClass</para>
    ///
    /// labels<para>"Area Unit"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#AreaUnit">http://www.telegraphis.net/ontology/measurement/measurement#AreaUnit</seealso>
    let AreaUnit = Prefixed_Name(msr, "AreaUnit") |> PrefixedName
    /// <summary>
    ///   <para>msr:Km2</para>
    /// </summary>
    /// <remarks>
    ///   <para>msr:AreaUnit</para>
    ///
    /// labels<para>"square kilometers"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#Km2">http://www.telegraphis.net/ontology/measurement/measurement#Km2</seealso>
    let Km2 = Prefixed_Name(msr, "Km2") |> PrefixedName
    /// <summary>
    ///   <para>msr:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Measurement"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#Measurement">http://www.telegraphis.net/ontology/measurement/measurement#Measurement</seealso>
    let Measurement = Prefixed_Name(msr, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>msr:Quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Quantity"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#Quantity">http://www.telegraphis.net/ontology/measurement/measurement#Quantity</seealso>
    let Quantity = Prefixed_Name(msr, "Quantity") |> PrefixedName
    /// <summary>
    ///   <para>msr:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unit"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#Unit">http://www.telegraphis.net/ontology/measurement/measurement#Unit</seealso>
    let Unit = Prefixed_Name(msr, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>msr:UnitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unit Class"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#UnitClass">http://www.telegraphis.net/ontology/measurement/measurement#UnitClass</seealso>
    let UnitClass = Prefixed_Name(msr, "UnitClass") |> PrefixedName
    /// <summary>
    ///   <para>msr:UnitSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Unit System"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#UnitSystem">http://www.telegraphis.net/ontology/measurement/measurement#UnitSystem</seealso>
    let UnitSystem = Prefixed_Name(msr, "UnitSystem") |> PrefixedName
    /// <summary>
    ///   <para>msr:area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"area"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#area">http://www.telegraphis.net/ontology/measurement/measurement#area</seealso>
    let area = Prefixed_Name(msr, "area") |> PrefixedName
    /// <summary>
    ///   <para>msr:equivalentQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equivalent quantity"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentQuantity">http://www.telegraphis.net/ontology/measurement/measurement#equivalentQuantity</seealso>
    let equivalentQuantity = Prefixed_Name(msr, "equivalentQuantity") |> PrefixedName
    /// <summary>
    ///   <para>msr:equivalentUnitClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"equivalent unit class"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#equivalentUnitClass">http://www.telegraphis.net/ontology/measurement/measurement#equivalentUnitClass</seealso>
    let equivalentUnitClass = Prefixed_Name(msr, "equivalentUnitClass") |> PrefixedName
    /// <summary>
    ///   <para>msr:measuredQuantity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#measuredQuantity">http://www.telegraphis.net/ontology/measurement/measurement#measuredQuantity</seealso>
    let measuredQuantity = Prefixed_Name(msr, "measuredQuantity") |> PrefixedName
    /// <summary>
    ///   <para>msr:quantityMeasured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"measured quantity"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#quantityMeasured">http://www.telegraphis.net/ontology/measurement/measurement#quantityMeasured</seealso>
    let quantityMeasured = Prefixed_Name(msr, "quantityMeasured") |> PrefixedName
    /// <summary>
    ///   <para>msr:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>"unit"</para></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#unit">http://www.telegraphis.net/ontology/measurement/measurement#unit</seealso>
    let unit = Prefixed_Name(msr, "unit") |> PrefixedName
    /// <summary>
    ///   <para>msr:unitClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#unitClass">http://www.telegraphis.net/ontology/measurement/measurement#unitClass</seealso>
    let unitClass = Prefixed_Name(msr, "unitClass") |> PrefixedName
    /// <summary>
    ///   <para>msr:units</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.telegraphis.net/ontology/measurement/measurement#units">http://www.telegraphis.net/ontology/measurement/measurement#units</seealso>
    let units = Prefixed_Name(msr, "units") |> PrefixedName
