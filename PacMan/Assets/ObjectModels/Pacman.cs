using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour, GameObjectInterface
{
    //****************
    //Private variable initialzations
    //****************
    private int _PACMAN_WIDTH, _PACMAN_HEIGHT;
    private int _X;
    private int _Y;
    private int _lives = 3;
    private bool _isAlive = true;
    private Direction _characterDirection;
    private int _dotsEaten = 0;
    private Speed _speed = Speed.Slow;
    private bool _hasPower = false;
    private bool _isFacingBlock = false;

    //****************
    //Public varible initializations
    //****************
    public int PACMAN_HEIGHT { get => _PACMAN_HEIGHT; }
    public int PACMAN_WIDTH { get => _PACMAN_WIDTH; }
    public int X { get => _X; }
    public int Y { get => _Y; }
    public int lives { get => _lives; }
    public bool isAlive { get => _isAlive; }
    public Direction characterDirection { get => _characterDirection; }
    public Speed speed { get => _speed; }
    public bool hasPower { get => _hasPower; }
    public int dotsEaten { get => _dotsEaten; }
    public bool isFacingBlock { get => _isFacingBlock; }


    //****************
    //Initializations
    //****************
    public Pacman(int height, int width, int x, int y, Direction d)
    {
        setWidthHeight(width, height);
        setX(x);
        setY(y);
        setDirection(d);
    }


    //****************
    //GameObjectInterface Required Method Declarations
    //****************
    public void setDirection(Direction newDirection)
    {
        _characterDirection = newDirection;
        //TODO: Change the image of pacman to match the direction
    }
    public void move(int X, int Y)
    {
        //Determine the direction and Call Set direction 
        _X = X;
        _Y = Y;
    }
    public void setX(int X)
    {
        _X = X;
    }
    public void setY(int Y)
    {
        _Y = Y;
    }
    public void respawn()
    {
        //Respawn object
    }
    public void setSpeed(Speed newSpeed) { _speed = newSpeed; }


    //****************
    //Custom Object Methods
    //****************


    /// <summary>
    /// Sets the height and width of the object
    /// <param name="width"> The width of the obejct </param>
    /// <param name="height"> The height of the obejct </param>
    /// </summary>
    private void setWidthHeight(int width, int height)
    {
        this._PACMAN_HEIGHT = height;
        this._PACMAN_WIDTH = width;
    }

    /// <summary>
    /// Makes the object invincible, so that it cannot be killed,
    /// also increases the speed of the object
    /// </summary>
    void givePower()
    {
        //Make sure pacman cannot be killed
        _hasPower = true;
        //Increase speed
        setSpeed(Speed.Medium);
        //Start a timer for X seconds 
        //Once finished call removePower()
    }

    /// <summary>
    /// Returns the object back to normal
    /// </summary>
    void removePower()
    {
        _hasPower = false;
        setSpeed(Speed.Slow);
    }

    /// <summary>
    /// Increments 'dotsEaten' 
    /// </summary>
    void increaseDotsEaten() { _dotsEaten += 1; }



    /// <summary>
    /// Performs actions once the object dies
    /// </summary>
    void didDie()
    {
        _lives -= 1;
        //Game Object needs to call end game not pacman 
    }

    // Start is called before the first frame update
    void Start()
    {
        //Set the position of pacman 

    }

    // Update is called once per frame
    void Update()
    {

    }
}
