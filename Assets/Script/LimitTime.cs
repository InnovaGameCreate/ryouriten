using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitTime : MonoBehaviour
{
    float snd;
    [SerializeField] private Text LimitText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Random random;  //呼ぶスクリプトにrandpmというあだ名をつける
        GameObject b = GameObject.Find("Random");   //Randomというオブジェクトを探す
        random = b.GetComponent<Random>();  //ついているスクリプトを取得
        snd = random.seconds;

        LimitText.text = "オーダーの変更まで：" + (30.0 + 1.0 - snd);

    }
}
