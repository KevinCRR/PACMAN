using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;
public enum LabelType
{
    Lives,
    Pellets
}

public class Labels : MonoBehaviour
{

    // Use this for initialization
    public Text text;
    public LabelType type;

    int currentCount = 0;
    void Start()
    {
        if (type.ToString() == LabelType.Lives.ToString())
        {
            currentCount = 3;
        }

        if (type.ToString() == LabelType.Pellets.ToString())
        {
            currentCount = 0;
        }
    }

    public void updatePellets()
    {
        currentCount = currentCount + 1;
        text.text = "Pellets Eaten: " + currentCount.ToString();
    }

    public void updateLives()
    {
        currentCount = currentCount - 1;
        text.text = "Lives: " + currentCount.ToString();
    }

    public void reset()
    {
        if (type == LabelType.Lives)
        {
            currentCount = 3;
        }

        if (type == LabelType.Pellets)
        {
            currentCount = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
