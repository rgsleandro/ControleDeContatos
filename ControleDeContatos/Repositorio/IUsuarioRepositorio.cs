﻿using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar (UsuarioModel usuario);
        UsuarioModel Atualizar (UsuarioModel usuario);
        UsuarioModel Editar (UsuarioModel usuario);
        bool Apagar(int id);
    }
}
