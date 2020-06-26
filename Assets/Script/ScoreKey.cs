using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKey : MonoBehaviour
{
    public static int Score;
    Text T;
    void Start()
    {
        T = GetComponent<Text>();
        Score = 0;
    }
    void Update()
    {
        T.text = "" + Score;
    }
}
