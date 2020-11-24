using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CttController : UIController
{
    private float speed = 0.5f;

    private Image image;
    private Color mainColor = new Color(1, 1, 1, 0);
    private float index = 0;

    private void Start()
    {
        image = GetComponent<Image>();
        speed = 255f / speed;
        image.color = mainColor;
    }

    private void Update()
    {
        if (UIStatus.isTitleComplete)
        {
            index += Time.deltaTime * speed;
            if (index > 255)
            {
                UIStatus.isShadowComplete = true;
                index = 255;
            }
            mainColor.a = index / 255f;
            image.color = mainColor;
        }
    }
}
