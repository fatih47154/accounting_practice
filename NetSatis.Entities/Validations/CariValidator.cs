using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("Cari Kodu Alanı Boş Geçilemez.");

            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("Cari Adı Alanı Boş Geçilemez.")
                .Length(5, 15).WithMessage("Cari Adı Alanı 5 Karakter ile 15 Karakter Arasında Olmalıdır.");

            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage("Yetili Kişi Alanı Boş Geçilemez");

            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("Fatura Ünvanı Alanı Boş Geçilemez");

            RuleFor(p => p.Email).EmailAddress().WithMessage("Girdiğiniz E-Mail Adresi Geçersiz.");

            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage("İskontor Oranı Alanı 0'dan Küçük Olamaz");

            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage("Risk Limiti Alanı 0'dan Küçük Olamaz");
        }
    }
}
