using personalZinho.Celulas;
using personalZinho.Models;
using System;
using System.Linq;
using Xamarin.Forms;


namespace personalZinho
{
    public partial class MainPage : ContentPage
    {
        public Context contexto;

        public MainPage()
        {
            InitializeComponent();
            contexto = new Context();
            ListagemAluno();
        }

        private void ListagemAluno()
        {
            ListagemAlunos.ItemTemplate = new DataTemplate(typeof(CellAlunos));
            ListagemAlunos.ItemsSource = contexto.conexao.Query<Aluno>("select * From Aluno").ToList();
            ListagemAlunos.RowHeight = 30;
        }

        private void LimparDados()
        {
            entID.Text = "";
            entAluno.Text = "";
            entExercicio.Text = "";
            entSerie.Text = "";
            entIntervalo.Text = "";

            entRepet01.Text = "";
            entRepet02.Text = "";
            entRepet03.Text = "";
            entRepet04.Text = "";
            //entRepet05.Text = "0";
            //entRepet06.Text = "0";
            //entRepet07.Text = "0";
            //entRepet08.Text = "0";
            //entRepet09.Text = "0";
            //entRepet10.Text = "0";
            //entRepet11.Text = "0";
            //entRepet12.Text = "0";

            entCarga01.Text = "";
            entCarga02.Text = "";
            entCarga03.Text = "";
            entCarga04.Text = "";
            //entCarga05.Text = "0";
            //entCarga06.Text = "0";
            //entCarga07.Text = "0";
            //entCarga08.Text = "0";
            //entCarga09.Text = "0";
            //entCarga10.Text = "0";
            //entCarga11.Text = "0";
            //entCarga12.Text = "0";

        }

        private void salvarDados(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(entAluno.Text))
                {
                    DisplayAlert("Erro", "Informe o nome do ALuno", "OK");
                    return;
                }

                if (string.IsNullOrEmpty(entExercicio.Text))
                {
                    DisplayAlert("Erro", "Informe o exercício", "OK");
                    return;
                }

                Aluno aluno = AddAluno();

                contexto.Inserir(aluno);
                DisplayAlert("Sucesso", "Aluno e Exercicio inserido com sucesso!", "OK");
                ListagemAluno();

            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }



        private void AtualizarDados(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(entAluno.Text))
                {
                    DisplayAlert("Erro", "Informe o nome do ALuno", "OK");
                    return;
                }

                if (string.IsNullOrEmpty(entExercicio.Text))
                {
                    DisplayAlert("Erro", "Informe o exercício", "OK");
                    return;
                }

                Aluno aluno = AddAluno();

                contexto.Atualizar(aluno);

                DisplayAlert("Sucesso", "Aluno e Exercicio Atualizado com sucesso!", "OK");
                ListagemAluno();


            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }



        private void apagarDados(object sender, EventArgs e)
        {
            try
            {
                if (entID.Text != "0")
                {
                    contexto.conexao.Execute($"Delete from Aluno where ID = {entID.Text}");
                    DisplayAlert("Sucesso!", "Aluno e exercício Deletado com sucesso!", "OK");
                    ListagemAluno();
                    LimparDados();
                }
                else
                    DisplayAlert("Erro!", "Selecione um aluno na Lista", "OK");

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void exportarDados(object sender, EventArgs e)

        {



        }

        private void ListagemAlunos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var Aluno = (Aluno)e.SelectedItem;
                entID.Text = Aluno.ID.ToString();
                entAluno.Text = Aluno.Nome;
                entExercicio.Text = Aluno.Exercicio;
                entSerie.Text = Aluno.Series.ToString();
                entIntervalo.Text = Aluno.Intervalo.ToString();

                entRepet01.Text = Aluno.Rep01.ToString();
                entRepet02.Text = Aluno.Rep02.ToString();
                entRepet03.Text = Aluno.Rep03.ToString();
                entRepet04.Text = Aluno.Rep04.ToString();
                entRepet05.Text = Aluno.Rep05.ToString();
                entRepet06.Text = Aluno.Rep06.ToString();
                entRepet07.Text = Aluno.Rep07.ToString();
                entRepet08.Text = Aluno.Rep08.ToString();
                entRepet09.Text = Aluno.Rep09.ToString();
                entRepet10.Text = Aluno.Rep10.ToString();
                entRepet11.Text = Aluno.Rep11.ToString();
                entRepet12.Text = Aluno.Rep12.ToString();

                entCarga01.Text = Aluno.Carga01.ToString();
                entCarga02.Text = Aluno.Carga02.ToString();
                entCarga03.Text = Aluno.Carga03.ToString();
                entCarga04.Text = Aluno.Carga04.ToString();
                entCarga05.Text = Aluno.Carga05.ToString();
                entCarga06.Text = Aluno.Carga06.ToString();
                entCarga07.Text = Aluno.Carga07.ToString();
                entCarga08.Text = Aluno.Carga08.ToString();
                entCarga09.Text = Aluno.Carga09.ToString();
                entCarga10.Text = Aluno.Carga10.ToString();
                entCarga11.Text = Aluno.Carga11.ToString();
                entCarga12.Text = Aluno.Carga12.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("ERRO", ex.Message, "OK");
            }
        }

        // método para adicionar e atualizar alunos
        private Aluno AddAluno()
        {
            return new Aluno()
            {
                ID = int.Parse(entID.Text),
                Nome = entAluno.Text,
                Exercicio = entExercicio.Text,
                Series = int.Parse(entSerie.Text),
                Rep01 = int.Parse(entRepet01.Text),
                Rep02 = int.Parse(entRepet02.Text),
                Rep03 = int.Parse(entRepet03.Text),
                Rep04 = int.Parse(entRepet04.Text),
                Rep05 = int.Parse(entRepet05.Text),
                Rep06 = int.Parse(entRepet06.Text),
                Rep07 = int.Parse(entRepet07.Text),
                Rep08 = int.Parse(entRepet08.Text),
                Rep09 = int.Parse(entRepet09.Text),
                Rep10 = int.Parse(entRepet10.Text),
                Rep11 = int.Parse(entRepet11.Text),
                Rep12 = int.Parse(entRepet12.Text),
                Carga01 = int.Parse(entCarga01.Text),
                Carga02 = int.Parse(entCarga02.Text),
                Carga03 = int.Parse(entCarga03.Text),
                Carga04 = int.Parse(entCarga04.Text),
                Carga05 = int.Parse(entCarga05.Text),
                Carga06 = int.Parse(entCarga06.Text),
                Carga07 = int.Parse(entCarga07.Text),
                Carga08 = int.Parse(entCarga08.Text),
                Carga09 = int.Parse(entCarga09.Text),
                Carga10 = int.Parse(entCarga10.Text),
                Carga11 = int.Parse(entCarga11.Text),
                Carga12 = int.Parse(entCarga12.Text),
                Intervalo = int.Parse(entIntervalo.Text)

            };
        }
    }
}
