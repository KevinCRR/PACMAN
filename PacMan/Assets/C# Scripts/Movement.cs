// Credit: https://www.youtube.com/watch?v=5toQfaCDmUs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float pacmanSpeed = 4.0f;

    private Vector2 pacmanDirection = Vector2.zero;

    //private Node currentNode;

    // Start is called before the first frame update
    void Start()
    {

        //Node node = GetNodeAtPosition(transform.localPosition);
        //if (node != null)
        //{
        //    currentNode = node;
        //    Debug.Log(currentNode);
        //}

        transform.localPosition = new Vector3(13, -22.5f, 1);


    }

    // Update is called once per frame
    void Update()
    {

        CheckInput();

        UpdateOrientation();
        ///Debug.Log(transform.position.x);

        if (transform.position.x >= 27f)
        {
            transform.localPosition = new Vector3(-0.4f, transform.position.y, -0.0f);
        }
        else if(transform.position.x <= -0.5f)
        {
            transform.localPosition = new Vector3(26.5f, transform.position.y, -0.0f);
        }

        if (transform.position.y >= 1f)
        {
            transform.localPosition = new Vector3(transform.position.x, -30f,  0.0f);
        }
        else if (transform.position.y <= -31f)
        {
            transform.localPosition = new Vector3(transform.position.x, 1f,  0.0f);
        }
        Move();


    }

    // Check the current player's input
    void CheckInput() { 
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pacmanDirection = Vector2.left;
            //MoveToNode(pacmanDirection);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pacmanDirection = Vector2.right;
            //MoveToNode(pacmanDirection);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            pacmanDirection = Vector2.down;
            //MoveToNode(pacmanDirection);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            pacmanDirection = Vector2.up;
            //MoveToNode(pacmanDirection);
        }
    }

    //
    void Move()
    {
        transform.localPosition += (Vector3)(pacmanDirection * pacmanSpeed) * Time.deltaTime;
    }


    //void MoveToNode (Vector2 d)
    //{
    //    //Node moveToNode = CanMove(d);

    //    if (moveToNode != null)
    //    {
    //        transform.localPosition = moveToNode.transform.position;
    //        currentNode = moveToNode;
    //    }
    //}

    void UpdateOrientation()
    {
        if (pacmanDirection == Vector2.up)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (pacmanDirection == Vector2.down)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 270);
        }
        else if (pacmanDirection == Vector2.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (pacmanDirection == Vector2.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    //Node CanMove (Vector2 d)
    //{
    //    Node moveToNode = null;
        
    //    for (int i = 0; i < currentNode.neighbours.Length; i++)
    //    {
    //        if (currentNode.validDirections [i] == d)
    //        {
    //            moveToNode = currentNode.neighbours[i];
    //            break;
    //        }
    //    }
    //    return moveToNode;
    //}

    //Node GetNodeAtPosition (Vector2 pos)
    //{
    //    GameObject tile = GameObject.Find("Game").GetComponent<GameBoard>().board[(int)pos.x, (int)pos.y];

    //    if (tile != null)
    //    {
    //        return tile.GetComponent<Node>();
    //    }
    //    return null;
    //}
}
