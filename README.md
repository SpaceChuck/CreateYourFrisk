# Create Your Frisk iOS Port
An iOS port of Create Your Frisk. Might work on Android too. Thanks to [ereralp5kekadam](https://github.com/ereralp5kekadam) for ~~forcing me~~ kindly asking me to make this.

## Building
After building, add UIFileSharingEnabled and LSSupportsOpeningDocumentsInPlace to Info.plist.

## Issues
- Shaders are not supported
- Probably more that I haven't found yet

# Create Your Frisk - Lua moddable Undertale engine

Welcome to the Git repository for **Create Your Frisk**, a fork of [**Unitale**](https://github.com/lvk/Unitale/) by lvk!

When testing, you'll want to load the Disclaimer scene from the Scenes folder.

Editing the Overworld requires **Unity** (see **Unity Version** below).

We also have a [**Discord server**](https://discord.gg/GFJ5277)! Feel free to check it out if you want to be in touch with Unitale and Create Your Frisk's community!

***

## Download

To download the engine, go to [**the releases page**](https://github.com/SpaceChuck/CreateYourFrisk/releases).

***

## Unity Version

CYF's latest version is **v0.6.6**. It was built using **Unity Personal 2018.4.36f1**, or Unity 2018's **Long Term Support** version.

To get this version of Unity, either:

* [**Download the Unity Hub**](https://unity3d.com/get-unity/download) or
* [**Find it in the Unity Version Archive**](https://unity3d.com/get-unity/download/archive) (remember, it's **2018.4.36**).

***

## Required files

Please keep the mods and the resources which are in the Mods and Default folders, unless you know what you're doing.
~~The only mods you can remove safely are Mionn and Donald Trump.~~ *(Removed as of CYF v0.6.2)*

***

## Licenses

Create Your Frisk is released under the GNU General Public License 3.0.
We are using MoonSharp as our Lua interpreter, written by Marco Mastropaolo. The binary is included in `/Assets/Plugins`. License details in `MOONSHARP_LICENSE`.
