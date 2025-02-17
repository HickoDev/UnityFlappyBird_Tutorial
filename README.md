 # Overview
Welcome to this beginner-friendly Unity course! This project is designed for those who are new to Unity and game development. In this tutorial, you will create a simple Flappy Bird clone, step by step, to get a hands-on introduction to the Unity game engine.

Through this project, you will learn the basics of Unity, including:

* Scene setup and game objects
* Scripting with C# to handle game mechanics
* Implementing physics and controls for your game character
* Creating user interfaces (UI) for score and game over screens
  
By the end of this course, you’ll have a fully functional Flappy Bird clone and a solid understanding of Unity's core concepts, preparing you for more advanced projects in game development!

This course is perfect for beginners, and no prior experience with Unity is required.


# Prerequisites
Before starting, ensure you have the following:

**Unity Hub:**
Download and install Unity Hub from the official website.
![image](https://github.com/user-attachments/assets/6424d89b-7959-437d-852f-562c54d949d0)

**Unity Editor:** 
Open Unity Hub and install 6000.0.29f1 version of the Unity Editor.( only universal windows platform build support)
![Capture d'écran 2025-01-20 210909](https://github.com/user-attachments/assets/a569f4dc-681f-42be-a494-94e99ff94271)

# Set Up Your Development Environment:

Launch Unity Hub and sign in or create a Unity account.

Creating the Project:

1-Open Unity Hub

2-Click on the "New Project" button.

![image](https://github.com/user-attachments/assets/945a244a-cc32-4d9c-b51c-623253cba517)

3-Select the "Universal 2D" template.

4-Name your project "BirdGame" and choose a save location.

5-Click "Create" to generate the project.

![image](https://github.com/user-attachments/assets/4e70e848-7b02-494d-8465-822b2e53ebe0)

# Developing the Game
Once the project is open, let's familiarize ourselves with the Unity Editor interface. Here's an overview of the main components:

**Toolbar**: Located at the top, it provides access to essential features like Play mode controls, Unity Cloud Services, and the Editor layout menu.

**Hierarchy Window**: Displays a hierarchical text representation of every GameObject in the current Scene. It reveals the structure of how GameObjects attach to each other.

**Scene View**: Allows you to visually navigate and edit your Scene. It can display a 3D or 2D perspective, depending on your project type.

**Game View**: Simulates what your final rendered game will look like through your Scene Cameras.

**Inspector Window :** Enables you to view and edit all properties of the currently selected GameObject. The layout and contents change based on the selected object.

**Project Window:** Shows your library of Assets available for use in your Project. Imported Assets appear here.

**Console Window:** Displays output from your game, such as debug messages, warnings, and errors.
![image](https://github.com/user-attachments/assets/62eb8f68-1ecc-444e-b1b4-afa5f2877ca0)


# Setting Up the Background
Now that we understand the layout of the Unity Editor, we will add the background for the game.

1-Create an empty GameObject and name it "Background."

2-From the Art folder, drag the background image into the Scene and assign it to the "Background" GameObject.

3-Continue dragging and positioning additional background images until the entire background area is covered in the Game View.
![image](https://github.com/user-attachments/assets/904a46b1-fce3-44f3-b515-880b8235944b)

# Create the Player


### 1-Create the Player GameObject:

* Right-click in the Hierarchy Window and select Create Empty.
* Rename the new GameObject to "Player."

### 2-Assign the Bird Sprite to the Player:

* From the Art folder, drag the bird sprite into the Scene and assign it to the "Player" GameObject. You can do this by dragging the sprite onto the Player GameObject in the Hierarchy Window.
 
### 3-Add Components to the Player:

* Circle Collider 2D:
  
With the Player GameObject selected, click Add Component in the Inspector Window and search for Circle Collider 2D.
The Circle Collider 2D component adds a circular collision area around the player. This helps detect collisions with other objects in the game (e.g., pipes, ground, etc.).
* Rigidbody 2D:
  
Click Add Component again and search for Rigidbody 2D.
The Rigidbody 2D component adds physics properties to the player, enabling it to react to forces like gravity and be moved by physics-based interactions. By default, Unity applies gravity to objects with a Rigidbody 2D, which will cause the bird to fall unless we apply a force (e.g., when the player taps the screen or presses a key).

![image](https://github.com/user-attachments/assets/8254dc39-4be8-4b18-905a-a5724bec94b0)

the final result will look like this :

![Capture d'écran 2025-01-20 222131](https://github.com/user-attachments/assets/6ad16121-8346-4a00-970c-df9e95cb91c5)

**Tip:**  
For the Player GameObject, we use colliders smaller than the actual size of the player sprite. This ensures that the game isn't too strict with collisions, giving the player a little more room to navigate and making the game more fun and forgiving. This small adjustment helps prevent frustrating moments where the player might collide with an obstacle even though they didn’t technically touch it.


### 4- Adding the Player Script

Now, let's create a script that will make the player (bird) jump when the player clicks the left mouse button.



* In the Project Window, right-click and select Create → C# Script.
* Name the script BirdController.
* Open the Script and Write the Code:
* Double-click the newly created BirdController script to open it in your preferred code editor (e.g., Visual Studio or Visual Studio Code).
```csharp
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
             rb.linearVelocity = Vector2.up * jumpForce; 
        }
    }
}
```
### Script Breakdown:

- **`using UnityEngine;`**: Includes Unity's core libraries to use built-in classes like `MonoBehaviour` and `Rigidbody2D`.
  
- **`public class BirdController : MonoBehaviour`**: Defines the class controlling the bird's behavior, inheriting from `MonoBehaviour`.
-  **`MonoBehaviour`** is the base class from which every Unity script derives. It provides Unity-specific functions like `Start()`, `Update()`, `Awake()`, etc. These methods allow you to hook into Unity’s game loop, which is essential for responding to game events like input, collisions, and physics.

- **`public float jumpForce = 5f;`**: A public variable to control the jump strength, editable in the Unity Editor.

- **`private Rigidbody2D rb;`**: A reference to the **Rigidbody2D** component for handling physics.

- **`void Start()`**: Finds and stores the **Rigidbody2D** component when the game starts.

- **`void Update()`**: Checks if the left mouse button is clicked (`Input.GetMouseButtonDown(0)`). If clicked, it applies an upward velocity (`rb.linearVelocity = Vector2.up * jumpForce;`), making the bird jump.

### Attach the Script to the Player GameObject:

1. Save the script and return to Unity.
2. Select the **Player GameObject** in the **Hierarchy Window**.
3. In the **Inspector Window**, click **Add Component** and search for `BirdController`.
4. Select the script to attach it to the **Player GameObject**.

# Create the Pipe GameObject and Script

1. **Create the Obstacle GameObject:**
   - In the **Hierarchy Window**, right-click and select `Create Empty`.
   - Name this GameObject `Obstacle`.
     


2. **Add Children to the Obstacle GameObject:**
   - **Pipes:**
     - Right-click on the `Obstacle` GameObject and select `2D Object` → `Sprite`.
     - Assign the pipe sprite to this object.
     - Rename it `PipeTop`.
     - Repeat the process to create a second child named `PipeBottom`.
     - Add a **Box Collider 2D** component to both `PipeTop` and `PipeBottom` to enable collision detection.
   - **Score Trigger:**
     - Right-click on the `Obstacle` GameObject and select `Create Empty`.
     - Name this GameObject `Score`.
     - Add a **Box Collider 2D** to it.
     - Check the **Is Trigger** option on the `Score` GameObject’s collider. This allows the bird to pass through it without physical collision.
    
       
   ![image](https://github.com/user-attachments/assets/dd3b198c-f5fb-43c0-b460-9fb34d1b55f6)




3. **Set Up the Collision:**
   - Position the `PipeTop`, `PipeBottom`, and `Score` children so that they form a passable obstacle.
   - The collision will look like this:
   
  ![Capture d'écran 2025-01-21 164252](https://github.com/user-attachments/assets/098dfa21-abb8-4130-8e58-a786d0d2c5de)

### Difference Between Trigger and Real Collision

| **Aspect**            | **Trigger Collider**                                                                 | **Regular Collider**                                                              |
|------------------------|---------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------|
| **Definition**         | A collider set to "Is Trigger" allows objects to pass through it without physical interaction. | A regular collider prevents objects from passing through it, enabling physical collisions. |
| **Purpose**            | Used for detecting events, such as scoring or activating gameplay mechanics.          | Used for creating physical boundaries and realistic interactions between objects. |
| **Physics Interaction**| Does not apply physical forces or stop objects; only detects overlap.                 | Applies physical forces and stops objects when they collide.                     |
| **Event Methods**      | Triggers methods like `OnTriggerEnter2D`, `OnTriggerStay2D`, and `OnTriggerExit2D`.   | Triggers methods like `OnCollisionEnter2D`, `OnCollisionStay2D`, and `OnCollisionExit2D`. |
| **Example Use Case**   | Passing through a "score zone" or detecting entry into a special area.                | Preventing the player from going through walls or colliding with obstacles.       |

### Purpose of Each Component:
- **Pipes (`PipeTop` and `PipeBottom`)**: These represent the visible obstacles the player needs to avoid.
- **Score Trigger (`Score`)**: A hidden collider used to detect when the bird successfully passes between the pipes, allowing you to track the score.

### 4. Creating the Pipe Script

Now, we need to give the obstacle movement. The goal is for the obstacle to move toward the player, simulating the gameplay challenge. Additionally, once the obstacle leaves the game view, we’ll destroy it to prevent unnecessary objects from remaining in the scene. 

This helps optimize resource management, which is a good practice in game development. Although in this small project it might not have a significant performance impact, it’s important to get into the habit of keeping the game scene clean.

#### Script:

```csharp
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
```
### 5. Creating the Floor Background

Next, we’ll create the floor background to simulate the scrolling effect of the ground beneath the player. The floor will move at the same rate as the pipes and loop seamlessly as part of the gameplay experience. Additionally, we will add a collider to the floor to detect collisions with the player.

#### Steps to Set Up the Floor Background:

1. **Create the Floor GameObject**:
   - In the **Hierarchy Window**, create a new empty GameObject and name it `Floor`.
   - Drag and drop the floor sprite from your assets into the scene and assign it to the `Floor` GameObject.

2. **Repeat the Background**:
   - Duplicate the floor sprite and place copies side by side in the Scene View until the entire background is covered in the Game View.
   - Ensure the sprites are aligned seamlessly to avoid visual gaps.

3. **Add a Collider**:
   - Select the `Floor` GameObject in the **Hierarchy Window**.
   - In the **Inspector Window**, click **Add Component** and add a **Box Collider 2D**.
   - Adjust the collider size and position to match the visible floor area.

4. **Attach the Movement Script**:
   - Since the floor background moves at the same speed as the pipes, we can reuse the `PipeScript`.
   - Attach the `PipeScript` to the `Floor` GameObject:
     1. Select the `Floor` GameObject.
     2. Click **Add Component** in the **Inspector Window**.
     3. Search for `PipeScript` and add it.


This setup ensures the floor background scrolls seamlessly alongside the pipes, creating a cohesive and dynamic game environment. Using the same script simplifies the implementation and keeps the codebase clean.

![image](https://github.com/user-attachments/assets/ee664091-345a-4722-a0ea-8eeb21b39de7)


# Handling Collisions and Displaying the Score

### Tags in Unity

In Unity, **tags** are a way to categorize and identify GameObjects. They allow you to easily reference specific objects in your scene without needing to store a reference to each one individually. Tags are especially useful for organizing and managing GameObjects in your project, making it easier to handle different types of objects during gameplay.

#### What are Tags Used For?
Tags are typically used for:
- **Identifying specific GameObjects**: For example, you can use tags to mark objects like "Player", "Enemy", "Score", or "Obstacle".
- **Efficient Collision Detection**: You can check whether a GameObject is of a specific type in scripts, allowing you to handle events like scoring or collisions.
- **Layered Logic**: Tags can help you organize your game objects logically, making it easier to manage complex interactions.

#### How to Create and Use Tags:

#### Steps to Tag GameObjects:

1. **Add Tags**:
   - **Obstacle Detection**:
     - Select the obstacles in the **Hierarchy Window**.
     - In the **Inspector Window**, find the **Tag** dropdown and choose **Add Tag**.
     - Add a new tag named `Respawn`.
     - Assign the `Respawn` tag to the obstacle GameObjects.
     - 
      ![image](https://github.com/user-attachments/assets/184b6e68-2c0a-425b-b894-a9c612d1c067)

   - **Score Trigger**:
     - Select the score-triggering GameObject (the empty GameObject in the obstacle setup).
     - Add a new tag named `Score`.
     - Assign the `Score` tag to the score GameObject.
       
       ![image](https://github.com/user-attachments/assets/e1d4a216-99c1-43d0-ab53-93eba57a6701)


#### Steps to Add the Canvas for the Score Display:

1. **Create a Canvas**:
   - In the **Hierarchy Window**, right-click and select **UI > Canvas**.
   - In the **Inspector Window**, set the **Canvas Scaler** mode to **Scale with Screen Size**. This ensures that the UI elements scale properly across different screen sizes.
  
   ![image](https://github.com/user-attachments/assets/b8eab282-03da-4244-b8f8-4af85bb3923c)


2. **Add a Text Element**:
   - Right-click the **Canvas** in the **Hierarchy Window** and select **UI > Text - TextMeshPro** (preferred for better font rendering).
   - Place the text element in the middle-top of the screen (adjust the position using the **Rect Transform** in the **Inspector Window**).
   - Customize the font size, color, and alignment for clear visibility.

3. **Name the Text**:
   - Rename the text element to `ScoreText` in the **Hierarchy Window** for easier reference in the script.



#  Update BirdController Script: Scoring and Speed Increase

Now, we’ll update the **BirdController** script to handle both the scoring system and the progressive speed increase. Every time the bird successfully passes through a score zone, the score will increase, and the game’s speed will slightly increase to make it progressively harder. 

The script will also handle detecting the bird’s collisions with obstacles (Respawn) to stop the game when the bird hits something.

#### Steps to Update the Script:

1. **Create Score Display**:
   - Add a reference to the **TextMeshPro** text component for displaying the score.
   
2. **Increase Speed Over Time**:
   - Every time the score increases, slightly increase the game speed.
   - Set a maximum speed limit to ensure the game doesn’t become unplayable.

3. **Collision Detection**:
   - If the bird collides with an object tagged `Score`, the score will increase, and the game speed will increase.
   - If the bird collides with an object tagged `Respawn`, the game will stop.

#### Updated BirdController Script:

```csharp
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
            Debug.Log("Score: " + score + " Time: " + Time.timeScale); // Log the score for testing
        }
        if (other.CompareTag("Respawn"))
        {
            StopGame(); // Stop the game if the bird hits the respawn trigger
        }
    }
}

```

# Adding the Spawner System

To make the game dynamic, we need to spawn obstacles and ground tiles at regular intervals. The spawner system will handle:
- **Obstacle spawning**: Obstacles (pipes) will appear at a fixed X position but at random Y positions within a defined range.
- **Ground spawning**: Ground tiles will appear at a fixed X and Y position to create a continuous scrolling effect.




#### Objective
For the main game mechanics, we need to dynamically spawn the ground and obstacles at regular intervals:
- **Obstacles**: Spawn at a fixed X position with a random Y position within a specified range.
- **Ground tiles**: Spawn at a fixed X and Y position to create a continuous scrolling effect.



#### Steps to Implement the Spawner System

1. **GameObjects for Spawning**:

   - Create two empty GameObjects in the **Hierarchy**:
     - **GSpawner**: Responsible for spawning the ground tiles.
     - **OSpawner**: Responsible for spawning the obstacles.
       

![Capture d'écran 2025-01-22 210113](https://github.com/user-attachments/assets/3946c359-bc0b-4af9-9283-735a753d00c6)


2. **Attach the Script**:
   - Use the **Spawner** script below, and attach it to both **GSpawner** and **OSpawner** GameObjects.

```csharp
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PrefabToSpawn; // The prefab to spawn
    public float initialSpawnInterval; // Time between each spawn
    public float minY; // Minimum Y position for spawning (used for obstacles)
    public float maxY; // Maximum Y position for spawning (used for obstacles)
    public float spawnX; // Fixed X position for spawning
    public float spawnZ; // Fixed Z position for spawning

    private float currentSpawnInterval;

    void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        InvokeRepeating(nameof(SpawnObject), currentSpawnInterval, currentSpawnInterval);
    }

    void SpawnObject()
    {
        // Generate a random Y position for obstacles
        float randomY = Random.Range(minY, maxY);

        // Define spawn position
        Vector3 spawnPosition = new Vector3(spawnX, randomY, spawnZ);

        // Instantiate the prefab at the calculated position
        Instantiate(PrefabToSpawn, spawnPosition, Quaternion.identity);
    }
}

``` 

3. **Adjusting the Spawner Script Variables**:

To ensure objects spawn off-screen, configure the **Spawner Script** as follows:

* Ospawner:

![image](https://github.com/user-attachments/assets/6d577547-0c01-4eed-bf85-924773abca71)


* Gspawner:

![image](https://github.com/user-attachments/assets/3aef85dd-c3d6-4b89-92a0-7fba74c5ca32)


#### **Note**: How to Create a Prefab
1. Select a GameObject from the **Hierarchy** (e.g., an obstacle or ground object).
2. Drag the GameObject into the **Project Window**.
3. A prefab will be created, allowing you to reuse the object as needed.

# Adding a Button and Best Score Display

In this section, we will add a **Restart Button** and a **Best Score** display to the game. The restart button will be shown only when the player loses, and it will allow the player to restart the game. The best score will track the highest score achieved by the player and will persist across sessions.

### Step 1: Create the UI Button
1. **Add the Button**:
   - In the **Hierarchy**, right-click and select **UI** > **Button - TextMeshPro** (or **Button** if you don't have TextMeshPro).
   - Rename the button to **RestartButton** or something similar.
   - Adjust the button’s position and size according to your preference.
   
2. **Attach an Image to the Button**:
   - Click on the **RestartButton** in the **Hierarchy**.
   - In the **Inspector**, find the **Button** component.
   - In the **Image** field, click the small circle next to **Source Image** and choose any image you like from the **Art** folder. This will be the button's visual representation.
  
### Step 2: Create the Best Score Text
1. **Add the Text Element**:
   - Right-click on the **Canvas** in the **Hierarchy** again, and select **UI** > **Text - TextMeshPro**.
   - Rename it to **BestScoreText**.
   - Place this text at a convenient location on the screen (for example, at the top-right corner).

2. **Change the Text**:
   - Modify the **Text** field in the **TextMeshPro** component to display something like: "Best Score: 0".
   - Adjust the alignment and font size to your preference.
  
 ### Step 3 : Make the both of them invisible
  * In the Hierarchy Window, click on the GameObject you want to make invisible.
  * In the Inspector Window, at the top of the GameObject's properties, you will see a checkbox next to the GameObject's name.
  * Uncheck the box next to the GameObject's name (this is the "active" checkbox). This will deactivate the entire GameObject and make it invisible in the scene, along with disabling all its components (such as the Renderer, Colliders, Scripts, etc.).

    ![image](https://github.com/user-attachments/assets/405e22c2-0d7f-45bf-9318-5bd8f3a6a21a)

### Step 4 : Make the button reload the game
 * make a script to reload :
 ```csharp
   
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
public class RestartController : MonoBehaviour
{
    // This function reloads the current scene
    public void ReloadScene()
    {
        // Get the current scene and reload it
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
```
* attach the script to an empty game object you created :
  
   ![image](https://github.com/user-attachments/assets/b3a82252-4986-4c97-a5ba-b03221a3b734)

* assign an event to the button OnClick() action, link the GameObject containing the reload script, and select the function that restarts the game.

  
![image](https://github.com/user-attachments/assets/119ca742-40eb-4a33-818b-6dc63b76460e)


    
  ## Explanation of the Final `BirdController` Script  

  ``` csharp
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
 

        scoreText.text = score.ToString(); // Update score text on the UI

        // Detects player input to make the bird jump
        if (Input.GetMouseButtonDown(0))
        {
            countnumber++; // Increase tap count
            if (countnumber == 1 && isplaying == false)
            {
                isplaying = true; // Set game to active state
                Time.timeScale = 1;
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

```

### 1. **Game Start Behavior**  
- The game starts **paused** by setting `Time.timeScale = 0`.  
- It only begins when the player **clicks for the first time**.  

### 2. **Jump Mechanic**  
- On a mouse click, the bird's **vertical velocity** is set to make it jump.  

### 3. **Score Handling**  
- When the bird **passes through a score trigger**, the score increases.  
- The game speed **slightly increases** with each score, up to a **maximum limit**.  

### 4. **Collision Detection**  
- If the bird **hits an obstacle (tag: "Respawn")**, the game **stops**, and the restart button appears.  

### 5. **Restart Button Logic**  
- The button is **hidden at the start**.  
- It only appears when the player **loses** to allow restarting.  

### Dont forget to attach the button to the script :
![image](https://github.com/user-attachments/assets/bbb0b108-47a8-4baa-a9b6-699c1b899ccf)





















