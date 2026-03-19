for $column in //column
  let $columnName := string($column/@name)
  let $table := $column/parent::element()
  let $productFamily := $table/parent::element()

  where
    $productFamily/@name = "AssetManagement.Storm"
    and
    fn:starts-with($table/@databaseName, "COMP")
   return $column
   