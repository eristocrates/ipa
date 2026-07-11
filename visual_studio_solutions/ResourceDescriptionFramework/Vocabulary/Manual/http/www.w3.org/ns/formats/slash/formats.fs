namespace Formats.Namespace

module formats =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "https://www.w3.org/ns/formats/"
            None
            (Some "formats")
            None

    let ``JSON-LD`` = { _prefixID with _localName = "JSON-LD" }
    let N3 = { _prefixID with _localName = "N3" }
    let ``N-Triples`` = { _prefixID with _localName = "N-Triples" }
    let ``N-Quads`` = { _prefixID with _localName = "N-Quads" }
    let LD_Patch = { _prefixID with _localName = "LD_Patch" }
    let microdata = { _prefixID with _localName = "microdata" }
    /// OWL XML Serialization:
    let OWL_XML = { _prefixID with _localName = "OWL_XML" }
    /// OWL Functional Syntax:
    let OWL_Functional = { _prefixID with _localName = "OWL_Functional" }
    /// OWL Manchester Syntax:
    let OWL_Manchester = { _prefixID with _localName = "OWL_Manchester" }
    /// POWDER:
    let POWDER = { _prefixID with _localName = "POWDER" }
    /// POWDER-S:
    let ``POWDER-S`` = { _prefixID with _localName = "POWDER-S" }
    /// PROV-N:
    let ``PROV-N`` = { _prefixID with _localName = "PROV-N" }
    /// PROV-XML:
    let ``PROV-XML`` = { _prefixID with _localName = "PROV-XML" }
    /// RDFa:
    let RDFa = { _prefixID with _localName = "RDFa" }
    /// RDF/JSON:
    let RDF_JSON = { _prefixID with _localName = "RDF_JSON" }
    /// RDF/XML:
    let RDF_XML = { _prefixID with _localName = "RDF_XML" }
    /// RIF XML Syntax:
    let RIF_XML = { _prefixID with _localName = "RIF_XML" }
    /// SPARQL Results in XML:
    let SPARQL_Results_XML = { _prefixID with _localName = "SPARQL_Results_XML" }
    /// SPARQL Results in JSON:
    let SPARQL_Results_JSON = { _prefixID with _localName = "SPARQL_Results_JSON" }
    /// SPARQL Results in CSV:
    let SPARQL_Results_CSV = { _prefixID with _localName = "SPARQL_Results_CSV" }
    /// SPARQL Results in TSV:
    let SPARQL_Results_TSV = { _prefixID with _localName = "SPARQL_Results_TSV" }
    /// Turtle:
    let Turtle = { _prefixID with _localName = "Turtle" }
    /// TriG:
    let TriG = { _prefixID with _localName = "TriG" }
    let media_type = { _prefixID with _localName = "media_type" }
    let preferred_suffix = { _prefixID with _localName = "preferred_suffix" }
