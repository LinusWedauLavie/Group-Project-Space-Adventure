using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        animator.SetFloat("Speed", Mathf.Abs(move));
    }
}
