using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public bool b ;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Нажал");
            b = true;
        } 
      
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Отжал");
            b = false;
        }
    }
}
