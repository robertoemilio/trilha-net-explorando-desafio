namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            try
            {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            //IMPLEMENTADO!!! - Roberto - 05-03-2025
            if (Suite.Capacidade >=hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {              
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                //IMPLEMENTADO!!! - Roberto - 05-03-2025
                throw new Exception ("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção Tratada: " + ex.Message);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
            
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            //IMPLEMENTADO!!! - Roberto - 05-03-2025            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            //IMPLEMENTADO!!! - Roberto - 05-03-2025
            decimal valor = DiasReservados * Suite.ValorDiaria;
            

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            //IMPLEMENTADO!!! - Roberto - 05-03-2025
            if (DiasReservados >= 10)
            {
                valor -= (valor*10)/100;
            }

            return valor;
        }
    }
}