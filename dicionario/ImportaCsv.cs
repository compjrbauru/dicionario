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
        CRUD operacoes = new CRUD();
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
                try
                {
                    StreamReader leitor = new StreamReader(LblArquivo.Text);
                    linha = leitor.ReadLine();
                    

                    try
                    {
                        do
                        {
                            linha = leitor.ReadLine();
                            if (linha != "")
                            {
                                divisor = linha.Split(';');
                                //varificar dimensao antes de prosseguir
                                if (divisor.Count() != Palavra.ToListTabela().Count)
                                {
                                    MessageBox.Show("A quantidade de colunas da entrada é diferente do destino.\nOperação Abortada.", "Erro fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    progressBar1.MarqueeAnimationSpeed = 0;
                                    BtnStart.Enabled = false;
                                    return;
                                }
                                List<string> ptlt = Palavra.ToListTabela(true);
                                for (int i = 0; i < divisor.GetLength(0); i++)
                                {
                                    if (divisor[i] == ptlt.ElementAt(i))
                                        dataGridView1.Columns.Add(divisor[i], divisor[i]);
                                    else
                                    {
                                        MessageBox.Show("A coluna " + divisor[i] + " do arquivo importado deveria ser nomeada " + ptlt.ElementAt(i) + ".\nOperação Abortada!");
                                        dataGridView1.Columns.Clear();
                                        return;
                                    }
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
                }
                catch (FileLoadException) {
                    return;
                }
                catch (FileNotFoundException) {
                    return;
                }
                catch (IOException)
                {
                    MessageBox.Show("O arquivo está inacessível no momento.\nTente novamente mais tarde.");
                    return;
                }
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

        private List<string> SanitizaValores(string tabela, List<string> valores)
        { //função para trocar possíveis valores em string por suas respectivas FK
            switch (tabela)
            {
                case "palavra":
                    Palavra teste = new Palavra();
                    try
                    {
                        teste = (Palavra)valores;
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Erro na conversão. Tipo de dado divergente.");
                    }
                    List<Rubrica> lrub = new List<Rubrica>();
                    List<ClasseGramatical> lclg = new List<ClasseGramatical>();
                    List<Referencia> lref = new List<Referencia>();
                    lrub = Rubrica.ConverteObject(operacoes.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), "Id="+ teste.rubrica.ToString()));
                    lclg = ClasseGramatical.ConverteObject(operacoes.SelecionarTabela("classegram", ClasseGramatical.ToListTabela(true), "id=" + teste.Id_classeGram.ToString()));
                    lref = Referencia.ConverteObject(operacoes.SelecionarTabela("referencias", Referencia.ToListTabela(true), "Id=" + teste.referencia_verbete.ToString()));
                    if (lrub.Count() > 0)
                    {
                        teste.rubrica = lrub.First().id;
                    }
                    if (lclg.Count() > 0)
                    {
                        teste.Id_classeGram = lclg.First().id;
                    }
                    if (lref.Count > 0)
                    {
                        teste.referencia_verbete = lref.First().id;
                    }
                    //criação das referências para o caso de pluriverbalidade
                    /*if (teste.lema.Contains(' '))
                    {
                        string[] lemas = teste.lema.Split(' ');
                        List<int> saidas = new List<int>();
                        diag_equivalente diag;
                        for (int i = 0; i < lemas.Count(); i++)
                        {
                            diag = new diag_equivalente(lemas[i]);
                            diag.ShowDialog();
                            if (diag.DialogResult == DialogResult.OK)
                                saidas.Add(diag.selecionado);
                            else
                                saidas.Add(-1);
                            diag.Dispose();
                        }
                        teste.EditRelacoesPluri(saidas);
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
                   
                }
                    switch (NomeTabela)
                    {
                    case "palavra":
                        ValoresLinha = SanitizaValores("palavra", ValoresLinha);
                        operacoes.InsereLinha(NomeTabela, Palavra.ToListTabela(), ValoresLinha);
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
