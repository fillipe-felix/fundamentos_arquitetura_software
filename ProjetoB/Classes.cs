using ProjetoA;

namespace ProjetoB
{
    public class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada();
            //var interna = new Interna();
            //var abstrata = new Abstrat();
        }
    }
    
    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            // publica.TesteInternal();
            // publica.TesteProtegidoInterno();
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
            TesteProtegidoInterno();
            TesteProtegido();
            // TestePrivadoProtegido();
            // TesteInternal();
            //TestePrivado();
        }
    }
}