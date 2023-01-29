using UnityEngine;
using UnityEngine.UI;

public class Abas : MonoBehaviour
{
    [SerializeField] GameObject abaEmail;
    [SerializeField] GameObject abaCurriculo;
    [SerializeField] GameObject abaMusica;

    [SerializeField] GameObject email;
    [SerializeField] GameObject curriculo;
    [SerializeField] GameObject musica;

    Color corAtivo = new Color(82f/255f, 82f/255f, 82f/255f);
    Color corInativo = new Color(42f/255f, 42f/255f, 42f/255f);

    public void AbrirEmail() {
        abaCurriculo.GetComponent<Image>().color = corInativo;
        curriculo.SetActive(false);
        abaMusica.GetComponent<Image>().color = corInativo;
        musica.SetActive(false);

        abaEmail.GetComponent<Image>().color = corAtivo;
        email.SetActive(true);
    }

    public void AbrirCurriculo() {
        abaEmail.GetComponent<Image>().color = corInativo;
        email.SetActive(false);
        abaMusica.GetComponent<Image>().color = corInativo;
        musica.SetActive(false);

        abaCurriculo.GetComponent<Image>().color = corAtivo;
        curriculo.SetActive(true);
    }

    public void AbrirMusica() {
        abaCurriculo.GetComponent<Image>().color = corInativo;
        curriculo.SetActive(false);
        abaEmail.GetComponent<Image>().color = corInativo;
        email.SetActive(false);

        abaMusica.GetComponent<Image>().color = corAtivo;
        musica.SetActive(true);
    }
}
