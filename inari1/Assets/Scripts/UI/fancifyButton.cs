using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class fancifyButton : MonoBehaviour
{
    public Vector2 defaultSize;
    public Vector2 hoverSize;
    public float smoothTime;

    Vector2 size;
    Vector2 velocity = Vector2.zero;
    RectTransform rT;
    mouseChecker mC;

    private void Start()
    {
        size = defaultSize;
        rT = GetComponent<RectTransform>();
        mC = GetComponent<mouseChecker>();
    }

    private void Update()
    {
        rT.sizeDelta = size;

        if (mC.mouse_over)
        {
            size = Vector2.SmoothDamp(size, hoverSize, ref velocity, smoothTime);
        } else
        {
            size = Vector2.SmoothDamp(size, defaultSize, ref velocity, smoothTime);
        }
    }
}
