using UnityEngine; // Includes Unity’s libraries
using TMPro;

public class BirdController : MonoBehaviour // Defines the class for the bird
{
    public float jumpForce = 5f; // The strength of the bird’s jump
    static int score;
    public TMP_Text scoreText; // Reference to the TextMeshPro text component
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    public float speedIncreaseAmount = 0.01f; // Amount to increase the game speed by every time the score increases
    public float maxTimeScale = 1.5f; // Maximum time scale value

    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody2D>(); // Find the Rigidbody2D component on the bird
    }

    void Update()
    {
        scoreText.text = score.ToString(); // Update the score display

        if (Input.GetMouseButtonDown(0)) // Check if the player clicks or taps
        {
            rb.linearVelocity = Vector2.up * jumpForce; // Apply upward force to the bird
        }

        // Increase the game speed (time scale) based on the score
    
    }

    void StopGame()
    {
        Time.timeScale = 0; // Pause the game by setting time scale to 0
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bird has passed through the trigger
        if (other.CompareTag("score"))
        {
            score++; // Increment the score
            Time.timeScale += speedIncreaseAmount; // Increase the time scale by the defined amount
            Time.timeScale = Mathf.Min(Time.timeScale, maxTimeScale); // Clamp it to maxTimeScale
            Debug.Log("Score: " + score  + "Time = " + Time.timeScale); // Log the score for testing
        }
        if (other.CompareTag("Respawn"))
        {
            StopGame(); // Stop the game if the bird hits the respawn trigger
        }
    }
}
