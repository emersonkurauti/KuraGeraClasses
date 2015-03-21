using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SansERP.Geral.Model.[ContextModel];
using SansERP.Mensagem;
using System.Data;

namespace SansERP.Geral.Controller
{
    public class con[Table] : KuraFrameWork.ClasseBase.csControllerBase
    {
        private static co[Table] _objCo;
        public static co[Table]  objCo
        {
            get { return con[Table]._objCo[Table]; }
            set { con[Table]._objCo[Table] = value; }
        }

        private static co[Table] _objCo[Table];
        public co[Table] objCo[Table]
        {
            get { return _objCo[Table]; }
            set { _objCo[Table] = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public con[Table]()
        {
            _objCo[Table] = new co[Table]();
            _objCo = _objCo[Table];
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <returns></returns>
        public static bool Select()
        {
            _strMensagemErro = "";

            if (!_objCo[Table].Select(out _dtDados))
            {
                _strMensagemErro = csMensagem.msgConsultar;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Inserir
        /// </summary>
        /// <returns></returns>
        public static bool Inserir()
        {
            if (!_objCo[Table].Inserir())
            {
                _strMensagemErro = csMensagem.msgInserir;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Alterar
        /// </summary>
        /// <returns></returns>
        public static bool Alterar()
        {
            _strMensagemErro = "";

            if (!_objCo[Table].Alterar())
            {
                _strMensagemErro = csMensagem.msgAlterar;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Excluir
        /// </summary>
        /// <returns></returns>
        public static bool Excluir()
        {
            _strMensagemErro = "";

            if (!_objCo[Table].Excluir())
            {
                _strMensagemErro = csMensagem.msgRemover;
                return false;
            }
            return true;
        }
    }
}