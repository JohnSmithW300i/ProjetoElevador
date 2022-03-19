using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    
        class Elevador
        {
            //Informa o limite de pessoas que podem entrar no elevador.
            public int PessoasLimite { get; set; }
            
            //Informa o andar em que o elevator está.          
            public int AndarAtual { get; set; }

            //Informa quantas pessoas estão no elevador no momento.
            public int PessoasElevador { get; set; }

            //Informa quantos andares o prédio possui.
            public int QuantidadeAndares { get; set; }

            //Inicializa o uso do Elevador solicitando a Capacidade de pessoas no elevador e o total de andares
            public void Inicializar(int capacidade, int andares)
            {
                PessoasLimite = capacidade;
                QuantidadeAndares = andares;
                
                //Informa o Andar atual como 0 = Térreo.
                AndarAtual = 0;

                //Informa a quantidade de pessoas no Elevador iniciando em 0.
                PessoasElevador = 0;
            }

            //Adiciona uma pessoa ao Elevador se houver espaço.
            public bool Entrar()
            {
                if (PessoasElevador < PessoasLimite)
                {
                    PessoasElevador++;
                    return true;
                }
                else
                    return false;


            }

            //Caso exista alguém no Elevador, remove uma pessoa.
            public bool Sair()
            {
                if (PessoasElevador > 0)
                {
                    PessoasElevador--;
                    return true;
                }
                else
                    return false;
            }

            //Sobe um andar, caso não esteja no último andar.
            public bool Subir()
            {
                if (AndarAtual < QuantidadeAndares)
                {
                    AndarAtual++;
                    return true;
                }
                else
                    return false;
            }

            //Desce um andar, caso não esteja no 0 (Térreo).
            public bool Descer()
            {
                if (AndarAtual > 0)
                {
                    AndarAtual--;
                    return true;
                }
                else
                    return false;
            }

            //Informa a quantidade de pessoas no elevador.
            public int Pessoas()
            {
                return PessoasElevador;
            }

            //Informa o andar atual do elevador.
            public int Andar()
            {
                return AndarAtual;
            }
                             

        }

    }

