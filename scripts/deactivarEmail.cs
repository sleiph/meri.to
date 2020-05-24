using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivarEmail : MonoBehaviour
{

    public void DisableChildren()  
    {    
        foreach (Transform child in transform)     
        {  
            child.gameObject.SetActive(false);   
        }   
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
