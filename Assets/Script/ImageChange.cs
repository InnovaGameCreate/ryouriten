using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Sprite newSprite1;
    public Sprite newSprite2;
    public Sprite newSprite3;
    public Sprite newSprite4;
    public Sprite newSprite5;

    private Image image;

    int num;
    // Start is called before the first frame update
    void Start()
    {
        // SpriteRenderer�R���|�[�l���g���擾���܂�
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        Random random;  //�ĂԃX�N���v�g��randpm�Ƃ���������������
        GameObject a = GameObject.Find("Random");   //Random�Ƃ����I�u�W�F�N�g��T��
        random = a.GetComponent<Random>();  //���Ă���X�N���v�g���擾
        num = random.rnd;

        if (num == 1)
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite1;
        }

        if (num == 2)
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite2;
        }

        if (num == 3)
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite3;
        }

        if (num == 4)
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite4;
        }

        if (num == 5)
        {
            // �摜��؂�ւ��܂�
            image.sprite = newSprite5;
        }
    }
}
