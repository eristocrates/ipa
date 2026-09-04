#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module usability =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/usability#" "usability"

    /// <summary>
    ///   <para>rdfs:label : ДействиеСобытиеrdfs:label : ActionEvent</para>
    ///   <para>rdfs:comment : Базовый класс, предназначенный для событий, которые представляют собой действия пользователя, относящиеся к взаимодействию пользователя с интерфейсом (клики, перемещения мыши и др.)rdfs:comment : The base class for events which are user actions related to user interation with the interface (clicks, mouse movements, etc.)</para>
    ///   <a href="https://w3id.org/usability#ActionEvent">usability:ActionEvent</a>
    /// </summary>
    let ActionEvent = _prefixId.prefix "ActionEvent"
    /// <summary>
    ///   <para>rdfs:label : КликМышьДействиеСобытиеrdfs:label : ClickMouseActionEvent</para>
    ///   <para>rdfs:comment : Клик (click) — щелчок по кнопке мыши.rdfs:comment : The class that represents any mouse click</para>
    ///   <a href="https://w3id.org/usability#ClickMouseActionEvent">usability:ClickMouseActionEvent</a>
    /// </summary>
    let ClickMouseActionEvent = _prefixId.prefix "ClickMouseActionEvent"
    /// <summary>
    ///   <para>rdfs:label : Командаrdfs:label : The base class for the command called by userrdfs:label : Command</para>
    ///   <para>rdfs:comment : Базовый класс команды, вызываемой пользователем.</para>
    ///   <a href="https://w3id.org/usability#Command">usability:Command</a>
    /// </summary>
    let Command = _prefixId.prefix "Command"
    let CommandA = _prefixId.prefix "CommandA"
    let CommandB = _prefixId.prefix "CommandB"
    /// <summary>
    ///   <para>rdfs:label : КомандаСобытиеrdfs:label : CommandEvent</para>
    ///   <para>rdfs:comment : Класс, который описывает события команд. Они служат для фиксации факта вызова определенной команды (функции) пользователем.rdfs:comment : The class that represents events, related with the fact of calling a certain command (function) by the user</para>
    ///   <a href="https://w3id.org/usability#CommandEvent">usability:CommandEvent</a>
    /// </summary>
    let CommandEvent = _prefixId.prefix "CommandEvent"
    let CommandEvent1113 = _prefixId.prefix "CommandEvent1113"
    let CommandEvent1114 = _prefixId.prefix "CommandEvent1114"
    let CommandEvent2112 = _prefixId.prefix "CommandEvent2112"
    /// <summary>
    ///   <para>rdfs:label : Устройствоrdfs:label : The device on which the sessions were performed.rdfs:label : Device</para>
    ///   <para>rdfs:comment : Устройство, на котором выполнялись(ются) сессии.</para>
    ///   <a href="https://w3id.org/usability#Device">usability:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    let Device1 = _prefixId.prefix "Device1"
    /// <summary>
    ///   <para>rdfs:label : ДвойнойКликМышьДействиеСобытиеrdfs:label : DoubleClickMouseEvent</para>
    ///   <para>rdfs:comment : Дабл-клик, двойной клик (double click) — два быстрых щелчка по кнопке мыши.rdfs:comment : The class that represents a double mouse click</para>
    ///   <a href="https://w3id.org/usability#DoubleClickMouseEvent">usability:DoubleClickMouseEvent</a>
    /// </summary>
    let DoubleClickMouseEvent = _prefixId.prefix "DoubleClickMouseEvent"
    /// <summary>
    ///   <para>rdfs:label : DoubleTapTouchActionEvent</para>
    ///   <para>rdfs:comment : Дабл-тап, дабл-тэп (double tap) — два коротких нажатия пальцем, сродни дабл-клику.rdfs:comment : The class that represents double tap - two short taps on the screen</para>
    ///   <a href="https://w3id.org/usability#DoubleTapTouchActionEvent">usability:DoubleTapTouchActionEvent</a>
    /// </summary>
    let DoubleTapTouchActionEvent = _prefixId.prefix "DoubleTapTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : Событиеrdfs:label : Event</para>
    ///   <para>rdfs:comment : Базовый класс для событий, которые могут происходить при взаимодействии пользователя с программной системойrdfs:comment : The base class for all different kinds of event that may be occured while the user is interacting with the software</para>
    ///   <a href="https://w3id.org/usability#Event">usability:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let Event1111 = _prefixId.prefix "Event1111"
    let Event1112 = _prefixId.prefix "Event1112"
    let Event1121 = _prefixId.prefix "Event1121"
    let Event1122 = _prefixId.prefix "Event1122"
    let Event2111 = _prefixId.prefix "Event2111"
    /// <summary>
    ///   <para>rdfs:label : HoldTapTouchActionEvent</para>
    ///   <para>rdfs:comment : Тач-энд-холд (touch and hold) — нажать и держать.rdfs:comment : The class that represents touch-and-hold action - continuous touch with a single finger</para>
    ///   <a href="https://w3id.org/usability#HoldTapTouchActionEvent">usability:HoldTapTouchActionEvent</a>
    /// </summary>
    let HoldTapTouchActionEvent = _prefixId.prefix "HoldTapTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:comment : Class that describes an image of the region variationrdfs:comment : Класс, описывающий изображение, хранящее внешний вид вариации региона</para>
    ///   <para>rdfs:label : Imagerdfs:label : Изображение</para>
    ///   <a href="https://w3id.org/usability#Image">usability:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    let Image111 = _prefixId.prefix "Image111"
    let Image112 = _prefixId.prefix "Image112"
    let Image211 = _prefixId.prefix "Image211"
    /// <summary>
    ///   <para>rdfs:label : КлавиатураДействиеСобытиеrdfs:label : KeyboardActionEvent</para>
    ///   <para>rdfs:comment : Класс, который описывает событий действий, связанных с манипуляцией пользователя с клавиатуройrdfs:comment : The class that represents actions related to user's manipulations with a keyboard</para>
    ///   <a href="https://w3id.org/usability#KeyboardActionEvent">usability:KeyboardActionEvent</a>
    /// </summary>
    let KeyboardActionEvent = _prefixId.prefix "KeyboardActionEvent"
    /// <summary>
    ///   <para>rdfs:label : LongTapTouchActionEvent</para>
    ///   <para>rdfs:comment : Тач (touch) — нажатие длиннее, чем Тап.rdfs:comment : The class that represents touch - a touch that is slightly longer then tap</para>
    ///   <a href="https://w3id.org/usability#LongTapTouchActionEvent">usability:LongTapTouchActionEvent</a>
    /// </summary>
    let LongTapTouchActionEvent = _prefixId.prefix "LongTapTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : МышьДействиеСобытиеrdfs:label : MouseActionEvent</para>
    ///   <para>rdfs:comment : Класс, который описывает события действий, связанных с манипуляцией пользователя с мышьюrdfs:comment : The class that represents actions related to user's manipulations with a mouse</para>
    ///   <a href="https://w3id.org/usability#MouseActionEvent">usability:MouseActionEvent</a>
    /// </summary>
    let MouseActionEvent = _prefixId.prefix "MouseActionEvent"
    /// <summary>
    ///   <para>rdfs:label : ДвижениеМышьДействиеСобытиеrdfs:label : MoveMouseAcitonEvent</para>
    ///   <para>rdfs:comment : Класс, который соответствует событию движения курсора мыши. Свойства hasInRegionX и hasInRegionY позволяют указать новые координаты курсора мыши после перемещенияrdfs:comment : The class that represents movements of cursor. hasInRegionX and hasInRegionY properties store information about the new cursor coordinates after the movement</para>
    ///   <a href="https://w3id.org/usability#MoveMouseActionEvent">usability:MoveMouseActionEvent</a>
    /// </summary>
    let MoveMouseActionEvent = _prefixId.prefix "MoveMouseActionEvent"
    /// <summary>
    ///   <para>rdfs:label : PinchTouchActionEvent</para>
    ///   <para>rdfs:comment : Пинч (pinch) — сжимающее движение одновременно двумя пальцами по экрану для уменьшения изображения.rdfs:comment : The class that represents pinch - a contractive movement with two fingers on the screen to scale down the image.</para>
    ///   <a href="https://w3id.org/usability#PinchTouchActionEvent">usability:PinchTouchActionEvent</a>
    /// </summary>
    let PinchTouchActionEvent = _prefixId.prefix "PinchTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : Регионrdfs:label : Region</para>
    ///   <para>rdfs:comment : Область пользовательского интерфейса, например, окно целиком, либо его отдельная частьrdfs:comment : A fragment of GUI, for example, the whole window, or a part of it</para>
    ///   <a href="https://w3id.org/usability#Region">usability:Region</a>
    /// </summary>
    let Region = _prefixId.prefix "Region"
    let Region11 = _prefixId.prefix "Region11"
    let Region21 = _prefixId.prefix "Region21"
    let RegionVariation111 = _prefixId.prefix "RegionVariation111"
    let RegionVariation112 = _prefixId.prefix "RegionVariation112"
    let RegionVariation211 = _prefixId.prefix "RegionVariation211"
    /// <summary>
    ///   <para>rdfs:label : ПрокруткаМышьДействиеСобытиеrdfs:label : ScrollMouseActionEvent</para>
    ///   <para>rdfs:comment : Класс, который соответствует событию прокрутки колесика мышиrdfs:comment : The class that represents a mouse wheel scroll</para>
    ///   <a href="https://w3id.org/usability#ScrollMouseActionEvent">usability:ScrollMouseActionEvent</a>
    /// </summary>
    let ScrollMouseActionEvent = _prefixId.prefix "ScrollMouseActionEvent"
    /// <summary>
    ///   <para>rdfs:comment : Временной промежуток, в течение которого пользователь взаимодействует с программной системойrdfs:comment : A period of time when a user interacts with the software</para>
    ///   <para>rdfs:label : Сессияrdfs:label : Session</para>
    ///   <a href="https://w3id.org/usability#Session">usability:Session</a>
    /// </summary>
    let Session = _prefixId.prefix "Session"
    let Session1 = _prefixId.prefix "Session1"
    let Session2 = _prefixId.prefix "Session2"
    /// <summary>
    ///   <para>rdfs:label : ОдинарныйКликМышьДействиеСобытиеrdfs:label : SingleClickMouseEvent</para>
    ///   <para>rdfs:comment : Клик (click) — одинарный щелчок по кнопке мыши, короткое нажатие.rdfs:comment : The class that represents a single mouse click</para>
    ///   <a href="https://w3id.org/usability#SingleClickMouseEvent">usability:SingleClickMouseEvent</a>
    /// </summary>
    let SingleClickMouseEvent = _prefixId.prefix "SingleClickMouseEvent"
    /// <summary>
    ///   <para>rdfs:label : SingleTapTouchActionEvent</para>
    ///   <para>rdfs:comment : Тап, тэп (tap) — короткое нажатие пальцем, сродни клику.rdfs:comment : The class that represents tap action - single short touch with one finger</para>
    ///   <a href="https://w3id.org/usability#SingleTapTouchActionEvent">usability:SingleTapTouchActionEvent</a>
    /// </summary>
    let SingleTapTouchActionEvent = _prefixId.prefix "SingleTapTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : StretchTouchActionEvent</para>
    ///   <para>rdfs:comment : Стретч (stretch: для Microsoft), Пинч-ит-опен (pinch it open: для Apple) — растягивающее движение одновременно двумя пальцами по экрану для увеличения изображения.rdfs:comment : The class that represents stretch (pinch it open) - tensile movement with two fingers on the screen to enlarge the image.</para>
    ///   <a href="https://w3id.org/usability#StretchTouchActionEvent">usability:StretchTouchActionEvent</a>
    /// </summary>
    let StretchTouchActionEvent = _prefixId.prefix "StretchTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : SwipeTouchActionEvent</para>
    ///   <para>rdfs:comment : Свайп (swipe), Слайд (slide) — продолжительное скольжение пальцем по экрану.rdfs:comment : The class the represents swipe (slide) - a continuous movement of the finger across the screen</para>
    ///   <a href="https://w3id.org/usability#SwipeTouchActionEvent">usability:SwipeTouchActionEvent</a>
    /// </summary>
    let SwipeTouchActionEvent = _prefixId.prefix "SwipeTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : TapTouchActionEvent</para>
    ///   <para>rdfs:comment : Класс, предназначенный для описания различных видов тапов - прикосновений пользователя к экрану одним пальцем без движенияrdfs:comment : The class that represents differend kinds events related to user's tap on the touch screen</para>
    ///   <a href="https://w3id.org/usability#TapTouchActionEvent">usability:TapTouchActionEvent</a>
    /// </summary>
    let TapTouchActionEvent = _prefixId.prefix "TapTouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : КасаниеДействиеСобытиеrdfs:label : TouchActionEvent</para>
    ///   <para>rdfs:comment : Класс, который описывает события действий, связанных с взаимодействием пользователя с сенсорным экраном (тачскрин, англ. touchscreen), например, дисплеем телефона или планшетного компьютераrdfs:comment : The class that represents events related to user interations with touchscreen, like smartphone or tablet PC</para>
    ///   <a href="https://w3id.org/usability#TouchActionEvent">usability:TouchActionEvent</a>
    /// </summary>
    let TouchActionEvent = _prefixId.prefix "TouchActionEvent"
    /// <summary>
    ///   <para>rdfs:label : ВводКлавиатураДействиеСобытиеrdfs:label : TypeKeyboardActionEvent</para>
    ///   <para>rdfs:comment : Класс, который описывает события нажатия клавиш клавиатурыrdfs:comment : The class that represents clicks on a keyboard</para>
    ///   <a href="https://w3id.org/usability#TypeKeyboardActionEvent">usability:TypeKeyboardActionEvent</a>
    /// </summary>
    let TypeKeyboardActionEvent = _prefixId.prefix "TypeKeyboardActionEvent"
    /// <summary>
    ///   <para>rdfs:label : Пользовательrdfs:label : User</para>
    ///   <para>rdfs:comment : Пользователь, который выполнял(ет) сессии.rdfs:comment : The user who runs sessions</para>
    ///   <a href="https://w3id.org/usability#User">usability:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    let User1 = _prefixId.prefix "User1"
    let User2 = _prefixId.prefix "User2"
    /// <summary>
    ///   <para>rdfs:label : ВариацияРегионаrdfs:label : Variation</para>
    ///   <para>rdfs:comment : Class that describes a region variation, since a region may have one or more variations. Variation is a unique combination of region image's height and width, or their rangerdfs:comment : Класс предназначен для описания вариации региона, так как каждый регион, в свою очередь, может иметь одну или более вариаций. Под вариацией региона в общем случае может пониматься уникальное сочетание параметров высоты и ширины изображения региона, либо их диапазон</para>
    ///   <a href="https://w3id.org/usability#Variation">usability:Variation</a>
    /// </summary>
    let Variation = _prefixId.prefix "Variation"
    /// <summary>
    ///   <para>rdfs:label : cодержитrdfs:label : contains</para>
    ///   <para>rdfs:comment : Транзитивное свойство, которое определят, что некий объект содержит/хранит внутря себя какой-либо другой объектrdfs:comment : A transitive property which determines that some subject contains/stores some object inside of it. Inverse of isContainedIn</para>
    ///   <a href="https://w3id.org/usability#contains">usability:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    let hasBinaryData = _prefixId.prefix "hasBinaryData"
    let hasCommandName = _prefixId.prefix "hasCommandName"
    let hasDateTime = _prefixId.prefix "hasDateTime"
    let hasDpiX = _prefixId.prefix "hasDpiX"
    let hasDpiY = _prefixId.prefix "hasDpiY"
    let hasEndDateTime = _prefixId.prefix "hasEndDateTime"
    let hasHeight = _prefixId.prefix "hasHeight"
    /// <summary>
    ///   <para>rdfs:label : имеетИзображениеrdfs:label : hasImage</para>
    ///   <para>rdfs:comment : Свойство которое связывает вариацию региона с его изображениемrdfs:comment : The property which associate some region variation with its image</para>
    ///   <a href="https://w3id.org/usability#hasImage">usability:hasImage</a>
    /// </summary>
    let hasImage = _prefixId.prefix "hasImage"
    let hasInRegionX = _prefixId.prefix "hasInRegionX"
    let hasInRegionY = _prefixId.prefix "hasInRegionY"
    let hasMaxHeight = _prefixId.prefix "hasMaxHeight"
    let hasMaxWidth = _prefixId.prefix "hasMaxWidth"
    let hasMinHeight = _prefixId.prefix "hasMinHeight"
    let hasMinWidth = _prefixId.prefix "hasMinWidth"
    let hasName = _prefixId.prefix "hasName"
    let hasStartDateTime = _prefixId.prefix "hasStartDateTime"
    let hasUid = _prefixId.prefix "hasUid"
    let hasWidth = _prefixId.prefix "hasWidth"
    /// <summary>
    ///   <para>rdfs:label : содержитсяВrdfs:label : isContainedIn</para>
    ///   <para>rdfs:comment : Транзитивное свойство, которое определяет, что некоторый объект содержится/хранится/находится внутри какого-либо другого объектаrdfs:comment : A transitive property which determines that some object is contained/stored/located inside of some subject. Inverse of contains</para>
    ///   <a href="https://w3id.org/usability#isContainedIn">usability:isContainedIn</a>
    /// </summary>
    let isContainedIn = _prefixId.prefix "isContainedIn"
    /// <summary>
    ///   <para>rdfs:label : выполнилrdfs:label : performed</para>
    ///   <para>rdfs:comment : Связывает пользователя с сессией, которую он выполнилrdfs:comment : The property that associates a user with a session that he performed</para>
    ///   <a href="https://w3id.org/usability#performed">usability:performed</a>
    /// </summary>
    let performed = _prefixId.prefix "performed"
    /// <summary>
    ///   <para>rdfs:label : связанаСrdfs:label : wasAssociatedWith</para>
    ///   <para>rdfs:comment : Связывает командное событие с экземпляром командыrdfs:comment : The property that associates command event with the specific command instance</para>
    ///   <a href="https://w3id.org/usability#wasAssociatedWith">usability:wasAssociatedWith</a>
    /// </summary>
    let wasAssociatedWith = _prefixId.prefix "wasAssociatedWith"
    /// <summary>
    ///   <para>rdfs:label : изображаетrdfs:label : wasImaged</para>
    ///   <para>rdfs:comment : Связывает изображение с соответствующей вариацией регионаrdfs:comment : The property that associates an image with the corresponding region variation</para>
    ///   <a href="https://w3id.org/usability#wasImaged">usability:wasImaged</a>
    /// </summary>
    let wasImaged = _prefixId.prefix "wasImaged"
    /// <summary>
    ///   <para>rdfs:label : былоВызваноВrdfs:label : wasInvokedIn</para>
    ///   <para>rdfs:comment : Связывает команду с командным событием, в котором команда была вызванаrdfs:comment : The property that associates specific command with the event in which the command was called</para>
    ///   <a href="https://w3id.org/usability#wasInvokedIn">usability:wasInvokedIn</a>
    /// </summary>
    let wasInvokedIn = _prefixId.prefix "wasInvokedIn"
    /// <summary>
    ///   <para>rdfs:label : былаВыполненаПользователемrdfs:label : wasPerformedBy</para>
    ///   <para>rdfs:comment : Связывает сессию с пользователем, который ее выполнялrdfs:comment : The property that associates a session with the user who performed it</para>
    ///   <a href="https://w3id.org/usability#wasPerformedBy">usability:wasPerformedBy</a>
    /// </summary>
    let wasPerformedBy = _prefixId.prefix "wasPerformedBy"
    /// <summary>
    ///   <para>rdfs:label : былаВыполненаНаrdfs:label : wasPerformedOn</para>
    ///   <para>rdfs:comment : Связывает сессию с устройством, на котором она выполняласьrdfs:comment : The property that associates a session with the device on which the session was run</para>
    ///   <a href="https://w3id.org/usability#wasPerformedOn">usability:wasPerformedOn</a>
    /// </summary>
    let wasPerformedOn = _prefixId.prefix "wasPerformedOn"
    /// <summary>
    ///   <para>rdfs:label : былоИспользованоВrdfs:label : wasUsedIn</para>
    ///   <para>rdfs:comment : Связывает устройство с сессиями, которые были на нем запущеныrdfs:comment : The property that associates a device with the sessions which were run on that device</para>
    ///   <a href="https://w3id.org/usability#wasUsedIn">usability:wasUsedIn</a>
    /// </summary>
    let wasUsedIn = _prefixId.prefix "wasUsedIn"
