param(
  [Parameter(Mandatory=$true, Position=0)] [string]$Command,
  [Parameter(Position=1)]                  [string]$OutBase,
  [Parameter(ValueFromRemainingArguments=$true, Position=2)]
  [string[]]$HelpArgs
)

$ErrorActionPreference = 'Stop'

# Resolve command; default output base
$cmd = $Command.Trim('"')
if ([string]::IsNullOrWhiteSpace($OutBase)) { $OutBase = "$cmd" }

# Run command (no args or given help args), capture stdout+stderr
try {
  if ($HelpArgs -and $HelpArgs.Count -gt 0) {
    $lines = & $cmd @HelpArgs 2>&1
  } else {
    $lines = & $cmd 2>&1
  }
} catch {
  Write-Error "Failed to run '$cmd' $HelpArgs : $($_.Exception.Message)"
  exit 1
}

# Coerce to strings
$lines = $lines | ForEach-Object { $_.ToString() }

# 1) raw
$rawPath = "$OutBase.usage.txt"
$lines | Set-Content -Encoding UTF8 $rawPath

# 2) compact spacing (collapse 2+ spaces)
$usgPath = "$OutBase.usg.txt"
$lines | ForEach-Object { $_ -replace '\s{2,}', ' ' } | Set-Content -Encoding UTF8 $usgPath

# 3) structured CSV
$csvPath = "$OutBase.usage.csv"
$rows = @()
$rx = '^\s*(?:(?:-(?<short>[A-Za-z0-9]))(?:,)?\s*)?(?:--(?<long>[A-Za-z0-9][A-Za-z0-9\-]*))?(?:\s+(?<meta><[^>]+>))?\s{2,}(?<desc>\S.*)$'

foreach ($line in $lines) {
  if ($line -match $rx) {
    $rows += [pscustomobject]@{
      Short       = $matches.short
      Long        = $matches.long
      Meta        = $matches.meta
      Description = $matches.desc.Trim()
    }
  }
  elseif ($rows.Count -gt 0 -and $line -match '^\s{2,}\S') {
    # continuation line for description (wrapped help)
    $rows[-1].Description += ' ' + $line.Trim()
  }
}

$rows | Export-Csv -Path $csvPath -NoTypeInformation -Encoding UTF8

Write-Host "Wrote:"
Write-Host "  $rawPath"
Write-Host "  $usgPath"
Write-Host "  $csvPath"
