using System.Runtime.CompilerServices;

//[assembly:InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        public void TestePublico()
        {
        }

        private void TestePrivado()
        {
        }

        internal void TesteInternal()
        {
        }

        protected void TesteProtegido()
        {
        }

        private protected void TestePrivadoProtegido()
        {
        }

        protected internal void TesteProtegidoInterno()
        {
        }
    }

    /// <summary>
    /// Não pode ser herdada, pode apenas ser instanciada
    /// </summary>
    public sealed class Selada
    {
    }

    /// <summary>
    /// Quando passa apenas class ela é privada
    /// </summary>
    class Privada
    {
    }


    internal class Interna
    {
    }

    /// <summary>
    /// Classe abstrata não pode ser instanciada, pode ser apenas herdada
    /// </summary>
    abstract class Abstrata
    {
    }

    #endregion

    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido);
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegidoInterno();
            TesteProtegido();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion


    /**************************************************************************/
    // public:

    // Access is not restricted.
    /**************************************************************************/
    // protected: 

    // Access is limited to the containing class or types
    // derived from the containing class
    /**************************************************************************/
    // internal:

    //Access is limited to the current assembly
    /**************************************************************************/
    // protected internal:

    // Access is limited to the current assembly or types
    // derived from the containing class
    /**************************************************************************/
    // private:

    // Access is limited to the containing type
    /**************************************************************************/
    // private protected:

    // Access is limited to the containing class or type
    // derived from the containing class within the current
    // assembly.Avaible since C# 7.2
    /**************************************************************************/
}