#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdarel =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdvocab.info/RDARelationshipsWEMI/" "rdarel"

    /// <summary>
    ///   <para>skos:definition : A work that comprises the text of an opera or other work for the musical stage, or an oratorio, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : BasisForLibrettoWork</para>
    ///   <para>rdfs:label : Basis for libretto (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/BasisForLibrettoWork">rdarel:BasisForLibrettoWork</a>
    /// </summary>
    let BasisForLibrettoWork = _prefixId.prefix "BasisForLibrettoWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAs</para>
    ///   <para>rdfs:label : Abridged as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAs">rdarel:abridgedAs</a>
    /// </summary>
    let abridgedAs = _prefixId.prefix "abridgedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that shortens the source entity without changing the general meaning or manner of presentation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAsExpression</para>
    ///   <para>rdfs:label : Abridged as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsExpression">rdarel:abridgedAsExpression</a>
    /// </summary>
    let abridgedAsExpression = _prefixId.prefix "abridgedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that shortens the source work without changing the general meaning or manner of presentation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgedAsWork</para>
    ///   <para>rdfs:label : Abridged as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgedAsWork">rdarel:abridgedAsWork</a>
    /// </summary>
    let abridgedAsWork = _prefixId.prefix "abridgedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOf</para>
    ///   <para>rdfs:label : Abridgement of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOf">rdarel:abridgementOf</a>
    /// </summary>
    let abridgementOf = _prefixId.prefix "abridgementOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOfExpression</para>
    ///   <para>rdfs:label : Abridgement of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfExpression">rdarel:abridgementOfExpression</a>
    /// </summary>
    let abridgementOfExpression = _prefixId.prefix "abridgementOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been abridged, i.e., shortened without changing the general meaning or manner of presentation of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abridgementOfWork</para>
    ///   <para>rdfs:label : Abridgement of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abridgementOfWork">rdarel:abridgementOfWork</a>
    /// </summary>
    let abridgementOfWork = _prefixId.prefix "abridgementOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbed</para>
    ///   <para>rdfs:label : Absorbed</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbed">rdarel:absorbed</a>
    /// </summary>
    let absorbed = _prefixId.prefix "absorbed"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedBy</para>
    ///   <para>rdfs:label : Absorbed by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedBy">rdarel:absorbedBy</a>
    /// </summary>
    let absorbedBy = _prefixId.prefix "absorbedBy"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that incorporates another entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedByExpression</para>
    ///   <para>rdfs:label : Absorbed by (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByExpression">rdarel:absorbedByExpression</a>
    /// </summary>
    let absorbedByExpression = _prefixId.prefix "absorbedByExpression"
    /// <summary>
    ///   <para>skos:definition : A work that incorporates another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedByWork</para>
    ///   <para>rdfs:label : Absorbed by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedByWork">rdarel:absorbedByWork</a>
    /// </summary>
    let absorbedByWork = _prefixId.prefix "absorbedByWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been incorporated into another entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedExpression</para>
    ///   <para>rdfs:label : Absorbed (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedExpression">rdarel:absorbedExpression</a>
    /// </summary>
    let absorbedExpression = _prefixId.prefix "absorbedExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPart</para>
    ///   <para>rdfs:label : Absorbed in part</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPart">rdarel:absorbedInPart</a>
    /// </summary>
    let absorbedInPart = _prefixId.prefix "absorbedInPart"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartBy</para>
    ///   <para>rdfs:label : Absorbed in part by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartBy">rdarel:absorbedInPartBy</a>
    /// </summary>
    let absorbedInPartBy = _prefixId.prefix "absorbedInPartBy"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that incorporates part of the content of another entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartByExpression</para>
    ///   <para>rdfs:label : Absorbed in part by (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByExpression">rdarel:absorbedInPartByExpression</a>
    /// </summary>
    let absorbedInPartByExpression = _prefixId.prefix "absorbedInPartByExpression"
    /// <summary>
    ///   <para>skos:definition : A work that incorporates part of the content of another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartByWork</para>
    ///   <para>rdfs:label : Absorbed in part by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartByWork">rdarel:absorbedInPartByWork</a>
    /// </summary>
    let absorbedInPartByWork = _prefixId.prefix "absorbedInPartByWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been partially incorporated into another entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartExpression</para>
    ///   <para>rdfs:label : Absorbed in part (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartExpression">rdarel:absorbedInPartExpression</a>
    /// </summary>
    let absorbedInPartExpression = _prefixId.prefix "absorbedInPartExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been partially incorporated into another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedInPartWork</para>
    ///   <para>rdfs:label : Absorbed in part (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedInPartWork">rdarel:absorbedInPartWork</a>
    /// </summary>
    let absorbedInPartWork = _prefixId.prefix "absorbedInPartWork"
    /// <summary>
    ///   <para>skos:definition : A work that has been incorporated into another work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : absorbedWork</para>
    ///   <para>rdfs:label : Absorbed (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/absorbedWork">rdarel:absorbedWork</a>
    /// </summary>
    let absorbedWork = _prefixId.prefix "absorbedWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstract</para>
    ///   <para>rdfs:label : Abstract</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstract">rdarel:abstract</a>
    /// </summary>
    let abstract_ = _prefixId.prefix "abstract"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that abbreviates the source entity in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractExpression</para>
    ///   <para>rdfs:label : Abstract (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractExpression">rdarel:abstractExpression</a>
    /// </summary>
    let abstractExpression = _prefixId.prefix "abstractExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOf</para>
    ///   <para>rdfs:label : Abstract of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractOf">rdarel:abstractOf</a>
    /// </summary>
    let abstractOf = _prefixId.prefix "abstractOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOfExpression</para>
    ///   <para>rdfs:label : Abstract of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfExpression">rdarel:abstractOfExpression</a>
    /// </summary>
    let abstractOfExpression = _prefixId.prefix "abstractOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been abstracted, i.e., abbreviated in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractOfWork</para>
    ///   <para>rdfs:label : Abstract of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractOfWork">rdarel:abstractOfWork</a>
    /// </summary>
    let abstractOfWork = _prefixId.prefix "abstractOfWork"
    /// <summary>
    ///   <para>skos:definition : A work that abbreviated the source work in a brief, objective manner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractWork</para>
    ///   <para>rdfs:label : Abstract (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractWork">rdarel:abstractWork</a>
    /// </summary>
    let abstractWork = _prefixId.prefix "abstractWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedIn</para>
    ///   <para>rdfs:label : Abstracted in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractedIn">rdarel:abstractedIn</a>
    /// </summary>
    let abstractedIn = _prefixId.prefix "abstractedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work (an abstracting and indexing service) that abstracts the contents of a source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedInExpression</para>
    ///   <para>rdfs:label : Abstracted in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInExpression">rdarel:abstractedInExpression</a>
    /// </summary>
    let abstractedInExpression = _prefixId.prefix "abstractedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work (an abstracting and indexing service) that abstracts the contents of a source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractedInWork</para>
    ///   <para>rdfs:label : Abstracted in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractedInWork">rdarel:abstractedInWork</a>
    /// </summary>
    let abstractedInWork = _prefixId.prefix "abstractedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsFor</para>
    ///   <para>rdfs:label : Abstracts for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractsFor">rdarel:abstractsFor</a>
    /// </summary>
    let abstractsFor = _prefixId.prefix "abstractsFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a work whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsForExpression</para>
    ///   <para>rdfs:label : Abstracts for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForExpression">rdarel:abstractsForExpression</a>
    /// </summary>
    let abstractsForExpression = _prefixId.prefix "abstractsForExpression"
    /// <summary>
    ///   <para>skos:definition : A work whose contents have been abstracted by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : abstractsForWork</para>
    ///   <para>rdfs:label : Abstracts for (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/abstractsForWork">rdarel:abstractsForWork</a>
    /// </summary>
    let abstractsForWork = _prefixId.prefix "abstractsForWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedBy</para>
    ///   <para>rdfs:label : Accompanied by </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedBy">rdarel:accompaniedBy</a>
    /// </summary>
    let accompaniedBy = _prefixId.prefix "accompaniedBy"
    /// <summary>
    ///   <para>rdfs:label : Accompanied by (Item)</para>
    ///   <para>skos:definition : An item brought together with another item, subsequent to issuance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedByItem</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByItem">rdarel:accompaniedByItem</a>
    /// </summary>
    let accompaniedByItem = _prefixId.prefix "accompaniedByItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation issued with another manifestation, without any relationship to its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedByManifestation</para>
    ///   <para>rdfs:label : Accompanied by (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/accompaniedByManifestation">rdarel:accompaniedByManifestation</a>
    /// </summary>
    let accompaniedByManifestation = _prefixId.prefix "accompaniedByManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingExpression</para>
    ///   <para>rdfs:label : Accompanying expression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingExpression">rdarel:accompanyingExpression</a>
    /// </summary>
    let accompanyingExpression = _prefixId.prefix "accompanyingExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingWork</para>
    ///   <para>rdfs:label : Accompanying work</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/accompanyingWork">rdarel:accompanyingWork</a>
    /// </summary>
    let accompanyingWork = _prefixId.prefix "accompanyingWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOf</para>
    ///   <para>rdfs:label : Adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOf">rdarel:adaptationOf</a>
    /// </summary>
    let adaptationOf = _prefixId.prefix "adaptationOf"
    /// <summary>
    ///   <para>rdfs:label : Adaptation of (Expression)</para>
    ///   <para>skos:definition : An expression of a work that modifies the source entity for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOfExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfExpression">rdarel:adaptationOfExpression</a>
    /// </summary>
    let adaptationOfExpression = _prefixId.prefix "adaptationOfExpression"
    /// <summary>
    ///   <para>rdfs:label : Adaptation of (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptationOfWork</para>
    ///   <para>skos:definition : A work that has been modified for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptationOfWork">rdarel:adaptationOfWork</a>
    /// </summary>
    let adaptationOfWork = _prefixId.prefix "adaptationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAs</para>
    ///   <para>rdfs:label : Adapted as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAs">rdarel:adaptedAs</a>
    /// </summary>
    let adaptedAs = _prefixId.prefix "adaptedAs"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPicture</para>
    ///   <para>rdfs:label : Adapted as a motion picture</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPicture">rdarel:adaptedAsAMotionPicture</a>
    /// </summary>
    let adaptedAsAMotionPicture = _prefixId.prefix "adaptedAsAMotionPicture"

    /// <summary>
    ///   <para>skos:definition : A motion picture based on the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureExpression</para>
    ///   <para>rdfs:label : Adapted as a motion picture (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureExpression">rdarel:adaptedAsAMotionPictureExpression</a>
    /// </summary>
    let adaptedAsAMotionPictureExpression =
        _prefixId.prefix "adaptedAsAMotionPictureExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureScreenplay</para>
    ///   <para>rdfs:label : Adapted as a motion picture screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplay">rdarel:adaptedAsAMotionPictureScreenplay</a>
    /// </summary>
    let adaptedAsAMotionPictureScreenplay =
        _prefixId.prefix "adaptedAsAMotionPictureScreenplay"

    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising the screenplay for a motion picture, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureScreenplayExpression</para>
    ///   <para>rdfs:label : Adapted as a motion picture screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayExpression">rdarel:adaptedAsAMotionPictureScreenplayExpression</a>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayExpression =
        _prefixId.prefix "adaptedAsAMotionPictureScreenplayExpression"

    /// <summary>
    ///   <para>skos:definition : A work comprising the screenplay for a motion picture, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureScreenplayWork</para>
    ///   <para>rdfs:label : Adapted as a motion picture screenplay (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureScreenplayWork">rdarel:adaptedAsAMotionPictureScreenplayWork</a>
    /// </summary>
    let adaptedAsAMotionPictureScreenplayWork =
        _prefixId.prefix "adaptedAsAMotionPictureScreenplayWork"

    /// <summary>
    ///   <para>skos:definition : A motion picture based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAMotionPictureWork</para>
    ///   <para>rdfs:label : Adapted as a motion picture (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAMotionPictureWork">rdarel:adaptedAsAMotionPictureWork</a>
    /// </summary>
    let adaptedAsAMotionPictureWork = _prefixId.prefix "adaptedAsAMotionPictureWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioProgramme</para>
    ///   <para>rdfs:label : Adapted as a radio programme</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgramme">rdarel:adaptedAsARadioProgramme</a>
    /// </summary>
    let adaptedAsARadioProgramme = _prefixId.prefix "adaptedAsARadioProgramme"

    /// <summary>
    ///   <para>skos:definition : A radio programme based on the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioProgrammeExpression</para>
    ///   <para>rdfs:label : Adapted as a radio programme (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeExpression">rdarel:adaptedAsARadioProgrammeExpression</a>
    /// </summary>
    let adaptedAsARadioProgrammeExpression =
        _prefixId.prefix "adaptedAsARadioProgrammeExpression"

    /// <summary>
    ///   <para>skos:definition : A radio programme based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioProgrammeWork</para>
    ///   <para>rdfs:label : Adapted as a radio programme (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioProgrammeWork">rdarel:adaptedAsARadioProgrammeWork</a>
    /// </summary>
    let adaptedAsARadioProgrammeWork = _prefixId.prefix "adaptedAsARadioProgrammeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioScript</para>
    ///   <para>rdfs:label : Adapted as a radio script</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScript">rdarel:adaptedAsARadioScript</a>
    /// </summary>
    let adaptedAsARadioScript = _prefixId.prefix "adaptedAsARadioScript"

    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising the script for a radio programme, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioScriptExpression</para>
    ///   <para>rdfs:label : Adapted as a radio script (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptExpression">rdarel:adaptedAsARadioScriptExpression</a>
    /// </summary>
    let adaptedAsARadioScriptExpression =
        _prefixId.prefix "adaptedAsARadioScriptExpression"

    /// <summary>
    ///   <para>skos:definition : A work comprising the script for a radio programme, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsARadioScriptWork</para>
    ///   <para>rdfs:label : Adapted as a radio script (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsARadioScriptWork">rdarel:adaptedAsARadioScriptWork</a>
    /// </summary>
    let adaptedAsARadioScriptWork = _prefixId.prefix "adaptedAsARadioScriptWork"
    /// <summary>
    ///   <para>rdfs:label : Adapted as a screenplay</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAScreenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplay">rdarel:adaptedAsAScreenplay</a>
    /// </summary>
    let adaptedAsAScreenplay = _prefixId.prefix "adaptedAsAScreenplay"

    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising the screenplay for a motion picture, television programme, or video, based on the source
    /// work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAScreenplayExpression</para>
    ///   <para>rdfs:label : Adapted as a screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayExpression">rdarel:adaptedAsAScreenplayExpression</a>
    /// </summary>
    let adaptedAsAScreenplayExpression =
        _prefixId.prefix "adaptedAsAScreenplayExpression"

    /// <summary>
    ///   <para>rdfs:label : Adapted as a screenplay (Work)</para>
    ///   <para>skos:definition : A work comprising the screenplay for a motion picture, television programme, or video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAScreenplayWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAScreenplayWork">rdarel:adaptedAsAScreenplayWork</a>
    /// </summary>
    let adaptedAsAScreenplayWork = _prefixId.prefix "adaptedAsAScreenplayWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionProgramme</para>
    ///   <para>rdfs:label : Adapted as a television programme</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgramme">rdarel:adaptedAsATelevisionProgramme</a>
    /// </summary>
    let adaptedAsATelevisionProgramme = _prefixId.prefix "adaptedAsATelevisionProgramme"

    /// <summary>
    ///   <para>skos:definition : A television programme based on the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionProgrammeExpression</para>
    ///   <para>rdfs:label : Adapted as a television programme (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeExpression">rdarel:adaptedAsATelevisionProgrammeExpression</a>
    /// </summary>
    let adaptedAsATelevisionProgrammeExpression =
        _prefixId.prefix "adaptedAsATelevisionProgrammeExpression"

    /// <summary>
    ///   <para>skos:definition : A television programme based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionProgrammeWork</para>
    ///   <para>rdfs:label : Adapted as a television programme (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionProgrammeWork">rdarel:adaptedAsATelevisionProgrammeWork</a>
    /// </summary>
    let adaptedAsATelevisionProgrammeWork =
        _prefixId.prefix "adaptedAsATelevisionProgrammeWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionScreenplay</para>
    ///   <para>rdfs:label : Adapted as a television screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplay">rdarel:adaptedAsATelevisionScreenplay</a>
    /// </summary>
    let adaptedAsATelevisionScreenplay =
        _prefixId.prefix "adaptedAsATelevisionScreenplay"

    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising the screenplay for a television programme, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionScreenplayExpression</para>
    ///   <para>rdfs:label : Adapted as a television screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayExpression">rdarel:adaptedAsATelevisionScreenplayExpression</a>
    /// </summary>
    let adaptedAsATelevisionScreenplayExpression =
        _prefixId.prefix "adaptedAsATelevisionScreenplayExpression"

    /// <summary>
    ///   <para>skos:definition : A work comprising the screenplay for a television programme, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsATelevisionScreenplayWork</para>
    ///   <para>rdfs:label : Adapted as a television screenplay (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsATelevisionScreenplayWork">rdarel:adaptedAsATelevisionScreenplayWork</a>
    /// </summary>
    let adaptedAsATelevisionScreenplayWork =
        _prefixId.prefix "adaptedAsATelevisionScreenplayWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideo</para>
    ///   <para>rdfs:label : Adapted as a video</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideo">rdarel:adaptedAsAVideo</a>
    /// </summary>
    let adaptedAsAVideo = _prefixId.prefix "adaptedAsAVideo"
    /// <summary>
    ///   <para>skos:definition : A video based on the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoExpression</para>
    ///   <para>rdfs:label : Adapted as a video (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoExpression">rdarel:adaptedAsAVideoExpression</a>
    /// </summary>
    let adaptedAsAVideoExpression = _prefixId.prefix "adaptedAsAVideoExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoScreenplay</para>
    ///   <para>rdfs:label : Adapted as a video screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplay">rdarel:adaptedAsAVideoScreenplay</a>
    /// </summary>
    let adaptedAsAVideoScreenplay = _prefixId.prefix "adaptedAsAVideoScreenplay"

    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising the screenplay for a video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoScreenplayExpression</para>
    ///   <para>rdfs:label : Adapted as a video screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayExpression">rdarel:adaptedAsAVideoScreenplayExpression</a>
    /// </summary>
    let adaptedAsAVideoScreenplayExpression =
        _prefixId.prefix "adaptedAsAVideoScreenplayExpression"

    /// <summary>
    ///   <para>skos:definition : A work comprising the screenplay for a video, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoScreenplayWork</para>
    ///   <para>rdfs:label : Adapted as a video screenplay (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoScreenplayWork">rdarel:adaptedAsAVideoScreenplayWork</a>
    /// </summary>
    let adaptedAsAVideoScreenplayWork = _prefixId.prefix "adaptedAsAVideoScreenplayWork"
    /// <summary>
    ///   <para>skos:definition : A video based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsAVideoWork</para>
    ///   <para>rdfs:label : Adapted as a video (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsAVideoWork">rdarel:adaptedAsAVideoWork</a>
    /// </summary>
    let adaptedAsAVideoWork = _prefixId.prefix "adaptedAsAVideoWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that modifies the source entity for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>rdfs:label : Adapted as (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsExpression">rdarel:adaptedAsExpression</a>
    /// </summary>
    let adaptedAsExpression = _prefixId.prefix "adaptedAsExpression"
    /// <summary>
    ///   <para>rdfs:label : Adapted as (Work)</para>
    ///   <para>skos:definition : A work that modifies the source work for a purpose, use, or medium other than that for which it was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : adaptedAsWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/adaptedAsWork">rdarel:adaptedAsWork</a>
    /// </summary>
    let adaptedAsWork = _prefixId.prefix "adaptedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addenda</para>
    ///   <para>rdfs:label : Addenda</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addenda">rdarel:addenda</a>
    /// </summary>
    let addenda = _prefixId.prefix "addenda"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaExpression</para>
    ///   <para>rdfs:label : Addenda (Expression)</para>
    ///   <para>skos:definition : An expression of a work that consists of brief additional material, less extensive than a supplement, which is essential to the completeness of the text of the predominant work and is usually added to the end of the content, but may also be issued separately.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addendaExpression">rdarel:addendaExpression</a>
    /// </summary>
    let addendaExpression = _prefixId.prefix "addendaExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaTo</para>
    ///   <para>rdfs:label : Addenda to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addendaTo">rdarel:addendaTo</a>
    /// </summary>
    let addendaTo = _prefixId.prefix "addendaTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work to which is added, usually at the end of the content, but sometimes separately from it, brief additional material, less extensive than a supplement, which is essential to the completeness of the content of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaToExpression</para>
    ///   <para>rdfs:label : Addenda to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addendaToExpression">rdarel:addendaToExpression</a>
    /// </summary>
    let addendaToExpression = _prefixId.prefix "addendaToExpression"
    /// <summary>
    ///   <para>skos:definition : A work to which is added, usually at the end of the work, but sometimes separately from it, brief additional material, less extensive than a supplement, which is essential to the completeness of the content of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaToWork</para>
    ///   <para>rdfs:label : Addenda to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addendaToWork">rdarel:addendaToWork</a>
    /// </summary>
    let addendaToWork = _prefixId.prefix "addendaToWork"
    /// <summary>
    ///   <para>skos:definition : A work that consists of brief additional material, less extensive than a supplement, which is essential to the completeness of the text of the predominant work and is usually added to the end of the content, but may also be issued separately.</para>
    ///   <para>rdfs:label : Addenda (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : addendaWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/addendaWork">rdarel:addendaWork</a>
    /// </summary>
    let addendaWork = _prefixId.prefix "addendaWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alsoIssuedAs</para>
    ///   <para>rdfs:label : Also issued as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAs">rdarel:alsoIssuedAs</a>
    /// </summary>
    let alsoIssuedAs = _prefixId.prefix "alsoIssuedAs"
    /// <summary>
    ///   <para>skos:definition : A manifestation issued in a different format embodying the same expression of a work as the resource being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : alsoIssuedAsManifestation</para>
    ///   <para>rdfs:label : Also issued as (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/alsoIssuedAsManifestation">rdarel:alsoIssuedAsManifestation</a>
    /// </summary>
    let alsoIssuedAsManifestation = _prefixId.prefix "alsoIssuedAsManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedIn</para>
    ///   <para>rdfs:label : Analysed in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysedIn">rdarel:analysedIn</a>
    /// </summary>
    let analysedIn = _prefixId.prefix "analysedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that examines the described entity to identity its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInExpression</para>
    ///   <para>rdfs:label : Analysed in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysedInExpression">rdarel:analysedInExpression</a>
    /// </summary>
    let analysedInExpression = _prefixId.prefix "analysedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work that examines the source work to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInWork</para>
    ///   <para>rdfs:label : Analysed in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysedInWork">rdarel:analysedInWork</a>
    /// </summary>
    let analysedInWork = _prefixId.prefix "analysedInWork"
    /// <summary>
    ///   <para>rdfs:label : Analysis of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOf</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysisOf">rdarel:analysisOf</a>
    /// </summary>
    let analysisOf = _prefixId.prefix "analysisOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfExpression</para>
    ///   <para>rdfs:label : Analysis of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfExpression">rdarel:analysisOfExpression</a>
    /// </summary>
    let analysisOfExpression = _prefixId.prefix "analysisOfExpression"
    /// <summary>
    ///   <para>skos:definition : An item that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfItem</para>
    ///   <para>rdfs:label : Analysis of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfItem">rdarel:analysisOfItem</a>
    /// </summary>
    let analysisOfItem = _prefixId.prefix "analysisOfItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfManifestation</para>
    ///   <para>rdfs:label : Analysis of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfManifestation">rdarel:analysisOfManifestation</a>
    /// </summary>
    let analysisOfManifestation = _prefixId.prefix "analysisOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A work that has been examined to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysisOfWork</para>
    ///   <para>rdfs:label : Analysis of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/analysisOfWork">rdarel:analysisOfWork</a>
    /// </summary>
    let analysisOfWork = _prefixId.prefix "analysisOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendix</para>
    ///   <para>rdfs:label : Appendix</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendix">rdarel:appendix</a>
    /// </summary>
    let appendix = _prefixId.prefix "appendix"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that forms an augmenting part of another work which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; may be material which comes at the end of the content of the predominant work, or may be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixExpression</para>
    ///   <para>rdfs:label : Appendix (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendixExpression">rdarel:appendixExpression</a>
    /// </summary>
    let appendixExpression = _prefixId.prefix "appendixExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixTo</para>
    ///   <para>rdfs:label : Appendix to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendixTo">rdarel:appendixTo</a>
    /// </summary>
    let appendixTo = _prefixId.prefix "appendixTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a predominant work that is augmented by another work that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting work may come at the end of the content, or may be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixToExpression</para>
    ///   <para>rdfs:label : Appendix to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendixToExpression">rdarel:appendixToExpression</a>
    /// </summary>
    let appendixToExpression = _prefixId.prefix "appendixToExpression"
    /// <summary>
    ///   <para>skos:definition : A work that is augmented by another work that consists of material that is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; the augmenting work may come at the end of the content, or may be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixToWork</para>
    ///   <para>rdfs:label : Appendix to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendixToWork">rdarel:appendixToWork</a>
    /// </summary>
    let appendixToWork = _prefixId.prefix "appendixToWork"
    /// <summary>
    ///   <para>skos:definition : A work that forms an augmenting part of another work which is not essential to the completeness of the content, such as a list of references, statistical tables, and explanatory matter; may be material which comes at the end of the content of the predominant work, or may be issued separately.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : appendixWork</para>
    ///   <para>rdfs:label : Appendix (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/appendixWork">rdarel:appendixWork</a>
    /// </summary>
    let appendixWork = _prefixId.prefix "appendixWork"
    /// <summary>
    ///   <para>rdfs:label : Augmentation of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOf</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOf">rdarel:augmentationOf</a>
    /// </summary>
    let augmentationOf = _prefixId.prefix "augmentationOf"
    /// <summary>
    ///   <para>skos:definition : An expression whose content is added to by another entity.</para>
    ///   <para>rdfs:label : Augmentation of (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOfExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfExpression">rdarel:augmentationOfExpression</a>
    /// </summary>
    let augmentationOfExpression = _prefixId.prefix "augmentationOfExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentationOfWork</para>
    ///   <para>skos:definition : A work whose content is added to by another work.</para>
    ///   <para>rdfs:label : Augmentation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentationOfWork">rdarel:augmentationOfWork</a>
    /// </summary>
    let augmentationOfWork = _prefixId.prefix "augmentationOfWork"
    /// <summary>
    ///   <para>rdfs:label : Augmented by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedBy</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentedBy">rdarel:augmentedBy</a>
    /// </summary>
    let augmentedBy = _prefixId.prefix "augmentedBy"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedByExpression</para>
    ///   <para>skos:definition : An expression of a work that adds to the content of a predominant entity.</para>
    ///   <para>rdfs:label : Augmented by (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByExpression">rdarel:augmentedByExpression</a>
    /// </summary>
    let augmentedByExpression = _prefixId.prefix "augmentedByExpression"
    /// <summary>
    ///   <para>skos:definition : A work that adds to the content of a predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : augmentedByWork</para>
    ///   <para>rdfs:label : Augmented by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/augmentedByWork">rdarel:augmentedByWork</a>
    /// </summary>
    let augmentedByWork = _prefixId.prefix "augmentedByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOn</para>
    ///   <para>rdfs:label : Based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/basedOn">rdarel:basedOn</a>
    /// </summary>
    let basedOn = _prefixId.prefix "basedOn"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOnExpression</para>
    ///   <para>skos:definition : An expression used as the basis for a derivative entity.</para>
    ///   <para>rdfs:label : Based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/basedOnExpression">rdarel:basedOnExpression</a>
    /// </summary>
    let basedOnExpression = _prefixId.prefix "basedOnExpression"
    /// <summary>
    ///   <para>rdfs:label : Based on (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basedOnWork</para>
    ///   <para>skos:definition : A work used as the source for a derivative work.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/basedOnWork">rdarel:basedOnWork</a>
    /// </summary>
    let basedOnWork = _prefixId.prefix "basedOnWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basisForLibretto</para>
    ///   <para>rdfs:label : Basis for libretto</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibretto">rdarel:basisForLibretto</a>
    /// </summary>
    let basisForLibretto = _prefixId.prefix "basisForLibretto"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that comprises the text of an opera or other work for the musical stage, or an oratorio, based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : basisForLibrettoExpression</para>
    ///   <para>rdfs:label : Basis for libretto (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/basisForLibrettoExpression">rdarel:basisForLibrettoExpression</a>
    /// </summary>
    let basisForLibrettoExpression = _prefixId.prefix "basisForLibrettoExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : boundWith</para>
    ///   <para>rdfs:label : Bound with</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/boundWith">rdarel:boundWith</a>
    /// </summary>
    let boundWith = _prefixId.prefix "boundWith"
    /// <summary>
    ///   <para>skos:definition : An item that has been bound within the same binding as the item being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : boundWithItem</para>
    ///   <para>rdfs:label : Bound with (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/boundWithItem">rdarel:boundWithItem</a>
    /// </summary>
    let boundWithItem = _prefixId.prefix "boundWithItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenza</para>
    ///   <para>rdfs:label : Cadenza</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenza">rdarel:cadenza</a>
    /// </summary>
    let cadenza = _prefixId.prefix "cadenza"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedFor</para>
    ///   <para>rdfs:label : Cadenza composed for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedFor">rdarel:cadenzaComposedFor</a>
    /// </summary>
    let cadenzaComposedFor = _prefixId.prefix "cadenzaComposedFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a musical work such as a concerto for which an ornamental passage for a soloist has been composed, either by the
    /// same or a different composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedForExpression</para>
    ///   <para>rdfs:label : Cadenza composed for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForExpression">rdarel:cadenzaComposedForExpression</a>
    /// </summary>
    let cadenzaComposedForExpression = _prefixId.prefix "cadenzaComposedForExpression"
    /// <summary>
    ///   <para>skos:definition : A musical work such as a concerto that contains an ornamental passage for a soloist, either by the composer of the larger work or by another composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaComposedForWork</para>
    ///   <para>rdfs:label : Cadenza composed for (work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaComposedForWork">rdarel:cadenzaComposedForWork</a>
    /// </summary>
    let cadenzaComposedForWork = _prefixId.prefix "cadenzaComposedForWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a musical work comprising an ornamental passage for a soloist, added to a musical work such as a concerto, either by the same or a different composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaExpression</para>
    ///   <para>rdfs:label : Cadenza (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaExpression">rdarel:cadenzaExpression</a>
    /// </summary>
    let cadenzaExpression = _prefixId.prefix "cadenzaExpression"
    /// <summary>
    ///   <para>skos:definition : A musical work comprising an ornamental passage for a soloist, added to the musical work such as a concerto, either by the composer of the larger work or by another composer.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : cadenzaWork</para>
    ///   <para>rdfs:label : Cadenza (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/cadenzaWork">rdarel:cadenzaWork</a>
    /// </summary>
    let cadenzaWork = _prefixId.prefix "cadenzaWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogue</para>
    ///   <para>rdfs:label : Catalogue</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogue">rdarel:catalogue</a>
    /// </summary>
    let catalogue = _prefixId.prefix "catalogue"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that comprises a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueExpression</para>
    ///   <para>rdfs:label : Catalogue (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogueExpression">rdarel:catalogueExpression</a>
    /// </summary>
    let catalogueExpression = _prefixId.prefix "catalogueExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOf</para>
    ///   <para>rdfs:label : Catalogue of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOf">rdarel:catalogueOf</a>
    /// </summary>
    let catalogueOf = _prefixId.prefix "catalogueOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOfExpression</para>
    ///   <para>rdfs:label : Catalogue of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfExpression">rdarel:catalogueOfExpression</a>
    /// </summary>
    let catalogueOfExpression = _prefixId.prefix "catalogueOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueOfWork</para>
    ///   <para>rdfs:label : Catalogue of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogueOfWork">rdarel:catalogueOfWork</a>
    /// </summary>
    let catalogueOfWork = _prefixId.prefix "catalogueOfWork"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a catalogue, i.e., a complete enumeration of items arranged systematically.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : catalogueWork</para>
    ///   <para>rdfs:label : Catalogue (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/catalogueWork">rdarel:catalogueWork</a>
    /// </summary>
    let catalogueWork = _prefixId.prefix "catalogueWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreography</para>
    ///   <para>rdfs:label : Choreography</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreography">rdarel:choreography</a>
    /// </summary>
    let choreography = _prefixId.prefix "choreography"
    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising dance based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyExpression</para>
    ///   <para>rdfs:label : Choreography (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreographyExpression">rdarel:choreographyExpression</a>
    /// </summary>
    let choreographyExpression = _prefixId.prefix "choreographyExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyFor</para>
    ///   <para>rdfs:label : Choreography for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreographyFor">rdarel:choreographyFor</a>
    /// </summary>
    let choreographyFor = _prefixId.prefix "choreographyFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a derivative work comprising dance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyForExpression</para>
    ///   <para>rdfs:label : Choreography for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForExpression">rdarel:choreographyForExpression</a>
    /// </summary>
    let choreographyForExpression = _prefixId.prefix "choreographyForExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a derivative work comprising dance.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyForWork</para>
    ///   <para>rdfs:label : Choreography for (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreographyForWork">rdarel:choreographyForWork</a>
    /// </summary>
    let choreographyForWork = _prefixId.prefix "choreographyForWork"
    /// <summary>
    ///   <para>skos:definition : A work comprising dance based on the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : choreographyWork</para>
    ///   <para>rdfs:label : Choreography (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/choreographyWork">rdarel:choreographyWork</a>
    /// </summary>
    let choreographyWork = _prefixId.prefix "choreographyWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryIn</para>
    ///   <para>rdfs:label : Commentary in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryIn">rdarel:commentaryIn</a>
    /// </summary>
    let commentaryIn = _prefixId.prefix "commentaryIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that contains a set of explanatory or critical notes on the described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInExpression</para>
    ///   <para>rdfs:label : Commentary in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInExpression">rdarel:commentaryInExpression</a>
    /// </summary>
    let commentaryInExpression = _prefixId.prefix "commentaryInExpression"
    /// <summary>
    ///   <para>skos:definition : A work that contains a set of explanatory or critical notes on the described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInWork</para>
    ///   <para>rdfs:label : Commentary in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryInWork">rdarel:commentaryInWork</a>
    /// </summary>
    let commentaryInWork = _prefixId.prefix "commentaryInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOn</para>
    ///   <para>rdfs:label : Commentary on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOn">rdarel:commentaryOn</a>
    /// </summary>
    let commentaryOn = _prefixId.prefix "commentaryOn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnExpression</para>
    ///   <para>rdfs:label : Commentary on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnExpression">rdarel:commentaryOnExpression</a>
    /// </summary>
    let commentaryOnExpression = _prefixId.prefix "commentaryOnExpression"
    /// <summary>
    ///   <para>skos:definition : An item used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnItem</para>
    ///   <para>rdfs:label : Commentary on (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnItem">rdarel:commentaryOnItem</a>
    /// </summary>
    let commentaryOnItem = _prefixId.prefix "commentaryOnItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnManifestation</para>
    ///   <para>rdfs:label : Commentary on (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnManifestation">rdarel:commentaryOnManifestation</a>
    /// </summary>
    let commentaryOnManifestation = _prefixId.prefix "commentaryOnManifestation"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a set of explanatory or critical notes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryOnWork</para>
    ///   <para>rdfs:label : Commentary on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/commentaryOnWork">rdarel:commentaryOnWork</a>
    /// </summary>
    let commentaryOnWork = _prefixId.prefix "commentaryOnWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedBy</para>
    ///   <para>rdfs:label : Complemented by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/complementedBy">rdarel:complementedBy</a>
    /// </summary>
    let complementedBy = _prefixId.prefix "complementedBy"
    /// <summary>
    ///   <para>skos:definition : An expression paired with another entity without either entity being considered to predominate.</para>
    ///   <para>rdfs:label : Complemented by (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedByExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/complementedByExpression">rdarel:complementedByExpression</a>
    /// </summary>
    let complementedByExpression = _prefixId.prefix "complementedByExpression"
    /// <summary>
    ///   <para>skos:definition : A work paired with another entity without either entity being considered to predominate.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementedByWork</para>
    ///   <para>rdfs:label : Complemented by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/complementedByWork">rdarel:complementedByWork</a>
    /// </summary>
    let complementedByWork = _prefixId.prefix "complementedByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordance</para>
    ///   <para>rdfs:label : Concordance</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordance">rdarel:concordance</a>
    /// </summary>
    let concordance = _prefixId.prefix "concordance"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that comprises an index of all the words in the predominant entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceExpression</para>
    ///   <para>rdfs:label : Concordance (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordanceExpression">rdarel:concordanceExpression</a>
    /// </summary>
    let concordanceExpression = _prefixId.prefix "concordanceExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceTo</para>
    ///   <para>rdfs:label : Concordance to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordanceTo">rdarel:concordanceTo</a>
    /// </summary>
    let concordanceTo = _prefixId.prefix "concordanceTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a concordance, i.e., an index of all the words in the predominant entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceToExpression</para>
    ///   <para>rdfs:label : Concordance to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToExpression">rdarel:concordanceToExpression</a>
    /// </summary>
    let concordanceToExpression = _prefixId.prefix "concordanceToExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a concordance, i.e. an index of all the words in the augmented work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceToWork</para>
    ///   <para>rdfs:label : Concordance to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordanceToWork">rdarel:concordanceToWork</a>
    /// </summary>
    let concordanceToWork = _prefixId.prefix "concordanceToWork"
    /// <summary>
    ///   <para>skos:definition : A work that comprises an index of all the words in the predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : concordanceWork</para>
    ///   <para>rdfs:label : Concordance (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/concordanceWork">rdarel:concordanceWork</a>
    /// </summary>
    let concordanceWork = _prefixId.prefix "concordanceWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedIn</para>
    ///   <para>rdfs:label : Contained in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containedIn">rdarel:containedIn</a>
    /// </summary>
    let containedIn = _prefixId.prefix "containedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a larger work of which a part is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInExpression</para>
    ///   <para>rdfs:label : Contained in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containedInExpression">rdarel:containedInExpression</a>
    /// </summary>
    let containedInExpression = _prefixId.prefix "containedInExpression"
    /// <summary>
    ///   <para>skos:definition : A larger item of which a part is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInItem</para>
    ///   <para>rdfs:label : Contained in (item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containedInItem">rdarel:containedInItem</a>
    /// </summary>
    let containedInItem = _prefixId.prefix "containedInItem"
    /// <summary>
    ///   <para>skos:definition : A larger manifestation of which a part is a discrete component.</para>
    ///   <para>rdfs:label : Contained in (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInManifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containedInManifestation">rdarel:containedInManifestation</a>
    /// </summary>
    let containedInManifestation = _prefixId.prefix "containedInManifestation"
    /// <summary>
    ///   <para>skos:definition : A larger work of which a part is a discrete component.</para>
    ///   <para>rdfs:label : Contained in (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containedInWork">rdarel:containedInWork</a>
    /// </summary>
    let containedInWork = _prefixId.prefix "containedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : contains</para>
    ///   <para>rdfs:label : Contains</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/contains">rdarel:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containsExpression</para>
    ///   <para>skos:definition : An expression of a work that is a discrete component of a larger entity.</para>
    ///   <para>rdfs:label : Contains (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containsExpression">rdarel:containsExpression</a>
    /// </summary>
    let containsExpression = _prefixId.prefix "containsExpression"
    /// <summary>
    ///   <para>skos:definition : An item that is a discrete component of a larger item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containsItem</para>
    ///   <para>rdfs:label : Contains (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containsItem">rdarel:containsItem</a>
    /// </summary>
    let containsItem = _prefixId.prefix "containsItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation that is a discrete component of a larger entity.</para>
    ///   <para>rdfs:label : Contains (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containsManifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containsManifestation">rdarel:containsManifestation</a>
    /// </summary>
    let containsManifestation = _prefixId.prefix "containsManifestation"
    /// <summary>
    ///   <para>rdfs:label : Contains (Work)</para>
    ///   <para>skos:definition : A work that is a discrete component of a larger work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containsWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/containsWork">rdarel:containsWork</a>
    /// </summary>
    let containsWork = _prefixId.prefix "containsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedBy</para>
    ///   <para>rdfs:label : Continued by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedBy">rdarel:continuedBy</a>
    /// </summary>
    let continuedBy = _prefixId.prefix "continuedBy"
    /// <summary>
    ///   <para>rdfs:label : Continued by (Expression)</para>
    ///   <para>skos:definition : An expression of a work whose content separated from an earlier entity to form a new entity. </para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedByExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedByExpression">rdarel:continuedByExpression</a>
    /// </summary>
    let continuedByExpression = _prefixId.prefix "continuedByExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedByWork</para>
    ///   <para>rdfs:label : Continued by (Work)</para>
    ///   <para>skos:definition : A work whose content continues an earlier work under a new title. </para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedByWork">rdarel:continuedByWork</a>
    /// </summary>
    let continuedByWork = _prefixId.prefix "continuedByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartBy</para>
    ///   <para>rdfs:label : Continued in part by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartBy">rdarel:continuedInPartBy</a>
    /// </summary>
    let continuedInPartBy = _prefixId.prefix "continuedInPartBy"
    /// <summary>
    ///   <para>skos:definition : An expression of a work part of whose content separated from an earlier entity to form a new entity. </para>
    ///   <para>rdfs:label : Continued in part by (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartByExpression</para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByExpression">rdarel:continuedInPartByExpression</a>
    /// </summary>
    let continuedInPartByExpression = _prefixId.prefix "continuedInPartByExpression"
    /// <summary>
    ///   <para>rdfs:label : Continued in part by (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuedInPartByWork</para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <para>skos:definition : A work part of whose content separated from an earlier work to form a new work. </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuedInPartByWork">rdarel:continuedInPartByWork</a>
    /// </summary>
    let continuedInPartByWork = _prefixId.prefix "continuedInPartByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continues</para>
    ///   <para>rdfs:label : Continues</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continues">rdarel:continues</a>
    /// </summary>
    let continues = _prefixId.prefix "continues"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuesExpression</para>
    ///   <para>rdfs:label : Continues (Expression)</para>
    ///   <para>skos:definition : An expression of a work that is continued by the content of a later entity under a new title. </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuesExpression">rdarel:continuesExpression</a>
    /// </summary>
    let continuesExpression = _prefixId.prefix "continuesExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuesInPart</para>
    ///   <para>rdfs:label : Continues in part</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPart">rdarel:continuesInPart</a>
    /// </summary>
    let continuesInPart = _prefixId.prefix "continuesInPart"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <para>rdfs:label : Continues in part (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuesInPartExpression</para>
    ///   <para>skos:definition : An expression of a work that split into two or more separate entities with new titles. </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartExpression">rdarel:continuesInPartExpression</a>
    /// </summary>
    let continuesInPartExpression = _prefixId.prefix "continuesInPartExpression"
    /// <summary>
    ///   <para>skos:definition : A work that split into two or more separate works with new titles. </para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuesInPartWork</para>
    ///   <para>rdfs:label : Continues in part (Work)</para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuesInPartWork">rdarel:continuesInPartWork</a>
    /// </summary>
    let continuesInPartWork = _prefixId.prefix "continuesInPartWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : continuesWork</para>
    ///   <para>rdfs:comment : Apply generally to serials.</para>
    ///   <para>skos:definition : A work that is continued by the content of a later work under a new title. </para>
    ///   <para>rdfs:label : Continues (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/continuesWork">rdarel:continuesWork</a>
    /// </summary>
    let continuesWork = _prefixId.prefix "continuesWork"
    /// <summary>
    ///   <para>rdfs:label : Critique of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOf</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOf">rdarel:critiqueOf</a>
    /// </summary>
    let critiqueOf = _prefixId.prefix "critiqueOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfExpression</para>
    ///   <para>rdfs:label : Critique of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfExpression">rdarel:critiqueOfExpression</a>
    /// </summary>
    let critiqueOfExpression = _prefixId.prefix "critiqueOfExpression"
    /// <summary>
    ///   <para>skos:definition : An item used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfItem</para>
    ///   <para>rdfs:label : Critique of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfItem">rdarel:critiqueOfItem</a>
    /// </summary>
    let critiqueOfItem = _prefixId.prefix "critiqueOfItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfManifestation</para>
    ///   <para>rdfs:label : Critique of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfManifestation">rdarel:critiqueOfManifestation</a>
    /// </summary>
    let critiqueOfManifestation = _prefixId.prefix "critiqueOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a critical evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiqueOfWork</para>
    ///   <para>rdfs:label : Critique of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiqueOfWork">rdarel:critiqueOfWork</a>
    /// </summary>
    let critiqueOfWork = _prefixId.prefix "critiqueOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedIn</para>
    ///   <para>rdfs:label : Critiqued in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiquedIn">rdarel:critiquedIn</a>
    /// </summary>
    let critiquedIn = _prefixId.prefix "critiquedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work contains a critical evaluation of the described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInExpression</para>
    ///   <para>rdfs:label : Critiqued in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInExpression">rdarel:critiquedInExpression</a>
    /// </summary>
    let critiquedInExpression = _prefixId.prefix "critiquedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work that contains a critical evaluation of the described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInWork</para>
    ///   <para>rdfs:label : Critiqued in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/critiquedInWork">rdarel:critiquedInWork</a>
    /// </summary>
    let critiquedInWork = _prefixId.prefix "critiquedInWork"
    let derivativeExpression = _prefixId.prefix "derivativeExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeRelationship</para>
    ///   <para>rdfs:label : Derivative relationship</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationship">rdarel:derivativeRelationship</a>
    /// </summary>
    let derivativeRelationship = _prefixId.prefix "derivativeRelationship"

    /// <summary>
    ///   <para>skos:definition : An expression that is a modification of a source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeRelationshipExpression</para>
    ///   <para>rdfs:label : Derivative relationship (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipExpression">rdarel:derivativeRelationshipExpression</a>
    /// </summary>
    let derivativeRelationshipExpression =
        _prefixId.prefix "derivativeRelationshipExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : derivativeRelationshipWork</para>
    ///   <para>rdfs:label : Derivative relationship (Work)</para>
    ///   <para>skos:definition : A work that is a modification of a source work.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/derivativeRelationshipWork">rdarel:derivativeRelationshipWork</a>
    /// </summary>
    let derivativeRelationshipWork = _prefixId.prefix "derivativeRelationshipWork"
    let derivativeRelationships = _prefixId.prefix "derivativeRelationships"
    let derivativeWork = _prefixId.prefix "derivativeWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedIn</para>
    ///   <para>rdfs:label : Described in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/describedIn">rdarel:describedIn</a>
    /// </summary>
    let describedIn = _prefixId.prefix "describedIn"
    /// <summary>
    ///   <para>skos:definition : An expression that describes a described entity.</para>
    ///   <para>rdfs:label : Described in (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/describedInExpression">rdarel:describedInExpression</a>
    /// </summary>
    let describedInExpression = _prefixId.prefix "describedInExpression"
    /// <summary>
    ///   <para>rdfs:label : Described in (Work)</para>
    ///   <para>skos:definition : A work that describes a described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/describedInWork">rdarel:describedInWork</a>
    /// </summary>
    let describedInWork = _prefixId.prefix "describedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOf</para>
    ///   <para>rdfs:label : Description of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOf">rdarel:descriptionOf</a>
    /// </summary>
    let descriptionOf = _prefixId.prefix "descriptionOf"
    /// <summary>
    ///   <para>rdfs:label : Description of (Expression)</para>
    ///   <para>skos:definition : An expression described by a describing entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfExpression">rdarel:descriptionOfExpression</a>
    /// </summary>
    let descriptionOfExpression = _prefixId.prefix "descriptionOfExpression"
    /// <summary>
    ///   <para>skos:definition : An item described by a describing entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfItem</para>
    ///   <para>rdfs:label : Description of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfItem">rdarel:descriptionOfItem</a>
    /// </summary>
    let descriptionOfItem = _prefixId.prefix "descriptionOfItem"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfManifestation</para>
    ///   <para>skos:definition : A manifestation described by a describing entity.</para>
    ///   <para>rdfs:label : Description of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfManifestation">rdarel:descriptionOfManifestation</a>
    /// </summary>
    let descriptionOfManifestation = _prefixId.prefix "descriptionOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A work described by a describing entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptionOfWork</para>
    ///   <para>rdfs:label : Description of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptionOfWork">rdarel:descriptionOfWork</a>
    /// </summary>
    let descriptionOfWork = _prefixId.prefix "descriptionOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveRelationships</para>
    ///   <para>rdfs:label : Descriptive relationships</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationships">rdarel:descriptiveRelationships</a>
    /// </summary>
    let descriptiveRelationships = _prefixId.prefix "descriptiveRelationships"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveRelationshipsExpression</para>
    ///   <para>rdfs:label : Descriptive relationships (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsExpression">rdarel:descriptiveRelationshipsExpression</a>
    /// </summary>
    let descriptiveRelationshipsExpression =
        _prefixId.prefix "descriptiveRelationshipsExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveRelationshipsItem</para>
    ///   <para>rdfs:label : Descriptive relationships (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsItem">rdarel:descriptiveRelationshipsItem</a>
    /// </summary>
    let descriptiveRelationshipsItem = _prefixId.prefix "descriptiveRelationshipsItem"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveRelationshipsManifestation</para>
    ///   <para>rdfs:label : Descriptive relationships (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsManifestation">rdarel:descriptiveRelationshipsManifestation</a>
    /// </summary>
    let descriptiveRelationshipsManifestation =
        _prefixId.prefix "descriptiveRelationshipsManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : descriptiveRelationshipsWork</para>
    ///   <para>rdfs:label : Descriptive relationships (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/descriptiveRelationshipsWork">rdarel:descriptiveRelationshipsWork</a>
    /// </summary>
    let descriptiveRelationshipsWork = _prefixId.prefix "descriptiveRelationshipsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digest</para>
    ///   <para>rdfs:label : Digest</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digest">rdarel:digest</a>
    /// </summary>
    let digest = _prefixId.prefix "digest"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that systematically, comprehensively condenses the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestExpression</para>
    ///   <para>rdfs:label : Digest (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digestExpression">rdarel:digestExpression</a>
    /// </summary>
    let digestExpression = _prefixId.prefix "digestExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOf</para>
    ///   <para>rdfs:label : Digest of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digestOf">rdarel:digestOf</a>
    /// </summary>
    let digestOf = _prefixId.prefix "digestOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been digested, i.e., systematically, comprehensively condensed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOfExpression</para>
    ///   <para>rdfs:label : Digest of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digestOfExpression">rdarel:digestOfExpression</a>
    /// </summary>
    let digestOfExpression = _prefixId.prefix "digestOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been digested, i.e., systematically, comprehensively condensed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestOfWork</para>
    ///   <para>rdfs:label : Digest of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digestOfWork">rdarel:digestOfWork</a>
    /// </summary>
    let digestOfWork = _prefixId.prefix "digestOfWork"
    /// <summary>
    ///   <para>skos:definition : A work that systematically, comprehensively condenses the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digestWork</para>
    ///   <para>rdfs:label : Digest (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digestWork">rdarel:digestWork</a>
    /// </summary>
    let digestWork = _prefixId.prefix "digestWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransfer</para>
    ///   <para>rdfs:label : Digital transfer</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransfer">rdarel:digitalTransfer</a>
    /// </summary>
    let digitalTransfer = _prefixId.prefix "digitalTransfer"
    /// <summary>
    ///   <para>skos:definition : A manifestation transferred from one digital format to another.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferManifestation</para>
    ///   <para>rdfs:label : Digital transfer (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferManifestation">rdarel:digitalTransferManifestation</a>
    /// </summary>
    let digitalTransferManifestation = _prefixId.prefix "digitalTransferManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOf</para>
    ///   <para>rdfs:label : Digital transfer of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOf">rdarel:digitalTransferOf</a>
    /// </summary>
    let digitalTransferOf = _prefixId.prefix "digitalTransferOf"
    /// <summary>
    ///   <para>skos:definition : An item transferred from one digital format to another.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOfItem</para>
    ///   <para>rdfs:label : Digital transfer of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfItem">rdarel:digitalTransferOfItem</a>
    /// </summary>
    let digitalTransferOfItem = _prefixId.prefix "digitalTransferOfItem"

    /// <summary>
    ///   <para>skos:definition : A manifestation transferred from one digital format to another.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOfManifestation</para>
    ///   <para>rdfs:label : Digital transfer of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/digitalTransferOfManifestation">rdarel:digitalTransferOfManifestation</a>
    /// </summary>
    let digitalTransferOfManifestation =
        _prefixId.prefix "digitalTransferOfManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOf</para>
    ///   <para>rdfs:label : Dramatization of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOf">rdarel:dramatizationOf</a>
    /// </summary>
    let dramatizationOf = _prefixId.prefix "dramatizationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a drama.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOfExpression</para>
    ///   <para>rdfs:label : Dramatization of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfExpression">rdarel:dramatizationOfExpression</a>
    /// </summary>
    let dramatizationOfExpression = _prefixId.prefix "dramatizationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a drama.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizationOfWork</para>
    ///   <para>rdfs:label : Dramatization of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizationOfWork">rdarel:dramatizationOfWork</a>
    /// </summary>
    let dramatizationOfWork = _prefixId.prefix "dramatizationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAs</para>
    ///   <para>rdfs:label : Dramatized as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAs">rdarel:dramatizedAs</a>
    /// </summary>
    let dramatizedAs = _prefixId.prefix "dramatizedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a dramatic work adapted from the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAsExpression</para>
    ///   <para>rdfs:label : Dramatized as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsExpression">rdarel:dramatizedAsExpression</a>
    /// </summary>
    let dramatizedAsExpression = _prefixId.prefix "dramatizedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A dramatic work adapted from the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dramatizedAsWork</para>
    ///   <para>rdfs:label : Dramatized as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/dramatizedAsWork">rdarel:dramatizedAsWork</a>
    /// </summary>
    let dramatizedAsWork = _prefixId.prefix "dramatizedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproduction</para>
    ///   <para>rdfs:label : Electronic reproduction</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproduction">rdarel:electronicReproduction</a>
    /// </summary>
    let electronicReproduction = _prefixId.prefix "electronicReproduction"

    /// <summary>
    ///   <para>skos:definition : A digital manifestation resulting from the reproduction of an analog manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionManifestation</para>
    ///   <para>rdfs:label : Electronic reproduction (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionManifestation">rdarel:electronicReproductionManifestation</a>
    /// </summary>
    let electronicReproductionManifestation =
        _prefixId.prefix "electronicReproductionManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOf</para>
    ///   <para>rdfs:label : Electronic reproduction of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOf">rdarel:electronicReproductionOf</a>
    /// </summary>
    let electronicReproductionOf = _prefixId.prefix "electronicReproductionOf"
    /// <summary>
    ///   <para>skos:definition : An analog item used as the basis for an electronic reproduction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOfItem</para>
    ///   <para>rdfs:label : Electronic reproduction of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfItem">rdarel:electronicReproductionOfItem</a>
    /// </summary>
    let electronicReproductionOfItem = _prefixId.prefix "electronicReproductionOfItem"

    /// <summary>
    ///   <para>skos:definition : An analog manifestation used as the basis for an electronic reproduction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOfManifestation</para>
    ///   <para>rdfs:label : Electronic reproduction of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/electronicReproductionOfManifestation">rdarel:electronicReproductionOfManifestation</a>
    /// </summary>
    let electronicReproductionOfManifestation =
        _prefixId.prefix "electronicReproductionOfManifestation"

    /// <summary>
    ///   <para>rdfs:label : Equivalence relationships</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalenceRelationships</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationships">rdarel:equivalenceRelationships</a>
    /// </summary>
    let equivalenceRelationships = _prefixId.prefix "equivalenceRelationships"
    /// <summary>
    ///   <para>skos:definition : An item embodying the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalenceRelationshipsItem</para>
    ///   <para>rdfs:label : Equivalence relationships (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsItem">rdarel:equivalenceRelationshipsItem</a>
    /// </summary>
    let equivalenceRelationshipsItem = _prefixId.prefix "equivalenceRelationshipsItem"

    /// <summary>
    ///   <para>skos:definition : A manifestation embodying the same expression of a work.</para>
    ///   <para>rdfs:label : Equivalence relationships (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalenceRelationshipsManifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/equivalenceRelationshipsManifestation">rdarel:equivalenceRelationshipsManifestation</a>
    /// </summary>
    let equivalenceRelationshipsManifestation =
        _prefixId.prefix "equivalenceRelationshipsManifestation"

    let equivalentItem = _prefixId.prefix "equivalentItem"
    let equivalentManifestation = _prefixId.prefix "equivalentManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errata</para>
    ///   <para>rdfs:label : Errata</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errata">rdarel:errata</a>
    /// </summary>
    let errata = _prefixId.prefix "errata"
    /// <summary>
    ///   <para>skos:definition : An expression of a work consisting of errors discovered after the publication of the predominant work, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataExpression</para>
    ///   <para>rdfs:label : Errata (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errataExpression">rdarel:errataExpression</a>
    /// </summary>
    let errataExpression = _prefixId.prefix "errataExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataTo</para>
    ///   <para>rdfs:label : Errata to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errataTo">rdarel:errataTo</a>
    /// </summary>
    let errataTo = _prefixId.prefix "errataTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that is augmented by a list of errors in the augmented work, discovered after publication, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataToExpression</para>
    ///   <para>rdfs:label : Errata to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errataToExpression">rdarel:errataToExpression</a>
    /// </summary>
    let errataToExpression = _prefixId.prefix "errataToExpression"
    /// <summary>
    ///   <para>skos:definition : A work that is augmented by a list of errors in the predominant work, discovered after publication, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataToWork</para>
    ///   <para>rdfs:label : Errata to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errataToWork">rdarel:errataToWork</a>
    /// </summary>
    let errataToWork = _prefixId.prefix "errataToWork"
    /// <summary>
    ///   <para>skos:definition : A work consisting of errors discovered after the publication of the predominant work, with their corrections.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : errataWork</para>
    ///   <para>rdfs:label : Errata (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/errataWork">rdarel:errataWork</a>
    /// </summary>
    let errataWork = _prefixId.prefix "errataWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedIn</para>
    ///   <para>rdfs:label : Evaluated in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedIn">rdarel:evaluatedIn</a>
    /// </summary>
    let evaluatedIn = _prefixId.prefix "evaluatedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that examines or judges the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInExpression</para>
    ///   <para>rdfs:label : Evaluated in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInExpression">rdarel:evaluatedInExpression</a>
    /// </summary>
    let evaluatedInExpression = _prefixId.prefix "evaluatedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work that examines or judges the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInWork</para>
    ///   <para>rdfs:label : Evaluated in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluatedInWork">rdarel:evaluatedInWork</a>
    /// </summary>
    let evaluatedInWork = _prefixId.prefix "evaluatedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOf</para>
    ///   <para>rdfs:label : Evaluation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOf">rdarel:evaluationOf</a>
    /// </summary>
    let evaluationOf = _prefixId.prefix "evaluationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfExpression</para>
    ///   <para>rdfs:label : Evaluation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfExpression">rdarel:evaluationOfExpression</a>
    /// </summary>
    let evaluationOfExpression = _prefixId.prefix "evaluationOfExpression"
    /// <summary>
    ///   <para>skos:definition : An item that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfItem</para>
    ///   <para>rdfs:label : Evaluation of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfItem">rdarel:evaluationOfItem</a>
    /// </summary>
    let evaluationOfItem = _prefixId.prefix "evaluationOfItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfManifestation</para>
    ///   <para>rdfs:label : Evaluation of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfManifestation">rdarel:evaluationOfManifestation</a>
    /// </summary>
    let evaluationOfManifestation = _prefixId.prefix "evaluationOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A work that is examined or judged.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluationOfWork</para>
    ///   <para>rdfs:label : Evaluation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/evaluationOfWork">rdarel:evaluationOfWork</a>
    /// </summary>
    let evaluationOfWork = _prefixId.prefix "evaluationOfWork"
    /// <summary>
    ///   <para>skos:definition : A single exemplar or instance of a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : exemplarOfManifestation</para>
    ///   <para>rdfs:label : Exemplar of manifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/exemplarOfManifestation">rdarel:exemplarOfManifestation</a>
    /// </summary>
    let exemplarOfManifestation = _prefixId.prefix "exemplarOfManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAs</para>
    ///   <para>rdfs:label : Expanded as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedAs">rdarel:expandedAs</a>
    /// </summary>
    let expandedAs = _prefixId.prefix "expandedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that expands the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAsExpression</para>
    ///   <para>rdfs:label : Expanded as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsExpression">rdarel:expandedAsExpression</a>
    /// </summary>
    let expandedAsExpression = _prefixId.prefix "expandedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that enlarges upon the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedAsWork</para>
    ///   <para>rdfs:label : Expanded as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedAsWork">rdarel:expandedAsWork</a>
    /// </summary>
    let expandedAsWork = _prefixId.prefix "expandedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOf</para>
    ///   <para>rdfs:label : Expanded version of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOf">rdarel:expandedVersionOf</a>
    /// </summary>
    let expandedVersionOf = _prefixId.prefix "expandedVersionOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a derivative work that enlarges upon the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOfExpression</para>
    ///   <para>rdfs:label : Expanded version of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfExpression">rdarel:expandedVersionOfExpression</a>
    /// </summary>
    let expandedVersionOfExpression = _prefixId.prefix "expandedVersionOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a derivative work that enlarges upon the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expandedVersionOfWork</para>
    ///   <para>rdfs:label : Expanded version of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expandedVersionOfWork">rdarel:expandedVersionOfWork</a>
    /// </summary>
    let expandedVersionOfWork = _prefixId.prefix "expandedVersionOfWork"
    /// <summary>
    ///   <para>skos:definition : A physical embodiment of an expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expressionManifested</para>
    ///   <para>rdfs:label : Expression manifested</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expressionManifested">rdarel:expressionManifested</a>
    /// </summary>
    let expressionManifested = _prefixId.prefix "expressionManifested"
    /// <summary>
    ///   <para>skos:definition : A realization of the work in a form of alpha-numeric, musical or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : expressionOfWork</para>
    ///   <para>rdfs:label : Expression of work</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/expressionOfWork">rdarel:expressionOfWork</a>
    /// </summary>
    let expressionOfWork = _prefixId.prefix "expressionOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimile</para>
    ///   <para>rdfs:label : Facsimile</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/facsimile">rdarel:facsimile</a>
    /// </summary>
    let facsimile = _prefixId.prefix "facsimile"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileManifestation</para>
    ///   <para>skos:definition : A manifestation that exactly reproduces another manifestation embodying the same expression of a work.</para>
    ///   <para>rdfs:label : Facsimile (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/facsimileManifestation">rdarel:facsimileManifestation</a>
    /// </summary>
    let facsimileManifestation = _prefixId.prefix "facsimileManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOf</para>
    ///   <para>rdfs:label : Facsimile of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOf">rdarel:facsimileOf</a>
    /// </summary>
    let facsimileOf = _prefixId.prefix "facsimileOf"
    /// <summary>
    ///   <para>skos:definition : A particular item used as the basis for an exact reproduction.</para>
    ///   <para>rdfs:label : Facsimile of (Item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOfItem</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfItem">rdarel:facsimileOfItem</a>
    /// </summary>
    let facsimileOfItem = _prefixId.prefix "facsimileOfItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation used as the basis for an exact reproduction.</para>
    ///   <para>rdfs:label : Facsimile of (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOfManifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/facsimileOfManifestation">rdarel:facsimileOfManifestation</a>
    /// </summary>
    let facsimileOfManifestation = _prefixId.prefix "facsimileOfManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWith</para>
    ///   <para>rdfs:label : Filmed with</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/filmedWith">rdarel:filmedWith</a>
    /// </summary>
    let filmedWith = _prefixId.prefix "filmedWith"
    /// <summary>
    ///   <para>skos:definition : An item that is contained on the same microfilm with the item being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWithItem</para>
    ///   <para>rdfs:label : Filmed with (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithItem">rdarel:filmedWithItem</a>
    /// </summary>
    let filmedWithItem = _prefixId.prefix "filmedWithItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation that is issued on the same carrier with the manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWithManifestation</para>
    ///   <para>rdfs:label : Filmed with (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/filmedWithManifestation">rdarel:filmedWithManifestation</a>
    /// </summary>
    let filmedWithManifestation = _prefixId.prefix "filmedWithManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAid</para>
    ///   <para>rdfs:label : Finding aid</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAid">rdarel:findingAid</a>
    /// </summary>
    let findingAid = _prefixId.prefix "findingAid"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidExpression</para>
    ///   <para>rdfs:label : Finding aid (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAidExpression">rdarel:findingAidExpression</a>
    /// </summary>
    let findingAidExpression = _prefixId.prefix "findingAidExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidFor</para>
    ///   <para>rdfs:label : Finding aid for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAidFor">rdarel:findingAidFor</a>
    /// </summary>
    let findingAidFor = _prefixId.prefix "findingAidFor"
    /// <summary>
    ///   <para>skos:definition : An expression of an archival collection used as the basis for a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidForExpression</para>
    ///   <para>rdfs:label : Finding aid for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForExpression">rdarel:findingAidForExpression</a>
    /// </summary>
    let findingAidForExpression = _prefixId.prefix "findingAidForExpression"
    /// <summary>
    ///   <para>skos:definition : An archival collection that is described in a finding aid, i.e., a guide to the organization, arrangement, and contents of the collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidForWork</para>
    ///   <para>rdfs:label : Finding aid for (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAidForWork">rdarel:findingAidForWork</a>
    /// </summary>
    let findingAidForWork = _prefixId.prefix "findingAidForWork"
    /// <summary>
    ///   <para>skos:definition : A work that provides a guide to the organization, arrangement, and contents of an archival collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : findingAidWork</para>
    ///   <para>rdfs:label : Finding aid (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/findingAidWork">rdarel:findingAidWork</a>
    /// </summary>
    let findingAidWork = _prefixId.prefix "findingAidWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOf</para>
    ///   <para>rdfs:label : Free translation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOf">rdarel:freeTranslationOf</a>
    /// </summary>
    let freeTranslationOf = _prefixId.prefix "freeTranslationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOfExpression</para>
    ///   <para>rdfs:label : Free translation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfExpression">rdarel:freeTranslationOfExpression</a>
    /// </summary>
    let freeTranslationOfExpression = _prefixId.prefix "freeTranslationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been translated freely, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freeTranslationOfWork</para>
    ///   <para>rdfs:label : Free translation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freeTranslationOfWork">rdarel:freeTranslationOfWork</a>
    /// </summary>
    let freeTranslationOfWork = _prefixId.prefix "freeTranslationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAs</para>
    ///   <para>rdfs:label : Freely translated as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAs">rdarel:freelyTranslatedAs</a>
    /// </summary>
    let freelyTranslatedAs = _prefixId.prefix "freelyTranslatedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that presents the text in another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAsExpression</para>
    ///   <para>rdfs:label : Freely translated as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsExpression">rdarel:freelyTranslatedAsExpression</a>
    /// </summary>
    let freelyTranslatedAsExpression = _prefixId.prefix "freelyTranslatedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that created by freely rendering the source work into another language, preserving the spirit of the original, but not its linguistic details.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : freelyTranslatedAsWork</para>
    ///   <para>rdfs:label : Freely translated as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/freelyTranslatedAsWork">rdarel:freelyTranslatedAsWork</a>
    /// </summary>
    let freelyTranslatedAsWork = _prefixId.prefix "freelyTranslatedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guide</para>
    ///   <para>rdfs:label : Guide</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guide">rdarel:guide</a>
    /// </summary>
    let guide = _prefixId.prefix "guide"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that guides a user through the use of the predominant work, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideExpression</para>
    ///   <para>rdfs:label : Guide (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guideExpression">rdarel:guideExpression</a>
    /// </summary>
    let guideExpression = _prefixId.prefix "guideExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideTo</para>
    ///   <para>rdfs:label : Guide to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guideTo">rdarel:guideTo</a>
    /// </summary>
    let guideTo = _prefixId.prefix "guideTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that is augmented by another work comprising material to help the user of the predominant work, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideToExpression</para>
    ///   <para>rdfs:label : Guide to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guideToExpression">rdarel:guideToExpression</a>
    /// </summary>
    let guideToExpression = _prefixId.prefix "guideToExpression"
    /// <summary>
    ///   <para>skos:definition : A work that is augmented by another work comprising material to help the user of the augmented work, such as notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideToWork</para>
    ///   <para>rdfs:label : Guide to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guideToWork">rdarel:guideToWork</a>
    /// </summary>
    let guideToWork = _prefixId.prefix "guideToWork"
    /// <summary>
    ///   <para>skos:definition : A work that guides a user through the use of the predominant work, using notes, learning and study aids, exercises, problems, questions and answers, instructor or student materials, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : guideWork</para>
    ///   <para>rdfs:label : Guide (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/guideWork">rdarel:guideWork</a>
    /// </summary>
    let guideWork = _prefixId.prefix "guideWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrations</para>
    ///   <para>rdfs:label : Illustrations</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrations">rdarel:illustrations</a>
    /// </summary>
    let illustrations = _prefixId.prefix "illustrations"
    /// <summary>
    ///   <para>skos:definition : An expression of a work comprising pictorial content designed to elucidate or decorate the augmented entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsExpression</para>
    ///   <para>rdfs:label : Illustrations (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsExpression">rdarel:illustrationsExpression</a>
    /// </summary>
    let illustrationsExpression = _prefixId.prefix "illustrationsExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsFor</para>
    ///   <para>rdfs:label : Illustrations for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsFor">rdarel:illustrationsFor</a>
    /// </summary>
    let illustrationsFor = _prefixId.prefix "illustrationsFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that is augmented by pictorial content designed to elucidate or decorate it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsForExpression</para>
    ///   <para>rdfs:label : Illustrations for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForExpression">rdarel:illustrationsForExpression</a>
    /// </summary>
    let illustrationsForExpression = _prefixId.prefix "illustrationsForExpression"
    /// <summary>
    ///   <para>skos:definition : A work that is augmented by pictorial content designed to elucidate or decorate it.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsForWork</para>
    ///   <para>rdfs:label : Illustrations for (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsForWork">rdarel:illustrationsForWork</a>
    /// </summary>
    let illustrationsForWork = _prefixId.prefix "illustrationsForWork"
    /// <summary>
    ///   <para>skos:definition : A work comprising pictorial content designed to elucidate or decorate the augmented work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illustrationsWork</para>
    ///   <para>rdfs:label : Illustrations (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/illustrationsWork">rdarel:illustrationsWork</a>
    /// </summary>
    let illustrationsWork = _prefixId.prefix "illustrationsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAs</para>
    ///   <para>rdfs:label : Imitated as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAs">rdarel:imitatedAs</a>
    /// </summary>
    let imitatedAs = _prefixId.prefix "imitatedAs"
    /// <summary>
    ///   <para>rdfs:label : Imitated as (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAsExpression</para>
    ///   <para>skos:definition : An expression of a work that copies the style of the source work.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsExpression">rdarel:imitatedAsExpression</a>
    /// </summary>
    let imitatedAsExpression = _prefixId.prefix "imitatedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that copies the style of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitatedAsWork</para>
    ///   <para>rdfs:label : Imitated as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitatedAsWork">rdarel:imitatedAsWork</a>
    /// </summary>
    let imitatedAsWork = _prefixId.prefix "imitatedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOf</para>
    ///   <para>rdfs:label : Imitation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitationOf">rdarel:imitationOf</a>
    /// </summary>
    let imitationOf = _prefixId.prefix "imitationOf"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOfExpression</para>
    ///   <para>skos:definition : An expression of a work whose style is copied in a derivative work.</para>
    ///   <para>rdfs:label : Imitation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfExpression">rdarel:imitationOfExpression</a>
    /// </summary>
    let imitationOfExpression = _prefixId.prefix "imitationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work whose style is copied in a derivative work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : imitationOfWork</para>
    ///   <para>rdfs:label : Imitation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imitationOfWork">rdarel:imitationOfWork</a>
    /// </summary>
    let imitationOfWork = _prefixId.prefix "imitationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariations</para>
    ///   <para>rdfs:label : Musical variations</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/imusicalVariations">rdarel:imusicalVariations</a>
    /// </summary>
    let imusicalVariations = _prefixId.prefix "imusicalVariations"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inSeries</para>
    ///   <para>rdfs:label : In series</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/inSeries">rdarel:inSeries</a>
    /// </summary>
    let inSeries = _prefixId.prefix "inSeries"
    /// <summary>
    ///   <para>skos:definition : A work in which the part has been issued; the part bears the title of the larger work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inSeriesWork</para>
    ///   <para>rdfs:label : In series (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/inSeriesWork">rdarel:inSeriesWork</a>
    /// </summary>
    let inSeriesWork = _prefixId.prefix "inSeriesWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : index</para>
    ///   <para>rdfs:label : Index</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/index">rdarel:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides a systematic, alphabetical guide to the contents of the predominant entity, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexExpression</para>
    ///   <para>rdfs:label : Index (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexExpression">rdarel:indexExpression</a>
    /// </summary>
    let indexExpression = _prefixId.prefix "indexExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexTo</para>
    ///   <para>rdfs:label : Index to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexTo">rdarel:indexTo</a>
    /// </summary>
    let indexTo = _prefixId.prefix "indexTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the predominant entity, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexToExpression</para>
    ///   <para>rdfs:label : Index to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexToExpression">rdarel:indexToExpression</a>
    /// </summary>
    let indexToExpression = _prefixId.prefix "indexToExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for an index, i.e., a systematic, alphabetical guide to the contents of the augmented work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexToWork</para>
    ///   <para>rdfs:label : Index to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexToWork">rdarel:indexToWork</a>
    /// </summary>
    let indexToWork = _prefixId.prefix "indexToWork"
    /// <summary>
    ///   <para>skos:definition : A work that provides a systematic, alphabetical guide to the contents of the predominant work, usually keyed to page numbers or other reference codes.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexWork</para>
    ///   <para>rdfs:label : Index (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexWork">rdarel:indexWork</a>
    /// </summary>
    let indexWork = _prefixId.prefix "indexWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedIn</para>
    ///   <para>rdfs:label : Indexed in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexedIn">rdarel:indexedIn</a>
    /// </summary>
    let indexedIn = _prefixId.prefix "indexedIn"
    /// <summary>
    ///   <para>skos:definition : The expression of the work (asn abstracting and indexing service) that indexes the contents of a source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedInExpression</para>
    ///   <para>rdfs:label : Indexed in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexedInExpression">rdarel:indexedInExpression</a>
    /// </summary>
    let indexedInExpression = _prefixId.prefix "indexedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work (an abstracting and indexing service) that indexes the contents of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexedInWork</para>
    ///   <para>rdfs:label : Indexed in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexedInWork">rdarel:indexedInWork</a>
    /// </summary>
    let indexedInWork = _prefixId.prefix "indexedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingFor</para>
    ///   <para>rdfs:label : Indexing for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexingFor">rdarel:indexingFor</a>
    /// </summary>
    let indexingFor = _prefixId.prefix "indexingFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a work whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingForExpression</para>
    ///   <para>rdfs:label : Indexing for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexingForExpression">rdarel:indexingForExpression</a>
    /// </summary>
    let indexingForExpression = _prefixId.prefix "indexingForExpression"
    /// <summary>
    ///   <para>skos:definition : A work whose contents have been indexed by an abstracting and indexing service.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : indexingForWork</para>
    ///   <para>rdfs:label : Indexing for (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/indexingForWork">rdarel:indexingForWork</a>
    /// </summary>
    let indexingForWork = _prefixId.prefix "indexingForWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insert</para>
    ///   <para>rdfs:label : Insert</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/insert">rdarel:insert</a>
    /// </summary>
    let insert = _prefixId.prefix "insert"
    /// <summary>
    ///   <para>skos:definition : A manifestation consisting of separately issued material that is not an integral part of the larger manifestation into which it has been inserted.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insertManifestation</para>
    ///   <para>rdfs:label : Insert (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/insertManifestation">rdarel:insertManifestation</a>
    /// </summary>
    let insertManifestation = _prefixId.prefix "insertManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insertedIn</para>
    ///   <para>rdfs:label : Inserted in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/insertedIn">rdarel:insertedIn</a>
    /// </summary>
    let insertedIn = _prefixId.prefix "insertedIn"
    /// <summary>
    ///   <para>skos:definition : A manifestation into which material has been inserted that is not an integral part of the publication.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : insertedInManifestation</para>
    ///   <para>rdfs:label : Inserted in (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/insertedInManifestation">rdarel:insertedInManifestation</a>
    /// </summary>
    let insertedInManifestation = _prefixId.prefix "insertedInManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuedWith</para>
    ///   <para>rdfs:label : Issued with</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/issuedWith">rdarel:issuedWith</a>
    /// </summary>
    let issuedWith = _prefixId.prefix "issuedWith"
    /// <summary>
    ///   <para>rdfs:label : Issued with (Manifestation)</para>
    ///   <para>skos:definition : A manifestation that is issued on the same carrier as the manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : issuedWithManifestation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/issuedWithManifestation">rdarel:issuedWithManifestation</a>
    /// </summary>
    let issuedWithManifestation = _prefixId.prefix "issuedWithManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : libretto</para>
    ///   <para>rdfs:label : Libretto</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/libretto">rdarel:libretto</a>
    /// </summary>
    let libretto = _prefixId.prefix "libretto"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOn</para>
    ///   <para>rdfs:label : Libretto based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOn">rdarel:librettoBasedOn</a>
    /// </summary>
    let librettoBasedOn = _prefixId.prefix "librettoBasedOn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOnExpression</para>
    ///   <para>rdfs:label : Libretto based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnExpression">rdarel:librettoBasedOnExpression</a>
    /// </summary>
    let librettoBasedOnExpression = _prefixId.prefix "librettoBasedOnExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoBasedOnWork</para>
    ///   <para>rdfs:label : Libretto based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoBasedOnWork">rdarel:librettoBasedOnWork</a>
    /// </summary>
    let librettoBasedOnWork = _prefixId.prefix "librettoBasedOnWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text of an opera or other work for the musical stage, or an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoExpression</para>
    ///   <para>rdfs:label : Libretto (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoExpression">rdarel:librettoExpression</a>
    /// </summary>
    let librettoExpression = _prefixId.prefix "librettoExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoFor</para>
    ///   <para>rdfs:label : Libretto for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoFor">rdarel:librettoFor</a>
    /// </summary>
    let librettoFor = _prefixId.prefix "librettoFor"
    /// <summary>
    ///   <para>skos:definition : An expression of a musical work such as an opera or other work for the musical stage, or an oratorio, that uses the text of the related work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoForExpression</para>
    ///   <para>rdfs:label : Libretto for (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoForExpression">rdarel:librettoForExpression</a>
    /// </summary>
    let librettoForExpression = _prefixId.prefix "librettoForExpression"
    /// <summary>
    ///   <para>skos:definition : A musical work such as an opera or other work for the musical stage concerto that contains a vocal text.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoForWork</para>
    ///   <para>rdfs:label : Libretto for (work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoForWork">rdarel:librettoForWork</a>
    /// </summary>
    let librettoForWork = _prefixId.prefix "librettoForWork"
    /// <summary>
    ///   <para>skos:definition : A work comprising the text of an opera or other work for the musical stage.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : librettoWork</para>
    ///   <para>rdfs:label : Libretto (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/librettoWork">rdarel:librettoWork</a>
    /// </summary>
    let librettoWork = _prefixId.prefix "librettoWork"
    /// <summary>
    ///   <para>skos:definition : The manifestation exemplified by an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manifestationExemplified</para>
    ///   <para>rdfs:label : Manifestation exemplified</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/manifestationExemplified">rdarel:manifestationExemplified</a>
    /// </summary>
    let manifestationExemplified = _prefixId.prefix "manifestationExemplified"
    /// <summary>
    ///   <para>skos:definition : A physical embodiment of an expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manifestationOfWork</para>
    ///   <para>rdfs:label : Manifestation of work</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/manifestationOfWork">rdarel:manifestationOfWork</a>
    /// </summary>
    let manifestationOfWork = _prefixId.prefix "manifestationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedWithToForm</para>
    ///   <para>rdfs:label : Merged with to form</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToForm">rdarel:mergedWithToForm</a>
    /// </summary>
    let mergedWithToForm = _prefixId.prefix "mergedWithToForm"
    /// <summary>
    ///   <para>skos:definition : One of two or more expressions of works that come together to form a new entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedWithToFormExpression</para>
    ///   <para>rdfs:label : Merged with to form (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormExpression">rdarel:mergedWithToFormExpression</a>
    /// </summary>
    let mergedWithToFormExpression = _prefixId.prefix "mergedWithToFormExpression"
    /// <summary>
    ///   <para>skos:definition : One of two or more works that come together to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergedWithToFormWork</para>
    ///   <para>rdfs:label : Merged with to form (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergedWithToFormWork">rdarel:mergedWithToFormWork</a>
    /// </summary>
    let mergedWithToFormWork = _prefixId.prefix "mergedWithToFormWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOf</para>
    ///   <para>rdfs:label : Merger of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergerOf">rdarel:mergerOf</a>
    /// </summary>
    let mergerOf = _prefixId.prefix "mergerOf"
    /// <summary>
    ///   <para>skos:definition : An expression of one of two or more works which came together to form a new entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOfExpression</para>
    ///   <para>rdfs:label : Merger of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfExpression">rdarel:mergerOfExpression</a>
    /// </summary>
    let mergerOfExpression = _prefixId.prefix "mergerOfExpression"
    /// <summary>
    ///   <para>skos:definition : One of two or more works which came together to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mergerOfWork</para>
    ///   <para>rdfs:label : Merger of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mergerOfWork">rdarel:mergerOfWork</a>
    /// </summary>
    let mergerOfWork = _prefixId.prefix "mergerOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mirrorSite</para>
    ///   <para>rdfs:label : Mirror site</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSite">rdarel:mirrorSite</a>
    /// </summary>
    let mirrorSite = _prefixId.prefix "mirrorSite"
    /// <summary>
    ///   <para>skos:definition : A manifestation of a Web site that is an exact copy, used to reduce network traffic or improve the availability of the original site.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : mirrorSiteManifestation</para>
    ///   <para>rdfs:label : Mirror site (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/mirrorSiteManifestation">rdarel:mirrorSiteManifestation</a>
    /// </summary>
    let mirrorSiteManifestation = _prefixId.prefix "mirrorSiteManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOf</para>
    ///   <para>rdfs:label : Motion picture adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOf">rdarel:motionPictureAdaptationOf</a>
    /// </summary>
    let motionPictureAdaptationOf = _prefixId.prefix "motionPictureAdaptationOf"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOfExpression</para>
    ///   <para>rdfs:label : Motion picture adaptation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfExpression">rdarel:motionPictureAdaptationOfExpression</a>
    /// </summary>
    let motionPictureAdaptationOfExpression =
        _prefixId.prefix "motionPictureAdaptationOfExpression"

    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureAdaptationOfWork</para>
    ///   <para>rdfs:label : Motion picture adaptation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureAdaptationOfWork">rdarel:motionPictureAdaptationOfWork</a>
    /// </summary>
    let motionPictureAdaptationOfWork = _prefixId.prefix "motionPictureAdaptationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplay</para>
    ///   <para>rdfs:label : Motion picture screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplay">rdarel:motionPictureScreenplay</a>
    /// </summary>
    let motionPictureScreenplay = _prefixId.prefix "motionPictureScreenplay"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOn</para>
    ///   <para>rdfs:label : Motion picture screenplay based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOn">rdarel:motionPictureScreenplayBasedOn</a>
    /// </summary>
    let motionPictureScreenplayBasedOn =
        _prefixId.prefix "motionPictureScreenplayBasedOn"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as the screenplay for a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOnExpression</para>
    ///   <para>rdfs:label : Motion picture screenplay based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnExpression">rdarel:motionPictureScreenplayBasedOnExpression</a>
    /// </summary>
    let motionPictureScreenplayBasedOnExpression =
        _prefixId.prefix "motionPictureScreenplayBasedOnExpression"

    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as the screenplay for a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayBasedOnWork</para>
    ///   <para>rdfs:label : Motion picture screenplay based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayBasedOnWork">rdarel:motionPictureScreenplayBasedOnWork</a>
    /// </summary>
    let motionPictureScreenplayBasedOnWork =
        _prefixId.prefix "motionPictureScreenplayBasedOnWork"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text for a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : motionPictureScreenplayExpression</para>
    ///   <para>rdfs:label : Motion picture screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/motionPictureScreenplayExpression">rdarel:motionPictureScreenplayExpression</a>
    /// </summary>
    let motionPictureScreenplayExpression =
        _prefixId.prefix "motionPictureScreenplayExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangement</para>
    ///   <para>rdfs:label : Musical arrangement</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangement">rdarel:musicalArrangement</a>
    /// </summary>
    let musicalArrangement = _prefixId.prefix "musicalArrangement"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that rewrites the source entity for a medium of performance different from that for which the work was originally intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangementExpression</para>
    ///   <para>rdfs:label : Musical arrangement (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementExpression">rdarel:musicalArrangementExpression</a>
    /// </summary>
    let musicalArrangementExpression = _prefixId.prefix "musicalArrangementExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangementOf</para>
    ///   <para>rdfs:label : Musical arrangement of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOf">rdarel:musicalArrangementOf</a>
    /// </summary>
    let musicalArrangementOf = _prefixId.prefix "musicalArrangementOf"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been rewritten for a medium of performance different from that for which the work was originally
    /// intended.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalArrangementOfExpression</para>
    ///   <para>rdfs:label : Musical arrangement of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalArrangementOfExpression">rdarel:musicalArrangementOfExpression</a>
    /// </summary>
    let musicalArrangementOfExpression =
        _prefixId.prefix "musicalArrangementOfExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSetting</para>
    ///   <para>rdfs:label : Musical setting</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSetting">rdarel:musicalSetting</a>
    /// </summary>
    let musicalSetting = _prefixId.prefix "musicalSetting"
    /// <summary>
    ///   <para>skos:definition : An expression of a non-dramatic musical work, except for an oratorio, that uses the text of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingExpression</para>
    ///   <para>rdfs:label : Musical setting (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingExpression">rdarel:musicalSettingExpression</a>
    /// </summary>
    let musicalSettingExpression = _prefixId.prefix "musicalSettingExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOf</para>
    ///   <para>rdfs:label : Musical setting of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOf">rdarel:musicalSettingOf</a>
    /// </summary>
    let musicalSettingOf = _prefixId.prefix "musicalSettingOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text for a non-dramatic musical work, except for an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOfExpression</para>
    ///   <para>rdfs:label : Musical setting of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfExpression">rdarel:musicalSettingOfExpression</a>
    /// </summary>
    let musicalSettingOfExpression = _prefixId.prefix "musicalSettingOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that provides the text for a non-dramatic musical work, except for an oratorio.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingOfWork</para>
    ///   <para>rdfs:label : Musical setting of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingOfWork">rdarel:musicalSettingOfWork</a>
    /// </summary>
    let musicalSettingOfWork = _prefixId.prefix "musicalSettingOfWork"
    /// <summary>
    ///   <para>skos:definition : A non-dramatic musical work, except for an oratorio, that uses the text for the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalSettingWork</para>
    ///   <para>rdfs:label : Musical setting (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalSettingWork">rdarel:musicalSettingWork</a>
    /// </summary>
    let musicalSettingWork = _prefixId.prefix "musicalSettingWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsBasedOn</para>
    ///   <para>rdfs:label : Musical variations based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOn">rdarel:musicalVariationsBasedOn</a>
    /// </summary>
    let musicalVariationsBasedOn = _prefixId.prefix "musicalVariationsBasedOn"

    /// <summary>
    ///   <para>skos:definition : An expression of a musical work from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is
    /// repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsBasedOnExpression</para>
    ///   <para>rdfs:label : Musical variations based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnExpression">rdarel:musicalVariationsBasedOnExpression</a>
    /// </summary>
    let musicalVariationsBasedOnExpression =
        _prefixId.prefix "musicalVariationsBasedOnExpression"

    /// <summary>
    ///   <para>skos:definition : A musical work from which melodic, thematic, or harmonic material is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsBasedOnWork</para>
    ///   <para>rdfs:label : Musical variations based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsBasedOnWork">rdarel:musicalVariationsBasedOnWork</a>
    /// </summary>
    let musicalVariationsBasedOnWork = _prefixId.prefix "musicalVariationsBasedOnWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a musical work in which melodic, thematic, or harmonic material from the source work is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsExpression</para>
    ///   <para>rdfs:label : Musical variations (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsExpression">rdarel:musicalVariationsExpression</a>
    /// </summary>
    let musicalVariationsExpression = _prefixId.prefix "musicalVariationsExpression"
    /// <summary>
    ///   <para>skos:definition : A musical work in which melodic, thematic, or harmonic material from the source work is taken to form a discrete theme, which is repeated one or more times with subsequent modifications.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : musicalVariationsWork</para>
    ///   <para>rdfs:label : Musical variations (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/musicalVariationsWork">rdarel:musicalVariationsWork</a>
    /// </summary>
    let musicalVariationsWork = _prefixId.prefix "musicalVariationsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelization</para>
    ///   <para>rdfs:label : Novelization</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelization">rdarel:novelization</a>
    /// </summary>
    let novelization = _prefixId.prefix "novelization"
    /// <summary>
    ///   <para>skos:definition : An expression of a novel adapted from the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationExpression</para>
    ///   <para>rdfs:label : Novelization (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelizationExpression">rdarel:novelizationExpression</a>
    /// </summary>
    let novelizationExpression = _prefixId.prefix "novelizationExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOf</para>
    ///   <para>rdfs:label : Novelization of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOf">rdarel:novelizationOf</a>
    /// </summary>
    let novelizationOf = _prefixId.prefix "novelizationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOfExpression</para>
    ///   <para>rdfs:label : Novelization of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfExpression">rdarel:novelizationOfExpression</a>
    /// </summary>
    let novelizationOfExpression = _prefixId.prefix "novelizationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a novel.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationOfWork</para>
    ///   <para>rdfs:label : Novelization of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelizationOfWork">rdarel:novelizationOfWork</a>
    /// </summary>
    let novelizationOfWork = _prefixId.prefix "novelizationOfWork"
    /// <summary>
    ///   <para>skos:definition : A novel adapted from the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : novelizationWork</para>
    ///   <para>rdfs:label : Novelization (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/novelizationWork">rdarel:novelizationWork</a>
    /// </summary>
    let novelizationWork = _prefixId.prefix "novelizationWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfPart</para>
    ///   <para>rdfs:label : Numbering of part</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPart">rdarel:numberingOfPart</a>
    /// </summary>
    let numberingOfPart = _prefixId.prefix "numberingOfPart"
    /// <summary>
    ///   <para>skos:definition : A designation of the sequencing of a part or parts within a larger work. Numbering of part may include a numeral, a letter, any other character, or the combination of these, with or without an accompanying caption (volume, number, etc.) and/or a chronological designation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : numberingOfPartWork</para>
    ///   <para>rdfs:label : Numbering of part (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/numberingOfPartWork">rdarel:numberingOfPartWork</a>
    /// </summary>
    let numberingOfPartWork = _prefixId.prefix "numberingOfPartWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWith</para>
    ///   <para>rdfs:label : On disc with</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWith">rdarel:onDiscWith</a>
    /// </summary>
    let onDiscWith = _prefixId.prefix "onDiscWith"
    /// <summary>
    ///   <para>skos:definition : An item that is contained on the same disc with the item being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWithItem</para>
    ///   <para>rdfs:label : On disc with (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithItem">rdarel:onDiscWithItem</a>
    /// </summary>
    let onDiscWithItem = _prefixId.prefix "onDiscWithItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation that is issued on the same disc with the
    /// manifestation being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWithManifestation</para>
    ///   <para>rdfs:label : On disc with (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/onDiscWithManifestation">rdarel:onDiscWithManifestation</a>
    /// </summary>
    let onDiscWithManifestation = _prefixId.prefix "onDiscWithManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOf</para>
    ///   <para>rdfs:label : Paraphrase of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOf">rdarel:paraphraseOf</a>
    /// </summary>
    let paraphraseOf = _prefixId.prefix "paraphraseOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a paraphrase, i.e., a restating of the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOfExpression</para>
    ///   <para>rdfs:label : Paraphrase of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfExpression">rdarel:paraphraseOfExpression</a>
    /// </summary>
    let paraphraseOfExpression = _prefixId.prefix "paraphraseOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a paraphrase, i.e., a restating of the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphraseOfWork</para>
    ///   <para>rdfs:label : Paraphrase of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphraseOfWork">rdarel:paraphraseOfWork</a>
    /// </summary>
    let paraphraseOfWork = _prefixId.prefix "paraphraseOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAs</para>
    ///   <para>rdfs:label : Paraphrased as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAs">rdarel:paraphrasedAs</a>
    /// </summary>
    let paraphrasedAs = _prefixId.prefix "paraphrasedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that restates the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAsExpression</para>
    ///   <para>rdfs:label : Paraphrased as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsExpression">rdarel:paraphrasedAsExpression</a>
    /// </summary>
    let paraphrasedAsExpression = _prefixId.prefix "paraphrasedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that restates the content of the source work in a different form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : paraphrasedAsWork</para>
    ///   <para>rdfs:label : Paraphrased as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/paraphrasedAsWork">rdarel:paraphrasedAsWork</a>
    /// </summary>
    let paraphrasedAsWork = _prefixId.prefix "paraphrasedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAs</para>
    ///   <para>rdfs:label : Parodied as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAs">rdarel:parodiedAs</a>
    /// </summary>
    let parodiedAs = _prefixId.prefix "parodiedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that imitates the style or content of the source work for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAsExpression</para>
    ///   <para>rdfs:label : Parodied as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsExpression">rdarel:parodiedAsExpression</a>
    /// </summary>
    let parodiedAsExpression = _prefixId.prefix "parodiedAsExpression"
    /// <summary>
    ///   <para>skos:definition : A work that imitates the style or content of the source work for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodiedAsWork</para>
    ///   <para>rdfs:label : Parodied as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodiedAsWork">rdarel:parodiedAsWork</a>
    /// </summary>
    let parodiedAsWork = _prefixId.prefix "parodiedAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOf</para>
    ///   <para>rdfs:label : Parody of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodyOf">rdarel:parodyOf</a>
    /// </summary>
    let parodyOf = _prefixId.prefix "parodyOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work whose style or content is imitated for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOfExpression</para>
    ///   <para>rdfs:label : Parody of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfExpression">rdarel:parodyOfExpression</a>
    /// </summary>
    let parodyOfExpression = _prefixId.prefix "parodyOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work whose style is imitated for comic effect.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : parodyOfWork</para>
    ///   <para>rdfs:label : Parody of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/parodyOfWork">rdarel:parodyOfWork</a>
    /// </summary>
    let parodyOfWork = _prefixId.prefix "parodyOfWork"
    /// <summary>
    ///   <para>rdfs:label : Preceded by</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededBy</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/precededBy">rdarel:precededBy</a>
    /// </summary>
    let precededBy = _prefixId.prefix "precededBy"
    /// <summary>
    ///   <para>rdfs:label : Preceded by (Expression)</para>
    ///   <para>skos:definition : An expression of a work that precedes (e.g., is earlier in time or before in narrative) the succeeding entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededByExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/precededByExpression">rdarel:precededByExpression</a>
    /// </summary>
    let precededByExpression = _prefixId.prefix "precededByExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : precededByWork</para>
    ///   <para>rdfs:label : Preceded by (Work)</para>
    ///   <para>skos:definition : A work that precedes (e.g., is earlier in time or before in a narrative) the succeeding work.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/precededByWork">rdarel:precededByWork</a>
    /// </summary>
    let precededByWork = _prefixId.prefix "precededByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequel</para>
    ///   <para>rdfs:label : Prequel</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/prequel">rdarel:prequel</a>
    /// </summary>
    let prequel = _prefixId.prefix "prequel"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequelTo</para>
    ///   <para>rdfs:label : Prequel to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/prequelTo">rdarel:prequelTo</a>
    /// </summary>
    let prequelTo = _prefixId.prefix "prequelTo"
    /// <summary>
    ///   <para>skos:definition : A work whose narrative is extended backwards in time by the later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequelToWork</para>
    ///   <para>rdfs:label : Prequel to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/prequelToWork">rdarel:prequelToWork</a>
    /// </summary>
    let prequelToWork = _prefixId.prefix "prequelToWork"
    /// <summary>
    ///   <para>skos:definition : A work that extends the narrative of an earlier work backwards in time.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : prequelWork</para>
    ///   <para>rdfs:label : Prequel (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/prequelWork">rdarel:prequelWork</a>
    /// </summary>
    let prequelWork = _prefixId.prefix "prequelWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimile</para>
    ///   <para>rdfs:label : Preservation facsimile</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimile">rdarel:preservationFacsimile</a>
    /// </summary>
    let preservationFacsimile = _prefixId.prefix "preservationFacsimile"

    /// <summary>
    ///   <para>skos:definition : A manifestation consisting of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileManifestation</para>
    ///   <para>rdfs:label : Preservation facsimile (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileManifestation">rdarel:preservationFacsimileManifestation</a>
    /// </summary>
    let preservationFacsimileManifestation =
        _prefixId.prefix "preservationFacsimileManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOf</para>
    ///   <para>rdfs:label : Preservation facsimile of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOf">rdarel:preservationFacsimileOf</a>
    /// </summary>
    let preservationFacsimileOf = _prefixId.prefix "preservationFacsimileOf"
    /// <summary>
    ///   <para>skos:definition : An item used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOfItem</para>
    ///   <para>rdfs:label : Preservation facsimile of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfItem">rdarel:preservationFacsimileOfItem</a>
    /// </summary>
    let preservationFacsimileOfItem = _prefixId.prefix "preservationFacsimileOfItem"

    /// <summary>
    ///   <para>skos:definition : A manifestation used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOfManifestation</para>
    ///   <para>rdfs:label : Preservation facsimile of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/preservationFacsimileOfManifestation">rdarel:preservationFacsimileOfManifestation</a>
    /// </summary>
    let preservationFacsimileOfManifestation =
        _prefixId.prefix "preservationFacsimileOfManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOf</para>
    ///   <para>rdfs:label : Radio adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOf">rdarel:radioAdaptationOf</a>
    /// </summary>
    let radioAdaptationOf = _prefixId.prefix "radioAdaptationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOfExpression</para>
    ///   <para>rdfs:label : Radio adaptation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfExpression">rdarel:radioAdaptationOfExpression</a>
    /// </summary>
    let radioAdaptationOfExpression = _prefixId.prefix "radioAdaptationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a radio programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioAdaptationOfWork</para>
    ///   <para>rdfs:label : Radio adaptation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioAdaptationOfWork">rdarel:radioAdaptationOfWork</a>
    /// </summary>
    let radioAdaptationOfWork = _prefixId.prefix "radioAdaptationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScript</para>
    ///   <para>rdfs:label : Radio script</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioScript">rdarel:radioScript</a>
    /// </summary>
    let radioScript = _prefixId.prefix "radioScript"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOn</para>
    ///   <para>rdfs:label : Radio script based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOn">rdarel:radioScriptBasedOn</a>
    /// </summary>
    let radioScriptBasedOn = _prefixId.prefix "radioScriptBasedOn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as the script for a radio program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOnExpression </para>
    ///   <para>rdfs:label : Radio script based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnExpression">rdarel:radioScriptBasedOnExpression</a>
    /// </summary>
    let radioScriptBasedOnExpression = _prefixId.prefix "radioScriptBasedOnExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as the script for a radio programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptBasedOnWork</para>
    ///   <para>rdfs:label : Radio script based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptBasedOnWork">rdarel:radioScriptBasedOnWork</a>
    /// </summary>
    let radioScriptBasedOnWork = _prefixId.prefix "radioScriptBasedOnWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text for a radio programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : radioScriptExpression</para>
    ///   <para>rdfs:label : Radio script (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/radioScriptExpression">rdarel:radioScriptExpression</a>
    /// </summary>
    let radioScriptExpression = _prefixId.prefix "radioScriptExpression"
    /// <summary>
    ///   <para>skos:definition : A work related to the work represented by an identifier, a preferred access point, or a description (e.g., an adaptation, commentary, supplement, sequel, part of a larger work).</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedWork</para>
    ///   <para>rdfs:label : Related work</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/relatedWork">rdarel:relatedWork</a>
    /// </summary>
    let relatedWork = _prefixId.prefix "relatedWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAs</para>
    ///   <para>rdfs:label : Remade as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remadeAs">rdarel:remadeAs</a>
    /// </summary>
    let remadeAs = _prefixId.prefix "remadeAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a new motion picture, radio programme, television programme, or video based on an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAsExpression</para>
    ///   <para>rdfs:label : Remade as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsExpression">rdarel:remadeAsExpression</a>
    /// </summary>
    let remadeAsExpression = _prefixId.prefix "remadeAsExpression"
    /// <summary>
    ///   <para>skos:definition : A new motion picture, radio programme, television programme, or video based on an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remadeAsWork</para>
    ///   <para>rdfs:label : Remade as (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remadeAsWork">rdarel:remadeAsWork</a>
    /// </summary>
    let remadeAsWork = _prefixId.prefix "remadeAsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOf</para>
    ///   <para>rdfs:label : Remake of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remakeOf">rdarel:remakeOf</a>
    /// </summary>
    let remakeOf = _prefixId.prefix "remakeOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a new motion picture, radio programme, television programme, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOfExpression</para>
    ///   <para>rdfs:label : Remake of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfExpression">rdarel:remakeOfExpression</a>
    /// </summary>
    let remakeOfExpression = _prefixId.prefix "remakeOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a new motion picture, radio programme, television programme, or video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : remakeOfWork</para>
    ///   <para>rdfs:label : Remake of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/remakeOfWork">rdarel:remakeOfWork</a>
    /// </summary>
    let remakeOfWork = _prefixId.prefix "remakeOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOf</para>
    ///   <para>rdfs:label : Reprint of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reprintOf">rdarel:reprintOf</a>
    /// </summary>
    let reprintOf = _prefixId.prefix "reprintOf"
    /// <summary>
    ///   <para>skos:definition : An item that is used as the basis for a reprint with the same content as the resource being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOfItem</para>
    ///   <para>rdfs:label : Reprint of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfItem">rdarel:reprintOfItem</a>
    /// </summary>
    let reprintOfItem = _prefixId.prefix "reprintOfItem"
    /// <summary>
    ///   <para>skos:definition : A printed manifestation that is used as the basis for a reissue with the same content as the resource being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOfManifestation</para>
    ///   <para>rdfs:label : Reprint of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reprintOfManifestation">rdarel:reprintOfManifestation</a>
    /// </summary>
    let reprintOfManifestation = _prefixId.prefix "reprintOfManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintedAs</para>
    ///   <para>rdfs:label : Reprinted as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAs">rdarel:reprintedAs</a>
    /// </summary>
    let reprintedAs = _prefixId.prefix "reprintedAs"
    /// <summary>
    ///   <para>skos:definition : A manifestation that reissues the same expression of a work as the printed resource being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintedAsManifestation</para>
    ///   <para>rdfs:label : Reprinted as (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reprintedAsManifestation">rdarel:reprintedAsManifestation</a>
    /// </summary>
    let reprintedAsManifestation = _prefixId.prefix "reprintedAsManifestation"
    /// <summary>
    ///   <para>rdfs:label : Reproduced as</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproducedAs</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAs">rdarel:reproducedAs</a>
    /// </summary>
    let reproducedAs = _prefixId.prefix "reproducedAs"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproducedAsManifestation</para>
    ///   <para>skos:definition : A manifestation that reproduces another manifestation embodying the same expression of a work.</para>
    ///   <para>rdfs:label : Reproduced as (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reproducedAsManifestation">rdarel:reproducedAsManifestation</a>
    /// </summary>
    let reproducedAsManifestation = _prefixId.prefix "reproducedAsManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOf</para>
    ///   <para>rdfs:label : Reproduction of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOf">rdarel:reproductionOf</a>
    /// </summary>
    let reproductionOf = _prefixId.prefix "reproductionOf"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOfItem</para>
    ///   <para>skos:definition : A particular item used as the basis for a reproduction.</para>
    ///   <para>rdfs:label : Reproduction of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfItem">rdarel:reproductionOfItem</a>
    /// </summary>
    let reproductionOfItem = _prefixId.prefix "reproductionOfItem"
    /// <summary>
    ///   <para>rdfs:label : Reproduction of (Manifestation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOfManifestation</para>
    ///   <para>skos:definition : A manifestation used as the basis for a reproduction.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reproductionOfManifestation">rdarel:reproductionOfManifestation</a>
    /// </summary>
    let reproductionOfManifestation = _prefixId.prefix "reproductionOfManifestation"
    /// <summary>
    ///   <para>rdfs:label : Review of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOf</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewOf">rdarel:reviewOf</a>
    /// </summary>
    let reviewOf = _prefixId.prefix "reviewOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a summative evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfExpression</para>
    ///   <para>rdfs:label : Review of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfExpression">rdarel:reviewOfExpression</a>
    /// </summary>
    let reviewOfExpression = _prefixId.prefix "reviewOfExpression"
    /// <summary>
    ///   <para>skos:definition : An item used as the basis for a summative evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfItem</para>
    ///   <para>rdfs:label : Review of (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfItem">rdarel:reviewOfItem</a>
    /// </summary>
    let reviewOfItem = _prefixId.prefix "reviewOfItem"
    /// <summary>
    ///   <para>skos:definition : A manifestation used as the basis for a summative evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfManifestation</para>
    ///   <para>rdfs:label : Review of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfManifestation">rdarel:reviewOfManifestation</a>
    /// </summary>
    let reviewOfManifestation = _prefixId.prefix "reviewOfManifestation"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a summative evaluation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewOfWork</para>
    ///   <para>rdfs:label : Review of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewOfWork">rdarel:reviewOfWork</a>
    /// </summary>
    let reviewOfWork = _prefixId.prefix "reviewOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedIn</para>
    ///   <para>rdfs:label : Reviewed in</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewedIn">rdarel:reviewedIn</a>
    /// </summary>
    let reviewedIn = _prefixId.prefix "reviewedIn"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that contains a summative evaluation of the described entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInExpression</para>
    ///   <para>rdfs:label : Reviewed in (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInExpression">rdarel:reviewedInExpression</a>
    /// </summary>
    let reviewedInExpression = _prefixId.prefix "reviewedInExpression"
    /// <summary>
    ///   <para>skos:definition : A work that contains a summative evaluation of the described work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInWork</para>
    ///   <para>rdfs:label : Reviewed in (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/reviewedInWork">rdarel:reviewedInWork</a>
    /// </summary>
    let reviewedInWork = _prefixId.prefix "reviewedInWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisionOf</para>
    ///   <para>rdfs:label : Revision of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/revisionOf">rdarel:revisionOf</a>
    /// </summary>
    let revisionOf = _prefixId.prefix "revisionOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for an updated, corrected, or expanded version.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : revisionOfExpression</para>
    ///   <para>rdfs:label : Revision of (expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/revisionOfExpression">rdarel:revisionOfExpression</a>
    /// </summary>
    let revisionOfExpression = _prefixId.prefix "revisionOfExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplay</para>
    ///   <para>rdfs:label : Screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplay">rdarel:screenplay</a>
    /// </summary>
    let screenplay = _prefixId.prefix "screenplay"
    /// <summary>
    ///   <para>rdfs:label : Screenplay based on</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOn</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOn">rdarel:screenplayBasedOn</a>
    /// </summary>
    let screenplayBasedOn = _prefixId.prefix "screenplayBasedOn"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOnExpression</para>
    ///   <para>skos:definition : An expression of a work that has been adapted as the screenplay for a motion picture, television program, or video.</para>
    ///   <para>rdfs:label : Screenplay based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnExpression">rdarel:screenplayBasedOnExpression</a>
    /// </summary>
    let screenplayBasedOnExpression = _prefixId.prefix "screenplayBasedOnExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as the screenplay for a motion picture, television programme, or video.</para>
    ///   <para>rdfs:label : Screenplay based on (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayBasedOnWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayBasedOnWork">rdarel:screenplayBasedOnWork</a>
    /// </summary>
    let screenplayBasedOnWork = _prefixId.prefix "screenplayBasedOnWork"
    /// <summary>
    ///   <para>rdfs:label : Screenplay (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayExpression</para>
    ///   <para>skos:definition : An expression of a work that provides the text for a motion picture, television programme or video.</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayExpression">rdarel:screenplayExpression</a>
    /// </summary>
    let screenplayExpression = _prefixId.prefix "screenplayExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayFor</para>
    ///   <para>rdfs:label : Screenplay for</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayFor">rdarel:screenplayFor</a>
    /// </summary>
    let screenplayFor = _prefixId.prefix "screenplayFor"
    /// <summary>
    ///   <para>rdfs:label : Screenplay for (Expression)</para>
    ///   <para>skos:definition : An expression of a work such as a motion picture, television programme, or video, that uses the text of the work as a screenplay.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForExpression">rdarel:screenplayForExpression</a>
    /// </summary>
    let screenplayForExpression = _prefixId.prefix "screenplayForExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPicture</para>
    ///   <para>rdfs:label : Screenplay for the motion picture</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPicture">rdarel:screenplayForTheMotionPicture</a>
    /// </summary>
    let screenplayForTheMotionPicture = _prefixId.prefix "screenplayForTheMotionPicture"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that uses the text as a screenplay for a motion picture.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPictureExpression</para>
    ///   <para>rdfs:label : Screenplay for the motion picture (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureExpression">rdarel:screenplayForTheMotionPictureExpression</a>
    /// </summary>
    let screenplayForTheMotionPictureExpression =
        _prefixId.prefix "screenplayForTheMotionPictureExpression"

    /// <summary>
    ///   <para>skos:definition : A work that adapts the source work as the screenplay for a motion picture work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheMotionPictureWork</para>
    ///   <para>rdfs:label : Screenplay for the motion picture (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheMotionPictureWork">rdarel:screenplayForTheMotionPictureWork</a>
    /// </summary>
    let screenplayForTheMotionPictureWork =
        _prefixId.prefix "screenplayForTheMotionPictureWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgramme</para>
    ///   <para>rdfs:label : Screenplay for the television programme</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgramme">rdarel:screenplayForTheTelevisionProgramme</a>
    /// </summary>
    let screenplayForTheTelevisionProgramme =
        _prefixId.prefix "screenplayForTheTelevisionProgramme"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that uses the text as a screenplay for a television programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgrammeExpression</para>
    ///   <para>rdfs:label : Screenplay for the television programme (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeExpression">rdarel:screenplayForTheTelevisionProgrammeExpression</a>
    /// </summary>
    let screenplayForTheTelevisionProgrammeExpression =
        _prefixId.prefix "screenplayForTheTelevisionProgrammeExpression"

    /// <summary>
    ///   <para>skos:definition : A work that adapts the source work as the screenplay for a television program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheTelevisionProgrammeWork</para>
    ///   <para>rdfs:label : Screenplay for the television programme (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheTelevisionProgrammeWork">rdarel:screenplayForTheTelevisionProgrammeWork</a>
    /// </summary>
    let screenplayForTheTelevisionProgrammeWork =
        _prefixId.prefix "screenplayForTheTelevisionProgrammeWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideo</para>
    ///   <para>rdfs:label : Screenplay for the video</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideo">rdarel:screenplayForTheVideo</a>
    /// </summary>
    let screenplayForTheVideo = _prefixId.prefix "screenplayForTheVideo"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that uses the text as a screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideoExpression</para>
    ///   <para>rdfs:label : Screenplay for the video (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoExpression">rdarel:screenplayForTheVideoExpression</a>
    /// </summary>
    let screenplayForTheVideoExpression =
        _prefixId.prefix "screenplayForTheVideoExpression"

    /// <summary>
    ///   <para>skos:definition : A work that adapts the source work as the screenplay for a video work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForTheVideoWork</para>
    ///   <para>rdfs:label : Screenplay for the video (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForTheVideoWork">rdarel:screenplayForTheVideoWork</a>
    /// </summary>
    let screenplayForTheVideoWork = _prefixId.prefix "screenplayForTheVideoWork"
    /// <summary>
    ///   <para>rdfs:label : Screenplay for (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : screenplayForWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/screenplayForWork">rdarel:screenplayForWork</a>
    /// </summary>
    let screenplayForWork = _prefixId.prefix "screenplayForWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgramme</para>
    ///   <para>rdfs:label : Script for the radio programme</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgramme">rdarel:scriptForTheRadioProgramme</a>
    /// </summary>
    let scriptForTheRadioProgramme = _prefixId.prefix "scriptForTheRadioProgramme"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that uses the text of the source work as the script for a radio programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgrammeExpression</para>
    ///   <para>rdfs:label : Script for the radio programme (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeExpression">rdarel:scriptForTheRadioProgrammeExpression</a>
    /// </summary>
    let scriptForTheRadioProgrammeExpression =
        _prefixId.prefix "scriptForTheRadioProgrammeExpression"

    /// <summary>
    ///   <para>skos:definition : A work that adapts the source work as the script for a radio
    /// program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : scriptForTheRadioProgrammeWork</para>
    ///   <para>rdfs:label : Script for the radio programme (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/scriptForTheRadioProgrammeWork">rdarel:scriptForTheRadioProgrammeWork</a>
    /// </summary>
    let scriptForTheRadioProgrammeWork =
        _prefixId.prefix "scriptForTheRadioProgrammeWork"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFrom</para>
    ///   <para>rdfs:label : Separated from</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/separatedFrom">rdarel:separatedFrom</a>
    /// </summary>
    let separatedFrom = _prefixId.prefix "separatedFrom"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that spun off a part of its content to form a new entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFromExpression</para>
    ///   <para>rdfs:label : Separated from (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromExpression">rdarel:separatedFromExpression</a>
    /// </summary>
    let separatedFromExpression = _prefixId.prefix "separatedFromExpression"
    /// <summary>
    ///   <para>skos:definition : A work that spun off a part of its content to form a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : separatedFromWork</para>
    ///   <para>rdfs:label : Separated from (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/separatedFromWork">rdarel:separatedFromWork</a>
    /// </summary>
    let separatedFromWork = _prefixId.prefix "separatedFromWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequel</para>
    ///   <para>rdfs:label : Sequel</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequel">rdarel:sequel</a>
    /// </summary>
    let sequel = _prefixId.prefix "sequel"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequelTo</para>
    ///   <para>rdfs:label : Sequel to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequelTo">rdarel:sequelTo</a>
    /// </summary>
    let sequelTo = _prefixId.prefix "sequelTo"
    /// <summary>
    ///   <para>skos:definition : A work whose narrative is continued by a later work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequelToWork</para>
    ///   <para>rdfs:label : Sequel to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequelToWork">rdarel:sequelToWork</a>
    /// </summary>
    let sequelToWork = _prefixId.prefix "sequelToWork"
    /// <summary>
    ///   <para>skos:definition : A later work that continues the narrative of an earlier work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequelWork</para>
    ///   <para>rdfs:label : Sequel (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequelWork">rdarel:sequelWork</a>
    /// </summary>
    let sequelWork = _prefixId.prefix "sequelWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialRelationship</para>
    ///   <para>rdfs:label : Sequential relationship</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationship">rdarel:sequentialRelationship</a>
    /// </summary>
    let sequentialRelationship = _prefixId.prefix "sequentialRelationship"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialRelationshipExpression</para>
    ///   <para>rdfs:label : Sequential relationship (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipExpression">rdarel:sequentialRelationshipExpression</a>
    /// </summary>
    let sequentialRelationshipExpression =
        _prefixId.prefix "sequentialRelationshipExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialRelationshipItem</para>
    ///   <para>rdfs:label : Sequential relationship (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipItem">rdarel:sequentialRelationshipItem</a>
    /// </summary>
    let sequentialRelationshipItem = _prefixId.prefix "sequentialRelationshipItem"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialRelationshipManifestation</para>
    ///   <para>rdfs:label : Sequential relationship (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipManifestation">rdarel:sequentialRelationshipManifestation</a>
    /// </summary>
    let sequentialRelationshipManifestation =
        _prefixId.prefix "sequentialRelationshipManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : sequentialRelationshipWork</para>
    ///   <para>rdfs:label : Sequential relationship (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/sequentialRelationshipWork">rdarel:sequentialRelationshipWork</a>
    /// </summary>
    let sequentialRelationshipWork = _prefixId.prefix "sequentialRelationshipWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesContains</para>
    ///   <para>rdfs:label : Series contains</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/seriesContains">rdarel:seriesContains</a>
    /// </summary>
    let seriesContains = _prefixId.prefix "seriesContains"
    /// <summary>
    ///   <para>skos:definition : A work that has been issued as part of a series.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seriesContainsWork</para>
    ///   <para>rdfs:label : Series contains (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/seriesContainsWork">rdarel:seriesContainsWork</a>
    /// </summary>
    let seriesContainsWork = _prefixId.prefix "seriesContainsWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssue</para>
    ///   <para>rdfs:label : Special issue</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/specialIssue">rdarel:specialIssue</a>
    /// </summary>
    let specialIssue = _prefixId.prefix "specialIssue"
    /// <summary>
    ///   <para>skos:definition : A manifestation that comprises a single issue or a supplementary section of a serial or newspaper devoted to a special subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssueManifestation</para>
    ///   <para>rdfs:label : Special issue (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueManifestation">rdarel:specialIssueManifestation</a>
    /// </summary>
    let specialIssueManifestation = _prefixId.prefix "specialIssueManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssueOf</para>
    ///   <para>rdfs:label : Special issue of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOf">rdarel:specialIssueOf</a>
    /// </summary>
    let specialIssueOf = _prefixId.prefix "specialIssueOf"
    /// <summary>
    ///   <para>skos:definition : A serial or newspaper containing a single issue or a supplementary section devoted to a special subject, with or without serial numbering, such as an anniversary number of a periodical or newspaper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : specialIssueOfManifestation</para>
    ///   <para>rdfs:label : Special issue of (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/specialIssueOfManifestation">rdarel:specialIssueOfManifestation</a>
    /// </summary>
    let specialIssueOfManifestation = _prefixId.prefix "specialIssueOfManifestation"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitInto</para>
    ///   <para>rdfs:label : Split into</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/splitInto">rdarel:splitInto</a>
    /// </summary>
    let splitInto = _prefixId.prefix "splitInto"
    /// <summary>
    ///   <para>skos:definition : An expression of one of two or more works resulting from the division of an earlier entity into separate entities.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitIntoExpression</para>
    ///   <para>rdfs:label : Split into (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoExpression">rdarel:splitIntoExpression</a>
    /// </summary>
    let splitIntoExpression = _prefixId.prefix "splitIntoExpression"
    /// <summary>
    ///   <para>skos:definition : One of two or more works resulting from the division of an earlier work into separate works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : splitIntoWork</para>
    ///   <para>rdfs:label : Split into (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/splitIntoWork">rdarel:splitIntoWork</a>
    /// </summary>
    let splitIntoWork = _prefixId.prefix "splitIntoWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseries</para>
    ///   <para>rdfs:label : Subseries</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/subseries">rdarel:subseries</a>
    /// </summary>
    let subseries = _prefixId.prefix "subseries"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseriesOf</para>
    ///   <para>rdfs:label : Subseries of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOf">rdarel:subseriesOf</a>
    /// </summary>
    let subseriesOf = _prefixId.prefix "subseriesOf"
    /// <summary>
    ///   <para>skos:definition : A work in which the part consistently appears; all issues or parts of the subseries bear the title of the larger work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseriesOfWork</para>
    ///   <para>rdfs:label : Subseries of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/subseriesOfWork">rdarel:subseriesOfWork</a>
    /// </summary>
    let subseriesOfWork = _prefixId.prefix "subseriesOfWork"
    /// <summary>
    ///   <para>skos:definition : A serial or multipart work that consistently appears in a larger work; all issues or parts of the subseries bear the title of the larger work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subseriesWork</para>
    ///   <para>rdfs:label : Subseries (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/subseriesWork">rdarel:subseriesWork</a>
    /// </summary>
    let subseriesWork = _prefixId.prefix "subseriesWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededBy</para>
    ///   <para>rdfs:label : Succeeded by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/succeededBy">rdarel:succeededBy</a>
    /// </summary>
    let succeededBy = _prefixId.prefix "succeededBy"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that succeeds (e.g., later in time or after in a narrative) the preceding entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededByExpression</para>
    ///   <para>rdfs:label : Succeeded by (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/succeededByExpression">rdarel:succeededByExpression</a>
    /// </summary>
    let succeededByExpression = _prefixId.prefix "succeededByExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : succeededByWork</para>
    ///   <para>skos:definition : A work that succeeds (e.g., later in time or after in a narrative) the preceding work. </para>
    ///   <para>rdfs:comment : For sequentially numbered works with revised content.</para>
    ///   <para>rdfs:label : Succeeded by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/succeededByWork">rdarel:succeededByWork</a>
    /// </summary>
    let succeededByWork = _prefixId.prefix "succeededByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summary</para>
    ///   <para>rdfs:label : Summary</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summary">rdarel:summary</a>
    /// </summary>
    let summary = _prefixId.prefix "summary"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that comprises a brief recapitulation of the content of the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryExpression</para>
    ///   <para>rdfs:label : Summary (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summaryExpression">rdarel:summaryExpression</a>
    /// </summary>
    let summaryExpression = _prefixId.prefix "summaryExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOf</para>
    ///   <para>rdfs:label : Summary of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summaryOf">rdarel:summaryOf</a>
    /// </summary>
    let summaryOf = _prefixId.prefix "summaryOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work used as the basis for a brief recapitulation of its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOfExpression</para>
    ///   <para>rdfs:label : Summary of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfExpression">rdarel:summaryOfExpression</a>
    /// </summary>
    let summaryOfExpression = _prefixId.prefix "summaryOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work used as the basis for a brief recapitulation of its content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryOfWork</para>
    ///   <para>rdfs:label : Summary of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summaryOfWork">rdarel:summaryOfWork</a>
    /// </summary>
    let summaryOfWork = _prefixId.prefix "summaryOfWork"
    /// <summary>
    ///   <para>skos:definition : A work that comprises a brief recapitulation of the content of the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : summaryWork</para>
    ///   <para>rdfs:label : Summary (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/summaryWork">rdarel:summaryWork</a>
    /// </summary>
    let summaryWork = _prefixId.prefix "summaryWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededBy</para>
    ///   <para>rdfs:label : Superseded by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededBy">rdarel:supersededBy</a>
    /// </summary>
    let supersededBy = _prefixId.prefix "supersededBy"
    /// <summary>
    ///   <para>rdfs:label : Superseded by (Expression)</para>
    ///   <para>skos:definition : An expression of a later entity used in place of the earlier entity, usually because the later entity contains updated or new information that makes the earlier entity obsolete. </para>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededByExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededByExpression">rdarel:supersededByExpression</a>
    /// </summary>
    let supersededByExpression = _prefixId.prefix "supersededByExpression"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>skos:definition : A later work used in place of an earlier work, usually because the later work contains updated or new information that makes the earlier work obsolete. </para>
    ///   <para>rdfs:label : Superseded by (Work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededByWork</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededByWork">rdarel:supersededByWork</a>
    /// </summary>
    let supersededByWork = _prefixId.prefix "supersededByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededInPartBy</para>
    ///   <para>rdfs:label : Superseded in part by</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartBy">rdarel:supersededInPartBy</a>
    /// </summary>
    let supersededInPartBy = _prefixId.prefix "supersededInPartBy"
    /// <summary>
    ///   <para>skos:definition : An expression of a later entity used in part in place of the earlier entity, usually because the later entity contains updated or new
    /// information that makes part of the earlier entity obsolete. </para>
    ///   <para>rdfs:label : Superseded in part by (Expression)</para>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededInPartByExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByExpression">rdarel:supersededInPartByExpression</a>
    /// </summary>
    let supersededInPartByExpression = _prefixId.prefix "supersededInPartByExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersededInPartByWork</para>
    ///   <para>skos:definition : A later work used in part in place of an earlier work, usually because the later work contains updated or new information that makes part of the earlier work obsolete. </para>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>rdfs:label : Superseded in part by (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersededInPartByWork">rdarel:supersededInPartByWork</a>
    /// </summary>
    let supersededInPartByWork = _prefixId.prefix "supersededInPartByWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedes</para>
    ///   <para>rdfs:label : Supersedes</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedes">rdarel:supersedes</a>
    /// </summary>
    let supersedes = _prefixId.prefix "supersedes"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>skos:definition : An expression of an earlier work whose content has been replaced by a later entity, usually because the later entity contains updated or new information that makes the earlier entity obsolete. </para>
    ///   <para>rdfs:label : Supersedes (Expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedesExpression</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedesExpression">rdarel:supersedesExpression</a>
    /// </summary>
    let supersedesExpression = _prefixId.prefix "supersedesExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedesInPart</para>
    ///   <para>rdfs:label : Supersedes in part</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPart">rdarel:supersedesInPart</a>
    /// </summary>
    let supersedesInPart = _prefixId.prefix "supersedesInPart"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedesInPartExpression</para>
    ///   <para>skos:definition : An expression of an earlier work whose content has been partially replaced by a later entity, usually because the later entity contains updated or new information that makes part of the earlier entity obsolete.</para>
    ///   <para>rdfs:label : Supersedes in part (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartExpression">rdarel:supersedesInPartExpression</a>
    /// </summary>
    let supersedesInPartExpression = _prefixId.prefix "supersedesInPartExpression"
    /// <summary>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedesInPartWork</para>
    ///   <para>rdfs:label : Supersedes in part (Work)</para>
    ///   <para>skos:definition : An earlier work whose content has been partially replaced by a later work, usually because the later work contains updated or new information that makes part of the earlier work obsolete. </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedesInPartWork">rdarel:supersedesInPartWork</a>
    /// </summary>
    let supersedesInPartWork = _prefixId.prefix "supersedesInPartWork"
    /// <summary>
    ///   <para>rdfs:label : Supersedes (Work)</para>
    ///   <para>rdfs:comment : Apply generally to single-part units, multipart monographs, and integrating resources.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supersedesWork</para>
    ///   <para>skos:definition : An earlier work whose content has been replaced by a later work, usually because the later work contains updated or new information that makes the earlier work obsolete. </para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supersedesWork">rdarel:supersedesWork</a>
    /// </summary>
    let supersedesWork = _prefixId.prefix "supersedesWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplement</para>
    ///   <para>rdfs:label : Supplement</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplement">rdarel:supplement</a>
    /// </summary>
    let supplement = _prefixId.prefix "supplement"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that updates or otherwise complements the predominant entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementExpression</para>
    ///   <para>rdfs:label : Supplement (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplementExpression">rdarel:supplementExpression</a>
    /// </summary>
    let supplementExpression = _prefixId.prefix "supplementExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementTo</para>
    ///   <para>rdfs:label : Supplement to</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplementTo">rdarel:supplementTo</a>
    /// </summary>
    let supplementTo = _prefixId.prefix "supplementTo"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that is updated or otherwise complemented by the augmenting entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementToExpression</para>
    ///   <para>rdfs:label : Supplement to (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplementToExpression">rdarel:supplementToExpression</a>
    /// </summary>
    let supplementToExpression = _prefixId.prefix "supplementToExpression"
    /// <summary>
    ///   <para>skos:definition : A work that is updated or otherwise complemented by the augmenting work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementToWork</para>
    ///   <para>rdfs:label : Supplement to (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplementToWork">rdarel:supplementToWork</a>
    /// </summary>
    let supplementToWork = _prefixId.prefix "supplementToWork"
    /// <summary>
    ///   <para>skos:definition : A work that updates or otherwise complements the predominant work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementWork</para>
    ///   <para>rdfs:label : Supplement (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/supplementWork">rdarel:supplementWork</a>
    /// </summary>
    let supplementWork = _prefixId.prefix "supplementWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOf</para>
    ///   <para>rdfs:label : Television adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOf">rdarel:televisionAdaptationOf</a>
    /// </summary>
    let televisionAdaptationOf = _prefixId.prefix "televisionAdaptationOf"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a television
    /// program.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOfExpression</para>
    ///   <para>rdfs:label : Television adaptation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfExpression">rdarel:televisionAdaptationOfExpression</a>
    /// </summary>
    let televisionAdaptationOfExpression =
        _prefixId.prefix "televisionAdaptationOfExpression"

    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a television programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionAdaptationOfWork</para>
    ///   <para>rdfs:label : Television adaptation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionAdaptationOfWork">rdarel:televisionAdaptationOfWork</a>
    /// </summary>
    let televisionAdaptationOfWork = _prefixId.prefix "televisionAdaptationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplay</para>
    ///   <para>rdfs:label : Television screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplay">rdarel:televisionScreenplay</a>
    /// </summary>
    let televisionScreenplay = _prefixId.prefix "televisionScreenplay"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOn</para>
    ///   <para>rdfs:label : Television screenplay based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOn">rdarel:televisionScreenplayBasedOn</a>
    /// </summary>
    let televisionScreenplayBasedOn = _prefixId.prefix "televisionScreenplayBasedOn"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as the screenplay for a television programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOnExpression</para>
    ///   <para>rdfs:label : Television screenplay based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnExpression">rdarel:televisionScreenplayBasedOnExpression</a>
    /// </summary>
    let televisionScreenplayBasedOnExpression =
        _prefixId.prefix "televisionScreenplayBasedOnExpression"

    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as the screenplay for a television programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayBasedOnWork</para>
    ///   <para>rdfs:label : Television screenplay based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayBasedOnWork">rdarel:televisionScreenplayBasedOnWork</a>
    /// </summary>
    let televisionScreenplayBasedOnWork =
        _prefixId.prefix "televisionScreenplayBasedOnWork"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text for a television programme.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : televisionScreenplayExpression</para>
    ///   <para>rdfs:label : Television screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/televisionScreenplayExpression">rdarel:televisionScreenplayExpression</a>
    /// </summary>
    let televisionScreenplayExpression =
        _prefixId.prefix "televisionScreenplayExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatedAs</para>
    ///   <para>rdfs:label : Translated as</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/translatedAs">rdarel:translatedAs</a>
    /// </summary>
    let translatedAs = _prefixId.prefix "translatedAs"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that renders the text of the source entity into a language different from that of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translatedAsExpression</para>
    ///   <para>rdfs:label : Translated as (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/translatedAsExpression">rdarel:translatedAsExpression</a>
    /// </summary>
    let translatedAsExpression = _prefixId.prefix "translatedAsExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translationOf</para>
    ///   <para>rdfs:label : Translation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/translationOf">rdarel:translationOf</a>
    /// </summary>
    let translationOf = _prefixId.prefix "translationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been translated, i.e., the text rendered into a language different from that of the original work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : translationOfExpression</para>
    ///   <para>rdfs:label : Translation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/translationOfExpression">rdarel:translationOfExpression</a>
    /// </summary>
    let translationOfExpression = _prefixId.prefix "translationOfExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptation</para>
    ///   <para>rdfs:label : Verse adaptation</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptation">rdarel:verseAdaptation</a>
    /// </summary>
    let verseAdaptation = _prefixId.prefix "verseAdaptation"
    /// <summary>
    ///   <para>skos:definition : An expression of a literary composition in verse form adapted from the source entity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationExpression</para>
    ///   <para>rdfs:label : Verse adaptation (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationExpression">rdarel:verseAdaptationExpression</a>
    /// </summary>
    let verseAdaptationExpression = _prefixId.prefix "verseAdaptationExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOf</para>
    ///   <para>rdfs:label : Verse adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOf">rdarel:verseAdaptationOf</a>
    /// </summary>
    let verseAdaptationOf = _prefixId.prefix "verseAdaptationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as a literary composition in verse form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOfExpression</para>
    ///   <para>rdfs:label : Verse adaptation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfExpression">rdarel:verseAdaptationOfExpression</a>
    /// </summary>
    let verseAdaptationOfExpression = _prefixId.prefix "verseAdaptationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as a literary composition in verse form.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationOfWork</para>
    ///   <para>rdfs:label : Verse adaptation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationOfWork">rdarel:verseAdaptationOfWork</a>
    /// </summary>
    let verseAdaptationOfWork = _prefixId.prefix "verseAdaptationOfWork"
    /// <summary>
    ///   <para>skos:definition : A literary composition in verse form adapted from the source work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : verseAdaptationWork</para>
    ///   <para>rdfs:label : Verse adaptation (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/verseAdaptationWork">rdarel:verseAdaptationWork</a>
    /// </summary>
    let verseAdaptationWork = _prefixId.prefix "verseAdaptationWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOf</para>
    ///   <para>rdfs:label : Video adaptation of</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOf">rdarel:videoAdaptationOf</a>
    /// </summary>
    let videoAdaptationOf = _prefixId.prefix "videoAdaptationOf"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted for video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOfExpression</para>
    ///   <para>rdfs:label : Video adaptation of (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfExpression">rdarel:videoAdaptationOfExpression</a>
    /// </summary>
    let videoAdaptationOfExpression = _prefixId.prefix "videoAdaptationOfExpression"
    /// <summary>
    ///   <para>skos:definition : A work that has been adapted for video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoAdaptationOfWork</para>
    ///   <para>rdfs:label : Video adaptation of (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoAdaptationOfWork">rdarel:videoAdaptationOfWork</a>
    /// </summary>
    let videoAdaptationOfWork = _prefixId.prefix "videoAdaptationOfWork"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplay</para>
    ///   <para>rdfs:label : Video screenplay</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplay">rdarel:videoScreenplay</a>
    /// </summary>
    let videoScreenplay = _prefixId.prefix "videoScreenplay"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOn</para>
    ///   <para>rdfs:label : Video screenplay based on</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOn">rdarel:videoScreenplayBasedOn</a>
    /// </summary>
    let videoScreenplayBasedOn = _prefixId.prefix "videoScreenplayBasedOn"

    /// <summary>
    ///   <para>skos:definition : An expression of a work that has been adapted as the screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOnExpression</para>
    ///   <para>rdfs:label : Video screenplay based on (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnExpression">rdarel:videoScreenplayBasedOnExpression</a>
    /// </summary>
    let videoScreenplayBasedOnExpression =
        _prefixId.prefix "videoScreenplayBasedOnExpression"

    /// <summary>
    ///   <para>skos:definition : A work that has been adapted as the screenplay for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayBasedOnWork</para>
    ///   <para>rdfs:label : Video screenplay based on (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayBasedOnWork">rdarel:videoScreenplayBasedOnWork</a>
    /// </summary>
    let videoScreenplayBasedOnWork = _prefixId.prefix "videoScreenplayBasedOnWork"
    /// <summary>
    ///   <para>skos:definition : An expression of a work that provides the text for a video.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : videoScreenplayExpression</para>
    ///   <para>rdfs:label : Video screenplay (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/videoScreenplayExpression">rdarel:videoScreenplayExpression</a>
    /// </summary>
    let videoScreenplayExpression = _prefixId.prefix "videoScreenplayExpression"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartRelationship</para>
    ///   <para>rdfs:label : Whole-part relationship</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationship">rdarel:wholePartRelationship</a>
    /// </summary>
    let wholePartRelationship = _prefixId.prefix "wholePartRelationship"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartRelationshipExpression</para>
    ///   <para>rdfs:label : Whole-part relationship (Expression)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipExpression">rdarel:wholePartRelationshipExpression</a>
    /// </summary>
    let wholePartRelationshipExpression =
        _prefixId.prefix "wholePartRelationshipExpression"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartRelationshipItem</para>
    ///   <para>rdfs:label : Whole-part relationship (Item)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipItem">rdarel:wholePartRelationshipItem</a>
    /// </summary>
    let wholePartRelationshipItem = _prefixId.prefix "wholePartRelationshipItem"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartRelationshipManifestation</para>
    ///   <para>rdfs:label : Whole-part relationship (Manifestation)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipManifestation">rdarel:wholePartRelationshipManifestation</a>
    /// </summary>
    let wholePartRelationshipManifestation =
        _prefixId.prefix "wholePartRelationshipManifestation"

    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartRelationshipWork</para>
    ///   <para>rdfs:label : Whole-part relationship (Work)</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/wholePartRelationshipWork">rdarel:wholePartRelationshipWork</a>
    /// </summary>
    let wholePartRelationshipWork = _prefixId.prefix "wholePartRelationshipWork"
    /// <summary>
    ///   <para>skos:definition : A work embodied in a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : workManifested</para>
    ///   <para>rdfs:label : Work manifested</para>
    ///   <a href="http://rdvocab.info/RDARelationshipsWEMI/workManifested">rdarel:workManifested</a>
    /// </summary>
    let workManifested = _prefixId.prefix "workManifested"
