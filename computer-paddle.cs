using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball; // Assign this in the Inspector


    private void FixedUpdate()
    {
        if (ball != null)
        {
            Vector2 newPosition = new Vector2(_rigidbody.position.x, ball.position.y);
            _rigidbody.MovePosition(newPosition);
        }
    }

}
