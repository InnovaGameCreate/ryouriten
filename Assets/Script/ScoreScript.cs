using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  static int Score;  //���_�̕ϐ�
    public Text ScoreText;  //���_�̕����̕ϐ�

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Kill:" + Score.ToString();    //ScoreText�̕�����Score:Score�̒l�ɂ���

        if (Input.GetKey(KeyCode.Space))    //����Space�L�[�������ꂽ��
        {
            RequestIngredients requestingredients;
            GameObject obj = GameObject.Find("Guest1");
            requestingredients = obj.GetComponent<RequestIngredients>();
            Score = requestingredients.killcount1;
        }
    }
}
