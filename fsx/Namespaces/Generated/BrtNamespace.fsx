#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module brt =
    let _prefixId = PrefixId.fromNamespaceLabel "http://brt.basisregistraties.overheid.nl/def/top10nl#" "brt"

    /// <summary>
    ///   <para>rdfs:label : Aanlegsteiger_inrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Aanlegsteiger_inrichtingselement">brt:Aanlegsteiger_inrichtingselement</a>
    /// </summary>
    let Aanlegsteiger_inrichtingselement = _prefixId.prefix "Aanlegsteiger_inrichtingselement"

    /// <summary>
    ///   <para>rdfs:label : Aanlegsteiger_terrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Aanlegsteiger_terrein">brt:Aanlegsteiger_terrein</a>
    /// </summary>
    let Aanlegsteiger_terrein = _prefixId.prefix "Aanlegsteiger_terrein"
    /// <summary>
    ///   <para>rdfs:label : Akkerland^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Akkerland">brt:Akkerland</a>
    /// </summary>
    let Akkerland = _prefixId.prefix "Akkerland"
    /// <summary>
    ///   <para>rdfs:label : Arboretum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Arboretum">brt:Arboretum</a>
    /// </summary>
    let Arboretum = _prefixId.prefix "Arboretum"
    /// <summary>
    ///   <para>rdfs:label : Attractiepark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Attractiepark">brt:Attractiepark</a>
    /// </summary>
    let Attractiepark = _prefixId.prefix "Attractiepark"
    /// <summary>
    ///   <para>rdfs:label : Autosnelweg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Autosnelweg">brt:Autosnelweg</a>
    /// </summary>
    let Autosnelweg = _prefixId.prefix "Autosnelweg"
    /// <summary>
    ///   <para>rdfs:label : Baak^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Baak">brt:Baak</a>
    /// </summary>
    let Baak = _prefixId.prefix "Baak"
    /// <summary>
    ///   <para>rdfs:label : BankOndieptePlaat^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BankOndieptePlaat">brt:BankOndieptePlaat</a>
    /// </summary>
    let BankOndieptePlaat = _prefixId.prefix "BankOndieptePlaat"
    /// <summary>
    ///   <para>rdfs:label : BasaltblokkenSteenglooiing^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BasaltblokkenSteenglooiing">brt:BasaltblokkenSteenglooiing</a>
    /// </summary>
    let BasaltblokkenSteenglooiing = _prefixId.prefix "BasaltblokkenSteenglooiing"
    /// <summary>
    ///   <para>rdfs:label : BebouwdGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BebouwdGebied">brt:BebouwdGebied</a>
    /// </summary>
    let BebouwdGebied = _prefixId.prefix "BebouwdGebied"
    /// <summary>
    ///   <para>rdfs:label : Bedrijventerrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bedrijventerrein">brt:Bedrijventerrein</a>
    /// </summary>
    let Bedrijventerrein = _prefixId.prefix "Bedrijventerrein"
    /// <summary>
    ///   <para>rdfs:label : Begraafplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Begraafplaats">brt:Begraafplaats</a>
    /// </summary>
    let Begraafplaats = _prefixId.prefix "Begraafplaats"
    /// <summary>
    ///   <para>rdfs:label : Bezoekerscentrum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bezoekerscentrum">brt:Bezoekerscentrum</a>
    /// </summary>
    let Bezoekerscentrum = _prefixId.prefix "Bezoekerscentrum"
    /// <summary>
    ///   <para>rdfs:label : Bomenrij^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bomenrij">brt:Bomenrij</a>
    /// </summary>
    let Bomenrij = _prefixId.prefix "Bomenrij"
    /// <summary>
    ///   <para>rdfs:label : Boom^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Boom">brt:Boom</a>
    /// </summary>
    let Boom = _prefixId.prefix "Boom"
    /// <summary>
    ///   <para>rdfs:label : Boomgaard^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Boomgaard">brt:Boomgaard</a>
    /// </summary>
    let Boomgaard = _prefixId.prefix "Boomgaard"
    /// <summary>
    ///   <para>rdfs:label : Boomkwekerij^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Boomkwekerij">brt:Boomkwekerij</a>
    /// </summary>
    let Boomkwekerij = _prefixId.prefix "Boomkwekerij"
    /// <summary>
    ///   <para>rdfs:label : Boortoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Boortoren">brt:Boortoren</a>
    /// </summary>
    let Boortoren = _prefixId.prefix "Boortoren"
    /// <summary>
    ///   <para>rdfs:label : BosGemengdBos^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BosGemengdBos">brt:BosGemengdBos</a>
    /// </summary>
    let BosGemengdBos = _prefixId.prefix "BosGemengdBos"
    /// <summary>
    ///   <para>rdfs:label : BosGriend^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BosGriend">brt:BosGriend</a>
    /// </summary>
    let BosGriend = _prefixId.prefix "BosGriend"
    /// <summary>
    ///   <para>rdfs:label : BosLoofbos^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BosLoofbos">brt:BosLoofbos</a>
    /// </summary>
    let BosLoofbos = _prefixId.prefix "BosLoofbos"
    /// <summary>
    ///   <para>rdfs:label : BosNaaldbos^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BosNaaldbos">brt:BosNaaldbos</a>
    /// </summary>
    let BosNaaldbos = _prefixId.prefix "BosNaaldbos"
    /// <summary>
    ///   <para>rdfs:label : Bosgebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bosgebied">brt:Bosgebied</a>
    /// </summary>
    let Bosgebied = _prefixId.prefix "Bosgebied"
    /// <summary>
    ///   <para>rdfs:label : Boswachterij^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Boswachterij">brt:Boswachterij</a>
    /// </summary>
    let Boswachterij = _prefixId.prefix "Boswachterij"
    /// <summary>
    ///   <para>rdfs:label : Botenhelling^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Botenhelling">brt:Botenhelling</a>
    /// </summary>
    let Botenhelling = _prefixId.prefix "Botenhelling"
    /// <summary>
    ///   <para>rdfs:label : Braakliggend^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Braakliggend">brt:Braakliggend</a>
    /// </summary>
    let Braakliggend = _prefixId.prefix "Braakliggend"
    /// <summary>
    ///   <para>rdfs:label : Brandtoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Brandtoren">brt:Brandtoren</a>
    /// </summary>
    let Brandtoren = _prefixId.prefix "Brandtoren"
    /// <summary>
    ///   <para>rdfs:label : Brandweerkazerne^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Brandweerkazerne">brt:Brandweerkazerne</a>
    /// </summary>
    let Brandweerkazerne = _prefixId.prefix "Brandweerkazerne"
    /// <summary>
    ///   <para>rdfs:label : BronWel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#BronWel">brt:BronWel</a>
    /// </summary>
    let BronWel = _prefixId.prefix "BronWel"
    /// <summary>
    ///   <para>rdfs:label : Bungalowpark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bungalowpark">brt:Bungalowpark</a>
    /// </summary>
    let Bungalowpark = _prefixId.prefix "Bungalowpark"
    /// <summary>
    ///   <para>rdfs:label : Bunker^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Bunker">brt:Bunker</a>
    /// </summary>
    let Bunker = _prefixId.prefix "Bunker"
    /// <summary>
    ///   <para>rdfs:label : Busstation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Busstation">brt:Busstation</a>
    /// </summary>
    let Busstation = _prefixId.prefix "Busstation"
    /// <summary>
    ///   <para>rdfs:label : Buurt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Buurt">brt:Buurt</a>
    /// </summary>
    let Buurt = _prefixId.prefix "Buurt"
    /// <summary>
    ///   <para>rdfs:label : Buurtschap^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Buurtschap">brt:Buurtschap</a>
    /// </summary>
    let Buurtschap = _prefixId.prefix "Buurtschap"
    /// <summary>
    ///   <para>rdfs:label : Calamiteitendoorgang^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Calamiteitendoorgang">brt:Calamiteitendoorgang</a>
    /// </summary>
    let Calamiteitendoorgang = _prefixId.prefix "Calamiteitendoorgang"
    /// <summary>
    ///   <para>rdfs:label : CampingKampeerterrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#CampingKampeerterrein">brt:CampingKampeerterrein</a>
    /// </summary>
    let CampingKampeerterrein = _prefixId.prefix "CampingKampeerterrein"
    /// <summary>
    ///   <para>rdfs:label : Campus^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Campus">brt:Campus</a>
    /// </summary>
    let Campus = _prefixId.prefix "Campus"
    /// <summary>
    ///   <para>rdfs:label : Caravanpark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Caravanpark">brt:Caravanpark</a>
    /// </summary>
    let Caravanpark = _prefixId.prefix "Caravanpark"
    /// <summary>
    ///   <para>rdfs:label : Circuit^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Circuit">brt:Circuit</a>
    /// </summary>
    let Circuit = _prefixId.prefix "Circuit"
    /// <summary>
    ///   <para>rdfs:label : Crematorium^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Crematorium">brt:Crematorium</a>
    /// </summary>
    let Crematorium = _prefixId.prefix "Crematorium"
    /// <summary>
    ///   <para>rdfs:label : Crossbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Crossbaan">brt:Crossbaan</a>
    /// </summary>
    let Crossbaan = _prefixId.prefix "Crossbaan"
    /// <summary>
    ///   <para>rdfs:label : Deelkern^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Deelkern">brt:Deelkern</a>
    /// </summary>
    let Deelkern = _prefixId.prefix "Deelkern"
    /// <summary>
    ///   <para>rdfs:label : Dieptelijn^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Dieptelijn">brt:Dieptelijn</a>
    /// </summary>
    let Dieptelijn = _prefixId.prefix "Dieptelijn"
    /// <summary>
    ///   <para>rdfs:label : Dieptepunt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Dieptepunt">brt:Dieptepunt</a>
    /// </summary>
    let Dieptepunt = _prefixId.prefix "Dieptepunt"
    /// <summary>
    ///   <para>rdfs:label : DierentuinSafaripark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#DierentuinSafaripark">brt:DierentuinSafaripark</a>
    /// </summary>
    let DierentuinSafaripark = _prefixId.prefix "DierentuinSafaripark"
    /// <summary>
    ///   <para>rdfs:label : Dodenakker^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Dodenakker">brt:Dodenakker</a>
    /// </summary>
    let Dodenakker = _prefixId.prefix "Dodenakker"
    /// <summary>
    ///   <para>rdfs:label : DodenakkerMetBos^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#DodenakkerMetBos">brt:DodenakkerMetBos</a>
    /// </summary>
    let DodenakkerMetBos = _prefixId.prefix "DodenakkerMetBos"
    /// <summary>
    ///   <para>rdfs:label : Dok^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Dok">brt:Dok</a>
    /// </summary>
    let Dok = _prefixId.prefix "Dok"
    /// <summary>
    ///   <para>rdfs:label : Droogvallend^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Droogvallend">brt:Droogvallend</a>
    /// </summary>
    let Droogvallend = _prefixId.prefix "Droogvallend"
    /// <summary>
    ///   <para>rdfs:label : Droogvallend (LAT)^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Droogvallend_LAT">brt:Droogvallend_LAT</a>
    /// </summary>
    let Droogvallend_LAT = _prefixId.prefix "Droogvallend_LAT"
    /// <summary>
    ///   <para>rdfs:label : Duin^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Duin">brt:Duin</a>
    /// </summary>
    let Duin = _prefixId.prefix "Duin"
    /// <summary>
    ///   <para>rdfs:label : Duingebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Duingebied">brt:Duingebied</a>
    /// </summary>
    let Duingebied = _prefixId.prefix "Duingebied"
    /// <summary>
    ///   <para>rdfs:label : Dukdalf^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Dukdalf">brt:Dukdalf</a>
    /// </summary>
    let Dukdalf = _prefixId.prefix "Dukdalf"
    /// <summary>
    ///   <para>rdfs:label : Eendenkooi^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Eendenkooi">brt:Eendenkooi</a>
    /// </summary>
    let Eendenkooi = _prefixId.prefix "Eendenkooi"
    /// <summary>
    ///   <para>rdfs:label : Eiland^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Eiland">brt:Eiland</a>
    /// </summary>
    let Eiland = _prefixId.prefix "Eiland"
    /// <summary>
    ///   <para>rdfs:label : Elektriciteitscentrale^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Elektriciteitscentrale">brt:Elektriciteitscentrale</a>
    /// </summary>
    let Elektriciteitscentrale = _prefixId.prefix "Elektriciteitscentrale"
    /// <summary>
    ///   <para>rdfs:label : Emplacement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Emplacement">brt:Emplacement</a>
    /// </summary>
    let Emplacement = _prefixId.prefix "Emplacement"
    /// <summary>
    ///   <para>rdfs:label : Erebegraafplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Erebegraafplaats">brt:Erebegraafplaats</a>
    /// </summary>
    let Erebegraafplaats = _prefixId.prefix "Erebegraafplaats"
    /// <summary>
    ///   <para>rdfs:label : Fabriek^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Fabriek">brt:Fabriek</a>
    /// </summary>
    let Fabriek = _prefixId.prefix "Fabriek"
    /// <summary>
    ///   <para>rdfs:label : FeatureCollectionT10NL^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#FeatureCollectionT10NL">brt:FeatureCollectionT10NL</a>
    /// </summary>
    let FeatureCollectionT10NL = _prefixId.prefix "FeatureCollectionT10NL"
    /// <summary>
    ///   <para>rdfs:label : FeatureMember^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#FeatureMember">brt:FeatureMember</a>
    /// </summary>
    let FeatureMember = _prefixId.prefix "FeatureMember"
    /// <summary>
    ///   <para>rdfs:label : Fort^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Fort">brt:Fort</a>
    /// </summary>
    let Fort = _prefixId.prefix "Fort"
    /// <summary>
    ///   <para>rdfs:label : Fruitkwekerij^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Fruitkwekerij">brt:Fruitkwekerij</a>
    /// </summary>
    let Fruitkwekerij = _prefixId.prefix "Fruitkwekerij"
    /// <summary>
    ///   <para>rdfs:label : FunctioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#FunctioneelGebied">brt:FunctioneelGebied</a>
    /// </summary>
    let FunctioneelGebied = _prefixId.prefix "FunctioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Gaswinning_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gaswinning_functioneelGebied">brt:Gaswinning_functioneelGebied</a>
    /// </summary>
    let Gaswinning_functioneelGebied = _prefixId.prefix "Gaswinning_functioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Gaswinning_inrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gaswinning_inrichtingselement">brt:Gaswinning_inrichtingselement</a>
    /// </summary>
    let Gaswinning_inrichtingselement = _prefixId.prefix "Gaswinning_inrichtingselement"
    /// <summary>
    ///   <para>rdfs:label : GebiedMetHogeObjecten^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GebiedMetHogeObjecten">brt:GebiedMetHogeObjecten</a>
    /// </summary>
    let GebiedMetHogeObjecten = _prefixId.prefix "GebiedMetHogeObjecten"
    /// <summary>
    ///   <para>rdfs:label : Gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gebouw">brt:Gebouw</a>
    /// </summary>
    let Gebouw = _prefixId.prefix "Gebouw"
    /// <summary>
    ///   <para>rdfs:label : Gebouwencomplex^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gebouwencomplex">brt:Gebouwencomplex</a>
    /// </summary>
    let Gebouwencomplex = _prefixId.prefix "Gebouwencomplex"
    /// <summary>
    ///   <para>rdfs:label : GedenktekenMonument^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GedenktekenMonument">brt:GedenktekenMonument</a>
    /// </summary>
    let GedenktekenMonument = _prefixId.prefix "GedenktekenMonument"
    /// <summary>
    ///   <para>rdfs:label : Gehucht^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gehucht">brt:Gehucht</a>
    /// </summary>
    let Gehucht = _prefixId.prefix "Gehucht"
    /// <summary>
    ///   <para>rdfs:label : Geluidswering^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Geluidswering">brt:Geluidswering</a>
    /// </summary>
    let Geluidswering = _prefixId.prefix "Geluidswering"
    /// <summary>
    ///   <para>rdfs:label : Gemaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gemaal">brt:Gemaal</a>
    /// </summary>
    let Gemaal = _prefixId.prefix "Gemaal"
    /// <summary>
    ///   <para>rdfs:label : Gemeente^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gemeente">brt:Gemeente</a>
    /// </summary>
    let Gemeente = _prefixId.prefix "Gemeente"
    /// <summary>
    ///   <para>rdfs:label : Gemeentehuis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gemeentehuis">brt:Gemeentehuis</a>
    /// </summary>
    let Gemeentehuis = _prefixId.prefix "Gemeentehuis"
    /// <summary>
    ///   <para>rdfs:label : Gemengd^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gemengd">brt:Gemengd</a>
    /// </summary>
    let Gemengd = _prefixId.prefix "Gemengd"
    /// <summary>
    ///   <para>rdfs:label : GeografischGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GeografischGebied">brt:GeografischGebied</a>
    /// </summary>
    let GeografischGebied = _prefixId.prefix "GeografischGebied"
    /// <summary>
    ///   <para>rdfs:label : GeulVaargeul^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GeulVaargeul">brt:GeulVaargeul</a>
    /// </summary>
    let GeulVaargeul = _prefixId.prefix "GeulVaargeul"
    /// <summary>
    ///   <para>rdfs:label : Gevangenis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Gevangenis">brt:Gevangenis</a>
    /// </summary>
    let Gevangenis = _prefixId.prefix "Gevangenis"
    /// <summary>
    ///   <para>rdfs:label : Golfmeetpaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Golfmeetpaal">brt:Golfmeetpaal</a>
    /// </summary>
    let Golfmeetpaal = _prefixId.prefix "Golfmeetpaal"
    /// <summary>
    ///   <para>rdfs:label : Golfterrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Golfterrein">brt:Golfterrein</a>
    /// </summary>
    let Golfterrein = _prefixId.prefix "Golfterrein"
    /// <summary>
    ///   <para>rdfs:label : GpsKernnetpunt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GpsKernnetpunt">brt:GpsKernnetpunt</a>
    /// </summary>
    let GpsKernnetpunt = _prefixId.prefix "GpsKernnetpunt"
    /// <summary>
    ///   <para>rdfs:label : Grafheuvel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Grafheuvel">brt:Grafheuvel</a>
    /// </summary>
    let Grafheuvel = _prefixId.prefix "Grafheuvel"
    /// <summary>
    ///   <para>rdfs:label : Grasland^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Grasland">brt:Grasland</a>
    /// </summary>
    let Grasland = _prefixId.prefix "Grasland"
    /// <summary>
    ///   <para>rdfs:label : Grenspunt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Grenspunt">brt:Grenspunt</a>
    /// </summary>
    let Grenspunt = _prefixId.prefix "Grenspunt"
    /// <summary>
    ///   <para>rdfs:label : GreppelDrogeSloot^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#GreppelDrogeSloot">brt:GreppelDrogeSloot</a>
    /// </summary>
    let GreppelDrogeSloot = _prefixId.prefix "GreppelDrogeSloot"
    /// <summary>
    ///   <para>rdfs:label : Grindwinning^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Grindwinning">brt:Grindwinning</a>
    /// </summary>
    let Grindwinning = _prefixId.prefix "Grindwinning"
    /// <summary>
    ///   <para>rdfs:label : Groeve^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Groeve">brt:Groeve</a>
    /// </summary>
    let Groeve = _prefixId.prefix "Groeve"
    /// <summary>
    ///   <para>rdfs:label : Haven_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Haven_functioneelGebied">brt:Haven_functioneelGebied</a>
    /// </summary>
    let Haven_functioneelGebied = _prefixId.prefix "Haven_functioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Heemtuin^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Heemtuin">brt:Heemtuin</a>
    /// </summary>
    let Heemtuin = _prefixId.prefix "Heemtuin"
    /// <summary>
    ///   <para>rdfs:label : HegHaag^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#HegHaag">brt:HegHaag</a>
    /// </summary>
    let HegHaag = _prefixId.prefix "HegHaag"
    /// <summary>
    ///   <para>rdfs:label : Heide^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Heide">brt:Heide</a>
    /// </summary>
    let Heide = _prefixId.prefix "Heide"
    /// <summary>
    ///   <para>rdfs:label : Heidegebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Heidegebied">brt:Heidegebied</a>
    /// </summary>
    let Heidegebied = _prefixId.prefix "Heidegebied"
    /// <summary>
    ///   <para>rdfs:label : Hekwerk^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hekwerk">brt:Hekwerk</a>
    /// </summary>
    let Hekwerk = _prefixId.prefix "Hekwerk"
    /// <summary>
    ///   <para>rdfs:label : Helikopterlandingsplatform^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Helikopterlandingsplatform">brt:Helikopterlandingsplatform</a>
    /// </summary>
    let Helikopterlandingsplatform = _prefixId.prefix "Helikopterlandingsplatform"
    /// <summary>
    ///   <para>rdfs:label : Helikopterlandingsterrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Helikopterlandingsterrein">brt:Helikopterlandingsterrein</a>
    /// </summary>
    let Helikopterlandingsterrein = _prefixId.prefix "Helikopterlandingsterrein"
    /// <summary>
    ///   <para>rdfs:label : HeuvelBerg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#HeuvelBerg">brt:HeuvelBerg</a>
    /// </summary>
    let HeuvelBerg = _prefixId.prefix "HeuvelBerg"
    /// <summary>
    ///   <para>rdfs:label : Hoofdweg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoofdweg">brt:Hoofdweg</a>
    /// </summary>
    let Hoofdweg = _prefixId.prefix "Hoofdweg"
    /// <summary>
    ///   <para>rdfs:label : Hoogspanningsleiding^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogspanningsleiding">brt:Hoogspanningsleiding</a>
    /// </summary>
    let Hoogspanningsleiding = _prefixId.prefix "Hoogspanningsleiding"
    /// <summary>
    ///   <para>rdfs:label : Hoogspanningsmast^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogspanningsmast">brt:Hoogspanningsmast</a>
    /// </summary>
    let Hoogspanningsmast = _prefixId.prefix "Hoogspanningsmast"
    /// <summary>
    ///   <para>rdfs:label : Hoogte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogte">brt:Hoogte</a>
    /// </summary>
    let Hoogte = _prefixId.prefix "Hoogte"
    /// <summary>
    ///   <para>rdfs:label : Hoogtelijn^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogtelijn">brt:Hoogtelijn</a>
    /// </summary>
    let Hoogtelijn = _prefixId.prefix "Hoogtelijn"
    /// <summary>
    ///   <para>rdfs:label : Hoogtepunt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogtepunt">brt:Hoogtepunt</a>
    /// </summary>
    let Hoogtepunt = _prefixId.prefix "Hoogtepunt"
    /// <summary>
    ///   <para>rdfs:label : Hoogwaterlijn^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hoogwaterlijn">brt:Hoogwaterlijn</a>
    /// </summary>
    let Hoogwaterlijn = _prefixId.prefix "Hoogwaterlijn"
    /// <summary>
    ///   <para>rdfs:label : Hotel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hotel">brt:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>rdfs:label : Huizenblok^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Huizenblok">brt:Huizenblok</a>
    /// </summary>
    let Huizenblok = _prefixId.prefix "Huizenblok"
    /// <summary>
    ///   <para>rdfs:label : Hunebed^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Hunebed">brt:Hunebed</a>
    /// </summary>
    let Hunebed = _prefixId.prefix "Hunebed"
    /// <summary>
    ///   <para>rdfs:label : Ijsbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Ijsbaan">brt:Ijsbaan</a>
    /// </summary>
    let Ijsbaan = _prefixId.prefix "Ijsbaan"
    /// <summary>
    ///   <para>rdfs:label : Industriekern^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Industriekern">brt:Industriekern</a>
    /// </summary>
    let Industriekern = _prefixId.prefix "Industriekern"
    /// <summary>
    ///   <para>rdfs:label : Infiltratiegebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Infiltratiegebied">brt:Infiltratiegebied</a>
    /// </summary>
    let Infiltratiegebied = _prefixId.prefix "Infiltratiegebied"
    /// <summary>
    ///   <para>rdfs:label : Inrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Inrichtingselement">brt:Inrichtingselement</a>
    /// </summary>
    let Inrichtingselement = _prefixId.prefix "Inrichtingselement"
    /// <summary>
    ///   <para>rdfs:label : Jachthaven^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Jachthaven">brt:Jachthaven</a>
    /// </summary>
    let Jachthaven = _prefixId.prefix "Jachthaven"
    /// <summary>
    ///   <para>rdfs:label : Kaap^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kaap">brt:Kaap</a>
    /// </summary>
    let Kaap = _prefixId.prefix "Kaap"
    /// <summary>
    ///   <para>rdfs:label : KaapHoek^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KaapHoek">brt:KaapHoek</a>
    /// </summary>
    let KaapHoek = _prefixId.prefix "KaapHoek"
    /// <summary>
    ///   <para>rdfs:label : Kabelbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kabelbaan">brt:Kabelbaan</a>
    /// </summary>
    let Kabelbaan = _prefixId.prefix "Kabelbaan"
    /// <summary>
    ///   <para>rdfs:label : Kabelbaanmast^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kabelbaanmast">brt:Kabelbaanmast</a>
    /// </summary>
    let Kabelbaanmast = _prefixId.prefix "Kabelbaanmast"
    /// <summary>
    ///   <para>rdfs:label : Kapel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kapel">brt:Kapel</a>
    /// </summary>
    let Kapel = _prefixId.prefix "Kapel"
    /// <summary>
    ///   <para>rdfs:label : Kartingbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kartingbaan">brt:Kartingbaan</a>
    /// </summary>
    let Kartingbaan = _prefixId.prefix "Kartingbaan"
    /// <summary>
    ///   <para>rdfs:label : KasWarenhuis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KasWarenhuis">brt:KasWarenhuis</a>
    /// </summary>
    let KasWarenhuis = _prefixId.prefix "KasWarenhuis"
    /// <summary>
    ///   <para>rdfs:label : Kassengebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kassengebied">brt:Kassengebied</a>
    /// </summary>
    let Kassengebied = _prefixId.prefix "Kassengebied"
    /// <summary>
    ///   <para>rdfs:label : Kasteel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kasteel">brt:Kasteel</a>
    /// </summary>
    let Kasteel = _prefixId.prefix "Kasteel"
    /// <summary>
    ///   <para>rdfs:label : KazerneLegerplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KazerneLegerplaats">brt:KazerneLegerplaats</a>
    /// </summary>
    let KazerneLegerplaats = _prefixId.prefix "KazerneLegerplaats"
    /// <summary>
    ///   <para>rdfs:label : Kerk^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kerk">brt:Kerk</a>
    /// </summary>
    let Kerk = _prefixId.prefix "Kerk"
    /// <summary>
    ///   <para>rdfs:label : KerncentraleKernreactor^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KerncentraleKernreactor">brt:KerncentraleKernreactor</a>
    /// </summary>
    let KerncentraleKernreactor = _prefixId.prefix "KerncentraleKernreactor"
    /// <summary>
    ///   <para>rdfs:label : Kilometerpaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kilometerpaal">brt:Kilometerpaal</a>
    /// </summary>
    let Kilometerpaal = _prefixId.prefix "Kilometerpaal"
    /// <summary>
    ///   <para>rdfs:label : KilometerpaalSpoorweg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KilometerpaalSpoorweg">brt:KilometerpaalSpoorweg</a>
    /// </summary>
    let KilometerpaalSpoorweg = _prefixId.prefix "KilometerpaalSpoorweg"
    /// <summary>
    ///   <para>rdfs:label : KilometerpaalWater^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KilometerpaalWater">brt:KilometerpaalWater</a>
    /// </summary>
    let KilometerpaalWater = _prefixId.prefix "KilometerpaalWater"
    /// <summary>
    ///   <para>rdfs:label : Kilometerraaibord^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kilometerraaibord">brt:Kilometerraaibord</a>
    /// </summary>
    let Kilometerraaibord = _prefixId.prefix "Kilometerraaibord"
    /// <summary>
    ///   <para>rdfs:label : Kilometerraaipaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kilometerraaipaal">brt:Kilometerraaipaal</a>
    /// </summary>
    let Kilometerraaipaal = _prefixId.prefix "Kilometerraaipaal"
    /// <summary>
    ///   <para>rdfs:label : KliniekInrichtingSanatorium^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KliniekInrichtingSanatorium">brt:KliniekInrichtingSanatorium</a>
    /// </summary>
    let KliniekInrichtingSanatorium = _prefixId.prefix "KliniekInrichtingSanatorium"
    /// <summary>
    ///   <para>rdfs:label : Klokkentoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Klokkentoren">brt:Klokkentoren</a>
    /// </summary>
    let Klokkentoren = _prefixId.prefix "Klokkentoren"
    /// <summary>
    ///   <para>rdfs:label : KloosterAbdij^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KloosterAbdij">brt:KloosterAbdij</a>
    /// </summary>
    let KloosterAbdij = _prefixId.prefix "KloosterAbdij"
    /// <summary>
    ///   <para>rdfs:label : Koedam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Koedam">brt:Koedam</a>
    /// </summary>
    let Koedam = _prefixId.prefix "Koedam"
    /// <summary>
    ///   <para>rdfs:label : Koeltoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Koeltoren">brt:Koeltoren</a>
    /// </summary>
    let Koeltoren = _prefixId.prefix "Koeltoren"
    /// <summary>
    ///   <para>rdfs:label : Koepel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Koepel">brt:Koepel</a>
    /// </summary>
    let Koepel = _prefixId.prefix "Koepel"
    /// <summary>
    ///   <para>rdfs:label : KogelvangerSchietbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#KogelvangerSchietbaan">brt:KogelvangerSchietbaan</a>
    /// </summary>
    let KogelvangerSchietbaan = _prefixId.prefix "KogelvangerSchietbaan"
    /// <summary>
    ///   <para>rdfs:label : Kraan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kraan">brt:Kraan</a>
    /// </summary>
    let Kraan = _prefixId.prefix "Kraan"
    /// <summary>
    ///   <para>rdfs:label : Kruis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kruis">brt:Kruis</a>
    /// </summary>
    let Kruis = _prefixId.prefix "Kruis"
    /// <summary>
    ///   <para>rdfs:label : Kunstijsbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Kunstijsbaan">brt:Kunstijsbaan</a>
    /// </summary>
    let Kunstijsbaan = _prefixId.prefix "Kunstijsbaan"
    /// <summary>
    ///   <para>rdfs:label : Laagwaterlijn^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Laagwaterlijn">brt:Laagwaterlijn</a>
    /// </summary>
    let Laagwaterlijn = _prefixId.prefix "Laagwaterlijn"
    /// <summary>
    ///   <para>rdfs:label : Land^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Land">brt:Land</a>
    /// </summary>
    let Land = _prefixId.prefix "Land"
    /// <summary>
    ///   <para>rdfs:label : Landgoed^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Landgoed">brt:Landgoed</a>
    /// </summary>
    let Landgoed = _prefixId.prefix "Landgoed"
    /// <summary>
    ///   <para>rdfs:label : Leiding^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Leiding">brt:Leiding</a>
    /// </summary>
    let Leiding = _prefixId.prefix "Leiding"
    /// <summary>
    ///   <para>rdfs:label : Lichttoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Lichttoren">brt:Lichttoren</a>
    /// </summary>
    let Lichttoren = _prefixId.prefix "Lichttoren"
    /// <summary>
    ///   <para>rdfs:label : LokaleWeg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#LokaleWeg">brt:LokaleWeg</a>
    /// </summary>
    let LokaleWeg = _prefixId.prefix "LokaleWeg"
    /// <summary>
    ///   <para>rdfs:label : Luchtvaartlicht^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Luchtvaartlicht">brt:Luchtvaartlicht</a>
    /// </summary>
    let Luchtvaartlicht = _prefixId.prefix "Luchtvaartlicht"
    /// <summary>
    ///   <para>rdfs:label : Luchtwachttoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Luchtwachttoren">brt:Luchtwachttoren</a>
    /// </summary>
    let Luchtwachttoren = _prefixId.prefix "Luchtwachttoren"
    /// <summary>
    ///   <para>rdfs:label : Manege^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Manege">brt:Manege</a>
    /// </summary>
    let Manege = _prefixId.prefix "Manege"
    /// <summary>
    ///   <para>rdfs:label : MarkantGebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#MarkantGebouw">brt:MarkantGebouw</a>
    /// </summary>
    let MarkantGebouw = _prefixId.prefix "MarkantGebouw"
    /// <summary>
    ///   <para>rdfs:label : MarkantObject^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#MarkantObject">brt:MarkantObject</a>
    /// </summary>
    let MarkantObject = _prefixId.prefix "MarkantObject"
    /// <summary>
    ///   <para>rdfs:label : MeerPlas^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#MeerPlas">brt:MeerPlas</a>
    /// </summary>
    let MeerPlas = _prefixId.prefix "MeerPlas"
    /// <summary>
    ///   <para>rdfs:label : Metro^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Metro">brt:Metro</a>
    /// </summary>
    let Metro = _prefixId.prefix "Metro"
    /// <summary>
    ///   <para>rdfs:label : Metrostation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Metrostation">brt:Metrostation</a>
    /// </summary>
    let Metrostation = _prefixId.prefix "Metrostation"
    /// <summary>
    ///   <para>rdfs:label : Mijn^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Mijn">brt:Mijn</a>
    /// </summary>
    let Mijn = _prefixId.prefix "Mijn"
    /// <summary>
    ///   <para>rdfs:label : Milieustraat^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Milieustraat">brt:Milieustraat</a>
    /// </summary>
    let Milieustraat = _prefixId.prefix "Milieustraat"
    /// <summary>
    ///   <para>rdfs:label : MilitairGebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#MilitairGebouw">brt:MilitairGebouw</a>
    /// </summary>
    let MilitairGebouw = _prefixId.prefix "MilitairGebouw"

    /// <summary>
    ///   <para>rdfs:label : MilitairOefengebiedSchietterrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#MilitairOefengebiedSchietterrein">brt:MilitairOefengebiedSchietterrein</a>
    /// </summary>
    let MilitairOefengebiedSchietterrein = _prefixId.prefix "MilitairOefengebiedSchietterrein"

    /// <summary>
    ///   <para>rdfs:label : Moskee^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Moskee">brt:Moskee</a>
    /// </summary>
    let Moskee = _prefixId.prefix "Moskee"
    /// <summary>
    ///   <para>rdfs:label : Mosselbank^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Mosselbank">brt:Mosselbank</a>
    /// </summary>
    let Mosselbank = _prefixId.prefix "Mosselbank"
    /// <summary>
    ///   <para>rdfs:label : Museum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Museum">brt:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>rdfs:label : Muur^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Muur">brt:Muur</a>
    /// </summary>
    let Muur = _prefixId.prefix "Muur"
    /// <summary>
    ///   <para>rdfs:label : NatuurgebiedNatuurreservaat^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#NatuurgebiedNatuurreservaat">brt:NatuurgebiedNatuurreservaat</a>
    /// </summary>
    let NatuurgebiedNatuurreservaat = _prefixId.prefix "NatuurgebiedNatuurreservaat"
    /// <summary>
    ///   <para>rdfs:label : Observatorium^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Observatorium">brt:Observatorium</a>
    /// </summary>
    let Observatorium = _prefixId.prefix "Observatorium"
    /// <summary>
    ///   <para>rdfs:label : Oliepompinstallatie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Oliepompinstallatie">brt:Oliepompinstallatie</a>
    /// </summary>
    let Oliepompinstallatie = _prefixId.prefix "Oliepompinstallatie"
    /// <summary>
    ///   <para>rdfs:label : Oliewinning^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Oliewinning">brt:Oliewinning</a>
    /// </summary>
    let Oliewinning = _prefixId.prefix "Oliewinning"
    /// <summary>
    ///   <para>rdfs:label : Openluchtmuseum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Openluchtmuseum">brt:Openluchtmuseum</a>
    /// </summary>
    let Openluchtmuseum = _prefixId.prefix "Openluchtmuseum"
    /// <summary>
    ///   <para>rdfs:label : Openluchttheater^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Openluchttheater">brt:Openluchttheater</a>
    /// </summary>
    let Openluchttheater = _prefixId.prefix "Openluchttheater"
    /// <summary>
    ///   <para>rdfs:label : OverigReligieusGebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#OverigReligieusGebouw">brt:OverigReligieusGebouw</a>
    /// </summary>
    let OverigReligieusGebouw = _prefixId.prefix "OverigReligieusGebouw"
    /// <summary>
    ///   <para>rdfs:label : Overig_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_functioneelGebied">brt:Overig_functioneelGebied</a>
    /// </summary>
    let Overig_functioneelGebied = _prefixId.prefix "Overig_functioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Overig_gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_gebouw">brt:Overig_gebouw</a>
    /// </summary>
    let Overig_gebouw = _prefixId.prefix "Overig_gebouw"
    /// <summary>
    ///   <para>rdfs:label : Overig_geografischGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_geografischGebied">brt:Overig_geografischGebied</a>
    /// </summary>
    let Overig_geografischGebied = _prefixId.prefix "Overig_geografischGebied"
    /// <summary>
    ///   <para>rdfs:label : Overig_inrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_inrichtingselement">brt:Overig_inrichtingselement</a>
    /// </summary>
    let Overig_inrichtingselement = _prefixId.prefix "Overig_inrichtingselement"
    /// <summary>
    ///   <para>rdfs:label : Overig_planTopografie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_planTopografie">brt:Overig_planTopografie</a>
    /// </summary>
    let Overig_planTopografie = _prefixId.prefix "Overig_planTopografie"
    /// <summary>
    ///   <para>rdfs:label : Overig_terrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_terrein">brt:Overig_terrein</a>
    /// </summary>
    let Overig_terrein = _prefixId.prefix "Overig_terrein"
    /// <summary>
    ///   <para>rdfs:label : Overig_waterdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_waterdeel">brt:Overig_waterdeel</a>
    /// </summary>
    let Overig_waterdeel = _prefixId.prefix "Overig_waterdeel"
    /// <summary>
    ///   <para>rdfs:label : Overig_wegdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Overig_wegdeel">brt:Overig_wegdeel</a>
    /// </summary>
    let Overig_wegdeel = _prefixId.prefix "Overig_wegdeel"
    /// <summary>
    ///   <para>rdfs:label : Paal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Paal">brt:Paal</a>
    /// </summary>
    let Paal = _prefixId.prefix "Paal"
    /// <summary>
    ///   <para>rdfs:label : Paalwerk^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Paalwerk">brt:Paalwerk</a>
    /// </summary>
    let Paalwerk = _prefixId.prefix "Paalwerk"
    /// <summary>
    ///   <para>rdfs:label : Paleis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Paleis">brt:Paleis</a>
    /// </summary>
    let Paleis = _prefixId.prefix "Paleis"
    /// <summary>
    ///   <para>rdfs:label : Park^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Park">brt:Park</a>
    /// </summary>
    let Park = _prefixId.prefix "Park"

    /// <summary>
    ///   <para>rdfs:label : ParkeerdakParkeerdekParkeergarage^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ParkeerdakParkeerdekParkeergarage">brt:ParkeerdakParkeerdekParkeergarage</a>
    /// </summary>
    let ParkeerdakParkeerdekParkeergarage = _prefixId.prefix "ParkeerdakParkeerdekParkeergarage"

    /// <summary>
    ///   <para>rdfs:label : Parkeerplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Parkeerplaats">brt:Parkeerplaats</a>
    /// </summary>
    let Parkeerplaats = _prefixId.prefix "Parkeerplaats"
    /// <summary>
    ///   <para>rdfs:label : ParkeerplaatsCarpool^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ParkeerplaatsCarpool">brt:ParkeerplaatsCarpool</a>
    /// </summary>
    let ParkeerplaatsCarpool = _prefixId.prefix "ParkeerplaatsCarpool"
    /// <summary>
    ///   <para>rdfs:label : ParkeerplaatsPR^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ParkeerplaatsPR">brt:ParkeerplaatsPR</a>
    /// </summary>
    let ParkeerplaatsPR = _prefixId.prefix "ParkeerplaatsPR"
    /// <summary>
    ///   <para>rdfs:label : Peil^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Peil">brt:Peil</a>
    /// </summary>
    let Peil = _prefixId.prefix "Peil"
    /// <summary>
    ///   <para>rdfs:label : PeilWinterpeil^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#PeilWinterpeil">brt:PeilWinterpeil</a>
    /// </summary>
    let PeilWinterpeil = _prefixId.prefix "PeilWinterpeil"
    /// <summary>
    ///   <para>rdfs:label : PeilZomerpeil^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#PeilZomerpeil">brt:PeilZomerpeil</a>
    /// </summary>
    let PeilZomerpeil = _prefixId.prefix "PeilZomerpeil"
    /// <summary>
    ///   <para>rdfs:label : Peilmeetstation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Peilmeetstation">brt:Peilmeetstation</a>
    /// </summary>
    let Peilmeetstation = _prefixId.prefix "Peilmeetstation"
    /// <summary>
    ///   <para>rdfs:label : Peilschaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Peilschaal">brt:Peilschaal</a>
    /// </summary>
    let Peilschaal = _prefixId.prefix "Peilschaal"
    /// <summary>
    ///   <para>rdfs:label : Pijler^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Pijler">brt:Pijler</a>
    /// </summary>
    let Pijler = _prefixId.prefix "Pijler"
    /// <summary>
    ///   <para>rdfs:label : Plaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Plaats">brt:Plaats</a>
    /// </summary>
    let Plaats = _prefixId.prefix "Plaats"
    /// <summary>
    ///   <para>rdfs:label : Plaatsnaambord^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Plaatsnaambord">brt:Plaatsnaambord</a>
    /// </summary>
    let Plaatsnaambord = _prefixId.prefix "Plaatsnaambord"
    /// <summary>
    ///   <para>rdfs:label : PlanTopografie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#PlanTopografie">brt:PlanTopografie</a>
    /// </summary>
    let PlanTopografie = _prefixId.prefix "PlanTopografie"
    /// <summary>
    ///   <para>rdfs:label : Plantsoen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Plantsoen">brt:Plantsoen</a>
    /// </summary>
    let Plantsoen = _prefixId.prefix "Plantsoen"
    /// <summary>
    ///   <para>rdfs:label : Polder^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Polder">brt:Polder</a>
    /// </summary>
    let Polder = _prefixId.prefix "Polder"
    /// <summary>
    ///   <para>rdfs:label : Politiebureau^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Politiebureau">brt:Politiebureau</a>
    /// </summary>
    let Politiebureau = _prefixId.prefix "Politiebureau"
    /// <summary>
    ///   <para>rdfs:label : Pompstation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Pompstation">brt:Pompstation</a>
    /// </summary>
    let Pompstation = _prefixId.prefix "Pompstation"
    /// <summary>
    ///   <para>rdfs:label : Populieren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Populieren">brt:Populieren</a>
    /// </summary>
    let Populieren = _prefixId.prefix "Populieren"
    /// <summary>
    ///   <para>rdfs:label : Postkantoor^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Postkantoor">brt:Postkantoor</a>
    /// </summary>
    let Postkantoor = _prefixId.prefix "Postkantoor"
    /// <summary>
    ///   <para>rdfs:label : Productie-installatie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Productie-installatie">brt:Productie-installatie</a>
    /// </summary>
    let Productie_installatie = _prefixId.prefix "Productie-installatie"
    /// <summary>
    ///   <para>rdfs:label : Provincie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Provincie">brt:Provincie</a>
    /// </summary>
    let Provincie = _prefixId.prefix "Provincie"

    /// <summary>
    ///   <para>rdfs:label : PsychiatrischZiekenhuisPsychiatrischCentrum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#PsychiatrischZiekenhuisPsychiatrischCentrum">brt:PsychiatrischZiekenhuisPsychiatrischCentrum</a>
    /// </summary>
    let PsychiatrischZiekenhuisPsychiatrischCentrum = _prefixId.prefix "PsychiatrischZiekenhuisPsychiatrischCentrum"

    /// <summary>
    ///   <para>rdfs:label : Radarpost^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Radarpost">brt:Radarpost</a>
    /// </summary>
    let Radarpost = _prefixId.prefix "Radarpost"
    /// <summary>
    ///   <para>rdfs:label : Radartoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Radartoren">brt:Radartoren</a>
    /// </summary>
    let Radartoren = _prefixId.prefix "Radartoren"
    /// <summary>
    ///   <para>rdfs:label : Radiobaken^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Radiobaken">brt:Radiobaken</a>
    /// </summary>
    let Radiobaken = _prefixId.prefix "Radiobaken"
    /// <summary>
    ///   <para>rdfs:label : Radiotelescoop^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Radiotelescoop">brt:Radiotelescoop</a>
    /// </summary>
    let Radiotelescoop = _prefixId.prefix "Radiotelescoop"
    /// <summary>
    ///   <para>rdfs:label : RadiotorenTelevisietoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#RadiotorenTelevisietoren">brt:RadiotorenTelevisietoren</a>
    /// </summary>
    let RadiotorenTelevisietoren = _prefixId.prefix "RadiotorenTelevisietoren"
    /// <summary>
    ///   <para>rdfs:label : RdPunt^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#RdPunt">brt:RdPunt</a>
    /// </summary>
    let RdPunt = _prefixId.prefix "RdPunt"
    /// <summary>
    ///   <para>rdfs:label : Recreatiecentrum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Recreatiecentrum">brt:Recreatiecentrum</a>
    /// </summary>
    let Recreatiecentrum = _prefixId.prefix "Recreatiecentrum"
    /// <summary>
    ///   <para>rdfs:label : Recreatiegebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Recreatiegebied">brt:Recreatiegebied</a>
    /// </summary>
    let Recreatiegebied = _prefixId.prefix "Recreatiegebied"
    /// <summary>
    ///   <para>rdfs:label : Recreatiekern^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Recreatiekern">brt:Recreatiekern</a>
    /// </summary>
    let Recreatiekern = _prefixId.prefix "Recreatiekern"
    /// <summary>
    ///   <para>rdfs:label : Reddingboothuisje^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Reddingboothuisje">brt:Reddingboothuisje</a>
    /// </summary>
    let Reddingboothuisje = _prefixId.prefix "Reddingboothuisje"
    /// <summary>
    ///   <para>rdfs:label : RegionaleWeg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#RegionaleWeg">brt:RegionaleWeg</a>
    /// </summary>
    let RegionaleWeg = _prefixId.prefix "RegionaleWeg"
    /// <summary>
    ///   <para>rdfs:label : RegistratiefGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#RegistratiefGebied">brt:RegistratiefGebied</a>
    /// </summary>
    let RegistratiefGebied = _prefixId.prefix "RegistratiefGebied"
    /// <summary>
    ///   <para>rdfs:label : Relief^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Relief">brt:Relief</a>
    /// </summary>
    let Relief = _prefixId.prefix "Relief"
    /// <summary>
    ///   <para>rdfs:label : Remise^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Remise">brt:Remise</a>
    /// </summary>
    let Remise = _prefixId.prefix "Remise"
    /// <summary>
    ///   <para>rdfs:label : Renbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Renbaan">brt:Renbaan</a>
    /// </summary>
    let Renbaan = _prefixId.prefix "Renbaan"
    /// <summary>
    ///   <para>rdfs:label : RolbaanPlatform^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#RolbaanPlatform">brt:RolbaanPlatform</a>
    /// </summary>
    let RolbaanPlatform = _prefixId.prefix "RolbaanPlatform"
    /// <summary>
    ///   <para>rdfs:label : Rune^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Rune">brt:Rune</a>
    /// </summary>
    let Rune = _prefixId.prefix "Rune"
    /// <summary>
    ///   <para>rdfs:label : Schaapskooi^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Schaapskooi">brt:Schaapskooi</a>
    /// </summary>
    let Schaapskooi = _prefixId.prefix "Schaapskooi"
    /// <summary>
    ///   <para>rdfs:label : Scheepvaartlicht^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Scheepvaartlicht">brt:Scheepvaartlicht</a>
    /// </summary>
    let Scheepvaartlicht = _prefixId.prefix "Scheepvaartlicht"
    /// <summary>
    ///   <para>rdfs:label : Schietbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Schietbaan">brt:Schietbaan</a>
    /// </summary>
    let Schietbaan = _prefixId.prefix "Schietbaan"
    /// <summary>
    ///   <para>rdfs:label : School^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#School">brt:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>rdfs:label : Schoorsteen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Schoorsteen">brt:Schoorsteen</a>
    /// </summary>
    let Schoorsteen = _prefixId.prefix "Schoorsteen"
    /// <summary>
    ///   <para>rdfs:label : Seinmast^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Seinmast">brt:Seinmast</a>
    /// </summary>
    let Seinmast = _prefixId.prefix "Seinmast"
    /// <summary>
    ///   <para>rdfs:label : Silo^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Silo">brt:Silo</a>
    /// </summary>
    let Silo = _prefixId.prefix "Silo"
    /// <summary>
    ///   <para>rdfs:label : Skibaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Skibaan">brt:Skibaan</a>
    /// </summary>
    let Skibaan = _prefixId.prefix "Skibaan"
    /// <summary>
    ///   <para>rdfs:label : Slipschool^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Slipschool">brt:Slipschool</a>
    /// </summary>
    let Slipschool = _prefixId.prefix "Slipschool"
    /// <summary>
    ///   <para>rdfs:label : Sluisdeur^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Sluisdeur">brt:Sluisdeur</a>
    /// </summary>
    let Sluisdeur = _prefixId.prefix "Sluisdeur"
    /// <summary>
    ///   <para>rdfs:label : Sluizencomplex^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Sluizencomplex">brt:Sluizencomplex</a>
    /// </summary>
    let Sluizencomplex = _prefixId.prefix "Sluizencomplex"
    /// <summary>
    ///   <para>rdfs:label : Sneltram^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Sneltram">brt:Sneltram</a>
    /// </summary>
    let Sneltram = _prefixId.prefix "Sneltram"
    /// <summary>
    ///   <para>rdfs:label : Sneltramhalte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Sneltramhalte">brt:Sneltramhalte</a>
    /// </summary>
    let Sneltramhalte = _prefixId.prefix "Sneltramhalte"
    /// <summary>
    ///   <para>rdfs:label : Spoor^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Spoor">brt:Spoor</a>
    /// </summary>
    let Spoor = _prefixId.prefix "Spoor"
    /// <summary>
    ///   <para>rdfs:label : Spoorbaandeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Spoorbaandeel">brt:Spoorbaandeel</a>
    /// </summary>
    let Spoorbaandeel = _prefixId.prefix "Spoorbaandeel"
    /// <summary>
    ///   <para>rdfs:label : Spoorbaanlichaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Spoorbaanlichaam">brt:Spoorbaanlichaam</a>
    /// </summary>
    let Spoorbaanlichaam = _prefixId.prefix "Spoorbaanlichaam"
    /// <summary>
    ///   <para>rdfs:label : Sporthal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Sporthal">brt:Sporthal</a>
    /// </summary>
    let Sporthal = _prefixId.prefix "Sporthal"
    /// <summary>
    ///   <para>rdfs:label : SportterreinSportcomplex^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#SportterreinSportcomplex">brt:SportterreinSportcomplex</a>
    /// </summary>
    let SportterreinSportcomplex = _prefixId.prefix "SportterreinSportcomplex"
    /// <summary>
    ///   <para>rdfs:label : Stadion^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stadion">brt:Stadion</a>
    /// </summary>
    let Stadion = _prefixId.prefix "Stadion"
    /// <summary>
    ///   <para>rdfs:label : Stadsdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stadsdeel">brt:Stadsdeel</a>
    /// </summary>
    let Stadsdeel = _prefixId.prefix "Stadsdeel"
    /// <summary>
    ///   <para>rdfs:label : StadskantoorHulpsecretarie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#StadskantoorHulpsecretarie">brt:StadskantoorHulpsecretarie</a>
    /// </summary>
    let StadskantoorHulpsecretarie = _prefixId.prefix "StadskantoorHulpsecretarie"
    /// <summary>
    ///   <para>rdfs:label : StartbaanLandingsbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#StartbaanLandingsbaan">brt:StartbaanLandingsbaan</a>
    /// </summary>
    let StartbaanLandingsbaan = _prefixId.prefix "StartbaanLandingsbaan"
    /// <summary>
    ///   <para>rdfs:label : Stationsgebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stationsgebouw">brt:Stationsgebouw</a>
    /// </summary>
    let Stationsgebouw = _prefixId.prefix "Stationsgebouw"
    /// <summary>
    ///   <para>rdfs:label : SteileRandAardrand^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#SteileRandAardrand">brt:SteileRandAardrand</a>
    /// </summary>
    let SteileRandAardrand = _prefixId.prefix "SteileRandAardrand"
    /// <summary>
    ///   <para>rdfs:label : Stormvloedkering^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stormvloedkering">brt:Stormvloedkering</a>
    /// </summary>
    let Stormvloedkering = _prefixId.prefix "Stormvloedkering"
    /// <summary>
    ///   <para>rdfs:label : Stortplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stortplaats">brt:Stortplaats</a>
    /// </summary>
    let Stortplaats = _prefixId.prefix "Stortplaats"
    /// <summary>
    ///   <para>rdfs:label : Straat^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Straat">brt:Straat</a>
    /// </summary>
    let Straat = _prefixId.prefix "Straat"
    /// <summary>
    ///   <para>rdfs:label : Strandpaal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Strandpaal">brt:Strandpaal</a>
    /// </summary>
    let Strandpaal = _prefixId.prefix "Strandpaal"
    /// <summary>
    ///   <para>rdfs:label : StreekVeld^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#StreekVeld">brt:StreekVeld</a>
    /// </summary>
    let StreekVeld = _prefixId.prefix "StreekVeld"
    /// <summary>
    ///   <para>rdfs:label : StrekdamKribGolfbreker^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#StrekdamKribGolfbreker">brt:StrekdamKribGolfbreker</a>
    /// </summary>
    let StrekdamKribGolfbreker = _prefixId.prefix "StrekdamKribGolfbreker"
    /// <summary>
    ///   <para>rdfs:label : Stuw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Stuw">brt:Stuw</a>
    /// </summary>
    let Stuw = _prefixId.prefix "Stuw"
    /// <summary>
    ///   <para>rdfs:label : Synagoge^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Synagoge">brt:Synagoge</a>
    /// </summary>
    let Synagoge = _prefixId.prefix "Synagoge"
    /// <summary>
    ///   <para>rdfs:label : TaludHoogteverschil^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#TaludHoogteverschil">brt:TaludHoogteverschil</a>
    /// </summary>
    let TaludHoogteverschil = _prefixId.prefix "TaludHoogteverschil"
    /// <summary>
    ///   <para>rdfs:label : Tank^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tank">brt:Tank</a>
    /// </summary>
    let Tank = _prefixId.prefix "Tank"
    /// <summary>
    ///   <para>rdfs:label : Tankstation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tankstation">brt:Tankstation</a>
    /// </summary>
    let Tankstation = _prefixId.prefix "Tankstation"
    /// <summary>
    ///   <para>rdfs:label : Telecommunicatietoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Telecommunicatietoren">brt:Telecommunicatietoren</a>
    /// </summary>
    let Telecommunicatietoren = _prefixId.prefix "Telecommunicatietoren"
    /// <summary>
    ///   <para>rdfs:label : Tennispark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tennispark">brt:Tennispark</a>
    /// </summary>
    let Tennispark = _prefixId.prefix "Tennispark"
    /// <summary>
    ///   <para>rdfs:label : TerpWierde^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#TerpWierde">brt:TerpWierde</a>
    /// </summary>
    let TerpWierde = _prefixId.prefix "TerpWierde"
    /// <summary>
    ///   <para>rdfs:label : Terrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Terrein">brt:Terrein</a>
    /// </summary>
    let Terrein = _prefixId.prefix "Terrein"
    /// <summary>
    ///   <para>rdfs:label : TerritorialeZee^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#TerritorialeZee">brt:TerritorialeZee</a>
    /// </summary>
    let TerritorialeZee = _prefixId.prefix "TerritorialeZee"
    /// <summary>
    ///   <para>rdfs:label : Tol_gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tol_gebouw">brt:Tol_gebouw</a>
    /// </summary>
    let Tol_gebouw = _prefixId.prefix "Tol_gebouw"
    /// <summary>
    ///   <para>rdfs:label : Tol_inrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tol_inrichtingselement">brt:Tol_inrichtingselement</a>
    /// </summary>
    let Tol_inrichtingselement = _prefixId.prefix "Tol_inrichtingselement"
    /// <summary>
    ///   <para>rdfs:label : Toren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Toren">brt:Toren</a>
    /// </summary>
    let Toren = _prefixId.prefix "Toren"
    /// <summary>
    ///   <para>rdfs:label : Tram^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tram">brt:Tram</a>
    /// </summary>
    let Tram = _prefixId.prefix "Tram"

    /// <summary>
    ///   <para>rdfs:label : Transformatorstation_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Transformatorstation_functioneelGebied">brt:Transformatorstation_functioneelGebied</a>
    /// </summary>
    let Transformatorstation_functioneelGebied = _prefixId.prefix "Transformatorstation_functioneelGebied"

    /// <summary>
    ///   <para>rdfs:label : Transformatorstation_gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Transformatorstation_gebouw">brt:Transformatorstation_gebouw</a>
    /// </summary>
    let Transformatorstation_gebouw = _prefixId.prefix "Transformatorstation_gebouw"
    /// <summary>
    ///   <para>rdfs:label : Trein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Trein">brt:Trein</a>
    /// </summary>
    let Trein = _prefixId.prefix "Trein"
    /// <summary>
    ///   <para>rdfs:label : Treinstation^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Treinstation">brt:Treinstation</a>
    /// </summary>
    let Treinstation = _prefixId.prefix "Treinstation"
    /// <summary>
    ///   <para>rdfs:label : Tuincentrum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Tuincentrum">brt:Tuincentrum</a>
    /// </summary>
    let Tuincentrum = _prefixId.prefix "Tuincentrum"
    /// <summary>
    ///   <para>rdfs:label : Uitzichttoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Uitzichttoren">brt:Uitzichttoren</a>
    /// </summary>
    let Uitzichttoren = _prefixId.prefix "Uitzichttoren"
    /// <summary>
    ///   <para>rdfs:label : Universiteit^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Universiteit">brt:Universiteit</a>
    /// </summary>
    let Universiteit = _prefixId.prefix "Universiteit"
    /// <summary>
    ///   <para>rdfs:label : Veerverbinding^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Veerverbinding">brt:Veerverbinding</a>
    /// </summary>
    let Veerverbinding = _prefixId.prefix "Veerverbinding"
    /// <summary>
    ///   <para>rdfs:label : Veiling^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Veiling">brt:Veiling</a>
    /// </summary>
    let Veiling = _prefixId.prefix "Veiling"
    /// <summary>
    ///   <para>rdfs:label : Verkeersgeleider^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Verkeersgeleider">brt:Verkeersgeleider</a>
    /// </summary>
    let Verkeersgeleider = _prefixId.prefix "Verkeersgeleider"
    /// <summary>
    ///   <para>rdfs:label : Verkeerstoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Verkeerstoren">brt:Verkeerstoren</a>
    /// </summary>
    let Verkeerstoren = _prefixId.prefix "Verkeerstoren"
    /// <summary>
    ///   <para>rdfs:label : Verzorgingsplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Verzorgingsplaats">brt:Verzorgingsplaats</a>
    /// </summary>
    let Verzorgingsplaats = _prefixId.prefix "Verzorgingsplaats"
    /// <summary>
    ///   <para>rdfs:label : Viskwekerij_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Viskwekerij_functioneelGebied">brt:Viskwekerij_functioneelGebied</a>
    /// </summary>
    let Viskwekerij_functioneelGebied = _prefixId.prefix "Viskwekerij_functioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Vlampijp^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Vlampijp">brt:Vlampijp</a>
    /// </summary>
    let Vlampijp = _prefixId.prefix "Vlampijp"
    /// <summary>
    ///   <para>rdfs:label : Vliedberg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Vliedberg">brt:Vliedberg</a>
    /// </summary>
    let Vliedberg = _prefixId.prefix "Vliedberg"
    /// <summary>
    ///   <para>rdfs:label : VliegveldLuchthaven^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#VliegveldLuchthaven">brt:VliegveldLuchthaven</a>
    /// </summary>
    let VliegveldLuchthaven = _prefixId.prefix "VliegveldLuchthaven"
    /// <summary>
    ///   <para>rdfs:label : Volkstuinen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Volkstuinen">brt:Volkstuinen</a>
    /// </summary>
    let Volkstuinen = _prefixId.prefix "Volkstuinen"
    /// <summary>
    ///   <para>rdfs:label : Vuurtoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Vuurtoren">brt:Vuurtoren</a>
    /// </summary>
    let Vuurtoren = _prefixId.prefix "Vuurtoren"
    /// <summary>
    ///   <para>rdfs:label : Wad^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wad">brt:Wad</a>
    /// </summary>
    let Wad = _prefixId.prefix "Wad"
    /// <summary>
    ///   <para>rdfs:label : Wal^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wal">brt:Wal</a>
    /// </summary>
    let Wal = _prefixId.prefix "Wal"
    /// <summary>
    ///   <para>rdfs:label : Water^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Water">brt:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>rdfs:label : Waterdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Waterdeel">brt:Waterdeel</a>
    /// </summary>
    let Waterdeel = _prefixId.prefix "Waterdeel"
    /// <summary>
    ///   <para>rdfs:label : Watergebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Watergebied">brt:Watergebied</a>
    /// </summary>
    let Watergebied = _prefixId.prefix "Watergebied"
    /// <summary>
    ///   <para>rdfs:label : Waterkering^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Waterkering">brt:Waterkering</a>
    /// </summary>
    let Waterkering = _prefixId.prefix "Waterkering"
    /// <summary>
    ///   <para>rdfs:label : Waterloop^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Waterloop">brt:Waterloop</a>
    /// </summary>
    let Waterloop = _prefixId.prefix "Waterloop"
    /// <summary>
    ///   <para>rdfs:label : Waterradmolen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Waterradmolen">brt:Waterradmolen</a>
    /// </summary>
    let Waterradmolen = _prefixId.prefix "Waterradmolen"
    /// <summary>
    ///   <para>rdfs:label : Waterschap^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Waterschap">brt:Waterschap</a>
    /// </summary>
    let Waterschap = _prefixId.prefix "Waterschap"
    /// <summary>
    ///   <para>rdfs:label : Watertoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Watertoren">brt:Watertoren</a>
    /// </summary>
    let Watertoren = _prefixId.prefix "Watertoren"
    /// <summary>
    ///   <para>rdfs:label : Weg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Weg">brt:Weg</a>
    /// </summary>
    let Weg = _prefixId.prefix "Weg"
    /// <summary>
    ///   <para>rdfs:label : Wegafsluiting^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wegafsluiting">brt:Wegafsluiting</a>
    /// </summary>
    let Wegafsluiting = _prefixId.prefix "Wegafsluiting"
    /// <summary>
    ///   <para>rdfs:label : Wegdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wegdeel">brt:Wegdeel</a>
    /// </summary>
    let Wegdeel = _prefixId.prefix "Wegdeel"
    /// <summary>
    ///   <para>rdfs:label : Wegrestaurant^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wegrestaurant">brt:Wegrestaurant</a>
    /// </summary>
    let Wegrestaurant = _prefixId.prefix "Wegrestaurant"
    /// <summary>
    ///   <para>rdfs:label : Wegwijzer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wegwijzer">brt:Wegwijzer</a>
    /// </summary>
    let Wegwijzer = _prefixId.prefix "Wegwijzer"
    /// <summary>
    ///   <para>rdfs:label : Werf_functioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Werf_functioneelGebied">brt:Werf_functioneelGebied</a>
    /// </summary>
    let Werf_functioneelGebied = _prefixId.prefix "Werf_functioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : Werf_gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Werf_gebouw">brt:Werf_gebouw</a>
    /// </summary>
    let Werf_gebouw = _prefixId.prefix "Werf_gebouw"
    /// <summary>
    ///   <para>rdfs:label : Wijk^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wijk">brt:Wijk</a>
    /// </summary>
    let Wijk = _prefixId.prefix "Wijk"
    /// <summary>
    ///   <para>rdfs:label : Wildwissel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Wildwissel">brt:Wildwissel</a>
    /// </summary>
    let Wildwissel = _prefixId.prefix "Wildwissel"
    /// <summary>
    ///   <para>rdfs:label : Windmolen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Windmolen">brt:Windmolen</a>
    /// </summary>
    let Windmolen = _prefixId.prefix "Windmolen"
    /// <summary>
    ///   <para>rdfs:label : WindmolenKorenmolen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#WindmolenKorenmolen">brt:WindmolenKorenmolen</a>
    /// </summary>
    let WindmolenKorenmolen = _prefixId.prefix "WindmolenKorenmolen"
    /// <summary>
    ///   <para>rdfs:label : WindmolenWatermolen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#WindmolenWatermolen">brt:WindmolenWatermolen</a>
    /// </summary>
    let WindmolenWatermolen = _prefixId.prefix "WindmolenWatermolen"
    /// <summary>
    ///   <para>rdfs:label : Windmolentje^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Windmolentje">brt:Windmolentje</a>
    /// </summary>
    let Windmolentje = _prefixId.prefix "Windmolentje"
    /// <summary>
    ///   <para>rdfs:label : Windturbine^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Windturbine">brt:Windturbine</a>
    /// </summary>
    let Windturbine = _prefixId.prefix "Windturbine"
    /// <summary>
    ///   <para>rdfs:label : Windturbinepark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Windturbinepark">brt:Windturbinepark</a>
    /// </summary>
    let Windturbinepark = _prefixId.prefix "Windturbinepark"
    /// <summary>
    ///   <para>rdfs:label : Woonkern^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Woonkern">brt:Woonkern</a>
    /// </summary>
    let Woonkern = _prefixId.prefix "Woonkern"
    /// <summary>
    ///   <para>rdfs:label : Woonwagencentrum^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Woonwagencentrum">brt:Woonwagencentrum</a>
    /// </summary>
    let Woonwagencentrum = _prefixId.prefix "Woonwagencentrum"
    /// <summary>
    ///   <para>rdfs:label : Zand^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zand">brt:Zand</a>
    /// </summary>
    let Zand = _prefixId.prefix "Zand"
    /// <summary>
    ///   <para>rdfs:label : Zandwinning^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zandwinning">brt:Zandwinning</a>
    /// </summary>
    let Zandwinning = _prefixId.prefix "Zandwinning"
    /// <summary>
    ///   <para>rdfs:label : Zee_geografischGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zee_geografischGebied">brt:Zee_geografischGebied</a>
    /// </summary>
    let Zee_geografischGebied = _prefixId.prefix "Zee_geografischGebied"
    /// <summary>
    ///   <para>rdfs:label : Zee_waterdeel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zee_waterdeel">brt:Zee_waterdeel</a>
    /// </summary>
    let Zee_waterdeel = _prefixId.prefix "Zee_waterdeel"
    /// <summary>
    ///   <para>rdfs:label : ZeegatZeearm^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ZeegatZeearm">brt:ZeegatZeearm</a>
    /// </summary>
    let ZeegatZeearm = _prefixId.prefix "ZeegatZeearm"
    /// <summary>
    ///   <para>rdfs:label : Zenderpark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zenderpark">brt:Zenderpark</a>
    /// </summary>
    let Zenderpark = _prefixId.prefix "Zenderpark"
    /// <summary>
    ///   <para>rdfs:label : Zendmast^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zendmast">brt:Zendmast</a>
    /// </summary>
    let Zendmast = _prefixId.prefix "Zendmast"
    /// <summary>
    ///   <para>rdfs:label : Zendtoren^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zendtoren">brt:Zendtoren</a>
    /// </summary>
    let Zendtoren = _prefixId.prefix "Zendtoren"
    /// <summary>
    ///   <para>rdfs:label : ZichtbaarWrak^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ZichtbaarWrak">brt:ZichtbaarWrak</a>
    /// </summary>
    let ZichtbaarWrak = _prefixId.prefix "ZichtbaarWrak"
    /// <summary>
    ///   <para>rdfs:label : Ziekenhuis^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Ziekenhuis">brt:Ziekenhuis</a>
    /// </summary>
    let Ziekenhuis = _prefixId.prefix "Ziekenhuis"
    /// <summary>
    ///   <para>rdfs:label : Ziekenhuiscomplex^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Ziekenhuiscomplex">brt:Ziekenhuiscomplex</a>
    /// </summary>
    let Ziekenhuiscomplex = _prefixId.prefix "Ziekenhuiscomplex"
    /// <summary>
    ///   <para>rdfs:label : Zonnepark^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zonnepark">brt:Zonnepark</a>
    /// </summary>
    let Zonnepark = _prefixId.prefix "Zonnepark"
    /// <summary>
    ///   <para>rdfs:label : Zoutwinning^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zoutwinning">brt:Zoutwinning</a>
    /// </summary>
    let Zoutwinning = _prefixId.prefix "Zoutwinning"
    /// <summary>
    ///   <para>rdfs:label : Zuiveringsinstallatie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zuiveringsinstallatie">brt:Zuiveringsinstallatie</a>
    /// </summary>
    let Zuiveringsinstallatie = _prefixId.prefix "Zuiveringsinstallatie"
    /// <summary>
    ///   <para>rdfs:label : Zweefvliegveldterrein^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zweefvliegveldterrein">brt:Zweefvliegveldterrein</a>
    /// </summary>
    let Zweefvliegveldterrein = _prefixId.prefix "Zweefvliegveldterrein"
    /// <summary>
    ///   <para>rdfs:label : Zwembadcomplex^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#ZwembadComplex">brt:ZwembadComplex</a>
    /// </summary>
    let ZwembadComplex = _prefixId.prefix "ZwembadComplex"
    /// <summary>
    ///   <para>rdfs:label : Zwembad_gebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#Zwembad_gebouw">brt:Zwembad_gebouw</a>
    /// </summary>
    let Zwembad_gebouw = _prefixId.prefix "Zwembad_gebouw"
    /// <summary>
    ///   <para>rdfs:label : _Top10nlObject^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#_Top10nlObject">brt:_Top10nlObject</a>
    /// </summary>
    let _Top10nlObject = _prefixId.prefix "_Top10nlObject"
    /// <summary>
    ///   <para>rdfs:label : aWegnummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#aWegnummer">brt:aWegnummer</a>
    /// </summary>
    let aWegnummer = _prefixId.prefix "aWegnummer"
    /// <summary>
    ///   <para>rdfs:label : aantalRijstroken^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#aantalRijstroken">brt:aantalRijstroken</a>
    /// </summary>
    let aantalRijstroken = _prefixId.prefix "aantalRijstroken"
    /// <summary>
    ///   <para>rdfs:label : aantalSporen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#aantalSporen">brt:aantalSporen</a>
    /// </summary>
    let aantalSporen = _prefixId.prefix "aantalSporen"
    /// <summary>
    ///   <para>rdfs:label : aantalinwoners^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#aantalinwoners">brt:aantalinwoners</a>
    /// </summary>
    let aantalinwoners = _prefixId.prefix "aantalinwoners"
    /// <summary>
    ///   <para>rdfs:label : afritnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#afritnaam">brt:afritnaam</a>
    /// </summary>
    let afritnaam = _prefixId.prefix "afritnaam"
    /// <summary>
    ///   <para>rdfs:label : afritnummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#afritnummer">brt:afritnummer</a>
    /// </summary>
    let afritnummer = _prefixId.prefix "afritnummer"
    /// <summary>
    ///   <para>rdfs:label : baanvaknaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#baanvaknaam">brt:baanvaknaam</a>
    /// </summary>
    let baanvaknaam = _prefixId.prefix "baanvaknaam"
    /// <summary>
    ///   <para>rdfs:label : bebouwdeKom^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#bebouwdeKom">brt:bebouwdeKom</a>
    /// </summary>
    let bebouwdeKom = _prefixId.prefix "bebouwdeKom"
    /// <summary>
    ///   <para>rdfs:label : breedte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#breedte">brt:breedte</a>
    /// </summary>
    let breedte = _prefixId.prefix "breedte"
    /// <summary>
    ///   <para>rdfs:label : breedteklasse^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#breedteklasse">brt:breedteklasse</a>
    /// </summary>
    let breedteklasse = _prefixId.prefix "breedteklasse"
    /// <summary>
    ///   <para>rdfs:label : bronactualiteit^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#bronactualiteit">brt:bronactualiteit</a>
    /// </summary>
    let bronactualiteit = _prefixId.prefix "bronactualiteit"
    /// <summary>
    ///   <para>rdfs:label : bronbeschrijving^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#bronbeschrijving">brt:bronbeschrijving</a>
    /// </summary>
    let bronbeschrijving = _prefixId.prefix "bronbeschrijving"
    /// <summary>
    ///   <para>rdfs:label : bronnauwkeurigheid^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#bronnauwkeurigheid">brt:bronnauwkeurigheid</a>
    /// </summary>
    let bronnauwkeurigheid = _prefixId.prefix "bronnauwkeurigheid"
    /// <summary>
    ///   <para>rdfs:label : brontype^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#brontype">brt:brontype</a>
    /// </summary>
    let brontype = _prefixId.prefix "brontype"
    /// <summary>
    ///   <para>rdfs:label : brugnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#brugnaam">brt:brugnaam</a>
    /// </summary>
    let brugnaam = _prefixId.prefix "brugnaam"
    /// <summary>
    ///   <para>rdfs:label : eWegnummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#eWegnummer">brt:eWegnummer</a>
    /// </summary>
    let eWegnummer = _prefixId.prefix "eWegnummer"
    /// <summary>
    ///   <para>rdfs:label : eindRegistratie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#eindRegistratie">brt:eindRegistratie</a>
    /// </summary>
    let eindRegistratie = _prefixId.prefix "eindRegistratie"
    /// <summary>
    ///   <para>rdfs:label : elektrificatie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#elektrificatie">brt:elektrificatie</a>
    /// </summary>
    let elektrificatie = _prefixId.prefix "elektrificatie"
    /// <summary>
    ///   <para>rdfs:label : functie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#functie">brt:functie</a>
    /// </summary>
    let functie = _prefixId.prefix "functie"
    /// <summary>
    ///   <para>rdfs:label : fysiekVoorkomen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#fysiekVoorkomen">brt:fysiekVoorkomen</a>
    /// </summary>
    let fysiekVoorkomen = _prefixId.prefix "fysiekVoorkomen"
    /// <summary>
    ///   <para>rdfs:label : gebruiksdoel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#gebruiksdoel">brt:gebruiksdoel</a>
    /// </summary>
    let gebruiksdoel = _prefixId.prefix "gebruiksdoel"
    /// <summary>
    ///   <para>rdfs:label : geometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#geometrie">brt:geometrie</a>
    /// </summary>
    let geometrie = _prefixId.prefix "geometrie"
    /// <summary>
    ///   <para>rdfs:label : geometrieVlak^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#geometrieVlak">brt:geometrieVlak</a>
    /// </summary>
    let geometrieVlak = _prefixId.prefix "geometrieVlak"
    /// <summary>
    ///   <para>rdfs:label : gescheidenRijbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#gescheidenRijbaan">brt:gescheidenRijbaan</a>
    /// </summary>
    let gescheidenRijbaan = _prefixId.prefix "gescheidenRijbaan"
    /// <summary>
    ///   <para>rdfs:label : getijdeinvloed^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#getijdeinvloed">brt:getijdeinvloed</a>
    /// </summary>
    let getijdeinvloed = _prefixId.prefix "getijdeinvloed"
    /// <summary>
    ///   <para>rdfs:label : hartGeometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hartGeometrie">brt:hartGeometrie</a>
    /// </summary>
    let hartGeometrie = _prefixId.prefix "hartGeometrie"
    /// <summary>
    ///   <para>rdfs:label : hogeZijdeTaludGeometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hogeZijdeTaludGeometrie">brt:hogeZijdeTaludGeometrie</a>
    /// </summary>
    let hogeZijdeTaludGeometrie = _prefixId.prefix "hogeZijdeTaludGeometrie"
    /// <summary>
    ///   <para>rdfs:label : hoofdGeometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoofdGeometrie">brt:hoofdGeometrie</a>
    /// </summary>
    let hoofdGeometrie = _prefixId.prefix "hoofdGeometrie"
    /// <summary>
    ///   <para>rdfs:label : hoofdafwatering^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoofdafwatering">brt:hoofdafwatering</a>
    /// </summary>
    let hoofdafwatering = _prefixId.prefix "hoofdafwatering"
    /// <summary>
    ///   <para>rdfs:label : hoofdverkeersgebruik^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoofdverkeersgebruik">brt:hoofdverkeersgebruik</a>
    /// </summary>
    let hoofdverkeersgebruik = _prefixId.prefix "hoofdverkeersgebruik"
    /// <summary>
    ///   <para>rdfs:label : hoogte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoogte">brt:hoogte</a>
    /// </summary>
    let hoogte = _prefixId.prefix "hoogte"
    /// <summary>
    ///   <para>rdfs:label : hoogteklasse^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoogteklasse">brt:hoogteklasse</a>
    /// </summary>
    let hoogteklasse = _prefixId.prefix "hoogteklasse"
    /// <summary>
    ///   <para>rdfs:label : hoogteniveau^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#hoogteniveau">brt:hoogteniveau</a>
    /// </summary>
    let hoogteniveau = _prefixId.prefix "hoogteniveau"
    /// <summary>
    ///   <para>rdfs:label : identificatie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#identificatie">brt:identificatie</a>
    /// </summary>
    let identificatie = _prefixId.prefix "identificatie"
    /// <summary>
    ///   <para>rdfs:label : isBAGnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#isBAGnaam">brt:isBAGnaam</a>
    /// </summary>
    let isBAGnaam = _prefixId.prefix "isBAGnaam"
    /// <summary>
    ///   <para>rdfs:label : isBAGwoonplaats^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#isBAGwoonplaats">brt:isBAGwoonplaats</a>
    /// </summary>
    let isBAGwoonplaats = _prefixId.prefix "isBAGwoonplaats"
    /// <summary>
    ///   <para>rdfs:label : knooppuntnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#knooppuntnaam">brt:knooppuntnaam</a>
    /// </summary>
    let knooppuntnaam = _prefixId.prefix "knooppuntnaam"
    /// <summary>
    ///   <para>rdfs:label : lageZijdeTaludGeometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#lageZijdeTaludGeometrie">brt:lageZijdeTaludGeometrie</a>
    /// </summary>
    let lageZijdeTaludGeometrie = _prefixId.prefix "lageZijdeTaludGeometrie"
    /// <summary>
    ///   <para>rdfs:label : lijnGeometrie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#lijnGeometrie">brt:lijnGeometrie</a>
    /// </summary>
    let lijnGeometrie = _prefixId.prefix "lijnGeometrie"
    /// <summary>
    ///   <para>rdfs:label : mutatieType^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#mutatieType">brt:mutatieType</a>
    /// </summary>
    let mutatieType = _prefixId.prefix "mutatieType"
    /// <summary>
    ///   <para>rdfs:label : nWegnummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#nWegnummer">brt:nWegnummer</a>
    /// </summary>
    let nWegnummer = _prefixId.prefix "nWegnummer"
    /// <summary>
    ///   <para>rdfs:label : naam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#naam">brt:naam</a>
    /// </summary>
    let naam = _prefixId.prefix "naam"
    /// <summary>
    ///   <para>rdfs:label : naamFries^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#naamFries">brt:naamFries</a>
    /// </summary>
    let naamFries = _prefixId.prefix "naamFries"
    /// <summary>
    ///   <para>rdfs:label : naamNL^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#naamNL">brt:naamNL</a>
    /// </summary>
    let naamNL = _prefixId.prefix "naamNL"
    /// <summary>
    ///   <para>rdfs:label : naamOfficieel^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#naamOfficieel">brt:naamOfficieel</a>
    /// </summary>
    let naamOfficieel = _prefixId.prefix "naamOfficieel"
    /// <summary>
    ///   <para>rdfs:label : nummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#nummer">brt:nummer</a>
    /// </summary>
    let nummer = _prefixId.prefix "nummer"
    /// <summary>
    ///   <para>rdfs:label : objectBeginTijd^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#objectBeginTijd">brt:objectBeginTijd</a>
    /// </summary>
    let objectBeginTijd = _prefixId.prefix "objectBeginTijd"
    /// <summary>
    ///   <para>rdfs:label : objectEindTijd^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#objectEindTijd">brt:objectEindTijd</a>
    /// </summary>
    let objectEindTijd = _prefixId.prefix "objectEindTijd"
    /// <summary>
    ///   <para>rdfs:label : referentievlak^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#referentievlak">brt:referentievlak</a>
    /// </summary>
    let referentievlak = _prefixId.prefix "referentievlak"
    /// <summary>
    ///   <para>rdfs:label : sWegnummer^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#sWegnummer">brt:sWegnummer</a>
    /// </summary>
    let sWegnummer = _prefixId.prefix "sWegnummer"
    /// <summary>
    ///   <para>rdfs:label : sluisnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#sluisnaam">brt:sluisnaam</a>
    /// </summary>
    let sluisnaam = _prefixId.prefix "sluisnaam"
    /// <summary>
    ///   <para>rdfs:label : soortnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#soortnaam">brt:soortnaam</a>
    /// </summary>
    let soortnaam = _prefixId.prefix "soortnaam"
    /// <summary>
    ///   <para>rdfs:label : spoorbreedte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#spoorbreedte">brt:spoorbreedte</a>
    /// </summary>
    let spoorbreedte = _prefixId.prefix "spoorbreedte"
    /// <summary>
    ///   <para>rdfs:label : status^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#status">brt:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : tdnCode^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#tdnCode">brt:tdnCode</a>
    /// </summary>
    let tdnCode = _prefixId.prefix "tdnCode"
    /// <summary>
    ///   <para>rdfs:label : tijdstipRegistratie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#tijdstipRegistratie">brt:tijdstipRegistratie</a>
    /// </summary>
    let tijdstipRegistratie = _prefixId.prefix "tijdstipRegistratie"
    /// <summary>
    ///   <para>rdfs:label : tunnelnaam^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#tunnelnaam">brt:tunnelnaam</a>
    /// </summary>
    let tunnelnaam = _prefixId.prefix "tunnelnaam"
    /// <summary>
    ///   <para>rdfs:label : typeFunctioneelGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeFunctioneelGebied">brt:typeFunctioneelGebied</a>
    /// </summary>
    let typeFunctioneelGebied = _prefixId.prefix "typeFunctioneelGebied"
    /// <summary>
    ///   <para>rdfs:label : typeGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeGebied">brt:typeGebied</a>
    /// </summary>
    let typeGebied = _prefixId.prefix "typeGebied"
    /// <summary>
    ///   <para>rdfs:label : typeGebouw^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeGebouw">brt:typeGebouw</a>
    /// </summary>
    let typeGebouw = _prefixId.prefix "typeGebouw"
    /// <summary>
    ///   <para>rdfs:label : typeGeografischGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeGeografischGebied">brt:typeGeografischGebied</a>
    /// </summary>
    let typeGeografischGebied = _prefixId.prefix "typeGeografischGebied"
    /// <summary>
    ///   <para>rdfs:label : typeHoogte^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeHoogte">brt:typeHoogte</a>
    /// </summary>
    let typeHoogte = _prefixId.prefix "typeHoogte"
    /// <summary>
    ///   <para>rdfs:label : typeInfrastructuur^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeInfrastructuur">brt:typeInfrastructuur</a>
    /// </summary>
    let typeInfrastructuur = _prefixId.prefix "typeInfrastructuur"
    /// <summary>
    ///   <para>rdfs:label : typeInrichtingselement^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeInrichtingselement">brt:typeInrichtingselement</a>
    /// </summary>
    let typeInrichtingselement = _prefixId.prefix "typeInrichtingselement"
    /// <summary>
    ///   <para>rdfs:label : typeLandgebruik^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeLandgebruik">brt:typeLandgebruik</a>
    /// </summary>
    let typeLandgebruik = _prefixId.prefix "typeLandgebruik"
    /// <summary>
    ///   <para>rdfs:label : typeObject^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeObject">brt:typeObject</a>
    /// </summary>
    let typeObject = _prefixId.prefix "typeObject"
    /// <summary>
    ///   <para>rdfs:label : typeRegistratiefGebied^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeRegistratiefGebied">brt:typeRegistratiefGebied</a>
    /// </summary>
    let typeRegistratiefGebied = _prefixId.prefix "typeRegistratiefGebied"
    /// <summary>
    ///   <para>rdfs:label : typeRelief^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeRelief">brt:typeRelief</a>
    /// </summary>
    let typeRelief = _prefixId.prefix "typeRelief"
    /// <summary>
    ///   <para>rdfs:label : typeSpoorbaan^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeSpoorbaan">brt:typeSpoorbaan</a>
    /// </summary>
    let typeSpoorbaan = _prefixId.prefix "typeSpoorbaan"
    /// <summary>
    ///   <para>rdfs:label : typeWater^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeWater">brt:typeWater</a>
    /// </summary>
    let typeWater = _prefixId.prefix "typeWater"
    /// <summary>
    ///   <para>rdfs:label : typeWeg^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#typeWeg">brt:typeWeg</a>
    /// </summary>
    let typeWeg = _prefixId.prefix "typeWeg"
    /// <summary>
    ///   <para>rdfs:label : vaarwegklasse^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#vaarwegklasse">brt:vaarwegklasse</a>
    /// </summary>
    let vaarwegklasse = _prefixId.prefix "vaarwegklasse"
    /// <summary>
    ///   <para>rdfs:label : verhardingsbreedteklasse^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#verhardingsbreedteklasse">brt:verhardingsbreedteklasse</a>
    /// </summary>
    let verhardingsbreedteklasse = _prefixId.prefix "verhardingsbreedteklasse"
    /// <summary>
    ///   <para>rdfs:label : verhardingstype^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#verhardingstype">brt:verhardingstype</a>
    /// </summary>
    let verhardingstype = _prefixId.prefix "verhardingstype"
    /// <summary>
    ///   <para>rdfs:label : vervoerfunctie^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#vervoerfunctie">brt:vervoerfunctie</a>
    /// </summary>
    let vervoerfunctie = _prefixId.prefix "vervoerfunctie"
    /// <summary>
    ///   <para>rdfs:label : visualisatieCode^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#visualisatieCode">brt:visualisatieCode</a>
    /// </summary>
    let visualisatieCode = _prefixId.prefix "visualisatieCode"
    /// <summary>
    ///   <para>rdfs:label : voorkomen^^xsd:string</para>
    ///   <a href="http://brt.basisregistraties.overheid.nl/def/top10nl#voorkomen">brt:voorkomen</a>
    /// </summary>
    let voorkomen = _prefixId.prefix "voorkomen"
