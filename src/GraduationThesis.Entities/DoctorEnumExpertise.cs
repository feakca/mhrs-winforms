using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.Entities
{
    public enum DoctorEnumExpertise
    {
        [Description("Aile Hekimliği")]
        AileHekimligi = 0,
        [Description("Beyin ve Sinir Cerrahisi")]
        BeyinveSinirCerrahisi = 1,
        [Description("Çocuk Cerrahisi")]
        CocukCerrahisi = 2,
        [Description("Çocuk Sağlığı Hastalıkları")]
        CocukSagligiveHastaliklari = 3,
        [Description("Çocuk ve Ergen Ruh Sağlığı ve Hastalıkları")]
        CocukveErgenRuhSagligiveHastaliklari = 4,
        [Description("Deri ve Zührevi Hastalıklar")]
        DeriveZuhreviHastaliklar = 5,
        [Description("Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji")]
        EnfeksiyonHastaliklariveKlinikMikrobiyoloji = 6,
        [Description("Fiziksel Tıp ve Rehabilitasyon")]
        FizikselTipveRehabilitasyon = 7,
        [Description("Fizyoloji")]
        Fizyoloji = 8,
        [Description("Genel Cerrahi")]
        GenelCerrahi = 9,
        [Description("Göğüs Hastalıkları")]
        GogusHastaliklari = 10,
        [Description("Göz Hastalıkları")]
        GozHastaliklari = 11,
        [Description("İç Hastalıkları")]
        IcHastaliklari = 12,
        [Description("Kadın Hastalıkları ve Doğum")]
        KadinHastaliklariveDogum = 13,
        [Description("Kalp ve Damar Cerrahisi")]
        KalpveDamarCerrahisi = 14,
        [Description("Kardiyoloji")]
        Kardiyoloji = 15,
        [Description("Kulak Burun Boğaz Hastalıkları")]
        KulakBurunBogazHastaliklari = 16,
        [Description("Nöroloji")]
        Noroloji = 17,
        [Description("Ortopedi ve Travmatoloji")]
        OrtopediveTravmatoloji = 18,
        [Description("Plastik Rekonstruktif ve Estetik Cerrahi")]
        PlastikRekonstruktifveEstetikCerrahi = 19,
        [Description("Ruh Sağlığı ve Hastalıkları")]
        RuhSagligiveHastaliklari = 20,
        [Description("Üroloji")]
        Uroloji = 21
    }
}
