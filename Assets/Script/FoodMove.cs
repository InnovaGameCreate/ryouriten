using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{

    float dai = 0f;
    private GameObject data;
    private Data dataCs;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); //ヒエラルキーにあるDataをdataに代入;
        dataCs = data.GetComponent<Data>(); //data(ヒエラルキーにあるData)の中からスクリプトのDataを取得
    }

    // Update is called once per frame
    void Update()
    {
        if (dai == 1f)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            if (dataCs.vanish == 1)
            {
                StartCoroutine(DelayCoroutine());
            }
        }
    }


    private IEnumerator DelayCoroutine()
    {
        // 1秒間待つ
        yield return new WaitForSeconds(1);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        this.transform.position = new Vector3(-100f, 0.3f, 5f);

    }


    public void FoodGof()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

    }

    public void FoodChange(float guzai)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (-45f < this.transform.position.x && this.transform.position.x < -20f && -30f < this.transform.position.z && this.transform.position.z < -20f)
        {
            if (dataCs.layer == 1f)
            {
                if (guzai == 0f)
                {
                    this.transform.position = new Vector3(-10f, 0.3f * dataCs.layer, 5f);
                    dataCs.layer++;
                    dai = 1f;
                }
                else
                {
                    rb.useGravity = false;
                    this.transform.position = new Vector3(-100f, 0.3f, 5f);
                }
            }

            else
            {
                if (guzai == 0f)
                {
                    rb.useGravity = false;
                    this.transform.position = new Vector3(-100f, 0.3f, 5f);
                }
                else if (guzai == 2f)
                {
                    this.transform.position = new Vector3(-10f, 0.3f * dataCs.layer, 5f);
                    dataCs.layer++;
                    dai = 1f;
                }
                else if (guzai == 1f)
                {
                    this.transform.position = new Vector3(-10f, 0.3f * dataCs.layer, 5f);
                    dataCs.layer = 1f;
                    dai = 1f;
                    dataCs.vanish = 1;

                }

            }
        }
        else
        {
            rb.useGravity = true;
        }


    }






}
