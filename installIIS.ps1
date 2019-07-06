import-module servermanager

$IsInstalled = ((Get-WindowsFeature -Name Web-Server).installed)
if ($isinstalled -eq $false){
	$premission = Read-Host -Prompt 'Are you sure you want to install ISS ?  [y] Yes [n] No'
	if ($premission -eq "y"){
		Install-WindowsFeature -Name "Web-Server" -IncludeManagementTools -IncludeAllSubFeature
	}
}
else{
    Write-output "IIS Server (WebServer) is already installed"
	Write-output "Please choose another feature : "
	$IISFeature = Read-Host -Prompt 'Enter another feature name to install that feature.'
	$premission = Read-Host -Prompt 'Are you sure you want to install $IISFeature ?  [y] Yes [n] No'
	if ($premission -eq "y"){
		Install-WindowsFeature -Name $IISFeature
	}
}
 