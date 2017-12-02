# Unity Stealth Game

A simple stealth based game where the aim is to get to the safe area without being spotted by the guards on the level. Each guard has a spotlight, which visually represents their Vision cone. Players can use obstacles and walls placed around the level to sneak past and around guards. 

The guards spotlight color will change if the guard is aware of the player. The spotlight colour change is a visual aid to inform the player to rethink their approach and reposition if need be. 

# Guards 

As mentioned above the spotlight emitting from the guards represents the guards vision cone. If a player enters this area then the game is over. However,  the guards real sight distance is slightly shorter than the perceived spot light particle effect, this is to decrease difficulty as the the light is faded towards the end of the spotlight, and knowing the exact vision cone will be difficult to play around

The red line represents the guards real vision distance. This can be adjusted to increase or decrease difficulty.

![guard_view_distance](https://user-images.githubusercontent.com/31442053/33516441-b6e9e5da-d76a-11e7-944f-1cf8df7ac15c.png)


The player is not seen behind obstacles and the light from the guard also does not display through obstacles. 
![player_not_seen](https://user-images.githubusercontent.com/31442053/33516452-f30ea398-d76a-11e7-97d0-00d80bf525fc.png)


Guards have public variable exposed in the engine which can be increased or decreased depending on the required difficulty. Behaviors such as: 

- Turn Speed
- Move Speed
- Wait Time
- Awareness Timer 

The below screenshot demonstrates the red light when the player has been seen. Circles show guards patrol path. 
![player_seen](https://user-images.githubusercontent.com/31442053/33516464-139e6d1e-d76b-11e7-8d37-95ba3f5f7d3b.png)


Completed level with several guards.
![finished_game](https://user-images.githubusercontent.com/31442053/33516475-2d62ca60-d76b-11e7-8b27-cefd1a9ff3ec.png)


*All assets used are free from the Unity Asset store*

# Download 

Clone and Download this project. Open the "Stealth_Game" Game folder and run the "StealthGame_Build" Unity Application. 

This will open the Unity Game.

**DO NOT MOVE THE EXE FILE OR THE GAME WILL NOT RUN CORRECTLY** 



