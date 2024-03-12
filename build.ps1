param(
    [switch]$NoCache,
    [switch]$Run
)

$buildParams = @()

$buildParams += @("--build-arg CBD_FEED_ACCESSTOKEN=$($Env:CBD_FEED_ACCESSTOKEN)")
if ($NoCache) {
    $buildParams += @('--no-cache')
}

echo @buildParams

docker build @buildParams -t codebuilddeploy.azurecr.io/code-build-deploy-blogs:latest -f ./CodeBuildDeploy.Blogs/Dockerfile .

if ($?) {
    if ($Run) {
        & '.\run.ps1'
    }
}
else {
    Write-Warning "Failed to build an upto date image."
}
