using ConsoleApp2.Enum;
using System;

namespace ConsoleApp2.Product
{
    public abstract class Document
    {
        public abstract string Header { get; set; }
        public abstract string Filler { get; set; }
        public abstract string DocumentName { get; }
        public abstract DateTime GenerateDate { get; set; }
        public abstract int IspbOrCnpj { get; set; }
        public abstract int CountRegisters { get; set; }
        public virtual int CodigoDoParticipanteDoConglomerado { get; set; }
        public virtual string NomeDoParticipanteDoConglomerado { get; set; }
        public abstract int Ano { get; set; }
        public abstract int Trimestre { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Bandeira Bandeira { get; set; }
        public virtual ModalidadeDoCartao ModalidadeDoCartao { get; set; }
        public virtual Funcao Funcao { get; set; }
        public virtual decimal TarifaDeAnuidadeMinima { get; set; }
        public virtual decimal TarifaDeAnuidadeMedia { get; set; }
        public virtual decimal TarifaDeAnuidadeMaxima { get; set; }
        public virtual decimal DesvioPadraoDaTarifaDeAnuidade { get; set; }
        public virtual long EstoqueDePontosCreditadosNasContasDosPortadores { get; set; }
        public virtual long QuantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor { get; set; }
        public virtual long QuantidadeDePontosConvertidos { get; set; }
        public virtual long QuantidadeDePontosExpirados { get; set; }
        public virtual decimal GastoEfetivoDoEmissorComProgramasDeRecompensa { get; set; }
        public virtual decimal ReceitaDaTarifaDeIntercambio { get; set; }
        public virtual decimal ReceitaDeTarifaAosPortadores { get; set; }
        public virtual decimal ReceitaDeIncentivosDeEmissaoEPorFaturamento { get; set; }
        public virtual decimal ReceitaFinanceira { get; set; }
        public virtual decimal ReceitaPorRepassesDeMarketingEPropaganda { get; set; }
        public virtual decimal OutrasReceitasDoEmissor { get; set; }
        public virtual decimal CustoDeGerenciamentoDeRisco { get; set; }
        public virtual decimal DespesasComProcessamento { get; set; }
        public virtual decimal CustoComMarketingEPropaganda { get; set; }
        public virtual decimal CustoComTaxasPagasABandeira { get; set; }
        public virtual decimal CustoComInadimplencia { get; set; }
        public virtual decimal OutrosCustos { get; set; }
        public virtual decimal DespesaComImpostosDiretos { get; set; }
        public virtual decimal CustosComProgramasDeRecompensaEdeRetencaoDeClientes { get; set; }
        public virtual int CountRequestCards { get; set; }
        public virtual int CountActiveCards { get; set; }
        public virtual int MontanteFinanceiroDasTransacoesNacionais { get; set; }
        public virtual int MontanteFinanceiroDasTransacoesInternacionais { get; set; }
        public virtual decimal ValorFinanciadoNoRotativo { get; set; }
        public virtual TipoDeContato Contato { get; set; }
        public virtual string NomeDoContato { get; set; }
        public virtual string Cargo { get; set; }
        public virtual string NumeroDeTelefone { get; set; }
        public virtual string Email { get; set; }

    }
}
