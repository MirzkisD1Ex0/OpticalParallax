using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ShadowController : UIController
{
    [SerializeField]
    private float speed = 1f;

    private Image image;
    private Color mainColor = new Color(1, 1, 1, 1);
    private float index = 0;

    private void Start()
    {
        image = GetComponent<Image>();
        speed = 255f / speed;
    }

    private void Update()
    {
        if (UIStatus.isMaskComplete)
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