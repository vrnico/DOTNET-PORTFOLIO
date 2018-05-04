.Net Portfolio Template
==========
#### A WebApp by Nico Daunt

### Epicodus Weeks Two and Three .Net Code Review

#### Description
A personal portfolio template with features like blog posts and comments section.
***
[VISIT THE LIVE DEMO](https://google.com)
***

## Installation (build your own portfolio!)

#### this setup assumes previous installation of MAMP and Microsoft Visual Studio



Open your preferred terminal, and enter the following command to clone source to your local machine:
```sh
https://github.com/vrnico/DOTNET-PORTFOLIO.git
```

navigate to the Project directory in NicoPortfolio/NicoPortfolio:
```sh
cd NicoPortfolio
```

restore your dotnet project:
```sh
dotnet restore
```

Generate the database
```
$dotnet ef database update
```
Run program from Visual Studio by pressing ctrl F5 or the play button


Enjoy your brand new Portfolio!



## Specifications

1. #### Takes a users input as a comment, and displays it underneath content.

| Input      | Output           |
| ------------- |:-------------:|
| Wow Nico, your computer art is interesting    | **IMG_1: Wow Nico, your computer art is interesting** |


2. #### Allows user to login as admin and upload content

| Input      | Output           |
| ------------- |:-------------:|
| upload IMG_1.gif      |![img-icon](  https://imgur.com/ES8yuYP.gif)|

3. #### Allows user to login as admin and edit content

| Input      | Output           |
| ------------- |:-------------:|
| edit IMG_1.gif    | ![img-edit](https://i.imgur.com/dkNUuU1.png) |

3. #### Allows user to login as admin and delete content

| Input      | Output           |
| ------------- |:-------------:|
| delete IMG_1.gif      |Content Deleted!|





## features
1. Add/Edit/Delete content as admin
2. Comment on content as user








## Created With
* HTML
* Bootstrap
* CSS
* .NET
* MySQL




## Contact
questions/comments/concerns
* [nico.daunt@gmail.com](mailto:nico.daunt@gmail.com)
* [PERSONAL WEBSITE](nicodaunt.com)




## License
Copyright 2018


Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
