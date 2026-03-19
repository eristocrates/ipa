let $newline := "&#xa;"

for $table in //table
let $productFamily := $table/parent::element()
let $owner := $productFamily/@owner
let $productFamilyName := $productFamily/@name
let $name := string($table/@name)
let $type := string($table/@type)
let $case := if (contains($type, "Table")) then `{$type}` else `{$type}Table`

where 
  $table/parent::element()/@name = "AssetManagement.Storm"
  and
  fn:starts-with($table/@databaseName, "COMP")
return ``[
let `{$name}` = `{$case}` {
  name = "`{$table/@name}`"
  databaseName = "`{$table/@databaseName}`"
  hasNullRecord = `{$table/@hasNullRecord}`
  isLicensed = `{$table/@isLicensed}`
  tableType = "`{$table/@type}`"
  productFamily = "`{$productFamilyName}`"
  owner = "`{$owner}`"
  columns = Set.ofList [
  `{for $column in $table/column
    return concat($column/@databaseName,$newline)}`
    
  ]
}
]``