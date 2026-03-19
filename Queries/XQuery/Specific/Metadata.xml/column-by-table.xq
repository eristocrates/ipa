for $column in //productFamily[@name = "AssetManagement.Storm"]/table[@name = "StormMain"]/column
let $columnName := string($column/@name)

return `
{$column/text/@displayTitle} ({$columnName})
        description: {$column/text/@description}
        displayTitleLong: {$column/text/@displayTitleLong}
        displayDescription: {$column/text/@displayDescription}
`