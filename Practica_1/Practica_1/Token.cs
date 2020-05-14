using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Token
    {

        public enum Tipo
        {
            PALABRA_RESERVADA,
            CADENA_DE_TEXTO,
            NUMERO,
            CORCHETE_IZQ,
            CORCHETE_DER,
            LLAVES_IZQ,
            LLAVES_DER,
            SIGNO_MENOR_QUE,
            SIGNO_MAYOR_QUE,
            SIGNO_DOS_PUNTOS,
            SIGNO_PUNTO_Y_COMA,
            PARENTESIS_IZQ,
            PARENTESIS_DER
        }

        private Tipo tipoToken;
        private String lexema;
        private int fila;

        public Token(Tipo tipoToken, String lexema, int fila)
        {
            this.tipoToken = tipoToken;
            this.lexema = lexema;
            this.fila = fila;
        }

        public int getFila()
        {
            return fila;
        }

        public String getLexema()
        {
            return this.lexema;
        }

        public String getTipoToken()
        {
            switch (tipoToken)
            {
                case Tipo.PALABRA_RESERVADA:
                    return "PALABRA_RESERVADA";
                case Tipo.CADENA_DE_TEXTO:
                    return "CADENA_DE_TEXTO";
                case Tipo.NUMERO:
                    return "NÚMERO";
                case Tipo.CORCHETE_IZQ:
                    return "CORCHETE_ABRE";
                case Tipo.CORCHETE_DER:
                    return "CORCHETE_CIERRA";
                case Tipo.LLAVES_IZQ:
                    return "LLAVES_ABRE";
                case Tipo.LLAVES_DER:
                    return "LLAVES_CIERRA";
                case Tipo.SIGNO_MENOR_QUE:
                    return "SIGNO_MENOR_QUE";
                case Tipo.SIGNO_MAYOR_QUE:
                    return "SIGNO_MAYOR_QUE";
                case Tipo.SIGNO_DOS_PUNTOS:
                    return "SIGNO_DOS_PUNTOS";
                case Tipo.SIGNO_PUNTO_Y_COMA:
                    return "SIGNO_PUNTO_Y_COMA";
                case Tipo.PARENTESIS_IZQ:
                    return "PARENTESIS_ABRE";
                case Tipo.PARENTESIS_DER:
                    return "PARENTESIS_CIERRA";
                default:
                    return "DESCONOCIDO";
            }
        }

       

    }
}
