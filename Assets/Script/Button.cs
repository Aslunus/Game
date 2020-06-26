using UnityEngine;


public class Button : MonoBehaviour
{ 
   // public GameObject Stul;
    //public GameObject But;
    public bool a;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Нажал");
             a = true;
        } 
      
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Chair")
        {
            Debug.Log("Отжал");
            a = false;
        }
    }
    
}
