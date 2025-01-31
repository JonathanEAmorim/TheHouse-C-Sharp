﻿namespace Model.DTOs.Compras.Mercado
{
    public class GetMercadoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Rua { get; set; }
        public int? Numero { get; set; }
        public string? Cep { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
    }
}
