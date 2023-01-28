using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuChino
{
    public partial class Form1 : Form
    {
        string[] pedidoBase = {"","","","" };
        string[] pedidoTopping = { "", "", "", "", "" };
        string[] pedidoProteina = { "", "", "", "" };
        string[] pedidoCrujientes = { "", "", "", "" };
        string[] pedidoAderezos = { "", "", "", "" };
        bool validarBase = false;
        bool validarTopping = false;
        bool validarProteina = false;
        bool validarCrujientes = false;
        bool validarAderezos = false;
        public Form1()
        {
            InitializeComponent();
        }

        private int CalcularBase()
        {
            for (int i=0; i<4; i++)
            {
                pedidoBase[i] = "";
            }
            int cont = 0;
            if (baseArroz.CheckState == CheckState.Checked)
            {
                pedidoBase[0] = baseArroz.Text;
                cont++;
            }
            if (baseTallarines.CheckState == CheckState.Checked)
            {
                pedidoBase[1] = baseTallarines.Text;
                cont++;
            }

            if (baseFideos.CheckState == CheckState.Checked)
            {
                pedidoBase[2] = baseFideos.Text;
                cont++;
            }
            if (baseLechuga.CheckState == CheckState.Checked)
            {
                pedidoBase[3] = baseLechuga.Text;
                cont++;
            }
            return cont;
        }

        private int CalcularTopping()
        {
            for (int i = 0; i < 5; i++)
            {
                pedidoTopping[i] = "";
            }
            int cont = 0;
            if (toppingMango.CheckState == CheckState.Checked)
            {
                pedidoTopping[0] = toppingMango.Text;
                cont++;
            }
            if (toppingDurazno.CheckState == CheckState.Checked)
            {
                pedidoTopping[1] = toppingDurazno.Text;
                cont++;
            }
            if (toppingTomate.CheckState == CheckState.Checked)
            {
                pedidoTopping[2] = toppingTomate.Text;
                cont++;
            }
            if (toppingEdamame.CheckState == CheckState.Checked)
            {
                pedidoTopping[3] = toppingEdamame.Text;
                cont++;
            }
            if (toppingChampinones.CheckState == CheckState.Checked)
            {
                pedidoTopping[4] = toppingChampinones.Text;
                cont++;
            }
            return cont;
        }

        private int CalcularProteina()
        {
            for (int i = 0; i < 4; i++)
            {
                pedidoProteina[i] = "";
            }
            int cont = 0;
            if (proteinaPollo.CheckState == CheckState.Checked)
            {
                pedidoProteina[0] = proteinaPollo.Text;
                cont++;
            }
            if (proteinaCerdo.CheckState == CheckState.Checked)
            {
                pedidoProteina[1] = proteinaCerdo.Text;
                cont++;
            }
            if (proteinaRolloP.CheckState == CheckState.Checked)
            {
                pedidoProteina[2] = proteinaRolloP.Text;
                cont++;
            }
            if (proteinaSurimi.CheckState == CheckState.Checked)
            {
                pedidoProteina[3] = proteinaSurimi.Text;
                cont++;
            }
            return cont;
        }

        private int CalcularCrujientes()
        {
            for (int i = 0; i < 4; i++)
            {
                pedidoCrujientes[i] = "";
            }
            int cont = 0;
            if (crujientesArandano.CheckState == CheckState.Checked)
            {
                pedidoCrujientes[0] = crujientesArandano.Text;
                cont++;
            }
            if (crujientesAmaranto.CheckState == CheckState.Checked)
            {
                pedidoCrujientes[1] = crujientesAmaranto.Text;
                cont++;
            }
            if (crujientesCacahuate.CheckState == CheckState.Checked)
            {
                pedidoCrujientes[2] = crujientesCacahuate.Text;
                cont++;
            }
            if (crujientesSemillaG.CheckState == CheckState.Checked)
            {
                pedidoCrujientes[3] = crujientesSemillaG.Text;
                cont++;
            }
            return cont;
        }

        private int CalcularAderezos()
        {
            for (int i = 0; i < 4; i++)
            {
                pedidoAderezos[i] = "";
            }
            int cont = 0;
            if (aderezoHKE.CheckState == CheckState.Checked)
            {
                pedidoAderezos[0] = aderezoHKE.Text;
                cont++;
            }
            if (aderezoAgridulce.CheckState == CheckState.Checked)
            {
                pedidoAderezos[1] = aderezoAgridulce.Text;
                cont++;
            }
            if (aderezoSoya.CheckState == CheckState.Checked)
            {
                pedidoAderezos[2] = aderezoSoya.Text;
                cont++;
            }
            if (aderezoChileSeco.CheckState == CheckState.Checked)
            {
                pedidoAderezos[3] = aderezoChileSeco.Text;
                cont++;
            }
            return cont;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int contBase = 0;
            int contTopping = 0;
            int contProteina = 0;
            int contCrujientes = 0;
            int contAderezos = 0;

            contBase = CalcularBase();
            if (contBase == 0)
            {
                avisoBase.Text = "Tiene que elegir una base";
                panel1.BackColor = Color.FromArgb(255, 51, 51);
                validarBase = false;
            }
            else if (contBase > 1)
            {
                avisoBase.Text = "Solo puede elegir una base";
                panel1.BackColor = Color.FromArgb(255, 51, 51);
                validarBase = false;
            }
            else
            {
                avisoBase.Text = "";
                panel1.BackColor = Color.FromArgb(64, 64, 64);
                validarBase = true;
            }

            contTopping = CalcularTopping();
            if (contTopping == 0)
            {
                avisoTopping.Text = "Tiene que elegir un topping";
                panel3.BackColor = Color.FromArgb(255, 51, 51);
                validarTopping = false;
            }
            else if (contTopping > 3)
            {
                avisoTopping.Text = "Solo puede elegir 3 topping máximo";
                panel3.BackColor = Color.FromArgb(255, 51, 51);
                validarTopping = false;
            }
            else
            {
                avisoTopping.Text = "";
                panel3.BackColor = Color.FromArgb(64, 64, 64);
                validarTopping = true;
            }

            contProteina = CalcularProteina();
            if (contProteina == 0)
            {
                avisoProteina.Text = "Tiene que elegir una proteina";
                panel5.BackColor = Color.FromArgb(255, 51, 51);
                validarProteina = false;
            }
            else if (contProteina > 2)
            {
                avisoProteina.Text = "Solo puede elegir 2 proteinas máximo";
                panel5.BackColor = Color.FromArgb(255, 51, 51);
                validarProteina = false;
            }
            else
            {
                avisoProteina.Text = "";
                panel5.BackColor = Color.FromArgb(64, 64, 64);
                validarProteina = true;
            }

            contCrujientes = CalcularCrujientes();
            if (contCrujientes == 0)
            {
                avisoCrujientes.Text = "Tiene que elegir un crujiente";
                panel7.BackColor = Color.FromArgb(255, 51, 51);
                validarCrujientes = false;
            }
            else if (contCrujientes > 2)
            {
                avisoCrujientes.Text = "Solo puede elegir 2 crujientes máximo";
                panel7.BackColor = Color.FromArgb(255, 51, 51);
                validarCrujientes = false;
            }
            else
            {
                avisoCrujientes.Text = "";
                panel7.BackColor = Color.FromArgb(64, 64, 64);
                validarCrujientes = true;
            }

            contAderezos = CalcularAderezos();
            if (contAderezos == 0)
            {
                avisoAderezos.Text = "Tiene que elegir un aderezo";
                panel9.BackColor = Color.FromArgb(255, 51, 51);
                validarAderezos = false;
            }
            else if (contAderezos > 2)
            {
                avisoAderezos.Text = "Solo puede elegir 2 aderezos máximo";
                panel9.BackColor = Color.FromArgb(255, 51, 51);
                validarAderezos = false;
            }
            else
            {
                avisoAderezos.Text = "";
                panel9.BackColor = Color.FromArgb(64, 64, 64);
                validarAderezos = true;
            }

            if (validarBase == true && validarTopping == true && validarProteina == true && validarCrujientes == true && validarAderezos == true)
            {
                MessageBox.Show("Orden generada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string pedido1 = "";
                for (int i = 0; i < 4; i++)
                {
                    if (pedidoBase[i] != "")
                    {
                        pedido1 = pedido1 + pedidoBase[i];
                    }         
                }

                string pedido2 = "";
                for (int i = 0; i < 5; i++)
                {
                    if (pedidoTopping[i] != "")
                    {
                        pedido2 = pedido2 + "\n" + pedidoTopping[i];
                    }
                }

                string pedido3 = "";
                for (int i = 0; i < 4; i++)
                {
                    if (pedidoProteina[i] != "")
                    {
                        pedido3 = pedido3 + "\n" + pedidoProteina[i];
                    }
                }

                string pedido4 = "";
                for (int i = 0; i < 4; i++)
                {
                    if (pedidoCrujientes[i] != "")
                    {
                        pedido4 = pedido4 + "\n" + pedidoCrujientes[i];
                    }
                }

                string pedido5 = "";
                for (int i = 0; i < 4; i++)
                {
                    if (pedidoAderezos[i] != "")
                    {
                        pedido5 = pedido5 + "\n" + pedidoAderezos[i];
                    }
                }
                MessageBox.Show("<< Base >>\n" + pedido1 + "\n\n<< Topping >>" + pedido2 + "\n\n<< Proteina >>" + pedido3 + "\n\n<< Crujientes >>" + pedido4 + "\n\n<< Aderezos >>" + pedido5, "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Porfavor revisa tu pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
