using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public float layer = 1;
    public float vanish = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (vanish == 1)
            StartCoroutine(DelayCoroutine());
        // �R���[�`���̋N��
    }

    private IEnumerator DelayCoroutine()
    {
        // 1�b�ԑ҂�
        yield return new WaitForSeconds(1);
        vanish = 0;
    }

}
