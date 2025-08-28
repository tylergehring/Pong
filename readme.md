# Unity Pong Game

A simple Pong game built in Unity using C#. The game features two paddles (player and computer) and a ball, following classic Pong mechanics.

## Features

- **Player Paddle:** Controlled via keyboard (W/S or Up/Down arrows).
- **Computer Paddle:** Automatically tracks the ball's vertical position.
- **Ball:** Bounces off paddles and walls, resets when hitting left or right wall.
- **Dynamic Bounce (Optional):** Ball bounce angle can change based on where it hits the paddle.

## Controls

- **Player Paddle:**  
  - Move Up: `W` or `Up Arrow`
  - Move Down: `S` or `Down Arrow`

## Scripts Overview

- `ball.cs`: Handles ball movement, collision, and reset logic.
- `paddle.cs`: Abstract base class for paddles, includes optional dynamic bounce.
- `player-paddle.cs`: Inherits from `Paddle`, handles player input.
- `computer-paddle.cs`: Inherits from `Paddle`, follows the ball automatically.

## How to Play

1. Open the project in Unity.
2. Assign the `Rigidbody2D` component to the ball and paddles.
3. Attach the scripts to the appropriate GameObjects:
   - `ball.cs` to the Ball object.
   - `player-paddle.cs` to the Player Paddle.
   - `computer-paddle.cs` to the Computer Paddle.
4. Set the `ball` reference in the Computer Paddle script via the Inspector.
5. Press Play to start the game.

## Customization

- Adjust paddle speed and ball speed in the Inspector.
- Enable `useDynamicBounce` on paddles for more advanced ball physics.

## Requirements

- Unity (any recent version supporting C# scripts)
- Unity Input System package (for player controls)

