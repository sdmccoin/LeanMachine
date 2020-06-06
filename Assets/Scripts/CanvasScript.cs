using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
     [SerializeField] PopupPanel popupPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        popupPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
