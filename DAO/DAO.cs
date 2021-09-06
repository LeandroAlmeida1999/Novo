using ConsoleApp2.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp2.DAO
{
   public class DAO
    {
        public static int GetQtdArquives()
        {
            return 1;
        }
        public static string TransformarString(string Input)
        {
            string result = Input;

            result = Regex.Replace(result, "[@,\\.\";'\\\\: /]", string.Empty);
            return result.ToUpper();
        }

        public static Produto GetProduto()
        {
            return Produto.Outros;
        }

        public static ModalidadeDoCartao GetModalidadeDoCartao()
        {
            return ModalidadeDoCartao.H;
        }

        public static Funcao GetFuncao()
        {
            return Funcao.C;
        }

        public static Bandeira GetBandeira()
        {
            return Bandeira.Elo;
        }
    }
}
