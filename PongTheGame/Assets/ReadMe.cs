using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadMe : MonoBehaviour {

    /*
     * So I left this project pretty barebones on purpose. This should keep you busy for a bit 
     * learning the layout of Unity and get us 90% set up for doing some coding. 
     * 
     * The only thing in the scene I started is an image of the game we are making, so it's a 
     * visual representation of our MVP. The things we need to make this game a 'game' are:
     * 
     * 1. Paddles that move up and down for each player.
     * 2. A ball that bounces off of the upper and lower walls as well as the paddles.
     * 3. A way to score points if the ball passes a player paddle.
     * 4. A winning score.
     * 5. Possibly a menu and a reset button.
     * 
     * Your first task is to create a new scene and save it. The convention
     * is to save this scene as 'Main' since this is the main scene of
     * our game. Once that is done, in our scene folder we should have two scenes,
     * the 'Concept' scene which I've created and the new one that you've created.
     * You can easily switch back and forth between the two as long as changes in 
     * each scene are saved.
     * 
     * Your next task is to learn how to change the settings for our art. With the Ball 
     * image this is straight forward. The image is a 32x32 pixel image, so if we click 
     * the Ball image, in the inpector we get some options. The important one is the 
     * 'Max Size' option. Change this to 32 and click apply. Next the Paddle_Wall_Ball 
     * art needs to be edited and chopped into two images. Again, click the image, and in
     * the inspector we need to change the max size to 32. Now we need to change the 'Sprite Mode' to 
     * 'Multiple', then click 'Sprite Editor'. Here is where we would slice
     * up a sprite map if we were using one. Technically the Paddle_Wall_Ball image is a sprite map. 
     * You can google sprite map to see what they look like if you're curious. Once in the sprite editor, 
     * click the slice button and auto slice the image and click apply. It will cut out the two white
     * images and save them as seperate iamges. If you click the arrow next to the Paddle_Wall_Ball
     * art, you'll see the two images. These will be our paddles, dotted lines and walls, as well as our
     * ball if we decide to create the retro version of pong with the square ball. If not, we will use 
     * the more rounded ball art.
     * 
     * From here, your next challenge is create our GameObjects using this art. Use Google if you need
     * to, but simply dragging and dropping combined with tools in the upper left corner of Unity and/or
     * the Transform information in the inspector to the right of the screen, should get you started.
     * We need two Paddles, one named 'PlayerOne', the other named 'PlayerTwo', a Ball of your 
     * choice (retro or circl) named 'Ball', one dot of the dotted line named 'Dot', and two Walls named 
     * 'TopWall' and 'BottomWall'.
     * 
     * Next, we need to add Collider Components to our objects for obvious reasons. We want a ball to 
     * bounce around, and without colliders that just won't happen. PlayerOne, PlayerTwo, TopWall and 
     * BottomWall all need a Box Collider 2D added to them. Same with the Ball if you decided on the 
     * retro square version. If not, then the Ball needs a Circle Collider 2D. This can be done in the 
     * inspector tab when you select a GameObject. Remember, these things are called 'Components'. It 
     * should be obvious as how to add a component in the Inspector tab.
     * 
     * PlayerOne, PlayerTwo and the Ball also need a RidgidBody2D component. This is done in the same 
     * place you added the colldiers. The RidgidBody2D Body Type for the players should be set to Kinematic 
     * (this means we aren't using Physics to move them basically). The RidgidBody2D Body Type for the 
     * Ball should stay as Dynamic, because it will use Physics to move, however the Mass needs to be 
     * lowered to something like 0.1 and Linear and Angular Drag needs to be 0 along with gravity. 
     * We don't want our ball slowing down or falling straight to the floor. Also under constraints, 
     * let's freeze the Z rotation. We don't want it to spin around. The walls don't need Physics
     * so they don't require a RigidBody Component.
     * 
     * Once you have all of this set up, you can Google how to prefab these GameObjects. It's very 
     * simple to do but I'm too lazy to type it out. One thing that may not be mentioned when you 
     * find out how to prefab is to reset the position of the GameObject that you are turning into a 
     * prefab. It's good practice to have your prefab's position at 0,0,0. This has to do with some basic, 
     * but not so obvious things when it comes to positioning GameObjects later, especially when grouping
     * them under and empty GameObject. We will get into that later. The easiest way to reset the position
     * is to select the item you are going to prefab, and in the inspector tab under Transform, 
     * click the gear icon and select 'Reset Position'. Avoid clicking just 'Reset' unless you intend 
     * to reset all the values of the Transform to 0,0,0. Once you prefab each of these items, you 
     * can delete them from the scene view by right clicking  on them in the Hierarchy tab to the left 
     * and clicking delete. If they are prefabed, the will be safe and sound  in their own place 
     * until we need them.
     * 
     * Next is the fun stuff, so when you're all done, let me know and we can start on some programming.
     */
}