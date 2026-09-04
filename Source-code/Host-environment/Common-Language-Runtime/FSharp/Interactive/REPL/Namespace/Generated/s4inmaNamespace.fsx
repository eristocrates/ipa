#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module s4inma =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4inma/" "s4inma"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actual measurement</para>
    ///   <para>rdfs:comment : Describes whether the measurement is actually measured during the production process. Disjoint with ExpectedMeasurement.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ActualMeasurement">s4inma:ActualMeasurement</a>
    /// </summary>
    let ActualMeasurement = _prefixId.prefix "ActualMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Area</para>
    ///   <para>rdfs:comment : A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, areas are physical, geographical or logical groupings of resources determined by the site. A site can be divided in areas, whereas areas contain work centers.s.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Area">s4inma:Area</a>
    /// </summary>
    let Area = _prefixId.prefix "Area"
    /// <summary>
    ///   <para>rdfs:label : Batch</para>
    ///   <para>rdfs:comment : A uniform collection of tangible objects or Lot. This can either be a collection of produced items (i.e. the outflow of products) or a collection of raw material or required material (i.e. the inflow of products). It is assumed that the objects in a batch are similar and thus have shared attributes. Note that this definition is broader than the definition in IEC 61512, which defines a batch as the material that is being produced (whereas in SAREF4INMA a batch can be items or materials). ^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Batch">s4inma:Batch</a>
    /// </summary>
    let Batch = _prefixId.prefix "Batch"
    /// <summary>
    ///   <para>rdfs:label : Expected measurement</para>
    ///   <para>rdfs:comment : Describes whether the measurement is expected (i.e., planned before the production process). Disjoint with ActualMeasurement.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ExpectedMeasurement">s4inma:ExpectedMeasurement</a>
    /// </summary>
    let ExpectedMeasurement = _prefixId.prefix "ExpectedMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Factory</para>
    ///   <para>rdfs:comment : A subclass of s4bldg:Building specialized for the purpose of SAREF4INMA, a factory represents one or more organizations sharing a definit mission, goals and objectives which provides an output such as a product (definition taken from IEC 62264). A factory can be divided in one or multiple sites. ^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Factory">s4inma:Factory</a>
    /// </summary>
    let Factory = _prefixId.prefix "Factory"
    /// <summary>
    ///   <para>rdfs:label : GTIN12ID</para>
    ///   <para>rdfs:comment : GTIN-12 (UPC-A) is a 12-digit number used primarily in North America^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/GTIN12ID">s4inma:GTIN12ID</a>
    /// </summary>
    let GTIN12ID = _prefixId.prefix "GTIN12ID"
    /// <summary>
    ///   <para>rdfs:label : GTIN13ID</para>
    ///   <para>rdfs:comment : GTIN-13 (EAN/UCC-13) is a 13-digit number used predominately outside of North America^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/GTIN13ID">s4inma:GTIN13ID</a>
    /// </summary>
    let GTIN13ID = _prefixId.prefix "GTIN13ID"
    /// <summary>
    ///   <para>rdfs:label : GTIN14ID</para>
    ///   <para>rdfs:comment : GTIN-14 (EAN/UCC-14 or ITF-14 or also known as ITF Symbol, SCC-14, DUN-14, UPC Case Code, UPC Shipping Container Code, UCC Code 128, EAN Code 128) is a 14-digit number used to identify trade items at various packaging levels.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/GTIN14ID">s4inma:GTIN14ID</a>
    /// </summary>
    let GTIN14ID = _prefixId.prefix "GTIN14ID"
    /// <summary>
    ///   <para>rdfs:label : GTIN18ID</para>
    ///   <para>rdfs:comment : GTIN-8 (EAN/UCC-8) is an 8-digit number used predominately outside of North America.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/GTIN8ID">s4inma:GTIN8ID</a>
    /// </summary>
    let GTIN8ID = _prefixId.prefix "GTIN8ID"
    /// <summary>
    ///   <para>rdfs:label : Identifier</para>
    ///   <para>rdfs:comment : A unique identifier.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ID">s4inma:ID</a>
    /// </summary>
    let ID = _prefixId.prefix "ID"
    /// <summary>
    ///   <para>rdfs:label : IRDI</para>
    ///   <para>rdfs:comment : International Registration Data Identifier (IRDI) is based on the international standards ISO/IEC 11179-6, ISO 29002 and ISO 6532 and used in eCl@ss and the Asset Administration Shell as unique identifier.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/IRDI">s4inma:IRDI</a>
    /// </summary>
    let IRDI = _prefixId.prefix "IRDI"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : A tangible object which can be unique identified, for example, with a GTIN in the form of a barcode/QR/RFID tag. An item product can be the result of the organization's production process (i.e. outflow of objects/goods) or can be uniquely identifiable material (i.e. inflow of objects/supplies). Each item is part of exactly one ItemBatch, whereas each ItemBatch contains only Items which have similar properties. An item can consists of multiple Batches and other Items (i.e. subassemblies).^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Item">s4inma:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Item Batch</para>
    ///   <para>rdfs:comment : A uniform collection of tangible objects which are relevant for the prodcution process. The ItemBatch consists of a set of objects with similar properties (e.g. a certain type of sensors or metal sheets). The difference between ItemBatch and MaterialBatch is that individual items can be traced in a ItemBatch, whereas this is not possible in a MaterialBatch, meaning that, for example, it is possible to trace the individual metal sheet used in a ItemBatch. This implies that the objects in an ItemBatch have an unique identifier (e.g. a GTIN code in the form of a barcode/QR-code or RFID tag).^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ItemBatch">s4inma:ItemBatch</a>
    /// </summary>
    let ItemBatch = _prefixId.prefix "ItemBatch"
    /// <summary>
    ///   <para>rdfs:label : Item category</para>
    ///   <para>rdfs:comment : An ItemCategory describes a single type of item in terms of its static properties. Each ItemCategory can have multiple related ItemBatches, which all contain individual Items. The essential properties of each Item in all ItemBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of all Items related to an ItemCategory are similar.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ItemCategory">s4inma:ItemCategory</a>
    /// </summary>
    let ItemCategory = _prefixId.prefix "ItemCategory"
    /// <summary>
    ///   <para>rdfs:label : Material Batch</para>
    ///   <para>rdfs:comment : A uniform collection of tangible raw material which are relevant for the prodcution process. The MaterialBatch can consists of a set of objects with similar properties (e.g. a certain type of screws) or a stock of homogeen material (e.g. oil, water). The difference between MaterialBatch and ItemBatch is that individual items cannot be traced in a MaterialBatch, whereas this is possible in an ItemBatch, meaning that, for example, it is not possible to trace the individual screw used in a MaterialBatch.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/MaterialBatch">s4inma:MaterialBatch</a>
    /// </summary>
    let MaterialBatch = _prefixId.prefix "MaterialBatch"
    /// <summary>
    ///   <para>rdfs:label : Material category</para>
    ///   <para>rdfs:comment : A MaterialCategory describes a category of material in terms of its static properties. Examples are: a certain category of steel or plastic. Each MaterialCategory can have multiple related MaterialBatches, which represent the physical material. The essential properties of the material in all MaterialBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of the material related to an MaterialCategory are similar.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/MaterialCategory">s4inma:MaterialCategory</a>
    /// </summary>
    let MaterialCategory = _prefixId.prefix "MaterialCategory"
    /// <summary>
    ///   <para>rdfs:label : Measurement</para>
    ///   <para>rdfs:comment : A subclass of saref:Measurement that represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement. The saref4imna:Measurement can be linked to individual Batches or Items. Moreover, the Measurement can be an ExpectedMeasurement (i.e. the value which is planned) or the ActualMeasurement (i.e. the value measured during production), which enables to check for deviations between the planned and actual values.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Measurement">s4inma:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : ProductionEquipment</para>
    ///   <para>rdfs:comment : A production equipment is a specialization of a saref:Device and s4bldg:PhysicalObject that can produce items in a manufacturing process. This class represents an individual production equipment device and includes their specification in terms of functions, states and services. Different types of machines can be defined under this class as needed, for example, LaserCuttingMachine (i.e., a type of production equipment to cut steel material), MillingMachine (i.e., to drill holes in steel material), MouldingMachine (i.e., to mold liquid material, such as iron or plastic, and let it harden in a certain shape), WeldingMachine (i.e., join parts of material, such as steel, together), etc.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ProductionEquipment">s4inma:ProductionEquipment</a>
    /// </summary>
    let ProductionEquipment = _prefixId.prefix "ProductionEquipment"
    /// <summary>
    ///   <para>rdfs:label : Production equipment category</para>
    ///   <para>rdfs:comment : A ProductionEquipmentCategory represents a certain type of production equipment, which is generally static over time. More concretely, the ProductionEquipmentCategory represents a certain model and brand of a production equipment. Each ProductionEquipmentCategory can have multiple related ProductionEquipment, which represent the actual individual machines. Moreover, each ItemCategory can be produced by multiple ProductionEquipmentCategories.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ProductionEquipmentCategory">s4inma:ProductionEquipmentCategory</a>
    /// </summary>
    let ProductionEquipmentCategory = _prefixId.prefix "ProductionEquipmentCategory"
    /// <summary>
    ///   <para>rdfs:label : Production equipment function</para>
    ///   <para>rdfs:comment : Functionallity neccessary to accomplish the task for which a production equipment is designed.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/ProductionEquipmentFunction">s4inma:ProductionEquipmentFunction</a>
    /// </summary>
    let ProductionEquipmentFunction = _prefixId.prefix "ProductionEquipmentFunction"
    /// <summary>
    ///   <para>rdfs:label : Site</para>
    ///   <para>rdfs:comment : A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, sites are identified physical, geographical, and/or logical component groupings of a manufacturing enterprise. A factory can be divided in sites, whereas sites can be divided areas^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Site">s4inma:Site</a>
    /// </summary>
    let Site = _prefixId.prefix "Site"
    /// <summary>
    ///   <para>rdfs:label : Size</para>
    ///   <para>rdfs:comment : The amount of certain objects in a collection (e.g., size of a material batch).^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/Size">s4inma:Size</a>
    /// </summary>
    let Size = _prefixId.prefix "Size"
    /// <summary>
    ///   <para>rdfs:label : UUID</para>
    ///   <para>rdfs:comment : A universally unique identifier (UUID) is a 128-bit number used to identify items and is also known as: globally unique identifier (GUID). In its canonical textual representation, the sixteen octets of a UUID are represented as 32 hexadecimal (base 16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 alphanumeric characters and four hyphens). UUID are documented in ISO/IEC 11578:1996 "Information technology – Open Systems Interconnection – Remote Procedure Call (RPC)" and in ITU-T Rec. X.667 | ISO/IEC 9834-8:2005.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/UUID">s4inma:UUID</a>
    /// </summary>
    let UUID = _prefixId.prefix "UUID"
    /// <summary>
    ///   <para>rdfs:label : Work center</para>
    ///   <para>rdfs:comment : A subclass of s4inma:ProductionEquipment (and therefore of s4bld:PhysicalObject). It is an equipment element under an area in a role-based equipment hierarchy that performs production, storage or material movement (definition taken from IEC 62264). An Area contains work centers.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/WorkCenter">s4inma:WorkCenter</a>
    /// </summary>
    let WorkCenter = _prefixId.prefix "WorkCenter"
    /// <summary>
    ///   <para>rdfs:label : belongs to category</para>
    ///   <para>rdfs:comment : Link between an entity and its category^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/belongsToCategory">s4inma:belongsToCategory</a>
    /// </summary>
    let belongsToCategory = _prefixId.prefix "belongsToCategory"
    /// <summary>
    ///   <para>rdfs:label : consists of batch</para>
    ///   <para>rdfs:comment : A relation to express that a batch can recursively consists of other batches^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/consistsOfBatch">s4inma:consistsOfBatch</a>
    /// </summary>
    let consistsOfBatch = _prefixId.prefix "consistsOfBatch"
    /// <summary>
    ///   <para>rdfs:label : consists of item</para>
    ///   <para>rdfs:comment : A relation to express that an item can recursively consists of other Items^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/consistsOfItem">s4inma:consistsOfItem</a>
    /// </summary>
    let consistsOfItem = _prefixId.prefix "consistsOfItem"
    /// <summary>
    ///   <para>rdfs:label : creates</para>
    ///   <para>rdfs:comment : A relation between a production process (e.g., Batch) that creates one or more tangible objects (e.g., Items)^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/creates">s4inma:creates</a>
    /// </summary>
    let creates = _prefixId.prefix "creates"
    /// <summary>
    ///   <para>rdfs:label : has certificate</para>
    ///   <para>rdfs:comment : The MaterialBatch can contain material quality certificates, for example a NEN 10204:2004 3.1 steel certificate.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasCertificate">s4inma:hasCertificate</a>
    /// </summary>
    let hasCertificate = _prefixId.prefix "hasCertificate"
    /// <summary>
    ///   <para>rdfs:label : has feature of interest</para>
    ///   <para>rdfs:comment : Relationship between a feature of interest and equipment^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasFeatureOfInterest">s4inma:hasFeatureOfInterest</a>
    /// </summary>
    let hasFeatureOfInterest = _prefixId.prefix "hasFeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : has GTIN12ID </para>
    ///   <para>rdfs:comment : A relationship determining the  GTIN-12 identifier^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN12ID">s4inma:hasGTIN12ID</a>
    /// </summary>
    let hasGTIN12ID = _prefixId.prefix "hasGTIN12ID"
    /// <summary>
    ///   <para>rdfs:label : has GTIN12ID value</para>
    ///   <para>rdfs:comment : A relation to express the value of an GTIN12 as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN12IDValue">s4inma:hasGTIN12IDValue</a>
    /// </summary>
    let hasGTIN12IDValue = _prefixId.prefix "hasGTIN12IDValue"
    /// <summary>
    ///   <para>rdfs:label : has GTIN13ID</para>
    ///   <para>rdfs:comment : A relationship determining the  GTIN-13 identifier^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN13ID">s4inma:hasGTIN13ID</a>
    /// </summary>
    let hasGTIN13ID = _prefixId.prefix "hasGTIN13ID"
    /// <summary>
    ///   <para>rdfs:label : has GTIN13ID value</para>
    ///   <para>rdfs:comment : A relation to express the value of an GTIN13 as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN13IDValue">s4inma:hasGTIN13IDValue</a>
    /// </summary>
    let hasGTIN13IDValue = _prefixId.prefix "hasGTIN13IDValue"
    /// <summary>
    ///   <para>rdfs:label : has GTIN14ID</para>
    ///   <para>rdfs:comment : A relationship determining the  GTIN-14 identifier^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN14ID">s4inma:hasGTIN14ID</a>
    /// </summary>
    let hasGTIN14ID = _prefixId.prefix "hasGTIN14ID"
    /// <summary>
    ///   <para>rdfs:label : has GTIN14ID value</para>
    ///   <para>rdfs:comment : A relation to express the value of an GTIN14 as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN14IDValue">s4inma:hasGTIN14IDValue</a>
    /// </summary>
    let hasGTIN14IDValue = _prefixId.prefix "hasGTIN14IDValue"
    /// <summary>
    ///   <para>rdfs:label : has GTIN8ID</para>
    ///   <para>rdfs:comment : A relationship determining the  GTIN-8 identifier^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN8ID">s4inma:hasGTIN8ID</a>
    /// </summary>
    let hasGTIN8ID = _prefixId.prefix "hasGTIN8ID"
    /// <summary>
    ///   <para>rdfs:label : has GTIN8ID value</para>
    ///   <para>rdfs:comment : A relation to express the value of an GTIN8 as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasGTIN8IDValue">s4inma:hasGTIN8IDValue</a>
    /// </summary>
    let hasGTIN8IDValue = _prefixId.prefix "hasGTIN8IDValue"
    /// <summary>
    ///   <para>rdfs:label : has identifier value</para>
    ///   <para>rdfs:comment : A relation to express the value of an indentifier as a string (it can be used as alternative to or in combination with the s4inma:hasIdentifier object property^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasIDValue">s4inma:hasIDValue</a>
    /// </summary>
    let hasIDValue = _prefixId.prefix "hasIDValue"
    /// <summary>
    ///   <para>rdfs:label : has IRDI</para>
    ///   <para>rdfs:comment : A relationship determining the  International Registration Data Identifier (IRDI)^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasIRDI">s4inma:hasIRDI</a>
    /// </summary>
    let hasIRDI = _prefixId.prefix "hasIRDI"
    /// <summary>
    ///   <para>rdfs:label : has IRDI value</para>
    ///   <para>rdfs:comment : A relation to express the value of an IRDI as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasIRDIValue">s4inma:hasIRDIValue</a>
    /// </summary>
    let hasIRDIValue = _prefixId.prefix "hasIRDIValue"
    /// <summary>
    ///   <para>rdfs:label : has identifier</para>
    ///   <para>rdfs:comment : link between an entity and its unique identifier^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasIdentifier">s4inma:hasIdentifier</a>
    /// </summary>
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has model number</para>
    ///   <para>rdfs:comment : A relation to express the model number of a certain object (item, product, equipment, etc.) ^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasModelNumber">s4inma:hasModelNumber</a>
    /// </summary>
    let hasModelNumber = _prefixId.prefix "hasModelNumber"
    /// <summary>
    ///   <para>rdfs:label : has serial number</para>
    ///   <para>rdfs:comment : A relation to describe the serial number of a certain Item, which is unique per Item.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasSerialNumber">s4inma:hasSerialNumber</a>
    /// </summary>
    let hasSerialNumber = _prefixId.prefix "hasSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : has size</para>
    ///   <para>rdfs:comment : A relationship to count the amount of certain objects in a collection (e.g., size of a material batch)^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasSize">s4inma:hasSize</a>
    /// </summary>
    let hasSize = _prefixId.prefix "hasSize"
    /// <summary>
    ///   <para>rdfs:label : has UUID</para>
    ///   <para>rdfs:comment : A relationship determining the Universally Unique Identifier (UUID)^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasUUID">s4inma:hasUUID</a>
    /// </summary>
    let hasUUID = _prefixId.prefix "hasUUID"
    /// <summary>
    ///   <para>rdfs:label : has UUID value</para>
    ///   <para>rdfs:comment : A relation to express the value of an UUID as a string^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasUUIDValue">s4inma:hasUUIDValue</a>
    /// </summary>
    let hasUUIDValue = _prefixId.prefix "hasUUIDValue"
    /// <summary>
    ///   <para>rdfs:label : has update</para>
    ///   <para>rdfs:comment : The newer version of a ItemCategory.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasUpdate">s4inma:hasUpdate</a>
    /// </summary>
    let hasUpdate = _prefixId.prefix "hasUpdate"
    /// <summary>
    ///   <para>rdfs:label : has version</para>
    ///   <para>rdfs:comment : An item has a certain revision or version number, whereas a higher number indicates a newer version.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/hasVersion">s4inma:hasVersion</a>
    /// </summary>
    let hasVersion = _prefixId.prefix "hasVersion"
    /// <summary>
    ///   <para>rdfs:label : is category of</para>
    ///   <para>rdfs:comment : Link between a category and its associated entity^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/isCategoryOf">s4inma:isCategoryOf</a>
    /// </summary>
    let isCategoryOf = _prefixId.prefix "isCategoryOf"
    /// <summary>
    ///   <para>rdfs:label : is created in</para>
    ///   <para>rdfs:comment : An Item is created in an ItemBatch.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/isCreatedIn">s4inma:isCreatedIn</a>
    /// </summary>
    let isCreatedIn = _prefixId.prefix "isCreatedIn"
    /// <summary>
    ///   <para>rdfs:label : is feature of interest of</para>
    ///   <para>rdfs:comment : Relationship between a feature of interest and equipment^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/isFeatureOfInterestOf">s4inma:isFeatureOfInterestOf</a>
    /// </summary>
    let isFeatureOfInterestOf = _prefixId.prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <para>rdfs:label : is produced by</para>
    ///   <para>rdfs:comment : Items are produced using certain types of ProductionEquipmentCategories, for example: welding machines or laser cutting machines.^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/isProducedBy">s4inma:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>rdfs:label : needs equipment</para>
    ///   <para>rdfs:comment : A relationship indicating that an entity needs a particular equipment to be produced^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/needsEquipment">s4inma:needsEquipment</a>
    /// </summary>
    let needsEquipment = _prefixId.prefix "needsEquipment"
    /// <summary>
    ///   <para>rdfs:label : produces</para>
    ///   <para>rdfs:comment : ProductionEquipmentCategory, such as welding machines or laser cutting machines, produce certain categories of items (inverse of s4inma:isProducedBy)^^xsd:string</para>
    ///   <a href="https://saref.etsi.org/saref4inma/produces">s4inma:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
