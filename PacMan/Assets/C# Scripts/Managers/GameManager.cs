using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Level = 0;
    public static int lives = 3;

    public enum GameState { Init, Game, Dead, Scores }
    private GameObject PacMan;
    private GameObject Blinky;
    private GameObject Pinky;
    private GameObject Inky;
    private GameObject Clyde;


}

//	// Update is called once per frame

