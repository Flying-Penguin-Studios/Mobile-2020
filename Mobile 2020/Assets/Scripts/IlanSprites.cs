using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IlanSprites : MonoBehaviour
{
    Image Image_Sprite;
    SpriteRenderer Render_Sprite;

    // Start is called before the first frame update
    void Start()
    {
        Image_Sprite = GetComponent<Image>();
        Render_Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Image_Sprite.sprite = Render_Sprite.sprite;
    }
}
