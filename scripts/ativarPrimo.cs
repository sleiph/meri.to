using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativarPrimo : MonoBehaviour
{
    private GameObject eu;
    private GameObject tio;
    private GameObject primo;
    
    public void AtivarPrimo(){
        primo.gameObject.SetActive(true); 
    }

    // Start is called before the first frame update
    void Awake()
    {
        eu = this.gameObject;
        tio = GameObject.Find("conteudoContent");
        primo = tio.transform.GetChild(eu.transform.GetSiblingIndex()).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
