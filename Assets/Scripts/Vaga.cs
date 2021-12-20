using System;

[Serializable]
public class Vaga
{
    public string id;

    public Empresa empresa;
    public string cargo;
    public double salario;
    public bool isRemoto;

    public string[] atividades;
    public Requisito[] requisitos;
}
