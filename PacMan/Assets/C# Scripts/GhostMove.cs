using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    public List<Transform> originalWaypoints = new List<Transform>();

    public bool isFirstLoad = true;
    public Transform startingPosition;
    //Keep track of the current way point
    public string GhostName = "";
    int current_point = 0;
    public float speed = 4.5f;
    // Use this for initialization
    void FixedUpdate()
    {

        if (GhostName.Equals("Blinky") && Time.fixedTime < 4.0)
        {
            return;
        }
        if (isFirstLoad)
        {
            startingPosition = this.transform;
            originalWaypoints = waypoints;
            isFirstLoad = false;
        }
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[current_point].position)
        {
            if (GhostName.Equals("Blinky"))
            {
                print("Current point " + transform.position.ToString());
                print("Next point " + waypoints[current_point].position.ToString());
            }

            Vector2 p = Vector2.MoveTowards(transform.position,
                                            waypoints[current_point].position,
                                            speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(p);
        }
        // Waypoint reached, select next one
        else
        {
            if (GhostName.Equals("Blinky"))
            {
                waypoints.RemoveAt(current_point);

            }
            else
            {
                current_point = (current_point + 1) % waypoints.Count;
            }

            //Configuring the animation 
            Vector2 dir = waypoints[current_point].position - this.transform.position;
            //Setting the direction 
            GetComponent<Animator>().SetFloat("DirX", dir.x);
            GetComponent<Animator>().SetFloat("DirY", dir.y);

        }


    }

    void reset()
    {
        current_point = 0;
        waypoints = originalWaypoints;
        this.transform.position.Set(startingPosition.position.x, startingPosition.position.y, startingPosition.position.z);
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "PacMan")
        {
            Destroy(co.gameObject);
            GameObject.Find("livesLbl").GetComponent<Labels>().updateLives();
        }
    }

}
