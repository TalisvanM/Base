﻿using DAL;
using Model;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir()
        {
            UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "João";
            usuario.Senha = "asdf123";
            usuario.Ativo = true;

           /* UsuarioDAL usuarioDAL1 = new UsuarioDAL(); */
            usuarioDAL.Inserir(usuario);
        }
        public void Excluir()
        {

        }
        public void Alterar()
        {

        }
        public List<Usuario> Buscar()
        {
            return new List<Usuario>();
        }

    }
}
