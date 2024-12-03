using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    
    public bool wandering;
    public bool chasing;
    public GameObject player;
    public NavMeshAgent myAgent;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("NewWanderPosition",0, Random.Range(1, 5));
    }

    // Update is called once per frame
    void Update()
    {
        if (chasing)
        {
            wandering = false;
            myAgent.SetDestination(player.transform.position);
        }
        
    }
    public void Check()
    {
        chasing = true;
    }
    public void NewWanderPosition()
    {
        if (wandering)
        {
            myAgent.SetDestination(new Vector3(transform.position.x + Random.Range(-5,5), 0, transform.position.z + Random.Range(-5, 5)));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
