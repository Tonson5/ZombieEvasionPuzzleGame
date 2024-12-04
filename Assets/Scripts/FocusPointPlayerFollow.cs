using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPointPlayerFollow : MonoBehaviour
{
    public GameObject player;
    public PlayerMovment playerManager;
    public float moveSpeed;
    public float range;
    public GameObject indicator;
    public GameObject indicator2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.beingControlled)
        {
            transform.position = player.transform.position;
            indicator.SetActive(false);
            indicator2.SetActive(false);
        }
        else
        {
            indicator.SetActive(true);
            indicator2.SetActive(true);
            if ((transform.position - player.transform.position).magnitude < range)
            {
                transform.Translate((Vector3.forward * Input.GetAxisRaw("Vertical") + Vector3.right * Input.GetAxisRaw("Horizontal")).normalized * Time.deltaTime * moveSpeed);
            }
            else
            {
                transform.Translate((player.transform.position - transform.position).normalized * Time.deltaTime * moveSpeed);
            }
        }

    }
}
