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

let $columns := for $column in //column
  let $table := $column/parent::element()
  let $productFamily := $table/parent::element()
  
  let $name := string($column/@name)
  let $dataPrecision := $column/@dataPrecision
  let $dataScale := $column/@dataScale
  let $databaseName := string($column/@databaseName)
  let $defaultValue := if ($column/@defaultValue = $defaultValues) then `Some(SqlType.{$column/@type} {$column/@defaultValue})` else `None`
  let $isNullable := $column/@isNullable
  let $isRequired := $column/@isRequired
  let $length := $column/@length
  let $name := string($column/@name)
  let $showSearchOrder := string($column/@showSearchOrder)
  let $columnType := string($column/@columnType)
  let $description := if (string($column/text/@description) != "") then `Some("""{string($column/text/@description)}""")` else `None`
  let $displayDescription := if (string($column/text/@displayDescription) != "") then `Some("{string($column/text/@displayDescription)}")` else `None`
  let $displayTitle := if (string($column/text/@displayTitle) != "") then `Some("{string($column/text/@displayTitle)}")` else `None`
  let $displayTitleLong := if (string($column/text/@displayTitleLong) != "") then `Some("{string($column/text/@displayTitleLong)}")` else `None`

  where
    $productFamily/@name = "AssetManagement.Storm"
    and
    fn:starts-with($table/@databaseName, "COMP")
   return `
   let {$databaseName} = TableColumn {{
      name = "{$name}"
      databaseName = "{$databaseName}"
      defaultValue = {$defaultValue}
      isNullable = {$isNullable}
      isRequired = {$isRequired}
    }}
   `
 return distinct-values($columns)
   