using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
        
        public bool Permitir { get; set; }

        public void Autorizar(){

            System.Console.WriteLine("Deseja permitir acesso? Digite true para sim ou false para nao.");
            try
            {
                Permitir = Boolean.Parse( Console.ReadLine() );
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Erro na aplicação, por favor tente novamente!");
                
            }
            
            

        }

    }
}