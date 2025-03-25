﻿using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        
        string _descricao;
        double _quantidade;
        double _preco;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { 
            get => _descricao; 
            set
            {
                if(value == null) 
                {
                    throw new Exception("Por favor, preencha a descrição");
                }
                _descricao = value;
            } 
        }
        public double Quantidade
        {
            get => _quantidade;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A quantidade deve ser maior que zero.");
                }
                _quantidade = value;
            }
        }
        public double Preco
        {
            get => _preco;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O preço deve ser maior que zero.");
                }
                _preco = value;
            }
        }
        public double Total { get => Quantidade * Preco; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
