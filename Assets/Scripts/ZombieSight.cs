using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSight : MonoBehaviour
{
    public Zombie myZom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        myZom.Check();
    }
}
