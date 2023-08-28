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
    private GameObject[] UpBuns;
    private GameObject[] UdBuns;
    private GameObject[] Cheese;
    private GameObject[] Tomato;
    private GameObject[] Meets;
    private GameObject[] Lettuce;

    private GameObject data;
    private Data dataCs;

    private GameObject NearFood;

    [SerializeField] private float d;
    int FoodNumber = 4;
    int j = 0;

    private GameObject[] Targets = new GameObject[24];

    //Rigidbody�^��rb�Ƃ����ϐ������
    private Rigidbody rb;

    public Vector3 movingVelocity;
    Vector3 movingDirecion;

    // Start is called before the first frame update
    void Start()
    {

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

        data = GameObject.Find("Data"); //�q�G�����L�[�ɂ���Data��data�ɑ��;
        dataCs = data.GetComponent<Data>(); //data(�q�G�����L�[�ɂ���Data)�̒�����X�N���v�g��Data���擾

        angle = this.gameObject.transform.localEulerAngles;
        rb = GetComponent<Rigidbody>();
        Transform objectTransform = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        angle.y += Input.GetAxis("Mouse X") * CameraSpeed;

        //angle.x -= Input.GetAxis("Mouse Y") * CameraSpeed;

        this.gameObject.transform.localEulerAngles = angle;

        // Move.x += Input.GetKey(KeyCode.W) * MoveSpeed;
        //Move.x -= Input.GetKey(KeyCode.S) * MoveSpeed;
        //Move.z += Input.GetKey(KeyCode.A) * MoveSpeed;
        //Move.z -= Input.GetKey(KeyCode.D) * MoveSpeed;
        //rb.velocity = new vector3();

        //if (Input.GetKey(KeyCode.W))
        //rb.AddForce(transform.forward * MoveSpeed, ForceMode.Acceleration);   
        //transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            NearFood = null;
            Dist = 10;

            foreach (GameObject t in Targets)
            {
                // ���̃I�u�W�F�N�g�ƐH�ނ܂ł̋������v��
                float tDist = Vector3.Distance(transform.position, t.transform.position);

                // �������u�����l�v�����u�v�����������v�̕����߂��Ȃ�΁A
                if (Dist > tDist)
                {    // �uDist�v���utDist�i�H�ނ܂ł̋����j�v�ɒu��������B
                    // ������J��Ԃ����ƂŁA��ԋ߂��H�ނ������o�����Ƃ��ł���B
                    Dist = tDist;
                    // ��ԋ߂�����NearFood�Ƃ����ϐ��Ɋi�[����
                    NearFood = t;
                    //NearFood.transform.localPosition = new Vector3(3, 0, 0);
                }
            }

            FoodMove fooodMove = NearFood.GetComponent<FoodMove>();
            fooodMove.FoodGof();
            //rb.useGravity = false;
            //NearFood.rb.useGravity = false;
            NearFood.transform.parent = this.gameObject.transform;
            NearFood.transform.position = transform.position + transform.forward * d + transform.up * 3;

        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            FoodMove fooodMove = NearFood.GetComponent<FoodMove>();
            if (NearFood.gameObject.CompareTag("UdBuns"))
                fooodMove.FoodChange(0f);
            else if (NearFood.gameObject.CompareTag("UpBuns"))
                fooodMove.FoodChange(1f);
            else
                fooodMove.FoodChange(2f);
            NearFood.transform.parent = null;
        }

        // W�L�[�i�O���ړ��j
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += MoveSpeed * transform.forward * Time.deltaTime;
        }

        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= MoveSpeed * transform.forward * Time.deltaTime;
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += MoveSpeed * transform.right * Time.deltaTime;
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= MoveSpeed * transform.right * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.L))
        {

        }
    }

    void FixedUpdate()
    {

    }


}





