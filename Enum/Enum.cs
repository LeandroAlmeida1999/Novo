using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp2.Enum
{
    public enum Produto
    {
        ClassicNacional = 0,
        ClassicInternacional = 1,
        Gold = 2,
        Platinum = 3,
        Infinite = 4,
        Electron = 5,
        StandartNacional = 7,
        StandartInternacional = 8,
        Eletronic = 9,
        Black = 10,
        RedeShopMaestro_MasterCardMaestro = 11,
        Green = 12,
        Blue = 13,
        BlueBox = 14,
        ProfisisonalLiberal = 15,
        ChequeEletronico = 16,
        Corporativo = 17,
        Empresarial = 18,
        Compras = 19,
        Outros = 20
    }
    public enum Bandeira
    {
        Visa = 0,
        MasterCard = 1,
        AmericanExpress = 2,
        DinersClub = 3,
        HiperCard = 4,
        BandeiraPropria = 5,
        ChequeEletronico = 6,
        Elo = 7,
        Outras = 99
    }
    public enum ModalidadeDoCartao
    {
        [Description("")]
        P = 0,
        [Description("")]
        H = 1,
        [Description("")]
        C = 3
    }
    public enum Funcao
    {
        [Description("Débito")]
        D = 0,
        [Description("Crédito")]
        C = 1
    }
    public enum TipoDeContato
    {
        [Description("Diretor de SPB")]
        D = 0 ,
        [Description("TécnicosResponsáveis")]
        T = 1 ,
        [Description("Institucional")]
        I = 2
    }
}
