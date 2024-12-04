using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public float gasNeeded;
    public float gasCollected;
    public bool active;
    public string nextLevel;
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
    private void OnCollisionEnter(Collision collision)
    {
        if (active && collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
