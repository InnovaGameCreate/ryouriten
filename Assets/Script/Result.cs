using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int number = ScoreScript.Score; // ���ϐ����Ăяo���������̃X�N���v�g�̃N���X���A�ϐ����G
    [SerializeField] private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text ="���v�@" + number;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
