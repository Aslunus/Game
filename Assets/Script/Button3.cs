using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public bool c ;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Нажал");
            c = true;
        } 
      
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Отжал");
            c = false;
        }
    }
}
