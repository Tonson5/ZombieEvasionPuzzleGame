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
    public float speed;
    public Vector3 startPoint; 
    public Vector3 endPoint; 
    public float rayLength = 100f;
    void Start()
    {
        player = GameObject.Find("Player");
        InvokeRepeating("NewWanderPosition",0, Random.Range(1, 5));
        speed = Random.Range(2, 4);
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.speed = speed;
        if (chasing)
        {
            wandering = false;
            myAgent.SetDestination(player.transform.position);
        }
        
    }
    public void Check()
    {
        startPoint = transform.position;
        Vector3 direction = (endPoint - startPoint).normalized;
        RaycastHit hit;
        if (Physics.Raycast(startPoint, direction, out hit, rayLength))
        {
            if (hit.collider.CompareTag("Player"))
            {
                chasing = true;
            }
        } 
        
        Debug.DrawRay(startPoint, direction * rayLength, Color.red);
        
    }
    public void StopChase()
    {
        chasing = false;
        wandering = true;
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
