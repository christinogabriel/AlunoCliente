using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Workspace.Models
{
    public class Aluno
    {
      public string Nome{get;set;}
      public int Idade {get;set;}
      public char Sexo{ get; set; }
      public string Endereco{ get; set; }
      public string RG { get; set; }

      public void TomarAdvertencia()
      {
        Console.WriteLine($"O aluno {Nome} esta advertido!");
      }

      public void SairMaisCedo() 
      {
        Console.WriteLine($"O aluno {Nome} sairá mais cedo!");
      }
    }

    
}

//características -> são as props (propriedade)
// Ações -> métodos (função)
// class é o molde
// -------------------------------
// get e set são métodos:
// get -> pegar algo
// set -> alterar algo

// -----------VISIBILIDADE-----------
//public -> qualquer lugar do projeto
//privace -> somente a class terá acesso
//default -> somente o pacote
// protect -> somente as class que possuem heranças
// -----------------------------------
//char -> comporta somente 1 caracter. ( aspas simples)
// $ -> variável e texto
