using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appGeraClasses.ModelAttribute
{
    public class csModelAttribute
    {
        public string strAttribute =
            "		public static string [nmAttribute]" + "\n" +
            "        {" + "\n" +
            "            get { return \"[nmAttribute]\"; }" + "\n" +
            "        }";

        public string strModelAttribute =
            "using System;" + "\n" +
            "using System.Collections.Generic;" + "\n" +
            "using System.Linq;" + "\n" +
            "using System.Text;" + "\n" +
            "" + "\n" +
            "namespace [NameSpaceModel]" + "\n" +
            "{" + "\n" +
            "    public static class ca[Table]" + "\n" +
            "    {" + "\n" +
            "        private static string _strFields = \"\";" + "\n" +
            "        public static string strFields" + "\n" +
            "        {" + "\n" +
            "            get { return _strFields; }" + "\n" +
            "            set { _strFields = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        private static string _strVisivel = \"\";" + "\n" +
            "        public static string strVisivel" + "\n" +
            "        {" + "\n" +
            "            get { return _strVisivel; }" + "\n" +
            "            set { _strVisivel = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        private static string _strNome = \"\";" + "\n" +
            "        public static string strNome" + "\n" +
            "        {" + "\n" +
            "            get { return _strNome; }" + "\n" +
            "            set { _strNome = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        private static bool _bGeraChave = [GeraChave];" + "\n" +
            "        public static bool bGeraChave" + "\n" +
            "        {" + "\n" +
            "            get { return ca[Table]._bGeraChave; }" + "\n" +
            "            set { ca[Table]._bGeraChave = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        private static bool _bControlaTransacao = [ControlaTransacao];" + "\n" +
            "        public static bool bControlaTransacao" + "\n" +
            "        {" + "\n" +
            "            get { return ca[Table]._bControlaTransacao; }" + "\n" +
            "            set { ca[Table]._bControlaTransacao = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        public static string CC_cdRegistro" + "\n" +
            "        {" + "\n" +
            "            get { return \"CC_cdRegistro\"; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        public static string nmTabela" + "\n" +
            "        {" + "\n" +
            "            get { return \"[Upper|Table]\"; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        public static string nmCampoChave" + "\n" +
            "        {" + "\n" +
            "            get { return \"[PK]\"; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        public static string dePrincipal" + "\n" +
            "        {" + "\n" +
            "            get { return \"[DescPrinc]\"; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        public static string deChaveComposta" + "\n" +
            "        {" + "\n" +
            "            get { return \"[ChComposta]\"; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "		/// <summary>" + "\n" +
            "		/// Atributos" + "\n" +
            "	 	/// </summary>" +
            "        [Attribute]" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Retorna os fields para montar DataGridView" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <param name=\"strFields\"></param>" + "\n" +
            "        /// <param name=\"strVisivel\"></param>" + "\n" +
            "        /// <param name=\"strNome\"></param>" + "\n" +
            "        public static void RetornarFields()" + "\n" +
            "        {" + "\n" +
            "            _strFields = CC_cdRegistro  + \",\" + [strFields];" + "\n" +
            "" + "\n" +
            "            _strNome = \"Cd. Registro, [strNameFields]\";" + "\n" +
            "" + "\n" +
            "            _strVisivel = \"0, [strVisibleFields]\";" + "\n" +
            "        }" + "\n" +
            "    }" + "\n" +
            "}";
    }
}
