using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTarget : MonoBehaviour

{
    public GameObject correctAnswer;

    
    private void OnMouseUp()
    {
       if (GameManager.instance.currentObject == correctAnswer)
        {
            GameManager.instance.currentObject.SetActive(false);
            GameManager.instance.currentObject = null;
            Debug.Log("Correct");
        }
       else 
        {
            GameManager.instance.currentObject.transform.position = GameManager.instance.currentObject.GetComponent<DragLabels>().startLocation;
            GameManager.instance.currentObject = null;
            Debug.Log("Wrong");
        }
    }

    private void OnMouseEnter()
    {
        Debug.Log("Working!!!!");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
