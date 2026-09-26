# Deathwatch Primus

**A top-down tank shooter prototype for mobile game development coursework.** The player tank moves, auto-fires, and fights spawned enemies while score and health are tracked in UI.

---

## Status

Course assignment prototype (GAME2014). Includes an Android `.apk` build artifact in history. Educational work, not a production title.

## Tech stack

| Area | What it uses |
|---|---|
| Engine | **Unity 2022.3.46f1** |
| Language | **C#** |
| Platform target | Android (APK present in repo history) |

## What's in the project

| System | Key files |
|---|---|
| Tank movement / shooting | `Assets/_Scripts/TankMovement.cs`, `TankShooting.cs` |
| Bullets | `Assets/_Scripts/BulletMovement.cs`, `BulletCollision.cs` |
| Enemies | `Assets/_Scripts/EnemyMovement.cs`, `EnemySpawner.cs` |
| Health / score / collisions | `Assets/_Scripts/HealthManager.cs`, `ScoreManager.cs`, `PlayerCollision.cs` |
| Main menu | `Assets/_Scripts/MainMenu.cs` |

## About this repository

Public coursework showcase. Sound design and UI polish commits are part of the assignment history.
