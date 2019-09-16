using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesManager
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public int Cont { get; set; }


    private void button2_Click(object sender, EventArgs e)
    {
      // Ler o arquivo e trás para ser editado
      string conteudoTxt;

      try
      {
        //Pegar o caminho do arquivo escolhido
        string caminhoAbrir = listBox1.SelectedItem.ToString();
        // caminhoAbrir = listBox1.SelectedItem.ToString();

        conteudoTxt = File.ReadAllText(caminhoAbrir);
        //Coloca o arquivo no textBox
        textBox1.Text = conteudoTxt;
      }
      catch (Exception ex) { MessageBox.Show(ex.Message); };
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //Faz as substituições
      string novoConteudoTxt = textBox1.Text;

      //###### Salva o txt com os valores substituídos onde o usuário escolher ######//
      try
      {

        //Pegar o caminho do arquivo que ele criou
        string caminhoSalvar = listBox1.SelectedItem.ToString();
        //Salvar todo o texto no caminho do arquivo escolhido
        File.WriteAllText(caminhoSalvar, novoConteudoTxt);
        //Mostrar confirmação
        Cont += 1;
        label1.Text = "Alterados: " + Cont.ToString();
        MessageBox.Show("Arquivo salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

      }
      catch (Exception ex) { MessageBox.Show(ex.Message); };
    }

    private void button4_Click(object sender, EventArgs e)
    {

      listBox1.Items.Clear();
      // Ler o arquivo com o diretorio
      try
      {
        //Pegar o caminho do arquivo escolhido
        string[] array = File.ReadAllLines(textBox2.Text);
        int i = 0;

        listBox1.Items.AddRange(array);
        i = listBox1.Items.Count;
        label2.Text = "Total: " + i.ToString();
      }
      catch (Exception ex) { MessageBox.Show(ex.Message); };
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void ListBox1_DoubleClick(object sender, EventArgs e)
    {
      if (listBox1.SelectedItem != null)
      {
        //MessageBox.Show(listBox1.SelectedItem.ToString());
        ReadDoc();
      }
    }

    protected void ReadDoc()
    {
      // Ler o arquivo e trás para ser editado
      string conteudoTxt;

      try
      {
        //Pegar o caminho do arquivo escolhido
        string caminhoAbrir = listBox1.SelectedItem.ToString();
        // caminhoAbrir = listBox1.SelectedItem.ToString();

        conteudoTxt = File.ReadAllText(caminhoAbrir);
        //Coloca o arquivo no textBox
        textBox1.Text = conteudoTxt;
      }
      catch (Exception ex) { MessageBox.Show(ex.Message); };
    }


    private void button1_Click(object sender, EventArgs e)
    {

      string conteudoTxt, novoConteudoTxt;

      if (checkBox1.Checked == true)
      {
        Cont = 0;
        foreach (var listBoxItem in listBox1.Items)
        {
          try
          {

            //Pegar o caminho do arquivo escolhido
            string caminhoAbrir = listBoxItem.ToString();

            conteudoTxt = File.ReadAllText(caminhoAbrir);
            textBox1.Text = conteudoTxt;
            //Faz as substituições
            novoConteudoTxt = conteudoTxt.Replace(EditFind1.Text, EditReplace1.Text);

            //###### Salva o txt com os valores substituídos onde o usuário escolher ######//
            try
            {

              //Pegar o caminho do arquivo que ele criou
              string caminhoSalvar = listBoxItem.ToString();
              //Salvar todo o texto no caminho do arquivo escolhido
              File.WriteAllText(caminhoSalvar, novoConteudoTxt);
              //Mostrar confirmação
              Cont += 1;
              label1.Text = "Alterados: " + Cont.ToString();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
              //listBox2.Items.Add(listBoxItem.ToString());
            };
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message);
            listBox2.Items.Add(listBoxItem.ToString());
          };

        }
        MessageBox.Show("Todos os arquivos do List Box foram alterados!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        try
        {
          //Pegar o caminho do arquivo escolhido
          string caminhoAbrir = listBox1.SelectedItem.ToString();

          conteudoTxt = File.ReadAllText(caminhoAbrir);
          textBox1.Text = conteudoTxt;
          //Faz as substituições
          novoConteudoTxt = conteudoTxt.Replace(EditFind1.Text, EditReplace1.Text);

          //###### Salva o txt com os valores substituídos onde o usuário escolher ######//
          try
          {

            //Pegar o caminho do arquivo que ele criou
            string caminhoSalvar = listBox1.SelectedItem.ToString();
            //Salvar todo o texto no caminho do arquivo escolhido
            File.WriteAllText(caminhoSalvar, novoConteudoTxt);
            //Mostrar confirmação
            Cont += 1;
            label1.Text = "Alterados: " + Cont.ToString();
          }
          catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); };

      }
    }

    private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
      {
        button3_Click(sender, e);

      }
    }

  }
}

