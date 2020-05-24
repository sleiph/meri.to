using UnityEngine;
using UnityEditor;
using System.IO;

public class leitor : MonoBehaviour
{
    public string LerString(int n)
    {
        string path = "Assets/data/texto.txt";
        StreamReader texto = new StreamReader(path); 
        string entrada = texto.ReadToEnd();
        texto.Close();
        string[] linhas = entrada.Split("\n"[0]);
        return linhas[n];
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
