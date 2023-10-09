using Rika.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rika.models.Comum
{
    public class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    //Limpa os campos de texto na tela
                    if (ctr1 is TextBox)
                        (ctr1 as TextBox).Text = string.Empty;                   

                    if (ctr1 is MaskedTextBox)
                        (ctr1 as MaskedTextBox).Text = string.Empty;

                    if (ctr1 is textBoxComImagem)
                        (ctr1 as textBoxComImagem).Text = string.Empty;

                    if (ctr1 is novoTextBox)
                        (ctr1 as novoTextBox).Text = string.Empty;

                    if (ctr1 is novoTextBoxReadOnly)
                        (ctr1 as novoTextBoxReadOnly).Text = string.Empty;

                    if (ctr1 is novoTextBoxTextAlign)
                        (ctr1 as novoTextBoxTextAlign).Text = string.Empty;
                }
            }
        }
    }
}
