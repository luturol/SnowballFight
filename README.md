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

## [Video 5](https://www.youtube.com/watch?v=CFFcS-yoQac)

This video you will add another player to the game!!!

After all you've done, it's kind of easy. Just copy all animations and player material, then change the animations in the Animators tab to the animations of player 2. Finally, you add the sprites to the animations.
Set new controls. Done. Go have fun.

## [Video 6](https://www.youtube.com/watch?v=xfvsUhNQLtA)

Adding some UI!

Things you will learn:

1. How to set a canvas

1. Adding Text and Image to it

1. Adding Scripts to make interactions if the colliders you have in the players objects.

    Remember to add the tags on the player!! You will manage a script of the game, so it can control HP loss from players and the UI of the HP.

    GameManager will controll UI Effects and the SnowBall will call GamaManager to set which will be hurt.

    GameManager => Controls UI

    SnowBall => SnowBall Effects and Who gets shot to lost HP. Finds who got the shot from tag name attached to it and call GameManager to register HP loss.

    PlayerController => Player Actions

1. Adding a game over scene and how to make UI effects disappear when the player get hit by a snow ball.

## [Video 7](https://www.youtube.com/watch?v=QSTKy9cHmcI)

Adding Sound!

Be careful with Play on Awake and Loop checks so it does not make you crazy and make odd sounds.

You can add sound in the script or in the animation.

Just send a Play event on the script or add in the animation effect.

## [Video 8](https://www.youtube.com/watch?v=uAa_MfnM6_I)

Adding Menu!

Things you'll learn:

1. How to create another Scene and how to call one from another one.

1. How to create buttons and add OnClick event

1. Scripting button and Scene change

## [Video 9](https://www.youtube.com/watch?v=VZTcPkH84hg&t=173s)

Add another level!!!

Thing you will learn:

1. Scene transition from menu to another level and vice versa.

1. Particle System to make the effect of snow.

1. Finally and most important: **HOW TO BUILD** the project and get .exe file or WebGL files.
