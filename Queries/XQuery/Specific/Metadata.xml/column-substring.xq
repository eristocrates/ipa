let $assetTable := (
"StormMain",

"StormValve",

"StormNode",

"StormManhole",
"StormStorageBasin"


)
(:
"StormChannel",
"StormInlet",
"StormLevee",
"StormServiceLine",
"StormMiscellaneous"
:)
for $column in //productFamily[@name = "AssetManagement.Storm"]/table/column
  let $tableName := $column/parent::element()/@name
  where contains($column/@name,"Length") and $tableName = $assetTable
  (:where $column/@name ="Length" and $tableName = $assetTable:)
  return $column