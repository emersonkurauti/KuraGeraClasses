using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appGeraClasses.ModelObject
{
    public class csModelObject
    {
        public string strAttribute =
            "		private static [Type] _[nmAttribute];" + "\n" +
            "        public [Type] [nmAttribute]" + "\n" +
            "        {" + "\n" +
            "            get { return _[nmAttribute]; }" + "\n" +
            "            set { _[nmAttribute] = value; }" + "\n" +
            "        }";

        public string strListaControllers = 
            "               con[TableCalc] objCon[TableCalc] = new con[TableCalc]();" + "\n";

        public string strAlteraReadyOnly_Length =
            "               dtDados.Columns[ca[Table].[CCAttribute]].ReadOnly = false;" + "\n" +
            "               dtDados.Columns[ca[Table].[CCAttribute]].MaxLength = 100;" + "\n";

        public string strPreparaControllerParaConsulta =
            "                   objCon[TableCalc].objCo[TableCalc].LimparAtributos();" + "\n" +
            "                   objCon[TableCalc].objCo[TableCalc].[CampoChave] = Convert.ToInt32(dr[ca[Table].[CampoChave]].ToString());" + "\n";

        public string strExecutaConsulta =
            "                   if (con[TableCalc].Select())" + "\n" +
            "                   {" + "\n" +
            "                       if (objCon[TableCalc].dtDados.Rows.Count > 0)" + "\n" +
            "                       {" + "\n" +
            "                           dr[ca[Table].[CCAttribute]] = objCon[TableCalc].dtDados.Rows[0][ca[TableCalc].[AttributeCalc]].ToString();" + "\n" +
            "                       }" + "\n" +
            "                   }" + "\n";

        public string strSelectCampoCalc =
            "		/// <summary>" + "\n" +
            "       /// Método sobrescrito por conta do campo calculado" + "\n" +
            "       /// </summary>" + "\n" +
            "       /// <param name=\"dtDados\"></param>" + "\n" +
            "       /// <returns></returns>" + "\n" +
            "       public override bool Select(out DataTable dtDados)" + "\n" +
            "       {" + "\n" +
            "           if (base.Select(out dtDados))" + "\n" +
            "           {" + "\n" +
            "               [ListaControllers]" + "\n" +
            "               DataTable dtAux = dtDados;" + "\n" +
            "" + "\n" +
            "               [AlteraReadyOnly_Length]" + "\n" +
            "" + "\n" +
            "               foreach (DataRow dr in dtAux.Rows)" + "\n" +
            "               {" + "\n" +
            "                   [PreparaControllerParaConsulta]" + "\n" +
            "" + "\n" +
            "                   [ExecutaConsulta]" + "\n" +
            "               }" + "\n" +
            "" + "\n" +
            "               dtDados = dtAux;" + "\n" +
            "           }" + "\n" +
            "           else" + "\n" +
            "               return false;" + "\n" +
            "" + "\n" +
            "           return true;" + "\n" +
            "       }";

        public string strModelObject =
            "using System;" + "\n" +
            "using System.Collections.Generic;" + "\n" +
            "using System.Linq;" + "\n" +
            "using System.Text;" + "\n" +
            "using System.Data;" + "\n" +
            "using [NameSpaceController];" + "\n" +
            "" + "\n" +
            "namespace [NameSpaceObjects]" + "\n" +
            "{" + "\n" +
            "    public class co[Table] : KuraFrameWork.ClasseBase.csModelBase" + "\n" +
            "    {" + "\n" +
            "        private static  int _CC_cdRegistro;" + "\n" +
            "        public static int CC_cdRegistro" + "\n" +
            "        {" + "\n" +
            "            get { return co[Table].[PK]; }" + "\n" +
            "            set { co[Table].[PK] = value; }" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "		/// <summary>" + "\n" +
            "		/// Atributos" + "\n" +
            "		/// </summary>" +
            "        [Attribute]" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Construtor" + "\n" +
            "        /// </summary>" + "\n" +
            "        public co[Table]()" + "\n" +
            "        {" + "\n" +
            "            AtualizaObj();" + "\n" +
            "            LimparAtributos();" + "\n" +
            "            _CC_cdRegistro = [PK];" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "		/// <summary>" + "\n" +
            "		/// Atributos" + "\n" +
            "		/// </summary>" +
            "	 	 [CampoCalculado]" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Sobrescrito para retornar a chave" + "\n" +
            "        /// </summary>" + "\n" +
            "        /// <returns></returns>" + "\n" +
            "        public override bool Inserir()" + "\n" +
            "        {" + "\n" +
            "            if (base.Inserir())" + "\n" +
            "            {" + "\n" +
            "                [PK] = objBanco.cdChave;" + "\n" +
            "                return true;" + "\n" +
            "            }" + "\n" +
            "" + "\n" +
            "            return false;" + "\n" +
            "        }" + "\n" +
            "" + "\n" +
            "        /// <summary>" + "\n" +
            "        /// Método para garantir a execução das instruções no objeto correto" + "\n" +
            "        /// </summary>" + "\n" +
            "        public override void AtualizaObj()" + "\n" +
            "        {" + "\n" +
            "            base.AtualizaObj();" + "\n" +
            "            objBanco.strCampoChave = ca[Table].nmCampoChave;" + "\n" +
            "            objBanco.strTabela = ca[Table].nmTabela;" + "\n" +
            "        }" + "\n" +
            "    }" + "\n" +
            "}";
    }
}
