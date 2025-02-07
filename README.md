# Project03-JuicyBreakout

# Project Name
Neon Matrix Smash

# Description
This is a brick-breaker-style game that has 3 levels.

## Implementation
I added a background to every scene. 

I changed the assets for the ball, paddle, and the blocks.

I added an effect for when a block gets hit and randomness for when a block is loaded in.

I added a particle effect for when the paddle is hit by the ball.

I added a screen shake for when the paddle or a block is hit.

I added background music and sound effects for when the paddle and blocks get hit and when a life is lost. The background music is loaded in the main menu and stays throughout the entire game without restarting when you load a new scene. I also made the music a singleton, so that when you go back to the main menu, you do not have the music playing a second time.

I added a pause menu when escape is pressed. You can resume the game, go back to the main menu, or quit the game. Since we are not going to be exporting the game, I just made the quit button exit play mode.

I made it so that you go to the next level or a win screen when you beat levels one, two, or three.

I made each level have a different number of blocks for an added challenge in each level.

I created and added a win screen for if you beat level 3.

I added a way to reset the ball (puts it back into the starting location where you have to press space to launch the ball) when you press R. I added this because I noticed that the ball gets stuck going straight up and down or side to side often.


## References
(Ball and Paddle Assets)[https://www.kenney.nl/assets/puzzle-pack]

(Paddle Particles)[https://assetstore.unity.com/packages/2d/textures-materials/neon-shapes-61454]

(Block, Mouse, and Pause Menu Button Assets)[https://www.kenney.nl/assets/ui-pack-space-expansion]

(Background Assets)[https://assetstore.unity.com/packages/2d/textures-materials/building/cyberpunk-street-environment-86766]

Music and sound effects (Made by Me)

## Future Development
None

## Created by
Eli Cohen
