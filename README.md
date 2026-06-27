# 👻 Shadow Escape

<div align="center">

![Unity](https://img.shields.io/badge/Unity-6-black?style=for-the-badge\&logo=unity)
![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge\&logo=csharp)
![Platform](https://img.shields.io/badge/Platform-PC-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

**A unique 2D top-down stealth adventure game built with Unity 6, featuring a dynamic lantern mechanic, enemy AI, hidden traps, collectible keys, and escape-based gameplay.**

</div>

---

## 🎮 Gameplay Preview

> 📹 Gameplay Video

**Coming Soon**

---

## 📸 Screenshots

> Screenshots will be added soon.

---

# 📖 About The Project

Shadow Escape is a 2D top-down stealth adventure game developed with Unity 6 as a university project.

The objective is simple: collect three hidden keys and escape through the exit door while avoiding ghosts and dangerous traps.

Unlike traditional escape games, Shadow Escape introduces a unique lantern mechanic. The player can switch the lantern on and off at any time. When the lantern is turned on, hidden traps become visible, but nearby ghosts can detect and chase the player. Turning the lantern off makes the player harder for ghosts to detect, but traps become invisible, increasing the risk of taking damage.

This creates a simple but engaging risk-versus-reward gameplay experience.

---

# ✨ Features

* 🎮 Smooth top-down player movement
* 🏃 Running mechanic
* 🕯️ Toggleable lantern system
* 👻 Ghost patrol AI
* 🎯 Ghost chase AI
* ⚠️ Hidden spike traps
* 🔑 Key collection system
* 🚪 Exit door with unlock condition
* ❤️ Health system
* 🏆 Win & Lose conditions
* 📊 User Interface (Health & Keys)
* ⏸️ Restart functionality

---

# 🎯 Game Mechanics

### 🕯️ Lantern System

The lantern is the core mechanic of the game.

When the lantern is **ON**

* Ghosts can detect the player.
* Hidden traps become visible.

When the lantern is **OFF**

* Ghosts lose player detection.
* Spike traps become invisible.

Players must constantly decide whether visibility or stealth is more important.

---

### 👻 Ghost AI

Ghosts patrol between predefined points.

If the player enters the lantern detection area while the lantern is active, the ghost switches from patrol mode to chase mode.

When the player escapes or turns the lantern off, the ghost returns to its patrol route.

---

### ⚠️ Hidden Traps

Spike traps damage the player on contact.

Their visibility depends entirely on the lantern state, making exploration more strategic.

---

### 🔑 Key Collection

Players must collect all three keys before reaching the exit door.

Attempting to leave early will not complete the game.

---

# 🎮 Controls

| Key        | Action         |
| ---------- | -------------- |
| W A S D    | Move           |
| Left Shift | Run            |
| Space      | Toggle Lantern |

---

# 🛠️ Technologies

* Unity 6
* C#
* Unity Physics 2D
* Rigidbody2D
* Collider2D
* TextMeshPro
* Unity UI System

---

# 📂 Project Structure

```text
Assets
├── TheGame
    ├── Animations
    ├── Audio
    ├── Prefabs
    ├── Scenes
    ├── Scripts
    ├── Sprites
```

---

# 🚀 Getting Started

Clone the repository

```bash
git clone https://github.com/miarmely/shadow-escape.git
```

Open the project using **Unity 6** or newer.

Open the main scene and press **Play**.

---

# 📌 Future Improvements

* Character animations
* Multiple enemy types
* Multiple levels
* Save system
* Sound effects
* Background music
* Settings menu
* Difficulty levels
* Collectible treasures
* Improved visual effects
* Particle system
* Dynamic lighting

---

# 📚 Educational Purpose

This project was developed as part of a university game development assignment.

The primary objective was to design and implement an original 2D game demonstrating player movement, AI behavior, game mechanics, UI implementation, collision handling, and gameplay flow using Unity.

---

# 👨‍💻 Author

**Mert Akdemir**

**Software Engineer | Backend Developer (.NET & Node.js) | Database Engineer**

---

# ⭐ Support

If you like this project, consider giving it a ⭐ on GitHub.
