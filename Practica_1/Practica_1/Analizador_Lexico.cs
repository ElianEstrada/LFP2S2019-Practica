using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_1
{
    class Analizador_Lexico
    {

        private LinkedList<Token> salida;
        private int estado;
        private String lexAux;

        private static int fila = 1;


        public LinkedList<Token> getLista()
        {
            return salida;
        }
        public void setFila(int inicio)
        {
            fila = inicio;
        }

        public LinkedList<Token> escanear(String entrada)
        {
            entrada = entrada + "#";
            salida = new LinkedList<Token>();
            estado = 0;
            lexAux = "";
            Char c;

            for(int i = 0; i < entrada.Length; i++)
            {
                c = entrada.ElementAt(i);

                switch (estado)
                {
                    case 0:
                        if (c.Equals('P') || c.Equals('p'))
                        {
                            estado = 1;
                            lexAux += c;
                        } else if (c.Equals('A') || c.Equals('a'))
                        {
                            estado = 13;
                            lexAux += c;
                        } else if (c.Equals('M') || c.Equals('m'))
                        {
                            estado = 17;
                            lexAux += c;
                        } else if (c.Equals('D') || c.Equals('d'))
                        {
                            estado = 20;
                            lexAux += c;
                        } else if (c.Equals('I') || c.Equals('i'))
                        {
                            estado = 33;
                            lexAux += c;
                        } else if (Char.IsDigit(c))
                        {
                            estado = 39;
                            lexAux += c;
                        } else if (c.Equals('"'))
                        {
                            estado = 40;
                        } else if (c.CompareTo('[') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.CORCHETE_IZQ, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo('{') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.LLAVES_IZQ, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo('<') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.SIGNO_MENOR_QUE, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo(']') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.CORCHETE_DER, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo('}') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.LLAVES_DER, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo('>') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.SIGNO_MAYOR_QUE, lexAux, fila);
                            lexAux = "";
                        } else if (c.CompareTo(':') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.SIGNO_DOS_PUNTOS, lexAux, fila);
                            lexAux = "";
                        }
                        else if(c.CompareTo(';') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.SIGNO_PUNTO_Y_COMA, lexAux, fila);
                            lexAux = "";
                        }else if (c.CompareTo('\n') == 0)
                        {
                            estado = 0;
                            fila += 1;
                        }else if(c.Equals(' '))
                        {
                            estado = 0;
                        }else if(c.CompareTo('(') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.PARENTESIS_IZQ, lexAux, fila);
                            lexAux = "";
                        }else if(c.CompareTo(')') == 0)
                        {
                            lexAux += c;
                            agregarToken(Token.Tipo.PARENTESIS_DER, lexAux, fila);
                            lexAux = "";
                        }
                        else
                        {
                            if (c.Equals('#') && i == entrada.Length-1)
                            {
                                System.Windows.Forms.MessageBox.Show("Analisis Exitoso");
                            } else
                            {
                                lexAux += c;
                                agregarToken((Token.Tipo)14, Char.ConvertFromUtf32(c), fila);
                                lexAux = "";
                                estado = 0;
                            }
                        }
                        break;
                    case 1:
                        if (c.Equals('L') || c.Equals('l'))
                        {
                            estado = 2;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            lexAux = "";
                            estado = 0;
                            i -= 1;
                        }
                        break;
                    case 2:
                        if(c.Equals('A') || c.Equals('a'))
                        {
                            estado = 3;
                            lexAux += c;
                        }else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            lexAux = "";
                            estado = 0;
                            i -= 1;
                        }
                        break;
                    case 3:
                        if(c.Equals('N') || c.Equals('n'))
                        {
                            estado = 4;
                            lexAux += c;
                        }else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 4:
                        if(c.Equals('I') || c.Equals('i'))
                        {
                            estado = 5;
                            lexAux += c;
                        }else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 5:
                        if (c.Equals('F') || c.Equals('f'))
                        {
                            estado = 6;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 6:
                        if (c.Equals('I') || c.Equals('i'))
                        {
                            estado = 7;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 7:
                        if (c.Equals('C') || c.Equals('c'))
                        {
                            estado = 8;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 8:
                        if (c.Equals('A') || c.Equals('a'))
                        {
                            estado = 9;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 9:
                        if (c.Equals('D') || c.Equals('d'))
                        {
                            estado = 10;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux,fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 10:
                        if (c.Equals('O') || c.Equals('o'))
                        {
                            estado = 11;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 11:
                        if (c.Equals('R') || c.Equals('r'))
                        {
                            estado = 12;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 12:
                        agregarToken((Token.Tipo.PALABRA_RESERVADA), lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                    case 13:
                        if(c.Equals('N') || c.Equals('n')){
                            estado = 14;
                            lexAux += c;
                        }
                        else{
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 14:
                        if (c.Equals('I') || c.Equals('i')){
                            estado = 15;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 15:
                        if (c.Equals('O') || c.Equals('o')){
                            estado = 16;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 16:
                        agregarToken(Token.Tipo.PALABRA_RESERVADA, lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                    case 17:
                        if(c.Equals('E') || c.Equals('e'))
                        {
                            estado = 18;
                            lexAux += c;
                        }else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 18:
                        if (c.Equals('S') || c.Equals('s'))
                        {
                            estado = 19;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 19:
                        agregarToken(Token.Tipo.PALABRA_RESERVADA, lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                    case 20:
                        if (c.Equals('I') || c.Equals('i'))
                        {
                            estado = 21;
                            lexAux += c;
                        }else if (c.Equals('E') || c.Equals('e'))
                        {
                            estado = 23;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 21:
                        if (c.Equals('A') || c.Equals('a'))
                        {
                            estado = 22;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 22:
                        agregarToken(Token.Tipo.PALABRA_RESERVADA, lexAux, fila);
                        estado = 0;
                        lexAux = "";
                        i -= 1;
                        break;
                    case 23:
                        if (c.Equals('S') || c.Equals('s'))
                        {
                            estado = 24;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 24:
                        if (c.Equals('C') || c.Equals('c'))
                        {
                            estado = 25;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 25:
                        if (c.Equals('R') || c.Equals('r'))
                        {
                            estado = 26;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 26:
                        if (c.Equals('I') || c.Equals('i'))
                        {
                            estado = 27;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 27:
                        if (c.Equals('P') || c.Equals('p'))
                        {
                            estado = 28;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 28:
                        if (c.Equals('C') || c.Equals('c'))
                        {
                            estado = 29;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 29:
                        if (c.Equals('I') || c.Equals('i'))
                        {
                            estado = 30;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 30:
                        if (c.Equals('O') || c.Equals('o'))
                        {
                            estado = 31;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 31:
                        if (c.Equals('N') || c.Equals('n'))
                        {
                            estado = 32;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 32:
                        agregarToken(Token.Tipo.PALABRA_RESERVADA, lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                    case 33:
                        if (c.Equals('M') || c.Equals('m'))
                        {
                            estado = 34;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 34:
                        if (c.Equals('A') || c.Equals('a'))
                        {
                            estado = 35;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 35:
                        if (c.Equals('G') || c.Equals('g'))
                        {
                            estado = 36;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 36:
                        if (c.Equals('E') || c.Equals('e'))
                        {
                            estado = 37;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 37:
                        if (c.Equals('N') || c.Equals('n'))
                        {
                            estado = 38;
                            lexAux += c;
                        }
                        else
                        {
                            agregarToken((Token.Tipo)14, lexAux, fila);
                            estado = 0;
                            lexAux = "";
                            i -= 1;
                        }
                        break;
                    case 38:
                        agregarToken(Token.Tipo.PALABRA_RESERVADA, lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                    case 39:
                        if (Char.IsDigit(c))
                        {
                            lexAux += c;
                        }else
                        {
                            agregarToken(Token.Tipo.NUMERO, lexAux, fila);
                            estado = 0;
                            i -= 1;
                            lexAux = "";
                        }
                        break;
                    case 40:
                        if(c.Equals('\n'))
                        {
                            fila += 1;
                        }else
                        {
                            lexAux += c;
                            estado = 41;
                        }
                        break;
                    case 41:
                        if (c.CompareTo('"') == 0)
                        {
                            estado = 42;
                        }else if(c.CompareTo('\n') == 0)
                        {
                            fila += 1;
                            lexAux += c;
                        }else
                        {
                            lexAux += c;
                        }
                        break;
                    case 42:
                        agregarToken(Token.Tipo.CADENA_DE_TEXTO, lexAux, fila);
                        estado = 0;
                        i -= 1;
                        lexAux = "";
                        break;
                }
            }

            return salida;
        }

        public void agregarToken(Token.Tipo tipo, String lexema, int noFila)
        {
            salida.AddLast(new Token(tipo, lexema, noFila));
        }


        public void imprimir(LinkedList<Token> lista)
        {
            
            int contador = 0;
            String contenido = "<html>\n <head> <title> Lista de Tokens </title> </head>\n <body bgcolor = \"black\"; text = \"white\";>\n <p> <h1> <center> Tabla de Tokens </center> </h1> </p> \n<table border = \"1\"> \n"
                + "<tr>\n <th> # </th>\n <th> Fila </th>\n <th> Lexema</th> \n <th> Tipo de Token </th>\n</tr>";

            foreach (Token item in lista)
            {
                if (item.getTipoToken().Equals("DESCONOCIDO"))
                {
                    continue;
                }
                else
                {
                    contador++;
                    String concatener = "<tr>\n <td>" + contador + "</td>\n <td>" + item.getFila() + "</td>\n <td>" + item.getLexema() + "</td>\n <td>" + item.getTipoToken() + "</td>\n </tr>";
                    contenido += concatener;
                }
            }

            File.WriteAllText("Archivos\\Tokens.html", contenido);

        }

        public void imprimirErrores(LinkedList<Token> lista)
        {
            int contador = 0;
            String contenido = "<html>\n <head> <title> Lista de Errores </title> </head>\n <body bgcolor = \"black\"; text = \"white\";>\n <p> <h1> <center> Tabla de Errores </center> </h1> </p> \n<table border = \"1\"> \n"
                + "<tr>\n <th> # </th>\n <th> Fila </th>\n <th> Caracter </th> \n <th> Descripción </th>\n</tr>";

            foreach (Token item in lista)
            {
                if (item.getTipoToken().Equals("DESCONOCIDO"))
                {
                    contador++;
                    String concatener = "<tr>\n <td>" + contador + "</td>\n <td>" + item.getFila() + "</td>\n <td>" + item.getLexema() + "</td>\n <td>" + item.getTipoToken() + "</td>\n </tr>";
                    contenido += concatener;
                }
                else
                {
                    continue;
                }
            }

            File.WriteAllText("Archivos\\Errores.html", contenido);
        }

       
    }
}
