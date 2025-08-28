
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private InputAction moveAction;

    private void OnEnable()
    {
        moveAction = new InputAction(type: InputActionType.Value, binding: "<Keyboard>/w");
        moveAction.AddCompositeBinding("1DAxis")
            .With("Positive", "<Keyboard>/w")
            .With("Positive", "<Keyboard>/upArrow")
            .With("Negative", "<Keyboard>/s")
            .With("Negative", "<Keyboard>/downArrow");
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    private void Update()
    {
        float move = moveAction.ReadValue<float>();
        _direction = new Vector2(0, move);

        // Allow quitting the application with Escape key (Input System)
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
}
