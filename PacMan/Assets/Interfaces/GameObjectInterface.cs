using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameObjectInterface
{
    int X { get; }
    int Y { get; }
    Speed speed { get; }
    bool isAlive { get; }
    Direction characterDirection { get; }
    bool isFacingBlock { get; }

    /// <summary>
    /// Used to set which way the object will be facing
    /// </summary>
    /// <param name="newDirection">"The new direction"</param>
    void setDirection(Direction newDirection);

    /// <summary>
    /// Used to set the X Position of the object
    /// </summary>
    /// <param name="X">"The X position to move to."</param>
    void setX(int X);

    /// <summary>
    /// Used to set the Y Position of the object
    /// </summary>
    /// <param name="Y">"The Y position to move to."</param>
    void setY(int Y);

    /// <summary>
    /// Used to move the object to a specified destination
    /// </summary>
    /// <param name="X">"The X position to move to."</param>
    /// <param name="Y">"The Y position to move to."</param>
    void move(int X, int Y);

    /// <summary>
    /// When the player dies, this should be called
    /// </summary>
    void respawn();

    /// <summary>
    /// Sets the speed of the object
    /// <param name="newSpeed"> The new speed of the object </param>
    /// </summary>
    void setSpeed(Speed newSpeed);
}
