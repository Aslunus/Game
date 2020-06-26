using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Gravitation")
        {
            Debug.Log("Включил гравитацию");
            
        }

    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Gravitation")
        {
            Debug.Log("Отключил гравитацию");
        }

    }
    
}
