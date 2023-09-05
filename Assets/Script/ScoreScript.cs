using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public  static int Score;  //���_�̕ϐ�
    public Text ScoreText;  //���_�̕����̕ϐ�
    private GameObject data;
    private Data dataCs;

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); //�q�G�����L�[�ɂ���Data��data�ɑ��;
        dataCs = data.GetComponent<Data>(); //data(�q�G�����L�[�ɂ���Data)�̒�����X�N���v�g��Data���擾
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Kill:" + Score.ToString();    //ScoreText�̕�����Score:Score�̒l�ɂ���

        if (dataCs.erase == 1)    //����
        {
            RequestIngredients requestingredients;
            GameObject obj = GameObject.Find("Guest1");
            requestingredients = obj.GetComponent<RequestIngredients>();
            Score = requestingredients.killcount1;
        }
    }
}
