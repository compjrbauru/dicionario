using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using dicionario.Model;

namespace dicionario
{
    public partial class frmImportaCsv : Form
    {
        public frmImportaCsv()
        {
            InitializeComponent();
        }

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            if (AbreArquivoDialog.ShowDialog() == DialogResult.OK)
            {
                LblArquivo.Text = AbreArquivoDialog.FileName;
                BtnStart.Enabled = true;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        //NOTE: Usar ponto e vírgula como separador no CSV
        {
            string linha;
            string[] divisor;
            progressBar1.MarqueeAnimationSpeed = 50;
            if (File.Exists(LblArquivo.Text))
            {
                StreamReader leitor = new StreamReader(LblArquivo.Text);
                try
                {
                    do
                    {
                        linha = leitor.ReadLine();
                        if (linha != "")
                        {
                            divisor = linha.Split(';');
                            for (int i = 0; i < divisor.GetLength(0); i++)
                            {
                                dataGridView1.Columns.Add(divisor[i], divisor[i]);
                            }
                        }
                    } while (linha == "");
                    do //implementar thread
                    {
                        linha = leitor.ReadLine();
                        if (linha != "")
                        {
                            divisor = linha.Split(';');
                            dataGridView1.Rows.Add(divisor);
                        }
                    } while (leitor.Peek() != -1);
                }
                catch (IndexOutOfRangeException) { }
                catch (EndOfStreamException) { }
                BtnStart.Enabled = false;
                BtnProcura.Enabled = false;
                BtnCancela.Enabled = true;
                BtnGrava.Enabled = true;
                ComboTable.Enabled = true;
                progressBar1.MarqueeAnimationSpeed = 0;
            }
        }

        private void BtnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar todos os dados não salvos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                progressBar1.MarqueeAnimationSpeed = 50;
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                BtnCancela.Enabled = false;
                BtnGrava.Enabled = false;
                BtnStart.Enabled = false;
                ComboTable.Enabled = false;
                BtnProcura.Enabled = true;
                LblArquivo.Text = "Nenhum arquivo selecionado";
                progressBar1.MarqueeAnimationSpeed = 0;
            }
        }

        private void LblArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private List<string> SanitizaValores(List<string> valores)
        { //função para trocar possíveis valores em string por suas respectivas FK
            switch (ComboTable.SelectedIndex)
            {
                case 0:
                    /*City city = new City();
                    if (valores.Count == 2)
                    {
                        city.Cidade = valores.First<string>();
                        string temp = valores.ElementAt(2);
                        if (int.TryParse(temp, out int val))
                        {
                            city.IDEstado = val;
                        }
                        else
                        {
                            ConectaBanco conecta = new ConectaBanco("bd", "usr", "pass");
                            Country country = new Country();
                            List<string>[] similares = conecta.Select("country", Country.ToStringTabelaLista(true), "country='" + temp);
                            try { city.IDEstado = Convert.ToInt32(similares[0].First<string>()); }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Nenhuma chave similar encontrada. Deixando como está.");
                            }

                        }
                    }*/
                    break;
            }
            return valores;
        }

        private void BtnGrava_Click(object sender, EventArgs e)
        {
            if (ComboTable.Text != "")
            {
                if (MessageBox.Show("Você tem certeza que deseja continuar?\n" + "Todos os dados da tabela serão salvos no Banco de Dados!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    importador(ComboTable.Text);

                }
            }
            else
            {
                MessageBox.Show("Escolha uma tabela destino");
            }
        }
        private void importador(string NomeTabela)
        {
            DataGridViewRow[] linhas = new DataGridViewRow[dataGridView1.Rows.Count];
            DataGridViewCell[] cell = new DataGridViewCell[dataGridView1.ColumnCount];
            List<string> ValoresLinha = new List<string>();
            ConectaBanco conBanco = new ConectaBanco("dicionario", "usuario", "senha");
            string temp;

            progressBar1.MarqueeAnimationSpeed = 50;
            BtnCancela.Enabled = false;
            BtnGrava.Enabled = false;
            BtnStart.Enabled = false;
            BtnProcura.Enabled = false;

            dataGridView1.Rows.CopyTo(linhas, 0);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                linhas[i].Cells.CopyTo(cell, 0);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    temp = Convert.ToString(cell[j].Value);
                    ValoresLinha.Add(temp);
                    ValoresLinha = SanitizaValores(ValoresLinha);
                }
                    switch (NomeTabela)
                    {
                    case "Palavra":
                        conBanco.InsereLinha(NomeTabela, Palavra.ToListTabela(), ValoresLinha);
                        break;
                    }

            }

            BtnProcura.Enabled = true;
            LblArquivo.Text = "Nenhum arquivo selecionado";
            progressBar1.MarqueeAnimationSpeed = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /* FLUXO DA IDEIA
             * Digitar sublema na caixa
             * clicar no botão
             * Verificar todas as palavras com mais de X caracteres
             * verificar se existe o lema analisado na base de dados
             * caso existir, então:
             * Verificar quantos lemas iguais existem.
             *  Caso = 1, atribuir este automaticamente
             *  caso > 1, perguntar qual o usuário deseja relacionar
             *  pegar o código do registro escolhido
             *  repor na string entre { }
             * repete até acabar a string analisada
             * coloca a string montada no lugar
             */
            /*
           string[] text = (textBox1.Text).Split(' ');
           label3.Text = "";
           for (int i = 0; i < text.Count<string>(); i++) {
               if (text[i].Length >= 3)
               {
                   ConectaBanco con = new ConectaBanco("bd", "user", "pass");

                   List<string>[] resultados = con.Select("city", City.ToStringTabelaLista(true), "city='" + Convert.ToString(text.GetValue(i)) + "'");
                   if (resultados[0].Count > 1) //se há mais de um código
                   {
                       List<City> city = new List<City>();
                       City temp = new City();
                       for (int j = 0; j < (resultados.Count()-1); j++) {
                           temp.IDCidade = Convert.ToInt32(resultados[0].ElementAt(j));
                           temp.Cidade = resultados[1].ElementAt(j);
                           temp.IDEstado = Convert.ToInt32(resultados[2].ElementAt(j));
                           temp.ultimaAtualizacao = Convert.ToDateTime(resultados[3].ElementAt(j));
                           city.Add(temp);
                           city.
                       }
                       popup_EscolheCelula Desco = new popup_EscolheCelula(city);
                       Desco.Show();
                       label3.Text += "{" + Desco.retorno.ToString() + "} ";
                   }
                   else {
                       try
                       {
                           label3.Text += "{" + resultados[0].ElementAt(0) + "} ";
                       }
                       catch (ArgumentOutOfRangeException) {
                           label3.Text += text[i];
                       }
                   }
               }
               else {
                   label3.Text += text[i] + " ";
               }*/
        }

    }
}

/*public class popup_EscolheCelula : Form
{
    private DataGridView DgvOpcoes;
    private Form popup;
    private Label lblDescreve;
    private Button BtnConfirma;
    public popup_EscolheCelula()
    {
        List<string> list = City.ToStringTabelaLista(true);
        popup = new Form
        {
            Size = new Size(640, 480),
            ShowInTaskbar = false,

            ControlBox = false,
            MaximizeBox = false,
            MinimizeBox = false
        };
        lblDescreve = new Label
        {
            Text = "Escolha um dos valores da lista a seguir para vincular ao sublema do verbete",
            AutoSize = true,
            Location = new Point(20, 20)
        };
        popup.Controls.Add(lblDescreve);
        BtnConfirma = new Button
        {
            Text = "Confirmar",
            Location = new Point(500, 400),
            AutoSize = true
        };
        BtnConfirma.Click += new EventHandler(EvClick);
        popup.Controls.Add(BtnConfirma);
        DgvOpcoes = new DataGridView();
        DgvOpcoes.MultiSelect = false;
        for (int t = 0; t < list.Count; t++)
        {
            DgvOpcoes.Columns.Add(list.ElementAt(t), list.ElementAt(t));
        }

        DgvOpcoes.Rows.Add();

        DgvOpcoes.Size = new Size(500, 380);
        DgvOpcoes.Location = new Point(20, 50);
        popup.Controls.Add(DgvOpcoes);

        popup.PerformLayout();
        popup.Update();
    }
    public int retorno { 
        get { return selecio; } 
    }
    private int selecio;

    private void EvClick(object sender, EventArgs e)
    {
        if (MessageBox.Show("Confirma seleção da linha?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
            DataGridViewSelectedCellCollection sel = DgvOpcoes.SelectedCells;
            DataGridViewCell c = sel[0];
            selecio = (int)c.Value;
            popup.Close();
        }

    }

}
}
*/
