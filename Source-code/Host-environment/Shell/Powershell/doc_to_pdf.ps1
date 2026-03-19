param(
    [Parameter(Mandatory = $true, Position = 0)]
    [ValidateNotNullOrEmpty()]
    [string]$RootPath,

    [switch]$Force
)

function Convert-DocxToPdfInPlace {
    param(
        [Parameter(Mandatory = $true)]
        [string]$RootPath,

        [switch]$Force
    )

    if (-not (Test-Path -LiteralPath $RootPath)) {
        throw "RootPath does not exist: $RootPath"
    }

    # Collect targets first (so Word is opened once, not per file)
    $docxFiles = Get-ChildItem -LiteralPath $RootPath -Recurse -File -Filter *.docx

    if ($docxFiles.Count -eq 0) {
        Write-Host "No .docx files found under: $RootPath"
        return
    }

    $word = New-Object -ComObject Word.Application
    $word.Visible = $false
    $word.DisplayAlerts = 0  # wdAlertsNone

    try {
        foreach ($file in $docxFiles) {
            $docxPath = $file.FullName
            $pdfPath  = [System.IO.Path]::ChangeExtension($docxPath, ".pdf")

            if (-not $Force -and (Test-Path -LiteralPath $pdfPath)) {
                Write-Host "Skip (exists): $pdfPath"
                continue
            }

            $doc = $null
            try {
                # Open(ReadOnly=true). Explicit args reduce Word UI prompts.
                $doc = $word.Documents.Open($docxPath, $false, $true)

                # 17 = wdFormatPDF
                $doc.SaveAs([ref]$pdfPath, [ref]17)

                Write-Host "OK: $docxPath -> $pdfPath"
            }
            catch {
                Write-Warning "FAIL: $docxPath ($($_.Exception.Message))"
            }
            finally {
                if ($doc -ne $null) {
                    $doc.Close($false) | Out-Null
                }
            }
        }
    }
    finally {
        $word.Quit()
        [System.Runtime.InteropServices.Marshal]::ReleaseComObject($word) | Out-Null
        [GC]::Collect()
        [GC]::WaitForPendingFinalizers()
    }
}

Convert-DocxToPdfInPlace -RootPath $RootPath -Force:$Force
