using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dots : MonoBehaviour
{
    //****************
    //Private variable declarations
    //****************
    private int _DOT_WIDTH;
    private int _DOT_HEIGHT;
    private int _X;
    private int _Y;
    private bool _isSpecial;
    private bool _isAvailable;

    //****************
    //Public accessors
    //****************
    public int DOT_WIDTH { get => _DOT_WIDTH; }
    public int DOT_HEIGHT { get => _DOT_HEIGHT; }
    public int X { get => _X; }
    public int Y { get => _Y; }
    public bool isSpecial { get => _isSpecial; }
    public bool isAvailable { get => _isAvailable; }

    //****************
    //Initializer
    //****************

    /// <summary>
    /// Initialize the dot object
    /// </summary>
    /// <param name="height">"The height of the dot."</param>
    /// <param name="width">"The width of the dot."</param>
    /// <param name="X">"The X position of the dot."</param>
    /// <param name="Y">"The Y position of the dot."</param>
    /// <param name="special">"If the dot is special."</param>
    public Dots(int height, int width, int X, int Y, bool special)
    {
        setPosition(X, Y);
        setHeightWidth(height, width);
        this._isSpecial = special;
    }
    /// <summary>
    /// Sets the width and height of th dot/food
    /// </summary>
    /// <param name="height">"The Width of the object."</param>
    /// <param name="width">"The height of the object."</param>
    private void setHeightWidth(int height, int width)
    {
        _DOT_HEIGHT = height;
        _DOT_WIDTH = width;
    }

    private void setPosition(int X, int Y)
    {
        _X = X;
        _Y = Y;
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
