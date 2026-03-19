let substringAfter (input: string) (separator: string) =
    // Find the starting index of the separator
    let pos = input.IndexOf(separator)

    // Check if the separator was found (IndexOf returns -1 if not)
    if pos < 0 then
        // Return the original string or handle the case as needed
        input
    else
        // Calculate the start index of the desired substring
        let startIndex = pos + separator.Length

        // Check if startIndex is within valid bounds
        if startIndex >= input.Length then
            "" // Separator is at the end of the string
        else
            // Return the substring starting from startIndex to the end of the string
            input.Substring(startIndex)

