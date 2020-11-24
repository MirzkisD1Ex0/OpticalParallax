using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TitleController : MonoBehaviour
{
    private float speed = 0.5f;

    private Text text;
    private Color mainColor = new Color(1, 1, 1, 1);
    private float index = 0;

    private void Start()
    {
        text = GetComponent<Text>();
        speed = 255f / speed;
    }

    private void Update()
    {
        if (UIStatus.isShadowComplete)
        {
            index += Time.deltaTime * speed;
            if (index > 255)
            {
                UIStatus.isTitleComplete = true;
                index = 255;
            }
            mainColor.a = index / 255f;
            text.color = mainColor;
        }
    }
}