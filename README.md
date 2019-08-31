# Snowball Fight game

It's a 2D game created with Unity 2018.3.7f1 using the tutorials from [GamePlusJames Youtube channel](https://www.youtube.com/user/gamesplusjames/featured)

## [Video 1](https://www.youtube.com/watch?v=p23J5-1OTAM)

In this video you will learn how to split sprites and how to add box colliders into your platform objects and how to change size of it.

## [Video 2](https://www.youtube.com/watch?v=uqofxjeY5fg)

Things you will learn in this video:

1. Add controls to your player

1. Layers, what it is, how to apply them as a Type of Object in the scene and how to add it as dependency in some player action

1. Gravity in RigidBody2D and use it as jump high delimiter
 
    I've found a bug when the player collides to a platform he get stuck. To solve this go to Assets -> Create -> Physical Material 2D and add 0 to friction, then add this material to the platforms.

1. An easy way to script controls to your player.
