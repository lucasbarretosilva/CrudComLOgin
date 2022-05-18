namespace WFLogin
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.rdbNet = new System.Windows.Forms.RadioButton();
            this.rdbJava = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.serverCastDataSet = new WFLogin.ServerCastDataSet();
            this.serverCastDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serverCastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverCastDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cadastro de Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(262, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 29);
            this.txtNome.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(262, 129);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(187, 29);
            this.txtRg.TabIndex = 6;
            // 
            // rdbNet
            // 
            this.rdbNet.AutoSize = true;
            this.rdbNet.Location = new System.Drawing.Point(538, 108);
            this.rdbNet.Name = "rdbNet";
            this.rdbNet.Size = new System.Drawing.Size(45, 17);
            this.rdbNet.TabIndex = 7;
            this.rdbNet.TabStop = true;
            this.rdbNet.Text = ".Net";
            this.rdbNet.UseVisualStyleBackColor = true;
            this.rdbNet.CheckedChanged += new System.EventHandler(this.rdbNet_CheckedChanged);
            // 
            // rdbJava
            // 
            this.rdbJava.AutoSize = true;
            this.rdbJava.Location = new System.Drawing.Point(652, 108);
            this.rdbJava.Name = "rdbJava";
            this.rdbJava.Size = new System.Drawing.Size(48, 17);
            this.rdbJava.TabIndex = 8;
            this.rdbJava.TabStop = true;
            this.rdbJava.Text = "Java";
            this.rdbJava.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Turmas";
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(582, 268);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(91, 23);
            this.btnMostrarLista.TabIndex = 11;
            this.btnMostrarLista.Text = "Mostrar Turmas";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // serverCastDataSet
            // 
            this.serverCastDataSet.DataSetName = "ServerCastDataSet";
            this.serverCastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serverCastDataSetBindingSource
            // 
            this.serverCastDataSetBindingSource.DataSource = this.serverCastDataSet;
            this.serverCastDataSetBindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(182, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(384, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(590, 350);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(589, 309);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Editar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbJava);
            this.Controls.Add(this.rdbNet);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            ((System.ComponentModel.ISupportInitialize)(this.serverCastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverCastDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.RadioButton rdbNet;
        private System.Windows.Forms.RadioButton rdbJava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.BindingSource serverCastDataSetBindingSource;
        private ServerCastDataSet serverCastDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}