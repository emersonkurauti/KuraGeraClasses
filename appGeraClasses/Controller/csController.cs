using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appGeraClasses.Controller
{
    public class csController
    {
        public string strController =
            "using System;" + "\n" +
            "using System.Collections.Generic;" + "\n" +
            "using System.Linq;" + "\n" +
            "using System.Text;" + "\n" +
            "using System.Data;" + "\n" +
            "using [NameSpaceModel];" + "\n" +
            "using [NameSpaceMensagem];" + "\n" +
            "" + "\n" +
            "namespace [NameSpaceController]" + "\n" +
            "{" + "\n" +
            "    public class con[Table] : KuraFrameWork.ClasseBase.csControllerBase" + "\n" +
            "    {" + "\n" +
            "        private static co[Table] _objCo;" + "\n" +
            "        public static co[Table]  objCo" + "\n" +
            "        {" + "\n" +
            "            get { return con[Table]._objCo[Table]; }" + "\n" +
            "            set { con[Table]._objCo[Table] = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        private static co[Table] _objCo[Table];" + "\n" +
            "        public co[Table] objCo[Table]" + "\n" +
            "        {" + "\n" +
            "            get { return _objCo[Table]; }" + "\n" +
            "            set { _objCo[Table] = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Construtor" + "\n" +
            "        /// </summary>" + "\n" +
            "        public con[Table]()" + "\n" +
            "        {" + "\n" +
            "            _objCo[Table] = new co[Table]();" + "\n" +
            "            _objCo = _objCo[Table];" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Select" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <returns></returns>" + "\n" +
            "        public static bool Select()" + "\n" +
            "        {" + "\n" +
            "            _strMensagemErro = \"\";" + "\n" +
            "" + "\n" +
            "            if (!_objCo[Table].Select(out _dtDados))" + "\n" +
            "            {" + "\n" +
            "                _strMensagemErro = csMensagem.msgConsultar;" + "\n" +
            "                return false;" + "\n" +
            "            }" + "\n" +
            "" + "\n" +
            "            return true;" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Inserir" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <returns></returns>" + "\n" +
            "        public static bool Inserir()" + "\n" +
            "        {" + "\n" +
            "            if (!_objCo[Table].Inserir())" + "\n" +
            "            {" + "\n" +
            "            _strMensagemErro = \"\";" + "\n" +
            "" + "\n" +
            "                _strMensagemErro = csMensagem.msgInserir;" + "\n" +
            "                return false;" + "\n" +
            "            }" + "\n" +
            "            return true;" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Alterar" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <returns></returns>" + "\n" +
            "        public static bool Alterar()" + "\n" +
            "        {" + "\n" +
            "            _strMensagemErro = \"\";" + "\n" +
            "" + "\n" +
            "            if (!_objCo[Table].Alterar())" + "\n" +
            "            {" + "\n" +
            "                _strMensagemErro = csMensagem.msgAlterar;" + "\n" +
            "                return false;" + "\n" +
            "            }" + "\n" +
            "            return true;" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Excluir" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <returns></returns>" + "\n" +
            "        public static bool Excluir()" + "\n" +
            "        {" + "\n" +
            "            _strMensagemErro = \"\";" + "\n" +
            "" + "\n" +
            "            if (!_objCo[Table].Excluir())" + "\n" +
            "            {" + "\n" +
            "                _strMensagemErro = csMensagem.msgRemover;" + "\n" +
            "                return false;" + "\n" +
            "            }" + "\n" +
            "            return true;" + "\n" +
            "        }" + "\n" +
            "    }" + "\n" +
            "}";
    } 
}
