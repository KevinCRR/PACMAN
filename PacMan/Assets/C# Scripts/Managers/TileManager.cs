using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
public class TileManager : MonoBehaviour
{

    public class Tile
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool occupied { get; set; }

        public Tile left, right, up, down;

        public Tile(int x_in, int y_in)
        {
            x = x_in; y = y_in;
            occupied = false;
            left = right = up = down = null;
        }
    }
}