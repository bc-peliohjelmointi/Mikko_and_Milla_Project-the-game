using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movement;

    private int points = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize(); //normalses diagonal movement move so its the same speed as the other movements
    }

    //used for physics
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);

        }
    }
}
