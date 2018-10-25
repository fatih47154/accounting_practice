using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).Empty().WithMessage("Kasa Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.KasaAdi).Empty().WithMessage("Kasa Adı Alanı Boş Geçilemez");
        }
    }
}
