using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Validations
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).Empty().WithMessage("Depo Kodu Alanı Boş Geçilemez");
            RuleFor(p => p.DepoAdi).Empty().WithMessage("Depo Adı Alanı Boş Geçilemez");
        }
    }
}
