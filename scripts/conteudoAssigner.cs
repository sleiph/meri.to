using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conteudoAssigner : MonoBehaviour
{
    private GameObject filho;
    private leitor leitor;

    void Awake()
    {
        filho = this.gameObject.transform.GetChild(0).gameObject;
        leitor = GameObject.Find("lista").GetComponent<leitor>();
        
        filho.GetComponent<Text>().text = leitor.LerString(0);
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
