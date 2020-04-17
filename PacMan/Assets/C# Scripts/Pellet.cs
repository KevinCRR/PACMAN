using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D co)
    {
        //If the collision occurs with pacman
        //destroy the object
        if (co.name == "PacMan")
        {
            GameObject.Find("pelletsLbl").GetComponent<Labels>().updatePellets();
            Destroy(gameObject);

        }
    }
}
