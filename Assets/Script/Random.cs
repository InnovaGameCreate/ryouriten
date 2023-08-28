using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    float seconds = 0;
    public int rnd = 0;
    int TRRIGER;

    // Start is called before the first frame update
    void Start()
    {
        rnd = UnityEngine.Random.Range(1, 6); //•Ï”rnd‚É‚P`5‚Ü‚Å‚Ì®”‚ğƒ‰ƒ“ƒ_ƒ€‚É‘ã“ü
    }

    // Update is called once per frame
    void Update()
    {
        RequestIngredients requestingredients;
        GameObject obj = GameObject.Find("Guest1"); //Guest1‚Æ‚¢‚¤ƒIƒuƒWƒFƒNƒg‚ğ’T‚·
        requestingredients = obj.GetComponent<RequestIngredients>();
        TRRIGER = requestingredients.trriger;

        seconds += Time.deltaTime;

        if (seconds >= 5 || TRRIGER == 1)
        {
            rnd = UnityEngine.Random.Range(1, 6); //•Ï”rnd‚É‚P`5‚Ü‚Å‚Ì®”‚ğƒ‰ƒ“ƒ_ƒ€‚É‘ã“ü
            seconds = 0;
            //Debug.Log("10•bŒã‚ÉÀs‚³‚ê‚½");
        }

        if (TRRIGER >= 1)
            TRRIGER = 0;
        
    }
}
