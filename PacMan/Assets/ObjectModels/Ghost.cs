using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost /*: *//*GhostInterface*/
{
    //****************
    //Private Class varibles 
    //****************
    private int _GHOST_HEIGHT;
    private int _GHOST_WIDTH;
    private int _X;
    private int _Y;
    private bool _isAlive = true;
    private GhostType _ghostType;
    private Direction _characterDirection;
    private Speed _speed = Speed.Slow;
    private bool _isFacingBlock = false;
    //****************
    //Public Class varibles
    //****************
    //public int GHOST_HEIGHT { get => this._GHOST_HEIGHT; }
    //public int GHOST_WIDTH { get => this._GHOST_WIDTH; }
    //public int X { get => this._X; }
    //public int Y { get => this._Y; }
    //public bool isAlive { get => this._isAlive; }
    //public GhostType ghostType { get => this._ghostType; }
    //public Direction characterDirection { get => this._characterDirection; }
    //public Speed speed { get => this._speed; }
    //public bool isFacingBlock { get => this._isFacingBlock; }

    //****************
    //Initializations
    //****************

    /// <summary>
    /// Initialize the dot object
    /// </summary>
    /// <param name="height">"The height of the ghost."</param>
    /// <param name="width">"The width of the ghost."</param>
    /// <param name="X">"The X position of the ghost."</param>
    /// <param name="Y">"The Y position of the ghost."</param>
    /// <param name="d">"The direction the ghost should be facing."</param>
    /// <param name="gType">"The type of ghost."</param>

    public Ghost(int height, int width, int X, int Y, Direction d, GhostType gType)
    {
        this._ghostType = gType;
        setX(X);
        setY(Y);
        setDirection(d);
    }
    //****************
    //Private method declarations
    //****************
    /// <summary>
    /// Sets the height and width of the object
    /// </summary>
    /// <param name="height">"Height of the object"</param>
    /// <param name="width">"Width of the object"</param>
    private void setHeightWidth(int height, int width)
    {
        this._GHOST_HEIGHT = height;
        this._GHOST_WIDTH = width;
    }

    //****************
    //GhostInterface Required Method Declarations
    //****************
    public void setDirection(Direction newDirection)
    {
        _characterDirection = newDirection;
        //TODO: Change the image of pacman to match the direction
    }

    public void setSpeed(Speed newSpeed) { this._speed = newSpeed; }

    public void move(int X, int Y)
    {
        //Determine the direction and Call Set direction 
        this._X = X;
        this._Y = Y;
    }


    public void setX(int X)
    {
        this._X = X;
    }

    public void setY(int Y)
    {
        this._Y = Y;
    }

    public void respawn()
    {
        //Respawn object
    }
    public void MovementPattern()
    {
        //Set a default random movement 
        //Apply specific movement in specific ghosts
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
