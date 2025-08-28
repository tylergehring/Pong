

# Unity Pong Game

This project is a simple Pong game built in Unity using C#. It features a player paddle, a computer paddle, a bouncing ball, a scoreboard, and a help screen. Follow these instructions to download, set up, and run the game—even if you are new to Git or Unity.

---

## 1. Prerequisites

- **Unity Hub & Unity Editor:** Download and install [Unity Hub](https://unity.com/download) and use it to install the latest LTS (Long Term Support) version of Unity (2021 or newer recommended).
- **Git:** Download and install [Git](https://git-scm.com/downloads).
- **A GitHub Account:** [Sign up here](https://github.com/) if you don't have one.

---

## 2. Downloading the Project

1. **Clone the Repository:**
   - Open a terminal (Command Prompt or PowerShell on Windows).
   - Navigate to the folder where you want to store the project.
   - Run:
     ```
     git clone https://github.com/your-username/your-repo-name.git
     ```
   - Replace `your-username/your-repo-name` with the actual repository path.
2. **Open the Project in Unity:**
   - Launch Unity Hub.
   - Click 'Open' and select the folder you just cloned.

---

## 3. Setting Up the Project in Unity

1. **Install Required Packages:**
   - In Unity, go to `Window > Package Manager`.
   - Make sure the following packages are installed:
     - **Input System** (for player controls)
     - **TextMeshPro** (for UI text)
2. **Scene Setup:**
   - Open the main scene (or create a new one).
   - Ensure you have the following GameObjects:
     - **Ball** (with `ball.cs` attached)
     - **Player Paddle** (with `player-paddle.cs` attached)
     - **Computer Paddle** (with `computer-paddle.cs` attached)
     - **GameManager** (with `ScoreManager.cs` attached)
     - **UIManager** or similar (with `HelpScreenManager.cs` attached)
   - Assign the `Rigidbody2D` component to the ball and paddles if not already present.
   - Set the `ball` reference in the Computer Paddle script via the Inspector.
   - Create a Canvas with TextMeshPro UI elements for the scoreboard and help screen. Assign these to the appropriate fields in the Inspector.

---


## 4. Running the Game

### Option 1: Play the Executable

If you downloaded a release or clone that includes a `Pong.exe` (or similar) file:

1. Open the build folder in your file explorer.
2. Double-click the `.exe` file to launch the game—no Unity installation required.
3. Use the controls below to play.

### Option 2: Run from Unity Editor

1. Press the **Play** button in Unity to start the game.
2. Use the controls below to play.

---

## 5. Controls

- **Move Up:** `W` or `Up Arrow`
- **Move Down:** `S` or `Down Arrow`
- **Show/Hide Help:** `H` (game pauses while help is open)

---

## 6. Features

- Player and computer paddles
- Ball with realistic bounce
- Scoreboard (player and computer)
- Help screen with instructions (press `H`)
- Game pauses when help is open
- Optional: Enable `useDynamicBounce` on paddles for advanced ball physics

---

## 7. Customization

- Adjust paddle speed and ball speed in the Inspector.
- Edit the help text in the HelpPanel UI.
- Tweak UI layout and colors as desired.

---

## 8. Troubleshooting

- If you see errors about missing packages, install them via the Package Manager.
- If scripts are not working, ensure they are attached to the correct GameObjects and all required references are set in the Inspector.
- For Git issues, see [GitHub Docs](https://docs.github.com/en/get-started/quickstart).

---

## 9. Additional Resources

- [Unity Learn](https://learn.unity.com/)
- [GitHub Docs](https://docs.github.com/)

---

Enjoy playing and customizing your Pong game!

