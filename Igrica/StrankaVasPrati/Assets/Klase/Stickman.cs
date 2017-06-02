using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman {

    float y;
    bool skok = false;
    int score = 0;

    public float Y
    {
        get
        {
            return y;
        }

        set
        {
            y = value;
        }
    }

    public bool Skok
    {
        get
        {
            return skok;
        }

        set
        {
            skok = value;
        }
    }

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }
}
