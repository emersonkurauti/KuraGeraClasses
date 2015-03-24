using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;

namespace appGeraClasses
{
    class csBanco
    {
        private static volatile csBanco instance;

        private string _strStringConexao = "";
        public string strStringConexao
        {
            get { return _strStringConexao; }
            set { _strStringConexao = value; }
        }

        /// <summary>
        /// Variável de conexão com o SGBD
        /// </summary>
        private OracleConnection _conexao;

        /// <summary>
        /// Variável de comando do sql
        /// </summary>
        private OracleCommand _comando;

        /// <summary>
        /// Create do banco de dados
        /// </summary>
        private csBanco()
        {
            _strStringConexao = "Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = XE))); User Id=SansERP; Password=SansERP";
            _conexao = new OracleConnection(_strStringConexao);
            _comando = new OracleCommand();
            _comando = _conexao.CreateCommand();
        }

        /// <summary>
        /// Instancia do banco
        /// </summary>
        public static csBanco Instance
        {
            get
            {
                if (instance == null)
                    instance = new csBanco();

                return instance;
            }
        }

        /// <summary>
        /// Conecta no banco de dados
        /// </summary>
        /// <returns></returns>
        public bool ConectaBanco()
        {
            try
            {
                if (_conexao.State == ConnectionState.Closed)
                    _conexao.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Desconecta do banco de dados
        /// </summary>
        /// <returns></returns>
        public bool DesconectaBanco()
        {
            try
            {
                _conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna true para caso o campo passado por parâmetro necessite usar aspas para utilização no banco de dados
        /// </summary>
        /// <param name="nmTabela"></param>
        /// <param name="nmCampo"></param>
        /// <returns></returns>
        public OracleDataAdapter RetornaCamposTabela(string nmTabela)
        {
            OracleDataAdapter dtaTabela = new OracleDataAdapter();

            dtaTabela = RetornaDA("SELECT UTC.COLUMN_NAME AS NOME, UTC.DATA_TYPE AS TIPO, UTC.DATA_PRECISION AS PRECISAO, " +
                                  "       CASE WHEN (CPK.CONSTRAINT_TYPE = 'P') THEN " +
                                  "          'S' " +
                                  "       ELSE " +
                                  "          'N' " +
                                  "       END AS CHAVE, " +
                                  "       CASE WHEN (CPFK.CONSTRAINT_TYPE = 'C' AND CPRK.CONSTRAINT_TYPE <> 'R') THEN  " +
                                  "          'S' " +
                                  "       ELSE " +
                                  "          'N' " +
                                  "       END AS CHCOMPOSTA, " +
                                  "       CASE WHEN UTC.DATA_TYPE = 'VARCHAR' OR UTC.DATA_TYPE = 'VARCHAR2' THEN " +
                                  "            'STRING'" +
                                  "       WHEN UTC.DATA_TYPE = 'NUMBER' THEN" +
                                  "             'INT'" +
                                  "       WHEN UTC.DATA_TYPE = 'DATE' THEN" +
                                  "             'DATETIME'" +
                                  "       END AS TPVARIAVEL," +
                                  "       'N' AS DEPRINCIPAL, " +
                                  "       SUBSTR(LOWER(UTC.COLUMN_NAME),1,2) || SUBSTR(UPPER(UTC.COLUMN_NAME),3,1) || SUBSTR(LOWER(UTC.COLUMN_NAME),4,LENGTH(UTC.COLUMN_NAME)) AS NOMECLASSE " +
                                  "  FROM USER_TAB_COLUMNS UTC " +
                                  "  LEFT JOIN (SELECT CL.TABLE_NAME, CL.COLUMN_NAME, CONS.CONSTRAINT_TYPE " +
                                  "               FROM DBA_CONS_COLUMNS CL " +
                                  "              INNER JOIN DBA_CONSTRAINTS CONS ON CONS.CONSTRAINT_NAME = CL.CONSTRAINT_NAME" +
                                  "              WHERE CONS.CONSTRAINT_TYPE = 'P') CPK ON CPK.COLUMN_NAME = UTC.COLUMN_NAME " +
                                  "                                                   AND CPK.TABLE_NAME = UTC.TABLE_NAME " +
                                  "  LEFT JOIN (SELECT CL.TABLE_NAME, CL.COLUMN_NAME, CONS.CONSTRAINT_TYPE " +
                                  "               FROM DBA_CONS_COLUMNS CL " +
                                  "              INNER JOIN DBA_CONSTRAINTS CONS ON CONS.CONSTRAINT_NAME = CL.CONSTRAINT_NAME" +
                                  "              WHERE CONS.CONSTRAINT_TYPE = 'C') CPFK ON CPFK.COLUMN_NAME = UTC.COLUMN_NAME " +
                                  "                                                               AND CPFK.TABLE_NAME = UTC.TABLE_NAME " +
                                  "  LEFT JOIN (SELECT CL.TABLE_NAME, CL.COLUMN_NAME, CONS.CONSTRAINT_TYPE " +
                                  "               FROM DBA_CONS_COLUMNS CL " +
                                  "              INNER JOIN DBA_CONSTRAINTS CONS ON CONS.CONSTRAINT_NAME = CL.CONSTRAINT_NAME " +
                                  "              WHERE CONS.CONSTRAINT_TYPE = 'R') CPRK ON CPRK.COLUMN_NAME = UTC.COLUMN_NAME " +
                                  "                                                    AND CPRK.TABLE_NAME = UTC.TABLE_NAME " +
                                  " WHERE UTC.TABLE_NAME = UPPER('" + nmTabela + "')");

            //dtaTabela = RetornaDA("SELECT UTC.COLUMN_NAME AS NOME, UTC.DATA_TYPE AS TIPO, UTC.DATA_PRECISION AS PRECISAO, CPK.CONSTRAINT_TYPE AS CHAVE,"+
            //                      "       CPFK.CONSTRAINT_TYPE AS CHCOMPOSTA,"+
            //                      "       CASE WHEN UTC.DATA_TYPE = 'VARCHAR' OR UTC.DATA_TYPE = 'VARCHAR2' THEN "+
            //                      "            'STRING'"+
            //                      "       WHEN UTC.DATA_TYPE = 'NUMBER' THEN"+
            //                      "             'INT'"+
            //                      "       WHEN UTC.DATA_TYPE = 'DATE' THEN"+
            //                      "             'DATETIME'"+
            //                      "       END AS TPVARIAVEL"+
            //                      "  FROM USER_TAB_COLUMNS UTC "+
            //                      "  LEFT JOIN (SELECT CL.TABLE_NAME, CL.COLUMN_NAME, CONS.CONSTRAINT_TYPE "+
            //                      "               FROM DBA_CONS_COLUMNS CL "+
            //                      "              INNER JOIN DBA_CONSTRAINTS CONS ON CONS.CONSTRAINT_NAME = CL.CONSTRAINT_NAME"+
            //                      "              WHERE CONS.CONSTRAINT_TYPE = 'P') CPK ON CPK.COLUMN_NAME = UTC.COLUMN_NAME "+
            //                      "                                                   AND CPK.TABLE_NAME = UTC.TABLE_NAME "+
            //                      "  LEFT JOIN (SELECT CL.TABLE_NAME, CL.COLUMN_NAME, CONS.CONSTRAINT_TYPE "+
            //                      "               FROM DBA_CONS_COLUMNS CL "+
            //                      "              INNER JOIN DBA_CONSTRAINTS CONS ON CONS.CONSTRAINT_NAME = CL.CONSTRAINT_NAME"+
            //                      "              WHERE CONS.CONSTRAINT_TYPE <> 'P') CPFK ON CPFK.COLUMN_NAME = UTC.COLUMN_NAME " +
            //                      "                                                     AND CPFK.TABLE_NAME = UTC.TABLE_NAME " +
            //                      " WHERE UTC.TABLE_NAME = UPPER('" + nmTabela + "')");

            return dtaTabela;
        }

        /// <summary>
        /// Retorna DataTable com o select passado por parâmetro
        /// </summary>
        /// <param name="sSQL"></param>
        /// <returns></returns> 
        public DataTable RetornaDT(string sSQL)
        {
            DataTable dtDados = new DataTable();
            if (ConectaBanco())
            {
                _comando.CommandText = sSQL;
                dtDados.Load(_comando.ExecuteReader());
                DesconectaBanco();
            }
            return dtDados;
        }

        /// <summary>
        /// Retorna DataTable com o select passado por parâmetro
        /// </summary>
        /// <param name="sSQL"></param>
        /// <returns></returns>
        public OracleDataAdapter RetornaDA(string sSQL)
        {
            if (ConectaBanco())
            {
                _comando.CommandText = sSQL;
                OracleDataAdapter dtaDados = new OracleDataAdapter(_comando);
                //dtaDados.TableMappings.Add("Table", "Pessoa");
                DesconectaBanco();
                return dtaDados;
            }
            return null;            
        }
    }
}
