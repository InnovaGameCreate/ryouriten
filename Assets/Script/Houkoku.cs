using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Houkoku : MonoBehaviour
{
    int ABC;
    public Text DentatuText;
    //public float seconds = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RequestIngredients requestingredients;
        GameObject obj = GameObject.Find("Guest1"); //Guest1というオブジェクトを探す
        requestingredients = obj.GetComponent<RequestIngredients>();    //オブジェクト「Guest1」内のスクリプトを取得
        ABC = requestingredients.abc;   //変数ABCに上で取得したスクリプト内の変数を代入する

        if (ABC == 0)
            DentatuText.text = "客の外見で苦手な毒が分かったらいいのになぁ";
        else if (ABC == 1)
        {
            DentatuText.text = "仕留めたっ！";    
        }
        else if (ABC == 2)
        {
            DentatuText.text = "オーダー通りの食材を使わなくちゃ";
            //ABC = 0;
        }
        else if (ABC == 3)
        {
            DentatuText.text = "どうやら、この毒は効かないらしい";
            //ABC = 0;
        }
    }
}
