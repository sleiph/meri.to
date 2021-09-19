public class Curriculo
{
    string id;

    Empresa empresa;
    string cargo;
    double salario;
    bool isRemoto;

    string[] atividades;
    Requisito[] requisitos;

    public Curriculo (
        Empresa empresa, string cargo, double salario, bool isRemoto,
        string[] atividades, Requisito[] requisitos
    ) {
        this.empresa = empresa;
        this.cargo = cargo;
        this.salario = salario;
        this.isRemoto = isRemoto;
        this.atividades = atividades;
        this.requisitos = requisitos;
    }
}
