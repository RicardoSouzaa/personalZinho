using Xamarin.Forms;

namespace personalZinho.Celulas
{
    class CellAlunos : ViewCell
    {
        public CellAlunos()
        {
            var Nome = new Label
            {
                FontSize = 14,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start
            };
            Nome.SetBinding(Label.TextProperty, new Binding("Nome"));

            var Exercicio = new Label
            {
                FontSize = 14,
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.End
            };
            Exercicio.SetBinding(Label.TextProperty, new Binding("Exercicio"));

            var linha1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { Nome, Exercicio }
            };

            View = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { linha1 }
            };
        }
    }
}
