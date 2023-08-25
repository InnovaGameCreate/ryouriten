using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RequestIngredients : MonoBehaviour
{
    [SerializeField] private float Lcount;
    [SerializeField] private float Mcount;
    [SerializeField] private float Ccount;
    [SerializeField] private float Tcount;

    int lcnt = 0;
    int mcnt = 0;
    int ccnt = 0;
    int tcnt = 0;

    public int killcount1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

        // Update is called once per frame
        void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            Discrimination();
    }

    void Discrimination()
    {
        RaycastHit[] hits = Physics.SphereCastAll(
              transform.position,
              7.0f,
              Vector3.right);

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

        if (Lcount == lcnt && Mcount == mcnt && Ccount == ccnt && Tcount == tcnt)
        {
            Debug.Log("REQUEST CLEAR!");
            foreach (var hit in hits)
            {
                if (hit.collider.name == "Meets.P") //���̐l�̎�_�łł�������
                    killcount1 += 1;
                Debug.Log($"Kill:{killcount1}");
            }
        }
        else
            Debug.Log("FALSE");
    }
}
