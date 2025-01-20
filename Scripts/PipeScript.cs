using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed at which the pipe moves
    public float destroyXPosition = -10f; // X position at which the pipe is destroyed

    void Update()
    {
        // Move the pipe to the left along the X-axis
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Destroy the pipe if it goes beyond the destroy position on the X-axis
        if (transform.position.x <= destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
