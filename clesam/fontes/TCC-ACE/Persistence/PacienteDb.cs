using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC_ACE.Models;

namespace TCC_ACE.Persistence
{
    public class PacienteDb
    {
        private ContextEntities Context { get; set; }

        public PacienteDb(ContextEntities context)
        {
            this.Context = context;
        }

        public bool SalvarPaciente(ModelPaciente paciente)
        {
            var pacienteIncluir = new Paciente
            {
                Prontuario = paciente.Prontuario,
                Nome = paciente.Nome,
                DataNascimento = paciente.DataNascimento,
                Logradouro = paciente.Logradouro,
                NumeroLogradouro = paciente.NumeroLogradouro,
                Bairro = paciente.Bairro,
                TelefoneResidencia = paciente.TelefoneResidencia,
                TelefoneCelular = paciente.TelefoneCelular,
                Profissao = paciente.Profissao,
                Email = paciente.Email,
            };

            Context.Paciente.Add(pacienteIncluir);
            Context.SaveChanges();
            return true;
        }
    }
}