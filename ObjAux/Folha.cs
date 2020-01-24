using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.ObjAux
{
    class Folha
    {
        Database.Entity.db_a4fdf1_basiEntities1 db = new Database.Entity.db_a4fdf1_basiEntities1();

        public void Calculo()
        {
            Database.Entity.tb_descontos descontos = new Database.Entity.tb_descontos();
            Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
            Database.Entity.tb_provento provento = new Database.Entity.tb_provento();
            Database.Entity.tb_folha pagamento = new Database.Entity.tb_folha();

            pagamento.id_funcionario = funcionario.id_funcionario;
            pagamento.id_descontos = descontos.id_descontos;
            pagamento.id_proventos = provento.id_provento;

            double Salario = Convert.ToDouble(funcionario.vl_salario);
            double FGTS = (0.08 * Salario);
;            if (funcionario.vl_salario <= Convert.ToDecimal(1751.80))
            {
                descontos.vl_inss = Convert.ToDecimal(0.08);
            }

            if (funcionario.vl_salario <= Convert.ToDecimal(2919.72)
                || funcionario.vl_salario >= Convert.ToDecimal(1751.81))
            {
                descontos.vl_inss = Convert.ToDecimal(0.09);
            }
            if (funcionario.vl_salario <= Convert.ToDecimal(5839.45)
                || funcionario.vl_salario >= Convert.ToDecimal(2919.73))
            {
                descontos.vl_inss = Convert.ToDecimal(0.11);
            }
            if (funcionario.vl_salario >= Convert.ToDecimal(5839.46))
            {
                descontos.vl_inss = Convert.ToDecimal(0.11);
            }
            double SalarioLiquido = Convert.ToDouble( ((funcionario.vl_salario - descontos.vl_inss) + FGTS) 
                                      - (descontos.vl_ir - descontos.vl_planoodonto - descontos.vl_planosaude - descontos.vl_segurodevida
                                      - descontos.vl_va - descontos.vl_vr - descontos.vl_vt));

        }
        }


       


    }

