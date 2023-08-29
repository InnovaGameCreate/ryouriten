using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int number = ScoreScript.Score; // ＝変数を呼び出したい元のスクリプトのクラス名、変数名；
    [SerializeField] private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text ="合計　" + number;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
