namespace https.w3id.org.usability.hash

open DoxAletheia

module usability =
    let _namespace_name = "https://w3id.org/usability#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The base class for events which are user actions related to user interation with the interface (clicks, mouse movements, etc.)
    /// <see href="https://w3id.org/usability#ActionEvent"></see></summary>
    let ActionEvent = _prefix "ActionEvent"
    /// <summary>
    /// The base class for all different kinds of event that may be occured while the user is interacting with the software
    /// <see href="https://w3id.org/usability#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The class that represents any mouse click
    /// <see href="https://w3id.org/usability#ClickMouseActionEvent"></see></summary>
    let ClickMouseActionEvent = _prefix "ClickMouseActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasInRegionY"></see>
    /// </summary>
    let hasInRegionY = _prefix "hasInRegionY"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasInRegionX"></see>
    /// </summary>
    let hasInRegionX = _prefix "hasInRegionX"
    /// <summary>
    /// The class that represents actions related to user's manipulations with a mouse
    /// <see href="https://w3id.org/usability#MouseActionEvent"></see></summary>
    let MouseActionEvent = _prefix "MouseActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Command"></see>
    /// </summary>
    let Command = _prefix "Command"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// The class that represents events, related with the fact of calling a certain command (function) by the user
    /// <see href="https://w3id.org/usability#CommandEvent"></see></summary>
    let CommandEvent = _prefix "CommandEvent"
    /// <summary>
    /// The property that associates specific command with the event in which the command was called
    /// <see href="https://w3id.org/usability#wasInvokedIn"></see></summary>
    let wasInvokedIn = _prefix "wasInvokedIn"
    /// <summary>
    /// A transitive property which determines that some object is contained/stored/located inside of some subject. Inverse of contains
    /// <see href="https://w3id.org/usability#isContainedIn"></see></summary>
    let isContainedIn = _prefix "isContainedIn"
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandA"></see>
    /// </summary>
    let CommandA = _prefix "CommandA"
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandB"></see>
    /// </summary>
    let CommandB = _prefix "CommandB"
    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation211"></see>
    /// </summary>
    let RegionVariation211 = _prefix "RegionVariation211"
    /// <summary>
    /// The property that associates command event with the specific command instance
    /// <see href="https://w3id.org/usability#wasAssociatedWith"></see></summary>
    let wasAssociatedWith = _prefix "wasAssociatedWith"
    /// <summary>
    /// A transitive property which determines that some subject contains/stores some object inside of it. Inverse of isContainedIn
    /// <see href="https://w3id.org/usability#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent1113"></see>
    /// </summary>
    let CommandEvent1113 = _prefix "CommandEvent1113"
    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation111"></see>
    /// </summary>
    let RegionVariation111 = _prefix "RegionVariation111"
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent1114"></see>
    /// </summary>
    let CommandEvent1114 = _prefix "CommandEvent1114"
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent2112"></see>
    /// </summary>
    let CommandEvent2112 = _prefix "CommandEvent2112"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Device"></see>
    /// </summary>
    let Device = _prefix "Device"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasUid"></see>
    /// </summary>
    let hasUid = _prefix "hasUid"
    /// <summary>
    /// A period of time when a user interacts with the software
    /// <see href="https://w3id.org/usability#Session"></see></summary>
    let Session = _prefix "Session"
    /// <summary>
    /// The property that associates a device with the sessions which were run on that device
    /// <see href="https://w3id.org/usability#wasUsedIn"></see></summary>
    let wasUsedIn = _prefix "wasUsedIn"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Device1"></see>
    /// </summary>
    let Device1 = _prefix "Device1"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Session2"></see>
    /// </summary>
    let Session2 = _prefix "Session2"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Session1"></see>
    /// </summary>
    let Session1 = _prefix "Session1"
    /// <summary>
    /// The class that represents a double mouse click
    /// <see href="https://w3id.org/usability#DoubleClickMouseEvent"></see></summary>
    let DoubleClickMouseEvent = _prefix "DoubleClickMouseEvent"
    /// <summary>
    /// The class that represents double tap - two short taps on the screen
    /// <see href="https://w3id.org/usability#DoubleTapTouchActionEvent"></see></summary>
    let DoubleTapTouchActionEvent = _prefix "DoubleTapTouchActionEvent"
    /// <summary>
    /// The class that represents differend kinds events related to user's tap on the touch screen
    /// <see href="https://w3id.org/usability#TapTouchActionEvent"></see></summary>
    let TapTouchActionEvent = _prefix "TapTouchActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDateTime"></see>
    /// </summary>
    let hasDateTime = _prefix "hasDateTime"
    /// <summary>
    /// Class that describes a region variation, since a region may have one or more variations. Variation is a unique combination of region image's height and width, or their range
    /// <see href="https://w3id.org/usability#Variation"></see></summary>
    let Variation = _prefix "Variation"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1111"></see>
    /// </summary>
    let Event1111 = _prefix "Event1111"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1112"></see>
    /// </summary>
    let Event1112 = _prefix "Event1112"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1121"></see>
    /// </summary>
    let Event1121 = _prefix "Event1121"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1122"></see>
    /// </summary>
    let Event1122 = _prefix "Event1122"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event2111"></see>
    /// </summary>
    let Event2111 = _prefix "Event2111"
    /// <summary>
    /// The class that represents touch-and-hold action - continuous touch with a single finger
    /// <see href="https://w3id.org/usability#HoldTapTouchActionEvent"></see></summary>
    let HoldTapTouchActionEvent = _prefix "HoldTapTouchActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDpiX"></see>
    /// </summary>
    let hasDpiX = _prefix "hasDpiX"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasHeight"></see>
    /// </summary>
    let hasHeight = _prefix "hasHeight"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasBinaryData"></see>
    /// </summary>
    let hasBinaryData = _prefix "hasBinaryData"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasWidth"></see>
    /// </summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDpiY"></see>
    /// </summary>
    let hasDpiY = _prefix "hasDpiY"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image111"></see>
    /// </summary>
    let Image111 = _prefix "Image111"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image112"></see>
    /// </summary>
    let Image112 = _prefix "Image112"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image211"></see>
    /// </summary>
    let Image211 = _prefix "Image211"
    /// <summary>
    /// The class that represents actions related to user's manipulations with a keyboard
    /// <see href="https://w3id.org/usability#KeyboardActionEvent"></see></summary>
    let KeyboardActionEvent = _prefix "KeyboardActionEvent"
    /// <summary>
    /// The class that represents touch - a touch that is slightly longer then tap
    /// <see href="https://w3id.org/usability#LongTapTouchActionEvent"></see></summary>
    let LongTapTouchActionEvent = _prefix "LongTapTouchActionEvent"
    /// <summary>
    /// The class that represents movements of cursor. hasInRegionX and hasInRegionY properties store information about the new cursor coordinates after the movement
    /// <see href="https://w3id.org/usability#MoveMouseActionEvent"></see></summary>
    let MoveMouseActionEvent = _prefix "MoveMouseActionEvent"
    /// <summary>
    /// The class that represents pinch - a contractive movement with two fingers on the screen to scale down the image.
    /// <see href="https://w3id.org/usability#PinchTouchActionEvent"></see></summary>
    let PinchTouchActionEvent = _prefix "PinchTouchActionEvent"
    /// <summary>
    /// The class that represents events related to user interations with touchscreen, like smartphone or tablet PC
    /// <see href="https://w3id.org/usability#TouchActionEvent"></see></summary>
    let TouchActionEvent = _prefix "TouchActionEvent"
    /// <summary>
    /// A fragment of GUI, for example, the whole window, or a part of it
    /// <see href="https://w3id.org/usability#Region"></see></summary>
    let Region = _prefix "Region"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMinHeight"></see>
    /// </summary>
    let hasMinHeight = _prefix "hasMinHeight"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMaxWidth"></see>
    /// </summary>
    let hasMaxWidth = _prefix "hasMaxWidth"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMaxHeight"></see>
    /// </summary>
    let hasMaxHeight = _prefix "hasMaxHeight"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMinWidth"></see>
    /// </summary>
    let hasMinWidth = _prefix "hasMinWidth"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Region11"></see>
    /// </summary>
    let Region11 = _prefix "Region11"
    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation112"></see>
    /// </summary>
    let RegionVariation112 = _prefix "RegionVariation112"
    /// <summary>
    ///   <see href="https://w3id.org/usability#Region21"></see>
    /// </summary>
    let Region21 = _prefix "Region21"
    /// <summary>
    /// The property which associate some region variation with its image
    /// <see href="https://w3id.org/usability#hasImage"></see></summary>
    let hasImage = _prefix "hasImage"
    /// <summary>
    /// The class that represents a mouse wheel scroll
    /// <see href="https://w3id.org/usability#ScrollMouseActionEvent"></see></summary>
    let ScrollMouseActionEvent = _prefix "ScrollMouseActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasEndDateTime"></see>
    /// </summary>
    let hasEndDateTime = _prefix "hasEndDateTime"
    /// <summary>
    /// The property that associates a session with the device on which the session was run
    /// <see href="https://w3id.org/usability#wasPerformedOn"></see></summary>
    let wasPerformedOn = _prefix "wasPerformedOn"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasStartDateTime"></see>
    /// </summary>
    let hasStartDateTime = _prefix "hasStartDateTime"
    /// <summary>
    /// The user who runs sessions
    /// <see href="https://w3id.org/usability#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// The property that associates a session with the user who performed it
    /// <see href="https://w3id.org/usability#wasPerformedBy"></see></summary>
    let wasPerformedBy = _prefix "wasPerformedBy"
    /// <summary>
    /// The class that represents a single mouse click
    /// <see href="https://w3id.org/usability#SingleClickMouseEvent"></see></summary>
    let SingleClickMouseEvent = _prefix "SingleClickMouseEvent"
    /// <summary>
    /// The class that represents tap action - single short touch with one finger
    /// <see href="https://w3id.org/usability#SingleTapTouchActionEvent"></see></summary>
    let SingleTapTouchActionEvent = _prefix "SingleTapTouchActionEvent"
    /// <summary>
    /// The class that represents stretch (pinch it open) - tensile movement with two fingers on the screen to enlarge the image.
    /// <see href="https://w3id.org/usability#StretchTouchActionEvent"></see></summary>
    let StretchTouchActionEvent = _prefix "StretchTouchActionEvent"
    /// <summary>
    /// The class the represents swipe (slide) - a continuous movement of the finger across the screen
    /// <see href="https://w3id.org/usability#SwipeTouchActionEvent"></see></summary>
    let SwipeTouchActionEvent = _prefix "SwipeTouchActionEvent"
    /// <summary>
    /// The class that represents clicks on a keyboard
    /// <see href="https://w3id.org/usability#TypeKeyboardActionEvent"></see></summary>
    let TypeKeyboardActionEvent = _prefix "TypeKeyboardActionEvent"
    /// <summary>
    ///   <see href="https://w3id.org/usability#performed"></see>
    /// </summary>
    let performed = _prefix "performed"
    /// <summary>
    ///   <see href="https://w3id.org/usability#User1"></see>
    /// </summary>
    let User1 = _prefix "User1"
    /// <summary>
    ///   <see href="https://w3id.org/usability#User2"></see>
    /// </summary>
    let User2 = _prefix "User2"
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasCommandName"></see>
    /// </summary>
    let hasCommandName = _prefix "hasCommandName"
    /// <summary>
    /// The property that associates an image with the corresponding region variation
    /// <see href="https://w3id.org/usability#wasImaged"></see></summary>
    let wasImaged = _prefix "wasImaged"
