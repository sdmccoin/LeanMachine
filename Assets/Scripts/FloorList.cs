using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorList : MonoBehaviour
{
    [SerializeField] PopupPanel popupPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Debug.Log("Mouse Clicked");
    //        OpenPanel();
    //    }
            
    //}

    public void OpenPanel()
    {
        Debug.Log("Mouse Clicked");
        //popupPanel = FindObjectOfType<PopupPanel>();
        popupPanel.gameObject.SetActive(true);
    }
}
