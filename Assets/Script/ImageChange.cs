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
        // SpriteRendererコンポーネントを取得します
        image = GetComponent<Image>();
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
            // 画像を切り替えます
            image.sprite = newSprite1;
        }

        if (num == 2)
        {
            // 画像を切り替えます
            image.sprite = newSprite2;
        }

        if (num == 3)
        {
            // 画像を切り替えます
            image.sprite = newSprite3;
        }

        if (num == 4)
        {
            // 画像を切り替えます
            image.sprite = newSprite4;
        }

        if (num == 5)
        {
            // 画像を切り替えます
            image.sprite = newSprite5;
        }
    }
}
