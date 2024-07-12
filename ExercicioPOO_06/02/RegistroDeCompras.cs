/*
2 - Crie uma classe RegistroDeCompras com atributos para registrar informações de
compras (data, produto, valor). Implemente um construtor e métodos para adicionar e
listar compras.
*/

using System;

class RegistroDeCompras
{

    public string Produto{ get; set; }

    public double Valor { get; set; }

    public DateTime Data{ get; set; }

    public int Validade{ get; set; }

    
    public RegistroDeCompras(string produto, double valor, DateTime data, int validade)
    {
       
        Produto = produto;
        Valor = valor;
        Data = data;
        Validade = validade;
    }
    public string VerificarValidade()
    {
        DateTime validadeData = Data.AddDays(Validade);
        TimeSpan diferenca = validadeData - DateTime.Now;

        if(diferenca.TotalDays >= 0)
        {
            return $"Válido - Falta {diferenca.Days} Dias para passar dar validade";
        }
        else
        {
            return $"Passou da validade {Math.Abs(diferenca.Days)}  dias atrás";
        }
    }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Produto: {Produto}, Valor: {Valor:C}, Data: {Data:dd/MM/yyyy}");
    }

}