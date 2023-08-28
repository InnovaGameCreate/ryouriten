using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    float seconds = 0;
    public int rnd = 0;
    int ABC;

    // Start is called before the first frame update
    void Start()
    {
        rnd = UnityEngine.Random.Range(1, 6); //変数rndに１～5までの整数をランダムに代入
    }

    // Update is called once per frame
    void Update()
    {
        RequestIngredients requestingredients;
        GameObject obj = GameObject.Find("Guest1"); //Guest1というオブジェクトを探す
        requestingredients = obj.GetComponent<RequestIngredients>();
        ABC = requestingredients.abc;

        seconds += Time.deltaTime;

        if (seconds >= 2 || ABC == 1)
        {
            rnd = UnityEngine.Random.Range(1, 6); //変数rndに１～5までの整数をランダムに代入
            seconds = 0;
            //Debug.Log("10秒後に実行された");
            //ABC = 0;
        }
    }
}
