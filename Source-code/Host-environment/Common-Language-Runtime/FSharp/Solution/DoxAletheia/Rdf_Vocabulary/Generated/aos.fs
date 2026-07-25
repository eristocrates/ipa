namespace http.aims.fao.org.aos.agrontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aos =
    let _namespace_iri = Namespace_Iri aos |> NamespaceIRI
    /// <summary>
    ///   <para>aos:RangeOfHasTermType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#RangeOfHasTermType">http://aims.fao.org/aos/agrontology#RangeOfHasTermType</seealso>
    let RangeOfHasTermType = Prefixed_Name(aos, "RangeOfHasTermType") |> PrefixedName
    /// <summary>
    ///   <para>aos:isActedUponBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is acted upon by</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isActedUponBy">http://aims.fao.org/aos/agrontology#isActedUponBy</seealso>
    let isActedUponBy = Prefixed_Name(aos, "isActedUponBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>س &lt;يؤثر على&gt; ع. أي إجراء من العامل س يؤدي إلى تغيير حالة أو موقع ع
    /// على سبيل المثال: "نضوب المياه" &lt;يؤثر على&gt; "منسوب المياه الجوفية"
    /// "الضرر الميكانيكي" &lt;يؤثر على&gt; "جودة النقل"
    /// لا تستخدم للأمراض أو الاضطرابات. لهؤلاء استخدم &lt;afflicts / isAfflictedBy&gt;.</para>
    ///   <para>X &lt;affects&gt; Y. Action of agent X changes the state or location of Y. E.g. "water depletion" &lt;affects&gt; "groundwater table", "mechanical damage" &lt;affects&gt; “transporting quality”. Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;. </para>
    ///   <para>X &lt;afecta&gt; Y. La acción del agente X cambia el estado o la ubicación de Y. Ej. "Agotamiento del agua" &lt;afecta&gt; "Capa freática", "Daños mecánicos" &lt;afecta&gt; "Aptitud para el transporte". No lo utilice para enfermedades o trastornos; para ellos, utilice &lt;aflige/está afligido por&gt;. </para>
    ///   <para>X&lt;影响&gt; Y。媒介X的行为改变Y的状态或位置。例如：“水枯竭”&lt;影响&gt; “地下水位”，“机械损伤”&lt;影响&gt; “运输性能”。请勿用于疾病或病症；对于疾病和病症，使用&lt;损害/受...损害&gt;。</para>
    ///   <para>X &lt;влияет на&gt; Y. Действие агента X изменяет состояние или местоположение Y. Например, "истощение водных ресурсов" &lt;влияет на&gt; "уровень грунтовых вод", "механические повреждения" &lt;влияют на&gt; "пригодность к транспортировке". Не используйте для болезней или расстройств; для них используйте &lt;поражает/на ... негативно влияет болезнь .....&gt;. </para>
    ///   <para>X &lt;affecte&gt; Y. L'agent X agit sur l'objet Y de telle sorte que Y change d'état ou de localisation. Par exemple, "tarissement" &lt;affecte&gt; "nappe souterraine",  "dégât mécanique" &lt;affecte&gt; "aptitude au transport". Ne l'utilisez pas pour des maladies ou des désordres : pour ceux-là, utilisez &lt;afflige/est affligé par&gt;.</para>
    /// labels<para>влияет на</para><para>Affecte</para><para>Affects</para><para>Afecta</para><para>يؤثر</para><para>影响</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#affects">http://aims.fao.org/aos/agrontology#affects</seealso>
    let affects = Prefixed_Name(aos, "affects") |> PrefixedName
    /// <summary>
    ///   <para>aos:afflicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;поражает&gt; Y. Болезнь или расстройство X может иметь негативные последствия для Y, например, отрицательно повлиять на здоровье организма или части тела Y. Например, "скрейпи" &lt;поражает&gt; "овцы", "глоссит" &lt;поражает&gt; "язык".</para>
    ///   <para>X &lt;afflicts&gt; Y. The disease or disorder X could have negative effects in Y, such as adversely affect the health of an organism or body part Y. E.g. "scrapie" &lt;afflicts&gt; "sheep", “glossitis” &lt;afflicts&gt; “tongue”.</para>
    ///   <para>X &lt;afflige&gt; Y. La maladie ou le désordre X pourrait avoir des effets négatifs sur Y, tels que nuire à la santé d'un organisme ou d'une partie du corps Y. Par exemple, "tremblante" &lt;afflige&gt; "mouton", "glossite" &lt;afflige&gt; "langue". </para>
    ///   <para>X&lt;损伤&gt;Y。疾病或病症X可能对Y造成负面影响，如对生物体或身体部分Y的健康造成不利影响。例如：“羊瘙痒病”&lt;损伤&gt;“绵羊”，“舌炎”&lt;损伤&gt;“舌”。</para>
    ///   <para>X &lt;aflige&gt; Y. La enfermedad o el trastorno X podría tener efectos negativos en Y, como por ejemplo, afectar negativamente a la salud de un organismo o una parte del cuerpo Y. Ej. "Scrapie" &lt;aflige&gt; "Ovinos", “Glositis” &lt;aflige&gt; “Lengua”.</para>
    ///   <para>س &lt; يصيب &gt; ع. يمكن أن يكون للمرض أو الاضطراب س آثار سلبية في ع. مثل التأثير سلبًا على صحة كائن حي أو جزء من الجسم ع
    /// على سبيل المثال "مرض سكرابي" &lt;يصيب&gt; "الخروف" ،
    ///  "التهاب اللسان" &lt;يصيب&gt; "اللسان".  </para>
    /// labels<para>Afflicts</para><para>поражает</para><para>Afflige</para><para>لهجمات</para><para>Aflige</para><para>损伤</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#afflicts">http://aims.fao.org/aos/agrontology#afflicts</seealso>
    let afflicts = Prefixed_Name(aos, "afflicts") |> PrefixedName
    /// <summary>
    ///   <para>aos:isAfflictedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Y &lt;поражается&gt; болезнью X. На здоровье или благополучие организма или части тела Y может негативно повлиять болезнь X. Например,  "медоносные пчелы" &lt;поражается&gt; "варроатоз",  "язык" &lt;поражается&gt; "глоссит".</para>
    ///   <para>Y &lt;est affligé par&gt; X. La santé ou le bien-être d'un organisme ou d'une partie du corps Y pourrait être affecté par la maladie ou le désordre X. Par exemple, "abeille domestique" &lt;est affligé par&gt; "varroase", "langue" &lt;est affligé par&gt; "glossite".</para>
    ///   <para>Y &lt;está afligido por&gt; X. La salud o el bienestar de un organismo o parte del cuerpo Y podría verse afectado negativamente por la enfermedad X. Ej.  "Abeja melífera" &lt;está afligido por&gt; "Varroosis", "Lengua" &lt;está afligido por&gt; "Glositis". </para>
    ///   <para>Y &lt;is afflicted by&gt; X. The health or wellbeing of an organism or body part Y could adversely be affected by the disease X. E.g. "honey bees" &lt;is afflicted by&gt; "varoosis", "tongue" &lt;is afflicted by&gt; "glossitis". </para>
    ///   <para>ع &lt; يصاب بـ &gt; س. يمكن أن تتأثر صحة أو رفاهية كائن حي أو جزء من الجسم ع سلبًا بالمرض س.
    /// "  على سبيل المثال "نحل العسل" &lt;يصاب بـ &gt; "امرض الفاروا" ،
    /// "اللسان" &lt;يصاب بـ&gt; "التهاب اللسان".  </para>
    ///   <para>Y&lt;受...损伤&gt;X。生物体或身体部分Y的健康可能受到疾病X的负面影响。例如：“蜜蜂”&lt;受...损伤&gt;“蜂螨病”，“舌”&lt;受...损伤&gt;“舌炎”。</para>
    /// labels<para>está afligido por</para><para>تتأثر ... بـ ...</para><para>Is afflicted by</para><para>est affligé par</para><para>поражается</para><para>受...损伤</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAfflictedBy">http://aims.fao.org/aos/agrontology#isAfflictedBy</seealso>
    let isAfflictedBy = Prefixed_Name(aos, "isAfflictedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:benefitsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;benefitsFrom&gt; X. A result Y  that is advantageous to some beneficiary, produced by the behaviour of an agent X. A consequence Y achieved through a means X. E.g. "biological control" &lt;benefitsFrom&gt; "biological control arthropods"; "plant health" &lt;benefitsFrom&gt; "pest control";</para>
    /// labels<para>Benefits from</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#benefitsFrom">http://aims.fao.org/aos/agrontology#benefitsFrom</seealso>
    let benefitsFrom = Prefixed_Name(aos, "benefitsFrom") |> PrefixedName
    /// <summary>
    ///   <para>aos:isBeneficialFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;isBeneficialFor&gt; Y. Agent X behaves in a way that produces some result Y that is advantageous to some beneficiary. A means X through which a consequence Y can be achieved. E.g. "biological control arthropods" &lt;isBeneficialFor&gt; "biological control"; "pest control" &lt;isBeneficialFor&gt; "plant health";</para>
    /// labels<para>Is beneficial for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isBeneficialFor">http://aims.fao.org/aos/agrontology#isBeneficialFor</seealso>
    let isBeneficialFor = Prefixed_Name(aos, "isBeneficialFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:isCausedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;está causado por&gt; X. Un resultado Y se produjo debido a un agente X (animado o inanimado). Ej. "Encefalopatía espongiforme" &lt;está causado por&gt; "Prione", "Marchitamiento" &lt;está causado por&gt; "Déficit de humedad en el suelo".</para>
    ///   <para>Y &lt;вызывается&gt; X. Результат Y произошел из-за агента X (одушевленного или неодушевленного). Например, "губчатая энцефалопатия" &lt;вызывается&gt; "прионы", "увядание" &lt;вызывается&gt; "дефицит влажности почвы". </para>
    ///   <para>Y&lt;由...引起&gt;X。结果Y由于媒介X（生物或非生物）而发生。例如：“海绵状脑病”&lt;由...引起&gt;“朊病毒”，“萎蔫”&lt;由...引起&gt;“土壤水分亏缺”。</para>
    ///   <para>Y &lt;is caused by&gt; X. A result Y occurred because of an agent X (animate or inanimate). E.g. "spongiform encephalopathy" &lt;is caused by&gt; “prions”, "soil moisture deficit” &lt;is caused by&gt; "wilting".</para>
    ///   <para>Y &lt;est causée par&gt; X. Un résultat Y s'est produit à cause d'un agent X (animé ou inanimé). Par exemple, "encéphalopathie spongiforme" &lt;est causée par&gt; "prion", "fanaison" &lt;est causée par&gt; "déficit d'humidité du sol". </para>
    ///   <para>ع &lt;سببه&gt; س. النتيجة ع تحدث بسبب العامل س (الحي أو غير الحي)
    /// على سبيل المثال: "الاعتلال الدماغي الاسفنجي" &lt;سببه&gt; "البريونات"
    /// الذبول" &lt;سببه&gt; "النقص في رطوبة التربة"</para>
    /// labels<para>Está causado por</para><para>Est causée par</para><para>Is caused by</para><para>вызывается</para><para>هو سبب</para><para>由...引起</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isCausedBy">http://aims.fao.org/aos/agrontology#isCausedBy</seealso>
    let isCausedBy = Prefixed_Name(aos, "isCausedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:compose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;compone&gt; X. Y es el material o sustancia de la que se compone X. Ej. Par exemple, "Flora microbiana" &lt;compone&gt; "Flora del suelo", "Materiales volcánicos" &lt;compone&gt; "Toba".</para>
    ///   <para>ع &lt;يؤلف&gt; س. ع هي الأداة أو المادة التي تتكون منها س.
    /// على سبيل المثال: "النباتات الجرثومية" &lt;تؤلف &gt; "نباتات التربة"
    /// "مواد بركانية" &lt;تؤلف&gt; " صخر tuff"
    /// </para>
    ///   <para>Y &lt;compose&gt; X. Y is the material or substance of which X is composed. E.g. “microbial flora” &lt;compose&gt; "soil flora", “volcanic materials” &lt;compose&gt; "tuff".</para>
    ///   <para>Y &lt;compose&gt; X. Y est le matériau ou la substance dont X est composé. Par exemple, "flore microbienne" &lt;compose&gt; "flore du sol", "matériau volcanique" &lt;compose&gt; "tuff".</para>
    ///   <para>Y -  &lt;то, из чего состоит&gt; X. Y - это материал или вещество, из которого состоит X. Например, "микробная флора" - &lt;то, из чего состоит&gt;  "почвенная флора", "вулканогенные материалы" - &lt;то, из чего состоит&gt;  "туф (вулканический).</para>
    ///   <para>Y&lt;组成&gt;X。Y是组成X的材料或物质。例如：“微生物菌群”&lt;组成&gt;“土壤植物区系”，“火山灰物质”&lt;组成&gt;“凝灰岩”。</para>
    /// labels<para>то, из чего состоит</para><para>تتكون Y من </para><para>Compone</para><para>Compose</para><para>Compose</para><para>组成</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#compose">http://aims.fao.org/aos/agrontology#compose</seealso>
    let compose = Prefixed_Name(aos, "compose") |> PrefixedName
    /// <summary>
    ///   <para>aos:isControlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>Is controlled by</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isControlledBy">http://aims.fao.org/aos/agrontology#isControlledBy</seealso>
    let isControlledBy = Prefixed_Name(aos, "isControlledBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:developsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>Develops from</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#developsFrom">http://aims.fao.org/aos/agrontology#developsFrom</seealso>
    let developsFrom = Prefixed_Name(aos, "developsFrom") |> PrefixedName

    /// <summary>
    ///   <para>aos:temporalRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>Temporal relations</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#temporalRelationship">http://aims.fao.org/aos/agrontology#temporalRelationship</seealso>
    let temporalRelationship =
        Prefixed_Name(aos, "temporalRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:developsInto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Develops into</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#developsInto">http://aims.fao.org/aos/agrontology#developsInto</seealso>
    let developsInto = Prefixed_Name(aos, "developsInto") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTaxonomicConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;has taxonomic concept&gt; Y.  X is a common name concept for an organism or organism group. Y is the scientifically defined concept name for the same organism or a group of organisms, having a specific taxonomic rank. E.g. “honey bees” &lt;has taxonomic concept&gt; ”Apis mellifera”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;. </para>
    ///   <para>X &lt;имеет таксономическое понятие&gt; Y. X - это обиходное название для организма или группы организмов. Y - это научно определенное название понятия для того же организма или группы организмов, имеющее определенный таксономический ранг. Например, "медоносные пчелы" &lt;имеет таксономическое понятие&gt; "Apis mellifera". Используется на уровне понятий, когда обиходное название и научное название являются отдельными понятиями. Для связи между метками в пределах понятия используйте &lt;имеет научное название /является научным названием&gt;. </para>
    ///   <para>س &lt;لها مفهوم تصنيفي&gt; ع. س هو مفهوم الاسم الشائع لكائن أو مجموعة الكائن. ع هو اسم المفهوم المحدد علمياً لنفس الكائن الحي أو لمجموعة من الكائنات ، لها رتبة تصنيفية محددة.
    /// على سبيل المثال "نحل العسل" &lt;له مفهوم التصنيف&gt; "Apis mellifera".
    /// يستخدم على مستوى المفهوم عندما يكون الاسم الشائع والاسم العلمي مفهومين منفصلين.
    ///  لعلاقة التسمية إلى التسمية للاستخدام ضمن المفهوم ، استخدم &lt;له اسم علمي / اسم علمي لـ&gt;. </para>
    ///   <para>X &lt;tiene concepto taxonómico&gt; Y. X es un concepto de nombre común para un organismo o grupo de organismos. Y es el nombre conceptual definido científicamente para el mismo organismo o grupo de organismos, que tiene un rango taxonómico específico. Por ejemplo, "Abeja melífera" &lt;tiene concepto taxonómico&gt; "Apis mellifera". Se utiliza a nivel de concepto cuando el nombre común y el nombre científico son conceptos separados. Para la relación de etiqueta a etiqueta para su uso dentro de un concepto, utilice &lt;tiene nombre científico / es el nombre científico de&gt;.</para>
    ///   <para>X&lt;有分类学概念&gt;Y。X是某一生物体或生物体组别的常用名概念。Y是同一生物体或生物群的学名概念，有特定的分类等级。 例如：“蜜蜂”&lt;有分类学概念&gt;“Apis mellifera”。当常用名和学名是独立的概念时，在概念层面使用。对于标签间关系，在同一个概念内使用&lt;有学名/是...的学名&gt;。</para>
    ///   <para>X &lt;a concept taxonomique&gt; Y. X est un concept de nom commun pour un organisme ou un groupe d'organismes. Y est le nom de concept scientifiquement défini pour le même organisme ou un groupe d'organismes, ayant un rang taxonomique spécifique. Par exemple, "abeille domestique" &lt;a concept taxonomique&gt; "Apis mellifera". À utiliser au niveau du concept lorsque le nom commun et le nom scientifique sont des concepts distincts. Pour une relation terme à terme à utiliser dans un concept, utilisez &lt;a nom scientifique/ est le nom scientifique&gt;.</para>
    /// labels<para>имеет таксономическое понятие</para><para>Tiene concepto taxonómico</para><para>A concept taxonomique</para><para>Has taxonomic concept</para><para>مفهوم التصنيف</para><para>有分类学概念</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTaxonomicConcept">http://aims.fao.org/aos/agrontology#hasTaxonomicConcept</seealso>
    let hasTaxonomicConcept = Prefixed_Name(aos, "hasTaxonomicConcept") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y&lt;有组成部分&gt;X。物体X是整体Y的一部分，同时也独立于Y存在。例如：“树”&lt;有组成部分&gt;“叶”，“车辆系统”&lt;有组成部分&gt;“发动机”。</para>
    ///   <para>س &lt;يحتوي على&gt; ع. الكائن س هو جزء من ع بالكامل وله أيضاً وجود مستقل عن ع.
    /// على سبيل المثال: "الأشجار" &lt;تحتوي على &gt; "الأوراق"
    /// " منظومات المركبات" &lt;تحتوي على &gt; "المحركات".
    /// </para>
    ///   <para>Y &lt;имеет компонент&gt; X. Объект X, который является частью целого Y и также имеет существование независимо от Y. Например, "деревья" &lt;имеет компонент "листья", "системы машин" &lt;имеет компонент&gt; "двигатели".</para>
    ///   <para>Y &lt;tiene componente&gt; X. Un objeto X que es una parte de un todo Y y tiene también una existencia independiente de Y. Ex. Par exemple, "Árboles" &lt;tiene componente&gt; "Hojas", "Componentes del vehículo" &lt;tiene componente&gt; "Motores". </para>
    ///   <para>Y &lt;a le composant&gt; X. Un objet X qui fait partie d'un Y entier et a également une existence indépendamment de Y. Par exemple, "arbre" &lt;a le composant&gt; "feuille", "organe de véhicule" &lt;a le composant&gt; "moteur".</para>
    ///   <para>Y &lt;has component&gt; X. An object X that is a part of a whole Y and also has an existence independently from Y. E.g. "trees" &lt;has component&gt; "leaves",  "vehicle systems" &lt;has component&gt; "engines".</para>
    /// labels<para>Tiene componente</para><para>имеет компонент</para><para>A le composant</para><para>Has component</para><para>有组成部分</para><para>مكون</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasComponent">http://aims.fao.org/aos/agrontology#hasComponent</seealso>
    let hasComponent = Prefixed_Name(aos, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasComposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has composition</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasComposition">http://aims.fao.org/aos/agrontology#hasComposition</seealso>
    let hasComposition = Prefixed_Name(aos, "hasComposition") |> PrefixedName

    /// <summary>
    ///   <para>aos:partitiveRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Superpropiedad de las relaciones partitivas</para>
    ///   <para>Суперсвойство для партитивных отношений</para>
    ///   <para>所有整体部分关系的父类属性</para>
    ///   <para>Super-property for partitive relationships</para>
    ///   <para>خاصية فائقة للعلاقات الجزئية</para>
    ///   <para>Super-propriété pour les relations partitives</para>
    /// labels<para>Partitive relationship</para><para>Relaciones partitivas</para><para>партитивные отношения</para><para>Relations partitives</para><para>العلاقات الجزئية</para><para>整体部分关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#partitiveRelationship">http://aims.fao.org/aos/agrontology#partitiveRelationship</seealso>
    let partitiveRelationship =
        Prefixed_Name(aos, "partitiveRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:isCompositionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is composition of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isCompositionOf">http://aims.fao.org/aos/agrontology#isCompositionOf</seealso>
    let isCompositionOf = Prefixed_Name(aos, "isCompositionOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasControlMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has control method</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasControlMethod">http://aims.fao.org/aos/agrontology#hasControlMethod</seealso>
    let hasControlMethod = Prefixed_Name(aos, "hasControlMethod") |> PrefixedName
    /// <summary>
    ///   <para>aos:isControlMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is control method of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isControlMethodOf">http://aims.fao.org/aos/agrontology#isControlMethodOf</seealso>
    let isControlMethodOf = Prefixed_Name(aos, "isControlMethodOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCropingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has cropping system</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCropingSystem">http://aims.fao.org/aos/agrontology#hasCropingSystem</seealso>
    let hasCropingSystem = Prefixed_Name(aos, "hasCropingSystem") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;has disease&gt; Y. Organism X can have disease Y. E.g. “Sorghum” &lt;has disease&gt; “loose smut of sorghum”. Organism to disease relationship.
    /// </para>
    ///   <para>س &lt;لديه مرض&gt; ع. يمكن أن يكون لدى الكائن س المرض ع.
    /// على سبيل المثال: "الذرة الرفيعة" &lt;لديها مرض&gt; "تفحم الذرة الرفيعة".
    /// علاقة الكائن الحي بالمرض.</para>
    ///   <para>X &lt;имеет болезнь&gt; Y. Организм X может иметь болезнь Y. Например, “Sorghum” &lt;имеет болезнь&gt; “мелкопузырчатая головня сорго”. Отношения между организмом и болезнью.
    /// </para>
    ///   <para> X &lt;a la maladie&gt; Y. L'organisme X peut avoir la maladie Y. Par exemple, "Sorghum" &lt;a la maladie&gt; "charbon nu du sorgho" . Relation entre l'organisme et la maladie.</para>
    ///   <para>X&lt;有疾病&gt;Y。生物体X可能会有疾病Y。例如：“高粱属”&lt;有疾病&gt;“高粱散黑粉病”。生物体-疾病关系。</para>
    ///   <para>X &lt;tiene la enfermedad&gt; Y. El organismo X puede tener la enfermedad Y. Ej.  "Sorghum” &lt;tiene la enfermedad&gt; “Carbón suelto del sorgo”. Relación organismo-enfermedad.</para>
    /// labels<para>Tiene la enfermedad</para><para>имеет болезнь</para><para>A la maladie</para><para>Has disease</para><para>لديه مرض</para><para>有疾病</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasDisease">http://aims.fao.org/aos/agrontology#hasDisease</seealso>
    let hasDisease = Prefixed_Name(aos, "hasDisease") |> PrefixedName
    /// <summary>
    ///   <para>aos:isDiseaseFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;является болезнью для&gt; X. Болезнь Y является болезнью организма X. Например, "мелкопузырчатая головня сорго" &lt;является болезнью для&gt; "Sorghum". Отношения между болезнью и организмом.</para>
    ///   <para>ع هو &lt;مرض&gt; س. المرض ع هو مرض الكائن س.
    /// على سبيل المثال: "تفحم الذرة الرفيعة" هو &lt;مرض&gt; "الذرة".
    /// علاقة المرض بالكائن الحي.</para>
    ///   <para>Y &lt;est maladie de&gt; X. La maladie Y est un maladie de l'organisme X. Par exemple, "charbon nu du sorgho" &lt;est maladie de&gt; "Sorghum". Relation entre la maladie et l'organisme.</para>
    ///   <para>Y &lt;is disease for&gt; X. Disease Y is disease of organism X. E.g. “loose smut of sorghum”&lt;is disease for&gt; “Sorghum". Disease to organism relationship.</para>
    ///   <para>Y&lt;是...的疾病&gt;X。疾病Y是生物体X的疾病。例如：“高粱散黑粉病”&lt;是...的疾病&gt;“高粱属”。疾病-生物体关系。</para>
    ///   <para>Y &lt;es la enfermedad por&gt; X. La enfermedad Y es enfermedad del organismo X. Ej. "Carbón suelto del sorgo” &lt;es la enfermedad por&gt; “Sorghum". Relación entre la enfermedad y el organismo.</para>
    /// labels<para>является болезнью для</para><para>Es la enfermedad por</para><para>Est maladie de</para><para>Is disease for</para><para>是...的疾病</para><para>هو مرض</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isDiseaseFor">http://aims.fao.org/aos/agrontology#isDiseaseFor</seealso>
    let isDiseaseFor = Prefixed_Name(aos, "isDiseaseFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasDisorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has disorder</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasDisorder">http://aims.fao.org/aos/agrontology#hasDisorder</seealso>
    let hasDisorder = Prefixed_Name(aos, "hasDisorder") |> PrefixedName
    /// <summary>
    ///   <para>aos:isAchievedByMeansOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;يتم تحقيقه عن طريق&gt; س . ع  هو هدف أو عملية يستخدمها س ، دون أن يكون ع بالضرورة جزءاً من س.
    /// على سبيل المثال اضطراب التزاوج "&lt;يتحقق عن طريق&gt;" نظائر الفرمون "  ،
    ///  "إتخاذ القرار" &lt;يتم تحقيقه عن طريق&gt; "نظام دعم القرار".</para>
    ///   <para>Y &lt;se consigue por medio de&gt; X. Y es un objetivo o proceso utilizado por X, sin que Y sea necesariamente parte de X. Ej. “Confusión sexual” &lt;se consigue por medio de&gt; “Feromonas sintéticas”, “Toma de decisiones” &lt;se consigue por medio de&gt; “Sistemas de apoyo a las decisiones”. </para>
    ///   <para>Y&lt;通过…手段实现&gt;X。Y是X的目标或是X使用的过程，不一定是X的一部分。例如：“交配干扰”&lt;通过…手段实现&gt;“信息素类似物”，“决策”&lt;通过…手段实现&gt;“决策支持系统”。</para>
    ///   <para>Y &lt;is achieved by means of&gt; X. Y is an objective or process used by X, without Y necessarily being part of X. E.g. “mating disruption” &lt;is achieved by means of&gt; “pheromone analogues”, “decision making” &lt;is achieved by means of&gt; “decision support systems”.</para>
    ///   <para>Y &lt;est réalisée au moyen de&gt;X. Y est un objectif ou un processus utilisé par X, sans que Y fasse nécessairement partie de X. Par exemple : "confusion sexuelle" &lt;est réalisée au moyen de&gt; "analogue phéromone", "prise de décision" &lt;est réalisée au moyen de&gt; "système d'aide à la décision".</para>
    ///   <para>Y &lt;достигается с помощью&gt; X. Y  это цель или процесс, используемый X, при этом Y не обязательно является частью X. Например, "нарушение спаривания" &lt;достигается с помощью&gt; "аналоги феромонов", "принятие решений" &lt;достигается с помощью&gt; "системы поддержки принятия решений".</para>
    /// labels<para>Se consigue por medio de</para><para>Est réalisée au moyen de</para><para>Is achieved by means of</para><para>достигается с помощью</para><para>يتم تحقيقه عن طريق</para><para>通过…手段实现</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAchievedByMeansOf">http://aims.fao.org/aos/agrontology#isAchievedByMeansOf</seealso>
    let isAchievedByMeansOf = Prefixed_Name(aos, "isAchievedByMeansOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;a le vecteur ou l'hôte&gt; Y.  X a un organisme hôte ou un vecteur Y. Par exemple, "Plasmodium" &lt;A le vecteur ou l'hôte&gt; "Anopheles". </para>
    ///   <para>X&lt;有寄主&gt;Y。X有生物寄主或传播媒介Y。例如：“疟原虫属”&lt;有寄主&gt;“按蚊属” 。</para>
    ///   <para>X &lt;tiene huesped u vector&gt; Y. X tiene el organismo huésped o vector Y. Ej. “Plasmodium” &lt;tiene huesped u vector&gt; ”Anopheles”.</para>
    ///   <para>س &lt;لديه ناقل أو مضيف&gt; ع. س لديه الكائن الحي الناقل أو المضيف ع.
    /// على سبيل المثال: "المتصورة" &lt;لديها المضيف&gt; "بعوضة الملاريا".</para>
    ///   <para>X &lt;has vector or host&gt; Y.  X has organism host or vector  Y.  E.g. “Plasmodium” &lt;has host&gt; ”Anopheles”.</para>
    ///   <para>X &lt;имеет переносчика или хозяина&gt; Y. X имеет организм-хозяина или организм-переносчика Y. Например, "Plasmodium" &lt;имеет переносчика или хозяина&gt; "Anopheles".</para>
    /// labels<para>имеет переносчика или хозяина</para><para>A le vecteur ou l'hôte </para><para>Tiene huésped u vector</para><para>Has vector or host </para><para>لديه مضيف</para><para>有寄主</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasHost">http://aims.fao.org/aos/agrontology#hasHost</seealso>
    let hasHost = Prefixed_Name(aos, "hasHost") |> PrefixedName
    /// <summary>
    ///   <para>aos:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;является членом&gt; Y. Социальная или политическая единица (группа или индивид) X принадлежит к социальной или политической группе Y. Например, "бенин" &lt;является членом&gt; "франкоязычная африка", "рабочие пчелы" &lt;является членом&gt; "пчелиные семьи". Ограничьте использование географическими/социально-политическими единицами, не используйте для группировки организмов (например, по использованию, климату или таксономическому рангу).</para>
    ///   <para>X &lt;is member of&gt; Y. A social or political unit (group or individual) X belongs to a social or political group Y. E.g. "Benin" &lt;is member of&gt; "Francophone Africa", "worker bees" &lt;is member of&gt; "bee colonies". Limit use to geographical or socio-political units, do not use for grouping organisms (e.g. by use, climate, or taxonomic rank). Use &lt;includes/included in&gt; if describing spatial or temporal relation, but more loose than &lt;is part of.&gt;</para>
    ///   <para>س &lt;هو عضو في&gt; ع. تنتمي الوحدة الاجتماعية أو السياسية (مجموعة أو فرد) س إلى مجموعة اجتماعية أو سياسية ع
    /// على سبيل المثال: "Benin" &lt;هي عضو في&gt; " إفريقيا الناطقة بالفرنسية"
    /// "النحلات العاملات" &lt;هي عضو &gt; "مستعمرات النحل".
    /// قصر الاستخدام على الوحدات الجغرافية / الاجتماعية السياسية.
    /// لا تستخدم لتجميع الكائنات الحية حسب الاستخدام أو المناخ أو الترتيب التصنيفي.
    /// استخدم &lt;تتضمن&gt; / &lt;مضمن في&gt; إذا كنت تصف العلاقة المكانية أو الزمنية ، إذا كانت فضفاضة أكثر يستخدم &lt;جزء من&gt;.</para>
    ///   <para> X &lt;est membre de&gt; Y: est membre de. Une unité sociale ou politique (groupe ou individu) X appartient à un groupe social ou politique Y. Par exemple, "Bénin" &lt;est membre de&gt; "Afrique francophone", "abeille ouvrière" &lt;est membre de&gt; "colonie d'abeilles". Limiter l'utilisation aux unités géographiques/socio-politiques, ne pas utiliser pour regrouper des organismes (par exemple, par utilisation, climat ou rang taxonomique). </para>
    ///   <para> X &lt;es miembro de&gt; Y. Una unidad social o política (grupo o individuo) X pertenece a un grupo social o político Y. Ej. "Benin" &lt;es miembro de&gt; "Africa de habla francesa", "Abejas obreras" &lt;es miembro de&gt; "Colonia de abejas".  Limitar el uso a unidades geográficas/sociopolíticas. No utilizar para agrupar organismos por uso, clima o rango taxonómico.</para>
    ///   <para>X&lt;是...的成员&gt;Y。社会或政治单位（团体或个人）X属于社会或政治团体Y。例如：“贝宁”&lt;是...的成员&gt;“法语非洲”，“工蜂”&lt;是...的成员&gt;“蜜蜂群”。限用于地理/社会政治单位。请勿用于对生物体进行分组（如按用途、气候或分类等级）。对于空间或时间关系，使用&lt;包含/包含于&gt;，但比&lt;有部分/是...的部分&gt;更为松散。</para>
    /// labels<para>Est membre de  </para><para>является членом</para><para>Es miembro de</para><para>Is member of</para><para>هو عضو في</para><para>是...的成员</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isMemberOf">http://aims.fao.org/aos/agrontology#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(aos, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasNaturalEnemy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has natural enemy</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasNaturalEnemy">http://aims.fao.org/aos/agrontology#hasNaturalEnemy</seealso>
    let hasNaturalEnemy = Prefixed_Name(aos, "hasNaturalEnemy") |> PrefixedName
    /// <summary>
    ///   <para>aos:isObjectOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;является объектом деятельности&gt; X. Y является центром деятельности X. Например, "шерсть" &lt;является объектом деятельности&gt; "стрижка", "пакты" &lt;является объектом деятельности&gt; "ратификация".</para>
    ///   <para>X&lt;是活动...的对象&gt;Y。概念X是活动Y关注的对象。例如：“羊毛”&lt;是活动...的对象&gt;“剪毛”，“条约”&lt;是活动...的对象&gt;“批准”。</para>
    ///   <para>Y &lt;is object of activity&gt; X. Y is the focus of activity X.  E.g. “wool” &lt;is object of activity&gt; "shearing”, “treaties" &lt;is object of activity&gt; “ratification”.</para>
    ///   <para>ع &lt;هو هدف النشاط&gt; س . ع هو محور النشاط س.
    /// على سبيل المثال "الصوف" &lt;هو محور&gt; "الجز" ،
    ///  "المعاهدات" &lt;هي محور &gt; "التصديق".</para>
    ///   <para>Y &lt;es objeto de la actividad&gt; X. La actividad Y tiene como foco el concepto X. Ej. “Lana” &lt;es objeto de la actividad&gt; "Esquileo”, “Tratados" &lt;es objeto de la actividad&gt; “Ratificación”. </para>
    ///   <para>Y &lt;est l'objet de l'activité&gt; X. Y est le centre de l'activité X. Par exemple, “laine" &lt;est l'objet de l'activité&gt; "tonte", “traité” &lt;est l'objet de l'activité&gt; “ratification”.</para>
    /// labels<para>является объектом деятельности</para><para>Es objeto de la actividad</para><para>Est l'objet de l'activité</para><para>Is object of activity</para><para>هو محور النشاط</para><para>是活动...的对象</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isObjectOfActivity">http://aims.fao.org/aos/agrontology#isObjectOfActivity</seealso>
    let isObjectOfActivity = Prefixed_Name(aos, "isObjectOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasOldName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;tiene nombre antiguo&gt; Y. Se utiliza para etiquetas obsoletas , como nombres antiguos de países. Por ejemplo, "Bulgaria" &lt;tiene nombre antiguo&gt; "República Popular de Bulgaria". Usar sólo entre etiquetas para el mismo concepto en un idioma específico.
    /// </para>
    ///   <para>X &lt;a nom ancien&gt; Y. À utiliser pour les étiquettes obsolètes, comme les anciens noms de pays. Par exemple, “Bulgaria”&lt;a nom ancien&gt;”République populaire de Bulgarie”. Utilisez uniquement entre les termes pour le même concept dans une langue spécifique. </para>
    ///   <para>X &lt;has old name&gt; Y. Use for obsolete labels, such as old names of countries. E.g. “Bulgaria”&lt;has old name&gt;”People’s Republic of Bulgaria”. Use only between labels for the same concept in a specific language.</para>
    ///   <para>X&lt;有曾用名&gt;Y。用于过时的标签，如国家的旧名。例如：“保加利亚”&lt;有曾用名&gt;“保加利亚人民共和国”。限用于同一概念某一特定语言的不同标签。</para>
    ///   <para>س &lt;له الاسم القديم&gt; ع. يستخدم للتسميات القديمة ، مثل الأسماء القديمة للبلدان
    /// على سبيل المثال:  "بلغاريا" &lt;لها الاسم القديم&gt; "جمهورية بلغاريا الشعبية"
    /// تستخدم فقط بين التسميات لنفس المفهوم بلغة معينة.
    /// </para>
    ///   <para>X &lt;имеет старое название&gt; Y. Используется для устаревших обозначений, например, старых названий стран. Например, "Болгария" &lt;имеет старое название&gt; "Народная Республика Болгария". Используется только между обозначениями для одного и того же понятия на определенном языке.</para>
    /// labels<para>имеет старое название</para><para>tiene nombre antiguo</para><para>Has old name</para><para>a nom ancien</para><para>له اسم قديم</para><para>有曾用名</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasOldName">http://aims.fao.org/aos/agrontology#hasOldName</seealso>
    let hasOldName = Prefixed_Name(aos, "hasOldName") |> PrefixedName
    /// <summary>
    ///   <para>aos:usesProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;utilise le processus&gt; Y. X utilise une ou plusieurs actions, activités, méthodes Y comme processus. Par exemple, "culture d'hiver" &lt;utilise le processus&gt; "vernalisation", “mise en conserve” &lt;utilise le processus&gt; "stérilisation (germes)”.</para>
    ///   <para>X&lt;使用过程&gt;Y。X使用一个或多个行动、活动、方法Y作为其过程。例如：“越冬作物”&lt;使用过程&gt;“春化”，“罐藏”&lt;使用过程&gt;“灭菌”。</para>
    ///   <para>X &lt;использует процесс&gt; Y. X использует одно или несколько действий, мероприятий, методов Y в качестве процесса. Например, “озимые культуры” &lt;использует процесс&gt; “яровизация”, “консервирование в герметичной таре” &lt;использует процесс&gt; “обеззараживание”.</para>
    ///   <para>X &lt;uses process&gt; Y. X uses one or more actions, activities, methods Y as a process. E.g. “winter crops” &lt;uses process&gt; “vernalization”, “canning” &lt;uses process&gt; “sterilizing”.</para>
    ///   <para>س &lt;يستخدم العملية&gt; ع. يستخدم س واحدًا أو أكثر من الإجراءات والأنشطة والطرق للعملية ع.
    /// على سبيل المثال “محاصيل شتوية” &lt;تستخدم عملية&gt; “التنشيط بالبرد“,
    ///  “التعليب” &lt;يستخدم عملية&gt; “التعقيم”.</para>
    ///   <para> X &lt;utiliza el proceso&gt; Y. Una o varias acciones, actividades, métodos X que producen un cambio o desarrollo Y. Ej. "Cultivos de invierno" &lt;utiliza el proceso&gt; "Vernalización", “Envasado” &lt;utiliza el proceso&gt; "Esterilización”. </para>
    /// labels<para>Utilise le processus</para><para>использует процесс </para><para>Utiliza el proceso</para><para>يستخدم العملية</para><para>Uses process</para><para>使用过程</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#usesProcess">http://aims.fao.org/aos/agrontology#usesProcess</seealso>
    let usesProcess = Prefixed_Name(aos, "usesProcess") |> PrefixedName
    /// <summary>
    ///   <para>aos:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;производится&gt; Y. Ограничьте использование естественными процессами (такими, как растущие на растениях плоды, яйца, молоко), а также химическими процессами. Например, "мед" &lt;производится&gt; "медоносные пчелы", "картофель (клубни)" &lt;производится&gt; "Solanum tuberosum". Однако "сыры" &lt;является продуктом&gt; " сыроделие".</para>
    ///   <para>X &lt;es producido por&gt; Y. Restringir el uso a los procesos naturales (como los frutos que crecen en las plantas, los huevos, la leche), pero también a los procesos químicos.   Ej. “Miel” &lt;es producido por&gt; “Abeja melífera”, “Papa” &lt;es producido por&gt; “Solanum tuberosum".  Pero, “Queso” &lt;producto de&gt; “Fabricación del queso”.</para>
    ///   <para>X &lt;est produit par&gt; Y. Restreindre l'utilisation aux processus naturels (tels que les fruits poussant sur les plantes, les œufs, le lait) - mais aussi les processus chimiques. Par exemple, "miel" &lt;est produit par&gt; "abeille domestique", "pomme de terre" &lt;est produit par&gt; "Solanum tuberosum". Cependant, "fromage" &lt;produit de&gt; "fabrication du fromage". </para>
    ///   <para>X&lt;由...生产&gt;Y。限用于自然过程（如长在植物上的水果，蛋类，牛奶），也可用于化学过程。例如：“蜂蜜”&lt;由...生产&gt;“蜜蜂”，“马铃薯”&lt;由...生产&gt;“阳芋”。但是，“干酪”&lt;是...的产品&gt;“奶酪制作”。</para>
    ///   <para>س &lt;يُنتج من قبل&gt; ع. تقييد الاستخدام للعمليات الطبيعية (مثل الفاكهة التي تنمو على النباتات والبيض والحليب) - ولكن أيضًا العمليات الكيميائية
    /// على سبيل المثال: "العسل" &lt;يُنتج من قبل&gt; "نحل العسل"
    /// البطاطا &lt;يُنتج من قبل&gt; "Solanum tuberosum"
    /// ومع ذلك ، "الجبن" &lt;هو نتاج&gt; "صناعة الجبن". </para>
    ///   <para>X &lt;is produced by&gt; Y. Restrict use to natural processes (such as fruits growing on plants, eggs, milk) - but also chemical processes. E.g. “honey” &lt;is produced by&gt; “honey bees”, “potatoes” &lt;is produced by&gt; “Solanum tuberosum". However, “cheese” &lt;product of&gt; “cheese-making”.</para>
    /// labels<para>Es producido por</para><para>Est produit par</para><para>Is produced by</para><para>производится</para><para>من إنتاج</para><para>由...生产</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isProducedBy">http://aims.fao.org/aos/agrontology#isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(aos, "isProducedBy") |> PrefixedName

    /// <summary>
    ///   <para>aos:isSpatiallyIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;est spatialement inclus dans&gt; X. La région Y est une partie spatiale inaliénable de la région spatiale X. Par exemple, "eaux continentales africaines" &lt;est spatialement inclus dans&gt; "Afrique", "Pérou" &lt;est spatialement inclus dans&gt; "région andine". </para>
    ///   <para>Y &lt;se incluye espacialmente en&gt; X. La región Y es una parte espacial inalienable de la región espacial X. Ej. "Aguas interiores de África" &lt;se incluye espacialmente en&gt; "África", "Perú" &lt;se incluye espacialmente en&gt; "Región andina".</para>
    ///   <para>Y&lt;空间包含于&gt;X。空间区域Y是空间区域X不可分割的空间部分。例如：“非洲大陆水体”&lt;空间包含于&gt;“非洲”，“秘鲁”&lt;空间包含于&gt;“安第斯山脉地区”。</para>
    ///   <para>Y &lt;пространственно включен в&gt; X. Пространственная область Y является неотъемлемой пространственной частью пространственной области X. Например, "внутренние воды Африки" &lt;пространственно включен в&gt; "Африка", "Перу" &lt;пространственно включен в&gt; "Андский регион".</para>
    ///   <para>Y &lt;is spatially included in&gt; X. Spatial region Y is an inalienable spatial part of spatial region X. E.g. "African inland waters" &lt;is spatially included in&gt; "Africa", "Peru" &lt;is spatially included in&gt; "Andean region".</para>
    ///   <para>ع &lt;مُدرج مكانياً في&gt; س. المنطقة المكانية ع هي جزء مكاني غير قابل للتصرف من المنطقة المكانية س.
    /// على سبيل المثال: "المياه الداخلية الإفريقية" &lt;مدرجة مكانيًا في&gt; "إفريقيا" ،
    /// و "البيرو" &lt;مدرجة مكانيًا في&gt; "منطقة الأنديز". </para>
    /// labels<para>Est spatialement inclus dans</para><para>Se incluye espacialmente en</para><para>пространственно включен в</para><para>Is spatially included in</para><para>مدرج مكانيًا في</para><para>空间包含于</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedIn">http://aims.fao.org/aos/agrontology#isSpatiallyIncludedIn</seealso>
    let isSpatiallyIncludedIn =
        Prefixed_Name(aos, "isSpatiallyIncludedIn") |> PrefixedName

    /// <summary>
    ///   <para>aos:isSpatiallyIncludedInCity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Is spatially included in city</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInCity">http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInCity</seealso>
    let isSpatiallyIncludedInCity =
        Prefixed_Name(aos, "isSpatiallyIncludedInCity") |> PrefixedName

    /// <summary>
    ///   <para>aos:isSpatiallyIncludedInState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Is spatially included in state</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInState">http://aims.fao.org/aos/agrontology#isSpatiallyIncludedInState</seealso>
    let isSpatiallyIncludedInState =
        Prefixed_Name(aos, "isSpatiallyIncludedInState") |> PrefixedName

    /// <summary>
    ///   <para>aos:isStudiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>س &lt;تُدرس من قبل&gt; ع. يتم دراسة المفهوم س حسب المجال أو العلم أو المجموعة ع.
    /// على سبيل المثال "علم الحفريات" &lt;تمت دراسته من قبل&gt; "علماء الحفريات"
    /// "ظروف العمل" &lt;تمت دراستها من قبل&gt;" بيئة العمل</para>
    ///   <para>X &lt;изучается&gt; Y. Понятие X изучается областью знаний, наукой или группой людей Y. Например, "палеонтология" &lt;изучается&gt; "палеонтологи", "условия труда" &lt;изучается&gt; "эргономика".</para>
    ///   <para>X&lt;被...研究&gt;Y。概念X是领域、科学或组群Y的研究对象。例如：“古生物学”&lt;被...研究&gt;“古生物学家”，“工作条件”&lt;被...研究&gt;“人机工程学”。</para>
    ///   <para>X &lt;es estudiado por &gt; Y. El concepto X es estudiado por el campo, la ciencia o el grupo Y. Ej. “Paleontología” &lt;es estudiado por&gt; "Paleontólogos”, “Condiciones de trabajo” &lt;es estudiado por&gt; “Ergonomía”.
    /// </para>
    ///   <para>X &lt;est étudié par&gt; Y. Le concept X est étudié par domaine, science ou groupe Y. Par exemple, "paléontologie" &lt;est étudié par&gt; "paléontologue", "condition de travail" &lt;est étudié par&gt; "ergonomie".</para>
    ///   <para>X &lt;is studied by&gt; Y. Concept X is studied by field, science or group Y. E.g. “palaeontology”&lt;is studied by&gt; "palaeontologists”, “working conditions” &lt;is studied by&gt; “ergonomics”.</para>
    /// labels<para>Es estudiado por </para><para>Est étudié par </para><para>Is studied by
    /// </para><para>تدرس من قبل</para><para>&lt;изучается&gt;</para><para>被...研究</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isStudiedBy">http://aims.fao.org/aos/agrontology#isStudiedBy</seealso>
    let isStudiedBy = Prefixed_Name(aos, "isStudiedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:isUseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;es el uso de&gt; X.  Ej. "Edulcorantes" &lt;es el uso de&gt; '"Sorbitol",  "Combustibles" &lt;es el uso de&gt; "Etánol".</para>
    ///   <para>Y &lt;是使用&gt; X.  例如 : "甜味剂" &lt;是使用&gt; '"山梨醇",  "燃料" &lt;是使用&gt; "乙醇".</para>
    ///   <para>Y &lt;est l'utilisation de&gt; X.  Par exemple:  "édulcorant" &lt;est l'utilisation de&gt; "sorbitol",  "combustible" &lt;est l'utilisation de&gt; "éthanol".</para>
    ///   <para>Y &lt;is use of&gt; X.  For example, "sweeteners" &lt;is use of&gt; '"sorbitol",  "fuels" &lt;is use of&gt; "ethanol".</para>
    ///   <para>Y &lt;это использование&gt; X.  Например,   "подсластители" &lt;это использование&gt; "стевиозид",  "топливо" &lt;это использование&gt; "этанол".  </para>
    ///   <para>Y &lt;هو استخدام&gt; X: "محليات" &lt;هو استخدام&gt; '"سربتول"</para>
    /// labels<para>Est l'utilisation de</para><para>это использование</para><para>Es el uso de</para><para>هو استخدام</para><para>Is use of</para><para>是使用</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isUseOf">http://aims.fao.org/aos/agrontology#isUseOf</seealso>
    let isUseOf = Prefixed_Name(aos, "isUseOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:isUsedAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;用作&gt; Y. 例如 :  "山梨醇" &lt;用作&gt; "甜味剂"; "乙醇" &lt;用作&gt; "燃料".</para>
    ///   <para> X  &lt;مستعمل ك&gt; Y: "سربتول" &lt;مستعمل ك&gt; "محليات"; "إيثانول" &lt;مستعمل ك&gt; "وقود".</para>
    ///   <para>X &lt;se utiliza como&gt; Y. Ej. "Sorbitol" &lt;se utiliza como&gt; "Edulcorantes"; "Etánol" &lt;se utiliza como&gt; "Combustibles".</para>
    ///   <para>X &lt;is used as&gt; Y. E.g. "sorbitol" &lt;is used as&gt; "sweetener"; "ethanol" &lt;is used as&gt; "fuel".</para>
    ///   <para>X &lt;направлен на&gt; Y. X направлен на цель или процесс Y. Например, "ветеринарные услуги" &lt;направлен на&gt; "здоровье животных", "рубки обновления" &lt;направлен на&gt;  "естественное возобновление".</para>
    ///   <para>X &lt;est utilisé comme&gt; Y. Par exemple: "sorbitol" &lt;est utilisé comme&gt; "édulcorant"; "éthanol" &lt;est utilisé comme&gt; "combustible".</para>
    /// labels<para>Est utilisé comme</para><para>используется как</para><para>Se utiliza como</para><para>Is used as</para><para>مستعمل ك</para><para>用作</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isUsedAs">http://aims.fao.org/aos/agrontology#isUsedAs</seealso>
    let isUsedAs = Prefixed_Name(aos, "isUsedAs") |> PrefixedName
    /// <summary>
    ///   <para>aos:isUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;est utilisé dans&gt; Y.  X est habituellement utilisé dans Y, il est normal d'utiliser X dans la pratique de Y. Par exemple, "boyau" &lt;est utilisé dans&gt; "saucisse", "train" &lt;est utilisé dans&gt; "transport ferroviaire".</para>
    ///   <para>X &lt;es utilizado en&gt; Y. X se usa habitualmente en Y, es normal usar X en la práctica de Y.  Ej. "Tripa" &lt;es utilizado en&gt; "Salchicha", "Trenes" &lt;es utilizado en&gt; "Transporte por ferrocarriles". </para>
    ///   <para>X &lt;is used in&gt; Y. X is habitually used in Y, it is normal to use X in the practice of Y. E.g. “casings” &lt;is used in&gt; “sausages”, “trains” &lt;is used in&gt; “rail transport”.</para>
    ///   <para>س &lt;يستخدم في&gt; ع.
    /// يتم استخدام س عادة في ع ، ومن الطبيعي استخدام س في ممارسة ع
    /// على سبيل المثال: "الأغلفة" تستخدم في "النقانق"
    /// "القطارات" تستخدم في "النقل بالسكك الحديدية"</para>
    ///   <para>X &lt;используется в&gt; Y. X обычно используется в Y, нормально использовать X при обращении с Y. Например, "экструдеры"  &lt;используется в&gt; "экструзия", "фильтры"  &lt;используется в&gt; "сепараторы".</para>
    ///   <para>X&lt;被用于&gt;Y。 X习惯性地被用于Y中，在做法Y中通常使用X。例如：“肠衣”&lt;被用于&gt;“香肠”，“火车”&lt;被用于&gt;“铁路运输”。</para>
    /// labels<para>Est utilisé dans</para><para>Es utilizado en</para><para>используется в</para><para>Is used in</para><para>يستخدم في</para><para>被用于</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isUsedIn">http://aims.fao.org/aos/agrontology#isUsedIn</seealso>
    let isUsedIn = Prefixed_Name(aos, "isUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>aos:makeUseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;fait usage de&gt; X. L'activité Y utilise le processus ou l'intrant X. Par exemple, "navigation" &lt;fait usage de&gt; "aide à la navigation", "agriculture de précision" &lt;fait usage de&gt; "système d'information géographique", "transport ferroviaire" &lt;fait usage de&gt; "train".</para>
    ///   <para>Y&lt;利用&gt;X。活动Y使用过程或投入物X。例如：“航海”&lt;利用&gt;“导航设备”，“精准农业”&lt;利用&gt;“地理信息系统”，“铁路运输”&lt;利用&gt;“火车”。</para>
    ///   <para>Y &lt;hace uso de&gt; X. La actividad Y utiliza el proceso o la entrada X. Ej. "Navegación" &lt;hace uso de&gt; "Ayuda a la navegación", "Agricultura de precisión" &lt;hace uso de&gt; "Sistemas de información geográfica", "Transporte por ferrocarrilese" &lt;hace uso de&gt; "Trenes". </para>
    ///   <para>Y &lt;make use of&gt; X. Activity Y makes use of process or input X. E.g. “navigation” &lt;make use of&gt; ”navigational aids”, “precision agriculture” &lt;make use of&gt; ”geographical information systems”, “rail transport” &lt;make use of&gt; “trains”.</para>
    ///   <para>Y &lt;использует&gt; X. Действие Y использует процесс, оборудование или данные X. Например,  "навигация" &lt;использует&gt; "навигационное оборудование", "точное сельское хозяйство" &lt;использует&gt; "географические информационные системы",  "сварка" &lt;использует&gt; "сварочное обрудование".</para>
    ///   <para>ع  &lt;يستفد من&gt; س. يستفيدالنشاط ع من العملية أو الإدخال س.
    ///  على سبيل المثال "لملاحة" &lt;تستفيد من&gt; "المساعدات الملاحية"،
    /// "الزراعة الدقيقة " &lt;تستفيد من&gt; "نظم المعلومات الجغرافية".
    /// "النقل بالسكك الحديدية" &lt;تستفيد من&gt; " القطارات"</para>
    /// labels<para>Fait usage de</para><para>Hace uso de</para><para>Make use of</para><para>использует</para><para>يستفاد من</para><para>利用</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#makeUseOf">http://aims.fao.org/aos/agrontology#makeUseOf</seealso>
    let makeUseOf = Prefixed_Name(aos, "makeUseOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:m49Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Стандарт ООН M.49 (англ. UN M.49) — стандарт для кодов регионов, используемый ООН для статистических целей, разработанный и поддерживаемый Статистическим отделом ООН</para>
    ///   <para>UN M49 or the Standard Country or Area Codes for Statistical Use (Series M, No. 49) is a standard for area codes used by the United Nations for statistical purposes, developed and maintained by the United Nations Statistics Division.</para>
    ///   <para>UN M49 o Códigos de país o área estándar para fines estadísticos (serie M, nº 49) es un estándar para los códigos de área utilizados por las Naciones Unidas con fines estadísticos, desarrollado y mantenido por la División de Estadística de las Naciones Unidas.</para>
    ///   <para>UN M49  أو معيار البلد أو رموز المنطقة للاستخدام الإحصائي
    ///   (السلسلة M، رقم 49) هو معيار لرموز المنطقة التي تستخدمها الأمم المتحدة للأغراض الإحصائية وتطويرها والتي تحتفظ بها شعبة الإحصاءات في الأمم المتحدة. </para>
    ///   <para>联合国M49，即统计用标准国家或地区代码（M系列，第49号）是联合国用于统计目的的地区代码标准，由联合国统计司制定和维护。</para>
    ///   <para>UN M49 ou les codes de pays ou de zone standard à usage statistique (série M, n ° 49) est une norme pour les codes de zone utilisés par les Nations Unies à des fins statistiques, développée et maintenue par la Division de statistique des Nations Unies.</para>
    /// labels<para>Código M49</para><para>M49 code</para><para>Code M49</para><para>UN M49</para><para>M.49</para><para>M49码</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#m49Code">http://aims.fao.org/aos/agrontology#m49Code</seealso>
    let m49Code = Prefixed_Name(aos, "m49Code") |> PrefixedName
    /// <summary>
    ///   <para>aos:spellingVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has spelling variant</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#spellingVariant">http://aims.fao.org/aos/agrontology#spellingVariant</seealso>
    let spellingVariant = Prefixed_Name(aos, "spellingVariant") |> PrefixedName
    /// <summary>
    ///   <para>aos:surroundedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;rodeado de&gt; Y. El objeto X está físicamente rodeado por el objeto Y. Ej. “Pupa” &lt;rodeado de&gt; “Capullos“, "Endosperma” &lt;rodeado de&gt; “Células de aleurona". Utilizar sólo para los términos que son físicamente adyacentes entre sí. Para la geografía, utilice  &lt;se incluye espacialmente en&gt;.
    /// </para>
    ///   <para>X &lt;est entouré par&gt; Y. L'objet X est physiquement entouré par l'objet Y. Par exemple, "pupe" &lt;est entouré par&gt; "cocon", "endosperme" &lt;est entouré par&gt; "cellule à aleurone". Utiliser uniquement pour les termes qui sont physiquement immédiatement adjacents à chacun autre. Pour la géographie, utilisez  &lt;est spatialement inclus dans&gt;.</para>
    ///   <para>X &lt;surrounded by&gt; Y. The object X is physically surrounded by object Y. E.g. “pupae” &lt;surrounded by&gt; “cocoons“, "endosperm” &lt;surrounded by&gt; “aleurone cells". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;is spatially included in&gt;.</para>
    ///   <para>X &lt;окружен&gt; Y. Объект X физически окружен объектом Y. Например, "куколки" &lt;окружен&gt; "коконы", "эндосперм" &lt;окружен&gt; "алейроновые клетки". Используйте только для терминов, которые физически непосредственно примыкают друг к другу. Для географии используйте &lt;пространственно включен в&gt;.</para>
    ///   <para>X&lt;被...围绕&gt;Y。物体X在物理上被物体Y围绕。例如：“蛹”&lt;被...围绕&gt;“茧”，“胚乳”&lt;被...围绕&gt;“糊粉细胞”。仅可用于物理上彼此紧邻的术语。对于地理，使用&lt;空间包含于&gt;。</para>
    ///   <para>س &lt;مُحاط بـ &gt; ع. الكائن س محاط فيزيائياً بالكائن ع.
    /// على سبيل المثال: "الخادرة" &lt;محاطة بـ&gt; "الشرانق" ،
    /// و "السويداء" &lt;محاطة بـ&gt; "خلايا ألورون".
    /// تستخدم فقط للمصطلحات المتاخمة فعلياً لبعضها البعض. للاستخدام الجغرافي &lt;مدرج مكانيًا في&gt;. </para>
    /// labels<para>Est entouré par</para><para>Surrounded by</para><para>Rodeado de</para><para>وتحيط به</para><para>окружен</para><para>被...围绕</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#surroundedBy">http://aims.fao.org/aos/agrontology#surroundedBy</seealso>
    let surroundedBy = Prefixed_Name(aos, "surroundedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:surrounds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;окружает&gt; X. Объект Y физически окружает объект X. Например, "коконы" &lt;окружает&gt; "куколки", "алейроновые клетки" &lt;окружает&gt; "эндосперм". Используйте только для терминов, которые физически непосредственно примыкают друг к другу. Для географии используйте &lt;пространственно включает&gt;.</para>
    ///   <para>Y &lt;entoure&gt; X. L'objet Y entoure physiquement l'objet X. Par exemple,"cocon" &lt;entoure&gt; "pupe", "cellule à aleurone" &lt;entoure&gt; "endosperme". À utiliser uniquement pour les termes qui sont physiquement immédiatement adjacents les uns aux autres.  Pour la géographie, utilisez &lt;spatialement inclut&gt;.</para>
    ///   <para>ع &lt;يحيط بـ &gt; س. الكائن ع يحيط فيزيائياً بالكائن س.
    /// على سبيل المثال: "الشرانق" &lt;تحيط بـ&gt; "الخادرة" ،
    /// و "خلايا ألورون" &lt;تحيط بـ&gt; "السويداء".
    /// تستخدم فقط للمصطلحات المتاخمة فعلياً لبعضها البعض. للاستخدام الجغرافي &lt;يشمل مكانيًا&gt;. </para>
    ///   <para>Y&lt;围绕&gt;X。物体Y在物理上围绕物体X。例如：“茧”&lt;围绕&gt;“蛹”，“糊粉细胞”&lt;围绕&gt;“胚乳”。仅可用于物理上彼此紧邻的术语。对于地理，使用&lt;空间包含&gt;。</para>
    ///   <para>Y &lt;surrounds&gt; X. The object Y is physically surrounding object X. E.g. “cocoons” &lt;surrounds&gt; “pupae“, "aleurone cells” &lt;surrounds&gt; “endosperm". Use only for the terms that are physically immediately adjacent to each other. For geography use &lt;spatially Includes&gt;.</para>
    ///   <para>Y &lt;alrededor de&gt; X. El objeto Y rodea físicamente al objeto X. Ej. ”Capullos" &lt;alrededor de&gt; “Pupa“, "Células de aleurona” &lt;alrededor de&gt; “Endosperma". Utilizar sólo para los términos que son físicamente adyacentes entre sí. Para la geografía, utilice  &lt;incluye espacialmente&gt;.</para>
    /// labels<para>Alrededor de</para><para>Surrounds</para><para>окружает</para><para>Entoure</para><para>يحيط</para><para>围绕</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#surrounds">http://aims.fao.org/aos/agrontology#surrounds</seealso>
    let surrounds = Prefixed_Name(aos, "surrounds") |> PrefixedName
    /// <summary>
    ///   <para>aos:usingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A concept that make use of a specific value.</para>
    /// labels<para>Using value</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#usingValue">http://aims.fao.org/aos/agrontology#usingValue</seealso>
    let usingValue = Prefixed_Name(aos, "usingValue") |> PrefixedName
    /// <summary>
    ///   <para>aos:valueUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A measure or other value used in a specific activity or methods or for any purpose.</para>
    /// labels<para>Value used in</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#valueUsedIn">http://aims.fao.org/aos/agrontology#valueUsedIn</seealso>
    let valueUsedIn = Prefixed_Name(aos, "valueUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>aos:isPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Y &lt;является частью&gt; X. X состоит из одной или нескольких частей, где Y - одна часть. Например, "кортекс" &lt;является частью&gt; "стебли", "корневые узелки" &lt;является частью&gt; "корни". Используйте это отношение, когда ни одно из других низших партитивных отношений (&lt;состоит из&gt;, &lt;hasMember&gt;) не применимо.</para>
    ///   <para> Y &lt;es parte de&gt; X. X está compuesto por una o más partes, donde Y es una parte. Ej. "Cortex" &lt;es parte de&gt; "Tallos", "Nudosidades radiculares" &lt;es parte de&gt; "Raíces". Utilice esta relación cuando no se aplique ninguna de las otras relaciones partitivas inferiores (&lt;está compuesto de&gt;, &lt;tiene miembro&gt;). </para>
    ///   <para>ع &lt;هو جزء من&gt; س. يتكون س من جزء واحد أو أكثر ، حيث ع جزء واحد.
    /// على سبيل المثال: "القشرة" &lt;هي جزء من&gt; "الساق"
    /// "عقد الجذور" &lt;هي جزء من&gt; "الجذور"
    /// استخدم هذه العلاقة عندما لا تنطبق أي من العلاقات الجزئية السفلية الأخرى ( &lt;مكون من&gt;، &lt;لديه عضو&gt; )</para>
    ///   <para> Y&lt;是...的部分&gt;X。X由一个或多个部分组成，其中包括Y。例如：“皮层”&lt;是...的部分&gt;“茎”，“根节结”&lt;是...的部分&gt;“根”。 用于其他下位整体部分关系（&lt;有组成部分&gt;，&lt;是...的组成部分&gt;，&lt;有成员&gt;）都不适用时。</para>
    ///   <para>Y &lt;fait partie de&gt; X. X est composé d'une ou plusieurs parties, où Y est une partie. Par exemple, "cortex" &lt;fait partie de&gt; "tige", "nodosité racinaire" &lt;fait partie de&gt; "racine". Utilisez cette relation lorsqu'aucune des autres relations de partition inférieure (&lt;est composé de&gt;, &lt;a un membre&gt;) ne s'applique.</para>
    ///   <para> Y &lt;is part of&gt; X. X is composed of one or more parts, where Y is one part. E.g. “cortex” &lt;is part of&gt; “stems”, “root nodules” &lt;is part of&gt; “roots". Use this relationship when none of the other lower partitive relations (&lt;is composed of&gt;, &lt;has member&gt;) apply. </para>
    /// labels<para>является частью</para><para>Fait partie de</para><para>Es parte de</para><para>وهو جزء من</para><para>Is part of</para><para>是...的部分</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPartOf">http://aims.fao.org/aos/agrontology#isPartOf</seealso>
    let isPartOf = Prefixed_Name(aos, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:formerlyIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An inclusion that was valid in the past but currently is not valid anymore.</para>
    /// labels<para>Formerly included in</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#formerlyIncludedIn">http://aims.fao.org/aos/agrontology#formerlyIncludedIn</seealso>
    let formerlyIncludedIn = Prefixed_Name(aos, "formerlyIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>aos:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>س &lt;يتضمن&gt; ع. س هو كيان يتضمن العنصر ع
    /// على سبيل المثال: "طرق رعاية الحيوان" &lt;تتضمن&gt; "عملية إزالة القرون"
    /// "تحليل المياه" &lt;تتضمن&gt; " تخصيص الموارد"</para>
    ///   <para>X&lt;包含&gt;Y。实体X包含元素Y。例如：“家畜饲养方法”&lt;包含&gt;“断角术”，“水分析”&lt;包含&gt;“微生物分析”。</para>
    ///   <para>X &lt;включает&gt; Y. X - это сущность, которая включает элемент Y. Например,
    /// "методы выращивания и содержания животных" &lt;включает&gt; "удаление рогов", "анализ воды" &lt;включает&gt; "микробиологический анализ".</para>
    ///   <para>X &lt;includes&gt; Y. X is an entity that includes the element Y. For example: “animal husbandry methods” &lt;includes&gt; ”dehorning”, “water analysis” &lt;includes&gt; ”microbiological analysis”.</para>
    ///   <para>X &lt;incluye&gt; Y. X es una entidad que incluye el elemento Y. Ej.
    /// "Métodos de crianza" &lt;incluye&gt; "Descorne", " Análisis de agua" &lt;incluye&gt; "Análisis microbiológico".</para>
    ///   <para>X &lt;comprend&gt; Y. X est une entité qui inclut l'élément Y. Par exemple, "méthode d'élevage" &lt;comprend&gt; "écornage", "analyse de l'eau" &lt;comprend&gt; "analyse microbiologique".</para>
    /// labels<para>Comprend</para><para>Includes</para><para>включает</para><para>Incluye</para><para>يشمل</para><para>包含</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#includes">http://aims.fao.org/aos/agrontology#includes</seealso>
    let includes = Prefixed_Name(aos, "includes") |> PrefixedName

    /// <summary>
    ///   <para>aos:quantitativeRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Super-propriété pour les relations quantitatives  Toutes les relations impliquant une quantité ou une mesure.</para>
    ///   <para>所有数量关系的父类属性</para>
    ///   <para>Сверхсвойство для количественных отношений. Все отношения, связанные с количеством или мерой.</para>
    ///   <para>Superpropiedad para las relaciones cuantitativas. Todas las relaciones que implican una cantidad o una medida.</para>
    ///   <para>Super-property for quantitative relationships. All relationships involving a quantity or a measure.</para>
    ///   <para>خاصية فائقة للعلاقات الكمية. كل العلاقات التي تتضمن كمية أو مقياس. </para>
    /// labels<para>Quantitative relationship</para><para>Relations quantitatives </para><para>Relaciones cuantitativas</para><para>количественные отношения</para><para>العلاقات الكمية</para><para>数量关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#quantitativeRelationship">http://aims.fao.org/aos/agrontology#quantitativeRelationship</seealso>
    let quantitativeRelationship =
        Prefixed_Name(aos, "quantitativeRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasAbbreviation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has abbreviation</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasAbbreviation">http://aims.fao.org/aos/agrontology#hasAbbreviation</seealso>
    let hasAbbreviation = Prefixed_Name(aos, "hasAbbreviation") |> PrefixedName
    /// <summary>
    ///   <para>aos:prevents</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;previene&gt; X. Y es un elemento que previene, interrumpe o reduce el daño o perjuicio X. Ej. “Higiene de manos" &lt;previene&gt; “Transmisión de enfermedades”, “Seguridad en el trabajo” &lt;previene&gt; “Riesgos ocupacionales”.</para>
    ///   <para>Y&lt;防止&gt;X。Y可以防止、中断或减少伤害或损害X。例如：“洗手”&lt;防止&gt; “疾病传播”，“工作安全”&lt;防止&gt;“职业危害”。</para>
    ///   <para>Y &lt;prévient&gt; X. Y est un élément qui prévient, interrompt ou réduit les dommages ou dommages X. Par exemple, "lavage des mains" &lt;prévient&gt; "transmission des maladies", "sécurité du travail" &lt;prévient&gt; "risque professionnel".</para>
    ///   <para>Y &lt;предотвращает&gt; X. Y - это элемент, который предотвращает, прерывает или уменьшает вред или ущерб X. Например, "мытье рук" &lt;предотвращает&gt; "передача болезни", "безопасность труда" &lt;предотвращает&gt; "профессиональные риски".</para>
    ///   <para>Y &lt;prevents&gt; X. Y is an element which prevents, interrupts or reduces harm or damage X. E.g. “hand hygiene” &lt;prevents&gt; “disease transmission”, “safety at work”&lt;prevents&gt; “occupational hazards”.</para>
    ///   <para>ع &lt;يمنع&gt; س. ع عنصر يمنع أو يقطع أو يقلل من الضرر أو الضرر س.
    /// على سبيل المثال: "نظافة اليدين" &lt;تمنع&gt; "نقل المرض"،
    ///  "السلامة في العمل" &lt;تمنع&gt; "المخاطر المهنية". </para>
    /// labels<para>предотвращает</para><para>Prevents</para><para>Previene</para><para>Prévient</para><para>يمنع</para><para>防止</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#prevents">http://aims.fao.org/aos/agrontology#prevents</seealso>
    let prevents = Prefixed_Name(aos, "prevents") |> PrefixedName
    /// <summary>
    ///   <para>aos:isProcessFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;является процессом для&gt; X. Одно или несколько действий, мероприятий, методов Y, которые приводят к изменению или развитию X. Например, ”стерилизация” &lt;является процессом для&gt; “выпуск стерильных насекомых”, “спиртовое брожение" &lt;является процессом для&gt; “виноделие".</para>
    ///   <para>Y &lt;est un processus pour&gt; X. Une ou plusieurs actions, activités, méthodes Y qui produisent un changement ou un développement pour X. Par exemple, "stérilisation" &lt;est un processus pour&gt; "lâcher d'insectes stériles", "fermentation alcoolique" &lt;est un processus pour&gt; "vinification". </para>
    ///   <para>Y &lt;is process for&gt; X. One or more actions, activities, methods Y that produce a change or development for X. E.g. ”sterilization” &lt;is process for&gt; “sterile insect release”, “alcoholic fermentation” &lt;is process for&gt; “winemaking”.</para>
    ///   <para>Y &lt;es un proceso para&gt; X. Una o varias acciones, actividades, métodos X que producen un cambio o desarrollo Y. Ej.  "Esterilización (reproducción)" &lt;es un proceso para&gt; "Liberación de insectos estériles", "Fermentación alcohólica" &lt;es un proceso para&gt; "Vinificación". </para>
    ///   <para>ع &lt;هي عملية لـ&gt; س. إجراء واحد أو أكثر ،أنشطة أو طرق من ع تنتج تغييرًا أو تطويرًا لـ س.
    ///  على سبيل المثال ”تعقيم” هي العملية لـ“إطلاق حشرة معقمة",
    ///  "تخمير كحولي” هي العملية لـ “إعداد الخمور”.</para>
    ///   <para>Y&lt;是…的过程&gt;X。一个或多个行动、活动、方法Y造成X的变化或发展。例如：“绝育” &lt;是…的过程&gt;“不孕昆虫释放”，“酒精发酵” &lt;是…的过程&gt;“酿酒”。</para>
    /// labels<para>вляется процессом для</para><para>Est un processus pour</para><para>Es un proceso para</para><para>Is process for</para><para>هي العملية ل</para><para>是…的过程</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isProcessFor">http://aims.fao.org/aos/agrontology#isProcessFor</seealso>
    let isProcessFor = Prefixed_Name(aos, "isProcessFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;производит&gt; X. Например, "медоносные пчелы" &lt;производит&gt; "мед", "Solanum tuberosum" &lt;производит&gt; "картофель (клубни)". Однако "сыроделие" &lt;имеет продукт&gt; "сыры".</para>
    ///   <para>Y &lt;produce&gt; X. E.g. “Abeja melífera” &lt;produce&gt; “Miel”,  “Solanum tuberosum” &lt;produce&gt; "Papa". Pero “Fabricación del queso” &lt;tiene el producto&gt; ”Queso”.</para>
    ///   <para>ع &lt;ينتج&gt; س. .
    /// على سبيل المثال: "نحل العسل" &lt;ينتج&gt; "العسل"،
    /// "Solanum tuberosum"&lt;تنتج&gt; "البطاطا".
    /// ومع ذلك ، فإن "صناعة الجبن" &lt;لها منتج&gt; "جبن". </para>
    ///   <para>Y&lt;生产&gt;X。例如：“蜜蜂”&lt;生产&gt;“蜂蜜”，“阳芋”&lt;生产&gt;“马铃薯”。但是，“奶酪制作”&lt;有产品&gt;“干酪”。</para>
    ///   <para>Y &lt;produces&gt; X. E.g. “honey bees” &lt;produces&gt;“honey”,  “Solanum tuberosum” &lt;produces&gt; "potatoes". However, “cheese-making” &lt;has product&gt;”cheese”.</para>
    ///   <para>Y &lt;produit&gt; X. Ex. "abeille domestique" &lt;produit&gt; "miel", “Solanum tuberosum” &lt;produit&gt; "pomme de terre".  Cependant, "fabrication fromagère" &lt;a le produit&gt; "fromage".</para>
    /// labels<para>производит</para><para>ينتج عنه</para><para>Produces</para><para>Produce</para><para>Produit</para><para>生产</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#produces">http://aims.fao.org/aos/agrontology#produces</seealso>
    let produces = Prefixed_Name(aos, "produces") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasAcronym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;has acronym&gt; Y. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word. E.g. “acquired immunodeficiency syndrome” &lt;has acronym&gt;”AIDS”. </para>
    ///   <para>س &lt;لها الاختصار&gt; ع. الاختصار هو اختصار يتكون من الأحرف الأولى للكلمات الأخرى ، وغالبًا ما يتم نطقه ككلمة.
    /// على سبيل المثال: "متلازمة نقص المناعة المكتسبة" &lt;لها الاختصار&gt; "مرض الايدز".</para>
    ///   <para>X &lt;a l'acronyme&gt; Y. Un acronyme est une abréviation formée des lettres initiales d'autres mots, souvent prononcées comme un mot.  Par exemple, “syndrome d'immunodéficience acquise" &lt;a l'acronyme&gt;”sida (maladie)”. </para>
    ///   <para>X&lt;有缩略语&gt;Y。缩略语由其他单词首字母组成，通常读作一个词。例如：“获得性免疫缺陷综合征”&lt;有缩略语&gt;“艾滋病”。</para>
    ///   <para>X &lt;tiene acrónimo&gt; Y. Un acrónimo es una abreviatura formada por las letras iniciales de otras palabras, a menudo pronunciadas como una palabra. Por ejemplo, "Síndrome de inmunodeficiencia adquirida" &lt;tiene acrónimo&gt; "SIDA". </para>
    ///   <para>X &lt;имеет акроним&gt; Y. Акроним - это аббревиатура, образованная из начальных букв других слов, часто произносимых как одно слово. Например, "синдром приобретенного иммунодефицита" &lt;имеет акроним&gt; "СПИД". </para>
    /// labels<para>Tiene acrónimo</para><para>имеет акроним</para><para>A l'acronyme</para><para>Has acronym</para><para>له اختصار</para><para>有缩略语</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasAcronym">http://aims.fao.org/aos/agrontology#hasAcronym</seealso>
    let hasAcronym = Prefixed_Name(aos, "hasAcronym") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasBiologicalControlAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has biological control agent</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasBiologicalControlAgent">http://aims.fao.org/aos/agrontology#hasBiologicalControlAgent</seealso>
    let hasBiologicalControlAgent =
        Prefixed_Name(aos, "hasBiologicalControlAgent") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasNarrowerSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has narrower synonym</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasNarrowerSynonym">http://aims.fao.org/aos/agrontology#hasNarrowerSynonym</seealso>
    let hasNarrowerSynonym = Prefixed_Name(aos, "hasNarrowerSynonym") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCodeAsfa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Has ASFA code</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeAsfa">http://aims.fao.org/aos/agrontology#hasCodeAsfa</seealso>
    let hasCodeAsfa = Prefixed_Name(aos, "hasCodeAsfa") |> PrefixedName
    /// <summary>
    ///   <para>aos:isPathogenOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y&lt;是...的病原体&gt;X。Y是生物体X的病原体。例如：“Xylella fastidiosa”&lt;是...的病原体&gt;“Olea europaea”。</para>
    ///   <para>Y &lt;est pathogène de&gt; X. Y est l'agent pathogène de l'organisme X. Par exemple, "Xylella fastidiosa" &lt;est pathogène de&gt; "Olea europaea". </para>
    ///   <para>ع &lt;هوالعامل الممرض لـ &gt; س. ع هو العامل الممرض للكائن الحي س.
    /// على سبيل المثال: " Xylella fastidiosa "  هو &lt;العامل الممرض لـ &gt; "Olea europaea "</para>
    ///   <para>Y &lt;является патогеном&gt; X .Y является патогеном организма X. Например, "Xylella fastidiosa" &lt;является патогеном&gt; "Olea europaea".</para>
    ///   <para>Y &lt;es patógeno de&gt; X . Y es un patógeno del organismo X. Ej. "Xylella fastidiosa" &lt;es patógeno de&gt; "Olea europaea".</para>
    ///   <para>Y &lt;is pathogen of&gt; X . Y is pathogen of organism X. E.g. "Xylella fastidiosa" &lt;is pathogen of&gt; "Olea europaea".</para>
    /// labels<para>هو أحد مسببات الأمراض</para><para>является патогеном</para><para>Est pathogène de</para><para>Es patógeno de</para><para>Is pathogen of</para><para>是...的病原体</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPathogenOf">http://aims.fao.org/aos/agrontology#isPathogenOf</seealso>
    let isPathogenOf = Prefixed_Name(aos, "isPathogenOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:pestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Х вредитель Y. Вредитель Х наносит вред организму Y. Например, "Varroa destructor" &lt;вредитель&gt; "Apis mellifera".</para>
    ///   <para>س &lt;هي آفة&gt; ع. الآفة س تسبب ضرراً للكائن الحي ع.
    /// على سبيل المثال  "Varroa destructor"  &lt;هي آفة&gt;  "Apis mellifera" </para>
    ///   <para>X &lt;es una plaga de&gt; Y. La plaga X causa daños al organismo Y. Ej. "Varroa destructor" &lt;es una plaga de&gt; "Apis mellifera".</para>
    ///   <para>X &lt;pest of&gt; Y. Pest X causes harm to organism Y. E.g. "Varroa destructor" &lt;pest of&gt; "Apis mellifera".</para>
    ///   <para>X&lt;是...的有害生物&gt;Y。有害生物 X对生物体Y造成损害。例如：“Varroa destructor”&lt;是...的有害生物&gt;“西方蜜蜂”。</para>
    ///   <para>X &lt;est peste de&gt; Y. Le ravageur X cause des dommages à l'organisme Y. Les ravageurs sont des insectes, des nématodes et des rongeurs qui causent des dommages. Par ex. "Varroa destructor" &lt;est peste de&gt; "Apis mellifera". </para>
    /// labels<para>Es una plaga de</para><para>Is a pest of</para><para>Est peste de</para><para>是...的有害生物</para><para>вредитель</para><para>هي الآفة</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#pestOf">http://aims.fao.org/aos/agrontology#pestOf</seealso>
    let pestOf = Prefixed_Name(aos, "pestOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPhysiologicalFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has physiological function</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPhysiologicalFunction">http://aims.fao.org/aos/agrontology#hasPhysiologicalFunction</seealso>
    let hasPhysiologicalFunction =
        Prefixed_Name(aos, "hasPhysiologicalFunction") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;имеет продукт&gt; Y. X является источником продукта Y, с элементом переработки. Например, "брожение" &lt;имеет продукт&gt; "ферментированные продукты", "Испания" &lt;имеет продукт&gt; "херес".</para>
    ///   <para>س &lt;لديه المنتج&gt; ع. س هو مصدر المنتج ع مع عنصر معالجة.
    /// على سبيل المثال: "قطع الجذور" &lt;لديه المنتج&gt; "نفايات قطع الأخشاب"
    /// اسبانيا &lt;لديها المنتج&gt; الخمر شيري</para>
    ///   <para>X&lt;有产品&gt;Y。X是产品Y的来源，其中有加工处理的要素。例如：“森林采运”&lt;有产品&gt;“砍伐损失”，“ 西班牙”&lt;有产品&gt;“雪利酒”。</para>
    ///   <para> X &lt;a le produit&gt; Y. X est la source du produit Y, avec un élément de traitement. Par exemple: "exploitation forestière" &lt;a le produit&gt; "déchet d'exploitation forestière",  "Espagne" &lt;a le produit&gt; "xérès".</para>
    ///   <para>X &lt;tiene el producto&gt; Y. X es la fuente del producto Y, con un elemento de procesamiento. Ej. “Aprovechamiento de la madera” &lt;tiene el producto&gt; “Residuos de explotación forestal”, “España” &lt;tiene el producto&gt; “Jerez”.</para>
    ///   <para>X &lt;has product&gt; Y. X is the source of product Y, with a processing element. E.g. “logging”&lt;has product&gt; “logging wastes”, “Spain” &lt;has product&gt; “sherry”.</para>
    /// labels<para>Tiene el producto</para><para>имеет продукт</para><para>A le produit</para><para>لديه المنتج</para><para>Has product</para><para>有产品</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasProduct">http://aims.fao.org/aos/agrontology#hasProduct</seealso>
    let hasProduct = Prefixed_Name(aos, "hasProduct") |> PrefixedName
    /// <summary>
    ///   <para>aos:actsUpon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Acts upon</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#actsUpon">http://aims.fao.org/aos/agrontology#actsUpon</seealso>
    let actsUpon = Prefixed_Name(aos, "actsUpon") |> PrefixedName

    /// <summary>
    ///   <para>aos:causativeRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Сверхсвойство для причинно-следственных связей</para>
    ///   <para>Super-property for causative relationships</para>
    ///   <para>خاصية فائقة للعلاقات السببية</para>
    ///   <para>所有引起关系的父类属性</para>
    ///   <para>Super-propriété pour les relations causales </para>
    ///   <para>Superpropiedad de las relaciones causales</para>
    /// labels<para>причинно-следственная связь</para><para>Causative relationship</para><para>Relaciones causales </para><para>Relations causales </para><para>العلاقات السببية</para><para>引起关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#causativeRelationship">http://aims.fao.org/aos/agrontology#causativeRelationship</seealso>
    let causativeRelationship =
        Prefixed_Name(aos, "causativeRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasChemicalFormula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has chemical formula</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasChemicalFormula">http://aims.fao.org/aos/agrontology#hasChemicalFormula</seealso>
    let hasChemicalFormula = Prefixed_Name(aos, "hasChemicalFormula") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasCodeFishery3Alpha</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Has fishery 3 alpha code</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeFishery3Alpha">http://aims.fao.org/aos/agrontology#hasCodeFishery3Alpha</seealso>
    let hasCodeFishery3Alpha =
        Prefixed_Name(aos, "hasCodeFishery3Alpha") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasCodeTaxonomic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Has taxonomic code</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeTaxonomic">http://aims.fao.org/aos/agrontology#hasCodeTaxonomic</seealso>
    let hasCodeTaxonomic = Prefixed_Name(aos, "hasCodeTaxonomic") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasCommonNameConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;tiene nombre común del concepto&gt; X. Y es un concepto definido científicamente para un organismo o un grupo de organismos con nombre científico como etiquetas, que tiene un rango taxonómico específico. "Apis mellifera" &lt;tiene nombre común del concepto&gt; "Abeja melífera". Se utiliza a nivel de concepto cuando el nombre común y el nombre científico son conceptos separados. Para la relación de etiqueta a etiqueta para su uso dentro de un concepto, utilice &lt;tiene nombre científico / es el nombre científico de&gt;.
    /// </para>
    ///   <para>Y &lt;has common name concept&gt; X. Y is a scientifically defined concept for an organism or a group of organisms with scientific name as labels, having a specific taxonomic rank. "Apis mellifera” &lt;has common name concept&gt; “honey bees”. Use at concept level when common name and scientific name are separate concepts. For label-to-label relationship for use within a concept, use &lt;has scientific name / scientific name of&gt;.
    /// </para>
    ///   <para>Y &lt;имеет обиходное название&gt; X. Y - это научно определенное понятие для организма или группы организмов с научным названием в качестве меток, имеющих определенный таксономический ранг. "Apis mellifera" &lt;имеет обиходное название&gt; "медоносные пчелы". Используется на уровне понятия, когда обиходное название и научное название являются отдельными понятиями. Для связи между метками в пределах понятия используйте &lt;имеет научное название/явлется научным названием&gt;. </para>
    ///   <para>Y&lt;有常用名概念&gt;X。Y是某一生物体或生物群X的学名概念，其标签为学名，具有特定的分类等级。“Apis mellifera”&lt;有常用名概念&gt;“蜜蜂”。当常用名和学名是独立的概念时，在概念层面使用。对于标签间关系，在同一个概念内使用&lt;有学名/是...的学名&gt;。</para>
    ///   <para>ع &lt;لها مفهوم الاسم الشائع&gt; س. ع هو مفهوم محدد علميًا لكائن حي أو مجموعة من الكائنات الحية التي تحمل اسمًا علميًا كعلامات ، ولها رتبة تصنيفية محددة
    /// على سبيل المثال"Apis mellifera". &lt;لها مفهوم الاسم الشائع&gt; "نحل العسل".
    /// يستخدم على مستوى المفهوم عندما يكون الاسم الشائع والاسم العلمي مفهومين منفصلين.
    ///  لعلاقة التسمية إلى التسمية للاستخدام ضمن المفهوم ، استخدم &lt;له اسم علمي / اسم علمي لـ&gt;. </para>
    ///   <para>Y &lt;a nom commun de concept&gt; X. Y est un concept scientifiquement défini pour un organisme ou un groupe d'organismes avec des noms scientifiques comme terme, ayant un rang taxonomique spécifique. "Apis mellifera" &lt;a nom commun de concept&gt; "abeille domestique". Utilisation au niveau du concept lorsque le nom commun et le nom scientifique sont des concepts distincts. Pour une relation terme à terme à utiliser dans un concept, utilisez &lt;a nom scientifique/ est le nom scientifique&gt;.
    /// </para>
    /// labels<para>Tiene nombre común del concepto</para><para>имеет обиходное название</para><para>A nom commun de concept</para><para>Has common name concept</para><para>له مفهوم الاسم الشائع</para><para>有常用名概念</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCommonNameConcept">http://aims.fao.org/aos/agrontology#hasCommonNameConcept</seealso>
    let hasCommonNameConcept =
        Prefixed_Name(aos, "hasCommonNameConcept") |> PrefixedName

    /// <summary>
    ///   <para>aos:taxonomicRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Super-propriété pour les relations taxonomiques</para>
    ///   <para>الملكية الفائقة للعلاقات التصنيفية</para>
    ///   <para>Superpropiedad para relaciones taxonómicas </para>
    ///   <para>Суперсвойство для таксономических отношений</para>
    ///   <para>Super-property for taxonomic relationships. </para>
    ///   <para>所有分类学关系的父类属性</para>
    /// labels<para>таксономические отношения</para><para>Relaciones taxonómicas</para><para>Relations taxonomiques</para><para>Taxonomic relationship</para><para>العلاقات التصنيفية</para><para>分类学关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#taxonomicRelationship">http://aims.fao.org/aos/agrontology#taxonomicRelationship</seealso>
    let taxonomicRelationship =
        Prefixed_Name(aos, "taxonomicRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X&lt;有部分&gt;Y。复合实体X可被认定为由一个或多个部分组成，其中包括Y。例如：“茎”&lt;有部分&gt;“皮层”，“根”&lt;有部分&gt;“根节结”。用于其他下位整体部分关系（&lt;有组成部分&gt;，&lt;是...的组成部分&gt;，&lt;是...的成员&gt;）都不适用时。</para>
    ///   <para>X &lt;tiene parte&gt; Y. Una entidad compuesta X que puede ser identificada como compuesta por una o más partes, entre las cuales Y. Por ejemplo, "Tallos" &lt;tiene parte&gt; "Cortex", "Raíces" &lt;tiene parte&gt; "Nudosidades radiculares". Utilice esta relación cuando ninguna de las otras relaciones partitivas inferiores (&lt;tiene componente&gt;, &lt;está compuesto de&gt;, &lt;miembro&gt;)  sea aplicable. </para>
    ///   <para> X &lt;a partie&gt; Y.  Une entité composite X qui peut être identifiée comme composée d'une ou plusieurs parties, entre lesquelles Y. Par exemple, "tige" &lt;a partie&gt; "cortex", "racine" &lt;a partie&gt; "nodosité racinaire". Utilisez cette relation lorsqu'aucune des autres relations partitives inférieures (&lt;a le composant&gt;, &lt;est composé de&gt;, &lt;membre de&gt;) ne s'applique.</para>
    ///   <para>س &lt;له جزء&gt; ع. الكيان المركب س يمكن تحديده على أنه مكون من جزء واحد أو أكثر ، بينها ع.
    /// على سبيل المثال: "الساق" &lt;لها جزء&gt;" القشرة"
    /// "الجذور" &lt;لها جزء&gt; "عقد الجذور".
    /// استخدم هذه العلاقة عندما لا تنطبق أي من العلاقات الجزئية السفلية الأخرى (&lt;لها مكون&gt; ، &lt;مكون من&gt; ، &lt;عضو&gt;). </para>
    ///   <para>X &lt;имеет часть&gt; Y. Составная сущность X, которая может быть идентифицирована как состоящая из одной или более частей, между которыми Y. Например, "стебли" &lt;имеет часть&gt; "кортекс", "корни" &lt;имеет часть&gt; "корневые клубеньки". Используйте это отношение, когда ни одно из других низших партитивных отношений (&lt;имеет компонент&gt;, &lt;состоит из&gt;, &lt;является членом&gt;) не применимо. </para>
    ///   <para>X &lt;has part&gt; Y. A composite entity X that can be identified as being composed of one or more parts, between which Y. E.g. “stems” &lt;has part&gt; “cortex”, “roots” &lt;has part&gt;“root nodules”. Use this relationship when none of the other lower partitive relations (&lt;has component&gt;, &lt;is composed of&gt;, &lt;member&gt;) apply. </para>
    /// labels<para>имеет часть</para><para>Tiene parte</para><para>لديه جزء</para><para>A partie</para><para>Has part</para><para>有部分</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPart">http://aims.fao.org/aos/agrontology#hasPart</seealso>
    let hasPart = Prefixed_Name(aos, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>aos:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;es componente de&gt; Y. Un objeto X que forma parte de un conjunto Y, también tiene una existencia independiente de Y. Ej. "Hojas" &lt;es componente de&gt; "Árboles", "Motores" &lt;es componente de&gt; "Componentes del vehículo".</para>
    ///   <para> X&lt;是...的组成部分&gt;Y。物体X是整体Y的一部分，同时也独立于Y存在。例如：“叶”&lt;是...的组成部分&gt;“树”，“发动机”&lt;是...的组成部分&gt;“车辆系统”。</para>
    ///   <para>س &lt;هي مكون من&gt; ع. الكائن س هو جزء من ع بالكامل وله أيضاً وجود مستقل عن ع.
    /// على سبيل المثال: "الورقة" &lt;هي مكون من &gt; "الشجرة"
    /// " المحركات" &lt;هي مكون من &gt; "منظومات المركبات".
    /// </para>
    ///   <para>X &lt;est un composant de&gt; Y. Un objet X qui fait partie d'un Y entier, a également une existence indépendante de Y. Par exemple, "feuille" &lt;est un composant de&gt; "arbre",  "moteur" &lt;est un composant de&gt; "organe de véhicule" .</para>
    ///   <para> X &lt;is component of&gt; Y. An object X that is a part of a whole Y, also has an existence independently from Y. E.g. "leaves" &lt;is component of&gt; "trees", "engines" &lt;is component of&gt; "vehicle systems".</para>
    ///   <para>X &lt;является компонентом&gt; Y. Объект X, который является частью целого Y, также имеет существование независимо от Y. Например, "листья" &lt;является компонентом&gt; "деревья", "двигатели" &lt;является компонентом&gt; "системы машин".</para>
    /// labels<para>является компонентом</para><para>Est un composant de</para><para>Es componente de</para><para>Is component of</para><para>هو مكون من</para><para>是...的组成部分</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isComponentOf">http://aims.fao.org/aos/agrontology#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(aos, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:isCropingSystemOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is cropping system of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isCropingSystemOf">http://aims.fao.org/aos/agrontology#isCropingSystemOf</seealso>
    let isCropingSystemOf = Prefixed_Name(aos, "isCropingSystemOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasCultivationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has cultivation process</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCultivationProcess">http://aims.fao.org/aos/agrontology#hasCultivationProcess</seealso>
    let hasCultivationProcess =
        Prefixed_Name(aos, "hasCultivationProcess") |> PrefixedName

    /// <summary>
    ///   <para>aos:isDisorderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is disorder of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isDisorderOf">http://aims.fao.org/aos/agrontology#isDisorderOf</seealso>
    let isDisorderOf = Prefixed_Name(aos, "isDisorderOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasGoalOrProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;has goal or process&gt; Y. X has intended goal or  process Y. E.g. “veterinary services” &lt;has goal or process&gt; “animal health”, “coppicing” &lt;has goal or process&gt; “natural regeneration”.
    /// </para>
    ///   <para>X&lt;有目标或过程&gt;Y。X有预期的目标或过程Y。例如：“兽医服务”&lt;有目标或过程&gt;“家畜健康”，“矮林作业”&lt;有目标或过程&gt;“天然更新”。</para>
    ///   <para>X &lt;направлен на&gt; Y. X направлен на цель или процесс Y. Например, "ветеринарные услуги" &lt;направлен на&gt; "здоровье животных", "рубки обновления" &lt;направлен на&gt;  "естественное возобновление".</para>
    ///   <para>X &lt;a le but ou le processus&gt; Y. X a un objectif ou un processus prévu Y. Par exemple: "service vétérinaire" &lt;a le but ou le processus&gt; "santé animale", "coupe de rajeunissement" &lt;a le but ou le processus&gt; "régénération naturelle".</para>
    ///   <para>X &lt;tiene el objetivo o el proceso&gt; Y. Ej. "Servicios veterinarios" &lt;tiene el objetivo o el proceso&gt; "Sanidad animal", "Corta de renuevos"  &lt;tiene el objetivo o el proceso&gt; "Regeneración natural".</para>
    ///   <para>س &lt;لديه هدف أو عملية &gt; ع.يحتوي س على الهدف المقصود أو العملية ع.
    /// على سبيل المثال "الخدمات البيطرية" &lt;هدفها&gt; "صحة الحيوان" .
    /// </para>
    /// labels<para>Tiene el objetivo o el proceso</para><para>A le but ou le processus</para><para>Has goal or process</para><para>направлен на</para><para>لديه الهدف</para><para>有目标或过程</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasGoalOrProcess">http://aims.fao.org/aos/agrontology#hasGoalOrProcess</seealso>
    let hasGoalOrProcess = Prefixed_Name(aos, "hasGoalOrProcess") |> PrefixedName
    /// <summary>
    ///   <para>aos:isHostFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;tiene vector o es huésped de&gt; X. El organismo Y es huésped o vector de Y. Ej. “Anopheles” &lt;tiene vector o es huésped de&gt; ”Plasmodium”.
    /// </para>
    ///   <para>ع &lt;هو الناقل أو المضيف لـ &gt; س. الكائن الحي ع هو ميف أو ناقل لـ س.
    /// على سبيل المثال: "بعوضة الملاريا" &lt;هي الناقل أو المضيف لـ&gt; "المتصورة".</para>
    ///   <para>Y &lt;Is vector or host for&gt; X. Organism Y is host or vector for X.  E.g. “Anopheles” &lt;is vector or host for&gt; ”Plasmodium”.
    /// </para>
    ///   <para>Y &lt;является переносчиком или хозяином для&gt; X. Организм Y является переносчиком или хозяином для X. "Anopheles" &lt;является переносчиком или хозяином для&gt;  "Plasmodium".
    /// </para>
    ///   <para>Y &lt;possède un vecteur ou est hôte de&gt; X. L'organisme Y est l'hôte ou le vecteur de X. Par exemple, "Anophele" &lt;possède un vecteur ou est hôte de&gt; "Plasmodium".</para>
    ///   <para>Y&lt;是...的寄主&gt;X。生物体Y是X的寄主或传播媒介。例如：“按蚊属”&lt;是...的寄主&gt;“疟原虫属” 。</para>
    /// labels<para>является переносчиком или хозяином для</para><para>Est vecteur ou est hôte de</para><para>Es vector o es huésped de</para><para>Is vector or host for</para><para>مضيف لـ</para><para>是...的寄主</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isHostFor">http://aims.fao.org/aos/agrontology#isHostFor</seealso>
    let isHostFor = Prefixed_Name(aos, "isHostFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasInfectionPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has infection part</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasInfectionPart">http://aims.fao.org/aos/agrontology#hasInfectionPart</seealso>
    let hasInfectionPart = Prefixed_Name(aos, "hasInfectionPart") |> PrefixedName
    /// <summary>
    ///   <para>aos:isInfectedPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is infected part of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isInfectedPartOf">http://aims.fao.org/aos/agrontology#isInfectedPartOf</seealso>
    let isInfectedPartOf = Prefixed_Name(aos, "isInfectedPartOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasLocalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has local name</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasLocalName">http://aims.fao.org/aos/agrontology#hasLocalName</seealso>
    let hasLocalName = Prefixed_Name(aos, "hasLocalName") |> PrefixedName
    /// <summary>
    ///   <para>aos:isLocalNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is a local name of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isLocalNameOf">http://aims.fao.org/aos/agrontology#isLocalNameOf</seealso>
    let isLocalNameOf = Prefixed_Name(aos, "isLocalNameOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;tiene miembro&gt; X. Un grupo social o político Y se compone de una o más unidades sociales o políticas subsidiarias (grupo o individuo) X. Ej. "Africa de habla francesa" &lt;tiene miembro&gt; "Bénin", "Colonia de abejas" &lt;tiene miembro&gt; "Abejas obrera". Limitar el uso a unidades geográficas/sociopolíticas. No utilizar para agrupar organismos por uso, clima o rango taxonómico.</para>
    ///   <para>Y &lt;有成员&gt;X。社会或政治团体Y由一个或多个附属的社会或政治单位（团体或个人）X组成。例如：“法语非洲”&lt;有成员&gt;“贝宁”，“蜜蜂群”&lt;有成员&gt;“工蜂”。限用于地理/社会政治单位。请勿用于按用途、气候或分类等级对生物体进行分组。对于空间或时间关系，使用&lt;包含/包含于&gt;，但比&lt;有部分/是...的部分&gt;更为松散。</para>
    ///   <para>Y &lt;имеет члена&gt; X. Социальная или политическая группа Y состоит из одной или более дочерних социальных или политических единиц (группы или индивида) X. Например, "франкоязычная Африка" &lt;имеет члена&gt; "Бенин", "челиные семьи" &lt;имеет члена&gt; "рабочие пчелы". Ограничьте использование географическими/социально-политическими единицами. Не используйте для группировки организмов по использованию, климату или таксономическому рангу. Используйте &lt;включает/ входит в&gt; при описании пространственных или временных отношений, если они более свободные, чем &lt;имеет часть/является частью&gt;.</para>
    ///   <para>Y &lt;a un membre&gt; X. Un groupe social ou politique Y est constitué d'une ou plusieurs unités sociales ou politiques subsidiaires (groupe ou individu) X. Par exemple, "Afrique francophone" &lt;a un membre&gt; "Bénin", "colonie d'abeilles" &lt;a un membre&gt; "abeille ouvrière". Limiter l'utilisation aux unités géographiques/socio-politiques. Ne pas utiliser pour regrouper les organismes par utilisation, climat ou rang taxonomique.</para>
    ///   <para>Y &lt;has member&gt; X. A social or political group Y consists of one or more subsidiary social or political units (group or individual) X. E.g. "Francophone Africa" &lt;has member&gt; "Benin", "bee colonies" &lt;has member&gt; "worker bees". Limit use to geographical or socio-political units. Do not use for grouping organisms by use, climate, or taxonomic rank. Use &lt;includes&gt; / &lt;included in&gt; if describing spatial or temporal relation, if more loose than &lt;has part/is part of&gt;.</para>
    ///   <para>ع &lt;لديه عضو&gt; س. تتكون المجموعة الاجتماعية أو السياسية ع من وحدة اجتماعية أو سياسية فرعية واحدة أو أكثر (مجموعة أو فرد) س.
    /// على سبيل المثال: "أفريقيا الناطقة باللغة الفرنسية" &lt;لديها العضو&gt; بنن
    /// " مستعمرات النحل" &lt;لديها العضو &gt; "النحلات العاملات".
    /// قصر الاستخدام على الوحدات الجغرافية / الاجتماعية السياسية.
    /// لا تستخدم لتجميع الكائنات الحية حسب الاستخدام أو المناخ أو الترتيب التصنيفي.
    /// استخدم &lt;تتضمن&gt; / &lt;مضمن في&gt; إذا كنت تصف العلاقة المكانية أو الزمنية ، إذا كانت فضفاضة أكثر يستخدم &lt;لها جزء / جزء من&gt;. </para>
    /// labels<para>Tiene miembro</para><para>имеет члена</para><para>A un membre</para><para>Has member</para><para>لديه عضو</para><para>有成员</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasMember">http://aims.fao.org/aos/agrontology#hasMember</seealso>
    let hasMember = Prefixed_Name(aos, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>aos:isNaturalEnemyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is natural enemy of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isNaturalEnemyOf">http://aims.fao.org/aos/agrontology#isNaturalEnemyOf</seealso>
    let isNaturalEnemyOf = Prefixed_Name(aos, "isNaturalEnemyOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasNearSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has near synonym</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasNearSynonym">http://aims.fao.org/aos/agrontology#hasNearSynonym</seealso>
    let hasNearSynonym = Prefixed_Name(aos, "hasNearSynonym") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasObjectOfActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;tiene objeto de la actividad&gt; Y. El concepto X es el foco de la actividad Y.Ej. “Esquileo” &lt;tiene objeto de la actividad&gt; “Lana”, “Ratificación” &lt;tiene objeto de la actividad&gt; “Tratados”.
    ///  </para>
    ///   <para>X &lt;имеет объект деятельности&gt; Y. Действие X сосредоточено на Y. Например,  "стрижка" &lt;имеет объект деятельности&gt; "шерсть", "ратификация" &lt;имеет объект деятельности&gt; "пакты".
    /// </para>
    ///   <para>X &lt;has object of activity&gt; Y. Activity X focuses on Y. E.g. “shearing” &lt;has object of activity&gt; “wool”, “ratification” &lt;has object of activity&gt; “treaties”.
    /// </para>
    ///   <para>س &lt;له هدف النشاط&gt; ع.  يركز النشاط س على ع.
    /// على سبيل المثال "الجز" &lt;له هدف&gt; "الصوف" ،
    /// "التصديق" &lt;له هدف&gt; "المعاهدات".</para>
    ///   <para>X &lt;a objet d'activité&gt; Y. Le concept X est au centre de l'activité Y. "tonte" &lt;a objet d'activité&gt; "laine", "ratification" &lt;a objet d'activité&gt; "traité".</para>
    ///   <para>X &lt;有活动对象&gt; Y。活动X关注对象Y。例如：“剪毛”&lt;有活动对象&gt;“羊毛”，“批准”&lt;有活动对象&gt;“条约”。</para>
    /// labels<para>Tiene objeto de la actividad</para><para>имеет объект деятельности</para><para>Has object of activity</para><para>A objet d'activité</para><para>له هدف النشاط</para><para>有活动对象</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasObjectOfActivity">http://aims.fao.org/aos/agrontology#hasObjectOfActivity</seealso>
    let hasObjectOfActivity = Prefixed_Name(aos, "hasObjectOfActivity") |> PrefixedName
    /// <summary>
    ///   <para>aos:isOldNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y&lt;是...的曾用名&gt;X。用于过时的标签，如国家的旧名。例如：“保加利亚人民共和国”&lt;是...的曾用名&gt;“保加利亚”。限用于同一概念某一特定语言的不同标签。</para>
    ///   <para>Y &lt;es nombre antiguo de&gt; X. Se utiliza para etiquetas obsoletas, como nombres antiguos de países.  Por ejemplo, "República Popular de Bulgaria" &lt;es nombre antiguo de&gt; "Bulgaria". Usar sólo para etiquetas del mismo concepto en un idioma específico.</para>
    ///   <para>Y &lt;est nom ancien de&gt; X. À utiliser pour les étiquettes obsolètes, comme les anciens noms de pays. Par exemple, "République populaire de Bulgarie" &lt;est nom ancien de&gt; "Bulgarie".  Utilisez uniquement entre les termes pour le même concept dans une langue spécifique. </para>
    ///   <para>Y &lt;is old name of&gt; X. Use for obsolete labels , like old names of countries. E.g. “People’s Republic of Bulgaria” &lt;is old name of&gt; ”Bulgaria”. Use only for labels for the same concept in a specific language.</para>
    ///   <para>ع &lt;هي الاسم القديم لـ&gt; س .يستخدم للتسميات القديمة ، مثل الأسماء القديمة للبلدان
    /// على سبيل المثال:  "جمهورية بلغاريا الشعبية" &lt;هي الاسم القديم لـ&gt; "بلغاريا"
    /// تستخدم فقط بين التسميات لنفس المفهوم بلغة معينة.</para>
    ///   <para>Y &lt;является старым названием&gt; X. Используется для устаревших обозначений, например, старых названий стран. Например, "Народная Республика Болгария" &lt;является старым названием&gt; "Болгария". Использовать только для обозначения одного и того же понятия на определенном языке.</para>
    /// labels<para>является старым названием</para><para>Es nombre antiguo de</para><para>هو الاسم القديم ل</para><para>Est nom ancien de</para><para>Is old name of</para><para>是...的曾用名</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isOldNameOf">http://aims.fao.org/aos/agrontology#isOldNameOf</seealso>
    let isOldNameOf = Prefixed_Name(aos, "isOldNameOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has parent</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasParent">http://aims.fao.org/aos/agrontology#hasParent</seealso>
    let hasParent = Prefixed_Name(aos, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>aos:isParentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is parent of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isParentOf">http://aims.fao.org/aos/agrontology#isParentOf</seealso>
    let isParentOf = Prefixed_Name(aos, "isParentOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasPathogen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;tiene patógeno&gt; Y. El organismo X tiene el patógeno Y. Los patógenos son microorganismos patógenos como virus, bacterias y hongos. Ej. "Olea europaea" &lt;tiene patógeno&gt; "Xylella fastidiosa".
    /// </para>
    ///   <para>X &lt;a l'agent pathogène&gt; Y. L'organisme X a un agent pathogène Y. Les agents pathogènes sont des microorganismes pathogènes tels que : des virus, des bactéries et des champignons. Par exemple, "Olea europaea" &lt;a l'agent pathogène&gt; "Xylella fastidiosa".</para>
    ///   <para>X &lt;has pathogen&gt; Y. Organism X has pathogen Y. Pathogens are pathogenic microorganism such as viruses, bacteria and fungi. E.g. "Olea europaea" &lt;has pathogen&gt; "Xylella fastidiosa".</para>
    ///   <para>X&lt;有病原体&gt;Y。生物体X有病原体Y。病原体指病毒、细菌和真菌等致病性微生物。例如：“Olea europaea”&lt;有病原体&gt;“Xylella fastidiosa”。</para>
    ///   <para>X &lt;имеет патоген&gt; Y. Организм X имеет патоген Y. Патогены - это патогенные микроорганизмы, такие как вирусы, бактерии и грибы. Например, "Olea europaea" &lt;имеет патоген&gt; "Xylella fastidiosa".
    /// </para>
    ///   <para>س &lt;لديه مسببات مرض&gt; ع. الكائن الحي لديه مسببات مرض ع. مسببات الأمراض هي الكائنات الحية الدقيقة المسببة للأمراض مثل الفيروسات والبكتيريا والفطريات
    /// على سبيل المثال: "Olea europaea "&lt;لديها مسببات مرض&gt;" Xylella fastidiosa " </para>
    /// labels<para>لديه مسببات الأمراض</para><para>A l'agent pathogène</para><para>Tiene patógeno</para><para>имеет патоген</para><para>Has pathogen</para><para>有病原体</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPathogen">http://aims.fao.org/aos/agrontology#hasPathogen</seealso>
    let hasPathogen = Prefixed_Name(aos, "hasPathogen") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasPest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;has pest&gt; X. An organism Y in which the pest X causes harm. Pests are insects, nematodes and rodents that cause damage. E.g. "Apis mellifera" &lt;has pest&gt; "Varroa destructor", "Olea europaea" &lt;has pest&gt; "Bactrocera oleae".</para>
    ///   <para>Y &lt;a peste&gt; X. Un organisme Y dans lequel le ravageur X cause des dommages. Les ravageurs sont des insectes, des nématodes et des rongeurs qui causent des dommages. Par exemple, "Apis mellifera" &lt;a peste&gt; "Varroa destructor", "Olea europaea" &lt;a peste&gt; "Bactrocera oleae".
    /// </para>
    ///   <para>Y&lt;有有害生物&gt;X。有害生物X对生物体Y造成损害。有害生物指造成损害的昆虫、线虫和啮齿动物。例如：“西方蜜蜂”&lt;有有害生物&gt;“Varroa destructor”，“Olea europaea”&lt;有有害生物&gt;“油橄榄果实蝇”。</para>
    ///   <para>Y &lt;tiene plaga&gt; X. Un organismo Y en el que la plaga X causa daños. Las plagas son insectos, nematodos y roedores que causan daños. Ej. "Apis mellifera" &lt;tiene plaga&gt; "Varroa destructor", "Olea europaea" &lt;tiene plaga&gt; "Bactrocera oleae".
    /// </para>
    ///   <para>У Y &lt;имеется вредитель&gt; X. Организм Y, которому вредитель X причиняет вред. Вредители - это насекомые, нематоды и грызуны, которые причиняют вред. Например, У "Apis mellifera" &lt;имеется вредитель&gt; "Varroa destructor", У "Olea europaea" &lt;имеется вредитель&gt; "Bactrocera oleae".
    /// </para>
    ///   <para>ع &lt;لديه الآفة&gt; س. الكائن الحي ع الذي تسبب فيه الآفة س الضرر. الآفات هي الحشرات والديدان الخيطية والقوارض التي تسبب الضرر.
    /// على سبيل المثال:   "Apis mellifera" &lt; لديه الآفة&gt; "Varroa destructor",
    /// "Olea europaea"  &lt;لديه الآفة&gt; "Bactrocera oleae".</para>
    /// labels<para>У ... имеется вредитель ...</para><para>Tiene plaga</para><para>لديه آفة</para><para>Has pest</para><para>A peste</para><para>有有害生物</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPest">http://aims.fao.org/aos/agrontology#hasPest</seealso>
    let hasPest = Prefixed_Name(aos, "hasPest") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPhysiologicalFunctionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is physiological function of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPhysiologicalFunctionOf">http://aims.fao.org/aos/agrontology#isPhysiologicalFunctionOf</seealso>
    let isPhysiologicalFunctionOf =
        Prefixed_Name(aos, "isPhysiologicalFunctionOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPlural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Has plural</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPlural">http://aims.fao.org/aos/agrontology#hasPlural</seealso>
    let hasPlural = Prefixed_Name(aos, "hasPlural") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPostProductionPractice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has post-production practice</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPostProductionPractice">http://aims.fao.org/aos/agrontology#hasPostProductionPractice</seealso>
    let hasPostProductionPractice =
        Prefixed_Name(aos, "hasPostProductionPractice") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPractice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has practice</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPractice">http://aims.fao.org/aos/agrontology#hasPractice</seealso>
    let hasPractice = Prefixed_Name(aos, "hasPractice") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPostProductionPracticeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is post-production practice for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPostProductionPracticeFor">http://aims.fao.org/aos/agrontology#isPostProductionPracticeFor</seealso>
    let isPostProductionPracticeFor =
        Prefixed_Name(aos, "isPostProductionPracticeFor") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPropagationMaterialOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is propagation material of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPropagationMaterialOf">http://aims.fao.org/aos/agrontology#isPropagationMaterialOf</seealso>
    let isPropagationMaterialOf =
        Prefixed_Name(aos, "isPropagationMaterialOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPropagationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has Propagation process</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPropagationProcess">http://aims.fao.org/aos/agrontology#hasPropagationProcess</seealso>
    let hasPropagationProcess =
        Prefixed_Name(aos, "hasPropagationProcess") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPropagationProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is propagation process of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPropagationProcessOf">http://aims.fao.org/aos/agrontology#isPropagationProcessOf</seealso>
    let isPropagationProcessOf =
        Prefixed_Name(aos, "isPropagationProcessOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X&lt;有属性&gt;Y。属性可以是一种性质或特点。例如：“种子”&lt;有属性&gt;“种子大小”和“种子活力”，“药用植物类” &lt;有属性&gt;“药物属性”。</para>
    ///   <para>X &lt;обладает свойством&gt; Y. Свойство может быть качеством или признаком. Например, "семенной материал" &lt;обладает свойством&gt; "крупность семян", "лекарственные растения" &lt;обладает свойством&gt; "фармакологические свойства".
    /// </para>
    ///   <para>X &lt;a la propriété&gt; Y. Une propriété peut être une qualité ou un trait. Par exemple, "semence" &lt;a la propriété&gt; "grosseur des semences",  "plante médicinale" &lt;a la propriété&gt; "propriété pharmacologique".</para>
    ///   <para>X &lt;tiene propriedad&gt; Y. Una propiedad puede ser una cualidad o un rasgo. Ej. “Semillas” &lt;tiene propriedad&gt; “Tamaño de la semilla", “Plantas medicinales” &lt;tiene propriedad&gt; “Propiedades medicinales”.</para>
    ///   <para>س &lt;لديه خاصية&gt; ع. الخاصية قد تكون جودة أو ميزة.
    /// على سبيل المثال: البذرة"&lt;لديها خاصية&gt; "حجم البذرة"
    /// "النباتات الطبية" &lt;لديها خاصية&gt; "الخصائص الطبية"</para>
    ///   <para>X &lt;has property&gt; Y. A property might be a quality or trait. E.g. “seed” &lt;has property&gt; “seed size", “medicinal plants” &lt;has property&gt; “medicinal properties”.</para>
    /// labels<para>обладает свойством</para><para>Tiene propriedad</para><para>A la propriété</para><para>لديه ممتلكات</para><para>Has property</para><para>有属性</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasProperty">http://aims.fao.org/aos/agrontology#hasProperty</seealso>
    let hasProperty = Prefixed_Name(aos, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>aos:scientificNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;является научным названием&gt; X. Например, "Salmo trutta" &lt;является научным названием&gt; "морская форель". Связь между метками для использования внутри понятия. Используется, когда обычное название и научное название не являются отдельными понятиями, или когда отдельное отношение между научным и обычным названием необходимо для конкретного языка. Если обычное название и научное название являются отдельными понятиями, используйте отношение между понятиями &lt;имеет  таксономическое понятие/имеет обиходное название&gt;.</para>
    ///   <para>ع &lt;هي الاسم العلمي لـ&gt; س.
    /// على سبيل المثال:  "Salmo trutta” &lt;هي الاسم العلمي لـ&gt; "التروت البحري"
    /// علاقة التسمية إلى التسمية للاستخدام داخل المفهوم.
    /// يستخدم عندما لا يكون الاسم الشائع والاسم العلمي مفهومين منفصلين ، أو عندما تكون هناك حاجة لعلاقة منفصلة بين الاسم العلمي والاسم الشائع للغة معينة. عندما يكون الاسم الشائع والاسم العلمي مفهومين منفصلين ، استخدم علاقة المفهوم بالمفهوم &lt;له مفهوم تصنيفي / له مفهوم اسم شائع&gt;. </para>
    ///   <para>Y&lt;是...的学名&gt;X。例如：“Salmo trutta”&lt;是...的学名&gt;“褐鳟”。可用于同一概念内的标签间关系。当俗名和学名不是独立的概念，或者当特定的语言需要在学名和俗名之间建立单独的关系时使用。当俗名和学名是独立的概念时，使用概念间关系&lt;有分类学概念/有常用名概念&gt;。</para>
    ///   <para>Y &lt;scientific name of&gt; X. E.g. “Salmo trutta” &lt;scientific name of&gt; "sea trout”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.</para>
    ///   <para>Y &lt;est le nom scientifique de&gt; X. "Salmo trutta" &lt;est le nom scientifique de&gt; "truite de mer". Relation terme à terme à utiliser dans un concept. À utiliser lorsque le nom commun et le nom scientifique ne sont pas des concepts distincts, ou lorsqu'une relation distincte entre le nom scientifique et le nom commun est nécessaire pour un Lorsque le nom commun et le nom scientifique sont des concepts distincts, utilisez la relation de concept à concept &lt;a concept taxonomique /a nom commun de concept&gt;. </para>
    ///   <para>Y &lt;es el nombre científico de&gt; X. Ej."Salmo trutta" &lt;es el nombre científico de&gt; "Trucha de mar". Relación de etiqueta a etiqueta para su uso dentro de un concepto. Se utiliza cuando el nombre común y el nombre científico no son conceptos separados, o cuando se necesita una relación separada entre el nombre científico y el nombre común para un idioma específico. Cuando el nombre común y el nombre científico son conceptos separados, utilice la relación de concepto a concepto &lt;tiene concepto taxonómico/tiene nombre común del concepto&gt;.</para>
    /// labels<para>является научным названием</para><para>Est le nom scientifique de</para><para>Es el nombre científico de</para><para>Scientific name of</para><para>هو الاسم العلمي ل</para><para>是...的学名</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#scientificNameOf">http://aims.fao.org/aos/agrontology#scientificNameOf</seealso>
    let scientificNameOf = Prefixed_Name(aos, "scientificNameOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasSingular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Has singular</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasSingular">http://aims.fao.org/aos/agrontology#hasSingular</seealso>
    let hasSingular = Prefixed_Name(aos, "hasSingular") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasSubstitute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has substitute</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasSubstitute">http://aims.fao.org/aos/agrontology#hasSubstitute</seealso>
    let hasSubstitute = Prefixed_Name(aos, "hasSubstitute") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasSymbol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;a le symbole&gt; Y. "fer" &lt;a le symbole&gt; "Fe (symbole)". À utiliser pour lever l'ambiguïté des symboles d'éléments chimiques à partir d'autres abréviations similaires. </para>
    ///   <para>X &lt;обозначается символом&gt; Y. "железо" обозначается символом  "Fe". Используется, чтобы отличить символы химических элементов от других подобных сокращений.</para>
    ///   <para>X &lt;has symbol&gt; Y. “iron” has symbol ”Fe (symbol)”. Use for disambiguation of chemical element symbols from other similar abbreviations.</para>
    ///   <para>X&lt;有符号&gt;Y。“铁”&lt;有符号&gt;“Fe(元素)”。用于化学元素符号与其他类似缩写的消歧。</para>
    ///   <para>س &lt;لها الرمز الكيميائي&gt; ع.
    /// على سبيل المثال: " الحديد" &lt;لها الرمز الكيميائي&gt; "Fe"
    /// يستخدم لتوضيح رموز العناصر الكيميائية من الاختصارات المشابهة الأخرى.</para>
    ///   <para>X &lt;tiene símbolo&gt; Y. "Hierro" &lt;tiene símbolo&gt; "Fe (símbolo)". Se utiliza para desambiguar los símbolos de elementos químicos de otras abreviaturas similares.</para>
    /// labels<para>обозначается символом</para><para>لها الرمز الكيميائي</para><para>Tiene símbolo</para><para>A le symbole</para><para>Has symbol</para><para>有符号</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasSymbol">http://aims.fao.org/aos/agrontology#hasSymbol</seealso>
    let hasSymbol = Prefixed_Name(aos, "hasSymbol") |> PrefixedName
    /// <summary>
    ///   <para>aos:isSymbolFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;est le symbole de&gt; X. "Fe (symbole)" &lt;est le symbole de&gt; "fer". À utiliser pour lever l'ambiguïté des symboles d'éléments chimiques à partir d'autres abréviations similaires. </para>
    ///   <para>Y &lt;es símbolo de&gt; X. "Fe (símbolo)" &lt;es símbolo de&gt; "Hierro". Se utiliza para desambiguar los símbolos de elementos químicos de otras abreviaturas similares.</para>
    ///   <para>ع &lt;هي الرمز الكيميائي لـ&gt; س.
    /// على سبيل المثال: " Fe" &lt;هي الرمز الكيميائي لـ&gt; "الحديد"
    /// يستخدم لتوضيح رموز العناصر الكيميائية من الاختصارات المشابهة الأخرى.</para>
    ///   <para>Y&lt;是...的符号&gt;X。“Fe(元素)”&lt;是...的符号&gt;“铁”。用于化学元素符号与其他类似缩写的消歧。</para>
    ///   <para>Y &lt;символ для&gt; X. "Fe" &lt;символ для&gt; "железо". Используется для разотождествления символов химических элементов от других подобных сокращений.</para>
    ///   <para>Y &lt;is symbol for&gt; X. ”Fe (symbol)” &lt;is symbol for&gt; “iron”. Use for disambiguation of chemical element symbols from other similar abbreviations.</para>
    /// labels<para>هو رمز كيميائي لـ</para><para>Est le symbole de</para><para>Is symbol for</para><para>Es símbolo de</para><para>символ для</para><para>是...的符号</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSymbolFor">http://aims.fao.org/aos/agrontology#isSymbolFor</seealso>
    let isSymbolFor = Prefixed_Name(aos, "isSymbolFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasSymptom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;has symptom&gt; Y. A disease or disorder X presents disease characteristic Y in an organism. E.g. "malnutrition" &lt;has symptom&gt; "thinness", "septicaemia" &lt;has symptom&gt; "septic shock". </para>
    ///   <para>X &lt;tiene síntoma&gt; Y. Una enfermedad o trastorno X presenta la característica de enfermedad Y en un organismo. Ej. "Malnutrición" &lt;tiene síntoma&gt; "Delgadez", "Septicemia" &lt;tiene síntoma&gt; "Shock séptico". </para>
    ///   <para>س &lt;لديه أعراض&gt; ع. المرض او الاضطراب س يعرض سمة المرض ع في كائن حي.
    /// على سبيل المثال: "سوء التغذية" &lt;لديها أعراض&gt; "النحافة"،
    /// " التسمم الدموي" &lt;لديه أعراض&gt; " الصدمة الانتانية"</para>
    ///   <para>X &lt;имеет симптом&gt; Y. Заболевание или расстройство X представляет характеристику болезни Y в организме. Например,  "септицемия" &lt;имеет симптом&gt; "септический шок".</para>
    ///   <para>X &lt;a symptôme&gt; Y. Une maladie ou un désordre X présente une maladie caractéristique Y dans un organisme. Par exemple, "malnutrition" &lt;a symptôme&gt; "maigreur", "septicémie" &lt;a symptôme&gt; "choc septique". </para>
    ///   <para>X&lt;有症状&gt;Y。疾病或病症X在生物体内显示出疾病特征Y。例如：“营养不良”&lt;有症状&gt;“体瘦”，“败血症”&lt;有症状&gt;“感染性休克”。</para>
    /// labels<para>имеет симптом</para><para>Tiene síntoma</para><para>Has symptom</para><para>A symptôme</para><para>له أعراض</para><para>有症状</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasSymptom">http://aims.fao.org/aos/agrontology#hasSymptom</seealso>
    let hasSymptom = Prefixed_Name(aos, "hasSymptom") |> PrefixedName
    /// <summary>
    ///   <para>aos:indicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;يشير إلى&gt; س. المرض او الاضطراب ع في كائن حي يشير إلى المرض س
    /// على سبيل المثال: " الصدمة الانتانية &lt;تشير إلى&gt; " التسمم الدموي".
    /// تستخدم فقط للأمراض. ومع ذلك ، "الحموضة" &lt;تقاس بـ&gt; "درجة الحموضة"</para>
    ///   <para>Y&lt;指示&gt;X。生物体的疾病或病征Y指示疾病X。例如：“感染性休克”&lt;指示&gt;“败血症”。仅适用于疾病。但是，“酸性”&lt;由...测量&gt;“酸碱度”。</para>
    ///   <para>Y &lt;indica&gt; X. Una enfermedad o trastorno característico Y en un organismo indica enfermedad X. Ej. "Shock séptico" &lt;indica&gt; "Septicemia". Úselo solo para enfermedades. Pero, "Acidez" &lt;si mide mediante&gt; "pH".</para>
    ///   <para>Y &lt;является симптомом&gt; X. Характеристика болезни или расстройства Y в организме указывает на болезнь X. Например, "септицемия" &lt;является симптомом&gt; "септический шок". Используется только для болезней. Однако "кислотность" &lt;измеряется&gt; "pH".</para>
    ///   <para>Y &lt;indique&gt; X. Une maladie ou un désordre caractéristique Y dans un organisme indique une maladie X. Par ex. "choc septique" &lt;indique&gt; "septicémie". Utiliser uniquement pour les maladies. Cependant, "acidité" &lt;est mesuré par&gt; "pH".
    /// </para>
    ///   <para>Y &lt;indicates&gt; X. A disease or disorder characteristic Y in an organism indicates disease X. E.g. "septic shock" &lt;indicates&gt; "septicaemia". Use only for diseases. However, "acidity" &lt;is measured by&gt; "pH".</para>
    /// labels<para>является симптомом</para><para>Indicates</para><para>Indique</para><para>Indica</para><para>يُظهر</para><para>指示</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#indicates">http://aims.fao.org/aos/agrontology#indicates</seealso>
    let indicates = Prefixed_Name(aos, "indicates") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTaxonomicRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;a le rang taxonomique&gt; Y. Décrit le rang taxonomique Y de l'organisme X. "Spodoptera frugiperda" &lt;a le rang taxonomique&gt; "espèce (taxon)" </para>
    ///   <para>X&lt;有分类等级&gt;Y。描述了生物体X的分类等级Y。例如：“草地贪夜蛾”&lt;有分类等级&gt;“物种(分类单位)”。</para>
    ///   <para>X &lt;имеет таксономический ранг&gt; Y. Описывает таксономический ранг Y организма X. "Spodoptera frugiperda" &lt;имеет таксономический ранг&gt; "вид (таксон)".</para>
    ///   <para>X &lt;tiene el rango taxonómico&gt; Y. Describe el rango taxonómico Y del organismo X. Ej. "Spodoptera frugiperda" &lt;tiene el rango taxonómico&gt;  "Especie (taxón)". </para>
    ///   <para>X &lt;has taxonomic rank&gt; Y. Describes taxonomic rank Y of organism X. “Spodoptera frugiperda” &lt;has taxonomic rank&gt; “species (taxa)”. </para>
    ///   <para>س &lt;لها مرتبة تصنيفية في&gt; ع. تصف المرتبة التصنيفية ع الكائن الحي س.
    /// على سبيل المثال:  "Spodoptera frugiperda" &lt;لها مرتبة تصنيفية في&gt; "الأنواع (نظام التصنيف)".
    /// </para>
    /// labels<para>имеет таксономический ранг</para><para>Tiene el rango taxonómico</para><para>لديها المرتبة التصنيفية</para><para>A le rang taxonomique</para><para>Has taxonomic rank</para><para>有分类等级</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTaxonomicRank">http://aims.fao.org/aos/agrontology#hasTaxonomicRank</seealso>
    let hasTaxonomicRank = Prefixed_Name(aos, "hasTaxonomicRank") |> PrefixedName
    /// <summary>
    ///   <para>aos:isTaxonomicRankOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> Y &lt;es el rango taxonómico de&gt; X. Describe el rango taxonómico Y del organismo X. Ej.
    /// "Especie (taxón)" &lt;es el rango taxonómico de&gt; "Spodoptera frugiperda".</para>
    ///   <para>Y &lt;est le rang taxonomique de&gt; X. Décrit le rang taxonomique Y de l'organisme X. "espèce (taxons)" &lt;est le rang taxonomique de&gt; "Spodoptera frugiperda".</para>
    ///   <para>Y &lt;является таксономическим рангом&gt; X. Описывает таксономический ранг Y организма X. Например, "вид (таксон)" &lt;является таксономическим рангом&gt; "Spodoptera frugiperda".</para>
    ///   <para> Y &lt;is taxonomic rank of&gt; X. Describes taxonomic rank Y of organism X. E.g. “species (taxa)” &lt;is taxonomic rank of&gt; “Spodoptera frugiperda”.</para>
    ///   <para> Y&lt;是...的分类等级&gt;X。描述了生物体X的分类等级Y。例如：“物种(分类单位)”&lt;是...的分类等级&gt;“草地贪夜蛾”。</para>
    ///   <para>ع &lt;هي رتبة تصنيفية لـ&gt; س. تصف المرتبة التصنيفية ع الكائن الحي س.
    /// على سبيل المثال: "الأنواع (نظام التصنيف)" &lt;هي رتبة تصنيفية لـ&gt; "Spodoptera frugiperda"</para>
    /// labels<para>является таксономическим рангом</para><para>Est le rang taxonomique de</para><para>Es el rango taxonómico de</para><para>Is taxonomic rank of</para><para>هي رتبة تصنيفية</para><para>是...的分类等级</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isTaxonomicRankOf">http://aims.fao.org/aos/agrontology#isTaxonomicRankOf</seealso>
    let isTaxonomicRankOf = Prefixed_Name(aos, "isTaxonomicRankOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTermType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Has term type</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTermType">http://aims.fao.org/aos/agrontology#hasTermType</seealso>
    let hasTermType = Prefixed_Name(aos, "hasTermType") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>From CWR ontology.</para>
    /// labels<para>Has theme</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTheme">http://aims.fao.org/aos/agrontology#hasTheme</seealso>
    let hasTheme = Prefixed_Name(aos, "hasTheme") |> PrefixedName
    /// <summary>
    ///   <para>aos:isThemeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>From CWR ontology.</para>
    /// labels<para>Is theme of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isThemeOf">http://aims.fao.org/aos/agrontology#isThemeOf</seealso>
    let isThemeOf = Prefixed_Name(aos, "isThemeOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTradeName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has trade name, has commercial name</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTradeName">http://aims.fao.org/aos/agrontology#hasTradeName</seealso>
    let hasTradeName = Prefixed_Name(aos, "hasTradeName") |> PrefixedName
    /// <summary>
    ///   <para>aos:isTradeNameOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is a trade name of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isTradeNameOf">http://aims.fao.org/aos/agrontology#isTradeNameOf</seealso>
    let isTradeNameOf = Prefixed_Name(aos, "isTradeNameOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasTransliteration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has transliteration</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasTransliteration">http://aims.fao.org/aos/agrontology#hasTransliteration</seealso>
    let hasTransliteration = Prefixed_Name(aos, "hasTransliteration") |> PrefixedName
    /// <summary>
    ///   <para>aos:typeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;является разновидностью&gt; X. Понятие Y является разновидностью X. Связь &lt;является разновидностью&gt; шире и очень похожа на &lt;skos:broader&gt;, но не является исключительной.  Например, "галоп" &lt;является разновидностью&gt; "походки лошади", но также слоны и верблюды могут скакать галопом.</para>
    ///   <para>Y  &lt;es tipo de&gt;  X. &lt;es tipo te&gt; es más amplio y bastante similar a &lt;skos:broader&gt;, pero no es exclusivo.  Ej."Galope" &lt;es tipo de&gt; "Aires del caballo", pero también los elefantes y los camellos pueden galopar.</para>
    ///   <para>Y &lt;est un type de&gt; X. Concept Y est un type de X. &lt;est un type de&gt; est plus large et assez similaire à &lt;skos:broader&gt;, mais il n'est pas exclusif. Par exemple, "galop" &lt;est un type de&gt; "allure de cheval", mais aussi les éléphants et les chameaux peuvent galoper.</para>
    ///   <para>Y&lt;是...的类型&gt;X。概念Y是X的一种类型。&lt;是...的类型&gt;的范围更广，与&lt;skos:broader&gt;十分相似，但不具有排他性。例如：“驰骋”&lt;是...的类型&gt;“马的步态”，但大象和骆驼也可以驰骋。</para>
    ///   <para>Y &lt;type of&gt; X. Concept Y is a type of X.  &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “gallop” &lt;type of&gt; “horse gaits”, but also elephants and camels can gallop.</para>
    ///   <para>ع &lt;هو نمط من &gt; س. المفهوم ع هو نمط من س.&lt;نمط من&gt; أوسع ويشبه تمامًا &lt;skos: أوسع&gt; ، لكنه ليس حصريًا
    /// على سبيل المثال: "العدو السريع" &lt;هو نمط من &gt; "مشي الخيل"، ولكن أيضاً الفيلة والإبل يمكنها العدو السريع</para>
    /// labels<para>является разновидностью</para><para>Est un type de</para><para>Es tipo de</para><para>هو نوع من</para><para>Type of</para><para>是...的类型</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#typeOf">http://aims.fao.org/aos/agrontology#typeOf</seealso>
    let typeOf = Prefixed_Name(aos, "typeOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasVariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Simmetric relationship indicating that two concepts are variety each other.</para>
    /// labels<para>Has variety</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasVariety">http://aims.fao.org/aos/agrontology#hasVariety</seealso>
    let hasVariety = Prefixed_Name(aos, "hasVariety") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasWeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has weed</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasWeed">http://aims.fao.org/aos/agrontology#hasWeed</seealso>
    let hasWeed = Prefixed_Name(aos, "hasWeed") |> PrefixedName
    /// <summary>
    ///   <para>aos:includesSubprocess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;includesSubprocess&gt; Y. Process X naturally or conventionally realized at the minimum through process Y. Equivalent to &lt;stageOf&gt;. E.g. "milk production" &lt;includesSubprocess&gt; "pasteurization";</para>
    /// labels<para>Includes subprocess</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#includesSubprocess">http://aims.fao.org/aos/agrontology#includesSubprocess</seealso>
    let includesSubprocess = Prefixed_Name(aos, "includesSubprocess") |> PrefixedName
    /// <summary>
    ///   <para>aos:isSubprocessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;isSubprocessOf&gt; X. Y is one of one or more processes naturally or conventionally associated with the realization of process X. E.g. "pasteurization" &lt;isSubprocessOf&gt; "milk production";</para>
    /// labels<para>Is subprocess of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSubprocessOf">http://aims.fao.org/aos/agrontology#isSubprocessOf</seealso>
    let isSubprocessOf = Prefixed_Name(aos, "isSubprocessOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:influences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Influences</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#influences">http://aims.fao.org/aos/agrontology#influences</seealso>
    let influences = Prefixed_Name(aos, "influences") |> PrefixedName
    /// <summary>
    ///   <para>aos:isInfluencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is influenced by or Depends on</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isInfluencedBy">http://aims.fao.org/aos/agrontology#isInfluencedBy</seealso>
    let isInfluencedBy = Prefixed_Name(aos, "isInfluencedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:isDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X&lt;源自&gt;Y。物质或产品X的获得完全源自Y，不含额外的物质或产品。例如：“杏仁油”&lt;源自&gt;“杏仁”，“橙汁”&lt;源自&gt;“甜橙”。用于表示生物体及其衍生产品的关系：“羊肉”&lt;源自&gt;“绵羊”。</para>
    ///   <para>س &lt;مشتق من&gt; ع. يتم الحصول على المادة و المنتج س حصريً من المصدر ع وبدون أي مادة أو منتج إضافي.
    /// على سبيل المثال: " زيت اللوز" &lt;مشتق من&gt; " اللوز"
    /// "عصير البرتقال" &lt;مشتق من&gt; " البرتقال الحلو".
    /// تستخدم لربط كائن حي بمنتج مشتق: "لحم الضأن" &lt;مشتق من&gt; "الخروف".</para>
    ///   <para>X &lt;is derived from&gt; Y. A substance or product X obtained exclusively from source Y without any additional substance or product. E.g. “almond oil” &lt;is derived from&gt; “almonds”, “orange juice” &lt;is derived from&gt; “sweet oranges”. Use to relate an organism with a derived product: “mutton” &lt;is derived from&gt; “sheep”. </para>
    ///   <para>X &lt;получен из&gt; Y. Вещество или продукт X, полученный исключительно из источника Y без каких-либо дополнительных веществ или продуктов. Например, "миндальное масло" &lt;получен из&gt; "миндаль (орехи)", "апельсиновый сок" &lt;получен из&gt; "сладкие апельсины". Используется, чтобы показать связь между организмом и полученным из него продуктом: "баранина" &lt;получен из&gt; "овцы". </para>
    ///   <para>X &lt;est dérivé de&gt; Y. Une substance ou un produit X obtenu exclusivement à partir de la source Y sans aucune substance ou produit supplémentaire. Par exemple, "huile d'amande" &lt;est dérivé de&gt; "amande", "jus d'orange" &lt;est dérivé de&gt; "orange douce". À utiliser pour relier un organisme à un produit dérivé "viande ovine" &lt;est dérivé de&gt; "ovin".</para>
    ///   <para>X &lt;es derivado de&gt; Y. Una sustancia o producto X obtenido exclusivamente de la fuente Y sin ninguna sustancia o producto adicional. Ej. “Aceite de almendra” &lt;es derivado de&gt; “Almendra”, “Zumo de naranja” &lt;es derivado de&gt; “Naranja dulce”. Se utiliza para relacionar un organismo con un producto derivado: “Carne de carnero” &lt;es derivado de&gt; “Ovinos”. </para>
    /// labels<para>Is derived from</para><para>Es derivado de</para><para>Est dérivé de</para><para>получен из</para><para>مشتق من</para><para>源自</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isDerivedFrom">http://aims.fao.org/aos/agrontology#isDerivedFrom</seealso>
    let isDerivedFrom = Prefixed_Name(aos, "isDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>aos:isSourceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;هو مصدر&gt; س.
    /// على سبيل المثال: " اللوز" &lt;هو مصدر&gt; "زيت اللوز"
    /// "البرتقال الحلو" &lt;هو مصدر&gt; " عصير البرتقال"
    /// تستخدم لربط كائن حي بمنتج مشتق: "الخروف" &lt;هو مصدر&gt; "لحم الضأن"
    /// (لكن العسل &lt;يتم إنتاجه من قبل&gt; "نحل العسل"، "مخلفات العلف المخزون" &lt;هي نتاج&gt; " العلف المخزون")</para>
    ///   <para>Y&lt;是...的来源&gt;X。例如：“杏仁”&lt;是...的来源&gt;“杏仁油”，“甜橙”&lt;是...的来源&gt;“橙汁”。用于表示生物体及其衍生产品的关系：“绵羊”&lt;是...的来源&gt;“羊肉”。（但是，“蜂蜜”&lt;由...生产&gt; “蜜蜂”，“青贮料渗出液”&lt;是...的产品&gt;“青贮饲料”。）</para>
    ///   <para>Y &lt;est source de&gt; X. Ex. "amande" &lt;est source de&gt; "huile d'amande", "oranges douce" &lt;est source de&gt; "jus d'orange". Utiliser pour relier un organisme à un produit dérivé : "ovin" &lt;est source de&gt; "viande ovine". (Mais "miel" &lt;est produit par&gt; "abeille domestique", "effluent d'ensilage" &lt;est le produit de&gt; "ensilage (produit)".)</para>
    ///   <para>Y &lt;is source of&gt; X. E.g. “almonds" &lt;is source of&gt; “almond oil”, “sweet oranges”&lt;is source of&gt; “orange juice". Use to relate an organism with a derived product: “sheep” &lt;is source of&gt; “mutton”.  (But “honey” &lt;is produced by&gt; “honey bees”, “silage effluents” &lt;product of&gt; “silage”.)</para>
    ///   <para>Y &lt;является источником&gt; X. Например, " миндаль (орехи)" &lt;является источником&gt; "миндальное масло", "апельсины" &lt;является источником&gt; "апельсиновый сок". Используется, чтобы показать связь между организмом и производным продуктом: "овцы" &lt;является источником&gt; "баранина".  (Но "Однако "мед" &lt;производится&gt; "медоносные пчелы", " силосные стоки" &lt;является продуктом&gt; "силос").</para>
    ///   <para>Y &lt;es fuente de&gt; X. E.g. “Almendra" &lt;es fuente de&gt; “Aceite de almendra", “Naranja dulce” &lt;es fuente de&gt; “Zumo de naranja". Se utiliza para relacionar un organismo con un producto derivado: “Ovinos” &lt;es fuente de&gt; “Carne de carnero”.  (Pero “Miel” &lt;es producido por&gt; “Abeja melífera”, “Efluentes del ensilaje” &lt;producto de&gt; “Ensilado”.)</para>
    /// labels<para>является источником</para><para>Est source de</para><para>Is source of</para><para>Es fuente de</para><para>是...的来源</para><para>هو مصدر</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSourceOf">http://aims.fao.org/aos/agrontology#isSourceOf</seealso>
    let isSourceOf = Prefixed_Name(aos, "isSourceOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:isInputFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is input for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isInputFor">http://aims.fao.org/aos/agrontology#isInputFor</seealso>
    let isInputFor = Prefixed_Name(aos, "isInputFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:isOutputFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is output from</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isOutputFrom">http://aims.fao.org/aos/agrontology#isOutputFrom</seealso>
    let isOutputFrom = Prefixed_Name(aos, "isOutputFrom") |> PrefixedName
    /// <summary>
    ///   <para>aos:isMadeFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para> X &lt;está hecho de&gt; Y.  El producto X se fabrica principalmente a partir de una sustancia o un producto Y. Ej. "Queso de oveja" &lt;está hecho de&gt; "Leche de oveja", "Hormigón" &lt;está hecho de&gt; "Cemento", "Tocino magro" &lt;está hecho de&gt; "Carne de cerdo". Elemento de procesamiento más fuerte que &lt;es fuente de&gt;.</para>
    ///   <para>X &lt;est fait de&gt; Y. Le produit X est principalement fabriqué à partir d'une substance ou d'un produit Y. Par exemple, "fromage de brebis" &lt;est fait de&gt; "lait de brebis", "béton" &lt;est fait de&gt; "ciment", "bacon" &lt;est fait de&gt; "viande porcine". Élément de traitement plus puissant que &lt;est source de&gt;.
    /// </para>
    ///   <para> X&lt;由...制成&gt;Y。产品X主要由物质或产品Y制成。例如：“绵羊乳干酪”&lt;由...制成&gt; “绵羊奶”，“混凝土”&lt;由...制成&gt;“水泥”，“培根”&lt;由...制成&gt;“猪肉”。比&lt;是...的来源&gt;有更强的加工要素。</para>
    ///   <para>س &lt;مصنوع من&gt; ع. المنتج س مصنوع بشكل أساسي من المادة أو المنتج ع.
    /// على سبيل المثال:  "جبن الغنم" &lt;مصنوع من&gt; "حليب النعجة"
    /// "الخرسانة" &lt;مصنوعة من&gt; "الأسمنت"
    /// "لحم الخنزير المملح" &lt;مصنوع من&gt; "لحم الخنزير".
    /// عنصر معالجة أقوى من &lt;هو مصدر&gt;</para>
    ///   <para> X &lt;is made from&gt; Y.  Product X is mainly made from substance or a product Y. E.g. "sheep cheese" &lt;is made from&gt; "ewe milk", "concrete" &lt;is made from&gt; "cement", "bacon" &lt;is made from&gt; "pork". Stronger processing element than &lt;is source of&gt;.</para>
    ///   <para> X &lt;сделан из&gt; Y. Продукт X в основном производится из вещества или продукта Y. Например, "овечий сыр" &lt;сделан из&gt; "овечье молоко", "бетон" &lt;сделан из&gt; "цемент", "бекон," &lt;сделан из&gt; "свинина". Более сильный элемент обработки, чем &lt;сделан из&gt;.</para>
    /// labels<para>Está hecho de</para><para>Is made from</para><para>Est fait de</para><para>сделан из</para><para>مصنوعه من</para><para>由...制成</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isMadeFrom">http://aims.fao.org/aos/agrontology#isMadeFrom</seealso>
    let isMadeFrom = Prefixed_Name(aos, "isMadeFrom") |> PrefixedName
    /// <summary>
    ///   <para>aos:isUsedToMake</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;se utiliza para  hacer&gt; X. Una sustancia o un producto Y se utiliza para fabricar el producto X. Ej. "Leche de oveja" &lt;se utiliza para  hacer&gt; "Queso de oveja", "Cemento" &lt;se utiliza para  hacer&gt; "Hormigón", "Carne de cerdo" &lt;se utiliza para  hacer&gt; "Tocino magro". Elemento de procesamiento más fuerte que &lt;es fuente de&gt;.</para>
    ///   <para>Y &lt;est utilisé pour fabriquer&gt; X. Une substance ou un produit Y est utilisé pour fabriquer le produit X. Ex. "lait de brebis" &lt;est utilisé pour fabriquer&gt; "fromage de brebis",  "ciment" &lt;est utilisé pour fabriquer&gt; "béton", "viande porcine" &lt;est utilisé pour fabriquer&gt; "bacon". Élément de traitement plus puissant que &lt;est dérivé de&gt;. </para>
    ///   <para>Y &lt;is used to make&gt; X. A substance or a product Y is used to make product X. E.g. "ewe milk" &lt;is used to make&gt; "sheep cheese", "cement" &lt;is used to make&gt; "concrete", "pork" &lt;is used to make&gt; "bacon". Stronger processing element than &lt;is source of&gt;.</para>
    ///   <para>ع &lt;يستخدم لصنع&gt; س. المادة أو المنتج ع تستخدم لصنع المنتج س.
    /// على سبيل المثال: "حليب النعجة" &lt;يستخدم لصنع&gt; "جبن الغنم"
    /// "الاسمنت" &lt;يستخدم لصنع&gt; "الخرسانة"
    /// عنصر معالجة أقوى من &lt;هو مصدر&gt;</para>
    ///   <para>Y &lt;используется для производства&gt; X. Вещество или продукт Y используется для производства продукта X. Например, "овечье молоко" &lt;используется для производства&gt; "овечий сыр", "цемент" &lt;используется для производства&gt; "бетон", "свинина" &lt;используется для производства&gt; "бекон". Более сильная степень обработки, чем &lt;является источником&gt;.</para>
    ///   <para>Y&lt;用于制作&gt; X。物质或产品Y用于制作产品X。例如：“绵羊奶”&lt;用于制作&gt; “绵羊乳干酪”，“水泥”&lt;用于制作&gt;“混凝土”，“猪肉”&lt;用于制作&gt; “培根”。比&lt;是...的来源&gt;有更强的加工要素。</para>
    /// labels<para>используется для производства</para><para>Est utilisé pour fabriquer</para><para>Se utiliza para hacer</para><para>Is used to make</para><para>يستخدم لصنع</para><para>用于制作</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isUsedToMake">http://aims.fao.org/aos/agrontology#isUsedToMake</seealso>
    let isUsedToMake = Prefixed_Name(aos, "isUsedToMake") |> PrefixedName
    /// <summary>
    ///   <para>aos:isMeansFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;isMeansFor&gt; Y. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;performedWithInstrument&gt; "curry paste grinding machine"; "weapon" &lt;instrumentFor&gt; "killing"; "fishing pole" &lt;instrumentFor&gt; "fishing"; "alcohol" &lt;instrumentFor&gt; "cleaning"; Ploughs &lt;isMeansFor&gt; Ploughing ;but NOT "knives" &lt;instrumentFor&gt; "felling" (because knives are not primarily used for cutting down trees);</para>
    /// labels<para>Is means for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isMeansFor">http://aims.fao.org/aos/agrontology#isMeansFor</seealso>
    let isMeansFor = Prefixed_Name(aos, "isMeansFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:measures</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;يقيس&gt; س.يتم استخدام ع لقياس خاصية الكمية لـ س.
    /// على سبيل المثال: " ميزان الحرارة" &lt;يقيس&gt; "درجة الحرارة"
    /// "المؤشرات الاجتماعية " &lt;تقيس&gt; " التغير الاجتماعي"</para>
    ///   <para>Y &lt;medidas&gt; X. Y se utiliza para medir una propiedad cuantitativa de X. Ej. “Termómetros” &lt;medidas&gt; “Temperatura”, “Indicadores sociales” &lt;medidas&gt; ”Cambio social”.</para>
    ///   <para>Y&lt;测量&gt;X。Y用于测量X数量方面的属性。例如：“体温计”&lt;测量&gt;“温度”，“社会指标”&lt;测量&gt;“社会变迁”。</para>
    ///   <para>Y &lt;measures&gt; X. Y is used to measure a quantitative property of X. For example: “thermometers” &lt;measures&gt; “temperature”, “social indicators” &lt;measures&gt; ”social change”.</para>
    ///   <para>Y &lt;измеряет&gt; X. Y используется для измерения количественного свойства X. Например: "термометры" &lt;измеряет&gt; "температура", "социальные показатели" &lt;измеряет&gt; "социальные изменения".</para>
    ///   <para>Y &lt;mesure&gt; X. Y est utilisé pour mesurer une propriété quantitative de X. Par exemple, "thermomètre"  &lt;mesure&gt; "température", "indicateur social"  &lt;mesure&gt; "changement social".</para>
    /// labels<para>Measures</para><para>измеряет</para><para>س يقيس ص</para><para>Medidas</para><para>Mesure</para><para>测量</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#measures">http://aims.fao.org/aos/agrontology#measures</seealso>
    let measures = Prefixed_Name(aos, "measures") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPartOfSubvocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>FAIT PARTIE DU SOUS-VOCABULAIRE</para><para>ЯВЛЯЕТСЯ ЧАСТЬЮ МИКРОТЕЗАУРУСА</para><para>ES PARTE DE UN SUBVOCABULARIO</para><para>Is part of subvocabulary</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPartOfSubvocabulary">http://aims.fao.org/aos/agrontology#isPartOfSubvocabulary</seealso>
    let isPartOfSubvocabulary =
        Prefixed_Name(aos, "isPartOfSubvocabulary") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is performed by</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPerformedBy">http://aims.fao.org/aos/agrontology#isPerformedBy</seealso>
    let isPerformedBy = Prefixed_Name(aos, "isPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:performs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Performs</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#performs">http://aims.fao.org/aos/agrontology#performs</seealso>
    let performs = Prefixed_Name(aos, "performs") |> PrefixedName
    /// <summary>
    ///   <para>aos:isPreventedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;предотвращается&gt; Y. X может быть уменьшен, прерван или предотвращен Y. Например, "передача болезни" &lt;предотвращается&gt; "мытье рук", "профессиональные риски" &lt;предотвращается&gt; "безопасность труда".</para>
    ///   <para>X &lt;is prevented by&gt; Y. X can be reduced, interrupted or prevented by Y. E.g. "disease transmission" &lt;is prevented by&gt; "hand hygiene", "occupational hazards" &lt;is prevented by&gt; "safety at work".</para>
    ///   <para>س &lt;يُمنع من خلال&gt; ع. يمكن تقليل س أو مقاطعته أو منعه بواسطة ع.
    /// على سبيل المثال: "نقل المرض" &lt;يتم منعه من خلال&gt; "نظافة اليدين"،
    ///  "المخاطر المهنية" &lt;يتم منعها بواسطة&gt; "السلامة في العمل". </para>
    ///   <para>X&lt;由...防止&gt;Y。X可通过Y来减少、中断或防止。例如：“疾病传播”&lt;由...防止&gt; “洗手”， “职业危害”&lt;由...防止&gt;“工作安全”。</para>
    ///   <para>X &lt;est empêché par&gt; Y. X peut être réduit, interrompu ou empêché par Y. Par exemple, "transmission des maladies" &lt;est empêché par&gt; "lavage des mains", "risque professionnel" &lt;est empêché par&gt; "sécurité du travail". </para>
    ///   <para>X &lt;se previene con&gt; Y. X puede ser reducido, interrumpido o prevenido por Y.  Ej. "Transmisión de enfermedades" &lt;se previene con&gt; "Higiene de manos", "Riesgos ocupacionales" &lt;se previene con&gt; "Seguridad en el trabajo".</para>
    /// labels<para>Is prevented by</para><para>Se previene con</para><para>предотвращается</para><para>Est empêché par</para><para>تم منعه بواسطة</para><para>由...防止</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPreventedBy">http://aims.fao.org/aos/agrontology#isPreventedBy</seealso>
    let isPreventedBy = Prefixed_Name(aos, "isPreventedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:controls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Controls</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#controls">http://aims.fao.org/aos/agrontology#controls</seealso>
    let controls = Prefixed_Name(aos, "controls") |> PrefixedName
    /// <summary>
    ///   <para>aos:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Follows</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#follows">http://aims.fao.org/aos/agrontology#follows</seealso>
    let follows = Prefixed_Name(aos, "follows") |> PrefixedName
    /// <summary>
    ///   <para>aos:isPracticeFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is practice for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPracticeFor">http://aims.fao.org/aos/agrontology#isPracticeFor</seealso>
    let isPracticeFor = Prefixed_Name(aos, "isPracticeFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:productOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;est le produit de&gt; X, avec un élément de traitement. Y est produit ou fabriqué à la suite de X. Par exemple, "déchet d'exploitation forestière" &lt;est le produit de&gt; "exploitation forestière", "xérès" &lt;est le produit de&gt; "Espagne". Cependant, "miel" &lt;est produit par&gt; "abeille domestique". </para>
    ///   <para>Y &lt;product of&gt; X, with a processing element. Y is produced or manufactured as a result or consequence of X. E.g. “logging wastes” &lt;product of&gt; “logging”, “sherry” &lt;product of&gt; “Spain”. However, “honey” &lt;is produced by&gt; “honey bees”.</para>
    ///   <para>Y&lt;是...的产品&gt;X，其中有加工处理的要素。Y的生产或制造是X的结果或后果。例如：“砍伐损失”&lt;是...的产品&gt;“森林采运”，“雪利酒”&lt;是...的产品&gt;“ 西班牙”。但是，“蜂蜜” &lt;由...生产&gt;“蜜蜂”。</para>
    ///   <para>ع &lt;هو نتاج&gt; س مع عنصر معالجة. ع يتم إنتاجها أو تصنيعها كنتيجة أو عاقبة لـ س.
    /// على سبيل المثال: "نفايات قطع الأخشاب" &lt;هو نتاج&gt; "قطع الجذور"
    /// "الخمر شيري" &lt;هو نتاج&gt; "اسبانيا"
    /// "العسل" &lt;هو نتاج&gt; "نحل العسل"</para>
    ///   <para>Y &lt;producto de&gt; X, con un elemento de transformación. Y se produce o fabrica como resultado o consecuencia de X. Ej. “Residuos de explotación forestal” &lt;producto de&gt; “Aprovechamiento de la madera”, “Jerez” &lt;producto de&gt; “España”. Pero, “Miel” &lt;es producido por&gt; “Abeja melífera”.</para>
    ///   <para>Y является продуктом X, Y &lt;является продуктом&gt; X, с элементом обработки. Y производится или изготавливается как результат или следствие X. Например, "ферментированные продукты" &lt;является продуктом&gt; "брожение", "херес" &lt;является продуктом&gt; "Испания". Однако "мед" &lt;производится&gt; "медоносные пчелы".</para>
    /// labels<para>является продуктом</para><para>Est le produit de</para><para>Producto de</para><para>Product of</para><para>是...的产品</para><para>هو نتاج</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#productOf">http://aims.fao.org/aos/agrontology#productOf</seealso>
    let productOf = Prefixed_Name(aos, "productOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasPropagationMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has propagation material</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasPropagationMaterial">http://aims.fao.org/aos/agrontology#hasPropagationMaterial</seealso>
    let hasPropagationMaterial =
        Prefixed_Name(aos, "hasPropagationMaterial") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;هي خاصية لـ&gt; س. الخاصية قد تكون جودة أو ميزة.
    /// على سبيل المثال: "صلاحية البذور" &lt;هي خاصية لـ&gt; "البذور" ، "الخصائص الطبية" &lt;هي خاصية لـ&gt; "النباتات الطبية". </para>
    ///   <para>Y &lt;является свойством&gt; X. Свойство может быть качеством или признаком. Например, "жизнеспособность семян" &lt;является свойством&gt; "семенной материал", "фармакологические свойства" &lt;является свойством&gt; "лекарственные растения".</para>
    ///   <para>Y&lt;是...的属性&gt;X。属性可以是一种性质或特点。例如：“种子活力”&lt;是...的属性&gt;“种子”，“药物属性”&lt;是...的属性&gt;“药用植物类”。</para>
    ///   <para>Y &lt;est une propriété de&gt; X. Une propriété peut être une qualité ou un trait. Par exemple, "viabilité des semences" &lt;est une propriété de&gt; "semence", "propriété pharmacologique" &lt;est une propriété de&gt; "plante médicinale".</para>
    ///   <para>Y  &lt;es propriedad de&gt; X. Una propiedad puede ser una cualidad o un rasgo. Ej. “Viabilidad de la semilla” &lt;es propriedad de&gt; “Semillas”, “Propiedades medicinales” &lt;es propriedad de&gt; “Plantas medicinales”.</para>
    ///   <para>Y &lt;is property of&gt; X. A property might be a quality or trait. E.g. “seed viability” &lt;is property of&gt; “seed”, “medicinal properties” &lt;is property of&gt; “medicinal plants”.</para>
    /// labels<para>Est une propriété de</para><para>является свойством</para><para>Es propriedad de</para><para>Is property of</para><para>هي ملكية لـ</para><para>是...的属性</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPropertyOf">http://aims.fao.org/aos/agrontology#isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(aos, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasScientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;a nom scientifique&gt; Y. Par exemple, "truite de mer" &lt;a nom scientifique&gt; "Salmo trutta". Relation concept à concept à utiliser dans un concept. À utiliser lorsque le nom commun et le nom scientifique ne sont pas des concepts distincts, ou lorsqu'une relation distincte entre le nom scientifique et le nom commun est nécessaire pour une langue spécifique. Lorsque le nom commun et le nom scientifique sont des concepts distincts, utilisez la relation de concept à concept &lt;a concept taxonomique /a nom commun de concept&gt;.</para>
    ///   <para>X &lt;tiene nombre científico&gt; Y. Ej. "Trucha de mar" &lt;tiene nombre científico&gt; "Salmo trutta". Relación de etiqueta a etiqueta para su uso dentro de un concepto. Se utiliza cuando el nombre común y el nombre científico no son conceptos separados, o cuando se necesita una relación separada entre el nombre científico y el nombre común para un idioma específico. Cuando el nombre común y el nombre científico son conceptos separados, utilice la relación de concepto a concepto &lt;tiene concepto taxonómico/tiene nombre común del concepto&gt;.</para>
    ///   <para>X&lt;有学名&gt;Y。例如：“褐鳟”&lt;有学名&gt;“Salmo trutta”。可用于同一概念内的标签间关系。当俗名和学名不是独立的概念，或者当特定的语言需要在学名和俗名之间建立单独的关系时使用。当俗名和学名是独立的概念时，使用概念间关系&lt;有分类学概念/有常用名概念&gt;。</para>
    ///   <para>X &lt;has scientific name&gt; Y. E.g. “sea trout” &lt;has scientific name&gt; "Salmo trutta”. Label-to-label relationship for use within a concept. Use when common name and scientific name are not separate concepts, or when a separate relation between scientific and common name is needed for a specific language. When common name and scientific name are separate concepts, use concept-to-concept relation &lt;has taxonomic concept/has common name concept&gt;.</para>
    ///   <para>X &lt;имеет научное название&gt; Y. Например, "морская форель" &lt;имеет научное название&gt; "Salmo trutta". Отношения между метками для использования внутри понятия. Используется, когда обычное название и научное название не являются отдельными понятиями, или когда отдельное отношение между научным и обычным названием необходимо для конкретного языка. Когда обычное название и научное название являются отдельными понятиями, используйте отношение между понятиями &lt;имеет  таксономическое понятие/имеет обиходное название&gt;.</para>
    ///   <para>س &lt;لها الاسم العلمي&gt; ع.
    /// على سبيل المثال:  "التروت البحري" &lt;له الاسم العلمي&gt; "Salmo trutta”
    /// علاقة التسمية إلى التسمية للاستخدام داخل المفهوم.
    /// يستخدم عندما لا يكون الاسم الشائع والاسم العلمي مفهومين منفصلين ، أو عندما تكون هناك حاجة لعلاقة منفصلة بين الاسم العلمي والاسم الشائع للغة معينة. عندما يكون الاسم الشائع والاسم العلمي مفهومين منفصلين ، استخدم علاقة المفهوم بالمفهوم &lt;له مفهوم تصنيفي / له مفهوم اسم شائع&gt;. </para>
    /// labels<para>Tiene nombre científico</para><para>имеет научное название</para><para>Has scientific name</para><para>A nom scientifique</para><para>له اسم علمي</para><para>有学名</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasScientificName">http://aims.fao.org/aos/agrontology#hasScientificName</seealso>
    let hasScientificName = Prefixed_Name(aos, "hasScientificName") |> PrefixedName
    /// <summary>
    ///   <para>aos:isSubstituteFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is substitute for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isSubstituteFor">http://aims.fao.org/aos/agrontology#isSubstituteFor</seealso>
    let isSubstituteFor = Prefixed_Name(aos, "isSubstituteFor") |> PrefixedName
    /// <summary>
    ///   <para>aos:greaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Greater than</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#greaterThan">http://aims.fao.org/aos/agrontology#greaterThan</seealso>
    let greaterThan = Prefixed_Name(aos, "greaterThan") |> PrefixedName

    /// <summary>
    ///   <para>aos:isAGrowthEnvironmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;isAGrowthEnvironmentFor&gt; X. An environment Y favorable to a taxon X. This is used as the inverse relationship of &lt;growsIn&gt;. Use this in a plant and related domain (e.g. fungi). E.g. "isarn region" &lt;isAGrowthEnvironmentFor&gt; "jasmine rice"; "moist soil" &lt;isAGrowthEnvironmentFor&gt; "rice";</para>
    /// labels<para>Is a growth environment for</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAGrowthEnvironmentFor">http://aims.fao.org/aos/agrontology#isAGrowthEnvironmentFor</seealso>
    let isAGrowthEnvironmentFor =
        Prefixed_Name(aos, "isAGrowthEnvironmentFor") |> PrefixedName

    /// <summary>
    ///   <para>aos:isAbbreviationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is abbreviation of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAbbreviationOf">http://aims.fao.org/aos/agrontology#isAbbreviationOf</seealso>
    let isAbbreviationOf = Prefixed_Name(aos, "isAbbreviationOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:processRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Superpropiedad para relaciones de procesos</para>
    ///   <para>所有过程关系的父类属性</para>
    ///   <para>Super-property for process relationships</para>
    ///   <para>процессные отношения</para>
    ///   <para>Super-propriété pour les relations de processus </para>
    ///   <para>خاصية فائقة لعلاقات العملية</para>
    /// labels<para>Relaciones de procesos </para><para>Relations de processus</para><para>Process relationships</para><para>процессные отношения</para><para>علاقات العملية</para><para>过程关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#processRelationship">http://aims.fao.org/aos/agrontology#processRelationship</seealso>
    let processRelationship = Prefixed_Name(aos, "processRelationship") |> PrefixedName

    /// <summary>
    ///   <para>aos:isCultivationProcessOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is cultivation process of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isCultivationProcessOf">http://aims.fao.org/aos/agrontology#isCultivationProcessOf</seealso>
    let isCultivationProcessOf =
        Prefixed_Name(aos, "isCultivationProcessOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X  &lt;causa&gt; Y. El agente X (animado o inanimado) provoca un resultado Y. Ej. "Priones" &lt;causa&gt; "Encefalopatía espongiforme", "Déficit de humedad en el suelo"  &lt;causa&gt; "Marchitamiento".</para>
    ///   <para>X &lt;causes&gt; Y. Agent X (animate or inanimate) brings about a result Y. E.g. "prions" &lt;causes&gt; "spongiform encephalopathy", "soil moisture deficit" &lt;causes&gt; "wilting".</para>
    ///   <para>س &lt;يسبب&gt; ع. العامل س (حي أو غير حي) يحقق نتيجة ع.
    /// على سبيل المثال: "البريونات" &lt;تسبب&gt; "الاعتلال الدماغي الاسفنجي"
    /// "نقص في رطوبة التربة" &lt;يسبب&gt; "الذبول"</para>
    ///   <para>X &lt;вызывает &gt; Y. Агент X (одушевленный или неодушевленный) приводит к результату Y. Например, "прионы" &lt;вызывает&gt;  "губкообразная энцефалопатия", "водный дефицит в почве" &lt;вызывает&gt; "увядание".</para>
    ///   <para>X&lt;引起&gt;Y。媒介X（生物或非生物）引起结果Y。例如：“朊病毒”&lt;引起&gt;“海绵状脑病”，“土壤水分亏缺”&lt;引起&gt;“萎蔫”。</para>
    ///   <para>X  &lt;cause&gt; Y. L'agent X (animé ou inanimé) produit un résultat Y. Par exemple, "prion" &lt;cause&gt; "encéphalopathie spongiforme", "déficit d'humidité du sol" &lt;cause&gt; "fanaison".</para>
    /// labels<para>вызывает</para><para>الأسباب</para><para>Causes</para><para>Causa</para><para>Cause</para><para>引起关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#causes">http://aims.fao.org/aos/agrontology#causes</seealso>
    let causes = Prefixed_Name(aos, "causes") |> PrefixedName
    /// <summary>
    ///   <para>aos:isComposedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;состоит из&gt; Y. X состоит из материала или вещества Y. Например, "почвенная флора" &lt;состоит из&gt; "микробная флора", "туф (вулканический)" &lt;состоит из&gt; "вулканогенные материалы".
    /// </para>
    ///   <para>X &lt;está compuesto de&gt; Y.  X está compuesto de materia o sustancia Y. Ej. "Flora del suelo" &lt;está compuesto de&gt; "Flora microbiana", "Toba" &lt;está compuesto de&gt; "Materiales volcánicos".  </para>
    ///   <para>X &lt;is composed of&gt; Y. X is composed of material or substance Y . E.g. “soil flora” &lt;is composed of&gt; “microbial flora”, “tuff”&lt;is composed of&gt; “volcanic materials”.</para>
    ///   <para>X&lt;由...组成&gt;Y。X由材料或物质Y组成。例如：“土壤植物区系”&lt;由...组成&gt;“微生物菌群”，“凝灰岩”&lt;由...组成&gt;“火山灰物质”。</para>
    ///   <para>X &lt;est composé de&gt; Y.  X est composé de la matière ou de la substance Y. Par exemple, "flore du sol" &lt;est composé de"flore microbienne", "tuff" &lt;est composé de&gt; "matériau volcanique". </para>
    ///   <para>س &lt;يتكون من&gt; ع. يتكون س من المادة أو الأداة ع.
    /// على سبيل المثال: "نباتات التربة" &lt;تتكون من &gt; "نباتات جرثومية"
    /// " صخر tuff"&lt;يتكون من&gt; "مواد بركانية".
    /// </para>
    /// labels<para>Está compuesto de</para><para>Is composed of</para><para>Est composé de</para><para>состоит из</para><para>يتكون من</para><para>由...组成</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isComposedOf">http://aims.fao.org/aos/agrontology#isComposedOf</seealso>
    let isComposedOf = Prefixed_Name(aos, "isComposedOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#precedes">http://aims.fao.org/aos/agrontology#precedes</seealso>
    let precedes = Prefixed_Name(aos, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>aos:isIncludedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;is included in&gt;X. X is an entity that includes the element Y. For example: "dehorning” &lt;included in&gt; ”animal husbandry methods”, “microbiological analysis" &lt;included in&gt; “water analysis”</para>
    ///   <para>Y&lt;包含于&gt;X。实体X包含元素Y。例如：“断角术”&lt;包含于&gt;“家畜饲养方法”，“微生物分析”&lt;包含于&gt;“水分析”。</para>
    ///   <para>Y &lt;incluido en&gt;X. X es una entidad que incluye el elemento Y. Ej. "Descorne" &lt;incluido en&gt; "Métodos de crianza", "Análisis microbiológico" &lt;incluido en&gt; "Análisis de agua".</para>
    ///   <para>X &lt;est inclus dans&gt;  Y. X est une entité qui inclut l'élément Y. Par exemple, "écornage" &lt;est inclus dans&gt; "méthode d'élevage", "analyse microbiologique" &lt;est inclus dans&gt; "analyse de l'eau".</para>
    ///   <para>Y &lt;включен в&gt; X. X - это сущность, которая включена в элемент Y. Например, "удаление рогов" &lt;включен в&gt; "методы выращивания и содержания животных", "микробиологический анализ" &lt;включен в&gt; "анализ воды".</para>
    ///   <para>ع &lt;متضمن في&gt; س. س هو كيان يتضمن العنصر ع
    /// على سبيل المثال: "عملية إزالة القرون" &lt;متضمنة في&gt;"طرق رعاية الحيوان"
    /// " تخصيص الموارد" &lt;متضمنة في&gt; "تحليل المياه"</para>
    /// labels<para>Est inclus dans</para><para>Is included in</para><para>Incluido en</para><para>включен в</para><para>مدرج في</para><para>包含于</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isIncludedIn">http://aims.fao.org/aos/agrontology#isIncludedIn</seealso>
    let isIncludedIn = Prefixed_Name(aos, "isIncludedIn") |> PrefixedName
    /// <summary>
    ///   <para>aos:formerlyIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Formerly includes</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#formerlyIncludes">http://aims.fao.org/aos/agrontology#formerlyIncludes</seealso>
    let formerlyIncludes = Prefixed_Name(aos, "formerlyIncludes") |> PrefixedName
    /// <summary>
    ///   <para>aos:smallerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Smaller than</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#smallerThan">http://aims.fao.org/aos/agrontology#smallerThan</seealso>
    let smallerThan = Prefixed_Name(aos, "smallerThan") |> PrefixedName
    /// <summary>
    ///   <para>aos:growsln</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;growsIn&gt; Y. A taxon X grows in an environment Y. Use this in a plant and related domain (e.g. fungi). E.g. "jasmine rice" &lt;growsIn&gt; "isarn region"; "rice" &lt;growsIn&gt; "moist soil";</para>
    /// labels<para>Grows in</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#growsln">http://aims.fao.org/aos/agrontology#growsln</seealso>
    let growsln = Prefixed_Name(aos, "growsln") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X&lt;有同义词&gt;Y。Y&lt;有同义词&gt;X。“保加利亚”&lt;有同义词&gt;“保加利亚共和国”。 用于区分准确的、目前的同义词和过去的、可能使用过的过时的术语（对于后者，使用&lt;有曾用名&gt;）。限用于同一概念某一特定语言的不同标签。</para>
    ///   <para>X &lt;a le synonyme&gt; Y. Y &lt;a le synonyme&gt; X .“Bulgarie” &lt;a le synonyme&gt; ”République de Bulgarie”. Utilisé pour distinguer un synonyme exact et actuel des termes obsolètes qui auraient pu être utilisés dans le passé (pour cela, utiliser &lt;a nom ancien&gt;). </para>
    ///   <para>X &lt;имеет синоним&gt; Y. Y &lt;имеет синоним&gt; X. "Болгария" &lt;имеет синоним&gt; "Республика Болгария". Используется, чтобы отличить точный и актуальный синоним от устаревших терминов, которые могли использоваться в прошлом (для этого используйте hasOldName). Используется только между обозначениями одного и того же понятия на определенном языке.</para>
    ///   <para>س &lt;له المرادف&gt; ع. ع &lt;له المرادف&gt; س
    /// على سبيل المثال: "بلغاريا" &lt;لها المرادف&gt; "جمهورية بلغاريا"
    /// يستخدم لتمييز المرادف الدقيق والحالي عن المصطلحات القديمة التي ربما تم استخدامها في الماضي (لذلك ، استخدم &lt;له اسم قديم&gt;). استخدم فقط بين التسميات لنفس المفهوم بلغة معينة</para>
    ///   <para>X &lt;tiene sinónimo&gt; Y. Y &lt;tiene sinónimo&gt; X. "Bulgaria" &lt;tiene sinónimo&gt; "República de Bulgaria". Se utiliza para distinguir un sinónimo exacto y actual de los términos obsoletos que pudieran haberse utilizado en el pasado (para ello, utilice &lt;tiene nombre antiguo&gt;). Se utiliza sólo entre etiquetas para el mismo concepto en un idioma específico.</para>
    ///   <para>X &lt;has synonym&gt; Y. Y &lt;has synonym&gt; X. “Bulgaria”&lt;has synonym&gt;”Republic of Bulgaria”. Used to distinguish an exact and current synonym from obsolete terms which might have been used in the past (for that, use &lt;has old name&gt;). Use only between labels for the same concept in a specific language.</para>
    /// labels<para>Tiene sinónimo</para><para>химеет синоним</para><para>A le synonyme</para><para>Has synonym</para><para>له مرادف</para><para>有同义词</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasSynonym">http://aims.fao.org/aos/agrontology#hasSynonym</seealso>
    let hasSynonym = Prefixed_Name(aos, "hasSynonym") |> PrefixedName
    /// <summary>
    ///   <para>aos:isAcronymOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y&lt;是...的缩略语&gt;X。缩略语由其他单词首字母组成，通常读作一个词。“艾滋病”&lt;是...的缩略语&gt;“获得性免疫缺陷综合征”。</para>
    ///   <para>ع &lt;هي اختصار لـ&gt; س. الاختصار هو اختصار يتكون من الأحرف الأولى للكلمات الأخرى ، وغالبًا ما يتم نطقه ككلمة.
    /// على سبيل المثال:  "مرض الايدز" &lt;هو اختصار لـ&gt; "متلازمة نقص المناعة المكتسبة"
    /// </para>
    ///   <para>Y &lt;est l'acronyme de&gt; X. Un acronyme est une abréviation formée des lettres initiales d'autres mots, souvent prononcées comme un mot. “UE” &lt;est l'acronyme de&gt; ”Union européenne”. </para>
    ///   <para>Y &lt;es acrónimo de&gt; X. Un acrónimo es una abreviatura formada por las letras iniciales de otras palabras, que a menudo se pronuncia como una palabra.  "SIDA" &lt;es acrónimo de&gt; "Síndrome de inmunodeficiencia adquirida".</para>
    ///   <para>Y &lt;is acronym of&gt; X. An acronym is an abbreviation formed from the initial letters of other words, often pronounced as a word.  “AIDS” &lt;is acronym of&gt;”acquired immunodeficiency syndrome”.</para>
    ///   <para>Y &lt;является акронимом&gt; X. Акроним - это аббревиатура, образованная из начальных букв других слов, часто произносимая как слово.  "СПИД" &lt;является акронимом&gt; "синдром приобретенного иммунодефицита".</para>
    /// labels<para>является акронимом</para><para>Est l'acronyme de</para><para>Es acrónimo de</para><para>Is acronym of</para><para>هو اختصار</para><para>是...的缩略语</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAcronymOf">http://aims.fao.org/aos/agrontology#isAcronymOf</seealso>
    let isAcronymOf = Prefixed_Name(aos, "isAcronymOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasAntonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has antonym or Has opposite</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasAntonym">http://aims.fao.org/aos/agrontology#hasAntonym</seealso>
    let hasAntonym = Prefixed_Name(aos, "hasAntonym") |> PrefixedName

    /// <summary>
    ///   <para>aos:isBiologicalControlAgentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is biological control agent of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isBiologicalControlAgentOf">http://aims.fao.org/aos/agrontology#isBiologicalControlAgentOf</seealso>
    let isBiologicalControlAgentOf =
        Prefixed_Name(aos, "isBiologicalControlAgentOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:hasBreedingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has breeding method</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasBreedingMethod">http://aims.fao.org/aos/agrontology#hasBreedingMethod</seealso>
    let hasBreedingMethod = Prefixed_Name(aos, "hasBreedingMethod") |> PrefixedName
    /// <summary>
    ///   <para>aos:isBreedingMethodOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is breeding method of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isBreedingMethodOf">http://aims.fao.org/aos/agrontology#isBreedingMethodOf</seealso>
    let isBreedingMethodOf = Prefixed_Name(aos, "isBreedingMethodOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasBroaderSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Has broader synonym</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasBroaderSynonym">http://aims.fao.org/aos/agrontology#hasBroaderSynonym</seealso>
    let hasBroaderSynonym = Prefixed_Name(aos, "hasBroaderSynonym") |> PrefixedName
    /// <summary>
    ///   <para>aos:isChemicalFormulaOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is chemical formula of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isChemicalFormulaOf">http://aims.fao.org/aos/agrontology#isChemicalFormulaOf</seealso>
    let isChemicalFormulaOf = Prefixed_Name(aos, "isChemicalFormulaOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCodeAsc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Has ASC code</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeAsc">http://aims.fao.org/aos/agrontology#hasCodeAsc</seealso>
    let hasCodeAsc = Prefixed_Name(aos, "hasCodeAsc") |> PrefixedName
    /// <summary>
    ///   <para>aos:isTransliterationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is a transliteration of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isTransliterationOf">http://aims.fao.org/aos/agrontology#isTransliterationOf</seealso>
    let isTransliterationOf = Prefixed_Name(aos, "isTransliterationOf") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>El concepto X tiene tipos Y. &lt;tiene tipo&gt; es más amplio y bastante similar a &lt;skos:broader&gt;, pero no es exclusivo.  Ej. "Aires del caballo" &lt;tiene tipo&gt; "Galope", pero también los elefantes y los camellos pueden galopar.</para>
    ///   <para>X &lt;has type&gt; Y. Concept X has types Y. &lt;type of&gt; is broader and quite similar to &lt;skos:broader&gt;, but  it is not exclusive.  E.g. “horse gaits” &lt;has type&gt; “gallop”, but also elephants and camels can gallop.</para>
    ///   <para>X&lt;有类型&gt;Y。概念X有类型Y。&lt;有类型&gt;的范围更广，与&lt;skos:broader&gt;十分相似，但不具有排他性。例如：“马的步态”&lt;有类型&gt;“驰骋”，但大象和骆驼也可以驰骋。</para>
    ///   <para>X &lt;a le type&gt; Y. Le concept X a des types Y. &lt;a le type&gt; est plus large et assez similaire à &lt;skos:broader&gt;, mais il n'est pas exclusif.  Par exemple, "allure de cheval" &lt;a le type&gt; "galop", mais aussi les éléphants et les chameaux peuvent galoper.</para>
    ///   <para>X &lt;имеет разновидность &gt; Y. Понятие X имеет разновидности Y. Связь &lt;имеет разновидность&gt; шире и очень похожа на &lt;skos:broader&gt;, но не является исключительной.  Например, "походки лошади" &lt;имеет разновидность&gt; "галоп", но также слоны и верблюды могут скакать галопом.</para>
    ///   <para>س &lt;لديه النمط&gt; ع. للمفهوم س الأنماط ع.&lt;نمط من&gt; أوسع ويشبه تمامًا &lt;skos: أوسع&gt; ، لكنه ليس حصريًا
    /// على سبيل المثال: "مشي الخيل" &lt;لديها نمط&gt; "العدو السريع"، ولكن أيضاً الفيلة والإبل يمكنها العدو السريع</para>
    /// labels<para>имеет разновидность</para><para>Tiene tipo</para><para>A le type</para><para>Has type</para><para>لديه نوع</para><para>有类型</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasType">http://aims.fao.org/aos/agrontology#hasType</seealso>
    let hasType = Prefixed_Name(aos, "hasType") |> PrefixedName
    /// <summary>
    ///   <para>aos:isWeedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Is weed of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isWeedOf">http://aims.fao.org/aos/agrontology#isWeedOf</seealso>
    let isWeedOf = Prefixed_Name(aos, "isWeedOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:isPerformedByMeansOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;isPerformedByMeansOf&gt; X. An object or process X mainly used to perform a process Y. See also &lt;usedAs&gt;. E.g. "curry paste grinding" &lt;isPerformedByMeansOf&gt; "curry paste grinding machine"; "weapon" &lt;meansFor&gt; "killing"; "fishing pole" &lt;meansFor&gt; "fishing"; "alcohol" &lt;meansFor&gt; "cleaning"; but NOT "knives" &lt;meansFor&gt; "felling" (because knives are not primarily used for cutting down trees);</para>
    /// labels<para>Is performed by means of</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isPerformedByMeansOf">http://aims.fao.org/aos/agrontology#isPerformedByMeansOf</seealso>
    let isPerformedByMeansOf =
        Prefixed_Name(aos, "isPerformedByMeansOf") |> PrefixedName

    /// <summary>
    ///   <para>aos:isMeasuredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;si mide mediante&gt; Y. Una propiedad cuantitativa de X se mide con Y. Ej. “Temperatura” &lt;si mide mediante&gt; “Termómetros”, “Cambio social” &lt;si mide mediante&gt; "Indicadores sociales".</para>
    ///   <para>س &lt;تُقاس من قبل&gt; ع. يتم قياس خاصية الكمية لـ س بواسطة ع
    /// على سبيل المثال: "الحرارة" &lt;تُقاس من قبل&gt; "ميزان الحرارة"
    /// التغير الاجتماعي &lt;يُقاس من قبل&gt; " المؤشرات الاجتماعية"</para>
    ///   <para>X &lt;измеряется&gt; Y. Количественное свойство X измеряется Y. Например, "температура" &lt;измеряется&gt; "термометры", "социальные изменения" &lt;измеряется&gt; "социальные показатели".</para>
    ///   <para>X &lt;est mesuré par&gt; Y. Une propriété quantitative de X est mesurée par Y. Par exemple : "température" &lt;est mesuré par&gt; "thermomètre", "changement social" &lt;est mesuré par&gt; "indicateur social".</para>
    ///   <para>X &lt;is measured by&gt; Y. A quantitative property of X is measured by Y. For example: “temperature” &lt;is measured by&gt; “thermometers”, “social change” &lt;is measured by&gt; “social indicators".</para>
    ///   <para>X&lt;由...测量&gt;Y。X数量方面的属性由Y测量。例如：“温度”&lt;由...测量&gt;“体温计”，“社会变迁”&lt;由...测量&gt;“社会指标”。</para>
    /// labels<para>يتم قياس x بواسطة y</para><para>Si mide mediante</para><para>Est mesuré par</para><para>Is measured by</para><para>измеряется</para><para>由...测量</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isMeasuredBy">http://aims.fao.org/aos/agrontology#isMeasuredBy</seealso>
    let isMeasuredBy = Prefixed_Name(aos, "isMeasuredBy") |> PrefixedName

    /// <summary>
    ///   <para>aos:RangeOfIsPartOfSubvocabulary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    /// </remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#RangeOfIsPartOfSubvocabulary">http://aims.fao.org/aos/agrontology#RangeOfIsPartOfSubvocabulary</seealso>
    let RangeOfIsPartOfSubvocabulary =
        Prefixed_Name(aos, "RangeOfIsPartOfSubvocabulary") |> PrefixedName

    /// <summary>
    ///   <para>aos:isAffectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ع &lt;يتأثر بـ &gt;س . يغير الكائن "ع" حالته أو موقعه بسبب إجراء قام به العامل "س".
    /// على سبيل المثال. "الأشجار" تتأثر بـ "مبيدات الشجر" ،
    /// "جودة النقل" تتأثر "بالضرر الميكانيكي".
    /// لا تستخدم للأمراض أو الاضطرابات. لهؤلاء استخدم &lt;afflicts / isAfflictedBy&gt;.</para>
    ///   <para>Y &lt;está afectado por&gt; X. Un objeto Y cambia de estado o ubicación debido a la acción de un agente X. Ej. "Árboles" &lt;está afectado por&gt; "Arboricidas", "Aptitud para el transporte" &lt;está afectado por&gt; "Daños mecánicos". No lo utilice para enfermedades o trastornos; para ellos, utilice &lt;aflige/está afligido por&gt;. </para>
    ///   <para>Y&lt;受...影响&gt; X。对象Y的状态或位置由于媒介X的行为而发生变化。例如：“树”&lt;受...影响&gt;“树木毒杀剂”，“运输性能”&lt;受...影响&gt;“机械损伤”。 请勿用于疾病或病症；对于疾病和病症，使用&lt;损伤/受...损伤&gt;。</para>
    ///   <para>Y &lt;est affecté par&gt; X. Un objet Y change d'état ou de localisation suite à l'action d'un agent X. Par exemple, "arbre" &lt;est affecté par&gt; "arboricide", "aptitude au transport" &lt;est affecté par&gt; "dégât mécanique". Ne l'utilisez pas pour des maladies ou des désordres: pour ceux-là, utilisez &lt;afflige/est affligé par&gt;.</para>
    ///   <para>на Y влияет X. Объект Y изменяет состояние или местоположение из-за действия агента X. Например, на "деревья" влияет "арборициды", на "качество транспортировки" влияет "механические повреждения".  Не используйте для болезней или расстройств; для них используйте &lt;поражает/на ... негативно влияет болезнь .....&gt;. </para>
    ///   <para>Y &lt;is affected by&gt; X. An object Y changes state or location because of an action of an agent X. E.g. "trees" &lt;is affected by&gt; "arboricides", "transporting quality" &lt;is affected by&gt; "mechanical damage". Do not use for diseases or disorders; for those, use &lt;afflicts/is afflicted by&gt;. </para>
    /// labels<para>на ... влияет ....</para><para>Está afectado por</para><para>Est affecté par</para><para>Is affected by</para><para>يتأثر بها</para><para>受...影响</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#isAffectedBy">http://aims.fao.org/aos/agrontology#isAffectedBy</seealso>
    let isAffectedBy = Prefixed_Name(aos, "isAffectedBy") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCodeFaoPa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Has code in the schema FAO Priority Area</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeFaoPa">http://aims.fao.org/aos/agrontology#hasCodeFaoPa</seealso>
    let hasCodeFaoPa = Prefixed_Name(aos, "hasCodeFaoPa") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCodeFaoterm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Has FAO term code</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeFaoterm">http://aims.fao.org/aos/agrontology#hasCodeFaoterm</seealso>
    let hasCodeFaoterm = Prefixed_Name(aos, "hasCodeFaoterm") |> PrefixedName
    /// <summary>
    ///   <para>aos:hasCodeISO3Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The International Standard for country codes and codes for their subdivisions. Alpha-3 code – a three-letter code that represents a country name, which is usually more closely related to the country name</para>
    ///   <para>المعيار الدولي لرموز الدول ورموز التقسيمات الفرعية الخاصة بهم.
    /// رمز Alpha-3 - رمز مكون من ثلاثة أحرف يمثل اسم البلد ، والذي يكون عادةً أكثر ارتباطًا باسم البلد </para>
    ///   <para>La norma internacional para los códigos de nombres de países y sus subdivisiones. Código Alfa-3: código de tres letras utilizado para la representación de nombres de países, que permite la asociación visual con el nombre común del país.</para>
    ///   <para>La Norme internationale des codes des noms de pays et de leurs subdivisions. Code alpha-3 – code à trois lettres utilisé pour la représentation des noms de pays, permettant une association visuelle avec le nom usuel du pays.</para>
    ///   <para>国家代码及其分区代码的国际标准。Alpha-3代码是代表国家名称的三位字母代码，通常更接近于国家名称。</para>
    ///   <para>ИСО 3166 является международным стандартом для представления названий стран и единиц их административно-территориального деления.</para>
    /// labels<para>Tiene código ISO3 de país </para><para>Has ISO 3 country code</para><para>Имеет код страны ISO3</para><para>لديه رمز البلد ISO3 </para><para>A le code pays ISO3</para><para>有ISO3国家码</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#hasCodeISO3Country">http://aims.fao.org/aos/agrontology#hasCodeISO3Country</seealso>
    let hasCodeISO3Country = Prefixed_Name(aos, "hasCodeISO3Country") |> PrefixedName
    /// <summary>
    ///   <para>aos:spatialRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Superpropiedad de las relaciones espaciales</para>
    ///   <para>خاصية فائقة للعلاقات المكانية</para>
    ///   <para>所有空间关系的父类属性</para>
    ///   <para>Super-propriété pour les relations spatiales </para>
    ///   <para>Super-property for spatial relationships</para>
    ///   <para>Сверхсвойство для пространственных отношений</para>
    /// labels<para>пространственные отношения
    /// </para><para>Relaciones espaciales </para><para>Relations spatiales </para><para>Spatial relationship</para><para>العلاقات المكانية</para><para>空间关系</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#spatialRelationship">http://aims.fao.org/aos/agrontology#spatialRelationship</seealso>
    let spatialRelationship = Prefixed_Name(aos, "spatialRelationship") |> PrefixedName
    /// <summary>
    ///   <para>aos:spatiallyIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>X &lt;spatially includes&gt; Y. Region X spatially includes as inalienable part the spatial region Y. E.g. "Africa" &lt;spatially includes&gt; "African inland waters", "Andean region" &lt;spatially includes&gt; "Peru".</para>
    ///   <para>X &lt;пространственно включает&gt; Y. Регион X пространственно включает в качестве неотъемлемой части пространственный регион Y. Например, "Африка" &lt;пространственно включает&gt; "внутренние воды Африки", "Андский регион" &lt;пространственно включает&gt; "Перу".</para>
    ///   <para>X &lt;spatialement inclut&gt; Y. La région X comprend spatialement comme partie inaliénable la région spatiale Y. Par exemple, "Afrique" &lt;spatialement inclu&gt; "eaux continentales africaines", "région andine" &lt;spatialement inclu&gt; "Pérou".</para>
    ///   <para>X &lt;incluye espacialmente&gt; Y. La parte X es una parte inalienable de Y (la región espacial ocupada por Y es una parte de la región espacial ocupada por X). Ej. "África" &lt;incluye espacialmente&gt; "Aguas interiores de África", "Región andina" &lt;incluye espacialmente&gt; "Perú". </para>
    ///   <para>X&lt;空间包含&gt;Y。区域X在空间上包含空间区域Y ，作为其不可分割的一部分。例如：“非洲”&lt;空间包含&gt;“非洲大陆水体”，“安第斯山脉地区”&lt;空间包含&gt;“秘鲁”。</para>
    ///   <para>س &lt;يشمل مكانياً &gt; ع. تتضمن المنطقة س مكانيًا كجزء غير قابل للتصرف المنطقة المكانية ع
    /// على سبيل المثال: "إفريقيا" &lt;تشمل مكانياً&gt; "المياه الداخلية الإفريقية" ،
    /// و "منطقة الأنديز" &lt;تشمل مكانيًا&gt; "البيرو". </para>
    /// labels<para>пространственно включает</para><para>Incluye espacialmente</para><para>Spatialement inclut</para><para>Spatially includes</para><para>x مكانيًا يشمل y</para><para>空间包含</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#spatiallyIncludes">http://aims.fao.org/aos/agrontology#spatiallyIncludes</seealso>
    let spatiallyIncludes = Prefixed_Name(aos, "spatiallyIncludes") |> PrefixedName
    /// <summary>
    ///   <para>aos:study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Y &lt;étude&gt; X. Domaine, science ou groupe Y étude concept X. Par exemple, "sédimentologie" &lt;étude&gt; "sédiment", "anatomie du bois" &lt;étude&gt; "bois de coeur".</para>
    ///   <para>Y &lt;estudia&gt; X. El campo, la ciencia o el grupo Y estudia el concepto X. Ej. “Sedimentología” &lt;estudia&gt; “Sedimento”,
    /// “Anatomía de la madera” &lt;estudia&gt; “Duramen”.</para>
    ///   <para>Y &lt;изучает&gt; X. Область, наука или группа Y изучает понятие X. Например, "седиментология" &lt;изучает&gt; "осадок", "строение древесины" &lt;изучает&gt; "ядровая древесина".
    /// "строение древесины" &lt;изучает&gt; "ядровая древесина".</para>
    ///   <para>Y &lt;study&gt; X. Field, science or group Y studies concept X. E.g. “sedimentology” &lt;study&gt; “sediment”,
    /// “wood anatomy” &lt;study&gt; “heartwood”.</para>
    ///   <para>ع&lt;تدرس&gt;س. العلم أو المجموعة ع تدرس المفهوم س.
    /// على سبيل المثال "علم الرواسب" &lt;تدرس&gt;"الرواسب" ،
    ///  "تشريح الخشب" &lt;تدرس&gt; "قلب الخشب".</para>
    ///   <para>Y&lt;研究&gt;X。领域、科学或组群Y研究X。例如：“沉积学”&lt;研究&gt;“沉积物”，“木材解剖学”&lt;研究&gt;“心材”。</para>
    /// labels<para>изучает</para><para>Estudia</para><para>دراسات</para><para>Study</para><para>Étude</para><para>研究</para></remarks>
    /// <seealso href="http://aims.fao.org/aos/agrontology#study">http://aims.fao.org/aos/agrontology#study</seealso>
    let study = Prefixed_Name(aos, "study") |> PrefixedName
