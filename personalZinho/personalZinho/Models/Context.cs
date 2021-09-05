using PCLExt.FileStorage.Folders;
using SQLite;

namespace personalZinho.Models
{
    public class Context
    {
        public SQLiteConnection conexao;
        public Context()
        {
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile("appPersonalzinho.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            conexao = new SQLiteConnection(arquivo.Path);
            conexao.CreateTable<Aluno>();

        }

        public void Inserir<T>(T model)
        {
            conexao.Insert(model);
        }

        public void Atualizar<T>(T model)
        {
            conexao.Update(model);
        }

        public void Deletar<T>(T model)
        {
            conexao.Delete(model);
        }
    }
}
