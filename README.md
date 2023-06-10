# Project Documentation

## Stating issues you've coped with:
- the main issue was working with GitHub while using unity. There were major merging conflicts we could not find a way around, even when only working on specific scenes/ scripts in parallel. We had to mainly collaborate and update our code outside of Unity, e.g. sending scripts via google drive or updating scences of the other Person manually. 
- At the beginning we had some issues with arbitrary movements of the Player we seemingly didn't have influence on. It took us quite a while until realizing that our floor had some messed up Capsule colliders, when Box-colliders would be the right choice. 
- Another tricky point was getting the player to move towards the camera direction. At the end we resolved that issue with a thirdperson Camera.
- More generally, we found Unity quite tricky to work with. Throughout the project, when running into errors, it was often quite hard to identify the source of the issue. When the issue was due to script errors, debug messages helped to identify the mistakes. However, especially errors due to mistakes in the Unity editor where hard to identify. 

## Hints on how to play:

### Game story/background:
**Sriracha-Quest**

***(This text will be read out to you in the start scene, so the player gets an idea of the game setting/ background of the quest.)***

The decade long Sriracha-War has brought countless losses. It looks like the ketchup and mayo soliders could claim dominance over the battlefield in the best "side sauce". The Sriracha was forced to flee, untraceable and forever gone. In reminiscence the people are holding on to the vanishing memory of its sweet and spicy aftertaste, in denial to the reality, that the actual sauce is forever history. But really forever history?

One brave bird solider simply does not accept this new reality. Determined to bring back sriracha it is willing to face the deadly threats of ketchup and mayo. Making the quest to collect the right ingredients despite of all dangers their life's mission. It is up to you to guide and protect this brave bird, to safe the people's pleasure of spiciness.

### Generally moving around 
- On its quest to collect the ingredients for the holy Siracha-sauce, the player walks along the x- and z- dimensions of the 3D game and can jump along the y-axis. 
- For this, the player always moves (and faces!) the direction the thirdperson camer is set at. The third person camera's direction can be rotated via moving the mouse on the screen. 
- The player can move via the usual keys (a,s,d,w) or respectively the arrow-keys. 
- It can move sideways or backwards, as the player doesn't rotate when using a or d. For rotating the player, the mouse has to be used. 

### Collecting Items
- Items can be picked up via pressing "e" in the area of the Item (Hints are shown throughout the game). 
- The respective black and white picture of the item in the User-interface will then turn colorful.
- The Oninon can be collected right away.
- The yoghurt can be collected by walking into the labyrinth. In the labyrinth the umbrella can also be collected (not an ingredient but useful later on) 
- The mushroom can be collected by jumping on the small clouds underneath the big rain-cloud. Careful! the acidic mayo-raing will kill the player if they don't have an umbrella with them. That means the order of collection matters and the Person playing the game has to find that out by trial and error. 
- The garlic can be collected by managing your way through the ketchup-army. Careful! the ketchups work like landmines, if you touch them you loose a life. 

### Enemies
- your enemies are ketchup and mayo, as they don't want the Siracha-sauce to have a come back
- The ketchup-landmines make you loose a life when touching them 
- they randomly move around within a certain area **(NORMAN NEEDS TO ADD EXPLANATION)**
- The acidic mayo rain basically kills you right away. Every rain drop makes you loose a life, so to get the mushroom it is necessary to collect the umbrella. 
- The rain is an "effect"-object that is randomly spawn over the area of the hill in an ongoing loop. 

### Gameover/ winning
- the game is won when the player has collected all items and placed them into the pot in the middle of the island 
- the player can place the items into the pot by pressing "e" within its area. (That only works after ALL items have been collected) 
- The game is lost when the player has lost all lives (due to ketchup-landmines/ mayo-rain) 
- When gameover, the player will spawn at the starting point next to the pot and you can try again

## Functionalities of the Game

**Player**
- moves in all directions of 3D space (including jumping) 
- Always aligns rotation with camera direction, set by mouse

**Animations**
- player transitions between different animations: 
 1. "bouncing" - standard
 2. "flying" - (or more "trying to fly") - when jumping
 3. "dead" - when game over
 4. "spinning" - when game is won

**Rain**
- rain is an "effect"-object that is randomly spawned over the area of the hill in an ongoing loop. 

**Collecting Items**

**Life count**

**Ketchup army**

**UI Manager**

**Sound effects**

**Scene switching** 



