# amWRit

# Dread50

As part of learning through Harvard's CS50G "Introduction to Game Development" course, recreating the Dreadhalls game using Unity and Blender.
Updates were made on the original source code provided by CS50, based on assignment specifications.

__Assignment 9: “Dreadhalls, The Tumble Update”__

__Unity 2020.2.0b7__
__Blender 2.90.1__

# Assignment Updates

__Spawn holes__
- Randomly spawn holes in the floor of the maze that the player can fall through.

__Game over on falling through holes__
- When the player falls through any holes, the game is over and transitions to a “Game Over” scene. Also destroy Play scene's looping music.
- On hitting Enter key in the Game Over scene, it transitions to Title scene.

__Maze number__
- Keeps track of which maze they’re in, incrementing each time they progress to the next maze. Show the maze number during Play scene.

_Game over sound source: https://www.storyblocks.com/_ 