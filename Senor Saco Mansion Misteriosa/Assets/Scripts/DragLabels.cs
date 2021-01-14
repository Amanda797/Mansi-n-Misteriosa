using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class DragLabels : MonoBehaviour
    
{
    public Vector3 startLocation;
    bool isDragging;
    public float z = 5;
    private void OnMouseDown()
    {
        isDragging = true;
        GameManager.instance.currentObject = this.gameObject;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        isDragging = false;
        startLocation = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            GetComponent<Transform>().position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z));
        }
    }
}
