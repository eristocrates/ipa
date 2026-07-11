namespace Rfc.Namespace

module rfc2119 =
    let _prefixID =
        Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
            "https://www.rfc-editor.org/rfc/rfc2119#"
            None
            (Some "rfc2119")
            None

    let MUST = { _prefixID with _localName = "MUST" }

    let MUST_NOT = { _prefixID with _localName = "MUST_NOT" }

    let REQUIRED = { _prefixID with _localName = "REQUIRED" }

    let SHALL = { _prefixID with _localName = "SHALL" }

    let SHALL_NOT = { _prefixID with _localName = "SHALL_NOT" }

    let SHOULD = { _prefixID with _localName = "SHOULD" }

    let SHOULD_NOT = { _prefixID with _localName = "SHOULD_NOT" }

    let RECOMMENDED = { _prefixID with _localName = "RECOMMENDED" }

    let MAY = { _prefixID with _localName = "MAY" }

    let OPTIONAL = { _prefixID with _localName = "OPTIONAL" }
    let citation_author = { _prefixID with _localName = "citation_author" }
    let citation_doi = { _prefixID with _localName = "citation_doi" }
    let citation_issn = { _prefixID with _localName = "citation_issn" }
    let citation_pdf_url = { _prefixID with _localName = "citation_pdf_url" }

    let citation_publication_date =
        { _prefixID with _localName = "citation_publication_date" }

    let citation_technical_report_number =
        { _prefixID with _localName = "citation_technical_report_number" }

    let citation_title = { _prefixID with _localName = "citation_title" }
    let creator = { _prefixID with _localName = "creator" }
    let ``page-2`` = { _prefixID with _localName = "page-2" }
    let ``page-3`` = { _prefixID with _localName = "page-3" }
    let robots = { _prefixID with _localName = "robots" }
    let ``section-1`` = { _prefixID with _localName = "section-1" }
    let ``section-2`` = { _prefixID with _localName = "section-2" }
    let ``section-3`` = { _prefixID with _localName = "section-3" }
    let ``section-4`` = { _prefixID with _localName = "section-4" }
    let ``section-5`` = { _prefixID with _localName = "section-5" }
    let ``section-6`` = { _prefixID with _localName = "section-6" }
    let ``section-7`` = { _prefixID with _localName = "section-7" }
    let ``section-8`` = { _prefixID with _localName = "section-8" }
    let ``section-9`` = { _prefixID with _localName = "section-9" }
