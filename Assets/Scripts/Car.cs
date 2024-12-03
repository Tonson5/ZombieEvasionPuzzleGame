using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float gasNeeded;
    public float gasCollected;
    public bool active;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (gasCollected == gasNeeded)
        {
            active = true;
        }
    }
}
