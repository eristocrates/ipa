// just a sketch
// https://cse.unl.edu/~reich/XML/dtd.html

type Element_Name = string

type Attribute_Name = string
type Entity_Name = string
type Notation_Name = string


type Document_Element = unit
type Content_Model_Group = unit

type Content_Model_Term =
    | Element of Element_Name
    | Parsed_Character_Data
    | Group of Content_Model_Group

[<RequireQualifiedAccess>]
type Content_Category =
    /// The element has no contents.
    | EMPTY
    /// The element can have any contents.
    | ANY
    /// The element can have text-only contents.
    | PCDATA
    /// The element can have mixed contents.
    | mixed

[<RequireQualifiedAccess>]
type Occurrence =
    | ExactlyOnce
    | ZeroOrOnce
    | ZeroOrMore
    | OnceOrMore

[<RequireQualifiedAccess>]
type Connector =
    | StrictSequence
    | Choice

[<RequireQualifiedAccess>]
type Arity =
    | binary
    | unary

[<RequireQualifiedAccess>]
type Operator_Kind =
    | connector of Connector
    | occurrence_indicator of Occurrence

type Expression_Operator =
    {

      arity: Arity
      kind: Operator_Kind
      character: string
      description: string

     }


let strict_sequence =
    { arity = Arity.binary
      kind = Operator_Kind.connector Connector.StrictSequence
      character = ","
      description = "comma" }

let choice =
    { arity = Arity.binary
      kind = Operator_Kind.connector Connector.Choice
      character = "|"
      description = "vertical bar" }

let appears_zero_or_once =
    { arity = Arity.unary
      kind = Operator_Kind.occurrence_indicator Occurrence.ZeroOrOnce
      character = "?"
      description = "question mark" }

let appears_zero_or_more =
    { arity = Arity.unary
      kind = Operator_Kind.occurrence_indicator Occurrence.ZeroOrMore
      character = "*"
      description = "asterisk" }

let appears_once_or_more =
    { arity = Arity.unary
      kind = Operator_Kind.occurrence_indicator Occurrence.OnceOrMore
      character = "+"
      description = "plus" }


type Children_Content_Model = unit
type Mixed_Content_Model = unit

[<RequireQualifiedAccess>]
type Content_Model =
    | EMPTY
    | ANY
    | Children of Children_Content_Model
    | Mixed of Mixed_Content_Model

type Content =
    | FromContentCategory of Content_Category
    | FromContentModel of Content_Model

/// XML elements, the nouns.
type ELEMENT =
    {

      name: string
      content: Content

     }

[<RequireQualifiedAccess>]
type Attribute_Type =
    /// "Character data (text)"
    | CDATA
    /// "Explicit list of choices"
    | Enumerated_values
    /// "Unique name for element instance"
    | ID
    /// "Link to another element's ID"
    | IDREF
    /// "List of IDREF attributes"
    | IDREFS
    /// "Name Token (use NameChar characters)"
    | NMTOKEN
    /// "List of NMTOKEN"
    | NMTOKENS
    /// "Unparsed external entity"
    | ENTITY
    /// "List of ENTITY attributes"
    | ENTITIES
    /// "Notation reference"
    | NOTATION of string array
    | Enumeration of string array

[<RequireQualifiedAccess>]
type Default_Value =
    /// "Value must be given"
    | REQUIRED
    /// "Optional value"
    | IMPLIED
    /// "Optional, value fixed"
    | FIXED of string
    /// "Optional, default available"
    | Default of string

type Attribute_Declaration =
    {

      attribute_name: string
      attribute_type: Attribute_Type
      default_value: Default_Value

     }

/// XML element attributes, the adjectives.
type ATTLIST =
    {

      element_name: string
      attribute_declarations: Attribute_Declaration array

     }

[<RequireQualifiedAccess>]
type Entity_Kind =
    | General
    | Parameter

[<RequireQualifiedAccess>]
type DTD_Conditional =
    | INCLUDE
    | IGNORE

/// Character references, macros for content.
type ENTITY =
    {

      name: string
      replacement_text: string
      entity_kind: Entity_Kind

     }


/// Non-XML content, e.g. binary data.
type NOTATION = unit
type URI = unit
type URL = unit
type URN = unit

type DTD_Location =
    | FromURI of URI
    | FromURL of URL
    | FromURN of URN

type Reference_Fallback =
    | FromURI of URI
    | FromURL of URL

type PUBLIC =
    {

      dtd_reference: string
      reference_fallback: Reference_Fallback

     }

type SYSTEM =
    {

      dtd_location: DTD_Location

     }

type External_Identifier =
    | SYSTEM of system_identifier: URI
    | PUBLIC of public_identifier: string * system_identifier: URI option

type DTD_Keyword =
    | FromELEMENT of ELEMENT
    | FromATTLIST of ATTLIST
    | FromENTITY of ENTITY
    | FromNOTATION of NOTATION

type DTD_Declaration =
    {

      keyword: DTD_Keyword

     }

type DOCTYPE =
    {

      document_element_name: string
      external_subset: External_Identifier option
      internal_subset_declarations: DTD_Declaration array

     }

type Conditional_Section =
    | INCLUDE of DTD_Declaration array
    | IGNORE of string
