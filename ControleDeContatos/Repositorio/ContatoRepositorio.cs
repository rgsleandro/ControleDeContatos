using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _context;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _context = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB != null)
            {
                contatoDB.Nome = contato.Nome;
                contatoDB.Email = contato.Email;
                contatoDB.Telefone = contato.Telefone;

                _context.Contatos.Update(contatoDB);
                _context.SaveChanges();

                return contatoDB;
            }

            throw new System.Exception("Houve um erro na atualização do contato");
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB != null)
            {
                _context.Contatos.Remove(contatoDB);
                _context.SaveChanges();
                return true;
            }

            throw new System.Exception("Houve um erro na deleção do contato");
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }
    }
}
