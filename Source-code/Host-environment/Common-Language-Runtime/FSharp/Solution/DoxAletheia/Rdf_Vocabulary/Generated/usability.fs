namespace https.w3id.org.usability.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module usability =
    let _namespace_iri = Namespace_Iri usability |> NamespaceIRI

    /// <summary>
    ///   <para>usability:ClickMouseActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents any mouse click</para>
    ///   <para>Клик (click) — щелчок по кнопке мыши.</para>
    /// labels<para>КликМышьДействиеСобытие</para><para>ClickMouseActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#ClickMouseActionEvent">https://w3id.org/usability#ClickMouseActionEvent</seealso>
    let ClickMouseActionEvent =
        Prefixed_Name(usability, "ClickMouseActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:ActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Базовый класс, предназначенный для событий, которые представляют собой действия пользователя, относящиеся к взаимодействию пользователя с интерфейсом (клики, перемещения мыши и др.)</para>
    ///   <para>The base class for events which are user actions related to user interation with the interface (clicks, mouse movements, etc.)</para>
    /// labels<para>ДействиеСобытие</para><para>ActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#ActionEvent">https://w3id.org/usability#ActionEvent</seealso>
    let ActionEvent = Prefixed_Name(usability, "ActionEvent") |> PrefixedName
    /// <summary>
    ///   <para>usability:TouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Класс, который описывает события действий, связанных с взаимодействием пользователя с сенсорным экраном (тачскрин, англ. touchscreen), например, дисплеем телефона или планшетного компьютера</para>
    ///   <para>The class that represents events related to user interations with touchscreen, like smartphone or tablet PC</para>
    /// labels<para>КасаниеДействиеСобытие</para><para>TouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#TouchActionEvent">https://w3id.org/usability#TouchActionEvent</seealso>
    let TouchActionEvent = Prefixed_Name(usability, "TouchActionEvent") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasMaxWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasMaxWidth">https://w3id.org/usability#hasMaxWidth</seealso>
    let hasMaxWidth = Prefixed_Name(usability, "hasMaxWidth") |> PrefixedName
    /// <summary>
    ///   <para>usability:Region21</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Region</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Region21">https://w3id.org/usability#Region21</seealso>
    let Region21 = Prefixed_Name(usability, "Region21") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasDateTime">https://w3id.org/usability#hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(usability, "hasDateTime") |> PrefixedName

    /// <summary>
    ///   <para>usability:HoldTapTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents touch-and-hold action - continuous touch with a single finger</para>
    ///   <para>Тач-энд-холд (touch and hold) — нажать и держать.</para>
    /// labels<para>HoldTapTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#HoldTapTouchActionEvent">https://w3id.org/usability#HoldTapTouchActionEvent</seealso>
    let HoldTapTouchActionEvent =
        Prefixed_Name(usability, "HoldTapTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:hasDpiX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasDpiX">https://w3id.org/usability#hasDpiX</seealso>
    let hasDpiX = Prefixed_Name(usability, "hasDpiX") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasHeight">https://w3id.org/usability#hasHeight</seealso>
    let hasHeight = Prefixed_Name(usability, "hasHeight") |> PrefixedName

    /// <summary>
    ///   <para>usability:StretchTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents stretch (pinch it open) - tensile movement with two fingers on the screen to enlarge the image.</para>
    ///   <para>Стретч (stretch: для Microsoft), Пинч-ит-опен (pinch it open: для Apple) — растягивающее движение одновременно двумя пальцами по экрану для увеличения изображения.</para>
    /// labels<para>StretchTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#StretchTouchActionEvent">https://w3id.org/usability#StretchTouchActionEvent</seealso>
    let StretchTouchActionEvent =
        Prefixed_Name(usability, "StretchTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:TypeKeyboardActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents clicks on a keyboard</para>
    ///   <para>Класс, который описывает события нажатия клавиш клавиатуры</para>
    /// labels<para>ВводКлавиатураДействиеСобытие</para><para>TypeKeyboardActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#TypeKeyboardActionEvent">https://w3id.org/usability#TypeKeyboardActionEvent</seealso>
    let TypeKeyboardActionEvent =
        Prefixed_Name(usability, "TypeKeyboardActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:performed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Связывает пользователя с сессией, которую он выполнил</para>
    ///   <para>The property that associates a user with a session that he performed</para>
    /// labels<para>performed</para><para>выполнил</para></remarks>
    /// <seealso href="https://w3id.org/usability#performed">https://w3id.org/usability#performed</seealso>
    let performed = Prefixed_Name(usability, "performed") |> PrefixedName
    /// <summary>
    ///   <para>usability:User1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#User</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#User1">https://w3id.org/usability#User1</seealso>
    let User1 = Prefixed_Name(usability, "User1") |> PrefixedName
    /// <summary>
    ///   <para>usability:User2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#User</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#User2">https://w3id.org/usability#User2</seealso>
    let User2 = Prefixed_Name(usability, "User2") |> PrefixedName
    /// <summary>
    ///   <para>usability:CommandEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents events, related with the fact of calling a certain command (function) by the user</para>
    ///   <para>Класс, который описывает события команд. Они служат для фиксации факта вызова определенной команды (функции) пользователем.</para>
    /// labels<para>КомандаСобытие</para><para>CommandEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#CommandEvent">https://w3id.org/usability#CommandEvent</seealso>
    let CommandEvent = Prefixed_Name(usability, "CommandEvent") |> PrefixedName
    /// <summary>
    ///   <para>usability:wasInvokedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that associates specific command with the event in which the command was called</para>
    ///   <para>Связывает команду с командным событием, в котором команда была вызвана</para>
    /// labels<para>wasInvokedIn</para><para>былоВызваноВ</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasInvokedIn">https://w3id.org/usability#wasInvokedIn</seealso>
    let wasInvokedIn = Prefixed_Name(usability, "wasInvokedIn") |> PrefixedName

    /// <summary>
    ///   <para>usability:wasAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that associates command event with the specific command instance</para>
    ///   <para>Связывает командное событие с экземпляром команды</para>
    /// labels<para>wasAssociatedWith</para><para>связанаС</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasAssociatedWith">https://w3id.org/usability#wasAssociatedWith</seealso>
    let wasAssociatedWith =
        Prefixed_Name(usability, "wasAssociatedWith") |> PrefixedName

    /// <summary>
    ///   <para>usability:RegionVariation111</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Variation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#RegionVariation111">https://w3id.org/usability#RegionVariation111</seealso>
    let RegionVariation111 =
        Prefixed_Name(usability, "RegionVariation111") |> PrefixedName

    /// <summary>
    ///   <para>usability:CommandEvent1114</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#CommandEvent</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#CommandEvent1114">https://w3id.org/usability#CommandEvent1114</seealso>
    let CommandEvent1114 = Prefixed_Name(usability, "CommandEvent1114") |> PrefixedName
    /// <summary>
    ///   <para>usability:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Транзитивное свойство, которое определят, что некий объект содержит/хранит внутря себя какой-либо другой объект</para>
    ///   <para>A transitive property which determines that some subject contains/stores some object inside of it. Inverse of isContainedIn</para>
    /// labels<para>contains</para><para>cодержит</para></remarks>
    /// <seealso href="https://w3id.org/usability#contains">https://w3id.org/usability#contains</seealso>
    let contains = Prefixed_Name(usability, "contains") |> PrefixedName
    /// <summary>
    ///   <para>usability:CommandEvent2112</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#CommandEvent</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#CommandEvent2112">https://w3id.org/usability#CommandEvent2112</seealso>
    let CommandEvent2112 = Prefixed_Name(usability, "CommandEvent2112") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasCommandName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasCommandName">https://w3id.org/usability#hasCommandName</seealso>
    let hasCommandName = Prefixed_Name(usability, "hasCommandName") |> PrefixedName
    /// <summary>
    ///   <para>usability:CommandEvent1113</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#CommandEvent</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#CommandEvent1113">https://w3id.org/usability#CommandEvent1113</seealso>
    let CommandEvent1113 = Prefixed_Name(usability, "CommandEvent1113") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasUid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasUid">https://w3id.org/usability#hasUid</seealso>
    let hasUid = Prefixed_Name(usability, "hasUid") |> PrefixedName
    /// <summary>
    ///   <para>usability:wasUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Связывает устройство с сессиями, которые были на нем запущены</para>
    ///   <para>The property that associates a device with the sessions which were run on that device</para>
    /// labels<para>былоИспользованоВ</para><para>wasUsedIn</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasUsedIn">https://w3id.org/usability#wasUsedIn</seealso>
    let wasUsedIn = Prefixed_Name(usability, "wasUsedIn") |> PrefixedName
    /// <summary>
    ///   <para>usability:Session2</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Session</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Session2">https://w3id.org/usability#Session2</seealso>
    let Session2 = Prefixed_Name(usability, "Session2") |> PrefixedName
    /// <summary>
    ///   <para>usability:Session1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Session</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Session1">https://w3id.org/usability#Session1</seealso>
    let Session1 = Prefixed_Name(usability, "Session1") |> PrefixedName

    /// <summary>
    ///   <para>usability:TapTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Класс, предназначенный для описания различных видов тапов - прикосновений пользователя к экрану одним пальцем без движения</para>
    ///   <para>The class that represents differend kinds events related to user's tap on the touch screen</para>
    /// labels<para>TapTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#TapTouchActionEvent">https://w3id.org/usability#TapTouchActionEvent</seealso>
    let TapTouchActionEvent =
        Prefixed_Name(usability, "TapTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Устройство, на котором выполнялись(ются) сессии.</para>
    /// labels<para>The device on which the sessions were performed.</para><para>Устройство</para><para>Device</para></remarks>
    /// <seealso href="https://w3id.org/usability#Device">https://w3id.org/usability#Device</seealso>
    let Device = Prefixed_Name(usability, "Device") |> PrefixedName
    /// <summary>
    ///   <para>usability:Session</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Временной промежуток, в течение которого пользователь взаимодействует с программной системой</para>
    ///   <para>A period of time when a user interacts with the software</para>
    /// labels<para>Session</para><para>Сессия</para></remarks>
    /// <seealso href="https://w3id.org/usability#Session">https://w3id.org/usability#Session</seealso>
    let Session = Prefixed_Name(usability, "Session") |> PrefixedName

    /// <summary>
    ///   <para>usability:DoubleClickMouseEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents a double mouse click</para>
    ///   <para>Дабл-клик, двойной клик (double click) — два быстрых щелчка по кнопке мыши.</para>
    /// labels<para>ДвойнойКликМышьДействиеСобытие</para><para>DoubleClickMouseEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#DoubleClickMouseEvent">https://w3id.org/usability#DoubleClickMouseEvent</seealso>
    let DoubleClickMouseEvent =
        Prefixed_Name(usability, "DoubleClickMouseEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:wasImaged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property that associates an image with the corresponding region variation</para>
    ///   <para>Связывает изображение с соответствующей вариацией региона</para>
    /// labels<para>изображает</para><para>wasImaged</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasImaged">https://w3id.org/usability#wasImaged</seealso>
    let wasImaged = Prefixed_Name(usability, "wasImaged") |> PrefixedName
    /// <summary>
    ///   <para>usability:Device1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:usability#Device</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Device1">https://w3id.org/usability#Device1</seealso>
    let Device1 = Prefixed_Name(usability, "Device1") |> PrefixedName

    /// <summary>
    ///   <para>usability:DoubleTapTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Дабл-тап, дабл-тэп (double tap) — два коротких нажатия пальцем, сродни дабл-клику.</para>
    ///   <para>The class that represents double tap - two short taps on the screen</para>
    /// labels<para>DoubleTapTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#DoubleTapTouchActionEvent">https://w3id.org/usability#DoubleTapTouchActionEvent</seealso>
    let DoubleTapTouchActionEvent =
        Prefixed_Name(usability, "DoubleTapTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:Event1111</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Event1111">https://w3id.org/usability#Event1111</seealso>
    let Event1111 = Prefixed_Name(usability, "Event1111") |> PrefixedName
    /// <summary>
    ///   <para>usability:Event1121</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:usability#Event</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Event1121">https://w3id.org/usability#Event1121</seealso>
    let Event1121 = Prefixed_Name(usability, "Event1121") |> PrefixedName
    /// <summary>
    ///   <para>usability:Event1122</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:usability#Event</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Event1122">https://w3id.org/usability#Event1122</seealso>
    let Event1122 = Prefixed_Name(usability, "Event1122") |> PrefixedName
    /// <summary>
    ///   <para>usability:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes an image of the region variation</para>
    ///   <para>Класс, описывающий изображение, хранящее внешний вид вариации региона</para>
    /// labels<para>Изображение</para><para>Image</para></remarks>
    /// <seealso href="https://w3id.org/usability#Image">https://w3id.org/usability#Image</seealso>
    let Image = Prefixed_Name(usability, "Image") |> PrefixedName
    /// <summary>
    ///   <para>usability:Variation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Класс предназначен для описания вариации региона, так как каждый регион, в свою очередь, может иметь одну или более вариаций. Под вариацией региона в общем случае может пониматься уникальное сочетание параметров высоты и ширины изображения региона, либо их диапазон</para>
    ///   <para>Class that describes a region variation, since a region may have one or more variations. Variation is a unique combination of region image's height and width, or their range</para>
    /// labels<para>ВариацияРегиона</para><para>Variation</para></remarks>
    /// <seealso href="https://w3id.org/usability#Variation">https://w3id.org/usability#Variation</seealso>
    let Variation = Prefixed_Name(usability, "Variation") |> PrefixedName
    /// <summary>
    ///   <para>usability:Event1112</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Event1112">https://w3id.org/usability#Event1112</seealso>
    let Event1112 = Prefixed_Name(usability, "Event1112") |> PrefixedName
    /// <summary>
    ///   <para>usability:Event2111</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Event</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Event2111">https://w3id.org/usability#Event2111</seealso>
    let Event2111 = Prefixed_Name(usability, "Event2111") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasDpiY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasDpiY">https://w3id.org/usability#hasDpiY</seealso>
    let hasDpiY = Prefixed_Name(usability, "hasDpiY") |> PrefixedName
    /// <summary>
    ///   <para>usability:Image111</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:usability#Image</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Image111">https://w3id.org/usability#Image111</seealso>
    let Image111 = Prefixed_Name(usability, "Image111") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasBinaryData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasBinaryData">https://w3id.org/usability#hasBinaryData</seealso>
    let hasBinaryData = Prefixed_Name(usability, "hasBinaryData") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasWidth">https://w3id.org/usability#hasWidth</seealso>
    let hasWidth = Prefixed_Name(usability, "hasWidth") |> PrefixedName
    /// <summary>
    ///   <para>usability:Image211</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Image</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Image211">https://w3id.org/usability#Image211</seealso>
    let Image211 = Prefixed_Name(usability, "Image211") |> PrefixedName
    /// <summary>
    ///   <para>usability:Image112</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Image</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Image112">https://w3id.org/usability#Image112</seealso>
    let Image112 = Prefixed_Name(usability, "Image112") |> PrefixedName

    /// <summary>
    ///   <para>usability:LongTapTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Тач (touch) — нажатие длиннее, чем Тап.</para>
    ///   <para>The class that represents touch - a touch that is slightly longer then tap</para>
    /// labels<para>LongTapTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#LongTapTouchActionEvent">https://w3id.org/usability#LongTapTouchActionEvent</seealso>
    let LongTapTouchActionEvent =
        Prefixed_Name(usability, "LongTapTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:MoveMouseActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents movements of cursor. hasInRegionX and hasInRegionY properties store information about the new cursor coordinates after the movement</para>
    ///   <para>Класс, который соответствует событию движения курсора мыши. Свойства hasInRegionX и hasInRegionY позволяют указать новые координаты курсора мыши после перемещения</para>
    /// labels<para>ДвижениеМышьДействиеСобытие</para><para>MoveMouseAcitonEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#MoveMouseActionEvent">https://w3id.org/usability#MoveMouseActionEvent</seealso>
    let MoveMouseActionEvent =
        Prefixed_Name(usability, "MoveMouseActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:KeyboardActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Класс, который описывает событий действий, связанных с манипуляцией пользователя с клавиатурой</para>
    ///   <para>The class that represents actions related to user's manipulations with a keyboard</para>
    /// labels<para>КлавиатураДействиеСобытие</para><para>KeyboardActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#KeyboardActionEvent">https://w3id.org/usability#KeyboardActionEvent</seealso>
    let KeyboardActionEvent =
        Prefixed_Name(usability, "KeyboardActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:PinchTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Пинч (pinch) — сжимающее движение одновременно двумя пальцами по экрану для уменьшения изображения.</para>
    ///   <para>The class that represents pinch - a contractive movement with two fingers on the screen to scale down the image.</para>
    /// labels<para>PinchTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#PinchTouchActionEvent">https://w3id.org/usability#PinchTouchActionEvent</seealso>
    let PinchTouchActionEvent =
        Prefixed_Name(usability, "PinchTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A fragment of GUI, for example, the whole window, or a part of it</para>
    ///   <para>Область пользовательского интерфейса, например, окно целиком, либо его отдельная часть</para>
    /// labels<para>Region</para><para>Регион</para></remarks>
    /// <seealso href="https://w3id.org/usability#Region">https://w3id.org/usability#Region</seealso>
    let Region = Prefixed_Name(usability, "Region") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasMinHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasMinHeight">https://w3id.org/usability#hasMinHeight</seealso>
    let hasMinHeight = Prefixed_Name(usability, "hasMinHeight") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasMaxHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasMaxHeight">https://w3id.org/usability#hasMaxHeight</seealso>
    let hasMaxHeight = Prefixed_Name(usability, "hasMaxHeight") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasMinWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasMinWidth">https://w3id.org/usability#hasMinWidth</seealso>
    let hasMinWidth = Prefixed_Name(usability, "hasMinWidth") |> PrefixedName
    /// <summary>
    ///   <para>usability:Region11</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Region</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#Region11">https://w3id.org/usability#Region11</seealso>
    let Region11 = Prefixed_Name(usability, "Region11") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The property which associate some region variation with its image</para>
    ///   <para>Свойство которое связывает вариацию региона с его изображением</para>
    /// labels<para>имеетИзображение</para><para>hasImage</para></remarks>
    /// <seealso href="https://w3id.org/usability#hasImage">https://w3id.org/usability#hasImage</seealso>
    let hasImage = Prefixed_Name(usability, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasEndDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasEndDateTime">https://w3id.org/usability#hasEndDateTime</seealso>
    let hasEndDateTime = Prefixed_Name(usability, "hasEndDateTime") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasStartDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasStartDateTime">https://w3id.org/usability#hasStartDateTime</seealso>
    let hasStartDateTime = Prefixed_Name(usability, "hasStartDateTime") |> PrefixedName
    /// <summary>
    ///   <para>usability:wasPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Связывает сессию с пользователем, который ее выполнял</para>
    ///   <para>The property that associates a session with the user who performed it</para>
    /// labels<para>былаВыполненаПользователем</para><para>wasPerformedBy</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasPerformedBy">https://w3id.org/usability#wasPerformedBy</seealso>
    let wasPerformedBy = Prefixed_Name(usability, "wasPerformedBy") |> PrefixedName

    /// <summary>
    ///   <para>usability:SingleClickMouseEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Клик (click) — одинарный щелчок по кнопке мыши, короткое нажатие.</para>
    ///   <para>The class that represents a single mouse click</para>
    /// labels<para>ОдинарныйКликМышьДействиеСобытие</para><para>SingleClickMouseEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#SingleClickMouseEvent">https://w3id.org/usability#SingleClickMouseEvent</seealso>
    let SingleClickMouseEvent =
        Prefixed_Name(usability, "SingleClickMouseEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:RegionVariation112</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Variation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#RegionVariation112">https://w3id.org/usability#RegionVariation112</seealso>
    let RegionVariation112 =
        Prefixed_Name(usability, "RegionVariation112") |> PrefixedName

    /// <summary>
    ///   <para>usability:ScrollMouseActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Класс, который соответствует событию прокрутки колесика мыши</para>
    ///   <para>The class that represents a mouse wheel scroll</para>
    /// labels<para>ПрокруткаМышьДействиеСобытие</para><para>ScrollMouseActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#ScrollMouseActionEvent">https://w3id.org/usability#ScrollMouseActionEvent</seealso>
    let ScrollMouseActionEvent =
        Prefixed_Name(usability, "ScrollMouseActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:wasPerformedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Связывает сессию с устройством, на котором она выполнялась</para>
    ///   <para>The property that associates a session with the device on which the session was run</para>
    /// labels<para>былаВыполненаНа</para><para>wasPerformedOn</para></remarks>
    /// <seealso href="https://w3id.org/usability#wasPerformedOn">https://w3id.org/usability#wasPerformedOn</seealso>
    let wasPerformedOn = Prefixed_Name(usability, "wasPerformedOn") |> PrefixedName
    /// <summary>
    ///   <para>usability:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The user who runs sessions</para>
    ///   <para>Пользователь, который выполнял(ет) сессии.</para>
    /// labels<para>Пользователь</para><para>User</para></remarks>
    /// <seealso href="https://w3id.org/usability#User">https://w3id.org/usability#User</seealso>
    let User = Prefixed_Name(usability, "User") |> PrefixedName

    /// <summary>
    ///   <para>usability:SingleTapTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Тап, тэп (tap) — короткое нажатие пальцем, сродни клику.</para>
    ///   <para>The class that represents tap action - single short touch with one finger</para>
    /// labels<para>SingleTapTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#SingleTapTouchActionEvent">https://w3id.org/usability#SingleTapTouchActionEvent</seealso>
    let SingleTapTouchActionEvent =
        Prefixed_Name(usability, "SingleTapTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:SwipeTouchActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class the represents swipe (slide) - a continuous movement of the finger across the screen</para>
    ///   <para>Свайп (swipe), Слайд (slide) — продолжительное скольжение пальцем по экрану.</para>
    /// labels<para>SwipeTouchActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#SwipeTouchActionEvent">https://w3id.org/usability#SwipeTouchActionEvent</seealso>
    let SwipeTouchActionEvent =
        Prefixed_Name(usability, "SwipeTouchActionEvent") |> PrefixedName

    /// <summary>
    ///   <para>usability:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Базовый класс для событий, которые могут происходить при взаимодействии пользователя с программной системой</para>
    ///   <para>The base class for all different kinds of event that may be occured while the user is interacting with the software</para>
    /// labels<para>Событие</para><para>Event</para></remarks>
    /// <seealso href="https://w3id.org/usability#Event">https://w3id.org/usability#Event</seealso>
    let Event = Prefixed_Name(usability, "Event") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasInRegionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasInRegionY">https://w3id.org/usability#hasInRegionY</seealso>
    let hasInRegionY = Prefixed_Name(usability, "hasInRegionY") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasInRegionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasInRegionX">https://w3id.org/usability#hasInRegionX</seealso>
    let hasInRegionX = Prefixed_Name(usability, "hasInRegionX") |> PrefixedName
    /// <summary>
    ///   <para>usability:MouseActionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class that represents actions related to user's manipulations with a mouse</para>
    ///   <para>Класс, который описывает события действий, связанных с манипуляцией пользователя с мышью</para>
    /// labels<para>МышьДействиеСобытие</para><para>MouseActionEvent</para></remarks>
    /// <seealso href="https://w3id.org/usability#MouseActionEvent">https://w3id.org/usability#MouseActionEvent</seealso>
    let MouseActionEvent = Prefixed_Name(usability, "MouseActionEvent") |> PrefixedName
    /// <summary>
    ///   <para>usability:Command</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Базовый класс команды, вызываемой пользователем.</para>
    /// labels<para>The base class for the command called by user</para><para>Команда</para><para>Command</para></remarks>
    /// <seealso href="https://w3id.org/usability#Command">https://w3id.org/usability#Command</seealso>
    let Command = Prefixed_Name(usability, "Command") |> PrefixedName
    /// <summary>
    ///   <para>usability:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#hasName">https://w3id.org/usability#hasName</seealso>
    let hasName = Prefixed_Name(usability, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>usability:isContainedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Транзитивное свойство, которое определяет, что некоторый объект содержится/хранится/находится внутри какого-либо другого объекта</para>
    ///   <para>A transitive property which determines that some object is contained/stored/located inside of some subject. Inverse of contains</para>
    /// labels<para>isContainedIn</para><para>содержитсяВ</para></remarks>
    /// <seealso href="https://w3id.org/usability#isContainedIn">https://w3id.org/usability#isContainedIn</seealso>
    let isContainedIn = Prefixed_Name(usability, "isContainedIn") |> PrefixedName
    /// <summary>
    ///   <para>usability:CommandA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Command</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#CommandA">https://w3id.org/usability#CommandA</seealso>
    let CommandA = Prefixed_Name(usability, "CommandA") |> PrefixedName
    /// <summary>
    ///   <para>usability:CommandB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:usability#Command</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#CommandB">https://w3id.org/usability#CommandB</seealso>
    let CommandB = Prefixed_Name(usability, "CommandB") |> PrefixedName

    /// <summary>
    ///   <para>usability:RegionVariation211</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:usability#Variation</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/usability#RegionVariation211">https://w3id.org/usability#RegionVariation211</seealso>
    let RegionVariation211 =
        Prefixed_Name(usability, "RegionVariation211") |> PrefixedName
