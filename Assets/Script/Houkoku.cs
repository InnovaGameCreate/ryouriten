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
        GameObject obj = GameObject.Find("Guest1"); //Guest1�Ƃ����I�u�W�F�N�g��T��
        requestingredients = obj.GetComponent<RequestIngredients>();    //�I�u�W�F�N�g�uGuest1�v���̃X�N���v�g���擾
        ABC = requestingredients.abc;   //�ϐ�ABC�ɏ�Ŏ擾�����X�N���v�g���̕ϐ���������

        if (ABC == 0)
            DentatuText.text = "�q�̊O���ŋ��ȓł����������炢���̂ɂȂ�";
        else if (ABC == 1)
        {
            DentatuText.text = "�d���߂����I";    
        }
        else if (ABC == 2)
        {
            DentatuText.text = "�I�[�_�[�ʂ�̐H�ނ��g��Ȃ�����";
            //ABC = 0;
        }
        else if (ABC == 3)
        {
            DentatuText.text = "�ǂ����A���̓ł͌����Ȃ��炵��";
            //ABC = 0;
        }
    }
}
