using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veiculosadamlista3ex29
{
    public class veiculo
    {

        public enum tipoveiculo
        {
            carro=0,
            moto=1,
            caminhao=2,
            desonhecido=3
        }

        public static tipoveiculo obtertipoveiculo(string modelo)
        {
            if (modelo.ToLower().Contains("carro"))
            {
                return tipoveiculo.carro;
            }
            else if (modelo.ToLower().Contains("caminhao"))
            {
                return tipoveiculo.caminhao;
            }
            else if (modelo.ToLower().Contains("moto"))
            {
                return tipoveiculo.moto;
            }
            else
            {
                return tipoveiculo.desonhecido;
            }
        }


        public void exibirtipoveiculo(tipoveiculo tipo)
        {
            switch (tipo)
            {
                case tipoveiculo.carro:
                    MessageBox.Show("É um carro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case tipoveiculo.moto:
                    MessageBox.Show("É uma moto.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case tipoveiculo.caminhao:
                    MessageBox.Show("É um caminhão.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case tipoveiculo.desonhecido:
                    MessageBox.Show("Tipo de veículo não reconhecido com base no modelo fornecido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }



}
