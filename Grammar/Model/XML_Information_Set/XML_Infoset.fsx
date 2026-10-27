// just a sketch
// maybe treat unknown us unit and no value as None?
// https://www.w3.org/TR/xml-infoset/


type Information_Item = Option<string>
type URI = unit
type Character_Encoding_Scheme = unit
type Attribute_Type = unit
type Attribute_Reference = unit


/// There is exactly one document information item in the information set, and all other information items are accessible from the properties of the document information item, either directly or indirectly through the properties of other information items.
type Document_Information_Item =
    {

      /// An ordered list of child information items, in document order.
      ///  The list contains exactly one element information item.
      ///  The list also contains one processing instruction information item for each processing instruction outside the document element, and one comment information item for each comment outside the document element.
      ///  Processing instructions and comments within the DTD are excluded.
      ///  If there is a document type declaration, the list also contains a document type declaration information item.
      children: Element_Information_Item array
      /// The element information item corresponding to the document element.
      document_element: Element_Information_Item
      /// An unordered set of notation information items, one for each notation declared in the DTD.
      ///  If any notation is multiply declared, this property has no value.
      notations: Set<Notation_Information_Item>
      /// An unordered set of unparsed entity information items, one for each unparsed entity declared in the DTD.
      unparsed_entities: Set<Unparsed_Entity_Information_Item>
      /// The base URI of the document entity.
      base_URI: URI
      /// The name of the character encoding scheme in which the document entity is expressed.
      character_encoding_scheme: Character_Encoding_Scheme
      /// An indication of the standalone status of the document, either yes or no.
      ///  This property is derived from the optional standalone document declaration in the XML declaration at the beginning of the document entity, and has no value if there is no standalone document declaration.
      standalone: bool
      /// A string representing the XML version of the document.
      ///  This property is derived from the XML declaration optionally present at the beginning of the document entity, and has no value if there is no XML declaration.
      version: string
      /// This property is not strictly speaking part of the infoset of the document.
      ///  Rather it is an indication of whether the processor has read the complete DTD.
      ///  Its value is a boolean.
      ///  If it is false, then certain properties (indicated in their descriptions below) may be unknown.
      ///  If it is true, those properties are never unknown.
      all_declarations_processed: bool

     }

/// There is an element information item for each element appearing in the XML document.
///  One of the element information items is the value of the [document element] property of the document information item, corresponding to the root of the element tree, and all other element information items are accessible by recursively following its [children] property.
and Element_Information_Item =
    { ///  The namespace name, if any, of the element type.
      ///  If the element does not belong to a namespace, this property has no value.
      namespace_name: string option
      ///  The local part of the element-type name.
      ///  This does not include any namespace prefix or following colon.
      local_name: string
      ///  The namespace prefix part of the element-type name.
      ///  If the name is unprefixed, this property has no value.
      ///  Note that namespace-aware applications should use the namespace name rather than the prefix to identify elements.
      prefix: string option
      ///  An ordered list of child information items, in document order.
      ///  This list contains element, processing instruction, unexpanded entity reference, character, and comment information items, one for each element, processing instruction, reference to an unprocessed external entity, data character, and comment appearing immediately within the current element.
      ///  If the element is empty, this list has no members.
      children: Information_Item array

      ///  An unordered set of attribute information items, one for each of the attributes (specified or defaulted from the DTD) of this element.
      ///  Namespace declarations do not appear in this set.
      ///  If the element has no attributes, this set has no members.
      ///
      attributes: Set<Attribute_Information_Item>
      ///  An unordered set of attribute information items, one for each of the namespace declarations (specified or defaulted from the DTD) of this element.
      ///  Declarations of the form xmlns="" and xmlns:name="", which undeclare the default namespace and prefixes respectively, count as namespace declarations.
      ///  Prefix undeclaration was added in Namespaces in XML 1.
      /// 1.
      ///  By definition, all namespace attributes (including those named xmlns, whose [prefix] property has no value) have a namespace URI of http://www.
      /// w3.
      /// org/2000/xmlns/.
      ///  If the element has no namespace declarations, this set has no members.
      namespace_attributes: Set<Attribute_Information_Item>
      ///  An unordered set of namespace information items, one for each of the namespaces in effect for this element.
      ///  This set always contains an item with the prefix xml which is implicitly bound to the namespace name http://www.
      /// w3.
      /// org/XML/1998/namespace.
      ///  It does not contain an item with the prefix xmlns (used for declaring namespaces), since an application can never encounter an element or attribute with that prefix.
      ///  The set will include namespace items corresponding to all of the members of [namespace attributes], except for any representing declarations of the form xmlns="" or xmlns:name="", which do not declare a namespace but rather undeclare the default namespace and prefixes.
      ///  When resolving the prefixes of qualified names this property should be used in preference to the [namespace attributes] property; they may be inconsistent in the case of Synthetic Infosets.
      in_scope_namespaces: Set<Namespace_Information_Item>
      ///  The base URI of the element.
      base_URI: URI
      ///  The document or element information item which contains this information item in its [children] property.
      parent: Information_Item

     }

/// There is an attribute information item for each attribute (specified or defaulted) of each element in the document, including those which are namespace declarations.
///  The latter however appear as members of an element's [namespace attributes] property rather than its [attributes] property.
/// Attributes declared in the DTD with no default value and not specified in the element's start tag are not represented by attribute information items.
and Attribute_Information_Item =
    { ///  The namespace name, if any, of the element type.
      ///  If the element does not belong to a namespace, this property has no value.
      namespace_name: string option
      ///  The local part of the element-type name.
      ///  This does not include any namespace prefix or following colon.
      local_name: string
      ///  The namespace prefix part of the element-type name.
      ///  If the name is unprefixed, this property has no value.
      ///  Note that namespace-aware applications should use the namespace name rather than the prefix to identify elements.
      prefix: string option
      ///  The normalized attribute value (see 3.3.3 Attribute-Value Normalization [XML]).
      normalized_value: string
      ///  A flag indicating whether this attribute was actually specified in the start-tag of its element, or was defaulted from the DTD.
      specified: bool
      ///  An indication of the type declared for this attribute in the DTD.
      ///  Legitimate values are ID, IDREF, IDREFS, ENTITY, ENTITIES, NMTOKEN, NMTOKENS, NOTATION, CDATA, and ENUMERATION.
      ///  If there is no declaration for the attribute, this property has no value.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown.
      ///  Applications should treat no value and unknown as equivalent to a value of CDATA.
      ///  The value of this property is not affected by the validity of the attribute value.
      attribute_type: Attribute_Type
      ///  If the attribute type is ID, NMTOKEN, NMTOKENS, CDATA, or ENUMERATION, this property has no value.
      ///  If the attribute type is unknown, the value of this property is unknown.
      ///  Otherwise (that is, if the attribute type is IDREF, IDREFS, ENTITY, ENTITIES, or NOTATION), the value of this property is an ordered list of the element, unparsed entity, or notation information items referred to in the attribute value, in the order that they appear there.
      ///  In this case, if the attribute value is syntactically invalid, this property has no value.
      ///  If the type is IDREF or IDREFS and any of the IDs does not appear as the value of an ID attribute in the document, or if the type is ENTITY, ENTITIES or NOTATION and no declaration has been read for any of the entities or the notation, then this property has no value or is unknown, depending on whether the [all declarations processed] property of the document information item is true or false.
      ///  If the type is IDREF or IDREFS and any of the IDs appears as the value of more than one ID attribute in the document, or if the type is NOTATION and there are multiple declarations for the notation, then this property has no value.
      references: Attribute_Reference array
      ///  The element information item which contains this information item in its [attributes] property.
      owner_element: Element_Information_Item

     }

/// There is a processing instruction information item for each processing instruction in the document.
///  The XML declaration and text declarations for external parsed entities are not considered processing instructions.
and Processing_Instruction_Information_Item =
    {

      ///  A string representing the target part of the processing instruction (an XML name).
      target: string
      ///  A string representing the content of the processing instruction, excluding the target and any white space immediately following it.
      ///  If there is no such content, the value of this property will be an empty string.
      content: string
      ///  The base URI of the PI.
      ///  Note that if an infoset is serialized as an XML document, it will not be possible to preserve the base URI of any PI that originally appeared at the top level of an external entity, since there is no syntax for PIs corresponding to the xml:base attribute on elements.
      base_URI: URI
      ///  The notation information item named by the target.
      ///  If there is no declaration for a notation with that name, or there are multiple declarations, this property has no value.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown.
      notation: Notation_Information_Item
      ///  The document, element, or document type declaration information item which contains this information item in its [children] property.
      parent: Information_Item

     }


/// A unexpanded entity reference information item serves as a placeholder by which an XML processor can indicate that it has not expanded an external parsed entity.
///  There is such an information item for each unexpanded reference to an external general entity within the content of an element.
///  A validating XML processor, or a non-validating processor that reads all external general entities, will never generate unexpanded entity reference information items for a valid document.
and Unexpanded_Entity_Reference_Information_Item =
    {

      ///  The name of the entity referenced.
      name: string
      ///  The system identifier of the entity, as it appears in the declaration of the entity, without any additional URI escaping applied by the processor.
      ///  If there is no declaration for the entity, this property has no value.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown.
      system_identifier: string option
      ///  The public identifier of the entity, normalized as described in 4.2.2 External Entities [XML].
      ///  If there is no declaration for the entity, or the declaration does not include a public identifier, this property has no value.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown.
      public_identifier: string option
      ///  The base URI relative to which the system identifier should be resolved (i.e.the base URI of the resource within which the entity declaration occurs).
      ///  This is unknown or has no value in the same circumstances as the [system identifier] property.
      declaration_base_URI: URI
      ///  The element information item which contains this information item in its [children] property.
      parent: Element_Information_Item

     }

// There is a character information item for each data character that appears in the document, whether literally, as a character reference, or within a CDATA section.
// Each character is a logically separate information item, but XML applications are free to chunk characters into larger groups as necessary or desirable.
and Character_Information_Item =

    {

      ///  The ISO 10646 character code (in the range 0 to #x10FFFF, though not every value in this range is a legal XML character code) of the character.
      character_code: int
      ///  A boolean indicating whether the character is white space appearing within element content (see [XML], 2.10 "White Space Handling").
      ///  Note that validating XML processors are required to provide this information.
      ///  If there is no declaration for the containing element, or there are multiple declarations, this property has no value for white space characters.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown for white space characters.
      ///  It is always false for characters that are not white space.
      element_content_whitespace: bool
      ///  The element information item which contains this information item in its [children] property.
      parent: Element_Information_Item

     }

/// There is a comment information item for each XML comment in the original document, except for those appearing in the DTD (which are not represented).
and Comment_Information_Item =


    {

      ///  A string representing the content of the comment.
      content: string
      ///  The document or element information item which contains this information item in its [children] property.
      parent: Element_Information_Item

     }

/// If the XML document has a document type declaration, then the information set contains a single document type declaration information item. Note that entities and notations are provided as properties of the document information item, not the document type declaration information item.
and Document_Type_Declaration_Information_Item =
    {

      ///  The system identifier of the external subset, as it appears in the DOCTYPE declaration, without any additional URI escaping applied by the processor.
      ///  If there is no external subset this property has no value.
      system_identifier: string
      ///  The public identifier of the external subset, normalized as described in 4.2.2 External Entities [XML].
      ///  If there is no external subset or if it has no public identifier, this property has no value.
      public_identifier: string option
      ///  An ordered list of processing instruction information items representing processing instructions appearing in the DTD, in the original document order.
      ///  Items from the internal DTD subset appear before those in the external subset.
      children: Processing_Instruction_Information_Item array
      ///  The document information item.
      parent: Document_Information_Item

     }

/// There is an unparsed entity information item for each unparsed general entity declared in the DTD.
and Unparsed_Entity_Information_Item =

    {



      ///  The name of the entity.
      name: string
      ///  The system identifier of the entity, as it appears in the declaration of the entity, without any additional URI escaping applied by the processor.
      system_identifier: string
      ///  The public identifier of the entity, normalized as described in 4.2.2 External Entities [XML].
      ///  If the entity has no public identifier, this property has no value.
      public_identifier: string option
      ///  The base URI relative to which the system identifier should be resolved (i.e.the base URI of the resource within which the entity declaration occurs).
      declaration_base_URI: URI
      ///  The notation name associated with the entity.
      notation_name: string
      ///  The notation information item named by the notation name.
      ///  If there is no declaration for a notation with that name, or there are multiple declarations, this property has no value.
      ///  If no declaration has been read, but the [all declarations processed] property of the document information item is false (so there may be an unread declaration), then the value of this property is unknown.
      notation: Notation_Information_Item option

     }


/// There is a notation information item for each notation declared in the DTD.
and Notation_Information_Item =


    {

      ///  The name of the notation.
      name: string
      ///  The system identifier of the notation, as it appears in the declaration of the notation, without any additional URI escaping applied by the processor.
      ///  If no system identifier was specified, this property has no value.
      system_identifier: string option
      ///  The public identifier of the notation, normalized as described in 4.2.2 External Entities [XML].
      ///  If the notation has no public identifier, this property has no value.
      public_identifier: string option
      ///  The base URI relative to which the system identifier should be resolved (i.e the base URI of the resource within which the notation declaration occurs).
      declaration_base_URI: URI

     }

/// Each element in the document has a namespace information item for each namespace that is in scope for that element.
and Namespace_Information_Item =



    {

      ///  The prefix whose binding this item describes.
      ///  Syntactically, this is the part of the attribute name following the xmlns: prefix.
      ///  If the attribute name is simply xmlns, so that the declaration is of the default namespace, this property has no value.
      prefix: string
      /// The namespace name to which the prefix is bound.
      namespace_name: string

     }


and Information_Set =
    {

      document_information_item: Document_Information_Item

     }
