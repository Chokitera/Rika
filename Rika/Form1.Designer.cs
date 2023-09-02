namespace Rika
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.novoTextBox1 = new Rika.controls.novoTextBox();
            this.novosComboBox1 = new Rika.controls.novosComboBox();
            this.modeloCheckBox1 = new Rika.controls.ModeloCheckBox();
            this.modeloBotao1 = new Rika.controls.ModeloBotao();
            this.SuspendLayout();
            // 
            // novoTextBox1
            // 
            this.novoTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.novoTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.novoTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.novoTextBox1.BorderSize = 2;
            this.novoTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.novoTextBox1.Location = new System.Drawing.Point(315, 106);
            this.novoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.novoTextBox1.Multiline = false;
            this.novoTextBox1.Name = "novoTextBox1";
            this.novoTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.novoTextBox1.PasswordChar = false;
            this.novoTextBox1.Size = new System.Drawing.Size(250, 31);
            this.novoTextBox1.TabIndex = 0;
            this.novoTextBox1.UnderlinedStyle = false;
            // 
            // novosComboBox1
            // 
            this.novosComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.novosComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.novosComboBox1.BorderSize = 1;
            this.novosComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.novosComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.novosComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.novosComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.novosComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.novosComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.novosComboBox1.Location = new System.Drawing.Point(281, 65);
            this.novosComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.novosComboBox1.Name = "novosComboBox1";
            this.novosComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.novosComboBox1.Size = new System.Drawing.Size(200, 30);
            this.novosComboBox1.TabIndex = 1;
            this.novosComboBox1.Texts = "";
            // 
            // modeloCheckBox1
            // 
            this.modeloCheckBox1.AutoSize = true;
            this.modeloCheckBox1.Location = new System.Drawing.Point(536, 271);
            this.modeloCheckBox1.MinimumSize = new System.Drawing.Size(45, 22);
            this.modeloCheckBox1.Name = "modeloCheckBox1";
            this.modeloCheckBox1.OffBackColor = System.Drawing.Color.Gray;
            this.modeloCheckBox1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.modeloCheckBox1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.modeloCheckBox1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.modeloCheckBox1.Size = new System.Drawing.Size(45, 22);
            this.modeloCheckBox1.TabIndex = 2;
            this.modeloCheckBox1.UseVisualStyleBackColor = true;
            // 
            // modeloBotao1
            // 
            this.modeloBotao1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.modeloBotao1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.modeloBotao1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.modeloBotao1.BorderRadius = 0;
            this.modeloBotao1.BorderSize = 0;
            this.modeloBotao1.FlatAppearance.BorderSize = 0;
            this.modeloBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modeloBotao1.ForeColor = System.Drawing.Color.White;
            this.modeloBotao1.Location = new System.Drawing.Point(315, 172);
            this.modeloBotao1.Name = "modeloBotao1";
            this.modeloBotao1.Size = new System.Drawing.Size(150, 40);
            this.modeloBotao1.TabIndex = 3;
            this.modeloBotao1.Text = "modeloBotao1";
            this.modeloBotao1.TextColor = System.Drawing.Color.White;
            this.modeloBotao1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modeloBotao1);
            this.Controls.Add(this.modeloCheckBox1);
            this.Controls.Add(this.novosComboBox1);
            this.Controls.Add(this.novoTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.novoTextBox novoTextBox1;
        private controls.novosComboBox novosComboBox1;
        private controls.ModeloCheckBox modeloCheckBox1;
        private controls.ModeloBotao modeloBotao1;
    }
}

