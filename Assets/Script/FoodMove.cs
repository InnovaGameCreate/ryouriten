using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMove : MonoBehaviour
{

    [SerializeField] private float dai = 0f;
    private GameObject data;
    private Data dataCs;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("Data"); //ヒエラルキーにあるDataをdataに代入;
        dataCs = data.GetComponent<Data>(); //data(ヒエラルキーにあるData)の中からスクリプトのDataを取得
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) && dai == 0f)
        {

            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.useGravity = false;
        }

        if (dai == 1f)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            if (dataCs.vanish == 1)
            {
                // コルーチンの起動
                StartCoroutine(DelayCoroutine());
            }
        }
    }


    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(1);
        this.transform.position = new Vector3(-100f, 0.3f, 5f);
    }


    public void FoodGof()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    public void FoodChange(float guzai)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (-43f < this.transform.position.x && this.transform.position.x < -19f && -32f < this.transform.position.z && this.transform.position.z < -15f)
        {
            if (dataCs.layer == 1f)
            {
                if (guzai == 0f)
                {
                    this.transform.position = new Vector3(-35f, 12 + 0.3f * dataCs.layer, -27f);

                    dataCs.layer++;
                    dai = 1f;
                }
                else
                {
                    this.transform.position = new Vector3(-100f, 0.3f, 5f);
                }
            }

            else
            {
                if (guzai == 0f)
                {
                    this.transform.position = new Vector3(-100f, 0.3f, 5f);
                }
                else if (guzai == 2f)
                {
                    this.transform.position = new Vector3(-35f, 12 + 0.3f * dataCs.layer, -27f);
                    dataCs.layer++;
                    dai = 1f;
                }
                else if (guzai == 1f)
                {
                    this.transform.position = new Vector3(-35f, 12 + 0.3f * dataCs.layer, -27f);
                    dataCs.layer = 1f;
                    dai = 1f;
                    dataCs.vanish = 1;

                }

            }
        }
        else
        {
            rb.useGravity = true;
            rb.isKinematic = false;
        }


    }






}
