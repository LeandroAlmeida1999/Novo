using ConsoleApp2.Enum;
using ConsoleApp2.Product;
using System;

namespace ConsoleApp2.ConcretProducts
{
    public class DocumentPortador : Document
    {
        private readonly string _documentName;
        private DateTime _generateDate;
        private int _ispbOrCnpj;
        private int _countRegister;
        private int _ano;
        private int _trimestre;
        private Produto _produto;
        private Bandeira _bandeira;
        private ModalidadeDoCartao _modalidadeDoCartao;
        private Funcao _funcao;
        private decimal _tarifaDeAnuidadeMinima;
        private decimal _tarifaDeAnuidadeMedia;
        private decimal _tarifaDeAnuidadeMaxima;
        private decimal _desvioPadraoDaTarifaDeAnuidade;
        private long _estoqueDePontosCreditadosNasContasDosPortadores;
        private long _quantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor;
        private long _quantidadeDePontosConvertidos;
        private long _quantidadeDePontosExpirados;
        private decimal _gastoEfetivoDoEmissorComProgramasDeRecompensa;

        private string _header;
        private string _filler;
        public DocumentPortador(int ano, int trimestre)
        {
            this._documentName = "Portador";
            this._ano = ano;
            this._trimestre = trimestre;
            this._generateDate = DateTime.Now;
            this._ispbOrCnpj = 13203354;
            this._countRegister = DAO.DAO.GetQtdArquives();
            this._produto = DAO.DAO.GetProduto();
            this._bandeira = DAO.DAO.GetBandeira();
            this._modalidadeDoCartao = DAO.DAO.GetModalidadeDoCartao();
            this._funcao = DAO.DAO.GetFuncao();
            this._tarifaDeAnuidadeMinima = 000000; //get
            this._tarifaDeAnuidadeMedia = 000000; // get
            this._tarifaDeAnuidadeMaxima = 000000; // get
            this._desvioPadraoDaTarifaDeAnuidade = 500000; // get
            this._estoqueDePontosCreditadosNasContasDosPortadores = 2000000000;
            this._quantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor = 120000000000;
            this._quantidadeDePontosConvertidos = 13000000000000;
            this._quantidadeDePontosExpirados = 15000000000000;
            this._gastoEfetivoDoEmissorComProgramasDeRecompensa = 123456789012;
            this._header = DAO.DAO.TransformarString(_documentName + _generateDate.ToString("dd/MM/yyyy") + _ispbOrCnpj.ToString() + _countRegister.ToString());
            this._filler = DAO.DAO.TransformarString(
                _ano.ToString()
             + _trimestre.ToString()
             + _produto.ToString()
             + _bandeira.ToString()
             + _modalidadeDoCartao.ToString()
             + _funcao.ToString()
             + _tarifaDeAnuidadeMaxima.ToString()
             + _tarifaDeAnuidadeMedia.ToString()
             + _tarifaDeAnuidadeMinima.ToString()
             + _desvioPadraoDaTarifaDeAnuidade.ToString()
             + _estoqueDePontosCreditadosNasContasDosPortadores.ToString()
             + _quantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor.ToString()
             + _quantidadeDePontosExpirados.ToString()
             + _gastoEfetivoDoEmissorComProgramasDeRecompensa.ToString());
        }
        public override string DocumentName
        {
            get { return _documentName; }
        }
        public override int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public override int Trimestre
        {
            get { return _trimestre; }
            set { _trimestre = value; }
        }
        public override DateTime GenerateDate
        {
            get { return _generateDate; }
            set { _generateDate = value; }
        }
        public override int IspbOrCnpj
        {
            get { return _ispbOrCnpj; }
            set { _ispbOrCnpj = value; }
        }
        public override int CountRegisters
        {
            get { return _countRegister; }
            set { _countRegister = value; }
        }
        public override string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        public override string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override Produto Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }
        public override ModalidadeDoCartao ModalidadeDoCartao
        {
            get { return _modalidadeDoCartao; }
            set { _modalidadeDoCartao = value; }
        }
        public override Funcao Funcao
        {
            get { return _funcao; }
            set { _funcao = value; }
        }
        public override decimal TarifaDeAnuidadeMinima
        {
            get { return _tarifaDeAnuidadeMinima; }
            set { _tarifaDeAnuidadeMinima = value; }
        }
        public override decimal TarifaDeAnuidadeMedia
        {
            get { return _tarifaDeAnuidadeMedia; }
            set { _tarifaDeAnuidadeMedia = value; }
        }
        public override decimal TarifaDeAnuidadeMaxima
        {
            get { return _tarifaDeAnuidadeMaxima; }
            set { _tarifaDeAnuidadeMaxima = value; }
        }
        public override decimal DesvioPadraoDaTarifaDeAnuidade
        {
            get { return _desvioPadraoDaTarifaDeAnuidade; }
            set { _desvioPadraoDaTarifaDeAnuidade = value; }
        }
        public override long EstoqueDePontosCreditadosNasContasDosPortadores
        {
            get { return _estoqueDePontosCreditadosNasContasDosPortadores; }
            set { _estoqueDePontosCreditadosNasContasDosPortadores = value; }
        }
        public override long QuantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor
        {
            get { return _quantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor; }
            set { _quantidadeDePontosAdquiridosNoAmbitoDosProgamasDeRecompensaDoEmissor = value; }
        }
        public override long QuantidadeDePontosConvertidos
        {
            get { return _quantidadeDePontosConvertidos; }
            set { _quantidadeDePontosConvertidos = value; }
        }
        public override long QuantidadeDePontosExpirados
        {
            get { return _quantidadeDePontosExpirados; }
            set { _quantidadeDePontosExpirados = value; }
        }
        public override decimal GastoEfetivoDoEmissorComProgramasDeRecompensa
        {
            get { return _gastoEfetivoDoEmissorComProgramasDeRecompensa; }
            set { _gastoEfetivoDoEmissorComProgramasDeRecompensa = value; }
        }
        public override Bandeira Bandeira
        {
            get { return _bandeira; }
            set { _bandeira = value; }
        }
    }
}