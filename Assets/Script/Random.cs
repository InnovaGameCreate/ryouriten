using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    public float seconds = 0;
    public int rnd = 0;
    int TRRIGER;

    // Start is called before the first frame update
    void Start()
    {
        rnd = UnityEngine.Random.Range(1, 6); //�ϐ�rnd�ɂP�`5�܂ł̐����������_���ɑ��
    }

    // Update is called once per frame
    void Update()
    {
        RequestIngredients requestingredients;
        GameObject obj = GameObject.Find("Guest1"); //Guest1�Ƃ����I�u�W�F�N�g��T��
        requestingredients = obj.GetComponent<RequestIngredients>();
        TRRIGER = requestingredients.trriger;

        seconds += Time.deltaTime;

        if (seconds >= 5 || TRRIGER == 1)
        {
            rnd = UnityEngine.Random.Range(1, 6); //�ϐ�rnd�ɂP�`5�܂ł̐����������_���ɑ��
            seconds = 0;
            //Debug.Log("10�b��Ɏ��s���ꂽ");
        }
    }
}
