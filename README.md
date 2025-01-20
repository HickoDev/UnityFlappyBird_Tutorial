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


**1-Create the Player GameObject:**

* Right-click in the Hierarchy Window and select Create Empty.
* Rename the new GameObject to "Player."

**2-Assign the Bird Sprite to the Player:**

* From the Art folder, drag the bird sprite into the Scene and assign it to the "Player" GameObject. You can do this by dragging the sprite onto the Player GameObject in the Hierarchy Window.
 
**3-Add Components to the Player:**

**Circle Collider 2D:**
  
* With the Player GameObject selected, click Add Component in the Inspector Window and search for Circle Collider 2D.
The Circle Collider 2D component adds a circular collision area around the player. This helps detect collisions with other objects in the game (e.g., pipes, ground, etc.).

**Rigidbody 2D:**
  
* Click Add Component again and search for Rigidbody 2D.
* The Rigidbody 2D component adds physics properties to the player, enabling it to react to forces like gravity and be moved by physics-based interactions. By default, Unity applies gravity to objects with a Rigidbody 2D, which will cause the bird to fall unless we apply a force (e.g., when the player taps the screen or presses a key).

  ![image](https://github.com/user-attachments/assets/6f6c96c4-2f8f-4a55-9f91-69897115082f)


The final result will look like this for the player character :

![image](https://github.com/user-attachments/assets/92bbc9ea-395d-4bbd-bde0-eff34b605ddb)

**Tip:**

For the Player GameObject, we use colliders smaller than the actual size of the player sprite. This ensures that the game isn't too strict with collisions, giving the player a little more room to navigate and making the game more fun and forgiving. This small adjustment helps prevent frustrating moments where the player might collide with an obstacle even though they didn’t technically touch it.














