#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nen3610 =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://modellen.geostandaarden.nl/def/nen3610#" "nen3610"

    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Begroeiing^^xsd:string</para>
    ///   <para>skos:notation : Begroeiing^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Planten die op natuurlijke wijze zijn ontstaan of door mensen zijn aangeplant.^^xsd:string</para>
    ///   <para>rdfs:label : Begroeiing^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Begroeiing kan dus spontaan of natuurlijk zijn (vegetatie), maar ook door menselijk toedoen tot stand zijn gekomen (aanplant of beplanting) of combinaties daarvan.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Begroeiing">nen3610:Begroeiing</a>
    /// </summary>
    let Begroeiing = _prefixId.prefix "Begroeiing"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Bovenste deel van de aarde, exclusief oppervlaktewater.^^xsd:string</para>
    ///   <para>rdfs:label : Bodem^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : Bodem^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Bodem verwijst naar een typering en/of benoeming van het aardoppervlak, waarbij de bodem doorloopt onder het oppervlaktewater.  Bodem omvat ook de daaronder liggende bodemmaterialen met indelingen die kunnen verschillen per vakgebied zoals bijvoorbeeld bodemkunde, geologie, geohydrologie en geomorfologie.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Bodem^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Bodem">nen3610:Bodem</a>
    /// </summary>
    let Bodem = _prefixId.prefix "Bodem"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Constructie kan boven- en ondergrondse objecten betreffen. Voorbeelden zijn: huis, brug, asfalt, waterleiding, fabriek, mijnstelsel.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Gebouwd object dat direct of indirect met de bodem is verbonden en bedoeld is om ter plaatse te functioneren.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>skos:notation : Constructie^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Constructie^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Constructie">nen3610:Constructie</a>
    /// </summary>
    let Constructie = _prefixId.prefix "Constructie"
    /// <summary>
    ///   <para>skos:notation : FunctioneleRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Een functionele ruimte wordt gebruikt om een (gebruiks)functie aan een ruimte toe te kennen. Het functionele gebruik van de ruimte volgt niet altijd de fysieke begrenzing van re�le objecten.^^xsd:string</para>
    ///   <para>rdfs:comment : Ruimte met een specifieke functie.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Functionele ruimte^^xsd:string</para>
    ///   <para>rdfs:label : FunctioneleRuimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#FunctioneleRuimte">nen3610:FunctioneleRuimte</a>
    /// </summary>
    let FunctioneleRuimte = _prefixId.prefix "FunctioneleRuimte"
    /// <summary>
    ///   <para>skos:notation : Gebouw^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Gebouw^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Voorbeelden zijn: huis, schuur, flatgebouw, huizenblok, fabriek.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Overdekte en geheel of gedeeltelijk met wanden omsloten constructie bedoeld voor het in een afgeschermde omgeving onderbrengen van mensen, dieren of voorwerpen of voor de productie van goederen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:label : Gebouw^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Gebouw">nen3610:Gebouw</a>
    /// </summary>
    let Gebouw = _prefixId.prefix "Gebouw"
    /// <summary>
    ///   <para>rdfs:label : GeoObject^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>skos:notation : GeoObject^^xsd:string</para>
    ///   <para>rdfs:comment : Een fenomeen in de werkelijkheid dat direct of indirect is geassocieerd met een locatie relatief ten opzichte van de aarde.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Van dit objecttype worden geen directe instanties gemaakt. Indien een object een geo-object is, is het altijd een instantie van een subklasse van GeoObject. Alle subklassen van GeoObject hebben conform MIM het stereotype �Objecttype�. Voor publicatie conform NEN-EN-ISO 19109:2015 is het stereotype �FeatureType� verplicht. Binnen de context van NEN 3610 is �Objecttype� het equivalent van �FeatureType�.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Geo-object^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#GeoObject">nen3610:GeoObject</a>
    /// </summary>
    let GeoObject = _prefixId.prefix "GeoObject"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#alias : Geografische ruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : De grenzen zijn niet altijd exact vastgesteld. Voorbeelden zijn: Noordoostpolder, Midden-Nederland, rivierengebied, Veluwe, Zuid-Limburg, kustgebied. ^^xsd:string</para>
    ///   <para>rdfs:comment : Ruimte die bekendstaat onder een vanuit de historie of het gebruik bekende benaming of een fysisch-geografische samenhang, al dan niet met zijn omgeving, kent.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:label : GeografischeRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>skos:notation : GeografischeRuimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#GeografischeRuimte">nen3610:GeografischeRuimte</a>
    /// </summary>
    let GeografischeRuimte = _prefixId.prefix "GeografischeRuimte"
    /// <summary>
    ///   <para>rdfs:comment : Klasse opgenomen om identificatie-attributen in te defini�ren.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : IdentificeerbaarObject^^xsd:string</para>
    ///   <para>rdfs:label : IdentificeerbaarObject^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20221216^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : De klasse wordt als superklasse gebruikt voor alle objecttypen waarvan de instanties identificeerbaar moeten zijn.^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#IdentificeerbaarObject">nen3610:IdentificeerbaarObject</a>
    /// </summary>
    let IdentificeerbaarObject = _prefixId.prefix "IdentificeerbaarObject"
    /// <summary>
    ///   <para>skos:notation : JuridischeRuimte^^xsd:string</para>
    ///   <para>rdfs:comment : Ruimte waar een juridisch instrument beleid of regelgeving toepast.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:label : JuridischeRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Juridische ruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Juridische ruimte omvat objecten die zijn gekoppeld aan wet- en beleidsinformatie die aangeeft wat waar krachtens wetgeving of wettelijk beleid is geformuleerd. Voorbeelden zijn: benoeming van ruimten en gebieden in bijvoorbeeld omgevingsvisie, omgevingsverordening, waterschapsverordening, projectbesluit.^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#JuridischeRuimte">nen3610:JuridischeRuimte</a>
    /// </summary>
    let JuridischeRuimte = _prefixId.prefix "JuridischeRuimte"
    /// <summary>
    ///   <para>rdfs:label : Kunstwerk^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Kunstwerk^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : Kunstwerk^^xsd:string</para>
    ///   <para>rdfs:comment : Civiel-technische constructie voor de infrastructuur van wegen, water, spoorbanen, waterkeringen en/of leidingen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Hieronder vallen overbruggingen, waterstaatkundige werken en waterkerende constructies. Overbruggingen kunnen zijn: brug, viaduct, aquaduct enz. Een voorbeeld van een waterstaatkundig werk is een sluis. Voorbeelden van waterkerende constructies zijn stuw en vaste dam.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Kunstwerk">nen3610:Kunstwerk</a>
    /// </summary>
    let Kunstwerk = _prefixId.prefix "Kunstwerk"
    /// <summary>
    ///   <para>skos:notation : Leiding^^xsd:string</para>
    ///   <para>rdfs:comment : Een geheel van geleiders of een ruimte die voorzien is van ��n ommanteling en bestemd is voor transport van materie, data en/of energie.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Leiding^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Leiding^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Voorbeelden zijn: hoogspanningsleiding, riool, waterleiding, glasvezelkabel, gasleiding.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Leiding">nen3610:Leiding</a>
    /// </summary>
    let Leiding = _prefixId.prefix "Leiding"
    /// <summary>
    ///   <para>rdfs:comment : Verkeerruimte voor voertuigen die zich door de lucht verplaatsen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : Luchtvaartruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Luchtvaartruimte wordt bijvoorbeeld gebruikt door allerlei soorten vliegtuigen en helikopters.^^xsd:string</para>
    ///   <para>rdfs:label : Luchtvaartruimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Luchtvaartruimte">nen3610:Luchtvaartruimte</a>
    /// </summary>
    let Luchtvaartruimte = _prefixId.prefix "Luchtvaartruimte"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#alias : Oppervlaktewater^^xsd:string</para>
    ///   <para>rdfs:label : Oppervlaktewater^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Grondwater maakt geen deel uit van de superklasse.^^xsd:string</para>
    ///   <para>rdfs:comment : Massa van water dat de bodem bedekt of in normale omstandigheden kan bedekken.^^xsd:string</para>
    ///   <para>skos:notation : Oppervlaktewater^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Oppervlaktewater">nen3610:Oppervlaktewater</a>
    /// </summary>
    let Oppervlaktewater = _prefixId.prefix "Oppervlaktewater"
    /// <summary>
    ///   <para>rdfs:comment : Geo-object dat zich geheel materieel manifesteert.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Een re�el of fysiek object is een tastbaar begrensd object dat gekenmerkt wordt door zijn materiele samenstelling en structuur.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : ReeelObject^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Re�el object^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:label : ReeelObject^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#ReeelObject">nen3610:ReeelObject</a>
    /// </summary>
    let ReeelObject = _prefixId.prefix "ReeelObject"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : false^^xsd:boolean</para>
    ///   <para>rdfs:comment : Vastlegging van een versie van een set gegevens.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Bij het registreren van een object als informatieobject horen een aantal metadata die hier betrekking op hebben, zoals versie en registratie van tijdlijngegevens.^^xsd:string</para>
    ///   <para>skos:notation : Registratie^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:label : Registratie^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Registratie">nen3610:Registratie</a>
    /// </summary>
    let Registratie = _prefixId.prefix "Registratie"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Registratieve ruimte omvat objecten die onder de wet- of regelgeving vallen of die voor bedrijfsvoering administratief van belang zijn. In veel gevallen zal een dergelijk gebied ook een registratieve aanduiding of registratief nummer hebben. Voorbeelden zijn: gemeente Delft, postcodegebied 2345, politieregio Haaglanden, veiligheidsregio Gelderland-Midden, Nationaal Park De Hoge Veluwe, kadastraal perceel.^^xsd:string</para>
    ///   <para>rdfs:label : RegistratieveRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:comment : Op basis van wet- of regelgeving afgebakende ruimte die als eenheid geldt van politiek-bestuurlijke verantwoordelijkheid of voor bedrijfsvoering.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>skos:notation : RegistratieveRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Registratieve ruimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#RegistratieveRuimte">nen3610:RegistratieveRuimte</a>
    /// </summary>
    let RegistratieveRuimte = _prefixId.prefix "RegistratieveRuimte"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>skos:notation : Scheepvaartruimte^^xsd:string</para>
    ///   <para>rdfs:comment : Verkeerruimte voor voertuigen die zich over water verplaatsen.^^xsd:string</para>
    ///   <para>rdfs:label : Scheepvaartruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Scheepvaartruimte wordt gebruikt door allerlei soorten schepen.^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Scheepvaartruimte">nen3610:Scheepvaartruimte</a>
    /// </summary>
    let Scheepvaartruimte = _prefixId.prefix "Scheepvaartruimte"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Spoorverkeerruimte wordt gebruikt door bijvoorbeeld treinen, trams en metro's.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Spoorverkeerruimte^^xsd:string</para>
    ///   <para>rdfs:label : Spoorverkeerruimte^^xsd:string</para>
    ///   <para>skos:notation : Spoorverkeerruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Verkeerruimte voor voertuigen die zich over rails verplaatsen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Spoorverkeerruimte">nen3610:Spoorverkeerruimte</a>
    /// </summary>
    let Spoorverkeerruimte = _prefixId.prefix "Spoorverkeerruimte"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>skos:notation : Transportruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Transportlijnen worden onder andere gerealiseerd door wegen, spoorwegen, waterwegen, luchtverbindingen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:label : Transportruimte^^xsd:string</para>
    ///   <para>rdfs:comment : Natuurlijke of aangelegde transportlijnen of verbindingen met knooppunten waarlangs stromen zich kunnen verplaatsen.^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Transportruimte">nen3610:Transportruimte</a>
    /// </summary>
    let Transportruimte = _prefixId.prefix "Transportruimte"
    /// <summary>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Een verharding is fysiek begrensd aanwezig. Het type gebruik van de verharding kan meervoudig zijn en hoeft niet de fysieke begrenzing te volgen.^^xsd:string</para>
    ///   <para>skos:notation : Verharding^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>rdfs:comment : Een door egaliseren, verstevigen en/of verruwen voor het beoogde gebruik geschikt gemaakt oppervlak, bestaande uit in een of meer lagen over een bodem of onderliggende constructie aangelegd materiaal.^^xsd:string</para>
    ///   <para>rdfs:label : Verharding^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Verharding^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Verharding">nen3610:Verharding</a>
    /// </summary>
    let Verharding = _prefixId.prefix "Verharding"
    /// <summary>
    ///   <para>rdfs:label : Verkeerruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Transportruimte voor verkeer via land, water of lucht.^^xsd:string</para>
    ///   <para>skos:notation : Verkeerruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Verkeerruimten zijn transportruimten die specifiek bedoeld zijn voor het verplaatsen van mensen of goederen al dan niet met vervoersmiddelen, zoals bijvoorbeeld treinen, schepen en vliegtuigen.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Verkeerruimte">nen3610:Verkeerruimte</a>
    /// </summary>
    let Verkeerruimte = _prefixId.prefix "Verkeerruimte"
    /// <summary>
    ///   <para>rdfs:comment : Geo-object dat zich geheel of gedeeltelijk niet-materieel manifesteert en dus slechts in abstracte en/of geregistreerde vorm bestaat.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:label : VirtueleRuimte^^xsd:string</para>
    ///   <para>skos:notation : VirtueleRuimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Virtuele ruimten bevatten geo-objecten waarvan de begrenzing of een gedeelte van de begrenzing niet tastbaar en dus ook niet zichtbaar aanwezig is. Het betreft veelal het administratief of wettelijk benoemen en vastleggen van ruimten. Voorbeelden zijn objecten voor bestuurlijke grenzen, eigendomsbegrenzing, beheerbegrenzingen, ruimtelijk beleid.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#alias : Virtuele ruimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#VirtueleRuimte">nen3610:VirtueleRuimte</a>
    /// </summary>
    let VirtueleRuimte = _prefixId.prefix "VirtueleRuimte"
    /// <summary>
    ///   <para>rdfs:comment : Reden waarom een 'nil'-waarde is ingevuld.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>rdfs:label : VoidReasonValue^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Deze codelijst moet extern worden gepubliceerd.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : false^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>skos:notation : VoidReasonValue^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#VoidReasonValue">nen3610:VoidReasonValue</a>
    /// </summary>
    let VoidReasonValue = _prefixId.prefix "VoidReasonValue"
    /// <summary>
    ///   <para>skos:notation : Waterverplaatsingsruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Waterverplaatsingsruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Een waterverplaatsingsruimte realiseert het hydrologisch aspect van water en met name de oppervlaktewaterhydrologie. Het benoemt de ruimte die wordt gebruikt voor o.a. afwatering, watertoevoer en drainage.^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>rdfs:comment : Transportruimte waardoor water zich verplaatst.^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Waterverplaatsingsruimte">nen3610:Waterverplaatsingsruimte</a>
    /// </summary>
    let Waterverplaatsingsruimte = _prefixId.prefix "Waterverplaatsingsruimte"
    /// <summary>
    ///   <para>skos:notation : Wegverkeerruimte^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#datumOpname : 20220601^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#indicatieAbstractObject : true^^xsd:boolean</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomstDefinitie : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#herkomst : nen 3610^^xsd:string</para>
    ///   <para>http://bp4mc2.org/def/mim#toelichting : Wegverkeerruimten worden gebruikt door bijvoorbeeld voetgangers, fietsers en autoverkeer.^^xsd:string</para>
    ///   <para>rdfs:comment : Verkeerruimte voor weggebruikers die zich over wegen verplaatsen.^^xsd:string</para>
    ///   <para>rdfs:label : Wegverkeerruimte^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#Wegverkeerruimte">nen3610:Wegverkeerruimte</a>
    /// </summary>
    let Wegverkeerruimte = _prefixId.prefix "Wegverkeerruimte"
    /// <summary>
    ///   <para>rdfs:label : beginGeldigheid^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#beginGeldigheid">nen3610:beginGeldigheid</a>
    /// </summary>
    let beginGeldigheid = _prefixId.prefix "beginGeldigheid"
    /// <summary>
    ///   <para>rdfs:label : domein^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#domein">nen3610:domein</a>
    /// </summary>
    let domein = _prefixId.prefix "domein"
    /// <summary>
    ///   <para>rdfs:label : eindGeldigheid^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#eindGeldigheid">nen3610:eindGeldigheid</a>
    /// </summary>
    let eindGeldigheid = _prefixId.prefix "eindGeldigheid"
    /// <summary>
    ///   <para>rdfs:label : eindRegistratie^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#eindRegistratie">nen3610:eindRegistratie</a>
    /// </summary>
    let eindRegistratie = _prefixId.prefix "eindRegistratie"
    /// <summary>
    ///   <para>rdfs:label : identificatie^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#identificatie">nen3610:identificatie</a>
    /// </summary>
    let identificatie = _prefixId.prefix "identificatie"
    /// <summary>
    ///   <para>rdfs:label : objectBeginTijd^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#objectBeginTijd">nen3610:objectBeginTijd</a>
    /// </summary>
    let objectBeginTijd = _prefixId.prefix "objectBeginTijd"
    /// <summary>
    ///   <para>rdfs:label : objectEindTijd^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#objectEindTijd">nen3610:objectEindTijd</a>
    /// </summary>
    let objectEindTijd = _prefixId.prefix "objectEindTijd"
    /// <summary>
    ///   <para>rdfs:label : registratiegegevens^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#registratiegegevens">nen3610:registratiegegevens</a>
    /// </summary>
    let registratiegegevens = _prefixId.prefix "registratiegegevens"
    /// <summary>
    ///   <para>rdfs:label : tijdstipRegistratie^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#tijdstipRegistratie">nen3610:tijdstipRegistratie</a>
    /// </summary>
    let tijdstipRegistratie = _prefixId.prefix "tijdstipRegistratie"
    /// <summary>
    ///   <para>rdfs:label : versie^^xsd:string</para>
    ///   <a href="http://modellen.geostandaarden.nl/def/nen3610#versie">nen3610:versie</a>
    /// </summary>
    let versie = _prefixId.prefix "versie"
