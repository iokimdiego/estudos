namespace RH
{
    public class Funcionario
    {
        public string Nome;
        private string CPF;

        public Funcionario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public string GetCPF()
        {
            return CPF;
        }
        
        public void SetCPF(string cpf)
        {
            if (cpf.Length == 0)
                return;
            CPF = cpf;
        }
    }
}

