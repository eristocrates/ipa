namespace SharedKernel

module InvalidFileNameCharacter =

    type Type =
        { character: char
          stringReplacement: string }

    let quotationMark =
        { character = '"'
          stringReplacement = "&quot;" }

    let asterisk =
        { character = '*'
          stringReplacement = "&ast;" }

    let solidus =
        { character = '/'
          stringReplacement = "&sol;" }

    let colon =
        { character = ':'
          stringReplacement = "&colon;" }

    let lessThan =
        { character = '<'
          stringReplacement = "&lt;" }

    let greaterThan =
        { character = '>'
          stringReplacement = "&gt;" }

    let questionMark =
        { character = '?'
          stringReplacement = "&quest;" }

    let nullCharacter =
        { character = '\000'
          stringReplacement = "&NUL;" }

    let startOfHeading =
        { character = '\001'
          stringReplacement = "&SOH;" }

    let startOfText =
        { character = '\002'
          stringReplacement = "&STX;" }

    let endOfText =
        { character = '\003'
          stringReplacement = "&ETX;" }

    let endOfTransmission =
        { character = '\004'
          stringReplacement = "&EOT;" }

    let enquiry =
        { character = '\005'
          stringReplacement = "&ENQ;" }

    let acknowledge =
        { character = '\006'
          stringReplacement = "&ACK;" }

    let bell =
        { character = '\007'
          stringReplacement = "&BEL;" }

    let backspace =
        { character = '\008'
          stringReplacement = "&BS;" }

    let characterTabulation =
        { character = '\009'
          stringReplacement = "&Tab;" }

    let lineFeed =
        { character = '\010'
          stringReplacement = "&NewLine;" }

    let lineTabulation =
        { character = '\011'
          stringReplacement = "&VT;" }

    let formFeed =
        { character = '\012'
          stringReplacement = "&FF;" }

    let carriageReturn =
        { character = '\013'
          stringReplacement = "&CR;" }

    let shiftOut =
        { character = '\014'
          stringReplacement = "&SO;" }

    let shiftIn =
        { character = '\015'
          stringReplacement = "&SI;" }

    let dataLinkEscape =
        { character = '\016'
          stringReplacement = "&DLE;" }

    let deviceControl1'XON =
        { character = '\017'
          stringReplacement = "&DC1;" }

    let deviceControl2 =
        { character = '\018'
          stringReplacement = "&DC2;" }

    let deviceControl3'XOFF =
        { character = '\019'
          stringReplacement = "&DC3;" }

    let deviceControl4 =
        { character = '\020'
          stringReplacement = "&DC4;" }

    let negativeAcknowledge =
        { character = '\021'
          stringReplacement = "&NAK;" }

    let synchronousIdle =
        { character = '\022'
          stringReplacement = "&SYN;" }

    let endOfTransmissionBlock =
        { character = '\023'
          stringReplacement = "&ETB;" }

    let cancel =
        { character = '\024'
          stringReplacement = "&CAN;" }

    let endOfMedium =
        { character = '\025'
          stringReplacement = "&EM;" }

    let substitute =
        { character = '\026'
          stringReplacement = "&SUB;" }

    let escape =
        { character = '\027'
          stringReplacement = "&ESC;" }

    let informationSeparator1'fileSeparator =
        { character = '\028'
          stringReplacement = "&FS;" }

    let informationSeparator2'groupSeparator =
        { character = '\029'
          stringReplacement = "&GS;" }

    let informationSeparator3'recordSeparator'requestToSend =
        { character = '\030'
          stringReplacement = "&RS;" }

    let informationSeparator4'unitSeparator =
        { character = '\031'
          stringReplacement = "&US;" }

    let reverseSolidus =
        { character = '\\'
          stringReplacement = "&bsol;" }

    let lineTabulationb =
        { character = '\b'
          stringReplacement = "&VT;" }

    let verticalLine =
        { character = '|'
          stringReplacement = "&vert;" }
