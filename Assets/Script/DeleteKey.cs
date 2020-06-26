using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteKey : MonoBehaviour
{
    public GameObject Cube;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Deleter")
       {
            Debug.Log("Удалил объект");
            ScoreKey.Score += 1;
            Cube.GetComponent<FirstKey>().enabled = false;
            Destroy(gameObject);
        }
    }
    
}
