#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module frbrer =
    let _prefixId = PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/fr/frbr/frbrer/" "frbrer"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:scopeNote : A work is an abstract entity; there is no single material object one can point to as the work. We recognize the work through individual realizations or expressions of the work, but the work itself exists only in the commonality of content between and among the various expressions of the work. Because the notion of a work is abstract, it is difficult to define precise boundaries for the entity. The concept of what constitutes a work and where the line of demarcation lies between one work and another may in fact be viewed differently from one culture to another. Consequently the bibliographic conventions established by various cultures or national groups may differ in terms of the criteria they use for determining the boundaries between one work and another. For the purposes of this model variant texts incorporating revisions or updates to an earlier text are viewed simply as expressions of the same work (i.e., the variant texts are not viewed as separate works). Similarly, abridgements or enlargements of an existing text, or the addition of parts or an accompaniment to a musical composition are considered to be different expressions of the same work. Translations from one language to another, musical transcriptions and arrangements, and dubbed or subtitled versions of a film are also considered simply as different expressions of the same original work. By contrast, when the modification of a work involves a significant degree of independent intellectual or artistic effort, the result is viewed, for the purpose of this model, as a new work. Thus paraphrases, rewritings, adaptations for children, parodies, musical variations on a theme and free transcriptions of a musical composition are considered to represent new works. Similarly, adaptations of a work from one literary or art form to another (e.g., dramatizations, adaptations from one medium of the graphic arts to another, etc.) are considered to represent new works. Abstracts, digests and summaries are also considered to represent new works.</para>
    ///   <para>skos:definition : A distinct intellectual or artistic creation.</para>
    ///   <para>rdfs:label : Obrardfs:label : Work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Work</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1001">frbrer:C1001</a>
    /// </summary>
    let C1001 = _prefixId.prefix "C1001"
    /// <summary>
    ///   <para>skos:scopeNote : An expression is the specific intellectual or artistic form that a work takes each time it is "realized". Expression encompasses, for example, the specific words, sentences, paragraphs, etc. that result from the realization of a work in the form of a text, or the particular sounds, phrasing, etc. resulting from the realization of a musical work. The boundaries of the entity expression are defined, however, so as to exclude aspects of physical form, such as typeface and page layout, that are not integral to the intellectual or artistic realization of the work as such. Inasmuch as the form of expression is an inherent characteristic of the expression, any change in form (e.g., from alpha-numeric notation to spoken word) results in a new expression. Similarly, changes in the intellectual conventions or instruments that are employed to express a work (e.g., translation from one language to another) result in the production of a new expression. If a text is revised or modified, the resulting expression is considered to be a new expression. The degree to which bibliographic distinctions are made between variant expressions of a work will depend to some extent on the nature of the work itself, on the anticipated needs of users and on what the cataloguer can reasonably be expected to recognize from the manifestation being described. Differences in form of expression (e.g., the differences between the expression of a work in the form of musical notation and the expression of the same work in the form of recorded sound) will normally be reflected in the bibliographic record, no matter what the nature of the work itself may be. Variant expressions in the same form (e.g., revised versions of a text) will often be indirectly identified as different expressions because the variation is apparent from the data associated with an attribute used to identify the manifestation in which the expression is embodied (e.g., an edition statement). Variations that would be evident only from a more detailed analysis and comparison of expressions (e.g., variations between several of the early texts of Shakespeare's Hamlet) would normally be reflected in the data only if the nature or stature of the work warranted such analysis, and only if it was anticipated that the distinction would be important to users.</para>
    ///   <para>skos:definition : The intellectual or artistic realization of a work in the form of alpha-numeric, musical, or choreographic notation, sound, image, object, movement, etc., or any combination of such forms.</para>
    ///   <para>rdfs:label : ExpresiÃ³nrdfs:label : Expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Expression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1002">frbrer:C1002</a>
    /// </summary>
    let C1002 = _prefixId.prefix "C1002"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as manifestation encompasses a wide range of materials, including manuscripts, books, periodicals, maps, posters, sound recordings, films, video recordings, CD-ROMs, multimedia kits, etc. As an entity, manifestation represents all the physical objects that bear the same characteristics, in respect to both intellectual content and physical form. When a work is realized, the resulting expression of the work may be physically embodied on or in a medium such as paper, audio tape, video tape, canvas, plaster, etc. That physical embodiment constitutes a manifestation of the work. In some cases there may be only a single physical exemplar produced of that manifestation of the work (e.g., an author's manuscript, a tape recorded for an oral history archive, an original oil painting, etc.). In other cases there are multiple copies produced in order to facilitate public dissemination or distribution. In those cases there is normally a more formal production process involved, and a publisher, producer, or distributor takes responsibility for the process. In other cases there may be only a limited number of copies made of an original exemplar for purposes such as private study (e.g., a dubbing of an original recording of a piece of music), or preservation (e.g., a photocopy produced on permanent paper of an author's original typescript). Whether the scope of production is broad (e.g., in the case of publication, etc.) or limited (e.g., in the case of copies made for private study, etc.), the set of copies produced in each case constitutes a manifestation. All copies produced that form part of the same set are considered to be copies of the same manifestation. The boundaries between one manifestation and another are drawn on the basis of both intellectual content and physical form. When the production process involves changes in physical form the resulting product is considered a new manifestation. Changes in physical form include changes affecting display characteristics (e.g., a change in typeface, size of font, page layout, etc.), changes in physical medium (e.g., a change from paper to microfilm as the medium of conveyance), and changes in the container (e.g., a change from cassette to cartridge as the container for a tape). Where the production process involves a publisher, producer, distributor, etc., and there are changes signalled in the product that are related to publication, marketing, etc. (e.g., a change in publisher, repackaging, etc.), the resulting product may be considered a new manifestation. Whenever the production process involves modifications, additions, deletions, etc. that affect the intellectual or artistic content, the result is a new manifestation embodying a new expression of the work. Changes that occur deliberately or even inadvertently in the production process that affect the copies result, strictly speaking, in a new manifestation. A manifestation resulting from such a change may be identified as a particular "state" or "issue" of the publication. Changes that occur to an individual copy after the production process is complete (e.g., the loss of a page, rebinding, etc.) are not considered to result in a new manifestation. That copy is simply considered to be an exemplar (or item) of the manifestation that deviates from the copy as produced.</para>
    ///   <para>skos:definition : The physical embodiment of an expression of a work.</para>
    ///   <para>rdfs:label : ManifestaciÃ³nrdfs:label : Manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Manifestation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1003">frbrer:C1003</a>
    /// </summary>
    let C1003 = _prefixId.prefix "C1003"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as item is a concrete entity. It is in many instances a single physical object (e.g., a copy of a one-volume monograph, a single audio cassette, etc.). There are instances, however, where the entity defined as item comprises more than one physical object (e.g., a monograph issued as two separately bound volumes, a recording issued on three separate compact discs, etc.). In terms of intellectual content and physical form, an item exemplifying a manifestation is normally the same as the manifestation itself. However, variations may occur from one item to another, even when the items exemplify the same manifestation, where those variations are the result of actions external to the intent of the producer of the manifestation (e.g., damage occurring after the item was produced, binding performed by a library, etc.).</para>
    ///   <para>skos:definition : A single exemplar of a manifestation.</para>
    ///   <para>rdfs:label : Ejemplarrdfs:label : Item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Item</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1004">frbrer:C1004</a>
    /// </summary>
    let C1004 = _prefixId.prefix "C1004"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as person encompasses individuals that are deceased as well as those that are living. For the purposes of this model persons are treated as entities only to the extent that they are involved in the creation or realization of a work (e.g., as authors, composers, artists, editors, translators, directors, performers, etc.), or are the subject of a work (e.g., as the subject of a biographical or autobiographical work, of a history, etc.).</para>
    ///   <para>skos:definition : An individual.</para>
    ///   <para>rdfs:label : Personardfs:label : Person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Person</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1005">frbrer:C1005</a>
    /// </summary>
    let C1005 = _prefixId.prefix "C1005"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as corporate body encompasses organizations and groups of individuals and-or organizations that are identified by a particular name, including occasional groups and groups that are constituted as meetings, conferences, congresses, expeditions, exhibitions, festivals, fairs, etc. The entity also encompasses organizations that act as territorial authorities, exercising or claiming to exercise government functions over a certain territory, such as a federation, a state, a region, a local municipality, etc. The entity encompasses organizations and groups that are defunct as well as those that continue to operate.  For the purposes of this model corporate bodies are treated as entities only to the extent that they are involved in the creation or realization of a work (e.g., as the sponsors or endorsers of a work, etc.), or are the subject of a work (e.g., as the subject of a history, etc.).</para>
    ///   <para>skos:definition : An organization or group of individuals and/or organizations acting as a unit.</para>
    ///   <para>rdfs:label : Entidad corporativardfs:label : Corporate Body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : CorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1006">frbrer:C1006</a>
    /// </summary>
    let C1006 = _prefixId.prefix "C1006"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as concept encompasses a comprehensive range of abstractions that may be the subject of a work: fields of knowledge, disciplines, schools of thought (philosophies, religions, political ideologies, etc.), theories, processes, techniques, practices, etc. A concept may be broad in nature or narrowly defined and precise. For the purposes of this model concepts are treated as entities only to the extent that they are the subject of a work (e.g., as the subject of a philosophical treatise, of a critique of a school of thought, etc.).</para>
    ///   <para>skos:definition : An abstract notion or idea.</para>
    ///   <para>rdfs:label : Conceptordfs:label : Concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Concept</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1007">frbrer:C1007</a>
    /// </summary>
    let C1007 = _prefixId.prefix "C1007"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as object encompasses a comprehensive range of material things that may be the subject of a work: animate and inanimate objects occurring in nature; fixed, movable, and moving objects that are the product of human creation; objects that no longer exist. For the purposes of this model objects are treated as entities only to the extent that they are the subject of a work (e.g., as the subject of a scientific study, etc.).</para>
    ///   <para>skos:definition : A material thing.</para>
    ///   <para>rdfs:label : Objetordfs:label : Object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Object</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1008">frbrer:C1008</a>
    /// </summary>
    let C1008 = _prefixId.prefix "C1008"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as event encompasses a comprehensive range of actions and occurrences that may be the subject of a work: historical events, epochs, periods of time, etc. For the purposes of this model events are treated as entities only to the extent that they are the subject of a work (e.g., the subject of an historical treatise, of a painting, etc.).</para>
    ///   <para>skos:definition : An action or occurrence.</para>
    ///   <para>rdfs:label : Acontecimientordfs:label : Event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Event</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1009">frbrer:C1009</a>
    /// </summary>
    let C1009 = _prefixId.prefix "C1009"
    /// <summary>
    ///   <para>skos:scopeNote : The entity defined as place encompasses a comprehensive range of locations: terrestrial and extra-terrestrial; historical and contemporary; geographic features and geo-political jurisdictions. For the purposes of this model places are treated as entities only to the extent that they are the subject of a work (e.g., the subject of a map or atlas, or of a travel guide, etc.).</para>
    ///   <para>skos:definition : A location.</para>
    ///   <para>rdfs:label : Lugarrdfs:label : Place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : Place</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/C1010">frbrer:C1010</a>
    /// </summary>
    let C1010 = _prefixId.prefix "C1010"
    /// <summary>
    ///   <para>rdfs:label : is realized throughrdfs:label : estÃ¡ realizado mediante</para>
    ///   <para>skos:definition : Relates a work to an expression that is the realization of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizedThrough</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2001">frbrer:P2001</a>
    /// </summary>
    let P2001 = _prefixId.prefix "P2001"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the work that is realized through the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizationOf</para>
    ///   <para>rdfs:label : is realization ofrdfs:label : es realizaciÃ³n de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2002">frbrer:P2002</a>
    /// </summary>
    let P2002 = _prefixId.prefix "P2002"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a manifestation that is the embodiment of the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isEmbodiedIn</para>
    ///   <para>rdfs:label : is embodied inrdfs:label : estÃ¡ materializado en</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2003">frbrer:P2003</a>
    /// </summary>
    let P2003 = _prefixId.prefix "P2003"
    /// <summary>
    ///   <para>rdfs:label : is embodiment ofrdfs:label : es materializaciÃ³n de</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isEmbodimentOf</para>
    ///   <para>skos:definition : Relates a manifestation to an expression that is embodied in the manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2004">frbrer:P2004</a>
    /// </summary>
    let P2004 = _prefixId.prefix "P2004"
    /// <summary>
    ///   <para>rdfs:label : estÃ¡ ejemplificado porrdfs:label : is exemplified by</para>
    ///   <para>skos:definition : Relates a manifestation to an item that is a single exemplar of the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isExemplifiedBy</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2005">frbrer:P2005</a>
    /// </summary>
    let P2005 = _prefixId.prefix "P2005"
    /// <summary>
    ///   <para>rdfs:label : es ejemplar derdfs:label : is exemplar of</para>
    ///   <para>skos:definition : Relates an item to the manifestation that is exemplified by the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isExemplarOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2006">frbrer:P2006</a>
    /// </summary>
    let P2006 = _prefixId.prefix "P2006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatedByCorporateBody</para>
    ///   <para>skos:definition : Relates a work to a corporate body that is responsible for the creation of the intellectual or artistic content of the work.</para>
    ///   <para>rdfs:label : is created by (corporate body)rdfs:label : es creado por (entidad corporativa)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2007">frbrer:P2007</a>
    /// </summary>
    let P2007 = _prefixId.prefix "P2007"
    /// <summary>
    ///   <para>rdfs:label : es creador (entidad corporativa) derdfs:label : is creator (corporate body) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatorCorporateBodyOf</para>
    ///   <para>skos:definition : Relates a corporate body to a work of which it is responsible for the creation of the intellectual or artistic content.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2008">frbrer:P2008</a>
    /// </summary>
    let P2008 = _prefixId.prefix "P2008"
    /// <summary>
    ///   <para>rdfs:label : is created by (person)rdfs:label : es creado por (persona)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatedByPerson</para>
    ///   <para>skos:definition : Relates a work to a person who is responsible for the creation of the intellectual or artistic content of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2009">frbrer:P2009</a>
    /// </summary>
    let P2009 = _prefixId.prefix "P2009"
    /// <summary>
    ///   <para>rdfs:label : es creador (persona) derdfs:label : is creator (person) of</para>
    ///   <para>skos:definition : Relates a person to a work of which they are responsible for the creation of the intellectual or artistic content.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isCreatorPersonOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2010">frbrer:P2010</a>
    /// </summary>
    let P2010 = _prefixId.prefix "P2010"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a corporate body that is responsible for the specifics of the intellectual or artistic realization or execution of the expression.</para>
    ///   <para>rdfs:label : estÃ¡ realizado por (entidad corporativa)rdfs:label : is realized by (corporate body)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizedByCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2011">frbrer:P2011</a>
    /// </summary>
    let P2011 = _prefixId.prefix "P2011"
    /// <summary>
    ///   <para>rdfs:label : es realizador (entidad corporativa) derdfs:label : is realizer (corporate body) of</para>
    ///   <para>skos:definition : Relates a corporate body to an expression of which it is responsible for the specifics of the intellectual or artistic realization or execution.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizerCorporateBodyOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2012">frbrer:P2012</a>
    /// </summary>
    let P2012 = _prefixId.prefix "P2012"
    /// <summary>
    ///   <para>rdfs:label : is realized by (person)rdfs:label : estÃ¡ realizado por (persona)</para>
    ///   <para>skos:definition : Relates an expression to a person who is responsible for the specifics of the intellectual or artistic realization or execution of the expression.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizedByPerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2013">frbrer:P2013</a>
    /// </summary>
    let P2013 = _prefixId.prefix "P2013"
    /// <summary>
    ///   <para>rdfs:label : is realizer (person) ofrdfs:label : es realizador (persona) de</para>
    ///   <para>skos:definition : Relates a person to an expression of which they are responsible for the specifics of the intellectual or artistic realization or execution.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isRealizerPersonOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2014">frbrer:P2014</a>
    /// </summary>
    let P2014 = _prefixId.prefix "P2014"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a corporate body that is responsible for publishing, distributing, fabricating or manufacturing the manifestation.</para>
    ///   <para>rdfs:label : es producido por (entidad corporativa)rdfs:label : is produced by (corporate body)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducedByCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2015">frbrer:P2015</a>
    /// </summary>
    let P2015 = _prefixId.prefix "P2015"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducerCorporateBodyOf</para>
    ///   <para>skos:definition : Relates a corporate body to a manifestation of which it is responsible for publishing, distributing, fabricating or manufacturing.</para>
    ///   <para>rdfs:label : is producer (corporate body) ofrdfs:label : es productor (entidad corporativa) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2016">frbrer:P2016</a>
    /// </summary>
    let P2016 = _prefixId.prefix "P2016"
    /// <summary>
    ///   <para>rdfs:label : is produced by (person)rdfs:label : es producido por (persona)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducedByPerson</para>
    ///   <para>skos:definition : Relates a manifestation to a person who is responsible for publishing, distributing, fabricating or manufacturing the manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2017">frbrer:P2017</a>
    /// </summary>
    let P2017 = _prefixId.prefix "P2017"
    /// <summary>
    ///   <para>skos:definition : Relates a person to a manifestation of which they are responsible for publishing, distributing, fabricating or manufacturing.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isProducerPersonOf</para>
    ///   <para>rdfs:label : es productor (persona) derdfs:label : is producer (person) of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2018">frbrer:P2018</a>
    /// </summary>
    let P2018 = _prefixId.prefix "P2018"
    /// <summary>
    ///   <para>rdfs:label : is owned by (corporate body)rdfs:label : es propiedad de (entidad corporativa)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnedByCorporateBody</para>
    ///   <para>skos:definition : Relates an item to a corporate body that is the owner or custodian of the item.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2019">frbrer:P2019</a>
    /// </summary>
    let P2019 = _prefixId.prefix "P2019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnerCorporateBodyOf</para>
    ///   <para>rdfs:label : es propietario (entidad corporativa) derdfs:label : is owner (corporate body) of</para>
    ///   <para>skos:definition : Relates a corporate body to an item of which it is the owner or custodian.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2020">frbrer:P2020</a>
    /// </summary>
    let P2020 = _prefixId.prefix "P2020"
    /// <summary>
    ///   <para>rdfs:label : is owned by (person)rdfs:label : es propiedad de (persona)</para>
    ///   <para>skos:definition : Relates an item to a person who is the owner or custodian of the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnedByPerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2021">frbrer:P2021</a>
    /// </summary>
    let P2021 = _prefixId.prefix "P2021"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isOwnerPersonOf</para>
    ///   <para>rdfs:label : is owner (person) ofrdfs:label : es propietario (persona) de</para>
    ///   <para>skos:definition : Relates a person to an item of which they are the owner or custodian.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2022">frbrer:P2022</a>
    /// </summary>
    let P2022 = _prefixId.prefix "P2022"
    /// <summary>
    ///   <para>rdfs:label : has as subject (concept)rdfs:label : tiene como materia (concepto)</para>
    ///   <para>skos:definition : Relates a work to a concept that is the subject of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectConcept</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2023">frbrer:P2023</a>
    /// </summary>
    let P2023 = _prefixId.prefix "P2023"
    /// <summary>
    ///   <para>rdfs:label : is subject (concept) ofrdfs:label : es materia (concepto) de</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectConceptOf</para>
    ///   <para>skos:definition : Relates a concept to a work of which it is the subject.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2024">frbrer:P2024</a>
    /// </summary>
    let P2024 = _prefixId.prefix "P2024"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an object that is the subject of the work.</para>
    ///   <para>rdfs:label : has as subject (object)rdfs:label : tiene como materia (objeto)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2025">frbrer:P2025</a>
    /// </summary>
    let P2025 = _prefixId.prefix "P2025"
    /// <summary>
    ///   <para>rdfs:label : es materia (objeto) derdfs:label : is subject (object) of</para>
    ///   <para>skos:definition : Relates an object to a work of which it is the subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectObjectOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2026">frbrer:P2026</a>
    /// </summary>
    let P2026 = _prefixId.prefix "P2026"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectEvent</para>
    ///   <para>rdfs:label : tiene como materia (acontecimiento)rdfs:label : has as subject (event)</para>
    ///   <para>skos:definition : Relates a work to an event that is the subject of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2027">frbrer:P2027</a>
    /// </summary>
    let P2027 = _prefixId.prefix "P2027"
    /// <summary>
    ///   <para>rdfs:label : es materia (acontecimiento) derdfs:label : is subject (event) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectEventOf</para>
    ///   <para>skos:definition : Relates an event to a work of which it is the subject.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2028">frbrer:P2028</a>
    /// </summary>
    let P2028 = _prefixId.prefix "P2028"
    /// <summary>
    ///   <para>rdfs:label : tiene como materia (lugar)rdfs:label : has as subject (place)</para>
    ///   <para>skos:definition : Relates a work to a place that is the subject of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectPlace</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2029">frbrer:P2029</a>
    /// </summary>
    let P2029 = _prefixId.prefix "P2029"
    /// <summary>
    ///   <para>rdfs:label : is subject (place) ofrdfs:label : es materia (lugar) de</para>
    ///   <para>skos:definition : Relates a place to a work of which it is the subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectPlaceOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2030">frbrer:P2030</a>
    /// </summary>
    let P2030 = _prefixId.prefix "P2030"
    /// <summary>
    ///   <para>rdfs:label : has as subject (corporate body)rdfs:label : tiene como materia (entidad corporativa)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectCorporateBody</para>
    ///   <para>skos:definition : Relates a work to a corporate body that is the subject of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2031">frbrer:P2031</a>
    /// </summary>
    let P2031 = _prefixId.prefix "P2031"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to a work of which it is the subject.</para>
    ///   <para>rdfs:label : is subject (corporate body) ofrdfs:label : es materia (entidad corporativa) de</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectCorporateBodyOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2032">frbrer:P2032</a>
    /// </summary>
    let P2032 = _prefixId.prefix "P2032"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a person that is the subject of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectPerson</para>
    ///   <para>rdfs:label : tiene como materia (persona)rdfs:label : has as subject (person)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2033">frbrer:P2033</a>
    /// </summary>
    let P2033 = _prefixId.prefix "P2033"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectPersonOf</para>
    ///   <para>rdfs:label : is subject (person) ofrdfs:label : es materia (persona) de</para>
    ///   <para>skos:definition : Relates a person to a work of which it is the subject.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2034">frbrer:P2034</a>
    /// </summary>
    let P2034 = _prefixId.prefix "P2034"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a prior work that is the subject of the work.</para>
    ///   <para>rdfs:label : tiene como materia (obra)rdfs:label : has as subject (work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2035">frbrer:P2035</a>
    /// </summary>
    let P2035 = _prefixId.prefix "P2035"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectWorkOf</para>
    ///   <para>rdfs:label : is subject (work) ofrdfs:label : es materia (obra) de</para>
    ///   <para>skos:definition : Relates a prior work to another work of which it is the subject.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2036">frbrer:P2036</a>
    /// </summary>
    let P2036 = _prefixId.prefix "P2036"
    /// <summary>
    ///   <para>rdfs:label : has as subject (expression)rdfs:label : tiene como materia (expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectExpression</para>
    ///   <para>skos:definition : Relates a work to an expression that is the subject of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2037">frbrer:P2037</a>
    /// </summary>
    let P2037 = _prefixId.prefix "P2037"
    /// <summary>
    ///   <para>rdfs:label : es materia (expresiÃ³n) derdfs:label : is subject (expression) of</para>
    ///   <para>skos:definition : Relates an expression to a work of which it is the subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectExpressionOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2038">frbrer:P2038</a>
    /// </summary>
    let P2038 = _prefixId.prefix "P2038"
    /// <summary>
    ///   <para>skos:definition : Relates a work to a manifestation that is the subject of the work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectManifestation</para>
    ///   <para>rdfs:label : tiene como materia (manifestaciÃ³n)rdfs:label : has as subject (manifestation)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2039">frbrer:P2039</a>
    /// </summary>
    let P2039 = _prefixId.prefix "P2039"
    /// <summary>
    ///   <para>rdfs:label : es materia (manifestaciÃ³n) derdfs:label : is subject (manifestation) of</para>
    ///   <para>skos:definition : Relates a manifestation to a work of which it is the subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectManifestationOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2040">frbrer:P2040</a>
    /// </summary>
    let P2040 = _prefixId.prefix "P2040"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAsSubjectItem</para>
    ///   <para>rdfs:label : tiene como materia (ejemplar)rdfs:label : has as subject (item)</para>
    ///   <para>skos:definition : Relates a work to an item that is the subject of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2041">frbrer:P2041</a>
    /// </summary>
    let P2041 = _prefixId.prefix "P2041"
    /// <summary>
    ///   <para>rdfs:label : is subject (item) ofrdfs:label : es materia (ejemplar) de</para>
    ///   <para>skos:definition : Relates an item to a work of which it is the subject.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isSubjectItemOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2042">frbrer:P2042</a>
    /// </summary>
    let P2042 = _prefixId.prefix "P2042"
    /// <summary>
    ///   <para>rdfs:label : has a successor (work) (from work)rdfs:label : continuado por (obra) (de obra)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASuccessorWorkFromWork</para>
    ///   <para>skos:definition : Relates a prior work to another work, the content of which represents a linear progression from that of the prior work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2043">frbrer:P2043</a>
    /// </summary>
    let P2043 = _prefixId.prefix "P2043"
    /// <summary>
    ///   <para>rdfs:label : is a successor (work) to (work)rdfs:label : es continuaciÃ³n (obra) de (obra)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASuccessorWorkToWork</para>
    ///   <para>skos:definition : Relates a work to a prior work, the content of which represents the basis of a linear progression to that of the successor work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2044">frbrer:P2044</a>
    /// </summary>
    let P2044 = _prefixId.prefix "P2044"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASupplementWorkFromWork</para>
    ///   <para>skos:definition : Relates a prior work to another work that is intended to be used in conjunction with the prior work. The content may be closely or loosely associatedd, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : has a supplement (work) (from work)rdfs:label : tiene suplemento (obra) (de obra)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2045">frbrer:P2045</a>
    /// </summary>
    let P2045 = _prefixId.prefix "P2045"
    /// <summary>
    ///   <para>rdfs:label : supplements (work) (from work)rdfs:label : es suplemento (obra) de (obra)</para>
    ///   <para>skos:definition : Relates a work to a prior work with which it is intended to be used in conjunction. The content may be closely or loosely associated, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementsWorkFromWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2046">frbrer:P2046</a>
    /// </summary>
    let P2046 = _prefixId.prefix "P2046"
    /// <summary>
    ///   <para>rdfs:label : tiene complemento (obra) (de obra)rdfs:label : has a complement (work) (from work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAComplementWorkFromWork</para>
    ///   <para>skos:definition : Relates a prior work to another work that is intended to be combined with or inserted into the prior work, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2047">frbrer:P2047</a>
    /// </summary>
    let P2047 = _prefixId.prefix "P2047"
    /// <summary>
    ///   <para>rdfs:label : complements (work) (from work)rdfs:label : es complemento (obra) (de obra)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementsWorkFromWork</para>
    ///   <para>skos:definition : Relates a work to a prior work that it is intended to be combined with or inserted into, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2048">frbrer:P2048</a>
    /// </summary>
    let P2048 = _prefixId.prefix "P2048"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASummaryWorkFromWork</para>
    ///   <para>skos:definition : Relates a prior work to another work that represents a brief recapitulation of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : has a summary (work) (from work)rdfs:label : tiene resumen (obra) (de obra)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2049">frbrer:P2049</a>
    /// </summary>
    let P2049 = _prefixId.prefix "P2049"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASummaryWorkOfWork</para>
    ///   <para>skos:definition : Relates a work to a prior work of which it represents a brief recapitulation. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : is a summary (work) of (work)rdfs:label : es resumen (obra) de (obra)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2050">frbrer:P2050</a>
    /// </summary>
    let P2050 = _prefixId.prefix "P2050"
    /// <summary>
    ///   <para>rdfs:label : has an adaptation (work) (from work)rdfs:label : tiene adaptaciÃ³n (obra) (de obra)</para>
    ///   <para>skos:definition : Relates a prior work to another work that represents a modification of the content of the prior work for a purpose, use, or medium other than that for which it was originally intended. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:comment : Source documentation has label "has adaptation"; amended to improve consistency.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnAdaptationWorkFromWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2051">frbrer:P2051</a>
    /// </summary>
    let P2051 = _prefixId.prefix "P2051"
    /// <summary>
    ///   <para>rdfs:label : is an adaptation (work) of (work)rdfs:label : es adaptaciÃ³n (obra) de (obra)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnAdaptationWorkOfWork</para>
    ///   <para>skos:definition : Relates a work to a prior work of which it represents a modification of the content for a purpose, use, or medium other than that for which it was originally intended.The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2052">frbrer:P2052</a>
    /// </summary>
    let P2052 = _prefixId.prefix "P2052"
    /// <summary>
    ///   <para>skos:definition : Relates a prior work to another work that represents a transformation of the content of the prior work in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the transformation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <para>rdfs:label : tiene transformaciÃ³n (obra) (de obra)rdfs:label : has a transformation (work) (from work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasATransformationWorkFromWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2053">frbrer:P2053</a>
    /// </summary>
    let P2053 = _prefixId.prefix "P2053"
    /// <summary>
    ///   <para>rdfs:label : is a transformation (work) of (work)rdfs:label : es transformaciÃ³n (obra) de (obra)</para>
    ///   <para>skos:definition : Relates a work to a prior work of which it represents a transformation of the content in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isATransformationWorkOfWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2054">frbrer:P2054</a>
    /// </summary>
    let P2054 = _prefixId.prefix "P2054"
    /// <summary>
    ///   <para>skos:definition : Relates a prior work to another work that that copies the style of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnImitationWorkFromWork</para>
    ///   <para>rdfs:label : tiene imitaciÃ³n (obra) (de obra)rdfs:label : has an imitation (work) (from work)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2055">frbrer:P2055</a>
    /// </summary>
    let P2055 = _prefixId.prefix "P2055"
    /// <summary>
    ///   <para>rdfs:label : es imitaciÃ³n (obra) de (obra)rdfs:label : is an imitation (work) of (work)</para>
    ///   <para>skos:definition : Relates a work to a prior work of which it copies the style of the content. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnImitationWorkOfWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2056">frbrer:P2056</a>
    /// </summary>
    let P2056 = _prefixId.prefix "P2056"
    /// <summary>
    ///   <para>rdfs:label : tiene como parte (obra)rdfs:label : has part (work)</para>
    ///   <para>skos:scopeNote : The component work may be intended to be used in the context of the prior work or may not depend to any significant extent on the context provided by the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPartWork</para>
    ///   <para>skos:definition : Relates a work to another work that is a component of the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2057">frbrer:P2057</a>
    /// </summary>
    let P2057 = _prefixId.prefix "P2057"
    /// <summary>
    ///   <para>rdfs:label : forma parte (obra) derdfs:label : is part (work) of</para>
    ///   <para>skos:definition : Relates a work to another work of which it is a component.</para>
    ///   <para>skos:scopeNote : The component work may be intended to be used in the context of the prior work or may not depend to any significant extent on the context provided by the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPartWorkOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2058">frbrer:P2058</a>
    /// </summary>
    let P2058 = _prefixId.prefix "P2058"
    /// <summary>
    ///   <para>rdfs:label : has an abridgement (expression)rdfs:label : tiene compendio (expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnAbridgementExpression</para>
    ///   <para>skos:definition : Relates an expression to another expression of the same work that represents an abridgement, in which some content of the prior expression is removed, but the result does not alter the content to the extent that it becomes a new work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2059">frbrer:P2059</a>
    /// </summary>
    let P2059 = _prefixId.prefix "P2059"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnAbridgementExpressionOf</para>
    ///   <para>skos:definition : Relates an expression to a prior expression of the same work of which it represents an abridgement, in which some content of the prior expression is removed, but the result does not alter the content to the extent that it becomes a new work.</para>
    ///   <para>rdfs:label : is an abridgement (expression) ofrdfs:label : es compendio (expresiÃ³n) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2060">frbrer:P2060</a>
    /// </summary>
    let P2060 = _prefixId.prefix "P2060"
    /// <summary>
    ///   <para>rdfs:label : has a revision (expression)rdfs:label : tiene revisiÃ³n (expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression to another expression of the same work that represents a revision, in which the intent is to alter or update the content of the prior expression, but without changing the content so much that it becomes a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasARevisionExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2061">frbrer:P2061</a>
    /// </summary>
    let P2061 = _prefixId.prefix "P2061"
    /// <summary>
    ///   <para>rdfs:label : is a revision (expression) ofrdfs:label : es revisiÃ³n (expresiÃ³n) de</para>
    ///   <para>skos:definition : Relates an expression to a prior expression of the same work of which it represents a revision, in which the intent is to alter or update the content of the prior expression, but without changing the content so much that it becomes a new work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isARevisionExpressionOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2062">frbrer:P2062</a>
    /// </summary>
    let P2062 = _prefixId.prefix "P2062"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasATranslationExpression</para>
    ///   <para>rdfs:label : tiene traducciÃ³n (expresiÃ³n)rdfs:label : has a translation (expression)</para>
    ///   <para>skos:scopeNote : Free translations are treated in the model as new works.</para>
    ///   <para>skos:definition : Relates an expression to another expression of the same work that represents a literal translation, in which the intent is to render the intellectual content of the previous expression as accurately as possible.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2063">frbrer:P2063</a>
    /// </summary>
    let P2063 = _prefixId.prefix "P2063"
    /// <summary>
    ///   <para>skos:scopeNote : Free translations are treated in the model as new works.</para>
    ///   <para>rdfs:label : is a translation (expression) ofrdfs:label : es traducciÃ³n (expresiÃ³n) de</para>
    ///   <para>skos:definition : Relates an expression to a prior expression of the same work of which it represents a literal translation, in which the intent is to render the intellectual content of the previous expression as accurately as possible.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isATranslationExpressionOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2064">frbrer:P2064</a>
    /// </summary>
    let P2064 = _prefixId.prefix "P2064"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to another expression that represents an arrangement of the same musical composition work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnArrangementExpression</para>
    ///   <para>rdfs:label : tiene arreglo (expresiÃ³n)rdfs:label : has an arrangement (expression)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2065">frbrer:P2065</a>
    /// </summary>
    let P2065 = _prefixId.prefix "P2065"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to a prior expression of which it represents an arrangement of the same musical composition work.</para>
    ///   <para>rdfs:label : es arreglo (expresiÃ³n) derdfs:label : is an arrangement (expression) of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnArrangementExpressionOf</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2066">frbrer:P2066</a>
    /// </summary>
    let P2066 = _prefixId.prefix "P2066"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASuccessorExpressionFromExpression</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work, the content of which represents a linear progression from that of the prior work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : continuado por (expresiÃ³n) (de expresiÃ³n)rdfs:label : has a successor (expression) (from expression)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2067">frbrer:P2067</a>
    /// </summary>
    let P2067 = _prefixId.prefix "P2067"
    /// <summary>
    ///   <para>rdfs:label : es continuaciÃ³n (expresiÃ³n) de (expresiÃ³n)rdfs:label : is a successor (expression) to (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASuccessorExpressionToExpression</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work, the content of which represents the basis of a linear progression to that of the successor work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2068">frbrer:P2068</a>
    /// </summary>
    let P2068 = _prefixId.prefix "P2068"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAComplementExpressionFromExpression</para>
    ///   <para>rdfs:label : has a complement (expression) (from expression)rdfs:label : tiene complemento (expresiÃ³n)  (de expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that is intended to be combined with or inserted into the prior work, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2069">frbrer:P2069</a>
    /// </summary>
    let P2069 = _prefixId.prefix "P2069"
    /// <summary>
    ///   <para>rdfs:label : es complemento (expresiÃ³n) de (expresiÃ³n)rdfs:label : complements (expression) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work that it is intended to be combined with or inserted into, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementsExpressionFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2070">frbrer:P2070</a>
    /// </summary>
    let P2070 = _prefixId.prefix "P2070"
    /// <summary>
    ///   <para>rdfs:label : has a summary (expression) (from expression)rdfs:label : tiene resumen (expresiÃ³n) (de expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that represents a brief recapitulation of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASummaryExpressionFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2071">frbrer:P2071</a>
    /// </summary>
    let P2071 = _prefixId.prefix "P2071"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASummaryExpressionOfExpression</para>
    ///   <para>rdfs:label : is a summary (expression) of (expression)rdfs:label : es resumen (expresiÃ³n) de (expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work of which it represents a brief recapitulation. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2072">frbrer:P2072</a>
    /// </summary>
    let P2072 = _prefixId.prefix "P2072"
    /// <summary>
    ///   <para>rdfs:label : tiene adaptaciÃ³n (expresiÃ³n) (de expresiÃ³n)rdfs:label : has an adaptation (expression) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that represents a modification of the content of the prior work for a purpose, use, or medium other than that for which it was originally intended. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnAdaptationExpressionFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2073">frbrer:P2073</a>
    /// </summary>
    let P2073 = _prefixId.prefix "P2073"
    /// <summary>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work of which it represents a modification of the content for a purpose, use, or medium other than that for which it was originally intended. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : is an adaptation (expression) of (expression)rdfs:label : es adaptaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnAdaptationExpressionOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2074">frbrer:P2074</a>
    /// </summary>
    let P2074 = _prefixId.prefix "P2074"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasATransformationExpressionFromExpression</para>
    ///   <para>rdfs:label : has a transformation (expression) (from expression)rdfs:label : tiene transformaciÃ³n (expresiÃ³n) (de expresiÃ³n)</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that represents a transformation of the content of the prior work in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the transformation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2075">frbrer:P2075</a>
    /// </summary>
    let P2075 = _prefixId.prefix "P2075"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isATransformationExpressionOfExpression</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work of which it represents a transformation of the content in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : is a transformation (expression) of (expression)rdfs:label : es transformaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2076">frbrer:P2076</a>
    /// </summary>
    let P2076 = _prefixId.prefix "P2076"
    /// <summary>
    ///   <para>rdfs:label : tiene imitaciÃ³n (expresiÃ³n) (de expresiÃ³n)rdfs:label : has an imitation (expression) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that copies the style of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnImitationExpressionFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2077">frbrer:P2077</a>
    /// </summary>
    let P2077 = _prefixId.prefix "P2077"
    /// <summary>
    ///   <para>rdfs:label : is an imitation (expression) of (expression)rdfs:label : es imitaciÃ³n (expresiÃ³n) de (expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work of which it copies the style of the content. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnImitationExpressionOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2078">frbrer:P2078</a>
    /// </summary>
    let P2078 = _prefixId.prefix "P2078"
    /// <summary>
    ///   <para>skos:scopeNote : The component expression may be intended to be used in the context of the prior expression or may not depend to any significant extent on the context provided by the prior expression.</para>
    ///   <para>skos:definition : Relates an expression to another expression that is a component of the expression.</para>
    ///   <para>rdfs:label : has part (expression)rdfs:label : tiene como parte (expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPartExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2079">frbrer:P2079</a>
    /// </summary>
    let P2079 = _prefixId.prefix "P2079"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPartExpressionOf</para>
    ///   <para>skos:definition : Relates an expression to another expression of which it is a component.</para>
    ///   <para>skos:scopeNote : The component expression may be intended to be used in the context of the prior expression or may not depend to any significant extent on the context provided by the prior expression.</para>
    ///   <para>rdfs:label : is part (expression) ofrdfs:label : forma parte (expresiÃ³n) de</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2080">frbrer:P2080</a>
    /// </summary>
    let P2080 = _prefixId.prefix "P2080"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAReproductionManifestationFromManifestation</para>
    ///   <para>rdfs:label : tiene reproducciÃ³n (manifestaciÃ³n) (de manifestaciÃ³n)rdfs:label : has a reproduction (manifestation) (from manifestation)</para>
    ///   <para>skos:definition : Relates a manifestation to another manifestation, usually of the same expression, that represents the same intellectual or artistic content as the prior manifestation. The reproduction manifestation may or may not replicate the look and feel or other physical characteristics of the prior manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2081">frbrer:P2081</a>
    /// </summary>
    let P2081 = _prefixId.prefix "P2081"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to a prior manifestation, usually of the same expression, of which it represents the same intellectual or artistic content as the prior manifestation. The reproduction manifestation may or may not replicate the look and feel or other physical characteristics of the prior manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAReproductionManifestationOfManifestation</para>
    ///   <para>rdfs:label : is a reproduction (manifestation) of (manifestation)rdfs:label : es reproducciÃ³n (manifestaciÃ³n) de (manifestaciÃ³n)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2082">frbrer:P2082</a>
    /// </summary>
    let P2082 = _prefixId.prefix "P2082"
    /// <summary>
    ///   <para>rdfs:label : tiene (manifestaciÃ³n) alternardfs:label : has an alternate</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnAlternate</para>
    ///   <para>skos:scopeNote : The alternate relationship obtains, for example, when a publication, sound recording, video, etc. is issued in more than one format or when it is released simultaneously by different publishers in different countries.</para>
    ///   <para>skos:definition : Relates a manifestation to another manifestation, usually of the same expression, that effectively serves as an alternate manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2083">frbrer:P2083</a>
    /// </summary>
    let P2083 = _prefixId.prefix "P2083"
    /// <summary>
    ///   <para>rdfs:label : has part (manifestation)rdfs:label : tiene como parte (manifestaciÃ³n)</para>
    ///   <para>skos:scopeNote : The component manifestation may be a discrete physical unit of the prior manifestation or may be an integral part that is physically inseparable from the whole of the prior expression.</para>
    ///   <para>skos:definition : Relates a manifestation to another manifestation that is a component of the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPartManifestation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2085">frbrer:P2085</a>
    /// </summary>
    let P2085 = _prefixId.prefix "P2085"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPartManifestationOf</para>
    ///   <para>skos:scopeNote : The component manifestation may be a discrete physical unit of the prior manifestation or may be an integral part that is physically inseparable from the whole of the prior manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to another manifestation of which it is a component.</para>
    ///   <para>rdfs:label : forma parte (manifestaciÃ³n) derdfs:label : is part (manifestation) of</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2086">frbrer:P2086</a>
    /// </summary>
    let P2086 = _prefixId.prefix "P2086"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has label "has reconfiguration", amended to improve consistency.</para>
    ///   <para>skos:definition : Relates an item to another item that is the result of a change to the prior item. The reconfiguration item may be the result of changes to more than one prior item.</para>
    ///   <para>rdfs:label : has a reconfigurationrdfs:label : tiene reconfiguraciÃ³n</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAReconfiguration</para>
    ///   <para>skos:scopeNote : Most commonly, an item of one manifestation is bound with an item of a different manifestation to make a new item.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2087">frbrer:P2087</a>
    /// </summary>
    let P2087 = _prefixId.prefix "P2087"
    /// <summary>
    ///   <para>skos:definition : Relates an item to another item to which it is the result of a change. The reconfiguration item may be the result of changes to more than one prior item.</para>
    ///   <para>rdfs:label : es reconfiguraciÃ³n derdfs:label : is a reconfiguration of</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAReconfigurationOf</para>
    ///   <para>skos:scopeNote : Most commonly, an item of one manifestation is bound with an item of a different manifestation to make a new item.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2088">frbrer:P2088</a>
    /// </summary>
    let P2088 = _prefixId.prefix "P2088"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has label "has reproduction"; amended to improve consistency.</para>
    ///   <para>rdfs:label : has a reproduction (item) (from item)rdfs:label : tiene reproducciÃ³n (ejemplar) (de ejemplar)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAReproductionItemFromItem</para>
    ///   <para>skos:definition : Relates an item to another item that has been derived in some way from the prior item. There can be varying levels of fidelity of the reproduction item to the prior item. The reproduction item must replicate the type of carrier and other physical characteristics of the prior item.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2089">frbrer:P2089</a>
    /// </summary>
    let P2089 = _prefixId.prefix "P2089"
    /// <summary>
    ///   <para>rdfs:label : is a reproduction (item) of (item)rdfs:label : es reproducciÃ³n (ejemplar) de (ejemplar)</para>
    ///   <para>skos:definition : Relates an item to a prior item from which it has been derived in some way. There can be varying levels of fidelity of the reproduction item to the prior item. The reproduction item must replicate the type of carrier and other physical characteristics of the prior item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAReproductionItemOfItem</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2090">frbrer:P2090</a>
    /// </summary>
    let P2090 = _prefixId.prefix "P2090"
    /// <summary>
    ///   <para>skos:definition : Relates an item to another item that is a component of the item.</para>
    ///   <para>rdfs:label : tiene como parte (ejemplar)rdfs:label : has part (item)</para>
    ///   <para>skos:scopeNote : The component item may be a discrete physical unit of the prior item or may be an integral part that is physically inseparable from the whole of the prior item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPartItem</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2091">frbrer:P2091</a>
    /// </summary>
    let P2091 = _prefixId.prefix "P2091"
    /// <summary>
    ///   <para>rdfs:label : is part (item) ofrdfs:label : forma parte (ejemplar) de</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isPartItemOf</para>
    ///   <para>skos:definition : Relates an item to another item of which it is a component.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2092">frbrer:P2092</a>
    /// </summary>
    let P2092 = _prefixId.prefix "P2092"
    /// <summary>
    ///   <para>rdfs:label : tiene reproducciÃ³n (manifestaciÃ³n) (de ejemplar)rdfs:label : has a reproduction (manifestation) (from item)</para>
    ///   <para>skos:definition : Relates an item to a manifestation that has been derived in some way from the prior item. There can be varying levels of fidelity of the reproduction manifestation to the prior item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAReproductionManifestationFromItem</para>
    ///   <para>skos:scopeNote : The reproduction relationship will be stated at this level when it is useful to indicate the specific item used, as opposed to stating the relationship at the more general level of manifestation-to-manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2093">frbrer:P2093</a>
    /// </summary>
    let P2093 = _prefixId.prefix "P2093"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAReproductionManifestationOfItem</para>
    ///   <para>skos:definition : Relates a manifestation to an item from which it has been derived in some way. There can be varying levels of fidelity of the reproduction manifestation to the prior item.</para>
    ///   <para>rdfs:label : is a reproduction (manifestation) of (item)rdfs:label : es reproducciÃ³n (manifestaciÃ³n) de (ejemplar)</para>
    ///   <para>skos:scopeNote : The reproduction relationship will be stated at this level when it is useful to indicate the specific item used, as opposed to stating the relationship at the more general level of manifestation-to-manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2094">frbrer:P2094</a>
    /// </summary>
    let P2094 = _prefixId.prefix "P2094"
    /// <summary>
    ///   <para>rdfs:label : has a successor (work) (from expression)rdfs:label : continuado por (obra) (de expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work, the content of which represents a linear progression from that of the prior work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASuccessorWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2095">frbrer:P2095</a>
    /// </summary>
    let P2095 = _prefixId.prefix "P2095"
    /// <summary>
    ///   <para>rdfs:label : is a successor (work) to (expression)rdfs:label : es continuaciÃ³n (obra) de (expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASuccessorWorkToExpression</para>
    ///   <para>skos:definition : Relates a work to an expression of a prior work, the content of which represents the basis of a linear progression to that of the successor work. The content may be closely or loosely connected, so the successor work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2096">frbrer:P2096</a>
    /// </summary>
    let P2096 = _prefixId.prefix "P2096"
    /// <summary>
    ///   <para>rdfs:label : has a supplement (work) (from expression)rdfs:label : tiene suplemento (obra) (de expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that is intended to be used in conjunction with the prior work. The content may be closely or loosely associated, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASupplementWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2097">frbrer:P2097</a>
    /// </summary>
    let P2097 = _prefixId.prefix "P2097"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression of a prior work with which it is intended to be used in conjunction. The content may be closely or loosely associated, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : es suplemento (expresiÃ³n) de (obra)rdfs:label : supplements (expression) (from work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementsExpressionFromWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2098">frbrer:P2098</a>
    /// </summary>
    let P2098 = _prefixId.prefix "P2098"
    /// <summary>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that is intended to be combined with or inserted into the prior work, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : has a complement (work) (from expression)rdfs:label : tiene complemento (obra) (de expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAComplementWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2099">frbrer:P2099</a>
    /// </summary>
    let P2099 = _prefixId.prefix "P2099"
    /// <summary>
    ///   <para>rdfs:label : complements (work) (from expression)rdfs:label : es complemento (obra) de (expresiÃ³n)</para>
    ///   <para>skos:definition : Relates a work to an expression of a prior work that it is intended to be combined with or inserted into, but was not part of the original conception of the prior work. The content may be closely or loosely connected, so the complementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : complementsWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2100">frbrer:P2100</a>
    /// </summary>
    let P2100 = _prefixId.prefix "P2100"
    /// <summary>
    ///   <para>rdfs:label : tiene resumen (obra) (de expresiÃ³n)rdfs:label : has a summary (work) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that represents a brief recapitulation of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASummaryWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2101">frbrer:P2101</a>
    /// </summary>
    let P2101 = _prefixId.prefix "P2101"
    /// <summary>
    ///   <para>rdfs:label : es resumen (obra) de (expresiÃ³n)rdfs:label : is a summary (work) of (expression)</para>
    ///   <para>skos:definition : Relates a work to an expression of a prior work of which it represents a brief recapitulation. The modification of the content of the prior work must be sufficient in degree to warrant the summary work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isASummaryWorkOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2102">frbrer:P2102</a>
    /// </summary>
    let P2102 = _prefixId.prefix "P2102"
    /// <summary>
    ///   <para>rdfs:label : tiene adaptaciÃ³n (obra) (de expresiÃ³n)rdfs:label : has an adaptation (work) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that represents a modification of the content of the prior work for a purpose, use, or medium other than that for which it was originally intended. The modification of the content of the prior work must be sufficient in degree to warrant the adaption work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnAdaptationWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2103">frbrer:P2103</a>
    /// </summary>
    let P2103 = _prefixId.prefix "P2103"
    /// <summary>
    ///   <para>rdfs:label : is an adaptation (work) of (expression)rdfs:label : es adaptaciÃ³n (obra) de (expresiÃ³n)</para>
    ///   <para>skos:definition : Relates a work to an expression of a prior work of which it represents a modification of the content for a purpose, use, or medium other than that for which it was originally intended. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnAdaptationWorkOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2104">frbrer:P2104</a>
    /// </summary>
    let P2104 = _prefixId.prefix "P2104"
    /// <summary>
    ///   <para>rdfs:label : has a transformation (work) (from expression)rdfs:label : tiene transformaciÃ³n (obra) (de expresiÃ³n)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasATransformationWorkFromExpression</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that represents a transformation of the content of the prior work in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the transformation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2105">frbrer:P2105</a>
    /// </summary>
    let P2105 = _prefixId.prefix "P2105"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isATransformationWorkOfExpression</para>
    ///   <para>skos:definition : Relates a work to an expression of a prior work of which it represents a transformation of the content in a different genre. The modification of the content of the prior work must be sufficient in degree to warrant the adaptation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:comment : Source documentation has "literary genre", but other genres allowed.</para>
    ///   <para>rdfs:label : es transformaciÃ³n (obra) de (expresiÃ³n)rdfs:label : is a transformation (work) of (expression)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2106">frbrer:P2106</a>
    /// </summary>
    let P2106 = _prefixId.prefix "P2106"
    /// <summary>
    ///   <para>rdfs:label : has an imitation (work) (from expression)rdfs:label : tiene imitaciÃ³n (obra) (de expresiÃ³n)</para>
    ///   <para>skos:definition : Relates an expression of a prior work to another work that copies the style of the content of the prior work. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAnImitationWorkFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2107">frbrer:P2107</a>
    /// </summary>
    let P2107 = _prefixId.prefix "P2107"
    /// <summary>
    ///   <para>skos:definition : Relates a work to an expression of a prior work of which it copies the style of the content. The modification of the content of the prior work must be sufficient in degree to warrant the imitation work being considered as a new work autonomous with respect to the prior work.</para>
    ///   <para>rdfs:label : es imitaciÃ³n (obra) de (expresiÃ³n)rdfs:label : is an imitation (work) of (expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : isAnImitationWorkOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2108">frbrer:P2108</a>
    /// </summary>
    let P2108 = _prefixId.prefix "P2108"
    /// <summary>
    ///   <para>rdfs:label : tiene suplemento (expresiÃ³n) (de expresiÃ³n) rdfs:label : has a supplement (expression) (from expression)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasASupplementExpressionFromExpression</para>
    ///   <para>skos:definition : Relates an expression of a prior work to an expression of another work that is intended to be used in conjunction with the prior work. The content may be closely or loosely associated, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2109">frbrer:P2109</a>
    /// </summary>
    let P2109 = _prefixId.prefix "P2109"
    /// <summary>
    ///   <para>rdfs:label : es suplemento (expresiÃ³n) de (expresiÃ³n)rdfs:label : supplements (expression) (from expression)</para>
    ///   <para>skos:definition : Relates an expression of a work to an expression of a prior work with which it is intended to be used in conjunction. The content may be closely or loosely associated, so the supplementary work may be referential or autonomous with respect to the prior work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : supplementsExpressionFromExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P2110">frbrer:P2110</a>
    /// </summary>
    let P2110 = _prefixId.prefix "P2110"
    /// <summary>
    ///   <para>rdfs:label : tiene tÃ­tulo de la obrardfs:label : has title of the work</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfTheWork</para>
    ///   <para>skos:scopeNote : There may be one or more titles associated with a work. If the work has appeared under varying titles (differing in form, language, etc.), a bibliographic agency normally selects one of those titles as the basis of a "uniform title" for purposes of consistency in naming and referencing the work. Other titles under which the work has appeared may be treated as variant titles for the work, or in some cases as a parallel uniform title. The title of a work that forms part of a larger work may consist solely of a number or other generic designation that is dependent on the title of the larger work.</para>
    ///   <para>skos:definition : Relates a work to the word, phrase, or group of characters naming the work.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3001">frbrer:P3001</a>
    /// </summary>
    let P3001 = _prefixId.prefix "P3001"
    /// <summary>
    ///   <para>rdfs:label : tiene forma de la obrardfs:label : has form of work</para>
    ///   <para>skos:scopeNote : E.g., novel, play, poem, essay, biography, symphony, concerto, sonata, map, drawing, painting, photograph, etc.</para>
    ///   <para>skos:definition : Relates a work to the class to which the work belongs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFormOfWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3002">frbrer:P3002</a>
    /// </summary>
    let P3002 = _prefixId.prefix "P3002"
    /// <summary>
    ///   <para>skos:scopeNote : The date (normally the year) may be a single date or a range of dates. In the absence of an ascertainable date of creation, the date of the work may be associated with the date of its first publication or release.</para>
    ///   <para>skos:definition : Relates a work to the date the work was originally created.</para>
    ///   <para>rdfs:label : has date of the workrdfs:label : tiene fecha de la obra</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateOfTheWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3003">frbrer:P3003</a>
    /// </summary>
    let P3003 = _prefixId.prefix "P3003"
    /// <summary>
    ///   <para>rdfs:label : has other distinguishing characteristic of workrdfs:label : tiene otras caracterÃ­siticas distintivas de obra</para>
    ///   <para>rdfs:comment : Source documentation has label "Other Distinguishing Characteristic", used also for an Expression attribute.</para>
    ///   <para>skos:definition : Relates a work to any characteristic that serves to differentiate the work from another work with the same title.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherDistinguishingCharacteristicOfWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3004">frbrer:P3004</a>
    /// </summary>
    let P3004 = _prefixId.prefix "P3004"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasIntendedTermination</para>
    ///   <para>rdfs:label : has intended terminationrdfs:label : tiene finalizaciÃ³n prevista</para>
    ///   <para>skos:definition : Relates a work to a reflection of whether the work has been conceived as having a finite end or whether it is intended to continue indefinitely.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3005">frbrer:P3005</a>
    /// </summary>
    let P3005 = _prefixId.prefix "P3005"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the class of user for which the work is intended, as defined by age group, educational level, or other categorization.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasIntendedAudience</para>
    ///   <para>rdfs:label : has intended audiencerdfs:label : tiene tipo de audencia</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3006">frbrer:P3006</a>
    /// </summary>
    let P3006 = _prefixId.prefix "P3006"
    /// <summary>
    ///   <para>skos:definition : Relates a work to the historical, social, intellectual, artistic, or other context within which the work was originally conceived.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContextForTheWork</para>
    ///   <para>rdfs:label : has context for the workrdfs:label : tiene contexto de la obra</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3007">frbrer:P3007</a>
    /// </summary>
    let P3007 = _prefixId.prefix "P3007"
    /// <summary>
    ///   <para>skos:scopeNote : There may be one or more titles associated with an expression. The title of an expression that forms part of a larger expression may consist solely of a number or other generic designation that is dependent on the title of the larger expression.</para>
    ///   <para>skos:definition : Relates an expression to a word, phrase, or group of characters naming the expression.</para>
    ///   <para>rdfs:label : tiene tÃ­tulo de la expresiÃ³nrdfs:label : has title of the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfTheExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3008">frbrer:P3008</a>
    /// </summary>
    let P3008 = _prefixId.prefix "P3008"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., through alpha-numeric notation, musical notation, spoken word, musical sound, cartographic image, photographic image, sculpture, dance, mime, etc.</para>
    ///   <para>skos:definition : Relates an expression to the means by which the work is realized.</para>
    ///   <para>rdfs:label : tiene forma de la expresiÃ³nrdfs:label : has form of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFormOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3009">frbrer:P3009</a>
    /// </summary>
    let P3009 = _prefixId.prefix "P3009"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., the date the particular text of a work was written or revised, the date a song was performed, etc. The date may be a single date or a range of dates. In the absence of an ascertainable date of expression, the date of the expression may be associated with the date of its publication or release.</para>
    ///   <para>skos:definition : Relates an expression to the date the expression was created.</para>
    ///   <para>rdfs:label : tiene fecha de la expresiÃ³nrdfs:label : has date of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3010">frbrer:P3010</a>
    /// </summary>
    let P3010 = _prefixId.prefix "P3010"
    /// <summary>
    ///   <para>skos:scopeNote : The language of the expression may comprise a number of languages, each pertaining to an individual component of the expression.</para>
    ///   <para>skos:definition : Relates an expression to the language in which the work is expressed.</para>
    ///   <para>rdfs:label : tiene lengua de la expresiÃ³nrdfs:label : has language of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasLanguageOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3011">frbrer:P3011</a>
    /// </summary>
    let P3011 = _prefixId.prefix "P3011"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherDistinguishingCharacteristicOfExpression</para>
    ///   <para>rdfs:comment : Source document has label "Other Distinguishing Characteristic" used also for a Work attribute.</para>
    ///   <para>skos:definition : Relates an expression to any characteristic of the expression that serves to differentiate the expression from another expression of the same work.</para>
    ///   <para>rdfs:label : tiene otras caracterÃ­sticas distintivas de expresiÃ³nrdfs:label : has other distinguishing characteristic of expression</para>
    ///   <para>skos:scopeNote : E.g., the names used to differentiate the various versions of the English text of the Bible, or an "edition" or version designation relating to the intellectual content of the expression such as "2nd revision".</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3012">frbrer:P3012</a>
    /// </summary>
    let P3012 = _prefixId.prefix "P3012"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., an expression that is completed one part at a time, segment by segment, issue by issue, etc.</para>
    ///   <para>skos:definition : Relates an expression to a reflection of the expectation that the expression will have additional intellectual or artistic content added to it.</para>
    ///   <para>rdfs:label : tiene extensibilidad de la expresiÃ³nrdfs:label : has extensibility of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExtensibilityOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3013">frbrer:P3013</a>
    /// </summary>
    let P3013 = _prefixId.prefix "P3013"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., a draft or interim report, a directory that is expected to be updated periodically.</para>
    ///   <para>skos:definition : Relates an expression to a reflection of the expectation that the intellectual or artistic content of the expression will be revised.</para>
    ///   <para>rdfs:label : tiene revisabilidad de la expresiÃ³nrdfs:label : has revisability of expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRevisabilityOfExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3014">frbrer:P3014</a>
    /// </summary>
    let P3014 = _prefixId.prefix "P3014"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., number of words in a text, statements in a computer program, images in a comic strip, etc. For works expressed as sound and, or, motion the extent may be a measure of duration; e.g., playing time.</para>
    ///   <para>skos:definition : Relates an expression to a quantification of the intellectual content of the expression.</para>
    ///   <para>rdfs:label : tiene extensiÃ³n de la expresiÃ³nrdfs:label : has extent of the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExtentOfTheExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3015">frbrer:P3015</a>
    /// </summary>
    let P3015 = _prefixId.prefix "P3015"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to an abstract, summary, synopsis, etc., or a list of chapter headings, songs, parts, etc. included in the expression.</para>
    ///   <para>rdfs:label : tiene resumen del contenidordfs:label : has summarization of content</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSummarizationOfContent</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3016">frbrer:P3016</a>
    /// </summary>
    let P3016 = _prefixId.prefix "P3016"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the historical, social, intellectual, artistic, or other context within which the expression was realized.</para>
    ///   <para>rdfs:label : tiene contexto de la expresiÃ³nrdfs:label : has context for the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasContextForTheExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3017">frbrer:P3017</a>
    /// </summary>
    let P3017 = _prefixId.prefix "P3017"
    /// <summary>
    ///   <para>skos:definition : Relates an expression to the reception given to the expression by reviewers, critics, etc., as encapsulated in an annotation.</para>
    ///   <para>rdfs:label : tiene respuesta crÃ­tica a la expresiÃ³nrdfs:label : has critical response to the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCriticalResponseToTheExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3018">frbrer:P3018</a>
    /// </summary>
    let P3018 = _prefixId.prefix "P3018"
    /// <summary>
    ///   <para>skos:scopeNote : Use restrictions may be based in copyright, or they may extend beyond the protections guaranteed in law to the owner of the copyright.</para>
    ///   <para>skos:definition : Relates an expression to restrictions on access to and use of an expression.</para>
    ///   <para>rdfs:label : tiene restricciones de uso de la expresiÃ³nrdfs:label : has use restrictions on the expression</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasUseRestrictionsOnTheExpression</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3019">frbrer:P3019</a>
    /// </summary>
    let P3019 = _prefixId.prefix "P3019"
    /// <summary>
    ///   <para>skos:scopeNote : There may be one or more titles associated with a manifestation. Titles associated with a manifestation include all those that appear in the manifestation itself (e.g., the title on the title page, title frame, etc., a cover title, added title-page title, caption title, running title, spine title, etc., the title in a colophon, explicit, etc., the title on a container, on a microfiche header, etc.), as well as those that have been assigned to the manifestation for purposes of bibliographic control (e.g., key title, expanded title, translated title, supplied title, etc.).</para>
    ///   <para>skos:definition : Relates a manifestation to the word, phrase, or group of characters naming the manifestation.</para>
    ///   <para>rdfs:label : tiene tÃ­tulo de la manifestaciÃ³nrdfs:label : has title of the manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfTheManifestation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3020">frbrer:P3020</a>
    /// </summary>
    let P3020 = _prefixId.prefix "P3020"
    /// <summary>
    ///   <para>skos:scopeNote : An individual or group named may be directly responsible for the work embodied in the manifestation (e.g., the author, composer, etc.), or indirectly responsible (e.g., the author of a novel on which a film script is based). Other individuals or groups named in the statement may include those responsible for the expression of the work contained in the manifestation (e.g., translators, performers, etc.), or those responsible for the compilation of works contained in the manifestation (e.g., the editor, compiler, etc.). A statement of responsibility may name an organization responsible for sponsoring or issuing the work contained in the manifestation. The statement may also indicate the role or function performed by each of the individuals, groups, or organizations responsible. The names appearing in the statement of responsibility in the manifestation may or may not be those of the persons and corporate bodies actually responsible for the creation or realization of the intellectual or artistic content embodied in the manifestation. Similarly, the stated functions may or may not reflect the actual relationship that exists between the individuals and groups named and the intellectual or artistic content.</para>
    ///   <para>skos:definition : Relates a manifestation to a statement appearing in the manifestation (normally in conjunction with the title) that names one or more individuals or groups responsible for the creation or realization of the intellectual or artistic content embodied in the manifestation.</para>
    ///   <para>rdfs:label : tiene menciÃ³n de responsabilidadrdfs:label : has statement of responsibility</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasStatementOfResponsibility</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3021">frbrer:P3021</a>
    /// </summary>
    let P3021 = _prefixId.prefix "P3021"
    /// <summary>
    ///   <para>skos:scopeNote : A series statement may also include a number designating the sequential position of the manifestation within the series. There may be one or more series and, or, subseries named in the manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to the word, phrase, or group of characters appearing in the manifestation naming the series to which the manifestation belongs.</para>
    ///   <para>rdfs:label : tiene menciÃ³n de serierdfs:label : has series statement</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSeriesStatement</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3022">frbrer:P3022</a>
    /// </summary>
    let P3022 = _prefixId.prefix "P3022"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., sound cassette, videodisc, microfilm cartridge, transparency, etc. The carrier for a manifestation comprising multiple physical components may include more than one form (e.g., a filmstrip with an accompanying booklet, a separate sound disc carrying the sound track for a film, etc.).</para>
    ///   <para>skos:definition : Relates a manifestation to the specific class of material to which the physical carrier of the manifestation belongs.</para>
    ///   <para>rdfs:label : tiene forma del soporterdfs:label : has form of carrier</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFormOfCarrier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3023">frbrer:P3023</a>
    /// </summary>
    let P3023 = _prefixId.prefix "P3023"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., number of sheets, discs, reels, etc.</para>
    ///   <para>skos:definition : Relates a manifestation to a quantification of the number of physical units making up the carrier.</para>
    ///   <para>rdfs:label : tiene extensiÃ³n del soporterdfs:label : has extent of the carrier</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExtentOfTheCarrier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3024">frbrer:P3024</a>
    /// </summary>
    let P3024 = _prefixId.prefix "P3024"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., paper, wood, plastic, metal, etc. The physical medium may include in addition to the base material any material that is applied to the base (e.g., oil paint applied to canvas, a chemical emulsion applied to a film base, etc.). Each component of a manifestation comprising multiple physical components may be produced from a different type of material.</para>
    ///   <para>skos:definition : Relates a manifestation to the type of material from which the carrier is produced.</para>
    ///   <para>rdfs:label : tiene soporte fÃ­sicordfs:label : has physical medium</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPhysicalMedium</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3025">frbrer:P3025</a>
    /// </summary>
    let P3025 = _prefixId.prefix "P3025"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., analogue, acoustic, electric, digital, optical etc.</para>
    ///   <para>skos:definition : Relates a manifestation to the means used to record notation, sound, or images in the production of a manifestation.</para>
    ///   <para>rdfs:label : tiene modo de capturardfs:label : has capture mode</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCaptureMode</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3026">frbrer:P3026</a>
    /// </summary>
    let P3026 = _prefixId.prefix "P3026"
    /// <summary>
    ///   <para>skos:scopeNote : The dimensions may comprise measurements of height (e.g., 18 cm bound volume), width (e.g., 8mm film), height x width (e.g., 5 x 5 cm slide), height x width x depth (e.g., 9 x 30 x 20 cm model), or diameter (e.g., 30 cm disc).</para>
    ///   <para>skos:definition : Relates a manifestation to the measurements of the physical components and, or, the container of the manifestation.</para>
    ///   <para>rdfs:label : tiene dimensiones del soporterdfs:label : has dimensions of the carrier</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDimensionsOfTheCarrier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3027">frbrer:P3027</a>
    /// </summary>
    let P3027 = _prefixId.prefix "P3027"
    /// <summary>
    ///   <para>skos:scopeNote : A manifestation may have one or more identifiers associated with it. The identifier may be assigned as part of an international numbering or coding system (e.g., ISBN, etc.), as part of a national system (e.g., legal deposit number), or it may be assigned independently by the publisher or distributor of the manifestation (e.g., government publication number, music publisher's number, clearinghouse inventory number, etc.). A manifestation identifier may also be assigned by a bibliographer, musicologist, etc. The manifestation identifier may comprise both a numeric component and a textual or coded component identifying the system under which it was assigned and, or, the agency or individual that assigned the number, so as to render the identifier unique to the manifestation.</para>
    ///   <para>skos:definition : Relates a manifestation to a number or code uniquely associated with the manifestation that serves to differentiate that manifestation from any other manifestation.</para>
    ///   <para>rdfs:label : tiene identificador del manifestaciÃ³nrdfs:label : has manifestation identifier</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasManifestationIdentifier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3028">frbrer:P3028</a>
    /// </summary>
    let P3028 = _prefixId.prefix "P3028"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., free to members of a particular association.</para>
    ///   <para>skos:definition : Relates a manifestation to the terms indicated in the manifestation under which the supplier (i.e., the source for acquisition or access authorization) will normally make the manifestation available, or the price for which the manifestation sells.</para>
    ///   <para>rdfs:label : tiene condiciones de disponibilidadrdfs:label : has terms of availability</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermsOfAvailability</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3029">frbrer:P3029</a>
    /// </summary>
    let P3029 = _prefixId.prefix "P3029"
    /// <summary>
    ///   <para>skos:scopeNote : Access restrictions may be based in copyright, or they may extend beyond the protections guaranteed in law to the owner of the copyright.</para>
    ///   <para>skos:definition : Relates a manifestation to restrictions on access to and use of a manifestation.</para>
    ///   <para>rdfs:label : tiene restricciones de acceso a la manifestaciÃ³nrdfs:label : has access restrictions on the manifestation</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAccessRestrictionsOnTheManifestation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3030">frbrer:P3030</a>
    /// </summary>
    let P3030 = _prefixId.prefix "P3030"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., call number, accession number, bar code, etc. The number is normally assigned by the institution that holds the item. The item identifier may also include a name or code identifying the institution or repository in which the item is housed, and a name or code identifying a particular collection or sub-unit within the institution (e.g., a rare book collection, a branch library, etc.).</para>
    ///   <para>skos:definition : Relates an item to a number or code that is uniquely associated with the item, and serves to differentiate that item from any other item in the same collection and, or, institution.</para>
    ///   <para>rdfs:label : tiene identificador del ejemplarrdfs:label : has item identifier</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasItemIdentifier</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3031">frbrer:P3031</a>
    /// </summary>
    let P3031 = _prefixId.prefix "P3031"
    /// <summary>
    ///   <para>skos:scopeNote : The technique is used primarily to signal differences between individual copies of early printed books. There are various formulae for constructing the fingerprint (e.g., the one specified in Fingerprints = Empreintes = Impronte, published by the Institut de Recherche et dâ€™Histoire des Textes in Paris).</para>
    ///   <para>skos:definition : Relates an item to an identifier constructed by combining groups of characters transcribed from specified pages of a printed item.</para>
    ///   <para>rdfs:label : tiene huella tipogrÃ¡ficardfs:label : has fingerprint</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFingerprint</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3032">frbrer:P3032</a>
    /// </summary>
    let P3032 = _prefixId.prefix "P3032"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a record of previous ownership or custodianship of the item.</para>
    ///   <para>rdfs:label : tiene procedencia del ejemplarrdfs:label : has provenance of the item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasProvenanceOfTheItem</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3033">frbrer:P3033</a>
    /// </summary>
    let P3033 = _prefixId.prefix "P3033"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a record of public exhibitions of an item, including dates, venues, etc.</para>
    ///   <para>rdfs:label : tiene historial de exposicionesrdfs:label : has exhibition history</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExhibitionHistory</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3034">frbrer:P3034</a>
    /// </summary>
    let P3034 = _prefixId.prefix "P3034"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., missing pages, plates, etc. Condition may reflect other aspects of the physical condition of the item as well (e.g., brittleness, faded images, etc.).</para>
    ///   <para>skos:definition : Relates an item to the physical condition of the item, particularly any variances between the physical makeup of the item and that of the manifestation it exemplifies.</para>
    ///   <para>rdfs:label : tiene estado del ejemplarrdfs:label : has condition of the item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasConditionOfTheItem</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3035">frbrer:P3035</a>
    /// </summary>
    let P3035 = _prefixId.prefix "P3035"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., deacidification, restoration, etc. Treatment history may also comprise details of the treatment process (e.g., chemical solutions used, techniques applied, etc.), the date the treatment was applied, etc.</para>
    ///   <para>skos:definition : Relates an item to a record of the treatment the item has undergone.</para>
    ///   <para>rdfs:label : tiene historial de tratamientosrdfs:label : has treatment history</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTreatmentHistory</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3036">frbrer:P3036</a>
    /// </summary>
    let P3036 = _prefixId.prefix "P3036"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., chemical wash. Scheduled treatment may also comprise details of the planned treatment process and the scheduled date of application.</para>
    ///   <para>skos:definition : Relates an item to a plan for future treatment of the item.</para>
    ///   <para>rdfs:label : tiene tratamiento programadordfs:label : has scheduled treatment</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScheduledTreatment</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3037">frbrer:P3037</a>
    /// </summary>
    let P3037 = _prefixId.prefix "P3037"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., restricted to supervised on-site use, etc.</para>
    ///   <para>skos:definition : Relates an item to any limitations placed on physical access to the item.</para>
    ///   <para>rdfs:label : tiene restricciones de acceso al ejemplarrdfs:label : has access restrictions on the item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAccessRestrictionsOnTheItem</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3038">frbrer:P3038</a>
    /// </summary>
    let P3038 = _prefixId.prefix "P3038"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Donald Horne, A. A. Milne, Ellery Queen, etc. A name may include one or more forenames (or given names), matronymics, patronymics, family names (or surnames), sobriquets, dynastic names, etc. A person may be known by more than one name, or by more than one form of the same name. A bibliographic agency normally selects one of those names as the uniform heading for purposes of consistency in naming and referencing the person. The other names or forms of name may be treated as variant names for the person. In some cases (e.g., in the case of a person who writes under more than one pseudonym, or a person who writes both in an official capacity and as an individual) the bibliographic agency may establish more than one uniform heading for the person.</para>
    ///   <para>skos:definition : Relates a person to the word, character, or group of words and, or, characters by which the person is known.</para>
    ///   <para>rdfs:label : tiene nombre de personardfs:label : has name of person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameOfPerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3039">frbrer:P3039</a>
    /// </summary>
    let P3039 = _prefixId.prefix "P3039"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "includes" prefixing the definition, interpreted as "and other dates" in the property description.</para>
    ///   <para>skos:definition : Relates a person to the precise or approximate date of the person's birth and, or, death, or dates indicating the period in which the person was known to be active in a given field of endeavour, and other dates.</para>
    ///   <para>rdfs:label : tiene fechas de personardfs:label : has dates of person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDatesOfPerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3040">frbrer:P3040</a>
    /// </summary>
    let P3040 = _prefixId.prefix "P3040"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Major, Premier, Duke, etc.; Sir, Mrs., etc.</para>
    ///   <para>skos:definition : Relates a person to a word or phrase indicative of rank, office, nobility, honour, etc., or a term of address associated with the person.</para>
    ///   <para>rdfs:label : tiene calificativo de personardfs:label : has title of person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTitleOfPerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3041">frbrer:P3041</a>
    /// </summary>
    let P3041 = _prefixId.prefix "P3041"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., III, Jr., etc.; the Brave, Professional Engineer, etc.</para>
    ///   <para>skos:definition : Relates a person to a numeral, word, or abbreviation indicating succession within a family or dynasty, or an epithet or other word or phrase associated with the person.</para>
    ///   <para>rdfs:label : tiene otras designaciones asociadas con la personardfs:label : has other designation associated with the person</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherDesignationAssociatedWithThePerson</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3042">frbrer:P3042</a>
    /// </summary>
    let P3042 = _prefixId.prefix "P3042"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Royal Aeronautical Society, IBM, SÃ©minaire europÃ©en sur la recherche en Ã©ducation, Friedrich Witte, etc. A corporate body may be known by more than one name, or more than one form of the same name. A bibliographic agency normally selects one of those names as the uniform heading for purposes of consistency in naming and referencing the corporate body. The other names or forms of name may be treated as variant names for the corporate body. In some cases (e.g., in the case where a corporate body is known by different names at different periods in its history) the bibliographic agency may establish more than one uniform heading for the corporate body.</para>
    ///   <para>skos:definition : Relates a corporate body to the word, phrase, character, or group of words and, or, characters by which the body is known.</para>
    ///   <para>rdfs:label : tiene nombre de entidad corporativardfs:label : has name of the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNameOfTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3043">frbrer:P3043</a>
    /// </summary>
    let P3043 = _prefixId.prefix "P3043"
    /// <summary>
    ///   <para>skos:definition : Relates a corporate body to the numerical designation sequencing a meeting, conference, exhibition, fair, etc. that constitutes one of a series of related meetings, conferences, exhibitions, fairs, etc., or any other numerical designation associated with a corporate body.</para>
    ///   <para>rdfs:label : tiene nÃºmero asociado a la entidad corporativardfs:label : has number associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberAssociatedWithTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3044">frbrer:P3044</a>
    /// </summary>
    let P3044 = _prefixId.prefix "P3044"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Los Angeles, Bretton Woods, Oxford University, etc. The place may comprise the name of the state, province, territory, and, or, country as well as the local place name.</para>
    ///   <para>skos:definition : Relates a corporate body to the city, town, or other designation of location in which a meeting, conference, exhibition, fair, etc. was held, or the location with which the corporate body is otherwise associated.</para>
    ///   <para>rdfs:label : tiene lugar asociado a la entidad corporativardfs:label : has place associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceAssociatedWithTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3045">frbrer:P3045</a>
    /// </summary>
    let P3045 = _prefixId.prefix "P3045"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., the date of incorporation.</para>
    ///   <para>skos:definition : Relates a corporate body to the date or range of dates on which a meeting, conference, exhibition, fair, etc. was held, or a date with which the corporate body is otherwise associated.</para>
    ///   <para>rdfs:label : tiene fecha asociada a la entidad corporativardfs:label : has date associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateAssociatedWithTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3046">frbrer:P3046</a>
    /// </summary>
    let P3046 = _prefixId.prefix "P3046"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Inc., Ltd., etc.; firm, musical group, etc.</para>
    ///   <para>skos:definition : Relates a corporate body to a word, phrase, or abbreviation indicating incorporation or legal status of the body, or any term serving to differentiate the body from other corporate bodies, persons, etc.</para>
    ///   <para>rdfs:label : tiene otra designaciÃ³n asociada a la entidad corporativardfs:label : has other designation associated with the corporate body</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasOtherDesignationAssociatedWithTheCorporateBody</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3047">frbrer:P3047</a>
    /// </summary>
    let P3047 = _prefixId.prefix "P3047"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., economics, existentialism, radioactivity, etc. A concept may be designated by more than one term, or by more than one form of the term. A bibliographic agency normally selects one of those terms as the uniform heading for purposes of consistency in naming and referencing the concept. The other terms or forms of term may be treated as variant terms for the concept.</para>
    ///   <para>skos:definition : Relates a concept to the word, phrase, or group of characters used to name or designate the concept.</para>
    ///   <para>rdfs:label : tiene tÃ©rmino del conceptordfs:label : has term for the concept</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermForTheConcept</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3048">frbrer:P3048</a>
    /// </summary>
    let P3048 = _prefixId.prefix "P3048"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., a building, a ship, etc. An object may be designated by more than one term, or by more than one form of the term. A bibliographic agency normally selects one of those terms as the uniform heading for purposes of consistency in naming and referencing the object. The other terms or forms of term may be treated as variant terms for the object.</para>
    ///   <para>skos:definition : Relates an object to the word, phrase, or group of characters used to name or designate the object.</para>
    ///   <para>rdfs:label : tiene tÃ©rmino del objetordfs:label : has term for the object</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermForTheObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3049">frbrer:P3049</a>
    /// </summary>
    let P3049 = _prefixId.prefix "P3049"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Battle of Hastings, Tour de France, etc. An event may be designated by more than one term, or by more than one form of the term. A bibliographic agency normally selects one of those terms as the uniform heading for purposes of consistency in naming and referencing the event. The other terms or forms of term may be treated as variant terms for the event.</para>
    ///   <para>skos:definition : Relates an event to the word, phrase, or group of characters used to name or designate the event.</para>
    ///   <para>rdfs:label : tiene tÃ©rmino del acontecimientordfs:label : has term for the event</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermForTheEvent</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3050">frbrer:P3050</a>
    /// </summary>
    let P3050 = _prefixId.prefix "P3050"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., London, St. Lawrence River, etc. A place may be designated by more than one term, or by more than one form of the term. A bibliographic agency normally selects one of those terms as the uniform heading for purposes of consistency in naming and referencing the place. The other terms or forms of term may be treated as variant terms for the place.</para>
    ///   <para>skos:definition : Relates a place to the word, phrase, or group of characters used to name or designate the place.</para>
    ///   <para>rdfs:label : tiene tÃ©rmino del lugarrdfs:label : has term for the place</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTermForThePlace</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3051">frbrer:P3051</a>
    /// </summary>
    let P3051 = _prefixId.prefix "P3051"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "marks/inscriptions"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>skos:definition : Relates an item to any signatures, numbering, annotations, etc. that have been applied uniquely to the item by the artist, fabricator, owner, etc., and other marks and inscriptions.</para>
    ///   <para>rdfs:label : tiene marcas o inscripcionesrdfs:label : has marks or inscriptions</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMarksOrInscriptions</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3052">frbrer:P3052</a>
    /// </summary>
    let P3052 = _prefixId.prefix "P3052"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSourceForAcquisitionOrAccessAuthorization</para>
    ///   <para>rdfs:label : tiene fuente de adquisiciÃ³n o autorizaciÃ³n para el accesordfs:label : has source for acquisition or access authorization</para>
    ///   <para>rdfs:comment : Source documentation has "acquisition/access"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>skos:scopeNote : The source for acquisition/access authorization will normally also include an address for the publisher, distributor, etc. A manifestation may be associated with one or more sources.</para>
    ///   <para>skos:definition : Relates a manifestation to the name of a publisher, distributor, etc. indicated in the manifestation as the source from which the manifestation may be acquired or through whom access may be authorized.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3053">frbrer:P3053</a>
    /// </summary>
    let P3053 = _prefixId.prefix "P3053"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "fabricator/manufacturer"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>skos:scopeNote : A manifestation may be associated with one or more fabricators or manufacturers.</para>
    ///   <para>rdfs:label : has fabricator or manufacturerrdfs:label : tiene fabricante o productor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFabricatorOrManufacturer</para>
    ///   <para>skos:definition : Relates a manifestation to the individual, group, or organization named in the manifestation as being responsible for the fabrication or manufacture of the manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3054">frbrer:P3054</a>
    /// </summary>
    let P3054 = _prefixId.prefix "P3054"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation to the date of public release of the manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasDateOfPublicationOrDistribution</para>
    ///   <para>rdfs:comment : Source documentation has "publication/distribution"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>rdfs:label : tiene fecha de publicaciÃ³n o distribuciÃ³nrdfs:label : has date of publication or distribution</para>
    ///   <para>skos:scopeNote : The date (normally a year) may be a single date of publication or release, or a range of dates (e.g., in the case of a serial publication). In the absence of a date designated as the date of publication or release, a copyright date or a date of printing or manufacture may serve as a substitute.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3055">frbrer:P3055</a>
    /// </summary>
    let P3055 = _prefixId.prefix "P3055"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "publisher/distributor"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>rdfs:label : has publisher or distributorrdfs:label : tiene editor o distribuidor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPublisherOrDistributor</para>
    ///   <para>skos:scopeNote : A manifestation may be associated with one or more publishers or distributors.</para>
    ///   <para>skos:definition : Relates a manifestation to the individual, group, or organization named in the manifestation as being responsible for the publication, distribution, issuing, or release of the manifestation.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3056">frbrer:P3056</a>
    /// </summary>
    let P3056 = _prefixId.prefix "P3056"
    /// <summary>
    ///   <para>rdfs:label : has place of publication or distributionrdfs:label : tiene lugar de publicaciÃ³n o distribuciÃ³n</para>
    ///   <para>skos:definition : Relates a manifestation to the city, town, or other locality associated in the manifestation with the name of the publisher or distributor.</para>
    ///   <para>skos:scopeNote : The place of publication may comprise the name of the state, province, territory, and/or country as well as the local place name. A manifestation may be associated with one or more places of publication or distribution.</para>
    ///   <para>rdfs:comment : Source documentation has "publication/distribution"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlaceOfPublicationOrDistribution</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3057">frbrer:P3057</a>
    /// </summary>
    let P3057 = _prefixId.prefix "P3057"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "edition/issue"; slash character replaced with "or" to improve clarity.</para>
    ///   <para>rdfs:label : has edition or issue designationrdfs:label : tiene designaciÃ³n de ediciÃ³n o emisiÃ³n</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEditionOrIssueDesignation</para>
    ///   <para>skos:scopeNote : The edition/issue designation pertains to all copies of a manifestation produced from substantially the same master and issued by the same publisher/distributor or group of publishers/distributors.</para>
    ///   <para>skos:definition : Relates a manifestation to a word or phrase appearing in the manifestation that normally indicates a difference in either content or form between the manifestation and a related manifestation previously issued by the same publisher/distributor, or simultaneously issued by either the same publisher/distributor or another publisher/distributor.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3058">frbrer:P3058</a>
    /// </summary>
    let P3058 = _prefixId.prefix "P3058"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., piano, violin, orchestra, men's voices, etc.</para>
    ///   <para>skos:definition : Relates a work that is musical to the instrumental, vocal, and, or, other medium of performance for which the work was originally intended.</para>
    ///   <para>rdfs:label : tiene medio de interpretaciÃ³n (obra musical)rdfs:label : has medium of performance (musical work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMediumOfPerformanceMusicalWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3059">frbrer:P3059</a>
    /// </summary>
    let P3059 = _prefixId.prefix "P3059"
    /// <summary>
    ///   <para>skos:definition : Relates a work that is musical to a serial number, opus number, or thematic index number assigned to thel work by the composer, publisher, or a musicologist.</para>
    ///   <para>rdfs:label : tiene designaciÃ³n numÃ©rica (obra musical)rdfs:label : has numeric designation (musical work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumericDesignationMusicalWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3060">frbrer:P3060</a>
    /// </summary>
    let P3060 = _prefixId.prefix "P3060"
    /// <summary>
    ///   <para>skos:scopeNote : The key for a musical work is the key in which the work is originally composed.</para>
    ///   <para>skos:definition : Relates a work that is musical to the set of pitch relationships that establishes a single pitch class as a tonal centre.</para>
    ///   <para>rdfs:label : tiene clave (obra musical)rdfs:label : has key (musical work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasKeyMusicalWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3061">frbrer:P3061</a>
    /// </summary>
    let P3061 = _prefixId.prefix "P3061"
    /// <summary>
    ///   <para>skos:definition : Relates a work that is cartographic to the degrees, minutes, and seconds of longitude and latitude, or the angles of declination and ascension that form the outer boundaries for the area represented in the cartographic image or object.</para>
    ///   <para>rdfs:label : tiene coordenadas (obra cartogrÃ¡fica)rdfs:label : has coordinates (cartographic work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCoordinatesCartographicWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3062">frbrer:P3062</a>
    /// </summary>
    let P3062 = _prefixId.prefix "P3062"
    /// <summary>
    ///   <para>skos:definition : Relates a work that is cartographic to the year that serves as the point of reference for a celestial chart or model.</para>
    ///   <para>rdfs:label : tiene equinoccio (obra cartogrÃ¡fica)rdfs:label : has equinox (cartographic work)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasEquinoxCartographicWork</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3063">frbrer:P3063</a>
    /// </summary>
    let P3063 = _prefixId.prefix "P3063"
    /// <summary>
    ///   <para>skos:definition : Relates an expression issued as a serial to the form anticipated to be used in designating volumes, issues, etc. and, or, dates for the individual units of the serial.</para>
    ///   <para>rdfs:label : tiene modelo de secuencia (publicaciÃ³n seriada)rdfs:label : has sequencing pattern (serial)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSequencingPatternSerial</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3064">frbrer:P3064</a>
    /// </summary>
    let P3064 = _prefixId.prefix "P3064"
    /// <summary>
    ///   <para>skos:definition : Relates an expression issued as a serial to the anticipated regularity of release of individual issues (i.e., whether the release is expected to be regular or irregular).</para>
    ///   <para>rdfs:label : tiene regularidad prevista de la publicaciÃ³n (publicaciÃ³n seriada)rdfs:label : has expected regularity of issue (serial)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExpectedRegularityOfIssueSerial</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3065">frbrer:P3065</a>
    /// </summary>
    let P3065 = _prefixId.prefix "P3065"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., weekly, monthly, quarterly, annually, etc.</para>
    ///   <para>skos:definition : Relates an expression issued as a serial to the interval at which individual issues of the serial are anticipated to be released.</para>
    ///   <para>rdfs:label : tiene frecuencia de publicaciÃ³n prevista (publicaciÃ³n seriada)rdfs:label : has expected frequency of issue (serial)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasExpectedFrequencyOfIssueSerial</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3066">frbrer:P3066</a>
    /// </summary>
    let P3066 = _prefixId.prefix "P3066"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., short score, full score, condensed score, close score, etc.</para>
    ///   <para>skos:definition : Relates an expression that is a musical notation to the format used to represent a musical composition.</para>
    ///   <para>rdfs:label : tiene tipo de partitura (notaciÃ³n musical)rdfs:label : has type of score (musical notation)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeOfScoreMusicalNotation</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3067">frbrer:P3067</a>
    /// </summary>
    let P3067 = _prefixId.prefix "P3067"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., two pianos, soprano and alto, etc.</para>
    ///   <para>skos:definition : Relates an expression that is a musical notation or recorded sound to the instrumental and, or, vocal medium of performance of a musical work represented in the expression. The instruments and, or, voices represented in a particular expression of a work may differ from the medium of performance for which the work was originally intended.</para>
    ///   <para>rdfs:label : tiene medio de interpretaciÃ³n (notaciÃ³n musical o registro sonoro)rdfs:label : has medium of performance (musical notation or recorded sound)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasMediumOfPerformanceMusicalNotationExpressionOrRecordedSound</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3068">frbrer:P3068</a>
    /// </summary>
    let P3068 = _prefixId.prefix "P3068"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., multispectral photography, infrared line scanning, SLAR, passive microwave mapping, etc.</para>
    ///   <para>skos:definition : Relates an expression that is a remote sensing image to the technique used to capture the image through remote sensing.</para>
    ///   <para>rdfs:label : tiene tÃ©cnica de grabaciÃ³n (imagen sensible remota)rdfs:label : has recording technique (remote sensing image)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRecordingTechniqueRemoteSensingImage</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3070">frbrer:P3070</a>
    /// </summary>
    let P3070 = _prefixId.prefix "P3070"
    /// <summary>
    ///   <para>skos:definition : Relates an expression that is a remote sensing image to the altitude and attitude of the sensor, the position of the platform, the category and name of the satellite, the number of spectral bands involved, the quality of the image, the extent of cloud cover, or the mean value of the ground resolution.</para>
    ///   <para>rdfs:label : tiene caracterÃ­sticas especiales (imagen sensibel remota)rdfs:label : has special characteristic (remote sensing image)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSpecialCharacteristicRemoteSensingImage</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3071">frbrer:P3071</a>
    /// </summary>
    let P3071 = _prefixId.prefix "P3071"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., engraving, etc.</para>
    ///   <para>skos:definition : Relates an expression that is a graphic or projected image to the method used to create it.</para>
    ///   <para>rdfs:label : tiene tÃ©cnica (imagen grÃ¡fica o proyectada)rdfs:label : has technique (graphic or projected image)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTechniqueGraphicOrProjectedImage</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3072">frbrer:P3072</a>
    /// </summary>
    let P3072 = _prefixId.prefix "P3072"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Baskerville, Times New Roman, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a printed book to the style of type used to print it.</para>
    ///   <para>rdfs:label : tiene tipografÃ­a (libros impresos)rdfs:label : has typeface (printed book)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypefacePrintedBook</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3074">frbrer:P3074</a>
    /// </summary>
    let P3074 = _prefixId.prefix "P3074"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation that is a printed book to the size of the characters in it.</para>
    ///   <para>rdfs:label : tiene tamaÃ±o del tipo (libro impreso)rdfs:label : has type size (printed book)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTypeSizePrintedBook</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3075">frbrer:P3075</a>
    /// </summary>
    let P3075 = _prefixId.prefix "P3075"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., a sheet folded twice to form a quarto, three times to form an octavo, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a hand-printed book to a reflection of the number of folds made in a printed sheet to form a gathering of leaves.</para>
    ///   <para>rdfs:label : tiene foliaciÃ³n (imprenta manual)rdfs:label : has foliation (hand-printed book)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFoliationHandPrintedBook</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3076">frbrer:P3076</a>
    /// </summary>
    let P3076 = _prefixId.prefix "P3076"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., four gatherings bearing signatures A through D.</para>
    ///   <para>skos:definition : Relates a manifestation that is a hand-printed book to a reflection of the sequence of gatherings in the book as indicated by signatures on each gathering.</para>
    ///   <para>rdfs:label : tiene colaciÃ³n (imprenta manual)rdfs:label : has collation (hand-printed book)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasCollationHandPrintedBook</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3077">frbrer:P3077</a>
    /// </summary>
    let P3077 = _prefixId.prefix "P3077"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation that is a serial to its status with respect to its continuing publication (i.e., whether it is currently published or has ceased publication).</para>
    ///   <para>rdfs:label : tiene estado de la publicaciÃ³n (publicaciÃ³n seriada)rdfs:label : has publication status (serial)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPublicationStatusSerial</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3078">frbrer:P3078</a>
    /// </summary>
    let P3078 = _prefixId.prefix "P3078"
    /// <summary>
    ///   <para>skos:scopeNote : The numbering may comprise a numeric, alphabetic and, or, a date component (e.g., Volume 1, number 1 (January 1971)).</para>
    ///   <para>skos:definition : Relates a manifestation that is a serial to the designation of volume, issue, etc. and, or, date appearing in it.</para>
    ///   <para>rdfs:label : tiene numeraciÃ³n (publicaciÃ³n seriada)rdfs:label : has numbering (serial)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasNumberingSerial</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3079">frbrer:P3079</a>
    /// </summary>
    let P3079 = _prefixId.prefix "P3079"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., 33 1/3 rpm, 19 cm/s, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to the speed at which the carrier must be operated to produce the sound intended.</para>
    ///   <para>rdfs:label : tiene velocidad de reproducciÃ³n (grabaciÃ³n sonora)rdfs:label : has playing speed (sound recording)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPlayingSpeedSoundRecording</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3080">frbrer:P3080</a>
    /// </summary>
    let P3080 = _prefixId.prefix "P3080"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., microgroove--i.e., 200 grooves per inch.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to an indication of the number of grooves per inch cut on a disc or cylinder.</para>
    ///   <para>rdfs:label : tiene anchura del surcordfs:label : has groove width</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGrooveWidth</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3081">frbrer:P3081</a>
    /// </summary>
    let P3081 = _prefixId.prefix "P3081"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., lateral, vertical, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to the direction in which the grooves are cut on a disc or cylinder.</para>
    ///   <para>rdfs:label : has kind of cutting (sound recording)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasKindOfCuttingSoundRecording</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3082">frbrer:P3082</a>
    /// </summary>
    let P3082 = _prefixId.prefix "P3082"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., eight track, twelve track.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to the number of tracks on a sound tape.</para>
    ///   <para>rdfs:label : tiene configuraciÃ³n de la cinta (grabaciÃ³n sonora)rdfs:label : has tape configuration (sound recording)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasTapeConfigurationSoundRecording</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3083">frbrer:P3083</a>
    /// </summary>
    let P3083 = _prefixId.prefix "P3083"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Monaural, stereophonic, quadraphonic, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to a reflection of the number of sound channels used to make the recording.</para>
    ///   <para>rdfs:label : tiene tipo de sonido (grabaciÃ³n sonora)rdfs:label : has kind of sound (sound recording)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasKindOfSoundSoundRecording</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3084">frbrer:P3084</a>
    /// </summary>
    let P3084 = _prefixId.prefix "P3084"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., NAB, DBX, Dolby, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a sound recording to the equalization system, noise reduction system, etc. used in making the recording.</para>
    ///   <para>rdfs:label : tiene caracterÃ­sticas especiales de la reproducciÃ³n  (grabaciÃ³n sonora)rdfs:label : has special reproduction characteristic (sound recording)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSpecialReproductionCharacteristicSoundRecording</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3085">frbrer:P3085</a>
    /// </summary>
    let P3085 = _prefixId.prefix "P3085"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation that is an image to the colour(s), tone(s), etc. (including black and white) used in the production of the image.</para>
    ///   <para>rdfs:label : tiene color (imagen)rdfs:label : has colour (image)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasColourImage</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3086">frbrer:P3086</a>
    /// </summary>
    let P3086 = _prefixId.prefix "P3086"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., 42x, etc. Reduction ratio may also be indicated as a range (e.g., very high reduction indicates a reduction in the range of 61x to 90x).</para>
    ///   <para>skos:definition : Relates a manifestation that is a microform to the degree to which a text or image has been reduced in the process of microfilming.</para>
    ///   <para>rdfs:label : tiene escala de reducciÃ³n (microforma)rdfs:label : has reduction ratio (microform)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasReductionRatioMicroform</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3087">frbrer:P3087</a>
    /// </summary>
    let P3087 = _prefixId.prefix "P3087"
    /// <summary>
    ///   <para>skos:scopeNote : When the colours and tones in the film image reflect directly the colour and tones of the object filmed, the polarity is positive. When they are the reverse of the object the polarity is negative. The polarity of images in a manifestation comprising more than one image may be mixed.</para>
    ///   <para>skos:definition : Relates a manifestation that is a microform or visual projection to the relationship of the colours and tones in the image on film to the colours and tones of the object filmed.</para>
    ///   <para>rdfs:label : tiene polaridad (microforma o proyecciÃ³n visual)rdfs:label : has polarity (microform or visual projection)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPolarityMicroformOrVisualProjection</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3088">frbrer:P3088</a>
    /// </summary>
    let P3088 = _prefixId.prefix "P3088"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., a first generation camera master, a second generation printing master, a third generation service copy, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a microform or visual projection to a reflection of the number of times the image on film has been transferred from one carrier to another.</para>
    ///   <para>rdfs:label : tiene generaciÃ³n (microforma o proyecciÃ³n visual)rdfs:label : has generation (microform or visual projection)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGenerationMicroformOrVisualProjection</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3089">frbrer:P3089</a>
    /// </summary>
    let P3089 = _prefixId.prefix "P3089"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., wide screen, Beta, VHS, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a visual projection to the format used in the production of the projected image.</para>
    ///   <para>rdfs:label : tiene formato de presentaciÃ³n (proyecciÃ³n visual)rdfs:label : has presentation format (visual projection)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPresentationFormatVisualProjection</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3090">frbrer:P3090</a>
    /// </summary>
    let P3090 = _prefixId.prefix "P3090"
    /// <summary>
    ///   <para>skos:scopeNote :  E.g., machine make and model, RAM capacity, etc. E.g., operating systems, programming language, supporting software, etc. Peripherals include monitor, printer, mouse, etc.</para>
    ///   <para>rdfs:label : has system requirements (electronic resource)rdfs:label : tiene requisitos del sistema (recurso electrÃ³nico)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasSystemRequirementsElectronicResource</para>
    ///   <para>skos:definition : Relates a manifestation that is an electronic resource to requirements related to hardware, software, and peripherals, and other system components.</para>
    ///   <para>rdfs:comment : Source documentation has "includes" prefixing the definition, interpreted as "and other system components" in the property description.</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3093">frbrer:P3093</a>
    /// </summary>
    let P3093 = _prefixId.prefix "P3093"
    /// <summary>
    ///   <para>skos:definition : Relates a manifestation that is an electronic resource to standards or schemes used to encode the file, physical characteristics of the file, and other characteristics that have a bearing on how the file can be processed.</para>
    ///   <para>skos:scopeNote : E.g., ASCII, SGML, etc. E.g., recording density, parity, blocking, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasFileCharacteristicsElectronicResource</para>
    ///   <para>rdfs:comment : Source documentation has "include" prefixing the definition, removed for being redundant with respect to "and other characteristics" in the property description.</para>
    ///   <para>rdfs:label : has file characteristics (electronic resource)rdfs:label : tiene caracterÃ­sticas del archivo (recurso electrÃ³nico)</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3094">frbrer:P3094</a>
    /// </summary>
    let P3094 = _prefixId.prefix "P3094"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., Internet, World Wide Web, etc.</para>
    ///   <para>skos:definition : Relates a manifestation that is a remote electronic resource to the means of accessing it.</para>
    ///   <para>rdfs:label : tiene modo de acceso (recurso electrÃ³nico de acceso remoto)rdfs:label : has mode of access (remote electronic resource)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasModeOfAccessRemoteElectronicResource</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3095">frbrer:P3095</a>
    /// </summary>
    let P3095 = _prefixId.prefix "P3095"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., universal resource locator â€“ URL.</para>
    ///   <para>skos:definition : Relates a manifestation that is a remote electronic resource to an alpha-numeric code used to facilitate remote access to it.</para>
    ///   <para>rdfs:label : tiene direcciÃ³n de acceso (recurso electrÃ³nico de acceso remoto)rdfs:label : has access address (remote electronic resource)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasAccessAddressRemoteElectronicResource</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3096">frbrer:P3096</a>
    /// </summary>
    let P3096 = _prefixId.prefix "P3096"
    /// <summary>
    ///   <para>skos:scopeNote : Scale may apply to horizontal, vertical, angular, and, or, other distances represented in the expression.</para>
    ///   <para>skos:definition : Relates an expression that is cartographic to the ratio of distances in the expression to the actual distances they represent.</para>
    ///   <para>rdfs:label : tiene escala (imagen cartogrÃ¡fica u objeto)rdfs:label : has scale (cartographic image or object)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasScaleCartographicImageOrObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3097">frbrer:P3097</a>
    /// </summary>
    let P3097 = _prefixId.prefix "P3097"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., transverse Mercator, azimuthal equidistant, etc.</para>
    ///   <para>skos:definition : Relates an expression that is cartographic to the method or system used to represent the surface of the Earth or of a celestial sphere on a plane.</para>
    ///   <para>rdfs:label : tiene proyecciÃ³n (imagen cartogrÃ¡fica u objeto)rdfs:label : has projection (cartographic image or object)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasProjectionCartographicImageOrObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3098">frbrer:P3098</a>
    /// </summary>
    let P3098 = _prefixId.prefix "P3098"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., anaglyphic, diagrammatic, pictorial, etc.</para>
    ///   <para>skos:definition : Relates an expression that is cartographic to the method used to represent geographic or other features in a cartographic image.</para>
    ///   <para>rdfs:label : tiene tÃ©cnica de presentaciÃ³n (imagen cartogrÃ¡fica u objeto)rdfs:label : has presentation technique (cartographic image or object)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasPresentationTechniqueCartographicImageOrObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3099">frbrer:P3099</a>
    /// </summary>
    let P3099 = _prefixId.prefix "P3099"
    /// <summary>
    ///   <para>skos:scopeNote : E.g., contours, shading, hachures, spot heights, bathymetric tints, etc.</para>
    ///   <para>skos:definition : Relates an expression that is cartographic to the technique used to depict the elevations or the inequalities of a land surface or of the bed of a body of water in a cartographic image.</para>
    ///   <para>rdfs:label : tiene representaciÃ³n de relieve (imagen cartogrÃ¡fica u objeto)rdfs:label : has representation of relief (cartographic image or object)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasRepresentationOfReliefCartographicImageOrObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3100">frbrer:P3100</a>
    /// </summary>
    let P3100 = _prefixId.prefix "P3100"
    /// <summary>
    ///   <para>rdfs:comment : Source documentation has "includes" prefixing the definition, interpreted as "and other geodetic, grid and vertical measurements" in the property description.</para>
    ///   <para>skos:definition : Relates an expression that is cartographic to information on the spheroid used to construct the cartographic image, the grid or referencing systems used in the image, horizontal datum, vertical datum, mathematical data on contour intervals, bathymetric intervals, etc., and other geodetic, grid and vertical measurements.</para>
    ///   <para>rdfs:label : tiene geodÃ©sic, cuadrÃ­cula y medida vertical (imagen cartogrÃ¡fica u objeto)rdfs:label : has geodetic, grid and vertical measurement (cartographic image or object)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : hasGeodeticGridAndVerticalMeasurementCartographicImageOrObject</para>
    ///   <a href="http://iflastandards.info/ns/fr/frbr/frbrer/P3101">frbrer:P3101</a>
    /// </summary>
    let P3101 = _prefixId.prefix "P3101"
