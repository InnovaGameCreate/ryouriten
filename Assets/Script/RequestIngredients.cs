using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*客の、①要求を満たしているか
                         ②killできるかの判定*/

public class RequestIngredients : MonoBehaviour
{
    [SerializeField] private float Lcount1 = 1;
    [SerializeField] private float Mcount1 = 0;
    [SerializeField] private float Ccount1 = 0;
    [SerializeField] private float Tcount1 = 1;

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

    public int killcount1 = 0;
    public int abc = 0;    //毒か客の要望を満たしていないかをUIで知らせるための変数
    public int trriger = 0; //Killできたら次のオーダーにするための変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

        // Update is called once per frame
        void Update()
    {
        Random random;  //呼ぶスクリプトにrandpmというあだ名をつける
        GameObject a = GameObject.Find("Random");   //Randomというオブジェクトを探す
        random = a.GetComponent<Random>();  //ついているスクリプトを取得
        num = random.rnd;

        if (num == 1) 
        {
            if (Input.GetKeyDown(KeyCode.Space))    //もしスペースキーが押されたら
                Discrimination1();
        }
        else if (num == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Discrimination2();
        }
        else if (num == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Discrimination3();
        }
        else if (num == 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Discrimination4();
        }
        else if (num == 5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                Discrimination5();
        }
    }

    void Discrimination1()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              5.0f,
              Vector3.forward);

        Debug.Log($"検出されたコライダーの数：{hits.Length}");

        foreach (var hit in hits)
        {
            Debug.Log($"検出されたオブジェクト:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce：{lcnt}");
        Debug.Log($"Meets：{mcnt}");
        Debug.Log($"Cheese：{ccnt}");
        Debug.Log($"Tomato：{tcnt}");

        if (Lcount1 == lcnt && Mcount1 == mcnt && Ccount1 == ccnt && Tcount1 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");
            foreach (var hit in hits)
            {
                if (hit.collider.name == "Lettuce.P") //この人の弱点毒であったら
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("お客様の要求を満たしていません");
            abc = 2;
        }

        lcnt = 0;   //lcntの初期化
        mcnt = 0;   //mcntの初期化
        ccnt = 0;   //ccntの初期化
        tcnt = 0;   //tcntの初期化
        if(num != 1)
        trriger = 0;
    }
    void Discrimination2()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              7.0f,
              Vector3.right);

        Debug.Log($"検出されたコライダーの数：{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"検出されたオブジェクト:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce：{lcnt}");
        Debug.Log($"Meets：{mcnt}");
        Debug.Log($"Cheese：{ccnt}");
        Debug.Log($"Tomato：{tcnt}");

        if (Lcount2 == lcnt && Mcount2 == mcnt && Ccount2 == ccnt && Tcount2 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Tomato.P") //この人の弱点毒であったら
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("お客様の要求を満たしていません。");
            abc = 2;
        }

        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
    }

    void Discrimination3()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              7.0f,
              Vector3.right);

        Debug.Log($"検出されたコライダーの数：{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"検出されたオブジェクト:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce：{lcnt}");
        Debug.Log($"Meets：{mcnt}");
        Debug.Log($"Cheese：{ccnt}");
        Debug.Log($"Tomato：{tcnt}");

        if (Lcount3 == lcnt && Mcount3 == mcnt && Ccount3 == ccnt && Tcount3 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Meets.P") //この人の弱点毒であったら
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("お客様の要求を満たしていません。");
            abc = 2;
        }

        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
        trriger = 0;
    }

    void Discrimination4()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              7.0f,
              Vector3.right);

        Debug.Log($"検出されたコライダーの数：{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"検出されたオブジェクト:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce：{lcnt}");
        Debug.Log($"Meets：{mcnt}");
        Debug.Log($"Cheese：{ccnt}");
        Debug.Log($"Tomato：{tcnt}");

        if (Lcount4 == lcnt && Mcount4 == mcnt && Ccount4 == ccnt && Tcount4 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Cheese.P") //この人の弱点毒であったら
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("お客様の要求を満たしていません。");
            abc = 2;
        }
        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
        trriger = 0;
    }

    void Discrimination5()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              7.0f,
              Vector3.right);

        Debug.Log($"検出されたコライダーの数：{hits.Length}");

        foreach (var hit in hits)
        {
            //Debug.Log($"検出されたオブジェクト:{hit.collider.name}");

            if (hit.collider.tag == "Lettuce")
                lcnt++;
            else if (hit.collider.tag == "Meets")
                mcnt++;
            else if (hit.collider.tag == "Cheese")
                ccnt++;
            else if (hit.collider.tag == "Tomato")
                tcnt++;

        }

        Debug.Log($"Lettuce：{lcnt}");
        Debug.Log($"Meets：{mcnt}");
        Debug.Log($"Cheese：{ccnt}");
        Debug.Log($"Tomato：{tcnt}");

        if (Lcount5 == lcnt && Mcount5 == mcnt && Ccount5 == ccnt && Tcount5 == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");

            foreach (var hit in hits)
            {
                if (hit.collider.name == "Buns.P") //この人の弱点毒であったら
                {
                    killcount1 += 1;
                    Debug.Log($"Kill:{killcount1}");
                    abc = 1;
                    trriger = 1;
                }
                else if (abc != 1)
                    abc = 3;
            }
        }
        else
        {
            Debug.Log("お客様の要求を満たしていません。");
            abc = 2;
        }
        lcnt = 0;
        mcnt = 0;
        ccnt = 0;
        tcnt = 0;
        trriger = 0;
    }
}
