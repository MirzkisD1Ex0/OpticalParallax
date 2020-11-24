using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    private float speed = 2.5f;

    private bool isTurn = false;
    private float index = 0;

    private Vector2 objectSize = new Vector2(1, 1);

    private void Update()
    {
        if (UIStatus.isTitleComplete)
        {
            if (isTurn)
            {
                index += Time.deltaTime * speed;
                if (index > 1)
                {
                    index = 1;
                }
            }
            else
            {
                index -= Time.deltaTime * speed;
                if (index < 0)
                {
                    index = 0;
                }
            }
            objectSize.x = Mathf.Lerp(1f, -1f, index);
            gameObject.transform.localScale = objectSize;
        }
    }

    public void ChangeState()
    {
        isTurn = !isTurn;
    }
}