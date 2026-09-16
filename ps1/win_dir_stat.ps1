function Format-Size {
    param(
        [long]$Bytes
    )

    if ($null -eq $Bytes) { return '0 B' }

    $units = 'B','KB','MB','GB','TB','PB'
    $i = 0
    $value = [double]$Bytes

    while ($value -ge 1KB -and $i -lt $units.Length - 1) {
        $value /= 1KB
        $i++
    }

    # two decimal places: e.g. "1.23 GB"
    return ('{0:N2} {1}' -f $value, $units[$i])
}

Get-ChildItem -Directory | ForEach-Object {
    $sizeBytes = (Get-ChildItem $_.FullName -Recurse -File |
                  Measure-Object -Property Length -Sum).Sum

    [PSCustomObject]@{
        Name      = $_.Name
        Path      = $_.FullName
        SizeBytes = $sizeBytes
        Size      = Format-Size $sizeBytes
    }
}