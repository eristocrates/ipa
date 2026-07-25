namespace https.saref.etsi.org.saref4inma.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module s4inma =
    let _namespace_iri = Namespace_Iri s4inma |> NamespaceIRI
    /// <summary>
    ///   <para>s4inma:Site</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, sites are identified physical, geographical, and/or logical component groupings of a manufacturing enterprise. A factory can be divided in sites, whereas sites can be divided areas</para>
    /// labels<para>Site</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Site">https://saref.etsi.org/saref4inma/Site</seealso>
    let Site = Prefixed_Name(s4inma, "Site") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:WorkCenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of s4inma:ProductionEquipment (and therefore of s4bld:PhysicalObject). It is an equipment element under an area in a role-based equipment hierarchy that performs production, storage or material movement (definition taken from IEC 62264). An Area contains work centers.</para>
    /// labels<para>Work center</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/WorkCenter">https://saref.etsi.org/saref4inma/WorkCenter</seealso>
    let WorkCenter = Prefixed_Name(s4inma, "WorkCenter") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasIDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an indentifier as a string (it can be used as alternative to or in combination with the s4inma:hasIdentifier object property</para>
    /// labels<para>has identifier value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasIDValue">https://saref.etsi.org/saref4inma/hasIDValue</seealso>
    let hasIDValue = Prefixed_Name(s4inma, "hasIDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:IRDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>International Registration Data Identifier (IRDI) is based on the international standards ISO/IEC 11179-6, ISO 29002 and ISO 6532 and used in eCl@ss and the Asset Administration Shell as unique identifier.</para>
    /// labels<para>IRDI</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/IRDI">https://saref.etsi.org/saref4inma/IRDI</seealso>
    let IRDI = Prefixed_Name(s4inma, "IRDI") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to describe the serial number of a certain Item, which is unique per Item.</para>
    /// labels<para>has serial number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasSerialNumber">https://saref.etsi.org/saref4inma/hasSerialNumber</seealso>
    let hasSerialNumber = Prefixed_Name(s4inma, "hasSerialNumber") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:belongsToCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link between an entity and its category</para>
    /// labels<para>belongs to category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/belongsToCategory">https://saref.etsi.org/saref4inma/belongsToCategory</seealso>
    let belongsToCategory = Prefixed_Name(s4inma, "belongsToCategory") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:ItemCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ItemCategory describes a single type of item in terms of its static properties. Each ItemCategory can have multiple related ItemBatches, which all contain individual Items. The essential properties of each Item in all ItemBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of all Items related to an ItemCategory are similar.</para>
    /// labels<para>Item category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ItemCategory">https://saref.etsi.org/saref4inma/ItemCategory</seealso>
    let ItemCategory = Prefixed_Name(s4inma, "ItemCategory") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Items are produced using certain types of ProductionEquipmentCategories, for example: welding machines or laser cutting machines.</para>
    /// labels<para>is produced by</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/isProducedBy">https://saref.etsi.org/saref4inma/isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(s4inma, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unique identifier.</para>
    /// labels<para>Identifier</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ID">https://saref.etsi.org/saref4inma/ID</seealso>
    let ID = Prefixed_Name(s4inma, "ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tangible object which can be unique identified, for example, with a GTIN in the form of a barcode/QR/RFID tag. An item product can be the result of the organization's production process (i.e. outflow of objects/goods) or can be uniquely identifiable material (i.e. inflow of objects/supplies). Each item is part of exactly one ItemBatch, whereas each ItemBatch contains only Items which have similar properties. An item can consists of multiple Batches and other Items (i.e. subassemblies).</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Item">https://saref.etsi.org/saref4inma/Item</seealso>
    let Item = Prefixed_Name(s4inma, "Item") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:consistsOfItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to express that an item can recursively consists of other Items</para>
    /// labels<para>consists of item</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/consistsOfItem">https://saref.etsi.org/saref4inma/consistsOfItem</seealso>
    let consistsOfItem = Prefixed_Name(s4inma, "consistsOfItem") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:ProductionEquipmentFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Functionallity neccessary to accomplish the task for which a production equipment is designed.</para>
    /// labels<para>Production equipment function</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ProductionEquipmentFunction">https://saref.etsi.org/saref4inma/ProductionEquipmentFunction</seealso>
    let ProductionEquipmentFunction =
        Prefixed_Name(s4inma, "ProductionEquipmentFunction") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:MaterialCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A MaterialCategory describes a category of material in terms of its static properties. Examples are: a certain category of steel or plastic. Each MaterialCategory can have multiple related MaterialBatches, which represent the physical material. The essential properties of the material in all MaterialBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of the material related to an MaterialCategory are similar.</para>
    /// labels<para>Material category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/MaterialCategory">https://saref.etsi.org/saref4inma/MaterialCategory</seealso>
    let MaterialCategory = Prefixed_Name(s4inma, "MaterialCategory") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/">https://saref.etsi.org/saref4inma/</seealso>
    let _prefix_iri = Prefixed_Name(s4inma, "") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:ExpectedMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes whether the measurement is expected (i.e., planned before the production process). Disjoint with ActualMeasurement.</para>
    /// labels<para>Expected measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ExpectedMeasurement">https://saref.etsi.org/saref4inma/ExpectedMeasurement</seealso>
    let ExpectedMeasurement =
        Prefixed_Name(s4inma, "ExpectedMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:hasGTIN12ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the  GTIN-12 identifier</para>
    /// labels<para>has GTIN12ID </para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN12ID">https://saref.etsi.org/saref4inma/hasGTIN12ID</seealso>
    let hasGTIN12ID = Prefixed_Name(s4inma, "hasGTIN12ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN13ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the  GTIN-13 identifier</para>
    /// labels<para>has GTIN13ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN13ID">https://saref.etsi.org/saref4inma/hasGTIN13ID</seealso>
    let hasGTIN13ID = Prefixed_Name(s4inma, "hasGTIN13ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN14IDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an GTIN14 as a string</para>
    /// labels<para>has GTIN14ID value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN14IDValue">https://saref.etsi.org/saref4inma/hasGTIN14IDValue</seealso>
    let hasGTIN14IDValue = Prefixed_Name(s4inma, "hasGTIN14IDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasIRDI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the  International Registration Data Identifier (IRDI)</para>
    /// labels<para>has IRDI</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasIRDI">https://saref.etsi.org/saref4inma/hasIRDI</seealso>
    let hasIRDI = Prefixed_Name(s4inma, "hasIRDI") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasIRDIValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an IRDI as a string</para>
    /// labels<para>has IRDI value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasIRDIValue">https://saref.etsi.org/saref4inma/hasIRDIValue</seealso>
    let hasIRDIValue = Prefixed_Name(s4inma, "hasIRDIValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:UUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A universally unique identifier (UUID) is a 128-bit number used to identify items and is also known as: globally unique identifier (GUID). In its canonical textual representation, the sixteen octets of a UUID are represented as 32 hexadecimal (base 16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 alphanumeric characters and four hyphens). UUID are documented in ISO/IEC 11578:1996 "Information technology – Open Systems Interconnection – Remote Procedure Call (RPC)" and in ITU-T Rec. X.667 | ISO/IEC 9834-8:2005.</para>
    /// labels<para>UUID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/UUID">https://saref.etsi.org/saref4inma/UUID</seealso>
    let UUID = Prefixed_Name(s4inma, "UUID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN12IDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an GTIN12 as a string</para>
    /// labels<para>has GTIN12ID value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN12IDValue">https://saref.etsi.org/saref4inma/hasGTIN12IDValue</seealso>
    let hasGTIN12IDValue = Prefixed_Name(s4inma, "hasGTIN12IDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN13IDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an GTIN13 as a string</para>
    /// labels<para>has GTIN13ID value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN13IDValue">https://saref.etsi.org/saref4inma/hasGTIN13IDValue</seealso>
    let hasGTIN13IDValue = Prefixed_Name(s4inma, "hasGTIN13IDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN8ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the  GTIN-8 identifier</para>
    /// labels<para>has GTIN8ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN8ID">https://saref.etsi.org/saref4inma/hasGTIN8ID</seealso>
    let hasGTIN8ID = Prefixed_Name(s4inma, "hasGTIN8ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the Universally Unique Identifier (UUID)</para>
    /// labels<para>has UUID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasUUID">https://saref.etsi.org/saref4inma/hasUUID</seealso>
    let hasUUID = Prefixed_Name(s4inma, "hasUUID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasUUIDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an UUID as a string</para>
    /// labels<para>has UUID value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasUUIDValue">https://saref.etsi.org/saref4inma/hasUUIDValue</seealso>
    let hasUUIDValue = Prefixed_Name(s4inma, "hasUUIDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:ActualMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes whether the measurement is actually measured during the production process. Disjoint with ExpectedMeasurement.</para>
    /// labels<para>Actual measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ActualMeasurement">https://saref.etsi.org/saref4inma/ActualMeasurement</seealso>
    let ActualMeasurement = Prefixed_Name(s4inma, "ActualMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>link between an entity and its unique identifier</para>
    /// labels<para>has identifier</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasIdentifier">https://saref.etsi.org/saref4inma/hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(s4inma, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship to count the amount of certain objects in a collection (e.g., size of a material batch)</para>
    /// labels<para>has size</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasSize">https://saref.etsi.org/saref4inma/hasSize</seealso>
    let hasSize = Prefixed_Name(s4inma, "hasSize") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Factory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of s4bldg:Building specialized for the purpose of SAREF4INMA, a factory represents one or more organizations sharing a definit mission, goals and objectives which provides an output such as a product (definition taken from IEC 62264). A factory can be divided in one or multiple sites. </para>
    /// labels<para>Factory</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Factory">https://saref.etsi.org/saref4inma/Factory</seealso>
    let Factory = Prefixed_Name(s4inma, "Factory") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:GTIN12ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>GTIN-12 (UPC-A) is a 12-digit number used primarily in North America</para>
    /// labels<para>GTIN12ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/GTIN12ID">https://saref.etsi.org/saref4inma/GTIN12ID</seealso>
    let GTIN12ID = Prefixed_Name(s4inma, "GTIN12ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN14ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship determining the  GTIN-14 identifier</para>
    /// labels<para>has GTIN14ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN14ID">https://saref.etsi.org/saref4inma/hasGTIN14ID</seealso>
    let hasGTIN14ID = Prefixed_Name(s4inma, "hasGTIN14ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasGTIN8IDValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the value of an GTIN8 as a string</para>
    /// labels<para>has GTIN8ID value</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasGTIN8IDValue">https://saref.etsi.org/saref4inma/hasGTIN8IDValue</seealso>
    let hasGTIN8IDValue = Prefixed_Name(s4inma, "hasGTIN8IDValue") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ProductionEquipmentCategory, such as welding machines or laser cutting machines, produce certain categories of items (inverse of s4inma:isProducedBy)</para>
    /// labels<para>produces</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/produces">https://saref.etsi.org/saref4inma/produces</seealso>
    let produces = Prefixed_Name(s4inma, "produces") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, areas are physical, geographical or logical groupings of resources determined by the site. A site can be divided in areas, whereas areas contain work centers.s.</para>
    /// labels<para>Area</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Area">https://saref.etsi.org/saref4inma/Area</seealso>
    let Area = Prefixed_Name(s4inma, "Area") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:v1.1.2/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/v1.1.2/">https://saref.etsi.org/saref4inma/v1.1.2/</seealso>
    let ``v1.1.2/`` = Prefixed_Name(s4inma, "v1.1.2/") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A subclass of saref:Measurement that represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement. The saref4imna:Measurement can be linked to individual Batches or Items. Moreover, the Measurement can be an ExpectedMeasurement (i.e. the value which is planned) or the ActualMeasurement (i.e. the value measured during production), which enables to check for deviations between the planned and actual values.</para>
    /// labels<para>Measurement</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Measurement">https://saref.etsi.org/saref4inma/Measurement</seealso>
    let Measurement = Prefixed_Name(s4inma, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Batch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A uniform collection of tangible objects or Lot. This can either be a collection of produced items (i.e. the outflow of products) or a collection of raw material or required material (i.e. the inflow of products). It is assumed that the objects in a batch are similar and thus have shared attributes. Note that this definition is broader than the definition in IEC 61512, which defines a batch as the material that is being produced (whereas in SAREF4INMA a batch can be items or materials). </para>
    /// labels<para>Batch</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Batch">https://saref.etsi.org/saref4inma/Batch</seealso>
    let Batch = Prefixed_Name(s4inma, "Batch") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:consistsOfBatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to express that a batch can recursively consists of other batches</para>
    /// labels<para>consists of batch</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/consistsOfBatch">https://saref.etsi.org/saref4inma/consistsOfBatch</seealso>
    let consistsOfBatch = Prefixed_Name(s4inma, "consistsOfBatch") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:Size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The amount of certain objects in a collection (e.g., size of a material batch).</para>
    /// labels<para>Size</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/Size">https://saref.etsi.org/saref4inma/Size</seealso>
    let Size = Prefixed_Name(s4inma, "Size") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:isFeatureOfInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a feature of interest and equipment</para>
    /// labels<para>is feature of interest of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/isFeatureOfInterestOf">https://saref.etsi.org/saref4inma/isFeatureOfInterestOf</seealso>
    let isFeatureOfInterestOf =
        Prefixed_Name(s4inma, "isFeatureOfInterestOf") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:needsEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relationship indicating that an entity needs a particular equipment to be produced</para>
    /// labels<para>needs equipment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/needsEquipment">https://saref.etsi.org/saref4inma/needsEquipment</seealso>
    let needsEquipment = Prefixed_Name(s4inma, "needsEquipment") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:ProductionEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A production equipment is a specialization of a saref:Device and s4bldg:PhysicalObject that can produce items in a manufacturing process. This class represents an individual production equipment device and includes their specification in terms of functions, states and services. Different types of machines can be defined under this class as needed, for example, LaserCuttingMachine (i.e., a type of production equipment to cut steel material), MillingMachine (i.e., to drill holes in steel material), MouldingMachine (i.e., to mold liquid material, such as iron or plastic, and let it harden in a certain shape), WeldingMachine (i.e., join parts of material, such as steel, together), etc.</para>
    /// labels<para>ProductionEquipment</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ProductionEquipment">https://saref.etsi.org/saref4inma/ProductionEquipment</seealso>
    let ProductionEquipment =
        Prefixed_Name(s4inma, "ProductionEquipment") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:GTIN13ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>GTIN-13 (EAN/UCC-13) is a 13-digit number used predominately outside of North America</para>
    /// labels<para>GTIN13ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/GTIN13ID">https://saref.etsi.org/saref4inma/GTIN13ID</seealso>
    let GTIN13ID = Prefixed_Name(s4inma, "GTIN13ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:GTIN14ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>GTIN-14 (EAN/UCC-14 or ITF-14 or also known as ITF Symbol, SCC-14, DUN-14, UPC Case Code, UPC Shipping Container Code, UCC Code 128, EAN Code 128) is a 14-digit number used to identify trade items at various packaging levels.</para>
    /// labels<para>GTIN14ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/GTIN14ID">https://saref.etsi.org/saref4inma/GTIN14ID</seealso>
    let GTIN14ID = Prefixed_Name(s4inma, "GTIN14ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:GTIN8ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>GTIN-8 (EAN/UCC-8) is an 8-digit number used predominately outside of North America.</para>
    /// labels<para>GTIN18ID</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/GTIN8ID">https://saref.etsi.org/saref4inma/GTIN8ID</seealso>
    let GTIN8ID = Prefixed_Name(s4inma, "GTIN8ID") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:isCreatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Item is created in an ItemBatch.</para>
    /// labels<para>is created in</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/isCreatedIn">https://saref.etsi.org/saref4inma/isCreatedIn</seealso>
    let isCreatedIn = Prefixed_Name(s4inma, "isCreatedIn") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:ItemBatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A uniform collection of tangible objects which are relevant for the prodcution process. The ItemBatch consists of a set of objects with similar properties (e.g. a certain type of sensors or metal sheets). The difference between ItemBatch and MaterialBatch is that individual items can be traced in a ItemBatch, whereas this is not possible in a MaterialBatch, meaning that, for example, it is possible to trace the individual metal sheet used in a ItemBatch. This implies that the objects in an ItemBatch have an unique identifier (e.g. a GTIN code in the form of a barcode/QR-code or RFID tag).</para>
    /// labels<para>Item Batch</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ItemBatch">https://saref.etsi.org/saref4inma/ItemBatch</seealso>
    let ItemBatch = Prefixed_Name(s4inma, "ItemBatch") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:creates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a production process (e.g., Batch) that creates one or more tangible objects (e.g., Items)</para>
    /// labels<para>creates</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/creates">https://saref.etsi.org/saref4inma/creates</seealso>
    let creates = Prefixed_Name(s4inma, "creates") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasUpdate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The newer version of a ItemCategory.</para>
    /// labels<para>has update</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasUpdate">https://saref.etsi.org/saref4inma/hasUpdate</seealso>
    let hasUpdate = Prefixed_Name(s4inma, "hasUpdate") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasModelNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A relation to express the model number of a certain object (item, product, equipment, etc.) </para>
    /// labels<para>has model number</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasModelNumber">https://saref.etsi.org/saref4inma/hasModelNumber</seealso>
    let hasModelNumber = Prefixed_Name(s4inma, "hasModelNumber") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:ProductionEquipmentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ProductionEquipmentCategory represents a certain type of production equipment, which is generally static over time. More concretely, the ProductionEquipmentCategory represents a certain model and brand of a production equipment. Each ProductionEquipmentCategory can have multiple related ProductionEquipment, which represent the actual individual machines. Moreover, each ItemCategory can be produced by multiple ProductionEquipmentCategories.</para>
    /// labels<para>Production equipment category</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/ProductionEquipmentCategory">https://saref.etsi.org/saref4inma/ProductionEquipmentCategory</seealso>
    let ProductionEquipmentCategory =
        Prefixed_Name(s4inma, "ProductionEquipmentCategory") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:hasVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An item has a certain revision or version number, whereas a higher number indicates a newer version.</para>
    /// labels<para>has version</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasVersion">https://saref.etsi.org/saref4inma/hasVersion</seealso>
    let hasVersion = Prefixed_Name(s4inma, "hasVersion") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:isCategoryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link between a category and its associated entity</para>
    /// labels<para>is category of</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/isCategoryOf">https://saref.etsi.org/saref4inma/isCategoryOf</seealso>
    let isCategoryOf = Prefixed_Name(s4inma, "isCategoryOf") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:MaterialBatch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A uniform collection of tangible raw material which are relevant for the prodcution process. The MaterialBatch can consists of a set of objects with similar properties (e.g. a certain type of screws) or a stock of homogeen material (e.g. oil, water). The difference between MaterialBatch and ItemBatch is that individual items cannot be traced in a MaterialBatch, whereas this is possible in an ItemBatch, meaning that, for example, it is not possible to trace the individual screw used in a MaterialBatch.</para>
    /// labels<para>Material Batch</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/MaterialBatch">https://saref.etsi.org/saref4inma/MaterialBatch</seealso>
    let MaterialBatch = Prefixed_Name(s4inma, "MaterialBatch") |> PrefixedName
    /// <summary>
    ///   <para>s4inma:hasCertificate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The MaterialBatch can contain material quality certificates, for example a NEN 10204:2004 3.1 steel certificate.</para>
    /// labels<para>has certificate</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasCertificate">https://saref.etsi.org/saref4inma/hasCertificate</seealso>
    let hasCertificate = Prefixed_Name(s4inma, "hasCertificate") |> PrefixedName

    /// <summary>
    ///   <para>s4inma:hasFeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a feature of interest and equipment</para>
    /// labels<para>has feature of interest</para></remarks>
    /// <seealso href="https://saref.etsi.org/saref4inma/hasFeatureOfInterest">https://saref.etsi.org/saref4inma/hasFeatureOfInterest</seealso>
    let hasFeatureOfInterest =
        Prefixed_Name(s4inma, "hasFeatureOfInterest") |> PrefixedName
