# wttr.in-csharp

This app allows to check weather from every city in the world.<br>
App can **only** be ran in the **new** Windows Terminal. App uses ASCII escape codes to display colors, old Windows Terminal **can't** read those.

## Usage

Checking weather (table):<br>
`weather cityName`<br>

Checking weather (graph):
> Disclaimer: this is an experimental feature and may not work as intended<br>

`weather -v`<br>

Checking app version:<br>
`weather -v`

## Building an app

To build this app, past this command in the directory you want it in:<br>
`git clone https://github.com/IAmTree/wttr.in-csharp`

Than open the Weather.sln file with Visual Studio 2019.<br>
Then compile it and open it with Windows Terminal.

## Work in progress
<ul>
    <li>Fix the old Windows Terminal bug.</li>
    <li>Fix the Windows PowerShell bug.</li>
</ul>