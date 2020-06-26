using UnityEngine;
using Valve.VR.InteractionSystem;

public class RotateHome : MonoBehaviour
{
    public GameObject Home;
    public CircularDrive circularDrive;
    private float ugol = 50;
    private float ugol2 = -50;
    private float ugg = 45;
    public bool ug;
    public float uggg = 0.1f;
    public float ugggg;

    void Start()
    {
      //  ug = true;
    }
    void FixedUpdate()
    {
        
        if (ug == true)
        {
             RotateOnTime();
             RotateVsTime();
        }
       else 
        if(ug == false)
        {
            RotateStop();
        }
    }

    void RotateOnTime()
    {
         if (circularDrive.outAngle == ugol)
         {
             Debug.Log("Крутится против часовой стрелки");
             Home.transform.Rotate(0, 0, uggg);
           
            // if (uggg == ugg)
            // {
               //  ug = false; 
             //}
         }
    }
    void RotateVsTime()
    {
       if (circularDrive.outAngle == ugol2) 
       { 
            Debug.Log("Крутится по часововй стрелке");
            Home.transform.Rotate(0, 0, -uggg);
            
       }
    }
    void RotateStop()
    {
        Debug.Log("Остановить вращение");
        Home.transform.Rotate(0, 0, 0);
        
    }


}
