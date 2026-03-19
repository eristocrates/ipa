
let $newline := codepoints-to-string(10)
let $defaultValues := (
"-1",
"0",
"0.00",
"0.0",
"0.000001",
"0.01",
"1",
"2",
"3",
"4",
"5",
"6",
"7",
"8",
"12",
"24",
"31",
"42",
"100",
"1000",
"9999",
"'  '",
"' '",
"' During Validation'",
"'_'",
"'A'",
"'AREAAVERAGE'",
"'ASSET'",
"'B'",
"'C'",
"'D'",
"'DATE'",
"'E'",
"'ERROR'",
"'F'",
"'H'",
"'I'",
"'J'",
"'L'",
"'localhost'",
"'M'",
"'N'",
"'O'",
"'P'",
"'PayFlowPro'",
"'Q'",
"'R'",
"'S'",
"'T'",
"'U'",
"'V'",
"'W'",
"'Y'",
"A",
"B",
"Core.GetDateTimeByTimeZone()",
"Cubic Feet",
"en-US",
"GETDATE()",
"N",
"NONE",
"Not Set",
"O",
"P",
"RateTableDetail",
"unknown",
"Y",
"{{_BILLKEY_}}"
)
let $StormAssetTables := 
  for $table in //table
  where 
    $table/parent::element()/@name = "AssetManagement.Storm"
    and
    fn:starts-with($table/@databaseName, "COMP")
return $table

let $foreignColumnReferences :=
  for $table in $StormAssetTables
return $table/foreignKeyConstraint/foreignColumnReference




let $foreignColumnReferenceNames :=
    for $foreignColumnReference in $foreignColumnReferences
    order by $foreignColumnReference/@name
return $foreignColumnReference/@name

let $StormReferenceTables :=
  for $foreignColumnReferenceName in distinct-values($foreignColumnReferenceNames)
  let $tokens := tokenize($foreignColumnReferenceName, "\.")
  where $tokens[2] = "Storm"
  return //productFamily[@name = `{$tokens[1]}.{$tokens[2]}`]/table[@name = $tokens[3]]



for $table in ($StormAssetTables, $StormReferenceTables)

let $productFamily := $table/parent::element()
let $owner := $productFamily/@owner
let $name := string($table/@name)
let $type := string($table/@type)
let $case := if (contains($type, "Table")) then $type else $type || "Table"

let $columnBlock :=
  string-join(
    for $column in $table/column
    group by $columnDatabaseName := string($column/@databaseName)
    let $column := $column[1]
    order by $columnDatabaseName
    let $defaultValue :=
      if ($column/@defaultValue = $defaultValues)
        then
          if ($column/@type = "Varchar")
            then `Some(SqlType.{ $column/@type } "{ replace($column/@defaultValue, "'", "") }")`
            else `Some(SqlType.{ $column/@type } { $column/@defaultValue })`
        else `None`
    let $description :=
      if (string($column/text/@description) != "")
        then `Some("""{ fn:normalize-space(string($column/text/@description)) } """)`
        else `None`
    let $displayDescription :=
      if (string($column/text/@displayDescription) != "")
        then `Some("""{ fn:normalize-space(string($column/text/@displayDescription)) } """)`
        else `None`
    let $displayTitle :=
      if (string($column/text/@displayTitle) != "")
        then `Some("""{ fn:normalize-space(string($column/text/@displayTitle)) } """)`
        else `None`
    let $displayTitleLong :=
      if (string($column/text/@displayTitleLong) != "")
        then `Some("""{ fn:normalize-space(string($column/text/@displayTitleLong)) } """)`
        else `None`
    return ``[
  let `{$column/@databaseName }` = TableColumn {
      name = "`{ $column/@name }`"
      databaseName = "`{ $column/@databaseName }`"
      displayTitle = `{ $displayTitle }`
      description = `{ $description }`
      displayTitleLong = `{ $displayTitleLong }`
      displayDescription = `{ $displayDescription }`
      defaultValue = `{ $defaultValue }`
      isNullable = `{ $column/@isNullable }`
      isRequired = `{ $column/@isRequired }`
  }
    ]``,
    $newline
  )

where
  $productFamily/@name = "AssetManagement.Storm"
  and fn:starts-with($table/@databaseName, "COMP")

return ``[
module `{ $table/@databaseName }` =
  let `{ $table/@name }` = `{ $case }` {
      name = "`{ $table/@name }`"
      databaseName = "`{ $table/@databaseName }`"
      hasNullRecord = `{ $table/@hasNullRecord }`
      isLicensed = `{ $table/@isLicensed }`
      tableType = "`{ $table/@type }`"
      productFamily = "`{ $productFamily/@name }`"
      owner = "`{ $owner }`"
    }
  `{$columnBlock}`
]``