using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirCursor : MonoBehaviour
{

    private RectTransform oRectTransform;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        oRectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;

        if (Input.GetButtonDown("Fire1"))
        {
            oRectTransform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
        } else if (Input.GetButtonUp("Fire1"))
        {
            oRectTransform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
