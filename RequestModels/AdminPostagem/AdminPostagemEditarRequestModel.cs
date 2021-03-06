﻿using PWABlog.Models.Blog.Autor;
using PWABlog.Models.Blog.Categoria;
using PWABlog.Models.Blog.Etiqueta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PWABlog.RequestModels.AdminPostagem
{
    public class AdminPostagemEditarRequestModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string DataPostagem { get; set; }
        
        public int  IdCategoria { get; set; }

        public string Texto { get; set; }
    }
}
