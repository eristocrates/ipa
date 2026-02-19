namespace Dcmi.dctype.Namespace
module dctype =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "http://purl.org/dc/dcmitype/" (Some @"http://purl.org/dc/dcmitype/") (Some @"dcmi.dctype") None
    let Collection = {_prefixID with _localName = "Collection"}
    let Dataset = {_prefixID with _localName = "Dataset"}
    let Event = {_prefixID with _localName = "Event"}
    let Image = {_prefixID with _localName = "Image"}
    let InteractiveResource = {_prefixID with _localName = "InteractiveResource"}
    let MovingImage = {_prefixID with _localName = "MovingImage"}
    let PhysicalObject = {_prefixID with _localName = "PhysicalObject"}
    let Service = {_prefixID with _localName = "Service"}
    let Software = {_prefixID with _localName = "Software"}
    let Sound = {_prefixID with _localName = "Sound"}
    let StillImage = {_prefixID with _localName = "StillImage"}
    let Text = {_prefixID with _localName = "Text"}