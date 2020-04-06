# _Word Counter_

#### _Epicodus C# Independent Project_, _Mar. 6, 2020_
#### A console application built to word search

#### By _**Stephanie Podolak**_

## Description
A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)

## Specifications:

| Specification | Example Input | Example Output |
| :-------------:|:-------------:|:-------------:|
|User inputs a word and program confirms word is valid|"walk"|word is stored with no output|
|User inputs a sentence and program confirms input is valid |"I took the cat for a walk"|sentence is stored with no output|
|Program takes sentence and divides it into separate words|"I took the cat for a walk"|"I" "took" "the" "cat" "for" "a" "walk"|
|Program searches through the divided sentence to see if inputted occurs| Search: "I" "took" "the" "cat" "for" "a" "walk" | Yes, word "walk" occurs |
|If word occurs, program counts how many times the word occurs|"I" "took" "the" "cat" "for" "a" "walk"|"walk" occurs 1 time|
|Program notifies user if inputted word is not a real word| Dgh |Program returns user error statement|

## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone "https://github.com/spodolak/wordcounter.git" ``
* ``$ cd WordCounter.Solution``

_To Run this Console Application, enter the following command in the Terminal:_

* ``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_
* _VS Code_

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Stephanie Podolak_**
