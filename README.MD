
# Touran Malecki Simulator

This program is a fun racing game with 2D view written in C# 

## Project assumptions and ideas 

My idea for that game was to make a racing game with many obstacles coming out on straight road. Different stages of the game are divided more or less by the music - when there are some slower moments in the game, another stage is about to start. During those slower parts a user can read what obstacles he should expect.

The car can be driven by direction keys - left or right. User can choose four lanes. Space bar is the boost key that is not available from the beginning of the game.

The user's car looks like that:

![Car](/TouranMaleckiSimulator/Car.png)

One of the obstacle is police car, looks like that:

![Police](/TouranMaleckiSimulator/paly.png)

Second obstacle is a cow:

![Police](/TouranMaleckiSimulator/krowa.png)

In the code, classes like *Car.cs*, *Barriers.cs*, *Road.cs* are designed for drawing elements like, in turn user's car, obstacles, road. They also handle their functionality. 

The game should last till the end of the song, but still i have some obstacles left to add. 

## Features

* The game synchronized more or less with the music
* Clear menu where user can start or pause the game
* Instructions appearing on the screen during the game


## Author

pawel1991-1992
