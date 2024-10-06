# IMTC 505 Lab 2: Carnival Game

## Interactions Overview

This project is a carnival environment where the player needs to walk over to the Carnival game, and throw the red ball to knock down the red can to win. 

The project demonstrates a number of key VR interactions:

1. **Continuous movement using the left-hand joystick.** You can change camera direction using the right hand joystick. Movement was implemented through a Locomotion system and a Continuous Move Provider referencing actions on the left VR controller.
2. **Trigger colliders and the ability to grab and move game objects (specifically, the game ball).** This was implemented through making the ball an XR Grab Interactible, and adding XR Direct Interactors + Sphere colliders to the left and right controllers. You can use the grip button to grab the ball object.
3. **Physics interactions as you throw the ball to knock down the can.** The ball also resets back to you after every throw, using some collision detection with the ground.
4. **UI Based interaction as knocking the can over triggers the "Winner Winner Chicken Dinner UI text.**


## Theme
The project theme was based around a carnival in your city. I try to create this sense of theme by importing a number of asset packs, as well as creating my own shader for a circus-like red and white pattern. I created my own text image as well for the "Welcome to the Carnival" sign.
