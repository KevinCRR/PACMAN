//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameBoard : MonoBehaviour {

//    private static int boardWidth = 28;
//    private static int boardHeight = 36;

//    public GameObject[,] board = new GameObject[boardWidth, boardHeight];
//	// Use this for initialization
//	void Start () {
//        Object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));

//        foreach (GameObject o in objects)
//        {
//            Vector2 pos = o.transform.position;

//            if (o.name != "Movement")
//            {
//                board[(int)pos.x, (int)pos.y] = o;
//            }
//            else
//            {
//                Debug.Log("Found Movement at: " + pos);
//            }
//        }
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}
//}
