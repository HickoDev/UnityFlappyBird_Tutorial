using UnityEngine; // Includes Unity’s core game engine library
using TMPro; // Allows the use of TextMeshPro for UI text rendering

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f; // The force applied to the bird when jumping
    public int score; // Stores the player's current score
    static int bestscore; // Stores the best score achieved in the session

    public TMP_Text scoreText; // UI text to display the current score
    public TMP_Text BestScore; // UI text to display the best score

    public float speedIncreaseAmount = 0.01f; // How much the game speed increases per score
    public float maxTimeScale = 1.5f; // The maximum allowed game speed

    public GameObject button; // Restart button (becomes visible on game over)

    private Rigidbody2D rb; // Reference to the Rigidbody2D component for physics movement
    private bool isplaying = false; // Tracks if the game has started
    private int countnumber = 0; // Counts player taps to start the game

    void Start()
    {
        button.SetActive(false); // Hide restart button initially
        score = 0; // Reset score
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the bird
        Time.timeScale = 0; // Pause the game at the start until the player clicks
    }

    void Update()
    {
        // Starts the game when the player clicks for the first time
        if (isplaying == true && countnumber == 1)
        {
            Time.timeScale = 1;
        }

        scoreText.text = score.ToString(); // Update score text on the UI

        // Detects player input to make the bird jump
        if (Input.GetMouseButtonDown(0))
        {
            countnumber++; // Increase tap count
            if (countnumber == 0 && isplaying == false)
            {
                isplaying = true; // Set game to active state
            }
            rb.linearVelocity = Vector2.up * jumpForce; // Apply upward force to the bird
        }
    }

    void StopGame()
    {
        Time.timeScale = 0; // Pause the game
        button.SetActive(true); // Show the restart button
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the bird passes a score trigger, increase the score
        if (other.CompareTag("score"))
        {
            score++; // Increment score
            Time.timeScale += speedIncreaseAmount; // Increase game speed slightly
            Time.timeScale = Mathf.Min(Time.timeScale, maxTimeScale); // Ensure it doesn't exceed max speed
            Debug.Log("Score: " + score + " Time = " + Time.timeScale); // Debug log for testing
        }

        // If the bird hits an obstacle, stop the game
        if (other.CompareTag("Respawn"))
        {
            StopGame();
        }
    }
}
