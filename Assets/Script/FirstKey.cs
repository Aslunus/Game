using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class FirstKey : MonoBehaviour
{
    public Button But;
    public Button2 But2;
    public Button3 But3;
    public GameObject DorKey;
    public GameObject Key;
    private  bool bo = true;

    private void Start()
    {
          DorKey.GetComponent<MeshRenderer>().enabled = true;
          DorKey.GetComponent<BoxCollider>().enabled = true;
    }

    private void Update()
    {
        Proverka();
    }

    private void Proverka()
    {
        if (But.a && But2.b && But3.c == bo)
        {
            Debug.Log("Ключ открыт!!!");
            DorKey.GetComponent<MeshRenderer>().enabled = false;
            DorKey.GetComponent<BoxCollider>().enabled = false;
            Key.GetComponent<Animator>().enabled = false;
            Key.GetComponent<Animation>().enabled = false;
        }
        else
        if (But.a && But2.b && But3.c != bo)
        {
            Debug.Log("Ключ закрыт!!!");
            DorKey.GetComponent<MeshRenderer>().enabled = true;
            DorKey.GetComponent<BoxCollider>().enabled = true;
            Key.GetComponent<Animator>().enabled = true;
            Key.GetComponent<Animation>().enabled = true;
        }
    }
}
