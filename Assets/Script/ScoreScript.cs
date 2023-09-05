using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  static int Score;  //得点の変数
    public Text ScoreText;  //得点の文字の変数
    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); //ヒエラルキーにあるDataをdataに代入;
        dataCs = data.GetComponent<Data>(); //data(ヒエラルキーにあるData)の中からスクリプトのDataを取得
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Kill:" + Score.ToString();    //ScoreTextの文字をScore:Scoreの値にする

        if (dataCs.erase == 1)    //もし
        {
            RequestIngredients requestingredients;
            GameObject obj = GameObject.Find("Guest1");
            requestingredients = obj.GetComponent<RequestIngredients>();
            Score = requestingredients.killcount1;
        }
    }
}
