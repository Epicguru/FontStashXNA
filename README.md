# FontStashXNA
[![NuGet](https://img.shields.io/nuget/v/FontStashXNA.MonoGame.svg)](https://www.nuget.org/packages/FontStashXNA.MonoGame/) 
[![Chat](https://img.shields.io/discord/628186029488340992.svg)](https://discord.gg/ZeHxhCY)

FontStashXNA is [FontStashSharp](https://github.com/rds1983/FontStashSharp) for MonoGame and FNA.

Or - in other words - it is the text rendering library with following features:

* Glyphs are rendered on demand on the texture atlas
* It's possible to have multiple ttf fonts per one FontSystem(i.e. one ttf with Latin characters, second with Japanese characters and third with emojis)
* Colored text
* Blurry and stroked text

# Adding Reference
There are two ways of referencing FontStashXNAs in the project:
1. Through nuget(works only for MonoGame): https://www.nuget.org/packages/FontStashXNA.MonoGame/
2. As source code(works for both MonoGame and FNA):
    
    a. Clone this repo.
    
    b. Execute `git submodule update --init --recursive` within the folder the repo was cloned to.
    
    c. Add src/FontStashXNA.MonoGame.csproj or src/FontStashXNA.FNA.csproj to the solution.

      * If FNA is used, then the folder structure is expected to be following: ![Folder Structure](/images/FolderStructure.png)
