# Snowball Fight game

It's a 2D game created with Unity 2018.3.7f1 using the tutorials from [GamePlusJames Youtube channel](https://www.youtube.com/user/gamesplusjames/featured).

## [Video 1](https://www.youtube.com/watch?v=p23J5-1OTAM)

In this video you will learn how to split sprites and how to add box colliders into your platform objects and how to change size of it.

## [Video 2](https://www.youtube.com/watch?v=uqofxjeY5fg)

Things you will learn in this video:

1. Add controls to your player

1. Layers, what it is, how to apply them as a Type of Object in the scene and how to add it as dependency in some player action

1. Gravity in RigidBody2D and use it as jump high delimiter

    I've found a bug when the player collides to a platform he get stuck. To solve this go to Assets -> Create -> Physical Material 2D and add 0 to friction, then add this material to the platforms.

1. An easy way to script controls to your player.

## [Video 3](https://www.youtube.com/watch?v=IBE29kz4GsQ)

ANIMATIONS ARE REAL

You'll learn how to add animations to your game and how to turn your player to another size, if you look to way it is then will see the character does not face the other side when press to run left.

Animation involves others sprites "movements" then adding how much time it will last until it's over and adding parameters to set when it will be running or jumping.

## [Video 4](https://www.youtube.com/watch?v=lwzUiOCOqVA)

Now we're throwing snow balls!!

This video is important!!

You'll learn:

1. How to create a Particle System and modulate it.

    - Change number of particles
    - Rotation
    - Add gravity
    - Lifetime
    - Add effect to make it disappear
    - Attach as a trigger into the snow ball
    - How to create a trigger to instantiate Particle System (Snow Ball object)
    - How to create a script to destroy the GameObject of the Particle System after the effect triggered.

1. Add a circle collider into the snow ball and make an event to instantiate the Particle System Effect and destroy the snow ball.

1. How to throw the snow ball from the player and the script that has on it.
