#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module rdai =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/i/" "rdai"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A character string associated with an item that serves to differentiate that item from other items.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : identifierForTheItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : identifier for the item</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.2^^xsd:string</para>
    ///   <para>rdfs:label : has identifier for the item</para>
    ///   <para>skos:definition : Relates an item to a character string associated with an item that serves to differentiate that item from other items.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40001">rdai:P40001</a>
    /// </summary>
    let P40001 = _prefixId.prefix "P40001"
    let P40002 = _prefixId.prefix "P40002"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing additional information about carrier characteristics that are specific to the item being described and are assumed not to apply to other items exemplifying the same manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.22^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on item-specific carrier characteristic</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnItemSpecificCarrierCharacteristic</para>
    ///   <para>rdfs:label : has note on item-specific carrier characteristic</para>
    ///   <para>skos:definition : Relates an item to a note providing additional information about carrier characteristics that are specific to the item being described and are assumed not to apply to other items exemplifying the same manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40003">rdai:P40003</a>
    /// </summary>
    let P40003 = _prefixId.prefix "P40003"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a curator who brings together items from various sources that are then arranged, described, and cataloged as a collection.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : collector</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collector</para>
    ///   <para>rdfs:label : has collector</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A curator who brings together items from various sources that are then arranged, described, and cataloged as a collection.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40004">rdai:P40004</a>
    /// </summary>
    let P40004 = _prefixId.prefix "P40004"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a curator who lists or inventories the items in an aggregate work such as a collection of items or works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A curator who lists or inventories the items in an aggregate work such as a collection of items or works.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : collectionRegistrar</para>
    ///   <para>rdfs:label : has collection registrar</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : collection registrar</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40005">rdai:P40005</a>
    /// </summary>
    let P40005 = _prefixId.prefix "P40005"
    /// <summary>
    ///   <para>rdfs:label : has depositor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A current owner of an item who deposited the item into the custody of another person, family, or corporate body, while still retaining ownership.</para>
    ///   <para>skos:definition : Relates an item to a current owner of an item who deposited the item into the custody of another person, family, or corporate body, while still retaining ownership.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : depositor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : depositor</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40006">rdai:P40006</a>
    /// </summary>
    let P40006 = _prefixId.prefix "P40006"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : donor</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : donor</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A former owner of an item who donated that item to another owner.</para>
    ///   <para>rdfs:label : has donor</para>
    ///   <para>skos:definition : Relates an item to a former owner of an item who donated that item to another owner.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40007">rdai:P40007</a>
    /// </summary>
    let P40007 = _prefixId.prefix "P40007"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a former owner of an item who sold that item to another owner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : seller</para>
    ///   <para>rdfs:label : has seller</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A former owner of an item who sold that item to another owner.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : seller</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40008">rdai:P40008</a>
    /// </summary>
    let P40008 = _prefixId.prefix "P40008"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containedInItem</para>
    ///   <para>rdfs:label : is contained in (item)</para>
    ///   <para>skos:definition : Relates an item to a larger item of which the item is a discrete component.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : contained in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A larger item of which the item is a discrete component.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40009">rdai:P40009</a>
    /// </summary>
    let P40009 = _prefixId.prefix "P40009"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnDimensionsOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the dimensions of the specific item being described that is not recorded as part of the dimensions element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.22.3^^xsd:string</para>
    ///   <para>rdfs:label : has note on dimensions of item</para>
    ///   <para>skos:definition : Relates an item to a note providing information on the dimensions of the specific item being described that is not recorded as part of the dimensions element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on dimensions of item</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40010">rdai:P40010</a>
    /// </summary>
    let P40010 = _prefixId.prefix "P40010"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on the extent of the specific item being described that is not recorded as part of the extent element.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnExtentOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 3.22.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on extent of item</para>
    ///   <para>skos:definition : Relates an item to a note providing information on the extent of the specific item being described that is not recorded as part of the extent element.</para>
    ///   <para>rdfs:label : has note on extent of item</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40011">rdai:P40011</a>
    /// </summary>
    let P40011 = _prefixId.prefix "P40011"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a person providing decoration to a specific item using precious metals or color, often with elaborate designs and motifs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : illuminator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person providing decoration to a specific item using precious metals or color, often with elaborate designs and motifs.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : illuminator</para>
    ///   <para>rdfs:label : has illuminator</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40012">rdai:P40012</a>
    /// </summary>
    let P40012 = _prefixId.prefix "P40012"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : binder</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who binds an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : binder</para>
    ///   <para>rdfs:label : has binder</para>
    ///   <para>skos:definition : Relates an item to a person who binds an item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40013">rdai:P40013</a>
    /// </summary>
    let P40013 = _prefixId.prefix "P40013"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a person who has written a statement of dedication or gift on an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : inscriber</para>
    ///   <para>rdfs:label : has inscriber</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who has written a statement of dedication or gift on an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : inscriber</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40014">rdai:P40014</a>
    /// </summary>
    let P40014 = _prefixId.prefix "P40014"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a person who makes manuscript annotations on an item.</para>
    ///   <para>rdfs:label : has annotator</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person who makes manuscript annotations on an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : annotator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : annotator</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40015">rdai:P40015</a>
    /// </summary>
    let P40015 = _prefixId.prefix "P40015"
    /// <summary>
    ///   <para>rdfs:label : has autographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : autographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : autographer</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person whose manuscript signature appears on an item.</para>
    ///   <para>skos:definition : Relates an item to a person whose manuscript signature appears on an item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40016">rdai:P40016</a>
    /// </summary>
    let P40016 = _prefixId.prefix "P40016"
    /// <summary>
    ///   <para>rdfs:label : has curator</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body conceiving, aggregating, and/or organizing an exhibition, collection, or other item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body conceiving, aggregating, and/or organizing an exhibition, collection, or other item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : curator</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : curator</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40017">rdai:P40017</a>
    /// </summary>
    let P40017 = _prefixId.prefix "P40017"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : current owner</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : currentOwner</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body currently having legal possession of an item.</para>
    ///   <para>rdfs:label : has current owner</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body currently having legal possession of an item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40018">rdai:P40018</a>
    /// </summary>
    let P40018 = _prefixId.prefix "P40018"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body formerly having legal possession of an item.</para>
    ///   <para>rdfs:label : has former owner</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body formerly having legal possession of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : formerOwner</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : former owner</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40019">rdai:P40019</a>
    /// </summary>
    let P40019 = _prefixId.prefix "P40019"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body having legal custody of an item.</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body having legal custody of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 22.3^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : custodian</para>
    ///   <para>rdfs:label : has custodian</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodian</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40020">rdai:P40020</a>
    /// </summary>
    let P40020 = _prefixId.prefix "P40020"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body having legal possession of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : owner</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 22.2^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body having legal possession of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : owner</para>
    ///   <para>rdfs:label : has owner</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40021">rdai:P40021</a>
    /// </summary>
    let P40021 = _prefixId.prefix "P40021"
    /// <summary>
    ///   <para>rdfs:label : has honouree (item)</para>
    ///   <para>skos:altLabel : has honoree (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body honoured by an item, e.g., a person to whom a copy is presented.</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body honoured by an item, e.g., a person to whom a copy is presented.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : honoureeOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : honouree (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40022">rdai:P40022</a>
    /// </summary>
    let P40022 = _prefixId.prefix "P40022"
    /// <summary>
    ///   <para>rdfs:label : has other person, family, or corporate body associated with an item</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body other than an owner or custodian associated with an item.</para>
    ///   <para>skos:scopeNote : Includes curators, binders, restorationists, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : other person, family, or corporate body associated with an item</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body other than an owner or custodian associated with an item. Includes curators, binders, restorationists, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 22.4^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : otherPFCItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40023">rdai:P40023</a>
    /// </summary>
    let P40023 = _prefixId.prefix "P40023"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : restorationist</para>
    ///   <para>rdfs:label : has restorationist</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restorationist</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body responsible for the set of technical, editorial, and intellectual procedures aimed at compensating for the degradation of an item by bringing it back to a state as close as possible to its original condition.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40024">rdai:P40024</a>
    /// </summary>
    let P40024 = _prefixId.prefix "P40024"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : dedicatee (item)</para>
    ///   <para>rdfs:label : has dedicatee (item)</para>
    ///   <para>skos:definition : Relates an item to a person, family, or corporate body to whom an item is dedicated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A person, family, or corporate body to whom an item is dedicated.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : dedicateeOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40025">rdai:P40025</a>
    /// </summary>
    let P40025 = _prefixId.prefix "P40025"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a record of previous ownership or custodianship of an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.18^^xsd:string</para>
    ///   <para>rdfs:label : has custodial history of item</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : custodial history of item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : custodialHistoryOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A record of previous ownership or custodianship of an item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40026">rdai:P40026</a>
    /// </summary>
    let P40026 = _prefixId.prefix "P40026"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item in an analog format that is transferred to a digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item in an analog format that is transferred to a digital format.</para>
    ///   <para>rdfs:label : is electronic reproduction of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : electronic reproduction of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40027">rdai:P40027</a>
    /// </summary>
    let P40027 = _prefixId.prefix "P40027"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : note on item</para>
    ///   <para>rdfs:label : has note on item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : noteOnItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.21^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A note providing information on attributes of the item.</para>
    ///   <para>skos:definition : Relates an item to a note providing information on attributes of the item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40028">rdai:P40028</a>
    /// </summary>
    let P40028 = _prefixId.prefix "P40028"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item brought together with another item after being issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompaniedByItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item brought together with another item after being issued.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : accompanied by (item)</para>
    ///   <para>rdfs:label : is accompanied by (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40029">rdai:P40029</a>
    /// </summary>
    let P40029 = _prefixId.prefix "P40029"
    let P40030 = _prefixId.prefix "P40030"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that exemplifies a manifestation that embodies the same expression of a work.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equivalent (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalentItem</para>
    ///   <para>skos:definition : Relates an item to an item that exemplifies a manifestation that embodies the same expression of a work.</para>
    ///   <para>rdfs:label : is equivalent (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40031">rdai:P40031</a>
    /// </summary>
    let P40031 = _prefixId.prefix "P40031"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : boundWith</para>
    ///   <para>skos:definition : Relates an item to an item that has been bound within the same binding as the item being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that has been bound within the same binding as the item being described.</para>
    ///   <para>rdfs:label : is bound with</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : bound with</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40032">rdai:P40032</a>
    /// </summary>
    let P40032 = _prefixId.prefix "P40032"
    let P40033 = _prefixId.prefix "P40033"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that is a discrete component of a larger item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is a discrete component of a larger item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : container of (item)</para>
    ///   <para>rdfs:label : is container of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : containerOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40034">rdai:P40034</a>
    /// </summary>
    let P40034 = _prefixId.prefix "P40034"
    /// <summary>
    ///   <para>rdfs:label : is on disc with (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : onDiscWithItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is contained on the same disc with the item being described.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : on disc with (item)</para>
    ///   <para>skos:definition : Relates an item to an item that is contained on the same disc with the item being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40035">rdai:P40035</a>
    /// </summary>
    let P40035 = _prefixId.prefix "P40035"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : filmedWithItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : filmed with (item)</para>
    ///   <para>rdfs:label : is filmed with (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is contained on the same microform with the item being described.</para>
    ///   <para>skos:definition : Relates an item to an item that is contained on the same microform with the item being described.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40036">rdai:P40036</a>
    /// </summary>
    let P40036 = _prefixId.prefix "P40036"
    let P40037 = _prefixId.prefix "P40037"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that exemplifies a printed manifestation that is used as the basis for a reissue of a manifestation.</para>
    ///   <para>rdfs:label : is reprint of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reprint of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that exemplifies a printed manifestation that is used as the basis for a reissue of a manifestation.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40038">rdai:P40038</a>
    /// </summary>
    let P40038 = _prefixId.prefix "P40038"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item in a digital format that is transferred to another digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferOfItem</para>
    ///   <para>skos:definition : Relates an item to an item in a digital format that is transferred to another digital format.</para>
    ///   <para>rdfs:label : is digital transfer of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital transfer of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40039">rdai:P40039</a>
    /// </summary>
    let P40039 = _prefixId.prefix "P40039"
    let P40040 = _prefixId.prefix "P40040"
    let P40041 = _prefixId.prefix "P40041"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that is used as the basis for a reproduction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is used as the basis for a reproduction.</para>
    ///   <para>rdfs:label : is reproduction of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reproduction of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproductionOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40042">rdai:P40042</a>
    /// </summary>
    let P40042 = _prefixId.prefix "P40042"
    let P40043 = _prefixId.prefix "P40043"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preservation facsimile of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>skos:definition : Relates an item to an item that is used as the basis for an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileOfItem</para>
    ///   <para>rdfs:label : is preservation facsimile of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40044">rdai:P40044</a>
    /// </summary>
    let P40044 = _prefixId.prefix "P40044"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is used as the basis for an exact reproduction.</para>
    ///   <para>rdfs:label : is facsimile of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileOfItem</para>
    ///   <para>skos:definition : Relates an item to an item that is used as the basis for an exact reproduction.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile of (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40045">rdai:P40045</a>
    /// </summary>
    let P40045 = _prefixId.prefix "P40045"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item, represented by an identifier or a description, that is related to the item being described (e.g., an item used as the basis for a microform reproduction).</para>
    ///   <para>rdfs:label : has related item of item</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : relatedItemOfItem</para>
    ///   <para>skos:definition : Relates an item to an item, represented by an identifier or a description, that is related to the item being described (e.g., an item used as the basis for a microform reproduction).</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 28.1^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : related item</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40046">rdai:P40046</a>
    /// </summary>
    let P40046 = _prefixId.prefix "P40046"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Limitations placed on access to a resource.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnAccessToItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : restrictions on access</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.4^^xsd:string</para>
    ///   <para>rdfs:label : has restrictions on access to item</para>
    ///   <para>skos:definition : Relates an item to limitations placed on access to an item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40047">rdai:P40047</a>
    /// </summary>
    let P40047 = _prefixId.prefix "P40047"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : restrictions on use</para>
    ///   <para>rdfs:label : has restrictions on use of item</para>
    ///   <para>skos:definition : Relates an item to limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : Limitations placed on uses such as reproduction, publication, exhibition, etc.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : restrictionsOnUseOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 4.5^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40048">rdai:P40048</a>
    /// </summary>
    let P40048 = _prefixId.prefix "P40048"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The manifestation exemplified by an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : manifestation exemplified</para>
    ///   <para>skos:definition : Relates an item to the manifestation exemplified by an item.</para>
    ///   <para>rdfs:label : has manifestation exemplified</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : manifestationExemplified</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 17.12^^xsd:string</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40049">rdai:P40049</a>
    /// </summary>
    let P40049 = _prefixId.prefix "P40049"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : The source from which the agency directly acquired an item and the circumstances under which it was received.</para>
    ///   <para>skos:definition : Relates an item to the source from which the agency directly acquired an item and the circumstances under which it was received.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/instructionNumber : 2.19^^xsd:string</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : immediateSourceOfAcquisitionOfItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : immediate source of acquisition of item</para>
    ///   <para>rdfs:label : has immediate source of acquisition of item</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40050">rdai:P40050</a>
    /// </summary>
    let P40050 = _prefixId.prefix "P40050"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that accompanies or is accompanied by the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : accompanying item relationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : accompanyingItemRelationship</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that accompanies or is accompanied by the item.</para>
    ///   <para>rdfs:label : has accompanying item relationship with</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40051">rdai:P40051</a>
    /// </summary>
    let P40051 = _prefixId.prefix "P40051"
    let P40052 = _prefixId.prefix "P40052"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : equivalentItemRelationship</para>
    ///   <para>skos:definition : Relates an item to an item that is equivalent to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is equivalent to the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : equivalent item relationship</para>
    ///   <para>rdfs:label : has equivalent item relationship with</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40053">rdai:P40053</a>
    /// </summary>
    let P40053 = _prefixId.prefix "P40053"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is contained in or contains the item.</para>
    ///   <para>rdfs:label : has whole-part item relationship with</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : wholePartItemRelationship</para>
    ///   <para>skos:definition : Relates an item to an item that is contained in or contains the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : whole-part item relationship</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40054">rdai:P40054</a>
    /// </summary>
    let P40054 = _prefixId.prefix "P40054"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that reproduces another item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reproducedAsItem</para>
    ///   <para>rdfs:label : is reproduced as (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reproduced as (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that reproduces another item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40055">rdai:P40055</a>
    /// </summary>
    let P40055 = _prefixId.prefix "P40055"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : digitalTransferItem</para>
    ///   <para>skos:definition : Relates an item to an item in a digital format that results from the transfer of an item in another digital format.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : digital transfer (item)</para>
    ///   <para>rdfs:label : is digital transfer (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item in a digital format that results from the transfer of an item in another digital format.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40056">rdai:P40056</a>
    /// </summary>
    let P40056 = _prefixId.prefix "P40056"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : electronicReproductionItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : electronic reproduction (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item in a digital format that is the result of the transfer of an item in analog format.</para>
    ///   <para>skos:definition : Relates an item to an item in a digital format that is the result of the transfer of an item in analog format.</para>
    ///   <para>rdfs:label : is electronic reproduction (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40057">rdai:P40057</a>
    /// </summary>
    let P40057 = _prefixId.prefix "P40057"
    /// <summary>
    ///   <para>skos:definition : Relates an item to an item that exactly reproduces an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : facsimile (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that exactly reproduces an item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : facsimileItem</para>
    ///   <para>rdfs:label : is facsimile (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40058">rdai:P40058</a>
    /// </summary>
    let P40058 = _prefixId.prefix "P40058"
    /// <summary>
    ///   <para>rdfs:label : is preservation facsimile (item)</para>
    ///   <para>skos:definition : Relates an item to an item that consists of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that consists of an exact reproduction on preservation-quality media, such as acid-free permanent or archival paper.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : preservation facsimile (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : preservationFacsimileItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40059">rdai:P40059</a>
    /// </summary>
    let P40059 = _prefixId.prefix "P40059"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reprintedAsItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reprinted as (item)</para>
    ///   <para>skos:definition : Relates an item to an item that is a reissue of an item that exemplifies another printed manifestation.</para>
    ///   <para>rdfs:label : is reprinted as (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : An item that is a reissue of an item that exemplifies another printed manifestation.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40060">rdai:P40060</a>
    /// </summary>
    let P40060 = _prefixId.prefix "P40060"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a work that is about the item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : subject of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that is about the item.</para>
    ///   <para>rdfs:label : is subject of (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : subjectOfItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40061">rdai:P40061</a>
    /// </summary>
    let P40061 = _prefixId.prefix "P40061"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : describedInItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that describes a described item.</para>
    ///   <para>rdfs:label : is described in (item)</para>
    ///   <para>skos:definition : Relates an item to a work that describes a described item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : described in (item)</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40062">rdai:P40062</a>
    /// </summary>
    let P40062 = _prefixId.prefix "P40062"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines the source item to identify its components and their relations.</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : analysedInItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : analysed in (item)</para>
    ///   <para>rdfs:label : is analysed in (item)</para>
    ///   <para>skos:definition : Relates an item to a work that examines the source item to identify its components and their relations.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40063">rdai:P40063</a>
    /// </summary>
    let P40063 = _prefixId.prefix "P40063"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : commentary in (item)</para>
    ///   <para>rdfs:label : is commentary in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : commentaryInItem</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a set of explanatory or critical notes on the described item.</para>
    ///   <para>skos:definition : Relates an item to a work that contains a set of explanatory or critical notes on the described item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40064">rdai:P40064</a>
    /// </summary>
    let P40064 = _prefixId.prefix "P40064"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a critical evaluation of the described item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : critiqued in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : critiquedInItem</para>
    ///   <para>rdfs:label : is critiqued in (item)</para>
    ///   <para>skos:definition : Relates an item to a work that contains a critical evaluation of the described item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40065">rdai:P40065</a>
    /// </summary>
    let P40065 = _prefixId.prefix "P40065"
    /// <summary>
    ///   <para>skos:definition : Relates an item to a work that examines or judges the described item.</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : evaluated in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that examines or judges the described item.</para>
    ///   <para>rdfs:label : is evaluated in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : evaluatedInItem</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40066">rdai:P40066</a>
    /// </summary>
    let P40066 = _prefixId.prefix "P40066"
    /// <summary>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitDefinition : A work that contains a brief evaluation of the described item.</para>
    ///   <para>rdfs:label : is reviewed in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/rdakit/toolkitLabel : reviewed in (item)</para>
    ///   <para>http://metadataregistry.org/uri/profile/RegAp/name : reviewedInItem</para>
    ///   <para>skos:definition : Relates an item to a work that contains a brief evaluation of the described item.</para>
    ///   <a href="http://rdaregistry.info/Elements/i/P40067">rdai:P40067</a>
    /// </summary>
    let P40067 = _prefixId.prefix "P40067"
    let ``accompaniedByItem.en`` = _prefixId.prefix "accompaniedByItem.en"

    let ``accompanyingItemRelationship.en`` =
        _prefixId.prefix "accompanyingItemRelationship.en"

    let ``analysedInItem.en`` = _prefixId.prefix "analysedInItem.en"
    let ``annotator.en`` = _prefixId.prefix "annotator.en"
    let ``autographer.en`` = _prefixId.prefix "autographer.en"
    let ``binder.en`` = _prefixId.prefix "binder.en"
    let ``boundWith.en`` = _prefixId.prefix "boundWith.en"
    let ``collectionRegistrar.en`` = _prefixId.prefix "collectionRegistrar.en"
    let ``collector.en`` = _prefixId.prefix "collector.en"
    let ``commentaryInItem.en`` = _prefixId.prefix "commentaryInItem.en"
    let ``containedInItem.en`` = _prefixId.prefix "containedInItem.en"
    let ``containerOfItem.en`` = _prefixId.prefix "containerOfItem.en"
    let ``critiquedInItem.en`` = _prefixId.prefix "critiquedInItem.en"
    let ``curator.en`` = _prefixId.prefix "curator.en"
    let ``currentOwner.en`` = _prefixId.prefix "currentOwner.en"
    let ``custodialHistoryOfItem.en`` = _prefixId.prefix "custodialHistoryOfItem.en"
    let ``custodian.en`` = _prefixId.prefix "custodian.en"
    let ``dedicateeOfItem.en`` = _prefixId.prefix "dedicateeOfItem.en"
    let ``depositor.en`` = _prefixId.prefix "depositor.en"
    let ``describedInItem.en`` = _prefixId.prefix "describedInItem.en"
    let ``digitalTransferItem.en`` = _prefixId.prefix "digitalTransferItem.en"
    let ``digitalTransferOfItem.en`` = _prefixId.prefix "digitalTransferOfItem.en"
    let ``donor.en`` = _prefixId.prefix "donor.en"

    let ``electronicReproductionItem.en`` =
        _prefixId.prefix "electronicReproductionItem.en"

    let ``electronicReproductionOfItem.en`` =
        _prefixId.prefix "electronicReproductionOfItem.en"

    let ``equivalentItem.en`` = _prefixId.prefix "equivalentItem.en"

    let ``equivalentItemRelationship.en`` =
        _prefixId.prefix "equivalentItemRelationship.en"

    let ``evaluatedInItem.en`` = _prefixId.prefix "evaluatedInItem.en"
    let ``facsimileItem.en`` = _prefixId.prefix "facsimileItem.en"
    let ``facsimileOfItem.en`` = _prefixId.prefix "facsimileOfItem.en"
    let ``filmedWithItem.en`` = _prefixId.prefix "filmedWithItem.en"
    let ``formerOwner.en`` = _prefixId.prefix "formerOwner.en"
    let ``honoureeOfItem.en`` = _prefixId.prefix "honoureeOfItem.en"
    let ``identifierForTheItem.en`` = _prefixId.prefix "identifierForTheItem.en"
    let ``illuminator.en`` = _prefixId.prefix "illuminator.en"

    let ``immediateSourceOfAcquisitionOfItem.en`` =
        _prefixId.prefix "immediateSourceOfAcquisitionOfItem.en"

    let ``inscriber.en`` = _prefixId.prefix "inscriber.en"
    let ``manifestationExemplified.en`` = _prefixId.prefix "manifestationExemplified.en"
    let ``noteOnDimensionsOfItem.en`` = _prefixId.prefix "noteOnDimensionsOfItem.en"
    let ``noteOnExtentOfItem.en`` = _prefixId.prefix "noteOnExtentOfItem.en"
    let ``noteOnItem.en`` = _prefixId.prefix "noteOnItem.en"

    let ``noteOnItemSpecificCarrierCharacteristic.en`` =
        _prefixId.prefix "noteOnItemSpecificCarrierCharacteristic.en"

    let ``onDiscWithItem.en`` = _prefixId.prefix "onDiscWithItem.en"
    let ``otherPFCItem.en`` = _prefixId.prefix "otherPFCItem.en"
    let ``owner.en`` = _prefixId.prefix "owner.en"

    let ``preservationFacsimileItem.en`` =
        _prefixId.prefix "preservationFacsimileItem.en"

    let ``preservationFacsimileOfItem.en`` =
        _prefixId.prefix "preservationFacsimileOfItem.en"

    let ``relatedItemOfItem.en`` = _prefixId.prefix "relatedItemOfItem.en"
    let ``reprintOfItem.en`` = _prefixId.prefix "reprintOfItem.en"
    let ``reprintedAsItem.en`` = _prefixId.prefix "reprintedAsItem.en"
    let ``reproducedAsItem.en`` = _prefixId.prefix "reproducedAsItem.en"
    let ``reproductionOfItem.en`` = _prefixId.prefix "reproductionOfItem.en"
    let ``restorationist.en`` = _prefixId.prefix "restorationist.en"

    let ``restrictionsOnAccessToItem.en`` =
        _prefixId.prefix "restrictionsOnAccessToItem.en"

    let ``restrictionsOnUseOfItem.en`` = _prefixId.prefix "restrictionsOnUseOfItem.en"
    let ``reviewedInItem.en`` = _prefixId.prefix "reviewedInItem.en"
    let ``seller.en`` = _prefixId.prefix "seller.en"
    let ``subjectOfItem.en`` = _prefixId.prefix "subjectOfItem.en"

    let ``wholePartItemRelationship.en`` =
        _prefixId.prefix "wholePartItemRelationship.en"
