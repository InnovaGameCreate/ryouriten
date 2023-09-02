using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*�q�́A�@�v���𖞂����Ă��邩
                         �Akill�ł��邩�̔���*/

public class RequestIngredients : MonoBehaviour
{
    private int trriger1 = 0;
    public int trriger2 = 0; //Kill�ł����玟�̃I�[�_�[�ɂ��邽�߂̕ϐ�

    private float Lcount1 = 1;
    private float Mcount1 = 0;
    private float Ccount1 = 0;
    private float Tcount1 = 1;

    private float Lcount2 = 0;
    private float Mcount2 = 1;
    private float Ccount2 = 1;
    private float Tcount2 = 1;

    private float Lcount3 = 1;
    private float Mcount3 = 1;
    private float Ccount3 = 0;
    private float Tcount3 = 1;

    private float Lcount4 = 1;
    private float Mcount4 = 1;
    private float Ccount4 = 1;
    private float Tcount4 = 1;

    private float Lcount5 = 1;
    private float Mcount5 = 1;
    private float Ccount5 = 1;
    private float Tcount5 = 0;

    int lcnt = 0;
    int mcnt = 0;
    int ccnt = 0;
    int tcnt = 0;
    int num;
    float num2;

    public int killcount1 = 0;
    public int abc = 0;    //�ł��q�̗v�]�𖞂����Ă��Ȃ�����UI�Œm�点�邽�߂̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

        // Update is called once per frame
        void Update()
    {
        Random random;  //�ĂԃX�N���v�g��random�Ƃ���������������
        GameObject a = GameObject.Find("Random");   //Random�Ƃ����I�u�W�F�N�g��T��
        random = a.GetComponent<Random>();  //���Ă���X�N���v�g���擾
        num = random.rnd;

        Data data;  //�ĂԃX�N���v�g��data�Ƃ���������������
        GameObject b = GameObject.Find("Data"); //Data�Ƃ����I�u�W�F�N�g��T��
        data = b.GetComponent<Data>();  // ���Ă���X�N���v�g���擾
        num2 = data.vanish;

        if (num == 1)
        {
            if (num2 == 1)
            {  //�����X�y�[�X�L�[�������ꂽ��
                Discrimination1();
                data.vanish = 0;
            }

        }
        else if (num == 2)
        {
            if (num2 == 1)
            {
                Discrimination2();
                data.vanish = 0;
            }
        }
        else if (num == 3)
        {
            if (num2 == 1)
            {
                Discrimination3();
                data.vanish = 0;
            }
        }
        else if (num == 4)
        {
            if (num2 == 1)
            {
                Discrimination4();
                data.vanish = 0;
            }
        }
        else if (num == 5)
        {
            if (num2 == 1)
            {
                Discrimination5();
                data.vanish = 0;
            }
        }

        if (trriger1 == 1)
        {
            trriger2 = 1;
            trriger1 = 0;
        }
        else if (trriger1 == 0)
            trriger2 = 0;
    }

    void Discrimination1()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position,Vector3.up);

        Debug.Log($"���o���ꂽ�R���C�_�[�̐��F{hits.Length}");

        foreach (var hit in hits)
        {
            Debug.Log($"���o���ꂽ�I�u�W�F�N�g:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce�F{lcnt}");
        Debug.Log($"Meets�F{mcnt}");
        Debug.Log($"Cheese�F{ccnt}");
        Debug.Log($"Tomato�F{tcnt}");

        if (Lcount1 == lcnt && Mcount1 == mcnt && Ccount1 == ccnt && Tcount1 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");
            foreach (var hit in hits)
            {
                if (hit.collider.name == "Lettuce.P") //���̐l�̎�_�łł�������
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger1 = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("���q�l�̗v���𖞂����Ă��܂���");
            abc = 2;
        }

        lcnt = 0;   //lcnt�̏�����
        mcnt = 0;   //mcnt�̏�����
        ccnt = 0;   //ccnt�̏�����
        tcnt = 0;   //tcnt�̏�����
    }
    void Discrimination2()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.up);


        Debug.Log($"���o���ꂽ�R���C�_�[�̐��F{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"���o���ꂽ�I�u�W�F�N�g:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce�F{lcnt}");
        Debug.Log($"Meets�F{mcnt}");
        Debug.Log($"Cheese�F{ccnt}");
        Debug.Log($"Tomato�F{tcnt}");

        if (Lcount2 == lcnt && Mcount2 == mcnt && Ccount2 == ccnt && Tcount2 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Tomato.P") //���̐l�̎�_�łł�������
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger1 = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("���q�l�̗v���𖞂����Ă��܂���B");
            abc = 2;
        }

        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
    }

    void Discrimination3()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.up);


        Debug.Log($"���o���ꂽ�R���C�_�[�̐��F{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"���o���ꂽ�I�u�W�F�N�g:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce�F{lcnt}");
        Debug.Log($"Meets�F{mcnt}");
        Debug.Log($"Cheese�F{ccnt}");
        Debug.Log($"Tomato�F{tcnt}");

        if (Lcount3 == lcnt && Mcount3 == mcnt && Ccount3 == ccnt && Tcount3 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Meets.P") //���̐l�̎�_�łł�������
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger1 = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("���q�l�̗v���𖞂����Ă��܂���B");
            abc = 2;
        }

        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
    }

    void Discrimination4()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.up);


        Debug.Log($"���o���ꂽ�R���C�_�[�̐��F{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"���o���ꂽ�I�u�W�F�N�g:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce�F{lcnt}");
        Debug.Log($"Meets�F{mcnt}");
        Debug.Log($"Cheese�F{ccnt}");
        Debug.Log($"Tomato�F{tcnt}");

        if (Lcount4 == lcnt && Mcount4 == mcnt && Ccount4 == ccnt && Tcount4 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Cheese.P") //���̐l�̎�_�łł�������
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger1 = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("���q�l�̗v���𖞂����Ă��܂���B");
            abc = 2;
        }
        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
    }

    void Discrimination5()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.up);


        Debug.Log($"���o���ꂽ�R���C�_�[�̐��F{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"���o���ꂽ�I�u�W�F�N�g:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce�F{lcnt}");
        Debug.Log($"Meets�F{mcnt}");
        Debug.Log($"Cheese�F{ccnt}");
        Debug.Log($"Tomato�F{tcnt}");

        if (Lcount5 == lcnt && Mcount5 == mcnt && Ccount5 == ccnt && Tcount5 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Buns.P") //���̐l�̎�_�łł�������
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger1 = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("���q�l�̗v���𖞂����Ă��܂���B");
            abc = 2;
        }
        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
    }
}
