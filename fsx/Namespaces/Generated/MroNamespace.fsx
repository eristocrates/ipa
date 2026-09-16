#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mro =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.commoncoreontologies.org/mro/" "mro"

    /// <summary>
    ///   <para>rdfs:label : has realization</para>
    ///   <para>dc11:identifier : 206-BFO^^xsd:string</para>
    ///   <para>skos:altLabel : realized in</para>
    ///   <para>skos:definition : b has realization c =Def c realizes b</para>
    ///   <para>skos:example : As for realizes</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000054">mro:BFO_0000054</a>
    /// </summary>
    let BFO_0000054 = _prefixId.prefix "BFO_0000054"
    /// <summary>
    ///   <para>rdfs:label : realizes</para>
    ///   <para>dc11:identifier : 059-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) realizes is a relation between a process b and realizable entity c such that c inheres in some d &amp; for all t, if b has participant d then c exists &amp; the type instantiated by b is correlated with the type instantiated by c</para>
    ///   <para>skos:example : A balding process realizes a disposition to go bald; a studying process realizes a student role; a process of pumping blood realizes the pumping function of a heart</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000055">mro:BFO_0000055</a>
    /// </summary>
    let BFO_0000055 = _prefixId.prefix "BFO_0000055"
    /// <summary>
    ///   <para>rdfs:label : participates in</para>
    ///   <para>dc11:identifier : 250-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) participates in holds between some b that is either a specifically dependent continuant or generically dependent continuant or independent continuant that is not a spatial region &amp; some process p such that b participates in p some way</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000056">mro:BFO_0000056</a>
    /// </summary>
    let BFO_0000056 = _prefixId.prefix "BFO_0000056"
    /// <summary>
    ///   <para>rdfs:label : has participant</para>
    ///   <para>dc11:identifier : 248-BFO^^xsd:string</para>
    ///   <para>skos:definition : p has participant c =Def c participates in p</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000057">mro:BFO_0000057</a>
    /// </summary>
    let BFO_0000057 = _prefixId.prefix "BFO_0000057"
    /// <summary>
    ///   <para>rdfs:label : is concretized by</para>
    ///   <para>dc11:identifier : 258-BFO^^xsd:string</para>
    ///   <para>skos:definition : c is concretized by b =Def b concretizes c</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000058">mro:BFO_0000058</a>
    /// </summary>
    let BFO_0000058 = _prefixId.prefix "BFO_0000058"
    /// <summary>
    ///   <para>rdfs:label : concretizes</para>
    ///   <para>dc11:identifier : 256-BFO^^xsd:string</para>
    ///   <para>skos:definition : b concretizes c =Def b is a process or a specifically dependent continuant &amp; c is a generically dependent continuant &amp; there is some time t such that c is the pattern or content which b shares at t with actual or potential copies</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000059">mro:BFO_0000059</a>
    /// </summary>
    let BFO_0000059 = _prefixId.prefix "BFO_0000059"
    /// <summary>
    ///   <para>rdfs:label : preceded by</para>
    ///   <para>dc11:identifier : 213-BFO^^xsd:string</para>
    ///   <para>skos:definition : b preceded by c =Def b precedes c</para>
    ///   <para>skos:example : The temporal region occupied by the second half of the match is preceded by the temporal region occupied by the first half of the match</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000062">mro:BFO_0000062</a>
    /// </summary>
    let BFO_0000062 = _prefixId.prefix "BFO_0000062"
    /// <summary>
    ///   <para>rdfs:label : precedes</para>
    ///   <para>dc11:identifier : 270-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) precedes is a relation between occurrents o, o' such that if t is the temporal extent of o &amp; t' is the temporal extent of o' then either the last instant of o is before the first instant of o' or the last instant of o is the first instant of o' &amp; neither o nor o' are temporal instants</para>
    ///   <para>skos:example : The temporal region occupied by Mary's birth precedes the temporal region occupied by Mary's death.</para>
    ///   <para>skos:scopeNote : Each temporal region is its own temporal extent. The temporal extent of a spatiotemporal region is the temporal region it temporally projects onto. The temporal extent of a process or process boundary that occupies temporal region t is t.^^xsd:stringskos:scopeNote : Precedes defines a strict partial order on occurrents.^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000063">mro:BFO_0000063</a>
    /// </summary>
    let BFO_0000063 = _prefixId.prefix "BFO_0000063"
    /// <summary>
    ///   <para>rdfs:label : occurs in</para>
    ///   <para>dc11:identifier : 143-BFO^^xsd:string</para>
    ///   <para>skos:definition : b occurs in c =Def b is a process or a process boundary &amp; c is a material entity or site &amp; there exists a spatiotemporal region r &amp; b occupies spatiotemporal region r &amp; for all time t, if b exists at t then c exists at t &amp; there exist spatial regions s and s' where b spatially projects onto s at t &amp; c occupies spatial region s' at t &amp; s is a continuant part of s' at t</para>
    ///   <para>skos:example : A process of digestion occurs in the interior of an organism; a process of loading artillery rounds into a tank cannon occurs in the interior of the tank</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000066">mro:BFO_0000066</a>
    /// </summary>
    let BFO_0000066 = _prefixId.prefix "BFO_0000066"
    /// <summary>
    ///   <para>rdfs:label : generically depends on</para>
    ///   <para>dc11:identifier : 252-BFO^^xsd:string</para>
    ///   <para>skos:altLabel : g-depends on</para>
    ///   <para>skos:definition : b generically depends on c =Def b is a generically dependent continuant &amp; c is an independent continuant that is not a spatial region &amp; at some time t there inheres in c a specifically dependent continuant which concretizes b at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000084">mro:BFO_0000084</a>
    /// </summary>
    let BFO_0000084 = _prefixId.prefix "BFO_0000084"
    /// <summary>
    ///   <para>rdfs:label : is carrier of</para>
    ///   <para>dc11:identifier : 254-BFO^^xsd:string</para>
    ///   <para>skos:definition : b is carrier of c =Def there is some time t such that c generically depends on b at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000101">mro:BFO_0000101</a>
    /// </summary>
    let BFO_0000101 = _prefixId.prefix "BFO_0000101"
    /// <summary>
    ///   <para>rdfs:label : exists at</para>
    ///   <para>dc11:identifier : 118-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) exists at is a relation between a particular and some temporal region at which the particular exists</para>
    ///   <para>skos:example : First World War exists at 1914-1916; Mexico exists at January 1, 2000</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000108">mro:BFO_0000108</a>
    /// </summary>
    let BFO_0000108 = _prefixId.prefix "BFO_0000108"
    /// <summary>
    ///   <para>rdfs:label : has member part</para>
    ///   <para>dc11:identifier : 230-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has member part c =Def c member part of b</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000115">mro:BFO_0000115</a>
    /// </summary>
    let BFO_0000115 = _prefixId.prefix "BFO_0000115"
    /// <summary>
    ///   <para>rdfs:label : has occurrent part</para>
    ///   <para>dc11:identifier : 202-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has occurrent part c =Def c occurrent part of b</para>
    ///   <para>skos:example : Mary's life has occurrent part Mary's 5th birthday</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000117">mro:BFO_0000117</a>
    /// </summary>
    let BFO_0000117 = _prefixId.prefix "BFO_0000117"
    /// <summary>
    ///   <para>rdfs:label : has temporal part</para>
    ///   <para>dc11:identifier : 211-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has temporal part c =Def c temporal part of b</para>
    ///   <para>skos:example : Your life has temporal part the first year of your life</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000121">mro:BFO_0000121</a>
    /// </summary>
    let BFO_0000121 = _prefixId.prefix "BFO_0000121"
    /// <summary>
    ///   <para>rdfs:label : location of</para>
    ///   <para>dc11:identifier : 236-BFO^^xsd:string</para>
    ///   <para>skos:definition : b location of c =Def c located in b</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000124">mro:BFO_0000124</a>
    /// </summary>
    let BFO_0000124 = _prefixId.prefix "BFO_0000124"
    /// <summary>
    ///   <para>rdfs:label : material basis of</para>
    ///   <para>dc11:identifier : 244-BFO^^xsd:string</para>
    ///   <para>skos:definition : b material basis of c =Def c has material basis b</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000127">mro:BFO_0000127</a>
    /// </summary>
    let BFO_0000127 = _prefixId.prefix "BFO_0000127"
    /// <summary>
    ///   <para>rdfs:label : member part of</para>
    ///   <para>dc11:identifier : 228-BFO^^xsd:string</para>
    ///   <para>skos:definition : b member part of c =Def b is an object &amp; c is a material entity &amp; there is some time t such that b continuant part of c at t &amp; there is a mutually exhaustive and pairwise disjoint partition of c into objects x1, ..., xn (for some n ≠ 1) with b = xi (for some 1 &lt;= i &lt;= n)</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000129">mro:BFO_0000129</a>
    /// </summary>
    let BFO_0000129 = _prefixId.prefix "BFO_0000129"
    /// <summary>
    ///   <para>rdfs:label : occurrent part of</para>
    ///   <para>dc11:identifier : 003-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) occurrent part of is a relation between occurrents b and c when b is part of c</para>
    ///   <para>skos:example : Mary's 5th birthday is an occurrent part of Mary's life; the first set of the tennis match is an occurrent part of the tennis match</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000132">mro:BFO_0000132</a>
    /// </summary>
    let BFO_0000132 = _prefixId.prefix "BFO_0000132"
    /// <summary>
    ///   <para>rdfs:label : temporal part of</para>
    ///   <para>dc11:identifier : 078-BFO^^xsd:string</para>
    ///   <para>skos:definition : b temporal part of c =Def b occurrent part of c &amp; (b and c are temporal regions) or (b and c are spatiotemporal regions &amp; b temporally projects onto an occurrent part of the temporal region that c temporally projects onto) or (b and c are processes or process boundaries &amp; b occupies a temporal region that is an occurrent part of the temporal region that c occupies)</para>
    ///   <para>skos:example : Your heart beating from 4pm to 5pm today is a temporal part of the process of your heart beating; the 4th year of your life is a temporal part of your life, as is the process boundary which separates the 3rd and 4th years of your life; the first quarter of a game of football is a temporal part of the whole game</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000139">mro:BFO_0000139</a>
    /// </summary>
    let BFO_0000139 = _prefixId.prefix "BFO_0000139"
    /// <summary>
    ///   <para>rdfs:label : temporally projects onto</para>
    ///   <para>dc11:identifier : 080-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) temporally projects onto is a relation between a spatiotemporal region s and some temporal region which is the temporal extent of s</para>
    ///   <para>skos:example : The world line of a particle temporally projects onto the temporal region extending from the beginning to the end of the existence of the particle</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000153">mro:BFO_0000153</a>
    /// </summary>
    let BFO_0000153 = _prefixId.prefix "BFO_0000153"
    /// <summary>
    ///   <para>rdfs:label : located in</para>
    ///   <para>dc11:identifier : 234-BFO^^xsd:string</para>
    ///   <para>skos:definition : b located in c =Def b is an independent continuant &amp; c is an independent &amp; neither is a spatial region &amp; there is some time t such that the spatial region which b occupies at t is continuant part of the spatial region which c occupies at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000171">mro:BFO_0000171</a>
    /// </summary>
    let BFO_0000171 = _prefixId.prefix "BFO_0000171"
    /// <summary>
    ///   <para>rdfs:label : continuant part of</para>
    ///   <para>dc11:identifier : 221-BFO^^xsd:string</para>
    ///   <para>skos:definition : b continuant part of c =Def b and c are continuants &amp; there is some time t such that b and c exist at t &amp; b continuant part of c at t</para>
    ///   <para>skos:example : Milk teeth continuant part of human; surgically removed tumour continuant part of organism</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000176">mro:BFO_0000176</a>
    /// </summary>
    let BFO_0000176 = _prefixId.prefix "BFO_0000176"
    /// <summary>
    ///   <para>rdfs:label : has continuant part</para>
    ///   <para>dc11:identifier : 271-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has continuant part c =Def c continuant part of b</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000178">mro:BFO_0000178</a>
    /// </summary>
    let BFO_0000178 = _prefixId.prefix "BFO_0000178"
    /// <summary>
    ///   <para>rdfs:label : environs</para>
    ///   <para>dc11:identifier : 267-BFO^^xsd:string</para>
    ///   <para>skos:altLabel : contains process</para>
    ///   <para>skos:definition : b environs c =Def c occurs in b</para>
    ///   <para>skos:example : Mouth environs process of mastication; city environs traffic</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000183">mro:BFO_0000183</a>
    /// </summary>
    let BFO_0000183 = _prefixId.prefix "BFO_0000183"
    /// <summary>
    ///   <para>rdfs:label : history of</para>
    ///   <para>dc11:identifier : 144-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) history of is a relation between history b and material entity c such that b is the unique history of c</para>
    ///   <para>skos:example : This life is the history of this organism</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000184">mro:BFO_0000184</a>
    /// </summary>
    let BFO_0000184 = _prefixId.prefix "BFO_0000184"
    /// <summary>
    ///   <para>rdfs:label : has history</para>
    ///   <para>dc11:identifier : 145-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has history c =Def c history of b</para>
    ///   <para>skos:example : This organism has history this life</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000185">mro:BFO_0000185</a>
    /// </summary>
    let BFO_0000185 = _prefixId.prefix "BFO_0000185"
    /// <summary>
    ///   <para>rdfs:label : specifically depended on by</para>
    ///   <para>dc11:identifier : 260-BFO^^xsd:string</para>
    ///   <para>skos:altLabel : s-depended on by</para>
    ///   <para>skos:definition : b specifically depended on by c =Def c specifically depends on b</para>
    ///   <para>skos:example : Coloured object specifically depended on by colour</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000194">mro:BFO_0000194</a>
    /// </summary>
    let BFO_0000194 = _prefixId.prefix "BFO_0000194"
    /// <summary>
    ///   <para>rdfs:label : specifically depends on</para>
    ///   <para>dc11:identifier : 012-BFO^^xsd:string</para>
    ///   <para>skos:altLabel : s-depends on</para>
    ///   <para>skos:definition : (Elucidation) specifically depends on is a relation between a specifically dependent continuant b and specifically dependent continuant or independent continuant that is not a spatial region c such that b and c share no parts in common &amp; b is of a nature such that at all times t it cannot exist unless c exists &amp; b is not a boundary of c</para>
    ///   <para>skos:example : A shape specifically depends on the shaped object; hue, saturation and brightness of a colour sample specifically depends on each other</para>
    ///   <para>skos:scopeNote : The analogue of specifically depends on for occurrents is has participant.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000195">mro:BFO_0000195</a>
    /// </summary>
    let BFO_0000195 = _prefixId.prefix "BFO_0000195"
    /// <summary>
    ///   <para>rdfs:label : bearer of</para>
    ///   <para>dc11:identifier : 053-BFO^^xsd:string</para>
    ///   <para>skos:definition : b bearer of c =Def c inheres in b</para>
    ///   <para>skos:example : A patch of ink is the bearer of a colour quality; an organism is the bearer of a temperature quality</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000196">mro:BFO_0000196</a>
    /// </summary>
    let BFO_0000196 = _prefixId.prefix "BFO_0000196"
    /// <summary>
    ///   <para>rdfs:label : inheres in</para>
    ///   <para>dc11:identifier : 051-BFO^^xsd:string</para>
    ///   <para>skos:definition : b inheres in c =Def b is a specifically dependent continuant &amp; c is an independent continuant that is not a spatial region &amp; b specifically depends on c</para>
    ///   <para>skos:example : A shape inheres in a shaped object; a mass inheres in a material entity</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000197">mro:BFO_0000197</a>
    /// </summary>
    let BFO_0000197 = _prefixId.prefix "BFO_0000197"
    /// <summary>
    ///   <para>rdfs:label : occupies temporal region</para>
    ///   <para>dc11:identifier : 132-BFO^^xsd:string</para>
    ///   <para>skos:definition : p occupies temporal region t =Def p is a process or process boundary &amp; the spatiotemporal region occupied by p temporally projects onto t</para>
    ///   <para>skos:example : The Second World War occupies the temporal region September 1, 1939 - September 2, 1945</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000199">mro:BFO_0000199</a>
    /// </summary>
    let BFO_0000199 = _prefixId.prefix "BFO_0000199"
    /// <summary>
    ///   <para>rdfs:label : occupies spatiotemporal region</para>
    ///   <para>dc11:identifier : 082-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) occupies spatiotemporal region is a relation between a process or process boundary p and the spatiotemporal region s which is its spatiotemporal extent</para>
    ///   <para>skos:example : A particle emitted by a nuclear reactor occupies the spatiotemporal region which is its trajectory</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000200">mro:BFO_0000200</a>
    /// </summary>
    let BFO_0000200 = _prefixId.prefix "BFO_0000200"
    /// <summary>
    ///   <para>rdfs:label : occupies spatial region</para>
    ///   <para>dc11:identifier : 232-BFO^^xsd:string</para>
    ///   <para>skos:definition : b occupies spatial region r =Def b is an independent continuant that is not a spatial region &amp; r is a spatial region &amp; there is some time t such that every continuant part of b occupies some continuant part of r at t and no continuant part of b occupies any spatial region that is not a continuant part of r at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000210">mro:BFO_0000210</a>
    /// </summary>
    let BFO_0000210 = _prefixId.prefix "BFO_0000210"
    /// <summary>
    ///   <para>rdfs:label : spatially projects onto</para>
    ///   <para>dc11:identifier : 246-BFO^^xsd:string</para>
    ///   <para>skos:definition : (Elucidation) spatially projects onto is a relation between some spatiotemporal region b and spatial region c such that at some time t, c is the spatial extent of b at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000216">mro:BFO_0000216</a>
    /// </summary>
    let BFO_0000216 = _prefixId.prefix "BFO_0000216"
    /// <summary>
    ///   <para>rdfs:label : has material basis</para>
    ///   <para>dc11:identifier : 242-BFO^^xsd:string</para>
    ///   <para>skos:definition : b has material basis c =Def b is a disposition &amp; c is a material entity &amp; there is some d bearer of b &amp; there is some time t such that c is a continuant part of d at t &amp; d has disposition b because c is a continuant part of d at t</para>
    ///   <para>skos:scopeNote : Users that require more sophisticated representations of time are encouraged to import a temporal extension of BFO-Core provided by the BFO development team. See documentation for guidance: &lt;https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/profiles/temporal%20extensions&gt;</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000218">mro:BFO_0000218</a>
    /// </summary>
    let BFO_0000218 = _prefixId.prefix "BFO_0000218"
    /// <summary>
    ///   <para>rdfs:label : first instant of</para>
    ///   <para>dc11:identifier : 268-BFO^^xsd:string</para>
    ///   <para>skos:definition : t first instant of t' =Def t is a temporal instant &amp; t' is a temporal region t' &amp; t precedes all temporal parts of t' other than t</para>
    ///   <para>skos:example : An hour starting at midnight yesterday has first instant midnight yesterday</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000221">mro:BFO_0000221</a>
    /// </summary>
    let BFO_0000221 = _prefixId.prefix "BFO_0000221"
    /// <summary>
    ///   <para>rdfs:label : has first instant</para>
    ///   <para>dc11:identifier : 261-BFO^^xsd:string</para>
    ///   <para>skos:definition : t has first instant t' =Def t' first instant of t</para>
    ///   <para>skos:example : The first hour of a year has first instant midnight on December 31</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000222">mro:BFO_0000222</a>
    /// </summary>
    let BFO_0000222 = _prefixId.prefix "BFO_0000222"
    /// <summary>
    ///   <para>rdfs:label : last instant of</para>
    ///   <para>dc11:identifier : 269-BFO^^xsd:string</para>
    ///   <para>skos:definition : t last instant of t' =Def t is a temporal instant &amp; t' is a temporal region &amp; all temporal parts of t' other than t precede t</para>
    ///   <para>skos:example : Last midnight is the last instant of yesterday</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000223">mro:BFO_0000223</a>
    /// </summary>
    let BFO_0000223 = _prefixId.prefix "BFO_0000223"
    /// <summary>
    ///   <para>rdfs:label : has last instant</para>
    ///   <para>dc11:identifier : 215-BFO^^xsd:string</para>
    ///   <para>skos:definition : t has last instant t' =Def t' last instant of t</para>
    ///   <para>skos:example : The last hour of a year has last instant midnight December 31</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/BFO_0000224">mro:BFO_0000224</a>
    /// </summary>
    let BFO_0000224 = _prefixId.prefix "BFO_0000224"
    /// <summary>
    ///   <para>rdfs:label : Modal Object Property</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/mro00000001">mro:mro00000001</a>
    /// </summary>
    let mro00000001 = _prefixId.prefix "mro00000001"
    /// <summary>
    ///   <para>rdfs:label : has altitude value</para>
    ///   <para>skos:scopeNote : Altitude values typically use kilometers as the Unit of Measurement.skos:scopeNote : This data property can be used along with has_latitude_value and has_longitude_value to connect three-dimensional spatial data to a single Information Bearing Entity to specify the location of an entity in a Geospatial Region.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001763">mro:ont00001763</a>
    /// </summary>
    let ont00001763 = _prefixId.prefix "ont00001763"
    /// <summary>
    ///   <para>rdfs:label : has longitude value</para>
    ///   <para>skos:definition : A Data Property that has as its range the longitude value from some Geospatial Location coordinates set expressed in decimal degrees.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001764">mro:ont00001764</a>
    /// </summary>
    let ont00001764 = _prefixId.prefix "ont00001764"
    /// <summary>
    ///   <para>rdfs:label : has text value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of a string literal. Modelers should instead use a more specific datatype property whose meaning explains what the text records, names, describes, encodes, or otherwise represents.</para>
    ///   <para>skos:definition : A data property that has as its range a string value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001765">mro:ont00001765</a>
    /// </summary>
    let ont00001765 = _prefixId.prefix "ont00001765"
    /// <summary>
    ///   <para>rdfs:label : has latitude value</para>
    ///   <para>skos:definition : A Data Property that has as its range the latitude value from some Geospatial Location coordinates set expressed in decimal degrees.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001766">mro:ont00001766</a>
    /// </summary>
    let ont00001766 = _prefixId.prefix "ont00001766"
    /// <summary>
    ///   <para>rdfs:label : has datetime value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of an xsd:dateTime typed literal. Modelers should instead use a more specific datatype property whose meaning explains what date-time value is being recorded, specified, observed, issued, created, modified, or otherwise represented.</para>
    ///   <para>skos:definition : A data property that has as its value a datetime value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001767">mro:ont00001767</a>
    /// </summary>
    let ont00001767 = _prefixId.prefix "ont00001767"
    /// <summary>
    ///   <para>rdfs:label : has URI value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of an xsd:anyURI typed literal. Modelers should instead use a more specific datatype property whose meaning explains what the URI identifies, locates, references, resolves to, or otherwise represents.</para>
    ///   <para>skos:definition : A data property that has as its range a URI value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001768">mro:ont00001768</a>
    /// </summary>
    let ont00001768 = _prefixId.prefix "ont00001768"
    /// <summary>
    ///   <para>rdfs:label : has decimal value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of an xsd:decimal typed literal. Modelers should instead use a more specific datatype property whose meaning explains what the decimal value measures, quantifies, estimates, rates, or otherwise represents.</para>
    ///   <para>skos:definition : A data property that has as its range a decimal value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001769">mro:ont00001769</a>
    /// </summary>
    let ont00001769 = _prefixId.prefix "ont00001769"
    /// <summary>
    ///   <para>rdfs:label : has double value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of an xsd:double typed literal. Modelers should instead use a more specific datatype property whose meaning explains what the double value measures, quantifies, estimates, rates, or otherwise represents.</para>
    ///   <para>skos:definition : A data property that has as its range a double value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001770">mro:ont00001770</a>
    /// </summary>
    let ont00001770 = _prefixId.prefix "ont00001770"
    /// <summary>
    ///   <para>rdfs:label : has date value</para>
    ///   <para>skos:definition : A data property that has as its range a date value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001771">mro:ont00001771</a>
    /// </summary>
    let ont00001771 = _prefixId.prefix "ont00001771"
    /// <summary>
    ///   <para>rdfs:label : has boolean value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated without direct replacement because the property is overly generic and does not add semantic content beyond the use of an xsd:boolean typed literal. Modelers should instead use a more specific datatype property whose meaning explains what the boolean value affirms, denies, indicates, or otherwise represents.</para>
    ///   <para>skos:definition : A data property that has as its range a boolean value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001772">mro:ont00001772</a>
    /// </summary>
    let ont00001772 = _prefixId.prefix "ont00001772"
    /// <summary>
    ///   <para>rdfs:label : has integer value</para>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>skos:changeNote : Deprecated because the property does not add semantic content beyond the use of an xsd:integer typed literal. Use a domain-specific datatype property with range xsd:integer where an integer-valued measurement, count, ordinal, identifier component, or other value is intended.</para>
    ///   <para>skos:definition : A data property that has as its range an integer value.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001773">mro:ont00001773</a>
    /// </summary>
    let ont00001773 = _prefixId.prefix "ont00001773"
    /// <summary>
    ///   <para>rdfs:label : has brother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001774">mro:ont00001774</a>
    /// </summary>
    let ont00001774 = _prefixId.prefix "ont00001774"
    /// <summary>
    ///   <para>rdfs:label : is successor of</para>
    ///   <para>skos:definition : x is successor of y =Def y is predecessor of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001775">mro:ont00001775</a>
    /// </summary>
    let ont00001775 = _prefixId.prefix "ont00001775"
    /// <summary>
    ///   <para>rdfs:label : has grandfather</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001776">mro:ont00001776</a>
    /// </summary>
    let ont00001776 = _prefixId.prefix "ont00001776"
    /// <summary>
    ///   <para>rdfs:label : has process part</para>
    ///   <para>skos:definition : x has process part y =Def y is part of process x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001777">mro:ont00001777</a>
    /// </summary>
    let ont00001777 = _prefixId.prefix "ont00001777"
    /// <summary>
    ///   <para>rdfs:label : has object</para>
    ///   <para>skos:definition : x has object y =Def y is object of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001778">mro:ont00001778</a>
    /// </summary>
    let ont00001778 = _prefixId.prefix "ont00001778"
    /// <summary>
    ///   <para>rdfs:label : has inside instant</para>
    ///   <para>skos:definition : x has_inside_instant y iff x is an instance of One Dimensional Temporal Region and y is an instance of Temporal Instant and y is_inside_instant_of x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001779">mro:ont00001779</a>
    /// </summary>
    let ont00001779 = _prefixId.prefix "ont00001779"
    /// <summary>
    ///   <para>rdfs:label : has mother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001780">mro:ont00001780</a>
    /// </summary>
    let ont00001780 = _prefixId.prefix "ont00001780"
    /// <summary>
    ///   <para>rdfs:label : has step sister</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001781">mro:ont00001781</a>
    /// </summary>
    let ont00001781 = _prefixId.prefix "ont00001781"
    /// <summary>
    ///   <para>rdfs:label : has all members located in</para>
    ///   <para>skos:definition : x has all members located in y iff x is an instance of Object Aggregate and y is an instance of independent continuant but not a spatial region, and every member of x is located in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001782">mro:ont00001782</a>
    /// </summary>
    let ont00001782 = _prefixId.prefix "ont00001782"
    /// <summary>
    ///   <para>rdfs:label : is granddaughter of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001783">mro:ont00001783</a>
    /// </summary>
    let ont00001783 = _prefixId.prefix "ont00001783"
    /// <summary>
    ///   <para>rdfs:label : has son-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001784">mro:ont00001784</a>
    /// </summary>
    let ont00001784 = _prefixId.prefix "ont00001784"
    /// <summary>
    ///   <para>rdfs:label : has uncle</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001785">mro:ont00001785</a>
    /// </summary>
    let ont00001785 = _prefixId.prefix "ont00001785"
    /// <summary>
    ///   <para>rdfs:label : is mother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001786">mro:ont00001786</a>
    /// </summary>
    let ont00001786 = _prefixId.prefix "ont00001786"
    /// <summary>
    ///   <para>rdfs:label : agent in</para>
    ///   <para>skos:definition : x agent_in y iff y is an instance of Process and x is an instance of Agent, such that x is causally active in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001787">mro:ont00001787</a>
    /// </summary>
    let ont00001787 = _prefixId.prefix "ont00001787"
    /// <summary>
    ///   <para>rdfs:label : has paternal aunt</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001788">mro:ont00001788</a>
    /// </summary>
    let ont00001788 = _prefixId.prefix "ont00001788"
    /// <summary>
    ///   <para>rdfs:label : has aunt</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001789">mro:ont00001789</a>
    /// </summary>
    let ont00001789 = _prefixId.prefix "ont00001789"
    /// <summary>
    ///   <para>rdfs:label : has maternal uncle</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001790">mro:ont00001790</a>
    /// </summary>
    let ont00001790 = _prefixId.prefix "ont00001790"
    /// <summary>
    ///   <para>rdfs:label : coincides with</para>
    ///   <para>skos:definition : x coincides_with y iff x and y are both instances of Immaterial Entity and x is a spatial part of y and y is a spatial part of x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be transitive and symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001791">mro:ont00001791</a>
    /// </summary>
    let ont00001791 = _prefixId.prefix "ont00001791"
    /// <summary>
    ///   <para>rdfs:label : has sister</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001792">mro:ont00001792</a>
    /// </summary>
    let ont00001792 = _prefixId.prefix "ont00001792"
    /// <summary>
    ///   <para>rdfs:label : has half sister</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001793">mro:ont00001793</a>
    /// </summary>
    let ont00001793 = _prefixId.prefix "ont00001793"
    /// <summary>
    ///   <para>rdfs:label : has subsidiary</para>
    ///   <para>skos:definition : x has subsidiary y =Def y is subsidiary of x.</para>
    ///   <para>cco:ont00001754 : http://www.austlii.edu.au/legis/cth/consol_act/ca2001172/s50aa.html^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001794">mro:ont00001794</a>
    /// </summary>
    let ont00001794 = _prefixId.prefix "ont00001794"
    /// <summary>
    ///   <para>rdfs:label : has inside interval</para>
    ///   <para>skos:definition : x has inside interval y =Def y interval during x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001795">mro:ont00001795</a>
    /// </summary>
    let ont00001795 = _prefixId.prefix "ont00001795"
    /// <summary>
    ///   <para>rdfs:label : tangential part of</para>
    ///   <para>skos:definition : x tangential_part_of y iff x and y are both instances of Immaterial Entity and x is a spatial part of y and there exists an instance of Immaterial Entity z such that z externally connects with x and z externally connects with y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be transitive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001796">mro:ont00001796</a>
    /// </summary>
    let ont00001796 = _prefixId.prefix "ont00001796"
    /// <summary>
    ///   <para>rdfs:label : partially overlaps with</para>
    ///   <para>skos:definition : x partially overlaps with y iff x and y are both instances of Immaterial Entity and x overlaps with y and x is not a spatial part of y and y is not a spatial part of x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001797">mro:ont00001797</a>
    /// </summary>
    let ont00001797 = _prefixId.prefix "ont00001797"
    /// <summary>
    ///   <para>rdfs:label : is supervised by</para>
    ///   <para>skos:definition : x is_supervised_by y iff x and y are both instances of Person and y supervises x.</para>
    ///   <para>cco:ont00001754 : http://en.wiktionary.org/wiki/supervise)^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001798">mro:ont00001798</a>
    /// </summary>
    let ont00001798 = _prefixId.prefix "ont00001798"
    /// <summary>
    ///   <para>rdfs:label : role of aggregate</para>
    ///   <para>skos:definition : x role_of_aggregate y iff y is an instance of Object Aggregate and x is an instance of Role, and x inheres_in_aggregate y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001799">mro:ont00001799</a>
    /// </summary>
    let ont00001799 = _prefixId.prefix "ont00001799"
    /// <summary>
    ///   <para>rdfs:label : prohibits</para>
    ///   <para>skos:definition : x prohibits y at t iff: x is an instance of Process Regulation at time t, and y is an instance of Process at time t, and x prescribes that some y must not occur.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001800">mro:ont00001800</a>
    /// </summary>
    let ont00001800 = _prefixId.prefix "ont00001800"
    /// <summary>
    ///   <para>rdfs:label : is subject of</para>
    ///   <para>skos:definition : x is subject of y =Def y is about x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001801">mro:ont00001801</a>
    /// </summary>
    let ont00001801 = _prefixId.prefix "ont00001801"
    /// <summary>
    ///   <para>rdfs:label : has husband</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001802">mro:ont00001802</a>
    /// </summary>
    let ont00001802 = _prefixId.prefix "ont00001802"
    /// <summary>
    ///   <para>rdfs:label : is cause of</para>
    ///   <para>skos:definition : x is_cause_of y iff x and y are instances of Process, and y is a consequence of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001803">mro:ont00001803</a>
    /// </summary>
    let ont00001803 = _prefixId.prefix "ont00001803"
    /// <summary>
    ///   <para>rdfs:label : is spouse of</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001804">mro:ont00001804</a>
    /// </summary>
    let ont00001804 = _prefixId.prefix "ont00001804"
    /// <summary>
    ///   <para>rdfs:label : is disrupted by</para>
    ///   <para>dcterms:created : 2022-12-30T21:32:27-05:00^^xsd:dateTime</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>skos:definition : x is disrupted by y =Def y disrupts x.</para>
    ///   <para>skos:prefLabel : is disrupted by</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001805">mro:ont00001805</a>
    /// </summary>
    let ont00001805 = _prefixId.prefix "ont00001805"
    /// <summary>
    ///   <para>rdfs:label : is first cousin of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001806">mro:ont00001806</a>
    /// </summary>
    let ont00001806 = _prefixId.prefix "ont00001806"
    /// <summary>
    ///   <para>rdfs:label : is required by</para>
    ///   <para>skos:definition : x is required by y =Def y requires x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001807">mro:ont00001807</a>
    /// </summary>
    let ont00001807 = _prefixId.prefix "ont00001807"
    /// <summary>
    ///   <para>rdfs:label : is about</para>
    ///   <para>skos:definition : x is_about y is a primitive relationship between an instance of Information Content Entity x and an instance of Entity y.</para>
    ///   <para>cco:ont00001754 : http://purl.obolibrary.org/obo/IAO_0000136^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001808">mro:ont00001808</a>
    /// </summary>
    let ont00001808 = _prefixId.prefix "ont00001808"
    /// <summary>
    ///   <para>rdfs:label : inheres in aggregate</para>
    ///   <para>skos:definition : x inheres_in_aggregate y iff x is an instance of Specifically Dependent Continuant or Generically Dependent Continuant and y is an instance of Object Aggregate and y aggregate_bearer_of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001809">mro:ont00001809</a>
    /// </summary>
    let ont00001809 = _prefixId.prefix "ont00001809"
    /// <summary>
    ///   <para>rdfs:label : connected with</para>
    ///   <para>skos:definition : x is_connected_with y iff x and y are both instances of Immaterial Entity and there exists an instance of Immaterial Entity z that is part of both x and y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001810">mro:ont00001810</a>
    /// </summary>
    let ont00001810 = _prefixId.prefix "ont00001810"
    /// <summary>
    ///   <para>rdfs:label : is an ordinal measurement of</para>
    ///   <para>skos:definition : x is_an_ordinal_measurement_of y iff x is an instance of Ordinal Measurement Information Content Entity and y is an instance of Entity and y is_measured_by_ordinal x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001811">mro:ont00001811</a>
    /// </summary>
    let ont00001811 = _prefixId.prefix "ont00001811"
    /// <summary>
    ///   <para>rdfs:label : is grandson of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001812">mro:ont00001812</a>
    /// </summary>
    let ont00001812 = _prefixId.prefix "ont00001812"
    /// <summary>
    ///   <para>rdfs:label : uses</para>
    ///   <para>skos:definition : x uses y iff x is an instance of an Agent and y is an instance of a Material Entity, such that both x and y participate in some instance of a Process wherein x attempts to accomplish a goal by manipulating, deploying, or leveraging some attribute of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001813">mro:ont00001813</a>
    /// </summary>
    let ont00001813 = _prefixId.prefix "ont00001813"
    /// <summary>
    ///   <para>rdfs:label : interval finishes</para>
    ///   <para>skos:definition : x interval_finishes y iff x and y are both instances of Temporal Interval and there exist instances of Temporal Instant v, w, and z such that v is the starting instant of x, w is the ending instant of both x and y, z is the starting instant of y, and z is before v.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001814">mro:ont00001814</a>
    /// </summary>
    let ont00001814 = _prefixId.prefix "ont00001814"
    /// <summary>
    ///   <para>rdfs:label : is subsidiary of</para>
    ///   <para>skos:definition : x is_subsidiary_of y iff x and y are both instances of Organization and y controls x by having the capacity to determine the outcome of decisions about the financial and operating policies of x.</para>
    ///   <para>cco:ont00001754 : http://www.austlii.edu.au/legis/cth/consol_act/ca2001172/s50aa.html)^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001815">mro:ont00001815</a>
    /// </summary>
    let ont00001815 = _prefixId.prefix "ont00001815"
    /// <summary>
    ///   <para>rdfs:label : is output of</para>
    ///   <para>skos:definition : x is output of y =Def x participates in y, x is an Independent Continuant (but not a Spatial Region), y is a Process, and the presence of x at the end of y is a necessary condition for the completion of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001816">mro:ont00001816</a>
    /// </summary>
    let ont00001816 = _prefixId.prefix "ont00001816"
    /// <summary>
    ///   <para>rdfs:label : is prohibited by</para>
    ///   <para>skos:definition : x is prohibited by y =Def y prohibits x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001817">mro:ont00001817</a>
    /// </summary>
    let ont00001817 = _prefixId.prefix "ont00001817"
    /// <summary>
    ///   <para>rdfs:label : is in-law of</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001818">mro:ont00001818</a>
    /// </summary>
    let ont00001818 = _prefixId.prefix "ont00001818"
    /// <summary>
    ///   <para>rdfs:label : caused by</para>
    ///   <para>skos:definition : x caused by y =Def y is cause of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001819">mro:ont00001819</a>
    /// </summary>
    let ont00001819 = _prefixId.prefix "ont00001819"
    /// <summary>
    ///   <para>rdfs:label : has granddaughter</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001820">mro:ont00001820</a>
    /// </summary>
    let ont00001820 = _prefixId.prefix "ont00001820"
    /// <summary>
    ///   <para>rdfs:label : interval finished by</para>
    ///   <para>skos:definition : x interval finished by y =Def y interval finishes x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001821">mro:ont00001821</a>
    /// </summary>
    let ont00001821 = _prefixId.prefix "ont00001821"
    /// <summary>
    ///   <para>rdfs:label : interval equals</para>
    ///   <para>skos:definition : x interval_equals y iff x and y are both instances of Temporal Interval and there exist instances of Temporal Instant w and z such that w is the starting instant of both x and y and z is the ending instant of both x and y.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001822">mro:ont00001822</a>
    /// </summary>
    let ont00001822 = _prefixId.prefix "ont00001822"
    /// <summary>
    ///   <para>rdfs:label : has paternal uncle</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001823">mro:ont00001823</a>
    /// </summary>
    let ont00001823 = _prefixId.prefix "ont00001823"
    /// <summary>
    ///   <para>rdfs:label : is excerpted from</para>
    ///   <para>skos:definition : An Information Bearing Entity b1 is excerpted from another Information Bearing Entity B2 iff b1 is part of some Information Bearing Entity B1 that is carrier of some Information Content Entity C1, B2 is carrier of some Information Content Entity C2, C1 is not identical with C2, b1 is carrier of some Information Content Entity c1, b2 is an Information Bearing Entity that is part of B2 and b2 is carrier of c1 (i.e. the same Information Content Entity as borne by b1).</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001824">mro:ont00001824</a>
    /// </summary>
    let ont00001824 = _prefixId.prefix "ont00001824"
    /// <summary>
    ///   <para>rdfs:label : interval overlaps</para>
    ///   <para>skos:definition : x interval overlaps y =Def y interval overlapped by x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001825">mro:ont00001825</a>
    /// </summary>
    let ont00001825 = _prefixId.prefix "ont00001825"
    /// <summary>
    ///   <para>rdfs:label : is sister-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001826">mro:ont00001826</a>
    /// </summary>
    let ont00001826 = _prefixId.prefix "ont00001826"
    /// <summary>
    ///   <para>rdfs:label : nontangential part of</para>
    ///   <para>skos:definition : x nontangential_part_of y iff x and y are both instances of Immaterial Entity and x is a spatial part of y and there does not exist an instance of Immaterial Entity z such that z externally connects with x and z externally connects with y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be transitive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001827">mro:ont00001827</a>
    /// </summary>
    let ont00001827 = _prefixId.prefix "ont00001827"
    /// <summary>
    ///   <para>rdfs:label : has sister-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001828">mro:ont00001828</a>
    /// </summary>
    let ont00001828 = _prefixId.prefix "ont00001828"
    /// <summary>
    ///   <para>rdfs:label : disposition of aggregate</para>
    ///   <para>skos:definition : x disposition_of_aggregate y iff y is an instance of Object Aggregate and x is an instance of Disposition, and x inheres_in_aggregate y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001829">mro:ont00001829</a>
    /// </summary>
    let ont00001829 = _prefixId.prefix "ont00001829"
    /// <summary>
    ///   <para>rdfs:label : has accomplice</para>
    ///   <para>skos:definition : x has accomplice y =Def y accomplice in x.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Accomplice&amp;oldid=1002047204^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001830">mro:ont00001830</a>
    /// </summary>
    let ont00001830 = _prefixId.prefix "ont00001830"
    /// <summary>
    ///   <para>rdfs:label : is subordinate role to</para>
    ///   <para>skos:definition : For all x,y,t: y is subordinate role to x at t iff: x is an instance of Role at time t, and y is an instance of Role at time t, and there is some z such that x is realized by z and z is an instance of Process which creates, modifies, transfers, or eliminates some u such that u is a Process Regulation at time t, and u is addressed to the bearer of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001831">mro:ont00001831</a>
    /// </summary>
    let ont00001831 = _prefixId.prefix "ont00001831"
    /// <summary>
    ///   <para>rdfs:label : has some member located in</para>
    ///   <para>skos:definition : x has some member located in y iff x is an instance of Object Aggregate and y is an instance of independent continuant but not a spatial region, and at least one member of x is located in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001832">mro:ont00001832</a>
    /// </summary>
    let ont00001832 = _prefixId.prefix "ont00001832"
    /// <summary>
    ///   <para>rdfs:label : has agent</para>
    ///   <para>skos:definition : x has agent y =Def y agent in x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001833">mro:ont00001833</a>
    /// </summary>
    let ont00001833 = _prefixId.prefix "ont00001833"
    /// <summary>
    ///   <para>rdfs:label : affects</para>
    ///   <para>skos:definition : x affects y =Def y is affected by x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001834">mro:ont00001834</a>
    /// </summary>
    let ont00001834 = _prefixId.prefix "ont00001834"
    /// <summary>
    ///   <para>rdfs:label : is son of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001835">mro:ont00001835</a>
    /// </summary>
    let ont00001835 = _prefixId.prefix "ont00001835"
    /// <summary>
    ///   <para>rdfs:label : aggregate bearer of</para>
    ///   <para>skos:definition : x aggregate bearer of y =Def y inheres in aggregate x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001836">mro:ont00001836</a>
    /// </summary>
    let ont00001836 = _prefixId.prefix "ont00001836"
    /// <summary>
    ///   <para>rdfs:label : time zone identifier used by</para>
    ///   <para>skos:definition : x time_zone_identifier_used_by y iff y is an instance of Information Bearing Entity and x is an instance of Time Zone Identifier, such that x designates the spatial region associated with the time zone mentioned in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001837">mro:ont00001837</a>
    /// </summary>
    let ont00001837 = _prefixId.prefix "ont00001837"
    /// <summary>
    ///   <para>rdfs:label : disconnected with</para>
    ///   <para>skos:definition : x disconnected_with y iff x and y are both instances of Immaterial Entity and there does not exist some immaterial entity z that is part of both x and y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001838">mro:ont00001838</a>
    /// </summary>
    let ont00001838 = _prefixId.prefix "ont00001838"
    /// <summary>
    ///   <para>rdfs:label : has son</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001839">mro:ont00001839</a>
    /// </summary>
    let ont00001839 = _prefixId.prefix "ont00001839"
    /// <summary>
    ///   <para>rdfs:label : has grandmother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001840">mro:ont00001840</a>
    /// </summary>
    let ont00001840 = _prefixId.prefix "ont00001840"
    /// <summary>
    ///   <para>rdfs:label : is input of</para>
    ///   <para>skos:definition : x is input of y =Def x participates in y, x is an Independent Continuant (but not a Spatial Region), y is a Process, and the presence of x at the beginning of y is a necessary condition for the start of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001841">mro:ont00001841</a>
    /// </summary>
    let ont00001841 = _prefixId.prefix "ont00001841"
    /// <summary>
    ///   <para>rdfs:label : is child of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001842">mro:ont00001842</a>
    /// </summary>
    let ont00001842 = _prefixId.prefix "ont00001842"
    /// <summary>
    ///   <para>rdfs:label : is paternal first cousin of</para>
    ///   <para>skos:definition : Person A is paternal first cousin of Person B iff Person B has father F and F has sibling P and P is parent of Person A.</para>
    ///   <para>skos:scopeNote : is_paternal_first_cousin_of is not a symmetric relationship as is is_first_cousin_of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001843">mro:ont00001843</a>
    /// </summary>
    let ont00001843 = _prefixId.prefix "ont00001843"
    /// <summary>
    ///   <para>rdfs:label : has sender</para>
    ///   <para>skos:definition : x has sender y =Def y sends x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001844">mro:ont00001844</a>
    /// </summary>
    let ont00001844 = _prefixId.prefix "ont00001844"
    /// <summary>
    ///   <para>rdfs:label : is site of</para>
    ///   <para>skos:definition : x is site of y =Def y occurs at x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001845">mro:ont00001845</a>
    /// </summary>
    let ont00001845 = _prefixId.prefix "ont00001845"
    /// <summary>
    ///   <para>rdfs:label : is organizational context of</para>
    ///   <para>skos:definition : x is_organizational_context_of y iff x is an instance of an Organization and y is an instance of a Role and z is an instance of a Person, such that z's affiliation with x is a prerequisite for z bearing y, or x ascribes y to the bearer of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001846">mro:ont00001846</a>
    /// </summary>
    let ont00001846 = _prefixId.prefix "ont00001846"
    /// <summary>
    ///   <para>rdfs:label : interval is after</para>
    ///   <para>skos:definition : x interval is after y =Def y interval is before x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001847">mro:ont00001847</a>
    /// </summary>
    let ont00001847 = _prefixId.prefix "ont00001847"
    /// <summary>
    ///   <para>rdfs:label : is inside instant of</para>
    ///   <para>skos:definition : x is_inside_instant of y iff x is an instance of Temporal Instant and y is an instance of One-Dimensional Temporal Region and there are instances of Temporal Instant w and z that are part of y and non-identical to x such that w precedes x and z is preceded by x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001848">mro:ont00001848</a>
    /// </summary>
    let ont00001848 = _prefixId.prefix "ont00001848"
    /// <summary>
    ///   <para>rdfs:label : is father-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001849">mro:ont00001849</a>
    /// </summary>
    let ont00001849 = _prefixId.prefix "ont00001849"
    /// <summary>
    ///   <para>rdfs:label : is grandparent of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001850">mro:ont00001850</a>
    /// </summary>
    let ont00001850 = _prefixId.prefix "ont00001850"
    /// <summary>
    ///   <para>rdfs:label : is sister of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001851">mro:ont00001851</a>
    /// </summary>
    let ont00001851 = _prefixId.prefix "ont00001851"
    /// <summary>
    ///   <para>rdfs:label : accessory in</para>
    ///   <para>skos:definition : x is_accessory_in y iff x is an instance of Agent and y is an instance of Process such that x assists another instance of Agent z in the commission of y, and x was not located at the location of y when y occurred, and x is not an agent_in y.</para>
    ///   <para>cco:ont00001754 : http://en.wikipedia.org/wiki/Accessory_(legal_term)^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001852">mro:ont00001852</a>
    /// </summary>
    let ont00001852 = _prefixId.prefix "ont00001852"
    /// <summary>
    ///   <para>rdfs:label : is mother-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001853">mro:ont00001853</a>
    /// </summary>
    let ont00001853 = _prefixId.prefix "ont00001853"
    /// <summary>
    ///   <para>rdfs:label : has daughter-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001854">mro:ont00001854</a>
    /// </summary>
    let ont00001854 = _prefixId.prefix "ont00001854"
    /// <summary>
    ///   <para>rdfs:label : has spatial part</para>
    ///   <para>skos:definition : x has spatial part y =Def y spatial part of x.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001855">mro:ont00001855</a>
    /// </summary>
    let ont00001855 = _prefixId.prefix "ont00001855"
    /// <summary>
    ///   <para>rdfs:label : has niece</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001856">mro:ont00001856</a>
    /// </summary>
    let ont00001856 = _prefixId.prefix "ont00001856"
    /// <summary>
    ///   <para>rdfs:label : is part of process</para>
    ///   <para>skos:definition : x is part of process y iff x is occurrent part of y, x and y are Processes, and x occupies a temporal region that is a proper occurrent part of the temporal interval of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001857">mro:ont00001857</a>
    /// </summary>
    let ont00001857 = _prefixId.prefix "ont00001857"
    /// <summary>
    ///   <para>rdfs:label : is daughter of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001858">mro:ont00001858</a>
    /// </summary>
    let ont00001858 = _prefixId.prefix "ont00001858"
    /// <summary>
    ///   <para>rdfs:label : is delimited by</para>
    ///   <para>skos:definition : x is_delimited_by y iff x is an instance of Organization and y is an instance of Delimiting Domain and y delimits x.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Boundary_delimitation&amp;oldid=1039137603^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001859">mro:ont00001859</a>
    /// </summary>
    let ont00001859 = _prefixId.prefix "ont00001859"
    /// <summary>
    ///   <para>rdfs:label : is ancestor of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001860">mro:ont00001860</a>
    /// </summary>
    let ont00001860 = _prefixId.prefix "ont00001860"
    /// <summary>
    ///   <para>rdfs:label : is material of</para>
    ///   <para>skos:definition : An object m is material of an object o when m is the material of which o consists and that material does not undergo a change of kind during the creation of o</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001861">mro:ont00001861</a>
    /// </summary>
    let ont00001861 = _prefixId.prefix "ont00001861"
    /// <summary>
    ///   <para>rdfs:label : interval disjoint</para>
    ///   <para>skos:definition : x interval_disjoint y iff x and y are both instances of Temporal Interval and have no parts in common.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001862">mro:ont00001862</a>
    /// </summary>
    let ont00001862 = _prefixId.prefix "ont00001862"
    /// <summary>
    ///   <para>rdfs:label : uses measurement unit</para>
    ///   <para>skos:definition : x uses measurement unit y =Def y is measurement unit of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001863">mro:ont00001863</a>
    /// </summary>
    let ont00001863 = _prefixId.prefix "ont00001863"
    /// <summary>
    ///   <para>rdfs:label : delimits</para>
    ///   <para>skos:definition : x delimits y =Def y is delimited by x.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Boundary_delimitation&amp;oldid=1039137603^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001864">mro:ont00001864</a>
    /// </summary>
    let ont00001864 = _prefixId.prefix "ont00001864"
    /// <summary>
    ///   <para>rdfs:label : has familial relationship to</para>
    ///   <para>skos:definition : A relationship between persons by virtue of ancestry or legal union.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001865">mro:ont00001865</a>
    /// </summary>
    let ont00001865 = _prefixId.prefix "ont00001865"
    /// <summary>
    ///   <para>rdfs:label : is interest of</para>
    ///   <para>dcterms:created : 2022-12-30T21:32:27-05:00^^xsd:dateTime</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>skos:definition : x is interest of y =Def y has interest in x.</para>
    ///   <para>skos:prefLabel : is interest of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001866">mro:ont00001866</a>
    /// </summary>
    let ont00001866 = _prefixId.prefix "ont00001866"
    /// <summary>
    ///   <para>rdfs:label : is daughter-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001867">mro:ont00001867</a>
    /// </summary>
    let ont00001867 = _prefixId.prefix "ont00001867"
    /// <summary>
    ///   <para>rdfs:label : is a nominal measurement of</para>
    ///   <para>skos:definition : x is_a_nominal_measurement_of y iff x is an instance of Nominal Measurement Information Content Entity and y is an instance of Entity, such that x classifies y relative to some set of shared, possibly arbitrary, characteristics.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001868">mro:ont00001868</a>
    /// </summary>
    let ont00001868 = _prefixId.prefix "ont00001868"
    /// <summary>
    ///   <para>rdfs:label : interval during</para>
    ///   <para>skos:definition : x interval_during y iff x and y are both instances of Temporal Interval and there exist instances of Temporal Instant u, v, w, and z such that u is the starting instant of x, v is the ending instant of x, w is the starting instant of y, z is the ending instant of y, w is before u, and v is before z.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001869">mro:ont00001869</a>
    /// </summary>
    let ont00001869 = _prefixId.prefix "ont00001869"
    /// <summary>
    ///   <para>rdfs:label : interval overlapped by</para>
    ///   <para>skos:definition : x is_overlapped_by y iff x and y are both instances of Temporal Interval and y interval_overlaps x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001870">mro:ont00001870</a>
    /// </summary>
    let ont00001870 = _prefixId.prefix "ont00001870"
    /// <summary>
    ///   <para>rdfs:label : has wife</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001871">mro:ont00001871</a>
    /// </summary>
    let ont00001871 = _prefixId.prefix "ont00001871"
    /// <summary>
    ///   <para>rdfs:label : is step-brother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001872">mro:ont00001872</a>
    /// </summary>
    let ont00001872 = _prefixId.prefix "ont00001872"
    /// <summary>
    ///   <para>rdfs:label : represented by</para>
    ///   <para>skos:definition : x represented by y =Def y represents x.</para>
    ///   <para>skos:scopeNote : See notes for inverse property.^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001873">mro:ont00001873</a>
    /// </summary>
    let ont00001873 = _prefixId.prefix "ont00001873"
    /// <summary>
    ///   <para>rdfs:label : is temporal region of</para>
    ///   <para>skos:definition : x is temporal region of y =Def y occupies temporal region x.</para>
    ///   <para>skos:editorialNote : Leaving this is in ERO for now since BFO2020 has no inverse of occupies-temporal-region yet.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001874">mro:ont00001874</a>
    /// </summary>
    let ont00001874 = _prefixId.prefix "ont00001874"
    /// <summary>
    ///   <para>rdfs:label : interval started by</para>
    ///   <para>skos:definition : x interval started by y =Def y interval starts x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001875">mro:ont00001875</a>
    /// </summary>
    let ont00001875 = _prefixId.prefix "ont00001875"
    /// <summary>
    ///   <para>rdfs:label : is grandfather of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001876">mro:ont00001876</a>
    /// </summary>
    let ont00001876 = _prefixId.prefix "ont00001876"
    /// <summary>
    ///   <para>rdfs:label : is an interval measurement of</para>
    ///   <para>skos:definition : x is_an_interval_measurement_of y iff x is an instance of Interval Measurement Information Content Entity and y is an instance of Entity and y is_measured_by_interval x.</para>
    ///   <para>skos:example : a measurement of air temperature on the Celsius scale.^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001877">mro:ont00001877</a>
    /// </summary>
    let ont00001877 = _prefixId.prefix "ont00001877"
    /// <summary>
    ///   <para>rdfs:label : is mention of</para>
    ///   <para>skos:definition : x is mention of y =Def y is mentioned by x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001878">mro:ont00001878</a>
    /// </summary>
    let ont00001878 = _prefixId.prefix "ont00001878"
    /// <summary>
    ///   <para>rdfs:label : designated by</para>
    ///   <para>skos:definition : x designated by y =Def y designates x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001879">mro:ont00001879</a>
    /// </summary>
    let ont00001879 = _prefixId.prefix "ont00001879"
    /// <summary>
    ///   <para>rdfs:label : capability of aggregate</para>
    ///   <para>skos:definition : x capability_of_aggregate y iff y is an instance of Object Aggregate and x is an instance of Agent Capability, such that x inheres in aggregate y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001880">mro:ont00001880</a>
    /// </summary>
    let ont00001880 = _prefixId.prefix "ont00001880"
    /// <summary>
    ///   <para>rdfs:label : is son-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001881">mro:ont00001881</a>
    /// </summary>
    let ont00001881 = _prefixId.prefix "ont00001881"
    /// <summary>
    ///   <para>rdfs:label : is grandmother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001882">mro:ont00001882</a>
    /// </summary>
    let ont00001882 = _prefixId.prefix "ont00001882"
    /// <summary>
    ///   <para>rdfs:label : is brother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001883">mro:ont00001883</a>
    /// </summary>
    let ont00001883 = _prefixId.prefix "ont00001883"
    /// <summary>
    ///   <para>rdfs:label : condition described by</para>
    ///   <para>skos:definition : x condition described by y =Def y describes condition x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001884">mro:ont00001884</a>
    /// </summary>
    let ont00001884 = _prefixId.prefix "ont00001884"
    /// <summary>
    ///   <para>rdfs:label : has mother-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001885">mro:ont00001885</a>
    /// </summary>
    let ont00001885 = _prefixId.prefix "ont00001885"
    /// <summary>
    ///   <para>rdfs:label : is affected by</para>
    ///   <para>skos:definition : x is affected by y =Def x participates in y, x is an Independent Continuant (but not a Spatial Region), y is a Process, and y influences x in some manner, most often by producing a change in x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001886">mro:ont00001886</a>
    /// </summary>
    let ont00001886 = _prefixId.prefix "ont00001886"
    /// <summary>
    ///   <para>rdfs:label : is wife of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001887">mro:ont00001887</a>
    /// </summary>
    let ont00001887 = _prefixId.prefix "ont00001887"
    /// <summary>
    ///   <para>rdfs:label : disrupts</para>
    ///   <para>dcterms:created : 2022-12-30T21:32:27-05:00^^xsd:dateTime</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>skos:definition : A relation where one process disrupts another process from occurring as it would have.</para>
    ///   <para>skos:editorialNote : To lower the grade of a process is to lower the quality of a process according to some standard, for example when realizing a capability or a function.</para>
    ///   <para>skos:prefLabel : disrupts</para>
    ///   <para>skos:scopeNote : A process can disrupt another process from occurring as it would have by 1) preventing a disposition or role from being realized by that process, 2) lowering the grade of the process, or 3) stopping the process from continuing to occur.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001888">mro:ont00001888</a>
    /// </summary>
    let ont00001888 = _prefixId.prefix "ont00001888"
    /// <summary>
    ///   <para>rdfs:label : capability of</para>
    ///   <para>skos:definition : x capability_of y iff y is an instance of Agent and x is an instance of Agent Capability, such that x inheres in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001889">mro:ont00001889</a>
    /// </summary>
    let ont00001889 = _prefixId.prefix "ont00001889"
    /// <summary>
    ///   <para>rdfs:label : has step brother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001890">mro:ont00001890</a>
    /// </summary>
    let ont00001890 = _prefixId.prefix "ont00001890"
    /// <summary>
    ///   <para>rdfs:label : has brother-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001891">mro:ont00001891</a>
    /// </summary>
    let ont00001891 = _prefixId.prefix "ont00001891"
    /// <summary>
    ///   <para>rdfs:label : is paternal grandfather of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001892">mro:ont00001892</a>
    /// </summary>
    let ont00001892 = _prefixId.prefix "ont00001892"
    /// <summary>
    ///   <para>rdfs:label : instant is after</para>
    ///   <para>skos:definition : x instant_is_after y iff x and y are both instances of Temporal Instant and there exists some instance of Temporal Interval z such that y is the starting instant of z and x is the ending instant of z.</para>
    ///   <para>skos:scopeNote : 'instant is after' is a primitive relationship. Informally, a temporal instant x is after some temporal instant y iff y precedes x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001893">mro:ont00001893</a>
    /// </summary>
    let ont00001893 = _prefixId.prefix "ont00001893"
    /// <summary>
    ///   <para>rdfs:label : has paternal first cousin</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001894">mro:ont00001894</a>
    /// </summary>
    let ont00001894 = _prefixId.prefix "ont00001894"
    /// <summary>
    ///   <para>rdfs:label : accomplice in</para>
    ///   <para>skos:definition : Agent x is accomplice_in Process y iff x assists in the commission of y, is located at the location of y, but is not agent_in y.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=Accomplice&amp;oldid=1002047204^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001895">mro:ont00001895</a>
    /// </summary>
    let ont00001895 = _prefixId.prefix "ont00001895"
    /// <summary>
    ///   <para>rdfs:label : interval meets</para>
    ///   <para>skos:definition : x interval meets y =Def y interval met by x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001896">mro:ont00001896</a>
    /// </summary>
    let ont00001896 = _prefixId.prefix "ont00001896"
    /// <summary>
    ///   <para>rdfs:label : is maternal grandmother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001897">mro:ont00001897</a>
    /// </summary>
    let ont00001897 = _prefixId.prefix "ont00001897"
    /// <summary>
    ///   <para>rdfs:label : aggregate has capability</para>
    ///   <para>skos:definition : x aggregate has capability y =Def y capability of aggregate x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001898">mro:ont00001898</a>
    /// </summary>
    let ont00001898 = _prefixId.prefix "ont00001898"
    /// <summary>
    ///   <para>rdfs:label : language used in</para>
    ///   <para>skos:definition : x language_used_by y iff y is an instance of Information Bearing Entity and x is an instance of Language, such that the literal value of y is a string that is encoded according to the syntax of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001899">mro:ont00001899</a>
    /// </summary>
    let ont00001899 = _prefixId.prefix "ont00001899"
    /// <summary>
    ///   <para>rdfs:label : is geospatial coordinate reference system of</para>
    ///   <para>skos:definition : x is_geospatial_coordinate_reference_system_of y iff y is an instance of Information Bearing Entity and x is an instance of Geospatial Coordinate Reference System, such that x describes the set of standards mentioned in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001900">mro:ont00001900</a>
    /// </summary>
    let ont00001900 = _prefixId.prefix "ont00001900"
    /// <summary>
    ///   <para>rdfs:label : aggregate has role</para>
    ///   <para>skos:definition : x aggregate_has_role y iff x is an instance of Object Aggregate and y is an instance of Role, such that x aggregate_bearer_of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001901">mro:ont00001901</a>
    /// </summary>
    let ont00001901 = _prefixId.prefix "ont00001901"
    /// <summary>
    ///   <para>rdfs:label : is sibling of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001902">mro:ont00001902</a>
    /// </summary>
    let ont00001902 = _prefixId.prefix "ont00001902"
    /// <summary>
    ///   <para>rdfs:label : is maternal grandfather of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001903">mro:ont00001903</a>
    /// </summary>
    let ont00001903 = _prefixId.prefix "ont00001903"
    /// <summary>
    ///   <para>rdfs:label : is measured by</para>
    ///   <para>skos:definition : x is measured by y =Def y is a measurement of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001904">mro:ont00001904</a>
    /// </summary>
    let ont00001904 = _prefixId.prefix "ont00001904"
    /// <summary>
    ///   <para>rdfs:label : is half-brother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001905">mro:ont00001905</a>
    /// </summary>
    let ont00001905 = _prefixId.prefix "ont00001905"
    /// <summary>
    ///   <para>rdfs:label : is maternal first cousin of</para>
    ///   <para>skos:definition : Person A is maternal first cousin of Person B iff Person B has mother M and M has sibling P and P is parent of Person A.</para>
    ///   <para>skos:scopeNote : is_maternal_first_cousin_of is not a symmetric relationship as is is_first_cousin_of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001906">mro:ont00001906</a>
    /// </summary>
    let ont00001906 = _prefixId.prefix "ont00001906"
    /// <summary>
    ///   <para>rdfs:label : aggregate has quality</para>
    ///   <para>skos:definition : x aggregate_has_quality y iff x is an instance of Object Aggregate and y is an instance of Quality, such that x aggregate_bearer_of y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001907">mro:ont00001907</a>
    /// </summary>
    let ont00001907 = _prefixId.prefix "ont00001907"
    /// <summary>
    ///   <para>rdfs:label : uses time zone identifier</para>
    ///   <para>skos:definition : x uses time zone identifier y =Def y time zone identifier used by x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001908">mro:ont00001908</a>
    /// </summary>
    let ont00001908 = _prefixId.prefix "ont00001908"
    /// <summary>
    ///   <para>rdfs:label : has tangential part</para>
    ///   <para>skos:definition : x has tangential part y =Def y tangential part of x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be transitive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001909">mro:ont00001909</a>
    /// </summary>
    let ont00001909 = _prefixId.prefix "ont00001909"
    /// <summary>
    ///   <para>rdfs:label : permits</para>
    ///   <para>skos:definition : x permits y at t iff: x is an instance of Process Regulation at time t, and y is an instance of Process at time t, and x prescribes that y may occur.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001910">mro:ont00001910</a>
    /// </summary>
    let ont00001910 = _prefixId.prefix "ont00001910"
    /// <summary>
    ///   <para>rdfs:label : is paternal grandmother of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001911">mro:ont00001911</a>
    /// </summary>
    let ont00001911 = _prefixId.prefix "ont00001911"
    /// <summary>
    ///   <para>rdfs:label : uses reference system</para>
    ///   <para>skos:definition : x uses reference system y =Def y is reference system of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001912">mro:ont00001912</a>
    /// </summary>
    let ont00001912 = _prefixId.prefix "ont00001912"
    /// <summary>
    ///   <para>rdfs:label : uses geospatial coordinate reference system</para>
    ///   <para>skos:definition : x uses geospatial coordinate reference system y =Def y is geospatial coordinate reference system of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001913">mro:ont00001913</a>
    /// </summary>
    let ont00001913 = _prefixId.prefix "ont00001913"
    /// <summary>
    ///   <para>rdfs:label : is measured by nominal</para>
    ///   <para>skos:definition : x is measured by nominal y =Def y is a nominal measurement of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001914">mro:ont00001914</a>
    /// </summary>
    let ont00001914 = _prefixId.prefix "ont00001914"
    /// <summary>
    ///   <para>rdfs:label : interval met by</para>
    ///   <para>skos:definition : x interval_met_by y iff x and y are both instances of Temporal Interval and y interval_meets x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001915">mro:ont00001915</a>
    /// </summary>
    let ont00001915 = _prefixId.prefix "ont00001915"
    /// <summary>
    ///   <para>rdfs:label : designates</para>
    ///   <para>skos:definition : x designates y iff x is an instance of a Designative Information Content Entity, and y is an instance of an Entity, such that given some context, x uniquely distinguishes y from other entities.</para>
    ///   <para>skos:example : a URL designates the location of a Web Page on the internet^^xsd:stringskos:example : a person's name designates that person^^xsd:stringskos:example : a vehicle identification number designates some vehicle^^xsd:string</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be functional. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001916">mro:ont00001916</a>
    /// </summary>
    let ont00001916 = _prefixId.prefix "ont00001916"
    /// <summary>
    ///   <para>rdfs:label : described by</para>
    ///   <para>skos:definition : x described by y =Def y describes x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001917">mro:ont00001917</a>
    /// </summary>
    let ont00001917 = _prefixId.prefix "ont00001917"
    /// <summary>
    ///   <para>rdfs:label : occurs at</para>
    ///   <para>skos:definition : x occurs_at y iff x is an instance of Process and y is an instance of Site, such that x occurs in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001918">mro:ont00001918</a>
    /// </summary>
    let ont00001918 = _prefixId.prefix "ont00001918"
    /// <summary>
    ///   <para>rdfs:label : is mentioned by</para>
    ///   <para>skos:definition : x is_mentioned_by y iff y is an instance of Information Bearing Entity and x is an instance of Entity, such that y is used as a reference to x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001919">mro:ont00001919</a>
    /// </summary>
    let ont00001919 = _prefixId.prefix "ont00001919"
    /// <summary>
    ///   <para>rdfs:label : prescribed by</para>
    ///   <para>skos:definition : x prescribed by y =Def y prescribes x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001920">mro:ont00001920</a>
    /// </summary>
    let ont00001920 = _prefixId.prefix "ont00001920"
    /// <summary>
    ///   <para>rdfs:label : has input</para>
    ///   <para>skos:definition : x has input y =Def y is input of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001921">mro:ont00001921</a>
    /// </summary>
    let ont00001921 = _prefixId.prefix "ont00001921"
    /// <summary>
    ///   <para>rdfs:label : has recipient</para>
    ///   <para>skos:definition : x has recipient y =Def y receives x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001922">mro:ont00001922</a>
    /// </summary>
    let ont00001922 = _prefixId.prefix "ont00001922"
    /// <summary>
    ///   <para>rdfs:label : interval starts</para>
    ///   <para>skos:definition : x interval_starts y iff x and y are both instances of Temporal Interval and there exist instances of Temporal Instant v, w, and z such that v is the starting instant of both x and y, w is the ending instant of x, z is the ending instant of y and w is before z.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001923">mro:ont00001923</a>
    /// </summary>
    let ont00001923 = _prefixId.prefix "ont00001923"
    /// <summary>
    ///   <para>rdfs:label : interval contains</para>
    ///   <para>skos:definition : x interval contains y =Def y interval contained by x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001924">mro:ont00001924</a>
    /// </summary>
    let ont00001924 = _prefixId.prefix "ont00001924"
    /// <summary>
    ///   <para>rdfs:label : is used by</para>
    ///   <para>skos:definition : x is used by y =Def y uses x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001925">mro:ont00001925</a>
    /// </summary>
    let ont00001925 = _prefixId.prefix "ont00001925"
    /// <summary>
    ///   <para>rdfs:label : is paternal uncle of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001926">mro:ont00001926</a>
    /// </summary>
    let ont00001926 = _prefixId.prefix "ont00001926"
    /// <summary>
    ///   <para>rdfs:label : has half brother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001927">mro:ont00001927</a>
    /// </summary>
    let ont00001927 = _prefixId.prefix "ont00001927"
    /// <summary>
    ///   <para>rdfs:label : is predecessor of</para>
    ///   <para>skos:definition : x is_predecessor_of y iff x and y are both instances of Independent Continuant and there is some process p and x is an input to p and y is an output of p.</para>
    ///   <para>skos:scopeNote : More informally, x is_predecessor_of y iff y follows or replaces x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001928">mro:ont00001928</a>
    /// </summary>
    let ont00001928 = _prefixId.prefix "ont00001928"
    /// <summary>
    ///   <para>rdfs:label : is maternal uncle of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001929">mro:ont00001929</a>
    /// </summary>
    let ont00001929 = _prefixId.prefix "ont00001929"
    /// <summary>
    ///   <para>rdfs:label : is second cousin of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001930">mro:ont00001930</a>
    /// </summary>
    let ont00001930 = _prefixId.prefix "ont00001930"
    /// <summary>
    ///   <para>rdfs:label : externally connects with</para>
    ///   <para>skos:definition : x externally_connects_with y iff x and y are both instances of Immaterial Entity and x connects with y and x does not overlap y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001931">mro:ont00001931</a>
    /// </summary>
    let ont00001931 = _prefixId.prefix "ont00001931"
    /// <summary>
    ///   <para>rdfs:label : is niece of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001932">mro:ont00001932</a>
    /// </summary>
    let ont00001932 = _prefixId.prefix "ont00001932"
    /// <summary>
    ///   <para>rdfs:label : process starts</para>
    ///   <para>skos:definition : x process_starts y iff x and y are instances of processes, and x is_cause_of y, and i is an instance of a temporal instant, and r is an instance of a temporal interval, and y has starting instance i, and x occupies temporal region r, and r has inside instant i.</para>
    ///   <para>skos:scopeNote : A process x starts another process y when x causes y while x is still occurring.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001933">mro:ont00001933</a>
    /// </summary>
    let ont00001933 = _prefixId.prefix "ont00001933"
    /// <summary>
    ///   <para>rdfs:label : has maternal first cousin</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001934">mro:ont00001934</a>
    /// </summary>
    let ont00001934 = _prefixId.prefix "ont00001934"
    /// <summary>
    ///   <para>rdfs:label : has father-in-law</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001935">mro:ont00001935</a>
    /// </summary>
    let ont00001935 = _prefixId.prefix "ont00001935"
    /// <summary>
    ///   <para>rdfs:label : is object of</para>
    ///   <para>skos:definition : x is object of y =Def x participates in y, x is an Independent Continuant (but not a Spatial Region), y is a Process, and y is performed by Agent z and x is part of the projected state that z intends to achieve by performing y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001936">mro:ont00001936</a>
    /// </summary>
    let ont00001936 = _prefixId.prefix "ont00001936"
    /// <summary>
    ///   <para>rdfs:label : has paternal grandmother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001937">mro:ont00001937</a>
    /// </summary>
    let ont00001937 = _prefixId.prefix "ont00001937"
    /// <summary>
    ///   <para>rdfs:label : represents</para>
    ///   <para>skos:definition : x represents y iff x is an instance of Representational Information Content Entity, y is an instance of Entity, and z is carrier of x, such that x is about y in virtue of there existing an isomorphism between characteristics of z and y.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be functional. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.skos:scopeNote : Isomorphism between the carrier of x and the represented entity can be via a direct similarity relation, e.g., grooves in a vinyl record corresponding to sound waves, or linguistic convention, e.g., a court stenographer's transcription of spoken words, as well as others, such as encoding processes for images.skos:scopeNote : The relationship that is being defined here is that between the content of a photographic image and its object, between the content of a video and its objects and events, between the content of an audio recording and the sounds or events generating those sounds, or between the content of a written transcript and the verbal event that it transcribes.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001938">mro:ont00001938</a>
    /// </summary>
    let ont00001938 = _prefixId.prefix "ont00001938"
    /// <summary>
    ///   <para>rdfs:label : is affiliated with</para>
    ///   <para>skos:definition : x is_affiliated_with y iff x and y are instances of Agent, such that they have any kind of social or business relationship.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001939">mro:ont00001939</a>
    /// </summary>
    let ont00001939 = _prefixId.prefix "ont00001939"
    /// <summary>
    ///   <para>rdfs:label : interval is before</para>
    ///   <para>skos:definition : x interval_is_before y iff x and y are both instances of Temporal Interval and there exist instances of Temporal Instant w, z such that w is the ending instant of x and z is the starting instant of y and w is before z.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001940">mro:ont00001940</a>
    /// </summary>
    let ont00001940 = _prefixId.prefix "ont00001940"
    /// <summary>
    ///   <para>rdfs:label : is maternal aunt of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001941">mro:ont00001941</a>
    /// </summary>
    let ont00001941 = _prefixId.prefix "ont00001941"
    /// <summary>
    ///   <para>rdfs:label : prescribes</para>
    ///   <para>skos:definition : x prescribes y iff x is an instance of Information Content Entity and y is an instance of Entity, such that x serves as a rule or guide for y if y an Occurrent, or x serves as a model for y if y is a Continuant.</para>
    ///   <para>skos:example : A blueprint prescribes some artifact or facility by being a model for it.^^xsd:stringskos:example : A professional code of conduct prescribes some realizations of a profession (role) by giving rules for how the bearer should act in those realizations.^^xsd:stringskos:example : An operations plan prescribes an operation by enumerating the tasks that need to be performed in order to achieve the objectives of the operation.^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001942">mro:ont00001942</a>
    /// </summary>
    let ont00001942 = _prefixId.prefix "ont00001942"
    /// <summary>
    ///   <para>rdfs:label : supervises</para>
    ///   <para>skos:definition : x supervises y =Def y is supervised by x.</para>
    ///   <para>cco:ont00001754 : http://en.wiktionary.org/wiki/supervise^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001943">mro:ont00001943</a>
    /// </summary>
    let ont00001943 = _prefixId.prefix "ont00001943"
    /// <summary>
    ///   <para>rdfs:label : spatial part of</para>
    ///   <para>skos:definition : x spatial_part_of y iff x, y, z, and q are instances of Immaterial Entity, such that for any z connected with x, z is also connected with y, and q is connected with y but not connected with x.</para>
    ///   <para>skos:scopeNote : in the sense used here, spatial part of is elsewhere referred to as proper spatial part of</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001944">mro:ont00001944</a>
    /// </summary>
    let ont00001944 = _prefixId.prefix "ont00001944"
    /// <summary>
    ///   <para>rdfs:label : is grandchild of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001945">mro:ont00001945</a>
    /// </summary>
    let ont00001945 = _prefixId.prefix "ont00001945"
    /// <summary>
    ///   <para>rdfs:label : has father</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001946">mro:ont00001946</a>
    /// </summary>
    let ont00001946 = _prefixId.prefix "ont00001946"
    /// <summary>
    ///   <para>rdfs:label : quality of aggregate</para>
    ///   <para>skos:definition : x quality_of_aggregate y iff y is an instance of Object Aggregate and x is an instance of Quality, and x inheres_in_aggregate y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001947">mro:ont00001947</a>
    /// </summary>
    let ont00001947 = _prefixId.prefix "ont00001947"
    /// <summary>
    ///   <para>rdfs:label : is half sister of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001948">mro:ont00001948</a>
    /// </summary>
    let ont00001948 = _prefixId.prefix "ont00001948"
    /// <summary>
    ///   <para>rdfs:label : has accessory</para>
    ///   <para>skos:definition : x has accessory y =Def y accessory in x.</para>
    ///   <para>cco:ont00001754 : http://en.wikipedia.org/wiki/Accessory_(legal_term)^^xsd:string</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001949">mro:ont00001949</a>
    /// </summary>
    let ont00001949 = _prefixId.prefix "ont00001949"
    /// <summary>
    ///   <para>rdfs:label : is third cousin of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001950">mro:ont00001950</a>
    /// </summary>
    let ont00001950 = _prefixId.prefix "ont00001950"
    /// <summary>
    ///   <para>rdfs:label : has subordinate role</para>
    ///   <para>skos:definition : x has subordinate role y =Def y is subordinate role to x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001951">mro:ont00001951</a>
    /// </summary>
    let ont00001951 = _prefixId.prefix "ont00001951"
    /// <summary>
    ///   <para>rdfs:label : is brother-in-law of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001952">mro:ont00001952</a>
    /// </summary>
    let ont00001952 = _prefixId.prefix "ont00001952"
    /// <summary>
    ///   <para>rdfs:label : has parent</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001953">mro:ont00001953</a>
    /// </summary>
    let ont00001953 = _prefixId.prefix "ont00001953"
    /// <summary>
    ///   <para>rdfs:label : has capability</para>
    ///   <para>skos:definition : x has capability y =Def y capability of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001954">mro:ont00001954</a>
    /// </summary>
    let ont00001954 = _prefixId.prefix "ont00001954"
    /// <summary>
    ///   <para>rdfs:label : is aunt of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001955">mro:ont00001955</a>
    /// </summary>
    let ont00001955 = _prefixId.prefix "ont00001955"
    /// <summary>
    ///   <para>rdfs:label : aggregate has disposition</para>
    ///   <para>skos:definition : x aggregate has disposition y =Def y disposition of aggregate x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001956">mro:ont00001956</a>
    /// </summary>
    let ont00001956 = _prefixId.prefix "ont00001956"
    /// <summary>
    ///   <para>rdfs:label : is husband of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001957">mro:ont00001957</a>
    /// </summary>
    let ont00001957 = _prefixId.prefix "ont00001957"
    /// <summary>
    ///   <para>rdfs:label : has maternal aunt</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001958">mro:ont00001958</a>
    /// </summary>
    let ont00001958 = _prefixId.prefix "ont00001958"
    /// <summary>
    ///   <para>rdfs:label : inhibits</para>
    ///   <para>skos:definition : x inhibits y =Def y is inhibited by x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001959">mro:ont00001959</a>
    /// </summary>
    let ont00001959 = _prefixId.prefix "ont00001959"
    /// <summary>
    ///   <para>rdfs:label : has maternal grandmother</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001960">mro:ont00001960</a>
    /// </summary>
    let ont00001960 = _prefixId.prefix "ont00001960"
    /// <summary>
    ///   <para>rdfs:label : is measurement unit of</para>
    ///   <para>skos:definition : x is_measurement_unit_of y iff y is an instance of Information Bearing Entity and x is an instance of Measurement Unit, such that x describes the magnitude of measured physical quantity mentioned in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001961">mro:ont00001961</a>
    /// </summary>
    let ont00001961 = _prefixId.prefix "ont00001961"
    /// <summary>
    ///   <para>rdfs:label : process started by</para>
    ///   <para>skos:definition : x process started by y =Def y process starts x.</para>
    ///   <para>skos:scopeNote : A process x is started by another process y when y causes x while y is still occurring.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001962">mro:ont00001962</a>
    /// </summary>
    let ont00001962 = _prefixId.prefix "ont00001962"
    /// <summary>
    ///   <para>rdfs:label : is measured by ordinal</para>
    ///   <para>skos:definition : x is measured by ordinal y =Def y is a ordinal measurement of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001963">mro:ont00001963</a>
    /// </summary>
    let ont00001963 = _prefixId.prefix "ont00001963"
    /// <summary>
    ///   <para>rdfs:label : is measured by interval</para>
    ///   <para>skos:definition : x is measured by interval y =Def y is a interval measurement of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001964">mro:ont00001964</a>
    /// </summary>
    let ont00001964 = _prefixId.prefix "ont00001964"
    /// <summary>
    ///   <para>rdfs:label : is measured by ratio</para>
    ///   <para>skos:definition : x is measured by ratio y =Def y is a ratio measurement of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001965">mro:ont00001965</a>
    /// </summary>
    let ont00001965 = _prefixId.prefix "ont00001965"
    /// <summary>
    ///   <para>rdfs:label : is a measurement of</para>
    ///   <para>skos:definition : x is_a_measurement_of y iff x is an instance of Measurement Information Content Entity and y is an instance of Entity, such that x describes some attribute of y relative to some scale or classification scheme.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be functional. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.skos:scopeNote : This object property, as well as all of its children are typified as functional properties. This means that for instances x, y, and z if x is a measurement of y and x is a measurement of z, then y = z.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001966">mro:ont00001966</a>
    /// </summary>
    let ont00001966 = _prefixId.prefix "ont00001966"
    /// <summary>
    ///   <para>rdfs:label : is nephew of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001967">mro:ont00001967</a>
    /// </summary>
    let ont00001967 = _prefixId.prefix "ont00001967"
    /// <summary>
    ///   <para>rdfs:label : is descendant of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001968">mro:ont00001968</a>
    /// </summary>
    let ont00001968 = _prefixId.prefix "ont00001968"
    /// <summary>
    ///   <para>rdfs:label : has nephew</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001969">mro:ont00001969</a>
    /// </summary>
    let ont00001969 = _prefixId.prefix "ont00001969"
    /// <summary>
    ///   <para>rdfs:label : inhibited by</para>
    ///   <para>skos:definition : y inhibited_by x iff x and y are non-identical Processes, d is a Decrease of Realizable Entity, and x is_cause_of d, and r is a Realizable Entity, and d has_participant r, and r realized_in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001970">mro:ont00001970</a>
    /// </summary>
    let ont00001970 = _prefixId.prefix "ont00001970"
    /// <summary>
    ///   <para>rdfs:label : interval contained by</para>
    ///   <para>skos:definition : x interval_contained_by y iff x and y are both instances of Temporal Interval and y interval_contains x.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001971">mro:ont00001971</a>
    /// </summary>
    let ont00001971 = _prefixId.prefix "ont00001971"
    /// <summary>
    ///   <para>rdfs:label : has paternal grandfather</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001972">mro:ont00001972</a>
    /// </summary>
    let ont00001972 = _prefixId.prefix "ont00001972"
    /// <summary>
    ///   <para>rdfs:label : has maternal grandfather</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001973">mro:ont00001973</a>
    /// </summary>
    let ont00001973 = _prefixId.prefix "ont00001973"
    /// <summary>
    ///   <para>rdfs:label : requires</para>
    ///   <para>skos:definition : x requires y at t iff: x is an instance of Process Regulation at time t, and y is an instance of Process at time t, and x prescribes that some y must occur.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001974">mro:ont00001974</a>
    /// </summary>
    let ont00001974 = _prefixId.prefix "ont00001974"
    /// <summary>
    ///   <para>rdfs:label : is half-sibling of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001975">mro:ont00001975</a>
    /// </summary>
    let ont00001975 = _prefixId.prefix "ont00001975"
    /// <summary>
    ///   <para>rdfs:label : uses language</para>
    ///   <para>skos:definition : x uses language y =Def y language used in x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001976">mro:ont00001976</a>
    /// </summary>
    let ont00001976 = _prefixId.prefix "ont00001976"
    /// <summary>
    ///   <para>rdfs:label : has affiliate</para>
    ///   <para>skos:definition : x has affiliate y =Def y is affiliated with x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001977">mro:ont00001977</a>
    /// </summary>
    let ont00001977 = _prefixId.prefix "ont00001977"
    /// <summary>
    ///   <para>rdfs:label : receives</para>
    ///   <para>skos:definition : x receives y iff x is an instance of Agent and y is an instance of Act Of Communication, such that x is the recipient and decoder of the InformationContentEntity intended for communication in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001978">mro:ont00001978</a>
    /// </summary>
    let ont00001978 = _prefixId.prefix "ont00001978"
    /// <summary>
    ///   <para>rdfs:label : is step-sister of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001979">mro:ont00001979</a>
    /// </summary>
    let ont00001979 = _prefixId.prefix "ont00001979"
    /// <summary>
    ///   <para>rdfs:label : describes condition</para>
    ///   <para>skos:definition : p describes_condition c iff p is an instance of a Performance Specification and c is an instance of Entity and p has part d, and d is an instance of a Descriptive Information Content Entity, and p prescribes an entity s, and d describes c, and c is an entity that is causally relevant to s existing as prescribed by p.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001980">mro:ont00001980</a>
    /// </summary>
    let ont00001980 = _prefixId.prefix "ont00001980"
    /// <summary>
    ///   <para>rdfs:label : has grandson</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001981">mro:ont00001981</a>
    /// </summary>
    let ont00001981 = _prefixId.prefix "ont00001981"
    /// <summary>
    ///   <para>rdfs:label : describes</para>
    ///   <para>skos:definition : x describes y iff x is an instance of Descriptive Information Content Entity, and y is an instance of Entity, such that x is_about the characteristics that identify y.</para>
    ///   <para>skos:example : the content of a newspaper article describes some current event^^xsd:stringskos:example : the content of a visitor's log describes some facility visit^^xsd:stringskos:example : the content of an accident report describes some accident^^xsd:string</para>
    ///   <para>skos:scopeNote : It is possible that this relation should be a functional property, that is for all x, y, z if x describes y and x describes z then y = z. For example, if a financial report x describes the quarterly results of a company y and that same financial report describes the quarterly results of a company z, then it should be inferred that companies y and z are the same. We refrained from classifying the relation as a functional property on the concern that descriptions are multifaceted and so consequently it may be that the same report would contain descriptions of multiple entities.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001982">mro:ont00001982</a>
    /// </summary>
    let ont00001982 = _prefixId.prefix "ont00001982"
    /// <summary>
    ///   <para>rdfs:label : is a ratio measurement of</para>
    ///   <para>skos:definition : x is_a_ratio_measurement_of y iff x is an instance of Ratio Measurement Information Content Entity and y is an instance of Entity and x describes some attribute of y relative to a scale having equal unit values and a zero value that corresponds to the absence of the attribute being measured.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001983">mro:ont00001983</a>
    /// </summary>
    let ont00001983 = _prefixId.prefix "ont00001983"
    /// <summary>
    ///   <para>rdfs:label : has interest in</para>
    ///   <para>dcterms:created : 2022-12-30T21:32:27-05:00^^xsd:dateTime</para>
    ///   <para>dcterms:creator : https://cubrc.org^^xsd:anyURI</para>
    ///   <para>skos:definition : A relation between an Agent and some Process where the Agent has an interest in that Process.</para>
    ///   <para>skos:editorialNote : This term is meant to be weakly normative. The only sense in which the process is of positive normative value is that it's prescribed by the Agent, or historically of evolutionary benefit to the Agent's ancestors, or facilitates a process the Agent has an interest in for the prior two reasons. The process an Agent has an interest could in many or all ways be harmful to the Agent.</para>
    ///   <para>skos:prefLabel : has interest in</para>
    ///   <para>skos:scopeNote : There are four conditions in which an agent has an interest in some process. 1) Biological Condition: If a part (including improper part) of an organism has a function, then that organism has an interest in the realization of that function. 2) Artifactual Condition: If a part (including improper part) of an artifact has a function, then some agent or group of agents, at some time, has an interest in the realization of that function. 3) Prescription Condition: If an agent or group of agents has a plan, then it has an interest in the realization of all the processes and process-combinations prescribed by that plan. 4) Facilitation Condition: If (a) agent x has an interest in the realization of a disposition y, and (b) the realization of a disposition z facilitates the realization of disposition y, then (c) x has an interest in the realization of disposition z, and by 'facilitates' we mean that the occurrence of a process w, which realizes realization of z is either (1) required for y, to realize or (2) would contribute positively to the grade of, y's realization.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001984">mro:ont00001984</a>
    /// </summary>
    let ont00001984 = _prefixId.prefix "ont00001984"
    /// <summary>
    ///   <para>rdfs:label : is father of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001985">mro:ont00001985</a>
    /// </summary>
    let ont00001985 = _prefixId.prefix "ont00001985"
    /// <summary>
    ///   <para>rdfs:label : has output</para>
    ///   <para>skos:definition : x has output y =Def y is output of x.</para>
    ///   <para>cco:ont00001754 : https://en.wikipedia.org/w/index.php?title=IPO_model&amp;oldid=1024398398^^xsd:anyURI</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001986">mro:ont00001986</a>
    /// </summary>
    let ont00001986 = _prefixId.prefix "ont00001986"
    /// <summary>
    ///   <para>rdfs:label : has daughter</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001987">mro:ont00001987</a>
    /// </summary>
    let ont00001987 = _prefixId.prefix "ont00001987"
    /// <summary>
    ///   <para>rdfs:label : is uncle of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001988">mro:ont00001988</a>
    /// </summary>
    let ont00001988 = _prefixId.prefix "ont00001988"
    /// <summary>
    ///   <para>rdfs:label : has nontangential part</para>
    ///   <para>skos:definition : x has nontangential part y =Def y nontangential part of x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be transitive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <para>cco:ont00001754 : Randell, D. A., Cui, Z. and Cohn, A. G.: 1992, "A spatial logic based on regions and connection," Proc. 3rd Int. Conf. on Knowledge Representation and Reasoning, Morgan Kaufmann, San Mateo, pp. 165-176. Available at: https://www.dpi.inpe.br/gilberto/references/cohn_rcc.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001989">mro:ont00001989</a>
    /// </summary>
    let ont00001989 = _prefixId.prefix "ont00001989"
    /// <summary>
    ///   <para>rdfs:label : instant is before</para>
    ///   <para>skos:definition : x instant_is_before y iff x and y are both instances of Zero Dimensional Temporal Region and there exists some instance of Temporal Interval z such that x is the starting instant of z and y is the ending instant of z.</para>
    ///   <para>skos:scopeNote : 'instant is before' is a primitive relationship. Informally, a temporal instant x is before some temporal instant y iff x precedes y.</para>
    ///   <para>cco:ont00001754 : J. F. Allen and J. A. G. M. Koomen. Planning using a temporal world model. In Proceedings of the 8th International Joint Conference on Artificial Intelligence (IJCAI-1983)  pages 741–747. Available at: https://www.ijcai.org/Proceedings/83-2/Papers/036.pdf</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001990">mro:ont00001990</a>
    /// </summary>
    let ont00001990 = _prefixId.prefix "ont00001990"
    /// <summary>
    ///   <para>rdfs:label : is made of</para>
    ///   <para>skos:definition : An object o is made of an object m when m is the material that o consists of and that material does not undergo a change of kind during the creation of o</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001991">mro:ont00001991</a>
    /// </summary>
    let ont00001991 = _prefixId.prefix "ont00001991"
    /// <summary>
    ///   <para>rdfs:label : has organizational context</para>
    ///   <para>skos:definition : x has organizational context y =Def y is organizational context of x.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001992">mro:ont00001992</a>
    /// </summary>
    let ont00001992 = _prefixId.prefix "ont00001992"
    /// <summary>
    ///   <para>rdfs:label : sends</para>
    ///   <para>skos:definition : x sends y iff x is an instance of Agent and y is an instance of Act Of Communication, such that x is the initiator and encoder of the InformationContentEntity intended for communication in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001993">mro:ont00001993</a>
    /// </summary>
    let ont00001993 = _prefixId.prefix "ont00001993"
    /// <summary>
    ///   <para>rdfs:label : is paternal aunt of</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001994">mro:ont00001994</a>
    /// </summary>
    let ont00001994 = _prefixId.prefix "ont00001994"
    /// <summary>
    ///   <para>rdfs:label : is parent of</para>
    ///   <para>skos:definition : x is_parent_of y is a familial relationship between an instance of Person x and a different instance of Person y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001995">mro:ont00001995</a>
    /// </summary>
    let ont00001995 = _prefixId.prefix "ont00001995"
    /// <summary>
    ///   <para>rdfs:label : is step-sibling of</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be symmetric. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001996">mro:ont00001996</a>
    /// </summary>
    let ont00001996 = _prefixId.prefix "ont00001996"
    /// <summary>
    ///   <para>rdfs:label : is reference system of</para>
    ///   <para>skos:definition : x is_reference_system_of y iff y is an instance of Information Bearing Entity and x is an instance of Reference System, such that x describes the set of standards mentioned in y.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001997">mro:ont00001997</a>
    /// </summary>
    let ont00001997 = _prefixId.prefix "ont00001997"
    /// <summary>
    ///   <para>rdfs:label : is permitted by</para>
    ///   <para>skos:definition : x is permitted by y =Def y permits x.</para>
    ///   <para>skos:scopeNote : Given a stronger temporal interpretation, this property may be asymmetric and irreflexive. For more info please refer to https://github.com/BFO-ontology/BFO-2020/tree/master/src/owl/temporal%20extensions.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00001998">mro:ont00001998</a>
    /// </summary>
    let ont00001998 = _prefixId.prefix "ont00001998"
    /// <summary>
    ///   <para>rdfs:label : process has first instant</para>
    ///   <para>skos:definition : x process_has_first_instant y Def= x is a Process, y is a Temporal Instant, and there is some Temporal Region z such that y is first_instant_of z, and x occupies_temporal_region z.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00002080">mro:ont00002080</a>
    /// </summary>
    let ont00002080 = _prefixId.prefix "ont00002080"
    /// <summary>
    ///   <para>rdfs:label : process has last instant</para>
    ///   <para>skos:definition : x process_has_last_instant y Def= x is a Process, y is a Temporal Instant, and there is some Temporal Region z such that y is last_instant_of z, and x occupies_temporal_region z.</para>
    ///   <a href="https://www.commoncoreontologies.org/mro/ont00002081">mro:ont00002081</a>
    /// </summary>
    let ont00002081 = _prefixId.prefix "ont00002081"
