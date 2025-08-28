using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("left-wall"))
        {
            if (ScoreManager.Instance != null)
                ScoreManager.Instance.AddComputerScore();
            ResetPosition();
        }
        if (collision.gameObject.CompareTag("right-wall"))
        {
            if (ScoreManager.Instance != null)
                ScoreManager.Instance.AddPlayerScore();
            ResetPosition();
        }
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }
    public void ResetPosition()
    {
        _rigidbody.linearVelocity = Vector2.zero;
        _rigidbody.position = Vector2.zero;
        AddStartingForce();
    }

}
