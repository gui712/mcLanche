﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [StringLength(100,ErrorMessage ="O tamanho maximo é 100 caracteres.")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do lanche.")]
        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}