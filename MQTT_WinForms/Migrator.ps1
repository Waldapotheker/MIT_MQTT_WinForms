param (
    [string]$Name = $("AutoMig_" + (Get-Date -Format "yyyyMMdd_HHmmss"))
)

Write-Host "Erstelle Migration: $Name"
dotnet ef migrations add $Name

Write-Host "Wende Migration an..."
dotnet ef database update

Write-Host "Migration abgeschlossen."
