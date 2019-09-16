namespace FilesManager
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.EditReplace1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.EditFind1 = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.HorizontalScrollbar = true;
      this.listBox1.Location = new System.Drawing.Point(12, 66);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(263, 576);
      this.listBox1.TabIndex = 5;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(1434, 543);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(125, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Read File";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(112, 38);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(94, 23);
      this.button3.TabIndex = 8;
      this.button3.Text = "Salvar Arquivo";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(12, 37);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(94, 23);
      this.button4.TabIndex = 9;
      this.button4.Text = "Listar Arquivos";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(12, 12);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(263, 20);
      this.textBox2.TabIndex = 10;
      this.textBox2.Text = "C:\\Lista.txt";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(167, 649);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 16);
      this.label1.TabIndex = 11;
      this.label1.Text = "Alterados: 0";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 649);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 16);
      this.label2.TabIndex = 12;
      this.label2.Text = "Total: 0";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(291, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1054, 653);
      this.tabControl1.TabIndex = 14;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1046, 627);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Manual";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(6, 6);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(1034, 615);
      this.textBox1.TabIndex = 7;
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox3);
      this.tabPage2.Controls.Add(this.groupBox2);
      this.tabPage2.Controls.Add(this.checkBox1);
      this.tabPage2.Controls.Add(this.button1);
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1046, 627);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Automático";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.listBox2);
      this.groupBox3.Location = new System.Drawing.Point(699, 6);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(341, 618);
      this.groupBox3.TabIndex = 19;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Erros:";
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(6, 19);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(329, 589);
      this.listBox2.TabIndex = 19;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(12, 509);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(102, 17);
      this.checkBox1.TabIndex = 16;
      this.checkBox1.Text = "Substituir Todos";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.EditReplace1);
      this.groupBox2.Location = new System.Drawing.Point(6, 252);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(687, 240);
      this.groupBox2.TabIndex = 16;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Substituir por:";
      // 
      // EditReplace1
      // 
      this.EditReplace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditReplace1.Location = new System.Drawing.Point(6, 19);
      this.EditReplace1.Multiline = true;
      this.EditReplace1.Name = "EditReplace1";
      this.EditReplace1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.EditReplace1.Size = new System.Drawing.Size(675, 215);
      this.EditReplace1.TabIndex = 16;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(120, 509);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(288, 23);
      this.button1.TabIndex = 17;
      this.button1.Text = "Substituir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.EditFind1);
      this.groupBox1.Location = new System.Drawing.Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(687, 240);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Buscar:";
      // 
      // EditFind1
      // 
      this.EditFind1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditFind1.Location = new System.Drawing.Point(6, 19);
      this.EditFind1.Multiline = true;
      this.EditFind1.Name = "EditFind1";
      this.EditFind1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.EditFind1.Size = new System.Drawing.Size(675, 206);
      this.EditFind1.TabIndex = 14;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1348, 675);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Editor de Arquivos";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox EditReplace1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox EditFind1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ListBox listBox2;
  }
}

