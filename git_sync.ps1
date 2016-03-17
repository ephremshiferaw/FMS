[CmdletBinding()]
Param (
  [Parameter(Mandatory=$True,Position=0)]
  [string]$remoteUrl

)
#$remoteUrl is the report git repo path e.g https://username:password@github.com/repo/Project.git
trap 
{ 
 ExitCode=[0]
} 
git remote set-url --push githuborigin $remoteUrl
git push --mirror --force 
ExitCode=[0]