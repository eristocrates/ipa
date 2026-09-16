#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdag1 =
    let _prefixId = PrefixId.fromNamespaceLabel "http://rdvocab.info/Elements/" "rdag1"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Dissertation or thesis information composite string. Dissertation or theses information is composed of an ordered, concatenated list of properties: - Academic degree - Granting institution or faculty - Year degree granted.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : DissertationOrThesisInformationEncodingScheme</para>
    ///   <para>rdfs:label : Dissertation Or Thesis Information Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/DissertationOrThesisInformationEncodingScheme">rdag1:DissertationOrThesisInformationEncodingScheme</a>
    /// </summary>
    let DissertationOrThesisInformationEncodingScheme = _prefixId.prefix "DissertationOrThesisInformationEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Distribution Statement composite string. The Distribution Statement is composed of an ordered, concatenated list of properties: - Place of distribution - Parallel place of distribution - Distributor's name - Parallel distributor's name - Date of distribution</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : DistributionStatementEncodingScheme</para>
    ///   <para>rdfs:label : Distribution Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/DistributionStatementEncodingScheme">rdag1:DistributionStatementEncodingScheme</a>
    /// </summary>
    let DistributionStatementEncodingScheme = _prefixId.prefix "DistributionStatementEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Edition Statement composite string. The Edition Statement is composed of an ordered, concatenated list of properties: - Designation of edition - Parallel designation of edition - Statement of responsibility relating to the edition - Parallel statement of responsibility relating to the edition - Designation of a named revision of an edition - Parallel designation of a named revision of an edition - Statement of responsibility relating to a named revision of an edition - Parallel statement of responsibility relating to a named revision of an edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : EditionStatementEncodingScheme</para>
    ///   <para>rdfs:label : Edition Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/EditionStatementEncodingScheme">rdag1:EditionStatementEncodingScheme</a>
    /// </summary>
    let EditionStatementEncodingScheme = _prefixId.prefix "EditionStatementEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Manufacture Statement composite string. The Manufacture Statement is composed of an ordered, concatenated list of properties: - Place of manufacture - Parallel place of manufacture - Manufacturer's name - Parallel manufacturer's name - Date of manufacture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ManufactureStatementEncodingScheme</para>
    ///   <para>rdfs:label : Manufacture Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/ManufactureStatementEncodingScheme">rdag1:ManufactureStatementEncodingScheme</a>
    /// </summary>
    let ManufactureStatementEncodingScheme = _prefixId.prefix "ManufactureStatementEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This encoding scheme has been created to define the Syntax Encoding Scheme for the RDA Place and date of capture composite string. Place and date of capture is composed of an ordered, concatenated list of properties: - Place of capture -- Date of capture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : PlaceAndDateOfCaptureEncodingScheme</para>
    ///   <para>rdfs:label : Place And Date of Capture Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/PlaceAndDateOfCaptureEncodingScheme">rdag1:PlaceAndDateOfCaptureEncodingScheme</a>
    /// </summary>
    let PlaceAndDateOfCaptureEncodingScheme = _prefixId.prefix "PlaceAndDateOfCaptureEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Production Statement composite string. The Production Statement is composed of an ordered, concatenated list of properties: - Place of production - Parallel place of production - Producer's name - Parallel producer's name - Date of production</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : ProductionStatementEncodingScheme</para>
    ///   <para>rdfs:label : Production Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/ProductionStatementEncodingScheme">rdag1:ProductionStatementEncodingScheme</a>
    /// </summary>
    let ProductionStatementEncodingScheme = _prefixId.prefix "ProductionStatementEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Publication Statement composite string. The Publication Statement is composed of an ordered, concatenated list of properties:
    ///  - Place of publication
    ///  - Parallel place of publication
    ///  - Publisher's name
    ///  - Parallel publisher's name
    ///  - Date of publication
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : PublicationStatementEncodingScheme</para>
    ///   <para>rdfs:label : Publication Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/PublicationStatementEncodingScheme">rdag1:PublicationStatementEncodingScheme</a>
    /// </summary>
    let PublicationStatementEncodingScheme = _prefixId.prefix "PublicationStatementEncodingScheme"

    /// <summary>
    ///   <para>rdfs:label : RDA Syntax Encoding Scheme</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : RDASyntaxEncodingScheme</para>
    ///   <para>skos:definition : This subclass has been created to gather the Syntax Encoding Schemes used in RDA. </para>
    ///   <a href="http://rdvocab.info/Elements/RDASyntaxEncodingScheme">rdag1:RDASyntaxEncodingScheme</a>
    /// </summary>
    let RDASyntaxEncodingScheme = _prefixId.prefix "RDASyntaxEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : This class has been created to define the Syntax Encoding Scheme for the RDA Representation of Cartographic Images composite string. The Representation of Cartographic Images is composed of an ordered, concatenated list of properties: - Data type - Number of objects - Object type</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : RepresentationOfCartographicImagesClass</para>
    ///   <para>rdfs:label : Representation of Cartographic Images Class</para>
    ///   <a href="http://rdvocab.info/Elements/RepresentationOfCartographicImagesClass">rdag1:RepresentationOfCartographicImagesClass</a>
    /// </summary>
    let RepresentationOfCartographicImagesClass = _prefixId.prefix "RepresentationOfCartographicImagesClass"

    /// <summary>
    ///   <para>skos:definition : This subclass has been created to define the Syntax Encoding Scheme for the RDA Series Statement composite string. The Series Statement is composed of an ordered, concatenated list of properties: - Title proper of series - Parallel title of series - Other title information of series - Parallel other title information of series - Statement of responsibility relating to series - Parallel statement of responsibility relating to series - ISSN of series - Numbering within series - Title proper of subseries - Parallel title of subseries - Other title information of subseries - Parallel other title information of subseries - Statement of responsibility relating to subseries - Parallel statement of responsibility relating to subseries - ISSN of subseries - Numbering within subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : SeriesStatementEncodingScheme</para>
    ///   <para>rdfs:label : Series Statement Encoding Scheme</para>
    ///   <a href="http://rdvocab.info/Elements/SeriesStatementEncodingScheme">rdag1:SeriesStatementEncodingScheme</a>
    /// </summary>
    let SeriesStatementEncodingScheme = _prefixId.prefix "SeriesStatementEncodingScheme"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for the edition being described but not to all editions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : StatementOfResponsibilityRelatingToEditionManifestation</para>
    ///   <para>rdfs:label : Statement of responsibility relating to the edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToEditionManifestation">rdag1:StatementOfResponsibilityRelatingToEditionManifestation</a>
    /// </summary>
    let StatementOfResponsibilityRelatingToEditionManifestation = _prefixId.prefix "StatementOfResponsibilityRelatingToEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for the edition being described but not to all editions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : StatementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>rdfs:label : Statement of responsibility relating to the edition</para>
    ///   <a href="http://rdvocab.info/Elements/StatementOfResponsibilityRelatingToTheEdition">rdag1:StatementOfResponsibilityRelatingToTheEdition</a>
    /// </summary>
    let StatementOfResponsibilityRelatingToTheEdition = _prefixId.prefix "StatementOfResponsibilityRelatingToTheEdition"

    let SyntaxEncodingScheme = _prefixId.prefix "SyntaxEncodingScheme"
    /// <summary>
    ///   <para>skos:definition : A title that has been abbreviated for purposes of indexing or identification. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abbreviatedTitle</para>
    ///   <para>rdfs:label : Abbreviated title</para>
    ///   <a href="http://rdvocab.info/Elements/abbreviatedTitle">rdag1:abbreviatedTitle</a>
    /// </summary>
    let abbreviatedTitle = _prefixId.prefix "abbreviatedTitle"
    /// <summary>
    ///   <para>skos:definition : A title that has been abbreviated for purposes of indexing or identification. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abbreviatedTitleManifestation</para>
    ///   <para>rdfs:label : Abbreviated title (Manifestatiion)</para>
    ///   <a href="http://rdvocab.info/Elements/abbreviatedTitleManifestation">rdag1:abbreviatedTitleManifestation</a>
    /// </summary>
    let abbreviatedTitleManifestation = _prefixId.prefix "abbreviatedTitleManifestation"
    /// <summary>
    ///   <para>skos:definition : A rank conferred as a guarantee of academic proficiency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : academicDegree</para>
    ///   <para>rdfs:label : Academic degree</para>
    ///   <a href="http://rdvocab.info/Elements/academicDegree">rdag1:academicDegree</a>
    /// </summary>
    let academicDegree = _prefixId.prefix "academicDegree"
    /// <summary>
    ///   <para>skos:definition : A rank conferred as a guarantee of academic proficiency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : academicDegreeWork</para>
    ///   <para>rdfs:label : Academic degree (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/academicDegreeWork">rdag1:academicDegreeWork</a>
    /// </summary>
    let academicDegreeWork = _prefixId.prefix "academicDegreeWork"
    /// <summary>
    ///   <para>skos:definition : Content that assists those with a sensory impairment in the greater understanding of content which their impairment prevents them fully seeing or hearing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accessibilityContent</para>
    ///   <para>rdfs:label : Accessibility content</para>
    ///   <a href="http://rdvocab.info/Elements/accessibilityContent">rdag1:accessibilityContent</a>
    /// </summary>
    let accessibilityContent = _prefixId.prefix "accessibilityContent"

    /// <summary>
    ///   <para>skos:definition : Content that assists those with a sensory impairment in the greater understanding of content which their impairment prevents them fully seeing or hearing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accessibilityContentExpression</para>
    ///   <para>rdfs:label : Accessibility content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/accessibilityContentExpression">rdag1:accessibilityContentExpression</a>
    /// </summary>
    let accessibilityContentExpression = _prefixId.prefix "accessibilityContentExpression"

    /// <summary>
    ///   <para>skos:definition : Supplemental information pertaining to scale such as a statement of comparative measures or limitation of the scale to particular parts of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : additionalScaleInformation</para>
    ///   <para>rdfs:label : Additional scale information</para>
    ///   <a href="http://rdvocab.info/Elements/additionalScaleInformation">rdag1:additionalScaleInformation</a>
    /// </summary>
    let additionalScaleInformation = _prefixId.prefix "additionalScaleInformation"

    /// <summary>
    ///   <para>skos:definition : Supplemental information pertaining to scale such as a statement of comparative measures or limitation of the scale to particular parts of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : additionalScaleInformationExpression</para>
    ///   <para>rdfs:label : Additional scale information (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/additionalScaleInformationExpression">rdag1:additionalScaleInformationExpression</a>
    /// </summary>
    let additionalScaleInformationExpression = _prefixId.prefix "additionalScaleInformationExpression"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Alternative Chronological Designation of First Issue or Part of Sequence</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence">rdag1:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence</a>
    /// </summary>
    let alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence = _prefixId.prefix "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Alternative Chronological Designation of First Issue or Part of Sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation">rdag1:alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "alternativeChronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Alternative Chronological Designation of Last Issue or Part of Sequence</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequence">rdag1:alternativeChronologicalDesignationOfLastIssueOrPartOfSequence</a>
    /// </summary>
    let alternativeChronologicalDesignationOfLastIssueOrPartOfSequence = _prefixId.prefix "alternativeChronologicalDesignationOfLastIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation </para>
    ///   <para>rdfs:label : Alternative Chronological Designation of Last Issue or Part of Sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation">rdag1:alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "alternativeChronologicalDesignationOfLastIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Alternative Numeric and/or Alphabetic Designation of First Issue or Part of Sequence</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence">rdag1:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</a>
    /// </summary>
    let alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Alternative Numeric and/or Alphabetic Designation of First Issue or Part of Sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation">rdag1:alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Alternative Numeric and/or Alphabetic Designation of Last Issue or Part of Sequence</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence">rdag1:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</a>
    /// </summary>
    let alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence = _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : A second or subsequent system of numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Alternative Numeric and/or Alphabetic Designation of Last Issue or Part of Sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation">rdag1:alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "alternativeNumericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.7.0.1.1</para>
    ///   <para>skos:definition : A physical or chemical substance applied to a base material of a resource.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appliedMaterial</para>
    ///   <para>rdfs:label : Applied material</para>
    ///   <a href="http://rdvocab.info/Elements/appliedMaterial">rdag1:appliedMaterial</a>
    /// </summary>
    let appliedMaterial = _prefixId.prefix "appliedMaterial"
    /// <summary>
    ///   <para>skos:definition : A physical or chemical substance applied to a base material of a resource.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appliedMaterialManifestation</para>
    ///   <para>rdfs:label : Applied material (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/appliedMaterialManifestation">rdag1:appliedMaterialManifestation</a>
    /// </summary>
    let appliedMaterialManifestation = _prefixId.prefix "appliedMaterialManifestation"
    /// <summary>
    ///   <para>skos:definition : A listing of persons, families, or corporate bodies making contributions to the artistic and/or technical production of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artisticAndOrTechnicalCredit</para>
    ///   <para>rdfs:label : Artistic and/or technical credit</para>
    ///   <a href="http://rdvocab.info/Elements/artisticAndOrTechnicalCredit">rdag1:artisticAndOrTechnicalCredit</a>
    /// </summary>
    let artisticAndOrTechnicalCredit = _prefixId.prefix "artisticAndOrTechnicalCredit"

    /// <summary>
    ///   <para>skos:definition : A listing of persons, families, or corporate bodies making contributions to the artistic and/or technical production of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : artisticAndOrTechnicalCreditExpression</para>
    ///   <para>rdfs:label : Artistic and/or technical credit (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/artisticAndOrTechnicalCreditExpression">rdag1:artisticAndOrTechnicalCreditExpression</a>
    /// </summary>
    let artisticAndOrTechnicalCreditExpression = _prefixId.prefix "artisticAndOrTechnicalCreditExpression"

    /// <summary>
    ///   <para>skos:definition : The ratio of the width to the height of a moving image.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : aspectRatio</para>
    ///   <para>rdfs:label : Aspect ratio</para>
    ///   <a href="http://rdvocab.info/Elements/aspectRatio">rdag1:aspectRatio</a>
    /// </summary>
    let aspectRatio = _prefixId.prefix "aspectRatio"
    /// <summary>
    ///   <para>skos:definition : The ratio of the width to the height of a moving image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : aspectRatioExpression</para>
    ///   <para>rdfs:label : Aspect ratio (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/aspectRatioExpression">rdag1:aspectRatioExpression</a>
    /// </summary>
    let aspectRatioExpression = _prefixId.prefix "aspectRatioExpression"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.25.0.1.1</para>
    ///   <para>skos:definition : A formal recognition of excellence, etc., for the content of a resource by an award- or prize-granting body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : award</para>
    ///   <para>rdfs:label : Award</para>
    ///   <a href="http://rdvocab.info/Elements/award">rdag1:award</a>
    /// </summary>
    let award = _prefixId.prefix "award"
    /// <summary>
    ///   <para>skos:definition : A formal recognition of excellence, etc., for the content of a resource by an award- or prize-granting body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : awardExpression</para>
    ///   <para>rdfs:label : Award (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/awardExpression">rdag1:awardExpression</a>
    /// </summary>
    let awardExpression = _prefixId.prefix "awardExpression"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.6.0.1.1</para>
    ///   <para>skos:definition : The underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterial</para>
    ///   <para>rdfs:label : Base material</para>
    ///   <a href="http://rdvocab.info/Elements/baseMaterial">rdag1:baseMaterial</a>
    /// </summary>
    let baseMaterial = _prefixId.prefix "baseMaterial"
    /// <summary>
    ///   <para>skos:definition : The underlying physical material of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterialManifestation</para>
    ///   <para>rdfs:label : Base material (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/baseMaterialManifestation">rdag1:baseMaterialManifestation</a>
    /// </summary>
    let baseMaterialManifestation = _prefixId.prefix "baseMaterialManifestation"

    /// <summary>
    ///   <para>skos:definition : The underlying physical material of a microfilm, microfiche, photographic film, or motion picture film resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm</para>
    ///   <para>rdfs:label : Base material for microfilm, microfiche, photographic film, and motion picture film</para>
    ///   <a href="http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm">rdag1:baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm</a>
    /// </summary>
    let baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm = _prefixId.prefix "baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilm"

    /// <summary>
    ///   <para>skos:definition : The underlying physical material of a microfilm, microfiche, photographic film, or motion picture film resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation</para>
    ///   <para>rdfs:label : Base material for microfilm, microfiche, photographic film, and motion picture film (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation">rdag1:baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation</a>
    /// </summary>
    let baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation =
        _prefixId.prefix "baseMaterialforMicrofilmMicrofichePhotographicFilmAndMotionPictureFilmManifestation"

    /// <summary>
    ///   <para>skos:definition : The result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookFormat</para>
    ///   <para>rdfs:label : Book format</para>
    ///   <a href="http://rdvocab.info/Elements/bookFormat">rdag1:bookFormat</a>
    /// </summary>
    let bookFormat = _prefixId.prefix "bookFormat"
    /// <summary>
    ///   <para>skos:definition : The result of folding a printed sheet to form a gathering of leaves (e.g., a sheet folded once to form a folio, twice to form a quarto, three times to form an octavo, etc.).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : bookFormatManifestation</para>
    ///   <para>rdfs:label : Book format (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/bookFormatManifestation">rdag1:bookFormatManifestation</a>
    /// </summary>
    let bookFormatManifestation = _prefixId.prefix "bookFormatManifestation"
    /// <summary>
    ///   <para>skos:definition : A  system used to format a video resource for television broadcast.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcastStandard</para>
    ///   <para>rdfs:label : Broadcast standard</para>
    ///   <a href="http://rdvocab.info/Elements/broadcastStandard">rdag1:broadcastStandard</a>
    /// </summary>
    let broadcastStandard = _prefixId.prefix "broadcastStandard"

    /// <summary>
    ///   <para>skos:definition : A  system used to format a video resource for television broadcast.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : broadcastStandardManifestation</para>
    ///   <para>rdfs:label : Broadcast standard (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/broadcastStandardManifestation">rdag1:broadcastStandardManifestation</a>
    /// </summary>
    let broadcastStandardManifestation = _prefixId.prefix "broadcastStandardManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.3.0.1.1</para>
    ///   <para>skos:definition : A categorization reflecting the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : carrierType</para>
    ///   <para>rdfs:label : Carrier type</para>
    ///   <a href="http://rdvocab.info/Elements/carrierType">rdag1:carrierType</a>
    /// </summary>
    let carrierType = _prefixId.prefix "carrierType"
    /// <summary>
    ///   <para>skos:definition : A categorization reflecting the format of the storage medium and housing of a carrier in combination with the type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : carrierTypeManifestation</para>
    ///   <para>rdfs:label : Carrier type (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/carrierTypeManifestation">rdag1:carrierTypeManifestation</a>
    /// </summary>
    let carrierTypeManifestation = _prefixId.prefix "carrierTypeManifestation"
    /// <summary>
    ///   <para>skos:definition : An annotation that might be helpful to those using or revising the authorized access point representing an entity or relationship data, or creating an authorized access point representing a related entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cataloguersNote</para>
    ///   <para>rdfs:label : Cataloguer's note</para>
    ///   <a href="http://rdvocab.info/Elements/cataloguersNote">rdag1:cataloguersNote</a>
    /// </summary>
    let cataloguersNote = _prefixId.prefix "cataloguersNote"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Chronological designation of first issue or part of sequence</para>
    ///   <a href="http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequence">rdag1:chronologicalDesignationOfFirstIssueOrPartOfSequence</a>
    /// </summary>
    let chronologicalDesignationOfFirstIssueOrPartOfSequence = _prefixId.prefix "chronologicalDesignationOfFirstIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Chronological designation of first issue or part of sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation">rdag1:chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation = _prefixId.prefix "chronologicalDesignationOfFirstIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Chronological designation of last issue or part of sequence</para>
    ///   <a href="http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequence">rdag1:chronologicalDesignationOfLastIssueOrPartOfSequence</a>
    /// </summary>
    let chronologicalDesignationOfLastIssueOrPartOfSequence = _prefixId.prefix "chronologicalDesignationOfLastIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in the form of a date (e.g., a year; year and month; month, day, and year) on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Chronological designation of last issue or part of sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation">rdag1:chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation = _prefixId.prefix "chronologicalDesignationOfLastIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:scopeNote :  Definition source: RDA 3.12.0.1.1 </para>
    ///   <para>skos:definition : The presence of colour, tone, etc., in the content of a resource. Colour content is also the specific colours, tones, etc., (including black and white) present in the content of a resource.</para>
    ///   <para>rdfs:label : Colour content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContent</para>
    ///   <a href="http://rdvocab.info/Elements/colourContent">rdag1:colourContent</a>
    /// </summary>
    let colourContent = _prefixId.prefix "colourContent"
    /// <summary>
    ///   <para>rdfs:label : Colour content (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContentExpression</para>
    ///   <para>skos:definition : The presence of colour, tone, etc., in the content of a resource. Colour content is also the specific colours, tones, etc., (including black and white) present in the content of a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/colourContentExpression">rdag1:colourContentExpression</a>
    /// </summary>
    let colourContentExpression = _prefixId.prefix "colourContentExpression"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a resource designed for persons with visual impairments. Colour content of a resource designed for persons with visual impairments is also the specific colours, tones, etc., (excluding black and white) present in a resource designed for persons with visual impairments.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContentOfResourceDesignedForPersonsWithVisualImpairments</para>
    ///   <para>rdfs:label : Colour content of resource designed for persons with visual impairments</para>
    ///   <a href="http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairments">rdag1:colourContentOfResourceDesignedForPersonsWithVisualImpairments</a>
    /// </summary>
    let colourContentOfResourceDesignedForPersonsWithVisualImpairments = _prefixId.prefix "colourContentOfResourceDesignedForPersonsWithVisualImpairments"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a resource designed for persons with visual impairments. Colour content of a resource designed for persons with visual impairments is also the specific colours, tones, etc., (excluding black and white) present in a resource designed for persons with visual impairments.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression</para>
    ///   <para>rdfs:label : Colour content of resource designed for persons with visual impairments (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression">rdag1:colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression</a>
    /// </summary>
    let colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression =
        _prefixId.prefix "colourContentOfResourceDesignedForPersonsWithVisualImpairmentsExpression"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a moving image or images contained in a resource. Colour of moving image is also the specific colours, tones, etc., (including black and white) present in a moving image or images contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfMovingImage</para>
    ///   <para>rdfs:label : Colour of moving images</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfMovingImage">rdag1:colourOfMovingImage</a>
    /// </summary>
    let colourOfMovingImage = _prefixId.prefix "colourOfMovingImage"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a moving image or images contained in a resource. Colour of moving image is also the specific colours, tones, etc., (including black and white) present in a moving image or images contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfMovingImagesExpressions</para>
    ///   <para>rdfs:label : Colour of moving images (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfMovingImagesExpressions">rdag1:colourOfMovingImagesExpressions</a>
    /// </summary>
    let colourOfMovingImagesExpressions = _prefixId.prefix "colourOfMovingImagesExpressions"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a still image or images contained in a resource. Colour of still image is also the specific colours, tones, etc., (including black and white) present in a still image or images contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfStillImage</para>
    ///   <para>rdfs:label : Colour of still image</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfStillImage">rdag1:colourOfStillImage</a>
    /// </summary>
    let colourOfStillImage = _prefixId.prefix "colourOfStillImage"
    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a still image or images contained in a resource. Colour of still image is also the specific colours, tones, etc., (including black and white) present in a still image or images contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfStillImageExpression</para>
    ///   <para>rdfs:label : Colour of still image (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfStillImageExpression">rdag1:colourOfStillImageExpression</a>
    /// </summary>
    let colourOfStillImageExpression = _prefixId.prefix "colourOfStillImageExpression"
    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a three-dimensional form or forms contained in a resource. Colour of three-dimensional form is also the specific colours, tones, etc., (including black and white) present in a three-dimensional form or forms contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfThree-dimensionalForm</para>
    ///   <para>rdfs:label : Colour of three-dimensional form</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfThree-dimensionalForm">rdag1:colourOfThree-dimensionalForm</a>
    /// </summary>
    let colourOfThree_dimensionalForm = _prefixId.prefix "colourOfThree-dimensionalForm"

    /// <summary>
    ///   <para>skos:definition : The presence of colour, tone, etc., in a three-dimensional form or forms contained in a resource. Colour of three-dimensional form is also the specific colours, tones, etc., (including black and white) present in a three-dimensional form or forms contained in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : colourOfThree-dimensionalFormExpression</para>
    ///   <para>rdfs:label : Colour of three-dimensional form (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/colourOfThree-dimensionalFormExpression">rdag1:colourOfThree-dimensionalFormExpression</a>
    /// </summary>
    let colourOfThree_dimensionalFormExpression = _prefixId.prefix "colourOfThree-dimensionalFormExpression"

    /// <summary>
    ///   <para>skos:definition : The number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : configurationOfPlaybackChannels</para>
    ///   <para>rdfs:label : Configuration of playback channels</para>
    ///   <a href="http://rdvocab.info/Elements/configurationOfPlaybackChannels">rdag1:configurationOfPlaybackChannels</a>
    /// </summary>
    let configurationOfPlaybackChannels = _prefixId.prefix "configurationOfPlaybackChannels"

    /// <summary>
    ///   <para>skos:definition : The number of sound channels used to make a recording (e.g., one channel for a monophonic recording, two channels for a stereophonic recording).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : configurationOfPlaybackChannelsManifestation</para>
    ///   <para>rdfs:label : Configuration of playback channels (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/configurationOfPlaybackChannelsManifestation">rdag1:configurationOfPlaybackChannelsManifestation</a>
    /// </summary>
    let configurationOfPlaybackChannelsManifestation = _prefixId.prefix "configurationOfPlaybackChannelsManifestation"

    /// <summary>
    ///   <para>skos:definition : Information relating to an organization, etc., from which a resource may be obtained.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contactInformation</para>
    ///   <para>rdfs:label : Contact information</para>
    ///   <a href="http://rdvocab.info/Elements/contactInformation">rdag1:contactInformation</a>
    /// </summary>
    let contactInformation = _prefixId.prefix "contactInformation"
    /// <summary>
    ///   <para>skos:definition : Information relating to an organization, etc., from which a resource may be obtained. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contactInformationItem</para>
    ///   <para>rdfs:label : Contact information (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/contactInformationItem">rdag1:contactInformationItem</a>
    /// </summary>
    let contactInformationItem = _prefixId.prefix "contactInformationItem"

    /// <summary>
    ///   <para>skos:definition : Information relating to an organization, etc., from which a resource may be obtained.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contactInformationManifestation</para>
    ///   <para>rdfs:label : Contact information (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/contactInformationManifestation">rdag1:contactInformationManifestation</a>
    /// </summary>
    let contactInformationManifestation = _prefixId.prefix "contactInformationManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.2.0.1.1</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contentType</para>
    ///   <para>rdfs:label : Content type </para>
    ///   <a href="http://rdvocab.info/Elements/contentType">rdag1:contentType</a>
    /// </summary>
    let contentType = _prefixId.prefix "contentType"
    /// <summary>
    ///   <para>skos:definition : A categorization reflecting the fundamental form of communication in which the content is expressed and the human sense through which it is intended to be perceived. For content expressed in the form of an image or images, content type also reflects the number of spatial dimensions in which the content is intended to be perceived and the perceived presence or absence of movement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contentTypeExpression</para>
    ///   <para>rdfs:label : Content type (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/contentTypeExpression">rdag1:contentTypeExpression</a>
    /// </summary>
    let contentTypeExpression = _prefixId.prefix "contentTypeExpression"

    /// <summary>
    ///   <para>rdfs:label : Coordinates of cartographic content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coordinatesOfCartographicContent</para>
    ///   <para>skos:definition : A mathematical system for identifying the area covered by the cartographic content of a resource. Coordinates may be expressed by means of longitude and latitude on the surface of planets or by the angles of right ascension and declination for celestial charts.</para>
    ///   <a href="http://rdvocab.info/Elements/coordinatesOfCartographicContent">rdag1:coordinatesOfCartographicContent</a>
    /// </summary>
    let coordinatesOfCartographicContent = _prefixId.prefix "coordinatesOfCartographicContent"

    /// <summary>
    ///   <para>rdfs:label : Coordinates of cartographic content (Work)</para>
    ///   <para>skos:definition : A mathematical system for identifying the area covered by the cartographic content of a resource. Coordinates may be expressed by means of longitude and latitude on the surface of planets or by the angles of right ascension and declination for celestial charts.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coordinatesOfCartographicContentWork</para>
    ///   <a href="http://rdvocab.info/Elements/coordinatesOfCartographicContentWork">rdag1:coordinatesOfCartographicContentWork</a>
    /// </summary>
    let coordinatesOfCartographicContentWork = _prefixId.prefix "coordinatesOfCartographicContentWork"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 2.10.0.1.1</para>
    ///   <para>skos:definition : A date associated with a claim of protection under copyright or a similar regime.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : copyrightDate</para>
    ///   <para>rdfs:label : Copyright date</para>
    ///   <a href="http://rdvocab.info/Elements/copyrightDate">rdag1:copyrightDate</a>
    /// </summary>
    let copyrightDate = _prefixId.prefix "copyrightDate"
    /// <summary>
    ///   <para>skos:definition : A date associated with a claim of protection under copyright or a similar regime.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : copyrightDateManifestation</para>
    ///   <para>rdfs:label : Copyright date (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/copyrightDateManifestation">rdag1:copyrightDateManifestation</a>
    /// </summary>
    let copyrightDateManifestation = _prefixId.prefix "copyrightDateManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.4.0.1.1</para>
    ///   <para>skos:definition : The chronological or geographic coverage of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coverageOfTheContent</para>
    ///   <para>rdfs:label : Coverage of the content</para>
    ///   <a href="http://rdvocab.info/Elements/coverageOfTheContent">rdag1:coverageOfTheContent</a>
    /// </summary>
    let coverageOfTheContent = _prefixId.prefix "coverageOfTheContent"
    /// <summary>
    ///   <para>skos:definition : The chronological or geographic coverage of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : coverageOfTheContentWork</para>
    ///   <para>rdfs:label : Coverage of the content (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/coverageOfTheContentWork">rdag1:coverageOfTheContentWork</a>
    /// </summary>
    let coverageOfTheContentWork = _prefixId.prefix "coverageOfTheContentWork"
    /// <summary>
    ///   <para>skos:definition : A record of previous ownership or custodianship of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodialHistoryOfItem</para>
    ///   <para>rdfs:label : Custodial history of item</para>
    ///   <a href="http://rdvocab.info/Elements/custodialHistoryOfItem">rdag1:custodialHistoryOfItem</a>
    /// </summary>
    let custodialHistoryOfItem = _prefixId.prefix "custodialHistoryOfItem"
    /// <summary>
    ///   <para>skos:definition : A date or range of dates associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfCapture</para>
    ///   <para>rdfs:label : Date of capture</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfCapture">rdag1:dateOfCapture</a>
    /// </summary>
    let dateOfCapture = _prefixId.prefix "dateOfCapture"
    /// <summary>
    ///   <para>skos:definition : A date or range of dates associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfCaptureExpression</para>
    ///   <para>rdfs:label : Date of capture (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfCaptureExpression">rdag1:dateOfCaptureExpression</a>
    /// </summary>
    let dateOfCaptureExpression = _prefixId.prefix "dateOfCaptureExpression"
    /// <summary>
    ///   <para>skos:definition : A date associated with the distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDistribution</para>
    ///   <para>rdfs:label : Date of distribution</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfDistribution">rdag1:dateOfDistribution</a>
    /// </summary>
    let dateOfDistribution = _prefixId.prefix "dateOfDistribution"

    /// <summary>
    ///   <para>skos:definition : A date associated with the distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfDistributionManifestation</para>
    ///   <para>rdfs:label : Date of distribution (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfDistributionManifestation">rdag1:dateOfDistributionManifestation</a>
    /// </summary>
    let dateOfDistributionManifestation = _prefixId.prefix "dateOfDistributionManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.32.0.1.1</para>
    ///   <para>skos:definition : The earliest date associated with an expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfExpression</para>
    ///   <para>rdfs:label : Date of expression</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfExpression">rdag1:dateOfExpression</a>
    /// </summary>
    let dateOfExpression = _prefixId.prefix "dateOfExpression"
    /// <summary>
    ///   <para>skos:definition : A date associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfManufacture</para>
    ///   <para>rdfs:label : Date of manufacture</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfManufacture">rdag1:dateOfManufacture</a>
    /// </summary>
    let dateOfManufacture = _prefixId.prefix "dateOfManufacture"

    /// <summary>
    ///   <para>skos:definition : A date associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfManufactureManifestation</para>
    ///   <para>rdfs:label : Date of manufacture (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfManufactureManifestation">rdag1:dateOfManufactureManifestation</a>
    /// </summary>
    let dateOfManufactureManifestation = _prefixId.prefix "dateOfManufactureManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 2.7.5.1.1</para>
    ///   <para>skos:definition : A date associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfProduction</para>
    ///   <para>rdfs:label : Date of production</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfProduction">rdag1:dateOfProduction</a>
    /// </summary>
    let dateOfProduction = _prefixId.prefix "dateOfProduction"
    /// <summary>
    ///   <para>skos:definition : A date associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfProductionManifestation</para>
    ///   <para>rdfs:label : Date of production (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfProductionManifestation">rdag1:dateOfProductionManifestation</a>
    /// </summary>
    let dateOfProductionManifestation = _prefixId.prefix "dateOfProductionManifestation"
    /// <summary>
    ///   <para>skos:definition : A date associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfPublication</para>
    ///   <para>rdfs:label : Date of publication</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfPublication">rdag1:dateOfPublication</a>
    /// </summary>
    let dateOfPublication = _prefixId.prefix "dateOfPublication"

    /// <summary>
    ///   <para>skos:definition : A date associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfPublicationManifestation</para>
    ///   <para>rdfs:label : Date of publication (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfPublicationManifestation">rdag1:dateOfPublicationManifestation</a>
    /// </summary>
    let dateOfPublicationManifestation = _prefixId.prefix "dateOfPublicationManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.5.0.1.1</para>
    ///   <para>skos:definition : The earliest date associated with a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dateOfWork</para>
    ///   <para>rdfs:label : Date of work</para>
    ///   <a href="http://rdvocab.info/Elements/dateOfWork">rdag1:dateOfWork</a>
    /// </summary>
    let dateOfWork = _prefixId.prefix "dateOfWork"

    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters, identifying a particular revision of a named edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : Designation of a named revision of an edition</para>
    ///   <a href="http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEdition">rdag1:designationOfANamedRevisionOfAnEdition</a>
    /// </summary>
    let designationOfANamedRevisionOfAnEdition = _prefixId.prefix "designationOfANamedRevisionOfAnEdition"

    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters, identifying a particular revision of a named edition. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfANamedRevisionOfAnEditionManifestation</para>
    ///   <para>rdfs:label : Designation of a named revision of an edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/designationOfANamedRevisionOfAnEditionManifestation">rdag1:designationOfANamedRevisionOfAnEditionManifestation</a>
    /// </summary>
    let designationOfANamedRevisionOfAnEditionManifestation = _prefixId.prefix "designationOfANamedRevisionOfAnEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters, identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfEdition</para>
    ///   <para>rdfs:label : Designation of edition</para>
    ///   <a href="http://rdvocab.info/Elements/designationOfEdition">rdag1:designationOfEdition</a>
    /// </summary>
    let designationOfEdition = _prefixId.prefix "designationOfEdition"

    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters, identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : designationOfEditionManifestation</para>
    ///   <para>rdfs:label : Designation of edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/designationOfEditionManifestation">rdag1:designationOfEditionManifestation</a>
    /// </summary>
    let designationOfEditionManifestation = _prefixId.prefix "designationOfEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalFileCharacteristic</para>
    ///   <para>rdfs:label : Digital file characteristic</para>
    ///   <a href="http://rdvocab.info/Elements/digitalFileCharacteristic">rdag1:digitalFileCharacteristic</a>
    /// </summary>
    let digitalFileCharacteristic = _prefixId.prefix "digitalFileCharacteristic"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalFileCharacteristicManifestation</para>
    ///   <para>rdfs:label : Digital file characteristic (Manifestation)</para>
    ///   <para>skos:definition : A technical specification relating to the digital encoding of text, image, audio, video, and other types of data in a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/digitalFileCharacteristicManifestation">rdag1:digitalFileCharacteristicManifestation</a>
    /// </summary>
    let digitalFileCharacteristicManifestation = _prefixId.prefix "digitalFileCharacteristicManifestation"

    /// <summary>
    ///   <para>skos:definition : A set of technical details relating to the encoding of geospatial information in a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalRepresentationOfCartographicContent</para>
    ///   <para>rdfs:label : Digital representation of cartographic content</para>
    ///   <a href="http://rdvocab.info/Elements/digitalRepresentationOfCartographicContent">rdag1:digitalRepresentationOfCartographicContent</a>
    /// </summary>
    let digitalRepresentationOfCartographicContent = _prefixId.prefix "digitalRepresentationOfCartographicContent"

    /// <summary>
    ///   <para>skos:definition : A set of technical details relating to the encoding of geospatial information in a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalRepresentationOfCartographicContentManifestation</para>
    ///   <para>rdfs:label : Digital representation of cartographic content (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/digitalRepresentationOfCartographicContentManifestation">rdag1:digitalRepresentationOfCartographicContentManifestation</a>
    /// </summary>
    let digitalRepresentationOfCartographicContentManifestation = _prefixId.prefix "digitalRepresentationOfCartographicContentManifestation"

    /// <summary>
    ///   <para>rdfs:label : Dimensions</para>
    ///   <para>skos:definition : The measurements of the carrier or carriers and/or the container of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensions</para>
    ///   <para>skos:scopeNote : Definition source: RDA 3.5.0.1.1</para>
    ///   <a href="http://rdvocab.info/Elements/dimensions">rdag1:dimensions</a>
    /// </summary>
    let dimensions = _prefixId.prefix "dimensions"
    /// <summary>
    ///   <para>rdfs:label : Dimensions (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsItem</para>
    ///   <para>skos:definition : The measurements of the carrier or carriers and/or the container of a resource. </para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsItem">rdag1:dimensionsItem</a>
    /// </summary>
    let dimensionsItem = _prefixId.prefix "dimensionsItem"
    /// <summary>
    ///   <para>skos:definition : The measurements of the carrier or carriers and/or the container of a resource. </para>
    ///   <para>rdfs:label : Dimensions (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsManifestation">rdag1:dimensionsManifestation</a>
    /// </summary>
    let dimensionsManifestation = _prefixId.prefix "dimensionsManifestation"
    /// <summary>
    ///   <para>skos:definition : The measurements of the face of a map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfMapEtc</para>
    ///   <para>rdfs:label : Dimensions of map, etc.</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfMapEtc">rdag1:dimensionsOfMapEtc</a>
    /// </summary>
    let dimensionsOfMapEtc = _prefixId.prefix "dimensionsOfMapEtc"
    /// <summary>
    ///   <para>skos:definition : The measurements of the face of a map, etc. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfMapEtcItem</para>
    ///   <para>rdfs:label : Dimensions of map, etc. (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfMapEtcItem">rdag1:dimensionsOfMapEtcItem</a>
    /// </summary>
    let dimensionsOfMapEtcItem = _prefixId.prefix "dimensionsOfMapEtcItem"

    /// <summary>
    ///   <para>skos:definition : The measurements of the face of a map, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfMapEtcManifestation</para>
    ///   <para>rdfs:label : Dimensions of map, etc. (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfMapEtcManifestation">rdag1:dimensionsOfMapEtcManifestation</a>
    /// </summary>
    let dimensionsOfMapEtcManifestation = _prefixId.prefix "dimensionsOfMapEtcManifestation"

    /// <summary>
    ///   <para>skos:definition : The measurements of the pictorial area of a still image.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfStillImage</para>
    ///   <para>rdfs:label : Dimensions of still image</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfStillImage">rdag1:dimensionsOfStillImage</a>
    /// </summary>
    let dimensionsOfStillImage = _prefixId.prefix "dimensionsOfStillImage"
    /// <summary>
    ///   <para>skos:definition : The measurements of the pictorial area of a still image. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfStillImageItem</para>
    ///   <para>rdfs:label : Dimensions of still image (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfStillImageItem">rdag1:dimensionsOfStillImageItem</a>
    /// </summary>
    let dimensionsOfStillImageItem = _prefixId.prefix "dimensionsOfStillImageItem"

    /// <summary>
    ///   <para>skos:definition : The measurements of the pictorial area of a still image. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dimensionsOfStillImageManifestation</para>
    ///   <para>rdfs:label : Dimensions of still image (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/dimensionsOfStillImageManifestation">rdag1:dimensionsOfStillImageManifestation</a>
    /// </summary>
    let dimensionsOfStillImageManifestation = _prefixId.prefix "dimensionsOfStillImageManifestation"

    let dissertationOrThesesInformationWork = _prefixId.prefix "dissertationOrThesesInformationWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dissertationOrThesisInformation</para>
    ///   <para>rdfs:label : Dissertation or thesis information</para>
    ///   <a href="http://rdvocab.info/Elements/dissertationOrThesisInformation">rdag1:dissertationOrThesisInformation</a>
    /// </summary>
    let dissertationOrThesisInformation = _prefixId.prefix "dissertationOrThesisInformation"

    /// <summary>
    ///   <para>rdfs:label : Dissertation or thesis information (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dissertationOrThesisInformationWork</para>
    ///   <para>skos:definition : Information relating to a work presented as part of the formal requirements for an academic degree</para>
    ///   <a href="http://rdvocab.info/Elements/dissertationOrThesisInformationWork">rdag1:dissertationOrThesisInformationWork</a>
    /// </summary>
    let dissertationOrThesisInformationWork = _prefixId.prefix "dissertationOrThesisInformationWork"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of distribution, distributor or distributors, and date or dates of distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributionStatement</para>
    ///   <para>rdfs:label : Distribution statement</para>
    ///   <a href="http://rdvocab.info/Elements/distributionStatement">rdag1:distributionStatement</a>
    /// </summary>
    let distributionStatement = _prefixId.prefix "distributionStatement"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of distribution, distributor or distributors, and date or dates of distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributionStatementManifestation</para>
    ///   <para>rdfs:label : Distribution statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/distributionStatementManifestation">rdag1:distributionStatementManifestation</a>
    /// </summary>
    let distributionStatementManifestation = _prefixId.prefix "distributionStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for distributing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorsName</para>
    ///   <para>rdfs:label : Distributor's name</para>
    ///   <a href="http://rdvocab.info/Elements/distributorsName">rdag1:distributorsName</a>
    /// </summary>
    let distributorsName = _prefixId.prefix "distributorsName"
    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for distributing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : distributorsNameManifestation</para>
    ///   <para>rdfs:label : Distributor's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/distributorsNameManifestation">rdag1:distributorsNameManifestation</a>
    /// </summary>
    let distributorsNameManifestation = _prefixId.prefix "distributorsNameManifestation"
    /// <summary>
    ///   <para>skos:definition : The playing time, running time, etc., of the content of a resource. Duration also includes performance time for a resource containing notated music or notated movement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : duration</para>
    ///   <para>rdfs:label : Duration</para>
    ///   <a href="http://rdvocab.info/Elements/duration">rdag1:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>skos:definition : The playing time, running time, etc., of the content of a resource. Duration also includes performance time for a resource containing notated music or notated movement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : durationExpression</para>
    ///   <para>rdfs:label : Duration (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/durationExpression">rdag1:durationExpression</a>
    /// </summary>
    let durationExpression = _prefixId.prefix "durationExpression"
    /// <summary>
    ///   <para>skos:definition : A title proper appearing on an earlier iteration of an integrating resource that differs from that on the current iteration.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : earlierTitleProper</para>
    ///   <para>rdfs:label : Earlier title proper</para>
    ///   <a href="http://rdvocab.info/Elements/earlierTitleProper">rdag1:earlierTitleProper</a>
    /// </summary>
    let earlierTitleProper = _prefixId.prefix "earlierTitleProper"

    /// <summary>
    ///   <para>skos:definition : A title proper appearing on an earlier iteration of an integrating resource that differs from that on the current iteration.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : earlierTitleProperManifestation</para>
    ///   <para>rdfs:label : Earlier title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/earlierTitleProperManifestation">rdag1:earlierTitleProperManifestation</a>
    /// </summary>
    let earlierTitleProperManifestation = _prefixId.prefix "earlierTitleProperManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editionStatement</para>
    ///   <para>rdfs:label : Edition statement</para>
    ///   <a href="http://rdvocab.info/Elements/editionStatement">rdag1:editionStatement</a>
    /// </summary>
    let editionStatement = _prefixId.prefix "editionStatement"
    /// <summary>
    ///   <para>skos:definition : A statement identifying the edition to which a resource belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : editionStatementManifestation</para>
    ///   <para>rdfs:label : Edition statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/editionStatementManifestation">rdag1:editionStatementManifestation</a>
    /// </summary>
    let editionStatementManifestation = _prefixId.prefix "editionStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : emulsionOnMicrofilmAndMicrofiche</para>
    ///   <para>rdfs:label : Emulsion on microfilm and microfiche</para>
    ///   <a href="http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicrofiche">rdag1:emulsionOnMicrofilmAndMicrofiche</a>
    /// </summary>
    let emulsionOnMicrofilmAndMicrofiche = _prefixId.prefix "emulsionOnMicrofilmAndMicrofiche"

    /// <summary>
    ///   <para>skos:definition : A suspension of light-sensitive chemicals used as a coating on a microfilm or microfiche (e.g., silver halide).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : emulsionOnMicrofilmAndMicroficheManifestation</para>
    ///   <para>rdfs:label : Emulsion on microfilm and microfiche (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/emulsionOnMicrofilmAndMicroficheManifestation">rdag1:emulsionOnMicrofilmAndMicroficheManifestation</a>
    /// </summary>
    let emulsionOnMicrofilmAndMicroficheManifestation = _prefixId.prefix "emulsionOnMicrofilmAndMicroficheManifestation"

    /// <summary>
    ///   <para>skos:definition : A schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodingFormat</para>
    ///   <para>rdfs:label : Encoding format</para>
    ///   <a href="http://rdvocab.info/Elements/encodingFormat">rdag1:encodingFormat</a>
    /// </summary>
    let encodingFormat = _prefixId.prefix "encodingFormat"
    /// <summary>
    ///   <para>skos:definition : A schema, standard, etc., used to encode the digital content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : encodingFormatManifestation</para>
    ///   <para>rdfs:label : Encoding format (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/encodingFormatManifestation">rdag1:encodingFormatManifestation</a>
    /// </summary>
    let encodingFormatManifestation = _prefixId.prefix "encodingFormatManifestation"
    /// <summary>
    ///   <para>skos:definition : An arbitrary moment in time to which measurements of position for a body or orientation for an orbit are referred.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : epoch</para>
    ///   <para>rdfs:label : Epoch</para>
    ///   <a href="http://rdvocab.info/Elements/epoch">rdag1:epoch</a>
    /// </summary>
    let epoch = _prefixId.prefix "epoch"
    /// <summary>
    ///   <para>skos:definition : An arbitrary moment in time to which measurements of position for a body or orientation for an orbit are referred.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : epochWork</para>
    ///   <para>rdfs:label : Epoch (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/epochWork">rdag1:epochWork</a>
    /// </summary>
    let epochWork = _prefixId.prefix "epochWork"
    /// <summary>
    ///   <para>skos:definition : One of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0°.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equinox</para>
    ///   <para>rdfs:label : Equinox</para>
    ///   <a href="http://rdvocab.info/Elements/equinox">rdag1:equinox</a>
    /// </summary>
    let equinox = _prefixId.prefix "equinox"
    /// <summary>
    ///   <para>skos:definition : One of two points of intersection of the ecliptic and the celestial equator, occupied by the sun when its declination is 0°.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equinoxWork</para>
    ///   <para>rdfs:label : Equinox (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/equinoxWork">rdag1:equinoxWork</a>
    /// </summary>
    let equinoxWork = _prefixId.prefix "equinoxWork"
    /// <summary>
    ///   <para>skos:definition : The equipment or system required for use, playback, etc., of an analog, digital, etc., resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equipmentOrSystemRequirement</para>
    ///   <para>rdfs:label : Equipment or system requirement</para>
    ///   <a href="http://rdvocab.info/Elements/equipmentOrSystemRequirement">rdag1:equipmentOrSystemRequirement</a>
    /// </summary>
    let equipmentOrSystemRequirement = _prefixId.prefix "equipmentOrSystemRequirement"

    /// <summary>
    ///   <para>skos:definition : The equipment or system required for use, playback, etc., of an analog, digital, etc., resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equipmentOrSystemRequirementManifestation</para>
    ///   <para>rdfs:label : Equipment or system requirement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/equipmentOrSystemRequirementManifestation">rdag1:equipmentOrSystemRequirementManifestation</a>
    /// </summary>
    let equipmentOrSystemRequirementManifestation = _prefixId.prefix "equipmentOrSystemRequirementManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extent</para>
    ///   <para>skos:scopeNote : Definition source: RDA 3.4.0.1.1</para>
    ///   <para>rdfs:label : Extent</para>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/extent">rdag1:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>rdfs:label : Extent (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentItem</para>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/extentItem">rdag1:extentItem</a>
    /// </summary>
    let extentItem = _prefixId.prefix "extentItem"
    /// <summary>
    ///   <para>rdfs:label : Extent (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentManifestation</para>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/extentManifestation">rdag1:extentManifestation</a>
    /// </summary>
    let extentManifestation = _prefixId.prefix "extentManifestation"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a cartographic resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfCartographicResource</para>
    ///   <para>rdfs:label : Extent of cartographic resource</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfCartographicResource">rdag1:extentOfCartographicResource</a>
    /// </summary>
    let extentOfCartographicResource = _prefixId.prefix "extentOfCartographicResource"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a cartographic resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfCartographicResourceItem</para>
    ///   <para>rdfs:label : Extent of cartographic resource (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfCartographicResourceItem">rdag1:extentOfCartographicResourceItem</a>
    /// </summary>
    let extentOfCartographicResourceItem = _prefixId.prefix "extentOfCartographicResourceItem"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a cartographic resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfCartographicResourceManifestation</para>
    ///   <para>rdfs:label : Extent of cartographic resource (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfCartographicResourceManifestation">rdag1:extentOfCartographicResourceManifestation</a>
    /// </summary>
    let extentOfCartographicResourceManifestation = _prefixId.prefix "extentOfCartographicResourceManifestation"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of notated music, with or without accompanying text and/or illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfNotatedMusic</para>
    ///   <para>rdfs:label : Extent of notated music</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfNotatedMusic">rdag1:extentOfNotatedMusic</a>
    /// </summary>
    let extentOfNotatedMusic = _prefixId.prefix "extentOfNotatedMusic"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of notated music, with or without accompanying text and/or illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfNotatedMusicItem</para>
    ///   <para>rdfs:label : Extent of notated music (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfNotatedMusicItem">rdag1:extentOfNotatedMusicItem</a>
    /// </summary>
    let extentOfNotatedMusicItem = _prefixId.prefix "extentOfNotatedMusicItem"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of notated music, with or without accompanying text and/or illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfNotatedMusicManifestation</para>
    ///   <para>rdfs:label : Extent of notated music (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfNotatedMusicManifestation">rdag1:extentOfNotatedMusicManifestation</a>
    /// </summary>
    let extentOfNotatedMusicManifestation = _prefixId.prefix "extentOfNotatedMusicManifestation"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of one or more still images.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfStillImage</para>
    ///   <para>rdfs:label : Extent of still image</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfStillImage">rdag1:extentOfStillImage</a>
    /// </summary>
    let extentOfStillImage = _prefixId.prefix "extentOfStillImage"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of one or more still images. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfStillImageItem</para>
    ///   <para>rdfs:label : Extent of still image (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfStillImageItem">rdag1:extentOfStillImageItem</a>
    /// </summary>
    let extentOfStillImageItem = _prefixId.prefix "extentOfStillImageItem"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of one or more still images.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfStillImageManifestation</para>
    ///   <para>rdfs:label : Extent of still image (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfStillImageManifestation">rdag1:extentOfStillImageManifestation</a>
    /// </summary>
    let extentOfStillImageManifestation = _prefixId.prefix "extentOfStillImageManifestation"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of text, with or without accompanying illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfText</para>
    ///   <para>rdfs:label : Extent of text</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfText">rdag1:extentOfText</a>
    /// </summary>
    let extentOfText = _prefixId.prefix "extentOfText"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of text, with or without accompanying illustrations</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfTextItem</para>
    ///   <para>rdfs:label : Extent of text (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfTextItem">rdag1:extentOfTextItem</a>
    /// </summary>
    let extentOfTextItem = _prefixId.prefix "extentOfTextItem"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of text, with or without accompanying illustrations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfTextManifestation</para>
    ///   <para>rdfs:label : Extent of text (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfTextManifestation">rdag1:extentOfTextManifestation</a>
    /// </summary>
    let extentOfTextManifestation = _prefixId.prefix "extentOfTextManifestation"
    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource
    /// consisting of one or more three-dimensional forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfThreeDimensionalForm</para>
    ///   <para>rdfs:label : Extent of three-dimensional form</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfThreeDimensionalForm">rdag1:extentOfThreeDimensionalForm</a>
    /// </summary>
    let extentOfThreeDimensionalForm = _prefixId.prefix "extentOfThreeDimensionalForm"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of one or more three-dimensional forms. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfThreeDimensionalFormItem</para>
    ///   <para>rdfs:label : Extent of three-dimensional form (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfThreeDimensionalFormItem">rdag1:extentOfThreeDimensionalFormItem</a>
    /// </summary>
    let extentOfThreeDimensionalFormItem = _prefixId.prefix "extentOfThreeDimensionalFormItem"

    /// <summary>
    ///   <para>skos:definition : The number and type of units and/or subunits making up a resource consisting of one or more three-dimensional forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : extentOfThreeDimensionalFormManifestation</para>
    ///   <para>rdfs:label : Extent of three-dimensional form (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/extentOfThreeDimensionalFormManifestation">rdag1:extentOfThreeDimensionalFormManifestation</a>
    /// </summary>
    let extentOfThreeDimensionalFormManifestation = _prefixId.prefix "extentOfThreeDimensionalFormManifestation"

    /// <summary>
    ///   <para>skos:definition : The number of bytes in a digital file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileSize</para>
    ///   <para>rdfs:label : File size</para>
    ///   <a href="http://rdvocab.info/Elements/fileSize">rdag1:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>skos:definition : The number of bytes in a digital file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileSizeManifestation</para>
    ///   <para>rdfs:label : File size (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/fileSizeManifestation">rdag1:fileSizeManifestation</a>
    /// </summary>
    let fileSizeManifestation = _prefixId.prefix "fileSizeManifestation"
    /// <summary>
    ///   <para>skos:definition : A general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileType</para>
    ///   <para>rdfs:label : File type</para>
    ///   <a href="http://rdvocab.info/Elements/fileType">rdag1:fileType</a>
    /// </summary>
    let fileType = _prefixId.prefix "fileType"
    /// <summary>
    ///   <para>skos:definition : A general type of data content encoded in a computer file.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fileTypeManifestation</para>
    ///   <para>rdfs:label : File type (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/fileTypeManifestation">rdag1:fileTypeManifestation</a>
    /// </summary>
    let fileTypeManifestation = _prefixId.prefix "fileTypeManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.14.0.1.1</para>
    ///   <para>skos:definition : The size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fontSize</para>
    ///   <para>rdfs:label : Font size</para>
    ///   <a href="http://rdvocab.info/Elements/fontSize">rdag1:fontSize</a>
    /// </summary>
    let fontSize = _prefixId.prefix "fontSize"
    /// <summary>
    ///   <para>skos:definition : The size of the type used to represent the characters and symbols in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : fontSizeManifestation</para>
    ///   <para>rdfs:label : Font size (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/fontSizeManifestation">rdag1:fontSizeManifestation</a>
    /// </summary>
    let fontSizeManifestation = _prefixId.prefix "fontSizeManifestation"
    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the musical content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfMusicalNotation</para>
    ///   <para>rdfs:label : Form of musical notation</para>
    ///   <a href="http://rdvocab.info/Elements/formOfMusicalNotation">rdag1:formOfMusicalNotation</a>
    /// </summary>
    let formOfMusicalNotation = _prefixId.prefix "formOfMusicalNotation"

    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the musical content of a resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfMusicalNotationExpression</para>
    ///   <para>rdfs:label : Form of musical notation (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/formOfMusicalNotationExpression">rdag1:formOfMusicalNotationExpression</a>
    /// </summary>
    let formOfMusicalNotationExpression = _prefixId.prefix "formOfMusicalNotationExpression"

    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the movement content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotatedMovement</para>
    ///   <para>rdfs:label : Form of notated movement</para>
    ///   <a href="http://rdvocab.info/Elements/formOfNotatedMovement">rdag1:formOfNotatedMovement</a>
    /// </summary>
    let formOfNotatedMovement = _prefixId.prefix "formOfNotatedMovement"

    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the movement content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotatedMovementExpression</para>
    ///   <para>rdfs:label : Form of notated movement (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/formOfNotatedMovementExpression">rdag1:formOfNotatedMovementExpression</a>
    /// </summary>
    let formOfNotatedMovementExpression = _prefixId.prefix "formOfNotatedMovementExpression"

    /// <summary>
    ///   <para>rdfs:label : Form of notation</para>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the content of a resource.</para>
    ///   <para>skos:scopeNote : Definition source: RDA 7.11.0.1.1</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotation</para>
    ///   <a href="http://rdvocab.info/Elements/formOfNotation">rdag1:formOfNotation</a>
    /// </summary>
    let formOfNotation = _prefixId.prefix "formOfNotation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfNotationExpression</para>
    ///   <para>rdfs:label : Form of notation (Expression)</para>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the content of a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/formOfNotationExpression">rdag1:formOfNotationExpression</a>
    /// </summary>
    let formOfNotationExpression = _prefixId.prefix "formOfNotationExpression"
    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the content of a resource in a form that can be perceived through touch.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfTactileNotation</para>
    ///   <para>rdfs:label : Form of tactile notation</para>
    ///   <a href="http://rdvocab.info/Elements/formOfTactileNotation">rdag1:formOfTactileNotation</a>
    /// </summary>
    let formOfTactileNotation = _prefixId.prefix "formOfTactileNotation"

    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the content of a resource in a form that can be perceived through touch.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfTactileNotationExpression</para>
    ///   <para>rdfs:label : Form of tactile notation (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/formOfTactileNotationExpression">rdag1:formOfTactileNotationExpression</a>
    /// </summary>
    let formOfTactileNotationExpression = _prefixId.prefix "formOfTactileNotationExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.4.0.1.1</para>
    ///   <para>skos:definition : A class or genre to which a work belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formOfWork</para>
    ///   <para>rdfs:label : Form of work</para>
    ///   <a href="http://rdvocab.info/Elements/formOfWork">rdag1:formOfWork</a>
    /// </summary>
    let formOfWork = _prefixId.prefix "formOfWork"
    /// <summary>
    ///   <para>skos:definition : The musical or physical layout of the content of a resource that is presented in the form of musical notation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formatOfNotatedMusic</para>
    ///   <para>rdfs:label : Format of notated music</para>
    ///   <a href="http://rdvocab.info/Elements/formatOfNotatedMusic">rdag1:formatOfNotatedMusic</a>
    /// </summary>
    let formatOfNotatedMusic = _prefixId.prefix "formatOfNotatedMusic"

    /// <summary>
    ///   <para>skos:definition : The musical or physical layout of the content of a resource that is presented in the form of musical notation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formatOfNotatedMusicExpression</para>
    ///   <para>rdfs:label : Format of notated music (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/formatOfNotatedMusicExpression">rdag1:formatOfNotatedMusicExpression</a>
    /// </summary>
    let formatOfNotatedMusicExpression = _prefixId.prefix "formatOfNotatedMusicExpression"

    /// <summary>
    ///   <para>skos:definition : The intervals at which the issues or parts of a serial or the updates to an integrating resource are issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : frequency</para>
    ///   <para>rdfs:label : Frequency</para>
    ///   <a href="http://rdvocab.info/Elements/frequency">rdag1:frequency</a>
    /// </summary>
    let frequency = _prefixId.prefix "frequency"
    /// <summary>
    ///   <para>skos:definition : The intervals at which the issues or parts of a serial or the updates to an integrating resource are issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : frequencyManifestation</para>
    ///   <para>rdfs:label : Frequency (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/frequencyManifestation">rdag1:frequencyManifestation</a>
    /// </summary>
    let frequencyManifestation = _prefixId.prefix "frequencyManifestation"
    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generation</para>
    ///   <para>rdfs:label : Generation</para>
    ///   <para>skos:scopeNote : Definition source: RDA 3.9.0.1.1</para>
    ///   <a href="http://rdvocab.info/Elements/generation">rdag1:generation</a>
    /// </summary>
    let generation = _prefixId.prefix "generation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationManifestation</para>
    ///   <para>skos:definition : The relationship between an original carrier and the carrier of a reproduction made from the original (e.g., a first generation camera master, a second generation printing master).</para>
    ///   <para>rdfs:label : Generation (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationManifestation">rdag1:generationManifestation</a>
    /// </summary>
    let generationManifestation = _prefixId.prefix "generationManifestation"
    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of an audio recording and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfAudioRecording</para>
    ///   <para>rdfs:label : Generation of audio recording</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfAudioRecording">rdag1:generationOfAudioRecording</a>
    /// </summary>
    let generationOfAudioRecording = _prefixId.prefix "generationOfAudioRecording"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of an audio recording and the carrier of a reproduction made from the original (e.g., a tape duplication master, a test pressing).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfAudioRecordingManifestation</para>
    ///   <para>rdfs:label : Generation of audio recording (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfAudioRecordingManifestation">rdag1:generationOfAudioRecordingManifestation</a>
    /// </summary>
    let generationOfAudioRecordingManifestation = _prefixId.prefix "generationOfAudioRecordingManifestation"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfDigitalResource</para>
    ///   <para>rdfs:label : Generation of digital resource</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfDigitalResource">rdag1:generationOfDigitalResource</a>
    /// </summary>
    let generationOfDigitalResource = _prefixId.prefix "generationOfDigitalResource"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a digital resource and the carrier of a reproduction made from the original (e.g., a derivative master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfDigitalResourceManifestation</para>
    ///   <para>rdfs:label : Generation of digital resource (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfDigitalResourceManifestation">rdag1:generationOfDigitalResourceManifestation</a>
    /// </summary>
    let generationOfDigitalResourceManifestation = _prefixId.prefix "generationOfDigitalResourceManifestation"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a microform resource and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMicroform</para>
    ///   <para>rdfs:label : Generation of microform</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfMicroform">rdag1:generationOfMicroform</a>
    /// </summary>
    let generationOfMicroform = _prefixId.prefix "generationOfMicroform"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a microform resource and the carrier of a reproduction made from the original (e.g., a printing master).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMicroformManifestation</para>
    ///   <para>rdfs:label : Generation of microform (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfMicroformManifestation">rdag1:generationOfMicroformManifestation</a>
    /// </summary>
    let generationOfMicroformManifestation = _prefixId.prefix "generationOfMicroformManifestation"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMotionPictureFilm</para>
    ///   <para>rdfs:label : Generation of motion picture film</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfMotionPictureFilm">rdag1:generationOfMotionPictureFilm</a>
    /// </summary>
    let generationOfMotionPictureFilm = _prefixId.prefix "generationOfMotionPictureFilm"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a motion picture film resource and the carrier of a reproduction made from the original (e.g., a reference print).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfMotionPictureFilmManifestation</para>
    ///   <para>rdfs:label : Generation of motion picture film (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfMotionPictureFilmManifestation">rdag1:generationOfMotionPictureFilmManifestation</a>
    /// </summary>
    let generationOfMotionPictureFilmManifestation = _prefixId.prefix "generationOfMotionPictureFilmManifestation"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfVideotape</para>
    ///   <para>rdfs:label : Generation of videotape</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfVideotape">rdag1:generationOfVideotape</a>
    /// </summary>
    let generationOfVideotape = _prefixId.prefix "generationOfVideotape"

    /// <summary>
    ///   <para>skos:definition : The relationship between an original carrier of a videotape resource and the carrier of a reproduction made from the original (e.g., a show copy).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : generationOfVideotapeManifestation</para>
    ///   <para>rdfs:label : Generation of videotape (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/generationOfVideotapeManifestation">rdag1:generationOfVideotapeManifestation</a>
    /// </summary>
    let generationOfVideotapeManifestation = _prefixId.prefix "generationOfVideotapeManifestation"

    /// <summary>
    ///   <para>skos:definition : An institution or faculty conferring an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grantingInstitutionOrFaculty</para>
    ///   <para>rdfs:label : Granting institution or faculty</para>
    ///   <a href="http://rdvocab.info/Elements/grantingInstitutionOrFaculty">rdag1:grantingInstitutionOrFaculty</a>
    /// </summary>
    let grantingInstitutionOrFaculty = _prefixId.prefix "grantingInstitutionOrFaculty"

    /// <summary>
    ///   <para>skos:definition : An institution or faculty conferring an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grantingInstitutionOrFacultyWork</para>
    ///   <para>rdfs:label : Granting institution or faculty (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/grantingInstitutionOrFacultyWork">rdag1:grantingInstitutionOrFacultyWork</a>
    /// </summary>
    let grantingInstitutionOrFacultyWork = _prefixId.prefix "grantingInstitutionOrFacultyWork"

    /// <summary>
    ///   <para>skos:definition : The groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grooveCharacteristic</para>
    ///   <para>rdfs:label : Groove characteristic</para>
    ///   <a href="http://rdvocab.info/Elements/grooveCharacteristic">rdag1:grooveCharacteristic</a>
    /// </summary>
    let grooveCharacteristic = _prefixId.prefix "grooveCharacteristic"

    /// <summary>
    ///   <para>skos:definition : The groove width of an analog disc or the groove pitch of an analog cylinder.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : grooveCharacteristicManifestation</para>
    ///   <para>rdfs:label : Groove characteristic (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/grooveCharacteristicManifestation">rdag1:grooveCharacteristicManifestation</a>
    /// </summary>
    let grooveCharacteristicManifestation = _prefixId.prefix "grooveCharacteristicManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.9.0.1.1</para>
    ///   <para>skos:definition : Information pertaining to the history of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : historyOfTheWork</para>
    ///   <para>rdfs:label : History of the work</para>
    ///   <a href="http://rdvocab.info/Elements/historyOfTheWork">rdag1:historyOfTheWork</a>
    /// </summary>
    let historyOfTheWork = _prefixId.prefix "historyOfTheWork"

    /// <summary>
    ///   <para>skos:definition : The ratio of horizontal distances in the cartographic content of a resource to the actual distances they represent.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : horizontalScaleOfCartographicContent</para>
    ///   <para>rdfs:label : Horizontal scale of cartographic content</para>
    ///   <a href="http://rdvocab.info/Elements/horizontalScaleOfCartographicContent">rdag1:horizontalScaleOfCartographicContent</a>
    /// </summary>
    let horizontalScaleOfCartographicContent = _prefixId.prefix "horizontalScaleOfCartographicContent"

    /// <summary>
    ///   <para>skos:definition : The ratio of horizontal distances in the cartographic content of a resource to the actual distances they represent.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : horizontalScaleOfCartographicContentExpression</para>
    ///   <para>rdfs:label : Horizontal scale of cartographic content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/horizontalScaleOfCartographicContentExpression">rdag1:horizontalScaleOfCartographicContentExpression</a>
    /// </summary>
    let horizontalScaleOfCartographicContentExpression = _prefixId.prefix "horizontalScaleOfCartographicContentExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.16.0.1.1</para>
    ///   <para>skos:definition : A character string uniquely associated with an expression, or with a surrogate for an expression (e.g., an authority record), that serves to
    /// differentiate that expression from other expressions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheExpression</para>
    ///   <para>rdfs:label : Identifier for the expression</para>
    ///   <a href="http://rdvocab.info/Elements/identifierForTheExpression">rdag1:identifierForTheExpression</a>
    /// </summary>
    let identifierForTheExpression = _prefixId.prefix "identifierForTheExpression"
    /// <summary>
    ///   <para>skos:definition : A character string associated with an item that serves to differentiate that item from other items.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheItem</para>
    ///   <para>rdfs:label : Identifier for the item</para>
    ///   <a href="http://rdvocab.info/Elements/identifierForTheItem">rdag1:identifierForTheItem</a>
    /// </summary>
    let identifierForTheItem = _prefixId.prefix "identifierForTheItem"
    /// <summary>
    ///   <para>skos:definition : A character string associated with a manifestation that serves to differentiate that manifestation from other manifestations.</para>
    ///   <para>skos:scopeNote :  Definition source: RDA 2.14.0.1.1 </para>
    ///   <para>rdfs:label : Identifier for the manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/identifierForTheManifestation">rdag1:identifierForTheManifestation</a>
    /// </summary>
    let identifierForTheManifestation = _prefixId.prefix "identifierForTheManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.10.0.1.1.</para>
    ///   <para>skos:definition : A character string uniquely associated with a work, or with a surrogate for a work (e.g., an authority record) that serves to differentiate that work from other works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheWork</para>
    ///   <para>rdfs:label : Identifier for the work</para>
    ///   <a href="http://rdvocab.info/Elements/identifierForTheWork">rdag1:identifierForTheWork</a>
    /// </summary>
    let identifierForTheWork = _prefixId.prefix "identifierForTheWork"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.12.0.1.1</para>
    ///   <para>skos:definition : Content designed to illustrate the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrativeContent</para>
    ///   <para>rdfs:label : Illustrative content</para>
    ///   <a href="http://rdvocab.info/Elements/illustrativeContent">rdag1:illustrativeContent</a>
    /// </summary>
    let illustrativeContent = _prefixId.prefix "illustrativeContent"
    /// <summary>
    ///   <para>skos:definition : Content designed to illustrate the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrativeContentExpression</para>
    ///   <para>rdfs:label : Illustrative content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/illustrativeContentExpression">rdag1:illustrativeContentExpression</a>
    /// </summary>
    let illustrativeContentExpression = _prefixId.prefix "illustrativeContentExpression"

    /// <summary>
    ///   <para>skos:definition : The source from which the agency directly acquired an item and the circumstances under which it was received.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : immediateSourceOfAcquisitionOfItem</para>
    ///   <para>rdfs:label : Immediate source of acquisition of item</para>
    ///   <a href="http://rdvocab.info/Elements/immediateSourceOfAcquisitionOfItem">rdag1:immediateSourceOfAcquisitionOfItem</a>
    /// </summary>
    let immediateSourceOfAcquisitionOfItem = _prefixId.prefix "immediateSourceOfAcquisitionOfItem"

    /// <summary>
    ///   <para>skos:definition : The class of user for which the content of a resource is intended, or for whom the content is considered suitable, as defined by age group (e.g., children, young adults, adults, etc.), educational level (e.g., primary, secondary, etc.), type of disability, or other categorization.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intendedAudience</para>
    ///   <para>rdfs:label : Intended audience</para>
    ///   <a href="http://rdvocab.info/Elements/intendedAudience">rdag1:intendedAudience</a>
    /// </summary>
    let intendedAudience = _prefixId.prefix "intendedAudience"
    /// <summary>
    ///   <para>skos:definition : The class of user for which the content of a resource is intended, or for whom the content is considered suitable, as defined by age group (e.g., children, young adults, adults, etc.), educational level (e.g., primary, secondary, etc.), type of disability, or other categorization.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : intendedAudienceWork</para>
    ///   <para>rdfs:label : Intended audience (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/intendedAudienceWork">rdag1:intendedAudienceWork</a>
    /// </summary>
    let intendedAudienceWork = _prefixId.prefix "intendedAudienceWork"
    /// <summary>
    ///   <para>skos:scopeNote : ISO 3297</para>
    ///   <para>skos:definition : The identifier assigned to a series by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSeries</para>
    ///   <para>rdfs:label : ISSN of series</para>
    ///   <a href="http://rdvocab.info/Elements/issnOfSeries">rdag1:issnOfSeries</a>
    /// </summary>
    let issnOfSeries = _prefixId.prefix "issnOfSeries"
    /// <summary>
    ///   <para>skos:definition : The identifier assigned to a series by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSeriesManifestation</para>
    ///   <para>rdfs:label : ISSN of series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/issnOfSeriesManifestation">rdag1:issnOfSeriesManifestation</a>
    /// </summary>
    let issnOfSeriesManifestation = _prefixId.prefix "issnOfSeriesManifestation"
    /// <summary>
    ///   <para>skos:definition : The identifier assigned to a subseries by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSubseries</para>
    ///   <para>rdfs:label : ISSN of subseries</para>
    ///   <a href="http://rdvocab.info/Elements/issnOfSubseries">rdag1:issnOfSubseries</a>
    /// </summary>
    let issnOfSubseries = _prefixId.prefix "issnOfSubseries"
    /// <summary>
    ///   <para>skos:definition : The identifier assigned to a subseries by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issnOfSubseriesManifestation</para>
    ///   <para>rdfs:label : ISSN of subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/issnOfSubseriesManifestation">rdag1:issnOfSubseriesManifestation</a>
    /// </summary>
    let issnOfSubseriesManifestation = _prefixId.prefix "issnOfSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A characteristic that applies to the carrier or carriers of the specific item being described and is assumed not to apply to other items
    /// exemplifying the same manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : item-specificCarrierCharacteristic</para>
    ///   <para>rdfs:label : Item-specific carrier characteristic</para>
    ///   <a href="http://rdvocab.info/Elements/item-specificCarrierCharacteristic">rdag1:item-specificCarrierCharacteristic</a>
    /// </summary>
    let item_specificCarrierCharacteristic = _prefixId.prefix "item-specificCarrierCharacteristic"

    /// <summary>
    ///   <para>skos:definition : A characteristic that applies to the carrier or carriers of the specific early printed item being described and is assumed not to apply to other items exemplifying the same manifestation. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : item-specificCarrierCharacteristicOfEarlyPrintedResources</para>
    ///   <para>rdfs:label : Item-specific carrier characteristic of early printed resources</para>
    ///   <para>rdfs:comment : Includes rubrication, illumination, and other hand colouring, manuscript additions, and binding.</para>
    ///   <a href="http://rdvocab.info/Elements/item-specificCarrierCharacteristicOfEarlyPrintedResources">rdag1:item-specificCarrierCharacteristicOfEarlyPrintedResources</a>
    /// </summary>
    let item_specificCarrierCharacteristicOfEarlyPrintedResources = _prefixId.prefix "item-specificCarrierCharacteristicOfEarlyPrintedResources"

    /// <summary>
    ///   <para>skos:scopeNote : Definition from: 6.22.0.1.1	</para>
    ///   <para>skos:definition : The set of pitch relationships that establishes the tonal centre, or principal tonal centre, for a musical work. Key is designated by its pitch name and its mode, when it is major or minor.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : key</para>
    ///   <para>rdfs:label : Key</para>
    ///   <a href="http://rdvocab.info/Elements/key">rdag1:key</a>
    /// </summary>
    let key = _prefixId.prefix "key"
    /// <summary>
    ///   <para>skos:definition : The unique name assigned to a resource by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : keyTitle</para>
    ///   <para>rdfs:label : Key title</para>
    ///   <a href="http://rdvocab.info/Elements/keyTitle">rdag1:keyTitle</a>
    /// </summary>
    let keyTitle = _prefixId.prefix "keyTitle"
    /// <summary>
    ///   <para>skos:definition : The unique name assigned to a resource by an ISSN registration agency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : keyTitleManifestation</para>
    ///   <para>rdfs:label : Key title (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/keyTitleManifestation">rdag1:keyTitleManifestation</a>
    /// </summary>
    let keyTitleManifestation = _prefixId.prefix "keyTitleManifestation"
    /// <summary>
    ///   <para>skos:definition : The set of pitch relationships that establishes the tonal centre, or principal tonal centre, for a musical work. Key is designated by its pitch name and its mode, when it is major or minor.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : keyWork</para>
    ///   <para>rdfs:label : Key (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/keyWork">rdag1:keyWork</a>
    /// </summary>
    let keyWork = _prefixId.prefix "keyWork"
    /// <summary>
    ///   <para>skos:definition : A language in which a work is expressed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfExpression</para>
    ///   <para>rdfs:label : Language of expression</para>
    ///   <a href="http://rdvocab.info/Elements/languageOfExpression">rdag1:languageOfExpression</a>
    /// </summary>
    let languageOfExpression = _prefixId.prefix "languageOfExpression"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.10.0.1.1</para>
    ///   <para>skos:definition : A language used to express the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheContent</para>
    ///   <para>rdfs:label : Language of the content</para>
    ///   <a href="http://rdvocab.info/Elements/languageOfTheContent">rdag1:languageOfTheContent</a>
    /// </summary>
    let languageOfTheContent = _prefixId.prefix "languageOfTheContent"

    /// <summary>
    ///   <para>skos:definition : A language used to express the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : languageOfTheContentExpression</para>
    ///   <para>rdfs:label : Language of the content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/languageOfTheContentExpression">rdag1:languageOfTheContentExpression</a>
    /// </summary>
    let languageOfTheContentExpression = _prefixId.prefix "languageOfTheContentExpression"

    /// <summary>
    ///   <para>skos:definition : A title proper appearing on a later issue or part of a multipart monograph or serial that differs from that on the first or earliest issue or part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : laterTitleProper</para>
    ///   <para>rdfs:label : Later title proper</para>
    ///   <a href="http://rdvocab.info/Elements/laterTitleProper">rdag1:laterTitleProper</a>
    /// </summary>
    let laterTitleProper = _prefixId.prefix "laterTitleProper"
    /// <summary>
    ///   <para>skos:definition : A title proper appearing on a later issue or part of a multipart monograph or serial that differs from that on the first or earliest issue or part.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : laterTitleProperManifestation</para>
    ///   <para>rdfs:label : Later title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/laterTitleProperManifestation">rdag1:laterTitleProperManifestation</a>
    /// </summary>
    let laterTitleProperManifestation = _prefixId.prefix "laterTitleProperManifestation"
    /// <summary>
    ///   <para>rdfs:comment : Associated with the FRBR Manifestation entity.</para>
    ///   <para>rdfs:label : Layout</para>
    ///   <para>skos:definition : The arrangement of text, images, etc., in a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layout</para>
    ///   <para>skos:scopeNote : Definition source: RDA 3.11.0.1.1</para>
    ///   <a href="http://rdvocab.info/Elements/layout">rdag1:layout</a>
    /// </summary>
    let layout = _prefixId.prefix "layout"
    /// <summary>
    ///   <para>skos:definition : The arrangement of text, images, etc., in a resource.</para>
    ///   <para>rdfs:label : Layout (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/layoutManifestation">rdag1:layoutManifestation</a>
    /// </summary>
    let layoutManifestation = _prefixId.prefix "layoutManifestation"
    /// <summary>
    ///   <para>skos:definition : The arrangement of a cartographic image or images in a resource consisting of one or more sheets.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfCartographicImages</para>
    ///   <para>rdfs:label : Layout of cartographic images</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfCartographicImages">rdag1:layoutOfCartographicImages</a>
    /// </summary>
    let layoutOfCartographicImages = _prefixId.prefix "layoutOfCartographicImages"

    /// <summary>
    ///   <para>skos:definition : The arrangement of a cartographic image or images in a resource consisting of one or more sheets.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfCartographicImagesManifestation</para>
    ///   <para>rdfs:label : Layout of cartographic images (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfCartographicImagesManifestation">rdag1:layoutOfCartographicImagesManifestation</a>
    /// </summary>
    let layoutOfCartographicImagesManifestation = _prefixId.prefix "layoutOfCartographicImagesManifestation"

    /// <summary>
    ///   <para>skos:definition : The arrangement of tactile musical notation in a resource (e.g., bar by bar, line by line).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfTactileMusicalNotation</para>
    ///   <para>rdfs:label : Layout of tactile musical notation</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfTactileMusicalNotation">rdag1:layoutOfTactileMusicalNotation</a>
    /// </summary>
    let layoutOfTactileMusicalNotation = _prefixId.prefix "layoutOfTactileMusicalNotation"

    /// <summary>
    ///   <para>skos:definition : The arrangement of tactile musical notation in a resource (e.g., bar by bar, line by line).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfTactileMusicalNotationManifestation</para>
    ///   <para>rdfs:label : Layout of tactile musical notation (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfTactileMusicalNotationManifestation">rdag1:layoutOfTactileMusicalNotationManifestation</a>
    /// </summary>
    let layoutOfTactileMusicalNotationManifestation = _prefixId.prefix "layoutOfTactileMusicalNotationManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfTactileText</para>
    ///   <para>rdfs:label : Layout of tactile text</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfTactileText">rdag1:layoutOfTactileText</a>
    /// </summary>
    let layoutOfTactileText = _prefixId.prefix "layoutOfTactileText"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : layoutOfTactileTextManifestation</para>
    ///   <para>rdfs:label : Layout of tactile text (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/layoutOfTactileTextManifestation">rdag1:layoutOfTactileTextManifestation</a>
    /// </summary>
    let layoutOfTactileTextManifestation = _prefixId.prefix "layoutOfTactileTextManifestation"

    /// <summary>
    ///   <para>skos:definition : A system for identifying the area covered by the cartographic content of a resource using longitude of the westernmost and easternmost boundaries and latitude of the northernmost and southernmost boundaries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : longitudeAndLatitude</para>
    ///   <para>rdfs:label : Longitude and latitude</para>
    ///   <a href="http://rdvocab.info/Elements/longitudeAndLatitude">rdag1:longitudeAndLatitude</a>
    /// </summary>
    let longitudeAndLatitude = _prefixId.prefix "longitudeAndLatitude"
    /// <summary>
    ///   <para>skos:definition : A system for identifying the area covered by the cartographic content of a resource using longitude of the westernmost and easternmost boundaries and latitude of the northernmost and southernmost boundaries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : longitudeAndLatitudeWork</para>
    ///   <para>rdfs:label : Longitude and latitude (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/longitudeAndLatitudeWork">rdag1:longitudeAndLatitudeWork</a>
    /// </summary>
    let longitudeAndLatitudeWork = _prefixId.prefix "longitudeAndLatitudeWork"
    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of manufacture, manufacturer or manufacturers, and date or dates of manufacture of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufactureStatement</para>
    ///   <para>rdfs:label : Manufacture statement</para>
    ///   <a href="http://rdvocab.info/Elements/manufactureStatement">rdag1:manufactureStatement</a>
    /// </summary>
    let manufactureStatement = _prefixId.prefix "manufactureStatement"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of manufacture, manufacturer or manufacturers, and date or dates of manufacture of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufactureStatementManifestation</para>
    ///   <para>rdfs:label : Manufacture statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/manufactureStatementManifestation">rdag1:manufactureStatementManifestation</a>
    /// </summary>
    let manufactureStatementManifestation = _prefixId.prefix "manufactureStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturersName</para>
    ///   <para>rdfs:label : Manufacturer's name</para>
    ///   <a href="http://rdvocab.info/Elements/manufacturersName">rdag1:manufacturersName</a>
    /// </summary>
    let manufacturersName = _prefixId.prefix "manufacturersName"

    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for printing, duplicating, casting, etc., a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manufacturersNameManifestation</para>
    ///   <para>rdfs:label : Manufacturer's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/manufacturersNameManifestation">rdag1:manufacturersNameManifestation</a>
    /// </summary>
    let manufacturersNameManifestation = _prefixId.prefix "manufacturersNameManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.2.0.1.1</para>
    ///   <para>skos:definition : A categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediaType</para>
    ///   <para>rdfs:label : Media type</para>
    ///   <a href="http://rdvocab.info/Elements/mediaType">rdag1:mediaType</a>
    /// </summary>
    let mediaType = _prefixId.prefix "mediaType"
    /// <summary>
    ///   <para>skos:definition : A categorization reflecting the general type of intermediation device required to view, play, run, etc., the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediaTypeManifestation</para>
    ///   <para>rdfs:label : Media type (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/mediaTypeManifestation">rdag1:mediaTypeManifestation</a>
    /// </summary>
    let mediaTypeManifestation = _prefixId.prefix "mediaTypeManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: 6.20.0.1.1	</para>
    ///   <para>skos:definition : The instrument, instruments, voice, voices, etc., used (or intended to be used) for performance of musical content.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformanceOfMusicalContent</para>
    ///   <para>rdfs:label : Medium of performance of musical content</para>
    ///   <a href="http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContent">rdag1:mediumOfPerformanceOfMusicalContent</a>
    /// </summary>
    let mediumOfPerformanceOfMusicalContent = _prefixId.prefix "mediumOfPerformanceOfMusicalContent"

    /// <summary>
    ///   <para>skos:definition : The instrument, instruments, voice, voices, etc., used (or intended to be used) for performance of musical content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformanceOfMusicalContentExpression</para>
    ///   <para>rdfs:label : Medium of performance of musical content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/mediumOfPerformanceOfMusicalContentExpression">rdag1:mediumOfPerformanceOfMusicalContentExpression</a>
    /// </summary>
    let mediumOfPerformanceOfMusicalContentExpression = _prefixId.prefix "mediumOfPerformanceOfMusicalContentExpression"

    /// <summary>
    ///   <para>skos:definition : The instrumental, instruments, voice, voices, etc., for which a musical work was originally conceived.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mediumOfPerformanceWork</para>
    ///   <para>rdfs:label : Medium of performance (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/mediumOfPerformanceWork">rdag1:mediumOfPerformanceWork</a>
    /// </summary>
    let mediumOfPerformanceWork = _prefixId.prefix "mediumOfPerformanceWork"
    /// <summary>
    ///   <para>skos:definition : A categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modeOfIssuance</para>
    ///   <para>rdfs:label : Mode of issuance</para>
    ///   <a href="http://rdvocab.info/Elements/modeOfIssuance">rdag1:modeOfIssuance</a>
    /// </summary>
    let modeOfIssuance = _prefixId.prefix "modeOfIssuance"
    /// <summary>
    ///   <para>skos:definition : A categorization reflecting whether a resource is issued in one or more parts, the way it is updated, and its intended termination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : modeOfIssuanceManifestation</para>
    ///   <para>rdfs:label : Mode of issuance (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/modeOfIssuanceManifestation">rdag1:modeOfIssuanceManifestation</a>
    /// </summary>
    let modeOfIssuanceManifestation = _prefixId.prefix "modeOfIssuanceManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.8.0.1.1</para>
    ///   <para>skos:definition : The physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mount</para>
    ///   <para>rdfs:label : Mount</para>
    ///   <para>rdfs:comment : Associated with the FRBR Manifestation entity.</para>
    ///   <a href="http://rdvocab.info/Elements/mount">rdag1:mount</a>
    /// </summary>
    let mount = _prefixId.prefix "mount"
    /// <summary>
    ///   <para>skos:definition : The physical material used for the support or backing to which the base material of a resource has been attached.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mountManifestation</para>
    ///   <para>rdfs:label : Mount (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/mountManifestation">rdag1:mountManifestation</a>
    /// </summary>
    let mountManifestation = _prefixId.prefix "mountManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.3.0.1.1 </para>
    ///   <para>skos:definition : The specific character of the content of a resource (e.g., legal articles, interim report).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : natureOfTheContent</para>
    ///   <para>rdfs:label : Nature of the content</para>
    ///   <a href="http://rdvocab.info/Elements/natureOfTheContent">rdag1:natureOfTheContent</a>
    /// </summary>
    let natureOfTheContent = _prefixId.prefix "natureOfTheContent"
    /// <summary>
    ///   <para>skos:definition : The specific character of the content of a resource (e.g., legal articles, interim report).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : natureOfTheContentWork</para>
    ///   <para>rdfs:label : Nature of the content (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/natureOfTheContentWork">rdag1:natureOfTheContentWork</a>
    /// </summary>
    let natureOfTheContentWork = _prefixId.prefix "natureOfTheContentWork"
    /// <summary>
    ///   <para>rdfs:label : Note</para>
    ///   <para>skos:definition : An annotation providing additional information relating to data recorded in another element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : note</para>
    ///   <a href="http://rdvocab.info/Elements/note">rdag1:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>skos:definition : An annotation providing additional information relating to content recorded as an expression attribute.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteExpression</para>
    ///   <para>rdfs:label : Note on expression (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/noteExpression">rdag1:noteExpression</a>
    /// </summary>
    let noteExpression = _prefixId.prefix "noteExpression"
    /// <summary>
    ///   <para>skos:definition : An annotation providing additional information relating to manifestation or item attributes.</para>
    ///   <para>rdfs:label : Note on manifestation or item (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteItem</para>
    ///   <a href="http://rdvocab.info/Elements/noteItem">rdag1:noteItem</a>
    /// </summary>
    let noteItem = _prefixId.prefix "noteItem"
    /// <summary>
    ///   <para>rdfs:label : Note on manifestation or item (Manifestation)</para>
    ///   <para>skos:definition : An annotation providing additional information relating to manifestation or item attributes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/noteManifestation">rdag1:noteManifestation</a>
    /// </summary>
    let noteManifestation = _prefixId.prefix "noteManifestation"

    /// <summary>
    ///   <para>skos:definition : A note on changes in carrier characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInCarrierCharacteristics</para>
    ///   <para>rdfs:label : Note on changes in carrier characteristics</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristics">rdag1:noteOnChangesInCarrierCharacteristics</a>
    /// </summary>
    let noteOnChangesInCarrierCharacteristics = _prefixId.prefix "noteOnChangesInCarrierCharacteristics"

    /// <summary>
    ///   <para>skos:definition : A note on changes in carrier characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnChangesInCarrierCharacteristicsManifestation</para>
    ///   <para>rdfs:label : Note on changes in carrier characteristics (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnChangesInCarrierCharacteristicsManifestation">rdag1:noteOnChangesInCarrierCharacteristicsManifestation</a>
    /// </summary>
    let noteOnChangesInCarrierCharacteristicsManifestation = _prefixId.prefix "noteOnChangesInCarrierCharacteristicsManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing additional information about copyright dates applying to various aspects of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnCopyrightDate</para>
    ///   <para>rdfs:label : Note on copyright date</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnCopyrightDate">rdag1:noteOnCopyrightDate</a>
    /// </summary>
    let noteOnCopyrightDate = _prefixId.prefix "noteOnCopyrightDate"

    /// <summary>
    ///   <para>skos:definition : A note providing additional information about copyright dates applying to various aspects of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnCopyrightDateManifestation</para>
    ///   <para>rdfs:label : Note on copyright date (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnCopyrightDateManifestation">rdag1:noteOnCopyrightDateManifestation</a>
    /// </summary>
    let noteOnCopyrightDateManifestation = _prefixId.prefix "noteOnCopyrightDateManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information about the dimensions of the specific item being described that is not recorded formally as part of the dimensions element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDimensionsOfItem</para>
    ///   <para>rdfs:label : Note on dimensions of item</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnDimensionsOfItem">rdag1:noteOnDimensionsOfItem</a>
    /// </summary>
    let noteOnDimensionsOfItem = _prefixId.prefix "noteOnDimensionsOfItem"

    /// <summary>
    ///   <para>skos:definition : A note providing information about the dimensions of a manifestation not recorded formally as part of the dimensions element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDimensionsOfManifestation</para>
    ///   <para>rdfs:label : Note on dimensions of manifestation</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnDimensionsOfManifestation">rdag1:noteOnDimensionsOfManifestation</a>
    /// </summary>
    let noteOnDimensionsOfManifestation = _prefixId.prefix "noteOnDimensionsOfManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of distribution, distributor, or date of distribution, or information on changes in the place of distribution, distributor, or distributor’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDistributionStatement</para>
    ///   <para>rdfs:label : Note on distribution statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnDistributionStatement">rdag1:noteOnDistributionStatement</a>
    /// </summary>
    let noteOnDistributionStatement = _prefixId.prefix "noteOnDistributionStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of distribution, distributor, or date of distribution, or information on changes in the place of distribution, distributor, or distributor’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDistributionStatementManifestation</para>
    ///   <para>rdfs:label : Note on distribution statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnDistributionStatementManifestation">rdag1:noteOnDistributionStatementManifestation</a>
    /// </summary>
    let noteOnDistributionStatementManifestation = _prefixId.prefix "noteOnDistributionStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the source of an edition statement, on edition statements relating to issues, parts, etc., on changes in edition statements, or other information relating to an edition statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnEditionStatement</para>
    ///   <para>rdfs:label : Note on edition statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnEditionStatement">rdag1:noteOnEditionStatement</a>
    /// </summary>
    let noteOnEditionStatement = _prefixId.prefix "noteOnEditionStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the source of an edition statement, on edition statements relating to issues, parts, etc., on changes in edition statements, or other information relating to an edition statement.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnEditionStatementManifestation</para>
    ///   <para>rdfs:label : Note on edition statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnEditionStatementManifestation">rdag1:noteOnEditionStatementManifestation</a>
    /// </summary>
    let noteOnEditionStatementManifestation = _prefixId.prefix "noteOnEditionStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the extent of the specific item being described that is not recorded formally as part of the extent element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExtentOfItem</para>
    ///   <para>rdfs:label : Note on extent of item </para>
    ///   <a href="http://rdvocab.info/Elements/noteOnExtentOfItem">rdag1:noteOnExtentOfItem</a>
    /// </summary>
    let noteOnExtentOfItem = _prefixId.prefix "noteOnExtentOfItem"
    /// <summary>
    ///   <para>skos:definition : A note providing information on the extent of a manifestation that is not recorded formally as part of the extent element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExtentOfManifestation</para>
    ///   <para>rdfs:label : Note on extent of manifestation</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnExtentOfManifestation">rdag1:noteOnExtentOfManifestation</a>
    /// </summary>
    let noteOnExtentOfManifestation = _prefixId.prefix "noteOnExtentOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A note providing details on the currency of the contents, on the frequency of release of issues or parts of a serial or the frequency of updates to an integrating resource, or on changes in frequency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnFrequency</para>
    ///   <para>rdfs:label : Note on frequency</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnFrequency">rdag1:noteOnFrequency</a>
    /// </summary>
    let noteOnFrequency = _prefixId.prefix "noteOnFrequency"
    /// <summary>
    ///   <para>skos:definition : A note providing details on the currency of the contents, on the frequency of release of issues or parts of a serial or the frequency of updates to an integrating resource, or on changes in frequency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnFrequencyManifestation</para>
    ///   <para>rdfs:label : Note on frequency (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnFrequencyManifestation">rdag1:noteOnFrequencyManifestation</a>
    /// </summary>
    let noteOnFrequencyManifestation = _prefixId.prefix "noteOnFrequencyManifestation"

    /// <summary>
    ///   <para>skos:definition : A note identifying the issue or part of a multipart monograph or serial, or the iteration of an integrating resource that has been used as the basis for the identification of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</para>
    ///   <para>rdfs:label : Note on issue, part, or iteration used as the basis for identification of the resource</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource">rdag1:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource</a>
    /// </summary>
    let noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource = _prefixId.prefix "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResource"

    /// <summary>
    ///   <para>skos:definition : A note identifying the issue or part of a multipart monograph or serial, or the iteration of an integrating resource that has been used as the basis for the identification of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation</para>
    ///   <para>rdfs:label : Note on issue, part, or iteration used as the basis for identification of the resource (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation">rdag1:noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation</a>
    /// </summary>
    let noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation =
        _prefixId.prefix "noteOnIssuePartOrIterationUsedAsTheBasisForIdentificationOfTheResourceManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of manufacture, manufacturer, or date of manufacture, or information on changes in the place of manufacture, manufacturer, or manufacturer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnManufactureStatement</para>
    ///   <para>rdfs:label : Note on manufacture statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnManufactureStatement">rdag1:noteOnManufactureStatement</a>
    /// </summary>
    let noteOnManufactureStatement = _prefixId.prefix "noteOnManufactureStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of manufacture, manufacturer, or date of manufacture, or information on changes in the place of manufacture, manufacturer, or manufacturer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnManufactureStatementManifestation</para>
    ///   <para>rdfs:label : Note on manufacture statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnManufactureStatementManifestation">rdag1:noteOnManufactureStatementManifestation</a>
    /// </summary>
    let noteOnManufactureStatementManifestation = _prefixId.prefix "noteOnManufactureStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the numbering of the first and/or last issue or part, on complex or irregular numbering (including numbering errors), or on the period covered by a volume, issue, part, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnNumberingOfSerials</para>
    ///   <para>rdfs:label : Note on numbering of serials</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnNumberingOfSerials">rdag1:noteOnNumberingOfSerials</a>
    /// </summary>
    let noteOnNumberingOfSerials = _prefixId.prefix "noteOnNumberingOfSerials"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the numbering of the first and/or last issue or part, on complex or irregular numbering (including numbering errors), or on the period covered by a volume, issue, part, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnNumberingOfSerialsManifestation</para>
    ///   <para>rdfs:label : Note on numbering of serials (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnNumberingOfSerialsManifestation">rdag1:noteOnNumberingOfSerialsManifestation</a>
    /// </summary>
    let noteOnNumberingOfSerialsManifestation = _prefixId.prefix "noteOnNumberingOfSerialsManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of production, producer, or date of production, or information on changes in the place of production,
    /// producer, or producer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnProductionStatement</para>
    ///   <para>rdfs:label : Note on production statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnProductionStatement">rdag1:noteOnProductionStatement</a>
    /// </summary>
    let noteOnProductionStatement = _prefixId.prefix "noteOnProductionStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of production, producer, or date of production, or information on changes in the place of production,
    /// producer, or producer’s name.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnProductionStatementManifestation</para>
    ///   <para>rdfs:label : Note on production statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnProductionStatementManifestation">rdag1:noteOnProductionStatementManifestation</a>
    /// </summary>
    let noteOnProductionStatementManifestation = _prefixId.prefix "noteOnProductionStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of publication, publisher, or date of publication, information on changes in the place of publication,
    /// publisher, or publisher’s name, or on suspension of publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnPublicationStatement</para>
    ///   <para>rdfs:label : Note on publication statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnPublicationStatement">rdag1:noteOnPublicationStatement</a>
    /// </summary>
    let noteOnPublicationStatement = _prefixId.prefix "noteOnPublicationStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing details on place of publication, publisher, or date of publication, information on changes in the place of publication,
    /// publisher, or publisher’s name, or on suspension of publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnPublicationStatementManifestation</para>
    ///   <para>rdfs:label : Note on publication statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnPublicationStatementManifestation">rdag1:noteOnPublicationStatementManifestation</a>
    /// </summary>
    let noteOnPublicationStatementManifestation = _prefixId.prefix "noteOnPublicationStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on complex series statements, incorrect numbering within series, or changes in series statements.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnSeriesStatement</para>
    ///   <para>rdfs:label : Note on series statement</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnSeriesStatement">rdag1:noteOnSeriesStatement</a>
    /// </summary>
    let noteOnSeriesStatement = _prefixId.prefix "noteOnSeriesStatement"

    /// <summary>
    ///   <para>skos:definition : A note providing information on complex series statements, incorrect numbering within series, or changes in series statements.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnSeriesStatementManifestation</para>
    ///   <para>rdfs:label : Note on series statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnSeriesStatementManifestation">rdag1:noteOnSeriesStatementManifestation</a>
    /// </summary>
    let noteOnSeriesStatementManifestation = _prefixId.prefix "noteOnSeriesStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on a person, family, or corporate body not named in a statement of responsibility to whom responsibility for the intellectual or artistic content of the resource has been attributed, on variant forms of names appearing in the resource, on changes in statements of responsibility, or other information relating to a statement of responsibility.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnStatementOfResponsibility</para>
    ///   <para>rdfs:label : Note on statement of responsibility</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnStatementOfResponsibility">rdag1:noteOnStatementOfResponsibility</a>
    /// </summary>
    let noteOnStatementOfResponsibility = _prefixId.prefix "noteOnStatementOfResponsibility"

    /// <summary>
    ///   <para>skos:definition : A note providing information on a person, family, or corporate body not named in a statement of responsibility to whom responsibility for the intellectual or artistic content of the resource has been attributed, on variant forms of names appearing in the resource, on changes in statements of responsibility, or other information relating to a statement of responsibility.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnStatementOfResponsibilityManifestation</para>
    ///   <para>rdfs:label : Note on statement of responsibility (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnStatementOfResponsibilityManifestation">rdag1:noteOnStatementOfResponsibilityManifestation</a>
    /// </summary>
    let noteOnStatementOfResponsibilityManifestation = _prefixId.prefix "noteOnStatementOfResponsibilityManifestation"

    /// <summary>
    ///   <para>skos:definition : A note providing information on the source from which a title was taken, the date the title was viewed, variations in titles, inaccuracies, deletions, etc., or other information relating to a title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnTitle</para>
    ///   <para>rdfs:label : Note on title</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnTitle">rdag1:noteOnTitle</a>
    /// </summary>
    let noteOnTitle = _prefixId.prefix "noteOnTitle"
    /// <summary>
    ///   <para>skos:definition : A note providing information on the source from which a title was taken, the date the title was viewed, variations in titles, inaccuracies, deletions, etc., or other information relating to a title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnTitleManifestation</para>
    ///   <para>rdfs:label : Note on title (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/noteOnTitleManifestation">rdag1:noteOnTitleManifestation</a>
    /// </summary>
    let noteOnTitleManifestation = _prefixId.prefix "noteOnTitleManifestation"

    /// <summary>
    ///   <para>skos:definition : A note on changes in content characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteonChangesinContentCharacteristics</para>
    ///   <para>rdfs:label : Note on changes in content characteristics</para>
    ///   <a href="http://rdvocab.info/Elements/noteonChangesinContentCharacteristics">rdag1:noteonChangesinContentCharacteristics</a>
    /// </summary>
    let noteonChangesinContentCharacteristics = _prefixId.prefix "noteonChangesinContentCharacteristics"

    /// <summary>
    ///   <para>skos:definition : A note on changes in content characteristics that occur in subsequent issues or parts of a resource issued in successive parts or between iterations of an integrating resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteonChangesinContentCharacteristicsExpression</para>
    ///   <para>rdfs:label : Note on changes in content characteristics (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/noteonChangesinContentCharacteristicsExpression">rdag1:noteonChangesinContentCharacteristicsExpression</a>
    /// </summary>
    let noteonChangesinContentCharacteristicsExpression = _prefixId.prefix "noteonChangesinContentCharacteristicsExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition from: 2.6.0.1.1	</para>
    ///   <para>rdfs:label : Numbering of serials</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfSerials</para>
    ///   <para>skos:definition : The identification of each of the issues or parts of a serial. Numbering of serials may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.
    /// </para>
    ///   <a href="http://rdvocab.info/Elements/numberingOfSerials">rdag1:numberingOfSerials</a>
    /// </summary>
    let numberingOfSerials = _prefixId.prefix "numberingOfSerials"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfSerialsManifestation</para>
    ///   <para>rdfs:label : Numbering of serials (Manifestation)</para>
    ///   <para>skos:definition : The identification of each of the issues or parts of a serial. Numbering of serials may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <a href="http://rdvocab.info/Elements/numberingOfSerialsManifestation">rdag1:numberingOfSerialsManifestation</a>
    /// </summary>
    let numberingOfSerialsManifestation = _prefixId.prefix "numberingOfSerialsManifestation"

    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a part or parts within a series. Numbering within series may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSeries</para>
    ///   <para>rdfs:label : Numbering within series</para>
    ///   <a href="http://rdvocab.info/Elements/numberingWithinSeries">rdag1:numberingWithinSeries</a>
    /// </summary>
    let numberingWithinSeries = _prefixId.prefix "numberingWithinSeries"

    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a part or parts within a series. Numbering within series may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSeriesManifestation</para>
    ///   <para>rdfs:label : Numbering within series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/numberingWithinSeriesManifestation">rdag1:numberingWithinSeriesManifestation</a>
    /// </summary>
    let numberingWithinSeriesManifestation = _prefixId.prefix "numberingWithinSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a part or parts within a subseries. Numbering within series may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSubseries</para>
    ///   <para>rdfs:label : Numbering within subseries</para>
    ///   <a href="http://rdvocab.info/Elements/numberingWithinSubseries">rdag1:numberingWithinSubseries</a>
    /// </summary>
    let numberingWithinSubseries = _prefixId.prefix "numberingWithinSubseries"

    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a part or parts within a subseries. Numbering within series may include a numeral, a letter, any other character, or the combination of these with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingWithinSubseriesManifestation</para>
    ///   <para>rdfs:label : Numbering within subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/numberingWithinSubseriesManifestation">rdag1:numberingWithinSubseriesManifestation</a>
    /// </summary>
    let numberingWithinSubseriesManifestation = _prefixId.prefix "numberingWithinSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Numeric and/or alphabetic designation of first issue or part of sequence</para>
    ///   <a href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence">rdag1:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence</a>
    /// </summary>
    let numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence = _prefixId.prefix "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in numeric and/or alphabetic form on the first issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Numeric and/or alphabetic designation of first issue or part of sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation">rdag1:numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "numericAndOrAlphabeticDesignationOfFirstIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</para>
    ///   <para>rdfs:label : Numeric and/or alphabetic designation of last issue or part of sequence</para>
    ///   <a href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence">rdag1:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence</a>
    /// </summary>
    let numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence = _prefixId.prefix "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequence"

    /// <summary>
    ///   <para>skos:definition : Numbering presented in numeric and/or alphabetic form on the last issue or part of a sequence of numbering for a serial.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</para>
    ///   <para>rdfs:label : Numeric and/or alphabetic designation of last issue or part of sequence (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation">rdag1:numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation</a>
    /// </summary>
    let numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation =
        _prefixId.prefix "numericAndOrAlphabeticDesignationOfLastIssueOrPartOfSequenceManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition from: 6.21.0.1.1	</para>
    ///   <para>skos:definition : A serial number, opus number, or thematic index number assigned to a musical work by a composer, publisher, or a musicologist.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numericDesignationOfAMusicalWork</para>
    ///   <para>rdfs:label : Numeric designation of a musical work </para>
    ///   <a href="http://rdvocab.info/Elements/numericDesignationOfAMusicalWork">rdag1:numericDesignationOfAMusicalWork</a>
    /// </summary>
    let numericDesignationOfAMusicalWork = _prefixId.prefix "numericDesignationOfAMusicalWork"

    /// <summary>
    ///   <para>skos:definition : Mathematical data and other features of the cartographic content of a resource not recorded in statements of scale, projection, and coordinates.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDetailsOfCartographicContent</para>
    ///   <para>rdfs:label : Other details of cartographic content</para>
    ///   <a href="http://rdvocab.info/Elements/otherDetailsOfCartographicContent">rdag1:otherDetailsOfCartographicContent</a>
    /// </summary>
    let otherDetailsOfCartographicContent = _prefixId.prefix "otherDetailsOfCartographicContent"

    /// <summary>
    ///   <para>skos:definition : Mathematical data and other features of the cartographic content of a resource not recorded in statements of scale, projection, and coordinates.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDetailsOfCartographicContentExpression</para>
    ///   <para>rdfs:label : Other details of cartographic content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/otherDetailsOfCartographicContentExpression">rdag1:otherDetailsOfCartographicContentExpression</a>
    /// </summary>
    let otherDetailsOfCartographicContentExpression = _prefixId.prefix "otherDetailsOfCartographicContentExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.14.0.1.1 </para>
    ///   <para>skos:definition : A characteristic other than content type, language of expression, or date of expression that serves to differentiate an expression from another expression of the same work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDistinguishingCharacteristicOfTheExpression</para>
    ///   <para>rdfs:label : Other distinguishing characteristic of the expression</para>
    ///   <a href="http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheExpression">rdag1:otherDistinguishingCharacteristicOfTheExpression</a>
    /// </summary>
    let otherDistinguishingCharacteristicOfTheExpression = _prefixId.prefix "otherDistinguishingCharacteristicOfTheExpression"

    /// <summary>
    ///   <para>skos:definition : A characteristic other than form of work, date of work, or place of origin of the work that serves to differentiate a work from another work with the same title or from the name of a person, family, or corporate body.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherDistinguishingCharacteristicOfTheWork</para>
    ///   <para>rdfs:label : Other distinguishing characteristic of the work</para>
    ///   <a href="http://rdvocab.info/Elements/otherDistinguishingCharacteristicOfTheWork">rdag1:otherDistinguishingCharacteristicOfTheWork</a>
    /// </summary>
    let otherDistinguishingCharacteristicOfTheWork = _prefixId.prefix "otherDistinguishingCharacteristicOfTheWork"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformation</para>
    ///   <para>rdfs:label : Other title information</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformation">rdag1:otherTitleInformation</a>
    /// </summary>
    let otherTitleInformation = _prefixId.prefix "otherTitleInformation"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationManifestation</para>
    ///   <para>rdfs:label : Other title information (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformationManifestation">rdag1:otherTitleInformationManifestation</a>
    /// </summary>
    let otherTitleInformationManifestation = _prefixId.prefix "otherTitleInformationManifestation"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSeries</para>
    ///   <para>rdfs:label : Other title information of series</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformationOfSeries">rdag1:otherTitleInformationOfSeries</a>
    /// </summary>
    let otherTitleInformationOfSeries = _prefixId.prefix "otherTitleInformationOfSeries"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSeriesManifestation</para>
    ///   <para>rdfs:label : Other title information of series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformationOfSeriesManifestation">rdag1:otherTitleInformationOfSeriesManifestation</a>
    /// </summary>
    let otherTitleInformationOfSeriesManifestation = _prefixId.prefix "otherTitleInformationOfSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSubseries</para>
    ///   <para>rdfs:label : Other title information of subseries</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformationOfSubseries">rdag1:otherTitleInformationOfSubseries</a>
    /// </summary>
    let otherTitleInformationOfSubseries = _prefixId.prefix "otherTitleInformationOfSubseries"

    /// <summary>
    ///   <para>skos:definition : Information that appears in conjunction with, and is subordinate to, the title proper of a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherTitleInformationOfSubseriesManifestation</para>
    ///   <para>rdfs:label : Other title information of subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/otherTitleInformationOfSubseriesManifestation">rdag1:otherTitleInformationOfSubseriesManifestation</a>
    /// </summary>
    let otherTitleInformationOfSubseriesManifestation = _prefixId.prefix "otherTitleInformationOfSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A designation of a named revision of an edition in a language and/or script that differs from that recorded in the designation of a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : Parallel designation of a named revision of an edition</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEdition">rdag1:parallelDesignationOfANamedRevisionOfAnEdition</a>
    /// </summary>
    let parallelDesignationOfANamedRevisionOfAnEdition = _prefixId.prefix "parallelDesignationOfANamedRevisionOfAnEdition"

    /// <summary>
    ///   <para>skos:definition : A designation of a named revision of an edition in a language and/or script that differs from that recorded in the designation of a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfANamedRevisionOfAnEditionManifestation</para>
    ///   <para>rdfs:label : Parallel designation of a named revision of an edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDesignationOfANamedRevisionOfAnEditionManifestation">rdag1:parallelDesignationOfANamedRevisionOfAnEditionManifestation</a>
    /// </summary>
    let parallelDesignationOfANamedRevisionOfAnEditionManifestation = _prefixId.prefix "parallelDesignationOfANamedRevisionOfAnEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A designation of edition in a language and/or script that differs from that recorded in the designation of edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfEdition</para>
    ///   <para>rdfs:label : Parallel designation of edition</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDesignationOfEdition">rdag1:parallelDesignationOfEdition</a>
    /// </summary>
    let parallelDesignationOfEdition = _prefixId.prefix "parallelDesignationOfEdition"

    /// <summary>
    ///   <para>skos:definition : A designation of edition in a language and/or script that differs from that recorded in the designation of edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDesignationOfEditionManifestation</para>
    ///   <para>rdfs:label : Parallel designation of edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDesignationOfEditionManifestation">rdag1:parallelDesignationOfEditionManifestation</a>
    /// </summary>
    let parallelDesignationOfEditionManifestation = _prefixId.prefix "parallelDesignationOfEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A distributor’s name in a language and/or script that differs from that recorded in the distributor’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDistributorsName</para>
    ///   <para>rdfs:label : Parallel distributor's name</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDistributorsName">rdag1:parallelDistributorsName</a>
    /// </summary>
    let parallelDistributorsName = _prefixId.prefix "parallelDistributorsName"

    /// <summary>
    ///   <para>skos:definition : A distributor’s name in a language and/or script that differs from that recorded in the distributor’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelDistributorsNameManifestation</para>
    ///   <para>rdfs:label : Parallel distributor's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelDistributorsNameManifestation">rdag1:parallelDistributorsNameManifestation</a>
    /// </summary>
    let parallelDistributorsNameManifestation = _prefixId.prefix "parallelDistributorsNameManifestation"

    /// <summary>
    ///   <para>skos:definition : A manufacturer’s name in a language and/or script that differs from that recorded in the manufacturer’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelManufacturersName</para>
    ///   <para>rdfs:label : Parallel manufacturer's name</para>
    ///   <a href="http://rdvocab.info/Elements/parallelManufacturersName">rdag1:parallelManufacturersName</a>
    /// </summary>
    let parallelManufacturersName = _prefixId.prefix "parallelManufacturersName"

    /// <summary>
    ///   <para>skos:definition : A manufacturer’s name in a language and/or script that differs from that recorded in the manufacturer’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelManufacturersNameManifestation</para>
    ///   <para>rdfs:label : Parallel manufacturer's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelManufacturersNameManifestation">rdag1:parallelManufacturersNameManifestation</a>
    /// </summary>
    let parallelManufacturersNameManifestation = _prefixId.prefix "parallelManufacturersNameManifestation"

    /// <summary>
    ///   <para>skos:definition : Other title information in a language and/or script different from that recorded in the other title information element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformation</para>
    ///   <para>rdfs:label : Parallel other title information</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformation">rdag1:parallelOtherTitleInformation</a>
    /// </summary>
    let parallelOtherTitleInformation = _prefixId.prefix "parallelOtherTitleInformation"

    /// <summary>
    ///   <para>skos:definition : Other title information in a language and/or script different from that recorded in the other title information element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationManifestation</para>
    ///   <para>rdfs:label : Parallel other title information (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformationManifestation">rdag1:parallelOtherTitleInformationManifestation</a>
    /// </summary>
    let parallelOtherTitleInformationManifestation = _prefixId.prefix "parallelOtherTitleInformationManifestation"

    /// <summary>
    ///   <para>skos:definition : Other title information of a series in a language and/or script that differs from that recorded in the other title information of series
    /// element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSeries</para>
    ///   <para>rdfs:label : Parallel other title information of series</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeries">rdag1:parallelOtherTitleInformationOfSeries</a>
    /// </summary>
    let parallelOtherTitleInformationOfSeries = _prefixId.prefix "parallelOtherTitleInformationOfSeries"

    /// <summary>
    ///   <para>skos:definition : Other title information of a series in a language and/or script that differs from that recorded in the other title information of series
    /// element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSeriesManifestation</para>
    ///   <para>rdfs:label : Parallel other title information of series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSeriesManifestation">rdag1:parallelOtherTitleInformationOfSeriesManifestation</a>
    /// </summary>
    let parallelOtherTitleInformationOfSeriesManifestation = _prefixId.prefix "parallelOtherTitleInformationOfSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : Other title information of a subseries in a language and/or script that differs from that recorded in the other title information of
    /// subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSubseries</para>
    ///   <para>rdfs:label : Parallel other title information of subseries</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseries">rdag1:parallelOtherTitleInformationOfSubseries</a>
    /// </summary>
    let parallelOtherTitleInformationOfSubseries = _prefixId.prefix "parallelOtherTitleInformationOfSubseries"

    /// <summary>
    ///   <para>skos:definition : Other title information of a subseries in a language and/or script that differs from that recorded in the other title information of
    /// subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelOtherTitleInformationOfSubseriesManifestation</para>
    ///   <para>rdfs:label : Parallel other title information of subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelOtherTitleInformationOfSubseriesManifestation">rdag1:parallelOtherTitleInformationOfSubseriesManifestation</a>
    /// </summary>
    let parallelOtherTitleInformationOfSubseriesManifestation = _prefixId.prefix "parallelOtherTitleInformationOfSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A place of distribution in a language and/or script that differs from that recorded in the place of distribution element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfDistribution</para>
    ///   <para>rdfs:label : Parallel place of distribution</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfDistribution">rdag1:parallelPlaceOfDistribution</a>
    /// </summary>
    let parallelPlaceOfDistribution = _prefixId.prefix "parallelPlaceOfDistribution"

    /// <summary>
    ///   <para>skos:definition : A place of distribution in a language and/or script that differs from that recorded in the place of distribution element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfDistributionManifestation</para>
    ///   <para>rdfs:label : Parallel place of distribution (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfDistributionManifestation">rdag1:parallelPlaceOfDistributionManifestation</a>
    /// </summary>
    let parallelPlaceOfDistributionManifestation = _prefixId.prefix "parallelPlaceOfDistributionManifestation"

    /// <summary>
    ///   <para>skos:definition : A place of manufacture in a language and/or script that differs from that recorded in the place of manufacture element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfManufacture</para>
    ///   <para>rdfs:label : Parallel place of manufacture</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfManufacture">rdag1:parallelPlaceOfManufacture</a>
    /// </summary>
    let parallelPlaceOfManufacture = _prefixId.prefix "parallelPlaceOfManufacture"

    /// <summary>
    ///   <para>skos:definition : A place of manufacture in a language and/or script that differs from that recorded in the place of manufacture element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfManufactureManifestation</para>
    ///   <para>rdfs:label : Parallel place of manufacture (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfManufactureManifestation">rdag1:parallelPlaceOfManufactureManifestation</a>
    /// </summary>
    let parallelPlaceOfManufactureManifestation = _prefixId.prefix "parallelPlaceOfManufactureManifestation"

    /// <summary>
    ///   <para>skos:definition : A place of production in a language and/or script that differs from that recorded in the place of production element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfProduction</para>
    ///   <para>rdfs:label : Parallel place of production</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfProduction">rdag1:parallelPlaceOfProduction</a>
    /// </summary>
    let parallelPlaceOfProduction = _prefixId.prefix "parallelPlaceOfProduction"

    /// <summary>
    ///   <para>skos:definition : A place of production in a language and/or script that differs from that recorded in the place of production element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfProductionManifestation</para>
    ///   <para>rdfs:label : Parallel place of production (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfProductionManifestation">rdag1:parallelPlaceOfProductionManifestation</a>
    /// </summary>
    let parallelPlaceOfProductionManifestation = _prefixId.prefix "parallelPlaceOfProductionManifestation"

    /// <summary>
    ///   <para>skos:definition : A place of publication in a language and/or script that differs from that recorded in the place of publication element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfPublication</para>
    ///   <para>rdfs:label : Parallel place of publication</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfPublication">rdag1:parallelPlaceOfPublication</a>
    /// </summary>
    let parallelPlaceOfPublication = _prefixId.prefix "parallelPlaceOfPublication"

    /// <summary>
    ///   <para>skos:definition : A place of publication in a language and/or script that differs from that recorded in the place of publication element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPlaceOfPublicationManifestation</para>
    ///   <para>rdfs:label : Parallel place of publication (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPlaceOfPublicationManifestation">rdag1:parallelPlaceOfPublicationManifestation</a>
    /// </summary>
    let parallelPlaceOfPublicationManifestation = _prefixId.prefix "parallelPlaceOfPublicationManifestation"

    /// <summary>
    ///   <para>skos:definition : A producer’s name in a language and/or script that differs from that recorded in the producer’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelProducersName</para>
    ///   <para>rdfs:label : Parallel producer's name</para>
    ///   <a href="http://rdvocab.info/Elements/parallelProducersName">rdag1:parallelProducersName</a>
    /// </summary>
    let parallelProducersName = _prefixId.prefix "parallelProducersName"

    /// <summary>
    ///   <para>skos:definition : A producer’s name in a language and/or script that differs from that recorded in the producer’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelProducersNameManifestation</para>
    ///   <para>rdfs:label : Parallel producer's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelProducersNameManifestation">rdag1:parallelProducersNameManifestation</a>
    /// </summary>
    let parallelProducersNameManifestation = _prefixId.prefix "parallelProducersNameManifestation"

    /// <summary>
    ///   <para>skos:definition : A publisher’s name in a language and/or script that differs from that recorded in the publisher’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPublishersName</para>
    ///   <para>rdfs:label : Parallel publisher's name</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPublishersName">rdag1:parallelPublishersName</a>
    /// </summary>
    let parallelPublishersName = _prefixId.prefix "parallelPublishersName"

    /// <summary>
    ///   <para>skos:definition : A publisher’s name in a language and/or script that differs from that recorded in the publisher’s name element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelPublishersNameManifestation</para>
    ///   <para>rdfs:label : Parallel publisher's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelPublishersNameManifestation">rdag1:parallelPublishersNameManifestation</a>
    /// </summary>
    let parallelPublishersNameManifestation = _prefixId.prefix "parallelPublishersNameManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to a named revision of an edition in a language and/or script that differs from that recorded in the statement of responsibility relating to a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to a named revision of an edition</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition">rdag1:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEdition"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to a named revision of an edition in a language and/or script that differs from that recorded in the statement of responsibility relating to a named revision of an edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to a named revision of an edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation">rdag1:parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation =
        _prefixId.prefix "parallelStatementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to series in a language and/or script that differs from that recorded in the statement of responsibility relating to series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSeries</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to series</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeries">rdag1:parallelStatementOfResponsibilityRelatingToSeries</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToSeries = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSeries"

    /// <summary>
    ///   <para>skos:definition : A statement relating to series in a language and/or script that differs from that recorded in the statement of responsibility relating to series element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSeriesManifestation</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSeriesManifestation">rdag1:parallelStatementOfResponsibilityRelatingToSeriesManifestation</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToSeriesManifestation = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to subseries in a language and/or script that differs from that recorded in the statement of responsibility relating to subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSubseries</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to subseries</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseries">rdag1:parallelStatementOfResponsibilityRelatingToSubseries</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToSubseries = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSubseries"

    /// <summary>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to subseries (Manifestation)</para>
    ///   <para>skos:definition : A statement relating to subseries in a language and/or script that differs from that recorded in the statement of responsibility relating to subseries element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToSubseriesManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToSubseriesManifestation">rdag1:parallelStatementOfResponsibilityRelatingToSubseriesManifestation</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToSubseriesManifestation = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to the edition in a language and/or script that differs from that recorded in the statement of responsibility relating to the edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTheEdition</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to the edition</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEdition">rdag1:parallelStatementOfResponsibilityRelatingToTheEdition</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToTheEdition = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTheEdition"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to the edition in a language and/or script that differs from that recorded in the statement of responsibility relating to the edition element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTheEditionManifestation</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to the edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTheEditionManifestation">rdag1:parallelStatementOfResponsibilityRelatingToTheEditionManifestation</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToTheEditionManifestation = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTheEditionManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to title proper in a language and/or script that differs from that recorded in the statement of responsibility relating to title proper element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to title proper</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProper">rdag1:parallelStatementOfResponsibilityRelatingToTitleProper</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToTitleProper = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTitleProper"

    /// <summary>
    ///   <para>skos:definition : A statement of responsibility relating to title proper in a language and/or script that differs from that recorded in the statement of responsibility relating to title proper element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelStatementOfResponsibilityRelatingToTitleProperManifestation</para>
    ///   <para>rdfs:label : Parallel statement of responsibility relating to title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelStatementOfResponsibilityRelatingToTitleProperManifestation">rdag1:parallelStatementOfResponsibilityRelatingToTitleProperManifestation</a>
    /// </summary>
    let parallelStatementOfResponsibilityRelatingToTitleProperManifestation = _prefixId.prefix "parallelStatementOfResponsibilityRelatingToTitleProperManifestation"

    /// <summary>
    ///   <para>skos:definition : The title proper in another language and/or script. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProper</para>
    ///   <para>rdfs:label : Parallel title proper</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProper">rdag1:parallelTitleProper</a>
    /// </summary>
    let parallelTitleProper = _prefixId.prefix "parallelTitleProper"

    /// <summary>
    ///   <para>skos:definition : The title proper in another language and/or script. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperManifestation</para>
    ///   <para>rdfs:label : Parallel title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProperManifestation">rdag1:parallelTitleProperManifestation</a>
    /// </summary>
    let parallelTitleProperManifestation = _prefixId.prefix "parallelTitleProperManifestation"

    /// <summary>
    ///   <para>skos:definition : The title proper of a series in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSeries</para>
    ///   <para>rdfs:label : Parallel title proper of series</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProperOfSeries">rdag1:parallelTitleProperOfSeries</a>
    /// </summary>
    let parallelTitleProperOfSeries = _prefixId.prefix "parallelTitleProperOfSeries"

    /// <summary>
    ///   <para>skos:definition : The title proper of a series in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSeriesManifestation</para>
    ///   <para>rdfs:label : Parallel title proper of series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProperOfSeriesManifestation">rdag1:parallelTitleProperOfSeriesManifestation</a>
    /// </summary>
    let parallelTitleProperOfSeriesManifestation = _prefixId.prefix "parallelTitleProperOfSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : The title proper of a subseries in another language and/or script.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSubseries</para>
    ///   <para>rdfs:label : Parallel title proper of subseries</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProperOfSubseries">rdag1:parallelTitleProperOfSubseries</a>
    /// </summary>
    let parallelTitleProperOfSubseries = _prefixId.prefix "parallelTitleProperOfSubseries"

    /// <summary>
    ///   <para>skos:definition : The title proper of a subseries in another language and/or script.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parallelTitleProperOfSubseriesManifestation</para>
    ///   <para>rdfs:label : Parallel title proper of subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/parallelTitleProperOfSubseriesManifestation">rdag1:parallelTitleProperOfSubseriesManifestation</a>
    /// </summary>
    let parallelTitleProperOfSubseriesManifestation = _prefixId.prefix "parallelTitleProperOfSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for performing, narrating, and/or presenting a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerNarratorAndOrPresenter</para>
    ///   <para>rdfs:label : Performer, narrator, and/or presenter</para>
    ///   <a href="http://rdvocab.info/Elements/performerNarratorAndOrPresenter">rdag1:performerNarratorAndOrPresenter</a>
    /// </summary>
    let performerNarratorAndOrPresenter = _prefixId.prefix "performerNarratorAndOrPresenter"

    /// <summary>
    ///   <para>skos:definition : A person, family, or corporate body responsible for performing, narrating, and/or presenting a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : performerNarratorAndOrPresenterExpression</para>
    ///   <para>rdfs:label : Performer, narrator, and/or presenter (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/performerNarratorAndOrPresenterExpression">rdag1:performerNarratorAndOrPresenterExpression</a>
    /// </summary>
    let performerNarratorAndOrPresenterExpression = _prefixId.prefix "performerNarratorAndOrPresenterExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.9.0.1.1.</para>
    ///   <para>skos:definition : The place and date associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAndDateOfCapture</para>
    ///   <para>rdfs:label : Place and date of capture</para>
    ///   <a href="http://rdvocab.info/Elements/placeAndDateOfCapture">rdag1:placeAndDateOfCapture</a>
    /// </summary>
    let placeAndDateOfCapture = _prefixId.prefix "placeAndDateOfCapture"

    /// <summary>
    ///   <para>skos:definition : The place and date associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeAndDateOfCaptureExpression</para>
    ///   <para>rdfs:label : Place and date of capture (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/placeAndDateOfCaptureExpression">rdag1:placeAndDateOfCaptureExpression</a>
    /// </summary>
    let placeAndDateOfCaptureExpression = _prefixId.prefix "placeAndDateOfCaptureExpression"

    /// <summary>
    ///   <para>skos:definition : The place associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfCapture</para>
    ///   <para>rdfs:label : Place of capture</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfCapture">rdag1:placeOfCapture</a>
    /// </summary>
    let placeOfCapture = _prefixId.prefix "placeOfCapture"
    /// <summary>
    ///   <para>skos:definition : The place associated with the capture (i.e., recording, filming, etc.) of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfCaptureExpression</para>
    ///   <para>rdfs:label : Place of capture (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfCaptureExpression">rdag1:placeOfCaptureExpression</a>
    /// </summary>
    let placeOfCaptureExpression = _prefixId.prefix "placeOfCaptureExpression"
    /// <summary>
    ///   <para>skos:definition : A place associated with the distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDistribution</para>
    ///   <para>rdfs:label : Place of distribution</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfDistribution">rdag1:placeOfDistribution</a>
    /// </summary>
    let placeOfDistribution = _prefixId.prefix "placeOfDistribution"

    /// <summary>
    ///   <para>skos:definition : A place associated with the distribution of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfDistributionManifestation</para>
    ///   <para>rdfs:label : Place of distribution (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfDistributionManifestation">rdag1:placeOfDistributionManifestation</a>
    /// </summary>
    let placeOfDistributionManifestation = _prefixId.prefix "placeOfDistributionManifestation"

    /// <summary>
    ///   <para>skos:definition : A place associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfManufacture</para>
    ///   <para>rdfs:label : Place of manufacture</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfManufacture">rdag1:placeOfManufacture</a>
    /// </summary>
    let placeOfManufacture = _prefixId.prefix "placeOfManufacture"

    /// <summary>
    ///   <para>skos:definition : A place associated with the printing, duplicating, casting, etc., of a resource in a published form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfManufactureManifestation</para>
    ///   <para>rdfs:label : Place of manufacture (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfManufactureManifestation">rdag1:placeOfManufactureManifestation</a>
    /// </summary>
    let placeOfManufactureManifestation = _prefixId.prefix "placeOfManufactureManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.6.0.1.1</para>
    ///   <para>skos:definition : The country or other territorial jurisdiction from which a work originated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfOriginOfTheWork</para>
    ///   <para>rdfs:label : Place of origin of the work</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfOriginOfTheWork">rdag1:placeOfOriginOfTheWork</a>
    /// </summary>
    let placeOfOriginOfTheWork = _prefixId.prefix "placeOfOriginOfTheWork"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 2.7.1.1.1</para>
    ///   <para>skos:definition : A place associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfProduction</para>
    ///   <para>rdfs:label : Place of production</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfProduction">rdag1:placeOfProduction</a>
    /// </summary>
    let placeOfProduction = _prefixId.prefix "placeOfProduction"

    /// <summary>
    ///   <para>skos:definition : A place associated with the inscription, fabrication, construction, etc., of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfProductionManifestation</para>
    ///   <para>rdfs:label : Place of production (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfProductionManifestation">rdag1:placeOfProductionManifestation</a>
    /// </summary>
    let placeOfProductionManifestation = _prefixId.prefix "placeOfProductionManifestation"

    /// <summary>
    ///   <para>skos:definition : A place associated with the publication, release, or issuing of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfPublication</para>
    ///   <para>rdfs:label : Place of publication</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfPublication">rdag1:placeOfPublication</a>
    /// </summary>
    let placeOfPublication = _prefixId.prefix "placeOfPublication"

    /// <summary>
    ///   <para>skos:definition : A place associated with the publication, release, or issuing of a resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : placeOfPublicationManifestation</para>
    ///   <para>rdfs:label : Place of publication (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/placeOfPublicationManifestation">rdag1:placeOfPublicationManifestation</a>
    /// </summary>
    let placeOfPublicationManifestation = _prefixId.prefix "placeOfPublicationManifestation"

    /// <summary>
    ///   <para>skos:definition : A numbering designation assigned to a resource by a music publisher, usually printed at the bottom of each page, and sometimes appearing also on the title page.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plateNumberForMusic</para>
    ///   <para>rdfs:label : Plate number for music</para>
    ///   <para>skos:scopeNote : Definition source: RDA 2.14.2.1.2</para>
    ///   <para>rdfs:comment : See also Publisher's number for music.</para>
    ///   <a href="http://rdvocab.info/Elements/plateNumberForMusic">rdag1:plateNumberForMusic</a>
    /// </summary>
    let plateNumberForMusic = _prefixId.prefix "plateNumberForMusic"

    /// <summary>
    ///   <para>skos:definition : A numbering designation assigned to a resource by a music publisher, usually printed at the bottom of each page, and sometimes appearing also on the title page.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : plateNumberForMusicManifestation</para>
    ///   <para>rdfs:label : Plate number for music (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/plateNumberForMusicManifestation">rdag1:plateNumberForMusicManifestation</a>
    /// </summary>
    let plateNumberForMusicManifestation = _prefixId.prefix "plateNumberForMusicManifestation"

    /// <summary>
    ///   <para>skos:definition : The speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : playingSpeed</para>
    ///   <para>rdfs:label : Playing speed</para>
    ///   <a href="http://rdvocab.info/Elements/playingSpeed">rdag1:playingSpeed</a>
    /// </summary>
    let playingSpeed = _prefixId.prefix "playingSpeed"
    /// <summary>
    ///   <para>skos:definition : The speed at which an audio carrier must be operated to produce the sound intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : playingSpeedManifestation</para>
    ///   <para>rdfs:label : Playing speed (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/playingSpeedManifestation">rdag1:playingSpeedManifestation</a>
    /// </summary>
    let playingSpeedManifestation = _prefixId.prefix "playingSpeedManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.15.0.1.1</para>
    ///   <para>skos:definition : The relationship of the colours and tones in an image to the colours and tones of the object filmed (e.g., positive, negative).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : polarity</para>
    ///   <para>rdfs:label : Polarity</para>
    ///   <para>rdfs:comment : Associated with the FRBR Manifestation entity.</para>
    ///   <a href="http://rdvocab.info/Elements/polarity">rdag1:polarity</a>
    /// </summary>
    let polarity = _prefixId.prefix "polarity"
    /// <summary>
    ///   <para>skos:definition : The relationship of the colours and tones in an image to the colours and tones of the object filmed (e.g., positive, negative).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : polarityManifestation</para>
    ///   <para>rdfs:label : Polarity (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/polarityManifestation">rdag1:polarityManifestation</a>
    /// </summary>
    let polarityManifestation = _prefixId.prefix "polarityManifestation"
    /// <summary>
    ///   <para>skos:definition : A citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredCitation</para>
    ///   <para>rdfs:label : Preferred citation</para>
    ///   <a href="http://rdvocab.info/Elements/preferredCitation">rdag1:preferredCitation</a>
    /// </summary>
    let preferredCitation = _prefixId.prefix "preferredCitation"
    /// <summary>
    ///   <para>skos:definition : A citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredCitationItem</para>
    ///   <para>rdfs:label : Preferred citation (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/preferredCitationItem">rdag1:preferredCitationItem</a>
    /// </summary>
    let preferredCitationItem = _prefixId.prefix "preferredCitationItem"

    /// <summary>
    ///   <para>skos:definition : A citation for a resource in the form preferred by a creator, publisher, custodian, indexing or abstracting service, etc. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredCitationManifestation</para>
    ///   <para>rdfs:label : Preferred citation (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/preferredCitationManifestation">rdag1:preferredCitationManifestation</a>
    /// </summary>
    let preferredCitationManifestation = _prefixId.prefix "preferredCitationManifestation"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 6.2.0.1.1</para>
    ///   <para>skos:definition : The title or form of title chosen as the basis for the suthorized access point representing that work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preferredTitleForTheWork</para>
    ///   <para>rdfs:label : Preferred title for the work</para>
    ///   <a href="http://rdvocab.info/Elements/preferredTitleForTheWork">rdag1:preferredTitleForTheWork</a>
    /// </summary>
    let preferredTitleForTheWork = _prefixId.prefix "preferredTitleForTheWork"
    /// <summary>
    ///   <para>skos:definition : The format used in the production of a projected image (e.g., Cinerama, IMAX).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presentationFormat</para>
    ///   <para>rdfs:label : Presentation format</para>
    ///   <a href="http://rdvocab.info/Elements/presentationFormat">rdag1:presentationFormat</a>
    /// </summary>
    let presentationFormat = _prefixId.prefix "presentationFormat"

    /// <summary>
    ///   <para>skos:definition : The format used in the production of a projected image (e.g., Cinerama, IMAX).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : presentationFormatManifestation</para>
    ///   <para>rdfs:label : Presentation format (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/presentationFormatManifestation">rdag1:presentationFormatManifestation</a>
    /// </summary>
    let presentationFormatManifestation = _prefixId.prefix "presentationFormatManifestation"

    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producersName</para>
    ///   <para>rdfs:label : Producer's name</para>
    ///   <a href="http://rdvocab.info/Elements/producersName">rdag1:producersName</a>
    /// </summary>
    let producersName = _prefixId.prefix "producersName"
    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for inscribing, fabricating, constructing, etc., a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : producersNameManifestation</para>
    ///   <para>rdfs:label : Producer's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/producersNameManifestation">rdag1:producersNameManifestation</a>
    /// </summary>
    let producersNameManifestation = _prefixId.prefix "producersNameManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 2.3.0.1.1</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethod</para>
    ///   <para>rdfs:label : Production method</para>
    ///   <para>skos:definition : The process used to produce a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethod">rdag1:productionMethod</a>
    /// </summary>
    let productionMethod = _prefixId.prefix "productionMethod"
    /// <summary>
    ///   <para>skos:definition : The process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForManuscript</para>
    ///   <para>rdfs:label : Production method for manuscript</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethodForManuscript">rdag1:productionMethodForManuscript</a>
    /// </summary>
    let productionMethodForManuscript = _prefixId.prefix "productionMethodForManuscript"

    /// <summary>
    ///   <para>skos:definition : The process used to produce an original manuscript or a copy.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForManuscriptManifestation</para>
    ///   <para>rdfs:label : Production method for manuscript (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethodForManuscriptManifestation">rdag1:productionMethodForManuscriptManifestation</a>
    /// </summary>
    let productionMethodForManuscriptManifestation = _prefixId.prefix "productionMethodForManuscriptManifestation"

    /// <summary>
    ///   <para>skos:definition : The process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForTactileResource</para>
    ///   <para>rdfs:label : Production method for tactile resource</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethodForTactileResource">rdag1:productionMethodForTactileResource</a>
    /// </summary>
    let productionMethodForTactileResource = _prefixId.prefix "productionMethodForTactileResource"

    /// <summary>
    ///   <para>skos:definition : The process used to produce a tactile resource (e.g., embossing, thermoform).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodForTactileResourceManifestation</para>
    ///   <para>rdfs:label : Production method for tactile resource (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethodForTactileResourceManifestation">rdag1:productionMethodForTactileResourceManifestation</a>
    /// </summary>
    let productionMethodForTactileResourceManifestation = _prefixId.prefix "productionMethodForTactileResourceManifestation"

    let productionMethodForTactileResources = _prefixId.prefix "productionMethodForTactileResources"

    /// <summary>
    ///   <para>rdfs:label : Production method (Manifestation)</para>
    ///   <para>skos:definition : The process used to produce a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionMethodManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/productionMethodManifestation">rdag1:productionMethodManifestation</a>
    /// </summary>
    let productionMethodManifestation = _prefixId.prefix "productionMethodManifestation"
    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of production, producer or producers, and date or dates of production of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionStatement</para>
    ///   <para>rdfs:label : Production statement</para>
    ///   <a href="http://rdvocab.info/Elements/productionStatement">rdag1:productionStatement</a>
    /// </summary>
    let productionStatement = _prefixId.prefix "productionStatement"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of production, producer or producers, and date or dates of production of a resource in an unpublished form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : productionStatementManifestation</para>
    ///   <para>rdfs:label : Production statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/productionStatementManifestation">rdag1:productionStatementManifestation</a>
    /// </summary>
    let productionStatementManifestation = _prefixId.prefix "productionStatementManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionCharacteristicOfMotionPictureFilm</para>
    ///   <para>rdfs:label : Projection characteristic of motion picture film</para>
    ///   <a href="http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilm">rdag1:projectionCharacteristicOfMotionPictureFilm</a>
    /// </summary>
    let projectionCharacteristicOfMotionPictureFilm = _prefixId.prefix "projectionCharacteristicOfMotionPictureFilm"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionCharacteristicOfMotionPictureFilmManifestation</para>
    ///   <para>rdfs:label : Projection characteristic of motion picture film (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/projectionCharacteristicOfMotionPictureFilmManifestation">rdag1:projectionCharacteristicOfMotionPictureFilmManifestation</a>
    /// </summary>
    let projectionCharacteristicOfMotionPictureFilmManifestation = _prefixId.prefix "projectionCharacteristicOfMotionPictureFilmManifestation"

    let projectionCharacteristicsOfMotionPictureFilm = _prefixId.prefix "projectionCharacteristicsOfMotionPictureFilm"

    /// <summary>
    ///   <para>skos:definition : The method or system used to represent the surface of the Earth or of a celestial sphere on a plane.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionOfCartographicContent</para>
    ///   <para>rdfs:label : Projection of cartographic content</para>
    ///   <a href="http://rdvocab.info/Elements/projectionOfCartographicContent">rdag1:projectionOfCartographicContent</a>
    /// </summary>
    let projectionOfCartographicContent = _prefixId.prefix "projectionOfCartographicContent"

    /// <summary>
    ///   <para>skos:definition : The method or system used to represent the surface of the Earth or of a celestial sphere on a plane.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionOfCartographicContentExpression</para>
    ///   <para>rdfs:label : Projection of cartographic content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/projectionOfCartographicContentExpression">rdag1:projectionOfCartographicContentExpression</a>
    /// </summary>
    let projectionOfCartographicContentExpression = _prefixId.prefix "projectionOfCartographicContentExpression"

    /// <summary>
    ///   <para>skos:definition : The speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionSpeed</para>
    ///   <para>rdfs:label : Projection speed</para>
    ///   <a href="http://rdvocab.info/Elements/projectionSpeed">rdag1:projectionSpeed</a>
    /// </summary>
    let projectionSpeed = _prefixId.prefix "projectionSpeed"
    /// <summary>
    ///   <para>skos:definition : The speed at which a projected carrier must be operated to produce the moving image intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : projectionSpeedManifestation</para>
    ///   <para>rdfs:label : Projection speed (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/projectionSpeedManifestation">rdag1:projectionSpeedManifestation</a>
    /// </summary>
    let projectionSpeedManifestation = _prefixId.prefix "projectionSpeedManifestation"
    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of publication, publisher or publishers, and date or dates of publication of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publicationStatement</para>
    ///   <para>rdfs:label : Publication statement</para>
    ///   <a href="http://rdvocab.info/Elements/publicationStatement">rdag1:publicationStatement</a>
    /// </summary>
    let publicationStatement = _prefixId.prefix "publicationStatement"

    /// <summary>
    ///   <para>skos:definition : A statement identifying the place or places of publication, publisher or publishers, and date or dates of publication of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publicationStatementManifestation</para>
    ///   <para>rdfs:label : Publication statement (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/publicationStatementManifestation">rdag1:publicationStatementManifestation</a>
    /// </summary>
    let publicationStatementManifestation = _prefixId.prefix "publicationStatementManifestation"

    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersName</para>
    ///   <para>rdfs:label : Publisher's name</para>
    ///   <a href="http://rdvocab.info/Elements/publishersName">rdag1:publishersName</a>
    /// </summary>
    let publishersName = _prefixId.prefix "publishersName"
    /// <summary>
    ///   <para>skos:definition : The name of a person, family, or corporate body responsible for publishing, releasing, or issuing a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersNameManifestation</para>
    ///   <para>rdfs:label : Publisher's name (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/publishersNameManifestation">rdag1:publishersNameManifestation</a>
    /// </summary>
    let publishersNameManifestation = _prefixId.prefix "publishersNameManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersNumberForMusic</para>
    ///   <para>skos:definition : A numbering designation assigned to a resource by a music publisher, appearing normally only on the title page, the cover, and/or the first page of music.</para>
    ///   <para>skos:scopeNote : Definition source: RDA 2.14.1.1.1</para>
    ///   <para>rdfs:label : Publisher's number for music</para>
    ///   <para>rdfs:comment : See also Plate number for music.</para>
    ///   <a href="http://rdvocab.info/Elements/publishersNumberForMusic">rdag1:publishersNumberForMusic</a>
    /// </summary>
    let publishersNumberForMusic = _prefixId.prefix "publishersNumberForMusic"

    /// <summary>
    ///   <para>skos:definition : A numbering designation assigned to a resource by a music publisher, appearing normally only on the title page, the cover, and/or the first page of music.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : publishersNumberForMusicManifestation</para>
    ///   <para>rdfs:label : Publisher's number for music (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/publishersNumberForMusicManifestation">rdag1:publishersNumberForMusicManifestation</a>
    /// </summary>
    let publishersNumberForMusicManifestation = _prefixId.prefix "publishersNumberForMusicManifestation"

    /// <summary>
    ///   <para>skos:definition : The type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingMedium</para>
    ///   <para>rdfs:label : Recording medium</para>
    ///   <a href="http://rdvocab.info/Elements/recordingMedium">rdag1:recordingMedium</a>
    /// </summary>
    let recordingMedium = _prefixId.prefix "recordingMedium"
    /// <summary>
    ///   <para>skos:definition : The type of medium used to record sound on an audio carrier (e.g., magnetic, optical).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : recordingMediumManifestation</para>
    ///   <para>rdfs:label : Recording medium (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/recordingMediumManifestation">rdag1:recordingMediumManifestation</a>
    /// </summary>
    let recordingMediumManifestation = _prefixId.prefix "recordingMediumManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 3.16.0.1.1</para>
    ///   <para>skos:definition : The size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reductionRatio</para>
    ///   <para>rdfs:label : Reduction ratio</para>
    ///   <a href="http://rdvocab.info/Elements/reductionRatio">rdag1:reductionRatio</a>
    /// </summary>
    let reductionRatio = _prefixId.prefix "reductionRatio"
    /// <summary>
    ///   <para>skos:definition : The size of a micro-image in relation to the original from which it was produced.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reductionRatioManifestation</para>
    ///   <para>rdfs:label : Reduction ration (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/reductionRatioManifestation">rdag1:reductionRatioManifestation</a>
    /// </summary>
    let reductionRatioManifestation = _prefixId.prefix "reductionRatioManifestation"
    /// <summary>
    ///   <para>skos:definition : A code identifying the region of the world for which a videodisc has been encoded and preventing the disc from being played on a player sold in a different region.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : regionalEncoding</para>
    ///   <para>rdfs:label : Regional encoding</para>
    ///   <a href="http://rdvocab.info/Elements/regionalEncoding">rdag1:regionalEncoding</a>
    /// </summary>
    let regionalEncoding = _prefixId.prefix "regionalEncoding"
    /// <summary>
    ///   <para>skos:definition : A code identifying the region of the world for which a videodisc has been encoded and preventing the disc from being played on a player sold in a different region.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : regionalEncodingManifestation</para>
    ///   <para>rdfs:label : Regional encoding (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/regionalEncodingManifestation">rdag1:regionalEncodingManifestation</a>
    /// </summary>
    let regionalEncodingManifestation = _prefixId.prefix "regionalEncodingManifestation"
    /// <summary>
    ///   <para>skos:definition : The clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : resolution</para>
    ///   <para>rdfs:label : Resolution</para>
    ///   <a href="http://rdvocab.info/Elements/resolution">rdag1:resolution</a>
    /// </summary>
    let resolution = _prefixId.prefix "resolution"
    /// <summary>
    ///   <para>skos:definition : The clarity or fineness of detail in a digital image, expressed by the measurement of the image in pixels, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : resolutionManifestation</para>
    ///   <para>rdfs:label : Resolution (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/resolutionManifestation">rdag1:resolutionManifestation</a>
    /// </summary>
    let resolutionManifestation = _prefixId.prefix "resolutionManifestation"
    /// <summary>
    ///   <para>skos:definition : Limitations placed on access to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccess</para>
    ///   <para>rdfs:label : Restrictions on access</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnAccess">rdag1:restrictionsOnAccess</a>
    /// </summary>
    let restrictionsOnAccess = _prefixId.prefix "restrictionsOnAccess"
    /// <summary>
    ///   <para>skos:definition : Limitations placed on access to a resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccessItem</para>
    ///   <para>rdfs:label : Restrictions on access (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnAccessItem">rdag1:restrictionsOnAccessItem</a>
    /// </summary>
    let restrictionsOnAccessItem = _prefixId.prefix "restrictionsOnAccessItem"

    /// <summary>
    ///   <para>skos:definition : Limitations placed on access to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccessManifestation</para>
    ///   <para>rdfs:label : Restrictions on access (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnAccessManifestation">rdag1:restrictionsOnAccessManifestation</a>
    /// </summary>
    let restrictionsOnAccessManifestation = _prefixId.prefix "restrictionsOnAccessManifestation"

    /// <summary>
    ///   <para>skos:definition : Limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUse</para>
    ///   <para>rdfs:label : Restrictions on use</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnUse">rdag1:restrictionsOnUse</a>
    /// </summary>
    let restrictionsOnUse = _prefixId.prefix "restrictionsOnUse"
    /// <summary>
    ///   <para>skos:definition : Limitations placed on uses such as reproduction, publication, exhibition, etc. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUseItem</para>
    ///   <para>rdfs:label : Restrictions on use (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnUseItem">rdag1:restrictionsOnUseItem</a>
    /// </summary>
    let restrictionsOnUseItem = _prefixId.prefix "restrictionsOnUseItem"

    /// <summary>
    ///   <para>skos:definition : Limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUseManifestation</para>
    ///   <para>rdfs:label : Restrictions on use (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/restrictionsOnUseManifestation">rdag1:restrictionsOnUseManifestation</a>
    /// </summary>
    let restrictionsOnUseManifestation = _prefixId.prefix "restrictionsOnUseManifestation"

    /// <summary>
    ///   <para>skos:definition : A system for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rightAscensionAndDeclination</para>
    ///   <para>rdfs:label : Right ascension and declination</para>
    ///   <a href="http://rdvocab.info/Elements/rightAscensionAndDeclination">rdag1:rightAscensionAndDeclination</a>
    /// </summary>
    let rightAscensionAndDeclination = _prefixId.prefix "rightAscensionAndDeclination"

    /// <summary>
    ///   <para>skos:definition : A system for identifying the location of a celestial object in the sky covered by the cartographic content of a resource using the angles of right ascension and declination.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : rightAscensionAndDeclinationWork</para>
    ///   <para>rdfs:label : Right ascension and declination (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/rightAscensionAndDeclinationWork">rdag1:rightAscensionAndDeclinationWork</a>
    /// </summary>
    let rightAscensionAndDeclinationWork = _prefixId.prefix "rightAscensionAndDeclinationWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scale</para>
    ///   <para>skos:definition : The ratio of the dimensions of an image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>rdfs:label : Scale</para>
    ///   <a href="http://rdvocab.info/Elements/scale">rdag1:scale</a>
    /// </summary>
    let scale = _prefixId.prefix "scale"
    /// <summary>
    ///   <para>skos:definition : The ratio of the dimensions of an image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scaleExpression</para>
    ///   <para>rdfs:label : Scale (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/scaleExpression">rdag1:scaleExpression</a>
    /// </summary>
    let scaleExpression = _prefixId.prefix "scaleExpression"

    /// <summary>
    ///   <para>skos:definition : The ratio of the dimensions of a still image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scaleOfStillImageOrThree-dimensionalForm</para>
    ///   <para>rdfs:label : Scale of still image or three-dimensional form</para>
    ///   <a href="http://rdvocab.info/Elements/scaleOfStillImageOrThree-dimensionalForm">rdag1:scaleOfStillImageOrThree-dimensionalForm</a>
    /// </summary>
    let scaleOfStillImageOrThree_dimensionalForm = _prefixId.prefix "scaleOfStillImageOrThree-dimensionalForm"

    /// <summary>
    ///   <para>skos:definition : The ratio of the dimensions of a still image or three-dimensional form contained or embodied in a resource to the dimensions of the entity it represents.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scaleOfStillImageOrThreeDimensionalFormExpression</para>
    ///   <para>rdfs:label : Scale of still image or three-dimensional form (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/scaleOfStillImageOrThreeDimensionalFormExpression">rdag1:scaleOfStillImageOrThreeDimensionalFormExpression</a>
    /// </summary>
    let scaleOfStillImageOrThreeDimensionalFormExpression = _prefixId.prefix "scaleOfStillImageOrThreeDimensionalFormExpression"

    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the written language content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : script</para>
    ///   <para>rdfs:label : Script</para>
    ///   <a href="http://rdvocab.info/Elements/script">rdag1:script</a>
    /// </summary>
    let script = _prefixId.prefix "script"
    /// <summary>
    ///   <para>skos:definition : A set of characters and/or symbols used to express the written language content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptExpression</para>
    ///   <para>rdfs:label : Script (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/scriptExpression">rdag1:scriptExpression</a>
    /// </summary>
    let scriptExpression = _prefixId.prefix "scriptExpression"
    /// <summary>
    ///   <para>skos:scopeNote : Definition Source: 2.11.0.1.1
    /// </para>
    ///   <para>skos:definition : A statement identifying a series to which a resource belongs and the numbering of the resource within the series. A series statement may also include information identifying one or more
    /// subseries to which the resource being described belongs.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesStatement</para>
    ///   <para>rdfs:label : Series statement</para>
    ///   <a href="http://rdvocab.info/Elements/seriesStatement">rdag1:seriesStatement</a>
    /// </summary>
    let seriesStatement = _prefixId.prefix "seriesStatement"
    /// <summary>
    ///   <para>skos:definition : A statement identifying a series to which a resource belongs and the numbering of the resource within the series. A series statement may also include information identifying one or more
    /// subseries to which the resource being described belongs.</para>
    ///   <para>rdfs:label : Series statement (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesStatementManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/seriesStatementManifestation">rdag1:seriesStatementManifestation</a>
    /// </summary>
    let seriesStatementManifestation = _prefixId.prefix "seriesStatementManifestation"
    /// <summary>
    ///   <para>skos:scopeNote : Definition from: 6.27.0.1.1 </para>
    ///   <para>skos:definition : A government or other party that has formally signed a treaty, etc., as an adherent to its terms and conditions.
    /// </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : signatoryToATreatyEtc</para>
    ///   <para>rdfs:label : Signatory to a treaty, etc.</para>
    ///   <a href="http://rdvocab.info/Elements/signatoryToATreatyEtc">rdag1:signatoryToATreatyEtc</a>
    /// </summary>
    let signatoryToATreatyEtc = _prefixId.prefix "signatoryToATreatyEtc"
    /// <summary>
    ///   <para>skos:definition : A government or other party that has formally signed a treaty, etc., as an adherent to its terms and conditions.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : signatoryToATreatyEtcWork</para>
    ///   <para>rdfs:label : Signatory to a treaty, etc. (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/signatoryToATreatyEtcWork">rdag1:signatoryToATreatyEtcWork</a>
    /// </summary>
    let signatoryToATreatyEtcWork = _prefixId.prefix "signatoryToATreatyEtcWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundCharacteristic</para>
    ///   <para>skos:scopeNote : Definition source: RDA 3.17.0.1.1</para>
    ///   <para>rdfs:label : Sound characteristic</para>
    ///   <para>skos:definition : A technical specification relating to the encoding of sound in a resource.</para>
    ///   <a href="http://rdvocab.info/Elements/soundCharacteristic">rdag1:soundCharacteristic</a>
    /// </summary>
    let soundCharacteristic = _prefixId.prefix "soundCharacteristic"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundCharacteristicManifestation</para>
    ///   <para>skos:definition : A technical specification relating to the encoding of sound in a resource.</para>
    ///   <para>rdfs:label : Sound characteristic (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/soundCharacteristicManifestation">rdag1:soundCharacteristicManifestation</a>
    /// </summary>
    let soundCharacteristicManifestation = _prefixId.prefix "soundCharacteristicManifestation"

    /// <summary>
    ///   <para>skos:definition : The presence of sound in a resource other than one that consists primarily of recorded sound.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundContent</para>
    ///   <para>rdfs:label : Sound content</para>
    ///   <a href="http://rdvocab.info/Elements/soundContent">rdag1:soundContent</a>
    /// </summary>
    let soundContent = _prefixId.prefix "soundContent"
    /// <summary>
    ///   <para>skos:definition : The presence of sound in a resource other than one that consists primarily of recorded sound. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundContentExpression</para>
    ///   <para>rdfs:label : Sound content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/soundContentExpression">rdag1:soundContentExpression</a>
    /// </summary>
    let soundContentExpression = _prefixId.prefix "soundContentExpression"
    /// <summary>
    ///   <para>skos:definition : The presence of sound in a resource other than one that consists primarily of recorded sound. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : soundContentManifestation</para>
    ///   <para>rdfs:label : Sound content (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/soundContentManifestation">rdag1:soundContentManifestation</a>
    /// </summary>
    let soundContentManifestation = _prefixId.prefix "soundContentManifestation"
    /// <summary>
    ///   <para>skos:definition : A resource used in determining the name, title or other identifying attributes of an entity, or in determining the relationship between entities.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sourceConsulted</para>
    ///   <para>rdfs:label : Source consulted</para>
    ///   <a href="http://rdvocab.info/Elements/sourceConsulted">rdag1:sourceConsulted</a>
    /// </summary>
    let sourceConsulted = _prefixId.prefix "sourceConsulted"
    /// <summary>
    ///   <para>skos:definition : An equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialPlaybackCharacteristic</para>
    ///   <para>rdfs:label : Special playback characteristic</para>
    ///   <a href="http://rdvocab.info/Elements/specialPlaybackCharacteristic">rdag1:specialPlaybackCharacteristic</a>
    /// </summary>
    let specialPlaybackCharacteristic = _prefixId.prefix "specialPlaybackCharacteristic"

    /// <summary>
    ///   <para>skos:definition : An equalization system, noise reduction system, etc., used in making an audio recording.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialPlaybackCharacteristicManifestation</para>
    ///   <para>rdfs:label : Special playback characteristic (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/specialPlaybackCharacteristicManifestation">rdag1:specialPlaybackCharacteristicManifestation</a>
    /// </summary>
    let specialPlaybackCharacteristicManifestation = _prefixId.prefix "specialPlaybackCharacteristicManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibility</para>
    ///   <para>rdfs:label : Statement of responsibility</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibility">rdag1:statementOfResponsibility</a>
    /// </summary>
    let statementOfResponsibility = _prefixId.prefix "statementOfResponsibility"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityManifestation</para>
    ///   <para>rdfs:label : Statement of responsibility (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityManifestation">rdag1:statementOfResponsibilityManifestation</a>
    /// </summary>
    let statementOfResponsibilityManifestation = _prefixId.prefix "statementOfResponsibilityManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a named revision of an edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</para>
    ///   <para>rdfs:label : Statement of responsibility relating to a named revision of an edition</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEdition">rdag1:statementOfResponsibilityRelatingToANamedRevisionOfAnEdition</a>
    /// </summary>
    let statementOfResponsibilityRelatingToANamedRevisionOfAnEdition = _prefixId.prefix "statementOfResponsibilityRelatingToANamedRevisionOfAnEdition"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a named revision of an edition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion</para>
    ///   <para>rdfs:label : Statement of responsibility relating to a named revision of an edition (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion">rdag1:statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion</a>
    /// </summary>
    let statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion =
        _prefixId.prefix "statementOfResponsibilityRelatingToANamedRevisionOfAnEditionManifestatiion"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSeries</para>
    ///   <para>rdfs:label : Statement of responsibility relating to series</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeries">rdag1:statementOfResponsibilityRelatingToSeries</a>
    /// </summary>
    let statementOfResponsibilityRelatingToSeries = _prefixId.prefix "statementOfResponsibilityRelatingToSeries"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSeriesManifestation</para>
    ///   <para>rdfs:label : Statement of responsibility relating to series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSeriesManifestation">rdag1:statementOfResponsibilityRelatingToSeriesManifestation</a>
    /// </summary>
    let statementOfResponsibilityRelatingToSeriesManifestation = _prefixId.prefix "statementOfResponsibilityRelatingToSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSubseries</para>
    ///   <para>rdfs:label : Statement of responsibility relating to subseries</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseries">rdag1:statementOfResponsibilityRelatingToSubseries</a>
    /// </summary>
    let statementOfResponsibilityRelatingToSubseries = _prefixId.prefix "statementOfResponsibilityRelatingToSubseries"

    /// <summary>
    ///   <para>skos:definition : A statement relating to the identification of any persons, families, or corporate bodies responsible for a subseries.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToSubseriesManifestatiion</para>
    ///   <para>rdfs:label : Statement of responsibility relating to subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToSubseriesManifestatiion">rdag1:statementOfResponsibilityRelatingToSubseriesManifestatiion</a>
    /// </summary>
    let statementOfResponsibilityRelatingToSubseriesManifestatiion = _prefixId.prefix "statementOfResponsibilityRelatingToSubseriesManifestatiion"

    /// <summary>
    ///   <para>skos:definition : A statement associated with the title proper of a resource that relates to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTitleProper</para>
    ///   <para>rdfs:label : Statement of responsibility relating to title proper</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProper">rdag1:statementOfResponsibilityRelatingToTitleProper</a>
    /// </summary>
    let statementOfResponsibilityRelatingToTitleProper = _prefixId.prefix "statementOfResponsibilityRelatingToTitleProper"

    /// <summary>
    ///   <para>skos:definition : A statement associated with the title proper of a resource that relates to the identification and/or function of any persons, families, or corporate bodies responsible for the creation of, or contributing to the realization of, the intellectual or artistic content of the resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statementOfResponsibilityRelatingToTitleProperManifestation</para>
    ///   <para>rdfs:label : Statement of responsibility relating to title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/statementOfResponsibilityRelatingToTitleProperManifestation">rdag1:statementOfResponsibilityRelatingToTitleProperManifestation</a>
    /// </summary>
    let statementOfResponsibilityRelatingToTitleProperManifestation = _prefixId.prefix "statementOfResponsibilityRelatingToTitleProperManifestation"

    /// <summary>
    ///   <para>skos:definition : An indication of the level of authentication of the data identifying an entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : statusOfIdentification</para>
    ///   <para>rdfs:label : Status of identification</para>
    ///   <a href="http://rdvocab.info/Elements/statusOfIdentification">rdag1:statusOfIdentification</a>
    /// </summary>
    let statusOfIdentification = _prefixId.prefix "statusOfIdentification"
    /// <summary>
    ///   <para>skos:definition : A system for identifying the precise area covered by the cartographic content of a resource using coordinates for each vertex of a polygon.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stringsOfCoordinatePairs</para>
    ///   <para>rdfs:label : Strings of coordinate pairs</para>
    ///   <a href="http://rdvocab.info/Elements/stringsOfCoordinatePairs">rdag1:stringsOfCoordinatePairs</a>
    /// </summary>
    let stringsOfCoordinatePairs = _prefixId.prefix "stringsOfCoordinatePairs"
    /// <summary>
    ///   <para>skos:definition : A system for identifying the precise area covered by the cartographic content of a resource using coordinates for each vertex of a polygon.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : stringsOfCoordinatePairsWork</para>
    ///   <para>rdfs:label : Strings of coordinate pairs (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/stringsOfCoordinatePairsWork">rdag1:stringsOfCoordinatePairsWork</a>
    /// </summary>
    let stringsOfCoordinatePairsWork = _prefixId.prefix "stringsOfCoordinatePairsWork"
    /// <summary>
    ///   <para>skos:definition : An abstract, summary, synopsis, etc., of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizationOfTheContent</para>
    ///   <para>rdfs:label : Summarization of the content</para>
    ///   <a href="http://rdvocab.info/Elements/summarizationOfTheContent">rdag1:summarizationOfTheContent</a>
    /// </summary>
    let summarizationOfTheContent = _prefixId.prefix "summarizationOfTheContent"

    /// <summary>
    ///   <para>skos:definition : An abstract, summary, synopsis, etc., of the content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summarizationOfTheContentExpression</para>
    ///   <para>rdfs:label : Summarization of the content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/summarizationOfTheContentExpression">rdag1:summarizationOfTheContentExpression</a>
    /// </summary>
    let summarizationOfTheContentExpression = _prefixId.prefix "summarizationOfTheContentExpression"

    /// <summary>
    ///   <para>skos:definition : Content (e.g., an index, bibliography, or appendix) designed to supplement the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementaryContent</para>
    ///   <para>rdfs:label : Supplementary content</para>
    ///   <a href="http://rdvocab.info/Elements/supplementaryContent">rdag1:supplementaryContent</a>
    /// </summary>
    let supplementaryContent = _prefixId.prefix "supplementaryContent"

    /// <summary>
    ///   <para>skos:definition : Content (e.g., an index, bibliography, or appendix) designed to supplement the primary content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementaryContentExpression</para>
    ///   <para>rdfs:label : Supplementary content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/supplementaryContentExpression">rdag1:supplementaryContentExpression</a>
    /// </summary>
    let supplementaryContentExpression = _prefixId.prefix "supplementaryContentExpression"

    /// <summary>
    ///   <para>skos:scopeNote : Definition source: RDA 7.7.0.1.1</para>
    ///   <para>skos:definition : A system of arranging materials in an archival resource or a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : systemOfOrganization</para>
    ///   <para>rdfs:label : System of organization</para>
    ///   <a href="http://rdvocab.info/Elements/systemOfOrganization">rdag1:systemOfOrganization</a>
    /// </summary>
    let systemOfOrganization = _prefixId.prefix "systemOfOrganization"
    /// <summary>
    ///   <para>skos:definition : A system of arranging materials in an archival resource or a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : systemOfOrganizationWork</para>
    ///   <para>rdfs:label : System of organization (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/systemOfOrganizationWork">rdag1:systemOfOrganizationWork</a>
    /// </summary>
    let systemOfOrganizationWork = _prefixId.prefix "systemOfOrganizationWork"
    /// <summary>
    ///   <para>skos:definition : The number of tracks on an audiotape.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : tapeConfiguration</para>
    ///   <para>rdfs:label : Tape configuration</para>
    ///   <a href="http://rdvocab.info/Elements/tapeConfiguration">rdag1:tapeConfiguration</a>
    /// </summary>
    let tapeConfiguration = _prefixId.prefix "tapeConfiguration"

    /// <summary>
    ///   <para>skos:definition : The number of tracks on an audiotape.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : tapeConfigurationManifestation</para>
    ///   <para>rdfs:label : Tape configuration (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/tapeConfigurationManifestation">rdag1:tapeConfigurationManifestation</a>
    /// </summary>
    let tapeConfigurationManifestation = _prefixId.prefix "tapeConfigurationManifestation"

    /// <summary>
    ///   <para>skos:definition : The conditions under which the publisher or distributor will normally supply a resource, or the price of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : termsOfAvailability</para>
    ///   <para>rdfs:label : Terms of availability</para>
    ///   <a href="http://rdvocab.info/Elements/termsOfAvailability">rdag1:termsOfAvailability</a>
    /// </summary>
    let termsOfAvailability = _prefixId.prefix "termsOfAvailability"

    /// <summary>
    ///   <para>skos:definition : The conditions under which the publisher or distributor will normally supply a resource, or the price of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : termsOfAvailabilityManifestation</para>
    ///   <para>rdfs:label : Terms of availability (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/termsOfAvailabilityManifestation">rdag1:termsOfAvailabilityManifestation</a>
    /// </summary>
    let termsOfAvailabilityManifestation = _prefixId.prefix "termsOfAvailabilityManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : title</para>
    ///   <para>rdfs:label : Title</para>
    ///   <para>skos:definition : A word, character, or group of words and/or characters that names a resource or a work contained in it.</para>
    ///   <a href="http://rdvocab.info/Elements/title">rdag1:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:label : Title (Manifestation)</para>
    ///   <para>skos:definition : A word, character, or group of words and/or characters that names a resource or a work contained in it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/titleManifestation">rdag1:titleManifestation</a>
    /// </summary>
    let titleManifestation = _prefixId.prefix "titleManifestation"
    /// <summary>
    ///   <para>skos:definition : A word, character, or group of words and/or characters by which a work is known.</para>
    ///   <para>rdfs:label : Title of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleOfTheWork</para>
    ///   <a href="http://rdvocab.info/Elements/titleOfTheWork">rdag1:titleOfTheWork</a>
    /// </summary>
    let titleOfTheWork = _prefixId.prefix "titleOfTheWork"
    let titleOfWork = _prefixId.prefix "titleOfWork"
    /// <summary>
    ///   <para>skos:definition : The chief name of a resource (i.e., the title normally used when citing the resource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProper</para>
    ///   <para>rdfs:label : Title proper</para>
    ///   <a href="http://rdvocab.info/Elements/titleProper">rdag1:titleProper</a>
    /// </summary>
    let titleProper = _prefixId.prefix "titleProper"
    /// <summary>
    ///   <para>skos:definition : The chief name of a resource (i.e., the title normally used when citing the resource).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperManifestation</para>
    ///   <para>rdfs:label : Title proper (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/titleProperManifestation">rdag1:titleProperManifestation</a>
    /// </summary>
    let titleProperManifestation = _prefixId.prefix "titleProperManifestation"
    /// <summary>
    ///   <para>skos:definition : The chief name of a series (i.e., the title normally used when citing the series).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSeries</para>
    ///   <para>rdfs:label : Title proper of series</para>
    ///   <a href="http://rdvocab.info/Elements/titleProperOfSeries">rdag1:titleProperOfSeries</a>
    /// </summary>
    let titleProperOfSeries = _prefixId.prefix "titleProperOfSeries"

    /// <summary>
    ///   <para>skos:definition : The chief name of a series (i.e., the title normally used when citing the series).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSeriesManifestation</para>
    ///   <para>rdfs:label : Title proper of series (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/titleProperOfSeriesManifestation">rdag1:titleProperOfSeriesManifestation</a>
    /// </summary>
    let titleProperOfSeriesManifestation = _prefixId.prefix "titleProperOfSeriesManifestation"

    /// <summary>
    ///   <para>skos:definition : The chief name of a subseries (i.e., the title normally used when citing the subseries).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSubseries</para>
    ///   <para>rdfs:label : Title proper of subseries</para>
    ///   <a href="http://rdvocab.info/Elements/titleProperOfSubseries">rdag1:titleProperOfSubseries</a>
    /// </summary>
    let titleProperOfSubseries = _prefixId.prefix "titleProperOfSubseries"

    /// <summary>
    ///   <para>skos:definition : The chief name of a subseries (i.e., the title normally used when citing the subseries).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : titleProperOfSubseriesManifestation</para>
    ///   <para>rdfs:label : Title proper of subseries (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/titleProperOfSubseriesManifestation">rdag1:titleProperOfSubseriesManifestation</a>
    /// </summary>
    let titleProperOfSubseriesManifestation = _prefixId.prefix "titleProperOfSubseriesManifestation"

    /// <summary>
    ///   <para>skos:definition : The configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : trackConfiguration</para>
    ///   <para>rdfs:label : Track configuration</para>
    ///   <a href="http://rdvocab.info/Elements/trackConfiguration">rdag1:trackConfiguration</a>
    /// </summary>
    let trackConfiguration = _prefixId.prefix "trackConfiguration"

    /// <summary>
    ///   <para>skos:definition : The configuration of the audio track on a sound-track film (e.g., centre track).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : trackConfigurationManifestation</para>
    ///   <para>rdfs:label : Track configuration (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/trackConfigurationManifestation">rdag1:trackConfigurationManifestation</a>
    /// </summary>
    let trackConfigurationManifestation = _prefixId.prefix "trackConfigurationManifestation"

    /// <summary>
    ///   <para>skos:definition : The speed at which streaming audio or video is designed to play.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transmissionSpeed</para>
    ///   <para>rdfs:label : Transmission speed</para>
    ///   <a href="http://rdvocab.info/Elements/transmissionSpeed">rdag1:transmissionSpeed</a>
    /// </summary>
    let transmissionSpeed = _prefixId.prefix "transmissionSpeed"

    /// <summary>
    ///   <para>skos:definition : The speed at which streaming audio or video is designed to play.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : transmissionSpeedManifestation</para>
    ///   <para>rdfs:label : Transmission speed (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/transmissionSpeedManifestation">rdag1:transmissionSpeedManifestation</a>
    /// </summary>
    let transmissionSpeedManifestation = _prefixId.prefix "transmissionSpeedManifestation"

    /// <summary>
    ///   <para>skos:definition : The method used to encode audio content for playback (i.e., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfRecordingAnalogDigital</para>
    ///   <para>rdfs:label : Type of recording</para>
    ///   <a href="http://rdvocab.info/Elements/typeOfRecordingAnalogDigital">rdag1:typeOfRecordingAnalogDigital</a>
    /// </summary>
    let typeOfRecordingAnalogDigital = _prefixId.prefix "typeOfRecordingAnalogDigital"
    /// <summary>
    ///   <para>skos:definition : The method used to encode audio content for playback (i.e., analog or digital).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : typeOfRecordingManifestation</para>
    ///   <para>rdfs:label : Type of recording (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/typeOfRecordingManifestation">rdag1:typeOfRecordingManifestation</a>
    /// </summary>
    let typeOfRecordingManifestation = _prefixId.prefix "typeOfRecordingManifestation"
    /// <summary>
    ///   <para>skos:definition : The address of a remote access resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : uniformResourceLocator</para>
    ///   <para>rdfs:label : Uniform resource locator</para>
    ///   <a href="http://rdvocab.info/Elements/uniformResourceLocator">rdag1:uniformResourceLocator</a>
    /// </summary>
    let uniformResourceLocator = _prefixId.prefix "uniformResourceLocator"
    /// <summary>
    ///   <para>skos:definition : The address of a remote access resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : uniformResourceLocatorItem</para>
    ///   <para>rdfs:label : Uniform resource locator (Item)</para>
    ///   <a href="http://rdvocab.info/Elements/uniformResourceLocatorItem">rdag1:uniformResourceLocatorItem</a>
    /// </summary>
    let uniformResourceLocatorItem = _prefixId.prefix "uniformResourceLocatorItem"

    /// <summary>
    ///   <para>skos:definition : The address of a remote access resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : uniformResourceLocatorManifestation</para>
    ///   <para>rdfs:label : Uniform resource locator (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/uniformResourceLocatorManifestation">rdag1:uniformResourceLocatorManifestation</a>
    /// </summary>
    let uniformResourceLocatorManifestation = _prefixId.prefix "uniformResourceLocatorManifestation"

    /// <summary>
    ///   <para>skos:definition : A title associated with a resource that differs from a title recorded as the title proper, a parallel title proper, other title information, parallel other title information, earlier title proper, later title proper, key title, or abbreviated title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitle</para>
    ///   <para>rdfs:label : Variant title</para>
    ///   <a href="http://rdvocab.info/Elements/variantTitle">rdag1:variantTitle</a>
    /// </summary>
    let variantTitle = _prefixId.prefix "variantTitle"
    /// <summary>
    ///   <para>skos:definition : A title or form of title by which a work is known that differs from the title or form of title chosen as the preferred title for the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitleForTheWork</para>
    ///   <para>rdfs:label : Variant title for the work</para>
    ///   <a href="http://rdvocab.info/Elements/variantTitleForTheWork">rdag1:variantTitleForTheWork</a>
    /// </summary>
    let variantTitleForTheWork = _prefixId.prefix "variantTitleForTheWork"
    /// <summary>
    ///   <para>skos:definition : A title associated with a resource that differs from a title recorded as the title proper, a parallel title proper, other title information, parallel other title information, earlier title proper, later title proper, key title, or abbreviated title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : variantTitleManifestation</para>
    ///   <para>rdfs:label : Variant title (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/variantTitleManifestation">rdag1:variantTitleManifestation</a>
    /// </summary>
    let variantTitleManifestation = _prefixId.prefix "variantTitleManifestation"

    /// <summary>
    ///   <para>skos:definition : The scale of elevation or vertical dimension of the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verticalScaleCartographicContent</para>
    ///   <para>rdfs:label : Vertical scale of cartographic content</para>
    ///   <a href="http://rdvocab.info/Elements/verticalScaleCartographicContent">rdag1:verticalScaleCartographicContent</a>
    /// </summary>
    let verticalScaleCartographicContent = _prefixId.prefix "verticalScaleCartographicContent"

    /// <summary>
    ///   <para>skos:definition : The scale of elevation or vertical dimension of the cartographic content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verticalScaleCartographicContentExpression</para>
    ///   <para>rdfs:label : Vertical scale of cartographic content (Expression)</para>
    ///   <a href="http://rdvocab.info/Elements/verticalScaleCartographicContentExpression">rdag1:verticalScaleCartographicContentExpression</a>
    /// </summary>
    let verticalScaleCartographicContentExpression = _prefixId.prefix "verticalScaleCartographicContentExpression"

    /// <summary>
    ///   <para>skos:definition : A technical specification relating to the encoding of video images in a resource. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoCharacteristic</para>
    ///   <para>rdfs:label : Video characteristic</para>
    ///   <a href="http://rdvocab.info/Elements/videoCharacteristic">rdag1:videoCharacteristic</a>
    /// </summary>
    let videoCharacteristic = _prefixId.prefix "videoCharacteristic"

    /// <summary>
    ///   <para>skos:definition : A technical specification relating to the encoding of video images in a resource. </para>
    ///   <para>rdfs:label : Video characteristic (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoCharacteristicManifestation</para>
    ///   <a href="http://rdvocab.info/Elements/videoCharacteristicManifestation">rdag1:videoCharacteristicManifestation</a>
    /// </summary>
    let videoCharacteristicManifestation = _prefixId.prefix "videoCharacteristicManifestation"

    /// <summary>
    ///   <para>skos:definition : A standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoFormat</para>
    ///   <para>rdfs:label : Video format</para>
    ///   <a href="http://rdvocab.info/Elements/videoFormat">rdag1:videoFormat</a>
    /// </summary>
    let videoFormat = _prefixId.prefix "videoFormat"
    /// <summary>
    ///   <para>skos:definition : A standard, etc., used to encode the analog video content of a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoFormatManifestation</para>
    ///   <para>rdfs:label : Video format (Manifestation)</para>
    ///   <a href="http://rdvocab.info/Elements/videoFormatManifestation">rdag1:videoFormatManifestation</a>
    /// </summary>
    let videoFormatManifestation = _prefixId.prefix "videoFormatManifestation"
    /// <summary>
    ///   <para>skos:definition : The calendar year in which a granting institution or faculty conferred an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : yearDegreeGranted</para>
    ///   <para>rdfs:label : Year degree granted</para>
    ///   <a href="http://rdvocab.info/Elements/yearDegreeGranted">rdag1:yearDegreeGranted</a>
    /// </summary>
    let yearDegreeGranted = _prefixId.prefix "yearDegreeGranted"
    /// <summary>
    ///   <para>skos:definition : The calendar year in which a granting institution or faculty conferred an academic degree on a candidate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : yearDegreeGrantedWork</para>
    ///   <para>rdfs:label : Year degree granted (Work)</para>
    ///   <a href="http://rdvocab.info/Elements/yearDegreeGrantedWork">rdag1:yearDegreeGrantedWork</a>
    /// </summary>
    let yearDegreeGrantedWork = _prefixId.prefix "yearDegreeGrantedWork"
