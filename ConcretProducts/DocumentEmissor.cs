using ConsoleApp2.Enum;
using ConsoleApp2.Product;
using System;

namespace ConsoleApp2.ConcretProducts
{
    public class DocumentEmissor : Document
    {
        private readonly string _documentName;
        private DateTime _generateDate;
        private int _ispbOrCnpj;
        private int _countRegister;
        private int _codigoDoParticipanteDoConglomerado;
        private string _nomeDoParticipanteDoConglomerado;
        private int _ano;
        private int _trimestre;
        private string _header;
        private string _filler;
        public DocumentEmissor(int ano, int trimestre)
        {
            this._documentName = "Emissor";
            this._ano = ano;
            this._trimestre = trimestre;
            this._generateDate = DateTime.Now;
            this._ispbOrCnpj = 13203354;
            this._countRegister = DAO.DAO.GetQtdArquives();
            this._codigoDoParticipanteDoConglomerado = 13203354;
            this._nomeDoParticipanteDoConglomerado = "FITBANKPAGAMENTOSELETRONICOSSA";
            this._header = DAO.DAO.TransformarString(_documentName + _generateDate.ToString("dd/MM/yyyy") + _ispbOrCnpj.ToString() + _countRegister.ToString());
            this._filler = DAO.DAO.TransformarString(_codigoDoParticipanteDoConglomerado.ToString() + _nomeDoParticipanteDoConglomerado + _ano.ToString() + _trimestre.ToString());
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
        public override int CodigoDoParticipanteDoConglomerado
        {
            get { return _codigoDoParticipanteDoConglomerado; }
            set { _codigoDoParticipanteDoConglomerado = value; }
        }
        public override string NomeDoParticipanteDoConglomerado
        {
            get { return _nomeDoParticipanteDoConglomerado; }
            set { _nomeDoParticipanteDoConglomerado = value; }
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
    }
}