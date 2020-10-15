## FontStashXNA
[![NuGet](https://img.shields.io/nuget/v/FontStashXNA.MonoGame.svg)](https://www.nuget.org/packages/FontStashXNA.MonoGame/) 
[![Chat](https://img.shields.io/discord/628186029488340992.svg)](https://discord.gg/ZeHxhCY)

FontStashXNA is [FontStashSharp](https://github.com/rds1983/FontStashSharp) for MonoGame and FNA.

Or - in other words - it is the text rendering library with following features:

* Glyphs are rendered on demand on the texture atlas
* It's possible to have multiple ttf fonts per one FontSystem(i.e. one ttf with Latin characters, second with Japanese characters and third with emojis)
* Colored text
* Blurry and stroked text

## Adding Reference
There are two ways of referencing FontStashXNAs in the project:
1. Through nuget(works only for MonoGame): https://www.nuget.org/packages/FontStashXNA.MonoGame/
2. As source code(works for both MonoGame and FNA):
    
    a. Clone this repo.
    
    b. Execute `git submodule update --init --recursive` within the folder the repo was cloned to.
    
    c. Add src/FontStashXNA.MonoGame.csproj or src/FontStashXNA.FNA.csproj to the solution.

      * If FNA is used, then the folder structure is expected to be following: ![Folder Structure](/images/FolderStructure.png)
      
## Usage
Following code creates FontSystem from 3 different ttfs:
```c#
    private SpriteBatch _spriteBatch; 
    private FontSystem _fontSystem;

    /// <summary>
    /// LoadContent will be called once per game and is the place to load
    /// all of your content.
    /// </summary>
    protected override void LoadContent()
    {
        // Create a new SpriteBatch, which can be used to draw textures.
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _fontSystem = FontSystemFactory.Create(GraphicsDevice, 1024, 1024);
        _fontSystem.AddFont(File.ReadAllBytes(@"Fonts/DroidSans.ttf"));
        _fontSystem.AddFont(File.ReadAllBytes(@"Fonts/DroidSansJapanese.ttf"));
        _fontSystem.AddFont(File.ReadAllBytes(@"Fonts/Symbola-Emoji.ttf"));
    }
```

Now the text could be drawn using following code:
```c#
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Render some text
        _spriteBatch.Begin();

        DynamicSpriteFont font18 = _fontSystem.GetFont(18);
        _spriteBatch.DrawString(font18, "The quick いろは brown\nfox にほへ jumps over\nt🙌h📦e l👏a👏zy dog", new Vector2(0, 0), Color.White);

        DynamicSpriteFont font30 = _fontSystem.GetFont(30);
        _spriteBatch.DrawString(font30, "The quick いろは brown\nfox にほへ jumps over\nt🙌h📦e l👏a👏zy dog", new Vector2(0, 80), Color.Yellow);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
```

It would render following:
![](/images/screenshot1.png)

If you want to draw a colored text, then pass array of colors(a color for every rendered character).
I.e.
```c#
    private static readonly Color[] ColoredTextColors = new Color[]
    {
        Color.Red,
        Color.Blue,
        Color.Green,
        Color.Aquamarine,
        Color.Azure,
        Color.Chartreuse,
        Color.Lavender,
        Color.OldLace,
        Color.PaleGreen,
        Color.SaddleBrown,
        Color.IndianRed,
        Color.ForestGreen,
        Color.Khaki
    };

    /// <summary>
    /// This is called when the game should draw itself.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Render some text
        _spriteBatch.Begin();

        DynamicSpriteFont font30 = _fontSystem.GetFont(30);
        _spriteBatch.DrawString(font30, "Colored Text", Vector2.Zero, ColoredTextColors);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
```

It would render following:
![](/images/screenshot2.png)

If you want to draw blurry text, specify blur amount during the creation of the font system:
```c#
    _fontSystem = FontSystemFactory.Create(GraphicsDevice, 1024, 1024, 2);
```
It would render following:
![](/images/screenshot3.png)

Similarly stroke amount could be specified:
```c#
    _fontSystem = FontSystemFactory.Create(GraphicsDevice, 1024, 1024, 0, 1);
```

It would render following:
![](/images/screenshot4.png)

## Building From Source Code
1. Clone this repo.
2. `git submodule update --init --recursive`
3. Open a solution from the "build" folder.

## Credits
* [MonoGame](http://www.monogame.net/)
* [FNA](https://github.com/FNA-XNA/FNA)
* [stb](https://github.com/nothings/stb)
* [fontstash](https://github.com/memononen/fontstash)
* [bartwe's fork of SpriteFontPlus](https://github.com/bartwe/SpriteFontPlus)
