using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int timeLeft;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ReduceTime",1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + timeLeft;
        if (timeLeft == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void ReduceTime()
    {
        timeLeft -= 1;
    }
}
