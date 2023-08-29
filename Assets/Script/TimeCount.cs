using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private Text TimeText;
    float seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if(seconds <= 10)
            TimeText.text = "Žc‚èŽžŠÔF" + (180f - seconds);
        else if (seconds >= 10)
            TimeText.text = "TIME UP!!";

        if (seconds >= 13)
            SceneManager.LoadScene("End");
        
    }
}
