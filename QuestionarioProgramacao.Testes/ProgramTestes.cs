using NUnit.Framework;
using System.IO;

namespace QuestionarioProgramacao.Testes
{
    [TestFixture]
    public class ProgramTestes
    {
        [Test]
        public void DevoCopiarImagens()
        {
            //string destino = CopiarImagens.Executar();
            CopiarImagens.Executar("pastaTeste");

            // Verifica se a pasta com o nome informado pelo usuário existe
            DirectoryAssert.Exists(@"C:/pastaTeste");

            // Verifica se as imagens foram copiadas
            DirectoryInfo di = new DirectoryInfo(@"C:/pastaTeste");
            Assert.That(di.GetFiles().Length > 0);
        }
    }
}
