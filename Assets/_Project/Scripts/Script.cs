using System;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print(message:"Collision");
    }

    private void OnTriggerEnter(Collider other)
    {
        print( message:"Trigger");
    }
}