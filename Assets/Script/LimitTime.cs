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
        Random random;  //�ĂԃX�N���v�g��randpm�Ƃ���������������
        GameObject b = GameObject.Find("Random");   //Random�Ƃ����I�u�W�F�N�g��T��
        random = b.GetComponent<Random>();  //���Ă���X�N���v�g���擾
        snd = random.seconds;

        LimitText.text = "�I�[�_�[�̕ύX�܂ŁF" + (30.0 + 1.0 - snd);

    }
}
