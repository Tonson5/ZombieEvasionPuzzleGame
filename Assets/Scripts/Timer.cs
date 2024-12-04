using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int timeLeft;
    public TextMeshProUGUI text;
    public GameObject zombie;
    public GameObject zomSpawn;
    public int maxtime;
    // Start is called before the first frame update
    void Start()
    {
        maxtime = timeLeft;
        InvokeRepeating("ReduceTime",1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + timeLeft;
        if (timeLeft == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(zombie,zomSpawn.transform.position,zomSpawn.transform.rotation);
            }
            timeLeft = maxtime * 2;
            maxtime *= 2;
        }
    }
    public void ReduceTime()
    {
        timeLeft -= 1;
    }
}
