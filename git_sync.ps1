[CmdletBinding()]
Param (
  [Parameter(Mandatory=$True,Position=0)]
  [string]$remoteUrl,
)
#$remoteUrl is the report git repo path e.g https://username:password@github.com/repo/Project.git
trap 
{ 
 exit 0
} 
} 
$pushTag=git rev-parse --short HEAD
git tag $pushTag
git remote set-url --push origin $remoteUrl
git push --mirror --force 