using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Range(0, 1)]
    public float TimeOfDay;
    public float DayDuration = 30f;

    public Light Sun;

    void Start()
    {

    }


    void Update()
    {
        TimeOfDay += Time.deltaTime / DayDuration;
        if (TimeOfDay >= 1) TimeOfDay -= 1;

        Sun.transform.localRotation = Quaternion.Euler(TimeOfDay * 360f, 180, 0);

    }
}
