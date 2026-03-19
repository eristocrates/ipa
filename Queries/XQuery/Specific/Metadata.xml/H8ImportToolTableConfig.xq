<h8importtool
  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  xmlns:xsd="http://www.w3.org/2001/XMLSchema">
{
for $productFamily in//productFamily
return
 <family name="{ string($productFamily/@name) }">
    {
      for $table in $productFamily/table
      return
      <table name="{ string($table/@databaseName)}" />
    }
    </family>
}
</h8importtool>