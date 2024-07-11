using System;

class Produto
{
    public string Nome{ get; set; }    
    public Decimal Preco{ get; set; }

    public int QuantidadeEstoque{ get; set; }

    
    public Produto(string nome, Decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        QuantidadeEstoque = quantidade;
    }    

    public int AdicionarEstoque(int quantidade)
    {
        if (quantidade < 0)
        {
            throw new ArgumentException("A quantidade não pode ser negativo");
        }
        QuantidadeEstoque =  QuantidadeEstoque + quantidade;
        return quantidade;
    }

    public int RemoverEstoque(int quantidade)
    {
        if (quantidade < 0)
        {
            throw new ArgumentException("A quantida não pode ser negativo");
        }
        if (quantidade > QuantidadeEstoque)
        {
            throw new InvalidOperationException("Quantidade em estoque insuficente");
        }
        QuantidadeEstoque = QuantidadeEstoque - quantidade;
        return quantidade;
    }
   

}