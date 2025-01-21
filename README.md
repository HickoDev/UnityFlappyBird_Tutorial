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


















