using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class MaskController : UIController
{
    [SerializeField]
    private float speed = 2f;

    private Image image;
    private Color mainColor = new Color(1, 1, 1, 1);
    private float index = 255f;

    private void Start()
    {
        image = GetComponent<Image>();
        speed = 255f / speed;
    }

    private void Update()
    {
        if (!UIStatus.isMaskComplete)
        {
            index -= Time.deltaTime * speed;
            if (index < 0)
            {
                UIStatus.isMaskComplete = true;
                index = 0;
            }
            mainColor.a = index / 255f;
            image.color = mainColor;
        }
    }
}