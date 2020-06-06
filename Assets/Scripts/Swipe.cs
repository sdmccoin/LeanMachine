using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public float dragSpeed = .1f;
    private Vector3 dragOrigin;

    public bool cameraDragging = true;

    public float outerLeft = -10f;
    public float outerRight = 10f;
    public float topMost = 10f;
    public float bottomMost = 10f;

    private float maxX = 10f;
    private float minX = -10;
    private float maxY = 10f;
    private float minY = -10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        //float left = Screen.width * 0.2f;
        //float right = Screen.width - (Screen.width * 0.2f);
        //float top = Screen.height * 0.2f;
        //float bottom = Screen.height - (Screen.height * 0.2f);

        //if (mousePosition.x < left)
        //{
        //    cameraDragging = true;
        //}
        //else if (mousePosition.x > right)
        //{
        //    cameraDragging = true;
        //}

        //if (mousePosition.y < top)
        //{
        //    cameraDragging = true;
        //}
        //else if(mousePosition.y > bottom)
        //{
        //    cameraDragging = true;
        //}

        //if (cameraDragging)
        //{

        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        dragOrigin = Input.mousePosition;
        //        return;
        //    }

        //    if (!Input.GetMouseButton(0)) return;

        //    Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        //    Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        //    if (Mathf.Clamp(move.x, minX, maxX) > 0f)
        //    {
        //        if (Mathf.Clamp(this.transform.position.x, minX, maxX) < outerRight)
        //        {
        //            transform.Translate(move, Space.World);
        //        }
        //    }
        //    else
        //    {
        //        if (Mathf.Clamp(this.transform.position.x, minX, maxX) > outerLeft)
        //        {
        //            transform.Translate(move, Space.World);
        //        }
        //    }

        //    if (Mathf.Clamp(move.y, minY, maxY) > 0f)
        //    {
        //        if (Mathf.Clamp(this.transform.position.y, minY, maxY) < topMost)
        //        {
        //            transform.Translate(move, Space.World);
        //        }
        //    }
        //    else
        //    {
        //        if (Mathf.Clamp(this.transform.position.y, minY, maxY) > bottomMost)
        //        {
        //            transform.Translate(move, Space.World);
        //        }
        //    }
        //}

    }
}

//transform.Translate(movement* speed * Time.deltaTime, Space.Self);
