using UnityEngine;
using UnityEngine.InputSystem.Controls;
using TMPro;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movement;

    private int points;

    public TextMeshProUGUI pointsText;
    public GameObject winText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        points = 0; //set points to 0
        SetCountText(); //activate the points text

        //turn off win text at the start of the game
        winText.SetActive(false);
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

    /// <summary>
    /// checks if the player hits a collectable
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //does the object have the same tag?
        if (collision.gameObject.CompareTag("PickUp"))
        {
            //collectable disapears
            collision.gameObject.SetActive(false);
            points++;
            SetCountText();
        }
    }

    /// <summary>
    /// show points (and win text)
    /// </summary>
    private void SetCountText()
    {
        pointsText.text = "Points: " + points.ToString();

        //win if all points are collected
        if (points >= 9)
        {
            //show win text
            winText.SetActive(true);
        }
    }
}
