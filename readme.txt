I have an odd number (student number 100573404; 1 + 0 - 4 = -3), so I've been recreating the sewer scene.

STEP 1: MOVING OBJECTS
The player's movement is done simply by reading the player's inputs. If W/A/S/D is pressed,
the player's rigidbody is moved in the associated direction (up/left/down/right). The specific code I've used here is kind of awkward; since the movement isn't super important, I elected to cobble together some code quickly rather than spending time on a more elegant solution.

The moving light is slightly more complex; it has left and right boundaries, a movement speed,
and a variable to track its current X position. Since this light is moving to the left, I've
only coded the relevant check: if its X position exceeds the left boundary, the light will
instantly move to the right boundary. This gives the impression of the screen scrolling past multiple light sources, when in reality there is only one light moving across the screen over and over. By using only one light, we can minimize the performance cost without sacrificing immersion.



Unfortunately, I do not remember the exact specifics of how to implement the shaders for the other parts of this assignment in code. I do, however, recall the general theory behind how they work, so I have explained them to the best of my ability in the paragraphs below.



STEP 2: BRICK WALL SHADER
To create the effect of a brick wall with depth, I've decided that utilizing normal mapping would make the most sense. Normal mapping works by calculating normals per fragment rather than per vertex, causing the normal for each fragment to point in different directions. Because lighting uses the normals for its calculations, this causes light to bounce off of each fragment in a different direction--thus making an otherwise flat surface appear to have depth and a more complex shape to it.


STEP 3: WATER SHADER
From what I remember, the water shaders we covered in class work by using displacement to adjust the vertices of a surface, making it appear to be moving like waves. To create the wave effect, the shader uses a sine wave (or similar moving function) to determine how the vertices should move on any given frame.

To implement a toggle between the water being murky and clear, I'd first need to set up two materials: one that is transparent, and another that is opaque. Then, I would write a script for the water object that stores those two materials, and switches which one is applied to the object if it detects a given button being pressed.


STEP 4: BLOOM
To acheive a bloom effect, we must first determine the brightness level of each pixel on screen, in order to sort out which pixels are bright enough to contribute to the bloom effect. Then, while calculating the colour of each pixel, we create a copy of all pixels that meet the brightness threshold, apply a blurring effect of choice, and then add the bloom effect to the final render by adding the colour of each blurred pixel to the colours of that pixels on the original image.

Because the bloom effect is universal rather than affecting a singular object, the bloom shader must be applied by a script which is placed on the camera.
