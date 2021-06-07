# Git Training Repo

This repository contains branches and conflicts on purpose for use in git training.

## Resources:
|RESOURCE|LOCATION|
|----|----|
|Atlassian Git Documents|[Advanced Git Tutorials Overview - Atlassian Git Tutorial](https://www.atlassian.com/git/tutorials/advanced-overview)|
|Microsoft Git Tutorials|[Azure Repos Git tutorial - Azure Repos Microsoft Docs](https://docs.microsoft.com/en-us/azure/devops/repos/git/gitworkflow?view=azure-devops)|
|Git Cheat Sheet|[Git Cheat Sheet](git-cheatsheet.com)|
|Trunk Based Development Guide|[Trunk Based Development](https://trunkbaseddevelopment.com)|
|Git Credential Manager Core|[GitHub - microsoft/Git-Credential-Manager-Core: Secure, cross-platform Git credential storage with authentication to GitHub, Azure Repos, and other popular Git hosting services.](https://github.com/microsoft/Git-Credential-Manager-Core)|

## Suggested Git Settings
`git config --global branch.autosetuprebase always`
`git config --global core.editor "code --wait"`
`git config --global mergetool.vscode.cmd "code --wait $MERGED"`
`git config --global merge.tool vscode`
`git config --global difftool.vscode.cmd "code --wait --diff $LOCAL $REMOTE"`
`git config --global diff.tool vscode`

## Suggested Git Tooling
[Posh-Git](https://github.com/dahlbyk/posh-git#installation) - Powershell extension for Git
[Visual Studio Code](https://code.visualstudio.com/) - Best Lightweight Editor for resolving conflicts, merge views, commit messages

Sample Commit Demo
