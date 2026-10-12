<div align="center">
  <h1>VB.NET Windows Forms Examples — Binary Clock in Visual Basic ✨</h1>
  <p>
    <strong>Visual Basic learning workspace with small, interactive Windows Forms experiments.</strong>
  </p>
</div>

<p align="center">
  <img alt="Language: Visual Basic" src="https://img.shields.io/badge/Language-Visual%20Basic-6f42c1?style=for-the-badge&logo=visual-studio-code" />
  <img alt="Framework: .NET Framework" src="https://img.shields.io/badge/Framework-.NET%20Framework-512bd4?style=for-the-badge" />
  <img alt="UI: Windows Forms" src="https://img.shields.io/badge/UI-Windows%20Forms-0088cc?style=for-the-badge" />
</p>

## Overview

This repository is a compact collection of **Visual Basic .NET (VB.NET) Windows Forms** projects focused on UI design, patterns, and experimentation in the classic desktop ecosystem. It currently includes one sample project: a **binary clock** that shows the current hour, minute, and second as coloured binary blocks, updated live by a timer.

It is useful if you are learning VB.NET and want a small, readable example of timer events, binary number conversion, and mouse-driven form interaction.

## Repository structure

```text
vb_codes/
├── .gitignore
├── README.md
└── Observer Pattern/
    ├── Observer Pattern.sln
    └── Observer UI/
        ├── My Project/
        ├── Observer UI.vbproj
        ├── Observer.vb
        ├── Observer.Designer.vb
        └── Observer.resx
```

## Featured project: Binary clock (`Observer Pattern`)

### What it does

The project in the `Observer Pattern` folder is a Windows Forms application (`FormBinary`) that visualizes the current time using a binary-style layout:

- **Red** blocks represent the hour
- **Yellow** blocks represent the minute
- **Green** blocks represent the second
- Each column reflects a binary weight from 32 down to 1, so six blocks can represent any value from 0 to 59
- A label above the blocks also shows the time as text, and the display updates in real time

### Visual behavior

- The form is draggable with the left mouse button
- Double-clicking the window closes the app
- The timer refreshes the display every second
- Binary digits are calculated programmatically by subtracting powers of two (`2 ^ n`)

### Core idea

This project is a simple and intuitive example of using UI components, timer events, and custom colouring logic in VB.NET to build a live, animated interface without complex frameworks.

### How the binary conversion works

On every timer tick, `SetColourIndex` takes the hour, minute, or second and walks the powers of two from `2 ^ 5` (32) down to `2 ^ 0` (1). Whenever the remaining value is at least the current power, that bit is switched on and the power is subtracted. `SetBackColour` then colours the matching blocks. For example, 45 seconds is `32 + 8 + 4 + 1`, so the 32, 8, 4, and 1 blocks turn green.

## Project details

| Item | Value |
|---|---|
| Language | Visual Basic (.NET Framework) |
| UI Framework | Windows Forms |
| Main file | `Observer Pattern/Observer UI/Observer.vb` |
| Solution file | `Observer Pattern/Observer Pattern.sln` |
| Build target | .NET Framework 2.0 |
| Purpose | UI experiment / pattern demonstration |

## How to run it

### Visual Studio

1. Open `Observer Pattern/Observer Pattern.sln` in Visual Studio.
2. Build the solution. If the .NET Framework 2.0 targeting pack is not installed, Visual Studio may offer to retarget the project to a newer .NET Framework version.
3. Press `F5` to run the app.

Compiled binaries are not stored in the repository, so build the project to get `Observer.exe` in the `bin` folder.

## Technologies used

- Microsoft Visual Studio
- VB.NET
- .NET Framework 2.0
- Windows Forms
- System.Windows.Forms.Timer

## Learning value

This project helps practice:

- event-driven programming
- timer-based UI updates
- form interaction and drag behavior
- binary number logic
- GUI state updates in Visual Basic

## Future ideas

This repository could grow with more Windows Forms experiments such as:

- calculator apps
- digital clock widgets
- student management dashboards
- data-entry forms
- game UI prototypes
- pattern-based visual demos

## Related projects

- [C# and .NET code examples](https://github.com/gcfernando/csharp_codes) — includes a high-DPI Windows Forms example in .NET 8
- [Glass.Message](https://github.com/gcfernando/glass) — a modern `MessageBox` replacement for Windows Forms apps
- [Spectrum](https://github.com/gcfernando/spectrum-analyzer) — a real-time audio spectrum analyzer built with Windows Forms

---

<div align="center">
  <h3>Built with passion for Visual Basic ✨</h3>
  <p><em>Small projects, bold ideas, and creative UI experiments.</em></p>
</div>

---

## Documentation links

[Read all VB.NET Windows Forms Examples guides online](https://gcfernando.github.io/vb_codes/documentation/) · [Project overview](https://gcfernando.github.io/vb_codes/) · [All developer projects](https://gcfernando.github.io/gcfernando/projects/)
