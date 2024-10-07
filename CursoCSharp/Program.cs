using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Execoes;
using CursoCSharp.Api;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Read only - Classes e Metodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação a objetos
                {"Herança - Orientação a objetos", Heranca.Executar},
                {"Construtor This - Orientação a objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a objetos", Abstract.Executar},
                {"Interface - Orientação a objetos", Interface.Executar},
                {"Sealed - Orientação a objetos", Sealed.Executar},

                // Métodos e funções
                {"Lambda - Métodos & funções", ExemploLambda.Executar},
                {"Lambdas Delegate - Métodos & funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos & funções", UsandoDelegates.Executar},
                {"Delegates como funções anônimas - Métodos & funções", DelegateFunAnonima.Executar},
                {"Métodos De Extensão - Métodos & funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}