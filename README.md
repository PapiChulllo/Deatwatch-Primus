# Deathwatch Primus (Deatwatch-Primus)

**Educational Assignment 1 mobile game (repo description: “A1_Mobile Game Development”).** A top-down 2D tank prototype: touch-to-move, automatic shooting, enemy spawns from the top of the screen, hearts UI, score, collisions, main menu, and sound effects.

Repository folder spelling is **Deatwatch-Primus** (as on GitHub).

---

## What it does

- **Tank:** `TankMovement` moves toward the latest touch world position; `TankShooting` instantiates bullets on a timer
- **Enemies:** `EnemySpawner` spawns along the top edge; `EnemyMovement` advances them
- **Combat / UI:** bullet/player collision scripts, `HealthManager` (3 hearts → game over panel + `timeScale = 0`), `ScoreManager`, `MainMenu`
- Scenes in Build Settings: `MainMenu` → `SampleScene`

**Status / limitations:** **course Assignment 1**, early mobile prototype. Commit history mentions an `.apk`; **no `.apk` is present in the current tree** (`git ls-files` shows none). Unity **2022.3.46f1**. No automated tests; device build not re-verified in this documentation pass.

## Tech stack

| Area | What it uses |
|---|---|
| Engine | **Unity** `2022.3.46f1` |
| Input | `Input.touchCount` / `GetTouch` |
| UI | uGUI hearts + **TextMesh Pro** game-over text |
| Audio | `Assets/Sound_Effects/` |

## What's in the project

| System | Key files |
|---|---|
| Tank move / shoot | `Assets/_Scripts/TankMovement.cs`, `TankShooting.cs` |
| Enemies | `EnemySpawner.cs`, `EnemyMovement.cs` |
| Combat / score / health / menu | `Bullet*.cs`, `PlayerCollision.cs`, `HealthManager.cs`, `ScoreManager.cs`, `MainMenu.cs` |

Ten authored scripts under `Assets/_Scripts/`. Prefabs and SFX support the scenes.

### Code / system highlights

- Touch sets a 2D target; `MoveTowards` each frame.
- Auto-fire on `shootingRate` without requiring a separate fire button.
- Health UI swaps full/empty heart sprites; game over freezes time and can load `MainMenu`.

## Scenes

| Build order | Scene | Purpose |
|---|---|---|
| 0 | `Assets/Scenes/MainMenu.unity` | Menu |
| 1 | `Assets/Scenes/SampleScene.unity` | Gameplay |

## Third-party assets

TextMesh Pro plus sprites/SFX/prefabs used by the assignment. No separate license inventory committed.

## About this repository

**Labeled educational / course Assignment 1 (mobile).** Public under **PapiChulllo**. Name typo in the GitHub repo title is preserved for the link; gameplay branding in docs uses “Deathwatch Primus” for readability.
