using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_POS_NHZ.clases
{
    class C_usuarios
    {

        static private string _cod_usuario = "";
        static private string _codigo_grupo = "";
        static private string _usuario = "";
        static private string _clave = "";
        static private string _nombres = "";

        public C_usuarios()
        {
            _cod_usuario = "";
            _codigo_grupo = "";
            _usuario = "";
            _clave = "";
            _nombres = "";
        }

        static public string cod_usuario
        {
            get { return _cod_usuario; }
            set { _cod_usuario = value; }
        }
        static public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        static public string codigo_grupo
        {
            get { return _codigo_grupo; }
            set { _codigo_grupo = value; }
        }

        static public string clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        static public string nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
    }
}
