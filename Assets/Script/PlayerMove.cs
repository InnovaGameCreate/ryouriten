using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] public float CameraSpeed;
    [SerializeField] private float Dist;
    private Vector3 angle;
    private Vector3 Move;
    private GameObject[] Targets;
    private GameObject NearFood;

    [SerializeField] private float d;

    //Rigidbody型のrbという変数を作る
    private Rigidbody rb;

<<<<<<< Updated upstream

    // [SerializeField] private Foodcs _foodcs;

    //Vector3 targetPosition = new Vector3(0, 0, 0);


    //Rigidbody rd;

    public Vector3 movingVelocity;
    Vector3 movingDirecion;

    // Start is called before the first frame update
    void Start()
    {
        Targets = GameObject.FindGameObjectsWithTag("Food");
=======
    // Start is called before the first frame update
    void Start()
    {
        //食材をTargetsに入れる
        UpBuns = GameObject.FindGameObjectsWithTag("UpBuns");
        UdBuns = GameObject.FindGameObjectsWithTag("UdBuns");
        Cheese = GameObject.FindGameObjectsWithTag("Cheese");
        Tomato = GameObject.FindGameObjectsWithTag("Tomato");
        Meets = GameObject.FindGameObjectsWithTag("Meets");
        Lettuce = GameObject.FindGameObjectsWithTag("Lettuce");
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = UpBuns[i];
            j++;
        }
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = UdBuns[i];
            j++;
        }
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = Cheese[i];
            j++;
        }
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = Tomato[i];
            j++;
        }
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = Meets[i];
            j++;
        }
        for (int i = 0; FoodNumber > i; i++)
        {
            Targets[j] = Lettuce[i];
            j++;
        }

        data = GameObject.Find("Data"); //ヒエラルキーにあるDataをdataに代入;
        dataCs = data.GetComponent<Data>(); //data(ヒエラルキーにあるData)の中からスクリプトのDataを取得

>>>>>>> Stashed changes
        angle = this.gameObject.transform.localEulerAngles;
        rb = GetComponent<Rigidbody>();
        //rbz = GetComponent<Rigidbody>();
        Transform objectTransform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //カメラ移動　縦は今のところナシ
        angle.y += Input.GetAxis("Mouse X") * CameraSpeed;
        //angle.x -= Input.GetAxis("Mouse Y") * CameraSpeed;
        this.gameObject.transform.localEulerAngles = angle;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NearFood = null;
            Dist = 10;

            foreach (GameObject t in Targets)
            {
                // このオブジェクトと食材までの距離を計測
                float tDist = Vector3.Distance(transform.position, t.transform.position);

                // もしも「初期値」よりも「計測した距離」の方が近いならば、
                if (Dist > tDist)
                {    // 「Dist」を「tDist（食材までの距離）」に置き換える。
                    // これを繰り返すことで、一番近い食材を見つけ出すことができる。
                    Dist = tDist;
                    // 一番近い情報をNearFoodという変数に格納する
                    NearFood = t;
                    //NearFood.transform.localPosition = new Vector3(3, 0, 0);

<<<<<<< Updated upstream
                }


            }
            //rd.useGravity = false;
            //NearFood.rb.useGravity = false;
=======
            FoodMove fooodMove = NearFood.GetComponent<FoodMove>();
            fooodMove.FoodGof();
>>>>>>> Stashed changes
            NearFood.transform.parent = this.gameObject.transform;
            NearFood.transform.position = transform.position + transform.forward * d + transform.up * 3;

        }


        if (Input.GetKeyUp(KeyCode.Space))
        {


            // GameObject otherGameObject = GameObject.FindWithTag("Food");

            //Foodcs foodcs = NearFood.GetComponent<Foodcs>();　ここは解除したい
            //foodcs.FoodMove(0f);　ここは解除したい
            NearFood.transform.parent = null;




        }

        // Wキー（前方移動）
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += MoveSpeed * transform.forward * Time.deltaTime;
        }

        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= MoveSpeed * transform.forward * Time.deltaTime;
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += MoveSpeed * transform.right * Time.deltaTime;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= MoveSpeed * transform.right * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {

    }


}

