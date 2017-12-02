# Unity Stealth Game

A simple stealth based game where the aim is to get to the safe area without being spotted by the guards on the level. Each guard has a spotlight, which visually represents their Vision cone. Players can use obstacles and walls placed around the level to sneak past and around guards. 

The guards spotlight color will change if the guard is aware of the player. The spotlight colour change is a visual aid to inform the player to rethink their approach and reposition if need be. 

# Guards 

As mentioned above the spotlight emitting from the guards represents the guards vision cone. If a player enters this area then the game is over. However,  the guards real sight distance is slightly shorter than the perceived spot light particle effect, this is to decrease difficulty as the the light is faded towards the end of the spotlight, and knowing the exact vision cone will be difficult to play around

The red line represents the guards real vision distance. This can be adjusted to increase or decrease difficulty.

![Guard_View_Distance](Images\Guard_View_Distance.png)

The player is not seen behind obstacles and the light from the guard also does not display through obstacles. ![Player_Not_Seen](D:\Unity Games\Stealth_Game\Images\Player_Not_Seen.png)

Guards have public variable exposed in the engine which can be increased or decreased depending on the required difficulty. Behaviors such as: 

- Turn Speed
- Move Speed
- Wait Time
- Awareness Timer 

The below screenshot demonstrates the red light when the player has been seen. The lines and circles represent the guards patrol path. 

![Player_Seen](https://gyazo.com/9efdb3f0c86242d1dba7c795b6960d4b)

 Completed level with several guards. ![Finished_Game](D:\Unity Games\Stealth_Game\Images\Finished_Game.png)

*All assets used are free from the Unity Asset store*

# Download 

Clone and Download this project. Open the "Stealth_Game" Game folder and run the "StealthGame_Build" Unity Application. 

This will open the Unity Game.

**DO NOT MOVE THE EXE FILE OR THE GAME WILL NOT RUN CORRECTLY** 



