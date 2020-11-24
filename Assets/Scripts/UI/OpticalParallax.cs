using UnityEngine;

/// <summary>
/// 
/// </summary>
public class OpticalParallax : MonoBehaviour
{
    public GameObject MrChinico;
    public GameObject BackgroundImage;
    public GameObject Title;

    private float[] opticalLevel = new float[] { 0.08f, 0.04f, 0.02f };
    private Vector2 opticalOffset = Vector2.zero;
    private Vector2 screenOffset = Vector2.zero;

    private Vector2[] specialOffset = new Vector2[] {
        new Vector2(250, -250),
        new Vector2(0, Screen.height/2-100) };

    private void Start()
    {
        screenOffset = new Vector2(Screen.width / 2, Screen.height / 2);
    }

    private void Update()
    {
        opticalOffset.x = Input.mousePosition.x - screenOffset.x;
        opticalOffset.y = Input.mousePosition.y - screenOffset.y;

        MrChinico.transform.position = opticalOffset * opticalLevel[0] + screenOffset + specialOffset[0];
        BackgroundImage.transform.position = opticalOffset * opticalLevel[1] + screenOffset;
        //Title.transform.position = opticalOffset * opticalLevel[2] + screenOffset + specialOffset[1];
    }
}