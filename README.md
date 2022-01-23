# SE06-19.2
A multiplayer first-person shooter game based on Unity3D. 

# Table of Contents
- [Requirements](#requirements)
- [Video Demo](#video-demo)
- [Screenshots](#screenshots)
- [Binary download](#binary-download)
- [Game logic and functionalities](#game-logic-and-functionalities)
- [Use Case](#use-case)
- [Working features](#working-features)
- [Script files](#script-files)
- [Class diagram](#class-diagram)
- [Game Mechanism](#game-mechanism)
- [Hotkeys](#hotkeys)
- [Credits](#credits)
- [Special Thanks](#special-thanks)
- [Play the Game](#play-the-game)
# Requirements
1. Unity 2020.3.19f1 (64-bit)
2. Visual Studio 2019
3. GitHub
4. Photon Engine

# Video Demo
[![FPS demo](Demos/youtube.png)](https://youtu.be/LeXe6MkAfcs "FPS demo")

# Screenshots
![fps1](Demos/1.png)
![fps2](Demos/2.png)
![fps3](Demos/3.png)
![fps4](Demos/4.png)


# Binary download
You can download the latest compiled binary here: https://github.com/nnchaubui/SE06-19.2/releases

# Game logic and functionalities

+ Start Panel
    - Input your name and click **Tutorial** for more infomation about our game.
    - To find the room you want to join, click **Find Room**.
    - To create a room on your own, click **Create Room**.
    - To quit game, click **Quit Game**.
+ Create Room Panel
    - Input your room name.
    - Click **Start Room** to join a room.
+ Find Room Panel
    - Input the room you want to join
    - You will be redirect the room you haved filled in the input panel.
+ Game Interface
    - **Player's HP**, your **Username** is on the top left corner.
    - A **gun (Riffle)** is always shown on the bottom right corner in front of everything you can see.
    - A green **shooting sight** is always in the center of the screen.
    - A **minimap** is always on the top right corner of the screen.
+ Player Movement
    - Walking and Running
    - Jumping
    - Dying
+ Gun Models: There're 4 types of guns which was from **Unity Assets Store**
    - Riffle
    - Sniper
    - Heavy
    - Pistol
+ Networking: This game uses **Photon Unity Networking 2**, which is a good network controller from Unity Assets Store. For the **free version**, it allows upto 20 players to play in real-time.
+ Bullet effects: Bullets hitting materials will cause effects

# Use Case
![Use Case](Demos/User_view.png)
Photon provides peer-to-peer multiplayer as a service. This means that there is no 'master server'; therefore instead of a unique source of truth for what is happening in the game, every client manages networked game objects (NGOs).

Each NGO synchronizes state (position, rotation, animation) and will message session-wise clones via RPC (remote procedure call)

Photon provides its own 'Instantiate' and 'Destroy' methods thereby a client creates/destroys NGOs, such as an avatar representing the player, or a projectile.

# Working features
- Multiplayer

# Script files
+ Damageable.cs
    - Interface for damageable objects
+ Gun.cs
+ GunInfo.cs
+ Item.cs
+ ItemInfo.cs
+ Launcher.cs
    - Start the network.
    - Create the lobby, Join the lobby.
    - Create Room, Join Room.
    - Start the game, Leave the Game.
    - Update Room Listings.
+ Loading.cs
    - Some loading stuffs.
+ Menu.cs
    - Open and Close Menu.
+ MenuManager.cs
    - Manage Menu Buttons.
+ PlayerController.cs
    - Mangage all player movements (moving, jumping, increse speed...)
+ PlayerGroundCheck.cs
    - Check if the player is on the ground or not.
+ PlayerListItem.cs
    - Setup Player's info.
+ PlayerManager.cs
    - Manage, create player controller when spawning into the game.
+ RoomListItem.cs
    - Setup Room's info.
+ RoomManager.cs
    - Manage, create rooms.
+ SinglerShotGun.cs
    - For Guns' behaviours: shooting, bullet impacts...
+ SpawnManager.cs
    - Manage where the Player's will spawn (by random).
+ SpawnPoint.cs
    - Create Spawnpoints.

# Class diagram

![Class diagram](Demos/Class_diagram.png)

# Game Mechanism
Shooting each others until you get bored of our game.
 
# Hotkeys
+ WASD: Player Control
+ E: Increse Player Speed
+ 1,2,3,4... or scroll mousewheel: Change betweens guns
+ Space: Jump
+ ESC: Return the mouse cursor.

# Credits
- Map: https://assetstore.unity.com/packages/3d/environments/industrial/rpg-fps-game-assets-for-pc-mobile-industrial-set-v3-0-101429
- Gun: https://assetstore.unity.com/packages/3d/props/guns/free-fps-weapon-akm-180663
- Photon Engine: https://forum.photonengine.com/
- FPS Tutorials: https://www.youtube.com/watch?v=UK57qdq_lak&list=PLPV2KyIb3jR5PhGqsO7G4PsbEC_Al-kPZ

# Special Thanks
- Many many youtube videos.
- Mr.Freddie Nguyen for helping us to know more about Software Engineering.

# Things to update, need to change
- Player's Animation.
- Maybe more character's outfits.
- Need much more actions, weapons for a better FPS game .

