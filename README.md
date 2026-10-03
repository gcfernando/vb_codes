<div align="center">
  <h1><span style="color:#ff6b6b">VB Projects</span> <span style="color:#ffd166">✨</span></h1>
  <p>
    <strong><span style="color:#7dd3fc">Visual Basic learning workspace</span> with small, interactive Windows Forms experiments.</strong>
  </p>
</div>

<p align="center">
  <img alt="VB Projects banner" src="https://img.shields.io/badge/Language-Visual%20Basic-6f42c1?style=for-the-badge&logo=visual-studio-code" />
  <img alt=".NET Framework" src="https://img.shields.io/badge/Framework-.NET%20Framework-512bd4?style=for-the-badge" />
  <img alt="UI Type" src="https://img.shields.io/badge/UI-Windows%20Forms-0088cc?style=for-the-badge" />
</p>

## Overview

This repository is a compact collection of Visual Basic projects focused on UI design, patterns, and experimentation in the classic Windows Forms ecosystem. It currently includes one polished sample project that demonstrates a dynamic binary-style time display with a custom visual effect.

## Repository structure

```text
VB_Projects/
├── .git/
├── .gitignore
├── README.md
└── Observer Pattern/
    ├── Observer Pattern.sln
    └── Observer UI/
        ├── My Project/
        ├── Observer UI.vbproj
        ├── Observer.vb
        ├── Observer.Designer.vb
        ├── Observer.resx
        └── bin/
```

## Featured project: Observer Pattern

### What it does
The <span style="color:#00c2a8">Observer Pattern</span> project is a Windows Forms application that visualizes the current time using a binary-style layout:

- <span style="color:#ff4d4d">Red</span> blocks represent the hour
- <span style="color:#ffd166">Yellow</span> blocks represent the minute
- <span style="color:#4ade80">Green</span> blocks represent the second
- Each column reflects the binary weight of the time value
- The interface updates in real time with a ticking clock

### Visual behavior
- The form is draggable by mouse
- Double-clicking the window closes the app
- The timer continuously refreshes the display seconds by seconds
- Binary logic is generated programmatically using power-of-two values

### Core idea
This project is a simple and intuitive example of using UI components, timer events, and custom drawing logic in VB.NET to build a live, animated interface without complex frameworks.

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

### Option 1: Visual Studio
1. Open `Observer Pattern.sln` in Visual Studio.
2. Restore/build the solution.
3. Press `F5` to run the app.

### Option 2: Open the built executable
The project already includes a compiled binary in:

```text
Observer Pattern\Observer UI\bin\Release\Observer.exe
```

Double-click it to launch the app on a Windows machine.

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

---

<div align="center">
  <h3><span style="color:#7c3aed">Built with passion for Visual Basic ✨</span></h3>
  <p><em>Small projects, bold ideas, and creative UI experiments.</em></p>
</div>
