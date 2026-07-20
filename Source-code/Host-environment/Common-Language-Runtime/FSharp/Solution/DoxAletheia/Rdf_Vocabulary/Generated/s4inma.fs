namespace https.saref.etsi.org.saref4inma.slash

open DoxAletheia

module s4inma =
    let _namespace_name = "https://saref.etsi.org/saref4inma/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, areas are physical, geographical or logical groupings of resources determined by the site. A site can be divided in areas, whereas areas contain work centers.s.
    /// <see href="https://saref.etsi.org/saref4inma/Area"></see></summary>
    let Area = _prefix "Area"
    /// <summary>
    /// A subclass of s4bldg:BuildingSpace used to define the physical spaces of the building. According to IEC 62264, sites are identified physical, geographical, and/or logical component groupings of a manufacturing enterprise. A factory can be divided in sites, whereas sites can be divided areas
    /// <see href="https://saref.etsi.org/saref4inma/Site"></see></summary>
    let Site = _prefix "Site"
    /// <summary>
    /// A subclass of s4inma:ProductionEquipment (and therefore of s4bld:PhysicalObject). It is an equipment element under an area in a role-based equipment hierarchy that performs production, storage or material movement (definition taken from IEC 62264). An Area contains work centers.
    /// <see href="https://saref.etsi.org/saref4inma/WorkCenter"></see></summary>
    let WorkCenter = _prefix "WorkCenter"
    /// <summary>
    ///   <see href="https://saref.etsi.org/saref4inma/v1.1.2/"></see>
    /// </summary>
    let ``v1.1.2/`` = _prefix "v1.1.2/"
    /// <summary>
    /// Describes whether the measurement is actually measured during the production process. Disjoint with ExpectedMeasurement.
    /// <see href="https://saref.etsi.org/saref4inma/ActualMeasurement"></see></summary>
    let ActualMeasurement = _prefix "ActualMeasurement"
    /// <summary>
    /// A subclass of saref:Measurement that represents the measured value made over a property. It is also linked to the unit of measure in which the value is expressed and the timestamp of the measurement. The saref4imna:Measurement can be linked to individual Batches or Items. Moreover, the Measurement can be an ExpectedMeasurement (i.e. the value which is planned) or the ActualMeasurement (i.e. the value measured during production), which enables to check for deviations between the planned and actual values.
    /// <see href="https://saref.etsi.org/saref4inma/Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// Describes whether the measurement is expected (i.e., planned before the production process). Disjoint with ActualMeasurement.
    /// <see href="https://saref.etsi.org/saref4inma/ExpectedMeasurement"></see></summary>
    let ExpectedMeasurement = _prefix "ExpectedMeasurement"
    /// <summary>
    /// A uniform collection of tangible objects or Lot. This can either be a collection of produced items (i.e. the outflow of products) or a collection of raw material or required material (i.e. the inflow of products). It is assumed that the objects in a batch are similar and thus have shared attributes. Note that this definition is broader than the definition in IEC 61512, which defines a batch as the material that is being produced (whereas in SAREF4INMA a batch can be items or materials).
    /// <see href="https://saref.etsi.org/saref4inma/Batch"></see></summary>
    let Batch = _prefix "Batch"
    /// <summary>
    /// A relation to express that a batch can recursively consists of other batches
    /// <see href="https://saref.etsi.org/saref4inma/consistsOfBatch"></see></summary>
    let consistsOfBatch = _prefix "consistsOfBatch"
    /// <summary>
    /// link between an entity and its unique identifier
    /// <see href="https://saref.etsi.org/saref4inma/hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    /// A unique identifier.
    /// <see href="https://saref.etsi.org/saref4inma/ID"></see></summary>
    let ID = _prefix "ID"
    /// <summary>
    /// A relationship to count the amount of certain objects in a collection (e.g., size of a material batch)
    /// <see href="https://saref.etsi.org/saref4inma/hasSize"></see></summary>
    let hasSize = _prefix "hasSize"
    /// <summary>
    /// The amount of certain objects in a collection (e.g., size of a material batch).
    /// <see href="https://saref.etsi.org/saref4inma/Size"></see></summary>
    let Size = _prefix "Size"
    /// <summary>
    /// Relationship between a feature of interest and equipment
    /// <see href="https://saref.etsi.org/saref4inma/isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf = _prefix "isFeatureOfInterestOf"
    /// <summary>
    /// A relationship indicating that an entity needs a particular equipment to be produced
    /// <see href="https://saref.etsi.org/saref4inma/needsEquipment"></see></summary>
    let needsEquipment = _prefix "needsEquipment"
    /// <summary>
    /// A production equipment is a specialization of a saref:Device and s4bldg:PhysicalObject that can produce items in a manufacturing process. This class represents an individual production equipment device and includes their specification in terms of functions, states and services. Different types of machines can be defined under this class as needed, for example, LaserCuttingMachine (i.e., a type of production equipment to cut steel material), MillingMachine (i.e., to drill holes in steel material), MouldingMachine (i.e., to mold liquid material, such as iron or plastic, and let it harden in a certain shape), WeldingMachine (i.e., join parts of material, such as steel, together), etc.
    /// <see href="https://saref.etsi.org/saref4inma/ProductionEquipment"></see></summary>
    let ProductionEquipment = _prefix "ProductionEquipment"
    /// <summary>
    /// A subclass of s4bldg:Building specialized for the purpose of SAREF4INMA, a factory represents one or more organizations sharing a definit mission, goals and objectives which provides an output such as a product (definition taken from IEC 62264). A factory can be divided in one or multiple sites.
    /// <see href="https://saref.etsi.org/saref4inma/Factory"></see></summary>
    let Factory = _prefix "Factory"
    /// <summary>
    /// GTIN-12 (UPC-A) is a 12-digit number used primarily in North America
    /// <see href="https://saref.etsi.org/saref4inma/GTIN12ID"></see></summary>
    let GTIN12ID = _prefix "GTIN12ID"
    /// <summary>
    /// GTIN-13 (EAN/UCC-13) is a 13-digit number used predominately outside of North America
    /// <see href="https://saref.etsi.org/saref4inma/GTIN13ID"></see></summary>
    let GTIN13ID = _prefix "GTIN13ID"
    /// <summary>
    /// GTIN-14 (EAN/UCC-14 or ITF-14 or also known as ITF Symbol, SCC-14, DUN-14, UPC Case Code, UPC Shipping Container Code, UCC Code 128, EAN Code 128) is a 14-digit number used to identify trade items at various packaging levels.
    /// <see href="https://saref.etsi.org/saref4inma/GTIN14ID"></see></summary>
    let GTIN14ID = _prefix "GTIN14ID"
    /// <summary>
    /// GTIN-8 (EAN/UCC-8) is an 8-digit number used predominately outside of North America.
    /// <see href="https://saref.etsi.org/saref4inma/GTIN8ID"></see></summary>
    let GTIN8ID = _prefix "GTIN8ID"
    /// <summary>
    /// A relation to express the value of an indentifier as a string (it can be used as alternative to or in combination with the s4inma:hasIdentifier object property
    /// <see href="https://saref.etsi.org/saref4inma/hasIDValue"></see></summary>
    let hasIDValue = _prefix "hasIDValue"
    /// <summary>
    /// International Registration Data Identifier (IRDI) is based on the international standards ISO/IEC 11179-6, ISO 29002 and ISO 6532 and used in eCl@ss and the Asset Administration Shell as unique identifier.
    /// <see href="https://saref.etsi.org/saref4inma/IRDI"></see></summary>
    let IRDI = _prefix "IRDI"
    /// <summary>
    /// A tangible object which can be unique identified, for example, with a GTIN in the form of a barcode/QR/RFID tag. An item product can be the result of the organization's production process (i.e. outflow of objects/goods) or can be uniquely identifiable material (i.e. inflow of objects/supplies). Each item is part of exactly one ItemBatch, whereas each ItemBatch contains only Items which have similar properties. An item can consists of multiple Batches and other Items (i.e. subassemblies).
    /// <see href="https://saref.etsi.org/saref4inma/Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// An Item is created in an ItemBatch.
    /// <see href="https://saref.etsi.org/saref4inma/isCreatedIn"></see></summary>
    let isCreatedIn = _prefix "isCreatedIn"
    /// <summary>
    /// A uniform collection of tangible objects which are relevant for the prodcution process. The ItemBatch consists of a set of objects with similar properties (e.g. a certain type of sensors or metal sheets). The difference between ItemBatch and MaterialBatch is that individual items can be traced in a ItemBatch, whereas this is not possible in a MaterialBatch, meaning that, for example, it is possible to trace the individual metal sheet used in a ItemBatch. This implies that the objects in an ItemBatch have an unique identifier (e.g. a GTIN code in the form of a barcode/QR-code or RFID tag).
    /// <see href="https://saref.etsi.org/saref4inma/ItemBatch"></see></summary>
    let ItemBatch = _prefix "ItemBatch"
    /// <summary>
    /// A relation to describe the serial number of a certain Item, which is unique per Item.
    /// <see href="https://saref.etsi.org/saref4inma/hasSerialNumber"></see></summary>
    let hasSerialNumber = _prefix "hasSerialNumber"
    /// <summary>
    /// A relation to express that an item can recursively consists of other Items
    /// <see href="https://saref.etsi.org/saref4inma/consistsOfItem"></see></summary>
    let consistsOfItem = _prefix "consistsOfItem"
    /// <summary>
    /// Link between an entity and its category
    /// <see href="https://saref.etsi.org/saref4inma/belongsToCategory"></see></summary>
    let belongsToCategory = _prefix "belongsToCategory"
    /// <summary>
    /// An ItemCategory describes a single type of item in terms of its static properties. Each ItemCategory can have multiple related ItemBatches, which all contain individual Items. The essential properties of each Item in all ItemBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of all Items related to an ItemCategory are similar.
    /// <see href="https://saref.etsi.org/saref4inma/ItemCategory"></see></summary>
    let ItemCategory = _prefix "ItemCategory"
    /// <summary>
    /// A relation between a production process (e.g., Batch) that creates one or more tangible objects (e.g., Items)
    /// <see href="https://saref.etsi.org/saref4inma/creates"></see></summary>
    let creates = _prefix "creates"
    /// <summary>
    /// The newer version of a ItemCategory.
    /// <see href="https://saref.etsi.org/saref4inma/hasUpdate"></see></summary>
    let hasUpdate = _prefix "hasUpdate"
    /// <summary>
    /// A relation to express the model number of a certain object (item, product, equipment, etc.)
    /// <see href="https://saref.etsi.org/saref4inma/hasModelNumber"></see></summary>
    let hasModelNumber = _prefix "hasModelNumber"
    /// <summary>
    /// Items are produced using certain types of ProductionEquipmentCategories, for example: welding machines or laser cutting machines.
    /// <see href="https://saref.etsi.org/saref4inma/isProducedBy"></see></summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    /// A ProductionEquipmentCategory represents a certain type of production equipment, which is generally static over time. More concretely, the ProductionEquipmentCategory represents a certain model and brand of a production equipment. Each ProductionEquipmentCategory can have multiple related ProductionEquipment, which represent the actual individual machines. Moreover, each ItemCategory can be produced by multiple ProductionEquipmentCategories.
    /// <see href="https://saref.etsi.org/saref4inma/ProductionEquipmentCategory"></see></summary>
    let ProductionEquipmentCategory = _prefix "ProductionEquipmentCategory"
    /// <summary>
    /// An item has a certain revision or version number, whereas a higher number indicates a newer version.
    /// <see href="https://saref.etsi.org/saref4inma/hasVersion"></see></summary>
    let hasVersion = _prefix "hasVersion"
    /// <summary>
    /// Link between a category and its associated entity
    /// <see href="https://saref.etsi.org/saref4inma/isCategoryOf"></see></summary>
    let isCategoryOf = _prefix "isCategoryOf"
    /// <summary>
    /// A uniform collection of tangible raw material which are relevant for the prodcution process. The MaterialBatch can consists of a set of objects with similar properties (e.g. a certain type of screws) or a stock of homogeen material (e.g. oil, water). The difference between MaterialBatch and ItemBatch is that individual items cannot be traced in a MaterialBatch, whereas this is possible in an ItemBatch, meaning that, for example, it is not possible to trace the individual screw used in a MaterialBatch.
    /// <see href="https://saref.etsi.org/saref4inma/MaterialBatch"></see></summary>
    let MaterialBatch = _prefix "MaterialBatch"
    /// <summary>
    /// A MaterialCategory describes a category of material in terms of its static properties. Examples are: a certain category of steel or plastic. Each MaterialCategory can have multiple related MaterialBatches, which represent the physical material. The essential properties of the material in all MaterialBatches are the same. However, each batch might use different MaterialBatches and/or different ProductionEquipment. Therefore, small deviations between batches might occur, while the essential properties of the material related to an MaterialCategory are similar.
    /// <see href="https://saref.etsi.org/saref4inma/MaterialCategory"></see></summary>
    let MaterialCategory = _prefix "MaterialCategory"
    /// <summary>
    /// The MaterialBatch can contain material quality certificates, for example a NEN 10204:2004 3.1 steel certificate.
    /// <see href="https://saref.etsi.org/saref4inma/hasCertificate"></see></summary>
    let hasCertificate = _prefix "hasCertificate"
    /// <summary>
    /// Relationship between a feature of interest and equipment
    /// <see href="https://saref.etsi.org/saref4inma/hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest = _prefix "hasFeatureOfInterest"
    /// <summary>
    /// Functionallity neccessary to accomplish the task for which a production equipment is designed.
    /// <see href="https://saref.etsi.org/saref4inma/ProductionEquipmentFunction"></see></summary>
    let ProductionEquipmentFunction = _prefix "ProductionEquipmentFunction"
    /// <summary>
    /// A universally unique identifier (UUID) is a 128-bit number used to identify items and is also known as: globally unique identifier (GUID). In its canonical textual representation, the sixteen octets of a UUID are represented as 32 hexadecimal (base 16) digits, displayed in five groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters (32 alphanumeric characters and four hyphens). UUID are documented in ISO/IEC 11578:1996 "Information technology – Open Systems Interconnection – Remote Procedure Call (RPC)" and in ITU-T Rec. X.667 | ISO/IEC 9834-8:2005.
    /// <see href="https://saref.etsi.org/saref4inma/UUID"></see></summary>
    let UUID = _prefix "UUID"
    /// <summary>
    /// A relationship determining the  GTIN-12 identifier
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN12ID"></see></summary>
    let hasGTIN12ID = _prefix "hasGTIN12ID"
    /// <summary>
    /// A relation to express the value of an GTIN12 as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN12IDValue"></see></summary>
    let hasGTIN12IDValue = _prefix "hasGTIN12IDValue"
    /// <summary>
    /// A relationship determining the  GTIN-13 identifier
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN13ID"></see></summary>
    let hasGTIN13ID = _prefix "hasGTIN13ID"
    /// <summary>
    /// A relation to express the value of an GTIN13 as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN13IDValue"></see></summary>
    let hasGTIN13IDValue = _prefix "hasGTIN13IDValue"
    /// <summary>
    /// A relationship determining the  GTIN-14 identifier
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN14ID"></see></summary>
    let hasGTIN14ID = _prefix "hasGTIN14ID"
    /// <summary>
    /// A relation to express the value of an GTIN14 as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN14IDValue"></see></summary>
    let hasGTIN14IDValue = _prefix "hasGTIN14IDValue"
    /// <summary>
    /// A relationship determining the  GTIN-8 identifier
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN8ID"></see></summary>
    let hasGTIN8ID = _prefix "hasGTIN8ID"
    /// <summary>
    /// A relation to express the value of an GTIN8 as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasGTIN8IDValue"></see></summary>
    let hasGTIN8IDValue = _prefix "hasGTIN8IDValue"
    /// <summary>
    /// A relationship determining the  International Registration Data Identifier (IRDI)
    /// <see href="https://saref.etsi.org/saref4inma/hasIRDI"></see></summary>
    let hasIRDI = _prefix "hasIRDI"
    /// <summary>
    /// A relation to express the value of an IRDI as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasIRDIValue"></see></summary>
    let hasIRDIValue = _prefix "hasIRDIValue"
    /// <summary>
    /// A relationship determining the Universally Unique Identifier (UUID)
    /// <see href="https://saref.etsi.org/saref4inma/hasUUID"></see></summary>
    let hasUUID = _prefix "hasUUID"
    /// <summary>
    /// A relation to express the value of an UUID as a string
    /// <see href="https://saref.etsi.org/saref4inma/hasUUIDValue"></see></summary>
    let hasUUIDValue = _prefix "hasUUIDValue"
    /// <summary>
    /// ProductionEquipmentCategory, such as welding machines or laser cutting machines, produce certain categories of items (inverse of s4inma:isProducedBy)
    /// <see href="https://saref.etsi.org/saref4inma/produces"></see></summary>
    let produces = _prefix "produces"
