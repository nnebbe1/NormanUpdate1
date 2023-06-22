# Project Documentation

## Stating issues you've coped with:
- the main issue was working with GitHub. There were major merging conflicts we could not find a way around, even when only working on specific scenes/ scripts in parallel. We had to mainly collaborate and update our code outside of GitHub, e.g. sending scripts via google drive or updating the scences of the other Person manually. 
- In the beginning, we had some issues with arbitrary movements of the Player we seemingly didn't have an influence on. It took us quite a while until realizing that our floor had some messed up Capsule colliders when Box-colliders would be the right choice. 
- Another tricky point was getting the player to move toward the camera direction.
- More generally, we found Unity quite tricky to work with. Throughout the project, when running into errors, it was often quite hard to identify the source of the issue. When the issue was due to script errors, debug messages helped to identify the mistakes. However, especially errors due to mistakes in the Unity editor were hard to identify. 

## Hints on how to play + how game should behave:

### Game story/background:

***(This text will be read out to you in the start scene, so the player gets an idea of the game setting/ background of the quest.)***

The decade-long Sriracha War has brought countless losses. It looks like the ketchup and mayo soldiers could claim dominance over the battlefield in the best "side sauce". The Sriracha was forced to flee, untraceable and forever gone. In reminiscence, the people are holding on to the vanishing memory of its sweet and spicy aftertaste, in denial to the reality, that the actual sauce is forever history. But really forever history?

One brave bird soldier simply does not accept this new reality. Determined to bring back sriracha it is willing to face the deadly threats of ketchup and mayo. Making the quest to collect the right ingredients despite all dangers their life's mission. It is up to you to guide and protect this brave bird, to save the people's pleasure of spiciness.

### Generally moving around 
- On its quest to collect the ingredients for the holy Siracha sauce, the player walks along the x- and z- dimensions of the 3D game and can jump along the y-axis. 
- For this, the player always moves in (and faces!) the direction, the third-person camera is set at. The third-person camera's direction can be rotated by moving the mouse on the screen. 
- The player can move via the usual keys (a,s,d,w) or respectively the arrow keys. 
- The player can jump when pressing the "spacebar".
- It can move sideways or backward, as the player doesn't rotate when using a or d. For rotating the player, the mouse has to be used. 
- You can walk on almost all of the terrain (all that is within stone walls), including the clouds.

### Collecting Items
- Items can be picked up via pressing "e" in the area of the Item (Hints are shown throughout the game). 
- The respective black and white picture of the item in the User-interface will then turn colorful.
- The onion can be talked to for a funny onion story.
- The tomato can be collected by walking into the labyrinth. In the labyrinth, the umbrella can also be collected (not an ingredient but useful later on) 
- The mushroom can be collected by jumping on the small clouds underneath the big rain cloud. Careful! the acidic mayo-rain will kill the player if they don't have an umbrella with them. That means the order of collection matters and the Person playing the game has to find that out by trial and error. 
- The yogurt can be collected by managing your way through the ketchup army. Careful! the ketchup bottles are enemies, if you touch them you lose a life.
- the garlic can be picked up right away


### Enemies
- Your enemies are ketchup and mayo, as they don't want the Siracha sauce to have a comeback
- The ketchup bottle landmines make you lose a life when touching them. The ketchup bottles have randomly generated movement, so make sure to dodge them.
- The acidic mayo rain kills you right away. To get the mushroom it is necessary to collect the umbrella first. 

### Gameover/ winning
- the game is won when the player has collected all items and placed them into the pot in the middle of the island 
- the player can place the items into the pot by pressing "e" within its area. (That only works after ALL items have been collected) 
- The game is lost when the player has lost all lives (due to ketchup-landmines/mayo rain) 
- When game over, the game will reset to the start screen / start scene

## Functionalities of the Game

**Player**
- moves in all directions of 3D space (including jumping) 
- Always aligns rotation with camera direction, which is set by the mouse
- player can move within stone walls - if it jumps over stonewalls (e.g. from a cloud) it reappears in the middle of the island

**Animations**
- player transitions between different animations: 
 1. "bouncing" - standard
 2. "flying" - (or more "trying to fly") - when jumping
 3. "dead" - when game over
 4. "spinning" - when game is won

- players eyes transition between different animations
1. "happy" - when all three lives are left
2. "sweating" - when one life is lost
3. "trauma" - when to lives are lost
4. "dead" - when no life is left

**Rain**
- rain is an "effect" particle system over the area of the hill in an ongoing loop. 
- Is the parent to the ripple particle "effect"-objects that appear when rain hits the surface of something and gets destroyed. (little circles on the ground that get bigger and then disappear like when rain hits the ground)

**Collecting Items**
- Items can be collected in the area of it by pressing "e". 
- It then gets destroyed 

**Ketchup Army**
- Group of ketchup game objects having a NavMeshAgent component
- Beneath them is a baked navmesh on which they can move around
- Script that generates random movement within a certain area on the navmesh

**User Interface**
- In the top-left corner is a life counter in the form of red hearts, that turn grey when losing a life. 
- In the top right corner are the Items that need to be collected, which turn colorful after collection.
- There appears text giving hints on how to proceed in the game in the area of certain objects.
- when getting hit by a ketchup landmine there is a red stain on the camera for a short period of time

**Sound effects**
- SoundManager class that is able to play various sounds
- contains Soundsources and Soundclips for the background and for the varius sound snippets
- There are sounds for background, rain, getting damage, jumping, picking up stuff, loosing the game, winning the game, and the introduction talk 

**Scene switching** 
- there are two different scenes
- start screen where you can start the game
- the game scene 



